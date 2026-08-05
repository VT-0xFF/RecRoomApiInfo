using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6210240", Offset = "0x620F440", VA = "0x186210240")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LCACNONGNHO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LJAPKFBJAGO NINDFLPFGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IJBOACAGBBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IEBBOEOKENJ(Entity CHIBHEBBKEE, object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DIFBPBADBJK(Entity CHIBHEBBKEE, object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JJGHMJPEHLE(Entity CHIBHEBBKEE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMJCCMLKBKN(Entity CHIBHEBBKEE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EJAMJIBIPEH<TComponentData, TValue> : IOHPLIPMHNG<TValue>, IDisposable where TComponentData : struct, LCACNONGNHO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class NBPAGOKJLCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> MJCNKJMKHLD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int MNPNLHNEGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x30E4440", Offset = "0x30E3640", VA = "0x1830E4440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDED0", Offset = "0x3EFD0D0", VA = "0x183EFDED0")]
		public bool BCLBJBJAGFG([Out] TValue AFCGKMGKPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE0A0", Offset = "0x3EFD2A0", VA = "0x183EFE0A0")]
		public void OJOKKDMOJFN(object COAGHPOILPB, TValue AFCGKMGKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE150", Offset = "0x3EFD350", VA = "0x183EFE150")]
		public bool PADFOOPDKDB(object COAGHPOILPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDFC0", Offset = "0x3EFD1C0", VA = "0x183EFDFC0")]
		public int MEECADPLCEN(object COAGHPOILPB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE1D0", Offset = "0x3EFD3D0", VA = "0x183EFE1D0")]
		public NBPAGOKJLCE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<NBPAGOKJLCE> MGFCHCDDPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NJJLEALGKIB<LJAPKFBJAGO, NBPAGOKJLCE> CIPDEFMJFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager IACEDLKPNGM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x32BDED0", Offset = "0x32BD0D0", VA = "0x1832BDED0")]
	public EJAMJIBIPEH(EntityManager IACEDLKPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x32BDC80", Offset = "0x32BCE80", VA = "0x1832BDC80", Slot = "4")]
	public void IEBBOEOKENJ(Entity CHIBHEBBKEE, object COAGHPOILPB, TValue AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x32BD880", Offset = "0x32BCA80", VA = "0x1832BD880", Slot = "5")]
	public bool DIFBPBADBJK(Entity CHIBHEBBKEE, object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x32BD780", Offset = "0x32BC980", VA = "0x1832BD780", Slot = "6")]
	public bool BCLBJBJAGFG(Entity CHIBHEBBKEE, [Out] TValue AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32BDA20", Offset = "0x32BCC20", VA = "0x1832BDA20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32BDB00", Offset = "0x32BCD00", VA = "0x1832BDB00")]
	private void ENCECJOLHDH(NBPAGOKJLCE AMKJEILNCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x32BDA40", Offset = "0x32BCC40", VA = "0x1832BDA40")]
	private bool EMMNEKLEKFO(Entity CHIBHEBBKEE, [Out] LJAPKFBJAGO HGKLAMFJANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32BDB90", Offset = "0x32BCD90", VA = "0x1832BDB90")]
	private void HACGLKDDCNH(Entity CHIBHEBBKEE, LJAPKFBJAGO HGKLAMFJANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x32BDDC0", Offset = "0x32BCFC0", VA = "0x1832BDDC0")]
	private bool OCIABIJCDNE(LJAPKFBJAGO HGKLAMFJANK, [Out] NBPAGOKJLCE AMKJEILNCPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x32BDDE0", Offset = "0x32BCFE0", VA = "0x1832BDDE0")]
	private NBPAGOKJLCE PIJJINLFIHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IOHPLIPMHNG<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEBBOEOKENJ(Entity CHIBHEBBKEE, object COAGHPOILPB, TValue AFCGKMGKPEF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DIFBPBADBJK(Entity CHIBHEBBKEE, object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCLBJBJAGFG(Entity CHIBHEBBKEE, [Out] TValue AFCGKMGKPEF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LJAPKFBJAGO : EOHGEMCIKJO, IEquatable<LJAPKFBJAGO>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly LJAPKFBJAGO FJJHIFEPCCP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int ANPNOFMCDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x912370", Offset = "0x911570", VA = "0x180912370", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int DFFLBILJIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2262750", Offset = "0x2261950", VA = "0x182262750", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x559D3B0", Offset = "0x559C5B0", VA = "0x18559D3B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6210840", Offset = "0x620FA40", VA = "0x186210840", Slot = "8")]
	public bool Equals(LJAPKFBJAGO NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6210890", Offset = "0x620FA90", VA = "0x186210890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HCFDAMJEEEG<THasTokensTag> : IJBOACAGBBF, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly DNCJPFEBFGD COBKBPPCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, LJAPKFBJAGO> LAADFMFIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> MGFCHCDDPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private NJJLEALGKIB<LJAPKFBJAGO, HashSet<object>> CIPDEFMJFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager IACEDLKPNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem LDCEKCECPJD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37947A0", Offset = "0x37939A0", VA = "0x1837947A0")]
	public HCFDAMJEEEG(EntityManager IACEDLKPNGM, EntityCommandBufferSystem LDCEKCECPJD, DNCJPFEBFGD FHPCHECHBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3792EB0", Offset = "0x37920B0", VA = "0x183792EB0", Slot = "4")]
	public bool IEBBOEOKENJ(Entity CHIBHEBBKEE, object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3791380", Offset = "0x3790580", VA = "0x183791380", Slot = "5")]
	public bool DIFBPBADBJK(Entity CHIBHEBBKEE, object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37936E0", Offset = "0x37928E0", VA = "0x1837936E0", Slot = "6")]
	public bool JJGHMJPEHLE(Entity CHIBHEBBKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3793A30", Offset = "0x3792C30", VA = "0x183793A30", Slot = "9")]
	public bool JJGHMJPEHLE(LJAPKFBJAGO HGKLAMFJANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3791860", Offset = "0x3790A60", VA = "0x183791860", Slot = "7")]
	public bool DMJCCMLKBKN(Entity CHIBHEBBKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3791B60", Offset = "0x3790D60", VA = "0x183791B60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3792270", Offset = "0x3791470", VA = "0x183792270")]
	private void ENCECJOLHDH(HashSet<object> AMKJEILNCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3791FE0", Offset = "0x37911E0", VA = "0x183791FE0")]
	private bool EMMNEKLEKFO(Entity CHIBHEBBKEE, [Out] LJAPKFBJAGO HGKLAMFJANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3794180", Offset = "0x3793380", VA = "0x183794180")]
	private bool OCPDOFFGLAP(Entity CHIBHEBBKEE, [Out] LJAPKFBJAGO HGKLAMFJANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3793190", Offset = "0x3792390", VA = "0x183793190")]
	private void ILCOCNMHNMH(Entity CHIBHEBBKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3792510", Offset = "0x3791710", VA = "0x183792510")]
	private void HFAKCCBFHEE(Entity CHIBHEBBKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3793D40", Offset = "0x3792F40", VA = "0x183793D40")]
	private void MPDNHHKLCEJ(Entity CHIBHEBBKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x37924A0", Offset = "0x37916A0", VA = "0x1837924A0")]
	private void HACGLKDDCNH(Entity CHIBHEBBKEE, LJAPKFBJAGO HGKLAMFJANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3793C60", Offset = "0x3792E60", VA = "0x183793C60")]
	private bool KFFLELJIFIH(LJAPKFBJAGO HGKLAMFJANK, [Out] HashSet<object> AMKJEILNCPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37944E0", Offset = "0x37936E0", VA = "0x1837944E0")]
	private HashSet<object> PIJJINLFIHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AOBACNFIBIN
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NOPLDIMKCKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int GNHLLBKBLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int BNPJLEJJKIB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DAFNKFGPHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x912370", Offset = "0x911570", VA = "0x180912370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2262750", Offset = "0x2261950", VA = "0x182262750")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x559D3B0", Offset = "0x559C5B0", VA = "0x18559D3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PJCBAOPNHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x912370", Offset = "0x911570", VA = "0x180912370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HIGLEHLPIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6210DE0", Offset = "0x620FFE0", VA = "0x186210DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6210DF0", Offset = "0x620FFF0", VA = "0x186210DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAF2C30", Offset = "0xAF1E30", VA = "0x180AF2C30")]
	private NOPLDIMKCKF(int GNHLLBKBLJF, int BNPJLEJJKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD4A0", Offset = "0x1DDC6A0", VA = "0x181DDD4A0")]
	public static NOPLDIMKCKF HJKMILCDJKD(int GNHLLBKBLJF, int BNPJLEJJKIB)
	{
		return default(NOPLDIMKCKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6210E00", Offset = "0x6210000", VA = "0x186210E00")]
	public static NOPLDIMKCKF KPOBOHEFGIN(int LIFMPBNCBOL, int NIANJOAGOAA)
	{
		return default(NOPLDIMKCKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6210E10", Offset = "0x6210010", VA = "0x186210E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FNJJIMDIKDK : ODLNMENBGJE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62102F0", Offset = "0x620F4F0", VA = "0x1862102F0")]
	public float KKOPGIPNECA([In] float3 AFCGKMGKPEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62102F0", Offset = "0x620F4F0", VA = "0x1862102F0", Slot = "4")]
	private float FPGPIHJCDOG([In] float3 AFCGKMGKPEF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NMOKAFKMFNH : ODLNMENBGJE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6210DD0", Offset = "0x620FFD0", VA = "0x186210DD0")]
	public float KKOPGIPNECA([In] float3 AFCGKMGKPEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6210DD0", Offset = "0x620FFD0", VA = "0x186210DD0", Slot = "4")]
	private float FPGPIHJCDOG([In] float3 AFCGKMGKPEF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KFNHEFHBCLM : ODLNMENBGJE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1AA47A0", Offset = "0x1AA39A0", VA = "0x181AA47A0")]
	public float KKOPGIPNECA([In] float3 AFCGKMGKPEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1AA47A0", Offset = "0x1AA39A0", VA = "0x181AA47A0", Slot = "4")]
	private float FPGPIHJCDOG([In] float3 AFCGKMGKPEF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NHHKAEHFPPH : ODLNMENBGJE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x13C39A0", Offset = "0x13C2BA0", VA = "0x1813C39A0")]
	public int KKOPGIPNECA([In] int3 AFCGKMGKPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x13C39A0", Offset = "0x13C2BA0", VA = "0x1813C39A0", Slot = "4")]
	private int PJLMJMAHHPI([In] int3 AFCGKMGKPEF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DNDCEJHABJG : ODLNMENBGJE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6210130", Offset = "0x620F330", VA = "0x186210130")]
	public int KKOPGIPNECA([In] int3 AFCGKMGKPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6210130", Offset = "0x620F330", VA = "0x186210130", Slot = "4")]
	private int PJLMJMAHHPI([In] int3 AFCGKMGKPEF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EFHLPFLJHGE : ODLNMENBGJE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16A4160", Offset = "0x16A3360", VA = "0x1816A4160")]
	public int KKOPGIPNECA([In] int3 AFCGKMGKPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16A4160", Offset = "0x16A3360", VA = "0x1816A4160", Slot = "4")]
	private int PJLMJMAHHPI([In] int3 AFCGKMGKPEF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MGFGIKGMFPJ : NBPFAHNIHDK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA300", VA = "0x1807CB100")]
	public MGFGIKGMFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class EIACKKIOKGL : SystemBase, IMCGGLPMDGD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6210160", Offset = "0x620F360", VA = "0x186210160")]
	public ComponentDataFromEntity ONOPMILMDLC(int EJONFLPPENB, bool PECDMDHLKKN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6210140", Offset = "0x620F340", VA = "0x186210140")]
	public EntityExistenceLookupByEntity HKFJKENEIMA()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6210220", Offset = "0x620F420", VA = "0x186210220", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA300", VA = "0x1807CB100")]
	protected EIACKKIOKGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class KEIMHGDAEEC : EIACKKIOKGL
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6210770", Offset = "0x620F970", VA = "0x186210770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA300", VA = "0x1807CB100")]
	protected KEIMHGDAEEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AMIKLHGGMAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class HGOGBCMNMEC : EntityCommandBufferSystem, IMCGGLPMDGD
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA300", VA = "0x1807CB100")]
	protected HGOGBCMNMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ODLNMENBGJE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo KKOPGIPNECA([In] TFrom AFCGKMGKPEF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KGMCFCPJBNO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DCEHMKBDHKG(T AFCGKMGKPEF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct MFHEAKJHGKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	public NativeArray<Entity> FLOMCKBKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EntityCommandBuffer INKNNPCCEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ComponentTypes LJEHJEHOAAB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62109E0", Offset = "0x620FBE0", VA = "0x1862109E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct KNKBHJBIEGE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> FLOMCKBKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer INKNNPCCEHM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x62107A0", Offset = "0x620F9A0", VA = "0x1862107A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct ALNGIDBCKBL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> FLOMCKBKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer INKNNPCCEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public ComponentType EFNIDODHGIB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x620FE60", Offset = "0x620F060", VA = "0x18620FE60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct OHKONKLHMKB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<Entity> FLOMCKBKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<T> GKNJGNIHLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer INKNNPCCEHM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40699F0", Offset = "0x4068BF0", VA = "0x1840699F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct JDBKJJCELNI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<Entity> FLOMCKBKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<T> OJPPDIEMMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer INKNNPCCEHM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct DJMFLPLBIGG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> FLOMCKBKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public T AFCGKMGKPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EntityCommandBuffer INKNNPCCEHM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x507CB10", Offset = "0x507BD10", VA = "0x18507CB10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct IFPCFNOGPDF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ODLNMENBGJE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<TFrom> BHDLNBCPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[WriteOnly]
	public NativeArray<TTo> FAINMOBDHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TMap CEBHNDLCHED;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct MAPMNMFCHGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public ComponentDataFromEntity CLOODGPKALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<Entity> BHDLNBCPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeArray<byte> FAINMOBDHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int OFBMGCKPOFE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62108E0", Offset = "0x620FAE0", VA = "0x1862108E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct NAGGLMLKAMI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EIOHNIFBNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<Entity> BHDLNBCPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<T> LDDIMHKJDIP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct GKMMKPEOLHD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ODLNMENBGJE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<TFrom> GNJNCBBFKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<TTo> FAINMOBDHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TMap CEBHNDLCHED;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LPBKIHKIBJF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JGJMGONPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public NativeArray<Entity> NONEHPHMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<bool> HFHPLDDBMGC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct MBOKHKMLJNH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JGJMGONPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> NONEHPHMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<bool> HFHPLDDBMGC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3E6A6C0", Offset = "0x3E698C0", VA = "0x183E6A6C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct KGOIJKHPJAP<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<T> BHDLNBCPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeList<T> LDDIMHKJDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeParallelHashSet<T> HLLDMELOFJO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B61BF0", Offset = "0x3B60DF0", VA = "0x183B61BF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct IIIPOGCCOML<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : ODLNMENBGJE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public NativeArray<TFrom> BHDLNBCPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeList<TFrom> LDDIMHKJDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeParallelHashSet<TTo> HLLDMELOFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap CEBHNDLCHED;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JALEHNLOJJK<T, TPredicate> : IJob where T : struct where TPredicate : struct, KGMCFCPJBNO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<T> BHDLNBCPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> LLPJNHNBKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeList<Entity> GEIBGNGHAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TPredicate CEBHNDLCHED;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3A5EF40", Offset = "0x3A5E140", VA = "0x183A5EF40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct HKOGFFKJGND<T, TPredicate> : IJob where T : struct where TPredicate : struct, KGMCFCPJBNO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<T> BHDLNBCPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeList<T> LDDIMHKJDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public TPredicate CEBHNDLCHED;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct BAPKLKHIACB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public ComponentDataFromEntity JGJMGONPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> NONEHPHMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NativeList<Entity> OKLKMKDMFCH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x620FEE0", Offset = "0x620F0E0", VA = "0x18620FEE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct FLHECMOKEPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public ComponentDataFromEntity JGJMGONPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public NativeArray<Entity> NONEHPHMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<Entity> OKLKMKDMFCH;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6210260", Offset = "0x620F460", VA = "0x186210260", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EGDEACOOLDN
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OIMLGPJBOJD
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28D2370", Offset = "0x28D1570", VA = "0x1828D2370")]
	public static bool DAPJPCGJDCP<T>(this NativeArray<Entity> NONEHPHMNAN, EntityManager IACEDLKPNGM, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BKCIMMNBLAP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BAAKAIKLOIB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		public BAAKAIKLOIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DPPODHMMGLB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		public DPPODHMMGLB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<Func<JobHandle, JobHandle>> GGHFDFJEAJF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x620FF70", Offset = "0x620F170", VA = "0x18620FF70")]
	public BKCIMMNBLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OMDMDNPIGNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EONJFPKPLJK
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct PPPDNHDKAFM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct LAJGOGCKHIA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			internal PPPDNHDKAFM<TFrom> DMKJLMNBOME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal NativeArray<TFrom> HJFOOBIEOKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct IJCDJEFGLIJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct OLMEEBIFJLA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			internal IJCDJEFGLIJ<TFrom> DMKJLMNBOME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal NativeList<TFrom> HJFOOBIEOKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct PGKBIIEFIGJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct KEPFCLCPCHE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal PGKBIIEFIGJ<TFrom> DMKJLMNBOME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NativeArrayAsync<TFrom> HJFOOBIEOKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct HJMGPBBIGEF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct JIBCOLKICFC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal HJMGPBBIGEF<TFrom> DMKJLMNBOME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeListAsync<TFrom> HJFOOBIEOKH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GBONKKJCHGL
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FAPBGLLCFBP
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2745340", Offset = "0x2744540", VA = "0x182745340")]
	public static NativeList<T> KHIDMLPGPCE<T>(this NativeList<T> PDEKNMBIEDN, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27451C0", Offset = "0x27443C0", VA = "0x1827451C0")]
	public static NativeList<T> KHIDMLPGPCE<T>(this NativeArray<T> PDEKNMBIEDN, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class MCCEJIKJBOD
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MIOMPPACGFC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28511A0", Offset = "0x28503A0", VA = "0x1828511A0")]
	[PGBJFNODAPG]
	public static JobHandle CFIMHALFOFL<T>(this EntityCommandBufferSystem LDCEKCECPJD, NativeArrayAsync<Entity> FLOMCKBKBJO, NativeArrayAsync<T> GKNJGNIHLDH, [Optional] JobHandle LGDAECPMAAC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2851420", Offset = "0x2850620", VA = "0x182851420")]
	[PGBJFNODAPG]
	public static JobHandle CFIMHALFOFL<T>(this EntityCommandBufferSystem LDCEKCECPJD, NativeArrayAsync<Entity> FLOMCKBKBJO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2851300", Offset = "0x2850500", VA = "0x182851300")]
	[PGBJFNODAPG]
	public static JobHandle CFIMHALFOFL<T>(this EntityCommandBufferSystem LDCEKCECPJD, NativeArray<Entity> FLOMCKBKBJO, [Optional] JobHandle LGDAECPMAAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6210C20", Offset = "0x620FE20", VA = "0x186210C20")]
	[PGBJFNODAPG]
	public static JobHandle CFIMHALFOFL(this EntityCommandBufferSystem LDCEKCECPJD, NativeArray<Entity> FLOMCKBKBJO, ComponentTypes LJEHJEHOAAB, [Optional] JobHandle LGDAECPMAAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6210AD0", Offset = "0x620FCD0", VA = "0x186210AD0")]
	[PGBJFNODAPG]
	public static JobHandle CFIMHALFOFL(this EntityCommandBufferSystem LDCEKCECPJD, EntityCommandBuffer INKNNPCCEHM, NativeArray<Entity> FLOMCKBKBJO, ComponentTypes LJEHJEHOAAB, [Optional] JobHandle LGDAECPMAAC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OGADNCKKHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28CF990", Offset = "0x28CEB90", VA = "0x1828CF990")]
	[PGBJFNODAPG]
	public static JobHandle LIJCALHJBNH<T>(this EntityCommandBufferSystem LDCEKCECPJD, EntityCommandBuffer INKNNPCCEHM, EntityQuery NMIFAMICDJN, T AFCGKMGKPEF) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JJFKOOOGHGG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62105E0", Offset = "0x620F7E0", VA = "0x1862105E0")]
	[PGBJFNODAPG]
	public static JobHandle CPFJLOBJPPA(this EntityCommandBufferSystem LDCEKCECPJD, NativeList<Entity> FLOMCKBKBJO, [Optional] JobHandle LGDAECPMAAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62104E0", Offset = "0x620F6E0", VA = "0x1862104E0")]
	[PGBJFNODAPG]
	public static JobHandle CPFJLOBJPPA(this EntityCommandBufferSystem LDCEKCECPJD, NativeArrayAsync<Entity> FLOMCKBKBJO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FCPLOHHEMKD
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2745B50", Offset = "0x2744D50", VA = "0x182745B50")]
	public static void MGKBFGMKMKH<T>(this EntityCommandBufferSystem LDCEKCECPJD, EntityQuery NMIFAMICDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27457F0", Offset = "0x27449F0", VA = "0x1827457F0")]
	[PGBJFNODAPG]
	public static JobHandle JAFOFAOBGFO<T>(this EntityCommandBufferSystem LDCEKCECPJD, NativeListAsync<Entity> FLOMCKBKBJO, [Optional] JobHandle LGDAECPMAAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27458B0", Offset = "0x2744AB0", VA = "0x1827458B0")]
	[PGBJFNODAPG]
	public static JobHandle JAFOFAOBGFO<T>(this EntityCommandBufferSystem LDCEKCECPJD, NativeArrayAsync<Entity> FLOMCKBKBJO, [Optional] JobHandle LGDAECPMAAC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KBEMKAONBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2807130", Offset = "0x2806330", VA = "0x182807130")]
	[PGBJFNODAPG]
	public static JobHandle DNGEHEEMEHK<T>(this EntityCommandBufferSystem LDCEKCECPJD, NativeArray<Entity> FLOMCKBKBJO, NativeArray<T> GKNJGNIHLDH, JobHandle LGDAECPMAAC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FPNCDKJGKGF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x274EF00", Offset = "0x274E100", VA = "0x18274EF00")]
	[PGBJFNODAPG]
	public static JobHandle LJDGNCIGGGM<T>(this EntityCommandBufferSystem LDCEKCECPJD, NativeArray<Entity> FLOMCKBKBJO, T AFCGKMGKPEF, [Optional] JobHandle LGDAECPMAAC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x274EFE0", Offset = "0x274E1E0", VA = "0x18274EFE0")]
	[PGBJFNODAPG]
	public static JobHandle LJDGNCIGGGM<T>(this EntityCommandBufferSystem LDCEKCECPJD, EntityCommandBuffer INKNNPCCEHM, NativeArray<Entity> FLOMCKBKBJO, T AFCGKMGKPEF, [Optional] JobHandle LGDAECPMAAC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class MEJFCLLEAFE
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x284A980", Offset = "0x2849B80", VA = "0x18284A980")]
	public static NativeList<T> KHIDMLPGPCE<T>(NativeList<T> PDEKNMBIEDN, Allocator ECEHKFLCCDN) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HFFPCDECNGM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x279B5C0", Offset = "0x279A7C0", VA = "0x18279B5C0")]
	public static NativeArray<T> JHEGACKBMIK<T>(this NativeList<Entity> PDEKNMBIEDN, EntityManager IACEDLKPNGM, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x279B080", Offset = "0x279A280", VA = "0x18279B080")]
	public static NativeArray<T> JHEGACKBMIK<T>(this NativeArray<Entity> PDEKNMBIEDN, EntityManager IACEDLKPNGM, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6210300", Offset = "0x620F500", VA = "0x186210300")]
	public static NativeArray<Entity> FEJDKECDFLA(this NativeArray<Entity> PDEKNMBIEDN, EntityManager IACEDLKPNGM, ComponentType EFNIDODHGIB, Allocator ECEHKFLCCDN = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x279AFA0", Offset = "0x279A1A0", VA = "0x18279AFA0")]
	public static NativeArray<T> FIGLJCEBBGB<T>(this NativeArray<Entity> PDEKNMBIEDN, EntityManager IACEDLKPNGM, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PHBPGCHOFHA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct AOIPADDPNBA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct MDCGKOLHAGB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public AOIPADDPNBA<TFrom> HJFOOBIEOKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<TFrom> BHDLNBCPICM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct CKOFGHODCMD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct IHIDBJCEMGE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CKOFGHODCMD<TFrom> HJFOOBIEOKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeArrayAsync<TFrom> BHDLNBCPICM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct CHCOCENJILD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct GMDNMCCIEDG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public CHCOCENJILD<TFrom> HJFOOBIEOKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeListAsync<TFrom> BHDLNBCPICM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HNNENOOLHIE
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GNBFEIJMPCK
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct EOEOKALPINB : ODLNMENBGJE<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> JPLNEGMJOPG;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6210230", Offset = "0x620F430", VA = "0x186210230")]
		[BurstCompatible]
		public Entity KKOPGIPNECA([In] Entity AFCGKMGKPEF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6210230", Offset = "0x620F430", VA = "0x186210230", Slot = "4")]
		private Entity EMHDFOPDDNB([In] Entity AFCGKMGKPEF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class DIMEEPEHBDI
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct JOMCEMMMPED<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<Entity> LLPJNHNBKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<T> BHDLNBCPICM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct KBODPOBIIAP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<Entity> LLPJNHNBKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<T> BHDLNBCPICM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LJELEOAFGCA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<Entity> LLPJNHNBKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArrayAsync<T> BHDLNBCPICM;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x26AB840", Offset = "0x26AAA40", VA = "0x1826AB840")]
		public NativeListAsync<Entity> DCEHMKBDHKG<TPredicate>() where TPredicate : struct, KGMCFCPJBNO<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26180F0", Offset = "0x26172F0", VA = "0x1826180F0")]
	public static LJELEOAFGCA<T> JPAFBBDJNGJ<T>(this NativeArrayAsync<Entity> NONEHPHMNAN, NativeArrayAsync<T> PDEKNMBIEDN, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct
	{
		return default(LJELEOAFGCA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class NIDOGNOMJND
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x28A9CA0", Offset = "0x28A8EA0", VA = "0x1828A9CA0")]
	public static NativeListAsync<Entity> KICHLKMNALP<T, TPredicate>(this NativeArrayAsync<T> PDEKNMBIEDN, NativeArrayAsync<Entity> NONEHPHMNAN, Allocator ECEHKFLCCDN = Allocator.TempJob) where T : struct where TPredicate : struct, KGMCFCPJBNO<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x28A9D60", Offset = "0x28A8F60", VA = "0x1828A9D60")]
	private static NativeListAsync<Entity> OJBBOHFBODA<T, TPredicate>(NativeArrayAsync<T> KKGJMPLFPJG, NativeArrayAsync<Entity> NONEHPHMNAN, int NCLKCGHBFFI, Allocator ECEHKFLCCDN) where T : struct where TPredicate : struct, KGMCFCPJBNO<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class EICIOHBDDFH
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct OHMDIGHEJFO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<T> BHDLNBCPICM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct JBBINBHHLKF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<T> BHDLNBCPICM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct FDADDBCKAEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArrayAsync<T> BHDLNBCPICM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct NIEGLIFLPJJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator ECEHKFLCCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeListAsync<T> BHDLNBCPICM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class JBMIILNPJDM
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class AKGMBMEPLFF
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2D55F20", Offset = "0x2D55120", VA = "0x182D55F20")]
	public static NativeList<Entity> LPHDFDPENAJ<T>(this NativeArray<Entity> NONEHPHMNAN, EntityManager IACEDLKPNGM, Allocator ECEHKFLCCDN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NDBPPFABPDA
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MOCEGFBPNPO
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct EAONADEFAOF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> NPPGGGEFJIJ;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
		public EAONADEFAOF(NativeArray<TSrc> NPPGGGEFJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0")]
		public EOIMGKOHAJC<TSrc, TValue> AJPPPMNBEPD<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(EOIMGKOHAJC<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct EOIMGKOHAJC<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> NPPGGGEFJIJ;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
		public EOIMGKOHAJC(NativeArray<TSrc> NPPGGGEFJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0")]
		public BHBFMKLHECE<TSrc, TValue, TSelector> KAGDJOHODFC<TSelector>() where TSelector : struct, ODLNMENBGJE<TSrc, TValue>
		{
			return default(BHBFMKLHECE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public readonly struct BHBFMKLHECE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ODLNMENBGJE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> NPPGGGEFJIJ;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
		public BHBFMKLHECE(NativeArray<TSrc> NPPGGGEFJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x47984B0", Offset = "0x47976B0", VA = "0x1847984B0")]
		public NAIKMFDICBB<TSrc, TValue, TSelector> LKJDEFCFOCC()
		{
			return default(NAIKMFDICBB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MKLIAMNPOMH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, ODLNMENBGJE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> NPPGGGEFJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TSelector GLDMFJEGHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int ILNNGHKJMBD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3E7B490", Offset = "0x3E7A690", VA = "0x183E7B490")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int ANPNOFMCDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA53800", VA = "0x180A54600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DOKCLGDELIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DADE80", Offset = "0x1DAD080", VA = "0x181DADE80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B600", Offset = "0x3E7A800", VA = "0x183E7B600")]
		public MKLIAMNPOMH(NativeArray<TSrc> NPPGGGEFJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B480", Offset = "0x3E7A680", VA = "0x183E7B480")]
		public bool BCHEHHFFNDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B520", Offset = "0x3E7A720", VA = "0x183E7B520")]
		private TSrc DPNOEICBLGE(int ABHDANNAKPK)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct NAIKMFDICBB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ODLNMENBGJE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private MKLIAMNPOMH<TSrc, TValue, TSelector> MGBABHDOAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TValue EHMBHODGAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int CMAABPPFEEC;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NOPLDIMKCKF LAHGMMLILPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3EFB870", Offset = "0x3EFAA70", VA = "0x183EFB870")]
			get
			{
				return default(NOPLDIMKCKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue ANIOFDMDDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, NOPLDIMKCKF range) DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3EFB790", Offset = "0x3EFA990", VA = "0x183EFB790")]
			get
			{
				return default((TValue, NOPLDIMKCKF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB8B0", Offset = "0x3EFAAB0", VA = "0x183EFB8B0")]
		public NAIKMFDICBB(NativeArray<TSrc> NPPGGGEFJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x32A9380", Offset = "0x32A8580", VA = "0x1832A9380")]
		public NAIKMFDICBB<TSrc, TValue, TSelector> HPMIKEPMPON()
		{
			return default(NAIKMFDICBB<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB650", Offset = "0x3EFA850", VA = "0x183EFB650")]
		public bool BCHEHHFFNDH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2855250", Offset = "0x2854450", VA = "0x182855250")]
	public static EAONADEFAOF<T> GIBPGLALPHC<T>(this NativeList<T> MJCNKJMKHLD) where T : struct
	{
		return default(EAONADEFAOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0")]
	public static EAONADEFAOF<T> GIBPGLALPHC<T>(this NativeArray<T> NPPGGGEFJIJ) where T : struct
	{
		return default(EAONADEFAOF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class LADECCEGLDD
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PIPONDEKKBI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<T>.ReadOnly NPPGGGEFJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int CMAABPPFEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int MPNJBPCAKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T EHMBHODGAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private T DOGGIEBIOHG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NOPLDIMKCKF LAHGMMLILPK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3C98380", Offset = "0x3C97580", VA = "0x183C98380")]
			get
			{
				return default(NOPLDIMKCKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T ANIOFDMDDCB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3334090", Offset = "0x3333290", VA = "0x183334090")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, NOPLDIMKCKF) DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x41390D0", Offset = "0x41382D0", VA = "0x1841390D0")]
			get
			{
				return default((T, NOPLDIMKCKF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4139290", Offset = "0x4138490", VA = "0x184139290")]
		public PIPONDEKKBI(NativeArray<T> NPPGGGEFJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4139250", Offset = "0x4138450", VA = "0x184139250")]
		public PIPONDEKKBI<T> HPMIKEPMPON()
		{
			return default(PIPONDEKKBI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4138EF0", Offset = "0x41380F0", VA = "0x184138EF0")]
		public bool BCHEHHFFNDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x26B2D80", Offset = "0x26B1F80", VA = "0x1826B2D80")]
		public LIBNBHIHIOP<T, TComparer> DHEPAIKPPIN<TComparer>([Optional] TComparer CKHMADAECKO) where TComparer : struct, IEqualityComparer<T>
		{
			return default(LIBNBHIHIOP<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LIBNBHIHIOP<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T>.ReadOnly NPPGGGEFJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int CMAABPPFEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int MPNJBPCAKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T EHMBHODGAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private T DOGGIEBIOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TComparer CKHMADAECKO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NOPLDIMKCKF LAHGMMLILPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3C98380", Offset = "0x3C97580", VA = "0x183C98380")]
			get
			{
				return default(NOPLDIMKCKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T ANIOFDMDDCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3334090", Offset = "0x3333290", VA = "0x183334090")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C98390", Offset = "0x3C97590", VA = "0x183C98390")]
		public LIBNBHIHIOP(NativeArray<T>.ReadOnly NPPGGGEFJIJ, TComparer CKHMADAECKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C981D0", Offset = "0x3C973D0", VA = "0x183C981D0")]
		public bool BCHEHHFFNDH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2826400", Offset = "0x2825600", VA = "0x182826400")]
	public static PIPONDEKKBI<T> LKJDEFCFOCC<T>(this NativeArray<T> NPPGGGEFJIJ) where T : struct
	{
		return default(PIPONDEKKBI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface PPPKEHCIANG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class MFDJEDKIMJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PKENBPDBILE<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KHDMDAMBKFP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PKENBPDBILE<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAE2150", Offset = "0xAE1350", VA = "0x180AE2150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x36BA5E0", Offset = "0x36B97E0", VA = "0x1836BA5E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public KHDMDAMBKFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B61EF0", Offset = "0x3B610F0", VA = "0x183B61EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B620A0", Offset = "0x3B612A0", VA = "0x183B620A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Action<Protobuf> JDNMKGBIKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MemoryStream EBPBGGMNBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CodedInputStream HOIOKMPFIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Protobuf IFEEJLPMMNF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int DOKCLGDELIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4147960", Offset = "0x4146B60", VA = "0x184147960", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x41479A0", Offset = "0x4146BA0", VA = "0x1841479A0", Slot = "4")]
	[IteratorStateMachine(typeof(PKENBPDBILE<>.KHDMDAMBKFP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4147A90", Offset = "0x4146C90", VA = "0x184147A90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JDMPJBNKPJI<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly byte[] JCGIBGELCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Protobuf IFEEJLPMMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream EBPBGGMNBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedOutputStream GAIPEFFDFAN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A714E0", Offset = "0x3A706E0", VA = "0x183A714E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct NHKJMBGBHNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream EBPBGGMNBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedInputStream HOIOKMPFIMH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6210D90", Offset = "0x620FF90", VA = "0x186210D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct CEMGODCIBOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly byte[] JCGIBGELCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MemoryStream EBPBGGMNBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CodedOutputStream GAIPEFFDFAN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6210000", Offset = "0x620F200", VA = "0x186210000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class OCILFJHBAFP
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class DIFLKAPFCPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
public enum MAGJDNJPCOA
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class BAIFIABFKDI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class CNDGMOJHGPO
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public CNDGMOJHGPO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
