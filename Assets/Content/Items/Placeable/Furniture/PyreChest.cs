using Steamworks;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Content.Items.Placeable.Furniture
{
	public class PyreChest : ModItem
	{
		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Content.Tiles.Furniture.PyreChest>());
			// Item.placeStyle = 1; // Use this to place the chest in its locked style
			Item.width = 32;
			Item.height = 32;
		}

	    public override void SetStaticDefaults()
		{
			ItemID.Sets.ShimmerTransformToItem[Type] = ModContent.ItemType<PyreKey>();

		}
	}
}
