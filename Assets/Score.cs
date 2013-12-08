using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	//  スコア
	private int score;
	
	//  スコアを初期化する
	void InitScore() {
		this.score = 0;
	}

	//  スコアを加算する
	void AddScore(int score) {
		this.score += score;
	}
	
	void Update () {
		// GUI Textを書き換える
		guiText.text = "Score:" + this.score;	
	}
}