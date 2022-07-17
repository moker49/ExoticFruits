using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsNine : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rambutan Fruit");
			base.SetStaticDefaults();
		}
		public override bool CanUseItem(Player player)
		{
			return player.statLifeMax >= 400 && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[8] < MaxFruits;
		}

		public override bool? UseItem(Player player)
		{
			base.UseItemHelp(player);
            player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[8]++;
			return true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.LunarCraftingStation)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}