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
public interface IMDCEKFCFHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity GCAHNCHIFNA
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
	[global::GAOFLKOKEBA(1, false)]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(11505792609904010668uL, 0u)]
	[MNHIKHMJILC("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::KBHCIGGOPHL("new float3(float.NaN)")]
		[global::JBILIDMDGLK(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3D10110", Offset = "0x3D0F310", VA = "0x183D10110")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61AFD20", Offset = "0x61AEF20", VA = "0x1861AFD20")]
		public static AuthoredLocalPoseData LOOIAEAGNBK(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[CompilerGenerated]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[global::FNOLIJLLCFM(9088562008033959482uL, 0u)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::KBHCIGGOPHL(1f)]
		[global::JBILIDMDGLK(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::FNOLIJLLCFM(10137300772124140051uL, 0u)]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	public struct AuthoredParentData : IComponentData, IMDCEKFCFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static AuthoredParentData LOOIAEAGNBK(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61AFD40", Offset = "0x61AEF40", VA = "0x1861AFD40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NCNDJOJPBBN : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::JBILIDMDGLK(2)]
		[global::KBHCIGGOPHL(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::JBILIDMDGLK(3)]
		[global::KBHCIGGOPHL(CBEOBLKLLNC.EnabledForRole)]
		public CBEOBLKLLNC filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[global::GAOFLKOKEBA(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(8594223769175916906uL, 0u)]
	[MNHIKHMJILC("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::JBILIDMDGLK(2)]
		[global::KBHCIGGOPHL]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::FNOLIJLLCFM(780699438743496039uL, 0u)]
	[global::GAOFLKOKEBA(1, false)]
	[CompilerGenerated]
	[MNHIKHMJILC("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::KBHCIGGOPHL(true)]
		[global::JBILIDMDGLK(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[global::GAOFLKOKEBA(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[MNHIKHMJILC("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MNHIKHMJILC("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::FNOLIJLLCFM(11853296779717712500uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[global::GAOFLKOKEBA(1, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	[MNHIKHMJILC("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::GAOFLKOKEBA(1, false)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::FNOLIJLLCFM(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E323B0", Offset = "0x1E315B0", VA = "0x181E323B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		internal EntityBundlePartId(uint JNIKIHKLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		internal uint GPDDKOLGBON()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5400", Offset = "0x8A4600", VA = "0x1808A5400", Slot = "4")]
		public bool Equals(EntityBundlePartId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61AFEA0", Offset = "0x61AF0A0", VA = "0x1861AFEA0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x94C1B0", Offset = "0x94B3B0", VA = "0x18094C1B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x18A2530", Offset = "0x18A1730", VA = "0x1818A2530")]
		public static bool AIPCENMEJFE(EntityBundlePartId JPEEHDCLFEK, EntityBundlePartId HGMCBKHHGFH)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[global::FNOLIJLLCFM(11104975410044731874uL, 0u)]
	[JJENICFIOEL("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(AMPNCKEABLE.IsDynamicEnvironment)]
		[PJOMCIADGJC(null, 0)]
		public AMPNCKEABLE collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NEODMCLCPMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum HPJCLGKKEMH
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
	public enum EPICKGBIKKB
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
	[Cpp2IlInjected.Address(RVA = "0x61B01F0", Offset = "0x61AF3F0", VA = "0x1861B01F0")]
	public static (HPJCLGKKEMH, EPICKGBIKKB) CKEJPPEBPBP(this AMPNCKEABLE AGBFFDLLICJ)
	{
		return default((HPJCLGKKEMH, EPICKGBIKKB));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::FNOLIJLLCFM(2914713536404587710uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[global::GAOFLKOKEBA(1, false)]
	[CompilerGenerated]
	[JJENICFIOEL("Container", 0)]
	[MNHIKHMJILC("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(IFHCIJGELLJ.Children)]
		[PJOMCIADGJC(null, 0)]
		public IFHCIJGELLJ collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[MNHIKHMJILC("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[JJENICFIOEL("Container", 0)]
	[global::GAOFLKOKEBA(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::KBHCIGGOPHL(DMFJIBOHKNI.DEFAULT)]
		[global::JBILIDMDGLK(1)]
		[PJOMCIADGJC(null, 0)]
		public DMFJIBOHKNI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::FNOLIJLLCFM(1094837642118998916uL, 0u)]
	[JJENICFIOEL("Container", 0)]
	[MNHIKHMJILC("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::GAOFLKOKEBA(1, false)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[PJOMCIADGJC(null, 0)]
		[global::KBHCIGGOPHL(0f)]
		[global::JBILIDMDGLK(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[JJENICFIOEL("Container", 0)]
	[global::FNOLIJLLCFM(13657791279235747653uL, 0u)]
	[MNHIKHMJILC("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::GAOFLKOKEBA(1, false)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[PJOMCIADGJC(null, 0)]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::GAOFLKOKEBA(1, false)]
	[CompilerGenerated]
	[MNHIKHMJILC("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[JJENICFIOEL("Container", 0)]
	[global::FNOLIJLLCFM(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		[PJOMCIADGJC(null, 0)]
		public HFGDBBHGGDC grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[global::FNOLIJLLCFM(16485879999901987510uL, 0u)]
	[MNHIKHMJILC("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::GAOFLKOKEBA(1, false)]
	[JJENICFIOEL("Container", 0)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(OIOGKNHCGED.NavMeshGenerator)]
		[PJOMCIADGJC(null, 0)]
		public OIOGKNHCGED mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[MNHIKHMJILC("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::GAOFLKOKEBA(1, false)]
	[global::FNOLIJLLCFM(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[global::GAOFLKOKEBA(1, false)]
	[global::FNOLIJLLCFM(5115014870530256079uL, 0u)]
	[MNHIKHMJILC("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(14429493078606832166uL, 0u)]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[MNHIKHMJILC("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	[global::GAOFLKOKEBA(1, false)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::FNOLIJLLCFM(12111354511484844847uL, 0u)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	public struct ParentData : IComponentData, IMDCEKFCFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, IMDCEKFCFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct EHOGAHIIHIB : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(1950029632769634832uL, 0u)]
	[MNHIKHMJILC("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::GAOFLKOKEBA(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public OICAAOIBBBA order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static SiblingSortOrderData LOOIAEAGNBK(OICAAOIBBBA value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61B0590", Offset = "0x61AF790", VA = "0x1861B0590", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[MNHIKHMJILC("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::GAOFLKOKEBA(1, false)]
	[global::FNOLIJLLCFM(15012400804589552708uL, 0u)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::GAOFLKOKEBA(5, false)]
	[global::FNOLIJLLCFM(16541670854338945984uL, 0u)]
	[JJENICFIOEL("Object", 0)]
	[CompilerGenerated]
	[MNHIKHMJILC("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::KBHCIGGOPHL("new ScaleRestriction(1,1)")]
		[global::JBILIDMDGLK(2)]
		public ACPNJIFFEJM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::KBHCIGGOPHL("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::JBILIDMDGLK(3)]
		[PJOMCIADGJC(null, 0)]
		public ENENJKLEDNA userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::JBILIDMDGLK(4)]
		[PJOMCIADGJC(null, 0)]
		[global::KBHCIGGOPHL(NHMPFBPMHDB.Default)]
		public NHMPFBPMHDB circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::KBHCIGGOPHL("ObjectPolicyEnumFlags.Default")]
		[global::JBILIDMDGLK(1)]
		public JHPCPPLHOMJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(17708500325183871236uL, 0u)]
	[MNHIKHMJILC("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::GAOFLKOKEBA(1, false)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static PlayerScopeData LOOIAEAGNBK(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::FNOLIJLLCFM(16642773407304133105uL, 0u)]
	[JJENICFIOEL("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[PJOMCIADGJC(null, 0)]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(10537432342869025182uL, 0u)]
	[MNHIKHMJILC("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[global::GAOFLKOKEBA(1, false)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(MKMLIFLADIO.None)]
		public MKMLIFLADIO flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x61B0BE0", Offset = "0x61AFDE0", VA = "0x1861B0BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x61B0BF0", Offset = "0x61AFDF0", VA = "0x1861B0BF0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::FNOLIJLLCFM(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::GAOFLKOKEBA(1, false)]
	[CompilerGenerated]
	[MNHIKHMJILC("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public EHKIBNJBFBB shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::FNOLIJLLCFM(5298506180484533559uL, 0u)]
	[global::GAOFLKOKEBA(1, false)]
	[CompilerGenerated]
	[MNHIKHMJILC("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public OICAAOIBBBA order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static SplinePointOrderData LOOIAEAGNBK(OICAAOIBBBA value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::FNOLIJLLCFM(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::FNOLIJLLCFM(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::FNOLIJLLCFM(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[MNHIKHMJILC("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::GAOFLKOKEBA(1, false)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::KBHCIGGOPHL("new quaternion(0, 0, 0, 1f)")]
		[global::JBILIDMDGLK(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::FNOLIJLLCFM(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[MNHIKHMJILC("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::GAOFLKOKEBA(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[global::FNOLIJLLCFM(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public KJGIJINEINK parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::GAOFLKOKEBA(1, false)]
	[MNHIKHMJILC("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(10026670690793008625uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(NICHABCIKOD.CURRENT)]
		public NICHABCIKOD version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[global::FNOLIJLLCFM(12332323170023439017uL, 0u)]
	[CompilerGenerated]
	[global::GAOFLKOKEBA(2, false)]
	[global::MNMBNGMDBNP(new int[] { 1 })]
	[MNHIKHMJILC("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::JBILIDMDGLK(2)]
		[global::KBHCIGGOPHL(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::JBILIDMDGLK(3)]
		[global::KBHCIGGOPHL(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[MNHIKHMJILC("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[global::MOFBKOJMPCG(KAFDABLICPN.MIN, KAFDABLICPN.ALL)]
[global::OLMDEKEBGBK(1, false)]
public enum KAFDABLICPN
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
	[MNHIKHMJILC("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[global::GAOFLKOKEBA(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::KBHCIGGOPHL(KAFDABLICPN.UseDefaultVisualEffects)]
		[global::JBILIDMDGLK(2)]
		public KAFDABLICPN toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	[global::GAOFLKOKEBA(1, false)]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[MNHIKHMJILC("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[global::JBILIDMDGLK(3)]
		[global::KBHCIGGOPHL]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::GAOFLKOKEBA(2, false)]
	[MNHIKHMJILC("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[global::KBHCIGGOPHL("new float3(1)")]
		[global::JBILIDMDGLK(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[MNHIKHMJILC("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::GAOFLKOKEBA(1, false)]
	[global::FNOLIJLLCFM(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[global::JBILIDMDGLK(1)]
		[PJOMCIADGJC(null, 0)]
		[global::KBHCIGGOPHL("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[global::JBILIDMDGLK(2)]
		[global::KBHCIGGOPHL]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D10110", Offset = "0x3D0F310", VA = "0x183D10110")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61AFD20", Offset = "0x61AEF20", VA = "0x1861AFD20")]
		public static RigidTransform LOOIAEAGNBK(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61AFD20", Offset = "0x61AEF20", VA = "0x1861AFD20")]
		public static LocalPoseData LOOIAEAGNBK(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IIPOLKCNOGL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static RigidTransform ANDJCMJMKJJ(this LocalPoseData NICEPFIEJED)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[global::FNOLIJLLCFM(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[MNHIKHMJILC("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::GAOFLKOKEBA(1, false)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::KBHCIGGOPHL(1f)]
		[global::JBILIDMDGLK(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::FNOLIJLLCFM(5730545663584378555uL, 0u)]
	[MNHIKHMJILC("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::GAOFLKOKEBA(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		public JGFBELBNDNB transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::JBILIDMDGLK(2)]
		[global::KBHCIGGOPHL]
		public ONDFFKKBNED transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[global::GAOFLKOKEBA(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(798350452111942523uL, 0u)]
	[global::KCFIBLLLELM]
	[MNHIKHMJILC("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public FHHKGBHDBDG prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[global::GAOFLKOKEBA(2, false)]
	[MNHIKHMJILC("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::KBHCIGGOPHL(false)]
		[global::JBILIDMDGLK(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[MNHIKHMJILC("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::GAOFLKOKEBA(1, false)]
	[global::FNOLIJLLCFM(1591066774816564574uL, 0u)]
	[CompilerGenerated]
	[JJENICFIOEL("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::JBILIDMDGLK(1)]
		[global::KBHCIGGOPHL]
		[PJOMCIADGJC(null, 0)]
		public PGGNMAEFFLG color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[global::JBILIDMDGLK(2)]
		[global::KBHCIGGOPHL]
		[PJOMCIADGJC(null, 0)]
		public FKDILDJBONM material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[global::JBILIDMDGLK(3)]
		[PJOMCIADGJC(null, 0)]
		[global::KBHCIGGOPHL]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[global::KBHCIGGOPHL]
		[PJOMCIADGJC(null, 0)]
		[global::JBILIDMDGLK(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[global::MOFBKOJMPCG(NHMPFBPMHDB.NONE, NHMPFBPMHDB.COUNT)]
[MNHIKHMJILC("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::OLMDEKEBGBK(1, false)]
public enum NHMPFBPMHDB
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[PJOMCIADGJC("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[PJOMCIADGJC("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[PJOMCIADGJC("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(0, 4)]
[MNHIKHMJILC("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum JPAALNLJBDB
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
[global::MOFBKOJMPCG(BJLCDICMPPM.NONE, BJLCDICMPPM.ALL)]
[MNHIKHMJILC("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::OLMDEKEBGBK(1, false)]
public enum BJLCDICMPPM
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
[global::MOFBKOJMPCG(IFHCIJGELLJ.Off, IFHCIJGELLJ.COUNT)]
[MNHIKHMJILC("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::OLMDEKEBGBK(1, false)]
public enum IFHCIJGELLJ
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
[OGNDAEAEAGI]
[MNHIKHMJILC("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::MOFBKOJMPCG(NICHABCIKOD.VERSION_0, NICHABCIKOD.CURRENT)]
[global::OLMDEKEBGBK(1, false)]
public enum NICHABCIKOD : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[MNHIKHMJILC("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::MOFBKOJMPCG(0, 127)]
[global::OLMDEKEBGBK(1, false)]
public enum AMPNCKEABLE
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[PJOMCIADGJC("Dynamic (Environment)", 0)]
	[ENAPPGHIIKB("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[PJOMCIADGJC("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[PJOMCIADGJC("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[PJOMCIADGJC("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[PJOMCIADGJC("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[PJOMCIADGJC("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[PJOMCIADGJC("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[PJOMCIADGJC("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[PJOMCIADGJC("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[OGNDAEAEAGI]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[OGNDAEAEAGI]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Flags]
[global::OLMDEKEBGBK(1, false)]
[MNHIKHMJILC("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[global::MOFBKOJMPCG(0, DMFJIBOHKNI.ALL)]
public enum DMFJIBOHKNI
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
[MNHIKHMJILC("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::MOFBKOJMPCG(0, 2)]
[global::OLMDEKEBGBK(1, false)]
public enum EHKIBNJBFBB
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
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(HFGDBBHGGDC.Pivot, HFGDBBHGGDC.COUNT)]
[MNHIKHMJILC("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum HFGDBBHGGDC
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
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(CBEOBLKLLNC.EnabledForRole, CBEOBLKLLNC.DisabledForRole)]
[MNHIKHMJILC("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum CBEOBLKLLNC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[global::MOFBKOJMPCG(OIOGKNHCGED.NavMeshGenerator, OIOGKNHCGED.NavMeshBlocker)]
[global::OLMDEKEBGBK(1, false)]
[MNHIKHMJILC("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum OIOGKNHCGED
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
[global::OLMDEKEBGBK(1, false)]
[Flags]
[MNHIKHMJILC("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::MOFBKOJMPCG(JHPCPPLHOMJ.None, JHPCPPLHOMJ.All)]
public enum JHPCPPLHOMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(0, MLDEANCMBFE.COUNT)]
[MNHIKHMJILC("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum MLDEANCMBFE
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
public static class APPPGLAJGKK
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61AFCC0", Offset = "0x61AEEC0", VA = "0x1861AFCC0")]
	public static void BHMONLIGLCO(this JHPCPPLHOMJ KIAPHNPFBHE, MLDEANCMBFE LMDABPKPNKH, bool COENLOODJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61AFD00", Offset = "0x61AEF00", VA = "0x1861AFD00")]
	public static bool MCJNJJGCDPC(this JHPCPPLHOMJ KIAPHNPFBHE, MLDEANCMBFE LMDABPKPNKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61AFCF0", Offset = "0x61AEEF0", VA = "0x1861AFCF0")]
	public static JHPCPPLHOMJ CKKGOBOBPIH(this MLDEANCMBFE LMDABPKPNKH)
	{
		return default(JHPCPPLHOMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[global::OLMDEKEBGBK(1, false)]
[MNHIKHMJILC("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
[global::MOFBKOJMPCG(ENENJKLEDNA.NONE, ENENJKLEDNA.COUNT)]
public enum ENENJKLEDNA
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
[global::OLMDEKEBGBK(1, false)]
[MNHIKHMJILC("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::MOFBKOJMPCG(1000, 8000)]
public enum FHHKGBHDBDG
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[PJOMCIADGJC("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[PJOMCIADGJC("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[PJOMCIADGJC("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[PJOMCIADGJC("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[OGNDAEAEAGI]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[PJOMCIADGJC("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[PJOMCIADGJC("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[PJOMCIADGJC("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[PJOMCIADGJC("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[PJOMCIADGJC("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[PJOMCIADGJC("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[PJOMCIADGJC("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[PJOMCIADGJC("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[PJOMCIADGJC("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[PJOMCIADGJC("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[PJOMCIADGJC("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[PJOMCIADGJC("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[PJOMCIADGJC("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[PJOMCIADGJC("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[PJOMCIADGJC("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[PJOMCIADGJC("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[PJOMCIADGJC("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[PJOMCIADGJC("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[PJOMCIADGJC("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[PJOMCIADGJC("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[PJOMCIADGJC("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[PJOMCIADGJC("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[PJOMCIADGJC("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[PJOMCIADGJC("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[PJOMCIADGJC("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[PJOMCIADGJC("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[PJOMCIADGJC("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[PJOMCIADGJC("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[PJOMCIADGJC("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[PJOMCIADGJC("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[PJOMCIADGJC("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[PJOMCIADGJC("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[PJOMCIADGJC("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[PJOMCIADGJC("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[PJOMCIADGJC("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[PJOMCIADGJC("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[PJOMCIADGJC("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[PJOMCIADGJC("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[PJOMCIADGJC("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[PJOMCIADGJC("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[PJOMCIADGJC("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[OGNDAEAEAGI]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[PJOMCIADGJC("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[PJOMCIADGJC("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[PJOMCIADGJC("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[PJOMCIADGJC("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[PJOMCIADGJC("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[PJOMCIADGJC("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[PJOMCIADGJC("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[PJOMCIADGJC("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[PJOMCIADGJC("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[PJOMCIADGJC("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[PJOMCIADGJC("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[PJOMCIADGJC("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[PJOMCIADGJC("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[PJOMCIADGJC("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[PJOMCIADGJC("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[PJOMCIADGJC("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[PJOMCIADGJC("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class DONALNGINBF
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61AFD50", Offset = "0x61AEF50", VA = "0x1861AFD50")]
	public static KEHJAHBCGEJ LIJPLHCDJBF(this FHHKGBHDBDG GEFIJDDLJAH)
	{
		return default(KEHJAHBCGEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[MNHIKHMJILC("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::MOFBKOJMPCG(0, 9)]
[global::OLMDEKEBGBK(1, false)]
public enum KEHJAHBCGEJ
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
public static class NAONEMHBODL
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61B01E0", Offset = "0x61AF3E0", VA = "0x1861B01E0")]
	public static bool KELBFIADBDI(this KEHJAHBCGEJ JKKGCIBOIGN)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::FNOLIJLLCFM(8060729269509364919uL, 0u)]
	[MNHIKHMJILC("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::GAOFLKOKEBA(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[global::KBHCIGGOPHL]
		[global::JBILIDMDGLK(1)]
		public OONAHILDADH shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[global::OLMDEKEBGBK(1, false)]
[MNHIKHMJILC("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::MOFBKOJMPCG(-1, 38)]
public enum OONAHILDADH
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
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(0, 7)]
[MNHIKHMJILC("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[Flags]
public enum MKMLIFLADIO
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
[MNHIKHMJILC("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[Flags]
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(0, 7)]
public enum KBFPCGKHHLC
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
[MNHIKHMJILC("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(0, 1)]
[Flags]
public enum JGFBELBNDNB
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
[MNHIKHMJILC("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::MOFBKOJMPCG(-2, 2)]
[global::OLMDEKEBGBK(1, false)]
public enum ONDFFKKBNED
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
[MNHIKHMJILC("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::OLMDEKEBGBK(1, false)]
[global::MOFBKOJMPCG(int.MinValue, int.MaxValue)]
public enum PGGNMAEFFLG
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
[global::MOFBKOJMPCG(-1, 31)]
[MNHIKHMJILC("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::OLMDEKEBGBK(1, false)]
public enum FKDILDJBONM
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
[global::IDMEEKMMKMD(1, false)]
[MNHIKHMJILC("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct OICAAOIBBBA : IComparable<OICAAOIBBBA>, IEquatable<OICAAOIBBBA>, EDPFHBBGDGC
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly OICAAOIBBBA CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	[global::JBILIDMDGLK(1)]
	public uint GOPGFFNFADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[global::JBILIDMDGLK(2)]
	public uint IIFKAHMLFKB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint KPEBEHPHCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61B08D0", Offset = "0x61AFAD0", VA = "0x1861B08D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61B09C0", Offset = "0x61AFBC0", VA = "0x1861B09C0")]
	public OICAAOIBBBA(int GOPGFFNFADC, int DFNFNJFJGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61B09C0", Offset = "0x61AFBC0", VA = "0x1861B09C0")]
	public OICAAOIBBBA(uint GOPGFFNFADC, uint DFNFNJFJGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61B0600", Offset = "0x61AF800", VA = "0x1861B0600")]
	public OICAAOIBBBA HOGJNMKLILP(int BJPGLMJPACN = 1)
	{
		return default(OICAAOIBBBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61B0690", Offset = "0x61AF890", VA = "0x1861B0690")]
	public OICAAOIBBBA JFIFABNDNAB(int BJPGLMJPACN = 1)
	{
		return default(OICAAOIBBBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61B0720", Offset = "0x61AF920", VA = "0x1861B0720")]
	public static OICAAOIBBBA KAEAICPDIKH(OICAAOIBBBA EBKLEGBLPGD, OICAAOIBBBA JCPNHMOLDGI)
	{
		return default(OICAAOIBBBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61B0830", Offset = "0x61AFA30", VA = "0x1861B0830")]
	private static uint OBHEBEGOGCO(uint JPEEHDCLFEK, uint HGMCBKHHGFH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61B04E0", Offset = "0x61AF6E0", VA = "0x1861B04E0", Slot = "4")]
	public int CompareTo(OICAAOIBBBA NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61B0500", Offset = "0x61AF700", VA = "0x1861B0500", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61B08E0", Offset = "0x61AFAE0", VA = "0x1861B08E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61B0590", Offset = "0x61AF790", VA = "0x1861B0590", Slot = "5")]
	public bool Equals(OICAAOIBBBA NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61B05B0", Offset = "0x61AF7B0", VA = "0x1861B05B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61B0860", Offset = "0x61AFA60", VA = "0x1861B0860", Slot = "6")]
	public void OHDBDPJBHPM(ENKDIFGMEIN KPDGEKKKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61B07C0", Offset = "0x61AF9C0", VA = "0x1861B07C0", Slot = "7")]
	public void LKMADFBDLGL(AEJGALJMLND CAMFAGAEHOD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x27218C0", Offset = "0x2720AC0", VA = "0x1827218C0")]
	public static bool AIPCENMEJFE(OICAAOIBBBA EBKLEGBLPGD, OICAAOIBBBA JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61B07A0", Offset = "0x61AF9A0", VA = "0x1861B07A0")]
	public static bool KEIKIALHENC(OICAAOIBBBA EBKLEGBLPGD, OICAAOIBBBA JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61B0670", Offset = "0x61AF870", VA = "0x1861B0670")]
	public static bool IOJMJLOPDNE(OICAAOIBBBA EBKLEGBLPGD, OICAAOIBBBA JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61B0700", Offset = "0x61AF900", VA = "0x1861B0700")]
	public static bool JKCKFAAOGBA(OICAAOIBBBA EBKLEGBLPGD, OICAAOIBBBA JCPNHMOLDGI)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[global::IDMEEKMMKMD(1, false)]
	[MNHIKHMJILC("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, EDPFHBBGDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[global::JBILIDMDGLK(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public static NetworkGuid LOOIAEAGNBK(Guid IKOKEKHMFKH)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61B0360", Offset = "0x61AF560", VA = "0x1861B0360", Slot = "4")]
		public bool Equals(NetworkGuid NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
		public int CompareTo(NetworkGuid NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x61B0400", Offset = "0x61AF600", VA = "0x1861B0400", Slot = "6")]
		public void OHDBDPJBHPM(ENKDIFGMEIN KPDGEKKKOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61B0390", Offset = "0x61AF590", VA = "0x1861B0390", Slot = "7")]
		public void LKMADFBDLGL(AEJGALJMLND CAMFAGAEHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61B04C0", Offset = "0x61AF6C0", VA = "0x1861B04C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MNHIKHMJILC("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::IDMEEKMMKMD(1, false)]
public struct ACPNJIFFEJM : EDPFHBBGDGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[global::JBILIDMDGLK(1)]
	public bool FFABKOCEGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[global::JBILIDMDGLK(2)]
	public float3 AFPEGLFFEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[global::JBILIDMDGLK(3)]
	public float3 HDMMDHOKOLM;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x61AFC90", Offset = "0x61AEE90", VA = "0x1861AFC90")]
	public ACPNJIFFEJM(float PMCJJGJGOKB, float OEEFGEJNCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x61AFC40", Offset = "0x61AEE40", VA = "0x1861AFC40", Slot = "4")]
	public void OHDBDPJBHPM(ENKDIFGMEIN KPDGEKKKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61AFBD0", Offset = "0x61AEDD0", VA = "0x1861AFBD0", Slot = "5")]
	public void LKMADFBDLGL(AEJGALJMLND CAMFAGAEHOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::IDMEEKMMKMD(1, false)]
[MNHIKHMJILC("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct KJGIJINEINK : EDPFHBBGDGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[global::JBILIDMDGLK(1)]
	public float HANIJLKEGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[global::JBILIDMDGLK(2)]
	public int JNNAONMNDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[global::JBILIDMDGLK(3)]
	public KBFPCGKHHLC KIAPHNPFBHE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BKGCDEAIOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61B0020", Offset = "0x61AF220", VA = "0x1861B0020")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61AFF30", Offset = "0x61AF130", VA = "0x1861AFF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OCMIENECDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61AFF20", Offset = "0x61AF120", VA = "0x1861AFF20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61AFF50", Offset = "0x61AF150", VA = "0x1861AFF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EKJFKBHHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x61B0050", Offset = "0x61AF250", VA = "0x1861B0050")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x61B0030", Offset = "0x61AF230", VA = "0x1861B0030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61AFF70", Offset = "0x61AF170", VA = "0x1861AFF70", Slot = "5")]
	public void LKMADFBDLGL(AEJGALJMLND CAMFAGAEHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61AFFC0", Offset = "0x61AF1C0", VA = "0x1861AFFC0", Slot = "4")]
	public void OHDBDPJBHPM(ENKDIFGMEIN KPDGEKKKOHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class LNKGJHCELEE : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class EFNIPBKNNBD : Property<RRObjectPrefabData, FHHKGBHDBDG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61AFE70", Offset = "0x61AF070", VA = "0x1861AFE70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61AFD80", Offset = "0x61AEF80", VA = "0x1861AFD80")]
		public EFNIPBKNNBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1408570", Offset = "0x1407770", VA = "0x181408570", Slot = "14")]
		public override FHHKGBHDBDG GetValue(RRObjectPrefabData BFOBHJGOFNM)
		{
			return default(FHHKGBHDBDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61AFD70", Offset = "0x61AEF70", VA = "0x1861AFD70", Slot = "15")]
		public override void SetValue(RRObjectPrefabData BFOBHJGOFNM, FHHKGBHDBDG NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61B0060", Offset = "0x61AF260", VA = "0x1861B0060")]
	public LNKGJHCELEE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61B0A10", Offset = "0x61AFC10", VA = "0x1861B0A10")]
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
