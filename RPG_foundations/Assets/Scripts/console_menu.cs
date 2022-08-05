using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class console_menu : MonoBehaviour
{
    public PlayerSO charac1;
    public PlayerSO charac2;
    public PlayerSO charac3;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press 1 to print out your party, and their HP");
    }

    // Update is called once per frame
    void Update()
    {
        OpenMenu();
    }

    void OpenMenu()
    {
        if (Keyboard.current[Key.Digit1].isPressed)
        {
            Debug.Log("Name: " + charac1.charName);
            Debug.Log("HP: " + (charac1.health).ToString());
            Debug.Log("Name: " + charac2.charName);
            Debug.Log("HP: " + (charac2.health).ToString());
            Debug.Log("Name: " + charac3.charName);
            Debug.Log("HP: " + (charac3.health).ToString());
        }
    }
}
