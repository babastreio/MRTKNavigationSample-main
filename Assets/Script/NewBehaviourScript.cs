using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SecondaryMenu;
    public GameObject pnlTutorial;
    public GameObject favoritesList;
    public TMP_Text pnlTitle;

    private void Awake()
    {
        MainMenu.SetActive(true);
        SecondaryMenu.SetActive(false);
        pnlTutorial.SetActive(false);
        favoritesList.SetActive(false);
    }
    public void ButtonClickedWithGameObject(GameObject selButton)
    {
        Debug.Log(selButton.name);
        MainMenu.SetActive(!MainMenu.activeSelf);
        SecondaryMenu.SetActive(!SecondaryMenu.activeSelf);
        switch (selButton.name)
        {
            case "btnTutorial1":
                LaunchTutorial1();
                break;
            case "btnTutorial2":
                LaunchTutorial2();
                break;
            case "btnTutorial3":
                LaunchTutorial3();
                break;
            case "btnHelp":
                LaunchHelp();
                break;
            case "btnHome":
                ReturnHome();
                break;
            default:
                ReturnHome();
                break;
        }

    }
    #region Launch Tutorials
    private void LaunchTutorial1()
    {
        pnlTutorial.SetActive(true);
        favoritesList.SetActive(false);
        pnlTitle.text = "Tutorial1";
    }
    private void LaunchTutorial2()
    {
        if (MainMenu.activeSelf == true)
        {
            EnableSecondaryMenu();
            favoritesList.SetActive(true);
            pnlTutorial.SetActive(true);
            /* EnableSecondaryMenu();
             pnlTutorial.SetActive(true);
             pnlTitle.text = "Tutorial2";*/
        }
        else
        {
            favoritesList.SetActive(true);
            /*
            pnlTutorial.SetActive(true);
            pnlTitle.text = "Tutorial2";*/
        }

    }
    private void LaunchTutorial3()
    {
        pnlTutorial.SetActive(true);
        pnlTitle.text = "Tutorial3";
    }
    #endregion
    private void LaunchHelp()
    {
        if (MainMenu.activeSelf == true)
        {
            EnableSecondaryMenu();
            pnlTutorial.SetActive(true);
            favoritesList.SetActive(false);
            pnlTitle.text = "Help";
        }
        else
        {
            pnlTutorial.SetActive(true);
            favoritesList.SetActive(false);
            pnlTitle.text = "Help";
        }

    }
    #region Enable menues
    private void ReturnHome()
    {
        EnableMainMenu();
        favoritesList.SetActive(false);
        pnlTutorial.SetActive(false);
    }
    private void EnableMainMenu()
    {
        MainMenu.SetActive(true);
        SecondaryMenu.SetActive(false);
        favoritesList.SetActive(false);
        pnlTutorial.SetActive(false);
    }
    private void EnableSecondaryMenu()
    {
        MainMenu.SetActive(false);
        SecondaryMenu.SetActive(true);
    }
    #endregion
}
