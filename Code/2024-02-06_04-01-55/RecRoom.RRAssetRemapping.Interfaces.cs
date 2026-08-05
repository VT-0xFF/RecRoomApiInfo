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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x66FD950", Offset = "0x66FCD50", VA = "0x1866FD950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CMKIOPIPLAD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ILCGODJBNBA(BIICCJCEIJJ EPJNNNGOOAO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BIICCJCEIJJ JCEFODEMOAF(string EPJNNNGOOAO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BIICCJCEIJJ : IEquatable<BIICCJCEIJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly NEDLJHKGNGL PDGOFDAFPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly CENAINPGEND GLGPHAJKOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid JPGIMOFFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? LGHFBPINCLA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ELIDIKLFOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66FBEF0", Offset = "0x66FB2F0", VA = "0x1866FBEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BJLPILDEJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66FBB60", Offset = "0x66FAF60", VA = "0x1866FBB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66FC440", Offset = "0x66FB840", VA = "0x1866FC440")]
	public BIICCJCEIJJ(BIICCJCEIJJ FGGKMOCDENI, [Optional] Guid LDGJAAOIEGI, [Optional] RRColor? MNHFMCFPMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x66FC3B0", Offset = "0x66FB7B0", VA = "0x1866FC3B0")]
	public BIICCJCEIJJ(NEDLJHKGNGL COLBIDCJEMK, CENAINPGEND APEGGJHHHFD, [Optional] Guid LDGJAAOIEGI, [Optional] RRColor? MNHFMCFPMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66FBBA0", Offset = "0x66FAFA0", VA = "0x1866FBBA0", Slot = "4")]
	public bool Equals(BIICCJCEIJJ KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66FBCA0", Offset = "0x66FB0A0", VA = "0x1866FBCA0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66FBD90", Offset = "0x66FB190", VA = "0x1866FBD90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x66FBE80", Offset = "0x66FB280", VA = "0x1866FBE80")]
	public static bool HOHCACPHFGD(BIICCJCEIJJ BGDKODNOBOD, BIICCJCEIJJ APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66FBAF0", Offset = "0x66FAEF0", VA = "0x1866FBAF0")]
	public static bool AEMEGLCBHEE(BIICCJCEIJJ BGDKODNOBOD, BIICCJCEIJJ APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66FBFB0", Offset = "0x66FB3B0", VA = "0x1866FBFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NEDLJHKGNGL : IEquatable<NEDLJHKGNGL>, IComparable<NEDLJHKGNGL>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly NEDLJHKGNGL IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public NEDLJHKGNGL(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(NEDLJHKGNGL KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(NEDLJHKGNGL KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x66FD730", Offset = "0x66FCB30", VA = "0x1866FD730", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(NEDLJHKGNGL BGDKODNOBOD, NEDLJHKGNGL APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(NEDLJHKGNGL BGDKODNOBOD, NEDLJHKGNGL APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x66FD7D0", Offset = "0x66FCBD0", VA = "0x1866FD7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IBELFNPGJPB : IEquatable<IBELFNPGJPB>, IComparable<IBELFNPGJPB>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly IBELFNPGJPB IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public IBELFNPGJPB(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(IBELFNPGJPB KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(IBELFNPGJPB KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x66FD2F0", Offset = "0x66FC6F0", VA = "0x1866FD2F0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(IBELFNPGJPB BGDKODNOBOD, IBELFNPGJPB APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(IBELFNPGJPB BGDKODNOBOD, IBELFNPGJPB APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x66FD390", Offset = "0x66FC790", VA = "0x1866FD390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GJBKAAIMHKF : IEquatable<GJBKAAIMHKF>, IComparable<GJBKAAIMHKF>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly GJBKAAIMHKF IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public GJBKAAIMHKF(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(GJBKAAIMHKF KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(GJBKAAIMHKF KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66FD1E0", Offset = "0x66FC5E0", VA = "0x1866FD1E0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(GJBKAAIMHKF BGDKODNOBOD, GJBKAAIMHKF APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(GJBKAAIMHKF BGDKODNOBOD, GJBKAAIMHKF APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x66FD280", Offset = "0x66FC680", VA = "0x1866FD280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct CENAINPGEND : IEquatable<CENAINPGEND>, IComparable<CENAINPGEND>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly CENAINPGEND IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OEAEIPNHKDB DMDDOLOJEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610")]
		[CompilerGenerated]
		get
		{
			return default(OEAEIPNHKDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OEAEIPNHKDB AOOKJKENBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEDE870", Offset = "0xEDDC70", VA = "0x180EDE870")]
		[CompilerGenerated]
		get
		{
			return default(OEAEIPNHKDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OEAEIPNHKDB PFNOKCLDEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE47380", Offset = "0xE46780", VA = "0x180E47380")]
		[CompilerGenerated]
		get
		{
			return default(OEAEIPNHKDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x66FC7E0", Offset = "0x66FBBE0", VA = "0x1866FC7E0")]
	public CENAINPGEND(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x66FC820", Offset = "0x66FBC20", VA = "0x1866FC820")]
	public CENAINPGEND(OEAEIPNHKDB GBAAKKBANEK, OEAEIPNHKDB LKANEJKDNPK, OEAEIPNHKDB ICMHKLOPOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x66FC600", Offset = "0x66FBA00", VA = "0x1866FC600")]
	private Guid HGKAHDJJPHG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x614F380", Offset = "0x614E780", VA = "0x18614F380", Slot = "4")]
	public bool Equals(CENAINPGEND KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x66FC550", Offset = "0x66FB950", VA = "0x1866FC550", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x66FC730", Offset = "0x66FBB30", VA = "0x1866FC730")]
	public static bool HOHCACPHFGD(CENAINPGEND BGDKODNOBOD, CENAINPGEND APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x66FC4D0", Offset = "0x66FB8D0", VA = "0x1866FC4D0")]
	public static bool AEMEGLCBHEE(CENAINPGEND BGDKODNOBOD, CENAINPGEND APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x66FC510", Offset = "0x66FB910", VA = "0x1866FC510", Slot = "5")]
	public int CompareTo(CENAINPGEND KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x66FC770", Offset = "0x66FBB70", VA = "0x1866FC770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JEKOHKIPLMM : IEquatable<JEKOHKIPLMM>, IComparable<JEKOHKIPLMM>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JEKOHKIPLMM IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public JEKOHKIPLMM(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(JEKOHKIPLMM KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(JEKOHKIPLMM KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66FD400", Offset = "0x66FC800", VA = "0x1866FD400", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(JEKOHKIPLMM BGDKODNOBOD, JEKOHKIPLMM APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(JEKOHKIPLMM BGDKODNOBOD, JEKOHKIPLMM APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x66FD4A0", Offset = "0x66FC8A0", VA = "0x1866FD4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct COJDBPEBDOA : IEquatable<COJDBPEBDOA>, IComparable<COJDBPEBDOA>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly COJDBPEBDOA IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public COJDBPEBDOA(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(COJDBPEBDOA KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(COJDBPEBDOA KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x66FC8A0", Offset = "0x66FBCA0", VA = "0x1866FC8A0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(COJDBPEBDOA BGDKODNOBOD, COJDBPEBDOA APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(COJDBPEBDOA BGDKODNOBOD, COJDBPEBDOA APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x66FC940", Offset = "0x66FBD40", VA = "0x1866FC940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NKHGCNKBHIG : IEquatable<NKHGCNKBHIG>, IComparable<NKHGCNKBHIG>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly NKHGCNKBHIG IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public NKHGCNKBHIG(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(NKHGCNKBHIG KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(NKHGCNKBHIG KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x66FD840", Offset = "0x66FCC40", VA = "0x1866FD840", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(NKHGCNKBHIG BGDKODNOBOD, NKHGCNKBHIG APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(NKHGCNKBHIG BGDKODNOBOD, NKHGCNKBHIG APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x66FD8E0", Offset = "0x66FCCE0", VA = "0x1866FD8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KLPHLAEFEOC : IEquatable<KLPHLAEFEOC>, IComparable<KLPHLAEFEOC>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly KLPHLAEFEOC IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public KLPHLAEFEOC(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(KLPHLAEFEOC KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(KLPHLAEFEOC KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x66FD620", Offset = "0x66FCA20", VA = "0x1866FD620", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(KLPHLAEFEOC BGDKODNOBOD, KLPHLAEFEOC APAKCINIMJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(KLPHLAEFEOC BGDKODNOBOD, KLPHLAEFEOC APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66FD6C0", Offset = "0x66FCAC0", VA = "0x1866FD6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct GCJLFGCANKK : IEquatable<GCJLFGCANKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? EEHENIFOEAB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PFEHLHJGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x66FCD40", Offset = "0x66FC140", VA = "0x1866FCD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int FEJOMDALNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B890", Offset = "0x3B1AC90", VA = "0x183B1B890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66FD020", Offset = "0x66FC420", VA = "0x1866FD020")]
	public GCJLFGCANKK(string? DGPDBEHIOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x66FD160", Offset = "0x66FC560", VA = "0x1866FD160")]
	public GCJLFGCANKK(string?[] COFNLLLDEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x66FCD60", Offset = "0x66FC160", VA = "0x1866FCD60")]
	private static string?[]? MDHLKPPGJKF(string?[]? COFNLLLDEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x66FCC00", Offset = "0x66FC000", VA = "0x1866FCC00")]
	public string FMGDDJLGLPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66FCAA0", Offset = "0x66FBEA0", VA = "0x1866FCAA0", Slot = "4")]
	public bool Equals(GCJLFGCANKK KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66FCB70", Offset = "0x66FBF70", VA = "0x1866FCB70", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x66FCC60", Offset = "0x66FC060", VA = "0x1866FCC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x66FCF90", Offset = "0x66FC390", VA = "0x1866FCF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OEAEIPNHKDB : IEquatable<OEAEIPNHKDB>, IComparable<OEAEIPNHKDB>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OEAEIPNHKDB IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public OEAEIPNHKDB(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(OEAEIPNHKDB KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(OEAEIPNHKDB KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x66FD9D0", Offset = "0x66FCDD0", VA = "0x1866FD9D0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40")]
	public static bool HOHCACPHFGD(OEAEIPNHKDB BGDKODNOBOD, OEAEIPNHKDB APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x66FDA70", Offset = "0x66FCE70", VA = "0x1866FDA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JLBCCOCGGIM : IEquatable<JLBCCOCGGIM>, IComparable<JLBCCOCGGIM>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JLBCCOCGGIM IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid LHLNCEHJAOH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
	public JLBCCOCGGIM(Guid LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public Guid FBPFMNCBNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4736F40", Offset = "0x4736340", VA = "0x184736F40", Slot = "4")]
	public bool Equals(JLBCCOCGGIM KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
	public int CompareTo(JLBCCOCGGIM KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x66FD510", Offset = "0x66FC910", VA = "0x1866FD510", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4736FF0", Offset = "0x47363F0", VA = "0x184736FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66FC870", Offset = "0x66FBC70", VA = "0x1866FC870")]
	public static bool AEMEGLCBHEE(JLBCCOCGGIM BGDKODNOBOD, JLBCCOCGGIM APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x66FD5B0", Offset = "0x66FC9B0", VA = "0x1866FD5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OJOEPEDKNCC<TModern> : IOONJIAMAMM<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GGNAIIPBHPC(TModern AKKFBEGKCIB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BBHCOKLJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid FBPFMNCBNOD();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IOONJIAMAMM<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern LDMGOKAFNNK(string AKKFBEGKCIB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CLOCPKMNDGM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OJOEPEDKNCC<NEDLJHKGNGL> GABDOAOCJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OJOEPEDKNCC<JEKOHKIPLMM> DLEANBJEOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OJOEPEDKNCC<KLPHLAEFEOC> ENJJHBCKNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OJOEPEDKNCC<CENAINPGEND> EAMNPALOLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OJOEPEDKNCC<GJBKAAIMHKF> NMBBKFOGKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OJOEPEDKNCC<NKHGCNKBHIG> LALKKKBJHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OJOEPEDKNCC<IBELFNPGJPB> ECBABGLACFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OJOEPEDKNCC<COJDBPEBDOA> ALNMMKENLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FMKGCLJEOOB
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x66FC9B0", Offset = "0x66FBDB0", VA = "0x1866FC9B0")]
	public static string[] IOPODBKLCPP(string? DGPDBEHIOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x66FCA70", Offset = "0x66FBE70", VA = "0x1866FCA70")]
	public static string? JEIADIAMOEN(string? COLBIDCJEMK)
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
