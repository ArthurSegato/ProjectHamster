using UnityEngine;

public class JogadorMovimento : MonoBehaviour
{
	public float velocidade = 4f;
	public float alturaPulo = 10f;
	public bool estaNoChao = false;

	private void Start()
	{
		
	}

	private void Update()
	{
		Jump();
		Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
		transform.position += movement * Time.deltaTime * velocidade;
	}
	void Jump()
	{
		if (Input.GetButtonDown("Jump"))
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, alturaPulo), ForceMode2D.Impulse);
		}
	}
}
