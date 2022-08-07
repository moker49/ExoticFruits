using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruits7 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Kiwano Fruit", (string)Lang.GetNPCName(NPCID.HallowBoss));
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 7);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 7);
        }

        public override void AddRecipes()
        {
            if (ExoticFruits.enableFruitShards)
            {
                if (ExoticFruits.enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, ModContent.ItemType<Items.ExoticFruitsShard2>(), ExoticFruits.DefaultAmount);
                }
                if (ExoticFruits.enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ModContent.ItemType<Items.ExoticFruitsShard2>(), ExoticFruits.DefaultAmount);
                }
            }
            else
            {
                RecipeGroup empressDrops = new(() => $"Any Weapon Drop From {Lang.GetNPCName(NPCID.HallowBoss)}", new int[]
                {
                    ItemID.FairyQueenMagicItem,
                    ItemID.PiercingStarlight,
                    ItemID.RainbowWhip,
                    ItemID.FairyQueenRangedItem
                });
                RecipeGroup.RegisterGroup("ExoticFruits:EmpressItems", empressDrops);

                if (ExoticFruits.enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, empressDrops);

                }
                if (ExoticFruits.enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, empressDrops);
                }
            }
        }
    }
}