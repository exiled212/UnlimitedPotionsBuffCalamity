﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class SoaringPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "SoaringPotion";
        }

        protected override string GetBuffName() {
            return "Soaring";
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
