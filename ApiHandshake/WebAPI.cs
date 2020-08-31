//using CompareHelper.RequestObjects;
using RestSharp;
using System;

namespace ApiHandshake
{
    public static class WebAPI<T, TR> where TR : class
    {
        public static ItemResponseObj<T> Consume(string endPoint, TR regObj, string username)
        {
            var response = new ItemResponseObj<T>()
            {
                IsSuccess = false
            };
            try
            {
                var apiResponse = new ServiceCall(endPoint, username, Method.POST).ProcessAPI<TR, ItemResponseObj<T>>(regObj, out var msg);
                if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
                {
                    return apiResponse;
                }
                response.Message = msg.Message;
                return response;
            }
            catch (Exception ex)
            {
                //UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
                response.Message = "Error: " + ex.GetBaseException().Message;
                return response;
            }
        }
    }
}
