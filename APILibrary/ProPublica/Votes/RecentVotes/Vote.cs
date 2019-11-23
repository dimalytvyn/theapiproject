﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.RecentVotes
{
    public class Vote
    {
        public int congress { get; set; }
        public string chamber { get; set; }
        public int session { get; set; }
        public int roll_call { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string vote_uri { get; set; }
        public Bill bill { get; set; }
        public Amendment amendment { get; set; }
        public string question { get; set; }
        public string description { get; set; }
        public string vote_type { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string result { get; set; }
        public Democratic democratic { get; set; }
        public Republican republican { get; set; }
        public Independent independent { get; set; }
        public Total total { get; set; }
    }
}
