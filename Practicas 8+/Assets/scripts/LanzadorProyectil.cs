using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LanzadorProyectil : MonoBehaviour
{
    [SerializeField]
    GameObject bala;

    [SerializeField]
    GameObject spawnBala;
    

    public List<GameObject> balas;
    float tiempoespera = 2f;

    // Start is called before the first frame update
    void Start()
    {
        balas = new List<GameObject>();
        for (int i = 0; i < 10; i++)
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Disparo");
            
            if (contBalaDisparada <= 10)
            {
                balas[contBalaDisparada].gameObject.transform.position = spawnBala.transform.position;
                balas[contBalaDisparada].SetActive(true);
                StartCoroutine(ocultar(contBalaDisparada));
                Debug.Log("Bala disparada: " + contBalaDisparada);
                contBalaDisparada++;
            }
            
            if (contBalaDisparada >= 10)
            {
                contBalaDisparada = 0;
            }
                        
            IEnumerator ocultar(int contt)
            {
                yield return new WaitForSeconds(tiempoespera);
                balas[contt].SetActive(false);          
            }
            
        }
    }

}