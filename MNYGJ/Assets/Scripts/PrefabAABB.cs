﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class PrefabAABB : MonoBehaviour
{

    /// <summary>
    /// local space Axis Aligned Bounding Box
    /// </summary>
    public Bounds bounds;
    Transform _transform;

    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position + bounds.center, bounds.size);
    }

    void Reset()
    {
        RecalculateBounds();
    }

    public Bounds WorldBounds()
    {
        if (_transform == null)
            _transform = transform;

        Bounds b = bounds;
        b.center += _transform.position;

        Vector3 size = b.size;
        Vector3 tsize = _transform.lossyScale;
        size.x *= tsize.x;
        size.y *= tsize.y;
        size.z *= tsize.z;
        b.size = size;

        return b;
    }

    [ContextMenu("Recalculate Bounds")]
    public void RecalculateBounds()
    {
        MeshFilter this_mf = GetComponent<MeshFilter>();
        if (this_mf == null)
        {
            bounds = new Bounds(Vector3.zero, Vector3.zero);
        }
        else
        {
            bounds = this_mf.sharedMesh.bounds;
        }

        MeshFilter[] mfs = GetComponentsInChildren<MeshFilter>();
        foreach (MeshFilter mf in mfs)
        {
            Vector3 pos = mf.transform.localPosition;
            Bounds child_bounds = mf.sharedMesh.bounds;
            child_bounds.center += pos;
            bounds.Encapsulate(child_bounds);
        }
    }

#if UNITY_EDITOR
    void Update()
    {
        CalculateBounds();
        if (Application.isPlaying) return;

        //RecalculateBounds();
    }
#endif


    public void CalculateBounds()
    {
        bounds.size = Vector3.zero; // reset
        Collider2D[] colliders = GetComponentsInChildren<Collider2D>();
        foreach (Collider2D col in colliders)
        {
            bounds.Encapsulate(col.bounds);
            Debug.Log(bounds);
        }
    }

}