using Terraria;
using Terraria.ID;

namespace ExoticFruits.Items
{
    internal class ExoticFruits9 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Mangosteen Fruit", (string)Lang.GetNPCName(NPCID.MoonLordHead));
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 9);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 9);
        }

        public override void AddRecipes()
        {
            if (ExoticFruits.enableFruitRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeFruit, ItemID.LunarBar, ExoticFruits.DefaultAmount);
            }
            if (ExoticFruits.enableCrystalRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeCrystal, ItemID.LunarBar, ExoticFruits.DefaultAmount);
            }
        }
    }
}