using System;
using UnityEngine;

public abstract class PlayerStateBase // soyut s�n�f olu�turduk.
{
    protected PlayerController _playerController; // Player controller s�n�f�ndan _playerController isimli bir nesne olu�turduk.

    public PlayerStateBase( PlayerController playerController)  // PlayerStateBase s�n�f�ndan t�reyen s�n�flar PlayerController nesnesine eri�ebilir.
    {                                                           //constructor bir  metod  tan�mlanm��t�r.(yap�c�).
        _playerController = playerController;
    }

   public abstract void EnterState( PlayerController playerController ); // giri�
   public abstract void UpdateState( PlayerController playerController );// g�ncelleme
   public abstract void ExitState( PlayerController playerController );// ��k��
   

}
