using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Board mBoard;

    void Start()
    {
        #region ��������� ����
        // �������� ����
        mBoard.Create();
        #endregion
    }
}