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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A92C70", Offset = "0x7A92070", VA = "0x187A92C70", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F870", Offset = "0x7A2EC70", VA = "0x187A2F870", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6420", Offset = "0x7AA5820", VA = "0x187AA6420")]
		private void NJKHJLGIPFD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7AA62B0", Offset = "0x7AA56B0", VA = "0x187AA62B0")]
		private void AKOLMCBFEPK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6590", Offset = "0x7AA5990", VA = "0x187AA6590", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA68D0", Offset = "0x7AA5CD0", VA = "0x187AA68D0")]
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
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[CompilerGenerated]
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
	[CompilerGenerated]
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
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[CompilerGenerated]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
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
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v3 : IComponentData
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
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.TypeVersion(2)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v5 : IComponentData
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
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct MJNOIPFNBFI : IComparable<MJNOIPFNBFI>, IEquatable<MJNOIPFNBFI>
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly MJNOIPFNBFI NKGDFHKGFHA;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly MJNOIPFNBFI ANPECFOMIHE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MJNOIPFNBFI KGOBMPFNJJA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MJNOIPFNBFI BACPMJHEPNN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MJNOIPFNBFI MMFOBEAADAG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly MJNOIPFNBFI PKMFJKFLGMP;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly int COPLIEINKOF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PINFDPDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type LLFNFBAMNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A93300", Offset = "0x7A92700", VA = "0x187A93300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BGMAPKEKIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A93090", Offset = "0x7A92490", VA = "0x187A93090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JFMOMNOKICG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A93820", Offset = "0x7A92C20", VA = "0x187A93820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type MBOPACPPPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A93590", Offset = "0x7A92990", VA = "0x187A93590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HIJAIMBACAP BBDBFAPIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A92D00", Offset = "0x7A92100", VA = "0x187A92D00")]
		get
		{
			return default(HIJAIMBACAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HIMIFJBKBBI OJDHIFPEJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A92E90", Offset = "0x7A92290", VA = "0x187A92E90")]
		get
		{
			return default(HIMIFJBKBBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KGBMKFEGGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7A93540", Offset = "0x7A92940", VA = "0x187A93540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AHEIIPGLJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A937D0", Offset = "0x7A92BD0", VA = "0x187A937D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DJCPBMPLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7A93670", Offset = "0x7A92A70", VA = "0x187A93670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MACKFICDHML
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7A933E0", Offset = "0x7A927E0", VA = "0x187A933E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0")]
	public MJNOIPFNBFI(int COPLIEINKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A931D0", Offset = "0x7A925D0", VA = "0x187A931D0", Slot = "5")]
	public bool Equals(MJNOIPFNBFI DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A93250", Offset = "0x7A92650", VA = "0x187A93250", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A93960", Offset = "0x7A92D60", VA = "0x187A93960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4C90AE0", Offset = "0x4C8FEE0", VA = "0x184C90AE0", Slot = "4")]
	public int CompareTo(MJNOIPFNBFI DMMBOHMLHLF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct CDEDBEOJDKG<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int COPLIEINKOF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private MJNOIPFNBFI NFEEEFBAPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
		get
		{
			return default(MJNOIPFNBFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0")]
	internal CDEDBEOJDKG(int COPLIEINKOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAD20", Offset = "0x1DDA120", VA = "0x181DDAD20")]
	public static MJNOIPFNBFI HIHFKEJHDAH(CDEDBEOJDKG<T> EKNPKHOHCLO)
	{
		return default(MJNOIPFNBFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6468400", Offset = "0x6467800", VA = "0x186468400", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6468E30", Offset = "0x6468230", VA = "0x186468E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7A887D0", Offset = "0x7A87BD0", VA = "0x187A887D0")]
		public static (long, string, string)[] NMMFMIIGPNG(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : KBPELAJANCP, KJDNBBHEGIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly DeferredEntityCommandBuffer decb;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7A925D0", Offset = "0x7A919D0", VA = "0x187A925D0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7A92690", Offset = "0x7A91A90", VA = "0x187A92690", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7A92740", Offset = "0x7A91B40", VA = "0x187A92740")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Dictionary<Type, DPAGKMMLOHL> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Dictionary<Type, DPAGKMMLOHL> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7A92BA0", Offset = "0x7A91FA0", VA = "0x187A92BA0")]
		public static IReadOnlyDictionary<Type, DPAGKMMLOHL> NJMIOFELLAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7A92AE0", Offset = "0x7A91EE0", VA = "0x187A92AE0")]
		private Dictionary<Type, DPAGKMMLOHL> KECNLMAOALC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7A92790", Offset = "0x7A91B90", VA = "0x187A92790")]
		private void GGMFEOFONHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7A92BF0", Offset = "0x7A91FF0", VA = "0x187A92BF0")]
		private readonly void OALAFOJHKIK(Type interfaceType, DPAGKMMLOHL implementationType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7A93D00", Offset = "0x7A93100", VA = "0x187A93D00")]
		public static Type[] IHJBPGGEHPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A93D60", Offset = "0x7A93160", VA = "0x187A93D60")]
		private static void KECNLMAOALC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v3 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		SuppressCollision = 16384,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public class SandboxDeformableShapeDefaults : NJPPICEMDOM, KBPELAJANCP, KJDNBBHEGIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15569F0", Offset = "0x1555DF0", VA = "0x1815569F0", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x15569B0", Offset = "0x1555DB0", VA = "0x1815569B0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4DD0", Offset = "0x7AA41D0", VA = "0x187AA4DD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4C80", Offset = "0x7AA4080", VA = "0x187AA4C80", Slot = "4")]
		public void GEKINDBKALD(KJDNBBHEGIL networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public SandboxDeformableShapeDefaults()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
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
	[Cpp2IlInjected.Token(Token = "0x2000032")]
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
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public class R2SandboxDeformableShapeNetworkData : KBPELAJANCP, KJDNBBHEGIL, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private HMFHDNOJHBA service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7AA48D0", Offset = "0x7AA3CD0", VA = "0x187AA48D0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4A70", Offset = "0x7AA3E70", VA = "0x187AA4A70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4BA0", Offset = "0x7AA3FA0", VA = "0x187AA4BA0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7AA47F0", Offset = "0x7AA3BF0", VA = "0x187AA47F0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7AA49B0", Offset = "0x7AA3DB0", VA = "0x187AA49B0", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4AE0", Offset = "0x7AA3EE0", VA = "0x187AA4AE0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4860", Offset = "0x7AA3C60", VA = "0x187AA4860", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4940", Offset = "0x7AA3D40", VA = "0x187AA4940", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4829B80", Offset = "0x4828F80", VA = "0x184829B80")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, HMFHDNOJHBA networkDataService)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public struct R2SandboxDeformableShapeNetworkData_Scale : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public float3 value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[R2Only]
		public static readonly CDEDBEOJDKG<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[R2Only]
		public static readonly CDEDBEOJDKG<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[R2Only]
		public static readonly CDEDBEOJDKG<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[R2Only]
		[IsBuffer]
		public static readonly CDEDBEOJDKG<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly CDEDBEOJDKG<IBBKNBAMBLM> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		[IsBuffer]
		public static readonly CDEDBEOJDKG<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly CDEDBEOJDKG<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[IsBuffer]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[R2Only]
		public static readonly CDEDBEOJDKG<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		public static readonly CDEDBEOJDKG<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		public static readonly CDEDBEOJDKG<HDBJOILNDBL> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly CDEDBEOJDKG<HDPGBHNAJEG> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly CDEDBEOJDKG<int> CostumePieceSlotIndex_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly CDEDBEOJDKG<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly CDEDBEOJDKG<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly CDEDBEOJDKG<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly CDEDBEOJDKG<NKCLOIEHICF> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		[IsBuffer]
		public static readonly CDEDBEOJDKG<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly CDEDBEOJDKG<CCHPAHMKDGB> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		public static readonly CDEDBEOJDKG<HKOELKKOBKF> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly CDEDBEOJDKG<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly CDEDBEOJDKG<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly CDEDBEOJDKG<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly CDEDBEOJDKG<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly CDEDBEOJDKG<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly CDEDBEOJDKG<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly CDEDBEOJDKG<ILMHGLFHNPH> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly CDEDBEOJDKG<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly CDEDBEOJDKG<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly CDEDBEOJDKG<IOEIEABAMHG> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly CDEDBEOJDKG<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly CDEDBEOJDKG<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(FLGPNLEOEBD))]
		public static readonly CDEDBEOJDKG<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly CDEDBEOJDKG<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly CDEDBEOJDKG<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly CDEDBEOJDKG<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly CDEDBEOJDKG<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly CDEDBEOJDKG<FCEFPHHJOJI> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly CDEDBEOJDKG<KMGOLLBAPBK> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly CDEDBEOJDKG<GBGIEAGCPDA> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly CDEDBEOJDKG<HDPGBHNAJEG> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly CDEDBEOJDKG<GIBBAOGDFDH> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> CostumePieceParentCostume_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[IsBuffer]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly CDEDBEOJDKG<AJDJHPALEJE> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly CDEDBEOJDKG<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly CDEDBEOJDKG<HGIEICHEMDE> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly CDEDBEOJDKG<JDJIHEDDMLO> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[IsBuffer]
		[R2Only]
		public static readonly CDEDBEOJDKG<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly CDEDBEOJDKG<PKKKHDDPEDA> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly CDEDBEOJDKG<MIHKMKGMLNJ> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly CDEDBEOJDKG<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly CDEDBEOJDKG<BKFLGFMIBLE> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly CDEDBEOJDKG<DEABANMHDFK> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly CDEDBEOJDKG<DIENJDEGOID> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly CDEDBEOJDKG<OJIHJBJHBLG> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly CDEDBEOJDKG<LBLHMKOBDAM> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[RegisterService(typeof(CBOPIKFLHCF), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : CBOPIKFLHCF, EBFJKMABEIO, BAEPLJFAONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCDBA30", Offset = "0xCDAE30", VA = "0x180CDBA30", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xD8C040", Offset = "0xD8B440", VA = "0x180D8C040", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xE89D90", Offset = "0xE89190", VA = "0x180E89D90", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xE38A60", Offset = "0xE37E60", VA = "0x180E38A60", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9CD840", Offset = "0x9CCC40", VA = "0x1809CD840", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9CD830", Offset = "0x9CCC30", VA = "0x1809CD830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9D5B60", Offset = "0x9D4F60", VA = "0x1809D5B60", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C00", Offset = "0x9D5000", VA = "0x1809D5C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public HIJAIMBACAP[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AB0", Offset = "0x9D4EB0", VA = "0x1809D5AB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AC0", Offset = "0x9D4EC0", VA = "0x1809D5AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, HIMIFJBKBBI> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C70", Offset = "0x9D5070", VA = "0x1809D5C70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C20", Offset = "0x9D5020", VA = "0x1809D5C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2D459B0", Offset = "0x2D44DB0", VA = "0x182D459B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7A96420", Offset = "0x7A95820", VA = "0x187A96420", Slot = "14")]
		public void CGHIEKBEDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7A96390", Offset = "0x7A95790", VA = "0x187A96390", Slot = "15")]
		public void AECAJPPNPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7A96430", Offset = "0x7A95830", VA = "0x187A96430")]
		private void OCGOJKBILPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA40F0", Offset = "0x7AA34F0", VA = "0x187AA40F0")]
		public static void KFDICCELKBP(KHCMELHEBFG writer, MJNOIPFNBFI property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2020", Offset = "0x7AA1420", VA = "0x187AA2020")]
		public static void GINOKMJKBGA(HGBEOPOJINF reader, MJNOIPFNBFI property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2040", Offset = "0x7AA1440", VA = "0x187AA2040")]
		private static void HMNKHBABNLO(KHCMELHEBFG writer, MJNOIPFNBFI property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0930", Offset = "0x7A9FD30", VA = "0x187AA0930")]
		private static void BPMKFGANAHJ(HGBEOPOJINF reader, MJNOIPFNBFI property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3889220", Offset = "0x3888620", VA = "0x183889220")]
		internal static void PEGKBLBFNLH<T>(KHCMELHEBFG writer, CDEDBEOJDKG<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3888DF0", Offset = "0x38881F0", VA = "0x183888DF0")]
		internal static void ILOIKAMJPOD<T>(HGBEOPOJINF reader, CDEDBEOJDKG<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3889570", Offset = "0x3888970", VA = "0x183889570")]
		internal static void PEGKBLBFNLH<T>(KHCMELHEBFG writer, CDEDBEOJDKG<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x38890B0", Offset = "0x38884B0", VA = "0x1838890B0")]
		internal static void ILOIKAMJPOD<T>(HGBEOPOJINF reader, CDEDBEOJDKG<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3889340", Offset = "0x3888740", VA = "0x183889340")]
		internal static void PEGKBLBFNLH<T>(KHCMELHEBFG writer, CDEDBEOJDKG<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3888EE0", Offset = "0x38882E0", VA = "0x183888EE0")]
		internal static void ILOIKAMJPOD<T>(HGBEOPOJINF reader, CDEDBEOJDKG<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4220", Offset = "0x7AA3620", VA = "0x187AA4220")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3E00", Offset = "0x7AA3200", VA = "0x187AA3E00")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AA45A0", Offset = "0x7AA39A0", VA = "0x187AA45A0")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3F60", Offset = "0x7AA3360", VA = "0x187AA3F60")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4540", Offset = "0x7AA3940", VA = "0x187AA4540")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4090", Offset = "0x7AA3490", VA = "0x187AA4090")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4790", Offset = "0x7AA3B90", VA = "0x187AA4790")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3A70", Offset = "0x7AA2E70", VA = "0x187AA3A70")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA44E0", Offset = "0x7AA38E0", VA = "0x187AA44E0")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3B80", Offset = "0x7AA2F80", VA = "0x187AA3B80")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4410", Offset = "0x7AA3810", VA = "0x187AA4410")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3A10", Offset = "0x7AA2E10", VA = "0x187AA3A10")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4640", Offset = "0x7AA3A40", VA = "0x187AA4640")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3AD0", Offset = "0x7AA2ED0", VA = "0x187AA3AD0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4470", Offset = "0x7AA3870", VA = "0x187AA4470")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3EB0", Offset = "0x7AA32B0", VA = "0x187AA3EB0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7AA46B0", Offset = "0x7AA3AB0", VA = "0x187AA46B0")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3CA0", Offset = "0x7AA30A0", VA = "0x187AA3CA0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4290", Offset = "0x7AA3690", VA = "0x187AA4290")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3D50", Offset = "0x7AA3150", VA = "0x187AA3D50")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3889420", Offset = "0x3888820", VA = "0x183889420")]
		internal static void PEGKBLBFNLH<T>(KHCMELHEBFG writer, CDEDBEOJDKG<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3888FC0", Offset = "0x38883C0", VA = "0x183888FC0")]
		internal static void ILOIKAMJPOD<T>(HGBEOPOJINF reader, CDEDBEOJDKG<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4110", Offset = "0x7AA3510", VA = "0x187AA4110")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3FD0", Offset = "0x7AA33D0", VA = "0x187AA3FD0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4300", Offset = "0x7AA3700", VA = "0x187AA4300")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3BE0", Offset = "0x7AA2FE0", VA = "0x187AA3BE0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4720", Offset = "0x7AA3B20", VA = "0x187AA4720")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<HDPGBHNAJEG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7AA39A0", Offset = "0x7AA2DA0", VA = "0x187AA39A0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<HDPGBHNAJEG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7A886F0", Offset = "0x7A87AF0", VA = "0x187A886F0")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, CDEDBEOJDKG<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7A882A0", Offset = "0x7A876A0", VA = "0x187A882A0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, CDEDBEOJDKG<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7A886F0", Offset = "0x7A87AF0", VA = "0x187A886F0")]
		internal static void PEGKBLBFNLH(KHCMELHEBFG writer, MJNOIPFNBFI prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A882A0", Offset = "0x7A876A0", VA = "0x187A882A0")]
		internal static void ILOIKAMJPOD(HGBEOPOJINF reader, MJNOIPFNBFI prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x38891A0", Offset = "0x38885A0", VA = "0x1838891A0")]
		internal static T MFOFEAMDGFN<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4E30", Offset = "0x7AA4230", VA = "0x187AA4E30")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7AA62A0", Offset = "0x7AA56A0", VA = "0x187AA62A0")]
		public void KECNLMAOALC(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5090", Offset = "0x7AA4490", VA = "0x187AA5090")]
		private void CJIKOLLCLMJ(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9110", Offset = "0x3DC8510", VA = "0x183DC9110")]
		private void BFJFACGLILI<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD27F0", Offset = "0x3DD1BF0", VA = "0x183DD27F0")]
		private void CNJLLALCENH<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2BB0", Offset = "0x3DD1FB0", VA = "0x183DD2BB0")]
		private void NFJKBCEBFGH<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			UpgradeRemovePersistedPivots = 152
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7020", Offset = "0x7AA6420", VA = "0x187AA7020")]
		public static bool IBKMAJDALBD(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum CBLEGFCEEBA
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[CompilerGenerated]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[RegisterService(typeof(IEJNOEEHCDE), new string[] { "Registry" })]
internal class MDJHAJMGFHI : IEJNOEEHCDE
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type EJHBCHLNELP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6DF0", Offset = "0x7AA61F0", VA = "0x187AA6DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] PABGBKLCLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6DE0", Offset = "0x7AA61E0", VA = "0x187AA6DE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, DPAGKMMLOHL> OBBNNJGAKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6DB0", Offset = "0x7AA61B0", VA = "0x187AA6DB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6DC0", Offset = "0x7AA61C0", VA = "0x187AA6DC0", Slot = "7")]
	public void HKBLDKGOPGD(IComponentDefaultRegistration OEJAHKGDBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MDJHAJMGFHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class HMMIOFJIABJ : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class FCABBICCDCH : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6C00", Offset = "0x7AA6000", VA = "0x187AA6C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6B10", Offset = "0x7AA5F10", VA = "0x187AA6B10")]
		public FCABBICCDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x20EBB50", Offset = "0x20EAF50", VA = "0x1820EBB50", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 INELJPKBMLP)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6B00", Offset = "0x7AA5F00", VA = "0x187AA6B00", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 INELJPKBMLP, ObjectPrefabType_v1 OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6C30", Offset = "0x7AA6030", VA = "0x187AA6C30")]
	public HMMIOFJIABJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6E50", Offset = "0x7AA6250", VA = "0x187AA6E50")]
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
