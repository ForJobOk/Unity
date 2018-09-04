//学習内容：シーンの切り替え方
//名前空間にSceneManagementを追加＿＿ SceneManager.LoadScene("移行したいシーン名");


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PushStartButton()
    {
        SceneManager.LoadScene("GameScene");

    }
}
