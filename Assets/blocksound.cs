using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocksound : MonoBehaviour {

	public AudioClip audioClip1;
	private AudioSource audioSource;

	//キューブのprefab
	public GameObject cubePrefab;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip1;
		//		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
//		audioSource = gameObject.GetComponent<AudioSource>();
//		audioSource.clip = audioClip1;

	}
	//キューブの接触判定
	void OnCollisionEnter2D (Collision2D Collision){
		//			if(Collision.gameObject == "cubePrefab"){
		//if(Collision.gameObject == cubePrefab){
		if (Collision.gameObject.tag == "block") {
//			Debug.Log("collision");
//			this.GetComponent<AudioSource>().PlayOneShot(audioSource.clip);
//			this.audioSource.Play ();
			audioSource.Play ();
		}
		//キューブが接触した時に音を鳴らす
		//this.GetComponent<AudioSource>().PlayOneShot(audioSource.clip)= (gameObject) ? 0 : 1;{
//		this.GetComponent<AudioSource>().PlayOneShot(audioSource.clip);
		//audioSource.audioSource.clip=(gameObject);
		//GetComponent<AudioSource>().volume = (gameObject) ? 1 : 0;{
				Debug.Log("GetComponent");
		}
	}
