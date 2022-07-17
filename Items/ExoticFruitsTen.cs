using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsTen : ExoticFruitsItem
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
				CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.LunarBar, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
			if (enableCrystalRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeCrystal)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.LunarBar, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
		}
	}
}