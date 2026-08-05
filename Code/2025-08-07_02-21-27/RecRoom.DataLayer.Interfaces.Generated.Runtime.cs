using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Bitstream;
using RecRoom.Foundation.Registration;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x897F4D0", Offset = "0x897E0D0", VA = "0x18897F4D0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] XIOCEUOZJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] XIIVHNVBZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset MVEDDDGEAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset MVJKAKABJST;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x269CC00", Offset = "0x269B800", VA = "0x18269CC00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8998BF0", Offset = "0x89977F0", VA = "0x188998BF0")]
		private void SGYKGOYOYBS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8998D40", Offset = "0x8997940", VA = "0x188998D40")]
		private void SHDRDVSMHNB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89988E0", Offset = "0x89974E0", VA = "0x1889988E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8998E90", Offset = "0x8997A90", VA = "0x188998E90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32BytesLegacy<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	public struct RRObjectPrefabData_v2 : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPrefabType_v1 prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(2)]
		public Guid prefabGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2299272917927886785uL)]
	public struct TerrainGenerationData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Field(1)]
		public uint Seed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(2)]
		public float BaseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(3)]
		public float BaseTerrainFeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(4)]
		public TerrainPlayAreaShape_v1 PlayAreaShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(5)]
		public TerrainLayerRoughness_v1 BaseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(6)]
		public TerrainLayerHeightFunction_v1 BaseTerrainHeightFunction;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	public struct AuthoredAIIdData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(2)]
		public FixedString64Bytes AICodeGenId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	public struct ObjectPolicyData_v5 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public readonly struct NetworkProperty : IComparable<NetworkProperty>, IEquatable<NetworkProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly NetworkProperty Invalid;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly NetworkProperty CreateObject;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly NetworkProperty DestroyObject;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly NetworkProperty BeginTransaction;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly NetworkProperty EndTransaction;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly NetworkProperty External;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly int index;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int TBYJWOVXLDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Type VKVIOUJPFWY
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x897FEC0", Offset = "0x897EAC0", VA = "0x18897FEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TIQLVDZUMDM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x897FBA0", Offset = "0x897E7A0", VA = "0x18897FBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int PPXFIKOTQOI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8980460", Offset = "0x897F060", VA = "0x188980460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Type ZLXFIPLBFPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x897F860", Offset = "0x897E460", VA = "0x18897F860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PropertyMetadata GNTEEPETWUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x897FFA0", Offset = "0x897EBA0", VA = "0x18897FFA0")]
			get
			{
				return default(PropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ComponentPropertyMetadata RHXDFHOTMGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x897FCE0", Offset = "0x897E8E0", VA = "0x18897FCE0")]
			get
			{
				return default(ComponentPropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool KKLQSNRTMFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8980140", Offset = "0x897ED40", VA = "0x188980140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int ILKDIWKNBBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x897FB50", Offset = "0x897E750", VA = "0x18897FB50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DSGPRFKYSWL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x897F790", Offset = "0x897E390", VA = "0x18897F790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GSNLGTDBPQH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x897FA80", Offset = "0x897E680", VA = "0x18897FA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
		public NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x897F940", Offset = "0x897E540", VA = "0x18897F940", Slot = "5")]
		public bool Equals(NetworkProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x897F9A0", Offset = "0x897E5A0", VA = "0x18897F9A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8980190", Offset = "0x897ED90", VA = "0x188980190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x556D310", Offset = "0x556BF10", VA = "0x18556D310", Slot = "4")]
		public int CompareTo(NetworkProperty other)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public readonly struct NetworkProperty<T>
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int index;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private NetworkProperty THCFMOKEXXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
		internal NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2495370", Offset = "0x2493F70", VA = "0x182495370")]
		public static implicit operator NetworkProperty(NetworkProperty<T> property)
		{
			return default(NetworkProperty);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6055DF0", Offset = "0x60549F0", VA = "0x186055DF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6056AC0", Offset = "0x60556C0", VA = "0x186056AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public static class OMIRENGLPAN
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly Dictionary<Type, int> DVRYMHRMQDJ;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly (long value, string name, string tooltip)[][] QWQQPBHDOND;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8980640", Offset = "0x897F240", VA = "0x188980640")]
		public static (long, string, string)[] YAZSIARFFXZ(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class VSDMMAOJJNA : LGPVABSKTTN, OGYFRAOOOAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Entity LQOWPMIIAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly DeferredEntityCommandBuffer PMWXGZUIRPJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 FNVHMWLXVDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8998820", Offset = "0x8997420", VA = "0x188998820", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8998770", Offset = "0x8997370", VA = "0x188998770", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FPGZWDKWVMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x898B560", Offset = "0x898A160", VA = "0x18898B560")]
		public VSDMMAOJJNA(Entity a, DeferredEntityCommandBuffer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	public class OWRZKHTFOXC : PCOLOKMULNB, OGYFRAOOOAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Entity LQOWPMIIAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly DeferredEntityCommandBuffer PMWXGZUIRPJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FixedString32Bytes IDOMWQOULJS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x898B280", Offset = "0x8989E80", VA = "0x18898B280", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x898B4B0", Offset = "0x898A0B0", VA = "0x18898B4B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) RDUREFIGLRR
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x898B3F0", Offset = "0x8989FF0", VA = "0x18898B3F0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x898B350", Offset = "0x8989F50", VA = "0x18898B350", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action XZTZVVTFAKE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action JVWPDXBIPHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x898B560", Offset = "0x898A160", VA = "0x18898B560")]
		public OWRZKHTFOXC(Entity a, DeferredEntityCommandBuffer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static Dictionary<Type, NetworkInterfaceInfo> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<Type, NetworkInterfaceInfo> interfaces;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x897BFF0", Offset = "0x897ABF0", VA = "0x18897BFF0")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> CBXSCWGAKES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x897C5F0", Offset = "0x897B1F0", VA = "0x18897C5F0")]
		private Dictionary<Type, NetworkInterfaceInfo> ERBMWTZFFKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x897C040", Offset = "0x897AC40", VA = "0x18897C040")]
		private void CKXNDQCLRGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x897C6A0", Offset = "0x897B2A0", VA = "0x18897C6A0")]
		private readonly void SMIWLVJHFIH(Type a, NetworkInterfaceInfo b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	internal static class LBZWIITMGZF
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static Type[] CKALTSGZCTM;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x897E920", Offset = "0x897D520", VA = "0x18897E920")]
		public static Type[] OWHFRYYBLOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x897C7F0", Offset = "0x897B3F0", VA = "0x18897C7F0")]
		private static void ERBMWTZFFKA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public enum TerrainLayerHeightFunction_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Steep,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Mesa
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public enum TerrainLayerRoughness_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		GentleSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RuggedSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		MediumSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		RiverBed
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v3 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		SuppressCollision = 16384,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public enum TerrainPlayAreaShape_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Circle,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Square
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public class SandboxDeformableShapeDefaults : USYRDJPFQVC, LGPVABSKTTN, OGYFRAOOOAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 FNVHMWLXVDX
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1349660", Offset = "0x1348260", VA = "0x181349660", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x19E7FE0", Offset = "0x19E6BE0", VA = "0x1819E7FE0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type WUOJEOZFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x898B6F0", Offset = "0x898A2F0", VA = "0x18898B6F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FPGZWDKWVMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x898B5B0", Offset = "0x898A1B0", VA = "0x18898B5B0", Slot = "4")]
		public void CopyTo(OGYFRAOOOAS networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public interface OSDRYUIWRPP
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float3 FNVHMWLXVDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public interface ERZJYUILEAN
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		float3 FNVHMWLXVDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public class EFCMWPSVJUY : TCGWGEZENLA, OGYFRAOOOAS, LGPVABSKTTN, OSDRYUIWRPP, ERZJYUILEAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private Entity LQOWPMIIAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private KSCOJTUDNMZ RJBFJQKSZEY;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 HDCWKAVFYXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8976D40", Offset = "0x8975940", VA = "0x188976D40", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8976E20", Offset = "0x8975A20", VA = "0x188976E20", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 LWHGDVUSIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8976FC0", Offset = "0x8975BC0", VA = "0x188976FC0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8976C10", Offset = "0x8975810", VA = "0x188976C10", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 GUHOUSHADXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8976C80", Offset = "0x8975880", VA = "0x188976C80", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8976F00", Offset = "0x8975B00", VA = "0x188976F00", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action DWEEXBRTHUH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8976DB0", Offset = "0x89759B0", VA = "0x188976DB0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8976E90", Offset = "0x8975A90", VA = "0x188976E90", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4663180", Offset = "0x4661D80", VA = "0x184663180")]
		public EFCMWPSVJUY(Entity a, KSCOJTUDNMZ b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Tag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Scale : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public float3 value;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public class MeshPresenterDefaults : USYRDJPFQVC, PCOLOKMULNB, OGYFRAOOOAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private FixedString32Bytes meshStorageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeField]
		private (long RequestId, int ActorNumber, int ServerTimestamp) meshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FixedString32Bytes IDOMWQOULJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4D13990", Offset = "0x4D12590", VA = "0x184D13990", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x897F780", Offset = "0x897E380", VA = "0x18897F780", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) RDUREFIGLRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xFE1360", Offset = "0xFDFF60", VA = "0x180FE1360", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xFE07E0", Offset = "0xFDF3E0", VA = "0x180FE07E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type WUOJEOZFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x897F730", Offset = "0x897E330", VA = "0x18897F730", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action XZTZVVTFAKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action JVWPDXBIPHB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x897F590", Offset = "0x897E190", VA = "0x18897F590", Slot = "4")]
		public void CopyTo(OGYFRAOOOAS networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MeshPresenterDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	public interface ZEUSXNCNZOZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool IHMLZYQSXOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void APFPOBMTEQA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public class IFWKAASXLPA : TCGWGEZENLA, OGYFRAOOOAS, PCOLOKMULNB, ZEUSXNCNZOZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Entity LQOWPMIIAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private KSCOJTUDNMZ RJBFJQKSZEY;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FixedString32Bytes LSGJASDHGBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x897BEA0", Offset = "0x897AAA0", VA = "0x18897BEA0", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x897BC90", Offset = "0x897A890", VA = "0x18897BC90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) VXERORRNPRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x897BD70", Offset = "0x897A970", VA = "0x18897BD70", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x897BA80", Offset = "0x897A680", VA = "0x18897BA80", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool NPSMPRRHWSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x897BDE0", Offset = "0x897A9E0", VA = "0x18897BDE0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action TRILQGIUELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x897BF10", Offset = "0x897AB10", VA = "0x18897BF10", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x897BBB0", Offset = "0x897A7B0", VA = "0x18897BBB0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action IZUUTNSQGTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x897BC20", Offset = "0x897A820", VA = "0x18897BC20", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x897BD00", Offset = "0x897A900", VA = "0x18897BD00", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4663180", Offset = "0x4661D80", VA = "0x184663180")]
		public IFWKAASXLPA(Entity a, KSCOJTUDNMZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x897BAF0", Offset = "0x897A6F0", VA = "0x18897BAF0", Slot = "13")]
		private void BODSFQEMFOM()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_Tag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshStorageFilename : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public FixedString32Bytes value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshGenerationRequest : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public class LCPGBBFQYTO
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly NetworkProperty<uint> YTNSQJUHART;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly NetworkProperty<FixedList32BytesLegacy<int>> VQXYZSCGJOT;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly NetworkProperty<bool> ORLXZKWQOCJ;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> OWBCQVAGUOX;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly NetworkProperty<float3> NCNACKWULCF;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly NetworkProperty<float3> HYDDUCMCLKK;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> VAWMBLWMURK;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly NetworkProperty<float> HTXLZUHEKZW;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> CTDIUEJZGRA;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> OSYPAPLRJHS;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly NetworkProperty<long> OVUNECIZYPK;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> SLIODUYLVHE;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainGenerationLayer> ZKNMICOELQF;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly NetworkProperty<bool> SIGCDDNATSY;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly NetworkProperty<int> LVFNUQBAORJ;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> BFXZEXTENMU;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly NetworkProperty<bool> NTQKTFDDSJI;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly NetworkProperty<float> JRZSBLWWSIU;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupFlags> EHVUFOHYNMY;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> OOMYUCLHEUR;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> SYJWIFCDKWD;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly NetworkProperty<float3> IJOXVFCKTHY;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> RMGOMQAYHVL;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly NetworkProperty<int> IBNAWWHDHUK;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> DQUCQNEOGZU;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> DQJLPEIDGCM;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly NetworkProperty<float> ANMTLJNXOAV;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupStatusFlags> LICOWPDYRIF;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> TGRXQVIMECU;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly NetworkProperty<uint> OBZVONTLEUU;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly NetworkProperty<float> VVVWFSGVKNU;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly NetworkProperty<float> EFGFURYWXUJ;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly NetworkProperty<TerrainPlayAreaShape> XCEJBLDZHWD;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerRoughness> VYJRSZNONDP;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerHeightFunction> AGDAHLZZJUG;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly NetworkProperty<float> ULVNNHBYKMP;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainCustomMaterialLayer> WMJXRLIPOTU;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<byte> MVWPYEGAKRC;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly NetworkProperty<float3> FCMHGMLEBHY;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly NetworkProperty<EShapeType> HOUOKBYLICA;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> RPMYSZSXCYX;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly NetworkProperty<PrimitiveShapeType> EVXNKSTGEBX;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> ILYPHTSBFTW;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly NetworkProperty<bool> LBNYUQYBOFK;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> KNMEKCCAYCE;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> FECKYUXNOCP;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> LUTPUCDYGQO;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly NetworkProperty<float3> VXRIHAEOAYP;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> PEXCEJYONYQ;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly NetworkProperty<uint> ASKXMFDHFCC;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly NetworkProperty<uint> ZTYZFHNFLGD;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly NetworkProperty<bool> MDSASDZDMZY;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly NetworkProperty<bool> ONINZJCOZJT;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> KCBZIOKCYKE;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[R2Only]
		public static readonly NetworkProperty<FixedString32Bytes> QGLKUQRXTZF;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[R2Only]
		public static readonly NetworkProperty<NavMeshGenerationMode> TOADVGATULD;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> TBPXTZNNTTF;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[R2Only]
		public static readonly NetworkProperty<bool> SBQHWHVBQNN;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[R2Only]
		public static readonly NetworkProperty<ShapeConfigFlags> YZLPKXQRCZK;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> KHZZZPTFFNY;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> OHPTZWBSLCD;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[R2Only]
		public static readonly NetworkProperty<uint> LHBTCBATMOK;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[R2Only]
		public static readonly NetworkProperty<int> QSERFRSUWMQ;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> JHZYJLGHUKE;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ConvertVector3ToFloat3))]
		public static readonly NetworkProperty<float3> IFOCHYDYKIL;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[R2Only]
		public static readonly NetworkProperty<bool> CNDDNREIIZU;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[R2Only]
		public static readonly NetworkProperty<float> NHSLRKYZWYE;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> NKSJNUNMCRX;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[R2Only]
		public static readonly NetworkProperty<float3> JSMRKHBZVYY;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> TUVMXIFLFSW;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> OLNNTHARKRC;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> YSMOQQRXUKK;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> BNGEOOFMQQO;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[R2Only]
		public static readonly NetworkProperty<float> KJILEPDDJTY;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> HPPESUBNZMY;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[R2Only]
		public static readonly NetworkProperty<RenderableMaterial> CUWKXXYVSUM;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[R2Only]
		public static readonly NetworkProperty<float> TQCMWPAHPVO;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[R2Only]
		public static readonly NetworkProperty<float3> BSOWWWLHDVL;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[R2Only]
		public static readonly NetworkProperty<CollisionLayerEnum> BVYFUDBOVIG;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> PKOYSMRCZZC;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> GLAKRKXJRCA;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[R2Only]
		public static readonly NetworkProperty<ElementSnapPointRuntimeFlags> WFJJVXOPGHO;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[R2Only]
		public static readonly NetworkProperty<GrabbableMode> VVCTTRMWTZE;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly NetworkProperty<FixedString32Bytes> ZJLWRIQRPII;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[RuntimeOnly]
		public static readonly NetworkProperty<(long RequestId, int ActorNumber, int ServerTimestamp)> FEXMMUXQGPF;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> QSVOMHYCRKY;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[R2Only]
		public static readonly NetworkProperty<SplineParameters> XHAITZDGUBQ;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[R2Only]
		public static readonly NetworkProperty<int> XYWCALFFLHN;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[R2Only]
		public static readonly NetworkProperty<TransformHint> WHXBTUSEISI;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[R2Only]
		public static readonly NetworkProperty<TransformPriority> SIBGESOEKHP;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> YCWUAPDFPNH;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[R2Only]
		public static readonly NetworkProperty<PhysicsModelEnumFlags> NAUMMETAIDU;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[R2Only]
		public static readonly NetworkProperty<CollisionMode> KEHBJVTIGXE;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> EGIASBCQFAB;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[R2Only]
		public static readonly NetworkProperty<float> QGCHTBMRTOI;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[R2Only]
		public static readonly NetworkProperty<ScaleRestriction> FUWLBSAZEBD;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyUserConfigurableFlags> LINCEBBGXPI;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[R2Only]
		public static readonly NetworkProperty<CircuitsTransformBehavior> RVNXBJSFYGV;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyEnumFlags> RYJRRKUPVWY;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> XGMHGITTZVQ;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[R2Only]
		public static readonly NetworkProperty<ReferenceGroupKind> EBONHSYXYSS;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	public static class KAZRCKQFZJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x897C720", Offset = "0x897B320", VA = "0x18897C720")]
		public static bool FEPKELWSYYT(NetworkProperty a, bool b, bool c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RegisterService(typeof(TPXBEQYFHYE), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class VIULCEEHKUX : TPXBEQYFHYE, MOWQOGDYZLC, BMZVOVVGZNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private NativeArray<int> SNHUPIJPHNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private NativeArray<int> PUZLPUDEHSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private NativeBitArray UOPTQKQYLUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private NativeBitArray BFNCRZWTEJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private NativeBitArray ZURSGABOPIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private NativeParallelHashSet<int> YRYOEQPDXRA;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NativeArray<int> CMGTEXNKIMT
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NativeArray<int> ZXCALBGONCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xF343E0", Offset = "0xF32FE0", VA = "0x180F343E0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeBitArray NZPPXZISFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeBitArray YAXVVQTDVKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeParallelHashSet<int> ALSNEIRPIJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xF343B0", Offset = "0xF32FB0", VA = "0x180F343B0", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Type[] KPEGALBGRIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB131B0", Offset = "0xB11DB0", VA = "0x180B131B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Type[] FUHNCEKBWDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB14940", Offset = "0xB13540", VA = "0x180B14940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public PropertyMetadata[] GNTEEPETWUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB13B50", Offset = "0xB12750", VA = "0x180B13B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Dictionary<int, ComponentPropertyMetadata> AAMBPWUKHHF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xB13330", Offset = "0xB11F30", VA = "0x180B13330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int TXICYPISMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x898BB20", Offset = "0x898A720", VA = "0x18898BB20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x898BB10", Offset = "0x898A710", VA = "0x18898BB10", Slot = "14")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x898BB40", Offset = "0x898A740", VA = "0x18898BB40", Slot = "15")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x898BBD0", Offset = "0x898A7D0", VA = "0x18898BBD0")]
		private void UBHUPJXZZRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public VIULCEEHKUX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	public static class HIBWNLOHVHS
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8977880", Offset = "0x8976480", VA = "0x188977880")]
		public static void MDEGGYLJVSM(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8977860", Offset = "0x8976460", VA = "0x188977860")]
		public static void LRCBJSSONKB(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8979D20", Offset = "0x8978920", VA = "0x188979D20")]
		private static void ZXEVZJQINOV(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89778A0", Offset = "0x89764A0", VA = "0x1889778A0")]
		private static void SOGZAOLULIA(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0570", Offset = "0x3BCF170", VA = "0x183BD0570")]
		internal static void Serialize<T>(FastBufferWriter writer, NetworkProperty<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFCB0", Offset = "0x3BCE8B0", VA = "0x183BCFCB0")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0A00", Offset = "0x3BCF600", VA = "0x183BD0A00")]
		internal static void Serialize<T>(FastBufferWriter writer, NetworkProperty<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0100", Offset = "0x3BCED00", VA = "0x183BD0100")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0930", Offset = "0x3BCF530", VA = "0x183BD0930")]
		internal static void Serialize<T>(FastBufferWriter writer, NetworkProperty<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0030", Offset = "0x3BCEC30", VA = "0x183BD0030")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8979980", Offset = "0x8978580", VA = "0x188979980")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8977570", Offset = "0x8976170", VA = "0x188977570")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8979C80", Offset = "0x8978880", VA = "0x188979C80")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89772D0", Offset = "0x8975ED0", VA = "0x1889772D0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8979610", Offset = "0x8978210", VA = "0x188979610")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8977150", Offset = "0x8975D50", VA = "0x188977150")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8979920", Offset = "0x8978520", VA = "0x188979920")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8977270", Offset = "0x8975E70", VA = "0x188977270")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89799F0", Offset = "0x89785F0", VA = "0x1889799F0")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8977740", Offset = "0x8976340", VA = "0x188977740")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8979A50", Offset = "0x8978650", VA = "0x188979A50")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x89777A0", Offset = "0x89763A0", VA = "0x1889777A0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8979840", Offset = "0x8978440", VA = "0x188979840")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89770A0", Offset = "0x8975CA0", VA = "0x1889770A0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x89795A0", Offset = "0x89781A0", VA = "0x1889795A0")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8977690", Offset = "0x8976290", VA = "0x188977690")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89797D0", Offset = "0x89783D0", VA = "0x1889797D0")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x89774C0", Offset = "0x89760C0", VA = "0x1889774C0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8979AB0", Offset = "0x89786B0", VA = "0x188979AB0")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8977410", Offset = "0x8976010", VA = "0x188977410")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8979B20", Offset = "0x8978720", VA = "0x188979B20")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x89771B0", Offset = "0x8975DB0", VA = "0x1889771B0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8979670", Offset = "0x8978270", VA = "0x188979670")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8977340", Offset = "0x8975F40", VA = "0x188977340")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x89798B0", Offset = "0x89784B0", VA = "0x1889798B0")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<FractionalIndex> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8977620", Offset = "0x8976220", VA = "0x188977620")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FractionalIndex> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8976B30", Offset = "0x8975730", VA = "0x188976B30")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8976790", Offset = "0x8975390", VA = "0x188976790")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8976B30", Offset = "0x8975730", VA = "0x188976B30")]
		internal static void Serialize(FastBufferWriter writer, NetworkProperty prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8976790", Offset = "0x8975390", VA = "0x188976790")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BD01D0", Offset = "0x3BCEDD0", VA = "0x183BD01D0")]
		internal static T KPNMRQHPNTA<T>(this NativeArray<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8977800", Offset = "0x8976400", VA = "0x188977800")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		internal static void GLYMURJNGTU(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x89990B0", Offset = "0x8997CB0", VA = "0x1889990B0")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x89990E0", Offset = "0x8997CE0", VA = "0x1889990E0")]
		public void ERBMWTZFFKA(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x89990F0", Offset = "0x8997CF0", VA = "0x1889990F0")]
		private void ZBIUOLLXJVD(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x419E1C0", Offset = "0x419CDC0", VA = "0x18419E1C0")]
		private void LCMGSCNWMXC<T>(IComponentDefaultRegistration a, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x419DB40", Offset = "0x419C740", VA = "0x18419DB40")]
		private void DDGSKYFBWND<T>(IComponentDefaultRegistration a, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x419DD40", Offset = "0x419C940", VA = "0x18419DD40")]
		private void IDPVJINWCAP<T>(IComponentDefaultRegistration a) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	public static class GUYUCBYYNKK
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			UpgradeFixDisassociatedAnimationData = 164
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8999010", Offset = "0x8997C10", VA = "0x188999010")]
		public static bool ONJHSCURTJI(this SerializedDataLayerVersionData a, TaggedVersions b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum ReservedPropertyIds
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		CreateObject = -1,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		DestroyObject = -2,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		BeginTransaction = -3,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		EndTransaction = -4,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		External = -5
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 2, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	internal struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int last;
	}
}
namespace RecRoom.DataLayer.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RegisterService(typeof(RMGTTGLSXRU), new string[] { "Registry" })]
	internal class QHEJSOOUAQF : RMGTTGLSXRU
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Type ENDKSDFEMQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8999020", Offset = "0x8997C20", VA = "0x188999020", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Type[] OYKJMIHYLQV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x89990A0", Offset = "0x8997CA0", VA = "0x1889990A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IReadOnlyDictionary<Type, NetworkInterfaceInfo> ISVMAJCBIGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8999090", Offset = "0x8997C90", VA = "0x188999090", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8999070", Offset = "0x8997C70", VA = "0x188999070", Slot = "7")]
		public void NUBSQIMALDA(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public QHEJSOOUAQF()
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
