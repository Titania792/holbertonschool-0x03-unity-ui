using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject trap = GameObject.Find("Trap");
    public GameObject goal = GameObject.Find("Goal");
    public Material trapMat;
    public Material goalMat;
    public Material trapMatCB;
    public Material goalMatCB;
    public Toggle colorblindMode;

    void Start()
    {
        colorblindMode.isOn = false;
    }
    public void ResetMaterials()
    {
        trap.GetComponent<Renderer>().material = trapMat;
        goal.GetComponent<Renderer>().material = goalMat;
    }
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
        if (colorblindMode.isOn)
        {
            trap.GetComponent<Renderer>().material = trapMatCB;
            goal.GetComponent<Renderer>().material = goalMatCB;
        }
        else
        {
            ResetMaterials();
        }
    }

    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
