using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruits8 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Rambutan Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 8);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 8);
        }

        public override void AddRecipes()
        {
            if (FruitShardsEnabled)
            {
                if (enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, ModContent.ItemType<Items.ExoticFruitsShard3>(), DefaultAmount);
                }
                if (enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ModContent.ItemType<Items.ExoticFruitsShard3>(), DefaultAmount);
                }
            }
            else
            {
                if (enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.LunarCraftingStation, 1);

                }
                if (enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.LunarCraftingStation, 1);
                }
            }
        }
    }
}