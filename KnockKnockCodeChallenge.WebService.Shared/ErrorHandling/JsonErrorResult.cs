using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KnockKnockCodeChallenge.WebService.Shared.ErrorHandling
{
    public class JsonErrorResult : JsonResult
    {
        /// <summary>

        /// This helper class wraps the HTTP Status Codes with exception message.

        /// </summary>
        private readonly HttpStatusCode statusCode;
        /// <summary>

        /// Default Constructor to return Internal Server Error

        /// </summary>

        /// <param name="json"></param>

        public JsonErrorResult(object json) : this(json, HttpStatusCode.InternalServerError)
        {

        }

        /// <summary>

        /// Constructor with the ability to specify the HTTP Status Code.

        /// </summary>

        /// <param name="json"></param>

        /// <param name="statusCode"></param>

        public JsonErrorResult(object json, HttpStatusCode statusCode) : base(json)
        {
            this.statusCode = statusCode;
        }

    }
}


