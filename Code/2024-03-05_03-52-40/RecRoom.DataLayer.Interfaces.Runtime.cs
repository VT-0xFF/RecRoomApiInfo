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
public interface HMEPPGLCLPM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity LIBILHLCBAE
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
	[global::DMLKKIHCNGA(11505792609904010668uL, 0u)]
	[global::LAKDGEIDLIN(1, false)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[HFDLLGMGDPK("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::GMAFCNDDADC("new float3(float.NaN)")]
		[global::HMLPPHANHBI(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6330", Offset = "0x3BE5130", VA = "0x183BE6330")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60A43E0", Offset = "0x60A31E0", VA = "0x1860A43E0")]
		public static AuthoredLocalPoseData CCJKPBOFOJB(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::DMLKKIHCNGA(9088562008033959482uL, 0u)]
	[HFDLLGMGDPK("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::GMAFCNDDADC(1f)]
		[global::HMLPPHANHBI(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[global::DMLKKIHCNGA(10137300772124140051uL, 0u)]
	[HFDLLGMGDPK("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::LAKDGEIDLIN(1, false)]
	public struct AuthoredParentData : IComponentData, HMEPPGLCLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
		public static AuthoredParentData CCJKPBOFOJB(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60A4400", Offset = "0x60A3200", VA = "0x1860A4400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JKCMMGBFKPO : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[HFDLLGMGDPK("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::GMAFCNDDADC(false)]
		[global::HMLPPHANHBI(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::GMAFCNDDADC(EOOLPFLHNKA.EnabledForRole)]
		[global::HMLPPHANHBI(3)]
		public EOOLPFLHNKA filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[HFDLLGMGDPK("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::HMLPPHANHBI(2)]
		[global::GMAFCNDDADC]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	[global::DMLKKIHCNGA(780699438743496039uL, 0u)]
	[HFDLLGMGDPK("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::GMAFCNDDADC(true)]
		[global::HMLPPHANHBI(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::GMAFCNDDADC(-1)]
		[global::HMLPPHANHBI(1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[HFDLLGMGDPK("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(11853296779717712500uL, 0u)]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[global::DMLKKIHCNGA(8536678595025273356uL, 0u)]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1DA0020", Offset = "0x1D9EE20", VA = "0x181DA0020")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD40A0", Offset = "0x1DD2EA0", VA = "0x181DD40A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		internal EntityBundlePartId(uint FJIJLBIGEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		internal uint MHPEBLHOMHB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86D940", Offset = "0x86C740", VA = "0x18086D940", Slot = "4")]
		public bool Equals(EntityBundlePartId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60A4760", Offset = "0x60A3560", VA = "0x1860A4760", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x90A050", Offset = "0x908E50", VA = "0x18090A050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1802CA0", Offset = "0x1801AA0", VA = "0x181802CA0")]
		public static bool EILLJGMDDAM(EntityBundlePartId AOHIFIJNOBB, EntityBundlePartId FNDBFMFAGPH)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[CompilerGenerated]
	[OBODDGECLAN("Container", 0)]
	[global::DMLKKIHCNGA(11104975410044731874uL, 0u)]
	[HFDLLGMGDPK("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::LAKDGEIDLIN(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[BFDFEKGFJHK(null, 0)]
		[global::GMAFCNDDADC(CPFCINEGKPG.IsDynamicEnvironment)]
		[global::HMLPPHANHBI(1)]
		public CPFCINEGKPG collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EICJOBEHKNA
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum IHMKLOLMKIP
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
	public enum KIJAHFMIEHK
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
	[Cpp2IlInjected.Address(RVA = "0x60A45F0", Offset = "0x60A33F0", VA = "0x1860A45F0")]
	public static (IHMKLOLMKIP, KIJAHFMIEHK) CKMOLOLJNFA(this CPFCINEGKPG JPKFLBLKANP)
	{
		return default((IHMKLOLMKIP, KIJAHFMIEHK));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[OBODDGECLAN("Container", 0)]
	[global::DMLKKIHCNGA(2914713536404587710uL, 0u)]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	[HFDLLGMGDPK("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[BFDFEKGFJHK(null, 0)]
		[global::GMAFCNDDADC(GMCCKJLLOHO.Children)]
		[global::HMLPPHANHBI(1)]
		public GMCCKJLLOHO collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::LAKDGEIDLIN(2, false)]
	[CompilerGenerated]
	[HFDLLGMGDPK("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[OBODDGECLAN("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::GMAFCNDDADC(PNFLHPNKBIO.DEFAULT)]
		[global::HMLPPHANHBI(1)]
		[BFDFEKGFJHK(null, 0)]
		public PNFLHPNKBIO flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::DMLKKIHCNGA(1094837642118998916uL, 0u)]
	[OBODDGECLAN("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::GMAFCNDDADC(0f)]
		[BFDFEKGFJHK(null, 0)]
		[global::HMLPPHANHBI(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[global::DMLKKIHCNGA(13657791279235747653uL, 0u)]
	[HFDLLGMGDPK("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::LAKDGEIDLIN(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[OBODDGECLAN("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		[BFDFEKGFJHK(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[HFDLLGMGDPK("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[OBODDGECLAN("Container", 0)]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[global::DMLKKIHCNGA(5176564412348566398uL, 0u)]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		[BFDFEKGFJHK(null, 0)]
		public BJILLFEBAPF grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	[global::DMLKKIHCNGA(16485879999901987510uL, 0u)]
	[HFDLLGMGDPK("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[OBODDGECLAN("Container", 0)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::HMLPPHANHBI(1)]
		[BFDFEKGFJHK(null, 0)]
		[global::GMAFCNDDADC(EIKOJILMNLL.NavMeshGenerator)]
		public EIKOJILMNLL mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::DMLKKIHCNGA(1537567323754185605uL, 0u)]
	[HFDLLGMGDPK("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::LAKDGEIDLIN(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[HFDLLGMGDPK("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(5115014870530256079uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[global::DMLKKIHCNGA(14429493078606832166uL, 0u)]
	[HFDLLGMGDPK("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(12111354511484844847uL, 0u)]
	[HFDLLGMGDPK("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, HMEPPGLCLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
		public ParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
		public static ParentData CCJKPBOFOJB(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FBHDGEIKMPA : ISystemStateComponentData, IComponentData, HMEPPGLCLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity DCLFHMLJNFN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity BLPNPGGIFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public FBHDGEIKMPA(Entity FEOGIMKDFKL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static FBHDGEIKMPA CCJKPBOFOJB(Entity JLCPBIBMCCJ)
	{
		return default(FBHDGEIKMPA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LIHOCLLNDCO : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[HFDLLGMGDPK("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(15012400804589552708uL, 0u)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[global::LAKDGEIDLIN(5, false)]
	[OBODDGECLAN("Object", 0)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::DMLKKIHCNGA(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[HFDLLGMGDPK("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::GMAFCNDDADC("new ScaleRestriction(1,1)")]
		[global::HMLPPHANHBI(2)]
		public PDMENGFPFOJ scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[BFDFEKGFJHK(null, 0)]
		[global::HMLPPHANHBI(3)]
		[global::GMAFCNDDADC("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		public PGDCJKHFMEC userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::GMAFCNDDADC(PLGEILLLIPO.Default)]
		[BFDFEKGFJHK(null, 0)]
		[global::HMLPPHANHBI(4)]
		public PLGEILLLIPO circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC("ObjectPolicyEnumFlags.Default")]
		public PJIBNPAPNBB flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[global::DMLKKIHCNGA(17708500325183871236uL, 0u)]
	[HFDLLGMGDPK("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
		public static PlayerScopeData CCJKPBOFOJB(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[global::DMLKKIHCNGA(16642773407304133105uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[HFDLLGMGDPK("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::LAKDGEIDLIN(1, false)]
	[OBODDGECLAN("Physics", 0)]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::GMAFCNDDADC(10f)]
		[BFDFEKGFJHK(null, 0)]
		[global::HMLPPHANHBI(1)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	[global::DMLKKIHCNGA(10537432342869025182uL, 0u)]
	[HFDLLGMGDPK("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC(GBJAGKOIPPB.None)]
		public GBJAGKOIPPB flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x60A53A0", Offset = "0x60A41A0", VA = "0x1860A53A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x60A5390", Offset = "0x60A4190", VA = "0x1860A5390")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[global::DMLKKIHCNGA(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public IAOPLFJAAKL shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[HFDLLGMGDPK("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public KJBEJFJOMFJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
		public static SplinePointOrderData CCJKPBOFOJB(KJBEJFJOMFJ value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::DMLKKIHCNGA(16368389834000856208uL, 0u)]
	[global::LAKDGEIDLIN(1, false)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[HFDLLGMGDPK("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	[global::DMLKKIHCNGA(18095612727592564636uL, 0u)]
	[HFDLLGMGDPK("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[CompilerGenerated]
	[HFDLLGMGDPK("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	[HFDLLGMGDPK("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::GMAFCNDDADC("new float3(1)")]
		[global::HMLPPHANHBI(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[global::LAKDGEIDLIN(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[HFDLLGMGDPK("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[CompilerGenerated]
	[global::DMLKKIHCNGA(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public FECIKOMCBBA parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[HFDLLGMGDPK("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[global::LAKDGEIDLIN(1, false)]
	[global::DMLKKIHCNGA(10026670690793008625uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::GMAFCNDDADC(AKPHCGFFGOG.CURRENT)]
		[global::HMLPPHANHBI(1)]
		public AKPHCGFFGOG version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[global::LCAPCGDBMNK(new int[] { 1 })]
	[HFDLLGMGDPK("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::LAKDGEIDLIN(2, false)]
	[global::DMLKKIHCNGA(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::HMLPPHANHBI(2)]
		[global::GMAFCNDDADC(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::GMAFCNDDADC(true)]
		[global::HMLPPHANHBI(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::DMLKKIHCNGA(2711391707957742092uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[CompilerGenerated]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("021E8703-AAFD-4965-8C38-FF86663126D2")]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::DMLKKIHCNGA(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[BFDFEKGFJHK(null, 0)]
		[global::GMAFCNDDADC("new quaternion(0,0,0,1)")]
		[global::HMLPPHANHBI(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::HMLPPHANHBI(2)]
		[global::GMAFCNDDADC]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6330", Offset = "0x3BE5130", VA = "0x183BE6330")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60A43E0", Offset = "0x60A31E0", VA = "0x1860A43E0")]
		public static RigidTransform CCJKPBOFOJB(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60A43E0", Offset = "0x60A31E0", VA = "0x1860A43E0")]
		public static LocalPoseData CCJKPBOFOJB(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[global::LAKDGEIDLIN(1, false)]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[CompilerGenerated]
	[HFDLLGMGDPK("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::DMLKKIHCNGA(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::DMLKKIHCNGA(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public JMBALEIKDLP transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(2)]
		public KKKPBECCFAO transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[global::LAKDGEIDLIN(1, false)]
	[CompilerGenerated]
	[global::PFJDFEABBFH]
	[HFDLLGMGDPK("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::DMLKKIHCNGA(798350452111942523uL, 0u)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public HLKLEDFOFOB prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[global::LAKDGEIDLIN(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[HFDLLGMGDPK("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::GMAFCNDDADC]
		[global::HMLPPHANHBI(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::GMAFCNDDADC(false)]
		[global::HMLPPHANHBI(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::DMLKKIHCNGA(1591066774816564574uL, 0u)]
	[OBODDGECLAN("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::HMLPPHANHBI(1)]
		[BFDFEKGFJHK(null, 0)]
		[global::GMAFCNDDADC]
		public IJGADHLLDHP color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[BFDFEKGFJHK(null, 0)]
		[global::HMLPPHANHBI(2)]
		[global::GMAFCNDDADC]
		public ONMMOGDAPLI material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::HMLPPHANHBI(3)]
		[BFDFEKGFJHK(null, 0)]
		[global::GMAFCNDDADC]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::HMLPPHANHBI(4)]
		[global::GMAFCNDDADC]
		[BFDFEKGFJHK(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AKEDCADBADK(PLGEILLLIPO.NONE, PLGEILLLIPO.COUNT)]
[HFDLLGMGDPK("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::BJGKKILKCHG(1, false)]
public enum PLGEILLLIPO
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[BFDFEKGFJHK("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[BFDFEKGFJHK("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[BFDFEKGFJHK("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[AKEDCADBADK(0, 4)]
[HFDLLGMGDPK("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::BJGKKILKCHG(1, false)]
public enum CGDEHGAIMNP
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
[AKEDCADBADK(COLDGNOCOJL.NONE, COLDGNOCOJL.ALL)]
[HFDLLGMGDPK("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::BJGKKILKCHG(1, false)]
public enum COLDGNOCOJL
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
[global::BJGKKILKCHG(1, false)]
[AKEDCADBADK(GMCCKJLLOHO.Off, GMCCKJLLOHO.COUNT)]
[HFDLLGMGDPK("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum GMCCKJLLOHO
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
[AKEDCADBADK(AKPHCGFFGOG.VERSION_0, AKPHCGFFGOG.CURRENT)]
[HFDLLGMGDPK("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::BJGKKILKCHG(1, false)]
[ADKFDMKNHPB]
public enum AKPHCGFFGOG : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[HFDLLGMGDPK("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::BJGKKILKCHG(1, false)]
[AKEDCADBADK(0, 127)]
public enum CPFCINEGKPG
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[MGIGJPBHAAA("Indicating it can be walked on and moved")]
	[BFDFEKGFJHK("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[BFDFEKGFJHK("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[BFDFEKGFJHK("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[BFDFEKGFJHK("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[BFDFEKGFJHK("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[BFDFEKGFJHK("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[BFDFEKGFJHK("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[BFDFEKGFJHK("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[BFDFEKGFJHK("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ADKFDMKNHPB]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ADKFDMKNHPB]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[HFDLLGMGDPK("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[global::BJGKKILKCHG(1, false)]
[AKEDCADBADK(0, PNFLHPNKBIO.ALL)]
[Flags]
public enum PNFLHPNKBIO
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
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[AKEDCADBADK(0, 2)]
public enum IAOPLFJAAKL
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
[AKEDCADBADK(BJILLFEBAPF.Pivot, BJILLFEBAPF.COUNT)]
[HFDLLGMGDPK("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::BJGKKILKCHG(1, false)]
public enum BJILLFEBAPF
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
[global::BJGKKILKCHG(1, false)]
[AKEDCADBADK(EOOLPFLHNKA.EnabledForRole, EOOLPFLHNKA.DisabledForRole)]
[HFDLLGMGDPK("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum EOOLPFLHNKA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[AKEDCADBADK(EIKOJILMNLL.NavMeshGenerator, EIKOJILMNLL.NavMeshBlocker)]
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum EIKOJILMNLL
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
[AKEDCADBADK(PJIBNPAPNBB.None, PJIBNPAPNBB.All)]
[HFDLLGMGDPK("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::BJGKKILKCHG(1, false)]
[Flags]
public enum PJIBNPAPNBB
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[HFDLLGMGDPK("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[AKEDCADBADK(0, IGNLIIMLDGD.COUNT)]
[global::BJGKKILKCHG(1, false)]
public enum IGNLIIMLDGD
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
public static class BPMGBJMCBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60A4590", Offset = "0x60A3390", VA = "0x1860A4590")]
	public static void DFGFKLLLOGA(this PJIBNPAPNBB MDPMDKOAJOO, IGNLIIMLDGD PHCJDGDKFOD, bool MCFOJMEHHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60A45D0", Offset = "0x60A33D0", VA = "0x1860A45D0")]
	public static bool IHLCMGOPPBI(this PJIBNPAPNBB MDPMDKOAJOO, IGNLIIMLDGD PHCJDGDKFOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60A45C0", Offset = "0x60A33C0", VA = "0x1860A45C0")]
	public static PJIBNPAPNBB IFNLHLCBMMP(this IGNLIIMLDGD PHCJDGDKFOD)
	{
		return default(PJIBNPAPNBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[AKEDCADBADK(PGDCJKHFMEC.NONE, PGDCJKHFMEC.COUNT)]
[Flags]
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum PGDCJKHFMEC
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
[HFDLLGMGDPK("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::BJGKKILKCHG(1, false)]
[AKEDCADBADK(1000, 8000)]
public enum HLKLEDFOFOB
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[BFDFEKGFJHK("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[BFDFEKGFJHK("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[BFDFEKGFJHK("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[BFDFEKGFJHK("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ADKFDMKNHPB]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[BFDFEKGFJHK("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[BFDFEKGFJHK("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[BFDFEKGFJHK("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[BFDFEKGFJHK("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[BFDFEKGFJHK("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[BFDFEKGFJHK("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[BFDFEKGFJHK("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[BFDFEKGFJHK("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[BFDFEKGFJHK("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[BFDFEKGFJHK("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[BFDFEKGFJHK("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[BFDFEKGFJHK("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[BFDFEKGFJHK("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[BFDFEKGFJHK("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[BFDFEKGFJHK("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[BFDFEKGFJHK("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[BFDFEKGFJHK("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[BFDFEKGFJHK("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[BFDFEKGFJHK("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[BFDFEKGFJHK("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[BFDFEKGFJHK("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[BFDFEKGFJHK("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[BFDFEKGFJHK("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[BFDFEKGFJHK("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[BFDFEKGFJHK("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[BFDFEKGFJHK("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[BFDFEKGFJHK("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[BFDFEKGFJHK("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[BFDFEKGFJHK("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[BFDFEKGFJHK("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[BFDFEKGFJHK("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[BFDFEKGFJHK("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[BFDFEKGFJHK("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[BFDFEKGFJHK("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[BFDFEKGFJHK("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[BFDFEKGFJHK("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[BFDFEKGFJHK("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[BFDFEKGFJHK("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[BFDFEKGFJHK("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[BFDFEKGFJHK("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[BFDFEKGFJHK("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ADKFDMKNHPB]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[BFDFEKGFJHK("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[BFDFEKGFJHK("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[BFDFEKGFJHK("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[BFDFEKGFJHK("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[BFDFEKGFJHK("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[BFDFEKGFJHK("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[BFDFEKGFJHK("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[BFDFEKGFJHK("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[BFDFEKGFJHK("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[BFDFEKGFJHK("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[BFDFEKGFJHK("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[BFDFEKGFJHK("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[BFDFEKGFJHK("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[BFDFEKGFJHK("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[BFDFEKGFJHK("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[BFDFEKGFJHK("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[BFDFEKGFJHK("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IJKPFECLFKO
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60A4920", Offset = "0x60A3720", VA = "0x1860A4920")]
	public static GKBGKNFOJCD GDPOIKMBFIJ(this HLKLEDFOFOB HCBFDEJPHHJ)
	{
		return default(GKBGKNFOJCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[AKEDCADBADK(0, 9)]
public enum GKBGKNFOJCD
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
public static class IPBNHJFHIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60A4940", Offset = "0x60A3740", VA = "0x1860A4940")]
	public static bool LIPHCHEBICP(this GKBGKNFOJCD POHACNLJDCA)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[global::LAKDGEIDLIN(1, false)]
	[HFDLLGMGDPK("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::DMLKKIHCNGA(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[global::HMLPPHANHBI(1)]
		[global::GMAFCNDDADC]
		public JIBPCJADACN shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("517224CC-0A79-4FE9-B048-53C37955D823")]
[AKEDCADBADK(-1, 38)]
public enum JIBPCJADACN
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
[HFDLLGMGDPK("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::BJGKKILKCHG(1, false)]
[AKEDCADBADK(0, 7)]
[Flags]
public enum GBJAGKOIPPB
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
[AKEDCADBADK(0, 7)]
[HFDLLGMGDPK("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::BJGKKILKCHG(1, false)]
public enum LCMOKIHLIHA
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
[AKEDCADBADK(0, 1)]
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("72742F9B-D48E-4CED-B403-444201FFEE66")]
public enum JMBALEIKDLP
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
[AKEDCADBADK(-2, 2)]
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum KKKPBECCFAO
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
[HFDLLGMGDPK("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[AKEDCADBADK(int.MinValue, int.MaxValue)]
[global::BJGKKILKCHG(1, false)]
public enum IJGADHLLDHP
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
[global::BJGKKILKCHG(1, false)]
[HFDLLGMGDPK("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[AKEDCADBADK(-1, 31)]
public enum ONMMOGDAPLI
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
[global::GFOGANADIGO(1, false)]
[HFDLLGMGDPK("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct KJBEJFJOMFJ : IComparable<KJBEJFJOMFJ>, IEquatable<KJBEJFJOMFJ>, DKBGDGLBDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[global::HMLPPHANHBI(1)]
	public uint HFMAGEAIFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[global::HMLPPHANHBI(2)]
	public uint AEEHGEPMKJP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint HJGBONJOAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60A4A30", Offset = "0x60A3830", VA = "0x1860A4A30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60A4DD0", Offset = "0x60A3BD0", VA = "0x1860A4DD0")]
	public KJBEJFJOMFJ(int HFMAGEAIFFN, int FOKMDKCMOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60A4DD0", Offset = "0x60A3BD0", VA = "0x1860A4DD0")]
	public KJBEJFJOMFJ(uint HFMAGEAIFFN, uint FOKMDKCMOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60A49C0", Offset = "0x60A37C0", VA = "0x1860A49C0")]
	public KJBEJFJOMFJ BMJKCBDMAOI(int LBJEFCOBKGF = 1)
	{
		return default(KJBEJFJOMFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60A4B80", Offset = "0x60A3980", VA = "0x1860A4B80")]
	public KJBEJFJOMFJ FNBIBNECJPE(int LBJEFCOBKGF = 1)
	{
		return default(KJBEJFJOMFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60A4C40", Offset = "0x60A3A40", VA = "0x1860A4C40")]
	public static KJBEJFJOMFJ JMNOJBLBBBE(KJBEJFJOMFJ LDPIALBNJEB, KJBEJFJOMFJ HLCIAKLFNHE)
	{
		return default(KJBEJFJOMFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60A4CC0", Offset = "0x60A3AC0", VA = "0x1860A4CC0")]
	private static uint MGJAICKKNHA(uint AOHIFIJNOBB, uint FNDBFMFAGPH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60A4AB0", Offset = "0x60A38B0", VA = "0x1860A4AB0", Slot = "4")]
	public int CompareTo(KJBEJFJOMFJ EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60A4AF0", Offset = "0x60A38F0", VA = "0x1860A4AF0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60A4CF0", Offset = "0x60A3AF0", VA = "0x1860A4CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60A4AD0", Offset = "0x60A38D0", VA = "0x1860A4AD0", Slot = "5")]
	public bool Equals(KJBEJFJOMFJ EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60A4BF0", Offset = "0x60A39F0", VA = "0x1860A4BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60A4A40", Offset = "0x60A3840", VA = "0x1860A4A40", Slot = "6")]
	public void CDDFPMJNNJO(ENIJCOAGKMD FCAJMDOFLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60A4950", Offset = "0x60A3750", VA = "0x1860A4950", Slot = "7")]
	public void APHAODHFANA(IINBKFKJJKB INLIFCPEGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27370E0", Offset = "0x2735EE0", VA = "0x1827370E0")]
	public static bool EILLJGMDDAM(KJBEJFJOMFJ LDPIALBNJEB, KJBEJFJOMFJ HLCIAKLFNHE)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[HFDLLGMGDPK("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::GFOGANADIGO(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, DKBGDGLBDGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[global::HMLPPHANHBI(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public static NetworkGuid CCJKPBOFOJB(Guid MAAFBDMNKAP)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x60A4F50", Offset = "0x60A3D50", VA = "0x1860A4F50", Slot = "4")]
		public bool Equals(NetworkGuid EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
		public int CompareTo(NetworkGuid EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60A4E90", Offset = "0x60A3C90", VA = "0x1860A4E90", Slot = "6")]
		public void CDDFPMJNNJO(ENIJCOAGKMD FCAJMDOFLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60A4E20", Offset = "0x60A3C20", VA = "0x1860A4E20", Slot = "7")]
		public void APHAODHFANA(IINBKFKJJKB INLIFCPEGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60A4F80", Offset = "0x60A3D80", VA = "0x1860A4F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[HFDLLGMGDPK("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::GFOGANADIGO(1, false)]
public struct PDMENGFPFOJ : DKBGDGLBDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[global::HMLPPHANHBI(1)]
	public bool IBCOHIKFCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[global::HMLPPHANHBI(2)]
	public float3 DOLMJINKFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[global::HMLPPHANHBI(3)]
	public float3 CAOKJCHFBAF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60A5190", Offset = "0x60A3F90", VA = "0x1860A5190")]
	public PDMENGFPFOJ(float BABEKEPDHDJ, float OGLEKPLDGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60A5140", Offset = "0x60A3F40", VA = "0x1860A5140", Slot = "4")]
	public void CDDFPMJNNJO(ENIJCOAGKMD FCAJMDOFLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60A50D0", Offset = "0x60A3ED0", VA = "0x1860A50D0", Slot = "5")]
	public void APHAODHFANA(IINBKFKJJKB INLIFCPEGKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[HFDLLGMGDPK("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::GFOGANADIGO(1, false)]
public struct FECIKOMCBBA : DKBGDGLBDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[global::HMLPPHANHBI(1)]
	public float KJNEGJGPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[global::HMLPPHANHBI(2)]
	public int BFILAEKMJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[global::HMLPPHANHBI(3)]
	public LCMOKIHLIHA MDPMDKOAJOO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HIMLALOJJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60A48A0", Offset = "0x60A36A0", VA = "0x1860A48A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60A48D0", Offset = "0x60A36D0", VA = "0x1860A48D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NJHOEKCLDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60A4830", Offset = "0x60A3630", VA = "0x1860A4830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60A48B0", Offset = "0x60A36B0", VA = "0x1860A48B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MJHELMADIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60A48F0", Offset = "0x60A36F0", VA = "0x1860A48F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60A4900", Offset = "0x60A3700", VA = "0x1860A4900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60A47E0", Offset = "0x60A35E0", VA = "0x1860A47E0", Slot = "5")]
	public void APHAODHFANA(IINBKFKJJKB INLIFCPEGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60A4840", Offset = "0x60A3640", VA = "0x1860A4840", Slot = "4")]
	public void CDDFPMJNNJO(ENIJCOAGKMD FCAJMDOFLNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class BJLIGLPGGNP : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class ODBDAAGLBKC : Property<RRObjectPrefabData, HLKLEDFOFOB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string PAHJIBDDKIP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x60A50A0", Offset = "0x60A3EA0", VA = "0x1860A50A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool OJMEMOAMNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60A4FB0", Offset = "0x60A3DB0", VA = "0x1860A4FB0")]
		public ODBDAAGLBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1395730", Offset = "0x1394530", VA = "0x181395730", Slot = "14")]
		public override HLKLEDFOFOB GetValue(RRObjectPrefabData LANMIEEPANH)
		{
			return default(HLKLEDFOFOB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60A4FA0", Offset = "0x60A3DA0", VA = "0x1860A4FA0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData LANMIEEPANH, HLKLEDFOFOB MAEBFBHFPDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60A4410", Offset = "0x60A3210", VA = "0x1860A4410")]
	public BJLIGLPGGNP()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60A51C0", Offset = "0x60A3FC0", VA = "0x1860A51C0")]
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
