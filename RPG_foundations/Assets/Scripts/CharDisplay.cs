using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharDisplay : MonoBehaviour
{
    public PlayerSO charac;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI healthPoints;
    public TextMeshProUGUI manaPool;
    public Image portrait;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = charac.charName;
        healthPoints.text = (charac.health).ToString();
        manaPool.text = (charac.mana).ToString();
        portrait.sprite = charac.portrait;
    }

}
