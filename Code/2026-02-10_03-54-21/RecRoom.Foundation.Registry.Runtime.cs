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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x845C1E0", Offset = "0x845B3E0", VA = "0x18845C1E0", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class PVXEYEKJDKX
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly string[] WTYPBISMIAU;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly string[] IXQRLIJJBDI;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AssemblyIndex> FGIHKYLVMWR;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static bool PRXZEUNYRCC;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly object FLSCTHHAKHL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static List<AssemblyIndex> UOAXUCKUVZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x845CA00", Offset = "0x845BC00", VA = "0x18845CA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x845C5B0", Offset = "0x845B7B0", VA = "0x18845C5B0")]
		public static List<AssemblyIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x845C720", Offset = "0x845B920", VA = "0x18845C720")]
		private static void TSDYXOCZZDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x845C3D0", Offset = "0x845B5D0", VA = "0x18845C3D0")]
		private static void BSREXJLFCIQ(Assembly a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x845C2A0", Offset = "0x845B4A0", VA = "0x18845C2A0")]
		[CompilerGenerated]
		internal static bool BMVRLOKJTGW(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BXTFIHSERCF : IComponentDefaultRegistration, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x845B1E0", Offset = "0x845A3E0", VA = "0x18845B1E0")]
			public static Align JJZHPWNVAAI(int a)
			{
				return default(Align);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x845B2A0", Offset = "0x845A4A0", VA = "0x18845B2A0")]
			public void WKVVACUCCMA([Out] NativeList<byte> a, [Out] NativeParallelHashMap<int, (int offset, int length)> ranges)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x845B150", Offset = "0x845A350", VA = "0x18845B150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Align[] ANPPPQDYCSN;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x845BC60", Offset = "0x845AE60", VA = "0x18845BC60")]
		public BXTFIHSERCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x845B890", Offset = "0x845AA90", VA = "0x18845B890", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x845B2B0", Offset = "0x845A4B0", VA = "0x18845B2B0")]
		public Defaults AROCZIKSOXU()
		{
			return default(Defaults);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x845BAF0", Offset = "0x845ACF0", VA = "0x18845BAF0", Slot = "4")]
		public void RegisterComponentDefault(Type type, int alignment, Span<byte> bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x845B990", Offset = "0x845AB90", VA = "0x18845B990")]
		private void FMBWTXXWFEB(int a, int b, Span<byte> c)
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
		[Cpp2IlInjected.Address(RVA = "0x845BFC0", Offset = "0x845B1C0", VA = "0x18845BFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB4E9A0", Offset = "0xB4DBA0", VA = "0x180B4E9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x845C010", Offset = "0x845B210", VA = "0x18845C010")]
		internal void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x360B490", Offset = "0x360A690", VA = "0x18360B490")]
		public a KREBXTWEPNH<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x845C0C0", Offset = "0x845B2C0", VA = "0x18845C0C0")]
		public NativeArray<byte> KREBXTWEPNH(int a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4D933C0", Offset = "0x4D925C0", VA = "0x184D933C0")]
		public Defaults(NativeArray<byte> buffer, NativeParallelHashMap<int, (int offset, int length)> ranges)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FKRQDNFXZRJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Type JGTMMTNQMBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Type[] LKEHQRQGWNU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyDictionary<Type, NetworkInterfaceInfo> LJOWDXBMAPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SCKIAPIPDTF(IComponentDefaultRegistration a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TZGHQDJKAMN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int EMFZFZKJVBK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type[] GHIADQIEPPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeArray<int> TNEUVERGOAU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		NativeArray<int> HRCAVBLRRFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		NativeBitArray TEMSVIWJFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		NativeBitArray XACSKSLWYDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		NativeParallelHashSet<int> DFTNGJOYCMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Type[] YETBKWTQZMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PropertyMetadata[] TARRKLRSZCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<int, ComponentPropertyMetadata> OEMDSQZSNWG
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
		public bool NBHBMONIVFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72ECF00", Offset = "0x72EC100", VA = "0x1872ECF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool VICGRWLVISJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72ECF20", Offset = "0x72EC120", VA = "0x1872ECF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string RXTUMVGBRDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x845CC50", Offset = "0x845BE50", VA = "0x18845CC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x845CC90", Offset = "0x845BE90", VA = "0x18845CC90")]
		public PropertyMetadata([Optional] string debugName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x655B1B0", Offset = "0x655A3B0", VA = "0x18655B1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x845E850", Offset = "0x845DA50", VA = "0x18845E850", Slot = "4")]
			public void RegisterTypes(Type attribute, params Type[] types)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x845E6F0", Offset = "0x845D8F0", VA = "0x18845E6F0", Slot = "5")]
			public void RegisterMethods(Type attribute, params Delegate[] delegates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
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
		private static RMFDIRGCGLF dataLayerServices;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static FKRQDNFXZRJ dataLayerRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static TZGHQDJKAMN networkPropertyRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static XKCSQAKIKKI serviceCategories;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static TZGHQDJKAMN NetworkProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x845E4A0", Offset = "0x845D6A0", VA = "0x18845E4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static List<Type> SingletonComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x845E4F0", Offset = "0x845D6F0", VA = "0x18845E4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Type[] NetworkComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x845E2C0", Offset = "0x845D4C0", VA = "0x18845E2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IReadOnlyDictionary<Type, NetworkInterfaceInfo> NetworkInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x845E3B0", Offset = "0x845D5B0", VA = "0x18845E3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Defaults Defaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x845E260", Offset = "0x845D460", VA = "0x18845E260")]
			[CompilerGenerated]
			get
			{
				return default(Defaults);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x845E690", Offset = "0x845D890", VA = "0x18845E690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3A844D0", Offset = "0x3A836D0", VA = "0x183A844D0")]
		public static List<Type> GetTypeList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x845CF40", Offset = "0x845C140", VA = "0x18845CF40")]
		public static List<Type> GetTypeList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3A84450", Offset = "0x3A83650", VA = "0x183A84450")]
		public static List<Delegate> GetMethodList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x845CE80", Offset = "0x845C080", VA = "0x18845CE80")]
		public static List<Delegate> GetMethodList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A84210", Offset = "0x3A83410", VA = "0x183A84210")]
		public static T GetDefault<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x845CCD0", Offset = "0x845BED0", VA = "0x18845CCD0")]
		public static NativeArray<byte> GetDefault(int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x845D000", Offset = "0x845C200", VA = "0x18845D000")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x845DAD0", Offset = "0x845CCD0", VA = "0x18845DAD0")]
		public static void RegisterServicesWithAny(this RMFDIRGCGLF services, params string[] any)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x845DB40", Offset = "0x845CD40", VA = "0x18845DB40")]
		public static void RegisterServicesWithNone(this RMFDIRGCGLF services, params string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x845DC50", Offset = "0x845CE50", VA = "0x18845DC50")]
		public static void RegisterServices(this RMFDIRGCGLF services, [Optional] string[] all, [Optional] string[] any, [Optional] string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x845DE40", Offset = "0x845D040", VA = "0x18845DE40")]
		public static void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x845DBB0", Offset = "0x845CDB0", VA = "0x18845DBB0")]
		private static void RegisterServices(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x845D480", Offset = "0x845C680", VA = "0x18845D480")]
		private static void RegisterDataLayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x845DD00", Offset = "0x845CF00", VA = "0x18845DD00")]
		private static void RegisterTypes(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x845D990", Offset = "0x845CB90", VA = "0x18845D990")]
		private static void RegisterMethods(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x845D630", Offset = "0x845C830", VA = "0x18845D630")]
		private static void RegisterDefaults(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x845DF50", Offset = "0x845D150", VA = "0x18845DF50")]
		private static void ThrowIfUninitialized()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class XKCSQAKIKKI : IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly ProfilerMarker AFUZBXXGDHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly List<AssemblyIndex> XRVNOOBENSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<(ServiceBitset, AssemblyIndex)> UVCVTTMRMHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Dictionary<ServiceBitset, List<AssemblyIndex>> MFAIAAHHICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Dictionary<string, int> NQZEHVAYHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly string[] HRZRCJQPCZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private RMFDIRGCGLF APLQWVIUXCU;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x845F890", Offset = "0x845EA90", VA = "0x18845F890")]
		public XKCSQAKIKKI(List<AssemblyIndex> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x845EE90", Offset = "0x845E090", VA = "0x18845EE90")]
		public void JUFURAKXVZP(RMFDIRGCGLF a, string[] b, string[] c, string[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x845ED90", Offset = "0x845DF90", VA = "0x18845ED90")]
		private ServiceBitsetFilter DIDEMHBMMOP(string[] a, string[] b, string[] c)
		{
			return default(ServiceBitsetFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x845F710", Offset = "0x845E910", VA = "0x18845F710")]
		private ServiceBitset WYKUDWRQPIF(string[] a)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x845F1A0", Offset = "0x845E3A0", VA = "0x18845F1A0")]
		private List<AssemblyIndex> OWDMGBMTICM(ServiceBitsetFilter a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x845EC90", Offset = "0x845DE90", VA = "0x18845EC90", Slot = "4")]
		public bool CanBind(Type bindType, [Out] Lifetime lifetime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x845EB70", Offset = "0x845DD70", VA = "0x18845EB70", Slot = "6")]
		public ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x845F440", Offset = "0x845E640", VA = "0x18845F440", Slot = "5")]
		public void Register(Type bindType, Lifetime lifetime, object instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x845F5A0", Offset = "0x845E7A0", VA = "0x18845F5A0", Slot = "7")]
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
