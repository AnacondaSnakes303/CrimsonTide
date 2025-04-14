using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WarmColdFeedback : MonoBehaviour
{
    public TMP_Text compass;
    public Transform target;
    private Vector3 previousPosition;
    private float previousDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousPosition = transform.position;
        previousDistance = Vector3.Distance(transform.position, target.position);
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector3.Distance(transform.position, target.position);

        if (currentDistance < previousDistance)
        {
            compass.text = "Warmer..";
        }
        else if (currentDistance > previousDistance)
        {
            compass.text = "Colder... ";
        }
        else
        {
            compass.text = "Same Distance...";
        }
    }
}
