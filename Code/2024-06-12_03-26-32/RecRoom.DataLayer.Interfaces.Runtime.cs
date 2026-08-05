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
public interface HEMCHFPENCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity LFNIFLKAADA
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
	[CompilerGenerated]
	[global::MOJMDIBOJPA(11505792609904010668uL, 0u)]
	[HFKPGNKBNHA("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[global::LDKCGIAHHBL(1, false)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::INCMOLFBCLB("new float3(float.NaN)")]
		[global::BPFJPAPNAML(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x41E2D60", Offset = "0x41E1960", VA = "0x1841E2D60")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6892730", Offset = "0x6891330", VA = "0x186892730")]
		public static RigidTransform NBHHLKKAPBL(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6892730", Offset = "0x6891330", VA = "0x186892730")]
		public static AuthoredLocalPoseData NBHHLKKAPBL(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[HFKPGNKBNHA("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[global::LDKCGIAHHBL(1, false)]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[global::MOJMDIBOJPA(9088562008033959482uL, 0u)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[global::MOJMDIBOJPA(10137300772124140051uL, 0u)]
	public struct AuthoredParentData : IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static AuthoredParentData NBHHLKKAPBL(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6892750", Offset = "0x6891350", VA = "0x186892750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OCAACLFMJLM : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[HFKPGNKBNHA("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(1, false)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::BPFJPAPNAML(2)]
		[global::INCMOLFBCLB(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::BPFJPAPNAML(3)]
		[global::INCMOLFBCLB(JKBEILLLHJC.EnabledForRole)]
		public JKBEILLLHJC filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[global::MOJMDIBOJPA(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[HFKPGNKBNHA("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[global::LDKCGIAHHBL(1, false)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::BPFJPAPNAML(2)]
		[global::INCMOLFBCLB]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[HFKPGNKBNHA("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[global::LDKCGIAHHBL(1, false)]
	[global::MOJMDIBOJPA(780699438743496039uL, 0u)]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[HFKPGNKBNHA("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[global::LDKCGIAHHBL(1, false)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::MOJMDIBOJPA(11853296779717712500uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[HFKPGNKBNHA("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(1, false)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[HFKPGNKBNHA("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::MOJMDIBOJPA(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EB20", Offset = "0x1F7D720", VA = "0x181F7EB20")]
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

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		internal EntityBundlePartId(uint EPKGPGILADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
		internal uint INAHEMIEKEJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D6EA0", Offset = "0x9D5AA0", VA = "0x1809D6EA0", Slot = "4")]
		public bool Equals(EntityBundlePartId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6893070", Offset = "0x6891C70", VA = "0x186893070", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA94CA0", Offset = "0xA938A0", VA = "0x180A94CA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1A4C930", Offset = "0x1A4B530", VA = "0x181A4C930")]
		public static bool NBAHCGFACIA(EntityBundlePartId NABHBOMGBNH, EntityBundlePartId EIKHFLMLKJH)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[DLACKILBFJG("Container", 0)]
	[global::MOJMDIBOJPA(11104975410044731874uL, 0u)]
	[HFKPGNKBNHA("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::LDKCGIAHHBL(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[IKFGDNMHOKM(null, 0)]
		[global::INCMOLFBCLB(EEBCFHBCHAF.IsDynamicEnvironment)]
		[global::BPFJPAPNAML(1)]
		public EEBCFHBCHAF collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LDLNHAFOAMG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum OOPLGNHGDJB
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
	public enum HDKBIDLBECO
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

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6893100", Offset = "0x6891D00", VA = "0x186893100")]
	public static (OOPLGNHGDJB, HDKBIDLBECO) FNCBICIDHEN(this EEBCFHBCHAF IGOCEJPANBF)
	{
		return default((OOPLGNHGDJB, HDKBIDLBECO));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[global::MOJMDIBOJPA(2914713536404587710uL, 0u)]
	[DLACKILBFJG("Container", 0)]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::BPFJPAPNAML(1)]
		[IKFGDNMHOKM(null, 0)]
		[global::INCMOLFBCLB(LEGGIBKEPLP.Children)]
		public LEGGIBKEPLP collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[DLACKILBFJG("Container", 0)]
	[global::LDKCGIAHHBL(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[HFKPGNKBNHA("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[IKFGDNMHOKM(null, 0)]
		[global::INCMOLFBCLB(KLJFOIFHPPB.DEFAULT)]
		[global::BPFJPAPNAML(1)]
		public KLJFOIFHPPB flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	[DLACKILBFJG("Container", 0)]
	[global::MOJMDIBOJPA(1094837642118998916uL, 0u)]
	[HFKPGNKBNHA("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::INCMOLFBCLB(0f)]
		[IKFGDNMHOKM(null, 0)]
		[global::BPFJPAPNAML(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[HFKPGNKBNHA("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::MOJMDIBOJPA(13657791279235747653uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	[DLACKILBFJG("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::INCMOLFBCLB]
		[IKFGDNMHOKM(null, 0)]
		[global::BPFJPAPNAML(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[HFKPGNKBNHA("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[global::LDKCGIAHHBL(1, false)]
	[global::MOJMDIBOJPA(5176564412348566398uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[DLACKILBFJG("Container", 0)]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		[IKFGDNMHOKM(null, 0)]
		public GGFFHFFDBGK grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[HFKPGNKBNHA("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	[DLACKILBFJG("Container", 0)]
	[global::MOJMDIBOJPA(16485879999901987510uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(MEGLICJNLED.NavMeshGenerator)]
		[IKFGDNMHOKM(null, 0)]
		public MEGLICJNLED mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[HFKPGNKBNHA("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::MOJMDIBOJPA(1537567323754185605uL, 0u)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[HFKPGNKBNHA("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::LDKCGIAHHBL(1, false)]
	[global::MOJMDIBOJPA(5115014870530256079uL, 0u)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::MOJMDIBOJPA(12111354511484844847uL, 0u)]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FLPHDACOOLO : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[global::MOJMDIBOJPA(1950029632769634832uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[HFKPGNKBNHA("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::LDKCGIAHHBL(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public CBNCODLAAAJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static SiblingSortOrderData NBHHLKKAPBL(CBNCODLAAAJ value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6892990", Offset = "0x6891590", VA = "0x186892990", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	[HFKPGNKBNHA("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[global::LDKCGIAHHBL(1, false)]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	public struct InteractionFilterAnyTagsData : IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	[HFKPGNKBNHA("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[global::LDKCGIAHHBL(1, false)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(JKBEILLLHJC.Disabled)]
		public JKBEILLLHJC filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[HFKPGNKBNHA("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[global::LDKCGIAHHBL(1, false)]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[HFKPGNKBNHA("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[global::MOJMDIBOJPA(15012400804589552708uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[CompilerGenerated]
	[HFKPGNKBNHA("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[global::LDKCGIAHHBL(1, false)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[DLACKILBFJG("Object", 0)]
	[global::MOJMDIBOJPA(16541670854338945984uL, 0u)]
	[HFKPGNKBNHA("FB9853D6-6231-43FD-A754-00105DC30880")]
	[global::LDKCGIAHHBL(5, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::BPFJPAPNAML(2)]
		[global::INCMOLFBCLB("new ScaleRestriction(1,1)")]
		public ENHIOBKLMJA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::INCMOLFBCLB("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[IKFGDNMHOKM(null, 0)]
		[global::BPFJPAPNAML(3)]
		public BCCIMNDHFAP userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::INCMOLFBCLB(EFGMDLKHKBH.Default)]
		[global::BPFJPAPNAML(4)]
		[IKFGDNMHOKM(null, 0)]
		public EFGMDLKHKBH circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::INCMOLFBCLB("ObjectPolicyEnumFlags.Default")]
		[global::BPFJPAPNAML(1)]
		public EIPEDFNNELI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::MOJMDIBOJPA(17708500325183871236uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	[HFKPGNKBNHA("617A903E-C2C2-467C-A138-287FDB487645")]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static PlayerScopeData NBHHLKKAPBL(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[global::MOJMDIBOJPA(16642773407304133105uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[DLACKILBFJG("Physics", 0)]
	[CompilerGenerated]
	[HFKPGNKBNHA("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[IKFGDNMHOKM(null, 0)]
		[global::INCMOLFBCLB(10f)]
		[global::BPFJPAPNAML(1)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::MOJMDIBOJPA(10537432342869025182uL, 0u)]
	[HFKPGNKBNHA("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::INCMOLFBCLB(PJNOCAJGACO.None)]
		[global::BPFJPAPNAML(1)]
		public PJNOCAJGACO flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6893720", Offset = "0x6892320", VA = "0x186893720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E4F280", Offset = "0x5E4DE80", VA = "0x185E4F280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6893730", Offset = "0x6892330", VA = "0x186893730")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[HFKPGNKBNHA("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[CompilerGenerated]
	[global::MOJMDIBOJPA(10917729582819845312uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public IFAAMIPBLNN shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	[global::MOJMDIBOJPA(5298506180484533559uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public CBNCODLAAAJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static SplinePointOrderData NBHHLKKAPBL(CBNCODLAAAJ value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[HFKPGNKBNHA("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(1, false)]
	[global::MOJMDIBOJPA(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[global::MOJMDIBOJPA(18095612727592564636uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::MOJMDIBOJPA(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::MOJMDIBOJPA(1238044349990854547uL, 0u)]
	[HFKPGNKBNHA("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::LDKCGIAHHBL(1, false)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[HFKPGNKBNHA("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::MOJMDIBOJPA(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[global::LDKCGIAHHBL(1, false)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public OFPOAEGCOLE parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[HFKPGNKBNHA("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::MOJMDIBOJPA(10026670690793008625uL, 0u)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(AOOPCPDDDIN.CURRENT)]
		public AOOPCPDDDIN version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[HFKPGNKBNHA("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::LBAJHLLINBM(new int[] { 1 })]
	[global::LDKCGIAHHBL(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[global::MOJMDIBOJPA(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::BPFJPAPNAML(2)]
		[global::INCMOLFBCLB(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::BPFJPAPNAML(3)]
		[global::INCMOLFBCLB(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[global::MKNIMFKOIEP(1, false)]
[HFKPGNKBNHA("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[global::BOFIPDAEMPL(CCFEJMHLJNL.MIN, CCFEJMHLJNL.ALL)]
[Flags]
public enum CCFEJMHLJNL
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[global::INCMOLFBCLB(15f)]
		[global::BPFJPAPNAML(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::BPFJPAPNAML(2)]
		[global::INCMOLFBCLB(CCFEJMHLJNL.UseDefaultVisualEffects)]
		public CCFEJMHLJNL toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[HFKPGNKBNHA("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::LDKCGIAHHBL(1, false)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::BPFJPAPNAML(2)]
		[global::INCMOLFBCLB]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::BPFJPAPNAML(3)]
		[global::INCMOLFBCLB]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[CompilerGenerated]
	[HFKPGNKBNHA("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[global::LDKCGIAHHBL(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::INCMOLFBCLB("new float3(1)")]
		[global::BPFJPAPNAML(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	[HFKPGNKBNHA("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::MOJMDIBOJPA(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::LDKCGIAHHBL(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::INCMOLFBCLB("new quaternion(0,0,0,1)")]
		[IKFGDNMHOKM(null, 0)]
		[global::BPFJPAPNAML(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::BPFJPAPNAML(2)]
		[global::INCMOLFBCLB]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x41E2D60", Offset = "0x41E1960", VA = "0x1841E2D60")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6892730", Offset = "0x6891330", VA = "0x186892730")]
		public static RigidTransform NBHHLKKAPBL(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6892730", Offset = "0x6891330", VA = "0x186892730")]
		public static LocalPoseData NBHHLKKAPBL(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class NBALLCLLKIN
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static RigidTransform FNIMOHBEEBI(this LocalPoseData GLMEMJNJKAN)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::MOJMDIBOJPA(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[global::MOJMDIBOJPA(5730545663584378555uL, 0u)]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public HKDNLFAONPL transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(2)]
		public ABGMOEOEDKG transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[HFKPGNKBNHA("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	[global::MOJMDIBOJPA(798350452111942523uL, 0u)]
	[global::GHICAGOGOPF]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public KGAFPCDNLAE prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[global::LDKCGIAHHBL(1, false)]
	[HFKPGNKBNHA("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public LECJGOBHOND kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[HFKPGNKBNHA("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[HFKPGNKBNHA("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[global::LDKCGIAHHBL(1, false)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct DJGMCCBPCAH : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static DJGMCCBPCAH IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6892DE0", Offset = "0x68919E0", VA = "0x186892DE0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer KNFDPFPHEON, ReferenceGroupReferenceBuffer EFBKAEHLBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1375930", Offset = "0x1374530", VA = "0x181375930", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer HAHECKLGOJC)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[HFKPGNKBNHA("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(1, false)]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	public struct AuthoredUserTagReferenceBuffer : NCBDMELNGEK, IBufferElementData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static AuthoredUserTagReferenceBuffer NBHHLKKAPBL(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface NCBDMELNGEK : IBufferElementData, HEMCHFPENCM
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	[global::LDKCGIAHHBL(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[HFKPGNKBNHA("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::INCMOLFBCLB(false)]
		[global::BPFJPAPNAML(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[HFKPGNKBNHA("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::MOJMDIBOJPA(1859693175312uL, 0u)]
	[global::LDKCGIAHHBL(1, false)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[CompilerGenerated]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6893740", Offset = "0x6892340", VA = "0x186893740")]
		public static UserTagNameData NBHHLKKAPBL(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[HFKPGNKBNHA("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[CompilerGenerated]
	[InternalBufferCapacity(0)]
	[global::LDKCGIAHHBL(1, false)]
	public struct UserTagReferenceBuffer : NCBDMELNGEK, IBufferElementData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static UserTagReferenceBuffer NBHHLKKAPBL(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[DLACKILBFJG("Visual", 0)]
	[global::MOJMDIBOJPA(1591066774816564574uL, 0u)]
	[CompilerGenerated]
	[HFKPGNKBNHA("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::LDKCGIAHHBL(1, false)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::BPFJPAPNAML(1)]
		[global::INCMOLFBCLB]
		[IKFGDNMHOKM(null, 0)]
		public EFKMGKJGMIM color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[IKFGDNMHOKM(null, 0)]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(2)]
		public GDIFGOILILA material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[IKFGDNMHOKM(null, 0)]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::INCMOLFBCLB]
		[IKFGDNMHOKM(null, 0)]
		[global::BPFJPAPNAML(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[HFKPGNKBNHA("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::BOFIPDAEMPL(EFGMDLKHKBH.NONE, EFGMDLKHKBH.COUNT)]
[global::MKNIMFKOIEP(1, false)]
public enum EFGMDLKHKBH
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[IKFGDNMHOKM("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[IKFGDNMHOKM("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[IKFGDNMHOKM("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[global::BOFIPDAEMPL(0, 4)]
[HFKPGNKBNHA("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::MKNIMFKOIEP(1, false)]
public enum OMOGKCNNODK
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Flags]
[global::MKNIMFKOIEP(1, false)]
[HFKPGNKBNHA("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::BOFIPDAEMPL(FOEEDMOAHPJ.NONE, FOEEDMOAHPJ.ALL)]
public enum FOEEDMOAHPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[HFKPGNKBNHA("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::MKNIMFKOIEP(1, false)]
[global::BOFIPDAEMPL(LEGGIBKEPLP.Off, LEGGIBKEPLP.COUNT)]
public enum LEGGIBKEPLP
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[BNGACCBPNGP]
[global::BOFIPDAEMPL(AOOPCPDDDIN.VERSION_0, AOOPCPDDDIN.CURRENT)]
[HFKPGNKBNHA("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::MKNIMFKOIEP(1, false)]
public enum AOOPCPDDDIN : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[HFKPGNKBNHA("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::BOFIPDAEMPL(0, 127)]
[global::MKNIMFKOIEP(1, false)]
public enum EEBCFHBCHAF
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[HEJIBNJJGBO("Indicating it can be walked on and moved")]
	[IKFGDNMHOKM("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[IKFGDNMHOKM("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[IKFGDNMHOKM("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[IKFGDNMHOKM("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[IKFGDNMHOKM("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[IKFGDNMHOKM("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[IKFGDNMHOKM("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[IKFGDNMHOKM("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[IKFGDNMHOKM("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[BNGACCBPNGP]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[BNGACCBPNGP]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Flags]
[global::BOFIPDAEMPL(0, KLJFOIFHPPB.ALL)]
[global::MKNIMFKOIEP(1, false)]
[HFKPGNKBNHA("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum KLJFOIFHPPB
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[HFKPGNKBNHA("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::BOFIPDAEMPL(0, 2)]
[global::MKNIMFKOIEP(1, false)]
public enum IFAAMIPBLNN
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[HFKPGNKBNHA("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::BOFIPDAEMPL(GGFFHFFDBGK.Pivot, GGFFHFFDBGK.COUNT)]
[global::MKNIMFKOIEP(1, false)]
public enum GGFFHFFDBGK
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[global::BOFIPDAEMPL(JKBEILLLHJC.EnabledForRole, JKBEILLLHJC.DisabledForRole)]
[HFKPGNKBNHA("c0973732-e735-44cd-9727-a9a79bad01e3")]
[global::MKNIMFKOIEP(1, false)]
public enum JKBEILLLHJC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[global::BOFIPDAEMPL(MEGLICJNLED.NavMeshGenerator, MEGLICJNLED.NavMeshBlocker)]
[HFKPGNKBNHA("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::MKNIMFKOIEP(1, false)]
public enum MEGLICJNLED
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[global::MKNIMFKOIEP(1, false)]
[HFKPGNKBNHA("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::BOFIPDAEMPL(EIPEDFNNELI.None, EIPEDFNNELI.All)]
[Flags]
public enum EIPEDFNNELI
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[HFKPGNKBNHA("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::BOFIPDAEMPL(0, HJDKAEONDEG.COUNT)]
[global::MKNIMFKOIEP(1, false)]
public enum HJDKAEONDEG
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AILKCLKKGGA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68926E0", Offset = "0x68912E0", VA = "0x1868926E0")]
	public static void CBGDEMCKLAL(this EIPEDFNNELI NBEBDBNCFGK, HJDKAEONDEG GCGAFGLFJDM, bool MOAICLIJDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6892710", Offset = "0x6891310", VA = "0x186892710")]
	public static bool DKBHDELPCDB(this EIPEDFNNELI NBEBDBNCFGK, HJDKAEONDEG GCGAFGLFJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1C085D0", Offset = "0x1C071D0", VA = "0x181C085D0")]
	public static EIPEDFNNELI GFHMPGPFCHB(this HJDKAEONDEG GCGAFGLFJDM)
	{
		return default(EIPEDFNNELI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Flags]
[HFKPGNKBNHA("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[global::BOFIPDAEMPL(BCCIMNDHFAP.NONE, BCCIMNDHFAP.COUNT)]
[global::MKNIMFKOIEP(1, false)]
public enum BCCIMNDHFAP
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[HFKPGNKBNHA("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::MKNIMFKOIEP(1, false)]
[global::BOFIPDAEMPL(1000, 8000)]
public enum KGAFPCDNLAE
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[IKFGDNMHOKM("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[IKFGDNMHOKM("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[IKFGDNMHOKM("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[IKFGDNMHOKM("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[BNGACCBPNGP]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[IKFGDNMHOKM("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[IKFGDNMHOKM("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[IKFGDNMHOKM("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[IKFGDNMHOKM("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[IKFGDNMHOKM("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[IKFGDNMHOKM("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[IKFGDNMHOKM("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[IKFGDNMHOKM("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[IKFGDNMHOKM("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[IKFGDNMHOKM("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[IKFGDNMHOKM("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[IKFGDNMHOKM("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[IKFGDNMHOKM("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[IKFGDNMHOKM("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[IKFGDNMHOKM("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[IKFGDNMHOKM("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[IKFGDNMHOKM("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[IKFGDNMHOKM("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[IKFGDNMHOKM("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[IKFGDNMHOKM("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[IKFGDNMHOKM("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[IKFGDNMHOKM("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[IKFGDNMHOKM("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[IKFGDNMHOKM("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[IKFGDNMHOKM("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[IKFGDNMHOKM("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[IKFGDNMHOKM("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[IKFGDNMHOKM("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[IKFGDNMHOKM("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[IKFGDNMHOKM("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[IKFGDNMHOKM("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[IKFGDNMHOKM("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[IKFGDNMHOKM("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[IKFGDNMHOKM("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[IKFGDNMHOKM("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[IKFGDNMHOKM("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[IKFGDNMHOKM("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[IKFGDNMHOKM("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[IKFGDNMHOKM("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[IKFGDNMHOKM("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[IKFGDNMHOKM("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[IKFGDNMHOKM("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[IKFGDNMHOKM("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[IKFGDNMHOKM("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[BNGACCBPNGP]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[IKFGDNMHOKM("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[IKFGDNMHOKM("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[IKFGDNMHOKM("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[IKFGDNMHOKM("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[IKFGDNMHOKM("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[IKFGDNMHOKM("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[IKFGDNMHOKM("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[IKFGDNMHOKM("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[IKFGDNMHOKM("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[IKFGDNMHOKM("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[IKFGDNMHOKM("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[IKFGDNMHOKM("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[IKFGDNMHOKM("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[IKFGDNMHOKM("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[IKFGDNMHOKM("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[IKFGDNMHOKM("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[IKFGDNMHOKM("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class MOABJIDPOLJ
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6893270", Offset = "0x6891E70", VA = "0x186893270")]
	public static BKOKLOEODFF NOGBFLNHOCK(this KGAFPCDNLAE BNEADFDDBLJ)
	{
		return default(BKOKLOEODFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[HFKPGNKBNHA("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::BOFIPDAEMPL(0, 9)]
[global::MKNIMFKOIEP(1, false)]
public enum BKOKLOEODFF
{
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DHONJCIPMHL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6892DD0", Offset = "0x68919D0", VA = "0x186892DD0")]
	public static bool ICIHGMEFHFI(this BKOKLOEODFF KBKALMJCJAE)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[HFKPGNKBNHA("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[global::LDKCGIAHHBL(1, false)]
	[global::MOJMDIBOJPA(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[global::INCMOLFBCLB]
		[global::BPFJPAPNAML(1)]
		public IPMKGJBCEGN shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[HFKPGNKBNHA("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::MKNIMFKOIEP(1, false)]
[global::BOFIPDAEMPL(-1, 38)]
public enum IPMKGJBCEGN
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[global::BOFIPDAEMPL(LECJGOBHOND.None, LECJGOBHOND.COUNT)]
[global::MKNIMFKOIEP(1, false)]
[HFKPGNKBNHA("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
public enum LECJGOBHOND : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[global::MKNIMFKOIEP(1, false)]
[HFKPGNKBNHA("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::BOFIPDAEMPL(0, 7)]
[Flags]
public enum PJNOCAJGACO
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[HFKPGNKBNHA("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::BOFIPDAEMPL(0, 7)]
[global::MKNIMFKOIEP(1, false)]
[Flags]
public enum IJEDNFDNODG
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[HFKPGNKBNHA("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::MKNIMFKOIEP(1, false)]
[Flags]
[global::BOFIPDAEMPL(0, 1)]
public enum HKDNLFAONPL
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[HFKPGNKBNHA("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::BOFIPDAEMPL(-2, 2)]
[global::MKNIMFKOIEP(1, false)]
public enum ABGMOEOEDKG
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[global::MKNIMFKOIEP(1, false)]
[HFKPGNKBNHA("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::BOFIPDAEMPL(int.MinValue, int.MaxValue)]
public enum EFKMGKJGMIM
{
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[HFKPGNKBNHA("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::MKNIMFKOIEP(1, false)]
[global::BOFIPDAEMPL(-1, 31)]
public enum GDIFGOILILA
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[global::EGLEONJBPEH(1, false)]
[HFKPGNKBNHA("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct CBNCODLAAAJ : IComparable<CBNCODLAAAJ>, IEquatable<CBNCODLAAAJ>, JPPLBHHNBKC
{
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static readonly CBNCODLAAAJ BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	[global::BPFJPAPNAML(1)]
	public uint PAOEGEHGHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[global::BPFJPAPNAML(2)]
	public uint FBKHJCCOBBN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint IMCGOIPDJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6892B10", Offset = "0x6891710", VA = "0x186892B10")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6892D80", Offset = "0x6891980", VA = "0x186892D80")]
	public CBNCODLAAAJ(int PAOEGEHGHEN, int LJKNCMLPCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6892D80", Offset = "0x6891980", VA = "0x186892D80")]
	public CBNCODLAAAJ(uint PAOEGEHGHEN, uint LJKNCMLPCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6892890", Offset = "0x6891490", VA = "0x186892890")]
	public CBNCODLAAAJ CHODNEHBILB(int MANKJHLJMBO = 1)
	{
		return default(CBNCODLAAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6892AA0", Offset = "0x68916A0", VA = "0x186892AA0")]
	public CBNCODLAAAJ IOBMNFAOOKO(int MANKJHLJMBO = 1)
	{
		return default(CBNCODLAAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6892B20", Offset = "0x6891720", VA = "0x186892B20")]
	public static CBNCODLAAAJ JAJHEHHJOHM(CBNCODLAAAJ HOGIDEMINCM, CBNCODLAAAJ FKJHDCOBNND)
	{
		return default(CBNCODLAAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6892BC0", Offset = "0x68917C0", VA = "0x186892BC0")]
	private static uint OLOMJAAFADB(uint NABHBOMGBNH, uint EIKHFLMLKJH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6892900", Offset = "0x6891500", VA = "0x186892900", Slot = "4")]
	public int CompareTo(CBNCODLAAAJ OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68929B0", Offset = "0x68915B0", VA = "0x1868929B0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6892CA0", Offset = "0x68918A0", VA = "0x186892CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6892990", Offset = "0x6891590", VA = "0x186892990", Slot = "5")]
	public bool Equals(CBNCODLAAAJ OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6892A50", Offset = "0x6891650", VA = "0x186892A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6892C10", Offset = "0x6891810", VA = "0x186892C10", Slot = "6")]
	public void PLFEAILJDFE(HKGFKELOBIK AKHHKFNOJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6892920", Offset = "0x6891520", VA = "0x186892920", Slot = "7")]
	public void EGCBEAACMHC(HJOMNJNLOEI GGPHPLOPODB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C17620", Offset = "0x2C16220", VA = "0x182C17620")]
	public static bool NBAHCGFACIA(CBNCODLAAAJ HOGIDEMINCM, CBNCODLAAAJ FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6892BF0", Offset = "0x68917F0", VA = "0x186892BF0")]
	public static bool OONFJEHFBJE(CBNCODLAAAJ HOGIDEMINCM, CBNCODLAAAJ FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6892BA0", Offset = "0x68917A0", VA = "0x186892BA0")]
	public static bool NJPCCEDOPLP(CBNCODLAAAJ HOGIDEMINCM, CBNCODLAAAJ FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6892C80", Offset = "0x6891880", VA = "0x186892C80")]
	public static bool PNGLBFPCAHN(CBNCODLAAAJ HOGIDEMINCM, CBNCODLAAAJ FKJHDCOBNND)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[global::EGLEONJBPEH(1, false)]
	[HFKPGNKBNHA("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, JPPLBHHNBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[global::BPFJPAPNAML(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public static NetworkGuid NBHHLKKAPBL(Guid CICFLOBNFHG)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6893300", Offset = "0x6891F00", VA = "0x186893300", Slot = "4")]
		public bool Equals(NetworkGuid OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
		public int CompareTo(NetworkGuid OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6893330", Offset = "0x6891F30", VA = "0x186893330", Slot = "6")]
		public void PLFEAILJDFE(HKGFKELOBIK AKHHKFNOJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6893290", Offset = "0x6891E90", VA = "0x186893290", Slot = "7")]
		public void EGCBEAACMHC(HJOMNJNLOEI GGPHPLOPODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68933F0", Offset = "0x6891FF0", VA = "0x1868933F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[global::EGLEONJBPEH(1, false)]
[HFKPGNKBNHA("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct ENHIOBKLMJA : JPPLBHHNBKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	[global::BPFJPAPNAML(1)]
	public bool MPKDEMAOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	[global::BPFJPAPNAML(2)]
	public float3 GHKCDIGPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	[global::BPFJPAPNAML(3)]
	public float3 OGNEOGNDNBI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6893040", Offset = "0x6891C40", VA = "0x186893040")]
	public ENHIOBKLMJA(float KFFFFOIIONO, float EJBCANAPLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6892FF0", Offset = "0x6891BF0", VA = "0x186892FF0", Slot = "4")]
	public void PLFEAILJDFE(HKGFKELOBIK AKHHKFNOJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6892F80", Offset = "0x6891B80", VA = "0x186892F80", Slot = "5")]
	public void EGCBEAACMHC(HJOMNJNLOEI GGPHPLOPODB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[HFKPGNKBNHA("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::EGLEONJBPEH(1, false)]
public struct OFPOAEGCOLE : JPPLBHHNBKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[global::BPFJPAPNAML(1)]
	public float GMNCBOEGGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[global::BPFJPAPNAML(2)]
	public int HBGJNCLMLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[global::BPFJPAPNAML(3)]
	public IJEDNFDNODG NBEBDBNCFGK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool JJFEGPGEANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6893540", Offset = "0x6892140", VA = "0x186893540")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68934A0", Offset = "0x68920A0", VA = "0x1868934A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OEICAONGDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6893420", Offset = "0x6892020", VA = "0x186893420")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68934C0", Offset = "0x68920C0", VA = "0x1868934C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool CEHBJOBJNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6893410", Offset = "0x6892010", VA = "0x186893410")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6893480", Offset = "0x6892080", VA = "0x186893480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6893430", Offset = "0x6892030", VA = "0x186893430", Slot = "5")]
	public void EGCBEAACMHC(HJOMNJNLOEI GGPHPLOPODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68934E0", Offset = "0x68920E0", VA = "0x1868934E0", Slot = "4")]
	public void PLFEAILJDFE(HKGFKELOBIK AKHHKFNOJLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class DPBLAOPPMHN : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class BLDPKLCMIMO : Property<RRObjectPrefabData, KGAFPCDNLAE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6892860", Offset = "0x6891460", VA = "0x186892860", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6892770", Offset = "0x6891370", VA = "0x186892770")]
		public BLDPKLCMIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1584AE0", Offset = "0x15836E0", VA = "0x181584AE0", Slot = "14")]
		public override KGAFPCDNLAE GetValue(RRObjectPrefabData INBELNINGBJ)
		{
			return default(KGAFPCDNLAE);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6892760", Offset = "0x6891360", VA = "0x186892760", Slot = "15")]
		public override void SetValue(RRObjectPrefabData INBELNINGBJ, KGAFPCDNLAE GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6892E00", Offset = "0x6891A00", VA = "0x186892E00")]
	public DPBLAOPPMHN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6893550", Offset = "0x6892150", VA = "0x186893550")]
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
