using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ExoticFruits.Configs
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Header("recipes")]

		[DefaultValue(true)]
		[ReloadRequired]
		public bool enableFruitShards;

		[DefaultValue(false)]
		[ReloadRequired]
		public bool enableCrystalRecipes;

		[DefaultValue(true)]
		[ReloadRequired]
		public bool enableFruitRecipes;


		[Header("requirements")]

		[Range(100, 500)]
		[Increment(100)]
		[DefaultValue(400)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int lifeRequired;

		[Range(0, 200)]
        [Increment(100)]
		[DefaultValue(0)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int manaRequired;


		[Header("stat_gain")]

		[Range(1, 4)]
		[DefaultValue(1)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int maxFruits;

		[Range(5, 25)]
		[Increment(5)]
		[DefaultValue(10)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int lifePerFruit;

		[Range(5, 25)]
		[Increment(5)]
		[DefaultValue(10)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int manaPerFruit;

		[Range(10, 150)]
		[Increment(10)]
		[DefaultValue(30)]
		[Slider]
		[ReloadRequired]
		public int potionDefenseValue;

		[Range(20, 480)]
		[Increment(20)]
		[DefaultValue(60)]
		[Slider]
		[ReloadRequired]
		public int potionDefenseDuration;
	}
}
