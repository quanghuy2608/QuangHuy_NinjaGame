using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
    //Ham bat dau vao state
    void OnEnter(Enemy enemy);
    //Ham upodate state
    void OnExecute(Enemy enemy);
    //Ham thoat state
    void OnExit(Enemy enemy);
}

    
