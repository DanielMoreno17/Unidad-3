using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_MoveTowardsV2 : MonoBehaviour
{
    GameObject personaje;
    P3_Distance revDistance;
    public bool estaDentro = false;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
      //  revDistance = GetComponent<P3_Distance>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (estaDentro){
            transform.position = Vector3.MoveTowards(
                transform.position,
                personaje.transform.position,
                Time.deltaTime * 2f);
        }
    }
}
