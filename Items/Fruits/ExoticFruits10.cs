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
            ExoticFruitsPlayer player = Main.player[Main.myPlayer].GetModPlayer<ExoticFruitsPlayer>();
            string capped = "";
            foreach (var line in tooltips)
            {
                string newLine = "";
                int maxFruits = ExoticFruits.MaxFruits;

                if (line.Text.Contains("<consumed>"))
                {
                    if (player.bigFruitsConsumed < ExoticFruits.MaxFruits)
                    {
                        line.OverrideColor = null;
                        line.IsModifier = true;
                    }
                    else if (player.bigFruitsConsumed >= ExoticFruits.MaxFruits)
                    {
                        line.OverrideColor = ExoticFruits.softCyan;
                        if (player.bigFruitsConsumed > ExoticFruits.MaxFruits)
                        {
                            capped += $" > {maxFruits}/{maxFruits}"; // Consumed: 2/1 > 1/1
                        }
                    }
                    newLine = line.Text.Replace("<consumed>", player.bigFruitsConsumed.ToString());
                    newLine = newLine.Replace("<cap>", maxFruits.ToString());
                    newLine += capped;
                }
                else if (line.Text.Contains("<lifeGain>"))
                {
                    newLine = line.Text.Replace("<lifeGain>", ExoticFruits.BigFruitValue.ToString());
                }
                else if (line.Text.Contains("<manaGain>"))
                {
                    newLine = line.Text.Replace("<manaGain>", ExoticFruits.BigFruitValue.ToString());
                }
                else
                {
                    continue;
                }
                line.Text = newLine;
            }
        }
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = ItemRarityID.Red;
        }
        public override bool CanUseItem(Player player)
        {
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && player.GetModPlayer<ExoticFruitsPlayer>().bigFruitsConsumed < ExoticFruits.MaxFruits;
        }

        public override bool? UseItem(Player player)
        {
            player.statLifeMax2 += ExoticFruits.BigFruitValue;
            player.statLife += ExoticFruits.BigFruitValue;
            player.statManaMax2 += ExoticFruits.BigFruitValue;
            player.statMana += ExoticFruits.BigFruitValue;
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(ExoticFruits.BigFruitValue);
            }
            player.GetModPlayer<ExoticFruitsPlayer>().bigFruitsConsumed++;
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                    .AddIngredient(ModContent.ItemType<ExoticFruits09>())
                    .AddIngredient(ItemID.AegisCrystal, 4)
                    .AddIngredient(ItemID.ArcaneCrystal, 4)
                    .AddIngredient(ItemID.PixieDust, 3)
                    .Register();
        }
    }
}