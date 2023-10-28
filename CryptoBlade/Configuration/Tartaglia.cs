﻿namespace CryptoBlade.Configuration
{
    public class Tartaglia
    {
        public double StandardDeviationLong { get; set; } = 1.0;

        public double StandardDeviationShort { get; set; } = 1.0;

        public int ChannelLengthLong { get; set; } = 100;

        public int ChannelLengthShort { get; set; } = 100;

        public decimal MinReentryPositionDistanceLong { get; set; } = 0.02m;

        public decimal MinReentryPositionDistanceShort { get; set; } = 0.02m;
    }
}