using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FMLIHBJIFBL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity JNOPHKJEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x46498A0", Offset = "0x46482A0", VA = "0x1846498A0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9420", Offset = "0x6DA7E20", VA = "0x186DA9420")]
		public static RigidTransform OLKJPEKNNFN(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9420", Offset = "0x6DA7E20", VA = "0x186DA9420")]
		public static AuthoredLocalPoseData OLKJPEKNNFN(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	public struct AuthoredParentData : IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static AuthoredParentData OLKJPEKNNFN(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9440", Offset = "0x6DA7E40", VA = "0x186DA9440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DJNOKBGCFDD : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(HAMKDOGKBNB.EnabledForRole)]
		public HAMKDOGKBNB filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[CompilerGenerated]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[RecRoom.DataLayer.StableTypeHash(780699438743496039uL, 0u)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RRGuid("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MCGBDIPEGIB : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Default(0)]
		[RecRoom.DataLayer.Field(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x228D680", Offset = "0x228C080", VA = "0x18228D680")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x227C9F0", Offset = "0x227B3F0", VA = "0x18227C9F0")]
		public EntityBundlePartData(Entity prefabRoot, EntityBundlePartId partId)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70")]
		internal EntityBundlePartId(uint CMEADPACGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700")]
		internal uint NEKLPDKKEMI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x200A890", Offset = "0x2009290", VA = "0x18200A890", Slot = "4")]
		public bool Equals(EntityBundlePartId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DA95E0", Offset = "0x6DA7FE0", VA = "0x186DA95E0", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDE4820", Offset = "0xDE3220", VA = "0x180DE4820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x200A8B0", Offset = "0x20092B0", VA = "0x18200A8B0")]
		public static bool EKIKFCPHGPG(EntityBundlePartId PEMPEACEHBG, EntityBundlePartId FDDPOELCNDG)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RecRoom.DataLayer.StableTypeHash(11104975410044731874uL, 0u)]
	[RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Default(GCIMJGEIOFH.IsDynamicEnvironment)]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public GCIMJGEIOFH collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DMEAHAFFKCD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PCBGKNMIAFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum NLBEDAKPBBG
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9450", Offset = "0x6DA7E50", VA = "0x186DA9450")]
	public static (PCBGKNMIAFA, NLBEDAKPBBG) JOLDJJPGAHH(this GCIMJGEIOFH FLMAECPLNCE)
	{
		return default((PCBGKNMIAFA, NLBEDAKPBBG));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[RecRoom.DataLayer.StableTypeHash(2914713536404587710uL, 0u)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Default(HBMCGPPNEEC.Children)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public HBMCGPPNEEC collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	[RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[ConfigGroup("Container", 0)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Default(OKCENOEKMFE.DEFAULT)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public OKCENOEKMFE flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Default(0f)]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[ConfigGroup("Container", 0)]
	[RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public DAOGJJNEHNF grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(OPJANFKCKPN.NavMeshGenerator)]
		[RecRoom.DataLayer.Field(1)]
		public OPJANFKCKPN mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static InventionIdData OLKJPEKNNFN(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9C60", Offset = "0x6DA8660", VA = "0x186DA9C60")]
		public readonly bool NIBNCLGPPLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5140", Offset = "0x6BA3B40", VA = "0x186BA5140")]
		public static bool NIBNCLGPPLE(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public static InventionInstanceIdData OLKJPEKNNFN(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ParentData : IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct JFNIMJLPLNK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FNBNHJHANON order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static SiblingSortOrderData OLKJPEKNNFN(FNBNHJHANON value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9820", Offset = "0x6DA8220", VA = "0x186DA9820", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	[RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(HAMKDOGKBNB.Disabled)]
		public HAMKDOGKBNB filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.NetworkComponent(5, false)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[RecRoom.DataLayer.StableTypeHash(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[ConfigGroup("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public OCJHPGBEEJI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		public KKJLAJPGCHJ userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(AEELCLEFBNG.Default)]
		public AEELCLEFBNG circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		[RecRoom.DataLayer.Field(1)]
		public KIOBFOCEJLD flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static PlayerScopeData OLKJPEKNNFN(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(DMGCPCFOJCI.None)]
		public DMGCPCFOJCI flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62EABE0", Offset = "0x62E95E0", VA = "0x1862EABE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x62EABF0", Offset = "0x62E95F0", VA = "0x1862EABF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DAA0D0", Offset = "0x6DA8AD0", VA = "0x186DAA0D0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public IJFMPACLLKE shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FNBNHJHANON order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static SplinePointOrderData OLKJPEKNNFN(FNBNHJHANON value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public JFNNGCLCPMM parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RecRoom.DataLayer.StableTypeHash(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(BNIKIPLFCPF.CURRENT)]
		public BNIKIPLFCPF version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(CKKGOMGJLIJ.MIN, CKKGOMGJLIJ.ALL)]
[RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
public enum CKKGOMGJLIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[RecRoom.DataLayer.Default(CKKGOMGJLIJ.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public CKKGOMGJLIJ toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public KALIECFDEAG statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(KALIECFDEAG.None, KALIECFDEAG.ALL)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KALIECFDEAG
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x46498A0", Offset = "0x46482A0", VA = "0x1846498A0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9420", Offset = "0x6DA7E20", VA = "0x186DA9420")]
		public static RigidTransform OLKJPEKNNFN(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9420", Offset = "0x6DA7E20", VA = "0x186DA9420")]
		public static LocalPoseData OLKJPEKNNFN(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CAOFONBABFM
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static RigidTransform PPCGJOBPLPH(this LocalPoseData PKCLPFEIPFH)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[CompilerGenerated]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ODAGACHMJEL transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public JJFMCBALIKM transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(798350452111942523uL, 0u)]
	[RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EBLEEPKFPFE prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GABGNEGOHJK kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FNNGHCDGNPN : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static FNNGHCDGNPN JCFGJMCEKAD;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9AB0", Offset = "0x6DA84B0", VA = "0x186DA9AB0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer PMBJFHIMJKC, ReferenceGroupReferenceBuffer HBABDGBANAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x96BF70", Offset = "0x96A970", VA = "0x18096BF70", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer BBNKFKDCOLP)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[CompilerGenerated]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	public struct AuthoredUserTagReferenceBuffer : LEMENAHMFJO, IBufferElementData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static AuthoredUserTagReferenceBuffer OLKJPEKNNFN(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LEMENAHMFJO : IBufferElementData, FMLIHBJIFBL
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAA0E0", Offset = "0x6DA8AE0", VA = "0x186DAA0E0")]
		public static UserTagNameData OLKJPEKNNFN(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[CompilerGenerated]
	[InternalBufferCapacity(0)]
	[RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	public struct UserTagReferenceBuffer : LEMENAHMFJO, IBufferElementData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static UserTagReferenceBuffer OLKJPEKNNFN(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[ConfigGroup("Visual", 0)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CompilerGenerated]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public DJGJAENKNLL color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[RecRoom.DataLayer.Field(2)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public KPLMDLGKHKB material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.Range(AEELCLEFBNG.NONE, AEELCLEFBNG.COUNT)]
public enum AEELCLEFBNG
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.Range(0, 4)]
public enum LEBGOMJGJHF
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[Flags]
[RecRoom.DataLayer.Range(AJAPKMNEBDK.NONE, AJAPKMNEBDK.ALL)]
public enum AJAPKMNEBDK
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[RecRoom.DataLayer.Range(HBMCGPPNEEC.Off, HBMCGPPNEEC.COUNT)]
[RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HBMCGPPNEEC
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[ConfigIgnore]
[RRGuid("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[RecRoom.DataLayer.Range(BNIKIPLFCPF.VERSION_0, BNIKIPLFCPF.CURRENT)]
public enum BNIKIPLFCPF : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 127)]
public enum GCIMJGEIOFH
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[Config("Dynamic (Environment)", 0)]
	[@Tooltip("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.Range(0, OKCENOEKMFE.ALL)]
public enum OKCENOEKMFE
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RecRoom.DataLayer.Range(0, 2)]
[RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum IJFMPACLLKE
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.Range(DAOGJJNEHNF.Pivot, DAOGJJNEHNF.COUNT)]
public enum DAOGJJNEHNF
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[RecRoom.DataLayer.Range(HAMKDOGKBNB.EnabledForRole, HAMKDOGKBNB.DisabledForRole)]
[RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HAMKDOGKBNB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[RecRoom.DataLayer.Range(OPJANFKCKPN.NavMeshGenerator, OPJANFKCKPN.NavMeshBlocker)]
[RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum OPJANFKCKPN
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[RecRoom.DataLayer.Range(KIOBFOCEJLD.None, KIOBFOCEJLD.All)]
[RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KIOBFOCEJLD
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[RecRoom.DataLayer.Range(0, HIIMGOHPDNM.COUNT)]
[RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HIIMGOHPDNM
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FOGMHGPJCGO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9AF0", Offset = "0x6DA84F0", VA = "0x186DA9AF0")]
	public static void CADIEIMFLMA(this KIOBFOCEJLD DDACCEBMBND, HIIMGOHPDNM IHGKJHBIDGF, bool PELDDJLLGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9AD0", Offset = "0x6DA84D0", VA = "0x186DA9AD0")]
	public static bool BNKPFOGIGOF(this KIOBFOCEJLD DDACCEBMBND, HIIMGOHPDNM IHGKJHBIDGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x97ECB0", Offset = "0x97D6B0", VA = "0x18097ECB0")]
	public static KIOBFOCEJLD MLNBNGOPKJE(this HIIMGOHPDNM IHGKJHBIDGF)
	{
		return default(KIOBFOCEJLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(KKJLAJPGCHJ.NONE, KKJLAJPGCHJ.COUNT)]
[RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum KKJLAJPGCHJ
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.DataLayer.Range(1000, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum EBLEEPKFPFE
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[ConfigIgnore]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[Config("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[Config("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[Config("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[Config("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[Config("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[Config("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[Config("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[Config("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[Config("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[Config("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[Config("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[Config("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[Config("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[Config("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[Config("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[Config("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class APLFLPFHCJF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9400", Offset = "0x6DA7E00", VA = "0x186DA9400")]
	public static CHDCAAKIBPG CEGEKPJBJKC(this EBLEEPKFPFE ADCKHDIMKFL)
	{
		return default(CHDCAAKIBPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[RecRoom.DataLayer.Range(0, 9)]
[RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum CHDCAAKIBPG
{
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HHNLCANKCFE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9C50", Offset = "0x6DA8650", VA = "0x186DA9C50")]
	public static bool PPENEDMCGEC(this CHDCAAKIBPG OFKLGFNPKLA)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public JKLBMPOHFIB shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum JKLBMPOHFIB
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.Range(GABGNEGOHJK.None, GABGNEGOHJK.COUNT)]
public enum GABGNEGOHJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
[RecRoom.DataLayer.Range(0, 7)]
[RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum DMGCPCFOJCI
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
[RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum LOLOFJOLBLA
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[RecRoom.DataLayer.Range(0, 1)]
[RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum ODAGACHMJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(-2, 2)]
public enum JJFMCBALIKM
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum DJGJAENKNLL
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[RecRoom.DataLayer.Range(-1, 31)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum KPLMDLGKHKB
{
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct FNBNHJHANON : IComparable<FNBNHJHANON>, IEquatable<FNBNHJHANON>
{
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static readonly FNBNHJHANON BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[RecRoom.DataLayer.Field(1)]
	public uint FKIDOBLDBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[RecRoom.DataLayer.Field(2)]
	public uint JPMPDJCFGOO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint OKPLEBOEJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9890", Offset = "0x6DA8290", VA = "0x186DA9890")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9A60", Offset = "0x6DA8460", VA = "0x186DA9A60")]
	public FNBNHJHANON(int FKIDOBLDBNE, int BHPLNEEICNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9A60", Offset = "0x6DA8460", VA = "0x186DA9A60")]
	public FNBNHJHANON(uint FKIDOBLDBNE, uint BHPLNEEICNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9910", Offset = "0x6DA8310", VA = "0x186DA9910")]
	public FNBNHJHANON PCKBJHCLLHJ(int FDHHGENAMHL = 1)
	{
		return default(FNBNHJHANON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6DA96E0", Offset = "0x6DA80E0", VA = "0x186DA96E0")]
	public FNBNHJHANON CNDKLJBPDGL(int FDHHGENAMHL = 1)
	{
		return default(FNBNHJHANON);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9660", Offset = "0x6DA8060", VA = "0x186DA9660")]
	public static FNBNHJHANON BOMNIOKPPKL(FNBNHJHANON FCKNABCAAPB, FNBNHJHANON JGIIKLPFBFG)
	{
		return default(FNBNHJHANON);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA98C0", Offset = "0x6DA82C0", VA = "0x186DA98C0")]
	private static uint NLKAELPCJJP(uint PEMPEACEHBG, uint FDDPOELCNDG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9750", Offset = "0x6DA8150", VA = "0x186DA9750", Slot = "4")]
	public int CompareTo(FNBNHJHANON GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9790", Offset = "0x6DA8190", VA = "0x186DA9790", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9980", Offset = "0x6DA8380", VA = "0x186DA9980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9820", Offset = "0x6DA8220", VA = "0x186DA9820", Slot = "5")]
	public bool Equals(FNBNHJHANON GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9840", Offset = "0x6DA8240", VA = "0x186DA9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x307A280", Offset = "0x3078C80", VA = "0x18307A280")]
	public static bool EKIKFCPHGPG(FNBNHJHANON FCKNABCAAPB, FNBNHJHANON JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9770", Offset = "0x6DA8170", VA = "0x186DA9770")]
	public static bool DKPEAJCEKME(FNBNHJHANON FCKNABCAAPB, FNBNHJHANON JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DA98F0", Offset = "0x6DA82F0", VA = "0x186DA98F0")]
	public static bool OFJBPMDBDGP(FNBNHJHANON FCKNABCAAPB, FNBNHJHANON JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DA98A0", Offset = "0x6DA82A0", VA = "0x186DA98A0")]
	public static bool LHEHHBKJPAN(FNBNHJHANON FCKNABCAAPB, FNBNHJHANON JGIIKLPFBFG)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public static NetworkGuid OLKJPEKNNFN(Guid MMGMNLELLKG)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9E80", Offset = "0x6DA8880", VA = "0x186DA9E80", Slot = "4")]
		public bool Equals(NetworkGuid GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
		public int CompareTo(NetworkGuid GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9EB0", Offset = "0x6DA88B0", VA = "0x186DA9EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct OCJHPGBEEJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[RecRoom.DataLayer.Field(1)]
	public bool FNEAOIOIFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[RecRoom.DataLayer.Field(2)]
	public float3 HIPJDABHMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[RecRoom.DataLayer.Field(3)]
	public float3 FNDNHIIGIGE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9ED0", Offset = "0x6DA88D0", VA = "0x186DA9ED0")]
	public OCJHPGBEEJI(float LAJFHIPPBIH, float APMEFBMNAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct JFNNGCLCPMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[RecRoom.DataLayer.Field(1)]
	public float MMEHDCHKFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[RecRoom.DataLayer.Field(2)]
	public int NLKELANNFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[RecRoom.DataLayer.Field(3)]
	public LOLOFJOLBLA DDACCEBMBND;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LJKFLGJPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9CB0", Offset = "0x6DA86B0", VA = "0x186DA9CB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9C70", Offset = "0x6DA8670", VA = "0x186DA9C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GBKAPLNBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9CC0", Offset = "0x6DA86C0", VA = "0x186DA9CC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9C90", Offset = "0x6DA8690", VA = "0x186DA9C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool AHBHEPAGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9CD0", Offset = "0x6DA86D0", VA = "0x186DA9CD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9CE0", Offset = "0x6DA86E0", VA = "0x186DA9CE0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class MKFKBCHIMBN : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class GBJEHNEALDN : Property<RRObjectPrefabData, EBLEEPKFPFE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6DA9C20", Offset = "0x6DA8620", VA = "0x186DA9C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9B30", Offset = "0x6DA8530", VA = "0x186DA9B30")]
		public GBJEHNEALDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1A48C80", Offset = "0x1A47680", VA = "0x181A48C80", Slot = "14")]
		public override EBLEEPKFPFE GetValue(RRObjectPrefabData DNJEODDCEHK)
		{
			return default(EBLEEPKFPFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9B20", Offset = "0x6DA8520", VA = "0x186DA9B20", Slot = "15")]
		public override void SetValue(RRObjectPrefabData DNJEODDCEHK, EBLEEPKFPFE PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9D00", Offset = "0x6DA8700", VA = "0x186DA9D00")]
	public MKFKBCHIMBN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9F00", Offset = "0x6DA8900", VA = "0x186DA9F00")]
		[Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
