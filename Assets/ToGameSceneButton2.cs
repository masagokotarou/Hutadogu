using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToGameSceneButton2 : MonoBehaviour
{
    public void OnClickToGameSceneButton2()
    {
        SceneManager.LoadScene("SampleScene");
    }
}