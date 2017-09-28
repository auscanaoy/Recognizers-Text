﻿using System.Collections.Immutable;
using System.Globalization;
using Microsoft.Recognizers.Definitions.Spanish;

namespace Microsoft.Recognizers.Text.NumberWithUnit.Spanish
{
    public class TemperatureExtractorConfiguration : SpanishNumberWithUnitExtractorConfiguration
    {
        public TemperatureExtractorConfiguration() : this(new CultureInfo(Culture.Spanish)) { }

        public TemperatureExtractorConfiguration(CultureInfo ci) : base(ci) { }

        public override ImmutableDictionary<string, string> SuffixList => TemperatureSuffixList;

        public override ImmutableDictionary<string, string> PrefixList => null;

        public override ImmutableList<string> AmbiguousUnitList => null;

        public override string ExtractType => Constants.SYS_UNIT_TEMPERATURE;

        public static readonly ImmutableDictionary<string, string> TemperatureSuffixList = NumbersWithUnitDefinitions.TemperatureSuffixList.ToImmutableDictionary();
    }
}