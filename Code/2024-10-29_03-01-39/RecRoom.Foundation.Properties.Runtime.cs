using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OFIHCCFKCBN<TContainer, TField> : DAIGOMDGIKK<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x408AA00", Offset = "0x4089A00", VA = "0x18408AA00")]
	public OFIHCCFKCBN(string DMCFPOLFNCF, OJEHEGHEHGK MPFENKGEFEA, FieldInfo GACKDADIEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FD90", Offset = "0x4B0ED90", VA = "0x184B0FD90", Slot = "26")]
	public override bool NONCGFKLPGD(Entity KKABBGOPMMA, NAIOMCDFHCH GKLNJFJLDOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F9A0", Offset = "0x4B0E9A0", VA = "0x184B0F9A0", Slot = "32")]
	public override COIBDOEEGGO DEMHKIGCFJD(EntityManager ALGIPGIOGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class MDCELMDOAEG<T> : DAIGOMDGIKK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x408AA00", Offset = "0x4089A00", VA = "0x18408AA00")]
	public MDCELMDOAEG(string DMCFPOLFNCF, OJEHEGHEHGK MPFENKGEFEA, FieldInfo GACKDADIEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4933F60", Offset = "0x4932F60", VA = "0x184933F60", Slot = "32")]
	public override COIBDOEEGGO DEMHKIGCFJD(EntityManager ALGIPGIOGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class DAIGOMDGIKK<T> : HFIGBHNMMFL, CNKKLCCGOHO<T>, OOCCELDGLFH<Entity, T>, PGCGGDFGBHJ<Entity>, MLGFGAMFLNG, IDisposable, COIBDOEEGGO, FIBMFGNIGLN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool KANMKNOMNDK(Entity KKABBGOPMMA, [In] T GKLNJFJLDOL);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void JHEFLOHPBAL(Entity KKABBGOPMMA, [In] T OIAHDOIKHME, [In] T GKLNJFJLDOL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OJEHEGHEHGK MPFENKGEFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo GACKDADIEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int BPLLKOJNCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int OFDADLBABBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int MLDINGBBEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KANMKNOMNDK IFGENJHGLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JHEFLOHPBAL IANHENFOBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private JHEFLOHPBAL KBLHLBNCILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World IPOALLGMDPB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type BFKMCKBKOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D3F750", Offset = "0x5D3E750", VA = "0x185D3F750", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override OJEHEGHEHGK AFDOELKDAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override FIBMFGNIGLN NNPJFGGFPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo HKKFHLLOADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int IMNFEHLNPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3700", Offset = "0x8D2700", VA = "0x1808D3700", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int ALOBLHOIAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EE0", Offset = "0x8C3EE0", VA = "0x1808C4EE0", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager EEACGFGMMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D3D950", Offset = "0x5D3C950", VA = "0x185D3D950")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D43120", Offset = "0x5D42120", VA = "0x185D43120")]
	internal DAIGOMDGIKK(string DMCFPOLFNCF, OJEHEGHEHGK MPFENKGEFEA, FieldInfo GACKDADIEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D3CEA0", Offset = "0x5D3BEA0", VA = "0x185D3CEA0", Slot = "30")]
	public override void CPDDJGLEDNE(EntityManager MPPDEPEBNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D3C3C0", Offset = "0x5D3B3C0", VA = "0x185D3C3C0")]
	public DAIGOMDGIKK<T> AGABGHBEIGB(KANMKNOMNDK IFGENJHGLAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D3CAC0", Offset = "0x5D3BAC0", VA = "0x185D3CAC0")]
	public DAIGOMDGIKK<T> CDHBBGNINDM(JHEFLOHPBAL IANHENFOBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D3CAA0", Offset = "0x5D3BAA0", VA = "0x185D3CAA0")]
	public DAIGOMDGIKK<T> BMCFADHFLFL(JHEFLOHPBAL KBLHLBNCILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D3E8F0", Offset = "0x5D3D8F0", VA = "0x185D3E8F0", Slot = "33")]
	public T KIJHOBDIGPJ(Entity KKABBGOPMMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D3FF50", Offset = "0x5D3EF50", VA = "0x185D3FF50")]
	public bool NONCGFKLPGD(Entity KKABBGOPMMA, [In] T GKLNJFJLDOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D3CFC0", Offset = "0x5D3BFC0", VA = "0x185D3CFC0")]
	public bool GDHJPDEOLHO(Entity KKABBGOPMMA, [In] T GKLNJFJLDOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D3E1B0", Offset = "0x5D3D1B0", VA = "0x185D3E1B0", Slot = "24")]
	public override bool KDIAAAJKNAC(Entity KKABBGOPMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D3E850", Offset = "0x5D3D850", VA = "0x185D3E850", Slot = "25")]
	public override void KIJHOBDIGPJ(Entity KKABBGOPMMA, DJEENCMJKNM BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D3FE10", Offset = "0x5D3EE10", VA = "0x185D3FE10", Slot = "26")]
	public override bool NONCGFKLPGD(Entity KKABBGOPMMA, NAIOMCDFHCH GKLNJFJLDOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42C3640", Offset = "0x42C2640", VA = "0x1842C3640", Slot = "27")]
	public override void CCPOLLPENCP(FMLLBAJNKDE NELJMCNNPAL, [Optional] object NDMMIOJEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D260", Offset = "0x5D3C260", VA = "0x185D3D260", Slot = "28")]
	public override bool GHOCANAKDHH(Entity EMIPIILANPP, Entity KBCCBGCMCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D3C660", Offset = "0x5D3B660", VA = "0x185D3C660", Slot = "31")]
	public override string BLANJIODBHL([In] NAIOMCDFHCH GFJJGLKGGFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F380", Offset = "0x5D3E380", VA = "0x185D3F380")]
	private bool NBPPFHJIPEN(T OIAHDOIKHME, T GKLNJFJLDOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class HFIGBHNMMFL : BGKJENMGGBG, COIBDOEEGGO, PGCGGDFGBHJ<Entity>, MLGFGAMFLNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type BFKMCKBKOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract OJEHEGHEHGK AFDOELKDAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract FIBMFGNIGLN NNPJFGGFPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OONIMCCDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB48CD0", Offset = "0xB47CD0", VA = "0x180B48CD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DHBIOAGLOBC<Entity> MLDBCOCGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EC0000", Offset = "0x6EBF000", VA = "0x186EC0000", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFF50", Offset = "0x6EBEF50", VA = "0x186EBFF50", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool KDIAAAJKNAC(Entity KKABBGOPMMA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void KIJHOBDIGPJ(Entity KKABBGOPMMA, DJEENCMJKNM BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool NONCGFKLPGD(Entity KKABBGOPMMA, NAIOMCDFHCH GKLNJFJLDOL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void CCPOLLPENCP(FMLLBAJNKDE NELJMCNNPAL, [Optional] object NDMMIOJEOEB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool GHOCANAKDHH(Entity EMIPIILANPP, Entity KBCCBGCMCIL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void CPDDJGLEDNE(EntityManager MPPDEPEBNEN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2F8F9B0", Offset = "0x2F8E9B0", VA = "0x182F8F9B0")]
	protected void LCFMCILNCJG<T>(Entity KKABBGOPMMA, [In] T OIAHDOIKHME, [In] T GKLNJFJLDOL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string BLANJIODBHL([In] NAIOMCDFHCH GFJJGLKGGFC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract COIBDOEEGGO DEMHKIGCFJD(EntityManager ALGIPGIOGCA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	protected HFIGBHNMMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface COIBDOEEGGO : PGCGGDFGBHJ<Entity>, MLGFGAMFLNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	COIBDOEEGGO DEMHKIGCFJD(EntityManager ALGIPGIOGCA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CNKKLCCGOHO<T> : OOCCELDGLFH<Entity, T>, PGCGGDFGBHJ<Entity>, MLGFGAMFLNG, IDisposable, COIBDOEEGGO where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface BGKJENMGGBG : COIBDOEEGGO, PGCGGDFGBHJ<Entity>, MLGFGAMFLNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int OONIMCCDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BHMBEMKICOB
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D00000", Offset = "0x2CFF000", VA = "0x182D00000")]
	public static T BLBBPOGEDED<T>(this CNKKLCCGOHO<T> EDBGKLDPNAK, Entity KKABBGOPMMA, [Optional] T MJBMFFMBOMO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D00400", Offset = "0x2CFF400", VA = "0x182D00400")]
	public static T JAEBKCPHLDG<T>(this PGCGGDFGBHJ<Entity> EDBGKLDPNAK, Entity KKABBGOPMMA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D00210", Offset = "0x2CFF210", VA = "0x182D00210")]
	public static bool GLDBPDCBPPC<T>(this PGCGGDFGBHJ<Entity> EDBGKLDPNAK, Entity KKABBGOPMMA, [In] T GKLNJFJLDOL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D001A0", Offset = "0x2CFF1A0", VA = "0x182D001A0")]
	public static bool GLDBPDCBPPC<T>(this PGCGGDFGBHJ<Entity> EDBGKLDPNAK, Entity KKABBGOPMMA, NativeArray<T> GKLNJFJLDOL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void DHBIOAGLOBC<TKey>(TKey IFPBFCLBBDP, [In] NAIOMCDFHCH OIAHDOIKHME, [In] NAIOMCDFHCH GKLNJFJLDOL);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OIOHMPDHJAO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3149110", Offset = "0x3148110", VA = "0x183149110")]
	public static void IJNFOBHJKBL<TKey, T>(this DHBIOAGLOBC<TKey> ECOGMCELFGJ, TKey IFPBFCLBBDP, T OIAHDOIKHME, T GKLNJFJLDOL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FMLLBAJNKDE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDDEGEJMIEA<TKey, T>(OOCCELDGLFH<TKey, T> EDBGKLDPNAK, [Optional] object NDMMIOJEOEB) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MKILGFOOOBB
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FIBMFGNIGLN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo JALNPEHAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int NDBPJGICJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int IIJOJMFBBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MLGFGAMFLNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type BFKMCKBKOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FIBMFGNIGLN NNPJFGGFPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OJEHEGHEHGK AFDOELKDAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int OONIMCCDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCPOLLPENCP(FMLLBAJNKDE NELJMCNNPAL, [Optional] object NDMMIOJEOEB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PGCGGDFGBHJ<TKey> : MLGFGAMFLNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DHBIOAGLOBC<TKey> MLDBCOCGEPI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDIAAAJKNAC(TKey MLAECOMLIEC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIJHOBDIGPJ(TKey MLAECOMLIEC, DJEENCMJKNM BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NONCGFKLPGD(TKey MLAECOMLIEC, NAIOMCDFHCH GKLNJFJLDOL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GHOCANAKDHH(TKey EMIPIILANPP, TKey KBCCBGCMCIL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string BLANJIODBHL([In] NAIOMCDFHCH BJDKOHEGDOK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface OOCCELDGLFH<TKey, T> : PGCGGDFGBHJ<TKey>, MLGFGAMFLNG, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T KIJHOBDIGPJ(TKey MLAECOMLIEC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DBPILHALAHC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DB7DA0", Offset = "0x2DB6DA0", VA = "0x182DB7DA0")]
	public static bool OKBNAJGEJDO<TKey, T>(this PGCGGDFGBHJ<TKey> EDBGKLDPNAK, TKey MLAECOMLIEC, [Out] T BJDKOHEGDOK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6CB0", Offset = "0x2DB5CB0", VA = "0x182DB6CB0")]
	public static T KIJHOBDIGPJ<T, TKey>(this PGCGGDFGBHJ<TKey> EDBGKLDPNAK, TKey MLAECOMLIEC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2DB78E0", Offset = "0x2DB68E0", VA = "0x182DB78E0")]
	public static bool NONCGFKLPGD<TKey, T>(this PGCGGDFGBHJ<TKey> EDBGKLDPNAK, TKey MLAECOMLIEC, T GKLNJFJLDOL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2DB7670", Offset = "0x2DB6670", VA = "0x182DB7670")]
	public static bool NONCGFKLPGD<TKey, T>(this PGCGGDFGBHJ<TKey> EDBGKLDPNAK, TKey MLAECOMLIEC, NativeArray<T> GKLNJFJLDOL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface PPDMBFAKKCA : IEnumerable<COIBDOEEGGO>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OJEHEGHEHGK
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int FFJOFJEINCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int HLKAEBMNJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type KICDDEIBFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	COIBDOEEGGO[] LBDIDFDPFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ANGCNDLOOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) LNDFAJKHDDL(Entity KKABBGOPMMA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class MHBCNAOLGHF : PPDMBFAKKCA, IEnumerable<COIBDOEEGGO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<COIBDOEEGGO> PEKHCFGGPBJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EC05C0", Offset = "0x6EBF5C0", VA = "0x186EC05C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public COIBDOEEGGO JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EC0600", Offset = "0x6EBF600", VA = "0x186EC0600", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0660", Offset = "0x6EBF660", VA = "0x186EC0660")]
	public MHBCNAOLGHF(IEnumerable<OJEHEGHEHGK> NBHHOJCALOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0130", Offset = "0x6EBF130", VA = "0x186EC0130")]
	private List<COIBDOEEGGO> ICJCHIAFDDE(IEnumerable<OJEHEGHEHGK> NBHHOJCALOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC00B0", Offset = "0x6EBF0B0", VA = "0x186EC00B0", Slot = "4")]
	public IEnumerator<COIBDOEEGGO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EC00B0", Offset = "0x6EBF0B0", VA = "0x186EC00B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DLDBIHMACPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type EBFJNACJDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string DMCFPOLFNCF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	public DLDBIHMACPC(Type EBFJNACJDDO, string DMCFPOLFNCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KIIPHCBACKL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type EBFJNACJDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string DMCFPOLFNCF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	public KIIPHCBACKL(Type EBFJNACJDDO, string DMCFPOLFNCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x467CB00", Offset = "0x467BB00", VA = "0x18467CB00")]
	public static DLDBIHMACPC APFPPDGPEGM(KIIPHCBACKL<T> CENBBDOHHKB)
	{
		return default(DLDBIHMACPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum BMFPFEFDGIL
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	External = -6
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OBMFEFCOIEE
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OBMFEFCOIEE()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
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
