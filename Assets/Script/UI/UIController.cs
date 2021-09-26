using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    private UIObject[] uis;

    private void Awake()
    {
        uis = GetComponentsInChildren<UIObject>();
    }

    void Update()
    {
        if (GameManager.GetInstance().CheckUIFocus())
            return;

        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Return");

            foreach(UIObject ui in uis)
            {
                if(ui.GetType() == typeof(ChatController))
                {
                    ui.gameObject.SetActive(true);
                    GameManager.GetInstance().ControllUI(ui);
                    ui.Open();
                }
            }
        }
    }
}
