using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;

namespace Mod_PandaUncapEnchantMod
{
    [BepInPlugin("panda.uncapenchant.mod", "Panda's Uncap Enchant Mod", "1.0.0.0")]
    internal class Mod_PandaUncapEnchantMod : BaseUnityPlugin
    {
        private void Start()
        {
            var harmony = new Harmony("Panda's Uncap Enchant Mod");
            harmony.PatchAll();
        }
        public void OnStartCore()
        {
            EnchPatch.OnStartCore();
        }
    }
}
