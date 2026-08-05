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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25B1260", Offset = "0x25B0460", VA = "0x1825B1260")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KMEJLPCMHGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public LNNKJBCILDK<PFLAIPPIFID> FBCEHENPCNB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25B1230", Offset = "0x25B0430", VA = "0x1825B1230")]
	public static KMEJLPCMHGM PEFMILKIAFF()
	{
		return default(KMEJLPCMHGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25B1200", Offset = "0x25B0400", VA = "0x1825B1200")]
	[CompilerGenerated]
	internal static LNNKJBCILDK<PFLAIPPIFID> MBDNHIHMMAL(int OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<PFLAIPPIFID>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NHGPHGNBIDF
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FCMEHEOJFNN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BCKGLEMJJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int OCILJJGEAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float IMIIHOGKDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float JHHIMMKIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BIOHCNGDAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MPPKDOGENCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool COLBBDPIAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EBNIAIJGKKL<OJADAPCHIGK> CV2SetMaxAmmo(CAAEKAHHAJB OLLOHIKPLMG, int PLIBGNKHNME);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EBNIAIJGKKL<OJADAPCHIGK> CV2SetCurrentAmmo(CAAEKAHHAJB OLLOHIKPLMG, int HOMHJOFIEBA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EBNIAIJGKKL<OJADAPCHIGK> CV2SetADSEnabled(CAAEKAHHAJB OLLOHIKPLMG, bool DOAMCAICJBD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EBNIAIJGKKL<OJADAPCHIGK> CV2SetCanReload(CAAEKAHHAJB OLLOHIKPLMG, bool CCMNFOCMKIF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EBNIAIJGKKL<OJADAPCHIGK> CV2SetContinuousFire(CAAEKAHHAJB OLLOHIKPLMG, bool DEEFPDFBDKP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EBNIAIJGKKL<OJADAPCHIGK> CV2SetRateOfFire(CAAEKAHHAJB OLLOHIKPLMG, float FGAMILHAAHP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EBNIAIJGKKL<OJADAPCHIGK> CV2SetReloadDuration(CAAEKAHHAJB OLLOHIKPLMG, float HFMGEOLGMMO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HOPOMELBNOB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string KCHNFNGFPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBNIAIJGKKL<OJADAPCHIGK> SetHandleControlLabel(CAAEKAHHAJB OLLOHIKPLMG, string OOCHKCHNNFA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFIBMLKCCDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(NHGPHGNBIDF, NHGPHGNBIDF, NHGPHGNBIDF, NHGPHGNBIDF, NHGPHGNBIDF) EPFGNJJBNGO(object NCAFEKBCKBL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object DKCDEGLIMPI();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IEIFJCLJNMH(object NCAFEKBCKBL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string PFJEDFKPNFB(object NCAFEKBCKBL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CHBEMNBAHMH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EBFGCOPKFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GEIDKEKJDBH
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJDJBBGJKEB EANOANAJDKG(int HFKCFMNDLCH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GDODJEHACPI([In] EJDJBBGJKEB EEPDKOPNBBL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KGPKFJKHHFM
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EBNIAIJGKKL<OJADAPCHIGK> SetEnabled(CAAEKAHHAJB OLLOHIKPLMG, bool DDAKGJJACJE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PBELLNKNIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly AEIMIADAHIA NFBNNENCKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GEIDKEKJDBH DLJEMNHOLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly BFIBMLKCCDJ HNMHJHDMNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KMEJLPCMHGM BEDKAFMLFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly MIDGLAFNAKG NCNDFKOFNIK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x25B12E0", Offset = "0x25B04E0", VA = "0x1825B12E0")]
	public PBELLNKNIJI(AEIMIADAHIA ODMABOADNPN, GEIDKEKJDBH NFGPEGAODOA, BFIBMLKCCDJ DMGAOMKJEFA, [In] KMEJLPCMHGM BIELOEICIGA, MIDGLAFNAKG EOBJJCNBBOI)
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
