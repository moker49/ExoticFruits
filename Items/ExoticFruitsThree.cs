using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsThree : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Acai Fruit");
			base.SetStaticDefaults();
		}
		public override bool CanUseItem(Player player)
		{
			return player.statLifeMax >= 400 && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[2] < MaxFruits;
		}

		public override bool? UseItem(Player player)
		{
			base.UseItemHelp(player);
            player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[2]++;
			return true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.SoulofMight, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}