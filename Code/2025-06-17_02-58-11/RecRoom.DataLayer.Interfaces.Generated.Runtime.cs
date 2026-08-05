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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CDE250", Offset = "0x7CDCC50", VA = "0x187CDE250", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21CF550", Offset = "0x21CDF50", VA = "0x1821CF550", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1180", Offset = "0x7CEFB80", VA = "0x187CF1180")]
		private void LNHKNJMKPNK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1010", Offset = "0x7CEFA10", VA = "0x187CF1010")]
		private void LEGOBPIAIHA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CF12F0", Offset = "0x7CEFCF0", VA = "0x187CF12F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1630", Offset = "0x7CF0030", VA = "0x187CF1630")]
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
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(2)]
		public FixedString64Bytes AICodeGenId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
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
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ObjectPolicyData_v5 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct CODIAJPBCGJ : IComparable<CODIAJPBCGJ>, IEquatable<CODIAJPBCGJ>
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly CODIAJPBCGJ HLCKODHBFKH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly CODIAJPBCGJ LGHKECOEALP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly CODIAJPBCGJ EINKGMCHFFD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly CODIAJPBCGJ PKNDMAOPLOD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly CODIAJPBCGJ IJPHMANBDHE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly CODIAJPBCGJ BAIICIIPILK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly int MNFHMLCLFEB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type CPOIPEOHOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3840", Offset = "0x7CD2240", VA = "0x187CD3840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LEHDAHFOAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CD32B0", Offset = "0x7CD1CB0", VA = "0x187CD32B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HMADEMCLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3970", Offset = "0x7CD2370", VA = "0x187CD3970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type JEAHNPAGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CD31D0", Offset = "0x7CD1BD0", VA = "0x187CD31D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MJBEOABMHFK FBANHEHOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CD36C0", Offset = "0x7CD20C0", VA = "0x187CD36C0")]
		get
		{
			return default(MJBEOABMHFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FIMBBFBOMGI OCKPAMGNNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2FD0", Offset = "0x7CD19D0", VA = "0x187CD2FD0")]
		get
		{
			return default(FIMBBFBOMGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JKBFCEPNBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CD33F0", Offset = "0x7CD1DF0", VA = "0x187CD33F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FECHIIACAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3920", Offset = "0x7CD2320", VA = "0x187CD3920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MOPEEAAPFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3570", Offset = "0x7CD1F70", VA = "0x187CD3570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BLECPBBNFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2E80", Offset = "0x7CD1880", VA = "0x187CD2E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
	public CODIAJPBCGJ(int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CD34F0", Offset = "0x7CD1EF0", VA = "0x187CD34F0", Slot = "5")]
	public bool Equals(CODIAJPBCGJ NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3440", Offset = "0x7CD1E40", VA = "0x187CD3440", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3AB0", Offset = "0x7CD24B0", VA = "0x187CD3AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x469ADA0", Offset = "0x46997A0", VA = "0x18469ADA0", Slot = "4")]
	public int CompareTo(CODIAJPBCGJ NDNHELJMDCG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct KEHPDPPOPNF<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly int MNFHMLCLFEB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CODIAJPBCGJ GEINCIDDCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930")]
		get
		{
			return default(CODIAJPBCGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
	internal KEHPDPPOPNF(int MNFHMLCLFEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB340", Offset = "0x1FC9D40", VA = "0x181FCB340")]
	public static CODIAJPBCGJ HNONLACFBHP(KEHPDPPOPNF<T> MLCOAPMDJJE)
	{
		return default(CODIAJPBCGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51B17B0", Offset = "0x51B01B0", VA = "0x1851B17B0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x51B2060", Offset = "0x51B0A60", VA = "0x1851B2060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3E40", Offset = "0x7CD2840", VA = "0x187CD3E40")]
		public static (long, string, string)[] BFNDALBBBNI(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : AEODHIBIJCB, LHJDKIFHNCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly DeferredEntityCommandBuffer decb;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7CDDC70", Offset = "0x7CDC670", VA = "0x187CDDC70", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7CDDBC0", Offset = "0x7CDC5C0", VA = "0x187CDDBC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7CDDD30", Offset = "0x7CDC730", VA = "0x187CDDD30")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Dictionary<Type, ECOCKJPFILA> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<Type, ECOCKJPFILA> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7CDDE40", Offset = "0x7CDC840", VA = "0x187CDDE40")]
		public static IReadOnlyDictionary<Type, ECOCKJPFILA> GDLBNDGHPEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7CDDD80", Offset = "0x7CDC780", VA = "0x187CDDD80")]
		private Dictionary<Type, ECOCKJPFILA> EPIAMCEAEFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7CDDE90", Offset = "0x7CDC890", VA = "0x187CDDE90")]
		private void HLPDMKJLMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7CDE1D0", Offset = "0x7CDCBD0", VA = "0x187CDE1D0")]
		private readonly void PCAOJOPLFMC(Type interfaceType, ECOCKJPFILA implementationType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7CE0120", Offset = "0x7CDEB20", VA = "0x187CE0120")]
		public static Type[] OPGIJEJBHLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7CDE2E0", Offset = "0x7CDCCE0", VA = "0x187CDE2E0")]
		private static void EPIAMCEAEFP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v3 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		SuppressCollision = 16384,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	public class SandboxDeformableShapeDefaults : NIBNOJLKLIC, AEODHIBIJCB, LHJDKIFHNCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x112DAE0", Offset = "0x112C4E0", VA = "0x18112DAE0", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x173F650", Offset = "0x173E050", VA = "0x18173F650", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF9C0", Offset = "0x7CEE3C0", VA = "0x187CEF9C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF880", Offset = "0x7CEE280", VA = "0x187CEF880", Slot = "4")]
		public void AHEPFHGKECD(LHJDKIFHNCB networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public interface ISandboxDeformableShapeNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public interface ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	public class R2SandboxDeformableShapeNetworkData : FKNOBPCLBKL, LHJDKIFHNCB, AEODHIBIJCB, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private EJMKFKADLAO service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF3F0", Offset = "0x7CEDDF0", VA = "0x187CEF3F0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF540", Offset = "0x7CEDF40", VA = "0x187CEF540", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF620", Offset = "0x7CEE020", VA = "0x187CEF620", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF4D0", Offset = "0x7CEDED0", VA = "0x187CEF4D0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF750", Offset = "0x7CEE150", VA = "0x187CEF750", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF690", Offset = "0x7CEE090", VA = "0x187CEF690", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF5B0", Offset = "0x7CEDFB0", VA = "0x187CEF5B0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF460", Offset = "0x7CEDE60", VA = "0x187CEF460", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4BD5420", Offset = "0x4BD3E20", VA = "0x184BD5420")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, EJMKFKADLAO networkDataService)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Scale : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public float3 value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[R2Only]
		public static readonly KEHPDPPOPNF<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly KEHPDPPOPNF<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly KEHPDPPOPNF<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[IsBuffer]
		[R2Only]
		public static readonly KEHPDPPOPNF<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[R2Only]
		public static readonly KEHPDPPOPNF<HIHPIEHKPPJ> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[IsBuffer]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		public static readonly KEHPDPPOPNF<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		[IsBuffer]
		public static readonly KEHPDPPOPNF<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[R2Only]
		public static readonly KEHPDPPOPNF<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly KEHPDPPOPNF<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly KEHPDPPOPNF<JHEADEDJLCG> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly KEHPDPPOPNF<GOIIOPJIELK> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly KEHPDPPOPNF<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly KEHPDPPOPNF<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly KEHPDPPOPNF<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly KEHPDPPOPNF<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly KEHPDPPOPNF<CPJEMKLLPAJ> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		[IsBuffer]
		public static readonly KEHPDPPOPNF<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly KEHPDPPOPNF<DMOLGJAGICF> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly KEHPDPPOPNF<AMKAGOPDJAP> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly KEHPDPPOPNF<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly KEHPDPPOPNF<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly KEHPDPPOPNF<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly KEHPDPPOPNF<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly KEHPDPPOPNF<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly KEHPDPPOPNF<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly KEHPDPPOPNF<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly KEHPDPPOPNF<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly KEHPDPPOPNF<DNNBJCBPMAN> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly KEHPDPPOPNF<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly KEHPDPPOPNF<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly KEHPDPPOPNF<JBJNHLKNCIO> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly KEHPDPPOPNF<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly KEHPDPPOPNF<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ELPJMKDHEMM))]
		public static readonly KEHPDPPOPNF<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly KEHPDPPOPNF<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly KEHPDPPOPNF<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly KEHPDPPOPNF<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly KEHPDPPOPNF<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly KEHPDPPOPNF<EALCMIHKJHP> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly KEHPDPPOPNF<CFDCEGNMEPB> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly KEHPDPPOPNF<IEMCFPCKHGN> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly KEHPDPPOPNF<GOIIOPJIELK> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly KEHPDPPOPNF<DCGEINBBHPK> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		[IsBuffer]
		public static readonly KEHPDPPOPNF<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly KEHPDPPOPNF<KIMDEAGCPNF> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly KEHPDPPOPNF<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly KEHPDPPOPNF<NBMBEAJJMME> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly KEHPDPPOPNF<OJKENEOOCCB> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[IsBuffer]
		[R2Only]
		public static readonly KEHPDPPOPNF<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly KEHPDPPOPNF<JEMODOMIDJB> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly KEHPDPPOPNF<HHLLLLGMKPE> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly KEHPDPPOPNF<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly KEHPDPPOPNF<MCOMBIBDPFL> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly KEHPDPPOPNF<KFCPMNIEOEG> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly KEHPDPPOPNF<BILGONJLGPF> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly KEHPDPPOPNF<EPPCBLKIBIH> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly KEHPDPPOPNF<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly KEHPDPPOPNF<HCMBDPHADFA> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE09F0", Offset = "0x7CDF3F0", VA = "0x187CE09F0")]
		public static bool NLKDPFBBGBD(CODIAJPBCGJ property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	[RegisterService(typeof(KFGLDNCJBHM), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : KFGLDNCJBHM, MJHCLHMDOAB, IIAKOCKOOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xDCB0C0", Offset = "0xDC9AC0", VA = "0x180DCB0C0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xDC95B0", Offset = "0xDC7FB0", VA = "0x180DC95B0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xE5F9A0", Offset = "0xE5E3A0", VA = "0x180E5F9A0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xF7F820", Offset = "0xF7E220", VA = "0x180F7F820", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xF21F60", Offset = "0xF20960", VA = "0x180F21F60", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA17C40", Offset = "0xA16640", VA = "0x180A17C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA09160", Offset = "0xA07B60", VA = "0x180A09160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MJBEOABMHFK[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA09280", Offset = "0xA07C80", VA = "0x180A09280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, FIMBBFBOMGI> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA09300", Offset = "0xA07D00", VA = "0x180A09300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2FACAD0", Offset = "0x2FAB4D0", VA = "0x182FACAD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB620", Offset = "0x7CEA020", VA = "0x187CEB620", Slot = "14")]
		public void PIJDKGLEIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB590", Offset = "0x7CE9F90", VA = "0x187CEB590", Slot = "15")]
		public void NEAHCMEBFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE0AB0", Offset = "0x7CDF4B0", VA = "0x187CE0AB0")]
		private void JFEIBBBDBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB630", Offset = "0x7CEA030", VA = "0x187CEB630")]
		public static void BGDDMHPDKHA(CGCGBLNHPDH writer, CODIAJPBCGJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE5A0", Offset = "0x7CECFA0", VA = "0x187CEE5A0")]
		public static void LKIJJKPJEME(LNPLFLMIBJH reader, CODIAJPBCGJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB650", Offset = "0x7CEA050", VA = "0x187CEB650")]
		private static void DIDBFGCBCLJ(CGCGBLNHPDH writer, CODIAJPBCGJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF10", Offset = "0x7CEB910", VA = "0x187CECF10")]
		private static void EFPCJGGKKLO(LNPLFLMIBJH reader, CODIAJPBCGJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE6C0", Offset = "0x3BED0C0", VA = "0x183BEE6C0")]
		internal static void PGPOMLMDCHO<T>(CGCGBLNHPDH writer, KEHPDPPOPNF<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE370", Offset = "0x3BECD70", VA = "0x183BEE370")]
		internal static void PGEPBAPICDN<T>(LNPLFLMIBJH reader, KEHPDPPOPNF<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE9B0", Offset = "0x3BED3B0", VA = "0x183BEE9B0")]
		internal static void PGPOMLMDCHO<T>(CGCGBLNHPDH writer, KEHPDPPOPNF<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE5F0", Offset = "0x3BECFF0", VA = "0x183BEE5F0")]
		internal static void PGEPBAPICDN<T>(LNPLFLMIBJH reader, KEHPDPPOPNF<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE7D0", Offset = "0x3BED1D0", VA = "0x183BEE7D0")]
		internal static void PGPOMLMDCHO<T>(CGCGBLNHPDH writer, KEHPDPPOPNF<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE450", Offset = "0x3BECE50", VA = "0x183BEE450")]
		internal static void PGEPBAPICDN<T>(LNPLFLMIBJH reader, KEHPDPPOPNF<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEE90", Offset = "0x7CED890", VA = "0x187CEEE90")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE670", Offset = "0x7CED070", VA = "0x187CEE670")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF220", Offset = "0x7CEDC20", VA = "0x187CEF220")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE8F0", Offset = "0x7CED2F0", VA = "0x187CEE8F0")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF2C0", Offset = "0x7CEDCC0", VA = "0x187CEF2C0")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEA90", Offset = "0x7CED490", VA = "0x187CEEA90")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEF00", Offset = "0x7CED900", VA = "0x187CEEF00")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEA30", Offset = "0x7CED430", VA = "0x187CEEA30")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF320", Offset = "0x7CEDD20", VA = "0x187CEF320")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE960", Offset = "0x7CED360", VA = "0x187CEE960")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEF60", Offset = "0x7CED960", VA = "0x187CEEF60")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE720", Offset = "0x7CED120", VA = "0x187CEE720")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEE20", Offset = "0x7CED820", VA = "0x187CEEE20")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE840", Offset = "0x7CED240", VA = "0x187CEE840")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEFC0", Offset = "0x7CED9C0", VA = "0x187CEEFC0")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEC60", Offset = "0x7CED660", VA = "0x187CEEC60")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF030", Offset = "0x7CEDA30", VA = "0x187CEF030")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEAF0", Offset = "0x7CED4F0", VA = "0x187CEEAF0")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF1B0", Offset = "0x7CEDBB0", VA = "0x187CEF1B0")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE5C0", Offset = "0x7CECFC0", VA = "0x187CEE5C0")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE890", Offset = "0x3BED290", VA = "0x183BEE890")]
		internal static void PGPOMLMDCHO<T>(CGCGBLNHPDH writer, KEHPDPPOPNF<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE520", Offset = "0x3BECF20", VA = "0x183BEE520")]
		internal static void PGEPBAPICDN<T>(LNPLFLMIBJH reader, KEHPDPPOPNF<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7CEED10", Offset = "0x7CED710", VA = "0x187CEED10")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE780", Offset = "0x7CED180", VA = "0x187CEE780")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF0A0", Offset = "0x7CEDAA0", VA = "0x187CEF0A0")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEBA0", Offset = "0x7CED5A0", VA = "0x187CEEBA0")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF380", Offset = "0x7CEDD80", VA = "0x187CEF380")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<GOIIOPJIELK> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE9C0", Offset = "0x7CED3C0", VA = "0x187CEE9C0")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<GOIIOPJIELK> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2DA0", Offset = "0x7CD17A0", VA = "0x187CD2DA0")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, KEHPDPPOPNF<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2A50", Offset = "0x7CD1450", VA = "0x187CD2A50")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, KEHPDPPOPNF<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2DA0", Offset = "0x7CD17A0", VA = "0x187CD2DA0")]
		internal static void PGPOMLMDCHO(CGCGBLNHPDH writer, CODIAJPBCGJ prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2A50", Offset = "0x7CD1450", VA = "0x187CD2A50")]
		internal static void PGEPBAPICDN(LNPLFLMIBJH reader, CODIAJPBCGJ prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE300", Offset = "0x3BECD00", VA = "0x183BEE300")]
		internal static T DNFKPGNIJOD<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFA20", Offset = "0x7CEE420", VA = "0x187CEFA20")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFC70", Offset = "0x7CEE670", VA = "0x187CEFC70")]
		public void EPIAMCEAEFP(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFC80", Offset = "0x7CEE680", VA = "0x187CEFC80")]
		private void FPAPPJDDBGB(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x416CA00", Offset = "0x416B400", VA = "0x18416CA00")]
		private void BJJPBMJFHEG<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4175DD0", Offset = "0x41747D0", VA = "0x184175DD0")]
		private void DKGOEAKFBMI<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4176140", Offset = "0x4174B40", VA = "0x184176140")]
		private void FGPMCDAIBFP<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			UpgradeFixDisassociatedAnimationData = 164
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1D80", Offset = "0x7CF0780", VA = "0x187CF1D80")]
		public static bool KLDCPOBEMJD(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum COCCEECMCIO
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[CompilerGenerated]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	internal struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterService(typeof(BMJCGOLKDKB), new string[] { "Registry" })]
internal class AHFIBMNNPLP : BMJCGOLKDKB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type FLGHJJFMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1870", Offset = "0x7CF0270", VA = "0x187CF1870", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] PCFMNFIGDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7CF18D0", Offset = "0x7CF02D0", VA = "0x187CF18D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, ECOCKJPFILA> IFPHFPEFKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1860", Offset = "0x7CF0260", VA = "0x187CF1860", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7CF18E0", Offset = "0x7CF02E0", VA = "0x187CF18E0", Slot = "7")]
	public void HFFKPKCFFEB(IComponentDefaultRegistration KHOJGJNAHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public AHFIBMNNPLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class HJJJOBLGOFK : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class BBMJEEAGBMM : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7CF1A00", Offset = "0x7CF0400", VA = "0x187CF1A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1910", Offset = "0x7CF0310", VA = "0x187CF1910")]
		public BBMJEEAGBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x22F87B0", Offset = "0x22F71B0", VA = "0x1822F87B0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 DJGDNAKMFCE)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1900", Offset = "0x7CF0300", VA = "0x187CF1900", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 DJGDNAKMFCE, ObjectPrefabType_v1 PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1A30", Offset = "0x7CF0430", VA = "0x187CF1A30")]
	public HJJJOBLGOFK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1BB0", Offset = "0x7CF05B0", VA = "0x187CF1BB0")]
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
