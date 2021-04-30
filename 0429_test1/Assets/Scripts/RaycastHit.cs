using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHit : MonoBehaviour
{
    private int colourR = 0;
    Renderer sphere;
    [SerializeField]
    LayerMask mask;
    List<GameObject> hits;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //int layerMask = 1 << 7;

        //layerMask = ~layerMask;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = new Ray(Camera.main.transform.position, Input.mousePosition);
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            print(ray);
            print(Input.mousePosition);

            
            float max = 38;
            if (Physics.Raycast(ray, out hit, max, mask))
            {
                print(hit.collider.name);
                if (!hits.Contains(hit.collider.gameObject))
                {
                    hits.Add(hit.collider.gameObject);
                }
            }
            if (hits.Count>0)
            {

            }
            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
            //{
            //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //}
            //else
            //{
            //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 777, Color.white);
            //}  
        }
           
        //RaycastHit.transform.gameObject : GameObject;

    }

    void SwitchColour()
    {
        switch ()
        {

        }
    }
}
