using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DitsPortal.Common.StaticResources
{
    /// <summary>  
    /// This class is used for handle the custom exception in the application level.  
    /// </summary>  
    public class CustomExceptionHandler : IExceptionFilter
    {
        /// <summary>  
        /// This method will return the status code based on the exception type.  
        /// </summary>  
        /// <param name="exceptionType"></param>  
        /// <returns>HttpStatusCode</returns>  
        private HttpStatusCode getErrorCode(Type exceptionType)
        {
            Exceptions tryParseResult;
            if (Enum.TryParse<Exceptions>(exceptionType.Name, out tryParseResult))
            {
                switch (tryParseResult)
                {
                    case Exceptions.NullReferenceException:
                        return HttpStatusCode.LengthRequired;

                    case Exceptions.FileNotFoundException:
                        return HttpStatusCode.NotFound;

                    case Exceptions.OverflowException:
                        return HttpStatusCode.RequestedRangeNotSatisfiable;

                    case Exceptions.OutOfMemoryException:
                        return HttpStatusCode.ExpectationFailed;

                    case Exceptions.InvalidCastException:
                        return HttpStatusCode.PreconditionFailed;

                    case Exceptions.ObjectDisposedException:
                        return HttpStatusCode.Gone;

                    case Exceptions.UnauthorizedAccessException:
                        return HttpStatusCode.Unauthorized;

                    case Exceptions.NotImplementedException:
                        return HttpStatusCode.NotImplemented;

                    case Exceptions.NotSupportedException:
                        return HttpStatusCode.NotAcceptable;

                    case Exceptions.InvalidOperationException:
                        return HttpStatusCode.MethodNotAllowed;

                    case Exceptions.TimeoutException:
                        return HttpStatusCode.RequestTimeout;

                    case Exceptions.ArgumentException:
                        return HttpStatusCode.BadRequest;

                    case Exceptions.StackOverflowException:
                        return HttpStatusCode.RequestedRangeNotSatisfiable;

                    case Exceptions.FormatException:
                        return HttpStatusCode.UnsupportedMediaType;

                    case Exceptions.IOException:
                        return HttpStatusCode.NotFound;

                    case Exceptions.IndexOutOfRangeException:
                        return HttpStatusCode.ExpectationFailed;

                    default:
                        return HttpStatusCode.InternalServerError;
                }
            }
            else
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        /// <summary>  
        /// This method will automatically trigger when any exception occurs in application level.  
        /// </summary>  
        /// <param name="context"></param>  
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode statusCode = (context.Exception as WebException != null &&
                        ((HttpWebResponse)(context.Exception as WebException).Response) != null) ?
                         ((HttpWebResponse)(context.Exception as WebException).Response).StatusCode
                         : getErrorCode(context.Exception.GetType());
            string errorMessage = context.Exception.Message;
            //string customErrorMessage = Constant.ERRORMSG;
            string customErrorMessage = "Custom Exception";
            string stackTrace = context.Exception.StackTrace;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)statusCode;
            response.ContentType = "application/json";
            var result = JsonConvert.SerializeObject(
                new
                {
                    Message = customErrorMessage,
                    //isError = true,
                    ErrorMessage = errorMessage,
                    //errorCode = statusCode,
                    //model = string.Empty
                    Sucess = false
                });
            #region Logging  
            //if (ConfigurationHelper.GetConfig()[ConfigurationHelper.environment].ToLower() != "dev")  
            //{  
            //    LogMessage objLogMessage = new LogMessage()  
            //    {  
            //        ApplicationName = ConfigurationHelper.GetConfig()["ApplicationName"].ToString(),  
            //        ComponentType = (int) ComponentType.Server,  
            //        ErrorMessage = errorMessage,  
            //        LogType = (int) LogType.EventViewer,  
            //        ErrorStackTrace = stackTrace,  
            //        UserName = Common.GetAccNameDev(context.HttpContext)  
            //    };  
            //    LogError(objLogMessage, LogEntryType.Error);  
            //}  
            #endregion Logging  
            response.ContentLength = result.Length;
            response.WriteAsync(result);
        }
    }
    /// <summary>  
    /// This class will allow to generate the custom exception message.  
    /// </summary>  
    public class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, string responseModel) : base(message)
        {
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
    /// <summary>  
    /// Different types of exceptions.  
    /// </summary>  
    public enum Exceptions
    {
        NullReferenceException = 1,
        FileNotFoundException = 2,
        OverflowException = 3,
        OutOfMemoryException = 4,
        InvalidCastException = 5,
        ObjectDisposedException = 6,
        UnauthorizedAccessException = 7,
        NotImplementedException = 8,
        NotSupportedException = 9,
        InvalidOperationException = 10,
        TimeoutException = 11,
        ArgumentException = 12,
        FormatException = 13,
        StackOverflowException = 14,
        SqlException = 15,
        IndexOutOfRangeException = 16,
        IOException = 17
    }
    

}
