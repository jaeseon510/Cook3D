using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    
    [SerializeField] private Player player;
    private Animator animtor;
    
    private void Awake()
    {
        animtor = GetComponent<Animator>();
    }

    private void Update()
    {
        animtor.SetBool(IS_WALKING, player.IsWalking());        
    }
    
}
