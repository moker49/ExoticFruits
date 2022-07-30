using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using ExoticFruits.Items;

namespace ExoticFruits
{
    public class ExoticFruitsPlayer : ModPlayer
    {
        public byte[] exoticFruits = new byte[10];
        public int exoticFruitsBig = 0;

        public override void ResetEffects()
        {
            foreach (byte item in exoticFruits)
            {
                Player.statLifeMax2 += item * ExoticFruits.LifePerFruit;
                Player.statManaMax2 += item * ExoticFruits.ManaPerFruit;
            }
            Player.statLifeMax2 += exoticFruitsBig * ExoticFruits.BigFruitValue;
            Player.statManaMax2 += exoticFruitsBig * ExoticFruits.BigFruitValue;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            //packet.Write((byte)ExampleMod.MessageType.ExamplePlayerSyncPlayer);
            packet.Write((byte)Player.whoAmI);
            packet.Write(exoticFruits);
            packet.Write(exoticFruitsBig);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["ExoticFruitss"] = exoticFruits;
            tag["ExoticFruitsBig"] = exoticFruitsBig;
        }

        public override void LoadData(TagCompound tag)
        {
            try
            {
                exoticFruits = (byte[])tag["ExoticFruitss"];
                exoticFruitsBig = (int)tag["ExoticFruitsBig"];
            }
            catch (System.Exception)
            {

            }
        }
    }
}
