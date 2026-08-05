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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C860", Offset = "0x6F3BC60", VA = "0x186F3C860", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9F20", Offset = "0x6FA9320", VA = "0x186FA9F20")]
		private void PKLDHDIFILK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9DB0", Offset = "0x6FA91B0", VA = "0x186FA9DB0")]
		private void KNPLIPKNCKI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA090", Offset = "0x6FA9490", VA = "0x186FAA090", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA3C0", Offset = "0x6FA97C0", VA = "0x186FAA3C0")]
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
public struct HFFALABIPJN : IComparable<HFFALABIPJN>, IEquatable<HFFALABIPJN>
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly HFFALABIPJN GBDBCKKFJEP;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly HFFALABIPJN HOMJCOAMLDL;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly HFFALABIPJN IHLHLJFIBFP;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly HFFALABIPJN GBDLACOCKPL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly HFFALABIPJN DJLDKHPCLGF;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly HFFALABIPJN DGPAJHMDBCI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly int IIACLAMOIEE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MCCLHKLCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type HOBOEBKIFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F99A00", Offset = "0x6F98E00", VA = "0x186F99A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KLPNABMJIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F997C0", Offset = "0x6F98BC0", VA = "0x186F997C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EMINOKGEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F998E0", Offset = "0x6F98CE0", VA = "0x186F998E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type DBFHGNDLNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F996F0", Offset = "0x6F98AF0", VA = "0x186F996F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OIHCJFBDABO JGEJGGLHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F992C0", Offset = "0x6F986C0", VA = "0x186F992C0")]
		get
		{
			return default(OIHCJFBDABO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IGAPPDJCHJC GFCHLNDPAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F98F90", Offset = "0x6F98390", VA = "0x186F98F90")]
		get
		{
			return default(IGAPPDJCHJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JJODJELDLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F99560", Offset = "0x6F98960", VA = "0x186F99560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CBPLHODAHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F99150", Offset = "0x6F98550", VA = "0x186F99150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OJHBJIOFGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F995B0", Offset = "0x6F989B0", VA = "0x186F995B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PMGDPKCOCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F99420", Offset = "0x6F98820", VA = "0x186F99420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260")]
	public HFFALABIPJN(int IIACLAMOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F99240", Offset = "0x6F98640", VA = "0x186F99240", Slot = "5")]
	public bool Equals(HFFALABIPJN BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F991A0", Offset = "0x6F985A0", VA = "0x186F991A0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F99AD0", Offset = "0x6F98ED0", VA = "0x186F99AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x41D9330", Offset = "0x41D8730", VA = "0x1841D9330", Slot = "4")]
	public int CompareTo(HFFALABIPJN BMKPAKCEMFK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EDEHECMKDHG<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly int IIACLAMOIEE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private HFFALABIPJN DLPMIFOGBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10")]
		get
		{
			return default(HFFALABIPJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260")]
	internal EDEHECMKDHG(int IIACLAMOIEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1829780", Offset = "0x1828B80", VA = "0x181829780")]
	public static HFFALABIPJN IDKOEJANABA(EDEHECMKDHG<T> LKGPHBHEBBE)
	{
		return default(HFFALABIPJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBBE0", Offset = "0x3CBAFE0", VA = "0x183CBBBE0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC2B0", Offset = "0x3CBB6B0", VA = "0x183CBC2B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F8D090", Offset = "0x6F8C490", VA = "0x186F8D090")]
		public static (long, string, string) KKELALDNHJB(NABGOBFPKKK value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CF50", Offset = "0x6F8C350", VA = "0x186F8CF50")]
		public static (long, string, string)[] CJFLAGAOLID(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x6F9B760", Offset = "0x6F9AB60", VA = "0x186F9B760")]
		public static Type[] JPCEMENLHHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F99E20", Offset = "0x6F99220", VA = "0x186F99E20")]
		private static void EMOBGIHOLPD()
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
		public static readonly EDEHECMKDHG<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly EDEHECMKDHG<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly EDEHECMKDHG<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly EDEHECMKDHG<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly EDEHECMKDHG<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly EDEHECMKDHG<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly EDEHECMKDHG<PDKELJPCIHO> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly EDEHECMKDHG<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly EDEHECMKDHG<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly EDEHECMKDHG<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly EDEHECMKDHG<FixedList32Bytes<int>> InteractionFilterData_tags;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly EDEHECMKDHG<bool> InteractionFilterData_enabled;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly EDEHECMKDHG<PDKELJPCIHO> InteractionFilterData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly EDEHECMKDHG<int> SerializedDataLayerVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly EDEHECMKDHG<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly EDEHECMKDHG<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly EDEHECMKDHG<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly EDEHECMKDHG<NIJJNBEEDDJ> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly EDEHECMKDHG<GPGJJHENEFG> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly EDEHECMKDHG<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static readonly EDEHECMKDHG<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly EDEHECMKDHG<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly EDEHECMKDHG<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly EDEHECMKDHG<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly EDEHECMKDHG<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly EDEHECMKDHG<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly EDEHECMKDHG<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public static readonly EDEHECMKDHG<CGNBAFLIIGN> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public static readonly EDEHECMKDHG<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly EDEHECMKDHG<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly EDEHECMKDHG<EMNBECFOLHA> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly EDEHECMKDHG<LHOIJIFDHFN> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly EDEHECMKDHG<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly EDEHECMKDHG<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly EDEHECMKDHG<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly EDEHECMKDHG<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly EDEHECMKDHG<LocalId> EntityBundlePartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly EDEHECMKDHG<uint> EntityBundlePartData_entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly EDEHECMKDHG<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static readonly EDEHECMKDHG<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly EDEHECMKDHG<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly EDEHECMKDHG<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly EDEHECMKDHG<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly EDEHECMKDHG<NPCMHJCAMLN> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly EDEHECMKDHG<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly EDEHECMKDHG<MCBOHJAEBBG> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly EDEHECMKDHG<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly EDEHECMKDHG<int> ReplicatorMaxObjectCountData_MaxCopies;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly EDEHECMKDHG<float> ContainerMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly EDEHECMKDHG<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly EDEHECMKDHG<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly EDEHECMKDHG<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly EDEHECMKDHG<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly EDEHECMKDHG<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly EDEHECMKDHG<DGJCNJCEEEP> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly EDEHECMKDHG<DIJCMKAGHOP> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly EDEHECMKDHG<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly EDEHECMKDHG<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly EDEHECMKDHG<IEEIAAPPNKJ> ContainerCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly EDEHECMKDHG<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly EDEHECMKDHG<GPGJJHENEFG> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly EDEHECMKDHG<DOEHBADGEDJ> ContainerGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly EDEHECMKDHG<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly EDEHECMKDHG<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly EDEHECMKDHG<AHKAPNEMKGD> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly EDEHECMKDHG<CFKLLNFGDHF> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly EDEHECMKDHG<BHOHGJEEODK> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly EDEHECMKDHG<LAKABHFBLCH> ContainerFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly EDEHECMKDHG<OLIPBANBJJC> ContainerCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly EDEHECMKDHG<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly EDEHECMKDHG<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly EDEHECMKDHG<EOAJELELPKP> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly EDEHECMKDHG<KLFGHHFCBOI> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly EDEHECMKDHG<MADKIBJAIEL> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly EDEHECMKDHG<IIPEAPLOMMN> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly EDEHECMKDHG<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly EDEHECMKDHG<AEMLLOGJEJB> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[RegisterService(typeof(PMLAADOPCKH), new string[] { "Registry", "Ignore" })]
	[ServiceLifetime(Lifetime.Application)]
	internal class NetworkPropertyRegistry : PMLAADOPCKH, DJNALIDNAMP, FCDDCBJENJH
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
			[Cpp2IlInjected.Address(RVA = "0xB5FC10", Offset = "0xB5F010", VA = "0x180B5FC10", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96E320", VA = "0x18096EF20", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9DE930", Offset = "0x9DDD30", VA = "0x1809DE930", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAE8460", Offset = "0xAE7860", VA = "0x180AE8460", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEB0", Offset = "0x8CA2B0", VA = "0x1808CAEB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEC0", Offset = "0x8CA2C0", VA = "0x1808CAEC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF30", Offset = "0x8CA330", VA = "0x1808CAF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public OIHCJFBDABO[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEE0", Offset = "0x8CA2E0", VA = "0x1808CAEE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8CAED0", Offset = "0x8CA2D0", VA = "0x1808CAED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, IGAPPDJCHJC> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF40", Offset = "0x8CA340", VA = "0x1808CAF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6FA55B0", Offset = "0x6FA49B0", VA = "0x186FA55B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BF70", Offset = "0x6F9B370", VA = "0x186F9BF70", Slot = "13")]
		public void FJNMEIIAPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FA55D0", Offset = "0x6FA49D0", VA = "0x186FA55D0", Slot = "14")]
		public void OBDLHHEKPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BF80", Offset = "0x6F9B380", VA = "0x186F9BF80")]
		private void JNICOPMDHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7370", Offset = "0x6FA6770", VA = "0x186FA7370")]
		public static void JJLEHCMKKGK(LBFJJKFGJBB writer, HFFALABIPJN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5C10", Offset = "0x6FA5010", VA = "0x186FA5C10")]
		public static void GPOACOGDAOK(CKFDNBKHPDG reader, HFFALABIPJN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5C30", Offset = "0x6FA5030", VA = "0x186FA5C30")]
		private static void IKJECDFPFAL(LBFJJKFGJBB writer, HFFALABIPJN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7A10", Offset = "0x6FA6E10", VA = "0x186FA7A10")]
		private static void PLIFMCLHGFN(CKFDNBKHPDG reader, HFFALABIPJN property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x320D180", Offset = "0x320C580", VA = "0x18320D180")]
		internal static void GKPJGNLGAKF<T>(LBFJJKFGJBB writer, EDEHECMKDHG<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x320D4B0", Offset = "0x320C8B0", VA = "0x18320D4B0")]
		internal static void KBLFJIABLOP<T>(CKFDNBKHPDG reader, EDEHECMKDHG<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x320D2A0", Offset = "0x320C6A0", VA = "0x18320D2A0")]
		internal static void GKPJGNLGAKF<T>(LBFJJKFGJBB writer, EDEHECMKDHG<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x320D5A0", Offset = "0x320C9A0", VA = "0x18320D5A0")]
		internal static void KBLFJIABLOP<T>(CKFDNBKHPDG reader, EDEHECMKDHG<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5950", Offset = "0x6FA4D50", VA = "0x186FA5950")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7780", Offset = "0x6FA6B80", VA = "0x186FA7780")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5AD0", Offset = "0x6FA4ED0", VA = "0x186FA5AD0")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FA79B0", Offset = "0x6FA6DB0", VA = "0x186FA79B0")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FA56A0", Offset = "0x6FA4AA0", VA = "0x186FA56A0")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FA78E0", Offset = "0x6FA6CE0", VA = "0x186FA78E0")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5880", Offset = "0x6FA4C80", VA = "0x186FA5880")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7670", Offset = "0x6FA6A70", VA = "0x186FA7670")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6FA58E0", Offset = "0x6FA4CE0", VA = "0x186FA58E0")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FA76D0", Offset = "0x6FA6AD0", VA = "0x186FA76D0")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5B30", Offset = "0x6FA4F30", VA = "0x186FA5B30")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7500", Offset = "0x6FA6900", VA = "0x186FA7500")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5BA0", Offset = "0x6FA4FA0", VA = "0x186FA5BA0")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7390", Offset = "0x6FA6790", VA = "0x186FA7390")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5630", Offset = "0x6FA4A30", VA = "0x186FA5630")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7830", Offset = "0x6FA6C30", VA = "0x186FA7830")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x320D370", Offset = "0x320C770", VA = "0x18320D370")]
		internal static void GKPJGNLGAKF<T>(LBFJJKFGJBB writer, EDEHECMKDHG<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x320D680", Offset = "0x320CA80", VA = "0x18320D680")]
		internal static void KBLFJIABLOP<T>(CKFDNBKHPDG reader, EDEHECMKDHG<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5770", Offset = "0x6FA4B70", VA = "0x186FA5770")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7440", Offset = "0x6FA6840", VA = "0x186FA7440")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6FA59C0", Offset = "0x6FA4DC0", VA = "0x186FA59C0")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6FA75B0", Offset = "0x6FA69B0", VA = "0x186FA75B0")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5700", Offset = "0x6FA4B00", VA = "0x186FA5700")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<GPGJJHENEFG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7940", Offset = "0x6FA6D40", VA = "0x186FA7940")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<GPGJJHENEFG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CA80", Offset = "0x6F8BE80", VA = "0x186F8CA80")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, EDEHECMKDHG<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CC10", Offset = "0x6F8C010", VA = "0x186F8CC10")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, EDEHECMKDHG<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CA80", Offset = "0x6F8BE80", VA = "0x186F8CA80")]
		internal static void GKPJGNLGAKF(LBFJJKFGJBB writer, HFFALABIPJN prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CC10", Offset = "0x6F8C010", VA = "0x186F8CC10")]
		internal static void KBLFJIABLOP(CKFDNBKHPDG reader, HFFALABIPJN prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x320D770", Offset = "0x320CB70", VA = "0x18320D770")]
		internal static T MABAPNOAKFP<T>(this NativeArray<byte> data) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x6FA8E30", Offset = "0x6FA8230", VA = "0x186FA8E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FA8E60", Offset = "0x6FA8260", VA = "0x186FA8E60")]
		public void EMOBGIHOLPD(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E70", Offset = "0x6FA8270", VA = "0x186FA8E70")]
		private void OPHHLNMAPJO(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x36DC8C0", Offset = "0x36DBCC0", VA = "0x1836DC8C0")]
		private void JKBCPEMKLEC<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
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
public enum BFNFFGOLNML
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
[RegisterService(typeof(MAMKJOAFKFN), new string[] { "Registry" })]
[ServiceLifetime(Lifetime.Application)]
internal class FNAOHPLOOIJ : MAMKJOAFKFN
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type AEENAIHNGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA620", Offset = "0x6FA9A20", VA = "0x186FAA620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] IIAPCABKNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA5F0", Offset = "0x6FA99F0", VA = "0x186FAA5F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA600", Offset = "0x6FA9A00", VA = "0x186FAA600", Slot = "6")]
	public void APHINBMBLAJ(IComponentDefaultRegistration LHKFKCFCNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FNAOHPLOOIJ()
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
