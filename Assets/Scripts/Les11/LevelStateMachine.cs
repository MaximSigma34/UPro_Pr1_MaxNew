using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LevelStateMachine 
{
    private Dictionary<Type, IlevelState> _LevelState = new Dictionary<Type, IlevelState>();
    private IlevelState _currentState;
    public IlevelState CurrentState { get => _currentState; }
    public void AddState(IlevelState state)
    {
        Type type = state.GetType();
        if (!_LevelState.ContainsKey(type))
        {
            _LevelState.Add(type, state);
        }
    }
    public void SetState(IlevelState state)
    {
        Type type = state.GetType();
        if(_currentState != null && _currentState.GetType() == type)
        {
            return;
        }

        if(_LevelState.TryGetValue(type, out IlevelState newState))
        {
            _currentState?.Exit();
            _currentState = newState;
            _currentState.Enter();

        }
    }

    public void Fixed()
    {
        _currentState.fixedDo();
    }
    public void Update()
    {
        _currentState.Do();
    }
}
