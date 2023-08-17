using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExoticFruits.Items
{
    public class ExoticFruitsDefensePotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.DrinkParticleColors[Type] = new Color[3]{
                new Color(240, 240, 240),
                new Color(200, 200, 200),
                new Color(140, 140, 140)
            };  
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.IronskinPotion);
            Item.rare = ItemRarityID.Red;
            Item.value = Item.buyPrice(platinum: 1);
            Item.buffType = ModContent.BuffType<Buffs.ExoticFruitsDefenseBuff>();
            Item.buffTime = ExoticFruits.PotionDefenseDuration * 60 * 60;
        }
        public override bool PreDrawTooltip(ReadOnlyCollection<TooltipLine> lines, ref int x, ref int y)
        {
            List<TooltipLine> newLines = new List<TooltipLine>(lines);
            ModifyTooltips(newLines);
            return true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (var line in tooltips)
            {
                if (line.Text.Contains("<defenseGain>")){
                    line.Text = line.Text.Replace("<defenseGain>", ExoticFruits.PotionDefenseValue.ToString());
                }
            }
        }
        public override void AddRecipes()
        {
            CreateRecipe(10)
                    .AddIngredient(ModContent.ItemType<ExoticFruits10>())
                    .AddIngredient(ItemID.IronskinPotion, 5)
                    .AddIngredient(ItemID.BottledWater, 5)
                    .AddIngredient(ItemID.CursedFlame)
                    .AddIngredient(ItemID.AsphaltBlock)
                    .AddTile(TileID.AlchemyTable)
                    .Register();
        }
    }
}