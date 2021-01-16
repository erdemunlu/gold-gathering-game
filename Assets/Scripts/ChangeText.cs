using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChangeText : MonoBehaviour  
{
    PlayerA playera;

    [SerializeField] TextMeshProUGUI goldText;

    // Start is called before the first frame update
    void Start()
    {
        playera = FindObjectOfType<PlayerA>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = playera.MevcutAltin.ToString();
    }
}
