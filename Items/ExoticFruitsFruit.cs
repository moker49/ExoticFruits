using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Drawing;

namespace ExoticFruits.Items
{
    internal abstract class ExoticFruitsFruit : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
        }

        internal bool CanUseItemBase(Player player, int fruitIndex)
        {
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && player.GetModPlayer<ExoticFruitsPlayer>().fruitsConsumed[fruitIndex] < ExoticFruits.MaxFruits;
        }
        internal bool UseItemBase(Player player, int fruitIndex)
        {
            BuffPlayer(player, ExoticFruits.LifePerFruit, ExoticFruits.ManaPerFruit);
            player.GetModPlayer<ExoticFruitsPlayer>().fruitsConsumed[fruitIndex]++;
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
        public void ModifyTooltipsFruit(int fruitIndex, List<TooltipLine> tooltips)
        {
            ExoticFruitsPlayer player = Main.player[Main.myPlayer].GetModPlayer<ExoticFruitsPlayer>();
            string capped = "";
            foreach (var line in tooltips)
            {
                string newLine = "";
                int maxFruits = ExoticFruits.MaxFruits;

                if (line.Text.Contains("<consumed>"))
                {
                    if (player.fruitsConsumed[fruitIndex] < ExoticFruits.MaxFruits)
                    {
                        line.OverrideColor = ExoticFruits.softCyan;
                    }
                    else if (player.fruitsConsumed[fruitIndex] >= ExoticFruits.MaxFruits)
                    {
                        line.OverrideColor = null;
                        line.IsModifier = true;
                        if (player.fruitsConsumed[fruitIndex] > ExoticFruits.MaxFruits)
                        {
                            line.IsModifierBad = true;
                            capped += $" > {maxFruits}/{maxFruits}"; // Consumed: 2/1 > 1/1
                        }
                    }
                    newLine = line.Text.Replace("<consumed>", player.fruitsConsumed[fruitIndex].ToString());
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