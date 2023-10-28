using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;
public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Transform _initialTransform;

    [SerializeField] private Transform _nextPos;

    Vector2[] _placePosition = new Vector2[2];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector2[] Get_placePosition()
    {
        return _placePosition;
    }
}
