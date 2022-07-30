using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits3 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Jujube Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 3);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 3);
        }

        public override void AddRecipes()
        {
            if (ExoticFruits.enableFruitRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.SoulofFright, ExoticFruits.DefaultAmount);

            }
            if (ExoticFruits.enableCrystalRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.SoulofFright, ExoticFruits.DefaultAmount);
            }
        }
    }
}