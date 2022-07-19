using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ExoticFruits.Configs
{
	public class ExoticFruitsConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Header("Recipes")]

		[Label("Use Life Fruit Recipes")]
		[Tooltip("Toggle this ON to enable recipes with Life Fruit")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool enableFruitRecipes;

		[Label("Use Life Crystal Recipes")]
		[Tooltip("Toggle this ON to enable recipes with Life Crystals")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool enableCrystalRecipes;


		[Header("Requirements")]

		[Label("Life Requirement")]
		[Tooltip("Maximum Life Required To Consume Fruits")]
		[Range(100, 500)]
		[Increment(100)]
		[DefaultValue(400)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int lifeRequired;

		[Label("Mana Requirement")]
		[Tooltip("Maximum Mana Required To Consume Fruits")]
		[Range(0, 200)]
        [Increment(100)]
		[DefaultValue(0)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int manaRequired;


		[Header("Stat Gain")]

		[Label("Maximum Fruit Consumptions")]
		[Tooltip("How many times can the same fruit be consumed")]
		[Range(1, 4)]
		[DefaultValue(1)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int maxFruits;

		[Label("Life Gain Per Fruit")]
		[Range(0, 25)]
		[Increment(5)]
		[DefaultValue(10)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int lifePerFruit;

		[Label("Mana Gain Per Fruit")]
		[Range(0, 25)]
		[Increment(5)]
		[DefaultValue(10)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int manaPerFruit;
	}
}
