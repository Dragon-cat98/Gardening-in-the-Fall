using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private string animationName_anim1;
    [SerializeField] private string animationName_anim2;

    [SerializeField] private int layer = 0;

    public bool clicked = false;

    private void Reset()
    {
        // Auto-assign if the Animator is on the same GameObject as this script
        animator = GetComponent<Animator>();
    }

    public void PlayPanelAnimation()
    {
        if (clicked == false)
        {
            PlayPanelAnimation(animationName_anim1);
            clicked = true;
        }
        else if (clicked == true)
        {
            PlayPanelAnimation(animationName_anim2);
            clicked = false;
        }
    }


    public void PlayPanelAnimation(string stateName)
    {
        if (animator == null)
        {
            return;
        }

        if (string.IsNullOrEmpty(stateName))
        {
            return;
        }

        animator.Play(stateName, layer);
    }
}
