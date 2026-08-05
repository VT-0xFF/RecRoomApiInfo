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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7536370", Offset = "0x7535570", VA = "0x187536370", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75A5B00", Offset = "0x75A4D00", VA = "0x1875A5B00")]
		private void BCKFAMNGJJN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75A5990", Offset = "0x75A4B90", VA = "0x1875A5990")]
		private void APGEGEPOGIN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75A5C70", Offset = "0x75A4E70", VA = "0x1875A5C70", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75A5FA0", Offset = "0x75A51A0", VA = "0x1875A5FA0")]
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
public readonly struct DJNFFIMKOOB : IComparable<DJNFFIMKOOB>, IEquatable<DJNFFIMKOOB>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly DJNFFIMKOOB GCMJBINHBBO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly DJNFFIMKOOB CCGKEEAILHP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DJNFFIMKOOB OIPJENCNAGA;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly DJNFFIMKOOB GMDGEGICCEM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly DJNFFIMKOOB FMHMEDCGGLL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly DJNFFIMKOOB LNCINEAMDAK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly int KOOLKCPAFBB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type AGAPFEDODPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7594AD0", Offset = "0x7593CD0", VA = "0x187594AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CAGALMNONCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7594C00", Offset = "0x7593E00", VA = "0x187594C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HNAECDILAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7594550", Offset = "0x7593750", VA = "0x187594550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type MAGIBKPNEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7594EC0", Offset = "0x75940C0", VA = "0x187594EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PGDEMGCHHMC INMPNAIDICP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7594D40", Offset = "0x7593F40", VA = "0x187594D40")]
		get
		{
			return default(PGDEMGCHHMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HCLEOBEHAEG CKJJANDFAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7594350", Offset = "0x7593550", VA = "0x187594350")]
		get
		{
			return default(HCLEOBEHAEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OODDANJIDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7594920", Offset = "0x7593B20", VA = "0x187594920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DOODMLKFJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7594BB0", Offset = "0x7593DB0", VA = "0x187594BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DNBMFFFFIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7594970", Offset = "0x7593B70", VA = "0x187594970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BKJCCILNEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75947C0", Offset = "0x75939C0", VA = "0x1875947C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120")]
	public DJNFFIMKOOB(int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7594690", Offset = "0x7593890", VA = "0x187594690", Slot = "5")]
	public bool Equals(DJNFFIMKOOB LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7594710", Offset = "0x7593910", VA = "0x187594710", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7594FA0", Offset = "0x75941A0", VA = "0x187594FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C6E0", Offset = "0x4B8B8E0", VA = "0x184B8C6E0", Slot = "4")]
	public int CompareTo(DJNFFIMKOOB LDKNLBHIGFL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FEMEPFDGNFM<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int KOOLKCPAFBB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private DJNFFIMKOOB AMJNHIMMJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
		get
		{
			return default(DJNFFIMKOOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120")]
	internal FEMEPFDGNFM(int KOOLKCPAFBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
	public static DJNFFIMKOOB AJAOLMPMCKD(FEMEPFDGNFM<T> AKOEHEOHLAC)
	{
		return default(DJNFFIMKOOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x44B8BA0", Offset = "0x44B7DA0", VA = "0x1844B8BA0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x44B9A40", Offset = "0x44B8C40", VA = "0x1844B9A40", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7588ED0", Offset = "0x75880D0", VA = "0x187588ED0")]
		public static (long, string, string) CMNDKCBOMLL(GBIMNPEINGJ value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x758A5E0", Offset = "0x75897E0", VA = "0x18758A5E0")]
		public static (long, string, string)[] ECAMCLCPHBO(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x7595460", Offset = "0x7594660", VA = "0x187595460")]
		public static Type[] BBJIGKIHMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75954B0", Offset = "0x75946B0", VA = "0x1875954B0")]
		private static void COGNOIDNGPM()
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
		public static readonly FEMEPFDGNFM<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly FEMEPFDGNFM<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly FEMEPFDGNFM<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly FEMEPFDGNFM<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly FEMEPFDGNFM<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly FEMEPFDGNFM<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly FEMEPFDGNFM<EJEHHIGLHHI> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly FEMEPFDGNFM<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly FEMEPFDGNFM<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly FEMEPFDGNFM<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly FEMEPFDGNFM<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly FEMEPFDGNFM<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly FEMEPFDGNFM<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly FEMEPFDGNFM<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static readonly FEMEPFDGNFM<PLMMPJCBGLA> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static readonly FEMEPFDGNFM<KCJNGLILOOA> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly FEMEPFDGNFM<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly FEMEPFDGNFM<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly FEMEPFDGNFM<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly FEMEPFDGNFM<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly FEMEPFDGNFM<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly FEMEPFDGNFM<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static readonly FEMEPFDGNFM<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static readonly FEMEPFDGNFM<JNJEAPHGDNK> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static readonly FEMEPFDGNFM<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly FEMEPFDGNFM<byte> ContainerNameBuffer_data;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly FEMEPFDGNFM<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly FEMEPFDGNFM<MLIAAFMGOKL> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly FEMEPFDGNFM<PMLONBCCMJA> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly FEMEPFDGNFM<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static readonly FEMEPFDGNFM<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly FEMEPFDGNFM<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static readonly FEMEPFDGNFM<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly FEMEPFDGNFM<LocalId> EntityPrefabPartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static readonly FEMEPFDGNFM<uint> EntityPrefabPartData_partId;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static readonly FEMEPFDGNFM<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly FEMEPFDGNFM<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly FEMEPFDGNFM<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly FEMEPFDGNFM<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static readonly FEMEPFDGNFM<NBCDJIIJPBF> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly FEMEPFDGNFM<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static readonly FEMEPFDGNFM<HLJNCAAHCPJ> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly FEMEPFDGNFM<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly FEMEPFDGNFM<int> ReplicatorMaxObjectCountData_count;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly FEMEPFDGNFM<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly FEMEPFDGNFM<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static readonly FEMEPFDGNFM<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static readonly FEMEPFDGNFM<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly FEMEPFDGNFM<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly FEMEPFDGNFM<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly FEMEPFDGNFM<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly FEMEPFDGNFM<PKHDDMBNAMA> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static readonly FEMEPFDGNFM<FEDDFCEHBJI> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly FEMEPFDGNFM<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly FEMEPFDGNFM<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly FEMEPFDGNFM<IKBKDAJDEEK> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly FEMEPFDGNFM<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly FEMEPFDGNFM<KCJNGLILOOA> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly FEMEPFDGNFM<BLEJPBLPOHN> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly FEMEPFDGNFM<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly FEMEPFDGNFM<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly FEMEPFDGNFM<GOJEDHLHKHB> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly FEMEPFDGNFM<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly FEMEPFDGNFM<OJDJGOBPIPB> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly FEMEPFDGNFM<HKPEPILBIDI> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly FEMEPFDGNFM<KDCOCJHBCHK> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly FEMEPFDGNFM<KNIMAJIFOKB> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly FEMEPFDGNFM<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly FEMEPFDGNFM<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly FEMEPFDGNFM<FPFMEBHEJNF> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly FEMEPFDGNFM<DEICFKHPALG> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly FEMEPFDGNFM<EGIKPNEFJGH> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly FEMEPFDGNFM<FIOIEGBPDMD> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly FEMEPFDGNFM<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly FEMEPFDGNFM<LALIAMPJIPE> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	[RegisterService(typeof(BLOELBNNLHF), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : BLOELBNNLHF, AFBPMOJODGO, DKPHGOHMHMA
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
			[Cpp2IlInjected.Address(RVA = "0xB45CB0", Offset = "0xB44EB0", VA = "0x180B45CB0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC1E1C0", Offset = "0xC1D3C0", VA = "0x180C1E1C0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCB9CA0", Offset = "0xCB8EA0", VA = "0x180CB9CA0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDB1CB0", Offset = "0xDB0EB0", VA = "0x180DB1CB0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x961610", Offset = "0x960810", VA = "0x180961610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960840", VA = "0x180961640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PGDEMGCHHMC[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x961600", Offset = "0x960800", VA = "0x180961600", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x961660", Offset = "0x960860", VA = "0x180961660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, HCLEOBEHAEG> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960870", VA = "0x180961670", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x961650", Offset = "0x960850", VA = "0x180961650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75A0D00", Offset = "0x759FF00", VA = "0x1875A0D00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75A0CF0", Offset = "0x759FEF0", VA = "0x1875A0CF0", Slot = "13")]
		public void KEGBNNEOIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75A0D20", Offset = "0x759FF20", VA = "0x1875A0D20", Slot = "14")]
		public void PPDMLGCOEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75976B0", Offset = "0x75968B0", VA = "0x1875976B0")]
		private void JLGOPFFJBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75A2B20", Offset = "0x75A1D20", VA = "0x1875A2B20")]
		public static void GMCIGBPLCJF(PGAHIIKCJMD writer, DJNFFIMKOOB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75A2B40", Offset = "0x75A1D40", VA = "0x1875A2B40")]
		public static void GOPGMFOMMNP(DCCIFJHAAKO reader, DJNFFIMKOOB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75A1470", Offset = "0x75A0670", VA = "0x1875A1470")]
		private static void FCNFHAOMNJO(PGAHIIKCJMD writer, DJNFFIMKOOB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75A31E0", Offset = "0x75A23E0", VA = "0x1875A31E0")]
		private static void OEHDKKFLEOJ(DCCIFJHAAKO reader, DJNFFIMKOOB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x363A650", Offset = "0x3639850", VA = "0x18363A650")]
		internal static void JEAAONFOJJH<T>(PGAHIIKCJMD writer, FEMEPFDGNFM<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x363A320", Offset = "0x3639520", VA = "0x18363A320")]
		internal static void ANADGBKPLNB<T>(DCCIFJHAAKO reader, FEMEPFDGNFM<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x363A980", Offset = "0x3639B80", VA = "0x18363A980")]
		internal static void JEAAONFOJJH<T>(PGAHIIKCJMD writer, FEMEPFDGNFM<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x363A5E0", Offset = "0x36397E0", VA = "0x18363A5E0")]
		internal static void ANADGBKPLNB<T>(DCCIFJHAAKO reader, FEMEPFDGNFM<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x363A770", Offset = "0x3639970", VA = "0x18363A770")]
		internal static void JEAAONFOJJH<T>(PGAHIIKCJMD writer, FEMEPFDGNFM<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x363A410", Offset = "0x3639610", VA = "0x18363A410")]
		internal static void ANADGBKPLNB<T>(DCCIFJHAAKO reader, FEMEPFDGNFM<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x75A3100", Offset = "0x75A2300", VA = "0x1875A3100")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75A1090", Offset = "0x75A0290", VA = "0x1875A1090")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75A2B60", Offset = "0x75A1D60", VA = "0x1875A2B60")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x75A0E30", Offset = "0x75A0030", VA = "0x1875A0E30")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75A30A0", Offset = "0x75A22A0", VA = "0x1875A30A0")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75A0F10", Offset = "0x75A0110", VA = "0x1875A0F10")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75A2CD0", Offset = "0x75A1ED0", VA = "0x1875A2CD0")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x75A0F70", Offset = "0x75A0170", VA = "0x1875A0F70")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75A2C70", Offset = "0x75A1E70", VA = "0x1875A2C70")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75A12A0", Offset = "0x75A04A0", VA = "0x1875A12A0")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75A2D30", Offset = "0x75A1F30", VA = "0x1875A2D30")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x75A13C0", Offset = "0x75A05C0", VA = "0x1875A13C0")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75A3170", Offset = "0x75A2370", VA = "0x1875A3170")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x75A0D80", Offset = "0x759FF80", VA = "0x1875A0D80")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x75A2C00", Offset = "0x75A1E00", VA = "0x1875A2C00")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x75A1140", Offset = "0x75A0340", VA = "0x1875A1140")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75A2DA0", Offset = "0x75A1FA0", VA = "0x1875A2DA0")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75A11F0", Offset = "0x75A03F0", VA = "0x1875A11F0")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x363A840", Offset = "0x3639A40", VA = "0x18363A840")]
		internal static void JEAAONFOJJH<T>(PGAHIIKCJMD writer, FEMEPFDGNFM<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x363A4F0", Offset = "0x36396F0", VA = "0x18363A4F0")]
		internal static void ANADGBKPLNB<T>(DCCIFJHAAKO reader, FEMEPFDGNFM<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x75A2F90", Offset = "0x75A2190", VA = "0x1875A2F90")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x75A0FD0", Offset = "0x75A01D0", VA = "0x1875A0FD0")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x75A2E10", Offset = "0x75A2010", VA = "0x1875A2E10")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x75A1300", Offset = "0x75A0500", VA = "0x1875A1300")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x75A2F20", Offset = "0x75A2120", VA = "0x1875A2F20")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<KCJNGLILOOA> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x75A0EA0", Offset = "0x75A00A0", VA = "0x1875A0EA0")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<KCJNGLILOOA> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7588C70", Offset = "0x7587E70", VA = "0x187588C70")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, FEMEPFDGNFM<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7588820", Offset = "0x7587A20", VA = "0x187588820")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, FEMEPFDGNFM<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7588C70", Offset = "0x7587E70", VA = "0x187588C70")]
		internal static void JEAAONFOJJH(PGAHIIKCJMD writer, DJNFFIMKOOB prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7588820", Offset = "0x7587A20", VA = "0x187588820")]
		internal static void ANADGBKPLNB(DCCIFJHAAKO reader, DJNFFIMKOOB prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x363A9F0", Offset = "0x3639BF0", VA = "0x18363A9F0")]
		internal static T OLHPPNOJAJI<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x75A4860", Offset = "0x75A3A60", VA = "0x1875A4860")]
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
		[Cpp2IlInjected.Address(RVA = "0x75A4890", Offset = "0x75A3A90", VA = "0x1875A4890")]
		public void COGNOIDNGPM(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75A48A0", Offset = "0x75A3AA0", VA = "0x1875A48A0")]
		private void NIKEJJJNEJD(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3B624C0", Offset = "0x3B616C0", VA = "0x183B624C0")]
		private void FAEILBHKKAK<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
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
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			UpgradeToRoomLevelShapes = 123
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75A5980", Offset = "0x75A4B80", VA = "0x1875A5980")]
		public static bool DAALHHHHENH(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum DOHKGDFFKOL
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
[RegisterService(typeof(NDEOIINGKKI), new string[] { "Registry" })]
internal class POOAFGDDEEH : NDEOIINGKKI
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type EGMIJKJNDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x75A4630", Offset = "0x75A3830", VA = "0x1875A4630", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] CGPMGHEDEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7595460", Offset = "0x7594660", VA = "0x187595460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75A4610", Offset = "0x75A3810", VA = "0x1875A4610", Slot = "6")]
	public void AJHBJEFMHJF(IComponentDefaultRegistration JIOGNCPEKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public POOAFGDDEEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class BHHNHNBKCBM : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private class IJGLOBLEPAG : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7595430", Offset = "0x7594630", VA = "0x187595430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7595340", Offset = "0x7594540", VA = "0x187595340")]
		public IJGLOBLEPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F84300", Offset = "0x1F83500", VA = "0x181F84300", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 GFOILLNHEFN)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7595330", Offset = "0x7594530", VA = "0x187595330", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 GFOILLNHEFN, ObjectPrefabType_v1 OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7588D50", Offset = "0x7587F50", VA = "0x187588D50")]
	public BHHNHNBKCBM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75A4690", Offset = "0x75A3890", VA = "0x1875A4690")]
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
