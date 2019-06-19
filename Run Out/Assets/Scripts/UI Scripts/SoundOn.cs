using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOn : MonoBehaviour
{
    void OnMouseDown()
    {
        AudioListener.volume = 1f;

    }
}
