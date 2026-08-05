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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F0BB0", Offset = "0x99EF5B0", VA = "0x1899F0BB0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class PCBRKENAQYC
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly string[] FQKPYXKDVQX;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly string[] SHRMGGKJASF;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AssemblyIndex> FRCEWUILHBA;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static bool NSTODTFPEQZ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly object VMPESYSZZMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static List<AssemblyIndex> ZQDFCFELCZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99F1110", Offset = "0x99EFB10", VA = "0x1899F1110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99F0E50", Offset = "0x99EF850", VA = "0x1899F0E50")]
		public static List<AssemblyIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99F1150", Offset = "0x99EFB50", VA = "0x1899F1150")]
		private static void ZTWPEWLYEIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99F0C70", Offset = "0x99EF670", VA = "0x1899F0C70")]
		private static void GOHDLIDNOSX(Assembly a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99F0FD0", Offset = "0x99EF9D0", VA = "0x1899F0FD0")]
		[CompilerGenerated]
		internal static bool OFNFBWRXLFF(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CLQCBDWACHO : IComponentDefaultRegistration, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x99EFBA0", Offset = "0x99EE5A0", VA = "0x1899EFBA0")]
			public static Align GDAYGRYKVSZ(int a)
			{
				return default(Align);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x99EFC60", Offset = "0x99EE660", VA = "0x1899EFC60")]
			public void OGNPAZKLJRJ([Out] NativeList<byte> a, [Out] NativeParallelHashMap<int, (int offset, int length)> ranges)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x99EFB10", Offset = "0x99EE510", VA = "0x1899EFB10", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Align[] JKIGZGZHRMO;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99F0630", Offset = "0x99EF030", VA = "0x1899F0630")]
		public CLQCBDWACHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99EFC70", Offset = "0x99EE670", VA = "0x1899EFC70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99F0040", Offset = "0x99EEA40", VA = "0x1899F0040")]
		public Defaults VMBGDDMKQBB()
		{
			return default(Defaults);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99EFED0", Offset = "0x99EE8D0", VA = "0x1899EFED0", Slot = "4")]
		public void RegisterComponentDefault(Type type, int alignment, Span<byte> bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99EFD70", Offset = "0x99EE770", VA = "0x1899EFD70")]
		private void GNVGRFQYRBG(int a, int b, Span<byte> c)
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
		[Cpp2IlInjected.Address(RVA = "0x99F0990", Offset = "0x99EF390", VA = "0x1899F0990")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC8DF0", Offset = "0xDC77F0", VA = "0x180DC8DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F09E0", Offset = "0x99EF3E0", VA = "0x1899F09E0")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x395BEF0", Offset = "0x395A8F0", VA = "0x18395BEF0")]
		public a IBOAAJNQSGY<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99F0A90", Offset = "0x99EF490", VA = "0x1899F0A90")]
		public NativeArray<byte> IBOAAJNQSGY(int a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6395810", Offset = "0x6394210", VA = "0x186395810")]
		public Defaults(NativeArray<byte> buffer, NativeParallelHashMap<int, (int offset, int length)> ranges)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QWKDHMUFFJQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Type QMOUDNDLYBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Type[] LKGUSROHRBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyDictionary<Type, NetworkInterfaceInfo> GJPYDABYVMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XSZTVLBKEMG(IComponentDefaultRegistration a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ADSDIIFYFNO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type[] LPWFGGUXBUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeArray<int> UAXJHDLDRTV
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		NativeArray<int> MKBBSHLLWXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		NativeBitArray WMXRCHJIPKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		NativeBitArray PNKASTASPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		NativeParallelHashSet<int> FIHWHUWKHEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Type[] CCGQCVEGWVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PropertyMetadata[] ATPVZSFLYHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<int, ComponentPropertyMetadata> VCRDBKZKFOL
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
		public bool QZEPOXVOZND
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8823F10", Offset = "0x8822910", VA = "0x188823F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool TKEEKVNTCLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8823F30", Offset = "0x8822930", VA = "0x188823F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string KSMECCFZXPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x99F1650", Offset = "0x99F0050", VA = "0x1899F1650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99F1690", Offset = "0x99F0090", VA = "0x1899F1690")]
		public PropertyMetadata([Optional] string debugName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82FBDC0", Offset = "0x82FA7C0", VA = "0x1882FBDC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99F4690", Offset = "0x99F3090", VA = "0x1899F4690", Slot = "4")]
			public void RegisterTypes(Type attribute, params Type[] types)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x99F4530", Offset = "0x99F2F30", VA = "0x1899F4530", Slot = "5")]
			public void RegisterMethods(Type attribute, params Delegate[] delegates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		private static KJVXVBNUPJI dataLayerServices;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static QWKDHMUFFJQ dataLayerRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static ADSDIIFYFNO networkPropertyRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static QQDTUOZJLYT serviceCategories;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ADSDIIFYFNO NetworkProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x99F42D0", Offset = "0x99F2CD0", VA = "0x1899F42D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static List<Type> SingletonComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x99F4320", Offset = "0x99F2D20", VA = "0x1899F4320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Type[] NetworkComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x99F40F0", Offset = "0x99F2AF0", VA = "0x1899F40F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> NetworkInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x99F41E0", Offset = "0x99F2BE0", VA = "0x1899F41E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Defaults Defaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x99F4080", Offset = "0x99F2A80", VA = "0x1899F4080")]
			[CompilerGenerated]
			get
			{
				return default(Defaults);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99F44D0", Offset = "0x99F2ED0", VA = "0x1899F44D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3F32EA0", Offset = "0x3F318A0", VA = "0x183F32EA0")]
		public static List<Type> GetTypeList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99F2CB0", Offset = "0x99F16B0", VA = "0x1899F2CB0")]
		public static List<Type> GetTypeList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F32E20", Offset = "0x3F31820", VA = "0x183F32E20")]
		public static List<Delegate> GetMethodList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99F2BE0", Offset = "0x99F15E0", VA = "0x1899F2BE0")]
		public static List<Delegate> GetMethodList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F32BE0", Offset = "0x3F315E0", VA = "0x183F32BE0")]
		public static T GetDefault<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99F2A30", Offset = "0x99F1430", VA = "0x1899F2A30")]
		public static NativeArray<byte> GetDefault(int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99F2D80", Offset = "0x99F1780", VA = "0x1899F2D80")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99F38B0", Offset = "0x99F22B0", VA = "0x1899F38B0")]
		public static void RegisterServicesWithAny(this KJVXVBNUPJI services, params string[] any)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99F3920", Offset = "0x99F2320", VA = "0x1899F3920")]
		public static void RegisterServicesWithNone(this KJVXVBNUPJI services, params string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99F3A30", Offset = "0x99F2430", VA = "0x1899F3A30")]
		public static void RegisterServices(this KJVXVBNUPJI services, [Optional] string[] all, [Optional] string[] any, [Optional] string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99F3C20", Offset = "0x99F2620", VA = "0x1899F3C20")]
		public static void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99F3990", Offset = "0x99F2390", VA = "0x1899F3990")]
		private static void RegisterServices(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99F3240", Offset = "0x99F1C40", VA = "0x1899F3240")]
		private static void RegisterDataLayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99F3AE0", Offset = "0x99F24E0", VA = "0x1899F3AE0")]
		private static void RegisterTypes(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99F3770", Offset = "0x99F2170", VA = "0x1899F3770")]
		private static void RegisterMethods(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99F3410", Offset = "0x99F1E10", VA = "0x1899F3410")]
		private static void RegisterDefaults(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x99F3D40", Offset = "0x99F2740", VA = "0x1899F3D40")]
		private static void ThrowIfUninitialized()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class QQDTUOZJLYT : IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly ProfilerMarker OJIYFXKEMMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly List<AssemblyIndex> LWGWOSEXUNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<(ServiceBitset, AssemblyIndex)> XMCCGLQPYSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Dictionary<ServiceBitset, List<AssemblyIndex>> MXJXKWLYBDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Dictionary<string, int> RPIRUHBISHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly string[] RFBZWTOWOEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private KJVXVBNUPJI GUKAWUKYTGZ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99F2410", Offset = "0x99F0E10", VA = "0x1899F2410")]
		public QQDTUOZJLYT(List<AssemblyIndex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99F16D0", Offset = "0x99F00D0", VA = "0x1899F16D0")]
		public void CBYRPQCEVDS(KJVXVBNUPJI a, string[] b, string[] c, string[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99F2190", Offset = "0x99F0B90", VA = "0x1899F2190")]
		private ServiceBitsetFilter WKHDMPHLOSK(string[] a, string[] b, string[] c)
		{
			return default(ServiceBitsetFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99F2290", Offset = "0x99F0C90", VA = "0x1899F2290")]
		private ServiceBitset XAYKMFVRFNA(string[] a)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99F1C00", Offset = "0x99F0600", VA = "0x1899F1C00")]
		private List<AssemblyIndex> RXNAHJGFHRH(ServiceBitsetFilter a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99F1B00", Offset = "0x99F0500", VA = "0x1899F1B00", Slot = "4")]
		public bool CanBind(Type bindType, [Out] Lifetime lifetime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99F19E0", Offset = "0x99F03E0", VA = "0x1899F19E0", Slot = "6")]
		public ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99F1EA0", Offset = "0x99F08A0", VA = "0x1899F1EA0", Slot = "5")]
		public void Register(Type bindType, Lifetime lifetime, object instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99F2010", Offset = "0x99F0A10", VA = "0x1899F2010", Slot = "7")]
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
