﻿using Newtonsoft.Json;

namespace SonyControlCamera.RemoteApi.System
{
    public class TimeOffset
    {
        [JsonProperty("dateTime")]
        public string DateTime { set; get; }

        [JsonProperty("timeZoneOffsetMinute")]
        public int TimeZoneOffsetMinute { set; get; }

        [JsonProperty("dstOffsetMinute")]
        public int DstOffsetMinute { set; get; }
    }
}
