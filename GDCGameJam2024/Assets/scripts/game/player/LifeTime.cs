using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    // Start is called before the first frame update
    public float LT = 1f;
    
    private void Start(){
        Destroy(gameObject, 0.1f);
    }

}
