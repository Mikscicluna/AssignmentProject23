using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSizeSlider : MonoBehaviour
{
    public class slide : MonoBehaviour
{
    public Text text; 

    public void ChangeFontSize(float value) //Allow player to change their font size using slider
    {    
        ChangeFontSize( Mathf.RoundToInt( value ) ) ;
    }

    public void ChangeFontSize(int value)
    {    
        text.fontSize = value;    
    }
}
