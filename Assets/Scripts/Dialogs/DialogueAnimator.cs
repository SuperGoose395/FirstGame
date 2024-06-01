using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator SDanim;
    public DialogueManager dm;
    public void OnTriggerEnter2D(Collider2D other)
    {
        SDanim.SetBool("SDOpen", true);
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        SDanim.SetBool("SDOpen", false);
        dm.EndDialogue();
    }

}
