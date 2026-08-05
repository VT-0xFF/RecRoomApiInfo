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
	public class LogRegistrationIndex : NNAGAKKCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69C7F10", Offset = "0x69C6B10", VA = "0x1869C7F10", Slot = "4")]
		public override void NGMFPPEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KOGODDDHIDO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69C7DD0", Offset = "0x69C69D0", VA = "0x1869C7DD0")]
	public static void BCHEJEJKBDO(this GameObject OJCNPGOLEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69C7D30", Offset = "0x69C6930", VA = "0x1869C7D30")]
	public static void BCHEJEJKBDO(this Component BFLHJMMHBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69C7E70", Offset = "0x69C6A70", VA = "0x1869C7E70")]
	public static void BCHEJEJKBDO(this ScriptableObject MEDHEEAIOAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ODIJFDNALIB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69C8050", Offset = "0x69C6C50", VA = "0x1869C8050")]
	public static Span<byte> LDJILHCKIAC(this NativeArray<byte> DKCMKELIAPN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69C7FA0", Offset = "0x69C6BA0", VA = "0x1869C7FA0")]
	public static ReadOnlySpan<byte> LAONAAPANFN(this NativeArray<byte> DKCMKELIAPN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CC85E0", Offset = "0x2CC71E0", VA = "0x182CC85E0")]
	public static NativeArray<T> APBLAKPAIPE<T>(this NativeArray<T> DKCMKELIAPN, FDBPFLBCDGJ FHHLMBJFCEC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2CC85A0", Offset = "0x2CC71A0", VA = "0x182CC85A0")]
	public static NativeArray<T> APBLAKPAIPE<T>(this NativeArray<T> DKCMKELIAPN, int CNNPCLMHBKN) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ALFKCGOOOAL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x31FEDE0", Offset = "0x31FD9E0", VA = "0x1831FEDE0")]
	public static string BLDFJFNHFDM<T>(this NativeArray<T> DKCMKELIAPN, string PMJEHAILNCK = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PFIEGGDCGIL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE43E0", Offset = "0x2CE2FE0", VA = "0x182CE43E0")]
	public static T OIPGNBHOLEB<T>([In] this ReadOnlySpan<byte> ACKACNDHEEO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3CB0", Offset = "0x2CE28B0", VA = "0x182CE3CB0")]
	public static NativeArray<T> OCBIBCEOMCF<T>(this ReadOnlySpan<byte> ACKACNDHEEO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6880", Offset = "0x2CD5480", VA = "0x182CD6880")]
	public static ReadOnlySpan<TTo> IBHMFLFHMAK<TTo, TFrom>(this ReadOnlySpan<TFrom> ACKACNDHEEO) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2B60", Offset = "0x2CE1760", VA = "0x182CE2B60")]
	public static Span<byte> IJGOPKKNHAN<T>([In] this Span<byte> ACKACNDHEEO, T IIPLJLPCLBC) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69C8100", Offset = "0x69C6D00", VA = "0x1869C8100")]
	private static Enum OAHIECPBCBB([In] ReadOnlySpan<byte> ACKACNDHEEO, Type GFECMDDJOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69C8BB0", Offset = "0x69C77B0", VA = "0x1869C8BB0")]
	public static Enum PMMIEONBLCE([In] this Span<byte> ACKACNDHEEO, Type GFECMDDJOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69C86A0", Offset = "0x69C72A0", VA = "0x1869C86A0")]
	public static void OKGKFGDPIMF([In] this Span<byte> ACKACNDHEEO, Enum CLDDKGECHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KBHLOILOCKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BCPHFBPLMDG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C7740", Offset = "0x69C6340", VA = "0x1869C7740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69C7C10", Offset = "0x69C6810", VA = "0x1869C7C10")]
	[AsyncStateMachine(typeof(BCPHFBPLMDG))]
	public static void MDLCEGICHOG(this Task GLMCDBEDNLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DJCJKPKPLCC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum LHHKOMGHHOM : short
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
	public struct LDCLJGIJEDI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly LHHKOMGHHOM NCMHANGAILD;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2558540", Offset = "0x2557140", VA = "0x182558540")]
		public LDCLJGIJEDI(LHHKOMGHHOM NCMHANGAILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory AOCABHFPLAH;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	public static void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69C78C0", Offset = "0x69C64C0", VA = "0x1869C78C0")]
	static DJCJKPKPLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x286C4C0", Offset = "0x286B0C0", VA = "0x18286C4C0")]
	public static LDCLJGIJEDI NIBIGDEHFLJ(LHHKOMGHHOM NCMHANGAILD)
	{
		return default(LDCLJGIJEDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	public static void IAEOHJNOOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class GKMOJKKGOPC<THandle, TValue> : IDisposable where THandle : struct, PCHGDIKACAK where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> OGFCEDKDAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> COOBAOCKFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> IHFKBBNMIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> NNANANDNGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int CBHFFMJNOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D58D00", Offset = "0x3D57900", VA = "0x183D58D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D59640", Offset = "0x3D58240", VA = "0x183D59640")]
	public GKMOJKKGOPC(Action<TValue> NNANANDNGGF, [Optional] Func<TValue> IHFKBBNMIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D589F0", Offset = "0x3D575F0", VA = "0x183D589F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D59000", Offset = "0x3D57C00", VA = "0x183D59000")]
	public THandle LKPJOLMECIF(TValue IIPLJLPCLBC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D58E80", Offset = "0x3D57A80", VA = "0x183D58E80")]
	public bool KHBCMNOGPLL(THandle MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D590B0", Offset = "0x3D57CB0", VA = "0x183D590B0")]
	public bool LPJAHGPAPEL(THandle MJBLPCEDGPJ, [Out] TValue IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D59580", Offset = "0x3D58180", VA = "0x183D59580")]
	public TValue OIPGNBHOLEB(THandle MJBLPCEDGPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D58810", Offset = "0x3D57410", VA = "0x183D58810")]
	public bool BCICDOOEJDJ(THandle MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D595E0", Offset = "0x3D581E0", VA = "0x183D595E0")]
	private THandle PBCAGDNHBNH(int BAEBMIBABAE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D59180", Offset = "0x3D57D80", VA = "0x183D59180")]
	private TValue MCDECIHBNJE(int BAEBMIBABAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D58FB0", Offset = "0x3D57BB0", VA = "0x183D58FB0")]
	private void LKGEHDCGMFC(int BAEBMIBABAE, [In] THandle MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D58CB0", Offset = "0x3D578B0", VA = "0x183D58CB0")]
	private void FIINAHLFLGM(int BAEBMIBABAE, [In] TValue IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D593C0", Offset = "0x3D57FC0", VA = "0x183D593C0")]
	private THandle NCICFAMDKFM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D58AD0", Offset = "0x3D576D0", VA = "0x183D58AD0")]
	private void EFLCNBOJMOG(THandle MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D591E0", Offset = "0x3D57DE0", VA = "0x183D591E0")]
	private int MHHMBOCKLFP(int FAEMFOKJHDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D591F0", Offset = "0x3D57DF0", VA = "0x183D591F0")]
	private bool MNCKHKIBBAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86A110", Offset = "0x868D10", VA = "0x18086A110")]
	private void LMEEABJIHLP(THandle MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D58930", Offset = "0x3D57530", VA = "0x183D58930")]
	private bool DDMHOKGNIAC([Out] THandle MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D58D40", Offset = "0x3D57940", VA = "0x183D58D40")]
	private bool IHAIJFFMEGE([Out] THandle MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D58BF0", Offset = "0x3D577F0", VA = "0x183D58BF0")]
	private void FCGILBOCIFE(THandle MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D59200", Offset = "0x3D57E00", VA = "0x183D59200")]
	private void NBIOBDFBCGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PCHGDIKACAK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int ICIBDGPPAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PDDGDECCJOA
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
public static class JNCNOOIIBAL
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BA14D0", Offset = "0x2BA00D0", VA = "0x182BA14D0")]
	public static bool HJDIMGILPPK<T>(this T MJBLPCEDGPJ, T HEIGABGMPLJ) where T : struct, PCHGDIKACAK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BA14F0", Offset = "0x2BA00F0", VA = "0x182BA14F0")]
	public static bool PHIOAAOKLPJ<T>(this T MJBLPCEDGPJ) where T : struct, PCHGDIKACAK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69C7B00", Offset = "0x69C6700", VA = "0x1869C7B00")]
	public static string OEPGJGAPCEK(this PCHGDIKACAK MJBLPCEDGPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct IHOAIJPBPNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type BJLBEAMJACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> INIAKPOKJJH;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x423A560", Offset = "0x4239160", VA = "0x18423A560")]
	public IHOAIJPBPNP(Type FMOPLEBEHNN, Span<byte> ACKACNDHEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B774F0", Offset = "0x2B760F0", VA = "0x182B774F0")]
	public static IHOAIJPBPNP ABOMBKDKOLM<T>(T IIPLJLPCLBC) where T : struct
	{
		return default(IHOAIJPBPNP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69C79F0", Offset = "0x69C65F0", VA = "0x1869C79F0")]
	public static ACJOMMOAIML ANHILFPCAJJ([In] IHOAIJPBPNP GKPLDDEPNGI)
	{
		return default(ACJOMMOAIML);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69C7A80", Offset = "0x69C6680", VA = "0x1869C7A80")]
	public Enum PMMIEONBLCE(Type GFECMDDJOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B785A0", Offset = "0x2B771A0", VA = "0x182B785A0")]
	public void IJGOPKKNHAN<T>([In] T IIPLJLPCLBC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69C7A70", Offset = "0x69C6670", VA = "0x1869C7A70")]
	public void OKGKFGDPIMF(Enum CLDDKGECHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct ACJOMMOAIML
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct FNCJKHIAPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* MGMLELJJAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* CEENIHNJHMG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type BJLBEAMJACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> INIAKPOKJJH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FODIPBCKAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69C76C0", Offset = "0x69C62C0", VA = "0x1869C76C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x423A560", Offset = "0x4239160", VA = "0x18423A560")]
	public ACJOMMOAIML(Type FMOPLEBEHNN, ReadOnlySpan<byte> ACKACNDHEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x31DC2D0", Offset = "0x31DAED0", VA = "0x1831DC2D0")]
	public static ACJOMMOAIML ABOMBKDKOLM<T>(T IIPLJLPCLBC) where T : struct
	{
		return default(ACJOMMOAIML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31DC400", Offset = "0x31DB000", VA = "0x1831DC400")]
	public static ACJOMMOAIML ABOMBKDKOLM<T>(NativeArray<T> IIPLJLPCLBC) where T : struct
	{
		return default(ACJOMMOAIML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69C74C0", Offset = "0x69C60C0", VA = "0x1869C74C0")]
	public void APBAMFDBHOK(NativeArray<byte> OLGBGEDHNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31DEE00", Offset = "0x31DDA00", VA = "0x1831DEE00")]
	public T OIPGNBHOLEB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31DED80", Offset = "0x31DD980", VA = "0x1831DED80")]
	public NativeArray<T> OCBIBCEOMCF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69C7700", Offset = "0x69C6300", VA = "0x1869C7700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69C7590", Offset = "0x69C6190", VA = "0x1869C7590")]
	private object BHEPCIJBHOC()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ACEKOFMBHKO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31DB630", Offset = "0x31DA230", VA = "0x1831DB630")]
	public static NativeArray<T> MNOKJNFJGDD<T>(T IIPLJLPCLBC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31DB5E0", Offset = "0x31DA1E0", VA = "0x1831DB5E0")]
	public static NativeArray<T> ABOMBKDKOLM<T>(T IIPLJLPCLBC, bool IECLGADGBHI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HNEGJGPDJME<Handle> where Handle : PCHGDIKACAK, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct DGFJFIDAOBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly HNEGJGPDJME<Handle> LDDBKNFFEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int BAEBMIBABAE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle FOEMFNJGDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x589FEB0", Offset = "0x589EAB0", VA = "0x18589FEB0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x58A0330", Offset = "0x589EF30", VA = "0x1858A0330")]
		public DGFJFIDAOBD(HNEGJGPDJME<Handle> LDDBKNFFEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x589F990", Offset = "0x589E590", VA = "0x18589F990")]
		public EBBIOKMBJJF FCDPFGJNKNI([In] EBBIOKMBJJF LDAADCAOFLJ)
		{
			return default(EBBIOKMBJJF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x589FC70", Offset = "0x589E870", VA = "0x18589FC70")]
		public bool IMIKPNNMLJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x589FE50", Offset = "0x589EA50", VA = "0x18589FE50")]
		private Handle LNIKHIIMIKK(string NKAJDDICLFH)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct EBBIOKMBJJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DGFJFIDAOBD DHNOAENJIAM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x38295E0", Offset = "0x38281E0", VA = "0x1838295E0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x38296E0", Offset = "0x38282E0", VA = "0x1838296E0")]
		public EBBIOKMBJJF(HNEGJGPDJME<Handle> LDDBKNFFEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x38296A0", Offset = "0x38282A0", VA = "0x1838296A0")]
		public bool IMIKPNNMLJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x38294E0", Offset = "0x38280E0", VA = "0x1838294E0")]
		public EBBIOKMBJJF DHNABIACCII()
		{
			return default(EBBIOKMBJJF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> DJAGJLLBNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> MHFAEEJPFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int AOKCNMJAOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int PCBDMHIHOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool JIPKFACDGJC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BEDOIHFIHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8500", Offset = "0x3DE7100", VA = "0x183DE8500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EBBIOKMBJJF HBDBMJEOEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8F90", Offset = "0x3DE7B90", VA = "0x183DE8F90")]
		get
		{
			return default(EBBIOKMBJJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9D10", Offset = "0x3DE8910", VA = "0x183DE9D10")]
	public HNEGJGPDJME(int FJFIKCNOKCK, Allocator MJBDBDLLDBK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9030", Offset = "0x3DE7C30", VA = "0x183DE9030")]
	public void JPLCCCCJMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x18DAD30", Offset = "0x18D9930", VA = "0x1818DAD30")]
	public static int MHHMBOCKLFP(int CCBJGKKCAKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2590600", Offset = "0x258F200", VA = "0x182590600")]
	public static bool PHMOOJECLGH(int CCBJGKKCAKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DE88A0", Offset = "0x3DE74A0", VA = "0x183DE88A0")]
	public bool EMFIOFJBFMC(int BAEBMIBABAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8C80", Offset = "0x3DE7880", VA = "0x183DE8C80")]
	public bool FILPHEMECFF(Handle MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3DE96A0", Offset = "0x3DE82A0", VA = "0x183DE96A0")]
	public Handle LCOIELDOBDL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DE75E0", Offset = "0x3DE61E0", VA = "0x183DE75E0")]
	public void AKMHNBGABAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3DE92E0", Offset = "0x3DE7EE0", VA = "0x183DE92E0")]
	public void KEJKGKCBNKM(Handle MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9470", Offset = "0x3DE8070", VA = "0x183DE9470")]
	public bool KLAGNHFDOLN(Handle MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA7EAB0", Offset = "0xA7D6B0", VA = "0x180A7EAB0")]
	private bool OFAKIINBABL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3DE84A0", Offset = "0x3DE70A0", VA = "0x183DE84A0")]
	private bool CMOLMOEBNLA(int BAEBMIBABAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7DE0", Offset = "0x3DE69E0", VA = "0x183DE7DE0")]
	private void BFEAAABJKLF([Out] int BAEBMIBABAE, [Out] int FAEMFOKJHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9840", Offset = "0x3DE8440", VA = "0x183DE9840")]
	private void POGOCJFGEGE(Handle MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8130", Offset = "0x3DE6D30", VA = "0x183DE8130")]
	private void BLHKNDBGOMG(int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8330", Offset = "0x3DE6F30", VA = "0x183DE8330")]
	private bool CKIDKKADKLO([Out] int BAEBMIBABAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE86B0", Offset = "0x3DE72B0", VA = "0x183DE86B0")]
	private static Handle ECEKJNJGNBN(int BAEBMIBABAE, int FAEMFOKJHDK)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct PNOHLKCJAAP<Handle, T> where Handle : PCHGDIKACAK, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private HNEGJGPDJME<Handle> KEDDOANGNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] DANAKBDMDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> FEENNKFHIGO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x47AC260", Offset = "0x47AAE60", VA = "0x1847AC260")]
	public PNOHLKCJAAP(int FJFIKCNOKCK, [Optional] Action<T> FEENNKFHIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x47ABA10", Offset = "0x47AA610", VA = "0x1847ABA10")]
	public void JPLCCCCJMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47AC000", Offset = "0x47AAC00", VA = "0x1847AC000")]
	public bool LPJAHGPAPEL(Handle MJBLPCEDGPJ, [Out] T APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x47ABB30", Offset = "0x47AA730", VA = "0x1847ABB30")]
	public Handle LKPJOLMECIF(T APKAFMDACKK)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x47AAF20", Offset = "0x47A9B20", VA = "0x1847AAF20")]
	public void DABCOMKMBFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x47AB3C0", Offset = "0x47A9FC0", VA = "0x1847AB3C0")]
	public void ECLBFOFCOFL(Handle MJBLPCEDGPJ, [Out] T IEOEHINDAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x47AB4A0", Offset = "0x47AA0A0", VA = "0x1847AB4A0")]
	public void ECLBFOFCOFL(Handle MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x47AA9F0", Offset = "0x47A95F0", VA = "0x1847AA9F0")]
	public bool CJFGMBOEDCF(Handle MJBLPCEDGPJ, [Out] T IEOEHINDAMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x47AA900", Offset = "0x47A9500", VA = "0x1847AA900")]
	public bool CJFGMBOEDCF(Handle MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47AB920", Offset = "0x47AA520", VA = "0x1847AB920")]
	private T EPMMPCEOBCB(int BAEBMIBABAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x47AC0B0", Offset = "0x47AACB0", VA = "0x1847AC0B0")]
	private void PMEBDOGEIPM(int KODFGJGJKEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct AEEEEICBMNB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] JGFKFMMOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int AEGGIAICNFC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FFE370", Offset = "0x1FFCF70", VA = "0x181FFE370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x29E2560", Offset = "0x29E1160", VA = "0x1829E2560")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> INIAKPOKJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3CECEE0", Offset = "0x3CEBAE0", VA = "0x183CECEE0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LFJOKDMJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE7BCF0", Offset = "0xE7A8F0", VA = "0x180E7BCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3CECF80", Offset = "0x3CEBB80", VA = "0x183CECF80")]
	public AEEEEICBMNB(int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3CECE30", Offset = "0x3CEBA30", VA = "0x183CECE30")]
	public int OFNMBPGBNNI(T IIPLJLPCLBC, int CNNPCLMHBKN, int LLHINFJPPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3CECC50", Offset = "0x3CEB850", VA = "0x183CECC50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct GLMBAMGBOHP<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct KKCJCOJOOFG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private GLMBAMGBOHP<T> ELBBNOKMNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int BAEBMIBABAE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x41B44B0", Offset = "0x41B30B0", VA = "0x1841B44B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x41B4550", Offset = "0x41B3150", VA = "0x1841B4550", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x41B4520", Offset = "0x41B3120", VA = "0x1841B4520")]
		public KKCJCOJOOFG(GLMBAMGBOHP<T> ELBBNOKMNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x41B4420", Offset = "0x41B3020", VA = "0x1841B4420", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x41B4460", Offset = "0x41B3060", VA = "0x1841B4460", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private AEEEEICBMNB<T> JGFKFMMOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int AEGGIAICNFC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D68EC0", Offset = "0x3D67AC0", VA = "0x183D68EC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3D68D90", Offset = "0x3D67990", VA = "0x183D68D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BEDOIHFIHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D68D20", Offset = "0x3D67920", VA = "0x183D68D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LFJOKDMJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3D68940", Offset = "0x3D67540", VA = "0x183D68940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> INIAKPOKJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3D690E0", Offset = "0x3D67CE0", VA = "0x183D690E0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3D696A0", Offset = "0x3D682A0", VA = "0x183D696A0")]
	public GLMBAMGBOHP(int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D688E0", Offset = "0x3D674E0", VA = "0x183D688E0")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D68F50", Offset = "0x3D67B50", VA = "0x183D68F50")]
	public void LKPJOLMECIF(T IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D693B0", Offset = "0x3D67FB0", VA = "0x183D693B0")]
	internal void PJIBAEHCPNE(int DFJDDCJIBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D687F0", Offset = "0x3D673F0", VA = "0x183D687F0")]
	public void ACJCBDDHPJG(int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D68980", Offset = "0x3D67580", VA = "0x183D68980")]
	public void CGOPPKCEKPH(int KJINLHAHILB, int CLJNFDDEOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D69060", Offset = "0x3D67C60", VA = "0x183D69060")]
	public int OFNMBPGBNNI(T IIPLJLPCLBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D68D50", Offset = "0x3D67950", VA = "0x183D68D50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D68DE0", Offset = "0x3D679E0", VA = "0x183D68DE0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D695F0", Offset = "0x3D681F0", VA = "0x183D695F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D69630", Offset = "0x3D68230", VA = "0x183D69630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D68BD0", Offset = "0x3D677D0", VA = "0x183D68BD0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DLMPHJDAELA(int IIPLJLPCLBC, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D691A0", Offset = "0x3D67DA0", VA = "0x183D691A0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PJHCAFLDJJE(int KJINLHAHILB, int CLJNFDDEOFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FDBPFLBCDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int JEHLDDEOFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int LLHINFJPPOH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int IKFOCKOFOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x256F310", Offset = "0x256DF10", VA = "0x18256F310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6600", Offset = "0x5DA5200", VA = "0x185DA6600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JDHGGBEHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int BNKOHBOJIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69C7930", Offset = "0x69C6530", VA = "0x1869C7930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69C7950", Offset = "0x69C6550", VA = "0x1869C7950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
	private FDBPFLBCDGJ(int JEHLDDEOFLK, int LLHINFJPPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0170", Offset = "0x1FDED70", VA = "0x181FE0170")]
	public static FDBPFLBCDGJ JPPADCHPKJF(int JEHLDDEOFLK, int LLHINFJPPOH)
	{
		return default(FDBPFLBCDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69C7940", Offset = "0x69C6540", VA = "0x1869C7940")]
	public static FDBPFLBCDGJ BFIBHADOMIH(int CNNPCLMHBKN, int CLJNFDDEOFA)
	{
		return default(FDBPFLBCDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69C7960", Offset = "0x69C6560", VA = "0x1869C7960", Slot = "3")]
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
