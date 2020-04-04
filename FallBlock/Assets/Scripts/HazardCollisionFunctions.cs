using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HazardCollisionFunctions : MonoBehaviour
{
    #region Variables

    
    //Private 
    [SerializeField] private ParticleSystem hazardDustParticles;
    
    #endregion

    #region UnityFunctions

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Destroy(Instantiate(
                hazardDustParticles.gameObject,transform.position,Quaternion.identity),hazardDustParticles.startLifetime);
            this.gameObject.SetActive(false);
        }
//
//        if (collision.gameObject.tag == "Player")
//        {
//            collision.gameObject.SetActive(false);
//        }
    }
}
