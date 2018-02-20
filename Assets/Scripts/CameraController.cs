using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool _gameover;

    [SerializeField]
    private float _learpRate;
    
    // Use this for initialization
    void Start()
    {
        if (_learpRate < 1)
        {
            _learpRate = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}