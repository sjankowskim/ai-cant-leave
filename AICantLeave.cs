using System.Collections;
using ThunderRoad;
using UnityEngine;

namespace AICantLeave
{
    public class AICantLeave : LevelModule
    {
        public override IEnumerator OnLoadCoroutine()
        {
            EventManager.OnPlayerSpawned += OnPlayerSpawned;
            return base.OnLoadCoroutine();
        }

        private void OnPlayerSpawned()
        {
            FleePoint.list.Clear();
        }
    }
}
