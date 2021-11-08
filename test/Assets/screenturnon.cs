using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenturnon : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tvscreen;
    void Start()
    {
        tvscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        tvscreen.SetActive(true);
    }
}
