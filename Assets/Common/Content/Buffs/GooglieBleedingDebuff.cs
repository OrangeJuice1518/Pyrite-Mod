using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework.Graphics;
using PyreModPlus.Assets.Common.GlobalNPCs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Common.Content.Buffs
{
    public class Bleeding : ModBuff
    {
        public const int DefenseReduction = 8;

        //public override LocalizedText Description => base.Description.WithFormatArgs(DefenseReduction);

        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            tip = "Cannot regenerate life";
        }
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;  // Is it a debuff?
            Main.pvpBuff[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.defense -= DefenseReduction;
        }
        public static void DrawEffects(NPC npc, ref Color drawColor)
        {
            // This simple color effect indicates that the buff is active

            drawColor.R = 0;
        }
    }

    public class BleedingPlayer : ModPlayer
    {
        public bool FakeBleeding;

        public override void ResetEffects()
        {
            FakeBleeding = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (FakeBleeding)
            {
                Player.lifeRegenTime = 0;
            }
        }
    }
}