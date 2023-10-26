using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiEliminater : MonoBehaviour
{
    public float eliminateTimer = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eliminateTimer -= Time.deltaTime;
        if(eliminateTimer <= 0.0f)
        {
            eliminateTimer = 4.0f;
            this.gameObject.SetActive(false);
        }
    }
}
