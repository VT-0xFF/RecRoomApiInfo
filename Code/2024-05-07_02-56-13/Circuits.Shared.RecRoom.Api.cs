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
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E40AC0", Offset = "0x1E3FCC0", VA = "0x181E40AC0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PGKKCLDMAJI
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
public enum JPOPOCOGEFM
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
public struct GLAAFBEMKJI : IEquatable<GLAAFBEMKJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public JPOPOCOGEFM KJLBEIAPKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public FPNOLPNOCPB EKPMLGJEFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Guid DBJJIEJGDBN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E40900", Offset = "0x1E3FB00", VA = "0x181E40900", Slot = "4")]
	public bool Equals(GLAAFBEMKJI NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E40960", Offset = "0x1E3FB60", VA = "0x181E40960", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E40A40", Offset = "0x1E3FC40", VA = "0x181E40A40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MFOONAMFMEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly FPNOLPNOCPB EKPMLGJEFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Guid DBJJIEJGDBN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E40A80", Offset = "0x1E3FC80", VA = "0x181E40A80")]
	public MFOONAMFMEF(FPNOLPNOCPB KBIOPGAFILM, Guid NOMPOCCHJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FPNOLPNOCPB
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PFHPFDNILHN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PGKKCLDMAJI MBOJOFLFHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LNJOLLAKCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EHLJHBNGNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LFMIJIINPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KJKKCMMMKID.PBFKKOCJLED.FFBKJMCPJCE OBJMPPLICKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MFIIOOOEPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string CNPJHEDGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string IGLMHJDLBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PGBOCPGJJAI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	int FOHJMIAHBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GIOIIDCCOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string IOJNOHEFDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string GBMCJKFDOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CCDLNGOIIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MLNKBLFGLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float CPPHGLLLPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BFANCPDIKJA OBAKJFMMGFJ;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EADHDIAAEOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Guid GHMLFHHEGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IReadOnlyList<string> CAJHGODBECA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FGCAGHCFIHI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int EEPNPLICFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int NDCEMIPFDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int EKGKKCFAAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int KNLFAIMHJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKLICOGFMBE();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIKDMLEJIGO();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ALFODDKKHIH();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNDDCPOHCNL();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PPENACBMILD();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHEIMKIFPIE();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGFFEGFAFDK();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLJGPFHJAGH();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MKBODMNJLIH(GLAAFBEMKJI CKPELOKOBDB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HFHEPMKOBOH(GLAAFBEMKJI CKPELOKOBDB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MFOONAMFMEF FJFJOJKGDHE(JPOPOCOGEFM BGEKOGIHADN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IReadOnlyDictionary<JPOPOCOGEFM, MFOONAMFMEF> JKCEBPJOPNB(FPNOLPNOCPB KBIOPGAFILM, [In] Guid NOMPOCCHJGN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DPAAIJOAGKK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int NNGFNAAOPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int JEDKDJCNJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ALKODGDMFJE
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFHPFDNILHN? INIKNHDJHDA(string? EENAJONDOIE, string? EMBHDFJAFHI, string? LIGNFDNLBLE, KJKKCMMMKID.PBFKKOCJLED.FFBKJMCPJCE PBGGDGAEELP, bool KENJJAFANFF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Obsolete("Do not add events to Circuits!")]
public delegate void BFANCPDIKJA(PGBOCPGJJAI GBHPBJPAFFB);
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
