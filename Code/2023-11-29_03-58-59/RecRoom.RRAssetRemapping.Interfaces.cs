using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x6458EA0", Offset = "0x64582A0", VA = "0x186458EA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KFFAMNKBMMP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ALIOEPOJFBC(AFKPLGJHCHM CGOLCEEBMBE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AFKPLGJHCHM JKMDPBEAKHM(string CGOLCEEBMBE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct AFKPLGJHCHM : IEquatable<AFKPLGJHCHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GBIOGAOCJBJ FGLDCGHFPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HLIMNJNLOEL MKIEMDGFNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid HHBIDHLCKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? OEPJMPFIGFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JHLBPLHBBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64573B0", Offset = "0x64567B0", VA = "0x1864573B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MOJNCNDIEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64575D0", Offset = "0x64569D0", VA = "0x1864575D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6457A10", Offset = "0x6456E10", VA = "0x186457A10")]
	public AFKPLGJHCHM(AFKPLGJHCHM PJDJBOICLBL, [Optional] Guid LFONKHHODHC, [Optional] RRColor? DDJLPLIEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6457AA0", Offset = "0x6456EA0", VA = "0x186457AA0")]
	public AFKPLGJHCHM(GBIOGAOCJBJ KFGKINDJPOE, HLIMNJNLOEL BPDFAAHEPGM, [Optional] Guid LFONKHHODHC, [Optional] RRColor? DDJLPLIEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6457240", Offset = "0x6456640", VA = "0x186457240", Slot = "4")]
	public bool Equals(AFKPLGJHCHM LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6457150", Offset = "0x6456550", VA = "0x186457150", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6457470", Offset = "0x6456870", VA = "0x186457470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6457340", Offset = "0x6456740", VA = "0x186457340")]
	public static bool FCHDBNDMOOD(AFKPLGJHCHM OJKFAPKLEMA, AFKPLGJHCHM BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6457560", Offset = "0x6456960", VA = "0x186457560")]
	public static bool HAGCGOPJDDN(AFKPLGJHCHM OJKFAPKLEMA, AFKPLGJHCHM BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6457610", Offset = "0x6456A10", VA = "0x186457610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GBIOGAOCJBJ : IEquatable<GBIOGAOCJBJ>, IComparable<GBIOGAOCJBJ>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly GBIOGAOCJBJ ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public GBIOGAOCJBJ(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(GBIOGAOCJBJ LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(GBIOGAOCJBJ LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6457C70", Offset = "0x6457070", VA = "0x186457C70", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(GBIOGAOCJBJ OJKFAPKLEMA, GBIOGAOCJBJ BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6457BD0", Offset = "0x6456FD0", VA = "0x186457BD0")]
	public static bool HAGCGOPJDDN(GBIOGAOCJBJ OJKFAPKLEMA, GBIOGAOCJBJ BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6457D10", Offset = "0x6457110", VA = "0x186457D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GEPFDDJIGPC : IEquatable<GEPFDDJIGPC>, IComparable<GEPFDDJIGPC>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly GEPFDDJIGPC ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public GEPFDDJIGPC(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(GEPFDDJIGPC LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(GEPFDDJIGPC LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6457D80", Offset = "0x6457180", VA = "0x186457D80", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(GEPFDDJIGPC OJKFAPKLEMA, GEPFDDJIGPC BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6457BD0", Offset = "0x6456FD0", VA = "0x186457BD0")]
	public static bool HAGCGOPJDDN(GEPFDDJIGPC OJKFAPKLEMA, GEPFDDJIGPC BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6457E20", Offset = "0x6457220", VA = "0x186457E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JKAEIHBBPEI : IEquatable<JKAEIHBBPEI>, IComparable<JKAEIHBBPEI>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly JKAEIHBBPEI ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public JKAEIHBBPEI(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(JKAEIHBBPEI LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(JKAEIHBBPEI LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6458430", Offset = "0x6457830", VA = "0x186458430", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(JKAEIHBBPEI OJKFAPKLEMA, JKAEIHBBPEI BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6457BD0", Offset = "0x6456FD0", VA = "0x186457BD0")]
	public static bool HAGCGOPJDDN(JKAEIHBBPEI OJKFAPKLEMA, JKAEIHBBPEI BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64584D0", Offset = "0x64578D0", VA = "0x1864584D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HLIMNJNLOEL : IEquatable<HLIMNJNLOEL>, IComparable<HLIMNJNLOEL>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly HLIMNJNLOEL ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OOPDJHHIALL CABEGIHKIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
		[CompilerGenerated]
		get
		{
			return default(OOPDJHHIALL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OOPDJHHIALL OIBKJMDAHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEE1000", Offset = "0xEE0400", VA = "0x180EE1000")]
		[CompilerGenerated]
		get
		{
			return default(OOPDJHHIALL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OOPDJHHIALL BBFDELPOHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDF9AA0", Offset = "0xDF8EA0", VA = "0x180DF9AA0")]
		[CompilerGenerated]
		get
		{
			return default(OOPDJHHIALL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6458290", Offset = "0x6457690", VA = "0x186458290")]
	public HLIMNJNLOEL(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x64582D0", Offset = "0x64576D0", VA = "0x1864582D0")]
	public HLIMNJNLOEL(OOPDJHHIALL LAFADMNMFII, OOPDJHHIALL BDICDANGGNB, OOPDJHHIALL CAADJANCPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6457FC0", Offset = "0x64573C0", VA = "0x186457FC0")]
	private Guid EPPGEJDLOJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0B00", Offset = "0x5ECFF00", VA = "0x185ED0B00", Slot = "4")]
	public bool Equals(HLIMNJNLOEL LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x64580F0", Offset = "0x64574F0", VA = "0x1864580F0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x64581A0", Offset = "0x64575A0", VA = "0x1864581A0")]
	public static bool FCHDBNDMOOD(HLIMNJNLOEL OJKFAPKLEMA, HLIMNJNLOEL BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x64581E0", Offset = "0x64575E0", VA = "0x1864581E0")]
	public static bool HAGCGOPJDDN(HLIMNJNLOEL OJKFAPKLEMA, HLIMNJNLOEL BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6457F80", Offset = "0x6457380", VA = "0x186457F80", Slot = "5")]
	public int CompareTo(HLIMNJNLOEL LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6458220", Offset = "0x6457620", VA = "0x186458220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JEKHGGKMKJE : IEquatable<JEKHGGKMKJE>, IComparable<JEKHGGKMKJE>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JEKHGGKMKJE ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public JEKHGGKMKJE(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(JEKHGGKMKJE LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(JEKHGGKMKJE LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6458320", Offset = "0x6457720", VA = "0x186458320", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(JEKHGGKMKJE OJKFAPKLEMA, JEKHGGKMKJE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6457BD0", Offset = "0x6456FD0", VA = "0x186457BD0")]
	public static bool HAGCGOPJDDN(JEKHGGKMKJE OJKFAPKLEMA, JEKHGGKMKJE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x64583C0", Offset = "0x64577C0", VA = "0x1864583C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EHPJADFBGFH : IEquatable<EHPJADFBGFH>, IComparable<EHPJADFBGFH>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EHPJADFBGFH ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public EHPJADFBGFH(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(EHPJADFBGFH LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(EHPJADFBGFH LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6457B30", Offset = "0x6456F30", VA = "0x186457B30", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(EHPJADFBGFH OJKFAPKLEMA, EHPJADFBGFH BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6457BD0", Offset = "0x6456FD0", VA = "0x186457BD0")]
	public static bool HAGCGOPJDDN(EHPJADFBGFH OJKFAPKLEMA, EHPJADFBGFH BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6457C00", Offset = "0x6457000", VA = "0x186457C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NBEFKMDGOAE : IEquatable<NBEFKMDGOAE>, IComparable<NBEFKMDGOAE>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly NBEFKMDGOAE ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public NBEFKMDGOAE(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(NBEFKMDGOAE LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(NBEFKMDGOAE LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6458C80", Offset = "0x6458080", VA = "0x186458C80", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(NBEFKMDGOAE OJKFAPKLEMA, NBEFKMDGOAE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6457BD0", Offset = "0x6456FD0", VA = "0x186457BD0")]
	public static bool HAGCGOPJDDN(NBEFKMDGOAE OJKFAPKLEMA, NBEFKMDGOAE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6458D20", Offset = "0x6458120", VA = "0x186458D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct NPDMNAIKMOE : IEquatable<NPDMNAIKMOE>, IComparable<NPDMNAIKMOE>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly NPDMNAIKMOE ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public NPDMNAIKMOE(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(NPDMNAIKMOE LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(NPDMNAIKMOE LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6458D90", Offset = "0x6458190", VA = "0x186458D90", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(NPDMNAIKMOE OJKFAPKLEMA, NPDMNAIKMOE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6457BD0", Offset = "0x6456FD0", VA = "0x186457BD0")]
	public static bool HAGCGOPJDDN(NPDMNAIKMOE OJKFAPKLEMA, NPDMNAIKMOE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6458E30", Offset = "0x6458230", VA = "0x186458E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LGAEGBALGBB : IEquatable<LGAEGBALGBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? PDNDFICKBGJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BKHFNIBKMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6458540", Offset = "0x6457940", VA = "0x186458540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int ECCMIIHEKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3A34D20", Offset = "0x3A34120", VA = "0x183A34D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6458AC0", Offset = "0x6457EC0", VA = "0x186458AC0")]
	public LGAEGBALGBB(string? HDHBIBBBCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6458C00", Offset = "0x6458000", VA = "0x186458C00")]
	public LGAEGBALGBB(string?[] AALHEEPKNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6458800", Offset = "0x6457C00", VA = "0x186458800")]
	private static string?[]? MOACFJBDPJN(string?[]? AALHEEPKNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x64587A0", Offset = "0x6457BA0", VA = "0x1864587A0")]
	public string IPDKNMKAAKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6458560", Offset = "0x6457960", VA = "0x186458560", Slot = "4")]
	public bool Equals(LGAEGBALGBB LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6458630", Offset = "0x6457A30", VA = "0x186458630", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64586C0", Offset = "0x6457AC0", VA = "0x1864586C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6458A30", Offset = "0x6457E30", VA = "0x186458A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OOPDJHHIALL : IEquatable<OOPDJHHIALL>, IComparable<OOPDJHHIALL>, KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OOPDJHHIALL ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid GJKCBNEBGAL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
	public OOPDJHHIALL(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0", Slot = "4")]
	public bool Equals(OOPDJHHIALL LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C90", Offset = "0x3DE7090", VA = "0x183DE7C90", Slot = "5")]
	public int CompareTo(OOPDJHHIALL LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6458F20", Offset = "0x6458320", VA = "0x186458F20", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E30", Offset = "0x3DE7230", VA = "0x183DE7E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7EB0", Offset = "0x3DE72B0", VA = "0x183DE7EB0")]
	public static bool FCHDBNDMOOD(OOPDJHHIALL OJKFAPKLEMA, OOPDJHHIALL BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6458FC0", Offset = "0x64583C0", VA = "0x186458FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AIEBEMKDAKL<TModern> : JJPJCJIDKGC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HNOKPEPFPLH(TModern FMPLPHMNAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KLGEPHJGHEG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BINBFKFLBCA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JJPJCJIDKGC<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern ENBFEHJBPLG(string FMPLPHMNAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FNOCCEJOOKG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AIEBEMKDAKL<GBIOGAOCJBJ> EPIPBLIGHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AIEBEMKDAKL<JEKHGGKMKJE> JAMCCJLAMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AIEBEMKDAKL<NPDMNAIKMOE> FNHLKMLPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AIEBEMKDAKL<HLIMNJNLOEL> KHPFNMDDPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AIEBEMKDAKL<JKAEIHBBPEI> NLEDFKPKIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AIEBEMKDAKL<NBEFKMDGOAE> IOICFPOOPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AIEBEMKDAKL<GEPFDDJIGPC> CLEENDALNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	AIEBEMKDAKL<EHPJADFBGFH> KDAGBDEMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HCBEEIFBJLA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6457EC0", Offset = "0x64572C0", VA = "0x186457EC0")]
	public static string[] MLIAAGBBEAK(string? HDHBIBBBCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6457E90", Offset = "0x6457290", VA = "0x186457E90")]
	public static string? DBKOKKNOHFF(string? KFGKINDJPOE)
	{
		return null;
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
