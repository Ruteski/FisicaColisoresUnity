using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTiro : MonoBehaviour
{
    public GameObject Projetil;
    public GameObject PontoTiro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            GameObject projetil = Instantiate(Projetil);
            projetil.transform.position = PontoTiro.transform.position;
            projetil.GetComponent<Rigidbody>().AddForce(transform.forward * 50, ForceMode.Impulse);
        }
    }
}
