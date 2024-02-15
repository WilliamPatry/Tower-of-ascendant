using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIInventoryItem : MonoBehaviour
{
    [SerializeField] private Image m_itemImage;
    [SerializeField] private TMP_Text m_quantityTxt;
    [SerializeField] private Image m_borderImage;
    
    public event Action<UIInventoryItem> OnItemClicked,
        OnItemDroppedOn, OnItemBeginDrag, OnItemEndDrag, OnRightMouseBtnClicked;

    private bool m_empty = true;

    public void Awake()
    {
        ResetData();
        Deselect();
    }
    public void ResetData()
    {
        this.m_itemImage.gameObject.SetActive(false);
    }
    public void Deselect()
    {
        m_borderImage.enabled = false;
    }
    public void SetData(Sprite sprite, int quantity)
    {
        this.m_itemImage.gameObject.SetActive(true);
        this.m_itemImage.sprite = sprite;
        this.m_quantityTxt.text = quantity + "";
        this.m_empty = false;
    }

    public void Select()
    {
        this.m_borderImage.enabled = true;
    }

    public void OnBeginDrag()
    {
        if(m_empty) return;
        OnItemBeginDrag?.Invoke(this);
    }

    public void OnDrop()
    {
        OnItemDroppedOn?.Invoke(this);
    }

    public void OnEndDrag()
    {
        OnItemEndDrag.Invoke(this);
    }

    public void OnPointerClick(BaseEventData data)
    {
        if (m_empty) return;
        PointerEventData pointerData = (PointerEventData)data;
        if (pointerData.button == PointerEventData.InputButton.Right)
        {
            OnRightMouseBtnClicked?.Invoke(this);
        }
        else
        {
            OnItemClicked?.Invoke(this);
        }
    }
}
