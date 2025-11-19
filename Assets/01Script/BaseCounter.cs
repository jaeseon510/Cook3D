using UnityEngine;
using UnityEngine.PlayerLoop;

public class BaseCounter : MonoBehaviour
{
    public virtual void Interact(Player player)
    {
        Debug.Log("Interacting...");
    }
}
