using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Camera fpsCam;

    public float range =180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            ShootRay();
        }

        void ShootRay(){
            RaycastHit hit;

            if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
                Debug.Log(hit.transform.name);
            }
            else{
                Debug.Log("Missed");
            }
        }
    }
}
