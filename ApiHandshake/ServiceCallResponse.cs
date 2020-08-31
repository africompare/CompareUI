using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHandshake
{
    public static class ServiceCallResponse
    {
        //public RequestResponseHelper()
        //{
        //}
        //public static T ConvertJsonToObject<T>(string json, string rootElement, out string msg) where T : new() {
        //}
        //public T ConvertJsonToObject<T>(string json, out string msg) where T : new() {
        //}
        //public T Deserialize<T>(JsonReader reader) where T : class
        //{
        //    return (T)Deserialize(reader, typeof(T));
        //}  
        //internal TR Deserialize<TR>(IRestResponse apiResponse, object p, out string techMessage) where TR : new()
        //{
        //    techMessage = "";
        //    return new TR();
        //}
        public static T Deserialize<T>(IRestResponse apiResponse, object p, out string msg) where T : new()
        {
            //using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(apiResponse.Content)))
            //{
            try
            {
                msg = "";
                var objData = JsonConvert.DeserializeObject<T>(apiResponse.Content);
                //var objData1 = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(apiResponse.Content);
                //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                //(T)serializer.ReadObject(ms);
                return objData;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return default(T);
            }
            //}
        }
        //public static T JsonDeserialize<T>(string jsonString)
        //{
        //    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
        //    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
        //    T obj = (T)ser.ReadObject(ms);
        //    return obj;
        //}
        //public static T Deserialize<T>(IRestResponse response, string rootElement, out string msg) where T : new() {
        //    msg = "";
        //    return new T();
        //}

        //public T DeserializeStream<T>(string content, string rootElement, out string msg) where T : new() { 
        //}
        //public string GetAuthorizationHeader(string username, string password) { 
        //}
        //public RequestException ReadRequestException(IRestResponse response) { 

        //}

    }

}
