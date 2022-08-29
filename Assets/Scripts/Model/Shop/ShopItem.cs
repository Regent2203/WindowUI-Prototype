namespace Model.Shop
{
    public class ShopItem
    {
        public readonly int Id;
        public readonly string Name;
        public readonly float Price;
        public readonly ShopItemType Type;
        public readonly int StackCount; //количество внутри одной "упаковки" покупаемого товара

        public ShopItem(int id, string name, float price, ShopItemType type, int stackCount = 1)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
            StackCount = stackCount;
        }
    }
}