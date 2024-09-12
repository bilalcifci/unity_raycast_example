using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject mermi;
    public GameObject ates_noktasi;
    public GameObject mermi_izi;
    //public Transform ates_noktasi_2;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                  
                hit.transform.gameObject.GetComponent<Dusman>().DarbeAl(20);

                if (hit.point != null)
                {
                    //Instantiate(mermi_izi, hit.point, Quaternion.identity);
                    GameObject mermi_izi_instantiate = Instantiate(mermi_izi, hit.point, Quaternion.identity);
                    mermi_izi_instantiate.transform.parent = hit.transform;
                }
                


                //if (hit.rigidbody != null)
                //{
                //    hit.rigidbody.AddForce(Vector3.forward * 1000);
                //}
            }
            //Instantiate(mermi, ates_noktasi.transform.position, ates_noktasi.transform.rotation);
        }
    }
    void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0f, vertical) * 10 * Time.deltaTime);

        //int layer_mask = 1 << 6;
        //layer_mask = ~layer_mask;
        //RaycastHit hit;
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity,layer_mask))
        //{
        //    hit.transform.GetComponent<MeshRenderer>().enabled = false;
        //    //Destroy(hit.transform.gameObject);
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        //    Debug.Log("Hedef Var");
        //}
        //else
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        //    Debug.Log("Hedef Yok");
        //}
    }
    // Update is called once per frame

}
