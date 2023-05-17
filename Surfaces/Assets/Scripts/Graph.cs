using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] Transform pointPrefab;
    [SerializeField,Range(10,100)] int resolution = 10;

    // Start is called before the first frame update
    void Awake()
    {

        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        for (int i = 0; i < resolution; i++)
        {
            Transform point = Instantiate(pointPrefab);
            //point.localPosition = Vector3.right * ((i + 0.5f) / 5f - 1f);
            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform,false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
