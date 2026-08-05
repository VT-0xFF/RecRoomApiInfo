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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x274F960", Offset = "0x274E160", VA = "0x18274F960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DKNFBJJHCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public NLPIAAOFKEO<LDMBCFHJGNI> KGGCBDFOPBB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x274F8C0", Offset = "0x274E0C0", VA = "0x18274F8C0")]
	public static DKNFBJJHCOH CJOJELENPLJ()
	{
		return default(DKNFBJJHCOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x274F890", Offset = "0x274E090", VA = "0x18274F890")]
	[CompilerGenerated]
	internal static NLPIAAOFKEO<LDMBCFHJGNI> AABEONKFHFB(int OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<LDMBCFHJGNI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HEAMPFJBCNL
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JBPGEJOHFOH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int OEDPJMNHFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int BIJMOAIACGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float PHKMBOOLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float FDMMCEGOEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KDGNBFNJEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ABIGNOKIEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IICNNGPNBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GGBJBGABBJA<OLONILFLODF> CV2SetMaxAmmo(HIJKCPJELCF HNILHIIFGAG, int FGNFJAMALCL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GGBJBGABBJA<OLONILFLODF> CV2SetCurrentAmmo(HIJKCPJELCF HNILHIIFGAG, int BOLFPBFEDKE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GGBJBGABBJA<OLONILFLODF> CV2SetADSEnabled(HIJKCPJELCF HNILHIIFGAG, bool BCOFJMBGKOE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GGBJBGABBJA<OLONILFLODF> CV2SetCanReload(HIJKCPJELCF HNILHIIFGAG, bool LJOGJOCJGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GGBJBGABBJA<OLONILFLODF> CV2SetContinuousFire(HIJKCPJELCF HNILHIIFGAG, bool NLCKLAFDLOE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GGBJBGABBJA<OLONILFLODF> CV2SetRateOfFire(HIJKCPJELCF HNILHIIFGAG, float NBFEKNCCFPA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GGBJBGABBJA<OLONILFLODF> CV2SetReloadDuration(HIJKCPJELCF HNILHIIFGAG, float OIKKJHNFKFP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EDMLDKGENPL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string OKNNBHCGDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GGBJBGABBJA<OLONILFLODF> SetHandleControlLabel(HIJKCPJELCF HNILHIIFGAG, string JNGEILKPDIM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CNMAOLGHEJK
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(HEAMPFJBCNL, HEAMPFJBCNL, HEAMPFJBCNL, HEAMPFJBCNL, HEAMPFJBCNL) CABMAKODDEN(object PPBALHIMPIH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object JOCCBNFKNAG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FFFKLPKJBMG(object PPBALHIMPIH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string FJFJOAJOLEG(object PPBALHIMPIH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PNDBDBLCNCL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OJDDDOLBIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BPICPPBICHJ
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJPPCHHGBLL EMBODJALCEI(int MENIDKIJFPO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ABLDFDNGGCP([In] KJPPCHHGBLL FNAKOAACHAD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EBGJCABAGGI
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGBJBGABBJA<OLONILFLODF> SetEnabled(HIJKCPJELCF HNILHIIFGAG, bool PLFJIIBLOAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct LANGBALEOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KENJGKFCIFK JLFHAHAICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly BPICPPBICHJ GOFCLJCOLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly CNMAOLGHEJK OMKGEMNEEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly DKNFBJJHCOH FDANGFGBMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly NEHDCNCKDOJ HFNKKIAOOON;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x274F8F0", Offset = "0x274E0F0", VA = "0x18274F8F0")]
	public LANGBALEOAE(KENJGKFCIFK GOLMMBLKDAK, BPICPPBICHJ KOKDGFDPCEC, CNMAOLGHEJK BGHDBLFMIKB, [In] DKNFBJJHCOH HKMGCBHFJIM, NEHDCNCKDOJ IEKAILPLBJM)
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
