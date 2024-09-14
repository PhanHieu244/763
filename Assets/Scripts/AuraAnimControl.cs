using System;
using System.Collections.Generic;
using UnityEngine;

public class AuraAnimControl : MonoBehaviour
{
	[SerializeField]
	public List<AnimationClip> anim;

	[SerializeField]
	private Animator animator;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayAnim(int ID)
	{
		try
		{
			if (ID < 0) ID = 0;
			if (ID >= anim.Count) return;
			this.animator.Play(this.anim[ID].name);
		}
		catch (Exception e)
		{
			Debug.LogWarning(e);
			throw;
		}
		
	}
}
