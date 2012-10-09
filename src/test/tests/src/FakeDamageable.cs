using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests {
    class FakeDamageable : Testable.IKineticDamage {
        public bool currentlyDamageable() {
            return true;
        }

        public Testable.EntityType getType() {
            return Testable.EntityType.NEUTRAL;
        }

        public void kineticDamage(UnityEngine.Vector3 location, UnityEngine.Vector3 incidentDirection, UnityEngine.Vector3 normal, float amount) {
            
        }

        public Testable.TestableGameObject Obj { get { return null; } }

        public UnityEngine.Vector3 getLocation() {
            return new UnityEngine.Vector3();
        }
    }
}