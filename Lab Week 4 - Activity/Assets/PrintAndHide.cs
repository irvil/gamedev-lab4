using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    public Renderer rend;
    private int randNum;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        rend.enabled = true;
        randNum = Random.Range(199, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.gameObject.name + ": " + i++);

        if (this.gameObject.tag == "Red" && i == 100){
            this.gameObject.SetActive(false);
        }

        if (this.gameObject.tag == "Blue" && i == randNum){
            rend.enabled = false;
        }
    }
}
