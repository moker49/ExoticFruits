using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System;
using System.Collections.Generic;

namespace ExoticFruits
{
    public class ExoticFruitsPlayer : ModPlayer
    {
        public byte[] fruitsConsumed = new byte[10];
        public byte[] calamityFruitsConsumed = new byte[10];
        public byte[] catalystFruitsConsumed = new byte[10];
        public int bigFruitsConsumed = 0;
        public override void ResetEffects()
        {
            // vanilla fruits
            foreach (byte fruitConsumed in fruitsConsumed)
            {
                Player.statLifeMax2 += ExoticFruits.LifePerFruit * Math.Min(fruitConsumed, ExoticFruits.MaxFruits);
                Player.statManaMax2 += ExoticFruits.ManaPerFruit * Math.Min(fruitConsumed, ExoticFruits.MaxFruits);
            }

            // other mod fruits
            LoadModFruitStats();

            string name = Player.name;
            Player.statLifeMax2 += ExoticFruits.BigFruitValue * Math.Min(bigFruitsConsumed, ExoticFruits.MaxFruits);
            Player.statManaMax2 += ExoticFruits.BigFruitValue * Math.Min(bigFruitsConsumed, ExoticFruits.MaxFruits);
        }

        private void LoadModFruitStats()
        {
            // calamity
            if (!ExoticFruits.calamityLoaded)
            {
                foreach (byte calamityFruitConsumed in calamityFruitsConsumed)
                {
                    Player.statLifeMax2 += ExoticFruits.LifePerFruit * Math.Min(calamityFruitConsumed, ExoticFruits.MaxFruits);
                    Player.statManaMax2 += ExoticFruits.ManaPerFruit * Math.Min(calamityFruitConsumed, ExoticFruits.MaxFruits);
                }
            }

            // catalyst
            if (!ExoticFruits.catalystLoaded)
            {
                foreach (byte catalystFruitConsumed in catalystFruitsConsumed)
                {
                    Player.statLifeMax2 += ExoticFruits.LifePerFruit * Math.Min(catalystFruitConsumed, ExoticFruits.MaxFruits);
                    Player.statManaMax2 += ExoticFruits.ManaPerFruit * Math.Min(catalystFruitConsumed, ExoticFruits.MaxFruits);
                }
            }
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            //packet.Write((byte)ExampleMod.MessageType.ExamplePlayerSyncPlayer);
            packet.Write((byte)Player.whoAmI);
            packet.Write(fruitsConsumed);
            packet.Write(calamityFruitsConsumed);
            packet.Write(catalystFruitsConsumed);
            packet.Write(bigFruitsConsumed);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["ExoticFruitss"] = fruitsConsumed;
            tag["ExoticFruitssCalamity"] = calamityFruitsConsumed;
            tag["ExoticFruitssCatalyst"] = catalystFruitsConsumed;
            tag["exoticFruitsBigFruit"] = bigFruitsConsumed;
        }

        public override void LoadData(TagCompound tag)
        {
            try
            {
                fruitsConsumed = (byte[])tag["ExoticFruitss"];
            }
            catch (Exception) { }
            try
            {
                calamityFruitsConsumed = (byte[])tag["ExoticFruitssCalamity"];
            }
            catch (Exception) { }
            try
            {
                catalystFruitsConsumed = (byte[])tag["ExoticFruitssCatalyst"];
            }
            catch (Exception) { }
            try
            {
                bigFruitsConsumed = (int)tag["exoticFruitsBigFruit"];
            }
            catch (Exception) { }
        }
    }
}
