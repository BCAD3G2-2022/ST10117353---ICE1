using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerCooldrinkAPI.Factory.fBurgers;

namespace BurgerCooldrinkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurgerController : ControllerBase
    {
     
        [HttpGet]
        public List<BurgerCooldrinkAPI.Factory.fBurgers.Burger> Get(string burgerType = "plain")
        {
        BurgerCooldrinkAPI.Factory.fBurgers.BurgerFactory burgerFactory = new BurgerCooldrinkAPI.Factory.fBurgers.BurgerFactory();
        BurgerCooldrinkAPI.Factory.fBurgers.IBurger burger = burgerFactory.getBurger(burgerType);
        List<BurgerCooldrinkAPI.Factory.fBurgers.Burger> returnedBurger = new List<BurgerCooldrinkAPI.Factory.fBurgers.Burger>();
        returnedBurger.Add(new BurgerCooldrinkAPI.Factory.fBurgers.Burger{patty = burger.getPatty(),bun=burger.getBun()});

        return returnedBurger;
        }
    }
}
