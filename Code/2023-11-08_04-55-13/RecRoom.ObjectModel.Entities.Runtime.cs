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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EBFAC0", Offset = "0x5EBE8C0", VA = "0x185EBFAC0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class PBOEKPBCCBB<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] BMOEMJPKBKH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2423440", Offset = "0x2422240", VA = "0x182423440")]
	public static void KCEAMCOCALA<TField>(int NGIPPLLBEKC, string NDLLBBKGIJD, HAAIIOGFDHE OCIKMCPOHOP, [Out] KCPHCELJCHH<TField> NEBGFGPEMHL) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2425130", Offset = "0x2423F30", VA = "0x182425130")]
	public static void MJOJBEBBLAH<TField>(int NGIPPLLBEKC, string NDLLBBKGIJD, [Out] GGPDIJBEDJF<TField> DLDPMNCLOEO) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class OBCNNDPJCLG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0BD0", Offset = "0x5EBF9D0", VA = "0x185EC0BD0")]
	public static FieldInfo[] PPJEEIPAOJH(Type AOPDMLJGEMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class BLHFEGDFCGG<View, Data> : DIKIFGCIEMG where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType PDKALFHHJGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type AFIIDLIHAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x45F8A50", Offset = "0x45F7850", VA = "0x1845F8A50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int KBJFBIPGOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x45F9B90", Offset = "0x45F8990", VA = "0x1845F9B90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45FA630", Offset = "0x45F9430", VA = "0x1845FA630")]
	public Data MNHPDACCKHC(Entity OEEKGABNFEP)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View GEKJNFELLBC(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D18720", Offset = "0x2D17520", VA = "0x182D18720", Slot = "14")]
	public override T GEKJNFELLBC<T>(Entity OEEKGABNFEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	protected BLHFEGDFCGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class DIKIFGCIEMG : HAAIIOGFDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle BJMNEGPAKJH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager NEGBPICGGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1200AD0", Offset = "0x11FF8D0", VA = "0x181200AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type AFIIDLIHAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int KBJFBIPGOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type MJJABKMOOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x909250", Offset = "0x908050", VA = "0x180909250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int LLNEIJMGBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF8D0", Offset = "0x5EBE6D0", VA = "0x185EBF8D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private GBBBMNOIKNN[] PKKADACAPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDEA0", Offset = "0x3CFCCA0", VA = "0x183CFDEA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual GBBBMNOIKNN[] HOCNMENCMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EBFA30", Offset = "0x5EBE830", VA = "0x185EBFA30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF790", Offset = "0x5EBE590", VA = "0x185EBF790")]
	public void CAKCEPELMIL(EntityManager FOMHILNOHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T GEKJNFELLBC<T>(Entity OEEKGABNFEP) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF940", Offset = "0x5EBE740", VA = "0x185EBF940", Slot = "8")]
	public (uint, uint) JLCKPLCKIPC(Entity OEEKGABNFEP)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF6A0", Offset = "0x5EBE4A0", VA = "0x185EBF6A0", Slot = "9")]
	public bool BNIBKCAPEGC(Entity OEEKGABNFEP, (uint order, uint change) PPBKIGHJOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected DIKIFGCIEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IIDBJJHPGEO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LGIJPFNILCO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HLANFIJCCPG FIFBCLKCHDO
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
public interface JBAPMCNOFNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HFJKPCJPLAK(Entity OEEKGABNFEP, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DJIHHCDIKIC(Entity OEEKGABNFEP, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPNAEKJBFBM(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NCIFIFHKKCK(Entity OEEKGABNFEP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MBEKCGGILGH<TComponentData, TValue> : ALGIDIMCEOE<TValue>, IDisposable where TComponentData : struct, LGIJPFNILCO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class MEHIMFJDFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> LCPNBOPPGBK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int BMGCAELLGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2F6E180", Offset = "0x2F6CF80", VA = "0x182F6E180")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C99190", Offset = "0x3C97F90", VA = "0x183C99190")]
		public bool BKALNELOBJK([Out] TValue PHPDIJICBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C99360", Offset = "0x3C98160", VA = "0x183C99360")]
		public void JHPNFEHLKNP(object HOBAPMCPFML, TValue PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C99110", Offset = "0x3C97F10", VA = "0x183C99110")]
		public bool BFKGBCINJJC(object HOBAPMCPFML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C99280", Offset = "0x3C98080", VA = "0x183C99280")]
		public int GGBHOPCELGI(object HOBAPMCPFML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C99410", Offset = "0x3C98210", VA = "0x183C99410")]
		public MEHIMFJDFDN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<MEHIMFJDFDN> OOMPIEKCKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GGMGNGMFAAB<HLANFIJCCPG, MEHIMFJDFDN> KFFONJNNPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager FOMHILNOHEE;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C93BA0", Offset = "0x3C929A0", VA = "0x183C93BA0")]
	public MBEKCGGILGH(EntityManager FOMHILNOHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C93820", Offset = "0x3C92620", VA = "0x183C93820", Slot = "4")]
	public void HFJKPCJPLAK(Entity OEEKGABNFEP, object HOBAPMCPFML, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C93550", Offset = "0x3C92350", VA = "0x183C93550", Slot = "5")]
	public bool DJIHHCDIKIC(Entity OEEKGABNFEP, object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C93450", Offset = "0x3C92250", VA = "0x183C93450", Slot = "6")]
	public bool BKALNELOBJK(Entity OEEKGABNFEP, [Out] TValue PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C936F0", Offset = "0x3C924F0", VA = "0x183C936F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C93A20", Offset = "0x3C92820", VA = "0x183C93A20")]
	private void NBDAGIAJLGI(MEHIMFJDFDN LBIJJPJCJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C93960", Offset = "0x3C92760", VA = "0x183C93960")]
	private bool MDOMPJIHOJF(Entity OEEKGABNFEP, [Out] HLANFIJCCPG JEGLLFDAPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C93730", Offset = "0x3C92530", VA = "0x183C93730")]
	private void GFIKKCEALKM(Entity OEEKGABNFEP, HLANFIJCCPG JEGLLFDAPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C93710", Offset = "0x3C92510", VA = "0x183C93710")]
	private bool EEPCAOFPHGI(HLANFIJCCPG JEGLLFDAPLN, [Out] MEHIMFJDFDN LBIJJPJCJJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C93AB0", Offset = "0x3C928B0", VA = "0x183C93AB0")]
	private MEHIMFJDFDN OECLOACPFHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ALGIDIMCEOE<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFJKPCJPLAK(Entity OEEKGABNFEP, object HOBAPMCPFML, TValue PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DJIHHCDIKIC(Entity OEEKGABNFEP, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BKALNELOBJK(Entity OEEKGABNFEP, [Out] TValue PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HLANFIJCCPG : EACNBBAKFGC, IEquatable<HLANFIJCCPG>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly HLANFIJCCPG OAICJFILECK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int FNPAHLCJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int AJIPJCGCHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x208FBA0", Offset = "0x208E9A0", VA = "0x18208FBA0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x52E5350", Offset = "0x52E4150", VA = "0x1852E5350", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03A0", Offset = "0x5EBF1A0", VA = "0x185EC03A0", Slot = "8")]
	public bool Equals(HLANFIJCCPG LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03F0", Offset = "0x5EBF1F0", VA = "0x185EC03F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DBKGBGFIMPN<THasTokensTag> : JBAPMCNOFNK, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BOGDNAKJHCL BNIILMIMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, HLANFIJCCPG> HNOABBJMKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> OOMPIEKCKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GGMGNGMFAAB<HLANFIJCCPG, HashSet<object>> KFFONJNNPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager FOMHILNOHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem JFPGHMPJOPA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D74DD0", Offset = "0x4D73BD0", VA = "0x184D74DD0")]
	public DBKGBGFIMPN(EntityManager FOMHILNOHEE, EntityCommandBufferSystem JFPGHMPJOPA, BOGDNAKJHCL GNIAHAIFGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4D72FA0", Offset = "0x4D71DA0", VA = "0x184D72FA0", Slot = "4")]
	public bool HFJKPCJPLAK(Entity OEEKGABNFEP, object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D71D20", Offset = "0x4D70B20", VA = "0x184D71D20", Slot = "5")]
	public bool DJIHHCDIKIC(Entity OEEKGABNFEP, object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4D72BA0", Offset = "0x4D719A0", VA = "0x184D72BA0", Slot = "6")]
	public bool GPNAEKJBFBM(Entity OEEKGABNFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4D72D90", Offset = "0x4D71B90", VA = "0x184D72D90", Slot = "9")]
	public bool GPNAEKJBFBM(HLANFIJCCPG JEGLLFDAPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D745B0", Offset = "0x4D733B0", VA = "0x184D745B0", Slot = "7")]
	public bool NCIFIFHKKCK(Entity OEEKGABNFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D72320", Offset = "0x4D71120", VA = "0x184D72320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D741D0", Offset = "0x4D72FD0", VA = "0x184D741D0")]
	private void NBDAGIAJLGI(HashSet<object> LBIJJPJCJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D73D40", Offset = "0x4D72B40", VA = "0x184D73D40")]
	private bool MDOMPJIHOJF(Entity OEEKGABNFEP, [Out] HLANFIJCCPG JEGLLFDAPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D73A30", Offset = "0x4D72830", VA = "0x184D73A30")]
	private bool KKIHHLDLFJF(Entity OEEKGABNFEP, [Out] HLANFIJCCPG JEGLLFDAPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D72760", Offset = "0x4D71560", VA = "0x184D72760")]
	private void GPICAEGINOI(Entity OEEKGABNFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D71880", Offset = "0x4D70680", VA = "0x184D71880")]
	private void DGIIJAPOBIL(Entity OEEKGABNFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D714E0", Offset = "0x4D702E0", VA = "0x184D714E0")]
	private void AHCFJKCPFFF(Entity OEEKGABNFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D725E0", Offset = "0x4D713E0", VA = "0x184D725E0")]
	private void GFIKKCEALKM(Entity OEEKGABNFEP, HLANFIJCCPG JEGLLFDAPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4D73790", Offset = "0x4D72590", VA = "0x184D73790")]
	private bool IMOLBMBHKOE(HLANFIJCCPG JEGLLFDAPLN, [Out] HashSet<object> LBIJJPJCJJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D74A30", Offset = "0x4D73830", VA = "0x184D74A30")]
	private HashSet<object> OECLOACPFHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class COFAKNODADE
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KDKIAPJNAEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int PLIILJHILHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int PDNIMDHODLH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DBDMPPMEDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x208FBA0", Offset = "0x208E9A0", VA = "0x18208FBA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x52E5350", Offset = "0x52E4150", VA = "0x1852E5350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MBBHLBOFKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KIEPBNIPFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0930", Offset = "0x5EBF730", VA = "0x185EC0930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0950", Offset = "0x5EBF750", VA = "0x185EC0950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9D7BB0", Offset = "0x9D69B0", VA = "0x1809D7BB0")]
	private KDKIAPJNAEK(int PLIILJHILHI, int PDNIMDHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9370", Offset = "0x1CC8170", VA = "0x181CC9370")]
	public static KDKIAPJNAEK NCGCPGHACPA(int PLIILJHILHI, int PDNIMDHODLH)
	{
		return default(KDKIAPJNAEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0940", Offset = "0x5EBF740", VA = "0x185EC0940")]
	public static KDKIAPJNAEK EDHICCJLBHF(int EIJIJLGPLFO, int GNLJFNAGDPD)
	{
		return default(KDKIAPJNAEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0960", Offset = "0x5EBF760", VA = "0x185EC0960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JHADBCJBMDO : JBPBNHBKBEN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EA84B0", Offset = "0x5EA72B0", VA = "0x185EA84B0")]
	public float DDDJIDOKCLB([In] float3 PHPDIJICBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA84B0", Offset = "0x5EA72B0", VA = "0x185EA84B0", Slot = "4")]
	private float ALIJBLCFNEK([In] float3 PHPDIJICBJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NNOGCJHGOME : JBPBNHBKBEN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA86E0", Offset = "0x5EA74E0", VA = "0x185EA86E0")]
	public float DDDJIDOKCLB([In] float3 PHPDIJICBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA86E0", Offset = "0x5EA74E0", VA = "0x185EA86E0", Slot = "4")]
	private float ALIJBLCFNEK([In] float3 PHPDIJICBJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KHFJMKADOJA : JBPBNHBKBEN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1944690", Offset = "0x1943490", VA = "0x181944690")]
	public float DDDJIDOKCLB([In] float3 PHPDIJICBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1944690", Offset = "0x1943490", VA = "0x181944690", Slot = "4")]
	private float ALIJBLCFNEK([In] float3 PHPDIJICBJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FCMKGNFNJCB : JBPBNHBKBEN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1294140", Offset = "0x1292F40", VA = "0x181294140")]
	public int DDDJIDOKCLB([In] int3 PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1294140", Offset = "0x1292F40", VA = "0x181294140", Slot = "4")]
	private int OMFCLHHDGFJ([In] int3 PHPDIJICBJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HHJECMJLAHI : JBPBNHBKBEN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2D40", Offset = "0x5EA1B40", VA = "0x185EA2D40")]
	public int DDDJIDOKCLB([In] int3 PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2D40", Offset = "0x5EA1B40", VA = "0x185EA2D40", Slot = "4")]
	private int OMFCLHHDGFJ([In] int3 PHPDIJICBJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EOPPBPHCLHG : JBPBNHBKBEN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1566A70", Offset = "0x1565870", VA = "0x181566A70")]
	public int DDDJIDOKCLB([In] int3 PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1566A70", Offset = "0x1565870", VA = "0x181566A70", Slot = "4")]
	private int OMFCLHHDGFJ([In] int3 PHPDIJICBJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FCMGFGHCCAJ : AKHEGHBFDGH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type DFPKHGCGOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type LHNNJFNFKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFBD0", Offset = "0x5EBE9D0", VA = "0x185EBFBD0")]
	public FCMGFGHCCAJ(Type NBPDGABKNPN, Type KKGNNMFDDEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EEMMDIKIBLF : AKHEGHBFDGH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type LHNNJFNFKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5100", Offset = "0x5DD3F00", VA = "0x185DD5100")]
	public EEMMDIKIBLF(Type KKGNNMFDDEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AHGHAHALFDM : AKHEGHBFDGH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	public AHGHAHALFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class OFLGDODPHLL<Data> : BJLJODNDBML where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data PJHGNDJLIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1920", Offset = "0x3DE0720", VA = "0x183DE1920", Slot = "8")]
	protected virtual bool EIEAFOONHPO(ReadOnlySpan<Data> JGKKOAMEPPD, IOHEBCHGDBO IONJMGHHBLL, [Out] ReadOnlySpan<byte> BBFMJKBFLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "9")]
	protected virtual bool OPNJPDNCGAJ(int PPBKIGHJOID, Span<Data> JGKKOAMEPPD, [In] ReadOnlySpan<byte> BBFMJKBFLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1930", Offset = "0x3DE0730", VA = "0x183DE1930", Slot = "5")]
	internal sealed override bool EIEAFOONHPO(Unity.Entities.Chunk AACHKEHFEHL, int PLLBHNFDGHM, IOHEBCHGDBO IONJMGHHBLL, [Out] ReadOnlySpan<byte> BBFMJKBFLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE21A0", Offset = "0x3DE0FA0", VA = "0x183DE21A0", Slot = "6")]
	internal sealed override bool OPNJPDNCGAJ(int PPBKIGHJOID, Unity.Entities.Chunk AACHKEHFEHL, int PLLBHNFDGHM, [In] ReadOnlySpan<byte> BBFMJKBFLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2421AB0", Offset = "0x24208B0", VA = "0x182421AB0")]
	protected ECJDAOAIKAC<Protobuf> LFLBMIFAMPG<Protobuf>(ReadOnlySpan<Data> JGKKOAMEPPD) where Protobuf : IMessage, new()
	{
		return default(ECJDAOAIKAC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2421B00", Offset = "0x2420900", VA = "0x182421B00")]
	protected MPPPLGBDIPJ<Protobuf> NDAMCKAGICE<Protobuf>(ReadOnlySpan<byte> BBFMJKBFLAL, ReadOnlySpan<Data> JGKKOAMEPPD, Action<Protobuf> JNFHPLOCDDM) where Protobuf : IMessage, new()
	{
		return default(MPPPLGBDIPJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	protected OFLGDODPHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class BJLJODNDBML
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int AJIPJCGCHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF1E0", Offset = "0x5EBDFE0", VA = "0x185EBF1E0", Slot = "5")]
	internal virtual bool EIEAFOONHPO(Unity.Entities.Chunk AACHKEHFEHL, int PLLBHNFDGHM, IOHEBCHGDBO IONJMGHHBLL, [Out] ReadOnlySpan<byte> BBFMJKBFLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "6")]
	internal virtual bool OPNJPDNCGAJ(int PPBKIGHJOID, Unity.Entities.Chunk AACHKEHFEHL, int PLLBHNFDGHM, [In] ReadOnlySpan<byte> BBFMJKBFLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected BJLJODNDBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DJIFOCKBJIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class NALEGIMBCJD : SystemBase, DJIFOCKBJIP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EC09F0", Offset = "0x5EBF7F0", VA = "0x185EC09F0")]
	public ComponentDataFromEntity ANJLNJCJLKF(int LOEGAOKGNFD, bool IBIKAIJHPOK = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0AB0", Offset = "0x5EBF8B0", VA = "0x185EC0AB0")]
	public EntityExistenceLookupByEntity BKPLINPMGLO()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0AD0", Offset = "0x5EBF8D0", VA = "0x185EC0AD0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	protected NALEGIMBCJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class CPAFFEONLMJ : NALEGIMBCJD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF360", Offset = "0x5EBE160", VA = "0x185EBF360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	protected CPAFFEONLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class GEJFOEFNPBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class FCEELKKNLHG : GBCHBMLPGDH
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFB80", Offset = "0x5EBE980", VA = "0x185EBFB80", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase CNFCJJIJBFF();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFB30", Offset = "0x5EBE930", VA = "0x185EBFB30")]
	protected ComponentSystemBase OJBMMDBIFGM(params ComponentSystemBase[] GPMKBOCPMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x24C3160", Offset = "0x24C1F60", VA = "0x1824C3160")]
	protected ComponentSystemBase OJBMMDBIFGM<T>(params ComponentSystemBase[] GPMKBOCPMMA) where T : GBCHBMLPGDH, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x24C3090", Offset = "0x24C1E90", VA = "0x1824C3090")]
	protected ComponentSystemBase JPLMJIIANPF<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x24C3090", Offset = "0x24C1E90", VA = "0x1824C3090")]
	protected ComponentSystemBase HNDOJJKBGJP<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFAE0", Offset = "0x5EBE8E0", VA = "0x185EBFAE0")]
	protected ComponentSystemBase OICIEFAFPPM(params SystemHandleUntyped[] GPMKBOCPMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24C30D0", Offset = "0x24C1ED0", VA = "0x1824C30D0")]
	protected ComponentSystemBase OICIEFAFPPM<T>(params SystemHandleUntyped[] GPMKBOCPMMA) where T : GBCHBMLPGDH, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24C31F0", Offset = "0x24C1FF0", VA = "0x1824C31F0")]
	protected SystemHandleUntyped PMOMCFAPAPG<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF100", Offset = "0x5EBDF00", VA = "0x185EBF100")]
	protected FCEELKKNLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GBCHBMLPGDH : BGLHEHABIPE
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFEF0", Offset = "0x5EBECF0", VA = "0x185EBFEF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF100", Offset = "0x5EBDF00", VA = "0x185EBF100")]
	public GBCHBMLPGDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class BGLHEHABIPE : ComponentSystemGroup, DJIFOCKBJIP
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF100", Offset = "0x5EBDF00", VA = "0x185EBF100")]
	protected BGLHEHABIPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class FLPHKNADKHH : EntityCommandBufferSystem, DJIFOCKBJIP
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	protected FLPHKNADKHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JBPBNHBKBEN<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DDDJIDOKCLB([In] TFrom PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FKJBLEDEDJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFNCBKOIDGD(T PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct NKDDINMCJJF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> DGGFIPBLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer EKKIJNHPHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes NFAFFCFGEAK;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0AE0", Offset = "0x5EBF8E0", VA = "0x185EC0AE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct AFIIMDJENMA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> DGGFIPBLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer EKKIJNHPHBL;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBEF60", Offset = "0x5EBDD60", VA = "0x185EBEF60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CBIKOKGOFGJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> DGGFIPBLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer EKKIJNHPHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType MJKIBEOKGMH;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF1F0", Offset = "0x5EBDFF0", VA = "0x185EBF1F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct IDHADOBLFON<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> DGGFIPBLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> KNAIEKIJLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer EKKIJNHPHBL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3735430", Offset = "0x3734230", VA = "0x183735430", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct OOFPLGEPKAC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> DGGFIPBLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> CMKGLPFECEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer EKKIJNHPHBL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct CGLGBMIEJOE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> DGGFIPBLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T PHPDIJICBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer EKKIJNHPHBL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x49B79D0", Offset = "0x49B67D0", VA = "0x1849B79D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct MIIEKIKLFKJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JBPBNHBKBEN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> OOIIFIKOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> HCGCJJJDONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap CBNAIFNPGEI;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct BFGNLOAGILP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity JGOJPMFIHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> OOIIFIKOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> HCGCJJJDONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int MOLJEKOIGAG;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF000", Offset = "0x5EBDE00", VA = "0x185EBF000", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct JJCMGAHDCIM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JCJONLPJFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> OOIIFIKOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> CCIOLJABOBB;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct ILPDKAELMAM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JBPBNHBKBEN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> FMDNPFPAJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> HCGCJJJDONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap CBNAIFNPGEI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct LMPHLIHOPJH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KKGNNMFDDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> IKPEPKBIELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> DMPDPMOOCEH;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct COFCMKPHKLA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KKGNNMFDDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> IKPEPKBIELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> DMPDPMOOCEH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4A88700", Offset = "0x4A87500", VA = "0x184A88700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct IHEFBPBLANP<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> OOIIFIKOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> CCIOLJABOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> LLNOCJICDNM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3755840", Offset = "0x3754640", VA = "0x183755840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct NCEGFJIFDEH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : JBPBNHBKBEN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> OOIIFIKOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> CCIOLJABOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> LLNOCJICDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap CBNAIFNPGEI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct ANCOFJMBABC<T, TPredicate> : IJob where T : struct where TPredicate : struct, FKJBLEDEDJN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> OOIIFIKOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> AJDIIMGLMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> BGPGAMIEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate CBNAIFNPGEI;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37B7BD0", Offset = "0x37B69D0", VA = "0x1837B7BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct EBKACJLHKEA<T, TPredicate> : IJob where T : struct where TPredicate : struct, FKJBLEDEDJN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> OOIIFIKOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> CCIOLJABOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate CBNAIFNPGEI;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct JNINNJNPILL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity KKGNNMFDDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> IKPEPKBIELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> GFFGHDBHHJI;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC08A0", Offset = "0x5EBF6A0", VA = "0x185EC08A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct JFDPAMGKKMA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity KKGNNMFDDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> IKPEPKBIELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> GFFGHDBHHJI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0810", Offset = "0x5EBF610", VA = "0x185EC0810", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class EHIAEMHIPNF
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class INIHIBBJGGI
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2526570", Offset = "0x2525370", VA = "0x182526570")]
	public static bool MLGMEAJJHGO<T>(this NativeArray<Entity> IKPEPKBIELM, EntityManager FOMHILNOHEE, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BICFIDOBMKJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class FJFOIPABGME<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public FJFOIPABGME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HGNPICMLBCG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public HGNPICMLBCG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> MCKLNJNKBBD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF150", Offset = "0x5EBDF50", VA = "0x185EBF150")]
	public BICFIDOBMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GFDAGIINJEH
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OJGOENMFIAN
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct HKBENEOHHIM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct GDHJLDNFECO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal HKBENEOHHIM<TFrom> BMNEKBHDGLJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> JPKEGLEDKEC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct JJNHFOADNGH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct FIEBMKGGCPO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal JJNHFOADNGH<TFrom> BMNEKBHDGLJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> JPKEGLEDKEC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct FLDOIMAPHHE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct HLDOIOMMJDD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal FLDOIMAPHHE<TFrom> BMNEKBHDGLJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> JPKEGLEDKEC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct EBFIPKCFJMD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct GCNFBAMOACI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal EBFIPKCFJMD<TFrom> BMNEKBHDGLJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> JPKEGLEDKEC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NNKEONCNLPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class BFBAHOHPBIO
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x22A11D0", Offset = "0x229FFD0", VA = "0x1822A11D0")]
	public static NativeList<T> ICIKAHGHNLC<T>(this NativeList<T> GOACONBBCAM, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x22A1050", Offset = "0x229FE50", VA = "0x1822A1050")]
	public static NativeList<T> ICIKAHGHNLC<T>(this NativeArray<T> GOACONBBCAM, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IKIHKFPJFEK
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DBBBJMBOGHH
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2350DF0", Offset = "0x234FBF0", VA = "0x182350DF0")]
	[DMHDLAMBIPA]
	public static JobHandle GDNACNALJJJ<T>(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArrayAsync<Entity> DGGFIPBLDCO, NativeArrayAsync<T> KNAIEKIJLBC, [Optional] JobHandle PEMGLIKCBOK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2351070", Offset = "0x234FE70", VA = "0x182351070")]
	[DMHDLAMBIPA]
	public static JobHandle GDNACNALJJJ<T>(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArrayAsync<Entity> DGGFIPBLDCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2350F50", Offset = "0x234FD50", VA = "0x182350F50")]
	[DMHDLAMBIPA]
	public static JobHandle GDNACNALJJJ<T>(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArray<Entity> DGGFIPBLDCO, [Optional] JobHandle PEMGLIKCBOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF4E0", Offset = "0x5EBE2E0", VA = "0x185EBF4E0")]
	[DMHDLAMBIPA]
	public static JobHandle GDNACNALJJJ(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArray<Entity> DGGFIPBLDCO, ComponentTypes NFAFFCFGEAK, [Optional] JobHandle PEMGLIKCBOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF390", Offset = "0x5EBE190", VA = "0x185EBF390")]
	[DMHDLAMBIPA]
	public static JobHandle GDNACNALJJJ(this EntityCommandBufferSystem JFPGHMPJOPA, EntityCommandBuffer EKKIJNHPHBL, NativeArray<Entity> DGGFIPBLDCO, ComponentTypes NFAFFCFGEAK, [Optional] JobHandle PEMGLIKCBOK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class MJOAAINJDAI
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25806D0", Offset = "0x257F4D0", VA = "0x1825806D0")]
	[DMHDLAMBIPA]
	public static JobHandle MACIAJKFIJB<T>(this EntityCommandBufferSystem JFPGHMPJOPA, EntityCommandBuffer EKKIJNHPHBL, EntityQuery MMDNBDHCAKH, T PHPDIJICBJO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HOEKHEIKGEG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0670", Offset = "0x5EBF470", VA = "0x185EC0670")]
	[DMHDLAMBIPA]
	public static JobHandle JOIENIDLIHM(this EntityCommandBufferSystem JFPGHMPJOPA, NativeList<Entity> DGGFIPBLDCO, [Optional] JobHandle PEMGLIKCBOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0570", Offset = "0x5EBF370", VA = "0x185EC0570")]
	[DMHDLAMBIPA]
	public static JobHandle JOIENIDLIHM(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArrayAsync<Entity> DGGFIPBLDCO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PPAINHAIMND
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x264BB60", Offset = "0x264A960", VA = "0x18264BB60")]
	public static void KHFMMONCJEM<T>(this EntityCommandBufferSystem JFPGHMPJOPA, EntityQuery MMDNBDHCAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x264B910", Offset = "0x264A710", VA = "0x18264B910")]
	[DMHDLAMBIPA]
	public static JobHandle JFAMADKBDKO<T>(this EntityCommandBufferSystem JFPGHMPJOPA, NativeListAsync<Entity> DGGFIPBLDCO, [Optional] JobHandle PEMGLIKCBOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x264B9D0", Offset = "0x264A7D0", VA = "0x18264B9D0")]
	[DMHDLAMBIPA]
	public static JobHandle JFAMADKBDKO<T>(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArrayAsync<Entity> DGGFIPBLDCO, [Optional] JobHandle PEMGLIKCBOK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class AAPMGBMLHPL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF5260", Offset = "0x2AF4060", VA = "0x182AF5260")]
	[DMHDLAMBIPA]
	public static JobHandle HMENAEBIKHD<T>(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArray<Entity> DGGFIPBLDCO, NativeArray<T> KNAIEKIJLBC, JobHandle PEMGLIKCBOK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class NINOCDJLMHN
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2606080", Offset = "0x2604E80", VA = "0x182606080")]
	[DMHDLAMBIPA]
	public static JobHandle EFBANHOFKCM<T>(this EntityCommandBufferSystem JFPGHMPJOPA, NativeArray<Entity> DGGFIPBLDCO, T PHPDIJICBJO, [Optional] JobHandle PEMGLIKCBOK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2606160", Offset = "0x2604F60", VA = "0x182606160")]
	[DMHDLAMBIPA]
	public static JobHandle EFBANHOFKCM<T>(this EntityCommandBufferSystem JFPGHMPJOPA, EntityCommandBuffer EKKIJNHPHBL, NativeArray<Entity> DGGFIPBLDCO, T PHPDIJICBJO, [Optional] JobHandle PEMGLIKCBOK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class JFOHDDEBJEM
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x253B1F0", Offset = "0x2539FF0", VA = "0x18253B1F0")]
	public static NativeList<T> ICIKAHGHNLC<T>(NativeList<T> GOACONBBCAM, Allocator DGKNIHLPENE) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GIMEAIGMIAD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x24F7830", Offset = "0x24F6630", VA = "0x1824F7830")]
	public static NativeArray<T> LCFMEKIEELK<T>(this NativeList<Entity> GOACONBBCAM, EntityManager FOMHILNOHEE, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x24F74B0", Offset = "0x24F62B0", VA = "0x1824F74B0")]
	public static NativeArray<T> LCFMEKIEELK<T>(this NativeArray<Entity> GOACONBBCAM, EntityManager FOMHILNOHEE, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFF20", Offset = "0x5EBED20", VA = "0x185EBFF20")]
	public static NativeArray<Entity> BKMNCAKCFDD(this NativeArray<Entity> GOACONBBCAM, EntityManager FOMHILNOHEE, ComponentType MJKIBEOKGMH, Allocator DGKNIHLPENE = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x24F73D0", Offset = "0x24F61D0", VA = "0x1824F73D0")]
	public static NativeArray<T> HAEIMGIBOJF<T>(this NativeArray<Entity> GOACONBBCAM, EntityManager FOMHILNOHEE, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class JHHFMEDENMK
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct COPCMCPHOOJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct JFANMHKMHKD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public COPCMCPHOOJ<TFrom> JPKEGLEDKEC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> OOIIFIKOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct EANAFJLOOJE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct HLNBEOPICCP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public EANAFJLOOJE<TFrom> JPKEGLEDKEC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> OOIIFIKOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EFEDNBIAEDE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct AFINKGFJEPE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public EFEDNBIAEDE<TFrom> JPKEGLEDKEC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> OOIIFIKOHCN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class EBPKIIPCEEK
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HPLHBIBMGDB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct DCFMALPLECE : JBPBNHBKBEN<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> FKEMOIMMIMI;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF650", Offset = "0x5EBE450", VA = "0x185EBF650")]
		[BurstCompatible]
		public Entity DDDJIDOKCLB([In] Entity PHPDIJICBJO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF650", Offset = "0x5EBE450", VA = "0x185EBF650", Slot = "4")]
		private Entity MFEJGBIGJJN([In] Entity PHPDIJICBJO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class JCMFGBAPKKK
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct JEEJKPACKLL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> AJDIIMGLMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> OOIIFIKOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct BGPBICCPJNP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> AJDIIMGLMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> OOIIFIKOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MPNEKPMIMGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> AJDIIMGLMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> OOIIFIKOHCN;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x241BDC0", Offset = "0x241ABC0", VA = "0x18241BDC0")]
		public NativeListAsync<Entity> LFNCBKOIDGD<TPredicate>() where TPredicate : struct, FKJBLEDEDJN<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2537B40", Offset = "0x2536940", VA = "0x182537B40")]
	public static MPNEKPMIMGI<T> KIEDNFODCIA<T>(this NativeArrayAsync<Entity> IKPEPKBIELM, NativeArrayAsync<T> GOACONBBCAM, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct
	{
		return default(MPNEKPMIMGI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class DIMKNHPKJPL
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x235D830", Offset = "0x235C630", VA = "0x18235D830")]
	public static NativeListAsync<Entity> PLEINOHBNGG<T, TPredicate>(this NativeArrayAsync<T> GOACONBBCAM, NativeArrayAsync<Entity> IKPEPKBIELM, Allocator DGKNIHLPENE = Allocator.TempJob) where T : struct where TPredicate : struct, FKJBLEDEDJN<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x235D690", Offset = "0x235C490", VA = "0x18235D690")]
	private static NativeListAsync<Entity> HKCLGCDHOAI<T, TPredicate>(NativeArrayAsync<T> OHJNGHILBKP, NativeArrayAsync<Entity> IKPEPKBIELM, int ELGJIDFGJJH, Allocator DGKNIHLPENE) where T : struct where TPredicate : struct, FKJBLEDEDJN<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class NHLDLGGDOFK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct NKMGMNNBBDP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> OOIIFIKOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ABJAFBIIGHK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> OOIIFIKOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct OPFAOALLCMA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> OOIIFIKOHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct IBEHJAFHMJO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator DGKNIHLPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> OOIIFIKOHCN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class GOOEALAPIOD
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class BMIBHDMAPMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22B16B0", Offset = "0x22B04B0", VA = "0x1822B16B0")]
	public static NativeList<Entity> LOBDOICLIJL<T>(this NativeArray<Entity> IKPEPKBIELM, EntityManager FOMHILNOHEE, Allocator DGKNIHLPENE = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class ENCHNLHENKA
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class JJOOBEDGAKK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct PFBFDJCHIMK<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> LPMIAHOCPLL;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
		public PFBFDJCHIMK(NativeArray<TSrc> LPMIAHOCPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public HBBDFNJHHCO<TSrc, TValue> PDHLHLOCBHA<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(HBBDFNJHHCO<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct HBBDFNJHHCO<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> LPMIAHOCPLL;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
		public HBBDFNJHHCO(NativeArray<TSrc> LPMIAHOCPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public LKKOMNBCNKJ<TSrc, TValue, TSelector> MKGPMMJOKJH<TSelector>() where TSelector : struct, JBPBNHBKBEN<TSrc, TValue>
		{
			return default(LKKOMNBCNKJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct LKKOMNBCNKJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JBPBNHBKBEN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> LPMIAHOCPLL;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
		public LKKOMNBCNKJ(NativeArray<TSrc> LPMIAHOCPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3AC1890", Offset = "0x3AC0690", VA = "0x183AC1890")]
		public OAHFKJAKCKB<TSrc, TValue, TSelector> OJBMMDBIFGM()
		{
			return default(OAHFKJAKCKB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct NCDILFEGACF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, JBPBNHBKBEN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> LPMIAHOCPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector NLDGEDJBHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int NGIPPLLBEKC;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3D07DC0", Offset = "0x3D06BC0", VA = "0x183D07DC0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int FNPAHLCJLFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x95BB00", Offset = "0x95A900", VA = "0x18095BB00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int DLGHEHGPEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CCB4E0", Offset = "0x1CCA2E0", VA = "0x181CCB4E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D07F40", Offset = "0x3D06D40", VA = "0x183D07F40")]
		public NCDILFEGACF(NativeArray<TSrc> LPMIAHOCPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D07F30", Offset = "0x3D06D30", VA = "0x183D07F30")]
		public bool PMAPCGLEDLM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D07E50", Offset = "0x3D06C50", VA = "0x183D07E50")]
		private TSrc NFPIHBFHJEB(int POGGKDPIPDP)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct OAHFKJAKCKB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JBPBNHBKBEN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NCDILFEGACF<TSrc, TValue, TSelector> JDNLPJMOHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue DCHIBBFPFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int FNPACLAMELJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KDKIAPJNAEK JBIDIPBGBPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD8A0", Offset = "0x3DDC6A0", VA = "0x183DDD8A0")]
			get
			{
				return default(KDKIAPJNAEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue PINOEGEKJKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x774610", Offset = "0x773410", VA = "0x180774610")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, KDKIAPJNAEK range) POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD8E0", Offset = "0x3DDC6E0", VA = "0x183DDD8E0")]
			get
			{
				return default((TValue, KDKIAPJNAEK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDB00", Offset = "0x3DDC900", VA = "0x183DDDB00")]
		public OAHFKJAKCKB(NativeArray<TSrc> LPMIAHOCPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x345B100", Offset = "0x3459F00", VA = "0x18345B100")]
		public OAHFKJAKCKB<TSrc, TValue, TSelector> NABGDMMLCNI()
		{
			return default(OAHFKJAKCKB<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD9C0", Offset = "0x3DDC7C0", VA = "0x183DDD9C0")]
		public bool PMAPCGLEDLM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x253CB10", Offset = "0x253B910", VA = "0x18253CB10")]
	public static PFBFDJCHIMK<T> GHBGGOEAGKH<T>(this NativeList<T> LCPNBOPPGBK) where T : struct
	{
		return default(PFBFDJCHIMK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
	public static PFBFDJCHIMK<T> GHBGGOEAGKH<T>(this NativeArray<T> LPMIAHOCPLL) where T : struct
	{
		return default(PFBFDJCHIMK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GLCJDEOIOLC
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct GFILJCJHOFN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly LPMIAHOCPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int FNPACLAMELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int LBKBNPDABOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T DCHIBBFPFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T DJBJBIGNDGM;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public KDKIAPJNAEK JBIDIPBGBPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x35BAEA0", Offset = "0x35B9CA0", VA = "0x1835BAEA0")]
			get
			{
				return default(KDKIAPJNAEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T PINOEGEKJKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x30FA970", Offset = "0x30F9770", VA = "0x1830FA970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, KDKIAPJNAEK) POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x35BAEB0", Offset = "0x35B9CB0", VA = "0x1835BAEB0")]
			get
			{
				return default((T, KDKIAPJNAEK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x35BB490", Offset = "0x35BA290", VA = "0x1835BB490")]
		public GFILJCJHOFN(NativeArray<T> LPMIAHOCPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x35BB030", Offset = "0x35B9E30", VA = "0x1835BB030")]
		public GFILJCJHOFN<T> NABGDMMLCNI()
		{
			return default(GFILJCJHOFN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x35BB240", Offset = "0x35BA040", VA = "0x1835BB240")]
		public bool PMAPCGLEDLM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x237B390", Offset = "0x237A190", VA = "0x18237B390")]
		public JOGGDELGBHF<T, TComparer> DJLMPLDBJNA<TComparer>([Optional] TComparer DCHLDOKAMLA) where TComparer : struct, IEqualityComparer<T>
		{
			return default(JOGGDELGBHF<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct JOGGDELGBHF<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly LPMIAHOCPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int FNPACLAMELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int LBKBNPDABOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T DCHIBBFPFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T DJBJBIGNDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer DCHLDOKAMLA;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KDKIAPJNAEK JBIDIPBGBPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x35BAEA0", Offset = "0x35B9CA0", VA = "0x1835BAEA0")]
			get
			{
				return default(KDKIAPJNAEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T PINOEGEKJKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x30FA970", Offset = "0x30F9770", VA = "0x1830FA970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, KDKIAPJNAEK range) POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x39CB9A0", Offset = "0x39CA7A0", VA = "0x1839CB9A0")]
			get
			{
				return default((T, KDKIAPJNAEK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x39CBC90", Offset = "0x39CAA90", VA = "0x1839CBC90")]
		public JOGGDELGBHF(NativeArray<T>.ReadOnly LPMIAHOCPLL, TComparer DCHLDOKAMLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x39CBA70", Offset = "0x39CA870", VA = "0x1839CBA70")]
		public JOGGDELGBHF<T, TComparer> NABGDMMLCNI()
		{
			return default(JOGGDELGBHF<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x39CBAB0", Offset = "0x39CA8B0", VA = "0x1839CBAB0")]
		public bool PMAPCGLEDLM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x25000F0", Offset = "0x24FEEF0", VA = "0x1825000F0")]
	public static GFILJCJHOFN<T> OJBMMDBIFGM<T>(this NativeArray<T> LPMIAHOCPLL) where T : struct
	{
		return default(GFILJCJHOFN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface DEHOMKOIJAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class KNJFPFCMPDL
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct MPPPLGBDIPJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class MFKBNIMNJPD : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MPPPLGBDIPJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9C95C0", Offset = "0x9C83C0", VA = "0x1809C95C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34C83E0", Offset = "0x34C71E0", VA = "0x1834C83E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public MFKBNIMNJPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3CA19A0", Offset = "0x3CA07A0", VA = "0x183CA19A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1B50", Offset = "0x3CA0950", VA = "0x183CA1B50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> JNFHPLOCDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream PCDNEJJECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream BBELEJNFPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf GGBHHHJMLNM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int DLGHEHGPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAD10", Offset = "0x3CC9B10", VA = "0x183CCAD10")]
	private MPPPLGBDIPJ(byte[] BNFLLCFHIAN, Action<Protobuf> JNFHPLOCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x241BE30", Offset = "0x241AC30", VA = "0x18241BE30")]
	public static MPPPLGBDIPJ<Protobuf> CBILMLOBPDD<Data>(ReadOnlySpan<byte> BBFMJKBFLAL, ReadOnlySpan<Data> JGKKOAMEPPD, Action<Protobuf> JNFHPLOCDDM)
	{
		return default(MPPPLGBDIPJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAB80", Offset = "0x3CC9980", VA = "0x183CCAB80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3CCABC0", Offset = "0x3CC99C0", VA = "0x183CCABC0", Slot = "4")]
	[IteratorStateMachine(typeof(MPPPLGBDIPJ<>.MFKBNIMNJPD))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3CCACB0", Offset = "0x3CC9AB0", VA = "0x183CCACB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct ECJDAOAIKAC<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] BNFLLCFHIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf GGBHHHJMLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream PCDNEJJECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream IAFAKBCBEOD;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x30D0170", Offset = "0x30CEF70", VA = "0x1830D0170")]
	private ECJDAOAIKAC(byte[] BNFLLCFHIAN, [In] Protobuf GGBHHHJMLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E05350", Offset = "0x2E04150", VA = "0x182E05350")]
	public static ECJDAOAIKAC<Protobuf> CBILMLOBPDD<T>(ReadOnlySpan<T> JGKKOAMEPPD)
	{
		return default(ECJDAOAIKAC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x30D00B0", Offset = "0x30CEEB0", VA = "0x1830D00B0")]
	public void IHJFCJMOGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x30D00E0", Offset = "0x30CEEE0", VA = "0x1830D00E0")]
	public ByteString IPPNCJBKMGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x30CFF80", Offset = "0x30CED80", VA = "0x1830CFF80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DGMONDFOPGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream PCDNEJJECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream BBELEJNFPPI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF660", Offset = "0x5EBE460", VA = "0x185EBF660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct HOEJGKAKCCO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] BNFLLCFHIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream PCDNEJJECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream IAFAKBCBEOD;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0440", Offset = "0x5EBF240", VA = "0x185EC0440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class FLCJIALFDPO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void JKAHMEIAGFA<From, To>(From JPKEGLEDKEC, To LLIDMGAMJNA, IOHEBCHGDBO IONJMGHHBLL);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class BBNFFECDOPA<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static JKAHMEIAGFA<From, To> CENFMEOJBFI;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public BBNFFECDOPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFC20", Offset = "0x5EBEA20", VA = "0x185EBFC20")]
	static FLCJIALFDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x24D13F0", Offset = "0x24D01F0", VA = "0x1824D13F0")]
	public static void IDDCFEPPMJK<T>(JKAHMEIAGFA<T, T> BEGLEGBGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x24D1E30", Offset = "0x24D0C30", VA = "0x1824D1E30")]
	public static void IDDCFEPPMJK<From, To>(JKAHMEIAGFA<From, To> BEGLEGBGPKO, JKAHMEIAGFA<To, From> CMMGEMAGPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x24D1100", Offset = "0x24CFF00", VA = "0x1824D1100")]
	public static void IDDCFEPPMJK<From, To>(JKAHMEIAGFA<From, To> CENFMEOJBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x24C9A10", Offset = "0x24C8810", VA = "0x1824C9A10")]
	public static JKAHMEIAGFA<From, To> BJEAGNAJELI<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x24CEC20", Offset = "0x24CDA20", VA = "0x1824CEC20")]
	public static void FLCBGNNKFMJ<From, To>(From JPKEGLEDKEC, To LLIDMGAMJNA, IOHEBCHGDBO IONJMGHHBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class IOHEBCHGDBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> IMBLCLHMBBP;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1C90D80", Offset = "0x1C8FB80", VA = "0x181C90D80")]
	public IOHEBCHGDBO(NativeArray<EntityRemapUtility.EntityRemapInfo> IMBLCLHMBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0800", Offset = "0x5EBF600", VA = "0x185EC0800")]
	public Entity OBFDEHBDNMG(Entity KFIJLJLHGLL)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class CDFMFNGMNDD
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF270", Offset = "0x5EBE070", VA = "0x185EBF270")]
	public static ulong IFINGICPBKP(Type AOPDMLJGEMB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF300", Offset = "0x5EBE100", VA = "0x185EBF300")]
	public static ulong IFINGICPBKP(string EPBCFBLKMFD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum CAMDKKDBOGB
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
public class PCHFDNBDPCN : AKHEGHBFDGH
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	public PCHFDNBDPCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class GOELEELAAKK
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0100", Offset = "0x5EBEF00", VA = "0x185EC0100")]
	private unsafe static Span<byte> LLCDLMGJLAM(Unity.Entities.Chunk* AACHKEHFEHL, int PLLBHNFDGHM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2500AE0", Offset = "0x24FF8E0", VA = "0x182500AE0")]
	public unsafe static Span<T> GLEACNJOOOP<T>(Unity.Entities.Chunk* AACHKEHFEHL, int PLLBHNFDGHM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x232DDD0", Offset = "0x232CBD0", VA = "0x18232DDD0")]
	public static Span<T> GLEACNJOOOP<T>(this Unity.Entities.Chunk AACHKEHFEHL, int PLLBHNFDGHM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0340", Offset = "0x5EBF140", VA = "0x185EC0340")]
	public unsafe static Span<Entity> MOMOLDKPMHI(Unity.Entities.Chunk* AACHKEHFEHL)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EC01D0", Offset = "0x5EBEFD0", VA = "0x185EC01D0")]
	public unsafe static void LPNBJONBLDG(Unity.Entities.Chunk* AACHKEHFEHL, int PLLBHNFDGHM)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DBFEEPAPMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DBFEEPAPMKO()
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
