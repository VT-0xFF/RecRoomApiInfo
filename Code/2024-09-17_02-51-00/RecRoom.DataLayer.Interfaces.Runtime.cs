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
public interface LOPBHHIOKCK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity DDOLMNPEMCH
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
	[global::MCNBEBMJGPM(1, false)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(11505792609904010668uL, 0u)]
	[EKNFNGANPKN("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x44B42B0", Offset = "0x44B2CB0", VA = "0x1844B42B0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C12930", Offset = "0x6C11330", VA = "0x186C12930")]
		public static RigidTransform BIEOCAPMHCM(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C12930", Offset = "0x6C11330", VA = "0x186C12930")]
		public static AuthoredLocalPoseData BIEOCAPMHCM(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::LLBIAJNLOOI(9088562008033959482uL, 0u)]
	[global::MCNBEBMJGPM(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[EKNFNGANPKN("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[global::LLBIAJNLOOI(10137300772124140051uL, 0u)]
	public struct AuthoredParentData : IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static AuthoredParentData BIEOCAPMHCM(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C12950", Offset = "0x6C11350", VA = "0x186C12950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LJCMLOIGBOG : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::MHJDIPDINOC(3)]
		[global::INAFDGOABKN(GGIDIJIGOKD.EnabledForRole)]
		public GGIDIJIGOKD filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(8594223769175916906uL, 0u)]
	[EKNFNGANPKN("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[CompilerGenerated]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[global::LLBIAJNLOOI(780699438743496039uL, 0u)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[EKNFNGANPKN("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[global::MCNBEBMJGPM(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::MCNBEBMJGPM(2, false)]
	[EKNFNGANPKN("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EHCCJONAMNC : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::INAFDGOABKN(10)]
		[global::MHJDIPDINOC(1)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[EKNFNGANPKN("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[global::MCNBEBMJGPM(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::INAFDGOABKN(0)]
		[global::MHJDIPDINOC(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[EKNFNGANPKN("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(8536678595025273356uL, 0u)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2154C90", Offset = "0x2153690", VA = "0x182154C90")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2143C60", Offset = "0x2142660", VA = "0x182143C60")]
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
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		internal EntityBundlePartId(uint MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		internal uint KLELMINMHEI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC63B20", Offset = "0xC62520", VA = "0x180C63B20", Slot = "4")]
		public bool Equals(EntityBundlePartId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C12CE0", Offset = "0x6C116E0", VA = "0x186C12CE0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD04700", Offset = "0xD03100", VA = "0x180D04700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B2D0", Offset = "0x1E09CD0", VA = "0x181E0B2D0")]
		public static bool MNAFCOICNLK(EntityBundlePartId MOKDKAEJAPP, EntityBundlePartId MKGNFMMEFHC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[global::LLBIAJNLOOI(11104975410044731874uL, 0u)]
	[EKNFNGANPKN("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[BACGBJLFNIE("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[global::MCNBEBMJGPM(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[global::INAFDGOABKN(PONFOPLGMFJ.IsDynamicEnvironment)]
		[global::MHJDIPDINOC(1)]
		[JFMCCMEMCEM(null, 0)]
		public PONFOPLGMFJ collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EAFKGMLBMEC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KDNFHLMPNDB
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
	public enum OILNCONAMHJ
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
	[Cpp2IlInjected.Address(RVA = "0x6C12B70", Offset = "0x6C11570", VA = "0x186C12B70")]
	public static (KDNFHLMPNDB, OILNCONAMHJ) FLGCNMNCPJB(this PONFOPLGMFJ CEEMGDGDBHO)
	{
		return default((KDNFHLMPNDB, OILNCONAMHJ));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[BACGBJLFNIE("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[global::LLBIAJNLOOI(2914713536404587710uL, 0u)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::INAFDGOABKN(HODCIKBIDMH.Children)]
		[JFMCCMEMCEM(null, 0)]
		[global::MHJDIPDINOC(1)]
		public HODCIKBIDMH collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[global::MCNBEBMJGPM(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	[EKNFNGANPKN("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[BACGBJLFNIE("Container", 0)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::INAFDGOABKN(FCJLNBDJJLP.DEFAULT)]
		[JFMCCMEMCEM(null, 0)]
		[global::MHJDIPDINOC(1)]
		public FCJLNBDJJLP flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[BACGBJLFNIE("Container", 0)]
	[global::LLBIAJNLOOI(1094837642118998916uL, 0u)]
	[EKNFNGANPKN("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::INAFDGOABKN(0f)]
		[global::MHJDIPDINOC(1)]
		[JFMCCMEMCEM(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[global::LLBIAJNLOOI(13657791279235747653uL, 0u)]
	[BACGBJLFNIE("Container", 0)]
	[EKNFNGANPKN("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::MCNBEBMJGPM(1, false)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		[JFMCCMEMCEM(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[BACGBJLFNIE("Container", 0)]
	[CompilerGenerated]
	[EKNFNGANPKN("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[JFMCCMEMCEM(null, 0)]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public EGCFPDPCIDC grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[global::LLBIAJNLOOI(16485879999901987510uL, 0u)]
	[CompilerGenerated]
	[BACGBJLFNIE("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[JFMCCMEMCEM(null, 0)]
		[global::INAFDGOABKN(LEFIGEGKALF.NavMeshGenerator)]
		[global::MHJDIPDINOC(1)]
		public LEFIGEGKALF mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[global::LLBIAJNLOOI(1537567323754185605uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(5115014870530256079uL, 0u)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[EKNFNGANPKN("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[global::MCNBEBMJGPM(1, false)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static InventionIdData BIEOCAPMHCM(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C12EA0", Offset = "0x6C118A0", VA = "0x186C12EA0")]
		public readonly bool CGOKNCIOKEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A32430", Offset = "0x6A30E30", VA = "0x186A32430")]
		public static bool CGOKNCIOKEJ(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[EKNFNGANPKN("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[global::NDPIKPOHBCL(new int[] { 1 })]
	[CompilerGenerated]
	[global::MCNBEBMJGPM(2, false)]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public static InventionInstanceIdData BIEOCAPMHCM(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[EKNFNGANPKN("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::LLBIAJNLOOI(12111354511484844847uL, 0u)]
	[global::MCNBEBMJGPM(1, false)]
	public struct ParentData : IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct ODDJGOELICG : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[EKNFNGANPKN("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public KDGCNJMFLKM order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static SiblingSortOrderData BIEOCAPMHCM(KDGCNJMFLKM value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C13060", Offset = "0x6C11A60", VA = "0x186C13060", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[EKNFNGANPKN("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[global::MCNBEBMJGPM(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	[EKNFNGANPKN("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(GGIDIJIGOKD.Disabled)]
		public GGIDIJIGOKD filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[EKNFNGANPKN("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(15012400804589552708uL, 0u)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::MCNBEBMJGPM(5, false)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::LLBIAJNLOOI(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[EKNFNGANPKN("FB9853D6-6231-43FD-A754-00105DC30880")]
	[BACGBJLFNIE("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN("new ScaleRestriction(1,1)")]
		public AJHILNHHBBL scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::INAFDGOABKN("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[JFMCCMEMCEM(null, 0)]
		[global::MHJDIPDINOC(3)]
		public CMBLEAIFMMK userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::MHJDIPDINOC(4)]
		[JFMCCMEMCEM(null, 0)]
		[global::INAFDGOABKN(EGDJCAPKOMI.Default)]
		public EGDJCAPKOMI circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::INAFDGOABKN("ObjectPolicyEnumFlags.Default")]
		[global::MHJDIPDINOC(1)]
		public OOIAIBKPKAE flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[global::LLBIAJNLOOI(17708500325183871236uL, 0u)]
	[EKNFNGANPKN("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static PlayerScopeData BIEOCAPMHCM(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BACGBJLFNIE("Physics", 0)]
	[CompilerGenerated]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[global::LLBIAJNLOOI(16642773407304133105uL, 0u)]
	[EKNFNGANPKN("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[JFMCCMEMCEM(null, 0)]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[EKNFNGANPKN("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(10537432342869025182uL, 0u)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(PDHKOOFCPLC.None)]
		public PDHKOOFCPLC flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C13880", Offset = "0x6C12280", VA = "0x186C13880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x618A400", Offset = "0x6188E00", VA = "0x18618A400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C13870", Offset = "0x6C12270", VA = "0x186C13870")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public NIBFHCFJAEN shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[EKNFNGANPKN("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public KDGCNJMFLKM order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static SplinePointOrderData BIEOCAPMHCM(KDGCNJMFLKM value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::LLBIAJNLOOI(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::LLBIAJNLOOI(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::INAFDGOABKN("new quaternion(0, 0, 0, 1f)")]
		[global::MHJDIPDINOC(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(1238044349990854547uL, 0u)]
	[EKNFNGANPKN("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(4657247877648983868uL, 0u)]
	[EKNFNGANPKN("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public KONHIMKBMHA parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[global::LLBIAJNLOOI(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[EKNFNGANPKN("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::INAFDGOABKN(DJMMIEIGNBC.CURRENT)]
		[global::MHJDIPDINOC(1)]
		public DJMMIEIGNBC version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[global::NDPIKPOHBCL(new int[] { 1 })]
	[EKNFNGANPKN("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::MCNBEBMJGPM(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::INAFDGOABKN(true)]
		[global::MHJDIPDINOC(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::INAFDGOABKN(true)]
		[global::MHJDIPDINOC(3)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[global::EBPMLMCCJOP(1, false)]
[Flags]
[EKNFNGANPKN("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[global::PMDMGBHMEHL(LJLDEDIPAMJ.MIN, LJLDEDIPAMJ.ALL)]
public enum LJLDEDIPAMJ
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[EKNFNGANPKN("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[global::MCNBEBMJGPM(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::INAFDGOABKN(15f)]
		[global::MHJDIPDINOC(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::INAFDGOABKN(LJLDEDIPAMJ.UseDefaultVisualEffects)]
		[global::MHJDIPDINOC(2)]
		public LJLDEDIPAMJ toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[global::NDPIKPOHBCL(new int[] { 2, 3 })]
	[EKNFNGANPKN("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::MCNBEBMJGPM(2, false)]
	[CompilerGenerated]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::MHJDIPDINOC(4)]
		[global::INAFDGOABKN]
		public LPLPPDHKKLD statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::PMDMGBHMEHL(LPLPPDHKKLD.None, LPLPPDHKKLD.ALL)]
[Flags]
[EKNFNGANPKN("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[global::EBPMLMCCJOP(1, false)]
public enum LPLPPDHKKLD
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
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::MCNBEBMJGPM(2, false)]
	[EKNFNGANPKN("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::INAFDGOABKN("new float3(1)")]
		[global::MHJDIPDINOC(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[EKNFNGANPKN("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::LLBIAJNLOOI(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::MCNBEBMJGPM(1, false)]
	[CompilerGenerated]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN("new quaternion(0,0,0,1)")]
		[JFMCCMEMCEM(null, 0)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x44B42B0", Offset = "0x44B2CB0", VA = "0x1844B42B0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C12930", Offset = "0x6C11330", VA = "0x186C12930")]
		public static RigidTransform BIEOCAPMHCM(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C12930", Offset = "0x6C11330", VA = "0x186C12930")]
		public static LocalPoseData BIEOCAPMHCM(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HOHBGPBPFGI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static RigidTransform LHEBPJJHMHP(this LocalPoseData KLABJGGMBGH)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[EKNFNGANPKN("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[EKNFNGANPKN("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public KLIHJJLKMHI transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN]
		public IMJGIELMPCP transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[EKNFNGANPKN("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::LLBIAJNLOOI(798350452111942523uL, 0u)]
	[global::OIALGOGDODK]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public IPNKFCKAPGB prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[global::MCNBEBMJGPM(1, false)]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	[EKNFNGANPKN("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public AOGBINLEDKL kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct DIHEHOJKPME : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static DIHEHOJKPME CLODJPHKAPB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C129D0", Offset = "0x6C113D0", VA = "0x186C129D0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer NCPIGLMANIM, ReferenceGroupReferenceBuffer DJBPOPBDKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x9B9460", Offset = "0x9B7E60", VA = "0x1809B9460", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer GHMNBJIOGAM)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[InternalBufferCapacity(0)]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : FEMPHBGAEOD, IBufferElementData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static AuthoredUserTagReferenceBuffer BIEOCAPMHCM(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FEMPHBGAEOD : IBufferElementData, LOPBHHIOKCK
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[EKNFNGANPKN("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[global::MCNBEBMJGPM(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[global::MHJDIPDINOC(2)]
		[global::INAFDGOABKN(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(1859693175312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[EKNFNGANPKN("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::MCNBEBMJGPM(1, false)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6C13890", Offset = "0x6C12290", VA = "0x186C13890")]
		public static UserTagNameData BIEOCAPMHCM(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[global::MCNBEBMJGPM(1, false)]
	[EKNFNGANPKN("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[InternalBufferCapacity(0)]
	public struct UserTagReferenceBuffer : FEMPHBGAEOD, IBufferElementData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[global::MHJDIPDINOC(1)]
		[global::INAFDGOABKN]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static UserTagReferenceBuffer BIEOCAPMHCM(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CompilerGenerated]
	[BACGBJLFNIE("Visual", 0)]
	[EKNFNGANPKN("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::MCNBEBMJGPM(1, false)]
	[global::LLBIAJNLOOI(1591066774816564574uL, 0u)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[JFMCCMEMCEM(null, 0)]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public FLBGLDILGCN color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[global::INAFDGOABKN]
		[JFMCCMEMCEM(null, 0)]
		[global::MHJDIPDINOC(2)]
		public MJMNJDHCNPH material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[JFMCCMEMCEM(null, 0)]
		[global::MHJDIPDINOC(3)]
		[global::INAFDGOABKN]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(4)]
		[JFMCCMEMCEM(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[global::PMDMGBHMEHL(EGDJCAPKOMI.NONE, EGDJCAPKOMI.COUNT)]
[EKNFNGANPKN("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::EBPMLMCCJOP(1, false)]
public enum EGDJCAPKOMI
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[JFMCCMEMCEM("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[JFMCCMEMCEM("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[JFMCCMEMCEM("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[global::PMDMGBHMEHL(0, 4)]
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum FLHGEFLCAHC
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
[EKNFNGANPKN("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::EBPMLMCCJOP(1, false)]
[Flags]
[global::PMDMGBHMEHL(PAPBEBKAKJA.NONE, PAPBEBKAKJA.ALL)]
public enum PAPBEBKAKJA
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
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::PMDMGBHMEHL(HODCIKBIDMH.Off, HODCIKBIDMH.COUNT)]
public enum HODCIKBIDMH
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
[EKNFNGANPKN("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[LOFKBLGHGMJ]
[global::EBPMLMCCJOP(1, false)]
[global::PMDMGBHMEHL(DJMMIEIGNBC.VERSION_0, DJMMIEIGNBC.CURRENT)]
public enum DJMMIEIGNBC : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[EKNFNGANPKN("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::EBPMLMCCJOP(1, false)]
[global::PMDMGBHMEHL(0, 127)]
public enum PONFOPLGMFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[JFMCCMEMCEM("Dynamic (Environment)", 0)]
	[PFENKOGGFII("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[JFMCCMEMCEM("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[JFMCCMEMCEM("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[JFMCCMEMCEM("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[JFMCCMEMCEM("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[JFMCCMEMCEM("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[JFMCCMEMCEM("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[JFMCCMEMCEM("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[JFMCCMEMCEM("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[LOFKBLGHGMJ]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[LOFKBLGHGMJ]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[EKNFNGANPKN("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
[global::PMDMGBHMEHL(0, FCJLNBDJJLP.ALL)]
[global::EBPMLMCCJOP(1, false)]
public enum FCJLNBDJJLP
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
[global::PMDMGBHMEHL(0, 2)]
[EKNFNGANPKN("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::EBPMLMCCJOP(1, false)]
public enum NIBFHCFJAEN
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
[global::PMDMGBHMEHL(EGCFPDPCIDC.Pivot, EGCFPDPCIDC.COUNT)]
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum EGCFPDPCIDC
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
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("c0973732-e735-44cd-9727-a9a79bad01e3")]
[global::PMDMGBHMEHL(GGIDIJIGOKD.EnabledForRole, GGIDIJIGOKD.DisabledForRole)]
public enum GGIDIJIGOKD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[global::PMDMGBHMEHL(LEFIGEGKALF.NavMeshGenerator, LEFIGEGKALF.NavMeshBlocker)]
[EKNFNGANPKN("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::EBPMLMCCJOP(1, false)]
public enum LEFIGEGKALF
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
[EKNFNGANPKN("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::PMDMGBHMEHL(OOIAIBKPKAE.None, OOIAIBKPKAE.All)]
[global::EBPMLMCCJOP(1, false)]
[Flags]
public enum OOIAIBKPKAE
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::PMDMGBHMEHL(0, PDPHKHLFKME.COUNT)]
public enum PDPHKHLFKME
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
public static class BONMBFNILAP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C12960", Offset = "0x6C11360", VA = "0x186C12960")]
	public static void ENCKAHEIPGI(this OOIAIBKPKAE OGECPHANGNB, PDPHKHLFKME LJPPDJHFDPP, bool BDGDGHAINAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C12990", Offset = "0x6C11390", VA = "0x186C12990")]
	public static bool PADOCPINEPM(this OOIAIBKPKAE OGECPHANGNB, PDPHKHLFKME LJPPDJHFDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE390", Offset = "0x1FBCD90", VA = "0x181FBE390")]
	public static OOIAIBKPKAE OGCKDHCLFIN(this PDPHKHLFKME LJPPDJHFDPP)
	{
		return default(OOIAIBKPKAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[EKNFNGANPKN("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[global::EBPMLMCCJOP(1, false)]
[Flags]
[global::PMDMGBHMEHL(CMBLEAIFMMK.NONE, CMBLEAIFMMK.COUNT)]
public enum CMBLEAIFMMK
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
[global::PMDMGBHMEHL(1000, 8000)]
[EKNFNGANPKN("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::EBPMLMCCJOP(1, false)]
public enum IPNKFCKAPGB
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[JFMCCMEMCEM("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[JFMCCMEMCEM("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[JFMCCMEMCEM("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[JFMCCMEMCEM("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[LOFKBLGHGMJ]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[JFMCCMEMCEM("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[JFMCCMEMCEM("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[JFMCCMEMCEM("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[JFMCCMEMCEM("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[JFMCCMEMCEM("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[JFMCCMEMCEM("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[JFMCCMEMCEM("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[JFMCCMEMCEM("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[JFMCCMEMCEM("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[JFMCCMEMCEM("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[JFMCCMEMCEM("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[JFMCCMEMCEM("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[JFMCCMEMCEM("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[JFMCCMEMCEM("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[JFMCCMEMCEM("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[JFMCCMEMCEM("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[JFMCCMEMCEM("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[JFMCCMEMCEM("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[JFMCCMEMCEM("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[JFMCCMEMCEM("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[JFMCCMEMCEM("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[JFMCCMEMCEM("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[JFMCCMEMCEM("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[JFMCCMEMCEM("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[JFMCCMEMCEM("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[JFMCCMEMCEM("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[JFMCCMEMCEM("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[JFMCCMEMCEM("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[JFMCCMEMCEM("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[JFMCCMEMCEM("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[JFMCCMEMCEM("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[JFMCCMEMCEM("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[JFMCCMEMCEM("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[JFMCCMEMCEM("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[JFMCCMEMCEM("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[JFMCCMEMCEM("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[JFMCCMEMCEM("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[JFMCCMEMCEM("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[JFMCCMEMCEM("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[JFMCCMEMCEM("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[JFMCCMEMCEM("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[JFMCCMEMCEM("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[JFMCCMEMCEM("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[JFMCCMEMCEM("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[LOFKBLGHGMJ]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[JFMCCMEMCEM("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[JFMCCMEMCEM("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[JFMCCMEMCEM("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[JFMCCMEMCEM("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[JFMCCMEMCEM("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[JFMCCMEMCEM("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[JFMCCMEMCEM("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[JFMCCMEMCEM("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[JFMCCMEMCEM("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[JFMCCMEMCEM("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[JFMCCMEMCEM("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[JFMCCMEMCEM("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[JFMCCMEMCEM("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[JFMCCMEMCEM("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[JFMCCMEMCEM("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[JFMCCMEMCEM("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[JFMCCMEMCEM("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CAPOFFJNCKE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C129B0", Offset = "0x6C113B0", VA = "0x186C129B0")]
	public static EPHIGNKNLLJ BCEOHNCOBJL(this IPNKFCKAPGB IMKFFCANKLC)
	{
		return default(EPHIGNKNLLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::PMDMGBHMEHL(0, 9)]
public enum EPHIGNKNLLJ
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
public static class GKDBHCABAPE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C12E90", Offset = "0x6C11890", VA = "0x186C12E90")]
	public static bool FMPNHEMANMJ(this EPHIGNKNLLJ JCAJLBCHLLM)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	[global::LLBIAJNLOOI(8060729269509364919uL, 0u)]
	[EKNFNGANPKN("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[global::MCNBEBMJGPM(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[global::INAFDGOABKN]
		[global::MHJDIPDINOC(1)]
		public KDHBKKGFEEG shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[EKNFNGANPKN("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::PMDMGBHMEHL(-1, 38)]
[global::EBPMLMCCJOP(1, false)]
public enum KDHBKKGFEEG
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
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[global::PMDMGBHMEHL(AOGBINLEDKL.None, AOGBINLEDKL.COUNT)]
public enum AOGBINLEDKL : byte
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
[global::PMDMGBHMEHL(0, 7)]
[Flags]
[EKNFNGANPKN("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::EBPMLMCCJOP(1, false)]
public enum PDHKOOFCPLC
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
[global::EBPMLMCCJOP(1, false)]
[global::PMDMGBHMEHL(0, 7)]
[Flags]
[EKNFNGANPKN("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum CAIEOMBKHIH
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
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::PMDMGBHMEHL(0, 1)]
[Flags]
public enum KLIHJJLKMHI
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
[global::PMDMGBHMEHL(-2, 2)]
[global::EBPMLMCCJOP(1, false)]
[EKNFNGANPKN("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum IMJGIELMPCP
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
[global::EBPMLMCCJOP(1, false)]
[global::PMDMGBHMEHL(int.MinValue, int.MaxValue)]
[EKNFNGANPKN("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum FLBGLDILGCN
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
[global::EBPMLMCCJOP(1, false)]
[global::PMDMGBHMEHL(-1, 31)]
[EKNFNGANPKN("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum MJMNJDHCNPH
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
[EKNFNGANPKN("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[global::HCIEAPLFNAC(1, false)]
public struct KDGCNJMFLKM : IComparable<KDGCNJMFLKM>, IEquatable<KDGCNJMFLKM>, OENBMLJNAPM
{
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static readonly KDGCNJMFLKM PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[global::MHJDIPDINOC(1)]
	public uint NPENJKKHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[global::MHJDIPDINOC(2)]
	public uint JDFMDHDPPBF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint OFJMIKNJGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C13160", Offset = "0x6C11B60", VA = "0x186C13160")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C13390", Offset = "0x6C11D90", VA = "0x186C13390")]
	public KDGCNJMFLKM(int NPENJKKHAAG, int OJEOLAKDPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C13390", Offset = "0x6C11D90", VA = "0x186C13390")]
	public KDGCNJMFLKM(uint NPENJKKHAAG, uint OJEOLAKDPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C13200", Offset = "0x6C11C00", VA = "0x186C13200")]
	public KDGCNJMFLKM MCMMGDMHCLI(int IEHCONIHMPO = 1)
	{
		return default(KDGCNJMFLKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C13190", Offset = "0x6C11B90", VA = "0x186C13190")]
	public KDGCNJMFLKM LMFLMAJKJNG(int IEHCONIHMPO = 1)
	{
		return default(KDGCNJMFLKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C12F90", Offset = "0x6C11990", VA = "0x186C12F90")]
	public static KDGCNJMFLKM CNGOCECAIIC(KDGCNJMFLKM NFCDCHABNCB, KDGCNJMFLKM BCBMNIEKAKB)
	{
		return default(KDGCNJMFLKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C13030", Offset = "0x6C11A30", VA = "0x186C13030")]
	private static uint DBKLHMHJABN(uint MOKDKAEJAPP, uint MKGNFMMEFHC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C13010", Offset = "0x6C11A10", VA = "0x186C13010", Slot = "4")]
	public int CompareTo(KDGCNJMFLKM PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C13080", Offset = "0x6C11A80", VA = "0x186C13080", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C132B0", Offset = "0x6C11CB0", VA = "0x186C132B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C13060", Offset = "0x6C11A60", VA = "0x186C13060", Slot = "5")]
	public bool Equals(KDGCNJMFLKM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C13110", Offset = "0x6C11B10", VA = "0x186C13110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C12EB0", Offset = "0x6C118B0", VA = "0x186C12EB0", Slot = "6")]
	public void AMCHBAGBIFH(KPLLCEDIIMH NFLODIHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C12F20", Offset = "0x6C11920", VA = "0x186C12F20", Slot = "7")]
	public void CENBFOHJAFB(LCHJAMFDNHI JEAKAGANOAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB280", Offset = "0x2AD9C80", VA = "0x182ADB280")]
	public static bool MNAFCOICNLK(KDGCNJMFLKM NFCDCHABNCB, KDGCNJMFLKM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C13170", Offset = "0x6C11B70", VA = "0x186C13170")]
	public static bool KIKJPCCIIDN(KDGCNJMFLKM NFCDCHABNCB, KDGCNJMFLKM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C13290", Offset = "0x6C11C90", VA = "0x186C13290")]
	public static bool PLONKBNIOOK(KDGCNJMFLKM NFCDCHABNCB, KDGCNJMFLKM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C13270", Offset = "0x6C11C70", VA = "0x186C13270")]
	public static bool MMOHMMCPHOG(KDGCNJMFLKM NFCDCHABNCB, KDGCNJMFLKM BCBMNIEKAKB)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[EKNFNGANPKN("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::HCIEAPLFNAC(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, OENBMLJNAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[global::MHJDIPDINOC(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public static NetworkGuid BIEOCAPMHCM(Guid GDCMEHKEAMI)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C13650", Offset = "0x6C12050", VA = "0x186C13650", Slot = "4")]
		public bool Equals(NetworkGuid PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
		public int CompareTo(NetworkGuid PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C13520", Offset = "0x6C11F20", VA = "0x186C13520", Slot = "6")]
		public void AMCHBAGBIFH(KPLLCEDIIMH NFLODIHODLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C135E0", Offset = "0x6C11FE0", VA = "0x186C135E0", Slot = "7")]
		public void CENBFOHJAFB(LCHJAMFDNHI JEAKAGANOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C13680", Offset = "0x6C12080", VA = "0x186C13680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[global::HCIEAPLFNAC(1, false)]
[EKNFNGANPKN("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct AJHILNHHBBL : OENBMLJNAPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[global::MHJDIPDINOC(1)]
	public bool GCKGFMHINMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[global::MHJDIPDINOC(2)]
	public float3 CMEBLCOBLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[global::MHJDIPDINOC(3)]
	public float3 NECFKJEEFKM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C12900", Offset = "0x6C11300", VA = "0x186C12900")]
	public AJHILNHHBBL(float GDAPDOPOOAD, float EMFANHEMBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C12840", Offset = "0x6C11240", VA = "0x186C12840", Slot = "4")]
	public void AMCHBAGBIFH(KPLLCEDIIMH NFLODIHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C12890", Offset = "0x6C11290", VA = "0x186C12890", Slot = "5")]
	public void CENBFOHJAFB(LCHJAMFDNHI JEAKAGANOAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[EKNFNGANPKN("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::HCIEAPLFNAC(1, false)]
public struct KONHIMKBMHA : OENBMLJNAPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[global::MHJDIPDINOC(1)]
	public float ACKDJLFMALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[global::MHJDIPDINOC(2)]
	public int NBPEKFPKIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[global::MHJDIPDINOC(3)]
	public CAIEOMBKHIH OGECPHANGNB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BLOCIDEICLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C13460", Offset = "0x6C11E60", VA = "0x186C13460")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C13500", Offset = "0x6C11F00", VA = "0x186C13500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JOMBMMLNDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C13470", Offset = "0x6C11E70", VA = "0x186C13470")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C133E0", Offset = "0x6C11DE0", VA = "0x186C133E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool CCAEELGKCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C134F0", Offset = "0x6C11EF0", VA = "0x186C134F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C134D0", Offset = "0x6C11ED0", VA = "0x186C134D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C13480", Offset = "0x6C11E80", VA = "0x186C13480", Slot = "5")]
	public void CENBFOHJAFB(LCHJAMFDNHI JEAKAGANOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C13400", Offset = "0x6C11E00", VA = "0x186C13400", Slot = "4")]
	public void AMCHBAGBIFH(KPLLCEDIIMH NFLODIHODLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class DNBCPNPFPFK : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class FNPAOEEJMIP : Property<RRObjectPrefabData, IPNKFCKAPGB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6C12E60", Offset = "0x6C11860", VA = "0x186C12E60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C12D70", Offset = "0x6C11770", VA = "0x186C12D70")]
		public FNPAOEEJMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x191AF30", Offset = "0x1919930", VA = "0x18191AF30", Slot = "14")]
		public override IPNKFCKAPGB GetValue(RRObjectPrefabData EOPOOELIKIH)
		{
			return default(IPNKFCKAPGB);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C12D60", Offset = "0x6C11760", VA = "0x186C12D60", Slot = "15")]
		public override void SetValue(RRObjectPrefabData EOPOOELIKIH, IPNKFCKAPGB KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C129F0", Offset = "0x6C113F0", VA = "0x186C129F0")]
	public DNBCPNPFPFK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C136A0", Offset = "0x6C120A0", VA = "0x186C136A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[Preserve]
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
