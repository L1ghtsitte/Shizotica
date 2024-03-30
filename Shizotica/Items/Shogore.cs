using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shizotica.Items
{
	public class Shogore : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shogore");
			Tooltip.SetDefault("Меч сделаный из слизи и щуполец кальмара, похож на тентакли не правда ли?");
		}

		public override void SetDefaults()
		{
			Item.damage = 36;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 100000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}