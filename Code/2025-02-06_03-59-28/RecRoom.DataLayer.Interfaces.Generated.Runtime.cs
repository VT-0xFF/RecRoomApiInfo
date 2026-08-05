using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71C0F80", Offset = "0x71BFD80", VA = "0x1871C0F80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7230C50", Offset = "0x722FA50", VA = "0x187230C50")]
		private void OGIEEDDHGBJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7230AE0", Offset = "0x722F8E0", VA = "0x187230AE0")]
		private void FEMILMKCAKN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7230DC0", Offset = "0x722FBC0", VA = "0x187230DC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72310F0", Offset = "0x722FEF0", VA = "0x1872310F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
	public struct SerializedDataLayerVersionData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Field(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerCollisionLayerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerCollisionLayerEnum_v1 collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerGrabbableModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public GrabbableMode_v1 grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(16456938112953419977uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ContainerFlagsData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerCollisionModeData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public CollisionMode_v1 collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v2 : IComponentData
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
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
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
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v5 : IComponentData
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
		[RecRoom.DataLayer.Field(4)]
		public CircuitsTransformBehavior_v1 circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KEJCGFMDGGO : IComparable<KEJCGFMDGGO>, IEquatable<KEJCGFMDGGO>
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly KEJCGFMDGGO EKNPGNFGBJM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KEJCGFMDGGO JFDAHOIGOOO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KEJCGFMDGGO KIGNMPAININ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KEJCGFMDGGO HJDJOCEKCFC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KEJCGFMDGGO LPBEMKCMBNF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KEJCGFMDGGO PFHJOIDBCGD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly int KNCPCNBMDNF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type MHDOPELBPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x721FE60", Offset = "0x721EC60", VA = "0x18721FE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NJLELLEMFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7220070", Offset = "0x721EE70", VA = "0x187220070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JCGPAOIEEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x721FA50", Offset = "0x721E850", VA = "0x18721FA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type EANJAELJCCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x721F680", Offset = "0x721E480", VA = "0x18721F680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BJEIMACAEHF HPDACJJKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x721FCB0", Offset = "0x721EAB0", VA = "0x18721FCB0")]
		get
		{
			return default(BJEIMACAEHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KNHJFOKIGEL DOAOOHGKPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x721F750", Offset = "0x721E550", VA = "0x18721F750")]
		get
		{
			return default(KNHJFOKIGEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HHAFNMMAGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x721FE10", Offset = "0x721EC10", VA = "0x18721FE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DJDKBKBKEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x721F630", Offset = "0x721E430", VA = "0x18721F630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FAKJIEHLGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x721FF30", Offset = "0x721ED30", VA = "0x18721FF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MNEBCFEOGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x721F910", Offset = "0x721E710", VA = "0x18721F910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
	public KEJCGFMDGGO(int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x721FC30", Offset = "0x721EA30", VA = "0x18721FC30", Slot = "5")]
	public bool Equals(KEJCGFMDGGO LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x721FB80", Offset = "0x721E980", VA = "0x18721FB80", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72201A0", Offset = "0x721EFA0", VA = "0x1872201A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2300", Offset = "0x4CB1100", VA = "0x184CB2300", Slot = "4")]
	public int CompareTo(KEJCGFMDGGO LHMPMCLNOPG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NCDLGKIFGAI<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly int KNCPCNBMDNF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private KEJCGFMDGGO OCOIBFFJGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390")]
		get
		{
			return default(KEJCGFMDGGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
	internal NCDLGKIFGAI(int KNCPCNBMDNF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0020", Offset = "0x1BEEE20", VA = "0x181BF0020")]
	public static KEJCGFMDGGO JCHCBNMNCNP(NCDLGKIFGAI<T> AMBDMECJFHI)
	{
		return default(KEJCGFMDGGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D22000", Offset = "0x4D20E00", VA = "0x184D22000", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D227D0", Offset = "0x4D215D0", VA = "0x184D227D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72134C0", Offset = "0x72122C0", VA = "0x1872134C0")]
		public static (long, string, string) EDBDPHDENKC(NJNFOMGPIJM value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7215200", Offset = "0x7214000", VA = "0x187215200")]
		public static (long, string, string)[] NOMOAACGOPO(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7221F10", Offset = "0x7220D10", VA = "0x187221F10")]
		public static Type[] OGMKEOAJEAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7220510", Offset = "0x721F310", VA = "0x187220510")]
		private static void EHDMJEMLBPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public enum GrabbableMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public enum GrabbableMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Bounds
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	public enum CircuitsTransformBehavior_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		NONE,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		CircuitsCanTransform,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		AlwaysStatic
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public enum PhysicsModelEnumFlags_v2 : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public enum CollisionMode_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public enum CollisionMode_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Hull
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v2
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public enum ContainerCollisionLayerEnum_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public enum CollisionLayerEnum_v2 : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		DECORATION = 101
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly NCDLGKIFGAI<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly NCDLGKIFGAI<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly NCDLGKIFGAI<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly NCDLGKIFGAI<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly NCDLGKIFGAI<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly NCDLGKIFGAI<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly NCDLGKIFGAI<GADINOAACEO> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly NCDLGKIFGAI<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly NCDLGKIFGAI<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly NCDLGKIFGAI<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly NCDLGKIFGAI<FixedList32Bytes<int>> InteractionFilterData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly NCDLGKIFGAI<bool> InteractionFilterData_enabled;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly NCDLGKIFGAI<GADINOAACEO> InteractionFilterData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly NCDLGKIFGAI<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly NCDLGKIFGAI<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly NCDLGKIFGAI<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly NCDLGKIFGAI<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public static readonly NCDLGKIFGAI<GENLDHLGIGG> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly NCDLGKIFGAI<GFAEAKCPAMB> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly NCDLGKIFGAI<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly NCDLGKIFGAI<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly NCDLGKIFGAI<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly NCDLGKIFGAI<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly NCDLGKIFGAI<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly NCDLGKIFGAI<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly NCDLGKIFGAI<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly NCDLGKIFGAI<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly NCDLGKIFGAI<EJHKEGBCNDE> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly NCDLGKIFGAI<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly NCDLGKIFGAI<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly NCDLGKIFGAI<AOIDDNEDMCD> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly NCDLGKIFGAI<LOEIMIFIJEN> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly NCDLGKIFGAI<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly NCDLGKIFGAI<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly NCDLGKIFGAI<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly NCDLGKIFGAI<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly NCDLGKIFGAI<LocalId> EntityBundlePartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly NCDLGKIFGAI<uint> EntityBundlePartData_entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly NCDLGKIFGAI<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly NCDLGKIFGAI<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly NCDLGKIFGAI<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly NCDLGKIFGAI<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly NCDLGKIFGAI<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly NCDLGKIFGAI<MDOGAOLHEIJ> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly NCDLGKIFGAI<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly NCDLGKIFGAI<GEJEIADHCHJ> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly NCDLGKIFGAI<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly NCDLGKIFGAI<int> ReplicatorMaxObjectCountData_MaxCopies;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly NCDLGKIFGAI<float> PhysicsModelMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly NCDLGKIFGAI<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly NCDLGKIFGAI<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly NCDLGKIFGAI<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public static readonly NCDLGKIFGAI<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly NCDLGKIFGAI<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static readonly NCDLGKIFGAI<BHMDPIOBIIO> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly NCDLGKIFGAI<CMKDMKNLIMB> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly NCDLGKIFGAI<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly NCDLGKIFGAI<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static readonly NCDLGKIFGAI<GLDFCNIMNAN> PhysicsModelCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static readonly NCDLGKIFGAI<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly NCDLGKIFGAI<GFAEAKCPAMB> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly NCDLGKIFGAI<FKEFFIMPMDP> PhysicsModelGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly NCDLGKIFGAI<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly NCDLGKIFGAI<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly NCDLGKIFGAI<KFOIBPICOAF> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static readonly NCDLGKIFGAI<PGEKODOPNON> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly NCDLGKIFGAI<NCDNJODNGAC> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly NCDLGKIFGAI<OFKIBJDIALG> PhysicsModelFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly NCDLGKIFGAI<JCNPJIGPNPG> PhysicsModelCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static readonly NCDLGKIFGAI<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly NCDLGKIFGAI<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly NCDLGKIFGAI<JJLMKIHFGND> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly NCDLGKIFGAI<DEHCHGHMLNK> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly NCDLGKIFGAI<FJJIGCEJIMM> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly NCDLGKIFGAI<GIJJLHMDBAJ> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly NCDLGKIFGAI<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly NCDLGKIFGAI<PMJLGJGNALL> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ServiceLifetime(Lifetime.Application)]
	[RegisterService(typeof(HNPAIHMCMOP), new string[] { "Registry", "Ignore" })]
	[CompilerGenerated]
	internal class NetworkPropertyRegistry : HNPAIHMCMOP, KFABIMDLPKI, EJBGNPMNAED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB21E50", Offset = "0xB20C50", VA = "0x180B21E50", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBE3510", Offset = "0xBE2310", VA = "0x180BE3510", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC8EF40", Offset = "0xC8DD40", VA = "0x180C8EF40", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD67490", Offset = "0xD66290", VA = "0x180D67490", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4250", Offset = "0x8F3050", VA = "0x1808F4250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8F4260", Offset = "0x8F3060", VA = "0x1808F4260", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8F4470", Offset = "0x8F3270", VA = "0x1808F4470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public BJEIMACAEHF[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8FBB10", Offset = "0x8FA910", VA = "0x1808FBB10", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8FBB20", Offset = "0x8FA920", VA = "0x1808FBB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, KNHJFOKIGEL> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8F4220", Offset = "0x8F3020", VA = "0x1808F4220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x722C010", Offset = "0x722AE10", VA = "0x18722C010", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x722C090", Offset = "0x722AE90", VA = "0x18722C090", Slot = "13")]
		public void PPAGFJBKAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x722C030", Offset = "0x722AE30", VA = "0x18722C030", Slot = "14")]
		public void OAKNFNBDPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7222810", Offset = "0x7221610", VA = "0x187222810")]
		private void HEHAHOFPDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x722D570", Offset = "0x722C370", VA = "0x18722D570")]
		public static void DIBNJLPFICJ(BDMDNLCBKLB writer, KEJCGFMDGGO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x722DC10", Offset = "0x722CA10", VA = "0x18722DC10")]
		public static void MINCPNNFPCI(HKGEPFPBNIF reader, KEJCGFMDGGO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x722E210", Offset = "0x722D010", VA = "0x18722E210")]
		private static void OBFOIAIDFNM(BDMDNLCBKLB writer, KEJCGFMDGGO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x722C0A0", Offset = "0x722AEA0", VA = "0x18722C0A0")]
		private static void DFLNANLIODC(HKGEPFPBNIF reader, KEJCGFMDGGO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x347CD10", Offset = "0x347BB10", VA = "0x18347CD10")]
		internal static void NPIKEPIONAB<T>(BDMDNLCBKLB writer, NCDLGKIFGAI<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x347C960", Offset = "0x347B760", VA = "0x18347C960")]
		internal static void FEIAPADJKML<T>(HKGEPFPBNIF reader, NCDLGKIFGAI<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x347D060", Offset = "0x347BE60", VA = "0x18347D060")]
		internal static void NPIKEPIONAB<T>(BDMDNLCBKLB writer, NCDLGKIFGAI<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x347CC20", Offset = "0x347BA20", VA = "0x18347CC20")]
		internal static void FEIAPADJKML<T>(HKGEPFPBNIF reader, NCDLGKIFGAI<T> prop, NativeArray<byte> data, ushort min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x347CE30", Offset = "0x347BC30", VA = "0x18347CE30")]
		internal static void NPIKEPIONAB<T>(BDMDNLCBKLB writer, NCDLGKIFGAI<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x347CA50", Offset = "0x347B850", VA = "0x18347CA50")]
		internal static void FEIAPADJKML<T>(HKGEPFPBNIF reader, NCDLGKIFGAI<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x722DC30", Offset = "0x722CA30", VA = "0x18722DC30")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x722D710", Offset = "0x722C510", VA = "0x18722D710")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x722E1B0", Offset = "0x722CFB0", VA = "0x18722E1B0")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x722D590", Offset = "0x722C390", VA = "0x18722D590")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x722DCA0", Offset = "0x722CAA0", VA = "0x18722DCA0")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x722D930", Offset = "0x722C730", VA = "0x18722D930")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x722E150", Offset = "0x722CF50", VA = "0x18722E150")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x722DA40", Offset = "0x722C840", VA = "0x18722DA40")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x722DD70", Offset = "0x722CB70", VA = "0x18722DD70")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x722D5F0", Offset = "0x722C3F0", VA = "0x18722D5F0")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x722DD00", Offset = "0x722CB00", VA = "0x18722DD00")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x722D7C0", Offset = "0x722C5C0", VA = "0x18722D7C0")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x722DEF0", Offset = "0x722CCF0", VA = "0x18722DEF0")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x722DB60", Offset = "0x722C960", VA = "0x18722DB60")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x722DF60", Offset = "0x722CD60", VA = "0x18722DF60")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x722D990", Offset = "0x722C790", VA = "0x18722D990")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x347CF10", Offset = "0x347BD10", VA = "0x18347CF10")]
		internal static void NPIKEPIONAB<T>(BDMDNLCBKLB writer, NCDLGKIFGAI<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x347CB30", Offset = "0x347B930", VA = "0x18347CB30")]
		internal static void FEIAPADJKML<T>(HKGEPFPBNIF reader, NCDLGKIFGAI<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x722E040", Offset = "0x722CE40", VA = "0x18722E040")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x722D870", Offset = "0x722C670", VA = "0x18722D870")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x722DDE0", Offset = "0x722CBE0", VA = "0x18722DDE0")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x722DAA0", Offset = "0x722C8A0", VA = "0x18722DAA0")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x722DFD0", Offset = "0x722CDD0", VA = "0x18722DFD0")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<GFAEAKCPAMB> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x722D6A0", Offset = "0x722C4A0", VA = "0x18722D6A0")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<GFAEAKCPAMB> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x72133E0", Offset = "0x72121E0", VA = "0x1872133E0")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, NCDLGKIFGAI<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7212FF0", Offset = "0x7211DF0", VA = "0x187212FF0")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, NCDLGKIFGAI<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x72133E0", Offset = "0x72121E0", VA = "0x1872133E0")]
		internal static void NPIKEPIONAB(BDMDNLCBKLB writer, KEJCGFMDGGO prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7212FF0", Offset = "0x7211DF0", VA = "0x187212FF0")]
		internal static void FEIAPADJKML(HKGEPFPBNIF reader, KEJCGFMDGGO prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x347C8E0", Offset = "0x347B6E0", VA = "0x18347C8E0")]
		internal static T DGEMGLACBJI<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x722FA10", Offset = "0x722E810", VA = "0x18722FA10")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7230AD0", Offset = "0x722F8D0", VA = "0x187230AD0")]
		public void EHDMJEMLBPD(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x722FA40", Offset = "0x722E840", VA = "0x18722FA40")]
		private void CFFCKGCEHIH(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x39BD190", Offset = "0x39BBF90", VA = "0x1839BD190")]
		private void AMDNDEOLBMD<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly int GeneratedVersionNumber;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum FJDJEMIKNMC
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[RegisterService(typeof(BKFNOPFGOBL), new string[] { "Registry" })]
[ServiceLifetime(Lifetime.Application)]
internal class MMPECDEPJDI : BKFNOPFGOBL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type DLHNBDLNODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7231320", Offset = "0x7230120", VA = "0x187231320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] NIHOHEGPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7231380", Offset = "0x7230180", VA = "0x187231380", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7231390", Offset = "0x7230190", VA = "0x187231390", Slot = "6")]
	public void LENLOPICAHA(IComponentDefaultRegistration GOFKOIDBLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public MMPECDEPJDI()
	{
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
