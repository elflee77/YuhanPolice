using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameStartBtn : MonoBehaviour, IPointerClickHandler
{
    public int stageNum;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Touch " + stageNum);

    }
}