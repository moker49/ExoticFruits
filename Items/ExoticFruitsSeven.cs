using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsSeven : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaultsBase("Loquat Fruit");
		}
		public override bool CanUseItem(Player player)
		{
			return base.CanUseItemBase(player, 6);
		}

		public override bool? UseItem(Player player)
		{
			return base.UseItemBase(player, 6);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.Flairon)
				.AddTile(TileID.WorkBenches)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.BubbleGun)
				.AddTile(TileID.WorkBenches)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.RazorbladeTyphoon)
				.AddTile(TileID.WorkBenches)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.TempestStaff)
				.AddTile(TileID.WorkBenches)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddIngredient(ItemID.Tsunami)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}