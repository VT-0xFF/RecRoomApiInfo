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
public interface FDELCCPMKNG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity LCFCJAKPGDA
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
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x47A79E0", Offset = "0x47A6DE0", VA = "0x1847A79E0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA10", Offset = "0x6FA9E10", VA = "0x186FAAA10")]
		public static RigidTransform IDKOEJANABA(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA10", Offset = "0x6FA9E10", VA = "0x186FAAA10")]
		public static AuthoredLocalPoseData IDKOEJANABA(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	[RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static AuthoredParentData IDKOEJANABA(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA30", Offset = "0x6FA9E30", VA = "0x186FAAA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GOGBCMHOHAK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Default(PDKELJPCIHO.EnabledForRole)]
		[RecRoom.DataLayer.Field(3)]
		public PDKELJPCIHO filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RRGuid("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(780699438743496039uL, 0u)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[RRGuid("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[CompilerGenerated]
	[RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FOIIDNDLLKD : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x232B450", Offset = "0x232A850", VA = "0x18232B450")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x231A600", Offset = "0x2319A00", VA = "0x18231A600")]
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
		[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260")]
		internal EntityBundlePartId(uint LPMIIFILJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10")]
		internal uint JCAAHMKCMLM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1B28B80", Offset = "0x1B27F80", VA = "0x181B28B80", Slot = "4")]
		public bool Equals(EntityBundlePartId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA50", Offset = "0x6FA9E50", VA = "0x186FAAA50", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xE73A30", Offset = "0xE72E30", VA = "0x180E73A30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1B28BA0", Offset = "0x1B27FA0", VA = "0x181B28BA0")]
		public static bool FANHDJJNLED(EntityBundlePartId DDIIBBHFODJ, EntityBundlePartId BCCGANGEINF)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(11104975410044731874uL, 0u)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(IEEIAAPPNKJ.IsDynamicEnvironment)]
		public IEEIAAPPNKJ collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AGBGILACALI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum AJNNIGDJFIK
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
	public enum MMHJDFGAAJE
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
	[Cpp2IlInjected.Address(RVA = "0x6FAA7F0", Offset = "0x6FA9BF0", VA = "0x186FAA7F0")]
	public static (AJNNIGDJFIK, MMHJDFGAAJE) HJODPLMJJLF(this IEEIAAPPNKJ HOGNIHDLFAI)
	{
		return default((AJNNIGDJFIK, MMHJDFGAAJE));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.StableTypeHash(2914713536404587710uL, 0u)]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[CompilerGenerated]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(OLIPBANBJJC.Children)]
		public OLIPBANBJJC collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(LAKABHFBLCH.DEFAULT)]
		[RecRoom.DataLayer.Field(1)]
		public LAKABHFBLCH flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(0f)]
		[RecRoom.DataLayer.Field(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[RecRoom.DataLayer.StableTypeHash(5176564412348566398uL, 0u)]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public DOEHBADGEDJ grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Default(NPCMHJCAMLN.NavMeshGenerator)]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public NPCMHJCAMLN mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static InventionIdData IDKOEJANABA(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB410", Offset = "0x6FAA810", VA = "0x186FAB410")]
		public readonly bool HOCEBKBHDBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D892A0", Offset = "0x6D886A0", VA = "0x186D892A0")]
		public static bool HOCEBKBHDBD(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public static InventionInstanceIdData IDKOEJANABA(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ParentData : IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CHCOHBDCFOB : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GPGJJHENEFG order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static SiblingSortOrderData IDKOEJANABA(GPGJJHENEFG value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAE70", Offset = "0x6FAA270", VA = "0x186FAAE70", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAllTagsData : IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	public struct InteractionFilterAnyTagsData : IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(PDKELJPCIHO.Disabled)]
		public PDKELJPCIHO filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[CompilerGenerated]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.NetworkComponent(5, false)]
	[CompilerGenerated]
	[ConfigGroup("Object", 0)]
	[RecRoom.DataLayer.StableTypeHash(16541670854338945984uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public EOAJELELPKP scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		public KLFGHHFCBOI userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[RecRoom.DataLayer.Default(MADKIBJAIEL.Default)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		public MADKIBJAIEL circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public IIPEAPLOMMN flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static PlayerScopeData IDKOEJANABA(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	[RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		[Config(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	[RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[RecRoom.DataLayer.Default(MCBOHJAEBBG.None)]
		[RecRoom.DataLayer.Field(1)]
		public MCBOHJAEBBG flags;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x64D44B0", Offset = "0x64D38B0", VA = "0x1864D44B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x64D44C0", Offset = "0x64D38C0", VA = "0x1864D44C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB680", Offset = "0x6FAAA80", VA = "0x186FAB680")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[CompilerGenerated]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EMNBECFOLHA shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public GPGJJHENEFG order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static SplinePointOrderData IDKOEJANABA(GPGJJHENEFG value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public AHKAPNEMKGD parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[RecRoom.DataLayer.Range(NIJJNBEEDDJ.MIN, NIJJNBEEDDJ.ALL)]
public enum NIJJNBEEDDJ
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
	[RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(NIJJNBEEDDJ.UseDefaultVisualEffects)]
		public NIJJNBEEDDJ toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public CGNBAFLIIGN statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Flags]
[RecRoom.DataLayer.Range(CGNBAFLIIGN.None, CGNBAFLIIGN.ALL)]
[RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum CGNBAFLIIGN
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x47A79E0", Offset = "0x47A6DE0", VA = "0x1847A79E0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA10", Offset = "0x6FA9E10", VA = "0x186FAAA10")]
		public static RigidTransform IDKOEJANABA(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA10", Offset = "0x6FA9E10", VA = "0x186FAAA10")]
		public static LocalPoseData IDKOEJANABA(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MAHGDDFCBIA
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static RigidTransform OPDKDKONDGO(this LocalPoseData HCPAOILCJCB)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CFKLLNFGDHF transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public BHOHGJEEODK transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(798350452111942523uL, 0u)]
	[RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NABGOBFPKKK prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public AEMLLOGJEJB kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct LNBKMMCOKCM : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static LNBKMMCOKCM LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB440", Offset = "0x6FAA840", VA = "0x186FAB440", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer KENGFOGLPKI, ReferenceGroupReferenceBuffer IFGPABAHODO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB90", Offset = "0x9D9F90", VA = "0x1809DAB90", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer NCHBKHMIMGJ)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	public struct AuthoredUserTagReferenceBuffer : JKCDKEJNDAO, IBufferElementData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static AuthoredUserTagReferenceBuffer IDKOEJANABA(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JKCDKEJNDAO : IBufferElementData, FDELCCPMKNG
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB690", Offset = "0x6FAAA90", VA = "0x186FAB690")]
		public static UserTagNameData IDKOEJANABA(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[InternalBufferCapacity(0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct UserTagReferenceBuffer : JKCDKEJNDAO, IBufferElementData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static UserTagReferenceBuffer IDKOEJANABA(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[ConfigGroup("Visual", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public DGJCNJCEEEP color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public DIJCMKAGHOP material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RecRoom.DataLayer.Range(MADKIBJAIEL.NONE, MADKIBJAIEL.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum MADKIBJAIEL
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RecRoom.DataLayer.Range(0, 4)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum DGFIGEKFLDA
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
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(DDKPGEEDCMK.NONE, DDKPGEEDCMK.ALL)]
[Flags]
[RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
public enum DDKPGEEDCMK
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
[RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(OLIPBANBJJC.Off, OLIPBANBJJC.COUNT)]
public enum OLIPBANBJJC
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
[RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 127)]
public enum IEEIAAPPNKJ
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, LAKABHFBLCH.ALL)]
[RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
public enum LAKABHFBLCH
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RecRoom.DataLayer.Range(0, 2)]
[RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum EMNBECFOLHA
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RecRoom.DataLayer.Range(DOEHBADGEDJ.Pivot, DOEHBADGEDJ.COUNT)]
[RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum DOEHBADGEDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[RecRoom.DataLayer.Range(PDKELJPCIHO.EnabledForRole, PDKELJPCIHO.DisabledForRole)]
[RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PDKELJPCIHO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.Range(NPCMHJCAMLN.NavMeshGenerator, NPCMHJCAMLN.NavMeshBlocker)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum NPCMHJCAMLN
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[Flags]
[RecRoom.DataLayer.Range(IIPEAPLOMMN.None, IIPEAPLOMMN.All)]
public enum IIPEAPLOMMN
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, AGDPHKHJMJD.COUNT)]
public enum AGDPHKHJMJD
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GDPBAHOLAAI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAAD0", Offset = "0x6FA9ED0", VA = "0x186FAAAD0")]
	public static void KJLAKIGFJAC(this IIPEAPLOMMN OBCABLKNBMC, AGDPHKHJMJD OHEEMKKCLCJ, bool GLCFJLGEAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAB00", Offset = "0x6FA9F00", VA = "0x186FAAB00")]
	public static bool ODLCFGJDIOH(this IIPEAPLOMMN OBCABLKNBMC, AGDPHKHJMJD OHEEMKKCLCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9DF450", Offset = "0x9DE850", VA = "0x1809DF450")]
	public static IIPEAPLOMMN NLOIIHEHFON(this AGDPHKHJMJD OHEEMKKCLCJ)
	{
		return default(IIPEAPLOMMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[RecRoom.DataLayer.Range(KLFGHHFCBOI.NONE, KLFGHHFCBOI.COUNT)]
[RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum KLFGHHFCBOI
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.Range(1000, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum NABGOBFPKKK
{
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[ConfigIgnore]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[Config("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[Config("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[Config("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[Config("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[Config("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[Config("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[Config("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[Config("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[Config("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[Config("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[Config("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[Config("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[Config("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[Config("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[Config("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[Config("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class LMDGOLBMOPP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB420", Offset = "0x6FAA820", VA = "0x186FAB420")]
	public static BFFJDHLHCFI HIBPFBHOELC(this NABGOBFPKKK FPLGHFJHKOE)
	{
		return default(BFFJDHLHCFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 9)]
public enum BFFJDHLHCFI
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class CGAOBHCLAPG
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAA40", Offset = "0x6FA9E40", VA = "0x186FAAA40")]
	public static bool JHFAILMMDIG(this BFFJDHLHCFI COHEBDMONKG)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public LHOIJIFDHFN shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[RecRoom.DataLayer.Range(-1, 38)]
[RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum LHOIJIFDHFN
{
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[RecRoom.DataLayer.Range(AEMLLOGJEJB.None, AEMLLOGJEJB.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
public enum AEMLLOGJEJB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum MCBOHJAEBBG
{
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
public enum HEMMIIAGOPG
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RecRoom.DataLayer.Range(0, 1)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
public enum CFKLLNFGDHF
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(-2, 2)]
public enum BHOHGJEEODK
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
public enum DGJCNJCEEEP
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[RecRoom.DataLayer.Range(-1, 31)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum DIJCMKAGHOP
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct GPGJJHENEFG : IComparable<GPGJJHENEFG>, IEquatable<GPGJJHENEFG>
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static readonly GPGJJHENEFG MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[RecRoom.DataLayer.Field(1)]
	public uint NJOPOJAECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[RecRoom.DataLayer.Field(2)]
	public uint KJHJGPOBHDI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private readonly uint DNFDDLCJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAFF0", Offset = "0x6FAA3F0", VA = "0x186FAAFF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public readonly bool BDPCGJLEFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAFE0", Offset = "0x6FAA3E0", VA = "0x186FAAFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB1B0", Offset = "0x6FAA5B0", VA = "0x186FAB1B0")]
	public GPGJJHENEFG(int NJOPOJAECGJ, int NKFIPHLJNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB1B0", Offset = "0x6FAA5B0", VA = "0x186FAB1B0")]
	public GPGJJHENEFG(uint NJOPOJAECGJ, uint NKFIPHLJNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB210", Offset = "0x6FAA610", VA = "0x186FAB210")]
	private GPGJJHENEFG(uint NJOPOJAECGJ, uint NKFIPHLJNDB, bool DGPBCBIGOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAF20", Offset = "0x6FAA320", VA = "0x186FAAF20")]
	public GPGJJHENEFG FILMELKFBMK(int LHBPAMEKCBO = 1)
	{
		return default(GPGJJHENEFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB060", Offset = "0x6FAA460", VA = "0x186FAB060")]
	public GPGJJHENEFG PIMJLGJEIAL(int LHBPAMEKCBO = 1)
	{
		return default(GPGJJHENEFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAB80", Offset = "0x6FA9F80", VA = "0x186FAAB80")]
	public static GPGJJHENEFG DGJLHINCHKD(GPGJJHENEFG KLFFMNNBENE, GPGJJHENEFG EHNIKEHCICN)
	{
		return default(GPGJJHENEFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB000", Offset = "0x6FAA400", VA = "0x186FAB000")]
	private static ulong KKBAEJLPGKL(ulong DDIIBBHFODJ, ulong BCCGANGEINF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAB60", Offset = "0x6FA9F60", VA = "0x186FAAB60", Slot = "4")]
	public int CompareTo(GPGJJHENEFG BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAE90", Offset = "0x6FAA290", VA = "0x186FAAE90", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB0D0", Offset = "0x6FAA4D0", VA = "0x186FAB0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAE70", Offset = "0x6FAA270", VA = "0x186FAAE70", Slot = "5")]
	public bool Equals(GPGJJHENEFG BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAF90", Offset = "0x6FAA390", VA = "0x186FAAF90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x30D7810", Offset = "0x30D6C10", VA = "0x1830D7810")]
	public static bool FANHDJJNLED(GPGJJHENEFG KLFFMNNBENE, GPGJJHENEFG EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB040", Offset = "0x6FAA440", VA = "0x186FAB040")]
	public static bool KNIDLJBALLO(GPGJJHENEFG KLFFMNNBENE, GPGJJHENEFG EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAB40", Offset = "0x6FA9F40", VA = "0x186FAAB40")]
	public static bool BPINALJKCHI(GPGJJHENEFG KLFFMNNBENE, GPGJJHENEFG EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAB20", Offset = "0x6FA9F20", VA = "0x186FAAB20")]
	public static bool BFJKHPFJCKM(GPGJJHENEFG KLFFMNNBENE, GPGJJHENEFG EHNIKEHCICN)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public static NetworkGuid IDKOEJANABA(Guid FNECNONNEND)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB460", Offset = "0x6FAA860", VA = "0x186FAB460", Slot = "4")]
		public bool Equals(NetworkGuid BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
		public int CompareTo(NetworkGuid BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB490", Offset = "0x6FAA890", VA = "0x186FAB490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct EOAJELELPKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	[RecRoom.DataLayer.Field(1)]
	public bool JCDOMELOGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[RecRoom.DataLayer.Field(2)]
	public float3 ANFFIEPKGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[RecRoom.DataLayer.Field(3)]
	public float3 JHGAJDGNDGB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8E30", Offset = "0x6FA8230", VA = "0x186FA8E30")]
	public EOAJELELPKP(float OHMCJFFPFMB, float CDDAELCNAGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct AHKAPNEMKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[RecRoom.DataLayer.Field(1)]
	public float AJJJMJCIPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[RecRoom.DataLayer.Field(2)]
	public int APNONPFOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[RecRoom.DataLayer.Field(3)]
	public HEMMIIAGOPG OBCABLKNBMC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MLADAJOKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA00", Offset = "0x6FA9E00", VA = "0x186FAAA00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA9D0", Offset = "0x6FA9DD0", VA = "0x186FAA9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IIKNHDJHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA9F0", Offset = "0x6FA9DF0", VA = "0x186FAA9F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA980", Offset = "0x6FA9D80", VA = "0x186FAA980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DKMLLJDHEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA9A0", Offset = "0x6FA9DA0", VA = "0x186FAA9A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA9B0", Offset = "0x6FA9DB0", VA = "0x186FAA9B0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal class INHMIJMNIAH : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class ADGAOHHMLKH : Property<RRObjectPrefabData, NABGOBFPKKK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6FAA7C0", Offset = "0x6FA9BC0", VA = "0x186FAA7C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA6D0", Offset = "0x6FA9AD0", VA = "0x186FAA6D0")]
		public ADGAOHHMLKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1B43AD0", Offset = "0x1B42ED0", VA = "0x181B43AD0", Slot = "14")]
		public override NABGOBFPKKK GetValue(RRObjectPrefabData CLDCJHAFFHO)
		{
			return default(NABGOBFPKKK);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA6C0", Offset = "0x6FA9AC0", VA = "0x186FAA6C0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData CLDCJHAFFHO, NABGOBFPKKK HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB290", Offset = "0x6FAA690", VA = "0x186FAB290")]
	public INHMIJMNIAH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB4B0", Offset = "0x6FAA8B0", VA = "0x186FAB4B0")]
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
