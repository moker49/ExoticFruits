using System.Collections.Generic;
using System.Collections.ObjectModel;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items.CalamityFruits
{
    internal class ExoticFruits16 : ExoticFruitsCalamityFruit
    {
        private readonly int calamityFruitIndex = 5;

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override bool PreDrawTooltip(ReadOnlyCollection<TooltipLine> lines, ref int x, ref int y)
        {
            List<TooltipLine> newLines = new List<TooltipLine>(lines);
            ModifyTooltips(newLines);
            return true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            base.ModifyTooltipsFruit(calamityFruitIndex, tooltips);
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, calamityFruitIndex);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, calamityFruitIndex);
        }

        public override void AddRecipes()
        {
            if (!ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                return;
            }

            if (ExoticFruits.enableFruitRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeFruit, calamityMod.Find<ModItem>("TwistingNether").Type, 1);
            }
            if (ExoticFruits.enableCrystalRecipes)
            {
                base.CreateFinalRecipe(ItemID.LifeCrystal, calamityMod.Find<ModItem>("TwistingNether").Type, 1);
            }
        }
    }
}