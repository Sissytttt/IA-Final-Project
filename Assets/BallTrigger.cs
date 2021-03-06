using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    public float ballStartTime;
    private float _ballStartTimer;

    public float ballEndTime;
    private float _ballEndTimer;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        _ballStartTimer = ballStartTime;
        _ballEndTimer = ballEndTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (_ballStartTimer < 0 && _ballEndTimer > 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }

        else if (_ballEndTimer < 0 && _ballStartTimer < 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            _ballStartTimer -= Time.deltaTime;
            _ballEndTimer -= Time.deltaTime;
        }
    }
}