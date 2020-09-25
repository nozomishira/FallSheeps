using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ExplainSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnclickGamaStart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnclicBackStartScene()
    {
        SceneManager.LoadScene("StartScene");

    }
}
