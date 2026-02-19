using UnityEngine;

public class InteractableObject : MonoBehaviour {
    public string objectName = "Object";
    public string description = "Interact with this object";
    protected bool isInteracted = false;

    public virtual void Interact() {
        isInteracted = true;
        Debug.Log("Interacted with: " + objectName);
    }

    public virtual void ShowDescription() {
        Debug.Log(description);
    }
}