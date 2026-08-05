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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C8050", Offset = "0x62C6E50", VA = "0x1862C8050")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DCELPGDDPNG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GKMCGBDALGF(DLMLPLPLKBA ENGEPLNNBDC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DLMLPLPLKBA EFHLMHLMFOG(string ENGEPLNNBDC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DLMLPLPLKBA : IEquatable<DLMLPLPLKBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly JFJOENEOEEK EEPHLDFLLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GDNGPBHAAIH NHAPNMIEBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid NBIKEJKKLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? FEKCDBEFCCK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ICNJICENMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62C6B60", Offset = "0x62C5960", VA = "0x1862C6B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JFPHOKDPPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62C6C90", Offset = "0x62C5A90", VA = "0x1862C6C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62C7420", Offset = "0x62C6220", VA = "0x1862C7420")]
	public DLMLPLPLKBA(DLMLPLPLKBA GEAGIAHFJGO, [Optional] Guid FPELHNLHNNB, [Optional] RRColor? BJLKCDOCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62C74B0", Offset = "0x62C62B0", VA = "0x1862C74B0")]
	public DLMLPLPLKBA(JFJOENEOEEK MNNAIKPBGNB, GDNGPBHAAIH LIIMEILJJGB, [Optional] Guid FPELHNLHNNB, [Optional] RRColor? BJLKCDOCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62C6CD0", Offset = "0x62C5AD0", VA = "0x1862C6CD0", Slot = "4")]
	public bool Equals(DLMLPLPLKBA MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62C6DD0", Offset = "0x62C5BD0", VA = "0x1862C6DD0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62C6EC0", Offset = "0x62C5CC0", VA = "0x1862C6EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62C6FB0", Offset = "0x62C5DB0", VA = "0x1862C6FB0")]
	public static bool NOLBLOCHCOA(DLMLPLPLKBA HADGDMKFEOD, DLMLPLPLKBA CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62C6C20", Offset = "0x62C5A20", VA = "0x1862C6C20")]
	public static bool BPHGJPBDHAH(DLMLPLPLKBA HADGDMKFEOD, DLMLPLPLKBA CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62C7020", Offset = "0x62C5E20", VA = "0x1862C7020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct JFJOENEOEEK : IEquatable<JFJOENEOEEK>, IComparable<JFJOENEOEEK>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JFJOENEOEEK AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public JFJOENEOEEK(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(JFJOENEOEEK MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(JFJOENEOEEK MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62C79F0", Offset = "0x62C67F0", VA = "0x1862C79F0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(JFJOENEOEEK HADGDMKFEOD, JFJOENEOEEK CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62C61F0", Offset = "0x62C4FF0", VA = "0x1862C61F0")]
	public static bool BPHGJPBDHAH(JFJOENEOEEK HADGDMKFEOD, JFJOENEOEEK CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62C7A90", Offset = "0x62C6890", VA = "0x1862C7A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NGEIMOEOPCO : IEquatable<NGEIMOEOPCO>, IComparable<NGEIMOEOPCO>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly NGEIMOEOPCO AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public NGEIMOEOPCO(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(NGEIMOEOPCO MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(NGEIMOEOPCO MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62C7E30", Offset = "0x62C6C30", VA = "0x1862C7E30", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(NGEIMOEOPCO HADGDMKFEOD, NGEIMOEOPCO CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62C61F0", Offset = "0x62C4FF0", VA = "0x1862C61F0")]
	public static bool BPHGJPBDHAH(NGEIMOEOPCO HADGDMKFEOD, NGEIMOEOPCO CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62C7ED0", Offset = "0x62C6CD0", VA = "0x1862C7ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KFFJOEKIJAH : IEquatable<KFFJOEKIJAH>, IComparable<KFFJOEKIJAH>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly KFFJOEKIJAH AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public KFFJOEKIJAH(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(KFFJOEKIJAH MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(KFFJOEKIJAH MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62C7B00", Offset = "0x62C6900", VA = "0x1862C7B00", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(KFFJOEKIJAH HADGDMKFEOD, KFFJOEKIJAH CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62C61F0", Offset = "0x62C4FF0", VA = "0x1862C61F0")]
	public static bool BPHGJPBDHAH(KFFJOEKIJAH HADGDMKFEOD, KFFJOEKIJAH CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62C7BA0", Offset = "0x62C69A0", VA = "0x1862C7BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct GDNGPBHAAIH : IEquatable<GDNGPBHAAIH>, IComparable<GDNGPBHAAIH>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly GDNGPBHAAIH AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KMLLLEBGBIK DDEMODIJJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850")]
		[CompilerGenerated]
		get
		{
			return default(KMLLLEBGBIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KMLLLEBGBIK CFHEELHKCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD47AA0", VA = "0x180D48CA0")]
		[CompilerGenerated]
		get
		{
			return default(KMLLLEBGBIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KMLLLEBGBIK BKPABJGIBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5E260", VA = "0x180D5F460")]
		[CompilerGenerated]
		get
		{
			return default(KMLLLEBGBIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62C78A0", Offset = "0x62C66A0", VA = "0x1862C78A0")]
	public GDNGPBHAAIH(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62C7850", Offset = "0x62C6650", VA = "0x1862C7850")]
	public GDNGPBHAAIH(KMLLLEBGBIK GBKLIIDFGIB, KMLLLEBGBIK AOPHIILILIK, KMLLLEBGBIK IFLFPOFFKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62C75C0", Offset = "0x62C63C0", VA = "0x1862C75C0")]
	private Guid ENPIHDFMIOO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D90070", Offset = "0x5D8EE70", VA = "0x185D90070", Slot = "4")]
	public bool Equals(GDNGPBHAAIH MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62C76F0", Offset = "0x62C64F0", VA = "0x1862C76F0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62C77A0", Offset = "0x62C65A0", VA = "0x1862C77A0")]
	public static bool NOLBLOCHCOA(GDNGPBHAAIH HADGDMKFEOD, GDNGPBHAAIH CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62C7540", Offset = "0x62C6340", VA = "0x1862C7540")]
	public static bool BPHGJPBDHAH(GDNGPBHAAIH HADGDMKFEOD, GDNGPBHAAIH CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62C7580", Offset = "0x62C6380", VA = "0x1862C7580", Slot = "5")]
	public int CompareTo(GDNGPBHAAIH MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62C77E0", Offset = "0x62C65E0", VA = "0x1862C77E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HMCLDAHIPDM : IEquatable<HMCLDAHIPDM>, IComparable<HMCLDAHIPDM>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HMCLDAHIPDM AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public HMCLDAHIPDM(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(HMCLDAHIPDM MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(HMCLDAHIPDM MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62C78E0", Offset = "0x62C66E0", VA = "0x1862C78E0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(HMCLDAHIPDM HADGDMKFEOD, HMCLDAHIPDM CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62C61F0", Offset = "0x62C4FF0", VA = "0x1862C61F0")]
	public static bool BPHGJPBDHAH(HMCLDAHIPDM HADGDMKFEOD, HMCLDAHIPDM CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62C7980", Offset = "0x62C6780", VA = "0x1862C7980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NJILKKKHBCK : IEquatable<NJILKKKHBCK>, IComparable<NJILKKKHBCK>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NJILKKKHBCK AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public NJILKKKHBCK(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(NJILKKKHBCK MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(NJILKKKHBCK MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62C7F40", Offset = "0x62C6D40", VA = "0x1862C7F40", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(NJILKKKHBCK HADGDMKFEOD, NJILKKKHBCK CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62C7FE0", Offset = "0x62C6DE0", VA = "0x1862C7FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BOMNBMOHBFK : IEquatable<BOMNBMOHBFK>, IComparable<BOMNBMOHBFK>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly BOMNBMOHBFK AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public BOMNBMOHBFK(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(BOMNBMOHBFK MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(BOMNBMOHBFK MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62C6220", Offset = "0x62C5020", VA = "0x1862C6220", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(BOMNBMOHBFK HADGDMKFEOD, BOMNBMOHBFK CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62C61F0", Offset = "0x62C4FF0", VA = "0x1862C61F0")]
	public static bool BPHGJPBDHAH(BOMNBMOHBFK HADGDMKFEOD, BOMNBMOHBFK CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62C62C0", Offset = "0x62C50C0", VA = "0x1862C62C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct NCIGLFEJKIH : IEquatable<NCIGLFEJKIH>, IComparable<NCIGLFEJKIH>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly NCIGLFEJKIH AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public NCIGLFEJKIH(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(NCIGLFEJKIH MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(NCIGLFEJKIH MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62C7D20", Offset = "0x62C6B20", VA = "0x1862C7D20", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(NCIGLFEJKIH HADGDMKFEOD, NCIGLFEJKIH CJIAEKJDMKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62C61F0", Offset = "0x62C4FF0", VA = "0x1862C61F0")]
	public static bool BPHGJPBDHAH(NCIGLFEJKIH HADGDMKFEOD, NCIGLFEJKIH CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62C7DC0", Offset = "0x62C6BC0", VA = "0x1862C7DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct CJKFMGJBHAJ : IEquatable<CJKFMGJBHAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? CILDDJHFLLP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GBAJLLCPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62C6560", Offset = "0x62C5360", VA = "0x1862C6560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int JIGOIPECHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3995890", Offset = "0x3994690", VA = "0x183995890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62C6930", Offset = "0x62C5730", VA = "0x1862C6930")]
	public CJKFMGJBHAJ(string? BIBOHPNFNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62C68B0", Offset = "0x62C56B0", VA = "0x1862C68B0")]
	public CJKFMGJBHAJ(string?[] KKLLEGLICOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x62C6330", Offset = "0x62C5130", VA = "0x1862C6330")]
	private static string?[]? BKNIGHKJDJE(string?[]? KKLLEGLICOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x62C67C0", Offset = "0x62C55C0", VA = "0x1862C67C0")]
	public string LKMJAFLIPKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x62C6580", Offset = "0x62C5380", VA = "0x1862C6580", Slot = "4")]
	public bool Equals(CJKFMGJBHAJ MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62C6650", Offset = "0x62C5450", VA = "0x1862C6650", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62C66E0", Offset = "0x62C54E0", VA = "0x1862C66E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62C6820", Offset = "0x62C5620", VA = "0x1862C6820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KMLLLEBGBIK : IEquatable<KMLLLEBGBIK>, IComparable<KMLLLEBGBIK>, EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly KMLLLEBGBIK AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid FGCEIIELPBP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public KMLLLEBGBIK(Guid FGCEIIELPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public Guid BDAOGOBABLJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70", Slot = "4")]
	public bool Equals(KMLLLEBGBIK MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x34A4BB0", Offset = "0x34A39B0", VA = "0x1834A4BB0", Slot = "5")]
	public int CompareTo(KMLLLEBGBIK MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62C7C10", Offset = "0x62C6A10", VA = "0x1862C7C10", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E50", Offset = "0x34A3C50", VA = "0x1834A4E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x34A4E70", Offset = "0x34A3C70", VA = "0x1834A4E70")]
	public static bool NOLBLOCHCOA(KMLLLEBGBIK HADGDMKFEOD, KMLLLEBGBIK CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62C7CB0", Offset = "0x62C6AB0", VA = "0x1862C7CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PHCCFGKEDML<TModern> : LPHAPLFHHGC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NFDLIIGLKML(TModern AMPODBDAPEM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EHJFCIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BDAOGOBABLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LPHAPLFHHGC<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern EPPJDMJHKPB(string AMPODBDAPEM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EDLHFAEHJIC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PHCCFGKEDML<JFJOENEOEEK> LPHMCGHMECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PHCCFGKEDML<HMCLDAHIPDM> FPKEMOBDDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PHCCFGKEDML<NCIGLFEJKIH> PLCIFODIHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PHCCFGKEDML<GDNGPBHAAIH> FLKNLNIPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PHCCFGKEDML<KFFJOEKIJAH> IIAMNHKOHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	PHCCFGKEDML<BOMNBMOHBFK> GCGOFIJOKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PHCCFGKEDML<NGEIMOEOPCO> OJJBJGBDNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PHCCFGKEDML<NJILKKKHBCK> PIHKEELJHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DDCOJILAFBC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62C6AA0", Offset = "0x62C58A0", VA = "0x1862C6AA0")]
	public static string[] HEFAMECPJCH(string? BIBOHPNFNGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62C6A70", Offset = "0x62C5870", VA = "0x1862C6A70")]
	public static string? FEJEIHPGHHH(string? MNNAIKPBGNB)
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
