using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    #region Variables
    [SerializeField] private Transform target;
    [SerializeField] private float yHeight = 0.0f;
    [SerializeField] private float zDistance = 0.0f;
    #endregion
    void Start()
    {
        
    }

    void Update()
    {
        Follow();
    }

    private void Follow()
    { 
        transform.position = new Vector3(
            target.position.x, target.position.y + yHeight,target.position.z - zDistance);
    }
}
