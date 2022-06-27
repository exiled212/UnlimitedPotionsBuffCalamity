using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class TitanScalePotion : CalamityItemBase {

        protected override string GetItemName() {
            return "TitanScalePotion";
        }

        protected override string GetBuffName() {
            return "TitanScale";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {
            int titanPotionId = RootMod.Find<ModItem>( "TitanPotion" ).Type;
            recipe.AddIngredient( titanPotionId, 1);
        }
    }
}
