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

public partial class PhysicsRagdollPose_t : NativeObject
{
    public PhysicsRagdollPose_t (IntPtr pointer) : base(pointer) {}

	// __m_pChainEntity
	[SchemaMember("PhysicsRagdollPose_t", "__m_pChainEntity")]
	public CNetworkVarChainer __m_pChainEntity => Schema.GetDeclaredClass<CNetworkVarChainer>(this.Handle, "PhysicsRagdollPose_t", "__m_pChainEntity");

	// m_Transforms
	[SchemaMember("PhysicsRagdollPose_t", "m_Transforms")]
	public NetworkedVector<CTransform> Transforms => Schema.GetDeclaredClass<NetworkedVector<CTransform>>(this.Handle, "PhysicsRagdollPose_t", "m_Transforms");

	// m_hOwner
	[SchemaMember("PhysicsRagdollPose_t", "m_hOwner")]
	public CHandle<CBaseEntity> Owner => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "PhysicsRagdollPose_t", "m_hOwner");

}