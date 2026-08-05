using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x842BB30", Offset = "0x842AB30", VA = "0x18842BB30", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		private int[] DGVDDFJHVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] DGPWFYPKLTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset XRLFBVIQUFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset XRQLZCCODQN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC640", Offset = "0x1FBB640", VA = "0x181FBC640", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x843D300", Offset = "0x843C300", VA = "0x18843D300")]
		private void ZASTUGVTQWC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x843D450", Offset = "0x843C450", VA = "0x18843D450")]
		private void ZAYARNPRAHL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x843CFF0", Offset = "0x843BFF0", VA = "0x18843CFF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x843D5A0", Offset = "0x843C5A0", VA = "0x18843D5A0")]
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
	[TypeManager.ForcedStableTypeHash(15805686756326706819uL)]
	public struct TerrainWaterData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(2)]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(3)]
		public float WaterAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(4)]
		public RenderableColor_v1 WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(5)]
		public RenderableColor_v1 DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(6)]
		public float EmissiveStrength;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15802817030977643784uL)]
	public struct TerrainWaterData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(1)]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[RecRoom.DataLayer.Field(2)]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(3)]
		public float WaterAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(4)]
		public RenderableColor_v1 WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(5)]
		public RenderableColor_v1 DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Field(6)]
		public float EmissiveStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(7)]
		public TerrainWaterMaterial_v1 WaterMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(8)]
		public WaterOverrides_v1 Overrides;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(10434800737286119109uL)]
	public struct MagneticAnchorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(1)]
		public Entity connectedAnchor;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	public struct AuthoredAIIdData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[RecRoom.DataLayer.Field(2)]
		public FixedString64Bytes AICodeGenId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	public struct ObjectPolicyData_v5 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct NetworkProperty : IComparable<NetworkProperty>, IEquatable<NetworkProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly NetworkProperty Invalid;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly NetworkProperty CreateObject;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly NetworkProperty DestroyObject;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly NetworkProperty BeginTransaction;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly NetworkProperty EndTransaction;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly NetworkProperty External;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly int index;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int RFMSXMRTOHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Type EHNVZGTCLRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x842CB60", Offset = "0x842BB60", VA = "0x18842CB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FPXZBOIVLKU
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x842CC40", Offset = "0x842BC40", VA = "0x18842CC40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int WXXVDKLEOHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x842D5D0", Offset = "0x842C5D0", VA = "0x18842D5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Type PVEVIVQZWBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x842CD80", Offset = "0x842BD80", VA = "0x18842CD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PropertyMetadata HYCWHCGZTHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x842D040", Offset = "0x842C040", VA = "0x18842D040")]
			get
			{
				return default(PropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ComponentPropertyMetadata TECZOFYLIJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x842CE60", Offset = "0x842BE60", VA = "0x18842CE60")]
			get
			{
				return default(ComponentPropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool WAGFGYCAHWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x842C900", Offset = "0x842B900", VA = "0x18842C900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int HCQDKKTDUPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x842D1C0", Offset = "0x842C1C0", VA = "0x18842D1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BHWZXOGADEV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x842C950", Offset = "0x842B950", VA = "0x18842C950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool MKJDWNYLMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x842D500", Offset = "0x842C500", VA = "0x18842D500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
		public NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x842CA20", Offset = "0x842BA20", VA = "0x18842CA20", Slot = "5")]
		public bool Equals(NetworkProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x842CA80", Offset = "0x842BA80", VA = "0x18842CA80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x842D210", Offset = "0x842C210", VA = "0x18842D210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x210C650", Offset = "0x210B650", VA = "0x18210C650", Slot = "4")]
		public int CompareTo(NetworkProperty other)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct NetworkProperty<T>
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly int index;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private NetworkProperty MKMPEDLDLTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
		internal NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAEA0", Offset = "0x1AA9EA0", VA = "0x181AAAEA0")]
		public static implicit operator NetworkProperty(NetworkProperty<T> property)
		{
			return default(NetworkProperty);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5C68470", Offset = "0x5C67470", VA = "0x185C68470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5C69020", Offset = "0x5C68020", VA = "0x185C69020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public static class ICJAZJWJTCP
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly Dictionary<Type, int> ZKSZZHBGSFP;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly (long value, string name, string tooltip)[][] NFNIUYSVXBN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x841AD90", Offset = "0x8419D90", VA = "0x18841AD90")]
		public static (long, string, string)[] ZEWRYYLPSIJ(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public class XAAVMPLHIYE : QRIJCDYBUKF, CEOVQMHWRJS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Entity VTIVFOAWVKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DeferredEntityCommandBuffer AXFGLKCWNMJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 ZFDNWAZKJUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x843CF30", Offset = "0x843BF30", VA = "0x18843CF30", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x843CE80", Offset = "0x843BE80", VA = "0x18843CE80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DFAJKKKPHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x843A2E0", Offset = "0x84392E0", VA = "0x18843A2E0")]
		public XAAVMPLHIYE(Entity a, DeferredEntityCommandBuffer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class RDVTFFAGLWC : OVBYHTRUNLT, CEOVQMHWRJS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity VTIVFOAWVKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly DeferredEntityCommandBuffer AXFGLKCWNMJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FixedString32Bytes WZDDNZSUUHU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x843A210", Offset = "0x8439210", VA = "0x18843A210", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x843A000", Offset = "0x8439000", VA = "0x18843A000", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) WYEAITDJDON
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x843A0B0", Offset = "0x84390B0", VA = "0x18843A0B0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x843A170", Offset = "0x8439170", VA = "0x18843A170", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action UNDVLZWTZPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action UAKJNUXMKKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x843A2E0", Offset = "0x84392E0", VA = "0x18843A2E0")]
		public RDVTFFAGLWC(Entity a, DeferredEntityCommandBuffer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static Dictionary<Type, NetworkInterfaceInfo> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Dictionary<Type, NetworkInterfaceInfo> interfaces;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8426E20", Offset = "0x8425E20", VA = "0x188426E20")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> JCXYSDDSCMQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8426770", Offset = "0x8425770", VA = "0x188426770")]
		private Dictionary<Type, NetworkInterfaceInfo> BPSMAKIBARY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84268A0", Offset = "0x84258A0", VA = "0x1884268A0")]
		private void FHXYTHCGBRI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8426820", Offset = "0x8425820", VA = "0x188426820")]
		private readonly void EXJGSPHRJBL(Type a, NetworkInterfaceInfo b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	internal static class WINJTGKLKTT
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static Type[] LNWPBJVJCNC;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x843A890", Offset = "0x8439890", VA = "0x18843A890")]
		public static Type[] BNINETAYLBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x843A8E0", Offset = "0x84398E0", VA = "0x18843A8E0")]
		private static void BPSMAKIBARY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public enum TerrainWaterMaterial_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Generic,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Ocean,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		River,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Lava,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Oil
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public enum TerrainWaterMaterial_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Generic,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Ocean,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		River,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Lava,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Oil,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Alien,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Blood,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Radioactive,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Slime,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Swamp,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Shoreline
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public enum TerrainLayerHeightFunction_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Steep,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Mesa
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public enum TerrainLayerRoughness_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		GentleSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		RuggedSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		MediumSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		RiverBed
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v3 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		SuppressCollision = 16384,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public enum TerrainPlayAreaShape_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		Circle,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Square
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public enum WaterOverrides_v1 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Chop = 1,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Alpha = 2,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Color = 4,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		DeepColor = 8,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		EmissiveStrength = 16,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		All = 31
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public enum RenderableColor_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Red = 0,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Orange = 1,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Yellow = 2,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		LightGreen = 3,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Blue = 4,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		LightBlue = 5,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Teal = 6,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Green = 7,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Purple = 8,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		LightPink = 9,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Pink = 10,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Brown = 11,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Tan = 12,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		White = 13,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		Grey = 14,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		DarkGrey = 15,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		DarkBrown = 16,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		LightBrown = 17,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		LightGrey = 18,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		Black = 19,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		DarkRed = 20,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		DarkOrange = 21,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		DarkYellow = 22,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		DarkGreen = 23,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		DarkTeal = 24,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		DarkBlue = 25,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		DarkPurple = 26,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		DarkPink = 27,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		LightRed = 28,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		LightOrange = 29,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		LightYellow = 30,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Cyan = 31,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		LightPurple = 32,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		DarkTan = 33,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		NewColor1 = 34,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		NewColor2 = 35,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		NewColor3 = 36,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		NewColor4 = 37,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		NewColor5 = 38,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		NewColor6 = 39,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		NewColor7 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		NewColor8 = 41,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		NewColor9 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		NewColor10 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		NewColor11 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		NewColor12 = 45,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		NewColor13 = 46,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		NewColor14 = 47,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NewColor15 = 48,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		NewColor16 = 49,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		NewColor17 = 50,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		NewColor18 = 51,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		NewColor19 = 52,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		NewColor20 = 53,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		NewColor21 = 54,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		NewColor22 = 55,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		NewColor23 = 56,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		NewColor24 = 57,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		NewColor25 = 58,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		NewColor26 = 59,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		NewColor27 = 60,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Default = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	public class SandboxDeformableShapeDefaults : ZIQLWFFOHLQ, QRIJCDYBUKF, CEOVQMHWRJS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 ZFDNWAZKJUL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1038F20", Offset = "0x1037F20", VA = "0x181038F20", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x16A2E50", Offset = "0x16A1E50", VA = "0x1816A2E50", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type MXTBITXWWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x843A330", Offset = "0x8439330", VA = "0x18843A330", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DFAJKKKPHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x843A380", Offset = "0x8439380", VA = "0x18843A380", Slot = "4")]
		public void CopyTo(CEOVQMHWRJS networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public interface ZGMHDLIJUQT
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float3 ZFDNWAZKJUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public interface OSKXHQTTQEL
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		float3 ZFDNWAZKJUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public class WRXOCLGJCFI : NZDEONUTMNW, CEOVQMHWRJS, QRIJCDYBUKF, ZGMHDLIJUQT, OSKXHQTTQEL
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Entity VTIVFOAWVKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private WPVCVOKXAUX FMXIWXRRCIK;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 SFLRBITMIVT
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x843CB90", Offset = "0x843BB90", VA = "0x18843CB90", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x843CC00", Offset = "0x843BC00", VA = "0x18843CC00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 UXPOZGGYKNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x843CAB0", Offset = "0x843BAB0", VA = "0x18843CAB0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x843CB20", Offset = "0x843BB20", VA = "0x18843CB20", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 WBMBLKOOTTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x843CD50", Offset = "0x843BD50", VA = "0x18843CD50", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x843C9F0", Offset = "0x843B9F0", VA = "0x18843C9F0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action BSFYRUXNYWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x843CCE0", Offset = "0x843BCE0", VA = "0x18843CCE0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x843CC70", Offset = "0x843BC70", VA = "0x18843CC70", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4FB8300", Offset = "0x4FB7300", VA = "0x184FB8300")]
		public WRXOCLGJCFI(Entity a, WPVCVOKXAUX b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Tag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Scale : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public float3 value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	public class MeshPresenterDefaults : ZIQLWFFOHLQ, OVBYHTRUNLT, CEOVQMHWRJS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private FixedString32Bytes meshStorageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private (long RequestId, int ActorNumber, int ServerTimestamp) meshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FixedString32Bytes WZDDNZSUUHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4911430", Offset = "0x4910430", VA = "0x184911430", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x842C8F0", Offset = "0x842B8F0", VA = "0x18842C8F0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) WYEAITDJDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCE1A80", Offset = "0xCE0A80", VA = "0x180CE1A80", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCE1B60", Offset = "0xCE0B60", VA = "0x180CE1B60", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type MXTBITXWWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x842C700", Offset = "0x842B700", VA = "0x18842C700", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action UNDVLZWTZPM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action UAKJNUXMKKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x842C750", Offset = "0x842B750", VA = "0x18842C750", Slot = "4")]
		public void CopyTo(CEOVQMHWRJS networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MeshPresenterDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public interface USOOSYREIOL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool CNFQNZZXILB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool JUGZYLKRLVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	public class OJYTYLVWSNC : NZDEONUTMNW, CEOVQMHWRJS, OVBYHTRUNLT, USOOSYREIOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Entity VTIVFOAWVKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private WPVCVOKXAUX FMXIWXRRCIK;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FixedString32Bytes CLXHPBDYTBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x842DA20", Offset = "0x842CA20", VA = "0x18842DA20", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x842DA90", Offset = "0x842CA90", VA = "0x18842DA90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) VBRKJOHJRWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x842D950", Offset = "0x842C950", VA = "0x18842D950", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x842D870", Offset = "0x842C870", VA = "0x18842D870", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private bool NQCYSNXMPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x842D9C0", Offset = "0x842C9C0", VA = "0x18842D9C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool BRJRVBIJKKG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x842D810", Offset = "0x842C810", VA = "0x18842D810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action WQPLMDMXSYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x842D7A0", Offset = "0x842C7A0", VA = "0x18842D7A0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x842DB70", Offset = "0x842CB70", VA = "0x18842DB70", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action UPSLFZVJIVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x842DB00", Offset = "0x842CB00", VA = "0x18842DB00", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x842D8E0", Offset = "0x842C8E0", VA = "0x18842D8E0", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4FB8300", Offset = "0x4FB7300", VA = "0x184FB8300")]
		public OJYTYLVWSNC(Entity a, WPVCVOKXAUX b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_Tag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshStorageFilename : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public FixedString32Bytes value;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	public struct R2MeshPresenterNetworkData_MeshGenerationRequest : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) value;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	public class MAXZXBTUTGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[R2Only]
		public static readonly NetworkProperty<uint> RPSDEXHSNYD;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[R2Only]
		public static readonly NetworkProperty<FixedList32BytesLegacy<int>> GBZBCUNMXVX;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[R2Only]
		public static readonly NetworkProperty<bool> CRCPSQQLIFF;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> QJNNUASWSPT;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[R2Only]
		public static readonly NetworkProperty<float3> VTFCVTPYNIL;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[R2Only]
		public static readonly NetworkProperty<float3> OSVSEFMPABK;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> FUFQTYWBGEC;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[R2Only]
		public static readonly NetworkProperty<float> NMFPYKYIKJQ;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> FVCXJDBCWYM;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> FCKIWVIYYYO;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[R2Only]
		public static readonly NetworkProperty<long> UVNIBYSUMJY;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> JSQAQTZXEWM;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainGenerationLayer> SNAVFCXAFJV;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[R2Only]
		public static readonly NetworkProperty<bool> YVODLIZCDGW;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[R2Only]
		public static readonly NetworkProperty<int> THVVMGAVDJT;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> RMUUXYIDWOW;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[R2Only]
		public static readonly NetworkProperty<bool> CWFQVSGZVCU;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[R2Only]
		public static readonly NetworkProperty<float> VXERROZHRLU;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupFlags> MEQKYJSGDBQ;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> ZUXIUBIWZPV;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> YFPOGMNZFUF;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[R2Only]
		public static readonly NetworkProperty<float3> ICHCWIIZSPO;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> IABCLBNVQRZ;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[R2Only]
		public static readonly NetworkProperty<int> PBEIZKTWCCQ;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> FXKUJTVIJWA;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> PCEBVBIXYFA;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[R2Only]
		public static readonly NetworkProperty<float> ISDJXGMIPUH;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupStatusFlags> FDHMGOPVJCX;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> GEPWFWKSFXI;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[R2Only]
		public static readonly NetworkProperty<uint> GVXDSJOMPKG;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[R2Only]
		public static readonly NetworkProperty<float> BKIWSPBSAMQ;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[R2Only]
		public static readonly NetworkProperty<float> XBSIGVAAQDV;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[R2Only]
		public static readonly NetworkProperty<TerrainPlayAreaShape> WHJMQQZSJAZ;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerRoughness> CBEWOMESUCH;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerHeightFunction> FFGUKOOKWIY;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[R2Only]
		public static readonly NetworkProperty<float> WOBWBOAXNGV;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainCustomMaterialLayer> UNKXSODDLSA;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<byte> YJTKOCVYUWW;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[R2Only]
		public static readonly NetworkProperty<float3> ISBTNBECOSY;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[R2Only]
		public static readonly NetworkProperty<EShapeType> CBLANTMAISS;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> MHMNEOXGDKF;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[R2Only]
		public static readonly NetworkProperty<PrimitiveShapeType> RQVCPZIOCXR;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> FCCJXSGGPDA;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[R2Only]
		public static readonly NetworkProperty<bool> ZHAXZSTRPDI;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> XBMZJPUJSDU;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> QKAFQEFYBMV;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> KIPSVQSXJWY;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[R2Only]
		public static readonly NetworkProperty<float3> HAAQSHTLLND;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> NXKRKHOGWDM;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[R2Only]
		public static readonly NetworkProperty<uint> HDVNIZBQAWY;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[R2Only]
		public static readonly NetworkProperty<float> RFLYOHOWVSI;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[R2Only]
		public static readonly NetworkProperty<float> ANICONRAHSD;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[R2Only]
		public static readonly NetworkProperty<float> XFAZOPNCOSV;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> JPDVBTOORBA;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> SVVQRZLAHEN;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[R2Only]
		public static readonly NetworkProperty<float> WTGUMKRHZIO;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[R2Only]
		public static readonly NetworkProperty<TerrainWaterMaterial> SCRYZNGLIBU;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[R2Only]
		public static readonly NetworkProperty<WaterOverrides> PJWLDOVYBPP;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[R2Only]
		public static readonly NetworkProperty<uint> LBFFRNWMUSZ;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[R2Only]
		public static readonly NetworkProperty<bool> XCYQZUZJNTG;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[R2Only]
		public static readonly NetworkProperty<bool> UEURKTJEIFR;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> RXMIBSKFMDE;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[R2Only]
		public static readonly NetworkProperty<FixedString32Bytes> BATVNCFYUPT;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[R2Only]
		public static readonly NetworkProperty<NavMeshGenerationMode> HFSWFSEGPXB;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> SWMULTEIFWZ;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[R2Only]
		public static readonly NetworkProperty<bool> UCLVCHBJUYJ;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[R2Only]
		public static readonly NetworkProperty<AccountRoleTypeNetworked> KIEVZRGJJFQ;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[R2Only]
		public static readonly NetworkProperty<ShapeConfigFlags> DDHCERNTKUC;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> VCRNQIFRXOI;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> DXKAXEDYRCR;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[R2Only]
		public static readonly NetworkProperty<float> VEJPXXIDPLX;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[R2Only]
		public static readonly NetworkProperty<uint> FXVOQSDBBRK;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[R2Only]
		public static readonly NetworkProperty<int> KHZPDJEVBKO;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> FFDHMFFOLAO;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ConvertVector3ToFloat3))]
		public static readonly NetworkProperty<float3> ZFRXIDPUHHD;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[R2Only]
		public static readonly NetworkProperty<bool> NAALLLSPNIU;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[R2Only]
		public static readonly NetworkProperty<float> VXXTOZODXUS;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> YBETEGWZWCX;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[R2Only]
		public static readonly NetworkProperty<float3> YHPUSBETPPE;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> TDTLSQDWLWQ;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> JWTPFKLGHVM;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> EICZAVFDIOA;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> PVFYSJCFMKY;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[R2Only]
		public static readonly NetworkProperty<float> KSSCDSKGVPC;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> VWSYQRWCJRI;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[R2Only]
		public static readonly NetworkProperty<RenderableMaterial> BJFDUIBQYRU;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[R2Only]
		public static readonly NetworkProperty<float> BCVEMEZNHOC;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[R2Only]
		public static readonly NetworkProperty<float3> TYEABKADJXR;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[R2Only]
		public static readonly NetworkProperty<CollisionLayerEnum> IKKCYTYDTJW;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> WDDYORTKSXM;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> JKBGFJUHAIC;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[R2Only]
		public static readonly NetworkProperty<ElementSnapPointRuntimeFlags> EUYGWHMHYDY;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[R2Only]
		public static readonly NetworkProperty<GrabbableMode> OKBXJLDLURK;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public static readonly NetworkProperty<FixedString32Bytes> PSTBQMQSVGW;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[RuntimeOnly]
		public static readonly NetworkProperty<(long RequestId, int ActorNumber, int ServerTimestamp)> KNDIZGMIZMV;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> QNGHWJXUPTY;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[R2Only]
		public static readonly NetworkProperty<SplineParameters> VASZRLKVMDS;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[R2Only]
		public static readonly NetworkProperty<int> UXXJHTWXFLH;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[R2Only]
		public static readonly NetworkProperty<TransformHint> GWTPJWEGXUO;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[R2Only]
		public static readonly NetworkProperty<TransformPriority> XQMSXTEKWFR;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> GGPHVKHWHBJ;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[R2Only]
		public static readonly NetworkProperty<PhysicsModelEnumFlags> KYGVSFTBSPG;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[R2Only]
		public static readonly NetworkProperty<CollisionMode> IMFAFJSHCKA;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> OKBYSBBFCUT;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[R2Only]
		public static readonly NetworkProperty<float> IUFZWRLHBJM;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[R2Only]
		public static readonly NetworkProperty<ScaleRestriction> CSHURWUIIBV;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyUserConfigurableFlags> OPYYKZUETXO;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[R2Only]
		public static readonly NetworkProperty<CircuitsTransformBehavior> JSFCKVZZLAL;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyEnumFlags> OBJTOIXYFJM;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> FULHUURONHC;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[R2Only]
		public static readonly NetworkProperty<ReferenceGroupKind> HGDFLZRMRKQ;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public static class KFJXPZZOSEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x842BA60", Offset = "0x842AA60", VA = "0x18842BA60")]
		public static bool LDNWCSSPIXL(NetworkProperty a, bool b, bool c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RegisterService(typeof(ZXJDEGIHXPY), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class QOMAIZBLLQJ : ZXJDEGIHXPY, KUDSHOZAGXY, YKHKLPHTBGW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private NativeArray<int> NVUVVYCSCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private NativeArray<int> ZJFLJIJKCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private NativeBitArray QRDXPLGREEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private NativeBitArray UWCVPZXFPVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private NativeBitArray LMIUYEZYQQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private NativeParallelHashSet<int> WYLGOSLFSHG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeArray<int> ONWTZQMNITX
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xC9D7C0", Offset = "0xC9C7C0", VA = "0x180C9D7C0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeArray<int> LLDXFFKVFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC51700", Offset = "0xC50700", VA = "0x180C51700", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeBitArray DYDBGNWWNTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NativeBitArray TFJTULSHWRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NativeParallelHashSet<int> EFXOYUTYEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC516F0", Offset = "0xC506F0", VA = "0x180C516F0", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Type[] AIXQHYTGFCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xACDCF0", Offset = "0xACCCF0", VA = "0x180ACDCF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xACDF80", Offset = "0xACCF80", VA = "0x180ACDF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Type[] QDKDCBUUUEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xACDF70", Offset = "0xACCF70", VA = "0x180ACDF70", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xACDCD0", Offset = "0xACCCD0", VA = "0x180ACDCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PropertyMetadata[] HYCWHCGZTHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xACDCB0", Offset = "0xACCCB0", VA = "0x180ACDCB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xACDF60", Offset = "0xACCF60", VA = "0x180ACDF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<int, ComponentPropertyMetadata> GQOVTJSKRJT
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xACDCA0", Offset = "0xACCCA0", VA = "0x180ACDCA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xACDCC0", Offset = "0xACCCC0", VA = "0x180ACDCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int KNJNUUEZHUL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8439FE0", Offset = "0x8438FE0", VA = "0x188439FE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x842DC50", Offset = "0x842CC50", VA = "0x18842DC50", Slot = "14")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8439F50", Offset = "0x8438F50", VA = "0x188439F50", Slot = "15")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x842DC60", Offset = "0x842CC60", VA = "0x18842DC60")]
		private void PYBEBOSKTNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public QOMAIZBLLQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public static class JZUEKQQINZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8427500", Offset = "0x8426500", VA = "0x188427500")]
		public static void EYQEIJEWECG(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8427520", Offset = "0x8426520", VA = "0x188427520")]
		public static void HHKSWWHZFFR(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8427540", Offset = "0x8426540", VA = "0x188427540")]
		private static void PJDYVDCGMKD(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84299F0", Offset = "0x84289F0", VA = "0x1884299F0")]
		private static void ZLVQSLMRKVE(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x37E43F0", Offset = "0x37E33F0", VA = "0x1837E43F0")]
		internal static void XRHSQBYDVHR<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, byte d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x37E3B30", Offset = "0x37E2B30", VA = "0x1837E3B30")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x37E4880", Offset = "0x37E3880", VA = "0x1837E4880")]
		internal static void XRHSQBYDVHR<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, ushort d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x37E3F80", Offset = "0x37E2F80", VA = "0x1837E3F80")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x37E47B0", Offset = "0x37E37B0", VA = "0x1837E47B0")]
		internal static void XRHSQBYDVHR<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, int d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x37E3EB0", Offset = "0x37E2EB0", VA = "0x1837E3EB0")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84298C0", Offset = "0x84288C0", VA = "0x1884298C0")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<bool> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8427090", Offset = "0x8426090", VA = "0x188427090")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8429990", Offset = "0x8428990", VA = "0x188429990")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<int> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8427030", Offset = "0x8426030", VA = "0x188427030")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8429480", Offset = "0x8428480", VA = "0x188429480")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<uint> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8426FD0", Offset = "0x8425FD0", VA = "0x188426FD0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8429930", Offset = "0x8428930", VA = "0x188429930")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<long> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x84272C0", Offset = "0x84262C0", VA = "0x1884272C0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8429850", Offset = "0x8428850", VA = "0x188429850")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<float> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8426E70", Offset = "0x8425E70", VA = "0x188426E70")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8429550", Offset = "0x8428550", VA = "0x188429550")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<float3> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8427210", Offset = "0x8426210", VA = "0x188427210")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84297E0", Offset = "0x84287E0", VA = "0x1884297E0")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<quaternion> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8427450", Offset = "0x8426450", VA = "0x188427450")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8429410", Offset = "0x8428410", VA = "0x188429410")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<NetworkGuid> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8426F20", Offset = "0x8425F20", VA = "0x188426F20")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84296D0", Offset = "0x84286D0", VA = "0x1884296D0")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<FixedString32Bytes> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8427390", Offset = "0x8426390", VA = "0x188427390")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84295C0", Offset = "0x84285C0", VA = "0x1884295C0")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<FixedString64Bytes> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8427140", Offset = "0x8426140", VA = "0x188427140")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84294E0", Offset = "0x84284E0", VA = "0x1884294E0")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<FractionalIndex> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8427320", Offset = "0x8426320", VA = "0x188427320")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FractionalIndex> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x841ACB0", Offset = "0x8419CB0", VA = "0x18841ACB0")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty<LocalId> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x841A800", Offset = "0x8419800", VA = "0x18841A800")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x841ACB0", Offset = "0x8419CB0", VA = "0x18841ACB0")]
		internal static void XRHSQBYDVHR(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x841A800", Offset = "0x8419800", VA = "0x18841A800")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x37E4050", Offset = "0x37E3050", VA = "0x1837E4050")]
		internal static T UHCNJRMBXKU<T>(this NativeArray<byte> a) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x843D7D0", Offset = "0x843C7D0", VA = "0x18843D7D0")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x843EF20", Offset = "0x843DF20", VA = "0x18843EF20")]
		public void BPSMAKIBARY(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x843D800", Offset = "0x843C800", VA = "0x18843D800")]
		private void AFDPKUACVFB(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C544A0", Offset = "0x3C534A0", VA = "0x183C544A0")]
		private void GVHRDOKSBJM<T>(IComponentDefaultRegistration a, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C53E20", Offset = "0x3C52E20", VA = "0x183C53E20")]
		private void BOYARPCLFED<T>(IComponentDefaultRegistration a, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C54020", Offset = "0x3C53020", VA = "0x183C54020")]
		private void BQOAGHYVYUJ<T>(IComponentDefaultRegistration a) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	public static class CNWKFXZJRYY
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			UpgradeFixDisassociatedAnimationData = 164,
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			UpgradeRotateMeshPresenter180Degrees = 186
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static int RYLZUOILDMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x843D730", Offset = "0x843C730", VA = "0x18843D730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x843D720", Offset = "0x843C720", VA = "0x18843D720")]
		public static bool BEVQEIVLDFW(this SerializedDataLayerVersionData a, TaggedVersions b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum ReservedPropertyIds
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		CreateObject = -1,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		DestroyObject = -2,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		BeginTransaction = -3,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		EndTransaction = -4,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		External = -5
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 2, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	internal struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 4, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(16439110051792907600uL)]
	internal struct PlayerIdBuffer : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private int last;
	}
}
namespace RecRoom.DataLayer.Registration
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[RegisterService(typeof(CUGMFFYTSXK), new string[] { "Registry" })]
	internal class DKLLFPFROQH : CUGMFFYTSXK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Type VPAZMQLAOCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x843D780", Offset = "0x843C780", VA = "0x18843D780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Type[] CSOYICVQEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x843D740", Offset = "0x843C740", VA = "0x18843D740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IReadOnlyDictionary<Type, NetworkInterfaceInfo> FYODKVEDDVB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x843D770", Offset = "0x843C770", VA = "0x18843D770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x843D750", Offset = "0x843C750", VA = "0x18843D750", Slot = "7")]
		public void QARJJNMHADW(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public DKLLFPFROQH()
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
