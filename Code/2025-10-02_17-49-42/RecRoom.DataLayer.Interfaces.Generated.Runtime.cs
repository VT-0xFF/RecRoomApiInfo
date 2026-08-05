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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847D7B0", Offset = "0x847C1B0", VA = "0x18847D7B0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2402EF0", Offset = "0x24018F0", VA = "0x182402EF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8492D60", Offset = "0x8491760", VA = "0x188492D60")]
		private void OFEEGALAMNF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8492BF0", Offset = "0x84915F0", VA = "0x188492BF0")]
		private void HGLHGGKJMAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8492ED0", Offset = "0x84918D0", VA = "0x188492ED0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8493210", Offset = "0x8491C10", VA = "0x188493210")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2299272917927886785uL)]
	[CompilerGenerated]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15805686756326706819uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct TerrainWaterData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(2)]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(3)]
		public float WaterAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(4)]
		public RenderableColor_v1 WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(5)]
		public RenderableColor_v1 DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(6)]
		public float EmissiveStrength;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15802817030977643784uL)]
	[CompilerGenerated]
	public struct TerrainWaterData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(1)]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(2)]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(3)]
		public float WaterAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[RecRoom.DataLayer.Field(4)]
		public RenderableColor_v1 WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(5)]
		public RenderableColor_v1 DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(6)]
		public float EmissiveStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(7)]
		public TerrainWaterMaterial_v1 WaterMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Field(8)]
		public WaterOverrides_v1 Overrides;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10434800737286119109uL)]
	public struct MagneticAnchorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(1)]
		public Entity connectedAnchor;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct AuthoredAIIdData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[RecRoom.DataLayer.Field(2)]
		public FixedString64Bytes AICodeGenId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[CompilerGenerated]
	[TypeManager.TypeVersion(2)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v5 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct CEEFNPBAPME : IComparable<CEEFNPBAPME>, IEquatable<CEEFNPBAPME>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly CEEFNPBAPME NAJKPDPODFG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly CEEFNPBAPME FLEIPCMBBLE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly CEEFNPBAPME FABNHDFACJJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly CEEFNPBAPME OJJLLFHOPJD;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CEEFNPBAPME GJDLADMMCPD;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly CEEFNPBAPME MEBFMKAMHFK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly int KABGMIEBEFC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type KOHNOJFBACP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84703A0", Offset = "0x846EDA0", VA = "0x1884703A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MMNMLIHNLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84706C0", Offset = "0x846F0C0", VA = "0x1884706C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BFHNMDFMCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8470060", Offset = "0x846EA60", VA = "0x188470060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type EHMCBBEKILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84705E0", Offset = "0x846EFE0", VA = "0x1884705E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FLCHEHNJJIJ EAJKMKOEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x846FD70", Offset = "0x846E770", VA = "0x18846FD70")]
		get
		{
			return default(FLCHEHNJJIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EEKHCGFLAJE OKFKEAFCHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84701A0", Offset = "0x846EBA0", VA = "0x1884701A0")]
		get
		{
			return default(EEKHCGFLAJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KCKJKAEKLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8470800", Offset = "0x846F200", VA = "0x188470800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OAICGAPHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8470010", Offset = "0x846EA10", VA = "0x188470010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DDNEDPGANGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x846FC10", Offset = "0x846E610", VA = "0x18846FC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DGIIFIAKFON
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8470480", Offset = "0x846EE80", VA = "0x188470480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
	public CEEFNPBAPME(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x846FEF0", Offset = "0x846E8F0", VA = "0x18846FEF0", Slot = "5")]
	public bool Equals(CEEFNPBAPME GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x846FF70", Offset = "0x846E970", VA = "0x18846FF70", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8470850", Offset = "0x846F250", VA = "0x188470850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5220590", Offset = "0x521EF90", VA = "0x185220590", Slot = "4")]
	public int CompareTo(CEEFNPBAPME GOCNHGEHNFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct BOHGAJEKAFH<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly int KABGMIEBEFC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CEEFNPBAPME MCAEALEBFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
		get
		{
			return default(CEEFNPBAPME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
	internal BOHGAJEKAFH(int KABGMIEBEFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x21DAFC0", Offset = "0x21D99C0", VA = "0x1821DAFC0")]
	public static CEEFNPBAPME HDPJNBPLGPE(BOHGAJEKAFH<T> ELEBIIGLBPL)
	{
		return default(CEEFNPBAPME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67861D0", Offset = "0x6784BD0", VA = "0x1867861D0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67867C0", Offset = "0x67851C0", VA = "0x1867867C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8470BF0", Offset = "0x846F5F0", VA = "0x188470BF0")]
		public static (long, string, string)[] EOIMJIOIFOF(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : GBBMODPOPBK, MBOKBPJPMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly DeferredEntityCommandBuffer decb;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x847CF50", Offset = "0x847B950", VA = "0x18847CF50", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x847CEA0", Offset = "0x847B8A0", VA = "0x18847CEA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x847CE50", Offset = "0x847B850", VA = "0x18847CE50")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public class DECBMeshPresenterNetworkData : FOGHKHKPFMM, MBOKBPJPMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DeferredEntityCommandBuffer decb;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FixedString32Bytes MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x847CD80", Offset = "0x847B780", VA = "0x18847CD80", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x847CC10", Offset = "0x847B610", VA = "0x18847CC10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x847CCC0", Offset = "0x847B6C0", VA = "0x18847CCC0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x847CB70", Offset = "0x847B570", VA = "0x18847CB70", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x847CE50", Offset = "0x847B850", VA = "0x18847CE50")]
		public DECBMeshPresenterNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Dictionary<Type, BJEJFNGOILC> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Dictionary<Type, BJEJFNGOILC> interfaces;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x847D010", Offset = "0x847BA10", VA = "0x18847D010")]
		public static IReadOnlyDictionary<Type, BJEJFNGOILC> FHCLMKELCLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x847D0E0", Offset = "0x847BAE0", VA = "0x18847D0E0")]
		private Dictionary<Type, BJEJFNGOILC> NFFNLBFBLBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x847D1A0", Offset = "0x847BBA0", VA = "0x18847D1A0")]
		private void OJPMPNAIFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x847D060", Offset = "0x847BA60", VA = "0x18847D060")]
		private readonly void GJNHNMPDBHB(Type interfaceType, BJEJFNGOILC implementationType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x847DA90", Offset = "0x847C490", VA = "0x18847DA90")]
		public static Type[] IBBMLHOPBGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x847DAF0", Offset = "0x847C4F0", VA = "0x18847DAF0")]
		private static void NFFNLBFBLBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public enum TerrainWaterMaterial_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Generic,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Ocean,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		River,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Lava,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Oil
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public enum TerrainWaterMaterial_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Generic,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Ocean,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		River,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Lava,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Oil,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Alien,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Blood,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Radioactive,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Slime,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Swamp,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Shoreline
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public enum TerrainLayerHeightFunction_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Steep,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Mesa
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public enum TerrainLayerRoughness_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		GentleSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		RuggedSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		MediumSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		RiverBed
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v3 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		SuppressCollision = 16384,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	public enum TerrainPlayAreaShape_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Circle,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		Square
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public enum WaterOverrides_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Chop = 1,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Alpha = 2,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Color = 4,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		DeepColor = 8,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		EmissiveStrength = 16,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		All = 31
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public enum RenderableColor_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Red = 0,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		Orange = 1,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Yellow = 2,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		LightGreen = 3,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Blue = 4,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		LightBlue = 5,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Teal = 6,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Green = 7,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Purple = 8,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		LightPink = 9,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Pink = 10,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Brown = 11,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Tan = 12,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		White = 13,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Grey = 14,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		DarkGrey = 15,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		DarkBrown = 16,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LightBrown = 17,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		LightGrey = 18,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Black = 19,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		DarkRed = 20,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		DarkOrange = 21,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		DarkYellow = 22,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		DarkGreen = 23,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		DarkTeal = 24,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		DarkBlue = 25,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		DarkPurple = 26,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		DarkPink = 27,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		LightRed = 28,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		LightOrange = 29,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		LightYellow = 30,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Cyan = 31,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		LightPurple = 32,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		DarkTan = 33,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		NewColor1 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		NewColor2 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		NewColor3 = 36,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		NewColor4 = 37,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		NewColor5 = 38,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		NewColor6 = 39,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		NewColor7 = 40,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		NewColor8 = 41,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		NewColor9 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		NewColor10 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		NewColor11 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		NewColor12 = 45,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		NewColor13 = 46,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		NewColor14 = 47,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		NewColor15 = 48,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		NewColor16 = 49,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NewColor17 = 50,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		NewColor18 = 51,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		NewColor19 = 52,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		NewColor20 = 53,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		NewColor21 = 54,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		NewColor22 = 55,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		NewColor23 = 56,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		NewColor24 = 57,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		NewColor25 = 58,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		NewColor26 = 59,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		NewColor27 = 60,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Default = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public class SandboxDeformableShapeDefaults : AOHMMLNNCNA, GBBMODPOPBK, MBOKBPJPMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x12BB810", Offset = "0x12BA210", VA = "0x1812BB810", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x194BEC0", Offset = "0x194A8C0", VA = "0x18194BEC0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x84927B0", Offset = "0x84911B0", VA = "0x1884927B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8492670", Offset = "0x8491070", VA = "0x188492670", Slot = "4")]
		public void KPNIEKPKGAM(MBOKBPJPMMM networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
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
	[Cpp2IlInjected.Token(Token = "0x2000040")]
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
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public class R2SandboxDeformableShapeNetworkData : GBGFNEFNPOP, MBOKBPJPMMM, GBBMODPOPBK, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private NKJIGKIHDNC service;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8492520", Offset = "0x8490F20", VA = "0x188492520", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84924B0", Offset = "0x8490EB0", VA = "0x1884924B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x84922C0", Offset = "0x8490CC0", VA = "0x1884922C0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8492250", Offset = "0x8490C50", VA = "0x188492250", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x84923F0", Offset = "0x8490DF0", VA = "0x1884923F0", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8492330", Offset = "0x8490D30", VA = "0x188492330", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84921E0", Offset = "0x8490BE0", VA = "0x1884921E0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8492590", Offset = "0x8490F90", VA = "0x188492590", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC7A0", Offset = "0x1CEB1A0", VA = "0x181CEC7A0")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, NKJIGKIHDNC networkDataService)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Scale : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public float3 value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	public class MeshPresenterDefaults : AOHMMLNNCNA, FOGHKHKPFMM, MBOKBPJPMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private FixedString32Bytes meshStorageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private (long RequestId, int ActorNumber, int ServerTimestamp) meshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FixedString32Bytes MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4B9CC20", Offset = "0x4B9B620", VA = "0x184B9CC20", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x847D880", Offset = "0x847C280", VA = "0x18847D880", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xF83BD0", Offset = "0xF825D0", VA = "0x180F83BD0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x847DA30", Offset = "0x847C430", VA = "0x18847DA30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x847D890", Offset = "0x847C290", VA = "0x18847D890", Slot = "4")]
		public void KPNIEKPKGAM(MBOKBPJPMMM networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MeshPresenterDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
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
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	public class R2MeshPresenterNetworkData : GBGFNEFNPOP, MBOKBPJPMMM, FOGHKHKPFMM, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private NKJIGKIHDNC service;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8491EE0", Offset = "0x84908E0", VA = "0x188491EE0", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8492100", Offset = "0x8490B00", VA = "0x188492100", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8492090", Offset = "0x8490A90", VA = "0x188492090", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8491FB0", Offset = "0x84909B0", VA = "0x188491FB0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8491F50", Offset = "0x8490950", VA = "0x188491F50", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshGenerationRequestSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8491E10", Offset = "0x8490810", VA = "0x188491E10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8491D30", Offset = "0x8490730", VA = "0x188491D30", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8491DA0", Offset = "0x84907A0", VA = "0x188491DA0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8491E70", Offset = "0x8490870", VA = "0x188491E70", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8492020", Offset = "0x8490A20", VA = "0x188492020", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC7A0", Offset = "0x1CEB1A0", VA = "0x181CEC7A0")]
		public R2MeshPresenterNetworkData(Entity entity, NKJIGKIHDNC networkDataService)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshStorageFilename : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public FixedString32Bytes value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshGenerationRequest : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[R2Only]
		public static readonly BOHGAJEKAFH<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[R2Only]
		[IsBuffer]
		public static readonly BOHGAJEKAFH<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[R2Only]
		public static readonly BOHGAJEKAFH<CFDHLOOAFMC> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[R2Only]
		[IsBuffer]
		public static readonly BOHGAJEKAFH<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[R2Only]
		public static readonly BOHGAJEKAFH<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[IsBuffer]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[R2Only]
		[IsBuffer]
		public static readonly BOHGAJEKAFH<TerrainGenerationLayer> TerrainLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> OwnedByTerrain_isOwnedByTerrain;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[R2Only]
		public static readonly BOHGAJEKAFH<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[R2Only]
		public static readonly BOHGAJEKAFH<HIEKGLJOIDK> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FFABOFGMJFG> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[R2Only]
		public static readonly BOHGAJEKAFH<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[R2Only]
		public static readonly BOHGAJEKAFH<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[R2Only]
		public static readonly BOHGAJEKAFH<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FNBBDKGCAHJ> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[R2Only]
		public static readonly BOHGAJEKAFH<uint> TerrainGeneration_Seed;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> TerrainGeneration_BaseTerrainHeight;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> TerrainGeneration_BaseTerrainFeatureScale;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[R2Only]
		public static readonly BOHGAJEKAFH<JHNOEBLNBMP> TerrainGeneration_PlayAreaShape;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[R2Only]
		public static readonly BOHGAJEKAFH<OINMLFJGGEA> TerrainGeneration_BaseTerrainRoughness;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[R2Only]
		public static readonly BOHGAJEKAFH<IADMLFPDBJC> TerrainGeneration_BaseTerrainHeightFunction;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> TerrainGeneration_PlayAreaOpacity;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[R2Only]
		[IsBuffer]
		public static readonly BOHGAJEKAFH<DNEPMPBCOPJ> TerrainMaterialLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[R2Only]
		[IsBuffer]
		public static readonly BOHGAJEKAFH<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[R2Only]
		public static readonly BOHGAJEKAFH<IOFPFGMGGDL> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[R2Only]
		public static readonly BOHGAJEKAFH<BMLHKENOJFK> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[R2Only]
		public static readonly BOHGAJEKAFH<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[R2Only]
		public static readonly BOHGAJEKAFH<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> TerrainWater_waterHeight;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> TerrainWater_waterChop;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> TerrainWater_waterAlpha;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[R2Only]
		public static readonly BOHGAJEKAFH<DJHMAEDPFEM> TerrainWater_waterColor;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[R2Only]
		public static readonly BOHGAJEKAFH<DJHMAEDPFEM> TerrainWater_deepColor;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> TerrainWater_emissiveStrength;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[R2Only]
		public static readonly BOHGAJEKAFH<KONGKEIIMBB> TerrainWater_waterMaterial;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FNFAKLPEIOE> TerrainWater_overrides;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[R2Only]
		public static readonly BOHGAJEKAFH<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FBBDDCEJJGE> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[R2Only]
		public static readonly BOHGAJEKAFH<OPBIGPJHHKE> PlayerRoleComponent_RoleType;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[R2Only]
		public static readonly BOHGAJEKAFH<DHMONCPGFAD> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> MagneticAnchor_snappingDistanceMultiplier;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[R2Only]
		public static readonly BOHGAJEKAFH<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[R2Only]
		public static readonly BOHGAJEKAFH<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(HDNPCKFDPDA))]
		public static readonly BOHGAJEKAFH<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[R2Only]
		public static readonly BOHGAJEKAFH<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[R2Only]
		public static readonly BOHGAJEKAFH<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[R2Only]
		public static readonly BOHGAJEKAFH<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[R2Only]
		public static readonly BOHGAJEKAFH<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[R2Only]
		public static readonly BOHGAJEKAFH<CFDHLOOAFMC> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[R2Only]
		public static readonly BOHGAJEKAFH<DJHMAEDPFEM> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[R2Only]
		public static readonly BOHGAJEKAFH<IEDBPPJHEGN> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[R2Only]
		public static readonly BOHGAJEKAFH<IGEICALDFNG> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FFABOFGMJFG> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[R2Only]
		public static readonly BOHGAJEKAFH<POCJFLPCOMA> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[R2Only]
		public static readonly BOHGAJEKAFH<AFEOBCPOCDD> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public static readonly BOHGAJEKAFH<FixedString32Bytes> MeshPresenter_MeshStorageFilename;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[RuntimeOnly]
		public static readonly BOHGAJEKAFH<(long RequestId, int ActorNumber, int ServerTimestamp)> MeshPresenter_MeshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[R2Only]
		[IsBuffer]
		public static readonly BOHGAJEKAFH<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[R2Only]
		public static readonly BOHGAJEKAFH<MGPOLIAHKGI> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[R2Only]
		public static readonly BOHGAJEKAFH<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[R2Only]
		public static readonly BOHGAJEKAFH<MEGPAAFBBKC> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[R2Only]
		public static readonly BOHGAJEKAFH<OACKFEAFAME> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[R2Only]
		[IsBuffer]
		public static readonly BOHGAJEKAFH<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[R2Only]
		public static readonly BOHGAJEKAFH<FFAGMAGLFPM> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[R2Only]
		public static readonly BOHGAJEKAFH<AKEEGCAKFGA> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[R2Only]
		public static readonly BOHGAJEKAFH<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[R2Only]
		public static readonly BOHGAJEKAFH<JIBMOIOFAKP> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[R2Only]
		public static readonly BOHGAJEKAFH<BMPIDNBPFBI> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[R2Only]
		public static readonly BOHGAJEKAFH<HNJIPPJLGGJ> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[R2Only]
		public static readonly BOHGAJEKAFH<OKJOGDJANOL> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[R2Only]
		public static readonly BOHGAJEKAFH<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[R2Only]
		public static readonly BOHGAJEKAFH<OCLGKNFAEHE> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8480880", Offset = "0x847F280", VA = "0x188480880")]
		public static bool HANIGLOFBHP(CEEFNPBAPME property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RegisterService(typeof(IDEPIMOLDHC), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : IDEPIMOLDHC, KHLGOMKJGNC, AOOPFNOOKFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A60", Offset = "0xEC8460", VA = "0x180EC9A60", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x109DC80", Offset = "0x109C680", VA = "0x18109DC80", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x102B9A0", Offset = "0x102A3A0", VA = "0x18102B9A0", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAB4810", Offset = "0xAB3210", VA = "0x180AB4810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAB7BB0", Offset = "0xAB65B0", VA = "0x180AB7BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public FLCHEHNJJIJ[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<int, EEKHCGFLAJE> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAB7AD0", Offset = "0xAB64D0", VA = "0x180AB7AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3289FF0", Offset = "0x32889F0", VA = "0x183289FF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8480960", Offset = "0x847F360", VA = "0x188480960", Slot = "14")]
		public void IHHLMHPBLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8480970", Offset = "0x847F370", VA = "0x188480970", Slot = "15")]
		public void PFOGGBNCDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8480A00", Offset = "0x847F400", VA = "0x188480A00")]
		private void PLKLBKHJOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x848FC00", Offset = "0x848E600", VA = "0x18848FC00")]
		public static void OLPHEEJBOIF(JJDOHPFIPLM writer, CEEFNPBAPME property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x848CF70", Offset = "0x848B970", VA = "0x18848CF70")]
		public static void AGMIFIONGNG(GEOIBMHFEBF reader, CEEFNPBAPME property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x848DC00", Offset = "0x848C600", VA = "0x18848DC00")]
		private static void OJECAEIMBMD(JJDOHPFIPLM writer, CEEFNPBAPME property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x848FC20", Offset = "0x848E620", VA = "0x18848FC20")]
		private static void OPNAMDNIEGJ(GEOIBMHFEBF reader, CEEFNPBAPME property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F110", Offset = "0x3F3DB10", VA = "0x183F3F110")]
		internal static void GCGCKFHBJPB<T>(JJDOHPFIPLM writer, BOHGAJEKAFH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F4C0", Offset = "0x3F3DEC0", VA = "0x183F3F4C0")]
		internal static void LEOAOCFGODA<T>(GEOIBMHFEBF reader, BOHGAJEKAFH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F400", Offset = "0x3F3DE00", VA = "0x183F3F400")]
		internal static void GCGCKFHBJPB<T>(JJDOHPFIPLM writer, BOHGAJEKAFH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F740", Offset = "0x3F3E140", VA = "0x183F3F740")]
		internal static void LEOAOCFGODA<T>(GEOIBMHFEBF reader, BOHGAJEKAFH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F220", Offset = "0x3F3DC20", VA = "0x183F3F220")]
		internal static void GCGCKFHBJPB<T>(JJDOHPFIPLM writer, BOHGAJEKAFH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F5A0", Offset = "0x3F3DFA0", VA = "0x183F3F5A0")]
		internal static void LEOAOCFGODA<T>(GEOIBMHFEBF reader, BOHGAJEKAFH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x848D1A0", Offset = "0x848BBA0", VA = "0x18848D1A0")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x848D730", Offset = "0x848C130", VA = "0x18848D730")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x848D140", Offset = "0x848BB40", VA = "0x18848D140")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x848D570", Offset = "0x848BF70", VA = "0x18848D570")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x848D430", Offset = "0x848BE30", VA = "0x18848D430")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x848D9C0", Offset = "0x848C3C0", VA = "0x18848D9C0")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x848D070", Offset = "0x848BA70", VA = "0x18848D070")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x848DBA0", Offset = "0x848C5A0", VA = "0x18848DBA0")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x848D500", Offset = "0x848BF00", VA = "0x18848D500")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x848D680", Offset = "0x848C080", VA = "0x18848D680")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x848D490", Offset = "0x848BE90", VA = "0x18848D490")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x848D8A0", Offset = "0x848C2A0", VA = "0x18848D8A0")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x848D000", Offset = "0x848BA00", VA = "0x18848D000")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x848DAF0", Offset = "0x848C4F0", VA = "0x18848DAF0")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x848CF90", Offset = "0x848B990", VA = "0x18848CF90")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x848D5D0", Offset = "0x848BFD0", VA = "0x18848D5D0")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F2E0", Offset = "0x3F3DCE0", VA = "0x183F3F2E0")]
		internal static void GCGCKFHBJPB<T>(JJDOHPFIPLM writer, BOHGAJEKAFH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F670", Offset = "0x3F3E070", VA = "0x183F3F670")]
		internal static void LEOAOCFGODA<T>(GEOIBMHFEBF reader, BOHGAJEKAFH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x848D210", Offset = "0x848BC10", VA = "0x18848D210")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x848D7E0", Offset = "0x848C1E0", VA = "0x18848D7E0")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x848D320", Offset = "0x848BD20", VA = "0x18848D320")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x848DA20", Offset = "0x848C420", VA = "0x18848DA20")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x848D0D0", Offset = "0x848BAD0", VA = "0x18848D0D0")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<FFABOFGMJFG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x848D950", Offset = "0x848C350", VA = "0x18848D950")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<FFABOFGMJFG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x846F680", Offset = "0x846E080", VA = "0x18846F680")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, BOHGAJEKAFH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x846F870", Offset = "0x846E270", VA = "0x18846F870")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, BOHGAJEKAFH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x846F680", Offset = "0x846E080", VA = "0x18846F680")]
		internal static void GCGCKFHBJPB(JJDOHPFIPLM writer, CEEFNPBAPME prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x846F870", Offset = "0x846E270", VA = "0x18846F870")]
		internal static void LEOAOCFGODA(GEOIBMHFEBF reader, CEEFNPBAPME prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F0A0", Offset = "0x3F3DAA0", VA = "0x183F3F0A0")]
		internal static T AHJIDMECDCN<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8493960", Offset = "0x8492360", VA = "0x188493960")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8495070", Offset = "0x8493A70", VA = "0x188495070")]
		public void NFFNLBFBLBL(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8493990", Offset = "0x8492390", VA = "0x188493990")]
		private void AOIFODPLHGN(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x44A00D0", Offset = "0x449EAD0", VA = "0x1844A00D0")]
		private void OLONAELLMFA<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x449FD60", Offset = "0x449E760", VA = "0x18449FD60")]
		private void MMCCNNFDBIJ<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x449F3E0", Offset = "0x449DDE0", VA = "0x18449F3E0")]
		private void AELKBPAKNJM<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			UpgradeFixDisassociatedAnimationData = 164,
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			UpgradeRotateMeshPresenter180Degrees = 186
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8495080", Offset = "0x8493A80", VA = "0x188495080")]
		public static bool JKAMCILPDIC(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum FAPOCBJLPNF
{
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[CompilerGenerated]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	internal struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(16439110051792907600uL)]
	internal struct PlayerIdBuffer : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[RegisterService(typeof(LNEPPGBNIAA), new string[] { "Registry" })]
internal class OBOJKFLOOAN : LNEPPGBNIAA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type IDNKFHHENMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84935C0", Offset = "0x8491FC0", VA = "0x1884935C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Type[] KMNBMIDINHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8493650", Offset = "0x8492050", VA = "0x188493650", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyDictionary<Type, BJEJFNGOILC> DAJCCODAEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8493620", Offset = "0x8492020", VA = "0x188493620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8493630", Offset = "0x8492030", VA = "0x188493630", Slot = "7")]
	public void NNBAGBPCBJN(IComponentDefaultRegistration EJLIKLOGIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OBOJKFLOOAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class BDPOJFBEDFE : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class PFADACMBKOE : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string DDPJMHMICBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8493760", Offset = "0x8492160", VA = "0x188493760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool MECKNDEFNLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8493670", Offset = "0x8492070", VA = "0x188493670")]
		public PFADACMBKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x14BB2B0", Offset = "0x14B9CB0", VA = "0x1814BB2B0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 KLIEGJHNGPK)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8493660", Offset = "0x8492060", VA = "0x188493660", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 KLIEGJHNGPK, ObjectPrefabType_v1 KMAFNKGMDCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8493440", Offset = "0x8491E40", VA = "0x188493440")]
	public BDPOJFBEDFE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8493790", Offset = "0x8492190", VA = "0x188493790")]
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
