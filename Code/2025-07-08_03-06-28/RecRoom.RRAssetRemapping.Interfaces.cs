using System;
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89AD4A0", Offset = "0x89AC2A0", VA = "0x1889AD4A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBFMNELNLKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NEJFHFKCOKJ(EMIPHPEOPMO PADDIEKMDDH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EMIPHPEOPMO KIDJPDKJMHF(string PADDIEKMDDH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct EMIPHPEOPMO : IEquatable<EMIPHPEOPMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly NANMHMIBICI BOOAIGDDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MKELHNOGKHJ PKIFDDOIJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid BEKGCCGIBNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NBLFLOHKFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89AC130", Offset = "0x89AAF30", VA = "0x1889AC130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DKLEJAHPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89AC280", Offset = "0x89AB080", VA = "0x1889AC280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x89AC5C0", Offset = "0x89AB3C0", VA = "0x1889AC5C0")]
	public EMIPHPEOPMO(EMIPHPEOPMO OFGKLBPPIAF, [Optional] Guid AIGIABENOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB7F0", Offset = "0x5FBA5F0", VA = "0x185FBB7F0")]
	public EMIPHPEOPMO(NANMHMIBICI DIHALJHDCND, MKELHNOGKHJ OPEEECOHEMN, [Optional] Guid AIGIABENOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x89AC070", Offset = "0x89AAE70", VA = "0x1889AC070", Slot = "4")]
	public bool Equals(EMIPHPEOPMO LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x89ABFC0", Offset = "0x89AADC0", VA = "0x1889ABFC0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89AC1C0", Offset = "0x89AAFC0", VA = "0x1889AC1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89AC250", Offset = "0x89AB050", VA = "0x1889AC250")]
	public static bool HAHIHKOBLPE(EMIPHPEOPMO EIECDDIBOHA, EMIPHPEOPMO AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x89AC2B0", Offset = "0x89AB0B0", VA = "0x1889AC2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NANMHMIBICI : IEquatable<NANMHMIBICI>, IComparable<NANMHMIBICI>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly NANMHMIBICI MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public NANMHMIBICI(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(NANMHMIBICI LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(NANMHMIBICI LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x89AD260", Offset = "0x89AC060", VA = "0x1889AD260", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290")]
	public static bool HAHIHKOBLPE(NANMHMIBICI EIECDDIBOHA, NANMHMIBICI AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89ABCE0", Offset = "0x89AAAE0", VA = "0x1889ABCE0")]
	public static bool KKINNKAIEFB(NANMHMIBICI EIECDDIBOHA, NANMHMIBICI AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x89AD310", Offset = "0x89AC110", VA = "0x1889AD310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NCJALFIEICP : IEquatable<NCJALFIEICP>, IComparable<NCJALFIEICP>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly NCJALFIEICP MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public NCJALFIEICP(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(NCJALFIEICP LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(NCJALFIEICP LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x89AD380", Offset = "0x89AC180", VA = "0x1889AD380", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290")]
	public static bool HAHIHKOBLPE(NCJALFIEICP EIECDDIBOHA, NCJALFIEICP AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x89ABCE0", Offset = "0x89AAAE0", VA = "0x1889ABCE0")]
	public static bool KKINNKAIEFB(NCJALFIEICP EIECDDIBOHA, NCJALFIEICP AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x89AD430", Offset = "0x89AC230", VA = "0x1889AD430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DFHCMGJACBB : IEquatable<DFHCMGJACBB>, IComparable<DFHCMGJACBB>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly DFHCMGJACBB MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public DFHCMGJACBB(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(DFHCMGJACBB LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(DFHCMGJACBB LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89ABEA0", Offset = "0x89AACA0", VA = "0x1889ABEA0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290")]
	public static bool HAHIHKOBLPE(DFHCMGJACBB EIECDDIBOHA, DFHCMGJACBB AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x89ABCE0", Offset = "0x89AAAE0", VA = "0x1889ABCE0")]
	public static bool KKINNKAIEFB(DFHCMGJACBB EIECDDIBOHA, DFHCMGJACBB AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x89ABF50", Offset = "0x89AAD50", VA = "0x1889ABF50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MKELHNOGKHJ : IEquatable<MKELHNOGKHJ>, IComparable<MKELHNOGKHJ>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly MKELHNOGKHJ MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public MKELHNOGKHJ(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x89AD0E0", Offset = "0x89ABEE0", VA = "0x1889AD0E0", Slot = "4")]
	public bool Equals(MKELHNOGKHJ LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89AD110", Offset = "0x89ABF10", VA = "0x1889AD110", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89AD0E0", Offset = "0x89ABEE0", VA = "0x1889AD0E0")]
	public static bool HAHIHKOBLPE(MKELHNOGKHJ EIECDDIBOHA, MKELHNOGKHJ AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x89AD1C0", Offset = "0x89ABFC0", VA = "0x1889AD1C0")]
	public static bool KKINNKAIEFB(MKELHNOGKHJ EIECDDIBOHA, MKELHNOGKHJ AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(MKELHNOGKHJ LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x89AD1F0", Offset = "0x89ABFF0", VA = "0x1889AD1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public MKELHNOGKHJ(PEMMIEJACOP ODADEEAHHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DDGGJNDBLEG : IEquatable<DDGGJNDBLEG>, IComparable<DDGGJNDBLEG>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly DDGGJNDBLEG MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public DDGGJNDBLEG(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(DDGGJNDBLEG LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(DDGGJNDBLEG LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x89ABD80", Offset = "0x89AAB80", VA = "0x1889ABD80", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290")]
	public static bool HAHIHKOBLPE(DDGGJNDBLEG EIECDDIBOHA, DDGGJNDBLEG AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x89ABCE0", Offset = "0x89AAAE0", VA = "0x1889ABCE0")]
	public static bool KKINNKAIEFB(DDGGJNDBLEG EIECDDIBOHA, DDGGJNDBLEG AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x89ABE30", Offset = "0x89AAC30", VA = "0x1889ABE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JPHJMMINMCH : IEquatable<JPHJMMINMCH>, IComparable<JPHJMMINMCH>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly JPHJMMINMCH MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public JPHJMMINMCH(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(JPHJMMINMCH LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(JPHJMMINMCH LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x89ACFC0", Offset = "0x89ABDC0", VA = "0x1889ACFC0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290")]
	public static bool HAHIHKOBLPE(JPHJMMINMCH EIECDDIBOHA, JPHJMMINMCH AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x89ABCE0", Offset = "0x89AAAE0", VA = "0x1889ABCE0")]
	public static bool KKINNKAIEFB(JPHJMMINMCH EIECDDIBOHA, JPHJMMINMCH AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89AD070", Offset = "0x89ABE70", VA = "0x1889AD070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BMCGFMAECEA : IEquatable<BMCGFMAECEA>, IComparable<BMCGFMAECEA>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BMCGFMAECEA MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public BMCGFMAECEA(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(BMCGFMAECEA LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(BMCGFMAECEA LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89ABC30", Offset = "0x89AAA30", VA = "0x1889ABC30", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290")]
	public static bool HAHIHKOBLPE(BMCGFMAECEA EIECDDIBOHA, BMCGFMAECEA AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x89ABCE0", Offset = "0x89AAAE0", VA = "0x1889ABCE0")]
	public static bool KKINNKAIEFB(BMCGFMAECEA EIECDDIBOHA, BMCGFMAECEA AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x89ABD10", Offset = "0x89AAB10", VA = "0x1889ABD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct FNALMPKNBLO : IEquatable<FNALMPKNBLO>, IComparable<FNALMPKNBLO>, BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly FNALMPKNBLO MMHNBCKELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public FNALMPKNBLO(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(FNALMPKNBLO LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(FNALMPKNBLO LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x89AC5E0", Offset = "0x89AB3E0", VA = "0x1889AC5E0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290")]
	public static bool HAHIHKOBLPE(FNALMPKNBLO EIECDDIBOHA, FNALMPKNBLO AFKLBECCDNB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x89ABCE0", Offset = "0x89AAAE0", VA = "0x1889ABCE0")]
	public static bool KKINNKAIEFB(FNALMPKNBLO EIECDDIBOHA, FNALMPKNBLO AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x89AC690", Offset = "0x89AB490", VA = "0x1889AC690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HLNBCOGMHLF : IEquatable<HLNBCOGMHLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? NLEFDHINNBO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NPDDCPKLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x89ACBD0", Offset = "0x89AB9D0", VA = "0x1889ACBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DLLKJPPLAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x53F1FC0", Offset = "0x53F0DC0", VA = "0x1853F1FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x89ACD00", Offset = "0x89ABB00", VA = "0x1889ACD00")]
	public HLNBCOGMHLF(string? KPMDFIINGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89ACC80", Offset = "0x89ABA80", VA = "0x1889ACC80")]
	public HLNBCOGMHLF(string?[] KPLLBODMJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x89AC940", Offset = "0x89AB740", VA = "0x1889AC940")]
	private static string?[]? IOJIEEBNELJ(string?[]? KPLLBODMJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x89ACB70", Offset = "0x89AB970", VA = "0x1889ACB70")]
	public string KFNPKLPFDHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x89AC700", Offset = "0x89AB500", VA = "0x1889AC700", Slot = "4")]
	public bool Equals(HLNBCOGMHLF LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x89AC7D0", Offset = "0x89AB5D0", VA = "0x1889AC7D0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x89AC860", Offset = "0x89AB660", VA = "0x1889AC860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89ACBF0", Offset = "0x89AB9F0", VA = "0x1889ACBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PEMMIEJACOP : IEquatable<PEMMIEJACOP>, IComparable<PEMMIEJACOP>, BNCNHCPLOHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid OKDHAOKOGCM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public PEMMIEJACOP(Guid OKDHAOKOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public Guid MBFEDJCNAOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x548A290", Offset = "0x5489090", VA = "0x18548A290", Slot = "4")]
	public bool Equals(PEMMIEJACOP LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5489E90", Offset = "0x5488C90", VA = "0x185489E90", Slot = "5")]
	public int CompareTo(PEMMIEJACOP LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x89AD520", Offset = "0x89AC320", VA = "0x1889AD520", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5489FB0", Offset = "0x5488DB0", VA = "0x185489FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x89AD5D0", Offset = "0x89AC3D0", VA = "0x1889AD5D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EOHMEIJACBP<TModern> : BGIGEAGFJEE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DGDKBCIHJOK(TModern CGCOHKMABKH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BNCNHCPLOHA
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid MBFEDJCNAOE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BGIGEAGFJEE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern CHIKCACDNGN(string CGCOHKMABKH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PLELJALJHKF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EOHMEIJACBP<NANMHMIBICI> ILDMHHCICMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	EOHMEIJACBP<DDGGJNDBLEG> FHEHCHKNIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EOHMEIJACBP<FNALMPKNBLO> IMOFLPMGLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EOHMEIJACBP<MKELHNOGKHJ> HHFDHCKFEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EOHMEIJACBP<DFHCMGJACBB> POBLMEEPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EOHMEIJACBP<BMCGFMAECEA> CFFFCEEOIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EOHMEIJACBP<NCJALFIEICP> JLMMHIAKHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EOHMEIJACBP<JPHJMMINMCH> HAMCINAFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IMICOEGIMIC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] ILCMCGGJADE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x89ACE80", Offset = "0x89ABC80", VA = "0x1889ACE80")]
	public static string[] JLKIHJOHPOG(string? KPMDFIINGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x89ACE50", Offset = "0x89ABC50", VA = "0x1889ACE50")]
	public static string? HBPPDHEJJMJ(string? DIHALJHDCND)
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
