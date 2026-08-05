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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x226FB10", Offset = "0x226EF10", VA = "0x18226FB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AKJANCAECMO
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
public enum PFLHCPOBDFJ
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
public struct DAJNGAPBJJK : IEquatable<DAJNGAPBJJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public PFLHCPOBDFJ NBLJIIMANNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public IFMKOJELGLC OGPFFCEKNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Guid FEBMDCCLMGK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x226FA70", Offset = "0x226EE70", VA = "0x18226FA70", Slot = "4")]
	public bool Equals(DAJNGAPBJJK OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x226F9A0", Offset = "0x226EDA0", VA = "0x18226F9A0", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x226FAD0", Offset = "0x226EED0", VA = "0x18226FAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PJJIODJINDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IFMKOJELGLC OGPFFCEKNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Guid FEBMDCCLMGK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x226FCE0", Offset = "0x226F0E0", VA = "0x18226FCE0")]
	public PJJIODJINDF(IFMKOJELGLC EAFCLFJELLK, Guid FFKILKBDNHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IFMKOJELGLC
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KAIPJMIDHAA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AKJANCAECMO EGPGHEIKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KPDDEJGGCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MOMBEFIOKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KAEMOHAKLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CKAPDHENPLM.IIIHCEPHAHJ.KKMNNLDMPMN IDFGHPNFOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MLHHHBEDBIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string OOKIHGFNEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string FCHNFCKCPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KBLGHFEOLDM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	int JOIHLDAGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JCKANHEGIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string IMLAMDBADPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string HNDLKLLIDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KKDJLOHLJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EPLNGMDBDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float BMDPBMMLMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PDCDFKNLECJ BKFMHPHJKBA;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HMEGEDIJOFB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string KPDDEJGGCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string EFPPAFPGIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	long NOIKINDIMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LDANDBFBMKG
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Guid GPNGJJINABA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IReadOnlyList<string> GEEJEPBBFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BLINOCMJAIM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NLHNCPKKFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int MFAOELKIPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int HPJAGCBBCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int NDMDJCBPNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEHFIILBBKH();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KECEJDGBHDL();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHJJLAECBNG();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKJEEJOBHIO();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CJBGFJCKPBN();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CNHAAELADNM();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HFGKPNALPGM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AMNLFNFGKEG();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MAGMLIGIDBE(DAJNGAPBJJK HPCIHDNADFI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MBFFGBKEJKB(DAJNGAPBJJK HPCIHDNADFI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PJJIODJINDF AIMPNJICMKD(PFLHCPOBDFJ CFCMGKOHCIN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IReadOnlyDictionary<PFLHCPOBDFJ, PJJIODJINDF> JGAKEGMBACM(IFMKOJELGLC EAFCLFJELLK, [In] Guid FFKILKBDNHG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DONKLMJDPFA
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int GJJCODFOIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int HGFBGICFDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DPMPADEOKFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KAIPJMIDHAA? BKBDAJCBKOA(string? DDMEPKPHGJJ, string? IKBFNHLKCMG, string? IBPJJOEOLAB, CKAPDHENPLM.IIIHCEPHAHJ.KKMNNLDMPMN CPNGGHJIFME, bool BJJDAOJEFEK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Obsolete("Do not add events to Circuits!")]
public delegate void PDCDFKNLECJ(KBLGHFEOLDM LHOBDGJGOHD);
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
