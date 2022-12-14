using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        //winText.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = player.transform.position;
            Debug.Log("collected");
        }

        if (other.CompareTag("WinArea"))
        {
            Destroy(gameObject);
        }
    }

}
