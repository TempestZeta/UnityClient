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
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Close();
        }

        if (Input.GetKeyUp(KeyCode.Return))
        {
            Action();
        }
    }

    public override void Open()
    {
        input.ActivateInputField();
    }

    public override void Close()
    {
        input.text = "";
        gameObject.SetActive(false);

        GameManager.GetInstance().CloseUI(this);
    }

    public override void Action()
    {

    }
}
