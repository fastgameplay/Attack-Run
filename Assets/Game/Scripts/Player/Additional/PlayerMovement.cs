namespace AttackRun.Player
{
    using UnityEngine;

    public class PlayerMovement : PlayerBase
    {
        private Transform _target;
        

        private void OnTargetChange(Transform target){
            _target = target;
        }
        private bool CheckDistance(){
            if (Vector3.Distance(player.transform.position , _target.position) < player.Data.StopDistance){
                return true;
            }
            return false;
        }

        
        private void OnEnable() {
            player.Events.OnTargetChange += OnTargetChange;
        }
        private void OnDisable() {
            player.Events.OnTargetChange -= OnTargetChange;
        }
    }
}