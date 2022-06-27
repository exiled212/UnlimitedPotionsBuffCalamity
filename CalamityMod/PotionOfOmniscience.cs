using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class PotionOfOmniscience : CalamityItemBase {

        protected override string GetItemName() {
            return "PotionofOmniscience";
        }

        protected override string GetBuffName() {
            return "Omniscience";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {
            int hunterPotionId = RootMod.Find<ModItem>( "HunterPotion" ).Type;
            int spelunkerPotionId = RootMod.Find<ModItem>( "SpelunkerPotion" ).Type;
            int dangersensePotionId = RootMod.Find<ModItem>( "DangersensePotion" ).Type;

            recipe.AddIngredient( hunterPotionId, 1);
            recipe.AddIngredient( spelunkerPotionId, 1);
            recipe.AddIngredient( dangersensePotionId, 1);
        }
    }
}
