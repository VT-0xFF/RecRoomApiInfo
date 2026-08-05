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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2228880", Offset = "0x2227C80", VA = "0x182228880")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IHFEFAIFAKH
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
public enum GFINFPBJNJD
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
public struct JNCGADOCIML : IEquatable<JNCGADOCIML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public GFINFPBJNJD ANEFHEOCCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public PCGKKGPJMHN CPFDBAAENHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Guid HNNCALLBIPN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2228690", Offset = "0x2227A90", VA = "0x182228690", Slot = "4")]
	public bool Equals(JNCGADOCIML OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22285B0", Offset = "0x22279B0", VA = "0x1822285B0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22286F0", Offset = "0x2227AF0", VA = "0x1822286F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HEGPDMPMHCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly PCGKKGPJMHN CPFDBAAENHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Guid HNNCALLBIPN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2228570", Offset = "0x2227970", VA = "0x182228570")]
	public HEGPDMPMHCJ(PCGKKGPJMHN GJKKABMBOEC, Guid PKBKDBMKMMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PCGKKGPJMHN
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BAEJMCIBENI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IHFEFAIFAKH OAAGHDCADAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LHHFKDCMMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PEKKKJDLGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GBBHLMACCCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MBOEDPABAEA.JCCKDJKFEMN.KNOPIMPNFKP MFDJCBDFLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string FFNMHOGIFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string HKOMMNCGCGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string IIONOMOIHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ADPBFOEECKO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	int CIGDMMLDFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JLNBNENCICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string IEGAFNEHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JAAMMBFOLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NINHNDAGJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ODNPPNPKCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float NKPJGENIPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NCOAEPJIMDH IEHBKCPEPLG;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PFANNCMAKCP
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string LHHFKDCMMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string MOOCNDCIOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	long EMGLOMBBILF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HKOANCEBIPH
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Guid BMLMCKPLKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IReadOnlyList<string> MHMIBIGKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ICNJMBCOIAP
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int LGOEMHHOEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int KIPAEMKKCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int OOEHAKEBKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int KEDNDLCCKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJIMKHELKOD();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKOOECOEJFG();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGLFJIHKLLG();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AAAIGBPFNNG();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void APOLJOMPHCI();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KKBDHOIEECK();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DCCOBOOHLJE();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PFLPHFDIMOA();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ABEEJJACOLM(JNCGADOCIML BPFJAGLAKDP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BJAGIKFFANO(JNCGADOCIML BPFJAGLAKDP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HEGPDMPMHCJ COPGCBCLCDJ(GFINFPBJNJD MOACPMBGECF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IReadOnlyDictionary<GFINFPBJNJD, HEGPDMPMHCJ> ILDJGGNFEDO(PCGKKGPJMHN GJKKABMBOEC, [In] Guid PKBKDBMKMMA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LDFLDFEBJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int KAALPHFKJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int AJFCCJJDDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GGDODLFCLBP
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAEJMCIBENI? HNBJCNFEIFF(string? NKDBIOJHKHB, string? ENDKHILOAMP, string? LAAKIIHMPAF, MBOEDPABAEA.JCCKDJKFEMN.KNOPIMPNFKP OCGGENEGDDP, bool DELJAAABCMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Obsolete("Do not add events to Circuits!")]
public delegate void NCOAEPJIMDH(ADPBFOEECKO PPIMIKDHEBO);
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
