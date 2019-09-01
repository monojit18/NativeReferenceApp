using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace NativeReferenceApp.Services
{

    public class NRADummyService : NRAHttpService
    {
        public NRADummyService()
        {
        }

        public void DummyHttpFunction()
        {



        }

        public async Task<string> RetrieveNameAsync()
        {

            var cl = new HttpClient();
            var str = await cl.GetStringAsync("https://www.google.com");
            return str;

        }
    }
}
