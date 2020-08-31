using System;
using System.Collections.Generic;
using System.Text;

namespace CompareHelper.Request
{
    class EndPoints
    {
        internal class SharedEndpoints
        {
            public const string SignIn = "/CompareService/Login";
            public const string Register = "​/CompareService​/Register";
            public const string ResetPassword = "/CompareService/PasswordReset";
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
        }
        internal class AdminEndpoints
        {
            internal const string ADD_PRODUCT_ENDPOINT = "/CompareService/LoadTransactions";  
        }
    }
}
