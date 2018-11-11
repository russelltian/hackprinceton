using UnityEngine;

public class KnightMovement : MonoBehaviour {
    public PlayerMatch leftWristMatch;
    public PlayerMatch rightWristMatch;
    public PlayerMatch leftAnkleMatch;
    public PlayerMatch rightAnkleMatch;

    public Animator m_Animator;
    private AnimationEvent[] _aEvents;
    private AnimationClip _aniclip;

    //Value from the slider, and it converts to speed level
    public float animatorSpeed;

    public void FreeLeftWrist()
    {
        Debug.Log("I am at FreeLeftWrist");
        leftWristMatch.setNeedMatchedStatus(false);

    }

    public void LockLeftWrist()
    {
        leftWristMatch.setNeedMatchedStatus(true);

    }

    public void FreeLeftWrist2()
    {
        leftWristMatch.setNeedMatchedStatus(false);

    }

    void Start()
    {
        _aniclip = m_Animator.runtimeAnimatorController.animationClips[0];
        _aEvents = new AnimationEvent[3];
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)//First, set hands not need player match
            {
                _aEvents[i] = new AnimationEvent();
                _aEvents[i].functionName = "FreeLeftWrist";
                _aEvents[i].time = 2.0f;
                continue;
            }
            if (i == 1)//Second, lock hands at waist, need player match
            {
                _aEvents[i] = new AnimationEvent();
                _aEvents[i].functionName = "LockLeftWrist";
                _aEvents[i].time = 21.0f;
                continue;
            }
            if (i == 2)
            {
                _aEvents[i] = new AnimationEvent();
                _aEvents[i].functionName = "FreeLeftWrist2";
                _aEvents[i].time = 36.0f;
                continue;
            }
            
        }

        _aniclip.events = _aEvents;
        Debug.Log(_aniclip.events.Length);

    }

    void Update()
    {
        if (!m_Animator)
        {
            return;
        }
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            Destroy(m_Animator.gameObject);
        }
        if (CanProceed())
        {
            m_Animator.speed = animatorSpeed;
        }
        else
        {
            m_Animator.speed = 0.0f;
        }

    }

    

    private bool CanProceed()
    {
        return leftWristMatch.getIntersectionStatus() &&
            rightWristMatch.getIntersectionStatus() &&
            leftAnkleMatch.getIntersectionStatus() &&
            rightAnkleMatch.getIntersectionStatus();
    }

}
