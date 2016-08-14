using DemoAutofac.Services.Archer;
using DemoAutofac.Services.Cavalry;
using DemoAutofac.Services.Infantry;
using System.Web.Http;
using System.Web.Http.Description;

namespace DemoAutofac.Controllers
{
    public class ArmyCommandController : ApiController
    {
        private IArcher ArcherService;
        private ICavalry CavalryService;
        private IInfantry InfantryService;

        public ArmyCommandController(IInfantry infantryService, ICavalry cavalryService, IArcher archerService)
        {
            this.InfantryService = infantryService;
            this.CavalryService = cavalryService;
            this.ArcherService = archerService;
        }

        [HttpGet]
        [ResponseType(typeof(string))]
        public string SendOrder(ArmyType Id)
        {
            var result = "";
            switch (Id)
            {
                case ArmyType.Infantry:
                    result = this.InfantryService.Guard();
                    break;
                case ArmyType.Cavalry:
                    result = this.CavalryService.Charge();
                    break;
                case ArmyType.Archer:
                    result = this.ArcherService.MultiShot();
                    break;
                default:
                    break;
            }
            return result;
        }
    }

public enum ArmyType
{
    Infantry = 0,

    Cavalry = 1,

    Archer=2
}
}