using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneCode : MonoBehaviour
{
    [SerializeField] Image AyarlarMenusu;
    [SerializeField] bool menuBool = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameSahnesineGec()
    {
        SceneManager.LoadScene("Game"); 
    }

    public void OyunCýkýs()
    {
        Application.Quit();
    }

    public void AyarlarAcKapa()
    {
        if(menuBool == false)
        {
            menuBool = true;
            AyarlarMenusu.gameObject.SetActive(true);
        }
        else if(menuBool == true)
        {
            menuBool = false;
            AyarlarMenusu.gameObject.SetActive(false);
        }

    }

}
