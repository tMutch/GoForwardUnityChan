﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {
	//キューブのprefab
	public GameObject cubePrefab;

	//時間計算用の変数
	private float delte = 0;

	//キューブの生成間隔
	private float span = 1.0f;

	//キューブの生成位置　x座標
	private float genPosX = 12;

	//キューブの生成位置オフセット
	private float offsetY = 0.3f;
	//キューブの縦方向感覚
	private float spaceY = 6.9f;

	//キューブの生成位置オフセット
	private float offsetX = 0.5f;
	//キューブの横方向の間隔
	private float spaceX = 0.4f;

	//キューブの生成個数の上限
	private int maxBlocNum = 4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.delte += Time.deltaTime;

		//span秒以上の時間が経過したが調べる
		if (this.delte > this.span) {
			this.delte = 0;
			//生成するキューブ数をランダムに決める
			int n = Random.Range (1, maxBlocNum + 1);

			//指定した数だけキューブを生成する
			for (int i = 0; i < n; i++) {
				//キューブの生成
				GameObject go = Instantiate (cubePrefab) as GameObject;
				go.transform.position = new Vector2 (this.genPosX, this.offsetY + i * this.spaceY);
			}
			//次のキューブまでの生成時間を決める
			this.span = this.offsetX + this.spaceX * n;
		}
	}
}
