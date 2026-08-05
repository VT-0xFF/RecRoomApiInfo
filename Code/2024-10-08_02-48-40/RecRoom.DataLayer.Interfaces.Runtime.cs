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
public interface FNCANDADBDA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity PFGDDEFCDEI
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
	[global::DKAHMGPGMFH(1, false)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(11505792609904010668uL, 0u)]
	[GEJDCIACAME("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4526DC0", Offset = "0x4525FC0", VA = "0x184526DC0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F8B0", Offset = "0x6C1EAB0", VA = "0x186C1F8B0")]
		public static RigidTransform CFMDMKLGJEH(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F8B0", Offset = "0x6C1EAB0", VA = "0x186C1F8B0")]
		public static AuthoredLocalPoseData CFMDMKLGJEH(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::FMBKKDMGPPD(9088562008033959482uL, 0u)]
	[global::DKAHMGPGMFH(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[GEJDCIACAME("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[global::FMBKKDMGPPD(10137300772124140051uL, 0u)]
	public struct AuthoredParentData : IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static AuthoredParentData CFMDMKLGJEH(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F8D0", Offset = "0x6C1EAD0", VA = "0x186C1F8D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AAANAJBHEIM : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::PKNFFIINCGN(3)]
		[global::IIJNNBJEGPL(MFELHFJEJBG.EnabledForRole)]
		public MFELHFJEJBG filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(8594223769175916906uL, 0u)]
	[GEJDCIACAME("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[CompilerGenerated]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[global::FMBKKDMGPPD(780699438743496039uL, 0u)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[GEJDCIACAME("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[global::DKAHMGPGMFH(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::DKAHMGPGMFH(2, false)]
	[GEJDCIACAME("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BFMINOAEHDF : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::IIJNNBJEGPL(10)]
		[global::PKNFFIINCGN(1)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[GEJDCIACAME("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[global::DKAHMGPGMFH(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::IIJNNBJEGPL(0)]
		[global::PKNFFIINCGN(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[GEJDCIACAME("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(8536678595025273356uL, 0u)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x21F92F0", Offset = "0x21F84F0", VA = "0x1821F92F0")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x21E8950", Offset = "0x21E7B50", VA = "0x1821E8950")]
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
		[Cpp2IlInjected.Address(RVA = "0xC02B40", Offset = "0xC01D40", VA = "0x180C02B40")]
		internal EntityBundlePartId(uint MHMAFIBKDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD00", Offset = "0x8FAF00", VA = "0x1808FBD00")]
		internal uint MFMJJHJOLOE()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCB9F50", Offset = "0xCB9150", VA = "0x180CB9F50", Slot = "4")]
		public bool Equals(EntityBundlePartId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F950", Offset = "0x6C1EB50", VA = "0x186C1F950", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD62B10", Offset = "0xD61D10", VA = "0x180D62B10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9C20", Offset = "0x1EF8E20", VA = "0x181EF9C20")]
		public static bool IELJJBKMIFI(EntityBundlePartId APIBENHOAOO, EntityBundlePartId EGCFJOLCAMD)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[global::FMBKKDMGPPD(11104975410044731874uL, 0u)]
	[GEJDCIACAME("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[IFJNOEDKKIH("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[global::DKAHMGPGMFH(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[global::IIJNNBJEGPL(NNAIFPKMBJB.IsDynamicEnvironment)]
		[global::PKNFFIINCGN(1)]
		[JENNLNHPNGL(null, 0)]
		public NNAIFPKMBJB collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ILMMEAKKAGI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KMKJNIKKEFN
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
	public enum DEPMFPDOADG
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
	[Cpp2IlInjected.Address(RVA = "0x6C1F9D0", Offset = "0x6C1EBD0", VA = "0x186C1F9D0")]
	public static (KMKJNIKKEFN, DEPMFPDOADG) NBCHLGBBKMF(this NNAIFPKMBJB FKKDMNGBFLM)
	{
		return default((KMKJNIKKEFN, DEPMFPDOADG));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[IFJNOEDKKIH("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[global::FMBKKDMGPPD(2914713536404587710uL, 0u)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::IIJNNBJEGPL(HAIGNMKLKGA.Children)]
		[JENNLNHPNGL(null, 0)]
		[global::PKNFFIINCGN(1)]
		public HAIGNMKLKGA collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[global::DKAHMGPGMFH(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	[GEJDCIACAME("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[IFJNOEDKKIH("Container", 0)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::IIJNNBJEGPL(BOHCGEJKFCB.DEFAULT)]
		[JENNLNHPNGL(null, 0)]
		[global::PKNFFIINCGN(1)]
		public BOHCGEJKFCB flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[IFJNOEDKKIH("Container", 0)]
	[global::FMBKKDMGPPD(1094837642118998916uL, 0u)]
	[GEJDCIACAME("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::IIJNNBJEGPL(0f)]
		[global::PKNFFIINCGN(1)]
		[JENNLNHPNGL(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[global::FMBKKDMGPPD(13657791279235747653uL, 0u)]
	[IFJNOEDKKIH("Container", 0)]
	[GEJDCIACAME("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::DKAHMGPGMFH(1, false)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		[JENNLNHPNGL(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[IFJNOEDKKIH("Container", 0)]
	[CompilerGenerated]
	[GEJDCIACAME("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[JENNLNHPNGL(null, 0)]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public JPFEEFLALHL grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[global::FMBKKDMGPPD(16485879999901987510uL, 0u)]
	[CompilerGenerated]
	[IFJNOEDKKIH("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[JENNLNHPNGL(null, 0)]
		[global::IIJNNBJEGPL(IBCKKHJNHPM.NavMeshGenerator)]
		[global::PKNFFIINCGN(1)]
		public IBCKKHJNHPM mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[global::FMBKKDMGPPD(1537567323754185605uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(5115014870530256079uL, 0u)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[GEJDCIACAME("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[global::DKAHMGPGMFH(1, false)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static InventionIdData CFMDMKLGJEH(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FB60", Offset = "0x6C1ED60", VA = "0x186C1FB60")]
		public readonly bool GJALELMKFIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BB60", Offset = "0x6A4AD60", VA = "0x186A4BB60")]
		public static bool GJALELMKFIP(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[GEJDCIACAME("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[global::KAJMODJBFPL(new int[] { 1 })]
	[CompilerGenerated]
	[global::DKAHMGPGMFH(2, false)]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public static InventionInstanceIdData CFMDMKLGJEH(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[GEJDCIACAME("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::FMBKKDMGPPD(12111354511484844847uL, 0u)]
	[global::DKAHMGPGMFH(1, false)]
	public struct ParentData : IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct AKBENFFNHLG : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[GEJDCIACAME("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public MNILGKBMOLG order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static SiblingSortOrderData CFMDMKLGJEH(MNILGKBMOLG value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FCC0", Offset = "0x6C1EEC0", VA = "0x186C1FCC0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[GEJDCIACAME("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[global::DKAHMGPGMFH(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	[GEJDCIACAME("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(MFELHFJEJBG.Disabled)]
		public MFELHFJEJBG filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[GEJDCIACAME("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(15012400804589552708uL, 0u)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::DKAHMGPGMFH(5, false)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::FMBKKDMGPPD(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[GEJDCIACAME("FB9853D6-6231-43FD-A754-00105DC30880")]
	[IFJNOEDKKIH("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL("new ScaleRestriction(1,1)")]
		public PCJBOHGDIKP scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::IIJNNBJEGPL("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[JENNLNHPNGL(null, 0)]
		[global::PKNFFIINCGN(3)]
		public DEKBOMIPMEK userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::PKNFFIINCGN(4)]
		[JENNLNHPNGL(null, 0)]
		[global::IIJNNBJEGPL(CPJLKIMNAJJ.Default)]
		public CPJLKIMNAJJ circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::IIJNNBJEGPL("ObjectPolicyEnumFlags.Default")]
		[global::PKNFFIINCGN(1)]
		public KANEDDGIKFO flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[global::FMBKKDMGPPD(17708500325183871236uL, 0u)]
	[GEJDCIACAME("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static PlayerScopeData CFMDMKLGJEH(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[IFJNOEDKKIH("Physics", 0)]
	[CompilerGenerated]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[global::FMBKKDMGPPD(16642773407304133105uL, 0u)]
	[GEJDCIACAME("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[JENNLNHPNGL(null, 0)]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[GEJDCIACAME("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(10537432342869025182uL, 0u)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(AKFFOEJDADO.None)]
		public AKFFOEJDADO flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6180730", Offset = "0x617F930", VA = "0x186180730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6180720", Offset = "0x617F920", VA = "0x186180720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C207C0", Offset = "0x6C1F9C0", VA = "0x186C207C0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public HIILINMFPNM shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[GEJDCIACAME("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public MNILGKBMOLG order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static SplinePointOrderData CFMDMKLGJEH(MNILGKBMOLG value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::FMBKKDMGPPD(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::FMBKKDMGPPD(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::IIJNNBJEGPL("new quaternion(0, 0, 0, 1f)")]
		[global::PKNFFIINCGN(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(1238044349990854547uL, 0u)]
	[GEJDCIACAME("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(4657247877648983868uL, 0u)]
	[GEJDCIACAME("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public OGEEGIDJAMP parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[global::FMBKKDMGPPD(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[GEJDCIACAME("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::IIJNNBJEGPL(HIEGLCKLPKH.CURRENT)]
		[global::PKNFFIINCGN(1)]
		public HIEGLCKLPKH version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[global::KAJMODJBFPL(new int[] { 1 })]
	[GEJDCIACAME("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::DKAHMGPGMFH(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::IIJNNBJEGPL(true)]
		[global::PKNFFIINCGN(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::IIJNNBJEGPL(true)]
		[global::PKNFFIINCGN(3)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[global::GCOEAACDLND(1, false)]
[Flags]
[GEJDCIACAME("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[global::GFCIODJNOKM(KJOHGNGMIED.MIN, KJOHGNGMIED.ALL)]
public enum KJOHGNGMIED
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
	[GEJDCIACAME("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[global::DKAHMGPGMFH(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::IIJNNBJEGPL(15f)]
		[global::PKNFFIINCGN(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::IIJNNBJEGPL(KJOHGNGMIED.UseDefaultVisualEffects)]
		[global::PKNFFIINCGN(2)]
		public KJOHGNGMIED toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[global::KAJMODJBFPL(new int[] { 2, 3 })]
	[GEJDCIACAME("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::DKAHMGPGMFH(2, false)]
	[CompilerGenerated]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::PKNFFIINCGN(4)]
		[global::IIJNNBJEGPL]
		public HFDEKCHCFEA statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::GFCIODJNOKM(HFDEKCHCFEA.None, HFDEKCHCFEA.ALL)]
[Flags]
[GEJDCIACAME("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[global::GCOEAACDLND(1, false)]
public enum HFDEKCHCFEA
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
	[global::DKAHMGPGMFH(2, false)]
	[GEJDCIACAME("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::IIJNNBJEGPL("new float3(1)")]
		[global::PKNFFIINCGN(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[GEJDCIACAME("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::FMBKKDMGPPD(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::DKAHMGPGMFH(1, false)]
	[CompilerGenerated]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL("new quaternion(0,0,0,1)")]
		[JENNLNHPNGL(null, 0)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4526DC0", Offset = "0x4525FC0", VA = "0x184526DC0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F8B0", Offset = "0x6C1EAB0", VA = "0x186C1F8B0")]
		public static RigidTransform CFMDMKLGJEH(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F8B0", Offset = "0x6C1EAB0", VA = "0x186C1F8B0")]
		public static LocalPoseData CFMDMKLGJEH(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KBEPJNEFELG
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static RigidTransform JBAIDAIAJCP(this LocalPoseData JECHHBGMFLN)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[GEJDCIACAME("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[GEJDCIACAME("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public BAMPOLDHNBI transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL]
		public BOIGCENJKCI transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[GEJDCIACAME("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::FMBKKDMGPPD(798350452111942523uL, 0u)]
	[global::AGCDIELGBAC]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public INFHPJINHKD prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[global::DKAHMGPGMFH(1, false)]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	[GEJDCIACAME("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public IABBCBEHFAO kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct BKBAIMLJAKL : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static BKBAIMLJAKL OFNBBIHJLBF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F8E0", Offset = "0x6C1EAE0", VA = "0x186C1F8E0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer AKHPALIKFFK, ReferenceGroupReferenceBuffer PGLPHKNNCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x931EC0", Offset = "0x9310C0", VA = "0x180931EC0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer JMJAOKJJFGJ)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[InternalBufferCapacity(0)]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : OGDMFFEGHNL, IBufferElementData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static AuthoredUserTagReferenceBuffer CFMDMKLGJEH(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OGDMFFEGHNL : IBufferElementData, FNCANDADBDA
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[GEJDCIACAME("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[global::DKAHMGPGMFH(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[global::PKNFFIINCGN(2)]
		[global::IIJNNBJEGPL(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(1859693175312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[GEJDCIACAME("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::DKAHMGPGMFH(1, false)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6C207D0", Offset = "0x6C1F9D0", VA = "0x186C207D0")]
		public static UserTagNameData CFMDMKLGJEH(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[global::DKAHMGPGMFH(1, false)]
	[GEJDCIACAME("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[InternalBufferCapacity(0)]
	public struct UserTagReferenceBuffer : OGDMFFEGHNL, IBufferElementData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[global::PKNFFIINCGN(1)]
		[global::IIJNNBJEGPL]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static UserTagReferenceBuffer CFMDMKLGJEH(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CompilerGenerated]
	[IFJNOEDKKIH("Visual", 0)]
	[GEJDCIACAME("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::DKAHMGPGMFH(1, false)]
	[global::FMBKKDMGPPD(1591066774816564574uL, 0u)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[JENNLNHPNGL(null, 0)]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public MEGHEDCALEB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[global::IIJNNBJEGPL]
		[JENNLNHPNGL(null, 0)]
		[global::PKNFFIINCGN(2)]
		public OGCPLLKGEFL material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[JENNLNHPNGL(null, 0)]
		[global::PKNFFIINCGN(3)]
		[global::IIJNNBJEGPL]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(4)]
		[JENNLNHPNGL(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[global::GFCIODJNOKM(CPJLKIMNAJJ.NONE, CPJLKIMNAJJ.COUNT)]
[GEJDCIACAME("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::GCOEAACDLND(1, false)]
public enum CPJLKIMNAJJ
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[JENNLNHPNGL("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[JENNLNHPNGL("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[JENNLNHPNGL("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[global::GFCIODJNOKM(0, 4)]
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum MKKKOEKMBAF
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
[GEJDCIACAME("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::GCOEAACDLND(1, false)]
[Flags]
[global::GFCIODJNOKM(JBFGPIHOMCK.NONE, JBFGPIHOMCK.ALL)]
public enum JBFGPIHOMCK
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
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::GFCIODJNOKM(HAIGNMKLKGA.Off, HAIGNMKLKGA.COUNT)]
public enum HAIGNMKLKGA
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
[GEJDCIACAME("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[JCMLENPGAAM]
[global::GCOEAACDLND(1, false)]
[global::GFCIODJNOKM(HIEGLCKLPKH.VERSION_0, HIEGLCKLPKH.CURRENT)]
public enum HIEGLCKLPKH : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[GEJDCIACAME("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::GCOEAACDLND(1, false)]
[global::GFCIODJNOKM(0, 127)]
public enum NNAIFPKMBJB
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[JENNLNHPNGL("Dynamic (Environment)", 0)]
	[JNHBANAPEPN("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[JENNLNHPNGL("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[JENNLNHPNGL("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[JENNLNHPNGL("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[JENNLNHPNGL("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[JENNLNHPNGL("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[JENNLNHPNGL("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[JENNLNHPNGL("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[JENNLNHPNGL("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[JCMLENPGAAM]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[JCMLENPGAAM]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[GEJDCIACAME("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
[global::GFCIODJNOKM(0, BOHCGEJKFCB.ALL)]
[global::GCOEAACDLND(1, false)]
public enum BOHCGEJKFCB
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
[global::GFCIODJNOKM(0, 2)]
[GEJDCIACAME("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::GCOEAACDLND(1, false)]
public enum HIILINMFPNM
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
[global::GFCIODJNOKM(JPFEEFLALHL.Pivot, JPFEEFLALHL.COUNT)]
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum JPFEEFLALHL
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
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("c0973732-e735-44cd-9727-a9a79bad01e3")]
[global::GFCIODJNOKM(MFELHFJEJBG.EnabledForRole, MFELHFJEJBG.DisabledForRole)]
public enum MFELHFJEJBG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[global::GFCIODJNOKM(IBCKKHJNHPM.NavMeshGenerator, IBCKKHJNHPM.NavMeshBlocker)]
[GEJDCIACAME("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::GCOEAACDLND(1, false)]
public enum IBCKKHJNHPM
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
[GEJDCIACAME("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::GFCIODJNOKM(KANEDDGIKFO.None, KANEDDGIKFO.All)]
[global::GCOEAACDLND(1, false)]
[Flags]
public enum KANEDDGIKFO
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::GFCIODJNOKM(0, NHHAGLLNICH.COUNT)]
public enum NHHAGLLNICH
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
public static class ECDKHICOOMC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F920", Offset = "0x6C1EB20", VA = "0x186C1F920")]
	public static void HPDIHAPBFNP(this KANEDDGIKFO CBEJFPKIGAM, NHHAGLLNICH DNCMIAHJPPL, bool CIBBAIKMIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F900", Offset = "0x6C1EB00", VA = "0x186C1F900")]
	public static bool EKNIDHKKMKI(this KANEDDGIKFO CBEJFPKIGAM, NHHAGLLNICH DNCMIAHJPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x915510", Offset = "0x914710", VA = "0x180915510")]
	public static KANEDDGIKFO GEEALNKGMKE(this NHHAGLLNICH DNCMIAHJPPL)
	{
		return default(KANEDDGIKFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[GEJDCIACAME("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[global::GCOEAACDLND(1, false)]
[Flags]
[global::GFCIODJNOKM(DEKBOMIPMEK.NONE, DEKBOMIPMEK.COUNT)]
public enum DEKBOMIPMEK
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
[global::GFCIODJNOKM(1000, 8000)]
[GEJDCIACAME("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::GCOEAACDLND(1, false)]
public enum INFHPJINHKD
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[JENNLNHPNGL("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[JENNLNHPNGL("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[JENNLNHPNGL("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[JENNLNHPNGL("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[JCMLENPGAAM]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[JENNLNHPNGL("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[JENNLNHPNGL("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[JENNLNHPNGL("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[JENNLNHPNGL("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[JENNLNHPNGL("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[JENNLNHPNGL("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[JENNLNHPNGL("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[JENNLNHPNGL("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[JENNLNHPNGL("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[JENNLNHPNGL("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[JENNLNHPNGL("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[JENNLNHPNGL("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[JENNLNHPNGL("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[JENNLNHPNGL("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[JENNLNHPNGL("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[JENNLNHPNGL("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[JENNLNHPNGL("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[JENNLNHPNGL("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[JENNLNHPNGL("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[JENNLNHPNGL("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[JENNLNHPNGL("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[JENNLNHPNGL("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[JENNLNHPNGL("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[JENNLNHPNGL("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[JENNLNHPNGL("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[JENNLNHPNGL("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[JENNLNHPNGL("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[JENNLNHPNGL("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[JENNLNHPNGL("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[JENNLNHPNGL("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[JENNLNHPNGL("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[JENNLNHPNGL("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[JENNLNHPNGL("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[JENNLNHPNGL("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[JENNLNHPNGL("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[JENNLNHPNGL("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[JENNLNHPNGL("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[JENNLNHPNGL("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[JENNLNHPNGL("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[JENNLNHPNGL("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[JENNLNHPNGL("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[JENNLNHPNGL("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[JENNLNHPNGL("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[JENNLNHPNGL("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[JCMLENPGAAM]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[JENNLNHPNGL("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[JENNLNHPNGL("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[JENNLNHPNGL("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[JENNLNHPNGL("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[JENNLNHPNGL("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[JENNLNHPNGL("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[JENNLNHPNGL("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[JENNLNHPNGL("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[JENNLNHPNGL("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[JENNLNHPNGL("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[JENNLNHPNGL("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[JENNLNHPNGL("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[JENNLNHPNGL("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[JENNLNHPNGL("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[JENNLNHPNGL("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[JENNLNHPNGL("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[JENNLNHPNGL("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class JEBCNCDOPMM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FB70", Offset = "0x6C1ED70", VA = "0x186C1FB70")]
	public static KOMCAFKHHOH CIFPPHLLCGA(this INFHPJINHKD GFOIKJGPAHB)
	{
		return default(KOMCAFKHHOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::GFCIODJNOKM(0, 9)]
public enum KOMCAFKHHOH
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
public static class AANEIPIAIOL
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F770", Offset = "0x6C1E970", VA = "0x186C1F770")]
	public static bool MBGBLKNFMGF(this KOMCAFKHHOH EAPHLKNKMNE)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	[global::FMBKKDMGPPD(8060729269509364919uL, 0u)]
	[GEJDCIACAME("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[global::DKAHMGPGMFH(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[global::IIJNNBJEGPL]
		[global::PKNFFIINCGN(1)]
		public JKPCMEPKCKH shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[GEJDCIACAME("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::GFCIODJNOKM(-1, 38)]
[global::GCOEAACDLND(1, false)]
public enum JKPCMEPKCKH
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
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[global::GFCIODJNOKM(IABBCBEHFAO.None, IABBCBEHFAO.COUNT)]
public enum IABBCBEHFAO : byte
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
[global::GFCIODJNOKM(0, 7)]
[Flags]
[GEJDCIACAME("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::GCOEAACDLND(1, false)]
public enum AKFFOEJDADO
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
[global::GCOEAACDLND(1, false)]
[global::GFCIODJNOKM(0, 7)]
[Flags]
[GEJDCIACAME("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum GHFKPIDLNLH
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
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::GFCIODJNOKM(0, 1)]
[Flags]
public enum BAMPOLDHNBI
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
[global::GFCIODJNOKM(-2, 2)]
[global::GCOEAACDLND(1, false)]
[GEJDCIACAME("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum BOIGCENJKCI
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
[global::GCOEAACDLND(1, false)]
[global::GFCIODJNOKM(int.MinValue, int.MaxValue)]
[GEJDCIACAME("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum MEGHEDCALEB
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
[global::GCOEAACDLND(1, false)]
[global::GFCIODJNOKM(-1, 31)]
[GEJDCIACAME("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum OGCPLLKGEFL
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
[GEJDCIACAME("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[global::MFBJIPBFGLG(1, false)]
public struct MNILGKBMOLG : IComparable<MNILGKBMOLG>, IEquatable<MNILGKBMOLG>, GGNBHIFAHKH
{
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static readonly MNILGKBMOLG NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[global::PKNFFIINCGN(1)]
	public uint BPCKOLOEGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[global::PKNFFIINCGN(2)]
	public uint LKKAOBNKLPM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint GDJFPBLGGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FE80", Offset = "0x6C1F080", VA = "0x186C1FE80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C20070", Offset = "0x6C1F270", VA = "0x186C20070")]
	public MNILGKBMOLG(int BPCKOLOEGGF, int BKJEAPNFPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C20070", Offset = "0x6C1F270", VA = "0x186C20070")]
	public MNILGKBMOLG(uint BPCKOLOEGGF, uint BKJEAPNFPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FE90", Offset = "0x6C1F090", VA = "0x186C1FE90")]
	public MNILGKBMOLG JHHANJDIJFE(int ECDKJELMFBH = 1)
	{
		return default(MNILGKBMOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FC30", Offset = "0x6C1EE30", VA = "0x186C1FC30")]
	public MNILGKBMOLG DPKNFFEIFCJ(int ECDKJELMFBH = 1)
	{
		return default(MNILGKBMOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FB90", Offset = "0x6C1ED90", VA = "0x186C1FB90")]
	public static MNILGKBMOLG AAODPMPCFHK(MNILGKBMOLG PCICJLNHPMM, MNILGKBMOLG OIJJJJFPNNN)
	{
		return default(MNILGKBMOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FE50", Offset = "0x6C1F050", VA = "0x186C1FE50")]
	private static uint HNFGIILLFCL(uint APIBENHOAOO, uint EGCFJOLCAMD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FC10", Offset = "0x6C1EE10", VA = "0x186C1FC10", Slot = "4")]
	public int CompareTo(MNILGKBMOLG KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FCE0", Offset = "0x6C1EEE0", VA = "0x186C1FCE0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FF90", Offset = "0x6C1F190", VA = "0x186C1FF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FCC0", Offset = "0x6C1EEC0", VA = "0x186C1FCC0", Slot = "5")]
	public bool Equals(MNILGKBMOLG KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FE00", Offset = "0x6C1F000", VA = "0x186C1FE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FF20", Offset = "0x6C1F120", VA = "0x186C1FF20", Slot = "6")]
	public void LMOHAAKIFFE(GJOHMKHNIHI MIOAACOLOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FD90", Offset = "0x6C1EF90", VA = "0x186C1FD90", Slot = "7")]
	public void GBKBNNNFJGC(CHLBHFMECIO IDGMLEGKFGC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E7E480", Offset = "0x2E7D680", VA = "0x182E7E480")]
	public static bool IELJJBKMIFI(MNILGKBMOLG PCICJLNHPMM, MNILGKBMOLG OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FD70", Offset = "0x6C1EF70", VA = "0x186C1FD70")]
	public static bool FNBDEMDKLNM(MNILGKBMOLG PCICJLNHPMM, MNILGKBMOLG OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FF00", Offset = "0x6C1F100", VA = "0x186C1FF00")]
	public static bool LGLJHFLGELM(MNILGKBMOLG PCICJLNHPMM, MNILGKBMOLG OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FCA0", Offset = "0x6C1EEA0", VA = "0x186C1FCA0")]
	public static bool EIIKGDIAKLJ(MNILGKBMOLG PCICJLNHPMM, MNILGKBMOLG OIJJJJFPNNN)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[GEJDCIACAME("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::MFBJIPBFGLG(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, GGNBHIFAHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[global::PKNFFIINCGN(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public static NetworkGuid CFMDMKLGJEH(Guid KGBBBBHDKAF)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C20240", Offset = "0x6C1F440", VA = "0x186C20240", Slot = "4")]
		public bool Equals(NetworkGuid KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
		public int CompareTo(NetworkGuid KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C202E0", Offset = "0x6C1F4E0", VA = "0x186C202E0", Slot = "6")]
		public void LMOHAAKIFFE(GJOHMKHNIHI MIOAACOLOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C20270", Offset = "0x6C1F470", VA = "0x186C20270", Slot = "7")]
		public void GBKBNNNFJGC(CHLBHFMECIO IDGMLEGKFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C203A0", Offset = "0x6C1F5A0", VA = "0x186C203A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[global::MFBJIPBFGLG(1, false)]
[GEJDCIACAME("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct PCJBOHGDIKP : GGNBHIFAHKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[global::PKNFFIINCGN(1)]
	public bool DFFHKLMFIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[global::PKNFFIINCGN(2)]
	public float3 IGADCDCKNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[global::PKNFFIINCGN(3)]
	public float3 OGOIOPLPPLP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C205C0", Offset = "0x6C1F7C0", VA = "0x186C205C0")]
	public PCJBOHGDIKP(float LGOHHHLPLHB, float KBKIMKNFKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C20570", Offset = "0x6C1F770", VA = "0x186C20570", Slot = "4")]
	public void LMOHAAKIFFE(GJOHMKHNIHI MIOAACOLOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C20500", Offset = "0x6C1F700", VA = "0x186C20500", Slot = "5")]
	public void GBKBNNNFJGC(CHLBHFMECIO IDGMLEGKFGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[GEJDCIACAME("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::MFBJIPBFGLG(1, false)]
public struct OGEEGIDJAMP : GGNBHIFAHKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[global::PKNFFIINCGN(1)]
	public float IJAHLCIFCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[global::PKNFFIINCGN(2)]
	public int DFFKPOLBPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[global::PKNFFIINCGN(3)]
	public GHFKPIDLNLH CBEJFPKIGAM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AEMHOFPAINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C20470", Offset = "0x6C1F670", VA = "0x186C20470")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C204E0", Offset = "0x6C1F6E0", VA = "0x186C204E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LIMPIIKFPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C20460", Offset = "0x6C1F660", VA = "0x186C20460")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C20440", Offset = "0x6C1F640", VA = "0x186C20440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool IACJOKJOJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C20430", Offset = "0x6C1F630", VA = "0x186C20430")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C203C0", Offset = "0x6C1F5C0", VA = "0x186C203C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C203E0", Offset = "0x6C1F5E0", VA = "0x186C203E0", Slot = "5")]
	public void GBKBNNNFJGC(CHLBHFMECIO IDGMLEGKFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C20480", Offset = "0x6C1F680", VA = "0x186C20480", Slot = "4")]
	public void LMOHAAKIFFE(GJOHMKHNIHI MIOAACOLOAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class NPEPIDDLIMI : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class AGHJACEDBCH : Property<RRObjectPrefabData, INFHPJINHKD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6C1F880", Offset = "0x6C1EA80", VA = "0x186C1F880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F790", Offset = "0x6C1E990", VA = "0x186C1F790")]
		public AGHJACEDBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1A4E1B0", Offset = "0x1A4D3B0", VA = "0x181A4E1B0", Slot = "14")]
		public override INFHPJINHKD GetValue(RRObjectPrefabData DDIEINIMBGH)
		{
			return default(INFHPJINHKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F780", Offset = "0x6C1E980", VA = "0x186C1F780", Slot = "15")]
		public override void SetValue(RRObjectPrefabData DDIEINIMBGH, INFHPJINHKD JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C200C0", Offset = "0x6C1F2C0", VA = "0x186C200C0")]
	public NPEPIDDLIMI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C205F0", Offset = "0x6C1F7F0", VA = "0x186C205F0")]
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
