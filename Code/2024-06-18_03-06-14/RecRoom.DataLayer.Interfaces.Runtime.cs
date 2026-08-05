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
public interface IGEIIFAFIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity OEJKIADKDEI
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
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[global::GIHIAFHCMNI(11505792609904010668uL, 0u)]
	[GAGOCMAPFPE("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::OMCHOCMMNFH(2)]
		[global::NEOHDGCLEBA("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42566D0", Offset = "0x42550D0", VA = "0x1842566D0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6889DD0", Offset = "0x68887D0", VA = "0x186889DD0")]
		public static RigidTransform OCHPDIOAFKC(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6889DD0", Offset = "0x68887D0", VA = "0x186889DD0")]
		public static AuthoredLocalPoseData OCHPDIOAFKC(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[global::GIHIAFHCMNI(9088562008033959482uL, 0u)]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[GAGOCMAPFPE("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[GAGOCMAPFPE("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[global::GIHIAFHCMNI(10137300772124140051uL, 0u)]
	public struct AuthoredParentData : IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static AuthoredParentData OCHPDIOAFKC(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6889DF0", Offset = "0x68887F0", VA = "0x186889DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LADOPHIFPCC : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::NEOHDGCLEBA(false)]
		[global::OMCHOCMMNFH(2)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::NEOHDGCLEBA(AKMIHCNIDHN.EnabledForRole)]
		[global::OMCHOCMMNFH(3)]
		public AKMIHCNIDHN filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[global::MGMOCBPCOCM(1, false)]
	[global::GIHIAFHCMNI(8594223769175916906uL, 0u)]
	[GAGOCMAPFPE("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[CompilerGenerated]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::OMCHOCMMNFH(2)]
		[global::NEOHDGCLEBA]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[global::GIHIAFHCMNI(780699438743496039uL, 0u)]
	[GAGOCMAPFPE("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::NEOHDGCLEBA(true)]
		[global::OMCHOCMMNFH(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[GAGOCMAPFPE("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[CompilerGenerated]
	[GAGOCMAPFPE("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::MGMOCBPCOCM(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::OMCHOCMMNFH(2)]
		[global::NEOHDGCLEBA(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FBJAOOBCPNF : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[GAGOCMAPFPE("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::NEOHDGCLEBA(10)]
		[global::OMCHOCMMNFH(1)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[global::MGMOCBPCOCM(2, false)]
	[GAGOCMAPFPE("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[GAGOCMAPFPE("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::MGMOCBPCOCM(1, false)]
	[global::GIHIAFHCMNI(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::OMCHOCMMNFH(2)]
		[global::NEOHDGCLEBA]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDFC0", Offset = "0x1FCC9C0", VA = "0x181FCDFC0")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1F903E0", Offset = "0x1F8EDE0", VA = "0x181F903E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		internal EntityBundlePartId(uint OBDGAAHPMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0")]
		internal uint NGIEGAMLMMK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9E72B0", Offset = "0x9E5CB0", VA = "0x1809E72B0", Slot = "4")]
		public bool Equals(EntityBundlePartId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x688A0E0", Offset = "0x6888AE0", VA = "0x18688A0E0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA9F800", Offset = "0xA9E200", VA = "0x180A9F800", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1A5E750", Offset = "0x1A5D150", VA = "0x181A5E750")]
		public static bool IKJGJDJDJIH(EntityBundlePartId GDMICPKKGFK, EntityBundlePartId JCAJPPHEFGK)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[JAPICABDNNI("Container", 0)]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[GAGOCMAPFPE("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[global::GIHIAFHCMNI(11104975410044731874uL, 0u)]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[global::NEOHDGCLEBA(PMMKGLFIGMM.IsDynamicEnvironment)]
		[global::OMCHOCMMNFH(1)]
		[GCMCLILHMGN(null, 0)]
		public PMMKGLFIGMM collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LCDNDAPIKGF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum HADEJPHFMAK
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
	public enum MJGLINIFNLH
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
	[Cpp2IlInjected.Address(RVA = "0x688A6C0", Offset = "0x68890C0", VA = "0x18688A6C0")]
	public static (HADEJPHFMAK, MJGLINIFNLH) DFNMLAEJDGO(this PMMKGLFIGMM NDBFPELDACP)
	{
		return default((HADEJPHFMAK, MJGLINIFNLH));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[global::GIHIAFHCMNI(2914713536404587710uL, 0u)]
	[JAPICABDNNI("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[GCMCLILHMGN(null, 0)]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(LJIPFCBIIIE.Children)]
		public LJIPFCBIIIE collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[global::MGMOCBPCOCM(2, false)]
	[GAGOCMAPFPE("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[JAPICABDNNI("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[GCMCLILHMGN(null, 0)]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(FCGHOGLKKBI.DEFAULT)]
		public FCGHOGLKKBI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::GIHIAFHCMNI(1094837642118998916uL, 0u)]
	[JAPICABDNNI("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::NEOHDGCLEBA(0f)]
		[GCMCLILHMGN(null, 0)]
		[global::OMCHOCMMNFH(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[JAPICABDNNI("Container", 0)]
	[GAGOCMAPFPE("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::GIHIAFHCMNI(13657791279235747653uL, 0u)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::NEOHDGCLEBA]
		[GCMCLILHMGN(null, 0)]
		[global::OMCHOCMMNFH(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[JAPICABDNNI("Container", 0)]
	[global::GIHIAFHCMNI(5176564412348566398uL, 0u)]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::NEOHDGCLEBA]
		[GCMCLILHMGN(null, 0)]
		[global::OMCHOCMMNFH(1)]
		public NFFMNGFGBJB grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[global::GIHIAFHCMNI(16485879999901987510uL, 0u)]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[CompilerGenerated]
	[JAPICABDNNI("Container", 0)]
	[GAGOCMAPFPE("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(HNCJGHHAJIP.NavMeshGenerator)]
		[GCMCLILHMGN(null, 0)]
		public HNCJGHHAJIP mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[global::MGMOCBPCOCM(1, false)]
	[global::GIHIAFHCMNI(1537567323754185605uL, 0u)]
	[GAGOCMAPFPE("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[global::GIHIAFHCMNI(5115014870530256079uL, 0u)]
	[GAGOCMAPFPE("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[global::GIHIAFHCMNI(12111354511484844847uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FPJPFAFFBBH : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[global::GIHIAFHCMNI(1950029632769634832uL, 0u)]
	[GAGOCMAPFPE("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public JCBPDGOJBKL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static SiblingSortOrderData OCHPDIOAFKC(JCBPDGOJBKL value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x688A3E0", Offset = "0x6888DE0", VA = "0x18688A3E0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[CompilerGenerated]
	[GAGOCMAPFPE("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[global::MGMOCBPCOCM(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[GAGOCMAPFPE("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(AKMIHCNIDHN.Disabled)]
		public AKMIHCNIDHN filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[GAGOCMAPFPE("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[GAGOCMAPFPE("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[global::MGMOCBPCOCM(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[GAGOCMAPFPE("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[global::GIHIAFHCMNI(15012400804589552708uL, 0u)]
	[global::MGMOCBPCOCM(1, false)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[GAGOCMAPFPE("FB9853D6-6231-43FD-A754-00105DC30880")]
	[global::GIHIAFHCMNI(16541670854338945984uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::MGMOCBPCOCM(5, false)]
	[JAPICABDNNI("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::NEOHDGCLEBA("new ScaleRestriction(1,1)")]
		[global::OMCHOCMMNFH(2)]
		public MEGKCGJEHNI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[GCMCLILHMGN(null, 0)]
		[global::NEOHDGCLEBA("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::OMCHOCMMNFH(3)]
		public PKOJBPLDAHP userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::NEOHDGCLEBA(AFMKDICJKCC.Default)]
		[GCMCLILHMGN(null, 0)]
		[global::OMCHOCMMNFH(4)]
		public AFMKDICJKCC circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::NEOHDGCLEBA("ObjectPolicyEnumFlags.Default")]
		[global::OMCHOCMMNFH(1)]
		public ALFPLPNGLNK flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::GIHIAFHCMNI(17708500325183871236uL, 0u)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static PlayerScopeData OCHPDIOAFKC(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[global::GIHIAFHCMNI(16642773407304133105uL, 0u)]
	[GAGOCMAPFPE("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[JAPICABDNNI("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::OMCHOCMMNFH(1)]
		[GCMCLILHMGN(null, 0)]
		[global::NEOHDGCLEBA(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[GAGOCMAPFPE("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[global::GIHIAFHCMNI(10537432342869025182uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA(LHBGCBDDANP.None)]
		public LHBGCBDDANP flags;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x688ADF0", Offset = "0x68897F0", VA = "0x18688ADF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E129B0", Offset = "0x5E113B0", VA = "0x185E129B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x688AE00", Offset = "0x6889800", VA = "0x18688AE00")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[GAGOCMAPFPE("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::MGMOCBPCOCM(1, false)]
	[global::GIHIAFHCMNI(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public NHMKJJKKPJH shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[GAGOCMAPFPE("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::GIHIAFHCMNI(5298506180484533559uL, 0u)]
	[global::MGMOCBPCOCM(1, false)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public JCBPDGOJBKL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static SplinePointOrderData OCHPDIOAFKC(JCBPDGOJBKL value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	[global::GIHIAFHCMNI(16368389834000856208uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[GAGOCMAPFPE("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[global::GIHIAFHCMNI(18095612727592564636uL, 0u)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[GAGOCMAPFPE("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[GAGOCMAPFPE("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[global::GIHIAFHCMNI(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[global::NEOHDGCLEBA("new quaternion(0, 0, 0, 1f)")]
		[global::OMCHOCMMNFH(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::GIHIAFHCMNI(1238044349990854547uL, 0u)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::GIHIAFHCMNI(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public BAOPFIECBOP parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[GAGOCMAPFPE("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[global::GIHIAFHCMNI(10026670690793008625uL, 0u)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[global::NEOHDGCLEBA(JMEKNLNCDIP.CURRENT)]
		[global::OMCHOCMMNFH(1)]
		public JMEKNLNCDIP version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[global::IMEBBCHBFNC(new int[] { 1 })]
	[GAGOCMAPFPE("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[global::MGMOCBPCOCM(2, false)]
	[CompilerGenerated]
	[global::GIHIAFHCMNI(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[global::NEOHDGCLEBA(true)]
		[global::OMCHOCMMNFH(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::OMCHOCMMNFH(3)]
		[global::NEOHDGCLEBA(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[global::CLMHPMEIIBK(FJIGBPDKKHF.MIN, FJIGBPDKKHF.ALL)]
[Flags]
public enum FJIGBPDKKHF
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
	[GAGOCMAPFPE("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[global::MGMOCBPCOCM(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::NEOHDGCLEBA(15f)]
		[global::OMCHOCMMNFH(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::NEOHDGCLEBA(FJIGBPDKKHF.UseDefaultVisualEffects)]
		[global::OMCHOCMMNFH(2)]
		public FJIGBPDKKHF toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[GAGOCMAPFPE("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[global::IMEBBCHBFNC(new int[] { 2, 3 })]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[global::MGMOCBPCOCM(2, false)]
	[CompilerGenerated]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(4)]
		public IIGMJHPOLKN statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[GAGOCMAPFPE("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[global::GMNDCIIAMFN(1, false)]
[Flags]
[global::CLMHPMEIIBK(IIGMJHPOLKN.None, IIGMJHPOLKN.ALL)]
public enum IIGMJHPOLKN
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
	[GAGOCMAPFPE("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::MGMOCBPCOCM(2, false)]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA("new float3(1)")]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[GAGOCMAPFPE("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::GIHIAFHCMNI(1369925932270831712uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[global::MGMOCBPCOCM(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[GCMCLILHMGN(null, 0)]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[global::OMCHOCMMNFH(2)]
		[global::NEOHDGCLEBA]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x42566D0", Offset = "0x42550D0", VA = "0x1842566D0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6889DD0", Offset = "0x68887D0", VA = "0x186889DD0")]
		public static RigidTransform OCHPDIOAFKC(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6889DD0", Offset = "0x68887D0", VA = "0x186889DD0")]
		public static LocalPoseData OCHPDIOAFKC(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FFBCDKBIJPN
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static RigidTransform OOOFAKINHHM(this LocalPoseData DBOBEHLEAAE)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::GIHIAFHCMNI(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[global::NEOHDGCLEBA(1f)]
		[global::OMCHOCMMNFH(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::GIHIAFHCMNI(5730545663584378555uL, 0u)]
	[GAGOCMAPFPE("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public IFBHIKOGANL transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(2)]
		public OLPOHBCGHKA transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[global::GIHIAFHCMNI(798350452111942523uL, 0u)]
	[global::KHLBHKHCLOD]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[GAGOCMAPFPE("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public MMAKLLHOPJG prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public KGNHGFCDFGP kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[GAGOCMAPFPE("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[global::MGMOCBPCOCM(1, false)]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct ANAMNPBEELM : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static ANAMNPBEELM LDMJBAPJLGF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6889DB0", Offset = "0x68887B0", VA = "0x186889DB0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer PHDMOAMCFBE, ReferenceGroupReferenceBuffer CPHIHAJIIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13808F0", Offset = "0x137F2F0", VA = "0x1813808F0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer GKHPLGCJCPF)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[GAGOCMAPFPE("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	public struct AuthoredUserTagReferenceBuffer : LNOKEMJGHDF, IBufferElementData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static AuthoredUserTagReferenceBuffer OCHPDIOAFKC(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface LNOKEMJGHDF : IBufferElementData, IGEIIFAFIJO
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[global::MGMOCBPCOCM(2, false)]
	[GAGOCMAPFPE("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[global::OMCHOCMMNFH(2)]
		[global::NEOHDGCLEBA(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[global::GIHIAFHCMNI(1859693175312uL, 0u)]
	[CompilerGenerated]
	[GAGOCMAPFPE("80D85A55-B2F6-4860-A851-62973DC10940")]
	[global::MGMOCBPCOCM(1, false)]
	public struct UserTagNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[global::NEOHDGCLEBA]
		[global::OMCHOCMMNFH(1)]
		public FixedString32Bytes Value;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x688AE10", Offset = "0x6889810", VA = "0x18688AE10")]
		public static UserTagNameData OCHPDIOAFKC(string value)
		{
			return default(UserTagNameData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[GAGOCMAPFPE("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	[InternalBufferCapacity(0)]
	public struct UserTagReferenceBuffer : LNOKEMJGHDF, IBufferElementData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static UserTagReferenceBuffer OCHPDIOAFKC(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[global::MGMOCBPCOCM(1, false)]
	[CompilerGenerated]
	[JAPICABDNNI("Visual", 0)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::GIHIAFHCMNI(1591066774816564574uL, 0u)]
	[GAGOCMAPFPE("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[global::OMCHOCMMNFH(1)]
		[GCMCLILHMGN(null, 0)]
		[global::NEOHDGCLEBA]
		public DMOGMHMAFJH color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[global::OMCHOCMMNFH(2)]
		[global::NEOHDGCLEBA]
		[GCMCLILHMGN(null, 0)]
		public OGAKFOBILNM material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[global::OMCHOCMMNFH(3)]
		[GCMCLILHMGN(null, 0)]
		[global::NEOHDGCLEBA]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::OMCHOCMMNFH(4)]
		[GCMCLILHMGN(null, 0)]
		[global::NEOHDGCLEBA]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[GAGOCMAPFPE("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::CLMHPMEIIBK(AFMKDICJKCC.NONE, AFMKDICJKCC.COUNT)]
[global::GMNDCIIAMFN(1, false)]
public enum AFMKDICJKCC
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[GCMCLILHMGN("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[GCMCLILHMGN("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[GCMCLILHMGN("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[GAGOCMAPFPE("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(0, 4)]
public enum IAMICNDEKJD
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
[global::CLMHPMEIIBK(KFPMOAKKADG.NONE, KFPMOAKKADG.ALL)]
[Flags]
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
public enum KFPMOAKKADG
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
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(LJIPFCBIIIE.Off, LJIPFCBIIIE.COUNT)]
[GAGOCMAPFPE("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum LJIPFCBIIIE
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
[DLIFFGJPNFN]
[global::CLMHPMEIIBK(JMEKNLNCDIP.VERSION_0, JMEKNLNCDIP.CURRENT)]
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
public enum JMEKNLNCDIP : uint
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(0, 127)]
[GAGOCMAPFPE("F843A776-E042-43B7-8167-0C7A421062F8")]
public enum PMMKGLFIGMM
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[GCMCLILHMGN("Dynamic (Environment)", 0)]
	[FNELNMPLHBO("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[GCMCLILHMGN("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[GCMCLILHMGN("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[GCMCLILHMGN("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[GCMCLILHMGN("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[GCMCLILHMGN("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[GCMCLILHMGN("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[GCMCLILHMGN("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[GCMCLILHMGN("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[DLIFFGJPNFN]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[DLIFFGJPNFN]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(0, FCGHOGLKKBI.ALL)]
[Flags]
[GAGOCMAPFPE("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum FCGHOGLKKBI
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
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::CLMHPMEIIBK(0, 2)]
public enum NHMKJJKKPJH
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
[GAGOCMAPFPE("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[global::CLMHPMEIIBK(NFFMNGFGBJB.Pivot, NFFMNGFGBJB.COUNT)]
[global::GMNDCIIAMFN(1, false)]
public enum NFFMNGFGBJB
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
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(AKMIHCNIDHN.EnabledForRole, AKMIHCNIDHN.DisabledForRole)]
[GAGOCMAPFPE("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum AKMIHCNIDHN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[global::CLMHPMEIIBK(HNCJGHHAJIP.NavMeshGenerator, HNCJGHHAJIP.NavMeshBlocker)]
public enum HNCJGHHAJIP
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
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(ALFPLPNGLNK.None, ALFPLPNGLNK.All)]
[Flags]
[GAGOCMAPFPE("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum ALFPLPNGLNK
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[GAGOCMAPFPE("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(0, EKMICOLCDKG.COUNT)]
public enum EKMICOLCDKG
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
public static class OHMOFHIGBIM
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x688AAA0", Offset = "0x68894A0", VA = "0x18688AAA0")]
	public static void BJDAAADFLKD(this ALFPLPNGLNK GBNNPAAOJAG, EKMICOLCDKG CDGHHKJCNJM, bool MOPHDJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x688AAD0", Offset = "0x68894D0", VA = "0x18688AAD0")]
	public static bool FLDLBOBHHPJ(this ALFPLPNGLNK GBNNPAAOJAG, EKMICOLCDKG CDGHHKJCNJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1C1CBB0", Offset = "0x1C1B5B0", VA = "0x181C1CBB0")]
	public static ALFPLPNGLNK FPGBKOLGDDI(this EKMICOLCDKG CDGHHKJCNJM)
	{
		return default(ALFPLPNGLNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::CLMHPMEIIBK(PKOJBPLDAHP.NONE, PKOJBPLDAHP.COUNT)]
[GAGOCMAPFPE("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
[global::GMNDCIIAMFN(1, false)]
public enum PKOJBPLDAHP
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
[global::CLMHPMEIIBK(1000, 8000)]
[GAGOCMAPFPE("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::GMNDCIIAMFN(1, false)]
public enum MMAKLLHOPJG
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[GCMCLILHMGN("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[GCMCLILHMGN("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[GCMCLILHMGN("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[GCMCLILHMGN("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[DLIFFGJPNFN]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[GCMCLILHMGN("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[GCMCLILHMGN("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[GCMCLILHMGN("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[GCMCLILHMGN("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[GCMCLILHMGN("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[GCMCLILHMGN("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[GCMCLILHMGN("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[GCMCLILHMGN("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[GCMCLILHMGN("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[GCMCLILHMGN("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[GCMCLILHMGN("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[GCMCLILHMGN("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[GCMCLILHMGN("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[GCMCLILHMGN("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[GCMCLILHMGN("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[GCMCLILHMGN("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[GCMCLILHMGN("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[GCMCLILHMGN("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[GCMCLILHMGN("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[GCMCLILHMGN("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[GCMCLILHMGN("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[GCMCLILHMGN("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[GCMCLILHMGN("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[GCMCLILHMGN("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[GCMCLILHMGN("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[GCMCLILHMGN("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[GCMCLILHMGN("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[GCMCLILHMGN("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[GCMCLILHMGN("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[GCMCLILHMGN("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[GCMCLILHMGN("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[GCMCLILHMGN("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[GCMCLILHMGN("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[GCMCLILHMGN("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[GCMCLILHMGN("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[GCMCLILHMGN("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[GCMCLILHMGN("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[GCMCLILHMGN("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[GCMCLILHMGN("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[GCMCLILHMGN("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[GCMCLILHMGN("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[GCMCLILHMGN("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[GCMCLILHMGN("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[GCMCLILHMGN("Interaction Filter", 0)]
	Other_InteractionFilter_Tags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[DLIFFGJPNFN]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[GCMCLILHMGN("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[GCMCLILHMGN("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[GCMCLILHMGN("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[GCMCLILHMGN("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[GCMCLILHMGN("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[GCMCLILHMGN("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[GCMCLILHMGN("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[GCMCLILHMGN("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[GCMCLILHMGN("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[GCMCLILHMGN("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[GCMCLILHMGN("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[GCMCLILHMGN("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[GCMCLILHMGN("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[GCMCLILHMGN("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[GCMCLILHMGN("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[GCMCLILHMGN("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[GCMCLILHMGN("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DAMAFDBLBOO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6889F40", Offset = "0x6888940", VA = "0x186889F40")]
	public static COBMOEEAMHE DPBLOIMOLDC(this MMAKLLHOPJG ECCNNFLILMF)
	{
		return default(COBMOEEAMHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[global::CLMHPMEIIBK(0, 9)]
[GAGOCMAPFPE("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::GMNDCIIAMFN(1, false)]
public enum COBMOEEAMHE
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
public static class GKAPMDBKEDL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x688A170", Offset = "0x6888B70", VA = "0x18688A170")]
	public static bool AHGJJCFIMDG(this COBMOEEAMHE OKFFBBDMJCF)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::MGMOCBPCOCM(1, false)]
	[GAGOCMAPFPE("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::GIHIAFHCMNI(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[global::OMCHOCMMNFH(1)]
		[global::NEOHDGCLEBA]
		public KLOIDLPMPGK shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[global::CLMHPMEIIBK(-1, 38)]
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum KLOIDLPMPGK
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
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[global::CLMHPMEIIBK(KGNHGFCDFGP.None, KGNHGFCDFGP.COUNT)]
public enum KGNHGFCDFGP : byte
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
[GAGOCMAPFPE("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[global::GMNDCIIAMFN(1, false)]
[Flags]
[global::CLMHPMEIIBK(0, 7)]
public enum LHBGCBDDANP
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
[Flags]
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[global::CLMHPMEIIBK(0, 7)]
public enum DMAJHPKBJIG
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
[global::GMNDCIIAMFN(1, false)]
[global::CLMHPMEIIBK(0, 1)]
[GAGOCMAPFPE("72742F9B-D48E-4CED-B403-444201FFEE66")]
[Flags]
public enum IFBHIKOGANL
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
[global::CLMHPMEIIBK(-2, 2)]
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum OLPOHBCGHKA
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
[global::GMNDCIIAMFN(1, false)]
[GAGOCMAPFPE("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::CLMHPMEIIBK(int.MinValue, int.MaxValue)]
public enum DMOGMHMAFJH
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
[global::CLMHPMEIIBK(-1, 31)]
[GAGOCMAPFPE("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::GMNDCIIAMFN(1, false)]
public enum OGAKFOBILNM
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
[global::DCHIAKANPNF(1, false)]
[GAGOCMAPFPE("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct JCBPDGOJBKL : IComparable<JCBPDGOJBKL>, IEquatable<JCBPDGOJBKL>, FIILODEJPOA
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static readonly JCBPDGOJBKL EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[global::OMCHOCMMNFH(1)]
	public uint ECGGJPNIHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	[global::OMCHOCMMNFH(2)]
	public uint CMCJHGBJBMG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private readonly uint HJGFMPMCJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x688A470", Offset = "0x6888E70", VA = "0x18688A470")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x688A670", Offset = "0x6889070", VA = "0x18688A670")]
	public JCBPDGOJBKL(int ECGGJPNIHPM, int LEKGHPPMDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x688A670", Offset = "0x6889070", VA = "0x18688A670")]
	public JCBPDGOJBKL(uint ECGGJPNIHPM, uint LEKGHPPMDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x688A290", Offset = "0x6888C90", VA = "0x18688A290")]
	public JCBPDGOJBKL BJPIMBILDGA(int LJEHDHLGGJA = 1)
	{
		return default(JCBPDGOJBKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x688A1A0", Offset = "0x6888BA0", VA = "0x18688A1A0")]
	public JCBPDGOJBKL ANGAIEJCJLK(int LJEHDHLGGJA = 1)
	{
		return default(JCBPDGOJBKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x688A210", Offset = "0x6888C10", VA = "0x18688A210")]
	public static JCBPDGOJBKL BIKJKNEOIAB(JCBPDGOJBKL FKJLOGAHGLJ, JCBPDGOJBKL MJMNBMLJKJJ)
	{
		return default(JCBPDGOJBKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x688A540", Offset = "0x6888F40", VA = "0x18688A540")]
	private static uint NEBBNOHBJNF(uint GDMICPKKGFK, uint JCAJPPHEFGK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x688A320", Offset = "0x6888D20", VA = "0x18688A320", Slot = "4")]
	public int CompareTo(JCBPDGOJBKL HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x688A340", Offset = "0x6888D40", VA = "0x18688A340", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x688A590", Offset = "0x6888F90", VA = "0x18688A590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x688A3E0", Offset = "0x6888DE0", VA = "0x18688A3E0", Slot = "5")]
	public bool Equals(JCBPDGOJBKL HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x688A480", Offset = "0x6888E80", VA = "0x18688A480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x688A4D0", Offset = "0x6888ED0", VA = "0x18688A4D0", Slot = "6")]
	public void KJCBMOAEMAH(FBEHPONBLLD AACOMNCLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x688A400", Offset = "0x6888E00", VA = "0x18688A400", Slot = "7")]
	public void FIOJCIMJMME(IOPLKNHCKLE DGAMLJBEAIK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29983E0", Offset = "0x2996DE0", VA = "0x1829983E0")]
	public static bool IKJGJDJDJIH(JCBPDGOJBKL FKJLOGAHGLJ, JCBPDGOJBKL MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x688A300", Offset = "0x6888D00", VA = "0x18688A300")]
	public static bool BNNGOGJDCPO(JCBPDGOJBKL FKJLOGAHGLJ, JCBPDGOJBKL MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x688A570", Offset = "0x6888F70", VA = "0x18688A570")]
	public static bool OKICMNCLDCG(JCBPDGOJBKL FKJLOGAHGLJ, JCBPDGOJBKL MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x688A180", Offset = "0x6888B80", VA = "0x18688A180")]
	public static bool AELOHONOJAK(JCBPDGOJBKL FKJLOGAHGLJ, JCBPDGOJBKL MJMNBMLJKJJ)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[GAGOCMAPFPE("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[global::DCHIAKANPNF(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, FIILODEJPOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[global::OMCHOCMMNFH(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public static NetworkGuid OCHPDIOAFKC(Guid JCMDDLFAGEN)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x688A920", Offset = "0x6889320", VA = "0x18688A920", Slot = "4")]
		public bool Equals(NetworkGuid HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
		public int CompareTo(NetworkGuid HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x688A9C0", Offset = "0x68893C0", VA = "0x18688A9C0", Slot = "6")]
		public void KJCBMOAEMAH(FBEHPONBLLD AACOMNCLNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x688A950", Offset = "0x6889350", VA = "0x18688A950", Slot = "7")]
		public void FIOJCIMJMME(IOPLKNHCKLE DGAMLJBEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x688AA80", Offset = "0x6889480", VA = "0x18688AA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[global::DCHIAKANPNF(1, false)]
[GAGOCMAPFPE("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct MEGKCGJEHNI : FIILODEJPOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[global::OMCHOCMMNFH(1)]
	public bool OPDIOPBPNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[global::OMCHOCMMNFH(2)]
	public float3 EEJMAMCKAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[global::OMCHOCMMNFH(3)]
	public float3 ILHCLIFAFHO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x688A8F0", Offset = "0x68892F0", VA = "0x18688A8F0")]
	public MEGKCGJEHNI(float MJGGCDOBPLJ, float NFEEPMFGNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x688A8A0", Offset = "0x68892A0", VA = "0x18688A8A0", Slot = "4")]
	public void KJCBMOAEMAH(FBEHPONBLLD AACOMNCLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x688A830", Offset = "0x6889230", VA = "0x18688A830", Slot = "5")]
	public void FIOJCIMJMME(IOPLKNHCKLE DGAMLJBEAIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[global::DCHIAKANPNF(1, false)]
[GAGOCMAPFPE("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct BAOPFIECBOP : FIILODEJPOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[global::OMCHOCMMNFH(1)]
	public float JOBNFKNMKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[global::OMCHOCMMNFH(2)]
	public int ALHGLLAOLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[global::OMCHOCMMNFH(3)]
	public DMAJHPKBJIG GBNNPAAOJAG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool IGFFJMNDPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6889F10", Offset = "0x6888910", VA = "0x186889F10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6889F20", Offset = "0x6888920", VA = "0x186889F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BJJMAKBIIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6889EA0", Offset = "0x68888A0", VA = "0x186889EA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6889E30", Offset = "0x6888830", VA = "0x186889E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool LCCNMAKCMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6889E20", Offset = "0x6888820", VA = "0x186889E20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6889E00", Offset = "0x6888800", VA = "0x186889E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6889E50", Offset = "0x6888850", VA = "0x186889E50", Slot = "5")]
	public void FIOJCIMJMME(IOPLKNHCKLE DGAMLJBEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6889EB0", Offset = "0x68888B0", VA = "0x186889EB0", Slot = "4")]
	public void KJCBMOAEMAH(FBEHPONBLLD AACOMNCLNFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class DBAIAHJIFLO : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class PDIAGNFNFLC : Property<RRObjectPrefabData, MMAKLLHOPJG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x688ABF0", Offset = "0x68895F0", VA = "0x18688ABF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x688AB00", Offset = "0x6889500", VA = "0x18688AB00")]
		public PDIAGNFNFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x158E9A0", Offset = "0x158D3A0", VA = "0x18158E9A0", Slot = "14")]
		public override MMAKLLHOPJG GetValue(RRObjectPrefabData FOPICBKBDEP)
		{
			return default(MMAKLLHOPJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x688AAF0", Offset = "0x68894F0", VA = "0x18688AAF0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData FOPICBKBDEP, MMAKLLHOPJG DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6889F60", Offset = "0x6888960", VA = "0x186889F60")]
	public DBAIAHJIFLO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x688AC20", Offset = "0x6889620", VA = "0x18688AC20")]
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
