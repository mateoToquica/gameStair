using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	public Animator anim;
	public SpriteRenderer animacion;
	public Rigidbody2D rigit;


	private StopDice stopdado;
	private Vector2 vector2;




	// Use this for initialization
	void Start () {
		rigit = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate()
	{

		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
		{
	

			startDice();
			int valor = obtenerValor();
			moverNave(valor);
		}

	}
	public void moverNave(int valor)
	{
		int valorMovimiento = valor + valor + valor+ valor+ valor+ valor;
		vector2 = new Vector2 (valorMovimiento, 0);
		
		rigit.MovePosition (rigit.position + vector2);

	}
	public int obtenerValor()
	{
		if (anim.speed == 0) {
			
			if (animacion.sprite.name.Equals ("dado sf_0")) {
				return 1;
			}
			if (animacion.sprite.name.Equals ("dado sf_1")) {
				return 2;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_2")) {
				return 3;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_3")) {
				return 4;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_4")) {
				return 5;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_5")) {
				return 6;
				
			}
			return 0;
		} else {
			return 0;
		}
	}
	public void startDice(){
		
		
		
		if (anim.speed == 1) {
			
			anim.speed = 0;
			
		} else {
			
			anim.speed = 1;
		}
	}
}

