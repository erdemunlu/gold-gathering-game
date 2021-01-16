using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FinalSituationD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI goldText;
    // Start is called before the first frame update
    void Start()
    {
        int deneme = UnityEngine.PlayerPrefs.GetInt("LastSituationD");
        goldText.text = deneme.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
