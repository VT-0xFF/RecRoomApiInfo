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
public interface KAGDFHACOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity GMIGJKKMKNG
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
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[global::GJCPACHAEGM(11505792609904010668uL, 0u)]
	[BEDNAPDBBKP("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::MFMEPIAMLKJ(2)]
		[global::HGLFNHIMMOF("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x423A6A0", Offset = "0x42392A0", VA = "0x18423A6A0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x698E9F0", Offset = "0x698D5F0", VA = "0x18698E9F0")]
		public static RigidTransform ANHILFPCAJJ(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x698E9F0", Offset = "0x698D5F0", VA = "0x18698E9F0")]
		public static AuthoredLocalPoseData ANHILFPCAJJ(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::GJCPACHAEGM(9088562008033959482uL, 0u)]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[BEDNAPDBBKP("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[BEDNAPDBBKP("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[global::GJCPACHAEGM(10137300772124140051uL, 0u)]
	public struct AuthoredParentData : IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static AuthoredParentData ANHILFPCAJJ(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x698EA10", Offset = "0x698D610", VA = "0x18698EA10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NNBJLGLHKIJ : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::HGLFNHIMMOF(false)]
		[global::MFMEPIAMLKJ(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::HGLFNHIMMOF(BAFAKCLLDFJ.EnabledForRole)]
		[global::MFMEPIAMLKJ(3)]
		public BAFAKCLLDFJ filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[global::KFHJKLCPNHB(1, false)]
	[global::GJCPACHAEGM(8594223769175916906uL, 0u)]
	[BEDNAPDBBKP("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[CompilerGenerated]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::MFMEPIAMLKJ(2)]
		[global::HGLFNHIMMOF]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[global::GJCPACHAEGM(780699438743496039uL, 0u)]
	[BEDNAPDBBKP("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::HGLFNHIMMOF(true)]
		[global::MFMEPIAMLKJ(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[BEDNAPDBBKP("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[CompilerGenerated]
	[BEDNAPDBBKP("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::KFHJKLCPNHB(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::MFMEPIAMLKJ(2)]
		[global::HGLFNHIMMOF(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ANFBMJFNBGM : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BEDNAPDBBKP("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::HGLFNHIMMOF(10)]
		[global::MFMEPIAMLKJ(1)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[global::KFHJKLCPNHB(2, false)]
	[BEDNAPDBBKP("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BEDNAPDBBKP("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::KFHJKLCPNHB(1, false)]
	[global::GJCPACHAEGM(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::MFMEPIAMLKJ(2)]
		[global::HGLFNHIMMOF]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1FFE370", Offset = "0x1FFCF70", VA = "0x181FFE370")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC02B0", Offset = "0x1FBEEB0", VA = "0x181FC02B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		internal EntityBundlePartId(uint CABAGOHBNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		internal uint MPBACIPPFPN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA07AD0", Offset = "0xA066D0", VA = "0x180A07AD0", Slot = "4")]
		public bool Equals(EntityBundlePartId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x698EA20", Offset = "0x698D620", VA = "0x18698EA20", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAC3770", Offset = "0xAC2370", VA = "0x180AC3770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1A90BD0", Offset = "0x1A8F7D0", VA = "0x181A90BD0")]
		public static bool IGDKJEPDLHP(EntityBundlePartId PFJBMEMCGDE, EntityBundlePartId GCHHKKAJBGE)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ECKOKAHKFCI("Container", 0)]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[BEDNAPDBBKP("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::GJCPACHAEGM(11104975410044731874uL, 0u)]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[global::HGLFNHIMMOF(MPNFGDHDJCH.IsDynamicEnvironment)]
		[global::MFMEPIAMLKJ(1)]
		[ENBABMBOIFI(null, 0)]
		public MPNFGDHDJCH collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GNNNGMPLIOK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KHLOLFINDPI
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
	public enum ACFPJPNGJBC
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
	[Cpp2IlInjected.Address(RVA = "0x698EAD0", Offset = "0x698D6D0", VA = "0x18698EAD0")]
	public static (KHLOLFINDPI, ACFPJPNGJBC) ILIGAKLDKIK(this MPNFGDHDJCH IJAMBPIAAJO)
	{
		return default((KHLOLFINDPI, ACFPJPNGJBC));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[global::GJCPACHAEGM(2914713536404587710uL, 0u)]
	[ECKOKAHKFCI("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ENBABMBOIFI(null, 0)]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(NEOFKOLGLOF.Children)]
		public NEOFKOLGLOF collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[global::KFHJKLCPNHB(2, false)]
	[BEDNAPDBBKP("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[ECKOKAHKFCI("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[ENBABMBOIFI(null, 0)]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(DHKMNICNAEB.DEFAULT)]
		public DHKMNICNAEB flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::GJCPACHAEGM(1094837642118998916uL, 0u)]
	[ECKOKAHKFCI("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::HGLFNHIMMOF(0f)]
		[ENBABMBOIFI(null, 0)]
		[global::MFMEPIAMLKJ(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[ECKOKAHKFCI("Container", 0)]
	[BEDNAPDBBKP("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::GJCPACHAEGM(13657791279235747653uL, 0u)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::HGLFNHIMMOF]
		[ENBABMBOIFI(null, 0)]
		[global::MFMEPIAMLKJ(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[ECKOKAHKFCI("Container", 0)]
	[global::GJCPACHAEGM(5176564412348566398uL, 0u)]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::HGLFNHIMMOF]
		[ENBABMBOIFI(null, 0)]
		[global::MFMEPIAMLKJ(1)]
		public GNDAOAFMAFP grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::GJCPACHAEGM(16485879999901987510uL, 0u)]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[CompilerGenerated]
	[ECKOKAHKFCI("Container", 0)]
	[BEDNAPDBBKP("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(POIKLOCLNGI.NavMeshGenerator)]
		[ENBABMBOIFI(null, 0)]
		public POIKLOCLNGI mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::KFHJKLCPNHB(1, false)]
	[global::GJCPACHAEGM(1537567323754185605uL, 0u)]
	[BEDNAPDBBKP("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[global::GJCPACHAEGM(5115014870530256079uL, 0u)]
	[BEDNAPDBBKP("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[global::GJCPACHAEGM(12111354511484844847uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KEMAKNOEDDC : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[global::GJCPACHAEGM(1950029632769634832uL, 0u)]
	[BEDNAPDBBKP("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public LEBNOFPPBOJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static SiblingSortOrderData ANHILFPCAJJ(LEBNOFPPBOJ value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x698F210", Offset = "0x698DE10", VA = "0x18698F210", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[CompilerGenerated]
	[BEDNAPDBBKP("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[global::KFHJKLCPNHB(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[BEDNAPDBBKP("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(BAFAKCLLDFJ.Disabled)]
		public BAFAKCLLDFJ filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[BEDNAPDBBKP("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[BEDNAPDBBKP("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[global::KFHJKLCPNHB(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[BEDNAPDBBKP("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[global::GJCPACHAEGM(15012400804589552708uL, 0u)]
	[global::KFHJKLCPNHB(1, false)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[BEDNAPDBBKP("FB9853D6-6231-43FD-A754-00105DC30880")]
	[global::GJCPACHAEGM(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::KFHJKLCPNHB(5, false)]
	[ECKOKAHKFCI("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::HGLFNHIMMOF("new ScaleRestriction(1,1)")]
		[global::MFMEPIAMLKJ(2)]
		public HEPKIKMEBPM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ENBABMBOIFI(null, 0)]
		[global::HGLFNHIMMOF("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::MFMEPIAMLKJ(3)]
		public AMDHMCDLIKB userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::HGLFNHIMMOF(PPDPJNIDGAP.Default)]
		[ENBABMBOIFI(null, 0)]
		[global::MFMEPIAMLKJ(4)]
		public PPDPJNIDGAP circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::HGLFNHIMMOF("ObjectPolicyEnumFlags.Default")]
		[global::MFMEPIAMLKJ(1)]
		public CNNEEEHMFHF flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::GJCPACHAEGM(17708500325183871236uL, 0u)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static PlayerScopeData ANHILFPCAJJ(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[global::GJCPACHAEGM(16642773407304133105uL, 0u)]
	[BEDNAPDBBKP("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[ECKOKAHKFCI("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::MFMEPIAMLKJ(1)]
		[ENBABMBOIFI(null, 0)]
		[global::HGLFNHIMMOF(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[BEDNAPDBBKP("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[global::GJCPACHAEGM(10537432342869025182uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF(PDCECJCBAEH.None)]
		public PDCECJCBAEH flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x698F8C0", Offset = "0x698E4C0", VA = "0x18698F8C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5F16B30", Offset = "0x5F15730", VA = "0x185F16B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x698F8B0", Offset = "0x698E4B0", VA = "0x18698F8B0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BEDNAPDBBKP("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::KFHJKLCPNHB(1, false)]
	[global::GJCPACHAEGM(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public DOPHNCBCMMA shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BEDNAPDBBKP("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::GJCPACHAEGM(5298506180484533559uL, 0u)]
	[global::KFHJKLCPNHB(1, false)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public LEBNOFPPBOJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static SplinePointOrderData ANHILFPCAJJ(LEBNOFPPBOJ value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	[global::GJCPACHAEGM(16368389834000856208uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[BEDNAPDBBKP("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::GJCPACHAEGM(18095612727592564636uL, 0u)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[BEDNAPDBBKP("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[BEDNAPDBBKP("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[global::GJCPACHAEGM(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::HGLFNHIMMOF("new quaternion(0, 0, 0, 1f)")]
		[global::MFMEPIAMLKJ(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::GJCPACHAEGM(1238044349990854547uL, 0u)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::GJCPACHAEGM(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public JCHPNDGNLDH parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[BEDNAPDBBKP("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::GJCPACHAEGM(10026670690793008625uL, 0u)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::HGLFNHIMMOF(HJKEOIKCEHK.CURRENT)]
		[global::MFMEPIAMLKJ(1)]
		public HJKEOIKCEHK version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[global::LGKOEKJANOF(new int[] { 1 })]
	[BEDNAPDBBKP("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::KFHJKLCPNHB(2, false)]
	[CompilerGenerated]
	[global::GJCPACHAEGM(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::HGLFNHIMMOF(true)]
		[global::MFMEPIAMLKJ(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::MFMEPIAMLKJ(3)]
		[global::HGLFNHIMMOF(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[global::HBBLIJDFDGH(KOPEKMFMEFE.MIN, KOPEKMFMEFE.ALL)]
[Flags]
public enum KOPEKMFMEFE
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
	[BEDNAPDBBKP("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[global::KFHJKLCPNHB(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::HGLFNHIMMOF(15f)]
		[global::MFMEPIAMLKJ(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::HGLFNHIMMOF(KOPEKMFMEFE.UseDefaultVisualEffects)]
		[global::MFMEPIAMLKJ(2)]
		public KOPEKMFMEFE toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[BEDNAPDBBKP("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::LGKOEKJANOF(new int[] { 2, 3 })]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[global::KFHJKLCPNHB(2, false)]
	[CompilerGenerated]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(4)]
		public ABLKNBJKHON statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BEDNAPDBBKP("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[global::DOMFBPICDOO(1, false)]
[Flags]
[global::HBBLIJDFDGH(ABLKNBJKHON.None, ABLKNBJKHON.ALL)]
public enum ABLKNBJKHON
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
	[BEDNAPDBBKP("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::KFHJKLCPNHB(2, false)]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[BEDNAPDBBKP("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::GJCPACHAEGM(1369925932270831712uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::KFHJKLCPNHB(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[ENBABMBOIFI(null, 0)]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[global::MFMEPIAMLKJ(2)]
		[global::HGLFNHIMMOF]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x423A6A0", Offset = "0x42392A0", VA = "0x18423A6A0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x698E9F0", Offset = "0x698D5F0", VA = "0x18698E9F0")]
		public static RigidTransform ANHILFPCAJJ(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x698E9F0", Offset = "0x698D5F0", VA = "0x18698E9F0")]
		public static LocalPoseData ANHILFPCAJJ(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GBCMMICNOMO
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static RigidTransform PDCDBNHKCPC(this LocalPoseData IIPLJLPCLBC)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::GJCPACHAEGM(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::HGLFNHIMMOF(1f)]
		[global::MFMEPIAMLKJ(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::GJCPACHAEGM(5730545663584378555uL, 0u)]
	[BEDNAPDBBKP("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public PPNGDGMHAEE transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(2)]
		public IPFGDPHLBKO transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[global::GJCPACHAEGM(798350452111942523uL, 0u)]
	[global::LEFNLIOHLHC]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[BEDNAPDBBKP("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public EBKFNFACOLI prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public ENHGDLNCONB kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[BEDNAPDBBKP("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[global::KFHJKLCPNHB(1, false)]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct FLFJKACGHPE : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static FLFJKACGHPE APEJJIEJKNM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x698EAB0", Offset = "0x698D6B0", VA = "0x18698EAB0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer KIGIELEFAKI, ReferenceGroupReferenceBuffer DKINGMIONNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13A98A0", Offset = "0x13A84A0", VA = "0x1813A98A0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer APKAFMDACKK)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[BEDNAPDBBKP("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	public struct AuthoredUserTagReferenceBuffer : ALAHJPKJDBD, IBufferElementData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static AuthoredUserTagReferenceBuffer ANHILFPCAJJ(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface ALAHJPKJDBD : IBufferElementData, KAGDFHACOBP
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[global::KFHJKLCPNHB(2, false)]
	[BEDNAPDBBKP("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[global::MFMEPIAMLKJ(2)]
		[global::HGLFNHIMMOF(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[global::GJCPACHAEGM(1859693175312uL, 0u)]
	[CompilerGenerated]
	[BEDNAPDBBKP("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::KFHJKLCPNHB(1, false)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[global::HGLFNHIMMOF]
		[global::MFMEPIAMLKJ(1)]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x698F8D0", Offset = "0x698E4D0", VA = "0x18698F8D0")]
		public static UserTagNameData ANHILFPCAJJ(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[BEDNAPDBBKP("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	[InternalBufferCapacity(0)]
	public struct UserTagReferenceBuffer : ALAHJPKJDBD, IBufferElementData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static UserTagReferenceBuffer ANHILFPCAJJ(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[global::KFHJKLCPNHB(1, false)]
	[CompilerGenerated]
	[ECKOKAHKFCI("Visual", 0)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::GJCPACHAEGM(1591066774816564574uL, 0u)]
	[BEDNAPDBBKP("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[global::MFMEPIAMLKJ(1)]
		[ENBABMBOIFI(null, 0)]
		[global::HGLFNHIMMOF]
		public DIEJALMDMOK color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[global::MFMEPIAMLKJ(2)]
		[global::HGLFNHIMMOF]
		[ENBABMBOIFI(null, 0)]
		public HHLFHEPFPPA material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[global::MFMEPIAMLKJ(3)]
		[ENBABMBOIFI(null, 0)]
		[global::HGLFNHIMMOF]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::MFMEPIAMLKJ(4)]
		[ENBABMBOIFI(null, 0)]
		[global::HGLFNHIMMOF]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[BEDNAPDBBKP("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::HBBLIJDFDGH(PPDPJNIDGAP.NONE, PPDPJNIDGAP.COUNT)]
[global::DOMFBPICDOO(1, false)]
public enum PPDPJNIDGAP
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ENBABMBOIFI("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ENBABMBOIFI("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ENBABMBOIFI("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BEDNAPDBBKP("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(0, 4)]
public enum NCOHDFBMCIA
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
[global::HBBLIJDFDGH(JBPOGCNDHJN.NONE, JBPOGCNDHJN.ALL)]
[Flags]
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
public enum JBPOGCNDHJN
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
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(NEOFKOLGLOF.Off, NEOFKOLGLOF.COUNT)]
[BEDNAPDBBKP("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum NEOFKOLGLOF
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
[NOKACHKMCNA]
[global::HBBLIJDFDGH(HJKEOIKCEHK.VERSION_0, HJKEOIKCEHK.CURRENT)]
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
public enum HJKEOIKCEHK : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(0, 127)]
[BEDNAPDBBKP("F843A776-E042-43B7-8167-0C7A421062F8")]
public enum MPNFGDHDJCH
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ENBABMBOIFI("Dynamic (Environment)", 0)]
	[JNIKGFPLIDF("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ENBABMBOIFI("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ENBABMBOIFI("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ENBABMBOIFI("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ENBABMBOIFI("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ENBABMBOIFI("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ENBABMBOIFI("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ENBABMBOIFI("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ENBABMBOIFI("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[NOKACHKMCNA]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NOKACHKMCNA]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(0, DHKMNICNAEB.ALL)]
[Flags]
[BEDNAPDBBKP("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum DHKMNICNAEB
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
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::HBBLIJDFDGH(0, 2)]
public enum DOPHNCBCMMA
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
[BEDNAPDBBKP("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::HBBLIJDFDGH(GNDAOAFMAFP.Pivot, GNDAOAFMAFP.COUNT)]
[global::DOMFBPICDOO(1, false)]
public enum GNDAOAFMAFP
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
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(BAFAKCLLDFJ.EnabledForRole, BAFAKCLLDFJ.DisabledForRole)]
[BEDNAPDBBKP("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum BAFAKCLLDFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::HBBLIJDFDGH(POIKLOCLNGI.NavMeshGenerator, POIKLOCLNGI.NavMeshBlocker)]
public enum POIKLOCLNGI
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
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(CNNEEEHMFHF.None, CNNEEEHMFHF.All)]
[Flags]
[BEDNAPDBBKP("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum CNNEEEHMFHF
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[BEDNAPDBBKP("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(0, BJCLPFLGMNG.COUNT)]
public enum BJCLPFLGMNG
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
public static class HJKBFNHJKKO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x698ED50", Offset = "0x698D950", VA = "0x18698ED50")]
	public static void IJGOPKKNHAN(this CNNEEEHMFHF DKIOAOHDADG, BJCLPFLGMNG GJMHHBNOEAN, bool NCJAANPMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x698ED30", Offset = "0x698D930", VA = "0x18698ED30")]
	public static bool BCIGLHBHDKB(this CNNEEEHMFHF DKIOAOHDADG, BJCLPFLGMNG GJMHHBNOEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1C506A0", Offset = "0x1C4F2A0", VA = "0x181C506A0")]
	public static CNNEEEHMFHF FKJILPDBPPE(this BJCLPFLGMNG GJMHHBNOEAN)
	{
		return default(CNNEEEHMFHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::HBBLIJDFDGH(AMDHMCDLIKB.NONE, AMDHMCDLIKB.COUNT)]
[BEDNAPDBBKP("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
[global::DOMFBPICDOO(1, false)]
public enum AMDHMCDLIKB
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
[global::HBBLIJDFDGH(1000, 8000)]
[BEDNAPDBBKP("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::DOMFBPICDOO(1, false)]
public enum EBKFNFACOLI
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ENBABMBOIFI("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ENBABMBOIFI("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[ENBABMBOIFI("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[ENBABMBOIFI("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[NOKACHKMCNA]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[ENBABMBOIFI("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ENBABMBOIFI("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[ENBABMBOIFI("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[ENBABMBOIFI("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ENBABMBOIFI("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[ENBABMBOIFI("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[ENBABMBOIFI("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ENBABMBOIFI("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ENBABMBOIFI("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[ENBABMBOIFI("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ENBABMBOIFI("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ENBABMBOIFI("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ENBABMBOIFI("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ENBABMBOIFI("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[ENBABMBOIFI("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[ENBABMBOIFI("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[ENBABMBOIFI("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[ENBABMBOIFI("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[ENBABMBOIFI("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[ENBABMBOIFI("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[ENBABMBOIFI("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[ENBABMBOIFI("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[ENBABMBOIFI("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[ENBABMBOIFI("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[ENBABMBOIFI("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[ENBABMBOIFI("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[ENBABMBOIFI("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[ENBABMBOIFI("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[ENBABMBOIFI("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[ENBABMBOIFI("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[ENBABMBOIFI("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[ENBABMBOIFI("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[ENBABMBOIFI("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[ENBABMBOIFI("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[ENBABMBOIFI("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[ENBABMBOIFI("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[ENBABMBOIFI("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[ENBABMBOIFI("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[ENBABMBOIFI("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[ENBABMBOIFI("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[ENBABMBOIFI("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[ENBABMBOIFI("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[ENBABMBOIFI("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[ENBABMBOIFI("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[NOKACHKMCNA]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[ENBABMBOIFI("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[ENBABMBOIFI("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[ENBABMBOIFI("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[ENBABMBOIFI("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[ENBABMBOIFI("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[ENBABMBOIFI("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[ENBABMBOIFI("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[ENBABMBOIFI("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[ENBABMBOIFI("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[ENBABMBOIFI("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[ENBABMBOIFI("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[ENBABMBOIFI("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[ENBABMBOIFI("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[ENBABMBOIFI("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[ENBABMBOIFI("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[ENBABMBOIFI("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[ENBABMBOIFI("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class IFCCLPLJBCA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x698ED80", Offset = "0x698D980", VA = "0x18698ED80")]
	public static EBNDBGDLOPE PFICPLFIJME(this EBKFNFACOLI OEBDHGNIACG)
	{
		return default(EBNDBGDLOPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[global::HBBLIJDFDGH(0, 9)]
[BEDNAPDBBKP("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::DOMFBPICDOO(1, false)]
public enum EBNDBGDLOPE
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
public static class LEEJJINMONF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x698F550", Offset = "0x698E150", VA = "0x18698F550")]
	public static bool MCNKGKCLOGL(this EBNDBGDLOPE MHKLNGFJGPA)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::KFHJKLCPNHB(1, false)]
	[BEDNAPDBBKP("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::GJCPACHAEGM(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[global::MFMEPIAMLKJ(1)]
		[global::HGLFNHIMMOF]
		public PPNDJOMCIKD shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[global::HBBLIJDFDGH(-1, 38)]
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum PPNDJOMCIKD
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
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[global::HBBLIJDFDGH(ENHGDLNCONB.None, ENHGDLNCONB.COUNT)]
public enum ENHGDLNCONB : byte
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
[BEDNAPDBBKP("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::DOMFBPICDOO(1, false)]
[Flags]
[global::HBBLIJDFDGH(0, 7)]
public enum PDCECJCBAEH
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
[Flags]
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::HBBLIJDFDGH(0, 7)]
public enum PBJPBLFKFIJ
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
[global::DOMFBPICDOO(1, false)]
[global::HBBLIJDFDGH(0, 1)]
[BEDNAPDBBKP("72742F9B-D48E-4CED-B403-444201FFEE66")]
[Flags]
public enum PPNGDGMHAEE
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
[global::HBBLIJDFDGH(-2, 2)]
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum IPFGDPHLBKO
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
[global::DOMFBPICDOO(1, false)]
[BEDNAPDBBKP("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::HBBLIJDFDGH(int.MinValue, int.MaxValue)]
public enum DIEJALMDMOK
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
[global::HBBLIJDFDGH(-1, 31)]
[BEDNAPDBBKP("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::DOMFBPICDOO(1, false)]
public enum HHLFHEPFPPA
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
[global::LLGBIIMAFKM(1, false)]
[BEDNAPDBBKP("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct LEBNOFPPBOJ : IComparable<LEBNOFPPBOJ>, IEquatable<LEBNOFPPBOJ>, OJJNLGDFJIK
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static readonly LEBNOFPPBOJ ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[global::MFMEPIAMLKJ(1)]
	public uint HNGEJILDCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	[global::MFMEPIAMLKJ(2)]
	public uint BAKAFPHFGNF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint OBNJPODNBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x698F2F0", Offset = "0x698DEF0", VA = "0x18698F2F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x698F500", Offset = "0x698E100", VA = "0x18698F500")]
	public LEBNOFPPBOJ(int HNGEJILDCJF, int IMAMGCBLIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x698F500", Offset = "0x698E100", VA = "0x18698F500")]
	public LEBNOFPPBOJ(uint HNGEJILDCJF, uint IMAMGCBLIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x698F300", Offset = "0x698DF00", VA = "0x18698F300")]
	public LEBNOFPPBOJ JEHFKEHENAD(int JEHLDDEOFLK = 1)
	{
		return default(LEBNOFPPBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x698F370", Offset = "0x698DF70", VA = "0x18698F370")]
	public LEBNOFPPBOJ JJLAOHGMMNM(int JEHLDDEOFLK = 1)
	{
		return default(LEBNOFPPBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x698F0C0", Offset = "0x698DCC0", VA = "0x18698F0C0")]
	public static LEBNOFPPBOJ DCJFIDMLDMG(LEBNOFPPBOJ HDIFBMODGOB, LEBNOFPPBOJ ADFEKOHGOPP)
	{
		return default(LEBNOFPPBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x698F140", Offset = "0x698DD40", VA = "0x18698F140")]
	private static uint EAJCDNJHLMP(uint PFJBMEMCGDE, uint GCHHKKAJBGE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x698F0A0", Offset = "0x698DCA0", VA = "0x18698F0A0", Slot = "4")]
	public int CompareTo(LEBNOFPPBOJ HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x698F170", Offset = "0x698DD70", VA = "0x18698F170", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x698F420", Offset = "0x698E020", VA = "0x18698F420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x698F210", Offset = "0x698DE10", VA = "0x18698F210", Slot = "5")]
	public bool Equals(LEBNOFPPBOJ HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x698F2A0", Offset = "0x698DEA0", VA = "0x18698F2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x698F010", Offset = "0x698DC10", VA = "0x18698F010", Slot = "6")]
	public void CJJBNJOFCID(BDFAIAGABOK PNCAPBLIAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x698F230", Offset = "0x698DE30", VA = "0x18698F230", Slot = "7")]
	public void GCPIDJEBGBI(HJODIKIPGEG KLAPEMMBNLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA14D0", Offset = "0x2BA00D0", VA = "0x182BA14D0")]
	public static bool IGDKJEPDLHP(LEBNOFPPBOJ HDIFBMODGOB, LEBNOFPPBOJ ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x698F400", Offset = "0x698E000", VA = "0x18698F400")]
	public static bool OAODAFKFIOO(LEBNOFPPBOJ HDIFBMODGOB, LEBNOFPPBOJ ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x698F3E0", Offset = "0x698DFE0", VA = "0x18698F3E0")]
	public static bool MAHJMLAIKME(LEBNOFPPBOJ HDIFBMODGOB, LEBNOFPPBOJ ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x698F080", Offset = "0x698DC80", VA = "0x18698F080")]
	public static bool CNOCEGMHIEF(LEBNOFPPBOJ HDIFBMODGOB, LEBNOFPPBOJ ADFEKOHGOPP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BEDNAPDBBKP("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::LLGBIIMAFKM(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, OJJNLGDFJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[global::MFMEPIAMLKJ(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public static NetworkGuid ANHILFPCAJJ(Guid GBCIBJHFOHP)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x698F620", Offset = "0x698E220", VA = "0x18698F620", Slot = "4")]
		public bool Equals(NetworkGuid HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
		public int CompareTo(NetworkGuid HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x698F560", Offset = "0x698E160", VA = "0x18698F560", Slot = "6")]
		public void CJJBNJOFCID(BDFAIAGABOK PNCAPBLIAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x698F650", Offset = "0x698E250", VA = "0x18698F650", Slot = "7")]
		public void GCPIDJEBGBI(HJODIKIPGEG KLAPEMMBNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x698F6C0", Offset = "0x698E2C0", VA = "0x18698F6C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[global::LLGBIIMAFKM(1, false)]
[BEDNAPDBBKP("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct HEPKIKMEBPM : OJJNLGDFJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[global::MFMEPIAMLKJ(1)]
	public bool NODMMGDBLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[global::MFMEPIAMLKJ(2)]
	public float3 BBOHFMDNMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[global::MFMEPIAMLKJ(3)]
	public float3 BJIANPHDJKF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x698ED00", Offset = "0x698D900", VA = "0x18698ED00")]
	public HEPKIKMEBPM(float GMOAOGFMENJ, float BHHOPHAOKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x698EC40", Offset = "0x698D840", VA = "0x18698EC40", Slot = "4")]
	public void CJJBNJOFCID(BDFAIAGABOK PNCAPBLIAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x698EC90", Offset = "0x698D890", VA = "0x18698EC90", Slot = "5")]
	public void GCPIDJEBGBI(HJODIKIPGEG KLAPEMMBNLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[global::LLGBIIMAFKM(1, false)]
[BEDNAPDBBKP("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct JCHPNDGNLDH : OJJNLGDFJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[global::MFMEPIAMLKJ(1)]
	public float HLAAEHCDKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[global::MFMEPIAMLKJ(2)]
	public int ADPIHBBNJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[global::MFMEPIAMLKJ(3)]
	public PBJPBLFKFIJ DKIOAOHDADG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BGHPCHOPOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x698EED0", Offset = "0x698DAD0", VA = "0x18698EED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x698EEB0", Offset = "0x698DAB0", VA = "0x18698EEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JLGJDCIBIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x698EDC0", Offset = "0x698D9C0", VA = "0x18698EDC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x698EE80", Offset = "0x698DA80", VA = "0x18698EE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GHLAIDBIFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x698EEA0", Offset = "0x698DAA0", VA = "0x18698EEA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x698EDA0", Offset = "0x698D9A0", VA = "0x18698EDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x698EE30", Offset = "0x698DA30", VA = "0x18698EE30", Slot = "5")]
	public void GCPIDJEBGBI(HJODIKIPGEG KLAPEMMBNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x698EDD0", Offset = "0x698D9D0", VA = "0x18698EDD0", Slot = "4")]
	public void CJJBNJOFCID(BDFAIAGABOK PNCAPBLIAKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class ALIANALCEOJ : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class LAHDOBIBIAJ : Property<RRObjectPrefabData, EBKFNFACOLI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x698EFE0", Offset = "0x698DBE0", VA = "0x18698EFE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x698EEF0", Offset = "0x698DAF0", VA = "0x18698EEF0")]
		public LAHDOBIBIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x15B07A0", Offset = "0x15AF3A0", VA = "0x1815B07A0", Slot = "14")]
		public override EBKFNFACOLI GetValue(RRObjectPrefabData MLGAMJFBMDB)
		{
			return default(EBKFNFACOLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x698EEE0", Offset = "0x698DAE0", VA = "0x18698EEE0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MLGAMJFBMDB, EBKFNFACOLI IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x698E870", Offset = "0x698D470", VA = "0x18698E870")]
	public ALIANALCEOJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x698F6E0", Offset = "0x698E2E0", VA = "0x18698F6E0")]
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
