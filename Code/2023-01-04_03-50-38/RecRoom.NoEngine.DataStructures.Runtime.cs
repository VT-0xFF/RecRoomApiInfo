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
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x60AC5B0", Offset = "0x60AB9B0", VA = "0x1860AC5B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6936F0", Offset = "0x692AF0", VA = "0x1806936F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x813880", Offset = "0x812C80", VA = "0x180813880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EOFEIFEGGBO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface PHAGDILJJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string GEFGHDDIEJH(string AIOIJCLKGCN);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HPDOPNHAGJK(string ICBCECIENAJ);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MLINMNLHNFK(Exception DLEJGHMKMEP);
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static PHAGDILJJOD KGKEDLDKCKD;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct JBBKGPMLGJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDisposable[] ECBLPLNCCOM;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
	public JBBKGPMLGJF(params IDisposable[] LJPDGNKFBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xEE67C0", Offset = "0xEE5BC0", VA = "0x180EE67C0")]
	public static JBBKGPMLGJF IKMCJIAOBME(params IDisposable[] LJPDGNKFBLK)
	{
		return default(JBBKGPMLGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60AC420", Offset = "0x60AB820", VA = "0x1860AC420", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MFHIEGPKIMO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IDisposable AGPIEKKCNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public T KGOGAJOHGBC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29C9260", Offset = "0x29C8660", VA = "0x1829C9260")]
	public MFHIEGPKIMO(IDisposable FPGLNAGBBFA, in T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2422C10", Offset = "0x2422010", VA = "0x182422C10")]
	public static global::MFHIEGPKIMO<U> KDBKEHOIICH<U>(in global::MFHIEGPKIMO<T> FPGLNAGBBFA, in U IGDJJEECDAF)
	{
		return default(global::MFHIEGPKIMO<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29C91D0", Offset = "0x29C85D0", VA = "0x1829C91D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LLOPINCGLOH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x25C1000", Offset = "0x25C0400", VA = "0x1825C1000")]
	public static global::MFHIEGPKIMO<T> IKMCJIAOBME<T>(IDisposable FPGLNAGBBFA, in T IGDJJEECDAF)
	{
		return default(global::MFHIEGPKIMO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A020", Offset = "0x1F79420", VA = "0x181F7A020")]
	public static global::MFHIEGPKIMO<U> KDBKEHOIICH<U, T>(in global::MFHIEGPKIMO<T> HCIANMDLBDK, in U IGDJJEECDAF)
	{
		return default(global::MFHIEGPKIMO<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct OCILMCCEGDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00")]
	public static OCILMCCEGDN DKOALHGANJG(Type FPPBLNEEHBP, [Optional] string HFGHFNGFDHM, [Optional] string KHDPGNMEKMI, bool HEFPCBHBBEO = false)
	{
		return default(OCILMCCEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00")]
	public static OCILMCCEGDN DKOALHGANJG<T>([Optional] string HFGHFNGFDHM, [Optional] string KHDPGNMEKMI, bool HEFPCBHBBEO = false)
	{
		return default(OCILMCCEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class DJBJKBPDGID
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static bool AHKBJAIDJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly string OJLJDHPKKMK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual DJBJKBPDGID IEKMIEGGPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60AC340", Offset = "0x60AB740", VA = "0x1860AC340")]
	protected DJBJKBPDGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string FFDKGCBGJBM();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60AC170", Offset = "0x60AB570", VA = "0x1860AC170", Slot = "6")]
	public virtual string LEAJLIAOJHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60ABE50", Offset = "0x60AB250", VA = "0x1860ABE50")]
	public void CNJKKJHJLNH(StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60AC2E0", Offset = "0x60AB6E0", VA = "0x1860AC2E0")]
	public void ONAMFFLJHNH(StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60ABCE0", Offset = "0x60AB0E0", VA = "0x1860ABCE0")]
	public void AMPFHOCMEJP(StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60AC1F0", Offset = "0x60AB5F0", VA = "0x1860AC1F0")]
	public void LFPALHHJMKJ(StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60AC0D0", Offset = "0x60AB4D0", VA = "0x1860AC0D0")]
	public static void KCMPFBKFAMP(StringBuilder BIOJHMCHAFL, string MGGNIJBJPII, string DNGPOGPADMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x67F670", Offset = "0x67EA70", VA = "0x18067F670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MEOHGPNEMHB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60AC540", Offset = "0x60AB940", VA = "0x1860AC540")]
	public MEOHGPNEMHB(string KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FBOBBNMLAAO<TErr> : MEOHGPNEMHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TErr IDMKKLEAGMK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x25301A0", Offset = "0x252F5A0", VA = "0x1825301A0")]
	private FBOBBNMLAAO(in TErr ACHLKAPINJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x25300D0", Offset = "0x252F4D0", VA = "0x1825300D0")]
	public static global::FBOBBNMLAAO<TErr> IKMCJIAOBME(in TErr ACHLKAPINJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BBGFHLGLABJ<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EJFIBLMECMK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string JKELPIBANNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FIHBIJLHEOP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60AC3B0", Offset = "0x60AB7B0", VA = "0x1860AC3B0")]
	public FIHBIJLHEOP(string KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DNAEEINLEKK<TOk> : FIHBIJLHEOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TOk LCGBNNGKEGC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31656B0", Offset = "0x3164AB0", VA = "0x1831656B0")]
	private DNAEEINLEKK(in TOk LMILMJBPBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27802D0", Offset = "0x277F6D0", VA = "0x1827802D0")]
	public static global::DNAEEINLEKK<TOk> IKMCJIAOBME(in TOk LMILMJBPBLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct BFOGDGGAJLJ<TOk, TErr> : IEquatable<global::BFOGDGGAJLJ<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly EqualityComparer<TErr> MLIMOAJIFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TErr IDMKKLEAGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly TOk LCGBNNGKEGC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool POCEBLMPKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3CE35F0", Offset = "0x3CE29F0", VA = "0x183CE35F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ODEEKNMDDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3CE73A0", Offset = "0x3CE67A0", VA = "0x183CE73A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8770", Offset = "0x3CE7B70", VA = "0x183CE8770")]
	internal BFOGDGGAJLJ(in TErr ACHLKAPINJH, in TOk LMILMJBPBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4E50", Offset = "0x3CE4250", VA = "0x183CE4E50")]
	public static global::BFOGDGGAJLJ<TOk, TErr> GIDJDIBFEBO(in TErr ACHLKAPINJH)
	{
		return default(global::BFOGDGGAJLJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6100", Offset = "0x3CE5500", VA = "0x183CE6100")]
	public static global::BFOGDGGAJLJ<TOk, TErr> IHMENBPIONO(in TOk LMILMJBPBLI)
	{
		return default(global::BFOGDGGAJLJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x23CDFF0", Offset = "0x23CD3F0", VA = "0x1823CDFF0")]
	public global::BFOGDGGAJLJ<TOk, UErr> NOAAMDCFLLH<UErr>()
	{
		return default(global::BFOGDGGAJLJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x23CDF20", Offset = "0x23CD320", VA = "0x1823CDF20")]
	public global::BFOGDGGAJLJ<UOk, TErr> GIINOFMKIDP<UOk>()
	{
		return default(global::BFOGDGGAJLJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x23CDB60", Offset = "0x23CCF60", VA = "0x1823CDB60")]
	public global::BFOGDGGAJLJ<UOk, TErr> APPBOFEDJAO<UOk>()
	{
		return default(global::BFOGDGGAJLJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x23CD7F0", Offset = "0x23CCBF0", VA = "0x1823CD7F0")]
	public global::BFOGDGGAJLJ<TOk, UErr> AAHMJEKJGKF<UErr>()
	{
		return default(global::BFOGDGGAJLJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7110", Offset = "0x3CE6510", VA = "0x183CE7110")]
	public global::BFOGDGGAJLJ<IMOBLFIBELG, TErr> OCCGANEMJJK()
	{
		return default(global::BFOGDGGAJLJ<IMOBLFIBELG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6A00", Offset = "0x3CE5E00", VA = "0x183CE6A00")]
	public static bool LPAHFDMKICD(in global::BFOGDGGAJLJ<TOk, TErr> HOHNFHDFLIK, in global::BFOGDGGAJLJ<TOk, TErr> IBLJPHDNENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4210", Offset = "0x3CE3610", VA = "0x183CE4210", Slot = "4")]
	public bool Equals(global::BFOGDGGAJLJ<TOk, TErr> EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4540", Offset = "0x3CE3940", VA = "0x183CE4540", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3CE58D0", Offset = "0x3CE4CD0", VA = "0x183CE58D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3CE85E0", Offset = "0x3CE79E0", VA = "0x183CE85E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LJCPFEDIKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x25C07A0", Offset = "0x25BFBA0", VA = "0x1825C07A0")]
	public static global::BFOGDGGAJLJ<TOk, TErr> LCGBNNGKEGC<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, in TOk LMILMJBPBLI)
	{
		return default(global::BFOGDGGAJLJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x25C0A20", Offset = "0x25BFE20", VA = "0x1825C0A20")]
	public static global::BFOGDGGAJLJ<IMOBLFIBELG, TErr> LCGBNNGKEGC<TErr>(this in global::BFOGDGGAJLJ<IMOBLFIBELG, TErr> LKINCHDLDIG)
	{
		return default(global::BFOGDGGAJLJ<IMOBLFIBELG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x25C07D0", Offset = "0x25BFBD0", VA = "0x1825C07D0")]
	public static global::BFOGDGGAJLJ<TOk, TErr> IDMKKLEAGMK<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, in TErr ACHLKAPINJH)
	{
		return default(global::BFOGDGGAJLJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25BF6B0", Offset = "0x25BEAB0", VA = "0x1825BF6B0")]
	public static TOk DGEKEPAHBAG<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x25BF720", Offset = "0x25BEB20", VA = "0x1825BF720")]
	[AsyncStateMachine(typeof(LBADOMHFKHD))]
	public static Task<TOk> DKJLIKGGKPL<TOk, TErr>(this Task<global::BFOGDGGAJLJ<TOk, TErr>> LKINCHDLDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25BF400", Offset = "0x25BE800", VA = "0x1825BF400")]
	public static TErr ABFDDKHOGFP<TErr, TOk>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25BFD50", Offset = "0x25BF150", VA = "0x1825BFD50")]
	public static bool GJIPGABEIJK<TOk, TErr, UErr, UOk>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, out global::BFOGDGGAJLJ<UOk, UErr> NDGHDGODOOA) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25C0980", Offset = "0x25BFD80", VA = "0x1825C0980")]
	public static bool JPHBAGNFNHC<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, out TOk LMILMJBPBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25C0A50", Offset = "0x25BFE50", VA = "0x1825C0A50")]
	public static bool NDLDDNKDKDH<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, out TErr ACHLKAPINJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25C08E0", Offset = "0x25BFCE0", VA = "0x1825C08E0")]
	public static bool JEOGLGKKJPF<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, out TOk LMILMJBPBLI, out TErr ACHLKAPINJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25C09C0", Offset = "0x25BFDC0", VA = "0x1825C09C0")]
	public static bool KJDGBNFLGDC<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, out TOk LMILMJBPBLI, out global::BFOGDGGAJLJ<TOk, TErr> NDGHDGODOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25C0200", Offset = "0x25BF600", VA = "0x1825C0200")]
	public static bool GJIPGABEIJK<TOk, TErr, UErr, UOk>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, out TOk LMILMJBPBLI, out global::BFOGDGGAJLJ<UOk, UErr> NDGHDGODOOA) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25C0BB0", Offset = "0x25BFFB0", VA = "0x1825C0BB0")]
	public static bool NGMNLNKFMAN<TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, out TOk LMILMJBPBLI, out global::BFOGDGGAJLJ<IMOBLFIBELG, TErr> NDGHDGODOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25C04A0", Offset = "0x25BF8A0", VA = "0x1825C04A0")]
	public static global::BFOGDGGAJLJ<UOk, UErr> HBHEJMBKFKL<UOk, UErr, TOk, TErr>(this in global::BFOGDGGAJLJ<TOk, TErr> LKINCHDLDIG, in global::BFOGDGGAJLJ<UOk, UErr> FAHGJOEFBKN) where TOk : UOk where TErr : UErr
	{
		return default(global::BFOGDGGAJLJ<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25BF980", Offset = "0x25BED80", VA = "0x1825BF980")]
	public static global::BFOGDGGAJLJ<TOk[], TErr> ELHEEGDJPLF<TOk, TErr>(this IEnumerable<global::BFOGDGGAJLJ<TOk, TErr>> LKINCHDLDIG)
	{
		return default(global::BFOGDGGAJLJ<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22B3470", Offset = "0x22B2870", VA = "0x1822B3470")]
	[IteratorStateMachine(typeof(AMPNPFBICOE))]
	public static IEnumerable<TOk> FIFLCFKGEDB<TOk, TErr>(this IEnumerable<global::BFOGDGGAJLJ<TOk, TErr>> LKINCHDLDIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JAABELIKIOK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23E64F0", Offset = "0x23E58F0", VA = "0x1823E64F0")]
	public static global::BFOGDGGAJLJ<TOk, T> LCGBNNGKEGC<TOk>(in TOk LMILMJBPBLI)
	{
		return default(global::BFOGDGGAJLJ<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31BDA40", Offset = "0x31BCE40", VA = "0x1831BDA40")]
	public static global::BFOGDGGAJLJ<IMOBLFIBELG, T> LCGBNNGKEGC()
	{
		return default(global::BFOGDGGAJLJ<IMOBLFIBELG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x23E65B0", Offset = "0x23E59B0", VA = "0x1823E65B0")]
	public static global::BFOGDGGAJLJ<T, TErr> IDMKKLEAGMK<TErr>(in TErr ACHLKAPINJH)
	{
		return default(global::BFOGDGGAJLJ<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public sealed class ADFAGLHAKJL<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private readonly struct KOPEEEMLDDO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly global::ADFAGLHAKJL<T> DNLNFMBJJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int ENBONNDIHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly bool LBAJHGJPBME;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x296D1B0", Offset = "0x296C5B0", VA = "0x18296D1B0")]
		public KOPEEEMLDDO(global::ADFAGLHAKJL<T> BDGKEIOKECF, int IKFCCMBOGHH, bool DEHJGLPNMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x296D080", Offset = "0x296C480", VA = "0x18296D080")]
		public global::ADFAGLHAKJL<T>.HCDPDAIIHFA PEKBJENCCON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x296D170", Offset = "0x296C570", VA = "0x18296D170", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x296D170", Offset = "0x296C570", VA = "0x18296D170", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class HCDPDAIIHFA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly global::ADFAGLHAKJL<T> DNLNFMBJJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int AJLNODPHECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int PMPHIBAPFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly bool LBAJHGJPBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool CACDBBLIGFJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2FC7170", Offset = "0x2FC6570", VA = "0x182FC7170")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2FC7290", Offset = "0x2FC6690", VA = "0x182FC7290", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2FC7480", Offset = "0x2FC6880", VA = "0x182FC7480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7A40", Offset = "0x2FC6E40", VA = "0x182FC7A40")]
		public HCDPDAIIHFA(global::ADFAGLHAKJL<T> BDGKEIOKECF, int IKFCCMBOGHH, bool DEHJGLPNMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2FC71C0", Offset = "0x2FC65C0", VA = "0x182FC71C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7240", Offset = "0x2FC6640", VA = "0x182FC7240", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BPPPAMDDHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63A7F0", Offset = "0x639BF0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public BPPPAMDDHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x239E360", Offset = "0x239D760", VA = "0x18239E360")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly T[] GGLGJIIHIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int PMPHIBAPFAH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HJDOHBKKHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x43A7C70", Offset = "0x43A7070", VA = "0x1843A7C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T BHDIBOCECJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2525790", Offset = "0x2524B90", VA = "0x182525790")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T KEADCECDCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x43A7B60", Offset = "0x43A6F60", VA = "0x1843A7B60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x43A7DD0", Offset = "0x43A71D0", VA = "0x1843A7DD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GCBADAOHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBC0", Offset = "0x8DDFC0", VA = "0x1808DEBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x43A7E30", Offset = "0x43A7230", VA = "0x1843A7E30")]
	private static int JNLFKMINOFP(int HMJKJGLHFKE, int BFFLFOJBLOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x43A8260", Offset = "0x43A7660", VA = "0x1843A8260")]
	public ADFAGLHAKJL(int DEBAMGFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x43A8080", Offset = "0x43A7480", VA = "0x1843A8080")]
	public ADFAGLHAKJL(int DEBAMGFBJEH, Func<T> PDGFCPAGKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x43A7FF0", Offset = "0x43A73F0", VA = "0x1843A7FF0")]
	public ADFAGLHAKJL(T[] LJPDGNKFBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x43A7C40", Offset = "0x43A7040", VA = "0x1843A7C40")]
	public void CHCOOBJCFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x43A7B90", Offset = "0x43A6F90", VA = "0x1843A7B90")]
	public IEnumerable<T> CAKLKBILMKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x43A7E50", Offset = "0x43A7250", VA = "0x1843A7E50")]
	public global::ADFAGLHAKJL<T>.HCDPDAIIHFA PEKBJENCCON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2391490", Offset = "0x2390890", VA = "0x182391490", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2391490", Offset = "0x2390890", VA = "0x182391490", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IABBLJKNLHD
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E420", Offset = "0x1F7D820", VA = "0x181F7E420")]
	public static global::ADFAGLHAKJL<T> IKMCJIAOBME<T>(int DEBAMGFBJEH, Func<T> PDGFCPAGKFP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class ALCPBPFNGMM<TData> : DJBJKBPDGID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly string GDJFNMEAMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly TData HEPLIACNMBF;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
	public override string FFDKGCBGJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x30FD660", Offset = "0x30FCA60", VA = "0x1830FD660")]
	internal ALCPBPFNGMM(string KAKCNEMJMJL, in TData PNMIIEJFOON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BBJKDBBLMIC
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60ABC70", Offset = "0x60AB070", VA = "0x1860ABC70")]
	public static global::ALCPBPFNGMM<IMOBLFIBELG> IKMCJIAOBME(string KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1F82640", Offset = "0x1F81A40", VA = "0x181F82640")]
	public static global::ALCPBPFNGMM<TData> IKMCJIAOBME<TData>(string KAKCNEMJMJL, in TData PNMIIEJFOON)
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
