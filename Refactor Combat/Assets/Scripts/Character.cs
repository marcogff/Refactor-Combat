using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Character : MonoBehaviour
{
    private float _healtActual;
    private float _healtMax;
    private int _damage;
    private int _defense;
    private Vector3 _scaleNormal;
    private Vector3 _infoTextPosition;

    private bool _isAlive;
    public bool isAlive { get { return _isAlive; } }

    private Vector3 _startPosition;
    public Vector3 StartPosition { get { return _startPosition; } }

    private BoxCollider _boxCollider;
    public BoxCollider BoxCollider { get { return _boxCollider; } }

    private SpriteRenderer _spriteRenderer;
    public SpriteRenderer SpriteRenderer { get { return _spriteRenderer; } }

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _scaleNormal = transform.localScale;
        _startPosition = transform.position;

        SetCharacter();

        _healtActual = _healtMax;


    }

    public virtual void SetCharacter()
    {
        // _isAlive = true;
        // _name = character.name;
        // _characterType = character.characterType;
        // _charaterBehaviour = character.characterBehaviour;

        // _healtMax = character.healthMax;
        // _damage = character.damage;
        // _defense = character.defense;

    }
    


}
