using UnityEngine;
using System.Collections.Generic;
using System.Collections;
[System.Serializable]

public class Inventory
{
  [System.Serializable]
   public class Slot
    {
        // attributes of a slot
        public CollectableType type;
        public int count; // num of items in the slot
        public int maxAllowed; // max amt of items in the slot
        
        public Slot()
        {
            type = CollectableType.NONE;
            count = 0;
            maxAllowed = 10;
        }

        public bool CanAddItem()
        {
            if (count < maxAllowed)
            {
                return true;
            }
            return false;
        }

        public void AddItem(CollectableType type)
        {
            this.type = type;
            count++;
        }
    }
    // list of slots for items
    public List<Slot> slots = new List<Slots>();

    public Inventory(int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }
    // let player add items to inventory when they pick them up
    public void Add(CollectableType typeToAdd)
    {
        //search inv for items that are same
        foreach(Slot slot in slots)
        {
            if(slot.type == typeToAdd && slot.CanAddItem())
            {
                // add item to inv
                slot.AddItem(typeToAdd);
                return;
            }
        }
        //add item if we dont have it yet/ slot full
        foreach (Slot slot in slots)
        {
            // slot empty --> add item to slot
            if (slot.type == CollectbleType.NONE)
            {
                slot.AddItem(typeToAdd);
                return;
            }
        }
    }
}
