using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBase : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) {
      if (other.transform.name == "Player") {
         
         Destroy(gameObject);
      }
   }
}
