using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Common.Content.Items.Weapons.Melee
{ 
	public class FlameFlayer: ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.pyremodplus.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 42;
			Item.DamageType = DamageClass.Melee;
            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.width = 38;
			Item.height = 36;
			Item.useTime = 4;
			Item.useAnimation = 4;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(platinum: 1);
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Projectiles.FlameFlayerProjectile>();
            Item.shootSpeed = 28;
        }

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

        public override void AddRecipes()
		{
		}
	}
}
