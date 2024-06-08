using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace ExoticFruits.Items
{
    internal abstract class ExoticFruitsCatalystFruit : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
        }

        internal bool CanUseItemBase(Player player, int modFruitIndex)
        {
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && player.GetModPlayer<ExoticFruitsPlayer>().catalystFruitsConsumed[modFruitIndex] < ExoticFruits.MaxFruits;
        }
        internal bool UseItemBase(Player player, int modFruitIndex)
        {
            BuffPlayer(player, ExoticFruits.LifePerFruit, ExoticFruits.ManaPerFruit);
            player.GetModPlayer<ExoticFruitsPlayer>().catalystFruitsConsumed[modFruitIndex]++;
            return true;
        }
        internal void BuffPlayer(Player player, int lifeAmount, int manaAmount)
        {
            player.statLifeMax2 += lifeAmount;
            player.statLife += lifeAmount;
            player.statManaMax2 += manaAmount;
            player.statMana += manaAmount;
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(lifeAmount);
            }
        }
        public void ModifyTooltipsFruit(int modFruitIndex, List<TooltipLine> tooltips)
        {
            ExoticFruitsPlayer player = Main.player[Main.myPlayer].GetModPlayer<ExoticFruitsPlayer>();
            string capped = "";
            foreach (var line in tooltips)
            {
                string newLine = "";
                int maxFruits = ExoticFruits.MaxFruits;

                if (line.Text.Contains("<consumed>"))
                {
                    if (!ExoticFruits.catalystLoaded)
                    {
                        line.OverrideColor = null;
                        line.IsModifier = true;
                        line.IsModifierBad = true;
                        capped += $" > 0/{maxFruits}"; // Consumed: 2/1 > 0/0
                    }
                    else if (player.catalystFruitsConsumed[modFruitIndex] < ExoticFruits.MaxFruits)
                    {
                        line.OverrideColor = null;
                        line.IsModifier = true;
                    }
                    else
                    {
                        line.OverrideColor = ExoticFruits.softCyan;

                        if (player.catalystFruitsConsumed[modFruitIndex] > ExoticFruits.MaxFruits)
                        {
                            capped += $" > {maxFruits}/{maxFruits}"; // Consumed: 2/1 > 1/1
                        }

                    }
                    newLine = line.Text.Replace("<consumed>", player.catalystFruitsConsumed[modFruitIndex].ToString());
                    newLine = newLine.Replace("<cap>", maxFruits.ToString());
                    newLine += capped;
                }
                else if (line.Text.Contains("<lifeGain>"))
                {
                    newLine = line.Text.Replace("<lifeGain>", ExoticFruits.LifePerFruit.ToString());
                }
                else if (line.Text.Contains("<manaGain>"))
                {
                    newLine = line.Text.Replace("<manaGain>", ExoticFruits.ManaPerFruit.ToString());
                }
                else
                {
                    continue;
                }
                line.Text = newLine;
            }
        }
        internal void CreateFinalRecipe(int lifeCrystalOrFruit, int lastIngredient, int amount)
        {
            CreateRecipe()
                    .AddIngredient(lifeCrystalOrFruit)
                    .AddIngredient(ItemID.ManaCrystal)
                    .AddIngredient(lastIngredient, amount)
                    .Register();
        }
        internal void CreateFinalRecipe(int lifeCrystalOrFruit, RecipeGroup lastIngredient)
        {
            CreateRecipe()
                    .AddIngredient(lifeCrystalOrFruit)
                    .AddIngredient(ItemID.ManaCrystal)
                    .AddRecipeGroup(lastIngredient)
                    .Register();
        }
    }
}