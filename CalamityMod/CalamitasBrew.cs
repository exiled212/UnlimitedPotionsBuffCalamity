using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class CalamitasBrew : CalamityItemBase {

        protected override string GetItemName() {
            return "CalamitasBrew";
        }

        protected override string GetBuffName() {
            return "AbyssalWeapon";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {
            // Not used
        }
    }
}
