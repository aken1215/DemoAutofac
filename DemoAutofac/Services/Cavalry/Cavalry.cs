using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAutofac.Services.Cavalry
{
public class Cavalry: ICavalry
{
    public string Charge()
    {
        return "騎兵衝鋒";
    }
}
}