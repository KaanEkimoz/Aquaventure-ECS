﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;


public class ResourceSystem : ReactiveSystem<GameEntity> 
{
	private Contexts _contexts;

	public ResourceSystem(Contexts contexts) : base(contexts.game) 
	{
		_contexts = contexts;
	}
		
	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
	{
		return context.CreateCollector(GameMatcher.Resource.Added());
	}
		
	protected override bool Filter(GameEntity entity) 
	{
		// check for required components
		return entity.hasResource;
	}

	protected override void Execute(List<GameEntity> entities) 
	{
		foreach (var e in entities) 
		{
			var go = Object.Instantiate(e.resource.instance).GetComponent<UnityViewObject>();
			e.AddUnityView(go);
			go.LinkObject(e);
			e.RemoveResource();
		}
	}
}
