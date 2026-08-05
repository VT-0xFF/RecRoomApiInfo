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
public interface LHEDAECFFLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity ONAMKGBJPDO
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
	[EHJNGADEEBE("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[global::GFECBCFGIBK(1, false)]
	[global::LOGDHPIOBCF(11505792609904010668uL, 0u)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::HPHOMPPIFEE("new float3(float.NaN)")]
		[global::KPANOAMPJIO(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3F24140", Offset = "0x3F23340", VA = "0x183F24140")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x63BDDF0", Offset = "0x63BCFF0", VA = "0x1863BDDF0")]
		public static AuthoredLocalPoseData LOFAPGLBJHK(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[EHJNGADEEBE("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[global::LOGDHPIOBCF(9088562008033959482uL, 0u)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::HPHOMPPIFEE(1f)]
		[global::KPANOAMPJIO(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::LOGDHPIOBCF(10137300772124140051uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, LHEDAECFFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static AuthoredParentData LOFAPGLBJHK(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63BDE10", Offset = "0x63BD010", VA = "0x1863BDE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PIKDFJCDCBJ : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[EHJNGADEEBE("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::HPHOMPPIFEE(false)]
		[global::KPANOAMPJIO(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::HPHOMPPIFEE(BPANFDAIIDA.EnabledForRole)]
		[global::KPANOAMPJIO(3)]
		public BPANFDAIIDA filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[global::LOGDHPIOBCF(8594223769175916906uL, 0u)]
	[EHJNGADEEBE("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::KPANOAMPJIO(2)]
		[global::HPHOMPPIFEE]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[EHJNGADEEBE("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[global::LOGDHPIOBCF(780699438743496039uL, 0u)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::HPHOMPPIFEE(-1)]
		[global::KPANOAMPJIO(1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[EHJNGADEEBE("5ED157AA-488F-453A-A986-594595B8D777")]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[global::LOGDHPIOBCF(11853296779717712500uL, 0u)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[EHJNGADEEBE("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[EHJNGADEEBE("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[global::GFECBCFGIBK(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::HPHOMPPIFEE(0)]
		[global::KPANOAMPJIO(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::LOGDHPIOBCF(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::KPANOAMPJIO(2)]
		[global::HPHOMPPIFEE]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1EDFEE0", Offset = "0x1EDF0E0", VA = "0x181EDFEE0")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1EAA090", Offset = "0x1EA9290", VA = "0x181EAA090")]
		public EntityBundlePartData(Entity prefabRoot, EntityBundlePartId partId)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80")]
		internal EntityBundlePartId(uint IFAFPBGLEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
		internal uint INOMGGCPKDD()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92A880", Offset = "0x929A80", VA = "0x18092A880", Slot = "4")]
		public bool Equals(EntityBundlePartId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63BDE90", Offset = "0x63BD090", VA = "0x1863BDE90", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F9250", Offset = "0x9F8450", VA = "0x1809F9250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1994A80", Offset = "0x1993C80", VA = "0x181994A80")]
		public static bool LOAKJDDAMKI(EntityBundlePartId BPOHBPAMNLC, EntityBundlePartId NOIIDJMAOFK)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[EHGPHLLJHLP("Container", 0)]
	[global::LOGDHPIOBCF(11104975410044731874uL, 0u)]
	[CompilerGenerated]
	[EHJNGADEEBE("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[global::KPANOAMPJIO(1)]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE(COMPIDEPGKL.IsDynamicEnvironment)]
		public COMPIDEPGKL collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HOLJCHDNIOK
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum GPENOHCCPPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum HKHNOJPFLAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63BE1F0", Offset = "0x63BD3F0", VA = "0x1863BE1F0")]
	public static (GPENOHCCPPD, HKHNOJPFLAD) IDCDJIJJCMM(this COMPIDEPGKL HEJPMNEGHKB)
	{
		return default((GPENOHCCPPD, HKHNOJPFLAD));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[EHJNGADEEBE("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[CompilerGenerated]
	[global::LOGDHPIOBCF(2914713536404587710uL, 0u)]
	[EHGPHLLJHLP("Container", 0)]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE(CKCINOKLGJJ.Children)]
		[global::KPANOAMPJIO(1)]
		public CKCINOKLGJJ collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[EHGPHLLJHLP("Container", 0)]
	[CompilerGenerated]
	[global::GFECBCFGIBK(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[EHJNGADEEBE("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::KPANOAMPJIO(1)]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE(ACJBFNFLLFC.DEFAULT)]
		public ACJBFNFLLFC flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[EHJNGADEEBE("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::LOGDHPIOBCF(1094837642118998916uL, 0u)]
	[global::GFECBCFGIBK(1, false)]
	[EHGPHLLJHLP("Container", 0)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::KPANOAMPJIO(1)]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE(0f)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[EHGPHLLJHLP("Container", 0)]
	[EHJNGADEEBE("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::GFECBCFGIBK(1, false)]
	[global::LOGDHPIOBCF(13657791279235747653uL, 0u)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		[JNHBKPCMELB(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[CompilerGenerated]
	[EHGPHLLJHLP("Container", 0)]
	[EHJNGADEEBE("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[global::LOGDHPIOBCF(5176564412348566398uL, 0u)]
	[global::GFECBCFGIBK(1, false)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		[JNHBKPCMELB(null, 0)]
		public NOHKFEMOOIC grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[EHJNGADEEBE("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[CompilerGenerated]
	[EHGPHLLJHLP("Container", 0)]
	[global::LOGDHPIOBCF(16485879999901987510uL, 0u)]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::KPANOAMPJIO(1)]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE(MLBJKKJIKNB.NavMeshGenerator)]
		public MLBJKKJIKNB mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[EHJNGADEEBE("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[global::LOGDHPIOBCF(1537567323754185605uL, 0u)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[global::LOGDHPIOBCF(5115014870530256079uL, 0u)]
	[EHJNGADEEBE("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[EHJNGADEEBE("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	[CompilerGenerated]
	[global::LOGDHPIOBCF(14429493078606832166uL, 0u)]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[global::GFECBCFGIBK(1, false)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[EHJNGADEEBE("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::LOGDHPIOBCF(12111354511484844847uL, 0u)]
	public struct ParentData : IComponentData, LHEDAECFFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, LHEDAECFFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DLAMNMLFKKK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[global::LOGDHPIOBCF(1950029632769634832uL, 0u)]
	[EHJNGADEEBE("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public KFBDLGJJCOB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static SiblingSortOrderData LOFAPGLBJHK(KFBDLGJJCOB value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x63BE430", Offset = "0x63BD630", VA = "0x1863BE430", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	[global::LOGDHPIOBCF(15012400804589552708uL, 0u)]
	[EHJNGADEEBE("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[global::GFECBCFGIBK(1, false)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[EHGPHLLJHLP("Object", 0)]
	[global::LOGDHPIOBCF(16541670854338945984uL, 0u)]
	[global::GFECBCFGIBK(5, false)]
	[EHJNGADEEBE("FB9853D6-6231-43FD-A754-00105DC30880")]
	[CompilerGenerated]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::HPHOMPPIFEE("new ScaleRestriction(1,1)")]
		[global::KPANOAMPJIO(2)]
		public OHGKNMNABPL scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::KPANOAMPJIO(3)]
		public BPFEAHFPDEI userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::KPANOAMPJIO(4)]
		[global::HPHOMPPIFEE(MJCCNDEFHPO.Default)]
		[JNHBKPCMELB(null, 0)]
		public MJCCNDEFHPO circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE("ObjectPolicyEnumFlags.Default")]
		public AJFHKDNNFBP flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::LOGDHPIOBCF(17708500325183871236uL, 0u)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static PlayerScopeData LOFAPGLBJHK(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[global::LOGDHPIOBCF(16642773407304133105uL, 0u)]
	[EHJNGADEEBE("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::GFECBCFGIBK(1, false)]
	[EHGPHLLJHLP("Physics", 0)]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::HPHOMPPIFEE(10f)]
		[global::KPANOAMPJIO(1)]
		[JNHBKPCMELB(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[global::LOGDHPIOBCF(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE(EBPGHJKKMKE.None)]
		public EBPGHJKKMKE flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63BEE20", Offset = "0x63BE020", VA = "0x1863BEE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x63BEE10", Offset = "0x63BE010", VA = "0x1863BEE10")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[global::LOGDHPIOBCF(10917729582819845312uL, 0u)]
	[CompilerGenerated]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public OPOOJGGNJKH shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::LOGDHPIOBCF(5298506180484533559uL, 0u)]
	[EHJNGADEEBE("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public KFBDLGJJCOB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static SplinePointOrderData LOFAPGLBJHK(KFBDLGJJCOB value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[EHJNGADEEBE("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::LOGDHPIOBCF(16368389834000856208uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[global::GFECBCFGIBK(1, false)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[global::LOGDHPIOBCF(18095612727592564636uL, 0u)]
	[EHJNGADEEBE("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	[global::LOGDHPIOBCF(1429513518619209486uL, 0u)]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[EHJNGADEEBE("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[EHJNGADEEBE("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::GFECBCFGIBK(1, false)]
	[global::LOGDHPIOBCF(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::HPHOMPPIFEE("new float3(1)")]
		[global::KPANOAMPJIO(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::LOGDHPIOBCF(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[EHJNGADEEBE("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public GAGNBDNECAG parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[global::LOGDHPIOBCF(10026670690793008625uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[EHJNGADEEBE("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE(GALKKFLEAAI.CURRENT)]
		public GALKKFLEAAI version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[global::HKLPEPCCCLA(new int[] { 1 })]
	[global::LOGDHPIOBCF(12332323170023439017uL, 0u)]
	[global::GFECBCFGIBK(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[EHJNGADEEBE("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::HPHOMPPIFEE(true)]
		[global::KPANOAMPJIO(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::KPANOAMPJIO(3)]
		[global::HPHOMPPIFEE(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[EHJNGADEEBE("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[global::LLJAPAEGNKJ(OFOPNFBNBEJ.MIN, OFOPNFBNBEJ.ALL)]
[global::NGOKNNJGNDC(1, false)]
public enum OFOPNFBNBEJ
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[EHJNGADEEBE("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::HPHOMPPIFEE(15f)]
		[global::KPANOAMPJIO(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::HPHOMPPIFEE(OFOPNFBNBEJ.UseDefaultVisualEffects)]
		[global::KPANOAMPJIO(2)]
		public OFOPNFBNBEJ toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[CompilerGenerated]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[global::KPANOAMPJIO(3)]
		[global::HPHOMPPIFEE]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::GFECBCFGIBK(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[EHJNGADEEBE("021E8703-AAFD-4965-8C38-FF86663126D2")]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[global::HPHOMPPIFEE("new float3(1)")]
		[global::KPANOAMPJIO(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::LOGDHPIOBCF(1369925932270831712uL, 0u)]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE("new quaternion(0,0,0,1)")]
		[global::KPANOAMPJIO(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::KPANOAMPJIO(2)]
		[global::HPHOMPPIFEE]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F24140", Offset = "0x3F23340", VA = "0x183F24140")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63BDDF0", Offset = "0x63BCFF0", VA = "0x1863BDDF0")]
		public static RigidTransform LOFAPGLBJHK(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63BDDF0", Offset = "0x63BCFF0", VA = "0x1863BDDF0")]
		public static LocalPoseData LOFAPGLBJHK(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class IFFENHELPLB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static RigidTransform EEHMCJJPLNJ(this LocalPoseData HLCKBKFCMPI)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[global::LOGDHPIOBCF(2720902521635056246uL, 0u)]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[CompilerGenerated]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::HPHOMPPIFEE(1f)]
		[global::KPANOAMPJIO(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::LOGDHPIOBCF(5730545663584378555uL, 0u)]
	[global::GFECBCFGIBK(1, false)]
	[CompilerGenerated]
	[EHJNGADEEBE("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public HAPEKFPHBJI transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::KPANOAMPJIO(2)]
		[global::HPHOMPPIFEE]
		public GEJPHJHEENL transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CompilerGenerated]
	[global::ALAKDLCHGNI]
	[global::LOGDHPIOBCF(798350452111942523uL, 0u)]
	[EHJNGADEEBE("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::GFECBCFGIBK(1, false)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public LFJMPPMLIHF prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[EHJNGADEEBE("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[global::GFECBCFGIBK(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::KPANOAMPJIO(1)]
		[global::HPHOMPPIFEE]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::KPANOAMPJIO(2)]
		[global::HPHOMPPIFEE(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[EHJNGADEEBE("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::LOGDHPIOBCF(1591066774816564574uL, 0u)]
	[EHGPHLLJHLP("Visual", 0)]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public DNGGAHCCLGO color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[JNHBKPCMELB(null, 0)]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(2)]
		public FDGOEMEGONN material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[global::HPHOMPPIFEE]
		[JNHBKPCMELB(null, 0)]
		[global::KPANOAMPJIO(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(4)]
		[JNHBKPCMELB(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::NGOKNNJGNDC(1, false)]
[global::LLJAPAEGNKJ(MJCCNDEFHPO.NONE, MJCCNDEFHPO.COUNT)]
[EHJNGADEEBE("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum MJCCNDEFHPO
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[JNHBKPCMELB("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[JNHBKPCMELB("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[JNHBKPCMELB("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::LLJAPAEGNKJ(0, 4)]
public enum GMNIOCKHCDC
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::LLJAPAEGNKJ(IIJMDKHCLHM.NONE, IIJMDKHCLHM.ALL)]
[Flags]
public enum IIJMDKHCLHM
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[EHJNGADEEBE("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::LLJAPAEGNKJ(CKCINOKLGJJ.Off, CKCINOKLGJJ.COUNT)]
[global::NGOKNNJGNDC(1, false)]
public enum CKCINOKLGJJ
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[EHJNGADEEBE("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[HENAHGEBLNH]
[global::LLJAPAEGNKJ(GALKKFLEAAI.VERSION_0, GALKKFLEAAI.CURRENT)]
[global::NGOKNNJGNDC(1, false)]
public enum GALKKFLEAAI : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[global::LLJAPAEGNKJ(0, 127)]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("F843A776-E042-43B7-8167-0C7A421062F8")]
public enum COMPIDEPGKL
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[JNHBKPCMELB("Dynamic (Environment)", 0)]
	[LCHPAKJEMCC("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[JNHBKPCMELB("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[JNHBKPCMELB("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[JNHBKPCMELB("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[JNHBKPCMELB("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[JNHBKPCMELB("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[JNHBKPCMELB("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[JNHBKPCMELB("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[JNHBKPCMELB("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[HENAHGEBLNH]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[HENAHGEBLNH]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Flags]
[global::LLJAPAEGNKJ(0, ACJBFNFLLFC.ALL)]
[EHJNGADEEBE("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[global::NGOKNNJGNDC(1, false)]
public enum ACJBFNFLLFC
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[EHJNGADEEBE("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::LLJAPAEGNKJ(0, 2)]
[global::NGOKNNJGNDC(1, false)]
public enum OPOOJGGNJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[global::NGOKNNJGNDC(1, false)]
[global::LLJAPAEGNKJ(NOHKFEMOOIC.Pivot, NOHKFEMOOIC.COUNT)]
[EHJNGADEEBE("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum NOHKFEMOOIC
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[global::LLJAPAEGNKJ(BPANFDAIIDA.EnabledForRole, BPANFDAIIDA.DisabledForRole)]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum BPANFDAIIDA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[global::NGOKNNJGNDC(1, false)]
[global::LLJAPAEGNKJ(MLBJKKJIKNB.NavMeshGenerator, MLBJKKJIKNB.NavMeshBlocker)]
[EHJNGADEEBE("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum MLBJKKJIKNB
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[global::LLJAPAEGNKJ(AJFHKDNNFBP.None, AJFHKDNNFBP.All)]
[Flags]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum AJFHKDNNFBP
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[global::LLJAPAEGNKJ(0, EIPKNFIBHOC.COUNT)]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum EIPKNFIBHOC
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DDILMEPJMPE
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE20", Offset = "0x63BD020", VA = "0x1863BDE20")]
	public static void HNJFJKPNHAB(this AJFHKDNNFBP HOFNLGPBEHO, EIPKNFIBHOC CGEGDBNCGFN, bool AIDBJIBCPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE50", Offset = "0x63BD050", VA = "0x1863BDE50")]
	public static bool PCOCNICKIPP(this AJFHKDNNFBP HOFNLGPBEHO, EIPKNFIBHOC CGEGDBNCGFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D330", Offset = "0x1B5C530", VA = "0x181B5D330")]
	public static AJFHKDNNFBP CEOHDMKBFOL(this EIPKNFIBHOC CGEGDBNCGFN)
	{
		return default(AJFHKDNNFBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[global::NGOKNNJGNDC(1, false)]
[global::LLJAPAEGNKJ(BPFEAHFPDEI.NONE, BPFEAHFPDEI.COUNT)]
[Flags]
[EHJNGADEEBE("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum BPFEAHFPDEI
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[global::NGOKNNJGNDC(1, false)]
[global::LLJAPAEGNKJ(1000, 8000)]
[EHJNGADEEBE("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum LFJMPPMLIHF
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[JNHBKPCMELB("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[JNHBKPCMELB("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[JNHBKPCMELB("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[JNHBKPCMELB("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[HENAHGEBLNH]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[JNHBKPCMELB("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[JNHBKPCMELB("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[JNHBKPCMELB("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[JNHBKPCMELB("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[JNHBKPCMELB("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[JNHBKPCMELB("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[JNHBKPCMELB("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[JNHBKPCMELB("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[JNHBKPCMELB("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[JNHBKPCMELB("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[JNHBKPCMELB("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[JNHBKPCMELB("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[JNHBKPCMELB("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[JNHBKPCMELB("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[JNHBKPCMELB("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[JNHBKPCMELB("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[JNHBKPCMELB("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[JNHBKPCMELB("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[JNHBKPCMELB("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[JNHBKPCMELB("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[JNHBKPCMELB("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[JNHBKPCMELB("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[JNHBKPCMELB("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[JNHBKPCMELB("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[JNHBKPCMELB("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[JNHBKPCMELB("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[JNHBKPCMELB("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[JNHBKPCMELB("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[JNHBKPCMELB("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[JNHBKPCMELB("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[JNHBKPCMELB("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[JNHBKPCMELB("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[JNHBKPCMELB("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[JNHBKPCMELB("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[JNHBKPCMELB("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[JNHBKPCMELB("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[JNHBKPCMELB("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[JNHBKPCMELB("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[JNHBKPCMELB("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[JNHBKPCMELB("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[JNHBKPCMELB("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[HENAHGEBLNH]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[JNHBKPCMELB("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[JNHBKPCMELB("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[JNHBKPCMELB("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[JNHBKPCMELB("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[JNHBKPCMELB("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[JNHBKPCMELB("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[JNHBKPCMELB("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[JNHBKPCMELB("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[JNHBKPCMELB("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[JNHBKPCMELB("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[JNHBKPCMELB("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[JNHBKPCMELB("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[JNHBKPCMELB("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[JNHBKPCMELB("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[JNHBKPCMELB("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[JNHBKPCMELB("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[JNHBKPCMELB("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class EDNLEOLHKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE70", Offset = "0x63BD070", VA = "0x1863BDE70")]
	public static CDEBHKLHJMI MBPHEMCAOHO(this LFJMPPMLIHF KCLAFPDDNOC)
	{
		return default(CDEBHKLHJMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[global::LLJAPAEGNKJ(0, 9)]
[EHJNGADEEBE("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::NGOKNNJGNDC(1, false)]
public enum CDEBHKLHJMI
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class HFLLBMKMCGG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63BE1E0", Offset = "0x63BD3E0", VA = "0x1863BE1E0")]
	public static bool JODGLOKLOFG(this CDEBHKLHJMI LPABBBIOMHI)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[global::LOGDHPIOBCF(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	[global::GFECBCFGIBK(1, false)]
	[EHJNGADEEBE("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[global::HPHOMPPIFEE]
		[global::KPANOAMPJIO(1)]
		public MEENIEMELIG shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::NGOKNNJGNDC(1, false)]
[global::LLJAPAEGNKJ(-1, 38)]
[EHJNGADEEBE("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum MEENIEMELIG
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Flags]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::LLJAPAEGNKJ(0, 7)]
public enum EBPGHJKKMKE
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Flags]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::LLJAPAEGNKJ(0, 7)]
public enum KPNEGFFJEHA
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::LLJAPAEGNKJ(0, 1)]
[Flags]
public enum HAPEKFPHBJI
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[EHJNGADEEBE("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::NGOKNNJGNDC(1, false)]
[global::LLJAPAEGNKJ(-2, 2)]
public enum GEJPHJHEENL
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::LLJAPAEGNKJ(int.MinValue, int.MaxValue)]
public enum DNGGAHCCLGO
{
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[global::LLJAPAEGNKJ(-1, 31)]
[global::NGOKNNJGNDC(1, false)]
[EHJNGADEEBE("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum FDGOEMEGONN
{
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[EHJNGADEEBE("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[global::CGDKAAMFPDB(1, false)]
public struct KFBDLGJJCOB : IComparable<KFBDLGJJCOB>, IEquatable<KFBDLGJJCOB>, ILHEOHOKJAJ
{
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static readonly KFBDLGJJCOB NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[global::KPANOAMPJIO(1)]
	public uint CNPFCKOONHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	[global::KPANOAMPJIO(2)]
	public uint KKFLKNBDOGL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint LNFCCPEGDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x63BE420", Offset = "0x63BD620", VA = "0x1863BE420")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63BE850", Offset = "0x63BDA50", VA = "0x1863BE850")]
	public KFBDLGJJCOB(int CNPFCKOONHC, int ILLMLDJKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63BE850", Offset = "0x63BDA50", VA = "0x1863BE850")]
	public KFBDLGJJCOB(uint CNPFCKOONHC, uint ILLMLDJKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63BE360", Offset = "0x63BD560", VA = "0x1863BE360")]
	public KFBDLGJJCOB CCADEDNPAOG(int CFPEDCFCDGK = 1)
	{
		return default(KFBDLGJJCOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63BE6E0", Offset = "0x63BD8E0", VA = "0x1863BE6E0")]
	public KFBDLGJJCOB JMJCJJDKLBE(int CFPEDCFCDGK = 1)
	{
		return default(KFBDLGJJCOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63BE5D0", Offset = "0x63BD7D0", VA = "0x1863BE5D0")]
	public static KFBDLGJJCOB IGAEIOJHGHA(KFBDLGJJCOB ABPADDODFDF, KFBDLGJJCOB DLCDCNECDEP)
	{
		return default(KFBDLGJJCOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63BE3F0", Offset = "0x63BD5F0", VA = "0x1863BE3F0")]
	private static uint DHDIKJNNNFG(uint BPOHBPAMNLC, uint NOIIDJMAOFK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63BE3D0", Offset = "0x63BD5D0", VA = "0x1863BE3D0", Slot = "4")]
	public int CompareTo(KFBDLGJJCOB JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63BE450", Offset = "0x63BD650", VA = "0x1863BE450", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63BE770", Offset = "0x63BD970", VA = "0x1863BE770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63BE430", Offset = "0x63BD630", VA = "0x1863BE430", Slot = "5")]
	public bool Equals(KFBDLGJJCOB JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x63BE580", Offset = "0x63BD780", VA = "0x1863BE580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x63BE510", Offset = "0x63BD710", VA = "0x1863BE510", Slot = "6")]
	public void GKNEHCEDNDE(AHJFMLMCBMD AELHGGJOBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63BE650", Offset = "0x63BD850", VA = "0x1863BE650", Slot = "7")]
	public void IHPADLGFHBL(GCKPPDHHJOE LAAOMLILGHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29A3930", Offset = "0x29A2B30", VA = "0x1829A3930")]
	public static bool LOAKJDDAMKI(KFBDLGJJCOB ABPADDODFDF, KFBDLGJJCOB DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63BE6C0", Offset = "0x63BD8C0", VA = "0x1863BE6C0")]
	public static bool IICOCCMJGPI(KFBDLGJJCOB ABPADDODFDF, KFBDLGJJCOB DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63BE4F0", Offset = "0x63BD6F0", VA = "0x1863BE4F0")]
	public static bool GDFFKPOOHOO(KFBDLGJJCOB ABPADDODFDF, KFBDLGJJCOB DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63BE750", Offset = "0x63BD950", VA = "0x1863BE750")]
	public static bool MEKLKLAELJI(KFBDLGJJCOB ABPADDODFDF, KFBDLGJJCOB DLCDCNECDEP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[EHJNGADEEBE("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::CGDKAAMFPDB(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, ILHEOHOKJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[global::KPANOAMPJIO(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public static NetworkGuid LOFAPGLBJHK(Guid LDJEJDDHHLO)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x63BE8A0", Offset = "0x63BDAA0", VA = "0x1863BE8A0", Slot = "4")]
		public bool Equals(NetworkGuid JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
		public int CompareTo(NetworkGuid JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x63BE8D0", Offset = "0x63BDAD0", VA = "0x1863BE8D0", Slot = "6")]
		public void GKNEHCEDNDE(AHJFMLMCBMD AELHGGJOBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63BE990", Offset = "0x63BDB90", VA = "0x1863BE990", Slot = "7")]
		public void IHPADLGFHBL(GCKPPDHHJOE LAAOMLILGHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63BEA00", Offset = "0x63BDC00", VA = "0x1863BEA00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[EHJNGADEEBE("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::CGDKAAMFPDB(1, false)]
public struct OHGKNMNABPL : ILHEOHOKJAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[global::KPANOAMPJIO(1)]
	public bool IJMGAKGNGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[global::KPANOAMPJIO(2)]
	public float3 BMCKGNAEHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[global::KPANOAMPJIO(3)]
	public float3 HECBHKKHALB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63BEAE0", Offset = "0x63BDCE0", VA = "0x1863BEAE0")]
	public OHGKNMNABPL(float EEMOHNLEPMA, float GINACGGICNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x63BEA20", Offset = "0x63BDC20", VA = "0x1863BEA20", Slot = "4")]
	public void GKNEHCEDNDE(AHJFMLMCBMD AELHGGJOBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x63BEA70", Offset = "0x63BDC70", VA = "0x1863BEA70", Slot = "5")]
	public void IHPADLGFHBL(GCKPPDHHJOE LAAOMLILGHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[EHJNGADEEBE("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::CGDKAAMFPDB(1, false)]
public struct GAGNBDNECAG : ILHEOHOKJAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[global::KPANOAMPJIO(1)]
	public float PJJOKDHMAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[global::KPANOAMPJIO(2)]
	public int DHLLJPCLCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[global::KPANOAMPJIO(3)]
	public KPNEGFFJEHA HOFNLGPBEHO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PHJFDCGGHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x63BDF50", Offset = "0x63BD150", VA = "0x1863BDF50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x63BE030", Offset = "0x63BD230", VA = "0x1863BE030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HBJEOPCNDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x63BDF40", Offset = "0x63BD140", VA = "0x1863BDF40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63BDF20", Offset = "0x63BD120", VA = "0x1863BDF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool AEJFDMLHLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63BE050", Offset = "0x63BD250", VA = "0x1863BE050")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63BE010", Offset = "0x63BD210", VA = "0x1863BE010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x63BDFC0", Offset = "0x63BD1C0", VA = "0x1863BDFC0", Slot = "5")]
	public void IHPADLGFHBL(GCKPPDHHJOE LAAOMLILGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x63BDF60", Offset = "0x63BD160", VA = "0x1863BDF60", Slot = "4")]
	public void GKNEHCEDNDE(AHJFMLMCBMD AELHGGJOBCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class GNOODMCGPKE : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class PKCLCPOJOCH : Property<RRObjectPrefabData, LFJMPPMLIHF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x63BEC10", Offset = "0x63BDE10", VA = "0x1863BEC10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x63BEB20", Offset = "0x63BDD20", VA = "0x1863BEB20")]
		public PKCLCPOJOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x14D1170", Offset = "0x14D0370", VA = "0x1814D1170", Slot = "14")]
		public override LFJMPPMLIHF GetValue(RRObjectPrefabData IFAAMIKFIMC)
		{
			return default(LFJMPPMLIHF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x63BEB10", Offset = "0x63BDD10", VA = "0x1863BEB10", Slot = "15")]
		public override void SetValue(RRObjectPrefabData IFAAMIKFIMC, LFJMPPMLIHF HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x63BE060", Offset = "0x63BD260", VA = "0x1863BE060")]
	public GNOODMCGPKE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x63BEC40", Offset = "0x63BDE40", VA = "0x1863BEC40")]
		[Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
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
