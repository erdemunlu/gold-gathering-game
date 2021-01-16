using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextD : MonoBehaviour
{
    PlayerD playerd;
    [SerializeField] TextMeshProUGUI goldText;
    // Start is called before the first frame update
    void Start()
    {
        playerd = FindObjectOfType<PlayerD>();
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = playerd.MevcutAltin.ToString();
    }
}
