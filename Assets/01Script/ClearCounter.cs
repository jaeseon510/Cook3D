using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField]private Transform tomatoPerfab;
    [SerializeField] private Transform counterTopPoint;
    public void Interact()
    {
        Debug.Log("Interact");
        Transform tomatoTransform = Instantiate(tomatoPerfab, counterTopPoint);

        tomatoTransform.localPosition = Vector3.zero;
    }
}
