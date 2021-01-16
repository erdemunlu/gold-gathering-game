using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

   

    public GameObject Gold;
    public GameObject hiddenGold;
    public int altinSayisi = 45;
    public int gizliAltinSayisi = 15;

   
    public List<Kare> Kareler = new List<Kare>();
    public class Kare
    {
        public Kare(int x, int y, bool isGold , bool isCharacter, bool isHidden)
        {
            this.X = x;
            this.Y = y;
            this.IsGold = isGold;
            this.IsCharacter = isCharacter;
            this.IsHidden = isHidden;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Boolean IsGold { get; set; }
        public int GoldAmount { get; set; }

        public Boolean IsCharacter { get; set; }
        public Boolean IsHidden { get; set; }




    }


    private void Awake()
    {


    // her kareden bir nesne oluşturulması
    for (int i = 1; i<=15; i++)
	{
            for (int j = 1; j <= 15; j++)
            {
                Kareler.Add(new Kare(i, j, false,false,false));
                
            }
	}

    //Oyuncuların konumuna altın düşmemesi için
    for(int i = 0; i < 225; i++)
        {
            if(Kareler[i].X == 1 && Kareler[i].Y == 1)
            {
                Kareler[i].IsCharacter = true;
            }
            else if (Kareler[i].X==1 && Kareler[i].Y==15)
            {
                Kareler[i].IsCharacter = true;
            }
            else if (Kareler[i].X == 15 && Kareler[i].Y == 1)
            {
                Kareler[i].IsCharacter = true;
            }
            else if (Kareler[i].X == 15 && Kareler[i].Y == 15)
            {
                Kareler[i].IsCharacter = true;
            }
        }
        
    
        // altinlarin yerleştirilmesi ve altınların değerlerinin atanması
        int a = 1;
        while (a <= altinSayisi)
        {
            int i = UnityEngine.Random.Range(0, 225);
            if (Kareler[i].IsGold == false && Kareler[i].IsCharacter == false && Kareler[i].IsHidden==false)
            {
                Kareler[i].IsGold = true;
                a++;
                Kareler[i].GoldAmount = UnityEngine.Random.Range(1, 5)*5;
                
                transform.position = new Vector3(Kareler[i].X, Kareler[i].Y, 0);
                Instantiate(Gold, transform.position, transform.rotation);
                

            }
        }

        //Gizli altınları oluşturmak için->

        
        int b = 1;
        while (b <= gizliAltinSayisi)
        {
            int i = UnityEngine.Random.Range(0, 225);
            if (Kareler[i].IsGold == false && Kareler[i].IsCharacter == false && Kareler[i].IsHidden==false)
            {
                Kareler[i].IsGold = true;
                Kareler[i].IsHidden = true;
                b++;
                Kareler[i].GoldAmount = UnityEngine.Random.Range(1, 5) * 5;
                
                transform.position = new Vector3(Kareler[i].X, Kareler[i].Y, 0);
                


            }
        }

        




    }
    


    // Start is called before the first frame update
    void Start()
    {

        

    }


   

    // Update is called once per frame
    void Update()
    {
        
    }
}

