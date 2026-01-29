using UnityEngine;
using UnityEngine.EventSystems;

public class Dialogue : MonoBehaviour, IPointerClickHandler
{
    [TextArea]
    public string[] dialogues;
    public void StartInteraction()
    {
        DialogueManager.instance.ShowDialogue(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Sprite clicked!");
        StartInteraction();
    }
    public void EndInteraction()
    {
        Debug.Log("Dialogue ended");
    }

}
