namespace AttackRun.Player
{
    using UnityEngine;
    using AttackRun.Interfaces;
    [RequireComponent(typeof(Player))]
    public class PlayerReference : PlayerBase, IEntityReference
    {
        public Transform Location => player.transform;
        public void Damage(int value){
            player.Events.OnDamageRecived.Invoke(value);
        }
    }


}
