using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour
{
    public void TianXian(){
        SceneManager.LoadScene("TianXian");
    }
    public void FuDe(){
        SceneManager.LoadScene("FuDe");
    }
    public void EastFort(){
        SceneManager.LoadScene("EastFort");
    }
    public void Menu(){
        SceneManager.LoadScene("Menu");
    }
    public void HomePage(){
        SceneManager.LoadScene("HomePage");
    }
}
