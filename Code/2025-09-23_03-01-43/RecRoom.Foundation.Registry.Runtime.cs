using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Foundation_Registry_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x851EF10", Offset = "0x851D510", VA = "0x18851EF10", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ILNKIIDDHPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly string[] CCLPBHKDGED;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly string[] PPKFBDDNFAA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static List<AssemblyIndex> GAHBPKOBKBL;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static bool OIJPENJFFAF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly object LGEJIAEJPOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static List<AssemblyIndex> BOEJCFFOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x851D420", Offset = "0x851BA20", VA = "0x18851D420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x851CFA0", Offset = "0x851B5A0", VA = "0x18851CFA0")]
	public static List<AssemblyIndex> BDBKJLHAGCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x851D120", Offset = "0x851B720", VA = "0x18851D120")]
	private static void EPOLPEILICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x851D460", Offset = "0x851BA60", VA = "0x18851D460")]
	private static void MIFBCLGOGAF(Assembly CBOBEOABEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x851CE60", Offset = "0x851B460", VA = "0x18851CE60")]
	[CompilerGenerated]
	internal static bool AHCFGDFFGDH(string NDIENANOGEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NJOALGCJOCM : IComponentDefaultRegistration, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct LFCIGNJHNMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NativeList<byte> DNGAEEFBGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NativeParallelHashMap<int, (int offset, int length)> LLKKLIEPGNP;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x851EDB0", Offset = "0x851D3B0", VA = "0x18851EDB0")]
		public static LFCIGNJHNMO BCINJDOEMFP(int AHIAOIDMGDN)
		{
			return default(LFCIGNJHNMO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x851EF00", Offset = "0x851D500", VA = "0x18851EF00")]
		public void HEAGIBMIAPN([Out] NativeList<byte> DNGAEEFBGGO, [Out] NativeParallelHashMap<int, (int offset, int length)> LLKKLIEPGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x851EE60", Offset = "0x851D460", VA = "0x18851EE60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LFCIGNJHNMO[] JDAGEDKIDGI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x851F940", Offset = "0x851DF40", VA = "0x18851F940")]
	public NJOALGCJOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x851EFE0", Offset = "0x851D5E0", VA = "0x18851EFE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x851F0F0", Offset = "0x851D6F0", VA = "0x18851F0F0")]
	public GMPHCDDBFNB GNMOBOKNHJG()
	{
		return default(GMPHCDDBFNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x851F7B0", Offset = "0x851DDB0", VA = "0x18851F7B0", Slot = "4")]
	public void RegisterComponentDefault(Type GPEIAHGICNA, int KLHCLCMMAIL, Span<byte> EIJIDGHNNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x851F670", Offset = "0x851DC70", VA = "0x18851F670")]
	private void HLCLBCPEANL(int FHIPANGHNKE, int KLHCLCMMAIL, Span<byte> EIJIDGHNNNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FFACLNDBNNC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Flags]
	public enum GOIFLFEJMIL
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Configurable = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public EIIIHLGILCE ABNEFAGEPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int GLMDCMNDPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int OKBBNDILDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public GOIFLFEJMIL ANBGOGICGFD;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x851CC10", Offset = "0x851B210", VA = "0x18851CC10")]
	public FFACLNDBNNC(EIIIHLGILCE ABNEFAGEPOC, int GLMDCMNDPIN, int OKBBNDILDJE, GOIFLFEJMIL ANBGOGICGFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct EIIIHLGILCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public string NDIENANOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int EOENKBEJCMN;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xDC6F20", Offset = "0xDC5520", VA = "0x180DC6F20")]
	public EIIIHLGILCE(string NDIENANOGEK, int EOENKBEJCMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GMPHCDDBFNB
{
	[StructLayout((LayoutKind)0, Size = 64)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct NFKOJJKMGEL
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	private readonly NativeArray<byte> DNGAEEFBGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	private readonly NativeParallelHashMap<int, (int offset, int length)> LLKKLIEPGNP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly NFKOJJKMGEL FOIOOANGCDI;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x851CC60", Offset = "0x851B260", VA = "0x18851CC60")]
	internal void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0430", Offset = "0x3DDEA30", VA = "0x183DE0430")]
	public T PLOMKMMJLOL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x851CD20", Offset = "0x851B320", VA = "0x18851CD20")]
	public NativeArray<byte> PLOMKMMJLOL(int FHIPANGHNKE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x578EE90", Offset = "0x578D490", VA = "0x18578EE90")]
	public GMPHCDDBFNB(NativeArray<byte> DNGAEEFBGGO, NativeParallelHashMap<int, (int offset, int length)> LLKKLIEPGNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface HBMPEEMDGJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Type MELKNKPJBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Type[] BKJMLLIIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyDictionary<Type, EAINMJFCEEG> PEMGKMOLEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBDOANBEEJN(IComponentDefaultRegistration MFHHAEFLHIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface BIPDAEHNKKM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Type[] IIIKFAEMBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NativeArray<int> GJNGENJMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NativeArray<int> JPOGLNMPKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NativeBitArray JIDAOEGKNJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NativeBitArray FALNLMJFJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NativeParallelHashSet<int> CFBNJAHLEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Type[] MMMBEJJGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CAKGHFEEHJP[] FCOFKLIDBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Dictionary<int, FFACLNDBNNC> KJKJGPIELPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EAINMJFCEEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Type GPEIAHGICNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int[] EBHEBJOJIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Func<Entity, object, object> LHGGIIMDMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Func<Entity, object, object> JHLHMFCJGNE;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CAKGHFEEHJP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Flags]
	public enum JEEMKJENLML
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
	public EIIIHLGILCE ABNEFAGEPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public string KKINOFKADPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public JEEMKJENLML ANBGOGICGFD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool BLPNOHPDPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72664B0", Offset = "0x7264AB0", VA = "0x1872664B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NLFNDCCNCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72664D0", Offset = "0x7264AD0", VA = "0x1872664D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string NCHADCAFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x851CB90", Offset = "0x851B190", VA = "0x18851CB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x851CBD0", Offset = "0x851B1D0", VA = "0x18851CBD0")]
	public CAKGHFEEHJP([Optional] string JGOFEEOIJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x631A9A0", Offset = "0x6318FA0", VA = "0x18631A9A0")]
	public CAKGHFEEHJP(EIIIHLGILCE DIHEIGLHFII, string MEGOHHCJIKL, JEEMKJENLML ANBGOGICGFD, [Optional] string JGOFEEOIJBH)
	{
	}
}
namespace RecRoom.Foundation.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class Registry
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class TypeRegistration : ITypeRegistration
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x85219C0", Offset = "0x851FFC0", VA = "0x1885219C0", Slot = "4")]
			public void RegisterTypes(Type attribute, params Type[] types)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8521850", Offset = "0x851FE50", VA = "0x188521850", Slot = "5")]
			public void RegisterMethods(Type attribute, params Delegate[] delegates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public TypeRegistration()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly string[] ServiceCategories;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly IPHNFELODMJ log;

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
		private static ELCJHMDILDE dataLayerServices;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static HBMPEEMDGJO dataLayerRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static BIPDAEHNKKM networkPropertyRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static LBNFKDFJOCI serviceCategories;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static BIPDAEHNKKM NetworkProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85215F0", Offset = "0x851FBF0", VA = "0x1885215F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static List<Type> SingletonComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8521640", Offset = "0x851FC40", VA = "0x188521640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Type[] NetworkComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8521410", Offset = "0x851FA10", VA = "0x188521410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IReadOnlyDictionary<Type, EAINMJFCEEG> NetworkInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8521500", Offset = "0x851FB00", VA = "0x188521500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static GMPHCDDBFNB Defaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x85213A0", Offset = "0x851F9A0", VA = "0x1885213A0")]
			[CompilerGenerated]
			get
			{
				return default(GMPHCDDBFNB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x85217F0", Offset = "0x851FDF0", VA = "0x1885217F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x40D14A0", Offset = "0x40CFAA0", VA = "0x1840D14A0")]
		public static List<Type> GetTypeList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x851FF10", Offset = "0x851E510", VA = "0x18851FF10")]
		public static List<Type> GetTypeList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40D1420", Offset = "0x40CFA20", VA = "0x1840D1420")]
		public static List<Delegate> GetMethodList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x851FE40", Offset = "0x851E440", VA = "0x18851FE40")]
		public static List<Delegate> GetMethodList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x40D0030", Offset = "0x40CE630", VA = "0x1840D0030")]
		public static T GetDefault<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x851FC70", Offset = "0x851E270", VA = "0x18851FC70")]
		public static NativeArray<byte> GetDefault(int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x851FFE0", Offset = "0x851E5E0", VA = "0x18851FFE0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8520B60", Offset = "0x851F160", VA = "0x188520B60")]
		public static void RegisterServicesWithAny(this ELCJHMDILDE services, params string[] any)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8520BD0", Offset = "0x851F1D0", VA = "0x188520BD0")]
		public static void RegisterServicesWithNone(this ELCJHMDILDE services, params string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8520CF0", Offset = "0x851F2F0", VA = "0x188520CF0")]
		public static void RegisterServices(this ELCJHMDILDE services, [Optional] string[] all, [Optional] string[] any, [Optional] string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8520EF0", Offset = "0x851F4F0", VA = "0x188520EF0")]
		public static void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8520C40", Offset = "0x851F240", VA = "0x188520C40")]
		private static void RegisterServices(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85204D0", Offset = "0x851EAD0", VA = "0x1885204D0")]
		private static void RegisterDataLayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8520DA0", Offset = "0x851F3A0", VA = "0x188520DA0")]
		private static void RegisterTypes(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8520A10", Offset = "0x851F010", VA = "0x188520A10")]
		private static void RegisterMethods(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85206A0", Offset = "0x851ECA0", VA = "0x1885206A0")]
		private static void RegisterDefaults(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8521000", Offset = "0x851F600", VA = "0x188521000")]
		private static void ThrowIfUninitialized()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LBNFKDFJOCI : IServiceRegistration
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly ProfilerMarker FPCHJKGGPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly List<AssemblyIndex> PGCEMAGNJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly List<(ServiceBitset, AssemblyIndex)> JHGGDKLBHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<ServiceBitset, List<AssemblyIndex>> OADGIJJPEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly Dictionary<string, int> JGGCEDJGPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly string[] KICJAMHICDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private ELCJHMDILDE KADNKCJPKCH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x851E770", Offset = "0x851CD70", VA = "0x18851E770")]
	public LBNFKDFJOCI(List<AssemblyIndex> CDAKEKHBMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x851DF70", Offset = "0x851C570", VA = "0x18851DF70")]
	public void NCEHDCEOICJ(ELCJHMDILDE KADNKCJPKCH, string[] NLCNNLOGNOC, string[] DLEJMCPMFGL, string[] EHGJECLNAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x851E2C0", Offset = "0x851C8C0", VA = "0x18851E2C0")]
	private ServiceBitsetFilter OCEGKAGEPAN(string[] NLCNNLOGNOC, string[] DLEJMCPMFGL, string[] EHGJECLNAFB)
	{
		return default(ServiceBitsetFilter);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x851DEB0", Offset = "0x851C4B0", VA = "0x18851DEB0")]
	private ServiceBitset MCJNGMHHMOI(string[] KICJAMHICDE)
	{
		return default(ServiceBitset);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x851DC10", Offset = "0x851C210", VA = "0x18851DC10")]
	private List<AssemblyIndex> HPBOFHHLHCK(ServiceBitsetFilter KMNHCMDEDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x851DB00", Offset = "0x851C100", VA = "0x18851DB00", Slot = "4")]
	public bool CanBind(Type FONJMHAJIOB, [Out] Lifetime BKAJBHIFDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x851D9D0", Offset = "0x851BFD0", VA = "0x18851D9D0", Slot = "6")]
	public ulong CanBindAny(Type[] MKJHNMCMPGG, [Out] Lifetime BKAJBHIFDLM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x851E540", Offset = "0x851CB40", VA = "0x18851E540", Slot = "5")]
	public void Register(Type FONJMHAJIOB, Lifetime BKAJBHIFDLM, object MHKMPBAHOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x851E3C0", Offset = "0x851C9C0", VA = "0x18851E3C0", Slot = "7")]
	public void Register(Type[] MKJHNMCMPGG, Lifetime BKAJBHIFDLM, ulong GDOEAMFOICP, object MHKMPBAHOMB)
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
