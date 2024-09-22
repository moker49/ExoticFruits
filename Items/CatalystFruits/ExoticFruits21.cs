using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExoticFruits.Items.CatalystFruits
{
    internal class ExoticFruits21 : ModItem
    {
        private readonly int catalystFruitIndex = 0;
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
            string consumedText = ExoticFruitsPlayer.catalystFruitsConsumed[catalystFruitIndex] > maxFruits
                                  ? $" > {maxFruits}/{maxFruits}" : string.Empty;

            foreach (var line in tooltips)
            {
                if (line.Text.Contains("<consumed>"))
                {
                    bool isBelowCap = ExoticFruitsPlayer.bigFruitsConsumed < maxFruits;
                    line.OverrideColor = isBelowCap ? null : ExoticFruits.softCyan;
                    line.IsModifier = true;

                    line.Text = line.Text.Replace("<consumed>", ExoticFruitsPlayer.catalystFruitsConsumed[catalystFruitIndex].ToString())
                                         .Replace("<cap>", maxFruits.ToString()) + consumedText;
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
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && ExoticFruitsPlayer.catalystFruitsConsumed[catalystFruitIndex] < ExoticFruits.MaxFruits;
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

            ExoticFruitsPlayer.catalystFruitsConsumed[catalystFruitIndex]++;

            return true;
        }

        public override void AddRecipes()
        {
            if (!ModLoader.TryGetMod("CatalystMod", out Mod catalystMod))
            {
                return;
            }

            CreateRecipe()
                    .AddIngredient(catalystMod.Find<ModItem>("AstraJelly").Type, 1)
                    .AddIngredient(ItemID.AegisCrystal, 2)
                    .AddIngredient(ItemID.ArcaneCrystal, 2)
                    .AddIngredient(ItemID.PixieDust, 1)
                    .Register();
        }
    }
}