using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    public float velocidade = 800f;
    public float forcaPulo = 10f;

    private bool estaNoChao = true;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            _rb.AddForce(Vector3.left * velocidade * Time.deltaTime, ForceMode.Acceleration);
        }

        if (estaNoChao && Input.GetKeyDown(KeyCode.Space)) {
            _rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Chao") {
            estaNoChao = true;
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Chao") {
            estaNoChao = false;
        }
    }
}
