using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private string text;

    private void Start()
    {
        text = GetComponent<Text>().text;
        GetComponent<Text>().text = "";
        StartCoroutine(TextCorutine());
    }


    IEnumerator TextCorutine()
    {
        foreach (char abc in text)
        {
            GetComponent<Text>().text += abc;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
