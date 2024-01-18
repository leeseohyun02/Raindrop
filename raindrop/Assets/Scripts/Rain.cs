using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rain : MonoBehaviour
{
    int type;
    float size;
    int score;
    

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.3f, 2.3f);
        float y = Random.Range(3.5f, 4.5f);
        transform.position = new Vector3(x, y, 0); // ºø¹æ¿ï À§Ä¡

        type = Random.Range(1, 4);

        if (type == 1)
        {
            size = 1.0f;
            score = 3;
            GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 2)
        {
            size = 0.7f;
            score = 2;
            GetComponent<SpriteRenderer>().color = new Color(130 / 255f, 130 / 255f, 255 / 255f, 255 / 255f);
        }
        else if(type == 3)
        {
            size = 0.5f;
            score = 1;
            GetComponent<SpriteRenderer>().color = new Color(150 / 255f, 150 / 255f, 255 / 255f, 255 / 255f);
        }
       
        transform.localScale = new Vector3(size, size, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "ground")
        {
            gameManager.I.addScore(score);
            Destroy(gameObject);
        }
        if(coll.gameObject.tag == "slime")
        {
            Destroy(gameObject);
            gameManager.I.HP();

        }
    }
}
