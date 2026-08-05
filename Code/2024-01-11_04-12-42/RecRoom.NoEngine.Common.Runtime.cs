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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x6059120", Offset = "0x6057B20", VA = "0x186059120")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class FABFOPEKBNP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6052BC0", Offset = "0x60515C0", VA = "0x186052BC0")]
	public FABFOPEKBNP(bool FLFDCOCMBAB, string DLAGGDNDBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ABCLBLDFHNH<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> BLPCGFPHNFB(CancellationToken EAPNOLMLMHM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct ECMDKGMEIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ABCLBLDFHNH<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public BLPCGFPHNFB taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3234010", Offset = "0x3232A10", VA = "0x183234010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3235070", Offset = "0x3233A70", VA = "0x183235070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource DCEAHKDKEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? POANGEMMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? KDEBKHGIJHA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3649210", Offset = "0x3647C10", VA = "0x183649210")]
	[AsyncStateMachine(typeof(ABCLBLDFHNH<>.ECMDKGMEIBD))]
	public Task<TResult> BGFCMAAEAEN(BLPCGFPHNFB PJPLNBOIAPJ, [Optional] CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3649350", Offset = "0x3647D50", VA = "0x183649350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36493C0", Offset = "0x3647DC0", VA = "0x1836493C0")]
	public ABCLBLDFHNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MACBNMENHHI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> CMEDADHPHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T BMLGNHJJEIP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35D7A20", Offset = "0x35D6420", VA = "0x1835D7A20")]
	public MACBNMENHHI([In] T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3DBFFE0", Offset = "0x3DBE9E0", VA = "0x183DBFFE0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0590", Offset = "0x3DBEF90", VA = "0x183DC0590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3DC05F0", Offset = "0x3DBEFF0", VA = "0x183DC05F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DMOKMHOPOIN
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6051150", Offset = "0x604FB50", VA = "0x186051150")]
	public static void EONDIDHBNAH(this CancellationTokenSource DCEAHKDKEFI, bool JIGEGCPLOIH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class NBJNJOIPMPA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
	public NBJNJOIPMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CONGGIJALNK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
	public CONGGIJALNK(string FPHEGBNAOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GHKDNGAIFFD
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x260A180", Offset = "0x2608B80", VA = "0x18260A180")]
	public static AOIALOCGNFG KPPCLNJEAHC<T>()
	{
		return default(AOIALOCGNFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2609F50", Offset = "0x2608950", VA = "0x182609F50")]
	public static AOIALOCGNFG IBDIOBOGFAM<T>([CallerMemberName] string CDHDOGOGPME = "") where T : notnull
	{
		return default(AOIALOCGNFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x260A200", Offset = "0x2608C00", VA = "0x18260A200")]
	public static AOIALOCGNFG KPPCLNJEAHC<T>(this T HNGEGNONPGJ) where T : notnull
	{
		return default(AOIALOCGNFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2609DD0", Offset = "0x26087D0", VA = "0x182609DD0")]
	public static AOIALOCGNFG GJOPJDCCPNA<T>(this T HNGEGNONPGJ, [CallerMemberName] string CDHDOGOGPME = "") where T : notnull
	{
		return default(AOIALOCGNFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2609FE0", Offset = "0x26089E0", VA = "0x182609FE0")]
	public static AOIALOCGNFG IBDIOBOGFAM<T>(this T JFFAAHPEFOB, [CallerMemberName] string CDHDOGOGPME = "") where T : notnull
	{
		return default(AOIALOCGNFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60538A0", Offset = "0x60522A0", VA = "0x1860538A0")]
	public static AOIALOCGNFG IBDIOBOGFAM(string BFKCEGOLABL, [CallerMemberName] string CDHDOGOGPME = "")
	{
		return default(AOIALOCGNFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6053800", Offset = "0x6052200", VA = "0x186053800")]
	public static string BBMMCJFNAGK(this object JFFAAHPEFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool HNGFKADOOBM();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NBJNJOIPMPA]
public delegate long BONCMNODOAM();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GBDNGNGBHCA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DPGNEEKBLNF OMOLLAGGOIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DPGNEEKBLNF OBABEOHHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6053070", Offset = "0x6051A70", VA = "0x186053070")]
		get
		{
			return default(DPGNEEKBLNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GNMIEGLEGIH KJJNCOCFIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6052F50", Offset = "0x6051950", VA = "0x186052F50")]
		get
		{
			return default(GNMIEGLEGIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IFGBPCBJDGI EMNNKNPELMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6053290", Offset = "0x6051C90", VA = "0x186053290")]
		get
		{
			return default(IFGBPCBJDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool OBGIKFJHNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6053600", Offset = "0x6052000", VA = "0x186053600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60533B0", Offset = "0x6051DB0", VA = "0x1860533B0")]
	public static void LFAJJLEIBJG([In] DPGNEEKBLNF FNNHMAPOCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6052FA0", Offset = "0x60519A0", VA = "0x186052FA0")]
	public static void CIBIHDAPBBB(string BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60532E0", Offset = "0x6051CE0", VA = "0x1860532E0")]
	public static void KBALLEFNGKH(string BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25F2300", Offset = "0x25F0D00", VA = "0x1825F2300")]
	public static void KBALLEFNGKH<T>(T GKNEMODKAOC, LGFGDOGOOPH<T> BKNCBJIACBJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6053560", Offset = "0x6051F60", VA = "0x186053560")]
	public static void MLKMFAKLMPL(Exception KHDPHPEGJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6053230", Offset = "0x6051C30", VA = "0x186053230")]
	public static void IPPIMDCILNE(string CDHDOGOGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6053670", Offset = "0x6052070", VA = "0x186053670")]
	public static void OHBBJCLBILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6052ED0", Offset = "0x60518D0", VA = "0x186052ED0")]
	public static string BBMMCJFNAGK(object GKNPKJAGNGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60536D0", Offset = "0x60520D0", VA = "0x1860536D0")]
	public static long OPHPIKNFDAM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6053190", Offset = "0x6051B90", VA = "0x186053190")]
	public static bool HAJMEFLBFDI(bool EMNHMEGCDBJ, string BKNCBJIACBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60530C0", Offset = "0x6051AC0", VA = "0x1860530C0")]
	public static double GJGGBKEJGAN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DPGNEEKBLNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly GNMIEGLEGIH KJJNCOCFIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IFGBPCBJDGI EMNNKNPELMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly HKFAJODALBC LFMOCINDMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly BONCMNODOAM MNPFBBIDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JLNMLBLDABC HCGCOENEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly HNGFKADOOBM KEMNOCLBNAN;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly HKFAJODALBC GILFOLELCIB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly BONCMNODOAM AEDGJKAAJKE;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JLNMLBLDABC CGIINFLBFGN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly HNGFKADOOBM FMMFNCNMNFH;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly DPGNEEKBLNF DPEMCFFPABG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KBMKICIKMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6051180", Offset = "0x604FB80", VA = "0x186051180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6051B60", Offset = "0x6050560", VA = "0x186051B60")]
	public DPGNEEKBLNF([In] GNMIEGLEGIH NDANHLBLDJB, [In] IFGBPCBJDGI GEFKJLEHAJP, HKFAJODALBC BOBFHFGEGHJ, BONCMNODOAM LIPDFGNMFIA, JLNMLBLDABC KLOCAPKOFNL, HNGFKADOOBM KMAOGKEPKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6051320", Offset = "0x604FD20", VA = "0x186051320")]
	private static string KEAECHOBOJC(object GKNPKJAGNGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220")]
	private static long GCGIELCIKJL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	private static string NIPOKHPBIIK(string IKBGKMEDHKI, string? IMDNGKBIEKF, bool EFPLBDJPMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
	private static bool GGEIKLPIIKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6051360", Offset = "0x604FD60", VA = "0x186051360")]
	private static DPGNEEKBLNF KICCFLJCOFA()
	{
		return default(DPGNEEKBLNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OOBNLMJBGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KINEEJCJGNI INLKKMKJDKM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KINEEJCJGNI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PFJBHGNAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCNFEGBGCOP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DECBLHBCBCN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMCMGCFNLJP([In] T CGDFJMJIABO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void AONFPGGFCPM<T>([In] T GKNEMODKAOC);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DBHBJCPEDPK<T> : IEquatable<DBHBJCPEDPK<T>>, DECBLHBCBCN<DBHBJCPEDPK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T BMLGNHJJEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int AMPNEGOJBEN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D21B70", Offset = "0x1D20570", VA = "0x181D21B70")]
	public DBHBJCPEDPK([In] T BEEGCHJLJFC, int BNALCEABILL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F58B40", Offset = "0x4F57540", VA = "0x184F58B40")]
	public static bool JGKBBKJJNFA([In] DBHBJCPEDPK<T> GHGBJDGFDKJ, [In] DBHBJCPEDPK<T> PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x369B970", Offset = "0x369A370", VA = "0x18369B970", Slot = "4")]
	public bool Equals(DBHBJCPEDPK<T> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x381E290", Offset = "0x381CC90", VA = "0x18381E290", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F59560", Offset = "0x4F57F60", VA = "0x184F59560")]
	public bool NMCMGCFNLJP([In] DBHBJCPEDPK<T> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F58820", Offset = "0x4F57220", VA = "0x184F58820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F59BE0", Offset = "0x4F585E0", VA = "0x184F59BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F593E0", Offset = "0x4F57DE0", VA = "0x184F593E0")]
	public void LKKAPGAGEOB([Out] T BEEGCHJLJFC, [Out] int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F58360", Offset = "0x4F56D60", VA = "0x184F58360")]
	public (T, int) GCLPFKGLPAF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4F57FB0", Offset = "0x4F569B0", VA = "0x184F57FB0", Slot = "5")]
	private bool BODJBJFHCGP([In] DBHBJCPEDPK<T> CGDFJMJIABO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AGEFCCPEIIK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2C34000", Offset = "0x2C32A00", VA = "0x182C34000")]
	public static DBHBJCPEDPK<T> KBFODEGLBLG<T>([In] T BEEGCHJLJFC, int BNALCEABILL) where T : notnull
	{
		return default(DBHBJCPEDPK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JECNCAKJHCB
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2657CF0", Offset = "0x26566F0", VA = "0x182657CF0")]
	public static bool NMCMGCFNLJP<T, U>([In] T JFFAAHPEFOB, [In] U GKNPKJAGNGH) where T : notnull, DECBLHBCBCN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult JBJPHBMEKMP<T, out TResult>([In] T GKNEMODKAOC);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult DKLNKFFLHNF<T1, T2, out TResult>([In] T1 KMAOFJCBBJO, [In] T2 KDBEMKADBNB);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KDMOHPGMFGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan GFIOCHBODEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? LEEJHFEJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGCMLJIFGEC();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENLFOIAINKD();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPJFMDFGPHO();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct GNMIEGLEGIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly DEDLBLLANGO NMCJAOLEBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly JDBFFIEIOPI FDDEEGEGJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly DEDLBLLANGO CIPGBKHJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly JDBFFIEIOPI CIENIHKKIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly DEDLBLLANGO GJHOKDOGNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly JDBFFIEIOPI IBJFJENKDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly PJAMAHFBHCN OCLNOFIADDK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly DEDLBLLANGO PJEPNPKFJIP;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly JDBFFIEIOPI GNEBNDGLMPP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly DEDLBLLANGO NPODLKMJEPO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JDBFFIEIOPI PEDAIKNFLEB;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly DEDLBLLANGO IEGIDACDEFE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly JDBFFIEIOPI IBMJONAGLKJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly PJAMAHFBHCN LMLNGGHGJLE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GNMIEGLEGIH DPEMCFFPABG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly DEDLBLLANGO NMLJLOIPPLL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KBMKICIKMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6053990", Offset = "0x6052390", VA = "0x186053990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9304E0", Offset = "0x92EEE0", VA = "0x1809304E0")]
	public GNMIEGLEGIH(DEDLBLLANGO NGGHFFKIPLD, JDBFFIEIOPI ODMKGNBLAJD, DEDLBLLANGO HLNAMBKAEGL, JDBFFIEIOPI DCGODGGLBOJ, DEDLBLLANGO IIPKFALCDNE, JDBFFIEIOPI CGGNOGJGIED, PJAMAHFBHCN NIIGCEPPEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
	private static bool BDFEKPAINDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	private static void HFLDBJBDBPM(string BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
	private static bool DLJHNBLLGPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	private static void KOHNOGCCKLK(string BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
	private static bool BAABDKHHDFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	private static void GFDOACACDND(string BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	private static void KHIAALBOFCE(Exception KHDPHPEGJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6053DB0", Offset = "0x60527B0", VA = "0x186053DB0")]
	private static GNMIEGLEGIH KICCFLJCOFA()
	{
		return default(GNMIEGLEGIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930")]
	private static bool IFHJDNFHNOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6053920", Offset = "0x6052320", VA = "0x186053920")]
	public void CIBIHDAPBBB(object BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6053C60", Offset = "0x6052660", VA = "0x186053C60")]
	public void KBALLEFNGKH(object BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21907F0", Offset = "0x218F1F0", VA = "0x1821907F0")]
	public void MLKMFAKLMPL(Exception KHDPHPEGJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6053CD0", Offset = "0x60526D0", VA = "0x186053CD0")]
	public void KBALLEFNGKH(IKNEGLAFBOE BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x260E740", Offset = "0x260D140", VA = "0x18260E740")]
	public void KBALLEFNGKH<T>(T GKNEMODKAOC, LGFGDOGOOPH<T> BKNCBJIACBJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x260E5C0", Offset = "0x260CFC0", VA = "0x18260E5C0")]
	public void CIBIHDAPBBB<T>([In] T GKNEMODKAOC, HCBFPLCHEBP<T> BKNCBJIACBJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6053B90", Offset = "0x6052590", VA = "0x186053B90")]
	public bool HAJMEFLBFDI(bool EMNHMEGCDBJ, string BKNCBJIACBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct AOIALOCGNFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string BMLGNHJJEIP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	public AOIALOCGNFG(string BEEGCHJLJFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270")]
	public static string LODPGCNHAMK([In] AOIALOCGNFG JFFAAHPEFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x13F3930", Offset = "0x13F2330", VA = "0x1813F3930")]
	public static AOIALOCGNFG LODPGCNHAMK(string CGDFJMJIABO)
	{
		return default(AOIALOCGNFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6050550", Offset = "0x604EF50", VA = "0x186050550")]
	public string CNEGGLEJLHA(string NGDOJIEIDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60505A0", Offset = "0x604EFA0", VA = "0x1860505A0")]
	public string KKAEEEMKLCO(object KDGIFLEALKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct NBACEGLOLCA : IEquatable<NBACEGLOLCA>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "4")]
	public bool Equals(NBACEGLOLCA CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60588A0", Offset = "0x60572A0", VA = "0x1860588A0", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60588F0", Offset = "0x60572F0", VA = "0x1860588F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6058900", Offset = "0x6057300", VA = "0x186058900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[OHHDJMNEMGK("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GEHGOLLEGKI<T> : IEquatable<GEHGOLLEGKI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T BMLGNHJJEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool IEFHBJALLPC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LKPFAFCJFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x369C7C0", Offset = "0x369B1C0", VA = "0x18369C7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x369CBD0", Offset = "0x369B5D0", VA = "0x18369CBD0")]
	public GEHGOLLEGKI([In] T BEEGCHJLJFC, bool MONEJNGEDEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x369C450", Offset = "0x369AE50", VA = "0x18369C450")]
	public static bool JGKBBKJJNFA([In] GEHGOLLEGKI<T> GHGBJDGFDKJ, [In] GEHGOLLEGKI<T> PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x369B970", Offset = "0x369A370", VA = "0x18369B970", Slot = "4")]
	public bool Equals(GEHGOLLEGKI<T> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x369BE50", Offset = "0x369A850", VA = "0x18369BE50", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x369C320", Offset = "0x369AD20", VA = "0x18369C320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x369CA70", Offset = "0x369B470", VA = "0x18369CA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class JJHDCJKACOF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x267A530", Offset = "0x2678F30", VA = "0x18267A530")]
	public static GEHGOLLEGKI<T> AGJKKGBHCEA<T>([In] T BEEGCHJLJFC) where T : notnull
	{
		return default(GEHGOLLEGKI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x267A650", Offset = "0x2679050", VA = "0x18267A650")]
	public static GEHGOLLEGKI<T?> HMKDJDMDLDJ<T>()
	{
		return default(GEHGOLLEGKI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x267A740", Offset = "0x2679140", VA = "0x18267A740")]
	public static bool ODHPHIDIGGO<T>([In] this GEHGOLLEGKI<T> OKCINDEAONI, [Out][NotNullWhen(true)] T BEEGCHJLJFC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct IFGBPCBJDGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr IPPIMDCILNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr OHBBJCLBILB;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr GBPDGJLCMKB;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr AKMJDNCJJOI;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IFGBPCBJDGI DPEMCFFPABG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KBMKICIKMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6054910", Offset = "0x6053310", VA = "0x186054910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x85EBA0", Offset = "0x85D5A0", VA = "0x18085EBA0")]
	public IFGBPCBJDGI(IntPtr BDMFMBNEEDG, IntPtr KLKDILDMAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	private static void BJBFGAPMHNP(string CDHDOGOGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
	private static void AECBGBJDIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60549F0", Offset = "0x60533F0", VA = "0x1860549F0")]
	private static IFGBPCBJDGI KICCFLJCOFA()
	{
		return default(IFGBPCBJDGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct JGCDGPMBOIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr PENINLCOFNN;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	private JGCDGPMBOIK(IntPtr KLKDILDMAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6054BD0", Offset = "0x60535D0", VA = "0x186054BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6054BE0", Offset = "0x60535E0", VA = "0x186054BE0")]
	public static JGCDGPMBOIK KBFODEGLBLG(string CDHDOGOGPME)
	{
		return default(JGCDGPMBOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D11B80", Offset = "0x1D10580", VA = "0x181D11B80")]
	public static JGCDGPMBOIK KBFODEGLBLG([In] IFGBPCBJDGI GEFKJLEHAJP, string CDHDOGOGPME)
	{
		return default(JGCDGPMBOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D11530", Offset = "0x1D0FF30", VA = "0x181D11530")]
	public static JGCDGPMBOIK KBFODEGLBLG([In] IFGBPCBJDGI GEFKJLEHAJP, Func<string> CDHDOGOGPME)
	{
		return default(JGCDGPMBOIK);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MLFJFFBDJGM
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool FLFLAAOLNEL<in TInput, TResult>(TInput KIEPLBLJKOI, [Out] TResult JHJJOGFODKA);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class AHADPJEBHNA : OOBNLMJBGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class EJBCMDDFGHA : KINEEJCJGNI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly EJBCMDDFGHA KHPIFBDMEAA;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool PFJBHGNAPPK
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x6052980", Offset = "0x6051380", VA = "0x186052980", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x60529E0", Offset = "0x60513E0", VA = "0x1860529E0", Slot = "6")]
			public void OnCompleted(Action PGAEKOGCNNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			public void CCNFEGBGCOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public EJBCMDDFGHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly AHADPJEBHNA KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private AHADPJEBHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x604FC50", Offset = "0x604E650", VA = "0x18604FC50", Slot = "4")]
		public KINEEJCJGNI INLKKMKJDKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class EBEOGMAPOAF : OOBNLMJBGHI
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class NNKODLPBFMN : KINEEJCJGNI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly NNKODLPBFMN KHPIFBDMEAA;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool PFJBHGNAPPK
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6058F20", Offset = "0x6057920", VA = "0x186058F20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6058F40", Offset = "0x6057940", VA = "0x186058F40", Slot = "6")]
			public void OnCompleted(Action PGAEKOGCNNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			public void CCNFEGBGCOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public NNKODLPBFMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly EBEOGMAPOAF KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private EBEOGMAPOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6051C10", Offset = "0x6050610", VA = "0x186051C10", Slot = "4")]
		public KINEEJCJGNI INLKKMKJDKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IPDJIIOOECA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public IPDJIIOOECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3853500", Offset = "0x3851F00", VA = "0x183853500")]
		internal void KDLFBMAIPCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CDMDNMAHDHL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public CDMDNMAHDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3010", Offset = "0x3BC1A10", VA = "0x183BC3010")]
		internal void DIPAIAKLHBE(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LJEIIJMLHIH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6055900", Offset = "0x6054300", VA = "0x186055900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x926CC0", Offset = "0x9256C0", VA = "0x180926CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NNPCINEJDNK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6059010", Offset = "0x6057A10", VA = "0x186059010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x926CC0", Offset = "0x9256C0", VA = "0x180926CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CPMNJFJKJLN<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x4D8F390", Offset = "0x4D8DD90", VA = "0x184D8F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F500", Offset = "0x4D8DF00", VA = "0x184D8F500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KOOMMPLMPLA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3B46750", Offset = "0x3B45150", VA = "0x183B46750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3B46FC0", Offset = "0x3B459C0", VA = "0x183B46FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EEEMBPKNKII : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6052710", Offset = "0x6051110", VA = "0x186052710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6052910", Offset = "0x6051310", VA = "0x186052910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class KJDLOHJHAHG<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public KJDLOHJHAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3853500", Offset = "0x3851F00", VA = "0x183853500")]
		internal void FMFFHLDIMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4AC0", Offset = "0x3AE34C0", VA = "0x183AE4AC0")]
		internal void PLGDFOAOCAP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HBBMDMCBMKF<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public FLFLAAOLNEL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x36E7160", Offset = "0x36E5B60", VA = "0x1836E7160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x36E7850", Offset = "0x36E6250", VA = "0x1836E7850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct EEBFBOCHDHG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6051EC0", Offset = "0x60508C0", VA = "0x186051EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60526B0", Offset = "0x60510B0", VA = "0x1860526B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KLDNHAMPAMG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6055120", Offset = "0x6053B20", VA = "0x186055120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6055660", Offset = "0x6054060", VA = "0x186055660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BFEHGJNJODL<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x471D900", Offset = "0x471C300", VA = "0x18471D900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x36BAF80", Offset = "0x36B9980", VA = "0x1836BAF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct EDKPIFOAKAM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x323CE10", Offset = "0x323B810", VA = "0x18323CE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x323D1F0", Offset = "0x323BBF0", VA = "0x18323D1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct EMLICLHLGLJ<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x326BFB0", Offset = "0x326A9B0", VA = "0x18326BFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x326C6B0", Offset = "0x326B0B0", VA = "0x18326C6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FBMINLBLDBL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6052C90", Offset = "0x6051690", VA = "0x186052C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6052E70", Offset = "0x6051870", VA = "0x186052E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct CLCKGKELGJE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6050680", Offset = "0x604F080", VA = "0x186050680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60509F0", Offset = "0x604F3F0", VA = "0x1860509F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct ACMOHAHAIJP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x604F900", Offset = "0x604E300", VA = "0x18604F900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x604FBF0", Offset = "0x604E5F0", VA = "0x18604FBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HJCAIOJNNLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public HJCAIOJNNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60544D0", Offset = "0x6052ED0", VA = "0x1860544D0")]
		internal Task LNGNJCLKCLP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NGGFCKEJKEI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6058930", Offset = "0x6057330", VA = "0x186058930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6058B90", Offset = "0x6057590", VA = "0x186058B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LFPPBIJAGEB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x60556C0", Offset = "0x60540C0", VA = "0x1860556C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60558A0", Offset = "0x60542A0", VA = "0x1860558A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HPHMJCDAMGC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6054540", Offset = "0x6052F40", VA = "0x186054540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60548B0", Offset = "0x60532B0", VA = "0x1860548B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JJOJCNOFCEI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6054CD0", Offset = "0x60536D0", VA = "0x186054CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6054FC0", Offset = "0x60539C0", VA = "0x186054FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NJMLEKFNLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public NJMLEKFNLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6058BF0", Offset = "0x60575F0", VA = "0x186058BF0")]
		internal Task BEEEJKPOOFB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct NKGJOIPLCLA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6058C60", Offset = "0x6057660", VA = "0x186058C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6058EC0", Offset = "0x60578C0", VA = "0x186058EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EDKOIGOHKEF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6051CE0", Offset = "0x60506E0", VA = "0x186051CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6051E60", Offset = "0x6050860", VA = "0x186051E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct CBNEEBKKNFK<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4AF5090", Offset = "0x4AF3A90", VA = "0x184AF5090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4AF52F0", Offset = "0x4AF3CF0", VA = "0x184AF52F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LNGMGKBEDDM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6055A60", Offset = "0x6054460", VA = "0x186055A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6055E70", Offset = "0x6054870", VA = "0x186055E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? OBFPEMICLNM;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<NBACEGLOLCA> GNGOKKOENHJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task KPAOOKKJLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60578F0", Offset = "0x60562F0", VA = "0x1860578F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C10", Offset = "0x26E8610", VA = "0x1826E9C10")]
	public static Task<T> IDAKDPEHOLI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6056D70", Offset = "0x6055770", VA = "0x186056D70")]
	public static Task CNELPKECLND(this Task HGLNIMPGIKP, CancellationToken BDAPLOBBPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26E8BB0", Offset = "0x26E75B0", VA = "0x1826E8BB0")]
	public static Task<TResult> CNELPKECLND<TResult>(this Task<TResult> HGLNIMPGIKP, CancellationToken BDAPLOBBPIE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26E9400", Offset = "0x26E7E00", VA = "0x1826E9400")]
	public static TaskCompletionSource<TResult> CNELPKECLND<TResult>(this TaskCompletionSource<TResult> FMHAMHEBBNI, CancellationToken BDAPLOBBPIE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6057510", Offset = "0x6055F10", VA = "0x186057510")]
	[AsyncStateMachine(typeof(LJEIIJMLHIH))]
	public static void GOKCPEOBJOE(this Task FIGFLJOONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6058730", Offset = "0x6057130", VA = "0x186058730")]
	[AsyncStateMachine(typeof(NNPCINEJDNK))]
	public static void OJFMKPIGHCC(this Task FIGFLJOONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26EA3C0", Offset = "0x26E8DC0", VA = "0x1826EA3C0")]
	[AsyncStateMachine(typeof(CPMNJFJKJLN<>))]
	public static Task PHGCIFJNLNJ<TException>(this Task FIGFLJOONIE) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x26E9960", Offset = "0x26E8360", VA = "0x1826E9960")]
	[AsyncStateMachine(typeof(KOOMMPLMPLA<>))]
	public static Task<T> GPDAOHKIDPJ<T>(this Task<T> JFFAAHPEFOB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6057100", Offset = "0x6055B00", VA = "0x186057100")]
	[AsyncStateMachine(typeof(EEEMBPKNKII))]
	public static Task<TaskStatus> EAJDONALGFO(this Task JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26E9D60", Offset = "0x26E8760", VA = "0x1826E9D60")]
	public static (Task<T?>?, Action<T?>?) JGEMJFILDMH<T>([Optional] CancellationToken EAPNOLMLMHM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26E6CA0", Offset = "0x26E56A0", VA = "0x1826E6CA0")]
	[AsyncStateMachine(typeof(HBBMDMCBMKF<, >))]
	public static Task<List<TResult>> BKOFMMDLDOF<TResult, TInput>(this Task<List<TInput>> HGLNIMPGIKP, FLFLAAOLNEL<TInput, TResult> CMDLNGPMOIP) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6056FD0", Offset = "0x60559D0", VA = "0x186056FD0")]
	[AsyncStateMachine(typeof(EEBFBOCHDHG))]
	public static Task DFOJPDLMJFP(Task FIGFLJOONIE, CancellationToken NPNMHCKEJKG, Func<CancellationToken, Task> KHJNCJIGINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6057960", Offset = "0x6056360", VA = "0x186057960")]
	[AsyncStateMachine(typeof(KLDNHAMPAMG))]
	public static Task JHIMMFEENDJ(Func<CancellationToken, Task> EBAOEMOFBPN, TimeSpan CEEPHBKGJCK, [Optional] CancellationToken NPNMHCKEJKG, [Optional] Action<OperationCanceledException>? KKMLFOHDOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x26E9FA0", Offset = "0x26E89A0", VA = "0x1826E9FA0")]
	[AsyncStateMachine(typeof(BFEHGJNJODL<>))]
	public static Task<T> JHIMMFEENDJ<T>(Func<CancellationToken, Task<T>> EBAOEMOFBPN, TimeSpan CEEPHBKGJCK, [Optional] CancellationToken NPNMHCKEJKG, [Optional] Func<OperationCanceledException, T>? KKMLFOHDOHG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x26EA2E0", Offset = "0x26E8CE0", VA = "0x1826EA2E0")]
	[AsyncStateMachine(typeof(EDKPIFOAKAM<>))]
	public static Task<IEnumerable<Task<T>>> NMNNCKDMBLD<T>(IEnumerable<Task<T>> APHODMGMNMK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26E6A00", Offset = "0x26E5400", VA = "0x1826E6A00")]
	[AsyncStateMachine(typeof(EMLICLHLGLJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> AOIBJGHLCHM<T1, T2, T3, T4>(Task<T1> DOJEKBMEJNL, Task<T2> PIIGHALGBCL, Task<T3> DEDHDNOBGKH, Task<T4> GFPAGHHOLNB) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6057420", Offset = "0x6055E20", VA = "0x186057420")]
	[AsyncStateMachine(typeof(FBMINLBLDBL))]
	public static Task GFCJDHGHMMD(Func<bool> EMNHMEGCDBJ, [Optional] CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6057310", Offset = "0x6055D10", VA = "0x186057310")]
	[AsyncStateMachine(typeof(CLCKGKELGJE))]
	public static Task GFCJDHGHMMD(Func<bool> EMNHMEGCDBJ, TimeSpan HEPFGHCMJFG, [Optional] CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6057BD0", Offset = "0x60565D0", VA = "0x186057BD0")]
	[AsyncStateMachine(typeof(ACMOHAHAIJP))]
	public static Task JPKLIGAKBFC(Func<bool> EMNHMEGCDBJ, TimeSpan CEEPHBKGJCK, [Optional] CancellationToken EAPNOLMLMHM, [Optional] Action<OperationCanceledException>? KKMLFOHDOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6057A90", Offset = "0x6056490", VA = "0x186057A90")]
	[AsyncStateMachine(typeof(NGGFCKEJKEI))]
	public static Task JPKLIGAKBFC(Func<bool> EMNHMEGCDBJ, TimeSpan CEEPHBKGJCK, TimeSpan HEPFGHCMJFG, [Optional] CancellationToken EAPNOLMLMHM, [Optional] Action<OperationCanceledException>? KKMLFOHDOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6058090", Offset = "0x6056A90", VA = "0x186058090")]
	[AsyncStateMachine(typeof(LFPPBIJAGEB))]
	public static Task LBDCBJAMPGO(Func<bool> EMNHMEGCDBJ, [Optional] CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6058180", Offset = "0x6056B80", VA = "0x186058180")]
	[AsyncStateMachine(typeof(HPHMJCDAMGC))]
	public static Task LBDCBJAMPGO(Func<bool> EMNHMEGCDBJ, TimeSpan HEPFGHCMJFG, [Optional] CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6057E40", Offset = "0x6056840", VA = "0x186057E40")]
	[AsyncStateMachine(typeof(JJOJCNOFCEI))]
	public static Task KAPPMGCNKBB(Func<bool> EMNHMEGCDBJ, TimeSpan CEEPHBKGJCK, [Optional] CancellationToken EAPNOLMLMHM, [Optional] Action<OperationCanceledException>? KKMLFOHDOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6057D00", Offset = "0x6056700", VA = "0x186057D00")]
	[AsyncStateMachine(typeof(NKGJOIPLCLA))]
	public static Task KAPPMGCNKBB(Func<bool> EMNHMEGCDBJ, TimeSpan CEEPHBKGJCK, TimeSpan HEPFGHCMJFG, [Optional] CancellationToken EAPNOLMLMHM, [Optional] Action<OperationCanceledException>? KKMLFOHDOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6057800", Offset = "0x6056200", VA = "0x186057800")]
	[AsyncStateMachine(typeof(EDKOIGOHKEF))]
	[Obsolete]
	public static Task IBKCPBEIPAH(this Task HGLNIMPGIKP, Action LNHDBKABFOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x26E9B20", Offset = "0x26E8520", VA = "0x1826E9B20")]
	[Obsolete]
	[AsyncStateMachine(typeof(CBNEEBKKNFK<>))]
	public static Task IBKCPBEIPAH<T>(this Task<T> HGLNIMPGIKP, Action<T> LNHDBKABFOC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6057750", Offset = "0x6056150", VA = "0x186057750")]
	private static void HLOOGHFLODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6058290", Offset = "0x6056C90", VA = "0x186058290")]
	public static bool LMMPLPMJJJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x60575C0", Offset = "0x6055FC0", VA = "0x1860575C0")]
	private static void HLCFCMHAODM(SynchronizationContext BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6057F70", Offset = "0x6056970", VA = "0x186057F70")]
	private static void KFEOLEEBLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6058610", Offset = "0x6057010", VA = "0x186058610")]
	public static void MODDCELJMNC([Optional] string? BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x60586E0", Offset = "0x60570E0", VA = "0x1860586E0")]
	public static OOBNLMJBGHI OANLHBBCBOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60572C0", Offset = "0x6055CC0", VA = "0x1860572C0")]
	public static OOBNLMJBGHI FPGNNDKMOIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60571F0", Offset = "0x6055BF0", VA = "0x1860571F0")]
	[AsyncStateMachine(typeof(LNGMGKBEDDM))]
	public static Task EHNKNPLEDDN(Func<Task> NBNCFKKHMMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class EPMDMPEMHGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
	public EPMDMPEMHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OLBGPDIILCK : PMBJACNGGOC
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly PMBJACNGGOC KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime BMCAJIPBBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6059200", Offset = "0x6057C00", VA = "0x186059200", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset OCLFOFIKCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60591A0", Offset = "0x6057BA0", VA = "0x1860591A0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public OLBGPDIILCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface PMBJACNGGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime BMCAJIPBBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset OCLFOFIKCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class AKEKDDEKNON
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long KJCOPOHOLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6050060", Offset = "0x604EA60", VA = "0x186050060")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long MBNGBEIOKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x604FFC0", Offset = "0x604E9C0", VA = "0x18604FFC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double HDKJFHBHBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6050010", Offset = "0x604EA10", VA = "0x186050010")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double FHJGHKOKAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x60500B0", Offset = "0x604EAB0", VA = "0x1860500B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double NNJFPOIOFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x604FE80", Offset = "0x604E880", VA = "0x18604FE80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double KMGIKGIHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x604FED0", Offset = "0x604E8D0", VA = "0x18604FED0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6050160", Offset = "0x604EB60", VA = "0x186050160")]
	public static double NMGMCKLNDOH(long DEMLHHOBOJI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60501F0", Offset = "0x604EBF0", VA = "0x1860501F0")]
	public static double POKHDADLOMA(long DEMLHHOBOJI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x604FF20", Offset = "0x604E920", VA = "0x18604FF20")]
	public static double FEAOOAIDAKK(double CKCOJFJBMED)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x604FDF0", Offset = "0x604E7F0", VA = "0x18604FDF0")]
	public static long BAFKJAIPDPP(long GPIPKOHJNJJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x604FFB0", Offset = "0x604E9B0", VA = "0x18604FFB0")]
	public static long GKKEOLPDDAE(long HOCCCEHPJFF, long MOBOFELCPJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x604FD20", Offset = "0x604E720", VA = "0x18604FD20")]
	public static double ABILNIKLDBK(long HOCCCEHPJFF, long MOBOFELCPJN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6050100", Offset = "0x604EB00", VA = "0x186050100")]
	public static double MLGCHOLPODI(long HOCCCEHPJFF, long MOBOFELCPJN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DGLFPINMMPH : KDMOHPGMFGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan KGGHLDHHNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer ENLHLLPMOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan CEEPHBKGJCK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan GFIOCHBODEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6050C00", Offset = "0x604F600", VA = "0x186050C00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? LEEJHFEJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6050E90", Offset = "0x604F890", VA = "0x186050E90")]
	[Preserve]
	public DGLFPINMMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6050F00", Offset = "0x604F900", VA = "0x186050F00")]
	public DGLFPINMMPH(TimeSpan CEEPHBKGJCK, [Optional] Action? HCDABPBNBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6050D90", Offset = "0x604F790", VA = "0x186050D90", Slot = "7")]
	public void NGCMLJIFGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6050B90", Offset = "0x604F590", VA = "0x186050B90", Slot = "8")]
	public void ENLFOIAINKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6050D60", Offset = "0x604F760", VA = "0x186050D60", Slot = "9")]
	public void LPJFMDFGPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xB967E0", Offset = "0xB951E0", VA = "0x180B967E0")]
	private void CCLFHDKFNEE(object HNGEGNONPGJ, ElapsedEventArgs DOJHALBKLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6050AF0", Offset = "0x604F4F0", VA = "0x186050AF0")]
	private static void ECCAIFJJBBL(TimeSpan EJCNKBABBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6050A50", Offset = "0x604F450", VA = "0x186050A50", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class OHHDJMNEMGK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string DEMOCGJNFGH;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
	public OHHDJMNEMGK(string EMLIHFKOFEC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct MFHOJHOMKDE : IEquatable<MFHOJHOMKDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint JKIOEJHAEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int MDMPIPGHEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float KNBAHHMCJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort MJKIBAJILBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort CBGPGIJOCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short MAKHIOCCOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short HOHFPEPFBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char MEFBFDGLNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char KMLLCLBBAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte IGAAJBNAGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte NEHFDNDPJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte EHLOOHJFODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte BOKAJGJNGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool AIPELFIJMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool HDGGEDNJPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool GMNDJIBEBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool GOHPNGDAAPL;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD82DD0", Offset = "0xD817D0", VA = "0x180D82DD0")]
	public static MFHOJHOMKDE LEAJNPGGCBM(uint IDJDEIFMFND)
	{
		return default(MFHOJHOMKDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD82DD0", Offset = "0xD817D0", VA = "0x180D82DD0")]
	public static MFHOJHOMKDE OFDHPLFGFCP(int JBAHIJEIPOE)
	{
		return default(MFHOJHOMKDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6055F50", Offset = "0x6054950", VA = "0x186055F50")]
	public static MFHOJHOMKDE GIPIKIOEOIH(float GPLNDNNOCMF)
	{
		return default(MFHOJHOMKDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6055F60", Offset = "0x6054960", VA = "0x186055F60")]
	public static MFHOJHOMKDE IGDGPPNMEIM(byte PKNEFDFMIIF, byte PNEPMPJOMGB, byte KHEGNFOGLGF, byte OPHNAAMDLPL)
	{
		return default(MFHOJHOMKDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6055F60", Offset = "0x6054960", VA = "0x186055F60")]
	public static MFHOJHOMKDE IEDGPDDOHHE(bool FIDCEIIOLAC, bool LAGIPPAEOFM, bool GFAEENAKJNK, bool AFKPPOPLJOL)
	{
		return default(MFHOJHOMKDE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1757570", Offset = "0x1755F70", VA = "0x181757570")]
	public static bool JGKBBKJJNFA(MFHOJHOMKDE KKLPBLEHAEB, MFHOJHOMKDE MFJBAALKDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8135B0", Offset = "0x811FB0", VA = "0x1808135B0", Slot = "4")]
	public bool Equals(MFHOJHOMKDE CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6055ED0", Offset = "0x60548D0", VA = "0x186055ED0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8A0350", Offset = "0x89ED50", VA = "0x1808A0350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6055F80", Offset = "0x6054980", VA = "0x186055F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PMJJAPBAGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong PIECENCOKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long KEGOHCGLBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double GPDIEAMNFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint NDKHGCNLKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint JFNLIIBEENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int NJANNPJGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int OFHDOGMPIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float PMJDNBICOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float MKNGIEJGLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort MJKIBAJILBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort CBGPGIJOCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort CLNIPKJOKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort JFGFMMJPGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short MAKHIOCCOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short HOHFPEPFBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short LJJDOHNDMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short EOGCDEBDMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char MEFBFDGLNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char KMLLCLBBAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char HDGFAAIMPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char EEHALMEDFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte IGAAJBNAGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte NEHFDNDPJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte EHLOOHJFODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte BOKAJGJNGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte LMMEADGLOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte KJFHIAFNLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte BDPGDMJCGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte MFECOGMOOGN;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60592C0", Offset = "0x6057CC0", VA = "0x1860592C0")]
	public static PMJJAPBAGKL KBFODEGLBLG(byte PKNEFDFMIIF, byte PNEPMPJOMGB, byte KHEGNFOGLGF, byte OPHNAAMDLPL, byte ELDNCFFNMLM, byte HLMJMBPJLLD, byte JJFLBIKJBGJ, byte NOICIFNBODH)
	{
		return default(PMJJAPBAGKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LLIIIJPAPJO
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x26BE9A0", Offset = "0x26BD3A0", VA = "0x1826BE9A0")]
	public static IEnumerable<T> NDBOCBAJNPJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static T[] LGKADINFOOL<T>(params T[] LLMEFKMFFAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static IEnumerable<T> JALMIBEBFEL<T>(params T[] LLMEFKMFFAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2614A60", Offset = "0x2613460", VA = "0x182614A60")]
	public static HashSet<T> IDAKOCIEDKA<T>(params T[] LLMEFKMFFAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x26BE8B0", Offset = "0x26BD2B0", VA = "0x1826BE8B0")]
	public static KeyValuePair<TKey, TValue> DIDEPGIGPNI<TKey, TValue>([In] TKey FHLJKJHFEEK, [In] TValue BEEGCHJLJFC) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2614A60", Offset = "0x2613460", VA = "0x182614A60")]
	public static List<T> MGELPGJKPFC<T>(IEnumerable<T> KGDPBJHHKON) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All)]
public sealed class OLMIKJHLAGC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string PGLEJLPIHHL;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
	public OLMIKJHLAGC(string MKNIMCJLKGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object HCBFPLCHEBP<T>([In] T BFAMAJEDCBA);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object LGFGDOGOOPH<T>(T BFAMAJEDCBA);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[NBJNJOIPMPA]
public delegate string JLNMLBLDABC(string IKBGKMEDHKI, string? IMDNGKBIEKF, bool EFPLBDJPMLP);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[NBJNJOIPMPA]
public delegate void JDBFFIEIOPI(string BKNCBJIACBJ);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[NBJNJOIPMPA]
public delegate void PJAMAHFBHCN(Exception KHDPHPEGJEF);
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object IKNEGLAFBOE();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[NBJNJOIPMPA]
public delegate bool DEDLBLLANGO();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[NBJNJOIPMPA]
public delegate string HKFAJODALBC(object GKNPKJAGNGH);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.Enum)]
public class CJJOCFOGJAH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
	public CJJOCFOGJAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class PJFGBOKBJBM
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class GKDMLFHOHIN<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly ISet<T> KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int MDLNLAAIONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x36B32F0", Offset = "0x36B1CF0", VA = "0x1836B32F0", Slot = "4")]
		public bool Add(T PPIDKPHGGGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "6")]
		public void IntersectWith(IEnumerable<T> CGDFJMJIABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x36B3490", Offset = "0x36B1E90", VA = "0x1836B3490", Slot = "5")]
		public void UnionWith(IEnumerable<T> CGDFJMJIABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x36B3430", Offset = "0x36B1E30", VA = "0x1836B3430", Slot = "9")]
		void ICollection<T>.Add(T PPIDKPHGGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "11")]
		public bool Contains(T PPIDKPHGGGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "12")]
		public void CopyTo(T[] BHNHFMPCKPL, int DOMAOCHEEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
		public bool Remove(T PPIDKPHGGGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x36B3350", Offset = "0x36B1D50", VA = "0x1836B3350", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x35E8950", Offset = "0x35E7350", VA = "0x1835E8950", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public GKDMLFHOHIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81E6F0", Offset = "0x81D0F0", VA = "0x18081E6F0")]
	public static ISet<T> IMCCPOMMHKC<T>() where T : notnull
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
