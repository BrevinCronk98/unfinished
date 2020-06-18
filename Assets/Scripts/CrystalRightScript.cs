﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalRightScript : MonoBehaviour
{
  public PlayerController PlayerScript;
  public SpriteRenderer CrystalSprite;
  public Sprite replacementSprite;

  public bool Activated = false;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.gamestate >= 6)
    {
      CrystalSprite.sprite = replacementSprite;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (Input.GetKeyDown("j") && PlayerController.instance.gamestate == 11)
      {
        var player = other.GetComponentInParent<PlayerController>();
        player.gamestate += 1;
        Activated = true;
        CrystalSprite.sprite = replacementSprite;
      }
    }
  }
}

