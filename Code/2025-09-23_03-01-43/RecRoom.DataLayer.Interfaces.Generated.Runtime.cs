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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84877D0", Offset = "0x8485DD0", VA = "0x1884877D0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23FEEA0", Offset = "0x23FD4A0", VA = "0x1823FEEA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x849CC40", Offset = "0x849B240", VA = "0x18849CC40")]
		private void BFHOJBJGDPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x849CDB0", Offset = "0x849B3B0", VA = "0x18849CDB0")]
		private void KNNDHOHFANH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x849CF20", Offset = "0x849B520", VA = "0x18849CF20", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x849D260", Offset = "0x849B860", VA = "0x18849D260")]
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
public readonly struct JPCENFLHKDB : IComparable<JPCENFLHKDB>, IEquatable<JPCENFLHKDB>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly JPCENFLHKDB IDBBECHCNHL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly JPCENFLHKDB OIAFGENCPBK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JPCENFLHKDB LENJPKDEJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly JPCENFLHKDB NEPPPLLOHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JPCENFLHKDB DPIEBJDLIGP;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly JPCENFLHKDB BCONPACKAGO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly int PMIGBJGNLLP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type CBPEGPFKLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8486EB0", Offset = "0x84854B0", VA = "0x188486EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CDOMHMKBDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84872A0", Offset = "0x84858A0", VA = "0x1884872A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FMLOJENFFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8486B70", Offset = "0x8485170", VA = "0x188486B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type DGEEIMDFKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8486900", Offset = "0x8484F00", VA = "0x188486900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CAKGHFEEHJP FCOFKLIDBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84869E0", Offset = "0x8484FE0", VA = "0x1884869E0")]
		get
		{
			return default(CAKGHFEEHJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FFACLNDBNNC AFOJPLEKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8486CB0", Offset = "0x84852B0", VA = "0x188486CB0")]
		get
		{
			return default(FFACLNDBNNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BEKKOBCBCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84873E0", Offset = "0x84859E0", VA = "0x1884873E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JEDDLGDMDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8486F90", Offset = "0x8485590", VA = "0x188486F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MLJEDBEGHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8486FE0", Offset = "0x84855E0", VA = "0x188486FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FCACBOJBHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8487140", Offset = "0x8485740", VA = "0x188487140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
	public JPCENFLHKDB(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8486880", Offset = "0x8484E80", VA = "0x188486880", Slot = "5")]
	public bool Equals(JPCENFLHKDB AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84867E0", Offset = "0x8484DE0", VA = "0x1884867E0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8487430", Offset = "0x8485A30", VA = "0x188487430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x54C5980", Offset = "0x54C3F80", VA = "0x1854C5980", Slot = "4")]
	public int CompareTo(JPCENFLHKDB AAGCKLPFJME)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct ENFAGDKOBHC<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly int PMIGBJGNLLP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JPCENFLHKDB KJIFKOFDJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450")]
		get
		{
			return default(JPCENFLHKDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
	internal ENFAGDKOBHC(int PMIGBJGNLLP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x21D6500", Offset = "0x21D4B00", VA = "0x1821D6500")]
	public static JPCENFLHKDB HNGLNPFKABH(ENFAGDKOBHC<T> GBIEIIJCCOO)
	{
		return default(JPCENFLHKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B642B0", Offset = "0x4B628B0", VA = "0x184B642B0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B64AB0", Offset = "0x4B630B0", VA = "0x184B64AB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8479C20", Offset = "0x8478220", VA = "0x188479C20")]
		public static (long, string, string)[] BMOPPLJNFKL(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : KGMKOBIBAKM, PKCPFDEDKBE
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
			[Cpp2IlInjected.Address(RVA = "0x8485ED0", Offset = "0x84844D0", VA = "0x188485ED0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8485F90", Offset = "0x8484590", VA = "0x188485F90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8485E80", Offset = "0x8484480", VA = "0x188485E80")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public class DECBMeshPresenterNetworkData : DJAOOLGKHNI, PKCPFDEDKBE
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
			[Cpp2IlInjected.Address(RVA = "0x8485D00", Offset = "0x8484300", VA = "0x188485D00", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8485DD0", Offset = "0x84843D0", VA = "0x188485DD0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8485BA0", Offset = "0x84841A0", VA = "0x188485BA0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8485C60", Offset = "0x8484260", VA = "0x188485C60", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8485E80", Offset = "0x8484480", VA = "0x188485E80")]
		public DECBMeshPresenterNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Dictionary<Type, EAINMJFCEEG> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Dictionary<Type, EAINMJFCEEG> interfaces;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8486040", Offset = "0x8484640", VA = "0x188486040")]
		public static IReadOnlyDictionary<Type, EAINMJFCEEG> DBFJFLICJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8486720", Offset = "0x8484D20", VA = "0x188486720")]
		private Dictionary<Type, EAINMJFCEEG> NCEHDCEOICJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8486090", Offset = "0x8484690", VA = "0x188486090")]
		private void HEEJJDLKPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84866A0", Offset = "0x8484CA0", VA = "0x1884866A0")]
		private readonly void HJOPCONPCFF(Type interfaceType, EAINMJFCEEG implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x8487AD0", Offset = "0x84860D0", VA = "0x188487AD0")]
		public static Type[] CJOMNPNBIHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8487B30", Offset = "0x8486130", VA = "0x188487B30")]
		private static void NCEHDCEOICJ()
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
	public class SandboxDeformableShapeDefaults : LGMDENGOBGD, KGMKOBIBAKM, PKCPFDEDKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x12B5250", Offset = "0x12B3850", VA = "0x1812B5250", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x19415C0", Offset = "0x193FBC0", VA = "0x1819415C0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x849C800", Offset = "0x849AE00", VA = "0x18849C800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x849C6B0", Offset = "0x849ACB0", VA = "0x18849C6B0", Slot = "4")]
		public void OCEKIKEEKEK(PKCPFDEDKBE networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
	public class R2SandboxDeformableShapeNetworkData : PFILKKFGBKJ, PKCPFDEDKBE, KGMKOBIBAKM, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private KBBMBCAHNGD service;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x849C4A0", Offset = "0x849AAA0", VA = "0x18849C4A0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x849C300", Offset = "0x849A900", VA = "0x18849C300", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x849C290", Offset = "0x849A890", VA = "0x18849C290", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x849C430", Offset = "0x849AA30", VA = "0x18849C430", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x849C510", Offset = "0x849AB10", VA = "0x18849C510", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x849C370", Offset = "0x849A970", VA = "0x18849C370", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x849C5D0", Offset = "0x849ABD0", VA = "0x18849C5D0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x849C220", Offset = "0x849A820", VA = "0x18849C220", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE9E00", Offset = "0x1CE8400", VA = "0x181CE9E00")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, KBBMBCAHNGD networkDataService)
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
	public class MeshPresenterDefaults : LGMDENGOBGD, DJAOOLGKHNI, PKCPFDEDKBE
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
			[Cpp2IlInjected.Address(RVA = "0x4BD3820", Offset = "0x4BD1E20", VA = "0x184BD3820", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84878A0", Offset = "0x8485EA0", VA = "0x1884878A0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xF75380", Offset = "0xF73980", VA = "0x180F75380", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xF74BF0", Offset = "0xF731F0", VA = "0x180F74BF0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8487A70", Offset = "0x8486070", VA = "0x188487A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84878B0", Offset = "0x8485EB0", VA = "0x1884878B0", Slot = "4")]
		public void OCEKIKEEKEK(PKCPFDEDKBE networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
	public class R2MeshPresenterNetworkData : PFILKKFGBKJ, PKCPFDEDKBE, DJAOOLGKHNI, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KBBMBCAHNGD service;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x849BF20", Offset = "0x849A520", VA = "0x18849BF20", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x849BF90", Offset = "0x849A590", VA = "0x18849BF90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x849BEB0", Offset = "0x849A4B0", VA = "0x18849BEB0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x849C140", Offset = "0x849A740", VA = "0x18849C140", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x849C0E0", Offset = "0x849A6E0", VA = "0x18849C0E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshGenerationRequestSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x849BDE0", Offset = "0x849A3E0", VA = "0x18849BDE0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x849BE40", Offset = "0x849A440", VA = "0x18849BE40", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x849C000", Offset = "0x849A600", VA = "0x18849C000", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x849BD70", Offset = "0x849A370", VA = "0x18849BD70", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x849C070", Offset = "0x849A670", VA = "0x18849C070", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1CE9E00", Offset = "0x1CE8400", VA = "0x181CE9E00")]
		public R2MeshPresenterNetworkData(Entity entity, KBBMBCAHNGD networkDataService)
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
		public static readonly ENFAGDKOBHC<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[R2Only]
		public static readonly ENFAGDKOBHC<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[R2Only]
		[IsBuffer]
		public static readonly ENFAGDKOBHC<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[R2Only]
		public static readonly ENFAGDKOBHC<JFIFMMJLAJM> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[R2Only]
		[IsBuffer]
		public static readonly ENFAGDKOBHC<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[R2Only]
		public static readonly ENFAGDKOBHC<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[IsBuffer]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[R2Only]
		[IsBuffer]
		public static readonly ENFAGDKOBHC<TerrainGenerationLayer> TerrainLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> OwnedByTerrain_isOwnedByTerrain;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[R2Only]
		public static readonly ENFAGDKOBHC<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[R2Only]
		public static readonly ENFAGDKOBHC<BPFBLAOAHAF> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[R2Only]
		public static readonly ENFAGDKOBHC<KBHPNNIEMBA> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[R2Only]
		public static readonly ENFAGDKOBHC<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[R2Only]
		public static readonly ENFAGDKOBHC<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[R2Only]
		public static readonly ENFAGDKOBHC<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[R2Only]
		public static readonly ENFAGDKOBHC<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[R2Only]
		public static readonly ENFAGDKOBHC<PEDDGHIIBCI> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[R2Only]
		public static readonly ENFAGDKOBHC<uint> TerrainGeneration_Seed;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> TerrainGeneration_BaseTerrainHeight;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> TerrainGeneration_BaseTerrainFeatureScale;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[R2Only]
		public static readonly ENFAGDKOBHC<COCHOMAPEKN> TerrainGeneration_PlayAreaShape;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[R2Only]
		public static readonly ENFAGDKOBHC<NGKDAGAOOPI> TerrainGeneration_BaseTerrainRoughness;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[R2Only]
		public static readonly ENFAGDKOBHC<ACJPOIHPEKD> TerrainGeneration_BaseTerrainHeightFunction;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> TerrainGeneration_PlayAreaOpacity;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[R2Only]
		[IsBuffer]
		public static readonly ENFAGDKOBHC<OCLIGBIFNLE> TerrainMaterialLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[R2Only]
		[IsBuffer]
		public static readonly ENFAGDKOBHC<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[R2Only]
		public static readonly ENFAGDKOBHC<PIBCBJPPNOB> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[R2Only]
		public static readonly ENFAGDKOBHC<PINBFOAJNAG> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[R2Only]
		public static readonly ENFAGDKOBHC<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[R2Only]
		public static readonly ENFAGDKOBHC<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[R2Only]
		public static readonly ENFAGDKOBHC<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> TerrainWater_waterHeight;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> TerrainWater_waterChop;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> TerrainWater_waterAlpha;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[R2Only]
		public static readonly ENFAGDKOBHC<GCJNBCEMIDE> TerrainWater_waterColor;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[R2Only]
		public static readonly ENFAGDKOBHC<GCJNBCEMIDE> TerrainWater_deepColor;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> TerrainWater_emissiveStrength;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[R2Only]
		public static readonly ENFAGDKOBHC<PPLBBBHFMKJ> TerrainWater_waterMaterial;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[R2Only]
		public static readonly ENFAGDKOBHC<BMBIMNFFOOL> TerrainWater_overrides;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[R2Only]
		public static readonly ENFAGDKOBHC<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[R2Only]
		public static readonly ENFAGDKOBHC<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[R2Only]
		public static readonly ENFAGDKOBHC<EEMOINOOAFE> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[R2Only]
		public static readonly ENFAGDKOBHC<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[R2Only]
		public static readonly ENFAGDKOBHC<MNAALBCCOMC> PlayerRoleComponent_RoleType;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LIJKMCLPLEC> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> MagneticAnchor_snappingDistanceMultiplier;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[R2Only]
		public static readonly ENFAGDKOBHC<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[R2Only]
		public static readonly ENFAGDKOBHC<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(BDKGCPGNHAL))]
		public static readonly ENFAGDKOBHC<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[R2Only]
		public static readonly ENFAGDKOBHC<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[R2Only]
		public static readonly ENFAGDKOBHC<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[R2Only]
		public static readonly ENFAGDKOBHC<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[R2Only]
		public static readonly ENFAGDKOBHC<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[R2Only]
		public static readonly ENFAGDKOBHC<JFIFMMJLAJM> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[R2Only]
		public static readonly ENFAGDKOBHC<GCJNBCEMIDE> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[R2Only]
		public static readonly ENFAGDKOBHC<HMCCGFBIKNJ> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[R2Only]
		public static readonly ENFAGDKOBHC<AEEBNJJBFGH> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[R2Only]
		public static readonly ENFAGDKOBHC<KBHPNNIEMBA> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[R2Only]
		public static readonly ENFAGDKOBHC<BOPBKGGEOBN> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LMHFHHIHLDE> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public static readonly ENFAGDKOBHC<FixedString32Bytes> MeshPresenter_MeshStorageFilename;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[RuntimeOnly]
		public static readonly ENFAGDKOBHC<(long RequestId, int ActorNumber, int ServerTimestamp)> MeshPresenter_MeshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[R2Only]
		[IsBuffer]
		public static readonly ENFAGDKOBHC<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[R2Only]
		public static readonly ENFAGDKOBHC<GKJBALMMHEO> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[R2Only]
		public static readonly ENFAGDKOBHC<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[R2Only]
		public static readonly ENFAGDKOBHC<AKOKLEKNFMD> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[R2Only]
		public static readonly ENFAGDKOBHC<MFKJODAEKDK> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[R2Only]
		[IsBuffer]
		public static readonly ENFAGDKOBHC<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[R2Only]
		public static readonly ENFAGDKOBHC<HEODPNLMNME> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[R2Only]
		public static readonly ENFAGDKOBHC<CIGOCINADGN> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[R2Only]
		public static readonly ENFAGDKOBHC<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[R2Only]
		public static readonly ENFAGDKOBHC<AAHFFAICMMH> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[R2Only]
		public static readonly ENFAGDKOBHC<ECECGBCBHKB> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[R2Only]
		public static readonly ENFAGDKOBHC<OAOIGNGOHBK> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[R2Only]
		public static readonly ENFAGDKOBHC<GFABJDFINDA> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[R2Only]
		public static readonly ENFAGDKOBHC<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[R2Only]
		public static readonly ENFAGDKOBHC<INIBMAJCADC> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x848A8C0", Offset = "0x8488EC0", VA = "0x18848A8C0")]
		public static bool JGOMOFDIOKL(JPCENFLHKDB property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RegisterService(typeof(BIPDAEHNKKM), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : BIPDAEHNKKM, HDOAJHPMAEO, DCEPPCNEFDI
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
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xEC0AD0", Offset = "0xEBF0D0", VA = "0x180EC0AD0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF75380", Offset = "0xF73980", VA = "0x180F75380", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1090920", Offset = "0x108EF20", VA = "0x181090920", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1022E40", Offset = "0x1021440", VA = "0x181022E40", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA5730", Offset = "0xAA3D30", VA = "0x180AA5730", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAA54F0", Offset = "0xAA3AF0", VA = "0x180AA54F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAB03C0", Offset = "0xAAE9C0", VA = "0x180AB03C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAB0540", Offset = "0xAAEB40", VA = "0x180AB0540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public CAKGHFEEHJP[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAB04B0", Offset = "0xAAEAB0", VA = "0x180AB04B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAB0550", Offset = "0xAAEB50", VA = "0x180AB0550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<int, FFACLNDBNNC> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0560", Offset = "0xAAEB60", VA = "0x180AB0560", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0400", Offset = "0xAAEA00", VA = "0x180AB0400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3289190", Offset = "0x3287790", VA = "0x183289190", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x848A9A0", Offset = "0x8488FA0", VA = "0x18848A9A0", Slot = "14")]
		public void ECFEIOPKLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x848A9B0", Offset = "0x8488FB0", VA = "0x18848A9B0", Slot = "15")]
		public void HDAIJOIMLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x848AA40", Offset = "0x8489040", VA = "0x18848AA40")]
		private void KAOGAJKDNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x849B6A0", Offset = "0x8499CA0", VA = "0x18849B6A0")]
		public static void JPPAHJOANCP(HILAOKLIKAB writer, JPCENFLHKDB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x849BD50", Offset = "0x849A350", VA = "0x18849BD50")]
		public static void POFLDJDMLPN(JANCDHJIGAG reader, JPCENFLHKDB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8497590", Offset = "0x8495B90", VA = "0x188497590")]
		private static void EBIDIBOEJFO(HILAOKLIKAB writer, JPCENFLHKDB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8499590", Offset = "0x8497B90", VA = "0x188499590")]
		private static void ENLDBKIFOCP(JANCDHJIGAG reader, JPCENFLHKDB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F75930", Offset = "0x3F73F30", VA = "0x183F75930")]
		internal static void ANHNANMIGBP<T>(HILAOKLIKAB writer, ENFAGDKOBHC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F75D50", Offset = "0x3F74350", VA = "0x183F75D50")]
		internal static void LPNJIHLFELG<T>(JANCDHJIGAG reader, ENFAGDKOBHC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F75C20", Offset = "0x3F74220", VA = "0x183F75C20")]
		internal static void ANHNANMIGBP<T>(HILAOKLIKAB writer, ENFAGDKOBHC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F75FD0", Offset = "0x3F745D0", VA = "0x183F75FD0")]
		internal static void LPNJIHLFELG<T>(JANCDHJIGAG reader, ENFAGDKOBHC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3F75A40", Offset = "0x3F74040", VA = "0x183F75A40")]
		internal static void ANHNANMIGBP<T>(HILAOKLIKAB writer, ENFAGDKOBHC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F75E30", Offset = "0x3F74430", VA = "0x183F75E30")]
		internal static void LPNJIHLFELG<T>(JANCDHJIGAG reader, ENFAGDKOBHC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8497120", Offset = "0x8495720", VA = "0x188497120")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x849BBF0", Offset = "0x849A1F0", VA = "0x18849BBF0")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8497380", Offset = "0x8495980", VA = "0x188497380")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x849BA10", Offset = "0x849A010", VA = "0x18849BA10")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84973E0", Offset = "0x84959E0", VA = "0x1884973E0")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x849B9B0", Offset = "0x8499FB0", VA = "0x18849B9B0")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84970C0", Offset = "0x84956C0", VA = "0x1884970C0")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x849BA70", Offset = "0x849A070", VA = "0x18849BA70")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8497520", Offset = "0x8495B20", VA = "0x188497520")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x849B900", Offset = "0x8499F00", VA = "0x18849B900")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84972A0", Offset = "0x84958A0", VA = "0x1884972A0")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x849B790", Offset = "0x8499D90", VA = "0x18849B790")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84974B0", Offset = "0x8495AB0", VA = "0x1884974B0")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x849BCA0", Offset = "0x849A2A0", VA = "0x18849BCA0")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8497310", Offset = "0x8495910", VA = "0x188497310")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x849BAD0", Offset = "0x849A0D0", VA = "0x18849BAD0")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3F75B00", Offset = "0x3F74100", VA = "0x183F75B00")]
		internal static void ANHNANMIGBP<T>(HILAOKLIKAB writer, ENFAGDKOBHC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3F75F00", Offset = "0x3F74500", VA = "0x183F75F00")]
		internal static void LPNJIHLFELG<T>(JANCDHJIGAG reader, ENFAGDKOBHC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8496FB0", Offset = "0x84955B0", VA = "0x188496FB0")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x849B840", Offset = "0x8499E40", VA = "0x18849B840")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8497190", Offset = "0x8495790", VA = "0x188497190")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x849B6C0", Offset = "0x8499CC0", VA = "0x18849B6C0")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8497440", Offset = "0x8495A40", VA = "0x188497440")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<KBHPNNIEMBA> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x849BB80", Offset = "0x849A180", VA = "0x18849BB80")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<KBHPNNIEMBA> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8479690", Offset = "0x8477C90", VA = "0x188479690")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, ENFAGDKOBHC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84798D0", Offset = "0x8477ED0", VA = "0x1884798D0")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, ENFAGDKOBHC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8479690", Offset = "0x8477C90", VA = "0x188479690")]
		internal static void ANHNANMIGBP(HILAOKLIKAB writer, JPCENFLHKDB prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84798D0", Offset = "0x8477ED0", VA = "0x1884798D0")]
		internal static void LPNJIHLFELG(JANCDHJIGAG reader, JPCENFLHKDB prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F75CE0", Offset = "0x3F742E0", VA = "0x183F75CE0")]
		internal static T FPEPODCKADP<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x849D9B0", Offset = "0x849BFB0", VA = "0x18849D9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x849F0C0", Offset = "0x849D6C0", VA = "0x18849F0C0")]
		public void NCEHDCEOICJ(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x849D9E0", Offset = "0x849BFE0", VA = "0x18849D9E0")]
		private void AOKPNNAMBCM(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x44CAFD0", Offset = "0x44C95D0", VA = "0x1844CAFD0")]
		private void HLCLBCPEANL<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x44D63F0", Offset = "0x44D49F0", VA = "0x1844D63F0")]
		private void NMAFJFNCDGH<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x44D5A70", Offset = "0x44D4070", VA = "0x1844D5A70")]
		private void HPJFCAGCDFE<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
		[Cpp2IlInjected.Address(RVA = "0x849F0D0", Offset = "0x849D6D0", VA = "0x18849F0D0")]
		public static bool FOAOJBNNBGE(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum OPFGFCGPBKL
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
[RegisterService(typeof(HBMPEEMDGJO), new string[] { "Registry" })]
internal class LCMNJIHGKGL : HBMPEEMDGJO
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type MELKNKPJBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x849D650", Offset = "0x849BC50", VA = "0x18849D650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Type[] BKJMLLIIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x849D620", Offset = "0x849BC20", VA = "0x18849D620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyDictionary<Type, EAINMJFCEEG> PEMGKMOLEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x849D610", Offset = "0x849BC10", VA = "0x18849D610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x849D630", Offset = "0x849BC30", VA = "0x18849D630", Slot = "7")]
	public void KBDOANBEEJN(IComponentDefaultRegistration MFHHAEFLHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LCMNJIHGKGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class FGOABJIMJMC : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class NJIFPJGBJMG : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x849D7B0", Offset = "0x849BDB0", VA = "0x18849D7B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x849D6C0", Offset = "0x849BCC0", VA = "0x18849D6C0")]
		public NJIFPJGBJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x14B5E40", Offset = "0x14B4440", VA = "0x1814B5E40", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 JBBCAANONNB)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x849D6B0", Offset = "0x849BCB0", VA = "0x18849D6B0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 JBBCAANONNB, ObjectPrefabType_v1 KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x849D490", Offset = "0x849BA90", VA = "0x18849D490")]
	public FGOABJIMJMC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x849D7E0", Offset = "0x849BDE0", VA = "0x18849D7E0")]
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
