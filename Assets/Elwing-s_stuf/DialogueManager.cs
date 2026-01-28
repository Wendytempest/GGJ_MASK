using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public TextMeshProUGUI label;

    public GameObject UiDialogue;

    private void Awake()
    {
        instance = this;
        UiDialogue.SetActive(false);
    }

    public void ShowDialogue(Dialogue dialogue)
    {
        UiDialogue.SetActive(true);
        Debug.Log("Dialogue clicked");
        dialogueIndex = 0;
        label.text = dialogue.dialogues[0];
        currentDialogue = dialogue;
    }


    Dialogue currentDialogue;
    int dialogueIndex = 0;

    public void NextLine()
    {
        if (currentDialogue == null) return;
            
        dialogueIndex = dialogueIndex + 1;
        if (dialogueIndex >= currentDialogue.dialogues.Length)
        {
            currentDialogue.EndInteraction();
            currentDialogue = null;
            UiDialogue.SetActive(false);
            return;
        }
        label.text = currentDialogue.dialogues[dialogueIndex];
    }
}
