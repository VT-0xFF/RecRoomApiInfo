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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x610BD90", Offset = "0x610B190", VA = "0x18610BD90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class ALNLFLNLCKA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6103B40", Offset = "0x6102F40", VA = "0x186103B40")]
	public ALNLFLNLCKA(bool ILHJAMMLMLI, string KAHGLHIJGAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KLLDMILBKFD<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> EPLINPFAGFM(CancellationToken PPJMMMGPFGD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GDPBIEFDFLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KLLDMILBKFD<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public EPLINPFAGFM taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x36FC760", Offset = "0x36FBB60", VA = "0x1836FC760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x36FD7C0", Offset = "0x36FCBC0", VA = "0x1836FD7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource FDJCMGONJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? BDMADBMEAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? OFKPHLELHEB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2ED0", Offset = "0x3AD22D0", VA = "0x183AD2ED0")]
	[AsyncStateMachine(typeof(KLLDMILBKFD<>.GDPBIEFDFLN))]
	public Task<TResult> IGIBFKMLDEP(EPLINPFAGFM FINPKILBCBI, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2E60", Offset = "0x3AD2260", VA = "0x183AD2E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3010", Offset = "0x3AD2410", VA = "0x183AD3010")]
	public KLLDMILBKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class JPEPGEKNDNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> HDHCGFDCMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T BDGBGLMDOLF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A63E70", Offset = "0x3A63270", VA = "0x183A63E70")]
	public JPEPGEKNDNJ([In] T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A63780", Offset = "0x3A62B80", VA = "0x183A63780", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A639B0", Offset = "0x3A62DB0", VA = "0x183A639B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A63BD0", Offset = "0x3A62FD0", VA = "0x183A63BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FEFBILNMGDL
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61071A0", Offset = "0x61065A0", VA = "0x1861071A0")]
	public static void NKFPIBPDKPD(this CancellationTokenSource FDJCMGONJAM, bool PFNGIKLOOPE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class CGMIEFCGOHC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	public CGMIEFCGOHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class GLNHMJBGBDI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	public GLNHMJBGBDI(string BGICBIKFAFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DEKLNIIIPEN
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x251A860", Offset = "0x2519C60", VA = "0x18251A860")]
	public static LACAGJLFIDN DDJLJACDINL<T>()
	{
		return default(LACAGJLFIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x251AB80", Offset = "0x2519F80", VA = "0x18251AB80")]
	public static LACAGJLFIDN JIGLNLIAGAI<T>([CallerMemberName] string GFBABMFGHOJ = "") where T : notnull
	{
		return default(LACAGJLFIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x251A8E0", Offset = "0x2519CE0", VA = "0x18251A8E0")]
	public static LACAGJLFIDN DDJLJACDINL<T>(this T OIGNJCHPDMC) where T : notnull
	{
		return default(LACAGJLFIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x251A960", Offset = "0x2519D60", VA = "0x18251A960")]
	public static LACAGJLFIDN DGLOLBGGEPB<T>(this T OIGNJCHPDMC, [CallerMemberName] string GFBABMFGHOJ = "") where T : notnull
	{
		return default(LACAGJLFIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x251AAE0", Offset = "0x2519EE0", VA = "0x18251AAE0")]
	public static LACAGJLFIDN JIGLNLIAGAI<T>(this T LOMPFKEACIP, [CallerMemberName] string GFBABMFGHOJ = "") where T : notnull
	{
		return default(LACAGJLFIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6105FB0", Offset = "0x61053B0", VA = "0x186105FB0")]
	public static LACAGJLFIDN JIGLNLIAGAI(string MDJCBJAMNEL, [CallerMemberName] string GFBABMFGHOJ = "")
	{
		return default(LACAGJLFIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6105F10", Offset = "0x6105310", VA = "0x186105F10")]
	public static string JBHCAFHJHFG(this object LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool KJCECLJHFBG();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[CGMIEFCGOHC]
public delegate long NKLIOPEJJOB();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DCAKFHFEHAL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DGDJBPBNDBM OCANOEKDHKK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DGDJBPBNDBM IMOEJAHMICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6105320", Offset = "0x6104720", VA = "0x186105320")]
		get
		{
			return default(DGDJBPBNDBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BFDHGHDNPEF KHIHDDPHEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61054A0", Offset = "0x61048A0", VA = "0x1861054A0")]
		get
		{
			return default(BFDHGHDNPEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OGAAHBBBMPE AIMHEMCDOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61057B0", Offset = "0x6104BB0", VA = "0x1861057B0")]
		get
		{
			return default(OGAAHBBBMPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool FFELBFJGMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6105210", Offset = "0x6104610", VA = "0x186105210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6105800", Offset = "0x6104C00", VA = "0x186105800")]
	public static void NIHLDCLLFNE([In] DGDJBPBNDBM LDGICOOEIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6105640", Offset = "0x6104A40", VA = "0x186105640")]
	public static void JBOJMAMBIHB(string CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61053D0", Offset = "0x61047D0", VA = "0x1861053D0")]
	public static void DBMJNCFFPFH(string CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2517600", Offset = "0x2516A00", VA = "0x182517600")]
	public static void DBMJNCFFPFH<T>(T CMDECJALHDG, GNKMDEHBICN<T> CAIOIMEOMNJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6105710", Offset = "0x6104B10", VA = "0x186105710")]
	public static void KNJLAGOCLPH(Exception PPLJOKJMAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6105370", Offset = "0x6104770", VA = "0x186105370")]
	public static void CODPPFNOKDJ(string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61059B0", Offset = "0x6104DB0", VA = "0x1861059B0")]
	public static void NLFFFBGEOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61055C0", Offset = "0x61049C0", VA = "0x1861055C0")]
	public static string JBHCAFHJHFG(object BHPOPDOKECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6105A10", Offset = "0x6104E10", VA = "0x186105A10")]
	public static long NMHLACBMEBK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6105280", Offset = "0x6104680", VA = "0x186105280")]
	public static bool BMNAIKHHPKA(bool CGICPLGALCI, string CAIOIMEOMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61054F0", Offset = "0x61048F0", VA = "0x1861054F0")]
	public static double FGJGAMFEDCJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DGDJBPBNDBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly BFDHGHDNPEF KHIHDDPHEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly OGAAHBBBMPE AIMHEMCDOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BKLFAOEPCIO FPBBDOBDAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly NKLIOPEJJOB EABEIGKAKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JIDFMINIFMJ DCMECLKHOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly KJCECLJHFBG HGIPBFAHMIK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly BKLFAOEPCIO HOPDBGHJKAN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly NKLIOPEJJOB GNLNFKDCCFF;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JIDFMINIFMJ ICKFJAHMMBN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly KJCECLJHFBG KNIBBNHCKKB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly DGDJBPBNDBM IEOIBINPDHE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PFEHLHJGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6106030", Offset = "0x6105430", VA = "0x186106030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6106A10", Offset = "0x6105E10", VA = "0x186106A10")]
	public DGDJBPBNDBM([In] BFDHGHDNPEF MPEFPBJECBP, [In] OGAAHBBBMPE GBDMFJLCMNH, BKLFAOEPCIO NHOENMNDCFL, NKLIOPEJJOB FHKAGBNFOON, JIDFMINIFMJ CGAKAKICPDI, KJCECLJHFBG ILMBDEFIDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61061D0", Offset = "0x61055D0", VA = "0x1861061D0")]
	private static string KKHKICMAFGC(object BHPOPDOKECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910")]
	private static long LKLEGFFMHCK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	private static string ANGHCKGCIEH(string HJAICMGMEBP, string? FHEIIELHIDO, bool FFBJGHBJJDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	private static bool NMIJBAGDFGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6106210", Offset = "0x6105610", VA = "0x186106210")]
	private static DGDJBPBNDBM PJDCMCAMGND()
	{
		return default(DGDJBPBNDBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FPNDKLAMEFG
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BIKDBJHIBKP JHNBDACJOPK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BIKDBJHIBKP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EKIHIOAGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNOMCIFMAHD();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OOCNEMALIND<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKOGKAMODKI([In] T KMJGEHGGFFC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void DDPPFDIGOKL<T>([In] T CMDECJALHDG);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IMFPLNAKCEA<T> : IEquatable<IMFPLNAKCEA<T>>, OOCNEMALIND<IMFPLNAKCEA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T BDGBGLMDOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int BLAEHDOLMPP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D54890", Offset = "0x1D53C90", VA = "0x181D54890")]
	public IMFPLNAKCEA([In] T ANJCCKHBJJO, int AHDNEIKOMIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3835680", Offset = "0x3834A80", VA = "0x183835680")]
	public static bool HOHCACPHFGD([In] IMFPLNAKCEA<T> BGDKODNOBOD, [In] IMFPLNAKCEA<T> APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3834C20", Offset = "0x3834020", VA = "0x183834C20", Slot = "4")]
	public bool Equals(IMFPLNAKCEA<T> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36D3450", Offset = "0x36D2850", VA = "0x1836D3450", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3834B90", Offset = "0x3833F90", VA = "0x183834B90")]
	public bool CKOGKAMODKI([In] IMFPLNAKCEA<T> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3834FD0", Offset = "0x38343D0", VA = "0x183834FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3835D20", Offset = "0x3835120", VA = "0x183835D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3834570", Offset = "0x3833970", VA = "0x183834570")]
	public void ABNKHBBCCGC([Out] T ANJCCKHBJJO, [Out] int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3835810", Offset = "0x3834C10", VA = "0x183835810")]
	public (T, int) PKDBGMPCBCL()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3835B30", Offset = "0x3834F30", VA = "0x183835B30", Slot = "5")]
	private bool PNEPHMPNCIG([In] IMFPLNAKCEA<T> KMJGEHGGFFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CGBJPBGAEPH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24EEF50", Offset = "0x24EE350", VA = "0x1824EEF50")]
	public static IMFPLNAKCEA<T> CPLKLKACALP<T>([In] T ANJCCKHBJJO, int AHDNEIKOMIB) where T : notnull
	{
		return default(IMFPLNAKCEA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HMCGBMICJGP
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x268DE40", Offset = "0x268D240", VA = "0x18268DE40")]
	public static bool CKOGKAMODKI<T, U>([In] T LOMPFKEACIP, [In] U BHPOPDOKECN) where T : notnull, OOCNEMALIND<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult HOPOLELGJNG<T, out TResult>([In] T CMDECJALHDG);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult OMOGKMCPPCK<T1, T2, out TResult>([In] T1 PEBGFMLJGKE, [In] T2 OPKFJJNKOAB);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KDFMOCKHLPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan DEHFBFGFNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? IKEBKMAJIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDMCIMIHPCE();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PJFCDLGAPKD();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHLMHDKNPAM();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct BFDHGHDNPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GBIIHGAEKBC BGJMGLJKLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly OKGAAMNCCBB DKPBAFMJHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly GBIIHGAEKBC DPNIJLEEBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly OKGAAMNCCBB NFBJEGLBFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly GBIIHGAEKBC FDIAHFNCDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly OKGAAMNCCBB POHFFFOBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly CKAODJPBDBD PLCABBALJOP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly GBIIHGAEKBC LGNKBKHHBOF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly OKGAAMNCCBB PDAMBCHJAEN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GBIIHGAEKBC ONOCCMBLHPF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OKGAAMNCCBB HMBDDBNFGLA;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GBIIHGAEKBC OBJPMHKMBLF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly OKGAAMNCCBB EKIPNEHECOI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly CKAODJPBDBD HKPECFNDODD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly BFDHGHDNPEF IEOIBINPDHE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly GBIIHGAEKBC JJDPKAKIJEG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PFEHLHJGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6103E30", Offset = "0x6103230", VA = "0x186103E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x93F280", Offset = "0x93E680", VA = "0x18093F280")]
	public BFDHGHDNPEF(GBIIHGAEKBC JFDFKPIJOJN, OKGAAMNCCBB GDGOCNKCMHM, GBIIHGAEKBC JPNKGOPCNAG, OKGAAMNCCBB LDNCPCLNALA, GBIIHGAEKBC CCFCIFGPNJH, OKGAAMNCCBB PNFBONNHFID, CKAODJPBDBD JNIIJNKNEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	private static bool BFMHCJCEBGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	private static void CBLEEHFHFGP(string CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	private static bool GMCGDBCKOBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	private static void IECFPBIOPCN(string CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	private static bool FHGJBMFANMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	private static void JLCDEEHHNPH(string CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	private static void AOADNJMOKNL(Exception PPLJOKJMAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61040A0", Offset = "0x61034A0", VA = "0x1861040A0")]
	private static BFDHGHDNPEF PJDCMCAMGND()
	{
		return default(BFDHGHDNPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0")]
	private static bool KGBLJALOCIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6104030", Offset = "0x6103430", VA = "0x186104030")]
	public void JBOJMAMBIHB(object CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6103CE0", Offset = "0x61030E0", VA = "0x186103CE0")]
	public void DBMJNCFFPFH(object CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x18E3880", Offset = "0x18E2C80", VA = "0x1818E3880")]
	public void KNJLAGOCLPH(Exception PPLJOKJMAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6103D50", Offset = "0x6103150", VA = "0x186103D50")]
	public void DBMJNCFFPFH(HLNHFCMCBBE CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2455BA0", Offset = "0x2454FA0", VA = "0x182455BA0")]
	public void DBMJNCFFPFH<T>(T CMDECJALHDG, GNKMDEHBICN<T> CAIOIMEOMNJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2455C60", Offset = "0x2455060", VA = "0x182455C60")]
	public void JBOJMAMBIHB<T>([In] T CMDECJALHDG, IIMIKJJFCIM<T> CAIOIMEOMNJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6103C10", Offset = "0x6103010", VA = "0x186103C10")]
	public bool BMNAIKHHPKA(bool CGICPLGALCI, string CAIOIMEOMNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct LACAGJLFIDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string BDGBGLMDOLF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	public LACAGJLFIDN(string ANJCCKHBJJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
	public static string JPANIEAALPM([In] LACAGJLFIDN LOMPFKEACIP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x13E54F0", Offset = "0x13E48F0", VA = "0x1813E54F0")]
	public static LACAGJLFIDN JPANIEAALPM(string KMJGEHGGFFC)
	{
		return default(LACAGJLFIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6109F20", Offset = "0x6109320", VA = "0x186109F20")]
	public string GLNMOMAHILP(string BDOLMNJIDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6109E40", Offset = "0x6109240", VA = "0x186109E40")]
	public string BMMEIBDHIKK(object CNFGOCJCINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct MKHCJDDCMIA : IEquatable<MKHCJDDCMIA>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "4")]
	public bool Equals(MKHCJDDCMIA KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x610AD70", Offset = "0x610A170", VA = "0x18610AD70", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x610ADC0", Offset = "0x610A1C0", VA = "0x18610ADC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x610ADD0", Offset = "0x610A1D0", VA = "0x18610ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[JOOFHEAGKPO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct MEHMHNNDBEN<T> : IEquatable<MEHMHNNDBEN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T BDGBGLMDOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool ILNBKIJAJCA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KGIFPNKBMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3DE13B0", Offset = "0x3DE07B0", VA = "0x183DE13B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1760", Offset = "0x3DE0B60", VA = "0x183DE1760")]
	public MEHMHNNDBEN([In] T ANJCCKHBJJO, bool IPKLJCDCJFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1040", Offset = "0x3DE0440", VA = "0x183DE1040")]
	public static bool HOHCACPHFGD([In] MEHMHNNDBEN<T> BGDKODNOBOD, [In] MEHMHNNDBEN<T> APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3834C20", Offset = "0x3834020", VA = "0x183834C20", Slot = "4")]
	public bool Equals(MEHMHNNDBEN<T> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0BB0", Offset = "0x3DDFFB0", VA = "0x183DE0BB0", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0F00", Offset = "0x3DE0300", VA = "0x183DE0F00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1660", Offset = "0x3DE0A60", VA = "0x183DE1660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class IOIFPAPKOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26BAD80", Offset = "0x26BA180", VA = "0x1826BAD80")]
	public static MEHMHNNDBEN<T> IIPFFDAEKAK<T>([In] T ANJCCKHBJJO) where T : notnull
	{
		return default(MEHMHNNDBEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26BAC10", Offset = "0x26BA010", VA = "0x1826BAC10")]
	public static MEHMHNNDBEN<T?> FDLMGDIHJEM<T>()
	{
		return default(MEHMHNNDBEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26BAC80", Offset = "0x26BA080", VA = "0x1826BAC80")]
	public static bool FNPMEEMJHFF<T>([In] this MEHMHNNDBEN<T> ENBBJACJKAG, [Out][NotNullWhen(true)] T ANJCCKHBJJO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct OGAAHBBBMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr CODPPFNOKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr NLFFFBGEOMN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr DLNCIPOBNGE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr BABNGHANDEC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly OGAAHBBBMPE IEOIBINPDHE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PFEHLHJGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x610C1D0", Offset = "0x610B5D0", VA = "0x18610C1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x87C050", Offset = "0x87B450", VA = "0x18087C050")]
	public OGAAHBBBMPE(IntPtr ILBKHOLBDNA, IntPtr PEPEGMGLEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	private static void OLLIAKKFCID(string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	private static void DFLGGAIILHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x610C2B0", Offset = "0x610B6B0", VA = "0x18610C2B0")]
	private static OGAAHBBBMPE PJDCMCAMGND()
	{
		return default(OGAAHBBBMPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct BJHDOJPCLDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr EIBAJODBPIO;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	private BJHDOJPCLDL(IntPtr PEPEGMGLEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D3DFA0", Offset = "0x1D3D3A0", VA = "0x181D3DFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6104C20", Offset = "0x6104020", VA = "0x186104C20")]
	public static BJHDOJPCLDL CPLKLKACALP(string GFBABMFGHOJ)
	{
		return default(BJHDOJPCLDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D413A0", Offset = "0x1D407A0", VA = "0x181D413A0")]
	public static BJHDOJPCLDL CPLKLKACALP([In] OGAAHBBBMPE GBDMFJLCMNH, string GFBABMFGHOJ)
	{
		return default(BJHDOJPCLDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D41090", Offset = "0x1D40490", VA = "0x181D41090")]
	public static BJHDOJPCLDL CPLKLKACALP([In] OGAAHBBBMPE GBDMFJLCMNH, Func<string> GFBABMFGHOJ)
	{
		return default(BJHDOJPCLDL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FIBJCPKKHKG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool JBLLGLIFPCB<in TInput, TResult>(TInput EPJNNNGOOAO, [Out] TResult ANIEEDIHIEE);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class FCHBLGPCIAF : FPNDKLAMEFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class BPKJBHNINKD : BIKDBJHIBKP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly BPKJBHNINKD GHDJCOLHINO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool EKIHIOAGCOD
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x6104E70", Offset = "0x6104270", VA = "0x186104E70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6104D10", Offset = "0x6104110", VA = "0x186104D10", Slot = "6")]
			public void OnCompleted(Action NHFEKMCDLOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			public void FNOMCIFMAHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public BPKJBHNINKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly FCHBLGPCIAF GHDJCOLHINO;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		private FCHBLGPCIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6106D00", Offset = "0x6106100", VA = "0x186106D00", Slot = "4")]
		public BIKDBJHIBKP JHNBDACJOPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class KJFOKKILLJO : FPNDKLAMEFG
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class NCNPGPCLAPD : BIKDBJHIBKP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly NCNPGPCLAPD GHDJCOLHINO;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool EKIHIOAGCOD
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x610BCF0", Offset = "0x610B0F0", VA = "0x18610BCF0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x610BCA0", Offset = "0x610B0A0", VA = "0x18610BCA0", Slot = "6")]
			public void OnCompleted(Action NHFEKMCDLOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			public void FNOMCIFMAHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public NCNPGPCLAPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly KJFOKKILLJO GHDJCOLHINO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		private KJFOKKILLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6109C50", Offset = "0x6109050", VA = "0x186109C50", Slot = "4")]
		public BIKDBJHIBKP JHNBDACJOPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class GJNCIKFDEGC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public GJNCIKFDEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3714550", Offset = "0x3713950", VA = "0x183714550")]
		internal void LLHGPAKOKBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NIFCJFAKNIN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public NIFCJFAKNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2B40", Offset = "0x3BE1F40", VA = "0x183BE2B40")]
		internal void GNICIADDMGL(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LBGPJMFKNJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6109F70", Offset = "0x6109370", VA = "0x186109F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x910560", Offset = "0x90F960", VA = "0x180910560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BGIIPPCFILI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6104B10", Offset = "0x6103F10", VA = "0x186104B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x910560", Offset = "0x90F960", VA = "0x180910560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CEKIPGPDGKF<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x492B300", Offset = "0x492A700", VA = "0x18492B300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x492B470", Offset = "0x492A870", VA = "0x18492B470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PABFKAPALPP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x407D1D0", Offset = "0x407C5D0", VA = "0x18407D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x407DA40", Offset = "0x407CE40", VA = "0x18407DA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct GFNDLEMNBHD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61092D0", Offset = "0x61086D0", VA = "0x1861092D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x61094D0", Offset = "0x61088D0", VA = "0x1861094D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class KNPHKBLNGAC<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public KNPHKBLNGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3714550", Offset = "0x3713950", VA = "0x183714550")]
		internal void EKNGCKAKAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4410", Offset = "0x3AD3810", VA = "0x183AD4410")]
		internal void POOKKPEBPPE(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct PKOKMFMGCDN<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public JBLLGLIFPCB<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x40AD230", Offset = "0x40AC630", VA = "0x1840AD230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x40AD920", Offset = "0x40ACD20", VA = "0x1840AD920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct OOGIBCMAPGI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x610CB90", Offset = "0x610BF90", VA = "0x18610CB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x610D380", Offset = "0x610C780", VA = "0x18610D380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct HALKPDOPBCB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6109540", Offset = "0x6108940", VA = "0x186109540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6109A80", Offset = "0x6108E80", VA = "0x186109A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GJCONNIFJDC<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3713230", Offset = "0x3712630", VA = "0x183713230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3714120", Offset = "0x3713520", VA = "0x183714120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JDNNPDKKHLD<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3A1B580", Offset = "0x3A1A980", VA = "0x183A1B580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3643480", Offset = "0x3642880", VA = "0x183643480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct IAOKAMPJGBD<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x380AF60", Offset = "0x380A360", VA = "0x18380AF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x380BC30", Offset = "0x380B030", VA = "0x18380BC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FHGCDMJOKAI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6107220", Offset = "0x6106620", VA = "0x186107220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6107400", Offset = "0x6106800", VA = "0x186107400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FEAHLAKLNHP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6106DD0", Offset = "0x61061D0", VA = "0x186106DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6107140", Offset = "0x6106540", VA = "0x186107140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BGEINJJAHEF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61047C0", Offset = "0x6103BC0", VA = "0x1861047C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6104AB0", Offset = "0x6103EB0", VA = "0x186104AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HLEPIJOFMCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public HLEPIJOFMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6109AE0", Offset = "0x6108EE0", VA = "0x186109AE0")]
		internal Task JDFFOKDEFHG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct CGKDGBMAJKH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6104F50", Offset = "0x6104350", VA = "0x186104F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61051B0", Offset = "0x61045B0", VA = "0x1861051B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EDCBGAMDAKI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6106AC0", Offset = "0x6105EC0", VA = "0x186106AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6106CA0", Offset = "0x61060A0", VA = "0x186106CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DCOOELLCEOD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6105B40", Offset = "0x6104F40", VA = "0x186105B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6105EB0", Offset = "0x61052B0", VA = "0x186105EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OAAIFGKGHDL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x610BE10", Offset = "0x610B210", VA = "0x18610BE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x610C100", Offset = "0x610B500", VA = "0x18610C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OBCJIFFHNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public OBCJIFFHNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x610C160", Offset = "0x610B560", VA = "0x18610C160")]
		internal Task OCOOELCBCNM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct FNHBMOHOOKG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6109010", Offset = "0x6108410", VA = "0x186109010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6109270", Offset = "0x6108670", VA = "0x186109270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct PHPMFJIKFMM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x610D3E0", Offset = "0x610C7E0", VA = "0x18610D3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x610D560", Offset = "0x610C960", VA = "0x18610D560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct MPFNHHBONFN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3E07DE0", Offset = "0x3E071E0", VA = "0x183E07DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E08040", Offset = "0x3E07440", VA = "0x183E08040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct MJEKPNAMLCO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x610A900", Offset = "0x6109D00", VA = "0x18610A900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x610AD10", Offset = "0x610A110", VA = "0x18610AD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? MONAHJEGMPF;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<MKHCJDDCMIA> JHEGJJHANIL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task LPAPJAOFJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6107460", Offset = "0x6106860", VA = "0x186107460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x265C9E0", Offset = "0x265BDE0", VA = "0x18265C9E0")]
	public static Task<T> BELANGLHFMG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6107550", Offset = "0x6106950", VA = "0x186107550")]
	public static Task APIJGENMGBA(this Task CMOICIKGDPA, CancellationToken BDHKJODLPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x265B3D0", Offset = "0x265A7D0", VA = "0x18265B3D0")]
	public static Task<TResult> APIJGENMGBA<TResult>(this Task<TResult> CMOICIKGDPA, CancellationToken BDHKJODLPCL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x265B950", Offset = "0x265AD50", VA = "0x18265B950")]
	public static TaskCompletionSource<TResult> APIJGENMGBA<TResult>(this TaskCompletionSource<TResult> OGKJLJLOADA, CancellationToken BDHKJODLPCL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6108600", Offset = "0x6107A00", VA = "0x186108600")]
	[AsyncStateMachine(typeof(LBGPJMFKNJG))]
	public static void JDLFEHALKIE(this Task MMKOHGNNHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6108CC0", Offset = "0x61080C0", VA = "0x186108CC0")]
	[AsyncStateMachine(typeof(BGIIPPCFILI))]
	public static void NGJOENKGDHL(this Task MMKOHGNNHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2659D00", Offset = "0x2659100", VA = "0x182659D00")]
	[AsyncStateMachine(typeof(CEKIPGPDGKF<>))]
	public static Task ACFCDCCLKKG<TException>(this Task MMKOHGNNHLF) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x265D200", Offset = "0x265C600", VA = "0x18265D200")]
	[AsyncStateMachine(typeof(PABFKAPALPP<>))]
	public static Task<T> MANOEJCDNMI<T>(this Task<T> LOMPFKEACIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6108A50", Offset = "0x6107E50", VA = "0x186108A50")]
	[AsyncStateMachine(typeof(GFNDLEMNBHD))]
	public static Task<TaskStatus> KFABMGIAMID(this Task LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x265CFC0", Offset = "0x265C3C0", VA = "0x18265CFC0")]
	public static (Task<T?>?, Action<T?>?) JGBDDJIGKNJ<T>([Optional] CancellationToken PPJMMMGPFGD)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x265CEC0", Offset = "0x265C2C0", VA = "0x18265CEC0")]
	[AsyncStateMachine(typeof(PKOKMFMGCDN<, >))]
	public static Task<List<TResult>> HOBHFMEBCKF<TResult, TInput>(this Task<List<TInput>> CMOICIKGDPA, JBLLGLIFPCB<TInput, TResult> DNAHOLNCCNN) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6108920", Offset = "0x6107D20", VA = "0x186108920")]
	[AsyncStateMachine(typeof(OOGIBCMAPGI))]
	public static Task JPHOCBKLFMP(Task MMKOHGNNHLF, CancellationToken AIPMLFMOPCC, Func<CancellationToken, Task> HFIKNHPGAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6108B90", Offset = "0x6107F90", VA = "0x186108B90")]
	[AsyncStateMachine(typeof(HALKPDOPBCB))]
	public static Task NDCBMANJODI(Func<CancellationToken, Task> NAIHHLJEKII, TimeSpan NAHMIMAPPEC, [Optional] CancellationToken AIPMLFMOPCC, [Optional] Action<OperationCanceledException>? DIHMOGMGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x265D580", Offset = "0x265C980", VA = "0x18265D580")]
	[AsyncStateMachine(typeof(GJCONNIFJDC<>))]
	public static Task<T> NDCBMANJODI<T>(Func<CancellationToken, Task<T>> NAIHHLJEKII, TimeSpan NAHMIMAPPEC, [Optional] CancellationToken AIPMLFMOPCC, [Optional] Func<OperationCanceledException, T>? DIHMOGMGHPN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x265D4A0", Offset = "0x265C8A0", VA = "0x18265D4A0")]
	[AsyncStateMachine(typeof(JDNNPDKKHLD<>))]
	public static Task<IEnumerable<Task<T>>> MPCMOLLIMMC<T>(IEnumerable<Task<T>> HEJADCJDMHG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x265CB30", Offset = "0x265BF30", VA = "0x18265CB30")]
	[AsyncStateMachine(typeof(IAOKAMPJGBD<, , , >))]
	public static Task<(T1, T2, T3, T4)> GBHGLLPBIAI<T1, T2, T3, T4>(Task<T1> NPPBIBMMEBA, Task<T2> JLKFJPEPMKN, Task<T3> PIGIEFNELOO, Task<T4> FAGHFHJFKEH) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6107D10", Offset = "0x6107110", VA = "0x186107D10")]
	[AsyncStateMachine(typeof(FHGCDMJOKAI))]
	public static Task EPONOJFCAMP(Func<bool> CGICPLGALCI, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6107C00", Offset = "0x6107000", VA = "0x186107C00")]
	[AsyncStateMachine(typeof(FEAHLAKLNHP))]
	public static Task EPONOJFCAMP(Func<bool> CGICPLGALCI, TimeSpan LFEENAEDJEI, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61087F0", Offset = "0x6107BF0", VA = "0x1861087F0")]
	[AsyncStateMachine(typeof(BGEINJJAHEF))]
	public static Task JMCONLBFJJA(Func<bool> CGICPLGALCI, TimeSpan NAHMIMAPPEC, [Optional] CancellationToken PPJMMMGPFGD, [Optional] Action<OperationCanceledException>? DIHMOGMGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61086B0", Offset = "0x6107AB0", VA = "0x1861086B0")]
	[AsyncStateMachine(typeof(CGKDGBMAJKH))]
	public static Task JMCONLBFJJA(Func<bool> CGICPLGALCI, TimeSpan NAHMIMAPPEC, TimeSpan LFEENAEDJEI, [Optional] CancellationToken PPJMMMGPFGD, [Optional] Action<OperationCanceledException>? DIHMOGMGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61083F0", Offset = "0x61077F0", VA = "0x1861083F0")]
	[AsyncStateMachine(typeof(EDCBGAMDAKI))]
	public static Task INHCLHNABND(Func<bool> CGICPLGALCI, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61082E0", Offset = "0x61076E0", VA = "0x1861082E0")]
	[AsyncStateMachine(typeof(DCOOELLCEOD))]
	public static Task INHCLHNABND(Func<bool> CGICPLGALCI, TimeSpan LFEENAEDJEI, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6107F40", Offset = "0x6107340", VA = "0x186107F40")]
	[AsyncStateMachine(typeof(OAAIFGKGHDL))]
	public static Task FEONAJDAFMD(Func<bool> CGICPLGALCI, TimeSpan NAHMIMAPPEC, [Optional] CancellationToken PPJMMMGPFGD, [Optional] Action<OperationCanceledException>? DIHMOGMGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6107E00", Offset = "0x6107200", VA = "0x186107E00")]
	[AsyncStateMachine(typeof(FNHBMOHOOKG))]
	public static Task FEONAJDAFMD(Func<bool> CGICPLGALCI, TimeSpan NAHMIMAPPEC, TimeSpan LFEENAEDJEI, [Optional] CancellationToken PPJMMMGPFGD, [Optional] Action<OperationCanceledException>? DIHMOGMGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6108120", Offset = "0x6107520", VA = "0x186108120")]
	[Obsolete]
	[AsyncStateMachine(typeof(PHPMFJIKFMM))]
	public static Task HCIECDNIGBC(this Task CMOICIKGDPA, Action IFKEHECMBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x265CDD0", Offset = "0x265C1D0", VA = "0x18265CDD0")]
	[Obsolete]
	[AsyncStateMachine(typeof(MPFNHHBONFN<>))]
	public static Task HCIECDNIGBC<T>(this Task<T> CMOICIKGDPA, Action<T> IFKEHECMBOF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6108070", Offset = "0x6107470", VA = "0x186108070")]
	private static void HCHBGGCKEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6107880", Offset = "0x6106C80", VA = "0x186107880")]
	public static bool DHINIKGOIBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6108DC0", Offset = "0x61081C0", VA = "0x186108DC0")]
	private static void OGECCMCLFFJ(SynchronizationContext ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61084E0", Offset = "0x61078E0", VA = "0x1861084E0")]
	private static void IPMAINKOHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61077B0", Offset = "0x6106BB0", VA = "0x1861077B0")]
	public static void BGDEDGMINFJ([Optional] string? CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x61074D0", Offset = "0x61068D0", VA = "0x1861074D0")]
	public static void ALDPEBLBMON([Optional] string? CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6108B40", Offset = "0x6107F40", VA = "0x186108B40")]
	public static FPNDKLAMEFG MJNGMMFFFLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6108D70", Offset = "0x6108170", VA = "0x186108D70")]
	public static FPNDKLAMEFG NPBFPBLHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6108210", Offset = "0x6107610", VA = "0x186108210")]
	[AsyncStateMachine(typeof(MJEKPNAMLCO))]
	public static Task IBHLANFCLNG(Func<Task> KCPEOJNECNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NKGHOOICMFH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	public NKGHOOICMFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KNHLJDEMMOO : NLCEFGBEGHI
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly NLCEFGBEGHI GHDJCOLHINO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime PKNDIKCAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6109D80", Offset = "0x6109180", VA = "0x186109D80", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset AHFFMPELOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6109D20", Offset = "0x6109120", VA = "0x186109D20", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public KNHLJDEMMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface NLCEFGBEGHI
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime PKNDIKCAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset AHFFMPELOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class LEDHLBNJHMH
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long BCMKDBFBFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x610A1C0", Offset = "0x61095C0", VA = "0x18610A1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long FHPLLLHKEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x610A390", Offset = "0x6109790", VA = "0x18610A390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double CAOCPFLFJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x610A2E0", Offset = "0x61096E0", VA = "0x18610A2E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double AIENMLLMGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x610A470", Offset = "0x6109870", VA = "0x18610A470")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double EJOFAENIBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x610A5E0", Offset = "0x61099E0", VA = "0x18610A5E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double KOGALOEAKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x610A330", Offset = "0x6109730", VA = "0x18610A330")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x610A3E0", Offset = "0x61097E0", VA = "0x18610A3E0")]
	public static double LMPOHALDFLA(long INKBHCNJDLE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x610A4C0", Offset = "0x61098C0", VA = "0x18610A4C0")]
	public static double NIKLMAFGLPG(long INKBHCNJDLE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x610A0D0", Offset = "0x61094D0", VA = "0x18610A0D0")]
	public static double AKJGDGDOJPN(double BFGIMBDKDMF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x610A550", Offset = "0x6109950", VA = "0x18610A550")]
	public static long NLEJCFMPJFJ(long MINLHDMFCJJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x610A380", Offset = "0x6109780", VA = "0x18610A380")]
	public static long JDBDFOOGBDE(long CAIOCKDMHHJ, long HHLMNNPFLGP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x610A210", Offset = "0x6109610", VA = "0x18610A210")]
	public static double EFOFGNHPCKC(long CAIOCKDMHHJ, long HHLMNNPFLGP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x610A160", Offset = "0x6109560", VA = "0x18610A160")]
	public static double BNLGJNNDJNN(long CAIOCKDMHHJ, long HHLMNNPFLGP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class OHJIEFAKKBM : KDFMOCKHLPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan LLAHBDIAMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer KJPGODIMAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan NAHMIMAPPEC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan DEHFBFGFNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x610C560", Offset = "0x610B960", VA = "0x18610C560", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? IKEBKMAJIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x610C8D0", Offset = "0x610BCD0", VA = "0x18610C8D0")]
	[Preserve]
	public OHJIEFAKKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x610C940", Offset = "0x610BD40", VA = "0x18610C940")]
	public OHJIEFAKKBM(TimeSpan NAHMIMAPPEC, [Optional] Action? LCHEKPBJDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x610C760", Offset = "0x610BB60", VA = "0x18610C760", Slot = "7")]
	public void MDMCIMIHPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x610C7F0", Offset = "0x610BBF0", VA = "0x18610C7F0", Slot = "8")]
	public void PJFCDLGAPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x610C490", Offset = "0x610B890", VA = "0x18610C490", Slot = "9")]
	public void BHLMHDKNPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xB93E80", Offset = "0xB93280", VA = "0x180B93E80")]
	private void ADMAMAKANLL(object OIGNJCHPDMC, ElapsedEventArgs GJOAEAFPDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x610C6C0", Offset = "0x610BAC0", VA = "0x18610C6C0")]
	private static void GDGCEEBAIML(TimeSpan NCDDICPCPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x610C4C0", Offset = "0x610B8C0", VA = "0x18610C4C0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class JOOFHEAGKPO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string EEOFHEPCPDO;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
	public JOOFHEAGKPO(string LAKEPEDEOJL)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct MNCMOJKJMDJ : IEquatable<MNCMOJKJMDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint BJFCPNJJKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int IOMGHKEKNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float LLNPBOOKKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort NMBFCOIHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort FELNLJBJEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short AHNIBHMIPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short OJINFBJLCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char NBOFCHBBBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char FCCCHAEKMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte GPMFFBKPGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte NMOCPCJDAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte JFGLOFEDPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte BKIKABOCGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool BLMPFOGDJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool LGOGFDBJJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool BHDIAHDLIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool IEEAPPJFNME;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static MNCMOJKJMDJ PKKJHJMDBIA(uint GMLOEFGJGML)
	{
		return default(MNCMOJKJMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static MNCMOJKJMDJ JEBMDCKPFBP(int BJALNEHCPKI)
	{
		return default(MNCMOJKJMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x610AE00", Offset = "0x610A200", VA = "0x18610AE00")]
	public static MNCMOJKJMDJ BFLBLBNKLFP(float LIGAPCAIPLO)
	{
		return default(MNCMOJKJMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x610AE10", Offset = "0x610A210", VA = "0x18610AE10")]
	public static MNCMOJKJMDJ DPFGHCHLJKG(byte HHEEIPONEEB, byte NBGCGEPLJPH, byte PDCIPEDLEEE, byte IANPBBLDBLE)
	{
		return default(MNCMOJKJMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x610AE10", Offset = "0x610A210", VA = "0x18610AE10")]
	public static MNCMOJKJMDJ KAOIEPBCJKH(bool EOICDPJIGAC, bool FAEBLHKFFKF, bool HOHNEMKIGIK, bool GNLOEPBDBJI)
	{
		return default(MNCMOJKJMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x610AE10", Offset = "0x610A210", VA = "0x18610AE10")]
	public static MNCMOJKJMDJ OMBDOICDGEF(byte LBOHCOHOCLI, byte LAEGFFDBMFO, byte HJEBFCABFJD, byte DFBCOJFCKMF)
	{
		return default(MNCMOJKJMDJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x174DD70", Offset = "0x174D170", VA = "0x18174DD70")]
	public static bool HOHCACPHFGD(MNCMOJKJMDJ NNOKPENDLPE, MNCMOJKJMDJ OBLEBBNJEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x818880", Offset = "0x817C80", VA = "0x180818880", Slot = "4")]
	public bool Equals(MNCMOJKJMDJ KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x610AE30", Offset = "0x610A230", VA = "0x18610AE30", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x89D2C0", Offset = "0x89C6C0", VA = "0x18089D2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x610AEB0", Offset = "0x610A2B0", VA = "0x18610AEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct FEHDMCOCBAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong HFKLABIPJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long PPNEAOPLONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double HPJFMCPBICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint OIHPMEPGENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint OANIKMPIEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int AGJJBIPOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int OLEBKLNGCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float NODNFDFIIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float LAGGAFOFOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort NMBFCOIHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort FELNLJBJEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort OBMHHDCMNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort KDCKIOKLCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short AHNIBHMIPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short OJINFBJLCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short CNEIAPLNMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short HEPBLLIAMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char NBOFCHBBBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char FCCCHAEKMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char EJEKCEMMHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char GEHNAEJIMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte GPMFFBKPGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte NMOCPCJDAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte JFGLOFEDPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte BKIKABOCGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte LGJBCMDFGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte ENDBGFGJDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte GCDCFOKCCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte PDPODFMGKDD;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x61071D0", Offset = "0x61065D0", VA = "0x1861071D0")]
	public static FEHDMCOCBAE CPLKLKACALP(byte HHEEIPONEEB, byte NBGCGEPLJPH, byte PDCIPEDLEEE, byte IANPBBLDBLE, byte BCOPGHEIDFH, byte IBPMPHKCOHK, byte LIOCLHJHFIB, byte MLFJDNBKGIB)
	{
		return default(FEHDMCOCBAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FEKDFJPGNOE<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly T HNKHAEGPLBK;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x36398F0", Offset = "0x3638CF0", VA = "0x1836398F0")]
	public FEKDFJPGNOE(T OOIIPOPKOAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HMPLBLDOEBO
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2696260", Offset = "0x2695660", VA = "0x182696260")]
	public static FEKDFJPGNOE<T> CPLKLKACALP<T>(T OOIIPOPKOAG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class APGLGBJMALH
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x26A8BC0", Offset = "0x26A7FC0", VA = "0x1826A8BC0")]
	public static IEnumerable<T> JEDBADPABIG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static T[] MGAIODOECJA<T>(params T[] CKLKMMOCGAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static IEnumerable<T> CGCMDNBMMMK<T>(params T[] CKLKMMOCGAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x24EEE80", Offset = "0x24EE280", VA = "0x1824EEE80")]
	public static HashSet<T> IFFHOLMLMPJ<T>(params T[] CKLKMMOCGAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9380", Offset = "0x2CF8780", VA = "0x182CF9380")]
	public static KeyValuePair<TKey, TValue> HDACDCECPCP<TKey, TValue>([In] TKey GPGELODKPOB, [In] TValue ANJCCKHBJJO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x24EEE80", Offset = "0x24EE280", VA = "0x1824EEE80")]
	public static List<T> BOKGDOJPOHA<T>(IEnumerable<T> PGGCOHKMABC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[AttributeUsage(AttributeTargets.All)]
public sealed class GEIPBJDCNMO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly string CJKEKAIHBNL;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
	public GEIPBJDCNMO(string KGJKGLPDNBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object IIMIKJJFCIM<T>([In] T EALPNGKPAMO);
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object GNKMDEHBICN<T>(T EALPNGKPAMO);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CGMIEFCGOHC]
public delegate string JIDFMINIFMJ(string HJAICMGMEBP, string? FHEIIELHIDO, bool FFBJGHBJJDB);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[CGMIEFCGOHC]
public delegate void OKGAAMNCCBB(string CAIOIMEOMNJ);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[CGMIEFCGOHC]
public delegate void CKAODJPBDBD(Exception PPLJOKJMAEA);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object HLNHFCMCBBE();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[CGMIEFCGOHC]
public delegate bool GBIIHGAEKBC();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[CGMIEFCGOHC]
public delegate string BKLFAOEPCIO(object BHPOPDOKECN);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[AttributeUsage(AttributeTargets.Enum)]
public class MAKBLFBLHNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	public MAKBLFBLHNI()
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
