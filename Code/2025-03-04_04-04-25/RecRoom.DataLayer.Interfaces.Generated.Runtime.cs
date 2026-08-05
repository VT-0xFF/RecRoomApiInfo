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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x743DB70", Offset = "0x743C170", VA = "0x18743DB70", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74AD250", Offset = "0x74AB850", VA = "0x1874AD250")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74AD0E0", Offset = "0x74AB6E0", VA = "0x1874AD0E0")]
		private void BGELMNPCJDF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74AD3C0", Offset = "0x74AB9C0", VA = "0x1874AD3C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74AD6F0", Offset = "0x74ABCF0", VA = "0x1874AD6F0")]
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
public readonly struct IDDBKPIMPMC : IComparable<IDDBKPIMPMC>, IEquatable<IDDBKPIMPMC>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDDBKPIMPMC NACGKDEGDLG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDDBKPIMPMC PPDNPJPLIPJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IDDBKPIMPMC PEHEJMCLOLF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IDDBKPIMPMC COKGNBNKJHM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDDBKPIMPMC IONJJCGHGHP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly IDDBKPIMPMC PGBEJIFGEMA;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly int EAHKFAJBNDN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type IKLFBLNJLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x749BB10", Offset = "0x749A110", VA = "0x18749BB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MBLKEEKGIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x749C210", Offset = "0x749A810", VA = "0x18749C210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NGPEAGCEMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x749BD50", Offset = "0x749A350", VA = "0x18749BD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type JMLPJOMCKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x749B7A0", Offset = "0x7499DA0", VA = "0x18749B7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JLLAJCACKJP KCNNBGCLAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x749C090", Offset = "0x749A690", VA = "0x18749C090")]
		get
		{
			return default(JLLAJCACKJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KGBGKJNNEAD DENNMOEIEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x749BE90", Offset = "0x749A490", VA = "0x18749BE90")]
		get
		{
			return default(KGBGKJNNEAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EAJJDEFJKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x749C3A0", Offset = "0x749A9A0", VA = "0x18749C3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BALEALHMKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x749C350", Offset = "0x749A950", VA = "0x18749C350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JHMHPGDOLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x749B880", Offset = "0x7499E80", VA = "0x18749B880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LOADNMPOMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x749BBF0", Offset = "0x749A1F0", VA = "0x18749BBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620")]
	public IDDBKPIMPMC(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x749B9E0", Offset = "0x7499FE0", VA = "0x18749B9E0", Slot = "5")]
	public bool Equals(IDDBKPIMPMC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x749BA60", Offset = "0x749A060", VA = "0x18749BA60", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x749C3F0", Offset = "0x749A9F0", VA = "0x18749C3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4583820", Offset = "0x4581E20", VA = "0x184583820", Slot = "4")]
	public int CompareTo(IDDBKPIMPMC OKCHLIEAIJP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NOKBAHBBFEN<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int EAHKFAJBNDN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private IDDBKPIMPMC FFAMOGBNMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
		get
		{
			return default(IDDBKPIMPMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620")]
	internal NOKBAHBBFEN(int EAHKFAJBNDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C09260", Offset = "0x1C07860", VA = "0x181C09260")]
	public static IDDBKPIMPMC HEGJABMHLEC(NOKBAHBBFEN<T> KKCCAKAEMAH)
	{
		return default(IDDBKPIMPMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB740", Offset = "0x4EE9D40", VA = "0x184EEB740", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBF60", Offset = "0x4EEA560", VA = "0x184EEBF60", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x74902D0", Offset = "0x748E8D0", VA = "0x1874902D0")]
		public static (long, string, string) LPOMLJMNECP(LBJDMFOKJAE value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7490190", Offset = "0x748E790", VA = "0x187490190")]
		public static (long, string, string)[] DNIDEHNENKK(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x749B740", Offset = "0x7499D40", VA = "0x18749B740")]
		public static Type[] LDKCECMMMKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x749CA40", Offset = "0x749B040", VA = "0x18749CA40")]
		private static void OCICFIBHEPA()
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
		public static readonly NOKBAHBBFEN<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly NOKBAHBBFEN<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly NOKBAHBBFEN<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly NOKBAHBBFEN<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly NOKBAHBBFEN<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly NOKBAHBBFEN<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly NOKBAHBBFEN<ADAPBJDILJP> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly NOKBAHBBFEN<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly NOKBAHBBFEN<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly NOKBAHBBFEN<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly NOKBAHBBFEN<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly NOKBAHBBFEN<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly NOKBAHBBFEN<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly NOKBAHBBFEN<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static readonly NOKBAHBBFEN<EIFCHLJGNJM> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static readonly NOKBAHBBFEN<HMNOMFGLPAB> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly NOKBAHBBFEN<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly NOKBAHBBFEN<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly NOKBAHBBFEN<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly NOKBAHBBFEN<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly NOKBAHBBFEN<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly NOKBAHBBFEN<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static readonly NOKBAHBBFEN<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static readonly NOKBAHBBFEN<GEKBHKNKKME> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static readonly NOKBAHBBFEN<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly NOKBAHBBFEN<byte> ContainerNameBuffer_data;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly NOKBAHBBFEN<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly NOKBAHBBFEN<ADOECMLOFOB> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly NOKBAHBBFEN<OFHIFDOIEMG> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly NOKBAHBBFEN<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static readonly NOKBAHBBFEN<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly NOKBAHBBFEN<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static readonly NOKBAHBBFEN<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly NOKBAHBBFEN<LocalId> EntityPrefabPartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static readonly NOKBAHBBFEN<uint> EntityPrefabPartData_partId;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static readonly NOKBAHBBFEN<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly NOKBAHBBFEN<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly NOKBAHBBFEN<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly NOKBAHBBFEN<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static readonly NOKBAHBBFEN<PGBKBOPFMNI> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly NOKBAHBBFEN<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static readonly NOKBAHBBFEN<EDJKJELJDNI> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly NOKBAHBBFEN<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly NOKBAHBBFEN<int> ReplicatorMaxObjectCountData_count;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly NOKBAHBBFEN<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly NOKBAHBBFEN<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static readonly NOKBAHBBFEN<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static readonly NOKBAHBBFEN<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly NOKBAHBBFEN<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly NOKBAHBBFEN<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly NOKBAHBBFEN<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly NOKBAHBBFEN<CPAENDDAKAG> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static readonly NOKBAHBBFEN<FLMNFNBLJCG> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly NOKBAHBBFEN<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly NOKBAHBBFEN<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly NOKBAHBBFEN<LAKFMIPGDFM> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly NOKBAHBBFEN<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly NOKBAHBBFEN<HMNOMFGLPAB> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly NOKBAHBBFEN<AEONEPFEMAI> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly NOKBAHBBFEN<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly NOKBAHBBFEN<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly NOKBAHBBFEN<GHMFPPOCHDI> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly NOKBAHBBFEN<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly NOKBAHBBFEN<GGAMIDPBJDH> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly NOKBAHBBFEN<FHNKOECFNCG> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly NOKBAHBBFEN<KMKOJLIANAG> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly NOKBAHBBFEN<BBKFGBALMBJ> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly NOKBAHBBFEN<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly NOKBAHBBFEN<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly NOKBAHBBFEN<BFDPJCKJFHK> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly NOKBAHBBFEN<MIICMHIJAKL> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly NOKBAHBBFEN<HPHAOIABICP> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly NOKBAHBBFEN<PEOGKAGLGAI> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly NOKBAHBBFEN<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly NOKBAHBBFEN<EKDALHPLPPO> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	[RegisterService(typeof(NFHCBJLKPBO), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : NFHCBJLKPBO, BCKKHAOMDCH, CBANIPAPHBJ
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
			[Cpp2IlInjected.Address(RVA = "0xAD38D0", Offset = "0xAD1ED0", VA = "0x180AD38D0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBCBF80", Offset = "0xBCA580", VA = "0x180BCBF80", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC74780", Offset = "0xC72D80", VA = "0x180C74780", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD4E4C0", Offset = "0xD4CAC0", VA = "0x180D4E4C0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x956B10", Offset = "0x955110", VA = "0x180956B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x956CC0", Offset = "0x9552C0", VA = "0x180956CC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x956D40", Offset = "0x955340", VA = "0x180956D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public JLLAJCACKJP[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x958C60", Offset = "0x957260", VA = "0x180958C60", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x958C70", Offset = "0x957270", VA = "0x180958C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, KGBGKJNNEAD> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x956D90", Offset = "0x955390", VA = "0x180956D90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x956D10", Offset = "0x955310", VA = "0x180956D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x74A83E0", Offset = "0x74A69E0", VA = "0x1874A83E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74A83D0", Offset = "0x74A69D0", VA = "0x1874A83D0", Slot = "13")]
		public void NGOLPLFPNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74A8370", Offset = "0x74A6970", VA = "0x1874A8370", Slot = "14")]
		public void GFJNPMIAIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x749ED30", Offset = "0x749D330", VA = "0x18749ED30")]
		private void EGOGIFMOOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74A8400", Offset = "0x74A6A00", VA = "0x1874A8400")]
		public static void GDHPJIPDANO(ACECHIALAJM writer, IDDBKPIMPMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74AA650", Offset = "0x74A8C50", VA = "0x1874AA650")]
		public static void NDCBHGDHDNJ(PLHMIJKLCDJ reader, IDDBKPIMPMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74AA670", Offset = "0x74A8C70", VA = "0x1874AA670")]
		private static void NOGPEKOMLKH(ACECHIALAJM writer, IDDBKPIMPMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74A9190", Offset = "0x74A7790", VA = "0x1874A9190")]
		private static void KOANGNOHFMM(PLHMIJKLCDJ reader, IDDBKPIMPMC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x35DA210", Offset = "0x35D8810", VA = "0x1835DA210")]
		internal static void IMJDHHAECMF<T>(ACECHIALAJM writer, NOKBAHBBFEN<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x35D9E60", Offset = "0x35D8460", VA = "0x1835D9E60")]
		internal static void GFOCOOKFNLL<T>(PLHMIJKLCDJ reader, NOKBAHBBFEN<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x35DA560", Offset = "0x35D8B60", VA = "0x1835DA560")]
		internal static void IMJDHHAECMF<T>(ACECHIALAJM writer, NOKBAHBBFEN<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x35DA120", Offset = "0x35D8720", VA = "0x1835DA120")]
		internal static void GFOCOOKFNLL<T>(PLHMIJKLCDJ reader, NOKBAHBBFEN<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x35DA330", Offset = "0x35D8930", VA = "0x1835DA330")]
		internal static void IMJDHHAECMF<T>(ACECHIALAJM writer, NOKBAHBBFEN<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x35D9F50", Offset = "0x35D8550", VA = "0x1835D9F50")]
		internal static void GFOCOOKFNLL<T>(PLHMIJKLCDJ reader, NOKBAHBBFEN<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74A9120", Offset = "0x74A7720", VA = "0x1874A9120")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74A8600", Offset = "0x74A6C00", VA = "0x1874A8600")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74A8B10", Offset = "0x74A7110", VA = "0x1874A8B10")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74A8820", Offset = "0x74A6E20", VA = "0x1874A8820")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74A8BB0", Offset = "0x74A71B0", VA = "0x1874A8BB0")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74A8AB0", Offset = "0x74A70B0", VA = "0x1874A8AB0")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74A90C0", Offset = "0x74A76C0", VA = "0x1874A90C0")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74A8480", Offset = "0x74A6A80", VA = "0x1874A8480")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74A9060", Offset = "0x74A7660", VA = "0x1874A9060")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74A8420", Offset = "0x74A6A20", VA = "0x1874A8420")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74A8EE0", Offset = "0x74A74E0", VA = "0x1874A8EE0")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74A8A00", Offset = "0x74A7000", VA = "0x1874A8A00")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74A8C80", Offset = "0x74A7280", VA = "0x1874A8C80")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74A86B0", Offset = "0x74A6CB0", VA = "0x1874A86B0")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x74A8CF0", Offset = "0x74A72F0", VA = "0x1874A8CF0")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74A8950", Offset = "0x74A6F50", VA = "0x1874A8950")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74A8E70", Offset = "0x74A7470", VA = "0x1874A8E70")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x74A84E0", Offset = "0x74A6AE0", VA = "0x1874A84E0")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x35DA410", Offset = "0x35D8A10", VA = "0x1835DA410")]
		internal static void IMJDHHAECMF<T>(ACECHIALAJM writer, NOKBAHBBFEN<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x35DA030", Offset = "0x35D8630", VA = "0x1835DA030")]
		internal static void GFOCOOKFNLL<T>(PLHMIJKLCDJ reader, NOKBAHBBFEN<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x74A8F50", Offset = "0x74A7550", VA = "0x1874A8F50")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x74A8760", Offset = "0x74A6D60", VA = "0x1874A8760")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x74A8D60", Offset = "0x74A7360", VA = "0x1874A8D60")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74A8890", Offset = "0x74A6E90", VA = "0x1874A8890")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x74A8C10", Offset = "0x74A7210", VA = "0x1874A8C10")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<HMNOMFGLPAB> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x74A8590", Offset = "0x74A6B90", VA = "0x1874A8590")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<HMNOMFGLPAB> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x74900B0", Offset = "0x748E6B0", VA = "0x1874900B0")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, NOKBAHBBFEN<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x748FC60", Offset = "0x748E260", VA = "0x18748FC60")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, NOKBAHBBFEN<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x74900B0", Offset = "0x748E6B0", VA = "0x1874900B0")]
		internal static void IMJDHHAECMF(ACECHIALAJM writer, IDDBKPIMPMC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x748FC60", Offset = "0x748E260", VA = "0x18748FC60")]
		internal static void GFOCOOKFNLL(PLHMIJKLCDJ reader, IDDBKPIMPMC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x35D9DE0", Offset = "0x35D83E0", VA = "0x1835D9DE0")]
		internal static T CFNBJHOAGED<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x74ABFB0", Offset = "0x74AA5B0", VA = "0x1874ABFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74AD0C0", Offset = "0x74AB6C0", VA = "0x1874AD0C0")]
		public void OCICFIBHEPA(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74ABFE0", Offset = "0x74AA5E0", VA = "0x1874ABFE0")]
		private void JPOKCMDBKLF(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3B0CF00", Offset = "0x3B0B500", VA = "0x183B0CF00")]
		private void KACLEJPBMBO<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
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
			UpgradeStudioObjectPolicyData = 137,
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			UpgradeToRoomLevelShapes = 123
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74AD0D0", Offset = "0x74AB6D0", VA = "0x1874AD0D0")]
		public static bool LFMCKNONCCD(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum AGJAOLGLIFC
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
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
		[Cpp2IlInjected.Token(Token = "0x400012E")]
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
		[Cpp2IlInjected.Token(Token = "0x400012F")]
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
		[Cpp2IlInjected.Token(Token = "0x4000130")]
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
		[Cpp2IlInjected.Token(Token = "0x4000131")]
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
		[Cpp2IlInjected.Token(Token = "0x4000132")]
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
		[Cpp2IlInjected.Token(Token = "0x4000133")]
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
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[RegisterService(typeof(MPFMKMKKIOA), new string[] { "Registry" })]
internal class GBIHOAEEBFF : MPFMKMKKIOA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type OLKDPODLCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x749B6E0", Offset = "0x7499CE0", VA = "0x18749B6E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] GLLGCACJHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x749B740", Offset = "0x7499D40", VA = "0x18749B740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x749B6C0", Offset = "0x7499CC0", VA = "0x18749B6C0", Slot = "6")]
	public void DHLJIAHIEMC(IComponentDefaultRegistration JMCFKKNNBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public GBIHOAEEBFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class KIBJFPNCPKI : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private class MPEFKHJMDKO : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x749CA10", Offset = "0x749B010", VA = "0x18749CA10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x749C920", Offset = "0x749AF20", VA = "0x18749C920")]
		public MPEFKHJMDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F19DE0", Offset = "0x1F183E0", VA = "0x181F19DE0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 MGOKPJKELJG)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x749C910", Offset = "0x749AF10", VA = "0x18749C910", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 MGOKPJKELJG, ObjectPrefabType_v1 KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x749C790", Offset = "0x749AD90", VA = "0x18749C790")]
	public KIBJFPNCPKI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74ABDE0", Offset = "0x74AA3E0", VA = "0x1874ABDE0")]
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
