﻿using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ExoticFruits.Configs
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Header("recipes")]

		// [Label("[i:1611] Custom Boss Ingredients")]
		// [Tooltip("Bosses that don't drop crafting ingredients will now do so, for the fruits.\nDisabling this will force the player to use weapon drops from those bosses to make the fruits.")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool enableFruitShards;

		// [Label("[i:29] Life Crystal Recipes")]
		// [Tooltip("Enable recipes with Life Crystals")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool enableCrystalRecipes;

		// [Label("[i:1291] Life Fruit Recipes")]
		// [Tooltip("Enable recipes with Life Fruits")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool enableFruitRecipes;


		[Header("requirements")]

		// [Label("[i:29] Life Requirement")]
		// [Tooltip("Maximum Life Required To Consume Fruits")]
		[Range(100, 500)]
		[Increment(100)]
		[DefaultValue(400)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int lifeRequired;

		// [Label("[i:109] Mana Requirement")]
		// [Tooltip("Maximum Mana Required To Consume Fruits")]
		[Range(0, 200)]
        [Increment(100)]
		[DefaultValue(0)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int manaRequired;


		[Header("stat_gain")]

		// [Label("[i:18] Maximum Fruit Consumptions")]
		// [Tooltip("How many times can the same fruit be consumed")]
		[Range(1, 4)]
		[DefaultValue(1)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int maxFruits;

		// [Label("[i:188] Life Gain Per Fruit")]
		[Range(0, 25)]
		[Increment(5)]
		[DefaultValue(10)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int lifePerFruit;

		// [Label("[i:189] Mana Gain Per Fruit")]
		[Range(0, 25)]
		[Increment(5)]
		[DefaultValue(10)]
		[Slider]
		[DrawTicks]
		[ReloadRequired]
		public int manaPerFruit;

		// [Label("[i:292] Defense Potion Strength")]
		[Range(10, 120)]
		[Increment(10)]
		[DefaultValue(30)]
		[Slider]
		[ReloadRequired]
		public int potionDefenseValue;

		// [Label("[i:17] Defense Potion Duration")]
		// [Tooltip("Duration in minutes")]
		[Range(0, 480)]
		[Increment(20)]
		[DefaultValue(60)]
		[Slider]
		[ReloadRequired]
		public int potionDefenseDuration;
	}
}
