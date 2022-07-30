using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ExoticFruits.Configs
{
	public class ExoticFruitsConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Header("Recipes")]

		[Label("Custom Boss Ingredients")]
		[Tooltip("Bosses that don't drop crafting ingredients will now do so, for the fruits.\nDisabling this will force the player to use weapon drops from those bosses to make the fruits.")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool enableFruitShards;

		[Label("Life Fruit Recipes")]
		[Tooltip("Enable recipes with Life Fruits")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool enableFruitRecipes;

		[Label("Life Crystal Recipes")]
		[Tooltip("Enable recipes with Life Crystals")]
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
