using ExoticFruits.Configs;
using ExoticFruits.Items.Shards;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits
{
    public class ExoticFruitsGlobalItem : GlobalItem
    {
        internal static bool FruitShardsEnabled = ModContent.GetInstance<Config>().enableFruitShards;
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            if (!FruitShardsEnabled)
            {
                return;
            }
            if (item.type == ItemID.PlanteraBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard0>(), 1, 10, 15));
            }
            else if (item.type == ItemID.FishronBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard1>(), 1, 10, 15));
            }
            else if (item.type == ItemID.FairyQueenBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard2>(), 1, 10, 15));
            }
            else if (item.type == ItemID.CultistBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ExoticFruitsShard3>(), 1, 10, 15));
            }

            // Calamity();

        }

        private bool Calamity()
        {
            if (!ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                return false;
            }



            return true;
        }
    }
}
