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
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A3090", Offset = "0x64A2490", VA = "0x1864A3090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72ABD0", Offset = "0x729FD0", VA = "0x18072ABD0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC60960", Offset = "0xC5FD60", VA = "0x180C60960")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LKGFDAABANC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OJDDDCCFPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string MFOGJDOCIGK(string BLLLMFLEANI);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BNCJEJEKKDP(string HKGFIHMBIEF);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CEGKELFPDAM(Exception AKCADADCFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static OJDDDCCFPII HNEIEBONIJN;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PCKPOJEMBKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDisposable[] DPMGKNFABCM;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F00", Offset = "0x6E1300", VA = "0x1806E1F00")]
	public PCKPOJEMBKG(params IDisposable[] BNOEJJNBJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x729B40", Offset = "0x728F40", VA = "0x180729B40")]
	public static PCKPOJEMBKG GDHAFJANMPF(params IDisposable[] BNOEJJNBJCK)
	{
		return default(PCKPOJEMBKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64A3190", Offset = "0x64A2590", VA = "0x1864A3190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JFPHJIIBCAK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IDisposable PJJGDKDHCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public T ALAOEPGGPNI;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x339AE20", Offset = "0x339A220", VA = "0x18339AE20")]
	public JFPHJIIBCAK(IDisposable JHMACGKJPAP, in T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x271FD00", Offset = "0x271F100", VA = "0x18271FD00")]
	public static global::JFPHJIIBCAK<U> HDDIPFEAELK<U>(in global::JFPHJIIBCAK<T> JHMACGKJPAP, in U JFBPNBNBHOE)
	{
		return default(global::JFPHJIIBCAK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB320", Offset = "0x3ABA720", VA = "0x183ABB320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DFHMDANFBOB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2C45680", Offset = "0x2C44A80", VA = "0x182C45680")]
	public static global::JFPHJIIBCAK<T> GDHAFJANMPF<T>(IDisposable JHMACGKJPAP, in T JFBPNBNBHOE)
	{
		return default(global::JFPHJIIBCAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2C44EE0", Offset = "0x2C442E0", VA = "0x182C44EE0")]
	public static global::JFPHJIIBCAK<U> HDDIPFEAELK<U, T>(in global::JFPHJIIBCAK<T> BCFLKBHJLFD, in U JFBPNBNBHOE)
	{
		return default(global::JFPHJIIBCAK<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct CMPJECJJKJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
	public static CMPJECJJKJC FFPKNNKHNKN(Type DDJDPMGLPAE, [Optional] string FHHMBAJMBIH, [Optional] string DJIMGACHHLG, bool PNODHGNMJBL = false)
	{
		return default(CMPJECJJKJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
	public static CMPJECJJKJC FFPKNNKHNKN<T>([Optional] string FHHMBAJMBIH, [Optional] string DJIMGACHHLG, bool PNODHGNMJBL = false)
	{
		return default(CMPJECJJKJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class IOILPEPIEGB
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static bool EHOPGJPMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly string IBOEFFPHFAI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual IOILPEPIEGB ONPFKPDECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64A3020", Offset = "0x64A2420", VA = "0x1864A3020")]
	protected IOILPEPIEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string PPGCJLLFOLE();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64A2D20", Offset = "0x64A2120", VA = "0x1864A2D20", Slot = "6")]
	public virtual string NELKIPJBBJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64A2DA0", Offset = "0x64A21A0", VA = "0x1864A2DA0")]
	public void NGEALHINPFL(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64A29C0", Offset = "0x64A1DC0", VA = "0x1864A29C0")]
	public void GOOIEDBPEEF(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64A2BB0", Offset = "0x64A1FB0", VA = "0x1864A2BB0")]
	public void MJCHEGJMKGM(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64A2AC0", Offset = "0x64A1EC0", VA = "0x1864A2AC0")]
	public void LLECBHNMMKH(StringBuilder LMKNLEBCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64A2A20", Offset = "0x64A1E20", VA = "0x1864A2A20")]
	public static void HMCDBJNILEN(StringBuilder LMKNLEBCBAL, string BNLEAMMLCPJ, string NOPFOHCDDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x786A30", Offset = "0x785E30", VA = "0x180786A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OPGAMEABBMN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64A3120", Offset = "0x64A2520", VA = "0x1864A3120")]
	public OPGAMEABBMN(string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GHHDDFJMAAD<TErr> : OPGAMEABBMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TErr MEEJNDBFMFK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D79450", Offset = "0x3D78850", VA = "0x183D79450")]
	private GHHDDFJMAAD(in TErr NKHAALJNCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D79380", Offset = "0x3D78780", VA = "0x183D79380")]
	public static global::GHHDDFJMAAD<TErr> GDHAFJANMPF(in TErr NKHAALJNCAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DMKCIPNABEJ<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PFCPDGJJPGB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string OKHLHGFIMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DFOBPKBLAGL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x64A28E0", Offset = "0x64A1CE0", VA = "0x1864A28E0")]
	public DFOBPKBLAGL(string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BCGCKBGOGBM<TOk> : DFOBPKBLAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TOk JEHIBPNDJLP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29B3B80", Offset = "0x29B2F80", VA = "0x1829B3B80")]
	private BCGCKBGOGBM(in TOk CKIGJNLHLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29B39D0", Offset = "0x29B2DD0", VA = "0x1829B39D0")]
	public static global::BCGCKBGOGBM<TOk> GDHAFJANMPF(in TOk CKIGJNLHLAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OHFECDBHLHC<TOk, TErr> : IEquatable<global::OHFECDBHLHC<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly EqualityComparer<TErr> LCAPGMCFAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TErr MEEJNDBFMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly TOk JEHIBPNDJLP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KHCLOHFPNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x416AA10", Offset = "0x4169E10", VA = "0x18416AA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PAIEHONMGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x416E3F0", Offset = "0x416D7F0", VA = "0x18416E3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x416F820", Offset = "0x416EC20", VA = "0x18416F820")]
	internal OHFECDBHLHC(in TErr NKHAALJNCAG, in TOk CKIGJNLHLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x416A860", Offset = "0x4169C60", VA = "0x18416A860")]
	public static global::OHFECDBHLHC<TOk, TErr> DILDMIHPMIB(in TErr NKHAALJNCAG)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x416D6C0", Offset = "0x416CAC0", VA = "0x18416D6C0")]
	public static global::OHFECDBHLHC<TOk, TErr> GNICBNEHKMH(in TOk CKIGJNLHLAD)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42D1690", Offset = "0x42D0A90", VA = "0x1842D1690")]
	public global::OHFECDBHLHC<TOk, UErr> JOMFNDKJKHA<UErr>()
	{
		return default(global::OHFECDBHLHC<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42D2120", Offset = "0x42D1520", VA = "0x1842D2120")]
	public global::OHFECDBHLHC<UOk, TErr> PCGFEDOHIND<UOk>()
	{
		return default(global::OHFECDBHLHC<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42D1540", Offset = "0x42D0940", VA = "0x1842D1540")]
	public global::OHFECDBHLHC<UOk, TErr> CPGCOCDGBDO<UOk>()
	{
		return default(global::OHFECDBHLHC<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42D1DE0", Offset = "0x42D11E0", VA = "0x1842D1DE0")]
	public global::OHFECDBHLHC<TOk, UErr> MMIAHNLOMDG<UErr>()
	{
		return default(global::OHFECDBHLHC<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x416C3A0", Offset = "0x416B7A0", VA = "0x18416C3A0")]
	public global::OHFECDBHLHC<CHLMDABNGKB, TErr> FAMJGELABOG()
	{
		return default(global::OHFECDBHLHC<CHLMDABNGKB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x416C810", Offset = "0x416BC10", VA = "0x18416C810")]
	public static bool GJOJIEKGOHO(in global::OHFECDBHLHC<TOk, TErr> KOBPJIJCFOM, in global::OHFECDBHLHC<TOk, TErr> PLEGOCBOLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x416B7F0", Offset = "0x416ABF0", VA = "0x18416B7F0", Slot = "4")]
	public bool Equals(global::OHFECDBHLHC<TOk, TErr> IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x416B600", Offset = "0x416AA00", VA = "0x18416B600", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x416DEF0", Offset = "0x416D2F0", VA = "0x18416DEF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x416EED0", Offset = "0x416E2D0", VA = "0x18416EED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FGBLHFLBMAP
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3768680", Offset = "0x3767A80", VA = "0x183768680")]
	public static global::OHFECDBHLHC<TOk, TErr> JEHIBPNDJLP<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, in TOk CKIGJNLHLAD)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37686F0", Offset = "0x3767AF0", VA = "0x1837686F0")]
	public static global::OHFECDBHLHC<CHLMDABNGKB, TErr> JEHIBPNDJLP<TErr>(this in global::OHFECDBHLHC<CHLMDABNGKB, TErr> PKCJMFFNILJ)
	{
		return default(global::OHFECDBHLHC<CHLMDABNGKB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37686B0", Offset = "0x3767AB0", VA = "0x1837686B0")]
	public static global::OHFECDBHLHC<TOk, TErr> MEEJNDBFMFK<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, in TErr NKHAALJNCAG)
	{
		return default(global::OHFECDBHLHC<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3767C70", Offset = "0x3767070", VA = "0x183767C70")]
	public static TOk AFCJJJLPDCD<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3768120", Offset = "0x3767520", VA = "0x183768120")]
	[AsyncStateMachine(typeof(NIJBIMLODDC))]
	public static Task<TOk> DLIIJHBOFKG<TOk, TErr>(this Task<global::OHFECDBHLHC<TOk, TErr>> PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x37693B0", Offset = "0x37687B0", VA = "0x1837693B0")]
	public static TErr MLMKFGIOHKH<TErr, TOk>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37688D0", Offset = "0x3767CD0", VA = "0x1837688D0")]
	public static bool JJOOKEHPHCN<TOk, TErr, UErr, UOk>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out global::OHFECDBHLHC<UOk, UErr> CJBOAAFIEJK) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3769310", Offset = "0x3768710", VA = "0x183769310")]
	public static bool LGJALPFMMLK<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3769570", Offset = "0x3768970", VA = "0x183769570")]
	public static bool ODDHEJGGCNH<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TErr NKHAALJNCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3767D20", Offset = "0x3767120", VA = "0x183767D20")]
	public static bool BKOMNDOIEKE<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out TErr NKHAALJNCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3769350", Offset = "0x3768750", VA = "0x183769350")]
	public static bool MIBIAOIBPIA<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out global::OHFECDBHLHC<TOk, TErr> CJBOAAFIEJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3768D80", Offset = "0x3768180", VA = "0x183768D80")]
	public static bool JJOOKEHPHCN<TOk, TErr, UErr, UOk>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out global::OHFECDBHLHC<UOk, UErr> CJBOAAFIEJK) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3767E60", Offset = "0x3767260", VA = "0x183767E60")]
	public static bool CFDLJAOEHFF<TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, out TOk CKIGJNLHLAD, out global::OHFECDBHLHC<CHLMDABNGKB, TErr> CJBOAAFIEJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3768380", Offset = "0x3767780", VA = "0x183768380")]
	public static global::OHFECDBHLHC<UOk, UErr> GKMFNFIMMGJ<UOk, UErr, TOk, TErr>(this in global::OHFECDBHLHC<TOk, TErr> PKCJMFFNILJ, in global::OHFECDBHLHC<UOk, UErr> IGJFJCHKKMF) where TOk : UOk where TErr : UErr
	{
		return default(global::OHFECDBHLHC<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3769020", Offset = "0x3768420", VA = "0x183769020")]
	public static global::OHFECDBHLHC<TOk[], TErr> KBPKHLEHGCA<TOk, TErr>(this IEnumerable<global::OHFECDBHLHC<TOk, TErr>> PKCJMFFNILJ)
	{
		return default(global::OHFECDBHLHC<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x27C76B0", Offset = "0x27C6AB0", VA = "0x1827C76B0")]
	[IteratorStateMachine(typeof(JJOGNJNJGKI))]
	public static IEnumerable<TOk> PJMCHCIDBKH<TOk, TErr>(this IEnumerable<global::OHFECDBHLHC<TOk, TErr>> PKCJMFFNILJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CIOFAIGADMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2717BD0", Offset = "0x2716FD0", VA = "0x182717BD0")]
	public static global::OHFECDBHLHC<TOk, T> JEHIBPNDJLP<TOk>(in TOk CKIGJNLHLAD)
	{
		return default(global::OHFECDBHLHC<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x337E040", Offset = "0x337D440", VA = "0x18337E040")]
	public static global::OHFECDBHLHC<CHLMDABNGKB, T> JEHIBPNDJLP()
	{
		return default(global::OHFECDBHLHC<CHLMDABNGKB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2717C90", Offset = "0x2717090", VA = "0x182717C90")]
	public static global::OHFECDBHLHC<T, TErr> MEEJNDBFMFK<TErr>(in TErr NKHAALJNCAG)
	{
		return default(global::OHFECDBHLHC<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public sealed class LJBFMKCOIOF<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private readonly struct COFPFJODAKC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly global::LJBFMKCOIOF<T> BFDFMDLBADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int BGAPHKDHOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly bool JMNFLOLHJHL;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1245C80", Offset = "0x1245080", VA = "0x181245C80")]
		public COFPFJODAKC(global::LJBFMKCOIOF<T> ONJEPBGIHBB, int AOHBMEFFHBP, bool EFAEFNCLJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x39F6EC0", Offset = "0x39F62C0", VA = "0x1839F6EC0")]
		public global::LJBFMKCOIOF<T>.MGHPCKACFDO AHIPNMLLDNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x39F6FB0", Offset = "0x39F63B0", VA = "0x1839F6FB0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x39F6FB0", Offset = "0x39F63B0", VA = "0x1839F6FB0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class MGHPCKACFDO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly global::LJBFMKCOIOF<T> BFDFMDLBADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int GGOACGKMPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int EAMIAOHACGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly bool JMNFLOLHJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool NBIOPFJPPJK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3A95BE0", Offset = "0x3A94FE0", VA = "0x183A95BE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3A95DD0", Offset = "0x3A951D0", VA = "0x183A95DD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3A95ED0", Offset = "0x3A952D0", VA = "0x183A95ED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3A96420", Offset = "0x3A95820", VA = "0x183A96420")]
		public MGHPCKACFDO(global::LJBFMKCOIOF<T> ONJEPBGIHBB, int AOHBMEFFHBP, bool EFAEFNCLJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3A95C80", Offset = "0x3A95080", VA = "0x183A95C80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3A95D00", Offset = "0x3A95100", VA = "0x183A95D00", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NJOCLHLIBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6864A0", Offset = "0x6858A0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public NJOCLHLIBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3564910", Offset = "0x3563D10", VA = "0x183564910")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly T[] PCAGFEJIENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int EAMIAOHACGN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JFOEPHAPCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1E80", Offset = "0x3BF1280", VA = "0x183BF1E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T CDKNNCCNMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2DC99B0", Offset = "0x2DC8DB0", VA = "0x182DC99B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T IAKIEBOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1D00", Offset = "0x3BF1100", VA = "0x183BF1D00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x46A31B0", Offset = "0x46A25B0", VA = "0x1846A31B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8C1DE0", Offset = "0x8C11E0", VA = "0x1808C1DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1C30", Offset = "0x3BF1030", VA = "0x183BF1C30")]
	private static int BNBABBHNIFD(int BELCAJFDAHD, int ONCBCCLEFOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1EC0", Offset = "0x3BF12C0", VA = "0x183BF1EC0")]
	public LJBFMKCOIOF(int PCAHMJECHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF20F0", Offset = "0x3BF14F0", VA = "0x183BF20F0")]
	public LJBFMKCOIOF(int PCAHMJECHKC, Func<T> OBGDBDDJHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x46A3210", Offset = "0x46A2610", VA = "0x1846A3210")]
	public LJBFMKCOIOF(T[] BNOEJJNBJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1E50", Offset = "0x3BF1250", VA = "0x183BF1E50")]
	public void LENPLAAMIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1C50", Offset = "0x3BF1050", VA = "0x183BF1C50")]
	public IEnumerable<T> ECNEGNJKBNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1BB0", Offset = "0x3BF0FB0", VA = "0x183BF1BB0")]
	public global::LJBFMKCOIOF<T>.MGHPCKACFDO AHIPNMLLDNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2718E00", Offset = "0x2718200", VA = "0x182718E00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2718E00", Offset = "0x2718200", VA = "0x182718E00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class AIHHPKINNAE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2141C20", Offset = "0x2141020", VA = "0x182141C20")]
	public static global::LJBFMKCOIOF<T> GDHAFJANMPF<T>(int PCAHMJECHKC, Func<T> OBGDBDDJHHM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class HDGJEBHOGDC<TData> : IOILPEPIEGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly string MALDNEKGAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly TData AHMFAEOKPKE;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
	public override string PPGCJLLFOLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x43932A0", Offset = "0x43926A0", VA = "0x1843932A0")]
	internal HDGJEBHOGDC(string DENPJAMCNLD, in TData ONIBEFDCPGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FLJPLDAMBHP
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64A2950", Offset = "0x64A1D50", VA = "0x1864A2950")]
	public static global::HDGJEBHOGDC<CHLMDABNGKB> GDHAFJANMPF(string DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2878660", Offset = "0x2877A60", VA = "0x182878660")]
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
