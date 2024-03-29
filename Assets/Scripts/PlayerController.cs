﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "Ground")
		{
			Player.GetComponent<JogadorMovimento>().estaNoChao = true;
		}

	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.collider.tag == "Ground")
		{
			Player.GetComponent<JogadorMovimento>().estaNoChao = false;
		}

	}
}
