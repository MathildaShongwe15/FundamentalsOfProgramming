using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class FactorialService : IFactorialService
    {
       
        public int GetFactorial( int num1) {

            int ans = 0;

            while(num1 > 0)
            {
                for(int i = num1.ToString().Length ; i < 0; i--)
                {
                    ans *= ans + num1;
                }

            }


           return ans;
        }

    }
    


    
}
