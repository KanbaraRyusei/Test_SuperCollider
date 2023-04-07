using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperColliderBase : MonoBehaviour, ISuperCollider
{
    [SerializeField]
    protected bool _isTrigger;

    [SerializeField]
    protected Vector3 _center;

    [SerializeField]
    protected Color _color = Color.green;

    protected void OnEnable()
    {
        SuperColliderManager.Register(this);
    }

    protected void OnDisable()
    {
        SuperColliderManager.Release(this);
    }

    public bool CheckCollider(ISuperCollider collider)
    {
        return true;
    }

    //�@�X�N���v�g��ݒ肵���Q�[���I�u�W�F�N�g���I�����ꂽ�������\��
    protected virtual void OnDrawGizmosSelected()
    {
        Gizmos.color = _color;
    }
}
