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
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68EACC0", Offset = "0x68E9EC0", VA = "0x1868EACC0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class APNDBANBKFE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68E98C0", Offset = "0x68E8AC0", VA = "0x1868E98C0")]
	public static void OGMOBPNHCEI(this GameObject NBDLDMDNCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68E9960", Offset = "0x68E8B60", VA = "0x1868E9960")]
	public static void OGMOBPNHCEI(this Component INPAFGCEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68E9A00", Offset = "0x68E8C00", VA = "0x1868E9A00")]
	public static void OGMOBPNHCEI(this ScriptableObject JHBGADOOAAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MBKBIFPEGOI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68EAE00", Offset = "0x68EA000", VA = "0x1868EAE00")]
	public static Span<byte> KFKILADLDJC(this NativeArray<byte> PFKJAOOHGBN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68EAD50", Offset = "0x68E9F50", VA = "0x1868EAD50")]
	public static ReadOnlySpan<byte> IGCPKIKCNFG(this NativeArray<byte> PFKJAOOHGBN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BF70", Offset = "0x2C2B170", VA = "0x182C2BF70")]
	public static NativeArray<T> AJPIDPMCHJH<T>(this NativeArray<T> PFKJAOOHGBN, DCAAIJCHCEO NHEIBBJGGFH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BFB0", Offset = "0x2C2B1B0", VA = "0x182C2BFB0")]
	public static NativeArray<T> AJPIDPMCHJH<T>(this NativeArray<T> PFKJAOOHGBN, int GBALKPFEDAI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMBOJKJGDKO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F2C0", Offset = "0x2B3E4C0", VA = "0x182B3F2C0")]
	public static string FMCMNJELJPM<T>(this NativeArray<T> PFKJAOOHGBN, string PCOEHEFFIFO = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CFOPDFPPFCB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2944200", Offset = "0x2943400", VA = "0x182944200")]
	public static T JMJOGDIBBHK<T>([In] this ReadOnlySpan<byte> JNJLMODIELO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2943A80", Offset = "0x2942C80", VA = "0x182943A80")]
	public static NativeArray<T> GOELFKMMAGI<T>(this ReadOnlySpan<byte> JNJLMODIELO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2943EB0", Offset = "0x29430B0", VA = "0x182943EB0")]
	public static ReadOnlySpan<TTo> HMGPGCAKDEO<TTo, TFrom>(this ReadOnlySpan<TFrom> JNJLMODIELO) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2945300", Offset = "0x2944500", VA = "0x182945300")]
	public static Span<byte> OLOHHMDPKEO<T>([In] this Span<byte> JNJLMODIELO, T JMDCGOKJIDA) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68E9FB0", Offset = "0x68E91B0", VA = "0x1868E9FB0")]
	private static Enum ECAKFIHJNEO([In] ReadOnlySpan<byte> JNJLMODIELO, Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68EA560", Offset = "0x68E9760", VA = "0x1868EA560")]
	public static Enum FDGEPDCLICC([In] this Span<byte> JNJLMODIELO, Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68E9AA0", Offset = "0x68E8CA0", VA = "0x1868E9AA0")]
	public static void BNLMEDAEBJF([In] this Span<byte> JNJLMODIELO, Enum NKEPPGPEFAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HOJHCNNECAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OCBOMFAMFDA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x68EAEB0", Offset = "0x68EA0B0", VA = "0x1868EAEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9EC1C0", Offset = "0x9EB3C0", VA = "0x1809EC1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68EA810", Offset = "0x68E9A10", VA = "0x1868EA810")]
	[AsyncStateMachine(typeof(OCBOMFAMFDA))]
	public static void MGBMNGIKHIE(this Task DOGPFNGIKMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HDKIAOOHAOI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum IILMIMNGKPF : short
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
	public struct PDNFAOJNEKC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly IILMIMNGKPF NDDCLPHCEEO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2554280", Offset = "0x2553480", VA = "0x182554280")]
		public PDNFAOJNEKC(IILMIMNGKPF NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory GGKCNFLLBEE;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	public static void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68EA690", Offset = "0x68E9890", VA = "0x1868EA690")]
	static HDKIAOOHAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x284B2E0", Offset = "0x284A4E0", VA = "0x18284B2E0")]
	public static PDNFAOJNEKC DPBMKNHEDMC(IILMIMNGKPF NDDCLPHCEEO)
	{
		return default(PDNFAOJNEKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	public static void FEHFNNHHLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class DHCBBOLKALJ<THandle, TValue> : IDisposable where THandle : struct, DIAIPOOLIIL where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> GHJAKKOFDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> MNHECFLLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> IMDOAAPGAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> DPFCEFBKJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int DDHHBMPMGIA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5766BD0", Offset = "0x5765DD0", VA = "0x185766BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5766C70", Offset = "0x5765E70", VA = "0x185766C70")]
	public DHCBBOLKALJ(Action<TValue> DPFCEFBKJAL, [Optional] Func<TValue> IMDOAAPGAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5766060", Offset = "0x5765260", VA = "0x185766060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5766B30", Offset = "0x5765D30", VA = "0x185766B30")]
	public THandle PBLNBBGFGAP(TValue JMDCGOKJIDA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5765F40", Offset = "0x5765140", VA = "0x185765F40")]
	public bool CKOHIKCJKJA(THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5766340", Offset = "0x5765540", VA = "0x185766340")]
	public bool FFKNBABIJFJ(THandle IIMJMBJHGDI, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5766620", Offset = "0x5765820", VA = "0x185766620")]
	public TValue JMJOGDIBBHK(THandle IIMJMBJHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5766870", Offset = "0x5765A70", VA = "0x185766870")]
	public bool LNFEOGNEOOI(THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5766810", Offset = "0x5765A10", VA = "0x185766810")]
	private THandle LJMGJBMEHNC(int DHNLEFJCEAH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5766C10", Offset = "0x5765E10", VA = "0x185766C10")]
	private TValue POIMHEEJLCG(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5766240", Offset = "0x5765440", VA = "0x185766240")]
	private void FEFADGGNLEI(int DHNLEFJCEAH, [In] THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5766400", Offset = "0x5765600", VA = "0x185766400")]
	private void HEOMLDPCKGB(int DHNLEFJCEAH, [In] TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5766980", Offset = "0x5765B80", VA = "0x185766980")]
	private THandle NEFCHJDBGAD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5766130", Offset = "0x5765330", VA = "0x185766130")]
	private void EDHEDILPGLJ(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5766050", Offset = "0x5765250", VA = "0x185766050")]
	private int DGACABAFAGG(int DMDAEILPBHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5766B20", Offset = "0x5765D20", VA = "0x185766B20")]
	private bool NNMBELKEAAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8581B0", VA = "0x180858FB0")]
	private void LKHDBNPNDNP(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5766290", Offset = "0x5765490", VA = "0x185766290")]
	private bool FFINEKPMFJP([Out] THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5766450", Offset = "0x5765650", VA = "0x185766450")]
	private bool HILLLHPLOHH([Out] THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5766570", Offset = "0x5765770", VA = "0x185766570")]
	private void JJGPLACDCHI(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5766670", Offset = "0x5765870", VA = "0x185766670")]
	private void KGIABCIBOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DIAIPOOLIIL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int GIOOEBIGKMB
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
public static class HLDHDBOMOII
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D2B0", Offset = "0x2B7C4B0", VA = "0x182B7D2B0")]
	public static bool PHINDPEAKKH<T>(this T IIMJMBJHGDI, T OKGBBGMIACH) where T : struct, DIAIPOOLIIL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D2A0", Offset = "0x2B7C4A0", VA = "0x182B7D2A0")]
	public static bool OONANGMADII<T>(this T IIMJMBJHGDI) where T : struct, DIAIPOOLIIL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9900", VA = "0x1868EA700")]
	public static string KABLEKCEFJN(this DIAIPOOLIIL IIMJMBJHGDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct JBCMKOAFGAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type LNODPCGLJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> KFOCBDPELCO;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4235A80", Offset = "0x4234C80", VA = "0x184235A80")]
	public JBCMKOAFGAE(Type FPPJJFGLDKN, Span<byte> JNJLMODIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB3B0", Offset = "0x2BCA5B0", VA = "0x182BCB3B0")]
	public static JBCMKOAFGAE AIJAFPFEFCM<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(JBCMKOAFGAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68EA9C0", Offset = "0x68E9BC0", VA = "0x1868EA9C0")]
	public static JHKEOJJDFBK GCLAHEGAFFN([In] JBCMKOAFGAE DLFEHJOHIIJ)
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68EA940", Offset = "0x68E9B40", VA = "0x1868EA940")]
	public Enum FDGEPDCLICC(Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC570", Offset = "0x2BCB770", VA = "0x182BCC570")]
	public void OLOHHMDPKEO<T>([In] T JMDCGOKJIDA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68EA930", Offset = "0x68E9B30", VA = "0x1868EA930")]
	public void BNLMEDAEBJF(Enum NKEPPGPEFAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct JHKEOJJDFBK
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct MAEIBFLBHNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* GHAJLLCDMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* MPCHEKFOICN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type LNODPCGLJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> KFOCBDPELCO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LIFKLMGEOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68EAB70", Offset = "0x68E9D70", VA = "0x1868EAB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4235A80", Offset = "0x4234C80", VA = "0x184235A80")]
	public JHKEOJJDFBK(Type FPPJJFGLDKN, ReadOnlySpan<byte> JNJLMODIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA7D0", Offset = "0x2BD99D0", VA = "0x182BDA7D0")]
	public static JHKEOJJDFBK AIJAFPFEFCM<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA900", Offset = "0x2BD9B00", VA = "0x182BDA900")]
	public static JHKEOJJDFBK AIJAFPFEFCM<T>(NativeArray<T> JMDCGOKJIDA) where T : struct
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68EABB0", Offset = "0x68E9DB0", VA = "0x1868EABB0")]
	public void PGKLAMLJNDJ(NativeArray<byte> CGCFPGMCFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD300", Offset = "0x2BDC500", VA = "0x182BDD300")]
	public T JMJOGDIBBHK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD280", Offset = "0x2BDC480", VA = "0x182BDD280")]
	public NativeArray<T> GOELFKMMAGI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68EAC80", Offset = "0x68E9E80", VA = "0x1868EAC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68EAA40", Offset = "0x68E9C40", VA = "0x1868EAA40")]
	private object BNOPFOOKAFL()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HNOHIECHPJL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EF00", Offset = "0x2B7E100", VA = "0x182B7EF00")]
	public static NativeArray<T> BOOPHANMLJP<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EEB0", Offset = "0x2B7E0B0", VA = "0x182B7EEB0")]
	public static NativeArray<T> AIJAFPFEFCM<T>(T JMDCGOKJIDA, bool HKNKBAEFAJL) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JMEKFLDIIFL<Handle> where Handle : DIAIPOOLIIL, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct PBHGPPPHMLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly JMEKFLDIIFL<Handle> JOPKJIBCCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int DHNLEFJCEAH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle EJEKCGLDLHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4767380", Offset = "0x4766580", VA = "0x184767380")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4767970", Offset = "0x4766B70", VA = "0x184767970")]
		public PBHGPPPHMLD(JMEKFLDIIFL<Handle> JOPKJIBCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4767010", Offset = "0x4766210", VA = "0x184767010")]
		public BNPLEPGLEPL FJAAFKPDAIA([In] BNPLEPGLEPL LMDEKGEENAI)
		{
			return default(BNPLEPGLEPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4767730", Offset = "0x4766930", VA = "0x184767730")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x47674F0", Offset = "0x47666F0", VA = "0x1847674F0")]
		private Handle NHCOPGEEKGF(string JNNDBFGKHHD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct BNPLEPGLEPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private PBHGPPPHMLD EDLIPAEADJL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A0F0", Offset = "0x4E892F0", VA = "0x184E8A0F0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E8A230", Offset = "0x4E89430", VA = "0x184E8A230")]
		public BNPLEPGLEPL(JMEKFLDIIFL<Handle> JOPKJIBCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E8A170", Offset = "0x4E89370", VA = "0x184E8A170")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E8A040", Offset = "0x4E89240", VA = "0x184E8A040")]
		public BNPLEPGLEPL DCPEOMEKOMK()
		{
			return default(BNPLEPGLEPL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> BLMPMIIJGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> EHBPMCCOOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int FEMOOHOEBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int ONPGAHLMPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool FHAAAJJKBPH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x40BEB40", Offset = "0x40BDD40", VA = "0x1840BEB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BNPLEPGLEPL OMADHNHPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x40BEF20", Offset = "0x40BE120", VA = "0x1840BEF20")]
		get
		{
			return default(BNPLEPGLEPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40BF080", Offset = "0x40BE280", VA = "0x1840BF080")]
	public JMEKFLDIIFL(int AHECCPJHEFF, Allocator CHDJMCMMMLJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40BCC30", Offset = "0x40BBE30", VA = "0x1840BCC30")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x18D3F90", Offset = "0x18D3190", VA = "0x1818D3F90")]
	public static int DGACABAFAGG(int NJJHKDBJDAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2585120", Offset = "0x2584320", VA = "0x182585120")]
	public static bool NMNDAGHCFGE(int NJJHKDBJDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x40BE040", Offset = "0x40BD240", VA = "0x1840BE040")]
	public bool IBJKGKLKMJK(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40BE590", Offset = "0x40BD790", VA = "0x1840BE590")]
	public bool ICPKLNCPNLN(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40BCA90", Offset = "0x40BBC90", VA = "0x1840BCA90")]
	public Handle CLAEJJKKLOO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40BD5C0", Offset = "0x40BC7C0", VA = "0x1840BD5C0")]
	public void IAJGPHKHNEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40BEEB0", Offset = "0x40BE0B0", VA = "0x1840BEEB0")]
	public void NNCHCODGEEH(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40BD2C0", Offset = "0x40BC4C0", VA = "0x1840BD2C0")]
	public bool EJCKHLBDCKI(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA6E540", Offset = "0xA6D740", VA = "0x180A6E540")]
	private bool MDHLFFKGHKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40BC960", Offset = "0x40BBB60", VA = "0x1840BC960")]
	private bool BPHBPCFPMNM(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x40BD150", Offset = "0x40BC350", VA = "0x1840BD150")]
	private void EINIANEDEHK([Out] int DHNLEFJCEAH, [Out] int DMDAEILPBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40BE9B0", Offset = "0x40BDBB0", VA = "0x1840BE9B0")]
	private void IPCHIDJGPMF(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40BD520", Offset = "0x40BC720", VA = "0x1840BD520")]
	private void FJIDHAJIPHA(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40BEC70", Offset = "0x40BDE70", VA = "0x1840BEC70")]
	private bool KEENPFAKGFD([Out] int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40BC6F0", Offset = "0x40BB8F0", VA = "0x1840BC6F0")]
	private static Handle ANPEOEDFGBH(int DHNLEFJCEAH, int DMDAEILPBHA)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct NLJNNOLMIDI<Handle, T> where Handle : DIAIPOOLIIL, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JMEKFLDIIFL<Handle> IAENOMBKGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] LPEADONKEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> DKBFFBLIJNO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4540DE0", Offset = "0x453FFE0", VA = "0x184540DE0")]
	public NLJNNOLMIDI(int AHECCPJHEFF, [Optional] Action<T> DKBFFBLIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x453FB20", Offset = "0x453ED20", VA = "0x18453FB20")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x453FCF0", Offset = "0x453EEF0", VA = "0x18453FCF0")]
	public bool FFKNBABIJFJ(Handle IIMJMBJHGDI, [Out] T MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4540BC0", Offset = "0x453FDC0", VA = "0x184540BC0")]
	public Handle PBLNBBGFGAP(T MEAFIMADMKA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4540660", Offset = "0x453F860", VA = "0x184540660")]
	public void NIGFFIBODJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4540350", Offset = "0x453F550", VA = "0x184540350")]
	public void MFKDEBIIBOM(Handle IIMJMBJHGDI, [Out] T OHPMNAJMMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4540280", Offset = "0x453F480", VA = "0x184540280")]
	public void MFKDEBIIBOM(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x453F7E0", Offset = "0x453E9E0", VA = "0x18453F7E0")]
	public bool CKCCKFKKMLA(Handle IIMJMBJHGDI, [Out] T OHPMNAJMMGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x453F600", Offset = "0x453E800", VA = "0x18453F600")]
	public bool CKCCKFKKMLA(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x453F4C0", Offset = "0x453E6C0", VA = "0x18453F4C0")]
	private T ACAJIKLBJOM(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x453FE50", Offset = "0x453F050", VA = "0x18453FE50")]
	private void LAMHFMADGIK(int APFHBGBBKEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct FHBDICCJKKK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int OMJPDIKPOLO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FF92F0", Offset = "0x1FF84F0", VA = "0x181FF92F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A340", Offset = "0x2B99540", VA = "0x182B9A340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> KFOCBDPELCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3BEDDE0", Offset = "0x3BECFE0", VA = "0x183BEDDE0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE67E90", Offset = "0xE67090", VA = "0x180E67E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDFF0", Offset = "0x3BED1F0", VA = "0x183BEDFF0")]
	public FHBDICCJKKK(int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDE80", Offset = "0x3BED080", VA = "0x183BEDE80")]
	public int IMLBDBIFEKB(T JMDCGOKJIDA, int GBALKPFEDAI, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDCE0", Offset = "0x3BECEE0", VA = "0x183BEDCE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct FCCFNDGAOHI<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct JMAJGMAAMCO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FCCFNDGAOHI<T> CGIFJALMJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int DHNLEFJCEAH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x40BA9D0", Offset = "0x40B9BD0", VA = "0x1840BA9D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x40BAA70", Offset = "0x40B9C70", VA = "0x1840BAA70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x40BAA40", Offset = "0x40B9C40", VA = "0x1840BAA40")]
		public JMAJGMAAMCO(FCCFNDGAOHI<T> CGIFJALMJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x40BA940", Offset = "0x40B9B40", VA = "0x1840BA940", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40BA980", Offset = "0x40B9B80", VA = "0x1840BA980", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private FHBDICCJKKK<T> LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int OMJPDIKPOLO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3B82910", Offset = "0x3B81B10", VA = "0x183B82910")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8513A0", VA = "0x1808521A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3B81E40", Offset = "0x3B81040", VA = "0x183B81E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3B824F0", Offset = "0x3B816F0", VA = "0x183B824F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3B820F0", Offset = "0x3B812F0", VA = "0x183B820F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> KFOCBDPELCO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B82280", Offset = "0x3B81480", VA = "0x183B82280")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3B82A50", Offset = "0x3B81C50", VA = "0x183B82A50")]
	public FCCFNDGAOHI(int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B82410", Offset = "0x3B81610", VA = "0x183B82410")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B82810", Offset = "0x3B81A10", VA = "0x183B82810")]
	public void PBLNBBGFGAP(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B81EC0", Offset = "0x3B810C0", VA = "0x183B81EC0")]
	internal void EMFKJPPIBCE(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B82730", Offset = "0x3B81930", VA = "0x183B82730")]
	public void MNACKLLGDEF(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B81C10", Offset = "0x3B80E10", VA = "0x183B81C10")]
	public void AHODFEAKAPC(int ONAHHCLNBMK, int DAOCGKJPECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B82470", Offset = "0x3B81670", VA = "0x183B82470")]
	public int IMLBDBIFEKB(T JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B81E80", Offset = "0x3B81080", VA = "0x183B81E80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B82340", Offset = "0x3B81540", VA = "0x183B82340", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B829A0", Offset = "0x3B81BA0", VA = "0x183B829A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B829E0", Offset = "0x3B81BE0", VA = "0x183B829E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B82130", Offset = "0x3B81330", VA = "0x183B82130")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void GCDGFGOFCNL(int JMDCGOKJIDA, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B82520", Offset = "0x3B81720", VA = "0x183B82520")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void LHINDJBFDBK(int ONAHHCLNBMK, int DAOCGKJPECC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DCAAIJCHCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int PENDBLHFGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IHGHLPOONHD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int FGGMJJKKBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x256A860", Offset = "0x2569A60", VA = "0x18256A860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1B20", Offset = "0x5CC0D20", VA = "0x185CC1B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LAKBBFJHJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JDLJCBHINAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x68EA5E0", Offset = "0x68E97E0", VA = "0x1868EA5E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x68EA5D0", Offset = "0x68E97D0", VA = "0x1868EA5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
	private DCAAIJCHCEO(int PENDBLHFGOI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5430", Offset = "0x1FD4630", VA = "0x181FD5430")]
	public static DCAAIJCHCEO HFMDNJKDJMF(int PENDBLHFGOI, int IHGHLPOONHD)
	{
		return default(DCAAIJCHCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x68EA5F0", Offset = "0x68E97F0", VA = "0x1868EA5F0")]
	public static DCAAIJCHCEO KODHNMIOGBA(int GBALKPFEDAI, int DAOCGKJPECC)
	{
		return default(DCAAIJCHCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68EA600", Offset = "0x68E9800", VA = "0x1868EA600", Slot = "3")]
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
