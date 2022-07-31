using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using ExoticFruits.Items;

namespace ExoticFruits
{
    public class ExoticFruitsPlayer : ModPlayer
    {
        public byte[] exoticFruits = new byte[10];
        public int exoticFruitsBigFruit = 0;

        public override void ResetEffects()
        {
            foreach (byte item in exoticFruits)
            {
                Player.statLifeMax2 += item * ExoticFruits.LifePerFruit;
                Player.statManaMax2 += item * ExoticFruits.ManaPerFruit;
            }
            Player.statLifeMax2 += exoticFruitsBigFruit * ExoticFruits.BigFruitValue;
            Player.statManaMax2 += exoticFruitsBigFruit * ExoticFruits.BigFruitValue;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            //packet.Write((byte)ExampleMod.MessageType.ExamplePlayerSyncPlayer);
            packet.Write((byte)Player.whoAmI);
            packet.Write(exoticFruits);
            packet.Write(exoticFruitsBigFruit);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["ExoticFruitss"] = exoticFruits;
            tag["exoticFruitsBigFruit"] = exoticFruitsBigFruit;
        }

        public override void LoadData(TagCompound tag)
        {
            try
            {
                exoticFruits = (byte[])tag["ExoticFruitss"];
            }
            catch (System.Exception)
            {

            }
            try
            {
                exoticFruitsBigFruit = (int)tag["exoticFruitsBigFruit"];
            }
            catch (System.Exception)
            {

            }
        }
    }
}
