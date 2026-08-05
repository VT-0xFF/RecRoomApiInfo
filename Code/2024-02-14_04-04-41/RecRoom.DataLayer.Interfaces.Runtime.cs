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
public interface MODFINNOGLH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity GJHEILIDBNI
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
	[global::MGHEEAFNLFN(11505792609904010668uL, 0u)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[LBHFJPPIHPK("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[global::JILHDEHOGJI(1, false)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::MBLAPLINKNC(2)]
		[global::NLHDMLEOFGL("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3B0AAF0", Offset = "0x3B09EF0", VA = "0x183B0AAF0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F10A70", Offset = "0x5F0FE70", VA = "0x185F10A70")]
		public static AuthoredLocalPoseData CPALPDKLBCM(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::MGHEEAFNLFN(9088562008033959482uL, 0u)]
	[LBHFJPPIHPK("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::JILHDEHOGJI(1, false)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::NLHDMLEOFGL(1f)]
		[global::MBLAPLINKNC(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::MGHEEAFNLFN(10137300772124140051uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	public struct AuthoredParentData : IComponentData, MODFINNOGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
		public static AuthoredParentData CPALPDKLBCM(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F10A90", Offset = "0x5F0FE90", VA = "0x185F10A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GNMEHGGCLGL : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[global::JILHDEHOGJI(1, false)]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[LBHFJPPIHPK("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::NLHDMLEOFGL(false)]
		[global::MBLAPLINKNC(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::NLHDMLEOFGL(BBMOGEPBAIL.EnabledForRole)]
		[global::MBLAPLINKNC(3)]
		public BBMOGEPBAIL filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[global::MGHEEAFNLFN(8594223769175916906uL, 0u)]
	[LBHFJPPIHPK("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[global::JILHDEHOGJI(1, false)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::JILHDEHOGJI(1, false)]
	[CompilerGenerated]
	[LBHFJPPIHPK("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[global::MGHEEAFNLFN(780699438743496039uL, 0u)]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::NLHDMLEOFGL(true)]
		[global::MBLAPLINKNC(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[CompilerGenerated]
	[LBHFJPPIHPK("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::JILHDEHOGJI(1, false)]
	[global::MGHEEAFNLFN(11853296779717712500uL, 0u)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[LBHFJPPIHPK("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::JILHDEHOGJI(1, false)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[global::MGHEEAFNLFN(8536678595025273356uL, 0u)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::MBLAPLINKNC(2)]
		[global::NLHDMLEOFGL]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1D46F30", Offset = "0x1D46330", VA = "0x181D46F30")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E4B0", Offset = "0x1D7D8B0", VA = "0x181D7E4B0")]
		public EntityBundlePartData(Entity prefabRoot, EntityBundlePartId partId)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		internal EntityBundlePartId(uint PDDHPPHOJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88ADC0", Offset = "0x88A1C0", VA = "0x18088ADC0")]
		internal uint KBJMLOKJNFK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x817B90", Offset = "0x816F90", VA = "0x180817B90", Slot = "4")]
		public bool Equals(EntityBundlePartId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F10AA0", Offset = "0x5F0FEA0", VA = "0x185F10AA0", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89A350", Offset = "0x899750", VA = "0x18089A350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x175BFD0", Offset = "0x175B3D0", VA = "0x18175BFD0")]
		public static bool FFFIMEBHMPG(EntityBundlePartId MAGGDEMNFDG, EntityBundlePartId LFCFPOEDJCH)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[LBHFJPPIHPK("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::MGHEEAFNLFN(11104975410044731874uL, 0u)]
	[global::JILHDEHOGJI(1, false)]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[EHGJEKLPOIG("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::NLHDMLEOFGL(OCHDCDHKKBD.IsDynamicEnvironment)]
		[FKEBHLCJPHC(null, 0)]
		[global::MBLAPLINKNC(1)]
		public OCHDCDHKKBD collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FLEOENCIEGC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum NCHAIKNAHCA
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DJCEABMJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F10B20", Offset = "0x5F0FF20", VA = "0x185F10B20")]
	public static (NCHAIKNAHCA, DJCEABMJEMB) JJNHJAADPLJ(this OCHDCDHKKBD PKGEMGAKJLI)
	{
		return default((NCHAIKNAHCA, DJCEABMJEMB));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[LBHFJPPIHPK("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[CompilerGenerated]
	[global::MGHEEAFNLFN(2914713536404587710uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[EHGJEKLPOIG("Container", 0)]
	[global::JILHDEHOGJI(1, false)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL(JPDMJCGMGDE.Children)]
		[FKEBHLCJPHC(null, 0)]
		public JPDMJCGMGDE collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[global::JILHDEHOGJI(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[LBHFJPPIHPK("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[EHGJEKLPOIG("Container", 0)]
	[CompilerGenerated]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[global::NLHDMLEOFGL(AAJBBPEHLCO.DEFAULT)]
		[global::MBLAPLINKNC(1)]
		[FKEBHLCJPHC(null, 0)]
		public AAJBBPEHLCO flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::MGHEEAFNLFN(1094837642118998916uL, 0u)]
	[EHGJEKLPOIG("Container", 0)]
	[LBHFJPPIHPK("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::JILHDEHOGJI(1, false)]
	[CompilerGenerated]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL(0f)]
		[FKEBHLCJPHC(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[EHGJEKLPOIG("Container", 0)]
	[global::MGHEEAFNLFN(13657791279235747653uL, 0u)]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("89708D57-D027-494A-A159-221E6C643B6B")]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		[FKEBHLCJPHC(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[CompilerGenerated]
	[EHGJEKLPOIG("Container", 0)]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[global::MGHEEAFNLFN(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::NLHDMLEOFGL]
		[FKEBHLCJPHC(null, 0)]
		[global::MBLAPLINKNC(1)]
		public EMIHHPKPCKI grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[LBHFJPPIHPK("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::JILHDEHOGJI(1, false)]
	[CompilerGenerated]
	[EHGJEKLPOIG("Container", 0)]
	[global::MGHEEAFNLFN(16485879999901987510uL, 0u)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::NLHDMLEOFGL(KDJBNKMKEOC.NavMeshGenerator)]
		[FKEBHLCJPHC(null, 0)]
		[global::MBLAPLINKNC(1)]
		public KDJBNKMKEOC mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[LBHFJPPIHPK("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::JILHDEHOGJI(1, false)]
	[global::MGHEEAFNLFN(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[global::MGHEEAFNLFN(5115014870530256079uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[LBHFJPPIHPK("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::JILHDEHOGJI(1, false)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[LBHFJPPIHPK("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[global::MGHEEAFNLFN(14429493078606832166uL, 0u)]
	[global::JILHDEHOGJI(1, false)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::MGHEEAFNLFN(12111354511484844847uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, MODFINNOGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80")]
		public ParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
		public static ParentData CPALPDKLBCM(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FNPLAKAIPEI : ISystemStateComponentData, IComponentData, MODFINNOGLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity HMDLCLHKHMG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity LOIADICGELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80")]
	public FNPLAKAIPEI(Entity BBCCHMIJNJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static FNPLAKAIPEI CPALPDKLBCM(Entity IBMHOJHGCIG)
	{
		return default(FNPLAKAIPEI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KPOFAGGANLD : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[LBHFJPPIHPK("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[global::MGHEEAFNLFN(15012400804589552708uL, 0u)]
	[CompilerGenerated]
	[global::JILHDEHOGJI(1, false)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[global::JILHDEHOGJI(5, false)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[LBHFJPPIHPK("FB9853D6-6231-43FD-A754-00105DC30880")]
	[global::MGHEEAFNLFN(16541670854338945984uL, 0u)]
	[EHGJEKLPOIG("Object", 0)]
	[CompilerGenerated]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::MBLAPLINKNC(2)]
		[global::NLHDMLEOFGL("new ScaleRestriction(1,1)")]
		public GFOPHKDCOIF scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::MBLAPLINKNC(3)]
		[global::NLHDMLEOFGL("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[FKEBHLCJPHC(null, 0)]
		public HPKPKKLNNBD userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[global::NLHDMLEOFGL(AJLPCMNFGLM.Default)]
		[FKEBHLCJPHC(null, 0)]
		[global::MBLAPLINKNC(4)]
		public AJLPCMNFGLM circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::NLHDMLEOFGL("ObjectPolicyEnumFlags.Default")]
		[global::MBLAPLINKNC(1)]
		public NLKIHKBJCMJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	[global::MGHEEAFNLFN(17708500325183871236uL, 0u)]
	[LBHFJPPIHPK("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::JILHDEHOGJI(1, false)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
		public static PlayerScopeData CPALPDKLBCM(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[EHGJEKLPOIG("Physics", 0)]
	[global::MGHEEAFNLFN(16642773407304133105uL, 0u)]
	[LBHFJPPIHPK("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::JILHDEHOGJI(1, false)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::NLHDMLEOFGL(10f)]
		[global::MBLAPLINKNC(1)]
		[FKEBHLCJPHC(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[LBHFJPPIHPK("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[global::MGHEEAFNLFN(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	[global::JILHDEHOGJI(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL(BLNHPOMBHOM.None)]
		public BLNHPOMBHOM flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5F11A10", Offset = "0x5F10E10", VA = "0x185F11A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5F11A20", Offset = "0x5F10E20", VA = "0x185F11A20")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[LBHFJPPIHPK("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[global::MGHEEAFNLFN(10917729582819845312uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::JILHDEHOGJI(1, false)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public BOFBKKJKCND shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::MGHEEAFNLFN(5298506180484533559uL, 0u)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public JJEFHDAOIGH order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
		public static SplinePointOrderData CPALPDKLBCM(JJEFHDAOIGH value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::MGHEEAFNLFN(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::JILHDEHOGJI(1, false)]
	[global::MGHEEAFNLFN(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[LBHFJPPIHPK("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[LBHFJPPIHPK("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::JILHDEHOGJI(1, false)]
	[global::MGHEEAFNLFN(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::MGHEEAFNLFN(1238044349990854547uL, 0u)]
	[LBHFJPPIHPK("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::JILHDEHOGJI(1, false)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[LBHFJPPIHPK("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::JILHDEHOGJI(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[global::MGHEEAFNLFN(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public GLLPKLKIABE parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[global::JILHDEHOGJI(1, false)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[CompilerGenerated]
	[global::MGHEEAFNLFN(10026670690793008625uL, 0u)]
	[LBHFJPPIHPK("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::NLHDMLEOFGL(IMBLADACFIA.CURRENT)]
		[global::MBLAPLINKNC(1)]
		public IMBLADACFIA version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	[global::EDMBNIEDGEG(new int[] { 1 })]
	[global::MGHEEAFNLFN(12332323170023439017uL, 0u)]
	[global::JILHDEHOGJI(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[LBHFJPPIHPK("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::NLHDMLEOFGL(true)]
		[global::MBLAPLINKNC(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::NLHDMLEOFGL(true)]
		[global::MBLAPLINKNC(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::MGHEEAFNLFN(2711391707957742092uL, 0u)]
	[CompilerGenerated]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("021E8703-AAFD-4965-8C38-FF86663126D2")]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::NLHDMLEOFGL("new float3(1)")]
		[global::MBLAPLINKNC(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::MGHEEAFNLFN(1369925932270831712uL, 0u)]
	[global::JILHDEHOGJI(1, false)]
	[CompilerGenerated]
	[LBHFJPPIHPK("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[FKEBHLCJPHC(null, 0)]
		[global::NLHDMLEOFGL("new quaternion(0,0,0,1)")]
		[global::MBLAPLINKNC(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B0AAF0", Offset = "0x3B09EF0", VA = "0x183B0AAF0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5F10A70", Offset = "0x5F0FE70", VA = "0x185F10A70")]
		public static RigidTransform CPALPDKLBCM(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5F10A70", Offset = "0x5F0FE70", VA = "0x185F10A70")]
		public static LocalPoseData CPALPDKLBCM(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[global::MGHEEAFNLFN(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::NLHDMLEOFGL(1f)]
		[global::MBLAPLINKNC(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::MGHEEAFNLFN(5730545663584378555uL, 0u)]
	[LBHFJPPIHPK("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::JILHDEHOGJI(1, false)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public KGEOCFAOCCF transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::MBLAPLINKNC(2)]
		[global::NLHDMLEOFGL]
		public DEBGKELLCHI transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::CAEDIJKFMNB]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[global::JILHDEHOGJI(1, false)]
	[LBHFJPPIHPK("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::MGHEEAFNLFN(798350452111942523uL, 0u)]
	[CompilerGenerated]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public NMFEMHGADPL prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::JILHDEHOGJI(2, false)]
	[LBHFJPPIHPK("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::NLHDMLEOFGL]
		[global::MBLAPLINKNC(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::MBLAPLINKNC(2)]
		[global::NLHDMLEOFGL(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::JILHDEHOGJI(1, false)]
	[CompilerGenerated]
	[EHGJEKLPOIG("Visual", 0)]
	[global::MGHEEAFNLFN(1591066774816564574uL, 0u)]
	[LBHFJPPIHPK("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[FKEBHLCJPHC(null, 0)]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public BDELPKJPBPE color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[FKEBHLCJPHC(null, 0)]
		[global::MBLAPLINKNC(2)]
		[global::NLHDMLEOFGL]
		public AICBIGGMGIO material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::MBLAPLINKNC(3)]
		[FKEBHLCJPHC(null, 0)]
		[global::NLHDMLEOFGL]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[FKEBHLCJPHC(null, 0)]
		[global::MBLAPLINKNC(4)]
		[global::NLHDMLEOFGL]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LBHFJPPIHPK("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(AJLPCMNFGLM.NONE, AJLPCMNFGLM.COUNT)]
public enum AJLPCMNFGLM
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[FKEBHLCJPHC("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[FKEBHLCJPHC("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[FKEBHLCJPHC("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IAFILGKNAJG(0, 4)]
[global::HJCJIAPJJON(1, false)]
[LBHFJPPIHPK("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum FDPCDHFNFAD
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[global::HJCJIAPJJON(1, false)]
[LBHFJPPIHPK("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[IAFILGKNAJG(HONLICKPKKN.NONE, HONLICKPKKN.ALL)]
[Flags]
public enum HONLICKPKKN
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LBHFJPPIHPK("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[IAFILGKNAJG(JPDMJCGMGDE.Off, JPDMJCGMGDE.COUNT)]
[global::HJCJIAPJJON(1, false)]
public enum JPDMJCGMGDE
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IAFILGKNAJG(IMBLADACFIA.VERSION_0, IMBLADACFIA.CURRENT)]
[KIFICBDIIFM]
[global::HJCJIAPJJON(1, false)]
[LBHFJPPIHPK("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
public enum IMBLADACFIA : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[IAFILGKNAJG(0, 127)]
[global::HJCJIAPJJON(1, false)]
[LBHFJPPIHPK("F843A776-E042-43B7-8167-0C7A421062F8")]
public enum OCHDCDHKKBD
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[FLODAKDKFNK("Indicating it can be walked on and moved")]
	[FKEBHLCJPHC("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[FKEBHLCJPHC("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[FKEBHLCJPHC("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[FKEBHLCJPHC("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[FKEBHLCJPHC("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[FKEBHLCJPHC("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[FKEBHLCJPHC("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[FKEBHLCJPHC("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[FKEBHLCJPHC("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[KIFICBDIIFM]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[KIFICBDIIFM]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[IAFILGKNAJG(0, AAJBBPEHLCO.ALL)]
[LBHFJPPIHPK("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
[global::HJCJIAPJJON(1, false)]
public enum AAJBBPEHLCO
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[IAFILGKNAJG(0, 2)]
[global::HJCJIAPJJON(1, false)]
[LBHFJPPIHPK("3B156405-5769-4DB2-87EA-2B846AC4E584")]
public enum BOFBKKJKCND
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(EMIHHPKPCKI.Pivot, EMIHHPKPCKI.COUNT)]
[LBHFJPPIHPK("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum EMIHHPKPCKI
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(BBMOGEPBAIL.EnabledForRole, BBMOGEPBAIL.DisabledForRole)]
[LBHFJPPIHPK("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum BBMOGEPBAIL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[LBHFJPPIHPK("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(KDJBNKMKEOC.NavMeshGenerator, KDJBNKMKEOC.NavMeshBlocker)]
public enum KDJBNKMKEOC
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[LBHFJPPIHPK("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(NLKIHKBJCMJ.None, NLKIHKBJCMJ.All)]
[Flags]
public enum NLKIHKBJCMJ
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(0, EHIPCMJHIPP.COUNT)]
[LBHFJPPIHPK("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum EHIPCMJHIPP
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PEBOPCJBDBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F117E0", Offset = "0x5F10BE0", VA = "0x185F117E0")]
	public static void BDBEANEDBLI(this NLKIHKBJCMJ HPGFBABPMCF, EHIPCMJHIPP OMNELGPJKHO, bool MDFPOPFCPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F11820", Offset = "0x5F10C20", VA = "0x185F11820")]
	public static bool OGBNMNMADIE(this NLKIHKBJCMJ HPGFBABPMCF, EHIPCMJHIPP OMNELGPJKHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F11810", Offset = "0x5F10C10", VA = "0x185F11810")]
	public static NLKIHKBJCMJ KFHLOIKFINK(this EHIPCMJHIPP OMNELGPJKHO)
	{
		return default(NLKIHKBJCMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[LBHFJPPIHPK("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[IAFILGKNAJG(HPKPKKLNNBD.NONE, HPKPKKLNNBD.COUNT)]
[Flags]
[global::HJCJIAPJJON(1, false)]
public enum HPKPKKLNNBD
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[LBHFJPPIHPK("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(1000, 8000)]
public enum NMFEMHGADPL
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[FKEBHLCJPHC("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[FKEBHLCJPHC("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[FKEBHLCJPHC("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[FKEBHLCJPHC("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[KIFICBDIIFM]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[FKEBHLCJPHC("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[FKEBHLCJPHC("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[FKEBHLCJPHC("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[FKEBHLCJPHC("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[FKEBHLCJPHC("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[FKEBHLCJPHC("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[FKEBHLCJPHC("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[FKEBHLCJPHC("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[FKEBHLCJPHC("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[FKEBHLCJPHC("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[FKEBHLCJPHC("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[FKEBHLCJPHC("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[FKEBHLCJPHC("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[FKEBHLCJPHC("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[FKEBHLCJPHC("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[FKEBHLCJPHC("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[FKEBHLCJPHC("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[FKEBHLCJPHC("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[FKEBHLCJPHC("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[FKEBHLCJPHC("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[FKEBHLCJPHC("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[FKEBHLCJPHC("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[FKEBHLCJPHC("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[FKEBHLCJPHC("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[FKEBHLCJPHC("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[FKEBHLCJPHC("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[FKEBHLCJPHC("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[FKEBHLCJPHC("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[FKEBHLCJPHC("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[FKEBHLCJPHC("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[FKEBHLCJPHC("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[FKEBHLCJPHC("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[FKEBHLCJPHC("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[FKEBHLCJPHC("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[FKEBHLCJPHC("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[FKEBHLCJPHC("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[FKEBHLCJPHC("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[FKEBHLCJPHC("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[FKEBHLCJPHC("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[FKEBHLCJPHC("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[FKEBHLCJPHC("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[KIFICBDIIFM]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[FKEBHLCJPHC("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[FKEBHLCJPHC("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[FKEBHLCJPHC("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[FKEBHLCJPHC("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[FKEBHLCJPHC("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[FKEBHLCJPHC("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[FKEBHLCJPHC("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[FKEBHLCJPHC("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[FKEBHLCJPHC("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[FKEBHLCJPHC("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[FKEBHLCJPHC("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[FKEBHLCJPHC("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[FKEBHLCJPHC("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[FKEBHLCJPHC("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[FKEBHLCJPHC("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[FKEBHLCJPHC("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KHLEFACBFGL
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F11640", Offset = "0x5F10A40", VA = "0x185F11640")]
	public static OICFMLPAGOA HPOIICJFKKJ(this NMFEMHGADPL KEEKBCHCMJM)
	{
		return default(OICFMLPAGOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[IAFILGKNAJG(0, 9)]
[LBHFJPPIHPK("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::HJCJIAPJJON(1, false)]
public enum OICFMLPAGOA
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class AMKFPKHDAIC
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F10A60", Offset = "0x5F0FE60", VA = "0x185F10A60")]
	public static bool BDHJONCOKCJ(this OICFMLPAGOA GNKLLPIHEBI)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[LBHFJPPIHPK("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::JILHDEHOGJI(1, false)]
	[global::MGHEEAFNLFN(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[global::MBLAPLINKNC(1)]
		[global::NLHDMLEOFGL]
		public GLKBACJABIP shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[global::HJCJIAPJJON(1, false)]
[IAFILGKNAJG(-1, 38)]
[LBHFJPPIHPK("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum GLKBACJABIP
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[global::HJCJIAPJJON(1, false)]
[LBHFJPPIHPK("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[IAFILGKNAJG(0, 7)]
[Flags]
public enum BLNHPOMBHOM
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[LBHFJPPIHPK("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[IAFILGKNAJG(0, 7)]
[Flags]
[global::HJCJIAPJJON(1, false)]
public enum OBMJIKDAHJH
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[global::HJCJIAPJJON(1, false)]
[LBHFJPPIHPK("72742F9B-D48E-4CED-B403-444201FFEE66")]
[IAFILGKNAJG(0, 1)]
[Flags]
public enum KGEOCFAOCCF
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[LBHFJPPIHPK("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[IAFILGKNAJG(-2, 2)]
[global::HJCJIAPJJON(1, false)]
public enum DEBGKELLCHI
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[LBHFJPPIHPK("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[IAFILGKNAJG(int.MinValue, int.MaxValue)]
[global::HJCJIAPJJON(1, false)]
public enum BDELPKJPBPE
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[IAFILGKNAJG(-1, 31)]
[LBHFJPPIHPK("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::HJCJIAPJJON(1, false)]
public enum AICBIGGMGIO
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[global::GNKCJPGAGLG(1, false)]
[LBHFJPPIHPK("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct JJEFHDAOIGH : IComparable<JJEFHDAOIGH>, IEquatable<JJEFHDAOIGH>, OJPJKBNMOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	[global::MBLAPLINKNC(1)]
	public uint EGJMPJFPOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	[global::MBLAPLINKNC(2)]
	public uint DEKDFMNPNLF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint LBPMMCMKMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F11360", Offset = "0x5F10760", VA = "0x185F11360")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F114C0", Offset = "0x5F108C0", VA = "0x185F114C0")]
	public JJEFHDAOIGH(int EGJMPJFPOID, int DPAALPIIIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F114C0", Offset = "0x5F108C0", VA = "0x185F114C0")]
	public JJEFHDAOIGH(uint EGJMPJFPOID, uint DPAALPIIIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F110E0", Offset = "0x5F104E0", VA = "0x185F110E0")]
	public JJEFHDAOIGH CCAFENDGLPF(int ABOMIAEBHEB = 1)
	{
		return default(JJEFHDAOIGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F11170", Offset = "0x5F10570", VA = "0x185F11170")]
	public JJEFHDAOIGH DICKKNGPAKF(int ABOMIAEBHEB = 1)
	{
		return default(JJEFHDAOIGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F111E0", Offset = "0x5F105E0", VA = "0x185F111E0")]
	public static JJEFHDAOIGH EHJAJKEJFFJ(JJEFHDAOIGH JIKBDKDLPCA, JJEFHDAOIGH DOFNKPFHEKJ)
	{
		return default(JJEFHDAOIGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F110B0", Offset = "0x5F104B0", VA = "0x185F110B0")]
	private static uint BMPHLOFDNKF(uint MAGGDEMNFDG, uint LFCFPOEDJCH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F11150", Offset = "0x5F10550", VA = "0x185F11150", Slot = "4")]
	public int CompareTo(JJEFHDAOIGH AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F11280", Offset = "0x5F10680", VA = "0x185F11280", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F113E0", Offset = "0x5F107E0", VA = "0x185F113E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F11260", Offset = "0x5F10660", VA = "0x185F11260", Slot = "5")]
	public bool Equals(JJEFHDAOIGH AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F11310", Offset = "0x5F10710", VA = "0x185F11310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F11370", Offset = "0x5F10770", VA = "0x185F11370", Slot = "6")]
	public void LENOCDGJGPN(KMMKEPKMDBL NADLGELBCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F11040", Offset = "0x5F10440", VA = "0x185F11040", Slot = "7")]
	public void AFFCBAMFOKP(GLEDGJAMEMI AGGHEBELANL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26593A0", Offset = "0x26587A0", VA = "0x1826593A0")]
	public static bool FFFIMEBHMPG(JJEFHDAOIGH JIKBDKDLPCA, JJEFHDAOIGH DOFNKPFHEKJ)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[global::GNKCJPGAGLG(1, false)]
	[LBHFJPPIHPK("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, OJPJKBNMOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[global::MBLAPLINKNC(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D570F0", VA = "0x181D57CF0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public static NetworkGuid CPALPDKLBCM(Guid INAIFGAIEKH)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5F116D0", Offset = "0x5F10AD0", VA = "0x185F116D0", Slot = "4")]
		public bool Equals(NetworkGuid AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x39DE2E0", Offset = "0x39DD6E0", VA = "0x1839DE2E0", Slot = "5")]
		public int CompareTo(NetworkGuid AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5F11700", Offset = "0x5F10B00", VA = "0x185F11700", Slot = "6")]
		public void LENOCDGJGPN(KMMKEPKMDBL NADLGELBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5F11660", Offset = "0x5F10A60", VA = "0x185F11660", Slot = "7")]
		public void AFFCBAMFOKP(GLEDGJAMEMI AGGHEBELANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F117C0", Offset = "0x5F10BC0", VA = "0x185F117C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[global::GNKCJPGAGLG(1, false)]
[LBHFJPPIHPK("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct GFOPHKDCOIF : OJPJKBNMOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[global::MBLAPLINKNC(1)]
	public bool PPMNKMLMNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	[global::MBLAPLINKNC(2)]
	public float3 BBFJDILEIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[global::MBLAPLINKNC(3)]
	public float3 LJMDHLIICJC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F10D50", Offset = "0x5F10150", VA = "0x185F10D50")]
	public GFOPHKDCOIF(float GKNDKBGCHOD, float OGPILMIPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F10D00", Offset = "0x5F10100", VA = "0x185F10D00", Slot = "4")]
	public void LENOCDGJGPN(KMMKEPKMDBL NADLGELBCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F10C90", Offset = "0x5F10090", VA = "0x185F10C90", Slot = "5")]
	public void AFFCBAMFOKP(GLEDGJAMEMI AGGHEBELANL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[global::GNKCJPGAGLG(1, false)]
[LBHFJPPIHPK("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct GLLPKLKIABE : OJPJKBNMOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[global::MBLAPLINKNC(1)]
	public float MMMOJBAMAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[global::MBLAPLINKNC(2)]
	public int FINONKMJMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[global::MBLAPLINKNC(3)]
	public OBMJIKDAHJH HPGFBABPMCF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool NLDHNKPBBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F10E40", Offset = "0x5F10240", VA = "0x185F10E40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F10DD0", Offset = "0x5F101D0", VA = "0x185F10DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AMPIEILFCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F10E30", Offset = "0x5F10230", VA = "0x185F10E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F10DF0", Offset = "0x5F101F0", VA = "0x185F10DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OHFMGPNFCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F10EB0", Offset = "0x5F102B0", VA = "0x185F10EB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F10E10", Offset = "0x5F10210", VA = "0x185F10E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F10D80", Offset = "0x5F10180", VA = "0x185F10D80", Slot = "5")]
	public void AFFCBAMFOKP(GLEDGJAMEMI AGGHEBELANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F10E50", Offset = "0x5F10250", VA = "0x185F10E50", Slot = "4")]
	public void LENOCDGJGPN(KMMKEPKMDBL NADLGELBCMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal class IIEPCNLJJFA : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class KCGIIFPMKME : Property<RRObjectPrefabData, NMFEMHGADPL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string BJAHCKCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5F11610", Offset = "0x5F10A10", VA = "0x185F11610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool OAMNHFOMJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5F11520", Offset = "0x5F10920", VA = "0x185F11520")]
		public KCGIIFPMKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1305790", Offset = "0x1304B90", VA = "0x181305790", Slot = "14")]
		public override NMFEMHGADPL GetValue(RRObjectPrefabData CHBOBHMMJGK)
		{
			return default(NMFEMHGADPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5F11510", Offset = "0x5F10910", VA = "0x185F11510", Slot = "15")]
		public override void SetValue(RRObjectPrefabData CHBOBHMMJGK, NMFEMHGADPL FDFHGIHHGHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5F10EC0", Offset = "0x5F102C0", VA = "0x185F10EC0")]
	public IIEPCNLJJFA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F11840", Offset = "0x5F10C40", VA = "0x185F11840")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
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
