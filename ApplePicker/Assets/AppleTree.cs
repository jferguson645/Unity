﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
	[Header("Set in Inspector")]

	public GameObject applePrefab;
	public float speed = 10f;
	public float leftAndRightEdge = 24f;
	public float chanceToChangeDirection = 0.04f;
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
		Invoke ("DropApple", 2f);
	}

	void DropApple() {
		GameObject apple = Instantiate<GameObject> (applePrefab);
		apple.transform.position = transform.position;
		Invoke ("DropApple", secondsBetweenAppleDrops);
	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;

		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed);
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed);
		}
	}

	void FixedUpdate () {
		if (Random.value < chanceToChangeDirection) {
			speed *= -1;
		}
	}
}
