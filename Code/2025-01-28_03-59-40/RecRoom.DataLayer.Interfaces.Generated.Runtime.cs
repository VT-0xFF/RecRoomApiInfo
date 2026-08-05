using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
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
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71628E0", Offset = "0x7161AE0", VA = "0x1871628E0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71D20F0", Offset = "0x71D12F0", VA = "0x1871D20F0")]
		private void GAEACHOPMAB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71D2260", Offset = "0x71D1460", VA = "0x1871D2260")]
		private void KHHBPMJNGGK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71D23D0", Offset = "0x71D15D0", VA = "0x1871D23D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71D2700", Offset = "0x71D1900", VA = "0x1871D2700")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct SerializedDataLayerVersionData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Field(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v2 : IComponentData
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
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
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
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v5 : IComponentData
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
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GFCAKFAODMC : IComparable<GFCAKFAODMC>, IEquatable<GFCAKFAODMC>
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly GFCAKFAODMC EPGHELDKPDG;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly GFCAKFAODMC MDFEGOIPNFL;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GFCAKFAODMC IEAEFBBFIPL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly GFCAKFAODMC OOLJOJNOCFD;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GFCAKFAODMC FAKCOCOEJIJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly GFCAKFAODMC NPIAHHJFPDH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly int CPLNODNGKGB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type AMLJAIEJCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71C1390", Offset = "0x71C0590", VA = "0x1871C1390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LHEECLLPINN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71C1670", Offset = "0x71C0870", VA = "0x1871C1670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ININOACGFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71C1900", Offset = "0x71C0B00", VA = "0x1871C1900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type OMOBGGNJDCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71C1460", Offset = "0x71C0660", VA = "0x1871C1460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JOLMFKMLFOA GGLJGJDNJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71C17A0", Offset = "0x71C09A0", VA = "0x1871C17A0")]
		get
		{
			return default(JOLMFKMLFOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FPBDBMMHLFB JNMLAADCGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71C11D0", Offset = "0x71C03D0", VA = "0x1871C11D0")]
		get
		{
			return default(FPBDBMMHLFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CFFLGCFGLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71C0ED0", Offset = "0x71C00D0", VA = "0x1871C0ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BDHHHKCDJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71C1040", Offset = "0x71C0240", VA = "0x1871C1040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EFLOOOCIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71C1090", Offset = "0x71C0290", VA = "0x1871C1090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KOOGENLINDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71C1530", Offset = "0x71C0730", VA = "0x1871C1530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
	public GFCAKFAODMC(int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71C0F20", Offset = "0x71C0120", VA = "0x1871C0F20", Slot = "5")]
	public bool Equals(GFCAKFAODMC JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71C0FA0", Offset = "0x71C01A0", VA = "0x1871C0FA0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71C1A30", Offset = "0x71C0C30", VA = "0x1871C1A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4537AE0", Offset = "0x4536CE0", VA = "0x184537AE0", Slot = "4")]
	public int CompareTo(GFCAKFAODMC JAINJPLCLDO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JNACMFGBLNP<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly int CPLNODNGKGB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private GFCAKFAODMC KKICCIANDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0")]
		get
		{
			return default(GFCAKFAODMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
	internal JNACMFGBLNP(int CPLNODNGKGB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4DA0", Offset = "0x1BC3FA0", VA = "0x181BC4DA0")]
	public static GFCAKFAODMC KEDBNOKLEHE(JNACMFGBLNP<T> FPOONLFOOIF)
	{
		return default(GFCAKFAODMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4847560", Offset = "0x4846760", VA = "0x184847560", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4848630", Offset = "0x4847830", VA = "0x184848630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71B4DB0", Offset = "0x71B3FB0", VA = "0x1871B4DB0")]
		public static (long, string, string) JKIHAPNGCFE(EHDGIFBGGFC value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71B6AF0", Offset = "0x71B5CF0", VA = "0x1871B6AF0")]
		public static (long, string, string)[] OLLMDOIJGJN(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x71C1DA0", Offset = "0x71C0FA0", VA = "0x1871C1DA0")]
		public static Type[] HMAKMIFKPBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71C1E00", Offset = "0x71C1000", VA = "0x1871C1E00")]
		private static void JMFBCAGPLCG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly JNACMFGBLNP<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly JNACMFGBLNP<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly JNACMFGBLNP<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly JNACMFGBLNP<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly JNACMFGBLNP<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly JNACMFGBLNP<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly JNACMFGBLNP<KEADHBOCJDP> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly JNACMFGBLNP<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly JNACMFGBLNP<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly JNACMFGBLNP<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly JNACMFGBLNP<FixedList32Bytes<int>> InteractionFilterData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly JNACMFGBLNP<bool> InteractionFilterData_enabled;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly JNACMFGBLNP<KEADHBOCJDP> InteractionFilterData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly JNACMFGBLNP<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly JNACMFGBLNP<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly JNACMFGBLNP<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly JNACMFGBLNP<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public static readonly JNACMFGBLNP<GIPGPNDMMEK> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly JNACMFGBLNP<CACHBFICFAK> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly JNACMFGBLNP<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly JNACMFGBLNP<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly JNACMFGBLNP<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly JNACMFGBLNP<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly JNACMFGBLNP<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly JNACMFGBLNP<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly JNACMFGBLNP<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly JNACMFGBLNP<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly JNACMFGBLNP<MBEDHLMGFAB> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly JNACMFGBLNP<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly JNACMFGBLNP<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly JNACMFGBLNP<GCOJHJHCPIC> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly JNACMFGBLNP<EAOBBGHPEOO> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly JNACMFGBLNP<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly JNACMFGBLNP<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly JNACMFGBLNP<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly JNACMFGBLNP<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly JNACMFGBLNP<LocalId> EntityBundlePartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly JNACMFGBLNP<uint> EntityBundlePartData_entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly JNACMFGBLNP<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly JNACMFGBLNP<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly JNACMFGBLNP<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly JNACMFGBLNP<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly JNACMFGBLNP<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly JNACMFGBLNP<CKFIOHPKJNE> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly JNACMFGBLNP<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly JNACMFGBLNP<GCEHINAIMFJ> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly JNACMFGBLNP<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly JNACMFGBLNP<int> ReplicatorMaxObjectCountData_MaxCopies;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly JNACMFGBLNP<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly JNACMFGBLNP<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly JNACMFGBLNP<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly JNACMFGBLNP<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public static readonly JNACMFGBLNP<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly JNACMFGBLNP<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static readonly JNACMFGBLNP<MIAEMOOKOJL> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly JNACMFGBLNP<MOEHFGBKLHG> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly JNACMFGBLNP<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly JNACMFGBLNP<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static readonly JNACMFGBLNP<BDJEHBJKPBL> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static readonly JNACMFGBLNP<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly JNACMFGBLNP<CACHBFICFAK> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly JNACMFGBLNP<PGGGFOKEONL> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly JNACMFGBLNP<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly JNACMFGBLNP<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly JNACMFGBLNP<LMHHOBCBPNM> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static readonly JNACMFGBLNP<IBEMIEGJDEJ> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly JNACMFGBLNP<BEIPFCCMEFJ> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly JNACMFGBLNP<EFIBLMLADKJ> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly JNACMFGBLNP<GMCNNNOCDCB> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static readonly JNACMFGBLNP<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly JNACMFGBLNP<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly JNACMFGBLNP<BILHAHKOKFB> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly JNACMFGBLNP<BMLLGPFCOHL> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly JNACMFGBLNP<FMALEHIBCFB> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly JNACMFGBLNP<OGNIHOPFCBL> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly JNACMFGBLNP<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly JNACMFGBLNP<CJJHDAEBBAK> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ServiceLifetime(Lifetime.Application)]
	[RegisterService(typeof(HNDBOIDDOAL), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : HNDBOIDDOAL, AIIEBFHELMN, CIDGALBBDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB00AB0", Offset = "0xAFFCB0", VA = "0x180B00AB0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBBC050", Offset = "0xBBB250", VA = "0x180BBC050", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC66240", Offset = "0xC65440", VA = "0x180C66240", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD4D480", Offset = "0xD4C680", VA = "0x180D4D480", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8F21B0", Offset = "0x8F13B0", VA = "0x1808F21B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2220", Offset = "0x8F1420", VA = "0x1808F2220", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2200", Offset = "0x8F1400", VA = "0x1808F2200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public JOLMFKMLFOA[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8F21E0", Offset = "0x8F13E0", VA = "0x1808F21E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8F2230", Offset = "0x8F1430", VA = "0x1808F2230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, FPBDBMMHLFB> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8F2240", Offset = "0x8F1440", VA = "0x1808F2240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71C4050", Offset = "0x71C3250", VA = "0x1871C4050", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71CD6A0", Offset = "0x71CC8A0", VA = "0x1871CD6A0", Slot = "13")]
		public void IFPABEPBBCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x71C3FF0", Offset = "0x71C31F0", VA = "0x1871C3FF0", Slot = "14")]
		public void APIIJJHOIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71C4070", Offset = "0x71C3270", VA = "0x1871C4070")]
		private void GEDIIOELGNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71CD6B0", Offset = "0x71CC8B0", VA = "0x1871CD6B0")]
		public static void BDAIDDMCJBL(PGCPIJCNBBK writer, GFCAKFAODMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71D03A0", Offset = "0x71CF5A0", VA = "0x1871D03A0")]
		public static void JDHAODEKBJP(GMOIKBBHPKK reader, GFCAKFAODMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x71CD6D0", Offset = "0x71CC8D0", VA = "0x1871CD6D0")]
		private static void BEKDBBHOCFE(PGCPIJCNBBK writer, GFCAKFAODMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71CEED0", Offset = "0x71CE0D0", VA = "0x1871CEED0")]
		private static void IJLEMEECAAM(GMOIKBBHPKK reader, GFCAKFAODMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x342F790", Offset = "0x342E990", VA = "0x18342F790")]
		internal static void LKDLAIOBOFF<T>(PGCPIJCNBBK writer, JNACMFGBLNP<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x342F3E0", Offset = "0x342E5E0", VA = "0x18342F3E0")]
		internal static void LAEIJKNHIPI<T>(GMOIKBBHPKK reader, JNACMFGBLNP<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x342FAE0", Offset = "0x342ECE0", VA = "0x18342FAE0")]
		internal static void LKDLAIOBOFF<T>(PGCPIJCNBBK writer, JNACMFGBLNP<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x342F6A0", Offset = "0x342E8A0", VA = "0x18342F6A0")]
		internal static void LAEIJKNHIPI<T>(GMOIKBBHPKK reader, JNACMFGBLNP<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x342F8B0", Offset = "0x342EAB0", VA = "0x18342F8B0")]
		internal static void LKDLAIOBOFF<T>(PGCPIJCNBBK writer, JNACMFGBLNP<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x342F4D0", Offset = "0x342E6D0", VA = "0x18342F4D0")]
		internal static void LAEIJKNHIPI<T>(GMOIKBBHPKK reader, JNACMFGBLNP<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71D0F40", Offset = "0x71D0140", VA = "0x1871D0F40")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71D0590", Offset = "0x71CF790", VA = "0x1871D0590")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71D0A40", Offset = "0x71CFC40", VA = "0x1871D0A40")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71D0530", Offset = "0x71CF730", VA = "0x1871D0530")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71D0C20", Offset = "0x71CFE20", VA = "0x1871D0C20")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71D0640", Offset = "0x71CF840", VA = "0x1871D0640")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71D0C80", Offset = "0x71CFE80", VA = "0x1871D0C80")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71D09E0", Offset = "0x71CFBE0", VA = "0x1871D09E0")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71D0AA0", Offset = "0x71CFCA0", VA = "0x1871D0AA0")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71D0870", Offset = "0x71CFA70", VA = "0x1871D0870")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71D0FB0", Offset = "0x71D01B0", VA = "0x1871D0FB0")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x71D07C0", Offset = "0x71CF9C0", VA = "0x1871D07C0")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71D0ED0", Offset = "0x71D00D0", VA = "0x1871D0ED0")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71D0710", Offset = "0x71CF910", VA = "0x1871D0710")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71D0E60", Offset = "0x71D0060", VA = "0x1871D0E60")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71D0480", Offset = "0x71CF680", VA = "0x1871D0480")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x342F990", Offset = "0x342EB90", VA = "0x18342F990")]
		internal static void LKDLAIOBOFF<T>(PGCPIJCNBBK writer, JNACMFGBLNP<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x342F5B0", Offset = "0x342E7B0", VA = "0x18342F5B0")]
		internal static void LAEIJKNHIPI<T>(GMOIKBBHPKK reader, JNACMFGBLNP<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71D0CE0", Offset = "0x71CFEE0", VA = "0x1871D0CE0")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71D0920", Offset = "0x71CFB20", VA = "0x1871D0920")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71D0B10", Offset = "0x71CFD10", VA = "0x1871D0B10")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71D03C0", Offset = "0x71CF5C0", VA = "0x1871D03C0")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x71D0DF0", Offset = "0x71CFFF0", VA = "0x1871D0DF0")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<CACHBFICFAK> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71D06A0", Offset = "0x71CF8A0", VA = "0x1871D06A0")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<CACHBFICFAK> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x71B4CD0", Offset = "0x71B3ED0", VA = "0x1871B4CD0")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, JNACMFGBLNP<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x71B48E0", Offset = "0x71B3AE0", VA = "0x1871B48E0")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, JNACMFGBLNP<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x71B4CD0", Offset = "0x71B3ED0", VA = "0x1871B4CD0")]
		internal static void LKDLAIOBOFF(PGCPIJCNBBK writer, GFCAKFAODMC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x71B48E0", Offset = "0x71B3AE0", VA = "0x1871B48E0")]
		internal static void LAEIJKNHIPI(GMOIKBBHPKK reader, GFCAKFAODMC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x342F360", Offset = "0x342E560", VA = "0x18342F360")]
		internal static T CDKFMKBICMB<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x71D1020", Offset = "0x71D0220", VA = "0x1871D1020")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x71D1050", Offset = "0x71D0250", VA = "0x1871D1050")]
		public void JMFBCAGPLCG(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x71D1060", Offset = "0x71D0260", VA = "0x1871D1060")]
		private void NHEDOAMCAKB(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3981E40", Offset = "0x3981040", VA = "0x183981E40")]
		private void MMPHDODJIEK<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly int GeneratedVersionNumber;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum DMHLEGPKADG
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[RegisterService(typeof(KHAMMNCMJNK), new string[] { "Registry" })]
[ServiceLifetime(Lifetime.Application)]
internal class LMBABAILNAB : KHAMMNCMJNK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type ENCGMCGLCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x71D2930", Offset = "0x71D1B30", VA = "0x1871D2930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] HAHCHPBDNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71D29B0", Offset = "0x71D1BB0", VA = "0x1871D29B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71D2990", Offset = "0x71D1B90", VA = "0x1871D2990", Slot = "6")]
	public void HNLOIHIELGE(IComponentDefaultRegistration NMOOHILANMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public LMBABAILNAB()
	{
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
