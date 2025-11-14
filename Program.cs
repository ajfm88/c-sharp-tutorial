using UnityEngine;

namespace CodeMoney.CSharpCourse.L2040_Enums
{
    public class TurnBasedStrategy : MonoBehaviour
    {
        private enum PlayerAction
        {
            NoEnemy,
            NoPathToEnemy,
            MovingTowardEnemy,
            AttackingEnemy
        }
        private enum State
        {
            LookingForEnemy,
            MovingToEnemy,
            AttackingEnemy,
        }

        private enum TutorialStage
        {
            Stage_1,
            Stage_2,
            Stage_3,
            Stage_4,
        }

        private State state;

        private void HandleState()
        {
            switch (state)
            {
                case State.MovingToEnemy:
                // Moving to enemy logic
                    break;
                case State.LookingForEnemy;
                    break;
                case State.AttackingEnemy;
                    break;
            }
        }

        private PlayerAction GetNextPlayerAction()
        {
            if (!PlayerHasEnemy())
            {
                return PlayerAction.NoEnemy;
            }
            if (!HasPathToEnemy())
            {
                return PlayerAction.NoPathToEnemy;
            }
            if (!PlayerWithinAttackDistance())
            {
                return PlayerAction.MovingTowardEnemy;
            } else
            {
                return PlayerAction.AttackingEnemy;
            }
            {
                return PlayerAction.NoEnemy;
            }
        }        
    }
}