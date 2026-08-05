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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x62333E0", Offset = "0x62323E0", VA = "0x1862333E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class EIGLIDJOLHA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x622C8F0", Offset = "0x622B8F0", VA = "0x18622C8F0")]
	public EIGLIDJOLHA(bool GKKJIOPPBAA, string FJOIPLDMLDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PBLJBNFPNBA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> KAHLBGIIPIH(CancellationToken JMJKFNJJBHM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FGJMJMGBAAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public PBLJBNFPNBA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KAHLBGIIPIH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x36720A0", Offset = "0x36710A0", VA = "0x1836720A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3673100", Offset = "0x3672100", VA = "0x183673100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource COPLNLJNKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? HIPEHNHDLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? FDFAJGFHMDJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4139CE0", Offset = "0x4138CE0", VA = "0x184139CE0")]
	[AsyncStateMachine(typeof(PBLJBNFPNBA<>.FGJMJMGBAAN))]
	public Task<TResult> CJBJHHPDJIO(KAHLBGIIPIH MJHNJJGOMAF, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4139E20", Offset = "0x4138E20", VA = "0x184139E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4139E90", Offset = "0x4138E90", VA = "0x184139E90")]
	public PBLJBNFPNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CECIPPNJGLA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> JBCFFHEBBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T ADACBBLDADO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x38E6920", Offset = "0x38E5920", VA = "0x1838E6920")]
	public CECIPPNJGLA([In] T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C770", Offset = "0x4C8B770", VA = "0x184C8C770", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CB10", Offset = "0x4C8BB10", VA = "0x184C8CB10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CC90", Offset = "0x4C8BC90", VA = "0x184C8CC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OAJELOCJJKA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6233460", Offset = "0x6232460", VA = "0x186233460")]
	public static void GCAMGDOBJAH(this CancellationTokenSource COPLNLJNKII, bool NAKJLKBPGMN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LCKPGCCHFLA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
	public LCKPGCCHFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CNNMBJEBBDE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
	public CNNMBJEBBDE(string FDKOAKOJDLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IEALIPMPCPP
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27DA120", Offset = "0x27D9120", VA = "0x1827DA120")]
	public static AHHHHCHPBMN HNAPNAMCMCA<T>()
	{
		return default(AHHHHCHPBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27D9F90", Offset = "0x27D8F90", VA = "0x1827D9F90")]
	public static AHHHHCHPBMN EJBFKNGCLMM<T>([CallerMemberName] string GCMHJLFFDHO = "") where T : notnull
	{
		return default(AHHHHCHPBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27DA1A0", Offset = "0x27D91A0", VA = "0x1827DA1A0")]
	public static AHHHHCHPBMN HNAPNAMCMCA<T>(this T IEHPEJEDEKI) where T : notnull
	{
		return default(AHHHHCHPBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27DA220", Offset = "0x27D9220", VA = "0x1827DA220")]
	public static AHHHHCHPBMN KLEFNNEPLMF<T>(this T IEHPEJEDEKI, [CallerMemberName] string GCMHJLFFDHO = "") where T : notnull
	{
		return default(AHHHHCHPBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27D9EF0", Offset = "0x27D8EF0", VA = "0x1827D9EF0")]
	public static AHHHHCHPBMN EJBFKNGCLMM<T>(this T AOFEPADBPDL, [CallerMemberName] string GCMHJLFFDHO = "") where T : notnull
	{
		return default(AHHHHCHPBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x622DE30", Offset = "0x622CE30", VA = "0x18622DE30")]
	public static AHHHHCHPBMN EJBFKNGCLMM(string ANJOAKJIEIN, [CallerMemberName] string GCMHJLFFDHO = "")
	{
		return default(AHHHHCHPBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x622DEB0", Offset = "0x622CEB0", VA = "0x18622DEB0")]
	public static string MECAGBKMOOC(this object AOFEPADBPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool INMEDGKHFEO();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[LCKPGCCHFLA]
public delegate long FLDAIALGPAG();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EDJLFOHNNNB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static JKIJOBIGMGE OGBEJMFFMNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JKIJOBIGMGE CKOGJFMOKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x622C020", Offset = "0x622B020", VA = "0x18622C020")]
		get
		{
			return default(JKIJOBIGMGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GIMLHPBOLKG NCGFFKLNHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x622C300", Offset = "0x622B300", VA = "0x18622C300")]
		get
		{
			return default(GIMLHPBOLKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OFIDEHIHCEH MFOKOAIICAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x622BF00", Offset = "0x622AF00", VA = "0x18622BF00")]
		get
		{
			return default(OFIDEHIHCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool JHMONHJKJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x622C500", Offset = "0x622B500", VA = "0x18622C500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x622C350", Offset = "0x622B350", VA = "0x18622C350")]
	public static void OOGOMMIPMGP([In] JKIJOBIGMGE DJMCPDKFMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x622BF50", Offset = "0x622AF50", VA = "0x18622BF50")]
	public static void LFPFJBDDFDP(string DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x622BE30", Offset = "0x622AE30", VA = "0x18622BE30")]
	public static void HHGJCABCFKG(string DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x266B040", Offset = "0x266A040", VA = "0x18266B040")]
	public static void HHGJCABCFKG<T>(T OMFIAODHHCI, HDBADDNEMFJ<T> DFJKCKBFLAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x622C1C0", Offset = "0x622B1C0", VA = "0x18622C1C0")]
	public static void NNPBFMNBJLK(Exception NNMGILNOFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x622BDD0", Offset = "0x622ADD0", VA = "0x18622BDD0")]
	public static void FIEGMHPHKNE(string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x622BD70", Offset = "0x622AD70", VA = "0x18622BD70")]
	public static void EBJMFBBCNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x622C070", Offset = "0x622B070", VA = "0x18622C070")]
	public static string MECAGBKMOOC(object FGOCJODIEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x622BD00", Offset = "0x622AD00", VA = "0x18622BD00")]
	public static long DJDHJNGPLOK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x622C260", Offset = "0x622B260", VA = "0x18622C260")]
	public static bool OBAHDLEGPKE(bool FPEAEOGHFOG, string DFJKCKBFLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x622C0F0", Offset = "0x622B0F0", VA = "0x18622C0F0")]
	public static double NCOEEHDJKEN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JKIJOBIGMGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly GIMLHPBOLKG NCGFFKLNHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly OFIDEHIHCEH MFOKOAIICAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly DAOJBIBCKBE JMKLIPGCDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly FLDAIALGPAG DPCMPGKFGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly IJFOJEMOJNI LLOFCOHKEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly INMEDGKHFEO LNHALOJBBLL;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly DAOJBIBCKBE LJLKGFBFDLG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FLDAIALGPAG KDAIPPCMLMA;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly IJFOJEMOJNI IJILLHINJIA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly INMEDGKHFEO BDNJLFPGLAE;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JKIJOBIGMGE ECAIHANDNCF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EKAOBJEABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x622EBF0", Offset = "0x622DBF0", VA = "0x18622EBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x622F5D0", Offset = "0x622E5D0", VA = "0x18622F5D0")]
	public JKIJOBIGMGE([In] GIMLHPBOLKG IEOFKOIHHHO, [In] OFIDEHIHCEH PILDOIKHGEN, DAOJBIBCKBE IAHJMPLMJLK, FLDAIALGPAG AKBBPGMENIB, IJFOJEMOJNI EPJMLOIKJCP, INMEDGKHFEO OEEAGGPLGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x622EEA0", Offset = "0x622DEA0", VA = "0x18622EEA0")]
	private static string NFOADBJJAMF(object FGOCJODIEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290")]
	private static long AFFABLDMIID()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	private static string IADPELBFPLL(string BBECBJENJIE, string? AHLEHOLMIAD, bool MNEIILAOOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	private static bool DMPFLFAEDBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x622ED90", Offset = "0x622DD90", VA = "0x18622ED90")]
	private static JKIJOBIGMGE LJCKNCCAHPG()
	{
		return default(JKIJOBIGMGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GEAIHKLKLDN
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICONKCMGDDM FLAMAHAJCAD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ICONKCMGDDM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GFGNILMDJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENMLFHFCKHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CFFCNEHDDII<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPBLCPAGKGA([In] T PJNBIAFGNNN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void JHNIFFHHLGA<T>([In] T OMFIAODHHCI);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct NHJCHIEAGNG<T> : IEquatable<NHJCHIEAGNG<T>>, CFFCNEHDDII<NHJCHIEAGNG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T ADACBBLDADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int EDPEAEGJAAB;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE78F0", Offset = "0x1DE68F0", VA = "0x181DE78F0")]
	public NHJCHIEAGNG([In] T CFJDHAGGAJO, int GCDIELAOHNA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3F7DC00", Offset = "0x3F7CC00", VA = "0x183F7DC00")]
	public static bool INAKJEGDKIC([In] NHJCHIEAGNG<T> FKOPFOECIGH, [In] NHJCHIEAGNG<T> DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D500", Offset = "0x3F7C500", VA = "0x183F7D500", Slot = "4")]
	public bool Equals(NHJCHIEAGNG<T> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DB40", Offset = "0x3B4CB40", VA = "0x183B4DB40", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D470", Offset = "0x3F7C470", VA = "0x183F7D470")]
	public bool DPBLCPAGKGA([In] NHJCHIEAGNG<T> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D970", Offset = "0x3F7C970", VA = "0x183F7D970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3F7E9D0", Offset = "0x3F7D9D0", VA = "0x183F7E9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3F7E120", Offset = "0x3F7D120", VA = "0x183F7E120")]
	public void PHGKEHMLKIB([Out] T CFJDHAGGAJO, [Out] int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D0F0", Offset = "0x3F7C0F0", VA = "0x183F7D0F0")]
	public (T, int) BOACBOKKJGD()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D040", Offset = "0x3F7C040", VA = "0x183F7D040", Slot = "5")]
	private bool AOCLCDGEHDJ([In] NHJCHIEAGNG<T> PJNBIAFGNNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class PJNDMLNEIPH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2932630", Offset = "0x2931630", VA = "0x182932630")]
	public static NHJCHIEAGNG<T> NAJBLLJFKKI<T>([In] T CFJDHAGGAJO, int GCDIELAOHNA) where T : notnull
	{
		return default(NHJCHIEAGNG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KOGMMNOGFBK
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2831BA0", Offset = "0x2830BA0", VA = "0x182831BA0")]
	public static bool DPBLCPAGKGA<T, U>([In] T AOFEPADBPDL, [In] U FGOCJODIEMI) where T : notnull, CFFCNEHDDII<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult KNPJMLFJDLK<T, out TResult>([In] T OMFIAODHHCI);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KMNFHKBHOJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan DIFPNJBIPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? GMLPGDKGCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBEKMFPLELC();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEAJMEEOAAF();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECBGDFNMHFA();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct GIMLHPBOLKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GHCCOHBCEND MICDDDFJCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly LCDIKMAFKOP ENEHGKHPLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly GHCCOHBCEND BBDJPDGIEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly LCDIKMAFKOP GLEPEJNOIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly GHCCOHBCEND CAMOGMFPDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly LCDIKMAFKOP FENPLBOGBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly KNABFDBILKH FFDOCHFMNLI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly GHCCOHBCEND LBCCPCEEHBK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly LCDIKMAFKOP LLNLAEFIMMO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GHCCOHBCEND FIDEOOGEBGF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly LCDIKMAFKOP CCEIKGIAEOF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GHCCOHBCEND FKCJCNEDODI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly LCDIKMAFKOP LOODJDOAIPD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KNABFDBILKH EKHOIADKJLO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GIMLHPBOLKG ECAIHANDNCF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly GHCCOHBCEND NAFOPPKBIGI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EKAOBJEABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x622CBA0", Offset = "0x622BBA0", VA = "0x18622CBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9D3FF0", Offset = "0x9D2FF0", VA = "0x1809D3FF0")]
	public GIMLHPBOLKG(GHCCOHBCEND MAFFENKAHLA, LCDIKMAFKOP FEIJGKIHCGL, GHCCOHBCEND COOENOFGLIE, LCDIKMAFKOP JIDNGPKPDDC, GHCCOHBCEND PFGKNFJIAMG, LCDIKMAFKOP DBECMCIFJKO, KNABFDBILKH JGLNPACMHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	private static bool ABMBCGBJPEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private static void KIAPECGKLGO(string DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	private static bool DAEDFKIPLIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private static void AFIOIBHHDOG(string DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	private static bool MCOHCLNJKPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private static void OPPPHNMPNHI(string DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private static void HJMAJHGNNKH(Exception NNMGILNOFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x622CE10", Offset = "0x622BE10", VA = "0x18622CE10")]
	private static GIMLHPBOLKG LJCKNCCAHPG()
	{
		return default(GIMLHPBOLKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100")]
	private static bool DPBJDOBODIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x622CDA0", Offset = "0x622BDA0", VA = "0x18622CDA0")]
	public void LFPFJBDDFDP(object DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x622CB30", Offset = "0x622BB30", VA = "0x18622CB30")]
	public void HHGJCABCFKG(object DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x19E51A0", Offset = "0x19E41A0", VA = "0x1819E51A0")]
	public void NNPBFMNBJLK(Exception NNMGILNOFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x622CA50", Offset = "0x622BA50", VA = "0x18622CA50")]
	public void HHGJCABCFKG(JIAIBJJNCGC DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2799450", Offset = "0x2798450", VA = "0x182799450")]
	public void HHGJCABCFKG<T>(T OMFIAODHHCI, HDBADDNEMFJ<T> DFJKCKBFLAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2799510", Offset = "0x2798510", VA = "0x182799510")]
	public void LFPFJBDDFDP<T>([In] T OMFIAODHHCI, ADEPAAHDHNP<T> DFJKCKBFLAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x622CF50", Offset = "0x622BF50", VA = "0x18622CF50")]
	public bool OBAHDLEGPKE(bool FPEAEOGHFOG, string DFJKCKBFLAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct AHHHHCHPBMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string ADACBBLDADO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	public AHHHHCHPBMN(string CFJDHAGGAJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0")]
	public static string GGALBBDOOLM([In] AHHHHCHPBMN AOFEPADBPDL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x14CCC90", Offset = "0x14CBC90", VA = "0x1814CCC90")]
	public static AHHHHCHPBMN GGALBBDOOLM(string PJNBIAFGNNN)
	{
		return default(AHHHHCHPBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x622A200", Offset = "0x6229200", VA = "0x18622A200")]
	public string ABALJKCHPPH(string HHMGHNBINBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x622A250", Offset = "0x6229250", VA = "0x18622A250")]
	public string LBCABIBCFHD(object OMGDFOAKJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct EMBFKEMHPML : IEquatable<EMBFKEMHPML>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "4")]
	public bool Equals(EMBFKEMHPML PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x622C9C0", Offset = "0x622B9C0", VA = "0x18622C9C0", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x622CA10", Offset = "0x622BA10", VA = "0x18622CA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x622CA20", Offset = "0x622BA20", VA = "0x18622CA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[HGNKAKLJIMO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DCPPBKBIMOM<T> : IEquatable<DCPPBKBIMOM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T ADACBBLDADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool KIKDDMICGLH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LEPAGGPBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50AC140", Offset = "0x50AB140", VA = "0x1850AC140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x50AD300", Offset = "0x50AC300", VA = "0x1850AD300")]
	public DCPPBKBIMOM([In] T CFJDHAGGAJO, bool DHGHEPDABDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x50ACD70", Offset = "0x50ABD70", VA = "0x1850ACD70")]
	public static bool INAKJEGDKIC([In] DCPPBKBIMOM<T> FKOPFOECIGH, [In] DCPPBKBIMOM<T> DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D500", Offset = "0x3F7C500", VA = "0x183F7D500", Slot = "4")]
	public bool Equals(DCPPBKBIMOM<T> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x50AC2C0", Offset = "0x50AB2C0", VA = "0x1850AC2C0", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x50AC890", Offset = "0x50AB890", VA = "0x1850AC890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x50ACFE0", Offset = "0x50ABFE0", VA = "0x1850ACFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class PMBBILNKBLH
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2935360", Offset = "0x2934360", VA = "0x182935360")]
	public static DCPPBKBIMOM<T> GOJBDKCMNLO<T>([In] T CFJDHAGGAJO) where T : notnull
	{
		return default(DCPPBKBIMOM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2935230", Offset = "0x2934230", VA = "0x182935230")]
	public static DCPPBKBIMOM<T?> AEALEDLFGGC<T>()
	{
		return default(DCPPBKBIMOM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2935420", Offset = "0x2934420", VA = "0x182935420")]
	public static bool NGOAMJNKHPK<T>([In] this DCPPBKBIMOM<T> BLGICIBCBKI, [Out][NotNullWhen(true)] T CFJDHAGGAJO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct OFIDEHIHCEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr FIEGMHPHKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr EBJMFBBCNNH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr CILNJMPNLKM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr OOBKGDHJOIL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly OFIDEHIHCEH ECAIHANDNCF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EKAOBJEABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6233490", Offset = "0x6232490", VA = "0x186233490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
	public OFIDEHIHCEH(IntPtr HJBDHAALIPD, IntPtr MCJICMEGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private static void DEAGHLBGGHP(string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private static void PBKKJLNLNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6233570", Offset = "0x6232570", VA = "0x186233570")]
	private static OFIDEHIHCEH LJCKNCCAHPG()
	{
		return default(OFIDEHIHCEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct KGMKKOKAHEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr IADNEGIFJNL;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	private KGMKKOKAHEN(IntPtr MCJICMEGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x622FA10", Offset = "0x622EA10", VA = "0x18622FA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x622FA20", Offset = "0x622EA20", VA = "0x18622FA20")]
	public static KGMKKOKAHEN NAJBLLJFKKI(string GCMHJLFFDHO)
	{
		return default(KGMKKOKAHEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DD31F0", Offset = "0x1DD21F0", VA = "0x181DD31F0")]
	public static KGMKKOKAHEN NAJBLLJFKKI([In] OFIDEHIHCEH PILDOIKHGEN, string GCMHJLFFDHO)
	{
		return default(KGMKKOKAHEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DD33A0", Offset = "0x1DD23A0", VA = "0x181DD33A0")]
	public static KGMKKOKAHEN NAJBLLJFKKI([In] OFIDEHIHCEH PILDOIKHGEN, Func<string> GCMHJLFFDHO)
	{
		return default(KGMKKOKAHEN);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NDCEPNLILPI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool MIJBPGKAPEO<in TInput, TResult>(TInput IIBDJBFNFJM, [Out] TResult HEOGODCLBDD);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class LDMCCFHLPGA : GEAIHKLKLDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class KMJNEFINKDJ : ICONKCMGDDM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly KMJNEFINKDJ GDAKEGIGEFB;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool GFGNILMDJGN
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x622FB10", Offset = "0x622EB10", VA = "0x18622FB10", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x622FB70", Offset = "0x622EB70", VA = "0x18622FB70", Slot = "6")]
			public void OnCompleted(Action HNDABBDLJKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			public void ENMLFHFCKHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public KMJNEFINKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly LDMCCFHLPGA GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private LDMCCFHLPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6230BF0", Offset = "0x622FBF0", VA = "0x186230BF0", Slot = "4")]
		public ICONKCMGDDM FLAMAHAJCAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class JEEFNDMLBKC : GEAIHKLKLDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class DPPMHCMIGCF : ICONKCMGDDM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly DPPMHCMIGCF GDAKEGIGEFB;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool GFGNILMDJGN
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x622BC10", Offset = "0x622AC10", VA = "0x18622BC10", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x622BC30", Offset = "0x622AC30", VA = "0x18622BC30", Slot = "6")]
			public void OnCompleted(Action HNDABBDLJKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			public void ENMLFHFCKHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public DPPMHCMIGCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly JEEFNDMLBKC GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private JEEFNDMLBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x622EB20", Offset = "0x622DB20", VA = "0x18622EB20", Slot = "4")]
		public ICONKCMGDDM FLAMAHAJCAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CNDKMGBDGLB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CNDKMGBDGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x373D130", Offset = "0x373C130", VA = "0x18373D130")]
		internal void EGBEPIDIKFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class HLMLHJLIIJJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HLMLHJLIIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x37EAC60", Offset = "0x37E9C60", VA = "0x1837EAC60")]
		internal void JJHJCNCOGBK(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct DBHDNGKEHCD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622B640", Offset = "0x622A640", VA = "0x18622B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891030", VA = "0x180892030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LEEOIALOHJI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6230CC0", Offset = "0x622FCC0", VA = "0x186230CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891030", VA = "0x180892030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CEOMMDKGNBL<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x4C8E050", Offset = "0x4C8D050", VA = "0x184C8E050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C8E1C0", Offset = "0x4C8D1C0", VA = "0x184C8E1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PCAKPAPAPNN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x413BAD0", Offset = "0x413AAD0", VA = "0x18413BAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x413BF10", Offset = "0x413AF10", VA = "0x18413BF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KBNOHOLBLND : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622F680", Offset = "0x622E680", VA = "0x18622F680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x622F880", Offset = "0x622E880", VA = "0x18622F880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GCMAJCJMAGG<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GCMAJCJMAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x373D130", Offset = "0x373C130", VA = "0x18373D130")]
		internal void JBOOFHIIEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x373D170", Offset = "0x373C170", VA = "0x18373D170")]
		internal void NJODBMBNADA(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PHHNHDLGGGJ<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public MIJBPGKAPEO<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4149A80", Offset = "0x4148A80", VA = "0x184149A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x414A170", Offset = "0x4149170", VA = "0x18414A170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DADHLHOFIGD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622ADF0", Offset = "0x6229DF0", VA = "0x18622ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x622B5E0", Offset = "0x622A5E0", VA = "0x18622B5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct MDGFMMCCDFH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6230E40", Offset = "0x622FE40", VA = "0x186230E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6231380", Offset = "0x6230380", VA = "0x186231380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ECGGBJEOPOD<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x330A620", Offset = "0x3309620", VA = "0x18330A620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x330B510", Offset = "0x330A510", VA = "0x18330B510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NNDKLPPFIEI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3F9DE90", Offset = "0x3F9CE90", VA = "0x183F9DE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x33286B0", Offset = "0x33276B0", VA = "0x1833286B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct PAHNEEGNMEC<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x411B310", Offset = "0x411A310", VA = "0x18411B310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x411BA10", Offset = "0x411AA10", VA = "0x18411BA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct NMKKKJGCPDM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6232FC0", Offset = "0x6231FC0", VA = "0x186232FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x62331A0", Offset = "0x62321A0", VA = "0x1862331A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IIMBKGLHMLK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622E650", Offset = "0x622D650", VA = "0x18622E650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x622E9C0", Offset = "0x622D9C0", VA = "0x18622E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct BLKDCOANEKI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622AA50", Offset = "0x6229A50", VA = "0x18622AA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x622AD40", Offset = "0x6229D40", VA = "0x18622AD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LIDOANBAJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LIDOANBAJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6230DD0", Offset = "0x622FDD0", VA = "0x186230DD0")]
		internal Task FFOLLKDADIM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct EDPCBIFKJCF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622C630", Offset = "0x622B630", VA = "0x18622C630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x622C890", Offset = "0x622B890", VA = "0x18622C890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct PAHDKBOCOMN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6233A10", Offset = "0x6232A10", VA = "0x186233A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6233BF0", Offset = "0x6232BF0", VA = "0x186233BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct ALMNPEEJGKN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622A680", Offset = "0x6229680", VA = "0x18622A680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x622A9F0", Offset = "0x62299F0", VA = "0x18622A9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct AJGFKBLDCFF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622A330", Offset = "0x6229330", VA = "0x18622A330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x622A620", Offset = "0x6229620", VA = "0x18622A620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class ADBFJENJCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ADBFJENJCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x622A190", Offset = "0x6229190", VA = "0x18622A190")]
		internal Task DADIAHHFGPL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct OLILCJCNGLN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6233750", Offset = "0x6232750", VA = "0x186233750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x62339B0", Offset = "0x62329B0", VA = "0x1862339B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct NNMAHIAJMNE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6233200", Offset = "0x6232200", VA = "0x186233200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6233380", Offset = "0x6232380", VA = "0x186233380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JFGCOOBFJNL<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3B37F10", Offset = "0x3B36F10", VA = "0x183B37F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3B38170", Offset = "0x3B37170", VA = "0x183B38170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DPBCJCMFCFC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x622B7A0", Offset = "0x622A7A0", VA = "0x18622B7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x622BBB0", Offset = "0x622ABB0", VA = "0x18622BBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? IDDMALGIEKA;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<EMBFKEMHPML> AGJMPFNGMLC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task PBIFANLHHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6232210", Offset = "0x6231210", VA = "0x186232210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6232540", Offset = "0x6231540", VA = "0x186232540")]
	public static bool IHAOCDIEPBG(this Task JCGMNOGFGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28E89A0", Offset = "0x28E79A0", VA = "0x1828E89A0")]
	public static Task<T> NDODADCIIOH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6232BF0", Offset = "0x6231BF0", VA = "0x186232BF0")]
	public static Task OCLEPODGFEI(this Task JCGMNOGFGHB, CancellationToken OGACLNNOKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x28EA900", Offset = "0x28E9900", VA = "0x1828EA900")]
	public static Task<TResult> OCLEPODGFEI<TResult>(this Task<TResult> JCGMNOGFGHB, CancellationToken OGACLNNOKDA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x28EB150", Offset = "0x28EA150", VA = "0x1828EB150")]
	public static TaskCompletionSource<TResult> OCLEPODGFEI<TResult>(this TaskCompletionSource<TResult> BEBOGKEEMEA, CancellationToken OGACLNNOKDA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6231BD0", Offset = "0x6230BD0", VA = "0x186231BD0")]
	[AsyncStateMachine(typeof(DBHDNGKEHCD))]
	public static void DFEGAKFCBOI(this Task MPLEEKHPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6232E50", Offset = "0x6231E50", VA = "0x186232E50")]
	[AsyncStateMachine(typeof(LEEOIALOHJI))]
	public static void OFKADEBOCJO(this Task MPLEEKHPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28E8710", Offset = "0x28E7710", VA = "0x1828E8710")]
	[AsyncStateMachine(typeof(CEOMMDKGNBL<>))]
	public static Task LCKNEKHNMML<TException>(this Task MPLEEKHPBJH) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28E7D20", Offset = "0x28E6D20", VA = "0x1828E7D20")]
	[AsyncStateMachine(typeof(PCAKPAPAPNN<>))]
	public static Task<T> FLMIHNIMBHJ<T>(this Task<T> AOFEPADBPDL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6231E80", Offset = "0x6230E80", VA = "0x186231E80")]
	[AsyncStateMachine(typeof(KBNOHOLBLND))]
	public static Task<TaskStatus> EJJNOADCDPL(this Task AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x28E7EE0", Offset = "0x28E6EE0", VA = "0x1828E7EE0")]
	public static (Task<T?>?, Action<T?>?) GOGFAFCJHOG<T>([Optional] CancellationToken JMJKFNJJBHM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28E7C20", Offset = "0x28E6C20", VA = "0x1828E7C20")]
	[AsyncStateMachine(typeof(PHHNHDLGGGJ<, >))]
	public static Task<List<TResult>> BOEGIGIEOHN<TResult, TInput>(this Task<List<TInput>> JCGMNOGFGHB, MIJBPGKAPEO<TInput, TResult> LGCOJKEBEFN) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62313E0", Offset = "0x62303E0", VA = "0x1862313E0")]
	[AsyncStateMachine(typeof(DADHLHOFIGD))]
	public static Task AEGNCHNFJNA(Task MPLEEKHPBJH, CancellationToken JOEEALIOINJ, Func<CancellationToken, Task> CHFPNBJBDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6232410", Offset = "0x6231410", VA = "0x186232410")]
	[AsyncStateMachine(typeof(MDGFMMCCDFH))]
	public static Task HOCLFJPDPML(Func<CancellationToken, Task> JFGBEMDJAJO, TimeSpan ONBAFMEFHPF, [Optional] CancellationToken JOEEALIOINJ, [Optional] Action<OperationCanceledException>? LMNEDKJPPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28E8120", Offset = "0x28E7120", VA = "0x1828E8120")]
	[AsyncStateMachine(typeof(ECGGBJEOPOD<>))]
	public static Task<T> HOCLFJPDPML<T>(Func<CancellationToken, Task<T>> JFGBEMDJAJO, TimeSpan ONBAFMEFHPF, [Optional] CancellationToken JOEEALIOINJ, [Optional] Func<OperationCanceledException, T>? LMNEDKJPPOK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28E88C0", Offset = "0x28E78C0", VA = "0x1828E88C0")]
	[AsyncStateMachine(typeof(NNDKLPPFIEI<>))]
	public static Task<IEnumerable<Task<T>>> MHIBEGLKNMD<T>(IEnumerable<Task<T>> NIPGBCCGBIO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x28E8470", Offset = "0x28E7470", VA = "0x1828E8470")]
	[AsyncStateMachine(typeof(PAHNEEGNMEC<, , , >))]
	public static Task<(T1, T2, T3, T4)> KALLHKMPMIK<T1, T2, T3, T4>(Task<T1> ENCBMDJAMJI, Task<T2> NNPKBFGDMIL, Task<T3> APMDJDLKNGI, Task<T4> MFCFINPHNHF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62328D0", Offset = "0x62318D0", VA = "0x1862328D0")]
	[AsyncStateMachine(typeof(NMKKKJGCPDM))]
	public static Task KPHACJJFCNC(Func<bool> FPEAEOGHFOG, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x62329C0", Offset = "0x62319C0", VA = "0x1862329C0")]
	[AsyncStateMachine(typeof(IIMBKGLHMLK))]
	public static Task KPHACJJFCNC(Func<bool> FPEAEOGHFOG, TimeSpan AEMENOLFKOI, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6231960", Offset = "0x6230960", VA = "0x186231960")]
	[AsyncStateMachine(typeof(BLKDCOANEKI))]
	public static Task CIMMOLHBDJF(Func<bool> FPEAEOGHFOG, TimeSpan ONBAFMEFHPF, [Optional] CancellationToken JMJKFNJJBHM, [Optional] Action<OperationCanceledException>? LMNEDKJPPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6231A90", Offset = "0x6230A90", VA = "0x186231A90")]
	[AsyncStateMachine(typeof(EDPCBIFKJCF))]
	public static Task CIMMOLHBDJF(Func<bool> FPEAEOGHFOG, TimeSpan ONBAFMEFHPF, TimeSpan AEMENOLFKOI, [Optional] CancellationToken JMJKFNJJBHM, [Optional] Action<OperationCanceledException>? LMNEDKJPPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6231C80", Offset = "0x6230C80", VA = "0x186231C80")]
	[AsyncStateMachine(typeof(PAHDKBOCOMN))]
	public static Task EAPKLMCCBIO(Func<bool> FPEAEOGHFOG, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6231D70", Offset = "0x6230D70", VA = "0x186231D70")]
	[AsyncStateMachine(typeof(ALMNPEEJGKN))]
	public static Task EAPKLMCCBIO(Func<bool> FPEAEOGHFOG, TimeSpan AEMENOLFKOI, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6232660", Offset = "0x6231660", VA = "0x186232660")]
	[AsyncStateMachine(typeof(AJGFKBLDCFF))]
	public static Task KKNHCANJGKK(Func<bool> FPEAEOGHFOG, TimeSpan ONBAFMEFHPF, [Optional] CancellationToken JMJKFNJJBHM, [Optional] Action<OperationCanceledException>? LMNEDKJPPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6232790", Offset = "0x6231790", VA = "0x186232790")]
	[AsyncStateMachine(typeof(OLILCJCNGLN))]
	public static Task KKNHCANJGKK(Func<bool> FPEAEOGHFOG, TimeSpan ONBAFMEFHPF, TimeSpan AEMENOLFKOI, [Optional] CancellationToken JMJKFNJJBHM, [Optional] Action<OperationCanceledException>? LMNEDKJPPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6232570", Offset = "0x6231570", VA = "0x186232570")]
	[Obsolete]
	[AsyncStateMachine(typeof(NNMAHIAJMNE))]
	public static Task IJDKNMIIJEJ(this Task JCGMNOGFGHB, Action AKMNMCMEMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x28E8380", Offset = "0x28E7380", VA = "0x1828E8380")]
	[AsyncStateMachine(typeof(JFGCOOBFJNL<>))]
	[Obsolete]
	public static Task IJDKNMIIJEJ<T>(this Task<T> JCGMNOGFGHB, Action<T> AKMNMCMEMGM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6232160", Offset = "0x6231160", VA = "0x186232160")]
	private static void GIEAGLFLFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62315E0", Offset = "0x62305E0", VA = "0x1862315E0")]
	public static bool CAHGMEFMMMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6232280", Offset = "0x6231280", VA = "0x186232280")]
	private static void GKNEMFJJHCN(SynchronizationContext CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6232040", Offset = "0x6231040", VA = "0x186232040")]
	private static void FOAFFDDPKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6231F70", Offset = "0x6230F70", VA = "0x186231F70")]
	public static void ENDNDAIPEBP([Optional] string? DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6232B20", Offset = "0x6231B20", VA = "0x186232B20")]
	public static void MGEIFIBBOLH([Optional] string? DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6232AD0", Offset = "0x6231AD0", VA = "0x186232AD0")]
	public static GEAIHKLKLDN MFBNGHJBFJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6232BA0", Offset = "0x6231BA0", VA = "0x186232BA0")]
	public static GEAIHKLKLDN MIFIGCBEAME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6231510", Offset = "0x6230510", VA = "0x186231510")]
	[AsyncStateMachine(typeof(DPBCJCMFCFC))]
	public static Task AFPDFNPBLCE(Func<Task> MNLLJIAJFCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class BLFHHLMIMBP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
	public BLFHHLMIMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KFEDJJADMKE : MJFHKAKOPCC
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly MJFHKAKOPCC GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime DAFFGICKNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x622F8F0", Offset = "0x622E8F0", VA = "0x18622F8F0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset DOJDDOFDJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x622F930", Offset = "0x622E930", VA = "0x18622F930", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KFEDJJADMKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MJFHKAKOPCC
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime DAFFGICKNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset DOJDDOFDJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class GJOKCLHDODA
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long LJLKNNOAKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x622D7C0", Offset = "0x622C7C0", VA = "0x18622D7C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long LGNLFNHPBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x622D650", Offset = "0x622C650", VA = "0x18622D650")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double IHKEKADOPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x622D930", Offset = "0x622C930", VA = "0x18622D930")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double OIOFHLBFKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x622D600", Offset = "0x622C600", VA = "0x18622D600")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double OJOLPJJGDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x622DAA0", Offset = "0x622CAA0", VA = "0x18622DAA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double IFLECIKGIBE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x622D8E0", Offset = "0x622C8E0", VA = "0x18622D8E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x622D730", Offset = "0x622C730", VA = "0x18622D730")]
	public static double ENMMMGHBFMK(long EBAGKBOLJIN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x622DA10", Offset = "0x622CA10", VA = "0x18622DA10")]
	public static double LGGDCKKAKKA(long EBAGKBOLJIN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x622D6A0", Offset = "0x622C6A0", VA = "0x18622D6A0")]
	public static double BNHCFBHDEKI(double ODCAGDKELBJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x622D980", Offset = "0x622C980", VA = "0x18622D980")]
	public static long IIIEPHPFCGM(long KMADAIPOJJD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x622DAF0", Offset = "0x622CAF0", VA = "0x18622DAF0")]
	public static long MFDAMIFPNNL(long HNJOGPCDHBH, long JICEDICCGDN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x622D810", Offset = "0x622C810", VA = "0x18622D810")]
	public static double FIKMEIMIHLJ(long HNJOGPCDHBH, long JICEDICCGDN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x622DB00", Offset = "0x622CB00", VA = "0x18622DB00")]
	public static double MHLMMLBKMPF(long HNJOGPCDHBH, long JICEDICCGDN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class IEBKKKBNKGJ : KMNFHKBHOJG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan BACGIFDANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer HKNHNBDNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan ONBAFMEFHPF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan DIFPNJBIPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x622E1C0", Offset = "0x622D1C0", VA = "0x18622E1C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? GMLPGDKGCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x622E390", Offset = "0x622D390", VA = "0x18622E390")]
	[Preserve]
	public IEBKKKBNKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x622E400", Offset = "0x622D400", VA = "0x18622E400")]
	public IEBKKKBNKGJ(TimeSpan ONBAFMEFHPF, [Optional] Action? FLFLONLANFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x622DFF0", Offset = "0x622CFF0", VA = "0x18622DFF0", Slot = "7")]
	public void EBEKMFPLELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x622E150", Offset = "0x622D150", VA = "0x18622E150", Slot = "8")]
	public void FEAJMEEOAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x622E080", Offset = "0x622D080", VA = "0x18622E080", Slot = "9")]
	public void ECBGDFNMHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xC36670", Offset = "0xC35670", VA = "0x180C36670")]
	private void KFBJPMCOAHD(object IEHPEJEDEKI, ElapsedEventArgs IBBENBAPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x622E0B0", Offset = "0x622D0B0", VA = "0x18622E0B0")]
	private static void FDJFBAHEDBP(TimeSpan OOBKMINAJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x622DF50", Offset = "0x622CF50", VA = "0x18622DF50", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class HGNKAKLJIMO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string FPJCOOIGBLL;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
	public HGNKAKLJIMO(string LLMKDGFJDOI)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KNBLNBFDADF : IEquatable<KNBLNBFDADF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint BBMNNBLIJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int LFLOHPPPGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float BANJAOKEIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort KBOLFDABPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort APONDKBDIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short JDDLOMPHOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short KGPAHPGJMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char IHPMOGGKEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char NJLEEIIENAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte EOCBDBEKHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte EDMDHKAOEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte MLPJIFJBBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte KFOPPHBBCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool MFNCDJJBEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool NPAAGJGNMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool ELCJFNKNHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool FBEEHIPLIBH;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD8A8A0", Offset = "0xD898A0", VA = "0x180D8A8A0")]
	public static KNBLNBFDADF NLONJBNBPIK(uint JEIGMFIHDFP)
	{
		return default(KNBLNBFDADF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD8A8A0", Offset = "0xD898A0", VA = "0x180D8A8A0")]
	public static KNBLNBFDADF OHCHEKEMNEN(int EBCEIBEPKJP)
	{
		return default(KNBLNBFDADF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x622FDF0", Offset = "0x622EDF0", VA = "0x18622FDF0")]
	public static KNBLNBFDADF FJMIDNDHJAM(float FJAAOFBINLA)
	{
		return default(KNBLNBFDADF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x622FD50", Offset = "0x622ED50", VA = "0x18622FD50")]
	public static KNBLNBFDADF BHIOCOPJGOO(byte IJIPHOMHCAC, byte JCKBFENCMFN, byte GIEAJOGEGPF, byte OIFNPNCDFIA)
	{
		return default(KNBLNBFDADF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x622FD50", Offset = "0x622ED50", VA = "0x18622FD50")]
	public static KNBLNBFDADF PIDAGCIODKI(bool EMDIKDJKGHH, bool BDCBFFLANCM, bool HECKAFJBMPJ, bool EDEKHDPEHCB)
	{
		return default(KNBLNBFDADF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x622FD50", Offset = "0x622ED50", VA = "0x18622FD50")]
	public static KNBLNBFDADF EDEJMEJBPFE(byte HMABIPJAAGH, byte IDGAFGAKALM, byte ADLJOPABPAG, byte EADJHJDOOHD)
	{
		return default(KNBLNBFDADF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x183F120", Offset = "0x183E120", VA = "0x18183F120")]
	public static bool INAKJEGDKIC(KNBLNBFDADF JAIIDLBPFND, KNBLNBFDADF ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x88EEC0", Offset = "0x88DEC0", VA = "0x18088EEC0", Slot = "4")]
	public bool Equals(KNBLNBFDADF PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x622FD70", Offset = "0x622ED70", VA = "0x18622FD70", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x946FF0", Offset = "0x945FF0", VA = "0x180946FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x622FE00", Offset = "0x622EE00", VA = "0x18622FE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CFDOPCGHAAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong PPOKOPPBPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long CHEPDJHIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double LOCAKJOPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint LKCHPBKADLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint KBFMEEGILMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int PJMPGEKFDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int ONMAEHBBLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float KFDDLHEKOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float ODGJJOOLBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort KBOLFDABPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort APONDKBDIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort EACKCKBOLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort IFDEJPNPGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short JDDLOMPHOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short KGPAHPGJMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short FKFIKICIONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short AMDLNCBELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char IHPMOGGKEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char NJLEEIIENAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char JGOAICOIAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char HKBPONBIJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte EOCBDBEKHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte EDMDHKAOEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte MLPJIFJBBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte KFOPPHBBCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte NAEPAEAOMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte KEAJHJMOMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte MEOENCIGLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte FJKKMJMMCMF;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x622ADA0", Offset = "0x6229DA0", VA = "0x18622ADA0")]
	public static CFDOPCGHAAB NAJBLLJFKKI(byte IJIPHOMHCAC, byte JCKBFENCMFN, byte GIEAJOGEGPF, byte OIFNPNCDFIA, byte MBKABDFABPD, byte ANHAOIMJMHO, byte HIHOJCPHNEJ, byte FDEJJPEBDCH)
	{
		return default(CFDOPCGHAAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class PEGDDMLDBBC<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly T IHEIEPGPPAD;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x413E870", Offset = "0x413D870", VA = "0x18413E870")]
	public PEGDDMLDBBC(T KEOGOLIHAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NDNJIGGFIHA
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x28EB940", Offset = "0x28EA940", VA = "0x1828EB940")]
	public static PEGDDMLDBBC<T> NAJBLLJFKKI<T>(T KEOGOLIHAKI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BHIBHEBGGKN
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2583AB0", Offset = "0x2582AB0", VA = "0x182583AB0")]
	public static IEnumerable<T> BGMKJFDLLJN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static T[] DOKGJFAFAOE<T>(params T[] NAAGFNKCJOK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static IEnumerable<T> OAOIHMGPLIN<T>(params T[] NAAGFNKCJOK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2583BC0", Offset = "0x2582BC0", VA = "0x182583BC0")]
	public static HashSet<T> MHLENFCKMEB<T>(params T[] NAAGFNKCJOK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2583AD0", Offset = "0x2582AD0", VA = "0x182583AD0")]
	public static KeyValuePair<TKey, TValue> BKONFIAOPLH<TKey, TValue>([In] TKey IPAJBJLLPIJ, [In] TValue CFJDHAGGAJO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2583BC0", Offset = "0x2582BC0", VA = "0x182583BC0")]
	public static List<T> ODEPGNANMAH<T>(IEnumerable<T> OAAIPIKOOLB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All)]
public sealed class GMPCNOECIMH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly string MDGCPFAHPKO;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
	public GMPCNOECIMH(string IIGDCCOFNDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object ADEPAAHDHNP<T>([In] T AFBHAGBGAAM);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object HDBADDNEMFJ<T>(T AFBHAGBGAAM);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[LCKPGCCHFLA]
public delegate string IJFOJEMOJNI(string BBECBJENJIE, string? AHLEHOLMIAD, bool MNEIILAOOHE);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LCKPGCCHFLA]
public delegate void LCDIKMAFKOP(string DFJKCKBFLAD);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[LCKPGCCHFLA]
public delegate void KNABFDBILKH(Exception NNMGILNOFJH);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object JIAIBJJNCGC();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[LCKPGCCHFLA]
public delegate bool GHCCOHBCEND();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[LCKPGCCHFLA]
public delegate string DAOJBIBCKBE(object FGOCJODIEMI);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Enum)]
public class AICAIOGCFHJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
	public AICAIOGCFHJ()
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
