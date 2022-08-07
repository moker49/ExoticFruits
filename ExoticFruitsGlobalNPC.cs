using ExoticFruits.Configs;
using ExoticFruits.Items;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits
{
    public class ExoticFruitsGlobalNPC : GlobalNPC
    {
        internal static bool FruitShardsEnabled = ModContent.GetInstance<Config>().enableFruitShards;
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (!FruitShardsEnabled)
            {
                return;
            }
            if (npc.type == NPCID.Plantera)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard0>(), 1, 10, 15));
            }
            else if(npc.type == NPCID.DukeFishron)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard1>(), 1, 10, 15));
            }
            else if (npc.type == NPCID.HallowBoss)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard2>(), 1, 10, 15));
            }
            else if (npc.type == NPCID.CultistBoss)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard3>(), 1, 10, 15));
            }
        }
    }
}