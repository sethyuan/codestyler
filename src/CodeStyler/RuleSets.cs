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
using System.IO;
using System.Text;

namespace Cavingdeep.CodeStyler
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public static class RuleSets
    {
        static RuleSets()
        {
            using (Stream stream = typeof(RuleSets).Assembly.GetManifestResourceStream(
                        "Cavingdeep.CodeStyler.Rules.CSharp.rule"))
            {
                CSharp = RuleSet.LoadFromStream(stream, Encoding.Default);
            }

            using (Stream stream = typeof(RuleSets).Assembly.GetManifestResourceStream(
                        "Cavingdeep.CodeStyler.Rules.Css.rule"))
            {
                Css = RuleSet.LoadFromStream(stream, Encoding.Default);
            }

            using (Stream stream = typeof(RuleSets).Assembly.GetManifestResourceStream(
                        "Cavingdeep.CodeStyler.Rules.JavaScript.rule"))
            {
                JavaScript = RuleSet.LoadFromStream(stream, Encoding.Default);
            }

            using (Stream stream = typeof(RuleSets).Assembly.GetManifestResourceStream(
                        "Cavingdeep.CodeStyler.Rules.Xml.rule"))
            {
                Xml = RuleSet.LoadFromStream(stream, Encoding.Default);
            }

            using (Stream stream = typeof(RuleSets).Assembly.GetManifestResourceStream(
                        "Cavingdeep.CodeStyler.Rules.Html.rule"))
            {
                Html = RuleSet.LoadFromStream(stream, Encoding.Default);
            }

            using (Stream stream = typeof(RuleSets).Assembly.GetManifestResourceStream(
                        "Cavingdeep.CodeStyler.Rules.At.rule"))
            {
                At = RuleSet.LoadFromStream(stream, Encoding.Default);
            }

            using (Stream stream = typeof(RuleSets).Assembly.GetManifestResourceStream(
                        "Cavingdeep.CodeStyler.Rules.Python.rule"))
            {
                Python = RuleSet.LoadFromStream(stream, Encoding.Default);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleSet CSharp
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleSet Css
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleSet JavaScript
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleSet Xml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleSet Html
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleSet At
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleSet Python
        {
            get;
            private set;
        }
    }
}
