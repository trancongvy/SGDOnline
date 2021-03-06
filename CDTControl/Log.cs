using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;

using System.Threading.Tasks;
using CDTLib;

namespace CDTControl
{
    public class Log
    {
        public string log(string companyName, string Product, string code, string _user, string _pass)
        {
            try
            {
                com.phanmemsgd.www1.Service a = new com.phanmemsgd.www1.Service();
                string k = a.GetKeyDirect(companyName, Product, code, _user, _pass);
                return k;
            }
            catch (Exception ex)
            {
                return "Lỗi";
            }
        }
        public string logWeb(string ob)
        {
            string webserver = Config.GetValue("WebServer").ToString();
            string url = webserver + @"Account/LoginfromAPI";
            string sContentType = "application/json";
            HttpContent s = new StringContent(ob, Encoding.UTF8, sContentType);
            HttpClient oHttpClient = new HttpClient();
            try
            {
                Task<HttpResponseMessage> oTaskPostAsync = oHttpClient.PostAsync(url, s);
                if (oTaskPostAsync.Result.StatusCode == HttpStatusCode.BadRequest)
                {
                    return "";
                }
                if (oTaskPostAsync.Result.StatusCode == HttpStatusCode.OK)
                {
                    return oTaskPostAsync.Result.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: true).GetAwaiter()
                        .GetResult();
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
        public bool Check(string user, string pass)
        {
            try
            {
                //Comboserver.Service a = new Comboserver.Service();
                com.sgdsoft.Service a = new com.sgdsoft.Service();
                bool k = a.CheckUserLogin(user, pass);
                return k;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string logFb(string ob)
        {
            string webserver = Config.GetValue("WebServer").ToString();
            string url = webserver + @"api/UserKeys";
           // string url = @"https://localhost:44347/api/UserKeys";
        
            string sContentType = "application/json";

            HttpContent s = new StringContent(ob,Encoding.UTF8, sContentType);

            HttpClient oHttpClient = new HttpClient();
            try
            {
                var oTaskPostAsync = oHttpClient.PostAsync(url, s);

                if (oTaskPostAsync.Result.StatusCode == HttpStatusCode.BadRequest) return "";
                else if (oTaskPostAsync.Result.StatusCode == HttpStatusCode.OK)
                {
                    string s1 = oTaskPostAsync.Result.Content.ReadAsStringAsync().ConfigureAwait(true).GetAwaiter().GetResult() ;
                    return s1;
                }
                else
                { return ""; }
            }
            catch(Exception ex)
            {
                return "";
            }
            return "";
            


        }
        public string GetExDate(string key)
        {
            string webserver = Config.GetValue("WebServer").ToString();
            string url = webserver + @"api/UserKeys";
           //  string url = @"https://localhost:44347/api/UserKeys";

            string sContentType = "application/json";

            //HttpContent s = new StringContent(ob, Encoding.UTF8, sContentType);

            HttpClient oHttpClient = new HttpClient();
            try
            {
                var oTaskPostAsync = oHttpClient.GetAsync(url + @"/?LicenseKey=" + key);
                if(oTaskPostAsync.Result !=null)
                {
                    return  oTaskPostAsync.Result.Content.ReadAsStringAsync().ConfigureAwait(true).GetAwaiter().GetResult(); ;
                }
                
            }
            catch (Exception ex)
            {
                return "";
            }
            return "";



        }
    }
}
