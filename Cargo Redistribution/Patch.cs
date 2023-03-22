using HarmonyLib;
using System;
using System.Collections.Generic;

namespace Cargo_Redistribution
{
    class Command : PulsarModLoader.Chat.Commands.CommandRouter.ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
               "cargopain"
            };
        }

        public override string Description()
        {
            return "Makes your ship cargo pain";
        }

        public override void Execute(string arguments)
        {
            PLShipInfo ship = PLEncounterManager.Instance.PlayerShip;
            Random rand = new Random();
            for(int i = 0; i < rand.Next(50,200); i++) 
            {
                Patch.ChangePosition(ship.CargoObjectDisplays, rand.Next(0, ship.CargoObjectDisplays.Count - 1), rand.Next(0, ship.CargoObjectDisplays.Count - 1));
            }
        }

    }

    internal class Patch
    {
        public static void ChangePosition(List<CargoObjectDisplay> list, int position1, int position2) 
        {
            CargoObjectDisplay temp = list[position1];
            list[position1] = list[position2];
            list[position1].Index = position1;
            list[position2] = temp;
            list[position2].Index = position2;
        }
        [HarmonyPatch(typeof(PLIntrepidInfo), "SetupShipStats")]
        class Intrepid
        {
            static void Postfix(bool previewStats, PLIntrepidInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 6, 7);
                }
            }
        }
        [HarmonyPatch(typeof(PLIntrepidCommanderInfo), "SetupShipStats")]
        class GrimCutlass
        {
            static void Postfix(bool previewStats, PLIntrepidCommanderInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 6, 7);
                }
            }
        }
        [HarmonyPatch(typeof(PLRolandInfo), "SetupShipStats")]
        class Roland 
        {
            static void Postfix(bool previewStats, PLRolandInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 3, 4);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 15, 16);
                    ChangePosition(__instance.CargoObjectDisplays, 19, 20);
                    ChangePosition(__instance.CargoObjectDisplays, 0, 11);
                    ChangePosition(__instance.CargoObjectDisplays, 1, 10);
                    ChangePosition(__instance.CargoObjectDisplays, 2, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 47);
                    ChangePosition(__instance.CargoObjectDisplays, 13, 42);
                    ChangePosition(__instance.CargoObjectDisplays, 14, 43);
                    ChangePosition(__instance.CargoObjectDisplays, 15, 41);
                    ChangePosition(__instance.CargoObjectDisplays, 16, 40);
                    ChangePosition(__instance.CargoObjectDisplays, 17, 34);
                    ChangePosition(__instance.CargoObjectDisplays, 18, 35);
                    ChangePosition(__instance.CargoObjectDisplays, 19, 33);
                    ChangePosition(__instance.CargoObjectDisplays, 20, 32);
                    ChangePosition(__instance.CargoObjectDisplays, 21, 26);
                    ChangePosition(__instance.CargoObjectDisplays, 22, 27);
                    ChangePosition(__instance.CargoObjectDisplays, 23, 25);
                    ChangePosition(__instance.CargoObjectDisplays, 24, 46);
                    ChangePosition(__instance.CargoObjectDisplays, 25, 45);
                    ChangePosition(__instance.CargoObjectDisplays, 26, 44);
                    ChangePosition(__instance.CargoObjectDisplays, 27, 38);
                    ChangePosition(__instance.CargoObjectDisplays, 28, 39);
                    ChangePosition(__instance.CargoObjectDisplays, 29, 37);
                    ChangePosition(__instance.CargoObjectDisplays, 30, 36);
                    ChangePosition(__instance.CargoObjectDisplays, 31, 36);
                    ChangePosition(__instance.CargoObjectDisplays, 32, 36);
                    ChangePosition(__instance.CargoObjectDisplays, 33, 37);
                    ChangePosition(__instance.CargoObjectDisplays, 34, 39);
                    ChangePosition(__instance.CargoObjectDisplays, 35, 46);
                    ChangePosition(__instance.CargoObjectDisplays, 36, 47);
                    ChangePosition(__instance.CargoObjectDisplays, 37, 42);
                    ChangePosition(__instance.CargoObjectDisplays, 38, 43);
                    ChangePosition(__instance.CargoObjectDisplays, 39, 41);
                    ChangePosition(__instance.CargoObjectDisplays, 42, 46);
                    ChangePosition(__instance.CargoObjectDisplays, 43, 46);
                    ChangePosition(__instance.CargoObjectDisplays, 44, 47);
                    ChangePosition(__instance.CargoObjectDisplays, 45, 47);
                }
            }
        }
        [HarmonyPatch(typeof(PLOutriderInfo), "SetupShipStats")]
        class Outrider
        {
            static void Postfix(bool previewStats, PLOutriderInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 2, 5);
                    ChangePosition(__instance.CargoObjectDisplays, 11, 9);
                }
            }
        }
        [HarmonyPatch(typeof(PLCruiserInfo), "SetupShipStats")]
        class Cruiser
        {
            static void Postfix(bool previewStats, PLCruiserInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 1, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 2, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 4);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 5);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 9, 13);
                    ChangePosition(__instance.CargoObjectDisplays, 11, 14);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 15);
                    ChangePosition(__instance.CargoObjectDisplays, 13, 14);
                    ChangePosition(__instance.CargoObjectDisplays, 14, 15);
                    ChangePosition(__instance.CargoObjectDisplays, 16, 19);
                    ChangePosition(__instance.CargoObjectDisplays, 17, 18);
                    ChangePosition(__instance.CargoObjectDisplays, 18, 20);
                    ChangePosition(__instance.CargoObjectDisplays, 19, 21);
                    ChangePosition(__instance.CargoObjectDisplays, 20, 21);
                    ChangePosition(__instance.CargoObjectDisplays, 22, 23);
                    ChangePosition(__instance.CargoObjectDisplays, 0, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 1, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 2, 5);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 4);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 15);
                    ChangePosition(__instance.CargoObjectDisplays, 13, 14);
                }
            }
        }
        [HarmonyPatch(typeof(PLWDDestroyerInfo), "SetupShipStats")]
        class Destroyer
        {
            static void Postfix(bool previewStats, PLWDDestroyerInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 0, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 1, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 2, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 6, 7);
                }
            }
        }
        [HarmonyPatch(typeof(PLWDAnnihilatorInfo), "SetupShipStats")]
        class Annihilator
        {
            static void Postfix(bool previewStats, PLWDAnnihilatorInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 2, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 6);
                }
            }
        }

        [HarmonyPatch(typeof(PLStarGazerInfo), "SetupShipStats")]
        class StarGazer
        {
            static void Postfix(bool previewStats, PLStarGazerInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 0, 1);
                    ChangePosition(__instance.CargoObjectDisplays, 1, 2);
                    ChangePosition(__instance.CargoObjectDisplays, 2, 3);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 4);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 5);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 6, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 8, 11);
                }
            }
        }
        [HarmonyPatch(typeof(PLCarrierInfo), "SetupShipStats")]
        class CarrierAndCorsair
        {
            static void Postfix(bool previewStats, PLCarrierInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 2, 11);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 12);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 14);
                    ChangePosition(__instance.CargoObjectDisplays, 6, 12);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 14);
                    ChangePosition(__instance.CargoObjectDisplays, 10, 16);
                    ChangePosition(__instance.CargoObjectDisplays, 11, 18);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 23);
                    ChangePosition(__instance.CargoObjectDisplays, 13, 22);
                    ChangePosition(__instance.CargoObjectDisplays, 14, 16);
                    ChangePosition(__instance.CargoObjectDisplays, 17, 23);
                    ChangePosition(__instance.CargoObjectDisplays, 18, 21);
                    ChangePosition(__instance.CargoObjectDisplays, 19, 20);
                    ChangePosition(__instance.CargoObjectDisplays, 20, 23);
                    ChangePosition(__instance.CargoObjectDisplays, 21, 23);
                    ChangePosition(__instance.CargoObjectDisplays, 24, 27);
                    ChangePosition(__instance.CargoObjectDisplays, 25, 27);
                    ChangePosition(__instance.CargoObjectDisplays, 26, 28);
                    ChangePosition(__instance.CargoObjectDisplays, 27, 28);
                    ChangePosition(__instance.CargoObjectDisplays, 19, 23);
                    ChangePosition(__instance.CargoObjectDisplays, 18, 22);
                    ChangePosition(__instance.CargoObjectDisplays, 13, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 16);
                    if (!(__instance is PLAlchemistShipInfo)) 
                    {
                        ChangePosition(__instance.CargoObjectDisplays, 29,30);
                        ChangePosition(__instance.CargoObjectDisplays, 30, 33);
                        ChangePosition(__instance.CargoObjectDisplays, 31, 33);
                        ChangePosition(__instance.CargoObjectDisplays, 32, 33);
                    }
                    ChangePosition(__instance.HiddenCargoObjectDisplays, 3, 7);
                    ChangePosition(__instance.HiddenCargoObjectDisplays, 6, 4);
                }
            }
        }
        [HarmonyPatch(typeof(PLFluffyShipInfo), "SetupShipStats")]
        class Fluffy1
        {
            static void Postfix(bool previewStats, PLFluffyShipInfo __instance)
            {
                if (!previewStats && !(__instance is PLFluffyShipInfo2))
                {
                    ChangePosition(__instance.CargoObjectDisplays, 4, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 6, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 8, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 9, 13);
                    ChangePosition(__instance.CargoObjectDisplays, 10, 14);
                    ChangePosition(__instance.CargoObjectDisplays, 11, 12);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 13);
                    ChangePosition(__instance.CargoObjectDisplays, 13, 16);
                    ChangePosition(__instance.CargoObjectDisplays, 15, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 16, 17);
                }
            }
        }
        [HarmonyPatch(typeof(PLOldWarsShip_Human), "SetupShipStats")]
        class Interceptor
        {
            static void Postfix(bool previewStats, PLOldWarsShip_Human __instance)
            {
                if (!previewStats /*&& PulsarModLoader.ModManager.Instance.GetMod("The Flagship") == null*/)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 1, 5);
                    ChangePosition(__instance.CargoObjectDisplays, 2, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 13);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 8, 11);
                    ChangePosition(__instance.CargoObjectDisplays, 9, 10);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 13);
                }
            }
        }
        [HarmonyPatch(typeof(PLCivilianStartingShipInfo), "SetupShipStats")]
        class SunCircler
        {
            static void Postfix(bool previewStats, PLCivilianStartingShipInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 0, 2);
                    ChangePosition(__instance.CargoObjectDisplays, 1, 2);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 6, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 9);
                }
            }
        }
        [HarmonyPatch(typeof(PLOldWarsShip_Sylvassi), "SetupShipStats")]
        class SwordShip
        {
            static void Postfix(bool previewStats, PLOldWarsShip_Sylvassi __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 0, 1);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 2);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 6, 15);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 16);
                    ChangePosition(__instance.CargoObjectDisplays, 8, 21);
                    ChangePosition(__instance.CargoObjectDisplays, 9, 18);
                    ChangePosition(__instance.CargoObjectDisplays, 10, 17);
                    ChangePosition(__instance.CargoObjectDisplays, 11, 19);
                    ChangePosition(__instance.CargoObjectDisplays, 12, 14);
                    ChangePosition(__instance.CargoObjectDisplays, 13, 18);
                    ChangePosition(__instance.CargoObjectDisplays, 14, 15);
                    ChangePosition(__instance.CargoObjectDisplays, 15, 20);
                    ChangePosition(__instance.CargoObjectDisplays, 16, 18);
                    ChangePosition(__instance.CargoObjectDisplays, 17, 19);
                    ChangePosition(__instance.CargoObjectDisplays, 18, 21);
                    ChangePosition(__instance.CargoObjectDisplays, 21, 20);
                }
            }
        }
        [HarmonyPatch(typeof(PLPolytechShipInfo), "SetupShipStats")]
        class Paladin
        {
            static void Postfix(bool previewStats, PLPolytechShipInfo __instance)
            {
                if (!previewStats)
                {
                    ChangePosition(__instance.CargoObjectDisplays, 0, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 1, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 2, 6);
                    ChangePosition(__instance.CargoObjectDisplays, 3, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 4, 7);
                    ChangePosition(__instance.CargoObjectDisplays, 5, 8);
                    ChangePosition(__instance.CargoObjectDisplays, 6, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 7, 9);
                    ChangePosition(__instance.CargoObjectDisplays, 8, 10);
                    ChangePosition(__instance.CargoObjectDisplays, 9, 10);
                    ChangePosition(__instance.CargoObjectDisplays, 10, 11);
                }
            }
        }
    }
}
