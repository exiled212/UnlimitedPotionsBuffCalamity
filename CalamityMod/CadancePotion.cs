using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class CadancePotion : CalamityItemBase {

        protected override string GetItemName() {
            return "CadancePotion";
        }

        protected override string GetBuffName() {
            return "CadancesGrace";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {
            int heartreachPotionId = RootMod.Find<ModItem>( "HeartreachPotion" ).Type;
            int lifeforcePotionId = RootMod.Find<ModItem>( "LifeforcePotion" ).Type;
            int regenerationPotionId = RootMod.Find<ModItem>( "RegenerationPotion" ).Type;

            recipe.AddIngredient( heartreachPotionId, 1);
            recipe.AddIngredient( lifeforcePotionId, 1);
            recipe.AddIngredient( regenerationPotionId, 1);
        }
    }
}
