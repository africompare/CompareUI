//using System; 
//using RestSharp;
//using AfriCompare.API.Controllers;

//namespace CompareHelper.APIServices
//{
//   public class UserService
//     {     
//        public static UserRegRespObj AddnewUser(UserRegistrationRequest model, string username)
//        {
//        //regObj.AdminUserId = 1;
//        var response = new UserRegRespObj
//        {
//            Status = new APIResponseStatus
//            {
//                IsSuccessful = false,
//                Message = new APIResponseMessage(),
//            },

//        };
//        try
//        {
//            var apiResponse = new APIHelper(APIEndpoints.RESET_STUDENT_PASSWORD_ENDPOINT, username, Method.POST).ProcessAPI<UserPasswordResetObj, UserRegRespObj>(regObj, out var msg);
//            if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//            {
//                return apiResponse;
//            }

//            response.Status.Message.FriendlyMessage = msg.Message;
//            response.Status.Message.TechnicalMessage = msg.TechMessage;
//            return response;
//        }
//        catch (Exception ex)
//        {
//            UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//            response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//            response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//            return response;
//        }
//    }
  
//        //public static UserRegRespObj ForgotPasword(UserPasswordResetObj regObj, string username)
//        //{
//        //    //regObj.AdminUserId = 1;
//        //    var response = new UserRegRespObj
//        //    {
//        //        Status = new APIResponseStatus
//        //        {
//        //            IsSuccessful = false,
//        //            Message = new APIResponseMessage(),
//        //        },

//        //    };
//        //    try
//        //    {
//        //        var apiResponse = new APIHelper(APIEndpoints.RESET_STUDENT_PASSWORD_ENDPOINT, username, Method.POST).ProcessAPI<UserPasswordResetObj,UserRegRespObj>(regObj, out var msg);
//        //        if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//        //        {
//        //            return apiResponse;
//        //        }

//        //        response.Status.Message.FriendlyMessage = msg.Message;
//        //        response.Status.Message.TechnicalMessage = msg.TechMessage;
//        //        return response;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//        //        response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//        //        response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//        //        return response;
//        //    }
//        //}
//        //public static UserRegRespObj ChangePasword(ChangePasswordObj regObj, string username)
//        //{
//        //    //regObj.AdminUserId = 1;
//        //    var response = newUserRegRespObj
//        //    {
//        //        Status = new APIResponseStatus
//        //        {
//        //            IsSuccessful = false,
//        //            Message = new APIResponseMessage(),
//        //        }, 
//        //    };
//        //    try
//        //    {

//        //        var apiResponse = new APIHelper(APIEndpoints.CHANGE_STUDENT_PASSWORD_ENDPOINT, username, Method.POST).ProcessAPI<ChangePasswordObj,UserRegRespObj>(regObj, out var msg);
//        //        if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//        //        {
//        //            return apiResponse;
//        //        }

//        //        response.Status.Message.FriendlyMessage = msg.Message;
//        //        response.Status.Message.TechnicalMessage = msg.TechMessage;
//        //        return response;

