using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits1 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Cherimoya Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 1);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 1);
        }

        public override void AddRecipes()
        {
            if (ExoticFruits.enableFruitRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.SoulofSight, ExoticFruits.DefaultAmount);

            }
            if (ExoticFruits.enableCrystalRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.SoulofSight, ExoticFruits.DefaultAmount);
            }
        }
    }
}