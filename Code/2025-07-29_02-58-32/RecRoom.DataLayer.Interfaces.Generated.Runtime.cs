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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x828F3C0", Offset = "0x828DDC0", VA = "0x18828F3C0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2349C00", Offset = "0x2348600", VA = "0x182349C00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82A4010", Offset = "0x82A2A10", VA = "0x1882A4010")]
		private void JKAPILFGJLE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82A3EA0", Offset = "0x82A28A0", VA = "0x1882A3EA0")]
		private void BEAEGHPCFKG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82A4180", Offset = "0x82A2B80", VA = "0x1882A4180", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82A44B0", Offset = "0x82A2EB0", VA = "0x1882A44B0")]
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
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[CompilerGenerated]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
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
	[TypeManager.ForcedStableTypeHash(2299272917927886785uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	[CompilerGenerated]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
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
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
public readonly struct ACDGIJAKCPP : IComparable<ACDGIJAKCPP>, IEquatable<ACDGIJAKCPP>
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly ACDGIJAKCPP IFHOCKPABEA;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly ACDGIJAKCPP EFMPOLEFKDC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly ACDGIJAKCPP BANIPMPBAMO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly ACDGIJAKCPP CIDMEKODLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly ACDGIJAKCPP FDEGDNOIICG;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly ACDGIJAKCPP BEFGCNNOCAL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly int FILGHJLFKAL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ODEBCJMJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type DKIFNAFPJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8282D30", Offset = "0x8281730", VA = "0x188282D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MPEIPFAGFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8282E60", Offset = "0x8281860", VA = "0x188282E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LKGECEPPJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8282640", Offset = "0x8281040", VA = "0x188282640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type GFAPJHJKPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8282C50", Offset = "0x8281650", VA = "0x188282C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ELHOPJDBLMD DDGNMONJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8282FA0", Offset = "0x82819A0", VA = "0x188282FA0")]
		get
		{
			return default(ELHOPJDBLMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IJMJKHAMEFJ BAPMIOHEOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8282930", Offset = "0x8281330", VA = "0x188282930")]
		get
		{
			return default(IJMJKHAMEFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GEAOJGDDBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8282780", Offset = "0x8281180", VA = "0x188282780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CCKCMGKKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8282E10", Offset = "0x8281810", VA = "0x188282E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KMGLIEECLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8283120", Offset = "0x8281B20", VA = "0x188283120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PDMMAOANIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82827D0", Offset = "0x82811D0", VA = "0x1882827D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
	public ACDGIJAKCPP(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8282B30", Offset = "0x8281530", VA = "0x188282B30", Slot = "5")]
	public bool Equals(ACDGIJAKCPP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8282BB0", Offset = "0x82815B0", VA = "0x188282BB0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8283280", Offset = "0x8281C80", VA = "0x188283280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DB80", Offset = "0x6A4C580", VA = "0x186A4DB80", Slot = "4")]
	public int CompareTo(ACDGIJAKCPP EFNHKCDKOGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct KDPPFNAMFML<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly int FILGHJLFKAL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private ACDGIJAKCPP CFGBHOCDHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		get
		{
			return default(ACDGIJAKCPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
	internal KDPPFNAMFML(int FILGHJLFKAL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2120A70", Offset = "0x211F470", VA = "0x182120A70")]
	public static ACDGIJAKCPP LHJBCIIELME(KDPPFNAMFML<T> OGFGMDINCKP)
	{
		return default(ACDGIJAKCPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x54E58A0", Offset = "0x54E42A0", VA = "0x1854E58A0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x54E6090", Offset = "0x54E4A90", VA = "0x1854E6090", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8283620", Offset = "0x8282020", VA = "0x188283620")]
		public static (long, string, string)[] FIHOMIDJAIJ(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : GBNPGJDGBIA, KGEGIFNFFAA
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
			[Cpp2IlInjected.Address(RVA = "0x828EB60", Offset = "0x828D560", VA = "0x18828EB60", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x828EAB0", Offset = "0x828D4B0", VA = "0x18828EAB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x828EA60", Offset = "0x828D460", VA = "0x18828EA60")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class DECBMeshPresenterNetworkData : KOFGDECNFOK, KGEGIFNFFAA
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
			[Cpp2IlInjected.Address(RVA = "0x828E780", Offset = "0x828D180", VA = "0x18828E780", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x828E9B0", Offset = "0x828D3B0", VA = "0x18828E9B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x828E850", Offset = "0x828D250", VA = "0x18828E850", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x828E910", Offset = "0x828D310", VA = "0x18828E910", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x828EA60", Offset = "0x828D460", VA = "0x18828EA60")]
		public DECBMeshPresenterNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static Dictionary<Type, JBFCMDAPGNI> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<Type, JBFCMDAPGNI> interfaces;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x828EC20", Offset = "0x828D620", VA = "0x18828EC20")]
		public static IReadOnlyDictionary<Type, JBFCMDAPGNI> AGAICMFKPDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x828F300", Offset = "0x828DD00", VA = "0x18828F300")]
		private Dictionary<Type, JBFCMDAPGNI> MAJNBNPDEEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x828ECF0", Offset = "0x828D6F0", VA = "0x18828ECF0")]
		private void HLOGEJJCGBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x828EC70", Offset = "0x828D670", VA = "0x18828EC70")]
		private readonly void HJJJJGDDJKG(Type interfaceType, JBFCMDAPGNI implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x828F6C0", Offset = "0x828E0C0", VA = "0x18828F6C0")]
		public static Type[] BCOCJBNFAGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x828F720", Offset = "0x828E120", VA = "0x18828F720")]
		private static void MAJNBNPDEEJ()
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
	public class SandboxDeformableShapeDefaults : CNJJAMKABMB, GBNPGJDGBIA, KGEGIFNFFAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x121C970", Offset = "0x121B370", VA = "0x18121C970", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x18655D0", Offset = "0x1863FD0", VA = "0x1818655D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x82A3A60", Offset = "0x82A2460", VA = "0x1882A3A60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82A3920", Offset = "0x82A2320", VA = "0x1882A3920", Slot = "4")]
		public void ACFCGPIAPCE(KGEGIFNFFAA networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
	public class R2SandboxDeformableShapeNetworkData : PHPMCIKBFGM, KGEGIFNFFAA, GBNPGJDGBIA, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private OGDAMBBNLCK service;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x82A3710", Offset = "0x82A2110", VA = "0x1882A3710", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x82A3780", Offset = "0x82A2180", VA = "0x1882A3780", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82A3570", Offset = "0x82A1F70", VA = "0x1882A3570", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x82A35E0", Offset = "0x82A1FE0", VA = "0x1882A35E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82A3650", Offset = "0x82A2050", VA = "0x1882A3650", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x82A37F0", Offset = "0x82A21F0", VA = "0x1882A37F0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82A3500", Offset = "0x82A1F00", VA = "0x1882A3500", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82A3490", Offset = "0x82A1E90", VA = "0x1882A3490", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA26A0", Offset = "0x4EA10A0", VA = "0x184EA26A0")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, OGDAMBBNLCK networkDataService)
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
	public class MeshPresenterDefaults : CNJJAMKABMB, KOFGDECNFOK, KGEGIFNFFAA
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
			[Cpp2IlInjected.Address(RVA = "0x49E1680", Offset = "0x49E0080", VA = "0x1849E1680", Slot = "6")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x828F6B0", Offset = "0x828E0B0", VA = "0x18828F6B0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public (long RequestId, int ActorNumber, int ServerTimestamp) MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF35BD0", VA = "0x180F371D0", Slot = "8")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xF36610", Offset = "0xF35010", VA = "0x180F36610", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x828F650", Offset = "0x828E050", VA = "0x18828F650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x828F490", Offset = "0x828DE90", VA = "0x18828F490", Slot = "4")]
		public void ACFCGPIAPCE(KGEGIFNFFAA networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
		void DDLNMNJDPBJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public class R2MeshPresenterNetworkData : PHPMCIKBFGM, KGEGIFNFFAA, KOFGDECNFOK, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private OGDAMBBNLCK service;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x82A3340", Offset = "0x82A1D40", VA = "0x1882A3340", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x82A32D0", Offset = "0x82A1CD0", VA = "0x1882A32D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x82A3260", Offset = "0x82A1C60", VA = "0x1882A3260", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82A2F80", Offset = "0x82A1980", VA = "0x1882A2F80", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x82A30C0", Offset = "0x82A1AC0", VA = "0x1882A30C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x82A3180", Offset = "0x82A1B80", VA = "0x1882A3180", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x82A2F10", Offset = "0x82A1910", VA = "0x1882A2F10", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		private event Action RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x82A31F0", Offset = "0x82A1BF0", VA = "0x1882A31F0", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x82A33B0", Offset = "0x82A1DB0", VA = "0x1882A33B0", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4EA26A0", Offset = "0x4EA10A0", VA = "0x184EA26A0")]
		public R2MeshPresenterNetworkData(Entity entity, OGDAMBBNLCK networkDataService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82A2FF0", Offset = "0x82A19F0", VA = "0x1882A2FF0", Slot = "13")]
		private void ENMLHBAIMNF()
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
		public static readonly KDPPFNAMFML<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly KDPPFNAMFML<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[IsBuffer]
		[R2Only]
		public static readonly KDPPFNAMFML<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly KDPPFNAMFML<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly KDPPFNAMFML<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly KDPPFNAMFML<EPFFJMIOIIG> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		[IsBuffer]
		public static readonly KDPPFNAMFML<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly KDPPFNAMFML<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		[IsBuffer]
		public static readonly KDPPFNAMFML<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[IsBuffer]
		[R2Only]
		public static readonly KDPPFNAMFML<TerrainGenerationLayer> TerrainLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> OwnedByTerrain_isOwnedByTerrain;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly KDPPFNAMFML<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly KDPPFNAMFML<PLHAJCJHLOP> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly KDPPFNAMFML<HJPEFODOPFJ> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly KDPPFNAMFML<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly KDPPFNAMFML<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly KDPPFNAMFML<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly KDPPFNAMFML<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly KDPPFNAMFML<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly KDPPFNAMFML<HNPLBJJBLJB> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly KDPPFNAMFML<uint> TerrainGeneration_Seed;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> TerrainGeneration_BaseTerrainHeight;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> TerrainGeneration_BaseTerrainFeatureScale;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly KDPPFNAMFML<MGJDJHNEGLA> TerrainGeneration_PlayAreaShape;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly KDPPFNAMFML<KLOKHGMABCA> TerrainGeneration_BaseTerrainRoughness;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly KDPPFNAMFML<NCBEDNHIKNG> TerrainGeneration_BaseTerrainHeightFunction;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> TerrainGeneration_PlayAreaOpacity;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[IsBuffer]
		[R2Only]
		public static readonly KDPPFNAMFML<ICMIJHNFGBH> TerrainMaterialLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		[IsBuffer]
		public static readonly KDPPFNAMFML<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly KDPPFNAMFML<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly KDPPFNAMFML<HJEFGOJLOAN> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly KDPPFNAMFML<CEHCOOIBKHM> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly KDPPFNAMFML<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly KDPPFNAMFML<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly KDPPFNAMFML<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly KDPPFNAMFML<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly KDPPFNAMFML<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly KDPPFNAMFML<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[R2Only]
		public static readonly KDPPFNAMFML<BJFCNOLEJHA> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[R2Only]
		public static readonly KDPPFNAMFML<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[R2Only]
		public static readonly KDPPFNAMFML<EMGMCNDGCFG> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[R2Only]
		public static readonly KDPPFNAMFML<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[R2Only]
		public static readonly KDPPFNAMFML<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(CGAOOBPKHAN))]
		public static readonly KDPPFNAMFML<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[R2Only]
		public static readonly KDPPFNAMFML<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[R2Only]
		public static readonly KDPPFNAMFML<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[R2Only]
		public static readonly KDPPFNAMFML<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[R2Only]
		public static readonly KDPPFNAMFML<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[R2Only]
		public static readonly KDPPFNAMFML<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[R2Only]
		public static readonly KDPPFNAMFML<EPFFJMIOIIG> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[R2Only]
		public static readonly KDPPFNAMFML<HLFHMCNDAGP> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[R2Only]
		public static readonly KDPPFNAMFML<NICLJDPJKKF> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[R2Only]
		public static readonly KDPPFNAMFML<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[R2Only]
		public static readonly KDPPFNAMFML<GFOOGNIAEFA> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[R2Only]
		public static readonly KDPPFNAMFML<HJPEFODOPFJ> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[R2Only]
		public static readonly KDPPFNAMFML<FHOJFJAOCHP> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[R2Only]
		public static readonly KDPPFNAMFML<MFBAPKLINAH> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly KDPPFNAMFML<FixedString32Bytes> MeshPresenter_MeshStorageFilename;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[RuntimeOnly]
		public static readonly KDPPFNAMFML<(long RequestId, int ActorNumber, int ServerTimestamp)> MeshPresenter_MeshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[IsBuffer]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[R2Only]
		public static readonly KDPPFNAMFML<PGCJEENILJB> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[R2Only]
		public static readonly KDPPFNAMFML<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[R2Only]
		public static readonly KDPPFNAMFML<LHKGKCLIHLH> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[R2Only]
		public static readonly KDPPFNAMFML<EPOPBBNMMBK> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[R2Only]
		[IsBuffer]
		public static readonly KDPPFNAMFML<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[R2Only]
		public static readonly KDPPFNAMFML<GCGINMLPDDC> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[R2Only]
		public static readonly KDPPFNAMFML<MLHELHANJLJ> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[R2Only]
		public static readonly KDPPFNAMFML<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[R2Only]
		public static readonly KDPPFNAMFML<BLMDODAEEPF> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[R2Only]
		public static readonly KDPPFNAMFML<ALMFFOLOPBG> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[R2Only]
		public static readonly KDPPFNAMFML<CBKMGINFBNJ> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[R2Only]
		public static readonly KDPPFNAMFML<IBCOPPAOFGG> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[R2Only]
		public static readonly KDPPFNAMFML<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[R2Only]
		public static readonly KDPPFNAMFML<MOLGCNIPLLK> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82922C0", Offset = "0x8290CC0", VA = "0x1882922C0")]
		public static bool DNNOGPLDFKE(ACDGIJAKCPP property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	[RegisterService(typeof(JABLHGIJCFH), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : JABLHGIJCFH, PGHMJJNBADC, NAGAKFIOPNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xE7AD80", Offset = "0xE79780", VA = "0x180E7AD80", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF35BD0", VA = "0x180F371D0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1067F60", Offset = "0x1066960", VA = "0x181067F60", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xFD2490", Offset = "0xFD0E90", VA = "0x180FD2490", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA841D0", Offset = "0xA82BD0", VA = "0x180A841D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA90910", Offset = "0xA8F310", VA = "0x180A90910", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA909B0", Offset = "0xA8F3B0", VA = "0x180A909B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ELHOPJDBLMD[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8F3C0", VA = "0x180A909C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Dictionary<int, IJMJKHAMEFJ> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA90970", Offset = "0xA8F370", VA = "0x180A90970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3171440", Offset = "0x316FE40", VA = "0x183171440", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x829E5C0", Offset = "0x829CFC0", VA = "0x18829E5C0", Slot = "14")]
		public void KEMLKJMHOGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x829E5D0", Offset = "0x829CFD0", VA = "0x18829E5D0", Slot = "15")]
		public void NOAMAPCJEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82923A0", Offset = "0x8290DA0", VA = "0x1882923A0")]
		private void CEMNKNEFGBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82A2ED0", Offset = "0x82A18D0", VA = "0x1882A2ED0")]
		public static void NNCEJHPMJCE(IOIOIIPNAEI writer, ACDGIJAKCPP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82A2EF0", Offset = "0x82A18F0", VA = "0x1882A2EF0")]
		public static void OHIDIDGPJJG(LGNPDNFGALK reader, ACDGIJAKCPP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82A1160", Offset = "0x829FB60", VA = "0x1882A1160")]
		private static void MMLEGOALEKO(IOIOIIPNAEI writer, ACDGIJAKCPP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x829ED40", Offset = "0x829D740", VA = "0x18829ED40")]
		private static void FKGKLCNGKGP(LGNPDNFGALK reader, ACDGIJAKCPP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A1D0", Offset = "0x3E38BD0", VA = "0x183E3A1D0")]
		internal static void AGNKEKDJGCC<T>(IOIOIIPNAEI writer, KDPPFNAMFML<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A580", Offset = "0x3E38F80", VA = "0x183E3A580")]
		internal static void JBBKNKCPLNK<T>(LGNPDNFGALK reader, KDPPFNAMFML<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A4C0", Offset = "0x3E38EC0", VA = "0x183E3A4C0")]
		internal static void AGNKEKDJGCC<T>(IOIOIIPNAEI writer, KDPPFNAMFML<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A800", Offset = "0x3E39200", VA = "0x183E3A800")]
		internal static void JBBKNKCPLNK<T>(LGNPDNFGALK reader, KDPPFNAMFML<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A2E0", Offset = "0x3E38CE0", VA = "0x183E3A2E0")]
		internal static void AGNKEKDJGCC<T>(IOIOIIPNAEI writer, KDPPFNAMFML<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A660", Offset = "0x3E39060", VA = "0x183E3A660")]
		internal static void JBBKNKCPLNK<T>(LGNPDNFGALK reader, KDPPFNAMFML<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x829EA30", Offset = "0x829D430", VA = "0x18829EA30")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x82A0BE0", Offset = "0x829F5E0", VA = "0x1882A0BE0")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x829E920", Offset = "0x829D320", VA = "0x18829E920")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x82A0A00", Offset = "0x829F400", VA = "0x1882A0A00")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x829EB60", Offset = "0x829D560", VA = "0x18829EB60")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82A0D50", Offset = "0x829F750", VA = "0x1882A0D50")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x829E660", Offset = "0x829D060", VA = "0x18829E660")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x82A0C90", Offset = "0x829F690", VA = "0x1882A0C90")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x829EB00", Offset = "0x829D500", VA = "0x18829EB00")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x82A0F80", Offset = "0x829F980", VA = "0x1882A0F80")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x829EAA0", Offset = "0x829D4A0", VA = "0x18829EAA0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x82A0CF0", Offset = "0x829F6F0", VA = "0x1882A0CF0")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x829E730", Offset = "0x829D130", VA = "0x18829E730")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82A0E60", Offset = "0x829F860", VA = "0x1882A0E60")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x829EBC0", Offset = "0x829D5C0", VA = "0x18829EBC0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x82A0B30", Offset = "0x829F530", VA = "0x1882A0B30")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x829E6C0", Offset = "0x829D0C0", VA = "0x18829E6C0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82A0DB0", Offset = "0x829F7B0", VA = "0x1882A0DB0")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x829E8B0", Offset = "0x829D2B0", VA = "0x18829E8B0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82A0FE0", Offset = "0x829F9E0", VA = "0x1882A0FE0")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A3A0", Offset = "0x3E38DA0", VA = "0x183E3A3A0")]
		internal static void AGNKEKDJGCC<T>(IOIOIIPNAEI writer, KDPPFNAMFML<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A730", Offset = "0x3E39130", VA = "0x183E3A730")]
		internal static void JBBKNKCPLNK<T>(LGNPDNFGALK reader, KDPPFNAMFML<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x829E7A0", Offset = "0x829D1A0", VA = "0x18829E7A0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82A0A70", Offset = "0x829F470", VA = "0x1882A0A70")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x829EC30", Offset = "0x829D630", VA = "0x18829EC30")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82A1090", Offset = "0x829FA90", VA = "0x1882A1090")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x829E9C0", Offset = "0x829D3C0", VA = "0x18829E9C0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<HJPEFODOPFJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x82A0F10", Offset = "0x829F910", VA = "0x1882A0F10")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<HJPEFODOPFJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82820B0", Offset = "0x8280AB0", VA = "0x1882820B0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, KDPPFNAMFML<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8282190", Offset = "0x8280B90", VA = "0x188282190")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, KDPPFNAMFML<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x82820B0", Offset = "0x8280AB0", VA = "0x1882820B0")]
		internal static void AGNKEKDJGCC(IOIOIIPNAEI writer, ACDGIJAKCPP prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8282190", Offset = "0x8280B90", VA = "0x188282190")]
		internal static void JBBKNKCPLNK(LGNPDNFGALK reader, ACDGIJAKCPP prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A8D0", Offset = "0x3E392D0", VA = "0x183E3A8D0")]
		internal static T MAKDNLNKDJI<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82A4C00", Offset = "0x82A3600", VA = "0x1882A4C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x82A61A0", Offset = "0x82A4BA0", VA = "0x1882A61A0")]
		public void MAJNBNPDEEJ(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82A4C30", Offset = "0x82A3630", VA = "0x1882A4C30")]
		private void JJAFPDKIDNH(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x43A9930", Offset = "0x43A8330", VA = "0x1843A9930")]
		private void PLFAJFIIMDF<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x43A95C0", Offset = "0x43A7FC0", VA = "0x1843A95C0")]
		private void LFFAIMMDMLL<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x43A8C40", Offset = "0x43A7640", VA = "0x1843A8C40")]
		private void FBNJEFHGEOP<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			UpgradeFixDisassociatedAnimationData = 164
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82A61B0", Offset = "0x82A4BB0", VA = "0x1882A61B0")]
		public static bool LFGPAKJMMKJ(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum OLAJJKCDJLD
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
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
		[Cpp2IlInjected.Token(Token = "0x400018D")]
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
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
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
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
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
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
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
		[Cpp2IlInjected.Token(Token = "0x4000194")]
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
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[RegisterService(typeof(OOEJNMBPGON), new string[] { "Registry" })]
internal class JDCPALDEENN : OOEJNMBPGON
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Type PLDFNGAOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82A4990", Offset = "0x82A3390", VA = "0x1882A4990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Type[] IIOFBHJMFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x82A4A20", Offset = "0x82A3420", VA = "0x1882A4A20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyDictionary<Type, JBFCMDAPGNI> JPHCEELOILP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x82A4A10", Offset = "0x82A3410", VA = "0x1882A4A10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82A49F0", Offset = "0x82A33F0", VA = "0x1882A49F0", Slot = "7")]
	public void HBJKFKMBDOH(IComponentDefaultRegistration INFKCEHJBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JDCPALDEENN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class DINLOGCEPPL : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class BAJDJFPJJDB : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x82A47E0", Offset = "0x82A31E0", VA = "0x1882A47E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x82A46F0", Offset = "0x82A30F0", VA = "0x1882A46F0")]
		public BAJDJFPJJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x14249B0", Offset = "0x14233B0", VA = "0x1814249B0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 JBOIKIICKBA)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x82A46E0", Offset = "0x82A30E0", VA = "0x1882A46E0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 JBOIKIICKBA, ObjectPrefabType_v1 PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x82A4810", Offset = "0x82A3210", VA = "0x1882A4810")]
	public DINLOGCEPPL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x82A4A30", Offset = "0x82A3430", VA = "0x1882A4A30")]
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