//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//        //        response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//        //        response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//        //        return response;
//        //    }
//        //}
//        //public static UserRegRespObj Activate(UserActivationObj regObj, string username)
//        //{
//        //    //regObj.AdminUserId = 1;
//        //    var response = new UserRegRespObj
//        //    {
//        //        Status = new APIResponseStatus
//        //        {
//        //            IsSuccessful = false,
//        //            Message = new APIResponseMessage(),
//        //        },
//        //    };
//        //    try
//        //    {
//        //        var apiResponse = new APIHelper(APIEndpoints.User_ACTIVATION_ENDPOINT, username, Method.POST).ProcessAPI<UserActivationObj,UserRegRespObj>(regObj, out var msg);
//        //        if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//        //        {
//        //            return apiResponse;
//        //        } 
//        //        response.Status.Message.FriendlyMessage = msg.Message;
//        //        response.Status.Message.TechnicalMessage = msg.TechMessage;
//        //        return response; 
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//        //        response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//        //        response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//        //        return response;
//        //    }
//        //}
//        //public static UserRegRespObj AddUser(RegUserObj regObj, string username)
//        //{
//        //    regObj.AdminUserId = 1;
//        //    var response = newUserRegRespObj
//        //    {
//        //        Status = new APIResponseStatus
//        //        {
//        //            IsSuccessful = false,
//        //            Message = new APIResponseMessage(),
//        //        }, 
//        //    };
//        //    try
//        //    { 
//        //        var apiResponse = new APIHelper(APIEndpoints.ADD_STUDENT_ENDPOINT, username, Method.POST).ProcessAPI<RegUserObj,UserRegRespObj>(regObj, out var msg);
//        //        if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//        //        {
//        //            return apiResponse;
//        //        } 
//        //        response.Status.Message.FriendlyMessage = msg.Message;
//        //        response.Status.Message.TechnicalMessage = msg.TechMessage;
//        //        return response; 
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//        //        response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//        //        response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//        //        return response;
//        //    }
//        //}
//        //public static UserLoginRespObj LogInUser(UserLoginObj regObj, string username)
//        //{
//        //    //regObj.AdminUserId = 1;
//        //    var response = newUserLoginRespObj
//        //    {
//        //        Status = new APIResponseStatus
//        //        {
//        //            IsSuccessful = false,
//        //            Message = new APIResponseMessage(),
//        //        },
//        //    };
//        //    try
//        //    {
//        //        var apiResponse = new APIHelper(APIEndpoints.LOGIN_STUDENT_ENDPOINT, username, Method.POST).ProcessAPI<UserLoginObj,UserLoginRespObj>(regObj, out var msg);
//        //        if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//        //        {
//        //            return apiResponse;
//        //        }

//        //        response.Status.Message.FriendlyMessage = msg.Message;
//        //        response.Status.Message.TechnicalMessage = msg.TechMessage;
//        //        return response;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//        //        response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//        //        response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//        //        return response;
//        //    }
//        //}
//        //public static UserRegRespObj UpdateUser(EditUserObj regObj, string username)
//        //{
//        //    var response = newUserRegRespObj
//        //    {
//        //        Status = new APIResponseStatus
//        //        {
//        //            IsSuccessful = false,
//        //            Message = new APIResponseMessage(),
//        //        },
//        //    };
//        //    try
//        //    {

//        //        var apiResponse = new APIHelper(APIEndpoints.UPDATE_STUDENT_ENDPOINT, username, Method.POST).ProcessAPI<EditUserObj,UserRegRespObj>(regObj, out var msg);
//        //        if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//        //        {
//        //            return apiResponse;
//        //        }

//        //        response.Status.Message.FriendlyMessage = msg.Message;
//        //        response.Status.Message.TechnicalMessage = msg.TechMessage;
//        //        return response;


//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//        //        response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//        //        response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//        //        return response;
//        //    }
//        //}
//        //public static UserRespObj LoadUsers(UserSearchObj regObj, string username)
//        //{
//        //    var response = newUserRespObj
//        //    {
//        //        Status = new APIResponseStatus
//        //        {
//        //            IsSuccessful = false,
//        //            Message = new APIResponseMessage(),
//        //        }, 
//        //    };
//        //    try
//        //    {
//        //        var apiResponse = new APIHelper(APIEndpoints.LOAD_User_ENDPOINT, username, Method.POST).ProcessAPI<UserSearchObj,UserRespObj>(regObj, out var msg);
//        //        if (msg.Code == 0 && string.IsNullOrEmpty(msg.TechMessage) && string.IsNullOrEmpty(msg.Message))
//        //        {
//        //            return apiResponse;
//        //        }

//        //        response.Status.Message.FriendlyMessage = msg.Message;
//        //        response.Status.Message.TechnicalMessage = msg.TechMessage;
//        //        return response; 
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
//        //        response.Status.Message.FriendlyMessage = "Error Occurred! Please try again later";
//        //        response.Status.Message.TechnicalMessage = "Error: " + ex.GetBaseException().Message;
//        //        return response;
//        //    }
//        //} 
     
//    }
//}
