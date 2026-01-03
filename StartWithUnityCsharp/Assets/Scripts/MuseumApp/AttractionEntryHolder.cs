using UnityEngine;
using UnityEngine.SceneManagement;

public class AttractionEntryHolder : MonoBehaviour
{
    public void OnClicked()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);//명시적 표현
    }
}
//ctrl + K + D : 코드 정리