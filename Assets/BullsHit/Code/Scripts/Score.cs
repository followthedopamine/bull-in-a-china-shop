using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {
  // I like the idea of centralizing the score text on screen and increasing text size as you do more damage

  public TMP_Text scoreText;

  private int score;

  void OnCollisionEnter(Collision hit) {
    if (hit.gameObject.tag == "Destructible") {
      int objectValue = hit.gameObject.GetComponent<ScoreValue>().value;
      score += objectValue;
      scoreText.text = "Score: " + score;
    }
  }
}
