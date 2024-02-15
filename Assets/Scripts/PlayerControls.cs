using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerControls : MonoBehaviour
{
    //[SerializeField] InGameUI GameUI;

    private NavMeshAgent m_agent;
    private float m_Damage = 10f;

    void Start()
    {
        m_agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Moving();
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
    void Moving()
    {
        if (Input.GetMouseButtonDown(0) && !IsMouseOverUI())
        {
            Ray moveTo = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(moveTo, out RaycastHit hitInfo))
            {
                m_agent.SetDestination(hitInfo.point);
                Debug.Log(hitInfo.collider.tag);
                if (hitInfo.collider.CompareTag("Enemies"))
                {
                    m_agent.stoppingDistance = 2;
                }
                //if (hitInfo.collider.CompareTag("Items"))
                //{
                //    //pick up item if inventory full drop item
                //}
            }
        }
    }

    void BasicAttack()
    {
        if(Input.GetMouseButtonDown(1)) 
        {

        }
    }

    private void dodge()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //dodge 
        }
    }
}

