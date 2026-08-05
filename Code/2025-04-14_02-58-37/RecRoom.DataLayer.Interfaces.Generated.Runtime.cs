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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78A1BA0", Offset = "0x78A05A0", VA = "0x1878A1BA0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x783DF70", Offset = "0x783C970", VA = "0x18783DF70", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x78B3C90", Offset = "0x78B2690", VA = "0x1878B3C90")]
		private void IPCGMJBOKKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78B3E00", Offset = "0x78B2800", VA = "0x1878B3E00")]
		private void PENEIAJNJEJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78B3F70", Offset = "0x78B2970", VA = "0x1878B3F70", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78B42B0", Offset = "0x78B2CB0", VA = "0x1878B42B0")]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
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
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[CompilerGenerated]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
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
public readonly struct DBDIPFEPNDG : IComparable<DBDIPFEPNDG>, IEquatable<DBDIPFEPNDG>
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DBDIPFEPNDG BOFAFIIEJCI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly DBDIPFEPNDG MPPHADDNLJD;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly DBDIPFEPNDG JIJDFGNOKAA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly DBDIPFEPNDG PIHNCOPMPFA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly DBDIPFEPNDG BBJPNELHNHG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly DBDIPFEPNDG LPOPFFFMBOB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly int DOAKEFBOPIA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type CLJLMBKGCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x78A0820", Offset = "0x789F220", VA = "0x1878A0820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KHMMHBDHIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78A1040", Offset = "0x789FA40", VA = "0x1878A1040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FPLMNCHJHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78A0B00", Offset = "0x789F500", VA = "0x1878A0B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type EIAEGKJEMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78A0C40", Offset = "0x789F640", VA = "0x1878A0C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OEIBNHPHEBP LOIOCFAAGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78A0D20", Offset = "0x789F720", VA = "0x1878A0D20")]
		get
		{
			return default(OEIBNHPHEBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IJNJMJNGEJK DDKCDIPNJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78A0900", Offset = "0x789F300", VA = "0x1878A0900")]
		get
		{
			return default(IJNJMJNGEJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LAFNOLPONHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78A06B0", Offset = "0x789F0B0", VA = "0x1878A06B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CMFKIPFOHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78A0FF0", Offset = "0x789F9F0", VA = "0x1878A0FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EGGNGOGFFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78A0EA0", Offset = "0x789F8A0", VA = "0x1878A0EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NAGNEPICMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78A0560", Offset = "0x789EF60", VA = "0x1878A0560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
	public DBDIPFEPNDG(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x78A07A0", Offset = "0x789F1A0", VA = "0x1878A07A0", Slot = "5")]
	public bool Equals(DBDIPFEPNDG OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x78A0700", Offset = "0x789F100", VA = "0x1878A0700", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x78A1180", Offset = "0x789FB80", VA = "0x1878A1180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x518E5D0", Offset = "0x518CFD0", VA = "0x18518E5D0", Slot = "4")]
	public int CompareTo(DBDIPFEPNDG OLKLGHOAKNE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct HLIGJNDODGC<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int DOAKEFBOPIA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private DBDIPFEPNDG IJIIPPHAMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		get
		{
			return default(DBDIPFEPNDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
	internal HLIGJNDODGC(int DOAKEFBOPIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D76B80", Offset = "0x1D75580", VA = "0x181D76B80")]
	public static DBDIPFEPNDG MEHFEEABIDG(HLIGJNDODGC<T> LDIFMBFDAPL)
	{
		return default(DBDIPFEPNDG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49678C0", Offset = "0x49662C0", VA = "0x1849678C0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4968850", Offset = "0x4967250", VA = "0x184968850", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x78951F0", Offset = "0x7893BF0", VA = "0x1878951F0")]
		public static (long, string, string) OGCINLHFMGN(KPBBJPOJBPM value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x78950B0", Offset = "0x7893AB0", VA = "0x1878950B0")]
		public static (long, string, string)[] AHJAAGOMHNF(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : EGPDLOGKCHH, NPJGMIPCEEB
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
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78A15C0", Offset = "0x789FFC0", VA = "0x1878A15C0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x78A1510", Offset = "0x789FF10", VA = "0x1878A1510", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78A1680", Offset = "0x78A0080", VA = "0x1878A1680")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Dictionary<Type, PMBFPOEHJMG> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Dictionary<Type, PMBFPOEHJMG> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78A16D0", Offset = "0x78A00D0", VA = "0x1878A16D0")]
		public static IReadOnlyDictionary<Type, PMBFPOEHJMG> ANCPKLJAHJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78A1720", Offset = "0x78A0120", VA = "0x1878A1720")]
		private Dictionary<Type, PMBFPOEHJMG> BLLBFFICICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78A17E0", Offset = "0x78A01E0", VA = "0x1878A17E0")]
		private void LLPAJDCHLNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x78A1B20", Offset = "0x78A0520", VA = "0x1878A1B20")]
		private readonly void NLCDBBKIDDA(Type interfaceType, PMBFPOEHJMG implementationType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78A3860", Offset = "0x78A2260", VA = "0x1878A3860")]
		public static Type[] LEIPNHBHPGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78A1C30", Offset = "0x78A0630", VA = "0x1878A1C30")]
		private static void BLLBFFICICF()
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
	public class SandboxDeformableShapeDefaults : JOMONHBMOBO, EGPDLOGKCHH, NPJGMIPCEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1510000", Offset = "0x150EA00", VA = "0x181510000", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x150FFF0", Offset = "0x150E9F0", VA = "0x18150FFF0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x78B27C0", Offset = "0x78B11C0", VA = "0x1878B27C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78B2680", Offset = "0x78B1080", VA = "0x1878B2680", Slot = "4")]
		public void ECPAKGCPJJJ(NPJGMIPCEEB networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
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
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003D")]
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
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public class R2SandboxDeformableShapeNetworkData : EGPDLOGKCHH, NPJGMIPCEEB, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private LEBBNCCOKKN service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x78B2260", Offset = "0x78B0C60", VA = "0x1878B2260", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x78B24E0", Offset = "0x78B0EE0", VA = "0x1878B24E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x78B21F0", Offset = "0x78B0BF0", VA = "0x1878B21F0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x78B2470", Offset = "0x78B0E70", VA = "0x1878B2470", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x78B23B0", Offset = "0x78B0DB0", VA = "0x1878B23B0", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x78B2550", Offset = "0x78B0F50", VA = "0x1878B2550", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x78B2340", Offset = "0x78B0D40", VA = "0x1878B2340", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x78B22D0", Offset = "0x78B0CD0", VA = "0x1878B22D0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x475FD50", Offset = "0x475E750", VA = "0x18475FD50")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, LEBBNCCOKKN networkDataService)
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
		public static readonly HLIGJNDODGC<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[R2Only]
		public static readonly HLIGJNDODGC<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[R2Only]
		public static readonly HLIGJNDODGC<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[R2Only]
		[IsBuffer]
		public static readonly HLIGJNDODGC<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly HLIGJNDODGC<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly HLIGJNDODGC<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[R2Only]
		public static readonly HLIGJNDODGC<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly HLIGJNDODGC<KDOFINIJEKG> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		[IsBuffer]
		public static readonly HLIGJNDODGC<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly HLIGJNDODGC<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[IsBuffer]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[R2Only]
		public static readonly HLIGJNDODGC<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		public static readonly HLIGJNDODGC<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[R2Only]
		public static readonly HLIGJNDODGC<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		public static readonly HLIGJNDODGC<EBEKHIBDNAC> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly HLIGJNDODGC<BBOGLCEBAKD> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly HLIGJNDODGC<int> CostumePieceSlotIndex_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly HLIGJNDODGC<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly HLIGJNDODGC<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly HLIGJNDODGC<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly HLIGJNDODGC<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly HLIGJNDODGC<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly HLIGJNDODGC<DDIJEGGEFPO> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		[IsBuffer]
		public static readonly HLIGJNDODGC<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly HLIGJNDODGC<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly HLIGJNDODGC<CPEEJIKFAAE> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		public static readonly HLIGJNDODGC<AHBNMJGLFPD> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly HLIGJNDODGC<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly HLIGJNDODGC<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly HLIGJNDODGC<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly HLIGJNDODGC<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly HLIGJNDODGC<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly HLIGJNDODGC<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly HLIGJNDODGC<LBBNALJLICL> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly HLIGJNDODGC<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly HLIGJNDODGC<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly HLIGJNDODGC<FFELHMGLKAD> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly HLIGJNDODGC<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly HLIGJNDODGC<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(GALCBOMIEOE))]
		public static readonly HLIGJNDODGC<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly HLIGJNDODGC<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly HLIGJNDODGC<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly HLIGJNDODGC<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly HLIGJNDODGC<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly HLIGJNDODGC<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly HLIGJNDODGC<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly HLIGJNDODGC<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly HLIGJNDODGC<EJODAALJJDB> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly HLIGJNDODGC<IHJHIPFBKPL> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly HLIGJNDODGC<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly HLIGJNDODGC<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly HLIGJNDODGC<PAAKCKFKCBH> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly HLIGJNDODGC<BBOGLCEBAKD> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly HLIGJNDODGC<FBKFJPCAJHI> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> CostumePieceParentCostume_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[IsBuffer]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly HLIGJNDODGC<JPHEOFPJKHK> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly HLIGJNDODGC<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly HLIGJNDODGC<OLNPFJCDOCE> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly HLIGJNDODGC<DJPDLJCIGFM> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[IsBuffer]
		[R2Only]
		public static readonly HLIGJNDODGC<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly HLIGJNDODGC<ECGPIELDBBK> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly HLIGJNDODGC<EOOPGOCNLLN> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly HLIGJNDODGC<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly HLIGJNDODGC<KPLMGPNDEAI> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly HLIGJNDODGC<HLDBNBPNCCB> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly HLIGJNDODGC<PPEOEAGKAEB> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly HLIGJNDODGC<CFBDDMMBAGN> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly HLIGJNDODGC<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly HLIGJNDODGC<PDPDCPPPIIG> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[RegisterService(typeof(POCHGMIILJI), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : POCHGMIILJI, NEHBEAAICPI, BLJGGMGKPKC
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
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xCA3D80", Offset = "0xCA2780", VA = "0x180CA3D80", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD10", Offset = "0xD49710", VA = "0x180D4AD10", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xE51830", Offset = "0xE50230", VA = "0x180E51830", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xDF4C00", Offset = "0xDF3600", VA = "0x180DF4C00", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4A0", Offset = "0x9AAEA0", VA = "0x1809AC4A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AC500", Offset = "0x9AAF00", VA = "0x1809AC500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BE0", Offset = "0x9B65E0", VA = "0x1809B7BE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BC0", Offset = "0x9B65C0", VA = "0x1809B7BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public OEIBNHPHEBP[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B20", Offset = "0x9B6520", VA = "0x1809B7B20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A80", Offset = "0x9B6480", VA = "0x1809B7A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, IJNJMJNGEJK> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BB0", Offset = "0x9B65B0", VA = "0x1809B7BB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B80", Offset = "0x9B6580", VA = "0x1809B7B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2CD72E0", Offset = "0x2CD5CE0", VA = "0x182CD72E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x78AE480", Offset = "0x78ACE80", VA = "0x1878AE480", Slot = "14")]
		public void GMFPMOLPFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x78AE3F0", Offset = "0x78ACDF0", VA = "0x1878AE3F0", Slot = "15")]
		public void FCBNDJLJLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x78A40F0", Offset = "0x78A2AF0", VA = "0x1878A40F0")]
		private void CJGDLPBPGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x78B0B80", Offset = "0x78AF580", VA = "0x1878B0B80")]
		public static void EFKNCHFBJKB(CMEMIDKHOHO writer, DBDIPFEPNDG property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x78AEB70", Offset = "0x78AD570", VA = "0x1878AEB70")]
		public static void DAKPMFAKNHF(AOOCFNFKJOL reader, DBDIPFEPNDG property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x78AF2E0", Offset = "0x78ADCE0", VA = "0x1878AF2E0")]
		private static void EAGCDNHKNEP(CMEMIDKHOHO writer, DBDIPFEPNDG property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x78B0BA0", Offset = "0x78AF5A0", VA = "0x1878B0BA0")]
		private static void OOEGFIJJOEN(AOOCFNFKJOL reader, DBDIPFEPNDG property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3814E40", Offset = "0x3813840", VA = "0x183814E40")]
		internal static void CFLEALCFLNK<T>(CMEMIDKHOHO writer, HLIGJNDODGC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3815270", Offset = "0x3813C70", VA = "0x183815270")]
		internal static void DHOLDBOACBA<T>(AOOCFNFKJOL reader, HLIGJNDODGC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3815190", Offset = "0x3813B90", VA = "0x183815190")]
		internal static void CFLEALCFLNK<T>(CMEMIDKHOHO writer, HLIGJNDODGC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3815530", Offset = "0x3813F30", VA = "0x183815530")]
		internal static void DHOLDBOACBA<T>(AOOCFNFKJOL reader, HLIGJNDODGC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3814F60", Offset = "0x3813960", VA = "0x183814F60")]
		internal static void CFLEALCFLNK<T>(CMEMIDKHOHO writer, HLIGJNDODGC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3815360", Offset = "0x3813D60", VA = "0x183815360")]
		internal static void DHOLDBOACBA<T>(AOOCFNFKJOL reader, HLIGJNDODGC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x78AEB00", Offset = "0x78AD500", VA = "0x1878AEB00")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78AF100", Offset = "0x78ADB00", VA = "0x1878AF100")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x78AEA60", Offset = "0x78AD460", VA = "0x1878AEA60")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x78AF090", Offset = "0x78ADA90", VA = "0x1878AF090")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x78AE680", Offset = "0x78AD080", VA = "0x1878AE680")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x78AEF20", Offset = "0x78AD920", VA = "0x1878AEF20")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x78AE990", Offset = "0x78AD390", VA = "0x1878AE990")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78AF030", Offset = "0x78ADA30", VA = "0x1878AF030")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x78AE6E0", Offset = "0x78AD0E0", VA = "0x1878AE6E0")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78AED60", Offset = "0x78AD760", VA = "0x1878AED60")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x78AE740", Offset = "0x78AD140", VA = "0x1878AE740")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x78AED00", Offset = "0x78AD700", VA = "0x1878AED00")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x78AE7A0", Offset = "0x78AD1A0", VA = "0x1878AE7A0")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78AEE70", Offset = "0x78AD870", VA = "0x1878AEE70")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x78AE9F0", Offset = "0x78AD3F0", VA = "0x1878AE9F0")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x78AEDC0", Offset = "0x78AD7C0", VA = "0x1878AEDC0")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x78AE810", Offset = "0x78AD210", VA = "0x1878AE810")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x78AEC50", Offset = "0x78AD650", VA = "0x1878AEC50")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x78AE490", Offset = "0x78ACE90", VA = "0x1878AE490")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x78AEF80", Offset = "0x78AD980", VA = "0x1878AEF80")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3815040", Offset = "0x3813A40", VA = "0x183815040")]
		internal static void CFLEALCFLNK<T>(CMEMIDKHOHO writer, HLIGJNDODGC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3815440", Offset = "0x3813E40", VA = "0x183815440")]
		internal static void DHOLDBOACBA<T>(AOOCFNFKJOL reader, HLIGJNDODGC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x78AE880", Offset = "0x78AD280", VA = "0x1878AE880")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x78AF220", Offset = "0x78ADC20", VA = "0x1878AF220")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x78AE570", Offset = "0x78ACF70", VA = "0x1878AE570")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x78AEB90", Offset = "0x78AD590", VA = "0x1878AEB90")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x78AE500", Offset = "0x78ACF00", VA = "0x1878AE500")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<BBOGLCEBAKD> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x78AF1B0", Offset = "0x78ADBB0", VA = "0x1878AF1B0")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<BBOGLCEBAKD> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7894B20", Offset = "0x7893520", VA = "0x187894B20")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, HLIGJNDODGC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7894C00", Offset = "0x7893600", VA = "0x187894C00")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, HLIGJNDODGC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7894B20", Offset = "0x7893520", VA = "0x187894B20")]
		internal static void CFLEALCFLNK(CMEMIDKHOHO writer, DBDIPFEPNDG prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7894C00", Offset = "0x7893600", VA = "0x187894C00")]
		internal static void DHOLDBOACBA(AOOCFNFKJOL reader, DBDIPFEPNDG prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3815620", Offset = "0x3814020", VA = "0x183815620")]
		internal static T KGIOFICLCLO<T>(this NativeArray<byte> data) where T : struct
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

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78B2820", Offset = "0x78B1220", VA = "0x1878B2820")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x78B2A70", Offset = "0x78B1470", VA = "0x1878B2A70")]
		public void BLLBFFICICF(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x78B2A80", Offset = "0x78B1480", VA = "0x1878B2A80")]
		private void LDJHLAMMFMF(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3D27540", Offset = "0x3D25F40", VA = "0x183D27540")]
		private void FCDIHBBFBDH<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3D27190", Offset = "0x3D25B90", VA = "0x183D27190")]
		private void EGIJBBFMAIP<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3D26A10", Offset = "0x3D25410", VA = "0x183D26A10")]
		private void ALEAIMFPAAH<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
			UpgradeStudioObjectPhysicsData = 145
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x78B4A00", Offset = "0x78B3400", VA = "0x1878B4A00")]
		public static bool IPHMIAENNPN(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum AMCGOGLKCLA
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
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
		[Cpp2IlInjected.Token(Token = "0x4000154")]
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
		[Cpp2IlInjected.Token(Token = "0x4000155")]
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
		[Cpp2IlInjected.Token(Token = "0x4000156")]
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
		[Cpp2IlInjected.Token(Token = "0x4000157")]
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
		[Cpp2IlInjected.Token(Token = "0x4000158")]
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
		[Cpp2IlInjected.Token(Token = "0x4000159")]
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
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[RegisterService(typeof(HBCAGIILDHF), new string[] { "Registry" })]
internal class OJNALFBGIAI : HBCAGIILDHF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type MBBGHJMMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x78B47D0", Offset = "0x78B31D0", VA = "0x1878B47D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] GKNNMIHBCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x78B47C0", Offset = "0x78B31C0", VA = "0x1878B47C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, PMBFPOEHJMG> MKDBHEADODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x78B4790", Offset = "0x78B3190", VA = "0x1878B4790", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x78B47A0", Offset = "0x78B31A0", VA = "0x1878B47A0", Slot = "7")]
	public void CAEHHGKINNO(IComponentDefaultRegistration LLIACBODNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OJNALFBGIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class BNKNGHGDCNN : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class EPJLOIGCMDL : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x78B4760", Offset = "0x78B3160", VA = "0x1878B4760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x78B4670", Offset = "0x78B3070", VA = "0x1878B4670")]
		public EPJLOIGCMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2083650", Offset = "0x2082050", VA = "0x182083650", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 MCJDMILNGAL)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x78B4660", Offset = "0x78B3060", VA = "0x1878B4660", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 MCJDMILNGAL, ObjectPrefabType_v1 PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x78B44E0", Offset = "0x78B2EE0", VA = "0x1878B44E0")]
	public BNKNGHGDCNN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x78B4830", Offset = "0x78B3230", VA = "0x1878B4830")]
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
