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
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D527A0", Offset = "0x6D51BA0", VA = "0x186D527A0", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BHCKAIEMFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D512E0", Offset = "0x6D506E0", VA = "0x186D512E0")]
	public static void HOMFIGAOGJC(this GameObject NEMCGAENDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D51380", Offset = "0x6D50780", VA = "0x186D51380")]
	public static void HOMFIGAOGJC(this Component COMALCPHDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D51420", Offset = "0x6D50820", VA = "0x186D51420")]
	public static void HOMFIGAOGJC(this ScriptableObject KEMMAGPKCMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KOFGDNMIBCM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D52640", Offset = "0x6D51A40", VA = "0x186D52640")]
	public static Span<byte> GAMDECFMAKI(this NativeArray<byte> EFKOIGFMOHD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D526F0", Offset = "0x6D51AF0", VA = "0x186D526F0")]
	public static ReadOnlySpan<byte> MAIKGDPKHMK(this NativeArray<byte> EFKOIGFMOHD)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B7D0", Offset = "0x2F7ABD0", VA = "0x182F7B7D0")]
	public static NativeArray<T> BOKHEPOKEPN<T>(this NativeArray<T> EFKOIGFMOHD, OJHMBNDHAOH GOLOFNEFPEG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B790", Offset = "0x2F7AB90", VA = "0x182F7B790")]
	public static NativeArray<T> BOKHEPOKEPN<T>(this NativeArray<T> EFKOIGFMOHD, int ICLFANODKJK) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AEABNEDJPIF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x35C2D30", Offset = "0x35C2130", VA = "0x1835C2D30")]
	public static string KDPIJFHMOKK<T>(this NativeArray<T> EFKOIGFMOHD, string DODFMGCBGGJ = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DCNKOGNAOCH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF230", Offset = "0x2CDE630", VA = "0x182CDF230")]
	public static T GEKLBPFDDHO<T>([In] this ReadOnlySpan<byte> LFKJJKCOKKE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF9C0", Offset = "0x2CDEDC0", VA = "0x182CDF9C0")]
	public static T GEKLBPFDDHO<T>([In] this Span<byte> LFKJJKCOKKE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEA40", Offset = "0x2CDDE40", VA = "0x182CDEA40")]
	public static NativeArray<T> BEMECHFHJHG<T>(this ReadOnlySpan<byte> LFKJJKCOKKE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA260", Offset = "0x2CA9660", VA = "0x182CAA260")]
	public static ReadOnlySpan<TTo> FONPCAJDJAA<TTo, TFrom>(this ReadOnlySpan<TFrom> LFKJJKCOKKE) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0440", Offset = "0x2CDF840", VA = "0x182CE0440")]
	public static Span<byte> NBJJIKECOBK<T>([In] this Span<byte> LFKJJKCOKKE, T PFKKDHPJFEH) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D514C0", Offset = "0x6D508C0", VA = "0x186D514C0")]
	private static Enum IGPIHEJDIMN([In] ReadOnlySpan<byte> LFKJJKCOKKE, Type CGMPPMEOEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D51A60", Offset = "0x6D50E60", VA = "0x186D51A60")]
	public static Enum LBPKKKLKAAL([In] this Span<byte> LFKJJKCOKKE, Type CGMPPMEOEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D51AD0", Offset = "0x6D50ED0", VA = "0x186D51AD0")]
	public static void NIMBIOGLKKA([In] this Span<byte> LFKJJKCOKKE, Enum LFKMIMEIEKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JGLDHBMFEKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PLOJNEPLCGM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D528F0", Offset = "0x6D51CF0", VA = "0x186D528F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D52410", Offset = "0x6D51810", VA = "0x186D52410")]
	[AsyncStateMachine(typeof(PLOJNEPLCGM))]
	public static void NODAMJMEHPD(this Task BNBMPMKBBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IKEICHGJLGH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GCFOLHNPBBC : short
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
	public struct MLJKDJNBIKB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly GCFOLHNPBBC PBFBBOFLBNL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2824000", Offset = "0x2823400", VA = "0x182824000")]
		public MLJKDJNBIKB(GCFOLHNPBBC PBFBBOFLBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory CENOIGEPJMG;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public static void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D523A0", Offset = "0x6D517A0", VA = "0x186D523A0")]
	static IKEICHGJLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3E60", Offset = "0x2BC3260", VA = "0x182BC3E60")]
	public static MLJKDJNBIKB DBGOGKAAMOM(GCFOLHNPBBC PBFBBOFLBNL)
	{
		return default(MLJKDJNBIKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public static void MGBJFJGAFDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class KFLENNGBJHK<THandle, TValue> : IDisposable where THandle : struct, FLCBANDPIBK where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> DPKJKDBALEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> MHFHLBKJCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> GHLLJOKPBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> PMCLBCHBBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int OCBOCBHFLPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x44FDF10", Offset = "0x44FD310", VA = "0x1844FDF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x44FE000", Offset = "0x44FD400", VA = "0x1844FE000")]
	public KFLENNGBJHK(Action<TValue> PMCLBCHBBGG, [Optional] Func<TValue> GHLLJOKPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x44FD3B0", Offset = "0x44FC7B0", VA = "0x1844FD3B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x44FD6A0", Offset = "0x44FCAA0", VA = "0x1844FD6A0")]
	public THandle FNBCENOGBNB(TValue PFKKDHPJFEH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x44FD7A0", Offset = "0x44FCBA0", VA = "0x1844FD7A0")]
	public bool GGKFCAFBJMN(THandle DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x44FDB80", Offset = "0x44FCF80", VA = "0x1844FDB80")]
	public bool IELONOIKEDC(THandle DOBBMOLDHPN, [Out] TValue PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x44FD740", Offset = "0x44FCB40", VA = "0x1844FD740")]
	public TValue GEKLBPFDDHO(THandle DOBBMOLDHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x44FDA70", Offset = "0x44FCE70", VA = "0x1844FDA70")]
	public bool ICLDDBMHILA(THandle DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x44FDEA0", Offset = "0x44FD2A0", VA = "0x1844FDEA0")]
	private THandle NPBOFBLHLEI(int OBFJPFHENMC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x44FD480", Offset = "0x44FC880", VA = "0x1844FD480")]
	private TValue FFDPDONAMEJ(int OBFJPFHENMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x44FDCA0", Offset = "0x44FD0A0", VA = "0x1844FDCA0")]
	private void LBLKKNBPNGF(int OBFJPFHENMC, [In] THandle DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x44FDC40", Offset = "0x44FD040", VA = "0x1844FDC40")]
	private void IICMCIBBOFF(int OBFJPFHENMC, [In] TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44FDCF0", Offset = "0x44FD0F0", VA = "0x1844FDCF0")]
	private THandle LKFEFKEGFIA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44FD590", Offset = "0x44FC990", VA = "0x1844FD590")]
	private void FKGHBAIOJDK(THandle DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x44FDF00", Offset = "0x44FD300", VA = "0x1844FDF00")]
	private int OBDODJEAGGJ(int FCPMNBOKKMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x44FDC90", Offset = "0x44FD090", VA = "0x1844FDC90")]
	private bool JGEPPHINFOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8A0F70", Offset = "0x8A0370", VA = "0x1808A0F70")]
	private void FJLIAPIOJJP(THandle DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44FDF50", Offset = "0x44FD350", VA = "0x1844FDF50")]
	private bool PLAHLMMFPPP([Out] THandle DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x44FD280", Offset = "0x44FC680", VA = "0x1844FD280")]
	private bool CHNLDPFMGHJ([Out] THandle DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x44FD4E0", Offset = "0x44FC8E0", VA = "0x1844FD4E0")]
	private void FIOKMGKFPAO(THandle DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x44FD8C0", Offset = "0x44FCCC0", VA = "0x1844FD8C0")]
	private void HGAHPFAMDDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FLCBANDPIBK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int DIJEOHGLGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LJMJPEBFKDI
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
public static class IAOPPIMMNDM
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EDE370", Offset = "0x2EDD770", VA = "0x182EDE370")]
	public static bool KMNCNEPCCOL<T>(this T DOBBMOLDHPN, T OGKFFDCECEL) where T : struct, FLCBANDPIBK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EDE360", Offset = "0x2EDD760", VA = "0x182EDE360")]
	public static bool KIGAEJLFEFK<T>(this T DOBBMOLDHPN) where T : struct, FLCBANDPIBK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D52290", Offset = "0x6D51690", VA = "0x186D52290")]
	public static string ENCGINADNOH(this FLCBANDPIBK DOBBMOLDHPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct JKPIALGNEGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type POEHEDNCMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> ONGMHHNMMBI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x45BDA50", Offset = "0x45BCE50", VA = "0x1845BDA50")]
	public JKPIALGNEGL(Type DPFKOCBIENI, Span<byte> LFKJJKCOKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D300", Offset = "0x2F3C700", VA = "0x182F3D300")]
	public static JKPIALGNEGL ADLLDKLMDCF<T>(T PFKKDHPJFEH) where T : struct
	{
		return default(JKPIALGNEGL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D525C0", Offset = "0x6D519C0", VA = "0x186D525C0")]
	public static EGAEOODFFBN NMFIIIJGOAJ([In] JKPIALGNEGL AKMABNIDADH)
	{
		return default(EGAEOODFFBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2FA90", Offset = "0x2D2EE90", VA = "0x182D2FA90")]
	public T GEKLBPFDDHO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D52530", Offset = "0x6D51930", VA = "0x186D52530")]
	public Enum LBPKKKLKAAL(Type CGMPPMEOEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F3E4E0", Offset = "0x2F3D8E0", VA = "0x182F3E4E0")]
	public void NBJJIKECOBK<T>([In] T PFKKDHPJFEH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D525B0", Offset = "0x6D519B0", VA = "0x186D525B0")]
	public void NIMBIOGLKKA(Enum LFKMIMEIEKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct EGAEOODFFBN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct NNOHANEFBEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* LJOCABNFJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* AIHDGCOJNGE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type POEHEDNCMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> ONGMHHNMMBI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int INPFMBGIDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D520E0", Offset = "0x6D514E0", VA = "0x186D520E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x45BDA50", Offset = "0x45BCE50", VA = "0x1845BDA50")]
	public EGAEOODFFBN(Type DPFKOCBIENI, ReadOnlySpan<byte> LFKJJKCOKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CE80", Offset = "0x2D2C280", VA = "0x182D2CE80")]
	public static EGAEOODFFBN ADLLDKLMDCF<T>(T PFKKDHPJFEH) where T : struct
	{
		return default(EGAEOODFFBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CFC0", Offset = "0x2D2C3C0", VA = "0x182D2CFC0")]
	public static EGAEOODFFBN ADLLDKLMDCF<T>(NativeArray<T> PFKKDHPJFEH) where T : struct
	{
		return default(EGAEOODFFBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D51FB0", Offset = "0x6D513B0", VA = "0x186D51FB0")]
	public void FDHCGLEDBPO(Span<byte> CCGEFIKPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D52010", Offset = "0x6D51410", VA = "0x186D52010")]
	public void FDHCGLEDBPO(NativeArray<byte> CCGEFIKPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D2FB20", Offset = "0x2D2EF20", VA = "0x182D2FB20")]
	public T GEKLBPFDDHO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D2FA40", Offset = "0x2D2EE40", VA = "0x182D2FA40")]
	public NativeArray<T> BEMECHFHJHG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D52250", Offset = "0x6D51650", VA = "0x186D52250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D52120", Offset = "0x6D51520", VA = "0x186D52120")]
	private object JMAGLCJDBPP()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KAKEMKBKMDG
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F62E00", Offset = "0x2F62200", VA = "0x182F62E00")]
	public static NativeArray<T> KAJNHNPEODM<T>(T PFKKDHPJFEH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2F62E50", Offset = "0x2F62250", VA = "0x182F62E50")]
	public static NativeArray<T> NAPEAOCPAPO<T>(T PFKKDHPJFEH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2F62DB0", Offset = "0x2F621B0", VA = "0x182F62DB0")]
	public static NativeArray<T> ADLLDKLMDCF<T>(T PFKKDHPJFEH, bool NJJAAHMCKCP) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DBGHLHACKDI<Handle> where Handle : FLCBANDPIBK, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct PGJNKJLOGME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly DBGHLHACKDI<Handle> MMFPHFFLLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int OBFJPFHENMC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle PCKHPCLOHGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4B2EC50", Offset = "0x4B2E050", VA = "0x184B2EC50")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4B2EF30", Offset = "0x4B2E330", VA = "0x184B2EF30")]
		public PGJNKJLOGME(DBGHLHACKDI<Handle> MMFPHFFLLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4B2E6F0", Offset = "0x4B2DAF0", VA = "0x184B2E6F0")]
		public IEJIODLIGIG GIIIFAJNKEL([In] IEJIODLIGIG KGHCPOJBNFM)
		{
			return default(IEJIODLIGIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4B2E9C0", Offset = "0x4B2DDC0", VA = "0x184B2E9C0")]
		public bool KPJEAMDBMKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4B2E5D0", Offset = "0x4B2D9D0", VA = "0x184B2E5D0")]
		private Handle COEOKNCOAGO(string NFKMLKNHFEM)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct IEJIODLIGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private PGJNKJLOGME FCHAIPDIMCH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4208E90", Offset = "0x4208290", VA = "0x184208E90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4209000", Offset = "0x4208400", VA = "0x184209000")]
		public IEJIODLIGIG(DBGHLHACKDI<Handle> MMFPHFFLLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4208F80", Offset = "0x4208380", VA = "0x184208F80")]
		public bool KPJEAMDBMKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4208ED0", Offset = "0x42082D0", VA = "0x184208ED0")]
		public IEJIODLIGIG EDIPCEILGGF()
		{
			return default(IEJIODLIGIG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> HFDMJHGHOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> IPBDEHHNNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int FDEJMPOIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int MJFGKAEKJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool PPAACBAIKDH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BAJAMKMOMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0E60", Offset = "0x5BE0260", VA = "0x185BE0E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IEJIODLIGIG KEBGBDOCNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0EA0", Offset = "0x5BE02A0", VA = "0x185BE0EA0")]
		get
		{
			return default(IEJIODLIGIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1A40", Offset = "0x5BE0E40", VA = "0x185BE1A40")]
	public DBGHLHACKDI(int FFMIFKEEDNO, Allocator DBCOPEDFGJL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5BE17D0", Offset = "0x5BE0BD0", VA = "0x185BE17D0")]
	public void PBEAHLLBJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1BDF710", Offset = "0x1BDEB10", VA = "0x181BDF710")]
	public static int OBDODJEAGGJ(int FCBPGONDPJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2854300", Offset = "0x2853700", VA = "0x182854300")]
	public static bool BAFAIILLKCG(int FCBPGONDPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1060", Offset = "0x5BE0460", VA = "0x185BE1060")]
	public bool NOKGDDKCOCP(int OBFJPFHENMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5BDF2F0", Offset = "0x5BDE6F0", VA = "0x185BDF2F0")]
	public bool AEOMEOCLHMK(Handle DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0610", Offset = "0x5BDFA10", VA = "0x185BE0610")]
	public Handle IMKHBEJNNGD()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0040", Offset = "0x5BDF440", VA = "0x185BE0040")]
	public void IFNPOHCKLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0D00", Offset = "0x5BE0100", VA = "0x185BE0D00")]
	public void MEEMDBAELKE(Handle DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5BDF8A0", Offset = "0x5BDECA0", VA = "0x185BDF8A0")]
	public bool GPLIOBHGMLE(Handle DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x983FC0", Offset = "0x9833C0", VA = "0x180983FC0")]
	private bool HAFIMCJCAEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0410", Offset = "0x5BDF810", VA = "0x185BE0410")]
	private bool IMHFDBADLKN(int OBFJPFHENMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5BE15A0", Offset = "0x5BE09A0", VA = "0x185BE15A0")]
	private void OIFOFHJJBKN([Out] int OBFJPFHENMC, [Out] int FCPMNBOKKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5BE09F0", Offset = "0x5BDFDF0", VA = "0x185BE09F0")]
	private void JKAKDIIBBGD(Handle DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5BE19A0", Offset = "0x5BE0DA0", VA = "0x185BE19A0")]
	private void PCGCCHFADJP(int OBFJPFHENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5BDF690", Offset = "0x5BDEA90", VA = "0x185BDF690")]
	private bool CIBIFMNNBCP([Out] int OBFJPFHENMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5BE06E0", Offset = "0x5BDFAE0", VA = "0x185BE06E0")]
	private static Handle JABKHGPDFMG(int OBFJPFHENMC, int FCPMNBOKKMJ)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct JEMEPMKCLAO<Handle, T> where Handle : FLCBANDPIBK, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private DBGHLHACKDI<Handle> EAMOGKMJJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] GMMDFLGDEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> IJAMMGLKIOH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x43DD430", Offset = "0x43DC830", VA = "0x1843DD430")]
	public JEMEPMKCLAO(int FFMIFKEEDNO, [Optional] Action<T> IJAMMGLKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x43DD1C0", Offset = "0x43DC5C0", VA = "0x1843DD1C0")]
	public void PBEAHLLBJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x43DC380", Offset = "0x43DB780", VA = "0x1843DC380")]
	public bool IELONOIKEDC(Handle DOBBMOLDHPN, [Out] T FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x43DC0C0", Offset = "0x43DB4C0", VA = "0x1843DC0C0")]
	public Handle FNBCENOGBNB(T FAKGLFFOLFI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x43DCF90", Offset = "0x43DC390", VA = "0x1843DCF90")]
	public void KIBKMJAKCBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x43DBBD0", Offset = "0x43DAFD0", VA = "0x1843DBBD0")]
	public void BIJNEFLCHFA(Handle DOBBMOLDHPN, [Out] T OLHPKMIHGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x43DBB00", Offset = "0x43DAF00", VA = "0x1843DBB00")]
	public void BIJNEFLCHFA(Handle DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x43DC870", Offset = "0x43DBC70", VA = "0x1843DC870")]
	public bool JHIBOIAAIHD(Handle DOBBMOLDHPN, [Out] T OLHPKMIHGAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x43DC960", Offset = "0x43DBD60", VA = "0x1843DC960")]
	public bool JHIBOIAAIHD(Handle DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x43DBF40", Offset = "0x43DB340", VA = "0x1843DBF40")]
	private T FIDCICKLFAC(int OBFJPFHENMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x43DC2C0", Offset = "0x43DB6C0", VA = "0x1843DC2C0")]
	private void GLLAGAGCNKM(int KJCCLHPMCNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct PNPEHBPOCJM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] EIFGKHNPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int LGPCCHEOHGO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2273940", Offset = "0x2272D40", VA = "0x182273940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D4EC10", Offset = "0x2D4E010", VA = "0x182D4EC10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> ONGMHHNMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4B4B890", Offset = "0x4B4AC90", VA = "0x184B4B890")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DINKENCDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x11CA180", Offset = "0x11C9580", VA = "0x1811CA180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B4B930", Offset = "0x4B4AD30", VA = "0x184B4B930")]
	public PNPEHBPOCJM(int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4B4B7E0", Offset = "0x4B4ABE0", VA = "0x184B4B7E0")]
	public int GEKFBAGACOL(T PFKKDHPJFEH, int ICLFANODKJK, int GMOPHNCDIJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B4B620", Offset = "0x4B4AA20", VA = "0x184B4B620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct IBCMFGIIKMI<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct GJHIGJPHAMI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IBCMFGIIKMI<T> PBBPHMMFLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int OBFJPFHENMC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x40541F0", Offset = "0x40535F0", VA = "0x1840541F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4054290", Offset = "0x4053690", VA = "0x184054290", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4054260", Offset = "0x4053660", VA = "0x184054260")]
		public GJHIGJPHAMI(IBCMFGIIKMI<T> PBBPHMMFLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4054160", Offset = "0x4053560", VA = "0x184054160", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x40541A0", Offset = "0x40535A0", VA = "0x1840541A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private PNPEHBPOCJM<T> EIFGKHNPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int LGPCCHEOHGO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x41FE970", Offset = "0x41FDD70", VA = "0x1841FE970")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x41FE340", Offset = "0x41FD740", VA = "0x1841FE340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BAJAMKMOMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x41FE940", Offset = "0x41FDD40", VA = "0x1841FE940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DINKENCDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x41FE300", Offset = "0x41FD700", VA = "0x1841FE300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> ONGMHHNMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x41FEC30", Offset = "0x41FE030", VA = "0x1841FEC30")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x41FEDA0", Offset = "0x41FE1A0", VA = "0x1841FEDA0")]
	public IBCMFGIIKMI(int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x41FE380", Offset = "0x41FD780", VA = "0x1841FE380")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x41FE3E0", Offset = "0x41FD7E0", VA = "0x1841FE3E0")]
	public void FNBCENOGBNB(T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x41FE630", Offset = "0x41FDA30", VA = "0x1841FE630")]
	internal void IANPLMLPPEL(int PCJIPONCEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x41FE860", Offset = "0x41FDC60", VA = "0x1841FE860")]
	public void LKOJIMEHPFD(int OBFJPFHENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x41FEA00", Offset = "0x41FDE00", VA = "0x1841FEA00")]
	public void OMKBCHPCKKA(int JBMCJFOPDGH, int CCKNHLLGPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x41FE4E0", Offset = "0x41FD8E0", VA = "0x1841FE4E0")]
	public int GEKFBAGACOL(T PFKKDHPJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x41FE2C0", Offset = "0x41FD6C0", VA = "0x1841FE2C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x41FE560", Offset = "0x41FD960", VA = "0x1841FE560", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x41FECF0", Offset = "0x41FE0F0", VA = "0x1841FECF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x41FED30", Offset = "0x41FE130", VA = "0x1841FED30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x41FDF60", Offset = "0x41FD360", VA = "0x1841FDF60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void AGGCEMPLKKG(int PFKKDHPJFEH, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x41FE0B0", Offset = "0x41FD4B0", VA = "0x1841FE0B0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void BEJDCJEAIHL(int JBMCJFOPDGH, int CCKNHLLGPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OJHMBNDHAOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HHOJFKLGPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int GMOPHNCDIJO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int GPBKFOICKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x283D840", Offset = "0x283CC40", VA = "0x18283D840")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60E85D0", Offset = "0x60E79D0", VA = "0x1860E85D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int GBFPNHJPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC8A120", Offset = "0xC89520", VA = "0x180C8A120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int KOJLHCDBCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6D52850", Offset = "0x6D51C50", VA = "0x186D52850")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D52840", Offset = "0x6D51C40", VA = "0x186D52840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA89130", Offset = "0xA88530", VA = "0x180A89130")]
	private OJHMBNDHAOH(int HHOJFKLGPBP, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x227FCE0", Offset = "0x227F0E0", VA = "0x18227FCE0")]
	public static OJHMBNDHAOH LENENDHBDOD(int HHOJFKLGPBP, int GMOPHNCDIJO)
	{
		return default(OJHMBNDHAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D52830", Offset = "0x6D51C30", VA = "0x186D52830")]
	public static OJHMBNDHAOH FEBGONHKIFK(int ICLFANODKJK, int CCKNHLLGPCO)
	{
		return default(OJHMBNDHAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D52860", Offset = "0x6D51C60", VA = "0x186D52860", Slot = "3")]
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
