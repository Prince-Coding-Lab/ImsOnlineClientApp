using System;
using System.Collections.Generic;
using System.Text;

namespace ImsClientApp
{
   public class Company
    {
        public int company_id { get; set; }
        public string company_name { get; set; }
        public string company_email { get; set; }
        public string company_type { get; set; }
        public string company_income { get; set; }
        public string company_address { get; set; }
        public string company_city { get; set; }
        public string company_country { get; set; }
        public string company_phone { get; set; }
        public string company_logo { get; set; }
        public string company_industry { get; set; }
        public DateTime? company_created_date { get; set; }
        public string company_created_by { get; set; }
        public string company_modifed_by { get; set; }
        public DateTime? company_modifed_date { get; set; }

    }
}
