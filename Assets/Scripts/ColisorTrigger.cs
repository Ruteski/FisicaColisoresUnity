using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            print("tocou");
        }
    }
}
