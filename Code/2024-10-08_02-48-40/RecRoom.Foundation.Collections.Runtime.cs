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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C220", Offset = "0x6C6B420", VA = "0x186C6C220", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ABDLKLOHLCK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AD20", Offset = "0x6C69F20", VA = "0x186C6AD20")]
	public static void FIEOLJADNAI(this GameObject PLNJOBKLAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ABE0", Offset = "0x6C69DE0", VA = "0x186C6ABE0")]
	public static void FIEOLJADNAI(this Component OPAHHNBNPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AC80", Offset = "0x6C69E80", VA = "0x186C6AC80")]
	public static void FIEOLJADNAI(this ScriptableObject JLIGCNDAENB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ABJPBIEDHIM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AE70", Offset = "0x6C6A070", VA = "0x186C6AE70")]
	public static Span<byte> LIPCONAKCND(this NativeArray<byte> IEIBCNCHGJN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ADC0", Offset = "0x6C69FC0", VA = "0x186C6ADC0")]
	public static ReadOnlySpan<byte> DJFGILAFFAD(this NativeArray<byte> IEIBCNCHGJN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x34FBEC0", Offset = "0x34FB0C0", VA = "0x1834FBEC0")]
	public static NativeArray<T> OGNIIPHKKLN<T>(this NativeArray<T> IEIBCNCHGJN, OJDOCFPBNPC GELGLJHAMIN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34FBE80", Offset = "0x34FB080", VA = "0x1834FBE80")]
	public static NativeArray<T> OGNIIPHKKLN<T>(this NativeArray<T> IEIBCNCHGJN, int NJJFLJLDLKI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class APMMJMFLDIP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x352E8F0", Offset = "0x352DAF0", VA = "0x18352E8F0")]
	public static string IIEBKFIOGLP<T>(this NativeArray<T> IEIBCNCHGJN, string NEIMFBHHIIA = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KHGHMOHMLMB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2EDEFC0", Offset = "0x2EDE1C0", VA = "0x182EDEFC0")]
	public static T PLOCNKMCLIO<T>([In] this ReadOnlySpan<byte> GAJNOCDCEMH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2EDF750", Offset = "0x2EDE950", VA = "0x182EDF750")]
	public static T PLOCNKMCLIO<T>([In] this Span<byte> GAJNOCDCEMH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2EDD4F0", Offset = "0x2EDC6F0", VA = "0x182EDD4F0")]
	public static NativeArray<T> ANCBIEJFJIO<T>(this ReadOnlySpan<byte> GAJNOCDCEMH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2EDECD0", Offset = "0x2EDDED0", VA = "0x182EDECD0")]
	public static ReadOnlySpan<TTo> IDLJGPAODEE<TTo, TFrom>(this ReadOnlySpan<TFrom> GAJNOCDCEMH) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2EDDCD0", Offset = "0x2EDCED0", VA = "0x182EDDCD0")]
	public static Span<byte> HPDIHAPBFNP<T>([In] this Span<byte> GAJNOCDCEMH, T JECHHBGMFLN) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B6C0", Offset = "0x6C6A8C0", VA = "0x186C6B6C0")]
	private static Enum IAMBCGCOKKE([In] ReadOnlySpan<byte> GAJNOCDCEMH, Type DOHFHJMDLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C150", Offset = "0x6C6B350", VA = "0x186C6C150")]
	public static Enum PLPPKPPJFBA([In] this Span<byte> GAJNOCDCEMH, Type DOHFHJMDLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BC70", Offset = "0x6C6AE70", VA = "0x186C6BC70")]
	public static void LAGHOKFFIHC([In] this Span<byte> GAJNOCDCEMH, Enum ODDCGAGBKJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KEGCEAAKGEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EOKEEMHKACE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6C6B030", Offset = "0x6C6A230", VA = "0x186C6B030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B5A0", Offset = "0x6C6A7A0", VA = "0x186C6B5A0")]
	[AsyncStateMachine(typeof(EOKEEMHKACE))]
	public static void CIDBFEGHOGC(this Task EBCBPNKDEPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LJAGNHGEDHJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MLBFABJIGPO : short
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
	public struct LIMOELMMABG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MLBFABJIGPO CPBLLDDDHEE;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27A24B0", Offset = "0x27A16B0", VA = "0x1827A24B0")]
		public LIMOELMMABG(MLBFABJIGPO CPBLLDDDHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory OOGDAKLIBDA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public static void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C1C0", Offset = "0x6C6B3C0", VA = "0x186C6C1C0")]
	static LJAGNHGEDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B1D560", Offset = "0x2B1C760", VA = "0x182B1D560")]
	public static LIMOELMMABG PAJCNPBMOPN(MLBFABJIGPO CPBLLDDDHEE)
	{
		return default(LIMOELMMABG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public static void HFJPLGAJNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class POEOKLDNEJG<THandle, TValue> : IDisposable where THandle : struct, EMEHIMPIDLI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> DKHHIJDHDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> JFBMKPGOEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> PLPAPBHMIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> CNMCLFAFDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int NIOEPEGKNEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4ABC2D0", Offset = "0x4ABB4D0", VA = "0x184ABC2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC6C0", Offset = "0x4ABB8C0", VA = "0x184ABC6C0")]
	public POEOKLDNEJG(Action<TValue> CNMCLFAFDJK, [Optional] Func<TValue> PLPAPBHMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBF20", Offset = "0x4ABB120", VA = "0x184ABBF20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC230", Offset = "0x4ABB430", VA = "0x184ABC230")]
	public THandle JIJNOIKPNBF(TValue JECHHBGMFLN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBFF0", Offset = "0x4ABB1F0", VA = "0x184ABBFF0")]
	public bool GJKAEPPOOPE(THandle OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC110", Offset = "0x4ABB310", VA = "0x184ABC110")]
	public bool HJCFEIDEHAE(THandle OLMIMHPMKPE, [Out] TValue JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC660", Offset = "0x4ABB860", VA = "0x184ABC660")]
	public TValue PLOCNKMCLIO(THandle OLMIMHPMKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBD10", Offset = "0x4ABAF10", VA = "0x184ABBD10")]
	public bool BBGJCOKFMOM(THandle OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC600", Offset = "0x4ABB800", VA = "0x184ABC600")]
	private THandle PIFDIDCGBCA(int KINMHNEMPOD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC1D0", Offset = "0x4ABB3D0", VA = "0x184ABC1D0")]
	private TValue IKLGAEEKKLK(int KINMHNEMPOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBCC0", Offset = "0x4ABAEC0", VA = "0x184ABBCC0")]
	private void APFBKAKKFPK(int KINMHNEMPOD, [In] THandle OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBED0", Offset = "0x4ABB0D0", VA = "0x184ABBED0")]
	private void CHLIJLINCNL(int KINMHNEMPOD, [In] TValue JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBB10", Offset = "0x4ABAD10", VA = "0x184ABBB10")]
	private THandle AMMHBDDLOFB()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4ABB940", Offset = "0x4ABAB40", VA = "0x184ABB940")]
	private void AAOHLCKADAP(THandle OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBA50", Offset = "0x4ABAC50", VA = "0x184ABBA50")]
	private int AHHDIDDAOKC(int AIIGKGFGNPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC310", Offset = "0x4ABB510", VA = "0x184ABC310")]
	private bool MLJBBILMPJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x89FAC0", Offset = "0x89ECC0", VA = "0x18089FAC0")]
	private void AMPHEAHMCAI(THandle OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBE20", Offset = "0x4ABB020", VA = "0x184ABBE20")]
	private bool BFKLOGAIEOP([Out] THandle OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC320", Offset = "0x4ABB520", VA = "0x184ABC320")]
	private bool OAONNPEOIHO([Out] THandle OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4ABBA60", Offset = "0x4ABAC60", VA = "0x184ABBA60")]
	private void ALLEIFEJCKM(THandle OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4ABC450", Offset = "0x4ABB650", VA = "0x184ABC450")]
	private void PCKHDHAGCCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EMEHIMPIDLI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int NLHHONDOFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int CMFKKIIIDLC
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
public static class JMDKGBKEPAG
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E7E480", Offset = "0x2E7D680", VA = "0x182E7E480")]
	public static bool BICMBEDLKOG<T>(this T OLMIMHPMKPE, T KDHPJMADEAD) where T : struct, EMEHIMPIDLI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E7E4A0", Offset = "0x2E7D6A0", VA = "0x182E7E4A0")]
	public static bool LHNMCLPFALC<T>(this T OLMIMHPMKPE) where T : struct, EMEHIMPIDLI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B490", Offset = "0x6C6A690", VA = "0x186C6B490")]
	public static string LGIBGAJHEFK(this EMEHIMPIDLI OLMIMHPMKPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct CBGBNPKGPME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type MMGLPNFAAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> FGGEAHMBADA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x451F8D0", Offset = "0x451EAD0", VA = "0x18451F8D0")]
	public CBGBNPKGPME(Type KMGHODOJJNM, Span<byte> GAJNOCDCEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0F990", Offset = "0x2C0EB90", VA = "0x182C0F990")]
	public static CBGBNPKGPME CGKFCMKKFDK<T>(T JECHHBGMFLN) where T : struct
	{
		return default(CBGBNPKGPME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AF20", Offset = "0x6C6A120", VA = "0x186C6AF20")]
	public static JELELNEKHOA CFMDMKLGJEH([In] CBGBNPKGPME KHFLFLECNEB)
	{
		return default(JELELNEKHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C10F60", Offset = "0x2C10160", VA = "0x182C10F60")]
	public T PLOCNKMCLIO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AFB0", Offset = "0x6C6A1B0", VA = "0x186C6AFB0")]
	public Enum PLPPKPPJFBA(Type DOHFHJMDLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C10D30", Offset = "0x2C0FF30", VA = "0x182C10D30")]
	public void HPDIHAPBFNP<T>([In] T JECHHBGMFLN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AFA0", Offset = "0x6C6A1A0", VA = "0x186C6AFA0")]
	public void LAGHOKFFIHC(Enum ODDCGAGBKJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct JELELNEKHOA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct ENMBFIFLFFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* IEGOAPJEBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* IIPKFCKHLHL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type MMGLPNFAAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> FGGEAHMBADA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NCANLJNAAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C6B2E0", Offset = "0x6C6A4E0", VA = "0x186C6B2E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x451F8D0", Offset = "0x451EAD0", VA = "0x18451F8D0")]
	public JELELNEKHOA(Type KMGHODOJJNM, ReadOnlySpan<byte> GAJNOCDCEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E9B0", Offset = "0x2E6DBB0", VA = "0x182E6E9B0")]
	public static JELELNEKHOA CGKFCMKKFDK<T>(T JECHHBGMFLN) where T : struct
	{
		return default(JELELNEKHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E830", Offset = "0x2E6DA30", VA = "0x182E6E830")]
	public static JELELNEKHOA CGKFCMKKFDK<T>(NativeArray<T> JECHHBGMFLN) where T : struct
	{
		return default(JELELNEKHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B280", Offset = "0x6C6A480", VA = "0x186C6B280")]
	public void CADOELBOBIE(Span<byte> IAPPIABCDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B1B0", Offset = "0x6C6A3B0", VA = "0x186C6B1B0")]
	public void CADOELBOBIE(NativeArray<byte> IAPPIABCDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E71970", Offset = "0x2E70B70", VA = "0x182E71970")]
	public T PLOCNKMCLIO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E6DFA0", Offset = "0x2E6D1A0", VA = "0x182E6DFA0")]
	public NativeArray<T> ANCBIEJFJIO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B450", Offset = "0x6C6A650", VA = "0x186C6B450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B320", Offset = "0x6C6A520", VA = "0x186C6B320")]
	private object LGACMGFJJMM()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LFPLMDADKNA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2EEBCA0", Offset = "0x2EEAEA0", VA = "0x182EEBCA0")]
	public static NativeArray<T> HOEBFONNHEA<T>(T JECHHBGMFLN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2EEBC50", Offset = "0x2EEAE50", VA = "0x182EEBC50")]
	public static NativeArray<T> EJHCGDAAHMK<T>(T JECHHBGMFLN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2EEBC00", Offset = "0x2EEAE00", VA = "0x182EEBC00")]
	public static NativeArray<T> CGKFCMKKFDK<T>(T JECHHBGMFLN, bool BMFPIGLLCJI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MBJMJHFAFAO<Handle> where Handle : EMEHIMPIDLI, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct EGPKFMNFDLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly MBJMJHFAFAO<Handle> GBANJLPKCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int KINMHNEMPOD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle BMIEPFDEFKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3AD23B0", Offset = "0x3AD15B0", VA = "0x183AD23B0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2910", Offset = "0x3AD1B10", VA = "0x183AD2910")]
		public EGPKFMNFDLJ(MBJMJHFAFAO<Handle> GBANJLPKCDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2520", Offset = "0x3AD1720", VA = "0x183AD2520")]
		public JAFCJFEAFPC MIFIOLMMIDE([In] JAFCJFEAFPC JNLAAHCIJJI)
		{
			return default(JAFCJFEAFPC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3AD27F0", Offset = "0x3AD19F0", VA = "0x183AD27F0")]
		public bool OLKLCFOLPIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2070", Offset = "0x3AD1270", VA = "0x183AD2070")]
		private Handle LMKKBOFGFPN(string ADNFLGLLNKI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct JAFCJFEAFPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private EGPKFMNFDLJ IHNEIICLHJD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4344540", Offset = "0x4343740", VA = "0x184344540")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4344680", Offset = "0x4343880", VA = "0x184344680")]
		public JAFCJFEAFPC(MBJMJHFAFAO<Handle> GBANJLPKCDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4344600", Offset = "0x4343800", VA = "0x184344600")]
		public bool OLKLCFOLPIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4344490", Offset = "0x4343690", VA = "0x184344490")]
		public JAFCJFEAFPC AKJNNDDNIOE()
		{
			return default(JAFCJFEAFPC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> PNHGFBCHPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> NFFKEGAKNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int CEFEPPLFMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int HMHBBBKDFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool EGHOOCIKDPJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PKFMAHJGDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4765AF0", Offset = "0x4764CF0", VA = "0x184765AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JAFCJFEAFPC CKPJEMGOFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x47655D0", Offset = "0x47647D0", VA = "0x1847655D0")]
		get
		{
			return default(JAFCJFEAFPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4767F60", Offset = "0x4767160", VA = "0x184767F60")]
	public MBJMJHFAFAO(int OAEHNBCMBMJ, Allocator PKPCACFEGCG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4767790", Offset = "0x4766990", VA = "0x184767790")]
	public void OAFCGGBDEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1B45120", Offset = "0x1B44320", VA = "0x181B45120")]
	public static int AHHDIDDAOKC(int IGDCKHODAOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27D6AA0", Offset = "0x27D5CA0", VA = "0x1827D6AA0")]
	public static bool PPNKAHMAGLC(int IGDCKHODAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4766A40", Offset = "0x4765C40", VA = "0x184766A40")]
	public bool KPHMALLKDCL(int KINMHNEMPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4767D20", Offset = "0x4766F20", VA = "0x184767D20")]
	public bool PNPBPMBMAEG(Handle OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4766360", Offset = "0x4765560", VA = "0x184766360")]
	public Handle GPHKDPGFHKL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47671B0", Offset = "0x47663B0", VA = "0x1847671B0")]
	public void LLBFLGFCHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4765D20", Offset = "0x4764F20", VA = "0x184765D20")]
	public void DCEBNANFHBO(Handle OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47665D0", Offset = "0x47657D0", VA = "0x1847665D0")]
	public bool JFEAIMKACPG(Handle OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x931B30", Offset = "0x930D30", VA = "0x180931B30")]
	private bool KDLCFJOICBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47679D0", Offset = "0x4766BD0", VA = "0x1847679D0")]
	private bool PFPDBNFMFAJ(int KINMHNEMPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4765660", Offset = "0x4764860", VA = "0x184765660")]
	private void AFKALNPBNKI([Out] int KINMHNEMPOD, [Out] int AIIGKGFGNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4765E70", Offset = "0x4765070", VA = "0x184765E70")]
	private void FFFLKHHBGPB(Handle OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4766310", Offset = "0x4765510", VA = "0x184766310")]
	private void GMAKOCEHGBC(int KINMHNEMPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4767620", Offset = "0x4766820", VA = "0x184767620")]
	private bool MFFGDMNEMLD([Out] int KINMHNEMPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4765B70", Offset = "0x4764D70", VA = "0x184765B70")]
	private static Handle CKMPGPNHHKC(int KINMHNEMPOD, int AIIGKGFGNPA)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct APBBLCBEBKE<Handle, T> where Handle : EMEHIMPIDLI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MBJMJHFAFAO<Handle> DLHEHGLHPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] LBFDMMEDDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> GBOOGJMHKLD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x447D600", Offset = "0x447C800", VA = "0x18447D600")]
	public APBBLCBEBKE(int OAEHNBCMBMJ, [Optional] Action<T> GBOOGJMHKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x447D320", Offset = "0x447C520", VA = "0x18447D320")]
	public void OAFCGGBDEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x447C150", Offset = "0x447B350", VA = "0x18447C150")]
	public bool HJCFEIDEHAE(Handle OLMIMHPMKPE, [Out] T JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x447C9A0", Offset = "0x447BBA0", VA = "0x18447C9A0")]
	public Handle JIJNOIKPNBF(T JMJAOKJJFGJ)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x447C540", Offset = "0x447B740", VA = "0x18447C540")]
	public void JIGEBKMLJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x447D0F0", Offset = "0x447C2F0", VA = "0x18447D0F0")]
	public void LOGGCHCCBFB(Handle OLMIMHPMKPE, [Out] T MAIIJBOIFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x447CE50", Offset = "0x447C050", VA = "0x18447CE50")]
	public void LOGGCHCCBFB(Handle OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x447BDA0", Offset = "0x447AFA0", VA = "0x18447BDA0")]
	public bool FPKGMEGDEJG(Handle OLMIMHPMKPE, [Out] T MAIIJBOIFDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x447BCC0", Offset = "0x447AEC0", VA = "0x18447BCC0")]
	public bool FPKGMEGDEJG(Handle OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x447C2B0", Offset = "0x447B4B0", VA = "0x18447C2B0")]
	private T HJGCKEGIOGD(int KINMHNEMPOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x447CCC0", Offset = "0x447BEC0", VA = "0x18447CCC0")]
	private void JKKHJFEDNFA(int MLLNGOMGGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct DJLDPGIMHDA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] LJIEGDEDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int KOHJFMFCHKH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x21F92F0", Offset = "0x21F84F0", VA = "0x1821F92F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2C11D00", Offset = "0x2C10F00", VA = "0x182C11D00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> FGGEAHMBADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5B32C80", Offset = "0x5B31E80", VA = "0x185B32C80")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LHECKIGJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x11487F0", Offset = "0x11479F0", VA = "0x1811487F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5B32E90", Offset = "0x5B32090", VA = "0x185B32E90")]
	public DJLDPGIMHDA(int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5B32DE0", Offset = "0x5B31FE0", VA = "0x185B32DE0")]
	public int MHOEOPCMNNM(T JECHHBGMFLN, int NJJFLJLDLKI, int NDEFEFEFLCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5B32B80", Offset = "0x5B31D80", VA = "0x185B32B80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct IMGNAIKAMJF<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct IHACPNPFHFE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IMGNAIKAMJF<T> NAGHBLHDGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int KINMHNEMPOD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4173010", Offset = "0x4172210", VA = "0x184173010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x41730B0", Offset = "0x41722B0", VA = "0x1841730B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4173080", Offset = "0x4172280", VA = "0x184173080")]
		public IHACPNPFHFE(IMGNAIKAMJF<T> NAGHBLHDGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4172F80", Offset = "0x4172180", VA = "0x184172F80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4172FC0", Offset = "0x41721C0", VA = "0x184172FC0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DJLDPGIMHDA<T> LJIEGDEDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int KOHJFMFCHKH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4183820", Offset = "0x4182A20", VA = "0x184183820")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4183620", Offset = "0x4182820", VA = "0x184183620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int PKFMAHJGDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x41832C0", Offset = "0x41824C0", VA = "0x1841832C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LHECKIGJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4183D70", Offset = "0x4182F70", VA = "0x184183D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> FGGEAHMBADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4183760", Offset = "0x4182960", VA = "0x184183760")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4183E60", Offset = "0x4183060", VA = "0x184183E60")]
	public IMGNAIKAMJF(int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4183260", Offset = "0x4182460", VA = "0x184183260")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4183660", Offset = "0x4182860", VA = "0x184183660")]
	public void JIJNOIKPNBF(T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4183030", Offset = "0x4182230", VA = "0x184183030")]
	internal void AHMLDHNGNLD(int LCNCMFGPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x41832F0", Offset = "0x41824F0", VA = "0x1841832F0")]
	public void BLPAAOKFBGM(int KINMHNEMPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4183B40", Offset = "0x4182D40", VA = "0x184183B40")]
	public void PBGDBMEJKFG(int EIGMELAECKI, int BBMKIHEGKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x41838B0", Offset = "0x4182AB0", VA = "0x1841838B0")]
	public int MHOEOPCMNNM(T JECHHBGMFLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x41833D0", Offset = "0x41825D0", VA = "0x1841833D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4183410", Offset = "0x4182610", VA = "0x184183410", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4183DB0", Offset = "0x4182FB0", VA = "0x184183DB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4183DF0", Offset = "0x4182FF0", VA = "0x184183DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x41834D0", Offset = "0x41826D0", VA = "0x1841834D0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void HDALCCFOKCG(int JECHHBGMFLN, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4183930", Offset = "0x4182B30", VA = "0x184183930")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void NDJLAEHAJMC(int EIGMELAECKI, int BBMKIHEGKMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OJDOCFPBNPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int ECDKJELMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int NDEFEFEFLCE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AMCDMMKKGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD00", Offset = "0x8FAF00", VA = "0x1808FBD00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x27BA930", Offset = "0x27B9B30", VA = "0x1827BA930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x601C7D0", Offset = "0x601B9D0", VA = "0x18601C7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JNEIHJBJIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD00", Offset = "0x8FAF00", VA = "0x1808FBD00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC02B40", Offset = "0xC01D40", VA = "0x180C02B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ECFIGNEHKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C2B0", Offset = "0x6C6B4B0", VA = "0x186C6C2B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C2C0", Offset = "0x6C6B4C0", VA = "0x186C6C2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A040", Offset = "0xA09240", VA = "0x180A0A040")]
	private OJDOCFPBNPC(int ECDKJELMFBH, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2210640", Offset = "0x220F840", VA = "0x182210640")]
	public static OJDOCFPBNPC IHFEAOPAPBH(int ECDKJELMFBH, int NDEFEFEFLCE)
	{
		return default(OJDOCFPBNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C2D0", Offset = "0x6C6B4D0", VA = "0x186C6C2D0")]
	public static OJDOCFPBNPC PIFCFKEJMBF(int NJJFLJLDLKI, int BBMKIHEGKMC)
	{
		return default(OJDOCFPBNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C2E0", Offset = "0x6C6B4E0", VA = "0x186C6C2E0", Slot = "3")]
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
