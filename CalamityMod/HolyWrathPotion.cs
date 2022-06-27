using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class HolyWrathPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "HolyWrathPotion";
        }

        protected override string GetBuffName() {
            return "HolyWrathBuff";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }
        
        protected override void AddIngredients(Recipe recipe) {
            int wrathPotionId = RootMod.Find<ModItem>( "WrathPotion" ).Type;
            recipe.AddIngredient( wrathPotionId, 1);
        }

    }
}
