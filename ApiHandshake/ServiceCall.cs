//using CompareHelper.Request;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHandshake
{
    internal class ServiceCall
    {
        protected RestClient _client;
        protected RestRequest _request;

        private readonly string _username;
        private readonly string _serviceUri;
        private readonly Method _method;

        //public RemoteCore(string endpoint, Method method);
        //public RemoteCore(string endpoint, string auth, Method method);

        public void ReInit(string endpoint, string auth, Method method)
        {
            //authenticate and get username
            //string username = "";//whatever logic
            //APIHelper(endpoint,  username,  method);
        }
        public ServiceCall(string serviceUri, string username, Method method)
        {
            _username = username;
            _serviceUri = serviceUri;
            _method = method;
            _client = new RestClient(new ApiRequests().GetBaseUrl());
            _request = new RestRequest(serviceUri, method);
        }
        public ServiceCall(string endpoint, Method method)
        {
            _serviceUri = endpoint;
            _method = method;
        }
        public TR ProcessAPI<T, TR>(T serviceObj, out APIOutMessage msg) where T : class where TR : new()
        {
            try
            {
                _request.AddJsonBody(serviceObj);
                var apiResponse = _client.Execute(_request);
                var responseCode = (int)apiResponse.StatusCode;
                msg.Code = responseCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                  //var deserializedResponse = new RequestResponseHelper().Deserialize<TR>(apiResponse, null, out msg.TechMessage);
                    var deserializedResponse = ServiceCallResponse.Deserialize<TR>(apiResponse, null, out msg.TechMessage);
                    if (deserializedResponse == null)
                    {
                        msg.Message = "cannot process server response. Please check transaction status";
                        msg.Code = -1;
                        return default;
                    }

                    msg.Message = "";
                    msg.TechMessage = "";
                    msg.Code = 0;
                    return deserializedResponse;
                }

                if (msg.Code == 400)
                {
                    msg.Message = "Validation error occurred! At least one of the supplied data is invalid";
                    msg.Code = -4;
                    msg.TechMessage = apiResponse.Content + " " + apiResponse.ErrorMessage;
                    return default;
                }

                if (msg.Code == 401)
                {
                    //if (!GlobalTokenParam.RefreshTokenDirect(_username))
                    //{
                    //    msg.Message = "We are unable to complete your request at this time due to system authorization error. Please try again later";
                    //    msg.Code = -3;
                    //    msg.TechMessage = "Authorization Failed";
                    //    return default;
                    //}

                    //Re-Initialize and invoke the service again
                    ReInit(_serviceUri, _username, _method);
                    apiResponse = _client.Execute(_request);
                    responseCode = (int)apiResponse.StatusCode;
                    msg.Code = responseCode;
                    if (responseCode < 200 || responseCode >= 300)
                    {
                        //Other HttpStatusCode returned
                        msg.Message = "we cannot fulfill this request at the moment. Please try again later";
                        msg.TechMessage = "Authorization Failed";
                        return default;
                    }

                    var deserializedResponse = ServiceCallResponse.Deserialize<TR>(apiResponse, null, out msg.TechMessage);
                    if (deserializedResponse == null)
                    {
                        msg.Message = "cannot process server response. Please check transaction status";
                        msg.Code = -1;
                        return default;
                    }

                    msg.Message = "";
                    msg.TechMessage = "";
                    msg.Code = 0;
                    return deserializedResponse;
                }

                msg.Message = "we cannot fulfill this request at the moment. Please try again later";
                msg.TechMessage = "Other Http Status Code";
                return default;
            }
            catch (Exception ex)
            {
                //UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
                msg.TechMessage = ex.GetBaseException().Message;
                msg.Message = "we cannot fulfill this request at the moment. Please try again later";
                msg.Code = -2;
                return default;
            }
        }
    }
}
