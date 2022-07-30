using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits2 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Acai Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 2);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 2);
        }

        public override void AddRecipes()
        {
            if (ExoticFruits.enableFruitRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.SoulofMight, ExoticFruits.DefaultAmount);

            }
            if (ExoticFruits.enableCrystalRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.SoulofMight, ExoticFruits.DefaultAmount);
            }
        }
    }
}