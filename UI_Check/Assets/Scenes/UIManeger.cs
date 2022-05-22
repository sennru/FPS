using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    public GameObject Startview;
    public GameObject Option;
    public GameObject Selectmenu;
    public GameObject Result;
    public GameObject Game;
    public GameObject Option_Playgame;
    // Start is called before the first frame update
    void Start()
    {
        MoveToMenu();
        Debug.Log("confirm");
    }

    // Update is called once per frame
    public void CurrentPanel()
    {

    }
    public void OptionMenu()
    {
        Startview.SetActive(false);
        Option.SetActive(true);
    }
    public void MoveToMenu()
    {

    }


}
