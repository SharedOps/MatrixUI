using Newtonsoft.Json;
using System.Collections.Generic;

namespace MatrixWebApi.CrossCutting
{
    public static class ResponseUtility
    {
        private const string Success = "Request was successfull";

        private const string UnSuccessfull = "Request was unsuccessfull";

        public static Response CreateResponse<T>(T response, bool isSuccessful = true)
        {
            return new Response
            {
                Message = isSuccessful ? Success : UnSuccessfull,
                Success = isSuccessful,
                Result = !EqualityComparer<T>.Default.Equals(response, default(T)) ? JsonConvert.SerializeObject(response) : null
            };
        }
    }
}