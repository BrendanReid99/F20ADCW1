using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    public int triangle_health = 10;
    public int playerHP;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = triangle_health;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerHP);
    }
}
