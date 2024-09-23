using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace ExoticFruits.Items
{
    internal abstract class ExoticFruitsCalamityFruit : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Yellow;
            Item.consumable = true;
            Item.UseSound = SoundID.Item4;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.maxStack = 30;
        }

        internal bool CanUseItemBase(Player player, int calamityFruitIndex)
        {
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && ExoticFruitsPlayer.calamityFruitsConsumed[calamityFruitIndex] < ExoticFruits.MaxFruits;
        }
        internal bool UseItemBase(Player player, int calamityFruitIndex)
        {
            BuffPlayer(player, ExoticFruits.LifePerFruit, ExoticFruits.ManaPerFruit);
            ExoticFruitsPlayer.calamityFruitsConsumed[calamityFruitIndex]++;
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
        public void ModifyTooltipsFruit(int calamityFruitIndex, List<TooltipLine> tooltips)
        {
            int consumedFruits = ExoticFruitsPlayer.calamityFruitsConsumed[calamityFruitIndex];
            int maxFruits = ExoticFruits.MaxFruits;
            string consumedText = consumedFruits > maxFruits ? $" > {maxFruits}/{maxFruits}" : string.Empty;

            foreach (var line in tooltips)
            {
                if (line.Text.Contains("<consumed>"))
                {
                    if (ExoticFruits.CalamityMod == null)
                    {
                        line.OverrideColor = null;
                        line.IsModifier = true;
                        line.IsModifierBad = true;
                        consumedText = $" > 0/{maxFruits}";
                    }
                    else
                    {
                        line.OverrideColor = consumedFruits >= maxFruits ? ExoticFruits.softCyan : null;
                        line.IsModifier = true;
                    }

                    line.Text = line.Text.Replace("<consumed>", consumedFruits.ToString())
                                         .Replace("<cap>", maxFruits.ToString()) + consumedText;
                }
                else if (line.Text.Contains("<lifeGain>"))
                {
                    line.Text = line.Text.Replace("<lifeGain>", ExoticFruits.LifePerFruit.ToString());
                }
                else if (line.Text.Contains("<manaGain>"))
                {
                    line.Text = line.Text.Replace("<manaGain>", ExoticFruits.ManaPerFruit.ToString());
                }
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