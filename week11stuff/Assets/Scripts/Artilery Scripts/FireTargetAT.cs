using System.Collections;
using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEditor;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class FireTargetAT : ActionTask {

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        float speed = 5f;
        public GameObject shell;
        public BBParameter<Transform> ArtDetect;
        public BBParameter<Transform> ArtTarget;
        public GameObject spawner;
        private IEnumerator coroutine;
        public Vector3 localTransform;
        public Vector3 offset;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {
            coroutine = spawn(2.0f);
            StartCoroutine(coroutine);

            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {

        }


        //Called once per frame while the action is active.
        protected override void OnUpdate() {

        }
        private IEnumerator spawn(float waitTime)
        {
            while (true)
            {
                yield return new WaitForSeconds(waitTime);
                shell = GameObject.Instantiate(shell, spawner.transform.position, spawner.transform.rotation);
            }
        }
        //Called when the task is disabled.
        protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}