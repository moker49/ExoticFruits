using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsSix : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Durian Fruit");
			base.SetStaticDefaults();
		}
		public override bool CanUseItem(Player player)
		{
			return player.statLifeMax >= 400 && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[5] < MaxFruits;
		}

		public override bool? UseItem(Player player)
		{
			base.UseItemHelp(player);
            player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[5]++;
			return true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.BeetleHusk, 4)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}