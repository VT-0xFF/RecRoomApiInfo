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
public interface MJOBODLPDGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity NAKLFKJFBME
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
	[MJJNOMFLNIA("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[global::GAHNAPGDIBF(11505792609904010668uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[global::AGEBCKCKHNP(1, false)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::AKOGMCGBMOC(2)]
		[global::PNBPGPEMEPB("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x420D5B0", Offset = "0x420C9B0", VA = "0x18420D5B0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68B6000", Offset = "0x68B5400", VA = "0x1868B6000")]
		public static RigidTransform JHFAHDJBNPM(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68B6000", Offset = "0x68B5400", VA = "0x1868B6000")]
		public static AuthoredLocalPoseData JHFAHDJBNPM(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[global::GAHNAPGDIBF(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::GAHNAPGDIBF(10137300772124140051uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[MJJNOMFLNIA("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[global::AGEBCKCKHNP(1, false)]
	public struct AuthoredParentData : IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static AuthoredParentData JHFAHDJBNPM(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68B6020", Offset = "0x68B5420", VA = "0x1868B6020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GHANMNKCLMM : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[MJJNOMFLNIA("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[global::AGEBCKCKHNP(1, false)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::PNBPGPEMEPB(false)]
		[global::AKOGMCGBMOC(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::PNBPGPEMEPB(EGMMDFJLLMC.EnabledForRole)]
		[global::AKOGMCGBMOC(3)]
		public EGMMDFJLLMC filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(8594223769175916906uL, 0u)]
	[MJJNOMFLNIA("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(780699438743496039uL, 0u)]
	[MJJNOMFLNIA("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[global::AGEBCKCKHNP(1, false)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[MJJNOMFLNIA("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[CompilerGenerated]
	[MJJNOMFLNIA("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::AGEBCKCKHNP(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::AKOGMCGBMOC(2)]
		[global::PNBPGPEMEPB(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PDNDIJKMEKE : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[MJJNOMFLNIA("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[MJJNOMFLNIA("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[global::AGEBCKCKHNP(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[MJJNOMFLNIA("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD620", Offset = "0x1FDCA20", VA = "0x181FDD620")]
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
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		internal EntityBundlePartId(uint GNBDDFJPEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB50400", Offset = "0xB4F800", VA = "0x180B50400")]
		internal uint IBKDGALJCGJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAE6B50", Offset = "0xAE5F50", VA = "0x180AE6B50", Slot = "4")]
		public bool Equals(EntityBundlePartId IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68B6310", Offset = "0x68B5710", VA = "0x1868B6310", Slot = "0")]
		public override bool Equals(object LALIGKIKEBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB7F990", Offset = "0xB7ED90", VA = "0x180B7F990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1B75460", Offset = "0x1B74860", VA = "0x181B75460")]
		public static bool JAICCEKEELH(EntityBundlePartId DKLJHPKNDLA, EntityBundlePartId EALBLGNMNKM)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[global::GAHNAPGDIBF(11104975410044731874uL, 0u)]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	[DLPBPDJNJDG("Container", 0)]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[MJJNOMFLNIA("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[global::AKOGMCGBMOC(1)]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB(CGABIILCBOJ.IsDynamicEnvironment)]
		public CGABIILCBOJ collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EOAIKPKALLO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PMNKJLFHOHH
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
	public enum FGHBHPAIALL
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
	[Cpp2IlInjected.Address(RVA = "0x68B61A0", Offset = "0x68B55A0", VA = "0x1868B61A0")]
	public static (PMNKJLFHOHH, FGHBHPAIALL) NBJMILMAEPF(this CGABIILCBOJ OMHGPEMHKCO)
	{
		return default((PMNKJLFHOHH, FGHBHPAIALL));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[CompilerGenerated]
	[DLPBPDJNJDG("Container", 0)]
	[global::GAHNAPGDIBF(2914713536404587710uL, 0u)]
	[MJJNOMFLNIA("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[global::AGEBCKCKHNP(1, false)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::PNBPGPEMEPB(MPLDKJGCKEE.Children)]
		[NNGIDPKMIAE(null, 0)]
		[global::AKOGMCGBMOC(1)]
		public MPLDKJGCKEE collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[DLPBPDJNJDG("Container", 0)]
	[global::AGEBCKCKHNP(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[MJJNOMFLNIA("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::AKOGMCGBMOC(1)]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB(DAMGCJMCCIG.DEFAULT)]
		public DAMGCJMCCIG flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::GAHNAPGDIBF(1094837642118998916uL, 0u)]
	[DLPBPDJNJDG("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::PNBPGPEMEPB(0f)]
		[global::AKOGMCGBMOC(1)]
		[NNGIDPKMIAE(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[DLPBPDJNJDG("Container", 0)]
	[global::GAHNAPGDIBF(13657791279235747653uL, 0u)]
	[MJJNOMFLNIA("89708D57-D027-494A-A159-221E6C643B6B")]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[global::GAHNAPGDIBF(5176564412348566398uL, 0u)]
	[MJJNOMFLNIA("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[DLPBPDJNJDG("Container", 0)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		[NNGIDPKMIAE(null, 0)]
		public JHABCFCICMM grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DLPBPDJNJDG("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[global::GAHNAPGDIBF(16485879999901987510uL, 0u)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::AKOGMCGBMOC(1)]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB(JOPBHOLNLCN.NavMeshGenerator)]
		public JOPBHOLNLCN mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[MJJNOMFLNIA("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::GAHNAPGDIBF(1537567323754185605uL, 0u)]
	[global::AGEBCKCKHNP(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[MJJNOMFLNIA("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(5115014870530256079uL, 0u)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[MJJNOMFLNIA("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::GAHNAPGDIBF(12111354511484844847uL, 0u)]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	public struct ParentData : IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EIHAIPGCBOG : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[MJJNOMFLNIA("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(1950029632769634832uL, 0u)]
	[global::AGEBCKCKHNP(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public PGMGELDGJBM order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static SiblingSortOrderData JHFAHDJBNPM(PGMGELDGJBM value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68B6AA0", Offset = "0x68B5EA0", VA = "0x1868B6AA0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[MJJNOMFLNIA("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[CompilerGenerated]
	[MJJNOMFLNIA("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	public struct InteractionFilterAnyTagsData : IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[MJJNOMFLNIA("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::PNBPGPEMEPB(EGMMDFJLLMC.Disabled)]
		[global::AKOGMCGBMOC(1)]
		public EGMMDFJLLMC filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[MJJNOMFLNIA("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	public struct InteractionFilterNoneTagsData : IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[global::GAHNAPGDIBF(15012400804589552708uL, 0u)]
	[MJJNOMFLNIA("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[MJJNOMFLNIA("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::AGEBCKCKHNP(5, false)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
	[MJJNOMFLNIA("FB9853D6-6231-43FD-A754-00105DC30880")]
	[DLPBPDJNJDG("Object", 0)]
	[global::GAHNAPGDIBF(16541670854338945984uL, 0u)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::AKOGMCGBMOC(2)]
		[global::PNBPGPEMEPB("new ScaleRestriction(1,1)")]
		public HEBJPGKPDLA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::AKOGMCGBMOC(3)]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		public NBGHNPHLDEF userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB(AHPHGHKBDEP.Default)]
		[global::AKOGMCGBMOC(4)]
		public AHPHGHKBDEP circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB("ObjectPolicyEnumFlags.Default")]
		public ODOPAAAPLKE flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[MJJNOMFLNIA("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::AGEBCKCKHNP(1, false)]
	[global::GAHNAPGDIBF(17708500325183871236uL, 0u)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static PlayerScopeData JHFAHDJBNPM(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[DLPBPDJNJDG("Physics", 0)]
	[global::GAHNAPGDIBF(16642773407304133105uL, 0u)]
	[CompilerGenerated]
	[MJJNOMFLNIA("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(10f)]
		[NNGIDPKMIAE(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[global::GAHNAPGDIBF(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[MJJNOMFLNIA("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::PNBPGPEMEPB(NCEKBJACAFC.None)]
		[global::AKOGMCGBMOC(1)]
		public NCEKBJACAFC flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68B7020", Offset = "0x68B6420", VA = "0x1868B7020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CEA0", Offset = "0x5E2C2A0", VA = "0x185E2CEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x68B7030", Offset = "0x68B6430", VA = "0x1868B7030")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[MJJNOMFLNIA("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public GGMABPBLDNH shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(5298506180484533559uL, 0u)]
	[MJJNOMFLNIA("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public PGMGELDGJBM order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static SplinePointOrderData JHFAHDJBNPM(PGMGELDGJBM value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[global::GAHNAPGDIBF(16368389834000856208uL, 0u)]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::GAHNAPGDIBF(18095612727592564636uL, 0u)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[MJJNOMFLNIA("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::GAHNAPGDIBF(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[MJJNOMFLNIA("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::PNBPGPEMEPB("new quaternion(0, 0, 0, 1f)")]
		[global::AKOGMCGBMOC(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[MJJNOMFLNIA("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::GAHNAPGDIBF(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::GAHNAPGDIBF(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public CFHMDFBLJPE parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[global::AGEBCKCKHNP(1, false)]
	[global::GAHNAPGDIBF(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[MJJNOMFLNIA("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(IFCJCLMMPFC.CURRENT)]
		public IFCJCLMMPFC version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(12332323170023439017uL, 0u)]
	[MJJNOMFLNIA("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::AGEBCKCKHNP(2, false)]
	[global::KEDOOFCFLAN(new int[] { 1 })]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::AKOGMCGBMOC(2)]
		[global::PNBPGPEMEPB(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::PNBPGPEMEPB(true)]
		[global::AKOGMCGBMOC(3)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[global::CPOOCMHMKDI(LDNKOMNINCP.MIN, LDNKOMNINCP.ALL)]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
public enum LDNKOMNINCP
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::PNBPGPEMEPB(LDNKOMNINCP.UseDefaultVisualEffects)]
		[global::AKOGMCGBMOC(2)]
		public LDNKOMNINCP toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[global::AGEBCKCKHNP(2, false)]
	[MJJNOMFLNIA("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::KEDOOFCFLAN(new int[] { 2, 3 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(4)]
		public IDDELHIKEKM statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[MJJNOMFLNIA("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[global::GELHEIJJNHF(1, false)]
[global::CPOOCMHMKDI(IDDELHIKEKM.None, IDDELHIKEKM.ALL)]
[Flags]
public enum IDDELHIKEKM
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[global::AGEBCKCKHNP(2, false)]
	[MJJNOMFLNIA("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[global::GAHNAPGDIBF(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[MJJNOMFLNIA("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::AGEBCKCKHNP(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[global::AKOGMCGBMOC(1)]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[global::AKOGMCGBMOC(2)]
		[global::PNBPGPEMEPB]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x420D5B0", Offset = "0x420C9B0", VA = "0x18420D5B0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68B6000", Offset = "0x68B5400", VA = "0x1868B6000")]
		public static RigidTransform JHFAHDJBNPM(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68B6000", Offset = "0x68B5400", VA = "0x1868B6000")]
		public static LocalPoseData JHFAHDJBNPM(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FHPBJIGPDBP
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static RigidTransform HJPJJEIEFPL(this LocalPoseData OBEEJPGJPFD)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::GAHNAPGDIBF(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::PNBPGPEMEPB(1f)]
		[global::AKOGMCGBMOC(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	[MJJNOMFLNIA("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::GAHNAPGDIBF(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public IKGDMPNIILI transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::AKOGMCGBMOC(2)]
		[global::PNBPGPEMEPB]
		public DHLGKMANIDB transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[MJJNOMFLNIA("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::AGEBCKCKHNP(1, false)]
	[global::OFPLMAAJABH]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[global::GAHNAPGDIBF(798350452111942523uL, 0u)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public POJFLIOAKPM prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[global::AGEBCKCKHNP(1, false)]
	[CompilerGenerated]
	[MJJNOMFLNIA("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public LLNMKDOAMIE kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[MJJNOMFLNIA("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct HOGAOFBPPBP : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static HOGAOFBPPBP ONJGBPHIMMM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68B65B0", Offset = "0x68B59B0", VA = "0x1868B65B0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer PCHHOKEGOFA, ReferenceGroupReferenceBuffer PDEIPLKJFKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14716F0", Offset = "0x1470AF0", VA = "0x1814716F0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer LALIGKIKEBM)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[InternalBufferCapacity(0)]
	[global::AGEBCKCKHNP(1, false)]
	[MJJNOMFLNIA("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : KDCGCNOFNFK, IBufferElementData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static AuthoredUserTagReferenceBuffer JHFAHDJBNPM(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface KDCGCNOFNFK : IBufferElementData, MJOBODLPDGJ
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[global::AGEBCKCKHNP(2, false)]
	[MJJNOMFLNIA("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[global::AKOGMCGBMOC(2)]
		[global::PNBPGPEMEPB(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[global::GAHNAPGDIBF(1859693175312uL, 0u)]
	[MJJNOMFLNIA("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::AGEBCKCKHNP(1, false)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68B7040", Offset = "0x68B6440", VA = "0x1868B7040")]
		public static UserTagNameData JHFAHDJBNPM(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[MJJNOMFLNIA("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[global::AGEBCKCKHNP(1, false)]
	[InternalBufferCapacity(0)]
	public struct UserTagReferenceBuffer : KDCGCNOFNFK, IBufferElementData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static UserTagReferenceBuffer JHFAHDJBNPM(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[global::AGEBCKCKHNP(1, false)]
	[DLPBPDJNJDG("Visual", 0)]
	[global::GAHNAPGDIBF(1591066774816564574uL, 0u)]
	[CompilerGenerated]
	[MJJNOMFLNIA("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[NNGIDPKMIAE(null, 0)]
		[global::AKOGMCGBMOC(1)]
		[global::PNBPGPEMEPB]
		public BCIFPAJHDBK color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[NNGIDPKMIAE(null, 0)]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(2)]
		public IEFIEIOEMOK material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[global::AKOGMCGBMOC(3)]
		[global::PNBPGPEMEPB]
		[NNGIDPKMIAE(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::PNBPGPEMEPB]
		[NNGIDPKMIAE(null, 0)]
		[global::AKOGMCGBMOC(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[global::GELHEIJJNHF(1, false)]
[global::CPOOCMHMKDI(AHPHGHKBDEP.NONE, AHPHGHKBDEP.COUNT)]
[MJJNOMFLNIA("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum AHPHGHKBDEP
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NNGIDPKMIAE("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NNGIDPKMIAE("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NNGIDPKMIAE("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[MJJNOMFLNIA("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::CPOOCMHMKDI(0, 4)]
[global::GELHEIJJNHF(1, false)]
public enum HFGDGLCIDLL
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Flags]
[MJJNOMFLNIA("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::GELHEIJJNHF(1, false)]
[global::CPOOCMHMKDI(LJEJPCDOHMB.NONE, LJEJPCDOHMB.ALL)]
public enum LJEJPCDOHMB
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[global::GELHEIJJNHF(1, false)]
[global::CPOOCMHMKDI(MPLDKJGCKEE.Off, MPLDKJGCKEE.COUNT)]
[MJJNOMFLNIA("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum MPLDKJGCKEE
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[IHPGGLKALPM]
[global::CPOOCMHMKDI(IFCJCLMMPFC.VERSION_0, IFCJCLMMPFC.CURRENT)]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
public enum IFCJCLMMPFC : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::CPOOCMHMKDI(0, 127)]
[MJJNOMFLNIA("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::GELHEIJJNHF(1, false)]
public enum CGABIILCBOJ
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NNGIDPKMIAE("Dynamic (Environment)", 0)]
	[DGLKPONOMEH("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[NNGIDPKMIAE("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[NNGIDPKMIAE("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[NNGIDPKMIAE("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NNGIDPKMIAE("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[NNGIDPKMIAE("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[NNGIDPKMIAE("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[NNGIDPKMIAE("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[NNGIDPKMIAE("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[IHPGGLKALPM]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[IHPGGLKALPM]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[global::CPOOCMHMKDI(0, DAMGCJMCCIG.ALL)]
[global::GELHEIJJNHF(1, false)]
[Flags]
[MJJNOMFLNIA("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum DAMGCJMCCIG
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[global::CPOOCMHMKDI(0, 2)]
[MJJNOMFLNIA("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::GELHEIJJNHF(1, false)]
public enum GGMABPBLDNH
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[MJJNOMFLNIA("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::CPOOCMHMKDI(JHABCFCICMM.Pivot, JHABCFCICMM.COUNT)]
[global::GELHEIJJNHF(1, false)]
public enum JHABCFCICMM
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[global::GELHEIJJNHF(1, false)]
[global::CPOOCMHMKDI(EGMMDFJLLMC.EnabledForRole, EGMMDFJLLMC.DisabledForRole)]
[MJJNOMFLNIA("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum EGMMDFJLLMC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::CPOOCMHMKDI(JOPBHOLNLCN.NavMeshGenerator, JOPBHOLNLCN.NavMeshBlocker)]
public enum JOPBHOLNLCN
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[MJJNOMFLNIA("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[Flags]
[global::CPOOCMHMKDI(ODOPAAAPLKE.None, ODOPAAAPLKE.All)]
[global::GELHEIJJNHF(1, false)]
public enum ODOPAAAPLKE
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::CPOOCMHMKDI(0, PIJGDKNBGAN.COUNT)]
public enum PIJGDKNBGAN
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OGKJLEEBONH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68B68D0", Offset = "0x68B5CD0", VA = "0x1868B68D0")]
	public static void KGJINEABJGO(this ODOPAAAPLKE EMGMDFDPKIE, PIJGDKNBGAN OCEBKJNMDLF, bool PEGAAPONPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68B6900", Offset = "0x68B5D00", VA = "0x1868B6900")]
	public static bool MIIAIEEACFP(this ODOPAAAPLKE EMGMDFDPKIE, PIJGDKNBGAN OCEBKJNMDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D29AD0", Offset = "0x1D28ED0", VA = "0x181D29AD0")]
	public static ODOPAAAPLKE FIJPGBJFJHM(this PIJGDKNBGAN OCEBKJNMDLF)
	{
		return default(ODOPAAAPLKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::CPOOCMHMKDI(NBGHNPHLDEF.NONE, NBGHNPHLDEF.COUNT)]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
public enum NBGHNPHLDEF
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[global::CPOOCMHMKDI(1000, 8000)]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum POJFLIOAKPM
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[NNGIDPKMIAE("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NNGIDPKMIAE("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NNGIDPKMIAE("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NNGIDPKMIAE("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[IHPGGLKALPM]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[NNGIDPKMIAE("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[NNGIDPKMIAE("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[NNGIDPKMIAE("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[NNGIDPKMIAE("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[NNGIDPKMIAE("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[NNGIDPKMIAE("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[NNGIDPKMIAE("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[NNGIDPKMIAE("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NNGIDPKMIAE("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[NNGIDPKMIAE("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[NNGIDPKMIAE("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[NNGIDPKMIAE("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[NNGIDPKMIAE("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[NNGIDPKMIAE("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[NNGIDPKMIAE("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[NNGIDPKMIAE("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[NNGIDPKMIAE("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[NNGIDPKMIAE("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[NNGIDPKMIAE("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[NNGIDPKMIAE("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[NNGIDPKMIAE("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[NNGIDPKMIAE("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[NNGIDPKMIAE("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[NNGIDPKMIAE("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[NNGIDPKMIAE("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NNGIDPKMIAE("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[NNGIDPKMIAE("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[NNGIDPKMIAE("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[NNGIDPKMIAE("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[NNGIDPKMIAE("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[NNGIDPKMIAE("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[NNGIDPKMIAE("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[NNGIDPKMIAE("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[NNGIDPKMIAE("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[NNGIDPKMIAE("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[NNGIDPKMIAE("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[NNGIDPKMIAE("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[NNGIDPKMIAE("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[NNGIDPKMIAE("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[NNGIDPKMIAE("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[NNGIDPKMIAE("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[NNGIDPKMIAE("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[NNGIDPKMIAE("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[NNGIDPKMIAE("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[IHPGGLKALPM]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[NNGIDPKMIAE("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[NNGIDPKMIAE("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[NNGIDPKMIAE("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[NNGIDPKMIAE("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[NNGIDPKMIAE("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[NNGIDPKMIAE("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[NNGIDPKMIAE("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[NNGIDPKMIAE("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[NNGIDPKMIAE("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[NNGIDPKMIAE("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[NNGIDPKMIAE("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[NNGIDPKMIAE("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[NNGIDPKMIAE("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[NNGIDPKMIAE("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[NNGIDPKMIAE("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[NNGIDPKMIAE("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[NNGIDPKMIAE("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class BFKINBGGODC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68B6030", Offset = "0x68B5430", VA = "0x1868B6030")]
	public static AIKLFOJEDDB HGAGLDBPLGA(this POJFLIOAKPM AKDHFMEOHOE)
	{
		return default(AIKLFOJEDDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::CPOOCMHMKDI(0, 9)]
public enum AIKLFOJEDDB
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class EDOGIFADECL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68B6190", Offset = "0x68B5590", VA = "0x1868B6190")]
	public static bool LFHPEHPCECF(this AIKLFOJEDDB PMDAADBLPNN)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::GAHNAPGDIBF(8060729269509364919uL, 0u)]
	[MJJNOMFLNIA("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::AGEBCKCKHNP(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[global::PNBPGPEMEPB]
		[global::AKOGMCGBMOC(1)]
		public ODHNMDGHJAA shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[global::GELHEIJJNHF(1, false)]
[global::CPOOCMHMKDI(-1, 38)]
[MJJNOMFLNIA("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum ODHNMDGHJAA
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[global::CPOOCMHMKDI(LLNMKDOAMIE.None, LLNMKDOAMIE.COUNT)]
public enum LLNMKDOAMIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
[global::CPOOCMHMKDI(0, 7)]
[MJJNOMFLNIA("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::GELHEIJJNHF(1, false)]
public enum NCEKBJACAFC
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[global::CPOOCMHMKDI(0, 7)]
[Flags]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum FNFJHHFCJGH
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[MJJNOMFLNIA("72742F9B-D48E-4CED-B403-444201FFEE66")]
[Flags]
[global::CPOOCMHMKDI(0, 1)]
[global::GELHEIJJNHF(1, false)]
public enum IKGDMPNIILI
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[MJJNOMFLNIA("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::GELHEIJJNHF(1, false)]
[global::CPOOCMHMKDI(-2, 2)]
public enum DHLGKMANIDB
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::CPOOCMHMKDI(int.MinValue, int.MaxValue)]
public enum BCIFPAJHDBK
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[global::GELHEIJJNHF(1, false)]
[MJJNOMFLNIA("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::CPOOCMHMKDI(-1, 31)]
public enum IEFIEIOEMOK
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[global::BCDJBHAFOKJ(1, false)]
[MJJNOMFLNIA("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct PGMGELDGJBM : IComparable<PGMGELDGJBM>, IEquatable<PGMGELDGJBM>, NJKLNGPHGDI
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static readonly PGMGELDGJBM ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[global::AKOGMCGBMOC(1)]
	public uint MKLLCCHEIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	[global::AKOGMCGBMOC(2)]
	public uint NDNFFFNOOGC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint JECNJAIFIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68B6B30", Offset = "0x68B5F30", VA = "0x1868B6B30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68B6E00", Offset = "0x68B6200", VA = "0x1868B6E00")]
	public PGMGELDGJBM(int MKLLCCHEIOD, int LLLCPCILANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68B6E00", Offset = "0x68B6200", VA = "0x1868B6E00")]
	public PGMGELDGJBM(uint MKLLCCHEIOD, uint LLLCPCILANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68B6C40", Offset = "0x68B6040", VA = "0x1868B6C40")]
	public PGMGELDGJBM LHNLHCCKMLK(int BILMLHHHLMM = 1)
	{
		return default(PGMGELDGJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68B6CB0", Offset = "0x68B60B0", VA = "0x1868B6CB0")]
	public PGMGELDGJBM MBJDCGLDFDM(int BILMLHHHLMM = 1)
	{
		return default(PGMGELDGJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x68B6960", Offset = "0x68B5D60", VA = "0x1868B6960")]
	public static PGMGELDGJBM DGJMKGELJBD(PGMGELDGJBM JNFNBKNOBNN, PGMGELDGJBM CNFAHLDDGGP)
	{
		return default(PGMGELDGJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x68B69E0", Offset = "0x68B5DE0", VA = "0x1868B69E0")]
	private static uint EAJMMKOJPKK(uint DKLJHPKNDLA, uint EALBLGNMNKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68B6920", Offset = "0x68B5D20", VA = "0x1868B6920", Slot = "4")]
	public int CompareTo(PGMGELDGJBM IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68B6A10", Offset = "0x68B5E10", VA = "0x1868B6A10", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68B6D20", Offset = "0x68B6120", VA = "0x1868B6D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68B6AA0", Offset = "0x68B5EA0", VA = "0x1868B6AA0", Slot = "5")]
	public bool Equals(PGMGELDGJBM IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x68B6AC0", Offset = "0x68B5EC0", VA = "0x1868B6AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68B6BD0", Offset = "0x68B5FD0", VA = "0x1868B6BD0", Slot = "6")]
	public void KPIBKDOHBCB(MEDDEPIPLBH CCOPEDCAMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68B6B60", Offset = "0x68B5F60", VA = "0x1868B6B60", Slot = "7")]
	public void JLCLGLEKPEG(OFPHBEOPOAJ CKPGDBBGEAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BC00", Offset = "0x2D0B000", VA = "0x182D0BC00")]
	public static bool JAICCEKEELH(PGMGELDGJBM JNFNBKNOBNN, PGMGELDGJBM CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68B6B10", Offset = "0x68B5F10", VA = "0x1868B6B10")]
	public static bool HBJIFBKOLOD(PGMGELDGJBM JNFNBKNOBNN, PGMGELDGJBM CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68B6B40", Offset = "0x68B5F40", VA = "0x1868B6B40")]
	public static bool JJFPIMEJMEH(PGMGELDGJBM JNFNBKNOBNN, PGMGELDGJBM CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68B6940", Offset = "0x68B5D40", VA = "0x1868B6940")]
	public static bool DBOLFKLFBOE(PGMGELDGJBM JNFNBKNOBNN, PGMGELDGJBM CNFAHLDDGGP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[global::BCDJBHAFOKJ(1, false)]
	[MJJNOMFLNIA("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, NJKLNGPHGDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[global::AKOGMCGBMOC(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0")]
		public static NetworkGuid JHFAHDJBNPM(Guid HLKHAOEDAIN)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68B6750", Offset = "0x68B5B50", VA = "0x1868B6750", Slot = "4")]
		public bool Equals(NetworkGuid IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
		public int CompareTo(NetworkGuid IEDCHGMDIML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68B67F0", Offset = "0x68B5BF0", VA = "0x1868B67F0", Slot = "6")]
		public void KPIBKDOHBCB(MEDDEPIPLBH CCOPEDCAMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68B6780", Offset = "0x68B5B80", VA = "0x1868B6780", Slot = "7")]
		public void JLCLGLEKPEG(OFPHBEOPOAJ CKPGDBBGEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68B68B0", Offset = "0x68B5CB0", VA = "0x1868B68B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[global::BCDJBHAFOKJ(1, false)]
[MJJNOMFLNIA("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct HEBJPGKPDLA : NJKLNGPHGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[global::AKOGMCGBMOC(1)]
	public bool PHHPGKLENNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[global::AKOGMCGBMOC(2)]
	public float3 JCMILGCPADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[global::AKOGMCGBMOC(3)]
	public float3 EHELEMLBEHH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68B6580", Offset = "0x68B5980", VA = "0x1868B6580")]
	public HEBJPGKPDLA(float DNLNJGFKFHE, float JDOCBGNCGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68B6530", Offset = "0x68B5930", VA = "0x1868B6530", Slot = "4")]
	public void KPIBKDOHBCB(MEDDEPIPLBH CCOPEDCAMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68B64C0", Offset = "0x68B58C0", VA = "0x1868B64C0", Slot = "5")]
	public void JLCLGLEKPEG(OFPHBEOPOAJ CKPGDBBGEAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[global::BCDJBHAFOKJ(1, false)]
[MJJNOMFLNIA("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct CFHMDFBLJPE : NJKLNGPHGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[global::AKOGMCGBMOC(1)]
	public float MJBNGKPIBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[global::AKOGMCGBMOC(2)]
	public int HEIDAIFLBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[global::AKOGMCGBMOC(3)]
	public FNFJHHFCJGH EMGMDFDPKIE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HPDNOLIDHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68B6070", Offset = "0x68B5470", VA = "0x1868B6070")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68B6050", Offset = "0x68B5450", VA = "0x1868B6050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OGBGPNEOAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68B6080", Offset = "0x68B5480", VA = "0x1868B6080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68B6170", Offset = "0x68B5570", VA = "0x1868B6170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BCECLLLHHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68B6160", Offset = "0x68B5560", VA = "0x1868B6160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68B6090", Offset = "0x68B5490", VA = "0x1868B6090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68B60B0", Offset = "0x68B54B0", VA = "0x1868B60B0", Slot = "5")]
	public void JLCLGLEKPEG(OFPHBEOPOAJ CKPGDBBGEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68B6100", Offset = "0x68B5500", VA = "0x1868B6100", Slot = "4")]
	public void KPIBKDOHBCB(MEDDEPIPLBH CCOPEDCAMKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class LAKAJNICMKM : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class FGAIPKHIAAO : Property<RRObjectPrefabData, POJFLIOAKPM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x68B6490", Offset = "0x68B5890", VA = "0x1868B6490", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68B63A0", Offset = "0x68B57A0", VA = "0x1868B63A0")]
		public FGAIPKHIAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16832F0", VA = "0x181683EF0", Slot = "14")]
		public override POJFLIOAKPM GetValue(RRObjectPrefabData IFELLLJKHDO)
		{
			return default(POJFLIOAKPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68B6390", Offset = "0x68B5790", VA = "0x1868B6390", Slot = "15")]
		public override void SetValue(RRObjectPrefabData IFELLLJKHDO, POJFLIOAKPM OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68B65D0", Offset = "0x68B59D0", VA = "0x1868B65D0")]
	public LAKAJNICMKM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68B6E50", Offset = "0x68B6250", VA = "0x1868B6E50")]
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
