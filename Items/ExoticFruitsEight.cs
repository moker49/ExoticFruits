using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsEight : ExoticFruitsItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaultsBase("Kiwano Fruit");
		}
		public override bool CanUseItem(Player player)
		{
			return base.CanUseItemBase(player, 7);
		}

		public override bool? UseItem(Player player)
		{
			return base.UseItemBase(player, 7);
		}

		public override void AddRecipes()
		{
			RecipeGroup empressDrops = new(() => $"Any guaranteed {Lang.GetNPCName(NPCID.EmpressButterfly)} drop", new int[]
			{
				ItemID.FairyQueenMagicItem,
				ItemID.PiercingStarlight,
				ItemID.RainbowWhip,
				ItemID.FairyQueenRangedItem
			});

			RecipeGroup.RegisterGroup("ExoticFruits:EmpressItems", empressDrops);

			if (enableFruitRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeFruit)
				.AddIngredient(ItemID.ManaCrystal)
				.AddRecipeGroup(empressDrops)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
			if (enableCrystalRecipes)
			{
				CreateRecipe()
				.AddIngredient(ItemID.LifeCrystal)
				.AddIngredient(ItemID.ManaCrystal)
				.AddRecipeGroup(empressDrops)
				.AddTile(TileID.WorkBenches)
				.Register();

			}
		}
	}
}