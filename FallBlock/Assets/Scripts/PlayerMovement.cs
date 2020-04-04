using System;
using System.Collections;
using System.Collections.Generic;
using DitzeGames.MobileJoystick;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    #region Variables

    //Public
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public int health;

    //Private
    [SerializeField] private float movementSpeed = 0.0f;
    private Rigidbody myRB;
    [SerializeField] private Joystick Joystick;


    private int count;
    private int countHeart;

    #endregion

    #region UnityFunctions

    void Start()
    {
        Joystick = FindObjectOfType<Joystick>();
        myRB = GetComponent<Rigidbody>();
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
    }

    void Update()
    {
        Vector3 moveDir = new Vector3(Joystick.AxisNormalized.x + Input.GetAxis("Horizontal"), 0, 0);
        myRB.velocity = moveDir * movementSpeed * Time.fixedDeltaTime;

        if (health > 3) health = 3;

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
        }
    }

    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Heart"))
        {
            health++;
            other.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            collision.gameObject.SetActive(false);
            health--;
//            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}