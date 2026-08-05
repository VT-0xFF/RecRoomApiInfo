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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78693A0", Offset = "0x78687A0", VA = "0x1878693A0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7806FA0", Offset = "0x78063A0", VA = "0x187806FA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x787B600", Offset = "0x787AA00", VA = "0x18787B600")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x787B490", Offset = "0x787A890", VA = "0x18787B490")]
		private void AGDLJELKAMH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x787B770", Offset = "0x787AB70", VA = "0x18787B770", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x787BAB0", Offset = "0x787AEB0", VA = "0x18787BAB0")]
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
public readonly struct JKPLFEIEHFJ : IComparable<JKPLFEIEHFJ>, IEquatable<JKPLFEIEHFJ>
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JKPLFEIEHFJ EFMDICAFKHF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly JKPLFEIEHFJ FFNFILFHHLJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly JKPLFEIEHFJ JIENCIKICIJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly JKPLFEIEHFJ APHJDGKFBJP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly JKPLFEIEHFJ MCLOFBDEJOF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly JKPLFEIEHFJ BHOPDAMMCBB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly int CJFNAFNJJLB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type APANIJNAHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7868A70", Offset = "0x7867E70", VA = "0x187868A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MPKJDDCJPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78687B0", Offset = "0x7867BB0", VA = "0x1878687B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BFPJLGPCCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7868ED0", Offset = "0x78682D0", VA = "0x187868ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type BGBOENFEOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7868DF0", Offset = "0x78681F0", VA = "0x187868DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BIKAPGGNAGJ LACCILDBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78688F0", Offset = "0x7867CF0", VA = "0x1878688F0")]
		get
		{
			return default(BIKAPGGNAGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KPBHNKNPOKE BEMFMKNIIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7868B50", Offset = "0x7867F50", VA = "0x187868B50")]
		get
		{
			return default(KPBHNKNPOKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KEONGIGELJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7868D50", Offset = "0x7868150", VA = "0x187868D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FPENINAMDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7868DA0", Offset = "0x78681A0", VA = "0x187868DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HAKECAILCHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7868660", Offset = "0x7867A60", VA = "0x187868660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FAFPNCKCAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7868510", Offset = "0x7867910", VA = "0x187868510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
	public JKPLFEIEHFJ(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7868490", Offset = "0x7867890", VA = "0x187868490", Slot = "5")]
	public bool Equals(JKPLFEIEHFJ KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x78683F0", Offset = "0x78677F0", VA = "0x1878683F0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7869010", Offset = "0x7868410", VA = "0x187869010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A1B6F0", Offset = "0x4A1AAF0", VA = "0x184A1B6F0", Slot = "4")]
	public int CompareTo(JKPLFEIEHFJ KNCKFHOKGJM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct HOKJDAMJNEH<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int CJFNAFNJJLB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JKPLFEIEHFJ HNLLPNEJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640")]
		get
		{
			return default(JKPLFEIEHFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
	internal HOKJDAMJNEH(int CJFNAFNJJLB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D45E10", Offset = "0x1D45210", VA = "0x181D45E10")]
	public static JKPLFEIEHFJ CLMIANKGGAM(HOKJDAMJNEH<T> MHALMOGKEGG)
	{
		return default(JKPLFEIEHFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x492D6F0", Offset = "0x492CAF0", VA = "0x18492D6F0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x492E1F0", Offset = "0x492D5F0", VA = "0x18492E1F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x785C8B0", Offset = "0x785BCB0", VA = "0x18785C8B0")]
		public static (long, string, string) CMDHJGBAMCL(CGLGBAJFIGE value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x785DFC0", Offset = "0x785D3C0", VA = "0x18785DFC0")]
		public static (long, string, string)[] HDLGMBDLGGH(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : KMMHOLECIFM, CBFDFOKOJOK
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
			[Cpp2IlInjected.Address(RVA = "0x7867E10", Offset = "0x7867210", VA = "0x187867E10", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7867D60", Offset = "0x7867160", VA = "0x187867D60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7867ED0", Offset = "0x78672D0", VA = "0x187867ED0")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Dictionary<Type, IHADJCLMGFL> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Dictionary<Type, IHADJCLMGFL> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7867FA0", Offset = "0x78673A0", VA = "0x187867FA0")]
		public static IReadOnlyDictionary<Type, IHADJCLMGFL> BDPKCCEFJJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7867FF0", Offset = "0x78673F0", VA = "0x187867FF0")]
		private Dictionary<Type, IHADJCLMGFL> GEAMIGHEOPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78680B0", Offset = "0x78674B0", VA = "0x1878680B0")]
		private void OEPNFOJKDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7867F20", Offset = "0x7867320", VA = "0x187867F20")]
		private readonly void ANLOBCNJKKM(Type interfaceType, IHADJCLMGFL implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x7869430", Offset = "0x7868830", VA = "0x187869430")]
		public static Type[] ENAPIJHPBOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7869480", Offset = "0x7868880", VA = "0x187869480")]
		private static void GEAMIGHEOPG()
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
	public class SandboxDeformableShapeDefaults : IJDNKFHGFBI, KMMHOLECIFM, CBFDFOKOJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x14D2620", Offset = "0x14D1A20", VA = "0x1814D2620", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x14D25E0", Offset = "0x14D19E0", VA = "0x1814D25E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7879FC0", Offset = "0x78793C0", VA = "0x187879FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7879E80", Offset = "0x7879280", VA = "0x187879E80", Slot = "4")]
		public void DHDJJANPOHF(CBFDFOKOJOK networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	public class R2SandboxDeformableShapeNetworkData : KMMHOLECIFM, CBFDFOKOJOK, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private AFMOLCDJHBN service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7879C70", Offset = "0x7879070", VA = "0x187879C70", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x78799F0", Offset = "0x7878DF0", VA = "0x1878799F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7879C00", Offset = "0x7879000", VA = "0x187879C00", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7879B90", Offset = "0x7878F90", VA = "0x187879B90", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7879A60", Offset = "0x7878E60", VA = "0x187879A60", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7879CE0", Offset = "0x78790E0", VA = "0x187879CE0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7879DA0", Offset = "0x78791A0", VA = "0x187879DA0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7879B20", Offset = "0x7878F20", VA = "0x187879B20", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4721D00", Offset = "0x4721100", VA = "0x184721D00")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, AFMOLCDJHBN networkDataService)
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
		public static readonly HOKJDAMJNEH<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[R2Only]
		public static readonly HOKJDAMJNEH<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[R2Only]
		public static readonly HOKJDAMJNEH<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[R2Only]
		[IsBuffer]
		public static readonly HOKJDAMJNEH<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly HOKJDAMJNEH<MHBPIDFNAAN> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		[IsBuffer]
		public static readonly HOKJDAMJNEH<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly HOKJDAMJNEH<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[IsBuffer]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[R2Only]
		public static readonly HOKJDAMJNEH<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		public static readonly HOKJDAMJNEH<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		public static readonly HOKJDAMJNEH<HFPJMNAOGAF> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly HOKJDAMJNEH<CPJAFFJHONJ> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly HOKJDAMJNEH<int> CostumePieceSlotIndex_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly HOKJDAMJNEH<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly HOKJDAMJNEH<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly HOKJDAMJNEH<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly HOKJDAMJNEH<PMMDFGLDHNM> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		[IsBuffer]
		public static readonly HOKJDAMJNEH<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly HOKJDAMJNEH<ODMPMFHJCBJ> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		public static readonly HOKJDAMJNEH<OGALGCNMGJH> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly HOKJDAMJNEH<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly HOKJDAMJNEH<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly HOKJDAMJNEH<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly HOKJDAMJNEH<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly HOKJDAMJNEH<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly HOKJDAMJNEH<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly HOKJDAMJNEH<OAIMBNMHJKM> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly HOKJDAMJNEH<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly HOKJDAMJNEH<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly HOKJDAMJNEH<AEPLEEMHJAE> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly HOKJDAMJNEH<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly HOKJDAMJNEH<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(JKGGPGHLCHL))]
		public static readonly HOKJDAMJNEH<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly HOKJDAMJNEH<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly HOKJDAMJNEH<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly HOKJDAMJNEH<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly HOKJDAMJNEH<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly HOKJDAMJNEH<IMDMMENCIGE> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly HOKJDAMJNEH<GKPHPKBFEMO> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly HOKJDAMJNEH<PJJDLHIAMPI> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly HOKJDAMJNEH<CPJAFFJHONJ> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly HOKJDAMJNEH<AMAHBNLCGNL> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> CostumePieceParentCostume_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[IsBuffer]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly HOKJDAMJNEH<OFDKKEMCEOC> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly HOKJDAMJNEH<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly HOKJDAMJNEH<BPAFOCGKPKM> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly HOKJDAMJNEH<KNDGIBFMLDC> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[IsBuffer]
		[R2Only]
		public static readonly HOKJDAMJNEH<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly HOKJDAMJNEH<FECKIEFHJNO> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly HOKJDAMJNEH<MEOCNMKGIFD> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly HOKJDAMJNEH<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly HOKJDAMJNEH<KIFMKPPKEAC> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly HOKJDAMJNEH<KNMEEIJOCBO> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly HOKJDAMJNEH<NLBLFFJPFIA> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly HOKJDAMJNEH<HBMNMKJALBD> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly HOKJDAMJNEH<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly HOKJDAMJNEH<KKDMKJIEJIF> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[RegisterService(typeof(LIKIDIPBAGD), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : LIKIDIPBAGD, EMCOCKJPFLA, PIEEAAJKAEB
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
			[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xC76DA0", Offset = "0xC761A0", VA = "0x180C76DA0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD2FE30", Offset = "0xD2F230", VA = "0x180D2FE30", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xDFC070", Offset = "0xDFB470", VA = "0x180DFC070", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xDAF240", Offset = "0xDAE640", VA = "0x180DAF240", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A30", Offset = "0x9A8E30", VA = "0x1809A9A30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9A9AB0", Offset = "0x9A8EB0", VA = "0x1809A9AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9AE420", Offset = "0x9AD820", VA = "0x1809AE420", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4E0", Offset = "0x9AD8E0", VA = "0x1809AE4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BIKAPGGNAGJ[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4D0", Offset = "0x9AD8D0", VA = "0x1809AE4D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4F0", Offset = "0x9AD8F0", VA = "0x1809AE4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, KPBHNKNPOKE> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AE5B0", Offset = "0x9AD9B0", VA = "0x1809AE5B0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9AE550", Offset = "0x9AD950", VA = "0x1809AE550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2CB2190", Offset = "0x2CB1590", VA = "0x182CB2190", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x786B8F0", Offset = "0x786ACF0", VA = "0x18786B8F0", Slot = "14")]
		public void IJPFELNFEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7875C00", Offset = "0x7875000", VA = "0x187875C00", Slot = "15")]
		public void NLAAFKHBPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x786B900", Offset = "0x786AD00", VA = "0x18786B900")]
		private void MIFPAGMGMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x78792F0", Offset = "0x78786F0", VA = "0x1878792F0")]
		public static void PEDJMLDFBGC(EELBJIEGGMG writer, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x78792D0", Offset = "0x78786D0", VA = "0x1878792D0")]
		public static void PBNFIIOEMAM(HOIFPHKOLPI reader, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x78763E0", Offset = "0x78757E0", VA = "0x1878763E0")]
		private static void IHPFFEIOEEH(EELBJIEGGMG writer, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7877C80", Offset = "0x7877080", VA = "0x187877C80")]
		private static void KJMMDNCMNDK(HOIFPHKOLPI reader, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3801240", Offset = "0x3800640", VA = "0x183801240")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3800F00", Offset = "0x3800300", VA = "0x183800F00")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3801590", Offset = "0x3800990", VA = "0x183801590")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x38010D0", Offset = "0x38004D0", VA = "0x1838010D0")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3801360", Offset = "0x3800760", VA = "0x183801360")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3800FF0", Offset = "0x38003F0", VA = "0x183800FF0")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7879800", Offset = "0x7878C00", VA = "0x187879800")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7875FF0", Offset = "0x78753F0", VA = "0x187875FF0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7879680", Offset = "0x7878A80", VA = "0x187879680")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7875F80", Offset = "0x7875380", VA = "0x187875F80")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7879310", Offset = "0x7878710", VA = "0x187879310")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7875C90", Offset = "0x7875090", VA = "0x187875C90")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7879370", Offset = "0x7878770", VA = "0x187879370")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7876160", Offset = "0x7875560", VA = "0x187876160")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7879430", Offset = "0x7878830", VA = "0x187879430")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7876380", Offset = "0x7875780", VA = "0x187876380")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x78793D0", Offset = "0x78787D0", VA = "0x1878793D0")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7876270", Offset = "0x7875670", VA = "0x187876270")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7879720", Offset = "0x7878B20", VA = "0x187879720")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78761C0", Offset = "0x78755C0", VA = "0x1878761C0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7879980", Offset = "0x7878D80", VA = "0x187879980")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7875E60", Offset = "0x7875260", VA = "0x187875E60")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7879490", Offset = "0x7878890", VA = "0x187879490")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7875CF0", Offset = "0x78750F0", VA = "0x187875CF0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7879610", Offset = "0x7878A10", VA = "0x187879610")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x78762D0", Offset = "0x78756D0", VA = "0x1878762D0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3801440", Offset = "0x3800840", VA = "0x183801440")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3800DA0", Offset = "0x38001A0", VA = "0x183800DA0")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7879870", Offset = "0x7878C70", VA = "0x187879870")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7875DA0", Offset = "0x78751A0", VA = "0x187875DA0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7879500", Offset = "0x7878900", VA = "0x187879500")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x78760A0", Offset = "0x78754A0", VA = "0x1878760A0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7879790", Offset = "0x7878B90", VA = "0x187879790")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<CPJAFFJHONJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7875F10", Offset = "0x7875310", VA = "0x187875F10")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<CPJAFFJHONJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x785C7D0", Offset = "0x785BBD0", VA = "0x18785C7D0")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x785C590", Offset = "0x785B990", VA = "0x18785C590")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x785C7D0", Offset = "0x785BBD0", VA = "0x18785C7D0")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, JKPLFEIEHFJ prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x785C590", Offset = "0x785B990", VA = "0x18785C590")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, JKPLFEIEHFJ prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x38011C0", Offset = "0x38005C0", VA = "0x1838011C0")]
		internal static T LOPLIPAOEAM<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x787A020", Offset = "0x7879420", VA = "0x18787A020")]
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
		[Cpp2IlInjected.Address(RVA = "0x787B480", Offset = "0x787A880", VA = "0x18787B480")]
		public void GEAMIGHEOPG(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x787A270", Offset = "0x7879670", VA = "0x18787A270")]
		private void APIMFHCAMCF(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3D06680", Offset = "0x3D05A80", VA = "0x183D06680")]
		private void GFBMDDOGDNI<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3D152A0", Offset = "0x3D146A0", VA = "0x183D152A0")]
		private void KABOLBDDMBI<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3D15650", Offset = "0x3D14A50", VA = "0x183D15650")]
		private void LEENNBKIGHA<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
		[Cpp2IlInjected.Address(RVA = "0x787C200", Offset = "0x787B600", VA = "0x18787C200")]
		public static bool GDBHAFLLPNK(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum GEJMMOGBMKA
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
[RegisterService(typeof(KKHPIIHNPCD), new string[] { "Registry" })]
internal class NLGEOJFLHNC : KKHPIIHNPCD
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type EPOOAKGJPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x787BFD0", Offset = "0x787B3D0", VA = "0x18787BFD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] ONMJECIJDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x787BFA0", Offset = "0x787B3A0", VA = "0x18787BFA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, IHADJCLMGFL> BDOIDPCBEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x787BF90", Offset = "0x787B390", VA = "0x18787BF90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x787BFB0", Offset = "0x787B3B0", VA = "0x18787BFB0", Slot = "7")]
	public void EMECOFBLPNE(IComponentDefaultRegistration FBLFJIPLCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public NLGEOJFLHNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class NBEKMICOGPL : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class CJCOIPDKKBE : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x787BDE0", Offset = "0x787B1E0", VA = "0x18787BDE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x787BCF0", Offset = "0x787B0F0", VA = "0x18787BCF0")]
		public CJCOIPDKKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2055A00", Offset = "0x2054E00", VA = "0x182055A00", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 NKMJDOBLHGP)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x787BCE0", Offset = "0x787B0E0", VA = "0x18787BCE0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 NKMJDOBLHGP, ObjectPrefabType_v1 FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x787BE10", Offset = "0x787B210", VA = "0x18787BE10")]
	public NBEKMICOGPL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x787C030", Offset = "0x787B430", VA = "0x18787C030")]
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
