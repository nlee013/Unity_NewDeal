using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//큐브와 큐브를 이용하여 프리팹 하나를 설정해두고 Inputfield를 이용하여 텍스트 입력을 받고
//버튼을 누르면 프리펩 생성-> 프리펩 이름은 inputfield에 있는 이름으로  바꿈
//기본 이름 "Adam"을 입력할 것

// : 서로 다른 오브젝트 5군데에 이동, 회전, 크기 변화, 보이는 상태, 보이지 않는 상태,
// 색깔변화, 소리재생 등의 함수를 넣고 마우스를 누르면 5가지의 행동을 동시에 할 수 있도록
// (버튼 활용방법 외에)

public class CreationTest : MonoBehaviour
{
    public GameObject adam;
    public Text nameContainer;
    public Transform creationPosiiton;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void creationAdam()
    {
        string adamname = nameContainer.text;
        adamname = adamname.Length > 0 ? adamname : "Adam";

        var a = Instantiate(adam, creationPosiiton);
        a.name = adamname;
    }
}
