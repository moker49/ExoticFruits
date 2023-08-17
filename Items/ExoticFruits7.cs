using System.Collections.Generic;
using System.Collections.ObjectModel;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruits7 : ExoticFruitsFruit
    {
        private readonly int fruitIndex = 7;
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
                    if (player.fruitsConsumed[fruitIndex] >= ExoticFruits.MaxFruits)
                    {
                        line.IsModifier = true;
                        if (player.fruitsConsumed[fruitIndex] > ExoticFruits.MaxFruits) capped += $" ({maxFruits}/{maxFruits})";
                    }
                    newLine = line.Text.Replace("<consumed>", player.fruitsConsumed[fruitIndex].ToString());
                    newLine = newLine.Replace("<cap>", maxFruits.ToString());
                    newLine += capped;
                } else if (line.Text.Contains("<lifeGain>")){
                    newLine = line.Text.Replace("<lifeGain>", ExoticFruits.LifePerFruit.ToString());
                } else if (line.Text.Contains("<manaGain>")){
                    newLine = line.Text.Replace("<manaGain>", ExoticFruits.ManaPerFruit.ToString());
                } else{
                    continue;
                }
                line.Text = newLine;
            }
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, fruitIndex);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, fruitIndex);
        }

        public override void AddRecipes()
        {
            if (ExoticFruits.enableFruitShards)
            {
                if (ExoticFruits.enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, ModContent.ItemType<Items.ExoticFruitsShard2>(), ExoticFruits.DefaultAmount);
                }
                if (ExoticFruits.enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ModContent.ItemType<Items.ExoticFruitsShard2>(), ExoticFruits.DefaultAmount);
                }
            }
            else
            {
                RecipeGroup empressDrops = new(() => $"Any Weapon Drop From {Lang.GetNPCName(NPCID.HallowBoss)}", new int[]
                {
                    ItemID.FairyQueenMagicItem,
                    ItemID.PiercingStarlight,
                    ItemID.RainbowWhip,
                    ItemID.FairyQueenRangedItem
                });
                RecipeGroup.RegisterGroup("ExoticFruits:EmpressItems", empressDrops);

                if (ExoticFruits.enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, empressDrops);

                }
                if (ExoticFruits.enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, empressDrops);
                }
            }
        }
    }
}