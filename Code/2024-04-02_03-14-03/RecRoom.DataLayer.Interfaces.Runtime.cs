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
public interface CDFIGFDGHPM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity GCCNOBLJLPD
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
	[global::MELEPFEPFLB(11505792609904010668uL, 0u)]
	[global::OCLFPHHJGAJ(1, false)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[KELCBHLJPIL("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::GHEJGODHDFC("new float3(float.NaN)")]
		[global::LFHHNDGABIE(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3BF58C0", Offset = "0x3BF44C0", VA = "0x183BF58C0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60E9B00", Offset = "0x60E8700", VA = "0x1860E9B00")]
		public static AuthoredLocalPoseData PFOIJBDHIHJ(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::MELEPFEPFLB(9088562008033959482uL, 0u)]
	[KELCBHLJPIL("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::GHEJGODHDFC(1f)]
		[global::LFHHNDGABIE(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[global::MELEPFEPFLB(10137300772124140051uL, 0u)]
	[KELCBHLJPIL("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::OCLFPHHJGAJ(1, false)]
	public struct AuthoredParentData : IComponentData, CDFIGFDGHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
		public static AuthoredParentData PFOIJBDHIHJ(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60E9B20", Offset = "0x60E8720", VA = "0x1860E9B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KKBECJNHODD : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[KELCBHLJPIL("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::GHEJGODHDFC(false)]
		[global::LFHHNDGABIE(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::GHEJGODHDFC(LNIHFCONKNN.EnabledForRole)]
		[global::LFHHNDGABIE(3)]
		public LNIHFCONKNN filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[KELCBHLJPIL("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[global::OCLFPHHJGAJ(1, false)]
	[global::MELEPFEPFLB(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::LFHHNDGABIE(2)]
		[global::GHEJGODHDFC]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	[global::MELEPFEPFLB(780699438743496039uL, 0u)]
	[KELCBHLJPIL("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::GHEJGODHDFC(true)]
		[global::LFHHNDGABIE(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::GHEJGODHDFC(-1)]
		[global::LFHHNDGABIE(1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[KELCBHLJPIL("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[global::OCLFPHHJGAJ(1, false)]
	[global::MELEPFEPFLB(11853296779717712500uL, 0u)]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[global::MELEPFEPFLB(8536678595025273356uL, 0u)]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E22BD0", Offset = "0x1E217D0", VA = "0x181E22BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0")]
		internal EntityBundlePartId(uint JPCJHDLLDBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		internal uint NENIJEDPANB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88AD80", Offset = "0x889980", VA = "0x18088AD80", Slot = "4")]
		public bool Equals(EntityBundlePartId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60E9D70", Offset = "0x60E8970", VA = "0x1860E9D70", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x93DDF0", Offset = "0x93C9F0", VA = "0x18093DDF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1855B40", Offset = "0x1854740", VA = "0x181855B40")]
		public static bool FKDJFADGJBA(EntityBundlePartId PKCAMDKHNLN, EntityBundlePartId ECIMPLOCMKE)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[CompilerGenerated]
	[FCCBHHJJMOG("Container", 0)]
	[global::MELEPFEPFLB(11104975410044731874uL, 0u)]
	[KELCBHLJPIL("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::OCLFPHHJGAJ(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[EKKCIPEDFDF(null, 0)]
		[global::GHEJGODHDFC(GFIOKLOKKHG.IsDynamicEnvironment)]
		[global::LFHHNDGABIE(1)]
		public GFIOKLOKKHG collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HOPMBADPFGH
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum CNCJJLHBNKF
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
	public enum EGNFJIJMMDF
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
	[Cpp2IlInjected.Address(RVA = "0x60EA2C0", Offset = "0x60E8EC0", VA = "0x1860EA2C0")]
	public static (CNCJJLHBNKF, EGNFJIJMMDF) MNFPEJMEJFM(this GFIOKLOKKHG LCLEPNJJEPM)
	{
		return default((CNCJJLHBNKF, EGNFJIJMMDF));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[FCCBHHJJMOG("Container", 0)]
	[global::MELEPFEPFLB(2914713536404587710uL, 0u)]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	[KELCBHLJPIL("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[EKKCIPEDFDF(null, 0)]
		[global::GHEJGODHDFC(EOFCEFPOPKM.Children)]
		[global::LFHHNDGABIE(1)]
		public EOFCEFPOPKM collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::OCLFPHHJGAJ(2, false)]
	[CompilerGenerated]
	[KELCBHLJPIL("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[FCCBHHJJMOG("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::GHEJGODHDFC(GEIOBDNIBFI.DEFAULT)]
		[global::LFHHNDGABIE(1)]
		[EKKCIPEDFDF(null, 0)]
		public GEIOBDNIBFI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::MELEPFEPFLB(1094837642118998916uL, 0u)]
	[FCCBHHJJMOG("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::GHEJGODHDFC(0f)]
		[EKKCIPEDFDF(null, 0)]
		[global::LFHHNDGABIE(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[global::MELEPFEPFLB(13657791279235747653uL, 0u)]
	[KELCBHLJPIL("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::OCLFPHHJGAJ(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[FCCBHHJJMOG("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		[EKKCIPEDFDF(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[KELCBHLJPIL("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[FCCBHHJJMOG("Container", 0)]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[global::MELEPFEPFLB(5176564412348566398uL, 0u)]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		[EKKCIPEDFDF(null, 0)]
		public ELGLBMPMFMM grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	[global::MELEPFEPFLB(16485879999901987510uL, 0u)]
	[KELCBHLJPIL("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[FCCBHHJJMOG("Container", 0)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::LFHHNDGABIE(1)]
		[EKKCIPEDFDF(null, 0)]
		[global::GHEJGODHDFC(FAHBCJFBLFI.NavMeshGenerator)]
		public FAHBCJFBLFI mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::MELEPFEPFLB(1537567323754185605uL, 0u)]
	[KELCBHLJPIL("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::OCLFPHHJGAJ(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[KELCBHLJPIL("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::OCLFPHHJGAJ(1, false)]
	[global::MELEPFEPFLB(5115014870530256079uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[global::MELEPFEPFLB(14429493078606832166uL, 0u)]
	[KELCBHLJPIL("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::OCLFPHHJGAJ(1, false)]
	[global::MELEPFEPFLB(12111354511484844847uL, 0u)]
	[KELCBHLJPIL("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, CDFIGFDGHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, CDFIGFDGHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MGDLHEJKLNJ : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[KELCBHLJPIL("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::OCLFPHHJGAJ(1, false)]
	[global::MELEPFEPFLB(15012400804589552708uL, 0u)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[global::OCLFPHHJGAJ(5, false)]
	[FCCBHHJJMOG("Object", 0)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::MELEPFEPFLB(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[KELCBHLJPIL("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::LFHHNDGABIE(2)]
		[global::GHEJGODHDFC("new ScaleRestriction(1,1)")]
		public DDCOPLICAFO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[EKKCIPEDFDF(null, 0)]
		[global::GHEJGODHDFC("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::LFHHNDGABIE(3)]
		public ABHMDJOONNA userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::GHEJGODHDFC(IKBPKMBLKEC.Default)]
		[EKKCIPEDFDF(null, 0)]
		[global::LFHHNDGABIE(4)]
		public IKBPKMBLKEC circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC("ObjectPolicyEnumFlags.Default")]
		public BJJDBIPGBFA flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[global::MELEPFEPFLB(17708500325183871236uL, 0u)]
	[KELCBHLJPIL("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
		public static PlayerScopeData PFOIJBDHIHJ(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[global::MELEPFEPFLB(16642773407304133105uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[KELCBHLJPIL("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::OCLFPHHJGAJ(1, false)]
	[FCCBHHJJMOG("Physics", 0)]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::GHEJGODHDFC(10f)]
		[EKKCIPEDFDF(null, 0)]
		[global::LFHHNDGABIE(1)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	[global::MELEPFEPFLB(10537432342869025182uL, 0u)]
	[KELCBHLJPIL("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::GHEJGODHDFC(PHCMFDMHLCF.None)]
		[global::LFHHNDGABIE(1)]
		public PHCMFDMHLCF flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x60EA960", Offset = "0x60E9560", VA = "0x1860EA960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x60EA970", Offset = "0x60E9570", VA = "0x1860EA970")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[global::MELEPFEPFLB(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public NDNIJNHJOPC shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[global::MELEPFEPFLB(5298506180484533559uL, 0u)]
	[KELCBHLJPIL("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[global::OCLFPHHJGAJ(1, false)]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public HCIOGIKPEPF order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
		public static SplinePointOrderData PFOIJBDHIHJ(HCIOGIKPEPF value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::OCLFPHHJGAJ(1, false)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[KELCBHLJPIL("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::MELEPFEPFLB(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[global::OCLFPHHJGAJ(1, false)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[CompilerGenerated]
	[global::MELEPFEPFLB(18095612727592564636uL, 0u)]
	[KELCBHLJPIL("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::MELEPFEPFLB(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::MELEPFEPFLB(1238044349990854547uL, 0u)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::GHEJGODHDFC("new float3(1)")]
		[global::LFHHNDGABIE(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[KELCBHLJPIL("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::OCLFPHHJGAJ(1, false)]
	[global::MELEPFEPFLB(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public ALFAJFPDPCI parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[global::MELEPFEPFLB(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[KELCBHLJPIL("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::OCLFPHHJGAJ(1, false)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::GHEJGODHDFC(PEIEPPDJHDN.CURRENT)]
		[global::LFHHNDGABIE(1)]
		public PEIEPPDJHDN version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[global::AKJBAJDEELE(new int[] { 1 })]
	[global::MELEPFEPFLB(12332323170023439017uL, 0u)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[KELCBHLJPIL("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::OCLFPHHJGAJ(2, false)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::LFHHNDGABIE(2)]
		[global::GHEJGODHDFC(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::GHEJGODHDFC(true)]
		[global::LFHHNDGABIE(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::MELEPFEPFLB(2711391707957742092uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[CompilerGenerated]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("021E8703-AAFD-4965-8C38-FF86663126D2")]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	[KELCBHLJPIL("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::MELEPFEPFLB(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC("new quaternion(0,0,0,1)")]
		[EKKCIPEDFDF(null, 0)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::LFHHNDGABIE(2)]
		[global::GHEJGODHDFC]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF58C0", Offset = "0x3BF44C0", VA = "0x183BF58C0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60E9B00", Offset = "0x60E8700", VA = "0x1860E9B00")]
		public static RigidTransform PFOIJBDHIHJ(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60E9B00", Offset = "0x60E8700", VA = "0x1860E9B00")]
		public static LocalPoseData PFOIJBDHIHJ(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BDGEFHECKKG
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static RigidTransform BKNMIIBIJIN(this LocalPoseData BLKAHBIJBJO)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[KELCBHLJPIL("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::MELEPFEPFLB(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[global::OCLFPHHJGAJ(1, false)]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::GHEJGODHDFC(1f)]
		[global::LFHHNDGABIE(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::MELEPFEPFLB(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public MJEEKHJJBMM transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::LFHHNDGABIE(2)]
		[global::GHEJGODHDFC]
		public FLMIPEJMHKA transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::GPPCBJGPIII]
	[CompilerGenerated]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::MELEPFEPFLB(798350452111942523uL, 0u)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(1)]
		public JDMDNBNFCKO prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::OCLFPHHJGAJ(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[KELCBHLJPIL("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::GHEJGODHDFC(false)]
		[global::LFHHNDGABIE(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::OCLFPHHJGAJ(1, false)]
	[KELCBHLJPIL("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::MELEPFEPFLB(1591066774816564574uL, 0u)]
	[FCCBHHJJMOG("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		[EKKCIPEDFDF(null, 0)]
		public FKDBJAIFMHN color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::LFHHNDGABIE(2)]
		[global::GHEJGODHDFC]
		[EKKCIPEDFDF(null, 0)]
		public MNJKPHMDKIP material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::LFHHNDGABIE(3)]
		[global::GHEJGODHDFC]
		[EKKCIPEDFDF(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::GHEJGODHDFC]
		[global::LFHHNDGABIE(4)]
		[EKKCIPEDFDF(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ONFHPPJLEJC(IKBPKMBLKEC.NONE, IKBPKMBLKEC.COUNT)]
[KELCBHLJPIL("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::BJDIKICHKOF(1, false)]
public enum IKBPKMBLKEC
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[EKKCIPEDFDF("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[EKKCIPEDFDF("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[EKKCIPEDFDF("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ONFHPPJLEJC(0, 4)]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum IJBNHOEPMKL
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
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KELCBHLJPIL("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::BJDIKICHKOF(1, false)]
[ONFHPPJLEJC(CKPGEJPPOPL.NONE, CKPGEJPPOPL.ALL)]
[Flags]
public enum CKPGEJPPOPL
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
[Cpp2IlInjected.Token(Token = "0x2000037")]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[ONFHPPJLEJC(EOFCEFPOPKM.Off, EOFCEFPOPKM.COUNT)]
public enum EOFCEFPOPKM
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
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ONFHPPJLEJC(PEIEPPDJHDN.VERSION_0, PEIEPPDJHDN.CURRENT)]
[KELCBHLJPIL("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::BJDIKICHKOF(1, false)]
[HAMLGMCMFPL]
public enum PEIEPPDJHDN : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ONFHPPJLEJC(0, 127)]
[KELCBHLJPIL("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::BJDIKICHKOF(1, false)]
public enum GFIOKLOKKHG
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[LOMJCOILOHM("Indicating it can be walked on and moved")]
	[EKKCIPEDFDF("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[EKKCIPEDFDF("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[EKKCIPEDFDF("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[EKKCIPEDFDF("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[EKKCIPEDFDF("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[EKKCIPEDFDF("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[EKKCIPEDFDF("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[EKKCIPEDFDF("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[EKKCIPEDFDF("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[HAMLGMCMFPL]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[HAMLGMCMFPL]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Flags]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[ONFHPPJLEJC(0, GEIOBDNIBFI.ALL)]
public enum GEIOBDNIBFI
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
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ONFHPPJLEJC(0, 2)]
[KELCBHLJPIL("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::BJDIKICHKOF(1, false)]
public enum NDNIJNHJOPC
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
[Cpp2IlInjected.Token(Token = "0x200003C")]
[KELCBHLJPIL("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::BJDIKICHKOF(1, false)]
[ONFHPPJLEJC(ELGLBMPMFMM.Pivot, ELGLBMPMFMM.COUNT)]
public enum ELGLBMPMFMM
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
[Cpp2IlInjected.Token(Token = "0x200003D")]
[ONFHPPJLEJC(LNIHFCONKNN.EnabledForRole, LNIHFCONKNN.DisabledForRole)]
[KELCBHLJPIL("c0973732-e735-44cd-9727-a9a79bad01e3")]
[global::BJDIKICHKOF(1, false)]
public enum LNIHFCONKNN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[KELCBHLJPIL("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::BJDIKICHKOF(1, false)]
[ONFHPPJLEJC(FAHBCJFBLFI.NavMeshGenerator, FAHBCJFBLFI.NavMeshBlocker)]
public enum FAHBCJFBLFI
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
[Cpp2IlInjected.Token(Token = "0x200003F")]
[ONFHPPJLEJC(BJJDBIPGBFA.None, BJJDBIPGBFA.All)]
[global::BJDIKICHKOF(1, false)]
[Flags]
[KELCBHLJPIL("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum BJJDBIPGBFA
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[ONFHPPJLEJC(0, DCOMAONPGJB.COUNT)]
public enum DCOMAONPGJB
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
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JNLADLDPEFL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60EA430", Offset = "0x60E9030", VA = "0x1860EA430")]
	public static void FNEEIDKMODG(this BJJDBIPGBFA OGPBDNPMEAI, DCOMAONPGJB IMLEKNAJKAE, bool FJKKNAGMELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60EA470", Offset = "0x60E9070", VA = "0x1860EA470")]
	public static bool LGNCFJMIAIB(this BJJDBIPGBFA OGPBDNPMEAI, DCOMAONPGJB IMLEKNAJKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60EA460", Offset = "0x60E9060", VA = "0x1860EA460")]
	public static BJJDBIPGBFA JPFMBFLOHDL(this DCOMAONPGJB IMLEKNAJKAE)
	{
		return default(BJJDBIPGBFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[ONFHPPJLEJC(ABHMDJOONNA.NONE, ABHMDJOONNA.COUNT)]
[Flags]
[KELCBHLJPIL("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[global::BJDIKICHKOF(1, false)]
public enum ABHMDJOONNA
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
[Cpp2IlInjected.Token(Token = "0x2000043")]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[ONFHPPJLEJC(1000, 8000)]
public enum JDMDNBNFCKO
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[EKKCIPEDFDF("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[EKKCIPEDFDF("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[EKKCIPEDFDF("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[EKKCIPEDFDF("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[HAMLGMCMFPL]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[EKKCIPEDFDF("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[EKKCIPEDFDF("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[EKKCIPEDFDF("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[EKKCIPEDFDF("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[EKKCIPEDFDF("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[EKKCIPEDFDF("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[EKKCIPEDFDF("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[EKKCIPEDFDF("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[EKKCIPEDFDF("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[EKKCIPEDFDF("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[EKKCIPEDFDF("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[EKKCIPEDFDF("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[EKKCIPEDFDF("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[EKKCIPEDFDF("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[EKKCIPEDFDF("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[EKKCIPEDFDF("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[EKKCIPEDFDF("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[EKKCIPEDFDF("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[EKKCIPEDFDF("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[EKKCIPEDFDF("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[EKKCIPEDFDF("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[EKKCIPEDFDF("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[EKKCIPEDFDF("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[EKKCIPEDFDF("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[EKKCIPEDFDF("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[EKKCIPEDFDF("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[EKKCIPEDFDF("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[EKKCIPEDFDF("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[EKKCIPEDFDF("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[EKKCIPEDFDF("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[EKKCIPEDFDF("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[EKKCIPEDFDF("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[EKKCIPEDFDF("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[EKKCIPEDFDF("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[EKKCIPEDFDF("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[EKKCIPEDFDF("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[EKKCIPEDFDF("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[EKKCIPEDFDF("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[EKKCIPEDFDF("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[EKKCIPEDFDF("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[EKKCIPEDFDF("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[HAMLGMCMFPL]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[EKKCIPEDFDF("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[EKKCIPEDFDF("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[EKKCIPEDFDF("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[EKKCIPEDFDF("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[EKKCIPEDFDF("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[EKKCIPEDFDF("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[EKKCIPEDFDF("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[EKKCIPEDFDF("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[EKKCIPEDFDF("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[EKKCIPEDFDF("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[EKKCIPEDFDF("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[EKKCIPEDFDF("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[EKKCIPEDFDF("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[EKKCIPEDFDF("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[EKKCIPEDFDF("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[EKKCIPEDFDF("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[EKKCIPEDFDF("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EEBEENANFNL
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60E9C20", Offset = "0x60E8820", VA = "0x1860E9C20")]
	public static FLANCFHLPOD FLBIJPAJPNK(this JDMDNBNFCKO HKKADAMFOHP)
	{
		return default(FLANCFHLPOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[ONFHPPJLEJC(0, 9)]
[KELCBHLJPIL("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::BJDIKICHKOF(1, false)]
public enum FLANCFHLPOD
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
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class AEMDLGDFMMI
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60E99B0", Offset = "0x60E85B0", VA = "0x1860E99B0")]
	public static bool PDOMINKDOLE(this FLANCFHLPOD GBHGIOLEJKL)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[global::OCLFPHHJGAJ(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[KELCBHLJPIL("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::MELEPFEPFLB(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[global::LFHHNDGABIE(1)]
		[global::GHEJGODHDFC]
		public EBFEJIDFJIN shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("517224CC-0A79-4FE9-B048-53C37955D823")]
[ONFHPPJLEJC(-1, 38)]
public enum EBFEJIDFJIN
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
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Flags]
[ONFHPPJLEJC(0, 7)]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
public enum PHCMFDMHLCF
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
[Cpp2IlInjected.Token(Token = "0x200004A")]
[KELCBHLJPIL("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::BJDIKICHKOF(1, false)]
[ONFHPPJLEJC(0, 7)]
[Flags]
public enum PBLMINMDFMD
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
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Flags]
[ONFHPPJLEJC(0, 1)]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("72742F9B-D48E-4CED-B403-444201FFEE66")]
public enum MJEEKHJJBMM
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
[Cpp2IlInjected.Token(Token = "0x200004C")]
[global::BJDIKICHKOF(1, false)]
[ONFHPPJLEJC(-2, 2)]
[KELCBHLJPIL("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum FLMIPEJMHKA
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
[Cpp2IlInjected.Token(Token = "0x200004D")]
[global::BJDIKICHKOF(1, false)]
[ONFHPPJLEJC(int.MinValue, int.MaxValue)]
[KELCBHLJPIL("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum FKDBJAIFMHN
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
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::BJDIKICHKOF(1, false)]
[KELCBHLJPIL("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[ONFHPPJLEJC(-1, 31)]
public enum MNJKPHMDKIP
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
[Cpp2IlInjected.Token(Token = "0x200004F")]
[global::FGPHLBAKMNO(1, false)]
[KELCBHLJPIL("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct HCIOGIKPEPF : IComparable<HCIOGIKPEPF>, IEquatable<HCIOGIKPEPF>, PPLCLCBEODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[global::LFHHNDGABIE(1)]
	public uint HABLHBMOADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[global::LFHHNDGABIE(2)]
	public uint MDKOGFANAEI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint IGBCDGOKCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60EA150", Offset = "0x60E8D50", VA = "0x1860EA150")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60EA270", Offset = "0x60E8E70", VA = "0x1860EA270")]
	public HCIOGIKPEPF(int HABLHBMOADM, int DJGANFIBOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60EA270", Offset = "0x60E8E70", VA = "0x1860EA270")]
	public HCIOGIKPEPF(uint HABLHBMOADM, uint DJGANFIBOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60E9E60", Offset = "0x60E8A60", VA = "0x1860E9E60")]
	public HCIOGIKPEPF BKDFFHLEBIP(int OIAPMOHIBDO = 1)
	{
		return default(HCIOGIKPEPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60E9DF0", Offset = "0x60E89F0", VA = "0x1860E9DF0")]
	public HCIOGIKPEPF ABJNBCEDJLK(int OIAPMOHIBDO = 1)
	{
		return default(HCIOGIKPEPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60EA0D0", Offset = "0x60E8CD0", VA = "0x1860EA0D0")]
	public static HCIOGIKPEPF ICEPJPJIDFH(HCIOGIKPEPF GDDMOGHGPAF, HCIOGIKPEPF GHPICIIHMOJ)
	{
		return default(HCIOGIKPEPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60EA160", Offset = "0x60E8D60", VA = "0x1860EA160")]
	private static uint NBPAJFGEIKK(uint PKCAMDKHNLN, uint ECIMPLOCMKE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60E9ED0", Offset = "0x60E8AD0", VA = "0x1860E9ED0", Slot = "4")]
	public int CompareTo(HCIOGIKPEPF NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F80", Offset = "0x60E8B80", VA = "0x1860E9F80", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60EA190", Offset = "0x60E8D90", VA = "0x1860EA190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F60", Offset = "0x60E8B60", VA = "0x1860E9F60", Slot = "5")]
	public bool Equals(HCIOGIKPEPF NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60EA080", Offset = "0x60E8C80", VA = "0x1860EA080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60EA010", Offset = "0x60E8C10", VA = "0x1860EA010", Slot = "6")]
	public void GAPNIKJAJOO(EKENKPJIJHJ EDIOJDLAEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60E9EF0", Offset = "0x60E8AF0", VA = "0x1860E9EF0", Slot = "7")]
	public void DPCADENMEMJ(PMHOKBEJPME ALHICDKDPIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2672CE0", Offset = "0x26718E0", VA = "0x182672CE0")]
	public static bool FKDJFADGJBA(HCIOGIKPEPF GDDMOGHGPAF, HCIOGIKPEPF GHPICIIHMOJ)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[KELCBHLJPIL("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::FGPHLBAKMNO(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, PPLCLCBEODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[global::LFHHNDGABIE(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public static NetworkGuid PFOIJBDHIHJ(Guid AGEGEBLOPIL)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60EA680", Offset = "0x60E9280", VA = "0x1860EA680", Slot = "4")]
		public bool Equals(NetworkGuid NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
		public int CompareTo(NetworkGuid NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60EA6B0", Offset = "0x60E92B0", VA = "0x1860EA6B0", Slot = "6")]
		public void GAPNIKJAJOO(EKENKPJIJHJ EDIOJDLAEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60EA610", Offset = "0x60E9210", VA = "0x1860EA610", Slot = "7")]
		public void DPCADENMEMJ(PMHOKBEJPME ALHICDKDPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60EA770", Offset = "0x60E9370", VA = "0x1860EA770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[KELCBHLJPIL("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::FGPHLBAKMNO(1, false)]
public struct DDCOPLICAFO : PPLCLCBEODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[global::LFHHNDGABIE(1)]
	public bool OOAKOKIGOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[global::LFHHNDGABIE(2)]
	public float3 MNIDLDLIOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[global::LFHHNDGABIE(3)]
	public float3 EEKIMHNFFKJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60E9BF0", Offset = "0x60E87F0", VA = "0x1860E9BF0")]
	public DDCOPLICAFO(float FJELBKILIHM, float HBEDOPKLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60E9BA0", Offset = "0x60E87A0", VA = "0x1860E9BA0", Slot = "4")]
	public void GAPNIKJAJOO(EKENKPJIJHJ EDIOJDLAEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60E9B30", Offset = "0x60E8730", VA = "0x1860E9B30", Slot = "5")]
	public void DPCADENMEMJ(PMHOKBEJPME ALHICDKDPIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[KELCBHLJPIL("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::FGPHLBAKMNO(1, false)]
public struct ALFAJFPDPCI : PPLCLCBEODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[global::LFHHNDGABIE(1)]
	public float BAGHCNHOEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[global::LFHHNDGABIE(2)]
	public int ALLOEMBICFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[global::LFHHNDGABIE(3)]
	public PBLMINMDFMD OGPBDNPMEAI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DFDCOCJMJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60E9AA0", Offset = "0x60E86A0", VA = "0x1860E9AA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60E9AD0", Offset = "0x60E86D0", VA = "0x1860E9AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FEOAAPLHAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60E9A70", Offset = "0x60E8670", VA = "0x1860E9A70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60E9A80", Offset = "0x60E8680", VA = "0x1860E9A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FNOIONBAJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60E9AF0", Offset = "0x60E86F0", VA = "0x1860E9AF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60E9AB0", Offset = "0x60E86B0", VA = "0x1860E9AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60E99C0", Offset = "0x60E85C0", VA = "0x1860E99C0", Slot = "5")]
	public void DPCADENMEMJ(PMHOKBEJPME ALHICDKDPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x60E9A10", Offset = "0x60E8610", VA = "0x1860E9A10", Slot = "4")]
	public void GAPNIKJAJOO(EKENKPJIJHJ EDIOJDLAEAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class KKJOIFPEFCF : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class EFGGGNILENB : Property<RRObjectPrefabData, JDMDNBNFCKO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string PEJAGGFBEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x60E9D40", Offset = "0x60E8940", VA = "0x1860E9D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool FHOMOFINOFF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60E9C50", Offset = "0x60E8850", VA = "0x1860E9C50")]
		public EFGGGNILENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x13DDE40", Offset = "0x13DCA40", VA = "0x1813DDE40", Slot = "14")]
		public override JDMDNBNFCKO GetValue(RRObjectPrefabData JEAKPHJODOO)
		{
			return default(JDMDNBNFCKO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60E9C40", Offset = "0x60E8840", VA = "0x1860E9C40", Slot = "15")]
		public override void SetValue(RRObjectPrefabData JEAKPHJODOO, JDMDNBNFCKO BLKAHBIJBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60EA490", Offset = "0x60E9090", VA = "0x1860EA490")]
	public KKJOIFPEFCF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60EA790", Offset = "0x60E9390", VA = "0x1860EA790")]
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
