﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.RecentExplanations
{
    public class Result
    {
        public string member_id { get; set; }
        public string api_uri { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public int year { get; set; }
        public int roll_call { get; set; }
        public string party { get; set; }
        public string date { get; set; }
        public string url { get; set; }
        public string text { get; set; }
        public string category { get; set; }
        public bool parsed { get; set; }
        public string vote_api_uri { get; set; }
    }
}