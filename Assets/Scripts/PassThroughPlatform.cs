using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughPlatform : MonoBehaviour
{
	[SerializeField]
	private BoxCollider2D boxCol = null;
	[SerializeField]
	private float colliderOffset = 8f;
	[SerializeField]
	private PlayerController playerController = null;

	private void Start()
	{
		boxCol.enabled = false;
	}

	private void Update()
	{
		if (playerController.playerPosition.y > (transform.position.y + colliderOffset))
		{
			boxCol.enabled = true;
			Destroy(this);
		}
	}
}
