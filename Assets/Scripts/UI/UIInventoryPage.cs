using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryPage : MonoBehaviour
{
    [SerializeField] private UIInventoryItem m_itemPrefab;
    [SerializeField] private RectTransform m_contentPanel;

    List<UIInventoryItem> m_listeOfUIItems = new List<UIInventoryItem>();

    public void InitializeInventoryUI(int inventorySize)
    {
        for (int i = 0; i < inventorySize; i++) 
        {
            UIInventoryItem uiItem = Instantiate(m_itemPrefab, m_contentPanel);
            m_listeOfUIItems.Add(uiItem);
            uiItem.OnItemClicked += HandleItemSelection;
            uiItem.OnItemBeginDrag += HandleBeginDrag;
            uiItem.OnItemDroppedOn += HandleSwap;
            uiItem.OnItemEndDrag += HandleEndDrag;
            uiItem.OnRightMouseBtnClicked += HandleShowItemActions;
        }
    }

    private void HandleShowItemActions(UIInventoryItem item)
    {
       
    }

    private void HandleEndDrag(UIInventoryItem item)
    {
    }

    private void HandleSwap(UIInventoryItem item)
    {
        
    }

    private void HandleBeginDrag(UIInventoryItem item)
    {
        
    }

    private void HandleItemSelection(UIInventoryItem item)
    {
        Debug.Log(item.name);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
