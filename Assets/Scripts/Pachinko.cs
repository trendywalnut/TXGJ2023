using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class Pachinko : Singleton<Pachinko>
{
    [SerializeField] private GameObject _PachinkoBall;
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D[] _SpinnersArray;
    [SerializeField] private Camera _Camera;
    // [SerializeField] private GameObject _Camera;
    private Rigidbody2D _ballRigidbody;
    [SerializeField] private float _BallDropMoveSpeed;
    [SerializeField] private GameObject _DropButton;
    private bool _ballDropped = false;
    private GameObject _ball;
    private bool _isMovingRight = true;
    void Start()
    {
        _DropButton.SetActive(true);
        _ball = GameObject.Instantiate(_PachinkoBall, new Vector3(Random.Range(-4.4f, 4.4f), 4.5f, 0), Quaternion.identity) as GameObject;
        _ballRigidbody = _ball.GetComponent<Rigidbody2D>();
        _ballRigidbody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DropBallClicked()
    {
        _ballDropped = true;
        _ballRigidbody.isKinematic = false;
        _DropButton.SetActive(false);
    }
    void FixedUpdate()
    {
        if(!_ballDropped)
        {
            if(_ballRigidbody.position.x <= -4.3f)
            {
                _isMovingRight = true;
            }
            else if(_ballRigidbody.position.x >= 4.3f)
            {
                _isMovingRight = false;
            }
            if(_isMovingRight)
            {
                _ballRigidbody.MovePosition(_ballRigidbody.position + new Vector2(_BallDropMoveSpeed, 0) * Time.deltaTime);
            }
            else
            {
                _ballRigidbody.MovePosition(_ballRigidbody.position - new Vector2(_BallDropMoveSpeed, 0) * Time.deltaTime);
            }

        }
        for(int spinner = 0; spinner < _SpinnersArray.Length; spinner++)
        {
            if(spinner % 2 == 0)
            {
                _SpinnersArray[spinner].AddTorque(30f);
            }
            else
            {
                _SpinnersArray[spinner].AddTorque(-30f);
            }
        }
        // foreach(GameObject spinner in _Spinners)
        // {
        //     spinner.GetComponent<Rigidbody2D>().AddTorque(5f);
        // }
        
    }
    private IEnumerator BallDrop()
    {
        while(true)
        {
            if(_ballRigidbody.position.x < -4.3f){}
                // _PachinkoBall.GetComponent<Rigidbody2D>().MovePosition(new Vector2(_ballRigidbody.position.x))
        }
    }
    public void BallEnteredCollider(string s)
    {
        Debug.Log(s);
        _Camera.DOShakePosition(2f, 2,10,80,true);
    }
}
