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
		[Cpp2IlInjected.Address(RVA = "0x68D09D0", Offset = "0x68CF3D0", VA = "0x1868D09D0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class APNDBANBKFE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68CF5D0", Offset = "0x68CDFD0", VA = "0x1868CF5D0")]
	public static void OGMOBPNHCEI(this GameObject NBDLDMDNCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68CF670", Offset = "0x68CE070", VA = "0x1868CF670")]
	public static void OGMOBPNHCEI(this Component INPAFGCEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68CF710", Offset = "0x68CE110", VA = "0x1868CF710")]
	public static void OGMOBPNHCEI(this ScriptableObject JHBGADOOAAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MBKBIFPEGOI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68D0B10", Offset = "0x68CF510", VA = "0x1868D0B10")]
	public static Span<byte> KFKILADLDJC(this NativeArray<byte> PFKJAOOHGBN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68D0A60", Offset = "0x68CF460", VA = "0x1868D0A60")]
	public static ReadOnlySpan<byte> IGCPKIKCNFG(this NativeArray<byte> PFKJAOOHGBN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D560", Offset = "0x2C1BF60", VA = "0x182C1D560")]
	public static NativeArray<T> AJPIDPMCHJH<T>(this NativeArray<T> PFKJAOOHGBN, DCAAIJCHCEO NHEIBBJGGFH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D5A0", Offset = "0x2C1BFA0", VA = "0x182C1D5A0")]
	public static NativeArray<T> AJPIDPMCHJH<T>(this NativeArray<T> PFKJAOOHGBN, int GBALKPFEDAI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMBOJKJGDKO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B30B50", Offset = "0x2B2F550", VA = "0x182B30B50")]
	public static string FMCMNJELJPM<T>(this NativeArray<T> PFKJAOOHGBN, string PCOEHEFFIFO = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CFOPDFPPFCB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2935BD0", Offset = "0x29345D0", VA = "0x182935BD0")]
	public static T JMJOGDIBBHK<T>([In] this ReadOnlySpan<byte> JNJLMODIELO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2935450", Offset = "0x2933E50", VA = "0x182935450")]
	public static NativeArray<T> GOELFKMMAGI<T>(this ReadOnlySpan<byte> JNJLMODIELO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2935880", Offset = "0x2934280", VA = "0x182935880")]
	public static ReadOnlySpan<TTo> HMGPGCAKDEO<TTo, TFrom>(this ReadOnlySpan<TFrom> JNJLMODIELO) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2936CD0", Offset = "0x29356D0", VA = "0x182936CD0")]
	public static Span<byte> OLOHHMDPKEO<T>([In] this Span<byte> JNJLMODIELO, T JMDCGOKJIDA) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68CFCC0", Offset = "0x68CE6C0", VA = "0x1868CFCC0")]
	private static Enum ECAKFIHJNEO([In] ReadOnlySpan<byte> JNJLMODIELO, Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68D0270", Offset = "0x68CEC70", VA = "0x1868D0270")]
	public static Enum FDGEPDCLICC([In] this Span<byte> JNJLMODIELO, Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68CF7B0", Offset = "0x68CE1B0", VA = "0x1868CF7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D0BC0", Offset = "0x68CF5C0", VA = "0x1868D0BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9EB410", Offset = "0x9E9E10", VA = "0x1809EB410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68D0520", Offset = "0x68CEF20", VA = "0x1868D0520")]
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
		[Cpp2IlInjected.Address(RVA = "0x25454B0", Offset = "0x2543EB0", VA = "0x1825454B0")]
		public PDNFAOJNEKC(IILMIMNGKPF NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory GGKCNFLLBEE;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	public static void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68D03A0", Offset = "0x68CEDA0", VA = "0x1868D03A0")]
	static HDKIAOOHAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x283D100", Offset = "0x283BB00", VA = "0x18283D100")]
	public static PDNFAOJNEKC DPBMKNHEDMC(IILMIMNGKPF NDDCLPHCEEO)
	{
		return default(PDNFAOJNEKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
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
		[Cpp2IlInjected.Address(RVA = "0x5748E10", Offset = "0x5747810", VA = "0x185748E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5748EB0", Offset = "0x57478B0", VA = "0x185748EB0")]
	public DHCBBOLKALJ(Action<TValue> DPFCEFBKJAL, [Optional] Func<TValue> IMDOAAPGAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x57482A0", Offset = "0x5746CA0", VA = "0x1857482A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5748D70", Offset = "0x5747770", VA = "0x185748D70")]
	public THandle PBLNBBGFGAP(TValue JMDCGOKJIDA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5748180", Offset = "0x5746B80", VA = "0x185748180")]
	public bool CKOHIKCJKJA(THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5748580", Offset = "0x5746F80", VA = "0x185748580")]
	public bool FFKNBABIJFJ(THandle IIMJMBJHGDI, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5748860", Offset = "0x5747260", VA = "0x185748860")]
	public TValue JMJOGDIBBHK(THandle IIMJMBJHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5748AB0", Offset = "0x57474B0", VA = "0x185748AB0")]
	public bool LNFEOGNEOOI(THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5748A50", Offset = "0x5747450", VA = "0x185748A50")]
	private THandle LJMGJBMEHNC(int DHNLEFJCEAH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5748E50", Offset = "0x5747850", VA = "0x185748E50")]
	private TValue POIMHEEJLCG(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5748480", Offset = "0x5746E80", VA = "0x185748480")]
	private void FEFADGGNLEI(int DHNLEFJCEAH, [In] THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5748640", Offset = "0x5747040", VA = "0x185748640")]
	private void HEOMLDPCKGB(int DHNLEFJCEAH, [In] TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5748BC0", Offset = "0x57475C0", VA = "0x185748BC0")]
	private THandle NEFCHJDBGAD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5748370", Offset = "0x5746D70", VA = "0x185748370")]
	private void EDHEDILPGLJ(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5748290", Offset = "0x5746C90", VA = "0x185748290")]
	private int DGACABAFAGG(int DMDAEILPBHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5748D60", Offset = "0x5747760", VA = "0x185748D60")]
	private bool NNMBELKEAAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8579B0", VA = "0x180858FB0")]
	private void LKHDBNPNDNP(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x57484D0", Offset = "0x5746ED0", VA = "0x1857484D0")]
	private bool FFINEKPMFJP([Out] THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5748690", Offset = "0x5747090", VA = "0x185748690")]
	private bool HILLLHPLOHH([Out] THandle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x57487B0", Offset = "0x57471B0", VA = "0x1857487B0")]
	private void JJGPLACDCHI(THandle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x57488B0", Offset = "0x57472B0", VA = "0x1857488B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B6EB40", Offset = "0x2B6D540", VA = "0x182B6EB40")]
	public static bool PHINDPEAKKH<T>(this T IIMJMBJHGDI, T OKGBBGMIACH) where T : struct, DIAIPOOLIIL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EB30", Offset = "0x2B6D530", VA = "0x182B6EB30")]
	public static bool OONANGMADII<T>(this T IIMJMBJHGDI) where T : struct, DIAIPOOLIIL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68D0410", Offset = "0x68CEE10", VA = "0x1868D0410")]
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
	[Cpp2IlInjected.Address(RVA = "0x4221950", Offset = "0x4220350", VA = "0x184221950")]
	public JBCMKOAFGAE(Type FPPJJFGLDKN, Span<byte> JNJLMODIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCC40", Offset = "0x2BBB640", VA = "0x182BBCC40")]
	public static JBCMKOAFGAE AIJAFPFEFCM<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(JBCMKOAFGAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68D06D0", Offset = "0x68CF0D0", VA = "0x1868D06D0")]
	public static JHKEOJJDFBK GCLAHEGAFFN([In] JBCMKOAFGAE DLFEHJOHIIJ)
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68D0650", Offset = "0x68CF050", VA = "0x1868D0650")]
	public Enum FDGEPDCLICC(Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDE00", Offset = "0x2BBC800", VA = "0x182BBDE00")]
	public void OLOHHMDPKEO<T>([In] T JMDCGOKJIDA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68D0640", Offset = "0x68CF040", VA = "0x1868D0640")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D0880", Offset = "0x68CF280", VA = "0x1868D0880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4221950", Offset = "0x4220350", VA = "0x184221950")]
	public JHKEOJJDFBK(Type FPPJJFGLDKN, ReadOnlySpan<byte> JNJLMODIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBDC0", Offset = "0x2BCA7C0", VA = "0x182BCBDC0")]
	public static JHKEOJJDFBK AIJAFPFEFCM<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBEF0", Offset = "0x2BCA8F0", VA = "0x182BCBEF0")]
	public static JHKEOJJDFBK AIJAFPFEFCM<T>(NativeArray<T> JMDCGOKJIDA) where T : struct
	{
		return default(JHKEOJJDFBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68D08C0", Offset = "0x68CF2C0", VA = "0x1868D08C0")]
	public void PGKLAMLJNDJ(NativeArray<byte> CGCFPGMCFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE8F0", Offset = "0x2BCD2F0", VA = "0x182BCE8F0")]
	public T JMJOGDIBBHK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE870", Offset = "0x2BCD270", VA = "0x182BCE870")]
	public NativeArray<T> GOELFKMMAGI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68D0990", Offset = "0x68CF390", VA = "0x1868D0990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68D0750", Offset = "0x68CF150", VA = "0x1868D0750")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B70790", Offset = "0x2B6F190", VA = "0x182B70790")]
	public static NativeArray<T> BOOPHANMLJP<T>(T JMDCGOKJIDA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B70740", Offset = "0x2B6F140", VA = "0x182B70740")]
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
			[Cpp2IlInjected.Address(RVA = "0x4750FE0", Offset = "0x474F9E0", VA = "0x184750FE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x47515D0", Offset = "0x474FFD0", VA = "0x1847515D0")]
		public PBHGPPPHMLD(JMEKFLDIIFL<Handle> JOPKJIBCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4750C70", Offset = "0x474F670", VA = "0x184750C70")]
		public BNPLEPGLEPL FJAAFKPDAIA([In] BNPLEPGLEPL LMDEKGEENAI)
		{
			return default(BNPLEPGLEPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4751390", Offset = "0x474FD90", VA = "0x184751390")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4751150", Offset = "0x474FB50", VA = "0x184751150")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E731F0", Offset = "0x4E71BF0", VA = "0x184E731F0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E73330", Offset = "0x4E71D30", VA = "0x184E73330")]
		public BNPLEPGLEPL(JMEKFLDIIFL<Handle> JOPKJIBCCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E73270", Offset = "0x4E71C70", VA = "0x184E73270")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E73140", Offset = "0x4E71B40", VA = "0x184E73140")]
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
		[Cpp2IlInjected.Address(RVA = "0x40A9390", Offset = "0x40A7D90", VA = "0x1840A9390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BNPLEPGLEPL OMADHNHPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x40A9770", Offset = "0x40A8170", VA = "0x1840A9770")]
		get
		{
			return default(BNPLEPGLEPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40A98D0", Offset = "0x40A82D0", VA = "0x1840A98D0")]
	public JMEKFLDIIFL(int AHECCPJHEFF, Allocator CHDJMCMMMLJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40A7480", Offset = "0x40A5E80", VA = "0x1840A7480")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x18CAEB0", Offset = "0x18C98B0", VA = "0x1818CAEB0")]
	public static int DGACABAFAGG(int NJJHKDBJDAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2576240", Offset = "0x2574C40", VA = "0x182576240")]
	public static bool NMNDAGHCFGE(int NJJHKDBJDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x40A8890", Offset = "0x40A7290", VA = "0x1840A8890")]
	public bool IBJKGKLKMJK(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40A8DE0", Offset = "0x40A77E0", VA = "0x1840A8DE0")]
	public bool ICPKLNCPNLN(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40A72E0", Offset = "0x40A5CE0", VA = "0x1840A72E0")]
	public Handle CLAEJJKKLOO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40A7E10", Offset = "0x40A6810", VA = "0x1840A7E10")]
	public void IAJGPHKHNEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40A9700", Offset = "0x40A8100", VA = "0x1840A9700")]
	public void NNCHCODGEEH(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40A7B10", Offset = "0x40A6510", VA = "0x1840A7B10")]
	public bool EJCKHLBDCKI(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BF60", VA = "0x180A6D560")]
	private bool MDHLFFKGHKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40A71B0", Offset = "0x40A5BB0", VA = "0x1840A71B0")]
	private bool BPHBPCFPMNM(int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x40A79A0", Offset = "0x40A63A0", VA = "0x1840A79A0")]
	private void EINIANEDEHK([Out] int DHNLEFJCEAH, [Out] int DMDAEILPBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40A9200", Offset = "0x40A7C00", VA = "0x1840A9200")]
	private void IPCHIDJGPMF(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40A7D70", Offset = "0x40A6770", VA = "0x1840A7D70")]
	private void FJIDHAJIPHA(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40A94C0", Offset = "0x40A7EC0", VA = "0x1840A94C0")]
	private bool KEENPFAKGFD([Out] int DHNLEFJCEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40A6F40", Offset = "0x40A5940", VA = "0x1840A6F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x452B660", Offset = "0x452A060", VA = "0x18452B660")]
	public NLJNNOLMIDI(int AHECCPJHEFF, [Optional] Action<T> DKBFFBLIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x452A3A0", Offset = "0x4528DA0", VA = "0x18452A3A0")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x452A570", Offset = "0x4528F70", VA = "0x18452A570")]
	public bool FFKNBABIJFJ(Handle IIMJMBJHGDI, [Out] T MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x452B440", Offset = "0x4529E40", VA = "0x18452B440")]
	public Handle PBLNBBGFGAP(T MEAFIMADMKA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x452AEE0", Offset = "0x45298E0", VA = "0x18452AEE0")]
	public void NIGFFIBODJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x452ABD0", Offset = "0x45295D0", VA = "0x18452ABD0")]
	public void MFKDEBIIBOM(Handle IIMJMBJHGDI, [Out] T OHPMNAJMMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x452AB00", Offset = "0x4529500", VA = "0x18452AB00")]
	public void MFKDEBIIBOM(Handle IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x452A060", Offset = "0x4528A60", VA = "0x18452A060")]
	public bool CKCCKFKKMLA(Handle IIMJMBJHGDI, [Out] T OHPMNAJMMGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4529E80", Offset = "0x4528880", VA = "0x184529E80")]
	public bool CKCCKFKKMLA(Handle IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4529D40", Offset = "0x4528740", VA = "0x184529D40")]
	private T ACAJIKLBJOM(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x452A6D0", Offset = "0x45290D0", VA = "0x18452A6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECD30", VA = "0x181FEE330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BBD0", Offset = "0x2B8A5D0", VA = "0x182B8BBD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> KFOCBDPELCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9730", Offset = "0x3BD8130", VA = "0x183BD9730")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE66560", Offset = "0xE64F60", VA = "0x180E66560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3BD9940", Offset = "0x3BD8340", VA = "0x183BD9940")]
	public FHBDICCJKKK(int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3BD97D0", Offset = "0x3BD81D0", VA = "0x183BD97D0")]
	public int IMLBDBIFEKB(T JMDCGOKJIDA, int GBALKPFEDAI, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3BD9630", Offset = "0x3BD8030", VA = "0x183BD9630", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x40A5220", Offset = "0x40A3C20", VA = "0x1840A5220", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x40A52C0", Offset = "0x40A3CC0", VA = "0x1840A52C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x40A5290", Offset = "0x40A3C90", VA = "0x1840A5290")]
		public JMAJGMAAMCO(FCCFNDGAOHI<T> CGIFJALMJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x40A5190", Offset = "0x40A3B90", VA = "0x1840A5190", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40A51D0", Offset = "0x40A3BD0", VA = "0x1840A51D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B6E910", Offset = "0x3B6D310", VA = "0x183B6E910")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DE40", Offset = "0x3B6C840", VA = "0x183B6DE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E4F0", Offset = "0x3B6CEF0", VA = "0x183B6E4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E0F0", Offset = "0x3B6CAF0", VA = "0x183B6E0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> KFOCBDPELCO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E280", Offset = "0x3B6CC80", VA = "0x183B6E280")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3B6EA50", Offset = "0x3B6D450", VA = "0x183B6EA50")]
	public FCCFNDGAOHI(int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E410", Offset = "0x3B6CE10", VA = "0x183B6E410")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E810", Offset = "0x3B6D210", VA = "0x183B6E810")]
	public void PBLNBBGFGAP(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B6DEC0", Offset = "0x3B6C8C0", VA = "0x183B6DEC0")]
	internal void EMFKJPPIBCE(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E730", Offset = "0x3B6D130", VA = "0x183B6E730")]
	public void MNACKLLGDEF(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B6DC10", Offset = "0x3B6C610", VA = "0x183B6DC10")]
	public void AHODFEAKAPC(int ONAHHCLNBMK, int DAOCGKJPECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E470", Offset = "0x3B6CE70", VA = "0x183B6E470")]
	public int IMLBDBIFEKB(T JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B6DE80", Offset = "0x3B6C880", VA = "0x183B6DE80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E340", Offset = "0x3B6CD40", VA = "0x183B6E340", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E9A0", Offset = "0x3B6D3A0", VA = "0x183B6E9A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E9E0", Offset = "0x3B6D3E0", VA = "0x183B6E9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E130", Offset = "0x3B6CB30", VA = "0x183B6E130")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void GCDGFGOFCNL(int JMDCGOKJIDA, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E520", Offset = "0x3B6CF20", VA = "0x183B6E520")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A490", VA = "0x18255BA90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9B30", Offset = "0x5CA8530", VA = "0x185CA9B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LAKBBFJHJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A910", VA = "0x180A7BF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JDLJCBHINAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x68D02F0", Offset = "0x68CECF0", VA = "0x1868D02F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x68D02E0", Offset = "0x68CECE0", VA = "0x1868D02E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC3F080", Offset = "0xC3DA80", VA = "0x180C3F080")]
	private DCAAIJCHCEO(int PENDBLHFGOI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA470", Offset = "0x1FC8E70", VA = "0x181FCA470")]
	public static DCAAIJCHCEO HFMDNJKDJMF(int PENDBLHFGOI, int IHGHLPOONHD)
	{
		return default(DCAAIJCHCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x68D0300", Offset = "0x68CED00", VA = "0x1868D0300")]
	public static DCAAIJCHCEO KODHNMIOGBA(int GBALKPFEDAI, int DAOCGKJPECC)
	{
		return default(DCAAIJCHCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68D0310", Offset = "0x68CED10", VA = "0x1868D0310", Slot = "3")]
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
