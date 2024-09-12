using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    private int saglik;
    // Start is called before the first frame update
    void Start()
    {
        saglik = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DarbeAl(int darbe_gucu)
    {
        if (saglik > 0)
        {
            saglik -= darbe_gucu;
            if (saglik <= 0)
            {
                Destroy(gameObject);
            }
        }
        //if (saglik <= 0)
        //{
        //    Destroy(gameObject);
        //}
        //else
        //{
        //    saglik -= darbe_gucu;
        //}
    }
}
