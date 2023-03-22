using PulsarModLoader;
namespace Cargo_Redistribution
{
    public class Mod : PulsarMod
    {
        public override string Version => "1.0";

        public override string Author => "pokegustavo";

        public override string ShortDescription => "Re-organizes cargo in all ships";

        public override string Name => "Cargo Redistribution";

        public override string HarmonyIdentifier()
        {
            return "pokegustavo.CargoRedistribution";
        }
    }
}
