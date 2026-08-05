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
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C483B0", Offset = "0x6C46FB0", VA = "0x186C483B0", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DECOAODJKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C47DF0", Offset = "0x6C469F0", VA = "0x186C47DF0")]
	public static void LDEAMGPMAEF(this GameObject DKOODDCANLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C47D50", Offset = "0x6C46950", VA = "0x186C47D50")]
	public static void LDEAMGPMAEF(this Component BHEFEMNBEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C47CB0", Offset = "0x6C468B0", VA = "0x186C47CB0")]
	public static void LDEAMGPMAEF(this ScriptableObject DKNKKFPIDCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JBPIFAIEICN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C48140", Offset = "0x6C46D40", VA = "0x186C48140")]
	public static Span<byte> ENOLJJACEFK(this NativeArray<byte> BFDOCKABCPN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C481F0", Offset = "0x6C46DF0", VA = "0x186C481F0")]
	public static ReadOnlySpan<byte> PIGDKOOBGOF(this NativeArray<byte> BFDOCKABCPN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E7B7F0", Offset = "0x2E7A3F0", VA = "0x182E7B7F0")]
	public static NativeArray<T> EFJHEPHJHLM<T>(this NativeArray<T> BFDOCKABCPN, FEBLOFFJPHN KNJGLEAPDIO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E7B830", Offset = "0x2E7A430", VA = "0x182E7B830")]
	public static NativeArray<T> EFJHEPHJHLM<T>(this NativeArray<T> BFDOCKABCPN, int GMEOEMGBEED) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NBKEMPHGIBG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F340", Offset = "0x2F5DF40", VA = "0x182F5F340")]
	public static string JBGPGDFPFHA<T>(this NativeArray<T> BFDOCKABCPN, string HGKFJIOFOLJ = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PNPLGGIBFAI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C491D0", Offset = "0x6C47DD0", VA = "0x186C491D0")]
	public static void FEGEFHGJACC(this NativeList<byte> APGPCFDNGCA, ReadOnlySpan<byte> HMDBAHOLLOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NHKNPCMLIEF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2F67EC0", Offset = "0x2F66AC0", VA = "0x182F67EC0")]
	public static T MGJGJKKLOCJ<T>(this ReadOnlySpan<byte> CABLCDOIFFL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F68000", Offset = "0x2F66C00", VA = "0x182F68000")]
	public static ReadOnlySpan<byte> PIGDKOOBGOF<T>(this T CABLCDOIFFL) where T : struct
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F67970", Offset = "0x2F66570", VA = "0x182F67970")]
	public static T IBIJBNAFKLE<T>([In] this ReadOnlySpan<byte> HMDBAHOLLOF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CF90", Offset = "0x2E6BB90", VA = "0x182E6CF90")]
	public static ReadOnlySpan<TTo> EKMPFEJNOGC<TTo>(this ReadOnlySpan<byte> HMDBAHOLLOF) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F67460", Offset = "0x2F66060", VA = "0x182F67460")]
	public static Span<byte> GAOLHIMCFIN<T>([In] this Span<byte> HMDBAHOLLOF, T CABLCDOIFFL) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C48560", Offset = "0x6C47160", VA = "0x186C48560")]
	private static Enum IOKBHBFEDEM([In] ReadOnlySpan<byte> HMDBAHOLLOF, Type GDHBPGJCJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C48B00", Offset = "0x6C47700", VA = "0x186C48B00")]
	public static Enum MLAIEOIOCJI([In] this Span<byte> HMDBAHOLLOF, Type GDHBPGJCJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C48B70", Offset = "0x6C47770", VA = "0x186C48B70")]
	public static void PIIHNLJCBCM([In] this Span<byte> HMDBAHOLLOF, Enum DIBAENLMLKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NCBEHPBPJJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OMGDAPKCAHB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C49050", Offset = "0x6C47C50", VA = "0x186C49050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C48440", Offset = "0x6C47040", VA = "0x186C48440")]
	[AsyncStateMachine(typeof(OMGDAPKCAHB))]
	public static void HIFHJBGKPHK(this Task APOGBJPOAAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EPNAKPMPEOH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LPCMLBEHBDN : short
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Uncategorized = 5,
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

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LPJNFJDPECM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly LPCMLBEHBDN NONKDEOLPHL;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x272BE10", Offset = "0x272AA10", VA = "0x18272BE10")]
		public LPJNFJDPECM(LPCMLBEHBDN NONKDEOLPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory GGOHEOEPIEI;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	public static void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C48020", Offset = "0x6C46C20", VA = "0x186C48020")]
	static EPNAKPMPEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAA60", Offset = "0x2AF9660", VA = "0x182AFAA60")]
	public static LPJNFJDPECM AGPDAMALBJL(LPCMLBEHBDN NONKDEOLPHL)
	{
		return default(LPJNFJDPECM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	public static void CPHEPPMDMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PLBMHLNEBOP<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GCHandle JBFBMCPGKHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T PPPKGAOABBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x48B4C00", Offset = "0x48B3800", VA = "0x1848B4C00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x48B4B30", Offset = "0x48B3730", VA = "0x1848B4B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x48B4CA0", Offset = "0x48B38A0", VA = "0x1848B4CA0")]
	public PLBMHLNEBOP(T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x48B4B00", Offset = "0x48B3700", VA = "0x1848B4B00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class NOKADPMDKJH<THandle, TValue> : IDisposable where THandle : struct, HLDDCBEIKDI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<THandle> BKJFMIDIDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly List<TValue> ILAABJMNJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Func<TValue> KAHEAGELECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Action<TValue> GMFOIFFPJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int FPEDIGJOCLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TValue CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x46B2770", Offset = "0x46B1370", VA = "0x1846B2770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x46B3250", Offset = "0x46B1E50", VA = "0x1846B3250")]
	public NOKADPMDKJH(Action<TValue> GMFOIFFPJMG, [Optional] Func<TValue> KAHEAGELECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x46B27B0", Offset = "0x46B13B0", VA = "0x1846B27B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x46B26D0", Offset = "0x46B12D0", VA = "0x1846B26D0")]
	public THandle CMCAIIEBGOH(TValue CABLCDOIFFL)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x46B2FA0", Offset = "0x46B1BA0", VA = "0x1846B2FA0")]
	public bool PAMNEBLPMKL(THandle JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x46B2950", Offset = "0x46B1550", VA = "0x1846B2950")]
	public bool JMHMMLHCCPD(THandle JBFBMCPGKHE, [Out] TValue CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x46B2900", Offset = "0x46B1500", VA = "0x1846B2900")]
	public TValue IBIJBNAFKLE(THandle JBFBMCPGKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46B2570", Offset = "0x46B1170", VA = "0x1846B2570")]
	public bool AMOCDEJOLHN(THandle JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46B2A20", Offset = "0x46B1620", VA = "0x1846B2A20")]
	private THandle JPPEAFHHCPC(int MFJLAMOCOBC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46B2880", Offset = "0x46B1480", VA = "0x1846B2880")]
	private TValue EENAOOMALPK(int MFJLAMOCOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46B2680", Offset = "0x46B1280", VA = "0x1846B2680")]
	private void CDGIFMMGGAL(int MFJLAMOCOBC, [In] THandle JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x46B30D0", Offset = "0x46B1CD0", VA = "0x1846B30D0")]
	private void PCMHMJJJIIL(int MFJLAMOCOBC, [In] TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x46B2D40", Offset = "0x46B1940", VA = "0x1846B2D40")]
	private THandle NDOAMDBOIAH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x46B2C30", Offset = "0x46B1830", VA = "0x1846B2C30")]
	private void KNAFOAENKLF(THandle JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x46B28F0", Offset = "0x46B14F0", VA = "0x1846B28F0")]
	private int GNEKHBNDFAG(int OGMJKGKJANG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x46B28E0", Offset = "0x46B14E0", VA = "0x1846B28E0")]
	private bool GMHIGBKADBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x893E10", Offset = "0x892A10", VA = "0x180893E10")]
	private void ECMMALAJIFD(THandle JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x46B2EF0", Offset = "0x46B1AF0", VA = "0x1846B2EF0")]
	private bool NFOGKDHOBOE([Out] THandle JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x46B3120", Offset = "0x46B1D20", VA = "0x1846B3120")]
	private bool PPAMNPCILEP([Out] THandle JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46B2A80", Offset = "0x46B1680", VA = "0x1846B2A80")]
	private void KHJFAFOJFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HLDDCBEIKDI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int EJLEFLLIODH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KBJNIHHCKPN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2E70", Offset = "0x2EC1A70", VA = "0x182EC2E70")]
	public static bool JAFDANLNLHF<T>(this T JBFBMCPGKHE, T FDOEIPBMJJM) where T : struct, HLDDCBEIKDI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2E90", Offset = "0x2EC1A90", VA = "0x182EC2E90")]
	public static bool OFMFOLKKKLF<T>(this T JBFBMCPGKHE) where T : struct, HLDDCBEIKDI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C482A0", Offset = "0x6C46EA0", VA = "0x186C482A0")]
	public static string LPMFOGCOLCA(this HLDDCBEIKDI JBFBMCPGKHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public ref struct CHKJBCCKFLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Type GBEDIJGPNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Span<byte> MFLGLFEBFIM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x435BFE0", Offset = "0x435ABE0", VA = "0x18435BFE0")]
	public CHKJBCCKFLA(Type DKDGHJNFFMM, Span<byte> HMDBAHOLLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C007B0", Offset = "0x2BFF3B0", VA = "0x182C007B0")]
	public static CHKJBCCKFLA CMADEOBHKDI<T>(T CABLCDOIFFL) where T : struct
	{
		return default(CHKJBCCKFLA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C47BA0", Offset = "0x6C467A0", VA = "0x186C47BA0")]
	public static DGHOKJMJNJK FGDKAMMLLCN([In] CHKJBCCKFLA LNOMDCGJNHN)
	{
		return default(DGHOKJMJNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C47C20", Offset = "0x6C46820", VA = "0x186C47C20")]
	public Enum MLAIEOIOCJI(Type GDHBPGJCJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C01140", Offset = "0x2BFFD40", VA = "0x182C01140")]
	public void GAOLHIMCFIN<T>([In] T CABLCDOIFFL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C47CA0", Offset = "0x6C468A0", VA = "0x186C47CA0")]
	public void PIIHNLJCBCM(Enum DIBAENLMLKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public ref struct DGHOKJMJNJK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct CFGOKBBGLDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* NNHNJIIDCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private unsafe void* FNICGPLBMLH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Type GBEDIJGPNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly ReadOnlySpan<byte> MFLGLFEBFIM;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x435BFE0", Offset = "0x435ABE0", VA = "0x18435BFE0")]
	public DGHOKJMJNJK(Type DKDGHJNFFMM, ReadOnlySpan<byte> HMDBAHOLLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A6A0", Offset = "0x2C392A0", VA = "0x182C3A6A0")]
	public static DGHOKJMJNJK CMADEOBHKDI<T>(T CABLCDOIFFL) where T : struct
	{
		return default(DGHOKJMJNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C47FE0", Offset = "0x6C46BE0", VA = "0x186C47FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C47E90", Offset = "0x6C46A90", VA = "0x186C47E90")]
	public object MJAHKGDJCEP()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FFLINFEFIEB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9F50", Offset = "0x2DE8B50", VA = "0x182DE9F50")]
	public static NativeArray<T> KLNMFBEJOCJ<T>(T CABLCDOIFFL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9EB0", Offset = "0x2DE8AB0", VA = "0x182DE9EB0")]
	public static NativeArray<T> CIIJEGEPAHO<T>(T CABLCDOIFFL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9F00", Offset = "0x2DE8B00", VA = "0x182DE9F00")]
	public static NativeArray<T> CMADEOBHKDI<T>(T CABLCDOIFFL, bool MCMJDLJKCGC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IAMHFLILLMB<Handle> where Handle : HLDDCBEIKDI, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct IOOIBBHOKEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly IAMHFLILLMB<Handle> AKNBIKOODEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int MFJLAMOCOBC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle OBJKKMMIADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x403C8C0", Offset = "0x403B4C0", VA = "0x18403C8C0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x403CBA0", Offset = "0x403B7A0", VA = "0x18403CBA0")]
		public IOOIBBHOKEF(IAMHFLILLMB<Handle> AKNBIKOODEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x403C830", Offset = "0x403B430", VA = "0x18403C830")]
		public EHLHNGKLFAC LMDPPDEOAIA([In] EHLHNGKLFAC AEBBBFCJHJO)
		{
			return default(EHLHNGKLFAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x403C650", Offset = "0x403B250", VA = "0x18403C650")]
		public bool GLLFIIAPDOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x403C770", Offset = "0x403B370", VA = "0x18403C770")]
		private Handle LJPOJGOFCCH(string LFKIGNHCOID)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct EHLHNGKLFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private IOOIBBHOKEF EFGFBJPLAFK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3A708F0", Offset = "0x3A6F4F0", VA = "0x183A708F0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3A70A60", Offset = "0x3A6F660", VA = "0x183A70A60")]
		public EHLHNGKLFAC(IAMHFLILLMB<Handle> AKNBIKOODEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3A70970", Offset = "0x3A6F570", VA = "0x183A70970")]
		public bool GLLFIIAPDOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3A709F0", Offset = "0x3A6F5F0", VA = "0x183A709F0")]
		public EHLHNGKLFAC NEGBLLIJCNA()
		{
			return default(EHLHNGKLFAC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> GGGIIIGODLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeList<int> JNPMMMHCNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int AEHHLFLGKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int BGGBLCFHMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool MOGENHODIJD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HAKLGKNKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x40080B0", Offset = "0x4006CB0", VA = "0x1840080B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EHLHNGKLFAC JHILKBNPDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4007FE0", Offset = "0x4006BE0", VA = "0x184007FE0")]
		get
		{
			return default(EHLHNGKLFAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4008770", Offset = "0x4007370", VA = "0x184008770")]
	public IAMHFLILLMB(int GLJHBGHNEOE, Allocator ICLGONBNBJO = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4007F20", Offset = "0x4006B20", VA = "0x184007F20")]
	public void ICJAGPEAKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1AA9E20", Offset = "0x1AA8A20", VA = "0x181AA9E20")]
	public static int GNEKHBNDFAG(int PPIEANOJMKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2763D20", Offset = "0x2762920", VA = "0x182763D20")]
	public static bool IMANKPDJEPE(int PPIEANOJMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4007D30", Offset = "0x4006930", VA = "0x184007D30")]
	public bool GKBGNFJJJAF(int MFJLAMOCOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4006E50", Offset = "0x4005A50", VA = "0x184006E50")]
	public bool BHHCHABKKEL(Handle JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4007A60", Offset = "0x4006660", VA = "0x184007A60")]
	public Handle DCNPKMHNCNI()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4006FC0", Offset = "0x4005BC0", VA = "0x184006FC0")]
	public void CBFHFNILLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40080F0", Offset = "0x4006CF0", VA = "0x1840080F0")]
	public void KIFEIOAAFJF(Handle JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0")]
	private bool GBCOEGBHOED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40086B0", Offset = "0x40072B0", VA = "0x1840086B0")]
	private bool PGNJBJBMJDF(int MFJLAMOCOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4008540", Offset = "0x4007140", VA = "0x184008540")]
	private void NODELKDLFBL([Out] int MFJLAMOCOBC, [Out] int OGMJKGKJANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40077B0", Offset = "0x40063B0", VA = "0x1840077B0")]
	private void CMJJJBBNBNC(Handle JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4008380", Offset = "0x4006F80", VA = "0x184008380")]
	private void MKLONMADINL(int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4008280", Offset = "0x4006E80", VA = "0x184008280")]
	private bool LHEDJFNBGLJ([Out] int MFJLAMOCOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40076F0", Offset = "0x40062F0", VA = "0x1840076F0")]
	private static Handle CDBFAGGBBPL(int MFJLAMOCOBC, int OGMJKGKJANG)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct BCHIGFGJONE<Handle, T> where Handle : HLDDCBEIKDI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IAMHFLILLMB<Handle> FAJGLJFCFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] KJHFCDIHCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Action<T> AIBNOHNHHFE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5049B20", Offset = "0x5048720", VA = "0x185049B20")]
	public BCHIGFGJONE(int GLJHBGHNEOE, [Optional] Action<T> AIBNOHNHHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5049350", Offset = "0x5047F50", VA = "0x185049350")]
	public void ICJAGPEAKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5049520", Offset = "0x5048120", VA = "0x185049520")]
	public bool JMHMMLHCCPD(Handle JBFBMCPGKHE, [Out] T PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5049070", Offset = "0x5047C70", VA = "0x185049070")]
	public Handle CMCAIIEBGOH(T PLAMADMDGIO)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5049800", Offset = "0x5048400", VA = "0x185049800")]
	public void LALIHKCOIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5048F90", Offset = "0x5047B90", VA = "0x185048F90")]
	public void CEFMELNJEMA(Handle JBFBMCPGKHE, [Out] T HGFEEBIMGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5048EC0", Offset = "0x5047AC0", VA = "0x185048EC0")]
	public void CEFMELNJEMA(Handle JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5048CA0", Offset = "0x50478A0", VA = "0x185048CA0")]
	private T BNGHKLOOFMF(int MFJLAMOCOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5049290", Offset = "0x5047E90", VA = "0x185049290")]
	private void DCOOFMGIIBA(int BGEIOEAAKFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public struct KEKINDAKDBF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private T[] BFLLAIFBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int OLBMNABBGHI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2161EC0", Offset = "0x2160AC0", VA = "0x182161EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFF00", Offset = "0x2ECEB00", VA = "0x182ECFF00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> MFLGLFEBFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x41F3B00", Offset = "0x41F2700", VA = "0x1841F3B00")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JJKFDCCDGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1065320", Offset = "0x1063F20", VA = "0x181065320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42B2450", Offset = "0x42B1050", VA = "0x1842B2450")]
	public KEKINDAKDBF(int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x42B22E0", Offset = "0x42B0EE0", VA = "0x1842B22E0")]
	public int IJKLJNFANMB(T CABLCDOIFFL, int GMEOEMGBEED, int KNHHBEFLJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x42B21E0", Offset = "0x42B0DE0", VA = "0x1842B21E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public struct DBNLNCLIBPO<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct HPEHLHKHIEP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private DBNLNCLIBPO<T> APGPCFDNGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int MFJLAMOCOBC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3F69880", Offset = "0x3F68480", VA = "0x183F69880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3F69920", Offset = "0x3F68520", VA = "0x183F69920", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3F698F0", Offset = "0x3F684F0", VA = "0x183F698F0")]
		public HPEHLHKHIEP(DBNLNCLIBPO<T> APGPCFDNGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3F697F0", Offset = "0x3F683F0", VA = "0x183F697F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3F69830", Offset = "0x3F68430", VA = "0x183F69830", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private KEKINDAKDBF<T> BFLLAIFBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int OLBMNABBGHI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5ABB8A0", Offset = "0x5ABA4A0", VA = "0x185ABB8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5ABBE20", Offset = "0x5ABAA20", VA = "0x185ABBE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HAKLGKNKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABBDF0", Offset = "0x5ABA9F0", VA = "0x185ABBDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JJKFDCCDGME
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5ABBA30", Offset = "0x5ABA630", VA = "0x185ABBA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> MFLGLFEBFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5ABB970", Offset = "0x5ABA570", VA = "0x185ABB970")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC120", Offset = "0x5ABAD20", VA = "0x185ABC120")]
	public DBNLNCLIBPO(int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB430", Offset = "0x5ABA030", VA = "0x185ABB430")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB7A0", Offset = "0x5ABA3A0", VA = "0x185ABB7A0")]
	public void CMCAIIEBGOH(T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB490", Offset = "0x5ABA090", VA = "0x185ABB490")]
	internal void BEAGGPKMPGB(int KPFLHEHNDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB6C0", Offset = "0x5ABA2C0", VA = "0x185ABB6C0")]
	public void BEAJIEAJJGC(int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBB40", Offset = "0x5ABA740", VA = "0x185ABBB40")]
	public void HKOLCKDOAHH(int DHFPPMGCOEB, int DAKCGLGCCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBD70", Offset = "0x5ABA970", VA = "0x185ABBD70")]
	public int IJKLJNFANMB(T CABLCDOIFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB930", Offset = "0x5ABA530", VA = "0x185ABB930", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBA70", Offset = "0x5ABA670", VA = "0x185ABBA70", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC070", Offset = "0x5ABAC70", VA = "0x185ABC070", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC0B0", Offset = "0x5ABACB0", VA = "0x185ABC0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB2E0", Offset = "0x5AB9EE0", VA = "0x185ABB2E0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void ALAEDCDHJGO(int CABLCDOIFFL, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBE60", Offset = "0x5ABAA60", VA = "0x185ABBE60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void MJMPGJHOMJO(int DHFPPMGCOEB, int DAKCGLGCCNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FEBLOFFJPHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int APMEPKJBNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int KNHHBEFLJAF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int FDEMFMNLEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D80", Offset = "0x5FB4980", VA = "0x185FB5D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int GCGCOMDKBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int IJIDNBHBGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C480A0", Offset = "0x6C46CA0", VA = "0x186C480A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6C48090", Offset = "0x6C46C90", VA = "0x186C48090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
	private FEBLOFFJPHN(int APMEPKJBNGD, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x216EF40", Offset = "0x216DB40", VA = "0x18216EF40")]
	public static FEBLOFFJPHN HECIPLMKOEH(int APMEPKJBNGD, int KNHHBEFLJAF)
	{
		return default(FEBLOFFJPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C48080", Offset = "0x6C46C80", VA = "0x186C48080")]
	public static FEBLOFFJPHN IHJBACMBCAF(int GMEOEMGBEED, int DAKCGLGCCNI)
	{
		return default(FEBLOFFJPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C480B0", Offset = "0x6C46CB0", VA = "0x186C480B0", Slot = "3")]
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
