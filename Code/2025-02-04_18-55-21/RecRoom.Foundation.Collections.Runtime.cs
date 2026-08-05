using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Foundation_Collections_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7280F90", Offset = "0x727FD90", VA = "0x187280F90", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KECHHNLAIGG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7280CD0", Offset = "0x727FAD0", VA = "0x187280CD0")]
	public static void GFKMCHELPLO(this GameObject IHNPMPCJPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7280D70", Offset = "0x727FB70", VA = "0x187280D70")]
	public static void GFKMCHELPLO(this Component MMJIAOCMCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7280C30", Offset = "0x727FA30", VA = "0x187280C30")]
	public static void GFKMCHELPLO(this ScriptableObject JIJIOMKCKOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FNAAHEJLEMG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72807E0", Offset = "0x727F5E0", VA = "0x1872807E0")]
	public static Span<byte> DGOGOHDDJNP(this NativeArray<byte> EOOCBMPNEML)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7280890", Offset = "0x727F690", VA = "0x187280890")]
	public static ReadOnlySpan<byte> LLLFBOLNPDG(this NativeArray<byte> EOOCBMPNEML)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x329D050", Offset = "0x329BE50", VA = "0x18329D050")]
	public static NativeArray<T> MFPGMPIAMIN<T>(this NativeArray<T> EOOCBMPNEML, GGPBJDCMKPH OIHMOLOEHFC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x329D090", Offset = "0x329BE90", VA = "0x18329D090")]
	public static NativeArray<T> MFPGMPIAMIN<T>(this NativeArray<T> EOOCBMPNEML, int EBKPEOBONHB) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NNKBLLBOAEB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3462010", Offset = "0x3460E10", VA = "0x183462010")]
	public static string LMHAIBMOCAB<T>(this NativeArray<T> EOOCBMPNEML, string AIIFFCELLKN = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MGIIMAGFBFD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7281020", Offset = "0x727FE20", VA = "0x187281020")]
	public static void KFILOAKBECL(this NativeList<byte> BJCKKCNKPEK, ReadOnlySpan<byte> CDHMHJNMOCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CBHMNNJENHO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x30F3040", Offset = "0x30F1E40", VA = "0x1830F3040")]
	public static T JDMNBLICOOH<T>(this ReadOnlySpan<byte> IPHILEOFJLB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30F31C0", Offset = "0x30F1FC0", VA = "0x1830F31C0")]
	public static ReadOnlySpan<byte> LLLFBOLNPDG<T>(this T IPHILEOFJLB) where T : struct
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30F2590", Offset = "0x30F1390", VA = "0x1830F2590")]
	public static T ANFJBBFMPMK<T>([In] this ReadOnlySpan<byte> CDHMHJNMOCE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x30F2FF0", Offset = "0x30F1DF0", VA = "0x1830F2FF0")]
	public static ReadOnlySpan<TTo> GCHEOMAMPMB<TTo>(this ReadOnlySpan<byte> CDHMHJNMOCE) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x30F2AE0", Offset = "0x30F18E0", VA = "0x1830F2AE0")]
	public static Span<byte> DJKOKNNCNMK<T>([In] this Span<byte> CDHMHJNMOCE, T IPHILEOFJLB) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x727FB30", Offset = "0x727E930", VA = "0x18727FB30")]
	private static Enum DCPEIMKBNAB([In] ReadOnlySpan<byte> CDHMHJNMOCE, Type BAIAAKMEPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72800D0", Offset = "0x727EED0", VA = "0x1872800D0")]
	public static Enum LPFMKGFGEDG([In] this Span<byte> CDHMHJNMOCE, Type BAIAAKMEPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7280140", Offset = "0x727EF40", VA = "0x187280140")]
	public static void OAJLDIIMECP([In] this Span<byte> CDHMHJNMOCE, Enum LJGAMICHBPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HNGPNILFMFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LJBHMEEGLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7280E10", Offset = "0x727FC10", VA = "0x187280E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7280B10", Offset = "0x727F910", VA = "0x187280B10")]
	[AsyncStateMachine(typeof(LJBHMEEGLFD))]
	public static void CEPGPGKFMJI(this Task DHJLEBFEJME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ONELIKAPPID
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum GMGGMLNFCCO : short
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Uncategorized = 5,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		ObjectModel,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		SplineWrapper,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Scalability,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		UpdateAllocator,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Snapshot,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		ShadowEntities,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		PostLoadNetworkIdSystem,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Singleton,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		COUNT
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct DNKOOMALJED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly GMGGMLNFCCO FFOHLCGHDKA;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B43600", Offset = "0x2B42400", VA = "0x182B43600")]
		public DNKOOMALJED(GMGGMLNFCCO FFOHLCGHDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory INPCIJAHNDH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	public static void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72810A0", Offset = "0x727FEA0", VA = "0x1872810A0")]
	static ONELIKAPPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAAB0", Offset = "0x2FB98B0", VA = "0x182FBAAB0")]
	public static DNKOOMALJED HEDNGINDHNL(GMGGMLNFCCO FFOHLCGHDKA)
	{
		return default(DNKOOMALJED);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	public static void MHIKABMNBHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HHDEPIJNCOK<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GCHandle IPNJAOPIHCP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4570130", Offset = "0x456EF30", VA = "0x184570130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4570030", Offset = "0x456EE30", VA = "0x184570030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x45701D0", Offset = "0x456EFD0", VA = "0x1845701D0")]
	public HHDEPIJNCOK(T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4570100", Offset = "0x456EF00", VA = "0x184570100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class EGODAIJGHLL<THandle, TValue> : IDisposable where THandle : struct, PLHKHJEHJBK where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<THandle> GOFFLFBJEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly List<TValue> DCFFMJLJGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Func<TValue> FKIJJHKCNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Action<TValue> MOMKGJDJACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int BNIJBDPMHPC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TValue FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3FDFE40", Offset = "0x3FDEC40", VA = "0x183FDFE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFF20", Offset = "0x3FDED20", VA = "0x183FDFF20")]
	public EGODAIJGHLL(Action<TValue> MOMKGJDJACD, [Optional] Func<TValue> FKIJJHKCNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF5C0", Offset = "0x3FDE3C0", VA = "0x183FDF5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFA60", Offset = "0x3FDE860", VA = "0x183FDFA60")]
	public THandle MDGAONDGEMG(TValue IPHILEOFJLB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFB00", Offset = "0x3FDE900", VA = "0x183FDFB00")]
	public bool MJMAPJMIAED(THandle IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF7D0", Offset = "0x3FDE5D0", VA = "0x183FDF7D0")]
	public bool KFIFLGLFIGE(THandle IPNJAOPIHCP, [Out] TValue IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF2A0", Offset = "0x3FDE0A0", VA = "0x183FDF2A0")]
	public TValue ANFJBBFMPMK(THandle IPNJAOPIHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF4B0", Offset = "0x3FDE2B0", VA = "0x183FDF4B0")]
	public bool DMOEJHJGHMI(THandle IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFC30", Offset = "0x3FDEA30", VA = "0x183FDFC30")]
	private THandle MKHLIKGAOAE(int KNCPCNBMDNF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF240", Offset = "0x3FDE040", VA = "0x183FDF240")]
	private TValue AIAPLHLPKLG(int KNCPCNBMDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFE80", Offset = "0x3FDEC80", VA = "0x183FDFE80")]
	private void PAOBFLOBDKE(int KNCPCNBMDNF, [In] THandle IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFED0", Offset = "0x3FDECD0", VA = "0x183FDFED0")]
	private void PJAJBBHLOCC(int KNCPCNBMDNF, [In] TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFC90", Offset = "0x3FDEA90", VA = "0x183FDFC90")]
	private THandle MMMPAOHCGPL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF8A0", Offset = "0x3FDE6A0", VA = "0x183FDF8A0")]
	private void LILALNILODB(THandle IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF690", Offset = "0x3FDE490", VA = "0x183FDF690")]
	private int GNFNDDBGNFI(int BBDOELHAPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF4A0", Offset = "0x3FDE2A0", VA = "0x183FDF4A0")]
	private bool CLHMFGJPDIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8F9750", Offset = "0x8F8550", VA = "0x1808F9750")]
	private void PGCHFPMIJHG(THandle IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF9B0", Offset = "0x3FDE7B0", VA = "0x183FDF9B0")]
	private bool LOHLPPABNFD([Out] THandle IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF6A0", Offset = "0x3FDE4A0", VA = "0x183FDF6A0")]
	private bool JAPNOMHAILD([Out] THandle IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF2F0", Offset = "0x3FDE0F0", VA = "0x183FDF2F0")]
	private void BFIPFJDKJFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PLHKHJEHJBK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int CKCKCAOJJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GLGILLFDONJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32B5C20", Offset = "0x32B4A20", VA = "0x1832B5C20")]
	public static bool KFHPCCBLNKM<T>(this T IPNJAOPIHCP, T LHMPMCLNOPG) where T : struct, PLHKHJEHJBK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32B5C10", Offset = "0x32B4A10", VA = "0x1832B5C10")]
	public static bool JJCPGCBCCEF<T>(this T IPNJAOPIHCP) where T : struct, PLHKHJEHJBK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7280A00", Offset = "0x727F800", VA = "0x187280A00")]
	public static string KJBLGMHAHEC(this PLHKHJEHJBK IPNJAOPIHCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public ref struct ALJDIGJCPKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Type ABHGFBHGHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Span<byte> DHKPDBLLNKN;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AFA0", Offset = "0x4A39DA0", VA = "0x184A3AFA0")]
	public ALJDIGJCPKP(Type ALMNFJBJIBE, Span<byte> CDHMHJNMOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F730", Offset = "0x3A2E530", VA = "0x183A2F730")]
	public static ALJDIGJCPKP IFANBOIGHJP<T>(T IPHILEOFJLB) where T : struct
	{
		return default(ALJDIGJCPKP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x727FA20", Offset = "0x727E820", VA = "0x18727FA20")]
	public static DIKFDJPCMMB JCHCBNMNCNP([In] ALJDIGJCPKP MLFMLAODHNL)
	{
		return default(DIKFDJPCMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x727FAA0", Offset = "0x727E8A0", VA = "0x18727FAA0")]
	public Enum LPFMKGFGEDG(Type BAIAAKMEPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F6F0", Offset = "0x3A2E4F0", VA = "0x183A2F6F0")]
	public void DJKOKNNCNMK<T>([In] T IPHILEOFJLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x727FB20", Offset = "0x727E920", VA = "0x18727FB20")]
	public void OAJLDIIMECP(Enum LJGAMICHBPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public ref struct DIKFDJPCMMB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct JNMMAIAKJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* KAIJPEGEGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private unsafe void* HFOIKCHKEFL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Type ABHGFBHGHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly ReadOnlySpan<byte> DHKPDBLLNKN;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AFA0", Offset = "0x4A39DA0", VA = "0x184A3AFA0")]
	public DIKFDJPCMMB(Type ALMNFJBJIBE, ReadOnlySpan<byte> CDHMHJNMOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3144480", Offset = "0x3143280", VA = "0x183144480")]
	public static DIKFDJPCMMB IFANBOIGHJP<T>(T IPHILEOFJLB) where T : struct
	{
		return default(DIKFDJPCMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72807A0", Offset = "0x727F5A0", VA = "0x1872807A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7280650", Offset = "0x727F450", VA = "0x187280650")]
	public object EMIAMKJOOAI()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KNOHOKNKFOB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x339A4B0", Offset = "0x33992B0", VA = "0x18339A4B0")]
	public static NativeArray<T> KGLPNFLAGMN<T>(T IPHILEOFJLB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x339A410", Offset = "0x3399210", VA = "0x18339A410")]
	public static NativeArray<T> BLONDFJLHHE<T>(T IPHILEOFJLB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x339A460", Offset = "0x3399260", VA = "0x18339A460")]
	public static NativeArray<T> IFANBOIGHJP<T>(T IPHILEOFJLB, bool DIDOHDJAEFH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DLOIMDJMCPB<Handle> where Handle : PLHKHJEHJBK, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct OKODPKFDDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly DLOIMDJMCPB<Handle> AEDLDLDGAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int KNCPCNBMDNF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle IKGLEANFCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4E4BE20", Offset = "0x4E4AC20", VA = "0x184E4BE20")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4E4C320", Offset = "0x4E4B120", VA = "0x184E4C320")]
		public OKODPKFDDCL(DLOIMDJMCPB<Handle> AEDLDLDGAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4E4C1D0", Offset = "0x4E4AFD0", VA = "0x184E4C1D0")]
		public NPPNKFNGOKP MKHEJJEDOII([In] NPPNKFNGOKP BHICHJIFLJC)
		{
			return default(NPPNKFNGOKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BF90", Offset = "0x4E4AD90", VA = "0x184E4BF90")]
		public bool HGCPDEMNJKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E4C260", Offset = "0x4E4B060", VA = "0x184E4C260")]
		private Handle NHMOLGDDLBB(string KKBJAPCBOHH)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct NPPNKFNGOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private OKODPKFDDCL OBOJLOHJDHP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4D4A170", Offset = "0x4D48F70", VA = "0x184D4A170")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4D4A2A0", Offset = "0x4D490A0", VA = "0x184D4A2A0")]
		public NPPNKFNGOKP(DLOIMDJMCPB<Handle> AEDLDLDGAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4D4A1F0", Offset = "0x4D48FF0", VA = "0x184D4A1F0")]
		public bool HGCPDEMNJKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4D4A230", Offset = "0x4D49030", VA = "0x184D4A230")]
		public NPPNKFNGOKP NAPBKLICNNH()
		{
			return default(NPPNKFNGOKP);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> LLFMKMAKJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeList<int> FAJCJCDIDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int OIPFDGJIFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int EIHLDOJKLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool HIFEDCDMFMM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EONCJEIOJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6119090", Offset = "0x6117E90", VA = "0x186119090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NPPNKFNGOKP OFOANPFHCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61199E0", Offset = "0x61187E0", VA = "0x1861199E0")]
		get
		{
			return default(NPPNKFNGOKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x611A0B0", Offset = "0x6118EB0", VA = "0x18611A0B0")]
	public DLOIMDJMCPB(int JODNHNBMFGB, Allocator GCNJHJPCIGN = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6119600", Offset = "0x6118400", VA = "0x186119600")]
	public void MOHLAAINEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3710", Offset = "0x1EB2510", VA = "0x181EB3710")]
	public static int GNFNDDBGNFI(int MFHMIEFHEKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B77EE0", Offset = "0x2B76CE0", VA = "0x182B77EE0")]
	public static bool MCGFOHFJGOB(int MFHMIEFHEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61198B0", Offset = "0x61186B0", VA = "0x1861198B0")]
	public bool OKFLJJAEGOL(int KNCPCNBMDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6119310", Offset = "0x6118110", VA = "0x186119310")]
	public bool LKLDFIAFBHP(Handle IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6118A80", Offset = "0x6117880", VA = "0x186118A80")]
	public Handle BNAKBAHNKCH()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6119DA0", Offset = "0x6118BA0", VA = "0x186119DA0")]
	public void POJAJKILGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6119230", Offset = "0x6118030", VA = "0x186119230")]
	public void LCFGAGLJCMO(Handle IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000")]
	private bool MPAPDPBJAHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61188F0", Offset = "0x61176F0", VA = "0x1861188F0")]
	private bool AKPIEIKILPA(int KNCPCNBMDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6118780", Offset = "0x6117580", VA = "0x186118780")]
	private void AJPMFBKGIOB([Out] int KNCPCNBMDNF, [Out] int BBDOELHAPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6118CB0", Offset = "0x6117AB0", VA = "0x186118CB0")]
	private void FGACJBDMNAN(Handle IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6118E00", Offset = "0x6117C00", VA = "0x186118E00")]
	private void HOCOMAFLJLK(int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61190D0", Offset = "0x6117ED0", VA = "0x1861190D0")]
	private bool KLONGNBBODL([Out] int KNCPCNBMDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6118F90", Offset = "0x6117D90", VA = "0x186118F90")]
	private static Handle KEILCJNDBHB(int KNCPCNBMDNF, int BBDOELHAPOH)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct FNJPKBHHDHM<Handle, T> where Handle : PLHKHJEHJBK, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DLOIMDJMCPB<Handle> FGGAOCAEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] NGLCMNIIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Action<T> DGJEHECFJGA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x43D1D00", Offset = "0x43D0B00", VA = "0x1843D1D00")]
	public FNJPKBHHDHM(int JODNHNBMFGB, [Optional] Action<T> DGJEHECFJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x43D1B10", Offset = "0x43D0910", VA = "0x1843D1B10")]
	public void MOHLAAINEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x43D1770", Offset = "0x43D0570", VA = "0x1843D1770")]
	public bool KFIFLGLFIGE(Handle IPNJAOPIHCP, [Out] T JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x43D1A10", Offset = "0x43D0810", VA = "0x1843D1A10")]
	public Handle MDGAONDGEMG(T JOOHPPHJKMI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x43D0E80", Offset = "0x43CFC80", VA = "0x1843D0E80")]
	public void FCJCGKMNPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x43D1400", Offset = "0x43D0200", VA = "0x1843D1400")]
	public void IEINLEAGPOE(Handle IPNJAOPIHCP, [Out] T KNPDPBCHILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x43D16A0", Offset = "0x43D04A0", VA = "0x1843D16A0")]
	public void IEINLEAGPOE(Handle IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x43D13A0", Offset = "0x43D01A0", VA = "0x1843D13A0")]
	private T HNFFLMKNOKC(int KNCPCNBMDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x43D12E0", Offset = "0x43D00E0", VA = "0x1843D12E0")]
	private void FJGODDCIPGC(int FCHNBIPGJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public struct GIOHGKCHIEP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private T[] JOAPLPPIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int AIIKLGOLFIK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2533EA0", Offset = "0x2532CA0", VA = "0x182533EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x33700F0", Offset = "0x336EEF0", VA = "0x1833700F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> DHKPDBLLNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x44C6EE0", Offset = "0x44C5CE0", VA = "0x1844C6EE0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HLLEOGFNEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x15061E0", Offset = "0x1504FE0", VA = "0x1815061E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x44C6F80", Offset = "0x44C5D80", VA = "0x1844C6F80")]
	public GIOHGKCHIEP(int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x44C6D70", Offset = "0x44C5B70", VA = "0x1844C6D70")]
	public int IKKFBIBAJIP(T IPHILEOFJLB, int EBKPEOBONHB, int BMGBDLLODJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x44C6C70", Offset = "0x44C5A70", VA = "0x1844C6C70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public struct ODEPIHBIIKA<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct ENAMHEEOKLN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private ODEPIHBIIKA<T> BJCKKCNKPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int KNCPCNBMDNF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4003590", Offset = "0x4002390", VA = "0x184003590", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4003630", Offset = "0x4002430", VA = "0x184003630", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4003600", Offset = "0x4002400", VA = "0x184003600")]
		public ENAMHEEOKLN(ODEPIHBIIKA<T> BJCKKCNKPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4003500", Offset = "0x4002300", VA = "0x184003500", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4003540", Offset = "0x4002340", VA = "0x184003540", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private GIOHGKCHIEP<T> JOAPLPPIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int AIIKLGOLFIK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4E2F5A0", Offset = "0x4E2E3A0", VA = "0x184E2F5A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4E2F500", Offset = "0x4E2E300", VA = "0x184E2F500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EONCJEIOJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4E2F310", Offset = "0x4E2E110", VA = "0x184E2F310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HLLEOGFNEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4E2F250", Offset = "0x4E2E050", VA = "0x184E2F250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> DHKPDBLLNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4E2F440", Offset = "0x4E2E240", VA = "0x184E2F440")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F9D0", Offset = "0x4E2E7D0", VA = "0x184E2F9D0")]
	public ODEPIHBIIKA(int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F540", Offset = "0x4E2E340", VA = "0x184E2F540")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F340", Offset = "0x4E2E140", VA = "0x184E2F340")]
	public void MDGAONDGEMG(T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EF50", Offset = "0x4E2DD50", VA = "0x184E2EF50")]
	internal void GBHMFDDCNBE(int MLAKJOPIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F630", Offset = "0x4E2E430", VA = "0x184E2F630")]
	public void PENIHPJNMJH(int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EB90", Offset = "0x4E2D990", VA = "0x184E2EB90")]
	public void BJPFLIKAING(int LGLMAIDLAKK, int GJDJJJOJIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F290", Offset = "0x4E2E090", VA = "0x184E2F290")]
	public int IKKFBIBAJIP(T IPHILEOFJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EDC0", Offset = "0x4E2DBC0", VA = "0x184E2EDC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F180", Offset = "0x4E2DF80", VA = "0x184E2F180", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F920", Offset = "0x4E2E720", VA = "0x184E2F920", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F960", Offset = "0x4E2E760", VA = "0x184E2F960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EE00", Offset = "0x4E2DC00", VA = "0x184E2EE00")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void GBAFHLKODHD(int IPHILEOFJLB, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F710", Offset = "0x4E2E510", VA = "0x184E2F710")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void PPFPGMGMNEJ(int LGLMAIDLAKK, int GJDJJJOJIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GGPBJDCMKPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int DACBEFNKNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int BMGBDLLODJK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NJLELLEMFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F4C0", VA = "0x182B506C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65B1030", Offset = "0x65AFE30", VA = "0x1865B1030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KBGPNAHACGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int CHGKKDHAAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7280950", Offset = "0x727F750", VA = "0x187280950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7280940", Offset = "0x727F740", VA = "0x187280940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	private GGPBJDCMKPH(int DACBEFNKNPO, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x254C320", Offset = "0x254B120", VA = "0x18254C320")]
	public static GGPBJDCMKPH GPFAJBNMPFJ(int DACBEFNKNPO, int BMGBDLLODJK)
	{
		return default(GGPBJDCMKPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7280960", Offset = "0x727F760", VA = "0x187280960")]
	public static GGPBJDCMKPH OMGNOJENAIJ(int EBKPEOBONHB, int GJDJJJOJIJP)
	{
		return default(GGPBJDCMKPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7280970", Offset = "0x727F770", VA = "0x187280970", Slot = "3")]
	public override string ToString()
	{
		return null;
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
