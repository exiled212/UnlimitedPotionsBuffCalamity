using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class ProfanedRagePotion : CalamityItemBase {

        protected override string GetItemName() {
            return "ProfanedRagePotion";
        }

        protected override string GetBuffName() {
            return "ProfanedRageBuff";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {
            int ragePotionId = RootMod.Find<ModItem>( "RagePotion" ).Type;
            recipe.AddIngredient( ragePotionId, 1);
        }
    }
}
