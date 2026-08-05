using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6534BB0", Offset = "0x65333B0", VA = "0x186534BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OMDHFNOGOHN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PBOBDIKKDID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GKMGNMPDBOB OJKJEPNBCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<HFGPNGHDOCH> JGJOGJCKAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AADEHAMLMBP ABDKNIEPENI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<HFGPNGHDOCH> KCNBLGOBCHC(bool MFAKDBOCOAA = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HFGPNGHDOCH EALCFKLEKKA(BNKEEFOCAMM KIPCLIECBNA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OHCNLNCGKLM(BNKEEFOCAMM KIPCLIECBNA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<HFGPNGHDOCH> JKMFNNGJBKL(BNKEEFOCAMM KIPCLIECBNA, bool AHONHGEELCE = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FCDFOCGCIBP(BNKEEFOCAMM CHFJEEHCEPM, EGDAOAMAONG OMGGENADPMH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HFGPNGHDOCH CIMFBHFAFJL(EGDAOAMAONG OMGGENADPMH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FOKKJCJHPCJ<T>(EGDAOAMAONG OMGGENADPMH, MMPHPNHNBDD MOPCMJIBMOH, bool OGECMJNDJJE, T FFIGANEHPFB) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OHFFCAFBLDD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MGGLEPIAEDA(KHHPFHOAEJL LHKEKFAGIAO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGNGLHPMJCL(ref KHHPFHOAEJL LHKEKFAGIAO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NEKMNHEBPAK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GINHCCABGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MCBMOFOPHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FDJLOGOFJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CCFDLDKHNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool GKENJJCOEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ONANBIDMOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IEJOCOLNMDC
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<EGDAOAMAONG> NDJGFJOKJFE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x652DDC0", Offset = "0x652C5C0", VA = "0x18652DDC0")]
	public static bool BFBOKABHLKC(this BNKEEFOCAMM KIHPDBAJKAD, EGDAOAMAONG OMGGENADPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x652DEB0", Offset = "0x652C6B0", VA = "0x18652DEB0")]
	public static bool GJAFNGPLLHM(this BNKEEFOCAMM KIHPDBAJKAD, EGDAOAMAONG OMGGENADPMH, JEELLOGMCHC POGGBOCFANE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class MJAACMBHKCF : JIOGHEKDEGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly PBOBDIKKDID MCHJCLGADEB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	[RecRoom.NoEngine.Common.Preserve]
	public MJAACMBHKCF([JHPEMCNOMHI(null)] PBOBDIKKDID ONKIPJGJNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6534630", Offset = "0x6532E30", VA = "0x186534630")]
	private static BLMAHMEMFHE? ENCAHLOHCNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6534520", Offset = "0x6532D20", VA = "0x186534520", Slot = "4")]
	public bool DGOGHEOFHLE(BNKEEFOCAMM DBJCJMOBBIC, BNKEEFOCAMM GJEKNLLOIJN, IEnumerable<BNKEEFOCAMM> KLFHNEMENEF, out OMDHFNOGOHN PLHGKBNAFBA, out MGOJIJNKBHN IDLNFKCFIOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6534680", Offset = "0x6532E80", VA = "0x186534680")]
	internal bool MDHDHHHPOOC(BNKEEFOCAMM DBJCJMOBBIC, BNKEEFOCAMM GJEKNLLOIJN, IEnumerable<BNKEEFOCAMM> KLFHNEMENEF, JEELLOGMCHC POGGBOCFANE, BLMAHMEMFHE? AAGIGOOEKKN, out OMDHFNOGOHN PLHGKBNAFBA, out MGOJIJNKBHN IDLNFKCFIOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HFJLGEBCKNH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string LGAMFIGFOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KBEOLCJLOOP<TPermission> FNCNGOLFJCI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void KBEOLCJLOOP<TPermission>(TPermission MOPCMJIBMOH);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void AADEHAMLMBP(BNKEEFOCAMM KIPCLIECBNA);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class ABEBEIKDCPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string FNCHNPJAGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type AKOIEGGFJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly INFODCDBJFA GJKDPPOCHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly MMPHPNHNBDD MPINEEBEALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NEGGBIKGCPI HPMFBLICDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GOAAMKHKGAL EHKGBBGCGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public AIPFIACKCHP MCLPNKMEODK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x652A830", Offset = "0x6529030", VA = "0x18652A830")]
	public ABEBEIKDCPC(Type MIGOMMLOIAA, string PCCFCNIMEFM, MMPHPNHNBDD MOPCMJIBMOH, NEGGBIKGCPI JODBLGBDGPH, GOAAMKHKGAL FNHBGFNFEFA, AIPFIACKCHP AIEMIBOJIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x652A740", Offset = "0x6528F40", VA = "0x18652A740")]
	public object ABNHHGNDCFF(object? OALEAAIPGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x119D360", Offset = "0x119BB60", VA = "0x18119D360")]
	public void LGDJGIPJIMF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x652A780", Offset = "0x6528F80", VA = "0x18652A780")]
	public void LGDJGIPJIMF(Type AOOFBMFBPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class KBACKDAJJCO<T> : ABEBEIKDCPC where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string LBDEDKIGHMG(T MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T HGEMMOHHKOL(string? ILNIJCIMJCH, T GFJIAKNDNMH);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class IGLMAAABEKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public LBDEDKIGHMG serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HGEMMOHHKOL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public IGLMAAABEKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2499C80", Offset = "0x2498480", VA = "0x182499C80")]
		internal string DCAPKAENBHC(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2499B30", Offset = "0x2498330", VA = "0x182499B30")]
		internal object AFBKOBLJPLD(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30591A0", Offset = "0x30579A0", VA = "0x1830591A0")]
	public KBACKDAJJCO(MMPHPNHNBDD MOPCMJIBMOH, string PCCFCNIMEFM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DB420", Offset = "0x6DA820")] KBACKDAJJCO<T>.LBDEDKIGHMG JODBLGBDGPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DB480", Offset = "0x6DA880")] KBACKDAJJCO<T>.HGEMMOHHKOL FNHBGFNFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3058400", Offset = "0x3056C00", VA = "0x183058400")]
	private static object? KLHPMPNNHAA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DB4E0", Offset = "0x6DA8E0")] KBACKDAJJCO<T?>.HGEMMOHHKOL? FNHBGFNFEFA, string? ILNIJCIMJCH, object? GFJIAKNDNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3058100", Offset = "0x3056900", VA = "0x183058100")]
	private static string CLIBMONIMNB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DB540", Offset = "0x6DA940")] KBACKDAJJCO<T>.LBDEDKIGHMG JHMIDNPIMHC, object? MENBIMCLIOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BHKPJLNKOFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BNKEEFOCAMM BPGDLLGCJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EIEEEHDKLAP OLAMOAGMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JEELLOGMCHC DDMPEFJPIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HIJCOEIBONI> HMMMMOKIFNI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action NKDMIMGALMO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EGDAOAMAONG JFOFDPKFMAM(BNKEEFOCAMM KIPCLIECBNA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HIJCOEIBONI> BDBEKBAPGLN(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HHNNGKNJDLE(long AFGKPOPONBN, long HILPLFHHAPA, IReadOnlyList<GAEALHGMBNK> GAFJDAJAJNH);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<BNKEEFOCAMM> LJOCAOEDOAM();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OAMACGLDFCA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6534C40", Offset = "0x6533440", VA = "0x186534C40")]
	public static EGDAOAMAONG HMHFPMDPNEC(this BHKPJLNKOFB NDPMPNBOBLI)
	{
		return default(EGDAOAMAONG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class OEIBGPKLLFN : HFGPNGHDOCH, BNDLMIHNGHC, NEKMNHEBPAK, HFJLGEBCKNH<MMPHPNHNBDD>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly AIPBCGINMNN CFHPEFDECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly ICPADLJCHDM GMJJAOPPNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? DBGGKIANIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? JMCODPADMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool ELFKBIDGGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x65355D0", Offset = "0x6533DD0", VA = "0x1865355D0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool HFCPCPCNCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6534CA0", Offset = "0x65334A0", VA = "0x186534CA0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool LBCHDKKPKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6536910", Offset = "0x6535110", VA = "0x186536910", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool GJDKCCNIHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6535AB0", Offset = "0x65342B0", VA = "0x186535AB0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool JFBKKHCBEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6536AC0", Offset = "0x65352C0", VA = "0x186536AC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool ICPDKAKJDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6536C00", Offset = "0x6535400", VA = "0x186536C00", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EGDAOAMAONG KNGEECICLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F14D0", Offset = "0x8EFCD0", VA = "0x1808F14D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(EGDAOAMAONG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA3F030", Offset = "0xA3D830", VA = "0x180A3F030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string LGAMFIGFOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6536BB0", Offset = "0x65353B0", VA = "0x186536BB0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6536A70", Offset = "0x6535270", VA = "0x186536A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string NPLJDGDDDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6536BB0", Offset = "0x65353B0", VA = "0x186536BB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool FEKBECKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8E7500", Offset = "0x8E5D00", VA = "0x1808E7500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8E7470", Offset = "0x8E5C70", VA = "0x1808E7470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ODJKNBEIKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6535180", Offset = "0x6533980", VA = "0x186535180", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OMDHFNOGOHN NGFKJOBABHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6536A20", Offset = "0x6535220", VA = "0x186536A20", Slot = "20")]
		get
		{
			return default(OMDHFNOGOHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PGHGKMALLJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6535090", Offset = "0x6533890", VA = "0x186535090", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NOGGJCONNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6536C50", Offset = "0x6535450", VA = "0x186536C50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool LOLCHLKMPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6535580", Offset = "0x6533D80", VA = "0x186535580", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool PKLCJHFHGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6535530", Offset = "0x6533D30", VA = "0x186535530", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool IAIBFAKGPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6535620", Offset = "0x6533E20", VA = "0x186535620", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool AOKJFKADMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6535BB0", Offset = "0x65343B0", VA = "0x186535BB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HBANEKDCHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65359C0", Offset = "0x65341C0", VA = "0x1865359C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JHFACKABIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6536CF0", Offset = "0x65354F0", VA = "0x186536CF0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> MIJEKPIBDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6535B50", Offset = "0x6534350", VA = "0x186535B50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool BBILIHPHAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65355D0", Offset = "0x6533DD0", VA = "0x1865355D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool DHELDPEDIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6536AC0", Offset = "0x65352C0", VA = "0x186536AC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool BHNKOAKIJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6534CA0", Offset = "0x65334A0", VA = "0x186534CA0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool OGOBDIDABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6536CA0", Offset = "0x65354A0", VA = "0x186536CA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool BNPADBADLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6535B00", Offset = "0x6534300", VA = "0x186535B00", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FFOBCJIDLCH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6536910", Offset = "0x6535110", VA = "0x186536910", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool AGJGCGJCIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x65351D0", Offset = "0x65339D0", VA = "0x1865351D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JFGOOIDBGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6535AB0", Offset = "0x65342B0", VA = "0x186535AB0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FOFFOFHGFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6536C00", Offset = "0x6535400", VA = "0x186536C00", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KBEOLCJLOOP<MMPHPNHNBDD> FNCNGOLFJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6535A10", Offset = "0x6534210", VA = "0x186535A10", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6536980", Offset = "0x6535180", VA = "0x186536980", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2BF66A0", Offset = "0x2BF4EA0", VA = "0x182BF66A0", Slot = "6")]
	public (bool, T?) EACOCIHJLKN<T>(MMPHPNHNBDD MOPCMJIBMOH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6660", Offset = "0x2BF4E60", VA = "0x182BF6660")]
	public OEIBGPKLLFN DDCCKPJKOLA<T>(MMPHPNHNBDD MOPCMJIBMOH, bool OGECMJNDJJE, T MENBIMCLIOI) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6536FA0", Offset = "0x65357A0", VA = "0x186536FA0")]
	public OEIBGPKLLFN(EGDAOAMAONG OMGGENADPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6536FC0", Offset = "0x65357C0", VA = "0x186536FC0")]
	public OEIBGPKLLFN(EGDAOAMAONG OMGGENADPMH, [Optional] string? DBGGKIANIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6536F10", Offset = "0x6535710", VA = "0x186536F10")]
	public OEIBGPKLLFN(OEIBGPKLLFN FAKGJMMFNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6536DB0", Offset = "0x65355B0", VA = "0x186536DB0")]
	internal OEIBGPKLLFN(EGDAOAMAONG HEJKFHEKJEN, [Optional] string? DBGGKIANIOE, [Optional] OEIBGPKLLFN? FAKGJMMFNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6535220", Offset = "0x6533A20", VA = "0x186535220")]
	public static INFODCDBJFA DJCALCHLCHD(MMPHPNHNBDD MOPCMJIBMOH)
	{
		return default(INFODCDBJFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6536960", Offset = "0x6535160", VA = "0x186536960")]
	public void JOEBOFELGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65352A0", Offset = "0x6533AA0", VA = "0x1865352A0")]
	internal OEIBGPKLLFN DLPPLJJPEKC(OEIBGPKLLFN GPKJEMGNBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6534CF0", Offset = "0x65334F0", VA = "0x186534CF0")]
	internal IReadOnlyCollection<MMPHPNHNBDD> BBGJPJPLCPO(OEIBGPKLLFN FAKGJMMFNIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6536830", Offset = "0x6535030", VA = "0x186536830")]
	public bool JAGHLLAMOCH(MMPHPNHNBDD MOPCMJIBMOH, bool OGECMJNDJJE, string ENNPLBNLBEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6535670", Offset = "0x6533E70", VA = "0x186535670")]
	public (bool, string) FGHBHHBDBIF(MMPHPNHNBDD MOPCMJIBMOH)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6536B10", Offset = "0x6535310", VA = "0x186536B10")]
	internal void LNDNANDPNEE(MMPHPNHNBDD MOPCMJIBMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6535780", Offset = "0x6533F80", VA = "0x186535780")]
	public ODHIFFFBEEI FOBKACAPNOI(Func<EGDAOAMAONG, Guid> AMDDEDPAKNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6535C00", Offset = "0x6534400", VA = "0x186535C00")]
	public void IJGEBDJAPMF(ODHIFFFBEEI DMLJLLNOOMH, Func<Guid, EGDAOAMAONG> FBCCLEKCKCI, [Optional] EGDAOAMAONG? CBOOOPPBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x65350E0", Offset = "0x65338E0", VA = "0x1865350E0")]
	[CompilerGenerated]
	private void CFKKKEIOHPH(MMPHPNHNBDD DDPKGAAOLPM, LNCMMNMGJHE OMMAFHCKLOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JIOGHEKDEGD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGOGHEOFHLE(BNKEEFOCAMM DBJCJMOBBIC, BNKEEFOCAMM GJEKNLLOIJN, IEnumerable<BNKEEFOCAMM> KLFHNEMENEF, out OMDHFNOGOHN PLHGKBNAFBA, out MGOJIJNKBHN IDLNFKCFIOL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MGOJIJNKBHN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BNDLMIHNGHC
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ODJKNBEIKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool PGHGKMALLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool NOGGJCONNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool LOLCHLKMPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool PKLCJHFHGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool IAIBFAKGPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool AOKJFKADMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool HBANEKDCHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool JHFACKABIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool OGOBDIDABHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool BNPADBADLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool AGJGCGJCIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> MIJEKPIBDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OMDHFNOGOHN NGFKJOBABHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HFGPNGHDOCH : BNDLMIHNGHC, NEKMNHEBPAK, HFJLGEBCKNH<MMPHPNHNBDD>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string NPLJDGDDDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EGDAOAMAONG KNGEECICLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) EACOCIHJLKN<T>(MMPHPNHNBDD MOPCMJIBMOH) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class BEFMGBIFEMD
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? AGDBGBDEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	protected BEFMGBIFEMD(object? DOCBAEFLPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DCLIJHBOMFC(object? MENBIMCLIOI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class PNNLBHMPCMH<T> : BEFMGBIFEMD where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T LLMMNLEPFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> HFFLNDGMJDI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8F14D0", Offset = "0x8EFCD0", VA = "0x1808F14D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2859330", Offset = "0x2857B30", VA = "0x182859330", Slot = "4")]
	public override bool DCLIJHBOMFC(object? MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x28598A0", Offset = "0x28580A0", VA = "0x1828598A0")]
	public bool GENCMOFAANB(T MKIBNHFKBLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2859BC0", Offset = "0x28583C0", VA = "0x182859BC0")]
	public PNNLBHMPCMH(T GFJIAKNDNMH, IEqualityComparer<T> HFFLNDGMJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class CIJMCIMGKDF
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum EJHMMNGDPLH
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly Guid CHKNNLEACPA;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid DJBJIGKJEBL;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid JKBAJFEOJAD;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid KKFEMHIINDG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid NKABNDPHKHM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly CCKPCFBJMIL<EGDAOAMAONG, Guid> IPJJCGMLAOM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<EGDAOAMAONG> LMEPOOIELJD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x652C760", Offset = "0x652AF60", VA = "0x18652C760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x652C7E0", Offset = "0x652AFE0", VA = "0x18652C7E0")]
	public static EGDAOAMAONG PIIPAHGDJKE(Guid IBLFHKFALNL)
	{
		return default(EGDAOAMAONG);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x652C610", Offset = "0x652AE10", VA = "0x18652C610")]
	public static Guid GPCCDCIIALO(EGDAOAMAONG OMGGENADPMH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x652C530", Offset = "0x652AD30", VA = "0x18652C530")]
	public static bool EOBNMABCBMD(EGDAOAMAONG OMGGENADPMH, out Guid IBLFHKFALNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x652C6C0", Offset = "0x652AEC0", VA = "0x18652C6C0")]
	public static bool HABOJIFEAKO(Guid IBLFHKFALNL, out EGDAOAMAONG OMGGENADPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x652C450", Offset = "0x652AC50", VA = "0x18652C450")]
	public static EGDAOAMAONG CDGNGPJKAPG(EGDAOAMAONG OMGGENADPMH)
	{
		return default(EGDAOAMAONG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x652C480", Offset = "0x652AC80", VA = "0x18652C480")]
	public static EJHMMNGDPLH ELHJHHNDNAE(EGDAOAMAONG LBAADLJKBLI)
	{
		return default(EJHMMNGDPLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x652C5D0", Offset = "0x652ADD0", VA = "0x18652C5D0")]
	internal static EGDAOAMAONG GAKMNBMBAKN(EJHMMNGDPLH NAPEDMNDIEO)
	{
		return default(EGDAOAMAONG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string NEGGBIKGCPI(object? MENBIMCLIOI);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object GOAAMKHKGAL(string? ILNIJCIMJCH, [Optional] object GFJIAKNDNMH);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate BEFMGBIFEMD AIPFIACKCHP();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class AIPBCGINMNN
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class FBPKIEFBIDC : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static FBPKIEFBIDC OEFAOPMNMGM;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x652CE60", Offset = "0x652B660", VA = "0x18652CE60", Slot = "4")]
		public bool Equals(List<string> FBGKLELIKCG, List<string> LFJEFFKGLOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x652CFC0", Offset = "0x652B7C0", VA = "0x18652CFC0", Slot = "5")]
		public int GetHashCode(List<string> CEPDEAHBHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FBPKIEFBIDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class EDCJHGIGFKK : LMHFGKKLBKE<OMDHFNOGOHN>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x652CD30", Offset = "0x652B530", VA = "0x18652CD30", Slot = "9")]
		public override string CLIBMONIMNB(OMDHFNOGOHN OADMIGAEKPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x652CB40", Offset = "0x652B340", VA = "0x18652CB40", Slot = "10")]
		protected override bool AIDGCEPJHHB(string OADMIGAEKPI, out OMDHFNOGOHN MENBIMCLIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x652CE20", Offset = "0x652B620", VA = "0x18652CE20")]
		public EDCJHGIGFKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly LMMOEDPHJDE OFMNMOKHEIE;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly EDCJHGIGFKK KMECCOPLABN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<ABEBEIKDCPC> ONELGGLNMID;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<MMPHPNHNBDD> MNNEIAFEMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<MMPHPNHNBDD, ABEBEIKDCPC> KPBFHLMBKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x652B4A0", Offset = "0x6529CA0", VA = "0x18652B4A0")]
	public AIPBCGINMNN([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DB620", Offset = "0x6DAA20")] IList<ABEBEIKDCPC> MIOHHGDCBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x652A8C0", Offset = "0x65290C0", VA = "0x18652A8C0")]
	public ABEBEIKDCPC GMJOPKDBKHC(MMPHPNHNBDD MOPCMJIBMOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KKMAMDKJNNK : OHFFCAFBLDD, PBOBDIKKDID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class GKFCMINEMAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public OEIBGPKLLFN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GKFCMINEMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x652D170", Offset = "0x652B970", VA = "0x18652D170")]
		internal bool NGBEHJMPILE(OEIBGPKLLFN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FMHDOHFBNKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EGDAOAMAONG roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FMHDOHFBNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x652D160", Offset = "0x652B960", VA = "0x18652D160")]
		internal bool BGDPOIHAFBL(EGDAOAMAONG r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PIKFLOHNJKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KHHPFHOAEJL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public KKMAMDKJNNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private HIJCOEIBONI <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private HIJCOEIBONI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DBBB0", Offset = "0x6DAFB0")]
		private TaskAwaiter<HIJCOEIBONI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PIKFLOHNJKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6536FE0", Offset = "0x65357E0", VA = "0x186536FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IIHJKLPGIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IIHJKLPGIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x652E230", Offset = "0x652CA30", VA = "0x18652E230")]
		internal void HCNNJFGEAMH(ODHIFFFBEEI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x652E100", Offset = "0x652C900", VA = "0x18652E100")]
		internal void AIHDEGAMBNJ(ODHIFFFBEEI r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ALJFGOKMKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KHHPFHOAEJL roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GMIIFCPKDJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DBC10", Offset = "0x6DB010")]
		public Func<ODHIFFFBEEI, LNCMMNMGJHE> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GMIIFCPKDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x652D1A0", Offset = "0x652B9A0", VA = "0x18652D1A0")]
		internal void JBOOLEBFBJK(ODHIFFFBEEI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x652D280", Offset = "0x652BA80", VA = "0x18652D280")]
		internal void NNJPPGHIEMK(ODHIFFFBEEI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x652D210", Offset = "0x652BA10", VA = "0x18652D210")]
		internal void KHCHCAPAKNO(ODHIFFFBEEI r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LKHJEHIHKJH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public LKHJEHIHKJH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private object <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private Exception <ex>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DBCD0", Offset = "0x6DB0D0")]
			private TaskAwaiter<HIJCOEIBONI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x19541D0", Offset = "0x19529D0", VA = "0x1819541D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public KKMAMDKJNNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public MMPHPNHNBDD rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EGDAOAMAONG accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public INFODCDBJFA recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public LKHJEHIHKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2031270", Offset = "0x202FA70", VA = "0x182031270")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LKHJEHIHKJH<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void INEJPJOHJJI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct LBCGBLANLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<GAEALHGMBNK> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class AJNJDINKNPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public BHKPJLNKOFB rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KHHPFHOAEJL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DBD30", Offset = "0x6DB130")]
		public IReadOnlyDictionary<EGDAOAMAONG, OEIBGPKLLFN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FNFJKICMOJE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DBD90", Offset = "0x6DB190")]
		private List<GAEALHGMBNK> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<ODHIFFFBEEI> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private ODHIFFFBEEI <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private EGDAOAMAONG <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private OEIBGPKLLFN <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<MMPHPNHNBDD> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<MMPHPNHNBDD> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private MMPHPNHNBDD <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private INFODCDBJFA <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DBDF0", Offset = "0x6DB1F0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AJNJDINKNPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x652B810", Offset = "0x652A010", VA = "0x18652B810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly BHKPJLNKOFB NDPMPNBOBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JLCEDEIEBJH JHMOHNOIICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FNFJKICMOJE IMLNKEDJGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, OEIBGPKLLFN> FGPFIMOEKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<EGDAOAMAONG, OEIBGPKLLFN> ABBGMOKOOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<EGDAOAMAONG, OEIBGPKLLFN> DLPLLJEJLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<OEIBGPKLLFN> FMPNCGODEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool BPHIMEALCAK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly MMPHPNHNBDD[] OHKGPPNPLKM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GKMGNMPDBOB OJKJEPNBCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<HFGPNGHDOCH> JGJOGJCKAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6531FD0", Offset = "0x65307D0", VA = "0x186531FD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event AADEHAMLMBP ABDKNIEPENI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6533280", Offset = "0x6531A80", VA = "0x186533280", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x65320A0", Offset = "0x65308A0", VA = "0x1865320A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x652F8D0", Offset = "0x652E0D0", VA = "0x18652F8D0")]
	[NFOBBCLLFPP(GBHJCKJMBFK.Room, BGPNPCEMJLD.None)]
	private static void EKIONAIJAEJ(LIFDIPFHEEA IPBKDPBLBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6534290", Offset = "0x6532A90", VA = "0x186534290")]
	[UnityEngine.Scripting.Preserve]
	internal KKMAMDKJNNK([JHPEMCNOMHI(null)] BHKPJLNKOFB FGABLLJLCGC, [JHPEMCNOMHI(null)] JLCEDEIEBJH BIHPMHMOLJI, [JHPEMCNOMHI(null)] FNFJKICMOJE IMLNKEDJGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x652F6B0", Offset = "0x652DEB0", VA = "0x18652F6B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x65308C0", Offset = "0x652F0C0", VA = "0x1865308C0")]
	private void IDNOEAGADFG(IEnumerable<OEIBGPKLLFN> PFACKDFJMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6533320", Offset = "0x6531B20", VA = "0x186533320", Slot = "12")]
	public bool OHCNLNCGKLM(BNKEEFOCAMM KIPCLIECBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6533250", Offset = "0x6531A50", VA = "0x186533250")]
	private void NKDMIMGALMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x65323C0", Offset = "0x6530BC0", VA = "0x1865323C0")]
	private void KPIHDAHCMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6532020", Offset = "0x6530820", VA = "0x186532020", Slot = "10")]
	public IReadOnlyList<HFGPNGHDOCH> KCNBLGOBCHC(bool MFAKDBOCOAA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x652F7C0", Offset = "0x652DFC0", VA = "0x18652F7C0", Slot = "11")]
	public HFGPNGHDOCH EALCFKLEKKA(BNKEEFOCAMM KIPCLIECBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x652FC10", Offset = "0x652E410", VA = "0x18652FC10")]
	private EGDAOAMAONG GGDPDFKBBGN(BNKEEFOCAMM KIPCLIECBNA)
	{
		return default(EGDAOAMAONG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x652FA80", Offset = "0x652E280", VA = "0x18652FA80", Slot = "14")]
	public bool FCDFOCGCIBP(BNKEEFOCAMM CHFJEEHCEPM, EGDAOAMAONG OMGGENADPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x652F600", Offset = "0x652DE00", VA = "0x18652F600", Slot = "15")]
	public HFGPNGHDOCH CIMFBHFAFJL(EGDAOAMAONG OMGGENADPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x652EF30", Offset = "0x652D730", VA = "0x18652EF30")]
	private static bool BBHAEJIBJFJ(CHCIOOHOKIH MPMAPIOLBDG, EGDAOAMAONG OMGGENADPMH, out ODHIFFFBEEI? PLHONFAIHJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x65305C0", Offset = "0x652EDC0", VA = "0x1865305C0")]
	private static void GNIBENNKOBB(CHCIOOHOKIH MPMAPIOLBDG, Action<ODHIFFFBEEI> DELMCIBIECI, EGDAOAMAONG GEDEMAPLNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x65306C0", Offset = "0x652EEC0", VA = "0x1865306C0")]
	private static void GNIBENNKOBB(CHCIOOHOKIH MPMAPIOLBDG, Action<ODHIFFFBEEI> DELMCIBIECI, Predicate<EGDAOAMAONG> CHMEAFAOKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6532540", Offset = "0x6530D40", VA = "0x186532540")]
	private void LBMCHNFNGAF(BNKEEFOCAMM KIPCLIECBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6532EC0", Offset = "0x65316C0", VA = "0x186532EC0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIKFLOHNJKC))]
	public Task MGGLEPIAEDA([CanBeNull] KHHPFHOAEJL LHKEKFAGIAO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
	public void LGNGLHPMJCL(ref KHHPFHOAEJL LHKEKFAGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6532140", Offset = "0x6530940", VA = "0x186532140")]
	private void KNMACDHPHNG(CHCIOOHOKIH GKKNPKNEFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6533A80", Offset = "0x6532280", VA = "0x186533A80")]
	internal static string OOODHOAPHDK(BHKPJLNKOFB NDPMPNBOBLI, KHHPFHOAEJL LHKEKFAGIAO, IReadOnlyDictionary<EGDAOAMAONG, OEIBGPKLLFN> ABBGMOKOOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x65310B0", Offset = "0x652F8B0", VA = "0x1865310B0")]
	private static void JDGNKNMEELM(KHHPFHOAEJL LHKEKFAGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x65333F0", Offset = "0x6531BF0", VA = "0x1865333F0")]
	private static void OLHNDLAAOKI(CHCIOOHOKIH BEMDLIADHAG, IReadOnlyDictionary<EGDAOAMAONG, OEIBGPKLLFN> ABBGMOKOOKH, StringBuilder HPBGJHOHMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6532740", Offset = "0x6530F40", VA = "0x186532740")]
	private static bool LPHIIDCBCAF(string FNBOIBOPFBI, out Guid PGHNJEPNBLL, out EGDAOAMAONG OMGGENADPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x65328A0", Offset = "0x65310A0", VA = "0x1865328A0")]
	private static void MDFNKJAJBGO(KHHPFHOAEJL LHKEKFAGIAO, StringBuilder HPBGJHOHMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9A9360", Offset = "0x9A7B60", VA = "0x1809A9360", Slot = "16")]
	public bool FOKKJCJHPCJ<T>(EGDAOAMAONG OMGGENADPMH, MMPHPNHNBDD MOPCMJIBMOH, bool OGECMJNDJJE, T FFIGANEHPFB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6530410", Offset = "0x652EC10", VA = "0x186530410")]
	private void GLIHIMKOGOD(EGDAOAMAONG OMGGENADPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6533260", Offset = "0x6531A60", VA = "0x186533260")]
	private bool NKMGHCLBGBD(BNKEEFOCAMM KIPCLIECBNA, EGDAOAMAONG OMGGENADPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6533DA0", Offset = "0x65325A0", VA = "0x186533DA0")]
	internal OEIBGPKLLFN PFDLJJDDKPM(BNKEEFOCAMM KIPCLIECBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6531FC0", Offset = "0x65307C0", VA = "0x186531FC0", Slot = "13")]
	public IReadOnlyList<HFGPNGHDOCH> JKMFNNGJBKL(BNKEEFOCAMM KIPCLIECBNA, bool AHONHGEELCE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6533030", Offset = "0x6531830", VA = "0x186533030")]
	internal IReadOnlyList<OEIBGPKLLFN> MLNBMHLEKEO(BNKEEFOCAMM KIPCLIECBNA, bool AHONHGEELCE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x652FCD0", Offset = "0x652E4D0", VA = "0x18652FCD0")]
	private void GIGFGJHLGCI(HIJCOEIBONI DIJFMELABNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x652EC50", Offset = "0x652D450", VA = "0x18652EC50")]
	private static bool AKMIFPHAMNL(OEIBGPKLLFN AAMGJGMJDNG, IReadOnlyDictionary<EGDAOAMAONG, OEIBGPKLLFN> ABBGMOKOOKH, out IReadOnlyList<MMPHPNHNBDD> KDJIENNMOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x65325A0", Offset = "0x6530DA0", VA = "0x1865325A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJNJDINKNPP))]
	private static Task LFLFBAKAEJB(BHKPJLNKOFB NDPMPNBOBLI, KHHPFHOAEJL LHKEKFAGIAO, IReadOnlyDictionary<EGDAOAMAONG, OEIBGPKLLFN> ABBGMOKOOKH, FNFJKICMOJE IMLNKEDJGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x652F320", Offset = "0x652DB20", VA = "0x18652F320")]
	[CompilerGenerated]
	internal static void CEFNPAKMLHO(Func<ODHIFFFBEEI, LNCMMNMGJHE> BPIEKHGDJBG, ref ALJFGOKMKAB P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6533700", Offset = "0x6531F00", VA = "0x186533700")]
	[CompilerGenerated]
	internal static bool OOCECCMLDDB(EGDAOAMAONG OMGGENADPMH, MMPHPNHNBDD MOPCMJIBMOH, out GAEALHGMBNK GGEEMAFHFNH, ref LBCGBLANLPI P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum MMPHPNHNBDD
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class ICPADLJCHDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<MMPHPNHNBDD, bool> EGEBCHBAKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<MMPHPNHNBDD, BEFMGBIFEMD> LBHBLEKNDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly AIPBCGINMNN GHGPBHBNNBL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x652DB70", Offset = "0x652C370", VA = "0x18652DB70")]
	public ICPADLJCHDM(AIPBCGINMNN GHGPBHBNNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x652D6F0", Offset = "0x652BEF0", VA = "0x18652D6F0")]
	public bool ALEFOEAINKN(MMPHPNHNBDD MOPCMJIBMOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2A27680", Offset = "0x2A25E80", VA = "0x182A27680")]
	public bool BEGDIHPMMLE<T>(MMPHPNHNBDD MOPCMJIBMOH, bool OGECMJNDJJE, T MENBIMCLIOI) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2A27990", Offset = "0x2A26190", VA = "0x182A27990")]
	public (bool, T?) JCDMBDDGOFJ<T>(MMPHPNHNBDD MOPCMJIBMOH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x652D760", Offset = "0x652BF60", VA = "0x18652D760")]
	public bool BEGDIHPMMLE(MMPHPNHNBDD MOPCMJIBMOH, bool OGECMJNDJJE, object MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x652D900", Offset = "0x652C100", VA = "0x18652D900")]
	public (bool, object) JCDMBDDGOFJ(MMPHPNHNBDD MOPCMJIBMOH)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2A27B90", Offset = "0x2A26390", VA = "0x182A27B90")]
	private void LGDJGIPJIMF<T>(MMPHPNHNBDD MOPCMJIBMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x652D840", Offset = "0x652C040", VA = "0x18652D840")]
	private BEFMGBIFEMD DHMIOPGAEFC(MMPHPNHNBDD MOPCMJIBMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x652D9F0", Offset = "0x652C1F0", VA = "0x18652D9F0")]
	public void JOEBOFELGEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GKMGNMPDBOB
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HFGPNGHDOCH POLNGOLBONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class JLCEDEIEBJH : GKMGNMPDBOB
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static JLCEDEIEBJH JGODKAIGFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly OEIBGPKLLFN CEMHJHFNJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<OEIBGPKLLFN> NMMJMKOEIBK;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public HFGPNGHDOCH POLNGOLBONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x652EB50", Offset = "0x652D350", VA = "0x18652EB50")]
	public JLCEDEIEBJH(OEIBGPKLLFN CNAAECLHAIE, IReadOnlyList<OEIBGPKLLFN> DJEJLIILAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x652E330", Offset = "0x652CB30", VA = "0x18652E330")]
	private static JLCEDEIEBJH NLGCKCNIDHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum BNFNDEELOCN
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Everyone
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
