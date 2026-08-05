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
public interface NMLGMOGBFPL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity HFNOKFJHEJG
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
	[CompilerGenerated]
	[global::BPDFABPNPMK(11505792609904010668uL, 0u)]
	[global::BHMNBGIBAEL(1, false)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[HHLNNBCFEGI("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::MOFLFMLICKM("new float3(float.NaN)")]
		[global::MNHIBGCDOBM(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3B96310", Offset = "0x3B95110", VA = "0x183B96310")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA940", Offset = "0x5FB9740", VA = "0x185FBA940")]
		public static AuthoredLocalPoseData EADAJIFKEOK(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::BPDFABPNPMK(9088562008033959482uL, 0u)]
	[HHLNNBCFEGI("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::MOFLFMLICKM(1f)]
		[global::MNHIBGCDOBM(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[global::BPDFABPNPMK(10137300772124140051uL, 0u)]
	[HHLNNBCFEGI("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::BHMNBGIBAEL(1, false)]
	public struct AuthoredParentData : IComponentData, NMLGMOGBFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
		public static AuthoredParentData EADAJIFKEOK(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA960", Offset = "0x5FB9760", VA = "0x185FBA960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HHBMCJFEFBP : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[HHLNNBCFEGI("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::MOFLFMLICKM(false)]
		[global::MNHIBGCDOBM(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::MOFLFMLICKM(OPGILECLNBH.EnabledForRole)]
		[global::MNHIBGCDOBM(3)]
		public OPGILECLNBH filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[HHLNNBCFEGI("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::MNHIBGCDOBM(2)]
		[global::MOFLFMLICKM]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	[global::BPDFABPNPMK(780699438743496039uL, 0u)]
	[HHLNNBCFEGI("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::MOFLFMLICKM(true)]
		[global::MNHIBGCDOBM(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::MOFLFMLICKM(-1)]
		[global::MNHIBGCDOBM(1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[HHLNNBCFEGI("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(11853296779717712500uL, 0u)]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[global::BPDFABPNPMK(8536678595025273356uL, 0u)]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1DBFF60", Offset = "0x1DBED60", VA = "0x181DBFF60")]
		public EntityBundlePartData(Entity prefabRoot, EntityBundlePartId partId)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		internal EntityBundlePartId(uint DGIBOINMLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0")]
		internal uint LOEODABKEEC()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81DD00", Offset = "0x81CB00", VA = "0x18081DD00", Slot = "4")]
		public bool Equals(EntityBundlePartId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAFA0", Offset = "0x5FB9DA0", VA = "0x185FBAFA0", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B28F0", Offset = "0x8B16F0", VA = "0x1808B28F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1788D20", Offset = "0x1787B20", VA = "0x181788D20")]
		public static bool JACCNGOPODK(EntityBundlePartId GCMDJKOKHCO, EntityBundlePartId LGCDJBDIEJC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[CompilerGenerated]
	[GJNEJKJLPCF("Container", 0)]
	[global::BPDFABPNPMK(11104975410044731874uL, 0u)]
	[HHLNNBCFEGI("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::BHMNBGIBAEL(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[BEPLEHFJFNF(null, 0)]
		[global::MOFLFMLICKM(HIDCIFMCKAM.IsDynamicEnvironment)]
		[global::MNHIBGCDOBM(1)]
		public HIDCIFMCKAM collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HDNHBOIOELL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DNIEDOMGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum PAJGHBAJMAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB020", Offset = "0x5FB9E20", VA = "0x185FBB020")]
	public static (DNIEDOMGAJL, PAJGHBAJMAM) AEJCPALHDJL(this HIDCIFMCKAM HDLBMFBCCKA)
	{
		return default((DNIEDOMGAJL, PAJGHBAJMAM));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[GJNEJKJLPCF("Container", 0)]
	[global::BPDFABPNPMK(2914713536404587710uL, 0u)]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	[HHLNNBCFEGI("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[BEPLEHFJFNF(null, 0)]
		[global::MOFLFMLICKM(KHCGBLHLHMN.Children)]
		[global::MNHIBGCDOBM(1)]
		public KHCGBLHLHMN collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::BHMNBGIBAEL(2, false)]
	[CompilerGenerated]
	[HHLNNBCFEGI("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[GJNEJKJLPCF("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::MOFLFMLICKM(NONJHGAANGP.DEFAULT)]
		[global::MNHIBGCDOBM(1)]
		[BEPLEHFJFNF(null, 0)]
		public NONJHGAANGP flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::BPDFABPNPMK(1094837642118998916uL, 0u)]
	[GJNEJKJLPCF("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::MOFLFMLICKM(0f)]
		[BEPLEHFJFNF(null, 0)]
		[global::MNHIBGCDOBM(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[global::BPDFABPNPMK(13657791279235747653uL, 0u)]
	[HHLNNBCFEGI("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::BHMNBGIBAEL(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[GJNEJKJLPCF("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		[BEPLEHFJFNF(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[HHLNNBCFEGI("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[GJNEJKJLPCF("Container", 0)]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[global::BPDFABPNPMK(5176564412348566398uL, 0u)]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		[BEPLEHFJFNF(null, 0)]
		public HLOOMFKOIJH grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	[global::BPDFABPNPMK(16485879999901987510uL, 0u)]
	[HHLNNBCFEGI("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[GJNEJKJLPCF("Container", 0)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::MNHIBGCDOBM(1)]
		[BEPLEHFJFNF(null, 0)]
		[global::MOFLFMLICKM(MIHOOCPGHPC.NavMeshGenerator)]
		public MIHOOCPGHPC mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::BPDFABPNPMK(1537567323754185605uL, 0u)]
	[HHLNNBCFEGI("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::BHMNBGIBAEL(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[HHLNNBCFEGI("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(5115014870530256079uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[global::BPDFABPNPMK(14429493078606832166uL, 0u)]
	[HHLNNBCFEGI("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(12111354511484844847uL, 0u)]
	[HHLNNBCFEGI("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, NMLGMOGBFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
		public ParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
		public static ParentData EADAJIFKEOK(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PDKDAHNBNDE : ISystemStateComponentData, IComponentData, NMLGMOGBFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity BPKDILNBOII;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity KEBMMLINAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public PDKDAHNBNDE(Entity AJKCELPHOFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static PDKDAHNBNDE EADAJIFKEOK(Entity KEAAKDKHLOM)
	{
		return default(PDKDAHNBNDE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LCGDAAGOJOF : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[HHLNNBCFEGI("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(15012400804589552708uL, 0u)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[global::BHMNBGIBAEL(5, false)]
	[GJNEJKJLPCF("Object", 0)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::BPDFABPNPMK(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[HHLNNBCFEGI("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::MOFLFMLICKM("new ScaleRestriction(1,1)")]
		[global::MNHIBGCDOBM(2)]
		public IBBOMFHEPLG scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[BEPLEHFJFNF(null, 0)]
		[global::MNHIBGCDOBM(3)]
		[global::MOFLFMLICKM("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		public HJHFJNCLMIG userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::MOFLFMLICKM(ADOEKHBDHCN.Default)]
		[BEPLEHFJFNF(null, 0)]
		[global::MNHIBGCDOBM(4)]
		public ADOEKHBDHCN circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM("ObjectPolicyEnumFlags.Default")]
		public BJHBALEABPN flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[global::BPDFABPNPMK(17708500325183871236uL, 0u)]
	[HHLNNBCFEGI("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
		public static PlayerScopeData EADAJIFKEOK(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[global::BPDFABPNPMK(16642773407304133105uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[HHLNNBCFEGI("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::BHMNBGIBAEL(1, false)]
	[GJNEJKJLPCF("Physics", 0)]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::MOFLFMLICKM(10f)]
		[BEPLEHFJFNF(null, 0)]
		[global::MNHIBGCDOBM(1)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	[global::BPDFABPNPMK(10537432342869025182uL, 0u)]
	[HHLNNBCFEGI("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM(DLCHMDBBJIK.None)]
		public DLCHMDBBJIK flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5FBB890", Offset = "0x5FBA690", VA = "0x185FBB890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5FBB8A0", Offset = "0x5FBA6A0", VA = "0x185FBB8A0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[global::BPDFABPNPMK(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public HNFAPBIOGOE shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[HHLNNBCFEGI("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public CGCPEDGLCON order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
		public static SplinePointOrderData EADAJIFKEOK(CGCPEDGLCON value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::BPDFABPNPMK(16368389834000856208uL, 0u)]
	[global::BHMNBGIBAEL(1, false)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[HHLNNBCFEGI("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	[global::BPDFABPNPMK(18095612727592564636uL, 0u)]
	[HHLNNBCFEGI("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[CompilerGenerated]
	[HHLNNBCFEGI("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	[HHLNNBCFEGI("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::MOFLFMLICKM("new float3(1)")]
		[global::MNHIBGCDOBM(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[global::BHMNBGIBAEL(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[HHLNNBCFEGI("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[CompilerGenerated]
	[global::BPDFABPNPMK(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public CECJBHNPNAC parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[HHLNNBCFEGI("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[global::BHMNBGIBAEL(1, false)]
	[global::BPDFABPNPMK(10026670690793008625uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::MOFLFMLICKM(FFIKLMMAOJI.CURRENT)]
		[global::MNHIBGCDOBM(1)]
		public FFIKLMMAOJI version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[global::PKLJJBNJBOB(new int[] { 1 })]
	[HHLNNBCFEGI("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::BHMNBGIBAEL(2, false)]
	[global::BPDFABPNPMK(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::MNHIBGCDOBM(2)]
		[global::MOFLFMLICKM(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::MOFLFMLICKM(true)]
		[global::MNHIBGCDOBM(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::BPDFABPNPMK(2711391707957742092uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[CompilerGenerated]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("021E8703-AAFD-4965-8C38-FF86663126D2")]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::BPDFABPNPMK(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[BEPLEHFJFNF(null, 0)]
		[global::MOFLFMLICKM("new quaternion(0,0,0,1)")]
		[global::MNHIBGCDOBM(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::MNHIBGCDOBM(2)]
		[global::MOFLFMLICKM]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B96310", Offset = "0x3B95110", VA = "0x183B96310")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA940", Offset = "0x5FB9740", VA = "0x185FBA940")]
		public static RigidTransform EADAJIFKEOK(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA940", Offset = "0x5FB9740", VA = "0x185FBA940")]
		public static LocalPoseData EADAJIFKEOK(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[global::BHMNBGIBAEL(1, false)]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[CompilerGenerated]
	[HHLNNBCFEGI("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::BPDFABPNPMK(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::BPDFABPNPMK(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public LDKNHNPJBMO transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(2)]
		public FKPJHEDNGFM transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[global::BHMNBGIBAEL(1, false)]
	[CompilerGenerated]
	[global::GFGOMEGDPOJ]
	[HHLNNBCFEGI("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::BPDFABPNPMK(798350452111942523uL, 0u)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public EGPFMLCEFJD prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[global::BHMNBGIBAEL(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[HHLNNBCFEGI("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::MOFLFMLICKM]
		[global::MNHIBGCDOBM(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::MOFLFMLICKM(false)]
		[global::MNHIBGCDOBM(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::BPDFABPNPMK(1591066774816564574uL, 0u)]
	[GJNEJKJLPCF("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::MNHIBGCDOBM(1)]
		[BEPLEHFJFNF(null, 0)]
		[global::MOFLFMLICKM]
		public NODCJNFOCGG color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[BEPLEHFJFNF(null, 0)]
		[global::MNHIBGCDOBM(2)]
		[global::MOFLFMLICKM]
		public NHCCMKBOPPD material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::MNHIBGCDOBM(3)]
		[BEPLEHFJFNF(null, 0)]
		[global::MOFLFMLICKM]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::MNHIBGCDOBM(4)]
		[global::MOFLFMLICKM]
		[BEPLEHFJFNF(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KALOFLIKHKE(ADOEKHBDHCN.NONE, ADOEKHBDHCN.COUNT)]
[HHLNNBCFEGI("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::HNHGMLOIFCP(1, false)]
public enum ADOEKHBDHCN
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[BEPLEHFJFNF("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[BEPLEHFJFNF("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[BEPLEHFJFNF("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KALOFLIKHKE(0, 4)]
[HHLNNBCFEGI("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::HNHGMLOIFCP(1, false)]
public enum HKFHHODFNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
[KALOFLIKHKE(NPFOCGACFPG.NONE, NPFOCGACFPG.ALL)]
[HHLNNBCFEGI("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::HNHGMLOIFCP(1, false)]
public enum NPFOCGACFPG
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[global::HNHGMLOIFCP(1, false)]
[KALOFLIKHKE(KHCGBLHLHMN.Off, KHCGBLHLHMN.COUNT)]
[HHLNNBCFEGI("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum KHCGBLHLHMN
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[KALOFLIKHKE(FFIKLMMAOJI.VERSION_0, FFIKLMMAOJI.CURRENT)]
[HHLNNBCFEGI("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::HNHGMLOIFCP(1, false)]
[MPOEBJFDNPP]
public enum FFIKLMMAOJI : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[HHLNNBCFEGI("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::HNHGMLOIFCP(1, false)]
[KALOFLIKHKE(0, 127)]
public enum HIDCIFMCKAM
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[GNNJCNJCMOE("Indicating it can be walked on and moved")]
	[BEPLEHFJFNF("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[BEPLEHFJFNF("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[BEPLEHFJFNF("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[BEPLEHFJFNF("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[BEPLEHFJFNF("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[BEPLEHFJFNF("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[BEPLEHFJFNF("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[BEPLEHFJFNF("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[BEPLEHFJFNF("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[MPOEBJFDNPP]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[MPOEBJFDNPP]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[HHLNNBCFEGI("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[global::HNHGMLOIFCP(1, false)]
[KALOFLIKHKE(0, NONJHGAANGP.ALL)]
[Flags]
public enum NONJHGAANGP
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[KALOFLIKHKE(0, 2)]
public enum HNFAPBIOGOE
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[KALOFLIKHKE(HLOOMFKOIJH.Pivot, HLOOMFKOIJH.COUNT)]
[HHLNNBCFEGI("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::HNHGMLOIFCP(1, false)]
public enum HLOOMFKOIJH
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[global::HNHGMLOIFCP(1, false)]
[KALOFLIKHKE(OPGILECLNBH.EnabledForRole, OPGILECLNBH.DisabledForRole)]
[HHLNNBCFEGI("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum OPGILECLNBH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[KALOFLIKHKE(MIHOOCPGHPC.NavMeshGenerator, MIHOOCPGHPC.NavMeshBlocker)]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum MIHOOCPGHPC
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[KALOFLIKHKE(BJHBALEABPN.None, BJHBALEABPN.All)]
[HHLNNBCFEGI("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::HNHGMLOIFCP(1, false)]
[Flags]
public enum BJHBALEABPN
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[HHLNNBCFEGI("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[KALOFLIKHKE(0, CBPNEJPCKLD.COUNT)]
[global::HNHGMLOIFCP(1, false)]
public enum CBPNEJPCKLD
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class AGFKGHHBCGM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA8E0", Offset = "0x5FB96E0", VA = "0x185FBA8E0")]
	public static void FOBLAMHLHCD(this BJHBALEABPN LJFFFJBJMOK, CBPNEJPCKLD FCKKDBAADCN, bool FDOMNJMGLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA910", Offset = "0x5FB9710", VA = "0x185FBA910")]
	public static bool GIEHCOFHPCC(this BJHBALEABPN LJFFFJBJMOK, CBPNEJPCKLD FCKKDBAADCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA930", Offset = "0x5FB9730", VA = "0x185FBA930")]
	public static BJHBALEABPN HJOCOJNKCJL(this CBPNEJPCKLD FCKKDBAADCN)
	{
		return default(BJHBALEABPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[KALOFLIKHKE(HJHFJNCLMIG.NONE, HJHFJNCLMIG.COUNT)]
[Flags]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum HJHFJNCLMIG
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[HHLNNBCFEGI("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::HNHGMLOIFCP(1, false)]
[KALOFLIKHKE(1000, 8000)]
public enum EGPFMLCEFJD
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[BEPLEHFJFNF("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[BEPLEHFJFNF("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[BEPLEHFJFNF("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[BEPLEHFJFNF("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[MPOEBJFDNPP]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[BEPLEHFJFNF("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[BEPLEHFJFNF("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[BEPLEHFJFNF("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[BEPLEHFJFNF("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[BEPLEHFJFNF("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[BEPLEHFJFNF("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[BEPLEHFJFNF("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[BEPLEHFJFNF("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[BEPLEHFJFNF("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[BEPLEHFJFNF("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[BEPLEHFJFNF("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[BEPLEHFJFNF("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[BEPLEHFJFNF("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[BEPLEHFJFNF("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[BEPLEHFJFNF("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[BEPLEHFJFNF("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[BEPLEHFJFNF("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[BEPLEHFJFNF("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[BEPLEHFJFNF("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[BEPLEHFJFNF("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[BEPLEHFJFNF("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[BEPLEHFJFNF("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[BEPLEHFJFNF("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[BEPLEHFJFNF("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[BEPLEHFJFNF("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[BEPLEHFJFNF("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[BEPLEHFJFNF("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[BEPLEHFJFNF("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[BEPLEHFJFNF("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[BEPLEHFJFNF("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[BEPLEHFJFNF("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[BEPLEHFJFNF("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[BEPLEHFJFNF("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[BEPLEHFJFNF("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[BEPLEHFJFNF("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[BEPLEHFJFNF("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[BEPLEHFJFNF("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[BEPLEHFJFNF("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[BEPLEHFJFNF("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[BEPLEHFJFNF("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[BEPLEHFJFNF("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[MPOEBJFDNPP]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[BEPLEHFJFNF("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[BEPLEHFJFNF("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[BEPLEHFJFNF("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[BEPLEHFJFNF("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[BEPLEHFJFNF("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[BEPLEHFJFNF("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[BEPLEHFJFNF("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[BEPLEHFJFNF("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[BEPLEHFJFNF("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[BEPLEHFJFNF("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[BEPLEHFJFNF("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[BEPLEHFJFNF("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[BEPLEHFJFNF("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[BEPLEHFJFNF("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[BEPLEHFJFNF("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[BEPLEHFJFNF("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[BEPLEHFJFNF("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BHJDIAHKABG
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA970", Offset = "0x5FB9770", VA = "0x185FBA970")]
	public static JICCPKLHMMF NEEKCKJKFFJ(this EGPFMLCEFJD MLPCHFIIHMO)
	{
		return default(JICCPKLHMMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[KALOFLIKHKE(0, 9)]
public enum JICCPKLHMMF
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ICECGPJMPHN
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB280", Offset = "0x5FBA080", VA = "0x185FBB280")]
	public static bool MBJHDDACNEF(this JICCPKLHMMF DBBKDALOGKB)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[global::BHMNBGIBAEL(1, false)]
	[HHLNNBCFEGI("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::BPDFABPNPMK(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[global::MNHIBGCDOBM(1)]
		[global::MOFLFMLICKM]
		public MCEJPAIOHJF shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("517224CC-0A79-4FE9-B048-53C37955D823")]
[KALOFLIKHKE(-1, 38)]
public enum MCEJPAIOHJF
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[HHLNNBCFEGI("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::HNHGMLOIFCP(1, false)]
[KALOFLIKHKE(0, 7)]
[Flags]
public enum DLCHMDBBJIK
{
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Flags]
[KALOFLIKHKE(0, 7)]
[HHLNNBCFEGI("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::HNHGMLOIFCP(1, false)]
public enum ODOMBEOBIHI
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Flags]
[KALOFLIKHKE(0, 1)]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("72742F9B-D48E-4CED-B403-444201FFEE66")]
public enum LDKNHNPJBMO
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[KALOFLIKHKE(-2, 2)]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum FKPJHEDNGFM
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[HHLNNBCFEGI("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[KALOFLIKHKE(int.MinValue, int.MaxValue)]
[global::HNHGMLOIFCP(1, false)]
public enum NODCJNFOCGG
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[global::HNHGMLOIFCP(1, false)]
[HHLNNBCFEGI("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[KALOFLIKHKE(-1, 31)]
public enum NHCCMKBOPPD
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::FAPIJGIHKLC(1, false)]
[HHLNNBCFEGI("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct CGCPEDGLCON : IComparable<CGCPEDGLCON>, IEquatable<CGCPEDGLCON>, OJMAAKOJIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[global::MNHIBGCDOBM(1)]
	public uint JNCKPKPDINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[global::MNHIBGCDOBM(2)]
	public uint IHDBILAFHGK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint DNEEADHCNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAD90", Offset = "0x5FB9B90", VA = "0x185FBAD90")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAF50", Offset = "0x5FB9D50", VA = "0x185FBAF50")]
	public CGCPEDGLCON(int JNCKPKPDINM, int PMDJLMNGMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAF50", Offset = "0x5FB9D50", VA = "0x185FBAF50")]
	public CGCPEDGLCON(uint JNCKPKPDINM, uint PMDJLMNGMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAAD0", Offset = "0x5FB98D0", VA = "0x185FBAAD0")]
	public CGCPEDGLCON ACGBBPIACEO(int OOCJLKADJBK = 1)
	{
		return default(CGCPEDGLCON);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAB40", Offset = "0x5FB9940", VA = "0x185FBAB40")]
	public CGCPEDGLCON AJOFPLBGBGC(int OOCJLKADJBK = 1)
	{
		return default(CGCPEDGLCON);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBADF0", Offset = "0x5FB9BF0", VA = "0x185FBADF0")]
	public static CGCPEDGLCON KGBBFIGEAJG(CGCPEDGLCON DPMPIPDPNFG, CGCPEDGLCON DJCBILALFKH)
	{
		return default(CGCPEDGLCON);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBABB0", Offset = "0x5FB99B0", VA = "0x185FBABB0")]
	private static uint BNMCPLKMOJF(uint GCMDJKOKHCO, uint LGCDJBDIEJC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAC50", Offset = "0x5FB9A50", VA = "0x185FBAC50", Slot = "4")]
	public int CompareTo(CGCPEDGLCON FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAC70", Offset = "0x5FB9A70", VA = "0x185FBAC70", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAE70", Offset = "0x5FB9C70", VA = "0x185FBAE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAD00", Offset = "0x5FB9B00", VA = "0x185FBAD00", Slot = "5")]
	public bool Equals(CGCPEDGLCON FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FBADA0", Offset = "0x5FB9BA0", VA = "0x185FBADA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAD20", Offset = "0x5FB9B20", VA = "0x185FBAD20", Slot = "6")]
	public void FILLENIGNNA(FHKCGDAMCNJ HNIKDBEHAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FBABE0", Offset = "0x5FB99E0", VA = "0x185FBABE0", Slot = "7")]
	public void CINNELLPCMC(PGFAOLEECFO FECOEFBKMHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2858C80", Offset = "0x2857A80", VA = "0x182858C80")]
	public static bool JACCNGOPODK(CGCPEDGLCON DPMPIPDPNFG, CGCPEDGLCON DJCBILALFKH)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[HHLNNBCFEGI("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::FAPIJGIHKLC(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, OJMAAKOJIEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[global::MNHIBGCDOBM(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public static NetworkGuid EADAJIFKEOK(Guid FANIDECOFDM)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB480", Offset = "0x5FBA280", VA = "0x185FBB480", Slot = "4")]
		public bool Equals(NetworkGuid FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
		public int CompareTo(NetworkGuid FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB4B0", Offset = "0x5FBA2B0", VA = "0x185FBB4B0", Slot = "6")]
		public void FILLENIGNNA(FHKCGDAMCNJ HNIKDBEHAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB410", Offset = "0x5FBA210", VA = "0x185FBB410", Slot = "7")]
		public void CINNELLPCMC(PGFAOLEECFO FECOEFBKMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB570", Offset = "0x5FBA370", VA = "0x185FBB570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[HHLNNBCFEGI("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::FAPIJGIHKLC(1, false)]
public struct IBBOMFHEPLG : OJMAAKOJIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[global::MNHIBGCDOBM(1)]
	public bool IFBLBHFFNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[global::MNHIBGCDOBM(2)]
	public float3 EDAGPNLLLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[global::MNHIBGCDOBM(3)]
	public float3 GFOMMNHMCEO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB250", Offset = "0x5FBA050", VA = "0x185FBB250")]
	public IBBOMFHEPLG(float EAKGPCAEIKM, float MKKECNHBALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB200", Offset = "0x5FBA000", VA = "0x185FBB200", Slot = "4")]
	public void FILLENIGNNA(FHKCGDAMCNJ HNIKDBEHAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB190", Offset = "0x5FB9F90", VA = "0x185FBB190", Slot = "5")]
	public void CINNELLPCMC(PGFAOLEECFO FECOEFBKMHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[HHLNNBCFEGI("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::FAPIJGIHKLC(1, false)]
public struct CECJBHNPNAC : OJMAAKOJIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[global::MNHIBGCDOBM(1)]
	public float HGNGKJDLCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[global::MNHIBGCDOBM(2)]
	public int CKIFCDEHAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[global::MNHIBGCDOBM(3)]
	public ODOMBEOBIHI LJFFFJBJMOK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool CBCLOONOJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAA70", Offset = "0x5FB9870", VA = "0x185FBAA70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA9F0", Offset = "0x5FB97F0", VA = "0x185FBA9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BDIOCKPHLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA9E0", Offset = "0x5FB97E0", VA = "0x185FBA9E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAAA0", Offset = "0x5FB98A0", VA = "0x185FBAAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EAIJECACJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAAC0", Offset = "0x5FB98C0", VA = "0x185FBAAC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAA80", Offset = "0x5FB9880", VA = "0x185FBAA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA990", Offset = "0x5FB9790", VA = "0x185FBA990", Slot = "5")]
	public void CINNELLPCMC(PGFAOLEECFO FECOEFBKMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAA10", Offset = "0x5FB9810", VA = "0x185FBAA10", Slot = "4")]
	public void FILLENIGNNA(FHKCGDAMCNJ HNIKDBEHAFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class NOGJKCBJOGK : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PKBBNOHCOAO : Property<RRObjectPrefabData, EGPFMLCEFJD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string GMLPMAJDOJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5FBB690", Offset = "0x5FBA490", VA = "0x185FBB690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool JPJFNMHJCCI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB5A0", Offset = "0x5FBA3A0", VA = "0x185FBB5A0")]
		public PKBBNOHCOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x132A360", Offset = "0x1329160", VA = "0x18132A360", Slot = "14")]
		public override EGPFMLCEFJD GetValue(RRObjectPrefabData PPDHICBEIFC)
		{
			return default(EGPFMLCEFJD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB590", Offset = "0x5FBA390", VA = "0x185FBB590", Slot = "15")]
		public override void SetValue(RRObjectPrefabData PPDHICBEIFC, EGPFMLCEFJD NKKIECLCEML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB290", Offset = "0x5FBA090", VA = "0x185FBB290")]
	public NOGJKCBJOGK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB6C0", Offset = "0x5FBA4C0", VA = "0x185FBB6C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class PreviousParentData
	{
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
