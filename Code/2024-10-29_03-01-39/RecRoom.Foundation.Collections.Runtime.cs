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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFB00", Offset = "0x6EAEB00", VA = "0x186EAFB00", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LHBIJLCKLGA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF920", Offset = "0x6EAE920", VA = "0x186EAF920")]
	public static void CCGKBEMNPKB(this GameObject IEELEEMHGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFA60", Offset = "0x6EAEA60", VA = "0x186EAFA60")]
	public static void CCGKBEMNPKB(this Component GEICOLLOJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF9C0", Offset = "0x6EAE9C0", VA = "0x186EAF9C0")]
	public static void CCGKBEMNPKB(this ScriptableObject JNKAKJKHBBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CBKAIBDFKJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE810", Offset = "0x6EAD810", VA = "0x186EAE810")]
	public static Span<byte> EHIHDIECHBF(this NativeArray<byte> CHPMBGHOEJI)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE8C0", Offset = "0x6EAD8C0", VA = "0x186EAE8C0")]
	public static ReadOnlySpan<byte> POKKJDJMBAB(this NativeArray<byte> CHPMBGHOEJI)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D60AA0", Offset = "0x2D5FAA0", VA = "0x182D60AA0")]
	public static NativeArray<T> IBOPNONMPHN<T>(this NativeArray<T> CHPMBGHOEJI, BPODBOELFJH FMPNIOHIOBP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D60A60", Offset = "0x2D5FA60", VA = "0x182D60A60")]
	public static NativeArray<T> IBOPNONMPHN<T>(this NativeArray<T> CHPMBGHOEJI, int NOAHCMMOGGC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BPBKNECFMKF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D04C10", Offset = "0x2D03C10", VA = "0x182D04C10")]
	public static string OKFEKDJEBEF<T>(this NativeArray<T> CHPMBGHOEJI, string LPFBPJCNGLI = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CELHGBJBLBC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D65370", Offset = "0x2D64370", VA = "0x182D65370")]
	public static T KIJHOBDIGPJ<T>([In] this ReadOnlySpan<byte> LFKEGNIJPKG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2D65A70", Offset = "0x2D64A70", VA = "0x182D65A70")]
	public static T KIJHOBDIGPJ<T>([In] this Span<byte> LFKEGNIJPKG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D67710", Offset = "0x2D66710", VA = "0x182D67710")]
	public static NativeArray<T> PJNALGJFBCI<T>(this ReadOnlySpan<byte> LFKEGNIJPKG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2D65080", Offset = "0x2D64080", VA = "0x182D65080")]
	public static ReadOnlySpan<TTo> BCHKOBCAMGI<TTo, TFrom>(this ReadOnlySpan<TFrom> LFKEGNIJPKG) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D66570", Offset = "0x2D65570", VA = "0x182D66570")]
	public static Span<byte> NONCGFKLPGD<T>([In] this Span<byte> LFKEGNIJPKG, T BJDKOHEGDOK) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEE50", Offset = "0x6EADE50", VA = "0x186EAEE50")]
	private static Enum KDGFDBCKLDO([In] ReadOnlySpan<byte> LFKEGNIJPKG, Type NFICGGNDBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF3F0", Offset = "0x6EAE3F0", VA = "0x186EAF3F0")]
	public static Enum LOHIOLDIGKM([In] this Span<byte> LFKEGNIJPKG, Type NFICGGNDBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE970", Offset = "0x6EAD970", VA = "0x186EAE970")]
	public static void FJMAMLCIJBO([In] this Span<byte> LFKEGNIJPKG, Enum FIAIOBCELLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IILHHFCCMEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LCMLJKLHMAH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF7A0", Offset = "0x6EAE7A0", VA = "0x186EAF7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF680", Offset = "0x6EAE680", VA = "0x186EAF680")]
	[AsyncStateMachine(typeof(LCMLJKLHMAH))]
	public static void HDNGKGOOPIK(this Task JJJGJKKAJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PMNHDMIKGDA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum BNJGOODDNGO : short
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
	public struct CAKABKAKNKE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly BNJGOODDNGO MLAECOMLIEC;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28A2940", Offset = "0x28A1940", VA = "0x1828A2940")]
		public CAKABKAKNKE(BNJGOODDNGO MLAECOMLIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory GGGCMBBMAME;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	public static void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFE70", Offset = "0x6EAEE70", VA = "0x186EAFE70")]
	static PMNHDMIKGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C7E0", Offset = "0x2C5B7E0", VA = "0x182C5C7E0")]
	public static CAKABKAKNKE KLAPFJAEOCC(BNJGOODDNGO MLAECOMLIEC)
	{
		return default(CAKABKAKNKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	public static void MIDAIBMDNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class KAJONLPBDNM<THandle, TValue> : IDisposable where THandle : struct, JGFOKCMIJII where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> CAAEFBINFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> CMDOFHABOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> DBBHABJHIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> FLAEKDJOKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int KAHMKAHGJID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x465FC80", Offset = "0x465EC80", VA = "0x18465FC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4660060", Offset = "0x465F060", VA = "0x184660060")]
	public KAJONLPBDNM(Action<TValue> FLAEKDJOKLN, [Optional] Func<TValue> DBBHABJHIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x465F720", Offset = "0x465E720", VA = "0x18465F720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x465FDF0", Offset = "0x465EDF0", VA = "0x18465FDF0")]
	public THandle OPFOFHIGBEE(TValue BJDKOHEGDOK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x465F4B0", Offset = "0x465E4B0", VA = "0x18465F4B0")]
	public bool BACJDAIFIKJ(THandle GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x465FD20", Offset = "0x465ED20", VA = "0x18465FD20")]
	public bool OKBNAJGEJDO(THandle GCBNNIKBPHJ, [Out] TValue BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x465FB50", Offset = "0x465EB50", VA = "0x18465FB50")]
	public TValue KIJHOBDIGPJ(THandle GCBNNIKBPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x465FA30", Offset = "0x465EA30", VA = "0x18465FA30")]
	public bool KDIAAAJKNAC(THandle GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x465FCC0", Offset = "0x465ECC0", VA = "0x18465FCC0")]
	private THandle NDKLIIJHJGG(int KHAIDMGPIED)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x465F9D0", Offset = "0x465E9D0", VA = "0x18465F9D0")]
	private TValue JAEBKCPHLDG(int KHAIDMGPIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x465F970", Offset = "0x465E970", VA = "0x18465F970")]
	private void HKMKDEDFOCO(int KHAIDMGPIED, [In] THandle GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x465F920", Offset = "0x465E920", VA = "0x18465F920")]
	private void GLDBPDCBPPC(int KHAIDMGPIED, [In] TValue BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x465FEA0", Offset = "0x465EEA0", VA = "0x18465FEA0")]
	private THandle PIICAHBNOPC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x465F800", Offset = "0x465E800", VA = "0x18465F800")]
	private void EIBLONHMMFP(THandle GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x465FBB0", Offset = "0x465EBB0", VA = "0x18465FBB0")]
	private int LDINKMNNEMD(int FNBFBBNHKCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x465F9C0", Offset = "0x465E9C0", VA = "0x18465F9C0")]
	private bool HPCGCLDJFPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8C34A0", Offset = "0x8C24A0", VA = "0x1808C34A0")]
	private void MIFCPIANLMB(THandle GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x465FBC0", Offset = "0x465EBC0", VA = "0x18465FBC0")]
	private bool MOCCBCKODOP([Out] THandle GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x465F5E0", Offset = "0x465E5E0", VA = "0x18465F5E0")]
	private bool CNCGJJDLDCE([Out] THandle GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x465F3F0", Offset = "0x465E3F0", VA = "0x18465F3F0")]
	private void AMDLNHMIHEB(THandle GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x465F230", Offset = "0x465E230", VA = "0x18465F230")]
	private void ACMNBEAGDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JGFOKCMIJII
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int HOLNAIGPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ECKOFMKJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HLIPOKAPKPD
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2F95500", Offset = "0x2F94500", VA = "0x182F95500")]
	public static bool JKCPMKNGKBH<T>(this T GCBNNIKBPHJ, T DFABCHNPEEM) where T : struct, JGFOKCMIJII
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2F95520", Offset = "0x2F94520", VA = "0x182F95520")]
	public static bool MNCIMEONHOG<T>(this T GCBNNIKBPHJ) where T : struct, JGFOKCMIJII
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF570", Offset = "0x6EAE570", VA = "0x186EAF570")]
	public static string LKHNLJPIIPJ(this JGFOKCMIJII GCBNNIKBPHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct DJEENCMJKNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type CDMHHCFHMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> FMMIPDEBFAP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x470D130", Offset = "0x470C130", VA = "0x18470D130")]
	public DJEENCMJKNM(Type ACEFOHJDFFL, Span<byte> LFKEGNIJPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2DBBC20", Offset = "0x2DBAC20", VA = "0x182DBBC20")]
	public static DJEENCMJKNM DPIOBCKIDMC<T>(T BJDKOHEGDOK) where T : struct
	{
		return default(DJEENCMJKNM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF470", Offset = "0x6EAE470", VA = "0x186EAF470")]
	public static NAIOMCDFHCH ILBKFABDDDI([In] DJEENCMJKNM AAGDOBFBLJM)
	{
		return default(NAIOMCDFHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCF40", Offset = "0x2DBBF40", VA = "0x182DBCF40")]
	public T KIJHOBDIGPJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF4F0", Offset = "0x6EAE4F0", VA = "0x186EAF4F0")]
	public Enum LOHIOLDIGKM(Type NFICGGNDBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCFF0", Offset = "0x2DBBFF0", VA = "0x182DBCFF0")]
	public void NONCGFKLPGD<T>([In] T BJDKOHEGDOK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF460", Offset = "0x6EAE460", VA = "0x186EAF460")]
	public void FJMAMLCIJBO(Enum FIAIOBCELLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct NAIOMCDFHCH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct BBPMGHPCPCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* CAGJPPLOGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* ANNAKBBPIHH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type CDMHHCFHMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> FMMIPDEBFAP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IIJOJMFBBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFCC0", Offset = "0x6EAECC0", VA = "0x186EAFCC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x470D130", Offset = "0x470C130", VA = "0x18470D130")]
	public NAIOMCDFHCH(Type ACEFOHJDFFL, ReadOnlySpan<byte> LFKEGNIJPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x30E5CD0", Offset = "0x30E4CD0", VA = "0x1830E5CD0")]
	public static NAIOMCDFHCH DPIOBCKIDMC<T>(T BJDKOHEGDOK) where T : struct
	{
		return default(NAIOMCDFHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x30E5B50", Offset = "0x30E4B50", VA = "0x1830E5B50")]
	public static NAIOMCDFHCH DPIOBCKIDMC<T>(NativeArray<T> BJDKOHEGDOK) where T : struct
	{
		return default(NAIOMCDFHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFD00", Offset = "0x6EAED00", VA = "0x186EAFD00")]
	public void NNFEGMMHAAH(Span<byte> KJMIODKMJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFD60", Offset = "0x6EAED60", VA = "0x186EAFD60")]
	public void NNFEGMMHAAH(NativeArray<byte> KJMIODKMJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x30E8C90", Offset = "0x30E7C90", VA = "0x1830E8C90")]
	public T KIJHOBDIGPJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3110EE0", Offset = "0x310FEE0", VA = "0x183110EE0")]
	public NativeArray<T> PJNALGJFBCI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFE30", Offset = "0x6EAEE30", VA = "0x186EAFE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFB90", Offset = "0x6EAEB90", VA = "0x186EAFB90")]
	private object AOFELMIDFDA()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LAJMMHMGBLI
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x30405B0", Offset = "0x303F5B0", VA = "0x1830405B0")]
	public static NativeArray<T> MBANLDHJBHL<T>(T BJDKOHEGDOK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3040560", Offset = "0x303F560", VA = "0x183040560")]
	public static NativeArray<T> KIJJNKFCDDA<T>(T BJDKOHEGDOK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3040510", Offset = "0x303F510", VA = "0x183040510")]
	public static NativeArray<T> DPIOBCKIDMC<T>(T BJDKOHEGDOK, bool DAPPHDLLBJN) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ELANCOHCCAI<Handle> where Handle : JGFOKCMIJII, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct FALEGOKOJGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ELANCOHCCAI<Handle> KFPDBBNOEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int KHAIDMGPIED;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle FNHKODDHIBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3FEE070", Offset = "0x3FED070", VA = "0x183FEE070")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE1F0", Offset = "0x3FED1F0", VA = "0x183FEE1F0")]
		public FALEGOKOJGA(ELANCOHCCAI<Handle> KFPDBBNOEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3FED970", Offset = "0x3FEC970", VA = "0x183FED970")]
		public NDJMNIOPHLO EJLELCHFLID([In] NDJMNIOPHLO BEELICCCBAC)
		{
			return default(NDJMNIOPHLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3FEDB30", Offset = "0x3FECB30", VA = "0x183FEDB30")]
		public bool IFOGALALJEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3FED8B0", Offset = "0x3FEC8B0", VA = "0x183FED8B0")]
		private Handle CBCNFJKEBNI(string ABHPFCOODAJ)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct NDJMNIOPHLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private FALEGOKOJGA EPBOKEOGBEL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x49C5980", Offset = "0x49C4980", VA = "0x1849C5980")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x49C59C0", Offset = "0x49C49C0", VA = "0x1849C59C0")]
		public NDJMNIOPHLO(ELANCOHCCAI<Handle> KFPDBBNOEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x49C5880", Offset = "0x49C4880", VA = "0x1849C5880")]
		public bool IFOGALALJEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x49C57C0", Offset = "0x49C47C0", VA = "0x1849C57C0")]
		public NDJMNIOPHLO EMFBOAAPBLH()
		{
			return default(NDJMNIOPHLO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> BLMLFEKLFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> CNJBGHJNIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int PBIDFFLLLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int JNAFLDNOGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool FLFHNBONEJC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LMAJBADMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A920", Offset = "0x3C69920", VA = "0x183C6A920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NDJMNIOPHLO IAMGNFEFOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C69AF0", Offset = "0x3C68AF0", VA = "0x183C69AF0")]
		get
		{
			return default(NDJMNIOPHLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A960", Offset = "0x3C69960", VA = "0x183C6A960")]
	public ELANCOHCCAI(int GBJJLLONKID, Allocator HHJAFJNPHLL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3C69970", Offset = "0x3C68970", VA = "0x183C69970")]
	public void HHBFEMLFOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C61000", Offset = "0x1C60000", VA = "0x181C61000")]
	public static int LDINKMNNEMD(int DEGBNBIJGGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28C8FD0", Offset = "0x28C7FD0", VA = "0x1828C8FD0")]
	public static bool NDOGCGLKPKK(int DEGBNBIJGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3C68CA0", Offset = "0x3C67CA0", VA = "0x183C68CA0")]
	public bool GHPFMHNEHCE(int KHAIDMGPIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A120", Offset = "0x3C69120", VA = "0x183C6A120")]
	public bool JFDLCGEDFLB(Handle GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A7D0", Offset = "0x3C697D0", VA = "0x183C6A7D0")]
	public Handle KKGKHKKCMKM()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C69250", Offset = "0x3C68250", VA = "0x183C69250")]
	public void HDHKNFLBCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3C680C0", Offset = "0x3C670C0", VA = "0x183C680C0")]
	public void APPIMLLOCON(Handle GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A580", Offset = "0x3C69580", VA = "0x183C6A580")]
	public bool JJGGPMFBJPD(Handle GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xA39CA0", Offset = "0xA38CA0", VA = "0x180A39CA0")]
	private bool ELHNOBOGFCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3C682D0", Offset = "0x3C672D0", VA = "0x183C682D0")]
	private bool CCOOMNNFOFF(int KHAIDMGPIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3C684B0", Offset = "0x3C674B0", VA = "0x183C684B0")]
	private void DECOBDLLGEE([Out] int KHAIDMGPIED, [Out] int FNBFBBNHKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3C69B90", Offset = "0x3C68B90", VA = "0x183C69B90")]
	private void IFPCCFKIMPB(Handle GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3C67FD0", Offset = "0x3C66FD0", VA = "0x183C67FD0")]
	private void AEDJHLLPCMB(int KHAIDMGPIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3C68860", Offset = "0x3C67860", VA = "0x183C68860")]
	private bool EAIBFFAMAMI([Out] int KHAIDMGPIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3C689C0", Offset = "0x3C679C0", VA = "0x183C689C0")]
	private static Handle EJOPBNGKPPI(int KHAIDMGPIED, int FNBFBBNHKCM)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct FAKCOAFGPJL<Handle, T> where Handle : JGFOKCMIJII, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ELANCOHCCAI<Handle> CONOIDEFPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] GNMPMLEEKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> AONMDCGGMBF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3FED670", Offset = "0x3FEC670", VA = "0x183FED670")]
	public FAKCOAFGPJL(int GBJJLLONKID, [Optional] Action<T> AONMDCGGMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC1E0", Offset = "0x3FEB1E0", VA = "0x183FEC1E0")]
	public void HHBFEMLFOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3FED0D0", Offset = "0x3FEC0D0", VA = "0x183FED0D0")]
	public bool OKBNAJGEJDO(Handle GCBNNIKBPHJ, [Out] T IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3FED360", Offset = "0x3FEC360", VA = "0x183FED360")]
	public Handle OPFOFHIGBEE(T IFPBFCLBBDP)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3FECDB0", Offset = "0x3FEBDB0", VA = "0x183FECDB0")]
	public void NNNHAEMGIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3FEBDD0", Offset = "0x3FEADD0", VA = "0x183FEBDD0")]
	public void CAKBCGBONLK(Handle GCBNNIKBPHJ, [Out] T FNDAJKKHDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3FEBB30", Offset = "0x3FEAB30", VA = "0x183FEBB30")]
	public void CAKBCGBONLK(Handle GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC7C0", Offset = "0x3FEB7C0", VA = "0x183FEC7C0")]
	public bool HLAJGHHAAMA(Handle GCBNNIKBPHJ, [Out] T FNDAJKKHDEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC6D0", Offset = "0x3FEB6D0", VA = "0x183FEC6D0")]
	public bool HLAJGHHAAMA(Handle GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC8B0", Offset = "0x3FEB8B0", VA = "0x183FEC8B0")]
	private T LEOGEMHIBKE(int KHAIDMGPIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC090", Offset = "0x3FEB090", VA = "0x183FEC090")]
	private void GOEKKGAIJOE(int BINCBFPFAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct HBDFIPKAAMA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] CONAFKKIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int CDEEBECPNGB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AAOLGFOFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x22F9A20", Offset = "0x22F8A20", VA = "0x1822F9A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA2D0", Offset = "0x2DD92D0", VA = "0x182DDA2D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> FMMIPDEBFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x41D6C80", Offset = "0x41D5C80", VA = "0x1841D6C80")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OPPNLAPBCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1277C60", Offset = "0x1276C60", VA = "0x181277C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x41D6D20", Offset = "0x41D5D20", VA = "0x1841D6D20")]
	public HBDFIPKAAMA(int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x41D6AC0", Offset = "0x41D5AC0", VA = "0x1841D6AC0")]
	public int ALPEADNKMBM(T BJDKOHEGDOK, int NOAHCMMOGGC, int DCEOMHJEBBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x41D6B70", Offset = "0x41D5B70", VA = "0x1841D6B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct AEBIOGGIKME<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct DLFGMMPGBCH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private AEBIOGGIKME<T> AKKGGCHEPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int KHAIDMGPIED;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5DC3BB0", Offset = "0x5DC2BB0", VA = "0x185DC3BB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5DC3C50", Offset = "0x5DC2C50", VA = "0x185DC3C50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3C20", Offset = "0x5DC2C20", VA = "0x185DC3C20")]
		public DLFGMMPGBCH(AEBIOGGIKME<T> AKKGGCHEPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3B20", Offset = "0x5DC2B20", VA = "0x185DC3B20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3B60", Offset = "0x5DC2B60", VA = "0x185DC3B60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HBDFIPKAAMA<T> CONAFKKIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int CDEEBECPNGB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x40926C0", Offset = "0x40916C0", VA = "0x1840926C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AAOLGFOFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4092020", Offset = "0x4091020", VA = "0x184092020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LMAJBADMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4092690", Offset = "0x4091690", VA = "0x184092690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OPPNLAPBCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4092070", Offset = "0x4091070", VA = "0x184092070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> FMMIPDEBFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x40923A0", Offset = "0x40913A0", VA = "0x1840923A0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4092D60", Offset = "0x4091D60", VA = "0x184092D60")]
	public AEBIOGGIKME(int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x40920F0", Offset = "0x40910F0", VA = "0x1840920F0")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4092990", Offset = "0x4091990", VA = "0x184092990")]
	public void OPFOFHIGBEE(T BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4092750", Offset = "0x4091750", VA = "0x184092750")]
	internal void OMNOJJFIOON(int BHNNGJABFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4091EB0", Offset = "0x4090EB0", VA = "0x184091EB0")]
	public void AJPODPOKFGA(int KHAIDMGPIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4092150", Offset = "0x4091150", VA = "0x184092150")]
	public void FAGNOIPBAAD(int AIDHIDOGENO, int IPCMHIELOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4091FA0", Offset = "0x4090FA0", VA = "0x184091FA0")]
	public int ALPEADNKMBM(T BJDKOHEGDOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x40920B0", Offset = "0x40910B0", VA = "0x1840920B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x40925B0", Offset = "0x40915B0", VA = "0x1840925B0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4092CB0", Offset = "0x4091CB0", VA = "0x184092CB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4092CF0", Offset = "0x4091CF0", VA = "0x184092CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4092460", Offset = "0x4091460", VA = "0x184092460")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void GFBABCCPEMP(int BJDKOHEGDOK, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4092AA0", Offset = "0x4091AA0", VA = "0x184092AA0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PKJEFLEPDIJ(int AIDHIDOGENO, int IPCMHIELOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BPODBOELFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OFDADLBABBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int DCEOMHJEBBP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NDBPJGICJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BCA20", VA = "0x1828BDA20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x625B930", Offset = "0x625A930", VA = "0x18625B930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LGFKEDOCBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD342A0", Offset = "0xD332A0", VA = "0x180D342A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ENFIFPOLOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE750", Offset = "0x6EAD750", VA = "0x186EAE750")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE770", Offset = "0x6EAD770", VA = "0x186EAE770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x99A6C0", Offset = "0x9996C0", VA = "0x18099A6C0")]
	private BPODBOELFJH(int OFDADLBABBI, int DCEOMHJEBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2310340", Offset = "0x230F340", VA = "0x182310340")]
	public static BPODBOELFJH JMMLAFIJINB(int OFDADLBABBI, int DCEOMHJEBBP)
	{
		return default(BPODBOELFJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE760", Offset = "0x6EAD760", VA = "0x186EAE760")]
	public static BPODBOELFJH HJDEGLDEDBB(int NOAHCMMOGGC, int IPCMHIELOCD)
	{
		return default(BPODBOELFJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE780", Offset = "0x6EAD780", VA = "0x186EAE780", Slot = "3")]
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
