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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x808A5C0", Offset = "0x80891C0", VA = "0x18808A5C0", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x230C5A0", Offset = "0x230B1A0", VA = "0x18230C5A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x809E7F0", Offset = "0x809D3F0", VA = "0x18809E7F0")]
		private void GAOPLNBGOGD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x809E680", Offset = "0x809D280", VA = "0x18809E680")]
		private void BBOPNMEHPCH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x809E960", Offset = "0x809D560", VA = "0x18809E960", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x809EC90", Offset = "0x809D890", VA = "0x18809EC90")]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	public struct AuthoredAIIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct PhysicsModelFlagsData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(1)]
		public PhysicsModelEnumFlags_v2 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[CompilerGenerated]
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
public readonly struct KMJOEPGFAJK : IComparable<KMJOEPGFAJK>, IEquatable<KMJOEPGFAJK>
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KMJOEPGFAJK DNKJCLIALLN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KMJOEPGFAJK PKKMJLPPHKP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KMJOEPGFAJK BKIMBJDNJEO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly KMJOEPGFAJK MKCGHCMHLHN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KMJOEPGFAJK PBEADAKBKFB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly KMJOEPGFAJK MBCGBOBHPCJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly int LCCBBMBENOH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type ONIENPDOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8089FE0", Offset = "0x8088BE0", VA = "0x188089FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MMKAIHHLJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8089EA0", Offset = "0x8088AA0", VA = "0x188089EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FEOFCNGFMML
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8089A10", Offset = "0x8088610", VA = "0x188089A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type NCHCKDBIDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8089730", Offset = "0x8088330", VA = "0x188089730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FFBFPGPHNIA PMBNFLJJLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8089CD0", Offset = "0x80888D0", VA = "0x188089CD0")]
		get
		{
			return default(FFBFPGPHNIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NHNJCELMFAL FIAMACBEEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8089810", Offset = "0x8088410", VA = "0x188089810")]
		get
		{
			return default(NHNJCELMFAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FOMDJJPKGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8089C80", Offset = "0x8088880", VA = "0x188089C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PDIFBJGIFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8089E50", Offset = "0x8088A50", VA = "0x188089E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IFICHCJDAID
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x808A0C0", Offset = "0x8088CC0", VA = "0x18808A0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OKGPFHLJGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80895D0", Offset = "0x80881D0", VA = "0x1880895D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0")]
	public KMJOEPGFAJK(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8089C00", Offset = "0x8088800", VA = "0x188089C00", Slot = "5")]
	public bool Equals(KMJOEPGFAJK IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8089B50", Offset = "0x8088750", VA = "0x188089B50", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x808A220", Offset = "0x8088E20", VA = "0x18808A220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C560B0", Offset = "0x6C54CB0", VA = "0x186C560B0", Slot = "4")]
	public int CompareTo(KMJOEPGFAJK IIOGPDPGOLB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct ONEJOBGIIJE<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly int LCCBBMBENOH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private KMJOEPGFAJK BIPNPDBKLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
		get
		{
			return default(KMJOEPGFAJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0")]
	internal ONEJOBGIIJE(int LCCBBMBENOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x20CFE30", Offset = "0x20CEA30", VA = "0x1820CFE30")]
	public static KMJOEPGFAJK KDDDGPNBGLG(ONEJOBGIIJE<T> ABMJBIODBLM)
	{
		return default(KMJOEPGFAJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5886A70", Offset = "0x5885670", VA = "0x185886A70", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5887AB0", Offset = "0x58866B0", VA = "0x185887AB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x807DD70", Offset = "0x807C970", VA = "0x18807DD70")]
		public static (long, string, string)[] JIPCCHKGNCB(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class DECBSandboxDeformableShapeNetworkData : MAAIGLGFMMK, GKNPGOIAOJL
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
			[Cpp2IlInjected.Address(RVA = "0x8088F30", Offset = "0x8087B30", VA = "0x188088F30", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8088FF0", Offset = "0x8087BF0", VA = "0x188088FF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x80890A0", Offset = "0x8087CA0", VA = "0x1880890A0")]
		public DECBSandboxDeformableShapeNetworkData(Entity entity, DeferredEntityCommandBuffer decb)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	internal struct InterfaceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Dictionary<Type, NDOKNDCGEEG> instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<Type, NDOKNDCGEEG> interfaces;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80890F0", Offset = "0x8087CF0", VA = "0x1880890F0")]
		public static IReadOnlyDictionary<Type, NDOKNDCGEEG> AEJBBAMDLLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8089490", Offset = "0x8088090", VA = "0x188089490")]
		private Dictionary<Type, NDOKNDCGEEG> AMHLLDBNIFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8089140", Offset = "0x8087D40", VA = "0x188089140")]
		private void AKBPDKMBJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8089550", Offset = "0x8088150", VA = "0x188089550")]
		private readonly void HBGKFBNMDGO(Type interfaceType, NDOKNDCGEEG implementationType)
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
		[Cpp2IlInjected.Address(RVA = "0x808C790", Offset = "0x808B390", VA = "0x18808C790")]
		public static Type[] ELPNMPEOJJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x808A650", Offset = "0x8089250", VA = "0x18808A650")]
		private static void AMHLLDBNIFP()
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
	public class SandboxDeformableShapeDefaults : GHDHONHDFLA, MAAIGLGFMMK, GKNPGOIAOJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private float3 scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x11C77F0", Offset = "0x11C63F0", VA = "0x1811C77F0", Slot = "6")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x18219E0", Offset = "0x18205E0", VA = "0x1818219E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type NetworkDataInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x809E3F0", Offset = "0x809CFF0", VA = "0x18809E3F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x809E2B0", Offset = "0x809CEB0", VA = "0x18809E2B0", Slot = "4")]
		public void IMHILHBHKJC(GKNPGOIAOJL networkData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
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
	public class R2SandboxDeformableShapeNetworkData : PGCOHAINJNI, GKNPGOIAOJL, MAAIGLGFMMK, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private NAEBDHBFECH service;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x809DE90", Offset = "0x809CA90", VA = "0x18809DE90", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x809E160", Offset = "0x809CD60", VA = "0x18809E160", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x809E1D0", Offset = "0x809CDD0", VA = "0x18809E1D0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x809DE20", Offset = "0x809CA20", VA = "0x18809DE20", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x809DF00", Offset = "0x809CB00", VA = "0x18809DF00", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x809E030", Offset = "0x809CC30", VA = "0x18809E030", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		private event Action RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x809DFC0", Offset = "0x809CBC0", VA = "0x18809DFC0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x809E0F0", Offset = "0x809CCF0", VA = "0x18809E0F0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4DFB200", Offset = "0x4DF9E00", VA = "0x184DFB200")]
		public R2SandboxDeformableShapeNetworkData(Entity entity, NAEBDHBFECH networkDataService)
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
		public static readonly ONEJOBGIIJE<uint> OverrideObjectNetworkId_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[R2Only]
		public static readonly ONEJOBGIIJE<FixedList32Bytes<int>> PersistentUserTag_tags;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> PersistentUserTag_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[IsBuffer]
		[R2Only]
		public static readonly ONEJOBGIIJE<ulong> RemovedNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float3> LocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float3> SplinePointScale_localScale;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> ElementSnapPoint_snappedTo;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> LocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[R2Only]
		public static readonly ONEJOBGIIJE<CLBPEPNMNAE> InteractionFilterEnabled_filterMode;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[R2Only]
		[IsBuffer]
		public static readonly ONEJOBGIIJE<LocalId> ReferenceGroupReference_reference;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[R2Only]
		public static readonly ONEJOBGIIJE<long> InventionId_inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[R2Only]
		[IsBuffer]
		public static readonly ONEJOBGIIJE<LocalId> UserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[R2Only]
		[IsBuffer]
		public static readonly ONEJOBGIIJE<TerrainGenerationLayer> TerrainLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> OwnedByTerrain_isOwnedByTerrain;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[R2Only]
		public static readonly ONEJOBGIIJE<int> SerializedDataLayerVersion_version;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> ReferenceGroupOwner_owner;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> MakerPenHeld_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> ToolCleanupSettings_delay;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[R2Only]
		public static readonly ONEJOBGIIJE<DOAPHOIIDLI> ToolCleanupSettings_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[R2Only]
		public static readonly ONEJOBGIIJE<EJDHJMPEDMM> SplinePointOrder_order;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[R2Only]
		public static readonly ONEJOBGIIJE<quaternion> LocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float3> LocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[R2Only]
		public static readonly ONEJOBGIIJE<FixedString64Bytes> AiCodeGenName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[R2Only]
		public static readonly ONEJOBGIIJE<int> ReplicatorPreallocatedObjectCount_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[R2Only]
		public static readonly ONEJOBGIIJE<quaternion> SplinePointRotation_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> InteractionFilterAllTags_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> ToolCleanupStatus_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[R2Only]
		public static readonly ONEJOBGIIJE<JEHMKKLDPGH> ToolCleanupStatus_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> InteractionFilterAnyTags_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[R2Only]
		public static readonly ONEJOBGIIJE<uint> TerrainGeneration_Seed;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> TerrainGeneration_BaseTerrainHeight;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> TerrainGeneration_BaseTerrainFeatureScale;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[R2Only]
		public static readonly ONEJOBGIIJE<ICMOIJBHMPP> TerrainGeneration_PlayAreaShape;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[R2Only]
		public static readonly ONEJOBGIIJE<KCNHKGPCNMH> TerrainGeneration_BaseTerrainRoughness;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[R2Only]
		public static readonly ONEJOBGIIJE<DIPACINJNHP> TerrainGeneration_BaseTerrainHeightFunction;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[R2Only]
		[IsBuffer]
		public static readonly ONEJOBGIIJE<CPAFJEBFNBF> TerrainMaterialLayer_layer;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[R2Only]
		[IsBuffer]
		public static readonly ONEJOBGIIJE<byte> ContainerName_data;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float3> SplinePointPosition_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[R2Only]
		public static readonly ONEJOBGIIJE<KNMEHEMEPOL> ShapeType_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> DesyncEntityReference_entity;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LDLEEKNJJFJ> PrimitiveShape_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> Replicator_Target;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> Replicator_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> PlayerScope_playerScope;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[R2Only]
		public static readonly ONEJOBGIIJE<FixedString64Bytes> AiCodeGenId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[R2Only]
		public static readonly ONEJOBGIIJE<NetworkGuid> InventionInstanceId_instanceId;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float3> AuthoredLocalDeformableScale_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> EntityPrefabPart_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[R2Only]
		public static readonly ONEJOBGIIJE<uint> EntityPrefabPart_partId;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[R2Only]
		public static readonly ONEJOBGIIJE<uint> ReplicatorExpectedCircuitsRevision_ExpectedRevision;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> OMShapeContainer_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> OMShapeContainer_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> AuthoredParent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[R2Only]
		public static readonly ONEJOBGIIJE<FixedString32Bytes> UserTagName_Value;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[R2Only]
		public static readonly ONEJOBGIIJE<DMKDAHIMIGM> NavMeshGeneration_mode;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[R2Only]
		public static readonly ONEJOBGIIJE<FixedString64Bytes> ContainerName_name;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> ContainerIsRecolorable_IsRecolorable;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[R2Only]
		public static readonly ONEJOBGIIJE<EHENCINGLKE> ShapeConfig_flags;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> Parent_parent;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> MagneticAnchor_connectedAnchor;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[R2Only]
		public static readonly ONEJOBGIIJE<uint> AuthoredAIId_Value;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[R2Only]
		public static readonly ONEJOBGIIJE<int> ReplicatorMaxObjectCount_count;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> DesyncNetworkEntityBackReference_entity;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(KHDMCOLMFDK))]
		public static readonly ONEJOBGIIJE<float3> SandboxDeformableShape_Scale;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[R2Only]
		public static readonly ONEJOBGIIJE<bool> ReplicatedObjectActiveStatus_active;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> PhysicsModelMassOverride_mass;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[R2Only]
		public static readonly ONEJOBGIIJE<quaternion> AuthoredLocalPose_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float3> AuthoredLocalPose_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[R2Only]
		public static readonly ONEJOBGIIJE<NetworkGuid> ObjectBoardNode_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[R2Only]
		public static readonly ONEJOBGIIJE<NetworkGuid> ObjectBoardNode_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> ObjectInteractionFilter_entity;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[R2Only]
		public static readonly ONEJOBGIIJE<CLBPEPNMNAE> ObjectInteractionFilter_mode;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> AuthoredLocalUniformScale_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[R2Only]
		public static readonly ONEJOBGIIJE<PFELNBBIHNK> StandardRenderableVisual_color;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[R2Only]
		public static readonly ONEJOBGIIJE<MEKNHMCLLHC> StandardRenderableVisual_material;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> StandardRenderableVisual_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float3> StandardRenderableVisual_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[R2Only]
		public static readonly ONEJOBGIIJE<PKHKHHIBOLB> PhysicsModelCollisionLayer_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> InteractionFilterNoneTags_noneTags;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[R2Only]
		public static readonly ONEJOBGIIJE<EJDHJMPEDMM> SiblingSortOrder_order;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[R2Only]
		public static readonly ONEJOBGIIJE<HADDMPHJDFI> ElementSnapPointRuntimeFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[R2Only]
		public static readonly ONEJOBGIIJE<EIBOFLPIJKL> PhysicsModelGrabbableMode_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[IsBuffer]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> AuthoredUserTagReference_Child;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LIACMAGLFCP> SplineShape_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[R2Only]
		public static readonly ONEJOBGIIJE<int> ReplicatedObjectOwnedByPlayer_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[R2Only]
		public static readonly ONEJOBGIIJE<DBNFECDEJAL> TransformFlags_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[R2Only]
		public static readonly ONEJOBGIIJE<KCMGGEJIJHC> TransformFlags_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[IsBuffer]
		[R2Only]
		public static readonly ONEJOBGIIJE<ulong> DesyncNetworkComponents_stableTypeHash;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[R2Only]
		public static readonly ONEJOBGIIJE<GCOFBKNOKHB> PhysicsModelFlags_flags;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[R2Only]
		public static readonly ONEJOBGIIJE<NGPGMOPOLKA> PhysicsModelCollisionMode_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> InteractionFilterEntityRef_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[R2Only]
		public static readonly ONEJOBGIIJE<float> PhysicsMaterial_density;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[R2Only]
		public static readonly ONEJOBGIIJE<PLGJBNGJIHN> ObjectPolicy_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[R2Only]
		public static readonly ONEJOBGIIJE<GOFNDNICMIL> ObjectPolicy_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[R2Only]
		public static readonly ONEJOBGIIJE<IKHNFFIHEKH> ObjectPolicy_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LNEEJIFPGOM> ObjectPolicy_flags;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[R2Only]
		public static readonly ONEJOBGIIJE<LocalId> SplinePointParent_spline;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[R2Only]
		public static readonly ONEJOBGIIJE<MCKGLJLILAB> ReferenceGroupKind_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	public static class NetworkPropertyAuthority
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x808D2E0", Offset = "0x808BEE0", VA = "0x18808D2E0")]
		public static bool CGGLDOOGOBP(KMJOEPGFAJK property, bool isMaster, bool hasAuth)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RegisterService(typeof(AIICGMJEAFM), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : AIICGMJEAFM, HHIKJEGILJH, IBPJLLPNJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private NativeBitArray desyncByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private NativeParallelHashSet<int> desyncTypeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xE507D0", Offset = "0xE4F3D0", VA = "0x180E507D0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xE4A620", Offset = "0xE49220", VA = "0x180E4A620", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xF075C0", Offset = "0xF061C0", VA = "0x180F075C0", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xFF7150", Offset = "0xFF5D50", VA = "0x180FF7150", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NativeParallelHashSet<int> DesyncTypeIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xFA0770", Offset = "0xF9F370", VA = "0x180FA0770", Slot = "10")]
			get
			{
				return default(NativeParallelHashSet<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA5B440", Offset = "0xA5A040", VA = "0x180A5B440", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5B650", Offset = "0xA5A250", VA = "0x180A5B650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBE0", Offset = "0xA5D7E0", VA = "0x180A5EBE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA5EAC0", Offset = "0xA5D6C0", VA = "0x180A5EAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public FFBFPGPHNIA[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB40", Offset = "0xA5D740", VA = "0x180A5EB40", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB30", Offset = "0xA5D730", VA = "0x180A5EB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<int, NHNJCELMFAL> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA70", Offset = "0xA5D670", VA = "0x180A5EA70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB70", Offset = "0xA5D770", VA = "0x180A5EB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x310E900", Offset = "0x310D500", VA = "0x18310E900", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8099580", Offset = "0x8098180", VA = "0x188099580", Slot = "14")]
		public void PLHNEJELPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x808D3A0", Offset = "0x808BFA0", VA = "0x18808D3A0", Slot = "15")]
		public void DJBBIIKCKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x808D430", Offset = "0x808C030", VA = "0x18808D430")]
		private void LDAEMNDGDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x809B9D0", Offset = "0x809A5D0", VA = "0x18809B9D0")]
		public static void JFKHKMLEJKI(BFNOLIBMLPJ writer, KMJOEPGFAJK property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8099590", Offset = "0x8098190", VA = "0x188099590")]
		public static void FJAMDLBDEAO(FHMLHEKMFLO reader, KMJOEPGFAJK property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x809B9F0", Offset = "0x809A5F0", VA = "0x18809B9F0")]
		private static void PAGAGFNIEHE(BFNOLIBMLPJ writer, KMJOEPGFAJK property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80995B0", Offset = "0x80981B0", VA = "0x1880995B0")]
		private static void FJODMMCAKKO(FHMLHEKMFLO reader, KMJOEPGFAJK property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF730", Offset = "0x3DEE330", VA = "0x183DEF730")]
		internal static void PBHGMJKEMBG<T>(BFNOLIBMLPJ writer, ONEJOBGIIJE<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF370", Offset = "0x3DEDF70", VA = "0x183DEF370")]
		internal static void GLDNKJDIMCO<T>(FHMLHEKMFLO reader, ONEJOBGIIJE<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF9C0", Offset = "0x3DEE5C0", VA = "0x183DEF9C0")]
		internal static void PBHGMJKEMBG<T>(BFNOLIBMLPJ writer, ONEJOBGIIJE<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF590", Offset = "0x3DEE190", VA = "0x183DEF590")]
		internal static void GLDNKJDIMCO<T>(FHMLHEKMFLO reader, ONEJOBGIIJE<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF7E0", Offset = "0x3DEE3E0", VA = "0x183DEF7E0")]
		internal static void PBHGMJKEMBG<T>(BFNOLIBMLPJ writer, ONEJOBGIIJE<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF450", Offset = "0x3DEE050", VA = "0x183DEF450")]
		internal static void GLDNKJDIMCO<T>(FHMLHEKMFLO reader, ONEJOBGIIJE<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x809D950", Offset = "0x809C550", VA = "0x18809D950")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x809B640", Offset = "0x809A240", VA = "0x18809B640")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x809D8B0", Offset = "0x809C4B0", VA = "0x18809D8B0")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x809B330", Offset = "0x8099F30", VA = "0x18809B330")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<byte> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x809D850", Offset = "0x809C450", VA = "0x18809D850")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x809B450", Offset = "0x809A050", VA = "0x18809B450")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x809DA30", Offset = "0x809C630", VA = "0x18809DA30")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x809B4B0", Offset = "0x809A0B0", VA = "0x18809B4B0")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x809DDC0", Offset = "0x809C9C0", VA = "0x18809DDC0")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x809B860", Offset = "0x809A460", VA = "0x18809B860")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x809DC50", Offset = "0x809C850", VA = "0x18809DC50")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x809B970", Offset = "0x809A570", VA = "0x18809B970")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<ulong> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x809DB00", Offset = "0x809C700", VA = "0x18809DB00")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x809B3A0", Offset = "0x8099FA0", VA = "0x18809B3A0")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x809D9C0", Offset = "0x809C5C0", VA = "0x18809D9C0")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x809B8C0", Offset = "0x809A4C0", VA = "0x18809B8C0")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x809DA90", Offset = "0x809C690", VA = "0x18809DA90")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x809B280", Offset = "0x8099E80", VA = "0x18809B280")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x809DBE0", Offset = "0x809C7E0", VA = "0x18809DBE0")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x809B6F0", Offset = "0x809A2F0", VA = "0x18809B6F0")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF8A0", Offset = "0x3DEE4A0", VA = "0x183DEF8A0")]
		internal static void PBHGMJKEMBG<T>(BFNOLIBMLPJ writer, ONEJOBGIIJE<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF4C0", Offset = "0x3DEE0C0", VA = "0x183DEF4C0")]
		internal static void GLDNKJDIMCO<T>(FHMLHEKMFLO reader, ONEJOBGIIJE<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x809D740", Offset = "0x809C340", VA = "0x18809D740")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x809B510", Offset = "0x809A110", VA = "0x18809B510")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x809DCB0", Offset = "0x809C8B0", VA = "0x18809DCB0")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x809B7A0", Offset = "0x809A3A0", VA = "0x18809B7A0")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x809DB70", Offset = "0x809C770", VA = "0x18809DB70")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<EJDHJMPEDMM> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x809B5D0", Offset = "0x809A1D0", VA = "0x18809B5D0")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<EJDHJMPEDMM> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x807DC90", Offset = "0x807C890", VA = "0x18807DC90")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, ONEJOBGIIJE<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x807D830", Offset = "0x807C430", VA = "0x18807D830")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, ONEJOBGIIJE<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x807DC90", Offset = "0x807C890", VA = "0x18807DC90")]
		internal static void PBHGMJKEMBG(BFNOLIBMLPJ writer, KMJOEPGFAJK prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x807D830", Offset = "0x807C430", VA = "0x18807D830")]
		internal static void GLDNKJDIMCO(FHMLHEKMFLO reader, KMJOEPGFAJK prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF600", Offset = "0x3DEE200", VA = "0x183DEF600")]
		internal static T MANIDGEBNFN<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x809F3E0", Offset = "0x809DFE0", VA = "0x18809F3E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x809F410", Offset = "0x809E010", VA = "0x18809F410")]
		public void AMHLLDBNIFP(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x809F420", Offset = "0x809E020", VA = "0x18809F420")]
		private void FFFJNGCPMKE(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4353470", Offset = "0x4352070", VA = "0x184353470")]
		private void GGNNFFCPBME<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4353100", Offset = "0x4351D00", VA = "0x184353100")]
		private void AOFFHCIIOHN<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x435D100", Offset = "0x435BD00", VA = "0x18435D100")]
		private void LEOMAADEKLH<T>(IComponentDefaultRegistration registry) where T : struct, IBufferElementData
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
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			UpgradeToRoomLevelShapes = 123,
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			UpgradedFromRuntimeToAuthored = 136,
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			UpgradeStudioObjectPolicyData = 138,
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			UpgradeStudioObjectPhysicsData = 145,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			UpgradeRemovePersistedPivots = 152,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			UpgradeDeformableScaleToAuthored = 153,
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			UpgradeConfigurableCollisionPhysicsData = 154,
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			UpgradeRRObjectPrefabDataToMatchPersistenceViewData = 162,
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			UpgradeFixDisassociatedAnimationData = 164
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x80A08E0", Offset = "0x809F4E0", VA = "0x1880A08E0")]
		public static bool OCJFFGDHPIH(this SerializedDataLayerVersionData version, TaggedVersions taggedVersion)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum IDAMMJLMAIN
{
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[TypeManager.ForcedStableTypeHash(13525807847946736151uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct PlayerIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
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
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private short last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	internal struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
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
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	internal struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
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
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterService(typeof(KFHMJFJDHKK), new string[] { "Registry" })]
internal class CNBJADFAACL : KFHMJFJDHKK
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Type FNKDEMNMJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x809EED0", Offset = "0x809DAD0", VA = "0x18809EED0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Type[] HPALPAPICMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x809EEC0", Offset = "0x809DAC0", VA = "0x18809EEC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyDictionary<Type, NDOKNDCGEEG> CAFHBKJNNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x809EF50", Offset = "0x809DB50", VA = "0x18809EF50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x809EF30", Offset = "0x809DB30", VA = "0x18809EF30", Slot = "7")]
	public void KBOPBHCANID(IComponentDefaultRegistration GBAPGBPIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CNBJADFAACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class LLJBEOBHIKF : ContainerPropertyBag<RRObjectPrefabData_v1>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class IFHHJPKGJGA : Property<RRObjectPrefabData_v1, ObjectPrefabType_v1>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x809F060", Offset = "0x809DC60", VA = "0x18809F060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x809EF70", Offset = "0x809DB70", VA = "0x18809EF70")]
		public IFHHJPKGJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2427140", Offset = "0x2425D40", VA = "0x182427140", Slot = "14")]
		public override ObjectPrefabType_v1 GetValue(RRObjectPrefabData_v1 EHEGCBFMKDA)
		{
			return default(ObjectPrefabType_v1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x809EF60", Offset = "0x809DB60", VA = "0x18809EF60", Slot = "15")]
		public override void SetValue(RRObjectPrefabData_v1 EHEGCBFMKDA, ObjectPrefabType_v1 BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x809F090", Offset = "0x809DC90", VA = "0x18809F090")]
	public LLJBEOBHIKF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x809F210", Offset = "0x809DE10", VA = "0x18809F210")]
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
