using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPuzzleController : PuzzlePiece
{
    [SerializeField] List<ClockInput> ClockInputs;
    [SerializeField] List<int> RandomSequence;
    public List<int> randomizedSequence()
    {
        List<int> sequence = new List<int>();
        for (int index = 0; index < ClockInputs.Count; index++)
        {
            sequence.Add(index);

        }

        List<int> randomsequence = new List<int>();
        for (int index = 0; index < ClockInputs.Count; index++)
        {
            int i = sequence[Random.Range(0, sequence.Count)];
            sequence.Remove(i);
            randomsequence.Add(i);
            Debug.Log(i);
             
        }

        return randomsequence;
    }

    public void onPlayerInput(int value)
    {
        if (value == RandomSequence[0])
        {
            RandomSequence.RemoveAt(0);
            if (RandomSequence.Count <= 0)
            {
                UnlockPuzzle();
            }
        } 
        else
        {
            ResetPuzzle();
        }
    }
    public override void ResetPuzzle()
    {
        RandomSequence = randomizedSequence();

    }

    // Start is called before the first frame update
    void Start()
    {
        for (int index=0;  index<ClockInputs.Count; index++)
        {
            ClockInputs[index].LinkToController(this, index);
        }

        randomizedSequence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
