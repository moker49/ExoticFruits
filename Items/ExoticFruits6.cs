using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruits6 : ExoticFruitsFruit
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaultsBase("Loquat Fruit");
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
            if (FruitShardsEnabled)
            {
                if (enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, ModContent.ItemType<Items.ExoticFruitsShard1>());
                }
                if (enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, ModContent.ItemType<Items.ExoticFruitsShard1>());
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

                if (enableFruitRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeFruit, fishronDrops);

                }
                if (enableCrystalRecipes)
                {
                    base.CreateFinalRecipe(ItemID.LifeCrystal, fishronDrops);
                }
            }
        }

    }
}