using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //マウスがクリックされたら
        {
            //マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //マウスを離した時
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //スワイプの長さを初速度に変換する
            this.speed = swipeLength / 500.0f;

            //効果音再生
            GetComponent<AudioSource> ().Play();
        }
        transform.Translate(this.speed, 0, 0); //移動
        this.speed *= 0.98f; //減速
    }
}
