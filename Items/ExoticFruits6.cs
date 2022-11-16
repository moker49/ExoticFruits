using System.Collections.Generic;
using System.Collections.ObjectModel;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruits6 : ExoticFruitsFruit
    {
        private int fruitIndex = 6;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Loquat Fruit", (string)Lang.GetNPCName(NPCID.DukeFishron));
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
                if (line.Text.Contains("Consumed:"))
                {
                    if (player.fruitsConsumed[fruitIndex] >= ExoticFruits.MaxFruits)
                    {
                        line.IsModifier = true;
                        if (player.fruitsConsumed[fruitIndex] > ExoticFruits.MaxFruits) capped += $"(Effective: {ExoticFruits.MaxFruits})";
                    }
                    line.Text = $"Consumed: {player.fruitsConsumed[fruitIndex]}/{ExoticFruits.MaxFruits} {capped}";
                    break;
                }
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
                    base.CreateFinalRecipe(ItemID.LifeFruit, ModContent.ItemType<Items.ExoticFruitsShard1>(), ExoticFruits.DefaultAmount);
                }
                if (ExoticFruits.enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ModContent.ItemType<Items.ExoticFruitsShard1>(), ExoticFruits.DefaultAmount);
                }
            }
            else
            {
                RecipeGroup fishronDrops = new(() => $"Any Weapon Drop From {Lang.GetNPCName(NPCID.DukeFishron)}", new int[]
                {
                    ItemID.Flairon,
                    ItemID.BubbleGun,
                    ItemID.RazorbladeTyphoon,
                    ItemID.TempestStaff,
                    ItemID.Tsunami
                });
                RecipeGroup.RegisterGroup("ExoticFruits:FishronItems", fishronDrops);

                if (ExoticFruits.enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, fishronDrops);

                }
                if (ExoticFruits.enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, fishronDrops);
                }
            }
        }

    }
}