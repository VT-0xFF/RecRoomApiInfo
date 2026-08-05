using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x649E0A0", Offset = "0x649D2A0", VA = "0x18649E0A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E26F0", Offset = "0x6E18F0", VA = "0x1806E26F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9116C0", Offset = "0x9108C0", VA = "0x1809116C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PCKPOJEMBKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IDisposable[] DPMGKNFABCM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89DDB0", Offset = "0x89CFB0", VA = "0x18089DDB0")]
	public PCKPOJEMBKG(params IDisposable[] BNOEJJNBJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xE26DD0", Offset = "0xE25FD0", VA = "0x180E26DD0")]
	public static PCKPOJEMBKG GDHAFJANMPF(params IDisposable[] BNOEJJNBJCK)
	{
		return default(PCKPOJEMBKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x649E1A0", Offset = "0x649D3A0", VA = "0x18649E1A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JFPHJIIBCAK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IDisposable PJJGDKDHCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public T ALAOEPGGPNI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x329B770", Offset = "0x329A970", VA = "0x18329B770")]
	public JFPHJIIBCAK(IDisposable JHMACGKJPAP, in T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8AB0", Offset = "0x1CE7CB0", VA = "0x181CE8AB0")]
	public static global::JFPHJIIBCAK<U> HDDIPFEAELK<U>(in global::JFPHJIIBCAK<T> JHMACGKJPAP, in U JFBPNBNBHOE)
	{
		return default(global::JFPHJIIBCAK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36428E0", Offset = "0x3641AE0", VA = "0x1836428E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DFHMDANFBOB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2575C70", Offset = "0x2574E70", VA = "0x182575C70")]
	public static global::JFPHJIIBCAK<T> GDHAFJANMPF<T>(IDisposable JHMACGKJPAP, in T JFBPNBNBHOE)
	{
		return default(global::JFPHJIIBCAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4BD10", Offset = "0x1D4AF10", VA = "0x181D4BD10")]
	public static global::JFPHJIIBCAK<U> HDDIPFEAELK<U, T>(in global::JFPHJIIBCAK<T> BCFLKBHJLFD, in U JFBPNBNBHOE)
	{
		return default(global::JFPHJIIBCAK<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CMPJECJJKJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00")]
	public static CMPJECJJKJC FFPKNNKHNKN(Type DDJDPMGLPAE, [Optional] string FHHMBAJMBIH, [Optional] string DJIMGACHHLG, bool PNODHGNMJBL = false)
	{
		return default(CMPJECJJKJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00")]
	public static CMPJECJJKJC FFPKNNKHNKN<T>([Optional] string FHHMBAJMBIH, [Optional] string DJIMGACHHLG, bool PNODHGNMJBL = false)
	{
		return default(CMPJECJJKJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class IOILPEPIEGB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static bool EHOPGJPMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly string IBOEFFPHFAI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual IOILPEPIEGB ONPFKPDECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x649E030", Offset = "0x649D230", VA = "0x18649E030")]
	protected IOILPEPIEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string PPGCJLLFOLE();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x649DD80", Offset = "0x649CF80", VA = "0x18649DD80", Slot = "6")]
	public virtual string NELKIPJBBJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x649DE00", Offset = "0x649D000", VA = "0x18649DE00")]
	public void NGEALHINPFL(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x649DA70", Offset = "0x649CC70", VA = "0x18649DA70")]
	public void GOOIEDBPEEF(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x649DC60", Offset = "0x649CE60", VA = "0x18649DC60")]
	public void MJCHEGJMKGM(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x649DB70", Offset = "0x649CD70", VA = "0x18649DB70")]
	public void LLECBHNMMKH(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x649DAD0", Offset = "0x649CCD0", VA = "0x18649DAD0")]
	public static void HMCDBJNILEN(StringBuilder LMKNLEBCBAL, string BNLEAMMLCPJ, string NOPFOHCDDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6CE670", Offset = "0x6CD870", VA = "0x1806CE670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OPGAMEABBMN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x649E130", Offset = "0x649D330", VA = "0x18649E130")]
	public OPGAMEABBMN(string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GHHDDFJMAAD<TErr> : OPGAMEABBMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly TErr MEEJNDBFMFK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35BE840", Offset = "0x35BDA40", VA = "0x1835BE840")]
	private GHHDDFJMAAD(in TErr NKHAALJNCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3485370", Offset = "0x3484570", VA = "0x183485370")]
	public static global::GHHDDFJMAAD<TErr> GDHAFJANMPF(in TErr NKHAALJNCAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DMKCIPNABEJ<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PFCPDGJJPGB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string OKHLHGFIMND
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DFOBPKBLAGL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x649D990", Offset = "0x649CB90", VA = "0x18649D990")]
	public DFOBPKBLAGL(string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BCGCKBGOGBM<TOk> : DFOBPKBLAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TOk JEHIBPNDJLP;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F9F0", Offset = "0x3E3EBF0", VA = "0x183E3F9F0")]
	private BCGCKBGOGBM(in TOk CKIGJNLHLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2350420", Offset = "0x234F620", VA = "0x182350420")]
	public static global::BCGCKBGOGBM<TOk> GDHAFJANMPF(in TOk CKIGJNLHLAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OHFECDBHLHC<TOk, TErr> : IEquatable<global::OHFECDBHLHC<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly EqualityComparer<TErr> LCAPGMCFAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly TErr MEEJNDBFMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TOk JEHIBPNDJLP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KHCLOHFPNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38237C0", Offset = "0x38229C0", VA = "0x1838237C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PAIEHONMGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38271A0", Offset = "0x38263A0", VA = "0x1838271A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38285D0", Offset = "0x38277D0", VA = "0x1838285D0")]
	internal OHFECDBHLHC(in TErr NKHAALJNCAG, in TOk CKIGJNLHLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3823610", Offset = "0x3822810", VA = "0x183823610")]
	public static global::OHFECDBHLHC<TOk, TErr> DILDMIHPMIB(in TErr NKHAALJNCAG)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3826470", Offset = "0x3825670", VA = "0x183826470")]
	public static global::OHFECDBHLHC<TOk, TErr> GNICBNEHKMH(in TOk CKIGJNLHLAD)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C82160", Offset = "0x3C81360", VA = "0x183C82160")]
	public global::OHFECDBHLHC<TOk, UErr> JOMFNDKJKHA<UErr>()
	{
		return default(global::OHFECDBHLHC<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C82BF0", Offset = "0x3C81DF0", VA = "0x183C82BF0")]
	public global::OHFECDBHLHC<UOk, TErr> PCGFEDOHIND<UOk>()
	{
		return default(global::OHFECDBHLHC<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C82010", Offset = "0x3C81210", VA = "0x183C82010")]
	public global::OHFECDBHLHC<UOk, TErr> CPGCOCDGBDO<UOk>()
	{
		return default(global::OHFECDBHLHC<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C828B0", Offset = "0x3C81AB0", VA = "0x183C828B0")]
	public global::OHFECDBHLHC<TOk, UErr> MMIAHNLOMDG<UErr>()
	{
		return default(global::OHFECDBHLHC<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3825150", Offset = "0x3824350", VA = "0x183825150")]
	public global::OHFECDBHLHC<CHLMDABNGKB, TErr> FAMJGELABOG()
	{
		return default(global::OHFECDBHLHC<CHLMDABNGKB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38255C0", Offset = "0x38247C0", VA = "0x1838255C0")]
	public static bool GJOJIEKGOHO(in global::OHFECDBHLHC<TOk, TErr> KOBPJIJCFOM, in global::OHFECDBHLHC<TOk, TErr> PLEGOCBOLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x38245A0", Offset = "0x38237A0", VA = "0x1838245A0", Slot = "4")]
	public bool Equals(global::OHFECDBHLHC<TOk, TErr> IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x38243B0", Offset = "0x38235B0", VA = "0x1838243B0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3826CA0", Offset = "0x3825EA0", VA = "0x183826CA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3827C80", Offset = "0x3826E80", VA = "0x183827C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FGBLHFLBMAP
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3680", Offset = "0x2EA2880", VA = "0x182EA3680")]
	public static global::OHFECDBHLHC<TOk, TErr> JEHIBPNDJLP<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, in TOk CKIGJNLHLAD)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2EA36F0", Offset = "0x2EA28F0", VA = "0x182EA36F0")]
	public static global::OHFECDBHLHC<CHLMDABNGKB, TErr> JEHIBPNDJLP<TErr>(this in global::OHFECDBHLHC<CHLMDABNGKB, TErr> PKCJMFFNILJ)
	{
		return default(global::OHFECDBHLHC<CHLMDABNGKB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2EA36B0", Offset = "0x2EA28B0", VA = "0x182EA36B0")]
	public static global::OHFECDBHLHC<TOk, TErr> MEEJNDBFMFK<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, in TErr NKHAALJNCAG)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2C70", Offset = "0x2EA1E70", VA = "0x182EA2C70")]
	public static TOk AFCJJJLPDCD<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3120", Offset = "0x2EA2320", VA = "0x182EA3120")]
	[AsyncStateMachine(typeof(NIJBIMLODDC))]
	public static Task<TOk> DLIIJHBOFKG<TOk, TErr>(this Task<global::OHFECDBHLHC<TOk, TErr>> PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2EA43B0", Offset = "0x2EA35B0", VA = "0x182EA43B0")]
	public static TErr MLMKFGIOHKH<TErr, TOk>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2EA38D0", Offset = "0x2EA2AD0", VA = "0x182EA38D0")]
	public static bool JJOOKEHPHCN<TOk, TErr, UErr, UOk>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out global::OHFECDBHLHC<UOk, UErr> CJBOAAFIEJK) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4310", Offset = "0x2EA3510", VA = "0x182EA4310")]
	public static bool LGJALPFMMLK<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4570", Offset = "0x2EA3770", VA = "0x182EA4570")]
	public static bool ODDHEJGGCNH<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TErr NKHAALJNCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2D20", Offset = "0x2EA1F20", VA = "0x182EA2D20")]
	public static bool BKOMNDOIEKE<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out TErr NKHAALJNCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4350", Offset = "0x2EA3550", VA = "0x182EA4350")]
	public static bool MIBIAOIBPIA<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out global::OHFECDBHLHC<TOk, TErr> CJBOAAFIEJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3D80", Offset = "0x2EA2F80", VA = "0x182EA3D80")]
	public static bool JJOOKEHPHCN<TOk, TErr, UErr, UOk>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out global::OHFECDBHLHC<UOk, UErr> CJBOAAFIEJK) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2E60", Offset = "0x2EA2060", VA = "0x182EA2E60")]
	public static bool CFDLJAOEHFF<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out global::OHFECDBHLHC<CHLMDABNGKB, TErr> CJBOAAFIEJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3380", Offset = "0x2EA2580", VA = "0x182EA3380")]
	public static global::OHFECDBHLHC<UOk, UErr> GKMFNFIMMGJ<UOk, UErr, TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, in global::OHFECDBHLHC<UOk, UErr> IGJFJCHKKMF) where TOk : UOk where TErr : UErr
	{
		return default(global::OHFECDBHLHC<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4020", Offset = "0x2EA3220", VA = "0x182EA4020")]
	public static global::OHFECDBHLHC<TOk[], TErr> KBPKHLEHGCA<TOk, TErr>(this IEnumerable<global::OHFECDBHLHC<TOk, TErr>> PKCJMFFNILJ)
	{
		return default(global::OHFECDBHLHC<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AD30", Offset = "0x1F99F30", VA = "0x181F9AD30")]
	[IteratorStateMachine(typeof(JJOGNJNJGKI))]
	public static IEnumerable<TOk> PJMCHCIDBKH<TOk, TErr>(this IEnumerable<global::OHFECDBHLHC<TOk, TErr>> PKCJMFFNILJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CIOFAIGADMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0790", Offset = "0x1CDF990", VA = "0x181CE0790")]
	public static global::OHFECDBHLHC<TOk, T> JEHIBPNDJLP<TOk>(in TOk CKIGJNLHLAD)
	{
		return default(global::OHFECDBHLHC<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE6B0", Offset = "0x2AFD8B0", VA = "0x182AFE6B0")]
	public static global::OHFECDBHLHC<CHLMDABNGKB, T> JEHIBPNDJLP()
	{
		return default(global::OHFECDBHLHC<CHLMDABNGKB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0850", Offset = "0x1CDFA50", VA = "0x181CE0850")]
	public static global::OHFECDBHLHC<T, TErr> MEEJNDBFMFK<TErr>(in TErr NKHAALJNCAG)
	{
		return default(global::OHFECDBHLHC<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class LJBFMKCOIOF<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct COFPFJODAKC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly global::LJBFMKCOIOF<T> BFDFMDLBADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int BGAPHKDHOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool JMNFLOLHJHL;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2F16870", Offset = "0x2F15A70", VA = "0x182F16870")]
		public COFPFJODAKC(global::LJBFMKCOIOF<T> ONJEPBGIHBB, int AOHBMEFFHBP, bool EFAEFNCLJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2F16740", Offset = "0x2F15940", VA = "0x182F16740")]
		public global::LJBFMKCOIOF<T>.MGHPCKACFDO AHIPNMLLDNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2F16830", Offset = "0x2F15A30", VA = "0x182F16830", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2F16830", Offset = "0x2F15A30", VA = "0x182F16830", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class MGHPCKACFDO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly global::LJBFMKCOIOF<T> BFDFMDLBADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly int GGOACGKMPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int EAMIAOHACGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly bool JMNFLOLHJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool NBIOPFJPPJK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2E5CAD0", Offset = "0x2E5BCD0", VA = "0x182E5CAD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2E5CCC0", Offset = "0x2E5BEC0", VA = "0x182E5CCC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2E5CDC0", Offset = "0x2E5BFC0", VA = "0x182E5CDC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2E5D310", Offset = "0x2E5C510", VA = "0x182E5D310")]
		public MGHPCKACFDO(global::LJBFMKCOIOF<T> ONJEPBGIHBB, int AOHBMEFFHBP, bool EFAEFNCLJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2E5CB70", Offset = "0x2E5BD70", VA = "0x182E5CB70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2E5CBF0", Offset = "0x2E5BDF0", VA = "0x182E5CBF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NJOCLHLIBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687430", Offset = "0x686830")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public NJOCLHLIBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B71910", Offset = "0x2B70B10", VA = "0x182B71910")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly T[] PCAGFEJIENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int EAMIAOHACGN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JFOEPHAPCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x37E7760", Offset = "0x37E6960", VA = "0x1837E7760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T CDKNNCCNMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x254C900", Offset = "0x254BB00", VA = "0x18254C900")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T IAKIEBOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x37E7580", Offset = "0x37E6780", VA = "0x1837E7580")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37E76D0", Offset = "0x37E68D0", VA = "0x1837E76D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37E74B0", Offset = "0x37E66B0", VA = "0x1837E74B0")]
	private static int BNBABBHNIFD(int BELCAJFDAHD, int ONCBCCLEFOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x37E77A0", Offset = "0x37E69A0", VA = "0x1837E77A0")]
	public LJBFMKCOIOF(int PCAHMJECHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37E7820", Offset = "0x37E6A20", VA = "0x1837E7820")]
	public LJBFMKCOIOF(int PCAHMJECHKC, Func<T> OBGDBDDJHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37E7C40", Offset = "0x37E6E40", VA = "0x1837E7C40")]
	public LJBFMKCOIOF(T[] BNOEJJNBJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37E7730", Offset = "0x37E6930", VA = "0x1837E7730")]
	public void LENPLAAMIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x37E74D0", Offset = "0x37E66D0", VA = "0x1837E74D0")]
	public IEnumerable<T> ECNEGNJKBNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x37E7430", Offset = "0x37E6630", VA = "0x1837E7430")]
	public global::LJBFMKCOIOF<T>.MGHPCKACFDO AHIPNMLLDNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE19C0", Offset = "0x1CE0BC0", VA = "0x181CE19C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE19C0", Offset = "0x1CE0BC0", VA = "0x181CE19C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AIHHPKINNAE
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26A0830", Offset = "0x269FA30", VA = "0x1826A0830")]
	public static global::LJBFMKCOIOF<T> GDHAFJANMPF<T>(int PCAHMJECHKC, Func<T> OBGDBDDJHHM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class HDGJEBHOGDC<TData> : IOILPEPIEGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly string MALDNEKGAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly TData AHMFAEOKPKE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
	public override string PPGCJLLFOLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3C024D0", Offset = "0x3C016D0", VA = "0x183C024D0")]
	internal HDGJEBHOGDC(string DENPJAMCNLD, in TData ONIBEFDCPGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FLJPLDAMBHP
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x649DA00", Offset = "0x649CC00", VA = "0x18649DA00")]
	public static global::HDGJEBHOGDC<CHLMDABNGKB> GDHAFJANMPF(string DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D694F0", Offset = "0x1D686F0", VA = "0x181D694F0")]
	public static global::HDGJEBHOGDC<TData> GDHAFJANMPF<TData>(string DENPJAMCNLD, in TData ONIBEFDCPGD)
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
