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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2690D60", Offset = "0x268F760", VA = "0x182690D60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KEDIFBHPHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public NBPBIJJFIMI<PAJEEABCKMH> JMDLCENLLDE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2690D00", Offset = "0x268F700", VA = "0x182690D00")]
	public static KEDIFBHPHML DDDHPONDPCL()
	{
		return default(KEDIFBHPHML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2690D30", Offset = "0x268F730", VA = "0x182690D30")]
	[CompilerGenerated]
	internal static NBPBIJJFIMI<PAJEEABCKMH> PLKFMPGPBKG(int PPJFMHBDGNA)
	{
		return default(NBPBIJJFIMI<PAJEEABCKMH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DCHPFNGJONI
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HIDIOJDAHEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KJILDPBFPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int EEOIFJNKFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float HCEMAJFJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float AHEGHLLGIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HCOMEBICMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KKMDNJKLLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IBMLPLMCBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DOJGONDNEHE<HGCBNLHKPOI> CV2SetMaxAmmo(FELICNPLCFD CHDFBHPMACH, int AIHFEHEPHFF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DOJGONDNEHE<HGCBNLHKPOI> CV2SetCurrentAmmo(FELICNPLCFD CHDFBHPMACH, int DBEGJIFAOAI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DOJGONDNEHE<HGCBNLHKPOI> CV2SetADSEnabled(FELICNPLCFD CHDFBHPMACH, bool PLGFLNLCLML);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DOJGONDNEHE<HGCBNLHKPOI> CV2SetCanReload(FELICNPLCFD CHDFBHPMACH, bool JELLLBIBEEC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DOJGONDNEHE<HGCBNLHKPOI> CV2SetContinuousFire(FELICNPLCFD CHDFBHPMACH, bool IGBIIKEOBMI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DOJGONDNEHE<HGCBNLHKPOI> CV2SetRateOfFire(FELICNPLCFD CHDFBHPMACH, float IJADCHMGEDF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DOJGONDNEHE<HGCBNLHKPOI> CV2SetReloadDuration(FELICNPLCFD CHDFBHPMACH, float KDFJLNMBGOO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IIGDFMMGCMC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string PNMLEGKOOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DOJGONDNEHE<HGCBNLHKPOI> SetHandleControlLabel(FELICNPLCFD CHDFBHPMACH, string ICBJABOHKGL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GCHHMLPKIAK
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(DCHPFNGJONI, DCHPFNGJONI, DCHPFNGJONI, DCHPFNGJONI, DCHPFNGJONI) AIANOMGCJGN(object DHJCIPPGLOL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object NIONEOBEEMD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BFBBKCKIDFH(object DHJCIPPGLOL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string DBKIGAGJGPC(object DHJCIPPGLOL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface POEEDCOAIKI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MINJMGBDLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DCMILNAGHHB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JNAHJMLGONB OHJFONKEOMH(int PHAOADFJMIM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HKGOGDFIDIJ([In] JNAHJMLGONB BMGDGPGPHPN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AEAEJCPMMAD
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DOJGONDNEHE<HGCBNLHKPOI> SetEnabled(FELICNPLCFD CHDFBHPMACH, bool FFEFMPCLPCE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct FPOOJJMCFNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DLJDMJFPFML KDHDBKBOHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DCMILNAGHHB FMEEHFPCNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly GCHHMLPKIAK BOFAEEKLGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KEDIFBHPHML JDNDJPBPHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly FHBHDECKECK NBICPEAMMEG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2690C90", Offset = "0x268F690", VA = "0x182690C90")]
	public FPOOJJMCFNI(DLJDMJFPFML LADBIJBPKLM, DCMILNAGHHB PDOHPDJHJNM, GCHHMLPKIAK BAHKNFAFLFH, [In] KEDIFBHPHML MCIGDAKFFEJ, FHBHDECKECK FKHPEBLEMLP)
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
