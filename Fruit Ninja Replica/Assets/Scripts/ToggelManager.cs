using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggelManager : MonoBehaviour
{
    public Toggle checkBox;
    public Dropdown dd1;
    public Dropdown dd2;
    public Dropdown dd3;
    public Dropdown dd4;

    public void ChangeToggle()
    {
        if (checkBox.isOn == true)
        {
            dd1.interactable = true;
            dd2.interactable = true;
            dd3.interactable = true;
            dd4.interactable = true;
        }
        else if (checkBox.isOn == false)
        {
            dd1.interactable = false;
            dd2.interactable = false;
            dd3.interactable = false;
            dd4.interactable = false;
        }
    }
}
