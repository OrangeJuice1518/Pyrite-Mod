using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PyreModPlus.Assets.Common.Content.Items.Ammo
{
    public class BloodyArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 99;
        }
        public override void SetDefaults()
        {
            Item.width = 7;
            Item.height = 16;

            Item.damage = 9;
            Item.DamageType = DamageClass.Ranged;

            Item.maxStack = Item.CommonMaxStack; // 9999.
            Item.consumable = true;
            Item.knockBack = 3f; // At the time of writing this, the same as the Unholy Arrow.
            Item.value = Item.sellPrice(copper: 8);
            Item.shoot = ModContent.ProjectileType<Projectiles.BloodyArrow>();
            Item.shootSpeed = 3.4f; // Ditto.
            Item.ammo = AmmoID.Arrow;
        }

        //public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        //{
        //    target.AddBuff(BuffID.Bleeding, 360);
        //}
        public override void AddRecipes()
        {
            CreateRecipe(5)
                .AddIngredient<Other.BloodClot>()
                .AddIngredient(ItemID.WoodenArrow, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}