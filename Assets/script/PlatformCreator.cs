using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    public GameObject platformPrefab;
    GameObject currentPlatform;
    // Start is called before the first frame update
    void Start()
    {
        currentPlatform = Instantiate(platformPrefab, new Vector3(16, Random.Range(-2,1), 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlatform.transform.position.x < 0)
        {
            currentPlatform = Instantiate(platformPrefab, new Vector3(16, Random.Range(-2,1), 0), Quaternion.identity);

        }
        
    }
}
