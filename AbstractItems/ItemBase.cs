using System.Collections.Generic;
using Terraria.ModLoader;

namespace UnlimitedPotionsBuffs.Items {
    public abstract class ItemBase : ModItem {

        protected string description = "Parece que el contenido de la posión se cristalizo.\n\tMarque el objeto como favorito para activar su efecto.";

        protected string nameBase = " cristalizada";

        protected abstract int GetRarityId();
        protected abstract int GetTileId();

        protected abstract List<RecipeData> RecipesData();

        protected class RecipeData {

            public int TileId { get; }

            public List<ItemData> ItemsData { get; }

            public RecipeData(int tileId, List<ItemData> itemsData) {
                TileId = tileId;
                ItemsData = itemsData;
            }

            public class ItemData {
                public int ItemId { get; }
                public int Stack { get; }

                public ItemData(int itemId, int stack) {
                    ItemId = itemId;
                    Stack = stack;
                }

            }

        }

    }
}
