using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MemoryManager : MonoBehaviour
{
    public static MemoryManager instance;
    public int skor=0;
    public TextMeshProUGUI skorTex;
    public Sprite[] spritesMemory;
    public KartuMemori[] kartuPrefab;
    public Transform tempatKartu;
    public int jumlahTerbukaSementara=0;
    public KartuMemori kartuA,kartuB;
    // Start is called before the first frame update
    void Start()
    {
        jumlahTerbukaSementara=0;
        instance =this;
        skor=0;
        SkorIsi();
        GenerateKartu();
    }

    public void SkorIsi(){
        skorTex.text= "Skor="+skor;
    }
   
   public void CekKartuTerbuka(KartuMemori kartu){
        jumlahTerbukaSementara++;
        if(jumlahTerbukaSementara <=2){
            if(kartuA==null){
                kartuA=kartu;
            }else{
                kartuB=kartu;
            }

        }else{
            jumlahTerbukaSementara=0;
            kartuA.TutupKartu();
            kartuB.TutupKartu();
            kartuA=null;
           
        }

   }
   void GenerateKartu(){
        for(int i=0;i<kartuPrefab.Length;i++){
            kartuPrefab[i].icon.gameObject.SetActive(false);
          // GameObject kartu1 = Instantiate(kartuPrefab,tempatKartu)as GameObject;
         //  kartu1.GetComponent<KartuMemori>().

          //  Instantiate(kartuPrefab,tempatKartu);
        }
   }
}
