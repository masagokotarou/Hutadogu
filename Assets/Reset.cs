using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem2 : MonoBehaviour
{

    //　スタートボタンを押したら実行する
    public void change_buttm ()
    {
        SceneManager.LoadScene("aflet");
    }
}