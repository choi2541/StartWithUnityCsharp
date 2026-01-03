using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class AttractionScreen : MonoBehaviour
    {
        //클릭 했을 때, 함수 - 같은 코드를 사용하기위해서 코드들의 이름을 붙였다.
        public void OnClicked()
        {
            SceneManager.LoadScene(0);
        }

    }
}