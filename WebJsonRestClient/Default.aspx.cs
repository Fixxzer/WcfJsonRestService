using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace WebJsonRestClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_OnClick(object sender, EventArgs e)
        {
            string url = string.Format("http://localhost:8732/service1/data/{0}", txtInputValue.Text);
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            JsonSerializer jsonSerializer = new JsonSerializer();//typeof(Person));
            string jsonResponse;
            Stream responseStream = response.GetResponseStream();
            if (responseStream == null)
            {
                throw new Exception("Could not get a response from REST service");
            }
            using (TextReader sr = new StreamReader(responseStream))
            {
                JsonTextReader reader = new JsonTextReader(sr);
                Person person = jsonSerializer.Deserialize<Person>(reader);

                Response.Write(string.Format("Person ID: {0}\r\nPerson Name: {1}", person.Id, person.Name));
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}