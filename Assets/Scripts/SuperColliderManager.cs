using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SuperColliderManager
{
    public static IReadOnlyList<ISuperCollider> SuperColliders => _superColliders;

    private static List<ISuperCollider> _superColliders;

    public static void Register(ISuperCollider collider)
    {
        _superColliders.Add(collider);
    }

    public static void Release(ISuperCollider collider)
    {
        _superColliders.Remove(collider);
    }
}
