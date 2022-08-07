using UnityEngine;

public class LocomotionStatePattern : MonoBehaviour, LocomotionContext
{
    LocomotionState currentState = new GroundedState();

    public void Crouch() => currentState.Crouch(this);

    public void Fall() => currentState.Fall(this);

    public void Jump() => currentState.Jump(this);

    public void Land() => currentState.Land(this);

    void LocomotionContext.SetState(LocomotionState newState)
    {
        currentState = newState;
    }
}