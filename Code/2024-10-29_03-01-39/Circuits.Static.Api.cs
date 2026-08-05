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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x2303220", Offset = "0x2302220", VA = "0x182303220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct IKHKKILINMA : IEquatable<IKHKKILINMA>, PLNBPIMMAIH<IKHKKILINMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly FCEODKAEDJI<OAOFJLCKBCA> DOKOJPMHKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly FCEODKAEDJI<JIHNPCGMGAN> FMGDKHMOOHG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22FBDF0", Offset = "0x22FADF0", VA = "0x1822FBDF0")]
	public IKHKKILINMA([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<JIHNPCGMGAN> CIFBOLGGHDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23005E0", Offset = "0x22FF5E0", VA = "0x1823005E0")]
	public static bool LJMKDDBNEAO([In] IKHKKILINMA LOPBCKBMJBH, [In] IKHKKILINMA BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2300430", Offset = "0x22FF430", VA = "0x182300430", Slot = "4")]
	public bool Equals(IKHKKILINMA DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2300510", Offset = "0x22FF510", VA = "0x182300510")]
	public bool OCBJJFACBHD([In] IKHKKILINMA DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2300450", Offset = "0x22FF450", VA = "0x182300450", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2300520", Offset = "0x22FF520", VA = "0x182300520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2300510", Offset = "0x22FF510", VA = "0x182300510", Slot = "5")]
	private bool FGBMCKBEBHO([In] IKHKKILINMA DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DPKDDFHGADN : IEquatable<DPKDDFHGADN>, PLNBPIMMAIH<DPKDDFHGADN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly FCEODKAEDJI<OAOFJLCKBCA> DOKOJPMHKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly FCEODKAEDJI<IAIFMMANJAN> LEDAHONGDFM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x22FBDF0", Offset = "0x22FADF0", VA = "0x1822FBDF0")]
	public DPKDDFHGADN([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<IAIFMMANJAN> HGMJLJCBGOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22FBD30", Offset = "0x22FAD30", VA = "0x1822FBD30")]
	public static bool LJMKDDBNEAO([In] DPKDDFHGADN LOPBCKBMJBH, [In] DPKDDFHGADN BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22FBB80", Offset = "0x22FAB80", VA = "0x1822FBB80", Slot = "4")]
	public bool Equals(DPKDDFHGADN DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22FBC60", Offset = "0x22FAC60", VA = "0x1822FBC60")]
	public bool OCBJJFACBHD([In] DPKDDFHGADN DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x22FBBA0", Offset = "0x22FABA0", VA = "0x1822FBBA0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x22FBC70", Offset = "0x22FAC70", VA = "0x1822FBC70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x22FBC60", Offset = "0x22FAC60", VA = "0x1822FBC60", Slot = "5")]
	private bool FBFCIFGFBLD([In] DPKDDFHGADN DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GKNAKDLBECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x99A6C0", Offset = "0x9996C0", VA = "0x18099A6C0")]
	public GKNAKDLBECE(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ILFCNFBBFBO
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
public readonly struct LBBHHBKMHGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly FIJCKAEAPLG LENDAJAKEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly IPDJNLFCKDA OCGGMLLGPII;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23018A0", Offset = "0x23008A0", VA = "0x1823018A0")]
	public LBBHHBKMHGF([In] FIJCKAEAPLG EBLANDLJNLN, IPDJNLFCKDA NMDHLPMFPLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FIJCKAEAPLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly DPJKEOMANBI CNAIIOMAKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly JPOKLPJBGMB MJDENGBLDMN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	public FIJCKAEAPLG(DPJKEOMANBI FPJMEHOOLHE, JPOKLPJBGMB GDKIBLCBODF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct IPDJNLFCKDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DPOFJEJGEFI NHMLELBHODB;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public IPDJNLFCKDA(DPOFJEJGEFI FEEPKIMPGIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KEIFAHMIGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly OANNEOPDIHC FPJDFOIMKPI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public KEIFAHMIGDI(OANNEOPDIHC IOIDKPLMNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum DLEAPOLBNAL
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
public enum HBMLAOAKPPE
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
public readonly struct MPOOPGKGMDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly string OPOPEPNBFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string ACOBLDEOGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly string FKHGGFEIOAM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21E39D0", Offset = "0x21E29D0", VA = "0x1821E39D0")]
	public MPOOPGKGMDJ(string DNAAKFFMGNB, string IFCMLHELLJE, string ADACKLCLFCN)
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
public interface CPMDGFFHIND : PFDHHIHKKHP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string AGHOEOAGDLA, Action<string, float> FDCIHHNONHE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ODAIEDCEJFJ : BJNHBEDOFDB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFCLGNCLGDD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PFDHHIHKKHP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KLNACLEPDMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FDADFNLPHKN
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MGMBKPNKILE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JHOJJNEENJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DLGAHPAEBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HJAFAIJJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NNPOGLKAKEH : BJNHBEDOFDB
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPFOFHIGBEE(BJNHBEDOFDB EEGMMPFLDLP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGPGCHCMHIK();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAKBCGBONLK(BJNHBEDOFDB EEGMMPFLDLP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FMBJCGHGOGL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJKHJGEBNCP(string NNOOJKIHBIA, Func<string> LJMALFBHHKD, Action<string> OPNGHNCEKPN, Func<bool> OABJFAKHIMC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKOLLCPIJIL(string NNOOJKIHBIA, Action CDLMHGHIGNB, Func<bool> OABJFAKHIMC);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEJPLKJNJFJ(string NNOOJKIHBIA, Func<int> KKEFNALBDFB, Action<int> AAKJBAIEIKM, Func<bool> OABJFAKHIMC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLAKIAOGGJM(string NNOOJKIHBIA, Func<int> LJMALFBHHKD, Action<int> OPNGHNCEKPN, Func<bool> OABJFAKHIMC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGFNPEKLLKD(string NNOOJKIHBIA, Func<object> FJJJBJMDINJ, Action<object> FDPFNJCLDLG, Func<object, string> DHPAGBGKDNL, Func<bool> OABJFAKHIMC, Type NFICGGNDBHN, IReadOnlyList<object> GPDGDJIJGME);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPFKCNGNHMA(string NNOOJKIHBIA, Func<string> LJMALFBHHKD, Action<string> OPNGHNCEKPN, Func<bool> OABJFAKHIMC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BOIKIBBELLH(string NNOOJKIHBIA, Func<bool> LJMALFBHHKD, Action<bool> OPNGHNCEKPN, Func<bool> OABJFAKHIMC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IHMICECIEIN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface CGIHIODLHDF
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Action<IHMICECIEIN>? FINCNIIADLP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		Action<IHMICECIEIN>? KDFJDCAOJBD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BJNHBEDOFDB EPGJNLOMAFH(Func<bool> FCHOGNIKEOL, Action<bool> MBDMEDLEPFO, Func<byte> MFMAFCEOKMA, Action<byte> ADAKEKNGEBE, Func<int> DAMPIHMLIJN, Action<int> JEBOFDDHEIK, Func<IReadOnlyList<string>> LFJBKEENDPK, Action<IReadOnlyList<string>> GCHLHBDPIKE, [Optional] Func<IReadOnlyList<string>>? BINEHGELPPJ, [Optional] Action<IReadOnlyList<string>>? FHPCNDHGBIG, [Optional] Func<bool>? OABJFAKHIMC);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NEOHHEGCPNN();
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CGIHIODLHDF PGNGNEOCJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BJNHBEDOFDB OMIIOIBKOBF(Action CDLMHGHIGNB, string NNOOJKIHBIA = "", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BJNHBEDOFDB FNPIDABBDGD(IReadOnlyList<BJNHBEDOFDB> KKKPLHGNHMJ, [Optional] float? PGCIKKGNGDI, [Optional] int? FEBHBDHIBOI, [Optional] bool? NPJAHOEJDMH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BJNHBEDOFDB IEKNKOALJPP(IReadOnlyList<BJNHBEDOFDB> KKKPLHGNHMJ, [Optional] float? PGCIKKGNGDI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BJNHBEDOFDB KCOFAKKMJDB(Func<int> KKEFNALBDFB, Action<int> AAKJBAIEIKM, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, bool BDCIGAHBHPI = false, string NNOOJKIHBIA = "Color", [Optional] Func<bool>? DBOGMDIPFJD, bool NMJFIAOEHLD = true, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BJNHBEDOFDB NOHCBBOCNAE(Action CDLMHGHIGNB, string NNOOJKIHBIA = "", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BJNHBEDOFDB MOBCALJELOC(Func<long> PCJPIBPAFCC, Action<long> AFHAMGPKDLO, string HMAHOHOPDIO = "Choose Event", string ECKBAPBNJCN = "Choose Event", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<CancellationToken>? OMELDKNFCGE);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BJNHBEDOFDB KMAHLIKGBIM(Func<GGKCCFNJFJC<OMEMEDNNNNN>> FIGONCCFIAE, Func<int> JEJAIDKIBOO, [Optional] Func<bool>? OABJFAKHIMC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BJNHBEDOFDB FGLFOLBOHKE(BJNHBEDOFDB EEGMMPFLDLP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NNPOGLKAKEH FLFBEAPBCNG(int IPAOJGBKAGO, string NNOOJKIHBIA, string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] List<BJNHBEDOFDB>? KKKPLHGNHMJ, [Optional] Func<bool>? OABJFAKHIMC, bool GPBBGPPKAHP = true, [Optional] Func<bool>? HDEPHNKKHEC, [Optional] Action<bool>? FAPAPEJKIOB, [Optional] float? KNOPENLFDJF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BJNHBEDOFDB HNGCIJDAOMI(string JCLHICKJKAC, [Optional] Func<string?>? EOKGEACAIBM, [Optional] Func<bool>? OABJFAKHIMC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BJNHBEDOFDB FHAKDOGBDJP(Func<string> LJMALFBHHKD, Action<string> OPNGHNCEKPN, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] int? LAMKALGLCHK, bool ELFBHBJBNPE = false, string NNOOJKIHBIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BJNHBEDOFDB GDLEPMELBJP(Func<float> LJMALFBHHKD, Action<float> OPNGHNCEKPN, string NNOOJKIHBIA = "", string MHPGNIDAFIA = "", string NCBDDCNHKCK = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", bool GBKLKHBJKKJ = false, float LJEKIICEOAB = 0f, float APNBJOGJHKH = 1000f, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BJNHBEDOFDB MNAKAFHPGFH(Func<int> LJMALFBHHKD, Action<int> OPNGHNCEKPN, string NNOOJKIHBIA = "", [Optional] Func<string>? LNBLBHMGJMP, string MHPGNIDAFIA = "", [Optional] Func<string>? BLGALLFJIMJ, string NCBDDCNHKCK = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", bool GBKLKHBJKKJ = false, int LJEKIICEOAB = 0, int APNBJOGJHKH = 1000, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BJNHBEDOFDB CGDNHBPPHEL(Type NFICGGNDBHN, IReadOnlyList<object> GPDGDJIJGME, Func<object> FJJJBJMDINJ, Action<object> FDPFNJCLDLG, string NNOOJKIHBIA = "", string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<object, string>? DHPAGBGKDNL, bool JCMLDDGOABA = true, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BJNHBEDOFDB INJCELKOGDF(Func<string> LJMALFBHHKD, Action<string> OPNGHNCEKPN, int GDBAJDACCMG = 1000, HBMLAOAKPPE JGMDJNCCPDP = HBMLAOAKPPE.Alphanumeric, [Optional] Func<string, bool>? OMNBPAFHDJH, [Optional] string? OEKPLHPBIGO, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, string NNOOJKIHBIA = "", string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", bool ELFBHBJBNPE = false, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true, float AKOBEOFBKPO = 0f);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BJNHBEDOFDB IHJCOAEMIEK(Func<float> LJMALFBHHKD, Action<float> OPNGHNCEKPN, float LJEKIICEOAB = 0f, float APNBJOGJHKH = 1000f, [Optional] Func<bool>? JPEGIGGCPIC, int GJHAPLMJCBL = -1, string NNOOJKIHBIA = "", string MHPGNIDAFIA = "", string NCBDDCNHKCK = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Func<float, float>? MCOMDPBKEHH, [Optional] Func<float, float>? CMGIGDNNHMO, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BJNHBEDOFDB HMPLDEKBGEP(Func<string> LJMALFBHHKD, Action<string> OPNGHNCEKPN, Action CDLMHGHIGNB, [Optional] Func<bool>? OABJFAKHIMC, HBMLAOAKPPE JGMDJNCCPDP = HBMLAOAKPPE.Alphanumeric, [Optional] Func<string, bool>? OMNBPAFHDJH, DLEAPOLBNAL BPPODLEGJOK = DLEAPOLBNAL.Alphanumeric, [Optional] string? OEKPLHPBIGO, [Optional] List<BJNHBEDOFDB>? IAJEPMCKBGD, string NNOOJKIHBIA = "", string KDOGLBPGGOG = "", string EBLBAENNIAC = "", string BFNKKIHKACM = "", bool IKKNIDEABGC = true, float AKOBEOFBKPO = 0f);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	BJNHBEDOFDB NKMKCNCKGKB(Func<string> LJMALFBHHKD, Action<string> OPNGHNCEKPN, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] int? LAMKALGLCHK, bool ELFBHBJBNPE = false, string NNOOJKIHBIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	BJNHBEDOFDB PIIMJGBLHCB(Func<bool> LJMALFBHHKD, Action<bool> OPNGHNCEKPN, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, string NNOOJKIHBIA = "", string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] int? IPAOJGBKAGO, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BJNHBEDOFDB OCMNAKMKODE(Func<bool> LJMALFBHHKD, Action<bool> OPNGHNCEKPN, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, string NNOOJKIHBIA = "", string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] int? IPAOJGBKAGO, [Optional] Func<bool>? DBOGMDIPFJD, [Optional] Func<bool>? KBPAPACHPNN, string JLBCBCBCDNA = "", [Optional] Func<string>? OLMJMLLHMOL, string GADJDHFPAMI = "", [Optional] Func<string>? KFPLOHPMMIL, bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "21")]
	ODAIEDCEJFJ PCDAKGMPDDB(Dictionary<string, GBEIEIMAINC> LNLOCMMGLOB, Func<int> KKEFNALBDFB, Action<int> AAKJBAIEIKM, string NNOOJKIHBIA, string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Action? EJPMAHOIOMC, [Optional] Action? FIHINCLGEGE, [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<int, string>? KJFFONOCILF, bool JCMLDDGOABA = true, bool BEEMAEMOHCN = true, bool IKKNIDEABGC = true, bool EPDBHFJFEEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "22")]
	ODAIEDCEJFJ HDMOLHIKAGB(Func<Dictionary<string, GBEIEIMAINC>> CLJFPBIDKHL, Func<int> KKEFNALBDFB, Action<int> AAKJBAIEIKM, string NNOOJKIHBIA, string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<bool>? NGLCDGLDBFI, [Optional] Func<int, string>? KJFFONOCILF, bool JCMLDDGOABA = true, bool BEEMAEMOHCN = true, bool IKKNIDEABGC = true, bool EPDBHFJFEEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BJNHBEDOFDB ACOGBDDHOBE(Func<IReadOnlyList<KeyValuePair<string, GBEIEIMAINC>>> CLJFPBIDKHL, Func<int> KKEFNALBDFB, Action<int> AAKJBAIEIKM, string NNOOJKIHBIA, string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<bool>? NGLCDGLDBFI, [Optional] Func<int, string>? KJFFONOCILF, [Optional] Action? EJPMAHOIOMC, [Optional] Action? FIHINCLGEGE, bool JCMLDDGOABA = true, bool BEEMAEMOHCN = true, bool IKKNIDEABGC = true, bool EPDBHFJFEEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BJNHBEDOFDB HIAHAAODGLO(Func<List<object>> CLJFPBIDKHL, Func<object> FJJJBJMDINJ, Action<object> FDPFNJCLDLG, Func<object, string> DHPAGBGKDNL, string NNOOJKIHBIA = "", string MHPGNIDAFIA = "", string KDOGLBPGGOG = "", string PBBCGJOBJFI = "", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, bool JCMLDDGOABA = true, bool IKKNIDEABGC = true, bool EPDBHFJFEEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BJNHBEDOFDB KKNIKBMDEDF(string NNOOJKIHBIA, Func<object> FJJJBJMDINJ, Action<object> FDPFNJCLDLG, Func<object, string> DHPAGBGKDNL, Func<IReadOnlyList<object>> NAJMPFDFKGJ, [Optional] Func<bool>? OABJFAKHIMC, bool EPDBHFJFEEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DDAKODJKIHH(BJNHBEDOFDB EEGMMPFLDLP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ECJIFALCMBP(string PBAIPGILELL, Action? GLEOANFILPA, string DHHPLJJFFNO, Action? GJKIIPELLBK, string ABHPFCOODAJ, string BNGCOHPPGBN);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MFJEINECABO(Func<string> LJMALFBHHKD, Action<string> OPNGHNCEKPN, Action CDLMHGHIGNB, [Optional] Func<bool>? OABJFAKHIMC, HBMLAOAKPPE JGMDJNCCPDP = HBMLAOAKPPE.Alphanumeric, [Optional] Func<string, bool>? OMNBPAFHDJH, DLEAPOLBNAL BPPODLEGJOK = DLEAPOLBNAL.Alphanumeric, [Optional] string? OEKPLHPBIGO, [Optional] List<BJNHBEDOFDB>? IAJEPMCKBGD, string NNOOJKIHBIA = "", string KDOGLBPGGOG = "", string EBLBAENNIAC = "", string BFNKKIHKACM = "", bool IKKNIDEABGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BBGHEKIJDPB(string PGGEHAIBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "30")]
	BJNHBEDOFDB HHDOIEBIEFF(List<object> LNLOCMMGLOB, List<string> DHPAGBGKDNL, Func<int> KKEFNALBDFB, Action<int> AAKJBAIEIKM, string JMIKPHEKECG = "", [Optional] Func<bool>? OABJFAKHIMC, [Optional] Func<bool>? BLLAOJMFOOP, [Optional] Func<bool>? DBOGMDIPFJD, bool IKKNIDEABGC = true, bool PEFJDPMEILD = false);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BJNHBEDOFDB
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AGBDGPANEPP
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAGOMJPDJHO();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PDPLHJCEOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBGCIAAMIJC();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHNKGDJLDNH(string DFAECDKEHHP, [In] IGNHFMPOJGB DANHKIEIFNH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNPFHHMOJBO(string ABHPFCOODAJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHEEMJOCJOC(string JCLHICKJKAC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EOAIFLFPKCG : FGHJECBDJBN, HJOFKELFHOB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JEKPODOGHBG BMBBEAGMMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KLBDKKAHFNE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PGAICCCDHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NCKLNBNPPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JKCPCKPMPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LMDAGIOAMHK(Guid LCBAMHDJINP);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MCNJNCAEPHO(EHGCIDBIDGP CONAFKKIHKL, IReadOnlyDictionary<GGKCCFNJFJC<OMEMEDNNNNN>, Guid>? CBHKPNLHBJG, bool CIOFBOJGFLM);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BCCACOGKMHN(Guid LCBAMHDJINP);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JBIFKIPJFLO(Guid LCBAMHDJINP);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DHJGMDOIJMN(GGKCCFNJFJC<EHIJNIOBBMM> LCBAMHDJINP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HIOHKLHBHOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GMNAMPPAFMB? LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IFHMNCPJANH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HMNKLCPPBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<GMNAMPPAFMB> AELHCLBLGLO();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OBFFLKDLIBJ<FIJCKAEAPLG, HJOFKELFHOB> CAOFHKIIFKB([In] FIJCKAEAPLG OAGAMDMLKKI, IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH, int HNNDCDNFMNM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OFMKKFHHLEK
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnEdgeDidAdd(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnEdgeWillRemove(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJPJALECGJK(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnFunctionDeclsRefreshed();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnEditGraphDidPush();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnEditGraphDidPop();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GMNAMPPAFMB
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct FLEEKDMOBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly PHBDFBFLGBL PHECLDPHCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly bool KPJGOMLLGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly KEIFAHMIGDI EGGALFGDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly IEnumerable<KGIKLNIIDMO> HLDFECFFBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly bool MNGPGEPGGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly GGKCCFNJFJC<OMEMEDNNNNN> DPNNAKFJNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly int? ILMCMKCBCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly AMGGLIGKMHC? FHKECHOLKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly AMGGLIGKMHC? IGABEOMPDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly GKELPECPCNF? ELMBKJGCOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x22FE890", Offset = "0x22FD890", VA = "0x1822FE890")]
		public FLEEKDMOBGG(PHBDFBFLGBL IANLAEECIJK, bool INNCGDPINKB, [In] KEIFAHMIGDI OAGAMDMLKKI, IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH, bool HLALKKOCMBI, [In] GGKCCFNJFJC<OMEMEDNNNNN> GNAKPJEGJEN, int? CLMJKKBMPNJ, [In] AMGGLIGKMHC? MEDGOMBLEGL, [In] AMGGLIGKMHC? KKEFCBIIJPH, [In] GKELPECPCNF? AKONCNONFEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct GKELPECPCNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly IReadOnlyCollection<ByteString> IEHNPGNDBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly IReadOnlyCollection<ByteString> IFOJPAAGDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly IReadOnlyCollection<ByteString> EJKCCNGCANF;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x21E39D0", Offset = "0x21E29D0", VA = "0x1821E39D0")]
		public GKELPECPCNF(IReadOnlyCollection<ByteString> OFMLKJAHINA, IReadOnlyCollection<ByteString> PPFIILNLHKB, IReadOnlyCollection<ByteString> DOGLPAMEOAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct IKCJMMMLOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly KEIFAHMIGDI EGGALFGDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly IReadOnlyDictionary<Guid, Guid> NEPBBEGFNMO;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x23003F0", Offset = "0x22FF3F0", VA = "0x1823003F0")]
		public IKCJMMMLOEG(KEIFAHMIGDI OAGAMDMLKKI, IReadOnlyDictionary<Guid, Guid> ECBPGCLKACA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GGKCCFNJFJC<OMEMEDNNNNN> ELHJLCPALNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IBINMGAJJHI JACJEOGKLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, bool) CANKHHEHCEA(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JMMPIFPOPHJ(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] HIKLHIHFALH PLNNKOJNAED);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LIBKFOHFDOP(MMIDPNEOGKG EEFLJODFNKM);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LHDIAKOOIAE(BOAGOIHOCGF BMKEMECOFMB);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IKHKKILINMA? MDKGIKAHLKB(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DPKDDFHGADN? EFHPAHCBDFI(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<FCEODKAEDJI<EEENFPNJEIF>> HENBNOJDAIE();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string MKLPOLKHLDI(FCEODKAEDJI<EEENFPNJEIF> MNBBIIOGDOD);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string DEIGEOHGNOC(FCEODKAEDJI<EEENFPNJEIF> MNBBIIOGDOD);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BOOIFAHNHOE? CAEMKJBEMGG([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FCEODKAEDJI<OMEMEDNNNNN> PCJHLDODIBF([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FCEODKAEDJI<OMEMEDNNNNN>? OLLIBOBPGJF([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NAOHBAGGJLN? ILHPBGKBOKP([In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FCEODKAEDJI<IMDHLBELCNK> GJHJJINDAGI(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<NLABAOACMJG> GMOPLLNHLOB(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BKAJMFMPPBC(FCEODKAEDJI<EEENFPNJEIF> MNBBIIOGDOD);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IEnumerable<HIKLHIHFALH> HJAJOLLOKIG(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IEnumerable<HIKLHIHFALH> ONOAJOBKOMN(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IEnumerable<NAOHBAGGJLN> ENPEJCFFIOL([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	FCEODKAEDJI<IDMOAGMBHCD> PIKDNMBINLF(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OOEPOIHBEEC> KLCJBCDLHHJ);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	FCEODKAEDJI<IMDHLBELCNK> KFPKIJNLHDP(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	FCEODKAEDJI<IMDHLBELCNK> PJEDFIEPEHB(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FCEODKAEDJI<DJNGCDCAKKJ> BEANJDGDAIM(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<MHCMNEOALJM> HDFKMLJJHIN);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IEnumerable<HFDGOBILPDJ> CJJFOLPAOEI(CBOIOFDJHEI HKLHPGCGGEO, bool GFJMDLGCFKF, bool MJPLPIKJCMP, bool JIEAFJLJDNH, bool LNBMKDNMOPH);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HFDGOBILPDJ LAENENNHPOG(CBOIOFDJHEI HKLHPGCGGEO, ABNPAAPNOHH MAFFFNNDKNN, bool GFJMDLGCFKF, bool MJPLPIKJCMP, bool JIEAFJLJDNH, bool LNBMKDNMOPH);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NLABAOACMJG EDEEFMJJPIC(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] HIKLHIHFALH PLNNKOJNAED);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GGKCCFNJFJC<OMEMEDNNNNN> IJAFKONEBBE(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HIKLHIHFALH NILDEFONEAM(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool AFOCKOPFPFA(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool GIANGPPEBMP(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool EEFGEBJDNMH(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "33")]
	OBFFLKDLIBJ<IKCJMMMLOEG, EOAIFLFPKCG> AHGNEIGHNCP([In] FLEEKDMOBGG NABJMDALPIF);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> FKAJCDGMFJD(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	OBFFLKDLIBJ<PNNOENNOEAA, HJOFKELFHOB> GPDGCNFCJNN(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, PNNOENNOEAA GDMIHLHPKJN, FLAJGLHFMML ABGMKDALCOP);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> OOEFCIKECDI(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> KGMJGCLHFFI, FCEODKAEDJI<OAOFJLCKBCA> LIDEOOBDIOH, FCEODKAEDJI<JIHNPCGMGAN> MMPLNFLCEPN);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> MOIHMOJPNKC(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> DBEOAFJFJEL, FCEODKAEDJI<OAOFJLCKBCA> DPIHCFAFGAD, FCEODKAEDJI<IAIFMMANJAN> LKEMMOGOMAB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "38")]
	LBBHHBKMHGF HMMNIOPJKLN(IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "39")]
	LBBHHBKMHGF KNKJHNCKDKJ();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "40")]
	KEIFAHMIGDI MGGPNLJFJBI(PHBDFBFLGBL IANLAEECIJK, FCEODKAEDJI<OMEMEDNNNNN> LDHIGPEHLAP, IEnumerable<GGKCCFNJFJC<IMDHLBELCNK>> LNBOMMCIFCA, IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "41")]
	List<KLNACLEPDMM> AGABGHBEIGB();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "42")]
	(List<KLNACLEPDMM>, bool) MBFCFAKNGAF([In] MPOOPGKGMDJ ILGHNJKCJDN, string NDMMIOJEOEB, [In] BDLCOGNBOKL GNFPEMNOJIL, FAMAMOGJFCI GKOPBEJIIOG, BBKGGAENLCO GDMAMBPDFDE);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool BFMNJCFFLNL(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IFIFLHGNABH : KPBPBKPGHBL
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HIOHKLHBHOJ IPPILFDIINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FGHJECBDJBN : HJOFKELFHOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BOOIFAHNHOE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FCEODKAEDJI<OMEMEDNNNNN>? MOMCAACDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FJAJHMJKDEB? FFNCCFEEBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MMIDPNEOGKG : ABNPAAPNOHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FCEODKAEDJI<JIHNPCGMGAN> KODJNPDOELF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FCEODKAEDJI<IDMOAGMBHCD> DMAEEKAFNNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EMGLJGGFNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OGCJONDGHKD(AGBDGPANEPP HNPIAGKEMIC);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKFIJFJAOJE(FMBJCGHGOGL CCCBOLIBBHN);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	string PFIIAOLCJAI(int FDICHMHOOJD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AAINJOBMDMC(NKLDBPFAFIE EDPOEFODAOJ);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NHBBFJEBDNB(NKLDBPFAFIE EDPOEFODAOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NKLDBPFAFIE
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface NAOHBAGGJLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	object FHMIHKKAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GGKCCFNJFJC<EHIJNIOBBMM> KMOOKAOLLIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FCEODKAEDJI<BHBNFANLIBI> DHKPHFJDPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LGHECJBOBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int EBJKJODGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IGNHFMPOJGB FGIOLOPKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string FJBPEPCIMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	NodeVisualizationKey AEDGBICBIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FCEODKAEDJI<EPMGPLBAOIN> MACIEJBGGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OPIOEOHLDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DLMPNLFPPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DEMGCAGOAGF AGJKJLCFIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FKHJAJMHGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JDBKGGPMAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BEFFDIOGKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	int CHPEILDNMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool CILLDAIALPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CICLPJBEDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JOFPIDEPFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool JJIIJHIFGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FLBIEJJCHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool AFLNKMKBLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool CEBOMMNFNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HOOPJPCIOLN DIHMGFFLLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FLAJGLHFMML FMEMKMLEONC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[OENFDFJFBHO(true, "FloatingText")]
	bool EIHECDLPJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "48")]
		[OENFDFJFBHO(true, "FloatingText")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MGMBKPNKILE? KFHOBBAHADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool JKDNDADNJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FCEODKAEDJI<OMEMEDNNNNN>? AIGABCLHHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IEnumerable<GGKCCFNJFJC<IMDHLBELCNK>>? DOPBIDNCKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool LFFOPIOOGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool EIBJJGGKHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	FPBBBHOCOJI<OAOFJLCKBCA, MJCJHKBHLNK> DMCECBBHENN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FCEODKAEDJI<OAOFJLCKBCA>? GODHPJAPEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool JHINDFHMOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "79")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool LHLPIOHOAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MEGPKLFHEEG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OGMJEJNAJGE JJIIFNBOOFO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MAOMNCENHIA LDCHNDBGCEK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action KHBAAHMNBJM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action KLCEIFADLGF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FCEODKAEDJI<OAOFJLCKBCA>, MJCJHKBHLNK> LOCHINKILFN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<FCEODKAEDJI<OAOFJLCKBCA>> OPKJCPGKEBL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<FCEODKAEDJI<OAOFJLCKBCA>, MJCJHKBHLNK> CINFKJHECFK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<FCEODKAEDJI<OAOFJLCKBCA>, FCEODKAEDJI<OAOFJLCKBCA>> HNKJNPKOJBC;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<FCEODKAEDJI<OAOFJLCKBCA>, MJCJHKBHLNK> MLCLPNJCPDA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FCEODKAEDJI<OAOFJLCKBCA>, FCEODKAEDJI<OAOFJLCKBCA>> HCANKAEIMFN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLJGDNHDBFD(int FOOJHNAHHJP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool BOBNODJHLPJ([In] HOOPJPCIOLN BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool AGDLPCAEDBA([In] FLAJGLHFMML BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PBEKJIGPNHK();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> HGMDMCOHOIM(HOOPJPCIOLN? OFOBLJHNFGM, FLAJGLHFMML? FEOKMKIDJOF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BMEANIOOHFB();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AJGHKBGFMPN();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DBMBLHPFMON();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool AJNPCHPCGDP([Out] Guid CDNKEEMBKMO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool JLDIKKAKODO([In] Guid EFMPIMPFJNO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void CMJEOBEPHJG();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void BMNKNFDCDOD(bool NADIHCKKKON);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	PFDHHIHKKHP ALIPBMDKPHF([In] CPMDGFFHIND MMFNKEEMOHC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void MHNFKAKEIMN(object JGDCPCEFPJB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LHGGCNNGIBH(object JGDCPCEFPJB);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> MMCLHLDGLNC(string DMCFPOLFNCF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void IKFIJFJAOJE(IHMICECIEIN AEJMIAICFOI);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "77")]
	AMGGLIGKMHC NNBAJEDLLHN();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "78")]
	bool IKOKPOEJCJE(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "81")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> PCNOKLALDDA(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BOAGOIHOCGF : ABNPAAPNOHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FCEODKAEDJI<DJNGCDCAKKJ> ANINGDBGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FCEODKAEDJI<IAIFMMANJAN> FAIOIBKFEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ABNPAAPNOHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	IEnumerable<StaticEdge> HFAAKKNPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	DisplayKind PLLAHMHCLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	FCEODKAEDJI<OAOFJLCKBCA> DOKOJPMHKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	FCEODKAEDJI<ENCMEEMGAFC> NBHDOBAJEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	KCFBAGCAKEO NNPGNDFBPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	PortImage EEEJGHCFNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AAAIPLFJNBC(NFMHPDNEMLP EDPOEFODAOJ);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JIBNAOKGFPG(EFEPAOJOINK EDPOEFODAOJ);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LMDODAEOFOF(PDPLHJCEOFC CCLHNNFMGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JFBKMJOGIKN(NFMHPDNEMLP EDPOEFODAOJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HNNPBEJKBEP(EFEPAOJOINK EDPOEFODAOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NFMHPDNEMLP
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MJCJHKBHLNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate void JLOBMFFFBED(FCEODKAEDJI<OAOFJLCKBCA> GKLNJFJLDOL, FCEODKAEDJI<OAOFJLCKBCA> OIAHDOIKHME);

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool OLDPCNECNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LFNGCEBOBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MBDACGJGJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool NKMFPHGNEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FPBBBHOCOJI<JIHNPCGMGAN, MMIDPNEOGKG> IJCKOKHAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	FPBBBHOCOJI<IAIFMMANJAN, BOAGOIHOCGF> HBLJCINIKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	FCEODKAEDJI<OAOFJLCKBCA> DOKOJPMHKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action NNKFNCDINBF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action LKBOLGKCOFM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<FCEODKAEDJI<JIHNPCGMGAN>, FCEODKAEDJI<JIHNPCGMGAN>> MEDNFFKDEKA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<FCEODKAEDJI<JIHNPCGMGAN>, FCEODKAEDJI<JIHNPCGMGAN>> PHCNHCLIDNL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<FCEODKAEDJI<IAIFMMANJAN>, FCEODKAEDJI<IAIFMMANJAN>> ECJHPDCCIPL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<FCEODKAEDJI<IAIFMMANJAN>, FCEODKAEDJI<IAIFMMANJAN>> MAOEKFDECHO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<FCEODKAEDJI<JIHNPCGMGAN>, MMIDPNEOGKG> NFIDKNLNBEJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<FCEODKAEDJI<JIHNPCGMGAN>> NGKHGCBMJND;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<FCEODKAEDJI<JIHNPCGMGAN>, MMIDPNEOGKG> HCPKNFNDCMA;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<FCEODKAEDJI<IAIFMMANJAN>, BOAGOIHOCGF> OHKFIIJLJIH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<FCEODKAEDJI<IAIFMMANJAN>> HDBFCDDNDBP;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<FCEODKAEDJI<IAIFMMANJAN>, BOAGOIHOCGF> JHCFIKKMMOO;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> MEGOOCEJHLB();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> LOALKMMMNFG(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> AKOFIGIIAAB(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> JBBNHMDGLAI(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, FCEODKAEDJI<KKOGEBIBMKE> LKANECPEFDC);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> ECKDPHEOBFL(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, FCEODKAEDJI<PLLHIIMKMMI> LKANECPEFDC);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> KMKKBHNIHLC();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> DAJLAJJCFGG(string GNOEHPKGKMF);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> CEKHGIOHDDA(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, string DMCFPOLFNCF);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> FMFBOOEKKFC(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, string DMCFPOLFNCF);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> GEBLCIPFIGJ(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, HFDGOBILPDJ PFCMGBLCCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> IDCLDIMKNFH(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, HFDGOBILPDJ PFCMGBLCCPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HFDGOBILPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	TypeKey OLANDIMLOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	string EGOFGBMPBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OBFFLKDLIBJ<FCEODKAEDJI<KKOGEBIBMKE>, FGHJECBDJBN>> IPPIPDCEAPK(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, string DMCFPOLFNCF);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<OBFFLKDLIBJ<FCEODKAEDJI<PLLHIIMKMMI>, FGHJECBDJBN>> MONAMFBDKNG(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, string DMCFPOLFNCF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EFEPAOJOINK
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed([In] DDOPIFIDJPF FOKFEHDKCGM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KCFBAGCAKEO
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CAPIAKMPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CLIEHPNDAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	TypeKey AEDGBICBIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool HJNPAGHFHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AAHPBGMKGGI : KLNACLEPDMM, IEquatable<AAHPBGMKGGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> BJKBHIMJJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> OLGJCLHOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> GDLIHNNLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> OEEAEELECEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> JLHAGONMOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> AKBGDIFAPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string OLGNDIBBBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly string IJPKLNBJFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x22F9A30", Offset = "0x22F8A30", VA = "0x1822F9A30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x22F9DD0", Offset = "0x22F8DD0", VA = "0x1822F9DD0")]
	public AAHPBGMKGGI(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> NGHBBCECJDC, [In] GGKCCFNJFJC<IMDHLBELCNK> NCJHNMLBCKG, FCEODKAEDJI<IMDHLBELCNK> ECLIAJIOAFA, [In] GGKCCFNJFJC<IMDHLBELCNK> IAAHPEDNNHI, FCEODKAEDJI<IDMOAGMBHCD> NIMEPOJNGEG, FCEODKAEDJI<DJNGCDCAKKJ> AIFKEMNGFHL, string FJEKALHOMHN, string MLOIOIMJDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8B4270", Offset = "0x8B3270", VA = "0x1808B4270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x22F9AD0", Offset = "0x22F8AD0", VA = "0x1822F9AD0", Slot = "5")]
	public bool Equals(AAHPBGMKGGI BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x22F9A60", Offset = "0x22F8A60", VA = "0x1822F9A60", Slot = "0")]
	public override bool Equals(object? BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x22F9C50", Offset = "0x22F8C50", VA = "0x1822F9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class FDMAGDGMMLM : KLNACLEPDMM, IEquatable<FDMAGDGMMLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x22FE580", Offset = "0x22FD580", VA = "0x1822FE580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x22FE770", Offset = "0x22FD770", VA = "0x1822FE770")]
	public FDMAGDGMMLM(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x22FE5B0", Offset = "0x22FD5B0", VA = "0x1822FE5B0", Slot = "5")]
	public bool Equals(FDMAGDGMMLM BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x22FE640", Offset = "0x22FD640", VA = "0x1822FE640", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x22FE700", Offset = "0x22FD700", VA = "0x1822FE700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class PFADDJIHAKO : KLNACLEPDMM, IEquatable<PFADDJIHAKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> IGHKPELBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> LMJNOFGNAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int LCAIHIPDOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x23032A0", Offset = "0x23022A0", VA = "0x1823032A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2303680", Offset = "0x2302680", VA = "0x182303680")]
	public PFADDJIHAKO(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, FCEODKAEDJI<IDMOAGMBHCD> AGOOLALJELE, FCEODKAEDJI<IDMOAGMBHCD> BDJDNMOMHLH, int KLCJBCDLHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x23032D0", Offset = "0x23022D0", VA = "0x1823032D0", Slot = "5")]
	public bool Equals(PFADDJIHAKO DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2303400", Offset = "0x2302400", VA = "0x182303400", Slot = "0")]
	public override bool Equals(object? IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2303590", Offset = "0x2302590", VA = "0x182303590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LJHNNIEFBLJ : KLNACLEPDMM, IEquatable<LJHNNIEFBLJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int CLHNFCJPAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int MNNCCOHMMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x23018E0", Offset = "0x23008E0", VA = "0x1823018E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2301C30", Offset = "0x2300C30", VA = "0x182301C30")]
	public LJHNNIEFBLJ(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, int JEEEIPHAAJD, int FIDICGNBJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2301910", Offset = "0x2300910", VA = "0x182301910", Slot = "5")]
	public bool Equals(LJHNNIEFBLJ BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2301A00", Offset = "0x2300A00", VA = "0x182301A00", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2301B30", Offset = "0x2300B30", VA = "0x182301B30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class FBFFIIONBEP : KLNACLEPDMM, IEquatable<FBFFIIONBEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x22FDF00", Offset = "0x22FCF00", VA = "0x1822FDF00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x22FE1D0", Offset = "0x22FD1D0", VA = "0x1822FE1D0")]
	public FBFFIIONBEP(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x22FDF30", Offset = "0x22FCF30", VA = "0x1822FDF30", Slot = "5")]
	public bool Equals(FBFFIIONBEP BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x22FE000", Offset = "0x22FD000", VA = "0x1822FE000", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22FE110", Offset = "0x22FD110", VA = "0x1822FE110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PGAMNDODPDH : KLNACLEPDMM, IEquatable<PGAMNDODPDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> BMPEHBPNKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> CAFALOGIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly int ABKHCDCMPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2303C10", Offset = "0x2302C10", VA = "0x182303C10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2303FF0", Offset = "0x2302FF0", VA = "0x182303FF0")]
	public PGAMNDODPDH(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, FCEODKAEDJI<DJNGCDCAKKJ> EJAMAKBHIMF, FCEODKAEDJI<DJNGCDCAKKJ> CFDFJKFMECH, int HDFKMLJJHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2303DD0", Offset = "0x2302DD0", VA = "0x182303DD0", Slot = "5")]
	public bool Equals(PGAMNDODPDH? DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2303C40", Offset = "0x2302C40", VA = "0x182303C40", Slot = "0")]
	public override bool Equals(object? IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2303F00", Offset = "0x2302F00", VA = "0x182303F00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class HDNBAOBHNGC : KLNACLEPDMM, IEquatable<HDNBAOBHNGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly int IBHEDBHGEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly int HEELGMCNCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x22FF560", Offset = "0x22FE560", VA = "0x1822FF560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x22FF8B0", Offset = "0x22FE8B0", VA = "0x1822FF8B0")]
	public HDNBAOBHNGC(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, int ICEDHMBBAMA, int NEKGBBLGPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22FF590", Offset = "0x22FE590", VA = "0x1822FF590", Slot = "5")]
	public bool Equals(HDNBAOBHNGC BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x22FF680", Offset = "0x22FE680", VA = "0x1822FF680", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x22FF7B0", Offset = "0x22FE7B0", VA = "0x1822FF7B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class EAIEHJDBIJK
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class EHIJNIOBBMM
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class EEENFPNJEIF
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class OMEMEDNNNNN
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class PPPGKNMBFDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class IDMOAGMBHCD : FBIJPPLOMIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class KKOGEBIBMKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class OOEPOIHBEEC : GGKDKNDFDKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class IMDHLBELCNK
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class BHBNFANLIBI
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class EBMGINFAGPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class GFCFGDPNKNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class DJNGCDCAKKJ : FBIJPPLOMIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class PLLHIIMKMMI
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class MHCMNEOALJM : GGKDKNDFDKM
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class FBIJPPLOMIC
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[GKFAPCOLABH("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class OAOFJLCKBCA
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class JIHNPCGMGAN : ENCMEEMGAFC
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class IAIFMMANJAN : ENCMEEMGAFC
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class ENCMEEMGAFC
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class GGKDKNDFDKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class DGGBEJIBMHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class EPMGPLBAOIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class NOKGCONELOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class OCKLHBEKGNF
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public sealed class KHIGAPAPNLJ : KLNACLEPDMM, IEquatable<KHIGAPAPNLJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public StaticEdge HJCPGGMKFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2300790", Offset = "0x22FF790", VA = "0x182300790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x23009C0", Offset = "0x22FF9C0", VA = "0x1823009C0")]
	public KHIGAPAPNLJ(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, [In] StaticEdge IOJPCKOCJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4280", Offset = "0x8B3280", VA = "0x1808B4280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x23007C0", Offset = "0x22FF7C0", VA = "0x1823007C0", Slot = "5")]
	public bool Equals(KHIGAPAPNLJ BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2300860", Offset = "0x22FF860", VA = "0x182300860", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2300940", Offset = "0x22FF940", VA = "0x182300940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public sealed class KHKEKCHJLNJ : KLNACLEPDMM, IEquatable<KHKEKCHJLNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2300D00", Offset = "0x22FFD00", VA = "0x182300D00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2300E70", Offset = "0x22FFE70", VA = "0x182300E70")]
	public KHKEKCHJLNJ([In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2300DD0", Offset = "0x22FFDD0", VA = "0x182300DD0", Slot = "5")]
	public bool Equals(KHKEKCHJLNJ BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2300D30", Offset = "0x22FFD30", VA = "0x182300D30", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2300E30", Offset = "0x22FFE30", VA = "0x182300E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class EFDOJAJGMBC : KLNACLEPDMM, IEquatable<EFDOJAJGMBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> IGHKPELBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> HHMHNLCFEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly int LCAIHIPDOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x22FD590", Offset = "0x22FC590", VA = "0x1822FD590", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x22FD970", Offset = "0x22FC970", VA = "0x1822FD970")]
	public EFDOJAJGMBC(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, FCEODKAEDJI<IDMOAGMBHCD> AGOOLALJELE, FCEODKAEDJI<IDMOAGMBHCD> PBLFMCFGIEF, int KLCJBCDLHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x22FD750", Offset = "0x22FC750", VA = "0x1822FD750", Slot = "5")]
	public bool Equals(EFDOJAJGMBC? DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x22FD5C0", Offset = "0x22FC5C0", VA = "0x1822FD5C0", Slot = "0")]
	public override bool Equals(object? IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x22FD880", Offset = "0x22FC880", VA = "0x1822FD880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class AJCOELOFJFC : KLNACLEPDMM, IEquatable<AJCOELOFJFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly int CLHNFCJPAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly int MNNCCOHMMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x22FAA70", Offset = "0x22F9A70", VA = "0x1822FAA70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x22FADC0", Offset = "0x22F9DC0", VA = "0x1822FADC0")]
	public AJCOELOFJFC(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, int JEEEIPHAAJD, int FIDICGNBJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x22FAAA0", Offset = "0x22F9AA0", VA = "0x1822FAAA0", Slot = "5")]
	public bool Equals(AJCOELOFJFC BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x22FAB90", Offset = "0x22F9B90", VA = "0x1822FAB90", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x22FACC0", Offset = "0x22F9CC0", VA = "0x1822FACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class LOCMFFOCKJN : KLNACLEPDMM, IEquatable<LOCMFFOCKJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2302230", Offset = "0x2301230", VA = "0x182302230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2302490", Offset = "0x2301490", VA = "0x182302490")]
	public LOCMFFOCKJN(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2302260", Offset = "0x2301260", VA = "0x182302260", Slot = "5")]
	public bool Equals(LOCMFFOCKJN BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2302310", Offset = "0x2301310", VA = "0x182302310", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2302400", Offset = "0x2301400", VA = "0x182302400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class KOIELAHEINA : KLNACLEPDMM, IEquatable<KOIELAHEINA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> BMPEHBPNKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> MFGDHGFEHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly int ABKHCDCMPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2300F30", Offset = "0x22FFF30", VA = "0x182300F30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2301310", Offset = "0x2300310", VA = "0x182301310")]
	public KOIELAHEINA(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, FCEODKAEDJI<DJNGCDCAKKJ> EJAMAKBHIMF, FCEODKAEDJI<DJNGCDCAKKJ> BBHJNDOFMGF, int HDFKMLJJHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x23010F0", Offset = "0x23000F0", VA = "0x1823010F0", Slot = "5")]
	public bool Equals(KOIELAHEINA? DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2300F60", Offset = "0x22FFF60", VA = "0x182300F60", Slot = "0")]
	public override bool Equals(object? IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2301220", Offset = "0x2300220", VA = "0x182301220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class PJOGOLPBNLL : KLNACLEPDMM, IEquatable<PJOGOLPBNLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly int IBHEDBHGEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly int HEELGMCNCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2304580", Offset = "0x2303580", VA = "0x182304580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x23048D0", Offset = "0x23038D0", VA = "0x1823048D0")]
	public PJOGOLPBNLL(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, int ICEDHMBBAMA, int NEKGBBLGPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x23045B0", Offset = "0x23035B0", VA = "0x1823045B0", Slot = "5")]
	public bool Equals(PJOGOLPBNLL BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x23046A0", Offset = "0x23036A0", VA = "0x1823046A0", Slot = "0")]
	public override bool Equals(object? BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x23047D0", Offset = "0x23037D0", VA = "0x1823047D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[JBAHBGCJJND("StaticEdge")]
public readonly struct NLABAOACMJG : IEquatable<NLABAOACMJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> OPPOGJADGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> ODCMPFPIGBC;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x99A6C0", Offset = "0x9996C0", VA = "0x18099A6C0")]
	public NLABAOACMJG(FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2303120", Offset = "0x2302120", VA = "0x182303120")]
	public void GIFBHPBPLDG([Out] FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, [Out] FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x23031A0", Offset = "0x23021A0", VA = "0x1823031A0")]
	public static bool LJMKDDBNEAO(NLABAOACMJG GGEOEEJGPGH, NLABAOACMJG OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2303080", Offset = "0x2302080", VA = "0x182303080", Slot = "4")]
	public bool Equals(NLABAOACMJG DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2303090", Offset = "0x2302090", VA = "0x182303090", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2303130", Offset = "0x2302130", VA = "0x182303130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class DILODBKMEIP : KLNACLEPDMM, IEquatable<DILODBKMEIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly int BGEEKJNHLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly int NBKMEABPNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly int EBCOADHHOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22FB2B0", Offset = "0x22FA2B0", VA = "0x1822FB2B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x22FB610", Offset = "0x22FA610", VA = "0x1822FB610")]
	public DILODBKMEIP(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, int DCPMEJPPMHH, int KCPNOECGLML, int LACKAJNJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x22FB410", Offset = "0x22FA410", VA = "0x1822FB410", Slot = "5")]
	public bool Equals(DILODBKMEIP BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22FB2E0", Offset = "0x22FA2E0", VA = "0x1822FB2E0", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x22FB500", Offset = "0x22FA500", VA = "0x1822FB500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NBJCGPEEEMI : KLNACLEPDMM, IEquatable<NBJCGPEEEMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DDLPHLIFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly int BGEEKJNHLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly int LHBDMNBNBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly int PCJMDLNPNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public string DOCMDIMJHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x23027B0", Offset = "0x23017B0", VA = "0x1823027B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2302B10", Offset = "0x2301B10", VA = "0x182302B10")]
	public NBJCGPEEEMI(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<OMEMEDNNNNN> CDLGPKCHKPF, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC, int DCPMEJPPMHH, int APNEDNNIMAN, int MOCNOIHLDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x23027E0", Offset = "0x23017E0", VA = "0x1823027E0", Slot = "5")]
	public bool Equals(NBJCGPEEEMI BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x23028D0", Offset = "0x23018D0", VA = "0x1823028D0", Slot = "0")]
	public override bool Equals(object BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2302A00", Offset = "0x2301A00", VA = "0x182302A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct FJAJHMJKDEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> DGIMHMGKILI;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public FJAJHMJKDEB([In] GGKCCFNJFJC<IMDHLBELCNK> GLBIJKPLDLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public delegate void ANHNAONCAOM([In] DDOPIFIDJPF FOKFEHDKCGM);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		List,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		StateTransition
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate void OGMJEJNAJGE([In] HOOPJPCIOLN DDDGFIIJFMJ);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum JEKPODOGHBG
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Versioning,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	NodesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SyncedVariablesNotAllowedInTargetGraphOrDescendents
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct IBINMGAJJHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly HFDGOBILPDJ LLFNIEFEIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly HFDGOBILPDJ HJLNLFGABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly HFDGOBILPDJ CHMADGPLFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly HFDGOBILPDJ AGGBNNPPDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly HFDGOBILPDJ PPAGNIEGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly HFDGOBILPDJ BDCKLBEJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly HFDGOBILPDJ FFPKCDJMNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly HFDGOBILPDJ EBJKJODGGDJ;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x9D3540", Offset = "0x9D2540", VA = "0x1809D3540")]
	public IBINMGAJJHI(HFDGOBILPDJ FAAGJJIGMJJ, HFDGOBILPDJ DAOOOGLHGNJ, HFDGOBILPDJ EPNJPHPDCJI, HFDGOBILPDJ NEBKKIBNLAF, HFDGOBILPDJ ABHHNKGOHAB, HFDGOBILPDJ KAIIADKJPPI, HFDGOBILPDJ FLFIIKKIKBN, HFDGOBILPDJ DANHKIEIFNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public delegate void MAOMNCENHIA([In] FLAJGLHFMML HHNPPALCIHB);
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct HIKLHIHFALH : IEquatable<HIKLHIHFALH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> BJKBHIMJJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly FCEODKAEDJI<MHCMNEOALJM> JIKIEHJLLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly GGKCCFNJFJC<IMDHLBELCNK> GDLIHNNLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly FCEODKAEDJI<OOEPOIHBEEC> DBPOMPJBKNG;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x23003D0", Offset = "0x22FF3D0", VA = "0x1823003D0")]
	public HIKLHIHFALH([In] GGKCCFNJFJC<IMDHLBELCNK> NGHBBCECJDC, FCEODKAEDJI<MHCMNEOALJM> IOPOCNPNHMM, [In] GGKCCFNJFJC<IMDHLBELCNK> ECLIAJIOAFA, FCEODKAEDJI<OOEPOIHBEEC> HBDOGJLNAPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x22FFFB0", Offset = "0x22FEFB0", VA = "0x1822FFFB0")]
	public static bool LJMKDDBNEAO([In] HIKLHIHFALH GGEOEEJGPGH, [In] HIKLHIHFALH OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x22FFD90", Offset = "0x22FED90", VA = "0x1822FFD90", Slot = "4")]
	public bool Equals(HIKLHIHFALH DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x22FFE50", Offset = "0x22FEE50", VA = "0x1822FFE50", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x22FFF00", Offset = "0x22FEF00", VA = "0x1822FFF00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2300070", Offset = "0x22FF070", VA = "0x182300070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly GGKCCFNJFJC<IMDHLBELCNK> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly FCEODKAEDJI<OAOFJLCKBCA> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly FCEODKAEDJI<IAIFMMANJAN> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly GGKCCFNJFJC<IMDHLBELCNK> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly FCEODKAEDJI<OAOFJLCKBCA> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly FCEODKAEDJI<JIHNPCGMGAN> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x23054D0", Offset = "0x23044D0", VA = "0x1823054D0")]
		public StaticEdge([In] GGKCCFNJFJC<IMDHLBELCNK> NGHBBCECJDC, FCEODKAEDJI<OAOFJLCKBCA> FODIEIENFPG, FCEODKAEDJI<IAIFMMANJAN> IBPMCPOIAOA, [In] GGKCCFNJFJC<IMDHLBELCNK> ECLIAJIOAFA, FCEODKAEDJI<OAOFJLCKBCA> MGIIFIOEENF, FCEODKAEDJI<JIHNPCGMGAN> EDOMLHKGOOP)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2304F70", Offset = "0x2303F70", VA = "0x182304F70")]
		public static bool LJMKDDBNEAO([In] StaticEdge GGEOEEJGPGH, [In] StaticEdge OLIPOMNIFIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2304E60", Offset = "0x2303E60", VA = "0x182304E60", Slot = "4")]
		public bool Equals(StaticEdge DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2304DB0", Offset = "0x2303DB0", VA = "0x182304DB0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2304E80", Offset = "0x2303E80", VA = "0x182304E80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2305060", Offset = "0x2304060", VA = "0x182305060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class LKGPFNEEOJA
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2302110", Offset = "0x2301110", VA = "0x182302110")]
	public static StaticEdge OGCNNFLPKKP(this HANIJEFFGNL GFJPFDOHONG)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct MNGGNLAFMIB : IEquatable<MNGGNLAFMIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly string PFHNBNOKONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public readonly int LNEHEEDMCPD;

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x9D4FE0", Offset = "0x9D3FE0", VA = "0x1809D4FE0")]
	public MNGGNLAFMIB(string IHNJPHKOIIF, int KCBKFAIBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x22FA720", Offset = "0x22F9720", VA = "0x1822FA720", Slot = "4")]
	public bool Equals(MNGGNLAFMIB DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct ABEEKFIJDHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public readonly string KKNEIOOKBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public readonly FKIBLIIKPME.OGGBJLEPEOP.CCIEPMNEHNP LNOAFIALFLG;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x9D4FE0", Offset = "0x9D3FE0", VA = "0x1809D4FE0")]
	public ABEEKFIJDHG(string DMCFPOLFNCF, FKIBLIIKPME.OGGBJLEPEOP.CCIEPMNEHNP MDKDFIJACFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x22FA770", Offset = "0x22F9770", VA = "0x1822FA770")]
	internal static ABEEKFIJDHG OGCNNFLPKKP(FKIBLIIKPME CONAFKKIHKL)
	{
		return default(ABEEKFIJDHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x22FA590", Offset = "0x22F9590", VA = "0x1822FA590")]
	internal FKIBLIIKPME EKFEJLFJOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x22FA6B0", Offset = "0x22F96B0", VA = "0x1822FA6B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x22FA600", Offset = "0x22F9600", VA = "0x1822FA600", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x22FA720", Offset = "0x22F9720", VA = "0x1822FA720")]
	public bool NBPPFHJIPEN(ABEEKFIJDHG DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x22FA7C0", Offset = "0x22F97C0", VA = "0x1822FA7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct ECJLIBFABMC : IEquatable<ECJLIBFABMC>
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<GGKCCFNJFJC<OCKLHBEKGNF>, MNGGNLAFMIB> OKBOJCBFFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly GKHHGLBIBCN CPJHIIMONCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string KAIMPHGPDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly IReadOnlyDictionary<GGKCCFNJFJC<OCKLHBEKGNF>, MNGGNLAFMIB> CACPJHHKMAB;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x22FC730", Offset = "0x22FB730", VA = "0x1822FC730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x22FD260", Offset = "0x22FC260", VA = "0x1822FD260")]
	public ECJLIBFABMC(GKHHGLBIBCN BONKNIGAHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x22FD310", Offset = "0x22FC310", VA = "0x1822FD310")]
	public ECJLIBFABMC(GKHHGLBIBCN BONKNIGAHFB, IReadOnlyDictionary<GGKCCFNJFJC<OCKLHBEKGNF>, MNGGNLAFMIB> HIFJKJPCHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x22FBE10", Offset = "0x22FAE10", VA = "0x1822FBE10")]
	public static ECJLIBFABMC ABHOFGFGJKM(ECJLIBFABMC FJKNKBIDPCF, ECJLIBFABMC CMLHMEDGLOP)
	{
		return default(ECJLIBFABMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x22FCDA0", Offset = "0x22FBDA0", VA = "0x1822FCDA0")]
	public static ECJLIBFABMC OGCNNFLPKKP(EDDJCBMGJGO CONAFKKIHKL)
	{
		return default(ECJLIBFABMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x22FC7B0", Offset = "0x22FB7B0", VA = "0x1822FC7B0")]
	public EDDJCBMGJGO EKFEJLFJOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x22FC940", Offset = "0x22FB940", VA = "0x1822FC940", Slot = "4")]
	public bool Equals(ECJLIBFABMC DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct GKHHGLBIBCN : IEquatable<GKHHGLBIBCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string KKNEIOOKBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly IReadOnlyList<ABEEKFIJDHG> IJCKOKHAOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly IReadOnlyList<ABEEKFIJDHG> HBLJCINIKBJ;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x22FEB20", Offset = "0x22FDB20", VA = "0x1822FEB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x21E39D0", Offset = "0x21E29D0", VA = "0x1821E39D0")]
	public GKHHGLBIBCN(string DMCFPOLFNCF, IReadOnlyList<ABEEKFIJDHG> GHPOJDLNEJJ, IReadOnlyList<ABEEKFIJDHG> OEOCEOHLKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x22FEEE0", Offset = "0x22FDEE0", VA = "0x1822FEEE0")]
	public static GKHHGLBIBCN OGCNNFLPKKP(OKNDCGKGEII CONAFKKIHKL)
	{
		return default(GKHHGLBIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x22FEB40", Offset = "0x22FDB40", VA = "0x1822FEB40")]
	public OKNDCGKGEII EKFEJLFJOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x22FEE60", Offset = "0x22FDE60", VA = "0x1822FEE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x22FE940", Offset = "0x22FD940", VA = "0x1822FE940")]
	private static int AAGEBNJIGHM(IReadOnlyList<ABEEKFIJDHG> HLKOINCGDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x22FEDB0", Offset = "0x22FDDB0", VA = "0x1822FEDB0", Slot = "4")]
	public bool Equals(GKHHGLBIBCN DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x22FF1A0", Offset = "0x22FE1A0", VA = "0x1822FF1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum PHBDFBFLGBL
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class HJHMJEOBCPN
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1164B30", Offset = "0x1163B30", VA = "0x181164B30")]
	public static bool FBJDPCANOBE(this PHBDFBFLGBL BMAADIIMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1164B30", Offset = "0x1163B30", VA = "0x181164B30")]
	public static bool JADGKMJONLI(this PHBDFBFLGBL BMAADIIMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1164B30", Offset = "0x1163B30", VA = "0x181164B30")]
	public static bool DNFPHIHFFCD(this PHBDFBFLGBL BMAADIIMEEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public enum DLCMHMHAIKF
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct DDOPIFIDJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public readonly bool LNDGLDIAFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly DLCMHMHAIKF NILADPFHPEE;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x22FB2A0", Offset = "0x22FA2A0", VA = "0x1822FB2A0")]
	public DDOPIFIDJPF(bool OEDJMNMDEGP, DLCMHMHAIKF OCJBBEIEDAA)
	{
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		String,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
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
