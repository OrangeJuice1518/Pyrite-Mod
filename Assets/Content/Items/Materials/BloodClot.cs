using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Content.Items.Materials
{
    public class BloodClot : ModItem // Did you know that the Worm Tooth's Item ID is 69?
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 25;
        }

        public override void SetDefaults()
        {
            Item.width = 9; // The item texture's width
            Item.height = 9; // The item texture's height

            Item.maxStack = Item.CommonMaxStack; // The item's max stack value. In this case, 9999.
            Item.value = Item.sellPrice(copper: 20); // The value of the item. This is the same as the Worm Tooth
        }
    }
}