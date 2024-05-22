using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20000; i++) 
        {
            GameObject tree = Instantiate(prefab,transform);
            tree.transform.position = new Vector3(Random.Range(-500, 500), -0.5f, Random.Range(-500, 500));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
