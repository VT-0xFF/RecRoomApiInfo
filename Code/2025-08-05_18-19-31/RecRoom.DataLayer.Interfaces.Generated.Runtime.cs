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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82359C0", Offset = "0x8234DC0", VA = "0x1882359C0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2353DC0", Offset = "0x23531C0", VA = "0x182353DC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x824BDB0", Offset = "0x824B1B0", VA = "0x18824BDB0")]
		private void GBFKFENBIAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x824BF20", Offset = "0x824B320", VA = "0x18824BF20")]
		private void NKKCCHCKNGM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x824C090", Offset = "0x824B490", VA = "0x18824C090", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x824C3C0", Offset = "0x824B7C0", VA = "0x18824C3C0")]
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
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[CompilerGenerated]
	public struct SerializedDataLayerVersionData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct RRObjectPrefabData_v1 : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPrefabType_v1 prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
public readonly struct OJEHFCOLBPA : IComparable<OJEHFCOLBPA>, IEquatable<OJEHFCOLBPA>
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OJEHFCOLBPA FEIBEMCCPGP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly OJEHFCOLBPA EBKBELDCCHC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly OJEHFCOLBPA CKAKGCKPMHO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly OJEHFCOLBPA BPEHLEACDJE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly OJEHFCOLBPA INJINELOEME;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly OJEHFCOLBPA CAMHEEJIDPD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly int NOEININIMIL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type NBFFAIKCBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x824A230", Offset = "0x8249630", VA = "0x18824A230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JDOCBDPHMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x824A360", Offset = "0x8249760", VA = "0x18824A360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GDGDNNAMJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x824A0F0", Offset = "0x82494F0", VA = "0x18824A0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type PIPGKGJFAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x824A9B0", Offset = "0x8249DB0", VA = "0x18824A9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GJEKNDHPING KGIBKLCCCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8249E40", Offset = "0x8249240", VA = "0x188249E40")]
		get
		{
			return default(GJEKNDHPING);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LBMPNBKPFKA DPJGMNIOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x824A4A0", Offset = "0x82498A0", VA = "0x18824A4A0")]
		get
		{
			return default(LBMPNBKPFKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JIDHOCGLKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x824A6A0", Offset = "0x8249AA0", VA = "0x18824A6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HLDJOGFAGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x824A310", Offset = "0x8249710", VA = "0x18824A310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FEHEDEDBMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x824A6F0", Offset = "0x8249AF0", VA = "0x18824A6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BFAFOPEGMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x824A850", Offset = "0x8249C50", VA = "0x18824A850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
	public OJEHFCOLBPA(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x824A070", Offset = "0x8249470", VA = "0x18824A070", Slot = "5")]
	public bool Equals(OJEHFCOLBPA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8249FC0", Offset = "0x82493C0", VA = "0x188249FC0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x824AA90", Offset = "0x8249E90", VA = "0x18824AA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x530D380", Offset = "0x530C780", VA = "0x18530D380", Slot = "4")]
	public int CompareTo(OJEHFCOLBPA LHDOHAKINKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct EBBFPIBPIGA<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly int NOEININIMIL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private OJEHFCOLBPA LCJHJFJHHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		get
		{
			return default(OJEHFCOLBPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
	internal EBBFPIBPIGA(int NOEININIMIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2127560", Offset = "0x2126960", VA = "0x182127560")]
	public static OJEHFCOLBPA GKKMDDPCKIG(EBBFPIBPIGA<T> NBOAFDFPIEI)
	{
		return default(OJEHFCOLBPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49B1480", Offset = "0x49B0880", VA = "0x1849B1480", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x49B2960", Offset = "0x49B1D60", VA = "0x1849B2960", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8229BC0", Offset = "0x8228FC0", VA = "0x188229BC0")]
		public static (long, string, string)[] LJOIMMMMCCG(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : JHOKCELOIPE, DCDKAIBLHNM
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
			[Cpp2IlInjected.Address(RVA = "0x8235160", Offset = "0x8234560", VA = "0x188235160", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82350B0", Offset = "0x82344B0", VA = "0x1882350B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8235060", Offset = "0x8234460", VA = "0x188235060")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class DECBMeshPresenterNetworkData : JBLCKMMHLIG, DCDKAIBLHNM
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
			[Cpp2IlInjected.Address(RVA = "0x8234D80", Offset = "0x8234180", VA = "0x188234D80", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8234FB0", Offset = "0x82343B0", VA = "0x188234FB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8234EF0", Offset = "0x82342F0", VA = "0x188234EF0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8234E50", Offset = "0x8234250", VA = "0x188234E50", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8235060", Offset = "0x8234460", VA = "0x188235060")]
		public DECBMeshPresenterNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static Dictionary<Type, FELCOLCEDEO> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<Type, FELCOLCEDEO> interfaces;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8235970", Offset = "0x8234D70", VA = "0x188235970")]
		public static IReadOnlyDictionary<Type, FELCOLCEDEO> CBHPODJGKKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8235220", Offset = "0x8234620", VA = "0x188235220")]
		private Dictionary<Type, FELCOLCEDEO> AAGBOPIEMBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8235360", Offset = "0x8234760", VA = "0x188235360")]
		private void BFCFKBKHGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82352E0", Offset = "0x82346E0", VA = "0x1882352E0")]
		private readonly void BFAMJKAPONF(Type interfaceType, FELCOLCEDEO implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x8237E50", Offset = "0x8237250", VA = "0x188237E50")]
		public static Type[] AIHMPMAAEPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8235CA0", Offset = "0x82350A0", VA = "0x188235CA0")]
		private static void AAGBOPIEMBE()
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
	public class SandboxDeformableShapeDefaults : MLCHICODICF, JHOKCELOIPE, DCDKAIBLHNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1200690", Offset = "0x11FFA90", VA = "0x181200690", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x187A4C0", Offset = "0x18798C0", VA = "0x18187A4C0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x824B970", Offset = "0x824AD70", VA = "0x18824B970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x824B830", Offset = "0x824AC30", VA = "0x18824B830", Slot = "4")]
		public void AHINEHNEJJM(DCDKAIBLHNM networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
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
	public class R2SandboxDeformableShapeNetworkData : PPMBIINKLOC, DCDKAIBLHNM, JHOKCELOIPE, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private OEHCPCJJKEN service;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x824B410", Offset = "0x824A810", VA = "0x18824B410", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x824B750", Offset = "0x824AB50", VA = "0x18824B750", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x824B3A0", Offset = "0x824A7A0", VA = "0x18824B3A0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x824B540", Offset = "0x824A940", VA = "0x18824B540", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x824B620", Offset = "0x824AA20", VA = "0x18824B620", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x824B480", Offset = "0x824A880", VA = "0x18824B480", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x824B5B0", Offset = "0x824A9B0", VA = "0x18824B5B0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x824B6E0", Offset = "0x824AAE0", VA = "0x18824B6E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9E00", Offset = "0x4EF9200", VA = "0x184EF9E00")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, OEHCPCJJKEN networkDataService)
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
	public class MeshPresenterDefaults : MLCHICODICF, JBLCKMMHLIG, DCDKAIBLHNM
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
			[Cpp2IlInjected.Address(RVA = "0x4A56F40", Offset = "0x4A56340", VA = "0x184A56F40", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8235C90", Offset = "0x8235090", VA = "0x188235C90", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xF1DA50", Offset = "0xF1CE50", VA = "0x180F1DA50", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8235C30", Offset = "0x8235030", VA = "0x188235C30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8235A90", Offset = "0x8234E90", VA = "0x188235A90", Slot = "4")]
		public void AHINEHNEJJM(DCDKAIBLHNM networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ILOJIJELPNF();
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public class R2MeshPresenterNetworkData : PPMBIINKLOC, DCDKAIBLHNM, JBLCKMMHLIG, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private OEHCPCJJKEN service;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x824AF60", Offset = "0x824A360", VA = "0x18824AF60", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x824B0B0", Offset = "0x824A4B0", VA = "0x18824B0B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x824AFD0", Offset = "0x824A3D0", VA = "0x18824AFD0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x824B190", Offset = "0x824A590", VA = "0x18824B190", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x824AE30", Offset = "0x824A230", VA = "0x18824AE30", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x824B200", Offset = "0x824A600", VA = "0x18824B200", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x824B040", Offset = "0x824A440", VA = "0x18824B040", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x824AEF0", Offset = "0x824A2F0", VA = "0x18824AEF0", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x824B120", Offset = "0x824A520", VA = "0x18824B120", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9E00", Offset = "0x4EF9200", VA = "0x184EF9E00")]
		public R2MeshPresenterNetworkData(Entity entity, OEHCPCJJKEN networkDataService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x824B270", Offset = "0x824A670", VA = "0x18824B270", Slot = "13")]
		private void NDOCNJEPFGN()
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
		public static readonly EBBFPIBPIGA<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly EBBFPIBPIGA<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[IsBuffer]
		[R2Only]
		public static readonly EBBFPIBPIGA<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly EBBFPIBPIGA<JHJGBLLNBFI> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		[IsBuffer]
		public static readonly EBBFPIBPIGA<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly EBBFPIBPIGA<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		[IsBuffer]
		public static readonly EBBFPIBPIGA<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[IsBuffer]
		[R2Only]
		public static readonly EBBFPIBPIGA<TerrainGenerationLayer> TerrainLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> OwnedByTerrain_isOwnedByTerrain;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly EBBFPIBPIGA<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly EBBFPIBPIGA<KGMJKHNNELD> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly EBBFPIBPIGA<OJNFHONPFAP> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly EBBFPIBPIGA<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly EBBFPIBPIGA<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly EBBFPIBPIGA<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly EBBFPIBPIGA<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LPDGDMDBJPF> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly EBBFPIBPIGA<uint> TerrainGeneration_Seed;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> TerrainGeneration_BaseTerrainHeight;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> TerrainGeneration_BaseTerrainFeatureScale;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly EBBFPIBPIGA<PBFAHNBOMEH> TerrainGeneration_PlayAreaShape;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly EBBFPIBPIGA<GLJNFGKKOAM> TerrainGeneration_BaseTerrainRoughness;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly EBBFPIBPIGA<CGJIJKGNEMN> TerrainGeneration_BaseTerrainHeightFunction;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> TerrainGeneration_PlayAreaOpacity;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[IsBuffer]
		[R2Only]
		public static readonly EBBFPIBPIGA<GCFFMGKDNLP> TerrainMaterialLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		[IsBuffer]
		public static readonly EBBFPIBPIGA<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly EBBFPIBPIGA<ALLEDPCNAAI> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly EBBFPIBPIGA<BFBNMLCCBFM> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly EBBFPIBPIGA<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly EBBFPIBPIGA<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly EBBFPIBPIGA<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> TerrainWater_WaterHeight;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> TerrainWater_WaterChop;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> TerrainWater_WaterAlpha;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly EBBFPIBPIGA<GEGMIDKLLFN> TerrainWater_WaterColor;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly EBBFPIBPIGA<GEGMIDKLLFN> TerrainWater_DeepColor;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> TerrainWater_EmissiveStrength;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[R2Only]
		public static readonly EBBFPIBPIGA<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[R2Only]
		public static readonly EBBFPIBPIGA<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[R2Only]
		public static readonly EBBFPIBPIGA<AGIDIJAMCNH> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[R2Only]
		public static readonly EBBFPIBPIGA<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[R2Only]
		public static readonly EBBFPIBPIGA<HNPEOKBOCPL> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[R2Only]
		public static readonly EBBFPIBPIGA<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[R2Only]
		public static readonly EBBFPIBPIGA<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(GHOGGHFCKAI))]
		public static readonly EBBFPIBPIGA<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[R2Only]
		public static readonly EBBFPIBPIGA<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[R2Only]
		public static readonly EBBFPIBPIGA<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[R2Only]
		public static readonly EBBFPIBPIGA<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[R2Only]
		public static readonly EBBFPIBPIGA<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[R2Only]
		public static readonly EBBFPIBPIGA<JHJGBLLNBFI> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[R2Only]
		public static readonly EBBFPIBPIGA<GEGMIDKLLFN> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[R2Only]
		public static readonly EBBFPIBPIGA<HPLJMLNNILP> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[R2Only]
		public static readonly EBBFPIBPIGA<CGPPANCJEFA> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[R2Only]
		public static readonly EBBFPIBPIGA<OJNFHONPFAP> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[R2Only]
		public static readonly EBBFPIBPIGA<CAKFJLPKMGI> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[R2Only]
		public static readonly EBBFPIBPIGA<EBPMCOGAHLH> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly EBBFPIBPIGA<FixedString32Bytes> MeshPresenter_MeshStorageFilename;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[RuntimeOnly]
		public static readonly EBBFPIBPIGA<(long RequestId, int ActorNumber, int ServerTimestamp)> MeshPresenter_MeshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[R2Only]
		[IsBuffer]
		public static readonly EBBFPIBPIGA<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[R2Only]
		public static readonly EBBFPIBPIGA<BFGADLCEFPF> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[R2Only]
		public static readonly EBBFPIBPIGA<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[R2Only]
		public static readonly EBBFPIBPIGA<IMPKOJJLIDN> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[R2Only]
		public static readonly EBBFPIBPIGA<IFFBGKJLFIG> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[R2Only]
		[IsBuffer]
		public static readonly EBBFPIBPIGA<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[R2Only]
		public static readonly EBBFPIBPIGA<BNADNEMKMMC> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[R2Only]
		public static readonly EBBFPIBPIGA<OPHMAHEJLBB> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[R2Only]
		public static readonly EBBFPIBPIGA<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[R2Only]
		public static readonly EBBFPIBPIGA<ICHHKDNLLPL> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[R2Only]
		public static readonly EBBFPIBPIGA<OEFDIDBPHAO> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[R2Only]
		public static readonly EBBFPIBPIGA<OBOGCMLDHKJ> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[R2Only]
		public static readonly EBBFPIBPIGA<JFKBIGJMKEO> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[R2Only]
		public static readonly EBBFPIBPIGA<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[R2Only]
		public static readonly EBBFPIBPIGA<GDCPGHBNPPK> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8238A90", Offset = "0x8237E90", VA = "0x188238A90")]
		public static bool PABGLOMMJEI(OJEHFCOLBPA property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	[RegisterService(typeof(NFLDMACMGCI), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : NFLDMACMGCI, OJJHPFNNLMN, LLJNOAGPADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xE6C740", Offset = "0xE6BB40", VA = "0x180E6C740", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x102B400", Offset = "0x102A800", VA = "0x18102B400", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xFBB650", Offset = "0xFBAA50", VA = "0x180FBB650", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA70170", Offset = "0xA6F570", VA = "0x180A70170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA7C8A0", Offset = "0xA7BCA0", VA = "0x180A7C8A0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9A0", Offset = "0xA7BDA0", VA = "0x180A7C9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GJEKNDHPING[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Dictionary<int, LBMPNBKPFKA> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA7C810", Offset = "0xA7BC10", VA = "0x180A7C810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3199880", Offset = "0x3198C80", VA = "0x183199880", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8238C00", Offset = "0x8238000", VA = "0x188238C00", Slot = "14")]
		public void NCJJIBEJLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8238B70", Offset = "0x8237F70", VA = "0x188238B70", Slot = "15")]
		public void IFLOIAOAMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8238C10", Offset = "0x8238010", VA = "0x188238C10")]
		private void NEOOGINDBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8247F10", Offset = "0x8247310", VA = "0x188247F10")]
		public static void GFAFEBCCOFD(GEIGGPAFKKG writer, OJEHFCOLBPA property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8247F30", Offset = "0x8247330", VA = "0x188247F30")]
		public static void LFOOGJKEMCJ(KCIOLIJNIGH reader, OJEHFCOLBPA property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82451E0", Offset = "0x82445E0", VA = "0x1882451E0")]
		private static void BAHKLPKOFEO(GEIGGPAFKKG writer, OJEHFCOLBPA property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8247F50", Offset = "0x8247350", VA = "0x188247F50")]
		private static void MFLCAIJJCOJ(KCIOLIJNIGH reader, OJEHFCOLBPA property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3E832F0", Offset = "0x3E826F0", VA = "0x183E832F0")]
		internal static void COFPFOKABJF<T>(GEIGGPAFKKG writer, EBBFPIBPIGA<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3E836A0", Offset = "0x3E82AA0", VA = "0x183E836A0")]
		internal static void DGFNGGGAAON<T>(KCIOLIJNIGH reader, EBBFPIBPIGA<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3E835E0", Offset = "0x3E829E0", VA = "0x183E835E0")]
		internal static void COFPFOKABJF<T>(GEIGGPAFKKG writer, EBBFPIBPIGA<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3E83920", Offset = "0x3E82D20", VA = "0x183E83920")]
		internal static void DGFNGGGAAON<T>(KCIOLIJNIGH reader, EBBFPIBPIGA<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3E83400", Offset = "0x3E82800", VA = "0x183E83400")]
		internal static void COFPFOKABJF<T>(GEIGGPAFKKG writer, EBBFPIBPIGA<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E83780", Offset = "0x3E82B80", VA = "0x183E83780")]
		internal static void DGFNGGGAAON<T>(KCIOLIJNIGH reader, EBBFPIBPIGA<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8247570", Offset = "0x8246970", VA = "0x188247570")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8247BE0", Offset = "0x8246FE0", VA = "0x188247BE0")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8247640", Offset = "0x8246A40", VA = "0x188247640")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8247AC0", Offset = "0x8246EC0", VA = "0x188247AC0")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x82471B0", Offset = "0x82465B0", VA = "0x1882471B0")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8247EB0", Offset = "0x82472B0", VA = "0x188247EB0")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x82475E0", Offset = "0x82469E0", VA = "0x1882475E0")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8247C90", Offset = "0x8247090", VA = "0x188247C90")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8247750", Offset = "0x8246B50", VA = "0x188247750")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x82477B0", Offset = "0x8246BB0", VA = "0x1882477B0")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8247210", Offset = "0x8246610", VA = "0x188247210")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8247CF0", Offset = "0x82470F0", VA = "0x188247CF0")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82476E0", Offset = "0x8246AE0", VA = "0x1882476E0")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8247D50", Offset = "0x8247150", VA = "0x188247D50")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82470D0", Offset = "0x82464D0", VA = "0x1882470D0")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8247B30", Offset = "0x8246F30", VA = "0x188247B30")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8247490", Offset = "0x8246890", VA = "0x188247490")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8247E00", Offset = "0x8247200", VA = "0x188247E00")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8247500", Offset = "0x8246900", VA = "0x188247500")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8247880", Offset = "0x8246C80", VA = "0x188247880")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3E834C0", Offset = "0x3E828C0", VA = "0x183E834C0")]
		internal static void COFPFOKABJF<T>(GEIGGPAFKKG writer, EBBFPIBPIGA<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E83850", Offset = "0x3E82C50", VA = "0x183E83850")]
		internal static void DGFNGGGAAON<T>(KCIOLIJNIGH reader, EBBFPIBPIGA<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8247380", Offset = "0x8246780", VA = "0x188247380")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8247A00", Offset = "0x8246E00", VA = "0x188247A00")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8247270", Offset = "0x8246670", VA = "0x188247270")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8247930", Offset = "0x8246D30", VA = "0x188247930")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8247140", Offset = "0x8246540", VA = "0x188247140")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<OJNFHONPFAP> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8247810", Offset = "0x8246C10", VA = "0x188247810")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<OJNFHONPFAP> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82295D0", Offset = "0x82289D0", VA = "0x1882295D0")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, EBBFPIBPIGA<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8229A30", Offset = "0x8228E30", VA = "0x188229A30")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, EBBFPIBPIGA<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x82295D0", Offset = "0x82289D0", VA = "0x1882295D0")]
		internal static void COFPFOKABJF(GEIGGPAFKKG writer, OJEHFCOLBPA prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8229A30", Offset = "0x8228E30", VA = "0x188229A30")]
		internal static void DGFNGGGAAON(KCIOLIJNIGH reader, OJEHFCOLBPA prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E839F0", Offset = "0x3E82DF0", VA = "0x183E839F0")]
		internal static T MMOAABBENAA<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x824CB10", Offset = "0x824BF10", VA = "0x18824CB10")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x824CB40", Offset = "0x824BF40", VA = "0x18824CB40")]
		public void AAGBOPIEMBE(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x824CB50", Offset = "0x824BF50", VA = "0x18824CB50")]
		private void OPKDADJJPDI(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x43F5400", Offset = "0x43F4800", VA = "0x1843F5400")]
		private void HAMBPNKGGIN<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x43F5090", Offset = "0x43F4490", VA = "0x1843F5090")]
		private void AALIOAADECO<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x43FF740", Offset = "0x43FEB40", VA = "0x1843FF740")]
		private void PKOHNFGKBAF<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			UpgradeFixDisassociatedAnimationData = 164
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x824E120", Offset = "0x824D520", VA = "0x18824E120")]
		public static bool GFDGGJLIKGC(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum FAPPOPDFKFJ
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
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
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[CompilerGenerated]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[RegisterService(typeof(CAAJOHMINKF), new string[] { "Registry" })]
internal class FLEOGBFHDCI : CAAJOHMINKF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Type HOPKKIPHNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x824C620", Offset = "0x824BA20", VA = "0x18824C620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Type[] AIKKOFLPHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x824C610", Offset = "0x824BA10", VA = "0x18824C610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyDictionary<Type, FELCOLCEDEO> JECNGHFAFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x824C680", Offset = "0x824BA80", VA = "0x18824C680", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x824C5F0", Offset = "0x824B9F0", VA = "0x18824C5F0", Slot = "7")]
	public void DMBGMEAMGJD(IComponentDefaultRegistration DKHCKEIFPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FLEOGBFHDCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class HCIOFODHDKD : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class GNGBEEJLCKL : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x824C790", Offset = "0x824BB90", VA = "0x18824C790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x824C6A0", Offset = "0x824BAA0", VA = "0x18824C6A0")]
		public GNGBEEJLCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x142C4C0", Offset = "0x142B8C0", VA = "0x18142C4C0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 MNCIANLLPKI)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x824C690", Offset = "0x824BA90", VA = "0x18824C690", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 MNCIANLLPKI, ObjectPrefabType_v1 CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x824C7C0", Offset = "0x824BBC0", VA = "0x18824C7C0")]
	public HCIOFODHDKD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x824C940", Offset = "0x824BD40", VA = "0x18824C940")]
		[UnityEngine.Scripting.Preserve]
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
