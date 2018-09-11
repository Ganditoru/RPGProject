using UnityEngine;

public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite background = null;
    public Sprite img = null;
    public GameObject itemObj;

    public virtual void Use()
    {
         Debug.Log("Using " + name);
    }

    public void RemoveFromInventory()
    {
        //Inventory.instance.Remove(this);
    }

    public virtual string getDescription()
    {
        return "Not set yet";
    }

}
