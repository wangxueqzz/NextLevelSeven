﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NextLevelSeven.Utility;

namespace NextLevelSeven.Building
{
    public interface IBuilder
    {
        /// <summary>
        ///     Get the number of subcomponents in this component, including subcomponents with no content.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Get or set the content string.
        /// </summary>
        string Value { get; set; }

        /// <summary>
        ///     Get or set content within this component.
        /// </summary>
        IEnumerableIndexable<int, string> Values { get; }

        /// <summary>
        ///     Get or set the character used to separate component-level content.
        /// </summary>
        char ComponentDelimiter { get; set; }

        /// <summary>
        ///     Get or set the character used to signify escape sequences.
        /// </summary>
        char EscapeDelimiter { get; set; }

        /// <summary>
        /// Get or set the character used to separate fields.
        /// </summary>
        char FieldDelimiter { get; set; }

        /// <summary>
        ///     Get or set the character used to separate field repetition content.
        /// </summary>
        char RepetitionDelimiter { get; set; }

        /// <summary>
        ///     Get or set the character used to separate subcomponent-level content.
        /// </summary>
        char SubcomponentDelimiter { get; set; }
    }
}
