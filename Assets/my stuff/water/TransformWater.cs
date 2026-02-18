using UnityEngine;
using UnityEngine.UI;

public class TransformWater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider age;
    public float ageNumber;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        ageNumber = age.value;
        this.transform.position = new Vector3(50.0f, ageNumber, 50.0f);
    }
}
