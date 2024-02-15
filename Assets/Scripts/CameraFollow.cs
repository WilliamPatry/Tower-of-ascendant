using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject m_Follow;

    private Vector3 m_OffSet;

    void Start()
    {
        m_OffSet = transform.position - m_Follow.transform.position;
    }


    void Update()
    {
        Vector3 position = transform.position;
        position = m_Follow.transform.position + m_OffSet;
        transform.position = position;
    }
}
