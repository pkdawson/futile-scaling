using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
	void Start()
	{
		FutileParams fparams = new FutileParams(true, true, false, false);
		fparams.AddResolutionLevel(1024, 1, 1, "");
		fparams.origin = new Vector2(0.5f,0.5f);
		
		Futile.instance.Init(fparams);
		
		Futile.atlasManager.LoadImage("tile32");
		Futile.atlasManager.LoadImage("tile64");
		Futile.atlasManager.LoadImage("tile128");
		Futile.atlasManager.LoadImage("tile256");
		
		FSprite tile32 = new FSprite("tile32");
		FSprite tile64 = new FSprite("tile64");
		FSprite tile128 = new FSprite("tile128");
		FSprite tile256 = new FSprite("tile256");
		
		FSprite tile32_2 = new FSprite("tile32");
		FSprite tile32_4 = new FSprite("tile32");
		FSprite tile32_8 = new FSprite("tile32");
		
		// native res
		tile32.x = -150;
		tile32.y = 300;
		Futile.stage.AddChild(tile32);
		
		tile64.x = -150;
		tile64.y = 300-64;
		Futile.stage.AddChild(tile64);
		
		tile128.x = -150;
		tile128.y = 300-64-128;
		Futile.stage.AddChild(tile128);

		tile256.x = -150;
		tile256.y = 300-64-128-256;
		Futile.stage.AddChild(tile256);

		// upscaled
		tile32_2.scale = 2;
		tile32_2.x = 150;
		tile32_2.y = 300-64;
		Futile.stage.AddChild(tile32_2);

		tile32_4.scale = 4;
		tile32_4.x = 150;
		tile32_4.y = 300-64-128;
		Futile.stage.AddChild(tile32_4);

		tile32_8.scale = 8;
		tile32_8.x = 150;
		tile32_8.y = 300-64-128-256;
		Futile.stage.AddChild(tile32_8);
	}
	
	void Update()
	{	
	}
}
