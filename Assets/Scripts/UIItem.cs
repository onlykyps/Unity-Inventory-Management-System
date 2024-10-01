using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItem
{
   public Item item;
    private Image spriteImage;
    private UIItem selectedItem;
    private Tooltip tooltip;
    public bool craftingSlot = false;
    private CraftingSlots craftingSlots;
    public bool craftedItemSlot = false;


    private void Awake()
    {
        craftingSlots = FindObjectOfType<CraftingSlots>();
        tooltip = FindObjectOfType<Tooltip>();
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        spriteImage = GetComponent<Image>();
        UpdateItem(null);
    }

    public void UpdateItem(Item item)
    {
        this.item = item;
        if (this.item != null)
        {
            spriteImage.color = Color.white;
            spriteImage.sprite = item.icon;     
        }
        else
        {
            spriteImage.color = Color.clear;
        }
        if(craftingSlot)
        {
            craftingSlots.UpdateRecipe();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (this.item != null)
        {
            if (selectedItem.item != null && !craftedItemSlot)
            {
                Item clone = new Item(selectedItem.item);
                selectedItem.UpdateItem(this.item);
                UpdateItem(clone);
            }
            else if (selectedItem.item == null)
            {
                selectedItem.UpdateItem(this.item);
                if (craftedItemSlot)
                {
                    GetComponent<UICraftResult>().CollectCraftResult(this.item);
                }
                UpdateItem(null);
            }
        }
        else if (selectedItem.item != null && !craftedItemSlot)
        {
            UpdateItem(selectedItem.item);
            selectedItem.UpdateItem(null);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (this.item != null)
        {
            tooltip.GenerateTooltip(item);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.gameObject.SetActive(false);
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
