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
using Cavingdeep.Dcg.At;

namespace Cavingdeep.CodeStyler
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public class Styler
    {
        private RuleSet rules;
        private IAtTemplate styleTemplate;

        /// <summary>
        /// 
        /// </summary>
        public RuleSet RuleSet
        {
            get
            {
                return this.rules;
            }

            set
            {
                this.rules = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IAtTemplate StyleTemplate
        {
            get
            {
                return this.styleTemplate;
            }

            set
            {
                this.styleTemplate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string StyleCode(string code)
        {
            if (this.rules == null)
            {
                throw new InvalidOperationException("RuleSet is still not set.");
            }

            if (this.styleTemplate == null)
            {
                throw new InvalidOperationException("StyleTemplate is still not set.");
            }

            if (string.IsNullOrEmpty(code))
            {
                return code;
            }

            if (string.IsNullOrEmpty(this.styleTemplate.SourceCode))
            {
                this.styleTemplate.Parse();
            }

            this.styleTemplate.Context = new object[] { new Tokenizer(code, this.rules) };

            return this.styleTemplate.Render();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codeFile"></param>
        /// <returns></returns>
        public string StyleFile(string codeFile)
        {
            return StyleFile(codeFile, Encoding.Default);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codeFile"></param>
        /// <param name="codeFileEncoding"></param>
        /// <returns></returns>
        public string StyleFile(string codeFile, Encoding codeFileEncoding)
        {
            if (string.IsNullOrEmpty(codeFile))
            {
                throw new ArgumentNullException("codeFile");
            }

            if (codeFileEncoding == null)
            {
                codeFileEncoding = Encoding.Default;
            }

            string code;
            using (StreamReader reader = new StreamReader(codeFile, codeFileEncoding))
            {
                code = reader.ReadToEnd();
            }
            return StyleCode(code);
        }
    }
}
