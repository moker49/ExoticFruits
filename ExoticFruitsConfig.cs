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
		[DrawTicks]
		[OptionStrings(new string[] { "50", "200", "400", "500" })]
		[DefaultValue("400")]
		public string lifeRequired;

		[Label("Mana Requirement")]
		[Tooltip("Maximum Mana Required To Consume Fruits")]
		[DrawTicks]
		[OptionStrings(new string[] { "0", "100", "200" })]
		[DefaultValue("0")]
		public string manaRequired;


		[Header("Stat Gain")]

		[Label("Maximum Fruit Consumptions")]
		[Tooltip("How many times can the same fruit be consumed")]
		[DrawTicks]
		[OptionStrings(new string[] { "1", "2", "3", "4" })]
		[DefaultValue("1")]
		[ReloadRequired]
		public string maxFruits;

		[Label("Life Gain Per Fruit")]
		[DrawTicks]
		[OptionStrings(new string[] { "5", "10", "15", "20", "25" })]
		[DefaultValue("10")]
		[ReloadRequired]
		public string lifePerFruit;

		[Label("Mana Gain Per Fruit")]
		[DrawTicks]
		[OptionStrings(new string[] { "5", "10", "15", "20", "25" })]
		[DefaultValue("10")]
		[ReloadRequired]
		public string manaPerFruit;
	}
}
