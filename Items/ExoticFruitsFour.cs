using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsFour : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaultsBase("Jujube Fruit");
		}
		public override bool CanUseItem(Player player)
		{
			return base.CanUseItemBase(player, 3);
		}

		public override bool? UseItem(Player player)
		{
			return base.UseItemBase(player, 3);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.SoulofFright, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}