using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ImsClientApp
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            List<Company> companies = await GetCompanyiesAsync("https://localhost:44378/api/company/getall");
            foreach (var item in companies)
            {
                Console.WriteLine(string.Format("company_id:{0}, company_name:{1}, company_email:{2}",
                    item.company_id,item.company_name,item.company_email));
            }
            Console.ReadLine();
        }
        static async Task<List<Company>> GetCompanyiesAsync(string path)
        {
            List<Company> companies = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsAsync<OperationResponse>();
            
                if (res.ReturnedObject != null)
                    companies =   new JavaScriptSerializer().Deserialize<List<Company>>(res.ReturnedObject.ToString());
            }
            return companies;
        }
    }
}
