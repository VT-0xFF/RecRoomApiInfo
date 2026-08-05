using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5E0E0", Offset = "0x2A5CAE0", VA = "0x182A5E0E0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KICBMDOANKP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	SubRoom,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	WelcomeMat
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FGNCOLCJODP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Title,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Subtitle,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	ProgressWheel,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Bar1,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Bar2,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	InventorySlot1,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	InventorySlot2,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	InventorySlot3
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ICDKBCJEKEN : IEquatable<ICDKBCJEKEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public FGNCOLCJODP JIMLOJJCIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ECIGAMINDOD HDAAPKPMADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Guid NKKNKFPJNKA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E040", Offset = "0x2A5CA40", VA = "0x182A5E040", Slot = "4")]
	public bool Equals(ICDKBCJEKEN EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF70", Offset = "0x2A5C970", VA = "0x182A5DF70", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E0A0", Offset = "0x2A5CAA0", VA = "0x182A5E0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HEBEFJGDDPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly ECIGAMINDOD HDAAPKPMADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Guid NKKNKFPJNKA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF30", Offset = "0x2A5C930", VA = "0x182A5DF30")]
	public HEBEFJGDDPE(ECIGAMINDOD AEIONDKHPPE, Guid LKBBCEFGAEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ECIGAMINDOD
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MFHMFNCBLLH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KICBMDOANKP NPFIJBOPNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ALCAKEPDMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DPIMEDFHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GNCJCKOGEII
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NCPIAHPKEAO.MLDILEBMNOC.AMOKGCJAGDG KFEKIDAHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string IPBFHHFPIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string ALIABMFDAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string KOCEHBHMMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MDMPBNOMMAL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string IPBFHHFPIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string GLEHNMOOPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	List<string> FGMPDPILNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CEGJFOFGDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int AEKGBFDECPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int NPEFODJNCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int EFEOJCGEENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	AJFFOGKDNFM LFIBMHCMFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KFPKCHFFBBD
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int IFHKNOCELKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HBDLACIAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string EAOIOBGHMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IGHCNCMMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BDJLDLMBLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float AOONALIGCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BBLHKEFDKFK HFJPJCIKKMI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AJFFOGKDNFM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int DIJMFFFNHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string HALANACBELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string DBGHCHDGBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string KJLNCLAFOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string LOBLMPCBLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int LNPFDJMMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FILFMJOALNA
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string ALCAKEPDMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string GIMJDCKMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	long PKEELHJMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KEDACBGJPIL
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	Guid BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IReadOnlyList<string> NMHJIOOIIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PLKPJJNELJF
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	int DPFCGOONEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int BDACANNIEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int CCKMEEJLFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	int NOIMJPEMKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKCIDMOHLFB();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHJDAFIMACJ();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IFHKPEBPJHD();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GPFGOJHHPJG();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JLLIKBCBILC();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JEKLKOEAAEI();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FGCGGFOHPNH();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NDJLNOKKKAP();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DNHICEHEKMM(ICDKBCJEKEN IOIADDNPONH);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PPPELKMEMOG(ICDKBCJEKEN IOIADDNPONH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HEBEFJGDDPE LONBOCALJDJ(FGNCOLCJODP HGFCOCODHNP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IReadOnlyDictionary<FGNCOLCJODP, HEBEFJGDDPE> FPBOAMADNOO(ECIGAMINDOD AEIONDKHPPE, [In] Guid LKBBCEFGAEA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IGOKMMLNFNB
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int KFCCBMIKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int BINPMDHNLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GIOPAPLLBOE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFHMFNCBLLH? GCNGGGIMDFC(string? JEICIMIGOHJ, string? PJGGLFJELEC, string? OHCHBJIEJDE, NCPIAHPKEAO.MLDILEBMNOC.AMOKGCJAGDG CAPJEFANPNK, bool PNKHPBEOPAC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDMPBNOMMAL LOLECFONKDA(string JEICIMIGOHJ, string DFCOAIFOHFE, List<string> CDABBLNAPID, int IOMBFFKOMKH, int JCJBGFOIMOA, int KBKGEDBAIDE, int MCAMHBLJCFB, AJFFOGKDNFM LMDMBJOIGHK);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AJFFOGKDNFM PMDEIECIDNA(int LHPHKGMDHKM, string NHLFIGMLKML, string JKEKNOHMGMG, string GHPNACOIODA, string MACCHLEOKCD, int PFGLIDEPNNE);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BJCEEOGELNA? GAOEGIBCNFH(string? OPGKKPJPJCP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Obsolete("Do not add events to Circuits!")]
public delegate void BBLHKEFDKFK(KFPKCHFFBBD PEIDNFHKHFH);
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
