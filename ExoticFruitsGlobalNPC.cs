using System;
using ExoticFruits.Configs;
using ExoticFruits.Items;
using ExoticFruits.Items.Shards;
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
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LifeFruitShard>(), 1, 4, 4));
            }
            else if (npc.type == NPCID.DukeFishron)
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
            else
            {
                Calamity(npc, npcLoot);
            }

        }

        private bool Calamity(NPC npc, NPCLoot npcLoot)
        {
            if (!ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                return false;
            }
            else if (npc.type == calamityMod.Find<ModNPC>("ProfanedGuardianCommander").Type)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard4>(), 1, 10, 15));
                return true;
            }

            return false;
        }
    }
}