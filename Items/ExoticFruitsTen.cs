using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsTen : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mangosteen Fruit");
			base.SetStaticDefaults();
		}
		public override bool CanUseItem(Player player)
		{
			return player.statLifeMax >= 400 && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[9] < MaxFruits;
		}

		public override bool? UseItem(Player player)
		{
			base.UseItemHelp(player);
            player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[9]++;
			return true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.LunarOre, 40)
				.AddTile(TileID.WorkBenches)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.LunarBar, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}