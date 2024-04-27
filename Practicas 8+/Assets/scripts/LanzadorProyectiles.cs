using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzadorProyectiles : MonoBehaviour
{
    [SerializeField] 
    GameObject bala;

    [SerializeField] 
    GameObject spawnBala;

    public List<GameObject> balas;

    // Start is called before the first frame update
    void Start()
    {        
        balas = new List<GameObject>();
        for (int i = 0; i < 100; i++)
        {
            GameObject b = Instantiate(bala, 
                spawnBala.transform.position,
                spawnBala.transform.rotation
            );
            b.SetActive(false);
            balas.Add(b);
        }
        contBalaDisparada = 0;
    }

    int contBalaDisparada; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("Disparo");
            //GameObject b = Instantiate(bala, 
            //    spawnBala.transform.position,
            //    spawnBala.transform.rotation
            //);
            //Destroy(b, 4);
            balas[contBalaDisparada].SetActive(true);
            contBalaDisparada++;
        }
    }


}
