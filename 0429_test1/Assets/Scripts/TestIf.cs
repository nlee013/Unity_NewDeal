using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���� ������Ʈ �� �ٲٱ�
//���� �� ���� ũ�� �ٲٱ�
//ȸ�� ��Ű��

public class TestIf : MonoBehaviour
{
    Renderer cubeColor;
    GameObject cube;

    private void Awake()
    {

        

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
            else{
                cubeColor.material.color = Color.black;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(cube)
            transform.localScale = Vector3.one * 7;
        }

        
    }



    private void OnEnable()//�� ���� ���������� update�� fixedupdate�� ���
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
