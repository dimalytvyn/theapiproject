﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.SearchBills
{
    public class Bill
    {
        public string bill_id { get; set; }
        public string bill_type { get; set; }
        public string number { get; set; }
        public string bill_uri { get; set; }
        public string title { get; set; }
        public string sponsor_title { get; set; }
        public string sponsor_id { get; set; }
        public string sponsor_name { get; set; }
        public string sponsor_state { get; set; }
        public string sponsor_party { get; set; }
        public string sponsor_uri { get; set; }
        public string gpo_pdf_uri { get; set; }
        public string congressdotgov_url { get; set; }
        public string govtrack_url { get; set; }
        public string introduced_date { get; set; }
        public bool active { get; set; }
        public string house_passage { get; set; }
        public string senate_passage { get; set; }
        public string enacted { get; set; }
        public object vetoed { get; set; }
        public int cosponsors { get; set; }
        public string committees { get; set; }
        public List<string> committee_codes { get; set; }
        public List<object> subcommittee_codes { get; set; }
        public string primary_subject { get; set; }
        public string summary { get; set; }
        public string summary_short { get; set; }
        public string latest_major_action_date { get; set; }
        public string latest_major_action { get; set; }
    }
}