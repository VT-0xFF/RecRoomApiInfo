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
public interface LFHLPFIFIBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity IBJNHNLOMDF
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
	[global::HDCEMAPPMOP(1, false)]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(11505792609904010668uL, 0u)]
	[FHPDFOCDIDL("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::IABCMOGADFL("new float3(float.NaN)")]
		[global::LCLPOMFIIFP(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3E12A60", Offset = "0x3E11A60", VA = "0x183E12A60")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6273C20", Offset = "0x6272C20", VA = "0x186273C20")]
		public static AuthoredLocalPoseData NCBCBLCGNHJ(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[CompilerGenerated]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[global::LHHCNOLNMNM(9088562008033959482uL, 0u)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::IABCMOGADFL(1f)]
		[global::LCLPOMFIIFP(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::LHHCNOLNMNM(10137300772124140051uL, 0u)]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	public struct AuthoredParentData : IComponentData, LFHLPFIFIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static AuthoredParentData NCBCBLCGNHJ(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6273C40", Offset = "0x6272C40", VA = "0x186273C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HLGFADDEJLB : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::LCLPOMFIIFP(2)]
		[global::IABCMOGADFL(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::LCLPOMFIIFP(3)]
		[global::IABCMOGADFL(GMBEFCLIDAN.EnabledForRole)]
		public GMBEFCLIDAN filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[global::HDCEMAPPMOP(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(8594223769175916906uL, 0u)]
	[FHPDFOCDIDL("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::LCLPOMFIIFP(2)]
		[global::IABCMOGADFL]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::LHHCNOLNMNM(780699438743496039uL, 0u)]
	[global::HDCEMAPPMOP(1, false)]
	[CompilerGenerated]
	[FHPDFOCDIDL("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::IABCMOGADFL(true)]
		[global::LCLPOMFIIFP(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[global::HDCEMAPPMOP(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[FHPDFOCDIDL("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[FHPDFOCDIDL("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::LHHCNOLNMNM(11853296779717712500uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[global::HDCEMAPPMOP(1, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	[FHPDFOCDIDL("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::HDCEMAPPMOP(1, false)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::LHHCNOLNMNM(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1E64090", Offset = "0x1E63090", VA = "0x181E64090")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EDD0", Offset = "0x1E2DDD0", VA = "0x181E2EDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		internal EntityBundlePartId(uint JKEKANKKCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0")]
		internal uint KCFBIPKPHAN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x895C90", Offset = "0x894C90", VA = "0x180895C90", Slot = "4")]
		public bool Equals(EntityBundlePartId JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6274040", Offset = "0x6273040", VA = "0x186274040", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x942C10", Offset = "0x941C10", VA = "0x180942C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x189A820", Offset = "0x1899820", VA = "0x18189A820")]
		public static bool JPKEALLKLNK(EntityBundlePartId AAOIMEIMECG, EntityBundlePartId ABLGCHAEIGE)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[global::LHHCNOLNMNM(11104975410044731874uL, 0u)]
	[KLLDNEOHGBL("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(LKAELOHNMPI.IsDynamicEnvironment)]
		[IAONFNJDEIO(null, 0)]
		public LKAELOHNMPI collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DGOABBLMMIC
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum CHAILJIHLIO
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
	public enum LDCLHFGNPPH
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
	[Cpp2IlInjected.Address(RVA = "0x6273D90", Offset = "0x6272D90", VA = "0x186273D90")]
	public static (CHAILJIHLIO, LDCLHFGNPPH) OLJOMHKIJLD(this LKAELOHNMPI AHMOKAPAGAF)
	{
		return default((CHAILJIHLIO, LDCLHFGNPPH));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::LHHCNOLNMNM(2914713536404587710uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[global::HDCEMAPPMOP(1, false)]
	[CompilerGenerated]
	[KLLDNEOHGBL("Container", 0)]
	[FHPDFOCDIDL("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(MDNCIBFEOMH.Children)]
		[IAONFNJDEIO(null, 0)]
		public MDNCIBFEOMH collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[FHPDFOCDIDL("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[KLLDNEOHGBL("Container", 0)]
	[global::HDCEMAPPMOP(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::IABCMOGADFL(JIDDLIBAHMP.DEFAULT)]
		[global::LCLPOMFIIFP(1)]
		[IAONFNJDEIO(null, 0)]
		public JIDDLIBAHMP flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::LHHCNOLNMNM(1094837642118998916uL, 0u)]
	[KLLDNEOHGBL("Container", 0)]
	[FHPDFOCDIDL("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::HDCEMAPPMOP(1, false)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[IAONFNJDEIO(null, 0)]
		[global::IABCMOGADFL(0f)]
		[global::LCLPOMFIIFP(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[KLLDNEOHGBL("Container", 0)]
	[global::LHHCNOLNMNM(13657791279235747653uL, 0u)]
	[FHPDFOCDIDL("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::HDCEMAPPMOP(1, false)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[IAONFNJDEIO(null, 0)]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::HDCEMAPPMOP(1, false)]
	[CompilerGenerated]
	[FHPDFOCDIDL("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[KLLDNEOHGBL("Container", 0)]
	[global::LHHCNOLNMNM(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		[IAONFNJDEIO(null, 0)]
		public CGPNNOLEFAM grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[global::LHHCNOLNMNM(16485879999901987510uL, 0u)]
	[FHPDFOCDIDL("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::HDCEMAPPMOP(1, false)]
	[KLLDNEOHGBL("Container", 0)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(CCKMMCPNPKF.NavMeshGenerator)]
		[IAONFNJDEIO(null, 0)]
		public CCKMMCPNPKF mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[FHPDFOCDIDL("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::HDCEMAPPMOP(1, false)]
	[global::LHHCNOLNMNM(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[global::HDCEMAPPMOP(1, false)]
	[global::LHHCNOLNMNM(5115014870530256079uL, 0u)]
	[FHPDFOCDIDL("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(14429493078606832166uL, 0u)]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[FHPDFOCDIDL("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	[global::HDCEMAPPMOP(1, false)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::LHHCNOLNMNM(12111354511484844847uL, 0u)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	public struct ParentData : IComponentData, LFHLPFIFIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, LFHLPFIFIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MMNDJAPOAHN : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(1950029632769634832uL, 0u)]
	[FHPDFOCDIDL("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::HDCEMAPPMOP(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public ANOPJPDFGHP order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static SiblingSortOrderData NCBCBLCGNHJ(ANOPJPDFGHP value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6273850", Offset = "0x6272850", VA = "0x186273850", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[FHPDFOCDIDL("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::HDCEMAPPMOP(1, false)]
	[global::LHHCNOLNMNM(15012400804589552708uL, 0u)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::HDCEMAPPMOP(5, false)]
	[global::LHHCNOLNMNM(16541670854338945984uL, 0u)]
	[KLLDNEOHGBL("Object", 0)]
	[CompilerGenerated]
	[FHPDFOCDIDL("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::IABCMOGADFL("new ScaleRestriction(1,1)")]
		[global::LCLPOMFIIFP(2)]
		public NKEOEFGOAMF scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::IABCMOGADFL("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::LCLPOMFIIFP(3)]
		[IAONFNJDEIO(null, 0)]
		public GMGCKILLHIB userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::LCLPOMFIIFP(4)]
		[IAONFNJDEIO(null, 0)]
		[global::IABCMOGADFL(CPLMIMIADNG.Default)]
		public CPLMIMIADNG circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::IABCMOGADFL("ObjectPolicyEnumFlags.Default")]
		[global::LCLPOMFIIFP(1)]
		public GDNDCNHBOAC flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(17708500325183871236uL, 0u)]
	[FHPDFOCDIDL("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::HDCEMAPPMOP(1, false)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static PlayerScopeData NCBCBLCGNHJ(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::LHHCNOLNMNM(16642773407304133105uL, 0u)]
	[KLLDNEOHGBL("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[IAONFNJDEIO(null, 0)]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(10537432342869025182uL, 0u)]
	[FHPDFOCDIDL("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[global::HDCEMAPPMOP(1, false)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(BAOHCLKKAAJ.None)]
		public BAOHCLKKAAJ flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6274710", Offset = "0x6273710", VA = "0x186274710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6274720", Offset = "0x6273720", VA = "0x186274720")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::LHHCNOLNMNM(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::HDCEMAPPMOP(1, false)]
	[CompilerGenerated]
	[FHPDFOCDIDL("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public LNMBGIBPONN shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::LHHCNOLNMNM(5298506180484533559uL, 0u)]
	[global::HDCEMAPPMOP(1, false)]
	[CompilerGenerated]
	[FHPDFOCDIDL("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public ANOPJPDFGHP order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static SplinePointOrderData NCBCBLCGNHJ(ANOPJPDFGHP value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::LHHCNOLNMNM(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::LHHCNOLNMNM(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::LHHCNOLNMNM(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[FHPDFOCDIDL("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::HDCEMAPPMOP(1, false)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::IABCMOGADFL("new quaternion(0, 0, 0, 1f)")]
		[global::LCLPOMFIIFP(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::LHHCNOLNMNM(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[FHPDFOCDIDL("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::HDCEMAPPMOP(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[global::LHHCNOLNMNM(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public DPMLOEBFPBC parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::HDCEMAPPMOP(1, false)]
	[FHPDFOCDIDL("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(10026670690793008625uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(GPMELJIOPAC.CURRENT)]
		public GPMELJIOPAC version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[global::LHHCNOLNMNM(12332323170023439017uL, 0u)]
	[CompilerGenerated]
	[global::HDCEMAPPMOP(2, false)]
	[global::ONFIHNJANID(new int[] { 1 })]
	[FHPDFOCDIDL("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::LCLPOMFIIFP(2)]
		[global::IABCMOGADFL(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::LCLPOMFIIFP(3)]
		[global::IABCMOGADFL(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[FHPDFOCDIDL("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[global::MLJOALMFCKM(KDHGOEGCHGO.MIN, KDHGOEGCHGO.ALL)]
[global::MNNDEFDBJKK(1, false)]
public enum KDHGOEGCHGO
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
	[FHPDFOCDIDL("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[global::HDCEMAPPMOP(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::IABCMOGADFL(KDHGOEGCHGO.UseDefaultVisualEffects)]
		[global::LCLPOMFIIFP(2)]
		public KDHGOEGCHGO toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	[global::HDCEMAPPMOP(1, false)]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[FHPDFOCDIDL("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[global::LCLPOMFIIFP(3)]
		[global::IABCMOGADFL]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::HDCEMAPPMOP(2, false)]
	[FHPDFOCDIDL("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[global::IABCMOGADFL("new float3(1)")]
		[global::LCLPOMFIIFP(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[FHPDFOCDIDL("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::HDCEMAPPMOP(1, false)]
	[global::LHHCNOLNMNM(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[global::LCLPOMFIIFP(1)]
		[IAONFNJDEIO(null, 0)]
		[global::IABCMOGADFL("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[global::LCLPOMFIIFP(2)]
		[global::IABCMOGADFL]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E12A60", Offset = "0x3E11A60", VA = "0x183E12A60")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6273C20", Offset = "0x6272C20", VA = "0x186273C20")]
		public static RigidTransform NCBCBLCGNHJ(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6273C20", Offset = "0x6272C20", VA = "0x186273C20")]
		public static LocalPoseData NCBCBLCGNHJ(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LIKBEONMBKP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static RigidTransform IFNLBCGFHLI(this LocalPoseData LDGMLLMKHLF)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[global::LHHCNOLNMNM(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[FHPDFOCDIDL("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::HDCEMAPPMOP(1, false)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::IABCMOGADFL(1f)]
		[global::LCLPOMFIIFP(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::LHHCNOLNMNM(5730545663584378555uL, 0u)]
	[FHPDFOCDIDL("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::HDCEMAPPMOP(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		public JDNAOIDINOP transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::LCLPOMFIIFP(2)]
		[global::IABCMOGADFL]
		public DNIKADBONDJ transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[global::HDCEMAPPMOP(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(798350452111942523uL, 0u)]
	[global::DJKCGMDCONE]
	[FHPDFOCDIDL("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public PLACGONOKNH prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[global::HDCEMAPPMOP(2, false)]
	[FHPDFOCDIDL("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::IABCMOGADFL(false)]
		[global::LCLPOMFIIFP(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[FHPDFOCDIDL("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::HDCEMAPPMOP(1, false)]
	[global::LHHCNOLNMNM(1591066774816564574uL, 0u)]
	[CompilerGenerated]
	[KLLDNEOHGBL("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::LCLPOMFIIFP(1)]
		[global::IABCMOGADFL]
		[IAONFNJDEIO(null, 0)]
		public APCAPIKDGEA color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[global::LCLPOMFIIFP(2)]
		[global::IABCMOGADFL]
		[IAONFNJDEIO(null, 0)]
		public IAANGPEHLAC material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[global::LCLPOMFIIFP(3)]
		[IAONFNJDEIO(null, 0)]
		[global::IABCMOGADFL]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[global::IABCMOGADFL]
		[IAONFNJDEIO(null, 0)]
		[global::LCLPOMFIIFP(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[global::MLJOALMFCKM(CPLMIMIADNG.NONE, CPLMIMIADNG.COUNT)]
[FHPDFOCDIDL("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::MNNDEFDBJKK(1, false)]
public enum CPLMIMIADNG
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[IAONFNJDEIO("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[IAONFNJDEIO("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[IAONFNJDEIO("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(0, 4)]
[FHPDFOCDIDL("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum DCKBNLIHMMO
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
[global::MLJOALMFCKM(EFDIFNHBAEI.NONE, EFDIFNHBAEI.ALL)]
[FHPDFOCDIDL("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::MNNDEFDBJKK(1, false)]
public enum EFDIFNHBAEI
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
[global::MLJOALMFCKM(MDNCIBFEOMH.Off, MDNCIBFEOMH.COUNT)]
[FHPDFOCDIDL("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::MNNDEFDBJKK(1, false)]
public enum MDNCIBFEOMH
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
[OEJEKBNLLIP]
[FHPDFOCDIDL("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::MLJOALMFCKM(GPMELJIOPAC.VERSION_0, GPMELJIOPAC.CURRENT)]
[global::MNNDEFDBJKK(1, false)]
public enum GPMELJIOPAC : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[FHPDFOCDIDL("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::MLJOALMFCKM(0, 127)]
[global::MNNDEFDBJKK(1, false)]
public enum LKAELOHNMPI
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[IAONFNJDEIO("Dynamic (Environment)", 0)]
	[OKNLNLBMJBF("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[IAONFNJDEIO("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[IAONFNJDEIO("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[IAONFNJDEIO("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[IAONFNJDEIO("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[IAONFNJDEIO("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[IAONFNJDEIO("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[IAONFNJDEIO("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[IAONFNJDEIO("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[OEJEKBNLLIP]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[OEJEKBNLLIP]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Flags]
[global::MNNDEFDBJKK(1, false)]
[FHPDFOCDIDL("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[global::MLJOALMFCKM(0, JIDDLIBAHMP.ALL)]
public enum JIDDLIBAHMP
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
[FHPDFOCDIDL("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::MLJOALMFCKM(0, 2)]
[global::MNNDEFDBJKK(1, false)]
public enum LNMBGIBPONN
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
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(CGPNNOLEFAM.Pivot, CGPNNOLEFAM.COUNT)]
[FHPDFOCDIDL("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum CGPNNOLEFAM
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
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(GMBEFCLIDAN.EnabledForRole, GMBEFCLIDAN.DisabledForRole)]
[FHPDFOCDIDL("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum GMBEFCLIDAN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[global::MLJOALMFCKM(CCKMMCPNPKF.NavMeshGenerator, CCKMMCPNPKF.NavMeshBlocker)]
[global::MNNDEFDBJKK(1, false)]
[FHPDFOCDIDL("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum CCKMMCPNPKF
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
[global::MNNDEFDBJKK(1, false)]
[Flags]
[FHPDFOCDIDL("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::MLJOALMFCKM(GDNDCNHBOAC.None, GDNDCNHBOAC.All)]
public enum GDNDCNHBOAC
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(0, MEBBJNKIGHL.COUNT)]
[FHPDFOCDIDL("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum MEBBJNKIGHL
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
public static class NOCMLGLGEDC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6274390", Offset = "0x6273390", VA = "0x186274390")]
	public static void PGLEONAELKI(this GDNDCNHBOAC ODGEOOFAOHB, MEBBJNKIGHL ICJHHECDGKP, bool GEEDEEIHDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6274360", Offset = "0x6273360", VA = "0x186274360")]
	public static bool DAMHMGHMMMI(this GDNDCNHBOAC ODGEOOFAOHB, MEBBJNKIGHL ICJHHECDGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6274380", Offset = "0x6273380", VA = "0x186274380")]
	public static GDNDCNHBOAC GOCLIGONELG(this MEBBJNKIGHL ICJHHECDGKP)
	{
		return default(GDNDCNHBOAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[global::MNNDEFDBJKK(1, false)]
[FHPDFOCDIDL("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
[global::MLJOALMFCKM(GMGCKILLHIB.NONE, GMGCKILLHIB.COUNT)]
public enum GMGCKILLHIB
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
[global::MNNDEFDBJKK(1, false)]
[FHPDFOCDIDL("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::MLJOALMFCKM(1000, 8000)]
public enum PLACGONOKNH
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[IAONFNJDEIO("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[IAONFNJDEIO("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[IAONFNJDEIO("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[IAONFNJDEIO("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[OEJEKBNLLIP]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[IAONFNJDEIO("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[IAONFNJDEIO("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[IAONFNJDEIO("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[IAONFNJDEIO("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[IAONFNJDEIO("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[IAONFNJDEIO("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[IAONFNJDEIO("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[IAONFNJDEIO("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[IAONFNJDEIO("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[IAONFNJDEIO("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[IAONFNJDEIO("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[IAONFNJDEIO("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[IAONFNJDEIO("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[IAONFNJDEIO("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[IAONFNJDEIO("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[IAONFNJDEIO("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[IAONFNJDEIO("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[IAONFNJDEIO("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[IAONFNJDEIO("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[IAONFNJDEIO("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[IAONFNJDEIO("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[IAONFNJDEIO("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[IAONFNJDEIO("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[IAONFNJDEIO("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[IAONFNJDEIO("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[IAONFNJDEIO("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[IAONFNJDEIO("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[IAONFNJDEIO("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[IAONFNJDEIO("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[IAONFNJDEIO("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[IAONFNJDEIO("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[IAONFNJDEIO("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[IAONFNJDEIO("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[IAONFNJDEIO("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[IAONFNJDEIO("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[IAONFNJDEIO("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[IAONFNJDEIO("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[IAONFNJDEIO("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[IAONFNJDEIO("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[IAONFNJDEIO("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[IAONFNJDEIO("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[OEJEKBNLLIP]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[IAONFNJDEIO("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[IAONFNJDEIO("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[IAONFNJDEIO("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[IAONFNJDEIO("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[IAONFNJDEIO("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[IAONFNJDEIO("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[IAONFNJDEIO("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[IAONFNJDEIO("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[IAONFNJDEIO("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[IAONFNJDEIO("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[IAONFNJDEIO("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[IAONFNJDEIO("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[IAONFNJDEIO("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[IAONFNJDEIO("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[IAONFNJDEIO("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[IAONFNJDEIO("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[IAONFNJDEIO("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class IJCFJCPJMGN
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6274250", Offset = "0x6273250", VA = "0x186274250")]
	public static BDFCCOKJLDJ BPNCIKPBOHF(this PLACGONOKNH INLOKFDEDIJ)
	{
		return default(BDFCCOKJLDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[FHPDFOCDIDL("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::MLJOALMFCKM(0, 9)]
[global::MNNDEFDBJKK(1, false)]
public enum BDFCCOKJLDJ
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
public static class DACKLDGGBFB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6273D80", Offset = "0x6272D80", VA = "0x186273D80")]
	public static bool OPCICKHKFGM(this BDFCCOKJLDJ PLGDMKFOCBO)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::LHHCNOLNMNM(8060729269509364919uL, 0u)]
	[FHPDFOCDIDL("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::HDCEMAPPMOP(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[global::IABCMOGADFL]
		[global::LCLPOMFIIFP(1)]
		public NGHGEBOPDDH shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[global::MNNDEFDBJKK(1, false)]
[FHPDFOCDIDL("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::MLJOALMFCKM(-1, 38)]
public enum NGHGEBOPDDH
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
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(0, 7)]
[FHPDFOCDIDL("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[Flags]
public enum BAOHCLKKAAJ
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
[FHPDFOCDIDL("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[Flags]
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(0, 7)]
public enum BOCEHFOHEOB
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
[FHPDFOCDIDL("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(0, 1)]
[Flags]
public enum JDNAOIDINOP
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
[FHPDFOCDIDL("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::MLJOALMFCKM(-2, 2)]
[global::MNNDEFDBJKK(1, false)]
public enum DNIKADBONDJ
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
[FHPDFOCDIDL("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::MNNDEFDBJKK(1, false)]
[global::MLJOALMFCKM(int.MinValue, int.MaxValue)]
public enum APCAPIKDGEA
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
[global::MLJOALMFCKM(-1, 31)]
[FHPDFOCDIDL("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::MNNDEFDBJKK(1, false)]
public enum IAANGPEHLAC
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
[global::NCIFHDDGMMC(1, false)]
[FHPDFOCDIDL("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct ANOPJPDFGHP : IComparable<ANOPJPDFGHP>, IEquatable<ANOPJPDFGHP>, FLDLAIGHMID
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly ANOPJPDFGHP LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	[global::LCLPOMFIIFP(1)]
	public uint IDHAMPFHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[global::LCLPOMFIIFP(2)]
	public uint HMPLIINDBAM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint CODFCIPFHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6273910", Offset = "0x6272910", VA = "0x186273910")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6273BD0", Offset = "0x6272BD0", VA = "0x186273BD0")]
	public ANOPJPDFGHP(int IDHAMPFHJNB, int GNMMMIPENCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6273BD0", Offset = "0x6272BD0", VA = "0x186273BD0")]
	public ANOPJPDFGHP(uint IDHAMPFHJNB, uint GNMMMIPENCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6273750", Offset = "0x6272750", VA = "0x186273750")]
	public ANOPJPDFGHP ALDHMKNFJCG(int NGKDOMEFDDB = 1)
	{
		return default(ANOPJPDFGHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62737E0", Offset = "0x62727E0", VA = "0x1862737E0")]
	public ANOPJPDFGHP DKKMAJDNFDF(int NGKDOMEFDDB = 1)
	{
		return default(ANOPJPDFGHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62739C0", Offset = "0x62729C0", VA = "0x1862739C0")]
	public static ANOPJPDFGHP KCIHAEMLBLL(ANOPJPDFGHP LHPJOLLNMHI, ANOPJPDFGHP MGIFPMANJFK)
	{
		return default(ANOPJPDFGHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6273970", Offset = "0x6272970", VA = "0x186273970")]
	private static uint JJABMMJPHIJ(uint AAOIMEIMECG, uint ABLGCHAEIGE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62737C0", Offset = "0x62727C0", VA = "0x1862737C0", Slot = "4")]
	public int CompareTo(ANOPJPDFGHP JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6273870", Offset = "0x6272870", VA = "0x186273870", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6273AF0", Offset = "0x6272AF0", VA = "0x186273AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6273850", Offset = "0x6272850", VA = "0x186273850", Slot = "5")]
	public bool Equals(ANOPJPDFGHP JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6273920", Offset = "0x6272920", VA = "0x186273920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62736E0", Offset = "0x62726E0", VA = "0x1862736E0", Slot = "6")]
	public void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6273A60", Offset = "0x6272A60", VA = "0x186273A60", Slot = "7")]
	public void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x27605A0", Offset = "0x275F5A0", VA = "0x1827605A0")]
	public static bool JPKEALLKLNK(ANOPJPDFGHP LHPJOLLNMHI, ANOPJPDFGHP MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6273A40", Offset = "0x6272A40", VA = "0x186273A40")]
	public static bool OECHKCIMKIG(ANOPJPDFGHP LHPJOLLNMHI, ANOPJPDFGHP MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6273AD0", Offset = "0x6272AD0", VA = "0x186273AD0")]
	public static bool PNFBCKPBMMF(ANOPJPDFGHP LHPJOLLNMHI, ANOPJPDFGHP MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62739A0", Offset = "0x62729A0", VA = "0x1862739A0")]
	public static bool KCHCJMABOFD(ANOPJPDFGHP LHPJOLLNMHI, ANOPJPDFGHP MGIFPMANJFK)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[global::NCIFHDDGMMC(1, false)]
	[FHPDFOCDIDL("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, FLDLAIGHMID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[global::LCLPOMFIIFP(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0")]
		public static NetworkGuid NCBCBLCGNHJ(Guid KAABLCGOLKG)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6274480", Offset = "0x6273480", VA = "0x186274480", Slot = "4")]
		public bool Equals(NetworkGuid JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
		public int CompareTo(NetworkGuid JNHFAFOIKEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x62743C0", Offset = "0x62733C0", VA = "0x1862743C0", Slot = "6")]
		public void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x62744B0", Offset = "0x62734B0", VA = "0x1862744B0", Slot = "7")]
		public void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6274520", Offset = "0x6273520", VA = "0x186274520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[FHPDFOCDIDL("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::NCIFHDDGMMC(1, false)]
public struct NKEOEFGOAMF : FLDLAIGHMID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[global::LCLPOMFIIFP(1)]
	public bool IEEBLFDNOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[global::LCLPOMFIIFP(2)]
	public float3 JDMMFAHCGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[global::LCLPOMFIIFP(3)]
	public float3 KGAHNHBCOHG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6274330", Offset = "0x6273330", VA = "0x186274330")]
	public NKEOEFGOAMF(float HBOEBLPEGBN, float ILNGOKDLDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6274270", Offset = "0x6273270", VA = "0x186274270", Slot = "4")]
	public void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62742C0", Offset = "0x62732C0", VA = "0x1862742C0", Slot = "5")]
	public void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::NCIFHDDGMMC(1, false)]
[FHPDFOCDIDL("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct DPMLOEBFPBC : FLDLAIGHMID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[global::LCLPOMFIIFP(1)]
	public float GIAPLBLFENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[global::LCLPOMFIIFP(2)]
	public int JDLGHBNAAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[global::LCLPOMFIIFP(3)]
	public BOCEHFOHEOB ODGEOOFAOHB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HLHLLGCGOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6273F70", Offset = "0x6272F70", VA = "0x186273F70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6273F80", Offset = "0x6272F80", VA = "0x186273F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FDELKLJPCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6273F00", Offset = "0x6272F00", VA = "0x186273F00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6273FA0", Offset = "0x6272FA0", VA = "0x186273FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool IKDJKAHEBIC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6274010", Offset = "0x6273010", VA = "0x186274010")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6274020", Offset = "0x6273020", VA = "0x186274020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6273FC0", Offset = "0x6272FC0", VA = "0x186273FC0", Slot = "5")]
	public void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6273F10", Offset = "0x6272F10", VA = "0x186273F10", Slot = "4")]
	public void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class GKKLGPCNLML : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class CKKNCGDAKKE : Property<RRObjectPrefabData, PLACGONOKNH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6273D50", Offset = "0x6272D50", VA = "0x186273D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6273C60", Offset = "0x6272C60", VA = "0x186273C60")]
		public CKKNCGDAKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1404430", Offset = "0x1403430", VA = "0x181404430", Slot = "14")]
		public override PLACGONOKNH GetValue(RRObjectPrefabData MJBHKMGKNLL)
		{
			return default(PLACGONOKNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6273C50", Offset = "0x6272C50", VA = "0x186273C50", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MJBHKMGKNLL, PLACGONOKNH LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62740D0", Offset = "0x62730D0", VA = "0x1862740D0")]
	public GKKLGPCNLML()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6274540", Offset = "0x6273540", VA = "0x186274540")]
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
