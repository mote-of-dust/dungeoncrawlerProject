using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerSO : ScriptableObject
{
    public string charName;
    public float health;
    public int mana;
    public Sprite portrait;

    public int str;
    public int dex;
    public int mag;

}
