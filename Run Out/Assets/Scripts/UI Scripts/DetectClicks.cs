using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectClicks : MonoBehaviour
{
    
    void OnMouseDown()
    {
        transform.localScale = new Vector3 (0.9f, 0.9f, 0.9f);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }
}
