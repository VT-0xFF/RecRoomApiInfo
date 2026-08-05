using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2540B20", Offset = "0x253F920", VA = "0x182540B20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct OMDFNHPHEAE : IEquatable<OMDFNHPHEAE>, DOBJOHBJOOL<OMDFNHPHEAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly MMBOLDIBAHF<IPGMDHDLEMN> OOBALNNFODE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2539D70", Offset = "0x2538B70", VA = "0x182539D70")]
	public OMDFNHPHEAE([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<IPGMDHDLEMN> LGHGLENPFAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2540D40", Offset = "0x253FB40", VA = "0x182540D40")]
	public static bool BHDCHHANDIG([In] OMDFNHPHEAE NMOPBJNEFKL, [In] OMDFNHPHEAE KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2540ED0", Offset = "0x253FCD0", VA = "0x182540ED0", Slot = "4")]
	public bool Equals(OMDFNHPHEAE LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2540E00", Offset = "0x253FC00", VA = "0x182540E00")]
	public bool KPIKCMFBAIM([In] OMDFNHPHEAE LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2540E10", Offset = "0x253FC10", VA = "0x182540E10", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2540EF0", Offset = "0x253FCF0", VA = "0x182540EF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2540E00", Offset = "0x253FC00", VA = "0x182540E00", Slot = "5")]
	private bool EEIEAKMOPOD([In] OMDFNHPHEAE LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FDOBDFHDADM : IEquatable<FDOBDFHDADM>, DOBJOHBJOOL<FDOBDFHDADM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly MMBOLDIBAHF<CJABLIIDPAG> JCGMNALMDGI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2539D70", Offset = "0x2538B70", VA = "0x182539D70")]
	public FDOBDFHDADM([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<CJABLIIDPAG> NGHFKDBHIPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2539B00", Offset = "0x2538900", VA = "0x182539B00")]
	public static bool BHDCHHANDIG([In] FDOBDFHDADM NMOPBJNEFKL, [In] FDOBDFHDADM KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2539C90", Offset = "0x2538A90", VA = "0x182539C90", Slot = "4")]
	public bool Equals(FDOBDFHDADM LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2539BC0", Offset = "0x25389C0", VA = "0x182539BC0")]
	public bool KPIKCMFBAIM([In] FDOBDFHDADM LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2539BD0", Offset = "0x25389D0", VA = "0x182539BD0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2539CB0", Offset = "0x2538AB0", VA = "0x182539CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2539BC0", Offset = "0x25389C0", VA = "0x182539BC0", Slot = "5")]
	private bool DDNAJAPLAEA([In] FDOBDFHDADM LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CCAGDHJOJOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	public CCAGDHJOJOO(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JIIPOHMNKAN
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Follow,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Orbit,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Attached,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Detached
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LGBFPHIHMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly HCAIJCFFPFA BGINDAILAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly GEBFHCNNIJP IPFNEKHOLLF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x253F4A0", Offset = "0x253E2A0", VA = "0x18253F4A0")]
	public LGBFPHIHMCK([In] HCAIJCFFPFA BGIEPHNJHFK, GEBFHCNNIJP PDNPLFLMEMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HCAIJCFFPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HKNIKLFPMCJ JOOLAJDCMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BGMBPJPBIDA NFJHEEFOGBK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	public HCAIJCFFPFA(HKNIKLFPMCJ NFBCEONMDOM, BGMBPJPBIDA IGOFBCPMNMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct GEBFHCNNIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly OLIDAEPNBCP FKBPAFHLMHI;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	public GEBFHCNNIJP(OLIDAEPNBCP FPGKIMDEMDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct ODGCBJBCHPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly FIGMLPKFFBC FBMAFBFKNIB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	public ODGCBJBCHPM(FIGMLPKFFBC JDDPFKOIPOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum KLCBIKGIGOO
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Digit,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Integer,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Decimal,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Regex,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	CustomValidator
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JOKNEJGFDBO
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BEJBGLNAANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly string ICDAKBBHCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string CJCIOGOFMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly string BMDHKKCONBB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2419D20", Offset = "0x2418B20", VA = "0x182419D20")]
	public BEJBGLNAANG(string KOOEAEGPNCF, string IKIEIDABEHC, string DCMECCMNPNM)
	{
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CDKPLBELCPA : ODIPPCJINFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string IFAIMJEEFNO, Action<string, float> ECEKBIHJMBL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HEOBGHFNHGK : KHHMCBEJJCB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMJIAFMDCEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ODIPPCJINFJ
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HOGENKMMIOH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HLAMMENEKBD
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface COHMEGBDNHO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OJOJBECKENC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JCANMPFDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNJFDADMBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NOLFGCADBEG : KHHMCBEJJCB
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDGAONDGEMG(KHHMCBEJJCB GFJFPCIBNHH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCEIDOKFHPG();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEINLEAGPOE(KHHMCBEJJCB GFJFPCIBNHH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LEDDOFOKGCB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAFINIEHECH(string BBAPHJINAGP, Func<string> EGHPAGDGAIB, Action<string> MELIBNNNBFH, Func<bool> BBJOGCFBNGM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCAFNBNNKIB(string BBAPHJINAGP, Action EAMJNDGJPFP, Func<bool> BBJOGCFBNGM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJKCHFBEKOB(string BBAPHJINAGP, Func<int> ECAAPIACHKN, Action<int> IPMJNOBEJAG, Func<bool> BBJOGCFBNGM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHCJBHIPKAF(string BBAPHJINAGP, Func<int> EGHPAGDGAIB, Action<int> MELIBNNNBFH, Func<bool> BBJOGCFBNGM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KDGNNHFDHDO(string BBAPHJINAGP, Func<object> JGKGFKHGELP, Action<object> MLLPCEHJCKL, Func<object, string> CPGPMNNGCBI, Func<bool> BBJOGCFBNGM, Type BAIAAKMEPDO, IReadOnlyList<object> OCCOLJHJGKI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMNIGLEKAEK(string BBAPHJINAGP, Func<string> EGHPAGDGAIB, Action<string> MELIBNNNBFH, Func<bool> BBJOGCFBNGM);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OOHKFOMNEMB(string BBAPHJINAGP, Func<bool> EGHPAGDGAIB, Action<bool> MELIBNNNBFH, Func<bool> BBJOGCFBNGM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FEMHNCEEGDK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface LOINKFNFBNA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Action<FEMHNCEEGDK>? OCCJFBFLACD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KHHMCBEJJCB IKADCGFDDFJ(Func<bool> MOHLEAFFMIP, Action<bool> ICDHHDIJIAH, Func<byte> HDDGPHKCIFH, Action<byte> LLDDMGEONEJ, Func<int> CEEMGJBLMIC, Action<int> JFJGIBOAOPN, Func<IReadOnlyList<string>> IFKEHGKMEJK, Action<IReadOnlyList<string>> OCBOOPHJGGO, [Optional] Func<IReadOnlyList<string>>? DKMOHMCENOO, [Optional] Action<IReadOnlyList<string>>? BNJKHDIPMLB, [Optional] Func<bool>? BBJOGCFBNGM);
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LOINKFNFBNA JDPNAGGALGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KHHMCBEJJCB LELOINMAGNC(Action EAMJNDGJPFP, string BBAPHJINAGP = "", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KHHMCBEJJCB BHHMKEBKOFC(IReadOnlyList<KHHMCBEJJCB> OLAJDKDOKOD, [Optional] float? JGIKEBDMHLB, [Optional] int? GIHEFEEIHHM, [Optional] bool? LLDDLKKKLHA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KHHMCBEJJCB NCBJJJAMELD(IReadOnlyList<KHHMCBEJJCB> OLAJDKDOKOD, [Optional] float? JGIKEBDMHLB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KHHMCBEJJCB NHAAPFDAADJ(Func<int> ECAAPIACHKN, Action<int> IPMJNOBEJAG, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, bool HNABLNHFFNL = false, string BBAPHJINAGP = "Color", [Optional] Func<bool>? LECLGOACOMM, bool HNMJJKJGOPK = true, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KHHMCBEJJCB FBAKFCPNJNC(Action EAMJNDGJPFP, string BBAPHJINAGP = "", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KHHMCBEJJCB ACMCJCGDEEI(Func<long> DOFNKNPKGEE, Action<long> BAPGFCEKEPB, string KINNPAIFCGL = "Choose Event", string GDMDMDOELBO = "Choose Event", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<CancellationToken>? DEAIHMMNEHN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KHHMCBEJJCB LKGDKDMIPHB(Func<HFJNFIGGNLC<CHMLMGCOLME>> AFMEDCDJGCA, Func<int> KMNMFJGMPBH, [Optional] Func<bool>? BBJOGCFBNGM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KHHMCBEJJCB GAPOCMPBLMI(KHHMCBEJJCB GFJFPCIBNHH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NOLFGCADBEG DIONFHKHFIL(int JHPBGABBKOP, string BBAPHJINAGP, string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] IReadOnlyList<KHHMCBEJJCB>? OLAJDKDOKOD, [Optional] Func<bool>? BBJOGCFBNGM, bool HJHJNGLMIJO = true, [Optional] Func<bool>? GGLEGINKGIP, [Optional] Action<bool>? LCODMGCKION, [Optional] float? MJELHMEGALM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KHHMCBEJJCB IPPLJOEDCGE(string MMLPEKEEFNO, [Optional] Func<string?>? FHGJFLNGEHN, [Optional] Func<bool>? BBJOGCFBNGM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KHHMCBEJJCB LJODIAIINND(Func<string> EGHPAGDGAIB, Action<string> MELIBNNNBFH, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] int? HNJLKNGMCJP, bool IDBFMHOCONE = false, string BBAPHJINAGP = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KHHMCBEJJCB EJFDFBHPPAD(Func<float> EGHPAGDGAIB, Action<float> MELIBNNNBFH, string BBAPHJINAGP = "", string LKMFBBFEFCB = "", string JBACKHNFBBH = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", bool AFLJFDHAFID = false, float NNFHCPHHCNA = 0f, float JDNLHPFENDF = 1000f, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KHHMCBEJJCB EODOHLGEJDP(Func<int> EGHPAGDGAIB, Action<int> MELIBNNNBFH, string BBAPHJINAGP = "", [Optional] Func<string>? IIKFLOPPACD, string LKMFBBFEFCB = "", [Optional] Func<string>? LCJLPBFNNGF, string JBACKHNFBBH = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", bool AFLJFDHAFID = false, int NNFHCPHHCNA = 0, int JDNLHPFENDF = 1000, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KHHMCBEJJCB ILAPNMLABBO(Type BAIAAKMEPDO, IReadOnlyList<object> OCCOLJHJGKI, Func<object> JGKGFKHGELP, Action<object> MLLPCEHJCKL, string BBAPHJINAGP = "", string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<object, string>? CPGPMNNGCBI, bool ADPABHNABHL = true, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KHHMCBEJJCB NJNHGEJNBPN(Func<string> EGHPAGDGAIB, Action<string> MELIBNNNBFH, int HBCOFAIIFEF = 1000, JOKNEJGFDBO KNFAICCMDII = JOKNEJGFDBO.Alphanumeric, [Optional] Func<string, bool>? FDDHILNGPJA, [Optional] string? CDELIKJKPCJ, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, string BBAPHJINAGP = "", string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", bool IDBFMHOCONE = false, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true, float KENFMJGBNLN = 0f);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KHHMCBEJJCB GBHENOALKGC(Func<float> EGHPAGDGAIB, Action<float> MELIBNNNBFH, float NNFHCPHHCNA = 0f, float JDNLHPFENDF = 1000f, [Optional] Func<bool>? OPFIINKNJDO, int BIKGDGIEAIJ = -1, string BBAPHJINAGP = "", string LKMFBBFEFCB = "", string JBACKHNFBBH = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Func<float, float>? JMBAJEGONKE, [Optional] Func<float, float>? IFHGIDHFBMK, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	KHHMCBEJJCB CHPANLBJONE(Func<string> EGHPAGDGAIB, Action<string> MELIBNNNBFH, Action EAMJNDGJPFP, [Optional] Func<bool>? BBJOGCFBNGM, JOKNEJGFDBO KNFAICCMDII = JOKNEJGFDBO.Alphanumeric, [Optional] Func<string, bool>? FDDHILNGPJA, KLCBIKGIGOO PPGGDCDMPCA = KLCBIKGIGOO.Alphanumeric, [Optional] string? CDELIKJKPCJ, [Optional] List<KHHMCBEJJCB>? DBCNPMLDKAH, string BBAPHJINAGP = "", string NKMDGDOPDEA = "", string EHPKIEIKEKD = "", string GMEPMGBEBIO = "", bool JNCDGNOGJBL = true, float KENFMJGBNLN = 0f);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KHHMCBEJJCB BIOLFHNCBNJ(Func<string> EGHPAGDGAIB, Action<string> MELIBNNNBFH, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] int? HNJLKNGMCJP, bool IDBFMHOCONE = false, string BBAPHJINAGP = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	KHHMCBEJJCB BKEKGNINNBN(Func<bool> EGHPAGDGAIB, Action<bool> MELIBNNNBFH, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, string BBAPHJINAGP = "", string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] int? JHPBGABBKOP, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KHHMCBEJJCB GCCINDJNMCO(Func<bool> EGHPAGDGAIB, Action<bool> MELIBNNNBFH, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, string BBAPHJINAGP = "", string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] int? JHPBGABBKOP, [Optional] Func<bool>? LECLGOACOMM, [Optional] Func<bool>? KFFIDADIKKO, string EDPMIKELOPA = "", [Optional] Func<string>? BFOLFEFEBEN, string AFGMFJCOPNC = "", [Optional] Func<string>? DMIONPHNGGA, bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HEOBGHFNHGK NNLKGABNIBI(Dictionary<string, NNDGLBEAKFC> EDLHCINOAKH, Func<int> ECAAPIACHKN, Action<int> IPMJNOBEJAG, string BBAPHJINAGP, string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Action? IGFALCGGLEI, [Optional] Action? KOFAMIJGHGE, [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<int, string>? FFNICHPNKGH, bool ADPABHNABHL = true, bool BCEMCAKMCLB = true, bool JNCDGNOGJBL = true, bool FKKMODPFGMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "22")]
	HEOBGHFNHGK BAKOEMOAKOG(Func<Dictionary<string, NNDGLBEAKFC>> FNHFJMOJIJI, Func<int> ECAAPIACHKN, Action<int> IPMJNOBEJAG, string BBAPHJINAGP, string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<bool>? MBOLGNJCIHJ, [Optional] Func<int, string>? FFNICHPNKGH, bool ADPABHNABHL = true, bool BCEMCAKMCLB = true, bool JNCDGNOGJBL = true, bool FKKMODPFGMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KHHMCBEJJCB DNJDKFACJMD(Func<IReadOnlyList<KeyValuePair<string, NNDGLBEAKFC>>> FNHFJMOJIJI, Func<int> ECAAPIACHKN, Action<int> IPMJNOBEJAG, string BBAPHJINAGP, string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<bool>? MBOLGNJCIHJ, [Optional] Func<int, string>? FFNICHPNKGH, [Optional] Action? IGFALCGGLEI, [Optional] Action? KOFAMIJGHGE, bool ADPABHNABHL = true, bool BCEMCAKMCLB = true, bool JNCDGNOGJBL = true, bool FKKMODPFGMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KHHMCBEJJCB DOMHNBNJDDL(Func<List<object>> FNHFJMOJIJI, Func<object> JGKGFKHGELP, Action<object> MLLPCEHJCKL, Func<object, string> CPGPMNNGCBI, string BBAPHJINAGP = "", string LKMFBBFEFCB = "", string NKMDGDOPDEA = "", string MKNOLAIIFLO = "", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, bool ADPABHNABHL = true, bool JNCDGNOGJBL = true, bool FKKMODPFGMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KHHMCBEJJCB KKOBHCDMFAK(string BBAPHJINAGP, Func<object> JGKGFKHGELP, Action<object> MLLPCEHJCKL, Func<object, string> CPGPMNNGCBI, Func<IReadOnlyList<object>> ABOIBMCBEGP, [Optional] Func<bool>? BBJOGCFBNGM, bool FKKMODPFGMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KEIDBHOKCLF(KHHMCBEJJCB GFJFPCIBNHH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KNBKBAIBNFG(string FMNMBOMDCIK, Action? BHLCKNEMMJP, string MGHJFKPDAMI, Action? LOOGECAKHAP, string KKBJAPCBOHH, string NDKKADCKLPM);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DFGDHAOEAGN(Func<string> EGHPAGDGAIB, Action<string> MELIBNNNBFH, Action EAMJNDGJPFP, [Optional] Func<bool>? BBJOGCFBNGM, JOKNEJGFDBO KNFAICCMDII = JOKNEJGFDBO.Alphanumeric, [Optional] Func<string, bool>? FDDHILNGPJA, KLCBIKGIGOO PPGGDCDMPCA = KLCBIKGIGOO.Alphanumeric, [Optional] string? CDELIKJKPCJ, [Optional] List<KHHMCBEJJCB>? DBCNPMLDKAH, string BBAPHJINAGP = "", string NKMDGDOPDEA = "", string EHPKIEIKEKD = "", string GMEPMGBEBIO = "", bool JNCDGNOGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AEOJNOJAAKJ(string PEJNIJOCNIJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "30")]
	KHHMCBEJJCB FFOHFFOICHH(List<object> EDLHCINOAKH, List<string> CPGPMNNGCBI, Func<int> ECAAPIACHKN, Action<int> IPMJNOBEJAG, string AIIBDLAKCHI = "", [Optional] Func<bool>? BBJOGCFBNGM, [Optional] Func<bool>? CKFHJLJGNJK, [Optional] Func<bool>? LECLGOACOMM, bool JNCDGNOGJBL = true, bool KMPHMCFGDLN = false);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KHHMCBEJJCB
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PFGGHFNJIBB
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOJMGGGPIPC();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface IOHPNEOGGOI
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEGNEEHKFLH();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKLKBIAHIBD(string PODGEBHMDBF, [In] CGBHHFFMFPE EDAHAPFCLBP);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHCHMOPHLNF(string KKBJAPCBOHH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJABAHIOMJE(string MMLPEKEEFNO);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FDIBCACJGHL : HJBBDBHAMJJ, EOABGNINGBC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HEPJDFKAIEG MNBCHBNGHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IICLGKECAGE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BONDNIKNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KCJJMMGPOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GBLIDPKABAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HABLOFDNLFN(Guid JAHKGJHKMHC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DBONNFACIFN(HFJNFIGGNLC<MIEFPPNINJG> KGEJKJHMGOM, HFJNFIGGNLC<CHMLMGCOLME>? PKBGMJKPAKH, IReadOnlyDictionary<HFJNFIGGNLC<CHMLMGCOLME>, Guid>? PLNPFOEDODF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AFCMHMIALNG(Guid JAHKGJHKMHC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool INBIEPONPCL(Guid JAHKGJHKMHC);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HMOIHBCNMDO(HFJNFIGGNLC<MIEFPPNINJG> JAHKGJHKMHC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CMBCLPOIFNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EDALADINGLF? GGJCMHODIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DHOFOBMJNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool OILDAKBFJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<EDALADINGLF> JPPCNNHMDDI();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PGOLMGNGGBM<HCAIJCFFPFA, EOABGNINGBC> GGODFDIMGPK([In] HCAIJCFFPFA MIJMPILAEHA);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IReadOnlyDictionary<HFJNFIGGNLC<CHMLMGCOLME>, Guid> JFHAGNHGKBC(IEnumerable<DACMPOAMDBF> PGMCKOPDLFJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ENEOPEAOFOI EMLLILJBDIE(IEnumerable<DACMPOAMDBF> PGMCKOPDLFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GMGIFMMHFGF
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnEdgeDidAdd(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnEdgeWillRemove(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DALNLHCFIBN(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnFunctionDeclsRefreshed();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnObjectPropertiesRefreshed();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnEditGraphDidPush();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEditGraphDidPop();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EDALADINGLF
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct KLKENFNIKIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly MGDGAGBKOEK PJCJPHKAFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly ODGCBJBCHPM CJKJKNBHOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly IEnumerable<DACMPOAMDBF> KDHKPPJFDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly bool CHNCOHHPEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly HFJNFIGGNLC<CHMLMGCOLME> KOOANHODOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly int? LPLHEIPPPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly JGEIPOFGAHI? DJMKEHFLNMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly JGEIPOFGAHI? OJPCCLEOIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly AIFKNKNFJKB? BLBPPIPGMOC;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x253F0E0", Offset = "0x253DEE0", VA = "0x18253F0E0")]
		public KLKENFNIKIF(MGDGAGBKOEK ABLPIFLOMGE, [In] ODGCBJBCHPM MIJMPILAEHA, IEnumerable<DACMPOAMDBF> NOOBFGDNPPE, bool ACAHLKCOGNJ, [In] HFJNFIGGNLC<CHMLMGCOLME> DFJIAKNCDJF, int? AIPBMGOHBAF, [In] JGEIPOFGAHI? AJLGILKMDNI, [In] JGEIPOFGAHI? BAGPOALFNFJ, [In] AIFKNKNFJKB? DMINCEOHEHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct AIFKNKNFJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly IReadOnlyCollection<ByteString> BJNDIKJCPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly IReadOnlyCollection<ByteString> AGONNHJKLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly IReadOnlyCollection<ByteString> CNFBBCNPLLD;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2419D20", Offset = "0x2418B20", VA = "0x182419D20")]
		public AIFKNKNFJKB(IReadOnlyCollection<ByteString> OCFGFLMLFFH, IReadOnlyCollection<ByteString> GLKHGFFALLO, IReadOnlyCollection<ByteString> PNEHGMDDBKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct CGIKHGGGNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly ODGCBJBCHPM CJKJKNBHOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly IReadOnlyDictionary<Guid, Guid> JGIEEMAPJKG;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x25375B0", Offset = "0x25363B0", VA = "0x1825375B0")]
		public CGIKHGGGNKB(ODGCBJBCHPM MIJMPILAEHA, IReadOnlyDictionary<Guid, Guid> DEHOLMIJCCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HFJNFIGGNLC<CHMLMGCOLME> AGEPPPCLNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EILAKDKEEJE OENLHJCLIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, bool) OBABNDDHMGD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JEDIKEAMNGK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] MCCJOLAKNPC GHCCANLFLNF);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JKHJIOGKMOM(BHENDMMDMGJ GLKKCGJJGEJ);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JBCEEHOIDLG(EAKLKILMIHK DCGDNLGNDLM);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OMDFNHPHEAE? KDJLJPIAPEG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FDOBDFHDADM? DJBFONFKBJM(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MMBOLDIBAHF<BGEDOHJDFGJ>? DHONJCCHFCG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<CJABLIIDPAG> KADNPDEALKM);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MMBOLDIBAHF<LILDJNMHNBP>? NBHLDCMMFHB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<IPGMDHDLEMN> BCFPEDLJBCN);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<MMBOLDIBAHF<CHMLMGCOLME>> POPBMIPKDPK();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<MMBOLDIBAHF<DJIMMFKAAFA>> BHMJPEPJGEM();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "12")]
	string OEBHKIJPENI(MMBOLDIBAHF<DJIMMFKAAFA> NGEJFEJNCIG);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	string JFNBHEIBJED(MMBOLDIBAHF<DJIMMFKAAFA> NGEJFEJNCIG);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KDIJDIKDJEK? OANILKMGJDE([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MMBOLDIBAHF<CHMLMGCOLME> OKJLKMJLMIF([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MMBOLDIBAHF<CHMLMGCOLME>? IHPLDPMJPIE([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MMBOLDIBAHF<CHMLMGCOLME>? EFNFGFKCJNM(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	AEBHIPCIKGL? HMAJDCLHIAC([In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MMBOLDIBAHF<DGKHNPEDJKJ> CHMECDKOOCB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MMBOLDIBAHF<AHIDBKDCADN> BPDJIJEFKPP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CCAGDHJOJOO? EHAMGHMFDIO(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	long HOFILGFCDHI();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	IEnumerable<OJCJNACIJDM> NNIBGOGGBAK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool LHKLBMBDOGM(MMBOLDIBAHF<DJIMMFKAAFA> NGEJFEJNCIG);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IEnumerable<MCCJOLAKNPC> GMJBJLHEGEK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IEnumerable<MCCJOLAKNPC> IIJMHFEAAGJ(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "27")]
	IEnumerable<(MMBOLDIBAHF<CHMLMGCOLME>, MMBOLDIBAHF<AHIDBKDCADN>)> DPOFHOPJEEJ(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MMBOLDIBAHF<LILDJNMHNBP> NBHLDCMMFHB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<LEDHAJOPDGM> BCFPEDLJBCN);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MMBOLDIBAHF<AHIDBKDCADN> BEIDFEHJIIG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "30")]
	MMBOLDIBAHF<AHIDBKDCADN> FAEKGPEOGMA(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MMBOLDIBAHF<BGEDOHJDFGJ> DHONJCCHFCG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<DIGNAGEOFCF> KADNPDEALKM);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "32")]
	IEnumerable<GIOJMNNFGKM> IEJFAALONFI(DJKKHFLEFNP LFIIHBIAKBD, bool JCKILBAIIIL, bool PGGKHIJNADM, bool FPFHGFPOKNN, bool AIJJLDPODMB);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "33")]
	GIOJMNNFGKM PMFIOEBPAIL(DJKKHFLEFNP LFIIHBIAKBD, AAFLNAOHLKL CLOJEHOEOGB, bool JCKILBAIIIL, bool PGGKHIJNADM, bool FPFHGFPOKNN, bool AIJJLDPODMB);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	OJCJNACIJDM HDMPIIMAEDK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] MCCJOLAKNPC GHCCANLFLNF);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	HFJNFIGGNLC<CHMLMGCOLME> ONBNGOBIBPD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	MCCJOLAKNPC JJEEHJDNMGP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OCLNEPHMAMD(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, MMBOLDIBAHF<AHIDBKDCADN> NGJLPFOIIME, NFJHFHNDCLG DACBEFNKNPO, bool KEONPDKIFDF);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> PIHIGNIENOE(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, List<MMBOLDIBAHF<AHIDBKDCADN>> NKEGLDNAHCJ, NFJHFHNDCLG GMIKBDHENNM, GGLODEGCHGH INMLNAMLHEP, NFJHFHNDCLG DACBEFNKNPO);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "39")]
	(IReadOnlyDictionary<IAFCKPHMLJB, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<IPGMDHDLEMN>)>, IReadOnlyDictionary<FDMDHELILLE, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<CJABLIIDPAG>)>) GMBPJDJMFMO(HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> NGJLPFOIIME);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task OAKBIFGBLCB(HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, IReadOnlyList<HFJNFIGGNLC<AHIDBKDCADN>> FKJAMENOENO, IReadOnlyDictionary<IAFCKPHMLJB, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<IPGMDHDLEMN>)> COAHLLGEANK, IReadOnlyDictionary<FDMDHELILLE, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<CJABLIIDPAG>)> LOEOJKHFPOC);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> IMOIAEMBLND(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, List<MMBOLDIBAHF<AHIDBKDCADN>> NKEGLDNAHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> NOPGFKLEEEN(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, List<MMBOLDIBAHF<AHIDBKDCADN>> NKEGLDNAHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool MPMHFHAPLPM(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool MNPLAPMJIDD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool ENNCADNNMHG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "46")]
	PGOLMGNGGBM<CGIKHGGGNKB, FDIBCACJGHL> AHJBNNKFFBA([In] KLKENFNIKIF EHEEIKICBAM);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> HENMGGDKPCG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "48")]
	PGOLMGNGGBM<GMAPBEGKMND, EOABGNINGBC> KDCKBALONOM(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, GMAPBEGKMND MKHLMAIAGNC, GGLODEGCHGH LINILAAPDHO);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> DPOEPBFJNIE(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> INLGIBKCEGI, MMBOLDIBAHF<ECCLNDBJNAE> OLMIFGBPKFH, MMBOLDIBAHF<IPGMDHDLEMN> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> JKIPJHPIMHL(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> NMIHPDICOOP, MMBOLDIBAHF<ECCLNDBJNAE> BANKKDDOOOP, MMBOLDIBAHF<CJABLIIDPAG> KIIIMMIFGEE);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "51")]
	LGBFPHIHMCK EPLBENJMBGL();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "52")]
	LGBFPHIHMCK ILFFIALGLKO();

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "53")]
	ODGCBJBCHPM CJILOCLDAMA(MGDGAGBKOEK ABLPIFLOMGE, MMBOLDIBAHF<CHMLMGCOLME> CKLHIMIDKKB, IEnumerable<HFJNFIGGNLC<AHIDBKDCADN>> NKEGLDNAHCJ, IEnumerable<DACMPOAMDBF> NOOBFGDNPPE);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "54")]
	List<HOGENKMMIOH> KMEAIBFOEPC();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "55")]
	(List<HOGENKMMIOH>, bool) CIPFDPKAMMC([In] BEJBGLNAANG PHLBCOGAGAP, string MOBMLKIIAJP, [In] GCFHHJINGND GHADNDJKGPE, AHMLKICPGDI BDHABOFHKHD, DHLDGGEGFKD PGHLKDEOJJB);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "56")]
	bool HJKILPILGHP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "57")]
	PGOLMGNGGBM<MMBOLDIBAHF<BGEDOHJDFGJ>?, HJBBDBHAMJJ> MFLMOLMLBMI(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "58")]
	PGOLMGNGGBM<MMBOLDIBAHF<LILDJNMHNBP>?, HJBBDBHAMJJ> PCIJFNHEJOB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> DPBAOOBMIBG();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MIJCMCIKHMG : HJCEHBPJLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CMBCLPOIFNM LECJNAHKJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HJBBDBHAMJJ : EOABGNINGBC
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KDIJDIKDJEK
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	MMBOLDIBAHF<CHMLMGCOLME>? KPODNFOEHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LCKCLOMHBDD? DMIECJBHKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BHENDMMDMGJ : AAFLNAOHLKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MMBOLDIBAHF<IPGMDHDLEMN> IPKBOPLFBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MMBOLDIBAHF<LILDJNMHNBP> NEPENMNGHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool COGOKPHFGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDHNMOKHJKM(PFGGHFNJIBB HOFNFCKJKLE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKKPEPHODEO(LEDDOFOKGCB JEBPNPJOCKO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	string DKOKBMHAMFC(int FICGKJMEBJG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJGBOHDJPAO(IDIGIECJIAE DJDAKCILPLD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AACDKPPAIIB(IDIGIECJIAE DJDAKCILPLD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IDIGIECJIAE
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface AEBHIPCIKGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	object DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HFJNFIGGNLC<MIEFPPNINJG> MDJDBCOFJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MMBOLDIBAHF<DGKHNPEDJKJ> MCLEGJALKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HCDGNHMEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int AMMOEPOKKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CGBHHFFMFPE DHKEDNOLDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string MPFNPJDPKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NodeVisualizationKey HDKBAJIDJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MMBOLDIBAHF<CFIPDELBCCO> ELJCLKLOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GKFGKLHEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KFMBDNDGHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LKCBOCANPIJ PALIHOBGCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool OHNJCEAMOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool AALJKKKIKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool IGFMKBGBJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int FDCJBLOCNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool ALMKIEEOCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GGKOCODFKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool MNIFGPNLAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PIKJGFHKPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool JBBKCOCMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool DBMGDJKKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool DJJEBDBALMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NFJHFHNDCLG CIIGPNLPGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GGLODEGCHGH FDIJLBLBDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	[AHJBCDKENFK(true, "FloatingText")]
	bool CMMJJEHEDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "48")]
		[AHJBCDKENFK(true, "FloatingText")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	COHMEGBDNHO? FGBAMGEJHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool DLACEHHEADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MMBOLDIBAHF<CHMLMGCOLME>? DNLBFIDHOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IEnumerable<HFJNFIGGNLC<AHIDBKDCADN>>? IAONIMKHEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool PLPDNNOCDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool HDHEGFFGPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string PKJNADEJNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AMNAKHMFIGM<ECCLNDBJNAE, DMICOAPJLHF> BGPDHEAEIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MMBOLDIBAHF<ECCLNDBJNAE>? JCNPIIKINAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool MGCBJJEFHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool FFJDOKIFPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AKOHPKHOFMN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HKDIIGLBIGC OJHMEDCFGCP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NDKNNIOJFFN NBCPJMMCDLB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action MEOCHBMMELO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action KFKLDLDIIFD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<MMBOLDIBAHF<ECCLNDBJNAE>, DMICOAPJLHF> NPGELGGPIHG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<MMBOLDIBAHF<ECCLNDBJNAE>> PHBMMBKAGPK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<MMBOLDIBAHF<ECCLNDBJNAE>, DMICOAPJLHF> OKCJEEJABIG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<ECCLNDBJNAE>> FMCKFCOEIAO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MMBOLDIBAHF<ECCLNDBJNAE>, DMICOAPJLHF> AFNFBBIMFFC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<ECCLNDBJNAE>> IDCFHDLMGOF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIMDDFOICKD(int ILBEDDAMMEM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool AMOKKIFGFAC([In] NFJHFHNDCLG IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BGLGBHBGMFH([In] GGLODEGCHGH IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MKHDKIMHGAH();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OIADKLIDBGJ(NFJHFHNDCLG? PFKOKOAMOAJ, GGLODEGCHGH? ACJIHPAJKOG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BFOJOPEDEFO();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EOLBFHKMKEK();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OPCKDKNLFBN();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool FKBOIHCEMHO([Out] Guid DBNKGFDNLJG);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool CBJCDADNKDD([In] Guid FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void GCNCDDFOOKM();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void BPPJNHDMFFD(bool HEIKJGPDHLJ);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	ODIPPCJINFJ FFEOGOILINP([In] CDKPLBELCPA ABNMGDINBMB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void MGJJGBGFMGK(object DDMGKJODKDL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void DOFEPKBMIAJ(object DDMGKJODKDL);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> PKNMOHDNCIB(string PPKJBGAOBJL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void HKKPEPHODEO(FEMHNCEEGDK JODBBDIJPAM);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "79")]
	JGEIPOFGAHI FALIBOMGDKK();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool IOENKGHIAHL(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OMJDLKCPKGJ(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "84")]
	bool AAPOPAFABNP(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EAKLKILMIHK : AAFLNAOHLKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	MMBOLDIBAHF<BGEDOHJDFGJ> PMENIELMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MMBOLDIBAHF<CJABLIIDPAG> PMLDJNAIIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface AAFLNAOHLKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	IEnumerable<StaticEdge> DJDHOMFABCH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DisplayKind NLPHKHAEOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	MMBOLDIBAHF<PCJFIJFJEGH> CHNHCHMADJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	MPCKAHAFFFL AOPBPDNNDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	PortImage LDIGMJAKOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGKELOFIIMF(NPNFIKDHGCP DJDAKCILPLD);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HLAJJHLAMPE(DBEIAHHOIEF DJDAKCILPLD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HMKBLBECCDK(IOHPNEOGGOI EMNMLJIDJPC);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BPPEHBKJFKM(NPNFIKDHGCP DJDAKCILPLD);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MOHIBNHCEHP(DBEIAHHOIEF DJDAKCILPLD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NPNFIKDHGCP
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DMICOAPJLHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate void LOHLFNCDABA(MMBOLDIBAHF<ECCLNDBJNAE> PIOEIDCNELN, MMBOLDIBAHF<ECCLNDBJNAE> EFJIBFDIIGP);

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool BMAEIPPINDP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ENNGKHIJAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool EMBABIOLGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool KKJOCPBNEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	AMNAKHMFIGM<IPGMDHDLEMN, BHENDMMDMGJ> NPNHDLGHJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	AMNAKHMFIGM<CJABLIIDPAG, EAKLKILMIHK> IEAAMABLIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action POFKEMPACIK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DHALOPOJJDD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<MMBOLDIBAHF<IPGMDHDLEMN>, MMBOLDIBAHF<IPGMDHDLEMN>> NOPJNFPOAPA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MMBOLDIBAHF<IPGMDHDLEMN>, MMBOLDIBAHF<IPGMDHDLEMN>> HMNEFOBPBBN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MMBOLDIBAHF<CJABLIIDPAG>, MMBOLDIBAHF<CJABLIIDPAG>> EOCKLIAOFBI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<MMBOLDIBAHF<CJABLIIDPAG>, MMBOLDIBAHF<CJABLIIDPAG>> BPDHPFOOGBI;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<MMBOLDIBAHF<IPGMDHDLEMN>, BHENDMMDMGJ> GCMNKGENGJC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<MMBOLDIBAHF<IPGMDHDLEMN>> DCKBBKGALPD;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<MMBOLDIBAHF<IPGMDHDLEMN>, BHENDMMDMGJ> IMNEELHFPKE;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<MMBOLDIBAHF<CJABLIIDPAG>, EAKLKILMIHK> FBJJFFMFIOH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<MMBOLDIBAHF<CJABLIIDPAG>> NIGKEMFOGGG;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<MMBOLDIBAHF<CJABLIIDPAG>, EAKLKILMIHK> KMGGBNIDNLJ;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> JJKEHNNEBOG();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> AFILPLIFBIM(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> EFNFOJACDKL(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> BHDBOLFJBMB(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, MMBOLDIBAHF<KPGCHBLJMLN> BCIPJODLJPD);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> KCJHIPEHGEF(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, MMBOLDIBAHF<BNKJNPHLBPJ> BCIPJODLJPD);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> CJMCBPKNAAA();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> LCPIMNMLLNE(string IEIADNFCLID);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> EBCJHOGJJBL(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, string PPKJBGAOBJL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> CKENOJLDGLP(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, string PPKJBGAOBJL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> NDJKLJEBKNA(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, GIOJMNNFGKM OBDHBADPJNM);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> FGJJAJFIILL(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, GIOJMNNFGKM OBDHBADPJNM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GIOJMNNFGKM
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	TypeKey DAENGAMBMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	string CEPPBACOOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<PGOLMGNGGBM<MMBOLDIBAHF<KPGCHBLJMLN>, HJBBDBHAMJJ>> OBONDLPFBKE(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, string PPKJBGAOBJL);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<PGOLMGNGGBM<MMBOLDIBAHF<BNKJNPHLBPJ>, HJBBDBHAMJJ>> DENIOCJFGJK(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, string PPKJBGAOBJL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface DBEIAHHOIEF
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed([In] FCGHFACELGK BLCLLKNOJLD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MPCKAHAFFFL
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GOEIIELNLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool EJJGOJLPAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	TypeKey HDKBAJIDJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool HEJDIPNHHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class ILHEFCALCEI : HOGENKMMIOH, IEquatable<ILHEFCALCEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> ENJFJHOGAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> LNICGLGMLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> HPBGAIJOELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> MAAIMNFHLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly MMBOLDIBAHF<LILDJNMHNBP> NAPKJKPHIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly MMBOLDIBAHF<BGEDOHJDFGJ> CAIHIGGCFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly string JGKHCEAEIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string OMAPFHMKNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x253E550", Offset = "0x253D350", VA = "0x18253E550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x253E8F0", Offset = "0x253D6F0", VA = "0x18253E8F0")]
	public ILHEFCALCEI(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> DBBCHEAOGIC, [In] HFJNFIGGNLC<AHIDBKDCADN> DOMJNOJMOPE, MMBOLDIBAHF<AHIDBKDCADN> GDBBFGKBDOC, [In] HFJNFIGGNLC<AHIDBKDCADN> ELODGKDFMNK, MMBOLDIBAHF<LILDJNMHNBP> PBBNBPKDAMF, MMBOLDIBAHF<BGEDOHJDFGJ> IKJFEGAGJME, string OMLMCMJPLFJ, string EABNNMHOPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x253E5F0", Offset = "0x253D3F0", VA = "0x18253E5F0", Slot = "5")]
	public bool Equals(ILHEFCALCEI KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x253E580", Offset = "0x253D380", VA = "0x18253E580", Slot = "0")]
	public override bool Equals(object? KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x253E770", Offset = "0x253D570", VA = "0x18253E770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class LCHGFHDOOAE : HOGENKMMIOH, IEquatable<LCHGFHDOOAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x253F190", Offset = "0x253DF90", VA = "0x18253F190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x253F380", Offset = "0x253E180", VA = "0x18253F380")]
	public LCHGFHDOOAE(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x253F1C0", Offset = "0x253DFC0", VA = "0x18253F1C0", Slot = "5")]
	public bool Equals(LCHGFHDOOAE KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x253F250", Offset = "0x253E050", VA = "0x18253F250", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x253F310", Offset = "0x253E110", VA = "0x18253F310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct IAFCKPHMLJB : IEquatable<IAFCKPHMLJB>, DOBJOHBJOOL<IAFCKPHMLJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly MMBOLDIBAHF<IPGMDHDLEMN> OOBALNNFODE;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x24D6A90", Offset = "0x24D5890", VA = "0x1824D6A90")]
	public IAFCKPHMLJB([In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<IPGMDHDLEMN> LGHGLENPFAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x253E2C0", Offset = "0x253D0C0", VA = "0x18253E2C0")]
	public static bool BHDCHHANDIG([In] IAFCKPHMLJB NMOPBJNEFKL, [In] IAFCKPHMLJB KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x253E490", Offset = "0x253D290", VA = "0x18253E490", Slot = "4")]
	public bool Equals(IAFCKPHMLJB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x253E540", Offset = "0x253D340", VA = "0x18253E540")]
	public bool KPIKCMFBAIM([In] IAFCKPHMLJB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x253E360", Offset = "0x253D160", VA = "0x18253E360", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x253E4B0", Offset = "0x253D2B0", VA = "0x18253E4B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x253E540", Offset = "0x253D340", VA = "0x18253E540", Slot = "5")]
	private bool NDLNAEJHJCB([In] IAFCKPHMLJB LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BGMMBBADFFD : HOGENKMMIOH, IEquatable<BGMMBBADFFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly MMBOLDIBAHF<LILDJNMHNBP> FMCCKADAGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly MMBOLDIBAHF<LILDJNMHNBP> MEPOIKHCIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int BHLGCGDAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2536C20", Offset = "0x2535A20", VA = "0x182536C20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2537000", Offset = "0x2535E00", VA = "0x182537000")]
	public BGMMBBADFFD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, MMBOLDIBAHF<LILDJNMHNBP> CBLLBPKMANI, MMBOLDIBAHF<LILDJNMHNBP> EBADFDGGDBH, int BCFPEDLJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2536DE0", Offset = "0x2535BE0", VA = "0x182536DE0", Slot = "5")]
	public bool Equals(BGMMBBADFFD LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2536C50", Offset = "0x2535A50", VA = "0x182536C50", Slot = "0")]
	public override bool Equals(object? JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2536F10", Offset = "0x2535D10", VA = "0x182536F10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class FCMABCONOAP : HOGENKMMIOH, IEquatable<FCMABCONOAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly int OKOBDGEEHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly int GDPABCKHHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2539020", Offset = "0x2537E20", VA = "0x182539020", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2539370", Offset = "0x2538170", VA = "0x182539370")]
	public FCMABCONOAP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, int HOKCNMBCKFK, int IAMIECCGHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2539050", Offset = "0x2537E50", VA = "0x182539050", Slot = "5")]
	public bool Equals(FCMABCONOAP KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2539140", Offset = "0x2537F40", VA = "0x182539140", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2539270", Offset = "0x2538070", VA = "0x182539270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class GMFNAOENHAP : HOGENKMMIOH, IEquatable<GMFNAOENHAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x253BB20", Offset = "0x253A920", VA = "0x18253BB20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x253BDF0", Offset = "0x253ABF0", VA = "0x18253BDF0")]
	public GMFNAOENHAP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x253BC60", Offset = "0x253AA60", VA = "0x18253BC60", Slot = "5")]
	public bool Equals(GMFNAOENHAP KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x253BB50", Offset = "0x253A950", VA = "0x18253BB50", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x253BD30", Offset = "0x253AB30", VA = "0x18253BD30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct FDMDHELILLE : IEquatable<FDMDHELILLE>, DOBJOHBJOOL<FDMDHELILLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly MMBOLDIBAHF<CJABLIIDPAG> JCGMNALMDGI;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x24D6A90", Offset = "0x24D5890", VA = "0x1824D6A90")]
	public FDMDHELILLE([In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<CJABLIIDPAG> NGHFKDBHIPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2539870", Offset = "0x2538670", VA = "0x182539870")]
	public static bool BHDCHHANDIG([In] FDMDHELILLE NMOPBJNEFKL, [In] FDMDHELILLE KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2539910", Offset = "0x2538710", VA = "0x182539910", Slot = "4")]
	public bool Equals(FDMDHELILLE LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2539AF0", Offset = "0x25388F0", VA = "0x182539AF0")]
	public bool KPIKCMFBAIM([In] FDMDHELILLE LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2539930", Offset = "0x2538730", VA = "0x182539930", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2539A60", Offset = "0x2538860", VA = "0x182539A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2539AF0", Offset = "0x25388F0", VA = "0x182539AF0", Slot = "5")]
	private bool NIIDCLBKNHD([In] FDMDHELILLE LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class GEFLPGFJCHO : HOGENKMMIOH, IEquatable<GEFLPGFJCHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly MMBOLDIBAHF<BGEDOHJDFGJ> JLFMJDNJPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly MMBOLDIBAHF<BGEDOHJDFGJ> EKAKMFBPKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly int LCEJMIIMNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x253B190", Offset = "0x2539F90", VA = "0x18253B190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x253B570", Offset = "0x253A370", VA = "0x18253B570")]
	public GEFLPGFJCHO(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, MMBOLDIBAHF<BGEDOHJDFGJ> ALCIAGGHCKP, MMBOLDIBAHF<BGEDOHJDFGJ> AHCJGNKNOLM, int KADNPDEALKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x253B1C0", Offset = "0x2539FC0", VA = "0x18253B1C0", Slot = "5")]
	public bool Equals(GEFLPGFJCHO? LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x253B2F0", Offset = "0x253A0F0", VA = "0x18253B2F0", Slot = "0")]
	public override bool Equals(object? JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x253B480", Offset = "0x253A280", VA = "0x18253B480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class CKPJBMPNICD : HOGENKMMIOH, IEquatable<CKPJBMPNICD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly int CCOGIGENFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly int PBGDPKOEPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2537E40", Offset = "0x2536C40", VA = "0x182537E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2538190", Offset = "0x2536F90", VA = "0x182538190")]
	public CKPJBMPNICD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, int OMCOPIECGLI, int KOBDNDBPPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2537E70", Offset = "0x2536C70", VA = "0x182537E70", Slot = "5")]
	public bool Equals(CKPJBMPNICD KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2537F60", Offset = "0x2536D60", VA = "0x182537F60", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2538090", Offset = "0x2536E90", VA = "0x182538090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LKKOGEPBGEB
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class MIEFPPNINJG
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class DIENIKBHLBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class DJIMMFKAAFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class CHMLMGCOLME
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class BFHGJAMBIOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class LILDJNMHNBP : GGACHNNILCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class KPGCHBLJMLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class LEDHAJOPDGM : EBIDJKPJHII
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class AHIDBKDCADN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class DGKHNPEDJKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class IJHCDMOHIDK
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class GHKMKLCEKGG
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class BGEDOHJDFGJ : GGACHNNILCE
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class BNKJNPHLBPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DIGNAGEOFCF : EBIDJKPJHII
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class GGACHNNILCE
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[OLBEHBOLMGB("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class ECCLNDBJNAE
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class IPGMDHDLEMN : PCJFIJFJEGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class CJABLIIDPAG : PCJFIJFJEGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class PCJFIJFJEGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class EBIDJKPJHII
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class LADPPKLODNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public sealed class CFIPDELBCCO
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public sealed class HMBMMAMLMAL
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class GFPAMBIAPPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class FOFOFLMODIO : HOGENKMMIOH, IEquatable<FOFOFLMODIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public StaticEdge CGFNGFPPPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2539D90", Offset = "0x2538B90", VA = "0x182539D90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2539FC0", Offset = "0x2538DC0", VA = "0x182539FC0")]
	public FOFOFLMODIO(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, [In] StaticEdge JAOFDJMEJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8F4260", Offset = "0x8F3060", VA = "0x1808F4260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2539EA0", Offset = "0x2538CA0", VA = "0x182539EA0", Slot = "5")]
	public bool Equals(FOFOFLMODIO KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2539DC0", Offset = "0x2538BC0", VA = "0x182539DC0", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2539F40", Offset = "0x2538D40", VA = "0x182539F40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class NLPNAAHJCJE : HOGENKMMIOH, IEquatable<NLPNAAHJCJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x25408F0", Offset = "0x253F6F0", VA = "0x1825408F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2540A60", Offset = "0x253F860", VA = "0x182540A60")]
	public NLPNAAHJCJE([In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x25409C0", Offset = "0x253F7C0", VA = "0x1825409C0", Slot = "5")]
	public bool Equals(NLPNAAHJCJE KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2540920", Offset = "0x253F720", VA = "0x182540920", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2540A20", Offset = "0x253F820", VA = "0x182540A20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class HFNFCMPGFBE : HOGENKMMIOH, IEquatable<HFNFCMPGFBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly MMBOLDIBAHF<LILDJNMHNBP> FMCCKADAGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly MMBOLDIBAHF<LILDJNMHNBP> MNCPFJBNDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly int BHLGCGDAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x253D930", Offset = "0x253C730", VA = "0x18253D930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x253DD10", Offset = "0x253CB10", VA = "0x18253DD10")]
	public HFNFCMPGFBE(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, MMBOLDIBAHF<LILDJNMHNBP> CBLLBPKMANI, MMBOLDIBAHF<LILDJNMHNBP> GHGHEBPNELA, int BCFPEDLJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x253DAF0", Offset = "0x253C8F0", VA = "0x18253DAF0", Slot = "5")]
	public bool Equals(HFNFCMPGFBE? LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x253D960", Offset = "0x253C760", VA = "0x18253D960", Slot = "0")]
	public override bool Equals(object? JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x253DC20", Offset = "0x253CA20", VA = "0x18253DC20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class BFIKDEHBOIA : HOGENKMMIOH, IEquatable<BFIKDEHBOIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly int OKOBDGEEHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly int GDPABCKHHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x25363D0", Offset = "0x25351D0", VA = "0x1825363D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2536720", Offset = "0x2535520", VA = "0x182536720")]
	public BFIKDEHBOIA(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, int HOKCNMBCKFK, int IAMIECCGHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2536530", Offset = "0x2535330", VA = "0x182536530", Slot = "5")]
	public bool Equals(BFIKDEHBOIA KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2536400", Offset = "0x2535200", VA = "0x182536400", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2536620", Offset = "0x2535420", VA = "0x182536620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class GAEHFHOFNPI : HOGENKMMIOH, IEquatable<GAEHFHOFNPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x253A310", Offset = "0x2539110", VA = "0x18253A310", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x253A570", Offset = "0x2539370", VA = "0x18253A570")]
	public GAEHFHOFNPI(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x253A430", Offset = "0x2539230", VA = "0x18253A430", Slot = "5")]
	public bool Equals(GAEHFHOFNPI KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x253A340", Offset = "0x2539140", VA = "0x18253A340", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x253A4E0", Offset = "0x25392E0", VA = "0x18253A4E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class ENLLAJFPBLE : HOGENKMMIOH, IEquatable<ENLLAJFPBLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly MMBOLDIBAHF<BGEDOHJDFGJ> JLFMJDNJPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly MMBOLDIBAHF<BGEDOHJDFGJ> JMAJKNJOPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly int LCEJMIIMNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2538690", Offset = "0x2537490", VA = "0x182538690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2538A70", Offset = "0x2537870", VA = "0x182538A70")]
	public ENLLAJFPBLE(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, MMBOLDIBAHF<BGEDOHJDFGJ> ALCIAGGHCKP, MMBOLDIBAHF<BGEDOHJDFGJ> MGIFHAFLFHA, int KADNPDEALKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2538850", Offset = "0x2537650", VA = "0x182538850", Slot = "5")]
	public bool Equals(ENLLAJFPBLE? LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x25386C0", Offset = "0x25374C0", VA = "0x1825386C0", Slot = "0")]
	public override bool Equals(object? JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2538980", Offset = "0x2537780", VA = "0x182538980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class CJIAMOBPEEI : HOGENKMMIOH, IEquatable<CJIAMOBPEEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly int CCOGIGENFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly int PBGDPKOEPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x25375F0", Offset = "0x25363F0", VA = "0x1825375F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2537940", Offset = "0x2536740", VA = "0x182537940")]
	public CJIAMOBPEEI(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, int OMCOPIECGLI, int KOBDNDBPPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2537620", Offset = "0x2536420", VA = "0x182537620", Slot = "5")]
	public bool Equals(CJIAMOBPEEI KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2537710", Offset = "0x2536510", VA = "0x182537710", Slot = "0")]
	public override bool Equals(object? KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2537840", Offset = "0x2536640", VA = "0x182537840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[JOBGNIMLPCB("StaticEdge")]
public readonly struct OJCJNACIJDM : IEquatable<OJCJNACIJDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly MMBOLDIBAHF<BGEDOHJDFGJ> PIAKALLNODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly MMBOLDIBAHF<LILDJNMHNBP> JIACPBAJIFA;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	public OJCJNACIJDM(MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2540BA0", Offset = "0x253F9A0", VA = "0x182540BA0")]
	public void AHAOIMLDBFI([Out] MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, [Out] MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2540BB0", Offset = "0x253F9B0", VA = "0x182540BB0")]
	public static bool BHDCHHANDIG(OJCJNACIJDM PMKFIDCMLAN, OJCJNACIJDM BFOIKIBAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2540C30", Offset = "0x253FA30", VA = "0x182540C30", Slot = "4")]
	public bool Equals(OJCJNACIJDM LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2540C40", Offset = "0x253FA40", VA = "0x182540C40", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2540CD0", Offset = "0x253FAD0", VA = "0x182540CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class GBAAAHHALBP : HOGENKMMIOH, IEquatable<GBAAAHHALBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly int JOLBCKOLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly int GPDIDLNABFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly int IPPLMLFGIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x253A8A0", Offset = "0x25396A0", VA = "0x18253A8A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x253AC00", Offset = "0x2539A00", VA = "0x18253AC00")]
	public GBAAAHHALBP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, int EOMNAFKKHMK, int LIODDANOJBI, int GNBKNBOPDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x253AA00", Offset = "0x2539800", VA = "0x18253AA00", Slot = "5")]
	public bool Equals(GBAAAHHALBP KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x253A8D0", Offset = "0x25396D0", VA = "0x18253A8D0", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x253AAF0", Offset = "0x25398F0", VA = "0x18253AAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class AGBDOJAHPDC : HOGENKMMIOH, IEquatable<AGBDOJAHPDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly int JOLBCKOLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly int JBEHAMKPOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly int EGDDAEBGNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string FGCCOGHIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2535AE0", Offset = "0x25348E0", VA = "0x182535AE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2535E40", Offset = "0x2534C40", VA = "0x182535E40")]
	public AGBDOJAHPDC(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF, int EOMNAFKKHMK, int HCBKNKICBFJ, int IJGBFEFHDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2535C40", Offset = "0x2534A40", VA = "0x182535C40", Slot = "5")]
	public bool Equals(AGBDOJAHPDC KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2535B10", Offset = "0x2534910", VA = "0x182535B10", Slot = "0")]
	public override bool Equals(object KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2535D30", Offset = "0x2534B30", VA = "0x182535D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct LCKCLOMHBDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> PDOHPOGFNLH;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x105A210", Offset = "0x1059010", VA = "0x18105A210")]
	public LCKCLOMHBDD([In] HFJNFIGGNLC<AHIDBKDCADN> CNJKHDLCDHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate void LFPHICKFGLN([In] FCGHFACELGK BLCLLKNOJLD);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		List,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		StateTransition
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public delegate void HKDIIGLBIGC([In] NFJHFHNDCLG ANBHGIAIIEJ);
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum HEPJDFKAIEG
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Versioning,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	NodesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SyncedVariablesNotAllowedInTargetGraphOrDescendents
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct EILAKDKEEJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly GIOJMNNFGKM FFOHBKFGAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly GIOJMNNFGKM BMFMBKAPGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly GIOJMNNFGKM OMAGNPJIKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly GIOJMNNFGKM NENBEEGJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly GIOJMNNFGKM NILOIAKAKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly GIOJMNNFGKM IBGAJLOEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly GIOJMNNFGKM KOIHDGKCLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly GIOJMNNFGKM AMMOEPOKKMB;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0xC218A0", Offset = "0xC206A0", VA = "0x180C218A0")]
	public EILAKDKEEJE(GIOJMNNFGKM EKIDKHHJPHL, GIOJMNNFGKM AKLBHCLHDOJ, GIOJMNNFGKM DFDPFKADDLD, GIOJMNNFGKM EDHIANIFHCF, GIOJMNNFGKM BDKALFGLHNM, GIOJMNNFGKM ODACEIKOKKB, GIOJMNNFGKM OODPKLAFMMP, GIOJMNNFGKM EDAHAPFCLBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate void NDKNNIOJFFN([In] GGLODEGCHGH OCGOOLKPBNF);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct MCCJOLAKNPC : IEquatable<MCCJOLAKNPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> ENJFJHOGAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly MMBOLDIBAHF<DIGNAGEOFCF> PJBCCNIBHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly HFJNFIGGNLC<AHIDBKDCADN> HPBGAIJOELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly MMBOLDIBAHF<LEDHAJOPDGM> KCCIGOMMLMC;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2540860", Offset = "0x253F660", VA = "0x182540860")]
	public MCCJOLAKNPC([In] HFJNFIGGNLC<AHIDBKDCADN> DBBCHEAOGIC, MMBOLDIBAHF<DIGNAGEOFCF> MJBOOFLDCKG, [In] HFJNFIGGNLC<AHIDBKDCADN> GDBBFGKBDOC, MMBOLDIBAHF<LEDHAJOPDGM> MAAPOPHPBJC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2540210", Offset = "0x253F010", VA = "0x182540210")]
	public static bool BHDCHHANDIG([In] MCCJOLAKNPC PMKFIDCMLAN, [In] MCCJOLAKNPC BFOIKIBAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x25402D0", Offset = "0x253F0D0", VA = "0x1825402D0", Slot = "4")]
	public bool Equals(MCCJOLAKNPC LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2540390", Offset = "0x253F190", VA = "0x182540390", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2540440", Offset = "0x253F240", VA = "0x182540440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x25404F0", Offset = "0x253F2F0", VA = "0x1825404F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct NCHJKEEPIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly int IMBONKMLLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly int GKAPEEDHPCP;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	public NCHJKEEPIJI(int DPJJCDKFBGJ, int JAIIEOHFKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2540880", Offset = "0x253F680", VA = "0x182540880")]
	public DNLIDGIMHBI NPIKEPIONAB()
	{
		return null;
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly HFJNFIGGNLC<AHIDBKDCADN> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly MMBOLDIBAHF<ECCLNDBJNAE> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly MMBOLDIBAHF<CJABLIIDPAG> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly HFJNFIGGNLC<AHIDBKDCADN> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly MMBOLDIBAHF<ECCLNDBJNAE> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly MMBOLDIBAHF<IPGMDHDLEMN> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2541CF0", Offset = "0x2540AF0", VA = "0x182541CF0")]
		public StaticEdge([In] HFJNFIGGNLC<AHIDBKDCADN> DBBCHEAOGIC, MMBOLDIBAHF<ECCLNDBJNAE> FMPEABPDAOD, MMBOLDIBAHF<CJABLIIDPAG> KJCLPMFDKKN, [In] HFJNFIGGNLC<AHIDBKDCADN> GDBBFGKBDOC, MMBOLDIBAHF<ECCLNDBJNAE> CDAHNILGJIE, MMBOLDIBAHF<IPGMDHDLEMN> FAALNIJAOGF)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x25415B0", Offset = "0x25403B0", VA = "0x1825415B0")]
		public static bool BHDCHHANDIG([In] StaticEdge PMKFIDCMLAN, [In] StaticEdge BFOIKIBAAFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2541750", Offset = "0x2540550", VA = "0x182541750", Slot = "4")]
		public bool Equals(StaticEdge LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x25416A0", Offset = "0x25404A0", VA = "0x1825416A0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2541770", Offset = "0x2540570", VA = "0x182541770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2541860", Offset = "0x2540660", VA = "0x182541860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class PNEIBFPODPE
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2541000", Offset = "0x253FE00", VA = "0x182541000")]
	public static StaticEdge FEIAPADJKML(this EBPOIEPBGHG DJAJDIFOIHP)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct PMDJMPOCMMH : IEquatable<PMDJMPOCMMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly string EEDBDNGPHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly int NBJLIDHOAPD;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0xAFEA80", Offset = "0xAFD880", VA = "0x180AFEA80")]
	public PMDJMPOCMMH(string IHNBODLLFGB, int LNMGAHCLFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2540FB0", Offset = "0x253FDB0", VA = "0x182540FB0", Slot = "4")]
	public bool Equals(PMDJMPOCMMH LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct POEHCMFONGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly string HIGBIGGFHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly MBENAOEANHN.IMIBHMJNIFK.OMMJDLJLDJL FPKIFMABMAF;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0xAFEA80", Offset = "0xAFD880", VA = "0x180AFEA80")]
	public POEHCMFONGN(string PPKJBGAOBJL, MBENAOEANHN.IMIBHMJNIFK.OMMJDLJLDJL KDMNBHEDIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x25411D0", Offset = "0x253FFD0", VA = "0x1825411D0")]
	internal static POEHCMFONGN FEIAPADJKML(MBENAOEANHN JOAPLPPIFPC)
	{
		return default(POEHCMFONGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2541290", Offset = "0x2540090", VA = "0x182541290")]
	internal MBENAOEANHN NPIKEPIONAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2541220", Offset = "0x2540020", VA = "0x182541220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2541120", Offset = "0x253FF20", VA = "0x182541120", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2540FB0", Offset = "0x253FDB0", VA = "0x182540FB0")]
	public bool DJBOHCAMMCM(POEHCMFONGN LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2541300", Offset = "0x2540100", VA = "0x182541300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct HBBICMCFMLK : IEquatable<HBBICMCFMLK>
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly IReadOnlyDictionary<HFJNFIGGNLC<GFPAMBIAPPA>, PMDJMPOCMMH> ENIFMGEEIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly LIPFIFNIDGI ABCNJJCINPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string LKLGNIDHKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly IReadOnlyDictionary<HFJNFIGGNLC<GFPAMBIAPPA>, PMDJMPOCMMH> GKMICLIOIKK;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x253D340", Offset = "0x253C140", VA = "0x18253D340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x253D880", Offset = "0x253C680", VA = "0x18253D880")]
	public HBBICMCFMLK(LIPFIFNIDGI MKBNDNKEIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x253D5F0", Offset = "0x253C3F0", VA = "0x18253D5F0")]
	public HBBICMCFMLK(LIPFIFNIDGI MKBNDNKEIEI, IReadOnlyDictionary<HFJNFIGGNLC<GFPAMBIAPPA>, PMDJMPOCMMH> DDACMOFOOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x253CA40", Offset = "0x253B840", VA = "0x18253CA40")]
	public static HBBICMCFMLK IGOLHEJNIIF(HBBICMCFMLK KIMANIPEJIH, HBBICMCFMLK FPHDNHBGJOB)
	{
		return default(HBBICMCFMLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x253C610", Offset = "0x253B410", VA = "0x18253C610")]
	public static HBBICMCFMLK FEIAPADJKML(MOECMFABDFM JOAPLPPIFPC)
	{
		return default(HBBICMCFMLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x253D3C0", Offset = "0x253C1C0", VA = "0x18253D3C0")]
	public MOECMFABDFM NPIKEPIONAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x253C1B0", Offset = "0x253AFB0", VA = "0x18253C1B0", Slot = "4")]
	public bool Equals(HBBICMCFMLK LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct LIPFIFNIDGI : IEquatable<LIPFIFNIDGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string HIGBIGGFHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public readonly IReadOnlyList<POEHCMFONGN> NPNHDLGHJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public readonly IReadOnlyList<POEHCMFONGN> IEAAMABLIIJ;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x253FAD0", Offset = "0x253E8D0", VA = "0x18253FAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2419D20", Offset = "0x2418B20", VA = "0x182419D20")]
	public LIPFIFNIDGI(string PPKJBGAOBJL, IReadOnlyList<POEHCMFONGN> EPHBHIHACKN, IReadOnlyList<POEHCMFONGN> HIPEDBFNJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x253F590", Offset = "0x253E390", VA = "0x18253F590")]
	public static LIPFIFNIDGI FEIAPADJKML(GHDEKOPHEAG JOAPLPPIFPC)
	{
		return default(LIPFIFNIDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x253FAF0", Offset = "0x253E8F0", VA = "0x18253FAF0")]
	public GHDEKOPHEAG NPIKEPIONAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x253F870", Offset = "0x253E670", VA = "0x18253F870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x253F8F0", Offset = "0x253E6F0", VA = "0x18253F8F0")]
	private static int JMFKNFHPJAP(IReadOnlyList<POEHCMFONGN> CKGPCMDHAPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x253F4E0", Offset = "0x253E2E0", VA = "0x18253F4E0", Slot = "4")]
	public bool Equals(LIPFIFNIDGI LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x253FD80", Offset = "0x253EB80", VA = "0x18253FD80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum MGDGAGBKOEK
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class AJLJBHJFJAC
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1062F10", Offset = "0x1061D10", VA = "0x181062F10")]
	public static bool DHCNCHFGLOM(this MGDGAGBKOEK ADJDIHDFFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1062F10", Offset = "0x1061D10", VA = "0x181062F10")]
	public static bool JNOCNBAJPJK(this MGDGAGBKOEK ADJDIHDFFBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public enum PHHDDAMPDOJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct FCGHFACELGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly bool JOJIJPGPEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly PHHDDAMPDOJ FBOADJCFJMF;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x14F9030", Offset = "0x14F7E30", VA = "0x1814F9030")]
	public FCGHFACELGK(bool HGOLLEOONGL, PHHDDAMPDOJ KCCGJLHCMCK)
	{
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		Color
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
