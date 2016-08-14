using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAutofac.Services.Cavalry
{
public class PowerCavalry : ICavalry
{
    public string Charge()
    {
        return "衝鋒後進行踐踏";
    }
}
}