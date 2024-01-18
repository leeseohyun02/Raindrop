using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : MonoBehaviour
{
    float direction = 0.005f; // position X의 값
    float toward = 1.0f; // 방향 전환
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            toward *= -1; // 한번 클릭하면 1, -1로 바뀜
            direction *= -1;
        }

        if (transform.position.x > 2.5f)
        {
            direction = -0.005f;
            toward = -1.0f;
        }
        
        if(transform.position.x < -2.5f)
        {
            direction = 0.005f;
            toward = 1.0f;
           
        }
        transform.localScale = new Vector3(toward, 1, 1); // 방향 전환
        transform.position += new Vector3(direction, 0, 0); // 오른쪽 이동

    }

   
}
