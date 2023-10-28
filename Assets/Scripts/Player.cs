using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 _moveDirection;
    Vector2 _position;

    Transform _trans;

    int _currentPlace = 1;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);

        InputManager.SetGameControls();

        _trans = GetComponent<Transform>();

        _position = _trans.position;

    }

    // Update is called once per frame
    void Update()
    {


        //_trans.position = _position;
    }

    public void FightVirus(string tag)
    {
        //GameObject[] gameObjects = GameObject.FindObjectsWithTag(tag);
        if (gameObject.tag == "Virus1")
        {
            Destroy(gameObject);
        }
    }

    //public Vector2 GetPosition()
    //{
       // return _position;
    //}

    //public void setPosition(Vector2 pos)
    //{
        //_position = pos;
    //}

    //public int getCurrentPlace()
    //{
       // return _currentPlace;
    //}

    //public void SetCurrentTile(int currentPlace)
    //{
        //_currentPlace = currentPlace;
    //}

    //public void SetMovementDirection(Vector2 currentDirection)
    //{
        //_//moveDirection = currentDirection;
    //}//
}
