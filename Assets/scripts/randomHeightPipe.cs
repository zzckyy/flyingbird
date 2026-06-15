using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomHeightPipe : MonoBehaviour
{
    public float minHeight = 0.5f;
    public float maxHeight = 2f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(transform.localScale.x, Random.Range(minHeight, maxHeight), transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
