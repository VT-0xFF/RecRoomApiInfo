using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C277E0", Offset = "0x1C26BE0", VA = "0x181C277E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
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
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PCDLIBABGAD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Follow,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Orbit,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Attached,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Detached
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct OMAGFAABBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly MDPHAFPKPNH PKJBAFJBIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly LCBHGIKAPAP MOOJNMNAAJP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1C27860", Offset = "0x1C26C60", VA = "0x181C27860")]
	public OMAGFAABBKJ([In] MDPHAFPKPNH NDJHINJFLAD, LCBHGIKAPAP ILOGCLKGEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MDPHAFPKPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly BOGJDKIJOLK BGMJKIEJIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly OCFHMGCGDAI JKDBCMNGGOI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
	public MDPHAFPKPNH(BOGJDKIJOLK NLEIOMCFPPC, OCFHMGCGDAI OGICCGNGKBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LCBHGIKAPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly CMFAAJONIFD MDOLNPJLCNK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	public LCBHGIKAPAP(CMFAAJONIFD AKODOEKJGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JNGCAMDGEKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly HBIOJHLGOIE HIDKJCNCKKN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	public JNGCAMDGEKN(HBIOJHLGOIE EAKHANICGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HEFPJGIBACC
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Digit,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Integer,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Decimal,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Regex,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CustomValidator
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JAEFPJIALHI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Custom
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJFLGAEPHLO : PGIOPALILBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string JGPMPGCGHFK, Action<string, float> MALFIMHEAIM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PMMMPEPOBNP : NCOIALPMEOC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDPFKHEBAFB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PGIOPALILBJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NJHLAFDJMNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DMDMGEGKDIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string OADCDKNMGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int ADKBDGOMMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IBOIEMDMFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LIGGHGPDIAP : NCOIALPMEOC
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIHKKMKIIOJ(NCOIALPMEOC NNOPHBMDNNP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOAOJFKKMLN();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFJFDMFKDND(NCOIALPMEOC NNOPHBMDNNP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EENFCJBELLA
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFNPCLOKJMH(string KAKOBFMHGJF, Func<string> ECOLGCIONCI, Action<string> OCLNBKDGNBP, Func<bool> KAFLLKGIFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDMNGNIMKJO(string KAKOBFMHGJF, Action OLKHFBJMOFM, Func<bool> KAFLLKGIFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEHIINJPGJN(string KAKOBFMHGJF, Func<int> NANAECBAEIG, Action<int> IMHGCALADME, Func<bool> KAFLLKGIFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COAAIHGDNDB(string KAKOBFMHGJF, Func<int> ECOLGCIONCI, Action<int> OCLNBKDGNBP, Func<bool> KAFLLKGIFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLIFABGKFHI(string KAKOBFMHGJF, Func<int> KLHCLJLFEDE, Action<object> IHEIGNBFAGB, Func<object, string> JAGCOCKDLCI, Func<bool> KAFLLKGIFHJ, Type EBALPOJPFMD, IReadOnlyList<object> DBECFDNMGKI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOANKBFEHEB(string KAKOBFMHGJF, Func<string> ECOLGCIONCI, Action<string> OCLNBKDGNBP, Func<bool> KAFLLKGIFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AJBJFNBEHGP(string KAKOBFMHGJF, Func<bool> ECOLGCIONCI, Action<bool> OCLNBKDGNBP, Func<bool> KAFLLKGIFHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AAENHECDBJO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface BOHFIJPDENL
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Action<AAENHECDBJO>? EDNMKEILJFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Action<AAENHECDBJO>? PODCLDEOHAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NCOIALPMEOC CFGLOMJPBGB(Func<byte> ICOEBCFCCJK, Action<byte> NJKBNIKIIDI, Func<int> DMJEGPMGHOH, Action<int> INDBIICEKDH, [Optional] Func<bool>? KAFLLKGIFHJ);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KEIEGHOGBII();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void APPKENDKBAJ(NCOIALPMEOC NNOPHBMDNNP);
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BOHFIJPDENL IMDFOBNNIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCOIALPMEOC NNAOIKIAAGP(Action OLKHFBJMOFM, string KAKOBFMHGJF = "", [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCOIALPMEOC EFGBMBDJGLN(IReadOnlyList<NCOIALPMEOC> PGHBEEJMEAP, [Optional] float? MEJAEDDPBOJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NCOIALPMEOC MCFNJLBKAPG(Func<int> NANAECBAEIG, Action<int> IMHGCALADME, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, bool NAHFBOHGEOM = false, string KAKOBFMHGJF = "Color", [Optional] Func<bool>? JFLLBBLGHPE, bool AAABJCLCOCG = true, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NCOIALPMEOC FNKAGOANFDE(NCOIALPMEOC NNOPHBMDNNP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LIGGHGPDIAP KMPHMBBIKLA(int AIAPAIEHOOP, string KAKOBFMHGJF, string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] List<NCOIALPMEOC>? PGHBEEJMEAP, [Optional] Func<bool>? KAFLLKGIFHJ, bool KBMNNPIMPHC = true, [Optional] Func<bool>? PMJONJADBLD, [Optional] Action<bool>? AFPPLIGANLN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NCOIALPMEOC MBJJLPAEFFC(string DBPAHEMAAMI, [Optional] Func<bool>? KAFLLKGIFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NCOIALPMEOC LEFALHGBFJA(Func<string> ECOLGCIONCI, Action<string> OCLNBKDGNBP, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] int? HJLAMBHOONP, bool FDHDFCDCCPE = false, string KAKOBFMHGJF = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NCOIALPMEOC PCCKIAPHJJC(Func<float> ECOLGCIONCI, Action<float> OCLNBKDGNBP, string KAKOBFMHGJF = "", string IHNBBBPBEKG = "", string HCKECBPFJML = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", bool NEIKGKGFPBB = false, float MPNGMKLCKDD = 0f, float BENIIGDMCOB = 1000f, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NCOIALPMEOC KPPLAPBPLIK(Func<int> ECOLGCIONCI, Action<int> OCLNBKDGNBP, string KAKOBFMHGJF = "", [Optional] Func<string>? POHEGPKPFID, string IHNBBBPBEKG = "", [Optional] Func<string>? EDNBHEEKDCE, string HCKECBPFJML = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", bool NEIKGKGFPBB = false, int MPNGMKLCKDD = 0, int BENIIGDMCOB = 1000, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NCOIALPMEOC EHDLBBBFFMP(Type EBALPOJPFMD, IReadOnlyList<object> DBECFDNMGKI, Func<int> KLHCLJLFEDE, Action<object> IHEIGNBFAGB, string KAKOBFMHGJF = "", string IHNBBBPBEKG = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] Func<object, string>? JAGCOCKDLCI, bool LHOOEMDONPE = true, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NCOIALPMEOC JNANLAJHINK(Func<string> ECOLGCIONCI, Action<string> OCLNBKDGNBP, int GNILBGDDFPN = 1000, JAEFPJIALHI FJCLLEACHBE = JAEFPJIALHI.Alphanumeric, [Optional] Func<string, bool>? ONDNPHDGLAP, [Optional] string? LOHIGANCECG, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, string KAKOBFMHGJF = "", string IHNBBBPBEKG = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", bool FDHDFCDCCPE = false, [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NCOIALPMEOC OIOFBBOEIDH(Func<float> ECOLGCIONCI, Action<float> OCLNBKDGNBP, float MPNGMKLCKDD = 0f, float BENIIGDMCOB = 1000f, [Optional] Func<bool>? KMKOAPGGHPN, int HGDABEGMFML = -1, string KAKOBFMHGJF = "", string IHNBBBPBEKG = "", string HCKECBPFJML = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Func<float, float>? GLBALPFEDCE, [Optional] Func<float, float>? ECHMBBPILBB, [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NCOIALPMEOC OKKKDMAGLCP(Func<string> ECOLGCIONCI, Action<string> OCLNBKDGNBP, Action OLKHFBJMOFM, [Optional] Func<bool>? KAFLLKGIFHJ, JAEFPJIALHI FJCLLEACHBE = JAEFPJIALHI.Alphanumeric, [Optional] Func<string, bool>? ONDNPHDGLAP, HEFPJGIBACC CKPEHJBCDIH = HEFPJGIBACC.Alphanumeric, [Optional] string? LOHIGANCECG, [Optional] List<NCOIALPMEOC>? MLOFPBELPEG, string KAKOBFMHGJF = "", string BPAIOFDKOBJ = "", string MMDGHIMFPBG = "", string MIBJAMFCDHN = "", bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NCOIALPMEOC FFGFLKOMCFH(Func<string> ECOLGCIONCI, Action<string> OCLNBKDGNBP, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] int? HJLAMBHOONP, bool FDHDFCDCCPE = false, string KAKOBFMHGJF = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NCOIALPMEOC MIEDICBCEII(Func<bool> ECOLGCIONCI, Action<bool> OCLNBKDGNBP, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, string KAKOBFMHGJF = "", string IHNBBBPBEKG = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] int? AIAPAIEHOOP, [Optional] Func<bool>? JFLLBBLGHPE, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PMMMPEPOBNP BEDCKNNEFIN(Dictionary<string, OPACAGJCGOO> OFAFLOECBGM, Func<int> NANAECBAEIG, Action<int> IMHGCALADME, string KAKOBFMHGJF, string IHNBBBPBEKG = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Action? IMCAPELKCNG, [Optional] Action? JLPELHFKPIG, [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] Func<int, string>? NFFCOEHBCGB, bool LHOOEMDONPE = true, bool PJOPBONPBAA = true, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PMMMPEPOBNP KDDFGBIGOKG(Func<Dictionary<string, OPACAGJCGOO>> LIPDAPEJNCK, Func<int> NANAECBAEIG, Action<int> IMHGCALADME, string KAKOBFMHGJF, string IHNBBBPBEKG = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] Func<bool>? CGHHAEBLJAF, [Optional] Func<int, string>? NFFCOEHBCGB, bool LHOOEMDONPE = true, bool PJOPBONPBAA = true, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NCOIALPMEOC GGAHCFJJJDI(Func<List<KeyValuePair<string, OPACAGJCGOO>>> LIPDAPEJNCK, Func<int> NANAECBAEIG, Action<int> IMHGCALADME, string KAKOBFMHGJF, string IHNBBBPBEKG = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, [Optional] Func<bool>? CGHHAEBLJAF, [Optional] Func<int, string>? NFFCOEHBCGB, [Optional] Action? IMCAPELKCNG, [Optional] Action? JLPELHFKPIG, bool LHOOEMDONPE = true, bool PJOPBONPBAA = true, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	NCOIALPMEOC CDEIFOBJEJB(Func<List<object>> LIPDAPEJNCK, Func<object> KLHCLJLFEDE, Action<object> IHEIGNBFAGB, Func<object, string> JAGCOCKDLCI, string KAKOBFMHGJF = "", string IHNBBBPBEKG = "", string BPAIOFDKOBJ = "", string GOGHFGANLLP = "", [Optional] Func<bool>? KAFLLKGIFHJ, [Optional] Func<bool>? DDPMGPDLDOE, bool LHOOEMDONPE = true, bool IGEHLODCIEE = true);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	NCOIALPMEOC NDEOHIHAMBP(string KAKOBFMHGJF, Func<object> KLHCLJLFEDE, Action<object> IHEIGNBFAGB, Func<object, string> JAGCOCKDLCI, Func<IReadOnlyList<object>> KHPKEONMFKB, [Optional] Func<bool>? KAFLLKGIFHJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ECJLFDJPLNL(NCOIALPMEOC NNOPHBMDNNP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EPBCIBMDMGH(string ACKGOHMLJIP, Action HCKAGJEDMKE, bool LKCOLIHDGPL, string FEGEBLHMDKA, Action GAIBNGJJGJN, string LMJAPBNMKLG, string AOPEKGKJIAM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FDGBKEKIDJK(string HHMFKCLJLAI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NCOIALPMEOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AKJGJABBJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMIHAPFBOH();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HABGMFKMPGG
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMIJHDEHONG();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDJKEPCDMDC(string PHKNAOONHKB, [In] MIMCCKCJMAH KKBAHNFNJMK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AENFIOHBIBN(string LMJAPBNMKLG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIDGIJFOJAM(string DBPAHEMAAMI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MIJGGABCNJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BCIEEEAOHOF? OMCMBELJBID
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DJPELIJNFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ENCEPKEOJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<BCIEEEAOHOF> JBLIJMGOLDO();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MEEAMGFNJIM<MDPHAFPKPNH, IEAOACDDPEG> AHLPLEECDDC([In] MDPHAFPKPNH AEFCOHFEBBD, IEnumerable<DAJJDHFICPI> LEEIOGKJPKL, int NMDLGILNDBJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BCIEEEAOHOF
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct BNOBGHACFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly HCKHNCKIMEB PHEOKNIAPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly JNGCAMDGEKN MBBPDPJJPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly IEnumerable<DAJJDHFICPI> ODECAFBJCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly bool GPMIBDOMKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly MIPNFHKLOLI<IOFALGJHBGF> EFECONDMBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly int? PDAFLGIOCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly IPABAODHIGJ? IDEMPEOBFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly IPABAODHIGJ? OKFKOBEJOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly KDHIGPOINLN? EHLIICBOCIF;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1C25B30", Offset = "0x1C24F30", VA = "0x181C25B30")]
		public BNOBGHACFMA(HCKHNCKIMEB LFJJHMBODKI, [In] JNGCAMDGEKN AEFCOHFEBBD, IEnumerable<DAJJDHFICPI> LEEIOGKJPKL, bool LGDOBIONJGG, [In] MIPNFHKLOLI<IOFALGJHBGF> GLBGNLOGMAI, int? ICFLFKPHKFL, [In] IPABAODHIGJ? FLHJJEEEPIO, [In] IPABAODHIGJ? NPOCPJCLGKF, [In] KDHIGPOINLN? FPLELFOPGAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct KDHIGPOINLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly IReadOnlyCollection<ByteString> BIEODMFLKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly IReadOnlyCollection<ByteString> DMJGLIPHAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly IReadOnlyCollection<ByteString> PHHANBDGLDE;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x189C610", Offset = "0x189BA10", VA = "0x18189C610")]
		public KDHIGPOINLN(IReadOnlyCollection<ByteString> KKFMAPJMKAD, IReadOnlyCollection<ByteString> KCJJLGHEJFF, IReadOnlyCollection<ByteString> ELDNNLELJMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct FBDKOEICHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly JNGCAMDGEKN MBBPDPJJPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly IReadOnlyDictionary<Guid, Guid> NBKDHOMPGKP;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1C26870", Offset = "0x1C25C70", VA = "0x181C26870")]
		public FBDKOEICHJN(JNGCAMDGEKN AEFCOHFEBBD, IReadOnlyDictionary<Guid, Guid> CHLOKHKBBNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEKDMDCHPLL? GKPINAKEJOK([In] MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AMIHCCNNHOK? NFLKDLBDDMM([In] MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<BGDPFFMCEIB> NNPKKBGAIOC(bool NADIAMOKNDD, bool HIHDJJJICHP, bool OHEBIAELJLN, bool LPGPLGCHDIP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MEEAMGFNJIM<FBDKOEICHJN, IEAOACDDPEG> GDJDIDBCFHD([In] BNOBGHACFMA LHPGBFGMEDK);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OMAGFAABBKJ LJMIBOLEIKI(IEnumerable<DAJJDHFICPI> LEEIOGKJPKL);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OMAGFAABBKJ IFMNBHGDFHG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JNGCAMDGEKN IKAAOCGNJLL(HCKHNCKIMEB LFJJHMBODKI, IEnumerable<MIPNFHKLOLI<EHDOJPLINGC>> EIAMKGNMDMC, IEnumerable<DAJJDHFICPI> LEEIOGKJPKL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EJGCHDICGHF : MOGFPOGFDEP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MIJGGABCNJJ IEJCACLPBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DBNOAAMPCCP : IEAOACDDPEG
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AEKDMDCHPLL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CLNHMHNDLPF? EOKHNFOBDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IFHMHLGDELF : AGECCGKIHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OKFPGADAGCG<PNJPGKEBOIL> NFIDGPGIJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool COJKBHEIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJHKBEBJFPG(AKJGJABBJKP HAOLPFHKADB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANKGLGEEPJN(EENFCJBELLA MOELPIKODPE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NKMLMNCBOAP(int GCHDMCAFBKA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNODKKNKGCH(DOFBBMLIDIC BOCDMAKBFLF);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNDBOOJNHFL(DOFBBMLIDIC BOCDMAKBFLF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DOFBBMLIDIC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface AMIHCCNNHOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	object KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MIPNFHKLOLI<MKPDEFBPMHA> MKFMBMMMIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FIPNIGDNCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int ECDKMOIOOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MIMCCKCJMAH DINAFOPAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string LLHDAPMDOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NodeVisualizationKey GJLBOFLDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OKFPGADAGCG<PGIHNDFJICK> KOOFEGEFDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DFMABHJODKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EMIPLECBDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IKNDNDFPBMG HIGBLIEACEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NPBEKDFOPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GPHPBJAGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool DNBPGAFCOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int PIBHOOFLGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EPBCOJKGIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string BCLILPABKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HNLGLJCIMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CLIEAOKAIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IBHGKBGHMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FMLOEKOHPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool OPAAKILEBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	CKMHLKANGCG MBLHMGPEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	KFJPEFPIECD JFMPNIDBDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[KAMKPIAKLIN(true, "FloatingText")]
	bool AMBEKKGIFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DMDMGEGKDIJ? HJHMHEHLLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	MIPNFHKLOLI<IOFALGJHBGF> HLMJOIBMECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[HMIBGOFDLPO("This isn't great UX and we should consider removing it.")]
	bool LNJFDJHMOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MIPNFHKLOLI<IOFALGJHBGF>? HKGDLJMPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IEnumerable<MIPNFHKLOLI<EHDOJPLINGC>>? AAIFGBPGPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool PNEHCKIEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool GCMDFAAPMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MIPNFHKLOLI<EHDOJPLINGC> GHAGOGIMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	ICPGDIAEEND<OJDCJBFDJOM, KNOLOAHCOCB> MBMKEAIDBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OKFPGADAGCG<OJDCJBFDJOM>? OPCEAIGPAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MNILNBBOMKC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event AHFJAHCECIB NNJFNLEAFBO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event INGKMIDDINO GOFPKLEIFPJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action JOMCNJDIKBP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action IDCIICDPKLO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<OKFPGADAGCG<OJDCJBFDJOM>, KNOLOAHCOCB> ODFJDDNDAMB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<OKFPGADAGCG<OJDCJBFDJOM>> KBJBEOKFBEJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<OKFPGADAGCG<OJDCJBFDJOM>, KNOLOAHCOCB> DCFKDBJIGEH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<OKFPGADAGCG<OJDCJBFDJOM>, OKFPGADAGCG<OJDCJBFDJOM>> EMAILBJOPGL;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<OKFPGADAGCG<OJDCJBFDJOM>, KNOLOAHCOCB> HDPCCMPLOBO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFBCCCIDCNH(int NNMDLMALIJI);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool KDBAMBKBMAK([In] CKMHLKANGCG LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool JFOFKKNAHGL([In] KFJPEFPIECD LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AAEONGIFCPA();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> JLEOLOLGOHO(CKMHLKANGCG? EDOEDBAJLGN, KFJPEFPIECD? ALNLHNLOHOA);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DOJIAHCBNDH();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NNHCDDOANJE();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool IAJLAJEADPD([Out] Guid PIFNMNCMMHD);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool LBAFLKIEBDP([In] Guid OFLFFIGFOIA);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void CGCDLMDFFPJ();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void EJELONDJPJN(bool CAFLOMEPFIA);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "45")]
	PGIOPALILBJ ALEHLIOHJHP([In] EJFLGAEPHLO CHHFJIKJLCE);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EJOAMOOFDAI(object NOFFHLIODPB);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void GECBKNCEJMI(object NOFFHLIODPB);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void ANKGLGEEPJN(AAENHECDBJO NBADMLOMMID);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	IPABAODHIGJ HNMCGMMJCKB();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> LIPFEEBDEDN(OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LMOGDMOMPMJ : AGECCGKIHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OKFPGADAGCG<JCONNHOELGN> IMFNEBANNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface AGECCGKIHIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	IEnumerable<StaticEdge> GCNNOLOPGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DisplayKind MPGHIEDLBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MIPNFHKLOLI<IOFALGJHBGF> HLMJOIBMECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MIPNFHKLOLI<EHDOJPLINGC> GHAGOGIMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OKFPGADAGCG<OJDCJBFDJOM> GFEEOBBHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	OKFPGADAGCG<LDFAIMDADIE> PGDEMBNOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DDBPLIOJFAP NPLGDBJEJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PortImage IAJPPIHEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FNHGDOPKPJA(GOALCNDJDIC BOCDMAKBFLF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IBBOPOHIMME(HPIIBLGNLMG BOCDMAKBFLF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HJLKCMHHFEN(HABGMFKMPGG ANMFNKHEHJG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GDAEPPDDIPE(GOALCNDJDIC BOCDMAKBFLF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OGAJGJEEDFL(HPIIBLGNLMG BOCDMAKBFLF);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GOALCNDJDIC
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KNOLOAHCOCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate void GENIMIHOMIM(OKFPGADAGCG<OJDCJBFDJOM> GJFJLOBMJBE, OKFPGADAGCG<OJDCJBFDJOM> MKKHNLNBPNM);

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool HKHEJLKPAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool MLDCDKBGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool DGDJOOOBECK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MIPNFHKLOLI<IOFALGJHBGF> HLMJOIBMECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool AGOOEJGINEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	ICPGDIAEEND<PNJPGKEBOIL, IFHMHLGDELF> LJJKBJGHOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	MIPNFHKLOLI<EHDOJPLINGC> GHAGOGIMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	ICPGDIAEEND<JCONNHOELGN, LMOGDMOMPMJ> AGHGIEAHLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OKFPGADAGCG<OJDCJBFDJOM> GFEEOBBHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action LMFPHCLJNOP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<OKFPGADAGCG<PNJPGKEBOIL>, OKFPGADAGCG<PNJPGKEBOIL>> FMKJFGGEDCM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<OKFPGADAGCG<JCONNHOELGN>, OKFPGADAGCG<JCONNHOELGN>> MJKPJKCPFAM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<OKFPGADAGCG<PNJPGKEBOIL>, IFHMHLGDELF> LJHJOAFNDDO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<OKFPGADAGCG<PNJPGKEBOIL>> OGCAFCODOPM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<OKFPGADAGCG<PNJPGKEBOIL>, IFHMHLGDELF> ECEOCPJIDDM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<OKFPGADAGCG<JCONNHOELGN>, LMOGDMOMPMJ> CNIJHAOFLIF;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<OKFPGADAGCG<JCONNHOELGN>> GEFIKHCOODD;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<OKFPGADAGCG<JCONNHOELGN>, LMOGDMOMPMJ> BCLCLPODGBC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> FEDCBLIMJFA();

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> MEILANEMCOG(OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> LMJCCJCNFLA(OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> PBDHMBBHBIO(OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE, OKFPGADAGCG<COCIAMPEGDB> GJAGJOCFELH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> DOMBOIAEFCJ(OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP, OKFPGADAGCG<MDPMJJMJGJG> GJAGJOCFELH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> MNBLLEGCNIH();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> IEDMAMNCJBH(string EMGPIOIKIHM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> BLINDFKPLGF(OKFPGADAGCG<COCIAMPEGDB> CLLCDEJPLBE, string DKFEAPHKBMP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<MEEAMGFNJIM<EOKBOBHHEEM, DBNOAAMPCCP>> AEELFNJELOG(OKFPGADAGCG<MDPMJJMJGJG> HKFFKMNNMFP, string DKFEAPHKBMP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BGDPFFMCEIB
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string FKDLEOOKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MEEAMGFNJIM<OKFPGADAGCG<COCIAMPEGDB>, DBNOAAMPCCP>> IKBJBCPJFKG(MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA, MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, string DKFEAPHKBMP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MEEAMGFNJIM<OKFPGADAGCG<MDPMJJMJGJG>, DBNOAAMPCCP>> PGHMCJGBCMK(MIPNFHKLOLI<IOFALGJHBGF> OFLFFIGFOIA, MIPNFHKLOLI<EHDOJPLINGC> CNCFOBBIEIM, OKFPGADAGCG<OJDCJBFDJOM> FAOHNDGDAJK, string DKFEAPHKBMP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HPIIBLGNLMG
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed([In] ENLIGFHDFKA LADNIBKBCLD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DDBPLIOJFAP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool CHBKHGLNMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool POPEMBFEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	TypeKey GJLBOFLDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FEMJEHBOOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class MKPDEFBPMHA
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class IOFALGJHBGF
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class IPLBFBMFAKI : IIPFGNEHFFA
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class COCIAMPEGDB
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class EHDOJPLINGC
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class NLJNNFGAEGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class NCANEMCOGDP : IIPFGNEHFFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class MDPMJJMJGJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public abstract class IIPFGNEHFFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HMIBGOFDLPO("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class OJDCJBFDJOM
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class PNJPGKEBOIL : LDFAIMDADIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class JCONNHOELGN : LDFAIMDADIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class LDFAIMDADIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IINLHLEIKAC
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class PGIHNDFJICK
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class EPILCJKKECK
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class MJNKFDLHFIO
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct CLNHMHNDLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly MIPNFHKLOLI<EHDOJPLINGC> OJIHKPBJKKO;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public CLNHMHNDLPF([In] MIPNFHKLOLI<EHDOJPLINGC> FIEAEKDAGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void DJGIKLOBCMA([In] ENLIGFHDFKA LADNIBKBCLD);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		List,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		StateTransition
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void AHFJAHCECIB([In] CKMHLKANGCG FBBLIAHAPDM);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct GMNMAFJAEKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly BGDPFFMCEIB EHFEKPANFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly BGDPFFMCEIB LBBBAAEGFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly BGDPFFMCEIB OOAOMIJNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly BGDPFFMCEIB GNCADJPEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly BGDPFFMCEIB IFCMDFICLMN;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0xE967B0", Offset = "0xE95BB0", VA = "0x180E967B0")]
	public GMNMAFJAEKA(BGDPFFMCEIB FNDCNCNLEBC, BGDPFFMCEIB HHALFJFKLPN, BGDPFFMCEIB PKCNIPKPCAF, BGDPFFMCEIB NMFOLLBKEHN, BGDPFFMCEIB MMAHIBDPAHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public delegate void INGKMIDDINO([In] KFJPEFPIECD LIHLHLCNBCF);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly MIPNFHKLOLI<EHDOJPLINGC> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly OKFPGADAGCG<OJDCJBFDJOM> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly OKFPGADAGCG<JCONNHOELGN> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly MIPNFHKLOLI<EHDOJPLINGC> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly OKFPGADAGCG<OJDCJBFDJOM> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly OKFPGADAGCG<PNJPGKEBOIL> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1C28500", Offset = "0x1C27900", VA = "0x181C28500")]
		public StaticEdge([In] MIPNFHKLOLI<EHDOJPLINGC> KCOCBFCNMFD, OKFPGADAGCG<OJDCJBFDJOM> CFDILDEEDCB, OKFPGADAGCG<JCONNHOELGN> NNLHMMCDIDF, [In] MIPNFHKLOLI<EHDOJPLINGC> FFLDEHALIBH, OKFPGADAGCG<OJDCJBFDJOM> OFMCBHNCMEB, OKFPGADAGCG<PNJPGKEBOIL> PICAFAOIBDB)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1C27FA0", Offset = "0x1C273A0", VA = "0x181C27FA0")]
		public static bool HCMKGGFOPFL([In] StaticEdge AHKCLAHHIPP, [In] StaticEdge MHLPFPGAPOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1C27DC0", Offset = "0x1C271C0", VA = "0x181C27DC0", Slot = "4")]
		public bool Equals(StaticEdge KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1C27D10", Offset = "0x1C27110", VA = "0x181C27D10", Slot = "0")]
		public override bool Equals(object IBBNLILJNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1C27EB0", Offset = "0x1C272B0", VA = "0x181C27EB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1C28090", Offset = "0x1C27490", VA = "0x181C28090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NBHPIAEPAJE
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1C276C0", Offset = "0x1C26AC0", VA = "0x181C276C0")]
	public static StaticEdge HNNKJEMPCFP(this DGFJKBBGOOL CLFMFOEGLFG)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct JGLHPEPHDFK : IEquatable<JGLHPEPHDFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string HDPHDEPACKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly int IDILNCOPBAL;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1634980", Offset = "0x1633D80", VA = "0x181634980")]
	public JGLHPEPHDFK(string CMKNABKHAEG, int FFCCCKPCCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1C27670", Offset = "0x1C26A70", VA = "0x181C27670", Slot = "4")]
	public bool Equals(JGLHPEPHDFK KEEHOGPOIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct PONGGKLLDCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string PDBKHDHIBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly OMAINAHDOID.GMMFNFNPOIG.HKDNCDPKKEK PLEPAFMJACD;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1634980", Offset = "0x1633D80", VA = "0x181634980")]
	public PONGGKLLDCG(string DKFEAPHKBMP, OMAINAHDOID.GMMFNFNPOIG.HKDNCDPKKEK OKPLGFAJBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1C279C0", Offset = "0x1C26DC0", VA = "0x181C279C0")]
	internal static PONGGKLLDCG HNNKJEMPCFP(OMAINAHDOID OOIBMCBCEPD)
	{
		return default(PONGGKLLDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1C27A10", Offset = "0x1C26E10", VA = "0x181C27A10")]
	internal OMAINAHDOID MFIMBGNEKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1C27950", Offset = "0x1C26D50", VA = "0x181C27950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1C278A0", Offset = "0x1C26CA0", VA = "0x181C278A0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1C27670", Offset = "0x1C26A70", VA = "0x181C27670")]
	public bool CEGAHNPOGGI(PONGGKLLDCG KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1C27A80", Offset = "0x1C26E80", VA = "0x181C27A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct GAMGBCMCOEG : IEquatable<GAMGBCMCOEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly BPPHNJNEHHM DJCNLJMEDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string DDLCKCOLNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly IReadOnlyDictionary<MIPNFHKLOLI<MJNKFDLHFIO>, JGLHPEPHDFK> FNINEOIHGPL;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool ADBIFDDOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C268B0", Offset = "0x1C25CB0", VA = "0x181C268B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1C272F0", Offset = "0x1C266F0", VA = "0x181C272F0")]
	public GAMGBCMCOEG(BPPHNJNEHHM FIHCCDKOAMJ, IReadOnlyDictionary<MIPNFHKLOLI<MJNKFDLHFIO>, JGLHPEPHDFK> DKLLFIOFJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1C26E00", Offset = "0x1C26200", VA = "0x181C26E00")]
	public static GAMGBCMCOEG HNNKJEMPCFP(HICCLNIKKCP OOIBMCBCEPD)
	{
		return default(GAMGBCMCOEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C27150", Offset = "0x1C26550", VA = "0x181C27150")]
	public HICCLNIKKCP MFIMBGNEKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1C26930", Offset = "0x1C25D30", VA = "0x181C26930", Slot = "4")]
	public bool Equals(GAMGBCMCOEG KEEHOGPOIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct BPPHNJNEHHM : IEquatable<BPPHNJNEHHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string PDBKHDHIBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly IReadOnlyList<PONGGKLLDCG> LJJKBJGHOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly IReadOnlyList<PONGGKLLDCG> AGHGIEAHLPC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool ADBIFDDOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1C25BE0", Offset = "0x1C24FE0", VA = "0x181C25BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x189C610", Offset = "0x189BA10", VA = "0x18189C610")]
	public BPPHNJNEHHM(string DKFEAPHKBMP, IReadOnlyList<PONGGKLLDCG> JHGMILLGKGF, IReadOnlyList<PONGGKLLDCG> ACJLOKFCAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1C25F20", Offset = "0x1C25320", VA = "0x181C25F20")]
	public static BPPHNJNEHHM HNNKJEMPCFP(EJPCCIKDHNA OOIBMCBCEPD)
	{
		return default(BPPHNJNEHHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1C26200", Offset = "0x1C25600", VA = "0x181C26200")]
	public EJPCCIKDHNA MFIMBGNEKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1C25EA0", Offset = "0x1C252A0", VA = "0x181C25EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1C25CB0", Offset = "0x1C250B0", VA = "0x181C25CB0")]
	private static int FDMPGFJJBMI(IReadOnlyList<PONGGKLLDCG> FKHDBBANCOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1C25C00", Offset = "0x1C25000", VA = "0x181C25C00", Slot = "4")]
	public bool Equals(BPPHNJNEHHM KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1C26490", Offset = "0x1C25890", VA = "0x181C26490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum HCKHNCKIMEB
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HDEKACDHPCI
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA71250", Offset = "0xA70650", VA = "0x180A71250")]
	public static bool PAFBKKMOBBF(this HCKHNCKIMEB GDMNFOHPCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA71250", Offset = "0xA70650", VA = "0x180A71250")]
	public static bool OILPJHFKIJK(this HCKHNCKIMEB GDMNFOHPCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA71250", Offset = "0xA70650", VA = "0x180A71250")]
	public static bool DDDAEBIKFEG(this HCKHNCKIMEB GDMNFOHPCNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum NMJELPJADAG
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct ENLIGFHDFKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool MIABCCLNABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly NMJELPJADAG JKPMPAGKKNE;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1C26860", Offset = "0x1C25C60", VA = "0x181C26860")]
	public ENLIGFHDFKA(bool FGCAJAJNOEE, NMJELPJADAG JEENMPGLKIJ)
	{
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
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
