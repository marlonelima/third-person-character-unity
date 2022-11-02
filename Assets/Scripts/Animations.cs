using UnityEngine;

public class Animations : MonoBehaviour
{

    public new Animator animation;

    // Update is called once per frame
    void Update()
    {
        animation.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animation.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }
}
