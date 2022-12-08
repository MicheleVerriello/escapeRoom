using System.Collections;
using UnityEngine;
using TMPro;

public class DialogHasbulla : MonoBehaviour
{
    public GameObject dialogCanvas;
    public TextMeshProUGUI textDisplay;
    public GameObject continueButton;
    public string[] sentences;
    private int _index;
    public float typingSpeed;

    void Start()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDisplay.text == sentences[_index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[_index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (_index < sentences.Length - 1)
        {
            _index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            _index = 0;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
    }
}
