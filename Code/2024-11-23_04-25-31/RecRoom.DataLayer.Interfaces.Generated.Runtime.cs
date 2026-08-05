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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D36420", Offset = "0x6D34E20", VA = "0x186D36420", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8B20", Offset = "0x6DA7520", VA = "0x186DA8B20")]
		private void ACOMFCOBJKA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8C90", Offset = "0x6DA7690", VA = "0x186DA8C90")]
		private void MODGDFGCADD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8E00", Offset = "0x6DA7800", VA = "0x186DA8E00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9140", Offset = "0x6DA7B40", VA = "0x186DA9140")]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(1)]
		public OKCENOEKMFE flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(1)]
		public KIOBFOCEJLD flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(2)]
		public OCJHPGBEEJI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public KIOBFOCEJLD flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(2)]
		public OCJHPGBEEJI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public KIOBFOCEJLD flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(2)]
		public OCJHPGBEEJI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(3)]
		public KKJLAJPGCHJ userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.TypeVersion(2)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(2)]
		public OCJHPGBEEJI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(3)]
		public KKJLAJPGCHJ userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(1)]
		public KIOBFOCEJLD flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HAANENPBPKN : IComparable<HAANENPBPKN>, IEquatable<HAANENPBPKN>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly HAANENPBPKN OMNMEECEPCK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly HAANENPBPKN HFLMHKEJJOF;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly HAANENPBPKN AJAPJIJDAKA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly HAANENPBPKN PKNCHFBLHLC;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly HAANENPBPKN MENCGFLKIIB;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly HAANENPBPKN GAHCJKADPMG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int GCBONJOGHCD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BPKEJBPHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type HMBPCDHFAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D981E0", Offset = "0x6D96BE0", VA = "0x186D981E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FOEJOECEJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D98640", Offset = "0x6D97040", VA = "0x186D98640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HOGPONPHGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D983F0", Offset = "0x6D96DF0", VA = "0x186D983F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type AABBOIBJFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D98520", Offset = "0x6D96F20", VA = "0x186D98520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public APCFLLDKBMG DPJHLHNMGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D97DD0", Offset = "0x6D967D0", VA = "0x186D97DD0")]
		get
		{
			return default(APCFLLDKBMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MGLFAJFGBNN MBGGMBCHHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D97C00", Offset = "0x6D96600", VA = "0x186D97C00")]
		get
		{
			return default(MGLFAJFGBNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KDOCKDFMKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D985F0", Offset = "0x6D96FF0", VA = "0x186D985F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OPOHACAEIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D98070", Offset = "0x6D96A70", VA = "0x186D98070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CPBKKDKFOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D982B0", Offset = "0x6D96CB0", VA = "0x186D982B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KCDKEIJAJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D97F30", Offset = "0x6D96930", VA = "0x186D97F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70")]
	public HAANENPBPKN(int GCBONJOGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D980C0", Offset = "0x6D96AC0", VA = "0x186D980C0", Slot = "5")]
	public bool Equals(HAANENPBPKN GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D98140", Offset = "0x6D96B40", VA = "0x186D98140", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D98770", Offset = "0x6D97170", VA = "0x186D98770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4956320", Offset = "0x4954D20", VA = "0x184956320", Slot = "4")]
	public int CompareTo(HAANENPBPKN GDOGPMPJPOO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MEPBHNPODPL<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly int GCBONJOGHCD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private HAANENPBPKN HENAOOHCJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700")]
		get
		{
			return default(HAANENPBPKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70")]
	internal MEPBHNPODPL(int GCBONJOGHCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1721280", Offset = "0x171FC80", VA = "0x181721280")]
	public static HAANENPBPKN OLKJPEKNNFN(MEPBHNPODPL<T> JKKOEFMEAMD)
	{
		return default(HAANENPBPKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x48AD280", Offset = "0x48ABC80", VA = "0x1848AD280", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x48AD920", Offset = "0x48AC320", VA = "0x1848AD920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BB80", Offset = "0x6D8A580", VA = "0x186D8BB80")]
		public static (long, string, string) MLBODOLLEAD(EBLEEPKFPFE value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BA40", Offset = "0x6D8A440", VA = "0x186D8BA40")]
		public static (long, string, string)[] JGBOEFLILEG(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D98AC0", Offset = "0x6D974C0", VA = "0x186D98AC0")]
		public static Type[] JBCFINPADOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D98B10", Offset = "0x6D97510", VA = "0x186D98B10")]
		private static void KFMGLABNFNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly MEPBHNPODPL<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly MEPBHNPODPL<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly MEPBHNPODPL<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly MEPBHNPODPL<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly MEPBHNPODPL<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly MEPBHNPODPL<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly MEPBHNPODPL<HAMKDOGKBNB> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly MEPBHNPODPL<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly MEPBHNPODPL<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly MEPBHNPODPL<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly MEPBHNPODPL<FixedList32Bytes<int>> InteractionFilterData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly MEPBHNPODPL<bool> InteractionFilterData_enabled;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly MEPBHNPODPL<HAMKDOGKBNB> InteractionFilterData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly MEPBHNPODPL<BNIKIPLFCPF> ComponentSerializedVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly MEPBHNPODPL<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly MEPBHNPODPL<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly MEPBHNPODPL<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly MEPBHNPODPL<CKKGOMGJLIJ> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly MEPBHNPODPL<FNBNHJHANON> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly MEPBHNPODPL<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MEPBHNPODPL<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly MEPBHNPODPL<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly MEPBHNPODPL<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly MEPBHNPODPL<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly MEPBHNPODPL<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly MEPBHNPODPL<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly MEPBHNPODPL<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly MEPBHNPODPL<KALIECFDEAG> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly MEPBHNPODPL<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly MEPBHNPODPL<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly MEPBHNPODPL<IJFMPACLLKE> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly MEPBHNPODPL<JKLBMPOHFIB> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly MEPBHNPODPL<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly MEPBHNPODPL<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly MEPBHNPODPL<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly MEPBHNPODPL<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly MEPBHNPODPL<LocalId> EntityBundlePartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly MEPBHNPODPL<uint> EntityBundlePartData_entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly MEPBHNPODPL<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly MEPBHNPODPL<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly MEPBHNPODPL<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly MEPBHNPODPL<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly MEPBHNPODPL<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly MEPBHNPODPL<OPJANFKCKPN> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static readonly MEPBHNPODPL<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly MEPBHNPODPL<DMGCPCFOJCI> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly MEPBHNPODPL<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly MEPBHNPODPL<int> ReplicatorMaxObjectCountData_MaxCopies;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly MEPBHNPODPL<float> ContainerMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly MEPBHNPODPL<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly MEPBHNPODPL<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public static readonly MEPBHNPODPL<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public static readonly MEPBHNPODPL<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly MEPBHNPODPL<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly MEPBHNPODPL<DJGJAENKNLL> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly MEPBHNPODPL<KPLMDLGKHKB> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly MEPBHNPODPL<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly MEPBHNPODPL<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly MEPBHNPODPL<GCIMJGEIOFH> ContainerCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly MEPBHNPODPL<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly MEPBHNPODPL<FNBNHJHANON> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly MEPBHNPODPL<DAOGJJNEHNF> ContainerGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly MEPBHNPODPL<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static readonly MEPBHNPODPL<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly MEPBHNPODPL<JFNNGCLCPMM> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly MEPBHNPODPL<ODAGACHMJEL> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly MEPBHNPODPL<JJFMCBALIKM> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly MEPBHNPODPL<OKCENOEKMFE> ContainerFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly MEPBHNPODPL<HBMCGPPNEEC> ContainerCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly MEPBHNPODPL<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly MEPBHNPODPL<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly MEPBHNPODPL<OCJHPGBEEJI> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly MEPBHNPODPL<KKJLAJPGCHJ> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly MEPBHNPODPL<AEELCLEFBNG> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly MEPBHNPODPL<KIOBFOCEJLD> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly MEPBHNPODPL<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly MEPBHNPODPL<GABGNEGOHJK> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[ServiceLifetime(Lifetime.Application)]
	[RegisterService(typeof(GCCMILHOOBP), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : GCCMILHOOBP, KDLDFFJCNLH, CGBLBMCHGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAEA840", Offset = "0xAE9240", VA = "0x180AEA840", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9C84B0", Offset = "0x9C6EB0", VA = "0x1809C84B0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x982A20", Offset = "0x981420", VA = "0x180982A20", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA895C0", Offset = "0xA87FC0", VA = "0x180A895C0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1E0", Offset = "0x8A9BE0", VA = "0x1808AB1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1B0", Offset = "0x8A9BB0", VA = "0x1808AB1B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8AB240", Offset = "0x8A9C40", VA = "0x1808AB240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public APCFLLDKBMG[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8AB230", Offset = "0x8A9C30", VA = "0x1808AB230", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8AB200", Offset = "0x8A9C00", VA = "0x1808AB200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, MGLFAJFGBNN> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1C0", Offset = "0x8A9BC0", VA = "0x1808AB1C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8AB210", Offset = "0x8A9C10", VA = "0x1808AB210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D9AC10", Offset = "0x6D99610", VA = "0x186D9AC10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6DA42E0", Offset = "0x6DA2CE0", VA = "0x186DA42E0", Slot = "13")]
		public void MKDJAFPGKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AC30", Offset = "0x6D99630", VA = "0x186D9AC30", Slot = "14")]
		public void ENOAJELNKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AC90", Offset = "0x6D99690", VA = "0x186D9AC90")]
		private void IBFHIHLFDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5780", Offset = "0x6DA4180", VA = "0x186DA5780")]
		public static void BFJPIIHIOHF(JLJAFHKKPFG writer, HAANENPBPKN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DA6F40", Offset = "0x6DA5940", VA = "0x186DA6F40")]
		public static void DFIMOJPFECF(IEKGOFPMJLE reader, HAANENPBPKN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA57A0", Offset = "0x6DA41A0", VA = "0x186DA57A0")]
		private static void CLPJLAPECPA(JLJAFHKKPFG writer, HAANENPBPKN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA42F0", Offset = "0x6DA2CF0", VA = "0x186DA42F0")]
		private static void AJAHMBBLIKE(IEKGOFPMJLE reader, HAANENPBPKN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x306F820", Offset = "0x306E220", VA = "0x18306F820")]
		internal static void HLGBFIEHJDG<T>(JLJAFHKKPFG writer, MEPBHNPODPL<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x306F400", Offset = "0x306DE00", VA = "0x18306F400")]
		internal static void DLDAMIHNNNK<T>(IEKGOFPMJLE reader, MEPBHNPODPL<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x306F940", Offset = "0x306E340", VA = "0x18306F940")]
		internal static void HLGBFIEHJDG<T>(JLJAFHKKPFG writer, MEPBHNPODPL<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x306F4F0", Offset = "0x306DEF0", VA = "0x18306F4F0")]
		internal static void DLDAMIHNNNK<T>(IEKGOFPMJLE reader, MEPBHNPODPL<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x306FB70", Offset = "0x306E570", VA = "0x18306FB70")]
		internal static void HLGBFIEHJDG<T>(JLJAFHKKPFG writer, MEPBHNPODPL<T> prop, NativeArray<byte> data, uint min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x306F6C0", Offset = "0x306E0C0", VA = "0x18306F6C0")]
		internal static void DLDAMIHNNNK<T>(IEKGOFPMJLE reader, MEPBHNPODPL<T> prop, NativeArray<byte> data, uint min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7730", Offset = "0x6DA6130", VA = "0x186DA7730")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DA73D0", Offset = "0x6DA5DD0", VA = "0x186DA73D0")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7B00", Offset = "0x6DA6500", VA = "0x186DA7B00")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6DA72B0", Offset = "0x6DA5CB0", VA = "0x186DA72B0")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7B60", Offset = "0x6DA6560", VA = "0x186DA7B60")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6DA6FD0", Offset = "0x6DA59D0", VA = "0x186DA6FD0")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7810", Offset = "0x6DA6210", VA = "0x186DA7810")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7250", Offset = "0x6DA5C50", VA = "0x186DA7250")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA76C0", Offset = "0x6DA60C0", VA = "0x186DA76C0")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7480", Offset = "0x6DA5E80", VA = "0x186DA7480")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA77A0", Offset = "0x6DA61A0", VA = "0x186DA77A0")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7530", Offset = "0x6DA5F30", VA = "0x186DA7530")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6DA75E0", Offset = "0x6DA5FE0", VA = "0x186DA75E0")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA71A0", Offset = "0x6DA5BA0", VA = "0x186DA71A0")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7A90", Offset = "0x6DA6490", VA = "0x186DA7A90")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6DA70F0", Offset = "0x6DA5AF0", VA = "0x186DA70F0")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x306FA20", Offset = "0x306E420", VA = "0x18306FA20")]
		internal static void HLGBFIEHJDG<T>(JLJAFHKKPFG writer, MEPBHNPODPL<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x306F5D0", Offset = "0x306DFD0", VA = "0x18306F5D0")]
		internal static void DLDAMIHNNNK<T>(IEKGOFPMJLE reader, MEPBHNPODPL<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7980", Offset = "0x6DA6380", VA = "0x186DA7980")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7030", Offset = "0x6DA5A30", VA = "0x186DA7030")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7870", Offset = "0x6DA6270", VA = "0x186DA7870")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7310", Offset = "0x6DA5D10", VA = "0x186DA7310")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7650", Offset = "0x6DA6050", VA = "0x186DA7650")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<FNBNHJHANON> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DA6F60", Offset = "0x6DA5960", VA = "0x186DA6F60")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<FNBNHJHANON> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B960", Offset = "0x6D8A360", VA = "0x186D8B960")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, MEPBHNPODPL<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B570", Offset = "0x6D89F70", VA = "0x186D8B570")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, MEPBHNPODPL<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B960", Offset = "0x6D8A360", VA = "0x186D8B960")]
		internal static void HLGBFIEHJDG(JLJAFHKKPFG writer, HAANENPBPKN prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B570", Offset = "0x6D89F70", VA = "0x186D8B570")]
		internal static void DLDAMIHNNNK(IEKGOFPMJLE reader, HAANENPBPKN prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x306F7A0", Offset = "0x306E1A0", VA = "0x18306F7A0")]
		internal static T GMLBIBJFPDA<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8B10", Offset = "0x6DA7510", VA = "0x186DA8B10")]
		public void KFMGLABNFNG(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7BC0", Offset = "0x6DA65C0", VA = "0x186DA7BC0")]
		private void JGCFJNODNCG(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x356CEF0", Offset = "0x356B8F0", VA = "0x18356CEF0")]
		private void GNAHFFLNHKJ<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PMHIEKHFCME
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(NEPMANBAOJL), new string[] { "Registry" })]
[ServiceLifetime(Lifetime.Application)]
internal class CFDJMMDAKIP : NEPMANBAOJL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type PEEALIJCJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9390", Offset = "0x6DA7D90", VA = "0x186DA9390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] BFOKACNAGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6DA93F0", Offset = "0x6DA7DF0", VA = "0x186DA93F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9370", Offset = "0x6DA7D70", VA = "0x186DA9370", Slot = "6")]
	public void BEGEJAFPDNH(IComponentDefaultRegistration GBOBNFONAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public CFDJMMDAKIP()
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
