using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchBar : MonoBehaviour
{
    public TouchScreenKeyboard keyboard;
    public string keyboardText;
    public void OpenSystemKeyboard()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard != null)
        {
            keyboardText = keyboard.text;
            // Do stuff with keyboardText
        }
    }
}
