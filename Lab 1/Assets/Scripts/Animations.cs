using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator object1Animator;
    private Animator object2Animator;
    private float distance = 0.25f; // Distanța de declanșare

    void Start()
    {
        GameObject object1 = GameObject.FindWithTag("Male");
        GameObject object2 = GameObject.FindWithTag("Female");

        if (object1 != null && object2 != null)
        {
            object1Animator = object1.GetComponent<Animator>();
            object2Animator = object2.GetComponent<Animator>();
        }
        else
        {
            Debug.LogError("Nu am găsit obiectele cu tag-urile specificate!");
        }
    }

    void Update()
    {
        if (object1Animator != null && object2Animator != null)
        {
            float currentDistance = Vector3.Distance(object1Animator.transform.position, object2Animator.transform.position);

            if (currentDistance <= distance)
            {
                object1Animator.SetTrigger("Attack");
                object2Animator.SetTrigger("Attack");
            }
            else
            {
                object1Animator.SetTrigger("Idle");
                object2Animator.SetTrigger("Idle");
            }
        }
    }
}