using System;
using System.Threading.Tasks;
using SharedProject.Generic.BaseClasses;
using NativeReferenceApp.Adapters;
using NativeReferenceApp.Services;

namespace NativeReferenceApp.ViewModels
{

    public class NRAViewModel : ViewModelBase
    {

        public NRAViewModel()
        {
        }

        public void DummyFunction()
        {

            var httpService = new NRADummyService();
            var dbService = new NRADBService();

            var adapter = new NRADummyAdapter(httpService, dbService);
            adapter.DummyFunction();


        }

        public async Task RetrieveNameAsync()
        {

            var httpService = new NRADummyService();
            var adapter = new NRADummyAdapter(httpService, null);
            var str = await adapter.RetrieveNameAsync();
            Notify.Invoke(str);

        }

    }
}
