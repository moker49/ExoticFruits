using ExoticFruits.Configs;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits
{
    public class ExoticFruitsNPC : GlobalNPC
    {
        internal static bool FruitShardsEnabled = ModContent.GetInstance<ExoticFruitsConfig>().enableFruitShards;
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (!FruitShardsEnabled)
            {
                return;
            }
            if (npc.type == NPCID.QueenSlimeBoss)
            {
                // This is where we add item drop rules for VampireBat, here is a simple example:
                npcLoot.Add(ItemDropRule.Common(ItemID.Gel, 1, 10, 15));
            }
        }
    }
}