﻿using Terraria;
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
        public int bigFruitsConsumed = 0;
        public override void ResetEffects()
        {
            // vanilla fruits
            foreach (byte fruitConsumed in fruitsConsumed)
            {
                Player.statLifeMax2 += ExoticFruits.LifePerFruit * Math.Min(fruitConsumed, ExoticFruits.MaxFruits);
                Player.statManaMax2 += ExoticFruits.ManaPerFruit * Math.Min(fruitConsumed, ExoticFruits.MaxFruits);
            }

            // calamity fruits
            LoadCalamityFruitStats();

            string name = Player.name;
            Player.statLifeMax2 += ExoticFruits.BigFruitValue * Math.Min(bigFruitsConsumed, ExoticFruits.MaxFruits);
            Player.statManaMax2 += ExoticFruits.BigFruitValue * Math.Min(bigFruitsConsumed, ExoticFruits.MaxFruits);
        }

        private bool LoadCalamityFruitStats()
        {
            if (!ExoticFruits.calamityLoaded) return false;
            foreach (byte calamityFruitConsumed in calamityFruitsConsumed)
            {
                Player.statLifeMax2 += ExoticFruits.LifePerFruit * Math.Min(calamityFruitConsumed, ExoticFruits.MaxFruits);
                Player.statManaMax2 += ExoticFruits.ManaPerFruit * Math.Min(calamityFruitConsumed, ExoticFruits.MaxFruits);
            }
            return true;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            //packet.Write((byte)ExampleMod.MessageType.ExamplePlayerSyncPlayer);
            packet.Write((byte)Player.whoAmI);
            packet.Write(fruitsConsumed);
            packet.Write(calamityFruitsConsumed);
            packet.Write(bigFruitsConsumed);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["ExoticFruitss"] = fruitsConsumed;
            tag["ExoticFruitssCalamity"] = calamityFruitsConsumed;
            tag["exoticFruitsBigFruit"] = bigFruitsConsumed;
        }

        public override void LoadData(TagCompound tag)
        {
            try
            {
                fruitsConsumed = (byte[])tag["ExoticFruitss"];
            }
            catch (System.Exception)
            {

            }
            try
            {
                calamityFruitsConsumed = (byte[])tag["ExoticFruitssCalamity"];
            }
            catch (System.Exception)
            {

            }
            try
            {
                bigFruitsConsumed = (int)tag["exoticFruitsBigFruit"];
            }
            catch (System.Exception)
            {

            }
        }
    }
}
