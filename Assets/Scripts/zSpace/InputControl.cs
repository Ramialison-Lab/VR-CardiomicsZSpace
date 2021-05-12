using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    public GameObject copy;

    public void combinedView()
    {
        Debug.Log("dsad");
        if (GameObject.Find("HeartCopy(Clone)") == null)
            Instantiate(copy);
            GameObject.Find("HeartCopy(Clone)").transform.position = new Vector3(0.5f, 0, 1.13f);
    }

    public void adjustModels()
    {
        GameObject.Find("Heart").transform.position = new Vector3(-1,0,1.13f);
    }

    public void readjustModel()
    {
        GameObject.Find("Heart").transform.position = new Vector3(0, 0, 1.13f);
    }

    public void callReset()
    {
        Destroy(GameObject.Find("HeartCopy(Clone)"));
    }

    public void callResetHeatMap()
    {

        Destroy(GameObject.Find("HeartCopy(Clone)"));


    }
}
