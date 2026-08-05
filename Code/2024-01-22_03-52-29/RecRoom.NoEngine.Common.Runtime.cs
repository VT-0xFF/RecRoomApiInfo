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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60961D0", Offset = "0x60955D0", VA = "0x1860961D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GODBLIPABLF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6093960", Offset = "0x6092D60", VA = "0x186093960")]
	public GODBLIPABLF(bool HLEJLNJPDNA, string AJIPDAMFENH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MGPLGALCOLG<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> ENOPDEHPIPN(CancellationToken HHHPDCGPCML);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IHFLLOCDPDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public MGPLGALCOLG<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public ENOPDEHPIPN taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x38E01C0", Offset = "0x38DF5C0", VA = "0x1838E01C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x38E1170", Offset = "0x38E0570", VA = "0x1838E1170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource BPEHJEDJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? FNAOKPJHIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? IMOONOEKFMJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E048F0", Offset = "0x3E03CF0", VA = "0x183E048F0")]
	[AsyncStateMachine(typeof(MGPLGALCOLG<>.IHFLLOCDPDO))]
	public Task<TResult> LNPPIEDFIFM(ENOPDEHPIPN HFBAIJMIOAP, [Optional] CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E04880", Offset = "0x3E03C80", VA = "0x183E04880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E04A30", Offset = "0x3E03E30", VA = "0x183E04A30")]
	public MGPLGALCOLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LAPPJJKMODB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> ONOJNEKGMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T BFBAIKCHJBC;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37A21C0", Offset = "0x37A15C0", VA = "0x1837A21C0")]
	public LAPPJJKMODB([In] T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE400", Offset = "0x3BED800", VA = "0x183BEE400", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE6B0", Offset = "0x3BEDAB0", VA = "0x183BEE6B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE970", Offset = "0x3BEDD70", VA = "0x183BEE970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ELANPOIOMME
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60921E0", Offset = "0x60915E0", VA = "0x1860921E0")]
	public static void DHNKGADEIAB(this CancellationTokenSource BPEHJEDJCHB, bool FHLGLDFNEKP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class CEEFMBCJICM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
	public CEEFMBCJICM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class LHMPCJOJBFM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
	public LHMPCJOJBFM(string LAHEEFNBNMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GIIHCGBBGOK
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x25F7D10", Offset = "0x25F7110", VA = "0x1825F7D10")]
	public static MEMAGMMPIIM IPGHBJBMNAD<T>()
	{
		return default(MEMAGMMPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x25F7F60", Offset = "0x25F7360", VA = "0x1825F7F60")]
	public static MEMAGMMPIIM KHIAPCGFFLK<T>([CallerMemberName] string ADLKEGECLOG = "") where T : notnull
	{
		return default(MEMAGMMPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x25F7C90", Offset = "0x25F7090", VA = "0x1825F7C90")]
	public static MEMAGMMPIIM IPGHBJBMNAD<T>(this T IBGLEOLMNIG) where T : notnull
	{
		return default(MEMAGMMPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x25F7B40", Offset = "0x25F6F40", VA = "0x1825F7B40")]
	public static MEMAGMMPIIM BNILDPNHMIN<T>(this T IBGLEOLMNIG, [CallerMemberName] string ADLKEGECLOG = "") where T : notnull
	{
		return default(MEMAGMMPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x25F7EC0", Offset = "0x25F72C0", VA = "0x1825F7EC0")]
	public static MEMAGMMPIIM KHIAPCGFFLK<T>(this T LHCHBOKBAPK, [CallerMemberName] string ADLKEGECLOG = "") where T : notnull
	{
		return default(MEMAGMMPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60937D0", Offset = "0x6092BD0", VA = "0x1860937D0")]
	public static MEMAGMMPIIM KHIAPCGFFLK(string MOHDIMKNDGC, [CallerMemberName] string ADLKEGECLOG = "")
	{
		return default(MEMAGMMPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6093850", Offset = "0x6092C50", VA = "0x186093850")]
	public static string KIMPOGAGEMB(this object LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool CNIEJHMFHIB();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[CEEFMBCJICM]
public delegate long GEAMFNNBDOL();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OGEDIDBCGKF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static AMHAFDKPDPI PPIEIOPGMBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AMHAFDKPDPI HJOLPJHJHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6096B10", Offset = "0x6095F10", VA = "0x186096B10")]
		get
		{
			return default(AMHAFDKPDPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FGBHEDLOALH ACKBJOABCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6096970", Offset = "0x6095D70", VA = "0x186096970")]
		get
		{
			return default(FGBHEDLOALH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OOGEGPGEIEB BDLLGEBMODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6096600", Offset = "0x6095A00", VA = "0x186096600")]
		get
		{
			return default(OOGEGPGEIEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool PDEDHMJCJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6096AA0", Offset = "0x6095EA0", VA = "0x186096AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6096650", Offset = "0x6095A50", VA = "0x186096650")]
	public static void EINLEJOMLEO([In] AMHAFDKPDPI PGFOEFLAINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6096530", Offset = "0x6095930", VA = "0x186096530")]
	public static void AOEJNDMBIGP(string AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6096BC0", Offset = "0x6095FC0", VA = "0x186096BC0")]
	public static void NMHDBGAJMFP(string AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2787C50", Offset = "0x2787050", VA = "0x182787C50")]
	public static void NMHDBGAJMFP<T>(T NGEFMGOMMMN, ICAOLCLGHPN<T> AGOKDCAFCLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6096C90", Offset = "0x6096090", VA = "0x186096C90")]
	public static void OOKGAPGGCNG(Exception EAIHDKDABHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6096B60", Offset = "0x6095F60", VA = "0x186096B60")]
	public static void NHLJGLOHPJK(string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60969C0", Offset = "0x6095DC0", VA = "0x1860969C0")]
	public static void IMEENDKHIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6096A20", Offset = "0x6095E20", VA = "0x186096A20")]
	public static string KIMPOGAGEMB(object DFFBALIDCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60964C0", Offset = "0x60958C0", VA = "0x1860964C0")]
	public static long ANGBALIGOKH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60968D0", Offset = "0x6095CD0", VA = "0x1860968D0")]
	public static bool FDFPJNOPEFC(bool NDMNCGHKEPJ, string AGOKDCAFCLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6096800", Offset = "0x6095C00", VA = "0x186096800")]
	public static double EKLGEBNNGAE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct AMHAFDKPDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly FGBHEDLOALH ACKBJOABCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly OOGEGPGEIEB BDLLGEBMODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly DMILBHNIGDI INHAAOHCKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly GEAMFNNBDOL JNALPINMAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly OKDGENLBCMC JMMHLIFGNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly CNIEJHMFHIB HMHEMIPBDNH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly DMILBHNIGDI BOJNILIANON;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GEAMFNNBDOL PIJLGMNOOEK;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OKDGENLBCMC JBMJCAFFEOB;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly CNIEJHMFHIB NBDLDFIKLIC;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly AMHAFDKPDPI HNPOJGAPKPM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DCKNEPLMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60905F0", Offset = "0x608F9F0", VA = "0x1860905F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6090E80", Offset = "0x6090280", VA = "0x186090E80")]
	public AMHAFDKPDPI([In] FGBHEDLOALH EEBINNEACBJ, [In] OOGEGPGEIEB IIHCFCLCLPA, DMILBHNIGDI OBDLGCHKKMK, GEAMFNNBDOL PGDDMGIBLBJ, OKDGENLBCMC CALCFHNFFIK, CNIEJHMFHIB KAHKHJPEGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60904A0", Offset = "0x608F8A0", VA = "0x1860904A0")]
	private static string DKBHEMEOBME(object DFFBALIDCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450")]
	private static long IFBDCFLHIGD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	private static string PKDCMOMNFJH(string LNCBDEONNFN, string? BCODKKBIHPM, bool IJMMHAIIJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
	private static bool BDBLGOEFKHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60904E0", Offset = "0x608F8E0", VA = "0x1860904E0")]
	private static AMHAFDKPDPI MKOHBFEPLFM()
	{
		return default(AMHAFDKPDPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IPHFNAPHIML
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEHMONCHGBD OLICJBAOPML();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AEHMONCHGBD : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AFAAFCBBNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JONBGDAHKMC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BGJBDKDCKID<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCJPNHFMMHK([In] T JLCJEDAFKJL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void BKAEMPLNOAG<T>([In] T NGEFMGOMMMN);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IIILBJALCGN<T> : IEquatable<IIILBJALCGN<T>>, BGJBDKDCKID<IIILBJALCGN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T BFBAIKCHJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int GOBEDCIKOGJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D25140", Offset = "0x1D24540", VA = "0x181D25140")]
	public IIILBJALCGN([In] T PAHKKNONPEO, int FGBBDGJMFEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38E2650", Offset = "0x38E1A50", VA = "0x1838E2650")]
	public static bool AODPLFIFGHC([In] IIILBJALCGN<T> NAJACJFDALM, [In] IIILBJALCGN<T> AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38E2E10", Offset = "0x38E2210", VA = "0x1838E2E10", Slot = "4")]
	public bool Equals(IIILBJALCGN<T> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x32E3B30", Offset = "0x32E2F30", VA = "0x1832E3B30", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38E29A0", Offset = "0x38E1DA0", VA = "0x1838E29A0")]
	public bool CCJPNHFMMHK([In] IIILBJALCGN<T> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38E31F0", Offset = "0x38E25F0", VA = "0x1838E31F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x38E4070", Offset = "0x38E3470", VA = "0x1838E4070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x38E38C0", Offset = "0x38E2CC0", VA = "0x1838E38C0")]
	public void OEGHLAHCHIH([Out] T PAHKKNONPEO, [Out] int FGBBDGJMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x38E2A90", Offset = "0x38E1E90", VA = "0x1838E2A90")]
	public (T, int) CDKFCOKAEAF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38E2F10", Offset = "0x38E2310", VA = "0x1838E2F10", Slot = "5")]
	private bool FJBJALJIILI([In] IIILBJALCGN<T> JLCJEDAFKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KFFOJOGKHEO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x269FAB0", Offset = "0x269EEB0", VA = "0x18269FAB0")]
	public static IIILBJALCGN<T> PIJMMFMEPKL<T>([In] T PAHKKNONPEO, int FGBBDGJMFEH) where T : notnull
	{
		return default(IIILBJALCGN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class AOLHDPHOLHN
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2C66F30", Offset = "0x2C66330", VA = "0x182C66F30")]
	public static bool CCJPNHFMMHK<T, U>([In] T LHCHBOKBAPK, [In] U DFFBALIDCLL) where T : notnull, BGJBDKDCKID<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult PFAALOLFPCP<T, out TResult>([In] T NGEFMGOMMMN);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult JJHNJCBEPID<T1, T2, out TResult>([In] T1 JFMEJMMHIFB, [In] T2 MOEDAACEKNB);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AAKLKHGJFJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan BBOEEDLGAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? PKNINDEJMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OFAAPPLMKAM();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JAPKMJLPFMC();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDMPOIPPKCE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FGBHEDLOALH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IJAPHAPHMKK BFJECACOIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly MDGGLEJDLFB MNNKMIMPNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IJAPHAPHMKK PNPJANHOIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly MDGGLEJDLFB GCECNPCHLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IJAPHAPHMKK HHFEDJNNBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly MDGGLEJDLFB OHOHIGPLIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly KJLGGJGKHNM IGBIFEGMCMN;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly IJAPHAPHMKK NKCOLAFKGPC;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly MDGGLEJDLFB CLBJAFKBLBN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IJAPHAPHMKK DIOCAHCDFFK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly MDGGLEJDLFB DNJJGNJFPMN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IJAPHAPHMKK HIGHFJDPAMB;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MDGGLEJDLFB FHEMLMDNBAF;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KJLGGJGKHNM PDLLFIIAOBD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly FGBHEDLOALH HNPOJGAPKPM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IJAPHAPHMKK OLLJKPABOFH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DCKNEPLMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6092FF0", Offset = "0x60923F0", VA = "0x186092FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x92FA90", Offset = "0x92EE90", VA = "0x18092FA90")]
	public FGBHEDLOALH(IJAPHAPHMKK LKAIKFLHCAL, MDGGLEJDLFB JHKDAJOKHLK, IJAPHAPHMKK NAAECCEKIEB, MDGGLEJDLFB GEKFBAFMOEC, IJAPHAPHMKK CFPBFMHPBME, MDGGLEJDLFB CPFBIEGEOMH, KJLGGJGKHNM MBDLDJLNHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
	private static bool EGPENAIMHBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	private static void HDFIONKIODD(string AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
	private static bool EIBOFJLEJAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	private static void OPLJDPGJBJG(string AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
	private static bool FPPLFPBLADK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	private static void GJBEMFBBBKO(string AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	private static void LBABHPPPBFD(Exception EAIHDKDABHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6092D60", Offset = "0x6092160", VA = "0x186092D60")]
	private static FGBHEDLOALH MKOHBFEPLFM()
	{
		return default(FGBHEDLOALH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880")]
	private static bool NACMIKLFHCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6092C20", Offset = "0x6092020", VA = "0x186092C20")]
	public void AOEJNDMBIGP(object AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6092EA0", Offset = "0x60922A0", VA = "0x186092EA0")]
	public void NMHDBGAJMFP(object AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21A18F0", Offset = "0x21A0CF0", VA = "0x1821A18F0")]
	public void OOKGAPGGCNG(Exception EAIHDKDABHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6092F10", Offset = "0x6092310", VA = "0x186092F10")]
	public void NMHDBGAJMFP(NHJIBIKACGO AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x25DAFB0", Offset = "0x25DA3B0", VA = "0x1825DAFB0")]
	public void NMHDBGAJMFP<T>(T NGEFMGOMMMN, ICAOLCLGHPN<T> AGOKDCAFCLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x25DAE30", Offset = "0x25DA230", VA = "0x1825DAE30")]
	public void AOEJNDMBIGP<T>([In] T NGEFMGOMMMN, AECCGEPGPLB<T> AGOKDCAFCLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6092C90", Offset = "0x6092090", VA = "0x186092C90")]
	public bool FDFPJNOPEFC(bool NDMNCGHKEPJ, string AGOKDCAFCLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct MEMAGMMPIIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string BFBAIKCHJBC;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	public MEMAGMMPIIM(string PAHKKNONPEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
	public static string OOICJOKLJBF([In] MEMAGMMPIIM LHCHBOKBAPK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x13FD7A0", Offset = "0x13FCBA0", VA = "0x1813FD7A0")]
	public static MEMAGMMPIIM OOICJOKLJBF(string JLCJEDAFKJL)
	{
		return default(MEMAGMMPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6095E30", Offset = "0x6095230", VA = "0x186095E30")]
	public string MOPAEKCHIGL(string JPFCCEKBKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6095D50", Offset = "0x6095150", VA = "0x186095D50")]
	public string LEEKIAABOPB(object FEOFELOLMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct JDDDAABNCFI : IEquatable<JDDDAABNCFI>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "4")]
	public bool Equals(JDDDAABNCFI JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60943F0", Offset = "0x60937F0", VA = "0x1860943F0", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6094440", Offset = "0x6093840", VA = "0x186094440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6094450", Offset = "0x6093850", VA = "0x186094450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BHFIKJBBKEL("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct NMGFKHEHGDM<T> : IEquatable<NMGFKHEHGDM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T BFBAIKCHJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool LJIHDJFADNK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BCIDFDOICDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8520", Offset = "0x3EB7920", VA = "0x183EB8520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9370", Offset = "0x3EB8770", VA = "0x183EB9370")]
	public NMGFKHEHGDM([In] T PAHKKNONPEO, bool CAKFEMINNDL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8460", Offset = "0x3EB7860", VA = "0x183EB8460")]
	public static bool AODPLFIFGHC([In] NMGFKHEHGDM<T> NAJACJFDALM, [In] NMGFKHEHGDM<T> AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38E2E10", Offset = "0x38E2210", VA = "0x1838E2E10", Slot = "4")]
	public bool Equals(NMGFKHEHGDM<T> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8B00", Offset = "0x3EB7F00", VA = "0x183EB8B00", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8D00", Offset = "0x3EB8100", VA = "0x183EB8D00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9230", Offset = "0x3EB8630", VA = "0x183EB9230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class GNNFNMMHGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x25FAA30", Offset = "0x25F9E30", VA = "0x1825FAA30")]
	public static NMGFKHEHGDM<T> PIMDHPFGEDI<T>([In] T PAHKKNONPEO) where T : notnull
	{
		return default(NMGFKHEHGDM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x25FA920", Offset = "0x25F9D20", VA = "0x1825FA920")]
	public static NMGFKHEHGDM<T?> KHBLKKHHFDB<T>()
	{
		return default(NMGFKHEHGDM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x25FA7E0", Offset = "0x25F9BE0", VA = "0x1825FA7E0")]
	public static bool JMHHIECDLKM<T>([In] this NMGFKHEHGDM<T> GMPOMJEFEFE, [Out][NotNullWhen(true)] T PAHKKNONPEO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct OOGEGPGEIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr NHLJGLOHPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr IMEENDKHIFK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr GMNMOCBOHHN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr JODMHNBNCFE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly OOGEGPGEIEB HNPOJGAPKPM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DCKNEPLMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6097350", Offset = "0x6096750", VA = "0x186097350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862A10", VA = "0x180863610")]
	public OOGEGPGEIEB(IntPtr EAILHGKLPCN, IntPtr KLIIGOHBPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	private static void ABKBIGCHCAN(string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	private static void AIHABOMENKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60972C0", Offset = "0x60966C0", VA = "0x1860972C0")]
	private static OOGEGPGEIEB MKOHBFEPLFM()
	{
		return default(OOGEGPGEIEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct HAIHKIJMBLO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr MLOHIGBDHBH;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	private HAIHKIJMBLO(IntPtr KLIIGOHBPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6093CF0", Offset = "0x60930F0", VA = "0x186093CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6093D00", Offset = "0x6093100", VA = "0x186093D00")]
	public static HAIHKIJMBLO PIJMMFMEPKL(string ADLKEGECLOG)
	{
		return default(HAIHKIJMBLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D19C50", Offset = "0x1D19050", VA = "0x181D19C50")]
	public static HAIHKIJMBLO PIJMMFMEPKL([In] OOGEGPGEIEB IIHCFCLCLPA, string ADLKEGECLOG)
	{
		return default(HAIHKIJMBLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A320", Offset = "0x1D19720", VA = "0x181D1A320")]
	public static HAIHKIJMBLO PIJMMFMEPKL([In] OOGEGPGEIEB IIHCFCLCLPA, Func<string> ADLKEGECLOG)
	{
		return default(HAIHKIJMBLO);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class AEBBOHFHPMH
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool MJLDENLAEFK<in TInput, TResult>(TInput KJOOLMAMLNL, [Out] TResult APCONDCGDJA);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class DBELBCPCLHI : IPHFNAPHIML
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class IADALABHCHI : AEHMONCHGBD, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly IADALABHCHI OKALMGBNAPE;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool AFAAFCBBNEA
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x6093F00", Offset = "0x6093300", VA = "0x186093F00", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6093F60", Offset = "0x6093360", VA = "0x186093F60", Slot = "6")]
			public void OnCompleted(Action GBCGPGPMMPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			public void JONBGDAHKMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public IADALABHCHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly DBELBCPCLHI OKALMGBNAPE;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		private DBELBCPCLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6091EB0", Offset = "0x60912B0", VA = "0x186091EB0", Slot = "4")]
		public AEHMONCHGBD OLICJBAOPML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class KJMNGLLGCEJ : IPHFNAPHIML
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class DJIGPDCKNGB : AEHMONCHGBD, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly DJIGPDCKNGB OKALMGBNAPE;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool AFAAFCBBNEA
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6091F80", Offset = "0x6091380", VA = "0x186091F80", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6091FA0", Offset = "0x60913A0", VA = "0x186091FA0", Slot = "6")]
			public void OnCompleted(Action GBCGPGPMMPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			public void JONBGDAHKMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public DJIGPDCKNGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly KJMNGLLGCEJ OKALMGBNAPE;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		private KJMNGLLGCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6094480", Offset = "0x6093880", VA = "0x186094480", Slot = "4")]
		public AEHMONCHGBD OLICJBAOPML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class GIEOEAGMIDI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public GIEOEAGMIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x377EF00", Offset = "0x377E300", VA = "0x18377EF00")]
		internal void LPIJBLFFBHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EICMDLFFLHH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public EICMDLFFLHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x32BE7E0", Offset = "0x32BDBE0", VA = "0x1832BE7E0")]
		internal void AFKHMCGJFMP(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct ADNGLKHOJMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x608E810", Offset = "0x608DC10", VA = "0x18608E810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x92DFC0", Offset = "0x92D3C0", VA = "0x18092DFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct HECKMPNMHPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6093DF0", Offset = "0x60931F0", VA = "0x186093DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x92DFC0", Offset = "0x92D3C0", VA = "0x18092DFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct EKKFKFMKNHJ<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x32E07D0", Offset = "0x32DFBD0", VA = "0x1832E07D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x32E0940", Offset = "0x32DFD40", VA = "0x1832E0940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct AEFKBCOMELL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3724780", Offset = "0x3723B80", VA = "0x183724780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3724FF0", Offset = "0x37243F0", VA = "0x183724FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct OECEINAJDJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6096250", Offset = "0x6095650", VA = "0x186096250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6096450", Offset = "0x6095850", VA = "0x186096450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class LDCNPPGMKNJ<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LDCNPPGMKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x377EF00", Offset = "0x377E300", VA = "0x18377EF00")]
		internal void OCPINGALJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9CA0", Offset = "0x3BF90A0", VA = "0x183BF9CA0")]
		internal void GEAKDOMNLBB(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KBLBHMOLAEB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MJLDENLAEFK<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B29A50", Offset = "0x3B28E50", VA = "0x183B29A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B2A140", Offset = "0x3B29540", VA = "0x183B2A140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BPHFKHHOODC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60913A0", Offset = "0x60907A0", VA = "0x1860913A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6091B90", Offset = "0x6090F90", VA = "0x186091B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct PIKKAKFKPBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6097C80", Offset = "0x6097080", VA = "0x186097C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60981C0", Offset = "0x60975C0", VA = "0x1860981C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NBFCKDFELFF<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E70640", Offset = "0x3E6FA40", VA = "0x183E70640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E510", Offset = "0x3C2D910", VA = "0x183C2E510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HFADGNCOHLF<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x381AE80", Offset = "0x381A280", VA = "0x18381AE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x32AA870", Offset = "0x32A9C70", VA = "0x1832AA870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct NEEIJFFAANJ<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B720", Offset = "0x3E8AB20", VA = "0x183E8B720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BE20", Offset = "0x3E8B220", VA = "0x183E8BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct LLEMGOLKCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6095B10", Offset = "0x6094F10", VA = "0x186095B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6095CF0", Offset = "0x60950F0", VA = "0x186095CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OGGHGIFKIPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6096DF0", Offset = "0x60961F0", VA = "0x186096DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6097160", Offset = "0x6096560", VA = "0x186097160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct LDHJFIDAHMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60957C0", Offset = "0x6094BC0", VA = "0x1860957C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6095AB0", Offset = "0x6094EB0", VA = "0x186095AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class GNOHEGPJJAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public GNOHEGPJJAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60938F0", Offset = "0x6092CF0", VA = "0x1860938F0")]
		internal Task ONPNLCMOAJN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HACMPGCENEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6093A30", Offset = "0x6092E30", VA = "0x186093A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6093C90", Offset = "0x6093090", VA = "0x186093C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct INGCKFKMJEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60941B0", Offset = "0x60935B0", VA = "0x1860941B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6094390", Offset = "0x6093790", VA = "0x186094390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KLLADALLDJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6094550", Offset = "0x6093950", VA = "0x186094550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60948C0", Offset = "0x6093CC0", VA = "0x1860948C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct NDOLAHGFJPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6095E80", Offset = "0x6095280", VA = "0x186095E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6096170", Offset = "0x6095570", VA = "0x186096170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class IJOADMOAGMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public IJOADMOAGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6094140", Offset = "0x6093540", VA = "0x186094140")]
		internal Task HFCLGDCACLO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct BPJLLJIEFBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6091BF0", Offset = "0x6090FF0", VA = "0x186091BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6091E50", Offset = "0x6091250", VA = "0x186091E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ELBEMIMJCLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6092210", Offset = "0x6091610", VA = "0x186092210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6092390", Offset = "0x6091790", VA = "0x186092390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct HHKCDCFIAGP<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x381D6A0", Offset = "0x381CAA0", VA = "0x18381D6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x381D900", Offset = "0x381CD00", VA = "0x18381D900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct BGDOIFMDNHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6090F30", Offset = "0x6090330", VA = "0x186090F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6091340", Offset = "0x6090740", VA = "0x186091340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? DPOGKLLMLJJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<JDDDAABNCFI> LCNLCFDOCEH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task PIAFLLLMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x608F800", Offset = "0x608EC00", VA = "0x18608F800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2C53400", Offset = "0x2C52800", VA = "0x182C53400")]
	public static Task<T> BLCKLGCBDGP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x608FAE0", Offset = "0x608EEE0", VA = "0x18608FAE0")]
	public static Task LEGAPAPPEME(this Task ADFIKOFONEM, CancellationToken KNOHBODGPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2C55720", Offset = "0x2C54B20", VA = "0x182C55720")]
	public static Task<TResult> LEGAPAPPEME<TResult>(this Task<TResult> ADFIKOFONEM, CancellationToken KNOHBODGPLL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2C56240", Offset = "0x2C55640", VA = "0x182C56240")]
	public static TaskCompletionSource<TResult> LEGAPAPPEME<TResult>(this TaskCompletionSource<TResult> DBEOHBPJKIC, CancellationToken KNOHBODGPLL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x608E970", Offset = "0x608DD70", VA = "0x18608E970")]
	[AsyncStateMachine(typeof(ADNGLKHOJMM))]
	public static void BLHAEKAALOJ(this Task DMIDIFJGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x608FD90", Offset = "0x608F190", VA = "0x18608FD90")]
	[AsyncStateMachine(typeof(HECKMPNMHPH))]
	public static void LLGCFPLMGBH(this Task DMIDIFJGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C53550", Offset = "0x2C52950", VA = "0x182C53550")]
	[AsyncStateMachine(typeof(EKKFKFMKNHJ<>))]
	public static Task DCMBMJKEGIM<TException>(this Task DMIDIFJGAKP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2C53A20", Offset = "0x2C52E20", VA = "0x182C53A20")]
	[AsyncStateMachine(typeof(AEFKBCOMELL<>))]
	public static Task<T> KAALALJFJAA<T>(this Task<T> LHCHBOKBAPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x608F540", Offset = "0x608E940", VA = "0x18608F540")]
	[AsyncStateMachine(typeof(OECEINAJDJI))]
	public static Task<TaskStatus> GBAOJLIKLFI(this Task LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2C537E0", Offset = "0x2C52BE0", VA = "0x182C537E0")]
	public static (Task<T?>?, Action<T?>?) JGCPNOIBAOB<T>([Optional] CancellationToken HHHPDCGPCML)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2C567A0", Offset = "0x2C55BA0", VA = "0x182C567A0")]
	[AsyncStateMachine(typeof(KBLBHMOLAEB<, >))]
	public static Task<List<TResult>> LLLECCMJIJA<TResult, TInput>(this Task<List<TInput>> ADFIKOFONEM, MJLDENLAEFK<TInput, TResult> LNOEJHKFPFE) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x608EA20", Offset = "0x608DE20", VA = "0x18608EA20")]
	[AsyncStateMachine(typeof(BPHFKHHOODC))]
	public static Task CEEBGLJIMJF(Task DMIDIFJGAKP, CancellationToken GLAAHKDDIBE, Func<CancellationToken, Task> IFDCKKIHNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x608FE40", Offset = "0x608F240", VA = "0x18608FE40")]
	[AsyncStateMachine(typeof(PIKKAKFKPBI))]
	public static Task LMICEBANDMH(Func<CancellationToken, Task> AECKBCKJJPA, TimeSpan AEOPAJNOPOK, [Optional] CancellationToken GLAAHKDDIBE, [Optional] Action<OperationCanceledException>? MHLDNAGHFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2C568A0", Offset = "0x2C55CA0", VA = "0x182C568A0")]
	[AsyncStateMachine(typeof(NBFCKDFELFF<>))]
	public static Task<T> LMICEBANDMH<T>(Func<CancellationToken, Task<T>> AECKBCKJJPA, TimeSpan AEOPAJNOPOK, [Optional] CancellationToken GLAAHKDDIBE, [Optional] Func<OperationCanceledException, T>? MHLDNAGHFMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C53700", Offset = "0x2C52B00", VA = "0x182C53700")]
	[AsyncStateMachine(typeof(HFADGNCOHLF<>))]
	public static Task<IEnumerable<Task<T>>> HAFCJOIKCPM<T>(IEnumerable<Task<T>> OLMDPDEMHGL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2C56BF0", Offset = "0x2C55FF0", VA = "0x182C56BF0")]
	[AsyncStateMachine(typeof(NEEIJFFAANJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> PBFHEIPKOLC<T1, T2, T3, T4>(Task<T1> DIIOPDMGOLL, Task<T2> KNEGKKLGEEP, Task<T3> AOHBMBCNLFD, Task<T4> KEKDCKDKPHD) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x608EC60", Offset = "0x608E060", VA = "0x18608EC60")]
	[AsyncStateMachine(typeof(LLEMGOLKCEP))]
	public static Task CJFOFOBGHIL(Func<bool> NDMNCGHKEPJ, [Optional] CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x608EB50", Offset = "0x608DF50", VA = "0x18608EB50")]
	[AsyncStateMachine(typeof(OGGHGIFKIPC))]
	public static Task CJFOFOBGHIL(Func<bool> NDMNCGHKEPJ, TimeSpan JLKLOOGLDLK, [Optional] CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x608F870", Offset = "0x608EC70", VA = "0x18608F870")]
	[AsyncStateMachine(typeof(LDHJFIDAHMG))]
	public static Task JOKLAFGGPCM(Func<bool> NDMNCGHKEPJ, TimeSpan AEOPAJNOPOK, [Optional] CancellationToken HHHPDCGPCML, [Optional] Action<OperationCanceledException>? MHLDNAGHFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x608F9A0", Offset = "0x608EDA0", VA = "0x18608F9A0")]
	[AsyncStateMachine(typeof(HACMPGCENEC))]
	public static Task JOKLAFGGPCM(Func<bool> NDMNCGHKEPJ, TimeSpan AEOPAJNOPOK, TimeSpan JLKLOOGLDLK, [Optional] CancellationToken HHHPDCGPCML, [Optional] Action<OperationCanceledException>? MHLDNAGHFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x608F0D0", Offset = "0x608E4D0", VA = "0x18608F0D0")]
	[AsyncStateMachine(typeof(INGCKFKMJEE))]
	public static Task EAOELLOFGDJ(Func<bool> NDMNCGHKEPJ, [Optional] CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x608F1C0", Offset = "0x608E5C0", VA = "0x18608F1C0")]
	[AsyncStateMachine(typeof(KLLADALLDJF))]
	public static Task EAOELLOFGDJ(Func<bool> NDMNCGHKEPJ, TimeSpan JLKLOOGLDLK, [Optional] CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x608F410", Offset = "0x608E810", VA = "0x18608F410")]
	[AsyncStateMachine(typeof(NDOLAHGFJPM))]
	public static Task FBENNLPGIMH(Func<bool> NDMNCGHKEPJ, TimeSpan AEOPAJNOPOK, [Optional] CancellationToken HHHPDCGPCML, [Optional] Action<OperationCanceledException>? MHLDNAGHFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x608F2D0", Offset = "0x608E6D0", VA = "0x18608F2D0")]
	[AsyncStateMachine(typeof(BPJLLJIEFBB))]
	public static Task FBENNLPGIMH(Func<bool> NDMNCGHKEPJ, TimeSpan AEOPAJNOPOK, TimeSpan JLKLOOGLDLK, [Optional] CancellationToken HHHPDCGPCML, [Optional] Action<OperationCanceledException>? MHLDNAGHFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x60902F0", Offset = "0x608F6F0", VA = "0x1860902F0")]
	[AsyncStateMachine(typeof(ELBEMIMJCLG))]
	[Obsolete]
	public static Task OFMFLCOMFAA(this Task ADFIKOFONEM, Action FBAOGEJPGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C56B00", Offset = "0x2C55F00", VA = "0x182C56B00")]
	[Obsolete]
	[AsyncStateMachine(typeof(HHKCDCFIAGP<>))]
	public static Task OFMFLCOMFAA<T>(this Task<T> ADFIKOFONEM, Action<T> FBAOGEJPGIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x608F630", Offset = "0x608EA30", VA = "0x18608F630")]
	private static void HGNCGLMPCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x608ED50", Offset = "0x608E150", VA = "0x18608ED50")]
	public static bool CMBENLIAKLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6090040", Offset = "0x608F440", VA = "0x186090040")]
	private static void NAHNDBBLHIB(SynchronizationContext PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x608F6E0", Offset = "0x608EAE0", VA = "0x18608F6E0")]
	private static void IAFKLAMHLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x608FF70", Offset = "0x608F370", VA = "0x18608FF70")]
	public static void MMLPPBJLLAN([Optional] string? AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x608FD40", Offset = "0x608F140", VA = "0x18608FD40")]
	public static IPHFNAPHIML LIIFOFBPLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60901D0", Offset = "0x608F5D0", VA = "0x1860901D0")]
	public static IPHFNAPHIML NJIOAPLNNDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6090220", Offset = "0x608F620", VA = "0x186090220")]
	[AsyncStateMachine(typeof(BGDOIFMDNHK))]
	public static Task OENMOADNOEH(Func<Task> HHLGGDGPLKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LOKPKGJHMNM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
	public LOKPKGJHMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DPBENFIEGMI : OMCFMCIBMJI
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly OMCFMCIBMJI OKALMGBNAPE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime CGEHBNEOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6092120", Offset = "0x6091520", VA = "0x186092120", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset KBMOMCMGJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60920C0", Offset = "0x60914C0", VA = "0x1860920C0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public DPBENFIEGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface OMCFMCIBMJI
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime CGEHBNEOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset KBMOMCMGJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class FFCNPDHLNHP
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long KKHLDNGMIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6092820", Offset = "0x6091C20", VA = "0x186092820")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long BPAOEKNNILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60923F0", Offset = "0x60917F0", VA = "0x1860923F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double CMCPFMJFPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60926A0", Offset = "0x6091AA0", VA = "0x1860926A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double ANIEABGCLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6092650", Offset = "0x6091A50", VA = "0x186092650")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double HOGONEJFABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6092870", Offset = "0x6091C70", VA = "0x186092870")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LNFPDHAIHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x60927C0", Offset = "0x6091BC0", VA = "0x1860927C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6092440", Offset = "0x6091840", VA = "0x186092440")]
	public static double DEPPACOEPAK(long AHBMAOGFKCN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6092530", Offset = "0x6091930", VA = "0x186092530")]
	public static double DJMHEPNOKJP(long AHBMAOGFKCN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60925C0", Offset = "0x60919C0", VA = "0x1860925C0")]
	public static double DMHOKDIMDJK(double GAIKHOGKDCP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60928C0", Offset = "0x6091CC0", VA = "0x1860928C0")]
	public static long OINKKNLMIEI(long PPLAIKBLALP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6092810", Offset = "0x6091C10", VA = "0x186092810")]
	public static long LJCOALONMIO(long IINEHIFICHE, long DMHFHHEPIAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60926F0", Offset = "0x6091AF0", VA = "0x1860926F0")]
	public static double LHCLEJFBAPJ(long IINEHIFICHE, long DMHFHHEPIAE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60924D0", Offset = "0x60918D0", VA = "0x1860924D0")]
	public static double DHBGGCEMMDH(long IINEHIFICHE, long DMHFHHEPIAE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class PEHGAIFAIND : AAKLKHGJFJB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan ODCEMFNFECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer DBIAGNOCLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan AEOPAJNOPOK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan BBOEEDLGAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60976C0", Offset = "0x6096AC0", VA = "0x1860976C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? PKNINDEJMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60979C0", Offset = "0x6096DC0", VA = "0x1860979C0")]
	[Preserve]
	public PEHGAIFAIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6097A30", Offset = "0x6096E30", VA = "0x186097A30")]
	public PEHGAIFAIND(TimeSpan AEOPAJNOPOK, [Optional] Action? PPEFFJEMODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60978C0", Offset = "0x6096CC0", VA = "0x1860978C0", Slot = "7")]
	public void OFAAPPLMKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6097820", Offset = "0x6096C20", VA = "0x186097820", Slot = "8")]
	public void JAPKMJLPFMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6097890", Offset = "0x6096C90", VA = "0x186097890", Slot = "9")]
	public void MDMPOIPPKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xB9A2B0", Offset = "0xB996B0", VA = "0x180B9A2B0")]
	private void EMDAAEJDJBJ(object IBGLEOLMNIG, ElapsedEventArgs JJHOODBGJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6097620", Offset = "0x6096A20", VA = "0x186097620")]
	private static void HFOONDLLPOG(TimeSpan CILADJMEPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6097580", Offset = "0x6096980", VA = "0x186097580", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class BHFIKJBBKEL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string FBBHJAECEKN;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
	public BHFIKJBBKEL(string MFDFNAPOEEK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KOIDDPPHLEE : IEquatable<KOIDDPPHLEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint ENNPPELMDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int KAJHACBCBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float MMAKPHFCJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort OMBMOELHPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort KFILJAGOICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short IANIFIFMABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short CBGCAOCBIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char EJIJGPHJMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char OHIDCOKJEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte GNPOGLIBHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte GHAOFFBKLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte OMBACFLDKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte MIMLODFMEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool AIIJEBPABGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool BDBFCAGMMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool NECJMLEENOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool JMPCGKJMPHJ;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static KOIDDPPHLEE DHMLFKPGKMG(uint NENEGGDBDMH)
	{
		return default(KOIDDPPHLEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static KOIDDPPHLEE BBENDNIJPIK(int OJFLCIGBEFL)
	{
		return default(KOIDDPPHLEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6094920", Offset = "0x6093D20", VA = "0x186094920")]
	public static KOIDDPPHLEE AFDNGBBCCEF(float POAJICIBCKM)
	{
		return default(KOIDDPPHLEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60949B0", Offset = "0x6093DB0", VA = "0x1860949B0")]
	public static KOIDDPPHLEE JPGDKHAPHEA(byte JECLLKPOKDH, byte ILKFIKDPCHL, byte HJNCCEKNPOO, byte NPOMHEKBCAG)
	{
		return default(KOIDDPPHLEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60949B0", Offset = "0x6093DB0", VA = "0x1860949B0")]
	public static KOIDDPPHLEE INJMPEOLOED(bool LLJKLPGEBLP, bool FOHPFPADHJF, bool NLINLCKKFFK, bool MIHDCFGJNJK)
	{
		return default(KOIDDPPHLEE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x175BF00", Offset = "0x175B300", VA = "0x18175BF00")]
	public static bool AODPLFIFGHC(KOIDDPPHLEE KKNFIGGNDFK, KOIDDPPHLEE PPBIBECNBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x818E50", Offset = "0x818250", VA = "0x180818E50", Slot = "4")]
	public bool Equals(KOIDDPPHLEE JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6094930", Offset = "0x6093D30", VA = "0x186094930", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8A3210", Offset = "0x8A2610", VA = "0x1808A3210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x60949D0", Offset = "0x6093DD0", VA = "0x1860949D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct DLDDCOBIMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong AGBIPDPLPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long IHGGIFDCFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double BGJEJPCGCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint MCHDCIIJHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint KPLKCHGHLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int FMEOBGECELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int BEAEKJBCNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float CJCJOFBHDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float ABCCENGEFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort OMBMOELHPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort KFILJAGOICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort JFNEMMDBHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort CLPGJNGNHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short IANIFIFMABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short CBGCAOCBIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short MKNPGJICBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short NOJKIDMINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char EJIJGPHJMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char OHIDCOKJEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char JGHOGIEHCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char BLAFOEAFMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte GNPOGLIBHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte GHAOFFBKLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte OMBACFLDKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte MIMLODFMEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte PGDHHOCPJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte IEMPHAHAKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte KDHNLDJEJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte EAKBLPHJHFI;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6092070", Offset = "0x6091470", VA = "0x186092070")]
	public static DLDDCOBIMLO PIJMMFMEPKL(byte JECLLKPOKDH, byte ILKFIKDPCHL, byte HJNCCEKNPOO, byte NPOMHEKBCAG, byte JFHKDGLDIEO, byte AFJENKBDHMK, byte MDHACCCONLB, byte PHHPNHCJCNJ)
	{
		return default(DLDDCOBIMLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class EBELPCIEJMD
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x24C8B70", Offset = "0x24C7F70", VA = "0x1824C8B70")]
	public static IEnumerable<T> JJIEKIIGDNI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static T[] NJMLENJAIKO<T>(params T[] JGHLDEEGHCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static IEnumerable<T> FFMLANKINDP<T>(params T[] JGHLDEEGHCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x23F3E10", Offset = "0x23F3210", VA = "0x1823F3E10")]
	public static HashSet<T> EBKBIKKMBCC<T>(params T[] JGHLDEEGHCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x24C8B90", Offset = "0x24C7F90", VA = "0x1824C8B90")]
	public static KeyValuePair<TKey, TValue> NBLFGDBMODA<TKey, TValue>([In] TKey CONEAMPCFEL, [In] TValue PAHKKNONPEO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x23F3E10", Offset = "0x23F3210", VA = "0x1823F3E10")]
	public static List<T> CCGAEBFFFFB<T>(IEnumerable<T> MEKGNJLOKAF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All)]
public sealed class PPBKPNMCKIN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string JKOIIOLCLJO;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
	public PPBKPNMCKIN(string HBMIPEJIPBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object AECCGEPGPLB<T>([In] T CNLJFDAGKBD);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object ICAOLCLGHPN<T>(T CNLJFDAGKBD);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[CEEFMBCJICM]
public delegate string OKDGENLBCMC(string LNCBDEONNFN, string? BCODKKBIHPM, bool IJMMHAIIJEN);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[CEEFMBCJICM]
public delegate void MDGGLEJDLFB(string AGOKDCAFCLN);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CEEFMBCJICM]
public delegate void KJLGGJGKHNM(Exception EAIHDKDABHO);
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object NHJIBIKACGO();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[CEEFMBCJICM]
public delegate bool IJAPHAPHMKK();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[CEEFMBCJICM]
public delegate string DMILBHNIGDI(object DFFBALIDCLL);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.Enum)]
public class KGJICCAMAII : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
	public KGJICCAMAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class BHOAEOMPLEO
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class CLPKHMHCOPN<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly ISet<T> OKALMGBNAPE;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int IGPGGFCOPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4AB0", Offset = "0x4BB3EB0", VA = "0x184BB4AB0", Slot = "4")]
		public bool Add(T JCBFPBHHLOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "6")]
		public void IntersectWith(IEnumerable<T> JLCJEDAFKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4CB0", Offset = "0x4BB40B0", VA = "0x184BB4CB0", Slot = "5")]
		public void UnionWith(IEnumerable<T> JLCJEDAFKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4C50", Offset = "0x4BB4050", VA = "0x184BB4C50", Slot = "9")]
		void ICollection<T>.Add(T JCBFPBHHLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "11")]
		public bool Contains(T JCBFPBHHLOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "12")]
		public void CopyTo(T[] CBCBEPHCJOP, int LNMJODKMHJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
		public bool Remove(T JCBFPBHHLOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4B70", Offset = "0x4BB3F70", VA = "0x184BB4B70", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x36135C0", Offset = "0x36129C0", VA = "0x1836135C0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public CLPKHMHCOPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81F560", Offset = "0x81E960", VA = "0x18081F560")]
	public static ISet<T> HEEJPNJDOOK<T>() where T : notnull
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
