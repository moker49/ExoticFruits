using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ExoticFruits.Items
{
    internal class ExoticFruitsFruit : ModItem
    {
        internal void SetStaticDefaultsBase(string displayName)
        {
            DisplayName.SetDefault(displayName);
            Tooltip.SetDefault($"Made from the essence of your slain enemies.\nIncreases maximum life by {ExoticFruits.LifePerFruit}.\nIncreases maximum mana by {ExoticFruits.ManaPerFruit}.\nOnly {ExoticFruits.MaxFruits} can be consumed.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
        }

        internal bool CanUseItemBase(Player player, int fruitIndex)
        {
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[fruitIndex] < ExoticFruits.MaxFruits;
        }
        internal bool UseItemBase(Player player, int fruitIndex)
        {
            BuffPlayer(player, ExoticFruits.BigFruitValue, ExoticFruits.BigFruitValue);
            player.GetModPlayer<ExoticFruitsPlayer>().exoticFruitsBig++;
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