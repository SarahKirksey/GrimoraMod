﻿namespace GrimoraMod;

public partial class GrimoraPlugin
{
	public const string NameSpectrabbit = $"{GUID}_Spectrabbit";

	private void Add_Card_Spectrabbit()
	{
		CardBuilder.Builder
			.SetBaseAttackAndHealth(0, 1)
			.SetNames(NameSpectrabbit, "Spectrabbit")
			.Build();
	}
}
