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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E71D00", Offset = "0x5E70D00", VA = "0x185E71D00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class OGILEDEFJAG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E72C20", Offset = "0x5E71C20", VA = "0x185E72C20")]
	public OGILEDEFJAG(bool IEOANKEGNDB, string CKEECHIMBMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FAPCJBEABFL<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> LGOFBPNENJI(CancellationToken JEBPNJAPHEL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HDJAOELACML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public FAPCJBEABFL<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public LGOFBPNENJI taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x35EA2A0", Offset = "0x35E92A0", VA = "0x1835EA2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35EB300", Offset = "0x35EA300", VA = "0x1835EB300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource OCCBKDMNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? OCLLFGHJKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? AHPFGCMJOBO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34468E0", Offset = "0x34458E0", VA = "0x1834468E0")]
	[AsyncStateMachine(typeof(FAPCJBEABFL<>.HDJAOELACML))]
	public Task<TResult> KLBJKHPPDBJ(LGOFBPNENJI NCPMIFFFNFK, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3446870", Offset = "0x3445870", VA = "0x183446870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3446A20", Offset = "0x3445A20", VA = "0x183446A20")]
	public FAPCJBEABFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MJKIOINODFG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> KFBGOBAMIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T INAJMIAKCCF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2350", Offset = "0x3CB1350", VA = "0x183CB2350")]
	public MJKIOINODFG([In] T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB18A0", Offset = "0x3CB08A0", VA = "0x183CB18A0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1D80", Offset = "0x3CB0D80", VA = "0x183CB1D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1F10", Offset = "0x3CB0F10", VA = "0x183CB1F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DHFMJLFOIKG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BF50", Offset = "0x5E6AF50", VA = "0x185E6BF50")]
	public static void AEICMDNNKNK(this CancellationTokenSource OCCBKDMNJNC, bool NPDPKKNGPBE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MLJNPPNNAJD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
	public MLJNPPNNAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class IHGAIGMILNM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
	public IHGAIGMILNM(string GDPJBLPGPNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class BCGJDANJAAK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
	public BCGJDANJAAK(string GDPJBLPGPNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BBGPMJOOMFG
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22A3500", Offset = "0x22A2500", VA = "0x1822A3500")]
	public static BMIJEMFIKCI MGCBLMJICHC<T>()
	{
		return default(BMIJEMFIKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x22A32F0", Offset = "0x22A22F0", VA = "0x1822A32F0")]
	public static BMIJEMFIKCI DPJFJEPPEKF<T>([CallerMemberName] string JNMEJDHMADI = "") where T : notnull
	{
		return default(BMIJEMFIKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22A3480", Offset = "0x22A2480", VA = "0x1822A3480")]
	public static BMIJEMFIKCI MGCBLMJICHC<T>(this T GDKIMOIKOFD) where T : notnull
	{
		return default(BMIJEMFIKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22A3580", Offset = "0x22A2580", VA = "0x1822A3580")]
	public static BMIJEMFIKCI NNDBONJJABF<T>(this T GDKIMOIKOFD, [CallerMemberName] string JNMEJDHMADI = "") where T : notnull
	{
		return default(BMIJEMFIKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x22A3250", Offset = "0x22A2250", VA = "0x1822A3250")]
	public static BMIJEMFIKCI DPJFJEPPEKF<T>(this T IEOMMHOPOKN, [CallerMemberName] string JNMEJDHMADI = "") where T : notnull
	{
		return default(BMIJEMFIKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BA00", Offset = "0x5E6AA00", VA = "0x185E6BA00")]
	public static BMIJEMFIKCI DPJFJEPPEKF(string EGNCJMCIPOK, [CallerMemberName] string JNMEJDHMADI = "")
	{
		return default(BMIJEMFIKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BA80", Offset = "0x5E6AA80", VA = "0x185E6BA80")]
	public static string HGCHIDMCKIE(this object IEOMMHOPOKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[MLJNPPNNAJD]
public delegate long MJPNMOCHCLG();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GFFDPMPJCOF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static INFLPMBNHCA PBALGHAKIHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static INFLPMBNHCA HPIKJDDINBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CC00", Offset = "0x5E6BC00", VA = "0x185E6CC00")]
		get
		{
			return default(INFLPMBNHCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IDIGKCEIICE HIKGDDCMFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CCC0", Offset = "0x5E6BCC0", VA = "0x185E6CCC0")]
		get
		{
			return default(IDIGKCEIICE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static ADNKMLHCABO JJBLLCAOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CBB0", Offset = "0x5E6BBB0", VA = "0x185E6CBB0")]
		get
		{
			return default(ADNKMLHCABO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C9D0", Offset = "0x5E6B9D0", VA = "0x185E6C9D0")]
	public static void AIEODAAIMAK([In] INFLPMBNHCA GJCDDCPGBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D0D0", Offset = "0x5E6C0D0", VA = "0x185E6D0D0")]
	public static void PAOJJBFOCDP(string NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CD90", Offset = "0x5E6BD90", VA = "0x185E6CD90")]
	public static void HPIHPDBEJLD(string NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x24EB6D0", Offset = "0x24EA6D0", VA = "0x1824EB6D0")]
	public static void HPIHPDBEJLD<T>(T DKCNDPMKPNO, NACDGBIBCJH<T> NCBOINMNCHO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D030", Offset = "0x5E6C030", VA = "0x185E6D030")]
	public static void OEDHDJAHCAN(Exception GDBKEDNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB50", Offset = "0x5E6BB50", VA = "0x185E6CB50")]
	public static void BCHEAMHLAGC(string JNMEJDHMADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CF30", Offset = "0x5E6BF30", VA = "0x185E6CF30")]
	public static void JNCLFEDEPMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CD10", Offset = "0x5E6BD10", VA = "0x185E6CD10")]
	public static string HGCHIDMCKIE(object GPCHHCACPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CC50", Offset = "0x5E6BC50", VA = "0x185E6CC50")]
	public static long GLGNGJNBCEI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CF90", Offset = "0x5E6BF90", VA = "0x185E6CF90")]
	public static bool LHGBBCHPJKL(bool FJNLKDBBOPP, string NCBOINMNCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CE60", Offset = "0x5E6BE60", VA = "0x185E6CE60")]
	public static double IENIJBEJPDG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct INFLPMBNHCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly IDIGKCEIICE HIKGDDCMFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly ADNKMLHCABO JJBLLCAOGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly GIPCKCHEECG MBKIKOLCLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly MJPNMOCHCLG FDKPJOHAMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly CNAEJDFAFAJ KHFNOKCLKAF;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly GIPCKCHEECG FJOEBHGBBGM;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly MJPNMOCHCLG IOCLENHBABB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CNAEJDFAFAJ IMIKFEFEJEI;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly INFLPMBNHCA FKNBKDPNJFH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MHPEFMEANPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F500", Offset = "0x5E6E500", VA = "0x185E6F500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FC60", Offset = "0x5E6EC60", VA = "0x185E6FC60")]
	public INFLPMBNHCA([In] IDIGKCEIICE JFCIFPCLLLO, [In] ADNKMLHCABO DJOMEGEMHJA, GIPCKCHEECG AOCAPDIBKIM, MJPNMOCHCLG KJGBJBEIOFP, CNAEJDFAFAJ ILAMMAPBOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F660", Offset = "0x5E6E660", VA = "0x185E6F660")]
	private static string HLHCFHOIKKM(object GPCHHCACPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0")]
	private static long FHBIHGDHMOH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	private static string APKHHDCMMLA(string CINODLDMGAP, string? OGCJFLBKOOA, bool DMPEONHNMEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F400", Offset = "0x5E6E400", VA = "0x185E6F400")]
	private static INFLPMBNHCA BBHBBGLKBOG()
	{
		return default(INFLPMBNHCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GNOPBKFOMED
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGKBMDMKJBD LKIDDMAHHKC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LGKBMDMKJBD : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BKEJBEDEMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIEIGFPHENP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CMNNFJMLHHN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOMDBPBBAAF([In] T EJEDDDCGMMB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void APCEOIGKKKO<T>([In] T DKCNDPMKPNO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct AGEIDNCBBCE<T> : IEquatable<AGEIDNCBBCE<T>>, CMNNFJMLHHN<AGEIDNCBBCE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T INAJMIAKCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int KLNGLNIFDLJ;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CBE950", Offset = "0x1CBD950", VA = "0x181CBE950")]
	public AGEIDNCBBCE([In] T APPJEOKOGAK, int NFJIPMHILEL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x355AE80", Offset = "0x3559E80", VA = "0x18355AE80")]
	public static bool LICIMLDMCMN([In] AGEIDNCBBCE<T> ANOMGKBFKJP, [In] AGEIDNCBBCE<T> DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3559D00", Offset = "0x3558D00", VA = "0x183559D00", Slot = "4")]
	public bool Equals(AGEIDNCBBCE<T> EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30CDC50", Offset = "0x30CCC50", VA = "0x1830CDC50", Slot = "0")]
	public override bool Equals(object EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3559C70", Offset = "0x3558C70", VA = "0x183559C70")]
	public bool AOMDBPBBAAF([In] AGEIDNCBBCE<T> EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x355A4D0", Offset = "0x35594D0", VA = "0x18355A4D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x355B4D0", Offset = "0x355A4D0", VA = "0x18355B4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x355A040", Offset = "0x3559040", VA = "0x18355A040")]
	public void FPCBDFAHIFB([Out] T APPJEOKOGAK, [Out] int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35599E0", Offset = "0x35589E0", VA = "0x1835599E0")]
	public (T, int) AKPGDEIHBJA()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x355A920", Offset = "0x3559920", VA = "0x18355A920", Slot = "5")]
	private bool JKPMBABCEAD([In] AGEIDNCBBCE<T> EJEDDDCGMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OMBGPOFJADJ
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2636880", Offset = "0x2635880", VA = "0x182636880")]
	public static AGEIDNCBBCE<T> ANBAJJBGINK<T>([In] T APPJEOKOGAK, int NFJIPMHILEL) where T : notnull
	{
		return default(AGEIDNCBBCE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EGCBLCELBLF
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x23B8FF0", Offset = "0x23B7FF0", VA = "0x1823B8FF0")]
	public static bool AOMDBPBBAAF<T, U>([In] T IEOMMHOPOKN, [In] U GPCHHCACPPJ) where T : notnull, CMNNFJMLHHN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult NDKGNBHKLJM<T, out TResult>([In] T DKCNDPMKPNO);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult KOFEAJIBFPG<T1, T2, out TResult>([In] T1 EJBBKMHCMOM, [In] T2 GLGNINKMFCO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KDHLNHAGGJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan JPJAHCNMPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Action? IPGKPJICBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMBOKILCADD();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGALIKADLPK();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ANKILPBGOAL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct IDIGKCEIICE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly MMNDLKAPPDC GMCLMEJPKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly KJJODIMKCJK NPDEKDPFCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly MMNDLKAPPDC GCEBAOMLKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KJJODIMKCJK MFJHBIBPLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly MMNDLKAPPDC MOGNIGPFIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KJJODIMKCJK KFMMEIKCIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly KNFKGNHKEIE DKMGGEAGFIE;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly MMNDLKAPPDC LNADILFEMLI;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly KJJODIMKCJK DFOJBPOJDIM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly MMNDLKAPPDC CNIKNFDAOHB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KJJODIMKCJK MKFFBKNHCHN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly MMNDLKAPPDC JBLPFHMBIJD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KJJODIMKCJK IIFIMAFGNCF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KNFKGNHKEIE EFDFJPHIALA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDIGKCEIICE FKNBKDPNJFH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MMNDLKAPPDC JMOJEAGGIKC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MHPEFMEANPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DCF0", Offset = "0x5E6CCF0", VA = "0x185E6DCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A30", Offset = "0x8C3A30", VA = "0x1808C4A30")]
	public IDIGKCEIICE(MMNDLKAPPDC DJNBGIFIFEB, KJJODIMKCJK OCLNBPEKPPP, MMNDLKAPPDC DPNKNMDNKFL, KJJODIMKCJK KOIIIIOJDFI, MMNDLKAPPDC HAIFHPDDLLE, KJJODIMKCJK LPILAENJAEN, KNFKGNHKEIE EJAPCPPOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0")]
	private static bool OKCOOCNMABC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private static void DOFPHPDJCBG(string NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0")]
	private static bool BBJCFDBOBKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private static void JMFBMGJLBBO(string NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0")]
	private static bool GAMPOBFMPJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private static void GHMDDMKANJB(string NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private static void NLMDAKOMJPG(Exception GDBKEDNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DBB0", Offset = "0x5E6CBB0", VA = "0x185E6DBB0")]
	private static IDIGKCEIICE BBHBBGLKBOG()
	{
		return default(IDIGKCEIICE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130")]
	private static bool OKJIDAJJDGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E110", Offset = "0x5E6D110", VA = "0x185E6E110")]
	public void PAOJJBFOCDP(object NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DEF0", Offset = "0x5E6CEF0", VA = "0x185E6DEF0")]
	public void HPIHPDBEJLD(object NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20C88E0", Offset = "0x20C78E0", VA = "0x1820C88E0")]
	public void OEDHDJAHCAN(Exception GDBKEDNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DF60", Offset = "0x5E6CF60", VA = "0x185E6DF60")]
	public void HPIHPDBEJLD(EEKGMGGKLOL NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x250B6F0", Offset = "0x250A6F0", VA = "0x18250B6F0")]
	public void HPIHPDBEJLD<T>(T DKCNDPMKPNO, NACDGBIBCJH<T> NCBOINMNCHO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x250B7B0", Offset = "0x250A7B0", VA = "0x18250B7B0")]
	public void PAOJJBFOCDP<T>([In] T DKCNDPMKPNO, GDOAFDIAJGI<T> NCBOINMNCHO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E040", Offset = "0x5E6D040", VA = "0x185E6E040")]
	public bool LHGBBCHPJKL(bool FJNLKDBBOPP, string NCBOINMNCHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct BMIJEMFIKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string INAJMIAKCCF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8426A0", VA = "0x1808436A0")]
	public BMIJEMFIKCI(string APPJEOKOGAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
	public static string OKGBDLIDGHC([In] BMIJEMFIKCI IEOMMHOPOKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1376830", Offset = "0x1375830", VA = "0x181376830")]
	public static BMIJEMFIKCI OKGBDLIDGHC(string EJEDDDCGMMB)
	{
		return default(BMIJEMFIKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BC00", Offset = "0x5E6AC00", VA = "0x185E6BC00")]
	public string NBPBJDKMIKE(string PCPFOKAIBEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BB20", Offset = "0x5E6AB20", VA = "0x185E6BB20")]
	public string DBPAOCIMAFH(object LGADAKPOIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct DBKAPBMMCGK : IEquatable<DBKAPBMMCGK>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "4")]
	public bool Equals(DBKAPBMMCGK EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BEC0", Offset = "0x5E6AEC0", VA = "0x185E6BEC0", Slot = "0")]
	public override bool Equals(object EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BF10", Offset = "0x5E6AF10", VA = "0x185E6BF10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BF20", Offset = "0x5E6AF20", VA = "0x185E6BF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[CGBJKNJKFOC("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JHBPOKMHNNP<T> : IEquatable<JHBPOKMHNNP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T INAJMIAKCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool LMNNIOBFPNE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IGGENDNCCPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x38DE030", Offset = "0x38DD030", VA = "0x1838DE030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38DE710", Offset = "0x38DD710", VA = "0x1838DE710")]
	public JHBPOKMHNNP([In] T APPJEOKOGAK, bool DMHNKLOCHJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38DE040", Offset = "0x38DD040", VA = "0x1838DE040")]
	public static bool LICIMLDMCMN([In] JHBPOKMHNNP<T> ANOMGKBFKJP, [In] JHBPOKMHNNP<T> DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3559D00", Offset = "0x3558D00", VA = "0x183559D00", Slot = "4")]
	public bool Equals(JHBPOKMHNNP<T> EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x38DDA40", Offset = "0x38DCA40", VA = "0x1838DDA40", Slot = "0")]
	public override bool Equals(object EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x38DDE40", Offset = "0x38DCE40", VA = "0x1838DDE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38DE650", Offset = "0x38DD650", VA = "0x1838DE650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DILDLIIHMPF
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x23656C0", Offset = "0x23646C0", VA = "0x1823656C0")]
	public static JHBPOKMHNNP<T> KPLOJAHKNLJ<T>([In] T APPJEOKOGAK) where T : notnull
	{
		return default(JHBPOKMHNNP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2365590", Offset = "0x2364590", VA = "0x182365590")]
	public static JHBPOKMHNNP<T?> HBAECMBFMMC<T>()
	{
		return default(JHBPOKMHNNP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2365780", Offset = "0x2364780", VA = "0x182365780")]
	public static bool MPEHHOKCCGC<T>([In] this JHBPOKMHNNP<T> NCHHAAAELAL, [Out][NotNullWhen(true)] T APPJEOKOGAK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct ADNKMLHCABO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly IntPtr BCHEAMHLAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly IntPtr JNCLFEDEPMB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IntPtr PBJJBNBHGFE;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly IntPtr PFDLCEMBNAA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly ADNKMLHCABO FKNBKDPNJFH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MHPEFMEANPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E69CF0", Offset = "0x5E68CF0", VA = "0x185E69CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E80", Offset = "0x7F6E80", VA = "0x1807F7E80")]
	public ADNKMLHCABO(IntPtr LEJPFFKMPLD, IntPtr MJAKHLBAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private static void JCKALCPDMLE(string JNMEJDHMADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	private static void CAELBFILAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E69C60", Offset = "0x5E68C60", VA = "0x185E69C60")]
	private static ADNKMLHCABO BBHBBGLKBOG()
	{
		return default(ADNKMLHCABO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct IMDNMIFFJPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IntPtr BBMGGALOECJ;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8426A0", VA = "0x1808436A0")]
	private IMDNMIFFJPF(IntPtr MJAKHLBAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F3F0", Offset = "0x5E6E3F0", VA = "0x185E6F3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F300", Offset = "0x5E6E300", VA = "0x185E6F300")]
	public static IMDNMIFFJPF ANBAJJBGINK(string JNMEJDHMADI)
	{
		return default(IMDNMIFFJPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7FE0", Offset = "0x1CB6FE0", VA = "0x181CB7FE0")]
	public static IMDNMIFFJPF ANBAJJBGINK([In] ADNKMLHCABO DJOMEGEMHJA, string JNMEJDHMADI)
	{
		return default(IMDNMIFFJPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7F50", Offset = "0x1CB6F50", VA = "0x181CB7F50")]
	public static IMDNMIFFJPF ANBAJJBGINK([In] ADNKMLHCABO DJOMEGEMHJA, Func<string> JNMEJDHMADI)
	{
		return default(IMDNMIFFJPF);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class APCEBNDEPCF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool CJHCJMOPENH<in TInput, TResult>(TInput JPKFBEJOHFJ, [Out] TResult BBMBCGDLBEE);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class GABFLPJLFKC : GNOPBKFOMED
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class AFMLJDNPBKD : LGKBMDMKJBD, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly AFMLJDNPBKD NKFKDADGOPA;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool BKEJBEDEMML
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x5E69F20", Offset = "0x5E68F20", VA = "0x185E69F20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E69F80", Offset = "0x5E68F80", VA = "0x185E69F80", Slot = "6")]
			public void OnCompleted(Action JLGLEDLMDLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			public void CIEIGFPHENP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public AFMLJDNPBKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly GABFLPJLFKC NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private GABFLPJLFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C900", Offset = "0x5E6B900", VA = "0x185E6C900", Slot = "4")]
		public LGKBMDMKJBD LKIDDMAHHKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class GMAGIPLDAKA : GNOPBKFOMED
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class MDKPKDMGCCI : LGKBMDMKJBD, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly MDKPKDMGCCI NKFKDADGOPA;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool BKEJBEDEMML
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x5E70BA0", Offset = "0x5E6FBA0", VA = "0x185E70BA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E70BC0", Offset = "0x5E6FBC0", VA = "0x185E70BC0", Slot = "6")]
			public void OnCompleted(Action JLGLEDLMDLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			public void CIEIGFPHENP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public MDKPKDMGCCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly GMAGIPLDAKA NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private GMAGIPLDAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D860", Offset = "0x5E6C860", VA = "0x185E6D860", Slot = "4")]
		public LGKBMDMKJBD LKIDDMAHHKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class CAFGONNDDJF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CAFGONNDDJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4570DB0", Offset = "0x456FDB0", VA = "0x184570DB0")]
		internal void IONDKEKOCFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FODIKCDNDMO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FODIKCDNDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3473350", Offset = "0x3472350", VA = "0x183473350")]
		internal void IMNABCGJIJM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HILLEGNHKBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DA50", Offset = "0x5E6CA50", VA = "0x185E6DA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2E60", Offset = "0x8C1E60", VA = "0x1808C2E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct JJIHCNNIKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FFC0", Offset = "0x5E6EFC0", VA = "0x185E6FFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2E60", Offset = "0x8C1E60", VA = "0x1808C2E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct NDDJJLJLHHJ<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D0E7B0", Offset = "0x3D0D7B0", VA = "0x183D0E7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D0E920", Offset = "0x3D0D920", VA = "0x183D0E920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct DGHFFGNIENH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9470", Offset = "0x4DA8470", VA = "0x184DA9470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4DA98B0", Offset = "0x4DA88B0", VA = "0x184DA98B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct CFNLMMNNIEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BC50", Offset = "0x5E6AC50", VA = "0x185E6BC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BE50", Offset = "0x5E6AE50", VA = "0x185E6BE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class BLAFCOKAODP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BLAFCOKAODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4570DB0", Offset = "0x456FDB0", VA = "0x184570DB0")]
		internal void JGPLDOHANOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4570DF0", Offset = "0x456FDF0", VA = "0x184570DF0")]
		internal void PBNIKAOIGCD(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KDJFLJNILID<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CJHCJMOPENH<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x395BBC0", Offset = "0x395ABC0", VA = "0x18395BBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x395C2B0", Offset = "0x395B2B0", VA = "0x18395C2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct IJCLBNCOBJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EAB0", Offset = "0x5E6DAB0", VA = "0x185E6EAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F2A0", Offset = "0x5E6E2A0", VA = "0x185E6F2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KJJDJCOOODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E705B0", Offset = "0x5E6F5B0", VA = "0x185E705B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E70AF0", Offset = "0x5E6FAF0", VA = "0x185E70AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KHGFIOGOKGD<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x396D1E0", Offset = "0x396C1E0", VA = "0x18396D1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x34730C0", Offset = "0x34720C0", VA = "0x1834730C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct BODONNIAOAM<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x45743B0", Offset = "0x45733B0", VA = "0x1845743B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x351D580", Offset = "0x351C580", VA = "0x18351D580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct CEMABDBIGDN<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x47F2200", Offset = "0x47F1200", VA = "0x1847F2200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x47F2ED0", Offset = "0x47F1ED0", VA = "0x1847F2ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FHHNFNJJMJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C160", Offset = "0x5E6B160", VA = "0x185E6C160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C4D0", Offset = "0x5E6B4D0", VA = "0x185E6C4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GKMJMJEPBKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D510", Offset = "0x5E6C510", VA = "0x185E6D510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D800", Offset = "0x5E6C800", VA = "0x185E6D800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NCJDNLCPGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NCJDNLCPGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E71390", Offset = "0x5E70390", VA = "0x185E71390")]
		internal Task GAMNCKALBIL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GJEIEMPJOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D250", Offset = "0x5E6C250", VA = "0x185E6D250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D4B0", Offset = "0x5E6C4B0", VA = "0x185E6D4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct PKOLEABIJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E72CF0", Offset = "0x5E71CF0", VA = "0x185E72CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E72ED0", Offset = "0x5E71ED0", VA = "0x185E72ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FOPGNEJBOHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C530", Offset = "0x5E6B530", VA = "0x185E6C530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C8A0", Offset = "0x5E6B8A0", VA = "0x185E6C8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct IFEGMNFLMKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E760", Offset = "0x5E6D760", VA = "0x185E6E760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EA50", Offset = "0x5E6DA50", VA = "0x185E6EA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class JNGNJGPBDIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JNGNJGPBDIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E700D0", Offset = "0x5E6F0D0", VA = "0x185E700D0")]
		internal Task GDCIIIMDBEF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct JCFJHAGGBDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FD00", Offset = "0x5E6ED00", VA = "0x185E6FD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FF60", Offset = "0x5E6EF60", VA = "0x185E6FF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EGDOMEIPOKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BF80", Offset = "0x5E6AF80", VA = "0x185E6BF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C100", Offset = "0x5E6B100", VA = "0x185E6C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GKJKGHDPHBM<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x35883D0", Offset = "0x35873D0", VA = "0x1835883D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3588630", Offset = "0x3587630", VA = "0x183588630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KJHOPPCHMHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E70140", Offset = "0x5E6F140", VA = "0x185E70140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E70550", Offset = "0x5E6F550", VA = "0x185E70550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static SynchronizationContext? JJEMLDPGDBH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly TaskCompletionSource<DBKAPBMMCGK> HBKNNFIMBNN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static Task NAEOJGHKAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A490", Offset = "0x5E69490", VA = "0x185E6A490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B16880", Offset = "0x2B15880", VA = "0x182B16880")]
	public static Task<T> EPLAFBCELJC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A250", Offset = "0x5E69250", VA = "0x185E6A250")]
	public static Task ANADAOEDHKK(this Task NFANMEMOADP, CancellationToken PDIBILKHEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B15680", Offset = "0x2B14680", VA = "0x182B15680")]
	public static Task<TResult> ANADAOEDHKK<TResult>(this Task<TResult> NFANMEMOADP, CancellationToken PDIBILKHEBM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B15E70", Offset = "0x2B14E70", VA = "0x182B15E70")]
	public static TaskCompletionSource<TResult> ANADAOEDHKK<TResult>(this TaskCompletionSource<TResult> JHNAGPPLNOK, CancellationToken PDIBILKHEBM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B4B0", Offset = "0x5E6A4B0", VA = "0x185E6B4B0")]
	[AsyncStateMachine(typeof(HILLEGNHKBG))]
	public static void MMANFLDCAGE(this Task CDBKGKHLPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B070", Offset = "0x5E6A070", VA = "0x185E6B070")]
	[AsyncStateMachine(typeof(JJIHCNNIKOJ))]
	public static void LCMOEGCPKAK(this Task CDBKGKHLPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B162D0", Offset = "0x2B152D0", VA = "0x182B162D0")]
	[AsyncStateMachine(typeof(NDDJJLJLHHJ<>))]
	public static Task CAIPPFGBNEP<TException>(this Task CDBKGKHLPJH) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B16EF0", Offset = "0x2B15EF0", VA = "0x182B16EF0")]
	[AsyncStateMachine(typeof(DGHFFGNIENH<>))]
	public static Task<T> NFCMCNKGGPN<T>(this Task<T> IEOMMHOPOKN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AA00", Offset = "0x5E69A00", VA = "0x185E6AA00")]
	[AsyncStateMachine(typeof(CFNLMMNNIEG))]
	public static Task<TaskStatus> IHKIEMDONBN(this Task IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B163A0", Offset = "0x2B153A0", VA = "0x182B163A0")]
	public static (Task<T?>?, Action<T?>?) DHCHDLEGNHB<T>([Optional] CancellationToken JEBPNJAPHEL)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B169D0", Offset = "0x2B159D0", VA = "0x182B169D0")]
	[AsyncStateMachine(typeof(KDJFLJNILID<, >))]
	public static Task<List<TResult>> JICMHDFJJFP<TResult, TInput>(this Task<List<TInput>> NFANMEMOADP, CJHCJMOPENH<TInput, TResult> LMCJEIHNLON) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A7C0", Offset = "0x5E697C0", VA = "0x185E6A7C0")]
	[AsyncStateMachine(typeof(IJCLBNCOBJJ))]
	public static Task GEDNJLACLNL(Task CDBKGKHLPJH, CancellationToken PMLBMCIFPPF, Func<CancellationToken, Task> OBMGABPJKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AF40", Offset = "0x5E69F40", VA = "0x185E6AF40")]
	[AsyncStateMachine(typeof(KJJDJCOOODA))]
	public static Task LCCMNKJOIAC(Func<CancellationToken, Task> BCFKKGGBHOK, TimeSpan HMHJOGKKCIF, [Optional] CancellationToken PMLBMCIFPPF, [Optional] Action<OperationCanceledException>? GDDKJJKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B16C90", Offset = "0x2B15C90", VA = "0x182B16C90")]
	[AsyncStateMachine(typeof(KHGFIOGOKGD<>))]
	public static Task<T> LCCMNKJOIAC<T>(Func<CancellationToken, Task<T>> BCFKKGGBHOK, TimeSpan HMHJOGKKCIF, [Optional] CancellationToken PMLBMCIFPPF, [Optional] Func<OperationCanceledException, T>? GDDKJJKNFMB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B16BB0", Offset = "0x2B15BB0", VA = "0x182B16BB0")]
	[AsyncStateMachine(typeof(BODONNIAOAM<>))]
	public static Task<IEnumerable<Task<T>>> JKGICHHIMNK<T>(IEnumerable<Task<T>> LNIMKIHACKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B165E0", Offset = "0x2B155E0", VA = "0x182B165E0")]
	[AsyncStateMachine(typeof(CEMABDBIGDN<, , , >))]
	public static Task<(T1, T2, T3, T4)> EONGLEADKAL<T1, T2, T3, T4>(Task<T1> PJLGMFDFNKF, Task<T2> KJJBNFIECOA, Task<T3> BKHCOGKHJFB, Task<T4> BONFDCFCAAN) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A8F0", Offset = "0x5E698F0", VA = "0x185E6A8F0")]
	[AsyncStateMachine(typeof(FHHNFNJJMJK))]
	public static Task HLDJBKGEPEM(Func<bool> FJNLKDBBOPP, TimeSpan LNNNCDGJPHL, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B680", Offset = "0x5E6A680", VA = "0x185E6B680")]
	[AsyncStateMachine(typeof(GKMJMJEPBKJ))]
	public static Task NHPGNNOFEHJ(Func<bool> FJNLKDBBOPP, TimeSpan HMHJOGKKCIF, [Optional] CancellationToken JEBPNJAPHEL, [Optional] Action<OperationCanceledException>? GDDKJJKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B7B0", Offset = "0x5E6A7B0", VA = "0x185E6B7B0")]
	[AsyncStateMachine(typeof(GJEIEMPJOEK))]
	public static Task NHPGNNOFEHJ(Func<bool> FJNLKDBBOPP, TimeSpan HMHJOGKKCIF, TimeSpan LNNNCDGJPHL, [Optional] CancellationToken JEBPNJAPHEL, [Optional] Action<OperationCanceledException>? GDDKJJKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B3C0", Offset = "0x5E6A3C0", VA = "0x185E6B3C0")]
	[AsyncStateMachine(typeof(PKOLEABIJOJ))]
	public static Task MKMLKEIKAMN(Func<bool> FJNLKDBBOPP, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B2B0", Offset = "0x5E6A2B0", VA = "0x185E6B2B0")]
	[AsyncStateMachine(typeof(FOPGNEJBOHJ))]
	public static Task MKMLKEIKAMN(Func<bool> FJNLKDBBOPP, TimeSpan LNNNCDGJPHL, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A550", Offset = "0x5E69550", VA = "0x185E6A550")]
	[AsyncStateMachine(typeof(IFEGMNFLMKA))]
	public static Task BNFKHPPCNKC(Func<bool> FJNLKDBBOPP, TimeSpan HMHJOGKKCIF, [Optional] CancellationToken JEBPNJAPHEL, [Optional] Action<OperationCanceledException>? GDDKJJKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A680", Offset = "0x5E69680", VA = "0x185E6A680")]
	[AsyncStateMachine(typeof(JCFJHAGGBDI))]
	public static Task BNFKHPPCNKC(Func<bool> FJNLKDBBOPP, TimeSpan HMHJOGKKCIF, TimeSpan LNNNCDGJPHL, [Optional] CancellationToken JEBPNJAPHEL, [Optional] Action<OperationCanceledException>? GDDKJJKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A160", Offset = "0x5E69160", VA = "0x185E6A160")]
	[Obsolete]
	[AsyncStateMachine(typeof(EGDOMEIPOKC))]
	public static Task AEIGNBBADFF(this Task NFANMEMOADP, Action MLIGHOMFLND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2B13CF0", Offset = "0x2B12CF0", VA = "0x182B13CF0")]
	[Obsolete]
	[AsyncStateMachine(typeof(GKJKGHDPHBM<>))]
	public static Task AEIGNBBADFF<T>(this Task<T> NFANMEMOADP, Action<T> MLIGHOMFLND) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AAF0", Offset = "0x5E69AF0", VA = "0x185E6AAF0")]
	public static bool ILBDBPCOHPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B120", Offset = "0x5E6A120", VA = "0x185E6B120")]
	private static void MCAJMJEKKDG(SynchronizationContext APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B560", Offset = "0x5E6A560", VA = "0x185E6B560")]
	private static void NFOBPJFJEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A500", Offset = "0x5E69500", VA = "0x185E6A500")]
	public static GNOPBKFOMED BDNDNMAFFLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B8F0", Offset = "0x5E6A8F0", VA = "0x185E6B8F0")]
	public static GNOPBKFOMED ODOPEJCJDMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AE70", Offset = "0x5E69E70", VA = "0x185E6AE70")]
	[AsyncStateMachine(typeof(KJHOPPCHMHK))]
	public static Task KNKNNPBBOOA(Func<Task> CMDBLPFLCHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DCMGMDBOPDL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
	public DCMGMDBOPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HIBAPKNNPNG : GIMGCMMEAHN
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly GIMGCMMEAHN NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DateTime EDGKNJCPNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D930", Offset = "0x5E6C930", VA = "0x185E6D930", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTimeOffset EOFLMBAMMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D970", Offset = "0x5E6C970", VA = "0x185E6D970", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HIBAPKNNPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface GIMGCMMEAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DateTime EDGKNJCPNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTimeOffset EOFLMBAMMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NGPLBBCCEIC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static long HCBALMIAEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E719E0", Offset = "0x5E709E0", VA = "0x185E719E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long FCBEJCDMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E718F0", Offset = "0x5E708F0", VA = "0x185E718F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static double KAPANILNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E71780", Offset = "0x5E70780", VA = "0x185E71780")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double DLHJCAAEPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E718A0", Offset = "0x5E708A0", VA = "0x185E718A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double LKOJCOJFIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E715F0", Offset = "0x5E705F0", VA = "0x185E715F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double ADFGDMAIFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E71730", Offset = "0x5E70730", VA = "0x185E71730")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E71950", Offset = "0x5E70950", VA = "0x185E71950")]
	public static double KFOJCFODAPL(long KDMHPLPPIMA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E71640", Offset = "0x5E70640", VA = "0x185E71640")]
	public static double EAIGNJMHOML(long KDMHPLPPIMA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5E714D0", Offset = "0x5E704D0", VA = "0x185E714D0")]
	public static double ADFPLMIOPOO(double ODIGKOCAGJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E71560", Offset = "0x5E70560", VA = "0x185E71560")]
	public static long AGECIBCJFJG(long JPCFJENKEPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E71940", Offset = "0x5E70940", VA = "0x185E71940")]
	public static long JPJHGMIJONH(long NJPHFIOKOJM, long BOCFIDKLMFO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E717D0", Offset = "0x5E707D0", VA = "0x185E717D0")]
	public static double GOAEGLINGCC(long NJPHFIOKOJM, long BOCFIDKLMFO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E716D0", Offset = "0x5E706D0", VA = "0x185E716D0")]
	public static double ELBLMEDDJPN(long NJPHFIOKOJM, long BOCFIDKLMFO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class NBDFNEMIFPM : KDHLNHAGGJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly TimeSpan OFNHJDBFGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly System.Timers.Timer HCMHKMALPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private TimeSpan HMHJOGKKCIF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public TimeSpan JPJAHCNMPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E70DF0", Offset = "0x5E6FDF0", VA = "0x185E70DF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Action? IPGKPJICBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E710D0", Offset = "0x5E700D0", VA = "0x185E710D0")]
	[Preserve]
	public NBDFNEMIFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E71140", Offset = "0x5E70140", VA = "0x185E71140")]
	public NBDFNEMIFPM(TimeSpan HMHJOGKKCIF, [Optional] Action? AODINIIBPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E70D60", Offset = "0x5E6FD60", VA = "0x185E70D60", Slot = "7")]
	public void IMBOKILCADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E70FF0", Offset = "0x5E6FFF0", VA = "0x185E70FF0", Slot = "8")]
	public void NGALIKADLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E70C90", Offset = "0x5E6FC90", VA = "0x185E70C90", Slot = "9")]
	public void ANKILPBGOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xB2F300", Offset = "0xB2E300", VA = "0x180B2F300")]
	private void MPMBCBBMNCK(object GDKIMOIKOFD, ElapsedEventArgs DHLAFEDPMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E70F50", Offset = "0x5E6FF50", VA = "0x185E70F50")]
	private static void MEHFEKAIMON(TimeSpan ENBFPNKHIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E70CC0", Offset = "0x5E6FCC0", VA = "0x185E70CC0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CGBJKNJKFOC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string HEKCOHALFLG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
	public CGBJKNJKFOC(string BEOAJBBECNO)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OABCCAHIOMF : IEquatable<OABCCAHIOMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public uint COKHGHKJJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public int GEEOKLLLINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public float GKJMOAJDONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public ushort MNGDFOAPLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public ushort FGKKNNLGKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public short DJBHFJNFILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public short GAJCDBKLHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public char OAGJPNINBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public char OJIDKJMAFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public byte ANEPJALNACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte FLCJGMPDHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public byte JJMHONDAMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public byte PGEOAPANJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public bool LEMJFLJIGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool LFLLJCDEMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public bool DLNLLJDJJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public bool NAKGEPANHNN;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static OABCCAHIOMF DBNEJGJGFOH(uint FHENMFEOOFA)
	{
		return default(OABCCAHIOMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static OABCCAHIOMF NPLFOJKPDON(int POMMINCLCPL)
	{
		return default(OABCCAHIOMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E71E20", Offset = "0x5E70E20", VA = "0x185E71E20")]
	public static OABCCAHIOMF IDMLHJMBCAF(float MOJANBMGDBK)
	{
		return default(OABCCAHIOMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E71D80", Offset = "0x5E70D80", VA = "0x185E71D80")]
	public static OABCCAHIOMF EEHHPEGLDLH(byte NIKBFHDGGND, byte NPAIJLDJNKN, byte PCALDFCGFID, byte ONIAICKIDIF)
	{
		return default(OABCCAHIOMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E71D80", Offset = "0x5E70D80", VA = "0x185E71D80")]
	public static OABCCAHIOMF BJOFMIKPCPL(bool DAHMJBGALBK, bool NPHDNGABPIL, bool AAJNCOJKNOC, bool OJKHBBEAMFO)
	{
		return default(OABCCAHIOMF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x16C9AF0", Offset = "0x16C8AF0", VA = "0x1816C9AF0")]
	public static bool LICIMLDMCMN(OABCCAHIOMF LJNLOLDLJAJ, OABCCAHIOMF AHGDCNHHAHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x16C9AD0", Offset = "0x16C8AD0", VA = "0x1816C9AD0", Slot = "4")]
	public bool Equals(OABCCAHIOMF EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E71DA0", Offset = "0x5E70DA0", VA = "0x185E71DA0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x83B7D0", Offset = "0x83A7D0", VA = "0x18083B7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E71E30", Offset = "0x5E70E30", VA = "0x185E71E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KMEDLJNMMKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ulong FKCLCLIMNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public long DLNMPPPKAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public double NMAGMJDNLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint IHFPOHBBGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint DBHKHNJBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int ABOBJMOKCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int NKDJCHIGDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float OBGCMPOOCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public float AIAMOBJMGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public ushort MNGDFOAPLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ushort FGKKNNLGKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public ushort AFBPALPNFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public ushort IAPKMLHAOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public short DJBHFJNFILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public short GAJCDBKLHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public short LBBLOCAEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public short KEPGNLGDCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public char OAGJPNINBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public char OJIDKJMAFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public char PHMKBHLIKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public char LMEEGBENOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public byte ANEPJALNACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte FLCJGMPDHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte JJMHONDAMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte PGEOAPANJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte GKNOLBEBHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte ALLNBNJNLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte GBHLBFHKAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte OFKIKKAEKCG;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E70B50", Offset = "0x5E6FB50", VA = "0x185E70B50")]
	public static KMEDLJNMMKN ANBAJJBGINK(byte NIKBFHDGGND, byte NPAIJLDJNKN, byte PCALDFCGFID, byte ONIAICKIDIF, byte BHICMMKAIDP, byte CCHBCDMGGNI, byte PDKCBOCMGBJ, byte IMHBKLNMICP)
	{
		return default(KMEDLJNMMKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GDLEJNGIJNO
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x24E70A0", Offset = "0x24E60A0", VA = "0x1824E70A0")]
	public static IEnumerable<T> IMAAJAFFDLD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static T[] EHBAAPFGHNK<T>(params T[] DCMOJIFBDDD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static IEnumerable<T> BEKBIKJIFDD<T>(params T[] DCMOJIFBDDD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x24E6F40", Offset = "0x24E5F40", VA = "0x1824E6F40")]
	public static HashSet<T> NDCMNJGGEEO<T>(params T[] DCMOJIFBDDD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x24E6FB0", Offset = "0x24E5FB0", VA = "0x1824E6FB0")]
	public static KeyValuePair<TKey, TValue> GFANPGCGHAP<TKey, TValue>([In] TKey BGNGIHJEFLM, [In] TValue APPJEOKOGAK) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x24E6F40", Offset = "0x24E5F40", VA = "0x1824E6F40")]
	public static List<T> DNAEIIPDFKP<T>(IEnumerable<T> LCMMFGCFNCG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All)]
public sealed class KMAAKLKJDDG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string GEMBKCMBJFH;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
	public KMAAKLKJDDG(string BANPOACJNJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate object GDOAFDIAJGI<T>([In] T IEECDEJOFJP);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object NACDGBIBCJH<T>(T IEECDEJOFJP);
[Cpp2IlInjected.Token(Token = "0x2000053")]
[MLJNPPNNAJD]
public delegate string CNAEJDFAFAJ(string CINODLDMGAP, string? OGCJFLBKOOA, bool DMPEONHNMEM);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[MLJNPPNNAJD]
public delegate void KJJODIMKCJK(string NCBOINMNCHO);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[MLJNPPNNAJD]
public delegate void KNFKGNHKEIE(Exception GDBKEDNPKDC);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object EEKGMGGKLOL();
[Cpp2IlInjected.Token(Token = "0x2000057")]
[MLJNPPNNAJD]
public delegate bool MMNDLKAPPDC();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[MLJNPPNNAJD]
public delegate string GIPCKCHEECG(object GPCHHCACPPJ);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Enum)]
public class PCFKBGHCGJN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
	public PCFKBGHCGJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class EBIPPCDANNB
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class KMBOBDIGOIA<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly ISet<T> NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int PLKFCNLILAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x39D5AA0", Offset = "0x39D4AA0", VA = "0x1839D5AA0", Slot = "4")]
		public bool Add(T NIFCHCHHAAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
		public void IntersectWith(IEnumerable<T> EJEDDDCGMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x39D5D30", Offset = "0x39D4D30", VA = "0x1839D5D30", Slot = "5")]
		public void UnionWith(IEnumerable<T> EJEDDDCGMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x39D5BE0", Offset = "0x39D4BE0", VA = "0x1839D5BE0", Slot = "9")]
		void ICollection<T>.Add(T NIFCHCHHAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "11")]
		public bool Contains(T NIFCHCHHAAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "12")]
		public void CopyTo(T[] FHOLKIOOKFG, int FKKKLBOABKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
		public bool Remove(T NIFCHCHHAAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x39D5B60", Offset = "0x39D4B60", VA = "0x1839D5B60", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x34ABFE0", Offset = "0x34AAFE0", VA = "0x1834ABFE0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KMBOBDIGOIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB890", Offset = "0x7DA890", VA = "0x1807DB890")]
	public static ISet<T> GMEPEDDNCLG<T>() where T : notnull
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
