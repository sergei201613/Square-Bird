using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private List<Collider2D> _overlapColliders = new List<Collider2D>();

    public bool GetIsGrounded()
    {
        if (_overlapColliders.Count > 0)
            return true;
        else
            return false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject != gameObject)
            _overlapColliders.Add(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _overlapColliders.Remove(other);
    }
}
