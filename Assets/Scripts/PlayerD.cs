using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerD : Player
{
    public GameObject Player4;
    test test1;
    public bool ulastikMi = false;
    Destroyer d;
    public GameObject bk;
    public bool hedefimVarMi = false;
    public int hedefBelirlemeTutar = 20;
    PlayerScript ps;
    int indis;

    public void hamleD(int sonuc)
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
                    indis = indisBul(xek, yek);
                    if (test1.Kareler[indis].IsHidden == true && indis != 1000)
                    {
                        test1.Kareler[indis].IsHidden = false;
                        Vector3 v3 = new Vector3(test1.Kareler[indis].X, test1.Kareler[indis].Y, 0);
                        Instantiate(test1.hiddenGold, v3, transform.rotation);
                    }

                }
                else if (xek < gidilecekx)
                {
                    xek++;
                    adim--;
                    xfark--;
                    indis = indisBul(xek, yek);
                    if (test1.Kareler[indis].IsHidden == true && indis != 1000)
                    {
                        test1.Kareler[indis].IsHidden = false;
                        Vector3 v3 = new Vector3(test1.Kareler[indis].X, test1.Kareler[indis].Y, 0);
                        Instantiate(test1.hiddenGold, v3, transform.rotation);
                    }
                }
            }
            while (yfark > 0 && adim > 0)
            {
                if (yek > gidileceky)
                {
                    yek -= 1;
                    adim--;
                    yfark--;
                    indis = indisBul(xek, yek);
                    if (test1.Kareler[indis].IsHidden == true && indis != 1000)
                    {
                        test1.Kareler[indis].IsHidden = false;
                        Vector3 v3 = new Vector3(test1.Kareler[indis].X, test1.Kareler[indis].Y, 0);
                        Instantiate(test1.hiddenGold, v3, transform.rotation);
                    }
                }
                else if (yek < gidileceky)
                {
                    yek++;
                    adim--;
                    yfark--;
                    indis = indisBul(xek, yek);
                    if (test1.Kareler[indis].IsHidden == true && indis != 1000)
                    {
                        test1.Kareler[indis].IsHidden = false;
                        Vector3 v3 = new Vector3(test1.Kareler[indis].X, test1.Kareler[indis].Y, 0);
                        Instantiate(test1.hiddenGold, v3, transform.rotation);
                    }
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

        
        






    }
    public int indisBul(int x, int y)
    {
        int i;
        for (i = 0; i < 225; i++)
        {
            if (test1.Kareler[i].X == x && test1.Kareler[i].Y == y)
            {
                return i;

            }

        }
        return 1000;
    }
    public int hamleSayisiBul(int distance)
    {
        int hamleSayisi = 0;
        if (distance > 3)
        {
            if (distance % 3 > 0)
            {
                hamleSayisi = (distance / 3) + 1;
            }
            else
            {
                hamleSayisi = distance / 3;
            }
        }
        else
        {
            hamleSayisi = 1;
        }
        return hamleSayisi;

    }

    public int hedefBelirlemeD(int hedefA, int hedefB, int hedefC, int uzaklikA, int uzaklikB, int uzaklikC)
    {
        int xek = (int)transform.position.x;
        int yek = (int)transform.position.y;
        int uzaklik = 100;
        int sonuc = 100;
        int hamlesayisi = 0;
        int kar = -100;
        int DninUzakligiA = Mathf.Abs(xek - test1.Kareler[hedefA].X) + Mathf.Abs(yek - test1.Kareler[hedefA].Y);
        
        
        int hamleSayisiD = hamleSayisiBul(DninUzakligiA);
        int HamleSayisiA = hamleSayisiBul(uzaklikA);
        int flagA = 0;
        if (hamleSayisiD > HamleSayisiA)
        {
            
            flagA = 1;

        }
        int DninUzakligiB = Mathf.Abs(xek - test1.Kareler[hedefB].X) + Mathf.Abs(yek - test1.Kareler[hedefB].Y);
        hamleSayisiD = hamleSayisiBul(DninUzakligiB);
        int HamleSayisiB = hamleSayisiBul(uzaklikB);
        int flagB = 0;
        if (hamleSayisiD > HamleSayisiB)
        {
            
            flagB = 1;

        }

        int DninUzakligiC = Mathf.Abs(xek - test1.Kareler[hedefC].X) + Mathf.Abs(yek - test1.Kareler[hedefC].Y);
        hamleSayisiD = hamleSayisiBul(DninUzakligiC);
        int HamleSayisiC = hamleSayisiBul(uzaklikC);
        int flagC = 0;
        if (hamleSayisiD > HamleSayisiC)
        {
            
            flagC = 1;

        }





        for (int i = 0; i < 225; i++)
        {
            if (test1.Kareler[i].IsGold == true && test1.Kareler[i].IsHidden == false)
            {
                if(flagA == 1 && i == hedefA)
                {
                    continue;
                }
                if (flagB == 1 && i == hedefB)
                {
                    continue;
                }
                if (flagC == 1 && i == hedefC)
                {
                    continue;
                }
                uzaklik = Mathf.Abs(xek - test1.Kareler[i].X) + Mathf.Abs(yek - test1.Kareler[i].Y);
                hamlesayisi = hamleSayisiBul(uzaklik);

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
        Player4.transform.position = new Vector3(1, 1, 0);


    }
    private void Start()
    {
        test1 = FindObjectOfType<test>();
        d = FindObjectOfType<Destroyer>();
        ps = FindObjectOfType<PlayerScript>();

    }
}
