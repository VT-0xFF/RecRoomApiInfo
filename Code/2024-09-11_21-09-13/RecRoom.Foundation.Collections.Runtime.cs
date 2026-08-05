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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B65460", Offset = "0x6B63A60", VA = "0x186B65460", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LALMBMHKMAF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B651C0", Offset = "0x6B637C0", VA = "0x186B651C0")]
	public static void MFLGBDKLOCO(this GameObject MNKAGJEGJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B65300", Offset = "0x6B63900", VA = "0x186B65300")]
	public static void MFLGBDKLOCO(this Component INEJDODHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B65260", Offset = "0x6B63860", VA = "0x186B65260")]
	public static void MFLGBDKLOCO(this ScriptableObject BOHKAIMJBDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FCHCIPFOAFL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B644B0", Offset = "0x6B62AB0", VA = "0x186B644B0")]
	public static Span<byte> KAEINKEEFAE(this NativeArray<byte> DKEEEGEFALD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B64400", Offset = "0x6B62A00", VA = "0x186B64400")]
	public static ReadOnlySpan<byte> JKEOPFKCCGC(this NativeArray<byte> DKEEEGEFALD)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C96670", Offset = "0x2C94C70", VA = "0x182C96670")]
	public static NativeArray<T> LKMOOADPKKB<T>(this NativeArray<T> DKEEEGEFALD, LIDAMMEOCHG PCIGIFGMPKJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C96630", Offset = "0x2C94C30", VA = "0x182C96630")]
	public static NativeArray<T> LKMOOADPKKB<T>(this NativeArray<T> DKEEEGEFALD, int OENMMCMOJOM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JAEAPPOHKOJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C5E0", Offset = "0x2D3ABE0", VA = "0x182D3C5E0")]
	public static string IKKOFKFKDAK<T>(this NativeArray<T> DKEEEGEFALD, string DAHJFKGMDFP = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KHLBADKDNGM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D679D0", Offset = "0x2D65FD0", VA = "0x182D679D0")]
	public static T PBGHNKGJFJB<T>([In] this ReadOnlySpan<byte> EBMIBGINKAH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2D678B0", Offset = "0x2D65EB0", VA = "0x182D678B0")]
	public static T PBGHNKGJFJB<T>([In] this Span<byte> EBMIBGINKAH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D65F70", Offset = "0x2D64570", VA = "0x182D65F70")]
	public static NativeArray<T> ANALNAJCEPH<T>(this ReadOnlySpan<byte> EBMIBGINKAH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA300", Offset = "0x2CF8900", VA = "0x182CFA300")]
	public static ReadOnlySpan<TTo> JIHPFLIBHLD<TTo, TFrom>(this ReadOnlySpan<TFrom> EBMIBGINKAH) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D66750", Offset = "0x2D64D50", VA = "0x182D66750")]
	public static Span<byte> ENCKAHEIPGI<T>([In] this Span<byte> EBMIBGINKAH, T KLABJGGMBGH) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B64BB0", Offset = "0x6B631B0", VA = "0x186B64BB0")]
	private static Enum GEHGAECLGCA([In] ReadOnlySpan<byte> EBMIBGINKAH, Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B65150", Offset = "0x6B63750", VA = "0x186B65150")]
	public static Enum PKDHJHKIJLO([In] this Span<byte> EBMIBGINKAH, Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B646D0", Offset = "0x6B62CD0", VA = "0x186B646D0")]
	public static void FAMFJPAKBMO([In] this Span<byte> EBMIBGINKAH, Enum HBEFBGGFFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NMHKDJAGHME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BPPCOICOPAO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6B64280", Offset = "0x6B62880", VA = "0x186B64280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B654F0", Offset = "0x6B63AF0", VA = "0x186B654F0")]
	[AsyncStateMachine(typeof(BPPCOICOPAO))]
	public static void PAEGHBDLGGO(this Task KGPMLIHPPAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GCNFGIMJMLA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GAOOKKMJHFC : short
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
	public struct OOPPGALFJFI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly GAOOKKMJHFC LFOBGDLOPID;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x264DEC0", Offset = "0x264C4C0", VA = "0x18264DEC0")]
		public OOPPGALFJFI(GAOOKKMJHFC LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory PDMFFKPECJB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public static void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B64670", Offset = "0x6B62C70", VA = "0x186B64670")]
	static GCNFGIMJMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29ACC80", Offset = "0x29AB280", VA = "0x1829ACC80")]
	public static OOPPGALFJFI LBLNOHJNLJC(GAOOKKMJHFC LFOBGDLOPID)
	{
		return default(OOPPGALFJFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public static void FOGCKMLELMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class GPDANAILPAE<THandle, TValue> : IDisposable where THandle : struct, EOIFKCNADCO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> ALLKFMONBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> ICLOFOKMOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> HLEEBDELFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> LHLDGOBOJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int EPDLGCOEDFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFB50", Offset = "0x3DFE150", VA = "0x183DFFB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E006E0", Offset = "0x3DFECE0", VA = "0x183E006E0")]
	public GPDANAILPAE(Action<TValue> LHLDGOBOJJL, [Optional] Func<TValue> HLEEBDELFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFB90", Offset = "0x3DFE190", VA = "0x183DFFB90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFE30", Offset = "0x3DFE430", VA = "0x183DFFE30")]
	public THandle FABNFHGMHGJ(TValue KLABJGGMBGH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF8B0", Offset = "0x3DFDEB0", VA = "0x183DFF8B0")]
	public bool AGDCKPANMGG(THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3E00130", Offset = "0x3DFE730", VA = "0x183E00130")]
	public bool JLNEIPDMCNA(THandle GPPOCIDKPII, [Out] TValue KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E00560", Offset = "0x3DFEB60", VA = "0x183E00560")]
	public TValue PBGHNKGJFJB(THandle GPPOCIDKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF9E0", Offset = "0x3DFDFE0", VA = "0x183DFF9E0")]
	public bool AOOFMIHDJBB(THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFA0", Offset = "0x3DFE5A0", VA = "0x183DFFFA0")]
	private THandle IBJJHKKIGPD(int HGFDMIDEFHN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E000D0", Offset = "0x3DFE6D0", VA = "0x183E000D0")]
	private TValue JHMOEGIAFJJ(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFB00", Offset = "0x3DFE100", VA = "0x183DFFB00")]
	private void BBEPNAAAKJD(int HGFDMIDEFHN, [In] THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E00510", Offset = "0x3DFEB10", VA = "0x183E00510")]
	private void OMPLFGPAEBL(int HGFDMIDEFHN, [In] TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E00200", Offset = "0x3DFE800", VA = "0x183E00200")]
	private THandle JNEMLDPLPCA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E005C0", Offset = "0x3DFEBC0", VA = "0x183E005C0")]
	private void PLINIAFMDDA(THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E003C0", Offset = "0x3DFE9C0", VA = "0x183E003C0")]
	private int LILGAIGAIME(int CJEHFDAEGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E000C0", Offset = "0x3DFE6C0", VA = "0x183E000C0")]
	private bool IOGCDIODCPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x893F70", Offset = "0x892570", VA = "0x180893F70")]
	private void PNAMGIEDGMA(THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFEE0", Offset = "0x3DFE4E0", VA = "0x183DFFEE0")]
	private bool FFPEMFOONAJ([Out] THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E003D0", Offset = "0x3DFE9D0", VA = "0x183E003D0")]
	private bool NJJCHDILAMH([Out] THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E00000", Offset = "0x3DFE600", VA = "0x183E00000")]
	private void IGALBFMLGPJ(THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFC70", Offset = "0x3DFE270", VA = "0x183DFFC70")]
	private void EDKMGGPOAJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EOIFKCNADCO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MFBBLPJBOGP
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
public static class BPAPIOEBAKP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A19620", Offset = "0x2A17C20", VA = "0x182A19620")]
	public static bool NDBEEGNEIKL<T>(this T GPPOCIDKPII, T PLNBHPCFEOK) where T : struct, EOIFKCNADCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A19640", Offset = "0x2A17C40", VA = "0x182A19640")]
	public static bool OGCLLAHCFGD<T>(this T GPPOCIDKPII) where T : struct, EOIFKCNADCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B64170", Offset = "0x6B62770", VA = "0x186B64170")]
	public static string JDHBGLIAIFD(this EOIFKCNADCO GPPOCIDKPII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct FGNBBGCPHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type MBMHEGAFHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> FBFLGOGMNFM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x43C7240", Offset = "0x43C5840", VA = "0x1843C7240")]
	public FGNBBGCPHEE(Type KCMHHLDAACM, Span<byte> EBMIBGINKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C99580", Offset = "0x2C97B80", VA = "0x182C99580")]
	public static FGNBBGCPHEE IPHAGGDKEPB<T>(T KLABJGGMBGH) where T : struct
	{
		return default(FGNBBGCPHEE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B64560", Offset = "0x6B62B60", VA = "0x186B64560")]
	public static BMMILLGHHLI BIEOCAPMHCM([In] FGNBBGCPHEE CGJIPKMEOFC)
	{
		return default(BMMILLGHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A18F10", Offset = "0x2A17510", VA = "0x182A18F10")]
	public T PBGHNKGJFJB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B645F0", Offset = "0x6B62BF0", VA = "0x186B645F0")]
	public Enum PKDHJHKIJLO(Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C98D90", Offset = "0x2C97390", VA = "0x182C98D90")]
	public void ENCKAHEIPGI<T>([In] T KLABJGGMBGH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B645E0", Offset = "0x6B62BE0", VA = "0x186B645E0")]
	public void FAMFJPAKBMO(Enum HBEFBGGFFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct BMMILLGHHLI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct GNGNDPBBJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* KJDKNBIDOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* DPFCBDOOEDH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type MBMHEGAFHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> FBFLGOGMNFM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KHAEIGABOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B63FC0", Offset = "0x6B625C0", VA = "0x186B63FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x43C7240", Offset = "0x43C5840", VA = "0x1843C7240")]
	public BMMILLGHHLI(Type KCMHHLDAACM, ReadOnlySpan<byte> EBMIBGINKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A16470", Offset = "0x2A14A70", VA = "0x182A16470")]
	public static BMMILLGHHLI IPHAGGDKEPB<T>(T KLABJGGMBGH) where T : struct
	{
		return default(BMMILLGHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A162F0", Offset = "0x2A148F0", VA = "0x182A162F0")]
	public static BMMILLGHHLI IPHAGGDKEPB<T>(NativeArray<T> KLABJGGMBGH) where T : struct
	{
		return default(BMMILLGHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B63F60", Offset = "0x6B62560", VA = "0x186B63F60")]
	public void IKLPEOJFMNH(Span<byte> GIEDJFEABAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B63E90", Offset = "0x6B62490", VA = "0x186B63E90")]
	public void IKLPEOJFMNH(NativeArray<byte> GIEDJFEABAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A18F40", Offset = "0x2A17540", VA = "0x182A18F40")]
	public T PBGHNKGJFJB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A154E0", Offset = "0x2A13AE0", VA = "0x182A154E0")]
	public NativeArray<T> ANALNAJCEPH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6B64130", Offset = "0x6B62730", VA = "0x186B64130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6B64000", Offset = "0x6B62600", VA = "0x186B64000")]
	private object PIOAGFEMFKM()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IKBDFFLOPKK
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C600", Offset = "0x2D2AC00", VA = "0x182D2C600")]
	public static NativeArray<T> DJJBKJFMCHA<T>(T KLABJGGMBGH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C6A0", Offset = "0x2D2ACA0", VA = "0x182D2C6A0")]
	public static NativeArray<T> NLNBFMALGMF<T>(T KLABJGGMBGH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C650", Offset = "0x2D2AC50", VA = "0x182D2C650")]
	public static NativeArray<T> IPHAGGDKEPB<T>(T KLABJGGMBGH, bool MPKLOIOFKAG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BOEJKFIDCCM<Handle> where Handle : EOIFKCNADCO, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct ADONKLANOEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly BOEJKFIDCCM<Handle> PNBHHBNOEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int HGFDMIDEFHN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle LGCJMABNOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3D90390", Offset = "0x3D8E990", VA = "0x183D90390")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3D90930", Offset = "0x3D8EF30", VA = "0x183D90930")]
		public ADONKLANOEA(BOEJKFIDCCM<Handle> PNBHHBNOEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3D902F0", Offset = "0x3D8E8F0", VA = "0x183D902F0")]
		public MMNMBFDKKIO GGBAHLJJLHO([In] MMNMBFDKKIO MNKBAIOBLHC)
		{
			return default(MMNMBFDKKIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3D900B0", Offset = "0x3D8E6B0", VA = "0x183D900B0")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3D90810", Offset = "0x3D8EE10", VA = "0x183D90810")]
		private Handle OJKEKBIEHMO(string KFAOBDLOMDC)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct MMNMBFDKKIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private ADONKLANOEA PCAFNOGJNOD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x46B51F0", Offset = "0x46B37F0", VA = "0x1846B51F0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x46B5270", Offset = "0x46B3870", VA = "0x1846B5270")]
		public MMNMBFDKKIO(BOEJKFIDCCM<Handle> PNBHHBNOEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x46B5070", Offset = "0x46B3670", VA = "0x1846B5070")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x46B5130", Offset = "0x46B3730", VA = "0x1846B5130")]
		public MMNMBFDKKIO HNHGFOAAHAF()
		{
			return default(MMNMBFDKKIO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> AAMMEKMDFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> CJFFBLANGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int KNACGDGJJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int NKMOEMLMAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool EHJHBDKNMEH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x50B0120", Offset = "0x50AE720", VA = "0x1850B0120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MMNMBFDKKIO GJFEMEEEFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50B1050", Offset = "0x50AF650", VA = "0x1850B1050")]
		get
		{
			return default(MMNMBFDKKIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x50B22F0", Offset = "0x50B08F0", VA = "0x1850B22F0")]
	public BOEJKFIDCCM(int PNEOLMDLHBN, Allocator NPNPKHEIOHB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x50B1300", Offset = "0x50AF900", VA = "0x1850B1300")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D650", Offset = "0x1A3BC50", VA = "0x181A3D650")]
	public static int LILGAIGAIME(int LEKEIHPCIEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26867B0", Offset = "0x2684DB0", VA = "0x1826867B0")]
	public static bool CDCMGNNAPMP(int LEKEIHPCIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x50B0350", Offset = "0x50AE950", VA = "0x1850B0350")]
	public bool EALEKBOMKFK(int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x50B0DB0", Offset = "0x50AF3B0", VA = "0x1850B0DB0")]
	public bool GNJBIILFJOK(Handle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x50B06E0", Offset = "0x50AECE0", VA = "0x1850B06E0")]
	public Handle FBLOKHAGBOM()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x50B1FC0", Offset = "0x50B05C0", VA = "0x1850B1FC0")]
	public void OAFPCGKHPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x50B09C0", Offset = "0x50AEFC0", VA = "0x1850B09C0")]
	public void GHDDEOCPHBH(Handle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x50B11A0", Offset = "0x50AF7A0", VA = "0x1850B11A0")]
	public bool KEHMJJHCKGN(Handle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x8FFA00", VA = "0x180901400")]
	private bool GOGLKNDDPDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x50B0FF0", Offset = "0x50AF5F0", VA = "0x1850B0FF0")]
	private bool HCFIFCJJKHA(int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x50AFC60", Offset = "0x50AE260", VA = "0x1850AFC60")]
	private void BLJPOFEPHMF([Out] int HGFDMIDEFHN, [Out] int CJEHFDAEGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50B17F0", Offset = "0x50AFDF0", VA = "0x1850B17F0")]
	private void MFBLJDBGLEA(Handle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x50AFC10", Offset = "0x50AE210", VA = "0x1850AFC10")]
	private void AOFGLNJAHGK(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x50AFAC0", Offset = "0x50AE0C0", VA = "0x1850AFAC0")]
	private bool ANLNEKBNDOJ([Out] int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50B0290", Offset = "0x50AE890", VA = "0x1850B0290")]
	private static Handle CMGMNNIBKIO(int HGFDMIDEFHN, int CJEHFDAEGCE)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct CFAOFCPNGBH<Handle, T> where Handle : EOIFKCNADCO, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BOEJKFIDCCM<Handle> BNEDCDADPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] HAPJJBDKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> IAPLAOKPJCA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x54B6A70", Offset = "0x54B5070", VA = "0x1854B6A70")]
	public CFAOFCPNGBH(int PNEOLMDLHBN, [Optional] Action<T> IAPLAOKPJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54B6330", Offset = "0x54B4930", VA = "0x1854B6330")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x54B6140", Offset = "0x54B4740", VA = "0x1854B6140")]
	public bool JLNEIPDMCNA(Handle GPPOCIDKPII, [Out] T GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x54B5CC0", Offset = "0x54B42C0", VA = "0x1854B5CC0")]
	public Handle FABNFHGMHGJ(T GHMNBJIOGAM)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x54B5820", Offset = "0x54B3E20", VA = "0x1854B5820")]
	public void DHNBBOCMLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x54B6530", Offset = "0x54B4B30", VA = "0x1854B6530")]
	public void MBEEDABKNGP(Handle GPPOCIDKPII, [Out] T HCBHCHHBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x54B6450", Offset = "0x54B4A50", VA = "0x1854B6450")]
	public void MBEEDABKNGP(Handle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x54B54E0", Offset = "0x54B3AE0", VA = "0x1854B54E0")]
	public bool DHAPIEAKDFP(Handle GPPOCIDKPII, [Out] T HCBHCHHBBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x54B5020", Offset = "0x54B3620", VA = "0x1854B5020")]
	public bool DHAPIEAKDFP(Handle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x54B6010", Offset = "0x54B4610", VA = "0x1854B6010")]
	private T FDBDCLPINFK(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x54B69B0", Offset = "0x54B4FB0", VA = "0x1854B69B0")]
	private void PHBPFDOAJJA(int BAPDOMLMICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct DCBPMLOKBLC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int KHMKAEGDPPG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20E3390", Offset = "0x20E1990", VA = "0x1820E3390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2E1B8C0", Offset = "0x2E19EC0", VA = "0x182E1B8C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> FBFLGOGMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5A430A0", Offset = "0x5A416A0", VA = "0x185A430A0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OADKJCMIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1033CA0", Offset = "0x10322A0", VA = "0x181033CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5A432C0", Offset = "0x5A418C0", VA = "0x185A432C0")]
	public DCBPMLOKBLC(int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5A43210", Offset = "0x5A41810", VA = "0x185A43210")]
	public int OHCPFAOHMPG(T KLABJGGMBGH, int OENMMCMOJOM, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5A42F90", Offset = "0x5A41590", VA = "0x185A42F90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct FKPPMPJBOIP<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct ONMCCAHBPFE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FKPPMPJBOIP<T> OLAPNOFMNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int HGFDMIDEFHN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4835DD0", Offset = "0x48343D0", VA = "0x184835DD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4835E70", Offset = "0x4834470", VA = "0x184835E70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4835E40", Offset = "0x4834440", VA = "0x184835E40")]
		public ONMCCAHBPFE(FKPPMPJBOIP<T> OLAPNOFMNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4835D40", Offset = "0x4834340", VA = "0x184835D40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4835D80", Offset = "0x4834380", VA = "0x184835D80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DCBPMLOKBLC<T> JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int KHMKAEGDPPG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3D33190", Offset = "0x3D31790", VA = "0x183D33190")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3D33BE0", Offset = "0x3D321E0", VA = "0x183D33BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3D33220", Offset = "0x3D31820", VA = "0x183D33220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OADKJCMIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3D33C30", Offset = "0x3D32230", VA = "0x183D33C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> FBFLGOGMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3D335B0", Offset = "0x3D31BB0", VA = "0x183D335B0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D33E00", Offset = "0x3D32400", VA = "0x183D33E00")]
	public FKPPMPJBOIP(int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D33C70", Offset = "0x3D32270", VA = "0x183D33C70")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D334A0", Offset = "0x3D31AA0", VA = "0x183D334A0")]
	public void FABNFHGMHGJ(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D338C0", Offset = "0x3D31EC0", VA = "0x183D338C0")]
	internal void GGAOOKOGIDC(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D32F50", Offset = "0x3D31550", VA = "0x183D32F50")]
	public void AAOPJACGKPM(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D33670", Offset = "0x3D31C70", VA = "0x183D33670")]
	public void FLDGJIJJDHA(int LJPLCEIDCDB, int FOOPMAMGEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D33CD0", Offset = "0x3D322D0", VA = "0x183D33CD0")]
	public int OHCPFAOHMPG(T KLABJGGMBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D33460", Offset = "0x3D31A60", VA = "0x183D33460", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D33B00", Offset = "0x3D32100", VA = "0x183D33B00", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3D33D50", Offset = "0x3D32350", VA = "0x183D33D50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3D33D90", Offset = "0x3D32390", VA = "0x183D33D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3D33040", Offset = "0x3D31640", VA = "0x183D33040")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void BNCPBJILNNI(int KLABJGGMBGH, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3D33250", Offset = "0x3D31850", VA = "0x183D33250")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void COGNEGJLDMJ(int LJPLCEIDCDB, int FOOPMAMGEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LIDAMMEOCHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int IEHCONIHMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FIGHABPEBPG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int FINIPIMGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2669630", Offset = "0x2667C30", VA = "0x182669630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5F41DD0", Offset = "0x5F403D0", VA = "0x185F41DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int MGECPAAHDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MIFABMICKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6B653A0", Offset = "0x6B639A0", VA = "0x186B653A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6B653C0", Offset = "0x6B639C0", VA = "0x186B653C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
	private LIDAMMEOCHG(int IEHCONIHMPO, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x20CB450", Offset = "0x20C9A50", VA = "0x1820CB450")]
	public static LIDAMMEOCHG CBAGAAFIGFG(int IEHCONIHMPO, int FIGHABPEBPG)
	{
		return default(LIDAMMEOCHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B653B0", Offset = "0x6B639B0", VA = "0x186B653B0")]
	public static LIDAMMEOCHG KNHHPKKGLKF(int OENMMCMOJOM, int FOOPMAMGEIK)
	{
		return default(LIDAMMEOCHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B653D0", Offset = "0x6B639D0", VA = "0x186B653D0", Slot = "3")]
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
