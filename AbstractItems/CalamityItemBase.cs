using UnlimitedPotionsBuffs.Items;
using Terraria.ModLoader;
using Terraria;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.ID;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class CalamityItemBase : ItemBase {

        protected Mod CalamityMod = ModLoader.GetMod("CalamityMod");

        protected Mod RootMod = ModLoader.GetMod( "UnlimitedPotionsBuffs" );

        protected abstract string GetItemName();
        protected abstract string GetBuffName();

        public override string Texture => (CalamityMod != null)?"CalamityMod/Items/Potions/" + GetItemName(): "UnlimitedPotionsBuffs/Textures/Default";

        public override void SetStaticDefaults() {
            if ( CalamityMod != null && RootMod != null ) {
                ModBuff currentBuff = CalamityMod.Find<ModBuff>( GetBuffName() );
                string descriptionBuff = currentBuff.Description.GetTranslation( (int) GameCulture.CultureName.Spanish );
                description += "\n\t" + descriptionBuff;
                Tooltip.SetDefault( description );
            }
        }

        public override void SetDefaults() {
            if ( CalamityMod != null && RootMod != null ) {
                int itemId = CalamityMod.Find<ModItem>(GetItemName()).Type;
                Item baseItem = new();
                baseItem.SetDefaults(itemId);
                Item.SetNameOverride(baseItem.Name + nameBase);
                Item.width = baseItem.width;
                Item.height = baseItem.height;
                Item.accessory = true;
                Item.consumable = false;
                Item.value = Item.sellPrice(platinum: 1);
                Item.rare = GetRarityId();
                Item.maxStack = 1;
            }
        }

        protected override List<RecipeData> RecipesData() {
            if ( CalamityMod != null && RootMod != null ) {
                int itemId = CalamityMod.Find<ModItem>( GetItemName() ).Type;
                int maxStacks = 30; //I not use maxStak from itemId because is 999 stacks.
                int gemsLockId = RootMod.Find<ModItem>( "GemsLock" ).Type;

                return new List<RecipeData> {
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, 1),
                        new RecipeData.ItemData(gemsLockId, 1)
                    }),
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, maxStacks),
                        new RecipeData.ItemData(ItemID.LargeAmber, 1)
                    }),
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, maxStacks),
                        new RecipeData.ItemData(ItemID.LargeAmethyst, 1)
                    }),
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, maxStacks),
                        new RecipeData.ItemData(ItemID.LargeDiamond, 1)
                    }),
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, maxStacks),
                        new RecipeData.ItemData(ItemID.LargeEmerald, 1)
                    }),
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, maxStacks),
                        new RecipeData.ItemData(ItemID.LargeRuby, 1)
                    }),
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, maxStacks),
                        new RecipeData.ItemData(ItemID.LargeSapphire, 1)
                    }),
                    new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                        new RecipeData.ItemData(itemId, maxStacks),
                        new RecipeData.ItemData(ItemID.LargeTopaz, 1)
                    })
                };
            }
            else {
                return new List<RecipeData>();
            }
        }

        public override void AddRecipes() {
            if ( CalamityMod != null && RootMod != null ) {
                foreach ( RecipeData recipeData in RecipesData() ) {
                    if ( recipeData.ItemsData.Count > 0 ) {
                        Recipe recipe = CreateRecipe();
                        recipe.AddTile( recipeData.TileId );
                        foreach ( RecipeData.ItemData itemData in recipeData.ItemsData ) {
                            recipe.AddIngredient( itemData.ItemId, itemData.Stack );
                        }
                        AddIngredients( recipe );
                        recipe.Register();
                    }
                }
            }
        }

        protected abstract void AddIngredients(Recipe recipe);

        public override void UpdateInventory(Player player) {
            if ( CalamityMod != null && RootMod != null ) {
                if ( Item.favorited ) {
                    int buffId = CalamityMod.Find<ModBuff>( GetBuffName() ).Type;
                    player.AddBuff( buffId, 1, false );
                }
            }
        }

    }
}
