using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextLFS : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI goldText;
    // Start is called before the first frame update
    void Start()
    {
        
        //goldText.text = playera.MevcutAltin.ToString();
        if (UnityEngine.PlayerPrefs.HasKey("FirstSituation"))
        {
            
            int x = PlayerPrefs.GetInt("FirstSituation");
            goldText.text = x.ToString();
        }
        int deneme = UnityEngine.PlayerPrefs.GetInt("LastSituationA");
        UnityEngine.Debug.Log(deneme);
        

        //int x = PlayerPrefs.GetInt("FirstSituation");
        
        //goldText.text = x.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
