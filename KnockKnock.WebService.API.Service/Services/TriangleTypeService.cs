using KnockKnockCodeChallenge.WebService.API.Service.Interfaces;
using KnockKnockCodeChallenge.WebService.API.Service.Model;
using System;
using System.Linq;
namespace KnockKnockCodeChallenge.WebService.API.Service.Services
{
    public class TriangleTypeService : ITriangleTypeService
    {
        public String GetTriangleType(int a, int b, int c)
        {
            //Placing items in an array for processing 
            int[] values = new int[3] { a, b, c };
            //Get the Distinct value count of Array
            int distictValue = values.Distinct().Count();
            //Check is inputs are valied
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return Enum.GetName(typeof(TriangleType), (int)TriangleType.Error);
            }

            //Address the Triangle Inequality Theory
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return Enum.GetName(typeof(TriangleType), TriangleType.Error);
            }
            //Deterine the Triangle Type
            switch (distictValue)
            {
                case 1:
                    return Enum.GetName(typeof(TriangleType), TriangleType.Equilateral);
                case 2:
                    return Enum.GetName(typeof(TriangleType), TriangleType.Isosceles);
                case 3:
                    return Enum.GetName(typeof(TriangleType), TriangleType.Scalene);
                default:
                    return Enum.GetName(typeof(TriangleType), TriangleType.Error);
            }
           
           
        }
    }
}
