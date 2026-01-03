using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    // 생성하고 싶은 프리팹을 등록한다
    public AttractionEntryHolder attractionEntryHolder;
    // 공장에서 찍어내는 것 처럼 생성한다. 어느 위치에 만들어줄 것인지
    public Transform parent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Object.Instantiate(attractionEntryHolder, parent);
        Object.Instantiate(attractionEntryHolder, parent);
        Object.Instantiate(attractionEntryHolder, parent);
        Object.Instantiate(attractionEntryHolder, parent);
        Object.Instantiate(attractionEntryHolder, parent);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
