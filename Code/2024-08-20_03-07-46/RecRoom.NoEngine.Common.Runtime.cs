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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A48A70", Offset = "0x6A47A70", VA = "0x186A48A70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BHKMKOMGLCC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A418D0", Offset = "0x6A408D0", VA = "0x186A418D0")]
	public static string OBIFGHCIBHP(this Encoding EOAGHJALCBK, [In] ReadOnlySequence<byte> KABOAHAAMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2929970", Offset = "0x2928970", VA = "0x182929970")]
	private static void GPMJHNHJHPO<T>(this ReadOnlySequence<T> IPBDMIADCAB, [Out] ReadOnlySpan<T> BNIBIDGGAMJ, [Out] SequencePosition FHLPPFEENNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class DFLLOHBKPKH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A42CC0", Offset = "0x6A41CC0", VA = "0x186A42CC0")]
	public DFLLOHBKPKH(bool POOBCFOJHEE, string HIOPNMHAJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GJJMHDMODIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PKDAPHNCKGL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EFDHPFNPILC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMGEBIJPOCJ(string GMFCIHEFPPO, double JJCEIJMGOAB, [Optional] string? PMCCCLAELAK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FBGMDJKAHHD<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> LIGIDGIEMMH(CancellationToken LABHBAHABKB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LNBFELNACCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public FBGMDJKAHHD<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public LIGIDGIEMMH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4306B30", Offset = "0x4305B30", VA = "0x184306B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4307BE0", Offset = "0x4306BE0", VA = "0x184307BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource DJMJNBDHLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? INKMAILPDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? FHDPGPLFBNB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C21A30", Offset = "0x3C20A30", VA = "0x183C21A30")]
	[AsyncStateMachine(typeof(FBGMDJKAHHD<>.LNBFELNACCG))]
	public Task<TResult> LNIHGKGMNEN(LIGIDGIEMMH DBKOAPDHJMM, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C219C0", Offset = "0x3C209C0", VA = "0x183C219C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C21B70", Offset = "0x3C20B70", VA = "0x183C21B70")]
	public FBGMDJKAHHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PHAFIPONGHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> DMFPNCLAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T JMEAFIDIDGF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x411B3D0", Offset = "0x411A3D0", VA = "0x18411B3D0")]
	public PHAFIPONGHA([In] T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47A3EC0", Offset = "0x47A2EC0", VA = "0x1847A3EC0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47A4460", Offset = "0x47A3460", VA = "0x1847A4460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x47A4550", Offset = "0x47A3550", VA = "0x1847A4550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PNCJJBMDION
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96B0", Offset = "0x2BB86B0", VA = "0x182BB96B0")]
	public static PHAFIPONGHA<T> GAKCNKPJGEK<T>([In] T JJCEIJMGOAB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GIMDCEFNONO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A445D0", Offset = "0x6A435D0", VA = "0x186A445D0")]
	public static void PCHGILCIELB(this CancellationTokenSource DJMJNBDHLHM, bool FDLEOHILECF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class EEKDJOCNGFB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
	public EEKDJOCNGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class EIHFMHIFCDM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
	public EIHFMHIFCDM(string NJJDIOJMFKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OKIAHDEHNAH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2D58520", Offset = "0x2D57520", VA = "0x182D58520")]
	public static HBGKLLMLFKL LLDGBLHIANN<T>()
	{
		return default(HBGKLLMLFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2D58820", Offset = "0x2D57820", VA = "0x182D58820")]
	public static HBGKLLMLFKL MEGKMAAOIAG<T>([CallerMemberName] string CKEJJGPNKGO = "") where T : notnull
	{
		return default(HBGKLLMLFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2D585A0", Offset = "0x2D575A0", VA = "0x182D585A0")]
	public static HBGKLLMLFKL LLDGBLHIANN<T>(this T PGMBMLICCAI) where T : notnull
	{
		return default(HBGKLLMLFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2D583D0", Offset = "0x2D573D0", VA = "0x182D583D0")]
	public static HBGKLLMLFKL ECLDKNOCAHL<T>(this T PGMBMLICCAI, [CallerMemberName] string CKEJJGPNKGO = "") where T : notnull
	{
		return default(HBGKLLMLFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2D58770", Offset = "0x2D57770", VA = "0x182D58770")]
	public static HBGKLLMLFKL MEGKMAAOIAG<T>(this T KALCJEIICGB, [CallerMemberName] string CKEJJGPNKGO = "") where T : notnull
	{
		return default(HBGKLLMLFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A48B90", Offset = "0x6A47B90", VA = "0x186A48B90")]
	public static HBGKLLMLFKL MEGKMAAOIAG(string LCMELNPGBOJ, [CallerMemberName] string CKEJJGPNKGO = "")
	{
		return default(HBGKLLMLFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A48AF0", Offset = "0x6A47AF0", VA = "0x186A48AF0")]
	public static string GLLFIFPOOGC(this object KALCJEIICGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool IOJCAAECFJK();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[EEKDJOCNGFB]
public delegate long NPHCIIPLEJO();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BAFFHBNPGHB
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IDNIPHPPIGD HKBGBAFKJGD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IDNIPHPPIGD HMJMKCBIEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A40CB0", Offset = "0x6A3FCB0", VA = "0x186A40CB0")]
		get
		{
			return default(IDNIPHPPIGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FAECHCHMHFD IJMLBLONHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A40D00", Offset = "0x6A3FD00", VA = "0x186A40D00")]
		get
		{
			return default(FAECHCHMHFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EAIIAGBAIGF HGCFAIJPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A411F0", Offset = "0x6A401F0", VA = "0x186A411F0")]
		get
		{
			return default(EAIIAGBAIGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool NMOLIEDHLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A412B0", Offset = "0x6A402B0", VA = "0x186A412B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A40A80", Offset = "0x6A3FA80", VA = "0x186A40A80")]
	public static void AOFAMAPNLFD([In] IDNIPHPPIGD ALICGDFBOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A40EC0", Offset = "0x6A3FEC0", VA = "0x186A40EC0")]
	public static void ELCBEGJPMKG(string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A40DF0", Offset = "0x6A3FDF0", VA = "0x186A40DF0")]
	public static void EHGDIBJABHH(string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2924B70", Offset = "0x2923B70", VA = "0x182924B70")]
	public static void EHGDIBJABHH<T>(T OEMEKBFANIG, KHFPJKHGHOO<T> KKHEHGHPOAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A40F90", Offset = "0x6A3FF90", VA = "0x186A40F90")]
	public static void FEIDIBACBHH(Exception APIEMOLNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A40C30", Offset = "0x6A3FC30", VA = "0x186A40C30")]
	public static void DCCAOIGMBLJ(string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A41240", Offset = "0x6A40240", VA = "0x186A41240")]
	public static void KPCPHAEOHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A41030", Offset = "0x6A40030", VA = "0x186A41030")]
	public static string GLLFIFPOOGC(object NOPFNIKINJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A410B0", Offset = "0x6A400B0", VA = "0x186A410B0")]
	public static long IDONPKLBBBI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A40D50", Offset = "0x6A3FD50", VA = "0x186A40D50")]
	public static bool DNIELPKCFME(bool MKNHBDKKONJ, string KKHEHGHPOAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A41120", Offset = "0x6A40120", VA = "0x186A41120")]
	public static double IJLDFDDBIEM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IDNIPHPPIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly FAECHCHMHFD IJMLBLONHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly EAIIAGBAIGF HGCFAIJPGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly CMNOPKEBIFE LOCDELLIEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly NPHCIIPLEJO GOCDPHLDGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly DAEKCPMKCLI IJNMGCBIHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly IOJCAAECFJK KICPOFFGANK;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CMNOPKEBIFE LELOEDCIKAI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NPHCIIPLEJO IFDPNNBEILG;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly DAEKCPMKCLI OJNGDFPMILJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly IOJCAAECFJK FIIPPLIIKEO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly IDNIPHPPIGD MEMMBNOMLFC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KFCLKKNDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6A44C40", Offset = "0x6A43C40", VA = "0x186A44C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A455E0", Offset = "0x6A445E0", VA = "0x186A455E0")]
	public IDNIPHPPIGD([In] FAECHCHMHFD FECADNJFFKK, [In] EAIIAGBAIGF NMDMDMBINDA, CMNOPKEBIFE GEEBPBMFOJL, NPHCIIPLEJO BPLFOBAOAMM, DAEKCPMKCLI JDLGNNCOKKD, IOJCAAECFJK GLBPBPHAKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A44C00", Offset = "0x6A43C00", VA = "0x186A44C00")]
	private static string LFDMBBMOHBM(object NOPFNIKINJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960")]
	private static long HFHNIPALBKN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	private static string ONAPKJPOLHI(string AFJFNKAODGK, string? BOJMPDAJCJP, bool AJAELNJLKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	private static bool OCCCMAKPJOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A44DE0", Offset = "0x6A43DE0", VA = "0x186A44DE0")]
	private static IDNIPHPPIGD NPCJJJFLHNL()
	{
		return default(IDNIPHPPIGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KNPMMEALMKG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKGBJDMJPMF KJJJNEGPHHP();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DKGBJDMJPMF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DCLFDPKOLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMBGOCBKJFC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GCBAFALFAIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHJNKDEDALG([In] T ACBLPNJDJBF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void OLLCCABFDFI<T>([In] T OEMEKBFANIG);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct KFMACFLLFMJ<T> : IEquatable<KFMACFLLFMJ<T>>, GCBAFALFAIH<KFMACFLLFMJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T JMEAFIDIDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int LCNJIFOOGIB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x20291F0", Offset = "0x20281F0", VA = "0x1820291F0")]
	public KFMACFLLFMJ([In] T JJCEIJMGOAB, int HCALFJOJKJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41C9EE0", Offset = "0x41C8EE0", VA = "0x1841C9EE0")]
	public static bool MKBCGNPIJEJ([In] KFMACFLLFMJ<T> OHFIHFHICKK, [In] KFMACFLLFMJ<T> CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F363B0", Offset = "0x3F353B0", VA = "0x183F363B0", Slot = "4")]
	public bool Equals(KFMACFLLFMJ<T> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x41C9100", Offset = "0x41C8100", VA = "0x1841C9100", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x41CA6F0", Offset = "0x41C96F0", VA = "0x1841CA6F0")]
	public bool NHJNKDEDALG([In] KFMACFLLFMJ<T> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41C9220", Offset = "0x41C8220", VA = "0x1841C9220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41CA8C0", Offset = "0x41C98C0", VA = "0x1841CA8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41C9890", Offset = "0x41C8890", VA = "0x1841C9890")]
	public void JNNCHEFJEMI([Out] T JJCEIJMGOAB, [Out] int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41CA480", Offset = "0x41C9480", VA = "0x1841CA480")]
	public (T, int) NELBIDCDMIE()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41C90B0", Offset = "0x41C80B0", VA = "0x1841C90B0", Slot = "5")]
	private bool EINNOHDLEDH([In] KFMACFLLFMJ<T> ACBLPNJDJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KEIKGMFFBCL
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C70360", Offset = "0x2C6F360", VA = "0x182C70360")]
	public static KFMACFLLFMJ<T> GAKCNKPJGEK<T>([In] T JJCEIJMGOAB, int HCALFJOJKJO) where T : notnull
	{
		return default(KFMACFLLFMJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HJDLFPANHEF
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5F90", Offset = "0x2BC4F90", VA = "0x182BC5F90")]
	public static bool NHJNKDEDALG<T, U>([In] T KALCJEIICGB, [In] U NOPFNIKINJA) where T : notnull, GCBAFALFAIH<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult MMJMDEJBDJN<T, out TResult>([In] T OEMEKBFANIG);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JJCOIOKFGEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan DMMCKMFKCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? HBDDGMLLDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHMAKOOBFHF();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCINIAEDCDK();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIGALPPIBNO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct FAECHCHMHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly KIEGBJHILLJ MGLJBNACKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly LJOGAJGPLJA LGGOGGLBOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly KIEGBJHILLJ LMFGEPNNMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly LJOGAJGPLJA FFGPAPAEICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly KIEGBJHILLJ HGOMJNOIIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly LJOGAJGPLJA BBJNHMGCMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly JNCFMKGJPKK FNGDCIOCICF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KIEGBJHILLJ HBADGICAGIJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly LJOGAJGPLJA OKEBCJEKLHN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KIEGBJHILLJ JBIJEMMHFGO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly LJOGAJGPLJA GGHLELOONBL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KIEGBJHILLJ BCCKHMHKPDP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly LJOGAJGPLJA JILMLCPBBBM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly JNCFMKGJPKK IDDALHCBACG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly FAECHCHMHFD MEMMBNOMLFC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KIEGBJHILLJ HGHPAJNEHEL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KFCLKKNDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A43800", Offset = "0x6A42800", VA = "0x186A43800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xC23670", Offset = "0xC22670", VA = "0x180C23670")]
	public FAECHCHMHFD(KIEGBJHILLJ ODHHGPNKMOB, LJOGAJGPLJA FBBMANGJMOC, KIEGBJHILLJ IBLNJHMNAPC, LJOGAJGPLJA DKMMKIFIFMF, KIEGBJHILLJ BLGNCJAONHN, LJOGAJGPLJA KJBAFOIGPCG, JNCFMKGJPKK CHMDHOHGMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	private static bool EFANKPEOBID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void KFKMNEDFLIL(string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	private static bool DJBJDINFKHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void APPABFJKFGD(string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	private static bool MDFNJJHHJJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void PJONMKBEHBI(string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void MCONJMBDBEG(Exception APIEMOLNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A43A00", Offset = "0x6A42A00", VA = "0x186A43A00")]
	private static FAECHCHMHFD NPCJJJFLHNL()
	{
		return default(FAECHCHMHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
	private static bool CFGANEKLPFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A43790", Offset = "0x6A42790", VA = "0x186A43790")]
	public void ELCBEGJPMKG(object KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A43720", Offset = "0x6A42720", VA = "0x186A43720")]
	public void EHGDIBJABHH(object KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD000", Offset = "0x1CFC000", VA = "0x181CFD000")]
	public void FEIDIBACBHH(Exception APIEMOLNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A43640", Offset = "0x6A42640", VA = "0x186A43640")]
	public void EHGDIBJABHH(EBHFGNEDIAD KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F360", Offset = "0x2B8E360", VA = "0x182B8F360")]
	public void EHGDIBJABHH<T>(T OEMEKBFANIG, KHFPJKHGHOO<T> KKHEHGHPOAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F500", Offset = "0x2B8E500", VA = "0x182B8F500")]
	public void ELCBEGJPMKG<T>([In] T OEMEKBFANIG, EICOBOHGJCA<T> KKHEHGHPOAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F1C0", Offset = "0x2B8E1C0", VA = "0x182B8F1C0")]
	public void EHGDIBJABHH<T>([In] T OEMEKBFANIG, EICOBOHGJCA<T> KKHEHGHPOAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A43570", Offset = "0x6A42570", VA = "0x186A43570")]
	public bool DNIELPKCFME(bool MKNHBDKKONJ, string KKHEHGHPOAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct HBGKLLMLFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string JMEAFIDIDGF;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	public HBGKLLMLFKL(string JJCEIJMGOAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
	public static string GCCHPLCKKEJ([In] HBGKLLMLFKL KALCJEIICGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA5EFB0", Offset = "0xA5DFB0", VA = "0x180A5EFB0")]
	public static HBGKLLMLFKL GCCHPLCKKEJ(string ACBLPNJDJBF)
	{
		return default(HBGKLLMLFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A44920", Offset = "0x6A43920", VA = "0x186A44920")]
	public string BKMNMPOFJBO(string BPGDPHKFJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A44970", Offset = "0x6A43970", VA = "0x186A44970")]
	public string MKCIPCLIGDO(object KIGCHOEOBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct OKOMLKNINNF : IEquatable<OKOMLKNINNF>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "4")]
	public bool Equals(OKOMLKNINNF ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A48C10", Offset = "0x6A47C10", VA = "0x186A48C10", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A48C60", Offset = "0x6A47C60", VA = "0x186A48C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A48C70", Offset = "0x6A47C70", VA = "0x186A48C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[KLDKOFJPICD("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct IHMGDPHFMFJ<T> : IEquatable<IHMGDPHFMFJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T JMEAFIDIDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool IJCCJLICLBM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NOBOJMPJDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3F370C0", Offset = "0x3F360C0", VA = "0x183F370C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3F37470", Offset = "0x3F36470", VA = "0x183F37470")]
	public IHMGDPHFMFJ([In] T JJCEIJMGOAB, bool NMFMPNBLDDK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3F36E20", Offset = "0x3F35E20", VA = "0x183F36E20")]
	public static bool MKBCGNPIJEJ([In] IHMGDPHFMFJ<T> OHFIHFHICKK, [In] IHMGDPHFMFJ<T> CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3F363B0", Offset = "0x3F353B0", VA = "0x183F363B0", Slot = "4")]
	public bool Equals(IHMGDPHFMFJ<T> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3F36240", Offset = "0x3F35240", VA = "0x183F36240", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3F36C90", Offset = "0x3F35C90", VA = "0x183F36C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F372B0", Offset = "0x3F362B0", VA = "0x183F372B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FCCKKIEELHJ
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FB50", Offset = "0x2B8EB50", VA = "0x182B8FB50")]
	public static IHMGDPHFMFJ<T> JKBJPFHNEOH<T>([In] T JJCEIJMGOAB) where T : notnull
	{
		return default(IHMGDPHFMFJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FA10", Offset = "0x2B8EA10", VA = "0x182B8FA10")]
	public static IHMGDPHFMFJ<T?> EJGODLFDNDH<T>()
	{
		return default(IHMGDPHFMFJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F9A0", Offset = "0x2B8E9A0", VA = "0x182B8F9A0")]
	public static bool AAOOGGACFMK<T>([In] this IHMGDPHFMFJ<T> IOEBKFHBDPJ, [Out][NotNullWhen(true)] T JJCEIJMGOAB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct EAIIAGBAIGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr DCCAOIGMBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr KPCPHAEOHGK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr GLJCLILLAJL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr IIOJBHJKPOO;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly EAIIAGBAIGF MEMMBNOMLFC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KFCLKKNDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A42DA0", Offset = "0x6A41DA0", VA = "0x186A42DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	public EAIIAGBAIGF(IntPtr IDCKPNMPOFE, IntPtr IMBFMCOJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void GEGFJBLIMIA(string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void HBMJADKLLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A42E80", Offset = "0x6A41E80", VA = "0x186A42E80")]
	private static EAIIAGBAIGF NPCJJJFLHNL()
	{
		return default(EAIIAGBAIGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct FMCIBBLLGEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr ADOGAPAELOA;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	private FMCIBBLLGEL(IntPtr IMBFMCOJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A441F0", Offset = "0x6A431F0", VA = "0x186A441F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A44210", Offset = "0x6A43210", VA = "0x186A44210")]
	public static FMCIBBLLGEL GAKCNKPJGEK(string CKEJJGPNKGO)
	{
		return default(FMCIBBLLGEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2002890", Offset = "0x2001890", VA = "0x182002890")]
	public static FMCIBBLLGEL GAKCNKPJGEK([In] EAIIAGBAIGF NMDMDMBINDA, string CKEJJGPNKGO)
	{
		return default(FMCIBBLLGEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2002310", Offset = "0x2001310", VA = "0x182002310")]
	public static FMCIBBLLGEL GAKCNKPJGEK([In] EAIIAGBAIGF NMDMDMBINDA, Func<string> CKEJJGPNKGO)
	{
		return default(FMCIBBLLGEL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class AOLAPPDGAJD
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool JADAFMJKDAK<in TInput, TResult>(TInput MIFEONEPPKP, [Out] TResult KNFGDDANCCK);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class FJFNKIMGGPC : KNPMMEALMKG
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class NGKBDCKCLLP : DKGBJDMJPMF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly NGKBDCKCLLP PNNELGGLBHA;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool DCLFDPKOLMF
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x6A48830", Offset = "0x6A47830", VA = "0x186A48830", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6A48890", Offset = "0x6A47890", VA = "0x186A48890", Slot = "6")]
			public void OnCompleted(Action DDPGPKCMHMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			public void DMBGOCBKJFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public NGKBDCKCLLP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly FJFNKIMGGPC PNNELGGLBHA;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		private FJFNKIMGGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A44120", Offset = "0x6A43120", VA = "0x186A44120", Slot = "4")]
		public DKGBJDMJPMF KJJJNEGPHHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class LHKIGCKLPIE : KNPMMEALMKG
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class ENLJKDBCPKG : DKGBJDMJPMF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly ENLJKDBCPKG PNNELGGLBHA;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool DCLFDPKOLMF
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x6A43480", Offset = "0x6A42480", VA = "0x186A43480", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6A434A0", Offset = "0x6A424A0", VA = "0x186A434A0", Slot = "6")]
			public void OnCompleted(Action DDPGPKCMHMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			public void DMBGOCBKJFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public ENLJKDBCPKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly LHKIGCKLPIE PNNELGGLBHA;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		private LHKIGCKLPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A47900", Offset = "0x6A46900", VA = "0x186A47900", Slot = "4")]
		public DKGBJDMJPMF KJJJNEGPHHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MADGJIGBNFF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MADGJIGBNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x44CAC50", Offset = "0x44C9C50", VA = "0x1844CAC50")]
		internal void EJAFAKGIOLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CGKAMCAEGAK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CGKAMCAEGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B370", Offset = "0x3D7A370", VA = "0x183D7B370")]
		internal void FIIMKAHADOL(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HJPICDDNMOI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A44AA0", Offset = "0x6A43AA0", VA = "0x186A44AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ABIKLOJHGOE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A3E550", Offset = "0x6A3D550", VA = "0x186A3E550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HFMIFPJFLFJ<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x3DCBCB0", Offset = "0x3DCACB0", VA = "0x183DCBCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBE20", Offset = "0x3DCAE20", VA = "0x183DCBE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BGNFDAKJPDN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E8F840", Offset = "0x4E8E840", VA = "0x184E8F840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4E8FC70", Offset = "0x4E8EC70", VA = "0x184E8FC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct JFJOLGKNHLI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A45AD0", Offset = "0x6A44AD0", VA = "0x186A45AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A45CD0", Offset = "0x6A44CD0", VA = "0x186A45CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PKMKFMIPIDL<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PKMKFMIPIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x44CAC50", Offset = "0x44C9C50", VA = "0x1844CAC50")]
		internal void PODOAGNGKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x47AC600", Offset = "0x47AB600", VA = "0x1847AC600")]
		internal void ECFCNOKBACH(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct IACKENNANIJ<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public JADAFMJKDAK<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3EAFC00", Offset = "0x3EAEC00", VA = "0x183EAFC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0310", Offset = "0x3EAF310", VA = "0x183EB0310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LMNGCFFLHJH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A479D0", Offset = "0x6A469D0", VA = "0x186A479D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A481C0", Offset = "0x6A471C0", VA = "0x186A481C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NEFIIBCCAPF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A48290", Offset = "0x6A47290", VA = "0x186A48290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6A487D0", Offset = "0x6A477D0", VA = "0x186A487D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EJNEGIBNELK<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x38A5CC0", Offset = "0x38A4CC0", VA = "0x1838A5CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x38A6490", Offset = "0x38A5490", VA = "0x1838A6490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OOFPDGEABBM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x46FAF80", Offset = "0x46F9F80", VA = "0x1846FAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x35D0370", Offset = "0x35CF370", VA = "0x1835D0370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GFLMABOAOAH<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3D5DBD0", Offset = "0x3D5CBD0", VA = "0x183D5DBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D5E8D0", Offset = "0x3D5D8D0", VA = "0x183D5E8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BKCGALHCNJA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A41E90", Offset = "0x6A40E90", VA = "0x186A41E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A42070", Offset = "0x6A41070", VA = "0x186A42070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct IKIBDCKPBPM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A45690", Offset = "0x6A44690", VA = "0x186A45690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A45A00", Offset = "0x6A44A00", VA = "0x186A45A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PIDMDJKJCPH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A49770", Offset = "0x6A48770", VA = "0x186A49770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A49A60", Offset = "0x6A48A60", VA = "0x186A49A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class JBBGHAFAOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JBBGHAFAOJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A45A60", Offset = "0x6A44A60", VA = "0x186A45A60")]
		internal Task NCAJKLEBLCM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct CBOKLKBJADF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A420D0", Offset = "0x6A410D0", VA = "0x186A420D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A42330", Offset = "0x6A41330", VA = "0x186A42330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EGGLOFJFDMH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A43060", Offset = "0x6A42060", VA = "0x186A43060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A43240", Offset = "0x6A42240", VA = "0x186A43240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BFIKIDOIOEG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A41500", Offset = "0x6A40500", VA = "0x186A41500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A41870", Offset = "0x6A40870", VA = "0x186A41870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KEMADDDABDI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A45D40", Offset = "0x6A44D40", VA = "0x186A45D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A46030", Offset = "0x6A45030", VA = "0x186A46030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class NBJJGJHNGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NBJJGJHNGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A48220", Offset = "0x6A47220", VA = "0x186A48220")]
		internal Task GJHKGJAECGP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct GAABNIEOAGD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A44310", Offset = "0x6A43310", VA = "0x186A44310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A44570", Offset = "0x6A43570", VA = "0x186A44570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct EHLKKLNJIJA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A432A0", Offset = "0x6A422A0", VA = "0x186A432A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6A43420", Offset = "0x6A42420", VA = "0x186A43420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MPGOJBJBPOD<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4585580", Offset = "0x4584580", VA = "0x184585580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x45857E0", Offset = "0x45847E0", VA = "0x1845857E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct PCGONIAOFGG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A48CA0", Offset = "0x6A47CA0", VA = "0x186A48CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A490A0", Offset = "0x6A480A0", VA = "0x186A490A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? BIFJGBFNLLD;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<OKOMLKNINNF> JGPJJKNPGEC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task BBPHCDBJNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A404B0", Offset = "0x6A3F4B0", VA = "0x186A404B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A40990", Offset = "0x6A3F990", VA = "0x186A40990")]
	public static bool PAIJMGGLANG(this Task FGPHJGHMKNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x326F260", Offset = "0x326E260", VA = "0x18326F260")]
	public static Task<T> AJFBMNCPLAN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A40520", Offset = "0x6A3F520", VA = "0x186A40520")]
	public static Task MJHCMJAGELE(this Task FGPHJGHMKNM, CancellationToken DJIBMMAIGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3271C30", Offset = "0x3270C30", VA = "0x183271C30")]
	public static Task<TResult> MJHCMJAGELE<TResult>(this Task<TResult> FGPHJGHMKNM, CancellationToken DJIBMMAIGPE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3272EC0", Offset = "0x3271EC0", VA = "0x183272EC0")]
	public static TaskCompletionSource<TResult> MJHCMJAGELE<TResult>(this TaskCompletionSource<TResult> BCPBDDPEGFL, CancellationToken DJIBMMAIGPE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FD70", Offset = "0x6A3ED70", VA = "0x186A3FD70")]
	public static IDisposable? HOLKKENGIJI(CancellationToken BLFAEHGAGLC, CancellationToken BICFLPDHNLA, [Out] CancellationToken FEMJDKDLLCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A40190", Offset = "0x6A3F190", VA = "0x186A40190")]
	[AsyncStateMachine(typeof(HJPICDDNMOI))]
	public static void KNNPOOHCFPP(this Task IGKMAMABJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F800", Offset = "0x6A3E800", VA = "0x186A3F800")]
	[AsyncStateMachine(typeof(ABIKLOJHGOE))]
	public static void FNDPDPKDDJG(this Task IGKMAMABJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x326FA40", Offset = "0x326EA40", VA = "0x18326FA40")]
	[AsyncStateMachine(typeof(HFMIFPJFLFJ<>))]
	public static Task KMGFCBHBIOF<TException>(this Task IGKMAMABJBH) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x326F4D0", Offset = "0x326E4D0", VA = "0x18326F4D0")]
	[AsyncStateMachine(typeof(BGNFDAKJPDN<>))]
	public static Task<T> DNEBMGADIBE<T>(this Task<T> KALCJEIICGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A40780", Offset = "0x6A3F780", VA = "0x186A40780")]
	[AsyncStateMachine(typeof(JFJOLGKNHLI))]
	public static Task<TaskStatus> NMBGBLCNFLK(this Task KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x326FDD0", Offset = "0x326EDD0", VA = "0x18326FDD0")]
	public static (Task<T?>?, Action<T?>?) LDODBGBDKMJ<T>([Optional] CancellationToken LABHBAHABKB)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x326F6B0", Offset = "0x326E6B0", VA = "0x18326F6B0")]
	[AsyncStateMachine(typeof(IACKENNANIJ<, >))]
	public static Task<List<TResult>> FAFBAOIEBJI<TResult, TInput>(this Task<List<TInput>> FGPHJGHMKNM, JADAFMJKDAK<TInput, TResult> CCKFKELBGAC) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F550", Offset = "0x6A3E550", VA = "0x186A3F550")]
	[AsyncStateMachine(typeof(LMNGCFFLHJH))]
	public static Task EDNDGKCNPLC(Task IGKMAMABJBH, CancellationToken CKFCHGJKDBJ, Func<CancellationToken, Task> CJKNKENODAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F6D0", Offset = "0x6A3E6D0", VA = "0x186A3F6D0")]
	[AsyncStateMachine(typeof(NEFIIBCCAPF))]
	public static Task FCGNJMHEFCP(Func<CancellationToken, Task> LNCBFFLCGKM, TimeSpan AOBFBAOECKG, [Optional] CancellationToken CKFCHGJKDBJ, [Optional] Action<OperationCanceledException>? IINAODLMIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x326F7C0", Offset = "0x326E7C0", VA = "0x18326F7C0")]
	[AsyncStateMachine(typeof(EJNEGIBNELK<>))]
	public static Task<T> FCGNJMHEFCP<T>(Func<CancellationToken, Task<T>> LNCBFFLCGKM, TimeSpan AOBFBAOECKG, [Optional] CancellationToken CKFCHGJKDBJ, [Optional] Func<OperationCanceledException, T>? IINAODLMIOP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3273910", Offset = "0x3272910", VA = "0x183273910")]
	[AsyncStateMachine(typeof(OOFPDGEABBM<>))]
	public static Task<IEnumerable<Task<T>>> OMEHGCMMPKN<T>(IEnumerable<Task<T>> IKPOPEIENIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x326FB10", Offset = "0x326EB10", VA = "0x18326FB10")]
	[AsyncStateMachine(typeof(GFLMABOAOAH<, , , >))]
	public static Task<(T1, T2, T3, T4)> LCCCABJHJBD<T1, T2, T3, T4>(Task<T1> IMCHNLOKBDL, Task<T2> JFMGPHFDAJL, Task<T3> JELJMAOIODB, Task<T4> CFMEDOAAOGA) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FC80", Offset = "0x6A3EC80", VA = "0x186A3FC80")]
	[AsyncStateMachine(typeof(BKCGALHCNJA))]
	public static Task GNOIDNPBCEJ(Func<bool> MKNHBDKKONJ, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FB70", Offset = "0x6A3EB70", VA = "0x186A3FB70")]
	[AsyncStateMachine(typeof(IKIBDCKPBPM))]
	public static Task GNOIDNPBCEJ(Func<bool> MKNHBDKKONJ, TimeSpan BAGOCOHDECN, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A40240", Offset = "0x6A3F240", VA = "0x186A40240")]
	[AsyncStateMachine(typeof(PIDMDJKJCPH))]
	public static Task LCDICHJFCIM(Func<bool> MKNHBDKKONJ, TimeSpan AOBFBAOECKG, [Optional] CancellationToken LABHBAHABKB, [Optional] Action<OperationCanceledException>? IINAODLMIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A40370", Offset = "0x6A3F370", VA = "0x186A40370")]
	[AsyncStateMachine(typeof(CBOKLKBJADF))]
	public static Task LCDICHJFCIM(Func<bool> MKNHBDKKONJ, TimeSpan AOBFBAOECKG, TimeSpan BAGOCOHDECN, [Optional] CancellationToken LABHBAHABKB, [Optional] Action<OperationCanceledException>? IINAODLMIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EEE0", Offset = "0x6A3DEE0", VA = "0x186A3EEE0")]
	[AsyncStateMachine(typeof(EGGLOFJFDMH))]
	public static Task CAOAOCBBBDN(Func<bool> MKNHBDKKONJ, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EFD0", Offset = "0x6A3DFD0", VA = "0x186A3EFD0")]
	[AsyncStateMachine(typeof(BFIKIDOIOEG))]
	public static Task CAOAOCBBBDN(Func<bool> MKNHBDKKONJ, TimeSpan BAGOCOHDECN, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F9F0", Offset = "0x6A3E9F0", VA = "0x186A3F9F0")]
	[AsyncStateMachine(typeof(KEMADDDABDI))]
	public static Task GGNKMHNOOMF(Func<bool> MKNHBDKKONJ, TimeSpan AOBFBAOECKG, [Optional] CancellationToken LABHBAHABKB, [Optional] Action<OperationCanceledException>? IINAODLMIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F8B0", Offset = "0x6A3E8B0", VA = "0x186A3F8B0")]
	[AsyncStateMachine(typeof(GAABNIEOAGD))]
	public static Task GGNKMHNOOMF(Func<bool> MKNHBDKKONJ, TimeSpan AOBFBAOECKG, TimeSpan BAGOCOHDECN, [Optional] CancellationToken LABHBAHABKB, [Optional] Action<OperationCanceledException>? IINAODLMIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F460", Offset = "0x6A3E460", VA = "0x186A3F460")]
	[Obsolete]
	[AsyncStateMachine(typeof(EHLKKLNJIJA))]
	public static Task DELHEANKKHO(this Task FGPHJGHMKNM, Action EEFGDCCEHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x326F3E0", Offset = "0x326E3E0", VA = "0x18326F3E0")]
	[AsyncStateMachine(typeof(MPGOJBJBPOD<>))]
	[Obsolete]
	public static Task DELHEANKKHO<T>(this Task<T> FGPHJGHMKNM, Action<T> EEFGDCCEHLD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EE30", Offset = "0x6A3DE30", VA = "0x186A3EE30")]
	private static void BHFHMCPOLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F0E0", Offset = "0x6A3E0E0", VA = "0x186A3F0E0")]
	public static bool DDDKELKAPMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FEB0", Offset = "0x6A3EEB0", VA = "0x186A3FEB0")]
	private static void JAJNIPAEJBA(SynchronizationContext JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A40870", Offset = "0x6A3F870", VA = "0x186A40870")]
	private static void NMPEGHKGEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A400C0", Offset = "0x6A3F0C0", VA = "0x186A400C0")]
	public static void KHBHKDDJMGH([Optional] string? KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A40040", Offset = "0x6A3F040", VA = "0x186A40040")]
	public static void KDLGMAEDGML([Optional] string? KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FB20", Offset = "0x6A3EB20", VA = "0x186A3FB20")]
	public static KNPMMEALMKG GNBPFECDMLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F680", Offset = "0x6A3E680", VA = "0x186A3F680")]
	public static KNPMMEALMKG FABJGMGGMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ED60", Offset = "0x6A3DD60", VA = "0x186A3ED60")]
	[AsyncStateMachine(typeof(PCGONIAOFGG))]
	public static Task BAOCFMKLCND(Func<Task> BOJOFOCMOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CCEMJNNADFH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
	public CCEMJNNADFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BEEPLJKFEDN : BOEJJLJIHOD
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly BOEJJLJIHOD PNNELGGLBHA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime EHJHAKOGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A41440", Offset = "0x6A40440", VA = "0x186A41440", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset IOGFDNCENKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A413E0", Offset = "0x6A403E0", VA = "0x186A413E0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public BEEPLJKFEDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface BOEJJLJIHOD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime EHJHAKOGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset IOGFDNCENKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CIBHDPLMPMF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long IJIPAFFNFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A42590", Offset = "0x6A41590", VA = "0x186A42590")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long LLJCCAIFOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A42540", Offset = "0x6A41540", VA = "0x186A42540")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double AKBNBDICALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A424F0", Offset = "0x6A414F0", VA = "0x186A424F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double GEHENFPLPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A42890", Offset = "0x6A41890", VA = "0x186A42890")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double BCDILPNLEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A42840", Offset = "0x6A41840", VA = "0x186A42840")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double CMKKCFGDCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A426D0", Offset = "0x6A416D0", VA = "0x186A426D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A425E0", Offset = "0x6A415E0", VA = "0x186A425E0")]
	public static double JFIHFLHIDNL(long CPDMAHKFLOF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A42720", Offset = "0x6A41720", VA = "0x186A42720")]
	public static double MIIACFIPLFJ(long CPDMAHKFLOF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A42390", Offset = "0x6A41390", VA = "0x186A42390")]
	public static double BKADIFLNFIL(double ECKHMCGBMKC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A427B0", Offset = "0x6A417B0", VA = "0x186A427B0")]
	public static long MLJAHOHNDLC(long GHCGFNCODKM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A428E0", Offset = "0x6A418E0", VA = "0x186A428E0")]
	public static long PJOMGDBBOED(long HCLGAFLMNLP, long FDGHINLGKGH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A42420", Offset = "0x6A41420", VA = "0x186A42420")]
	public static double CCLHBNFKAAA(long HCLGAFLMNLP, long FDGHINLGKGH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A42670", Offset = "0x6A41670", VA = "0x186A42670")]
	public static double KGLABLJFJKO(long HCLGAFLMNLP, long FDGHINLGKGH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class AEOALCGEDAF : JJCOIOKFGEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan JMDGKNGLKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer COCKABGNCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan AOBFBAOECKG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan DMMCKMFKCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E6F0", Offset = "0x6A3D6F0", VA = "0x186A3E6F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? HBDDGMLLDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EAA0", Offset = "0x6A3DAA0", VA = "0x186A3EAA0")]
	[Preserve]
	public AEOALCGEDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EB10", Offset = "0x6A3DB10", VA = "0x186A3EB10")]
	public AEOALCGEDAF(TimeSpan AOBFBAOECKG, [Optional] Action? GGCJPFABECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E660", Offset = "0x6A3D660", VA = "0x186A3E660", Slot = "7")]
	public void BHMAKOOBFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E8F0", Offset = "0x6A3D8F0", VA = "0x186A3E8F0", Slot = "8")]
	public void HCINIAEDCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E960", Offset = "0x6A3D960", VA = "0x186A3E960", Slot = "9")]
	public void JIGALPPIBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA13880", Offset = "0xA12880", VA = "0x180A13880")]
	private void CDAPPFEJACH(object PGMBMLICCAI, ElapsedEventArgs PPACJMPBHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E990", Offset = "0x6A3D990", VA = "0x186A3E990")]
	private static void KPHEDIBDBPI(TimeSpan NPHHLFHEHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E850", Offset = "0x6A3D850", VA = "0x186A3E850", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class KLDKOFJPICD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? IJFEOFLCCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string JLKBGJOCNJF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1E403D0", Offset = "0x1E3F3D0", VA = "0x181E403D0")]
	public KLDKOFJPICD(string EHMGHMNDKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3F64D00", Offset = "0x3F63D00", VA = "0x183F64D00")]
	public KLDKOFJPICD(string EEMOJGOOGIP, string EHMGHMNDKCC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KMHLEJADADA : IEquatable<KMHLEJADADA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint NHEDOPJICPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int HOEGMNINMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float JNDAICCPDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort EKBLJEMMNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort JIFDDBDGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short NIHBDKDPLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short LFCPFFAANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char IPAIAKICEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char BJGHAEDCKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte AMIPKMBIPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte LNJJJKPIJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte EJLCPJAPJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte IGOPKAPOHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool GMIDHNBNOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool JJCDMNOGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool DONAFPCBCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool JNPAJFHMCAJ;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C640", VA = "0x180E6D640")]
	public static KMHLEJADADA BBLCMMEMPKH(uint AGGPGKGBFHF)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C640", VA = "0x180E6D640")]
	public static KMHLEJADADA MAEOKIIKBDA(int ADADDONMMNK)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A46A90", Offset = "0x6A45A90", VA = "0x186A46A90")]
	public static KMHLEJADADA OFHPBPFDPHL(float KHNLJBAFADB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A469E0", Offset = "0x6A459E0", VA = "0x186A469E0")]
	public static KMHLEJADADA LELKIEBFFJL(byte PPPMLMPPNBD, byte AEPGCACEIKB, byte GGEHALJBPPF, byte OKDLMAINHOG)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A469E0", Offset = "0x6A459E0", VA = "0x186A469E0")]
	public static KMHLEJADADA CDEENALMGEL(bool JKIMNMOHGCD, bool GDLLGFFIOCN, bool BEAIIEBCLDB, bool MMHPJCALPIO)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A469E0", Offset = "0x6A459E0", VA = "0x186A469E0")]
	public static KMHLEJADADA PCCDNLCKFPO(byte HCLBKPFAIDK, byte EMKDODIIGEI, byte OLKJJNPGGBM, byte MEMBKJMJEDG)
	{
		return default(KMHLEJADADA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1B8AD10", Offset = "0x1B89D10", VA = "0x181B8AD10")]
	public static bool MKBCGNPIJEJ(KMHLEJADADA PNODNPKGJKB, KMHLEJADADA JHNJJGDAEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE1210", VA = "0x180AE2210", Slot = "4")]
	public bool Equals(KMHLEJADADA ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A46A00", Offset = "0x6A45A00", VA = "0x186A46A00", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xB8A950", Offset = "0xB89950", VA = "0x180B8A950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6A46AA0", Offset = "0x6A45AA0", VA = "0x186A46AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct HEGDBLGKNIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong BPCDKCMJNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long LHOHFBCGKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double LIHLIPEIJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint LCJECKLKEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BBABDLJBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int JKPDJICGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int GBKILMBHBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float IGHLFNHBDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float MODELEKMPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort EKBLJEMMNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort JIFDDBDGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort PBIGJDALOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort PAGNLNLMJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short NIHBDKDPLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short LFCPFFAANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short EGEEFJHHJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short KOKCJLFJCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char IPAIAKICEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char BJGHAEDCKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char CAIPOEMFOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char BMILGFFKABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte AMIPKMBIPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte LNJJJKPIJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte EJLCPJAPJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte IGOPKAPOHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte IINNNMFBAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte OAAIALIGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte EBEOBEACHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte OOCCMNGOKDN;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6A44A50", Offset = "0x6A43A50", VA = "0x186A44A50")]
	public static HEGDBLGKNIA GAKCNKPJGEK(byte PPPMLMPPNBD, byte AEPGCACEIKB, byte GGEHALJBPPF, byte OKDLMAINHOG, byte FNDBBEDNCLD, byte BLHPNJDOEAC, byte BPCIAFLOHMO, byte HDGGOACEFLI)
	{
		return default(HEGDBLGKNIA);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct GLEMCGMKJMC : IEquatable<GLEMCGMKJMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte LJMFHMFKBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool CJMMOPLEAGC;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x25D13A0", Offset = "0x25D03A0", VA = "0x1825D13A0")]
	public static GLEMCGMKJMC LELKIEBFFJL(byte LMDJJICOOEO)
	{
		return default(GLEMCGMKJMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25D13A0", Offset = "0x25D03A0", VA = "0x1825D13A0")]
	public static GLEMCGMKJMC CDEENALMGEL(bool GHHJNDDMPAE)
	{
		return default(GLEMCGMKJMC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A446A0", Offset = "0x6A436A0", VA = "0x186A446A0")]
	public static bool MKBCGNPIJEJ(GLEMCGMKJMC PNODNPKGJKB, GLEMCGMKJMC JHNJJGDAEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5BD3800", Offset = "0x5BD2800", VA = "0x185BD3800", Slot = "4")]
	public bool Equals(GLEMCGMKJMC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A44600", Offset = "0x6A43600", VA = "0x186A44600", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6A44690", Offset = "0x6A43690", VA = "0x186A44690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6A446B0", Offset = "0x6A436B0", VA = "0x186A446B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class PCEJHNEELIM<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T EJCHKGDNMMM;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4794CD0", Offset = "0x4793CD0", VA = "0x184794CD0")]
	public PCEJHNEELIM(T BPEOMNKNJGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JDFGCAJLDLL
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2C170E0", Offset = "0x2C160E0", VA = "0x182C170E0")]
	public static IEnumerable<T> HCAMFPBLJEP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static T[] FFJJKJOCALE<T>(params T[] JBMLKGPLPMF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static IEnumerable<T> IBLFBIGKEON<T>(params T[] JBMLKGPLPMF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96B0", Offset = "0x2BB86B0", VA = "0x182BB96B0")]
	public static HashSet<T> FNPOKJODCGB<T>(params T[] JBMLKGPLPMF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2C17110", Offset = "0x2C16110", VA = "0x182C17110")]
	public static KeyValuePair<TKey, TValue> HFGEMAJHBII<TKey, TValue>([In] TKey GMFCIHEFPPO, [In] TValue JJCEIJMGOAB) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96B0", Offset = "0x2BB86B0", VA = "0x182BB96B0")]
	public static List<T> EBKJDNPJPHB<T>(IEnumerable<T> AFNCAAOMPCK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.All)]
public sealed class OPGEBIIGIGA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string KJLANLLCIGF;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
	public OPGEBIIGIGA(string FICFNKLGBCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object EICOBOHGJCA<T>([In] T DJNIHGJAOCO);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object KHFPJKHGHOO<T>(T DJNIHGJAOCO);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[EEKDJOCNGFB]
public delegate string DAEKCPMKCLI(string AFJFNKAODGK, string? BOJMPDAJCJP, bool AJAELNJLKKM);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[EEKDJOCNGFB]
public delegate void LJOGAJGPLJA(string KKHEHGHPOAA);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[EEKDJOCNGFB]
public delegate void JNCFMKGJPKK(Exception APIEMOLNMPG);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate object EBHFGNEDIAD();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[EEKDJOCNGFB]
public delegate bool KIEGBJHILLJ();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[EEKDJOCNGFB]
public delegate string CMNOPKEBIFE(object NOPFNIKINJA);
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.Enum)]
public class JALFGCJLCCE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
	public JALFGCJLCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class PEEFEFLENEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct KIMDBGDPKDO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A46090", Offset = "0x6A45090", VA = "0x186A46090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6A46970", Offset = "0x6A45970", VA = "0x186A46970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback CLGEOJAOOHF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> APCCCJGAEBD;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A49350", Offset = "0x6A48350", VA = "0x186A49350")]
	public static Task<bool> NPNHCMIPDLA(int LBIDBIPFACL, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6A49220", Offset = "0x6A48220", VA = "0x186A49220")]
	[AsyncStateMachine(typeof(KIMDBGDPKDO))]
	private static Task<bool> JKLGACHICAL(int LBIDBIPFACL, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6A49100", Offset = "0x6A48100", VA = "0x186A49100")]
	private static void CBCGJFGPMLK(object? JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6A49190", Offset = "0x6A48190", VA = "0x186A49190")]
	private static void CGHCEEOHPMA(object? JKKAFCBPEPF)
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
