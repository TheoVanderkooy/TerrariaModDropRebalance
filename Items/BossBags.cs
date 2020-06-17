using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MasterModeDropRebalance.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg) {
            // TODO: follow this advice
            // Typically you'll also want to also add an item to the non-expert boss drops,
            // that code can be found in ExampleGlobalNPC.NPCLoot. Use this and that to add drops to bosses.
            if (context == "bossBag" && arg == ItemID.CultistBossBag) {
                // drop another boss bag for testing...
                player.QuickSpawnItem(ItemID.CultistBossBag, 1);
                player.QuickSpawnItem(ItemID.CelestialSigil, 1);
                // TODO decide how much luminite
                player.QuickSpawnItem(ItemID.LunarOre, Main.rand.Next(90,110));

            }
        }
    }
}
