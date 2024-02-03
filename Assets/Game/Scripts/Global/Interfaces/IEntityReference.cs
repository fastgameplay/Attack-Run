
namespace AttackRun.Interfaces
{
    using UnityEngine;
    public interface IEntityReference
    {
        public Transform Location { get; }
        public void Damage(int value);
    }
    


}

