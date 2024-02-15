using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    //cours coroutine
    [SerializeField] private TextMeshProUGUI m_Text;

    //cours audio


    void Start()
    {
       // StartCoroutine(TypeWriterEffect());
    }


    void Update()
    {
        
    }

    //cours coroutine
    private IEnumerable TypeWriterEffect()
    {
        string actualText = "This is an approved message";
        int charCount = 0;
        while (charCount < actualText.Length)
        {
            
            yield return new WaitForSeconds(0.05f);
        }
    }

    //cours audio
}
