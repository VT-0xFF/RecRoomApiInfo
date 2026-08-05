using System;
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
public interface FDKAFJDCLGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity MBMFDLMGMIP
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
	[global::OODKHDADANM(1, false)]
	[CompilerGenerated]
	[global::NLAGJNKENCL(11505792609904010668uL, 0u)]
	[IPJNLPLHFHD("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::EKIAFNEHNLO("new float3(float.NaN)")]
		[global::JEJFDDMFHFN(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3D42F80", Offset = "0x3D42180", VA = "0x183D42F80")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60F5660", Offset = "0x60F4860", VA = "0x1860F5660")]
		public static AuthoredLocalPoseData GEOGJCANPGE(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[CompilerGenerated]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[global::NLAGJNKENCL(9088562008033959482uL, 0u)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::EKIAFNEHNLO(1f)]
		[global::JEJFDDMFHFN(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::NLAGJNKENCL(10137300772124140051uL, 0u)]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	public struct AuthoredParentData : IComponentData, FDKAFJDCLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static AuthoredParentData GEOGJCANPGE(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60F5680", Offset = "0x60F4880", VA = "0x1860F5680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MCPADBMCODG : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::JEJFDDMFHFN(2)]
		[global::EKIAFNEHNLO(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::JEJFDDMFHFN(3)]
		[global::EKIAFNEHNLO(OIGBGKEBEFC.EnabledForRole)]
		public OIGBGKEBEFC filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[global::OODKHDADANM(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[global::NLAGJNKENCL(8594223769175916906uL, 0u)]
	[IPJNLPLHFHD("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::JEJFDDMFHFN(2)]
		[global::EKIAFNEHNLO]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::NLAGJNKENCL(780699438743496039uL, 0u)]
	[global::OODKHDADANM(1, false)]
	[CompilerGenerated]
	[IPJNLPLHFHD("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::EKIAFNEHNLO(true)]
		[global::JEJFDDMFHFN(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[global::OODKHDADANM(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[IPJNLPLHFHD("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[IPJNLPLHFHD("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::NLAGJNKENCL(11853296779717712500uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[global::OODKHDADANM(1, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	[IPJNLPLHFHD("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::OODKHDADANM(1, false)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::NLAGJNKENCL(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4CD40", Offset = "0x1E4BF40", VA = "0x181E4CD40")]
		public EntityBundlePartData(Entity prefabRoot, EntityBundlePartId partId)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		internal EntityBundlePartId(uint POAELFIOKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0")]
		internal uint MLNPJFLCGJK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88E910", Offset = "0x88DB10", VA = "0x18088E910", Slot = "4")]
		public bool Equals(EntityBundlePartId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60F5BC0", Offset = "0x60F4DC0", VA = "0x1860F5BC0", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x93E030", Offset = "0x93D230", VA = "0x18093E030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x18A5D90", Offset = "0x18A4F90", VA = "0x1818A5D90")]
		public static bool FPIEKNKMEBM(EntityBundlePartId LLLCBODKBAN, EntityBundlePartId HIOEJKGFIKI)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[global::NLAGJNKENCL(11104975410044731874uL, 0u)]
	[HHBNCGPLOCB("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(JLICOMJJGPO.IsDynamicEnvironment)]
		[NLCKALFEDOB(null, 0)]
		public JLICOMJJGPO collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FOJIGJDKJCF
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum EMMKIABEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PENKDOLJONA
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60F5C40", Offset = "0x60F4E40", VA = "0x1860F5C40")]
	public static (EMMKIABEDJH, PENKDOLJONA) BOADPMFLGHA(this JLICOMJJGPO OCLMGFCPPDD)
	{
		return default((EMMKIABEDJH, PENKDOLJONA));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::NLAGJNKENCL(2914713536404587710uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[global::OODKHDADANM(1, false)]
	[CompilerGenerated]
	[HHBNCGPLOCB("Container", 0)]
	[IPJNLPLHFHD("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(NMFMEBNCGMB.Children)]
		[NLCKALFEDOB(null, 0)]
		public NMFMEBNCGMB collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[IPJNLPLHFHD("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[HHBNCGPLOCB("Container", 0)]
	[global::OODKHDADANM(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::EKIAFNEHNLO(BPEECEOEIPM.DEFAULT)]
		[global::JEJFDDMFHFN(1)]
		[NLCKALFEDOB(null, 0)]
		public BPEECEOEIPM flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::NLAGJNKENCL(1094837642118998916uL, 0u)]
	[HHBNCGPLOCB("Container", 0)]
	[IPJNLPLHFHD("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::OODKHDADANM(1, false)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[NLCKALFEDOB(null, 0)]
		[global::EKIAFNEHNLO(0f)]
		[global::JEJFDDMFHFN(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[HHBNCGPLOCB("Container", 0)]
	[global::NLAGJNKENCL(13657791279235747653uL, 0u)]
	[IPJNLPLHFHD("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::OODKHDADANM(1, false)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[NLCKALFEDOB(null, 0)]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::OODKHDADANM(1, false)]
	[CompilerGenerated]
	[IPJNLPLHFHD("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[HHBNCGPLOCB("Container", 0)]
	[global::NLAGJNKENCL(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		[NLCKALFEDOB(null, 0)]
		public KJOJBBBAKAP grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[global::NLAGJNKENCL(16485879999901987510uL, 0u)]
	[IPJNLPLHFHD("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::OODKHDADANM(1, false)]
	[HHBNCGPLOCB("Container", 0)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(CCEAMCMKGBM.NavMeshGenerator)]
		[NLCKALFEDOB(null, 0)]
		public CCEAMCMKGBM mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[IPJNLPLHFHD("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::OODKHDADANM(1, false)]
	[global::NLAGJNKENCL(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[global::OODKHDADANM(1, false)]
	[global::NLAGJNKENCL(5115014870530256079uL, 0u)]
	[IPJNLPLHFHD("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[global::NLAGJNKENCL(14429493078606832166uL, 0u)]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[IPJNLPLHFHD("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	[global::OODKHDADANM(1, false)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::NLAGJNKENCL(12111354511484844847uL, 0u)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	public struct ParentData : IComponentData, FDKAFJDCLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, FDKAFJDCLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MIEMDFKNIML : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[global::NLAGJNKENCL(1950029632769634832uL, 0u)]
	[IPJNLPLHFHD("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::OODKHDADANM(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public DHOGHBGBODA order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static SiblingSortOrderData GEOGJCANPGE(DHOGHBGBODA value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60F57A0", Offset = "0x60F49A0", VA = "0x1860F57A0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[IPJNLPLHFHD("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::OODKHDADANM(1, false)]
	[global::NLAGJNKENCL(15012400804589552708uL, 0u)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::OODKHDADANM(5, false)]
	[global::NLAGJNKENCL(16541670854338945984uL, 0u)]
	[HHBNCGPLOCB("Object", 0)]
	[CompilerGenerated]
	[IPJNLPLHFHD("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::EKIAFNEHNLO("new ScaleRestriction(1,1)")]
		[global::JEJFDDMFHFN(2)]
		public OPHOACBKMHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::EKIAFNEHNLO("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::JEJFDDMFHFN(3)]
		[NLCKALFEDOB(null, 0)]
		public OBPHPMOBDFL userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::JEJFDDMFHFN(4)]
		[NLCKALFEDOB(null, 0)]
		[global::EKIAFNEHNLO(OLHAMEMJPND.Default)]
		public OLHAMEMJPND circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::EKIAFNEHNLO("ObjectPolicyEnumFlags.Default")]
		[global::JEJFDDMFHFN(1)]
		public INIFBINLFIE flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	[global::NLAGJNKENCL(17708500325183871236uL, 0u)]
	[IPJNLPLHFHD("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::OODKHDADANM(1, false)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static PlayerScopeData GEOGJCANPGE(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::NLAGJNKENCL(16642773407304133105uL, 0u)]
	[HHBNCGPLOCB("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[NLCKALFEDOB(null, 0)]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[CompilerGenerated]
	[global::NLAGJNKENCL(10537432342869025182uL, 0u)]
	[IPJNLPLHFHD("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[global::OODKHDADANM(1, false)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(GFPBOGIPHND.None)]
		public GFPBOGIPHND flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60F6680", Offset = "0x60F5880", VA = "0x1860F6680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x60F6670", Offset = "0x60F5870", VA = "0x1860F6670")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::NLAGJNKENCL(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::OODKHDADANM(1, false)]
	[CompilerGenerated]
	[IPJNLPLHFHD("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public AOPPGPEDKLO shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::NLAGJNKENCL(5298506180484533559uL, 0u)]
	[global::OODKHDADANM(1, false)]
	[CompilerGenerated]
	[IPJNLPLHFHD("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public DHOGHBGBODA order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static SplinePointOrderData GEOGJCANPGE(DHOGHBGBODA value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::NLAGJNKENCL(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::NLAGJNKENCL(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::NLAGJNKENCL(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[IPJNLPLHFHD("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::OODKHDADANM(1, false)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::EKIAFNEHNLO("new quaternion(0, 0, 0, 1f)")]
		[global::JEJFDDMFHFN(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::NLAGJNKENCL(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[IPJNLPLHFHD("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::OODKHDADANM(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[global::NLAGJNKENCL(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public JLLBINFBBDN parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::OODKHDADANM(1, false)]
	[IPJNLPLHFHD("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[global::NLAGJNKENCL(10026670690793008625uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(JLKOOCLJAGB.CURRENT)]
		public JLKOOCLJAGB version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[global::NLAGJNKENCL(12332323170023439017uL, 0u)]
	[CompilerGenerated]
	[global::OODKHDADANM(2, false)]
	[global::CFHAEPFDIKI(new int[] { 1 })]
	[IPJNLPLHFHD("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::JEJFDDMFHFN(2)]
		[global::EKIAFNEHNLO(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::JEJFDDMFHFN(3)]
		[global::EKIAFNEHNLO(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[IPJNLPLHFHD("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[global::FPEHEOPEMNL(MGJBAFEDDNK.MIN, MGJBAFEDDNK.ALL)]
[global::KNAGPGBHGNH(1, false)]
public enum MGJBAFEDDNK
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[IPJNLPLHFHD("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[global::OODKHDADANM(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::EKIAFNEHNLO(MGJBAFEDDNK.UseDefaultVisualEffects)]
		[global::JEJFDDMFHFN(2)]
		public MGJBAFEDDNK toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	[global::OODKHDADANM(1, false)]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[IPJNLPLHFHD("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[global::JEJFDDMFHFN(3)]
		[global::EKIAFNEHNLO]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::OODKHDADANM(2, false)]
	[IPJNLPLHFHD("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[global::EKIAFNEHNLO("new float3(1)")]
		[global::JEJFDDMFHFN(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[IPJNLPLHFHD("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::OODKHDADANM(1, false)]
	[global::NLAGJNKENCL(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[global::JEJFDDMFHFN(1)]
		[NLCKALFEDOB(null, 0)]
		[global::EKIAFNEHNLO("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[global::JEJFDDMFHFN(2)]
		[global::EKIAFNEHNLO]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D42F80", Offset = "0x3D42180", VA = "0x183D42F80")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60F5660", Offset = "0x60F4860", VA = "0x1860F5660")]
		public static RigidTransform GEOGJCANPGE(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60F5660", Offset = "0x60F4860", VA = "0x1860F5660")]
		public static LocalPoseData GEOGJCANPGE(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DHICKGJEAAG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static RigidTransform DGAHHLOCAMI(this LocalPoseData EKDDCPALANJ)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[global::NLAGJNKENCL(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[IPJNLPLHFHD("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::OODKHDADANM(1, false)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::EKIAFNEHNLO(1f)]
		[global::JEJFDDMFHFN(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::NLAGJNKENCL(5730545663584378555uL, 0u)]
	[IPJNLPLHFHD("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::OODKHDADANM(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		public CCMNNACNPHP transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::JEJFDDMFHFN(2)]
		[global::EKIAFNEHNLO]
		public OFPPBMBMNOL transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[global::OODKHDADANM(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CompilerGenerated]
	[global::NLAGJNKENCL(798350452111942523uL, 0u)]
	[global::EMDIIHNBDPG]
	[IPJNLPLHFHD("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public AIMLLPOCAAB prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[global::OODKHDADANM(2, false)]
	[IPJNLPLHFHD("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::EKIAFNEHNLO(false)]
		[global::JEJFDDMFHFN(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[IPJNLPLHFHD("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::OODKHDADANM(1, false)]
	[global::NLAGJNKENCL(1591066774816564574uL, 0u)]
	[CompilerGenerated]
	[HHBNCGPLOCB("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::JEJFDDMFHFN(1)]
		[global::EKIAFNEHNLO]
		[NLCKALFEDOB(null, 0)]
		public DKFFJGDMCCB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[global::JEJFDDMFHFN(2)]
		[global::EKIAFNEHNLO]
		[NLCKALFEDOB(null, 0)]
		public JFLGFGJFHHM material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[global::JEJFDDMFHFN(3)]
		[NLCKALFEDOB(null, 0)]
		[global::EKIAFNEHNLO]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[global::EKIAFNEHNLO]
		[NLCKALFEDOB(null, 0)]
		[global::JEJFDDMFHFN(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[global::FPEHEOPEMNL(OLHAMEMJPND.NONE, OLHAMEMJPND.COUNT)]
[IPJNLPLHFHD("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::KNAGPGBHGNH(1, false)]
public enum OLHAMEMJPND
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NLCKALFEDOB("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NLCKALFEDOB("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NLCKALFEDOB("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(0, 4)]
[IPJNLPLHFHD("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum FKPIJBINILH
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Flags]
[global::FPEHEOPEMNL(GOCMKIGFKEJ.NONE, GOCMKIGFKEJ.ALL)]
[IPJNLPLHFHD("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::KNAGPGBHGNH(1, false)]
public enum GOCMKIGFKEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[global::FPEHEOPEMNL(NMFMEBNCGMB.Off, NMFMEBNCGMB.COUNT)]
[IPJNLPLHFHD("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::KNAGPGBHGNH(1, false)]
public enum NMFMEBNCGMB
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[NNECPGIHGGJ]
[IPJNLPLHFHD("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::FPEHEOPEMNL(JLKOOCLJAGB.VERSION_0, JLKOOCLJAGB.CURRENT)]
[global::KNAGPGBHGNH(1, false)]
public enum JLKOOCLJAGB : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[IPJNLPLHFHD("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::FPEHEOPEMNL(0, 127)]
[global::KNAGPGBHGNH(1, false)]
public enum JLICOMJJGPO
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NLCKALFEDOB("Dynamic (Environment)", 0)]
	[IMJIPIPDIIM("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NLCKALFEDOB("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NLCKALFEDOB("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NLCKALFEDOB("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NLCKALFEDOB("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NLCKALFEDOB("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[NLCKALFEDOB("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[NLCKALFEDOB("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[NLCKALFEDOB("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[NNECPGIHGGJ]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[NNECPGIHGGJ]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Flags]
[global::KNAGPGBHGNH(1, false)]
[IPJNLPLHFHD("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[global::FPEHEOPEMNL(0, BPEECEOEIPM.ALL)]
public enum BPEECEOEIPM
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[IPJNLPLHFHD("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::FPEHEOPEMNL(0, 2)]
[global::KNAGPGBHGNH(1, false)]
public enum AOPPGPEDKLO
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(KJOJBBBAKAP.Pivot, KJOJBBBAKAP.COUNT)]
[IPJNLPLHFHD("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum KJOJBBBAKAP
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(OIGBGKEBEFC.EnabledForRole, OIGBGKEBEFC.DisabledForRole)]
[IPJNLPLHFHD("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum OIGBGKEBEFC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[global::FPEHEOPEMNL(CCEAMCMKGBM.NavMeshGenerator, CCEAMCMKGBM.NavMeshBlocker)]
[global::KNAGPGBHGNH(1, false)]
[IPJNLPLHFHD("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum CCEAMCMKGBM
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[global::KNAGPGBHGNH(1, false)]
[Flags]
[IPJNLPLHFHD("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::FPEHEOPEMNL(INIFBINLFIE.None, INIFBINLFIE.All)]
public enum INIFBINLFIE
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(0, IJPFCCDEOGE.COUNT)]
[IPJNLPLHFHD("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum IJPFCCDEOGE
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class JHMBCGBOJCK
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60F6080", Offset = "0x60F5280", VA = "0x1860F6080")]
	public static void HPPDEOLAJNB(this INIFBINLFIE PCHAAMDAAJA, IJPFCCDEOGE NLCKKIHGCEK, bool CCMFFLCDHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60F6060", Offset = "0x60F5260", VA = "0x1860F6060")]
	public static bool AOLDFFFDPHJ(this INIFBINLFIE PCHAAMDAAJA, IJPFCCDEOGE NLCKKIHGCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60F60B0", Offset = "0x60F52B0", VA = "0x1860F60B0")]
	public static INIFBINLFIE OHKMENGBPJL(this IJPFCCDEOGE NLCKKIHGCEK)
	{
		return default(INIFBINLFIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[global::KNAGPGBHGNH(1, false)]
[IPJNLPLHFHD("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
[global::FPEHEOPEMNL(OBPHPMOBDFL.NONE, OBPHPMOBDFL.COUNT)]
public enum OBPHPMOBDFL
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[global::KNAGPGBHGNH(1, false)]
[IPJNLPLHFHD("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::FPEHEOPEMNL(1000, 8000)]
public enum AIMLLPOCAAB
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[NLCKALFEDOB("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NLCKALFEDOB("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[NLCKALFEDOB("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[NLCKALFEDOB("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[NNECPGIHGGJ]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[NLCKALFEDOB("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[NLCKALFEDOB("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NLCKALFEDOB("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NLCKALFEDOB("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NLCKALFEDOB("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[NLCKALFEDOB("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[NLCKALFEDOB("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[NLCKALFEDOB("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[NLCKALFEDOB("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[NLCKALFEDOB("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[NLCKALFEDOB("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[NLCKALFEDOB("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[NLCKALFEDOB("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NLCKALFEDOB("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NLCKALFEDOB("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[NLCKALFEDOB("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[NLCKALFEDOB("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[NLCKALFEDOB("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[NLCKALFEDOB("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NLCKALFEDOB("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NLCKALFEDOB("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NLCKALFEDOB("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[NLCKALFEDOB("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[NLCKALFEDOB("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[NLCKALFEDOB("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[NLCKALFEDOB("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[NLCKALFEDOB("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[NLCKALFEDOB("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[NLCKALFEDOB("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[NLCKALFEDOB("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[NLCKALFEDOB("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NLCKALFEDOB("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[NLCKALFEDOB("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[NLCKALFEDOB("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[NLCKALFEDOB("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[NLCKALFEDOB("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[NLCKALFEDOB("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[NLCKALFEDOB("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[NLCKALFEDOB("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[NLCKALFEDOB("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[NLCKALFEDOB("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[NNECPGIHGGJ]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[NLCKALFEDOB("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[NLCKALFEDOB("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[NLCKALFEDOB("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[NLCKALFEDOB("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[NLCKALFEDOB("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[NLCKALFEDOB("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NLCKALFEDOB("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[NLCKALFEDOB("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[NLCKALFEDOB("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[NLCKALFEDOB("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[NLCKALFEDOB("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[NLCKALFEDOB("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[NLCKALFEDOB("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[NLCKALFEDOB("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[NLCKALFEDOB("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[NLCKALFEDOB("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[NLCKALFEDOB("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class OCLAJOGNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60F6380", Offset = "0x60F5580", VA = "0x1860F6380")]
	public static PLJJEACEGHF CNKBANMIIDN(this AIMLLPOCAAB BCOGJAIKHDP)
	{
		return default(PLJJEACEGHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[IPJNLPLHFHD("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::FPEHEOPEMNL(0, 9)]
[global::KNAGPGBHGNH(1, false)]
public enum PLJJEACEGHF
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class PCFPEPOIIDN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60F6490", Offset = "0x60F5690", VA = "0x1860F6490")]
	public static bool EEMKOEMJLGB(this PLJJEACEGHF PHMAPHAJPJG)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::NLAGJNKENCL(8060729269509364919uL, 0u)]
	[IPJNLPLHFHD("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::OODKHDADANM(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[global::EKIAFNEHNLO]
		[global::JEJFDDMFHFN(1)]
		public DBGCOLPIMDG shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[global::KNAGPGBHGNH(1, false)]
[IPJNLPLHFHD("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::FPEHEOPEMNL(-1, 38)]
public enum DBGCOLPIMDG
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(0, 7)]
[IPJNLPLHFHD("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[Flags]
public enum GFPBOGIPHND
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[IPJNLPLHFHD("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[Flags]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(0, 7)]
public enum POIBMGACAPJ
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[IPJNLPLHFHD("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(0, 1)]
[Flags]
public enum CCMNNACNPHP
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[IPJNLPLHFHD("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::FPEHEOPEMNL(-2, 2)]
[global::KNAGPGBHGNH(1, false)]
public enum OFPPBMBMNOL
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[IPJNLPLHFHD("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::KNAGPGBHGNH(1, false)]
[global::FPEHEOPEMNL(int.MinValue, int.MaxValue)]
public enum DKFFJGDMCCB
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[global::FPEHEOPEMNL(-1, 31)]
[IPJNLPLHFHD("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::KNAGPGBHGNH(1, false)]
public enum JFLGFGJFHHM
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[global::PPIPHEPLIOC(1, false)]
[IPJNLPLHFHD("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct DHOGHBGBODA : IComparable<DHOGHBGBODA>, IEquatable<DHOGHBGBODA>, MHHCOOJIDHE
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly DHOGHBGBODA NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	[global::JEJFDDMFHFN(1)]
	public uint EPKEKNKDPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[global::JEJFDDMFHFN(2)]
	public uint LIJKCCMAKMF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint KNHFFHPKBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60F5A10", Offset = "0x60F4C10", VA = "0x1860F5A10")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60F5B70", Offset = "0x60F4D70", VA = "0x1860F5B70")]
	public DHOGHBGBODA(int EPKEKNKDPFB, int JEJNMPABCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60F5B70", Offset = "0x60F4D70", VA = "0x1860F5B70")]
	public DHOGHBGBODA(uint EPKEKNKDPFB, uint JEJNMPABCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60F5850", Offset = "0x60F4A50", VA = "0x1860F5850")]
	public DHOGHBGBODA FADFPKLEPMN(int BMIAFODFMCE = 1)
	{
		return default(DHOGHBGBODA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60F5A20", Offset = "0x60F4C20", VA = "0x1860F5A20")]
	public DHOGHBGBODA NEAFILFEHNF(int BMIAFODFMCE = 1)
	{
		return default(DHOGHBGBODA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60F5720", Offset = "0x60F4920", VA = "0x1860F5720")]
	public static DHOGHBGBODA DOIIOCPMONE(DHOGHBGBODA EAIBKNOIIGG, DHOGHBGBODA PKGAILNKPEP)
	{
		return default(DHOGHBGBODA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60F56F0", Offset = "0x60F48F0", VA = "0x1860F56F0")]
	private static uint DJCGPJDNEOG(uint LLLCBODKBAN, uint HIOEJKGFIKI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60F56D0", Offset = "0x60F48D0", VA = "0x1860F56D0", Slot = "4")]
	public int CompareTo(DHOGHBGBODA MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60F57C0", Offset = "0x60F49C0", VA = "0x1860F57C0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60F5A90", Offset = "0x60F4C90", VA = "0x1860F5A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60F57A0", Offset = "0x60F49A0", VA = "0x1860F57A0", Slot = "5")]
	public bool Equals(DHOGHBGBODA MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60F58C0", Offset = "0x60F4AC0", VA = "0x1860F58C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60F5910", Offset = "0x60F4B10", VA = "0x1860F5910", Slot = "6")]
	public void JCBMCDNAHJB(KJBONOLPCBM IBOFEJJMDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60F59A0", Offset = "0x60F4BA0", VA = "0x1860F59A0", Slot = "7")]
	public void MAOCPLNNJJM(OBDKNNKGIKC GILMBCDEMDA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29FAEE0", Offset = "0x29FA0E0", VA = "0x1829FAEE0")]
	public static bool FPIEKNKMEBM(DHOGHBGBODA EAIBKNOIIGG, DHOGHBGBODA PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60F5980", Offset = "0x60F4B80", VA = "0x1860F5980")]
	public static bool LEBDJINPIPG(DHOGHBGBODA EAIBKNOIIGG, DHOGHBGBODA PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60F56B0", Offset = "0x60F48B0", VA = "0x1860F56B0")]
	public static bool BNKNCLACICD(DHOGHBGBODA EAIBKNOIIGG, DHOGHBGBODA PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60F5690", Offset = "0x60F4890", VA = "0x1860F5690")]
	public static bool BJLFKHFAHFD(DHOGHBGBODA EAIBKNOIIGG, DHOGHBGBODA PKGAILNKPEP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[global::PPIPHEPLIOC(1, false)]
	[IPJNLPLHFHD("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, MHHCOOJIDHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[global::JEJFDDMFHFN(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public static NetworkGuid GEOGJCANPGE(Guid JJMGPACFMMB)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60F6200", Offset = "0x60F5400", VA = "0x1860F6200", Slot = "4")]
		public bool Equals(NetworkGuid MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
		public int CompareTo(NetworkGuid MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60F6230", Offset = "0x60F5430", VA = "0x1860F6230", Slot = "6")]
		public void JCBMCDNAHJB(KJBONOLPCBM IBOFEJJMDAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60F62F0", Offset = "0x60F54F0", VA = "0x1860F62F0", Slot = "7")]
		public void MAOCPLNNJJM(OBDKNNKGIKC GILMBCDEMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60F6360", Offset = "0x60F5560", VA = "0x1860F6360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[IPJNLPLHFHD("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::PPIPHEPLIOC(1, false)]
public struct OPHOACBKMHH : MHHCOOJIDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[global::JEJFDDMFHFN(1)]
	public bool KIOKGDOKJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[global::JEJFDDMFHFN(2)]
	public float3 FCGAOPAFJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[global::JEJFDDMFHFN(3)]
	public float3 GNEKHCMLGDP;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x60F6460", Offset = "0x60F5660", VA = "0x1860F6460")]
	public OPHOACBKMHH(float HBDGBCALKKA, float JDDCNPMIKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60F63A0", Offset = "0x60F55A0", VA = "0x1860F63A0", Slot = "4")]
	public void JCBMCDNAHJB(KJBONOLPCBM IBOFEJJMDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x60F63F0", Offset = "0x60F55F0", VA = "0x1860F63F0", Slot = "5")]
	public void MAOCPLNNJJM(OBDKNNKGIKC GILMBCDEMDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::PPIPHEPLIOC(1, false)]
[IPJNLPLHFHD("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct JLLBINFBBDN : MHHCOOJIDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[global::JEJFDDMFHFN(1)]
	public float EELMHCELFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[global::JEJFDDMFHFN(2)]
	public int MPHMLFDJOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[global::JEJFDDMFHFN(3)]
	public POIBMGACAPJ PCHAAMDAAJA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IEAIACPKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60F6120", Offset = "0x60F5320", VA = "0x1860F6120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60F61E0", Offset = "0x60F53E0", VA = "0x1860F61E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HBAPFCAPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60F60C0", Offset = "0x60F52C0", VA = "0x1860F60C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60F60D0", Offset = "0x60F52D0", VA = "0x1860F60D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KPIPGBDFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60F6110", Offset = "0x60F5310", VA = "0x1860F6110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60F60F0", Offset = "0x60F52F0", VA = "0x1860F60F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60F6190", Offset = "0x60F5390", VA = "0x1860F6190", Slot = "5")]
	public void MAOCPLNNJJM(OBDKNNKGIKC GILMBCDEMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60F6130", Offset = "0x60F5330", VA = "0x1860F6130", Slot = "4")]
	public void JCBMCDNAHJB(KJBONOLPCBM IBOFEJJMDAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class HDPIKPPPAHH : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class JDANGKCMDMJ : Property<RRObjectPrefabData, AIMLLPOCAAB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x60F6030", Offset = "0x60F5230", VA = "0x1860F6030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60F5F40", Offset = "0x60F5140", VA = "0x1860F5F40")]
		public JDANGKCMDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x13E4320", Offset = "0x13E3520", VA = "0x1813E4320", Slot = "14")]
		public override AIMLLPOCAAB GetValue(RRObjectPrefabData BIBKBFDHJAF)
		{
			return default(AIMLLPOCAAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60F5F30", Offset = "0x60F5130", VA = "0x1860F5F30", Slot = "15")]
		public override void SetValue(RRObjectPrefabData BIBKBFDHJAF, AIMLLPOCAAB EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60F5DB0", Offset = "0x60F4FB0", VA = "0x1860F5DB0")]
	public HDPIKPPPAHH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60F64A0", Offset = "0x60F56A0", VA = "0x1860F64A0")]
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
