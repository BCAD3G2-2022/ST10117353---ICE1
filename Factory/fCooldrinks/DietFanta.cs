using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerCooldrinkAPI.Factory.fCooldrinks
{

    public class DietFanta : ICooldrink
    {
        public string getFlavour()
        {
            return "Fanta Grape";
        }

        public string getVolume()
        {
            return "500ml";
        }

        public string getDiet(){
            return "Diet";
        }
    }
}