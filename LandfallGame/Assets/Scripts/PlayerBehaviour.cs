using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour:MonoBehaviour {
    void Update() {
        //dev dmg player
        if(Input.GetKeyDown(KeyCode.Space)) {
            PlayerTakeDmg(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
        //dev heal player
        if(Input.GetKeyDown(KeyCode.LeftShift)) {
            PlayerHeal(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }

    //dmg player method
    private void PlayerTakeDmg(int dmg) {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
    }
    //heal player method
    private void PlayerHeal(int healing) {
        GameManager.gameManager._playerHealth.HealUnit(healing);
    }
}
