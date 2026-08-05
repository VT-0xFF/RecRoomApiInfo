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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8371960", Offset = "0x8370360", VA = "0x188371960", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TYXRQBMGJKQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly string[] WGNIZCEHSOJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly string[] KHTRCACABKX;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AssemblyIndex> FOEYYXBOEUU;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static bool EEXWHCBPFMX;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly object PBFEGGCBGDM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static List<AssemblyIndex> SHLMWJHOCVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8373910", Offset = "0x8372310", VA = "0x188373910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83737A0", Offset = "0x83721A0", VA = "0x1883737A0")]
		public static List<AssemblyIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83734C0", Offset = "0x8371EC0", VA = "0x1883734C0")]
		private static void ENCPTOOXKZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8373950", Offset = "0x8372350", VA = "0x188373950")]
		private static void TPQURWJHFTL(Assembly a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8373B30", Offset = "0x8372530", VA = "0x188373B30")]
		[CompilerGenerated]
		internal static bool XLWDVDRSVMZ(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ZPJYJTMSZNI : IComponentDefaultRegistration, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x83715E0", Offset = "0x836FFE0", VA = "0x1883715E0")]
			public static Align AARAJTMYXJJ(int a)
			{
				return default(Align);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8371730", Offset = "0x8370130", VA = "0x188371730")]
			public void HMUPOGLQWOR([Out] NativeList<byte> a, [Out] NativeParallelHashMap<int, (int offset, int length)> ranges)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83716A0", Offset = "0x83700A0", VA = "0x1883716A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Align[] FYDCRLECWWU;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8376000", Offset = "0x8374A00", VA = "0x188376000")]
		public ZPJYJTMSZNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8375640", Offset = "0x8374040", VA = "0x188375640", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8375A10", Offset = "0x8374410", VA = "0x188375A10")]
		public Defaults VDMLUDQBHAB()
		{
			return default(Defaults);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83758A0", Offset = "0x83742A0", VA = "0x1883758A0", Slot = "4")]
		public void RegisterComponentDefault(Type type, int alignment, Span<byte> bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8375740", Offset = "0x8374140", VA = "0x188375740")]
		private void OPTGWVULEGK(int a, int b, Span<byte> c)
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
		[Cpp2IlInjected.Address(RVA = "0x8371740", Offset = "0x8370140", VA = "0x188371740")]
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
		[Cpp2IlInjected.Address(RVA = "0xC40E00", Offset = "0xC3F800", VA = "0x180C40E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8371790", Offset = "0x8370190", VA = "0x188371790")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3589FE0", Offset = "0x35889E0", VA = "0x183589FE0")]
		public a XKTZSDKGIWK<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8371840", Offset = "0x8370240", VA = "0x188371840")]
		public NativeArray<byte> XKTZSDKGIWK(int a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4D38E00", Offset = "0x4D37800", VA = "0x184D38E00")]
		public Defaults(NativeArray<byte> buffer, NativeParallelHashMap<int, (int offset, int length)> ranges)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface XEXDSXEPWQU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Type RKCGKGSYYUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Type[] GVERIYGCDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyDictionary<Type, NetworkInterfaceInfo> ZKVXOPBMNCT
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZSZFJRFIHUU(IComponentDefaultRegistration a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZNJJMAAZBXE
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int VURRPMXXQNB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type[] EBXQAVOHZOD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeArray<int> UMMOIOZZAVP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		NativeArray<int> TFIFYYPWSMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		NativeBitArray QJRPEHMWQGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		NativeBitArray BEHHRTQVOUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		NativeParallelHashSet<int> TWAEPVLKKLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Type[] MELNIUQWAQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PropertyMetadata[] DVBKGBNXEWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<int, ComponentPropertyMetadata> KHYVNTQLASR
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
		public bool XIMXGHEMOYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7221FA0", Offset = "0x72209A0", VA = "0x187221FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KVUGVZMWOYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7221FC0", Offset = "0x72209C0", VA = "0x187221FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string BPVJQVHITCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8371A20", Offset = "0x8370420", VA = "0x188371A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8371A60", Offset = "0x8370460", VA = "0x188371A60")]
		public PropertyMetadata([Optional] string debugName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6568E80", Offset = "0x6567880", VA = "0x186568E80")]
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
			[Cpp2IlInjected.Address(RVA = "0x8373FD0", Offset = "0x83729D0", VA = "0x188373FD0", Slot = "4")]
			public void RegisterTypes(Type attribute, params Type[] types)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8373E70", Offset = "0x8372870", VA = "0x188373E70", Slot = "5")]
			public void RegisterMethods(Type attribute, params Delegate[] delegates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		private static YPEVVNJVJUU dataLayerServices;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static XEXDSXEPWQU dataLayerRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static ZNJJMAAZBXE networkPropertyRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static XTSVAEWPWHH serviceCategories;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ZNJJMAAZBXE NetworkProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8373270", Offset = "0x8371C70", VA = "0x188373270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static List<Type> SingletonComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x83732C0", Offset = "0x8371CC0", VA = "0x1883732C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Type[] NetworkComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8373090", Offset = "0x8371A90", VA = "0x188373090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> NetworkInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8373180", Offset = "0x8371B80", VA = "0x188373180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Defaults Defaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8373030", Offset = "0x8371A30", VA = "0x188373030")]
			[CompilerGenerated]
			get
			{
				return default(Defaults);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8373460", Offset = "0x8371E60", VA = "0x188373460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3A24510", Offset = "0x3A22F10", VA = "0x183A24510")]
		public static List<Type> GetTypeList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8371D10", Offset = "0x8370710", VA = "0x188371D10")]
		public static List<Type> GetTypeList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3A24490", Offset = "0x3A22E90", VA = "0x183A24490")]
		public static List<Delegate> GetMethodList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8371C50", Offset = "0x8370650", VA = "0x188371C50")]
		public static List<Delegate> GetMethodList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A24310", Offset = "0x3A22D10", VA = "0x183A24310")]
		public static T GetDefault<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8371AA0", Offset = "0x83704A0", VA = "0x188371AA0")]
		public static NativeArray<byte> GetDefault(int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8371DD0", Offset = "0x83707D0", VA = "0x188371DD0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83728A0", Offset = "0x83712A0", VA = "0x1883728A0")]
		public static void RegisterServicesWithAny(this YPEVVNJVJUU services, params string[] any)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8372910", Offset = "0x8371310", VA = "0x188372910")]
		public static void RegisterServicesWithNone(this YPEVVNJVJUU services, params string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8372980", Offset = "0x8371380", VA = "0x188372980")]
		public static void RegisterServices(this YPEVVNJVJUU services, [Optional] string[] all, [Optional] string[] any, [Optional] string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8372C10", Offset = "0x8371610", VA = "0x188372C10")]
		public static void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8372A30", Offset = "0x8371430", VA = "0x188372A30")]
		private static void RegisterServices(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8372250", Offset = "0x8370C50", VA = "0x188372250")]
		private static void RegisterDataLayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8372AD0", Offset = "0x83714D0", VA = "0x188372AD0")]
		private static void RegisterTypes(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8372760", Offset = "0x8371160", VA = "0x188372760")]
		private static void RegisterMethods(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8372400", Offset = "0x8370E00", VA = "0x188372400")]
		private static void RegisterDefaults(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8372D20", Offset = "0x8371720", VA = "0x188372D20")]
		private static void ThrowIfUninitialized()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class XTSVAEWPWHH : IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly ProfilerMarker LMKNSOYAAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly List<AssemblyIndex> JJKAIFCPXVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<(ServiceBitset, AssemblyIndex)> QBZBQJTILUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Dictionary<ServiceBitset, List<AssemblyIndex>> ICDCCKEJBRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Dictionary<string, int> WOLQSZFBOWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly string[] RVSNRVLPPHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private YPEVVNJVJUU YDZIBSORXNJ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8375020", Offset = "0x8373A20", VA = "0x188375020")]
		public XTSVAEWPWHH(List<AssemblyIndex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83745D0", Offset = "0x8372FD0", VA = "0x1883745D0")]
		public void JIBLBJTHOBM(YPEVVNJVJUU a, string[] b, string[] c, string[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83748E0", Offset = "0x83732E0", VA = "0x1883748E0")]
		private ServiceBitsetFilter RJWCKZEAWIQ(string[] a, string[] b, string[] c)
		{
			return default(ServiceBitsetFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8374510", Offset = "0x8372F10", VA = "0x188374510")]
		private ServiceBitset GMWFBVQBYIQ(string[] a)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8374CC0", Offset = "0x83736C0", VA = "0x188374CC0")]
		private List<AssemblyIndex> TMRPJRUSRVB(ServiceBitsetFilter a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8374410", Offset = "0x8372E10", VA = "0x188374410", Slot = "4")]
		public bool CanBind(Type bindType, [Out] Lifetime lifetime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83742F0", Offset = "0x8372CF0", VA = "0x1883742F0", Slot = "6")]
		public ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83749E0", Offset = "0x83733E0", VA = "0x1883749E0", Slot = "5")]
		public void Register(Type bindType, Lifetime lifetime, object instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8374B50", Offset = "0x8373550", VA = "0x188374B50", Slot = "7")]
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
