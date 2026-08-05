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
		[Cpp2IlInjected.Address(RVA = "0x68D08D0", Offset = "0x68CF0D0", VA = "0x1868D08D0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class APNDBANBKFE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68CF4D0", Offset = "0x68CDCD0", VA = "0x1868CF4D0")]
	public static void OGMOBPNHCEI(this GameObject NBDLDMDNCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68CF570", Offset = "0x68CDD70", VA = "0x1868CF570")]
	public static void OGMOBPNHCEI(this Component INPAFGCEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68CF610", Offset = "0x68CDE10", VA = "0x1868CF610")]
	public static void OGMOBPNHCEI(this ScriptableObject JHBGADOOAAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MBKBIFPEGOI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68D0A10", Offset = "0x68CF210", VA = "0x1868D0A10")]
	public static Span<byte> KFKILADLDJC(this NativeArray<byte> PFKJAOOHGBN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68D0960", Offset = "0x68CF160", VA = "0x1868D0960")]
	public static ReadOnlySpan<byte> IGCPKIKCNFG(this NativeArray<byte> PFKJAOOHGBN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D460", Offset = "0x2C1BC60", VA = "0x182C1D460")]
	public static NativeArray<T> AJPIDPMCHJH<T>(this NativeArray<T> PFKJAOOHGBN, DCAAIJCHCEO NHEIBBJGGFH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D4A0", Offset = "0x2C1BCA0", VA = "0x182C1D4A0")]
	public static NativeArray<T> AJPIDPMCHJH<T>(this NativeArray<T> PFKJAOOHGBN, int GBALKPFEDAI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMBOJKJGDKO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B30DD0", Offset = "0x2B2F5D0", VA = "0x182B30DD0")]
	public static string FMCMNJELJPM<T>(this NativeArray<T> PFKJAOOHGBN, string PCOEHEFFIFO = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CFOPDFPPFCB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2935ED0", Offset = "0x29346D0", VA = "0x182935ED0")]
	public static T JMJOGDIBBHK<T>([In] this ReadOnlySpan<byte> JNJLMODIELO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2935750", Offset = "0x2933F50", VA = "0x182935750")]
	public static NativeArray<T> GOELFKMMAGI<T>(this ReadOnlySpan<byte> JNJLMODIELO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2935B80", Offset = "0x2934380", VA = "0x182935B80")]
	public static ReadOnlySpan<TTo> HMGPGCAKDEO<TTo, TFrom>(this ReadOnlySpan<TFrom> JNJLMODIELO) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2936FD0", Offset = "0x29357D0", VA = "0x182936FD0")]
	public static Span<byte> OLOHHMDPKEO<T>([In] this Span<byte> JNJLMODIELO, T JMDCGOKJIDA) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68CFBC0", Offset = "0x68CE3C0", VA = "0x1868CFBC0")]
	private static Enum ECAKFIHJNEO([In] ReadOnlySpan<byte> JNJLMODIELO, Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68D0170", Offset = "0x68CE970", VA = "0x1868D0170")]
	public static Enum FDGEPDCLICC([In] this Span<byte> JNJLMODIELO, Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68CF6B0", Offset = "0x68CDEB0", VA = "0x1868CF6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D0AC0", Offset = "0x68CF2C0", VA = "0x1868D0AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9EB410", Offset = "0x9E9C10", VA = "0x1809EB410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68D0420", Offset = "0x68CEC20", VA = "0x1868D0420")]
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
		[Cpp2IlInjected.Address(RVA = "0x25454B0", Offset = "0x2543CB0", VA = "0x1825454B0")]
		public PDNFAOJNEKC(IILMIMNGKPF NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory GGKCNFLLBEE;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	public static void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68D02A0", Offset = "0x68CEAA0", VA = "0x1868D02A0")]
	static HDKIAOOHAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x283D500", Offset = "0x283BD00", VA = "0x18283D500")]
	public static PDNFAOJNEKC DPBMKNHEDMC(IILMIMNGKPF NDDCLPHCEEO)
	{
		return default(PDNFAOJNEKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
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
		[Cpp2IlInjected.Address(RVA = "0x5748D10", Offset = "0x5747510", VA = "0x185748D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5748DB0", Offset = "0x57475B0", VA = "0x185748DB0")]
	public DHCBBOLKALJ(Action<TValue> DPFCEFBKJAL, [Optional] Func<TValue> IMDOAAPGAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x57481A0", Offset = "0x57469A0", VA = "0x1857481A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5748C70", Offset = "0x5747470", VA = "0x185748C70")]
	public THandle PBLNBBGFGAP(TValue JMDCGOKJIDA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5748080", Offset = "0x5746880", VA = "0x185748080")]
	public bool CKOHIKCJKJA(THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5748480", Offset = "0x5746C80", VA = "0x185748480")]
	public bool FFKNBABIJFJ(THandle IIMJMBJHGDI, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5748760", Offset = "0x5746F60", VA = "0x185748760")]
	public TValue JMJOGDIBBHK(THandle IIMJMBJHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x57489B0", Offset = "0x57471B0", VA = "0x1857489B0")]
	public bool LNFEOGNEOOI(THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5748950", Offset = "0x5747150", VA = "0x185748950")]
	private THandle LJMGJBMEHNC(int DHNLEFJCEAH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5748D50", Offset = "0x5747550", VA = "0x185748D50")]
	private TValue POIMHEEJLCG(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5748380", Offset = "0x5746B80", VA = "0x185748380")]
	private void FEFADGGNLEI(int DHNLEFJCEAH, [In] THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5748540", Offset = "0x5746D40", VA = "0x185748540")]
	private void HEOMLDPCKGB(int DHNLEFJCEAH, [In] TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5748AC0", Offset = "0x57472C0", VA = "0x185748AC0")]
	private THandle NEFCHJDBGAD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5748270", Offset = "0x5746A70", VA = "0x185748270")]
	private void EDHEDILPGLJ(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5748190", Offset = "0x5746990", VA = "0x185748190")]
	private int DGACABAFAGG(int DMDAEILPBHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5748C60", Offset = "0x5747460", VA = "0x185748C60")]
	private bool NNMBELKEAAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8577B0", VA = "0x180858FB0")]
	private void LKHDBNPNDNP(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x57483D0", Offset = "0x5746BD0", VA = "0x1857483D0")]
	private bool FFINEKPMFJP([Out] THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5748590", Offset = "0x5746D90", VA = "0x185748590")]
	private bool HILLLHPLOHH([Out] THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x57486B0", Offset = "0x5746EB0", VA = "0x1857486B0")]
	private void JJGPLACDCHI(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x57487B0", Offset = "0x5746FB0", VA = "0x1857487B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B6EDC0", Offset = "0x2B6D5C0", VA = "0x182B6EDC0")]
	public static bool PHINDPEAKKH<T>(this T IIMJMBJHGDI, T OKGBBGMIACH) where T : struct, DIAIPOOLIIL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EDB0", Offset = "0x2B6D5B0", VA = "0x182B6EDB0")]
	public static bool OONANGMADII<T>(this T IIMJMBJHGDI) where T : struct, DIAIPOOLIIL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68D0310", Offset = "0x68CEB10", VA = "0x1868D0310")]
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
	[Cpp2IlInjected.Address(RVA = "0x4221850", Offset = "0x4220050", VA = "0x184221850")]
	public JBCMKOAFGAE(Type FPPJJFGLDKN, Span<byte> JNJLMODIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCEC0", Offset = "0x2BBB6C0", VA = "0x182BBCEC0")]
	public static JBCMKOAFGAE AIJAFPFEFCM<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(JBCMKOAFGAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68D05D0", Offset = "0x68CEDD0", VA = "0x1868D05D0")]
	public static JHKEOJJDFBK GCLAHEGAFFN([In] JBCMKOAFGAE DLFEHJOHIIJ)
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68D0550", Offset = "0x68CED50", VA = "0x1868D0550")]
	public Enum FDGEPDCLICC(Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE080", Offset = "0x2BBC880", VA = "0x182BBE080")]
	public void OLOHHMDPKEO<T>([In] T JMDCGOKJIDA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68D0540", Offset = "0x68CED40", VA = "0x1868D0540")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D0780", Offset = "0x68CEF80", VA = "0x1868D0780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4221850", Offset = "0x4220050", VA = "0x184221850")]
	public JHKEOJJDFBK(Type FPPJJFGLDKN, ReadOnlySpan<byte> JNJLMODIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBCC0", Offset = "0x2BCA4C0", VA = "0x182BCBCC0")]
	public static JHKEOJJDFBK AIJAFPFEFCM<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBDF0", Offset = "0x2BCA5F0", VA = "0x182BCBDF0")]
	public static JHKEOJJDFBK AIJAFPFEFCM<T>(NativeArray<T> JMDCGOKJIDA) where T : struct
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68D07C0", Offset = "0x68CEFC0", VA = "0x1868D07C0")]
	public void PGKLAMLJNDJ(NativeArray<byte> CGCFPGMCFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE7F0", Offset = "0x2BCCFF0", VA = "0x182BCE7F0")]
	public T JMJOGDIBBHK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE770", Offset = "0x2BCCF70", VA = "0x182BCE770")]
	public NativeArray<T> GOELFKMMAGI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68D0890", Offset = "0x68CF090", VA = "0x1868D0890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68D0650", Offset = "0x68CEE50", VA = "0x1868D0650")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B70A10", Offset = "0x2B6F210", VA = "0x182B70A10")]
	public static NativeArray<T> BOOPHANMLJP<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B709C0", Offset = "0x2B6F1C0", VA = "0x182B709C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4750EE0", Offset = "0x474F6E0", VA = "0x184750EE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x47514D0", Offset = "0x474FCD0", VA = "0x1847514D0")]
		public PBHGPPPHMLD(JMEKFLDIIFL<Handle> JOPKJIBCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4750B70", Offset = "0x474F370", VA = "0x184750B70")]
		public BNPLEPGLEPL FJAAFKPDAIA([In] BNPLEPGLEPL LMDEKGEENAI)
		{
			return default(BNPLEPGLEPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4751290", Offset = "0x474FA90", VA = "0x184751290")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4751050", Offset = "0x474F850", VA = "0x184751050")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E730F0", Offset = "0x4E718F0", VA = "0x184E730F0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E73230", Offset = "0x4E71A30", VA = "0x184E73230")]
		public BNPLEPGLEPL(JMEKFLDIIFL<Handle> JOPKJIBCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E73170", Offset = "0x4E71970", VA = "0x184E73170")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E73040", Offset = "0x4E71840", VA = "0x184E73040")]
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
		[Cpp2IlInjected.Address(RVA = "0x40A9290", Offset = "0x40A7A90", VA = "0x1840A9290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BNPLEPGLEPL OMADHNHPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x40A9670", Offset = "0x40A7E70", VA = "0x1840A9670")]
		get
		{
			return default(BNPLEPGLEPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40A97D0", Offset = "0x40A7FD0", VA = "0x1840A97D0")]
	public JMEKFLDIIFL(int AHECCPJHEFF, Allocator CHDJMCMMMLJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40A7380", Offset = "0x40A5B80", VA = "0x1840A7380")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x18CAEB0", Offset = "0x18C96B0", VA = "0x1818CAEB0")]
	public static int DGACABAFAGG(int NJJHKDBJDAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2576240", Offset = "0x2574A40", VA = "0x182576240")]
	public static bool NMNDAGHCFGE(int NJJHKDBJDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x40A8790", Offset = "0x40A6F90", VA = "0x1840A8790")]
	public bool IBJKGKLKMJK(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40A8CE0", Offset = "0x40A74E0", VA = "0x1840A8CE0")]
	public bool ICPKLNCPNLN(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40A71E0", Offset = "0x40A59E0", VA = "0x1840A71E0")]
	public Handle CLAEJJKKLOO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40A7D10", Offset = "0x40A6510", VA = "0x1840A7D10")]
	public void IAJGPHKHNEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40A9600", Offset = "0x40A7E00", VA = "0x1840A9600")]
	public void NNCHCODGEEH(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40A7A10", Offset = "0x40A6210", VA = "0x1840A7A10")]
	public bool EJCKHLBDCKI(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BD60", VA = "0x180A6D560")]
	private bool MDHLFFKGHKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40A70B0", Offset = "0x40A58B0", VA = "0x1840A70B0")]
	private bool BPHBPCFPMNM(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x40A78A0", Offset = "0x40A60A0", VA = "0x1840A78A0")]
	private void EINIANEDEHK([Out] int DHNLEFJCEAH, [Out] int DMDAEILPBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40A9100", Offset = "0x40A7900", VA = "0x1840A9100")]
	private void IPCHIDJGPMF(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40A7C70", Offset = "0x40A6470", VA = "0x1840A7C70")]
	private void FJIDHAJIPHA(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40A93C0", Offset = "0x40A7BC0", VA = "0x1840A93C0")]
	private bool KEENPFAKGFD([Out] int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40A6E40", Offset = "0x40A5640", VA = "0x1840A6E40")]
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
	[Cpp2IlInjected.Address(RVA = "0x452B560", Offset = "0x4529D60", VA = "0x18452B560")]
	public NLJNNOLMIDI(int AHECCPJHEFF, [Optional] Action<T> DKBFFBLIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x452A2A0", Offset = "0x4528AA0", VA = "0x18452A2A0")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x452A470", Offset = "0x4528C70", VA = "0x18452A470")]
	public bool FFKNBABIJFJ(Handle IIMJMBJHGDI, [Out] T MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x452B340", Offset = "0x4529B40", VA = "0x18452B340")]
	public Handle PBLNBBGFGAP(T MEAFIMADMKA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x452ADE0", Offset = "0x45295E0", VA = "0x18452ADE0")]
	public void NIGFFIBODJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x452AAD0", Offset = "0x45292D0", VA = "0x18452AAD0")]
	public void MFKDEBIIBOM(Handle IIMJMBJHGDI, [Out] T OHPMNAJMMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x452AA00", Offset = "0x4529200", VA = "0x18452AA00")]
	public void MFKDEBIIBOM(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4529F60", Offset = "0x4528760", VA = "0x184529F60")]
	public bool CKCCKFKKMLA(Handle IIMJMBJHGDI, [Out] T OHPMNAJMMGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4529D80", Offset = "0x4528580", VA = "0x184529D80")]
	public bool CKCCKFKKMLA(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4529C40", Offset = "0x4528440", VA = "0x184529C40")]
	private T ACAJIKLBJOM(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x452A5D0", Offset = "0x4528DD0", VA = "0x18452A5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE50", Offset = "0x2B8A650", VA = "0x182B8BE50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> KFOCBDPELCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9630", Offset = "0x3BD7E30", VA = "0x183BD9630")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE66560", Offset = "0xE64D60", VA = "0x180E66560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3BD9840", Offset = "0x3BD8040", VA = "0x183BD9840")]
	public FHBDICCJKKK(int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3BD96D0", Offset = "0x3BD7ED0", VA = "0x183BD96D0")]
	public int IMLBDBIFEKB(T JMDCGOKJIDA, int GBALKPFEDAI, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3BD9530", Offset = "0x3BD7D30", VA = "0x183BD9530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x40A5120", Offset = "0x40A3920", VA = "0x1840A5120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x40A51C0", Offset = "0x40A39C0", VA = "0x1840A51C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x40A5190", Offset = "0x40A3990", VA = "0x1840A5190")]
		public JMAJGMAAMCO(FCCFNDGAOHI<T> CGIFJALMJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x40A5090", Offset = "0x40A3890", VA = "0x1840A5090", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40A50D0", Offset = "0x40A38D0", VA = "0x1840A50D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B6E810", Offset = "0x3B6D010", VA = "0x183B6E810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DD40", Offset = "0x3B6C540", VA = "0x183B6DD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E3F0", Offset = "0x3B6CBF0", VA = "0x183B6E3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DFF0", Offset = "0x3B6C7F0", VA = "0x183B6DFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> KFOCBDPELCO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E180", Offset = "0x3B6C980", VA = "0x183B6E180")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E950", Offset = "0x3B6D150", VA = "0x183B6E950")]
	public FCCFNDGAOHI(int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E310", Offset = "0x3B6CB10", VA = "0x183B6E310")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E710", Offset = "0x3B6CF10", VA = "0x183B6E710")]
	public void PBLNBBGFGAP(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B6DDC0", Offset = "0x3B6C5C0", VA = "0x183B6DDC0")]
	internal void EMFKJPPIBCE(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E630", Offset = "0x3B6CE30", VA = "0x183B6E630")]
	public void MNACKLLGDEF(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B6DB10", Offset = "0x3B6C310", VA = "0x183B6DB10")]
	public void AHODFEAKAPC(int ONAHHCLNBMK, int DAOCGKJPECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E370", Offset = "0x3B6CB70", VA = "0x183B6E370")]
	public int IMLBDBIFEKB(T JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B6DD80", Offset = "0x3B6C580", VA = "0x183B6DD80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E240", Offset = "0x3B6CA40", VA = "0x183B6E240", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E8A0", Offset = "0x3B6D0A0", VA = "0x183B6E8A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E8E0", Offset = "0x3B6D0E0", VA = "0x183B6E8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E030", Offset = "0x3B6C830", VA = "0x183B6E030")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void GCDGFGOFCNL(int JMDCGOKJIDA, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E420", Offset = "0x3B6CC20", VA = "0x183B6E420")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LAKBBFJHJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JDLJCBHINAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x68D01F0", Offset = "0x68CE9F0", VA = "0x1868D01F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x68D01E0", Offset = "0x68CE9E0", VA = "0x1868D01E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC3F080", Offset = "0xC3D880", VA = "0x180C3F080")]
	private DCAAIJCHCEO(int PENDBLHFGOI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA470", Offset = "0x1FC8C70", VA = "0x181FCA470")]
	public static DCAAIJCHCEO HFMDNJKDJMF(int PENDBLHFGOI, int IHGHLPOONHD)
	{
		return default(DCAAIJCHCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x68D0200", Offset = "0x68CEA00", VA = "0x1868D0200")]
	public static DCAAIJCHCEO KODHNMIOGBA(int GBALKPFEDAI, int DAOCGKJPECC)
	{
		return default(DCAAIJCHCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68D0210", Offset = "0x68CEA10", VA = "0x1868D0210", Slot = "3")]
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
