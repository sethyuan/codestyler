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
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Cavingdeep.CodeStyler
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public class RuleSet : List<Rule>
    {
        /// <summary>
        /// 
        /// </summary>
        public const char SubRuleSplitter = '.';

        private const char SplitterChar = ':';

        private Dictionary<string, RuleSet> compositeRules;

        /// <summary>
        ///
        /// </summary>
        public RuleSet() : base(6)
        {
            this.compositeRules = new Dictionary<string, RuleSet>(3);
        }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, RuleSet> CompositeRules
        {
            get
            {
                return this.compositeRules;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static RuleSet LoadFromFile(string file)
        {
            return LoadFromFile(file, Encoding.Default);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileEncoding"></param>
        /// <returns></returns>
        public static RuleSet LoadFromFile(string file, Encoding fileEncoding)
        {
            if (string.IsNullOrEmpty(file))
            {
                throw new ArgumentNullException("file");
            }

            if (fileEncoding == null)
            {
                fileEncoding = Encoding.Default;
            }

            using (FileStream stream = new FileStream(file, FileMode.Open))
            {
                return LoadFromStream(stream, fileEncoding);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static RuleSet LoadFromStream(Stream stream, Encoding encoding)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            if (encoding == null)
            {
                encoding = Encoding.Default;
            }

            RuleSet ruleSet = new RuleSet();

            using (StreamReader reader = new StreamReader(stream, encoding))
            {
                string line;
                int lineCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;

                    if (line.Length == 0)
                    {
                        continue;
                    }

                    AddRule(ruleSet, line, lineCount);
                }
            }

            return ruleSet;
        }

        private static void AddRule(RuleSet ruleSet, string line, int lineCount)
        {
            int splitterCharIndex = line.IndexOf(SplitterChar);

            if (splitterCharIndex < 0)
            {
                throw new BadRuleException(
                    string.Format("No splitter found at {0}.", lineCount));
            }

            string ruleType = line.Substring(0, splitterCharIndex);
            string ruleExpression = line.Substring(splitterCharIndex + 1);

            int subRuleSplitterIndex = ruleType.IndexOf(SubRuleSplitter);

            if (subRuleSplitterIndex > -1)
            {
                string leftType = ruleType.Substring(0, subRuleSplitterIndex);
                string rightType = ruleType.Substring(subRuleSplitterIndex + 1);

                if (!ruleSet.CompositeRules.ContainsKey(leftType))
                {
                    ruleSet.CompositeRules.Add(leftType, new RuleSet());
                }

                ruleSet.CompositeRules[leftType].Add(
                    new Rule()
                    {
                        Type = ruleType,
                        ReExpression = new Regex(ruleExpression, RegexOptions.Singleline)
                    });
            }
            else
            {
                Rule rule = new Rule()
                {
                    Type = ruleType,
                    ReExpression = new Regex(ruleExpression, RegexOptions.Singleline)
                };

                ruleSet.Add(rule);
            }
        }
    }
}
