using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ItemDataBase : MonoBehaviour
{
   public List<Item> items = new List<Item>();
   public Item item = new Item();

   void Awake()
   {
      BuildItemDatabase();
   }

   public Item GetItem(int id)
   {
      return items.Find(item => item.id == id);
   }

   void BuildItemDatabase()
   {
      items = new List<Item>()
      {
         new Item(
                  1,
                  "Diamod Sword", 
                  "a sword made of diamond", 
                  new Dictionary<string, int>
                     {
                        {"Power", 15},
                        {"Defence", 7}
                     }
               ),
         new Item(
                  2,
                  "Diamod Ore",
                  "a shiny diamond",
                  new Dictionary<string, int>
                     {
                        {"Value", 2500}
                     }
               ),
          new Item(
                  3,
                  "Steel Sword",
                  "a sword made of steel",
                  new Dictionary<string, int>
                     {
                        {"Power", 1},
                        {"Defence", 1}
                     }
               )
      };
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
