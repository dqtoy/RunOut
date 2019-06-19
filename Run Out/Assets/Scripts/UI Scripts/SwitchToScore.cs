using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToScore : MonoBehaviour
{
    void OnMouseDown()
    {


        SceneManager.LoadScene("BestScore");

    }

}
