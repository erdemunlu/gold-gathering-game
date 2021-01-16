using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : Player
{

    test test1;
    Destroyer d;
    public GameObject Player1;
    public GameObject bk;
    public bool ulastikMi = false;
    public bool hedefimVarMi = false;
    public int hedefBelirlemeTutar = 5;

    public int hamleA(int sonuc)
    {
        int xek = (int)transform.position.x;
        int yek = (int)transform.position.y;
        int gidilecekx = test1.Kareler[sonuc].X;
        int gidileceky = test1.Kareler[sonuc].Y;
        int adim = 3;
        int xfark = Mathf.Abs(gidilecekx - xek);
        int yfark = Mathf.Abs(gidileceky - yek);
        MevcutAltin -= hamleTutari;
        int indis;
        while (adim>0 && ulastikMi == false)
        {
            while (xfark > 0 && adim>0)
            {
                if (xek > gidilecekx)
                {
                    xek -= 1;
                    adim--;
                    xfark--;
                    indis = indisBul(xek, yek);
                    if(test1.Kareler[indis].IsHidden == true && indis!= 1000)
                    {
                        test1.Kareler[indis].IsHidden = false;
                        Vector3 v3 = new Vector3(test1.Kareler[indis].X, test1.Kareler[indis].Y, 0);
                        Instantiate(test1.hiddenGold, v3, transform.rotation);
                    }
                    
                }
                else if(xek<gidilecekx )
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
            
           
            if (xfark== 0 && yfark==0)
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

        


        return xfark + yfark;




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
    

    public int hedefBelirlemeA()
    {
        int xek = (int)transform.position.x;
        int yek = (int)transform.position.y;
        
        int uzaklik = 100;
        int sonuc = 100;
        for(int j = 0; j < 225; j++)
        {

            for(int i = 0; i < 225; i++)
            {
                if(test1.Kareler[i].IsGold && test1.Kareler[i].IsHidden==false)
                {
                    if (uzaklik> (int)(Mathf.Abs(xek - (int)test1.Kareler[i].X) + (int)(Mathf.Abs(yek - (int)test1.Kareler[i].Y))))
                    {                    
                    
                        uzaklik = (Mathf.Abs(xek - test1.Kareler[i].X) + Mathf.Abs(yek - test1.Kareler[i].Y));
                        sonuc = i;
                    }
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
        Player1.transform.position = new Vector3(1, 15, 0);
        
        
    }

    private void Start()
    {
        
        test1 = FindObjectOfType<test>();
        d = FindObjectOfType<Destroyer>();

    }
    public void Update()
    {
        
    }
}
