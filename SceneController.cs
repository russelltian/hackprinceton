using System.Collections;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    [SerializeField]
    private GameObject soccerBallPrefab;

    private GameObject _soccerBall;

    private bool last_status;

    private void Start()
    {
        last_status = false;
    }

    private void Update()
    {
        bool this_status = Input.GetKey("p");
        if ( this_status && (last_status != this_status))
        {
            _soccerBall = Instantiate(soccerBallPrefab) as GameObject;

            float initXpos = Random.Range(12, 15);
            float initYpos = Random.Range(2f, 6);
            float initZpos = Random.Range(-0.3f, 2.2f);

            _soccerBall.transform.position = new Vector3(initXpos, initYpos, initZpos);

            float angle = Random.Range(0, 360);
            _soccerBall.transform.Rotate(0, angle, 0);
            _soccerBall.AddComponent<Rigidbody>();
            _soccerBall.AddComponent<SphereCollider>();
            var soccerBallRb = _soccerBall.GetComponent<Rigidbody>();
            soccerBallRb.mass = 50.0f;

            soccerBallRb.AddForce(Random.Range(-20000, -60000), 0, 0);
        }
        last_status = this_status;
        //}
    }
}