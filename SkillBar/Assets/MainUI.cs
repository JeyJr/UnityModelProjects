using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    
    public List<Button> btnSkill = new();
    public List<Button> btnSkillBar = new();
    public List<GameObject> slotsSkillBar;


    void Start()
    {
        for(int i = 0; i < btnSkillBar.Count; i++){
            slotsSkillBar.Add(null);
        }
    }

    public void PorSkillNaSkillBar(GameObject gc){

            slotsSkillBar[2] = slotsSkillBar[1];
            slotsSkillBar[1] = slotsSkillBar[0];
            slotsSkillBar[0] = gc;

            for(int i = 0; i < 3; i++){
                if(slotsSkillBar[i] == null) break;
                Color color = slotsSkillBar[i].GetComponent<Image>().color;
                btnSkillBar[i].GetComponent<Image>().color = color;
                btnSkillBar[i].GetComponent<SkillsInput>().EnableSkill = true;
            }

    }
    public void PorSkillNaSkillBarV2(Button btn){
        //    if(slotOcupado >= 3) slotOcupado = 0;
        //         slotsSkillBar[slotOcupado] = btn.name; 
        //         btnSkillBar[slotOcupado].gameObject.GetComponent<Image>().color = btn.GetComponent<Image>().color;
        //         slotOcupado++;

        //slotsSkillBar[slotOcupado] = btn.name; 
        //btnSkillBar[slotOcupado].gameObject.GetComponent<Image>().color = btn.GetComponent<Image>().color;
        //slotOcupado++;
    }
}


