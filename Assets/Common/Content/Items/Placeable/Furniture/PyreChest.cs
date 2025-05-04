using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Common.Content.Items.Placeable.Furniture
{
	public class PyreChest : ModItem
	{
		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.PyreChest>());
			// Item.placeStyle = 1; // Use this to place the chest in its locked style
			Item.width = 32;
			Item.height = 32;
		}

	    public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<Other.PyreKey>())
				.AddCustomShimmerResult(ModContent.ItemType<Other.PyreKey>())
                .Register();
		}
	}
}
