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
public interface HDFLLLHEFOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity DIPFGKEBCID
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
	[global::ENKFBAECKMH(11505792609904010668uL, 0u)]
	[global::AOKHOFEGODH(1, false)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[HDPAOJIBAJA("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::KACFMFNFHGO("new float3(float.NaN)")]
		[global::DJMGDJBDIKC(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3CC89D0", Offset = "0x3CC79D0", VA = "0x183CC89D0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6151F80", Offset = "0x6150F80", VA = "0x186151F80")]
		public static AuthoredLocalPoseData GGALBBDOOLM(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::ENKFBAECKMH(9088562008033959482uL, 0u)]
	[HDPAOJIBAJA("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::KACFMFNFHGO(1f)]
		[global::DJMGDJBDIKC(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[global::ENKFBAECKMH(10137300772124140051uL, 0u)]
	[HDPAOJIBAJA("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::AOKHOFEGODH(1, false)]
	public struct AuthoredParentData : IComponentData, HDFLLLHEFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
		public static AuthoredParentData GGALBBDOOLM(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6151FA0", Offset = "0x6150FA0", VA = "0x186151FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LCCIOLMGDAB : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[HDPAOJIBAJA("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::KACFMFNFHGO(false)]
		[global::DJMGDJBDIKC(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::KACFMFNFHGO(KNJALDOLDFP.EnabledForRole)]
		[global::DJMGDJBDIKC(3)]
		public KNJALDOLDFP filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[HDPAOJIBAJA("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[global::AOKHOFEGODH(1, false)]
	[global::ENKFBAECKMH(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::DJMGDJBDIKC(2)]
		[global::KACFMFNFHGO]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	[global::ENKFBAECKMH(780699438743496039uL, 0u)]
	[HDPAOJIBAJA("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::KACFMFNFHGO(true)]
		[global::DJMGDJBDIKC(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::KACFMFNFHGO(-1)]
		[global::DJMGDJBDIKC(1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[HDPAOJIBAJA("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[global::AOKHOFEGODH(1, false)]
	[global::ENKFBAECKMH(11853296779717712500uL, 0u)]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[global::ENKFBAECKMH(8536678595025273356uL, 0u)]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E14DF0", Offset = "0x1E13DF0", VA = "0x181E14DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90C4B0", VA = "0x18090D4B0")]
		internal EntityBundlePartId(uint IJKMNFNHLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0")]
		internal uint IIGDIGIMKDJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88EEC0", Offset = "0x88DEC0", VA = "0x18088EEC0", Slot = "4")]
		public bool Equals(EntityBundlePartId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6152280", Offset = "0x6151280", VA = "0x186152280", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x946FF0", Offset = "0x945FF0", VA = "0x180946FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x183F120", Offset = "0x183E120", VA = "0x18183F120")]
		public static bool INAKJEGDKIC(EntityBundlePartId ABLMDKMDGNE, EntityBundlePartId AMHEHNHOGFM)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[CompilerGenerated]
	[NGADABBHJDD("Container", 0)]
	[global::ENKFBAECKMH(11104975410044731874uL, 0u)]
	[HDPAOJIBAJA("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::AOKHOFEGODH(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[GOLJLNIBOLP(null, 0)]
		[global::KACFMFNFHGO(HLPMAFFHFPE.IsDynamicEnvironment)]
		[global::DJMGDJBDIKC(1)]
		public HLPMAFFHFPE collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KPAAEPIAGED
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum BNKDMBIJFMD
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
	public enum DJFHKGGOHAI
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
	[Cpp2IlInjected.Address(RVA = "0x61527F0", Offset = "0x61517F0", VA = "0x1861527F0")]
	public static (BNKDMBIJFMD, DJFHKGGOHAI) LAIPBNPMLDJ(this HLPMAFFHFPE ADMMNLEBHNB)
	{
		return default((BNKDMBIJFMD, DJFHKGGOHAI));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[NGADABBHJDD("Container", 0)]
	[global::ENKFBAECKMH(2914713536404587710uL, 0u)]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	[HDPAOJIBAJA("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[GOLJLNIBOLP(null, 0)]
		[global::KACFMFNFHGO(CDHFHDAPKFA.Children)]
		[global::DJMGDJBDIKC(1)]
		public CDHFHDAPKFA collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::AOKHOFEGODH(2, false)]
	[CompilerGenerated]
	[HDPAOJIBAJA("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[NGADABBHJDD("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::KACFMFNFHGO(KPMECJNFOCC.DEFAULT)]
		[global::DJMGDJBDIKC(1)]
		[GOLJLNIBOLP(null, 0)]
		public KPMECJNFOCC flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::ENKFBAECKMH(1094837642118998916uL, 0u)]
	[NGADABBHJDD("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::KACFMFNFHGO(0f)]
		[GOLJLNIBOLP(null, 0)]
		[global::DJMGDJBDIKC(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[global::ENKFBAECKMH(13657791279235747653uL, 0u)]
	[HDPAOJIBAJA("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::AOKHOFEGODH(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[NGADABBHJDD("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		[GOLJLNIBOLP(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[HDPAOJIBAJA("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[NGADABBHJDD("Container", 0)]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[global::ENKFBAECKMH(5176564412348566398uL, 0u)]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		[GOLJLNIBOLP(null, 0)]
		public DCGLFJKGGOD grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	[global::ENKFBAECKMH(16485879999901987510uL, 0u)]
	[HDPAOJIBAJA("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[NGADABBHJDD("Container", 0)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::DJMGDJBDIKC(1)]
		[GOLJLNIBOLP(null, 0)]
		[global::KACFMFNFHGO(HPFLICBCNBK.NavMeshGenerator)]
		public HPFLICBCNBK mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::ENKFBAECKMH(1537567323754185605uL, 0u)]
	[HDPAOJIBAJA("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::AOKHOFEGODH(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[HDPAOJIBAJA("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::AOKHOFEGODH(1, false)]
	[global::ENKFBAECKMH(5115014870530256079uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[global::ENKFBAECKMH(14429493078606832166uL, 0u)]
	[HDPAOJIBAJA("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::AOKHOFEGODH(1, false)]
	[global::ENKFBAECKMH(12111354511484844847uL, 0u)]
	[HDPAOJIBAJA("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, HDFLLLHEFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, HDFLLLHEFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KHPBHHKBMBO : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[HDPAOJIBAJA("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::AOKHOFEGODH(1, false)]
	[global::ENKFBAECKMH(15012400804589552708uL, 0u)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[global::AOKHOFEGODH(5, false)]
	[NGADABBHJDD("Object", 0)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::ENKFBAECKMH(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[HDPAOJIBAJA("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::DJMGDJBDIKC(2)]
		[global::KACFMFNFHGO("new ScaleRestriction(1,1)")]
		public DIOGDHPIICB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[GOLJLNIBOLP(null, 0)]
		[global::KACFMFNFHGO("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::DJMGDJBDIKC(3)]
		public EPPCAEDGIAE userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::KACFMFNFHGO(FOIDHFLBELL.Default)]
		[GOLJLNIBOLP(null, 0)]
		[global::DJMGDJBDIKC(4)]
		public FOIDHFLBELL circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO("ObjectPolicyEnumFlags.Default")]
		public GBCMIJBHFFJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[global::ENKFBAECKMH(17708500325183871236uL, 0u)]
	[HDPAOJIBAJA("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
		public static PlayerScopeData GGALBBDOOLM(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[global::ENKFBAECKMH(16642773407304133105uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[HDPAOJIBAJA("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::AOKHOFEGODH(1, false)]
	[NGADABBHJDD("Physics", 0)]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::KACFMFNFHGO(10f)]
		[GOLJLNIBOLP(null, 0)]
		[global::DJMGDJBDIKC(1)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	[global::ENKFBAECKMH(10537432342869025182uL, 0u)]
	[HDPAOJIBAJA("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::KACFMFNFHGO(DIPCEMIMPMH.None)]
		[global::DJMGDJBDIKC(1)]
		public DIPCEMIMPMH flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6152F30", Offset = "0x6151F30", VA = "0x186152F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6152F40", Offset = "0x6151F40", VA = "0x186152F40")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[global::ENKFBAECKMH(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public JIGEFLCICEA shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[global::ENKFBAECKMH(5298506180484533559uL, 0u)]
	[HDPAOJIBAJA("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[global::AOKHOFEGODH(1, false)]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public HFCIOEOECBJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
		public static SplinePointOrderData GGALBBDOOLM(HFCIOEOECBJ value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::AOKHOFEGODH(1, false)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[HDPAOJIBAJA("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::ENKFBAECKMH(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[global::AOKHOFEGODH(1, false)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[CompilerGenerated]
	[global::ENKFBAECKMH(18095612727592564636uL, 0u)]
	[HDPAOJIBAJA("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::ENKFBAECKMH(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::ENKFBAECKMH(1238044349990854547uL, 0u)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::KACFMFNFHGO("new float3(1)")]
		[global::DJMGDJBDIKC(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[HDPAOJIBAJA("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::AOKHOFEGODH(1, false)]
	[global::ENKFBAECKMH(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public MKFECDAPJFD parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[global::ENKFBAECKMH(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[HDPAOJIBAJA("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::AOKHOFEGODH(1, false)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::KACFMFNFHGO(MBBLILPOINK.CURRENT)]
		[global::DJMGDJBDIKC(1)]
		public MBBLILPOINK version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[global::KGJKADIIPKA(new int[] { 1 })]
	[global::ENKFBAECKMH(12332323170023439017uL, 0u)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[HDPAOJIBAJA("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::AOKHOFEGODH(2, false)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::DJMGDJBDIKC(2)]
		[global::KACFMFNFHGO(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::KACFMFNFHGO(true)]
		[global::DJMGDJBDIKC(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::ENKFBAECKMH(2711391707957742092uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[CompilerGenerated]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("021E8703-AAFD-4965-8C38-FF86663126D2")]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	[HDPAOJIBAJA("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::ENKFBAECKMH(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO("new quaternion(0,0,0,1)")]
		[GOLJLNIBOLP(null, 0)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::DJMGDJBDIKC(2)]
		[global::KACFMFNFHGO]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC89D0", Offset = "0x3CC79D0", VA = "0x183CC89D0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6151F80", Offset = "0x6150F80", VA = "0x186151F80")]
		public static RigidTransform GGALBBDOOLM(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6151F80", Offset = "0x6150F80", VA = "0x186151F80")]
		public static LocalPoseData GGALBBDOOLM(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JJKDBCNFMBH
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static RigidTransform EKMGOJDDIDD(this LocalPoseData CFJDHAGGAJO)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[HDPAOJIBAJA("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::ENKFBAECKMH(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[global::AOKHOFEGODH(1, false)]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::KACFMFNFHGO(1f)]
		[global::DJMGDJBDIKC(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::ENKFBAECKMH(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public JMJJMFCIOBF transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::DJMGDJBDIKC(2)]
		[global::KACFMFNFHGO]
		public OCNMEONOIHE transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::BLEDMOJGOGB]
	[CompilerGenerated]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::ENKFBAECKMH(798350452111942523uL, 0u)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(1)]
		public EFKHMPACCDB prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::AOKHOFEGODH(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[HDPAOJIBAJA("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::KACFMFNFHGO(false)]
		[global::DJMGDJBDIKC(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::AOKHOFEGODH(1, false)]
	[HDPAOJIBAJA("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::ENKFBAECKMH(1591066774816564574uL, 0u)]
	[NGADABBHJDD("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		[GOLJLNIBOLP(null, 0)]
		public PIKEMHDKICN color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::DJMGDJBDIKC(2)]
		[global::KACFMFNFHGO]
		[GOLJLNIBOLP(null, 0)]
		public KDGIIONBBNP material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::DJMGDJBDIKC(3)]
		[global::KACFMFNFHGO]
		[GOLJLNIBOLP(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::KACFMFNFHGO]
		[global::DJMGDJBDIKC(4)]
		[GOLJLNIBOLP(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[MCGDCLNMEMD(FOIDHFLBELL.NONE, FOIDHFLBELL.COUNT)]
[HDPAOJIBAJA("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::BAEELNAIKII(1, false)]
public enum FOIDHFLBELL
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[GOLJLNIBOLP("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[GOLJLNIBOLP("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[GOLJLNIBOLP("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[MCGDCLNMEMD(0, 4)]
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum PCIOKIOFFJO
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
[HDPAOJIBAJA("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::BAEELNAIKII(1, false)]
[MCGDCLNMEMD(KJOOOBKOLKO.NONE, KJOOOBKOLKO.ALL)]
[Flags]
public enum KJOOOBKOLKO
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
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[MCGDCLNMEMD(CDHFHDAPKFA.Off, CDHFHDAPKFA.COUNT)]
public enum CDHFHDAPKFA
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
[MCGDCLNMEMD(MBBLILPOINK.VERSION_0, MBBLILPOINK.CURRENT)]
[HDPAOJIBAJA("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::BAEELNAIKII(1, false)]
[LNHHKPOMIGE]
public enum MBBLILPOINK : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[MCGDCLNMEMD(0, 127)]
[HDPAOJIBAJA("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::BAEELNAIKII(1, false)]
public enum HLPMAFFHFPE
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[HLGBECLALKJ("Indicating it can be walked on and moved")]
	[GOLJLNIBOLP("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[GOLJLNIBOLP("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[GOLJLNIBOLP("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[GOLJLNIBOLP("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[GOLJLNIBOLP("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[GOLJLNIBOLP("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[GOLJLNIBOLP("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[GOLJLNIBOLP("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[GOLJLNIBOLP("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[LNHHKPOMIGE]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[LNHHKPOMIGE]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Flags]
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[MCGDCLNMEMD(0, KPMECJNFOCC.ALL)]
public enum KPMECJNFOCC
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
[MCGDCLNMEMD(0, 2)]
[HDPAOJIBAJA("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::BAEELNAIKII(1, false)]
public enum JIGEFLCICEA
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
[HDPAOJIBAJA("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::BAEELNAIKII(1, false)]
[MCGDCLNMEMD(DCGLFJKGGOD.Pivot, DCGLFJKGGOD.COUNT)]
public enum DCGLFJKGGOD
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
[MCGDCLNMEMD(KNJALDOLDFP.EnabledForRole, KNJALDOLDFP.DisabledForRole)]
[HDPAOJIBAJA("c0973732-e735-44cd-9727-a9a79bad01e3")]
[global::BAEELNAIKII(1, false)]
public enum KNJALDOLDFP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[HDPAOJIBAJA("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::BAEELNAIKII(1, false)]
[MCGDCLNMEMD(HPFLICBCNBK.NavMeshGenerator, HPFLICBCNBK.NavMeshBlocker)]
public enum HPFLICBCNBK
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
[MCGDCLNMEMD(GBCMIJBHFFJ.None, GBCMIJBHFFJ.All)]
[global::BAEELNAIKII(1, false)]
[Flags]
[HDPAOJIBAJA("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum GBCMIJBHFFJ
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[MCGDCLNMEMD(0, KPJAMHKNIOE.COUNT)]
public enum KPJAMHKNIOE
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
public static class EHPOHPLODFH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6152250", Offset = "0x6151250", VA = "0x186152250")]
	public static void PCMENIKJJKG(this GBCMIJBHFFJ LKCCHOABBBP, KPJAMHKNIOE ANMEJFKIBAK, bool DLLADFNIMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6152230", Offset = "0x6151230", VA = "0x186152230")]
	public static bool NBEMDDOHNPD(this GBCMIJBHFFJ LKCCHOABBBP, KPJAMHKNIOE ANMEJFKIBAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6152220", Offset = "0x6151220", VA = "0x186152220")]
	public static GBCMIJBHFFJ CJHBBAFAAEP(this KPJAMHKNIOE ANMEJFKIBAK)
	{
		return default(GBCMIJBHFFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[MCGDCLNMEMD(EPPCAEDGIAE.NONE, EPPCAEDGIAE.COUNT)]
[Flags]
[HDPAOJIBAJA("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[global::BAEELNAIKII(1, false)]
public enum EPPCAEDGIAE
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
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[MCGDCLNMEMD(1000, 8000)]
public enum EFKHMPACCDB
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[GOLJLNIBOLP("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[GOLJLNIBOLP("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[GOLJLNIBOLP("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[GOLJLNIBOLP("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[LNHHKPOMIGE]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[GOLJLNIBOLP("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[GOLJLNIBOLP("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[GOLJLNIBOLP("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[GOLJLNIBOLP("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[GOLJLNIBOLP("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[GOLJLNIBOLP("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[GOLJLNIBOLP("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[GOLJLNIBOLP("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[GOLJLNIBOLP("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[GOLJLNIBOLP("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[GOLJLNIBOLP("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[GOLJLNIBOLP("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[GOLJLNIBOLP("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[GOLJLNIBOLP("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[GOLJLNIBOLP("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[GOLJLNIBOLP("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[GOLJLNIBOLP("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[GOLJLNIBOLP("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[GOLJLNIBOLP("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[GOLJLNIBOLP("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[GOLJLNIBOLP("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[GOLJLNIBOLP("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[GOLJLNIBOLP("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[GOLJLNIBOLP("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[GOLJLNIBOLP("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[GOLJLNIBOLP("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[GOLJLNIBOLP("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[GOLJLNIBOLP("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[GOLJLNIBOLP("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[GOLJLNIBOLP("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[GOLJLNIBOLP("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[GOLJLNIBOLP("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[GOLJLNIBOLP("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[GOLJLNIBOLP("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[GOLJLNIBOLP("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[GOLJLNIBOLP("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[GOLJLNIBOLP("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[GOLJLNIBOLP("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[GOLJLNIBOLP("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[GOLJLNIBOLP("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[GOLJLNIBOLP("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[LNHHKPOMIGE]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[GOLJLNIBOLP("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[GOLJLNIBOLP("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[GOLJLNIBOLP("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[GOLJLNIBOLP("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[GOLJLNIBOLP("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[GOLJLNIBOLP("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[GOLJLNIBOLP("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[GOLJLNIBOLP("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[GOLJLNIBOLP("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[GOLJLNIBOLP("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[GOLJLNIBOLP("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[GOLJLNIBOLP("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[GOLJLNIBOLP("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[GOLJLNIBOLP("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[GOLJLNIBOLP("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[GOLJLNIBOLP("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[GOLJLNIBOLP("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ILNPHJPDDBB
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61527D0", Offset = "0x61517D0", VA = "0x1861527D0")]
	public static OIPDPDBBJEC LFPJIIBGNOJ(this EFKHMPACCDB CMPCNPHKCOC)
	{
		return default(OIPDPDBBJEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[MCGDCLNMEMD(0, 9)]
[HDPAOJIBAJA("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::BAEELNAIKII(1, false)]
public enum OIPDPDBBJEC
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
public static class MKDJBFIHEPL
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6152960", Offset = "0x6151960", VA = "0x186152960")]
	public static bool LFOEGCLFDLK(this OIPDPDBBJEC OHFIKOHINAC)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[global::AOKHOFEGODH(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[HDPAOJIBAJA("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::ENKFBAECKMH(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[global::DJMGDJBDIKC(1)]
		[global::KACFMFNFHGO]
		public MOFBPNJFCKE shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("517224CC-0A79-4FE9-B048-53C37955D823")]
[MCGDCLNMEMD(-1, 38)]
public enum MOFBPNJFCKE
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
[MCGDCLNMEMD(0, 7)]
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
public enum DIPCEMIMPMH
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
[HDPAOJIBAJA("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::BAEELNAIKII(1, false)]
[MCGDCLNMEMD(0, 7)]
[Flags]
public enum CCMPKAAKLAJ
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
[MCGDCLNMEMD(0, 1)]
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("72742F9B-D48E-4CED-B403-444201FFEE66")]
public enum JMJJMFCIOBF
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
[global::BAEELNAIKII(1, false)]
[MCGDCLNMEMD(-2, 2)]
[HDPAOJIBAJA("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum OCNMEONOIHE
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
[global::BAEELNAIKII(1, false)]
[MCGDCLNMEMD(int.MinValue, int.MaxValue)]
[HDPAOJIBAJA("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum PIKEMHDKICN
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
[global::BAEELNAIKII(1, false)]
[HDPAOJIBAJA("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[MCGDCLNMEMD(-1, 31)]
public enum KDGIIONBBNP
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
[global::PACGLFHHELO(1, false)]
[HDPAOJIBAJA("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct HFCIOEOECBJ : IComparable<HFCIOEOECBJ>, IEquatable<HFCIOEOECBJ>, JKBNCBNOOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[global::DJMGDJBDIKC(1)]
	public uint LMDNJJFKPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[global::DJMGDJBDIKC(2)]
	public uint HNMGEAIDNMN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint KHNOLMACODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6152300", Offset = "0x6151300", VA = "0x186152300")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6152780", Offset = "0x6151780", VA = "0x186152780")]
	public HFCIOEOECBJ(int LMDNJJFKPEN, int EPFNHECHFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6152780", Offset = "0x6151780", VA = "0x186152780")]
	public HFCIOEOECBJ(uint LMDNJJFKPEN, uint EPFNHECHFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61525C0", Offset = "0x61515C0", VA = "0x1861525C0")]
	public HFCIOEOECBJ NPHDKHPAILG(int CNHEAECNOFO = 1)
	{
		return default(HFCIOEOECBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6152310", Offset = "0x6151310", VA = "0x186152310")]
	public HFCIOEOECBJ BDNCLMFJOND(int CNHEAECNOFO = 1)
	{
		return default(HFCIOEOECBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6152450", Offset = "0x6151450", VA = "0x186152450")]
	public static HFCIOEOECBJ FEHAHOCNOOC(HFCIOEOECBJ FKOPFOECIGH, HFCIOEOECBJ DGKDEKELGHC)
	{
		return default(HFCIOEOECBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6152520", Offset = "0x6151520", VA = "0x186152520")]
	private static uint MAPHBLGCKEI(uint ABLMDKMDGNE, uint AMHEHNHOGFM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6152380", Offset = "0x6151380", VA = "0x186152380", Slot = "4")]
	public int CompareTo(HFCIOEOECBJ PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61523A0", Offset = "0x61513A0", VA = "0x1861523A0", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61526A0", Offset = "0x61516A0", VA = "0x1861526A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6152430", Offset = "0x6151430", VA = "0x186152430", Slot = "5")]
	public bool Equals(HFCIOEOECBJ PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61524D0", Offset = "0x61514D0", VA = "0x1861524D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6152630", Offset = "0x6151630", VA = "0x186152630", Slot = "6")]
	public void PAKOMNGHIKD(CEJHINEKEHI HKMKHKLNOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6152550", Offset = "0x6151550", VA = "0x186152550", Slot = "7")]
	public void MPIEPNPHGIA(MMHLAJAPJHB PCOFGFPALLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28EBF20", Offset = "0x28EAF20", VA = "0x1828EBF20")]
	public static bool INAKJEGDKIC(HFCIOEOECBJ FKOPFOECIGH, HFCIOEOECBJ DGKDEKELGHC)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[HDPAOJIBAJA("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::PACGLFHHELO(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, JKBNCBNOOGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[global::DJMGDJBDIKC(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public static NetworkGuid GGALBBDOOLM(Guid IECJFMHCKJI)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6152BE0", Offset = "0x6151BE0", VA = "0x186152BE0", Slot = "4")]
		public bool Equals(NetworkGuid PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
		public int CompareTo(NetworkGuid PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6152C80", Offset = "0x6151C80", VA = "0x186152C80", Slot = "6")]
		public void PAKOMNGHIKD(CEJHINEKEHI HKMKHKLNOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6152C10", Offset = "0x6151C10", VA = "0x186152C10", Slot = "7")]
		public void MPIEPNPHGIA(MMHLAJAPJHB PCOFGFPALLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6152D40", Offset = "0x6151D40", VA = "0x186152D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[HDPAOJIBAJA("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::PACGLFHHELO(1, false)]
public struct DIOGDHPIICB : JKBNCBNOOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[global::DJMGDJBDIKC(1)]
	public bool PNLCCPNIGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[global::DJMGDJBDIKC(2)]
	public float3 EEBHMMCHBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[global::DJMGDJBDIKC(3)]
	public float3 INEIBBBBIJB;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6152070", Offset = "0x6151070", VA = "0x186152070")]
	public DIOGDHPIICB(float HLCLGLDIPMH, float LHMDJADHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6152020", Offset = "0x6151020", VA = "0x186152020", Slot = "4")]
	public void PAKOMNGHIKD(CEJHINEKEHI HKMKHKLNOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6151FB0", Offset = "0x6150FB0", VA = "0x186151FB0", Slot = "5")]
	public void MPIEPNPHGIA(MMHLAJAPJHB PCOFGFPALLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[HDPAOJIBAJA("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::PACGLFHHELO(1, false)]
public struct MKFECDAPJFD : JKBNCBNOOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[global::DJMGDJBDIKC(1)]
	public float DDEBJJDMENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[global::DJMGDJBDIKC(2)]
	public int FNMJBCJCLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[global::DJMGDJBDIKC(3)]
	public CCMPKAAKLAJ LKCCHOABBBP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DNFFBPMNPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61529A0", Offset = "0x61519A0", VA = "0x1861529A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61529B0", Offset = "0x61519B0", VA = "0x1861529B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OEAMMDEMPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6152A20", Offset = "0x6151A20", VA = "0x186152A20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6152970", Offset = "0x6151970", VA = "0x186152970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EGAPJCJDJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6152990", Offset = "0x6151990", VA = "0x186152990")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6152A30", Offset = "0x6151A30", VA = "0x186152A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61529D0", Offset = "0x61519D0", VA = "0x1861529D0", Slot = "5")]
	public void MPIEPNPHGIA(MMHLAJAPJHB PCOFGFPALLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6152A50", Offset = "0x6151A50", VA = "0x186152A50", Slot = "4")]
	public void PAKOMNGHIKD(CEJHINEKEHI HKMKHKLNOHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class EHHLCBDPAEF : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class NLPDDMONLBK : Property<RRObjectPrefabData, EFKHMPACCDB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string JJGLPFPAGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6152BB0", Offset = "0x6151BB0", VA = "0x186152BB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool LMHDAJNCEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6152AC0", Offset = "0x6151AC0", VA = "0x186152AC0")]
		public NLPDDMONLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x13CBC20", Offset = "0x13CAC20", VA = "0x1813CBC20", Slot = "14")]
		public override EFKHMPACCDB GetValue(RRObjectPrefabData CNBEIAALEIM)
		{
			return default(EFKHMPACCDB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6152AB0", Offset = "0x6151AB0", VA = "0x186152AB0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData CNBEIAALEIM, EFKHMPACCDB CFJDHAGGAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61520A0", Offset = "0x61510A0", VA = "0x1861520A0")]
	public EHHLCBDPAEF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6152D60", Offset = "0x6151D60", VA = "0x186152D60")]
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
