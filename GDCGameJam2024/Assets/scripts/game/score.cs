using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TMP_Text ptText;
    public int pts = 0;

    public int getPts(){
        return pts;
    }

    void Update()
    {
        ptText.text = "Score: " + pts.ToString();
    }

}
