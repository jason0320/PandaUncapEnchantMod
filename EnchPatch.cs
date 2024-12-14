using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_PandaUncapEnchantMod
{
    internal class EnchPatch
    {
        public static void OnStartCore()
        {
            SourceManager sources = Core.Instance.sources;
            foreach (SourceElement.Row row in sources.elements.rows)
            {
                EnchPatch.FeatRewrite(row);
            }
        }
        public static void FeatRewrite(SourceElement.Row ele)
        {
            if (ele.group == "ENC" && ele.alias == "encSpell")
            {
                ele.SetField("encFactor", 100);
            }
            if (ele.group == "ENC" && ele.alias == "travelSpeed")
            {
                ele.SetField("encFactor", 100);
            }
        }
    }
}
