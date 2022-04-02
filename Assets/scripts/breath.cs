using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float height = Camera.main.orthographicSize * 2;
        float width = (float)(Camera.main.orthographicSize * 2.0 * Screen.width / Screen.height);
        
        //transform.localScale = new Vector3(width/ 9.0f, width / 9.0f, width / 9.0f);
        transform.localScale = new Vector3(width, 1, 1);
        var cameraView = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height, 0));
        //transform.Translate();
        transform.position = new Vector3(cameraView.x, cameraView.y, 0);
        //Debug.Log("Hola unity screen width: " + Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.localScale);
    }
}
