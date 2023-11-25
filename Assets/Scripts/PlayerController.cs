using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public float jumpForce = 8f;

	public string currentColor;

	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public Color[] colors = new Color[4];
	public string[] colorNames = { "Cyan", "Yellow", "Pink", "Purple" };

	void Start()
	{
		SetRandomColor();
	}

	void Update()
	{
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.up * jumpForce;
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "ColorChange")
		{
			SetRandomColor();
			Destroy(collider.gameObject);
			return;
		}

		if (collider.tag != currentColor)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		if (collider.tag == "Finish")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		if (collider.tag == "Offscreen")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void SetRandomColor()
	{
		int index = Random.Range(0, colors.Length);
		currentColor = colorNames[index];
		sr.color = colors[index];
	}
}
