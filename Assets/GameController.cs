using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   public GameOverScreen GameOverScreen;
   int maxplatform=0;
   public void GameOver(){
       GameOverScreen.Setup(maxplatform);
   }
}
