using UnityEngine;
using UnityEngine.InputSystem;

public class Main : MonoBehaviour
{
    public GameObject peka;
    public AudioClip gako;
    public InputAction input;
    void OnSlot(InputAction.CallbackContext ctx)
    {
        int flag = Random.Range(0, 99);
        if (flag == 0)
        {
            GetComponent<AudioSource>().PlayOneShot(gako);
            peka.SetActive(true);
        } else
        {
            peka.SetActive(false);
        }
        print(flag);
    }
    void OnEnable()
    {
        peka.SetActive(false);
        input.Enable();
        input.performed += OnSlot;
    }
    void OnDisable()
    {
        input.Disable();
        input.performed -= OnSlot;
    }
}
