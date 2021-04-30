using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//게임 오브젝트 색 바꾸기
//누를 때 마다 크기 바꾸기
//회전 시키기

public class TestIf : MonoBehaviour
{
    Renderer cubeColor;
    GameObject cube;

    public GameObject ob;
    public Transform creationOrigin;

    private void Awake()
    {
        print("Awake에서 호출");
        Debug.Log("Awake 호출");

        float angle = 0;
        angle += Time.deltaTime;

        transform.localScale = Vector3.one * 7;
        transform.Rotate(ob.transform.position, angle);
        transform.rotation = Quaternion.Euler(77, 35, 1);
        GetComponent<Renderer>().material.color = Color.blue;
        print("Awake에서 호출");

    }

    // Start is called before the first frame update
    void Start()
    {
        cubeColor = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (cubeColor.material.color != Color.blue)
            {
                cubeColor.material.color = Color.blue;

            }
            else
            {
                cubeColor.material.color = Color.black;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cube)
                transform.localScale = Vector3.one * 7;
        }


    }



    private void OnEnable()//한 번만 가능함으로 update나 fixedupdate를 사용
    {

    }



    private void OnDestroy()
    {

    }

    private void FixedUpdate()
    {
        //print("");
        //Debug.Log("");
        //float angle = 0;
        //angle += Time.deltaTime;

        ////if (Input.GetButtonDown(0))
        ////{
        //    transform.localScale = Vector3.one * 7;
        //    transform.Rotate(transform.position, angle);
        //    transform.rotation = Quaternion.Euler(70, 35, 7);
        //// }

    }
    
}
