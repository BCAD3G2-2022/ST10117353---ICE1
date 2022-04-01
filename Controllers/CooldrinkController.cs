using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerCooldrinkAPI.Factory.fCooldrinks;

namespace BurgerCooldrinkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CooldrinkController : ControllerBase
    {
     
        [HttpGet]
        public List<BurgerCooldrinkAPI.Factory.fCooldrinks.Cooldrink> Get(string cooldrinkType = "Coke")
        {
           BurgerCooldrinkAPI.Factory.fCooldrinks.CooldrinkFactory cooldrinkFactory = new BurgerCooldrinkAPI.Factory.fCooldrinks.CooldrinkFactory();
           BurgerCooldrinkAPI.Factory.fCooldrinks.ICooldrink cooldrink = cooldrinkFactory.getCooldrink(cooldrinkType);
           List<BurgerCooldrinkAPI.Factory.fCooldrinks.Cooldrink> returnedDrink = new List<Cooldrink>();
           returnedDrink.Add(new Cooldrink{flavour = cooldrink.getFlavour(),volume=cooldrink.getVolume()});

           return returnedDrink;
        }
    }
}
