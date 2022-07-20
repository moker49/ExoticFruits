using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits5 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Durian Fruit");
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 5);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 5);
        }

        public override void AddRecipes()
        {
            if (enableFruitRecipes)
            {
                CreateRecipe()
                .AddIngredient(ItemID.LifeFruit)
                .AddIngredient(ItemID.ManaCrystal)
                .AddIngredient(ItemID.BeetleHusk, 4)
                .AddTile(TileID.WorkBenches)
                .Register();
            }
            if (enableCrystalRecipes)
            {
                CreateRecipe()
                .AddIngredient(ItemID.LifeCrystal)
                .AddIngredient(ItemID.ManaCrystal)
                .AddIngredient(ItemID.BeetleHusk, 4)
                .AddTile(TileID.WorkBenches)
                .Register();
            }
        }
    }
}