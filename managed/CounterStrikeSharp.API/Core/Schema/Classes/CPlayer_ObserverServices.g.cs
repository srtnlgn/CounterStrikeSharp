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

public partial class CPlayer_ObserverServices : CPlayerPawnComponent
{
    public CPlayer_ObserverServices (IntPtr pointer) : base(pointer) {}

	// m_iObserverMode
	[SchemaMember("CPlayer_ObserverServices", "m_iObserverMode")]
	public ref byte ObserverMode => ref Schema.GetRef<byte>(this.Handle, "CPlayer_ObserverServices", "m_iObserverMode");

	// m_hObserverTarget
	[SchemaMember("CPlayer_ObserverServices", "m_hObserverTarget")]
	public CHandle<CBaseEntity> ObserverTarget => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPlayer_ObserverServices", "m_hObserverTarget");

	// m_iObserverLastMode
	[SchemaMember("CPlayer_ObserverServices", "m_iObserverLastMode")]
	public ref ObserverMode_t ObserverLastMode => ref Schema.GetRef<ObserverMode_t>(this.Handle, "CPlayer_ObserverServices", "m_iObserverLastMode");

	// m_bForcedObserverMode
	[SchemaMember("CPlayer_ObserverServices", "m_bForcedObserverMode")]
	public ref bool ForcedObserverMode => ref Schema.GetRef<bool>(this.Handle, "CPlayer_ObserverServices", "m_bForcedObserverMode");

}