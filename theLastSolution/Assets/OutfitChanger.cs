using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
  
    public SpriteRenderer bodyPart;

    public List<Sprite> options = new();

    private int m_CurrentOption = 0;
    public void NextOption()
    {
        
        if (m_CurrentOption < options.Count - 1)
        {
            m_CurrentOption = m_CurrentOption + 1;
        } 
        else
        {
            m_CurrentOption = 0;
        }

        Debug.Log("Sprite = " + bodyPart.sprite.ToString());
        Debug.Log("m_CurrentOption = " + m_CurrentOption);
        bodyPart.sprite = options[m_CurrentOption];
    }

    public void PreviousOption()
    {

        
        if (m_CurrentOption > 0)
        {
            m_CurrentOption = m_CurrentOption - 1;
        }
        else
        {
            m_CurrentOption = options.Count - 1;
        }

        bodyPart.sprite = options[m_CurrentOption];
    }

    public void Randomize()
    {
        m_CurrentOption = Random.Range(0, options.Count - 1);
        bodyPart.sprite = options[m_CurrentOption];
    }
}
