﻿using System.Diagnostics.CodeAnalysis;
using System.Text;
using NextLevelSeven.Core.Encoding;

namespace NextLevelSeven.Building.Elements
{
    /// <summary>An encoding configuration wrapper that redirects character properties from a MessageBuilder.</summary>
    internal sealed class BuilderEncodingConfiguration : ReadOnlyEncodingConfiguration, IEncoding
    {
        /// <summary>Builder to pull characters from.</summary>
        private readonly Builder _builder;

        /// <summary>Create an encoding configuration from a message or segment.</summary>
        /// <param name="builder">Message builder to pull the characters from.</param>
        public BuilderEncodingConfiguration(Builder builder)
        {
            _builder = builder;
        }

        char IEncoding.ComponentDelimiter
        {
            get => _builder.ComponentDelimiter;
            set => _builder.ComponentDelimiter = value;
        }

        char IEncoding.EscapeCharacter
        {
            get => _builder.EscapeCharacter;
            set => _builder.EscapeCharacter = value;
        }

        char IEncoding.FieldDelimiter
        {
            get => _builder.FieldDelimiter;
            set => _builder.FieldDelimiter = value;
        }

        char IEncoding.RepetitionDelimiter
        {
            get => _builder.RepetitionDelimiter;
            set => _builder.RepetitionDelimiter = value;
        }

        char IEncoding.SubcomponentDelimiter
        {
            get => _builder.SubcomponentDelimiter;
            set => _builder.SubcomponentDelimiter = value;
        }

        public override Encoding CharacterEncoding
        {
            get => Msh18EncodingMap.GetEncoding(_builder?.Message?[18]?.Value);
            [ExcludeFromCodeCoverage] protected set { }
        }

        public override char ComponentDelimiter
        {
            get => _builder.ComponentDelimiter;
            [ExcludeFromCodeCoverage] protected set { }
        }

        public override char EscapeCharacter
        {
            get => _builder.EscapeCharacter;
            [ExcludeFromCodeCoverage] protected set { }
        }

        public override char FieldDelimiter
        {
            get => _builder.FieldDelimiter;
            [ExcludeFromCodeCoverage] protected set { }
        }

        public override char RepetitionDelimiter
        {
            get => _builder.RepetitionDelimiter;
            [ExcludeFromCodeCoverage] protected set { }
        }

        public override char SubcomponentDelimiter
        {
            get => _builder.SubcomponentDelimiter;
            [ExcludeFromCodeCoverage] protected set { }
        }
    }
}