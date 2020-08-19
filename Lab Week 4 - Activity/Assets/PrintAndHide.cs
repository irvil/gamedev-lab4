using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.gameObject.name + ": " + i++);
    }
}
