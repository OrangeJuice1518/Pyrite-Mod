using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Content.Items.Materials
{
    public class ScorchedAsh : ModItem //Rotten Chunk Alt. for the Pyre
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 25;
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 8;

            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.sellPrice(copper: 20);
        }
    }
}