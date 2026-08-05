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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x97DA720", Offset = "0x97D9320", VA = "0x1897DA720", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		private int[] FEHXVDYRGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] FENESKSOPWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GXKYIJVMEXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset GXFRLDBOVMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x223B070", Offset = "0x2239C70", VA = "0x18223B070", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97EDB30", Offset = "0x97EC730", VA = "0x1897EDB30")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97ED9E0", Offset = "0x97EC5E0", VA = "0x1897ED9E0")]
		private void GUZRVDHVFXS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97EDC80", Offset = "0x97EC880", VA = "0x1897EDC80", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97EDF90", Offset = "0x97ECB90", VA = "0x1897EDF90")]
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
		public int RNGYLFLSPNO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Type SIHAFIFIULD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x97E73D0", Offset = "0x97E5FD0", VA = "0x1897E73D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x97E6F30", Offset = "0x97E5B30", VA = "0x1897E6F30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GRKCQGJVSOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x97E7290", Offset = "0x97E5E90", VA = "0x1897E7290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Type QIETXSVXFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x97E71B0", Offset = "0x97E5DB0", VA = "0x1897E71B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PropertyMetadata FEMXFIVAFIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x97E74B0", Offset = "0x97E60B0", VA = "0x1897E74B0")]
			get
			{
				return default(PropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ComponentPropertyMetadata VJYPIVPEXPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x97E7630", Offset = "0x97E6230", VA = "0x1897E7630")]
			get
			{
				return default(ComponentPropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool OCZSNVWKAZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x97E78E0", Offset = "0x97E64E0", VA = "0x1897E78E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JKWHVZXEHDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x97E7D00", Offset = "0x97E6900", VA = "0x1897E7D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IHCHLNVKTHW
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x97E7C30", Offset = "0x97E6830", VA = "0x1897E7C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HJGLCZEKBFM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x97E7810", Offset = "0x97E6410", VA = "0x1897E7810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
		public NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x97E7070", Offset = "0x97E5C70", VA = "0x1897E7070", Slot = "5")]
		public bool Equals(NetworkProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x97E70D0", Offset = "0x97E5CD0", VA = "0x1897E70D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97E7930", Offset = "0x97E6530", VA = "0x1897E7930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x238B370", Offset = "0x2389F70", VA = "0x18238B370", Slot = "4")]
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
		private NetworkProperty TTAZONQXWQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
		internal NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1CDF450", Offset = "0x1CDE050", VA = "0x181CDF450")]
		public static implicit operator NetworkProperty(NetworkProperty<T> property)
		{
			return default(NetworkProperty);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7262EA0", Offset = "0x7261AA0", VA = "0x187262EA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7263B70", Offset = "0x7262770", VA = "0x187263B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public static class JRRXFXKOUGA
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly Dictionary<Type, int> PKXMYQWILMM;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly (long value, string name, string tooltip)[][] EQQZZTUQRNS;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x97CED30", Offset = "0x97CD930", VA = "0x1897CED30")]
		public static (long, string, string)[] CEHOHQYJLXS(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public class BVGGIZQUWVT : AEIULYWIKIO, RYSGDVRLULF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Entity UQHKAAIUYKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DeferredEntityCommandBuffer DELIQUMMZVI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x97CBDF0", Offset = "0x97CA9F0", VA = "0x1897CBDF0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x97CBD40", Offset = "0x97CA940", VA = "0x1897CBD40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JWBUIJDXRAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x97CBEB0", Offset = "0x97CAAB0", VA = "0x1897CBEB0")]
		public BVGGIZQUWVT(Entity a, DeferredEntityCommandBuffer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class ZBAULVVCXCZ : UMJEQIUSFME, RYSGDVRLULF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity UQHKAAIUYKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly DeferredEntityCommandBuffer DELIQUMMZVI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FixedString32Bytes QBJEBUMVBQH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x97ED840", Offset = "0x97EC440", VA = "0x1897ED840", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x97ED630", Offset = "0x97EC230", VA = "0x1897ED630", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) FZTQXBOSYXS
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x97ED780", Offset = "0x97EC380", VA = "0x1897ED780", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x97ED6E0", Offset = "0x97EC2E0", VA = "0x1897ED6E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action RXUIVZWYUIX
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action PCIFMUBYHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97CBEB0", Offset = "0x97CAAB0", VA = "0x1897CBEB0")]
		public ZBAULVVCXCZ(Entity a, DeferredEntityCommandBuffer b)
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
		[Cpp2IlInjected.Address(RVA = "0x97CEC30", Offset = "0x97CD830", VA = "0x1897CEC30")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> MHUDXQZZPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97CEC80", Offset = "0x97CD880", VA = "0x1897CEC80")]
		private Dictionary<Type, NetworkInterfaceInfo> SIFQFAPRLAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97CE680", Offset = "0x97CD280", VA = "0x1897CE680")]
		private void JTAJNWVDHUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x97CE600", Offset = "0x97CD200", VA = "0x1897CE600")]
		private readonly void HLIUTTMTKDW(Type a, NetworkInterfaceInfo b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	internal static class CMNASBCFJZI
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static Type[] FESKGGFGAOV;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x97CBF00", Offset = "0x97CAB00", VA = "0x1897CBF00")]
		public static Type[] IVLZTUQWGKZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x97CBF60", Offset = "0x97CAB60", VA = "0x1897CBF60")]
		private static void SIFQFAPRLAF()
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
	public class SandboxDeformableShapeDefaults : FFWOXQNIDBX, AEIULYWIKIO, RYSGDVRLULF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x12A5C40", Offset = "0x12A4840", VA = "0x1812A5C40", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1915E00", Offset = "0x1914A00", VA = "0x181915E00", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type ALSRQGEZSZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x97ECD60", Offset = "0x97EB960", VA = "0x1897ECD60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action JWBUIJDXRAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x97ECC20", Offset = "0x97EB820", VA = "0x1897ECC20", Slot = "4")]
		public void CopyTo(RYSGDVRLULF networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public interface LEQQPBKJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float3 JBTKORXHGDU
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
	public interface KZSQPPSBCWE
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		float3 JBTKORXHGDU
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
	public class FEZMVMEHJDV : OECSVZXROGT, RYSGDVRLULF, AEIULYWIKIO, LEQQPBKJLDG, KZSQPPSBCWE
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Entity UQHKAAIUYKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private ISVHRVSPCMG KGCDZOBLHRV;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 OQBPZVHEGWK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x97CE460", Offset = "0x97CD060", VA = "0x1897CE460", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x97CE310", Offset = "0x97CCF10", VA = "0x1897CE310", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 SJHHXYTSVYA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x97CE1E0", Offset = "0x97CCDE0", VA = "0x1897CE1E0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x97CE3F0", Offset = "0x97CCFF0", VA = "0x1897CE3F0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 XLGBCABWPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x97CE250", Offset = "0x97CCE50", VA = "0x1897CE250", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x97CE4D0", Offset = "0x97CD0D0", VA = "0x1897CE4D0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action XOEBQQOFPDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x97CE380", Offset = "0x97CCF80", VA = "0x1897CE380", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x97CE170", Offset = "0x97CCD70", VA = "0x1897CE170", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6407EB0", Offset = "0x6406AB0", VA = "0x186407EB0")]
		public FEZMVMEHJDV(Entity a, ISVHRVSPCMG b)
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
	public class MeshPresenterDefaults : FFWOXQNIDBX, UMJEQIUSFME, RYSGDVRLULF
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
		public FixedString32Bytes QBJEBUMVBQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5166410", Offset = "0x5165010", VA = "0x185166410", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x97DA7E0", Offset = "0x97D93E0", VA = "0x1897DA7E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) FZTQXBOSYXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xF61530", Offset = "0xF60130", VA = "0x180F61530", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xF615B0", Offset = "0xF601B0", VA = "0x180F615B0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type ALSRQGEZSZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x97DA990", Offset = "0x97D9590", VA = "0x1897DA990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action RXUIVZWYUIX
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action PCIFMUBYHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x97DA7F0", Offset = "0x97D93F0", VA = "0x1897DA7F0", Slot = "4")]
		public void CopyTo(RYSGDVRLULF networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public MeshPresenterDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public interface FCGWOOKNKZY
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool CNDWAVGYTOE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool LYQJNFWABKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	public class WSXXZJMHBJR : OECSVZXROGT, RYSGDVRLULF, UMJEQIUSFME, FCGWOOKNKZY
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Entity UQHKAAIUYKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private ISVHRVSPCMG KGCDZOBLHRV;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FixedString32Bytes YJNYOUPJVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x97ED470", Offset = "0x97EC070", VA = "0x1897ED470", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x97ED390", Offset = "0x97EBF90", VA = "0x1897ED390", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) MNXRSCVOLIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x97ED320", Offset = "0x97EBF20", VA = "0x1897ED320", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x97ED550", Offset = "0x97EC150", VA = "0x1897ED550", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private bool KOIJVCKRHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x97ED2C0", Offset = "0x97EBEC0", VA = "0x1897ED2C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool FLWTLKXXEBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x97ED260", Offset = "0x97EBE60", VA = "0x1897ED260", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action WDJDBPYQVBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x97ED400", Offset = "0x97EC000", VA = "0x1897ED400", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x97ED4E0", Offset = "0x97EC0E0", VA = "0x1897ED4E0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action WVBSPBZWXSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x97ED180", Offset = "0x97EBD80", VA = "0x1897ED180", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x97ED1F0", Offset = "0x97EBDF0", VA = "0x1897ED1F0", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6407EB0", Offset = "0x6406AB0", VA = "0x186407EB0")]
		public WSXXZJMHBJR(Entity a, ISVHRVSPCMG b)
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
	public class AQSEJFAJOGX
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[R2Only]
		public static readonly NetworkProperty<uint> BRGVWWIXQMK;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[R2Only]
		public static readonly NetworkProperty<FixedList32BytesLegacy<int>> BENTRDWOBLA;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[R2Only]
		public static readonly NetworkProperty<bool> PQFZPYQSGMQ;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> LNRNUOTQKPO;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[R2Only]
		public static readonly NetworkProperty<float3> NHVYFEZSWTK;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[R2Only]
		public static readonly NetworkProperty<float3> KAXTPOJBJUZ;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> BFONOVHPBUZ;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[R2Only]
		public static readonly NetworkProperty<float> HBQXIMAUGCD;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> AQGWXVRVFLH;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> GFNPKTTFOHB;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[R2Only]
		public static readonly NetworkProperty<long> NYVAVJKIVNJ;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> VVJNZVTQOQD;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainGenerationLayer> UQUFMJDXNOY;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[R2Only]
		public static readonly NetworkProperty<bool> BXPGSXDSLHR;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[R2Only]
		public static readonly NetworkProperty<int> BUIWRJBQXTY;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> BCVVNKKKFBV;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[R2Only]
		public static readonly NetworkProperty<bool> NKFVJNBGJWV;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[R2Only]
		public static readonly NetworkProperty<float> NQLEXWCUTOP;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupFlags> NODABOZFIXX;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> KGWWKCSBLVC;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> NKVABZCRAKI;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[R2Only]
		public static readonly NetworkProperty<float3> ARNSEUHQCPL;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> LJSDVEVCQPQ;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[R2Only]
		public static readonly NetworkProperty<int> BFKGYEVUXHJ;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> CZLRJUKYPQB;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> DRLCQKMAPJT;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[R2Only]
		public static readonly NetworkProperty<float> FRTSVIIVSCQ;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupStatusFlags> MIHZHDMHHAO;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> ABTPUOBXZNL;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[R2Only]
		public static readonly NetworkProperty<uint> VHDGTYSDTSB;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[R2Only]
		public static readonly NetworkProperty<float> YHGUENBTRYV;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[R2Only]
		public static readonly NetworkProperty<float> MEAIMYNLANU;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[R2Only]
		public static readonly NetworkProperty<TerrainPlayAreaShape> MRIXBLLXSAM;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerRoughness> NZBYFJTFCOE;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerHeightFunction> FLMZVGNQOWR;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[R2Only]
		public static readonly NetworkProperty<float> MPKKDXTGHOA;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainCustomMaterialLayer> CZLNLIRWYSL;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<byte> FFQUJLWWRIN;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[R2Only]
		public static readonly NetworkProperty<float3> DDHSFVHTFKR;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[R2Only]
		public static readonly NetworkProperty<EShapeType> TGMXHLRXSRR;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> UJHWLCRKEFE;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[R2Only]
		public static readonly NetworkProperty<PrimitiveShapeType> IXWUKGRBFUU;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> VXPWRNYQFVJ;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[R2Only]
		public static readonly NetworkProperty<bool> LDSBWJQIDQD;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> XLALTGCPBID;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> NBIJHNDRPAI;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> VERYKHLWJZN;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[R2Only]
		public static readonly NetworkProperty<float3> BBHUKIACIGW;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> FPZVUZHTWSP;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[R2Only]
		public static readonly NetworkProperty<uint> GAWNZYLNFIJ;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[R2Only]
		public static readonly NetworkProperty<float> UJSZNPMUIIX;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[R2Only]
		public static readonly NetworkProperty<float> OXLLSYWVIQQ;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[R2Only]
		public static readonly NetworkProperty<float> BWZKFDMTAZG;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> JASDQMQRQZJ;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> FCYGGFFICOG;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[R2Only]
		public static readonly NetworkProperty<float> RPQMNTIAQOX;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[R2Only]
		public static readonly NetworkProperty<TerrainWaterMaterial> NSPMYXYUICJ;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[R2Only]
		public static readonly NetworkProperty<WaterOverrides> CMQDUEXYUDA;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[R2Only]
		public static readonly NetworkProperty<uint> SRJYJUJMIGM;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[R2Only]
		public static readonly NetworkProperty<bool> GUZXPGTMBRF;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[R2Only]
		public static readonly NetworkProperty<bool> DGGTOAZJZIA;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> SVMIHGYSVZR;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[R2Only]
		public static readonly NetworkProperty<FixedString32Bytes> IGJBGNPRISI;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[R2Only]
		public static readonly NetworkProperty<NavMeshGenerationMode> TJHVFBPPFGA;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> JUPFEJTNCZQ;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[R2Only]
		public static readonly NetworkProperty<bool> UFDYAUNSXDA;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[R2Only]
		public static readonly NetworkProperty<AccountRoleTypeNetworked> IPGQPLLCKBD;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[R2Only]
		public static readonly NetworkProperty<ShapeConfigFlags> RKRRRPGSCGX;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> GXLYITYWSWB;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> MKHNZACYJYS;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[R2Only]
		public static readonly NetworkProperty<float> PFHJUOQMUBK;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[R2Only]
		public static readonly NetworkProperty<uint> XNYZWARRUWD;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[R2Only]
		public static readonly NetworkProperty<int> WTKGPLRVVBH;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> YPSPHWKBAMH;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ConvertVector3ToFloat3))]
		public static readonly NetworkProperty<float3> XZATQZVTDFQ;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[R2Only]
		public static readonly NetworkProperty<bool> USUFPCREYPD;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[R2Only]
		public static readonly NetworkProperty<float> YDMLGCVANHV;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> UHQFRPKHXRQ;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[R2Only]
		public static readonly NetworkProperty<float3> YVKIHCJAXTR;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> VAPJYTIDPUD;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> PZTSHZMZWTF;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> DPOVNJBBGOX;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> WKUXJBAOBAH;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[R2Only]
		public static readonly NetworkProperty<float> ADNCRYQNFCZ;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> HVJOTAFFPKV;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[R2Only]
		public static readonly NetworkProperty<RenderableMaterial> VEPPZFDGTBZ;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[R2Only]
		public static readonly NetworkProperty<float> OCMUQPAXNDL;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[R2Only]
		public static readonly NetworkProperty<float3> DECQVHJIAYO;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[R2Only]
		public static readonly NetworkProperty<CollisionLayerEnum> HPGWSXWPUAJ;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> IKAAHZYAVVL;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> YXZNCLTHBFT;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[R2Only]
		public static readonly NetworkProperty<ElementSnapPointRuntimeFlags> UCDCYZMXJZT;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[R2Only]
		public static readonly NetworkProperty<GrabbableMode> UGCAPCSFGKZ;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public static readonly NetworkProperty<FixedString32Bytes> ARNRDUCXFUT;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[RuntimeOnly]
		public static readonly NetworkProperty<(long RequestId, int ActorNumber, int ServerTimestamp)> GISKWECVCQE;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> CADSHIDBUHP;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[R2Only]
		public static readonly NetworkProperty<SplineParameters> XIUEOCVEUVN;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[R2Only]
		public static readonly NetworkProperty<int> GHTLHBSASCM;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[R2Only]
		public static readonly NetworkProperty<TransformHint> MUZORFGOPEB;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[R2Only]
		public static readonly NetworkProperty<TransformPriority> OZWNMJDYWHW;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> YKSXTGFDISY;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[R2Only]
		public static readonly NetworkProperty<PhysicsModelEnumFlags> ENLUNXCAJZX;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[R2Only]
		public static readonly NetworkProperty<CollisionMode> QFTZFSBXMVT;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> IHPUWCQGONI;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[R2Only]
		public static readonly NetworkProperty<float> PHZMWQHCNLV;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[R2Only]
		public static readonly NetworkProperty<ScaleRestriction> RFRLCEFACUW;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyUserConfigurableFlags> VUXZVVTNJPF;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[R2Only]
		public static readonly NetworkProperty<CircuitsTransformBehavior> ZWFPXFLWQUM;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyEnumFlags> MTEJKWXGQYN;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> QVGAUUXTLZJ;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[R2Only]
		public static readonly NetworkProperty<ReferenceGroupKind> LYGSXKDLIAZ;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public static class ZZVUIKHKZFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x97ED910", Offset = "0x97EC510", VA = "0x1897ED910")]
		public static bool RBMXCOMJVMO(NetworkProperty a, bool b, bool c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RegisterService(typeof(IVGJIUWJFDH), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NVXNBYPHUYM : IVGJIUWJFDH, QNFHPEUJUSR, EQFYRFRSSPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private NativeArray<int> VPNXBRBSKMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private NativeArray<int> MBWEIEFGCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private NativeBitArray ZAWDWJVLSZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private NativeBitArray ULTFOYMLUBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private NativeBitArray PTDUZMDPSYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private NativeParallelHashSet<int> PEHPISSXFTX;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeArray<int> NPUJKQWKQBG
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF610", VA = "0x180F00A10", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeArray<int> RQFOJDHNJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xED3CD0", Offset = "0xED28D0", VA = "0x180ED3CD0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeBitArray QAZYILAYKLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NativeBitArray GCROAXVXOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NativeParallelHashSet<int> UOEOIMVQEVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xED3CC0", Offset = "0xED28C0", VA = "0x180ED3CC0", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Type[] PQSKXDLWNNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECD50", VA = "0x180CEE150", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCEE160", Offset = "0xCECD60", VA = "0x180CEE160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Type[] XLOPZVDAUCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCEE130", Offset = "0xCECD30", VA = "0x180CEE130", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCEE140", Offset = "0xCECD40", VA = "0x180CEE140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PropertyMetadata[] FEMXFIVAFIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED340", VA = "0x180CEE740", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCEE750", Offset = "0xCED350", VA = "0x180CEE750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<int, ComponentPropertyMetadata> CDIAWHIELIO
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED320", VA = "0x180CEE720", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCEE730", Offset = "0xCED330", VA = "0x180CEE730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x97E6F10", Offset = "0x97E5B10", VA = "0x1897E6F10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x97DAA70", Offset = "0x97D9670", VA = "0x1897DAA70", Slot = "14")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x97DA9E0", Offset = "0x97D95E0", VA = "0x1897DA9E0", Slot = "15")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x97DAA80", Offset = "0x97D9680", VA = "0x1897DAA80")]
		private void LFJZSQAXIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public NVXNBYPHUYM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public static class QLKLPSZNURV
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x97E8A60", Offset = "0x97E7660", VA = "0x1897E8A60")]
		public static void PBTWFKWLNCT(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x97E8A80", Offset = "0x97E7680", VA = "0x1897E8A80")]
		public static void QDMUTPMFXTE(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x97EAC30", Offset = "0x97E9830", VA = "0x1897EAC30")]
		private static void ZZHKUJSADPQ(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97E8AA0", Offset = "0x97E76A0", VA = "0x1897E8AA0")]
		private static void UWHUIEHLJXJ(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3E35FA0", Offset = "0x3E34BA0", VA = "0x183E35FA0")]
		internal static void GHRXOLGFAHI<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, byte d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3E356E0", Offset = "0x3E342E0", VA = "0x183E356E0")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3E36430", Offset = "0x3E35030", VA = "0x183E36430")]
		internal static void GHRXOLGFAHI<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, ushort d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3E35B30", Offset = "0x3E34730", VA = "0x183E35B30")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3E36360", Offset = "0x3E34F60", VA = "0x183E36360")]
		internal static void GHRXOLGFAHI<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, int d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E35A60", Offset = "0x3E34660", VA = "0x183E35A60")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x97E87E0", Offset = "0x97E73E0", VA = "0x1897E87E0")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<bool> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x97E81A0", Offset = "0x97E6DA0", VA = "0x1897E81A0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x97E88C0", Offset = "0x97E74C0", VA = "0x1897E88C0")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<int> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x97E7F10", Offset = "0x97E6B10", VA = "0x1897E7F10")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x97E8780", Offset = "0x97E7380", VA = "0x1897E8780")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<uint> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x97E7F70", Offset = "0x97E6B70", VA = "0x1897E7F70")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x97E8990", Offset = "0x97E7590", VA = "0x1897E8990")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<long> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x97E7FD0", Offset = "0x97E6BD0", VA = "0x1897E7FD0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x97E8920", Offset = "0x97E7520", VA = "0x1897E8920")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<float> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x97E8250", Offset = "0x97E6E50", VA = "0x1897E8250")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x97E89F0", Offset = "0x97E75F0", VA = "0x1897E89F0")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<float3> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x97E80F0", Offset = "0x97E6CF0", VA = "0x1897E80F0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x97E8710", Offset = "0x97E7310", VA = "0x1897E8710")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<quaternion> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x97E83D0", Offset = "0x97E6FD0", VA = "0x1897E83D0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x97E8850", Offset = "0x97E7450", VA = "0x1897E8850")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<NetworkGuid> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x97E7DF0", Offset = "0x97E69F0", VA = "0x1897E7DF0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x97E8480", Offset = "0x97E7080", VA = "0x1897E8480")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<FixedString32Bytes> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x97E8030", Offset = "0x97E6C30", VA = "0x1897E8030")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x97E8590", Offset = "0x97E7190", VA = "0x1897E8590")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<FixedString64Bytes> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x97E8300", Offset = "0x97E6F00", VA = "0x1897E8300")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x97E86A0", Offset = "0x97E72A0", VA = "0x1897E86A0")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<FractionalIndex> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x97E7EA0", Offset = "0x97E6AA0", VA = "0x1897E7EA0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FractionalIndex> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x97CB000", Offset = "0x97C9C00", VA = "0x1897CB000")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty<LocalId> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97CAC60", Offset = "0x97C9860", VA = "0x1897CAC60")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x97CB000", Offset = "0x97C9C00", VA = "0x1897CB000")]
		internal static void GHRXOLGFAHI(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x97CAC60", Offset = "0x97C9860", VA = "0x1897CAC60")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E35C00", Offset = "0x3E34800", VA = "0x183E35C00")]
		internal static T ETMUCYRZJLD<T>(this NativeArray<byte> a) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x97EE130", Offset = "0x97ECD30", VA = "0x1897EE130")]
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
		[Cpp2IlInjected.Address(RVA = "0x97EE160", Offset = "0x97ECD60", VA = "0x1897EE160")]
		public void SIFQFAPRLAF(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x97EE170", Offset = "0x97ECD70", VA = "0x1897EE170")]
		private void ZEGWPMQXANC(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x40D2A10", Offset = "0x40D1610", VA = "0x1840D2A10")]
		private void JUMLAXODUQR<T>(IComponentDefaultRegistration a, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x40D48E0", Offset = "0x40D34E0", VA = "0x1840D48E0")]
		private void SXTFLSQTSQQ<T>(IComponentDefaultRegistration a, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x40D4AE0", Offset = "0x40D36E0", VA = "0x1840D4AE0")]
		private void NWTMXXKHAGU<T>(IComponentDefaultRegistration a) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	public static class RBLKDNGIEQX
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
		public static int TKWETMAJYQC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x97EE110", Offset = "0x97ECD10", VA = "0x1897EE110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x97EE120", Offset = "0x97ECD20", VA = "0x1897EE120")]
		public static bool UFCKPXETIQN(this SerializedDataLayerVersionData a, TaggedVersions b)
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
	[RegisterService(typeof(RWRCFABRULF), new string[] { "Registry" })]
	internal class WRXMQHMHFJQ : RWRCFABRULF
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Type TQHVUTOPLAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x97EF8B0", Offset = "0x97EE4B0", VA = "0x1897EF8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Type[] XPUREBFWGWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x97EF910", Offset = "0x97EE510", VA = "0x1897EF910", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IReadOnlyDictionary<Type, NetworkInterfaceInfo> LURRTEAQVPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x97EF900", Offset = "0x97EE500", VA = "0x1897EF900", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x97EF890", Offset = "0x97EE490", VA = "0x1897EF890", Slot = "7")]
		public void AHDCYRNTZGD(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public WRXMQHMHFJQ()
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
