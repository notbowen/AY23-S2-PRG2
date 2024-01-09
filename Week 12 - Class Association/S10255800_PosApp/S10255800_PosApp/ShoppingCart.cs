namespace S10255800_PosApp;

public class ShoppingCart
{
    private List<CartItem> _itemList = new List<CartItem>();

    public ShoppingCart()
    {
    }
    
    public void AddItem(CartItem item)
    {
        if (!_itemList.Contains(item))
        {
            _itemList.Add(item);
            return;
        }

        _itemList[_itemList.IndexOf(item)].Qty += item.Qty;
    }

    public List<CartItem> GetItemList()
    {
        return _itemList;
    }

    public bool RemoveItem(int code)
    {
        CartItem? item = _itemList.FirstOrDefault(i => i.Code == code.ToString());
        if (item == null)
            return false;
        
        _itemList.Remove(item);
        return true;
    }

    public void ClearCart()
    {
        _itemList.Clear();
    }

    public int Size()
    {
        return _itemList.Count;
    }

    public bool IsEmpty()
    {
        return !_itemList.Any();
    }
}