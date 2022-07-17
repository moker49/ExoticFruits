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
			RecipeGroup fishronDrops = new(() => $"Any guaranteed {Lang.GetNPCName(NPCID.DukeFishron)} drop", new int[]
			{
				ItemID.Flairon,
				ItemID.BubbleGun,
				ItemID.RazorbladeTyphoon,
				ItemID.TempestStaff,
				ItemID.Tsunami
			});

			RecipeGroup.RegisterGroup("ExoticFruits:FishronItems", fishronDrops);
			if (enableFruitRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddRecipeGroup(fishronDrops)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
			if (enableCrystalRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeCrystal)
				.AddIngredient(ItemID.ManaCrystal)
				.AddRecipeGroup(fishronDrops)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
		}
	}
}