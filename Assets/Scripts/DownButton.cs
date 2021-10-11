using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DownButton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    public float input;
    public float sensitility = 3;
    bool pressing;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pressing){
            input += Time.deltaTime * sensitility;
        }
        else{
            input -= Time.deltaTime * sensitility;
        }
        input = Mathf.Clamp(input,0,1);
    }
}
