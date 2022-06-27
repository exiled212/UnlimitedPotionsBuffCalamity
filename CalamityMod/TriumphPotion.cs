using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class TriumphPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "TriumphPotion";
        }

        protected override string GetBuffName() {
            return "TriumphBuff";
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
