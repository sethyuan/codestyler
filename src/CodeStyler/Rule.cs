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
using System.Text.RegularExpressions;

namespace Cavingdeep.CodeStyler
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public class Rule
    {
        /// <summary>
        /// 
        /// </summary>
        public Regex ReExpression
        {
            get;
            internal set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Type
        {
            get;
            internal set;
        }
    }
}
