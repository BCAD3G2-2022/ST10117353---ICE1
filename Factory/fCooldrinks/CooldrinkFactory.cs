using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerCooldrinkAPI.Factory.fCooldrinks
{
 
public class CooldrinkFactory 
{

    // Instance of Interface (IBurger)
    public ICooldrink returnInstance ;

    public ICooldrink getCooldrink(String cooldrinkType)
    {
       switch(cooldrinkType)
       {
           case("Coke"):
           returnInstance = new RegularCoke();
           break;
           case("DietCoke"):
           returnInstance = new DietCoke();
            break;
           case("Fanta"):
           returnInstance = new RegularFanta();
           break;
           case("DietFanta"):
           returnInstance = new DietFanta();
           break;
       }

        return returnInstance;


    }
    
}
}

