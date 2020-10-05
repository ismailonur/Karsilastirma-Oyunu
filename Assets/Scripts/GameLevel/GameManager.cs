using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ustPanel;
    public GameObject altYazi;
    public GameObject ustDikdortgen;
    public GameObject altDikdortgen;
    public GameObject pausePanel;
    public GameObject sonucPanel;

    public Text ustTxt, altTxt, puanTxt;

    TimerManager timerManager;
    DairelerManager dairelerManager;
    TrueFalseManager trueFalseManager;
    SonucManager sonucManager;

    int oyunSayac, kacinciOyun;
    int ustDeger, altDeger;
    int buyukDeger;
    int butonDegeri;

    int toplamPuan, artisPuani;

    int dogruAdet, yanlisAdet;

    private AudioSource audioSource;

    public AudioClip baslangicSesi, dogruSesi, yanlisSesi, bitisSesi;

    private void Awake()
    {
        timerManager = Object.FindObjectOfType<TimerManager>();
        dairelerManager = Object.FindObjectOfType<DairelerManager>();
        trueFalseManager = Object.FindObjectOfType<TrueFalseManager>();

        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        kacinciOyun = 0;
        oyunSayac = 0;
        toplamPuan = 0;

        ustTxt.text = "";
        altTxt.text = "";
        puanTxt.text = "0";

        SahnedekileriGetir();
    }

    void SahnedekileriGetir()
    {
        ustPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        altYazi.GetComponent<CanvasGroup>().DOFade(1, 1f);

        ustDikdortgen.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
        altDikdortgen.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);

        OyunaBasla();
    }

    public void OyunaBasla()
    {
        audioSource.PlayOneShot(baslangicSesi);

        altYazi.GetComponent<CanvasGroup>().DOFade(0, .3f);
        timerManager.SureyiBaslat();
        KacinciOyun();
        Debug.Log("Başladı");
    }

    void KacinciOyun()
    {
        if(oyunSayac < 5)
        {
            kacinciOyun = 1;
            artisPuani = 10;
        }
        else if(oyunSayac >= 5 && oyunSayac < 10)
        {
            kacinciOyun = 2;
            artisPuani = 20;
        }
        else if(oyunSayac >= 10 && oyunSayac < 15)
        {
            kacinciOyun = 3;
            artisPuani = 30;
        }
        else if (oyunSayac >= 15 && oyunSayac < 20)
        {
            kacinciOyun = 4;
            artisPuani = 40;
        }
        else if(oyunSayac >= 20 && oyunSayac < 25)
        {
            kacinciOyun = 5;
            artisPuani = 50;
        }
        else
        {
            kacinciOyun = Random.Range(1, 6);
            artisPuani = 25;
        }
 
        switch (kacinciOyun)
        {
            case 1:
                BirinciFonksiyon();
                break;

            case 2:
                IkinciFonksiyon();
                break;

            case 3:
                UcuncuFonksiyon();
                break;

            case 4:
                DorduncuFonksiyon();
                break;

            case 5:
                BesinciFonksiyon();
                break;
        }
    }

    void BirinciFonksiyon()
    {
        int rastgeleDeğer = Random.Range(1, 50);

        if(rastgeleDeğer <= 25)
        {
            ustDeger = Random.Range(2, 50);
            altDeger = ustDeger + Random.Range(1, 10);
        }
        else
        {
            ustDeger = Random.Range(2, 50);
            altDeger = Mathf.Abs(ustDeger - Random.Range(1, 10));
        }
         
        if(ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if(ustDeger < altDeger)
        {
            buyukDeger = altDeger;
        }

        if(ustDeger == altDeger)
        {
            BirinciFonksiyon();
        }

        ustTxt.text = ustDeger.ToString();
        altTxt.text = altDeger.ToString();
        altTxt.text = altDeger.ToString();
    }

    void IkinciFonksiyon()
    {
        int birinciSayi = Random.Range(0, 10);
        int ikinciSayi = Random.Range(0, 20);
        int ucuncuSayi = Random.Range(0, 10);
        int dorduncuSayi = Random.Range(0, 20);

        ustDeger = birinciSayi + ikinciSayi;
        altDeger = ucuncuSayi + dorduncuSayi;

        if(ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if(altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }
        
        if(ustDeger == altDeger)
        {
            IkinciFonksiyon();
            return;
        }

        ustTxt.text = birinciSayi + " + " + ikinciSayi;
        altTxt.text = ucuncuSayi + " + " + dorduncuSayi;
    }

    void UcuncuFonksiyon()
    {
        int birinciSayi = Random.Range(11, 30);
        int ikinciSayi = Random.Range(0, 11);
        int ucuncuSayi = Random.Range(11, 40);
        int dorduncuSayi = Random.Range(0, 11);

        ustDeger = birinciSayi - ikinciSayi;
        altDeger = ucuncuSayi - dorduncuSayi;

        if (ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if (altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }

        if (ustDeger == altDeger)
        {
            UcuncuFonksiyon();
            return;
        }

        ustTxt.text = birinciSayi + " - " + ikinciSayi;
        altTxt.text = ucuncuSayi + " - " + dorduncuSayi;
    }

    void DorduncuFonksiyon()
    {
        int birinciSayi = Random.Range(0, 10);
        int ikinciSayi = Random.Range(0, 10);
        int ucuncuSayi = Random.Range(0, 10);
        int dorduncuSayi = Random.Range(0, 10);

        ustDeger = birinciSayi * ikinciSayi;
        altDeger = ucuncuSayi * dorduncuSayi;

        if(ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if(altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }
        
        if(ustDeger == altDeger)
        {
            DorduncuFonksiyon();
            return;
        }

        ustTxt.text = birinciSayi + " X " + ikinciSayi;
        altTxt.text = ucuncuSayi + " X " + dorduncuSayi;
    }

    void BesinciFonksiyon()
    {
        int bolen1 = Random.Range(2, 10);
        ustDeger = Random.Range(2, 10);

        int bolunen1 = bolen1 * ustDeger;

        int bolen2 = Random.Range(2, 10);
        altDeger = Random.Range(2, 10);

        int bolunen2 = bolen2 * altDeger;

        if(ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if(altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }

        if(ustDeger == altDeger)
        {
            BesinciFonksiyon();
            return;
        }

        ustTxt.text = bolunen1 + " / " + bolen1;
        altTxt.text = bolunen2 + " / " + bolen2;
    }

    public void ButonDegeriniBelirle(string butonAdi)
    {
        if(butonAdi == "ustButon")
        {
            butonDegeri = ustDeger;
        }
        else if (butonAdi == "altButon")
        {
            butonDegeri = altDeger;
        }

        if(butonDegeri == buyukDeger)
        {
            trueFalseManager.TrueFalseScaleAc(true);
            dairelerManager.DaireninScaleAc(oyunSayac % 5);
            oyunSayac++;
            toplamPuan += artisPuani;

            puanTxt.text = toplamPuan.ToString();

            dogruAdet++;

            audioSource.PlayOneShot(dogruSesi);

            KacinciOyun();
        }
        else
        {
            trueFalseManager.TrueFalseScaleAc(false);
            yanlisAdet++;
            audioSource.PlayOneShot(yanlisSesi);
            HatayaGoreSayaciAzalt();
            KacinciOyun();
        }
    }

    void HatayaGoreSayaciAzalt()
    {
        oyunSayac -= (oyunSayac % 5 + 5);

        if (oyunSayac < 0)
        {
            oyunSayac = 0;
        }
    }

    public void PausePaneliAc()
    {
        pausePanel.SetActive(true);
    }

    public void OyunuBitir()
    {
        audioSource.PlayOneShot(bitisSesi);

        sonucPanel.SetActive(true);

        sonucManager = Object.FindObjectOfType<SonucManager>();

        sonucManager.SonuclariGoster(dogruAdet, yanlisAdet, toplamPuan);
    }
}
