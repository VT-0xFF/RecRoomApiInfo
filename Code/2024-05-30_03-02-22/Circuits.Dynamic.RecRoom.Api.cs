using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EAF730", Offset = "0x1EAE930", VA = "0x181EAF730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HJAOKCPNKDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MKMFEDEKPBJ<KLDIJDDNLJP> ODEOMAAKHKJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF6D0", Offset = "0x1EAE8D0", VA = "0x181EAF6D0")]
	public static HJAOKCPNKDP EPPBEPCPNMI()
	{
		return default(HJAOKCPNKDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF700", Offset = "0x1EAE900", VA = "0x181EAF700")]
	[CompilerGenerated]
	internal static MKMFEDEKPBJ<KLDIJDDNLJP> NFGOFFJPFKG(int HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<KLDIJDDNLJP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FPMMAHMHAKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EIANKMCPPDF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BFHEEEJILHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int FFKLODAPGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float GGGLPJDKPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float MBAELGBELMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IOIKBPALINC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CFPMIMNJJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CEKKOJMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OKNCPOIACPH<PJGNGDCIDLA> CV2SetMaxAmmo(MIIOBBMHMBI NJNKMHCCCIB, int GINACGGICNB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OKNCPOIACPH<PJGNGDCIDLA> CV2SetCurrentAmmo(MIIOBBMHMBI NJNKMHCCCIB, int LPANOKJIEKD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OKNCPOIACPH<PJGNGDCIDLA> CV2SetADSEnabled(MIIOBBMHMBI NJNKMHCCCIB, bool IJMGAKGNGDB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OKNCPOIACPH<PJGNGDCIDLA> CV2SetCanReload(MIIOBBMHMBI NJNKMHCCCIB, bool EAEJCIAGBHG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OKNCPOIACPH<PJGNGDCIDLA> CV2SetContinuousFire(MIIOBBMHMBI NJNKMHCCCIB, bool FBGDFNEKMDI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OKNCPOIACPH<PJGNGDCIDLA> CV2SetRateOfFire(MIIOBBMHMBI NJNKMHCCCIB, float LKICNHOPPCG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OKNCPOIACPH<PJGNGDCIDLA> CV2SetReloadDuration(MIIOBBMHMBI NJNKMHCCCIB, float BAPODJDPLNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DHMFOHMDIKL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string DGHOAMEGFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKNCPOIACPH<PJGNGDCIDLA> SetHandleControlLabel(MIIOBBMHMBI NJNKMHCCCIB, string IFMOJFKAOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KBPGKBIENIG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(FPMMAHMHAKM, FPMMAHMHAKM, FPMMAHMHAKM, FPMMAHMHAKM, FPMMAHMHAKM) CCHHKGIGPAL(object PIDLONEPCMN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object AGKOAPNKMFA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DOILPLLJOOE(object PIDLONEPCMN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string OIMAOENIAOM(object PIDLONEPCMN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BKOLPDNCAJB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FGOLPNPKHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AHLMBPLBNGA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNMPOJDENIN ECLNLGFKJDI(int OHPHEEKKPLI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int MIGKNPIJIEO([In] MNMPOJDENIN GCBBHHLFKOA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HMJPEMHPCCH
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKNCPOIACPH<PJGNGDCIDLA> SetEnabled(MIIOBBMHMBI NJNKMHCCCIB, bool DCAEJMBEMDI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct ANPHBFLPBBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DCPNCMPNOHF CBFGFFJLMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly AHLMBPLBNGA FPOBGFFPPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly KBPGKBIENIG HJEBPECJONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly HJAOKCPNKDP JPPPIJJHGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly KJABDOMIKNI BNDNHPBHGBL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF660", Offset = "0x1EAE860", VA = "0x181EAF660")]
	public ANPHBFLPBBA(DCPNCMPNOHF GIIJDPJOHBH, AHLMBPLBNGA BMLHLADJMEP, KBPGKBIENIG DKMAEDJKCBP, [In] HJAOKCPNKDP DBJHEGBIHIF, KJABDOMIKNI OKNOFDLHEGL)
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
