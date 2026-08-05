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
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F6160", Offset = "0x64F5560", VA = "0x1864F6160")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x778380", Offset = "0x777780", VA = "0x180778380")]
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
		[Cpp2IlInjected.Address(RVA = "0xFCBE90", Offset = "0xFCB290", VA = "0x180FCBE90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JCACBBDBPOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IDisposable[] MOPHOFACFDB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7809C0", Offset = "0x77FDC0", VA = "0x1807809C0")]
	public JCACBBDBPOK(params IDisposable[] DGHKCMOGJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F2120", Offset = "0x7F1520", VA = "0x1807F2120")]
	public static JCACBBDBPOK GEGCLDEHDAN(params IDisposable[] DGHKCMOGJPO)
	{
		return default(JCACBBDBPOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64F5FD0", Offset = "0x64F53D0", VA = "0x1864F5FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IFKOLDEBLED<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IDisposable IFIHLEAFHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public T EJBPMDLBLGL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27F07E0", Offset = "0x27EFBE0", VA = "0x1827F07E0")]
	public IFKOLDEBLED(IDisposable CLPCALJPBGC, in T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x30FA6B0", Offset = "0x30F9AB0", VA = "0x1830FA6B0")]
	public static global::IFKOLDEBLED<U> JMOMIEPMPDA<U>(in global::IFKOLDEBLED<T> CLPCALJPBGC, in U FPLJCBGEJAP)
	{
		return default(global::IFKOLDEBLED<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27F0700", Offset = "0x27EFB00", VA = "0x1827F0700", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DBPLFOCOEOC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x33E5360", Offset = "0x33E4760", VA = "0x1833E5360")]
	public static global::IFKOLDEBLED<T> GEGCLDEHDAN<T>(IDisposable CLPCALJPBGC, in T FPLJCBGEJAP)
	{
		return default(global::IFKOLDEBLED<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3211D50", Offset = "0x3211150", VA = "0x183211D50")]
	public static global::IFKOLDEBLED<U> JMOMIEPMPDA<U, T>(in global::IFKOLDEBLED<T> GJIGDINONLL, in U FPLJCBGEJAP)
	{
		return default(global::IFKOLDEBLED<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GFDINLNPOKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0")]
	public static GFDINLNPOKK JNKDJNOGMIC(Type BKGBGEHNCAE, [Optional] string MCPCDIDKINB, [Optional] string MKKJANPAIIO, bool MECGACHAIEL = false)
	{
		return default(GFDINLNPOKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0")]
	public static GFDINLNPOKK JNKDJNOGMIC<T>([Optional] string MCPCDIDKINB, [Optional] string MKKJANPAIIO, bool MECGACHAIEL = false)
	{
		return default(GFDINLNPOKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class GKAEBCMEFAL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static bool CJFOKDLLNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly string CCLEIDELICL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual GKAEBCMEFAL EOABHIGPCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64F5F60", Offset = "0x64F5360", VA = "0x1864F5F60")]
	protected GKAEBCMEFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string HPLBNLEOGCE();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64F5EE0", Offset = "0x64F52E0", VA = "0x1864F5EE0", Slot = "6")]
	public virtual string MGKEENFBBMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64F5C10", Offset = "0x64F5010", VA = "0x1864F5C10")]
	public void JPCMPMELPKA(StringBuilder LKPFCMFGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64F5BB0", Offset = "0x64F4FB0", VA = "0x1864F5BB0")]
	public void FJKLNMPBJCE(StringBuilder LKPFCMFGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64F5A90", Offset = "0x64F4E90", VA = "0x1864F5A90")]
	public void BLAKPNNPAHE(StringBuilder LKPFCMFGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64F59A0", Offset = "0x64F4DA0", VA = "0x1864F59A0")]
	public void ADFBAHAIDBH(StringBuilder LKPFCMFGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64F5E40", Offset = "0x64F5240", VA = "0x1864F5E40")]
	public static void KCBLGFFLHGI(StringBuilder LKPFCMFGBCE, string MMPAOKKMEFN, string DNKGOHPBNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x884980", Offset = "0x883D80", VA = "0x180884980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CJDANHHKFNM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64F5930", Offset = "0x64F4D30", VA = "0x1864F5930")]
	public CJDANHHKFNM(string CIBBLLOHCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IOKOCOJPEDJ<TErr> : CJDANHHKFNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly TErr HDDNGLPFNJB;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33C8480", Offset = "0x33C7880", VA = "0x1833C8480")]
	private IOKOCOJPEDJ(in TErr MLKJHAPKMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33C83B0", Offset = "0x33C77B0", VA = "0x1833C83B0")]
	public static global::IOKOCOJPEDJ<TErr> GEGCLDEHDAN(in TErr MLKJHAPKMEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MCFNBCNAAKK<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JABJKIPBFFG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string KEBFPFFHCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PNLPMONAGLJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x64F61F0", Offset = "0x64F55F0", VA = "0x1864F61F0")]
	public PNLPMONAGLJ(string CIBBLLOHCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PGAPEILGMIG<TOk> : PNLPMONAGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TOk FHHDFIJMIBO;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43452D0", Offset = "0x43446D0", VA = "0x1843452D0")]
	private PGAPEILGMIG(in TOk LBFNPPDMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x31D0230", Offset = "0x31CF630", VA = "0x1831D0230")]
	public static global::PGAPEILGMIG<TOk> GEGCLDEHDAN(in TOk LBFNPPDMBOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct DPAEKNFIIFN<TOk, TErr> : IEquatable<global::DPAEKNFIIFN<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly EqualityComparer<TErr> IBEKDDIGHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly TErr HDDNGLPFNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TOk FHHDFIJMIBO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FEAPGACPOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x47A32E0", Offset = "0x47A26E0", VA = "0x1847A32E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KNHPPAGLAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x47A4940", Offset = "0x47A3D40", VA = "0x1847A4940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x47A5E80", Offset = "0x47A5280", VA = "0x1847A5E80")]
	internal DPAEKNFIIFN(in TErr MLKJHAPKMEE, in TOk LBFNPPDMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x47A10F0", Offset = "0x47A04F0", VA = "0x1847A10F0")]
	public static global::DPAEKNFIIFN<TOk, TErr> ANCOBDCDIPN(in TErr MLKJHAPKMEE)
	{
		return default(global::DPAEKNFIIFN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x47A0C60", Offset = "0x47A0060", VA = "0x1847A0C60")]
	public static global::DPAEKNFIIFN<TOk, TErr> ADODDJEJFCH(in TOk LBFNPPDMBOE)
	{
		return default(global::DPAEKNFIIFN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x345C720", Offset = "0x345BB20", VA = "0x18345C720")]
	public global::DPAEKNFIIFN<TOk, UErr> BGKLMAKDBIL<UErr>()
	{
		return default(global::DPAEKNFIIFN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x345D5A0", Offset = "0x345C9A0", VA = "0x18345D5A0")]
	public global::DPAEKNFIIFN<UOk, TErr> KGKEEKKMINJ<UOk>()
	{
		return default(global::DPAEKNFIIFN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x345D1E0", Offset = "0x345C5E0", VA = "0x18345D1E0")]
	public global::DPAEKNFIIFN<UOk, TErr> GDPKCNLHFHF<UOk>()
	{
		return default(global::DPAEKNFIIFN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x345CDA0", Offset = "0x345C1A0", VA = "0x18345CDA0")]
	public global::DPAEKNFIIFN<TOk, UErr> DHNPJCAGKIC<UErr>()
	{
		return default(global::DPAEKNFIIFN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47A1520", Offset = "0x47A0920", VA = "0x1847A1520")]
	public global::DPAEKNFIIFN<HOGMLAALAEJ, TErr> BEJCIGGOOKK()
	{
		return default(global::DPAEKNFIIFN<HOGMLAALAEJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x47A3CB0", Offset = "0x47A30B0", VA = "0x1847A3CB0")]
	public static bool OACFLELFBPC(in global::DPAEKNFIIFN<TOk, TErr> COMOCJDHDGL, in global::DPAEKNFIIFN<TOk, TErr> APKFNCAIFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x47A1840", Offset = "0x47A0C40", VA = "0x1847A1840", Slot = "4")]
	public bool Equals(global::DPAEKNFIIFN<TOk, TErr> FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x47A1CB0", Offset = "0x47A10B0", VA = "0x1847A1CB0", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47A2F30", Offset = "0x47A2330", VA = "0x1847A2F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47A4CE0", Offset = "0x47A40E0", VA = "0x1847A4CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HFAELEHPFBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD9C0", Offset = "0x2DCCDC0", VA = "0x182DCD9C0")]
	public static global::DPAEKNFIIFN<TOk, TErr> FHHDFIJMIBO<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, in TOk LBFNPPDMBOE)
	{
		return default(global::DPAEKNFIIFN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDA30", Offset = "0x2DCCE30", VA = "0x182DCDA30")]
	public static global::DPAEKNFIIFN<HOGMLAALAEJ, TErr> FHHDFIJMIBO<TErr>(this in global::DPAEKNFIIFN<HOGMLAALAEJ, TErr> COBPFFJEBON)
	{
		return default(global::DPAEKNFIIFN<HOGMLAALAEJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD9C0", Offset = "0x2DCCDC0", VA = "0x182DCD9C0")]
	public static global::DPAEKNFIIFN<TOk, TErr> HDDNGLPFNJB<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, in TErr MLKJHAPKMEE)
	{
		return default(global::DPAEKNFIIFN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE920", Offset = "0x2DCDD20", VA = "0x182DCE920")]
	public static TOk KGBCOPLBNGF<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE3C0", Offset = "0x2DCD7C0", VA = "0x182DCE3C0")]
	[AsyncStateMachine(typeof(NPAKLCAPCEA))]
	public static Task<TOk> HPIMNPGHNCC<TOk, TErr>(this Task<global::DPAEKNFIIFN<TOk, TErr>> COBPFFJEBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD800", Offset = "0x2DCCC00", VA = "0x182DCD800")]
	public static TErr CNILACDIKPO<TErr, TOk>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDAF0", Offset = "0x2DCCEF0", VA = "0x182DCDAF0")]
	public static bool GAJGINBNHFH<TOk, TErr, UErr, UOk>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, out global::DPAEKNFIIFN<UOk, UErr> BJKOKNLOKAJ) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEE60", Offset = "0x2DCE260", VA = "0x182DCEE60")]
	public static bool MCJCHIMGKDE<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, out TOk LBFNPPDMBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD780", Offset = "0x2DCCB80", VA = "0x182DCD780")]
	public static bool BKJJPCNAJMN<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, out TErr MLKJHAPKMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEEE0", Offset = "0x2DCE2E0", VA = "0x182DCEEE0")]
	public static bool OMCIEEEKHJH<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, out TOk LBFNPPDMBOE, out TErr MLKJHAPKMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE360", Offset = "0x2DCD760", VA = "0x182DCE360")]
	public static bool GBBPGBFCGBJ<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, out TOk LBFNPPDMBOE, out global::DPAEKNFIIFN<TOk, TErr> BJKOKNLOKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE0C0", Offset = "0x2DCD4C0", VA = "0x182DCE0C0")]
	public static bool GAJGINBNHFH<TOk, TErr, UErr, UOk>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, out TOk LBFNPPDMBOE, out global::DPAEKNFIIFN<UOk, UErr> BJKOKNLOKAJ) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEB60", Offset = "0x2DCDF60", VA = "0x182DCEB60")]
	public static bool LCKGLOOFJGH<TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, out TOk LBFNPPDMBOE, out global::DPAEKNFIIFN<HOGMLAALAEJ, TErr> BJKOKNLOKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE620", Offset = "0x2DCDA20", VA = "0x182DCE620")]
	public static global::DPAEKNFIIFN<UOk, UErr> IAEKJBJABHM<UOk, UErr, TOk, TErr>(this in global::DPAEKNFIIFN<TOk, TErr> COBPFFJEBON, in global::DPAEKNFIIFN<UOk, UErr> FKBMHFEKLIC) where TOk : UOk where TErr : UErr
	{
		return default(global::DPAEKNFIIFN<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD4D0", Offset = "0x2DCC8D0", VA = "0x182DCD4D0")]
	public static global::DPAEKNFIIFN<TOk[], TErr> BEAHJBMGJHB<TOk, TErr>(this IEnumerable<global::DPAEKNFIIFN<TOk, TErr>> COBPFFJEBON)
	{
		return default(global::DPAEKNFIIFN<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1AB0", Offset = "0x2CF0EB0", VA = "0x182CF1AB0")]
	[IteratorStateMachine(typeof(OJGEIHAFBJK))]
	public static IEnumerable<TOk> KIJENEBPOLD<TOk, TErr>(this IEnumerable<global::DPAEKNFIIFN<TOk, TErr>> COBPFFJEBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AKBNHLNGDAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x32F6E50", Offset = "0x32F6250", VA = "0x1832F6E50")]
	public static global::DPAEKNFIIFN<TOk, T> FHHDFIJMIBO<TOk>(in TOk LBFNPPDMBOE)
	{
		return default(global::DPAEKNFIIFN<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x322A1F0", Offset = "0x32295F0", VA = "0x18322A1F0")]
	public static global::DPAEKNFIIFN<HOGMLAALAEJ, T> FHHDFIJMIBO()
	{
		return default(global::DPAEKNFIIFN<HOGMLAALAEJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x32F6D90", Offset = "0x32F6190", VA = "0x1832F6D90")]
	public static global::DPAEKNFIIFN<T, TErr> HDDNGLPFNJB<TErr>(in TErr MLKJHAPKMEE)
	{
		return default(global::DPAEKNFIIFN<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class IBINAHCEMPO<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct PPAMBONCLID : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly global::IBINAHCEMPO<T> IEAONGDHDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int OBLAKBBLCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool MFKIPAJCBDK;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A630", Offset = "0xA69A30", VA = "0x180A6A630")]
		public PPAMBONCLID(global::IBINAHCEMPO<T> OOJCPNBFJMK, int MFMNAFBLFCO, bool KNFDJOGGIMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x32E2DD0", Offset = "0x32E21D0", VA = "0x1832E2DD0")]
		public global::IBINAHCEMPO<T>.PDJJHCJHEJO IINGNKPPFJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x32E2EC0", Offset = "0x32E22C0", VA = "0x1832E2EC0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x32E2EC0", Offset = "0x32E22C0", VA = "0x1832E2EC0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class PDJJHCJHEJO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly global::IBINAHCEMPO<T> IEAONGDHDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly int HGLEOMAMAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int AEBGDCJAGHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly bool MFKIPAJCBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool JAPKBNGHDGB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3FED540", Offset = "0x3FEC940", VA = "0x183FED540")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3FED660", Offset = "0x3FECA60", VA = "0x183FED660", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3FED8C0", Offset = "0x3FECCC0", VA = "0x183FED8C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3FEDD30", Offset = "0x3FED130", VA = "0x183FEDD30")]
		public PDJJHCJHEJO(global::IBINAHCEMPO<T> OOJCPNBFJMK, int MFMNAFBLFCO, bool KNFDJOGGIMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3FED590", Offset = "0x3FEC990", VA = "0x183FED590", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3FED610", Offset = "0x3FECA10", VA = "0x183FED610", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MEBJNJHPGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C2F0", Offset = "0x68B6F0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public MEBJNJHPGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3E66990", Offset = "0x3E65D90", VA = "0x183E66990")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly T[] DJPCBDGJLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int AEBGDCJAGHF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BKIHGLBCODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4A72380", Offset = "0x4A71780", VA = "0x184A72380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T HMAPMKOECOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x37241C0", Offset = "0x37235C0", VA = "0x1837241C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T DPHLGAHHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4A72470", Offset = "0x4A71870", VA = "0x184A72470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4A72240", Offset = "0x4A71640", VA = "0x184A72240")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FKOLDOEAEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x94EFF0", Offset = "0x94E3F0", VA = "0x18094EFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4A72360", Offset = "0x4A71760", VA = "0x184A72360")]
	private static int EBKFFMFHAPB(int GABJOMFFJAI, int DMFMCPNNNLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4A727C0", Offset = "0x4A71BC0", VA = "0x184A727C0")]
	public IBINAHCEMPO(int OLGJFEONMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4A72670", Offset = "0x4A71A70", VA = "0x184A72670")]
	public IBINAHCEMPO(int OLGJFEONMLB, Func<T> DOPGJOFIINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4A72840", Offset = "0x4A71C40", VA = "0x184A72840")]
	public IBINAHCEMPO(T[] DGHKCMOGJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4A72520", Offset = "0x4A71920", VA = "0x184A72520")]
	public void NPNJMGIALJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4A723C0", Offset = "0x4A717C0", VA = "0x184A723C0")]
	public IEnumerable<T> HCMDGJKONDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4A724A0", Offset = "0x4A718A0", VA = "0x184A724A0")]
	public global::IBINAHCEMPO<T>.PDJJHCJHEJO IINGNKPPFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x32C4300", Offset = "0x32C3700", VA = "0x1832C4300", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x32C4300", Offset = "0x32C3700", VA = "0x1832C4300", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IGBJLNPJENB
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34286C0", Offset = "0x3427AC0", VA = "0x1834286C0")]
	public static global::IBINAHCEMPO<T> GEGCLDEHDAN<T>(int OLGJFEONMLB, Func<T> DOPGJOFIINM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class IIKAKHMMJCC<TData> : GKAEBCMEFAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly string ODAKPEOCFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly TData KMLBNPHBCNK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
	public override string HPLBNLEOGCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2806AD0", Offset = "0x2805ED0", VA = "0x182806AD0")]
	internal IIKAKHMMJCC(string CIBBLLOHCGM, in TData MPEBBGJJODN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JJMNNGKFKMC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x64F60F0", Offset = "0x64F54F0", VA = "0x1864F60F0")]
	public static global::IIKAKHMMJCC<HOGMLAALAEJ> GEGCLDEHDAN(string CIBBLLOHCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2956EB0", Offset = "0x29562B0", VA = "0x182956EB0")]
	public static global::IIKAKHMMJCC<TData> GEGCLDEHDAN<TData>(string CIBBLLOHCGM, in TData MPEBBGJJODN)
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
