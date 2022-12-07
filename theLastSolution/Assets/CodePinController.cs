using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePinController : MonoBehaviour
{
    private string _winningCode = "1501";

    public GameObject errorText;
    public GameObject winningCanvas;
    public GameObject codeInputCanvas;
    // Start is called before the first frame update
    public void OnValueChanged(string value)
    {
        if (value.Equals(_winningCode))
        {
            winningCanvas.SetActive(false);
            winningCanvas.SetActive(true);
        }
        else if (value.Length == 4 && !value.Equals(_winningCode))
        {
            Debug.Log("Error");
            errorText.SetActive(true);
        }
        else
        {
            errorText.SetActive(false);
        }

    }
}
