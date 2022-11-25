
using System.Collections;
using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
   public Vector3Data v3Data;
   private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
   public BoolData canRun;
   
   public void ResetToZero()
   {
      transform.position = Vector3.zero;
   }

   public void SetV3Value()
   {
      v3Data.value = transform.position;
   }

   public void StartRunSetValue()
   {
      canRun.value = true;
      StartCoroutine(RunSetValue());
   }
   
   private IEnumerator RunSetValue()
   {
      while (canRun.value)
      {
         SetV3Value();
         yield return wffu;
      }
   }
}
