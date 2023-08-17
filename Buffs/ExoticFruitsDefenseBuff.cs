using Terraria;
using Terraria.ModLoader;

namespace ExoticFruits.Buffs
{
	public class ExoticFruitsDefenseBuff : ModBuff
	{

		public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += ExoticFruits.PotionDefenseValue; 
		}
	}
}
