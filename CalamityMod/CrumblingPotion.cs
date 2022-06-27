using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class CrumblingPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "CrumblingPotion";
        }

        protected override string GetBuffName() {
            return "ArmorCrumbling";
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
