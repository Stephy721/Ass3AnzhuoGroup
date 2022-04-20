using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemies : MonoBehaviour
{

    public static InstantiateEnemies instance;

    public GameObject Enemy01;
    public GameObject Enemy02;

    
    private GameObject InsEnemy01;
    private GameObject InsEnemy02;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        InsEnemy01 = Instantiate(Enemy01, new Vector3(Random.Range(-6,6), 0.5f, Random.Range(-6, 6)), Quaternion.identity);
        InsEnemy02 = Instantiate(Enemy02, new Vector3(Random.Range(-6, 6), 0.5f, Random.Range(-6, 6)), Quaternion.identity);
        InsEnemy01.SetActive(true);
        InsEnemy02.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InsSphere()
    {
        InsEnemy01 = Instantiate(Enemy01, new Vector3(Random.Range(-9, 9), 0.5f, Random.Range(-9, 9)), Quaternion.identity);
        InsEnemy01.SetActive(true);
    }




}
