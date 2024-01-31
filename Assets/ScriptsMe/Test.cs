using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(TypeWriterEffect());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerable TypeWriterEffect()
    {
        string actualText = "This is an approved message";
        int charCount = 0;
        while (charCount < actualText.Length)
        {
            
            yield return new WaitForSeconds(0.05f);
        }
    }
}
