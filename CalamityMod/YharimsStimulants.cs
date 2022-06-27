using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class YharimsStimulants : CalamityItemBase {

        protected override string GetItemName() {
            return "YharimsStimulants";
        }

        protected override string GetBuffName() {
            return "YharimPower";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(Recipe recipe) {

            int endurancePotionId = RootMod.Find<ModItem>( "EndurancePotion" ).Type;
            int ironskinPotionId = RootMod.Find<ModItem>( "IronskinPotion" ).Type;
            int swiftnessPotionId = RootMod.Find<ModItem>( "SwiftnessPotion" ).Type;
            int archeryPotionId = RootMod.Find<ModItem>( "ArcheryPotion" ).Type;
            int magicPowerPotionId = RootMod.Find<ModItem>( "MagicPowerPotion" ).Type;
            int titanPotionId = RootMod.Find<ModItem>( "TitanPotion" ).Type;

            recipe.AddIngredient( endurancePotionId, 1);
            recipe.AddIngredient( ironskinPotionId, 1);
            recipe.AddIngredient( swiftnessPotionId, 1);
            recipe.AddIngredient( archeryPotionId, 1);
            recipe.AddIngredient( magicPowerPotionId, 1);
            recipe.AddIngredient( titanPotionId, 1);
        }
    }
}
