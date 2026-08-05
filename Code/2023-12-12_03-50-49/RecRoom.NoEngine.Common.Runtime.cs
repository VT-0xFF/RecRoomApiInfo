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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8DF90", Offset = "0x5E8C790", VA = "0x185E8DF90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class MFAIONLGOOI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D5A0", Offset = "0x5E8BDA0", VA = "0x185E8D5A0")]
	public MFAIONLGOOI(bool NIJKLNJFHDC, string MKBCINPICGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DGCFKLAGHPB<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> BKMPFDDEJBO(CancellationToken GANAOLJLMGA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BHAJNCBFKGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public DGCFKLAGHPB<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public BKMPFDDEJBO taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x458F790", Offset = "0x458DF90", VA = "0x18458F790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x45907F0", Offset = "0x458EFF0", VA = "0x1845907F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource LFJFOBIGOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? KLPDFCKOOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? MMLMEAFGOKM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4DD3200", Offset = "0x4DD1A00", VA = "0x184DD3200")]
	[AsyncStateMachine(typeof(DGCFKLAGHPB<>.BHAJNCBFKGK))]
	public Task<TResult> COBCCJPFBPC(BKMPFDDEJBO LLOHMLPPOHE, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4DD3340", Offset = "0x4DD1B40", VA = "0x184DD3340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4DD33B0", Offset = "0x4DD1BB0", VA = "0x184DD33B0")]
	public DGCFKLAGHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EDDONIGCLEC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> EMIOOMIKBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T HMHFMLFLMGB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30F85E0", Offset = "0x30F6DE0", VA = "0x1830F85E0")]
	public EDDONIGCLEC([In] T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30F7EF0", Offset = "0x30F66F0", VA = "0x1830F7EF0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x30F8030", Offset = "0x30F6830", VA = "0x1830F8030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x30F82D0", Offset = "0x30F6AD0", VA = "0x1830F82D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CEOMKIFFCAD
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E86DC0", Offset = "0x5E855C0", VA = "0x185E86DC0")]
	public static void OEJMIDCNLIP(this CancellationTokenSource LFJFOBIGOHB, bool GMCDKIIPMKA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FDGENGFEHCH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	public FDGENGFEHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class LHNPKMLJMML : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	public LHNPKMLJMML(string MALNCPGMIBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class JHELNHMLECB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	public JHELNHMLECB(string MALNCPGMIBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NNGEGCJBMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2633550", Offset = "0x2631D50", VA = "0x182633550")]
	public static EPPNNCCDLMB AGHFDOKLCLP<T>()
	{
		return default(EPPNNCCDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2633750", Offset = "0x2631F50", VA = "0x182633750")]
	public static EPPNNCCDLMB ONNBPBKFNAI<T>([CallerMemberName] string PMDCAPIFBIP = "") where T : notnull
	{
		return default(EPPNNCCDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26334D0", Offset = "0x2631CD0", VA = "0x1826334D0")]
	public static EPPNNCCDLMB AGHFDOKLCLP<T>(this T CCHIEENNEGK) where T : notnull
	{
		return default(EPPNNCCDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26335D0", Offset = "0x2631DD0", VA = "0x1826335D0")]
	public static EPPNNCCDLMB EILFEHDGKAL<T>(this T CCHIEENNEGK, [CallerMemberName] string PMDCAPIFBIP = "") where T : notnull
	{
		return default(EPPNNCCDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26337E0", Offset = "0x2631FE0", VA = "0x1826337E0")]
	public static EPPNNCCDLMB ONNBPBKFNAI<T>(this T PIEBBHMNEOG, [CallerMemberName] string PMDCAPIFBIP = "") where T : notnull
	{
		return default(EPPNNCCDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DF10", Offset = "0x5E8C710", VA = "0x185E8DF10")]
	public static EPPNNCCDLMB ONNBPBKFNAI(string FJFAAFPJGNM, [CallerMemberName] string PMDCAPIFBIP = "")
	{
		return default(EPPNNCCDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DE70", Offset = "0x5E8C670", VA = "0x185E8DE70")]
	public static string IDIFIMIKFMA(this object PIEBBHMNEOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[FDGENGFEHCH]
public delegate long JNLDCOMMPMO();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JIDHIGEKJCA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static OBJGNCLDONO PLEKIMOCKKJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OBJGNCLDONO IOFMNGIKMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D1C0", Offset = "0x5E8B9C0", VA = "0x185E8D1C0")]
		get
		{
			return default(OBJGNCLDONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DJNFALAFNKL NMHNPIMDJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CAE0", Offset = "0x5E8B2E0", VA = "0x185E8CAE0")]
		get
		{
			return default(DJNFALAFNKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BBBLJJCEMFO IGPOGDLBMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CDF0", Offset = "0x5E8B5F0", VA = "0x185E8CDF0")]
		get
		{
			return default(BBBLJJCEMFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CF70", Offset = "0x5E8B770", VA = "0x185E8CF70")]
	public static void NMFGCEPJOKJ([In] OBJGNCLDONO BPIHBPAGANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D0F0", Offset = "0x5E8B8F0", VA = "0x185E8D0F0")]
	public static void OHIILDFJLAF(string OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CC00", Offset = "0x5E8B400", VA = "0x185E8CC00")]
	public static void IBJBAMNMDMB(string OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x253AA60", Offset = "0x2539260", VA = "0x18253AA60")]
	public static void IBJBAMNMDMB<T>(T AKIAGKECAIA, FKLCKOMIMGD<T> OLDFIJBKFKG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CD50", Offset = "0x5E8B550", VA = "0x185E8CD50")]
	public static void JAFEDJBJPDF(Exception IOPFKNIOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CF10", Offset = "0x5E8B710", VA = "0x185E8CF10")]
	public static void NHNAKLCEHKH(string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CB30", Offset = "0x5E8B330", VA = "0x185E8CB30")]
	public static void EOJFNICFJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CCD0", Offset = "0x5E8B4D0", VA = "0x185E8CCD0")]
	public static string IDIFIMIKFMA(object BEKFGDCEJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CB90", Offset = "0x5E8B390", VA = "0x185E8CB90")]
	public static long HEPPEFNOANI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CA40", Offset = "0x5E8B240", VA = "0x185E8CA40")]
	public static bool CPDLJFHNLKC(bool CPCFGJNAACA, string OLDFIJBKFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CE40", Offset = "0x5E8B640", VA = "0x185E8CE40")]
	public static double KMGBKMHFKEJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OBJGNCLDONO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly DJNFALAFNKL NMHNPIMDJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly BBBLJJCEMFO IGPOGDLBMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly GNKOLDHMCIG BBBNDKGFNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly JNLDCOMMPMO CNAKLLNAPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly EMDDEHNMPKB OGGJMGOLLOE;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly GNKOLDHMCIG KFCCEDEFCMF;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly JNLDCOMMPMO BIILMFGJBPB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EMDDEHNMPKB AILHOGNKENK;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OBJGNCLDONO NJCGGNOBEDM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KODPMDJOGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E010", Offset = "0x5E8C810", VA = "0x185E8E010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E870", Offset = "0x5E8D070", VA = "0x185E8E870")]
	public OBJGNCLDONO([In] DJNFALAFNKL NPCOLNDABEB, [In] BBBLJJCEMFO EEGBOODHIKL, GNKOLDHMCIG EKHNFPFHPNP, JNLDCOMMPMO KNHPBGMBCDE, EMDDEHNMPKB ONPNEICMBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E270", Offset = "0x5E8CA70", VA = "0x185E8E270")]
	private static string MHLLCANFDHP(object BEKFGDCEJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210")]
	private static long PLPBLNIHLEF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	private static string NOCMHPPJHFC(string OIHIJMCPAMD, string? PJCBEHMOMDC, bool EMAAIBCPDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E170", Offset = "0x5E8C970", VA = "0x185E8E170")]
	private static OBJGNCLDONO EGDEKBECGCH()
	{
		return default(OBJGNCLDONO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BIAHBNIJIFD
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGLKGJCAOJF NDIAGNCOELE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BGLKGJCAOJF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JMLBJKCFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEGLNODELFI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AIENODJKFOP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCNBHFDPOMC([In] T FPJCFKAMJHL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void JJCDBBKAAMO<T>([In] T AKIAGKECAIA);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IFEHEKNHKEN<T> : IEquatable<IFEHEKNHKEN<T>>, AIENODJKFOP<IFEHEKNHKEN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T HMHFMLFLMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int EGOJHBDPODL;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4E70", Offset = "0x1CD3670", VA = "0x181CD4E70")]
	public IFEHEKNHKEN([In] T DOLICEBFIPF, int EAHCFBMNNCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36A24B0", Offset = "0x36A0CB0", VA = "0x1836A24B0")]
	public static bool FMFPLPMCDAE([In] IFEHEKNHKEN<T> PCIGCGBJFLC, [In] IFEHEKNHKEN<T> FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x36A1F50", Offset = "0x36A0750", VA = "0x1836A1F50", Slot = "4")]
	public bool Equals(IFEHEKNHKEN<T> FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30FA080", Offset = "0x30F8880", VA = "0x1830FA080", Slot = "0")]
	public override bool Equals(object FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36A2EB0", Offset = "0x36A16B0", VA = "0x1836A2EB0")]
	public bool PCNBHFDPOMC([In] IFEHEKNHKEN<T> FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36A27B0", Offset = "0x36A0FB0", VA = "0x1836A27B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36A3470", Offset = "0x36A1C70", VA = "0x1836A3470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36A1970", Offset = "0x36A0170", VA = "0x1836A1970")]
	public void DJEJHKAEBIG([Out] T DOLICEBFIPF, [Out] int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36A2BC0", Offset = "0x36A13C0", VA = "0x1836A2BC0")]
	public (T, int) NCMOAMEHFEG()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36A2050", Offset = "0x36A0850", VA = "0x1836A2050", Slot = "5")]
	private bool FIGJLKMKOKP([In] IFEHEKNHKEN<T> FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BKPAAHJIEIH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x22CB220", Offset = "0x22C9A20", VA = "0x1822CB220")]
	public static IFEHEKNHKEN<T> AKKFLOCCMNP<T>([In] T DOLICEBFIPF, int EAHCFBMNNCF) where T : notnull
	{
		return default(IFEHEKNHKEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KHPAIJNFAME
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x25587C0", Offset = "0x2556FC0", VA = "0x1825587C0")]
	public static bool PCNBHFDPOMC<T, U>([In] T PIEBBHMNEOG, [In] U BEKFGDCEJDH) where T : notnull, AIENODJKFOP<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult HDFMNNEOBEA<T, out TResult>([In] T AKIAGKECAIA);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult MOMPLKMDJNG<T1, T2, out TResult>([In] T1 EMCACJCLHII, [In] T2 GLJNGBGAFDJ);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DIAGGHPJMJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan KNLKGONCGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Action? BFLDPKLKCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFEANBKPEKM();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLGNAGHODPB();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEEEKMDJAJH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct DJNFALAFNKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly EMJNCKMKBLF NFGACKNJMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly BLNHCICJOLM HFDCIBCNBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EMJNCKMKBLF IMNPEIBECFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly BLNHCICJOLM GFDBCBDHOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly EMJNCKMKBLF EAPNMPDKNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly BLNHCICJOLM OJMMOJJLCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly GIDNBGGDBCK HCJMHHKIGPL;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly EMJNCKMKBLF OPBINEOMPIB;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly BLNHCICJOLM PMEEFNLPJCF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly EMJNCKMKBLF PJHBADKOEOI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly BLNHCICJOLM MBDNMPEJJMC;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly EMJNCKMKBLF MEJBLABHGAO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly BLNHCICJOLM NBMFJOHAEGO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GIDNBGGDBCK ILJMPMEHOKE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly DJNFALAFNKL NJCGGNOBEDM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly EMJNCKMKBLF OAGGPGKIBHC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KODPMDJOGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E87360", Offset = "0x5E85B60", VA = "0x185E87360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8F5320", Offset = "0x8F3B20", VA = "0x1808F5320")]
	public DJNFALAFNKL(EMJNCKMKBLF GNNPEDHPNAB, BLNHCICJOLM GKPBIGAHIEM, EMJNCKMKBLF HLNIPCCFAAN, BLNHCICJOLM LHGDAOGNIAD, EMJNCKMKBLF GDDFCHAHKFG, BLNHCICJOLM OFDMPMIKCCA, GIDNBGGDBCK JPHDDHJBHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0")]
	private static bool NBKMFDCJOGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private static void NLHMEEOEDMM(string OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0")]
	private static bool KHIFLFGHBNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private static void HCIJDDLLBHM(string OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0")]
	private static bool KBKGCKAPBGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private static void CFIPCDNMDHG(string OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private static void KOALINALIJL(Exception IOPFKNIOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E87630", Offset = "0x5E85E30", VA = "0x185E87630")]
	private static DJNFALAFNKL EGDEKBECGCH()
	{
		return default(DJNFALAFNKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0")]
	private static bool MELNJEICMDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E878C0", Offset = "0x5E860C0", VA = "0x185E878C0")]
	public void OHIILDFJLAF(object OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E87770", Offset = "0x5E85F70", VA = "0x185E87770")]
	public void IBJBAMNMDMB(object OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20DB570", Offset = "0x20D9D70", VA = "0x1820DB570")]
	public void JAFEDJBJPDF(Exception IOPFKNIOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E877E0", Offset = "0x5E85FE0", VA = "0x185E877E0")]
	public void IBJBAMNMDMB(EOIEIGCJMNN OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2358090", Offset = "0x2356890", VA = "0x182358090")]
	public void IBJBAMNMDMB<T>(T AKIAGKECAIA, FKLCKOMIMGD<T> OLDFIJBKFKG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2358150", Offset = "0x2356950", VA = "0x182358150")]
	public void OHIILDFJLAF<T>([In] T AKIAGKECAIA, IGKKIBHLLKG<T> OLDFIJBKFKG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E87560", Offset = "0x5E85D60", VA = "0x185E87560")]
	public bool CPDLJFHNLKC(bool CPCFGJNAACA, string OLDFIJBKFKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct EPPNNCCDLMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string HMHFMLFLMGB;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	public EPPNNCCDLMB(string DOLICEBFIPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
	public static string DBFFIFAHFFL([In] EPPNNCCDLMB PIEBBHMNEOG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x13AA520", Offset = "0x13A8D20", VA = "0x1813AA520")]
	public static EPPNNCCDLMB DBFFIFAHFFL(string FPJCFKAMJHL)
	{
		return default(EPPNNCCDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E88880", Offset = "0x5E87080", VA = "0x185E88880")]
	public string GPPEMCNGDBG(string KADLHIPLPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E887A0", Offset = "0x5E86FA0", VA = "0x185E887A0")]
	public string GKIABFOMCHM(object GILJEAPGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct EGJHPKNOBOC : IEquatable<EGJHPKNOBOC>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "4")]
	public bool Equals(EGJHPKNOBOC FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E88710", Offset = "0x5E86F10", VA = "0x185E88710", Slot = "0")]
	public override bool Equals(object FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E88760", Offset = "0x5E86F60", VA = "0x185E88760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E88770", Offset = "0x5E86F70", VA = "0x185E88770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[FJDOMJOPJJA("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JLEEOCGECPK<T> : IEquatable<JLEEOCGECPK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T HMHFMLFLMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool CCGEJKALJHG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NEDIHKEHGID
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x38AD3F0", Offset = "0x38ABBF0", VA = "0x1838AD3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38AD800", Offset = "0x38AC000", VA = "0x1838AD800")]
	public JLEEOCGECPK([In] T DOLICEBFIPF, bool ECBIIBFFLAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38ACF20", Offset = "0x38AB720", VA = "0x1838ACF20")]
	public static bool FMFPLPMCDAE([In] JLEEOCGECPK<T> PCIGCGBJFLC, [In] JLEEOCGECPK<T> FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x36A1F50", Offset = "0x36A0750", VA = "0x1836A1F50", Slot = "4")]
	public bool Equals(JLEEOCGECPK<T> FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x38AC620", Offset = "0x38AAE20", VA = "0x1838AC620", Slot = "0")]
	public override bool Equals(object FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x38AD2C0", Offset = "0x38ABAC0", VA = "0x1838AD2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38AD5E0", Offset = "0x38ABDE0", VA = "0x1838AD5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class PIFJADKCDKE
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2656000", Offset = "0x2654800", VA = "0x182656000")]
	public static JLEEOCGECPK<T> ELPEDJAKDHM<T>([In] T DOLICEBFIPF) where T : notnull
	{
		return default(JLEEOCGECPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2656140", Offset = "0x2654940", VA = "0x182656140")]
	public static JLEEOCGECPK<T?> GDDGMFPJAFH<T>()
	{
		return default(JLEEOCGECPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26561B0", Offset = "0x26549B0", VA = "0x1826561B0")]
	public static bool JPPDDIFKGND<T>([In] this JLEEOCGECPK<T> BDKNKEKNCCB, [Out][NotNullWhen(true)] T DOLICEBFIPF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct BBBLJJCEMFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly IntPtr NHNAKLCEHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly IntPtr EOJFNICFJPN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IntPtr FJDOLEJLEDE;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly IntPtr MCLAGHPOMGD;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly BBBLJJCEMFO NJCGGNOBEDM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KODPMDJOGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E86850", Offset = "0x5E85050", VA = "0x185E86850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8384B0", Offset = "0x836CB0", VA = "0x1808384B0")]
	public BBBLJJCEMFO(IntPtr LBLCDHAKJFG, IntPtr OBLDPDPGDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private static void GCLJMNMKCJC(string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private static void GMLDOFGKDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E86930", Offset = "0x5E85130", VA = "0x185E86930")]
	private static BBBLJJCEMFO EGDEKBECGCH()
	{
		return default(BBBLJJCEMFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct EGHKGPPLONN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IntPtr LEPMHNNGLPG;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	private EGHKGPPLONN(IntPtr OBLDPDPGDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E88700", Offset = "0x5E86F00", VA = "0x185E88700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E88610", Offset = "0x5E86E10", VA = "0x185E88610")]
	public static EGHKGPPLONN AKKFLOCCMNP(string PMDCAPIFBIP)
	{
		return default(EGHKGPPLONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB040", Offset = "0x1CC9840", VA = "0x181CCB040")]
	public static EGHKGPPLONN AKKFLOCCMNP([In] BBBLJJCEMFO EEGBOODHIKL, string PMDCAPIFBIP)
	{
		return default(EGHKGPPLONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CCABF0", Offset = "0x1CC93F0", VA = "0x181CCABF0")]
	public static EGHKGPPLONN AKKFLOCCMNP([In] BBBLJJCEMFO EEGBOODHIKL, Func<string> PMDCAPIFBIP)
	{
		return default(EGHKGPPLONN);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HKAMGIIMLCN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool OJAOPNMLFBL<in TInput, TResult>(TInput LLJFBBILFIJ, [Out] TResult MLABNLLFODC);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class NLJJEHGEINA : BIAHBNIJIFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class CMKCIOMDJII : BGLKGJCAOJF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly CMKCIOMDJII ODCBNHJKAMO;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool JMLBJKCFCHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x5E86EE0", Offset = "0x5E856E0", VA = "0x185E86EE0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E86F40", Offset = "0x5E85740", VA = "0x185E86F40", Slot = "6")]
			public void OnCompleted(Action JPCBANHILHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			public void DEGLNODELFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public CMKCIOMDJII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly NLJJEHGEINA ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private NLJJEHGEINA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DDA0", Offset = "0x5E8C5A0", VA = "0x185E8DDA0", Slot = "4")]
		public BGLKGJCAOJF NDIAGNCOELE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class BJDGCGNDDKB : BIAHBNIJIFD
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class CJNKHAGOCML : BGLKGJCAOJF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly CJNKHAGOCML ODCBNHJKAMO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool JMLBJKCFCHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x5E86DF0", Offset = "0x5E855F0", VA = "0x185E86DF0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E86E10", Offset = "0x5E85610", VA = "0x185E86E10", Slot = "6")]
			public void OnCompleted(Action JPCBANHILHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			public void DEGLNODELFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public CJNKHAGOCML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly BJDGCGNDDKB ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private BJDGCGNDDKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E86B10", Offset = "0x5E85310", VA = "0x185E86B10", Slot = "4")]
		public BGLKGJCAOJF NDIAGNCOELE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LIGHCHPBBOG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LIGHCHPBBOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A56E00", Offset = "0x3A55600", VA = "0x183A56E00")]
		internal void FOMFPJIABND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PPOAAJHJCLN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PPOAAJHJCLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F275E0", Offset = "0x3F25DE0", VA = "0x183F275E0")]
		internal void CDAGGLCKLLD(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NINNPJGHJHM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8D6C0", Offset = "0x5E8BEC0", VA = "0x185E8D6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD10", Offset = "0x7EC510", VA = "0x1807EDD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct AIEKPPELFDP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E86740", Offset = "0x5E84F40", VA = "0x185E86740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD10", Offset = "0x7EC510", VA = "0x1807EDD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct IPDJFJEJENB<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x36C82F0", Offset = "0x36C6AF0", VA = "0x1836C82F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x36C8460", Offset = "0x36C6C60", VA = "0x1836C8460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct JLFDGOBMKPE<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x38AD850", Offset = "0x38AC050", VA = "0x1838AD850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x38AE0C0", Offset = "0x38AC8C0", VA = "0x1838AE0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JLOBEAHGACD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8D2C0", Offset = "0x5E8BAC0", VA = "0x185E8D2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D4C0", Offset = "0x5E8BCC0", VA = "0x185E8D4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class NMDIOCJBFJG<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NMDIOCJBFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A56E00", Offset = "0x3A55600", VA = "0x183A56E00")]
		internal void NHACLFAAGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E1D0", Offset = "0x3D3C9D0", VA = "0x183D3E1D0")]
		internal void CCCKDPJFKIP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HAJFLIADJMB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public OJAOPNMLFBL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x357D9C0", Offset = "0x357C1C0", VA = "0x18357D9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x357E0B0", Offset = "0x357C8B0", VA = "0x18357E0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct IEBJPGGNPCA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8C1F0", Offset = "0x5E8A9F0", VA = "0x185E8C1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C9E0", Offset = "0x5E8B1E0", VA = "0x185E8C9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FPPEOHJNBCG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E88C20", Offset = "0x5E87420", VA = "0x185E88C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E89160", Offset = "0x5E87960", VA = "0x185E89160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DNOJFMKNDAC<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4DE7100", Offset = "0x4DE5900", VA = "0x184DE7100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x388F7B0", Offset = "0x388DFB0", VA = "0x18388F7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct ECJOGDEEJHF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x30F65C0", Offset = "0x30F4DC0", VA = "0x1830F65C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x30F69A0", Offset = "0x30F51A0", VA = "0x1830F69A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct POJAIMMLBFK<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3F1EBA0", Offset = "0x3F1D3A0", VA = "0x183F1EBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F2A0", Offset = "0x3F1DAA0", VA = "0x183F1F2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct HGHENEOLCDH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8A580", Offset = "0x5E88D80", VA = "0x185E8A580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A8F0", Offset = "0x5E890F0", VA = "0x185E8A8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FJHHECCJKDL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E888D0", Offset = "0x5E870D0", VA = "0x185E888D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E88BC0", Offset = "0x5E873C0", VA = "0x185E88BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PCDCMFLPJFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PCDCMFLPJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F7B0", Offset = "0x5E8DFB0", VA = "0x185E8F7B0")]
		internal Task DPPBMDLGJAD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NKIIEIPHOFK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8DAE0", Offset = "0x5E8C2E0", VA = "0x185E8DAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DD40", Offset = "0x5E8C540", VA = "0x185E8DD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DCACBFMCMIM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E87120", Offset = "0x5E85920", VA = "0x185E87120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E87300", Offset = "0x5E85B00", VA = "0x185E87300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct HGBPNIJNAKA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8A1B0", Offset = "0x5E889B0", VA = "0x185E8A1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A520", Offset = "0x5E88D20", VA = "0x185E8A520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GCDICFLOCJI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E89630", Offset = "0x5E87E30", VA = "0x185E89630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E89920", Offset = "0x5E88120", VA = "0x185E89920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KADLFKILLLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public KADLFKILLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D530", Offset = "0x5E8BD30", VA = "0x185E8D530")]
		internal Task MCKICBECHAA(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct NJAOKFEAMGM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E8D820", Offset = "0x5E8C020", VA = "0x185E8D820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DA80", Offset = "0x5E8C280", VA = "0x185E8DA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct BJOBMBIJJGF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E86BE0", Offset = "0x5E853E0", VA = "0x185E86BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E86D60", Offset = "0x5E85560", VA = "0x185E86D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CEPCFDFBEOK<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x48F4000", Offset = "0x48F2800", VA = "0x1848F4000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x48F4260", Offset = "0x48F2A60", VA = "0x1848F4260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GBHMLHMHFGP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E891C0", Offset = "0x5E879C0", VA = "0x185E891C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E895D0", Offset = "0x5E87DD0", VA = "0x185E895D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static SynchronizationContext? EINFBPPEDKL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly TaskCompletionSource<EGJHPKNOBOC> OKMOACNEMJD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static Task BLMLAEONMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E8AC10", Offset = "0x5E89410", VA = "0x185E8AC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24F0E20", Offset = "0x24EF620", VA = "0x1824F0E20")]
	public static Task<T> FHPENGCLNDM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BE20", Offset = "0x5E8A620", VA = "0x185E8BE20")]
	public static Task OPLNACLMKBM(this Task KONAOGGENMJ, CancellationToken JECMOKMEJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x24F28E0", Offset = "0x24F10E0", VA = "0x1824F28E0")]
	public static Task<TResult> OPLNACLMKBM<TResult>(this Task<TResult> KONAOGGENMJ, CancellationToken JECMOKMEJED) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x24F30D0", Offset = "0x24F18D0", VA = "0x1824F30D0")]
	public static TaskCompletionSource<TResult> OPLNACLMKBM<TResult>(this TaskCompletionSource<TResult> MJGKNEPNLPB, CancellationToken JECMOKMEJED) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B390", Offset = "0x5E89B90", VA = "0x185E8B390")]
	[AsyncStateMachine(typeof(NINNPJGHJHM))]
	public static void KNPAOKHKNOI(this Task OPLOPEJIHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B8B0", Offset = "0x5E8A0B0", VA = "0x185E8B8B0")]
	[AsyncStateMachine(typeof(AIEKPPELFDP))]
	public static void MMOONDBJAOL(this Task OPLOPEJIHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x24F0F70", Offset = "0x24EF770", VA = "0x1824F0F70")]
	[AsyncStateMachine(typeof(IPDJFJEJENB<>))]
	public static Task NOIAJFMBIHH<TException>(this Task OPLOPEJIHLC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x24F3530", Offset = "0x24F1D30", VA = "0x1824F3530")]
	[AsyncStateMachine(typeof(JLFDGOBMKPE<>))]
	public static Task<T> PKFIPDJBEEK<T>(this Task<T> PIEBBHMNEOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B7C0", Offset = "0x5E89FC0", VA = "0x185E8B7C0")]
	[AsyncStateMachine(typeof(JLOBEAHGACD))]
	public static Task<TaskStatus> MGMHIFGAADJ(this Task PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x24F0BE0", Offset = "0x24EF3E0", VA = "0x1824F0BE0")]
	public static (Task<T?>?, Action<T?>?) FEGBJIDBJIG<T>([Optional] CancellationToken GANAOLJLMGA)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x24F0AE0", Offset = "0x24EF2E0", VA = "0x1824F0AE0")]
	[AsyncStateMachine(typeof(HAJFLIADJMB<, >))]
	public static Task<List<TResult>> DPPMNNPCHKD<TResult, TInput>(this Task<List<TInput>> KONAOGGENMJ, OJAOPNMLFBL<TInput, TResult> OFMGOGMGFDG) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BB60", Offset = "0x5E8A360", VA = "0x185E8BB60")]
	[AsyncStateMachine(typeof(IEBJPGGNPCA))]
	public static Task NENHGNAHNCO(Task OPLOPEJIHLC, CancellationToken LCNDAGMDGPL, Func<CancellationToken, Task> OIGDIFHILBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AA90", Offset = "0x5E89290", VA = "0x185E8AA90")]
	[AsyncStateMachine(typeof(FPPEOHJNBCG))]
	public static Task BLLKHPIPDPO(Func<CancellationToken, Task> JGEDAGPGKBM, TimeSpan ILOOJEFCFKO, [Optional] CancellationToken LCNDAGMDGPL, [Optional] Action<OperationCanceledException>? HMMLBCANCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x24F0710", Offset = "0x24EEF10", VA = "0x1824F0710")]
	[AsyncStateMachine(typeof(DNOJFMKNDAC<>))]
	public static Task<T> BLLKHPIPDPO<T>(Func<CancellationToken, Task<T>> JGEDAGPGKBM, TimeSpan ILOOJEFCFKO, [Optional] CancellationToken LCNDAGMDGPL, [Optional] Func<OperationCanceledException, T>? HMMLBCANCKM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x24F0410", Offset = "0x24EEC10", VA = "0x1824F0410")]
	[AsyncStateMachine(typeof(ECJOGDEEJHF<>))]
	public static Task<IEnumerable<Task<T>>> ADGIEOJPEMD<T>(IEnumerable<Task<T>> HFMFBCLBMOP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x24F0840", Offset = "0x24EF040", VA = "0x1824F0840")]
	[AsyncStateMachine(typeof(POJAIMMLBFK<, , , >))]
	public static Task<(T1, T2, T3, T4)> DFKJEPOAIBG<T1, T2, T3, T4>(Task<T1> IHPEPDNHODB, Task<T2> NBKKINCODBP, Task<T3> ONKMCGLHKOL, Task<T4> HEPGOJIHNHF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B440", Offset = "0x5E89C40", VA = "0x185E8B440")]
	[AsyncStateMachine(typeof(HGHENEOLCDH))]
	public static Task KOFKBFDBACP(Func<bool> CPCFGJNAACA, TimeSpan ABOPDDHHHGM, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B550", Offset = "0x5E89D50", VA = "0x185E8B550")]
	[AsyncStateMachine(typeof(FJHHECCJKDL))]
	public static Task LICAPDAOPDM(Func<bool> CPCFGJNAACA, TimeSpan ILOOJEFCFKO, [Optional] CancellationToken GANAOLJLMGA, [Optional] Action<OperationCanceledException>? HMMLBCANCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B680", Offset = "0x5E89E80", VA = "0x185E8B680")]
	[AsyncStateMachine(typeof(NKIIEIPHOFK))]
	public static Task LICAPDAOPDM(Func<bool> CPCFGJNAACA, TimeSpan ILOOJEFCFKO, TimeSpan ABOPDDHHHGM, [Optional] CancellationToken GANAOLJLMGA, [Optional] Action<OperationCanceledException>? HMMLBCANCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BA70", Offset = "0x5E8A270", VA = "0x185E8BA70")]
	[AsyncStateMachine(typeof(DCACBFMCMIM))]
	public static Task NDONPADLFPM(Func<bool> CPCFGJNAACA, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B960", Offset = "0x5E8A160", VA = "0x185E8B960")]
	[AsyncStateMachine(typeof(HGBPNIJNAKA))]
	public static Task NDONPADLFPM(Func<bool> CPCFGJNAACA, TimeSpan ABOPDDHHHGM, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B140", Offset = "0x5E89940", VA = "0x185E8B140")]
	[AsyncStateMachine(typeof(GCDICFLOCJI))]
	public static Task KDLEKNDCMKL(Func<bool> CPCFGJNAACA, TimeSpan ILOOJEFCFKO, [Optional] CancellationToken GANAOLJLMGA, [Optional] Action<OperationCanceledException>? HMMLBCANCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B000", Offset = "0x5E89800", VA = "0x185E8B000")]
	[AsyncStateMachine(typeof(NJAOKFEAMGM))]
	public static Task KDLEKNDCMKL(Func<bool> CPCFGJNAACA, TimeSpan ILOOJEFCFKO, TimeSpan ABOPDDHHHGM, [Optional] CancellationToken GANAOLJLMGA, [Optional] Action<OperationCanceledException>? HMMLBCANCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A9A0", Offset = "0x5E891A0", VA = "0x185E8A9A0")]
	[Obsolete]
	[AsyncStateMachine(typeof(BJOBMBIJJGF))]
	public static Task BGFCEGOGEGB(this Task KONAOGGENMJ, Action LGOGHIECNLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x24F04F0", Offset = "0x24EECF0", VA = "0x1824F04F0")]
	[Obsolete]
	[AsyncStateMachine(typeof(CEPCFDFBEOK<>))]
	public static Task BGFCEGOGEGB<T>(this Task<T> KONAOGGENMJ, Action<T> LGOGHIECNLJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AC80", Offset = "0x5E89480", VA = "0x185E8AC80")]
	public static bool HMIKAJPPBID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BC90", Offset = "0x5E8A490", VA = "0x185E8BC90")]
	private static void OEOEDEJKGAM(SynchronizationContext DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B270", Offset = "0x5E89A70", VA = "0x185E8B270")]
	private static void KFFPMGLDCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A950", Offset = "0x5E89150", VA = "0x185E8A950")]
	public static BIAHBNIJIFD APHACOBJJBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8ABC0", Offset = "0x5E893C0", VA = "0x185E8ABC0")]
	public static BIAHBNIJIFD DJJDLJNFJPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C060", Offset = "0x5E8A860", VA = "0x185E8C060")]
	[AsyncStateMachine(typeof(GBHMLHMHFGP))]
	public static Task PNGECBELEDK(Func<Task> KCILOJEPOFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class JEKFJOKMMCA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	public JEKFJOKMMCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class AFHCGFCLMIG : NDIKELKCBDO
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly NDIKELKCBDO ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DateTime CPCJCJINMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E86620", Offset = "0x5E84E20", VA = "0x185E86620", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTimeOffset AAHCICABOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E86660", Offset = "0x5E84E60", VA = "0x185E86660", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public AFHCGFCLMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NDIKELKCBDO
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DateTime CPCJCJINMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTimeOffset AAHCICABOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class GEBNBLLCNKI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static long HDEIMPEMDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E89C90", Offset = "0x5E88490", VA = "0x185E89C90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long JHMOIAHKCIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E89CE0", Offset = "0x5E884E0", VA = "0x185E89CE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static double OPAGPNCCMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E89980", Offset = "0x5E88180", VA = "0x185E89980")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double HKGLMNCBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E89AD0", Offset = "0x5E882D0", VA = "0x185E89AD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double AEJMOGCPMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E89B20", Offset = "0x5E88320", VA = "0x185E89B20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double DFKJCDFGAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E89E90", Offset = "0x5E88690", VA = "0x185E89E90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E89C00", Offset = "0x5E88400", VA = "0x185E89C00")]
	public static double HFMALCPJIHP(long PDHEMLEKJIE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E89D30", Offset = "0x5E88530", VA = "0x185E89D30")]
	public static double LCAFAINLEKH(long PDHEMLEKJIE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5E899E0", Offset = "0x5E881E0", VA = "0x185E899E0")]
	public static double FCMPBMPEMIC(double FJHCPAIOJGD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E89B70", Offset = "0x5E88370", VA = "0x185E89B70")]
	public static long HDIDEHKBIBO(long GDAIBLFKMLM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E899D0", Offset = "0x5E881D0", VA = "0x185E899D0")]
	public static long ELHJLAHCFFG(long AENBOFKPLLM, long LLFCGIMDPGM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E89DC0", Offset = "0x5E885C0", VA = "0x185E89DC0")]
	public static double NBNPDDHHJMI(long AENBOFKPLLM, long LLFCGIMDPGM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E89A70", Offset = "0x5E88270", VA = "0x185E89A70")]
	public static double FGNJDAPADGB(long AENBOFKPLLM, long LLFCGIMDPGM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class DKKHOOIAICB : DIAGGHPJMJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly TimeSpan BHKIGHMFJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly System.Timers.Timer PFAPIIDDMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private TimeSpan ILOOJEFCFKO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public TimeSpan KNLKGONCGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E88080", Offset = "0x5E86880", VA = "0x185E88080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Action? BFLDPKLKCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E885A0", Offset = "0x5E86DA0", VA = "0x185E885A0")]
	[Preserve]
	public DKKHOOIAICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E88350", Offset = "0x5E86B50", VA = "0x185E88350")]
	public DKKHOOIAICB(TimeSpan ILOOJEFCFKO, [Optional] Action? ONLNBIJOIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E881E0", Offset = "0x5E869E0", VA = "0x185E881E0", Slot = "7")]
	public void KFEANBKPEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E88270", Offset = "0x5E86A70", VA = "0x185E88270", Slot = "8")]
	public void KLGNAGHODPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E87F10", Offset = "0x5E86710", VA = "0x185E87F10", Slot = "9")]
	public void AEEEKMDJAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xB5E740", Offset = "0xB5CF40", VA = "0x180B5E740")]
	private void OKMPGPDPJEE(object CCHIEENNEGK, ElapsedEventArgs PLNFBKGEKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E87F40", Offset = "0x5E86740", VA = "0x185E87F40")]
	private static void BOFNDMPDPOC(TimeSpan JABJNIAAAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E87FE0", Offset = "0x5E867E0", VA = "0x185E87FE0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class FJDOMJOPJJA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string GHLGOPCAHEN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
	public FJDOMJOPJJA(string MMOFPMCDOKA)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OGEIICDNHGP : IEquatable<OGEIICDNHGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public uint NAOAJHBEMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public int JNCOOGBKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public float EOPPGJMPMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public ushort FNECHDGGPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public ushort LPCCNCIAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public short HECOOCOLBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public short ACHDFMJAMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public char AAPNLKNIPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public char IPDHMNMBGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public byte JKGIGPGCJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte BEAACEHIDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public byte HJEKCEHGAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public byte AOCKKKGFEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public bool GMMEHANIDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool BBHJEHDIGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public bool OMOLLEEELHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public bool EDGEIMCPPHD;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static OGEIICDNHGP CNECNCLNIKP(uint OMBNLHLMCOA)
	{
		return default(OGEIICDNHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static OGEIICDNHGP CNAMPDFOIFE(int IKGKFBAKAKO)
	{
		return default(OGEIICDNHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E9B0", Offset = "0x5E8D1B0", VA = "0x185E8E9B0")]
	public static OGEIICDNHGP FPJDECPJFBJ(float HHKPNOMKNEN)
	{
		return default(OGEIICDNHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E990", Offset = "0x5E8D190", VA = "0x185E8E990")]
	public static OGEIICDNHGP FBOAKJHNNJA(byte DFIPKDKMOPO, byte MDLGNMBJKIN, byte GAIALIJFOOM, byte PHPDDPDGDPK)
	{
		return default(OGEIICDNHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E990", Offset = "0x5E8D190", VA = "0x185E8E990")]
	public static OGEIICDNHGP NNDCOPPKOOD(bool LHKPPCECHAK, bool OMEMCBDOPAB, bool NPHMFNGFBKI, bool DBCILPOFDNE)
	{
		return default(OGEIICDNHGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x170D6A0", Offset = "0x170BEA0", VA = "0x18170D6A0")]
	public static bool FMFPLPMCDAE(OGEIICDNHGP NMCFAAKFHJI, OGEIICDNHGP AKHEBCAILGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFC0", Offset = "0x7DC7C0", VA = "0x1807DDFC0", Slot = "4")]
	public bool Equals(OGEIICDNHGP FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E910", Offset = "0x5E8D110", VA = "0x185E8E910", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8743C0", Offset = "0x872BC0", VA = "0x1808743C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E9C0", Offset = "0x5E8D1C0", VA = "0x185E8E9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NDCNBNNMLGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ulong LBGHOJIANDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public long JGJPFLDNGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public double FPDPHEKKJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint OLOMLANDGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint IEFPOFKKLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int CMMLLODADBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int IHJGBCCEIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float IEDHFFLECGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public float NJOBFKPBHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public ushort FNECHDGGPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ushort LPCCNCIAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public ushort OJPEPAAFEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public ushort IDNCMHFIOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public short HECOOCOLBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public short ACHDFMJAMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public short FADAMMLDFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public short NFLHPBFNOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public char AAPNLKNIPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public char IPDHMNMBGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public char KGCBCKKPNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public char DMCOJFNMELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public byte JKGIGPGCJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte BEAACEHIDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte HJEKCEHGAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte AOCKKKGFEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte LLDCNIBDFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte OILBHCAGPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte MNIMPAGAMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte KEKKEEBBKCJ;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D670", Offset = "0x5E8BE70", VA = "0x185E8D670")]
	public static NDCNBNNMLGO AKKFLOCCMNP(byte DFIPKDKMOPO, byte MDLGNMBJKIN, byte GAIALIJFOOM, byte PHPDDPDGDPK, byte HIFNOPAGNBA, byte ILAJFOAIGNH, byte BPCJIGAJFBN, byte AMEDAFICGKI)
	{
		return default(NDCNBNNMLGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IKNMHIADFGG
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2355460", Offset = "0x2353C60", VA = "0x182355460")]
	public static IEnumerable<T> IBDMEHEBENM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static T[] CHEOBFGLFON<T>(params T[] GOFCGGGDPGH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static IEnumerable<T> MHLBJFGLFBE<T>(params T[] GOFCGGGDPGH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2509FE0", Offset = "0x25087E0", VA = "0x182509FE0")]
	public static HashSet<T> NDBJBLOMCJP<T>(params T[] GOFCGGGDPGH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2509EF0", Offset = "0x25086F0", VA = "0x182509EF0")]
	public static KeyValuePair<TKey, TValue> ACDMGIJLKED<TKey, TValue>([In] TKey EMBEECDJLJB, [In] TValue DOLICEBFIPF) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2509FE0", Offset = "0x25087E0", VA = "0x182509FE0")]
	public static List<T> FHNFIOJJKNN<T>(IEnumerable<T> BGOMBENDKBO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FEGJBKNDDLC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string CMHDJNNGFNP;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
	public FEGJBKNDDLC(string IDADLFNFKJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate object IGKKIBHLLKG<T>([In] T ILIHAHINKGC);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object FKLCKOMIMGD<T>(T ILIHAHINKGC);
[Cpp2IlInjected.Token(Token = "0x2000053")]
[FDGENGFEHCH]
public delegate string EMDDEHNMPKB(string OIHIJMCPAMD, string? PJCBEHMOMDC, bool EMAAIBCPDHA);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[FDGENGFEHCH]
public delegate void BLNHCICJOLM(string OLDFIJBKFKG);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[FDGENGFEHCH]
public delegate void GIDNBGGDBCK(Exception IOPFKNIOMEG);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object EOIEIGCJMNN();
[Cpp2IlInjected.Token(Token = "0x2000057")]
[FDGENGFEHCH]
public delegate bool EMJNCKMKBLF();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[FDGENGFEHCH]
public delegate string GNKOLDHMCIG(object BEKFGDCEJDH);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Enum)]
public class PINCCHMGKLK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	public PINCCHMGKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CFAKHBCIOKB
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class ACJJHLMKCDK<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly ISet<T> ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int CADPCMFLDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3545080", Offset = "0x3543880", VA = "0x183545080", Slot = "4")]
		public bool Add(T BPGGEPDHIDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
		public void IntersectWith(IEnumerable<T> FPJCFKAMJHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3545280", Offset = "0x3543A80", VA = "0x183545280", Slot = "5")]
		public void UnionWith(IEnumerable<T> FPJCFKAMJHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x35451C0", Offset = "0x35439C0", VA = "0x1835451C0", Slot = "9")]
		void ICollection<T>.Add(T BPGGEPDHIDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "11")]
		public bool Contains(T BPGGEPDHIDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "12")]
		public void CopyTo(T[] CMKNCDNHDNA, int FJLHDHNDEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
		public bool Remove(T BPGGEPDHIDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3545140", Offset = "0x3543940", VA = "0x183545140", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x34C34D0", Offset = "0x34C1CD0", VA = "0x1834C34D0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public ACJJHLMKCDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x810F50", Offset = "0x80F750", VA = "0x180810F50")]
	public static ISet<T> JNCCLKGBFIA<T>() where T : notnull
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
