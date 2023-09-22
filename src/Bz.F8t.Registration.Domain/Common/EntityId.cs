﻿namespace Bz.F8t.Registration.Domain.Common;

public abstract record EntityId<TId>
{
	public EntityId(TId value)
	{
		Value = value;
	}

    public TId Value { get; init; }
}
