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
public interface GEIPLJHPHML
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity ACDFDGEINEH
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
	[DCMOJIBDOMK("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[global::PHCNMLNGGOH(11505792609904010668uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[global::KGFBBPJCAPO(1, false)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::DOHEHJPPEEF(2)]
		[global::EAMABFHMLIL("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42B0150", Offset = "0x42AE750", VA = "0x1842B0150")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DA0", Offset = "0x69C33A0", VA = "0x1869C4DA0")]
		public static RigidTransform HDKGBCFDEBL(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DA0", Offset = "0x69C33A0", VA = "0x1869C4DA0")]
		public static AuthoredLocalPoseData HDKGBCFDEBL(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[global::PHCNMLNGGOH(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::PHCNMLNGGOH(10137300772124140051uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[DCMOJIBDOMK("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::KGFBBPJCAPO(1, false)]
	public struct AuthoredParentData : IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static AuthoredParentData HDKGBCFDEBL(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DC0", Offset = "0x69C33C0", VA = "0x1869C4DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MKFAFKFADIL : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[DCMOJIBDOMK("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[global::KGFBBPJCAPO(1, false)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::EAMABFHMLIL(false)]
		[global::DOHEHJPPEEF(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::EAMABFHMLIL(ODKKPIAMDKH.EnabledForRole)]
		[global::DOHEHJPPEEF(3)]
		public ODKKPIAMDKH filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(8594223769175916906uL, 0u)]
	[DCMOJIBDOMK("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(780699438743496039uL, 0u)]
	[DCMOJIBDOMK("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[global::KGFBBPJCAPO(1, false)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[DCMOJIBDOMK("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[CompilerGenerated]
	[DCMOJIBDOMK("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::KGFBBPJCAPO(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::DOHEHJPPEEF(2)]
		[global::EAMABFHMLIL(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CBDMLOFFAOI : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DCMOJIBDOMK("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[DCMOJIBDOMK("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[global::KGFBBPJCAPO(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[DCMOJIBDOMK("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6370", Offset = "0x1FE4970", VA = "0x181FE6370")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		internal EntityBundlePartId(uint DAIJJLLIENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		internal uint ALEMJEMGHEN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA44B60", Offset = "0xA43160", VA = "0x180A44B60", Slot = "4")]
		public bool Equals(EntityBundlePartId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DF0", Offset = "0x69C33F0", VA = "0x1869C4DF0", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAED3A0", Offset = "0xAEB9A0", VA = "0x180AED3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3120", Offset = "0x1AD1720", VA = "0x181AD3120")]
		public static bool FFOLOHFBIHN(EntityBundlePartId KHKPJFABMKM, EntityBundlePartId CGBLKAAFCDI)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[global::PHCNMLNGGOH(11104975410044731874uL, 0u)]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	[GOHJBCKDMPB("Container", 0)]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[DCMOJIBDOMK("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[global::DOHEHJPPEEF(1)]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL(IHPNPIHEBNC.IsDynamicEnvironment)]
		public IHPNPIHEBNC collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GJAIGLLGPPB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum MPJFPLEDKIF
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
	public enum CGJDFFOMEND
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
	[Cpp2IlInjected.Address(RVA = "0x69C4F90", Offset = "0x69C3590", VA = "0x1869C4F90")]
	public static (MPJFPLEDKIF, CGJDFFOMEND) LHPKOPKHMFD(this IHPNPIHEBNC ABCPPKFGKJO)
	{
		return default((MPJFPLEDKIF, CGJDFFOMEND));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[CompilerGenerated]
	[GOHJBCKDMPB("Container", 0)]
	[global::PHCNMLNGGOH(2914713536404587710uL, 0u)]
	[DCMOJIBDOMK("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[global::KGFBBPJCAPO(1, false)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::EAMABFHMLIL(FGHMMODCMKP.Children)]
		[DFHFCKFNNMD(null, 0)]
		[global::DOHEHJPPEEF(1)]
		public FGHMMODCMKP collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[GOHJBCKDMPB("Container", 0)]
	[global::KGFBBPJCAPO(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[DCMOJIBDOMK("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::DOHEHJPPEEF(1)]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL(DGLLELHCEGN.DEFAULT)]
		public DGLLELHCEGN flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::PHCNMLNGGOH(1094837642118998916uL, 0u)]
	[GOHJBCKDMPB("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::EAMABFHMLIL(0f)]
		[global::DOHEHJPPEEF(1)]
		[DFHFCKFNNMD(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[GOHJBCKDMPB("Container", 0)]
	[global::PHCNMLNGGOH(13657791279235747653uL, 0u)]
	[DCMOJIBDOMK("89708D57-D027-494A-A159-221E6C643B6B")]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[global::PHCNMLNGGOH(5176564412348566398uL, 0u)]
	[DCMOJIBDOMK("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[GOHJBCKDMPB("Container", 0)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		[DFHFCKFNNMD(null, 0)]
		public GPBBMBGGIFB grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[GOHJBCKDMPB("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[global::PHCNMLNGGOH(16485879999901987510uL, 0u)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::DOHEHJPPEEF(1)]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL(CHDPAPFDIPP.NavMeshGenerator)]
		public CHDPAPFDIPP mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[DCMOJIBDOMK("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::PHCNMLNGGOH(1537567323754185605uL, 0u)]
	[global::KGFBBPJCAPO(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[DCMOJIBDOMK("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(5115014870530256079uL, 0u)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DCMOJIBDOMK("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::PHCNMLNGGOH(12111354511484844847uL, 0u)]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	public struct ParentData : IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GCOPNICPGFD : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[DCMOJIBDOMK("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(1950029632769634832uL, 0u)]
	[global::KGFBBPJCAPO(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public HKHEOBACNDB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static SiblingSortOrderData HDKGBCFDEBL(HKHEOBACNDB value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69C5120", Offset = "0x69C3720", VA = "0x1869C5120", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[DCMOJIBDOMK("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[CompilerGenerated]
	[DCMOJIBDOMK("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	public struct InteractionFilterAnyTagsData : IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[DCMOJIBDOMK("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::EAMABFHMLIL(ODKKPIAMDKH.Disabled)]
		[global::DOHEHJPPEEF(1)]
		public ODKKPIAMDKH filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[DCMOJIBDOMK("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	public struct InteractionFilterNoneTagsData : IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[global::PHCNMLNGGOH(15012400804589552708uL, 0u)]
	[DCMOJIBDOMK("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[DCMOJIBDOMK("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::KGFBBPJCAPO(5, false)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
	[DCMOJIBDOMK("FB9853D6-6231-43FD-A754-00105DC30880")]
	[GOHJBCKDMPB("Object", 0)]
	[global::PHCNMLNGGOH(16541670854338945984uL, 0u)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::DOHEHJPPEEF(2)]
		[global::EAMABFHMLIL("new ScaleRestriction(1,1)")]
		public GGDNKMJOBID scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::DOHEHJPPEEF(3)]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		public KBPHFEOEKMF userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL(BMDJAEPMNDM.Default)]
		[global::DOHEHJPPEEF(4)]
		public BMDJAEPMNDM circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL("ObjectPolicyEnumFlags.Default")]
		public JHJAHPCDJGG flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[DCMOJIBDOMK("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::KGFBBPJCAPO(1, false)]
	[global::PHCNMLNGGOH(17708500325183871236uL, 0u)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static PlayerScopeData HDKGBCFDEBL(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[GOHJBCKDMPB("Physics", 0)]
	[global::PHCNMLNGGOH(16642773407304133105uL, 0u)]
	[CompilerGenerated]
	[DCMOJIBDOMK("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(10f)]
		[DFHFCKFNNMD(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[global::PHCNMLNGGOH(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[DCMOJIBDOMK("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::EAMABFHMLIL(PPJODBBIPDM.None)]
		[global::DOHEHJPPEEF(1)]
		public PPJODBBIPDM flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69C5DE0", Offset = "0x69C43E0", VA = "0x1869C5DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5F456A0", Offset = "0x5F43CA0", VA = "0x185F456A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69C5DF0", Offset = "0x69C43F0", VA = "0x1869C5DF0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[DCMOJIBDOMK("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public EMOJCCPMLJF shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(5298506180484533559uL, 0u)]
	[DCMOJIBDOMK("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public HKHEOBACNDB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static SplinePointOrderData HDKGBCFDEBL(HKHEOBACNDB value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[global::PHCNMLNGGOH(16368389834000856208uL, 0u)]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::PHCNMLNGGOH(18095612727592564636uL, 0u)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[DCMOJIBDOMK("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::PHCNMLNGGOH(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[DCMOJIBDOMK("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::EAMABFHMLIL("new quaternion(0, 0, 0, 1f)")]
		[global::DOHEHJPPEEF(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[DCMOJIBDOMK("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::PHCNMLNGGOH(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::PHCNMLNGGOH(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public LOOJMKCMMDI parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[global::KGFBBPJCAPO(1, false)]
	[global::PHCNMLNGGOH(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[DCMOJIBDOMK("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(DOBCBOCLKNF.CURRENT)]
		public DOBCBOCLKNF version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(12332323170023439017uL, 0u)]
	[DCMOJIBDOMK("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::KGFBBPJCAPO(2, false)]
	[global::FHFBMHMEJEN(new int[] { 1 })]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::DOHEHJPPEEF(2)]
		[global::EAMABFHMLIL(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::EAMABFHMLIL(true)]
		[global::DOHEHJPPEEF(3)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[global::FGHLMBBJGPE(GPFAHCMOHBB.MIN, GPFAHCMOHBB.ALL)]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
public enum GPFAHCMOHBB
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::EAMABFHMLIL(GPFAHCMOHBB.UseDefaultVisualEffects)]
		[global::DOHEHJPPEEF(2)]
		public GPFAHCMOHBB toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[global::KGFBBPJCAPO(2, false)]
	[DCMOJIBDOMK("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::FHFBMHMEJEN(new int[] { 2, 3 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(4)]
		public JILJNNLDGBH statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DCMOJIBDOMK("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[global::JPKIGKMGHKB(1, false)]
[global::FGHLMBBJGPE(JILJNNLDGBH.None, JILJNNLDGBH.ALL)]
[Flags]
public enum JILJNNLDGBH
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[global::KGFBBPJCAPO(2, false)]
	[DCMOJIBDOMK("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[global::PHCNMLNGGOH(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[DCMOJIBDOMK("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::KGFBBPJCAPO(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[global::DOHEHJPPEEF(1)]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[global::DOHEHJPPEEF(2)]
		[global::EAMABFHMLIL]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x42B0150", Offset = "0x42AE750", VA = "0x1842B0150")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DA0", Offset = "0x69C33A0", VA = "0x1869C4DA0")]
		public static RigidTransform HDKGBCFDEBL(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DA0", Offset = "0x69C33A0", VA = "0x1869C4DA0")]
		public static LocalPoseData HDKGBCFDEBL(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HLDKNAGPMAI
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static RigidTransform OCLMEMGIELJ(this LocalPoseData DMNGPNKHPKF)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::PHCNMLNGGOH(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::EAMABFHMLIL(1f)]
		[global::DOHEHJPPEEF(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	[DCMOJIBDOMK("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::PHCNMLNGGOH(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public LBFNFICHKAM transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::DOHEHJPPEEF(2)]
		[global::EAMABFHMLIL]
		public BAKFMCIJLGA transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[DCMOJIBDOMK("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::KGFBBPJCAPO(1, false)]
	[global::IGFAPDHIHDL]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[global::PHCNMLNGGOH(798350452111942523uL, 0u)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public IDEDIMNMLPE prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[global::KGFBBPJCAPO(1, false)]
	[CompilerGenerated]
	[DCMOJIBDOMK("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public EEMOMCJGFPH kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[DCMOJIBDOMK("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct ELABPMBLECJ : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static ELABPMBLECJ ABMFDACMOIG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69C4DD0", Offset = "0x69C33D0", VA = "0x1869C4DD0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer OCPDJIJPMCG, ReferenceGroupReferenceBuffer DEKMKLPIHFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13D0EF0", Offset = "0x13CF4F0", VA = "0x1813D0EF0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer NJKKPOFFNNJ)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[InternalBufferCapacity(0)]
	[global::KGFBBPJCAPO(1, false)]
	[DCMOJIBDOMK("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : EHANPOADKCI, IBufferElementData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static AuthoredUserTagReferenceBuffer HDKGBCFDEBL(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface EHANPOADKCI : IBufferElementData, GEIPLJHPHML
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[global::KGFBBPJCAPO(2, false)]
	[DCMOJIBDOMK("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[global::DOHEHJPPEEF(2)]
		[global::EAMABFHMLIL(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[global::PHCNMLNGGOH(1859693175312uL, 0u)]
	[DCMOJIBDOMK("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::KGFBBPJCAPO(1, false)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69C5E00", Offset = "0x69C4400", VA = "0x1869C5E00")]
		public static UserTagNameData HDKGBCFDEBL(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[DCMOJIBDOMK("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[global::KGFBBPJCAPO(1, false)]
	[InternalBufferCapacity(0)]
	public struct UserTagReferenceBuffer : EHANPOADKCI, IBufferElementData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static UserTagReferenceBuffer HDKGBCFDEBL(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[global::KGFBBPJCAPO(1, false)]
	[GOHJBCKDMPB("Visual", 0)]
	[global::PHCNMLNGGOH(1591066774816564574uL, 0u)]
	[CompilerGenerated]
	[DCMOJIBDOMK("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[DFHFCKFNNMD(null, 0)]
		[global::DOHEHJPPEEF(1)]
		[global::EAMABFHMLIL]
		public GDHFDPACHFB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[DFHFCKFNNMD(null, 0)]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(2)]
		public EJIAINLLJBH material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[global::DOHEHJPPEEF(3)]
		[global::EAMABFHMLIL]
		[DFHFCKFNNMD(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::EAMABFHMLIL]
		[DFHFCKFNNMD(null, 0)]
		[global::DOHEHJPPEEF(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[global::JPKIGKMGHKB(1, false)]
[global::FGHLMBBJGPE(BMDJAEPMNDM.NONE, BMDJAEPMNDM.COUNT)]
[DCMOJIBDOMK("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum BMDJAEPMNDM
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[DFHFCKFNNMD("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[DFHFCKFNNMD("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[DFHFCKFNNMD("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DCMOJIBDOMK("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::FGHLMBBJGPE(0, 4)]
[global::JPKIGKMGHKB(1, false)]
public enum LAAEHIOOFNB
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Flags]
[DCMOJIBDOMK("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::JPKIGKMGHKB(1, false)]
[global::FGHLMBBJGPE(GJCGPCEBODA.NONE, GJCGPCEBODA.ALL)]
public enum GJCGPCEBODA
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[global::JPKIGKMGHKB(1, false)]
[global::FGHLMBBJGPE(FGHMMODCMKP.Off, FGHMMODCMKP.COUNT)]
[DCMOJIBDOMK("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum FGHMMODCMKP
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[MMMJCLLHEOP]
[global::FGHLMBBJGPE(DOBCBOCLKNF.VERSION_0, DOBCBOCLKNF.CURRENT)]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
public enum DOBCBOCLKNF : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::FGHLMBBJGPE(0, 127)]
[DCMOJIBDOMK("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::JPKIGKMGHKB(1, false)]
public enum IHPNPIHEBNC
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[DFHFCKFNNMD("Dynamic (Environment)", 0)]
	[HGGPGIIPJJP("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[DFHFCKFNNMD("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[DFHFCKFNNMD("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[DFHFCKFNNMD("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[DFHFCKFNNMD("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[DFHFCKFNNMD("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[DFHFCKFNNMD("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[DFHFCKFNNMD("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[DFHFCKFNNMD("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[MMMJCLLHEOP]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[MMMJCLLHEOP]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[global::FGHLMBBJGPE(0, DGLLELHCEGN.ALL)]
[global::JPKIGKMGHKB(1, false)]
[Flags]
[DCMOJIBDOMK("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum DGLLELHCEGN
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[global::FGHLMBBJGPE(0, 2)]
[DCMOJIBDOMK("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::JPKIGKMGHKB(1, false)]
public enum EMOJCCPMLJF
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DCMOJIBDOMK("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::FGHLMBBJGPE(GPBBMBGGIFB.Pivot, GPBBMBGGIFB.COUNT)]
[global::JPKIGKMGHKB(1, false)]
public enum GPBBMBGGIFB
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[global::JPKIGKMGHKB(1, false)]
[global::FGHLMBBJGPE(ODKKPIAMDKH.EnabledForRole, ODKKPIAMDKH.DisabledForRole)]
[DCMOJIBDOMK("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum ODKKPIAMDKH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::FGHLMBBJGPE(CHDPAPFDIPP.NavMeshGenerator, CHDPAPFDIPP.NavMeshBlocker)]
public enum CHDPAPFDIPP
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DCMOJIBDOMK("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[Flags]
[global::FGHLMBBJGPE(JHJAHPCDJGG.None, JHJAHPCDJGG.All)]
[global::JPKIGKMGHKB(1, false)]
public enum JHJAHPCDJGG
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::FGHLMBBJGPE(0, EOEDKKLCHJF.COUNT)]
public enum EOEDKKLCHJF
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JEBGEJLOLCK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69C5640", Offset = "0x69C3C40", VA = "0x1869C5640")]
	public static void ECADPABFBJL(this JHJAHPCDJGG MCGGLIKAALP, EOEDKKLCHJF ODEMLHLNENC, bool AKKNAKBNOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69C5670", Offset = "0x69C3C70", VA = "0x1869C5670")]
	public static bool KILMAGDNGCE(this JHJAHPCDJGG MCGGLIKAALP, EOEDKKLCHJF ODEMLHLNENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1C98FB0", Offset = "0x1C975B0", VA = "0x181C98FB0")]
	public static JHJAHPCDJGG OADODCOMELJ(this EOEDKKLCHJF ODEMLHLNENC)
	{
		return default(JHJAHPCDJGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::FGHLMBBJGPE(KBPHFEOEKMF.NONE, KBPHFEOEKMF.COUNT)]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
public enum KBPHFEOEKMF
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[global::FGHLMBBJGPE(1000, 8000)]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum IDEDIMNMLPE
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[DFHFCKFNNMD("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[DFHFCKFNNMD("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[DFHFCKFNNMD("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[DFHFCKFNNMD("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[MMMJCLLHEOP]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[DFHFCKFNNMD("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[DFHFCKFNNMD("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[DFHFCKFNNMD("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[DFHFCKFNNMD("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[DFHFCKFNNMD("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[DFHFCKFNNMD("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[DFHFCKFNNMD("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[DFHFCKFNNMD("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[DFHFCKFNNMD("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[DFHFCKFNNMD("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[DFHFCKFNNMD("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[DFHFCKFNNMD("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[DFHFCKFNNMD("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[DFHFCKFNNMD("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[DFHFCKFNNMD("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[DFHFCKFNNMD("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[DFHFCKFNNMD("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[DFHFCKFNNMD("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[DFHFCKFNNMD("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[DFHFCKFNNMD("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[DFHFCKFNNMD("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[DFHFCKFNNMD("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[DFHFCKFNNMD("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[DFHFCKFNNMD("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[DFHFCKFNNMD("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[DFHFCKFNNMD("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[DFHFCKFNNMD("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[DFHFCKFNNMD("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[DFHFCKFNNMD("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[DFHFCKFNNMD("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[DFHFCKFNNMD("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[DFHFCKFNNMD("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[DFHFCKFNNMD("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[DFHFCKFNNMD("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[DFHFCKFNNMD("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[DFHFCKFNNMD("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[DFHFCKFNNMD("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[DFHFCKFNNMD("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[DFHFCKFNNMD("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[DFHFCKFNNMD("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[DFHFCKFNNMD("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[DFHFCKFNNMD("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[DFHFCKFNNMD("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[DFHFCKFNNMD("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[MMMJCLLHEOP]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[DFHFCKFNNMD("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[DFHFCKFNNMD("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[DFHFCKFNNMD("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[DFHFCKFNNMD("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[DFHFCKFNNMD("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[DFHFCKFNNMD("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[DFHFCKFNNMD("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[DFHFCKFNNMD("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[DFHFCKFNNMD("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[DFHFCKFNNMD("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[DFHFCKFNNMD("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[DFHFCKFNNMD("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[DFHFCKFNNMD("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[DFHFCKFNNMD("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[DFHFCKFNNMD("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[DFHFCKFNNMD("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[DFHFCKFNNMD("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FHNIJEMMGOH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69C4E80", Offset = "0x69C3480", VA = "0x1869C4E80")]
	public static IDMJFGHFBNP OOGJHOGCHHE(this IDEDIMNMLPE MDDJDHCOALA)
	{
		return default(IDMJFGHFBNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::FGHLMBBJGPE(0, 9)]
public enum IDMJFGHFBNP
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class OECGOPIBOJD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69C5A80", Offset = "0x69C4080", VA = "0x1869C5A80")]
	public static bool BADKJGKDFLO(this IDMJFGHFBNP DBPNFFLNOOP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::PHCNMLNGGOH(8060729269509364919uL, 0u)]
	[DCMOJIBDOMK("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::KGFBBPJCAPO(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[global::EAMABFHMLIL]
		[global::DOHEHJPPEEF(1)]
		public JNBPIKMLHDI shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[global::JPKIGKMGHKB(1, false)]
[global::FGHLMBBJGPE(-1, 38)]
[DCMOJIBDOMK("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum JNBPIKMLHDI
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[global::FGHLMBBJGPE(EEMOMCJGFPH.None, EEMOMCJGFPH.COUNT)]
public enum EEMOMCJGFPH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
[global::FGHLMBBJGPE(0, 7)]
[DCMOJIBDOMK("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::JPKIGKMGHKB(1, false)]
public enum PPJODBBIPDM
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[global::FGHLMBBJGPE(0, 7)]
[Flags]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum BOAMIAKHJDA
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DCMOJIBDOMK("72742F9B-D48E-4CED-B403-444201FFEE66")]
[Flags]
[global::FGHLMBBJGPE(0, 1)]
[global::JPKIGKMGHKB(1, false)]
public enum LBFNFICHKAM
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DCMOJIBDOMK("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::JPKIGKMGHKB(1, false)]
[global::FGHLMBBJGPE(-2, 2)]
public enum BAKFMCIJLGA
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::FGHLMBBJGPE(int.MinValue, int.MaxValue)]
public enum GDHFDPACHFB
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[global::JPKIGKMGHKB(1, false)]
[DCMOJIBDOMK("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::FGHLMBBJGPE(-1, 31)]
public enum EJIAINLLJBH
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[global::GHPKADBNHNB(1, false)]
[DCMOJIBDOMK("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct HKHEOBACNDB : IComparable<HKHEOBACNDB>, IEquatable<HKHEOBACNDB>, CIFFJCAGIEN
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static readonly HKHEOBACNDB CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[global::DOHEHJPPEEF(1)]
	public uint GCOEMKMCOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	[global::DOHEHJPPEEF(2)]
	public uint CANBDBOHAMP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint IFGBFDMEFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69C51E0", Offset = "0x69C37E0", VA = "0x1869C51E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69C55F0", Offset = "0x69C3BF0", VA = "0x1869C55F0")]
	public HKHEOBACNDB(int GCOEMKMCOKP, int LCEMNDFOAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69C55F0", Offset = "0x69C3BF0", VA = "0x1869C55F0")]
	public HKHEOBACNDB(uint GCOEMKMCOKP, uint LCEMNDFOAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69C52F0", Offset = "0x69C38F0", VA = "0x1869C52F0")]
	public HKHEOBACNDB JPIJJMNOAEJ(int GCMGLJCEDLO = 1)
	{
		return default(HKHEOBACNDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69C5260", Offset = "0x69C3860", VA = "0x1869C5260")]
	public HKHEOBACNDB HBKNNNMCEHC(int GCMGLJCEDLO = 1)
	{
		return default(HKHEOBACNDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69C5390", Offset = "0x69C3990", VA = "0x1869C5390")]
	public static HKHEOBACNDB KKLBAFHPNGN(HKHEOBACNDB CLMMPLJCADB, HKHEOBACNDB NIGNLACGOIM)
	{
		return default(HKHEOBACNDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69C5360", Offset = "0x69C3960", VA = "0x1869C5360")]
	private static uint KKKFHHJMEEI(uint KHKPJFABMKM, uint CGBLKAAFCDI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69C5100", Offset = "0x69C3700", VA = "0x1869C5100", Slot = "4")]
	public int CompareTo(HKHEOBACNDB BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69C5140", Offset = "0x69C3740", VA = "0x1869C5140", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69C5510", Offset = "0x69C3B10", VA = "0x1869C5510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69C5120", Offset = "0x69C3720", VA = "0x1869C5120", Slot = "5")]
	public bool Equals(HKHEOBACNDB BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69C5210", Offset = "0x69C3810", VA = "0x1869C5210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69C54A0", Offset = "0x69C3AA0", VA = "0x1869C54A0", Slot = "6")]
	public void PEGIGFCKLEH(FMNOKOIDCFD JFIDOOOHFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69C5430", Offset = "0x69C3A30", VA = "0x1869C5430", Slot = "7")]
	public void OJPHNAHFOOE(JDHBHMPEGEO MMDEOFGAFEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0000", Offset = "0x2BDE600", VA = "0x182BE0000")]
	public static bool FFOLOHFBIHN(HKHEOBACNDB CLMMPLJCADB, HKHEOBACNDB NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69C5410", Offset = "0x69C3A10", VA = "0x1869C5410")]
	public static bool NKEIKPOPFDO(HKHEOBACNDB CLMMPLJCADB, HKHEOBACNDB NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69C52D0", Offset = "0x69C38D0", VA = "0x1869C52D0")]
	public static bool HMNNIAOILMO(HKHEOBACNDB CLMMPLJCADB, HKHEOBACNDB NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69C51F0", Offset = "0x69C37F0", VA = "0x1869C51F0")]
	public static bool GJCFJJLFMCH(HKHEOBACNDB CLMMPLJCADB, HKHEOBACNDB NIGNLACGOIM)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[global::GHPKADBNHNB(1, false)]
	[DCMOJIBDOMK("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, CIFFJCAGIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[global::DOHEHJPPEEF(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public static NetworkGuid HDKGBCFDEBL(Guid IJNLNGBKEAC)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69C5900", Offset = "0x69C3F00", VA = "0x1869C5900", Slot = "4")]
		public bool Equals(NetworkGuid BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
		public int CompareTo(NetworkGuid BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69C59A0", Offset = "0x69C3FA0", VA = "0x1869C59A0", Slot = "6")]
		public void PEGIGFCKLEH(FMNOKOIDCFD JFIDOOOHFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69C5930", Offset = "0x69C3F30", VA = "0x1869C5930", Slot = "7")]
		public void OJPHNAHFOOE(JDHBHMPEGEO MMDEOFGAFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x69C5A60", Offset = "0x69C4060", VA = "0x1869C5A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[global::GHPKADBNHNB(1, false)]
[DCMOJIBDOMK("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct GGDNKMJOBID : CIFFJCAGIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[global::DOHEHJPPEEF(1)]
	public bool PCJPKCENFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[global::DOHEHJPPEEF(2)]
	public float3 NKBDJMLDMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[global::DOHEHJPPEEF(3)]
	public float3 JNFJCIMAIOF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69C4F60", Offset = "0x69C3560", VA = "0x1869C4F60")]
	public GGDNKMJOBID(float KNJOHLDIOOJ, float JEAHIMKCJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69C4F10", Offset = "0x69C3510", VA = "0x1869C4F10", Slot = "4")]
	public void PEGIGFCKLEH(FMNOKOIDCFD JFIDOOOHFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69C4EA0", Offset = "0x69C34A0", VA = "0x1869C4EA0", Slot = "5")]
	public void OJPHNAHFOOE(JDHBHMPEGEO MMDEOFGAFEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[global::GHPKADBNHNB(1, false)]
[DCMOJIBDOMK("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct LOOJMKCMMDI : CIFFJCAGIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[global::DOHEHJPPEEF(1)]
	public float DPPHJOMDNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[global::DOHEHJPPEEF(2)]
	public int MCCHDHJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[global::DOHEHJPPEEF(3)]
	public BOAMIAKHJDA MCGGLIKAALP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DIOGLFLBFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69C5840", Offset = "0x69C3E40", VA = "0x1869C5840")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69C57C0", Offset = "0x69C3DC0", VA = "0x1869C57C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JCDMOJKKCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69C5810", Offset = "0x69C3E10", VA = "0x1869C5810")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69C5820", Offset = "0x69C3E20", VA = "0x1869C5820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool AMEKIELMJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69C5800", Offset = "0x69C3E00", VA = "0x1869C5800")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69C57E0", Offset = "0x69C3DE0", VA = "0x1869C57E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69C5850", Offset = "0x69C3E50", VA = "0x1869C5850", Slot = "5")]
	public void OJPHNAHFOOE(JDHBHMPEGEO MMDEOFGAFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69C58A0", Offset = "0x69C3EA0", VA = "0x1869C58A0", Slot = "4")]
	public void PEGIGFCKLEH(FMNOKOIDCFD JFIDOOOHFIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class PMFJHIOIDJA : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class LDAOGMKCCHJ : Property<RRObjectPrefabData, IDEDIMNMLPE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x69C5790", Offset = "0x69C3D90", VA = "0x1869C5790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69C56A0", Offset = "0x69C3CA0", VA = "0x1869C56A0")]
		public LDAOGMKCCHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x15E3110", Offset = "0x15E1710", VA = "0x1815E3110", Slot = "14")]
		public override IDEDIMNMLPE GetValue(RRObjectPrefabData PCIOPLPELBM)
		{
			return default(IDEDIMNMLPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69C5690", Offset = "0x69C3C90", VA = "0x1869C5690", Slot = "15")]
		public override void SetValue(RRObjectPrefabData PCIOPLPELBM, IDEDIMNMLPE DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69C5A90", Offset = "0x69C4090", VA = "0x1869C5A90")]
	public PMFJHIOIDJA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69C5C10", Offset = "0x69C4210", VA = "0x1869C5C10")]
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
