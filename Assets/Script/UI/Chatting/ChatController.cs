using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController : UIObject
{
    private InputField input;

    void Start()
    {
        input = GetComponentInChildren<InputField>();

        gameObject.SetActive(false);
    }

    void Update()
    {

    }

    public override void Open()
    {
        GUIUtility.keyboardControl = input.GetInstanceID();
    }
}
