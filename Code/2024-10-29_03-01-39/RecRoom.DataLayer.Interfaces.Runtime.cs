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
public interface GAJADDOMLLO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity NDNKGJEJKMB
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
	[global::MPNOHJBOGIH(1, false)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(11505792609904010668uL, 0u)]
	[KNPPIMNHCAF("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x470D1F0", Offset = "0x470C1F0", VA = "0x18470D1F0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E628C0", Offset = "0x6E618C0", VA = "0x186E628C0")]
		public static RigidTransform ILBKFABDDDI(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E628C0", Offset = "0x6E618C0", VA = "0x186E628C0")]
		public static AuthoredLocalPoseData ILBKFABDDDI(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::OAPCIDEPBMD(9088562008033959482uL, 0u)]
	[global::MPNOHJBOGIH(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[KNPPIMNHCAF("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[global::OAPCIDEPBMD(10137300772124140051uL, 0u)]
	public struct AuthoredParentData : IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static AuthoredParentData ILBKFABDDDI(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E628E0", Offset = "0x6E618E0", VA = "0x186E628E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EPMLCGPKPPK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::BFHHOAIOEJG(3)]
		[global::FGLBEABHDBE(JENDJHGIADH.EnabledForRole)]
		public JENDJHGIADH filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(8594223769175916906uL, 0u)]
	[KNPPIMNHCAF("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[CompilerGenerated]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[global::OAPCIDEPBMD(780699438743496039uL, 0u)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[KNPPIMNHCAF("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[global::MPNOHJBOGIH(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::MPNOHJBOGIH(2, false)]
	[KNPPIMNHCAF("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KJPKDOPFJHI : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::FGLBEABHDBE(10)]
		[global::BFHHOAIOEJG(1)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[KNPPIMNHCAF("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[global::MPNOHJBOGIH(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::FGLBEABHDBE(0)]
		[global::BFHHOAIOEJG(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[KNPPIMNHCAF("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(8536678595025273356uL, 0u)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x22F9A20", Offset = "0x22F8A20", VA = "0x1822F9A20")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x22E7910", Offset = "0x22E6910", VA = "0x1822E7910")]
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
		[Cpp2IlInjected.Address(RVA = "0xD342A0", Offset = "0xD332A0", VA = "0x180D342A0")]
		internal EntityBundlePartId(uint JHCIODFGPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0")]
		internal uint EFLILEIMFJG()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xDEA120", Offset = "0xDE9120", VA = "0x180DEA120", Slot = "4")]
		public bool Equals(EntityBundlePartId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E62AA0", Offset = "0x6E61AA0", VA = "0x186E62AA0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xE92570", Offset = "0xE91570", VA = "0x180E92570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x210D430", Offset = "0x210C430", VA = "0x18210D430")]
		public static bool LJMKDDBNEAO(EntityBundlePartId LGLGFADDDNK, EntityBundlePartId GMGEKOBCPAI)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[global::OAPCIDEPBMD(11104975410044731874uL, 0u)]
	[KNPPIMNHCAF("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[JDFFDGJHJJG("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[global::MPNOHJBOGIH(1, false)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[global::FGLBEABHDBE(EBCFLFMODPE.IsDynamicEnvironment)]
		[global::BFHHOAIOEJG(1)]
		[COCDHDPFAAP(null, 0)]
		public EBCFLFMODPE collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KBLPHNLECBP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IBAKAIPPCCF
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
	public enum HPEBOFCLFIO
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
	[Cpp2IlInjected.Address(RVA = "0x6E62DA0", Offset = "0x6E61DA0", VA = "0x186E62DA0")]
	public static (IBAKAIPPCCF, HPEBOFCLFIO) DDNFJLCNCBO(this EBCFLFMODPE BKMADAFHHHB)
	{
		return default((IBAKAIPPCCF, HPEBOFCLFIO));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[JDFFDGJHJJG("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[global::OAPCIDEPBMD(2914713536404587710uL, 0u)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[global::FGLBEABHDBE(OPANCCNJKFE.Children)]
		[COCDHDPFAAP(null, 0)]
		[global::BFHHOAIOEJG(1)]
		public OPANCCNJKFE collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[global::MPNOHJBOGIH(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	[KNPPIMNHCAF("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[JDFFDGJHJJG("Container", 0)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[global::FGLBEABHDBE(KGMCLDKIBHB.DEFAULT)]
		[COCDHDPFAAP(null, 0)]
		[global::BFHHOAIOEJG(1)]
		public KGMCLDKIBHB flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[JDFFDGJHJJG("Container", 0)]
	[global::OAPCIDEPBMD(1094837642118998916uL, 0u)]
	[KNPPIMNHCAF("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::FGLBEABHDBE(0f)]
		[global::BFHHOAIOEJG(1)]
		[COCDHDPFAAP(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[global::OAPCIDEPBMD(13657791279235747653uL, 0u)]
	[JDFFDGJHJJG("Container", 0)]
	[KNPPIMNHCAF("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::MPNOHJBOGIH(1, false)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		[COCDHDPFAAP(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[JDFFDGJHJJG("Container", 0)]
	[CompilerGenerated]
	[KNPPIMNHCAF("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[COCDHDPFAAP(null, 0)]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public IIAHEDMOJPJ grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[global::OAPCIDEPBMD(16485879999901987510uL, 0u)]
	[CompilerGenerated]
	[JDFFDGJHJJG("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[COCDHDPFAAP(null, 0)]
		[global::FGLBEABHDBE(EELHPFLEKBM.NavMeshGenerator)]
		[global::BFHHOAIOEJG(1)]
		public EELHPFLEKBM mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[global::OAPCIDEPBMD(1537567323754185605uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(5115014870530256079uL, 0u)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[KNPPIMNHCAF("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[global::MPNOHJBOGIH(1, false)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static InventionIdData ILBKFABDDDI(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E62CA0", Offset = "0x6E61CA0", VA = "0x186E62CA0")]
		public readonly bool NLHLLJDNECB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C83430", Offset = "0x6C82430", VA = "0x186C83430")]
		public static bool NLHLLJDNECB(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[KNPPIMNHCAF("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[global::PNBCPOMLMKP(new int[] { 1 })]
	[CompilerGenerated]
	[global::MPNOHJBOGIH(2, false)]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public static InventionInstanceIdData ILBKFABDDDI(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[KNPPIMNHCAF("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::OAPCIDEPBMD(12111354511484844847uL, 0u)]
	[global::MPNOHJBOGIH(1, false)]
	public struct ParentData : IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct IJKNCAGCBLB : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[KNPPIMNHCAF("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public NOPOCCDDOOL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static SiblingSortOrderData ILBKFABDDDI(NOPOCCDDOOL value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E63180", Offset = "0x6E62180", VA = "0x186E63180", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[KNPPIMNHCAF("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[global::MPNOHJBOGIH(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	[KNPPIMNHCAF("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(JENDJHGIADH.Disabled)]
		public JENDJHGIADH filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[KNPPIMNHCAF("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(15012400804589552708uL, 0u)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::MPNOHJBOGIH(5, false)]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::OAPCIDEPBMD(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[KNPPIMNHCAF("FB9853D6-6231-43FD-A754-00105DC30880")]
	[JDFFDGJHJJG("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE("new ScaleRestriction(1,1)")]
		public KBHADCGBEAI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::FGLBEABHDBE("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[COCDHDPFAAP(null, 0)]
		[global::BFHHOAIOEJG(3)]
		public OPNAOIHLHJL userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::BFHHOAIOEJG(4)]
		[COCDHDPFAAP(null, 0)]
		[global::FGLBEABHDBE(OEPHAFFDIHD.Default)]
		public OEPHAFFDIHD circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::FGLBEABHDBE("ObjectPolicyEnumFlags.Default")]
		[global::BFHHOAIOEJG(1)]
		public MNNPBPDMLNM flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[global::OAPCIDEPBMD(17708500325183871236uL, 0u)]
	[KNPPIMNHCAF("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static PlayerScopeData ILBKFABDDDI(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[JDFFDGJHJJG("Physics", 0)]
	[CompilerGenerated]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[global::OAPCIDEPBMD(16642773407304133105uL, 0u)]
	[KNPPIMNHCAF("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[COCDHDPFAAP(null, 0)]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[KNPPIMNHCAF("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(10537432342869025182uL, 0u)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(COOHEFBPBIK.None)]
		public COOHEFBPBIK flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63BFF10", Offset = "0x63BEF10", VA = "0x1863BFF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63BFF20", Offset = "0x63BEF20", VA = "0x1863BFF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E638F0", Offset = "0x6E628F0", VA = "0x186E638F0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public GKAGLCPBFJA shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[KNPPIMNHCAF("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public NOPOCCDDOOL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static SplinePointOrderData ILBKFABDDDI(NOPOCCDDOOL value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::OAPCIDEPBMD(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::OAPCIDEPBMD(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::FGLBEABHDBE("new quaternion(0, 0, 0, 1f)")]
		[global::BFHHOAIOEJG(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(1238044349990854547uL, 0u)]
	[KNPPIMNHCAF("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(4657247877648983868uL, 0u)]
	[KNPPIMNHCAF("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public MBMAGBGFPBG parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[global::OAPCIDEPBMD(10026670690793008625uL, 0u)]
	[CompilerGenerated]
	[KNPPIMNHCAF("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::FGLBEABHDBE(FDLPBINLLFP.CURRENT)]
		[global::BFHHOAIOEJG(1)]
		public FDLPBINLLFP version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[global::PNBCPOMLMKP(new int[] { 1 })]
	[KNPPIMNHCAF("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::MPNOHJBOGIH(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::FGLBEABHDBE(true)]
		[global::BFHHOAIOEJG(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::FGLBEABHDBE(true)]
		[global::BFHHOAIOEJG(3)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[global::BKENGLJFLAI(1, false)]
[Flags]
[KNPPIMNHCAF("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[global::FHFDEONFODE(PONGNIMPGFN.MIN, PONGNIMPGFN.ALL)]
public enum PONGNIMPGFN
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[KNPPIMNHCAF("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[global::MPNOHJBOGIH(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::FGLBEABHDBE(15f)]
		[global::BFHHOAIOEJG(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::FGLBEABHDBE(PONGNIMPGFN.UseDefaultVisualEffects)]
		[global::BFHHOAIOEJG(2)]
		public PONGNIMPGFN toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[global::PNBCPOMLMKP(new int[] { 2, 3 })]
	[KNPPIMNHCAF("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::MPNOHJBOGIH(2, false)]
	[CompilerGenerated]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::BFHHOAIOEJG(4)]
		[global::FGLBEABHDBE]
		public MJGKCBFGIHJ statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::FHFDEONFODE(MJGKCBFGIHJ.None, MJGKCBFGIHJ.ALL)]
[Flags]
[KNPPIMNHCAF("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[global::BKENGLJFLAI(1, false)]
public enum MJGKCBFGIHJ
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
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::MPNOHJBOGIH(2, false)]
	[KNPPIMNHCAF("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::FGLBEABHDBE("new float3(1)")]
		[global::BFHHOAIOEJG(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[KNPPIMNHCAF("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::OAPCIDEPBMD(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::MPNOHJBOGIH(1, false)]
	[CompilerGenerated]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE("new quaternion(0,0,0,1)")]
		[COCDHDPFAAP(null, 0)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x470D1F0", Offset = "0x470C1F0", VA = "0x18470D1F0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E628C0", Offset = "0x6E618C0", VA = "0x186E628C0")]
		public static RigidTransform ILBKFABDDDI(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E628C0", Offset = "0x6E618C0", VA = "0x186E628C0")]
		public static LocalPoseData ILBKFABDDDI(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KCKLEHDIHBC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static RigidTransform EOGGJMAMEKK(this LocalPoseData BJDKOHEGDOK)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[KNPPIMNHCAF("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[KNPPIMNHCAF("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public PCNNDDNGIEA transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE]
		public DGDLOJOHHEO transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[KNPPIMNHCAF("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[global::OAPCIDEPBMD(798350452111942523uL, 0u)]
	[global::GNEAEJKMKKF]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public KOCACJKGAPP prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[global::MPNOHJBOGIH(1, false)]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	[KNPPIMNHCAF("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public KBKKNPPGCKK kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct BDMMHIIOMJM : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static BDMMHIIOMJM LONMIMAJOAB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E628F0", Offset = "0x6E618F0", VA = "0x186E628F0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer GOCMFEAMGHO, ReferenceGroupReferenceBuffer AEFHGLLPABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xA08E00", Offset = "0xA07E00", VA = "0x180A08E00", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer IFPBFCLBBDP)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[InternalBufferCapacity(0)]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : OHDPCGBJMKL, IBufferElementData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static AuthoredUserTagReferenceBuffer ILBKFABDDDI(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OHDPCGBJMKL : IBufferElementData, GAJADDOMLLO
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[KNPPIMNHCAF("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[global::MPNOHJBOGIH(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[global::BFHHOAIOEJG(2)]
		[global::FGLBEABHDBE(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(1859693175312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[KNPPIMNHCAF("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::MPNOHJBOGIH(1, false)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6E63900", Offset = "0x6E62900", VA = "0x186E63900")]
		public static UserTagNameData ILBKFABDDDI(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[global::MPNOHJBOGIH(1, false)]
	[KNPPIMNHCAF("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[InternalBufferCapacity(0)]
	public struct UserTagReferenceBuffer : OHDPCGBJMKL, IBufferElementData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[global::BFHHOAIOEJG(1)]
		[global::FGLBEABHDBE]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static UserTagReferenceBuffer ILBKFABDDDI(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CompilerGenerated]
	[JDFFDGJHJJG("Visual", 0)]
	[KNPPIMNHCAF("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[global::MPNOHJBOGIH(1, false)]
	[global::OAPCIDEPBMD(1591066774816564574uL, 0u)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[COCDHDPFAAP(null, 0)]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public DONFCAMKLFM color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[global::FGLBEABHDBE]
		[COCDHDPFAAP(null, 0)]
		[global::BFHHOAIOEJG(2)]
		public LNBEMEGKNKH material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[COCDHDPFAAP(null, 0)]
		[global::BFHHOAIOEJG(3)]
		[global::FGLBEABHDBE]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(4)]
		[COCDHDPFAAP(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[global::FHFDEONFODE(OEPHAFFDIHD.NONE, OEPHAFFDIHD.COUNT)]
[KNPPIMNHCAF("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::BKENGLJFLAI(1, false)]
public enum OEPHAFFDIHD
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[COCDHDPFAAP("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[COCDHDPFAAP("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[COCDHDPFAAP("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[global::FHFDEONFODE(0, 4)]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum ELHAKPCLJBH
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
[KNPPIMNHCAF("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::BKENGLJFLAI(1, false)]
[Flags]
[global::FHFDEONFODE(IKNPHDPPMIH.NONE, IKNPHDPPMIH.ALL)]
public enum IKNPHDPPMIH
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
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::FHFDEONFODE(OPANCCNJKFE.Off, OPANCCNJKFE.COUNT)]
public enum OPANCCNJKFE
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
[KNPPIMNHCAF("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[LHKAHOCMHME]
[global::BKENGLJFLAI(1, false)]
[global::FHFDEONFODE(FDLPBINLLFP.VERSION_0, FDLPBINLLFP.CURRENT)]
public enum FDLPBINLLFP : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[KNPPIMNHCAF("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::BKENGLJFLAI(1, false)]
[global::FHFDEONFODE(0, 127)]
public enum EBCFLFMODPE
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[COCDHDPFAAP("Dynamic (Environment)", 0)]
	[JHMGMLLLPJJ("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[COCDHDPFAAP("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[COCDHDPFAAP("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[COCDHDPFAAP("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[COCDHDPFAAP("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[COCDHDPFAAP("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[COCDHDPFAAP("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[COCDHDPFAAP("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[COCDHDPFAAP("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[LHKAHOCMHME]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[LHKAHOCMHME]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[KNPPIMNHCAF("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
[global::FHFDEONFODE(0, KGMCLDKIBHB.ALL)]
[global::BKENGLJFLAI(1, false)]
public enum KGMCLDKIBHB
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	MAX = 0x3E47
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[global::FHFDEONFODE(0, 2)]
[KNPPIMNHCAF("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::BKENGLJFLAI(1, false)]
public enum GKAGLCPBFJA
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[global::FHFDEONFODE(IIAHEDMOJPJ.Pivot, IIAHEDMOJPJ.COUNT)]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum IIAHEDMOJPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("c0973732-e735-44cd-9727-a9a79bad01e3")]
[global::FHFDEONFODE(JENDJHGIADH.EnabledForRole, JENDJHGIADH.DisabledForRole)]
public enum JENDJHGIADH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[global::FHFDEONFODE(EELHPFLEKBM.NavMeshGenerator, EELHPFLEKBM.NavMeshBlocker)]
[KNPPIMNHCAF("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::BKENGLJFLAI(1, false)]
public enum EELHPFLEKBM
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[KNPPIMNHCAF("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::FHFDEONFODE(MNNPBPDMLNM.None, MNNPBPDMLNM.All)]
[global::BKENGLJFLAI(1, false)]
[Flags]
public enum MNNPBPDMLNM
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::FHFDEONFODE(0, LMMICAJFFJO.COUNT)]
public enum LMMICAJFFJO
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class ICJPHBCHAIN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E62C50", Offset = "0x6E61C50", VA = "0x186E62C50")]
	public static void NONCGFKLPGD(this MNNPBPDMLNM IECLEDMOCFH, LMMICAJFFJO NCIEMMAJCKL, bool EJMENMMDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E62C80", Offset = "0x6E61C80", VA = "0x186E62C80")]
	public static bool OFDHBJLNIAE(this MNNPBPDMLNM IECLEDMOCFH, LMMICAJFFJO NCIEMMAJCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA1C270", Offset = "0xA1B270", VA = "0x180A1C270")]
	public static MNNPBPDMLNM MHCLCEBIFDH(this LMMICAJFFJO NCIEMMAJCKL)
	{
		return default(MNNPBPDMLNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[KNPPIMNHCAF("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[global::BKENGLJFLAI(1, false)]
[Flags]
[global::FHFDEONFODE(OPNAOIHLHJL.NONE, OPNAOIHLHJL.COUNT)]
public enum OPNAOIHLHJL
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DEFAULT = 2
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[global::FHFDEONFODE(1000, 8000)]
[KNPPIMNHCAF("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::BKENGLJFLAI(1, false)]
public enum KOCACJKGAPP
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[COCDHDPFAAP("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[COCDHDPFAAP("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[COCDHDPFAAP("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[COCDHDPFAAP("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[LHKAHOCMHME]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[COCDHDPFAAP("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[COCDHDPFAAP("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[COCDHDPFAAP("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[COCDHDPFAAP("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[COCDHDPFAAP("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[COCDHDPFAAP("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[COCDHDPFAAP("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[COCDHDPFAAP("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[COCDHDPFAAP("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[COCDHDPFAAP("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[COCDHDPFAAP("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[COCDHDPFAAP("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[COCDHDPFAAP("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[COCDHDPFAAP("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[COCDHDPFAAP("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[COCDHDPFAAP("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[COCDHDPFAAP("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[COCDHDPFAAP("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[COCDHDPFAAP("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[COCDHDPFAAP("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[COCDHDPFAAP("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[COCDHDPFAAP("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[COCDHDPFAAP("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[COCDHDPFAAP("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[COCDHDPFAAP("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[COCDHDPFAAP("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[COCDHDPFAAP("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[COCDHDPFAAP("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[COCDHDPFAAP("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[COCDHDPFAAP("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[COCDHDPFAAP("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[COCDHDPFAAP("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[COCDHDPFAAP("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[COCDHDPFAAP("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[COCDHDPFAAP("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[COCDHDPFAAP("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[COCDHDPFAAP("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[COCDHDPFAAP("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[COCDHDPFAAP("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[COCDHDPFAAP("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[COCDHDPFAAP("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[COCDHDPFAAP("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[COCDHDPFAAP("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[COCDHDPFAAP("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[LHKAHOCMHME]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[COCDHDPFAAP("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[COCDHDPFAAP("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[COCDHDPFAAP("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[COCDHDPFAAP("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[COCDHDPFAAP("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[COCDHDPFAAP("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[COCDHDPFAAP("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[COCDHDPFAAP("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[COCDHDPFAAP("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[COCDHDPFAAP("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[COCDHDPFAAP("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[COCDHDPFAAP("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[COCDHDPFAAP("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[COCDHDPFAAP("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[COCDHDPFAAP("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[COCDHDPFAAP("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[COCDHDPFAAP("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class ANKPCLELHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E628A0", Offset = "0x6E618A0", VA = "0x186E628A0")]
	public static OELFFIFDGKJ EAPOEOCENIG(this KOCACJKGAPP LBKOKAEKFKC)
	{
		return default(OELFFIFDGKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::FHFDEONFODE(0, 9)]
public enum OELFFIFDGKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	UNUSED = 4,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	UNUSED2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class DMMHDHOFDMH
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E62910", Offset = "0x6E61910", VA = "0x186E62910")]
	public static bool PFEKFPAIODO(this OELFFIFDGKJ JLJIJLCLHCP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	[global::OAPCIDEPBMD(8060729269509364919uL, 0u)]
	[KNPPIMNHCAF("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[global::MPNOHJBOGIH(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[global::FGLBEABHDBE]
		[global::BFHHOAIOEJG(1)]
		public HIIHHGMHMLB shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[KNPPIMNHCAF("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::FHFDEONFODE(-1, 38)]
[global::BKENGLJFLAI(1, false)]
public enum HIIHHGMHMLB
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[global::FHFDEONFODE(KBKKNPPGCKK.None, KBKKNPPGCKK.COUNT)]
public enum KBKKNPPGCKK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[global::FHFDEONFODE(0, 7)]
[Flags]
[KNPPIMNHCAF("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::BKENGLJFLAI(1, false)]
public enum COOHEFBPBIK
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[global::BKENGLJFLAI(1, false)]
[global::FHFDEONFODE(0, 7)]
[Flags]
[KNPPIMNHCAF("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum GBIMHBHEMDC
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::FHFDEONFODE(0, 1)]
[Flags]
public enum PCNNDDNGIEA
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[global::FHFDEONFODE(-2, 2)]
[global::BKENGLJFLAI(1, false)]
[KNPPIMNHCAF("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum DGDLOJOHHEO
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[global::BKENGLJFLAI(1, false)]
[global::FHFDEONFODE(int.MinValue, int.MaxValue)]
[KNPPIMNHCAF("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum DONFCAMKLFM
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[global::BKENGLJFLAI(1, false)]
[global::FHFDEONFODE(-1, 31)]
[KNPPIMNHCAF("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum LNBEMEGKNKH
{
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[KNPPIMNHCAF("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[global::GKBMJGNDIGJ(1, false)]
public struct NOPOCCDDOOL : IComparable<NOPOCCDDOOL>, IEquatable<NOPOCCDDOOL>, OFHBIFCOJAD
{
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static readonly NOPOCCDDOOL BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[global::BFHHOAIOEJG(1)]
	public uint HDNOBOGAIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[global::BFHHOAIOEJG(2)]
	public uint PFPJHFFBGJP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint GLEJGNGGBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E63070", Offset = "0x6E62070", VA = "0x186E63070")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E63550", Offset = "0x6E62550", VA = "0x186E63550")]
	public NOPOCCDDOOL(int HDNOBOGAIPK, int OPJPKNFJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E63550", Offset = "0x6E62550", VA = "0x186E63550")]
	public NOPOCCDDOOL(uint HDNOBOGAIPK, uint OPJPKNFJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E63370", Offset = "0x6E62370", VA = "0x186E63370")]
	public NOPOCCDDOOL MKKILFAKIBP(int OFDADLBABBI = 1)
	{
		return default(NOPOCCDDOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E63080", Offset = "0x6E62080", VA = "0x186E63080")]
	public NOPOCCDDOOL CMCLPPPJFEM(int OFDADLBABBI = 1)
	{
		return default(NOPOCCDDOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E63280", Offset = "0x6E62280", VA = "0x186E63280")]
	public static NOPOCCDDOOL HKHPPKIPONK(NOPOCCDDOOL GGEOEEJGPGH, NOPOCCDDOOL OLIPOMNIFIH)
	{
		return default(NOPOCCDDOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E63320", Offset = "0x6E62320", VA = "0x186E63320")]
	private static uint LCPAHHJLMDP(uint LGLGFADDDNK, uint GMGEKOBCPAI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E630F0", Offset = "0x6E620F0", VA = "0x186E630F0", Slot = "4")]
	public int CompareTo(NOPOCCDDOOL DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E631A0", Offset = "0x6E621A0", VA = "0x186E631A0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E63470", Offset = "0x6E62470", VA = "0x186E63470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E63180", Offset = "0x6E62180", VA = "0x186E63180", Slot = "5")]
	public bool Equals(NOPOCCDDOOL DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E63230", Offset = "0x6E62230", VA = "0x186E63230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E63110", Offset = "0x6E62110", VA = "0x186E63110", Slot = "6")]
	public void EKFEJLFJOKC(DLKFKFPDMCG FOJCOMJJHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E63400", Offset = "0x6E62400", VA = "0x186E63400", Slot = "7")]
	public void OGCNNFLPKKP(FBBMEDEMDDK EEKHIEJPCBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2F95500", Offset = "0x2F94500", VA = "0x182F95500")]
	public static bool LJMKDDBNEAO(NOPOCCDDOOL GGEOEEJGPGH, NOPOCCDDOOL OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E63350", Offset = "0x6E62350", VA = "0x186E63350")]
	public static bool MCPOKKIFBCL(NOPOCCDDOOL GGEOEEJGPGH, NOPOCCDDOOL OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E63300", Offset = "0x6E62300", VA = "0x186E63300")]
	public static bool KLKEGOPCBHG(NOPOCCDDOOL GGEOEEJGPGH, NOPOCCDDOOL OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E633E0", Offset = "0x6E623E0", VA = "0x186E633E0")]
	public static bool MNEIFLIHCBL(NOPOCCDDOOL GGEOEEJGPGH, NOPOCCDDOOL OLIPOMNIFIH)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[KNPPIMNHCAF("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::GKBMJGNDIGJ(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, OFHBIFCOJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[global::BFHHOAIOEJG(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public static NetworkGuid ILBKFABDDDI(Guid EEKOILIMLBO)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E63660", Offset = "0x6E62660", VA = "0x186E63660", Slot = "4")]
		public bool Equals(NetworkGuid DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
		public int CompareTo(NetworkGuid DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6E635A0", Offset = "0x6E625A0", VA = "0x186E635A0", Slot = "6")]
		public void EKFEJLFJOKC(DLKFKFPDMCG FOJCOMJJHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6E63690", Offset = "0x6E62690", VA = "0x186E63690", Slot = "7")]
		public void OGCNNFLPKKP(FBBMEDEMDDK EEKHIEJPCBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E63700", Offset = "0x6E62700", VA = "0x186E63700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[global::GKBMJGNDIGJ(1, false)]
[KNPPIMNHCAF("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct KBHADCGBEAI : OFHBIFCOJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[global::BFHHOAIOEJG(1)]
	public bool MBINENIOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[global::BFHHOAIOEJG(2)]
	public float3 LCBIPIEIDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[global::BFHHOAIOEJG(3)]
	public float3 HKIMHOMJOEO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E62D70", Offset = "0x6E61D70", VA = "0x186E62D70")]
	public KBHADCGBEAI(float JCGGLMFLBCP, float PLFLOPDIPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E62CB0", Offset = "0x6E61CB0", VA = "0x186E62CB0", Slot = "4")]
	public void EKFEJLFJOKC(DLKFKFPDMCG FOJCOMJJHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E62D00", Offset = "0x6E61D00", VA = "0x186E62D00", Slot = "5")]
	public void OGCNNFLPKKP(FBBMEDEMDDK EEKHIEJPCBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[KNPPIMNHCAF("35984D5B-ACBD-4389-A94B-840070A871E2")]
[global::GKBMJGNDIGJ(1, false)]
public struct MBMAGBGFPBG : OFHBIFCOJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[global::BFHHOAIOEJG(1)]
	public float MLJJLHIOEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[global::BFHHOAIOEJG(2)]
	public int NHFALEGIHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[global::BFHHOAIOEJG(3)]
	public GBIMHBHEMDC IECLEDMOCFH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OKOBGLOFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E62F50", Offset = "0x6E61F50", VA = "0x186E62F50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E62F30", Offset = "0x6E61F30", VA = "0x186E62F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BENNLGNDAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E62FD0", Offset = "0x6E61FD0", VA = "0x186E62FD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E62FE0", Offset = "0x6E61FE0", VA = "0x186E62FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BPBCPOGGDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E62F60", Offset = "0x6E61F60", VA = "0x186E62F60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E63000", Offset = "0x6E62000", VA = "0x186E63000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E63020", Offset = "0x6E62020", VA = "0x186E63020", Slot = "5")]
	public void OGCNNFLPKKP(FBBMEDEMDDK EEKHIEJPCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E62F70", Offset = "0x6E61F70", VA = "0x186E62F70", Slot = "4")]
	public void EKFEJLFJOKC(DLKFKFPDMCG FOJCOMJJHIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class DMNJJCGOOAH : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class GBEFFDAGMKE : Property<RRObjectPrefabData, KOCACJKGAPP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6E62C20", Offset = "0x6E61C20", VA = "0x186E62C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6E62B30", Offset = "0x6E61B30", VA = "0x186E62B30")]
		public GBEFFDAGMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1B803C0", Offset = "0x1B7F3C0", VA = "0x181B803C0", Slot = "14")]
		public override KOCACJKGAPP GetValue(RRObjectPrefabData GHHOPPHGNHJ)
		{
			return default(KOCACJKGAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E62B20", Offset = "0x6E61B20", VA = "0x186E62B20", Slot = "15")]
		public override void SetValue(RRObjectPrefabData GHHOPPHGNHJ, KOCACJKGAPP BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E62920", Offset = "0x6E61920", VA = "0x186E62920")]
	public DMNJJCGOOAH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E63720", Offset = "0x6E62720", VA = "0x186E63720")]
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
