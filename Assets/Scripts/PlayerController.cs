﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Rigidbody2D theRB;
  public float moveSpeed;
  public Animator playerAnim;
  public static PlayerController instance;
  public string areaTransitionName;
<<<<<<< HEAD
  public int gameState;
=======
  public bool paintingFlipped;
  public bool atticTile1;
  public bool atticTile2;
  public bool atticTile3;
>>>>>>> a483a3b51dac97668b6242a8c95f2b0652388ed0
  // Start is called before the first frame update
  void Start()
  {
    DontDestroyOnLoad(gameObject);

    if (instance == null)
    {
      instance = this;
    }
    else
    {
      if (instance != this)
      {
        Destroy(gameObject);
      }
    }
  }

  // Update is called once per frame
  void Update()
  {
    theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

    playerAnim.SetFloat("moveX", theRB.velocity.x);
    playerAnim.SetFloat("moveY", theRB.velocity.y);

    if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
    {
      playerAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
      playerAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
    }
  }
}
