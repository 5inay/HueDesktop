using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace HueDesktop
{
    public sealed class RESTRequests
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string ourIP;
        private JavaScriptSerializer jss = new JavaScriptSerializer();
        

        public RESTRequests(string mainIP)
        {
            ourIP = "http://" + mainIP;
        }

        public async Task<string> POST(string addendum, string body, Encoding e, string type)
        {
            string postEndpoint = ourIP + addendum;
            StringContent content = new StringContent(body, e, type);
            HttpResponseMessage response = await client.PostAsync(postEndpoint, content);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";
        }

        public async Task<string> GET(string addendum)
        {
            string getEndpoint = ourIP + addendum;
            
            try
            {
                HttpResponseMessage response = await client.GetAsync(getEndpoint);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }

            return "";
        }

        public async Task<string> PUT(string addendum, string body, Encoding e, string type)
        {
            string putEndpoint = ourIP + addendum;
            StringContent content = new StringContent(body, e, type);
            HttpResponseMessage response = await client.PutAsync(putEndpoint, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";
        }


        public async Task<string> DELETE(string addendum, CancellationToken ct)
        {
            string deleteEndpoint = ourIP + addendum;
            HttpResponseMessage response = await client.DeleteAsync(deleteEndpoint, ct);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";
        }
    }
}
