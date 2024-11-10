using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.VFX;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject streetLampPrefab;
    public float distanceBetweenLamps = 5f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Vector3 position = new(i * distanceBetweenLamps, 0, 0);
            Instantiate(streetLampPrefab, position, Quaternion.identity);
        }
    }
    public GameObject prefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
