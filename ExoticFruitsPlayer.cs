using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using ExoticFruits.Items;

namespace ExoticFruits
{
    public class ExoticFruitsPlayer : ModPlayer
    {
        public byte[] exoticFruits = new byte[10];

        public override void ResetEffects()
        {
            foreach (byte item in exoticFruits)
            {
                Player.statLifeMax2 += item * ExoticFruitsFruit.LifePerFruit;
                Player.statManaMax2 += item * ExoticFruitsFruit.ManaPerFruit;
            }

        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            //packet.Write((byte)ExampleMod.MessageType.ExamplePlayerSyncPlayer);
            packet.Write((byte)Player.whoAmI);
            packet.Write(exoticFruits);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["ExoticFruitss"] = exoticFruits;
        }

        public override void LoadData(TagCompound tag)
        {
            exoticFruits = (byte[])tag["ExoticFruitss"];
        }
    }
}
