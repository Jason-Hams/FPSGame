using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class PuzzlePiece : MonoBehaviour
{
    public UnityEvent onUnlock;

    protected virtual void UnlockPuzzle()
    {
        onUnlock.Invoke();
    }

    public abstract void ResetPuzzle();
    
}
