using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour
{
    public int velocidadeGiro = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, velocidadeGiro * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtrairMoedas(1);
            Destroy(gameObject);
        }
    }
}