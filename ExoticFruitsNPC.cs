using Terraria.GameContent.ItemDropRules;

namespace ExoticFruits
{
    public class ExoticFruitsNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.VampireBat)
            {
                // This is where we add item drop rules for VampireBat, here is a simple example:
                npcLoot.Add(ItemDropRule.Common(ItemID.Shackle, 1, 10, 15));
            }
        }
    }
}