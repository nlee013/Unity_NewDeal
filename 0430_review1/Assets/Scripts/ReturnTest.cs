using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//키를 눌렀을 때 활성/ 비활성이 반복되도록..
//키를 누른 상태에서만 오브젝트가 활성화되도록 return 키워드 활용.

public class ReturnTest : MonoBehaviour
{
    public GameObject target, ActivationObject, ActiveRelationObject;
    public Canvas canvas;

    [SerializeField] Text[] texts; //하이얼랔키에서 끌어올 때 사용 가능

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(true);//게임 오브젝트 활성화.여기에 false를 불러오면 script가 같이 꺼져서 비활성

        var temp = FindObjectsOfType<GameObject>();

        foreach(var te in temp)
        {
            print(te.name);

           if(te.GetComponent<Rigidbody>())
            {
                te.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        //Canvas에 Random한 숫자로 Text창을 띄워서 Text()에 값을 입력해서 화면에 보이게 만들기

       
       
        //texts[0].gameObject.SetActive(true);
        //texts[0].ReturnTest.texts;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameObject.SetActive(true);

            ////ActivationObject.SetActive(!ActivationObject.activeSelf);

            var b = Random.Range(0, texts.Length);

            foreach(var text in texts)
            {
                text.enabled = false;
            }

            for (int i = 0; i < b; i++)
            {
                texts[i].text = Random.Range(0, 77).ToString();
                texts[i].enabled = true;
            }
        }
        else
        {
            //gameObject.SetActive(false); 
            //-> 게임오브젝트를 사용하면 여기서 스크립트 기능도 멈춤.
        }

        if (Input.GetMouseButton(0))
        {
            //gameObject.activeSelf = !gameObject.activeSelf
            //->다른곳에서 게임오브젝트를 가져와서 사용안하면 스크립트가 꺼짐.

            target.SetActive(false);
            //ActivationObject.SetActive(true);

            return;
        }
        //ActiveRelationObject.SetActive(false);
        target.SetActive(true);

        //var a = GetComponent<Collider>();
        //a.enabled = true;

        //씬 위의 오브젝트를 찾아 모두 이름을 출력하기 이름을 출력하면 하나씩 자유낙하를..
        //색 변화하는 기능도 추가
    }
}
