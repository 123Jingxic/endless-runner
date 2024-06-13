using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object left along its x axis 1 unit/second.
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);

        }
    }
}
