using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIInventoryDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject m_DescriptionPanel;
    //mouse over start
    public void OnPointerEnter(PointerEventData eventData)
    {
        m_DescriptionPanel.SetActive(true);
        m_DescriptionPanel.transform.position = eventData.position;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_DescriptionPanel.SetActive(false);
    }
    // mouse over finish
}
