using UnityEngine;

public class GroundControl : MonoBehaviour
{
    private float tiltSideways;
    private float tilSeesaw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiltSideways = Input.GetAxis("Horizontal");
        tilSeesaw = Input.GetAxis("Vertical");

        transform.Rotate(
            -tilSeesaw * 0.5f,
            0.0f,
            tiltSideways * 0.5f
        );
    }
}