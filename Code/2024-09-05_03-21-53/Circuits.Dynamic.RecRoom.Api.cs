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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x20A13C0", Offset = "0x209FDC0", VA = "0x1820A13C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OOMPJOILAIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MLGFJIHMDCD<HJCKAFIPEOB> DFCKCCJNEAE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20A1470", Offset = "0x209FE70", VA = "0x1820A1470")]
	public static OOMPJOILAIJ MMKGNMBHOIH()
	{
		return default(OOMPJOILAIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20A1440", Offset = "0x209FE40", VA = "0x1820A1440")]
	[CompilerGenerated]
	internal static MLGFJIHMDCD<HJCKAFIPEOB> ACJPHHHCDKP(int CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<HJCKAFIPEOB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HDIHDNABFMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NCAJCGOLDOO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NGKGEODFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int PFFPPHIEGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float ADNHIJAELGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float PBAELHLLOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MNPAIFLMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HIJHPEFFNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KMBFILONJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLPAOAJPAGO<IEPJDCHMGFO> CV2SetMaxAmmo(DNMPBDHKFOL DCGMDLPABHJ, int AAGMKEOFFOB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BLPAOAJPAGO<IEPJDCHMGFO> CV2SetCurrentAmmo(DNMPBDHKFOL DCGMDLPABHJ, int ABEMALIIAAN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BLPAOAJPAGO<IEPJDCHMGFO> CV2SetADSEnabled(DNMPBDHKFOL DCGMDLPABHJ, bool CEAFCCPFHNA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BLPAOAJPAGO<IEPJDCHMGFO> CV2SetCanReload(DNMPBDHKFOL DCGMDLPABHJ, bool LNJDNILHHKO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BLPAOAJPAGO<IEPJDCHMGFO> CV2SetContinuousFire(DNMPBDHKFOL DCGMDLPABHJ, bool FGOOKFDLMBE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BLPAOAJPAGO<IEPJDCHMGFO> CV2SetRateOfFire(DNMPBDHKFOL DCGMDLPABHJ, float JDMFBPLDJCP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BLPAOAJPAGO<IEPJDCHMGFO> CV2SetReloadDuration(DNMPBDHKFOL DCGMDLPABHJ, float MNHDOCAHHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FIIPHEEFIAO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string APMBPHJAJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BLPAOAJPAGO<IEPJDCHMGFO> SetHandleControlLabel(DNMPBDHKFOL DCGMDLPABHJ, string DFBDLGMNPNM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AFADCEKPNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(HDIHDNABFMF, HDIHDNABFMF, HDIHDNABFMF, HDIHDNABFMF, HDIHDNABFMF) HPFFFOOFGDI(object JGEPDBLHLJG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object CMIHLLKPNOM();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IMCHLNDGPGF(object JGEPDBLHLJG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string KDHKCEMPOJG(object JGEPDBLHLJG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LDOGOBOLLDL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AHKJGHFBCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JFENJDMOHBD
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GICBDAJODOB HFLKHLJHHNM(int MEELJMJPALN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OJDGMIELPNJ([In] GICBDAJODOB EACDPLALNJC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GGGAOCLBPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BLPAOAJPAGO<IEPJDCHMGFO> SetEnabled(DNMPBDHKFOL DCGMDLPABHJ, bool DKFELHLGCPE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PKGEPJOBJMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly CCIJKBLHPMJ JEBFPFBMAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly JFENJDMOHBD FFPMCPPGAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly AFADCEKPNBD JEKFPEDACOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly OOMPJOILAIJ JEBDGFCGIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly BCNAHFBIDCA CDPNFDFHBFN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x20A14A0", Offset = "0x209FEA0", VA = "0x1820A14A0")]
	public PKGEPJOBJMH(CCIJKBLHPMJ IHJPKPEPDCN, JFENJDMOHBD AINDJBEGCFO, AFADCEKPNBD IHEGMDCEJLJ, [In] OOMPJOILAIJ DMPGLOFPICA, BCNAHFBIDCA BGJGGOOGMAH)
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
