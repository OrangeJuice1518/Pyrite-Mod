using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Content.Items.Materials
{
    public class TwistedBranch : ModItem //Worm Tooth Alt. for the Pyre
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 25;
        }

        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 9;

            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.sellPrice(copper: 20);
        }
    }
}