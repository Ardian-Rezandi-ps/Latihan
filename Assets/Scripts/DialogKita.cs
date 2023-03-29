using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
public class DialogKita : MonoBehaviour
{
    public static DialogKita instance;
    public DialogManager DialogManager;
    public GameObject[] Example;
    
    void Awake()
    {
        instance=this;
    }
    public void BicarasamaNpcBurung()
    {
         var dialogTexts = new List<DialogData>();

         dialogTexts.Add(new DialogData("/color:black/Welcome To /size:up/Mentoring",""
        // ,() => Show_Example(0)
         ));
             dialogTexts.Add(new DialogData("Ini /color:black/latihan Dialog","Sa"));
           
             var TexQuest= new DialogData("Apa kabar?");
            TexQuest.SelectList.Add("Syukurlah","Baik kak");
            TexQuest.SelectList.Add("Semangat","Sedih kak");
                TexQuest.Callback = () =>CekKabar();
                
            dialogTexts.Add(TexQuest);
          //  CekKabar();
          DialogManager.Show(dialogTexts);
    }
    void CekKabar(){
         
        if(DialogManager.Result=="Syukurlah"){
             var dialogTexts = new List<DialogData>();
             dialogTexts.Add(new DialogData("Oh Syukurlah","Sa", () => Show_Example(0)));
              DialogManager.Show(dialogTexts);
        }else  if(DialogManager.Result=="Semangat"){
             var dialogTexts = new List<DialogData>();
             dialogTexts.Add(new DialogData("Tetap semangat!","Sa", () => Show_Example(1)));
              DialogManager.Show(dialogTexts);
        }
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }

}
