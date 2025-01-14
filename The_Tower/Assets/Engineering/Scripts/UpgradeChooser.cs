using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeChooser : MonoBehaviour
{
    GameObject upgrade1Button, upgrade2Button, upgrade3Button, player, upgradeBox;
    Upgrade upgrade;
    public Text upgrade1Text, upgrade2Text, upgrade3Text;

    // Start is called before the first frame update
    void Start()
    {
        upgrade1Button = transform.GetChild(0).gameObject;
        upgrade2Button = transform.GetChild(1).gameObject;
        upgrade3Button = transform.GetChild(2).gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Open()
    {
        upgrade = new Upgrade();
        upgrade1Text.text = "Upgrade 1: Acceleration increases by " + upgrade.Upgrade1;
        upgrade2Text.text = "Upgrade 2: Speed increases by " + upgrade.Upgrade2;
        upgrade3Text.text = "Upgrade 3: Jump increases by " + upgrade.Upgrade3;
    }
    public void Close()
    {
        gameObject.SetActive(false);
        Destroy(upgradeBox);
    }

    public void SetUpgradeBox(GameObject box) {
        upgradeBox = box;
    }

    public void choseUpgrade1()
    {
        player.GetComponent<Player>().spd += upgrade.Upgrade1;
        Close();
    }

    public void choseUpgrade2()
    {
        player.GetComponent<Player>().maxspd += upgrade.Upgrade2;
        Close();
    }

    public void choseUpgrade3()
    {
        player.GetComponent<Player>().jumpPower += upgrade.Upgrade3;
        Close();
    }
}
