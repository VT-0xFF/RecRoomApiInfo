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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77BA8B0", Offset = "0x77B9CB0", VA = "0x1877BA8B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x782E800", Offset = "0x782DC00", VA = "0x18782E800")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x782E690", Offset = "0x782DA90", VA = "0x18782E690")]
		private void AGDLJELKAMH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x782E970", Offset = "0x782DD70", VA = "0x18782E970", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x782ECB0", Offset = "0x782E0B0", VA = "0x18782ECB0")]
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
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct SerializedDataLayerVersionData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct RRObjectPrefabData_v1 : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPrefabType_v1 prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
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
public readonly struct JKPLFEIEHFJ : IComparable<JKPLFEIEHFJ>, IEquatable<JKPLFEIEHFJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly JKPLFEIEHFJ EFMDICAFKHF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JKPLFEIEHFJ FFNFILFHHLJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly JKPLFEIEHFJ JIENCIKICIJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly JKPLFEIEHFJ APHJDGKFBJP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly JKPLFEIEHFJ MCLOFBDEJOF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly JKPLFEIEHFJ BHOPDAMMCBB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int CJFNAFNJJLB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type APANIJNAHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x781D440", Offset = "0x781C840", VA = "0x18781D440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MPKJDDCJPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x781D170", Offset = "0x781C570", VA = "0x18781D170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BFPJLGPCCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x781D8A0", Offset = "0x781CCA0", VA = "0x18781D8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type BGBOENFEOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x781D7C0", Offset = "0x781CBC0", VA = "0x18781D7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BIKAPGGNAGJ LACCILDBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x781D2B0", Offset = "0x781C6B0", VA = "0x18781D2B0")]
		get
		{
			return default(BIKAPGGNAGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KPBHNKNPOKE BEMFMKNIIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x781D520", Offset = "0x781C920", VA = "0x18781D520")]
		get
		{
			return default(KPBHNKNPOKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KEONGIGELJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x781D720", Offset = "0x781CB20", VA = "0x18781D720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FPENINAMDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x781D770", Offset = "0x781CB70", VA = "0x18781D770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HAKECAILCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x781D010", Offset = "0x781C410", VA = "0x18781D010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FAFPNCKCAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x781CEB0", Offset = "0x781C2B0", VA = "0x18781CEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
	public JKPLFEIEHFJ(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x781CE30", Offset = "0x781C230", VA = "0x18781CE30", Slot = "5")]
	public bool Equals(JKPLFEIEHFJ KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x781CD90", Offset = "0x781C190", VA = "0x18781CD90", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x781D9E0", Offset = "0x781CDE0", VA = "0x18781D9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x49F0BB0", Offset = "0x49EFFB0", VA = "0x1849F0BB0", Slot = "4")]
	public int CompareTo(JKPLFEIEHFJ KNCKFHOKGJM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HOKJDAMJNEH<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly int CJFNAFNJJLB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JKPLFEIEHFJ HNLLPNEJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
		get
		{
			return default(JKPLFEIEHFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
	internal HOKJDAMJNEH(int CJFNAFNJJLB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D345A0", Offset = "0x1D339A0", VA = "0x181D345A0")]
	public static JKPLFEIEHFJ CLMIANKGGAM(HOKJDAMJNEH<T> MHALMOGKEGG)
	{
		return default(JKPLFEIEHFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4915220", Offset = "0x4914620", VA = "0x184915220", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4915EF0", Offset = "0x49152F0", VA = "0x184915EF0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7811830", Offset = "0x7810C30", VA = "0x187811830")]
		public static (long, string, string) CMDHJGBAMCL(CGLGBAJFIGE value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7812FE0", Offset = "0x78123E0", VA = "0x187812FE0")]
		public static (long, string, string)[] HDLGMBDLGGH(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x781DD80", Offset = "0x781D180", VA = "0x18781DD80")]
		public static Type[] ENAPIJHPBOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x781DDE0", Offset = "0x781D1E0", VA = "0x18781DDE0")]
		private static void GEAMIGHEOPG()
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
		public static readonly HOKJDAMJNEH<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly HOKJDAMJNEH<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly HOKJDAMJNEH<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly HOKJDAMJNEH<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly HOKJDAMJNEH<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly HOKJDAMJNEH<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly HOKJDAMJNEH<MHBPIDFNAAN> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static readonly HOKJDAMJNEH<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static readonly HOKJDAMJNEH<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static readonly HOKJDAMJNEH<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly HOKJDAMJNEH<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly HOKJDAMJNEH<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly HOKJDAMJNEH<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly HOKJDAMJNEH<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly HOKJDAMJNEH<HFPJMNAOGAF> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static readonly HOKJDAMJNEH<CPJAFFJHONJ> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly HOKJDAMJNEH<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static readonly HOKJDAMJNEH<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly HOKJDAMJNEH<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static readonly HOKJDAMJNEH<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static readonly HOKJDAMJNEH<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly HOKJDAMJNEH<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly HOKJDAMJNEH<PMMDFGLDHNM> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly HOKJDAMJNEH<byte> ContainerNameBuffer_data;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static readonly HOKJDAMJNEH<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly HOKJDAMJNEH<ODMPMFHJCBJ> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly HOKJDAMJNEH<OGALGCNMGJH> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly HOKJDAMJNEH<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly HOKJDAMJNEH<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static readonly HOKJDAMJNEH<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static readonly HOKJDAMJNEH<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly HOKJDAMJNEH<LocalId> EntityPrefabPartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly HOKJDAMJNEH<uint> EntityPrefabPartData_partId;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly HOKJDAMJNEH<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly HOKJDAMJNEH<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static readonly HOKJDAMJNEH<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly HOKJDAMJNEH<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly HOKJDAMJNEH<OAIMBNMHJKM> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly HOKJDAMJNEH<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly HOKJDAMJNEH<bool> ContainerIsRecolorableData_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly HOKJDAMJNEH<AEPLEEMHJAE> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly HOKJDAMJNEH<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly HOKJDAMJNEH<uint> AuthoredAIIdData_Value;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly HOKJDAMJNEH<int> ReplicatorMaxObjectCountData_count;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly HOKJDAMJNEH<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly HOKJDAMJNEH<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly HOKJDAMJNEH<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly HOKJDAMJNEH<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly HOKJDAMJNEH<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly HOKJDAMJNEH<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly HOKJDAMJNEH<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly HOKJDAMJNEH<IMDMMENCIGE> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly HOKJDAMJNEH<GKPHPKBFEMO> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly HOKJDAMJNEH<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly HOKJDAMJNEH<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly HOKJDAMJNEH<PJJDLHIAMPI> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly HOKJDAMJNEH<CPJAFFJHONJ> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly HOKJDAMJNEH<AMAHBNLCGNL> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly HOKJDAMJNEH<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly HOKJDAMJNEH<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly HOKJDAMJNEH<OFDKKEMCEOC> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly HOKJDAMJNEH<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly HOKJDAMJNEH<BPAFOCGKPKM> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly HOKJDAMJNEH<KNDGIBFMLDC> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly HOKJDAMJNEH<FECKIEFHJNO> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly HOKJDAMJNEH<MEOCNMKGIFD> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly HOKJDAMJNEH<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly HOKJDAMJNEH<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly HOKJDAMJNEH<KIFMKPPKEAC> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly HOKJDAMJNEH<KNMEEIJOCBO> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly HOKJDAMJNEH<NLBLFFJPFIA> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly HOKJDAMJNEH<HBMNMKJALBD> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly HOKJDAMJNEH<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly HOKJDAMJNEH<KKDMKJIEJIF> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RegisterService(typeof(LIKIDIPBAGD), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : LIKIDIPBAGD, EMCOCKJPFLA, PIEEAAJKAEB
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
			[Cpp2IlInjected.Address(RVA = "0xB9CB20", Offset = "0xB9BF20", VA = "0x180B9CB20", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC71960", Offset = "0xC70D60", VA = "0x180C71960", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD2B410", Offset = "0xD2A810", VA = "0x180D2B410", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE0D840", Offset = "0xE0CC40", VA = "0x180E0D840", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x993A70", Offset = "0x992E70", VA = "0x180993A70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x993AD0", Offset = "0x992ED0", VA = "0x180993AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x993A80", Offset = "0x992E80", VA = "0x180993A80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x993A90", Offset = "0x992E90", VA = "0x180993A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public BIKAPGGNAGJ[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x993A50", Offset = "0x992E50", VA = "0x180993A50", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x993AA0", Offset = "0x992EA0", VA = "0x180993AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, KPBHNKNPOKE> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x993AB0", Offset = "0x992EB0", VA = "0x180993AB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x993A60", Offset = "0x992E60", VA = "0x180993A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7820120", Offset = "0x781F520", VA = "0x187820120", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7820140", Offset = "0x781F540", VA = "0x187820140", Slot = "13")]
		public void IJPFELNFEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7829A00", Offset = "0x7828E00", VA = "0x187829A00", Slot = "14")]
		public void NLAAFKHBPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7820150", Offset = "0x781F550", VA = "0x187820150")]
		private void MIFPAGMGMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x782CE60", Offset = "0x782C260", VA = "0x18782CE60")]
		public static void PEDJMLDFBGC(EELBJIEGGMG writer, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x782CE40", Offset = "0x782C240", VA = "0x18782CE40")]
		public static void PBNFIIOEMAM(HOIFPHKOLPI reader, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x782A150", Offset = "0x7829550", VA = "0x18782A150")]
		private static void IHPFFEIOEEH(EELBJIEGGMG writer, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x782B8F0", Offset = "0x782ACF0", VA = "0x18782B8F0")]
		private static void KJMMDNCMNDK(HOIFPHKOLPI reader, JKPLFEIEHFJ property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x37EDD70", Offset = "0x37ED170", VA = "0x1837EDD70")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37ED940", Offset = "0x37ECD40", VA = "0x1837ED940")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37EE0C0", Offset = "0x37ED4C0", VA = "0x1837EE0C0")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x37EDC00", Offset = "0x37ED000", VA = "0x1837EDC00")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x37EDE90", Offset = "0x37ED290", VA = "0x1837EDE90")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x37EDA30", Offset = "0x37ECE30", VA = "0x1837EDA30")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x782D310", Offset = "0x782C710", VA = "0x18782D310")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7829DC0", Offset = "0x78291C0", VA = "0x187829DC0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x782D190", Offset = "0x782C590", VA = "0x18782D190")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7829D50", Offset = "0x7829150", VA = "0x187829D50")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x782CE80", Offset = "0x782C280", VA = "0x18782CE80")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7829A60", Offset = "0x7828E60", VA = "0x187829A60")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x782CEE0", Offset = "0x782C2E0", VA = "0x18782CEE0")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7829F30", Offset = "0x7829330", VA = "0x187829F30")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x782CF40", Offset = "0x782C340", VA = "0x18782CF40")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x782A0F0", Offset = "0x78294F0", VA = "0x18782A0F0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x782D230", Offset = "0x782C630", VA = "0x18782D230")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7829F90", Offset = "0x7829390", VA = "0x187829F90")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x782D490", Offset = "0x782C890", VA = "0x18782D490")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7829C30", Offset = "0x7829030", VA = "0x187829C30")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x782CFA0", Offset = "0x782C3A0", VA = "0x18782CFA0")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7829AC0", Offset = "0x7828EC0", VA = "0x187829AC0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x782D120", Offset = "0x782C520", VA = "0x18782D120")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x782A040", Offset = "0x7829440", VA = "0x18782A040")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37EDF70", Offset = "0x37ED370", VA = "0x1837EDF70")]
		internal static void PELCBGJOJPC<T>(EELBJIEGGMG writer, HOKJDAMJNEH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x37EDB10", Offset = "0x37ECF10", VA = "0x1837EDB10")]
		internal static void HFAEDKNMEEN<T>(HOIFPHKOLPI reader, HOKJDAMJNEH<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x782D380", Offset = "0x782C780", VA = "0x18782D380")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7829B70", Offset = "0x7828F70", VA = "0x187829B70")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x782D010", Offset = "0x782C410", VA = "0x18782D010")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7829E70", Offset = "0x7829270", VA = "0x187829E70")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x782D2A0", Offset = "0x782C6A0", VA = "0x18782D2A0")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<CPJAFFJHONJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7829CE0", Offset = "0x78290E0", VA = "0x187829CE0")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<CPJAFFJHONJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7811750", Offset = "0x7810B50", VA = "0x187811750")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, HOKJDAMJNEH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7811570", Offset = "0x7810970", VA = "0x187811570")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, HOKJDAMJNEH<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7811750", Offset = "0x7810B50", VA = "0x187811750")]
		internal static void PELCBGJOJPC(EELBJIEGGMG writer, JKPLFEIEHFJ prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7811570", Offset = "0x7810970", VA = "0x187811570")]
		internal static void HFAEDKNMEEN(HOIFPHKOLPI reader, JKPLFEIEHFJ prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x37EDCF0", Offset = "0x37ED0F0", VA = "0x1837EDCF0")]
		internal static T LOPLIPAOEAM<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x782D500", Offset = "0x782C900", VA = "0x18782D500")]
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
		[Cpp2IlInjected.Address(RVA = "0x782E680", Offset = "0x782DA80", VA = "0x18782E680")]
		public void GEAMIGHEOPG(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x782D530", Offset = "0x782C930", VA = "0x18782D530")]
		private void APIMFHCAMCF(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFCC0", Offset = "0x3CEF0C0", VA = "0x183CEFCC0")]
		private void GFBMDDOGDNI<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
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
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			UpgradeStudioObjectPhysicsData = 145
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x782F3F0", Offset = "0x782E7F0", VA = "0x18782F3F0")]
		public static bool GDBHAFLLPNK(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum GEJMMOGBMKA
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterService(typeof(KKHPIIHNPCD), new string[] { "Registry" })]
internal class NLGEOJFLHNC : KKHPIIHNPCD
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type EPOOAKGJPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x782F1C0", Offset = "0x782E5C0", VA = "0x18782F1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] ONMJECIJDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x782F190", Offset = "0x782E590", VA = "0x18782F190", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x782F1A0", Offset = "0x782E5A0", VA = "0x18782F1A0", Slot = "6")]
	public void EMECOFBLPNE(IComponentDefaultRegistration FBLFJIPLCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public NLGEOJFLHNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class NBEKMICOGPL : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class CJCOIPDKKBE : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x782EFE0", Offset = "0x782E3E0", VA = "0x18782EFE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x782EEF0", Offset = "0x782E2F0", VA = "0x18782EEF0")]
		public CJCOIPDKKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2049D90", Offset = "0x2049190", VA = "0x182049D90", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 NKMJDOBLHGP)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x782EEE0", Offset = "0x782E2E0", VA = "0x18782EEE0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 NKMJDOBLHGP, ObjectPrefabType_v1 FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x782F010", Offset = "0x782E410", VA = "0x18782F010")]
	public NBEKMICOGPL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x782F220", Offset = "0x782E620", VA = "0x18782F220")]
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
