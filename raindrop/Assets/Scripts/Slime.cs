using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : MonoBehaviour
{
    float direction = 0.005f; // position X�� ��
    float toward = 1.0f; // ���� ��ȯ
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            toward *= -1; // �ѹ� Ŭ���ϸ� 1, -1�� �ٲ�
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
        transform.localScale = new Vector3(toward, 1, 1); // ���� ��ȯ
        transform.position += new Vector3(direction, 0, 0); // ������ �̵�

    }

   
}
