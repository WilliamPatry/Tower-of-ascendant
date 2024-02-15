using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] private UIInventoryPage m_inventoryUI;

    public int m_inventorySize = 10;
    private void Start()
    {
        m_inventoryUI.InitializeInventoryUI(m_inventorySize);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) 
        {
            if (m_inventoryUI.isActiveAndEnabled == false) 
            {
                m_inventoryUI.Show();
            }
            else
            {
                m_inventoryUI.Hide();
            }
        }
    }
}
