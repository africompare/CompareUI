﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompareHelper.Request
{
    public static class SharedEndpoints
    {
        public const string Login = "/CompareService/Login";
        public const string Register = "/compareservice/register";
        public const string ConfirmEmail = "/CompareService/ConfirmEmail";
        public const string ResetPassword = "/CompareService/PasswordReset";
        public const string Test1 = "/CompareService/Test1";
        public const string Test2 = "/CompareService/Test2";
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
