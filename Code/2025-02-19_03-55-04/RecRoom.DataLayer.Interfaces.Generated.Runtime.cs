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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
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
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73EBE20", Offset = "0x73EAA20", VA = "0x1873EBE20", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74597F0", Offset = "0x74583F0", VA = "0x1874597F0")]
		private void MPLOOPBCFDI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7459680", Offset = "0x7458280", VA = "0x187459680")]
		private void GLOJJDDILEC(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7459960", Offset = "0x7458560", VA = "0x187459960", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7459C90", Offset = "0x7458890", VA = "0x187459C90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CompilerGenerated]
	public struct RRObjectPrefabData_v1 : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPrefabType_v1 prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[Cpp2IlInjected.Token(Token = "0x200000B")]
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
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	[CompilerGenerated]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
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
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v5 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct ILLBLIKIMND : IComparable<ILLBLIKIMND>, IEquatable<ILLBLIKIMND>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly ILLBLIKIMND GDEBNFLOOLE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly ILLBLIKIMND EIKFKHHDFFO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly ILLBLIKIMND FFBEMGJHDAH;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly ILLBLIKIMND JKLGGDLGIAL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly ILLBLIKIMND NLFIKLJOOPE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ILLBLIKIMND OHDGPBGDHOL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly int BIEEMEKMINN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AHDPANGFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type FHFJJAEHPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74485B0", Offset = "0x74471B0", VA = "0x1874485B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ADCBECJLAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7448AF0", Offset = "0x74476F0", VA = "0x187448AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BNJMONPHFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7448C30", Offset = "0x7447830", VA = "0x187448C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type OLMCLGHIJON
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7448A10", Offset = "0x7447610", VA = "0x187448A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IJADGMNJAPA AOHOCBDACJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7448280", Offset = "0x7446E80", VA = "0x187448280")]
		get
		{
			return default(IJADGMNJAPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MONOEGPPJDO KJAGHIONBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7448810", Offset = "0x7447410", VA = "0x187448810")]
		get
		{
			return default(MONOEGPPJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NIOEBDLDHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7448400", Offset = "0x7447000", VA = "0x187448400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IBKKPIEIGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74487C0", Offset = "0x74473C0", VA = "0x1874487C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NHKNIKKOMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7448D70", Offset = "0x7447970", VA = "0x187448D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GCODKGHOJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7448450", Offset = "0x7447050", VA = "0x187448450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
	public ILLBLIKIMND(int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7448740", Offset = "0x7447340", VA = "0x187448740", Slot = "5")]
	public bool Equals(ILLBLIKIMND PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7448690", Offset = "0x7447290", VA = "0x187448690", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7448ED0", Offset = "0x7447AD0", VA = "0x187448ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5340", Offset = "0x3FF3F40", VA = "0x183FF5340", Slot = "4")]
	public int CompareTo(ILLBLIKIMND PELBNOCGOOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct JNFJJJFLBKH<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int BIEEMEKMINN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private ILLBLIKIMND PNCJGFPMLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0")]
		get
		{
			return default(ILLBLIKIMND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
	internal JNFJJJFLBKH(int BIEEMEKMINN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1BE03E0", Offset = "0x1BDEFE0", VA = "0x181BE03E0")]
	public static ILLBLIKIMND NIBCGLOMJGK(JNFJJJFLBKH<T> JENIGBAOHNC)
	{
		return default(ILLBLIKIMND);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4946D60", Offset = "0x4945960", VA = "0x184946D60", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49470F0", Offset = "0x4945CF0", VA = "0x1849470F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x743CBC0", Offset = "0x743B7C0", VA = "0x18743CBC0")]
		public static (long, string, string) FOJNMENPPEJ(MCEIIDDCFHJ value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x743CA80", Offset = "0x743B680", VA = "0x18743CA80")]
		public static (long, string, string)[] FLPKEHHLOBH(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74481B0", Offset = "0x7446DB0", VA = "0x1874481B0")]
		public static Type[] COJDHBHJGJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7449220", Offset = "0x7447E20", VA = "0x187449220")]
		private static void CHOGICNNBDH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly JNFJJJFLBKH<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly JNFJJJFLBKH<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly JNFJJJFLBKH<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly JNFJJJFLBKH<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly JNFJJJFLBKH<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly JNFJJJFLBKH<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly JNFJJJFLBKH<AOMEDNFEJFK> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly JNFJJJFLBKH<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly JNFJJJFLBKH<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly JNFJJJFLBKH<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly JNFJJJFLBKH<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly JNFJJJFLBKH<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly JNFJJJFLBKH<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly JNFJJJFLBKH<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static readonly JNFJJJFLBKH<BOKJMHLAGIM> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static readonly JNFJJJFLBKH<KNNDLIBEPCE> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly JNFJJJFLBKH<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly JNFJJJFLBKH<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly JNFJJJFLBKH<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly JNFJJJFLBKH<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly JNFJJJFLBKH<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly JNFJJJFLBKH<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static readonly JNFJJJFLBKH<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static readonly JNFJJJFLBKH<KGJBIIODIFF> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static readonly JNFJJJFLBKH<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly JNFJJJFLBKH<byte> ContainerNameBuffer_data;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly JNFJJJFLBKH<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly JNFJJJFLBKH<AIILLNJMIAK> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly JNFJJJFLBKH<PKHCDPIAIHH> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly JNFJJJFLBKH<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static readonly JNFJJJFLBKH<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly JNFJJJFLBKH<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static readonly JNFJJJFLBKH<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly JNFJJJFLBKH<LocalId> EntityPrefabPartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static readonly JNFJJJFLBKH<uint> EntityPrefabPartData_partId;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static readonly JNFJJJFLBKH<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly JNFJJJFLBKH<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly JNFJJJFLBKH<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly JNFJJJFLBKH<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static readonly JNFJJJFLBKH<ILOIBFOGPCD> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly JNFJJJFLBKH<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static readonly JNFJJJFLBKH<AELPFFMHMMC> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly JNFJJJFLBKH<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly JNFJJJFLBKH<int> ReplicatorMaxObjectCountData_count;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly JNFJJJFLBKH<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly JNFJJJFLBKH<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static readonly JNFJJJFLBKH<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static readonly JNFJJJFLBKH<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly JNFJJJFLBKH<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly JNFJJJFLBKH<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly JNFJJJFLBKH<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly JNFJJJFLBKH<NECIPBBCOII> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static readonly JNFJJJFLBKH<GDJFDDEMAEB> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly JNFJJJFLBKH<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly JNFJJJFLBKH<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly JNFJJJFLBKH<LNEANCDCPBK> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly JNFJJJFLBKH<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly JNFJJJFLBKH<KNNDLIBEPCE> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly JNFJJJFLBKH<GKJNGJEAINA> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly JNFJJJFLBKH<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly JNFJJJFLBKH<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly JNFJJJFLBKH<BGBHOGOFFCI> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly JNFJJJFLBKH<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly JNFJJJFLBKH<HCIBANBNEEL> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly JNFJJJFLBKH<MDHOEMALAKC> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly JNFJJJFLBKH<KOKMBHAEOFP> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly JNFJJJFLBKH<KHFGJEJADIN> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly JNFJJJFLBKH<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly JNFJJJFLBKH<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly JNFJJJFLBKH<CFJKLKGPMMA> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly JNFJJJFLBKH<MBIGAFAMMKG> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly JNFJJJFLBKH<EEAIKJADKBJ> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly JNFJJJFLBKH<ILNIKCMEHIN> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly JNFJJJFLBKH<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly JNFJJJFLBKH<GDGOOJEEKEA> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	[RegisterService(typeof(DHGPKCHJBGH), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : DHGPKCHJBGH, IACHLPBDHHB, PPOHJMEPICJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAD8DC0", Offset = "0xAD79C0", VA = "0x180AD8DC0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBDB0A0", Offset = "0xBD9CA0", VA = "0x180BDB0A0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC55710", Offset = "0xC54310", VA = "0x180C55710", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD49930", Offset = "0xD48530", VA = "0x180D49930", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x95EFF0", Offset = "0x95DBF0", VA = "0x18095EFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x95F010", Offset = "0x95DC10", VA = "0x18095F010", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x95F040", Offset = "0x95DC40", VA = "0x18095F040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IJADGMNJAPA[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x95F020", Offset = "0x95DC20", VA = "0x18095F020", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x95F030", Offset = "0x95DC30", VA = "0x18095F030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, MONOEGPPJDO> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x961530", Offset = "0x960130", VA = "0x180961530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7454AD0", Offset = "0x74536D0", VA = "0x187454AD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7454AC0", Offset = "0x74536C0", VA = "0x187454AC0", Slot = "13")]
		public void NLBDHMKAEKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x744B420", Offset = "0x744A020", VA = "0x18744B420", Slot = "14")]
		public void GMJHFFLJMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x744B480", Offset = "0x744A080", VA = "0x18744B480")]
		private void IFPPIEIOGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7455190", Offset = "0x7453D90", VA = "0x187455190")]
		public static void HADFNALBNMO(GDFPEFJHJIP writer, ILLBLIKIMND property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7455170", Offset = "0x7453D70", VA = "0x187455170")]
		public static void FNGPCMJHHCK(OOBJKCBLAHD reader, ILLBLIKIMND property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74551B0", Offset = "0x7453DB0", VA = "0x1874551B0")]
		private static void JHONKBLHNNO(GDFPEFJHJIP writer, ILLBLIKIMND property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7456F50", Offset = "0x7455B50", VA = "0x187456F50")]
		private static void MFPIBOGACEG(OOBJKCBLAHD reader, ILLBLIKIMND property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3542A10", Offset = "0x3541610", VA = "0x183542A10")]
		internal static void DHDDBDHCOJI<T>(GDFPEFJHJIP writer, JNFJJJFLBKH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3542E40", Offset = "0x3541A40", VA = "0x183542E40")]
		internal static void KOHMJABOPGF<T>(OOBJKCBLAHD reader, JNFJJJFLBKH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3542D60", Offset = "0x3541960", VA = "0x183542D60")]
		internal static void DHDDBDHCOJI<T>(GDFPEFJHJIP writer, JNFJJJFLBKH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3543100", Offset = "0x3541D00", VA = "0x183543100")]
		internal static void KOHMJABOPGF<T>(OOBJKCBLAHD reader, JNFJJJFLBKH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3542B30", Offset = "0x3541730", VA = "0x183542B30")]
		internal static void DHDDBDHCOJI<T>(GDFPEFJHJIP writer, JNFJJJFLBKH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3542F30", Offset = "0x3541B30", VA = "0x183542F30")]
		internal static void KOHMJABOPGF<T>(OOBJKCBLAHD reader, JNFJJJFLBKH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7455100", Offset = "0x7453D00", VA = "0x187455100")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7456BC0", Offset = "0x74557C0", VA = "0x187456BC0")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7454DB0", Offset = "0x74539B0", VA = "0x187454DB0")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7456860", Offset = "0x7455460", VA = "0x187456860")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7454E50", Offset = "0x7453A50", VA = "0x187454E50")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74568D0", Offset = "0x74554D0", VA = "0x1874568D0")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7454C00", Offset = "0x7453800", VA = "0x187454C00")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7456EF0", Offset = "0x7455AF0", VA = "0x187456EF0")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74550A0", Offset = "0x7453CA0", VA = "0x1874550A0")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7456930", Offset = "0x7455530", VA = "0x187456930")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7454C60", Offset = "0x7453860", VA = "0x187454C60")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7456E40", Offset = "0x7455A40", VA = "0x187456E40")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7454EB0", Offset = "0x7453AB0", VA = "0x187454EB0")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7456D20", Offset = "0x7455920", VA = "0x187456D20")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7454CD0", Offset = "0x74538D0", VA = "0x187454CD0")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7456C70", Offset = "0x7455870", VA = "0x187456C70")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7454D40", Offset = "0x7453940", VA = "0x187454D40")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7456990", Offset = "0x7455590", VA = "0x187456990")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3542C10", Offset = "0x3541810", VA = "0x183542C10")]
		internal static void DHDDBDHCOJI<T>(GDFPEFJHJIP writer, JNFJJJFLBKH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3543010", Offset = "0x3541C10", VA = "0x183543010")]
		internal static void KOHMJABOPGF<T>(OOBJKCBLAHD reader, JNFJJJFLBKH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7454F90", Offset = "0x7453B90", VA = "0x187454F90")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7456A40", Offset = "0x7455640", VA = "0x187456A40")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7454AF0", Offset = "0x74536F0", VA = "0x187454AF0")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7456B00", Offset = "0x7455700", VA = "0x187456B00")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7454F20", Offset = "0x7453B20", VA = "0x187454F20")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<KNNDLIBEPCE> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7456DD0", Offset = "0x74559D0", VA = "0x187456DD0")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<KNNDLIBEPCE> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x743C550", Offset = "0x743B150", VA = "0x18743C550")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, JNFJJJFLBKH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x743C690", Offset = "0x743B290", VA = "0x18743C690")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, JNFJJJFLBKH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x743C550", Offset = "0x743B150", VA = "0x18743C550")]
		internal static void DHDDBDHCOJI(GDFPEFJHJIP writer, ILLBLIKIMND prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x743C690", Offset = "0x743B290", VA = "0x18743C690")]
		internal static void KOHMJABOPGF(OOBJKCBLAHD reader, ILLBLIKIMND prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x35431F0", Offset = "0x3541DF0", VA = "0x1835431F0")]
		internal static T PIFJCFNEALA<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7458550", Offset = "0x7457150", VA = "0x187458550")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7458580", Offset = "0x7457180", VA = "0x187458580")]
		public void CHOGICNNBDH(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7458590", Offset = "0x7457190", VA = "0x187458590")]
		private void LOKGDMIGEDH(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3A59970", Offset = "0x3A58570", VA = "0x183A59970")]
		private void AAKDDDCGOLM<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			UpgradeToRoomLevelShapes = 123
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7459670", Offset = "0x7458270", VA = "0x187459670")]
		public static bool FALEFPLCIMC(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum NLEBKDKBFOO
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[RegisterService(typeof(DLGJIKOBDBN), new string[] { "Registry" })]
internal class HFNAIAOCEKP : DLGJIKOBDBN
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type PBHBOCAFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7448220", Offset = "0x7446E20", VA = "0x187448220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] JPHIBGMDHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74481B0", Offset = "0x7446DB0", VA = "0x1874481B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7448200", Offset = "0x7446E00", VA = "0x187448200", Slot = "6")]
	public void EPKJHKNFLIG(IComponentDefaultRegistration BHPAAPCBOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HFNAIAOCEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class ELFOCOBOAAN : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private class HEONDIGKBPK : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7448180", Offset = "0x7446D80", VA = "0x187448180", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7448090", Offset = "0x7446C90", VA = "0x187448090")]
		public HEONDIGKBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1EE94C0", Offset = "0x1EE80C0", VA = "0x181EE94C0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 AGGFAPJEEEN)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7448080", Offset = "0x7446C80", VA = "0x187448080", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 AGGFAPJEEEN, ObjectPrefabType_v1 MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7447F00", Offset = "0x7446B00", VA = "0x187447F00")]
	public ELFOCOBOAAN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7458380", Offset = "0x7456F80", VA = "0x187458380")]
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
