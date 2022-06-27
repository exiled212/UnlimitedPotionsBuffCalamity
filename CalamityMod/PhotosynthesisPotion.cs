using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class PhotosynthesisPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "PhotosynthesisPotion";
        }

        protected override string GetBuffName() {
            return "PhotosynthesisBuff";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {
            // Not implement
        }
    }
}
