using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Game02Controller.Instance.SetCoin();
            InstantiateEnemies.instance.InsSphere();
            Destroy(this.gameObject);
        }
    }

}
