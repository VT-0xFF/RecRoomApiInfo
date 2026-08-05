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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
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
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x774DEC0", Offset = "0x774D2C0", VA = "0x18774DEC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77BE830", Offset = "0x77BDC30", VA = "0x1877BE830")]
		private void LBKELEMAONI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77BE9A0", Offset = "0x77BDDA0", VA = "0x1877BE9A0")]
		private void OCLIAJDDJMI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77BEB10", Offset = "0x77BDF10", VA = "0x1877BEB10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77BEE50", Offset = "0x77BE250", VA = "0x1877BEE50")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
	[Cpp2IlInjected.Token(Token = "0x2000006")]
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
	[Cpp2IlInjected.Token(Token = "0x2000007")]
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
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v5 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KEDFBBCLKIC : IComparable<KEDFBBCLKIC>, IEquatable<KEDFBBCLKIC>
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KEDFBBCLKIC DBEDOALFIKK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KEDFBBCLKIC OABGEBPNMEC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KEDFBBCLKIC GELDLBLCIJM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KEDFBBCLKIC JANJGHAFIFI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KEDFBBCLKIC AEOIEAEBHND;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KEDFBBCLKIC NDCPNNGBBJI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int KDCAMOIGIMA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BNBIOAJGDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type KDPMAEAPPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77AD110", Offset = "0x77AC510", VA = "0x1877AD110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MCKFPDMFILD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77AD320", Offset = "0x77AC720", VA = "0x1877AD320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FONFMMJKOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77ADA20", Offset = "0x77ACE20", VA = "0x1877ADA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type HJDIGNPIAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77AD770", Offset = "0x77ACB70", VA = "0x1877AD770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CHJPACCNFAL JEDMDLKHBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77AD850", Offset = "0x77ACC50", VA = "0x1877AD850")]
		get
		{
			return default(CHJPACCNFAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FILNHIOJNMN ECDCFLKCJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77ACF10", Offset = "0x77AC310", VA = "0x1877ACF10")]
		get
		{
			return default(FILNHIOJNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FJDAAEBCLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77AD9D0", Offset = "0x77ACDD0", VA = "0x1877AD9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ADHJCHADOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77AD720", Offset = "0x77ACB20", VA = "0x1877AD720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool INLKKMEEHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77AD460", Offset = "0x77AC860", VA = "0x1877AD460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KAMPJBCINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77AD5C0", Offset = "0x77AC9C0", VA = "0x1877AD5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
	public KEDFBBCLKIC(int KDCAMOIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77AD2A0", Offset = "0x77AC6A0", VA = "0x1877AD2A0", Slot = "5")]
	public bool Equals(KEDFBBCLKIC JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77AD1F0", Offset = "0x77AC5F0", VA = "0x1877AD1F0", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77ADB60", Offset = "0x77ACF60", VA = "0x1877ADB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x426D850", Offset = "0x426CC50", VA = "0x18426D850", Slot = "4")]
	public int CompareTo(KEDFBBCLKIC JAPIEEBOJEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct AOFDCDBHDKC<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly int KDCAMOIGIMA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private KEDFBBCLKIC FDIBAKAAFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
		get
		{
			return default(KEDFBBCLKIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
	internal AOFDCDBHDKC(int KDCAMOIGIMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D17060", Offset = "0x1D16460", VA = "0x181D17060")]
	public static KEDFBBCLKIC MDKCMNAEKLA(AOFDCDBHDKC<T> ODLMGDFMFJG)
	{
		return default(KEDFBBCLKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A1D220", Offset = "0x4A1C620", VA = "0x184A1D220", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DC60", Offset = "0x4A1D060", VA = "0x184A1DC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77A1B50", Offset = "0x77A0F50", VA = "0x1877A1B50")]
		public static (long, string, string) PGHFGLJCFMM(PMHBKOEDEGH value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x77A1A10", Offset = "0x77A0E10", VA = "0x1877A1A10")]
		public static (long, string, string)[] EDPJOBIIPDC(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x77AFA30", Offset = "0x77AEE30", VA = "0x1877AFA30")]
		public static Type[] KOEPDCDIJJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x77ADEF0", Offset = "0x77AD2F0", VA = "0x1877ADEF0")]
		private static void ELBDPICAHPN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public enum ObjectPrefabType_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		CostumePieceShapeContainer = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		UNUSED = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Other_InteractionFilter_Tags = 6005,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		UNUSED2 = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		GameObject_HierarchyObject = 7002,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		GameObject_PlayerRbex = 7005,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		GameObject_StudioProp = 7006,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		GameObject_NetworkedTransform = 7007,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		GameObject_PlayerNetworkedTransform = 7008,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		GameObject_HierarchyObject_Container = 7009,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		GameObject_Socket = 7010,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		GameObject_PlayerSocket = 7011,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		GameObject_PlayerRbexNetworkedTransform = 7012,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		GameObject_CostumeDummy = 7013,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		GameObject_Replicator = 7014,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		GameObject_NonHierarchicalObject = 7015,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v3 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		SuppressCollision = 16384,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static readonly AOFDCDBHDKC<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly AOFDCDBHDKC<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly AOFDCDBHDKC<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly AOFDCDBHDKC<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly AOFDCDBHDKC<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly AOFDCDBHDKC<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly AOFDCDBHDKC<CIIOGCMNFDK> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static readonly AOFDCDBHDKC<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static readonly AOFDCDBHDKC<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static readonly AOFDCDBHDKC<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly AOFDCDBHDKC<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly AOFDCDBHDKC<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly AOFDCDBHDKC<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly AOFDCDBHDKC<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly AOFDCDBHDKC<BNNPCJEEJFG> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static readonly AOFDCDBHDKC<ICHONNPKFBH> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly AOFDCDBHDKC<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static readonly AOFDCDBHDKC<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly AOFDCDBHDKC<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static readonly AOFDCDBHDKC<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static readonly AOFDCDBHDKC<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly AOFDCDBHDKC<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly AOFDCDBHDKC<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly AOFDCDBHDKC<NFOAHHPMJGH> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static readonly AOFDCDBHDKC<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly AOFDCDBHDKC<byte> ContainerNameBuffer_data;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static readonly AOFDCDBHDKC<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly AOFDCDBHDKC<NFCAIDCIJJF> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly AOFDCDBHDKC<GCBGIGDHMFN> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly AOFDCDBHDKC<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly AOFDCDBHDKC<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static readonly AOFDCDBHDKC<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static readonly AOFDCDBHDKC<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly AOFDCDBHDKC<LocalId> EntityPrefabPartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly AOFDCDBHDKC<uint> EntityPrefabPartData_partId;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly AOFDCDBHDKC<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly AOFDCDBHDKC<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static readonly AOFDCDBHDKC<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly AOFDCDBHDKC<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly AOFDCDBHDKC<IPEFDNGGMKI> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly AOFDCDBHDKC<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly AOFDCDBHDKC<bool> ContainerIsRecolorableData_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly AOFDCDBHDKC<JIHOGGHEDMF> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly AOFDCDBHDKC<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly AOFDCDBHDKC<uint> AuthoredAIIdData_Value;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly AOFDCDBHDKC<int> ReplicatorMaxObjectCountData_count;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly AOFDCDBHDKC<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly AOFDCDBHDKC<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly AOFDCDBHDKC<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly AOFDCDBHDKC<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly AOFDCDBHDKC<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly AOFDCDBHDKC<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly AOFDCDBHDKC<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly AOFDCDBHDKC<HCFAOKCHPKF> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly AOFDCDBHDKC<CGNLCNMEKCO> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly AOFDCDBHDKC<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly AOFDCDBHDKC<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly AOFDCDBHDKC<NMNNBIJOGOM> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly AOFDCDBHDKC<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly AOFDCDBHDKC<ICHONNPKFBH> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly AOFDCDBHDKC<FNONMPLFBAH> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly AOFDCDBHDKC<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly AOFDCDBHDKC<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly AOFDCDBHDKC<IJKALMPDIAP> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly AOFDCDBHDKC<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly AOFDCDBHDKC<PBCNMOHBOKP> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly AOFDCDBHDKC<COHGCJIEJHF> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly AOFDCDBHDKC<GFLDGCHPDND> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly AOFDCDBHDKC<IEHBBGFNHHB> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly AOFDCDBHDKC<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly AOFDCDBHDKC<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly AOFDCDBHDKC<GDMHDEGEKJE> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly AOFDCDBHDKC<JBEIFKBPHCL> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly AOFDCDBHDKC<JPHGCKAMKCE> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly AOFDCDBHDKC<CFMKEFNDENA> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly AOFDCDBHDKC<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly AOFDCDBHDKC<MDOHGMNCHPB> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	[RegisterService(typeof(MLPPLFNEKCB), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : MLPPLFNEKCB, DJEMOHLCCKH, AOPBNJCLOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB9A2C0", Offset = "0xB996C0", VA = "0x180B9A2C0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC6CCA0", Offset = "0xC6C0A0", VA = "0x180C6CCA0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD250C0", Offset = "0xD244C0", VA = "0x180D250C0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE1F7E0", Offset = "0xE1EBE0", VA = "0x180E1F7E0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9933A0", Offset = "0x9927A0", VA = "0x1809933A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x993280", Offset = "0x992680", VA = "0x180993280", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x993410", Offset = "0x992810", VA = "0x180993410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public CHJPACCNFAL[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x997460", Offset = "0x996860", VA = "0x180997460", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x997470", Offset = "0x996870", VA = "0x180997470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, FILNHIOJNMN> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x993540", Offset = "0x992940", VA = "0x180993540", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9932B0", Offset = "0x9926B0", VA = "0x1809932B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x77B0240", Offset = "0x77AF640", VA = "0x1877B0240", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x77B9D40", Offset = "0x77B9140", VA = "0x1877B9D40", Slot = "13")]
		public void PJBBKCOPPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x77B0260", Offset = "0x77AF660", VA = "0x1877B0260", Slot = "14")]
		public void GBFOCOOFFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x77B02C0", Offset = "0x77AF6C0", VA = "0x1877B02C0")]
		private void KKPPAHHKFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77B9D50", Offset = "0x77B9150", VA = "0x1877B9D50")]
		public static void ALHJMALBGGA(CKFKLPNGNNL writer, KEDFBBCLKIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77BBAD0", Offset = "0x77BAED0", VA = "0x1877BBAD0")]
		public static void OBLANEMNDKF(ONCEGKAJGLL reader, KEDFBBCLKIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77B9D70", Offset = "0x77B9170", VA = "0x1877B9D70")]
		private static void CLEIPEHEACF(CKFKLPNGNNL writer, KEDFBBCLKIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x77BC1E0", Offset = "0x77BB5E0", VA = "0x1877BC1E0")]
		private static void PGIJKDLGAFB(ONCEGKAJGLL reader, KEDFBBCLKIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x37C3620", Offset = "0x37C2A20", VA = "0x1837C3620")]
		internal static void LMGGAKIACNI<T>(CKFKLPNGNNL writer, AOFDCDBHDKC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37C3A50", Offset = "0x37C2E50", VA = "0x1837C3A50")]
		internal static void OJJOMCGFFJC<T>(ONCEGKAJGLL reader, AOFDCDBHDKC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37C3970", Offset = "0x37C2D70", VA = "0x1837C3970")]
		internal static void LMGGAKIACNI<T>(CKFKLPNGNNL writer, AOFDCDBHDKC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x37C3D10", Offset = "0x37C3110", VA = "0x1837C3D10")]
		internal static void OJJOMCGFFJC<T>(ONCEGKAJGLL reader, AOFDCDBHDKC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x37C3740", Offset = "0x37C2B40", VA = "0x1837C3740")]
		internal static void LMGGAKIACNI<T>(CKFKLPNGNNL writer, AOFDCDBHDKC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x37C3B40", Offset = "0x37C2F40", VA = "0x1837C3B40")]
		internal static void OJJOMCGFFJC<T>(ONCEGKAJGLL reader, AOFDCDBHDKC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77BB990", Offset = "0x77BAD90", VA = "0x1877BB990")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x77BBE20", Offset = "0x77BB220", VA = "0x1877BBE20")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77BB510", Offset = "0x77BA910", VA = "0x1877BB510")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77BC050", Offset = "0x77BB450", VA = "0x1877BC050")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x77BB4B0", Offset = "0x77BA8B0", VA = "0x1877BB4B0")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77BBF30", Offset = "0x77BB330", VA = "0x1877BBF30")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77BB450", Offset = "0x77BA850", VA = "0x1877BB450")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x77BBED0", Offset = "0x77BB2D0", VA = "0x1877BBED0")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77BBA70", Offset = "0x77BAE70", VA = "0x1877BBA70")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77BBAF0", Offset = "0x77BAEF0", VA = "0x1877BBAF0")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77BB620", Offset = "0x77BAA20", VA = "0x1877BB620")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x77BBB50", Offset = "0x77BAF50", VA = "0x1877BBB50")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x77BB920", Offset = "0x77BAD20", VA = "0x1877BB920")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x77BBD70", Offset = "0x77BB170", VA = "0x1877BBD70")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x77BBA00", Offset = "0x77BAE00", VA = "0x1877BBA00")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x77BC0C0", Offset = "0x77BB4C0", VA = "0x1877BC0C0")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77BB7A0", Offset = "0x77BABA0", VA = "0x1877BB7A0")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77BBCC0", Offset = "0x77BB0C0", VA = "0x1877BBCC0")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37C3820", Offset = "0x37C2C20", VA = "0x1837C3820")]
		internal static void LMGGAKIACNI<T>(CKFKLPNGNNL writer, AOFDCDBHDKC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x37C3C20", Offset = "0x37C3020", VA = "0x1837C3C20")]
		internal static void OJJOMCGFFJC<T>(ONCEGKAJGLL reader, AOFDCDBHDKC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77BB690", Offset = "0x77BAA90", VA = "0x1877BB690")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x77BBC00", Offset = "0x77BB000", VA = "0x1877BBC00")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77BB810", Offset = "0x77BAC10", VA = "0x1877BB810")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77BBF90", Offset = "0x77BB390", VA = "0x1877BBF90")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77BB5B0", Offset = "0x77BA9B0", VA = "0x1877BB5B0")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<ICHONNPKFBH> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77BC170", Offset = "0x77BB570", VA = "0x1877BC170")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<ICHONNPKFBH> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77A14E0", Offset = "0x77A08E0", VA = "0x1877A14E0")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, AOFDCDBHDKC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77A1880", Offset = "0x77A0C80", VA = "0x1877A1880")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, AOFDCDBHDKC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77A14E0", Offset = "0x77A08E0", VA = "0x1877A14E0")]
		internal static void LMGGAKIACNI(CKFKLPNGNNL writer, KEDFBBCLKIC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77A1880", Offset = "0x77A0C80", VA = "0x1877A1880")]
		internal static void OJJOMCGFFJC(ONCEGKAJGLL reader, KEDFBBCLKIC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x37C35A0", Offset = "0x37C29A0", VA = "0x1837C35A0")]
		internal static T FDCDKKAMIAI<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77BD6A0", Offset = "0x77BCAA0", VA = "0x1877BD6A0")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77BE820", Offset = "0x77BDC20", VA = "0x1877BE820")]
		public void ELBDPICAHPN(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x77BD6D0", Offset = "0x77BCAD0", VA = "0x1877BD6D0")]
		private void ABEJFDKFECO(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFCD0", Offset = "0x3CDF0D0", VA = "0x183CDFCD0")]
		private void KGBPPCMFCDL<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			UpgradeToRoomLevelShapes = 123
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x77BF590", Offset = "0x77BE990", VA = "0x1877BF590")]
		public static bool LMFHOCHKNBB(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum DEGFMJFEKGN
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4096)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14071844096648088262uL)]
	internal struct AuthoredAIMetaData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xFFE")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(AGBHOHIHOPK), new string[] { "Registry" })]
internal class JNFLDFAGIKJ : AGBHOHIHOPK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type KLKPPNBNBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x77BF0A0", Offset = "0x77BE4A0", VA = "0x1877BF0A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] BODFINAOGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77BF100", Offset = "0x77BE500", VA = "0x1877BF100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77BF080", Offset = "0x77BE480", VA = "0x1877BF080", Slot = "6")]
	public void AAHAOEPECIL(IComponentDefaultRegistration NMGMIAFBJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public JNFLDFAGIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal class NDHALIOPALO : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private class KLDEABCDIHE : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string EDDDAEGNADF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x77BF210", Offset = "0x77BE610", VA = "0x1877BF210", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool GKMGMAJNIBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x77BF120", Offset = "0x77BE520", VA = "0x1877BF120")]
		public KLDEABCDIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x20137E0", Offset = "0x2012BE0", VA = "0x1820137E0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 PHDMEDCBLHH)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x77BF110", Offset = "0x77BE510", VA = "0x1877BF110", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 PHDMEDCBLHH, ObjectPrefabType_v1 FIIKLGCIAGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x77BF240", Offset = "0x77BE640", VA = "0x1877BF240")]
	public NDHALIOPALO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77BF3C0", Offset = "0x77BE7C0", VA = "0x1877BF3C0")]
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
