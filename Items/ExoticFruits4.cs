using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruits4 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Pitaya Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 4);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 4);
        }

        public override void AddRecipes()
        {
            if (FruitShardsEnabled)
            {
                if (enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, ModContent.ItemType<Items.ExoticFruitsShard0>(), DefaultAmount);
                }
                if (enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ModContent.ItemType<Items.ExoticFruitsShard0>(), DefaultAmount);
                }
            }
            else
            {
                if (enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.TempleKey, 1);

                }
                if (enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.TempleKey, 1);
                }
            }
        }
    }
}