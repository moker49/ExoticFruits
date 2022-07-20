using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
    internal class ExoticFruitsShard0 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pitaya Fruit Essense");
            Tooltip.SetDefault($"Use this to make exotic fruits!");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.SoulofFlight);
        }
    }
}