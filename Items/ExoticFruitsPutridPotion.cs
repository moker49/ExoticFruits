using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Terraria.Localization;

namespace ExoticFruits.Items
{
    internal class ExoticFruitsPutridPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Pink;
            Item.consumable = true;
            Item.UseSound = SoundID.Item3;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.maxStack = 30;
        }
        public override bool CanUseItem(Player player)
        {
            return true;
        }
        public override bool? UseItem(Player player)
        {
            ExoticFruitsPlayer modPlayer = player.GetModPlayer<ExoticFruitsPlayer>();

            modPlayer.bigFruitsConsumed = 0;
            modPlayer.catalystFruitsConsumed[0] = 0;
            for (int i = 0; i <= 9; i++)
            {
                modPlayer.fruitsConsumed[i] = 0;
                modPlayer.calamityFruitsConsumed[i] = 0;
            }
            return true;
        }
    }
}