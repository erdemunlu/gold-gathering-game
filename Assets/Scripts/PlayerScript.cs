using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    test test1;
    Player  oyuncu;
    PlayerA oyuncuA;
    PlayerB oyuncuB;
    PlayerC oyuncuC;
    PlayerD oyuncuD;
    LoadScene ld;

    
     

    void Start()
    {

        

        

        test1 = FindObjectOfType<test>();
        
        oyuncu = FindObjectOfType<Player>();
        oyuncuA = FindObjectOfType<PlayerA>();
        oyuncuB = FindObjectOfType<PlayerB>();
        oyuncuC = FindObjectOfType<PlayerC>();
        oyuncuD = FindObjectOfType<PlayerD>();
        ld = FindObjectOfType<LoadScene>();
        StartCoroutine(Text());
        UnityEngine.PlayerPrefs.SetInt("FirstSituation", oyuncu.MevcutAltin);
        
        UnityEngine.PlayerPrefs.Save();


        

    }
    IEnumerator Text()  //  <-  its a standalone method
    {
        int altinsayisi = test1.altinSayisi + test1.gizliAltinSayisi;
        int degerA = 1;
        int degerB = 1;
        int degerC = 1;
        int degerD = 1;
        int tur = 1;
        int uzaklikA=100;
        int uzaklikB = 100;
        int uzaklikC = 100;

        while (altinsayisi > 0 && (oyuncuA.MevcutAltin>0 || oyuncuB.MevcutAltin>0 || oyuncuC.MevcutAltin>0 || oyuncuD.MevcutAltin>0))
        {
            if(tur == 1 && altinsayisi > 0)
            {
                if (oyuncuA.hedefimVarMi == false)
                {
                    if (oyuncuA.MevcutAltin >= oyuncuA.hedefBelirlemeTutar)
                    {
                        degerA = oyuncuA.hedefBelirlemeA();
                    }
                }
                if(oyuncuA.hedefimVarMi==true && oyuncuA.MevcutAltin >= oyuncuA.hamleTutari && oyuncuA.ulastikMi != true)
                {
                    if(test1.Kareler[degerA].IsGold == false)
                    {
                        if(oyuncuA.MevcutAltin >= oyuncuA.hedefBelirlemeTutar)
                        {
                            degerA = oyuncuA.hedefBelirlemeA();
                            if(oyuncuA.MevcutAltin >= oyuncuA.hamleTutari)
                            {
                                uzaklikA= oyuncuA.hamleA(degerA);
                                yield return new WaitForSeconds(1);
                                if (oyuncuA.ulastikMi == true)
                                {
                                    altinsayisi--;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (oyuncuA.MevcutAltin >= oyuncuA.hamleTutari)
                        {
                            uzaklikA=oyuncuA.hamleA(degerA);
                            yield return new WaitForSeconds(1);
                            if (oyuncuA.ulastikMi == true)
                            {
                                altinsayisi--;
                            }
                        }
                    }
                }
                tur++;
            }
            //B oyuncusuna geçiş
            if (tur == 2 && altinsayisi > 0)
            {
                if (oyuncuB.hedefimVarMi == false)
                {
                    if (oyuncuB.MevcutAltin >= oyuncuB.hedefBelirlemeTutar)
                    {
                        degerB = oyuncuB.hedefBelirlemeB();
                    }
                }
                if (oyuncuB.hedefimVarMi == true && oyuncuB.MevcutAltin >= oyuncuB.hamleTutari && oyuncuB.ulastikMi != true)
                {
                    if (test1.Kareler[degerB].IsGold == false)
                    {
                        if (oyuncuB.MevcutAltin >= oyuncuB.hedefBelirlemeTutar)
                        {
                            degerB = oyuncuB.hedefBelirlemeB();
                            if (oyuncuB.MevcutAltin >= oyuncuB.hamleTutari)
                            {
                                uzaklikB=oyuncuB.hamleB(degerB);
                                yield return new WaitForSeconds(1);
                                if (oyuncuB.ulastikMi == true)
                                {
                                    altinsayisi--;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (oyuncuB.MevcutAltin >= oyuncuB.hamleTutari)
                        {
                            uzaklikB=oyuncuB.hamleB(degerB);
                            yield return new WaitForSeconds(1);
                            if (oyuncuB.ulastikMi == true)
                            {
                                altinsayisi--;
                            }
                        }
                    }
                }
                tur++;
            }

            // C OYUNCUSUNA GEÇİŞ

            if (tur == 3 && altinsayisi > 0)
            {
                if (oyuncuC.hedefimVarMi == false)
                {
                    if (oyuncuC.MevcutAltin >= oyuncuC.hedefBelirlemeTutar)
                    {
                        degerC = oyuncuC.hedefBelirlemeC();
                    }
                }
                if (oyuncuC.hedefimVarMi == true && oyuncuC.MevcutAltin >= oyuncuC.hamleTutari && oyuncuC.ulastikMi != true)
                {
                    if (test1.Kareler[degerC].IsGold == false)
                    {
                        if (oyuncuC.MevcutAltin >= oyuncuC.hedefBelirlemeTutar)
                        {
                            degerC = oyuncuC.hedefBelirlemeC();
                            if (oyuncuC.MevcutAltin >= oyuncuC.hamleTutari)
                            {
                                uzaklikC=oyuncuC.hamleC(degerC);
                                yield return new WaitForSeconds(1);
                                if (oyuncuC.ulastikMi == true)
                                {
                                    altinsayisi--;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (oyuncuC.MevcutAltin >= oyuncuC.hamleTutari)
                        {
                            uzaklikC=oyuncuC.hamleC(degerC);
                            yield return new WaitForSeconds(1);
                            if (oyuncuC.ulastikMi == true)
                            {
                                altinsayisi--;
                            }
                        }
                    }
                }
                tur++;
            }
            // D OYUNCUSUNA GEÇİŞ
            if (tur == 4 && altinsayisi > 0)
            {
                if (oyuncuD.hedefimVarMi == false)
                {
                    if (oyuncuD.MevcutAltin >= oyuncuD.hedefBelirlemeTutar)
                    {
                        
                        degerD = oyuncuD.hedefBelirlemeD(degerA, degerB, degerC,uzaklikA,uzaklikB,uzaklikC);
                    }
                }
                if (oyuncuD.hedefimVarMi == true && oyuncuD.MevcutAltin >= oyuncuD.hamleTutari && oyuncuD.ulastikMi != true)
                {
                    if (test1.Kareler[degerD].IsGold == false)
                    {
                        if (oyuncuD.MevcutAltin >= oyuncuD.hedefBelirlemeTutar)
                        {
                            degerD = oyuncuD.hedefBelirlemeD(degerA, degerB, degerC, uzaklikA, uzaklikB, uzaklikC);
                            if (oyuncuD.MevcutAltin >= oyuncuD.hamleTutari)
                            {
                                oyuncuD.hamleD(degerD);
                                yield return new WaitForSeconds(1);
                                if (oyuncuD.ulastikMi == true)
                                {
                                    altinsayisi--;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (oyuncuD.MevcutAltin >= oyuncuD.hamleTutari)
                        {
                            oyuncuD.hamleD(degerD);
                            yield return new WaitForSeconds(1);
                            if (oyuncuD.ulastikMi == true)
                            {
                                altinsayisi--;
                            }
                        }
                    }
                }
                
            }

            tur = 1; //BAŞA DÖNMEK İÇİN
            




        }
        //OYUN BİTTİKTEN SONRA SON EKRANA GEÇİŞ:
        ld.LoadLastScene();
    }
    
    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSecondsRealtime(5);

    }


    // Update is called once per frame
    void Update()
    {
        UnityEngine.PlayerPrefs.SetInt("LastSituationA", oyuncuA.MevcutAltin);
        UnityEngine.PlayerPrefs.SetInt("LastSituationB", oyuncuB.MevcutAltin);
        UnityEngine.PlayerPrefs.SetInt("LastSituationC", oyuncuC.MevcutAltin);
        UnityEngine.PlayerPrefs.SetInt("LastSituationD", oyuncuD.MevcutAltin);


    }
}
