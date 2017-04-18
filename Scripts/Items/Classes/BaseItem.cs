/*****************************BaseItem*************************************
 *Programmer: Christine Jordan
 *Class: BaseItem
 *Inheritance:
 *Date Created:
 *Date Modified:
 *Project:
 ***************************************************************************/
 [System.Serializable]
public class BaseItem
{
    private string itemName;
    private string itemDescription;
    private int itemID;
    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,
        CHEST
    }

    private ItemTypes itemType;

/***************************Getters&Setters**********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public string ItemName { get; set; }
    public string ItemDescription { get; set; }
    public int ItemID { get; set; }
    public ItemTypes ItemType { get; set; }
//End Getters&Setters
}
