using System;
using SharedProject.Generic.BaseClasses;
using SharedProject.Generic.Interfaces;
using NativeReferenceApp.Services;
using System.Threading.Tasks;

namespace NativeReferenceApp.Adapters
{
    public class NRADummyAdapter : NRAAdapter
    {
        public NRADummyAdapter(IHttpService httpService, IDbService dbService)
            : base(httpService, dbService)
        {
        }

        public void DummyFunction()
        {

            var httpService = _httpService as NRADummyService;
            httpService.DummyHttpFunction();

            var dbService = _dbService as NRADBService;
            dbService.DummyDBFunction();


        }

        public async Task<string> RetrieveNameAsync()
        {

            var httpService = _httpService as NRADummyService;
            var str = await httpService.RetrieveNameAsync();
            Console.WriteLine(str);
            return str;

        }

    }
}
