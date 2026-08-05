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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x287EF30", Offset = "0x287D730", VA = "0x18287EF30")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MLJPHNPBMND
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
public enum GLDOGDNCLOC
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
public struct PDGOBPKFBBB : IEquatable<PDGOBPKFBBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public GLDOGDNCLOC CINNANFKMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public LGDMAHLJOCD KGIBLFPHPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Guid LJKIKBJHLPB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x287F080", Offset = "0x287D880", VA = "0x18287F080", Slot = "4")]
	public bool Equals(PDGOBPKFBBB KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x287EFB0", Offset = "0x287D7B0", VA = "0x18287EFB0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x287F0E0", Offset = "0x287D8E0", VA = "0x18287F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class INFNEANCLCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly LGDMAHLJOCD KGIBLFPHPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Guid LJKIKBJHLPB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x287EDA0", Offset = "0x287D5A0", VA = "0x18287EDA0")]
	public INFNEANCLCL(LGDMAHLJOCD GAKHNNCCDBJ, Guid OLOLBHBJOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LGDMAHLJOCD
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FGBGHJDOGAG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MLJPHNPBMND BMPDHEOABBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MHAEFOJJGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OMHLFAGHAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LCJKAGNJLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HEGNMFJHLIP.LCGNJNDEBKA.MEIBHLOOGCO DBIGCNIHJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string FFBHAMBBIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string NHIOLFLBNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string CANBIJFDOBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GKAPJJOHEDE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string FFBHAMBBIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string EJFMGDGDCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	List<string> DDFEEALFDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KJKLNLPOKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int LEPHNLFIBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int HDGCMLEDKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int MPNGKBPPIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CGKJDIIJGAP
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int FOLCICPPDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool DBHCMBNFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string OOPBIEEOBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NHIDOKAHBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CAABCKDCFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float JMGEGAEEKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MJKAMIJNOOL GPKPIGICFHN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ENEHBMMHJNA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string MHAEFOJJGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string INIBPMMMPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	long FEBDODEEGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MDBMPIKBGFA
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<string> AKJMJCBMNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface COLDFGOHEED
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int GDJFJILFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	int GACKPCEPJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int FPOKAPLHFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int PPAMKGACLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFLBHMPJPPO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMAHECILEJJ();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEKFEPOAHCG();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KALFMABEDDF();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEADDCANFPO();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KGGFJCJMIKD();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OBJLGDLKOIF();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOGMLCOGPGC();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GOJBGONIKAH(PDGOBPKFBBB MPIJOJPEJFK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ECDEGGLDIML(PDGOBPKFBBB MPIJOJPEJFK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "14")]
	INFNEANCLCL GEMADKNOFFD(GLDOGDNCLOC OKCAEOLDLOD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IReadOnlyDictionary<GLDOGDNCLOC, INFNEANCLCL> AEBHBHFMNJJ(LGDMAHLJOCD GAKHNNCCDBJ, [In] Guid OLOLBHBJOCA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LGGOPCILFAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int EJDOGAHJOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	int LFMNDEKHJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IBHMCCAGLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGBGHJDOGAG? BALEJDHHELH(string? INFFBMIKNIA, string? FANGBBPLLNE, string? NPIJHBGHCNM, HEGNMFJHLIP.LCGNJNDEBKA.MEIBHLOOGCO GJLLKMONDOJ, bool DGKLKONJGOO);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GKAPJJOHEDE KGGIFJMMHDG(string INFFBMIKNIA, string AJJDMMFAHKC, List<string> GALPOFMEIKN, int JEGIOLGMENO, int LJMOMIGEANA, int AHEHNDCKFOM, int IIMKALAKAAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Obsolete("Do not add events to Circuits!")]
public delegate void MJKAMIJNOOL(CGKJDIIJGAP BJNLPCOGDLM);
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
