using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        //if (collision.gameObject.name == "Plane") {
        if (collision.gameObject.tag == "Player") {
            print("tocou o chao"); 
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            print("saiu do chao");
        }
    }

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            print("saiu do chao");
        }
    }
}
