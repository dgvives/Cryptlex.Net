﻿namespace Cryptlex.Net.TrialActivations
{
    public class GetAllTrialActivationsData
    {
        public int? productId { get; set; }
        public int? page { get; set; }
        public int? limit { get; set; }
        public string? sort { get; set; }
        public string? query { get; set; }
    }
}
