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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x804EF10", Offset = "0x804DD10", VA = "0x18804EF10", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22D3BE0", Offset = "0x22D29E0", VA = "0x1822D3BE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8062BE0", Offset = "0x80619E0", VA = "0x188062BE0")]
		private void AFKHLAMEPCM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8062D50", Offset = "0x8061B50", VA = "0x188062D50")]
		private void DBFIEBKHIEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8062EC0", Offset = "0x8061CC0", VA = "0x188062EC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8063200", Offset = "0x8062000", VA = "0x188063200")]
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
public readonly struct IPPNBDGDCLE : IComparable<IPPNBDGDCLE>, IEquatable<IPPNBDGDCLE>
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly IPPNBDGDCLE POJIIGPHFHP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IPPNBDGDCLE PCKHODFHJHP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IPPNBDGDCLE FEAEEDMJAPB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly IPPNBDGDCLE DODGMCDHMNI;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IPPNBDGDCLE JNGEJOLPMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly IPPNBDGDCLE IGGNLJCEIEF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly int CKFKPOAGPKN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GBFKBOHPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type KDKHOOOPAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x804E450", Offset = "0x804D250", VA = "0x18804E450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KJPGBDEIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x804DA40", Offset = "0x804C840", VA = "0x18804DA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FEILDOFOPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x804E2C0", Offset = "0x804D0C0", VA = "0x18804E2C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type BKAKOKDAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x804DD00", Offset = "0x804CB00", VA = "0x18804DD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JNEJELKBDPK OOONCBOEFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x804DB80", Offset = "0x804C980", VA = "0x18804DB80")]
		get
		{
			return default(JNEJELKBDPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BMOCNMBPMAF FKCOJIPHCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x804E0C0", Offset = "0x804CEC0", VA = "0x18804E0C0")]
		get
		{
			return default(BMOCNMBPMAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PGAKMMJBNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x804E400", Offset = "0x804D200", VA = "0x18804E400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OGJCNALMGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x804E070", Offset = "0x804CE70", VA = "0x18804E070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KMKPFFFAOID
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x804E530", Offset = "0x804D330", VA = "0x18804E530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KHPFKFGBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x804DF10", Offset = "0x804CD10", VA = "0x18804DF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
	public IPPNBDGDCLE(int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x804DDE0", Offset = "0x804CBE0", VA = "0x18804DDE0", Slot = "5")]
	public bool Equals(IPPNBDGDCLE LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x804DE60", Offset = "0x804CC60", VA = "0x18804DE60", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x804E690", Offset = "0x804D490", VA = "0x18804E690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E12780", Offset = "0x4E11580", VA = "0x184E12780", Slot = "4")]
	public int CompareTo(IPPNBDGDCLE LOKLFHKEJPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct IIMPDEKBNIP<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly int CKFKPOAGPKN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private IPPNBDGDCLE LMENFEJIFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0")]
		get
		{
			return default(IPPNBDGDCLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
	internal IIMPDEKBNIP(int CKFKPOAGPKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2099710", Offset = "0x2098510", VA = "0x182099710")]
	public static IPPNBDGDCLE JGGBAIGHKJA(IIMPDEKBNIP<T> DAGPCGHBFAL)
	{
		return default(IPPNBDGDCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F20FA0", Offset = "0x4F1FDA0", VA = "0x184F20FA0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4F22100", Offset = "0x4F20F00", VA = "0x184F22100", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8043900", Offset = "0x8042700", VA = "0x188043900")]
		public static (long, string, string)[] GPPKPGNIEOD(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : GJHMCNCFKOC, MKFBMAGPOMA
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
			[Cpp2IlInjected.Address(RVA = "0x804D930", Offset = "0x804C730", VA = "0x18804D930", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x804D880", Offset = "0x804C680", VA = "0x18804D880", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x804D9F0", Offset = "0x804C7F0", VA = "0x18804D9F0")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Dictionary<Type, FOGBDCNLNBN> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<Type, FOGBDCNLNBN> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x804EB70", Offset = "0x804D970", VA = "0x18804EB70")]
		public static IReadOnlyDictionary<Type, FOGBDCNLNBN> MMNIMKPBCEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x804EAB0", Offset = "0x804D8B0", VA = "0x18804EAB0")]
		private Dictionary<Type, FOGBDCNLNBN> HIMDKAKGPHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x804EBC0", Offset = "0x804D9C0", VA = "0x18804EBC0")]
		private void OMPLKJHOKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x804EA30", Offset = "0x804D830", VA = "0x18804EA30")]
		private readonly void GFPLLMEAJIO(Type interfaceType, FOGBDCNLNBN implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x804EFA0", Offset = "0x804DDA0", VA = "0x18804EFA0")]
		public static Type[] AENFKGEFPPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x804F000", Offset = "0x804DE00", VA = "0x18804F000")]
		private static void HIMDKAKGPHI()
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
	public class SandboxDeformableShapeDefaults : HFICJIKIKPN, GJHMCNCFKOC, MKFBMAGPOMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x11CAD10", Offset = "0x11C9B10", VA = "0x1811CAD10", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x17F5090", Offset = "0x17F3E90", VA = "0x1817F5090", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x80613B0", Offset = "0x80601B0", VA = "0x1880613B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8061410", Offset = "0x8060210", VA = "0x188061410", Slot = "4")]
		public void HPANNKPMOKF(MKFBMAGPOMA networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
	public class R2SandboxDeformableShapeNetworkData : BNCDNLOFIDE, MKFBMAGPOMA, GJHMCNCFKOC, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private MFIPALKLGLC service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8061180", Offset = "0x805FF80", VA = "0x188061180", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8061110", Offset = "0x805FF10", VA = "0x188061110", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8060FE0", Offset = "0x805FDE0", VA = "0x188060FE0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x80612D0", Offset = "0x80600D0", VA = "0x1880612D0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8060F20", Offset = "0x805FD20", VA = "0x188060F20", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8061050", Offset = "0x805FE50", VA = "0x188061050", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8061260", Offset = "0x8060060", VA = "0x188061260", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x80611F0", Offset = "0x805FFF0", VA = "0x1880611F0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D1B6C0", Offset = "0x4D1A4C0", VA = "0x184D1B6C0")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, MFIPALKLGLC networkDataService)
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
		public static readonly IIMPDEKBNIP<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly IIMPDEKBNIP<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly IIMPDEKBNIP<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[IsBuffer]
		[R2Only]
		public static readonly IIMPDEKBNIP<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[R2Only]
		public static readonly IIMPDEKBNIP<OCFBDHPDABC> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		[IsBuffer]
		public static readonly IIMPDEKBNIP<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		public static readonly IIMPDEKBNIP<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[IsBuffer]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		public static readonly IIMPDEKBNIP<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly IIMPDEKBNIP<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly IIMPDEKBNIP<EHIJPFPOJLH> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly IIMPDEKBNIP<NPPBMLMJGNJ> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly IIMPDEKBNIP<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly IIMPDEKBNIP<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly IIMPDEKBNIP<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly IIMPDEKBNIP<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly IIMPDEKBNIP<HNLJBDHHEJL> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		[IsBuffer]
		public static readonly IIMPDEKBNIP<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly IIMPDEKBNIP<HKBNCHJJIEK> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly IIMPDEKBNIP<FHBADAKFFGA> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly IIMPDEKBNIP<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly IIMPDEKBNIP<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly IIMPDEKBNIP<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly IIMPDEKBNIP<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly IIMPDEKBNIP<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly IIMPDEKBNIP<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly IIMPDEKBNIP<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly IIMPDEKBNIP<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly IIMPDEKBNIP<KGLICKFNCGM> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly IIMPDEKBNIP<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly IIMPDEKBNIP<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly IIMPDEKBNIP<BKLCIIPAJGH> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly IIMPDEKBNIP<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly IIMPDEKBNIP<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(LGNGBLHMEFL))]
		public static readonly IIMPDEKBNIP<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly IIMPDEKBNIP<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly IIMPDEKBNIP<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly IIMPDEKBNIP<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly IIMPDEKBNIP<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly IIMPDEKBNIP<OCFBDHPDABC> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly IIMPDEKBNIP<BCFNPAGCDOG> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LENDJGLLJJI> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly IIMPDEKBNIP<AHEDCGBMDAC> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly IIMPDEKBNIP<NPPBMLMJGNJ> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly IIMPDEKBNIP<EJOMPKEOPGK> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly IIMPDEKBNIP<ONEKGAHOHGI> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		[IsBuffer]
		public static readonly IIMPDEKBNIP<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly IIMPDEKBNIP<GGKKLOFKKIO> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly IIMPDEKBNIP<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly IIMPDEKBNIP<OCNEBGNFBMJ> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly IIMPDEKBNIP<PFHEOADDPKH> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[IsBuffer]
		[R2Only]
		public static readonly IIMPDEKBNIP<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly IIMPDEKBNIP<GCLFJAMLBJN> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LAANAIEHAOK> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly IIMPDEKBNIP<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly IIMPDEKBNIP<BPIKHGANMFJ> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly IIMPDEKBNIP<ODHAEMGJCLL> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[R2Only]
		public static readonly IIMPDEKBNIP<EOMNDEHMIFN> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[R2Only]
		public static readonly IIMPDEKBNIP<BLDCCJFINOF> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[R2Only]
		public static readonly IIMPDEKBNIP<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[R2Only]
		public static readonly IIMPDEKBNIP<EOBJDHADOCF> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8051970", Offset = "0x8050770", VA = "0x188051970")]
		public static bool ONGGNFCKPFJ(IPPNBDGDCLE property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RegisterService(typeof(CKHODEBADIO), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : CKHODEBADIO, NHPEKAEFMLG, GNJFBAIKFDH
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
			[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xE416F0", Offset = "0xE404F0", VA = "0x180E416F0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xEF1200", Offset = "0xEF0000", VA = "0x180EF1200", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xFEFDB0", Offset = "0xFEEBB0", VA = "0x180FEFDB0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xFA7E80", Offset = "0xFA6C80", VA = "0x180FA7E80", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E190", VA = "0x180A5F390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3B0", Offset = "0xA5E1B0", VA = "0x180A5F3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA667D0", Offset = "0xA655D0", VA = "0x180A667D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA66740", Offset = "0xA65540", VA = "0x180A66740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public JNEJELKBDPK[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA66720", Offset = "0xA65520", VA = "0x180A66720", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA66710", Offset = "0xA65510", VA = "0x180A66710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, BMOCNMBPMAF> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA66730", Offset = "0xA65530", VA = "0x180A66730", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA66690", Offset = "0xA65490", VA = "0x180A66690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x30AAA50", Offset = "0x30A9850", VA = "0x1830AAA50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8051AC0", Offset = "0x80508C0", VA = "0x188051AC0", Slot = "14")]
		public void EDDKJIHBPCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8051A30", Offset = "0x8050830", VA = "0x188051A30", Slot = "15")]
		public void ECMDLAACMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8051AD0", Offset = "0x80508D0", VA = "0x188051AD0")]
		private void INKCELIIBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x805CD00", Offset = "0x805BB00", VA = "0x18805CD00")]
		public static void CBKCCKKPCGA(GGNHAKDMAHB writer, IPPNBDGDCLE property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x805EF50", Offset = "0x805DD50", VA = "0x18805EF50")]
		public static void KIOLLBKFMNP(OEGLMCJKFAN reader, IPPNBDGDCLE property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x805CD20", Offset = "0x805BB20", VA = "0x18805CD20")]
		private static void HICIJCLFHGJ(GGNHAKDMAHB writer, IPPNBDGDCLE property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x805EF70", Offset = "0x805DD70", VA = "0x18805EF70")]
		private static void MBKBLJOFPLA(OEGLMCJKFAN reader, IPPNBDGDCLE property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3D324F0", Offset = "0x3D312F0", VA = "0x183D324F0")]
		internal static void NEJFHFKCOKJ<T>(GGNHAKDMAHB writer, IIMPDEKBNIP<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3D32130", Offset = "0x3D30F30", VA = "0x183D32130")]
		internal static void KIDJPDKJMHF<T>(OEGLMCJKFAN reader, IIMPDEKBNIP<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3D327E0", Offset = "0x3D315E0", VA = "0x183D327E0")]
		internal static void NEJFHFKCOKJ<T>(GGNHAKDMAHB writer, IIMPDEKBNIP<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3D323B0", Offset = "0x3D311B0", VA = "0x183D323B0")]
		internal static void KIDJPDKJMHF<T>(OEGLMCJKFAN reader, IIMPDEKBNIP<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3D32600", Offset = "0x3D31400", VA = "0x183D32600")]
		internal static void NEJFHFKCOKJ<T>(GGNHAKDMAHB writer, IIMPDEKBNIP<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3D32210", Offset = "0x3D31010", VA = "0x183D32210")]
		internal static void KIDJPDKJMHF<T>(OEGLMCJKFAN reader, IIMPDEKBNIP<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8060DE0", Offset = "0x805FBE0", VA = "0x188060DE0")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x805EB40", Offset = "0x805D940", VA = "0x18805EB40")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8060CD0", Offset = "0x805FAD0", VA = "0x188060CD0")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x805ED70", Offset = "0x805DB70", VA = "0x18805ED70")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8060840", Offset = "0x805F640", VA = "0x188060840")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x805EEF0", Offset = "0x805DCF0", VA = "0x18805EEF0")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8060E50", Offset = "0x805FC50", VA = "0x188060E50")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x805ED10", Offset = "0x805DB10", VA = "0x18805ED10")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80609F0", Offset = "0x805F7F0", VA = "0x1880609F0")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x805ECB0", Offset = "0x805DAB0", VA = "0x18805ECB0")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8060C70", Offset = "0x805FA70", VA = "0x188060C70")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x805EDE0", Offset = "0x805DBE0", VA = "0x18805EDE0")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8060EB0", Offset = "0x805FCB0", VA = "0x188060EB0")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x805E800", Offset = "0x805D600", VA = "0x18805E800")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8060910", Offset = "0x805F710", VA = "0x188060910")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x805E960", Offset = "0x805D760", VA = "0x18805E960")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8060980", Offset = "0x805F780", VA = "0x188060980")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x805EE40", Offset = "0x805DC40", VA = "0x18805EE40")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x80608A0", Offset = "0x805F6A0", VA = "0x1880608A0")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x805E8B0", Offset = "0x805D6B0", VA = "0x18805E8B0")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3D326C0", Offset = "0x3D314C0", VA = "0x183D326C0")]
		internal static void NEJFHFKCOKJ<T>(GGNHAKDMAHB writer, IIMPDEKBNIP<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3D322E0", Offset = "0x3D310E0", VA = "0x183D322E0")]
		internal static void KIDJPDKJMHF<T>(OEGLMCJKFAN reader, IIMPDEKBNIP<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8060A50", Offset = "0x805F850", VA = "0x188060A50")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x805EA10", Offset = "0x805D810", VA = "0x18805EA10")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8060B60", Offset = "0x805F960", VA = "0x188060B60")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x805EBF0", Offset = "0x805D9F0", VA = "0x18805EBF0")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8060D70", Offset = "0x805FB70", VA = "0x188060D70")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<NPPBMLMJGNJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x805EAD0", Offset = "0x805D8D0", VA = "0x18805EAD0")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<NPPBMLMJGNJ> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8043820", Offset = "0x8042620", VA = "0x188043820")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IIMPDEKBNIP<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8043420", Offset = "0x8042220", VA = "0x188043420")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IIMPDEKBNIP<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8043820", Offset = "0x8042620", VA = "0x188043820")]
		internal static void NEJFHFKCOKJ(GGNHAKDMAHB writer, IPPNBDGDCLE prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8043420", Offset = "0x8042220", VA = "0x188043420")]
		internal static void KIDJPDKJMHF(OEGLMCJKFAN reader, IPPNBDGDCLE prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3D32480", Offset = "0x3D31280", VA = "0x183D32480")]
		internal static T KLHMNONIAFH<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x8061550", Offset = "0x8060350", VA = "0x188061550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8062BD0", Offset = "0x80619D0", VA = "0x188062BD0")]
		public void HIMDKAKGPHI(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x80617B0", Offset = "0x80605B0", VA = "0x1880617B0")]
		private void EHLEEFHEPDM(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4299DB0", Offset = "0x4298BB0", VA = "0x184299DB0")]
		private void ONEIDCOKELM<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4299A40", Offset = "0x4298840", VA = "0x184299A40")]
		private void KCNOAFPCGJL<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4299320", Offset = "0x4298120", VA = "0x184299320")]
		private void JCPDBIOBEKE<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
		[Cpp2IlInjected.Address(RVA = "0x8063950", Offset = "0x8062750", VA = "0x188063950")]
		public static bool IENOKIACBKG(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum JCHKOAIOLAK
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
[RegisterService(typeof(HFGPLJDDJFE), new string[] { "Registry" })]
internal class JMILNKCKKDI : HFGPLJDDJFE
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type BMHCAHFGPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8063560", Offset = "0x8062360", VA = "0x188063560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] DAIPBHHPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80635C0", Offset = "0x80623C0", VA = "0x1880635C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, FOGBDCNLNBN> OBPPIDPIHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x80635D0", Offset = "0x80623D0", VA = "0x1880635D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x80635E0", Offset = "0x80623E0", VA = "0x1880635E0", Slot = "7")]
	public void IJEMMLKDDBH(IComponentDefaultRegistration JILCCLBMMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JMILNKCKKDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class LNINIEPMADD : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class AOBLONDFDMN : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8063530", Offset = "0x8062330", VA = "0x188063530", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8063440", Offset = "0x8062240", VA = "0x188063440")]
		public AOBLONDFDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x23EB140", Offset = "0x23E9F40", VA = "0x1823EB140", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 CHDHLAGMCKI)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8063430", Offset = "0x8062230", VA = "0x188063430", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 CHDHLAGMCKI, ObjectPrefabType_v1 BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8063600", Offset = "0x8062400", VA = "0x188063600")]
	public LNINIEPMADD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8063780", Offset = "0x8062580", VA = "0x188063780")]
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
