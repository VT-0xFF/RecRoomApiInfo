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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x704CB90", Offset = "0x704B390", VA = "0x18704CB90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IIMBDHIDEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7047A00", Offset = "0x7046200", VA = "0x187047A00")]
	public static string FDIJOINEJJJ(this Encoding MDILAAAAOGE, [In] ReadOnlySequence<byte> LMGNHIJGDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x309FB30", Offset = "0x309E330", VA = "0x18309FB30")]
	private static void BNHEOOEGMDK<T>(this ReadOnlySequence<T> EAHPMEANBNE, [Out] ReadOnlySpan<T> KCLGEJAHFOB, [Out] SequencePosition PPBHJEMIBIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class HMNPIEFPDGM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7046E90", Offset = "0x7045690", VA = "0x187046E90")]
	public HMNPIEFPDGM(bool FMIODDJNJIN, string FJFKAPEKMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7046F60", Offset = "0x7045760", VA = "0x187046F60")]
	public HMNPIEFPDGM(bool FMIODDJNJIN, params string[] NDMFBFMNEGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CLCKPHMEAFL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NPPMOJGLNNG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ANHNNCGDNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHGMGFIFLDB(string KCGKBDGKIOP, double INDENPJBLHO, [Optional] string? EDEBACEMEME);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EJGLFAIKGOF<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> LHJCJKEJMEC(CancellationToken ALKEMFHOMCA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct MLJCHHGNEND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public EJGLFAIKGOF<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public LHJCJKEJMEC taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x49E4C80", Offset = "0x49E3480", VA = "0x1849E4C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x49E5D40", Offset = "0x49E4540", VA = "0x1849E5D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource OENGEKBIAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? IOOGOMNAOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? BAGPPPLOMDN;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4C70", Offset = "0x3CE3470", VA = "0x183CE4C70")]
	[AsyncStateMachine(typeof(EJGLFAIKGOF<>.MLJCHHGNEND))]
	public Task<TResult> HMGPEENBJKI(LHJCJKEJMEC GDEALOHBBKM, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4C00", Offset = "0x3CE3400", VA = "0x183CE4C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4DB0", Offset = "0x3CE35B0", VA = "0x183CE4DB0")]
	public EJGLFAIKGOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HMAFIJIFCEC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> HOODGHMNNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T MHFLHGKPHDB;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x406AC40", Offset = "0x4069440", VA = "0x18406AC40")]
	public HMAFIJIFCEC([In] T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x423E300", Offset = "0x423CB00", VA = "0x18423E300", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x423E940", Offset = "0x423D140", VA = "0x18423E940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x423EBF0", Offset = "0x423D3F0", VA = "0x18423EBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OLBKHLEMBOP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E619A0", Offset = "0x2E601A0", VA = "0x182E619A0")]
	public static HMAFIJIFCEC<T> DFLBOLBHLFN<T>([In] T INDENPJBLHO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GHAKHCCGMFA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x70455C0", Offset = "0x7043DC0", VA = "0x1870455C0")]
	public static void NGKIOEPEDBN(this CancellationTokenSource OENGEKBIAJA, bool HEMIGBPNMDB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FJGNIKBIBPB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
	public FJGNIKBIBPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class HFPGIODOIKD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
	public HFPGIODOIKD(string PIAMNDEIDDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BNOMJKPLEGI
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2DECB20", Offset = "0x2DEB320", VA = "0x182DECB20")]
	public static LENHKFEPAKM BNGICKCLKKP<T>()
	{
		return default(LENHKFEPAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC8D0", Offset = "0x2DEB0D0", VA = "0x182DEC8D0")]
	public static LENHKFEPAKM BKGEPFHONND<T>([CallerMemberName] string IKMKCMDHFDC = "") where T : notnull
	{
		return default(LENHKFEPAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2DECBA0", Offset = "0x2DEB3A0", VA = "0x182DECBA0")]
	public static LENHKFEPAKM BNGICKCLKKP<T>(this T FNGOEBINDAF) where T : notnull
	{
		return default(LENHKFEPAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2DECC20", Offset = "0x2DEB420", VA = "0x182DECC20")]
	public static LENHKFEPAKM PDMKEEOKPDF<T>(this T FNGOEBINDAF, [CallerMemberName] string IKMKCMDHFDC = "") where T : notnull
	{
		return default(LENHKFEPAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC970", Offset = "0x2DEB170", VA = "0x182DEC970")]
	public static LENHKFEPAKM BKGEPFHONND<T>(this T EGGDEECAALI, [CallerMemberName] string IKMKCMDHFDC = "") where T : notnull
	{
		return default(LENHKFEPAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7042600", Offset = "0x7040E00", VA = "0x187042600")]
	public static LENHKFEPAKM BKGEPFHONND(string MBMLNLMEADO, [CallerMemberName] string IKMKCMDHFDC = "")
	{
		return default(LENHKFEPAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7042680", Offset = "0x7040E80", VA = "0x187042680")]
	public static string MFJMMPCKIGN(this object EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool CBDFPMIKDEL();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FJGNIKBIBPB]
public delegate long EBJIMBOBBEJ();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EPEHBDDOMBN
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static LHNBPJMOLHL EEFNAALEPOH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LHNBPJMOLHL AABILHMEEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7044B30", Offset = "0x7043330", VA = "0x187044B30")]
		get
		{
			return default(LHNBPJMOLHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DHCDPFIGGBN CAAIHFFGEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7044D90", Offset = "0x7043590", VA = "0x187044D90")]
		get
		{
			return default(DHCDPFIGGBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EAPECHBFHAG DDMOMBCOHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7044C00", Offset = "0x7043400", VA = "0x187044C00")]
		get
		{
			return default(EAPECHBFHAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool IPIACPDIDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7044D20", Offset = "0x7043520", VA = "0x187044D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7044DE0", Offset = "0x70435E0", VA = "0x187044DE0")]
	public static void GGDPDACCBCA([In] LHNBPJMOLHL NPIKLOBKEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7044C50", Offset = "0x7043450", VA = "0x187044C50")]
	public static void CLLGOIEIHDM(string PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7044A60", Offset = "0x7043260", VA = "0x187044A60")]
	public static void AHAGIJADCMI(string PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7520", Offset = "0x2ED5D20", VA = "0x182ED7520")]
	public static void AHAGIJADCMI<T>(T HBIPIPALDEO, FPLGOKNCGPL<T> PJFOMDHJLBF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70451F0", Offset = "0x70439F0", VA = "0x1870451F0")]
	public static void NMMMCHBBKEJ(Exception HNGGNNBFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7044B80", Offset = "0x7043380", VA = "0x187044B80")]
	public static void BEPFFGKMPGO(string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7045290", Offset = "0x7043A90", VA = "0x187045290")]
	public static void PDMNDCIPGMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70450A0", Offset = "0x70438A0", VA = "0x1870450A0")]
	public static string MFJMMPCKIGN(object INCBEIDOHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7045030", Offset = "0x7043830", VA = "0x187045030")]
	public static long JNHJPOEJHKH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7044F90", Offset = "0x7043790", VA = "0x187044F90")]
	public static bool HDOGMKFOICL(bool JDBPPNFCIBD, string PJFOMDHJLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7045120", Offset = "0x7043920", VA = "0x187045120")]
	public static double MOMLNPKGJDE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct LHNBPJMOLHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly DHCDPFIGGBN CAAIHFFGEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly EAPECHBFHAG DDMOMBCOHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly BMJNKEHAKCO EKDLICHCDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly EBJIMBOBBEJ ACHODOFCIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly GNAPKLDAMNK PCEKJDOJDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly CBDFPMIKDEL NNBGGNDDHDI;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly BMJNKEHAKCO GIPOMKJIIJH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly EBJIMBOBBEJ GCBJOEIFIPB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly GNAPKLDAMNK BMIENPKMDPB;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly CBDFPMIKDEL OFDJCFEGHHI;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly LHNBPJMOLHL PNJBLIJBOPG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KMEJBLAIFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70499D0", Offset = "0x70481D0", VA = "0x1870499D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x704A260", Offset = "0x7048A60", VA = "0x18704A260")]
	public LHNBPJMOLHL([In] DHCDPFIGGBN LGKAMMPOBAE, [In] EAPECHBFHAG MKBKOIPNOEI, BMJNKEHAKCO JDHCNGEKENL, EBJIMBOBBEJ PLDCLFFPDMO, GNAPKLDAMNK ONPMKMNMEOO, CBDFPMIKDEL GLMPJJKBFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7049880", Offset = "0x7048080", VA = "0x187049880")]
	private static string CGNFLENGAEP(object INCBEIDOHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0")]
	private static long BLFJPBBFBAD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	private static string PFAIADKAHMG(string JPJKMDGHCEE, string? HCEFDNFIGAF, bool JCFNAHEEPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	private static bool PPDGEJNLMJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70498C0", Offset = "0x70480C0", VA = "0x1870498C0")]
	private static LHNBPJMOLHL HMNMEMJOJNP()
	{
		return default(LHNBPJMOLHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NICFFBPKHLO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIFKLJOMIHJ FJJFOJEIFLM();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JIFKLJOMIHJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BPMEEIFADIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDDGKHNHAAB();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DCNOAHAHPKJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGGGNHDPPG([In] T LIHCAHPMPHD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void DOKGNLMJLKB<T>([In] T HBIPIPALDEO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct MOKNNKNLKBI<T> : IEquatable<MOKNNKNLKBI<T>>, DCNOAHAHPKJ<MOKNNKNLKBI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T MHFLHGKPHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int MBLPHBBBBKP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2342BC0", Offset = "0x23413C0", VA = "0x182342BC0")]
	public MOKNNKNLKBI([In] T INDENPJBLHO, int ECDOOAABOPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49F7400", Offset = "0x49F5C00", VA = "0x1849F7400")]
	public static bool PCBECHOJFKF([In] MOKNNKNLKBI<T> CBNNCMPLCDK, [In] MOKNNKNLKBI<T> OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49F6BF0", Offset = "0x49F53F0", VA = "0x1849F6BF0", Slot = "4")]
	public bool Equals(MOKNNKNLKBI<T> LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4069910", Offset = "0x4068110", VA = "0x184069910", Slot = "0")]
	public override bool Equals(object LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49F7180", Offset = "0x49F5980", VA = "0x1849F7180")]
	public bool PBGGGNHDPPG([In] MOKNNKNLKBI<T> LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49F6EB0", Offset = "0x49F56B0", VA = "0x1849F6EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49F7920", Offset = "0x49F6120", VA = "0x1849F7920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x49F63B0", Offset = "0x49F4BB0", VA = "0x1849F63B0")]
	public void CCFBGGDGJEK([Out] T INDENPJBLHO, [Out] int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x49F67D0", Offset = "0x49F4FD0", VA = "0x1849F67D0")]
	public (T, int) CDCIGGDDCOC()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49F5F80", Offset = "0x49F4780", VA = "0x1849F5F80", Slot = "5")]
	private bool AJKALHKMFOD([In] MOKNNKNLKBI<T> LIHCAHPMPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MGMJPHNIIGP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3163BF0", Offset = "0x31623F0", VA = "0x183163BF0")]
	public static MOKNNKNLKBI<T> DFLBOLBHLFN<T>([In] T INDENPJBLHO, int ECDOOAABOPD) where T : notnull
	{
		return default(MOKNNKNLKBI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CPBJKECCBNF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AF70", Offset = "0x2E69770", VA = "0x182E6AF70")]
	public static bool PBGGGNHDPPG<T, U>([In] T EGGDEECAALI, [In] U INCBEIDOHDO) where T : notnull, DCNOAHAHPKJ<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult NHGJECAGIPO<T, out TResult>([In] T HBIPIPALDEO);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BOJFJKLDILF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan EEHOEOFBHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? HGIHCOEIKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIICEFGCNDO();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFPPMDNBIGF();

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBPPMFLMKPD();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct DHCDPFIGGBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly LDEKCMMCFII HHDHBADJOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly HOAIOLCKCBG KNJCJMKMEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly LDEKCMMCFII GNOFPPHFDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly HOAIOLCKCBG BBBPIAAKFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly LDEKCMMCFII NCFAOFGJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly HOAIOLCKCBG AAHGGFOEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IJNGBMBGPAK BABAIPPANOK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly LDEKCMMCFII FNMDHNKAJHI;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly HOAIOLCKCBG PPGOPKABAOA;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly LDEKCMMCFII CCABCKKNEKC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly HOAIOLCKCBG GCIKEIPCMBA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly LDEKCMMCFII BIIPNEGDKOD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HOAIOLCKCBG FDHGCKMADFI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IJNGBMBGPAK KCFKMFMGBIN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly DHCDPFIGGBN PNJBLIJBOPG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LDEKCMMCFII ENOOPPNEMEN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KMEJBLAIFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7043AD0", Offset = "0x70422D0", VA = "0x187043AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x98EB50", Offset = "0x98D350", VA = "0x18098EB50")]
	public DHCDPFIGGBN(LDEKCMMCFII ICHJJHONEMC, HOAIOLCKCBG ALOICGINBLN, LDEKCMMCFII DCJJGMNOGDJ, HOAIOLCKCBG LFEOLINHIJB, LDEKCMMCFII CEJPJPDBAPG, HOAIOLCKCBG NLKFCGOIEPO, IJNGBMBGPAK CGCDOKFLAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	private static bool KAOHPFPDBOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void EEPFICOJCPC(string PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	private static bool PMIMHOCKAAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void GIKICMGLJPP(string PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	private static bool EMEIPAGOPHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void ANAGHAEPICN(string PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void IDGFEMIALHK(Exception HNGGNNBFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7043990", Offset = "0x7042190", VA = "0x187043990")]
	private static DHCDPFIGGBN HMNMEMJOJNP()
	{
		return default(DHCDPFIGGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
	private static bool PAEHJNHMJJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7043850", Offset = "0x7042050", VA = "0x187043850")]
	public void CLLGOIEIHDM(object PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70437E0", Offset = "0x7041FE0", VA = "0x1870437E0")]
	public void AHAGIJADCMI(object PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x998FD0", Offset = "0x9977D0", VA = "0x180998FD0")]
	public void NMMMCHBBKEJ(Exception HNGGNNBFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7043700", Offset = "0x7041F00", VA = "0x187043700")]
	public void AHAGIJADCMI(IGIMKPLBFDI PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3900", Offset = "0x2EA2100", VA = "0x182EA3900")]
	public void AHAGIJADCMI<T>(T HBIPIPALDEO, FPLGOKNCGPL<T> PJFOMDHJLBF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA39D0", Offset = "0x2EA21D0", VA = "0x182EA39D0")]
	public void CLLGOIEIHDM<T>([In] T HBIPIPALDEO, PANKJKLLPOD<T> PJFOMDHJLBF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3690", Offset = "0x2EA1E90", VA = "0x182EA3690")]
	public void AHAGIJADCMI<T>([In] T HBIPIPALDEO, PANKJKLLPOD<T> PJFOMDHJLBF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70438C0", Offset = "0x70420C0", VA = "0x1870438C0")]
	public bool HDOGMKFOICL(bool JDBPPNFCIBD, string PJFOMDHJLBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct LENHKFEPAKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string MHFLHGKPHDB;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	public LENHKFEPAKM(string INDENPJBLHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
	public static string FMEIMHFCNHG([In] LENHKFEPAKM EGGDEECAALI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD56730", Offset = "0xD54F30", VA = "0x180D56730")]
	public static LENHKFEPAKM FMEIMHFCNHG(string LIHCAHPMPHD)
	{
		return default(LENHKFEPAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7049750", Offset = "0x7047F50", VA = "0x187049750")]
	public string DCMJGJNLGEM(string IGKHNELEFMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x70497A0", Offset = "0x7047FA0", VA = "0x1870497A0")]
	public string NMOEOCFPKEC(object AMODHGHPMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.Method)]
public class MDOKGGJPDLI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
	public MDOKGGJPDLI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct DOPPLCFNMND : IEquatable<DOPPLCFNMND>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "4")]
	public bool Equals(DOPPLCFNMND LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70442B0", Offset = "0x7042AB0", VA = "0x1870442B0", Slot = "0")]
	public override bool Equals(object LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7044300", Offset = "0x7042B00", VA = "0x187044300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7044310", Offset = "0x7042B10", VA = "0x187044310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DGOKMPKFCKH("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct CNCELCGNJHH<T> : IEquatable<CNCELCGNJHH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T MHFLHGKPHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool ODJHBLNCOHG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FEMNGNNPPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x593D190", Offset = "0x593B990", VA = "0x18593D190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x593E950", Offset = "0x593D150", VA = "0x18593E950")]
	public CNCELCGNJHH([In] T INDENPJBLHO, bool LAOCDKDNIOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x593DB30", Offset = "0x593C330", VA = "0x18593DB30")]
	public static bool PCBECHOJFKF([In] CNCELCGNJHH<T> CBNNCMPLCDK, [In] CNCELCGNJHH<T> OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x593C5C0", Offset = "0x593ADC0", VA = "0x18593C5C0", Slot = "4")]
	public bool Equals(CNCELCGNJHH<T> LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x593C8C0", Offset = "0x593B0C0", VA = "0x18593C8C0", Slot = "0")]
	public override bool Equals(object? LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x593D6B0", Offset = "0x593BEB0", VA = "0x18593D6B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x593E2F0", Offset = "0x593CAF0", VA = "0x18593E2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LLDHCDFPOHH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x31137E0", Offset = "0x3111FE0", VA = "0x1831137E0")]
	public static CNCELCGNJHH<T> ODPNHCIJJAA<T>([In] T INDENPJBLHO) where T : notnull
	{
		return default(CNCELCGNJHH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3113400", Offset = "0x3111C00", VA = "0x183113400")]
	public static CNCELCGNJHH<T?> DMKGIJMLBBO<T>()
	{
		return default(CNCELCGNJHH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3113630", Offset = "0x3111E30", VA = "0x183113630")]
	public static bool JIBDDOLIKHA<T>([In] this CNCELCGNJHH<T> LNJAABNGADG, [Out][NotNullWhen(true)] T INDENPJBLHO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x31135F0", Offset = "0x3111DF0", VA = "0x1831135F0")]
	public static bool JIBDDOLIKHA<T>([In] this CNCELCGNJHH<T> LNJAABNGADG, [Out][NotNullWhen(true)] T INDENPJBLHO, [Out] CNCELCGNJHH<T> CLHCJOJLFOO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3113660", Offset = "0x3111E60", VA = "0x183113660")]
	public static T? MCNJNBPJDKJ<T>([In] this CNCELCGNJHH<T> LNJAABNGADG, T? DFEJJOPGBKP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x31134C0", Offset = "0x3111CC0", VA = "0x1831134C0")]
	public static bool JAIPMEFJLAE<T>([In] this CNCELCGNJHH<T> LNJAABNGADG, T INDENPJBLHO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AMAKPEAPBCG
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3753F90", Offset = "0x3752790", VA = "0x183753F90")]
	public static T KCBCEFBEBKK<T>([In] this CNCELCGNJHH<T> LNJAABNGADG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct EAPECHBFHAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr BEPFFGKMPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr PDMNDCIPGMK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr GCIILFJAFJM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr FABKEMDOPHP;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly EAPECHBFHAG PNJBLIJBOPG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KMEJBLAIFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x70443D0", Offset = "0x7042BD0", VA = "0x1870443D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
	public EAPECHBFHAG(IntPtr NOMMAHFHPNO, IntPtr HINILELOAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void PLMMIAKFAMN(string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void FIGGAPCOCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7044340", Offset = "0x7042B40", VA = "0x187044340")]
	private static EAPECHBFHAG HMNMEMJOJNP()
	{
		return default(EAPECHBFHAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly ref struct EMADJLLJNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr GHEEADGELCK;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	private EMADJLLJNNK(IntPtr HINILELOAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7044840", Offset = "0x7043040", VA = "0x187044840")]
	public void BJHAOCCHMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7044860", Offset = "0x7043060", VA = "0x187044860")]
	public static EMADJLLJNNK DFLBOLBHLFN(string IKMKCMDHFDC)
	{
		return default(EMADJLLJNNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x231E900", Offset = "0x231D100", VA = "0x18231E900")]
	public static EMADJLLJNNK DFLBOLBHLFN([In] EAPECHBFHAG MKBKOIPNOEI, string IKMKCMDHFDC)
	{
		return default(EMADJLLJNNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x231EBC0", Offset = "0x231D3C0", VA = "0x18231EBC0")]
	public static EMADJLLJNNK DFLBOLBHLFN([In] EAPECHBFHAG MKBKOIPNOEI, Func<string> IKMKCMDHFDC)
	{
		return default(EMADJLLJNNK);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class LMJNKOFOKOP
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool NPCLHDOGGND<in TInput, TResult>(TInput AOJEAJGBMCP, [Out] TResult HANDIANDCDI);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private sealed class DDLCDJPCIMC : NICFFBPKHLO
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class EJBABABEMAO : JIFKLJOMIHJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly EJBABABEMAO ODDIIHPHFEL;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool BPMEEIFADIH
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x7044600", Offset = "0x7042E00", VA = "0x187044600", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7044660", Offset = "0x7042E60", VA = "0x187044660", Slot = "6")]
			public void OnCompleted(Action OGJDIMIHDHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			public void MDDGKHNHAAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public EJBABABEMAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly DDLCDJPCIMC ODDIIHPHFEL;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		private DDLCDJPCIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7043630", Offset = "0x7041E30", VA = "0x187043630", Slot = "4")]
		public JIFKLJOMIHJ FJJFOJEIFLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private sealed class LIHPCNNGDFE : NICFFBPKHLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class FAEDHAFPAFJ : JIFKLJOMIHJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly FAEDHAFPAFJ ODDIIHPHFEL;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool BPMEEIFADIH
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x70453C0", Offset = "0x7043BC0", VA = "0x1870453C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x70453E0", Offset = "0x7043BE0", VA = "0x1870453E0", Slot = "6")]
			public void OnCompleted(Action OGJDIMIHDHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			public void MDDGKHNHAAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FAEDHAFPAFJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly LIHPCNNGDFE ODDIIHPHFEL;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		private LIHPCNNGDFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x704A310", Offset = "0x7048B10", VA = "0x18704A310", Slot = "4")]
		public JIFKLJOMIHJ FJJFOJEIFLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NIFDAMOIBIG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NIFDAMOIBIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x493EA00", Offset = "0x493D200", VA = "0x18493EA00")]
		internal void OHJMGIAJGOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class FLHNKENJHIB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FLHNKENJHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4071810", Offset = "0x4070010", VA = "0x184071810")]
		internal void IMIMHPBMHNA(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KABDPKKKFCJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7048940", Offset = "0x7047140", VA = "0x187048940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FLHAKCFFDEA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x70454B0", Offset = "0x7043CB0", VA = "0x1870454B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FOOOAHAKCBM<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4080330", Offset = "0x407EB30", VA = "0x184080330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x40804A0", Offset = "0x407ECA0", VA = "0x1840804A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NBBEDPAFMCD<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4A36AA0", Offset = "0x4A352A0", VA = "0x184A36AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4A372F0", Offset = "0x4A35AF0", VA = "0x184A372F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KNLKMOMLNKD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x70494E0", Offset = "0x7047CE0", VA = "0x1870494E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x70496E0", Offset = "0x7047EE0", VA = "0x1870496E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MBJGBINJMFB<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MBJGBINJMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x493EA00", Offset = "0x493D200", VA = "0x18493EA00")]
		internal void DALBPODDJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x493E980", Offset = "0x493D180", VA = "0x18493E980")]
		internal void CGFNBIEAEJH(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OFLALIANHHO<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public NPCLHDOGGND<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B51A70", Offset = "0x4B50270", VA = "0x184B51A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B52180", Offset = "0x4B50980", VA = "0x184B52180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OFEAJOIJKNF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x704CED0", Offset = "0x704B6D0", VA = "0x18704CED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x704D6C0", Offset = "0x704BEC0", VA = "0x18704D6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IMOEDNHKPPJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7047FD0", Offset = "0x70467D0", VA = "0x187047FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7048510", Offset = "0x7046D10", VA = "0x187048510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BMGHFLIAKLL<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x53C0D30", Offset = "0x53BF530", VA = "0x1853C0D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4531880", Offset = "0x4530080", VA = "0x184531880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EOKMAIEDABI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<DOPPLCFNMND> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EOKMAIEDABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7044950", Offset = "0x7043150", VA = "0x187044950")]
		internal void PLABGCIMAKI(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct AAPIIPCCMMI<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x40F6B10", Offset = "0x40F5310", VA = "0x1840F6B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x39CD7F0", Offset = "0x39CBFF0", VA = "0x1839CD7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PGIAKIHFEHD<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C65E30", Offset = "0x4C64630", VA = "0x184C65E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C66540", Offset = "0x4C64D40", VA = "0x184C66540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct HEMAHIDABMP : IAsyncStateMachine
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7045A80", Offset = "0x7044280", VA = "0x187045A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7045C60", Offset = "0x7044460", VA = "0x187045C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct KJNLEHDFLLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7049110", Offset = "0x7047910", VA = "0x187049110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7049480", Offset = "0x7047C80", VA = "0x187049480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct NKLLGBNICIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x704C840", Offset = "0x704B040", VA = "0x18704C840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x704CB30", Offset = "0x704B330", VA = "0x18704CB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class CGKFPKCBDOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CGKFPKCBDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x70435C0", Offset = "0x7041DC0", VA = "0x1870435C0")]
		internal Task LMPABCEFOIB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct OAOHPMHKIBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x704CC10", Offset = "0x704B410", VA = "0x18704CC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x704CE70", Offset = "0x704B670", VA = "0x18704CE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct OLLGHLKJNMP : IAsyncStateMachine
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x704D720", Offset = "0x704BF20", VA = "0x18704D720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x704D900", Offset = "0x704C100", VA = "0x18704D900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct JOAIIJMCKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7048570", Offset = "0x7046D70", VA = "0x187048570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x70488E0", Offset = "0x70470E0", VA = "0x1870488E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IGBGLABNFKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7046FB0", Offset = "0x70457B0", VA = "0x187046FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70472A0", Offset = "0x7045AA0", VA = "0x1870472A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class PFFKLHCKDAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PFFKLHCKDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x704D960", Offset = "0x704C160", VA = "0x18704D960")]
		internal Task LAFEOPHOBJG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BBAAHGGALIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7042030", Offset = "0x7040830", VA = "0x187042030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7042290", Offset = "0x7040A90", VA = "0x187042290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct NCDHJBJDJDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x704C660", Offset = "0x704AE60", VA = "0x18704C660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x704C7E0", Offset = "0x704AFE0", VA = "0x18704C7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JCDKLCPAMAN<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4523880", Offset = "0x4522080", VA = "0x184523880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4523AE0", Offset = "0x45222E0", VA = "0x184523AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct GIIHMKIENNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x70455F0", Offset = "0x7043DF0", VA = "0x1870455F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7045920", Offset = "0x7044120", VA = "0x187045920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? IGEBCBFFNLC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<DOPPLCFNMND> DBPMHLNBJML;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task MOLJONOLFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x704A460", Offset = "0x7048C60", VA = "0x18704A460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x704BB00", Offset = "0x704A300", VA = "0x18704BB00")]
	public static bool MKMMHACDEBN(this Task DIGFCMIOIEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3118AD0", Offset = "0x31172D0", VA = "0x183118AD0")]
	public static Task<T> GKHACEICBOC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x704B300", Offset = "0x7049B00", VA = "0x18704B300")]
	public static Task FNHODCAJOID(this Task DIGFCMIOIEB, CancellationToken DJIMHLGHFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x31171D0", Offset = "0x31159D0", VA = "0x1831171D0")]
	public static Task<TResult> FNHODCAJOID<TResult>(this Task<TResult> DIGFCMIOIEB, CancellationToken DJIMHLGHFGI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3118140", Offset = "0x3116940", VA = "0x183118140")]
	public static TaskCompletionSource<TResult> FNHODCAJOID<TResult>(this TaskCompletionSource<TResult> BOBBGFPNGHE, CancellationToken DJIMHLGHFGI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x704AD70", Offset = "0x7049570", VA = "0x18704AD70")]
	public static IDisposable? DPEEPCJEOLB(CancellationToken LGFINMDJJMA, CancellationToken BCOIIJKCHAB, [Out] CancellationToken IOCDIKJBAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x704A4D0", Offset = "0x7048CD0", VA = "0x18704A4D0")]
	[AsyncStateMachine(typeof(KABDPKKKFCJ))]
	public static void BEINOLENLBF(this Task EBDGHJJPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x704C440", Offset = "0x704AC40", VA = "0x18704C440")]
	[AsyncStateMachine(typeof(FLHAKCFFDEA))]
	public static void PNFOGMHKLPN(this Task EBDGHJJPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3118C50", Offset = "0x3117450", VA = "0x183118C50")]
	[AsyncStateMachine(typeof(FOOOAHAKCBM<>))]
	public static Task HLLLLJLFBAG<TException>(this Task EBDGHJJPDEM) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3114790", Offset = "0x3112F90", VA = "0x183114790")]
	[AsyncStateMachine(typeof(NBBEDPAFMCD<>))]
	public static Task<T> DJIOBKDMGDI<T>(this Task<T> EGGDEECAALI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x704B560", Offset = "0x7049D60", VA = "0x18704B560")]
	[AsyncStateMachine(typeof(KNLKMOMLNKD))]
	public static Task<TaskStatus> GGPLMMOCLCE(this Task EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3114330", Offset = "0x3112B30", VA = "0x183114330")]
	public static (Task<T?>?, Action<T?>?) CLAKDKNOOED<T>([Optional] CancellationToken ALKEMFHOMCA)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x31190D0", Offset = "0x31178D0", VA = "0x1831190D0")]
	[AsyncStateMachine(typeof(OFLALIANHHO<, >))]
	public static Task<List<TResult>> NFPIMAHLCIH<TResult, TInput>(this Task<List<TInput>> DIGFCMIOIEB, NPCLHDOGGND<TInput, TResult> BGFMEMLDHDM) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x704B890", Offset = "0x704A090", VA = "0x18704B890")]
	[AsyncStateMachine(typeof(OFEAJOIJKNF))]
	public static Task LKBCPFCIKOC(Task EBDGHJJPDEM, CancellationToken LCOCKEOACEA, Func<CancellationToken, Task> FGHKFAONFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x704AC40", Offset = "0x7049440", VA = "0x18704AC40")]
	[AsyncStateMachine(typeof(IMOEDNHKPPJ))]
	public static Task DPCCGKEMENJ(Func<CancellationToken, Task> KHJDBHICGKH, TimeSpan DEKMBJOBNGH, [Optional] CancellationToken LCOCKEOACEA, [Optional] Action<OperationCanceledException>? DPJBIAKFOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3114970", Offset = "0x3113170", VA = "0x183114970")]
	[AsyncStateMachine(typeof(BMGHFLIAKLL<>))]
	public static Task<T> DPCCGKEMENJ<T>(Func<CancellationToken, Task<T>> KHJDBHICGKH, TimeSpan DEKMBJOBNGH, [Optional] CancellationToken LCOCKEOACEA, [Optional] Func<OperationCanceledException, T>? DPJBIAKFOJL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x704C3F0", Offset = "0x704ABF0", VA = "0x18704C3F0")]
	public static Task PGAAIKEFFGA(params Task[] EJFKNKBFCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x704BF30", Offset = "0x704A730", VA = "0x18704BF30")]
	public static Task PGAAIKEFFGA(IEnumerable<Task> EJFKNKBFCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x31146A0", Offset = "0x3112EA0", VA = "0x1831146A0")]
	[AsyncStateMachine(typeof(AAPIIPCCMMI<>))]
	public static Task<IEnumerable<Task<T>>> CPCCJMNOPGK<T>(IEnumerable<Task<T>> EJFKNKBFCCB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3118D20", Offset = "0x3117520", VA = "0x183118D20")]
	[AsyncStateMachine(typeof(PGIAKIHFEHD<, , , >))]
	public static Task<(T1, T2, T3, T4)> KENEKGBCABO<T1, T2, T3, T4>(Task<T1> CNPOGLAADDL, Task<T2> BGAEBAEIMPM, Task<T3> FOEAPJHLCDH, Task<T4> CCBPGPPBMCJ) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x704BC40", Offset = "0x704A440", VA = "0x18704BC40")]
	[AsyncStateMachine(typeof(HEMAHIDABMP))]
	public static Task NFOEFOHJNLN(Func<bool> JDBPPNFCIBD, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x704BB30", Offset = "0x704A330", VA = "0x18704BB30")]
	[AsyncStateMachine(typeof(KJNLEHDFLLF))]
	public static Task NFOEFOHJNLN(Func<bool> JDBPPNFCIBD, TimeSpan OFPHIPHHMCB, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x704AB10", Offset = "0x7049310", VA = "0x18704AB10")]
	[AsyncStateMachine(typeof(NKLLGBNICIO))]
	public static Task DGPLHAIMLON(Func<bool> JDBPPNFCIBD, TimeSpan DEKMBJOBNGH, [Optional] CancellationToken ALKEMFHOMCA, [Optional] Action<OperationCanceledException>? DPJBIAKFOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x704A9D0", Offset = "0x70491D0", VA = "0x18704A9D0")]
	[AsyncStateMachine(typeof(OAOHPMHKIBP))]
	public static Task DGPLHAIMLON(Func<bool> JDBPPNFCIBD, TimeSpan DEKMBJOBNGH, TimeSpan OFPHIPHHMCB, [Optional] CancellationToken ALKEMFHOMCA, [Optional] Action<OperationCanceledException>? DPJBIAKFOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x704BD30", Offset = "0x704A530", VA = "0x18704BD30")]
	[AsyncStateMachine(typeof(OLLGHLKJNMP))]
	public static Task NMMJHLEJANJ(Func<bool> JDBPPNFCIBD, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x704BE20", Offset = "0x704A620", VA = "0x18704BE20")]
	[AsyncStateMachine(typeof(JOAIIJMCKDA))]
	public static Task NMMJHLEJANJ(Func<bool> JDBPPNFCIBD, TimeSpan OFPHIPHHMCB, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x704B090", Offset = "0x7049890", VA = "0x18704B090")]
	[AsyncStateMachine(typeof(IGBGLABNFKO))]
	public static Task EJEHCPIIIDD(Func<bool> JDBPPNFCIBD, TimeSpan DEKMBJOBNGH, [Optional] CancellationToken ALKEMFHOMCA, [Optional] Action<OperationCanceledException>? DPJBIAKFOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x704B1C0", Offset = "0x70499C0", VA = "0x18704B1C0")]
	[AsyncStateMachine(typeof(BBAAHGGALIG))]
	public static Task EJEHCPIIIDD(Func<bool> JDBPPNFCIBD, TimeSpan DEKMBJOBNGH, TimeSpan OFPHIPHHMCB, [Optional] CancellationToken ALKEMFHOMCA, [Optional] Action<OperationCanceledException>? DPJBIAKFOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x704BA10", Offset = "0x704A210", VA = "0x18704BA10")]
	[AsyncStateMachine(typeof(NCDHJBJDJDI))]
	[Obsolete]
	public static Task LPPOFHGGJIG(this Task DIGFCMIOIEB, Action AMLJBOFNCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3118FE0", Offset = "0x31177E0", VA = "0x183118FE0")]
	[AsyncStateMachine(typeof(JCDKLCPAMAN<>))]
	[Obsolete]
	public static Task LPPOFHGGJIG<T>(this Task<T> DIGFCMIOIEB, Action<T> AMLJBOFNCKP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x704C4F0", Offset = "0x704ACF0", VA = "0x18704C4F0")]
	private static void PNMDIMKIGAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x704A650", Offset = "0x7048E50", VA = "0x18704A650")]
	public static bool DDPCNBFOJKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x704AF00", Offset = "0x7049700", VA = "0x18704AF00")]
	private static void EIIABKGILBI(SynchronizationContext INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x704B770", Offset = "0x7049F70", VA = "0x18704B770")]
	private static void JLONKGIGOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x704A580", Offset = "0x7048D80", VA = "0x18704A580")]
	public static void CNHNADDEFJA([Optional] string? PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x704A3E0", Offset = "0x7048BE0", VA = "0x18704A3E0")]
	public static void ADIGFINEHJM([Optional] string? PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x704B9C0", Offset = "0x704A1C0", VA = "0x18704B9C0")]
	public static NICFFBPKHLO LKLCKCAHIEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x704B720", Offset = "0x7049F20", VA = "0x18704B720")]
	public static NICFFBPKHLO IHINAFFDIHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x704B650", Offset = "0x7049E50", VA = "0x18704B650")]
	[AsyncStateMachine(typeof(GIIHMKIENNL))]
	public static Task HKFBMHNEIDF(Func<Task> GOODBCHHJFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CEOCIAMIFJE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
	public CEOCIAMIFJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class AANFIENOGIL : PIAKAKLALCN
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly PIAKAKLALCN ODDIIHPHFEL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime KOKODFPODEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7041F70", Offset = "0x7040770", VA = "0x187041F70", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset KOOPHNOGMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7041F10", Offset = "0x7040710", VA = "0x187041F10", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public AANFIENOGIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface PIAKAKLALCN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime KOKODFPODEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset KOOPHNOGMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class HFOLOMKEGLP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long LFFMPFBACMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7045CC0", Offset = "0x70444C0", VA = "0x187045CC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long FKFFMEPOHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7045F00", Offset = "0x7044700", VA = "0x187045F00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double IJEKLFLOODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7046090", Offset = "0x7044890", VA = "0x187046090")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double FOCFKNPNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7045F50", Offset = "0x7044750", VA = "0x187045F50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LINOENODCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7046040", Offset = "0x7044840", VA = "0x187046040")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double AOECPKJFLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x70461D0", Offset = "0x70449D0", VA = "0x1870461D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7045E70", Offset = "0x7044670", VA = "0x187045E70")]
	public static double FAJBLFGJGPF(long PDMAMJHPHMC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7045D10", Offset = "0x7044510", VA = "0x187045D10")]
	public static double BEIECBKHBGO(long PDMAMJHPHMC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7046140", Offset = "0x7044940", VA = "0x187046140")]
	public static double NALHIOFPBFA(double LLAJBLAPPFH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7045FB0", Offset = "0x70447B0", VA = "0x187045FB0")]
	public static long IJBDOCHFKEB(long CKHMGDGNNBB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7045FA0", Offset = "0x70447A0", VA = "0x187045FA0")]
	public static long IFNCFLICBLI(long NMNGIANHCBF, long INLEKNBFGOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7045DA0", Offset = "0x70445A0", VA = "0x187045DA0")]
	public static double CNBAIFNKOCL(long NMNGIANHCBF, long INLEKNBFGOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x70460E0", Offset = "0x70448E0", VA = "0x1870460E0")]
	public static double LBOKEDIJIEH(long NMNGIANHCBF, long INLEKNBFGOM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class IIJPPKPMIFK : BOJFJKLDILF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan BFIOHMALLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer IEGOAOCEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan DEKMBJOBNGH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan EEHOEOFBHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7047540", Offset = "0x7045D40", VA = "0x187047540", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? HGIHCOEIKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7047740", Offset = "0x7045F40", VA = "0x187047740")]
	[Preserve]
	public IIJPPKPMIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x70477B0", Offset = "0x7045FB0", VA = "0x1870477B0")]
	public IIJPPKPMIFK(TimeSpan DEKMBJOBNGH, [Optional] Action? PNNCCBKHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7047300", Offset = "0x7045B00", VA = "0x187047300", Slot = "7")]
	public void CIICEFGCNDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x70474D0", Offset = "0x7045CD0", VA = "0x1870474D0", Slot = "8")]
	public void IFPPMDNBIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x70476A0", Offset = "0x7045EA0", VA = "0x1870476A0", Slot = "9")]
	public void OBPPMFLMKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0xCE24A0", Offset = "0xCE0CA0", VA = "0x180CE24A0")]
	private void LAANFHJHPIK(object FNGOEBINDAF, ElapsedEventArgs LFIJDGPMKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7047430", Offset = "0x7045C30", VA = "0x187047430")]
	private static void FPENMFIEKCG(TimeSpan CIPGHFJNGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7047390", Offset = "0x7045B90", VA = "0x187047390", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DGOKMPKFCKH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? AAEKGAAKNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string ELBEDLFIJGP;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A687B0", Offset = "0x6A66FB0", VA = "0x186A687B0")]
	public DGOKMPKFCKH(string GIMKNCGKHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4595180", Offset = "0x4593980", VA = "0x184595180")]
	public DGOKMPKFCKH(string LJMDFKCKKHM, string GIMKNCGKHFF)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct CGDEJEKEJDL : IEquatable<CGDEJEKEJDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint LJPOIFIBAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int OEANHKKDNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float AGDGPIOGENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort FEOCCEONFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort EFLDFKMOPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short CODGMCNCOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short HMJMBJBGPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char CJIGGGCOKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char GDLOHACMCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte JFBFCFEHGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte IGMEEFIIJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte IGBIAMNDLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte DMHPNAOOMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool CANAJFLMCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool KGAOPJHAKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool KLBKNJCPLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool JAKBHHIEMIN;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x181D930", Offset = "0x181C130", VA = "0x18181D930")]
	public static CGDEJEKEJDL NJLFNCGMMGG(uint PHJDHECMBHN)
	{
		return default(CGDEJEKEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x181D930", Offset = "0x181C130", VA = "0x18181D930")]
	public static CGDEJEKEJDL ACIAGLFCMJO(int BPMKGNODPMO)
	{
		return default(CGDEJEKEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x70427C0", Offset = "0x7040FC0", VA = "0x1870427C0")]
	public static CGDEJEKEJDL KDBJFKGFOBH(float CMDFJEDODLE)
	{
		return default(CGDEJEKEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x70427A0", Offset = "0x7040FA0", VA = "0x1870427A0")]
	public static CGDEJEKEJDL JHJKKOIBFNE(byte BINMKMHHKJK, byte INKBFPICLEJ, byte KHALGGOLGAN, byte GMAMNAKKJGD)
	{
		return default(CGDEJEKEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x70427A0", Offset = "0x7040FA0", VA = "0x1870427A0")]
	public static CGDEJEKEJDL PNACPNKKCGD(bool JOLFCGLPADH, bool AKBMBMAINHN, bool COOHJAPHPBC, bool MNDOGMPBJOO)
	{
		return default(CGDEJEKEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x70427A0", Offset = "0x7040FA0", VA = "0x1870427A0")]
	public static CGDEJEKEJDL OMLOGFIJEKD(byte POMJIGGLIHD, byte KMDIPNAIODC, byte HBJNDCDOFHM, byte GNFHNOOEFML)
	{
		return default(CGDEJEKEJDL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B910", Offset = "0x1B1A110", VA = "0x181B1B910")]
	public static bool PCBECHOJFKF(CGDEJEKEJDL GJAJAHIEACP, CGDEJEKEJDL MCEIDNFODED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B8F0", Offset = "0x1B1A0F0", VA = "0x181B1B8F0", Slot = "4")]
	public bool Equals(CGDEJEKEJDL LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7042720", Offset = "0x7040F20", VA = "0x187042720", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xE6C510", Offset = "0xE6AD10", VA = "0x180E6C510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x70427D0", Offset = "0x7040FD0", VA = "0x1870427D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct HJHOJLLBNCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong EANOIMODKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long KLDKLGCELBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double NCNFNHFDOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint HMOPLMDJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint EIKKFKNNJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int CCOANMCIFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int JHNIANJLEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float NEPDACGAMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float CJFHKJPEJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort FEOCCEONFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort EFLDFKMOPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort CGBHJEEHEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort HKDAJCPDOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short CODGMCNCOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short HMJMBJBGPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short OFIPPPGBCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short JGNMENIJAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char CJIGGGCOKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char GDLOHACMCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char FLDMOCFHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char PELJKHPMIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte JFBFCFEHGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte IGMEEFIIJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte IGBIAMNDLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte DMHPNAOOMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte CLMIJMGDBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte HPPMKJAEAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte ANGHGHAMPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte BAOAGIKIFJK;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static HJHOJLLBNCI DFLBOLBHLFN(long ABPPDHPFDFB)
	{
		return default(HJHOJLLBNCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x70464F0", Offset = "0x7044CF0", VA = "0x1870464F0")]
	public static HJHOJLLBNCI DFLBOLBHLFN(byte BINMKMHHKJK, byte INKBFPICLEJ, byte KHALGGOLGAN, byte GMAMNAKKJGD, byte PBGJDGBFAIK, byte MFJNHKCFGPE, byte NCJBGIFCCOI, byte DEEDMDPCAEA)
	{
		return default(HJHOJLLBNCI);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct BNLICLPBCDK : IEquatable<BNLICLPBCDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte BLKAPOCPBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool KHOIEJFAAMH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2953450", Offset = "0x2951C50", VA = "0x182953450")]
	public static BNLICLPBCDK JHJKKOIBFNE(byte JIGAGFDAOJJ)
	{
		return default(BNLICLPBCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2953450", Offset = "0x2951C50", VA = "0x182953450")]
	public static BNLICLPBCDK PNACPNKKCGD(bool DPBKJNPJAEF)
	{
		return default(BNLICLPBCDK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7042390", Offset = "0x7040B90", VA = "0x187042390")]
	public static bool PCBECHOJFKF(BNLICLPBCDK GJAJAHIEACP, BNLICLPBCDK MCEIDNFODED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6123AE0", Offset = "0x61222E0", VA = "0x186123AE0", Slot = "4")]
	public bool Equals(BNLICLPBCDK LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x70422F0", Offset = "0x7040AF0", VA = "0x1870422F0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7042380", Offset = "0x7040B80", VA = "0x187042380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x70423A0", Offset = "0x7040BA0", VA = "0x1870423A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class DOEJOGFBNFK<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T MBBKPOJMELK;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5E02920", Offset = "0x5E01120", VA = "0x185E02920")]
	public DOEJOGFBNFK(T IPNNMIAHECA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class GEHEBCKFOJC
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x307A710", Offset = "0x3078F10", VA = "0x18307A710")]
	public static IEnumerable<T> OGALFDEFCOA<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static T[] ABAGELLLCMP<T>(params T[] LPACCBCNCHP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static IEnumerable<T> IHCAEHKBHBC<T>(params T[] LPACCBCNCHP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2E619A0", Offset = "0x2E601A0", VA = "0x182E619A0")]
	public static HashSet<T> CMGFOEJKIFB<T>(params T[] LPACCBCNCHP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x307A620", Offset = "0x3078E20", VA = "0x18307A620")]
	public static KeyValuePair<TKey, TValue> ENOFGBPKIOL<TKey, TValue>([In] TKey KCGKBDGKIOP, [In] TValue INDENPJBLHO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2E619A0", Offset = "0x2E601A0", VA = "0x182E619A0")]
	public static List<T> DCEGNDPGFJO<T>(IEnumerable<T> HEMCJGBMGKH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JCCIDHPDJJP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string ABLBFJECHPH;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
	public JCCIDHPDJJP(string MLDMOMHJIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate object PANKJKLLPOD<T>([In] T GIOJKAECAOO);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate object FPLGOKNCGPL<T>(T GIOJKAECAOO);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[FJGNIKBIBPB]
public delegate string GNAPKLDAMNK(string JPJKMDGHCEE, string? HCEFDNFIGAF, bool JCFNAHEEPIB);
[Cpp2IlInjected.Token(Token = "0x200005E")]
[FJGNIKBIBPB]
public delegate void HOAIOLCKCBG(string PJFOMDHJLBF);
[Cpp2IlInjected.Token(Token = "0x200005F")]
[FJGNIKBIBPB]
public delegate void IJNGBMBGPAK(Exception HNGGNNBFAEK);
[Cpp2IlInjected.Token(Token = "0x2000060")]
public delegate object IGIMKPLBFDI();
[Cpp2IlInjected.Token(Token = "0x2000061")]
[FJGNIKBIBPB]
public delegate bool LDEKCMMCFII();
[Cpp2IlInjected.Token(Token = "0x2000062")]
[FJGNIKBIBPB]
public delegate string BMJNKEHAKCO(object INCBEIDOHDO);
[Cpp2IlInjected.Token(Token = "0x2000063")]
[AttributeUsage(AttributeTargets.Enum)]
public class FICKPOAFAHL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
	public FICKPOAFAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class KENKLBLPMIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct HJOPOBHKHKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7046540", Offset = "0x7044D40", VA = "0x187046540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7046E20", Offset = "0x7045620", VA = "0x187046E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback BPLODHLJMNA;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> LJJLFJALNEH;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7048BC0", Offset = "0x70473C0", VA = "0x187048BC0")]
	public static Task<bool> KLEGGLNMIGP(int BDKILJCMOLO, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7048ED0", Offset = "0x70476D0", VA = "0x187048ED0")]
	[AsyncStateMachine(typeof(HJOPOBHKHKB))]
	private static Task<bool> ODBIDMHAONH(int BDKILJCMOLO, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7048B30", Offset = "0x7047330", VA = "0x187048B30")]
	private static void IMFCPCDPGMK(object? LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7048AA0", Offset = "0x70472A0", VA = "0x187048AA0")]
	private static void BFOJCIOMOHJ(object? LCFHGACCKAF)
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
