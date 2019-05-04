using System.Web.Http;

namespace MatrixWebApi.IOC
{
    public class BootStrapper
    {
        public static void Run()
        {
           //Configure AutoFac  
            IOCModule.Initialize(GlobalConfiguration.Configuration);
        }
    }
}