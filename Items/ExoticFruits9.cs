using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits9 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Mangosteen Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 9);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 9);
        }

        public override void AddRecipes()
        {
            if (enableFruitRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.LunarBar, DefaultAmount);

            }
            if (enableCrystalRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.LunarBar, DefaultAmount);
            }
        }
    }
}