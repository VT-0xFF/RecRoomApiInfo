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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75246B0", Offset = "0x7523AB0", VA = "0x1875246B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7593A60", Offset = "0x7592E60", VA = "0x187593A60")]
		private void PFONFFPEPLP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75938F0", Offset = "0x7592CF0", VA = "0x1875938F0")]
		private void OHDICCNDNDO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7593BD0", Offset = "0x7592FD0", VA = "0x187593BD0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7593F10", Offset = "0x7593310", VA = "0x187593F10")]
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
public readonly struct BNBJJKJBEKP : IComparable<BNBJJKJBEKP>, IEquatable<BNBJJKJBEKP>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly BNBJJKJBEKP GMGPCBOIDPO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly BNBJJKJBEKP MPBEEFKHJNK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly BNBJJKJBEKP NGGHLLAHBOC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly BNBJJKJBEKP JBDCDKBODDO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly BNBJJKJBEKP NEICAEGPHIA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly BNBJJKJBEKP FBKMNCDABLB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly int FFCBHHABFJN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NGGCGOFGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type KPPEHPOAJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7577650", Offset = "0x7576A50", VA = "0x187577650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CDNMPCJCEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7577A40", Offset = "0x7576E40", VA = "0x187577A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KHIDBOMGENB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7577780", Offset = "0x7576B80", VA = "0x187577780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type CDFCFCLGBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75770D0", Offset = "0x75764D0", VA = "0x1875770D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EOKPCIJNBFB NKNKBHKCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75778C0", Offset = "0x7576CC0", VA = "0x1875778C0")]
		get
		{
			return default(EOKPCIJNBFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IHOMGLADJDB MHKEEJLAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75771B0", Offset = "0x75765B0", VA = "0x1875771B0")]
		get
		{
			return default(IHOMGLADJDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DJMOEFJPHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7577B80", Offset = "0x7576F80", VA = "0x187577B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GJNNDKPNONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7577730", Offset = "0x7576B30", VA = "0x187577730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HKIAJKOCFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7577500", Offset = "0x7576900", VA = "0x187577500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NLFNBBNLMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75773B0", Offset = "0x75767B0", VA = "0x1875773B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
	public BNBJJKJBEKP(int FFCBHHABFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7577050", Offset = "0x7576450", VA = "0x187577050", Slot = "5")]
	public bool Equals(BNBJJKJBEKP MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7576FB0", Offset = "0x75763B0", VA = "0x187576FB0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7577BD0", Offset = "0x7576FD0", VA = "0x187577BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63E9550", Offset = "0x63E8950", VA = "0x1863E9550", Slot = "4")]
	public int CompareTo(BNBJJKJBEKP MNALNBMKJLK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GILEEGGEBMH<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int FFCBHHABFJN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private BNBJJKJBEKP PAINDACCBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
		get
		{
			return default(BNBJJKJBEKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
	internal GILEEGGEBMH(int FFCBHHABFJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C8C810", Offset = "0x1C8BC10", VA = "0x181C8C810")]
	public static BNBJJKJBEKP JKGHIELMIOO(GILEEGGEBMH<T> MFGHKKFEKII)
	{
		return default(BNBJJKJBEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x466E520", Offset = "0x466D920", VA = "0x18466E520", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x466F790", Offset = "0x466EB90", VA = "0x18466F790", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x75780A0", Offset = "0x75774A0", VA = "0x1875780A0")]
		public static (long, string, string) OAFNNAIKEAM(CNBJKFKGILJ value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7577F60", Offset = "0x7577360", VA = "0x187577F60")]
		public static (long, string, string)[] HDCGJNHGMDO(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x7583540", Offset = "0x7582940", VA = "0x187583540")]
		public static Type[] IIJHPDNLMDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7583710", Offset = "0x7582B10", VA = "0x187583710")]
		private static void ICLMLJMBJAH()
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
		public static readonly GILEEGGEBMH<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly GILEEGGEBMH<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly GILEEGGEBMH<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly GILEEGGEBMH<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly GILEEGGEBMH<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly GILEEGGEBMH<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly GILEEGGEBMH<BGOAJJLHILN> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly GILEEGGEBMH<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly GILEEGGEBMH<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly GILEEGGEBMH<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly GILEEGGEBMH<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly GILEEGGEBMH<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly GILEEGGEBMH<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly GILEEGGEBMH<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static readonly GILEEGGEBMH<JIMPHAPNHNN> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static readonly GILEEGGEBMH<OOOKFBDHBLL> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly GILEEGGEBMH<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly GILEEGGEBMH<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly GILEEGGEBMH<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly GILEEGGEBMH<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly GILEEGGEBMH<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly GILEEGGEBMH<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static readonly GILEEGGEBMH<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static readonly GILEEGGEBMH<CPBJDAJGNMI> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static readonly GILEEGGEBMH<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly GILEEGGEBMH<byte> ContainerNameBuffer_data;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly GILEEGGEBMH<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly GILEEGGEBMH<KBLOCDAJKPE> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly GILEEGGEBMH<KKPFGOPCOFD> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly GILEEGGEBMH<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static readonly GILEEGGEBMH<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly GILEEGGEBMH<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static readonly GILEEGGEBMH<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly GILEEGGEBMH<LocalId> EntityPrefabPartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static readonly GILEEGGEBMH<uint> EntityPrefabPartData_partId;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static readonly GILEEGGEBMH<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly GILEEGGEBMH<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly GILEEGGEBMH<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly GILEEGGEBMH<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static readonly GILEEGGEBMH<KCPENIPBKIG> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly GILEEGGEBMH<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static readonly GILEEGGEBMH<OAHBOFCALAL> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly GILEEGGEBMH<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly GILEEGGEBMH<int> ReplicatorMaxObjectCountData_count;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly GILEEGGEBMH<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly GILEEGGEBMH<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static readonly GILEEGGEBMH<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static readonly GILEEGGEBMH<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly GILEEGGEBMH<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly GILEEGGEBMH<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly GILEEGGEBMH<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly GILEEGGEBMH<JDKHCFMOIGK> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static readonly GILEEGGEBMH<DDBKNDGEJJI> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly GILEEGGEBMH<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly GILEEGGEBMH<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly GILEEGGEBMH<AOLFKOBBCMH> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly GILEEGGEBMH<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly GILEEGGEBMH<OOOKFBDHBLL> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly GILEEGGEBMH<PCICPALBLMA> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly GILEEGGEBMH<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly GILEEGGEBMH<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly GILEEGGEBMH<EBCIGMMPLDE> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly GILEEGGEBMH<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly GILEEGGEBMH<PKLLCJNIDEP> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly GILEEGGEBMH<PKNBEJKCAGA> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly GILEEGGEBMH<AEGHABAAKPJ> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly GILEEGGEBMH<AICLOPCAKOK> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly GILEEGGEBMH<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly GILEEGGEBMH<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly GILEEGGEBMH<AOEEPDNIMOA> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly GILEEGGEBMH<LBNCIFLCFMG> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly GILEEGGEBMH<AHINPDENBMA> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly GILEEGGEBMH<FGDPIGOCJKP> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly GILEEGGEBMH<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly GILEEGGEBMH<NHILINKIAMC> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	[RegisterService(typeof(GIFLCCBKEAJ), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : GIFLCCBKEAJ, LBIEIAKECGD, JOOHDJKBMLK
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
			[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC15800", Offset = "0xC14C00", VA = "0x180C15800", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCAFA20", Offset = "0xCAEE20", VA = "0x180CAFA20", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDAD2F0", Offset = "0xDAC6F0", VA = "0x180DAD2F0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9642D0", Offset = "0x9636D0", VA = "0x1809642D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9642C0", Offset = "0x9636C0", VA = "0x1809642C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9642E0", Offset = "0x9636E0", VA = "0x1809642E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public EOKPCIJNBFB[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9642F0", Offset = "0x9636F0", VA = "0x1809642F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x964300", Offset = "0x963700", VA = "0x180964300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, IHOMGLADJDB> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9650B0", Offset = "0x9644B0", VA = "0x1809650B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9650C0", Offset = "0x9644C0", VA = "0x1809650C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75858C0", Offset = "0x7584CC0", VA = "0x1875858C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75858E0", Offset = "0x7584CE0", VA = "0x1875858E0", Slot = "13")]
		public void HMOAEPFIPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7585860", Offset = "0x7584C60", VA = "0x187585860", Slot = "14")]
		public void CAHNJLIHDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75858F0", Offset = "0x7584CF0", VA = "0x1875858F0")]
		private void NIFFNMLMHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7590F20", Offset = "0x7590320", VA = "0x187590F20")]
		public static void OBPNIBOMLDN(JCIOOBBNDNE writer, BNBJJKJBEKP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x758ED60", Offset = "0x758E160", VA = "0x18758ED60")]
		public static void AAOEGFMHOMM(GKEMPPLDMIL reader, BNBJJKJBEKP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7590F40", Offset = "0x7590340", VA = "0x187590F40")]
		private static void PFALEEIGCDH(JCIOOBBNDNE writer, BNBJJKJBEKP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x758F400", Offset = "0x758E800", VA = "0x18758F400")]
		private static void HNLJCPEKHOL(GKEMPPLDMIL reader, BNBJJKJBEKP property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x364BB90", Offset = "0x364AF90", VA = "0x18364BB90")]
		internal static void EFGCEHNIDJN<T>(JCIOOBBNDNE writer, GILEEGGEBMH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x364BFC0", Offset = "0x364B3C0", VA = "0x18364BFC0")]
		internal static void NHMCOOCBIHH<T>(GKEMPPLDMIL reader, GILEEGGEBMH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x364BEE0", Offset = "0x364B2E0", VA = "0x18364BEE0")]
		internal static void EFGCEHNIDJN<T>(JCIOOBBNDNE writer, GILEEGGEBMH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x364C280", Offset = "0x364B680", VA = "0x18364C280")]
		internal static void NHMCOOCBIHH<T>(GKEMPPLDMIL reader, GILEEGGEBMH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x364BCB0", Offset = "0x364B0B0", VA = "0x18364BCB0")]
		internal static void EFGCEHNIDJN<T>(JCIOOBBNDNE writer, GILEEGGEBMH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x364C0B0", Offset = "0x364B4B0", VA = "0x18364C0B0")]
		internal static void NHMCOOCBIHH<T>(GKEMPPLDMIL reader, GILEEGGEBMH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x758ED80", Offset = "0x758E180", VA = "0x18758ED80")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7590DC0", Offset = "0x75901C0", VA = "0x187590DC0")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x758EEB0", Offset = "0x758E2B0", VA = "0x18758EEB0")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7590830", Offset = "0x758FC30", VA = "0x187590830")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x758EDF0", Offset = "0x758E1F0", VA = "0x18758EDF0")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7590D60", Offset = "0x7590160", VA = "0x187590D60")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x758F1B0", Offset = "0x758E5B0", VA = "0x18758F1B0")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7590CA0", Offset = "0x75900A0", VA = "0x187590CA0")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x758EE50", Offset = "0x758E250", VA = "0x18758EE50")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7590D00", Offset = "0x7590100", VA = "0x187590D00")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x758F280", Offset = "0x758E680", VA = "0x18758F280")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7590B80", Offset = "0x758FF80", VA = "0x187590B80")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x758F0D0", Offset = "0x758E4D0", VA = "0x18758F0D0")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7590AD0", Offset = "0x758FED0", VA = "0x187590AD0")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x758F210", Offset = "0x758E610", VA = "0x18758F210")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7590E70", Offset = "0x7590270", VA = "0x187590E70")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x758F060", Offset = "0x758E460", VA = "0x18758F060")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7590960", Offset = "0x758FD60", VA = "0x187590960")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x364BD90", Offset = "0x364B190", VA = "0x18364BD90")]
		internal static void EFGCEHNIDJN<T>(JCIOOBBNDNE writer, GILEEGGEBMH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x364C190", Offset = "0x364B590", VA = "0x18364C190")]
		internal static void NHMCOOCBIHH<T>(GKEMPPLDMIL reader, GILEEGGEBMH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x758F2F0", Offset = "0x758E6F0", VA = "0x18758F2F0")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x75908A0", Offset = "0x758FCA0", VA = "0x1875908A0")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x758EF50", Offset = "0x758E350", VA = "0x18758EF50")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7590A10", Offset = "0x758FE10", VA = "0x187590A10")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x758F140", Offset = "0x758E540", VA = "0x18758F140")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<OOOKFBDHBLL> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7590C30", Offset = "0x7590030", VA = "0x187590C30")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<OOOKFBDHBLL> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7576A80", Offset = "0x7575E80", VA = "0x187576A80")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, GILEEGGEBMH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7576B60", Offset = "0x7575F60", VA = "0x187576B60")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, GILEEGGEBMH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7576A80", Offset = "0x7575E80", VA = "0x187576A80")]
		internal static void EFGCEHNIDJN(JCIOOBBNDNE writer, BNBJJKJBEKP prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7576B60", Offset = "0x7575F60", VA = "0x187576B60")]
		internal static void NHMCOOCBIHH(GKEMPPLDMIL reader, BNBJJKJBEKP prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x364BB10", Offset = "0x364AF10", VA = "0x18364BB10")]
		internal static T DJOMEHAOJIE<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x75927C0", Offset = "0x7591BC0", VA = "0x1875927C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75938D0", Offset = "0x7592CD0", VA = "0x1875938D0")]
		public void ICLMLJMBJAH(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75927F0", Offset = "0x7591BF0", VA = "0x1875927F0")]
		private void AEACINCKFKA(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3B47D00", Offset = "0x3B47100", VA = "0x183B47D00")]
		private void MLOKEEOKCNH<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x75938E0", Offset = "0x7592CE0", VA = "0x1875938E0")]
		public static bool EMDJBEBIKMD(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum EHJEIJAJNCE
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
[RegisterService(typeof(COBAKPIBKEM), new string[] { "Registry" })]
internal class IIMCEMKMIOB : COBAKPIBKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type APHLBHADGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x75834C0", Offset = "0x75828C0", VA = "0x1875834C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] PPMDFCCIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7583540", Offset = "0x7582940", VA = "0x187583540", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7583520", Offset = "0x7582920", VA = "0x187583520", Slot = "6")]
	public void LPIDAPAEDGD(IComponentDefaultRegistration HBCJAJAGDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public IIMCEMKMIOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class LBKODAOMMKD : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private class FFJNNLGJGGL : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7583490", Offset = "0x7582890", VA = "0x187583490", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x75833A0", Offset = "0x75827A0", VA = "0x1875833A0")]
		public FFJNNLGJGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F83240", Offset = "0x1F82640", VA = "0x181F83240", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 EOMAFKDOFHE)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7583390", Offset = "0x7582790", VA = "0x187583390", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 EOMAFKDOFHE, ObjectPrefabType_v1 PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7583590", Offset = "0x7582990", VA = "0x187583590")]
	public LBKODAOMMKD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75925F0", Offset = "0x75919F0", VA = "0x1875925F0")]
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
