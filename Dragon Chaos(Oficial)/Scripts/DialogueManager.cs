using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    private Queue<string> sentencas;
	// Use this for initialization
	void Start () {
        sentencas = new Queue<string>();
	}
	
	public void ComecarDialogo(Dialogue dialogo)
    {
        sentencas.Clear();

        foreach(string frase in dialogo.sentencas)
        {
            sentencas.Enqueue(frase);
        }

        DisplayNextFrase();
    }
    public void DisplayNextFrase()
    {
        if(sentencas.Count == 0)
        {
            EndDialogo();
            return;
        }
        string frase = sentencas.Dequeue();
    }
    public void EndDialogo()
    {
        Debug.Log("Fim da Conversa");
    }
}
