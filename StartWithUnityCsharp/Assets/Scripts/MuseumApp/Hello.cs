using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
// 컴퓨터에게 명령어를 내리는 대본.sipt
// 주인공 : A,B,CDEFG
// 언어를  배울때 : 화면에 Hello World!;
/*
 * While(true)
 *  {   
 *      게임로직 
 *      Start이름 적혀져 있는 코드를 실행하세요.
 *      ,,,
 *      ,,,
 *      ,,,
 *      Update이름 적혀져 있는 코드를 실행하세요.
 * 
 *  }
 */

// 3개의 씬, 씬을 이동하는 명령을 컴퓨터에게 내릴거다.
// 어딘가에 구현이 되어있을 가능성이 매우 크다. 문법에 따라서 호출하기만 하면 기능을 구현할 수 있다.
//SceneManager

public class Hello : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //한번만 실행되는 녀석
    void Start()
    {
        Debug.Log("Hello World"!);
        Debug.Log("안녕하세요 유니티를 처음 시작해보는 시간입니다.");
        //SceneManager.LoadScene(0);

    }

    // Update is called once per frame
    //게임이 실행되는 동안에 지속적으로 실행되는 녀석
    void Update()
    {
        Debug.Log("반복적인 실행중...");
    }
}
