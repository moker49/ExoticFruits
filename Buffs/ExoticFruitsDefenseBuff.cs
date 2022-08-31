using Terraria;
using Terraria.ModLoader;

namespace ExoticFruits.Buffs
{
	public class ExoticFruitsDefenseBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Exoskin");
			Description.SetDefault($"Increases defense by {ExoticFruits.PotionDefenseValue}");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += ExoticFruits.PotionDefenseValue; 
		}
	}
}
