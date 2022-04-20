using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameController04.Instance.SetCoin();
            Destroy(this.gameObject);
        }
    }

}
