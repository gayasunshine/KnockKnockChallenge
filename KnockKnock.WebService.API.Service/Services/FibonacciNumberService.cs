using KnockKnockCodeChallenge.WebService.API.Service.Interfaces;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnockCodeChallenge.WebService.API.Service.Services
{
    public class FibonacciNumberService : IFibonacciNumberService
    {
        protected readonly long threshold = 92;
        public long GetFibonacciNumber(long n)
        {
           // long firstNumber = 0, secondNumber = 1, result = 0;
            if (n > threshold)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest)
                {

                });
            }
            if (n < -threshold)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest)
                {

                });
            }
            //check the Negative Inputs and convert to positive
            bool isNegative = false;
            if (n > 0)
            {
                n = n * -1;
                isNegative = true;
            }

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            for (int i = 2; i <= n; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            if (isNegative)
            {
                result = result * -1;
            }

            return result;
        }
    }
}
