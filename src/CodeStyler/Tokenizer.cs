/*
 *  Code Styler
 *  Copyright (C) 2008 Wei Yuan
 *
 *  This library is free software; you can redistribute it and/or modify it
 *  under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation; either version 2.1 of the License, or (at
 *  your option) any later version.
 *
 *  This library is distributed in the hope that it will be useful, but
 *  WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 *  or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public
 *  License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with this library; if not, write to the Free Software Foundation,
 *  Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
 *
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cavingdeep.CodeStyler
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    internal class Tokenizer : IEnumerable<Token>
    {
        private string code;
        private RuleSet rules;
        private SortedDictionary<int, TypeToken> typeTokens =
            new SortedDictionary<int, TypeToken>();

        /// <summary>
        ///
        /// </summary>
        public Tokenizer(string code, RuleSet rules)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new ArgumentNullException("code");
            }

            if (rules == null)
            {
                throw new ArgumentNullException("rules");
            }

            this.code = code;
            this.rules = rules;

            Parse();
        }

        #region IEnumerable<Token> Members

        public IEnumerator<Token> GetEnumerator()
        {
            int prevTokenEndPos = 0;

            foreach (TypeToken typeToken in this.typeTokens.Values)
            {
                yield return new Token(
                    this.code.Substring(prevTokenEndPos, (typeToken.Position - prevTokenEndPos)),
                    "_plain_");

                prevTokenEndPos = typeToken.Position + typeToken.Length;

                yield return new Token(
                    typeToken.Text,
                    typeToken.Type);
            }

            yield return new Token(this.code.Substring(prevTokenEndPos), "_plain_");
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        private void Parse()
        {
            ParseRules(this.rules, this.code, 0, "");
        }

        private void ParseRules(RuleSet rules, string text, int startPosition, string parentType)
        {
            foreach (Rule rule in rules)
            {
                text = rule.ReExpression.Replace(
                    text,
                    match =>
                    {
                        if (match.Groups.Count == 1)
                        {
                            return ParseNormalRule(match, rule, startPosition);
                        }
                        else
                        {
                            return ParseGroupedRule(match, rule, startPosition, parentType);
                        }
                    });
            }
        }

        private string ParseNormalRule(Match match, Rule rule, int startPosition)
        {
            if (this.rules.CompositeRules.ContainsKey(rule.Type))
            {
                ParseRules(
                    this.rules.CompositeRules[rule.Type],
                    match.Value,
                    match.Index,
                    rule.Type + RuleSet.SubRuleSplitter);
            }
            else
            {
                this.typeTokens.Add(
                    startPosition + match.Index,
                    new TypeToken()
                    {
                        Position = startPosition + match.Index,
                        Length = match.Length,
                        Type = rule.Type,
                        Text = match.Value
                    });
            }

            return new String(' ', match.Length);
        }

        private string ParseGroupedRule(Match match, Rule rule, int startPosition, string parentType)
        {
            Group matchGroup = null;
            string matchType = null;

            for (int i = 1; i < match.Groups.Count; i++)
            {
                if (match.Groups[i].Success)
                {
                    matchGroup = match.Groups[i];
                    matchType = rule.ReExpression.GroupNameFromNumber(i);
                    break;
                }
            }

            if (matchGroup == null || matchType == null)
            {
                throw new InvalidProgramException(
                    "An impossible error except that there is a rule badly written.");
            }

            if (this.rules.CompositeRules.ContainsKey(matchType))
            {
                ParseRules(
                    this.rules.CompositeRules[matchType],
                    matchGroup.Value,
                    matchGroup.Index,
                    matchType + RuleSet.SubRuleSplitter);
            }
            else
            {
                this.typeTokens.Add(
                    startPosition + matchGroup.Index,
                    new TypeToken()
                    {
                        Position = startPosition + matchGroup.Index,
                        Length = matchGroup.Length,
                        Type = parentType + matchType,
                        Text = matchGroup.Value
                    });
            }

            return new String(' ', matchGroup.Length);
        }
    }
}
