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
                CreateRecipe()
                .AddIngredient(ItemID.LifeFruit)
                .AddIngredient(ItemID.ManaCrystal)
                .AddIngredient(ItemID.GelBalloon, 10)
                .AddTile(TileID.WorkBenches)
                .Register();
            }
            if (enableCrystalRecipes)
            {
                CreateRecipe()
                .AddIngredient(ItemID.LifeCrystal)
                .AddIngredient(ItemID.ManaCrystal)
                .AddIngredient(ItemID.GelBalloon, 10)
                .AddTile(TileID.WorkBenches)
                .Register();

            }
        }
    }
}