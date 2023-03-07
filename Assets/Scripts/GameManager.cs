using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Board mBoard;

    public PieceManager mPieceManager;

    void Start()
    {
        #region ��������� ����
        // �������� ����
        mBoard.Create();
        #endregion

        #region ���������� �����
        mPieceManager.Setup(mBoard);
        #endregion
    }
}
