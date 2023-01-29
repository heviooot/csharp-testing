using System;
namespace TestingTable.Models
{
	public class Sob
    {
        public IEnumerable<SobData> data { get; set; }
    }
    public class SobData
    {
        public object policy_no { get; set; }
        public object pol_end_no { get; set; }
        public DateTime post_date { get; set; }
        public object distribution_code { get; set; }
        public object distribution_name { get; set; }
        public string distribution_type { get; set; }
        public object acting_code { get; set; }
        public object lob_code { get; set; }
        public object pol_office { get; set; }
        public double premium { get; set; }
        public int comm { get; set; }
        public int disc { get; set; }
    }


}

