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
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : PBLCGONKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69FE5D0", Offset = "0x69FCBD0", VA = "0x1869FE5D0", Slot = "4")]
		public override void NECNOABNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LHBNFODKADB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69FE4C0", Offset = "0x69FCAC0", VA = "0x1869FE4C0")]
	public static void ODOBHPPONBH(this GameObject FNAHDAKHMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69FE380", Offset = "0x69FC980", VA = "0x1869FE380")]
	public static void ODOBHPPONBH(this Component JLFHFDLINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69FE420", Offset = "0x69FCA20", VA = "0x1869FE420")]
	public static void ODOBHPPONBH(this ScriptableObject MDOKPILIPEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EGEFJFHOLJL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69FDAE0", Offset = "0x69FC0E0", VA = "0x1869FDAE0")]
	public static Span<byte> JFFKMFIOLJI(this NativeArray<byte> FAJBEEIFFCK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69FDB90", Offset = "0x69FC190", VA = "0x1869FDB90")]
	public static ReadOnlySpan<byte> LEMMHPFKIML(this NativeArray<byte> FAJBEEIFFCK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A34F60", Offset = "0x2A33560", VA = "0x182A34F60")]
	public static NativeArray<T> BNCNFDPJJBL<T>(this NativeArray<T> FAJBEEIFFCK, BEGHBKAAGJH HPMBFDPLEJG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A34FA0", Offset = "0x2A335A0", VA = "0x182A34FA0")]
	public static NativeArray<T> BNCNFDPJJBL<T>(this NativeArray<T> FAJBEEIFFCK, int IJNJPAGKLKM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BNGONCHMFOM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x293B5D0", Offset = "0x2939BD0", VA = "0x18293B5D0")]
	public static string LDIPFPOEADK<T>(this NativeArray<T> FAJBEEIFFCK, string IMBOBCBBAPA = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PNMBJOBFKJA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D47B10", Offset = "0x2D46110", VA = "0x182D47B10")]
	public static T FOHHCFMHKPE<T>([In] this ReadOnlySpan<byte> POCCCFEGFEF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2D48AC0", Offset = "0x2D470C0", VA = "0x182D48AC0")]
	public static NativeArray<T> FOLHPHAOFMM<T>(this ReadOnlySpan<byte> POCCCFEGFEF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D23360", Offset = "0x2D21960", VA = "0x182D23360")]
	public static ReadOnlySpan<TTo> IEONNGCGOCF<TTo, TFrom>(this ReadOnlySpan<TFrom> POCCCFEGFEF) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2D46870", Offset = "0x2D44E70", VA = "0x182D46870")]
	public static Span<byte> ECADPABFBJL<T>([In] this Span<byte> POCCCFEGFEF, T DMNGPNKHPKF) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69FEB70", Offset = "0x69FD170", VA = "0x1869FEB70")]
	private static Enum LIOAMGPOEKF([In] ReadOnlySpan<byte> POCCCFEGFEF, Type KODGOOBOLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69FF110", Offset = "0x69FD710", VA = "0x1869FF110")]
	public static Enum MIPBHCKEMJE([In] this Span<byte> POCCCFEGFEF, Type KODGOOBOLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69FE660", Offset = "0x69FCC60", VA = "0x1869FE660")]
	public static void DPNLHDBCFAG([In] this Span<byte> POCCCFEGFEF, Enum ANPOJJGGDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FCHMAFDGINJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GNPHCAGNBGA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69FDFE0", Offset = "0x69FC5E0", VA = "0x1869FDFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69FDC40", Offset = "0x69FC240", VA = "0x1869FDC40")]
	[AsyncStateMachine(typeof(GNPHCAGNBGA))]
	public static void FECHEEMJNHB(this Task FCNFHCDDANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LINENKOMAIC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum OFDLGAKIKCO : short
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Uncategorized = 4,
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

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ELCCBANAEAG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly OFDLGAKIKCO IBBDLGCDELM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2585950", Offset = "0x2583F50", VA = "0x182585950")]
		public ELCCBANAEAG(OFDLGAKIKCO IBBDLGCDELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory KJMDOBJEJGB;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	public static void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69FE560", Offset = "0x69FCB60", VA = "0x1869FE560")]
	static LINENKOMAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28A6A40", Offset = "0x28A5040", VA = "0x1828A6A40")]
	public static ELCCBANAEAG NBGDGIINNAC(OFDLGAKIKCO IBBDLGCDELM)
	{
		return default(ELCCBANAEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	public static void HKBFCDLPBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class PAFELJNLCII<THandle, TValue> : IDisposable where THandle : struct, DOGEODOABCA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> KMMNMMLCLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> EJHPODPBOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> JDBBINAFBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> IAHKPCDOOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int JOGOGEBPAIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x478F7C0", Offset = "0x478DDC0", VA = "0x18478F7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x478FC70", Offset = "0x478E270", VA = "0x18478FC70")]
	public PAFELJNLCII(Action<TValue> IAHKPCDOOAM, [Optional] Func<TValue> JDBBINAFBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x478F140", Offset = "0x478D740", VA = "0x18478F140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x478F710", Offset = "0x478DD10", VA = "0x18478F710")]
	public THandle LHEPNGLDBLI(TValue DMNGPNKHPKF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x478F520", Offset = "0x478DB20", VA = "0x18478F520")]
	public bool IHOPKBJIMEI(THandle FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x478F220", Offset = "0x478D820", VA = "0x18478F220")]
	public bool EGCGJKFAAFH(THandle FPDGNDMPHII, [Out] TValue DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x478F410", Offset = "0x478DA10", VA = "0x18478F410")]
	public TValue FOHHCFMHKPE(THandle FPDGNDMPHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x478F2F0", Offset = "0x478D8F0", VA = "0x18478F2F0")]
	public bool ELDMDCADOCM(THandle FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x478F470", Offset = "0x478DA70", VA = "0x18478F470")]
	private THandle GGOJGNPOHHG(int PDMMEDBMFPP)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x478EE40", Offset = "0x478D440", VA = "0x18478EE40")]
	private TValue AACDCMAOBJC(int PDMMEDBMFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x478F800", Offset = "0x478DE00", VA = "0x18478F800")]
	private void OAMJJMGBFDA(int PDMMEDBMFPP, [In] THandle FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x478F4D0", Offset = "0x478DAD0", VA = "0x18478F4D0")]
	private void IFICIMIEIPO(int PDMMEDBMFPP, [In] TValue DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x478F850", Offset = "0x478DE50", VA = "0x18478F850")]
	private THandle OOJLPBKHPDO()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x478FA10", Offset = "0x478E010", VA = "0x18478FA10")]
	private void PCFLBLFACDI(THandle FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x478F120", Offset = "0x478D720", VA = "0x18478F120")]
	private int BMCBMDPOOJP(int CICFELNCFMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x478F130", Offset = "0x478D730", VA = "0x18478F130")]
	private bool CKNLOAKPLIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x874EB0", Offset = "0x8734B0", VA = "0x180874EB0")]
	private void KCNEADGKKEA(THandle FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x478EEA0", Offset = "0x478D4A0", VA = "0x18478EEA0")]
	private bool BJMGJPFEDPI([Out] THandle FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x478FB30", Offset = "0x478E130", VA = "0x18478FB30")]
	private bool PGAKLAPFBFC([Out] THandle FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x478F650", Offset = "0x478DC50", VA = "0x18478F650")]
	private void JEGNKIKEONH(THandle FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x478EF60", Offset = "0x478D560", VA = "0x18478EF60")]
	private void BKAEOLENJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DOGEODOABCA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HDIHKFJHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IOFPLDEHHNL
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0000", Offset = "0x2BDE600", VA = "0x182BE0000")]
	public static bool CDHAKOPEGPK<T>(this T FPDGNDMPHII, T BHFGHGMPKOJ) where T : struct, DOGEODOABCA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0020", Offset = "0x2BDE620", VA = "0x182BE0020")]
	public static bool IPGIKMPLLND<T>(this T FPDGNDMPHII) where T : struct, DOGEODOABCA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69FE160", Offset = "0x69FC760", VA = "0x1869FE160")]
	public static string HMDPMILKLAA(this DOGEODOABCA FPDGNDMPHII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct KDNOALABLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type NNCFHDGNJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> DLDENGOBPAM;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x42B0070", Offset = "0x42AE670", VA = "0x1842B0070")]
	public KDNOALABLGK(Type KHBLNMAOCGA, Span<byte> POCCCFEGFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C35B10", Offset = "0x2C34110", VA = "0x182C35B10")]
	public static KDNOALABLGK AOLCCKEJHHA<T>(T DMNGPNKHPKF) where T : struct
	{
		return default(KDNOALABLGK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69FE280", Offset = "0x69FC880", VA = "0x1869FE280")]
	public static FIEGLLHKFJI HDKGBCFDEBL([In] KDNOALABLGK JPKMILJIBCP)
	{
		return default(FIEGLLHKFJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69FE300", Offset = "0x69FC900", VA = "0x1869FE300")]
	public Enum MIPBHCKEMJE(Type KODGOOBOLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C36C90", Offset = "0x2C35290", VA = "0x182C36C90")]
	public void ECADPABFBJL<T>([In] T DMNGPNKHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69FE270", Offset = "0x69FC870", VA = "0x1869FE270")]
	public void DPNLHDBCFAG(Enum ANPOJJGGDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct FIEGLLHKFJI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct HHHDOCHGCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* GKKODBNLEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* JNHCBBLBFFJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type NNCFHDGNJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> DLDENGOBPAM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FPMEMCFLMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69FDE90", Offset = "0x69FC490", VA = "0x1869FDE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x42B0070", Offset = "0x42AE670", VA = "0x1842B0070")]
	public FIEGLLHKFJI(Type KHBLNMAOCGA, ReadOnlySpan<byte> POCCCFEGFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B80CF0", Offset = "0x2B7F2F0", VA = "0x182B80CF0")]
	public static FIEGLLHKFJI AOLCCKEJHHA<T>(T DMNGPNKHPKF) where T : struct
	{
		return default(FIEGLLHKFJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B80E30", Offset = "0x2B7F430", VA = "0x182B80E30")]
	public static FIEGLLHKFJI AOLCCKEJHHA<T>(NativeArray<T> DMNGPNKHPKF) where T : struct
	{
		return default(FIEGLLHKFJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69FDED0", Offset = "0x69FC4D0", VA = "0x1869FDED0")]
	public void DGCLHGFMGCI(NativeArray<byte> LBPFDLMHGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2B838E0", Offset = "0x2B81EE0", VA = "0x182B838E0")]
	public T FOHHCFMHKPE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B83A90", Offset = "0x2B82090", VA = "0x182B83A90")]
	public NativeArray<T> FOLHPHAOFMM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69FDFA0", Offset = "0x69FC5A0", VA = "0x1869FDFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69FDD60", Offset = "0x69FC360", VA = "0x1869FDD60")]
	private object CJABBBOKEEN()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GEGPHJHAGFF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B92E40", Offset = "0x2B91440", VA = "0x182B92E40")]
	public static NativeArray<T> GEINIJPMDPL<T>(T DMNGPNKHPKF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B92DF0", Offset = "0x2B913F0", VA = "0x182B92DF0")]
	public static NativeArray<T> AOLCCKEJHHA<T>(T DMNGPNKHPKF, bool OLDPDAFLNJG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JNCGOABIBDE<Handle> where Handle : DOGEODOABCA, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct IAJNIAFAODD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly JNCGOABIBDE<Handle> BABPFPJMACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int PDMMEDBMFPP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle FABKMJDMFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3E49E60", Offset = "0x3E48460", VA = "0x183E49E60")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A340", Offset = "0x3E48940", VA = "0x183E4A340")]
		public IAJNIAFAODD(JNCGOABIBDE<Handle> BABPFPJMACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3E49AC0", Offset = "0x3E480C0", VA = "0x183E49AC0")]
		public NDHILNKNAJN ENFOKLPNHAF([In] NDHILNKNAJN INKFLMKONLP)
		{
			return default(NDHILNKNAJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3E49FE0", Offset = "0x3E485E0", VA = "0x183E49FE0")]
		public bool HNHNGOHHPDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3E499A0", Offset = "0x3E47FA0", VA = "0x183E499A0")]
		private Handle EDDJLPCBEFD(string ELIMFPDKMPD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct NDHILNKNAJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private IAJNIAFAODD JICMKACJBON;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x455DAE0", Offset = "0x455C0E0", VA = "0x18455DAE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x455DB20", Offset = "0x455C120", VA = "0x18455DB20")]
		public NDHILNKNAJN(JNCGOABIBDE<Handle> BABPFPJMACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x455D9E0", Offset = "0x455BFE0", VA = "0x18455D9E0")]
		public bool HNHNGOHHPDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x455D920", Offset = "0x455BF20", VA = "0x18455D920")]
		public NDHILNKNAJN GGGADAADMEJ()
		{
			return default(NDHILNKNAJN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> POOFPFGIDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> HACHBBJHJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int OIDEPHDDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int MFKALMCJGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool LDOCKJPJEMK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LDAFFHKGGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x40A3D00", Offset = "0x40A2300", VA = "0x1840A3D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NDHILNKNAJN KMBFKFCMNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x40A52A0", Offset = "0x40A38A0", VA = "0x1840A52A0")]
		get
		{
			return default(NDHILNKNAJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40A60A0", Offset = "0x40A46A0", VA = "0x1840A60A0")]
	public JNCGOABIBDE(int BHKHFILLELG, Allocator KOIILCBLJPK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40A3E40", Offset = "0x40A2440", VA = "0x1840A3E40")]
	public void EKANILNIIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1907A10", Offset = "0x1906010", VA = "0x181907A10")]
	public static int BMCBMDPOOJP(int HAHPKMHGFDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x25ADE30", Offset = "0x25AC430", VA = "0x1825ADE30")]
	public static bool FNOLLMCJMLD(int HAHPKMHGFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x40A3810", Offset = "0x40A1E10", VA = "0x1840A3810")]
	public bool CKEGLPAIKIO(int PDMMEDBMFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40A43C0", Offset = "0x40A29C0", VA = "0x1840A43C0")]
	public bool FDNLPBMAKMJ(Handle FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40A51D0", Offset = "0x40A37D0", VA = "0x1840A51D0")]
	public Handle KMOHDKCNCHB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40A5340", Offset = "0x40A3940", VA = "0x1840A5340")]
	public void NCIFCDDGCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40A4850", Offset = "0x40A2E50", VA = "0x1840A4850")]
	public void HOPIKIJDHIF(Handle FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40A4F80", Offset = "0x40A3580", VA = "0x1840A4F80")]
	public bool KKKPBBMOMPP(Handle FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xAA5760", Offset = "0xAA3D60", VA = "0x180AA5760")]
	private bool BENAAKDOBLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40A3C00", Offset = "0x40A2200", VA = "0x1840A3C00")]
	private bool DIGCGEBOLMM(int PDMMEDBMFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x40A49A0", Offset = "0x40A2FA0", VA = "0x1840A49A0")]
	private void JJOKIIJCKIG([Out] int PDMMEDBMFPP, [Out] int CICFELNCFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40A4270", Offset = "0x40A2870", VA = "0x1840A4270")]
	private void ENMKLOBBLJM(Handle FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40A3610", Offset = "0x40A1C10", VA = "0x1840A3610")]
	private void AGGLOKOFBBC(int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40A5DA0", Offset = "0x40A43A0", VA = "0x1840A5DA0")]
	private bool PCLDDCDPBAJ([Out] int PDMMEDBMFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40A3660", Offset = "0x40A1C60", VA = "0x1840A3660")]
	private static Handle BHDCJPMNGJC(int PDMMEDBMFPP, int CICFELNCFMD)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct KAGJGDFHLAL<Handle, T> where Handle : DOGEODOABCA, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JNCGOABIBDE<Handle> CNNFKFAOPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] AJNEMINIDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> DJODAPAMBKE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4167BC0", Offset = "0x41661C0", VA = "0x184167BC0")]
	public KAGJGDFHLAL(int BHKHFILLELG, [Optional] Action<T> DJODAPAMBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x41664F0", Offset = "0x4164AF0", VA = "0x1841664F0")]
	public void EKANILNIIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41663B0", Offset = "0x41649B0", VA = "0x1841663B0")]
	public bool EGCGJKFAAFH(Handle FPDGNDMPHII, [Out] T NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4167260", Offset = "0x4165860", VA = "0x184167260")]
	public Handle LHEPNGLDBLI(T NJKKPOFFNNJ)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4167010", Offset = "0x4165610", VA = "0x184167010")]
	public void LFDAOHBAJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4166990", Offset = "0x4164F90", VA = "0x184166990")]
	public void HHOKGKJNBNI(Handle FPDGNDMPHII, [Out] T ONJAALJHGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x41667D0", Offset = "0x4164DD0", VA = "0x1841667D0")]
	public void HHOKGKJNBNI(Handle FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x41678F0", Offset = "0x4165EF0", VA = "0x1841678F0")]
	public bool OGIDIIPHAMP(Handle FPDGNDMPHII, [Out] T ONJAALJHGJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4167AD0", Offset = "0x41660D0", VA = "0x184167AD0")]
	public bool OGIDIIPHAMP(Handle FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x41675B0", Offset = "0x4165BB0", VA = "0x1841675B0")]
	private T MJIDLAPDOJN(int PDMMEDBMFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4166170", Offset = "0x4164770", VA = "0x184166170")]
	private void BHKBBAJKBFL(int KNIENLIDBLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct IBJHKNDIOGA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] MMDLBEBNCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int JOCLJBACIHN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2A35080", Offset = "0x2A33680", VA = "0x182A35080")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> DLDENGOBPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3E50DC0", Offset = "0x3E4F3C0", VA = "0x183E50DC0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ANHMLBKHNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xEAC300", Offset = "0xEAA900", VA = "0x180EAC300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3E510F0", Offset = "0x3E4F6F0", VA = "0x183E510F0")]
	public IBJHKNDIOGA(int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E51040", Offset = "0x3E4F640", VA = "0x183E51040")]
	public int LFCMAHLPLCN(T DMNGPNKHPKF, int IJNJPAGKLKM, int BMKFLHFENBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3E50E60", Offset = "0x3E4F460", VA = "0x183E50E60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct GKFBNGBAJIH<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct HODHIDFPGEO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private GKFBNGBAJIH<T> DEPHDEBCNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int PDMMEDBMFPP;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3DB44D0", Offset = "0x3DB2AD0", VA = "0x183DB44D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3DB4570", Offset = "0x3DB2B70", VA = "0x183DB4570", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3DB4540", Offset = "0x3DB2B40", VA = "0x183DB4540")]
		public HODHIDFPGEO(GKFBNGBAJIH<T> DEPHDEBCNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3DB4440", Offset = "0x3DB2A40", VA = "0x183DB4440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3DB4480", Offset = "0x3DB2A80", VA = "0x183DB4480", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private IBJHKNDIOGA<T> MMDLBEBNCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int JOCLJBACIHN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D35C10", Offset = "0x3D34210", VA = "0x183D35C10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3D35030", Offset = "0x3D33630", VA = "0x183D35030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LDAFFHKGGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D354E0", Offset = "0x3D33AE0", VA = "0x183D354E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ANHMLBKHNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3D35DF0", Offset = "0x3D343F0", VA = "0x183D35DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> DLDENGOBPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3D353C0", Offset = "0x3D339C0", VA = "0x183D353C0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3D35EE0", Offset = "0x3D344E0", VA = "0x183D35EE0")]
	public GKFBNGBAJIH(int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D35480", Offset = "0x3D33A80", VA = "0x183D35480")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D35B00", Offset = "0x3D34100", VA = "0x183D35B00")]
	public void LHEPNGLDBLI(T DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D35550", Offset = "0x3D33B50", VA = "0x183D35550")]
	internal void FEAGIEMEIPO(int PLGOIBDCNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D35080", Offset = "0x3D33680", VA = "0x183D35080")]
	public void BCLFMGIHKHF(int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D35170", Offset = "0x3D33770", VA = "0x183D35170")]
	public void BMJMABEJMPD(int CGDMLDDMFIF, int ENJFDDOBAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D35A80", Offset = "0x3D34080", VA = "0x183D35A80")]
	public int LFCMAHLPLCN(T DMNGPNKHPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D35510", Offset = "0x3D33B10", VA = "0x183D35510", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D359A0", Offset = "0x3D33FA0", VA = "0x183D359A0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D35E30", Offset = "0x3D34430", VA = "0x183D35E30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D35E70", Offset = "0x3D34470", VA = "0x183D35E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D35CA0", Offset = "0x3D342A0", VA = "0x183D35CA0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void MNFBGONPMOG(int DMNGPNKHPKF, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D35790", Offset = "0x3D33D90", VA = "0x183D35790")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GHIFGDNNCBF(int CGDMLDDMFIF, int ENJFDDOBAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BEGHBKAAGJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int GCMGLJCEDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int BMKFLHFENBJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int MLKNMOMOHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2910", Offset = "0x5DD0F10", VA = "0x185DD2910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NGGHNELCOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int CHPBHFGPOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69FDA40", Offset = "0x69FC040", VA = "0x1869FDA40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69FDA20", Offset = "0x69FC020", VA = "0x1869FDA20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
	private BEGHBKAAGJH(int GCMGLJCEDLO, int BMKFLHFENBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x200BDD0", Offset = "0x200A3D0", VA = "0x18200BDD0")]
	public static BEGHBKAAGJH IKHINJFILIJ(int GCMGLJCEDLO, int BMKFLHFENBJ)
	{
		return default(BEGHBKAAGJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69FDA30", Offset = "0x69FC030", VA = "0x1869FDA30")]
	public static BEGHBKAAGJH GPABCIAGEGH(int IJNJPAGKLKM, int ENJFDDOBAJP)
	{
		return default(BEGHBKAAGJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69FDA50", Offset = "0x69FC050", VA = "0x1869FDA50", Slot = "3")]
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
