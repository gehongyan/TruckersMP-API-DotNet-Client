﻿using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class ServerSimple
    {
        [JsonProperty("id")] private readonly int _id;
        [JsonProperty("name")] private readonly string _name;

        public int Id => _id;

        public string Name => _name;
    }
}