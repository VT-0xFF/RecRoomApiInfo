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
public interface LAPBMAEDKPK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity HDAMGELLPBF
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
	[RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x4A368E0", Offset = "0x4A356E0", VA = "0x184A368E0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72313F0", Offset = "0x72301F0", VA = "0x1872313F0")]
		public static RigidTransform JCHCBNMNCNP(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72313F0", Offset = "0x72301F0", VA = "0x1872313F0")]
		public static AuthoredLocalPoseData JCHCBNMNCNP(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	public struct AuthoredParentData : IComponentData, LAPBMAEDKPK
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
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static AuthoredParentData JCHCBNMNCNP(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7231410", Offset = "0x7230210", VA = "0x187231410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ELOMJBLCEOF : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[CompilerGenerated]
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
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Default(GADINOAACEO.EnabledForRole)]
		[RecRoom.DataLayer.Field(3)]
		public GADINOAACEO filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
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
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RecRoom.DataLayer.StableTypeHash(780699438743496039uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[RRGuid("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
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
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JLEIMPPHHCC : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
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
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HGHAIIIKPIH : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
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
			[Cpp2IlInjected.Address(RVA = "0x2533EA0", Offset = "0x2532CA0", VA = "0x182533EA0")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2523650", Offset = "0x2522450", VA = "0x182523650")]
		public EntityBundlePartData(Entity prefabRoot, EntityBundlePartId partId)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		internal EntityBundlePartId(uint MIFPCBFGGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390")]
		internal uint JJKHACCKBHH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1ED9E60", Offset = "0x1ED8C60", VA = "0x181ED9E60", Slot = "4")]
		public bool Equals(EntityBundlePartId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7231420", Offset = "0x7230220", VA = "0x187231420", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x110BB30", Offset = "0x110A930", VA = "0x18110BB30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1ED9E80", Offset = "0x1ED8C80", VA = "0x181ED9E80")]
		public static bool BHDCHHANDIG(EntityBundlePartId HJGGLHBFMKO, EntityBundlePartId AGAPPIBJJBC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(JCNPJIGPNPG.Children)]
		public JCNPJIGPNPG collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[CompilerGenerated]
	[RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public FKEFFIMPMDP grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(MDOGAOLHEIJ.NavMeshGenerator)]
		[Config(null, 0)]
		public MDOGAOLHEIJ mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(GLDFCNIMNAN.IsDynamicEnvironment)]
		public GLDFCNIMNAN collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ICGAEPIPHPA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum PGBGFFMNDFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum IGDMGIJKLHC
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7231DA0", Offset = "0x7230BA0", VA = "0x187231DA0")]
	public static (PGBGFFMNDFG, IGDMGIJKLHC) LPCDJBGHODD(this GLDFCNIMNAN EMAGOACMMCH)
	{
		return default((PGBGFFMNDFG, IGDMGIJKLHC));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(3, false)]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(OFKIBJDIALG.DEFAULT)]
		[RecRoom.DataLayer.Field(1)]
		public OFKIBJDIALG flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
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
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static InventionIdData JCHCBNMNCNP(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72320B0", Offset = "0x7230EB0", VA = "0x1872320B0")]
		public readonly bool LHFDKIOIDAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x700EF60", Offset = "0x700DD60", VA = "0x18700EF60")]
		public static bool LHFDKIOIDAH(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public static InventionInstanceIdData JCHCBNMNCNP(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ParentData : IComponentData, LAPBMAEDKPK
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
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BPNJGEKLGMI : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public GFAEAKCPAMB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static SiblingSortOrderData JCHCBNMNCNP(GFAEAKCPAMB value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7231A30", Offset = "0x7230830", VA = "0x187231A30", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	public struct InteractionFilterAllTagsData : IComponentData, LAPBMAEDKPK
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
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[RecRoom.DataLayer.Default(GADINOAACEO.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public GADINOAACEO filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, LAPBMAEDKPK
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
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[CompilerGenerated]
	[RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[ConfigGroup("Object", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public JJLMKIHFGND scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		public DEHCHGHMLNK userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(FJJIGCEJIMM.Default)]
		[RecRoom.DataLayer.Field(4)]
		public FJJIGCEJIMM circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public GIJJLHMDBAJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	public struct PlayerScopeData : IComponentData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static PlayerScopeData JCHCBNMNCNP(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[RecRoom.DataLayer.Default(10f)]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(GEJEIADHCHJ.None)]
		public GEJEIADHCHJ flags;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6722A50", Offset = "0x6721850", VA = "0x186722A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6722A60", Offset = "0x6721860", VA = "0x186722A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72323E0", Offset = "0x72311E0", VA = "0x1872323E0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public AOIDDNEDMCD shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public GFAEAKCPAMB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static SplinePointOrderData JCHCBNMNCNP(GFAEAKCPAMB value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
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
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public KFOIBPICOAF parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[CompilerGenerated]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	[RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RecRoom.DataLayer.Range(GENLDHLGIGG.MIN, GENLDHLGIGG.ALL)]
[RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum GENLDHLGIGG
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
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[RecRoom.DataLayer.Default(GENLDHLGIGG.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public GENLDHLGIGG toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public EJHKEGBCNDE statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Flags]
[RecRoom.DataLayer.Range(EJHKEGBCNDE.None, EJHKEGBCNDE.ALL)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
public enum EJHKEGBCNDE
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
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
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

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4A368E0", Offset = "0x4A356E0", VA = "0x184A368E0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72313F0", Offset = "0x72301F0", VA = "0x1872313F0")]
		public static RigidTransform JCHCBNMNCNP(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72313F0", Offset = "0x72301F0", VA = "0x1872313F0")]
		public static LocalPoseData JCHCBNMNCNP(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BDOKGEAAGMC
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static RigidTransform PBBDJCKDIHD(this LocalPoseData IPHILEOFJLB)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public PGEKODOPNON transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NCDNJODNGAC transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.StableTypeHash(798350452111942523uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NJNFOMGPIJM prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public PMJLGJGNALL kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct GHDLHIJPJEN : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static GHDLHIJPJEN KPNHHCMCHOD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7231D70", Offset = "0x7230B70", VA = "0x187231D70", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer LBONEMFCDEA, ReferenceGroupReferenceBuffer IOKFBHNPJAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xC690A0", Offset = "0xC67EA0", VA = "0x180C690A0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer JOOHPPHJKMI)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : EFHLKHLOGBL, IBufferElementData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static AuthoredUserTagReferenceBuffer JCHCBNMNCNP(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface EFHLKHLOGBL : IBufferElementData, LAPBMAEDKPK
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	[RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[CompilerGenerated]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72323F0", Offset = "0x72311F0", VA = "0x1872323F0")]
		public static UserTagNameData JCHCBNMNCNP(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	public struct UserTagReferenceBuffer : EFHLKHLOGBL, IBufferElementData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static UserTagReferenceBuffer JCHCBNMNCNP(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[ConfigGroup("Visual", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public BHMDPIOBIIO color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public CMKDMKNLIMB material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.Range(FJJIGCEJIMM.NONE, FJJIGCEJIMM.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum FJJIGCEJIMM
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
[Cpp2IlInjected.Token(Token = "0x200004D")]
[RecRoom.DataLayer.Range(0, 4)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum GOECDLGPKIN
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
[Cpp2IlInjected.Token(Token = "0x200004E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.Range(ALOHGINMIGA.NONE, ALOHGINMIGA.ALL)]
[Flags]
public enum ALOHGINMIGA
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
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.Range(0, 127)]
public enum GLDFCNIMNAN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.Range(JCNPJIGPNPG.Off, JCNPJIGPNPG.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum JCNPJIGPNPG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RecRoom.DataLayer.Range(0, 2)]
[RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum AOIDDNEDMCD
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.Range(FKEFFIMPMDP.Pivot, FKEFFIMPMDP.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum FKEFFIMPMDP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.Range(GADINOAACEO.EnabledForRole, GADINOAACEO.DisabledForRole)]
public enum GADINOAACEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[RecRoom.DataLayer.Range(MDOGAOLHEIJ.NavMeshGenerator, MDOGAOLHEIJ.NavMeshBlocker)]
[RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum MDOGAOLHEIJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(GIJJLHMDBAJ.None, GIJJLHMDBAJ.All)]
public enum GIJJLHMDBAJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, GBACOOFBNFH.COUNT)]
[RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum GBACOOFBNFH
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class MMIDBKFHDEK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7232170", Offset = "0x7230F70", VA = "0x187232170")]
	public static void DJKOKNNCNMK(this GIJJLHMDBAJ HNALEDONGCB, GBACOOFBNFH GNBNDKPAAOG, bool OHPJAPBNBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72321A0", Offset = "0x7230FA0", VA = "0x1872321A0")]
	public static bool KOBHPGGPDAN(this GIJJLHMDBAJ HNALEDONGCB, GBACOOFBNFH GNBNDKPAAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC71380", Offset = "0xC70180", VA = "0x180C71380")]
	public static GIJJLHMDBAJ JNHOBHEEKFD(this GBACOOFBNFH GNBNDKPAAOG)
	{
		return default(GIJJLHMDBAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.Range(DEHCHGHMLNK.NONE, DEHCHGHMLNK.COUNT)]
public enum DEHCHGHMLNK
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.Range(1000, 8000)]
public enum NJNFOMGPIJM
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ConfigIgnore]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[Config("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[Config("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[Config("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[Config("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[Config("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[Config("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[Config("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[Config("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[Config("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[Config("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[Config("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[Config("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[Config("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[Config("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[Config("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[Config("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class JKOECCBGOIA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72320C0", Offset = "0x7230EC0", VA = "0x1872320C0")]
	public static DCDDLCJJDIG DCEEKKHGNNO(this NJNFOMGPIJM GFOODEKJMLI)
	{
		return default(DCDDLCJJDIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.Range(0, 9)]
public enum DCDDLCJJDIG
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GHMILGPIDOA
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7231D90", Offset = "0x7230B90", VA = "0x187231D90")]
	public static bool CFMGEHIGEPF(this DCDDLCJJDIG EFLHIFHHPPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[RecRoom.DataLayer.Range(0, OFKIBJDIALG.ALL)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum OFKIBJDIALG : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MAX = 0x3E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public LOEIMIFIJEN shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(-1, 38)]
[RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum LOEIMIFIJEN
{
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[RecRoom.DataLayer.Range(PMJLGJGNALL.None, PMJLGJGNALL.COUNT)]
[RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PMJLGJGNALL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum GEJEIADHCHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[Flags]
[RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum CHKBNPKBLIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
[RecRoom.DataLayer.Range(0, 1)]
[RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PGEKODOPNON
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(-2, 2)]
public enum NCDNJODNGAC
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum BHMDPIOBIIO
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.Range(-1, 31)]
public enum CMKDMKNLIMB
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct GFAEAKCPAMB : IComparable<GFAEAKCPAMB>, IEquatable<GFAEAKCPAMB>
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static readonly GFAEAKCPAMB JBBIPKIKKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[RecRoom.DataLayer.Field(1)]
	public uint AGHADGBLLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[RecRoom.DataLayer.Field(2)]
	public uint CNMOIJDANDJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private readonly uint GDBEEAFKGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7231BA0", Offset = "0x72309A0", VA = "0x187231BA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public readonly bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7231B90", Offset = "0x7230990", VA = "0x187231B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7231D10", Offset = "0x7230B10", VA = "0x187231D10")]
	public GFAEAKCPAMB(int AGHADGBLLKD, int CDCADKDNJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7231D10", Offset = "0x7230B10", VA = "0x187231D10")]
	public GFAEAKCPAMB(uint AGHADGBLLKD, uint CDCADKDNJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7231C90", Offset = "0x7230A90", VA = "0x187231C90")]
	private GFAEAKCPAMB(uint AGHADGBLLKD, uint CDCADKDNJED, bool BMNKKLJLHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7231B20", Offset = "0x7230920", VA = "0x187231B20")]
	public GFAEAKCPAMB JKFIFLCCAJP(int DACBEFNKNPO = 1)
	{
		return default(GFAEAKCPAMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7231920", Offset = "0x7230720", VA = "0x187231920")]
	public GFAEAKCPAMB EGMOEEJJGFK(int DACBEFNKNPO = 1)
	{
		return default(GFAEAKCPAMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7231620", Offset = "0x7230420", VA = "0x187231620")]
	public static GFAEAKCPAMB DOLJGGCEFPJ(GFAEAKCPAMB PMKFIDCMLAN, GFAEAKCPAMB BFOIKIBAAFG)
	{
		return default(GFAEAKCPAMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7231AC0", Offset = "0x72308C0", VA = "0x187231AC0")]
	private static ulong HEIIIDANPFJ(ulong HJGGLHBFMKO, ulong AGAPPIBJJBC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72315E0", Offset = "0x72303E0", VA = "0x1872315E0", Slot = "4")]
	public int CompareTo(GFAEAKCPAMB LHMPMCLNOPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7231990", Offset = "0x7230790", VA = "0x187231990", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7231BB0", Offset = "0x72309B0", VA = "0x187231BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7231A30", Offset = "0x7230830", VA = "0x187231A30", Slot = "5")]
	public bool Equals(GFAEAKCPAMB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7231A70", Offset = "0x7230870", VA = "0x187231A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32B5C20", Offset = "0x32B4A20", VA = "0x1832B5C20")]
	public static bool BHDCHHANDIG(GFAEAKCPAMB PMKFIDCMLAN, GFAEAKCPAMB BFOIKIBAAFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7231B00", Offset = "0x7230900", VA = "0x187231B00")]
	public static bool HGMDHININLF(GFAEAKCPAMB PMKFIDCMLAN, GFAEAKCPAMB BFOIKIBAAFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7231600", Offset = "0x7230400", VA = "0x187231600")]
	public static bool DFBCFFCGILP(GFAEAKCPAMB PMKFIDCMLAN, GFAEAKCPAMB BFOIKIBAAFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7231A50", Offset = "0x7230850", VA = "0x187231A50")]
	public static bool FCBJLEEGMDC(GFAEAKCPAMB PMKFIDCMLAN, GFAEAKCPAMB BFOIKIBAAFG)
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
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x105A210", Offset = "0x1059010", VA = "0x18105A210")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public static NetworkGuid JCHCBNMNCNP(Guid OGOMDMBFOMG)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x72321C0", Offset = "0x7230FC0", VA = "0x1872321C0", Slot = "4")]
		public bool Equals(NetworkGuid LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x456AB70", Offset = "0x4569970", VA = "0x18456AB70", Slot = "5")]
		public int CompareTo(NetworkGuid LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x72321F0", Offset = "0x7230FF0", VA = "0x1872321F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct JJLMKIHFGND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	[RecRoom.DataLayer.Field(1)]
	public bool KKHNIMMKCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[RecRoom.DataLayer.Field(2)]
	public float3 IOAMBMJHOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[RecRoom.DataLayer.Field(3)]
	public float3 BGKDFCLLIPG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x722FA10", Offset = "0x722E810", VA = "0x18722FA10")]
	public JJLMKIHFGND(float KGJBAAHPLAG, float GAMKMEIMNNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct KFOIBPICOAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[RecRoom.DataLayer.Field(1)]
	public float DEOMDOAOJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[RecRoom.DataLayer.Field(2)]
	public int DLEDIKFGPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[RecRoom.DataLayer.Field(3)]
	public CHKBNPKBLIJ HNALEDONGCB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BEDNAGIDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x72320E0", Offset = "0x7230EE0", VA = "0x1872320E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7232100", Offset = "0x7230F00", VA = "0x187232100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OPPCEGHPOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x72320F0", Offset = "0x7230EF0", VA = "0x1872320F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7232130", Offset = "0x7230F30", VA = "0x187232130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool FPBDAGOKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7232120", Offset = "0x7230F20", VA = "0x187232120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7232150", Offset = "0x7230F50", VA = "0x187232150")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class INJFNNFAKGO : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class FAAPGHJABFB : Property<RRObjectPrefabData, NJNFOMGPIJM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x72315B0", Offset = "0x72303B0", VA = "0x1872315B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72314C0", Offset = "0x72302C0", VA = "0x1872314C0")]
		public FAAPGHJABFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7E10", Offset = "0x1EF6C10", VA = "0x181EF7E10", Slot = "14")]
		public override NJNFOMGPIJM GetValue(RRObjectPrefabData BCNFHKMHIOK)
		{
			return default(NJNFOMGPIJM);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72314B0", Offset = "0x72302B0", VA = "0x1872314B0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData BCNFHKMHIOK, NJNFOMGPIJM IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7231F30", Offset = "0x7230D30", VA = "0x187231F30")]
	public INJFNNFAKGO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7232210", Offset = "0x7231010", VA = "0x187232210")]
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
