using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A81530", Offset = "0x6A7FB30", VA = "0x186A81530")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PCPJLJBMPMI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A81870", Offset = "0x6A7FE70", VA = "0x186A81870")]
	public static string MIJBLGOAGIO(this Encoding KOPHPPAFFFL, [In] ReadOnlySequence<byte> CNNPIMPOGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A4F0", Offset = "0x2D08AF0", VA = "0x182D0A4F0")]
	private static void EGEPKNGDPNC<T>(this ReadOnlySequence<T> EKOPIDBFEPE, [Out] ReadOnlySpan<T> JFLPMFHFDJD, [Out] SequencePosition IPGBLLOICJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class LPOKBPFBNKE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FF30", Offset = "0x6A7E530", VA = "0x186A7FF30")]
	public LPOKBPFBNKE(bool JPJKACCDJLB, string FOCBAKHBAMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LMGEDOIDDFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AKPBKMKMPKL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KEKMMPHMAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHJDPMDBPIE(string MNBFPOFIDHA, double FEBGGALLBNN, [Optional] string? CIOJKBCHPFE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OMGFBICBAJD<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> HHNCJBKOBCM(CancellationToken NNGMAHIDECE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CLAJBGFHMAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public OMGFBICBAJD<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HHNCJBKOBCM taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x50C00F0", Offset = "0x50BE6F0", VA = "0x1850C00F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50C1230", Offset = "0x50BF830", VA = "0x1850C1230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource NIGBFOEDEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? GJGJCOJKGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? OBEGHCFMBLM;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4730BC0", Offset = "0x472F1C0", VA = "0x184730BC0")]
	[AsyncStateMachine(typeof(OMGFBICBAJD<>.CLAJBGFHMAJ))]
	public Task<TResult> HGBGMDHDGKH(HHNCJBKOBCM MNBGFACFFOG, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4730B50", Offset = "0x472F150", VA = "0x184730B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4730D10", Offset = "0x472F310", VA = "0x184730D10")]
	public OMGFBICBAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class EENACNDBFCG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> HCLEKFBGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T MDPJKNKDANF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D30", Offset = "0x37E8330", VA = "0x1837E9D30")]
	public EENACNDBFCG([In] T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37E9190", Offset = "0x37E7790", VA = "0x1837E9190", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37E9690", Offset = "0x37E7C90", VA = "0x1837E9690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37E9760", Offset = "0x37E7D60", VA = "0x1837E9760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JLPJNMPENDP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2973880", Offset = "0x2971E80", VA = "0x182973880")]
	public static EENACNDBFCG<T> NKOJKFHACJH<T>([In] T FEBGGALLBNN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CODBONHDLKD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A78830", Offset = "0x6A76E30", VA = "0x186A78830")]
	public static void CGPCMJNNBNM(this CancellationTokenSource NIGBFOEDEML, bool JLHLODMMGGG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class EPPKEEOFFDN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
	public EPPKEEOFFDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class JOGPDABBCMG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
	public JOGPDABBCMG(string GFJHNAFPHDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KBMNNFDEAFI
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C02650", Offset = "0x2C00C50", VA = "0x182C02650")]
	public static EDOLANCNCJN EODIAPGDBCN<T>()
	{
		return default(EDOLANCNCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C024B0", Offset = "0x2C00AB0", VA = "0x182C024B0")]
	public static EDOLANCNCJN ECOMJPIDCBK<T>([CallerMemberName] string LGJDNDBECCI = "") where T : notnull
	{
		return default(EDOLANCNCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C026D0", Offset = "0x2C00CD0", VA = "0x182C026D0")]
	public static EDOLANCNCJN EODIAPGDBCN<T>(this T CEBMDGFHLLP) where T : notnull
	{
		return default(EDOLANCNCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C02750", Offset = "0x2C00D50", VA = "0x182C02750")]
	public static EDOLANCNCJN JPFALDABCPJ<T>(this T CEBMDGFHLLP, [CallerMemberName] string LGJDNDBECCI = "") where T : notnull
	{
		return default(EDOLANCNCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C02400", Offset = "0x2C00A00", VA = "0x182C02400")]
	public static EDOLANCNCJN ECOMJPIDCBK<T>(this T ELMHNMGFNPC, [CallerMemberName] string LGJDNDBECCI = "") where T : notnull
	{
		return default(EDOLANCNCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F510", Offset = "0x6A7DB10", VA = "0x186A7F510")]
	public static EDOLANCNCJN ECOMJPIDCBK(string OAPKMOHGKPL, [CallerMemberName] string LGJDNDBECCI = "")
	{
		return default(EDOLANCNCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F470", Offset = "0x6A7DA70", VA = "0x186A7F470")]
	public static string ANOBCOALCAO(this object ELMHNMGFNPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool OMCGFIKMEFG();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[EPPKEEOFFDN]
public delegate long CIHEEANAENG();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CPKIMBMGLBE
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static EKIEIKBPBOF LONAHNPLOJN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EKIEIKBPBOF JBPFAGCEMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A78C70", Offset = "0x6A77270", VA = "0x186A78C70")]
		get
		{
			return default(EKIEIKBPBOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MBJKCKFJKGI DCJAKAOAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A78D90", Offset = "0x6A77390", VA = "0x186A78D90")]
		get
		{
			return default(MBJKCKFJKGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HOOGKFLMCLH ADJAPKFEOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A78DE0", Offset = "0x6A773E0", VA = "0x186A78DE0")]
		get
		{
			return default(HOOGKFLMCLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool EELHDEOMGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A78AE0", Offset = "0x6A770E0", VA = "0x186A78AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A788D0", Offset = "0x6A76ED0", VA = "0x186A788D0")]
	public static void CBPNCCIDCJG([In] EKIEIKBPBOF GDOPCFFCAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A78CC0", Offset = "0x6A772C0", VA = "0x186A78CC0")]
	public static void FFHOJNCMEGD(string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A78E30", Offset = "0x6A77430", VA = "0x186A78E30")]
	public static void INDCCLFJMDJ(string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29737C0", Offset = "0x2971DC0", VA = "0x1829737C0")]
	public static void INDCCLFJMDJ<T>(T BBMJLAKPCGK, POBIMLFGMGA<T> DICMABMCPKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A78BD0", Offset = "0x6A771D0", VA = "0x186A78BD0")]
	public static void DADPKOPNCNH(Exception KLEFNMOCNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A78B50", Offset = "0x6A77150", VA = "0x186A78B50")]
	public static void CNLKJPHCGLK(string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A78A70", Offset = "0x6A77070", VA = "0x186A78A70")]
	public static void CLOHGKOIHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A78860", Offset = "0x6A76E60", VA = "0x186A78860")]
	public static string ANOBCOALCAO(object CDBNFNMIHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A78FA0", Offset = "0x6A775A0", VA = "0x186A78FA0")]
	public static long LAOHOLFACEE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A78F00", Offset = "0x6A77500", VA = "0x186A78F00")]
	public static bool JDEIFNBCFMC(bool LECPJGKPNPA, string DICMABMCPKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A79010", Offset = "0x6A77610", VA = "0x186A79010")]
	public static double ONEJDBHEMDJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct EKIEIKBPBOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly MBJKCKFJKGI DCJAKAOAHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly HOOGKFLMCLH ADJAPKFEOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly NGAFLPHBIGF IDCFOHIIJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly CIHEEANAENG CKOEHKIALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly LIJJFOLFMEI BCIKDLDGHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly OMCGFIKMEFG HGEDGKJBJPD;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NGAFLPHBIGF LMKAEAAHCOJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly CIHEEANAENG CEFJOABOGBN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly LIJJFOLFMEI CCOPOGJDICB;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly OMCGFIKMEFG ILILNLFINDB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly EKIEIKBPBOF IJMGMBPJJCI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BNJOFFCHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6A79EF0", Offset = "0x6A784F0", VA = "0x186A79EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A740", Offset = "0x6A78D40", VA = "0x186A7A740")]
	public EKIEIKBPBOF([In] MBJKCKFJKGI HCODABGJAMB, [In] HOOGKFLMCLH OOBOHIGMGOM, NGAFLPHBIGF GMEOMHKAPOH, CIHEEANAENG ICALKDLIFJP, LIJJFOLFMEI GCFBNBLDDPE, OMCGFIKMEFG KLDAIDNFAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A79EB0", Offset = "0x6A784B0", VA = "0x186A79EB0")]
	private static string IGMFHJHAMJF(object CDBNFNMIHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0")]
	private static long EMDHLAEIMAO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	private static string PNDJANLJBFE(string GCCBDCNGFBP, string? CJCGEMBCKKP, bool DOHMMMDNICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	private static bool IAPOGFFFLAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A79DB0", Offset = "0x6A783B0", VA = "0x186A79DB0")]
	private static EKIEIKBPBOF HDGLIHNBEFD()
	{
		return default(EKIEIKBPBOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EEHFCJDALBM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MANFLJHPBCN FLHBGNMEBOM();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MANFLJHPBCN : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CBHOFFDJBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOICIHMECBN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JLMFENJHCPD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFENCMHGJBG([In] T OGEIJLCLBIC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void GEHMOCFABBG<T>([In] T BBMJLAKPCGK);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct CJELOPIEJLI<T> : IEquatable<CJELOPIEJLI<T>>, JLMFENJHCPD<CJELOPIEJLI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T MDPJKNKDANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int JPOHIBGABMB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2005E80", Offset = "0x2004480", VA = "0x182005E80")]
	public CJELOPIEJLI([In] T FEBGGALLBNN, int EBDMAJMOJLN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x50BC180", Offset = "0x50BA780", VA = "0x1850BC180")]
	public static bool MLHBCNDBLOI([In] CJELOPIEJLI<T> GKFLJIIICHM, [In] CJELOPIEJLI<T> GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD310", Offset = "0x3DFB910", VA = "0x183DFD310", Slot = "4")]
	public bool Equals(CJELOPIEJLI<T> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C05F60", Offset = "0x3C04560", VA = "0x183C05F60", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x50BB580", Offset = "0x50B9B80", VA = "0x1850BB580")]
	public bool DFENCMHGJBG([In] CJELOPIEJLI<T> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x50BB760", Offset = "0x50B9D60", VA = "0x1850BB760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x50BCCE0", Offset = "0x50BB2E0", VA = "0x1850BCCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50BC540", Offset = "0x50BAB40", VA = "0x1850BC540")]
	public void NFDKAIMDEJH([Out] T FEBGGALLBNN, [Out] int EBDMAJMOJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50BBC60", Offset = "0x50BA260", VA = "0x1850BBC60")]
	public (T, int) HPKPEBDGJMB()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x50BB530", Offset = "0x50B9B30", VA = "0x1850BB530", Slot = "5")]
	private bool BKBFLIMEGJM([In] CJELOPIEJLI<T> OGEIJLCLBIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EIJOHEGFJFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29F62C0", Offset = "0x29F48C0", VA = "0x1829F62C0")]
	public static CJELOPIEJLI<T> NKOJKFHACJH<T>([In] T FEBGGALLBNN, int EBDMAJMOJLN) where T : notnull
	{
		return default(CJELOPIEJLI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DNEGLHILPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29ADDB0", Offset = "0x29AC3B0", VA = "0x1829ADDB0")]
	public static bool DFENCMHGJBG<T, U>([In] T ELMHNMGFNPC, [In] U CDBNFNMIHPK) where T : notnull, JLMFENJHCPD<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult KFNJKFBDHNG<T, out TResult>([In] T BBMJLAKPCGK);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HANHEIIAPMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan PDLEKHHDJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? HHJOFABKPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNIJFILABEH();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ELEENGCCFGG();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLEFALBLLKB();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct MBJKCKFJKGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly EFPLEJCNHHB FEMEIABLDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly GOMEIKAFPOD APLPMPAMEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly EFPLEJCNHHB HMBMBONGJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly GOMEIKAFPOD NKCNFOILPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly EFPLEJCNHHB EKHEBKGIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly GOMEIKAFPOD IPLELIGDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly EBLHKABIKMB HMAGHCBBFLI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly EFPLEJCNHHB CKOGNKNPHOA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly GOMEIKAFPOD DCAMNGNHKGE;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly EFPLEJCNHHB ADLPNDNJMDK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly GOMEIKAFPOD MKLPMOCEOJP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly EFPLEJCNHHB AKAACHJOHMI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GOMEIKAFPOD LJOEBOBFAGA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EBLHKABIKMB LLFKBCCOKLM;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly MBJKCKFJKGI IJMGMBPJJCI;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly EFPLEJCNHHB GJNBJAGAPGG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BNJOFFCHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A80490", Offset = "0x6A7EA90", VA = "0x186A80490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xC29B60", Offset = "0xC28160", VA = "0x180C29B60")]
	public MBJKCKFJKGI(EFPLEJCNHHB FNNMEGGKFIB, GOMEIKAFPOD DKHHIKFILLE, EFPLEJCNHHB HGMIKCDBEEJ, GOMEIKAFPOD MJPMMHPBHCI, EFPLEJCNHHB FDOIKDFNAMO, GOMEIKAFPOD NIHLHNEEDCE, EBLHKABIKMB KAEPFMIIGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	private static bool FOMMIKGJHFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void GAHCDELMCPH(string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	private static bool JJKMIGIIJNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void FBCCMJBDOAK(string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	private static bool JICHIMLOMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void IDGNDBOFPGH(string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void FHJCJKKBLKH(Exception KLEFNMOCNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A80130", Offset = "0x6A7E730", VA = "0x186A80130")]
	private static MBJKCKFJKGI HDGLIHNBEFD()
	{
		return default(MBJKCKFJKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
	private static bool EAIELDDMKFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A800C0", Offset = "0x6A7E6C0", VA = "0x186A800C0")]
	public void FFHOJNCMEGD(object DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A80270", Offset = "0x6A7E870", VA = "0x186A80270")]
	public void INDCCLFJMDJ(object DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1CDDE40", Offset = "0x1CDC440", VA = "0x181CDDE40")]
	public void DADPKOPNCNH(Exception KLEFNMOCNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A802E0", Offset = "0x6A7E8E0", VA = "0x186A802E0")]
	public void INDCCLFJMDJ(DDEKBOLDDDF DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C46A90", Offset = "0x2C45090", VA = "0x182C46A90")]
	public void INDCCLFJMDJ<T>(T BBMJLAKPCGK, POBIMLFGMGA<T> DICMABMCPKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2C46750", Offset = "0x2C44D50", VA = "0x182C46750")]
	public void FFHOJNCMEGD<T>([In] T BBMJLAKPCGK, LBPODIJBGLK<T> DICMABMCPKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2C468F0", Offset = "0x2C44EF0", VA = "0x182C468F0")]
	public void INDCCLFJMDJ<T>([In] T BBMJLAKPCGK, LBPODIJBGLK<T> DICMABMCPKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A803C0", Offset = "0x6A7E9C0", VA = "0x186A803C0")]
	public bool JDEIFNBCFMC(bool LECPJGKPNPA, string DICMABMCPKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct EDOLANCNCJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string MDPJKNKDANF;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	public EDOLANCNCJN(string FEBGGALLBNN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10")]
	public static string IHCIOHJGPAF([In] EDOLANCNCJN ELMHNMGFNPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA54FA0", Offset = "0xA535A0", VA = "0x180A54FA0")]
	public static EDOLANCNCJN IHCIOHJGPAF(string OGEIJLCLBIC)
	{
		return default(EDOLANCNCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A79D60", Offset = "0x6A78360", VA = "0x186A79D60")]
	public string NNKMOFEEPHI(string OCILOLICNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A79C80", Offset = "0x6A78280", VA = "0x186A79C80")]
	public string AALLNCPHPGL(object GABAMDMDCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct DHABIOOJNOJ : IEquatable<DHABIOOJNOJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "4")]
	public bool Equals(DHABIOOJNOJ OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A79300", Offset = "0x6A77900", VA = "0x186A79300", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A79350", Offset = "0x6A77950", VA = "0x186A79350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A79360", Offset = "0x6A77960", VA = "0x186A79360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[FJLOFHOEGHN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct IABIEENJMAD<T> : IEquatable<IABIEENJMAD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T MDPJKNKDANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool FCALCHOOFLF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NGOFKPLEALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD180", Offset = "0x3DFB780", VA = "0x183DFD180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE3C0", Offset = "0x3DFC9C0", VA = "0x183DFE3C0")]
	public IABIEENJMAD([In] T FEBGGALLBNN, bool LBJEOLDBIOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDE30", Offset = "0x3DFC430", VA = "0x183DFDE30")]
	public static bool MLHBCNDBLOI([In] IABIEENJMAD<T> GKFLJIIICHM, [In] IABIEENJMAD<T> GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD310", Offset = "0x3DFB910", VA = "0x183DFD310", Slot = "4")]
	public bool Equals(IABIEENJMAD<T> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD630", Offset = "0x3DFBC30", VA = "0x183DFD630", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD930", Offset = "0x3DFBF30", VA = "0x183DFD930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE180", Offset = "0x3DFC780", VA = "0x183DFE180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GOONFAAOFEB
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B79B50", Offset = "0x2B78150", VA = "0x182B79B50")]
	public static IABIEENJMAD<T> KMPCFGIKPJL<T>([In] T FEBGGALLBNN) where T : notnull
	{
		return default(IABIEENJMAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B79C60", Offset = "0x2B78260", VA = "0x182B79C60")]
	public static IABIEENJMAD<T?> LPCAFJOPCBL<T>()
	{
		return default(IABIEENJMAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B79DA0", Offset = "0x2B783A0", VA = "0x182B79DA0")]
	public static bool NOMDAHNIKNM<T>([In] this IABIEENJMAD<T> CIALEDOHLJF, [Out][NotNullWhen(true)] T FEBGGALLBNN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct HOOGKFLMCLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr CNLKJPHCGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr CLOHGKOIHGB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr BFFNKLPCIII;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr KFKGMAIBIJB;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly HOOGKFLMCLH IJMGMBPJJCI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BNJOFFCHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EF20", Offset = "0x6A7D520", VA = "0x186A7EF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	public HOOGKFLMCLH(IntPtr NPDGKEGBEMC, IntPtr GPFCDAAKFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void NGBGNBDBFEO(string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void BNBFGGCIJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EE90", Offset = "0x6A7D490", VA = "0x186A7EE90")]
	private static HOOGKFLMCLH HDGLIHNBEFD()
	{
		return default(HOOGKFLMCLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct IPHKONMOGNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr IHOGDPKHOBM;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	private IPHKONMOGNO(IntPtr GPFCDAAKFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F130", Offset = "0x6A7D730", VA = "0x186A7F130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F150", Offset = "0x6A7D750", VA = "0x186A7F150")]
	public static IPHKONMOGNO NKOJKFHACJH(string LGJDNDBECCI)
	{
		return default(IPHKONMOGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD320", Offset = "0x1FDB920", VA = "0x181FDD320")]
	public static IPHKONMOGNO NKOJKFHACJH([In] HOOGKFLMCLH OOBOHIGMGOM, string LGJDNDBECCI)
	{
		return default(IPHKONMOGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD970", Offset = "0x1FDBF70", VA = "0x181FDD970")]
	public static IPHKONMOGNO NKOJKFHACJH([In] HOOGKFLMCLH OOBOHIGMGOM, Func<string> LGJDNDBECCI)
	{
		return default(IPHKONMOGNO);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class EODOJDCMLJG
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool PILMEBMIAOH<in TInput, TResult>(TInput NGALCNCLJMG, [Out] TResult JKLHKLABFHH);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class MABFHOLDNHN : EEHFCJDALBM
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class JKNCECHPDFJ : MANFLJHPBCN, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly JKNCECHPDFJ HHHOBHGDEHO;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool CBHOFFDJBCD
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x6A7F250", Offset = "0x6A7D850", VA = "0x186A7F250", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6A7F2B0", Offset = "0x6A7D8B0", VA = "0x186A7F2B0", Slot = "6")]
			public void OnCompleted(Action FJBNHIAOKMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			public void MOICIHMECBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public JKNCECHPDFJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MABFHOLDNHN HHHOBHGDEHO;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		private MABFHOLDNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A80000", Offset = "0x6A7E600", VA = "0x186A80000", Slot = "4")]
		public MANFLJHPBCN FLHBGNMEBOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class EMKNAJGJAKJ : EEHFCJDALBM
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class FCCMHBGIOFB : MANFLJHPBCN, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly FCCMHBGIOFB HHHOBHGDEHO;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool CBHOFFDJBCD
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x6A7CDB0", Offset = "0x6A7B3B0", VA = "0x186A7CDB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6A7CDD0", Offset = "0x6A7B3D0", VA = "0x186A7CDD0", Slot = "6")]
			public void OnCompleted(Action FJBNHIAOKMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			public void MOICIHMECBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public FCCMHBGIOFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly EMKNAJGJAKJ HHHOBHGDEHO;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		private EMKNAJGJAKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A9D0", Offset = "0x6A78FD0", VA = "0x186A7A9D0", Slot = "4")]
		public MANFLJHPBCN FLHBGNMEBOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ICGGOGMGLLG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ICGGOGMGLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFEF0", Offset = "0x3DFE4F0", VA = "0x183DFFEF0")]
		internal void NFNGEGJJJGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NAHHDKAJIHJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NAHHDKAJIHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x45686B0", Offset = "0x4566CB0", VA = "0x1845686B0")]
		internal void EJMLJIMKDDP(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DFFOEBHMDKP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A791A0", Offset = "0x6A777A0", VA = "0x186A791A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BHHABNAFHGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6A77FA0", Offset = "0x6A765A0", VA = "0x186A77FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct IIEMGIPFEFN<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E40050", Offset = "0x3E3E650", VA = "0x183E40050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E401C0", Offset = "0x3E3E7C0", VA = "0x183E401C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KAKKOKCCEGP<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x41C5BD0", Offset = "0x41C41D0", VA = "0x1841C5BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x41C6460", Offset = "0x41C4A60", VA = "0x1841C6460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct DMACFPGBCAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A79390", Offset = "0x6A77990", VA = "0x186A79390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A79590", Offset = "0x6A77B90", VA = "0x186A79590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class BMPCEHPLADK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BMPCEHPLADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFEF0", Offset = "0x3DFE4F0", VA = "0x183DFFEF0")]
		internal void EPGJOFDPNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F37070", Offset = "0x4F35670", VA = "0x184F37070")]
		internal void FNIACJDAOMM(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FDNKNBMGMFK<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public PILMEBMIAOH<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3B87F50", Offset = "0x3B86550", VA = "0x183B87F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3B886C0", Offset = "0x3B86CC0", VA = "0x183B886C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct FOAPNDJEECM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D8B0", Offset = "0x6A7BEB0", VA = "0x186A7D8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E0A0", Offset = "0x6A7C6A0", VA = "0x186A7E0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct APDJNOGMAKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A77A00", Offset = "0x6A76000", VA = "0x186A77A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6A77F40", Offset = "0x6A76540", VA = "0x186A77F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KHGFPNDNEJL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x41EB0C0", Offset = "0x41E96C0", VA = "0x1841EB0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C63E90", Offset = "0x3C62490", VA = "0x183C63E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FHOIKPKMHBN<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3B9ABB0", Offset = "0x3B991B0", VA = "0x183B9ABB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x358AEC0", Offset = "0x35894C0", VA = "0x18358AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LGDLBGHMPHG<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x42A91D0", Offset = "0x42A77D0", VA = "0x1842A91D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x42A9910", Offset = "0x42A7F10", VA = "0x1842A9910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct LPJCELIDJOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FCF0", Offset = "0x6A7E2F0", VA = "0x186A7FCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FED0", Offset = "0x6A7E4D0", VA = "0x186A7FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct CJEKPILEIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A78470", Offset = "0x6A76A70", VA = "0x186A78470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A787D0", Offset = "0x6A76DD0", VA = "0x186A787D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DPCIOHCMJGB : IAsyncStateMachine
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
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A79600", Offset = "0x6A77C00", VA = "0x186A79600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A798F0", Offset = "0x6A77EF0", VA = "0x186A798F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EAOJKELJNCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EAOJKELJNCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A79C10", Offset = "0x6A78210", VA = "0x186A79C10")]
		internal Task BPLMPFAOENC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct ODJNMMLCEPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A815B0", Offset = "0x6A7FBB0", VA = "0x186A815B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A81810", Offset = "0x6A7FE10", VA = "0x186A81810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GFFHFKEJCMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E7E0", Offset = "0x6A7CDE0", VA = "0x186A7E7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E9C0", Offset = "0x6A7CFC0", VA = "0x186A7E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CCNNNFFGJAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A780B0", Offset = "0x6A766B0", VA = "0x186A780B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A78410", Offset = "0x6A76A10", VA = "0x186A78410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KOCAMOGGNAH : IAsyncStateMachine
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
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F8A0", Offset = "0x6A7DEA0", VA = "0x186A7F8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FB90", Offset = "0x6A7E190", VA = "0x186A7FB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FHIAPOFLFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FHIAPOFLFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CE90", Offset = "0x6A7B490", VA = "0x186A7CE90")]
		internal Task PKCLHLDEJMP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct EAMFOJOMGFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A79950", Offset = "0x6A77F50", VA = "0x186A79950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A79BB0", Offset = "0x6A781B0", VA = "0x186A79BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct ELLJHFFGCLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A7F0", Offset = "0x6A78DF0", VA = "0x186A7A7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A970", Offset = "0x6A78F70", VA = "0x186A7A970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NGIPILNMMGL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x457AEF0", Offset = "0x45794F0", VA = "0x18457AEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x457B170", Offset = "0x4579770", VA = "0x18457B170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct HOKMHIBJLBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EA20", Offset = "0x6A7D020", VA = "0x186A7EA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EE30", Offset = "0x6A7D430", VA = "0x186A7EE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? DBMOFHOMGIF;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<DHABIOOJNOJ> JOHDCJJEOKB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task GJONECCNOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A7BDD0", Offset = "0x6A7A3D0", VA = "0x186A7BDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C3C0", Offset = "0x6A7A9C0", VA = "0x186A7C3C0")]
	public static bool PFLEBEPKMDD(this Task OOOMFPPINLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A06E80", Offset = "0x2A05480", VA = "0x182A06E80")]
	public static Task<T> CAKNPLCLKGL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AC10", Offset = "0x6A79210", VA = "0x186A7AC10")]
	public static Task AFGFFPEGMOE(this Task OOOMFPPINLE, CancellationToken PNPIGCGKNPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A03FF0", Offset = "0x2A025F0", VA = "0x182A03FF0")]
	public static Task<TResult> AFGFFPEGMOE<TResult>(this Task<TResult> OOOMFPPINLE, CancellationToken PNPIGCGKNPI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2A04610", Offset = "0x2A02C10", VA = "0x182A04610")]
	public static TaskCompletionSource<TResult> AFGFFPEGMOE<TResult>(this TaskCompletionSource<TResult> AGJALLMMGDC, CancellationToken PNPIGCGKNPI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B910", Offset = "0x6A79F10", VA = "0x186A7B910")]
	public static IDisposable? FKHEJNJLGCN(CancellationToken JGFAHKAJOKP, CancellationToken JGIIBPDDDPO, [Out] CancellationToken MBOONBKMOPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AF90", Offset = "0x6A79590", VA = "0x186A7AF90")]
	[AsyncStateMachine(typeof(DFFOEBHMDKP))]
	public static void CENHNAOAMJP(this Task GJMDIBEDCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C5F0", Offset = "0x6A7ABF0", VA = "0x186A7C5F0")]
	[AsyncStateMachine(typeof(BHHABNAFHGM))]
	public static void PNOBNDONPEF(this Task GJMDIBEDCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A06BD0", Offset = "0x2A051D0", VA = "0x182A06BD0")]
	[AsyncStateMachine(typeof(IIEMGIPFEFN<>))]
	public static Task AKBFHDCCIFP<TException>(this Task GJMDIBEDCBL) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A07760", Offset = "0x2A05D60", VA = "0x182A07760")]
	[AsyncStateMachine(typeof(KAKKOKCCEGP<>))]
	public static Task<T> OGJBMIGMGLL<T>(this Task<T> ELMHNMGFNPC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B3A0", Offset = "0x6A799A0", VA = "0x186A7B3A0")]
	[AsyncStateMachine(typeof(DMACFPGBCAJ))]
	public static Task<TaskStatus> DFNDKJIPCLG(this Task ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2A07940", Offset = "0x2A05F40", VA = "0x182A07940")]
	public static (Task<T?>?, Action<T?>?) PINJHBENPJC<T>([Optional] CancellationToken NNGMAHIDECE)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2A07000", Offset = "0x2A05600", VA = "0x182A07000")]
	[AsyncStateMachine(typeof(FDNKNBMGMFK<, >))]
	public static Task<List<TResult>> DFNDDNAOLJP<TResult, TInput>(this Task<List<TInput>> OOOMFPPINLE, PILMEBMIAOH<TInput, TResult> NPNBJOGIAIC) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AE60", Offset = "0x6A79460", VA = "0x186A7AE60")]
	[AsyncStateMachine(typeof(FOAPNDJEECM))]
	public static Task AHGJKAJFNJI(Task GJMDIBEDCBL, CancellationToken MEHJFMOAFKE, Func<CancellationToken, Task> LDAFEAFEMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B4E0", Offset = "0x6A79AE0", VA = "0x186A7B4E0")]
	[AsyncStateMachine(typeof(APDJNOGMAKC))]
	public static Task DPODJFKLKBK(Func<CancellationToken, Task> NNKIBJPHKJM, TimeSpan BKEMADGDEBK, [Optional] CancellationToken MEHJFMOAFKE, [Optional] Action<OperationCanceledException>? NFDHJIOHNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2A07110", Offset = "0x2A05710", VA = "0x182A07110")]
	[AsyncStateMachine(typeof(KHGFPNDNEJL<>))]
	public static Task<T> DPODJFKLKBK<T>(Func<CancellationToken, Task<T>> NNKIBJPHKJM, TimeSpan BKEMADGDEBK, [Optional] CancellationToken MEHJFMOAFKE, [Optional] Func<OperationCanceledException, T>? NFDHJIOHNPF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2A06D90", Offset = "0x2A05390", VA = "0x182A06D90")]
	[AsyncStateMachine(typeof(FHOIKPKMHBN<>))]
	public static Task<IEnumerable<Task<T>>> BCLMNHCGFAN<T>(IEnumerable<Task<T>> DBDFCCHGHAP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2A073B0", Offset = "0x2A059B0", VA = "0x182A073B0")]
	[AsyncStateMachine(typeof(LGDLBGHMPHG<, , , >))]
	public static Task<(T1, T2, T3, T4)> JPOAMJINJOO<T1, T2, T3, T4>(Task<T1> IJAFLBDHJKB, Task<T2> KPLPJOAKLIB, Task<T3> KKBNKMLAIJN, Task<T4> OLELCIIFDGH) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B720", Offset = "0x6A79D20", VA = "0x186A7B720")]
	[AsyncStateMachine(typeof(LPJCELIDJOM))]
	public static Task ECLBJKJECJE(Func<bool> LECPJGKPNPA, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B610", Offset = "0x6A79C10", VA = "0x186A7B610")]
	[AsyncStateMachine(typeof(CJEKPILEIIG))]
	public static Task ECLBJKJECJE(Func<bool> LECPJGKPNPA, TimeSpan CHDIELMFOPD, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BB60", Offset = "0x6A7A160", VA = "0x186A7BB60")]
	[AsyncStateMachine(typeof(DPCIOHCMJGB))]
	public static Task INEHECFPFBB(Func<bool> LECPJGKPNPA, TimeSpan BKEMADGDEBK, [Optional] CancellationToken NNGMAHIDECE, [Optional] Action<OperationCanceledException>? NFDHJIOHNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BC90", Offset = "0x6A7A290", VA = "0x186A7BC90")]
	[AsyncStateMachine(typeof(ODJNMMLCEPG))]
	public static Task INEHECFPFBB(Func<bool> LECPJGKPNPA, TimeSpan BKEMADGDEBK, TimeSpan CHDIELMFOPD, [Optional] CancellationToken NNGMAHIDECE, [Optional] Action<OperationCanceledException>? NFDHJIOHNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C500", Offset = "0x6A7AB00", VA = "0x186A7C500")]
	[AsyncStateMachine(typeof(GFFHFKEJCMA))]
	public static Task PFNNMGHNBAO(Func<bool> LECPJGKPNPA, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C3F0", Offset = "0x6A7A9F0", VA = "0x186A7C3F0")]
	[AsyncStateMachine(typeof(CCNNNFFGJAP))]
	public static Task PFNNMGHNBAO(Func<bool> LECPJGKPNPA, TimeSpan CHDIELMFOPD, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C050", Offset = "0x6A7A650", VA = "0x186A7C050")]
	[AsyncStateMachine(typeof(KOCAMOGGNAH))]
	public static Task MIPAEKFAMCI(Func<bool> LECPJGKPNPA, TimeSpan BKEMADGDEBK, [Optional] CancellationToken NNGMAHIDECE, [Optional] Action<OperationCanceledException>? NFDHJIOHNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BF10", Offset = "0x6A7A510", VA = "0x186A7BF10")]
	[AsyncStateMachine(typeof(EAMFOJOMGFK))]
	public static Task MIPAEKFAMCI(Func<bool> LECPJGKPNPA, TimeSpan BKEMADGDEBK, TimeSpan CHDIELMFOPD, [Optional] CancellationToken NNGMAHIDECE, [Optional] Action<OperationCanceledException>? NFDHJIOHNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C180", Offset = "0x6A7A780", VA = "0x186A7C180")]
	[Obsolete]
	[AsyncStateMachine(typeof(ELLJHFFGCLM))]
	public static Task NNBLFOGECMO(this Task OOOMFPPINLE, Action GEIHHNFFNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A07670", Offset = "0x2A05C70", VA = "0x182A07670")]
	[AsyncStateMachine(typeof(NGIPILNMMGL<>))]
	[Obsolete]
	public static Task NNBLFOGECMO<T>(this Task<T> OOOMFPPINLE, Action<T> GEIHHNFFNAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B810", Offset = "0x6A79E10", VA = "0x186A7B810")]
	private static void EFJOGNDBAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B040", Offset = "0x6A79640", VA = "0x186A7B040")]
	public static bool CNPMAIJBAJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AA90", Offset = "0x6A79090", VA = "0x186A7AA90")]
	private static void ABBFKNIDMPH(SynchronizationContext FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BA50", Offset = "0x6A7A050", VA = "0x186A7BA50")]
	private static void GPOLAFMHNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C270", Offset = "0x6A7A870", VA = "0x186A7C270")]
	public static void OLBAOHKMDOB([Optional] string? DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C340", Offset = "0x6A7A940", VA = "0x186A7C340")]
	public static void PDMGFJGMFBD([Optional] string? DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B8C0", Offset = "0x6A79EC0", VA = "0x186A7B8C0")]
	public static EEHFCJDALBM EHIMGKMGJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B490", Offset = "0x6A79A90", VA = "0x186A7B490")]
	public static EEHFCJDALBM DJBHPJPBMPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BE40", Offset = "0x6A7A440", VA = "0x186A7BE40")]
	[AsyncStateMachine(typeof(HOKMHIBJLBB))]
	public static Task LKDMFMBJNAI(Func<Task> MMBIFBKCHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GJMIOABHJEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
	public GJMIOABHJEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class MNHIIGPLMDO : ACOOALCGGNA
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly ACOOALCGGNA HHHOBHGDEHO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime MOJIEMJLMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A81480", Offset = "0x6A7FA80", VA = "0x186A81480", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset CHAIGNEFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A81420", Offset = "0x6A7FA20", VA = "0x186A81420", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MNHIIGPLMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface ACOOALCGGNA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime MOJIEMJLMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset CHAIGNEFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MNCKLGHEIFI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long GDIFAKBOBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A810E0", Offset = "0x6A7F6E0", VA = "0x186A810E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long BLNOCOEGICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A80D80", Offset = "0x6A7F380", VA = "0x186A80D80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double PFCGPHMCDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A81080", Offset = "0x6A7F680", VA = "0x186A81080")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double JEFCKOMDNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A80FD0", Offset = "0x6A7F5D0", VA = "0x186A80FD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double POPMKIPLICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A80E60", Offset = "0x6A7F460", VA = "0x186A80E60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double AEHNFLFIPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A81130", Offset = "0x6A7F730", VA = "0x186A81130")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A80EB0", Offset = "0x6A7F4B0", VA = "0x186A80EB0")]
	public static double EKMDKLFPFGG(long GPGFIGALKEH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A80DD0", Offset = "0x6A7F3D0", VA = "0x186A80DD0")]
	public static double DNNCCBNEDGN(long GPGFIGALKEH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A80CF0", Offset = "0x6A7F2F0", VA = "0x186A80CF0")]
	public static double CBJCDMJEDAB(double NEGEGFFEGPA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A80F40", Offset = "0x6A7F540", VA = "0x186A80F40")]
	public static long FAMABEMAGLB(long OPCFFCHKCFF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A810D0", Offset = "0x6A7F6D0", VA = "0x186A810D0")]
	public static long KJHONFNGPKD(long LPNJCNOHMMD, long IJEOFOOKDIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A80C20", Offset = "0x6A7F220", VA = "0x186A80C20")]
	public static double BDNILHHMLKN(long LPNJCNOHMMD, long IJEOFOOKDIH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A81020", Offset = "0x6A7F620", VA = "0x186A81020")]
	public static double IBFALAGKBKB(long LPNJCNOHMMD, long IJEOFOOKDIH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class FOBEIMBNGIE : HANHEIIAPMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan BMCNKEGAAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer CIAFJLABOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan BKEMADGDEBK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan PDLEKHHDJED
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E190", Offset = "0x6A7C790", VA = "0x186A7E190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? HHJOFABKPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E530", Offset = "0x6A7CB30", VA = "0x186A7E530")]
	[Preserve]
	public FOBEIMBNGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E590", Offset = "0x6A7CB90", VA = "0x186A7E590")]
	public FOBEIMBNGIE(TimeSpan BKEMADGDEBK, [Optional] Action? GOKPGKLFMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E400", Offset = "0x6A7CA00", VA = "0x186A7E400", Slot = "7")]
	public void MNIJFILABEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E390", Offset = "0x6A7C990", VA = "0x186A7E390", Slot = "8")]
	public void ELEENGCCFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E490", Offset = "0x6A7CA90", VA = "0x186A7E490", Slot = "9")]
	public void NLEFALBLLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x9F4DA0", Offset = "0x9F33A0", VA = "0x1809F4DA0")]
	private void LEIDMEKMAHJ(object CEBMDGFHLLP, ElapsedEventArgs CILOLCJJKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E100", Offset = "0x6A7C700", VA = "0x186A7E100")]
	private static void CEAKIPGINIG(TimeSpan CLKHPIAAPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E2F0", Offset = "0x6A7C8F0", VA = "0x186A7E2F0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class FJLOFHOEGHN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? HCONHNEMFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string BMCCKBBLCFN;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1E19CC0", Offset = "0x1E182C0", VA = "0x181E19CC0")]
	public FJLOFHOEGHN(string EJBGBCFNIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3AE0", Offset = "0x3CD20E0", VA = "0x183CD3AE0")]
	public FJLOFHOEGHN(string LPMFPECNPEI, string EJBGBCFNIJD)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct PEIEOFGIIME : IEquatable<PEIEOFGIIME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint JDJIHHEAPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int OMMCFNGNKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float ECIOFGHMFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort DBFMOLLGJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort BGCICHINFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short HNCPPCCEMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short IBKHLOGIKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char EHJLPKLJFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char OMIODAKNION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte ADNAILDMNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte DHAFPGABHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte HNDGPKGONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte BBHNFNOHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool FKBCEFHPONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool OAOFALABDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool OJFFDCOMNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool JJDCMODALLN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE6F580", Offset = "0xE6DB80", VA = "0x180E6F580")]
	public static PEIEOFGIIME HNKJJFFMILL(uint HMDIAHEFEJE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xE6F580", Offset = "0xE6DB80", VA = "0x180E6F580")]
	public static PEIEOFGIIME LEABNDFKOCL(int IHBOJOAKJFB)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A81ED0", Offset = "0x6A804D0", VA = "0x186A81ED0")]
	public static PEIEOFGIIME OOFGOBFEJMM(float OEBCBCHGFLN)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A81E30", Offset = "0x6A80430", VA = "0x186A81E30")]
	public static PEIEOFGIIME MODLGIBDCPB(byte JLJMNBPGLKH, byte KFHCPMGAPPO, byte DBKJDNGINBH, byte LIDAAGICNCL)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A81E30", Offset = "0x6A80430", VA = "0x186A81E30")]
	public static PEIEOFGIIME EIMKMHBNLAO(bool JEMCPDAJLLA, bool GIMHJPJALMF, bool EEMABCNHOLO, bool AGMJMILLBHB)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A81E30", Offset = "0x6A80430", VA = "0x186A81E30")]
	public static PEIEOFGIIME MNANKGGAMAP(byte LKBMGMJIOEM, byte GNLHOFIBIHH, byte CJHLCDNHJGA, byte GOALAGPPLMA)
	{
		return default(PEIEOFGIIME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1B74300", Offset = "0x1B72900", VA = "0x181B74300")]
	public static bool MLHBCNDBLOI(PEIEOFGIIME MIGBCLGIEPA, PEIEOFGIIME MMACHIKDDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xAF2D80", Offset = "0xAF1380", VA = "0x180AF2D80", Slot = "4")]
	public bool Equals(PEIEOFGIIME OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A81E50", Offset = "0x6A80450", VA = "0x186A81E50", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xB8B230", Offset = "0xB89830", VA = "0x180B8B230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6A81EE0", Offset = "0x6A804E0", VA = "0x186A81EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct FLNMIMPIICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong HDGFEBHIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long EBEPCKODDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double NACHDHGBNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint BLPEEHIIIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint NPKKEJPHOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int CFIBAFEKGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int JBGAICNMDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float BNMCBIMMPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float PCFCIPHHEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort DBFMOLLGJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort BGCICHINFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort IHHPOFJFGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort ODJEEAILFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short HNCPPCCEMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short IBKHLOGIKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short ALFAMNMPJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short CGEDHGDPJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char EHJLPKLJFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char OMIODAKNION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char LJHPMMBOAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char CKCBMELDMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte ADNAILDMNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte DHAFPGABHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte HNDGPKGONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte BBHNFNOHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte DFJPPKOBBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte HGELNCDGDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte IFIEIHNENLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte GGJEFOEDMBO;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D860", Offset = "0x6A7BE60", VA = "0x186A7D860")]
	public static FLNMIMPIICB NKOJKFHACJH(byte JLJMNBPGLKH, byte KFHCPMGAPPO, byte DBKJDNGINBH, byte LIDAAGICNCL, byte JMBFNHLGCOE, byte CLCMHGEGDCE, byte CEFFFBLGLMN, byte AJIPEHNCCAP)
	{
		return default(FLNMIMPIICB);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KDHCKINBONE : IEquatable<KDHCKINBONE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte PDFLHAFKECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool INLHKEFCDJK;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x25A0210", Offset = "0x259E810", VA = "0x1825A0210")]
	public static KDHCKINBONE MODLGIBDCPB(byte DPCGELOMKHP)
	{
		return default(KDHCKINBONE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25A0210", Offset = "0x259E810", VA = "0x1825A0210")]
	public static KDHCKINBONE EIMKMHBNLAO(bool HPMPNMCOJAI)
	{
		return default(KDHCKINBONE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F630", Offset = "0x6A7DC30", VA = "0x186A7F630")]
	public static bool MLHBCNDBLOI(KDHCKINBONE MIGBCLGIEPA, KDHCKINBONE MMACHIKDDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5C27E50", Offset = "0x5C26450", VA = "0x185C27E50", Slot = "4")]
	public bool Equals(KDHCKINBONE OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F590", Offset = "0x6A7DB90", VA = "0x186A7F590", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F620", Offset = "0x6A7DC20", VA = "0x186A7F620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F640", Offset = "0x6A7DC40", VA = "0x186A7F640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MOKKLJLIMJN<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T BGKFIHDAEMP;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x451CD30", Offset = "0x451B330", VA = "0x18451CD30")]
	public MOKKLJLIMJN(T EFKCEICAMPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OEKNLEPPNIF
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2B53FB0", Offset = "0x2B525B0", VA = "0x182B53FB0")]
	public static IEnumerable<T> FJNLDLPJOPP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	public static T[] ACICGLOCJCK<T>(params T[] OONCKCLJCAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	public static IEnumerable<T> GBEODEFLCGI<T>(params T[] OONCKCLJCAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2973880", Offset = "0x2971E80", VA = "0x182973880")]
	public static HashSet<T> EJJJFAJIDPD<T>(params T[] OONCKCLJCAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6FD0", Offset = "0x2CE55D0", VA = "0x182CE6FD0")]
	public static KeyValuePair<TKey, TValue> KFPLGBDAGLD<TKey, TValue>([In] TKey MNBFPOFIDHA, [In] TValue FEBGGALLBNN) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2973880", Offset = "0x2971E80", VA = "0x182973880")]
	public static List<T> IIHBDPFLHJP<T>(IEnumerable<T> HBAHAFEIFCB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MNBHENEEEJF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string AKDGPLHCAMM;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
	public MNBHENEEEJF(string NLDMHMGCOCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object LBPODIJBGLK<T>([In] T HCHKMMKNKKB);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object POBIMLFGMGA<T>(T HCHKMMKNKKB);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[EPPKEEOFFDN]
public delegate string LIJJFOLFMEI(string GCCBDCNGFBP, string? CJCGEMBCKKP, bool DOHMMMDNICN);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[EPPKEEOFFDN]
public delegate void GOMEIKAFPOD(string DICMABMCPKO);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[EPPKEEOFFDN]
public delegate void EBLHKABIKMB(Exception KLEFNMOCNFP);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate object DDEKBOLDDDF();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[EPPKEEOFFDN]
public delegate bool EFPLEJCNHHB();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[EPPKEEOFFDN]
public delegate string NGAFLPHBIGF(object CDBNFNMIHPK);
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.Enum)]
public class MPPDABGGNCC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
	public MPPDABGGNCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class FBIDBABAIOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct FLBBKMABBED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CF00", Offset = "0x6A7B500", VA = "0x186A7CF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D7F0", Offset = "0x6A7BDF0", VA = "0x186A7D7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback GEDDNMKDLAE;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> CMGALNNEPFN;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C9B0", Offset = "0x6A7AFB0", VA = "0x186A7C9B0")]
	public static Task<bool> PEHOIHEEMFF(int NFPDJABKLBL, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C880", Offset = "0x6A7AE80", VA = "0x186A7C880")]
	[AsyncStateMachine(typeof(FLBBKMABBED))]
	private static Task<bool> IMGJNPMNGII(int NFPDJABKLBL, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C760", Offset = "0x6A7AD60", VA = "0x186A7C760")]
	private static void BOLEJCCDIAP(object? HJBEGIDNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C7F0", Offset = "0x6A7ADF0", VA = "0x186A7C7F0")]
	private static void IHAKPOHLONP(object? HJBEGIDNCHF)
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
