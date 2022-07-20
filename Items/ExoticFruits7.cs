using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits7 : ExoticFruitsFruit
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
            RecipeGroup empressDrops = new(() => $"Any Weapon Drop From {Lang.GetNPCName(NPCID.HallowBoss)}", new int[]
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