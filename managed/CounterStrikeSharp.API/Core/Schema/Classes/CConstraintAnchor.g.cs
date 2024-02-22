// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CConstraintAnchor : CBaseAnimGraph
{
    public CConstraintAnchor (IntPtr pointer) : base(pointer) {}

	// m_massScale
	[SchemaMember("CConstraintAnchor", "m_massScale")]
	public ref float MassScale => ref Schema.GetRef<float>(this.Handle, "CConstraintAnchor", "m_massScale");

}