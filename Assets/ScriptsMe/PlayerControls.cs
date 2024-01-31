using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

    void Moving()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray moveTo = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(moveTo, out RaycastHit hitInfo))
            {
                m_agent.SetDestination(hitInfo.point);
                if (hitInfo.collider.CompareTag("Enemies"))
                {
                    m_agent.stoppingDistance = 2;
                }
            }
        }
    }

    void BasicAttack()
    {
        if(Input.GetMouseButtonDown(1)) 
        {

        }
    }
}

