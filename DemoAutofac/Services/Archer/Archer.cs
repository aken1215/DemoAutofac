using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAutofac.Services.Archer
{
public class Archer: IArcher
{
    public string MultiShot()
    {
        return "多重射擊";
    }
}
}