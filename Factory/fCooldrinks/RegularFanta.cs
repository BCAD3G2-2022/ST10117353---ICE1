using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerCooldrinkAPI.Factory.fCooldrinks
{

    public class RegularFanta : ICooldrink
    {
        public string getFlavour()
        {
            return "Fanta Orange";
        }

        public string getVolume()
        {
            return "330ml";
        }
    }
}