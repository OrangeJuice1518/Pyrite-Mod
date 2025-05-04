using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ObjectInteractions;
using Terraria.Localization;


namespace PyreModPlus.Assets.Common.Content.Items.Other
{
    public class PyreKey : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1; // Consistent with vanilla.
        }

        public override void SetDefaults()
        {
                Item.CloneDefaults(ItemID.GoldenKey);
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            var line = new TooltipLine(Mod, "Pyre Key", "Unlocks a Pyre Chest in the dungeon");
            //var line = new TooltipLine(Mod, "Pyre Key", "It has been cursed by a powerful Jungle creature");
            tooltips.Add(line);
        }
        
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Placeable.Furniture.PyreChest>())
                .AddCustomShimmerResult(ModContent.ItemType<Placeable.Furniture.PyreChest>())
                .Register();
        }
    }
}
