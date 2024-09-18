using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftRecipe
{
   public int[] requiredItems;
   public int itemToCraft;

   public CraftRecipe(int itemToCraft, int[] requiredItems)
   {
      this.itemToCraft = itemToCraft;
      this.requiredItems = requiredItems;
   }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
