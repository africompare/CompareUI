using System;
using System.Collections.Generic;
using System.Text;

namespace CompareHelper.Endpoints
{
        public static class SharedEndpoints
        {
            public const string SignIn = "CompareService/Login";
            public const string Register = "compareservice/register";// "/compareservice​/register";
            public const string ResetPassword = "CompareService/PasswordReset";
        }
        internal class VendorEndpoints
        {
            internal const string ADD_PRODUCT_ENDPOINT = "/CompareService/AddProduct";
            internal const string UPDATE_PRODUCT_ENDPOINT = "/CompareService/UpdateProduct";
            internal const string DELETE_PRODUCT_ENDPOINT = "/CompareService/DeleteProduct";
            internal const string LOAD_PRODUCTS_ENDPOINT = "/CompareService/LoadProducts"; 
        }
        internal class CustomerEndpoints
        {
            internal const string GET_QUOTES = "/CompareService/GetQuotes";
            internal const string MAKE_REQUESTS = "/CompareService/MakeRequest";
        }
        internal class AdminEndpoints
        {
            internal const string ADD_PRODUCT_ENDPOINT = "/CompareService/LoadTransactions";  
        }
}
