using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D536D0", Offset = "0x5D524D0", VA = "0x185D536D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class IMHHKPCFHNB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D52EB0", Offset = "0x5D51CB0", VA = "0x185D52EB0")]
	public IMHHKPCFHNB(bool HCMPBDJEGKE, string KDDAFEKBGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DMBHKLIMLKM<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> LGFLBCAFDDH(CancellationToken BIBHFGFDEGJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FJLDLCOFNJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public DMBHKLIMLKM<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public LGFLBCAFDDH taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x33EC800", Offset = "0x33EB600", VA = "0x1833EC800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x33ED840", Offset = "0x33EC640", VA = "0x1833ED840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource PEGEFBHNLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? IHLOGJJFANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? GEDJJGGHDPL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4D05D60", Offset = "0x4D04B60", VA = "0x184D05D60")]
	[AsyncStateMachine(typeof(DMBHKLIMLKM<>.FJLDLCOFNJP))]
	public Task<TResult> MNMHNLOGKND(LGFLBCAFDDH IGLOPDDMDEN, [Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4D05CF0", Offset = "0x4D04AF0", VA = "0x184D05CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4D05EA0", Offset = "0x4D04CA0", VA = "0x184D05EA0")]
	public DMBHKLIMLKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HMDDMFCLIIG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> MCJBBIBLBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T GMPOHOAMMIO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35A9040", Offset = "0x35A7E40", VA = "0x1835A9040")]
	public HMDDMFCLIIG([In] T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x35A8830", Offset = "0x35A7630", VA = "0x1835A8830", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x35A8A80", Offset = "0x35A7880", VA = "0x1835A8A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x35A8BE0", Offset = "0x35A79E0", VA = "0x1835A8BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class PCDFIPFDOPN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	public PCDFIPFDOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FGKPKGHMHKE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	public FGKPKGHMHKE(string HMPDLJEELBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class PFPJDOOHBHK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	public PFPJDOOHBHK(string HMPDLJEELBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NFAGJDLCJAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24CEFF0", Offset = "0x24CDDF0", VA = "0x1824CEFF0")]
	public static GDCPOFGGKBN NGPHEEJIBMP<T>()
	{
		return default(GDCPOFGGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24CEE60", Offset = "0x24CDC60", VA = "0x1824CEE60")]
	public static GDCPOFGGKBN JJBIDIOIFCD<T>([CallerMemberName] string ONIBECKLJDD = "") where T : notnull
	{
		return default(GDCPOFGGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x24CF070", Offset = "0x24CDE70", VA = "0x1824CF070")]
	public static GDCPOFGGKBN NGPHEEJIBMP<T>(this T NGDHFFBLCOO) where T : notnull
	{
		return default(GDCPOFGGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x24CF0F0", Offset = "0x24CDEF0", VA = "0x1824CF0F0")]
	public static GDCPOFGGKBN OLEHJPOMFCP<T>(this T NGDHFFBLCOO, [CallerMemberName] string ONIBECKLJDD = "") where T : notnull
	{
		return default(GDCPOFGGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x24CEDC0", Offset = "0x24CDBC0", VA = "0x1824CEDC0")]
	public static GDCPOFGGKBN JJBIDIOIFCD<T>(this T LNKCIHFCLHG, [CallerMemberName] string ONIBECKLJDD = "") where T : notnull
	{
		return default(GDCPOFGGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D535B0", Offset = "0x5D523B0", VA = "0x185D535B0")]
	public static GDCPOFGGKBN JJBIDIOIFCD(string GACBJKOCJDC, [CallerMemberName] string ONIBECKLJDD = "")
	{
		return default(GDCPOFGGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D53630", Offset = "0x5D52430", VA = "0x185D53630")]
	public static string OLJEGFHLCFF(this object LNKCIHFCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PCDFIPFDOPN]
public delegate long LDJNIAKOEGI();
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class COCOPEDBDLG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IIJMMCGGGDG HPNPOOILIHK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IIJMMCGGGDG DANBHOOMJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F410", Offset = "0x5D4E210", VA = "0x185D4F410")]
		get
		{
			return default(IIJMMCGGGDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IKAMCFIMDDM FGKJCKCEKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F3C0", Offset = "0x5D4E1C0", VA = "0x185D4F3C0")]
		get
		{
			return default(IKAMCFIMDDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PCCHOLDBNIB KHINIODJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F230", Offset = "0x5D4E030", VA = "0x185D4F230")]
		get
		{
			return default(PCCHOLDBNIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F500", Offset = "0x5D4E300", VA = "0x185D4F500")]
	public static void KBDPFJDBAGP([In] IIJMMCGGGDG ECNLIABFCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F7F0", Offset = "0x5D4E5F0", VA = "0x185D4F7F0")]
	public static void NGLKBDEIIAD(string JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F680", Offset = "0x5D4E480", VA = "0x185D4F680")]
	public static void KHJODMCMOIC(string JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x21D0640", Offset = "0x21CF440", VA = "0x1821D0640")]
	public static void KHJODMCMOIC<T>(T OFPCPIFKKJA, BLNMJNENMEM<T> JIGBFCEILIK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F460", Offset = "0x5D4E260", VA = "0x185D4F460")]
	public static void JDEOGBAGFLO(Exception AOBBDNCEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F8C0", Offset = "0x5D4E6C0", VA = "0x185D4F8C0")]
	public static string OLJEGFHLCFF(object HBDENJGMDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F280", Offset = "0x5D4E080", VA = "0x185D4F280")]
	public static long EAKOHMCBKMP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F750", Offset = "0x5D4E550", VA = "0x185D4F750")]
	public static bool LLNLHPFMELO(bool NDIKNGPKKGH, string JIGBFCEILIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F2F0", Offset = "0x5D4E0F0", VA = "0x185D4F2F0")]
	public static double EIBOBDABODE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IIJMMCGGGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly IKAMCFIMDDM FGKJCKCEKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly PCCHOLDBNIB KHINIODJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly EOEHFILJLOA EADOGEJBBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly LDJNIAKOEGI BKIGNBDDBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly CGGBIKFIKGH EGBMKJKMNID;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly EOEHFILJLOA FJFOOCGOELO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly LDJNIAKOEGI PPMGAFFIKKF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CGGBIKFIKGH OKNEEIDLIBF;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly IIJMMCGGGDG AFMDONMGHHC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GBAJLLCPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D51940", Offset = "0x5D50740", VA = "0x185D51940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D521A0", Offset = "0x5D50FA0", VA = "0x185D521A0")]
	public IIJMMCGGGDG([In] IKAMCFIMDDM FPEBLEKOEAA, [In] PCCHOLDBNIB FNEBCNACLIA, EOEHFILJLOA MKMJOKNDAEI, LDJNIAKOEGI GCLJCFALGFB, CGGBIKFIKGH GANPPBGALCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51BA0", Offset = "0x5D509A0", VA = "0x185D51BA0")]
	private static string PEJJDPCKCHI(object HBDENJGMDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0")]
	private static long DKIAEKIGCFG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	private static string PPIHLBDPJEA(string BHPLNDJAMJB, string? NJLCOEPNOJM, bool CPCNEMBFFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D51AA0", Offset = "0x5D508A0", VA = "0x185D51AA0")]
	private static IIJMMCGGGDG FBKHCKBEBCM()
	{
		return default(IIJMMCGGGDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EPNKPOMOGEO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGEBJMLFOCD([In] T MFMJJEFODHB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void ABILBICKBMH<T>([In] T OFPCPIFKKJA);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct MJNOOEOPBBM<T> : IEquatable<MJNOOEOPBBM<T>>, EPNKPOMOGEO<MJNOOEOPBBM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T GMPOHOAMMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int CPCFHDJMLHI;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1C360D0", Offset = "0x1C34ED0", VA = "0x181C360D0")]
	public MJNOOEOPBBM([In] T GNLEHBFFNFG, int DOJILIOCHKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B37620", Offset = "0x3B36420", VA = "0x183B37620")]
	public static bool NOLBLOCHCOA([In] MJNOOEOPBBM<T> HADGDMKFEOD, [In] MJNOOEOPBBM<T> CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x35A7200", Offset = "0x35A6000", VA = "0x1835A7200", Slot = "4")]
	public bool Equals(MJNOOEOPBBM<T> MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3683040", Offset = "0x3681E40", VA = "0x183683040", Slot = "0")]
	public override bool Equals(object MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B36CA0", Offset = "0x3B35AA0", VA = "0x183B36CA0")]
	public bool LGEBJMLFOCD([In] MJNOOEOPBBM<T> MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B368A0", Offset = "0x3B356A0", VA = "0x183B368A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B37B50", Offset = "0x3B36950", VA = "0x183B37B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B36380", Offset = "0x3B35180", VA = "0x183B36380")]
	public void EIMGPDKFHGM([Out] T GNLEHBFFNFG, [Out] int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3B36D30", Offset = "0x3B35B30", VA = "0x183B36D30")]
	public (T, int) LMHPNIOHPMJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B36C50", Offset = "0x3B35A50", VA = "0x183B36C50", Slot = "5")]
	private bool INFMMPHLOIG([In] MJNOOEOPBBM<T> MFMJJEFODHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GOJKNNIDPNK
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2364270", Offset = "0x2363070", VA = "0x182364270")]
	public static MJNOOEOPBBM<T> NPAOPBPEFCO<T>([In] T GNLEHBFFNFG, int DOJILIOCHKM) where T : notnull
	{
		return default(MJNOOEOPBBM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HIJNJDOOJHL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x237B5B0", Offset = "0x237A3B0", VA = "0x18237B5B0")]
	public static bool LGEBJMLFOCD<T, U>([In] T LNKCIHFCLHG, [In] U HBDENJGMDDF) where T : notnull, EPNKPOMOGEO<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate TResult AMCHOOADKHA<T, out TResult>([In] T OFPCPIFKKJA);
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate TResult FBJEOEMOPOJ<T1, T2, out TResult>([In] T1 DDKOJHOEBMN, [In] T2 LIJDJCIOLFI);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NNLJCNMIGAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan OOLOIKBANOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Action? DFNBMBJBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPHPMPIIOOM();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHOCLJMCKFG();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMOIDNFCHPO();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct IKAMCFIMDDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly NFBCEGOKHIM BACKDNICFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly NMNIKBDOEOO EBAOJLKIJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NFBCEGOKHIM NADILIPGACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly NMNIKBDOEOO MNAJAABMCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly NFBCEGOKHIM IGKOBHBOBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly NMNIKBDOEOO ABODAEOCAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly NDCAJPAEIJJ KLKIJPNFIHH;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly NFBCEGOKHIM MIPHCGIGHEO;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly NMNIKBDOEOO KMEAGMHCEPG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly NFBCEGOKHIM MKDHLDBHNBD;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly NMNIKBDOEOO HMDBIDDLGAG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly NFBCEGOKHIM BNLDOJFHBCD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly NMNIKBDOEOO JDCNDPGIFPC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly NDCAJPAEIJJ AFOKNAGCFAF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IKAMCFIMDDM AFMDONMGHHC;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly NFBCEGOKHIM EKHFCIEMDEE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GBAJLLCPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5D52240", Offset = "0x5D51040", VA = "0x185D52240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x869450", Offset = "0x868250", VA = "0x180869450")]
	public IKAMCFIMDDM(NFBCEGOKHIM HHCGPDILPDM, NMNIKBDOEOO ABOAFEOAGCI, NFBCEGOKHIM OBFJDCEKNEC, NMNIKBDOEOO GAJAHKOANHD, NFBCEGOKHIM LCMMHPFJOAE, NMNIKBDOEOO IMKNCNNJMOB, NDCAJPAEIJJ DGGBBKOPCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	private static bool DLIOBBGNKFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void LEINKNJEJLH(string JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	private static bool KLCNKEMPIBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void LAEGAONHJED(string JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	private static bool FPGFPHEBKGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void IHGMKPPDDCF(string JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void OAJCKJJAPDE(Exception AOBBDNCEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D52440", Offset = "0x5D51240", VA = "0x185D52440")]
	private static IKAMCFIMDDM FBKHCKBEBCM()
	{
		return default(IKAMCFIMDDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0")]
	private static bool IBDDGCLCOOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D527A0", Offset = "0x5D515A0", VA = "0x185D527A0")]
	public void NGLKBDEIIAD(object JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D52660", Offset = "0x5D51460", VA = "0x185D52660")]
	public void KHJODMCMOIC(object JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEE80", Offset = "0x1FFDC80", VA = "0x181FFEE80")]
	public void JDEOGBAGFLO(Exception AOBBDNCEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D52580", Offset = "0x5D51380", VA = "0x185D52580")]
	public void KHJODMCMOIC(OFNMACJFGFI JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x239E850", Offset = "0x239D650", VA = "0x18239E850")]
	public void KHJODMCMOIC<T>(T OFPCPIFKKJA, BLNMJNENMEM<T> JIGBFCEILIK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x239E910", Offset = "0x239D710", VA = "0x18239E910")]
	public void NGLKBDEIIAD<T>([In] T OFPCPIFKKJA, HHECDILCFFP<T> JIGBFCEILIK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D526D0", Offset = "0x5D514D0", VA = "0x185D526D0")]
	public bool LLNLHPFMELO(bool NDIKNGPKKGH, string JIGBFCEILIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct GDCPOFGGKBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string GMPOHOAMMIO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C0", Offset = "0x7F07C0", VA = "0x1807F19C0")]
	public GDCPOFGGKBN(string GNLEHBFFNFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public static string FMKGPFEKDFI([In] GDCPOFGGKBN LNKCIHFCLHG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12A3D70", Offset = "0x12A2B70", VA = "0x1812A3D70")]
	public static GDCPOFGGKBN FMKGPFEKDFI(string MFMJJEFODHB)
	{
		return default(GDCPOFGGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D50FE0", Offset = "0x5D4FDE0", VA = "0x185D50FE0")]
	public string INIPBBFGCNK(string CCHCCCAOEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D51030", Offset = "0x5D4FE30", VA = "0x185D51030")]
	public string JKBBCPKIHHF(object IAIIOOGKNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct LIGKMPLCELA : IEquatable<LIGKMPLCELA>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "4")]
	public bool Equals(LIGKMPLCELA MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D52F80", Offset = "0x5D51D80", VA = "0x185D52F80", Slot = "0")]
	public override bool Equals(object MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D52FD0", Offset = "0x5D51DD0", VA = "0x185D52FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D52FE0", Offset = "0x5D51DE0", VA = "0x185D52FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CALCKJNFMHO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct HLJMMMGEILL<T> : IEquatable<HLJMMMGEILL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T GMPOHOAMMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool NPOOLFFHAPE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PILOGDFMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x35A7CE0", Offset = "0x35A6AE0", VA = "0x1835A7CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x35A8460", Offset = "0x35A7260", VA = "0x1835A8460")]
	public HLJMMMGEILL([In] T GNLEHBFFNFG, bool ECDICLMGIII)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x35A7CF0", Offset = "0x35A6AF0", VA = "0x1835A7CF0")]
	public static bool NOLBLOCHCOA([In] HLJMMMGEILL<T> HADGDMKFEOD, [In] HLJMMMGEILL<T> CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x35A7200", Offset = "0x35A6000", VA = "0x1835A7200", Slot = "4")]
	public bool Equals(HLJMMMGEILL<T> MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x35A76E0", Offset = "0x35A64E0", VA = "0x1835A76E0", Slot = "0")]
	public override bool Equals(object MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x35A7C40", Offset = "0x35A6A40", VA = "0x1835A7C40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x35A8300", Offset = "0x35A7100", VA = "0x1835A8300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JMJEDNMAIJN
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x23CC950", Offset = "0x23CB750", VA = "0x1823CC950")]
	public static HLJMMMGEILL<T> BACILNDEFHO<T>([In] T GNLEHBFFNFG) where T : notnull
	{
		return default(HLJMMMGEILL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23CCAC0", Offset = "0x23CB8C0", VA = "0x1823CCAC0")]
	public static HLJMMMGEILL<T?> CKDIPBEOHHE<T>()
	{
		return default(HLJMMMGEILL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23CCA50", Offset = "0x23CB850", VA = "0x1823CCA50")]
	public static bool BBLNOPGFLFE<T>([In] this HLJMMMGEILL<T> DBDNCKJJFJD, [Out][NotNullWhen(true)] T GNLEHBFFNFG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PCCHOLDBNIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly NIIIABMEHNH HMEOKMNMAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly GCEFAIPPOFD DLGPIPEEJGM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly NIIIABMEHNH NGNKLMBAIDF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly GCEFAIPPOFD KMKFEGEFHJI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly PCCHOLDBNIB AFMDONMGHHC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GBAJLLCPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D53750", Offset = "0x5D52550", VA = "0x185D53750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EC0", Offset = "0x7F0CC0", VA = "0x1807F1EC0")]
	public PCCHOLDBNIB(NIIIABMEHNH NCPIADHLIEA, GCEFAIPPOFD NCMHOCFHEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void NBINKJIAJIA(string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void IGKJJHKBKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D53810", Offset = "0x5D52610", VA = "0x185D53810")]
	private static PCCHOLDBNIB FBKHCKBEBCM()
	{
		return default(PCCHOLDBNIB);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class LLIONLEPGOI
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate bool BJHGNKELJDG<in TInput, TResult>(TInput ENGEPLNNBDC, [Out] TResult EKOLPKLNMBD);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ACKMBGHPNOK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ACKMBGHPNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x345A0E0", Offset = "0x3458EE0", VA = "0x18345A0E0")]
		internal void GCFFAJMEPKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LHGCJJOEFIO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LHGCJJOEFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x33D00C0", Offset = "0x33CEEC0", VA = "0x1833D00C0")]
		internal void FAHHJIKABDP(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct AKEPPKKLPLJ<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BJHGNKELJDG<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3517270", Offset = "0x3516070", VA = "0x183517270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3517960", Offset = "0x3516760", VA = "0x183517960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NEHLHCLLAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D53340", Offset = "0x5D52140", VA = "0x185D53340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5D53540", Offset = "0x5D52340", VA = "0x185D53540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D53010", Offset = "0x5D51E10", VA = "0x185D53010")]
	public static Task<TaskStatus> DBIINIFIAPF(this Task LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x241AF40", Offset = "0x2419D40", VA = "0x18241AF40")]
	public static Task<T> IIMDCFIIKFA<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D53100", Offset = "0x5D51F00", VA = "0x185D53100")]
	public static Task EMJLLDJBPBA(this Task CKLPGPGBFPF, CancellationToken PFKLELGAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x241A2F0", Offset = "0x24190F0", VA = "0x18241A2F0")]
	public static Task<TResult> EMJLLDJBPBA<TResult>(this Task<TResult> CKLPGPGBFPF, CancellationToken PFKLELGAJPH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x241AAE0", Offset = "0x24198E0", VA = "0x18241AAE0")]
	public static TaskCompletionSource<TResult> EMJLLDJBPBA<TResult>(this TaskCompletionSource<TResult> LKHHMKEMOPL, CancellationToken PFKLELGAJPH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x241B090", Offset = "0x2419E90", VA = "0x18241B090")]
	[AsyncStateMachine(typeof(AKEPPKKLPLJ<, >))]
	public static Task<List<TResult>> JOCEPMHKHFE<TResult, TInput>(this Task<List<TInput>> CKLPGPGBFPF, BJHGNKELJDG<TInput, TResult> GLIHPOAHHPJ) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D53010", Offset = "0x5D51E10", VA = "0x185D53010")]
	[AsyncStateMachine(typeof(NEHLHCLLAKL))]
	[CompilerGenerated]
	internal static Task<TaskStatus> JDMBHNGCLFN(Task CLMDIAOGACF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HAFCNIIAGOM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	public HAFCNIIAGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ILHLKEFEKGO : GMINOKAOFAH
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly GMINOKAOFAH GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DateTime LHFHGJNAACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D52DF0", Offset = "0x5D51BF0", VA = "0x185D52DF0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ILHLKEFEKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GMINOKAOFAH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime LHFHGJNAACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class IBOODFIEIKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long LONDCIDGHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D51110", Offset = "0x5D4FF10", VA = "0x185D51110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static long KPKOGNGGHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D513B0", Offset = "0x5D501B0", VA = "0x185D513B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double FKLDCJCCAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D51540", Offset = "0x5D50340", VA = "0x185D51540")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double FMFDAKGBCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D51490", Offset = "0x5D50290", VA = "0x185D51490")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double EMMIBDGIMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D51230", Offset = "0x5D50030", VA = "0x185D51230")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double MJCNIPDANEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5D51590", Offset = "0x5D50390", VA = "0x185D51590")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D51400", Offset = "0x5D50200", VA = "0x185D51400")]
	public static double KPNLKOEPPHK(long FKDONFHHABD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D515E0", Offset = "0x5D503E0", VA = "0x185D515E0")]
	public static double PENLLKMJPDA(long FKDONFHHABD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51290", Offset = "0x5D50090", VA = "0x185D51290")]
	public static double HAOOFOLNHNF(double HFCLLMPCHJO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D51320", Offset = "0x5D50120", VA = "0x185D51320")]
	public static long HBKLMLFEONN(long MILPBPEIAGI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5D51280", Offset = "0x5D50080", VA = "0x185D51280")]
	public static long FLFFLBPAJLM(long JDJHLAJAKIE, long BJCKGBEOOLN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D51160", Offset = "0x5D4FF60", VA = "0x185D51160")]
	public static double DNIPHNBAOEI(long JDJHLAJAKIE, long BJCKGBEOOLN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D514E0", Offset = "0x5D502E0", VA = "0x185D514E0")]
	public static double NJIGBENIFEH(long JDJHLAJAKIE, long BJCKGBEOOLN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class COIEELOPKAC : NNLJCNMIGAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly TimeSpan DCHOJCFACDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly System.Timers.Timer JICPEFHJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private TimeSpan FFFIPJLIDCP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan OOLOIKBANOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FA90", Offset = "0x5D4E890", VA = "0x185D4FA90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Action? DFNBMBJBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FE30", Offset = "0x5D4EC30", VA = "0x185D4FE30")]
	[Preserve]
	public COIEELOPKAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FEA0", Offset = "0x5D4ECA0", VA = "0x185D4FEA0")]
	public COIEELOPKAC(TimeSpan FFFIPJLIDCP, [Optional] Action? KOOKFBGEJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FC90", Offset = "0x5D4EA90", VA = "0x185D4FC90", Slot = "7")]
	public void JPHPMPIIOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FBF0", Offset = "0x5D4E9F0", VA = "0x185D4FBF0", Slot = "8")]
	public void HHOCLJMCKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FC60", Offset = "0x5D4EA60", VA = "0x185D4FC60", Slot = "9")]
	public void HMOIDNFCHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xADB470", Offset = "0xADA270", VA = "0x180ADB470")]
	private void PHPMMEFENHA(object NGDHFFBLCOO, ElapsedEventArgs OMLAGMHPCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FD20", Offset = "0x5D4EB20", VA = "0x185D4FD20")]
	private static void KPPLLFJFPOF(TimeSpan AFHDIMNHPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F9F0", Offset = "0x5D4E7F0", VA = "0x185D4F9F0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CALCKJNFMHO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string OHJMGNDHNOI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
	public CALCKJNFMHO(string IDLENODONKC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct DGKAIMGPBJB : IEquatable<DGKAIMGPBJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint KIKNOLBODLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int CNPIGPJJBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float GJPLFFLDJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort KAKGMKLCPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort MFHNHNPNDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short IBGNEDNHLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short AEDBNAADGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char EAFKODFDOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char BGIIPOBNBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte PGBKCGIOMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte FCCNAABKIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte EEBPLOEHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte EKMEJCEDKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool GANLOPHOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool FFBBFKAKABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool LHKCBMAPCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool MGAAJEPDFKC;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBBA660", Offset = "0xBB9460", VA = "0x180BBA660")]
	public static DGKAIMGPBJB FJJMEHLIFHM(uint MHCPCHCMICB)
	{
		return default(DGKAIMGPBJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xBBA660", Offset = "0xBB9460", VA = "0x180BBA660")]
	public static DGKAIMGPBJB KJMMOOJHHPP(int GEPLPIHNNGM)
	{
		return default(DGKAIMGPBJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D50190", Offset = "0x5D4EF90", VA = "0x185D50190")]
	public static DGKAIMGPBJB LKELKFENNAA(float IKJLMBPHFHL)
	{
		return default(DGKAIMGPBJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D500F0", Offset = "0x5D4EEF0", VA = "0x185D500F0")]
	public static DGKAIMGPBJB DBPKIECOGOK(byte GPIAPCANJCD, byte APDMJNLJACC, byte ENAJALPOEOB, byte OCJINJMALNO)
	{
		return default(DGKAIMGPBJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D500F0", Offset = "0x5D4EEF0", VA = "0x185D500F0")]
	public static DGKAIMGPBJB HFGNMIJCGKD(bool LPBBJKFMPAB, bool FMNAFFAAFMM, bool OCOJOAJBCGJ, bool JMPEKCAILBK)
	{
		return default(DGKAIMGPBJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x161D6E0", Offset = "0x161C4E0", VA = "0x18161D6E0")]
	public static bool NOLBLOCHCOA(DGKAIMGPBJB KNEDKAAPLCI, DGKAIMGPBJB FPBOJHIIPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x161D6C0", Offset = "0x161C4C0", VA = "0x18161D6C0", Slot = "4")]
	public bool Equals(DGKAIMGPBJB MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D50110", Offset = "0x5D4EF10", VA = "0x185D50110", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B40", Offset = "0x7F0940", VA = "0x1807F1B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D501A0", Offset = "0x5D4EFA0", VA = "0x185D501A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct FHANDCNDHKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public ulong NKIBPLEOAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public long DFNLLFPFEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public double BLENMCAJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint JDIEJNMKDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint OKPFACIIKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int FNPKGDDONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int FMKJKMBEGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float IKDFMDBDDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float KJBNHELGLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ushort KAKGMKLCPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public ushort MFHNHNPNDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ushort LNILKPNJBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ushort OGLCILNDBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public short IBGNEDNHLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public short AEDBNAADGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public short DEBKHAKLPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public short JNHEMJGCIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public char EAFKODFDOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public char BGIIPOBNBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public char OMODIDCENNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public char LBOEHOKGDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public byte PGBKCGIOMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public byte FCCNAABKIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte EEBPLOEHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public byte EKMEJCEDKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte LJPDJBOCKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public byte OKKJIMOLAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte LJKCNJFANEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte MHEOGFBJHCH;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D50F90", Offset = "0x5D4FD90", VA = "0x185D50F90")]
	public static FHANDCNDHKA NPAOPBPEFCO(byte GPIAPCANJCD, byte APDMJNLJACC, byte ENAJALPOEOB, byte OCJINJMALNO, byte BIAAEPCHMCN, byte FCHCAJHACPE, byte HJLKBJLJNAG, byte EHKJOJGMIMP)
	{
		return default(FHANDCNDHKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class COGCBBBOBBP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x21D06F0", Offset = "0x21CF4F0", VA = "0x1821D06F0")]
	public static IEnumerable<T> DPLHBJBHKHF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static T[] NIIJPMIIIIF<T>(params T[] NGNLLBPEOFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static IEnumerable<T> FIFFNJKKAHL<T>(params T[] NGNLLBPEOFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x216A7F0", Offset = "0x21695F0", VA = "0x18216A7F0")]
	public static HashSet<T> CMBEJENPACH<T>(params T[] NGNLLBPEOFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x21D0710", Offset = "0x21CF510", VA = "0x1821D0710")]
	public static KeyValuePair<TKey, TValue> FPJMJFNBGKD<TKey, TValue>([In] TKey JLDFGFPAIIN, [In] TValue GNLEHBFFNFG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x216A7F0", Offset = "0x21695F0", VA = "0x18216A7F0")]
	public static List<T> KIPHMEEIPLP<T>(IEnumerable<T> LJMPIGIKCCJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ICBJLAAAJKK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly string PFHLLDDIHFF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
	public ICBJLAAAJKK(string IMLAGLECAAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LBHNNOAJEOC
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class OPFBCMIAFOA<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ISet<T> GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int CBILAPKHPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C6F0", Offset = "0x3D3B4F0", VA = "0x183D3C6F0", Slot = "4")]
		public bool Add(T PEGAJFMFKFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
		public void IntersectWith(IEnumerable<T> MFMJJEFODHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C920", Offset = "0x3D3B720", VA = "0x183D3C920", Slot = "5")]
		public void UnionWith(IEnumerable<T> MFMJJEFODHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C830", Offset = "0x3D3B630", VA = "0x183D3C830", Slot = "9")]
		void ICollection<T>.Add(T PEGAJFMFKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "11")]
		public bool Contains(T PEGAJFMFKFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "12")]
		public void CopyTo(T[] FNIMPMJDPGM, int KOPIDODGMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
		public bool Remove(T PEGAJFMFKFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C750", Offset = "0x3D3B550", VA = "0x183D3C750", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x33B9B80", Offset = "0x33B8980", VA = "0x1833B9B80", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OPFBCMIAFOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA07DF0", VA = "0x180A08FF0")]
	public static ISet<T> CIGHMHBIGMA<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[PCDFIPFDOPN]
public delegate void NIIIABMEHNH(string ONIBECKLJDD);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PCDFIPFDOPN]
public delegate void GCEFAIPPOFD();
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object HHECDILCFFP<T>([In] T HGIPKCLMBHH);
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate object BLNMJNENMEM<T>(T HGIPKCLMBHH);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PCDFIPFDOPN]
public delegate string CGGBIKFIKGH(string BHPLNDJAMJB, string? NJLCOEPNOJM, bool CPCNEMBFFEM);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[PCDFIPFDOPN]
public delegate void NMNIKBDOEOO(string JIGBFCEILIK);
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PCDFIPFDOPN]
public delegate void NDCAJPAEIJJ(Exception AOBBDNCEPBJ);
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate object OFNMACJFGFI();
[Cpp2IlInjected.Token(Token = "0x200003C")]
[PCDFIPFDOPN]
public delegate bool NFBCEGOKHIM();
[Cpp2IlInjected.Token(Token = "0x200003D")]
[PCDFIPFDOPN]
public delegate string EOEHFILJLOA(object HBDENJGMDDF);
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
