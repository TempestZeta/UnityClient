using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager GetInstance()
    {
        if (null != instance)
            return instance;

        return null;
    }

    private List<UIObject> listUI = new List<UIObject>();

    void Start()
    {
        if (null == instance)
            instance = this;

        DontDestroyOnLoad(this);
    }

    public bool CheckUIFocus()
    {
        return listUI.Count > 0;
    }

    public void ControllUI(UIObject ui)
    {
        listUI.Add(ui);
    }

    public void CloseUI(UIObject ui)
    {
        if(null != ui)
        {
            listUI.Remove(ui);

            if(listUI.Count > 0)
            {
                UIObject lastUI = listUI[listUI.Count - 1];
                lastUI.GetFocus();
            }
        }
    }
}
