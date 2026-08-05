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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F4AF50", Offset = "0x6F49750", VA = "0x186F4AF50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FPGHMOIDPNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HNAIEAEAFJH(JEMEAOBLCBJ FDJIPPJKNDH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEMEAOBLCBJ PKPMANIAHDL(string FDJIPPJKNDH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct JEMEAOBLCBJ : IEquatable<JEMEAOBLCBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HAPGBAHNIJN GJMMECNJHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NPEBPDPBEAI ELPELENOKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid MPAEJKCEDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? NAANPBDAGHF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JIKFNDLMOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A340", Offset = "0x6F48B40", VA = "0x186F4A340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JJLOHEPPGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A300", Offset = "0x6F48B00", VA = "0x186F4A300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A8B0", Offset = "0x6F490B0", VA = "0x186F4A8B0")]
	public JEMEAOBLCBJ(JEMEAOBLCBJ PNFEKCLMGGJ, [Optional] Guid HKLDIPLNKCF, [Optional] RRColor? NLKAPPNAHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A820", Offset = "0x6F49020", VA = "0x186F4A820")]
	public JEMEAOBLCBJ(HAPGBAHNIJN NMJFGLOIAMF, NPEBPDPBEAI LAJJDJNPIIG, [Optional] Guid HKLDIPLNKCF, [Optional] RRColor? NLKAPPNAHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A110", Offset = "0x6F48910", VA = "0x186F4A110", Slot = "4")]
	public bool Equals(JEMEAOBLCBJ OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F49FE0", Offset = "0x6F487E0", VA = "0x186F49FE0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A270", Offset = "0x6F48A70", VA = "0x186F4A270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A110", Offset = "0x6F48910", VA = "0x186F4A110")]
	public static bool JAJJILMADFD(JEMEAOBLCBJ LDKECOBJCHJ, JEMEAOBLCBJ JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A1C0", Offset = "0x6F489C0", VA = "0x186F4A1C0")]
	public static bool GLAAFHEDDBF(JEMEAOBLCBJ LDKECOBJCHJ, JEMEAOBLCBJ JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A400", Offset = "0x6F48C00", VA = "0x186F4A400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HAPGBAHNIJN : IEquatable<HAPGBAHNIJN>, IComparable<HAPGBAHNIJN>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly HAPGBAHNIJN IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public HAPGBAHNIJN(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(HAPGBAHNIJN OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(HAPGBAHNIJN OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F49DA0", Offset = "0x6F485A0", VA = "0x186F49DA0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(HAPGBAHNIJN LDKECOBJCHJ, HAPGBAHNIJN JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AC0", Offset = "0x6F482C0", VA = "0x186F49AC0")]
	public static bool GLAAFHEDDBF(HAPGBAHNIJN LDKECOBJCHJ, HAPGBAHNIJN JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F49E50", Offset = "0x6F48650", VA = "0x186F49E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IMGHHJDAPBF : IEquatable<IMGHHJDAPBF>, IComparable<IMGHHJDAPBF>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly IMGHHJDAPBF IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public IMGHHJDAPBF(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(IMGHHJDAPBF OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(IMGHHJDAPBF OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F49EC0", Offset = "0x6F486C0", VA = "0x186F49EC0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(IMGHHJDAPBF LDKECOBJCHJ, IMGHHJDAPBF JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AC0", Offset = "0x6F482C0", VA = "0x186F49AC0")]
	public static bool GLAAFHEDDBF(IMGHHJDAPBF LDKECOBJCHJ, IMGHHJDAPBF JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F49F70", Offset = "0x6F48770", VA = "0x186F49F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GJGDDNMDCIJ : IEquatable<GJGDDNMDCIJ>, IComparable<GJGDDNMDCIJ>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly GJGDDNMDCIJ IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public GJGDDNMDCIJ(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(GJGDDNMDCIJ OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(GJGDDNMDCIJ OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F49C80", Offset = "0x6F48480", VA = "0x186F49C80", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(GJGDDNMDCIJ LDKECOBJCHJ, GJGDDNMDCIJ JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AC0", Offset = "0x6F482C0", VA = "0x186F49AC0")]
	public static bool GLAAFHEDDBF(GJGDDNMDCIJ LDKECOBJCHJ, GJGDDNMDCIJ JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F49D30", Offset = "0x6F48530", VA = "0x186F49D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NPEBPDPBEAI : IEquatable<NPEBPDPBEAI>, IComparable<NPEBPDPBEAI>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly NPEBPDPBEAI IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EIPBOOGAIEP HOOLOKFDDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
		[CompilerGenerated]
		get
		{
			return default(EIPBOOGAIEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EIPBOOGAIEP BOBEKKPNPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAF0", Offset = "0x8B92F0", VA = "0x1808BAAF0")]
		[CompilerGenerated]
		get
		{
			return default(EIPBOOGAIEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EIPBOOGAIEP KHIPPCDGFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C98E0", Offset = "0x8C80E0", VA = "0x1808C98E0")]
		[CompilerGenerated]
		get
		{
			return default(EIPBOOGAIEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AF10", Offset = "0x6F49710", VA = "0x186F4AF10")]
	public NPEBPDPBEAI(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AEC0", Offset = "0x6F496C0", VA = "0x186F4AEC0")]
	public NPEBPDPBEAI(EIPBOOGAIEP GFAJNBBMAGG, EIPBOOGAIEP LJDALIHGOKA, EIPBOOGAIEP MLDPLAIIBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AD20", Offset = "0x6F49520", VA = "0x186F4AD20")]
	private Guid PPFBOKNGKDJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AC70", Offset = "0x6F49470", VA = "0x186F4AC70", Slot = "4")]
	public bool Equals(NPEBPDPBEAI OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ABC0", Offset = "0x6F493C0", VA = "0x186F4ABC0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ACE0", Offset = "0x6F494E0", VA = "0x186F4ACE0")]
	public static bool JAJJILMADFD(NPEBPDPBEAI LDKECOBJCHJ, NPEBPDPBEAI JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ACA0", Offset = "0x6F494A0", VA = "0x186F4ACA0")]
	public static bool GLAAFHEDDBF(NPEBPDPBEAI LDKECOBJCHJ, NPEBPDPBEAI JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AB80", Offset = "0x6F49380", VA = "0x186F4AB80", Slot = "5")]
	public int CompareTo(NPEBPDPBEAI OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AE50", Offset = "0x6F49650", VA = "0x186F4AE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NKIGMCFBDEK : IEquatable<NKIGMCFBDEK>, IComparable<NKIGMCFBDEK>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NKIGMCFBDEK IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public NKIGMCFBDEK(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(NKIGMCFBDEK OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(NKIGMCFBDEK OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AA60", Offset = "0x6F49260", VA = "0x186F4AA60", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(NKIGMCFBDEK LDKECOBJCHJ, NKIGMCFBDEK JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AC0", Offset = "0x6F482C0", VA = "0x186F49AC0")]
	public static bool GLAAFHEDDBF(NKIGMCFBDEK LDKECOBJCHJ, NKIGMCFBDEK JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AB10", Offset = "0x6F49310", VA = "0x186F4AB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CFAGBELJJDL : IEquatable<CFAGBELJJDL>, IComparable<CFAGBELJJDL>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly CFAGBELJJDL IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public CFAGBELJJDL(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(CFAGBELJJDL OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(CFAGBELJJDL OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F49A10", Offset = "0x6F48210", VA = "0x186F49A10", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(CFAGBELJJDL LDKECOBJCHJ, CFAGBELJJDL JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AC0", Offset = "0x6F482C0", VA = "0x186F49AC0")]
	public static bool GLAAFHEDDBF(CFAGBELJJDL LDKECOBJCHJ, CFAGBELJJDL JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AF0", Offset = "0x6F482F0", VA = "0x186F49AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct MHJGBGNNDJI : IEquatable<MHJGBGNNDJI>, IComparable<MHJGBGNNDJI>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly MHJGBGNNDJI IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public MHJGBGNNDJI(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(MHJGBGNNDJI OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(MHJGBGNNDJI OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A940", Offset = "0x6F49140", VA = "0x186F4A940", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(MHJGBGNNDJI LDKECOBJCHJ, MHJGBGNNDJI JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AC0", Offset = "0x6F482C0", VA = "0x186F49AC0")]
	public static bool GLAAFHEDDBF(MHJGBGNNDJI LDKECOBJCHJ, MHJGBGNNDJI JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A9F0", Offset = "0x6F491F0", VA = "0x186F4A9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct OCAJLLGKCNC : IEquatable<OCAJLLGKCNC>, IComparable<OCAJLLGKCNC>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly OCAJLLGKCNC IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public OCAJLLGKCNC(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(OCAJLLGKCNC OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(OCAJLLGKCNC OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AFD0", Offset = "0x6F497D0", VA = "0x186F4AFD0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(OCAJLLGKCNC LDKECOBJCHJ, OCAJLLGKCNC JFMCJHKCOJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AC0", Offset = "0x6F482C0", VA = "0x186F49AC0")]
	public static bool GLAAFHEDDBF(OCAJLLGKCNC LDKECOBJCHJ, OCAJLLGKCNC JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B080", Offset = "0x6F49880", VA = "0x186F4B080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct AMCKELCMONE : IEquatable<AMCKELCMONE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? IBKLMBFGEPE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HACFJPDLFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F49740", Offset = "0x6F47F40", VA = "0x186F49740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int AJAFIHFFJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x404C0E0", Offset = "0x404A8E0", VA = "0x18404C0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F49850", Offset = "0x6F48050", VA = "0x186F49850")]
	public AMCKELCMONE(string? INACHHKJCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F49990", Offset = "0x6F48190", VA = "0x186F49990")]
	public AMCKELCMONE(string?[] GHLNKEHBEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F492D0", Offset = "0x6F47AD0", VA = "0x186F492D0")]
	private static string?[]? AKGCECLFHHF(string?[]? GHLNKEHBEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F49760", Offset = "0x6F47F60", VA = "0x186F49760")]
	public string OAOABIMGCHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F49590", Offset = "0x6F47D90", VA = "0x186F49590", Slot = "4")]
	public bool Equals(AMCKELCMONE OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F49500", Offset = "0x6F47D00", VA = "0x186F49500", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F49660", Offset = "0x6F47E60", VA = "0x186F49660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F497C0", Offset = "0x6F47FC0", VA = "0x186F497C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EIPBOOGAIEP : IEquatable<EIPBOOGAIEP>, IComparable<EIPBOOGAIEP>, AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly EIPBOOGAIEP IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public EIPBOOGAIEP(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(EIPBOOGAIEP OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(EIPBOOGAIEP OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F49B60", Offset = "0x6F48360", VA = "0x186F49B60", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0")]
	public static bool JAJJILMADFD(EIPBOOGAIEP LDKECOBJCHJ, EIPBOOGAIEP JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F49C10", Offset = "0x6F48410", VA = "0x186F49C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OOEOLGEGDMP : IEquatable<OOEOLGEGDMP>, IComparable<OOEOLGEGDMP>, AHEOGJEMBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid PGOHCHKMLGH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
	public OOEOLGEGDMP(Guid PGOHCHKMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770", Slot = "6")]
	public Guid AEDFFNCBBCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x376DCB0", Offset = "0x376C4B0", VA = "0x18376DCB0", Slot = "4")]
	public bool Equals(OOEOLGEGDMP OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x376DBF0", Offset = "0x376C3F0", VA = "0x18376DBF0", Slot = "5")]
	public int CompareTo(OOEOLGEGDMP OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B0F0", Offset = "0x6F498F0", VA = "0x186F4B0F0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x376DD40", Offset = "0x376C540", VA = "0x18376DD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B1A0", Offset = "0x6F499A0", VA = "0x186F4B1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BEDDFMDHJNJ<TModern> : EOJBOLPBPIO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JCJHCCCACOA(TModern LCCJJDFEJAB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AHEOGJEMBED
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid AEDFFNCBBCF();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EOJBOLPBPIO<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern OBIGEILLMPL(string LCCJJDFEJAB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IGKLCLDEJHC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BEDDFMDHJNJ<HAPGBAHNIJN> EJOMONGBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BEDDFMDHJNJ<NKIGMCFBDEK> MIOJEDOCECL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BEDDFMDHJNJ<OCAJLLGKCNC> EBNGFCFPMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BEDDFMDHJNJ<NPEBPDPBEAI> AFFKCJHDJME
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BEDDFMDHJNJ<GJGDDNMDCIJ> CBIHOFJGDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BEDDFMDHJNJ<MHJGBGNNDJI> MNGAPKAOGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BEDDFMDHJNJ<IMGHHJDAPBF> ICLOPEHMOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	BEDDFMDHJNJ<CFAGBELJJDL> ELDPOMADNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ADPGIDPIDAD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F49210", Offset = "0x6F47A10", VA = "0x186F49210")]
	public static string[] EEMAJNCJAIG(string? INACHHKJCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F491E0", Offset = "0x6F479E0", VA = "0x186F491E0")]
	public static string? CFAEGCHDMKK(string? NMJFGLOIAMF)
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
