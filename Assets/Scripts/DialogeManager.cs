using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogeManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;
    [SerializeField] TextMeshProUGUI textBoton;
    [SerializeField] int posicionFrase = 0;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] bool hasTalked;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //al entrar activa la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCbehaviour>().data.dialogueFrases;
            if(!hasTalked)
            {
                textoDelDialogo.text = "Hola forastero!";
                dialogueUI.SetActive(true);
            }
            else
            {
                textoDelDialogo.text = "Esto no es facil";
            }
        }
        
        
    }

    void OnTriggerExit(Collider other)
    {
        //al salir desactiva la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
        }
        
    }

    public void proxFrase()
    {
        if(posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;
            if(posicionFrase == frasesDialogo.Length - 1)
            {
                textBoton.text = "cerrar";
            }
        }
        else{
            dialogueUI.SetActive(false);
        }
    } 
}
