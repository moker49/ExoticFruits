using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsFive : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pitaya Fruit");
			base.SetStaticDefaults();
		}
		public override bool CanUseItem(Player player)
		{
			return player.statLifeMax >= 400 && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[4] < MaxFruits;
		}

		public override bool? UseItem(Player player)
		{
			base.UseItemHelp(player);
            player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[4]++;
			return true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.TempleKey)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}