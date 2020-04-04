using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformClock : MonoBehaviour
{
    [SerializeField] private float timeDeleteHeart = 0.0f;
    private float timer = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 120, 0) * Time.deltaTime);
       
        timer += 1.0f * Time.deltaTime;

        if (timer >= timeDeleteHeart)
            gameObject.SetActive(false);
    }
}
