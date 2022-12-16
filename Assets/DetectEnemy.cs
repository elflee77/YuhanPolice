using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (GameManager._instance.isDetected || GameManager._instance.isSymbol)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0f));

        }
        else if(GameManager._instance.isTouch)
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0f));
            if (gameObject.transform.position.x <= -6f)
            {
                GameManager._instance.isTouch = false;
            }
        }
    }
}
