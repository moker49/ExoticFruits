using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruits6 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Loquat Fruit", (string)Lang.GetNPCName(NPCID.DukeFishron));
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItemBase(player, 6);
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItemBase(player, 6);
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