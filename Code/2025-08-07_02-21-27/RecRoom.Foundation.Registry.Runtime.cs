using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A270F0", Offset = "0x8A25CF0", VA = "0x188A270F0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class OPRYYHCYHYS
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly string[] VVJIKYTWLOX;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly string[] LJPZAHJCUDP;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AssemblyIndex> VAHTIDRKWNY;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static bool UCWBSNBCBIJ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly object RXRHKXRPVIA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static List<AssemblyIndex> XBWPBAZSXFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8A286C0", Offset = "0x8A272C0", VA = "0x188A286C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A28400", Offset = "0x8A27000", VA = "0x188A28400")]
		public static List<AssemblyIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A28120", Offset = "0x8A26D20", VA = "0x188A28120")]
		private static void DUAAQUAYMGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A27ED0", Offset = "0x8A26AD0", VA = "0x188A27ED0")]
		private static void CTTRFDUNJSH(Assembly a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A28580", Offset = "0x8A27180", VA = "0x188A28580")]
		[CompilerGenerated]
		internal static bool ONKDMQPQAKT(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OOMIGOIZENW : IComponentDefaultRegistration, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8A26B10", Offset = "0x8A25710", VA = "0x188A26B10")]
			public static Align AGRTPSUIYOJ(int a)
			{
				return default(Align);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8A26C60", Offset = "0x8A25860", VA = "0x188A26C60")]
			public void SGLQLYIOUSX([Out] NativeList<byte> a, [Out] NativeParallelHashMap<int, (int offset, int length)> ranges)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8A26BD0", Offset = "0x8A257D0", VA = "0x188A26BD0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Align[] DPBILRGWLEK;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A27B70", Offset = "0x8A26770", VA = "0x188A27B70")]
		public OOMIGOIZENW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A271B0", Offset = "0x8A25DB0", VA = "0x188A271B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A27580", Offset = "0x8A26180", VA = "0x188A27580")]
		public Defaults TOXVOCJSATB()
		{
			return default(Defaults);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A27410", Offset = "0x8A26010", VA = "0x188A27410", Slot = "4")]
		public void RegisterComponentDefault(Type type, int alignment, Span<byte> bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A272B0", Offset = "0x8A25EB0", VA = "0x188A272B0")]
		private void LCMGSCNWMXC(int a, int b, Span<byte> c)
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
		[Cpp2IlInjected.Address(RVA = "0x8A26C70", Offset = "0x8A25870", VA = "0x188A26C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xE01E80", Offset = "0xE00A80", VA = "0x180E01E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A26CC0", Offset = "0x8A258C0", VA = "0x188A26CC0")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3AC4500", Offset = "0x3AC3100", VA = "0x183AC4500")]
		public a YKYIIQURCXK<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8A26FC0", Offset = "0x8A25BC0", VA = "0x188A26FC0")]
		public NativeArray<byte> YKYIIQURCXK(int a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A26D70", Offset = "0x8A25970", VA = "0x188A26D70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void JSKTYZACTIW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x53398D0", Offset = "0x53384D0", VA = "0x1853398D0")]
		public Defaults(NativeArray<byte> buffer, NativeParallelHashMap<int, (int offset, int length)> ranges)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RMGTTGLSXRU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Type ENDKSDFEMQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Type[] OYKJMIHYLQV
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyDictionary<Type, NetworkInterfaceInfo> ISVMAJCBIGF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NUBSQIMALDA(IComponentDefaultRegistration a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TPXBEQYFHYE
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int TXICYPISMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type[] KPEGALBGRIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeArray<int> CMGTEXNKIMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		NativeArray<int> ZXCALBGONCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		NativeBitArray NZPPXZISFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		NativeBitArray YAXVVQTDVKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		NativeParallelHashSet<int> ALSNEIRPIJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Type[] FUHNCEKBWDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PropertyMetadata[] GNTEEPETWUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<int, ComponentPropertyMetadata> AAMBPWUKHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
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
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Disabled = 1,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
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
		public bool EBSVDBRYLBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x78704C0", Offset = "0x786F0C0", VA = "0x1878704C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool MKPGWWCHQDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x78704E0", Offset = "0x786F0E0", VA = "0x1878704E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A28920", Offset = "0x8A27520", VA = "0x188A28920")]
		public PropertyMetadata([Optional] string debugName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A28980", Offset = "0x8A27580", VA = "0x188A28980")]
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
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A660", Offset = "0x8A29260", VA = "0x188A2A660", Slot = "4")]
			public void RegisterTypes(Type attribute, params Type[] types)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A500", Offset = "0x8A29100", VA = "0x188A2A500", Slot = "5")]
			public void RegisterMethods(Type attribute, params Delegate[] delegates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TypeRegistration()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly string[] ServiceCategories;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log log;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static bool isInitialized;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static bool isAppDomainUnloadRegistered;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Dictionary<Type, List<Type>> typeRegistry;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly Dictionary<Type, List<Delegate>> methodRegistry;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly List<Type> emptyTypeList;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly List<Delegate> emptyMethodList;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static BDOPQIINDDA dataLayerServices;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static RMGTTGLSXRU dataLayerRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static TPXBEQYFHYE networkPropertyRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static VUDQQHUZWFZ serviceCategories;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static TPXBEQYFHYE NetworkProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A2A0", Offset = "0x8A28EA0", VA = "0x188A2A2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static List<Type> SingletonComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A2F0", Offset = "0x8A28EF0", VA = "0x188A2A2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Type[] NetworkComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A0C0", Offset = "0x8A28CC0", VA = "0x188A2A0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> NetworkInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A1B0", Offset = "0x8A28DB0", VA = "0x188A2A1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Defaults Defaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A050", Offset = "0x8A28C50", VA = "0x188A2A050")]
			[CompilerGenerated]
			get
			{
				return default(Defaults);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A4A0", Offset = "0x8A290A0", VA = "0x188A2A4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1380", Offset = "0x3FCFF80", VA = "0x183FD1380")]
		public static List<Type> GetTypeList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A28C80", Offset = "0x8A27880", VA = "0x188A28C80")]
		public static List<Type> GetTypeList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1300", Offset = "0x3FCFF00", VA = "0x183FD1300")]
		public static List<Delegate> GetMethodList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A28BB0", Offset = "0x8A277B0", VA = "0x188A28BB0")]
		public static List<Delegate> GetMethodList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1000", Offset = "0x3FCFC00", VA = "0x183FD1000")]
		public static T GetDefault<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A289E0", Offset = "0x8A275E0", VA = "0x188A289E0")]
		public static NativeArray<byte> GetDefault(int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A28D50", Offset = "0x8A27950", VA = "0x188A28D50")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A29880", Offset = "0x8A28480", VA = "0x188A29880")]
		public static void RegisterServicesWithAny(this BDOPQIINDDA services, params string[] any)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A298F0", Offset = "0x8A284F0", VA = "0x188A298F0")]
		public static void RegisterServicesWithNone(this BDOPQIINDDA services, params string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A29A00", Offset = "0x8A28600", VA = "0x188A29A00")]
		public static void RegisterServices(this BDOPQIINDDA services, [Optional] string[] all, [Optional] string[] any, [Optional] string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A29BF0", Offset = "0x8A287F0", VA = "0x188A29BF0")]
		public static void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A29960", Offset = "0x8A28560", VA = "0x188A29960")]
		private static void RegisterServices(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A29210", Offset = "0x8A27E10", VA = "0x188A29210")]
		private static void RegisterDataLayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A29AB0", Offset = "0x8A286B0", VA = "0x188A29AB0")]
		private static void RegisterTypes(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A29740", Offset = "0x8A28340", VA = "0x188A29740")]
		private static void RegisterMethods(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A293E0", Offset = "0x8A27FE0", VA = "0x188A293E0")]
		private static void RegisterDefaults(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A29D10", Offset = "0x8A28910", VA = "0x188A29D10")]
		private static void ThrowIfUninitialized()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class VUDQQHUZWFZ : IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly ProfilerMarker PWZWSQKDITB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<AssemblyIndex> VKMADEFQQVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<(ServiceBitset, AssemblyIndex)> CPTVAYLYVGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Dictionary<ServiceBitset, List<AssemblyIndex>> UMRERALBLJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly Dictionary<string, int> FBBOQYSSDFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly string[] IMHYCOUYJQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private BDOPQIINDDA QAHOXJHWHNX;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A2BE40", Offset = "0x8A2AA40", VA = "0x188A2BE40")]
		public VUDQQHUZWFZ(List<AssemblyIndex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A2AFE0", Offset = "0x8A29BE0", VA = "0x188A2AFE0")]
		public void ERBMWTZFFKA(BDOPQIINDDA a, string[] b, string[] c, string[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8A2B2F0", Offset = "0x8A29EF0", VA = "0x188A2B2F0")]
		private ServiceBitsetFilter QMGMSQHYFHY(string[] a, string[] b, string[] c)
		{
			return default(ServiceBitsetFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A2AC80", Offset = "0x8A29880", VA = "0x188A2AC80")]
		private ServiceBitset CZDTNOJQMTE(string[] a)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8A2BAE0", Offset = "0x8A2A6E0", VA = "0x188A2BAE0")]
		private List<AssemblyIndex> XOAYBTJKSUZ(ServiceBitsetFilter a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8A2AEA0", Offset = "0x8A29AA0", VA = "0x188A2AEA0", Slot = "4")]
		public bool CanBind(Type bindType, [Out] Lifetime lifetime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8A2AD40", Offset = "0x8A29940", VA = "0x188A2AD40", Slot = "6")]
		public ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8A2B710", Offset = "0x8A2A310", VA = "0x188A2B710", Slot = "5")]
		public void Register(Type bindType, Lifetime lifetime, object instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A2B3F0", Offset = "0x8A29FF0", VA = "0x188A2B3F0", Slot = "7")]
		public void Register(Type[] bindTypes, Lifetime lifetime, ulong mask, object instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8A2BA10", Offset = "0x8A2A610", VA = "0x188A2BA10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void UREVILLPHJW(Type a)
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
