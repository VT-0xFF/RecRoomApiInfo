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
public interface AOOKKGFAIFC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Entity KFGIIIJDBHD
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
	[global::GGPHMMPBKAM(1, false)]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(11505792609904010668uL, 0u)]
	[NOCLMGJHKJJ("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[global::PNBOPLPMFJJ("new float3(float.NaN)")]
		[global::LPKOFLNCEDL(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FF30", Offset = "0x3D9ED30", VA = "0x183D9FF30")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61D83A0", Offset = "0x61D71A0", VA = "0x1861D83A0")]
		public static AuthoredLocalPoseData BPFJNEHKLMP(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[CompilerGenerated]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[global::ELBJEKKKDKC(9088562008033959482uL, 0u)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[global::PNBOPLPMFJJ(1f)]
		[global::LPKOFLNCEDL(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[global::ELBJEKKKDKC(10137300772124140051uL, 0u)]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	public struct AuthoredParentData : IComponentData, AOOKKGFAIFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static AuthoredParentData BPFJNEHKLMP(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61D83C0", Offset = "0x61D71C0", VA = "0x1861D83C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JGCCIECGMKN : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("1fc12b56-7902-430a-82ea-b62f7c9236bd")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	public struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[global::LPKOFLNCEDL(2)]
		[global::PNBOPLPMFJJ(false)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[global::LPKOFLNCEDL(3)]
		[global::PNBOPLPMFJJ(FCCPAOFFAPB.EnabledForRole)]
		public FCCPAOFFAPB filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[global::GGPHMMPBKAM(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(8594223769175916906uL, 0u)]
	[NOCLMGJHKJJ("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[global::LPKOFLNCEDL(2)]
		[global::PNBOPLPMFJJ]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[global::ELBJEKKKDKC(780699438743496039uL, 0u)]
	[global::GGPHMMPBKAM(1, false)]
	[CompilerGenerated]
	[NOCLMGJHKJJ("3A2478E6-C8A6-4A8B-9F53-B9690AFC54AF")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[global::PNBOPLPMFJJ(true)]
		[global::LPKOFLNCEDL(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[global::GGPHMMPBKAM(1, false)]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[NOCLMGJHKJJ("6C04E0EF-C7F4-41C7-85F9-38607F9FFA75")]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(-1)]
		public int actorId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[NOCLMGJHKJJ("5ED157AA-488F-453A-A986-594595B8D777")]
	[global::ELBJEKKKDKC(11853296779717712500uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[global::GGPHMMPBKAM(1, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	[NOCLMGJHKJJ("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[global::GGPHMMPBKAM(1, false)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(10)]
		public int MaxCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[global::ELBJEKKKDKC(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	public struct EntityBundlePartData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(2)]
		public uint entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityBundlePartId EntityBundlePartId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1E4F0B0", Offset = "0x1E4DEB0", VA = "0x181E4F0B0")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CF50", Offset = "0x1E1BD50", VA = "0x181E1CF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		internal EntityBundlePartId(uint NLFEJIHGBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0")]
		internal uint GHJIBIEMBMJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x888BC0", Offset = "0x8879C0", VA = "0x180888BC0", Slot = "4")]
		public bool Equals(EntityBundlePartId GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61D8A80", Offset = "0x61D7880", VA = "0x1861D8A80", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x93C630", Offset = "0x93B430", VA = "0x18093C630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1883660", Offset = "0x1882460", VA = "0x181883660")]
		public static bool OFKPFEHPLBH(EntityBundlePartId CGAHKNIFIAB, EntityBundlePartId CJOKOOBKDLJ)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[global::ELBJEKKKDKC(11104975410044731874uL, 0u)]
	[IPGCHINDMIH("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(GENGIDCKDKF.IsDynamicEnvironment)]
		[ACKFNDDHOHG(null, 0)]
		public GENGIDCKDKF collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GCJLKDKFPBD
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum FIGOPJOBBLC
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
	public enum AOIMCABDBEE
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
	[Cpp2IlInjected.Address(RVA = "0x61D8B10", Offset = "0x61D7910", VA = "0x1861D8B10")]
	public static (FIGOPJOBBLC, AOIMCABDBEE) PEIKAGJABPE(this GENGIDCKDKF NLIBJLKDDFN)
	{
		return default((FIGOPJOBBLC, AOIMCABDBEE));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[global::ELBJEKKKDKC(2914713536404587710uL, 0u)]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[global::GGPHMMPBKAM(1, false)]
	[CompilerGenerated]
	[IPGCHINDMIH("Container", 0)]
	[NOCLMGJHKJJ("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(NBCJNKAOEAB.Children)]
		[ACKFNDDHOHG(null, 0)]
		public NBCJNKAOEAB collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[NOCLMGJHKJJ("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[IPGCHINDMIH("Container", 0)]
	[global::GGPHMMPBKAM(2, false)]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[global::PNBOPLPMFJJ(BAMHMIEKLNG.DEFAULT)]
		[global::LPKOFLNCEDL(1)]
		[ACKFNDDHOHG(null, 0)]
		public BAMHMIEKLNG flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[global::ELBJEKKKDKC(1094837642118998916uL, 0u)]
	[IPGCHINDMIH("Container", 0)]
	[NOCLMGJHKJJ("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[global::GGPHMMPBKAM(1, false)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ACKFNDDHOHG(null, 0)]
		[global::PNBOPLPMFJJ(0f)]
		[global::LPKOFLNCEDL(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[IPGCHINDMIH("Container", 0)]
	[global::ELBJEKKKDKC(13657791279235747653uL, 0u)]
	[NOCLMGJHKJJ("89708D57-D027-494A-A159-221E6C643B6B")]
	[global::GGPHMMPBKAM(1, false)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[ACKFNDDHOHG(null, 0)]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[global::GGPHMMPBKAM(1, false)]
	[CompilerGenerated]
	[NOCLMGJHKJJ("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[IPGCHINDMIH("Container", 0)]
	[global::ELBJEKKKDKC(5176564412348566398uL, 0u)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		[ACKFNDDHOHG(null, 0)]
		public HINAGPNLPPN grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[global::ELBJEKKKDKC(16485879999901987510uL, 0u)]
	[NOCLMGJHKJJ("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[global::GGPHMMPBKAM(1, false)]
	[IPGCHINDMIH("Container", 0)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(NAPJHHHFHEA.NavMeshGenerator)]
		[ACKFNDDHOHG(null, 0)]
		public NAPJHHHFHEA mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[NOCLMGJHKJJ("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[global::GGPHMMPBKAM(1, false)]
	[global::ELBJEKKKDKC(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[global::GGPHMMPBKAM(1, false)]
	[global::ELBJEKKKDKC(5115014870530256079uL, 0u)]
	[NOCLMGJHKJJ("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(14429493078606832166uL, 0u)]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[NOCLMGJHKJJ("372AE436-C5D3-42FA-A4B5-1F3D77701F3D")]
	[global::GGPHMMPBKAM(1, false)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[global::ELBJEKKKDKC(12111354511484844847uL, 0u)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	public struct ParentData : IComponentData, AOOKKGFAIFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, AOOKKGFAIFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct NOCDIADDGLI : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(1950029632769634832uL, 0u)]
	[NOCLMGJHKJJ("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[global::GGPHMMPBKAM(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public BNGCCAMOOAG order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static SiblingSortOrderData BPFJNEHKLMP(BNGCCAMOOAG value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61D85F0", Offset = "0x61D73F0", VA = "0x1861D85F0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[NOCLMGJHKJJ("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[global::GGPHMMPBKAM(1, false)]
	[global::ELBJEKKKDKC(15012400804589552708uL, 0u)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[global::GGPHMMPBKAM(5, false)]
	[global::ELBJEKKKDKC(16541670854338945984uL, 0u)]
	[IPGCHINDMIH("Object", 0)]
	[CompilerGenerated]
	[NOCLMGJHKJJ("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[global::PNBOPLPMFJJ("new ScaleRestriction(1,1)")]
		[global::LPKOFLNCEDL(2)]
		public BCIMAJGAIIK scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[global::PNBOPLPMFJJ("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[global::LPKOFLNCEDL(3)]
		[ACKFNDDHOHG(null, 0)]
		public BDIGGNJMLKE userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[global::LPKOFLNCEDL(4)]
		[ACKFNDDHOHG(null, 0)]
		[global::PNBOPLPMFJJ(CGMBPBLFFDP.Default)]
		public CGMBPBLFFDP circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[global::PNBOPLPMFJJ("ObjectPolicyEnumFlags.Default")]
		[global::LPKOFLNCEDL(1)]
		public OCJBLPKOAED flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(17708500325183871236uL, 0u)]
	[NOCLMGJHKJJ("617A903E-C2C2-467C-A138-287FDB487645")]
	[global::GGPHMMPBKAM(1, false)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public Entity playerScope;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static PlayerScopeData BPFJNEHKLMP(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[global::ELBJEKKKDKC(16642773407304133105uL, 0u)]
	[IPGCHINDMIH("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[ACKFNDDHOHG(null, 0)]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(10537432342869025182uL, 0u)]
	[NOCLMGJHKJJ("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[global::GGPHMMPBKAM(1, false)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(LKFJFAGGHBK.None)]
		public LKFJFAGGHBK flags;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x61D93E0", Offset = "0x61D81E0", VA = "0x1861D93E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x61D93D0", Offset = "0x61D81D0", VA = "0x1861D93D0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[global::ELBJEKKKDKC(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[global::GGPHMMPBKAM(1, false)]
	[CompilerGenerated]
	[NOCLMGJHKJJ("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public ELLPOKPINBO shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[global::ELBJEKKKDKC(5298506180484533559uL, 0u)]
	[global::GGPHMMPBKAM(1, false)]
	[CompilerGenerated]
	[NOCLMGJHKJJ("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public BNGCCAMOOAG order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static SplinePointOrderData BPFJNEHKLMP(BNGCCAMOOAG value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[global::ELBJEKKKDKC(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[global::ELBJEKKKDKC(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[global::ELBJEKKKDKC(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[NOCLMGJHKJJ("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[global::GGPHMMPBKAM(1, false)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[global::PNBOPLPMFJJ("new quaternion(0, 0, 0, 1f)")]
		[global::LPKOFLNCEDL(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[global::ELBJEKKKDKC(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[NOCLMGJHKJJ("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[global::GGPHMMPBKAM(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[global::ELBJEKKKDKC(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public LFIODJEGHHP parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[global::GGPHMMPBKAM(1, false)]
	[NOCLMGJHKJJ("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(10026670690793008625uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(KDDDOHIEBOE.CURRENT)]
		public KDDDOHIEBOE version;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[global::ELBJEKKKDKC(12332323170023439017uL, 0u)]
	[CompilerGenerated]
	[global::GGPHMMPBKAM(2, false)]
	[global::CDFJEHNKAFL(new int[] { 1 })]
	[NOCLMGJHKJJ("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[global::LPKOFLNCEDL(2)]
		[global::PNBOPLPMFJJ(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[global::LPKOFLNCEDL(3)]
		[global::PNBOPLPMFJJ(true)]
		public bool optimizedCollidersEnabled;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NOCLMGJHKJJ("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[global::LEKMOPJPALB(LJDPJOPMJOF.MIN, LJDPJOPMJOF.ALL)]
[global::AICIMEIECPO(1, false)]
public enum LJDPJOPMJOF
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
	[NOCLMGJHKJJ("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	[global::GGPHMMPBKAM(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[global::PNBOPLPMFJJ(LJDPJOPMJOF.UseDefaultVisualEffects)]
		[global::LPKOFLNCEDL(2)]
		public LJDPJOPMJOF toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	[global::GGPHMMPBKAM(1, false)]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[NOCLMGJHKJJ("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[global::LPKOFLNCEDL(3)]
		[global::PNBOPLPMFJJ]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[global::GGPHMMPBKAM(2, false)]
	[NOCLMGJHKJJ("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[global::PNBOPLPMFJJ("new float3(1)")]
		[global::LPKOFLNCEDL(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[NOCLMGJHKJJ("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[global::GGPHMMPBKAM(1, false)]
	[global::ELBJEKKKDKC(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[global::LPKOFLNCEDL(1)]
		[ACKFNDDHOHG(null, 0)]
		[global::PNBOPLPMFJJ("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[global::LPKOFLNCEDL(2)]
		[global::PNBOPLPMFJJ]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FF30", Offset = "0x3D9ED30", VA = "0x183D9FF30")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61D83A0", Offset = "0x61D71A0", VA = "0x1861D83A0")]
		public static RigidTransform BPFJNEHKLMP(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61D83A0", Offset = "0x61D71A0", VA = "0x1861D83A0")]
		public static LocalPoseData BPFJNEHKLMP(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NKFKJPEBODO
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static RigidTransform GOBPAKHJAHP(this LocalPoseData DIBNBLEEFNN)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[global::ELBJEKKKDKC(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[NOCLMGJHKJJ("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[global::GGPHMMPBKAM(1, false)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[global::PNBOPLPMFJJ(1f)]
		[global::LPKOFLNCEDL(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[global::ELBJEKKKDKC(5730545663584378555uL, 0u)]
	[NOCLMGJHKJJ("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[global::GGPHMMPBKAM(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		public ICHMCKIKJLJ transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[global::LPKOFLNCEDL(2)]
		[global::PNBOPLPMFJJ]
		public ECKNNKKEMOB transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[global::GGPHMMPBKAM(1, false)]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(798350452111942523uL, 0u)]
	[global::IGJCKEHNFMD]
	[NOCLMGJHKJJ("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public struct RRObjectPrefabData : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public LGNBEHGCHLL prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[global::GGPHMMPBKAM(2, false)]
	[NOCLMGJHKJJ("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[global::PNBOPLPMFJJ(false)]
		[global::LPKOFLNCEDL(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[NOCLMGJHKJJ("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[global::GGPHMMPBKAM(1, false)]
	[global::ELBJEKKKDKC(1591066774816564574uL, 0u)]
	[CompilerGenerated]
	[IPGCHINDMIH("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[global::LPKOFLNCEDL(1)]
		[global::PNBOPLPMFJJ]
		[ACKFNDDHOHG(null, 0)]
		public DFGNLEDGGHJ color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[global::LPKOFLNCEDL(2)]
		[global::PNBOPLPMFJJ]
		[ACKFNDDHOHG(null, 0)]
		public MBFCDAMJAPM material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[global::LPKOFLNCEDL(3)]
		[ACKFNDDHOHG(null, 0)]
		[global::PNBOPLPMFJJ]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[global::PNBOPLPMFJJ]
		[ACKFNDDHOHG(null, 0)]
		[global::LPKOFLNCEDL(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[global::LEKMOPJPALB(CGMBPBLFFDP.NONE, CGMBPBLFFDP.COUNT)]
[NOCLMGJHKJJ("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[global::AICIMEIECPO(1, false)]
public enum CGMBPBLFFDP
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ACKFNDDHOHG("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ACKFNDDHOHG("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ACKFNDDHOHG("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(0, 4)]
[NOCLMGJHKJJ("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum LIHHOOMIMAD
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
[global::LEKMOPJPALB(OBACJIJHDBO.NONE, OBACJIJHDBO.ALL)]
[NOCLMGJHKJJ("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[global::AICIMEIECPO(1, false)]
public enum OBACJIJHDBO
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
[global::LEKMOPJPALB(NBCJNKAOEAB.Off, NBCJNKAOEAB.COUNT)]
[NOCLMGJHKJJ("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[global::AICIMEIECPO(1, false)]
public enum NBCJNKAOEAB
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
[PKKHBAAAOBP]
[NOCLMGJHKJJ("034DADCD-EFBA-4C2B-83BA-C3E8987A7585")]
[global::LEKMOPJPALB(KDDDOHIEBOE.VERSION_0, KDDDOHIEBOE.CURRENT)]
[global::AICIMEIECPO(1, false)]
public enum KDDDOHIEBOE : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[NOCLMGJHKJJ("F843A776-E042-43B7-8167-0C7A421062F8")]
[global::LEKMOPJPALB(0, 127)]
[global::AICIMEIECPO(1, false)]
public enum GENGIDCKDKF
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ACKFNDDHOHG("Dynamic (Environment)", 0)]
	[LJFJFBLCPKC("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ACKFNDDHOHG("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ACKFNDDHOHG("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ACKFNDDHOHG("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ACKFNDDHOHG("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ACKFNDDHOHG("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ACKFNDDHOHG("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ACKFNDDHOHG("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ACKFNDDHOHG("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[PKKHBAAAOBP]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[PKKHBAAAOBP]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Flags]
[global::AICIMEIECPO(1, false)]
[NOCLMGJHKJJ("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[global::LEKMOPJPALB(0, BAMHMIEKLNG.ALL)]
public enum BAMHMIEKLNG
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
[NOCLMGJHKJJ("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[global::LEKMOPJPALB(0, 2)]
[global::AICIMEIECPO(1, false)]
public enum ELLPOKPINBO
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
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(HINAGPNLPPN.Pivot, HINAGPNLPPN.COUNT)]
[NOCLMGJHKJJ("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum HINAGPNLPPN
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
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(FCCPAOFFAPB.EnabledForRole, FCCPAOFFAPB.DisabledForRole)]
[NOCLMGJHKJJ("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum FCCPAOFFAPB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DisabledForRole
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[global::LEKMOPJPALB(NAPJHHHFHEA.NavMeshGenerator, NAPJHHHFHEA.NavMeshBlocker)]
[global::AICIMEIECPO(1, false)]
[NOCLMGJHKJJ("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum NAPJHHHFHEA
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
[global::AICIMEIECPO(1, false)]
[Flags]
[NOCLMGJHKJJ("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[global::LEKMOPJPALB(OCJBLPKOAED.None, OCJBLPKOAED.All)]
public enum OCJBLPKOAED
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(0, KNGOHHKOPNC.COUNT)]
[NOCLMGJHKJJ("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum KNGOHHKOPNC
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
public static class EMNIIMFIFON
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61D8A40", Offset = "0x61D7840", VA = "0x1861D8A40")]
	public static void KNPAMBFMNAD(this OCJBLPKOAED OKIGIEHONKO, KNGOHHKOPNC IPHKKOLAAFN, bool AIBEMFNIBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61D8A20", Offset = "0x61D7820", VA = "0x1861D8A20")]
	public static bool HECKKLFGPJK(this OCJBLPKOAED OKIGIEHONKO, KNGOHHKOPNC IPHKKOLAAFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61D8A70", Offset = "0x61D7870", VA = "0x1861D8A70")]
	public static OCJBLPKOAED PFGHHHPBNFE(this KNGOHHKOPNC IPHKKOLAAFN)
	{
		return default(OCJBLPKOAED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[global::AICIMEIECPO(1, false)]
[NOCLMGJHKJJ("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
[global::LEKMOPJPALB(BDIGGNJMLKE.NONE, BDIGGNJMLKE.COUNT)]
public enum BDIGGNJMLKE
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
[global::AICIMEIECPO(1, false)]
[NOCLMGJHKJJ("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[global::LEKMOPJPALB(1000, 8000)]
public enum LGNBEHGCHLL
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ACKFNDDHOHG("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[ACKFNDDHOHG("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ACKFNDDHOHG("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ACKFNDDHOHG("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[PKKHBAAAOBP]
	UNUSED = 4000,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ACKFNDDHOHG("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ACKFNDDHOHG("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ACKFNDDHOHG("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ACKFNDDHOHG("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[ACKFNDDHOHG("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ACKFNDDHOHG("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ACKFNDDHOHG("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[ACKFNDDHOHG("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[ACKFNDDHOHG("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[ACKFNDDHOHG("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ACKFNDDHOHG("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ACKFNDDHOHG("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ACKFNDDHOHG("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[ACKFNDDHOHG("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ACKFNDDHOHG("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ACKFNDDHOHG("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ACKFNDDHOHG("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ACKFNDDHOHG("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ACKFNDDHOHG("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ACKFNDDHOHG("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[ACKFNDDHOHG("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[ACKFNDDHOHG("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[ACKFNDDHOHG("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	[ACKFNDDHOHG("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ACKFNDDHOHG("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[ACKFNDDHOHG("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[ACKFNDDHOHG("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ACKFNDDHOHG("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[ACKFNDDHOHG("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[ACKFNDDHOHG("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ACKFNDDHOHG("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ACKFNDDHOHG("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[ACKFNDDHOHG("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ACKFNDDHOHG("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ACKFNDDHOHG("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ACKFNDDHOHG("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ACKFNDDHOHG("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[ACKFNDDHOHG("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[ACKFNDDHOHG("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[ACKFNDDHOHG("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[ACKFNDDHOHG("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[PKKHBAAAOBP]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[ACKFNDDHOHG("Object", 0)]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[ACKFNDDHOHG("Object", 0)]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[ACKFNDDHOHG("Container", 0)]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[ACKFNDDHOHG("Gizmo", 0)]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[ACKFNDDHOHG("Object", 0)]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[ACKFNDDHOHG("Object", 0)]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[ACKFNDDHOHG("Container", 0)]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[ACKFNDDHOHG("Object", 0)]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[ACKFNDDHOHG("Object", 0)]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[ACKFNDDHOHG("Container", 0)]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[ACKFNDDHOHG("Socket", 0)]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[ACKFNDDHOHG("Player Socket", 0)]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[ACKFNDDHOHG("Player Rigidbody", 0)]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[ACKFNDDHOHG("Costume Dummy", 0)]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[ACKFNDDHOHG("Replicator", 0)]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[ACKFNDDHOHG("Non-Hierarchical Object", 0)]
	GameObject_NonHierarchicalObject = 7015,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[ACKFNDDHOHG("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class DANJLLBAOAM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61D8A00", Offset = "0x61D7800", VA = "0x1861D8A00")]
	public static GKJFLINHNGP CBPKALKFBFN(this LGNBEHGCHLL MIEPJJBHNJD)
	{
		return default(GKJFLINHNGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[NOCLMGJHKJJ("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[global::LEKMOPJPALB(0, 9)]
[global::AICIMEIECPO(1, false)]
public enum GKJFLINHNGP
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
public static class GIHBDJPADHO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61D8C80", Offset = "0x61D7A80", VA = "0x1861D8C80")]
	public static bool IJLNACCGGCG(this GKJFLINHNGP KICIGDGKKKO)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[global::ELBJEKKKDKC(8060729269509364919uL, 0u)]
	[NOCLMGJHKJJ("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[global::GGPHMMPBKAM(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[global::PNBOPLPMFJJ]
		[global::LPKOFLNCEDL(1)]
		public GGOBOICLBDK shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[global::AICIMEIECPO(1, false)]
[NOCLMGJHKJJ("517224CC-0A79-4FE9-B048-53C37955D823")]
[global::LEKMOPJPALB(-1, 38)]
public enum GGOBOICLBDK
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
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(0, 7)]
[NOCLMGJHKJJ("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[Flags]
public enum LKFJFAGGHBK
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
[NOCLMGJHKJJ("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[Flags]
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(0, 7)]
public enum GDPPMFDMIGG
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
[NOCLMGJHKJJ("72742F9B-D48E-4CED-B403-444201FFEE66")]
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(0, 1)]
[Flags]
public enum ICHMCKIKJLJ
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
[NOCLMGJHKJJ("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[global::LEKMOPJPALB(-2, 2)]
[global::AICIMEIECPO(1, false)]
public enum ECKNNKKEMOB
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
[NOCLMGJHKJJ("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[global::AICIMEIECPO(1, false)]
[global::LEKMOPJPALB(int.MinValue, int.MaxValue)]
public enum DFGNLEDGGHJ
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
[global::LEKMOPJPALB(-1, 31)]
[NOCLMGJHKJJ("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[global::AICIMEIECPO(1, false)]
public enum MBFCDAMJAPM
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
[global::NNNEDGMKHEH(1, false)]
[NOCLMGJHKJJ("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct BNGCCAMOOAG : IComparable<BNGCCAMOOAG>, IEquatable<BNGCCAMOOAG>, OMNELJLLMHF
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly BNGCCAMOOAG CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	[global::LPKOFLNCEDL(1)]
	public uint DDIAKCAGMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[global::LPKOFLNCEDL(2)]
	public uint MJADLBMDKPJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private readonly uint NBHLAOIIEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61D88C0", Offset = "0x61D76C0", VA = "0x1861D88C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61D89B0", Offset = "0x61D77B0", VA = "0x1861D89B0")]
	public BNGCCAMOOAG(int DDIAKCAGMHG, int CFDGGOCFBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61D89B0", Offset = "0x61D77B0", VA = "0x1861D89B0")]
	public BNGCCAMOOAG(uint DDIAKCAGMHG, uint CFDGGOCFBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61D8850", Offset = "0x61D7650", VA = "0x1861D8850")]
	public BNGCCAMOOAG MHBIMOKHDGG(int PJPGJICIKPG = 1)
	{
		return default(BNGCCAMOOAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61D8770", Offset = "0x61D7570", VA = "0x1861D8770")]
	public BNGCCAMOOAG JEECELLNHIN(int PJPGJICIKPG = 1)
	{
		return default(BNGCCAMOOAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61D84E0", Offset = "0x61D72E0", VA = "0x1861D84E0")]
	public static BNGCCAMOOAG BDLCGHIFPFL(BNGCCAMOOAG DCJCHFKPCOP, BNGCCAMOOAG IKGIOHGPKCP)
	{
		return default(BNGCCAMOOAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61D85C0", Offset = "0x61D73C0", VA = "0x1861D85C0")]
	private static uint DKBABMFEKAA(uint CGAHKNIFIAB, uint CJOKOOBKDLJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61D85A0", Offset = "0x61D73A0", VA = "0x1861D85A0", Slot = "4")]
	public int CompareTo(BNGCCAMOOAG GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61D8610", Offset = "0x61D7410", VA = "0x1861D8610", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61D88D0", Offset = "0x61D76D0", VA = "0x1861D88D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61D85F0", Offset = "0x61D73F0", VA = "0x1861D85F0", Slot = "5")]
	public bool Equals(BNGCCAMOOAG GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61D8720", Offset = "0x61D7520", VA = "0x1861D8720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61D87E0", Offset = "0x61D75E0", VA = "0x1861D87E0", Slot = "6")]
	public void JPFDICAGNEF(PFDOBINNEOD DFHABBFDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61D86B0", Offset = "0x61D74B0", VA = "0x1861D86B0", Slot = "7")]
	public void FPNHMAJLCHC(BJFFNENABKH HGAPEJGOMLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26ACDE0", Offset = "0x26ABBE0", VA = "0x1826ACDE0")]
	public static bool OFKPFEHPLBH(BNGCCAMOOAG DCJCHFKPCOP, BNGCCAMOOAG IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61D8580", Offset = "0x61D7380", VA = "0x1861D8580")]
	public static bool CAAJBKCJNPA(BNGCCAMOOAG DCJCHFKPCOP, BNGCCAMOOAG IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61D84C0", Offset = "0x61D72C0", VA = "0x1861D84C0")]
	public static bool AFAJILKDGGA(BNGCCAMOOAG DCJCHFKPCOP, BNGCCAMOOAG IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61D8560", Offset = "0x61D7360", VA = "0x1861D8560")]
	public static bool BJFDHOHLHLK(BNGCCAMOOAG DCJCHFKPCOP, BNGCCAMOOAG IKGIOHGPKCP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[global::NNNEDGMKHEH(1, false)]
	[NOCLMGJHKJJ("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>, OMNELJLLMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[global::LPKOFLNCEDL(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420")]
		public static NetworkGuid BPFJNEHKLMP(Guid IIGMMHCLOGB)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61D8F00", Offset = "0x61D7D00", VA = "0x1861D8F00", Slot = "4")]
		public bool Equals(NetworkGuid GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
		public int CompareTo(NetworkGuid GGINNHLAMLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x61D8FA0", Offset = "0x61D7DA0", VA = "0x1861D8FA0", Slot = "6")]
		public void JPFDICAGNEF(PFDOBINNEOD DFHABBFDBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61D8F30", Offset = "0x61D7D30", VA = "0x1861D8F30", Slot = "7")]
		public void FPNHMAJLCHC(BJFFNENABKH HGAPEJGOMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61D9060", Offset = "0x61D7E60", VA = "0x1861D9060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[NOCLMGJHKJJ("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[global::NNNEDGMKHEH(1, false)]
public struct BCIMAJGAIIK : OMNELJLLMHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[global::LPKOFLNCEDL(1)]
	public bool CDHMHHFKHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[global::LPKOFLNCEDL(2)]
	public float3 HEHGBKGFMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[global::LPKOFLNCEDL(3)]
	public float3 BECJDHAJJJE;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x61D8490", Offset = "0x61D7290", VA = "0x1861D8490")]
	public BCIMAJGAIIK(float CGPMFEMKNAJ, float BKMAHFHDFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x61D8440", Offset = "0x61D7240", VA = "0x1861D8440", Slot = "4")]
	public void JPFDICAGNEF(PFDOBINNEOD DFHABBFDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61D83D0", Offset = "0x61D71D0", VA = "0x1861D83D0", Slot = "5")]
	public void FPNHMAJLCHC(BJFFNENABKH HGAPEJGOMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[global::NNNEDGMKHEH(1, false)]
[NOCLMGJHKJJ("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct LFIODJEGHHP : OMNELJLLMHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[global::LPKOFLNCEDL(1)]
	public float EOPJONLKPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[global::LPKOFLNCEDL(2)]
	public int DGPDOKLLOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[global::LPKOFLNCEDL(3)]
	public GDPPMFDMIGG OKIGIEHONKO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KBJFHHJFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61D8CF0", Offset = "0x61D7AF0", VA = "0x1861D8CF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61D8D20", Offset = "0x61D7B20", VA = "0x1861D8D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MEAECPMKIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61D8DC0", Offset = "0x61D7BC0", VA = "0x1861D8DC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61D8D00", Offset = "0x61D7B00", VA = "0x1861D8D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CPEOHOBBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x61D8C90", Offset = "0x61D7A90", VA = "0x1861D8C90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x61D8D40", Offset = "0x61D7B40", VA = "0x1861D8D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61D8CA0", Offset = "0x61D7AA0", VA = "0x1861D8CA0", Slot = "5")]
	public void FPNHMAJLCHC(BJFFNENABKH HGAPEJGOMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61D8D60", Offset = "0x61D7B60", VA = "0x1861D8D60", Slot = "4")]
	public void JPFDICAGNEF(PFDOBINNEOD DFHABBFDBND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class OGAMPNFBFEN : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class NHNPLOPBLGG : Property<RRObjectPrefabData, LGNBEHGCHLL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61D8ED0", Offset = "0x61D7CD0", VA = "0x1861D8ED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61D8DE0", Offset = "0x61D7BE0", VA = "0x1861D8DE0")]
		public NHNPLOPBLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x13F0110", Offset = "0x13EEF10", VA = "0x1813F0110", Slot = "14")]
		public override LGNBEHGCHLL GetValue(RRObjectPrefabData COEPBABOGAM)
		{
			return default(LGNBEHGCHLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61D8DD0", Offset = "0x61D7BD0", VA = "0x1861D8DD0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData COEPBABOGAM, LGNBEHGCHLL DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61D9080", Offset = "0x61D7E80", VA = "0x1861D9080")]
	public OGAMPNFBFEN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61D9200", Offset = "0x61D8000", VA = "0x1861D9200")]
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
