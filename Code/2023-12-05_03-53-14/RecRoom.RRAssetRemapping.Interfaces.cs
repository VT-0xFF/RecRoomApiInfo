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
		[Cpp2IlInjected.Address(RVA = "0x6458DC0", Offset = "0x64581C0", VA = "0x186458DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64572D0", Offset = "0x64566D0", VA = "0x1864572D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MOJNCNDIEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64574F0", Offset = "0x64568F0", VA = "0x1864574F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6457930", Offset = "0x6456D30", VA = "0x186457930")]
	public AFKPLGJHCHM(AFKPLGJHCHM PJDJBOICLBL, [Optional] Guid LFONKHHODHC, [Optional] RRColor? DDJLPLIEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64579C0", Offset = "0x6456DC0", VA = "0x1864579C0")]
	public AFKPLGJHCHM(GBIOGAOCJBJ KFGKINDJPOE, HLIMNJNLOEL BPDFAAHEPGM, [Optional] Guid LFONKHHODHC, [Optional] RRColor? DDJLPLIEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6457160", Offset = "0x6456560", VA = "0x186457160", Slot = "4")]
	public bool Equals(AFKPLGJHCHM LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6457070", Offset = "0x6456470", VA = "0x186457070", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6457390", Offset = "0x6456790", VA = "0x186457390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6457260", Offset = "0x6456660", VA = "0x186457260")]
	public static bool FCHDBNDMOOD(AFKPLGJHCHM OJKFAPKLEMA, AFKPLGJHCHM BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6457480", Offset = "0x6456880", VA = "0x186457480")]
	public static bool HAGCGOPJDDN(AFKPLGJHCHM OJKFAPKLEMA, AFKPLGJHCHM BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6457530", Offset = "0x6456930", VA = "0x186457530", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public GBIOGAOCJBJ(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(GBIOGAOCJBJ LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(GBIOGAOCJBJ LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6457B90", Offset = "0x6456F90", VA = "0x186457B90", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(GBIOGAOCJBJ OJKFAPKLEMA, GBIOGAOCJBJ BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6457AF0", Offset = "0x6456EF0", VA = "0x186457AF0")]
	public static bool HAGCGOPJDDN(GBIOGAOCJBJ OJKFAPKLEMA, GBIOGAOCJBJ BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6457C30", Offset = "0x6457030", VA = "0x186457C30", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public GEPFDDJIGPC(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(GEPFDDJIGPC LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(GEPFDDJIGPC LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6457CA0", Offset = "0x64570A0", VA = "0x186457CA0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(GEPFDDJIGPC OJKFAPKLEMA, GEPFDDJIGPC BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6457AF0", Offset = "0x6456EF0", VA = "0x186457AF0")]
	public static bool HAGCGOPJDDN(GEPFDDJIGPC OJKFAPKLEMA, GEPFDDJIGPC BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6457D40", Offset = "0x6457140", VA = "0x186457D40", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public JKAEIHBBPEI(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(JKAEIHBBPEI LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(JKAEIHBBPEI LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6458350", Offset = "0x6457750", VA = "0x186458350", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(JKAEIHBBPEI OJKFAPKLEMA, JKAEIHBBPEI BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6457AF0", Offset = "0x6456EF0", VA = "0x186457AF0")]
	public static bool HAGCGOPJDDN(JKAEIHBBPEI OJKFAPKLEMA, JKAEIHBBPEI BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64583F0", Offset = "0x64577F0", VA = "0x1864583F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xB18F40", Offset = "0xB18340", VA = "0x180B18F40")]
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
		[Cpp2IlInjected.Address(RVA = "0xEE10B0", Offset = "0xEE04B0", VA = "0x180EE10B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDF9B50", Offset = "0xDF8F50", VA = "0x180DF9B50")]
		[CompilerGenerated]
		get
		{
			return default(OOPDJHHIALL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x64581B0", Offset = "0x64575B0", VA = "0x1864581B0")]
	public HLIMNJNLOEL(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x64581F0", Offset = "0x64575F0", VA = "0x1864581F0")]
	public HLIMNJNLOEL(OOPDJHHIALL LAFADMNMFII, OOPDJHHIALL BDICDANGGNB, OOPDJHHIALL CAADJANCPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6457EE0", Offset = "0x64572E0", VA = "0x186457EE0")]
	private Guid EPPGEJDLOJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0A20", Offset = "0x5ECFE20", VA = "0x185ED0A20", Slot = "4")]
	public bool Equals(HLIMNJNLOEL LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6458010", Offset = "0x6457410", VA = "0x186458010", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x64580C0", Offset = "0x64574C0", VA = "0x1864580C0")]
	public static bool FCHDBNDMOOD(HLIMNJNLOEL OJKFAPKLEMA, HLIMNJNLOEL BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6458100", Offset = "0x6457500", VA = "0x186458100")]
	public static bool HAGCGOPJDDN(HLIMNJNLOEL OJKFAPKLEMA, HLIMNJNLOEL BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6457EA0", Offset = "0x64572A0", VA = "0x186457EA0", Slot = "5")]
	public int CompareTo(HLIMNJNLOEL LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6458140", Offset = "0x6457540", VA = "0x186458140", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public JEKHGGKMKJE(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(JEKHGGKMKJE LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(JEKHGGKMKJE LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6458240", Offset = "0x6457640", VA = "0x186458240", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(JEKHGGKMKJE OJKFAPKLEMA, JEKHGGKMKJE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6457AF0", Offset = "0x6456EF0", VA = "0x186457AF0")]
	public static bool HAGCGOPJDDN(JEKHGGKMKJE OJKFAPKLEMA, JEKHGGKMKJE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x64582E0", Offset = "0x64576E0", VA = "0x1864582E0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public EHPJADFBGFH(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(EHPJADFBGFH LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(EHPJADFBGFH LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6457A50", Offset = "0x6456E50", VA = "0x186457A50", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(EHPJADFBGFH OJKFAPKLEMA, EHPJADFBGFH BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6457AF0", Offset = "0x6456EF0", VA = "0x186457AF0")]
	public static bool HAGCGOPJDDN(EHPJADFBGFH OJKFAPKLEMA, EHPJADFBGFH BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6457B20", Offset = "0x6456F20", VA = "0x186457B20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public NBEFKMDGOAE(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(NBEFKMDGOAE LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(NBEFKMDGOAE LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6458BA0", Offset = "0x6457FA0", VA = "0x186458BA0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(NBEFKMDGOAE OJKFAPKLEMA, NBEFKMDGOAE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6457AF0", Offset = "0x6456EF0", VA = "0x186457AF0")]
	public static bool HAGCGOPJDDN(NBEFKMDGOAE OJKFAPKLEMA, NBEFKMDGOAE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6458C40", Offset = "0x6458040", VA = "0x186458C40", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public NPDMNAIKMOE(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(NPDMNAIKMOE LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(NPDMNAIKMOE LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6458CB0", Offset = "0x64580B0", VA = "0x186458CB0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(NPDMNAIKMOE OJKFAPKLEMA, NPDMNAIKMOE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6457AF0", Offset = "0x6456EF0", VA = "0x186457AF0")]
	public static bool HAGCGOPJDDN(NPDMNAIKMOE OJKFAPKLEMA, NPDMNAIKMOE BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6458D50", Offset = "0x6458150", VA = "0x186458D50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6458460", Offset = "0x6457860", VA = "0x186458460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int ECCMIIHEKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3A345E0", Offset = "0x3A339E0", VA = "0x183A345E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x64589E0", Offset = "0x6457DE0", VA = "0x1864589E0")]
	public LGAEGBALGBB(string? HDHBIBBBCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6458B20", Offset = "0x6457F20", VA = "0x186458B20")]
	public LGAEGBALGBB(string?[] AALHEEPKNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6458720", Offset = "0x6457B20", VA = "0x186458720")]
	private static string?[]? MOACFJBDPJN(string?[]? AALHEEPKNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x64586C0", Offset = "0x6457AC0", VA = "0x1864586C0")]
	public string IPDKNMKAAKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6458480", Offset = "0x6457880", VA = "0x186458480", Slot = "4")]
	public bool Equals(LGAEGBALGBB LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6458550", Offset = "0x6457950", VA = "0x186458550", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64585E0", Offset = "0x64579E0", VA = "0x1864585E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6458950", Offset = "0x6457D50", VA = "0x186458950", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public OOPDJHHIALL(Guid GJKCBNEBGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
	public Guid BINBFKFLBCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300", Slot = "4")]
	public bool Equals(OOPDJHHIALL LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0", Slot = "5")]
	public int CompareTo(OOPDJHHIALL LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6458E40", Offset = "0x6458240", VA = "0x186458E40", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9280", Offset = "0x3DE8680", VA = "0x183DE9280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9300", Offset = "0x3DE8700", VA = "0x183DE9300")]
	public static bool FCHDBNDMOOD(OOPDJHHIALL OJKFAPKLEMA, OOPDJHHIALL BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6458EE0", Offset = "0x64582E0", VA = "0x186458EE0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6457DE0", Offset = "0x64571E0", VA = "0x186457DE0")]
	public static string[] MLIAAGBBEAK(string? HDHBIBBBCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6457DB0", Offset = "0x64571B0", VA = "0x186457DB0")]
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
