using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public bool Clear_flag;
    // Start is called before the first frame update
    void Start()
    {
        Clear_flag = false; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Result");
            Clear_flag = true;
        }
    }
}
