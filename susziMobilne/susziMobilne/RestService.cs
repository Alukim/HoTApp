using Newtonsoft.Json;
using susziMobilne;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using susziMobilne.Model;

namespace susziMobilne
{
   
    public class RestService:IRestService
    {
        HttpClient client;
        public event EventHandler<Test> CheckUserCompleted;
        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }


        //web api test
        public async Task<string>  CheckUser(string login,string password)
        {
            string items = null;
            var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<string>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }


            //CheckUserCompleted.Invoke(this, new Test(true));

            return items;
        }

        public async Task<User> GetUser(string login, string password)
        {
            User user = new User();
            var uri = new Uri(string.Format(Constants.RestUrl + string.Format("login{0}&password{1}", login, password),
                string.Empty));
         
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<User>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
                return null;
            }

            return user;
        }
    }
}
