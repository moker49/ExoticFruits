using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ExoticFruits.Items
{
    internal class ExoticFruits10 : ModItem
    {      
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goyave Noire");
            Tooltip.SetDefault($"The ultimate delicious nectar of the fallen gods.\nIncreases maximum life by {ExoticFruits.BigFruitValue}.\nIncreases maximum mana by {ExoticFruits.BigFruitValue}.\nOnly {ExoticFruits.MaxFruits} can be consumed.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = ItemRarityID.Red;
        }
        internal bool CanUseItemBase(Player player, int fruitIndex)
        {
            return player.statLifeMax >= ExoticFruits.LifeRequired && player.statManaMax >= ExoticFruits.ManaRequired && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruitsBigFruit < ExoticFruits.MaxFruits;
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
            player.GetModPlayer<ExoticFruitsPlayer>().exoticFruitsBigFruit++;
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                    .AddIngredient(ModContent.ItemType<ExoticFruits9>())
                    .AddIngredient(ItemID.GlowingMushroom)
                    .AddIngredient(ItemID.Gel, 2)
                    .AddIngredient(ItemID.LifeFruit, 5)
                    .AddIngredient(ItemID.ManaCrystal, 5)
                    .AddIngredient(ItemID.PixieDust, 3)
                    .Register();
        }
    }
}