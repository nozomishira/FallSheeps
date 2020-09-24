using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultSceneMoveButtun : MonoBehaviour
{
    // Start is called before the first frame update

    public Button ResultSceneMoveButton;
    //public GameObject gameobjResultSceneMoveButton;
    public static int ResultSceneMoveButtonflag = 0;

    void Start()
    {
        // ResultSceneMoveButton.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
       // ResultSceneMoveButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ResultSceneMoveButtonflag >=1)
        {
            //ResultSceneMoveButton.gameObject.SetActive(true);
            this.gameObject.SetActive(true);
            //ResultSceneMoveButton.interactable = true;
        }
    }

    public void OnClick()
    {
        SceneManager.LoadScene("EndScene");
    }
}
