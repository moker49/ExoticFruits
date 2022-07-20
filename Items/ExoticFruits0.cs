using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits0 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Carambola Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 0);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 0);
        }

        public override void AddRecipes()
        {
            if (enableFruitRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.GelBalloon, DefaultAmount);

            }
            if (enableCrystalRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.GelBalloon, DefaultAmount);
            }
        }
    }
}