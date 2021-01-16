using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextC : MonoBehaviour
{
    PlayerC playerc;
    [SerializeField] TextMeshProUGUI goldText;
    // Start is called before the first frame update
    void Start()
    {
        playerc = FindObjectOfType<PlayerC>();
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = playerc.MevcutAltin.ToString();

    }
}
