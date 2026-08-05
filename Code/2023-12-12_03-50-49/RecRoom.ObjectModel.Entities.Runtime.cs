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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EE3470", Offset = "0x5EE1C70", VA = "0x185EE3470")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BGNMCMMLLJJ<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] NIAKGOIEGFB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B000", Offset = "0x2E19800", VA = "0x182E1B000")]
	public static void EHAENBNGBCD<TField>(int EAHCFBMNNCF, string PMDCAPIFBIP, FADJKLOPABB OPFKECKJNDH, [Out] DBJOFEOJCDO<TField> AHFKMNKCLNN) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D2F0", Offset = "0x2E1BAF0", VA = "0x182E1D2F0")]
	public static void ODIKICIJAMH<TField>(int EAHCFBMNNCF, string PMDCAPIFBIP, [Out] JFMGGGHOGCJ<TField> LLJBEMIACPC) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class NFHPDBKKKJO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4B90", Offset = "0x5EE3390", VA = "0x185EE4B90")]
	public static FieldInfo[] OLKEHFGICHN(Type HJNJPNKDEFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class AFLGBAKACJL<View, Data> : HEHMGDGCBDN where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType OALAELEMALA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type KPNDNKFBJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3556000", Offset = "0x3554800", VA = "0x183556000", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int OOGDBICCBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3553550", Offset = "0x3551D50", VA = "0x183553550", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3553ED0", Offset = "0x35526D0", VA = "0x183553ED0")]
	public Data HKMHPPFBFDC(Entity EIJPPJGEAJM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View HNGGHMCNMAC(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20DF620", Offset = "0x20DDE20", VA = "0x1820DF620", Slot = "14")]
	public override T HNGGHMCNMAC<T>(Entity EIJPPJGEAJM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	protected AFLGBAKACJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class HEHMGDGCBDN : FADJKLOPABB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle DIOBBOPKEBO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager POPOHHMPIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type KPNDNKFBJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int OOGDBICCBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type ILGACPMAPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x965A50", Offset = "0x964250", VA = "0x180965A50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int GGHNNDEINNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3C20", Offset = "0x5EE2420", VA = "0x185EE3C20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private EIAJNDAFPFP[] OLCGAJOHOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1630", Offset = "0x3CEFE30", VA = "0x183CF1630", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual EIAJNDAFPFP[] DEEPPFGKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3C90", Offset = "0x5EE2490", VA = "0x185EE3C90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EE39F0", Offset = "0x5EE21F0", VA = "0x185EE39F0")]
	public void EBEAKPIECKB(EntityManager BBGFDBOHPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T HNGGHMCNMAC<T>(Entity EIJPPJGEAJM) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3D20", Offset = "0x5EE2520", VA = "0x185EE3D20", Slot = "8")]
	public (uint, uint) LOMEFNGJAIP(Entity EIJPPJGEAJM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3B30", Offset = "0x5EE2330", VA = "0x185EE3B30", Slot = "9")]
	public bool IFNPMPDILMD(Entity EIJPPJGEAJM, (uint order, uint change) GLPKPIDPHCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected HEHMGDGCBDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KPLKCKEEFPD
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OABGDCCOBIJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OFKCFJLEMKK JIMMKGIMCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HLOMBOEHFEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIHCGHEHFAH(Entity EIJPPJGEAJM, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDDFKLCKMBJ(Entity EIJPPJGEAJM, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CODMILKCEOJ(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KIAGJOJLKAB(Entity EIJPPJGEAJM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LJPJCJMCPED<TComponentData, TValue> : OGNOOBMDHPK<TValue>, IDisposable where TComponentData : struct, OABGDCCOBIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class OACCEJILIAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> GKICFBMALOA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CADPCMFLDGP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2F84100", Offset = "0x2F82900", VA = "0x182F84100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7FE0", Offset = "0x3DF67E0", VA = "0x183DF7FE0")]
		public bool BINGOMJDAPM([Out] TValue DOLICEBFIPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8150", Offset = "0x3DF6950", VA = "0x183DF8150")]
		public void INCGBOEKEGG(object JECMOKMEJED, TValue DOLICEBFIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DF80D0", Offset = "0x3DF68D0", VA = "0x183DF80D0")]
		public bool FMCALLKJEMI(object JECMOKMEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8200", Offset = "0x3DF6A00", VA = "0x183DF8200")]
		public int KHHFPNNLBDE(object JECMOKMEJED)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3DF82E0", Offset = "0x3DF6AE0", VA = "0x183DF82E0")]
		public OACCEJILIAP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<OACCEJILIAP> JKLDOJAHOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CEEMHKGLOLE<OFKCFJLEMKK, OACCEJILIAP> BGDGMHEBGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager BBGFDBOHPKJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CB80", Offset = "0x3A6B380", VA = "0x183A6CB80")]
	public LJPJCJMCPED(EntityManager BBGFDBOHPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C720", Offset = "0x3A6AF20", VA = "0x183A6C720", Slot = "4")]
	public void IIHCGHEHFAH(Entity EIJPPJGEAJM, object JECMOKMEJED, TValue DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C9E0", Offset = "0x3A6B1E0", VA = "0x183A6C9E0", Slot = "5")]
	public bool PDDFKLCKMBJ(Entity EIJPPJGEAJM, object JECMOKMEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C430", Offset = "0x3A6AC30", VA = "0x183A6C430", Slot = "6")]
	public bool BINGOMJDAPM(Entity EIJPPJGEAJM, [Out] TValue DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C5F0", Offset = "0x3A6ADF0", VA = "0x183A6C5F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C860", Offset = "0x3A6B060", VA = "0x183A6C860")]
	private void JCEIGHHHHLA(OACCEJILIAP HDMNEIOIAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C530", Offset = "0x3A6AD30", VA = "0x183A6C530")]
	private bool CGDAMJOLDCK(Entity EIJPPJGEAJM, [Out] OFKCFJLEMKK JDLDAOKCDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C630", Offset = "0x3A6AE30", VA = "0x183A6C630")]
	private void GAAEODJBKLJ(Entity EIJPPJGEAJM, OFKCFJLEMKK JDLDAOKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C610", Offset = "0x3A6AE10", VA = "0x183A6C610")]
	private bool FCAFFMBPLIK(OFKCFJLEMKK JDLDAOKCDAP, [Out] OACCEJILIAP HDMNEIOIAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C8F0", Offset = "0x3A6B0F0", VA = "0x183A6C8F0")]
	private OACCEJILIAP MOEJODBEEJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OGNOOBMDHPK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIHCGHEHFAH(Entity EIJPPJGEAJM, object JECMOKMEJED, TValue DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDDFKLCKMBJ(Entity EIJPPJGEAJM, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BINGOMJDAPM(Entity EIJPPJGEAJM, [Out] TValue DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OFKCFJLEMKK : DHALIGBDNKA, IEquatable<OFKCFJLEMKK>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly OFKCFJLEMKK MIOPHGKICKL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int EGOJHBDPODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int DJCMCJGIECP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x209E4E0", Offset = "0x209CCE0", VA = "0x18209E4E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5302BF0", Offset = "0x53013F0", VA = "0x185302BF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4CD0", Offset = "0x5EE34D0", VA = "0x185EE4CD0", Slot = "8")]
	public bool Equals(OFKCFJLEMKK FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4D20", Offset = "0x5EE3520", VA = "0x185EE4D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DGCNIDALCBC<THasTokensTag> : HLOMBOEHFEG, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, OFKCFJLEMKK> BOECHGPLNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> JKLDOJAHOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private CEEMHKGLOLE<OFKCFJLEMKK, HashSet<object>> BGDGMHEBGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager BBGFDBOHPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem DECBJKHFOBH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6CA0", Offset = "0x4DD54A0", VA = "0x184DD6CA0")]
	public DGCNIDALCBC(EntityManager BBGFDBOHPKJ, EntityCommandBufferSystem DECBJKHFOBH, DNJICJAPBOC GJELEMHEBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5370", Offset = "0x4DD3B70", VA = "0x184DD5370", Slot = "4")]
	public bool IIHCGHEHFAH(Entity EIJPPJGEAJM, object JECMOKMEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4DD66D0", Offset = "0x4DD4ED0", VA = "0x184DD66D0", Slot = "5")]
	public bool PDDFKLCKMBJ(Entity EIJPPJGEAJM, object JECMOKMEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4DD3EF0", Offset = "0x4DD26F0", VA = "0x184DD3EF0", Slot = "6")]
	public bool CODMILKCEOJ(Entity EIJPPJGEAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4DD3F80", Offset = "0x4DD2780", VA = "0x184DD3F80", Slot = "9")]
	public bool CODMILKCEOJ(OFKCFJLEMKK JDLDAOKCDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5CF0", Offset = "0x4DD44F0", VA = "0x184DD5CF0", Slot = "7")]
	public bool KIAGJOJLKAB(Entity EIJPPJGEAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4DD4960", Offset = "0x4DD3160", VA = "0x184DD4960", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4DD57C0", Offset = "0x4DD3FC0", VA = "0x184DD57C0")]
	private void JCEIGHHHHLA(HashSet<object> HDMNEIOIAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4DD3B20", Offset = "0x4DD2320", VA = "0x184DD3B20")]
	private bool CGDAMJOLDCK(Entity EIJPPJGEAJM, [Out] OFKCFJLEMKK JDLDAOKCDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4DD4E50", Offset = "0x4DD3650", VA = "0x184DD4E50")]
	private bool GINOODDPDKH(Entity EIJPPJGEAJM, [Out] OFKCFJLEMKK JDLDAOKCDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4DD3540", Offset = "0x4DD1D40", VA = "0x184DD3540")]
	private void BDMILCBHKEF(Entity EIJPPJGEAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4DD4850", Offset = "0x4DD3050", VA = "0x184DD4850")]
	private void DAAMFILHPLN(Entity EIJPPJGEAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4DD4210", Offset = "0x4DD2A10", VA = "0x184DD4210")]
	private void CPFBMFNEJNH(Entity EIJPPJGEAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DD4B80", Offset = "0x4DD3380", VA = "0x184DD4B80")]
	private void GAAEODJBKLJ(Entity EIJPPJGEAJM, OFKCFJLEMKK JDLDAOKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6010", Offset = "0x4DD4810", VA = "0x184DD6010")]
	private bool LBGDPEHIKKH(OFKCFJLEMKK JDLDAOKCDAP, [Out] HashSet<object> HDMNEIOIAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4DD60D0", Offset = "0x4DD48D0", VA = "0x184DD60D0")]
	private HashSet<object> MOEJODBEEJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JBEPFOACONG
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KGMFPMBMFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int IJJNAEFKMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int PPKDCOOCBKP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KEAGPFCIOED
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x209E4E0", Offset = "0x209CCE0", VA = "0x18209E4E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5302BF0", Offset = "0x53013F0", VA = "0x185302BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MKOLGNEGDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CGLCBLDLOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4220", Offset = "0x5EE2A20", VA = "0x185EE4220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4210", Offset = "0x5EE2A10", VA = "0x185EE4210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA106A0", Offset = "0xA0EEA0", VA = "0x180A106A0")]
	private KGMFPMBMFPL(int IJJNAEFKMHG, int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CDC410", Offset = "0x1CDAC10", VA = "0x181CDC410")]
	public static KGMFPMBMFPL PJNOLLAMAGE(int IJJNAEFKMHG, int PPKDCOOCBKP)
	{
		return default(KGMFPMBMFPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4230", Offset = "0x5EE2A30", VA = "0x185EE4230")]
	public static KGMFPMBMFPL POKEFLPIFKA(int IOPBDEDCAOK, int BEDAKCMDPNE)
	{
		return default(KGMFPMBMFPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4240", Offset = "0x5EE2A40", VA = "0x185EE4240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NPJPFNOGFAB : MDAHIOOPDAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD850", Offset = "0x5ECC050", VA = "0x185ECD850")]
	public float LFNCFHCCHIK([In] float3 DOLICEBFIPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD850", Offset = "0x5ECC050", VA = "0x185ECD850", Slot = "4")]
	private float IJMFDGJHCAG([In] float3 DOLICEBFIPF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OJCBNBACOFI : MDAHIOOPDAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9640", Offset = "0x5EC7E40", VA = "0x185EC9640")]
	public float LFNCFHCCHIK([In] float3 DOLICEBFIPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9640", Offset = "0x5EC7E40", VA = "0x185EC9640", Slot = "4")]
	private float IJMFDGJHCAG([In] float3 DOLICEBFIPF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NPGHJOBHDKA : MDAHIOOPDAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1986160", Offset = "0x1984960", VA = "0x181986160")]
	public float LFNCFHCCHIK([In] float3 DOLICEBFIPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1986160", Offset = "0x1984960", VA = "0x181986160", Slot = "4")]
	private float IJMFDGJHCAG([In] float3 DOLICEBFIPF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CKDEAHEKKDM : MDAHIOOPDAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x12CE800", Offset = "0x12CD000", VA = "0x1812CE800")]
	public int LFNCFHCCHIK([In] int3 DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12CE800", Offset = "0x12CD000", VA = "0x1812CE800", Slot = "4")]
	private int KBLKOEJHJOO([In] int3 DOLICEBFIPF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NBHGDNNBOEL : MDAHIOOPDAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7150", Offset = "0x5EC5950", VA = "0x185EC7150")]
	public int LFNCFHCCHIK([In] int3 DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7150", Offset = "0x5EC5950", VA = "0x185EC7150", Slot = "4")]
	private int KBLKOEJHJOO([In] int3 DOLICEBFIPF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LIPFJFIDDFF : MDAHIOOPDAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15A0A30", Offset = "0x159F230", VA = "0x1815A0A30")]
	public int LFNCFHCCHIK([In] int3 DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x15A0A30", Offset = "0x159F230", VA = "0x1815A0A30", Slot = "4")]
	private int KBLKOEJHJOO([In] int3 DOLICEBFIPF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GONOAHJPMIL : LOAGKKLHIFP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type LHOMHIBJFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type EMAACGCEDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EE39A0", Offset = "0x5EE21A0", VA = "0x185EE39A0")]
	public GONOAHJPMIL(Type OGNDJKCLIDF, Type POMACDIBJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DBBLFFNHOCO : LOAGKKLHIFP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type EMAACGCEDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8FB0", Offset = "0x5DF77B0", VA = "0x185DF8FB0")]
	public DBBLFFNHOCO(Type POMACDIBJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AJIAKCADJCA : LOAGKKLHIFP
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x782100", Offset = "0x780900", VA = "0x180782100")]
	public AJIAKCADJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class LPGOFIGONJE<Data> : GECLPODMPPC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data FCIJPOCPFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA93750", Offset = "0xA91F50", VA = "0x180A93750", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3A77810", Offset = "0x3A76010", VA = "0x183A77810", Slot = "8")]
	protected virtual bool HGHABNLKFOO(ReadOnlySpan<Data> HHKFGLJIGDM, FKKGMHGCIMA GLCCGOBFPBA, [Out] ReadOnlySpan<byte> KAGAAHEAJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "9")]
	protected virtual bool NOBHLBFEBMP(int GLPKPIDPHCF, Span<Data> HHKFGLJIGDM, [In] ReadOnlySpan<byte> KAGAAHEAJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3A77750", Offset = "0x3A75F50", VA = "0x183A77750", Slot = "5")]
	internal sealed override bool HGHABNLKFOO(Unity.Entities.Chunk OHMKADDCGHA, int NFAOAMFOHJD, FKKGMHGCIMA GLCCGOBFPBA, [Out] ReadOnlySpan<byte> KAGAAHEAJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3A77DA0", Offset = "0x3A765A0", VA = "0x183A77DA0", Slot = "6")]
	internal sealed override bool NOBHLBFEBMP(int GLPKPIDPHCF, Unity.Entities.Chunk OHMKADDCGHA, int NFAOAMFOHJD, [In] ReadOnlySpan<byte> KAGAAHEAJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x241E320", Offset = "0x241CB20", VA = "0x18241E320")]
	protected EHEFDHEEEID<Protobuf> LACHENOGGIF<Protobuf>(ReadOnlySpan<Data> HHKFGLJIGDM) where Protobuf : IMessage, new()
	{
		return default(EHEFDHEEEID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x241E2A0", Offset = "0x241CAA0", VA = "0x18241E2A0")]
	protected HJGNIPPMONO<Protobuf> FPPKEBPHIDG<Protobuf>(ReadOnlySpan<byte> KAGAAHEAJHB, ReadOnlySpan<Data> HHKFGLJIGDM, Action<Protobuf> JBPKDAGAEOD) where Protobuf : IMessage, new()
	{
		return default(HJGNIPPMONO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
	protected LPGOFIGONJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GECLPODMPPC
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int DJCMCJGIECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3990", Offset = "0x5EE2190", VA = "0x185EE3990", Slot = "5")]
	internal virtual bool HGHABNLKFOO(Unity.Entities.Chunk OHMKADDCGHA, int NFAOAMFOHJD, FKKGMHGCIMA GLCCGOBFPBA, [Out] ReadOnlySpan<byte> KAGAAHEAJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "6")]
	internal virtual bool NOBHLBFEBMP(int GLPKPIDPHCF, Unity.Entities.Chunk OHMKADDCGHA, int NFAOAMFOHJD, [In] ReadOnlySpan<byte> KAGAAHEAJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected GECLPODMPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HLDMIAAIHOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class FGALDICGFDH : SystemBase, HLDMIAAIHOC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3740", Offset = "0x5EE1F40", VA = "0x185EE3740")]
	public ComponentDataFromEntity NMNAIADBFJI(int IBDHJFPOKKL, bool CGOFEIMBLAC = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3720", Offset = "0x5EE1F20", VA = "0x185EE3720")]
	public EntityExistenceLookupByEntity IOGFFLINHEK()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3800", Offset = "0x5EE2000", VA = "0x185EE3800", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x782100", Offset = "0x780900", VA = "0x180782100")]
	protected FGALDICGFDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class FJLENMAMDDC : FGALDICGFDH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3950", Offset = "0x5EE2150", VA = "0x185EE3950", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x782100", Offset = "0x780900", VA = "0x180782100")]
	protected FJLENMAMDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class KLKOIIGOBKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class FGBILLFHNPK : JFIPJKGLEBB
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3860", Offset = "0x5EE2060", VA = "0x185EE3860", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase JAAOEANGELA();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3810", Offset = "0x5EE2010", VA = "0x185EE3810")]
	protected ComponentSystemBase DLELCDOFNFC(params ComponentSystemBase[] MDPDIFLCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x24C5460", Offset = "0x24C3C60", VA = "0x1824C5460")]
	protected ComponentSystemBase DLELCDOFNFC<T>(params ComponentSystemBase[] MDPDIFLCNNM) where T : JFIPJKGLEBB, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x24C5420", Offset = "0x24C3C20", VA = "0x1824C5420")]
	protected ComponentSystemBase PCPJNOECOAC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x24C5420", Offset = "0x24C3C20", VA = "0x1824C5420")]
	protected ComponentSystemBase ANHGILJHAAF<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EE38B0", Offset = "0x5EE20B0", VA = "0x185EE38B0")]
	protected ComponentSystemBase PINKFAPEGIB(params SystemHandleUntyped[] MDPDIFLCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24C5550", Offset = "0x24C3D50", VA = "0x1824C5550")]
	protected ComponentSystemBase PINKFAPEGIB<T>(params SystemHandleUntyped[] MDPDIFLCNNM) where T : JFIPJKGLEBB, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24C54F0", Offset = "0x24C3CF0", VA = "0x1824C54F0")]
	protected SystemHandleUntyped PAJCCFMENIP<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3900", Offset = "0x5EE2100", VA = "0x185EE3900")]
	protected FGBILLFHNPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JFIPJKGLEBB : FPINPCBLFIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3F10", Offset = "0x5EE2710", VA = "0x185EE3F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3900", Offset = "0x5EE2100", VA = "0x185EE3900")]
	public JFIPJKGLEBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class FPINPCBLFIJ : ComponentSystemGroup, HLDMIAAIHOC
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3900", Offset = "0x5EE2100", VA = "0x185EE3900")]
	protected FPINPCBLFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class BNLPKDAKMFA : EntityCommandBufferSystem, HLDMIAAIHOC
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x782100", Offset = "0x780900", VA = "0x180782100")]
	protected BNLPKDAKMFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MDAHIOOPDAC<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LFNCFHCCHIK([In] TFrom DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GPCBENGGKNF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CDICKLMDPAJ(T DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HHDMNPLDGCI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> EBDADEJKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer MJPMLHLDPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes HICKENIEIOI;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3E10", Offset = "0x5EE2610", VA = "0x185EE3E10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct CBHGCHEBGAA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> EBDADEJKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer MJPMLHLDPPM;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3310", Offset = "0x5EE1B10", VA = "0x185EE3310", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct DHCLGOPEDII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> EBDADEJKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer MJPMLHLDPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType HMHAAIJJENA;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE33B0", Offset = "0x5EE1BB0", VA = "0x185EE33B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct DOCNFFALGFB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> EBDADEJKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> FCHBDAMJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer MJPMLHLDPPM;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7910", Offset = "0x4DE6110", VA = "0x184DE7910", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct IBAFMMCMPPD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> EBDADEJKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> JCBAGKALIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer MJPMLHLDPPM;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct MFBGJCLHDAI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> EBDADEJKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T DOLICEBFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer MJPMLHLDPPM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C8A4F0", Offset = "0x3C88CF0", VA = "0x183C8A4F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct BPLNJFOKFGE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MDAHIOOPDAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> MAMLLEKEMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> OHPJIIFCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap KJDOCFCKCJE;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct BGGHLPLAMLD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity IGMEHJFDHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> MAMLLEKEMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> OHPJIIFCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int JGJPPPNLGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3050", Offset = "0x5EE1850", VA = "0x185EE3050", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct DOOHELKEOMA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IPGDGCCAPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> MAMLLEKEMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> GDFHHHMDHJN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct LHMODJGEEDM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MDAHIOOPDAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> OEKIABCABII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> OHPJIIFCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap KJDOCFCKCJE;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct IODLGPMLOPL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> POMACDIBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> LIFIFOHACEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> KNLLHFDMHOL;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct CLJKEKGAAHL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> POMACDIBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> LIFIFOHACEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> KNLLHFDMHOL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x49D4CE0", Offset = "0x49D34E0", VA = "0x1849D4CE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct MGANABKJHOM<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> MAMLLEKEMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> GDFHHHMDHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> EDJEBJGBJHG;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C7B0", Offset = "0x3C8AFB0", VA = "0x183C8C7B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct PFMONMNJOHI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : MDAHIOOPDAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> MAMLLEKEMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> GDFHHHMDHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> EDJEBJGBJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap KJDOCFCKCJE;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct IGMKHGMIJCF<T, TPredicate> : IJob where T : struct where TPredicate : struct, GPCBENGGKNF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> MAMLLEKEMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> NOADKIFMCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> BBAGIAGENLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate KJDOCFCKCJE;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x36B8060", Offset = "0x36B6860", VA = "0x1836B8060", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct DHDHGCBHJIJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, GPCBENGGKNF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> MAMLLEKEMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> GDFHHHMDHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate KJDOCFCKCJE;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct NAKBLPEBBLB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity POMACDIBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> LIFIFOHACEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> LLPBAHKMJNL;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4840", Offset = "0x5EE3040", VA = "0x185EE4840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct PCDKOCCPBLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity POMACDIBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> LIFIFOHACEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> LLPBAHKMJNL;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4D70", Offset = "0x5EE3570", VA = "0x185EE4D70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class CEPGDGPHCII
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PONIOKMNIEP
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x265B2D0", Offset = "0x2659AD0", VA = "0x18265B2D0")]
	public static bool BJINFHPODEN<T>(this NativeArray<Entity> LIFIFOHACEK, EntityManager BBGFDBOHPKJ, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BKCKLOOPDDA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class EBMIAHGGDEL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public EBMIAHGGDEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DGGKPJCCPBG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public DGGKPJCCPBG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> IHBFAAIIBNH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3150", Offset = "0x5EE1950", VA = "0x185EE3150")]
	public BKCKLOOPDDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LOADLPHPOGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ODJMPBOMNJP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct OAAOLHNDDDG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct JBMEFCOKCEP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal OAAOLHNDDDG<TFrom> DEINPDMGBDC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> MHGKACIOCHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct BGOKDGHIEOE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct AKMIJENFNFM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal BGOKDGHIEOE<TFrom> DEINPDMGBDC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> MHGKACIOCHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct DPBLMKNPAPG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct IOANMDHPLHJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal DPBLMKNPAPG<TFrom> DEINPDMGBDC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> MHGKACIOCHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct MFIPPAAIFFB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct DANNEKFAPLE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal MFIPPAAIFFB<TFrom> DEINPDMGBDC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> MHGKACIOCHE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PBMMJIHFDEL
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ECAOIHDACGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2379DB0", Offset = "0x23785B0", VA = "0x182379DB0")]
	public static NativeList<T> BHBMNLPDEDK<T>(this NativeList<T> JEKGCALHONC, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2379C30", Offset = "0x2378430", VA = "0x182379C30")]
	public static NativeList<T> BHBMNLPDEDK<T>(this NativeArray<T> JEKGCALHONC, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KANGFFEEKIA
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NCICCNLOONM
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2624D00", Offset = "0x2623500", VA = "0x182624D00")]
	[FAABJGLGFGL]
	public static JobHandle DGNIFNIOKDK<T>(this EntityCommandBufferSystem DECBJKHFOBH, NativeArrayAsync<Entity> EBDADEJKLEM, NativeArrayAsync<T> FCHBDAMJEHN, [Optional] JobHandle GBKLFHIPOEG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2624FC0", Offset = "0x26237C0", VA = "0x182624FC0")]
	[FAABJGLGFGL]
	public static JobHandle DGNIFNIOKDK<T>(this EntityCommandBufferSystem DECBJKHFOBH, NativeArrayAsync<Entity> EBDADEJKLEM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2624BE0", Offset = "0x26233E0", VA = "0x182624BE0")]
	[FAABJGLGFGL]
	public static JobHandle DGNIFNIOKDK<T>(this EntityCommandBufferSystem DECBJKHFOBH, NativeArray<Entity> EBDADEJKLEM, [Optional] JobHandle GBKLFHIPOEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4A20", Offset = "0x5EE3220", VA = "0x185EE4A20")]
	[FAABJGLGFGL]
	public static JobHandle DGNIFNIOKDK(this EntityCommandBufferSystem DECBJKHFOBH, NativeArray<Entity> EBDADEJKLEM, ComponentTypes HICKENIEIOI, [Optional] JobHandle GBKLFHIPOEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE48D0", Offset = "0x5EE30D0", VA = "0x185EE48D0")]
	[FAABJGLGFGL]
	public static JobHandle DGNIFNIOKDK(this EntityCommandBufferSystem DECBJKHFOBH, EntityCommandBuffer MJPMLHLDPPM, NativeArray<Entity> EBDADEJKLEM, ComponentTypes HICKENIEIOI, [Optional] JobHandle GBKLFHIPOEG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class IIMOCIKMIKI
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25055F0", Offset = "0x2503DF0", VA = "0x1825055F0")]
	[FAABJGLGFGL]
	public static JobHandle IBLAANGFOJK<T>(this EntityCommandBufferSystem DECBJKHFOBH, EntityCommandBuffer MJPMLHLDPPM, EntityQuery EAMOCHNAENP, T DOLICEBFIPF) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FADDLABNCBA
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3490", Offset = "0x5EE1C90", VA = "0x185EE3490")]
	[FAABJGLGFGL]
	public static JobHandle CCGHGAMDLGD(this EntityCommandBufferSystem DECBJKHFOBH, NativeList<Entity> EBDADEJKLEM, [Optional] JobHandle GBKLFHIPOEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3620", Offset = "0x5EE1E20", VA = "0x185EE3620")]
	[FAABJGLGFGL]
	public static JobHandle CCGHGAMDLGD(this EntityCommandBufferSystem DECBJKHFOBH, NativeArrayAsync<Entity> EBDADEJKLEM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class CFPNGPOAGBF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x232B3F0", Offset = "0x2329BF0", VA = "0x18232B3F0")]
	public static void JBKBIMDILHG<T>(this EntityCommandBufferSystem DECBJKHFOBH, EntityQuery EAMOCHNAENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x232BBA0", Offset = "0x232A3A0", VA = "0x18232BBA0")]
	[FAABJGLGFGL]
	public static JobHandle ODKADEJOJMK<T>(this EntityCommandBufferSystem DECBJKHFOBH, NativeListAsync<Entity> EBDADEJKLEM, [Optional] JobHandle GBKLFHIPOEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x232BA10", Offset = "0x232A210", VA = "0x18232BA10")]
	[FAABJGLGFGL]
	public static JobHandle ODKADEJOJMK<T>(this EntityCommandBufferSystem DECBJKHFOBH, NativeArrayAsync<Entity> EBDADEJKLEM, [Optional] JobHandle GBKLFHIPOEG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KDKPIICLDPL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2554FD0", Offset = "0x25537D0", VA = "0x182554FD0")]
	[FAABJGLGFGL]
	public static JobHandle MKEGIPOHCGF<T>(this EntityCommandBufferSystem DECBJKHFOBH, NativeArray<Entity> EBDADEJKLEM, NativeArray<T> FCHBDAMJEHN, JobHandle GBKLFHIPOEG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class OFACMIODHLH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x264A0F0", Offset = "0x26488F0", VA = "0x18264A0F0")]
	[FAABJGLGFGL]
	public static JobHandle DNHMILPFCCJ<T>(this EntityCommandBufferSystem DECBJKHFOBH, NativeArray<Entity> EBDADEJKLEM, T DOLICEBFIPF, [Optional] JobHandle GBKLFHIPOEG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x264A020", Offset = "0x2648820", VA = "0x18264A020")]
	[FAABJGLGFGL]
	public static JobHandle DNHMILPFCCJ<T>(this EntityCommandBufferSystem DECBJKHFOBH, EntityCommandBuffer MJPMLHLDPPM, NativeArray<Entity> EBDADEJKLEM, T DOLICEBFIPF, [Optional] JobHandle GBKLFHIPOEG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class AMIEIKCOAPG
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B28280", Offset = "0x2B26A80", VA = "0x182B28280")]
	public static NativeList<T> BHBMNLPDEDK<T>(NativeList<T> JEKGCALHONC, Allocator BIOBDEGNFFO) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class KEEPNGADONI
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2555640", Offset = "0x2553E40", VA = "0x182555640")]
	public static NativeArray<T> PLJCFEPBJEI<T>(this NativeList<Entity> JEKGCALHONC, EntityManager BBGFDBOHPKJ, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x25552C0", Offset = "0x2553AC0", VA = "0x1825552C0")]
	public static NativeArray<T> PLJCFEPBJEI<T>(this NativeArray<Entity> JEKGCALHONC, EntityManager BBGFDBOHPKJ, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4030", Offset = "0x5EE2830", VA = "0x185EE4030")]
	public static NativeArray<Entity> KHMLDKMBMAH(this NativeArray<Entity> JEKGCALHONC, EntityManager BBGFDBOHPKJ, ComponentType HMHAAIJJENA, Allocator BIOBDEGNFFO = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25551E0", Offset = "0x25539E0", VA = "0x1825551E0")]
	public static NativeArray<T> NNMDOOOJHPH<T>(this NativeArray<Entity> JEKGCALHONC, EntityManager BBGFDBOHPKJ, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CIMHKGMJGBB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct NFIHGAJFKJN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct EDJCOMMOAIJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NFIHGAJFKJN<TFrom> MHGKACIOCHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> MAMLLEKEMGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct ILKPLLOGMKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct MCPCNICJEBF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public ILKPLLOGMKJ<TFrom> MHGKACIOCHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> MAMLLEKEMGF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct CKOIFHOIGOH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct JECOFBEJACP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public CKOIFHOIGOH<TFrom> MHGKACIOCHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> MAMLLEKEMGF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ALAMMAFGKGA
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class DDIFNDFOBPM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct JBFJMDLLCNC : MDAHIOOPDAC<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> NFKIECLMICJ;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3F00", Offset = "0x5EE2700", VA = "0x185EE3F00")]
		[BurstCompatible]
		public Entity LFNCFHCCHIK([In] Entity DOLICEBFIPF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3F00", Offset = "0x5EE2700", VA = "0x185EE3F00", Slot = "4")]
		private Entity ILCFKEGCGJB([In] Entity DOLICEBFIPF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class DHGAHPKFEJK
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct MHEIFINLDHF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> NOADKIFMCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> MAMLLEKEMGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct HEDFGJONMMF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> NOADKIFMCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> MAMLLEKEMGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MLPNEAMGEDI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> NOADKIFMCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> MAMLLEKEMGF;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2424910", Offset = "0x2423110", VA = "0x182424910")]
		public NativeListAsync<Entity> CDICKLMDPAJ<TPredicate>() where TPredicate : struct, GPCBENGGKNF<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2357AA0", Offset = "0x23562A0", VA = "0x182357AA0")]
	public static MLPNEAMGEDI<T> AFBIEBBHJML<T>(this NativeArrayAsync<Entity> LIFIFOHACEK, NativeArrayAsync<T> JEKGCALHONC, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct
	{
		return default(MLPNEAMGEDI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class NPFKJELPHHE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x26339F0", Offset = "0x26321F0", VA = "0x1826339F0")]
	public static NativeListAsync<Entity> BJDANPLOEOO<T, TPredicate>(this NativeArrayAsync<T> JEKGCALHONC, NativeArrayAsync<Entity> LIFIFOHACEK, Allocator BIOBDEGNFFO = Allocator.TempJob) where T : struct where TPredicate : struct, GPCBENGGKNF<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2633AB0", Offset = "0x26322B0", VA = "0x182633AB0")]
	private static NativeListAsync<Entity> OJCJGIPOFGG<T, TPredicate>(NativeArrayAsync<T> FOOAOFDCHKC, NativeArrayAsync<Entity> LIFIFOHACEK, int BONCBNKGOGN, Allocator BIOBDEGNFFO) where T : struct where TPredicate : struct, GPCBENGGKNF<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class PNFBLLLKOPD
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GCNALDAGEOM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> MAMLLEKEMGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DPPMJEKFFCJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> MAMLLEKEMGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct CPKBMCGPHGE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> MAMLLEKEMGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct EIFALBHOOFE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator BIOBDEGNFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> MAMLLEKEMGF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class BJKKGCDJAJO
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class LKAPHALPCFM
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2575E10", Offset = "0x2574610", VA = "0x182575E10")]
	public static NativeList<Entity> HHFMDIIPHJM<T>(this NativeArray<Entity> LIFIFOHACEK, EntityManager BBGFDBOHPKJ, Allocator BIOBDEGNFFO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class PJKPGJHBDEO
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class EMKAFOBBBLA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct GIEOFLJIMFC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> CMKNCDNHDNA;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
		public GIEOFLJIMFC(NativeArray<TSrc> CMKNCDNHDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public LKANFCMNHIM<TSrc, TValue> GEOEKAPFHGH<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LKANFCMNHIM<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct LKANFCMNHIM<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> CMKNCDNHDNA;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
		public LKANFCMNHIM(NativeArray<TSrc> CMKNCDNHDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public HGPFPPAOIHI<TSrc, TValue, TSelector> GPPEMCNGDBG<TSelector>() where TSelector : struct, MDAHIOOPDAC<TSrc, TValue>
		{
			return default(HGPFPPAOIHI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct HGPFPPAOIHI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MDAHIOOPDAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> CMKNCDNHDNA;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
		public HGPFPPAOIHI(NativeArray<TSrc> CMKNCDNHDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x359BCB0", Offset = "0x359A4B0", VA = "0x18359BCB0")]
		public GEIMDBDANLM<TSrc, TValue, TSelector> DLELCDOFNFC()
		{
			return default(GEIMDBDANLM<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct HJOFABCDJLM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, MDAHIOOPDAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> CMKNCDNHDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector BKFAKEDANFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int EAHCFBMNNCF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x35A6950", Offset = "0x35A5150", VA = "0x1835A6950")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int EGOJHBDPODL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x993C00", Offset = "0x992400", VA = "0x180993C00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int FHJOOIBMPNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CDE7A0", Offset = "0x1CDCFA0", VA = "0x181CDE7A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x35A69E0", Offset = "0x35A51E0", VA = "0x1835A69E0")]
		public HJOFABCDJLM(NativeArray<TSrc> CMKNCDNHDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x35A6940", Offset = "0x35A5140", VA = "0x1835A6940")]
		public bool DMAIGAKOKOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x35A6860", Offset = "0x35A5060", VA = "0x1835A6860")]
		private TSrc CFKFJOPBJAA(int BOCONGADANC)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct GEIMDBDANLM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MDAHIOOPDAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HJOFABCDJLM<TSrc, TValue, TSelector> MJDEBPJEPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue PNHHEDMFJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int DJIOGHHPANO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KGMFPMBMFPL EPKHPKIACOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x351BA80", Offset = "0x351A280", VA = "0x18351BA80")]
			get
			{
				return default(KGMFPMBMFPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue CJHCMMFLJML
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x773AF0", Offset = "0x7722F0", VA = "0x180773AF0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, KGMFPMBMFPL range) POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x351BC00", Offset = "0x351A400", VA = "0x18351BC00")]
			get
			{
				return default((TValue, KGMFPMBMFPL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x351BD00", Offset = "0x351A500", VA = "0x18351BD00")]
		public GEIMDBDANLM(NativeArray<TSrc> CMKNCDNHDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x351BCE0", Offset = "0x351A4E0", VA = "0x18351BCE0")]
		public GEIMDBDANLM<TSrc, TValue, TSelector> LLEMGPCMEFC()
		{
			return default(GEIMDBDANLM<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x351BAC0", Offset = "0x351A2C0", VA = "0x18351BAC0")]
		public bool DMAIGAKOKOJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x23BB1B0", Offset = "0x23B99B0", VA = "0x1823BB1B0")]
	public static GIEOFLJIMFC<T> CMLADNJLGML<T>(this NativeList<T> GKICFBMALOA) where T : struct
	{
		return default(GIEOFLJIMFC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
	public static GIEOFLJIMFC<T> CMLADNJLGML<T>(this NativeArray<T> CMKNCDNHDNA) where T : struct
	{
		return default(GIEOFLJIMFC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class KFJFMBABFEB
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct AEGHPMIFGEP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly CMKNCDNHDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int DJIOGHHPANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int OKILBIHJBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T PNHHEDMFJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T GCDAHKGNOPO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public KGMFPMBMFPL EPKHPKIACOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x354BA40", Offset = "0x354A240", VA = "0x18354BA40")]
			get
			{
				return default(KGMFPMBMFPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T CJHCMMFLJML
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x317C1A0", Offset = "0x317A9A0", VA = "0x18317C1A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, KGMFPMBMFPL) POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x354BE00", Offset = "0x354A600", VA = "0x18354BE00")]
			get
			{
				return default((T, KGMFPMBMFPL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x354BFC0", Offset = "0x354A7C0", VA = "0x18354BFC0")]
		public AEGHPMIFGEP(NativeArray<T> CMKNCDNHDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x354BF80", Offset = "0x354A780", VA = "0x18354BF80")]
		public AEGHPMIFGEP<T> LLEMGPCMEFC()
		{
			return default(AEGHPMIFGEP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x354BA50", Offset = "0x354A250", VA = "0x18354BA50")]
		public bool DMAIGAKOKOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x20DF5D0", Offset = "0x20DDDD0", VA = "0x1820DF5D0")]
		public IMMMJCOIELE<T, TComparer> FAFAKLLGNDA<TComparer>([Optional] TComparer DIBCDKCIHOF) where TComparer : struct, IEqualityComparer<T>
		{
			return default(IMMMJCOIELE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct IMMMJCOIELE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly CMKNCDNHDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int DJIOGHHPANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int OKILBIHJBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T PNHHEDMFJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T GCDAHKGNOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer DIBCDKCIHOF;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KGMFPMBMFPL EPKHPKIACOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x354BA40", Offset = "0x354A240", VA = "0x18354BA40")]
			get
			{
				return default(KGMFPMBMFPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T CJHCMMFLJML
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x317C1A0", Offset = "0x317A9A0", VA = "0x18317C1A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, KGMFPMBMFPL range) POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x36C78A0", Offset = "0x36C60A0", VA = "0x1836C78A0")]
			get
			{
				return default((T, KGMFPMBMFPL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x36C79B0", Offset = "0x36C61B0", VA = "0x1836C79B0")]
		public IMMMJCOIELE(NativeArray<T>.ReadOnly CMKNCDNHDNA, TComparer DIBCDKCIHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x36C7970", Offset = "0x36C6170", VA = "0x1836C7970")]
		public IMMMJCOIELE<T, TComparer> LLEMGPCMEFC()
		{
			return default(IMMMJCOIELE<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x36C76C0", Offset = "0x36C5EC0", VA = "0x1836C76C0")]
		public bool DMAIGAKOKOJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2557700", Offset = "0x2555F00", VA = "0x182557700")]
	public static AEGHPMIFGEP<T> DLELCDOFNFC<T>(this NativeArray<T> CMKNCDNHDNA) where T : struct
	{
		return default(AEGHPMIFGEP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface GLMPBODJFFL
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class GJPPJANFPIH
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HJGNIPPMONO<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class JMFLCPPGMCG : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HJGNIPPMONO<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9FDA30", Offset = "0x9FC230", VA = "0x1809FDA30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x34C2EE0", Offset = "0x34C16E0", VA = "0x1834C2EE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public JMFLCPPGMCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x38B0590", Offset = "0x38AED90", VA = "0x1838B0590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x38B0740", Offset = "0x38AEF40", VA = "0x1838B0740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> JBPKDAGAEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream HLAKDKDHKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream IKKNNJKIKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf FKJMOCBEIHL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int FHJOOIBMPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x35A4100", Offset = "0x35A2900", VA = "0x1835A4100")]
	private HJGNIPPMONO(byte[] IJPAPFCFHAF, Action<Protobuf> JBPKDAGAEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D3D0", Offset = "0x2E2BBD0", VA = "0x182E2D3D0")]
	public static HJGNIPPMONO<Protobuf> OEONKPJDENI<Data>(ReadOnlySpan<byte> KAGAAHEAJHB, ReadOnlySpan<Data> HHKFGLJIGDM, Action<Protobuf> JBPKDAGAEOD)
	{
		return default(HJGNIPPMONO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x35A3F70", Offset = "0x35A2770", VA = "0x1835A3F70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x35A3FB0", Offset = "0x35A27B0", VA = "0x1835A3FB0", Slot = "4")]
	[IteratorStateMachine(typeof(HJGNIPPMONO<>.JMFLCPPGMCG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x35A40A0", Offset = "0x35A28A0", VA = "0x1835A40A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct EHEFDHEEEID<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] IJPAPFCFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf FKJMOCBEIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream HLAKDKDHKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream KLKGDEOOHCP;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x30FC9B0", Offset = "0x30FB1B0", VA = "0x1830FC9B0")]
	private EHEFDHEEEID(byte[] IJPAPFCFHAF, [In] Protobuf FKJMOCBEIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E23CC0", Offset = "0x2E224C0", VA = "0x182E23CC0")]
	public static EHEFDHEEEID<Protobuf> OEONKPJDENI<T>(ReadOnlySpan<T> HHKFGLJIGDM)
	{
		return default(EHEFDHEEEID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x30FC8F0", Offset = "0x30FB0F0", VA = "0x1830FC8F0")]
	public void EBIIHAJEFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x30FC920", Offset = "0x30FB120", VA = "0x1830FC920")]
	public ByteString NHPONOPKCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x30FC7C0", Offset = "0x30FAFC0", VA = "0x1830FC7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DLKFAFKDEHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream HLAKDKDHKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream IKKNNJKIKOH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3430", Offset = "0x5EE1C30", VA = "0x185EE3430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct BMJBNKDLGFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] IJPAPFCFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream HLAKDKDHKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream KLKGDEOOHCP;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE31E0", Offset = "0x5EE19E0", VA = "0x185EE31E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class LGLAFBGFLPE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void OOJFBAGGKGO<From, To>(From MHGKACIOCHE, To FPCLANOGJBF, FKKGMHGCIMA GLCCGOBFPBA);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class JBCHCGHHOGE<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static OOJFBAGGKGO<From, To> KCOJGEAMAKM;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JBCHCGHHOGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4570", Offset = "0x5EE2D70", VA = "0x185EE4570")]
	static LGLAFBGFLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2572AB0", Offset = "0x25712B0", VA = "0x182572AB0")]
	public static void PHLEODEOGKD<T>(OOJFBAGGKGO<T, T> JOBBGAGIPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x25730F0", Offset = "0x25718F0", VA = "0x1825730F0")]
	public static void PHLEODEOGKD<From, To>(OOJFBAGGKGO<From, To> JOBBGAGIPCK, OOJFBAGGKGO<To, From> FFIABMHANIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2572540", Offset = "0x2570D40", VA = "0x182572540")]
	public static void PHLEODEOGKD<From, To>(OOJFBAGGKGO<From, To> KCOJGEAMAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x256A9E0", Offset = "0x25691E0", VA = "0x18256A9E0")]
	public static OOJFBAGGKGO<From, To> BEDLKNKPMDC<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x256FCE0", Offset = "0x256E4E0", VA = "0x18256FCE0")]
	public static void LLFOMDEPKOP<From, To>(From MHGKACIOCHE, To FPCLANOGJBF, FKKGMHGCIMA GLCCGOBFPBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class FKKGMHGCIMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> LFMNGMKEHFC;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CA43B0", Offset = "0x1CA2BB0", VA = "0x181CA43B0")]
	public FKKGMHGCIMA(NativeArray<EntityRemapUtility.EntityRemapInfo> LFMNGMKEHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3980", Offset = "0x5EE2180", VA = "0x185EE3980")]
	public Entity EMAMDNDHELN(Entity PCNNAKCFNJC)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class KCEBOOHGONP
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3FA0", Offset = "0x5EE27A0", VA = "0x185EE3FA0")]
	public static ulong LMCIGDJOLHM(Type HJNJPNKDEFH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3F40", Offset = "0x5EE2740", VA = "0x185EE3F40")]
	public static ulong LMCIGDJOLHM(string LOMMNLEBDOA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum JNKGDEGOBGH
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AttributeUsage(AttributeTargets.Class)]
public class EKPNJKAEILH : LOAGKKLHIFP
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x782100", Offset = "0x780900", VA = "0x180782100")]
	public EKPNJKAEILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class LELPOAOALOE
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4330", Offset = "0x5EE2B30", VA = "0x185EE4330")]
	private unsafe static Span<byte> MFHEDNLJACD(Unity.Entities.Chunk* OHMKADDCGHA, int NFAOAMFOHJD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x25664D0", Offset = "0x2564CD0", VA = "0x1825664D0")]
	public unsafe static Span<T> JFDNMKNCJFL<T>(Unity.Entities.Chunk* OHMKADDCGHA, int NFAOAMFOHJD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x24DA750", Offset = "0x24D8F50", VA = "0x1824DA750")]
	public static Span<T> JFDNMKNCJFL<T>(this Unity.Entities.Chunk OHMKADDCGHA, int NFAOAMFOHJD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EE42D0", Offset = "0x5EE2AD0", VA = "0x185EE42D0")]
	public unsafe static Span<Entity> KMMIDMIFHPD(Unity.Entities.Chunk* OHMKADDCGHA)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4400", Offset = "0x5EE2C00", VA = "0x185EE4400")]
	public unsafe static void MJBDPJEPBJH(Unity.Entities.Chunk* OHMKADDCGHA, int NFAOAMFOHJD)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class ADJKIDCLGDK
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ADJKIDCLGDK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
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
