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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86AF020", Offset = "0x86AE020", VA = "0x1886AF020", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		private int[] LHVPIFQWCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] LHQIKYWYSQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EVWCTMNURRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset EWBJQTHSBCX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24AA5C0", Offset = "0x24A95C0", VA = "0x1824AA5C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86C08A0", Offset = "0x86BF8A0", VA = "0x1886C08A0")]
		private void SSAHAHAUBXG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86C09F0", Offset = "0x86BF9F0", VA = "0x1886C09F0")]
		private void SSFNXNURLIP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86C0590", Offset = "0x86BF590", VA = "0x1886C0590", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86C0B40", Offset = "0x86BFB40", VA = "0x1886C0B40")]
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
		public int EYRVWTAEZEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Type XVYCRODXNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x86B1EB0", Offset = "0x86B0EB0", VA = "0x1886B1EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KEZYADECSKC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x86B1D70", Offset = "0x86B0D70", VA = "0x1886B1D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int KLXWYWZZPWA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x86B1760", Offset = "0x86B0760", VA = "0x1886B1760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Type ULEUMRANCWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x86B2290", Offset = "0x86B1290", VA = "0x1886B2290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PropertyMetadata BRPJHMFCOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86B1BA0", Offset = "0x86B0BA0", VA = "0x1886B1BA0")]
			get
			{
				return default(PropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ComponentPropertyMetadata RYPFMLVTQRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x86B1970", Offset = "0x86B0970", VA = "0x1886B1970")]
			get
			{
				return default(ComponentPropertyMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DEZVASENMGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x86B1B50", Offset = "0x86B0B50", VA = "0x1886B1B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JYYJQEJLHZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x86B1D20", Offset = "0x86B0D20", VA = "0x1886B1D20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UAMUIXNVASX
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x86B18A0", Offset = "0x86B08A0", VA = "0x1886B18A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool WFSRAIWEMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x86B1550", Offset = "0x86B0550", VA = "0x1886B1550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
		public NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86B1620", Offset = "0x86B0620", VA = "0x1886B1620", Slot = "5")]
		public bool Equals(NetworkProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86B1680", Offset = "0x86B0680", VA = "0x1886B1680", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86B1F90", Offset = "0x86B0F90", VA = "0x1886B1F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x25DA0D0", Offset = "0x25D90D0", VA = "0x1825DA0D0", Slot = "4")]
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
		private NetworkProperty VGEZKHQVCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
		internal NetworkProperty(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static implicit operator NetworkProperty(NetworkProperty<T> property)
		{
			return default(NetworkProperty);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5C73EF0", Offset = "0x5C72EF0", VA = "0x185C73EF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5C74BC0", Offset = "0x5C73BC0", VA = "0x185C74BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public static class IBTCWRFSBON
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly Dictionary<Type, int> HRXCFGUOBLB;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly (long value, string name, string tooltip)[][] IVIQANCGFIV;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x869E0D0", Offset = "0x869D0D0", VA = "0x18869E0D0")]
		public static (long, string, string)[] IEJTGHKSBET(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public class RUMFYKHASUC : QHAVIDQXMFJ, QAHNJFFZOLQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Entity ALGZZKDRXZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DeferredEntityCommandBuffer UMMSCMBXKYP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 XJDRLPXJKUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x86B39B0", Offset = "0x86B29B0", VA = "0x1886B39B0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x86B3900", Offset = "0x86B2900", VA = "0x1886B3900", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action WMCVOZOUNER
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86B26F0", Offset = "0x86B16F0", VA = "0x1886B26F0")]
		public RUMFYKHASUC(Entity a, DeferredEntityCommandBuffer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class QIPNUPFIEWY : BQAJKRAMRQP, QAHNJFFZOLQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity ALGZZKDRXZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly DeferredEntityCommandBuffer UMMSCMBXKYP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FixedString32Bytes LXLJUBKNBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x86B24D0", Offset = "0x86B14D0", VA = "0x1886B24D0", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x86B25A0", Offset = "0x86B15A0", VA = "0x1886B25A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) CUKCCAUFDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x86B2410", Offset = "0x86B1410", VA = "0x1886B2410", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x86B2650", Offset = "0x86B1650", VA = "0x1886B2650", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action PDLZJUAPYVS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action HVLCRCZTFSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86B26F0", Offset = "0x86B16F0", VA = "0x1886B26F0")]
		public QIPNUPFIEWY(Entity a, DeferredEntityCommandBuffer b)
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
		[Cpp2IlInjected.Address(RVA = "0x86A9AC0", Offset = "0x86A8AC0", VA = "0x1886A9AC0")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> JECGUIRRJZQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86AA140", Offset = "0x86A9140", VA = "0x1886AA140")]
		private Dictionary<Type, NetworkInterfaceInfo> YTBQRMTMKZK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86A9B10", Offset = "0x86A8B10", VA = "0x1886A9B10")]
		private void UUBPWEAPSYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86AA0C0", Offset = "0x86A90C0", VA = "0x1886AA0C0")]
		private readonly void WNXGRKJWVCH(Type a, NetworkInterfaceInfo b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	internal static class MQONDNYFRTR
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static Type[] CFIWHARJRIC;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86AF0E0", Offset = "0x86AE0E0", VA = "0x1886AF0E0")]
		public static Type[] GYRZEWZJJFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86AF140", Offset = "0x86AE140", VA = "0x1886AF140")]
		private static void YTBQRMTMKZK()
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
	public class SandboxDeformableShapeDefaults : IQYLMYDWFJS, QHAVIDQXMFJ, QAHNJFFZOLQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 XJDRLPXJKUN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1362200", Offset = "0x1361200", VA = "0x181362200", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x19D9980", Offset = "0x19D8980", VA = "0x1819D9980", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type XKAICQXSLFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x86C0170", Offset = "0x86BF170", VA = "0x1886C0170", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action WMCVOZOUNER
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86C0030", Offset = "0x86BF030", VA = "0x1886C0030", Slot = "4")]
		public void CopyTo(QAHNJFFZOLQ networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public interface BTHXWQGDMIV
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float3 XJDRLPXJKUN
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
	public interface XGYRRIXCFCZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		float3 XJDRLPXJKUN
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
	public class RTWJCHXZTYM : PLZQXVHAMTQ, QAHNJFFZOLQ, QHAVIDQXMFJ, BTHXWQGDMIV, XGYRRIXCFCZ
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Entity ALGZZKDRXZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private EFEAQPRXVJL QUJOACNNQVW;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 KVTIAXOWRST
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x86B3820", Offset = "0x86B2820", VA = "0x1886B3820", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x86B3680", Offset = "0x86B2680", VA = "0x1886B3680", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 YOJJUTXMNYF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x86B3470", Offset = "0x86B2470", VA = "0x1886B3470", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x86B3550", Offset = "0x86B2550", VA = "0x1886B3550", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 YASZLZMVDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x86B3760", Offset = "0x86B2760", VA = "0x1886B3760", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x86B35C0", Offset = "0x86B25C0", VA = "0x1886B35C0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action XIFISKXCCDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x86B36F0", Offset = "0x86B26F0", VA = "0x1886B36F0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x86B34E0", Offset = "0x86B24E0", VA = "0x1886B34E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5161360", Offset = "0x5160360", VA = "0x185161360")]
		public RTWJCHXZTYM(Entity a, EFEAQPRXVJL b)
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
	public class MeshPresenterDefaults : IQYLMYDWFJS, BQAJKRAMRQP, QAHNJFFZOLQ
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
		public FixedString32Bytes LXLJUBKNBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4AAFA60", Offset = "0x4AAEA60", VA = "0x184AAFA60", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x86B1540", Offset = "0x86B0540", VA = "0x1886B1540", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) CUKCCAUFDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x10374D0", Offset = "0x10364D0", VA = "0x1810374D0", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1036FC0", Offset = "0x1035FC0", VA = "0x181036FC0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type XKAICQXSLFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x86B14F0", Offset = "0x86B04F0", VA = "0x1886B14F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action PDLZJUAPYVS
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action HVLCRCZTFSH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x86B1350", Offset = "0x86B0350", VA = "0x1886B1350", Slot = "4")]
		public void CopyTo(QAHNJFFZOLQ networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public MeshPresenterDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public interface CLEDUZGZWPH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool QSUCDIKKBQB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool LLDPRWBBWTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	public class HNFJTFGPPEK : PLZQXVHAMTQ, QAHNJFFZOLQ, BQAJKRAMRQP, CLEDUZGZWPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Entity ALGZZKDRXZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private EFEAQPRXVJL QUJOACNNQVW;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FixedString32Bytes DSOMHXEVFQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x869DEA0", Offset = "0x869CEA0", VA = "0x18869DEA0", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x869DFF0", Offset = "0x869CFF0", VA = "0x18869DFF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) BJMXDOMIWWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x869DDC0", Offset = "0x869CDC0", VA = "0x18869DDC0", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x869DC20", Offset = "0x869CC20", VA = "0x18869DC20", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private bool XMNXWOPTHBD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x869DC90", Offset = "0x869CC90", VA = "0x18869DC90", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool YYGAPGFTCDK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x869DCF0", Offset = "0x869CCF0", VA = "0x18869DCF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action OILHAEDDCMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x869DF10", Offset = "0x869CF10", VA = "0x18869DF10", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x869DD50", Offset = "0x869CD50", VA = "0x18869DD50", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action GCJRUJQHZNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x869DE30", Offset = "0x869CE30", VA = "0x18869DE30", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x869DF80", Offset = "0x869CF80", VA = "0x18869DF80", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5161360", Offset = "0x5160360", VA = "0x185161360")]
		public HNFJTFGPPEK(Entity a, EFEAQPRXVJL b)
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
	public class RFXMDEGOJQU
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[R2Only]
		public static readonly NetworkProperty<uint> IDNUKNWKYYZ;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[R2Only]
		public static readonly NetworkProperty<FixedList32BytesLegacy<int>> AGORRWFUJJR;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[R2Only]
		public static readonly NetworkProperty<bool> OCBMEWPWIIJ;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> FOLXQSFDRQL;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[R2Only]
		public static readonly NetworkProperty<float3> YEOKCPUZYCV;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[R2Only]
		public static readonly NetworkProperty<float3> LIQDLFJTXDM;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> XKJFFCAUXEE;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[R2Only]
		public static readonly NetworkProperty<float> ZZUVBAVEQQU;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> ZJINDSRZXJA;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> SLFTHLZDDPO;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[R2Only]
		public static readonly NetworkProperty<long> IJSIPYLTJHC;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> TSPRWWSIPTQ;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainGenerationLayer> RBDBYMNKHVP;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[R2Only]
		public static readonly NetworkProperty<bool> HQPSMMEDYEE;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[R2Only]
		public static readonly NetworkProperty<int> FDEZWHHEWPR;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> IVJMWMFTRBO;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[R2Only]
		public static readonly NetworkProperty<bool> ICAGYUPVAEO;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[R2Only]
		public static readonly NetworkProperty<float> JPDGSHUVJAM;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupFlags> KUOPLUTAJHO;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> PUBSDDSLWWZ;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> VSMNMRDNRVV;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[R2Only]
		public static readonly NetworkProperty<float3> DUZLMRSCARM;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> SWZPZIUOAVL;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[R2Only]
		public static readonly NetworkProperty<int> XZEEUSQWYFQ;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> CPKSKDWVBBE;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> IBXZZPQCKTO;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[R2Only]
		public static readonly NetworkProperty<float> LHQNAWHYOWF;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[R2Only]
		public static readonly NetworkProperty<ToolCleanupStatusFlags> UUXZBTHNZJX;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> AAGRWAYZXRO;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[R2Only]
		public static readonly NetworkProperty<uint> SNOXJXLVGNO;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[R2Only]
		public static readonly NetworkProperty<float> DJAWODSXWIK;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[R2Only]
		public static readonly NetworkProperty<float> RVCCKQGSIAB;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[R2Only]
		public static readonly NetworkProperty<TerrainPlayAreaShape> LSVUTXHPSMP;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerRoughness> ZYLKMBDUJYJ;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[R2Only]
		public static readonly NetworkProperty<TerrainLayerHeightFunction> FSMMAZGOSHQ;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[R2Only]
		public static readonly NetworkProperty<float> KMETUSOCGLF;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<TerrainCustomMaterialLayer> HNVTJTGQZMC;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<byte> KXCYWJDPMWU;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[R2Only]
		public static readonly NetworkProperty<float3> ZHLTABTLXKO;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[R2Only]
		public static readonly NetworkProperty<EShapeType> TEBFSPXZKKU;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> EEPWQCYRHGT;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[R2Only]
		public static readonly NetworkProperty<PrimitiveShapeType> JDEKOAIJBPT;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> WXCMCFFPQDW;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[R2Only]
		public static readonly NetworkProperty<bool> LJUVJIQMUHC;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> RDJIDBGBXIA;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> UENIHWOLJIL;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> KMSFFIMAQTU;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[R2Only]
		public static readonly NetworkProperty<float3> XKWGGFZDSJJ;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> TKPFZZGMGXS;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[R2Only]
		public static readonly NetworkProperty<uint> SHTHHKBSVJI;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[R2Only]
		public static readonly NetworkProperty<float> RIYIDSZMQGS;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[R2Only]
		public static readonly NetworkProperty<float> HFRWCDWWUIV;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[R2Only]
		public static readonly NetworkProperty<float> GDXXTUPVDZR;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> VIOBQGGYGKQ;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> MHNEAXNSBIX;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[R2Only]
		public static readonly NetworkProperty<float> EVNBWSAVGFS;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[R2Only]
		public static readonly NetworkProperty<TerrainWaterMaterial> MOJBXQKXBWM;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[R2Only]
		public static readonly NetworkProperty<WaterOverrides> JKHEXEBGADJ;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[R2Only]
		public static readonly NetworkProperty<uint> GRSTNRXOUGT;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[R2Only]
		public static readonly NetworkProperty<bool> PCKMHREUKUW;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[R2Only]
		public static readonly NetworkProperty<bool> MNJBEHEKVZP;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> GJYMVYYDWLO;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[R2Only]
		public static readonly NetworkProperty<FixedString32Bytes> WNAJNFLQJWH;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[R2Only]
		public static readonly NetworkProperty<NavMeshGenerationMode> ZHSIZXWZUWR;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[R2Only]
		public static readonly NetworkProperty<FixedString64Bytes> EUXGVOMYRJV;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[R2Only]
		public static readonly NetworkProperty<bool> ORBDORPWBNN;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[R2Only]
		public static readonly NetworkProperty<AccountRoleTypeNetworked> LBSECCGOBBW;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[R2Only]
		public static readonly NetworkProperty<ShapeConfigFlags> QCWWYJPTZOY;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> YXQGTKGPSYS;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> XRCZNPJUBIT;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[R2Only]
		public static readonly NetworkProperty<float> XYNCMXRVTFB;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[R2Only]
		public static readonly NetworkProperty<uint> JPQCNORZDXI;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[R2Only]
		public static readonly NetworkProperty<int> JRKCGQHYZWU;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> RLAUVBNPNBG;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ConvertVector3ToFloat3))]
		public static readonly NetworkProperty<float3> KOUWJQSJOSL;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[R2Only]
		public static readonly NetworkProperty<bool> FWQHCNYMXIG;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[R2Only]
		public static readonly NetworkProperty<float> EIGQZQOUWEA;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[R2Only]
		public static readonly NetworkProperty<quaternion> VVKZEJNQBPL;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[R2Only]
		public static readonly NetworkProperty<float3> MRYKUMYPMQA;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> ATVWSWYYHZE;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[R2Only]
		public static readonly NetworkProperty<NetworkGuid> XLMNKPTRMYY;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> GHFASUIRJXQ;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[R2Only]
		public static readonly NetworkProperty<InteractionFilterMode> AUTQNVMINBM;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[R2Only]
		public static readonly NetworkProperty<float> CXVOYKVJWBM;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[R2Only]
		public static readonly NetworkProperty<RenderableColor> ZTHEFSKCSVG;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[R2Only]
		public static readonly NetworkProperty<RenderableMaterial> BKKLTBPOPTO;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[R2Only]
		public static readonly NetworkProperty<float> XUUFUYVSJHW;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[R2Only]
		public static readonly NetworkProperty<float3> KTZIKKNYFUB;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[R2Only]
		public static readonly NetworkProperty<CollisionLayerEnum> JBZABPEQBMC;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> OWATNYIGMIU;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[R2Only]
		public static readonly NetworkProperty<FractionalIndex> FVUQVSMVSPG;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[R2Only]
		public static readonly NetworkProperty<ElementSnapPointRuntimeFlags> ERNRQJREKBW;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[R2Only]
		public static readonly NetworkProperty<GrabbableMode> LPIXOECWPJI;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public static readonly NetworkProperty<FixedString32Bytes> XDSKUJZLYII;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[RuntimeOnly]
		public static readonly NetworkProperty<(long RequestId, int ActorNumber, int ServerTimestamp)> IFPUYCRSKYX;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<LocalId> DCWDGLVGTVO;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[R2Only]
		public static readonly NetworkProperty<SplineParameters> RAXFYQVLVBI;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[R2Only]
		public static readonly NetworkProperty<int> YIFFEGFCIAD;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[R2Only]
		public static readonly NetworkProperty<TransformHint> LKGVAAMIJTG;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[R2Only]
		public static readonly NetworkProperty<TransformPriority> EVHSKFLHLWZ;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[R2Only]
		[IsBuffer]
		public static readonly NetworkProperty<ulong> BPPIGAVDCOV;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[R2Only]
		public static readonly NetworkProperty<PhysicsModelEnumFlags> SYQRLOSFPYS;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[R2Only]
		public static readonly NetworkProperty<CollisionMode> JFFNJTZTZUC;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> GRDSTVXGWKF;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[R2Only]
		public static readonly NetworkProperty<float> TPPKJVIPTBW;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[R2Only]
		public static readonly NetworkProperty<ScaleRestriction> QXJUOHTXWDT;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyUserConfigurableFlags> ULCMTZKHAOC;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[R2Only]
		public static readonly NetworkProperty<CircuitsTransformBehavior> ARIITBBGVLT;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[R2Only]
		public static readonly NetworkProperty<ObjectPolicyEnumFlags> EFAYKXMEULG;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[R2Only]
		public static readonly NetworkProperty<LocalId> RNBQLRRKVWC;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[R2Only]
		public static readonly NetworkProperty<ReferenceGroupKind> FDUAEGERNCC;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public static class REWUMYQNTAV
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86B2740", Offset = "0x86B1740", VA = "0x1886B2740")]
		public static bool VKFGLFXRPIT(NetworkProperty a, bool b, bool c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RegisterService(typeof(OZFUIILQCLW), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class SULARZXPFJF : OZFUIILQCLW, UZCAYKEWQQA, AXORFOQTGRK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private NativeArray<int> IPWWYUSTMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private NativeArray<int> CRPPPCCZHSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private NativeBitArray KMEJWZYKXFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private NativeBitArray EUXSNZCMDCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private NativeBitArray WSMHWHHADAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private NativeParallelHashSet<int> WOKTOGRVMXU;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeArray<int> VCXJQBKLKLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeArray<int> IFYZQBFGONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xF99640", Offset = "0xF98640", VA = "0x180F99640", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeBitArray JBLIECXLAOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NativeBitArray ETDZKHLXTGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NativeParallelHashSet<int> MNGRFBPWTBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xF99650", Offset = "0xF98650", VA = "0x180F99650", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Type[] OTFCLROQWZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xACEE70", Offset = "0xACDE70", VA = "0x180ACEE70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xACEEA0", Offset = "0xACDEA0", VA = "0x180ACEEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Type[] VOBDQICNATP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xACEBF0", Offset = "0xACDBF0", VA = "0x180ACEBF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xACEBD0", Offset = "0xACDBD0", VA = "0x180ACEBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PropertyMetadata[] BRPJHMFCOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xACEBE0", Offset = "0xACDBE0", VA = "0x180ACEBE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xACEE80", Offset = "0xACDE80", VA = "0x180ACEE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<int, ComponentPropertyMetadata> FHPKCTCITUP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xACEBB0", Offset = "0xACDBB0", VA = "0x180ACEBB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xACEEB0", Offset = "0xACDEB0", VA = "0x180ACEEB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x86C0010", Offset = "0x86BF010", VA = "0x1886C0010", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86B3B00", Offset = "0x86B2B00", VA = "0x1886B3B00", Slot = "14")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A70", Offset = "0x86B2A70", VA = "0x1886B3A70", Slot = "15")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86B3B10", Offset = "0x86B2B10", VA = "0x1886B3B10")]
		private void TINBYFVORRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public SULARZXPFJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public static class LESPAYYRRSA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86ACA10", Offset = "0x86ABA10", VA = "0x1886ACA10")]
		public static void FDYEVGJAOEQ(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86AF000", Offset = "0x86AE000", VA = "0x1886AF000")]
		public static void QPQJSUEAITP(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86AD010", Offset = "0x86AC010", VA = "0x1886AD010")]
		private static void MVTRVCAKIOF(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86AA1F0", Offset = "0x86A91F0", VA = "0x1886AA1F0")]
		private static void DFMNVRRWRKQ(FastBufferReader a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A0B0", Offset = "0x3A590B0", VA = "0x183A5A0B0")]
		internal static void LDGVYQLXUAF<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, byte d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3A59B90", Offset = "0x3A58B90", VA = "0x183A59B90")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A540", Offset = "0x3A59540", VA = "0x183A5A540")]
		internal static void LDGVYQLXUAF<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, ushort d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3A59FE0", Offset = "0x3A58FE0", VA = "0x183A59FE0")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A470", Offset = "0x3A59470", VA = "0x183A5A470")]
		internal static void LDGVYQLXUAF<T>(FastBufferWriter a, NetworkProperty<T> b, NativeArray<byte> c, int d) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3A59F10", Offset = "0x3A58F10", VA = "0x183A59F10")]
		internal static void Deserialize<T>(FastBufferReader reader, NetworkProperty<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86ACA30", Offset = "0x86ABA30", VA = "0x1886ACA30")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<bool> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x86AC560", Offset = "0x86AB560", VA = "0x1886AC560")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x86ACF40", Offset = "0x86ABF40", VA = "0x1886ACF40")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<int> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86AC730", Offset = "0x86AB730", VA = "0x1886AC730")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86ACB00", Offset = "0x86ABB00", VA = "0x1886ACB00")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<uint> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86AC900", Offset = "0x86AB900", VA = "0x1886AC900")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86ACAA0", Offset = "0x86ABAA0", VA = "0x1886ACAA0")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<long> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x86AC380", Offset = "0x86AB380", VA = "0x1886AC380")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86ACB60", Offset = "0x86ABB60", VA = "0x1886ACB60")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<float> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x86AC790", Offset = "0x86AB790", VA = "0x1886AC790")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x86ACC40", Offset = "0x86ABC40", VA = "0x1886ACC40")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<float3> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86AC960", Offset = "0x86AB960", VA = "0x1886AC960")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x86ACFA0", Offset = "0x86ABFA0", VA = "0x1886ACFA0")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<quaternion> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86AC3E0", Offset = "0x86AB3E0", VA = "0x1886AC3E0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86ACBD0", Offset = "0x86ABBD0", VA = "0x1886ACBD0")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<NetworkGuid> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86AC680", Offset = "0x86AB680", VA = "0x1886AC680")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86ACCB0", Offset = "0x86ABCB0", VA = "0x1886ACCB0")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<FixedString32Bytes> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86AC840", Offset = "0x86AB840", VA = "0x1886AC840")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86ACE30", Offset = "0x86ABE30", VA = "0x1886ACE30")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<FixedString64Bytes> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86AC490", Offset = "0x86AB490", VA = "0x1886AC490")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86ACDC0", Offset = "0x86ABDC0", VA = "0x1886ACDC0")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<FractionalIndex> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86AC610", Offset = "0x86AB610", VA = "0x1886AC610")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<FractionalIndex> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x869DB40", Offset = "0x869CB40", VA = "0x18869DB40")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty<LocalId> b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x869D7F0", Offset = "0x869C7F0", VA = "0x18869D7F0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x869DB40", Offset = "0x869CB40", VA = "0x18869DB40")]
		internal static void LDGVYQLXUAF(FastBufferWriter a, NetworkProperty b, NativeArray<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x869D7F0", Offset = "0x869C7F0", VA = "0x18869D7F0")]
		internal static void Deserialize(FastBufferReader reader, NetworkProperty prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A610", Offset = "0x3A59610", VA = "0x183A5A610")]
		internal static T UEERWMVDMDY<T>(this NativeArray<byte> a) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x86C0D70", Offset = "0x86BFD70", VA = "0x1886C0D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C24C0", Offset = "0x86C14C0", VA = "0x1886C24C0")]
		public void YTBQRMTMKZK(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86C0DA0", Offset = "0x86BFDA0", VA = "0x1886C0DA0")]
		private void XICUOKKDYXH(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F31A80", Offset = "0x3F30A80", VA = "0x183F31A80")]
		private void XJZJBDHCRUQ<T>(IComponentDefaultRegistration a, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F31880", Offset = "0x3F30880", VA = "0x183F31880")]
		private void PAPTKHRKHOB<T>(IComponentDefaultRegistration a, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F31400", Offset = "0x3F30400", VA = "0x183F31400")]
		private void CAMVLJHDHKD<T>(IComponentDefaultRegistration a) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	public static class LJQSIDSNCJM
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
		public static int ESSTFAYECZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x86C0CC0", Offset = "0x86BFCC0", VA = "0x1886C0CC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x86C0CD0", Offset = "0x86BFCD0", VA = "0x1886C0CD0")]
		public static bool ZPYLFSVDOPU(this SerializedDataLayerVersionData a, TaggedVersions b)
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
	[RegisterService(typeof(ALFMPVHLIGK), new string[] { "Registry" })]
	internal class MQLOWTOPCQB : ALFMPVHLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Type RIIXUQYUKGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x86C0D20", Offset = "0x86BFD20", VA = "0x1886C0D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Type[] VHCFDWUCZDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x86C0CE0", Offset = "0x86BFCE0", VA = "0x1886C0CE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IReadOnlyDictionary<Type, NetworkInterfaceInfo> DDHAWOIVLDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x86C0CF0", Offset = "0x86BFCF0", VA = "0x1886C0CF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86C0D00", Offset = "0x86BFD00", VA = "0x1886C0D00", Slot = "7")]
		public void HUGOGVMGVUK(IComponentDefaultRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public MQLOWTOPCQB()
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
