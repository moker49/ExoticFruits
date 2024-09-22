using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExoticFruits.Items.Fruits
{
    internal class ExoticFruits10 : ModItem
    {
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
            int maxFruits = ExoticFruits.MaxFruits;
            string consumedText = ExoticFruitsPlayer.bigFruitsConsumed > maxFruits
                ? $" > {maxFruits}/{maxFruits}"
                : string.Empty;

            foreach (var line in tooltips)
            {
                if (line.Text.Contains("<consumed>"))
                {
                    line.Text = line.Text.Replace("<consumed>", ExoticFruitsPlayer.bigFruitsConsumed.ToString()).Replace("<cap>", maxFruits.ToString()) + consumedText;
                    line.OverrideColor = ExoticFruitsPlayer.bigFruitsConsumed >= maxFruits ? ExoticFruits.softCyan : null;
                    line.IsModifier = true;
                }
                else if (line.Text.Contains("<lifeGain>"))
                {
                    line.Text = line.Text.Replace("<lifeGain>", ExoticFruits.BigFruitLifeValue.ToString());
                }
                else if (line.Text.Contains("<manaGain>"))
                {
                    line.Text = line.Text.Replace("<manaGain>", ExoticFruits.BigFruitManaValue.ToString());
                }
            }
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = ItemRarityID.Red;
        }
        public override bool CanUseItem(Player player)
        {
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && ExoticFruitsPlayer.bigFruitsConsumed < ExoticFruits.MaxFruits;
        }

        public override bool? UseItem(Player player)
        {
            player.statLifeMax2 += ExoticFruits.BigFruitLifeValue;
            player.statLife += ExoticFruits.BigFruitLifeValue;
            player.statManaMax2 += ExoticFruits.BigFruitManaValue;
            player.statMana += ExoticFruits.BigFruitManaValue;
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(ExoticFruits.BigFruitLifeValue);
            }
            ExoticFruitsPlayer.bigFruitsConsumed++;
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                    .AddIngredient(ModContent.ItemType<ExoticFruits09>())
                    .AddIngredient(ItemID.AegisCrystal, 2)
                    .AddIngredient(ItemID.ArcaneCrystal, 2)
                    .AddIngredient(ItemID.PixieDust, 1)
                    .Register();
        }
    }
}