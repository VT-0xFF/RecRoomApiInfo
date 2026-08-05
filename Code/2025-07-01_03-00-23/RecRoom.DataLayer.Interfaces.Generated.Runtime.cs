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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E0A0", Offset = "0x7F3C6A0", VA = "0x187F3E0A0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2251A10", Offset = "0x2250010", VA = "0x182251A10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F51A80", Offset = "0x7F50080", VA = "0x187F51A80")]
		private void FKDKBEPAOOM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F51BF0", Offset = "0x7F501F0", VA = "0x187F51BF0")]
		private void HCPAJCJNEGO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F51D60", Offset = "0x7F50360", VA = "0x187F51D60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F520A0", Offset = "0x7F506A0", VA = "0x187F520A0")]
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
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
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
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[CompilerGenerated]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[CompilerGenerated]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
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
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
public readonly struct LNGKIIMFKIB : IComparable<LNGKIIMFKIB>, IEquatable<LNGKIIMFKIB>
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly LNGKIIMFKIB PAIEKNMKJII;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly LNGKIIMFKIB JCJCJCMAFJK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LNGKIIMFKIB NPOEIGFFKHG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly LNGKIIMFKIB LKANPDJOEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LNGKIIMFKIB AEIPKHPGBOO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly LNGKIIMFKIB GACNPJEOEMM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly int KHMHPNKMLMD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type AKMEOHBEJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D240", Offset = "0x7F3B840", VA = "0x187F3D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FKCGNHACNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3DA80", Offset = "0x7F3C080", VA = "0x187F3DA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GBKBNOBKILL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3DBC0", Offset = "0x7F3C1C0", VA = "0x187F3DBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type CHJIPPLJNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D640", Offset = "0x7F3BC40", VA = "0x187F3D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JFKLMPPHNJN IBIBCEFJDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D0C0", Offset = "0x7F3B6C0", VA = "0x187F3D0C0")]
		get
		{
			return default(JFKLMPPHNJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IAGCDDDBJLC LODICKHCAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D440", Offset = "0x7F3BA40", VA = "0x187F3D440")]
		get
		{
			return default(IAGCDDDBJLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LOGDNKPJJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D720", Offset = "0x7F3BD20", VA = "0x187F3D720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IDEJIEBBEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F3DA30", Offset = "0x7F3C030", VA = "0x187F3DA30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DDPKAILPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D770", Offset = "0x7F3BD70", VA = "0x187F3D770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KMODMBGLDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D8D0", Offset = "0x7F3BED0", VA = "0x187F3D8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
	public LNGKIIMFKIB(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D320", Offset = "0x7F3B920", VA = "0x187F3D320", Slot = "5")]
	public bool Equals(LNGKIIMFKIB HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D3A0", Offset = "0x7F3B9A0", VA = "0x187F3D3A0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F3DD00", Offset = "0x7F3C300", VA = "0x187F3DD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x54289F0", Offset = "0x5426FF0", VA = "0x1854289F0", Slot = "4")]
	public int CompareTo(LNGKIIMFKIB HOPHFOOKMCC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct KOOPKPEKKLC<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly int KHMHPNKMLMD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private LNGKIIMFKIB JKNCOIAHBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		get
		{
			return default(LNGKIIMFKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
	internal KOOPKPEKKLC(int KHMHPNKMLMD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x202D230", Offset = "0x202B830", VA = "0x18202D230")]
	public static LNGKIIMFKIB EIMKEBEILPD(KOOPKPEKKLC<T> PJAMOIBNMIO)
	{
		return default(LNGKIIMFKIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x52E79D0", Offset = "0x52E5FD0", VA = "0x1852E79D0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x52E86A0", Offset = "0x52E6CA0", VA = "0x1852E86A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F32AF0", Offset = "0x7F310F0", VA = "0x187F32AF0")]
		public static (long, string, string)[] LPNGBCGABLJ(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : FNAJDFOCBLD, PCIBMHNCDLM
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
			[Cpp2IlInjected.Address(RVA = "0x7F3CA20", Offset = "0x7F3B020", VA = "0x187F3CA20", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7F3CAE0", Offset = "0x7F3B0E0", VA = "0x187F3CAE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7F3CB90", Offset = "0x7F3B190", VA = "0x187F3CB90")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Dictionary<Type, ANOMGGKBALC> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<Type, ANOMGGKBALC> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3CFF0", Offset = "0x7F3B5F0", VA = "0x187F3CFF0")]
		public static IReadOnlyDictionary<Type, ANOMGGKBALC> GJKOAMOJDKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3CF30", Offset = "0x7F3B530", VA = "0x187F3CF30")]
		private Dictionary<Type, ANOMGGKBALC> CCHHFLKMKEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3CBE0", Offset = "0x7F3B1E0", VA = "0x187F3CBE0")]
		private void AOKFPCKFPNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D040", Offset = "0x7F3B640", VA = "0x187F3D040")]
		private readonly void HLHLHHPKFJM(Type interfaceType, ANOMGGKBALC implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x7F3FFE0", Offset = "0x7F3E5E0", VA = "0x187F3FFE0")]
		public static Type[] FBGNOBDGHGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E130", Offset = "0x7F3C730", VA = "0x187F3E130")]
		private static void CCHHFLKMKEK()
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
	public class SandboxDeformableShapeDefaults : ACCAEBNDJIN, FNAJDFOCBLD, PCIBMHNCDLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x11729C0", Offset = "0x1170FC0", VA = "0x1811729C0", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x17A3430", Offset = "0x17A1A30", VA = "0x1817A3430", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7F50250", Offset = "0x7F4E850", VA = "0x187F50250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F502B0", Offset = "0x7F4E8B0", VA = "0x187F502B0", Slot = "4")]
		public void OGANFLEFEJB(PCIBMHNCDLM networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
	public class R2SandboxDeformableShapeNetworkData : EPNCOJPCADA, PCIBMHNCDLM, FNAJDFOCBLD, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private CMPLKMGCEMC service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7F4FF10", Offset = "0x7F4E510", VA = "0x187F4FF10", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7F50170", Offset = "0x7F4E770", VA = "0x187F50170", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F50100", Offset = "0x7F4E700", VA = "0x187F50100", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7F4FDC0", Offset = "0x7F4E3C0", VA = "0x187F4FDC0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7F50040", Offset = "0x7F4E640", VA = "0x187F50040", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7F4FF80", Offset = "0x7F4E580", VA = "0x187F4FF80", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7F4FEA0", Offset = "0x7F4E4A0", VA = "0x187F4FEA0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7F4FE30", Offset = "0x7F4E430", VA = "0x187F4FE30", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4CCA780", Offset = "0x4CC8D80", VA = "0x184CCA780")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, CMPLKMGCEMC networkDataService)
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
		public static readonly KOOPKPEKKLC<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly KOOPKPEKKLC<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly KOOPKPEKKLC<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[IsBuffer]
		[R2Only]
		public static readonly KOOPKPEKKLC<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[R2Only]
		public static readonly KOOPKPEKKLC<OBIGOCAPOLO> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		[IsBuffer]
		public static readonly KOOPKPEKKLC<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		public static readonly KOOPKPEKKLC<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[IsBuffer]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		public static readonly KOOPKPEKKLC<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly KOOPKPEKKLC<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly KOOPKPEKKLC<BCONCEGBJCH> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly KOOPKPEKKLC<DGAEBPJIIOK> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly KOOPKPEKKLC<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly KOOPKPEKKLC<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly KOOPKPEKKLC<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly KOOPKPEKKLC<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly KOOPKPEKKLC<MAOBCDIHBBF> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		[IsBuffer]
		public static readonly KOOPKPEKKLC<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly KOOPKPEKKLC<KPMGCCKEPKI> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly KOOPKPEKKLC<NKGGCFMEFLF> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly KOOPKPEKKLC<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly KOOPKPEKKLC<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly KOOPKPEKKLC<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly KOOPKPEKKLC<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly KOOPKPEKKLC<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly KOOPKPEKKLC<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly KOOPKPEKKLC<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly KOOPKPEKKLC<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly KOOPKPEKKLC<FKDFLMOGDKH> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly KOOPKPEKKLC<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly KOOPKPEKKLC<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly KOOPKPEKKLC<PMDGEEGMAGC> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly KOOPKPEKKLC<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly KOOPKPEKKLC<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(LFAJIKLPOPO))]
		public static readonly KOOPKPEKKLC<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly KOOPKPEKKLC<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly KOOPKPEKKLC<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly KOOPKPEKKLC<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly KOOPKPEKKLC<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly KOOPKPEKKLC<OBIGOCAPOLO> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly KOOPKPEKKLC<OIMGLIMIDDE> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly KOOPKPEKKLC<NDMOGPNBENB> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly KOOPKPEKKLC<JHCNKNHMPMK> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly KOOPKPEKKLC<DGAEBPJIIOK> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly KOOPKPEKKLC<FJDEBDGOFDG> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly KOOPKPEKKLC<AIANJGLPPCP> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		[IsBuffer]
		public static readonly KOOPKPEKKLC<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly KOOPKPEKKLC<HNLOHAHCDNN> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly KOOPKPEKKLC<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LAGOBMAIPOF> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly KOOPKPEKKLC<OFKMGJGNECN> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[IsBuffer]
		[R2Only]
		public static readonly KOOPKPEKKLC<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly KOOPKPEKKLC<HMMDHBIHKAK> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly KOOPKPEKKLC<KPMCCJPJMLK> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly KOOPKPEKKLC<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly KOOPKPEKKLC<CJJLOHBFDJM> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly KOOPKPEKKLC<AMAMMBOPIJC> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[R2Only]
		public static readonly KOOPKPEKKLC<EAFLHKJFOAH> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[R2Only]
		public static readonly KOOPKPEKKLC<NILDFBEGFPP> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[R2Only]
		public static readonly KOOPKPEKKLC<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[R2Only]
		public static readonly KOOPKPEKKLC<JGNPJEKDJKO> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F40A20", Offset = "0x7F3F020", VA = "0x187F40A20")]
		public static bool FPMLIAJFMIG(LNGKIIMFKIB property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RegisterService(typeof(OFJALIANHEN), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : OFJALIANHEN, CEGGANPCFLD, JFAKIPDGBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xDED9A0", Offset = "0xDEBFA0", VA = "0x180DED9A0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xE8D3B0", Offset = "0xE8B9B0", VA = "0x180E8D3B0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xFAE7A0", Offset = "0xFACDA0", VA = "0x180FAE7A0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xF4D010", Offset = "0xF4B610", VA = "0x180F4D010", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA50C70", Offset = "0xA4F270", VA = "0x180A50C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4E0", Offset = "0xA4AAE0", VA = "0x180A4C4E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4C0", Offset = "0xA4AAC0", VA = "0x180A4C4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public JFKLMPPHNJN[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, IAGCDDDBJLC> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA4C410", Offset = "0xA4AA10", VA = "0x180A4C410", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA4C320", Offset = "0xA4A920", VA = "0x180A4C320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x305F1E0", Offset = "0x305D7E0", VA = "0x18305F1E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F40AE0", Offset = "0x7F3F0E0", VA = "0x187F40AE0", Slot = "14")]
		public void BHAOPDEOLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F40AF0", Offset = "0x7F3F0F0", VA = "0x187F40AF0", Slot = "15")]
		public void KALGJOBBDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F40B80", Offset = "0x7F3F180", VA = "0x187F40B80")]
		private void KOAOEMPJNJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C2F0", Offset = "0x7F4A8F0", VA = "0x187F4C2F0")]
		public static void HGLLFKPPJMJ(KPHDCMCEMCG writer, LNGKIIMFKIB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C9F0", Offset = "0x7F4AFF0", VA = "0x187F4C9F0")]
		public static void LKOMFGHLJMK(BJCMFNCJPOJ reader, LNGKIIMFKIB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E2E0", Offset = "0x7F4C8E0", VA = "0x187F4E2E0")]
		private static void PDKFADDGNGF(KPHDCMCEMCG writer, LNGKIIMFKIB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CA10", Offset = "0x7F4B010", VA = "0x187F4CA10")]
		private static void PBGGJHKJPLH(BJCMFNCJPOJ reader, LNGKIIMFKIB property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3CE43C0", Offset = "0x3CE29C0", VA = "0x183CE43C0")]
		internal static void LGGJGPOGIBH<T>(KPHDCMCEMCG writer, KOOPKPEKKLC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4070", Offset = "0x3CE2670", VA = "0x183CE4070")]
		internal static void FJJOMODMCLM<T>(BJCMFNCJPOJ reader, KOOPKPEKKLC<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3CE46B0", Offset = "0x3CE2CB0", VA = "0x183CE46B0")]
		internal static void LGGJGPOGIBH<T>(KPHDCMCEMCG writer, KOOPKPEKKLC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3CE42F0", Offset = "0x3CE28F0", VA = "0x183CE42F0")]
		internal static void FJJOMODMCLM<T>(BJCMFNCJPOJ reader, KOOPKPEKKLC<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3CE44D0", Offset = "0x3CE2AD0", VA = "0x183CE44D0")]
		internal static void LGGJGPOGIBH<T>(KPHDCMCEMCG writer, KOOPKPEKKLC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4150", Offset = "0x3CE2750", VA = "0x183CE4150")]
		internal static void FJJOMODMCLM<T>(BJCMFNCJPOJ reader, KOOPKPEKKLC<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C5A0", Offset = "0x7F4ABA0", VA = "0x187F4C5A0")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C020", Offset = "0x7F4A620", VA = "0x187F4C020")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C370", Offset = "0x7F4A970", VA = "0x187F4C370")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BD70", Offset = "0x7F4A370", VA = "0x187F4BD70")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C470", Offset = "0x7F4AA70", VA = "0x187F4C470")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BC60", Offset = "0x7F4A260", VA = "0x187F4BC60")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C310", Offset = "0x7F4A910", VA = "0x187F4C310")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BFC0", Offset = "0x7F4A5C0", VA = "0x187F4BFC0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C540", Offset = "0x7F4AB40", VA = "0x187F4C540")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BE50", Offset = "0x7F4A450", VA = "0x187F4BE50")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C410", Offset = "0x7F4AA10", VA = "0x187F4C410")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BEB0", Offset = "0x7F4A4B0", VA = "0x187F4BEB0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C980", Offset = "0x7F4AF80", VA = "0x187F4C980")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BCC0", Offset = "0x7F4A2C0", VA = "0x187F4BCC0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C790", Offset = "0x7F4AD90", VA = "0x187F4C790")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C0D0", Offset = "0x7F4A6D0", VA = "0x187F4C0D0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C910", Offset = "0x7F4AF10", VA = "0x187F4C910")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C180", Offset = "0x7F4A780", VA = "0x187F4C180")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C4D0", Offset = "0x7F4AAD0", VA = "0x187F4C4D0")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BF10", Offset = "0x7F4A510", VA = "0x187F4BF10")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4590", Offset = "0x3CE2B90", VA = "0x183CE4590")]
		internal static void LGGJGPOGIBH<T>(KPHDCMCEMCG writer, KOOPKPEKKLC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4220", Offset = "0x3CE2820", VA = "0x183CE4220")]
		internal static void FJJOMODMCLM<T>(BJCMFNCJPOJ reader, KOOPKPEKKLC<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C800", Offset = "0x7F4AE00", VA = "0x187F4C800")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BBA0", Offset = "0x7F4A1A0", VA = "0x187F4BBA0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C680", Offset = "0x7F4AC80", VA = "0x187F4C680")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C230", Offset = "0x7F4A830", VA = "0x187F4C230")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C610", Offset = "0x7F4AC10", VA = "0x187F4C610")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<DGAEBPJIIOK> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BDE0", Offset = "0x7F4A3E0", VA = "0x187F4BDE0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<DGAEBPJIIOK> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F32A10", Offset = "0x7F31010", VA = "0x187F32A10")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, KOOPKPEKKLC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F325C0", Offset = "0x7F30BC0", VA = "0x187F325C0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, KOOPKPEKKLC<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F32A10", Offset = "0x7F31010", VA = "0x187F32A10")]
		internal static void LGGJGPOGIBH(KPHDCMCEMCG writer, LNGKIIMFKIB prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F325C0", Offset = "0x7F30BC0", VA = "0x187F325C0")]
		internal static void FJJOMODMCLM(BJCMFNCJPOJ reader, LNGKIIMFKIB prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4770", Offset = "0x3CE2D70", VA = "0x183CE4770")]
		internal static T MMMKFEGMMDL<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F503F0", Offset = "0x7F4E9F0", VA = "0x187F503F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F50650", Offset = "0x7F4EC50", VA = "0x187F50650")]
		public void CCHHFLKMKEK(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F50660", Offset = "0x7F4EC60", VA = "0x187F50660")]
		private void HIOALCIGOOG(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4225000", Offset = "0x4223600", VA = "0x184225000")]
		private void CKCHCLCACHP<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x422F010", Offset = "0x422D610", VA = "0x18422F010")]
		private void IBMPDDHGMHB<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x422E8F0", Offset = "0x422CEF0", VA = "0x18422E8F0")]
		private void HALLKEKLIAE<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			UpgradeFixDisassociatedAnimationData = 164
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F527F0", Offset = "0x7F50DF0", VA = "0x187F527F0")]
		public static bool LJCLCIMBHMN(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum IIHNECOCMHE
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterService(typeof(HIJLDBFHGCI), new string[] { "Registry" })]
internal class PNLKBGACOJF : HIJLDBFHGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type FHAMCGLEPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F52590", Offset = "0x7F50B90", VA = "0x187F52590", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] NKHIPKGJDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F52610", Offset = "0x7F50C10", VA = "0x187F52610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, ANOMGGKBALC> HGKEFOIGFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7F52580", Offset = "0x7F50B80", VA = "0x187F52580", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F525F0", Offset = "0x7F50BF0", VA = "0x187F525F0", Slot = "7")]
	public void GEMHMDHIAMB(IComponentDefaultRegistration BAAMNNIGHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public PNLKBGACOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class DDMKIMBJDCN : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NLNMDCPMOAB : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7F52550", Offset = "0x7F50B50", VA = "0x187F52550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F52460", Offset = "0x7F50A60", VA = "0x187F52460")]
		public NLNMDCPMOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x236E430", Offset = "0x236CA30", VA = "0x18236E430", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 FAIEEFHMPLL)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F52450", Offset = "0x7F50A50", VA = "0x187F52450", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 FAIEEFHMPLL, ObjectPrefabType_v1 KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F522D0", Offset = "0x7F508D0", VA = "0x187F522D0")]
	public DDMKIMBJDCN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F52620", Offset = "0x7F50C20", VA = "0x187F52620")]
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
