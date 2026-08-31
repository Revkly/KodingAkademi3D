using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter (Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            Other.GetComponent<Player>().AddScore(1);
        }
    }
}