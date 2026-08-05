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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
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
			[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E91CC0", Offset = "0x6E904C0", VA = "0x186E91CC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F00EC0", Offset = "0x6EFF6C0", VA = "0x186F00EC0")]
		private void HOKDCPPBEII(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F01030", Offset = "0x6EFF830", VA = "0x186F01030")]
		private void PMABBDBBCMA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F011A0", Offset = "0x6EFF9A0", VA = "0x186F011A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F014D0", Offset = "0x6EFFCD0", VA = "0x186F014D0")]
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
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[CompilerGenerated]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
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
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(1)]
		public ContainerEnumFlags_v1 flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
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
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(2)]
		public ScaleRestriction_v1 scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(3)]
		public ObjectPolicyUserConfigurableFlags_v1 userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[RecRoom.DataLayer.Field(1)]
		public ObjectPolicyEnumFlags_v1 flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JDHJHMOFOLO : IComparable<JDHJHMOFOLO>, IEquatable<JDHJHMOFOLO>
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly JDHJHMOFOLO EOIJNKLPKGL;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly JDHJHMOFOLO CODFAIKNJPP;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly JDHJHMOFOLO MFOBNJMNAEO;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly JDHJHMOFOLO ABPDPNHNEHF;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly JDHJHMOFOLO BABFDNDKDJI;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly JDHJHMOFOLO DPEOKNCHFBB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly int ECDOOAABOPD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type PKECFHLGJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFE00", Offset = "0x6EEE600", VA = "0x186EEFE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AEOBBNBHJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0560", Offset = "0x6EEED60", VA = "0x186EF0560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LJIEDMFFEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0040", Offset = "0x6EEE840", VA = "0x186EF0040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type AJGAKHNLCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0170", Offset = "0x6EEE970", VA = "0x186EF0170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GKCOIFFENLA CPPCKGJGMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0400", Offset = "0x6EEEC00", VA = "0x186EF0400")]
		get
		{
			return default(GKCOIFFENLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JBHCINFJFFJ HAHPFPDOGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0240", Offset = "0x6EEEA40", VA = "0x186EF0240")]
		get
		{
			return default(JBHCINFJFFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MCEJIPOMHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0910", Offset = "0x6EEF110", VA = "0x186EF0910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PIIGEPBLMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFFF0", Offset = "0x6EEE7F0", VA = "0x186EEFFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KNEDMJMGJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EF07D0", Offset = "0x6EEEFD0", VA = "0x186EF07D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BNHCOFIDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0690", Offset = "0x6EEEE90", VA = "0x186EF0690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
	public JDHJHMOFOLO(int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFF70", Offset = "0x6EEE770", VA = "0x186EEFF70", Slot = "5")]
	public bool Equals(JDHJHMOFOLO LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFED0", Offset = "0x6EEE6D0", VA = "0x186EEFED0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0960", Offset = "0x6EEF160", VA = "0x186EF0960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x49C6520", Offset = "0x49C4D20", VA = "0x1849C6520", Slot = "4")]
	public int CompareTo(JDHJHMOFOLO LIHCAHPMPHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KMPGFPGIIDL<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly int ECDOOAABOPD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JDHJHMOFOLO DJDIPGHGGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640")]
		get
		{
			return default(JDHJHMOFOLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
	internal KMPGFPGIIDL(int ECDOOAABOPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x181D930", Offset = "0x181C130", VA = "0x18181D930")]
	public static JDHJHMOFOLO FMEIMHFCNHG(KMPGFPGIIDL<T> MFCFAMOHGBK)
	{
		return default(JDHJHMOFOLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x466FB90", Offset = "0x466E390", VA = "0x18466FB90", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4670130", Offset = "0x466E930", VA = "0x184670130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3E20", Offset = "0x6EE2620", VA = "0x186EE3E20")]
		public static (long, string, string) ICGDHPCECGG(BKBMPOCGEPN value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3CE0", Offset = "0x6EE24E0", VA = "0x186EE3CE0")]
		public static (long, string, string)[] DPJILKIFHBH(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2620", Offset = "0x6EF0E20", VA = "0x186EF2620")]
		public static Type[] KGOIHOCDMPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0CD0", Offset = "0x6EEF4D0", VA = "0x186EF0CD0")]
		private static void CCEDGNHHKOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public enum ContainerEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		CollisionEvent = 64,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		CanUse = 512,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		CanClimb = 1024,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		CanWallRun = 2048,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		CanClamber = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		CanTeleport = 8192,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		DEFAULT = 14336,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		ALL = 15943
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	public enum ObjectPolicyEnumFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		All = 16383,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Default = 16383
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public enum ObjectPolicyUserConfigurableFlags_v1
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		DEFAULT = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly KMPGFPGIIDL<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly KMPGFPGIIDL<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly KMPGFPGIIDL<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly KMPGFPGIIDL<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly KMPGFPGIIDL<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly KMPGFPGIIDL<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly KMPGFPGIIDL<CBDFFPLOJIF> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly KMPGFPGIIDL<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly KMPGFPGIIDL<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly KMPGFPGIIDL<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly KMPGFPGIIDL<FixedList32Bytes<int>> InteractionFilterData_tags;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly KMPGFPGIIDL<bool> InteractionFilterData_enabled;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly KMPGFPGIIDL<CBDFFPLOJIF> InteractionFilterData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly KMPGFPGIIDL<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly KMPGFPGIIDL<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly KMPGFPGIIDL<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly KMPGFPGIIDL<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly KMPGFPGIIDL<HCMCHHADEDD> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly KMPGFPGIIDL<IPENIDGIMGH> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly KMPGFPGIIDL<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static readonly KMPGFPGIIDL<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly KMPGFPGIIDL<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly KMPGFPGIIDL<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly KMPGFPGIIDL<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly KMPGFPGIIDL<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly KMPGFPGIIDL<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly KMPGFPGIIDL<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public static readonly KMPGFPGIIDL<HDELFCEBOJG> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public static readonly KMPGFPGIIDL<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly KMPGFPGIIDL<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly KMPGFPGIIDL<EIHHNGMFHPM> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly KMPGFPGIIDL<KCDIPBECKHL> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly KMPGFPGIIDL<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly KMPGFPGIIDL<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly KMPGFPGIIDL<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly KMPGFPGIIDL<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly KMPGFPGIIDL<LocalId> EntityBundlePartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly KMPGFPGIIDL<uint> EntityBundlePartData_entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly KMPGFPGIIDL<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static readonly KMPGFPGIIDL<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly KMPGFPGIIDL<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly KMPGFPGIIDL<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly KMPGFPGIIDL<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly KMPGFPGIIDL<ECFHGLELIKG> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly KMPGFPGIIDL<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly KMPGFPGIIDL<JIKEHJJLJAI> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly KMPGFPGIIDL<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly KMPGFPGIIDL<int> ReplicatorMaxObjectCountData_MaxCopies;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly KMPGFPGIIDL<float> ContainerMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly KMPGFPGIIDL<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly KMPGFPGIIDL<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly KMPGFPGIIDL<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly KMPGFPGIIDL<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly KMPGFPGIIDL<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly KMPGFPGIIDL<KDFAPGKOLBP> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly KMPGFPGIIDL<KIHOFADNKAM> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly KMPGFPGIIDL<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly KMPGFPGIIDL<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly KMPGFPGIIDL<ELBAPEAMABC> ContainerCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly KMPGFPGIIDL<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly KMPGFPGIIDL<IPENIDGIMGH> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly KMPGFPGIIDL<GCMPNPKCMPJ> ContainerGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly KMPGFPGIIDL<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly KMPGFPGIIDL<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly KMPGFPGIIDL<GMIJGAFIAIM> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly KMPGFPGIIDL<NAFHBIPMJAN> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly KMPGFPGIIDL<JGAHKEGNBLD> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly KMPGFPGIIDL<IBNNJJAFPLG> ContainerFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly KMPGFPGIIDL<HHJBDBCFGBD> ContainerCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly KMPGFPGIIDL<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly KMPGFPGIIDL<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly KMPGFPGIIDL<ACDEAJEGJGA> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly KMPGFPGIIDL<CDEPPFIGPHB> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly KMPGFPGIIDL<INHFPBMEMPN> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly KMPGFPGIIDL<BGFOHDELAHM> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly KMPGFPGIIDL<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly KMPGFPGIIDL<JBOELMKONKK> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[RegisterService(typeof(EMGCMGMLIKO), new string[] { "Registry", "Ignore" })]
	[ServiceLifetime(Lifetime.Application)]
	internal class NetworkPropertyRegistry : EMGCMGMLIKO, FEOKNGHFANM, GOCAFABHBEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD30", Offset = "0xB2C530", VA = "0x180B2DD30", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x95B920", Offset = "0x95A120", VA = "0x18095B920", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9DC820", Offset = "0x9DB020", VA = "0x1809DC820", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAE8690", Offset = "0xAE6E90", VA = "0x180AE8690", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8B7510", Offset = "0x8B5D10", VA = "0x1808B7510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B7520", Offset = "0x8B5D20", VA = "0x1808B7520", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8B7570", Offset = "0x8B5D70", VA = "0x1808B7570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public GKCOIFFENLA[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7560", Offset = "0x8B5D60", VA = "0x1808B7560", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8B7550", Offset = "0x8B5D50", VA = "0x1808B7550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, JBHCINFJFFJ> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5D30", VA = "0x1808B7530", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8B74F0", Offset = "0x8B5CF0", VA = "0x1808B74F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EFC5B0", Offset = "0x6EFADB0", VA = "0x186EFC5B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC5D0", Offset = "0x6EFADD0", VA = "0x186EFC5D0", Slot = "13")]
		public void PFAOPLPHMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC550", Offset = "0x6EFAD50", VA = "0x186EFC550", Slot = "14")]
		public void DECDNNFOBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2F20", Offset = "0x6EF1720", VA = "0x186EF2F20")]
		private void CKCJIKHJBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC5E0", Offset = "0x6EFADE0", VA = "0x186EFC5E0")]
		public static void IOMCBFJAHHL(EENACIKAIOK writer, JDHJHMOFOLO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEA60", Offset = "0x6EFD260", VA = "0x186EFEA60")]
		public static void NPOIALNDBEP(DIEDANHAAGG reader, JDHJHMOFOLO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD260", Offset = "0x6EFBA60", VA = "0x186EFD260")]
		private static void MLKDGKOLLPK(EENACIKAIOK writer, JDHJHMOFOLO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEA80", Offset = "0x6EFD280", VA = "0x186EFEA80")]
		private static void OJEKFBDPKLA(DIEDANHAAGG reader, JDHJHMOFOLO property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x31F09B0", Offset = "0x31EF1B0", VA = "0x1831F09B0")]
		internal static void KBGBIJFEDIC<T>(EENACIKAIOK writer, KMPGFPGIIDL<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x31F0D00", Offset = "0x31EF500", VA = "0x1831F0D00")]
		internal static void KDFBDMHOPOO<T>(DIEDANHAAGG reader, KMPGFPGIIDL<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x31F0AD0", Offset = "0x31EF2D0", VA = "0x1831F0AD0")]
		internal static void KBGBIJFEDIC<T>(EENACIKAIOK writer, KMPGFPGIIDL<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x31F0DF0", Offset = "0x31EF5F0", VA = "0x1831F0DF0")]
		internal static void KDFBDMHOPOO<T>(DIEDANHAAGG reader, KMPGFPGIIDL<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC6D0", Offset = "0x6EFAED0", VA = "0x186EFC6D0")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCD50", Offset = "0x6EFB550", VA = "0x186EFCD50")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC670", Offset = "0x6EFAE70", VA = "0x186EFC670")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCE00", Offset = "0x6EFB600", VA = "0x186EFCE00")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC7B0", Offset = "0x6EFAFB0", VA = "0x186EFC7B0")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCFE0", Offset = "0x6EFB7E0", VA = "0x186EFCFE0")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCB80", Offset = "0x6EFB380", VA = "0x186EFCB80")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCF10", Offset = "0x6EFB710", VA = "0x186EFCF10")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC600", Offset = "0x6EFAE00", VA = "0x186EFC600")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD0F0", Offset = "0x6EFB8F0", VA = "0x186EFD0F0")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC740", Offset = "0x6EFAF40", VA = "0x186EFC740")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCBE0", Offset = "0x6EFB3E0", VA = "0x186EFCBE0")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC810", Offset = "0x6EFB010", VA = "0x186EFC810")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD040", Offset = "0x6EFB840", VA = "0x186EFD040")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCAA0", Offset = "0x6EFB2A0", VA = "0x186EFCAA0")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCE60", Offset = "0x6EFB660", VA = "0x186EFCE60")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x31F0BB0", Offset = "0x31EF3B0", VA = "0x1831F0BB0")]
		internal static void KBGBIJFEDIC<T>(EENACIKAIOK writer, KMPGFPGIIDL<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x31F0ED0", Offset = "0x31EF6D0", VA = "0x1831F0ED0")]
		internal static void KDFBDMHOPOO<T>(DIEDANHAAGG reader, KMPGFPGIIDL<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC880", Offset = "0x6EFB080", VA = "0x186EFC880")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD1A0", Offset = "0x6EFB9A0", VA = "0x186EFD1A0")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC990", Offset = "0x6EFB190", VA = "0x186EFC990")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCC90", Offset = "0x6EFB490", VA = "0x186EFCC90")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCB10", Offset = "0x6EFB310", VA = "0x186EFCB10")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<IPENIDGIMGH> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCF70", Offset = "0x6EFB770", VA = "0x186EFCF70")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<IPENIDGIMGH> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3810", Offset = "0x6EE2010", VA = "0x186EE3810")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, KMPGFPGIIDL<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3B00", Offset = "0x6EE2300", VA = "0x186EE3B00")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, KMPGFPGIIDL<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3810", Offset = "0x6EE2010", VA = "0x186EE3810")]
		internal static void KBGBIJFEDIC(EENACIKAIOK writer, JDHJHMOFOLO prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3B00", Offset = "0x6EE2300", VA = "0x186EE3B00")]
		internal static void KDFBDMHOPOO(DIEDANHAAGG reader, JDHJHMOFOLO prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x31F0FC0", Offset = "0x31EF7C0", VA = "0x1831F0FC0")]
		internal static T OPDEEOLNLFK<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public struct ScaleRestriction_v1
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFF40", Offset = "0x6EFE740", VA = "0x186EFFF40")]
		public ScaleRestriction_v1(float min, float max)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFF70", Offset = "0x6EFE770", VA = "0x186EFFF70")]
		public void CCEDGNHHKOL(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFF80", Offset = "0x6EFE780", VA = "0x186EFFF80")]
		private void PKAOGDCMFAM(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x36EE3E0", Offset = "0x36ECBE0", VA = "0x1836EE3E0")]
		private void ODMFBLJHIBC<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public static class VersionedTypesMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly int GeneratedVersionNumber;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EPLBNLAHOJM
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[CompilerGenerated]
	[Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[Preserve]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[RegisterService(typeof(LHJFBGDGNJO), new string[] { "Registry" })]
[ServiceLifetime(Lifetime.Application)]
internal class CGFGAKLEDFC : LHJFBGDGNJO
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type FKCLJHMDBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F01700", Offset = "0x6EFFF00", VA = "0x186F01700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] HKLBJEAMNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F01780", Offset = "0x6EFFF80", VA = "0x186F01780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F01760", Offset = "0x6EFFF60", VA = "0x186F01760", Slot = "6")]
	public void KHHBGMCLCAL(IComponentDefaultRegistration IJDFIPGGMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CGFGAKLEDFC()
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
