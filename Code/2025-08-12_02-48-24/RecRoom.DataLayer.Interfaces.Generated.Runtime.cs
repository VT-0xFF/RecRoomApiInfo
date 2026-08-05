using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83EBC60", Offset = "0x83EA260", VA = "0x1883EBC60", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23A8580", Offset = "0x23A6B80", VA = "0x1823A8580", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8402040", Offset = "0x8400640", VA = "0x188402040")]
		private void DHALDHDBNEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84021B0", Offset = "0x84007B0", VA = "0x1884021B0")]
		private void FAEKOOMPDOO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8402320", Offset = "0x8400920", VA = "0x188402320", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8402660", Offset = "0x8400C60", VA = "0x188402660")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	[CompilerGenerated]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct SerializedDataLayerVersionData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabData_v1 : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPrefabType_v1 prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Field(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2299272917927886785uL)]
	public struct TerrainGenerationData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public uint Seed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(2)]
		public float BaseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Field(3)]
		public float BaseTerrainFeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(4)]
		public TerrainPlayAreaShape_v1 PlayAreaShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(5)]
		public TerrainLayerRoughness_v1 BaseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(6)]
		public TerrainLayerHeightFunction_v1 BaseTerrainHeightFunction;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[CompilerGenerated]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(2)]
		public FixedString64Bytes AICodeGenId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.TypeVersion(2)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	public struct ObjectPolicyData_v5 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct OBBAANPPIBD : IComparable<OBBAANPPIBD>, IEquatable<OBBAANPPIBD>
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OBBAANPPIBD OBPFBJLIFCL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly OBBAANPPIBD KLCCKEGCKGG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly OBBAANPPIBD EEFJBECNFON;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly OBBAANPPIBD IEOGKDBOKKP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly OBBAANPPIBD MDFLHFFHGPC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly OBBAANPPIBD ONFBHFDMOMD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly int LEPAEEGOBDO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type PMBMBONEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8400980", Offset = "0x83FEF80", VA = "0x188400980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IDBKJPJKELN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8400840", Offset = "0x83FEE40", VA = "0x188400840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OJPHAFPPPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8400A60", Offset = "0x83FF060", VA = "0x188400A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type CPKABCPJMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8400BA0", Offset = "0x83FF1A0", VA = "0x188400BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GPIDHGBECCC FFNFKGMEIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8400230", Offset = "0x83FE830", VA = "0x188400230")]
		get
		{
			return default(GPIDHGBECCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EKCKFGICOJD OPKGGKDOOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8400640", Offset = "0x83FEC40", VA = "0x188400640")]
		get
		{
			return default(EKCKFGICOJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ODIFBOCCEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8400190", Offset = "0x83FE790", VA = "0x188400190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KDCBMGANBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84001E0", Offset = "0x83FE7E0", VA = "0x1884001E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KPGMEIJIOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8400C80", Offset = "0x83FF280", VA = "0x188400C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BAPOLBHOPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84003B0", Offset = "0x83FE9B0", VA = "0x1884003B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
	public OBBAANPPIBD(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8400510", Offset = "0x83FEB10", VA = "0x188400510", Slot = "5")]
	public bool Equals(OBBAANPPIBD IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8400590", Offset = "0x83FEB90", VA = "0x188400590", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8400DE0", Offset = "0x83FF3E0", VA = "0x188400DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x53E62E0", Offset = "0x53E48E0", VA = "0x1853E62E0", Slot = "4")]
	public int CompareTo(OBBAANPPIBD IBCMCOKAJEM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct KJOHOPGPKNM<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly int LEPAEEGOBDO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private OBBAANPPIBD LHCKNCJDPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		get
		{
			return default(OBBAANPPIBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
	internal KJOHOPGPKNM(int LEPAEEGOBDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x217FD40", Offset = "0x217E340", VA = "0x18217FD40")]
	public static OBBAANPPIBD HPNBGLLBBBG(KJOHOPGPKNM<T> BJBANDBIGLN)
	{
		return default(OBBAANPPIBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55CF1E0", Offset = "0x55CD7E0", VA = "0x1855CF1E0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55D0500", Offset = "0x55CEB00", VA = "0x1855D0500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83DFA00", Offset = "0x83DE000", VA = "0x1883DFA00")]
		public static (long, string, string)[] DBBGIIJGBNM(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : KMOLGOGOMLG, HPCDMPIBNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly DeferredEntityCommandBuffer decb;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x83EB350", Offset = "0x83E9950", VA = "0x1883EB350", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x83EB410", Offset = "0x83E9A10", VA = "0x1883EB410", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83EB300", Offset = "0x83E9900", VA = "0x1883EB300")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class DECBMeshPresenterNetworkData : KIDPBNIGCAD, HPCDMPIBNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly DeferredEntityCommandBuffer decb;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FixedString32Bytes MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83EB190", Offset = "0x83E9790", VA = "0x1883EB190", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x83EB0E0", Offset = "0x83E96E0", VA = "0x1883EB0E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x83EB020", Offset = "0x83E9620", VA = "0x1883EB020", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x83EB260", Offset = "0x83E9860", VA = "0x1883EB260", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83EB300", Offset = "0x83E9900", VA = "0x1883EB300")]
		public DECBMeshPresenterNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static Dictionary<Type, BGAFDIDDMKP> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<Type, BGAFDIDDMKP> interfaces;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83EBC10", Offset = "0x83EA210", VA = "0x1883EBC10")]
		public static IReadOnlyDictionary<Type, BGAFDIDDMKP> PHEAIKAMIPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83EB4C0", Offset = "0x83E9AC0", VA = "0x1883EB4C0")]
		private Dictionary<Type, BGAFDIDDMKP> CBPAAEAGBMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83EB600", Offset = "0x83E9C00", VA = "0x1883EB600")]
		private void MDAIIBANHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83EB580", Offset = "0x83E9B80", VA = "0x1883EB580")]
		private readonly void GHMGDAEPFLL(Type interfaceType, BGAFDIDDMKP implementationType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83EE150", Offset = "0x83EC750", VA = "0x1883EE150")]
		public static Type[] ODKLHGBHPFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83EBF40", Offset = "0x83EA540", VA = "0x1883EBF40")]
		private static void CBPAAEAGBMC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public enum TerrainLayerHeightFunction_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Steep,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Mesa
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public enum TerrainLayerRoughness_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		GentleSlopes,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RuggedSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		MediumSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		RiverBed
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v3 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		SuppressCollision = 16384,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public enum TerrainPlayAreaShape_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Circle,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Square
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public class SandboxDeformableShapeDefaults : BCNLMIDFFMP, KMOLGOGOMLG, HPCDMPIBNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1281700", Offset = "0x127FD00", VA = "0x181281700", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x18C8F10", Offset = "0x18C7510", VA = "0x1818C8F10", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8401C00", Offset = "0x8400200", VA = "0x188401C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8401AC0", Offset = "0x84000C0", VA = "0x188401AC0", Slot = "4")]
		public void CBDEJAGDNOD(HPCDMPIBNMN networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public interface ISandboxDeformableShapeNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public interface ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public class R2SandboxDeformableShapeNetworkData : BDDADAJIGDN, HPCDMPIBNMN, KMOLGOGOMLG, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IOLMBKKACOM service;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x84019E0", Offset = "0x83FFFE0", VA = "0x1884019E0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8401820", Offset = "0x83FFE20", VA = "0x188401820", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8401900", Offset = "0x83FFF00", VA = "0x188401900", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8401890", Offset = "0x83FFE90", VA = "0x188401890", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8401760", Offset = "0x83FFD60", VA = "0x188401760", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8401630", Offset = "0x83FFC30", VA = "0x188401630", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84016F0", Offset = "0x83FFCF0", VA = "0x1884016F0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8401970", Offset = "0x83FFF70", VA = "0x188401970", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2F80", Offset = "0x4FA1580", VA = "0x184FA2F80")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, IOLMBKKACOM networkDataService)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Scale : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float3 value;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public class MeshPresenterDefaults : BCNLMIDFFMP, KIDPBNIGCAD, HPCDMPIBNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		private FixedString32Bytes meshStorageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private (long RequestId, int ActorNumber, int ServerTimestamp) meshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FixedString32Bytes MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4B0AA00", Offset = "0x4B09000", VA = "0x184B0AA00", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83EBED0", Offset = "0x83EA4D0", VA = "0x1883EBED0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xF61520", Offset = "0xF5FB20", VA = "0x180F61520", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xF621F0", Offset = "0xF607F0", VA = "0x180F621F0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83EBEE0", Offset = "0x83EA4E0", VA = "0x1883EBEE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83EBD30", Offset = "0x83EA330", VA = "0x1883EBD30", Slot = "4")]
		public void CBDEJAGDNOD(HPCDMPIBNMN networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MeshPresenterDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public interface IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool IsMeshGenerationRequestSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public class R2MeshPresenterNetworkData : BDDADAJIGDN, HPCDMPIBNMN, KIDPBNIGCAD, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private IOLMBKKACOM service;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8401550", Offset = "0x83FFB50", VA = "0x188401550", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8401410", Offset = "0x83FFA10", VA = "0x188401410", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8401250", Offset = "0x83FF850", VA = "0x188401250", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8401330", Offset = "0x83FF930", VA = "0x188401330", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8401480", Offset = "0x83FFA80", VA = "0x188401480", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshGenerationRequestSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x84011F0", Offset = "0x83FF7F0", VA = "0x1884011F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84014E0", Offset = "0x83FFAE0", VA = "0x1884014E0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84012C0", Offset = "0x83FF8C0", VA = "0x1884012C0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x84013A0", Offset = "0x83FF9A0", VA = "0x1884013A0", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8401180", Offset = "0x83FF780", VA = "0x188401180", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2F80", Offset = "0x4FA1580", VA = "0x184FA2F80")]
		public R2MeshPresenterNetworkData(Entity entity, IOLMBKKACOM networkDataService)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshStorageFilename : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public FixedString32Bytes value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshGenerationRequest : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly KJOHOPGPKNM<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		[IsBuffer]
		public static readonly KJOHOPGPKNM<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly KJOHOPGPKNM<EKGHLLENOHA> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		[IsBuffer]
		public static readonly KJOHOPGPKNM<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly KJOHOPGPKNM<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		[IsBuffer]
		public static readonly KJOHOPGPKNM<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		[IsBuffer]
		public static readonly KJOHOPGPKNM<TerrainGenerationLayer> TerrainLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> OwnedByTerrain_isOwnedByTerrain;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly KJOHOPGPKNM<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly KJOHOPGPKNM<BPPEILIDMBL> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly KJOHOPGPKNM<EDCLCHHFDDJ> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly KJOHOPGPKNM<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly KJOHOPGPKNM<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly KJOHOPGPKNM<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FNJGDEFCMNB> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly KJOHOPGPKNM<uint> TerrainGeneration_Seed;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> TerrainGeneration_BaseTerrainHeight;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> TerrainGeneration_BaseTerrainFeatureScale;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly KJOHOPGPKNM<IDAMNGPLNCK> TerrainGeneration_PlayAreaShape;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LMJANGHOCHE> TerrainGeneration_BaseTerrainRoughness;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LKFHIDCNMGI> TerrainGeneration_BaseTerrainHeightFunction;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> TerrainGeneration_PlayAreaOpacity;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		[IsBuffer]
		public static readonly KJOHOPGPKNM<NPDFLAAOGLM> TerrainMaterialLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		[IsBuffer]
		public static readonly KJOHOPGPKNM<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly KJOHOPGPKNM<PPBNHAEPJLD> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FNNLELJCGID> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly KJOHOPGPKNM<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly KJOHOPGPKNM<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> TerrainWater_WaterHeight;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> TerrainWater_WaterChop;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> TerrainWater_WaterAlpha;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly KJOHOPGPKNM<DLKBGAHIKAB> TerrainWater_WaterColor;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly KJOHOPGPKNM<DLKBGAHIKAB> TerrainWater_DeepColor;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> TerrainWater_EmissiveStrength;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[R2Only]
		public static readonly KJOHOPGPKNM<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FDHJIACFCFO> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[R2Only]
		public static readonly KJOHOPGPKNM<EMDHJAPEHGM> PlayerRoleComponent_RoleType;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[R2Only]
		public static readonly KJOHOPGPKNM<DFBCNJDDJPE> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[R2Only]
		public static readonly KJOHOPGPKNM<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[R2Only]
		public static readonly KJOHOPGPKNM<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(LEJODJOIJLE))]
		public static readonly KJOHOPGPKNM<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[R2Only]
		public static readonly KJOHOPGPKNM<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[R2Only]
		public static readonly KJOHOPGPKNM<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[R2Only]
		public static readonly KJOHOPGPKNM<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[R2Only]
		public static readonly KJOHOPGPKNM<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[R2Only]
		public static readonly KJOHOPGPKNM<EKGHLLENOHA> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[R2Only]
		public static readonly KJOHOPGPKNM<DLKBGAHIKAB> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[R2Only]
		public static readonly KJOHOPGPKNM<BBOJGHFINDF> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[R2Only]
		public static readonly KJOHOPGPKNM<KBEFHOKOHMI> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[R2Only]
		public static readonly KJOHOPGPKNM<EDCLCHHFDDJ> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[R2Only]
		public static readonly KJOHOPGPKNM<FIJDIDACNHL> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[R2Only]
		public static readonly KJOHOPGPKNM<EENGOGLBEIG> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly KJOHOPGPKNM<FixedString32Bytes> MeshPresenter_MeshStorageFilename;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[RuntimeOnly]
		public static readonly KJOHOPGPKNM<(long RequestId, int ActorNumber, int ServerTimestamp)> MeshPresenter_MeshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[R2Only]
		[IsBuffer]
		public static readonly KJOHOPGPKNM<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[R2Only]
		public static readonly KJOHOPGPKNM<EKPIPMMBPJG> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[R2Only]
		public static readonly KJOHOPGPKNM<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[R2Only]
		public static readonly KJOHOPGPKNM<CJMMDEBHJMA> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[R2Only]
		public static readonly KJOHOPGPKNM<CPHNALMLPLL> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[IsBuffer]
		[R2Only]
		public static readonly KJOHOPGPKNM<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[R2Only]
		public static readonly KJOHOPGPKNM<DJIAOOPCFNI> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[R2Only]
		public static readonly KJOHOPGPKNM<MCDIDCAJDOP> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[R2Only]
		public static readonly KJOHOPGPKNM<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[R2Only]
		public static readonly KJOHOPGPKNM<GAJCCCIGMFD> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[R2Only]
		public static readonly KJOHOPGPKNM<KPKPCLALEAL> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[R2Only]
		public static readonly KJOHOPGPKNM<BKNAOBLPGDM> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[R2Only]
		public static readonly KJOHOPGPKNM<AIGILGIOKEF> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[R2Only]
		public static readonly KJOHOPGPKNM<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[R2Only]
		public static readonly KJOHOPGPKNM<APBOCLHIEMC> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83EEDB0", Offset = "0x83ED3B0", VA = "0x1883EEDB0")]
		public static bool HOACNJIGNJP(OBBAANPPIBD property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RegisterService(typeof(EBPMJLIGGMF), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : EBPMJLIGGMF, KDLLCPKJBMN, LKJPKMELKMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xEAD290", Offset = "0xEAB890", VA = "0x180EAD290", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF61520", Offset = "0xF5FB20", VA = "0x180F61520", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x106F980", Offset = "0x106DF80", VA = "0x18106F980", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xFFBEC0", Offset = "0xFFA4C0", VA = "0x180FFBEC0", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA99450", Offset = "0xA97A50", VA = "0x180A99450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA9D690", Offset = "0xA9BC90", VA = "0x180A9D690", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA9D640", Offset = "0xA9BC40", VA = "0x180A9D640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public GPIDHGBECCC[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA9D620", Offset = "0xA9BC20", VA = "0x180A9D620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<int, EKCKFGICOJD> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA9D770", Offset = "0xA9BD70", VA = "0x180A9D770", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA9D7C0", Offset = "0xA9BDC0", VA = "0x180A9D7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x320BC80", Offset = "0x320A280", VA = "0x18320BC80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83EEE90", Offset = "0x83ED490", VA = "0x1883EEE90", Slot = "14")]
		public void EPMGJNHIDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83FB540", Offset = "0x83F9B40", VA = "0x1883FB540", Slot = "15")]
		public void PILPLNBAOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83EEEA0", Offset = "0x83ED4A0", VA = "0x1883EEEA0")]
		private void NMBKMICPAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83FDBB0", Offset = "0x83FC1B0", VA = "0x1883FDBB0")]
		public static void KGGPDOIDEKJ(FGNAHOFALKM writer, OBBAANPPIBD property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8400170", Offset = "0x83FE770", VA = "0x188400170")]
		public static void OHDDGLLFDDM(KPACBNMEMMN reader, OBBAANPPIBD property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83FE260", Offset = "0x83FC860", VA = "0x1883FE260")]
		private static void NPNOGBPCPFJ(FGNAHOFALKM writer, OBBAANPPIBD property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83FBBB0", Offset = "0x83FA1B0", VA = "0x1883FBBB0")]
		private static void FJMJAAEBFAK(KPACBNMEMMN reader, OBBAANPPIBD property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DD70", Offset = "0x3F3C370", VA = "0x183F3DD70")]
		internal static void CAELEDFILEL<T>(FGNAHOFALKM writer, KJOHOPGPKNM<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E190", Offset = "0x3F3C790", VA = "0x183F3E190")]
		internal static void KJBCLIOBDIC<T>(KPACBNMEMMN reader, KJOHOPGPKNM<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E060", Offset = "0x3F3C660", VA = "0x183F3E060")]
		internal static void CAELEDFILEL<T>(FGNAHOFALKM writer, KJOHOPGPKNM<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E410", Offset = "0x3F3CA10", VA = "0x183F3E410")]
		internal static void KJBCLIOBDIC<T>(KPACBNMEMMN reader, KJOHOPGPKNM<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DE80", Offset = "0x3F3C480", VA = "0x183F3DE80")]
		internal static void CAELEDFILEL<T>(FGNAHOFALKM writer, KJOHOPGPKNM<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E270", Offset = "0x3F3C870", VA = "0x183F3E270")]
		internal static void KJBCLIOBDIC<T>(KPACBNMEMMN reader, KJOHOPGPKNM<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83FB790", Offset = "0x83F9D90", VA = "0x1883FB790")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83FDFD0", Offset = "0x83FC5D0", VA = "0x1883FDFD0")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83FB910", Offset = "0x83F9F10", VA = "0x1883FB910")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83FDF70", Offset = "0x83FC570", VA = "0x1883FDF70")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83FBAF0", Offset = "0x83FA0F0", VA = "0x1883FBAF0")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83FE200", Offset = "0x83FC800", VA = "0x1883FE200")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83FBB50", Offset = "0x83FA150", VA = "0x1883FBB50")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83FDD40", Offset = "0x83FC340", VA = "0x1883FDD40")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x83FB5D0", Offset = "0x83F9BD0", VA = "0x1883FB5D0")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83FDE50", Offset = "0x83FC450", VA = "0x1883FDE50")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x83FB640", Offset = "0x83F9C40", VA = "0x1883FB640")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83FE080", Offset = "0x83FC680", VA = "0x1883FE080")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x83FB6B0", Offset = "0x83F9CB0", VA = "0x1883FB6B0")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83FDC90", Offset = "0x83FC290", VA = "0x1883FDC90")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83FB720", Offset = "0x83F9D20", VA = "0x1883FB720")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83FDDA0", Offset = "0x83FC3A0", VA = "0x1883FDDA0")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DF40", Offset = "0x3F3C540", VA = "0x183F3DF40")]
		internal static void CAELEDFILEL<T>(FGNAHOFALKM writer, KJOHOPGPKNM<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E340", Offset = "0x3F3C940", VA = "0x183F3E340")]
		internal static void KJBCLIOBDIC<T>(KPACBNMEMMN reader, KJOHOPGPKNM<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83FB9E0", Offset = "0x83F9FE0", VA = "0x1883FB9E0")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83FDBD0", Offset = "0x83FC1D0", VA = "0x1883FDBD0")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83FB800", Offset = "0x83F9E00", VA = "0x1883FB800")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83FE130", Offset = "0x83FC730", VA = "0x1883FE130")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83FB970", Offset = "0x83F9F70", VA = "0x1883FB970")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<EDCLCHHFDDJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x83FDF00", Offset = "0x83FC500", VA = "0x1883FDF00")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<EDCLCHHFDDJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x83DF470", Offset = "0x83DDA70", VA = "0x1883DF470")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, KJOHOPGPKNM<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83DF600", Offset = "0x83DDC00", VA = "0x1883DF600")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, KJOHOPGPKNM<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83DF470", Offset = "0x83DDA70", VA = "0x1883DF470")]
		internal static void CAELEDFILEL(FGNAHOFALKM writer, OBBAANPPIBD prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83DF600", Offset = "0x83DDC00", VA = "0x1883DF600")]
		internal static void KJBCLIOBDIC(KPACBNMEMMN reader, OBBAANPPIBD prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E120", Offset = "0x3F3C720", VA = "0x183F3E120")]
		internal static T HNJDLGDGPFA<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8402DB0", Offset = "0x84013B0", VA = "0x188402DB0")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8402DE0", Offset = "0x84013E0", VA = "0x188402DE0")]
		public void CBPAAEAGBMC(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8402DF0", Offset = "0x84013F0", VA = "0x188402DF0")]
		private void LNMDAGFNCGL(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x44778A0", Offset = "0x4475EA0", VA = "0x1844778A0")]
		private void FIFKNFFHGJB<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4482710", Offset = "0x4480D10", VA = "0x184482710")]
		private void MIADBBHFKBF<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4481D90", Offset = "0x4480390", VA = "0x184481D90")]
		private void JBHPNAMKAMF<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			UpgradeFixDisassociatedAnimationData = 164,
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			UpgradeRotateMeshPresenter180Degrees = 186
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84043E0", Offset = "0x84029E0", VA = "0x1884043E0")]
		public static bool AHEKHGDIHOE(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum FFKPFCAKBJJ
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[CompilerGenerated]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	internal struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(16439110051792907600uL)]
	internal struct PlayerIdBuffer : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[RegisterService(typeof(DDMHNKBBNEL), new string[] { "Registry" })]
internal class AHDKFDNELED : DDMHNKBBNEL
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type KMGAGONKOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8402A30", Offset = "0x8401030", VA = "0x188402A30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Type[] AGIGDDJIOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8402A20", Offset = "0x8401020", VA = "0x188402A20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyDictionary<Type, BGAFDIDDMKP> GNPPEEKBFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8402A10", Offset = "0x8401010", VA = "0x188402A10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8402A90", Offset = "0x8401090", VA = "0x188402A90", Slot = "7")]
	public void PPFFHONJMOH(IComponentDefaultRegistration FCECIHLILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public AHDKFDNELED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class AFKGPBFOKGH : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class COLAGDMNAOK : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string CLGAHBNBCJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8402BB0", Offset = "0x84011B0", VA = "0x188402BB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool HBGKHJAILJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8402AC0", Offset = "0x84010C0", VA = "0x188402AC0")]
		public COLAGDMNAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x14735D0", Offset = "0x1471BD0", VA = "0x1814735D0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 LOLOEONEEKB)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8402AB0", Offset = "0x84010B0", VA = "0x188402AB0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 LOLOEONEEKB, ObjectPrefabType_v1 FKMNCAKIOFK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8402890", Offset = "0x8400E90", VA = "0x188402890")]
	public AFKGPBFOKGH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8402BE0", Offset = "0x84011E0", VA = "0x188402BE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
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
