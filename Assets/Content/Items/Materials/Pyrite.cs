using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Content.Items.Materials
{
    public class Pyrite : ModItem //Pyre Alt. for Cursed Flame
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 25;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.sellPrice(copper: 20);
        }
    }
}