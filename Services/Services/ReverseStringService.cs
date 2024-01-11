using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReverseStringService : IReverseStringService
    {

        public string ReverseString(string words){

            int temp;

            //split the words and store in a array
            string[] word = words.Split(' ');
            
            int k = word.Length - 1;

            temp = k;

            string ans = "";
            // reverse string
            for (int i = k ; i >= 0; i--)
            {
                ans += word[i] + " ";
            }

            return ans.Substring(0,ans.Length - 1);
        }
    }
}
