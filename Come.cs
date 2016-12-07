using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Come : MonoBehaviour {
	[SerializeField]
	Animator anim;
	bool direita, cima, baixo, esquerda, azul;
	[SerializeField]
	Text score;
	[SerializeField]
	int pontos;
	[SerializeField]
	GameObject[] fanta;
	// Use this for initialization
	void Start () {
		direita = true;
		cima = false;
		baixo = false;
		esquerda = false;


	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < fanta.Length; i++) {
			azul = fanta [i].gameObject.GetComponent<fantasma> ().getAzul();
		}
		if(Input.GetKeyDown (KeyCode.UpArrow)){
			cima=true;
			baixo=false;
			esquerda=false;
			direita=false;
		}
	
			score.text = "Score " + pontos;

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position+=new Vector3(0,10*Time.deltaTime,0);
		}
		if(Input.GetKeyDown (KeyCode.DownArrow)){
			cima=false;
			baixo=true;
			esquerda=false;
			direita=false;
			
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position+=new Vector3(0,-10*Time.deltaTime,0);
		}
		if(Input.GetKeyDown (KeyCode.LeftArrow)){
			cima=false;
			baixo=false;
			esquerda=true;
			direita=false;
			
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position+=new Vector3(-10*Time.deltaTime,0,0);
		}
		if(Input.GetKeyDown (KeyCode.RightArrow)){
			cima=false;
			baixo=false;
			esquerda=false;
			direita=true;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position+=new Vector3(10*Time.deltaTime,0,0);
		}
		anim.SetBool ("Direita", direita);
		anim.SetBool ("Esquerda", esquerda);
		anim.SetBool ("Baixo", baixo);
		anim.SetBool ("Cima", cima);
		
	}
	void OnTriggerEnter2D(Collider2D outro){
		//if (azul == true && outro.gameObject.tag == "fantasma") {
		//	pontos += 50;
		//	Destroy(outro.gameObject);
		//}

		if(outro.name.Equals ("pacdot")){
			Destroy(outro.gameObject);
			pontos += 10;

		}



}
}