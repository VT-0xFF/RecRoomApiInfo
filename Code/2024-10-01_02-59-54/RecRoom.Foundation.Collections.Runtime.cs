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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8730", Offset = "0x6DE7B30", VA = "0x186DE8730", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HHAGDMLNHND
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7B60", Offset = "0x6DE6F60", VA = "0x186DE7B60")]
	public static void GBDLBKPCJED(this GameObject JPONDMDOHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7AC0", Offset = "0x6DE6EC0", VA = "0x186DE7AC0")]
	public static void GBDLBKPCJED(this Component FCNHHPDOLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7A20", Offset = "0x6DE6E20", VA = "0x186DE7A20")]
	public static void GBDLBKPCJED(this ScriptableObject ANEPIMCGFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OPKOKLPDDAM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8AA0", Offset = "0x6DE7EA0", VA = "0x186DE8AA0")]
	public static Span<byte> MFPMEFLPHKK(this NativeArray<byte> AFBDFGIDJPF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DE89F0", Offset = "0x6DE7DF0", VA = "0x186DE89F0")]
	public static ReadOnlySpan<byte> HAOACBKKEKA(this NativeArray<byte> AFBDFGIDJPF)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3000150", Offset = "0x2FFF550", VA = "0x183000150")]
	public static NativeArray<T> EBGDNGBAEHL<T>(this NativeArray<T> AFBDFGIDJPF, CNPCHKHABFO JBJDGFHGGAA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3000110", Offset = "0x2FFF510", VA = "0x183000110")]
	public static NativeArray<T> EBGDNGBAEHL<T>(this NativeArray<T> AFBDFGIDJPF, int AKMLIMIBFHO) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HLGEOLIINBD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E88870", Offset = "0x2E87C70", VA = "0x182E88870")]
	public static string KGIPGLPINGN<T>(this NativeArray<T> AFBDFGIDJPF, string PJBAHPLDNPP = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IMCKPGKDADL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA8370", Offset = "0x2EA7770", VA = "0x182EA8370")]
	public static T JEMJOLBMCNL<T>([In] this ReadOnlySpan<byte> MKIADFJJCPA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA8140", Offset = "0x2EA7540", VA = "0x182EA8140")]
	public static T JEMJOLBMCNL<T>([In] this Span<byte> MKIADFJJCPA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7AF0", Offset = "0x2EA6EF0", VA = "0x182EA7AF0")]
	public static NativeArray<T> ANBNKBIJDGM<T>(this ReadOnlySpan<byte> MKIADFJJCPA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA220", Offset = "0x2EA9620", VA = "0x182EAA220")]
	public static ReadOnlySpan<TTo> KHLICADDBDF<TTo, TFrom>(this ReadOnlySpan<TFrom> MKIADFJJCPA) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9510", Offset = "0x2EA8910", VA = "0x182EA9510")]
	public static Span<byte> JOJCHNFNPDL<T>([In] this Span<byte> MKIADFJJCPA, T LIHHDPOHLDK) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7C70", Offset = "0x6DE7070", VA = "0x186DE7C70")]
	private static Enum NACFOJLFBMC([In] ReadOnlySpan<byte> MKIADFJJCPA, Type PPKDMHECOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7C00", Offset = "0x6DE7000", VA = "0x186DE7C00")]
	public static Enum KNEMNLAPOBM([In] this Span<byte> MKIADFJJCPA, Type PPKDMHECOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8220", Offset = "0x6DE7620", VA = "0x186DE8220")]
	public static void NBGNLEGNLMN([In] this Span<byte> MKIADFJJCPA, Enum CCLPDLLIEKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MMOELLNKFHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GHGPOJNIJIO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6DE78A0", Offset = "0x6DE6CA0", VA = "0x186DE78A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DE87C0", Offset = "0x6DE7BC0", VA = "0x186DE87C0")]
	[AsyncStateMachine(typeof(GHGPOJNIJIO))]
	public static void KENKBMNKLBN(this Task HIKBGGAGLAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CCHJOKJIMGO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum KGIBIGBLKLN : short
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
	public struct KIGKNIFMNDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly KGIBIGBLKLN GMJINMLEEAC;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27D5BB0", Offset = "0x27D4FB0", VA = "0x1827D5BB0")]
		public KIGKNIFMNDH(KGIBIGBLKLN GMJINMLEEAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory EALJOJCJEEO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public static void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7670", Offset = "0x6DE6A70", VA = "0x186DE7670")]
	static CCHJOKJIMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AAF0", Offset = "0x2B49EF0", VA = "0x182B4AAF0")]
	public static KIGKNIFMNDH HFGOHAOKMGP(KGIBIGBLKLN GMJINMLEEAC)
	{
		return default(KIGKNIFMNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public static void OLCPLCPHFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class EGOMDMDNJIL<THandle, TValue> : IDisposable where THandle : struct, KCAADKMDGIA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> FGIMIPJFHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> BIHDACIMKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> EAMEPMFNOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> HLLIFAFBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int KBKOCCHEMCH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3B32770", Offset = "0x3B31B70", VA = "0x183B32770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B32AC0", Offset = "0x3B31EC0", VA = "0x183B32AC0")]
	public EGOMDMDNJIL(Action<TValue> HLLIFAFBCLA, [Optional] Func<TValue> EAMEPMFNOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B31F50", Offset = "0x3B31350", VA = "0x183B31F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B328D0", Offset = "0x3B31CD0", VA = "0x183B328D0")]
	public THandle PJLPMKJIOFF(TValue LIHHDPOHLDK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B32220", Offset = "0x3B31620", VA = "0x183B32220")]
	public bool LBHGGLOEOHI(THandle PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B31E80", Offset = "0x3B31280", VA = "0x183B31E80")]
	public bool CPMADEOKHEK(THandle PKDPMCLKPHH, [Out] TValue LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3B320F0", Offset = "0x3B314F0", VA = "0x183B320F0")]
	public TValue JEMJOLBMCNL(THandle PKDPMCLKPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B327B0", Offset = "0x3B31BB0", VA = "0x183B327B0")]
	public bool PJAKFOIGPDG(THandle PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B32090", Offset = "0x3B31490", VA = "0x183B32090")]
	private THandle HGNNNNOOEPF(int AEAHMAMPNLO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B32030", Offset = "0x3B31430", VA = "0x183B32030")]
	private TValue GMGOKDOKMEE(int AEAHMAMPNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B32720", Offset = "0x3B31B20", VA = "0x183B32720")]
	private void OEBPDNHCLCP(int AEAHMAMPNLO, [In] THandle PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B32510", Offset = "0x3B31910", VA = "0x183B32510")]
	private void MICHIDJGAIF(int AEAHMAMPNLO, [In] TValue LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B32560", Offset = "0x3B31960", VA = "0x183B32560")]
	private THandle NCDOKPODDPA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B31D60", Offset = "0x3B31160", VA = "0x183B31D60")]
	private void BBMLBDLJACO(THandle PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B31D50", Offset = "0x3B31150", VA = "0x183B31D50")]
	private int BABILKKFBEI(int DMDALLEEEHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B32210", Offset = "0x3B31610", VA = "0x183B32210")]
	private bool LAPDKGIMLIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D30", Offset = "0x8A9130", VA = "0x1808A9D30")]
	private void KIINGNCDPIF(THandle PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B31C90", Offset = "0x3B31090", VA = "0x183B31C90")]
	private bool AEDHLEIHMOP([Out] THandle PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B32980", Offset = "0x3B31D80", VA = "0x183B32980")]
	private bool PLPEANBGCFM([Out] THandle PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B32150", Offset = "0x3B31550", VA = "0x183B32150")]
	private void KMICIIIKGKO(THandle PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B32350", Offset = "0x3B31750", VA = "0x183B32350")]
	private void LJHHNAOJBFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KCAADKMDGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int LGPOLAJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KMCLANLNCEJ
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
public static class GAMMFIAAEHN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E649F0", Offset = "0x2E63DF0", VA = "0x182E649F0")]
	public static bool FANDGDEPMPD<T>(this T PKDPMCLKPHH, T OCKBFCIKBEN) where T : struct, KCAADKMDGIA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E64A10", Offset = "0x2E63E10", VA = "0x182E64A10")]
	public static bool OOLCMFGMABL<T>(this T PKDPMCLKPHH) where T : struct, KCAADKMDGIA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7790", Offset = "0x6DE6B90", VA = "0x186DE7790")]
	public static string IBLBLLHOCDI(this KCAADKMDGIA PKDPMCLKPHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct ONJJKKKIGOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type FILMCONEKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> KCCMPBMFEMP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x45BC9D0", Offset = "0x45BBDD0", VA = "0x1845BC9D0")]
	public ONJJKKKIGOC(Type IFENGFJOFEK, Span<byte> MKIADFJJCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB660", Offset = "0x2FFAA60", VA = "0x182FFB660")]
	public static ONJJKKKIGOC JJFGKJCEFJO<T>(T LIHHDPOHLDK) where T : struct
	{
		return default(ONJJKKKIGOC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE88E0", Offset = "0x6DE7CE0", VA = "0x186DE88E0")]
	public static PNKJNCEHIKB ICFKEBCLOFF([In] ONJJKKKIGOC CMEHKBHKHFB)
	{
		return default(PNKJNCEHIKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FFADB0", Offset = "0x2FFA1B0", VA = "0x182FFADB0")]
	public T JEMJOLBMCNL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8960", Offset = "0x6DE7D60", VA = "0x186DE8960")]
	public Enum KNEMNLAPOBM(Type PPKDMHECOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC5A0", Offset = "0x2FFB9A0", VA = "0x182FFC5A0")]
	public void JOJCHNFNPDL<T>([In] T LIHHDPOHLDK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DE89E0", Offset = "0x6DE7DE0", VA = "0x186DE89E0")]
	public void NBGNLEGNLMN(Enum CCLPDLLIEKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct PNKJNCEHIKB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct KLJOAGEKPGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* DEDMKHBDEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* GMJEEHIPJHH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type FILMCONEKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> KCCMPBMFEMP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NDEEOPEAONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8B50", Offset = "0x6DE7F50", VA = "0x186DE8B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x45BC9D0", Offset = "0x45BBDD0", VA = "0x1845BC9D0")]
	public PNKJNCEHIKB(Type IFENGFJOFEK, ReadOnlySpan<byte> MKIADFJJCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x301BF40", Offset = "0x301B340", VA = "0x18301BF40")]
	public static PNKJNCEHIKB JJFGKJCEFJO<T>(T LIHHDPOHLDK) where T : struct
	{
		return default(PNKJNCEHIKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x301C080", Offset = "0x301B480", VA = "0x18301C080")]
	public static PNKJNCEHIKB JJFGKJCEFJO<T>(NativeArray<T> LIHHDPOHLDK) where T : struct
	{
		return default(PNKJNCEHIKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8C60", Offset = "0x6DE8060", VA = "0x186DE8C60")]
	public void FNBNPIELHGO(Span<byte> AHGELIGBIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8B90", Offset = "0x6DE7F90", VA = "0x186DE8B90")]
	public void FNBNPIELHGO(NativeArray<byte> AHGELIGBIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x301A840", Offset = "0x3019C40", VA = "0x18301A840")]
	public T JEMJOLBMCNL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x301A740", Offset = "0x3019B40", VA = "0x18301A740")]
	public NativeArray<T> ANBNKBIJDGM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8DF0", Offset = "0x6DE81F0", VA = "0x186DE8DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8CC0", Offset = "0x6DE80C0", VA = "0x186DE8CC0")]
	private object MJFCBKCOPPJ()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IHNJGBJLBGF
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1B70", Offset = "0x2EA0F70", VA = "0x182EA1B70")]
	public static NativeArray<T> JDGKGFKCHEB<T>(T LIHHDPOHLDK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1B20", Offset = "0x2EA0F20", VA = "0x182EA1B20")]
	public static NativeArray<T> FODIFBMJNFB<T>(T LIHHDPOHLDK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1BC0", Offset = "0x2EA0FC0", VA = "0x182EA1BC0")]
	public static NativeArray<T> JJFGKJCEFJO<T>(T LIHHDPOHLDK, bool JJEOCOJGEBM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FACNKIFIGJN<Handle> where Handle : KCAADKMDGIA, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct CLHEHHLJHCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly FACNKIFIGJN<Handle> GOBLLDAPGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int AEAHMAMPNLO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle ADGMNACGDML
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x532D590", Offset = "0x532C990", VA = "0x18532D590")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x532DE90", Offset = "0x532D290", VA = "0x18532DE90")]
		public CLHEHHLJHCM(FACNKIFIGJN<Handle> GOBLLDAPGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x532D4F0", Offset = "0x532C8F0", VA = "0x18532D4F0")]
		public MFNJDPLAMPJ AALKPJMFIHM([In] MFNJDPLAMPJ PAHNKMKPPCD)
		{
			return default(MFNJDPLAMPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x532DA10", Offset = "0x532CE10", VA = "0x18532DA10")]
		public bool NPHJBLECBIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x532DE30", Offset = "0x532D230", VA = "0x18532DE30")]
		private Handle OJBMIIBKMBF(string ADPAIBGIHMB)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct MFNJDPLAMPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private CLHEHHLJHCM JDCKMHNILPN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4819420", Offset = "0x4818820", VA = "0x184819420")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x48195E0", Offset = "0x48189E0", VA = "0x1848195E0")]
		public MFNJDPLAMPJ(FACNKIFIGJN<Handle> GOBLLDAPGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x48195A0", Offset = "0x48189A0", VA = "0x1848195A0")]
		public bool NPHJBLECBIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x48194A0", Offset = "0x48188A0", VA = "0x1848194A0")]
		public MFNJDPLAMPJ MKNNDFMGFGD()
		{
			return default(MFNJDPLAMPJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> DBPNDHLIBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> IKKIPOEJDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int KJHBFDDCBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int PNEFFIKJADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool EBDNAKBFCKO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OGMNDHJBABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8050", Offset = "0x3EE7450", VA = "0x183EE8050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MFNJDPLAMPJ DHAIEBCPEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7C00", Offset = "0x3EE7000", VA = "0x183EE7C00")]
		get
		{
			return default(MFNJDPLAMPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3EE86A0", Offset = "0x3EE7AA0", VA = "0x183EE86A0")]
	public FACNKIFIGJN(int NBBKLECJEBP, Allocator MGFIHPDNFPH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7E50", Offset = "0x3EE7250", VA = "0x183EE7E50")]
	public void KMANLEPJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1B87C60", Offset = "0x1B87060", VA = "0x181B87C60")]
	public static int BABILKKFBEI(int IDIHIILANOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x280EA40", Offset = "0x280DE40", VA = "0x18280EA40")]
	public static bool BLKBHGCBOGE(int IDIHIILANOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3EE81C0", Offset = "0x3EE75C0", VA = "0x183EE81C0")]
	public bool OHEKAJBOAEM(int AEAHMAMPNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3EE63F0", Offset = "0x3EE57F0", VA = "0x183EE63F0")]
	public bool BJBCGIHMAJC(Handle PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3EE79E0", Offset = "0x3EE6DE0", VA = "0x183EE79E0")]
	public Handle FHFCOMEMGLL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7510", Offset = "0x3EE6910", VA = "0x183EE7510")]
	public void EDBKBJFGDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7AB0", Offset = "0x3EE6EB0", VA = "0x183EE7AB0")]
	public void GFNDNJAJNKD(Handle PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6170", Offset = "0x3EE5570", VA = "0x183EE6170")]
	public bool AMPODMOJGMN(Handle PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x982980", Offset = "0x981D80", VA = "0x180982980")]
	private bool OKHDIKHFDAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6390", Offset = "0x3EE5790", VA = "0x183EE6390")]
	private bool BFFCPPDLEJM(int AEAHMAMPNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5F40", Offset = "0x3EE5340", VA = "0x183EE5F40")]
	private void AKCDEEJPOBC([Out] int AEAHMAMPNLO, [Out] int DMDALLEEEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6BE0", Offset = "0x3EE5FE0", VA = "0x183EE6BE0")]
	private void ECNEGLOIPPJ(Handle PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7CA0", Offset = "0x3EE70A0", VA = "0x183EE7CA0")]
	private void IKKOFNPFIDP(int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6930", Offset = "0x3EE5D30", VA = "0x183EE6930")]
	private bool DBFFFAGIFGC([Out] int AEAHMAMPNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8510", Offset = "0x3EE7910", VA = "0x183EE8510")]
	private static Handle PBCMNILANKL(int AEAHMAMPNLO, int DMDALLEEEHI)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct CLDABECMNED<Handle, T> where Handle : KCAADKMDGIA, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FACNKIFIGJN<Handle> NNGJNFNGAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] HAMMBLDDLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> NHJKFKEOLHI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x532D310", Offset = "0x532C710", VA = "0x18532D310")]
	public CLDABECMNED(int NBBKLECJEBP, [Optional] Action<T> NHJKFKEOLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x532C790", Offset = "0x532BB90", VA = "0x18532C790")]
	public void KMANLEPJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x532BF60", Offset = "0x532B360", VA = "0x18532BF60")]
	public bool CPMADEOKHEK(Handle PKDPMCLKPHH, [Out] T PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x532D110", Offset = "0x532C510", VA = "0x18532D110")]
	public Handle PJLPMKJIOFF(T PBAACPJGKNP)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x532C010", Offset = "0x532B410", VA = "0x18532C010")]
	public void GFCJDKNNJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x532CA70", Offset = "0x532BE70", VA = "0x18532CA70")]
	public void MAHJHHAHNPL(Handle PKDPMCLKPHH, [Out] T GKDOMIOPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x532CD30", Offset = "0x532C130", VA = "0x18532CD30")]
	public void MAHJHHAHNPL(Handle PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x532B8D0", Offset = "0x532ACD0", VA = "0x18532B8D0")]
	public bool AKNIOHKIFGB(Handle PKDPMCLKPHH, [Out] T GKDOMIOPDII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x532BAB0", Offset = "0x532AEB0", VA = "0x18532BAB0")]
	public bool AKNIOHKIFGB(Handle PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x532BD80", Offset = "0x532B180", VA = "0x18532BD80")]
	private T CEOINHKKKPF(int AEAHMAMPNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x532CE10", Offset = "0x532C210", VA = "0x18532CE10")]
	private void OCKFAEMPIBE(int JNCNJLFGPMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct JIGPDJIIFGH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] MPMEGOKIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int IDHDBIDGMFM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x222C340", Offset = "0x222B740", VA = "0x18222C340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2FCD130", Offset = "0x2FCC530", VA = "0x182FCD130")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> KCCMPBMFEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x442E3F0", Offset = "0x442D7F0", VA = "0x18442E3F0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ODMBGBHFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x11BAFF0", Offset = "0x11BA3F0", VA = "0x1811BAFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x442E490", Offset = "0x442D890", VA = "0x18442E490")]
	public JIGPDJIIFGH(int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x442E160", Offset = "0x442D560", VA = "0x18442E160")]
	public int APCLAAIMPOG(T LIHHDPOHLDK, int AKMLIMIBFHO, int MGEMHICLKEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x442E2E0", Offset = "0x442D6E0", VA = "0x18442E2E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct OEJBDDIGDHA<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct NLPEJFPJAKL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private OEJBDDIGDHA<T> HGMKHDHJCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int AEAHMAMPNLO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x48D8700", Offset = "0x48D7B00", VA = "0x1848D8700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x48D87A0", Offset = "0x48D7BA0", VA = "0x1848D87A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x48D8770", Offset = "0x48D7B70", VA = "0x1848D8770")]
		public NLPEJFPJAKL(OEJBDDIGDHA<T> HGMKHDHJCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x48D8670", Offset = "0x48D7A70", VA = "0x1848D8670", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x48D86B0", Offset = "0x48D7AB0", VA = "0x1848D86B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private JIGPDJIIFGH<T> MPMEGOKIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int IDHDBIDGMFM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FB00", Offset = "0x4A5EF00", VA = "0x184A5FB00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F2E0", Offset = "0x4A5E6E0", VA = "0x184A5F2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OGMNDHJBABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FAD0", Offset = "0x4A5EED0", VA = "0x184A5FAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ODMBGBHFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F370", Offset = "0x4A5E770", VA = "0x184A5F370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> KCCMPBMFEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FB90", Offset = "0x4A5EF90", VA = "0x184A5FB90")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4A5FE10", Offset = "0x4A5F210", VA = "0x184A5FE10")]
	public OEJBDDIGDHA(int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F3B0", Offset = "0x4A5E7B0", VA = "0x184A5F3B0")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4A5FC50", Offset = "0x4A5F050", VA = "0x184A5FC50")]
	public void PJLPMKJIOFF(T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F890", Offset = "0x4A5EC90", VA = "0x184A5F890")]
	internal void LMEAIIIFJNL(int MLLKNBDHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F1F0", Offset = "0x4A5E5F0", VA = "0x184A5F1F0")]
	public void CAKFPLKKIFP(int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F410", Offset = "0x4A5E810", VA = "0x184A5F410")]
	public void GMGMMFGONAB(int MEFHDOINLGD, int LFHCJICMNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4A5EF60", Offset = "0x4A5E360", VA = "0x184A5EF60")]
	public int APCLAAIMPOG(T LIHHDPOHLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F330", Offset = "0x4A5E730", VA = "0x184A5F330", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F660", Offset = "0x4A5EA60", VA = "0x184A5F660", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A5FD60", Offset = "0x4A5F160", VA = "0x184A5FD60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4A5FDA0", Offset = "0x4A5F1A0", VA = "0x184A5FDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F740", Offset = "0x4A5EB40", VA = "0x184A5F740")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void ICHENILIPKC(int LIHHDPOHLDK, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4A5EFE0", Offset = "0x4A5E3E0", VA = "0x184A5EFE0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void BNFNDGIJDPP(int MEFHDOINLGD, int LFHCJICMNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CNPCHKHABFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int GMCJIJBLJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int MGEMHICLKEP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BLOODECNJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x27EC6E0", Offset = "0x27EBAE0", VA = "0x1827EC6E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6196640", Offset = "0x6195A40", VA = "0x186196640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int CLFHAIPBDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ABKGAJKKDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE76F0", Offset = "0x6DE6AF0", VA = "0x186DE76F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE76D0", Offset = "0x6DE6AD0", VA = "0x186DE76D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
	private CNPCHKHABFO(int GMCJIJBLJPF, int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x22429B0", Offset = "0x2241DB0", VA = "0x1822429B0")]
	public static CNPCHKHABFO EIELIIGOLKO(int GMCJIJBLJPF, int MGEMHICLKEP)
	{
		return default(CNPCHKHABFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6DE76E0", Offset = "0x6DE6AE0", VA = "0x186DE76E0")]
	public static CNPCHKHABFO OJINDAFABBJ(int AKMLIMIBFHO, int LFHCJICMNKA)
	{
		return default(CNPCHKHABFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7700", Offset = "0x6DE6B00", VA = "0x186DE7700", Slot = "3")]
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
