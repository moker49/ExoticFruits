using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ExoticFruits.Items.Shards
{
    internal class LifeFruitShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
        }
    }
}