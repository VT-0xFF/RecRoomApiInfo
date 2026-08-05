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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B48340", Offset = "0x2B46D40", VA = "0x182B48340")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DFCBFOGGCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public HOHDPLDONAJ<LHDLAHGCLHI> AHMBLIBODMH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B482A0", Offset = "0x2B46CA0", VA = "0x182B482A0")]
	public static DFCBFOGGCIH KDBDJPAJKDJ()
	{
		return default(DFCBFOGGCIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B48270", Offset = "0x2B46C70", VA = "0x182B48270")]
	[CompilerGenerated]
	internal static HOHDPLDONAJ<LHDLAHGCLHI> GJGLCPDMFHM(int KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<LHDLAHGCLHI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MOJBLLILOMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GLADIBFCEMF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KFGAPGHCNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int JCFINEDEOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float FHKGMBEPMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float GENIOEBKOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LDFJCDNPLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HCFMAAPNEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FFBOFCNBMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NPFKNIJFGHB<LJBIGLJNMFO> CV2SetMaxAmmo(GOGDLCPEJKJ ILHCGNGICHE, int JOEBEKPOHKM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NPFKNIJFGHB<LJBIGLJNMFO> CV2SetCurrentAmmo(GOGDLCPEJKJ ILHCGNGICHE, int KEABKJMLOBK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NPFKNIJFGHB<LJBIGLJNMFO> CV2SetADSEnabled(GOGDLCPEJKJ ILHCGNGICHE, bool LEFHPHFNFDO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NPFKNIJFGHB<LJBIGLJNMFO> CV2SetCanReload(GOGDLCPEJKJ ILHCGNGICHE, bool GNCOOLGINLN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NPFKNIJFGHB<LJBIGLJNMFO> CV2SetContinuousFire(GOGDLCPEJKJ ILHCGNGICHE, bool LADNGKDDLNK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NPFKNIJFGHB<LJBIGLJNMFO> CV2SetRateOfFire(GOGDLCPEJKJ ILHCGNGICHE, float HODMIEFFAOA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NPFKNIJFGHB<LJBIGLJNMFO> CV2SetReloadDuration(GOGDLCPEJKJ ILHCGNGICHE, float LKKNOPLOOPB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AGLHPOGENGI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string MNFMEMFJCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPFKNIJFGHB<LJBIGLJNMFO> SetHandleControlLabel(GOGDLCPEJKJ ILHCGNGICHE, string JLLMPMKJKMF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NKKAEBBDKID
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(MOJBLLILOMP, MOJBLLILOMP, MOJBLLILOMP, MOJBLLILOMP, MOJBLLILOMP) GOFJFHAAAPJ(object BLHNDOLLIDD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object KBJEIICECNM();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OEBGFPNJFBL(object BLHNDOLLIDD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string PDBLLGFIAMK(object BLHNDOLLIDD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EDICANNPFML
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BINFJEPHFID
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PJAKHACJENM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BHOMMOJKCBM? FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BHOMMOJKCBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IEnumerable<string> OIOEBGFEBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GIAIOJPANDN(string DDMJIIPEIDF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGOEMPIBEMC(string DDMJIIPEIDF, string PJBJFJMLBHO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ALEAKPJFFLO
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIJFOKEFHAN AFGIPIDDIJO(int DGADOPNCDCD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int MBEAHNNBICI([In] LIJFOKEFHAN HEJKHHFPHNG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NBMHMLOJNFP
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPFKNIJFGHB<LJBIGLJNMFO> SetEnabled(GOGDLCPEJKJ ILHCGNGICHE, bool NDPLDKBMIAN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FODJLAOKDJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ICIAPNIGCHF GNHEOPAKFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ALEAKPJFFLO EBKPNDHCFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly NKKAEBBDKID BOGODDGLNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly DFCBFOGGCIH IEDEBBCBNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly EDEPNOIAMGF MGJDHCCNEMN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B482D0", Offset = "0x2B46CD0", VA = "0x182B482D0")]
	public FODJLAOKDJJ(ICIAPNIGCHF MGFECNEJJLP, ALEAKPJFFLO NNADMMBCCCE, NKKAEBBDKID KNJHDHHJEBN, [In] DFCBFOGGCIH LDJPGMPHPPE, EDEPNOIAMGF HJDPLOOJCKG)
	{
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
