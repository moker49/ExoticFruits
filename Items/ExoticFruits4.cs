using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruits4 : ExoticFruitsItem
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
			if (enableFruitRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.TempleKey)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
			if (enableCrystalRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeCrystal)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.TempleKey)
				.AddTile(TileID.WorkBenches)
				.Register();

			}
		}
	}
}