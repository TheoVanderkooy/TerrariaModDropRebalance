using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;

using static Terraria.ModLoader.ModContent;

namespace MasterModeDropRebalance.NPCs
{
    public class DropRebalanceGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            switch (npc.type) {
                // Make cultist drop treasure bag
                // also, make blue slime and zombie drop it for debugging
                case NPCID.BlueSlime:
                case NPCID.Zombie:
                case NPCID.FemaleZombie:
                case NPCID.ZombieMushroom:
                case NPCID.BaldZombie:
                case NPCID.BigBaldZombie:
                case NPCID.BigFemaleZombie:
                case NPCID.BigZombie:
                case NPCID.CultistBoss:
                    Item.NewItem(npc.getRect(), ItemID.CultistBossBag);
                    break;
            }
        }
    }
}

