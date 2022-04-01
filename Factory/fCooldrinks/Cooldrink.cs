using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerCooldrinkAPI.Factory.fCooldrinks
{

    public class Cooldrink{

        public string flavour { get; set; }
        public string volume { get; set; }
    }
}