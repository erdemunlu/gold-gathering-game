using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTextB : MonoBehaviour
{
    PlayerB playerb;
    [SerializeField] TextMeshProUGUI goldText;
    // Start is called before the first frame update
    void Start()
    {
        playerb = FindObjectOfType<PlayerB>();
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = playerb.MevcutAltin.ToString();
    }
}
