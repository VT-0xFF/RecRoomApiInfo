using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6363C90", Offset = "0x6362C90", VA = "0x186363C90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class PCOAICKOLJD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6364D70", Offset = "0x6363D70", VA = "0x186364D70")]
	public PCOAICKOLJD(bool PEDKNDEMGNI, string PMGMDAMDPEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class INOGANHONAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IKOPIFMNEJN<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate Task<TResult> JIPACFFJLCB(CancellationToken GHLJDIEPICD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HAILKIPBLHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public IKOPIFMNEJN<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JIPACFFJLCB taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3A00F60", Offset = "0x39FFF60", VA = "0x183A00F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A01FC0", Offset = "0x3A00FC0", VA = "0x183A01FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource EILAHEEOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? BDIDNIIIGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? CFEIGCLNAML;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A500", Offset = "0x3B09500", VA = "0x183B0A500")]
	[AsyncStateMachine(typeof(IKOPIFMNEJN<>.HAILKIPBLHL))]
	public Task<TResult> DCPNPIAEMAK(JIPACFFJLCB KFAOCLKJNJN, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A640", Offset = "0x3B09640", VA = "0x183B0A640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A6B0", Offset = "0x3B096B0", VA = "0x183B0A6B0")]
	public IKOPIFMNEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AGCKKNGPDLI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> CHBGJCPEEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T DMDNAKDAMMG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x395E0C0", Offset = "0x395D0C0", VA = "0x18395E0C0")]
	public AGCKKNGPDLI([In] T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x395D9D0", Offset = "0x395C9D0", VA = "0x18395D9D0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x395DBA0", Offset = "0x395CBA0", VA = "0x18395DBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x395DC70", Offset = "0x395CC70", VA = "0x18395DC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IKALKHPPOAN
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2774FA0", Offset = "0x2773FA0", VA = "0x182774FA0")]
	public static AGCKKNGPDLI<T> MGIIAIMPALM<T>([In] T LDGMLLMKHLF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BKDLNEBDILD
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x635D920", Offset = "0x635C920", VA = "0x18635D920")]
	public static void GPINEMDMEAH(this CancellationTokenSource EILAHEEOMFB, bool LFEIEBFEGJF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LOIJOPHPDNE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
	public LOIJOPHPDNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class MPBPOPFFKPJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
	public MPBPOPFFKPJ(string KGGLJAOPHCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OCHIFJOOBDO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A401D0", Offset = "0x2A3F1D0", VA = "0x182A401D0")]
	public static HFPNLFPGKNI HNIIGPFPDDN<T>()
	{
		return default(HFPNLFPGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A404A0", Offset = "0x2A3F4A0", VA = "0x182A404A0")]
	public static HFPNLFPGKNI KNKNAGCEGKM<T>([CallerMemberName] string ONGJKHHOIAM = "") where T : notnull
	{
		return default(HFPNLFPGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A40250", Offset = "0x2A3F250", VA = "0x182A40250")]
	public static HFPNLFPGKNI HNIIGPFPDDN<T>(this T GEJMEMCGHEN) where T : notnull
	{
		return default(HFPNLFPGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A40530", Offset = "0x2A3F530", VA = "0x182A40530")]
	public static HFPNLFPGKNI PMJAAHBGEPO<T>(this T GEJMEMCGHEN, [CallerMemberName] string ONGJKHHOIAM = "") where T : notnull
	{
		return default(HFPNLFPGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A40400", Offset = "0x2A3F400", VA = "0x182A40400")]
	public static HFPNLFPGKNI KNKNAGCEGKM<T>(this T HFLBADIEKAM, [CallerMemberName] string ONGJKHHOIAM = "") where T : notnull
	{
		return default(HFPNLFPGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6363DB0", Offset = "0x6362DB0", VA = "0x186363DB0")]
	public static HFPNLFPGKNI KNKNAGCEGKM(string DDLHPJCCOLJ, [CallerMemberName] string ONGJKHHOIAM = "")
	{
		return default(HFPNLFPGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6363D10", Offset = "0x6362D10", VA = "0x186363D10")]
	public static string DKLEBOOLCJD(this object HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate bool NJDFOGGAIDE();
[Cpp2IlInjected.Token(Token = "0x2000011")]
[LOIJOPHPDNE]
public delegate long DHCADPONHMA();
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class INMHJHHKDNI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static PCEJAFMPOIL EIEJOILALML;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PCEJAFMPOIL JBJKDDCAFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6360A70", Offset = "0x635FA70", VA = "0x186360A70")]
		get
		{
			return default(PCEJAFMPOIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HDMNFPGFPFC HDAFILMCJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6360F50", Offset = "0x635FF50", VA = "0x186360F50")]
		get
		{
			return default(HDMNFPGFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NAMEPPNGGHK ONPPEGBKGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63611F0", Offset = "0x63601F0", VA = "0x1863611F0")]
		get
		{
			return default(NAMEPPNGGHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool NKFMHHJBLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6360D40", Offset = "0x635FD40", VA = "0x186360D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6360FA0", Offset = "0x635FFA0", VA = "0x186360FA0")]
	public static void MBPGJFDCKFJ([In] PCEJAFMPOIL LMIHECICMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6360C70", Offset = "0x635FC70", VA = "0x186360C70")]
	public static void HEFADAFEBPD(string JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6360BA0", Offset = "0x635FBA0", VA = "0x186360BA0")]
	public static void GGAFDCAPOLI(string JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2928AB0", Offset = "0x2927AB0", VA = "0x182928AB0")]
	public static void GGAFDCAPOLI<T>(T OFDFAAHEGDG, LGKKPIBCJIM<T> JJJNODJJIFK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6361150", Offset = "0x6360150", VA = "0x186361150")]
	public static void MOCGDBKOOAK(Exception DNFOGIGBCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6360B40", Offset = "0x635FB40", VA = "0x186360B40")]
	public static void FAJDBLFAJCD(string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6360E80", Offset = "0x635FE80", VA = "0x186360E80")]
	public static void IPGEFLANIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6360AC0", Offset = "0x635FAC0", VA = "0x186360AC0")]
	public static string DKLEBOOLCJD(object KDEEPMDJGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6360EE0", Offset = "0x635FEE0", VA = "0x186360EE0")]
	public static long KHPBGLHAKMK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63609D0", Offset = "0x635F9D0", VA = "0x1863609D0")]
	public static bool BJBFGAINKIH(bool KOGAEBNIPPH, string JJJNODJJIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6360DB0", Offset = "0x635FDB0", VA = "0x186360DB0")]
	public static double INMJDNEEAML()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct PCEJAFMPOIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly HDMNFPGFPFC HDAFILMCJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly NAMEPPNGGHK ONPPEGBKGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly IEHOICACALB JPLMJAOJFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DHCADPONHMA ALLCNHEFLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly BLPFCMGCNLD GFBFMPHJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly NJDFOGGAIDE NGOOFJAADDC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly IEHOICACALB BGBFDPGJMAP;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DHCADPONHMA FAANGNIHFGN;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly BLPFCMGCNLD KDNDMDOHCHL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NJDFOGGAIDE BPPIJAKCOGP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly PCEJAFMPOIL LGJIMEKOCEB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JEAENFCBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6364430", Offset = "0x6363430", VA = "0x186364430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6364CC0", Offset = "0x6363CC0", VA = "0x186364CC0")]
	public PCEJAFMPOIL([In] HDMNFPGFPFC OCPBJGLAGJH, [In] NAMEPPNGGHK IHELNMOCNIN, IEHOICACALB PHLKMDKEKKK, DHCADPONHMA KHDPCFMPOLC, BLPFCMGCNLD GJKLPHDGCDB, NJDFOGGAIDE BNKBINKBJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63643F0", Offset = "0x63633F0", VA = "0x1863643F0")]
	private static string PDOBBJDIHKF(object KDEEPMDJGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0")]
	private static long LNNDGPFJPEJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	private static string ODDIPMEIFLN(string BKPGNLGJMIO, string? DOGOCHIINFI, bool ONFAPFGGFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	private static bool FMLFJNOJHCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63642E0", Offset = "0x63632E0", VA = "0x1863642E0")]
	private static PCEJAFMPOIL DGEPOOPKPKK()
	{
		return default(PCEJAFMPOIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DIIEAEMEOIP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJHKIIIHAFL KIMBMIDADNK();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JJHKIIIHAFL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IJLLMBECAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCLMOFPPMLI();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ECBLMMOEAKL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNBFHOIIMBJ([In] T JNHFAFOIKEO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate void OLDJMKCKJCM<T>([In] T OFDFAAHEGDG);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct DAEBKAFFCML<T> : IEquatable<DAEBKAFFCML<T>>, ECBLMMOEAKL<DAEBKAFFCML<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T DMDNAKDAMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int CBOGBOOIKCP;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E57D90", Offset = "0x1E56D90", VA = "0x181E57D90")]
	public DAEBKAFFCML([In] T LDGMLLMKHLF, int GPEHCABDGEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x51E0050", Offset = "0x51DF050", VA = "0x1851E0050")]
	public static bool JPKEALLKLNK([In] DAEBKAFFCML<T> LHPJOLLNMHI, [In] DAEBKAFFCML<T> MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A385C0", Offset = "0x3A375C0", VA = "0x183A385C0", Slot = "4")]
	public bool Equals(DAEBKAFFCML<T> JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x39493B0", Offset = "0x39483B0", VA = "0x1839493B0", Slot = "0")]
	public override bool Equals(object JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51DF940", Offset = "0x51DE940", VA = "0x1851DF940")]
	public bool DNBFHOIIMBJ([In] DAEBKAFFCML<T> JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51DFC30", Offset = "0x51DEC30", VA = "0x1851DFC30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51E0CE0", Offset = "0x51DFCE0", VA = "0x1851E0CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51E0840", Offset = "0x51DF840", VA = "0x1851E0840")]
	public void KNBCCAGJFOM([Out] T LDGMLLMKHLF, [Out] int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x51DF6C0", Offset = "0x51DE6C0", VA = "0x1851DF6C0")]
	public (T, int) DJAGJCMMLHO()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x51E0B50", Offset = "0x51DFB50", VA = "0x1851E0B50", Slot = "5")]
	private bool PGDBAAAJEKK([In] DAEBKAFFCML<T> JNHFAFOIKEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KHLOJBEDNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2950F20", Offset = "0x294FF20", VA = "0x182950F20")]
	public static DAEBKAFFCML<T> MGIIAIMPALM<T>([In] T LDGMLLMKHLF, int GPEHCABDGEJ) where T : notnull
	{
		return default(DAEBKAFFCML<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HHCODKFDOMJ
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28EAB20", Offset = "0x28E9B20", VA = "0x1828EAB20")]
	public static bool DNBFHOIIMBJ<T, U>([In] T HFLBADIEKAM, [In] U KDEEPMDJGFD) where T : notnull, ECBLMMOEAKL<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate TResult OPDIJMGBGKM<T, out TResult>([In] T OFDFAAHEGDG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EDHKLNMJAOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan FLDKNKJBMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? AHOGKJCEGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLLCENNIMJA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLMIPKFGBFI();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFOEKJDGKBL();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct HDMNFPGFPFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OIFBNFJKGJG MCNOMLEBNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly BBHLHPGKGJJ MCBLGKNCDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly OIFBNFJKGJG GLGHAHGCCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly BBHLHPGKGJJ FDIHEFKJGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly OIFBNFJKGJG DGFAELMGLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly BBHLHPGKGJJ AOKACABDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly PNEBPHPOKHP HLAJLILBICC;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly OIFBNFJKGJG LGPBPBLBNCG;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly BBHLHPGKGJJ LDNBMDIHKOF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly OIFBNFJKGJG BIOFNFHNDHK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly BBHLHPGKGJJ KIHAPGCEEMJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly OIFBNFJKGJG KPDFPGMACIP;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly BBHLHPGKGJJ EPAKNEAGHOH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly PNEBPHPOKHP JIAOMFDLBPA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HDMNFPGFPFC LGJIMEKOCEB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly OIFBNFJKGJG HEKCKNEIHNP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JEAENFCBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x635FE80", Offset = "0x635EE80", VA = "0x18635FE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9E04C0", Offset = "0x9DF4C0", VA = "0x1809E04C0")]
	public HDMNFPGFPFC(OIFBNFJKGJG CBANPHCEACC, BBHLHPGKGJJ CGCHLMLJFBJ, OIFBNFJKGJG BADEILGLCOH, BBHLHPGKGJJ GHEIMGAANHG, OIFBNFJKGJG PANKDKOPMED, BBHLHPGKGJJ IGNJIBAIAGE, PNEBPHPOKHP KIDFOEDAEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	private static bool DNABNECIFLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private static void IKENIPDGHBL(string JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	private static bool LJGNMJBDPBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private static void LBCBEHCPCMM(string JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	private static bool OGDLNLFNONA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private static void NJMJGMNPDIE(string JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private static void DAFNBFENDEH(Exception DNFOGIGBCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x635FB80", Offset = "0x635EB80", VA = "0x18635FB80")]
	private static HDMNFPGFPFC DGEPOOPKPKK()
	{
		return default(HDMNFPGFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
	private static bool EHAKFMIMFCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x635FE10", Offset = "0x635EE10", VA = "0x18635FE10")]
	public void HEFADAFEBPD(object JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x635FDA0", Offset = "0x635EDA0", VA = "0x18635FDA0")]
	public void GGAFDCAPOLI(object JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1A400F0", Offset = "0x1A3F0F0", VA = "0x181A400F0")]
	public void MOCGDBKOOAK(Exception DNFOGIGBCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x635FCC0", Offset = "0x635ECC0", VA = "0x18635FCC0")]
	public void GGAFDCAPOLI(AELFMPKKGLI JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28E8390", Offset = "0x28E7390", VA = "0x1828E8390")]
	public void GGAFDCAPOLI<T>(T OFDFAAHEGDG, LGKKPIBCJIM<T> JJJNODJJIFK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28E8450", Offset = "0x28E7450", VA = "0x1828E8450")]
	public void HEFADAFEBPD<T>([In] T OFDFAAHEGDG, KDPLCNCCOPH<T> JJJNODJJIFK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x635FAB0", Offset = "0x635EAB0", VA = "0x18635FAB0")]
	public bool BJBFGAINKIH(bool KOGAEBNIPPH, string JJJNODJJIFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct HFPNLFPGKNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string DMDNAKDAMMG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	public HFPNLFPGKNI(string LDGMLLMKHLF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
	public static string NCBCBLCGNHJ([In] HFPNLFPGKNI HFLBADIEKAM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x845830", Offset = "0x844830", VA = "0x180845830")]
	public static HFPNLFPGKNI NCBCBLCGNHJ(string JNHFAFOIKEO)
	{
		return default(HFPNLFPGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6360660", Offset = "0x635F660", VA = "0x186360660")]
	public string ELPFPFDOKNE(string ICGNBKPKIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x63606B0", Offset = "0x635F6B0", VA = "0x1863606B0")]
	public string KOOAJPEAKHG(object LBFBEADLMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct KLKJPNNICPF : IEquatable<KLKJPNNICPF>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "4")]
	public bool Equals(KLKJPNNICPF JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6362720", Offset = "0x6361720", VA = "0x186362720", Slot = "0")]
	public override bool Equals(object JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6362770", Offset = "0x6361770", VA = "0x186362770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6362780", Offset = "0x6361780", VA = "0x186362780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[HHGFKKBEMKA("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct HLIMGIIJKHF<T> : IEquatable<HLIMGIIJKHF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T DMDNAKDAMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool BJMJICFLFLM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FMDEDECDFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3A38450", Offset = "0x3A37450", VA = "0x183A38450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3A39700", Offset = "0x3A38700", VA = "0x183A39700")]
	public HLIMGIIJKHF([In] T LDGMLLMKHLF, bool MHIMPHJKGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3A39070", Offset = "0x3A38070", VA = "0x183A39070")]
	public static bool JPKEALLKLNK([In] HLIMGIIJKHF<T> LHPJOLLNMHI, [In] HLIMGIIJKHF<T> MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A385C0", Offset = "0x3A375C0", VA = "0x183A385C0", Slot = "4")]
	public bool Equals(HLIMGIIJKHF<T> JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3A38AE0", Offset = "0x3A37AE0", VA = "0x183A38AE0", Slot = "0")]
	public override bool Equals(object JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A38EE0", Offset = "0x3A37EE0", VA = "0x183A38EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3A393B0", Offset = "0x3A383B0", VA = "0x183A393B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class BFMDLACFGHM
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26BA0A0", Offset = "0x26B90A0", VA = "0x1826BA0A0")]
	public static HLIMGIIJKHF<T> EINHFNKOMIB<T>([In] T LDGMLLMKHLF) where T : notnull
	{
		return default(HLIMGIIJKHF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26B9F70", Offset = "0x26B8F70", VA = "0x1826B9F70")]
	public static HLIMGIIJKHF<T?> BJDKBBKMBJH<T>()
	{
		return default(HLIMGIIJKHF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26BA160", Offset = "0x26B9160", VA = "0x1826BA160")]
	public static bool PBKIPDAKJMP<T>([In] this HLIMGIIJKHF<T> PPCBGPABEFJ, [Out][NotNullWhen(true)] T LDGMLLMKHLF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct NAMEPPNGGHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr FAJDBLFAJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr IPGEFLANIJF;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr GFPCIGAMPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr MHAENCBMFEH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly NAMEPPNGGHK LGJIMEKOCEB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JEAENFCBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6363640", Offset = "0x6362640", VA = "0x186363640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
	public NAMEPPNGGHK(IntPtr NGLGHOKOCJF, IntPtr MEPNDANODLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private static void BHHLPKIKPFB(string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private static void PIDHBONPCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63635B0", Offset = "0x63625B0", VA = "0x1863635B0")]
	private static NAMEPPNGGHK DGEPOOPKPKK()
	{
		return default(NAMEPPNGGHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HAKOMKKHHGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr FPMECNJAOCA;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	private HAKOMKKHHGI(IntPtr MEPNDANODLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x635F690", Offset = "0x635E690", VA = "0x18635F690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x635F6A0", Offset = "0x635E6A0", VA = "0x18635F6A0")]
	public static HAKOMKKHHGI MGIIAIMPALM(string ONGJKHHOIAM)
	{
		return default(HAKOMKKHHGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F4B0", Offset = "0x1E3E4B0", VA = "0x181E3F4B0")]
	public static HAKOMKKHHGI MGIIAIMPALM([In] NAMEPPNGGHK IHELNMOCNIN, string ONGJKHHOIAM)
	{
		return default(HAKOMKKHHGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F3B0", Offset = "0x1E3E3B0", VA = "0x181E3F3B0")]
	public static HAKOMKKHHGI MGIIAIMPALM([In] NAMEPPNGGHK IHELNMOCNIN, Func<string> ONGJKHHOIAM)
	{
		return default(HAKOMKKHHGI);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PMFECDGFODD
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool FEEFAFIJHIJ<in TInput, TResult>(TInput BJGIJFLPNGG, [Out] TResult NIKEINPNLMA);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private sealed class PFHCHLCPPEA : DIIEAEMEOIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private sealed class OLAHMFCDHGG : JJHKIIIHAFL, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly OLAHMFCDHGG AFPJCELPLKK;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool IJLLMBECAKB
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x63640A0", Offset = "0x63630A0", VA = "0x1863640A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6364100", Offset = "0x6363100", VA = "0x186364100", Slot = "6")]
			public void OnCompleted(Action KPEFKFKJKFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
			public void BCLMOFPPMLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public OLAHMFCDHGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly PFHCHLCPPEA AFPJCELPLKK;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		private PFHCHLCPPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6364E50", Offset = "0x6363E50", VA = "0x186364E50", Slot = "4")]
		public JJHKIIIHAFL KIMBMIDADNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class PKGEHOIPCIE : DIIEAEMEOIP
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class PIAALNAPDOI : JJHKIIIHAFL, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly PIAALNAPDOI AFPJCELPLKK;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool IJLLMBECAKB
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x6364F20", Offset = "0x6363F20", VA = "0x186364F20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6364F40", Offset = "0x6363F40", VA = "0x186364F40", Slot = "6")]
			public void OnCompleted(Action KPEFKFKJKFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
			public void BCLMOFPPMLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public PIAALNAPDOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly PKGEHOIPCIE AFPJCELPLKK;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		private PKGEHOIPCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6365010", Offset = "0x6364010", VA = "0x186365010", Slot = "4")]
		public JJHKIIIHAFL KIMBMIDADNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OJAONGAACLC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OJAONGAACLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B788E0", Offset = "0x3B778E0", VA = "0x183B788E0")]
		internal void BABHIHMPEKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GNMBHNDDOLP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GNMBHNDDOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x39C7500", Offset = "0x39C6500", VA = "0x1839C7500")]
		internal void FDBFMNNDKNK(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MBGKGDNAENP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6363450", Offset = "0x6362450", VA = "0x186363450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct NGIDOLMNCMF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6363B30", Offset = "0x6362B30", VA = "0x186363B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct MAGHIGKOOGC<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4017570", Offset = "0x4016570", VA = "0x184017570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40176E0", Offset = "0x40166E0", VA = "0x1840176E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EAHCCKJIFBC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x34AB6E0", Offset = "0x34AA6E0", VA = "0x1834AB6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x34ABB20", Offset = "0x34AAB20", VA = "0x1834ABB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OEJNAMEBCAP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6363E30", Offset = "0x6362E30", VA = "0x186363E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6364030", Offset = "0x6363030", VA = "0x186364030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class AONHDMIIOHC<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AONHDMIIOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3B788E0", Offset = "0x3B778E0", VA = "0x183B788E0")]
		internal void HLPHAMKKIHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B78920", Offset = "0x3B77920", VA = "0x183B78920")]
		internal void OAEHLKHNLHB(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FGIOGCJOFGA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public FEEFAFIJHIJ<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3894340", Offset = "0x3893340", VA = "0x183894340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3894A30", Offset = "0x3893A30", VA = "0x183894A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FBLEOBAENGM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x635EC60", Offset = "0x635DC60", VA = "0x18635EC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x635F450", Offset = "0x635E450", VA = "0x18635F450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ELMEAEFKNNJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x635E370", Offset = "0x635D370", VA = "0x18635E370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x635E8B0", Offset = "0x635D8B0", VA = "0x18635E8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct OMHNOFFJOIC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x41EB150", Offset = "0x41EA150", VA = "0x1841EB150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x350BFE0", Offset = "0x350AFE0", VA = "0x18350BFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct ONNGAGDHHAA<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x41EC3E0", Offset = "0x41EB3E0", VA = "0x1841EC3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3899F30", Offset = "0x3898F30", VA = "0x183899F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct MLJKHJMNION<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x404BA90", Offset = "0x404AA90", VA = "0x18404BA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x404C770", Offset = "0x404B770", VA = "0x18404C770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KGEODGBAKJC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x63615C0", Offset = "0x63605C0", VA = "0x1863615C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x63617A0", Offset = "0x63607A0", VA = "0x1863617A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PNNBJMFDMDM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6366CC0", Offset = "0x6365CC0", VA = "0x186366CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6367030", Offset = "0x6366030", VA = "0x186367030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct EPEDPKCCLJH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x635E910", Offset = "0x635D910", VA = "0x18635E910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x635EC00", Offset = "0x635DC00", VA = "0x18635EC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BNCJIHFIFFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BNCJIHFIFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x635DA50", Offset = "0x635CA50", VA = "0x18635DA50")]
		internal Task OMBMNHBLHBN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NBEELKJOOAH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6363870", Offset = "0x6362870", VA = "0x186363870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6363AD0", Offset = "0x6362AD0", VA = "0x186363AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HNPFOPMKDHE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6360790", Offset = "0x635F790", VA = "0x186360790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6360970", Offset = "0x635F970", VA = "0x186360970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct BPLLOILACJH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x635DAC0", Offset = "0x635CAC0", VA = "0x18635DAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x635DE30", Offset = "0x635CE30", VA = "0x18635DE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct DEODCJIBCIL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x635E020", Offset = "0x635D020", VA = "0x18635E020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x635E310", Offset = "0x635D310", VA = "0x18635E310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class CBAKBDBBJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public CBAKBDBBJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x635DE90", Offset = "0x635CE90", VA = "0x18635DE90")]
		internal Task KFDPOFBPGPB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct IOIOEMGPJMP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6361300", Offset = "0x6360300", VA = "0x186361300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6361560", Offset = "0x6360560", VA = "0x186361560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct FGFJKLBCLBN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x635F4B0", Offset = "0x635E4B0", VA = "0x18635F4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x635F630", Offset = "0x635E630", VA = "0x18635F630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct PMKFLPBFJBD<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4297640", Offset = "0x4296640", VA = "0x184297640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x42978A0", Offset = "0x42968A0", VA = "0x1842978A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct LAIFNAKBHPN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x63627B0", Offset = "0x63617B0", VA = "0x1863627B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6362BC0", Offset = "0x6361BC0", VA = "0x186362BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? GLMJNKLBNDB;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<KLKJPNNICPF> GGPHAMNEGHB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task MJLGFFGFBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6365A60", Offset = "0x6364A60", VA = "0x186365A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6365F60", Offset = "0x6364F60", VA = "0x186365F60")]
	public static bool FKKFBEAILKJ(this Task BKJCIFOIBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A9D0", Offset = "0x2A599D0", VA = "0x182A5A9D0")]
	public static Task<T> MLKIECAFFNL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6365F90", Offset = "0x6364F90", VA = "0x186365F90")]
	public static Task GEBINEJHCMO(this Task BKJCIFOIBEF, CancellationToken KONODCHOCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A592A0", Offset = "0x2A582A0", VA = "0x182A592A0")]
	public static Task<TResult> GEBINEJHCMO<TResult>(this Task<TResult> BKJCIFOIBEF, CancellationToken KONODCHOCOG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A59DC0", Offset = "0x2A58DC0", VA = "0x182A59DC0")]
	public static TaskCompletionSource<TResult> GEBINEJHCMO<TResult>(this TaskCompletionSource<TResult> JOFPLCMGHII, CancellationToken KONODCHOCOG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63661F0", Offset = "0x63651F0", VA = "0x1863661F0")]
	[AsyncStateMachine(typeof(MBGKGDNAENP))]
	public static void HFIBEIMHKIM(this Task DCCCOAOAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6365EB0", Offset = "0x6364EB0", VA = "0x186365EB0")]
	[AsyncStateMachine(typeof(NGIDOLMNCMF))]
	public static void EPCBBIPLPBA(this Task DCCCOAOAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AB20", Offset = "0x2A59B20", VA = "0x182A5AB20")]
	[AsyncStateMachine(typeof(MAGHIGKOOGC<>))]
	public static Task NPJBPLGPDNK<TException>(this Task DCCCOAOAGBH) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A57250", Offset = "0x2A56250", VA = "0x182A57250")]
	[AsyncStateMachine(typeof(EAHCCKJIFBC<>))]
	public static Task<T> ADFCMCAFHGB<T>(this Task<T> HFLBADIEKAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6365DC0", Offset = "0x6364DC0", VA = "0x186365DC0")]
	[AsyncStateMachine(typeof(OEJNAMEBCAP))]
	public static Task<TaskStatus> ENKKJGANCAB(this Task HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A790", Offset = "0x2A59790", VA = "0x182A5A790")]
	public static (Task<T?>?, Action<T?>?) KJPOHACHABF<T>([Optional] CancellationToken GHLJDIEPICD)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AE90", Offset = "0x2A59E90", VA = "0x182A5AE90")]
	[AsyncStateMachine(typeof(FGIOGCJOFGA<, >))]
	public static Task<List<TResult>> PKGHNGOHGOE<TResult, TInput>(this Task<List<TInput>> BKJCIFOIBEF, FEEFAFIJHIJ<TInput, TResult> BMBHEPBCMBA) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6365290", Offset = "0x6364290", VA = "0x186365290")]
	[AsyncStateMachine(typeof(FBLEOBAENGM))]
	public static Task BFGBEDFCJGP(Task DCCCOAOAGBH, CancellationToken ICHNHGHOBPK, Func<CancellationToken, Task> AKCHMNLKHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6365160", Offset = "0x6364160", VA = "0x186365160")]
	[AsyncStateMachine(typeof(ELMEAEFKNNJ))]
	public static Task BANINICJOMC(Func<CancellationToken, Task> JKBOPINACMD, TimeSpan EHBCNAICFII, [Optional] CancellationToken ICHNHGHOBPK, [Optional] Action<OperationCanceledException>? IJNEHHLLMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2A57410", Offset = "0x2A56410", VA = "0x182A57410")]
	[AsyncStateMachine(typeof(OMHNOFFJOIC<>))]
	public static Task<T> BANINICJOMC<T>(Func<CancellationToken, Task<T>> JKBOPINACMD, TimeSpan EHBCNAICFII, [Optional] CancellationToken ICHNHGHOBPK, [Optional] Func<OperationCanceledException, T>? IJNEHHLLMNA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A6B0", Offset = "0x2A596B0", VA = "0x182A5A6B0")]
	[AsyncStateMachine(typeof(ONNGAGDHHAA<>))]
	public static Task<IEnumerable<Task<T>>> GGPJGBDDPOE<T>(IEnumerable<Task<T>> PPOPEOBJKKC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A5ABF0", Offset = "0x2A59BF0", VA = "0x182A5ABF0")]
	[AsyncStateMachine(typeof(MLJKHJMNION<, , , >))]
	public static Task<(T1, T2, T3, T4)> PIAHCINCENA<T1, T2, T3, T4>(Task<T1> BODHCMAGMOA, Task<T2> OKCFHAECKND, Task<T3> GIGKOJEBBFM, Task<T4> FADGDDOHMBM) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63666F0", Offset = "0x63656F0", VA = "0x1863666F0")]
	[AsyncStateMachine(typeof(KGEODGBAKJC))]
	public static Task MPEDCKGKCJD(Func<bool> KOGAEBNIPPH, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x63665E0", Offset = "0x63655E0", VA = "0x1863665E0")]
	[AsyncStateMachine(typeof(PNNBJMFDMDM))]
	public static Task MPEDCKGKCJD(Func<bool> KOGAEBNIPPH, TimeSpan FMIBCPDOGGA, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63662A0", Offset = "0x63652A0", VA = "0x1863662A0")]
	[AsyncStateMachine(typeof(EPEDPKCCLJH))]
	public static Task IALFKDFAEOA(Func<bool> KOGAEBNIPPH, TimeSpan EHBCNAICFII, [Optional] CancellationToken GHLJDIEPICD, [Optional] Action<OperationCanceledException>? IJNEHHLLMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63663D0", Offset = "0x63653D0", VA = "0x1863663D0")]
	[AsyncStateMachine(typeof(NBEELKJOOAH))]
	public static Task IALFKDFAEOA(Func<bool> KOGAEBNIPPH, TimeSpan EHBCNAICFII, TimeSpan FMIBCPDOGGA, [Optional] CancellationToken GHLJDIEPICD, [Optional] Action<OperationCanceledException>? IJNEHHLLMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6365CD0", Offset = "0x6364CD0", VA = "0x186365CD0")]
	[AsyncStateMachine(typeof(HNPFOPMKDHE))]
	public static Task ENINKDGAMDI(Func<bool> KOGAEBNIPPH, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6365BC0", Offset = "0x6364BC0", VA = "0x186365BC0")]
	[AsyncStateMachine(typeof(BPLLOILACJH))]
	public static Task ENINKDGAMDI(Func<bool> KOGAEBNIPPH, TimeSpan FMIBCPDOGGA, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6365500", Offset = "0x6364500", VA = "0x186365500")]
	[AsyncStateMachine(typeof(DEODCJIBCIL))]
	public static Task BKHFBFELIDD(Func<bool> KOGAEBNIPPH, TimeSpan EHBCNAICFII, [Optional] CancellationToken GHLJDIEPICD, [Optional] Action<OperationCanceledException>? IJNEHHLLMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x63653C0", Offset = "0x63643C0", VA = "0x1863653C0")]
	[AsyncStateMachine(typeof(IOIOEMGPJMP))]
	public static Task BKHFBFELIDD(Func<bool> KOGAEBNIPPH, TimeSpan EHBCNAICFII, TimeSpan FMIBCPDOGGA, [Optional] CancellationToken GHLJDIEPICD, [Optional] Action<OperationCanceledException>? IJNEHHLLMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6365AD0", Offset = "0x6364AD0", VA = "0x186365AD0")]
	[AsyncStateMachine(typeof(FGFJKLBCLBN))]
	[Obsolete]
	public static Task DFKBDBJMNMO(this Task BKJCIFOIBEF, Action MHGAIFPMLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A57670", Offset = "0x2A56670", VA = "0x182A57670")]
	[AsyncStateMachine(typeof(PMKFLPBFJBD<>))]
	[Obsolete]
	public static Task DFKBDBJMNMO<T>(this Task<T> BKJCIFOIBEF, Action<T> MHGAIFPMLJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63659B0", Offset = "0x63649B0", VA = "0x1863659B0")]
	private static void CHNCAPMPMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6365630", Offset = "0x6364630", VA = "0x186365630")]
	public static bool CFIGENOJKEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6366A70", Offset = "0x6365A70", VA = "0x186366A70")]
	private static void PDAFECAEBAG(SynchronizationContext LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6366830", Offset = "0x6365830", VA = "0x186366830")]
	private static void OGLEONONGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x63669A0", Offset = "0x63659A0", VA = "0x1863669A0")]
	public static void OJOFJMIOICJ([Optional] string? JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x63650E0", Offset = "0x63640E0", VA = "0x1863650E0")]
	public static void AGOLLMJJOIP([Optional] string? JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x63667E0", Offset = "0x63657E0", VA = "0x1863667E0")]
	public static DIIEAEMEOIP MPLKFAAOFEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6366950", Offset = "0x6365950", VA = "0x186366950")]
	public static DIIEAEMEOIP OJEJLBOALBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6366510", Offset = "0x6365510", VA = "0x186366510")]
	[AsyncStateMachine(typeof(LAIFNAKBHPN))]
	public static Task IJFIGMMIAKF(Func<Task> DCLBDAHBMFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GMMEGLMLLJK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
	public GMMEGLMLLJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CODLAOOLAMP : PHHLODGHAPM
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly PHHLODGHAPM AFPJCELPLKK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime OKCIFMNOMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x635DF60", Offset = "0x635CF60", VA = "0x18635DF60", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset EAEHCEPJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x635DF00", Offset = "0x635CF00", VA = "0x18635DF00", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CODLAOOLAMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface PHHLODGHAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime OKCIFMNOMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset EAEHCEPJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LFEJCAAMCGO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long PNGBLFKEMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6362E60", Offset = "0x6361E60", VA = "0x186362E60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long LEGIICMMDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6363130", Offset = "0x6362130", VA = "0x186363130")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double NBKIKAAMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6362FA0", Offset = "0x6361FA0", VA = "0x186362FA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double OGHCKIHPNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6362EC0", Offset = "0x6361EC0", VA = "0x186362EC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double NKOICANFEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6362C20", Offset = "0x6361C20", VA = "0x186362C20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LEIIPGABCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x63630E0", Offset = "0x63620E0", VA = "0x1863630E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6362D40", Offset = "0x6361D40", VA = "0x186362D40")]
	public static double FBAEDIBIMIK(long AALHAPCFJCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6362F10", Offset = "0x6361F10", VA = "0x186362F10")]
	public static double JFMGMGJDDLL(long AALHAPCFJCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6362DD0", Offset = "0x6361DD0", VA = "0x186362DD0")]
	public static double FLLKBGEEDDO(double BHLJJIFLPHN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6363050", Offset = "0x6362050", VA = "0x186363050")]
	public static long MFFAMADKIBB(long FHPCLBOOPLN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6362EB0", Offset = "0x6361EB0", VA = "0x186362EB0")]
	public static long GDLKIACMONH(long EIMJLEIAGMJ, long FDMNHLLOFMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6362C70", Offset = "0x6361C70", VA = "0x186362C70")]
	public static double EHELPNBDHBC(long EIMJLEIAGMJ, long FDMNHLLOFMK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6362FF0", Offset = "0x6361FF0", VA = "0x186362FF0")]
	public static double LNBLJECLCLA(long EIMJLEIAGMJ, long FDMNHLLOFMK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class APMPBJOAJCP : EDHKLNMJAOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan IPENBHACLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer OCBBLMCOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan EHBCNAICFII;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan FLDKNKJBMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x635D2C0", Offset = "0x635C2C0", VA = "0x18635D2C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? AHOGKJCEGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x635D660", Offset = "0x635C660", VA = "0x18635D660")]
	[Preserve]
	public APMPBJOAJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x635D6D0", Offset = "0x635C6D0", VA = "0x18635D6D0")]
	public APMPBJOAJCP(TimeSpan EHBCNAICFII, [Optional] Action? EBELJBCJBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x635D560", Offset = "0x635C560", VA = "0x18635D560", Slot = "7")]
	public void MLLCENNIMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x635D420", Offset = "0x635C420", VA = "0x18635D420", Slot = "8")]
	public void GLMIPKFGBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x635D490", Offset = "0x635C490", VA = "0x18635D490", Slot = "9")]
	public void IFOEKJDGKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xC3B6D0", Offset = "0xC3A6D0", VA = "0x180C3B6D0")]
	private void GJJODPJDBDM(object GEJMEMCGHEN, ElapsedEventArgs KCOGOJFDJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x635D4C0", Offset = "0x635C4C0", VA = "0x18635D4C0")]
	private static void LJIPCBMAPNM(TimeSpan PKEGHODJHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x635D220", Offset = "0x635C220", VA = "0x18635D220", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class HHGFKKBEMKA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string? FEICJBKNNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string NOJHAHGILOH;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5E62350", Offset = "0x5E61350", VA = "0x185E62350")]
	public HHGFKKBEMKA(string OCBNPBFKEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x20033E0", Offset = "0x20023E0", VA = "0x1820033E0")]
	public HHGFKKBEMKA(string KHOLDKJFPPN, string OCBNPBFKEJE)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KHKHDENPCDD : IEquatable<KHKHDENPCDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public uint MPGAMEPHFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public int KHPGPBJAAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float KOGGJLJGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort JGIMDIJCOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public ushort FHIJOBFHCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short IKJEKKDKEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public short JMGNGGDACJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char BNEMENEOJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public char OBJANLPCAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte GIOABCJJOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte JBIBJAAIIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte DEGBGMDDIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte KOMADDJDAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool BHLHPNCCAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool BMBHDCEABAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool DNNNKMFJDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool CKGIJLGPNHM;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0xD80700", Offset = "0xD7F700", VA = "0x180D80700")]
	public static KHKHDENPCDD LDMJNGNANEE(uint BCDHIBAKFDL)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xD80700", Offset = "0xD7F700", VA = "0x180D80700")]
	public static KHKHDENPCDD NHPODAGFHFO(int OBDKDHBELDB)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x63618B0", Offset = "0x63608B0", VA = "0x1863618B0")]
	public static KHKHDENPCDD FLLDKPIFPDB(float JEPFFBAMFGK)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6361800", Offset = "0x6360800", VA = "0x186361800")]
	public static KHKHDENPCDD PEBAEEABNDP(byte PDGAPBIIOBB, byte DDLFIKNDAHJ, byte ODGEJGJCHIH, byte HACEKGHFFCI)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6361800", Offset = "0x6360800", VA = "0x186361800")]
	public static KHKHDENPCDD DFHHNEJEDKL(bool PFKCECDJPIB, bool HMFKIKCBJJK, bool FJNKDHMHIBP, bool CFBDNFHBMGF)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6361800", Offset = "0x6360800", VA = "0x186361800")]
	public static KHKHDENPCDD FBEIFKOADBC(byte EADJGHBFBFG, byte GNBNJIIOBNI, byte ILEJBLKGPKB, byte IJKBALECOEG)
	{
		return default(KHKHDENPCDD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x189A820", Offset = "0x1899820", VA = "0x18189A820")]
	public static bool JPKEALLKLNK(KHKHDENPCDD LEGDDGHJEMC, KHKHDENPCDD KNJHKKJANOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x895C90", Offset = "0x894C90", VA = "0x180895C90", Slot = "4")]
	public bool Equals(KHKHDENPCDD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6361820", Offset = "0x6360820", VA = "0x186361820", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x942C10", Offset = "0x941C10", VA = "0x180942C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x63618C0", Offset = "0x63608C0", VA = "0x1863618C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct NKAICCEKLED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public ulong HLBDLAHKEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public long GNKEGCAEHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public double OPOGBBKCPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint JNAPKHAFAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint PFGKCPFKNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int DJMBNIPEGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int CBOAOMLGDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float DOKDGPPFLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float KPNJANGKDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort JGIMDIJCOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort FHIJOBFHCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort ONFKNOKNJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort FOKMCFGHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short IKJEKKDKEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short JMGNGGDACJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short NJMMHFAOLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short HINKBHCAJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char BNEMENEOJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char OBJANLPCAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char GDCKFBIDNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char PJGMIIGBKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte GIOABCJJOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte JBIBJAAIIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte DEGBGMDDIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte KOMADDJDAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte NJBMDKBALGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte ECNHMPNKKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte FNPOCBDPAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte JMLAKKKMDEE;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6363C40", Offset = "0x6362C40", VA = "0x186363C40")]
	public static NKAICCEKLED MGIIAIMPALM(byte PDGAPBIIOBB, byte DDLFIKNDAHJ, byte ODGEJGJCHIH, byte HACEKGHFFCI, byte ICDFMEFGHGM, byte NAFCKPCHMNL, byte MILIGPJBNEC, byte DELBBBAKOKO)
	{
		return default(NKAICCEKLED);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct HCNGCDCHFAJ : IEquatable<HCNGCDCHFAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte AMEPKPNENNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool MPNFECOMAOI;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x23AA470", Offset = "0x23A9470", VA = "0x1823AA470")]
	public static HCNGCDCHFAJ PEBAEEABNDP(byte LIJIGPJOHLG)
	{
		return default(HCNGCDCHFAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x23AA470", Offset = "0x23A9470", VA = "0x1823AA470")]
	public static HCNGCDCHFAJ DFHHNEJEDKL(bool LPGLLHIDELL)
	{
		return default(HCNGCDCHFAJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x635F830", Offset = "0x635E830", VA = "0x18635F830")]
	public static bool JPKEALLKLNK(HCNGCDCHFAJ LEGDDGHJEMC, HCNGCDCHFAJ KNJHKKJANOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x55990C0", Offset = "0x55980C0", VA = "0x1855990C0", Slot = "4")]
	public bool Equals(HCNGCDCHFAJ JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x635F790", Offset = "0x635E790", VA = "0x18635F790", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x635F820", Offset = "0x635E820", VA = "0x18635F820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x635F840", Offset = "0x635E840", VA = "0x18635F840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class LDPHDFMLCOM<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly T CFDOEALHKMI;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3E23850", Offset = "0x3E22850", VA = "0x183E23850")]
	public LDPHDFMLCOM(T AIMJIFPLANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class KGPMGNGBHIM
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x28E8370", Offset = "0x28E7370", VA = "0x1828E8370")]
	public static IEnumerable<T> NPDAOMPAOAE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static T[] NOEDKHFGPBP<T>(params T[] JNHNEEEMGNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static IEnumerable<T> GMDHBHOMAOG<T>(params T[] JNHNEEEMGNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2774FA0", Offset = "0x2773FA0", VA = "0x182774FA0")]
	public static HashSet<T> BFOIILDJBNE<T>(params T[] JNHNEEEMGNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2950DA0", Offset = "0x294FDA0", VA = "0x182950DA0")]
	public static KeyValuePair<TKey, TValue> DEPJGEEMMNH<TKey, TValue>([In] TKey OHNEPKBBADL, [In] TValue LDGMLLMKHLF) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2774FA0", Offset = "0x2773FA0", VA = "0x182774FA0")]
	public static List<T> GCEOHHKMKMN<T>(IEnumerable<T> DCGPAEFOGCA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All)]
public sealed class LNAPCDCOFGN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly string IIFJCPOEHIO;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
	public LNAPCDCOFGN(string JBHABPPCPJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object KDPLCNCCOPH<T>([In] T JMCMGAGCLNF);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object LGKKPIBCJIM<T>(T JMCMGAGCLNF);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[LOIJOPHPDNE]
public delegate string BLPFCMGCNLD(string BKPGNLGJMIO, string? DOGOCHIINFI, bool ONFAPFGGFFA);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[LOIJOPHPDNE]
public delegate void BBHLHPGKGJJ(string JJJNODJJIFK);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[LOIJOPHPDNE]
public delegate void PNEBPHPOKHP(Exception DNFOGIGBCCD);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object AELFMPKKGLI();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[LOIJOPHPDNE]
public delegate bool OIFBNFJKGJG();
[Cpp2IlInjected.Token(Token = "0x200005C")]
[LOIJOPHPDNE]
public delegate string IEHOICACALB(object KDEEPMDJGFD);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AttributeUsage(AttributeTargets.Enum)]
public class JEBPCKLDLOA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
	public JEBPCKLDLOA()
	{
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
