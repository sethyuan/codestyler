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
using Cavingdeep.Dcg.At;
using System.IO;
using System.Text;

namespace Cavingdeep.CodeStyler
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public static class DefaultStyles
    {
        static DefaultStyles()
        {
            string text;

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.CSharp_Html.template")))
            {
                text = reader.ReadToEnd();
            }
            CSharpHtml = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.CSharp_Html_Line.template")))
            {
                text = reader.ReadToEnd();
            }
            CSharpHtmlLine = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Css_Html.template")))
            {
                text = reader.ReadToEnd();
            }
            CssHtml = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Css_Html_Line.template")))
            {
                text = reader.ReadToEnd();
            }
            CssHtmlLine = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.JavaScript_Html.template")))
            {
                text = reader.ReadToEnd();
            }
            JavaScriptHtml = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.JavaScript_Html_Line.template")))
            {
                text = reader.ReadToEnd();
            }
            JavaScriptHtmlLine = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Xml_Html.template")))
            {
                text = reader.ReadToEnd();
            }
            XmlHtml = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Xml_Html_Line.template")))
            {
                text = reader.ReadToEnd();
            }
            XmlHtmlLine = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Html_Html.template")))
            {
                text = reader.ReadToEnd();
            }
            HtmlHtml = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Html_Html_Line.template")))
            {
                text = reader.ReadToEnd();
            }
            HtmlHtmlLine = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.At_Html.template")))
            {
                text = reader.ReadToEnd();
            }
            AtHtml = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.At_Html_Line.template")))
            {
                text = reader.ReadToEnd();
            }
            AtHtmlLine = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Python_Html.template")))
            {
                text = reader.ReadToEnd();
            }
            PythonHtml = new AtTemplate(text, "v2.0");

            using (StreamReader reader = new StreamReader(
                typeof(DefaultStyles).Assembly.GetManifestResourceStream(
                    "Cavingdeep.CodeStyler.StyleTemplates.Python_Html_Line.template")))
            {
                text = reader.ReadToEnd();
            }
            PythonHtmlLine = new AtTemplate(text, "v2.0");
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate CSharpHtml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate CSharpHtmlLine
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate CssHtml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate CssHtmlLine
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate JavaScriptHtml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate JavaScriptHtmlLine
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate XmlHtml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate XmlHtmlLine
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate HtmlHtml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate HtmlHtmlLine
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate AtHtml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate AtHtmlLine
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate PythonHtml
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IAtTemplate PythonHtmlLine
        {
            get;
            private set;
        }
    }
}
