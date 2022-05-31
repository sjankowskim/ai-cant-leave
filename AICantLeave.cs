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
            Debug.Log("(AICantLeave) Loaded successfully!");
            return base.OnLoadCoroutine();
        }

        private void OnPlayerSpawned()
        {
            FleePoint.list.Clear();
        }
    }
}
