using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DCGFAPDNBOF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string NFAOIHAODBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object LGGIHOEIGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MBIPOABIIOF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	DoNotCache = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	AddToRoomCacheGlobal = 5,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	RemoveFromRoomCache = 6,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	RemoveFromRoomCacheForActorsLeft = 7
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NJCHOGHPIEO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	MasterClient,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AllBuffered,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OthersBuffered,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AllViaServer,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AllBufferedViaServer
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NGFCECHAKNA
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	UnreliableUnsequenced,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reliable,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ReliableUnsequenced
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum EAOGCPAINGE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BKJLKPIDHCH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly BKJLKPIDHCH EMOEMPAFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public MBIPOABIIOF FIPKLBPINPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public byte MHOBALGDCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int[] NIIDPDDDLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EAOGCPAINGE MEAHIIMJFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte NOOGAAOCJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public MIMBJMFMMEP JMOGENAMOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public int EDEJFBIGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public object KIJDJBIBEBE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D80250", Offset = "0x7D7F450", VA = "0x187D80250")]
	public BKJLKPIDHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MIMBJMFMMEP
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly MIMBJMFMMEP EMOEMPAFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public byte CACDELDKBNE;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const byte OLDJFECPFAB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public const byte EOCDLGIGGMF = 2;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public const byte MDJBCBFPDNA = 4;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const byte PMJPKBKPDJK = 8;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBF4D60", Offset = "0xBF3F60", VA = "0x180BF4D60")]
	public MIMBJMFMMEP(byte NONADLAGNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KLBOHECHKNP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACGABFALOEC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMPCNLGDJDH();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ENAGJCNFDOP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D80470", Offset = "0x7D7F670", VA = "0x187D80470")]
	public static void ELMINHAMHEF(this IList<KLBOHECHKNP> BKNPNHLENFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D802C0", Offset = "0x7D7F4C0", VA = "0x187D802C0")]
	public static void BMBBOLFJMFC(this IList<KLBOHECHKNP> BKNPNHLENFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KPDBONCIMNC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LJMFAPOFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ALHLOMPOILE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MLCKALFJEHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Dictionary<object, object> JDFPKANCHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string GCGDNGNGGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int NOEBNEAFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GJAOODKPMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool AAFANNFFJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string NDNCLGLPMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string NFAOIHAODBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IFBEAGMHDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	object PDMDDKECOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BAEGAOCCOLL(Dictionary<object, object> CNHACOCGLJH, [Optional] Dictionary<object, object> HDKLFOBEOCA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DCFIJANIKOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	byte NFNNKKPFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IJOOBPLKILC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Dictionary<object, object> JDFPKANCHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BAEGAOCCOLL(Dictionary<object, object> CNHACOCGLJH, [Optional] Dictionary<object, object> JNHCGACKDMN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LLMFDEMKDNH(int MKHHKDJKLDN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public interface KOEIHCIJPPL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	byte EGKLDLJEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int APNPGHGIJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	object IIPDAPMAFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	object JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FLFGMEICIOC(byte AGBHGDFILGO, [Out] object MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IHKEKBDONBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly string EHAMBLHDLAM;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public IHKEKBDONBN([Optional] string EHAMBLHDLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D80620", Offset = "0x7D7F820", VA = "0x187D80620", Slot = "3")]
	public override string ToString()
	{
		return null;
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
