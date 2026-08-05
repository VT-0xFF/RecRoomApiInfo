using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Foundation_Registry_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84AD420", Offset = "0x84AC220", VA = "0x1884AD420", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TDRCZDSDGEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly string[] FDTXRFHJSEZ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly string[] EXSWJMSANCT;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AssemblyIndex> IMJVIOBUDTW;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static bool XQXHMUVABZJ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly object CPWBYBUXJQK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static List<AssemblyIndex> TOJMBMWKDQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x84AF060", Offset = "0x84ADE60", VA = "0x1884AF060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84AF0A0", Offset = "0x84ADEA0", VA = "0x1884AF0A0")]
		public static List<AssemblyIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84AF360", Offset = "0x84AE160", VA = "0x1884AF360")]
		private static void TZLCPYKMZLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84AF640", Offset = "0x84AE440", VA = "0x1884AF640")]
		private static void XODVWNCJJJL(Assembly a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84AF220", Offset = "0x84AE020", VA = "0x1884AF220")]
		[CompilerGenerated]
		internal static bool SAUKXBMQSFH(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CEIRANEZYZA : IComponentDefaultRegistration, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private struct Align : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public NativeList<byte> buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public NativeParallelHashMap<int, (int offset, int length)> ranges;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x84AB0A0", Offset = "0x84A9EA0", VA = "0x1884AB0A0")]
			public static Align LBPAECDTOVB(int a)
			{
				return default(Align);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84AB160", Offset = "0x84A9F60", VA = "0x1884AB160")]
			public void ZCUPQIFTYKF([Out] NativeList<byte> a, [Out] NativeParallelHashMap<int, (int offset, int length)> ranges)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x84AB010", Offset = "0x84A9E10", VA = "0x1884AB010", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Align[] GHCJTLHSVAA;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84ABB20", Offset = "0x84AA920", VA = "0x1884ABB20")]
		public CEIRANEZYZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84AB170", Offset = "0x84A9F70", VA = "0x1884AB170", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84AB3D0", Offset = "0x84AA1D0", VA = "0x1884AB3D0")]
		public Defaults PGLXIWAGTHX()
		{
			return default(Defaults);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84AB9B0", Offset = "0x84AA7B0", VA = "0x1884AB9B0", Slot = "4")]
		public void RegisterComponentDefault(Type type, int alignment, Span<byte> bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84AB270", Offset = "0x84AA070", VA = "0x1884AB270")]
		private void JSWRMAPHNAW(int a, int b, Span<byte> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct ComponentPropertyMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[Flags]
		public enum EFlags
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			Configurable = 1
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public ConfigGroup configGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int firstPropertyIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int propertyCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public EFlags flags;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84ABE80", Offset = "0x84AAC80", VA = "0x1884ABE80")]
		public ComponentPropertyMetadata(ConfigGroup configGroup, int firstPropertyIndex, int propertyCount, EFlags flags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ConfigGroup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int priority;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE190C0", Offset = "0xE17EC0", VA = "0x180E190C0")]
		public ConfigGroup(string name, int priority)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct Defaults
	{
		[StructLayout((LayoutKind)0, Size = 64)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ScratchDefault
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[ReadOnly]
		private readonly NativeArray<byte> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ReadOnly]
		private readonly NativeParallelHashMap<int, (int offset, int length)> ranges;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly ScratchDefault scratch;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84ABED0", Offset = "0x84AACD0", VA = "0x1884ABED0")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37F4960", Offset = "0x37F3760", VA = "0x1837F4960")]
		public a XLUJMNMYLBU<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84ABF80", Offset = "0x84AAD80", VA = "0x1884ABF80")]
		public NativeArray<byte> XLUJMNMYLBU(int a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4F77FE0", Offset = "0x4F76DE0", VA = "0x184F77FE0")]
		public Defaults(NativeArray<byte> buffer, NativeParallelHashMap<int, (int offset, int length)> ranges)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YMQMFMUYKCM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Type MPAJLZCJQYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Type[] ESJPNWJYZZV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyDictionary<Type, NetworkInterfaceInfo> ILAIMUKWKFF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JGLEKZPDIXW(IComponentDefaultRegistration a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VSXVZCCMZPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int WKYILYEQKLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type[] HCDVBEUEELJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeArray<int> GWLOJVCHYHX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		NativeArray<int> URFGFFKMPAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		NativeBitArray ZMELHDQDQQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		NativeBitArray VOEHDGXKOOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		NativeParallelHashSet<int> TOJQYCNGXIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Type[] YXDYEQRIBLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PropertyMetadata[] KRDNNNINWQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<int, ComponentPropertyMetadata> IDPHYFTLWYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NetworkInterfaceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TypeIndex[] componentTypeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<Entity, object, object> create;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Func<Entity, object, object> createDecb;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PropertyMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[Flags]
		public enum EFlags
		{
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Disabled = 1,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Configurable = 2
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ConfigGroup configGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string configFriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EFlags flags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool GQATBFGCYBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72DE630", Offset = "0x72DD430", VA = "0x1872DE630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool XDBUCNNPXPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72DE650", Offset = "0x72DD450", VA = "0x1872DE650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string VASMOFPMPIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x84AD4E0", Offset = "0x84AC2E0", VA = "0x1884AD4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84AD520", Offset = "0x84AC320", VA = "0x1884AD520")]
		public PropertyMetadata([Optional] string debugName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x65BDD20", Offset = "0x65BCB20", VA = "0x1865BDD20")]
		public PropertyMetadata(ConfigGroup group, string friendlyName, EFlags flags, [Optional] string debugName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public static class Registry
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class TypeRegistration : ITypeRegistration
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x84AFC00", Offset = "0x84AEA00", VA = "0x1884AFC00", Slot = "4")]
			public void RegisterTypes(Type attribute, params Type[] types)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84AFAA0", Offset = "0x84AE8A0", VA = "0x1884AFAA0", Slot = "5")]
			public void RegisterMethods(Type attribute, params Delegate[] delegates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public TypeRegistration()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly string[] ServiceCategories;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly Log log;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool isInitialized;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static bool isAppDomainUnloadRegistered;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Dictionary<Type, List<Type>> typeRegistry;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Dictionary<Type, List<Delegate>> methodRegistry;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly List<Type> emptyTypeList;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly List<Delegate> emptyMethodList;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static CERMPDGXYNS dataLayerServices;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static YMQMFMUYKCM dataLayerRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static VSXVZCCMZPA networkPropertyRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static HEMONIOTOQR serviceCategories;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static VSXVZCCMZPA NetworkProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x84AEE00", Offset = "0x84ADC00", VA = "0x1884AEE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static List<Type> SingletonComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84AEE50", Offset = "0x84ADC50", VA = "0x1884AEE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Type[] NetworkComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x84AEC20", Offset = "0x84ADA20", VA = "0x1884AEC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> NetworkInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84AED10", Offset = "0x84ADB10", VA = "0x1884AED10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Defaults Defaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x84AEBB0", Offset = "0x84AD9B0", VA = "0x1884AEBB0")]
			[CompilerGenerated]
			get
			{
				return default(Defaults);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84AF000", Offset = "0x84ADE00", VA = "0x1884AF000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5710", Offset = "0x3CD4510", VA = "0x183CD5710")]
		public static List<Type> GetTypeList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84AD7E0", Offset = "0x84AC5E0", VA = "0x1884AD7E0")]
		public static List<Type> GetTypeList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5690", Offset = "0x3CD4490", VA = "0x183CD5690")]
		public static List<Delegate> GetMethodList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84AD710", Offset = "0x84AC510", VA = "0x1884AD710")]
		public static List<Delegate> GetMethodList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5450", Offset = "0x3CD4250", VA = "0x183CD5450")]
		public static T GetDefault<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84AD560", Offset = "0x84AC360", VA = "0x1884AD560")]
		public static NativeArray<byte> GetDefault(int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84AD8B0", Offset = "0x84AC6B0", VA = "0x1884AD8B0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84AE3E0", Offset = "0x84AD1E0", VA = "0x1884AE3E0")]
		public static void RegisterServicesWithAny(this CERMPDGXYNS services, params string[] any)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84AE450", Offset = "0x84AD250", VA = "0x1884AE450")]
		public static void RegisterServicesWithNone(this CERMPDGXYNS services, params string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84AE4C0", Offset = "0x84AD2C0", VA = "0x1884AE4C0")]
		public static void RegisterServices(this CERMPDGXYNS services, [Optional] string[] all, [Optional] string[] any, [Optional] string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84AE750", Offset = "0x84AD550", VA = "0x1884AE750")]
		public static void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84AE570", Offset = "0x84AD370", VA = "0x1884AE570")]
		private static void RegisterServices(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84ADD70", Offset = "0x84ACB70", VA = "0x1884ADD70")]
		private static void RegisterDataLayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84AE610", Offset = "0x84AD410", VA = "0x1884AE610")]
		private static void RegisterTypes(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84AE2A0", Offset = "0x84AD0A0", VA = "0x1884AE2A0")]
		private static void RegisterMethods(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84ADF40", Offset = "0x84ACD40", VA = "0x1884ADF40")]
		private static void RegisterDefaults(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84AE870", Offset = "0x84AD670", VA = "0x1884AE870")]
		private static void ThrowIfUninitialized()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class HEMONIOTOQR : IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly ProfilerMarker WPGRFURZAQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly List<AssemblyIndex> JSTHYNASMUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<(ServiceBitset, AssemblyIndex)> SPAMWPJWXVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Dictionary<ServiceBitset, List<AssemblyIndex>> PTMWKEQFIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Dictionary<string, int> EQZVPXLWSHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly string[] RVEOANNDXNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private CERMPDGXYNS YAQZQWZJBFV;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84ACE00", Offset = "0x84ABC00", VA = "0x1884ACE00")]
		public HEMONIOTOQR(List<AssemblyIndex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84AC2E0", Offset = "0x84AB0E0", VA = "0x1884AC2E0")]
		public void IPFDCTVTWHM(CERMPDGXYNS a, string[] b, string[] c, string[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84ACC40", Offset = "0x84ABA40", VA = "0x1884ACC40")]
		private ServiceBitsetFilter TAPJSYHLTII(string[] a, string[] b, string[] c)
		{
			return default(ServiceBitsetFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84AC5F0", Offset = "0x84AB3F0", VA = "0x1884AC5F0")]
		private ServiceBitset JMUFSTIQFHS(string[] a)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84AC6B0", Offset = "0x84AB4B0", VA = "0x1884AC6B0")]
		private List<AssemblyIndex> NJTRCSXJGUT(ServiceBitsetFilter a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84AC1D0", Offset = "0x84AAFD0", VA = "0x1884AC1D0", Slot = "4")]
		public bool CanBind(Type bindType, [Out] Lifetime lifetime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84AC0A0", Offset = "0x84AAEA0", VA = "0x1884AC0A0", Slot = "6")]
		public ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84AC950", Offset = "0x84AB750", VA = "0x1884AC950", Slot = "5")]
		public void Register(Type bindType, Lifetime lifetime, object instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84ACAC0", Offset = "0x84AB8C0", VA = "0x1884ACAC0", Slot = "7")]
		public void Register(Type[] bindTypes, Lifetime lifetime, ulong mask, object instance)
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
