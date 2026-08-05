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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E90540", Offset = "0x5E8F140", VA = "0x185E90540")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GHHGMBFMPIE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C160", Offset = "0x5E8AD60", VA = "0x185E8C160")]
	public GHHGMBFMPIE(bool OHFEFPGDOKN, string JFFCKOILPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LIHCGMPLMBJ<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> IJBEEHAPKLF(CancellationToken BJFJMBIBKLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BAMGBJHKHBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public LIHCGMPLMBJ<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public IJBEEHAPKLF taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x45120F0", Offset = "0x4510CF0", VA = "0x1845120F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x45130A0", Offset = "0x4511CA0", VA = "0x1845130A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource OEDMIHFDIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? NIHKDLOKHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? IGHCJADAEDG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A40D50", Offset = "0x3A3F950", VA = "0x183A40D50")]
	[AsyncStateMachine(typeof(LIHCGMPLMBJ<>.BAMGBJHKHBO))]
	public Task<TResult> IAGFOEGDMEB(IJBEEHAPKLF LAOFJMLNPOI, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A40CE0", Offset = "0x3A3F8E0", VA = "0x183A40CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A40E90", Offset = "0x3A3FA90", VA = "0x183A40E90")]
	public LIHCGMPLMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class APBIFEEIKNP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> BNIHLNEADFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T GMFAJOGMKIF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3180C80", Offset = "0x317F880", VA = "0x183180C80")]
	public APBIFEEIKNP([In] T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x372A2D0", Offset = "0x3728ED0", VA = "0x18372A2D0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x372A670", Offset = "0x3729270", VA = "0x18372A670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x372A9A0", Offset = "0x37295A0", VA = "0x18372A9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HFPIJPCMGOK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C230", Offset = "0x5E8AE30", VA = "0x185E8C230")]
	public static void AFCDGNIHLFP(this CancellationTokenSource OEDMIHFDIKO, bool LIIOPJOODMG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class NCKCAKMMPFG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
	public NCKCAKMMPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class BNMOEEOCHBF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
	public BNMOEEOCHBF(string JHEJJEGDCMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class OHDJENMMPEJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
	public OHDJENMMPEJ(string JHEJJEGDCMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OPPLPMGDPLH
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2656630", Offset = "0x2655230", VA = "0x182656630")]
	public static OJOKGKDFNDH FHMHEOFLJAJ<T>()
	{
		return default(OJOKGKDFNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2656880", Offset = "0x2655480", VA = "0x182656880")]
	public static OJOKGKDFNDH KIHLAPECION<T>([CallerMemberName] string JEICAPDKHKI = "") where T : notnull
	{
		return default(OJOKGKDFNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26565B0", Offset = "0x26551B0", VA = "0x1826565B0")]
	public static OJOKGKDFNDH FHMHEOFLJAJ<T>(this T IKFHEHLCJCA) where T : notnull
	{
		return default(OJOKGKDFNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2656910", Offset = "0x2655510", VA = "0x182656910")]
	public static OJOKGKDFNDH KNKNDOGHEPC<T>(this T IKFHEHLCJCA, [CallerMemberName] string JEICAPDKHKI = "") where T : notnull
	{
		return default(OJOKGKDFNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26567E0", Offset = "0x26553E0", VA = "0x1826567E0")]
	public static OJOKGKDFNDH KIHLAPECION<T>(this T HHHLENOMLMP, [CallerMemberName] string JEICAPDKHKI = "") where T : notnull
	{
		return default(OJOKGKDFNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E912D0", Offset = "0x5E8FED0", VA = "0x185E912D0")]
	public static OJOKGKDFNDH KIHLAPECION(string KNONJIILJKB, [CallerMemberName] string JEICAPDKHKI = "")
	{
		return default(OJOKGKDFNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E91230", Offset = "0x5E8FE30", VA = "0x185E91230")]
	public static string FANOMKDMPPM(this object HHHLENOMLMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NCKCAKMMPFG]
public delegate long BEDLHFBLBOE();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KGLBDHAKPDN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static OFJPDPGMIAN BJHGLGOHBED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OFJPDPGMIAN POLGNEDAJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D740", Offset = "0x5E8C340", VA = "0x185E8D740")]
		get
		{
			return default(OFJPDPGMIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KJILBECOEKE OMDCFKMLLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D2D0", Offset = "0x5E8BED0", VA = "0x185E8D2D0")]
		get
		{
			return default(KJILBECOEKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BEJICDOEKPE KLAHMAEMONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D5C0", Offset = "0x5E8C1C0", VA = "0x185E8D5C0")]
		get
		{
			return default(BEJICDOEKPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D3A0", Offset = "0x5E8BFA0", VA = "0x185E8D3A0")]
	public static void FMGDEJELPKN([In] OFJPDPGMIAN EKGMGFCEFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D610", Offset = "0x5E8C210", VA = "0x185E8D610")]
	public static void JJBLJPHBGMP(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D790", Offset = "0x5E8C390", VA = "0x185E8D790")]
	public static void MOICFBOLICL(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x256C830", Offset = "0x256B430", VA = "0x18256C830")]
	public static void MOICFBOLICL<T>(T NGMDGDAKJOP, NKILCGMLEFM<T> EOOPGFAEMIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D520", Offset = "0x5E8C120", VA = "0x185E8D520")]
	public static void IJEAKANFJBD(Exception GDDKLHPPIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D270", Offset = "0x5E8BE70", VA = "0x185E8D270")]
	public static void ANPEHDMNBJO(string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D6E0", Offset = "0x5E8C2E0", VA = "0x185E8D6E0")]
	public static void JKEGIHDGMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D320", Offset = "0x5E8BF20", VA = "0x185E8D320")]
	public static string FANOMKDMPPM(object IIFJCGIHMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D200", Offset = "0x5E8BE00", VA = "0x185E8D200")]
	public static long AJPPDFEDGLA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D860", Offset = "0x5E8C460", VA = "0x185E8D860")]
	public static bool PGCFBEIGHJH(bool LHLJIIDKOKP, string EOOPGFAEMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D900", Offset = "0x5E8C500", VA = "0x185E8D900")]
	public static double PGDMIBDGOID()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OFJPDPGMIAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KJILBECOEKE OMDCFKMLLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly BEJICDOEKPE KLAHMAEMONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly MGJADHHODPN CMHFPIELOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly BEDLHFBLBOE DNHDPGDEINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly IKCJHKONAGB BFELLMJLCHN;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly MGJADHHODPN LBIADMFNDAK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly BEDLHFBLBOE ACIMFCHIDMF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly IKCJHKONAGB GPHGPAPGHDP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OFJPDPGMIAN MANJPJPLOHM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PJGJGCEHBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E90700", Offset = "0x5E8F300", VA = "0x185E90700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E90E20", Offset = "0x5E8FA20", VA = "0x185E90E20")]
	public OFJPDPGMIAN([In] KJILBECOEKE DMPMFIHIBLF, [In] BEJICDOEKPE BLPBAPMBIGE, MGJADHHODPN JHHOEMGJPBB, BEDLHFBLBOE HFOJNHADJFB, IKCJHKONAGB JGBEJGOHBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E906C0", Offset = "0x5E8F2C0", VA = "0x185E906C0")]
	private static string MNLAGLCAKOP(object IIFJCGIHMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320")]
	private static long MPMHENHDPLA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	private static string HPDJNAFEBMN(string JMMCCECHKKL, string? OFNFKLOMJDM, bool GNHEDFJNBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E905C0", Offset = "0x5E8F1C0", VA = "0x185E905C0")]
	private static OFJPDPGMIAN CKKOPOFMIEI()
	{
		return default(OFJPDPGMIAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EGFMFGCOGBL
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KMBGENFJHKL DOMDHLHKKOK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KMBGENFJHKL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HEDOCPHLOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCIHJOCCNBA();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GCMEALEGBOA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPHKEJFMDME([In] T LLMHBOEDHFP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void CICMIPMEDNB<T>([In] T NGMDGDAKJOP);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct LIKDKJBFBIA<T> : IEquatable<LIKDKJBFBIA<T>>, GCMEALEGBOA<LIKDKJBFBIA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T GMFAJOGMKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int EJAAMOHLDLD;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CD7BB0", Offset = "0x1CD67B0", VA = "0x181CD7BB0")]
	public LIKDKJBFBIA([In] T GCPEEAODAIB, int DCGGFHOCGGH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A41490", Offset = "0x3A40090", VA = "0x183A41490")]
	public static bool JONBIHPGCCI([In] LIKDKJBFBIA<T> CNJMMNBENNL, [In] LIKDKJBFBIA<T> PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A40FA0", Offset = "0x3A3FBA0", VA = "0x183A40FA0", Slot = "4")]
	public bool Equals(LIKDKJBFBIA<T> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3712020", Offset = "0x3710C20", VA = "0x183712020", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A40F10", Offset = "0x3A3FB10", VA = "0x183A40F10")]
	public bool DPHKEJFMDME([In] LIKDKJBFBIA<T> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3A410A0", Offset = "0x3A3FCA0", VA = "0x183A410A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A41F60", Offset = "0x3A40B60", VA = "0x183A41F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3A41A00", Offset = "0x3A40600", VA = "0x183A41A00")]
	public void OJCJGJJAKEJ([Out] T GCPEEAODAIB, [Out] int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A41770", Offset = "0x3A40370", VA = "0x183A41770")]
	public (T, int) NCGCFNNBLDJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3A41720", Offset = "0x3A40320", VA = "0x183A41720", Slot = "5")]
	private bool MLKFHGBAHBI([In] LIKDKJBFBIA<T> LLMHBOEDHFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KMNBPBBEBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x256F0D0", Offset = "0x256DCD0", VA = "0x18256F0D0")]
	public static LIKDKJBFBIA<T> OOMHMBNJBCG<T>([In] T GCPEEAODAIB, int DCGGFHOCGGH) where T : notnull
	{
		return default(LIKDKJBFBIA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IPOHLBHAJCA
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2536870", Offset = "0x2535470", VA = "0x182536870")]
	public static bool DPHKEJFMDME<T, U>([In] T HHHLENOMLMP, [In] U IIFJCGIHMIN) where T : notnull, GCMEALEGBOA<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult EDIFHGKLEEJ<T, out TResult>([In] T NGMDGDAKJOP);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult APJJNMDFONP<T1, T2, out TResult>([In] T1 GNKBGMMFKBL, [In] T2 BLCBHGICBID);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MOBJJNEBOMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan EANPIKPKACC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Action? PFOIIJMOFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLDDGFIBKDD();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAMHJCCNAPF();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOBCBCFKKIH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct KJILBECOEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly JFGHHCGCCDI FFDLJHOOHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly KHHEMIJPALG PIKAFFCPLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly JFGHHCGCCDI ODEOOHLMCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KHHEMIJPALG MAOJDEOAEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly JFGHHCGCCDI FDDLEEHLHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KHHEMIJPALG ECJMMNDHHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly HBCMOOMMIDP BKFIPMPNEDE;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly JFGHHCGCCDI MPPOOCDDPED;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly KHHEMIJPALG HJHMKHMJKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly JFGHHCGCCDI KJIPKJBPNML;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KHHEMIJPALG CKPBODMPPHH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly JFGHHCGCCDI CNHGHAFIIDE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KHHEMIJPALG MFGOINHAOGN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly HBCMOOMMIDP MDKPGJAHMKE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KJILBECOEKE MANJPJPLOHM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly JFGHHCGCCDI HIEOCNBNAGG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PJGJGCEHBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DD80", Offset = "0x5E8C980", VA = "0x185E8DD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8FB5B0", Offset = "0x8FA1B0", VA = "0x1808FB5B0")]
	public KJILBECOEKE(JFGHHCGCCDI PHPPJICOBBB, KHHEMIJPALG HFMHEGECGLD, JFGHHCGCCDI HAFEECCHJDB, KHHEMIJPALG EGNFEFKCBPO, JFGHHCGCCDI AANGAFGLBAL, KHHEMIJPALG BJMJMDNDDFM, HBCMOOMMIDP IGGECMDOJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	private static bool DNCMHDBOKHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private static void NGNLOBPMMDB(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	private static bool OHMJFPHMDHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private static void MENKBHEKFFK(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	private static bool LDEKFFPNCGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private static void DMIEALKFCEL(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private static void KDNKCOECACN(Exception GDDKLHPPIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DA80", Offset = "0x5E8C680", VA = "0x185E8DA80")]
	private static KJILBECOEKE CKKOPOFMIEI()
	{
		return default(KJILBECOEKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390")]
	private static bool LBBHDEGBOHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DBC0", Offset = "0x5E8C7C0", VA = "0x185E8DBC0")]
	public void JJBLJPHBGMP(object EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DD10", Offset = "0x5E8C910", VA = "0x185E8DD10")]
	public void MOICFBOLICL(object EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20DAAE0", Offset = "0x20D96E0", VA = "0x1820DAAE0")]
	public void IJEAKANFJBD(Exception GDDKLHPPIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DC30", Offset = "0x5E8C830", VA = "0x185E8DC30")]
	public void MOICFBOLICL(GFLAHEBENDA EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x256ECB0", Offset = "0x256D8B0", VA = "0x18256ECB0")]
	public void MOICFBOLICL<T>(T NGMDGDAKJOP, NKILCGMLEFM<T> EOOPGFAEMIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x256EA70", Offset = "0x256D670", VA = "0x18256EA70")]
	public void JJBLJPHBGMP<T>([In] T NGMDGDAKJOP, JLGGPLGEDGA<T> EOOPGFAEMIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DF80", Offset = "0x5E8CB80", VA = "0x185E8DF80")]
	public bool PGCFBEIGHJH(bool LHLJIIDKOKP, string EOOPGFAEMIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct OJOKGKDFNDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string GMFAJOGMKIF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8739C0", Offset = "0x8725C0", VA = "0x1808739C0")]
	public OJOKGKDFNDH(string GCPEEAODAIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
	public static string JLFJLFEACJM([In] OJOKGKDFNDH HHHLENOMLMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1394D70", Offset = "0x1393970", VA = "0x181394D70")]
	public static OJOKGKDFNDH JLFJLFEACJM(string LLMHBOEDHFP)
	{
		return default(OJOKGKDFNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E91100", Offset = "0x5E8FD00", VA = "0x185E91100")]
	public string LFKFLHLAPKH(string HJMPOPKEFMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E91150", Offset = "0x5E8FD50", VA = "0x185E91150")]
	public string LPEMLANKAIC(object MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct JNKPKLDONNF : IEquatable<JNKPKLDONNF>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "4")]
	public bool Equals(JNKPKLDONNF LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CA70", Offset = "0x5E8B670", VA = "0x185E8CA70", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CAC0", Offset = "0x5E8B6C0", VA = "0x185E8CAC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CAD0", Offset = "0x5E8B6D0", VA = "0x185E8CAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HECACKLOION("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DICBCILEPFI<T> : IEquatable<DICBCILEPFI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T GMFAJOGMKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool MEOJKIHKJNO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ILLIJHKCNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4E45620", Offset = "0x4E44220", VA = "0x184E45620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E46060", Offset = "0x4E44C60", VA = "0x184E46060")]
	public DICBCILEPFI([In] T GCPEEAODAIB, bool FAPPMPKOGLH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4E45950", Offset = "0x4E44550", VA = "0x184E45950")]
	public static bool JONBIHPGCCI([In] DICBCILEPFI<T> CNJMMNBENNL, [In] DICBCILEPFI<T> PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3A40FA0", Offset = "0x3A3FBA0", VA = "0x183A40FA0", Slot = "4")]
	public bool Equals(DICBCILEPFI<T> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4E454B0", Offset = "0x4E440B0", VA = "0x184E454B0", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4E45820", Offset = "0x4E44420", VA = "0x184E45820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4E45E40", Offset = "0x4E44A40", VA = "0x184E45E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class BGLEGFIIHAF
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x22BA070", Offset = "0x22B8C70", VA = "0x1822BA070")]
	public static DICBCILEPFI<T> NIKGNADPBHC<T>([In] T GCPEEAODAIB) where T : notnull
	{
		return default(DICBCILEPFI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x22B9F30", Offset = "0x22B8B30", VA = "0x1822B9F30")]
	public static DICBCILEPFI<T?> HDDDBLOBLII<T>()
	{
		return default(DICBCILEPFI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x22BA170", Offset = "0x22B8D70", VA = "0x1822BA170")]
	public static bool PGEMCMKKMKK<T>([In] this DICBCILEPFI<T> EFNMNIJONEJ, [Out][NotNullWhen(true)] T GCPEEAODAIB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct BEJICDOEKPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly IntPtr ANPEHDMNBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly IntPtr JKEGIHDGMOH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IntPtr HPEMPJGCKJD;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly IntPtr NPIKBMIDMPI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly BEJICDOEKPE MANJPJPLOHM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PJGJGCEHBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E89AF0", Offset = "0x5E886F0", VA = "0x185E89AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x835CA0", Offset = "0x8348A0", VA = "0x180835CA0")]
	public BEJICDOEKPE(IntPtr GKINFPOKKID, IntPtr LDKIKOHKHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private static void AGMDJICDHDC(string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	private static void JBCEBIOCEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E89A60", Offset = "0x5E88660", VA = "0x185E89A60")]
	private static BEJICDOEKPE CKKOPOFMIEI()
	{
		return default(BEJICDOEKPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct LOOKJCPFFJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IntPtr IIGDILDEPFL;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8739C0", Offset = "0x8725C0", VA = "0x1808739C0")]
	private LOOKJCPFFJJ(IntPtr LDKIKOHKHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F290", Offset = "0x5E8DE90", VA = "0x185E8F290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F2A0", Offset = "0x5E8DEA0", VA = "0x185E8F2A0")]
	public static LOOKJCPFFJJ OOMHMBNJBCG(string JEICAPDKHKI)
	{
		return default(LOOKJCPFFJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA520", Offset = "0x1CC9120", VA = "0x181CCA520")]
	public static LOOKJCPFFJJ OOMHMBNJBCG([In] BEJICDOEKPE BLPBAPMBIGE, string JEICAPDKHKI)
	{
		return default(LOOKJCPFFJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9DA0", Offset = "0x1CC89A0", VA = "0x181CC9DA0")]
	public static LOOKJCPFFJJ OOMHMBNJBCG([In] BEJICDOEKPE BLPBAPMBIGE, Func<string> JEICAPDKHKI)
	{
		return default(LOOKJCPFFJJ);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class AJGHEAHONFP
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool KCPHJPPMABC<in TInput, TResult>(TInput MAIMNHFMIBD, [Out] TResult HNCONAMCFGC);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class LKHGGCGHFIO : EGFMFGCOGBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class MELGNEFIFDO : KMBGENFJHKL, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly MELGNEFIFDO IDAIJJLMAFB;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool HEDOCPHLOHE
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x5E8F460", Offset = "0x5E8E060", VA = "0x185E8F460", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E8F4C0", Offset = "0x5E8E0C0", VA = "0x185E8F4C0", Slot = "6")]
			public void OnCompleted(Action AOBOMLLAKIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
			public void NCIHJOCCNBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public MELGNEFIFDO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly LKHGGCGHFIO IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private LKHGGCGHFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F060", Offset = "0x5E8DC60", VA = "0x185E8F060", Slot = "4")]
		public KMBGENFJHKL DOMDHLHKKOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class MDAGAGPIJPJ : EGFMFGCOGBL
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class KNJLEAKCMAA : KMBGENFJHKL, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly KNJLEAKCMAA IDAIJJLMAFB;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool HEDOCPHLOHE
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x5E8E630", Offset = "0x5E8D230", VA = "0x185E8E630", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E8E650", Offset = "0x5E8D250", VA = "0x185E8E650", Slot = "6")]
			public void OnCompleted(Action AOBOMLLAKIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
			public void NCIHJOCCNBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public KNJLEAKCMAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MDAGAGPIJPJ IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private MDAGAGPIJPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F390", Offset = "0x5E8DF90", VA = "0x185E8F390", Slot = "4")]
		public KMBGENFJHKL DOMDHLHKKOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DMHPINMLFDI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DMHPINMLFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x370FA30", Offset = "0x370E630", VA = "0x18370FA30")]
		internal void HFNELFLCKPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MFNCCBDAJHO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MFNCCBDAJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E2B0", Offset = "0x3C8CEB0", VA = "0x183C8E2B0")]
		internal void HIFAHDACEDM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LMEMFEOEMEL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8F130", Offset = "0x5E8DD30", VA = "0x185E8F130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0C0", Offset = "0x7E9CC0", VA = "0x1807EB0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct KODEFAPLBFE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8E720", Offset = "0x5E8D320", VA = "0x185E8E720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0C0", Offset = "0x7E9CC0", VA = "0x1807EB0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BMAHBAEOELM<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x45A08E0", Offset = "0x459F4E0", VA = "0x1845A08E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x45A0A50", Offset = "0x459F650", VA = "0x1845A0A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct EABBBMFOMND<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x314F0A0", Offset = "0x314DCA0", VA = "0x18314F0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x314F910", Offset = "0x314E510", VA = "0x18314F910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JDEANJJMJEO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8C620", Offset = "0x5E8B220", VA = "0x185E8C620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C820", Offset = "0x5E8B420", VA = "0x185E8C820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class IDBCCDFIMPA<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IDBCCDFIMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x370FA30", Offset = "0x370E630", VA = "0x18370FA30")]
		internal void ONLBBHBAMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x370F9D0", Offset = "0x370E5D0", VA = "0x18370F9D0")]
		internal void LMKAAOMLLOK(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GNEOFGNLNLL<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public KCPHJPPMABC<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x35DB170", Offset = "0x35D9D70", VA = "0x1835DB170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x35DB860", Offset = "0x35DA460", VA = "0x1835DB860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct DJMIINIJDNH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8B230", Offset = "0x5E89E30", VA = "0x185E8B230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BA20", Offset = "0x5E8A620", VA = "0x185E8BA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CCLAEKBJAGH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8A100", Offset = "0x5E88D00", VA = "0x185E8A100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A640", Offset = "0x5E89240", VA = "0x185E8A640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EIFIGPBHMBB<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3175210", Offset = "0x3173E10", VA = "0x183175210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x315F700", Offset = "0x315E300", VA = "0x18315F700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct OEOPNDJCJEA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3DEEFB0", Offset = "0x3DEDBB0", VA = "0x183DEEFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x35B3740", Offset = "0x35B2340", VA = "0x1835B3740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct BNDPNDHOKDF<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4678800", Offset = "0x4677400", VA = "0x184678800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4678F00", Offset = "0x4677B00", VA = "0x184678F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct CHKJKHPPGND : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8A6A0", Offset = "0x5E892A0", VA = "0x185E8A6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8AA10", Offset = "0x5E89610", VA = "0x185E8AA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DBLNKDPJLCJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8AEE0", Offset = "0x5E89AE0", VA = "0x185E8AEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B1D0", Offset = "0x5E89DD0", VA = "0x185E8B1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PDLAHLFGIEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public PDLAHLFGIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E91350", Offset = "0x5E8FF50", VA = "0x185E91350")]
		internal Task MHAECEKCNHN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct FHAMANDIOKG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8BEA0", Offset = "0x5E8AAA0", VA = "0x185E8BEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C100", Offset = "0x5E8AD00", VA = "0x185E8C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct OICAAAAPPGC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E90EC0", Offset = "0x5E8FAC0", VA = "0x185E90EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E910A0", Offset = "0x5E8FCA0", VA = "0x185E910A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EADGDOCCDIP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8BA80", Offset = "0x5E8A680", VA = "0x185E8BA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BDF0", Offset = "0x5E8A9F0", VA = "0x185E8BDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct IGEDGMHNDEC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8C2D0", Offset = "0x5E8AED0", VA = "0x185E8C2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C5C0", Offset = "0x5E8B1C0", VA = "0x185E8C5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class ICDJKIJMCGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ICDJKIJMCGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C260", Offset = "0x5E8AE60", VA = "0x185E8C260")]
		internal Task ANOGLFCMBOM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct BFHJAJBMFDK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E89D20", Offset = "0x5E88920", VA = "0x185E89D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E89F80", Offset = "0x5E88B80", VA = "0x185E89F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct JJDBCJPBJKB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8C890", Offset = "0x5E8B490", VA = "0x185E8C890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CA10", Offset = "0x5E8B610", VA = "0x185E8CA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OHDBJCBMDDF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3DF7FF0", Offset = "0x3DF6BF0", VA = "0x183DF7FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8250", Offset = "0x3DF6E50", VA = "0x183DF8250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct CPKDGLJIHLN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8AA70", Offset = "0x5E89670", VA = "0x185E8AA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8AE80", Offset = "0x5E89A80", VA = "0x185E8AE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static SynchronizationContext? DFEJFOOLLDD;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly TaskCompletionSource<JNKPKLDONNF> CCEEJLNGFEH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static Task GKODBNNNLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E88D70", Offset = "0x5E87970", VA = "0x185E88D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B19EE0", Offset = "0x2B18AE0", VA = "0x182B19EE0")]
	public static Task<T> BLEDNDKEDBD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E88A40", Offset = "0x5E87640", VA = "0x185E88A40")]
	public static Task FLDGEADBABD(this Task IMKPJBJJCAM, CancellationToken KJCAGLABEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BF30", Offset = "0x2B1AB30", VA = "0x182B1BF30")]
	public static Task<TResult> FLDGEADBABD<TResult>(this Task<TResult> IMKPJBJJCAM, CancellationToken KJCAGLABEME) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B1C720", Offset = "0x2B1B320", VA = "0x182B1C720")]
	public static TaskCompletionSource<TResult> FLDGEADBABD<TResult>(this TaskCompletionSource<TResult> PNJKDEENCLI, CancellationToken KJCAGLABEME) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E89100", Offset = "0x5E87D00", VA = "0x185E89100")]
	[AsyncStateMachine(typeof(LMEMFEOEMEL))]
	public static void MMEDAPNBHHK(this Task GHKAOLMKPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E89410", Offset = "0x5E88010", VA = "0x185E89410")]
	[AsyncStateMachine(typeof(KODEFAPLBFE))]
	public static void OEHFADDEOIA(this Task GHKAOLMKPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CB80", Offset = "0x2B1B780", VA = "0x182B1CB80")]
	[AsyncStateMachine(typeof(BMAHBAEOELM<>))]
	public static Task HHBGICAJAIJ<TException>(this Task GHKAOLMKPMN) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A270", Offset = "0x2B18E70", VA = "0x182B1A270")]
	[AsyncStateMachine(typeof(EABBBMFOMND<>))]
	public static Task<T> DFJEOKJLKIM<T>(this Task<T> HHHLENOMLMP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E88C80", Offset = "0x5E87880", VA = "0x185E88C80")]
	[AsyncStateMachine(typeof(JDEANJJMJEO))]
	public static Task<TaskStatus> IIPOPPBEBLK(this Task HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A030", Offset = "0x2B18C30", VA = "0x182B1A030")]
	public static (Task<T?>?, Action<T?>?) CDPGHGJECPF<T>([Optional] CancellationToken BJFJMBIBKLL)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CE10", Offset = "0x2B1BA10", VA = "0x182B1CE10")]
	[AsyncStateMachine(typeof(GNEOFGNLNLL<, >))]
	public static Task<List<TResult>> KHLHOPGKFLC<TResult, TInput>(this Task<List<TInput>> IMKPJBJJCAM, KCPHJPPMABC<TInput, TResult> PHBCGMEKLCL) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E887E0", Offset = "0x5E873E0", VA = "0x185E887E0")]
	[AsyncStateMachine(typeof(DJMIINIJDNH))]
	public static Task CNCFJOBEDAG(Task GHKAOLMKPMN, CancellationToken BINKOPDIFFD, Func<CancellationToken, Task> KDOPACBKBGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E88910", Offset = "0x5E87510", VA = "0x185E88910")]
	[AsyncStateMachine(typeof(CCLAEKBJAGH))]
	public static Task FIMDBCDPHIJ(Func<CancellationToken, Task> LFGOMLHIEOK, TimeSpan BENLPNBGENO, [Optional] CancellationToken BINKOPDIFFD, [Optional] Action<OperationCanceledException>? PDIOCFIDDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A430", Offset = "0x2B19030", VA = "0x182B1A430")]
	[AsyncStateMachine(typeof(EIFIGPBHMBB<>))]
	public static Task<T> FIMDBCDPHIJ<T>(Func<CancellationToken, Task<T>> LFGOMLHIEOK, TimeSpan BENLPNBGENO, [Optional] CancellationToken BINKOPDIFFD, [Optional] Func<OperationCanceledException, T>? PDIOCFIDDOD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CD30", Offset = "0x2B1B930", VA = "0x182B1CD30")]
	[AsyncStateMachine(typeof(OEOPNDJCJEA<>))]
	public static Task<IEnumerable<Task<T>>> JKGMPMIAPMH<T>(IEnumerable<Task<T>> DIGBJPCLNCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CF10", Offset = "0x2B1BB10", VA = "0x182B1CF10")]
	[AsyncStateMachine(typeof(BNDPNDHOKDF<, , , >))]
	public static Task<(T1, T2, T3, T4)> KJCGBGFGBOL<T1, T2, T3, T4>(Task<T1> AFJBFDDBLJM, Task<T2> JDFBLJJNGFH, Task<T3> EBIMADICJPP, Task<T4> NIAJDDFJIIE) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E88680", Offset = "0x5E87280", VA = "0x185E88680")]
	[AsyncStateMachine(typeof(CHKJKHPPGND))]
	public static Task BHBABJLLEKA(Func<bool> LHLJIIDKOKP, TimeSpan GACCDCCCHAO, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E89730", Offset = "0x5E88330", VA = "0x185E89730")]
	[AsyncStateMachine(typeof(DBLNKDPJLCJ))]
	public static Task PIJHIIAIBEE(Func<bool> LHLJIIDKOKP, TimeSpan BENLPNBGENO, [Optional] CancellationToken BJFJMBIBKLL, [Optional] Action<OperationCanceledException>? PDIOCFIDDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E89860", Offset = "0x5E88460", VA = "0x185E89860")]
	[AsyncStateMachine(typeof(FHAMANDIOKG))]
	public static Task PIJHIIAIBEE(Func<bool> LHLJIIDKOKP, TimeSpan BENLPNBGENO, TimeSpan GACCDCCCHAO, [Optional] CancellationToken BJFJMBIBKLL, [Optional] Action<OperationCanceledException>? PDIOCFIDDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E88DE0", Offset = "0x5E879E0", VA = "0x185E88DE0")]
	[AsyncStateMachine(typeof(OICAAAAPPGC))]
	public static Task JKENLPPFDOE(Func<bool> LHLJIIDKOKP, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E88ED0", Offset = "0x5E87AD0", VA = "0x185E88ED0")]
	[AsyncStateMachine(typeof(EADGDOCCDIP))]
	public static Task JKENLPPFDOE(Func<bool> LHLJIIDKOKP, TimeSpan GACCDCCCHAO, [Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E894C0", Offset = "0x5E880C0", VA = "0x185E894C0")]
	[AsyncStateMachine(typeof(IGEDGMHNDEC))]
	public static Task OJFOCGFDOGE(Func<bool> LHLJIIDKOKP, TimeSpan BENLPNBGENO, [Optional] CancellationToken BJFJMBIBKLL, [Optional] Action<OperationCanceledException>? PDIOCFIDDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E895F0", Offset = "0x5E881F0", VA = "0x185E895F0")]
	[AsyncStateMachine(typeof(BFHJAJBMFDK))]
	public static Task OJFOCGFDOGE(Func<bool> LHLJIIDKOKP, TimeSpan BENLPNBGENO, TimeSpan GACCDCCCHAO, [Optional] CancellationToken BJFJMBIBKLL, [Optional] Action<OperationCanceledException>? PDIOCFIDDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E88210", Offset = "0x5E86E10", VA = "0x185E88210")]
	[Obsolete]
	[AsyncStateMachine(typeof(JJDBCJPBJKB))]
	public static Task AIMOKFFDGKK(this Task IMKPJBJJCAM, Action HCLKHBHBLNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2B19DF0", Offset = "0x2B189F0", VA = "0x182B19DF0")]
	[Obsolete]
	[AsyncStateMachine(typeof(OHDBJCBMDDF<>))]
	public static Task AIMOKFFDGKK<T>(this Task<T> IMKPJBJJCAM, Action<T> HCLKHBHBLNG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E88300", Offset = "0x5E86F00", VA = "0x185E88300")]
	public static bool AJBJGKJMPCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E891B0", Offset = "0x5E87DB0", VA = "0x185E891B0")]
	private static void NLBADGJHMGD(SynchronizationContext GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E88FE0", Offset = "0x5E87BE0", VA = "0x185E88FE0")]
	private static void KFMFBOHDPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E88790", Offset = "0x5E87390", VA = "0x185E88790")]
	public static EGFMFGCOGBL BJKCLPGCHKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E881C0", Offset = "0x5E86DC0", VA = "0x185E881C0")]
	public static EGFMFGCOGBL ADOKLOJAFEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E89340", Offset = "0x5E87F40", VA = "0x185E89340")]
	[AsyncStateMachine(typeof(CPKDGLJIHLN))]
	public static Task OAHHBBKIEOH(Func<Task> CPCNABCMKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NOJKMEODKBC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
	public NOJKMEODKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CCCHLFDFKKJ : NMDJAPLLCLI
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly NMDJAPLLCLI IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DateTime PPKDCCHMKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E89FE0", Offset = "0x5E88BE0", VA = "0x185E89FE0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTimeOffset ACMFGCCCJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A020", Offset = "0x5E88C20", VA = "0x185E8A020", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CCCHLFDFKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NMDJAPLLCLI
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DateTime PPKDCCHMKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTimeOffset ACMFGCCCJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LAIGIOPFOPK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static long NCPDHKHGPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EC60", Offset = "0x5E8D860", VA = "0x185E8EC60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long JLKPDFLLIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8ECB0", Offset = "0x5E8D8B0", VA = "0x185E8ECB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static double NPJGOCPFNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E8E0", Offset = "0x5E8D4E0", VA = "0x185E8E8E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double CCGDOOMOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EB30", Offset = "0x5E8D730", VA = "0x185E8EB30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double LDMLEKHPBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EC10", Offset = "0x5E8D810", VA = "0x185E8EC10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double HBIALKMPBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E890", Offset = "0x5E8D490", VA = "0x185E8E890")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E930", Offset = "0x5E8D530", VA = "0x185E8E930")]
	public static double CDEILPIOIAL(long OHIADHKKLBA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EB80", Offset = "0x5E8D780", VA = "0x185E8EB80")]
	public static double IMOLPDOODOG(long OHIADHKKLBA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E9C0", Offset = "0x5E8D5C0", VA = "0x185E8E9C0")]
	public static double DAIKCJBBHOE(double MGGHHCBGNGE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E8ED00", Offset = "0x5E8D900", VA = "0x185E8ED00")]
	public static long MGPMJJGEGLI(long FOGEGHJNDKP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA50", Offset = "0x5E8D650", VA = "0x185E8EA50")]
	public static long EFJGCHFOKAF(long FDHHMPEFMDK, long LEPNNBHKJJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA60", Offset = "0x5E8D660", VA = "0x185E8EA60")]
	public static double GJGDINAEGDB(long FDHHMPEFMDK, long LEPNNBHKJJC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E830", Offset = "0x5E8D430", VA = "0x185E8E830")]
	public static double ACBHNKINKFL(long FDHHMPEFMDK, long LEPNNBHKJJC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class KEKJKHHMOBJ : MOBJJNEBOMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly TimeSpan JGIBAKHHMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly System.Timers.Timer AEIJEHEMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private TimeSpan BENLPNBGENO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public TimeSpan EANPIKPKACC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CB00", Offset = "0x5E8B700", VA = "0x185E8CB00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Action? PFOIIJMOFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CF40", Offset = "0x5E8BB40", VA = "0x185E8CF40")]
	[Preserve]
	public KEKJKHHMOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CFB0", Offset = "0x5E8BBB0", VA = "0x185E8CFB0")]
	public KEKJKHHMOBJ(TimeSpan BENLPNBGENO, [Optional] Action? PNDGHKFHOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CE40", Offset = "0x5E8BA40", VA = "0x185E8CE40", Slot = "7")]
	public void LLDDGFIBKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CD30", Offset = "0x5E8B930", VA = "0x185E8CD30", Slot = "8")]
	public void IAMHJCCNAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CC60", Offset = "0x5E8B860", VA = "0x185E8CC60", Slot = "9")]
	public void BOBCBCFKKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xB60E70", Offset = "0xB5FA70", VA = "0x180B60E70")]
	private void EIKKGPKENKF(object IKFHEHLCJCA, ElapsedEventArgs EODHIHOLKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CDA0", Offset = "0x5E8B9A0", VA = "0x185E8CDA0")]
	private static void IKHDNPIFEHF(TimeSpan PHJIHBIANNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CC90", Offset = "0x5E8B890", VA = "0x185E8CC90", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class HECACKLOION : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string LOLJPFLIOEN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
	public HECACKLOION(string BKAHLJMONND)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct NOOHOMJFEAA : IEquatable<NOOHOMJFEAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public uint PJFNOMNPMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public int LMFKIDDNPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public float PNGILLCKKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public ushort KCIHECHBKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public ushort LBHIBDJHNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public short CDNGKDGPLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public short KJLHJEDBDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public char JNGHOBGMOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public char BMMGOBEBEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public byte EDJNOIPKPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte HBLFMHJMKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public byte HKAMFCHFJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public byte IPJCECILLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public bool NICNMELAOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool INKCFLKDKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public bool HHDGGOLNAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public bool JLPPCCPIKAK;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xD68740", Offset = "0xD67340", VA = "0x180D68740")]
	public static NOOHOMJFEAA MKKGBLDBDMO(uint DPLPDJNCKMG)
	{
		return default(NOOHOMJFEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xD68740", Offset = "0xD67340", VA = "0x180D68740")]
	public static NOOHOMJFEAA OLPMAFNHHEJ(int ILEKJIIAPHH)
	{
		return default(NOOHOMJFEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F6C0", Offset = "0x5E8E2C0", VA = "0x185E8F6C0")]
	public static NOOHOMJFEAA CKNGPMKICBL(float BFIDFGDJIEI)
	{
		return default(NOOHOMJFEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F6A0", Offset = "0x5E8E2A0", VA = "0x185E8F6A0")]
	public static NOOHOMJFEAA CKMNDOIIKLK(byte JBBMPAKIINK, byte LKLADGDGOLD, byte DMGCHHNDKKK, byte PJCFANOAOCL)
	{
		return default(NOOHOMJFEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F6A0", Offset = "0x5E8E2A0", VA = "0x185E8F6A0")]
	public static NOOHOMJFEAA CCADMHACKFJ(bool LHIGMJFOFJM, bool MBDCAEOBDMN, bool AJFJLBPGFAC, bool CKFJFHMHGNM)
	{
		return default(NOOHOMJFEAA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1709750", Offset = "0x1708350", VA = "0x181709750")]
	public static bool JONBIHPGCCI(NOOHOMJFEAA AGIBINPMDEG, NOOHOMJFEAA BBPKFALMKGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC780", Offset = "0x7EB380", VA = "0x1807EC780", Slot = "4")]
	public bool Equals(NOOHOMJFEAA LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F6D0", Offset = "0x5E8E2D0", VA = "0x185E8F6D0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x877E30", Offset = "0x876A30", VA = "0x180877E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F750", Offset = "0x5E8E350", VA = "0x185E8F750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EFELKKIAJKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ulong DGLJCHNPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public long JPHNNCEIONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public double IJINPDOJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint ACPIHLNJKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint FJEFPEAKNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int PPIEEGCACOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int PCMAIGMENHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float CIPDKCJPPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public float KAJJGMGINBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public ushort KCIHECHBKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ushort LBHIBDJHNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public ushort KBPOIKFKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public ushort PMEMLDIEMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public short CDNGKDGPLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public short KJLHJEDBDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public short GCPDAJEMNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public short GPOJIDNIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public char JNGHOBGMOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public char BMMGOBEBEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public char CMCCBDDPMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public char JMCANLFCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public byte EDJNOIPKPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte HBLFMHJMKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte HKAMFCHFJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte IPJCECILLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte HIMBGHIMOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte OKKHDCIBLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte HOJDIEEDCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte ELPGKIBLNCA;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BE50", Offset = "0x5E8AA50", VA = "0x185E8BE50")]
	public static EFELKKIAJKM OOMHMBNJBCG(byte JBBMPAKIINK, byte LKLADGDGOLD, byte DMGCHHNDKKK, byte PJCFANOAOCL, byte HCKFDFFGFLN, byte DFFBKCPIJIG, byte IDBEAEEAIHL, byte INKDFBAEAAN)
	{
		return default(EFELKKIAJKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FPIJFBLMNNP
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x24F1FB0", Offset = "0x24F0BB0", VA = "0x1824F1FB0")]
	public static IEnumerable<T> FLLODPBFIAP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static T[] PKJNCDHPFHE<T>(params T[] NHBMIDPPCCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static IEnumerable<T> IMHBAAPFPGH<T>(params T[] NHBMIDPPCCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x24DAED0", Offset = "0x24D9AD0", VA = "0x1824DAED0")]
	public static HashSet<T> CCGJCKOLOCB<T>(params T[] NHBMIDPPCCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x24F1EC0", Offset = "0x24F0AC0", VA = "0x1824F1EC0")]
	public static KeyValuePair<TKey, TValue> DBCNNIMGJDH<TKey, TValue>([In] TKey PPNDANAOAMK, [In] TValue GCPEEAODAIB) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x24DAED0", Offset = "0x24D9AD0", VA = "0x1824DAED0")]
	public static List<T> HEAAJAJONOH<T>(IEnumerable<T> OALAPCBMCII) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ABIIGJBMJOF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string HFPKNAFMILD;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
	public ABIIGJBMJOF(string JLMAKMFNDLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate object JLGGPLGEDGA<T>([In] T ODENEMACEPI);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object NKILCGMLEFM<T>(T ODENEMACEPI);
[Cpp2IlInjected.Token(Token = "0x2000053")]
[NCKCAKMMPFG]
public delegate string IKCJHKONAGB(string JMMCCECHKKL, string? OFNFKLOMJDM, bool GNHEDFJNBJD);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[NCKCAKMMPFG]
public delegate void KHHEMIJPALG(string EOOPGFAEMIH);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[NCKCAKMMPFG]
public delegate void HBCMOOMMIDP(Exception GDDKLHPPIHO);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object GFLAHEBENDA();
[Cpp2IlInjected.Token(Token = "0x2000057")]
[NCKCAKMMPFG]
public delegate bool JFGHHCGCCDI();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[NCKCAKMMPFG]
public delegate string MGJADHHODPN(object IIFJCGIHMIN);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Enum)]
public class NFPKEMNJJBE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
	public NFPKEMNJJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class JCAKEDBLIGN
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class JFLFGHAKCHE<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly ISet<T> IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int CMJPMBPLDNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x38ECDB0", Offset = "0x38EB9B0", VA = "0x1838ECDB0", Slot = "4")]
		public bool Add(T KADOGPFLCFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "6")]
		public void IntersectWith(IEnumerable<T> LLMHBOEDHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x38ED040", Offset = "0x38EBC40", VA = "0x1838ED040", Slot = "5")]
		public void UnionWith(IEnumerable<T> LLMHBOEDHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x38ECEF0", Offset = "0x38EBAF0", VA = "0x1838ECEF0", Slot = "9")]
		void ICollection<T>.Add(T KADOGPFLCFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "11")]
		public bool Contains(T KADOGPFLCFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "12")]
		public void CopyTo(T[] DAJPKFPFPMI, int DOCPNNGFPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
		public bool Remove(T KADOGPFLCFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x38ECE70", Offset = "0x38EBA70", VA = "0x1838ECE70", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x316DF90", Offset = "0x316CB90", VA = "0x18316DF90", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public JFLFGHAKCHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x80FF50", Offset = "0x80EB50", VA = "0x18080FF50")]
	public static ISet<T> OPHFCMNANNN<T>() where T : notnull
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
