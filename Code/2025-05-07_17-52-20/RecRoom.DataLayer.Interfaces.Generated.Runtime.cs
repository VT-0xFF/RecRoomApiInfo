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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BF94B0", Offset = "0x7BF84B0", VA = "0x187BF94B0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B94F80", Offset = "0x7B93F80", VA = "0x187B94F80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C5C0", Offset = "0x7C0B5C0", VA = "0x187C0C5C0")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C450", Offset = "0x7C0B450", VA = "0x187C0C450")]
		private void KMFPJCIAGGA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C730", Offset = "0x7C0B730", VA = "0x187C0C730", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CA60", Offset = "0x7C0BA60", VA = "0x187C0CA60")]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	[CompilerGenerated]
	public struct SerializedDataLayerVersionData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
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
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	[CompilerGenerated]
	public struct AuthoredAIIdData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[TypeManager.ForcedStableTypeHash(11324154004334192783uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
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
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
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
public readonly struct ANLDAMAMKAN : IComparable<ANLDAMAMKAN>, IEquatable<ANLDAMAMKAN>
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ANLDAMAMKAN CABIBLEKJPN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly ANLDAMAMKAN MEMFJIEDBEK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ANLDAMAMKAN KENPINJOJJC;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly ANLDAMAMKAN NLBKGNFDBPB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly ANLDAMAMKAN DBFEFOMHEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly ANLDAMAMKAN EHPNFGNMAJI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly int OHHMJGCBCKD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type GGGLMMJGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE990", Offset = "0x7BED990", VA = "0x187BEE990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PFBGAKLJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE850", Offset = "0x7BED850", VA = "0x187BEE850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EOMGDLMNCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE020", Offset = "0x7BED020", VA = "0x187BEE020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type OLEKDPCJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE550", Offset = "0x7BED550", VA = "0x187BEE550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CCELIBMPGDF GNLNKAALLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE630", Offset = "0x7BED630", VA = "0x187BEE630")]
		get
		{
			return default(CCELIBMPGDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AHOKLBCDDAE AHBDJAJMPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEA70", Offset = "0x7BEDA70", VA = "0x187BEEA70")]
		get
		{
			return default(AHOKLBCDDAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MKFEJLPKALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE7B0", Offset = "0x7BED7B0", VA = "0x187BEE7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LACLGCKNMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE800", Offset = "0x7BED800", VA = "0x187BEE800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OKFJHPIKMND
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE290", Offset = "0x7BED290", VA = "0x187BEE290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OOMGPDNBLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE3F0", Offset = "0x7BED3F0", VA = "0x187BEE3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
	public ANLDAMAMKAN(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE210", Offset = "0x7BED210", VA = "0x187BEE210", Slot = "5")]
	public bool Equals(ANLDAMAMKAN MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE160", Offset = "0x7BED160", VA = "0x187BEE160", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEC70", Offset = "0x7BEDC70", VA = "0x187BEEC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x44BC610", Offset = "0x44BB610", VA = "0x1844BC610", Slot = "4")]
	public int CompareTo(ANLDAMAMKAN MIJLJBIHDMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct DFJLOPPNCOO<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly int OHHMJGCBCKD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private ANLDAMAMKAN HCBBCLIMFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
		get
		{
			return default(ANLDAMAMKAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
	internal DFJLOPPNCOO(int OHHMJGCBCKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1E45530", Offset = "0x1E44530", VA = "0x181E45530")]
	public static ANLDAMAMKAN OIFHDJNIHDL(DFJLOPPNCOO<T> LLPAKFGNDOB)
	{
		return default(ANLDAMAMKAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A598C0", Offset = "0x6A588C0", VA = "0x186A598C0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A59B00", Offset = "0x6A58B00", VA = "0x186A59B00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEF010", Offset = "0x7BEE010", VA = "0x187BEF010")]
		public static (long, string, string)[] JFBKCOMBBBD(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : ICEKMMAICHD, LGFMDGFNDFK
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
			[Cpp2IlInjected.Address(RVA = "0x7BF8EC0", Offset = "0x7BF7EC0", VA = "0x187BF8EC0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7BF8E10", Offset = "0x7BF7E10", VA = "0x187BF8E10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8F80", Offset = "0x7BF7F80", VA = "0x187BF8F80")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Dictionary<Type, OOIHLNFJLFI> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<Type, OOIHLNFJLFI> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9110", Offset = "0x7BF8110", VA = "0x187BF9110")]
		public static IReadOnlyDictionary<Type, OOIHLNFJLFI> LGBNFNKAAIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8FD0", Offset = "0x7BF7FD0", VA = "0x187BF8FD0")]
		private Dictionary<Type, OOIHLNFJLFI> AMBIAOGNIIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9160", Offset = "0x7BF8160", VA = "0x187BF9160")]
		private void ODMFPDCAACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9090", Offset = "0x7BF8090", VA = "0x187BF9090")]
		private readonly void EHKBFLBPAKO(Type interfaceType, OOIHLNFJLFI implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x7BFB380", Offset = "0x7BFA380", VA = "0x187BFB380")]
		public static Type[] OBEIJCBPENJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9540", Offset = "0x7BF8540", VA = "0x187BF9540")]
		private static void AMBIAOGNIIF()
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
	public class SandboxDeformableShapeDefaults : ECMEDEOEGOM, ICEKMMAICHD, LGFMDGFNDFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15DE750", Offset = "0x15DD750", VA = "0x1815DE750", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x15DE740", Offset = "0x15DD740", VA = "0x1815DE740", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7C0ACB0", Offset = "0x7C09CB0", VA = "0x187C0ACB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AD10", Offset = "0x7C09D10", VA = "0x187C0AD10", Slot = "4")]
		public void PNJIDJCBNNF(LGFMDGFNDFK networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	public class R2SandboxDeformableShapeNetworkData : ICEKMMAICHD, LGFMDGFNDFK, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private KAFHPENPANL service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A970", Offset = "0x7C09970", VA = "0x187C0A970", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A890", Offset = "0x7C09890", VA = "0x187C0A890", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A820", Offset = "0x7C09820", VA = "0x187C0A820", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A900", Offset = "0x7C09900", VA = "0x187C0A900", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7C0AAA0", Offset = "0x7C09AA0", VA = "0x187C0AAA0", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A9E0", Offset = "0x7C099E0", VA = "0x187C0A9E0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7C0AB60", Offset = "0x7C09B60", VA = "0x187C0AB60", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7C0ABD0", Offset = "0x7C09BD0", VA = "0x187C0ABD0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x48D0690", Offset = "0x48CF690", VA = "0x1848D0690")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, KAFHPENPANL networkDataService)
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
		public static readonly DFJLOPPNCOO<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly DFJLOPPNCOO<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly DFJLOPPNCOO<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[R2Only]
		[IsBuffer]
		public static readonly DFJLOPPNCOO<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[R2Only]
		public static readonly DFJLOPPNCOO<JCGOJLOCOAC> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[IsBuffer]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		public static readonly DFJLOPPNCOO<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		[IsBuffer]
		public static readonly DFJLOPPNCOO<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[R2Only]
		public static readonly DFJLOPPNCOO<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly DFJLOPPNCOO<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LLKIPCFLHEA> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly DFJLOPPNCOO<ENANNCNMKEP> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly DFJLOPPNCOO<int> CostumePieceSlotIndex_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly DFJLOPPNCOO<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly DFJLOPPNCOO<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly DFJLOPPNCOO<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly DFJLOPPNCOO<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly DFJLOPPNCOO<PMBKPGKOHOL> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		[IsBuffer]
		public static readonly DFJLOPPNCOO<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly DFJLOPPNCOO<DDDGCGEFBGF> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly DFJLOPPNCOO<JMKKFNHDEDM> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly DFJLOPPNCOO<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		public static readonly DFJLOPPNCOO<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		public static readonly DFJLOPPNCOO<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly DFJLOPPNCOO<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly DFJLOPPNCOO<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly DFJLOPPNCOO<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly DFJLOPPNCOO<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly DFJLOPPNCOO<GCBFKFHDHEE> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly DFJLOPPNCOO<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly DFJLOPPNCOO<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly DFJLOPPNCOO<CMOLENMEPKL> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly DFJLOPPNCOO<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly DFJLOPPNCOO<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(PLPGENBLKMG))]
		public static readonly DFJLOPPNCOO<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly DFJLOPPNCOO<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly DFJLOPPNCOO<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly DFJLOPPNCOO<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly DFJLOPPNCOO<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly DFJLOPPNCOO<GBOINGGHPAL> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly DFJLOPPNCOO<OFEGKJHLAID> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly DFJLOPPNCOO<JKFPCOPLDFP> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly DFJLOPPNCOO<ENANNCNMKEP> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly DFJLOPPNCOO<NEKAFJNOKCP> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> CostumePieceParentCostume_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[IsBuffer]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly DFJLOPPNCOO<JCLGHPNFNJF> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly DFJLOPPNCOO<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly DFJLOPPNCOO<BOHBIJHNLLB> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly DFJLOPPNCOO<HCGMHICBIDB> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[IsBuffer]
		[R2Only]
		public static readonly DFJLOPPNCOO<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly DFJLOPPNCOO<HGKJLDPCHCO> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly DFJLOPPNCOO<KCBFJLKHEKK> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly DFJLOPPNCOO<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly DFJLOPPNCOO<PHJDCIAHNAI> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly DFJLOPPNCOO<FMJNGMHIFLD> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly DFJLOPPNCOO<NAAMCHMIHPA> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LBIGPLJKBAG> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly DFJLOPPNCOO<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly DFJLOPPNCOO<AEGDAJEGAFP> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	[RegisterService(typeof(HLCLLHOCBMM), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : HLCLLHOCBMM, IJFNBDMABCN, MMMIGLKPHHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD021C0", Offset = "0xD011C0", VA = "0x180D021C0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xDBD010", Offset = "0xDBC010", VA = "0x180DBD010", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xEB1930", Offset = "0xEB0930", VA = "0x180EB1930", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xE67710", Offset = "0xE66710", VA = "0x180E67710", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9F9080", Offset = "0x9F8080", VA = "0x1809F9080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CCELIBMPGDF[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, AHOKLBCDDAE> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2DE9A50", Offset = "0x2DE8A50", VA = "0x182DE9A50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C068C0", Offset = "0x7C058C0", VA = "0x187C068C0", Slot = "14")]
		public void OPNHMMPAKCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C06830", Offset = "0x7C05830", VA = "0x187C06830", Slot = "15")]
		public void NHMAMKPPBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBD50", Offset = "0x7BFAD50", VA = "0x187BFBD50")]
		private void AKKGFCCOFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C090C0", Offset = "0x7C080C0", VA = "0x187C090C0")]
		public static void MBDPDJBPPBD(EIJLIFDICMP writer, ANLDAMAMKAN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C07020", Offset = "0x7C06020", VA = "0x187C07020")]
		public static void BDMHBIMDPEN(IJBBDEBOFIN reader, ANLDAMAMKAN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C07720", Offset = "0x7C06720", VA = "0x187C07720")]
		private static void FKHCNIDGHAO(EIJLIFDICMP writer, ANLDAMAMKAN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C090E0", Offset = "0x7C080E0", VA = "0x187C090E0")]
		private static void MCJOBJJFCDJ(IJBBDEBOFIN reader, ANLDAMAMKAN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x39C0370", Offset = "0x39BF370", VA = "0x1839C0370")]
		internal static void DFNAEDFOBIJ<T>(EIJLIFDICMP writer, DFJLOPPNCOO<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x39BFFC0", Offset = "0x39BEFC0", VA = "0x1839BFFC0")]
		internal static void AKDPGDCBDMI<T>(IJBBDEBOFIN reader, DFJLOPPNCOO<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x39C06C0", Offset = "0x39BF6C0", VA = "0x1839C06C0")]
		internal static void DFNAEDFOBIJ<T>(EIJLIFDICMP writer, DFJLOPPNCOO<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x39C0280", Offset = "0x39BF280", VA = "0x1839C0280")]
		internal static void AKDPGDCBDMI<T>(IJBBDEBOFIN reader, DFJLOPPNCOO<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x39C0490", Offset = "0x39BF490", VA = "0x1839C0490")]
		internal static void DFNAEDFOBIJ<T>(EIJLIFDICMP writer, DFJLOPPNCOO<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x39C00B0", Offset = "0x39BF0B0", VA = "0x1839C00B0")]
		internal static void AKDPGDCBDMI<T>(IJBBDEBOFIN reader, DFJLOPPNCOO<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C07470", Offset = "0x7C06470", VA = "0x187C07470")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C06AB0", Offset = "0x7C05AB0", VA = "0x187C06AB0")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C073D0", Offset = "0x7C063D0", VA = "0x187C073D0")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D30", Offset = "0x7C05D30", VA = "0x187C06D30")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C07300", Offset = "0x7C06300", VA = "0x187C07300")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C06940", Offset = "0x7C05940", VA = "0x187C06940")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C074E0", Offset = "0x7C064E0", VA = "0x187C074E0")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C06E50", Offset = "0x7C05E50", VA = "0x187C06E50")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C07230", Offset = "0x7C06230", VA = "0x187C07230")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C06CD0", Offset = "0x7C05CD0", VA = "0x187C06CD0")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C076C0", Offset = "0x7C066C0", VA = "0x187C076C0")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C06A50", Offset = "0x7C05A50", VA = "0x187C06A50")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C07360", Offset = "0x7C06360", VA = "0x187C07360")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B60", Offset = "0x7C05B60", VA = "0x187C06B60")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C07540", Offset = "0x7C06540", VA = "0x187C07540")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C069A0", Offset = "0x7C059A0", VA = "0x187C069A0")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C07150", Offset = "0x7C06150", VA = "0x187C07150")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C06EB0", Offset = "0x7C05EB0", VA = "0x187C06EB0")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7C07290", Offset = "0x7C06290", VA = "0x187C07290")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7C06DA0", Offset = "0x7C05DA0", VA = "0x187C06DA0")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x39C0570", Offset = "0x39BF570", VA = "0x1839C0570")]
		internal static void DFNAEDFOBIJ<T>(EIJLIFDICMP writer, DFJLOPPNCOO<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x39C0190", Offset = "0x39BF190", VA = "0x1839C0190")]
		internal static void AKDPGDCBDMI<T>(IJBBDEBOFIN reader, DFJLOPPNCOO<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7C075B0", Offset = "0x7C065B0", VA = "0x187C075B0")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C06F60", Offset = "0x7C05F60", VA = "0x187C06F60")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C07040", Offset = "0x7C06040", VA = "0x187C07040")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C10", Offset = "0x7C05C10", VA = "0x187C06C10")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C071C0", Offset = "0x7C061C0", VA = "0x187C071C0")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<ENANNCNMKEP> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C068D0", Offset = "0x7C058D0", VA = "0x187C068D0")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<ENANNCNMKEP> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7BEDF40", Offset = "0x7BECF40", VA = "0x187BEDF40")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, DFJLOPPNCOO<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7BEDD60", Offset = "0x7BECD60", VA = "0x187BEDD60")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, DFJLOPPNCOO<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7BEDF40", Offset = "0x7BECF40", VA = "0x187BEDF40")]
		internal static void DFNAEDFOBIJ(EIJLIFDICMP writer, ANLDAMAMKAN prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7BEDD60", Offset = "0x7BECD60", VA = "0x187BEDD60")]
		internal static void AKDPGDCBDMI(IJBBDEBOFIN reader, ANLDAMAMKAN prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x39C07A0", Offset = "0x39BF7A0", VA = "0x1839C07A0")]
		internal static T JBCFJHCNNHA<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AE50", Offset = "0x7C09E50", VA = "0x187C0AE50")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B0B0", Offset = "0x7C0A0B0", VA = "0x187C0B0B0")]
		public void AMBIAOGNIIF(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B0C0", Offset = "0x7C0A0C0", VA = "0x187C0B0C0")]
		private void FBNMPNBIACB(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB770", Offset = "0x3ECA770", VA = "0x183ECB770")]
		private void ICLBELPPJNK<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAC30", Offset = "0x3EC9C30", VA = "0x183ECAC30")]
		private void HCPBIAENOEG<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAFF0", Offset = "0x3EC9FF0", VA = "0x183ECAFF0")]
		private void ICHHCHDMAJP<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum TaggedVersions
		{
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			UpgradeConfigurableCollisionPhysicsData = 154
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D1B0", Offset = "0x7C0C1B0", VA = "0x187C0D1B0")]
		public static bool DGMJNHFBICM(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum NHOBBIHNHJO
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[CompilerGenerated]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(15785220565177840581uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private sbyte last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(14677347344669018359uL)]
	internal struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterService(typeof(OFFLAAFPNBI), new string[] { "Registry" })]
internal class FPNJIAIHFBD : OFFLAAFPNBI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type NKKEMIBCHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CF80", Offset = "0x7C0BF80", VA = "0x187C0CF80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] JFBLFPGEFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CF70", Offset = "0x7C0BF70", VA = "0x187C0CF70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, OOIHLNFJLFI> CPJMLBHDJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CF40", Offset = "0x7C0BF40", VA = "0x187C0CF40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CF50", Offset = "0x7C0BF50", VA = "0x187C0CF50", Slot = "7")]
	public void JIMIDMPMKGF(IComponentDefaultRegistration HKDJCDHGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FPNJIAIHFBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class BNPCCHOMGAD : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class DOIIJKGLGHD : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7C0CF10", Offset = "0x7C0BF10", VA = "0x187C0CF10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CE20", Offset = "0x7C0BE20", VA = "0x187C0CE20")]
		public DOIIJKGLGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2159BE0", Offset = "0x2158BE0", VA = "0x182159BE0", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 NELIKBMJKPH)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CE10", Offset = "0x7C0BE10", VA = "0x187C0CE10", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 NELIKBMJKPH, ObjectPrefabType_v1 OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CC90", Offset = "0x7C0BC90", VA = "0x187C0CC90")]
	public BNPCCHOMGAD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CFE0", Offset = "0x7C0BFE0", VA = "0x187C0CFE0")]
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
