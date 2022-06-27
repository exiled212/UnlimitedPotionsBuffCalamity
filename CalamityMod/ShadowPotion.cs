using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class ShadowPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "ShadowPotion";
        }

        protected override string GetBuffName() {
            return "ShadowBuff";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {
        }

    }
}
