﻿using System.Collections.Generic;

namespace NextLevelSeven.Core
{
    /// <summary>
    ///     Represents an abstract element in an HL7 message.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        ///     Get a sub-element at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Sub-element at the specified index.</returns>
        IElement this[int index] { get; }

        /// <summary>
        ///     Interpret the stored value as other types.
        /// </summary>
        IEncodedTypeConverter As { get; }

        /// <summary>
        ///     Get the delimiter character of the element. This will be zero if there are no sub-elements.
        /// </summary>
        char Delimiter { get; }

        /// <summary>
        ///     Get the index of the element.
        /// </summary>
        int Index { get; }

        /// <summary>
        ///     Get or set the complete value of the element.
        /// </summary>
        string Value { get; set; }

        /// <summary>
        ///     Get the number of subvalues in the element.
        /// </summary>
        int ValueCount { get; }

        /// <summary>
        ///     Get or set the subvalues of the element.
        /// </summary>
        IEnumerable<string> Values { get; set; }

        /// <summary>
        ///     Get a copy of the element.
        /// </summary>
        IElement Clone();
    }
}