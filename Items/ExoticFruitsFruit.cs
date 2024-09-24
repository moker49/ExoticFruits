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

        internal bool CanUseItemBase(Player player, int fruitIndex)
        {
            ExoticFruitsPlayer modPlayer = player.GetModPlayer<ExoticFruitsPlayer>();
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && modPlayer.fruitsConsumed[fruitIndex] < ExoticFruits.MaxFruits;
        }
        internal bool UseItemBase(Player player, int fruitIndex)
        {
            ExoticFruitsPlayer modPlayer = player.GetModPlayer<ExoticFruitsPlayer>();
            BuffPlayer(player, ExoticFruits.LifePerFruit, ExoticFruits.ManaPerFruit);
            modPlayer.fruitsConsumed[fruitIndex]++;
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
            ExoticFruitsPlayer modPlayer = Main.LocalPlayer.GetModPlayer<ExoticFruitsPlayer>();
            int consumedFruits = modPlayer.fruitsConsumed[fruitIndex];
            int maxFruits = ExoticFruits.MaxFruits;
            string consumedText = consumedFruits > maxFruits ? $" > {maxFruits}/{maxFruits}" : string.Empty;

            foreach (var line in tooltips)
            {
                if (line.Text.Contains("<consumed>"))
                {
                    line.Text = line.Text.Replace("<consumed>", consumedFruits.ToString())
                                         .Replace("<cap>", maxFruits.ToString()) + consumedText;

                    line.OverrideColor = consumedFruits >= maxFruits ? ExoticFruits.softCyan : null;
                    line.IsModifier = true;
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