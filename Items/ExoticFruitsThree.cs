using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsThree : ExoticFruitsItem
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
			if (enableFruitRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.SoulofMight, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
			if (enableCrystalRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeCrystal)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.SoulofMight, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
		}
	}
}