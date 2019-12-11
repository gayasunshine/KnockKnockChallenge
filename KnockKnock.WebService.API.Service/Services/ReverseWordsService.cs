using KnockKnockCodeChallenge.WebService.API.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace KnockKnockCodeChallenge.WebService.API.Service.Services
{
    public class ReverseWordsService : IReverseWordsService
    {
        public string GetReverseWord(string sentence)
        {
            string result = "";
            if (sentence != null)
            {
                char[] arr = sentence.ToCharArray();
                Array.Reverse(arr);

                string reverseCharacters = new string(arr);


                List<string> wordsList = new List<string>();
                string[] words = reverseCharacters.Split(new[] { " " }, StringSplitOptions.None);

                for (int i = words.Length - 1; i >= 0; i--)
                {
                    result += words[i] + " ";
                }

            }
            result = result.TrimEnd();
            return result;
        }
    }
}
