using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MIOENDCIEGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string BEKDGICGBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FFEPNGLLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NIONFGNNGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RefreshLocalizableContent();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HAHBMMLPMIK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Translated,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	AwaitingTranslations,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Untranslated
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct FCGNJJDHEJB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string JACKNKCKNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CMMPHABLIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xF088D0", Offset = "0xF06ED0", VA = "0x180F088D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D42BE0", Offset = "0x1D411E0", VA = "0x181D42BE0")]
	public FCGNJJDHEJB(string BMMKDMLAIOE, bool PCPPIKHJELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NIMODCBDEEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MOFIBGAMFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPHMPILJAOI(MIOENDCIEGH NDNCKODFKIM, bool LHEAMNILFLF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJAOKHINEGB(LCGOIIEOBDN KDIGEENFCDC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string BKGGCGDPGLH(string DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HAHBMMLPMIK HFCHDONDLBI(string NDEEEAFKNDA, string PAKFOBAPADB, ref ECGCDDHBABG HHJJEFJJELM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFIDCPJHIEG(string NDEEEAFKNDA, ECGCDDHBABG HHJJEFJJELM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FCGNJJDHEJB MDLNDMGBMOD(string NDEEEAFKNDA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EGHOGENGNPN(IPDOODALCIF KHFPJHNKLML, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ECGCDDHBABG : IEquatable<ECGCDDHBABG>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	long HJEFIBFMHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}
}
namespace Cpp2IlInjected;

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
