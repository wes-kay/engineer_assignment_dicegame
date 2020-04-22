using UnityEngine;

public class Dice : GameValidation
{
    [SerializeField]
    Die die1, die2;
    float throwForce = 9000;
    bool die1Moving, die2Moving, checkMovement = false;
    bool die1Checked, die2Checked;
    byte currentValue1, currentValue2;
    

    void Start()
    {
        CheckComponent(die1);
        CheckComponent(die2);
        GameManager.dice = this;
    }

    void FixedUpdate()
    {
        if (checkMovement)
        {
            GameManager.diceView.gameObject.SetActive(true);

            die1Moving = die1.rigidbody.velocity.magnitude != 0f;
            if (!die1Moving)
            {
                die1.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
                currentValue1 = die1.GetValue();
                if (!die1Checked)
                {
                    GameManager.diceView.SetValue(currentValue1);
                    die1Checked = true;
                }
            }
            die2Moving = die2.rigidbody.velocity.magnitude != 0f;
            if (!die2Moving)
            {
                die2.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
                currentValue2 = die2.GetValue();
                if (!die2Checked)
                {
                    GameManager.diceView.SetValue(currentValue2);
                    die2Checked = true;
                }
               
            }

            if(!die1Moving && !die2Moving)
            {
                GameManager.game.GetCurrentPlayer().AddRoll(new Roll(currentValue1, currentValue2));
                die1Checked = false;
                die2Checked = false;
                checkMovement = false;
                if (GameManager.game.GetCurrentPlayer().isMainPlayer)
                {

                }
            }
        }
    }

    public void RollDice()
    {
        die1.rigidbody.constraints = RigidbodyConstraints.None;
        die2.rigidbody.constraints = RigidbodyConstraints.None;
        die1.transform.position = new Vector3(1, 5, 0);
        die1.transform.localRotation = Random.rotation;
        die2.transform.localRotation = Random.rotation;
        die2.transform.position = new Vector3(-1, 5, 0);
        checkMovement = true;
    }
}
