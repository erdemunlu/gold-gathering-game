using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : Player
{
    public GameObject Player3;
    test test1;
    public bool ulastikMi = false;
    Destroyer d;
    public GameObject bk;
    public bool hedefimVarMi = false;
    public int hedefBelirlemeTutar = 15;




    public int hamleC(int sonuc)
    {
        int xek = (int)transform.position.x;
        int yek = (int)transform.position.y;
        int gidilecekx = test1.Kareler[sonuc].X;
        int gidileceky = test1.Kareler[sonuc].Y;
        int adim = 3;
        int xfark = Mathf.Abs(gidilecekx - xek);
        int yfark = Mathf.Abs(gidileceky - yek);
        MevcutAltin -= 5;
        while (adim > 0 && ulastikMi == false)
        {
            while (xfark > 0 && adim > 0)
            {
                if (xek > gidilecekx)
                {
                    xek -= 1;
                    adim--;
                    xfark--;

                }
                else if (xek < gidilecekx)
                {
                    xek++;
                    adim--;
                    xfark--;
                }
            }
            while (yfark > 0 && adim > 0)
            {
                if (yek > gidileceky)
                {
                    yek -= 1;
                    adim--;
                    yfark--;
                }
                else if (yek < gidileceky)
                {
                    yek++;
                    adim--;
                    yfark--;
                }
            }

            if (xfark == 0 && yfark == 0)
            {
                ulastikMi = true;
                hedefimVarMi = false;
                
                MevcutAltin += test1.Kareler[sonuc].GoldAmount;
                test1.Kareler[sonuc].IsGold = false;

                Vector3 v3 = new Vector3(xek, yek, 0f);
                Instantiate(bk, v3, transform.rotation);

                
            }



            


        }
        transform.position = new Vector3(xek, yek, 0);

        


        return xfark + yfark ;




    }
    public int hedefBelirlemeC()
    {
        int xek = (int)transform.position.x;
        int yek = (int)transform.position.y;
        int uzaklik = 100;
        int sonuc = 100;
        int birinci = -1;
        
        
            for (int i = 0; i < 225; i++)
            {
                if (test1.Kareler[i].IsGold == true && test1.Kareler[i].IsHidden == true)
                {
                    if (uzaklik > Mathf.Abs(xek - test1.Kareler[i].X) + Mathf.Abs(yek - test1.Kareler[i].Y))
                    {

                        uzaklik = Mathf.Abs(xek - test1.Kareler[i].X) + Mathf.Abs(yek - test1.Kareler[i].Y);
                        birinci = i;
                    }
                }

            }
            if(birinci != -1)
        {
            test1.Kareler[birinci].IsHidden = false;
            Vector3 v3 = new Vector3(test1.Kareler[birinci].X, test1.Kareler[birinci].Y, 0);
            Instantiate(test1.hiddenGold, v3, transform.rotation);
        }
            
            
        uzaklik = 100;
        int ikinci = -1;
        for (int i = 0; i < 225; i++)
        {
            if (test1.Kareler[i].IsGold == true && test1.Kareler[i].IsHidden == true)
            {
                if (uzaklik > Mathf.Abs(xek - test1.Kareler[i].X) + Mathf.Abs(yek - test1.Kareler[i].Y))
                {

                    uzaklik = Mathf.Abs(xek - test1.Kareler[i].X) + Mathf.Abs(yek - test1.Kareler[i].Y);
                    ikinci = i;
                }
            }

        }

        if(ikinci != -1)
        {
            test1.Kareler[ikinci].IsHidden = false;
            Vector3 v3_2 = new Vector3(test1.Kareler[ikinci].X, test1.Kareler[ikinci].Y, 0);
            Instantiate(test1.hiddenGold, v3_2, transform.rotation);

        }

        uzaklik = 100;

        int hamlesayisi = 0;
        int kar = -100;
        for (int i = 0; i < 225; i++)
        {
            if (test1.Kareler[i].IsGold == true && test1.Kareler[i].IsHidden == false)
            {

                uzaklik = Mathf.Abs(xek - test1.Kareler[i].X) + Mathf.Abs(yek - test1.Kareler[i].Y);
                if (uzaklik > 3)
                {
                    if (uzaklik % 3 > 0)
                    {
                        hamlesayisi = (uzaklik / 3) + 1;
                    }
                    else
                    {
                        hamlesayisi = uzaklik / 3;
                    }
                }
                else
                {
                    hamlesayisi = 1;
                }

                if (kar <= test1.Kareler[i].GoldAmount - ((hamleTutari * hamlesayisi) + hedefBelirlemeTutar))
                {
                    kar = test1.Kareler[i].GoldAmount - ((hamleTutari * hamlesayisi) + hedefBelirlemeTutar);
                    sonuc = i;
                }


            }

        }
        MevcutAltin -= hedefBelirlemeTutar;
        ulastikMi = false;
        hedefimVarMi = true;
        return sonuc;


    }
    public void Awake()
    {
        Player3.transform.position = new Vector3(15, 1, 0);


    }
    private void Start()
    {
        test1 = FindObjectOfType<test>();
        d = FindObjectOfType<Destroyer>();

    }
}
