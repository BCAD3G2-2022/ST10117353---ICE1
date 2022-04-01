using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerCooldrinkAPI.Factory.fBurgers
{
public class CheeseBurger : IBurger
{


public string getBun()
{
return "Wheat";

}

public string getPatty()
{
 return "Beef";

}

public string getCheese()
{
 return "Gouda";
}
}
}
