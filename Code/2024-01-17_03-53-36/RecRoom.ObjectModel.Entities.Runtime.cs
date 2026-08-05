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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60B0350", Offset = "0x60AF150", VA = "0x1860B0350")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KFIGDCKBJOD<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] PJCPNNLPHCB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22FA380", Offset = "0x22F9180", VA = "0x1822FA380")]
	public static void AFOAKANGAKK<TField>(int HPLKFBKKIBG, string AOAIBMOPKPE, DDBCKCLNIOE MMEIKJNHFEL, [Out] JIAOBKHOMPF<TField> LEDLMNEPNJE) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22FBE30", Offset = "0x22FAC30", VA = "0x1822FBE30")]
	public static void ELCMKMCMIJC<TField>(int HPLKFBKKIBG, string AOAIBMOPKPE, [Out] MEBHGJLELIG<TField> JBACKDCMGLH) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class KPECAKIGIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60B12C0", Offset = "0x60B00C0", VA = "0x1860B12C0")]
	public static FieldInfo[] NFCHOAFKONK(Type HJCFEPLFGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class IGLAMOPEMDA<View, Data> : JKEAFBAHBNF where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType BOBGMBIGEPA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type JKOBEIFIMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x380D480", Offset = "0x380C280", VA = "0x18380D480", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int MAODPBAGCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x380E500", Offset = "0x380D300", VA = "0x18380E500", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x380C0A0", Offset = "0x380AEA0", VA = "0x18380C0A0")]
	public Data EDBBGGKGNEG(Entity NIELJJHKFLG)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View BOKOMHJCOHJ(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21A8C60", Offset = "0x21A7A60", VA = "0x1821A8C60", Slot = "14")]
	public override T BOKOMHJCOHJ<T>(Entity NIELJJHKFLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
	protected IGLAMOPEMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class JKEAFBAHBNF : DDBCKCLNIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle OMEBDFILOPF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager GKADDEKPDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x128CA30", Offset = "0x128B830", VA = "0x18128CA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type JKOBEIFIMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int MAODPBAGCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type EICBGIKILCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9954D0", Offset = "0x9942D0", VA = "0x1809954D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BAGEFBJMLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60B0920", Offset = "0x60AF720", VA = "0x1860B0920", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private GEFBJHFMKHE[] JOCDNOKKDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F739C0", Offset = "0x1F727C0", VA = "0x181F739C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual GEFBJHFMKHE[] FIHONKOGBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60B0890", Offset = "0x60AF690", VA = "0x1860B0890", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60B0750", Offset = "0x60AF550", VA = "0x1860B0750")]
	public void CGDOOEBPPMG(EntityManager HGAJDDKIMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T BOKOMHJCOHJ<T>(Entity NIELJJHKFLG) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60B0990", Offset = "0x60AF790", VA = "0x1860B0990", Slot = "8")]
	public (uint, uint) HLEFJOHMEAI(Entity NIELJJHKFLG)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60B0A80", Offset = "0x60AF880", VA = "0x1860B0A80", Slot = "9")]
	public bool MOEGMMKOFFJ(Entity NIELJJHKFLG, (uint order, uint change) ECDEHLGBDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected JKEAFBAHBNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HDAFBEOEEIH
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FEPAHLENIMG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HCHIKDMPJJN CCIAFJEOACB
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
public interface JPLKDKEFDAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOKCGOPKLAO(Entity NIELJJHKFLG, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGGGDHPBFOP(Entity NIELJJHKFLG, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHMBPCJDDCC(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BPNBIEDIBAP(Entity NIELJJHKFLG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BPJAKJJIGEK<TComponentData, TValue> : FOEDPGPBEPC<TValue>, IDisposable where TComponentData : struct, FEPAHLENIMG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GJLAKFELCHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> HFLDOAFOIEF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OBAHNCBLFMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x305E230", Offset = "0x305D030", VA = "0x18305E230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x36E6040", Offset = "0x36E4E40", VA = "0x1836E6040")]
		public bool MAODHPJOKIL([Out] TValue MBDKMNBCLGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x36E5F90", Offset = "0x36E4D90", VA = "0x1836E5F90")]
		public void EHPBILHDFGD(object CGFEMNMBCOK, TValue MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x36E5E30", Offset = "0x36E4C30", VA = "0x1836E5E30")]
		public bool CPMMAHJGJAD(object CGFEMNMBCOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x36E5EB0", Offset = "0x36E4CB0", VA = "0x1836E5EB0")]
		public int DEEONMHMHKI(object CGFEMNMBCOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x36E6130", Offset = "0x36E4F30", VA = "0x1836E6130")]
		public GJLAKFELCHG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<GJLAKFELCHG> OPADAFHDDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GBLMFCPFHDC<HCHIKDMPJJN, GJLAKFELCHG> PBIJFILAOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager HGAJDDKIMHE;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x46BE4A0", Offset = "0x46BD2A0", VA = "0x1846BE4A0")]
	public BPJAKJJIGEK(EntityManager HGAJDDKIMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x46BDD50", Offset = "0x46BCB50", VA = "0x1846BDD50", Slot = "4")]
	public void DOKCGOPKLAO(Entity NIELJJHKFLG, object CGFEMNMBCOK, TValue MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x46BE2E0", Offset = "0x46BD0E0", VA = "0x1846BE2E0", Slot = "5")]
	public bool OGGGDHPBFOP(Entity NIELJJHKFLG, object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x46BE0F0", Offset = "0x46BCEF0", VA = "0x1846BE0F0", Slot = "6")]
	public bool MAODHPJOKIL(Entity NIELJJHKFLG, [Out] TValue MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46BDE90", Offset = "0x46BCC90", VA = "0x1846BDE90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46BE060", Offset = "0x46BCE60", VA = "0x1846BE060")]
	private void KGOMOAAOODF(GJLAKFELCHG FOJJJFKLLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46BDFA0", Offset = "0x46BCDA0", VA = "0x1846BDFA0")]
	private bool FFCPOIDMGBL(Entity NIELJJHKFLG, [Out] HCHIKDMPJJN MMNFNIFHOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46BE1F0", Offset = "0x46BCFF0", VA = "0x1846BE1F0")]
	private void NNOILPFBPND(Entity NIELJJHKFLG, HCHIKDMPJJN MMNFNIFHOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x46BE480", Offset = "0x46BD280", VA = "0x1846BE480")]
	private bool PONFLJOHMCN(HCHIKDMPJJN MMNFNIFHOJK, [Out] GJLAKFELCHG FOJJJFKLLLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x46BDEB0", Offset = "0x46BCCB0", VA = "0x1846BDEB0")]
	private GJLAKFELCHG ENFGMBMNPJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FOEDPGPBEPC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOKCGOPKLAO(Entity NIELJJHKFLG, object CGFEMNMBCOK, TValue MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGGGDHPBFOP(Entity NIELJJHKFLG, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAODHPJOKIL(Entity NIELJJHKFLG, [Out] TValue MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HCHIKDMPJJN : ONJJIHMMNEI, IEquatable<HCHIKDMPJJN>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly HCHIKDMPJJN GLJJGFPGJLG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int IMILALJBIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x885850", Offset = "0x884650", VA = "0x180885850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int ECKMEMMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2152A80", Offset = "0x2151880", VA = "0x182152A80", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x545E620", Offset = "0x545D420", VA = "0x18545E620", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60B0680", Offset = "0x60AF480", VA = "0x1860B0680", Slot = "8")]
	public bool Equals(HCHIKDMPJJN GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60B06D0", Offset = "0x60AF4D0", VA = "0x1860B06D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PCBACPMKEIF<THasTokensTag> : JPLKDKEFDAJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IBJKCJFAAOH LHKCFFJGAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, HCHIKDMPJJN> IBEJGHPMLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> OPADAFHDDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GBLMFCPFHDC<HCHIKDMPJJN, HashSet<object>> PBIJFILAOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager HGAJDDKIMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem PGKJCMGDHPG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3F8F6A0", Offset = "0x3F8E4A0", VA = "0x183F8F6A0")]
	public PCBACPMKEIF(EntityManager HGAJDDKIMHE, EntityCommandBufferSystem PGKJCMGDHPG, IBJKCJFAAOH BDPBPBFFFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C550", Offset = "0x3F8B350", VA = "0x183F8C550", Slot = "4")]
	public bool DOKCGOPKLAO(Entity NIELJJHKFLG, object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F8E210", Offset = "0x3F8D010", VA = "0x183F8E210", Slot = "5")]
	public bool OGGGDHPBFOP(Entity NIELJJHKFLG, object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D6D0", Offset = "0x3F8C4D0", VA = "0x183F8D6D0", Slot = "6")]
	public bool NHMBPCJDDCC(Entity NIELJJHKFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D760", Offset = "0x3F8C560", VA = "0x183F8D760", Slot = "9")]
	public bool NHMBPCJDDCC(HCHIKDMPJJN MMNFNIFHOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C070", Offset = "0x3F8AE70", VA = "0x183F8C070", Slot = "7")]
	public bool BPNBIEDIBAP(Entity NIELJJHKFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C9E0", Offset = "0x3F8B7E0", VA = "0x183F8C9E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D540", Offset = "0x3F8C340", VA = "0x183F8D540")]
	private void KGOMOAAOODF(HashSet<object> FOJJJFKLLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F8CE00", Offset = "0x3F8BC00", VA = "0x183F8CE00")]
	private bool FFCPOIDMGBL(Entity NIELJJHKFLG, [Out] HCHIKDMPJJN MMNFNIFHOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BB30", Offset = "0x3F8A930", VA = "0x183F8BB30")]
	private bool ANHFOLJIGDH(Entity NIELJJHKFLG, [Out] HCHIKDMPJJN MMNFNIFHOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F8EB50", Offset = "0x3F8D950", VA = "0x183F8EB50")]
	private void PJMBJBJIPAM(Entity NIELJJHKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3F8E5A0", Offset = "0x3F8D3A0", VA = "0x183F8E5A0")]
	private void OHNKLALCNDA(Entity NIELJJHKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3F8EA50", Offset = "0x3F8D850", VA = "0x183F8EA50")]
	private void PEAJFANAGNE(Entity NIELJJHKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8DB00", Offset = "0x3F8C900", VA = "0x183F8DB00")]
	private void NNOILPFBPND(Entity NIELJJHKFLG, HCHIKDMPJJN MMNFNIFHOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D270", Offset = "0x3F8C070", VA = "0x183F8D270")]
	private bool GKIPGHLPDGK(HCHIKDMPJJN MMNFNIFHOJK, [Out] HashSet<object> FOJJJFKLLLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3F8CCC0", Offset = "0x3F8BAC0", VA = "0x183F8CCC0")]
	private HashSet<object> ENFGMBMNPJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FMBHLDHFILN
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CFGELAIICNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int PNNJJHFFONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int KGLOPMIHJGF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ICGAHFEOGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2152A80", Offset = "0x2151880", VA = "0x182152A80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x545E620", Offset = "0x545D420", VA = "0x18545E620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EJIPMCECIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x885850", Offset = "0x884650", VA = "0x180885850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int APJJALPOAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60AFC80", Offset = "0x60AEA80", VA = "0x1860AFC80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60AFC60", Offset = "0x60AEA60", VA = "0x1860AFC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA34EB0", Offset = "0xA33CB0", VA = "0x180A34EB0")]
	private CFGELAIICNI(int PNNJJHFFONP, int KGLOPMIHJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D26C00", Offset = "0x1D25A00", VA = "0x181D26C00")]
	public static CFGELAIICNI MKLDBMLOPEE(int PNNJJHFFONP, int KGLOPMIHJGF)
	{
		return default(CFGELAIICNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60AFC70", Offset = "0x60AEA70", VA = "0x1860AFC70")]
	public static CFGELAIICNI IHJBONIDJGH(int GMKGLLAPKMM, int KKCAHMFFJFH)
	{
		return default(CFGELAIICNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60AFC90", Offset = "0x60AEA90", VA = "0x1860AFC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AHJEHHCHLJB : BABHHMPOABL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6094910", Offset = "0x6093710", VA = "0x186094910")]
	public float DHMFLLFAIHD([In] float3 MBDKMNBCLGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6094910", Offset = "0x6093710", VA = "0x186094910", Slot = "4")]
	private float IFIJJFKLOHK([In] float3 MBDKMNBCLGF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NHBMGPMJFDH : BABHHMPOABL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60941F0", Offset = "0x6092FF0", VA = "0x1860941F0")]
	public float DHMFLLFAIHD([In] float3 MBDKMNBCLGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60941F0", Offset = "0x6092FF0", VA = "0x1860941F0", Slot = "4")]
	private float IFIJJFKLOHK([In] float3 MBDKMNBCLGF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NKPDGCCFIFB : BABHHMPOABL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19D78F0", Offset = "0x19D66F0", VA = "0x1819D78F0")]
	public float DHMFLLFAIHD([In] float3 MBDKMNBCLGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x19D78F0", Offset = "0x19D66F0", VA = "0x1819D78F0", Slot = "4")]
	private float IFIJJFKLOHK([In] float3 MBDKMNBCLGF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OKHMALNCKLL : BABHHMPOABL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x13155F0", Offset = "0x13143F0", VA = "0x1813155F0")]
	public int DHMFLLFAIHD([In] int3 MBDKMNBCLGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x13155F0", Offset = "0x13143F0", VA = "0x1813155F0", Slot = "4")]
	private int LCKNEGMHBKB([In] int3 MBDKMNBCLGF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FBMPCBENBLH : BABHHMPOABL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6096FE0", Offset = "0x6095DE0", VA = "0x186096FE0")]
	public int DHMFLLFAIHD([In] int3 MBDKMNBCLGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6096FE0", Offset = "0x6095DE0", VA = "0x186096FE0", Slot = "4")]
	private int LCKNEGMHBKB([In] int3 MBDKMNBCLGF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FDCELIKKKBD : BABHHMPOABL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15DE730", Offset = "0x15DD530", VA = "0x1815DE730")]
	public int DHMFLLFAIHD([In] int3 MBDKMNBCLGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x15DE730", Offset = "0x15DD530", VA = "0x1815DE730", Slot = "4")]
	private int LCKNEGMHBKB([In] int3 MBDKMNBCLGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LGOPKKNDBJE : KCIILHAHFBL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type ADFOJCAKFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type EADLGIGLIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60B1400", Offset = "0x60B0200", VA = "0x1860B1400")]
	public LGOPKKNDBJE(Type LPHPELECCAO, Type KJKFKAMFBFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NKPEIJMFJDG : KCIILHAHFBL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type EADLGIGLIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC9C0", Offset = "0x5FBB7C0", VA = "0x185FBC9C0")]
	public NKPEIJMFJDG(Type KJKFKAMFBFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GCOIJJLGMPP : KCIILHAHFBL
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	public GCOIJJLGMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class MAEEIJFMJKC<Data> : EJMFCDCFPPN where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data DOPLKALBEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D37C30", Offset = "0x3D36A30", VA = "0x183D37C30", Slot = "8")]
	protected virtual bool LNIFABBKIEO(ReadOnlySpan<Data> PBMGHICHJGB, DNIKMALCLMO HKBPEKNGMMF, [Out] ReadOnlySpan<byte> MEFCHKNPKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "9")]
	protected virtual bool KGLCPAMNNGF(int ECDEHLGBDJN, Span<Data> PBMGHICHJGB, [In] ReadOnlySpan<byte> MEFCHKNPKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3D37B70", Offset = "0x3D36970", VA = "0x183D37B70", Slot = "5")]
	internal sealed override bool LNIFABBKIEO(Unity.Entities.Chunk GHHBKLNJKGA, int NHIEDLDADJG, DNIKMALCLMO HKBPEKNGMMF, [Out] ReadOnlySpan<byte> MEFCHKNPKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3D35F80", Offset = "0x3D34D80", VA = "0x183D35F80", Slot = "6")]
	internal sealed override bool KGLCPAMNNGF(int ECDEHLGBDJN, Unity.Entities.Chunk GHHBKLNJKGA, int NHIEDLDADJG, [In] ReadOnlySpan<byte> MEFCHKNPKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2309760", Offset = "0x2308560", VA = "0x182309760")]
	protected NOBOOAFDMMN<Protobuf> NGMIPNMFEHB<Protobuf>(ReadOnlySpan<Data> PBMGHICHJGB) where Protobuf : IMessage, new()
	{
		return default(NOBOOAFDMMN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23096E0", Offset = "0x23084E0", VA = "0x1823096E0")]
	protected JBDJAFCFAAO<Protobuf> GHHEHBCBDDI<Protobuf>(ReadOnlySpan<byte> MEFCHKNPKLC, ReadOnlySpan<Data> PBMGHICHJGB, Action<Protobuf> EGHEEJLKBGC) where Protobuf : IMessage, new()
	{
		return default(JBDJAFCFAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
	protected MAEEIJFMJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class EJMFCDCFPPN
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int ECKMEMMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60B0340", Offset = "0x60AF140", VA = "0x1860B0340", Slot = "5")]
	internal virtual bool LNIFABBKIEO(Unity.Entities.Chunk GHHBKLNJKGA, int NHIEDLDADJG, DNIKMALCLMO HKBPEKNGMMF, [Out] ReadOnlySpan<byte> MEFCHKNPKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "6")]
	internal virtual bool KGLCPAMNNGF(int ECDEHLGBDJN, Unity.Entities.Chunk GHHBKLNJKGA, int NHIEDLDADJG, [In] ReadOnlySpan<byte> MEFCHKNPKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected EJMFCDCFPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NFLDJDLKDOP
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class GOGPLKIJIKM : SystemBase, NFLDJDLKDOP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60B0430", Offset = "0x60AF230", VA = "0x1860B0430")]
	public ComponentDataFromEntity JFMALMBEIOJ(int KIGJOKGNLCM, bool KHKANBPBGLH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60B0410", Offset = "0x60AF210", VA = "0x1860B0410")]
	public EntityExistenceLookupByEntity HIJCDPJHKNF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60B04F0", Offset = "0x60AF2F0", VA = "0x1860B04F0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	protected GOGPLKIJIKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class IDFOLEEFGJG : GOGPLKIJIKM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60B0720", Offset = "0x60AF520", VA = "0x1860B0720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	protected IDFOLEEFGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class JEHOKBHOCPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class KJJLGIDAAPA : BBELIIJOKCP
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60B1270", Offset = "0x60B0070", VA = "0x1860B1270", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase COOJDEDOEGE();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60B1220", Offset = "0x60B0020", VA = "0x1860B1220")]
	protected ComponentSystemBase CMAIFKIHHHN(params ComponentSystemBase[] POHLIFJCECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2620150", Offset = "0x261EF50", VA = "0x182620150")]
	protected ComponentSystemBase CMAIFKIHHHN<T>(params ComponentSystemBase[] POHLIFJCECD) where T : BBELIIJOKCP, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2620110", Offset = "0x261EF10", VA = "0x182620110")]
	protected ComponentSystemBase BJFPMGLDFKA<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2620110", Offset = "0x261EF10", VA = "0x182620110")]
	protected ComponentSystemBase KOHMIOLABHA<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60B11D0", Offset = "0x60AFFD0", VA = "0x1860B11D0")]
	protected ComponentSystemBase APLFGNIHHKL(params SystemHandleUntyped[] POHLIFJCECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2620020", Offset = "0x261EE20", VA = "0x182620020")]
	protected ComponentSystemBase APLFGNIHHKL<T>(params SystemHandleUntyped[] POHLIFJCECD) where T : BBELIIJOKCP, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26200B0", Offset = "0x261EEB0", VA = "0x1826200B0")]
	protected SystemHandleUntyped BHIEBJGNIKF<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60AFB90", Offset = "0x60AE990", VA = "0x1860AFB90")]
	protected KJJLGIDAAPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BBELIIJOKCP : CDDBKEOJJFH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60AFB60", Offset = "0x60AE960", VA = "0x1860AFB60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60AFB90", Offset = "0x60AE990", VA = "0x1860AFB90")]
	public BBELIIJOKCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class CDDBKEOJJFH : ComponentSystemGroup, NFLDJDLKDOP
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60AFB90", Offset = "0x60AE990", VA = "0x1860AFB90")]
	protected CDDBKEOJJFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class IEKPLCAAIGD : EntityCommandBufferSystem, NFLDJDLKDOP
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	protected IEKPLCAAIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BABHHMPOABL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DHMFLLFAIHD([In] TFrom MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NLLMBGNMNFI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKCCOLMIKDJ(T MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HABFDJEDLBH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> HGFIGDEFGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer AGBBPNDJDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes MIEAJDBPAKK;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60B0590", Offset = "0x60AF390", VA = "0x1860B0590", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GJKAOGNLFKA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> HGFIGDEFGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer AGBBPNDJDFP;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60B0370", Offset = "0x60AF170", VA = "0x1860B0370", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct BKDIGDFDCOP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> HGFIGDEFGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer AGBBPNDJDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType EJIDAMOMHCE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60AFBE0", Offset = "0x60AE9E0", VA = "0x1860AFBE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct ENGFIAKMNAJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> HGFIGDEFGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> HKPHNGEBIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer AGBBPNDJDFP;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3282430", Offset = "0x3281230", VA = "0x183282430", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct AEKEIENNDNL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> HGFIGDEFGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> GPKFACOMFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer AGBBPNDJDFP;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct HNLADIMFKFD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> HGFIGDEFGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T MBDKMNBCLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer AGBBPNDJDFP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x375AD10", Offset = "0x3759B10", VA = "0x18375AD10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct AOLOJHLHGIB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BABHHMPOABL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> JJDAIDLKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> HGJHLGDLMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap APDAGBKMGMB;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct MFKCDHANEHP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity LPOGPGFGLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> JJDAIDLKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> HGJHLGDLMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int NKNFDNIIBHM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60B1540", Offset = "0x60B0340", VA = "0x1860B1540", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct JILMKEGLAFK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IIFEBBHFPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> JJDAIDLKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> EJDGCMICLDH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct MDOKOHHMNOL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BABHHMPOABL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> JLIMGGIMPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> HGJHLGDLMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap APDAGBKMGMB;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct JIEIBBPKAGB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KJKFKAMFBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> PLACEMENIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> MNPLDDKNEFF;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct IHHJAPMAHIM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KJKFKAMFBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> PLACEMENIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> MNPLDDKNEFF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x380F560", Offset = "0x380E360", VA = "0x18380F560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct HBOBFEHAKCK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> JJDAIDLKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> EJDGCMICLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> IFKEGMKJEFB;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x37317C0", Offset = "0x37305C0", VA = "0x1837317C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct KGFKONKEFPF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : BABHHMPOABL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> JJDAIDLKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> EJDGCMICLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> IFKEGMKJEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap APDAGBKMGMB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct OKDHMKOFLKN<T, TPredicate> : IJob where T : struct where TPredicate : struct, NLLMBGNMNFI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> JJDAIDLKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> BAHPJPNGOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NPPDKGONAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate APDAGBKMGMB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6400", Offset = "0x3EF5200", VA = "0x183EF6400", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct MJDNLJFAHPO<T, TPredicate> : IJob where T : struct where TPredicate : struct, NLLMBGNMNFI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> JJDAIDLKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> EJDGCMICLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate APDAGBKMGMB;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct CNMACENNOOA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity KJKFKAMFBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> PLACEMENIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> DAANNDJIHFL;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60AFD20", Offset = "0x60AEB20", VA = "0x1860AFD20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct GPIDIKNNAJN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity KJKFKAMFBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> PLACEMENIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> DAANNDJIHFL;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60B0500", Offset = "0x60AF300", VA = "0x1860B0500", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FBKBLOGKHDD
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MIJDFKMIBKA
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x26A3B30", Offset = "0x26A2930", VA = "0x1826A3B30")]
	public static bool EHMHAOAHAOJ<T>(this NativeArray<Entity> PLACEMENIAP, EntityManager HGAJDDKIMHE, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DJJPJIKOCEO
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class KIPACHCJAJP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public KIPACHCJAJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DNHGBPLPOBA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public DNHGBPLPOBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> HMNNOGCFJJH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60AFF90", Offset = "0x60AED90", VA = "0x1860AFF90")]
	public DJJPJIKOCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class IBINEGPNELE
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JHOAGKAKIPI
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct JMHCBBKICKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct DAODDGFMGEC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal JMHCBBKICKJ<TFrom> GEFCENNBDFI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> MBOILCLDJDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct LIDCLNMJFPE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct DKKCNFOGJJB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal LIDCLNMJFPE<TFrom> GEFCENNBDFI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> MBOILCLDJDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct IKBBNEBAOEP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct CEGDOFBDLFM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal IKBBNEBAOEP<TFrom> GEFCENNBDFI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> MBOILCLDJDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct CHJJNOPPMEB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct MDLOJGNMPEP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal CHJJNOPPMEB<TFrom> GEFCENNBDFI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> MBOILCLDJDM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PJBLDBJLHKC
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class LBMIOLCIHHM
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x26261B0", Offset = "0x2624FB0", VA = "0x1826261B0")]
	public static NativeList<T> DLNPIKFCELI<T>(this NativeList<T> EJLGDPIKFLB, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2626230", Offset = "0x2625030", VA = "0x182626230")]
	public static NativeList<T> DLNPIKFCELI<T>(this NativeArray<T> EJLGDPIKFLB, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IEMHKIPMFKP
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class ECJFCKAKPDP
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2488AC0", Offset = "0x24878C0", VA = "0x182488AC0")]
	[NJLGBKINADM]
	public static JobHandle NIKFEKIPOHA<T>(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArrayAsync<Entity> HGFIGDEFGDJ, NativeArrayAsync<T> HKPHNGEBIED, [Optional] JobHandle CEKGKINMKBC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2488D40", Offset = "0x2487B40", VA = "0x182488D40")]
	[NJLGBKINADM]
	public static JobHandle NIKFEKIPOHA<T>(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArrayAsync<Entity> HGFIGDEFGDJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2488C20", Offset = "0x2487A20", VA = "0x182488C20")]
	[NJLGBKINADM]
	public static JobHandle NIKFEKIPOHA<T>(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArray<Entity> HGFIGDEFGDJ, [Optional] JobHandle CEKGKINMKBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60B01D0", Offset = "0x60AEFD0", VA = "0x1860B01D0")]
	[NJLGBKINADM]
	public static JobHandle NIKFEKIPOHA(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArray<Entity> HGFIGDEFGDJ, ComponentTypes MIEAJDBPAKK, [Optional] JobHandle CEKGKINMKBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60B0080", Offset = "0x60AEE80", VA = "0x1860B0080")]
	[NJLGBKINADM]
	public static JobHandle NIKFEKIPOHA(this EntityCommandBufferSystem PGKJCMGDHPG, EntityCommandBuffer AGBBPNDJDFP, NativeArray<Entity> HGFIGDEFGDJ, ComponentTypes MIEAJDBPAKK, [Optional] JobHandle CEKGKINMKBC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class DPFGMDPEANO
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2474750", Offset = "0x2473550", VA = "0x182474750")]
	[NJLGBKINADM]
	public static JobHandle KMAOKEDGOPE<T>(this EntityCommandBufferSystem PGKJCMGDHPG, EntityCommandBuffer AGBBPNDJDFP, EntityQuery CEDLBGJCBFF, T MBDKMNBCLGF) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JMACBJAJCIM
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60B0B70", Offset = "0x60AF970", VA = "0x1860B0B70")]
	[NJLGBKINADM]
	public static JobHandle POOJDBLDBFJ(this EntityCommandBufferSystem PGKJCMGDHPG, NativeList<Entity> HGFIGDEFGDJ, [Optional] JobHandle CEKGKINMKBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x60B0D00", Offset = "0x60AFB00", VA = "0x1860B0D00")]
	[NJLGBKINADM]
	public static JobHandle POOJDBLDBFJ(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArrayAsync<Entity> HGFIGDEFGDJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class ALNFAINBHHC
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C28AE0", Offset = "0x2C278E0", VA = "0x182C28AE0")]
	public static void PIGACELAKMG<T>(this EntityCommandBufferSystem PGKJCMGDHPG, EntityQuery CEDLBGJCBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C28960", Offset = "0x2C27760", VA = "0x182C28960")]
	[NJLGBKINADM]
	public static JobHandle KONEPKMMJBE<T>(this EntityCommandBufferSystem PGKJCMGDHPG, NativeListAsync<Entity> HGFIGDEFGDJ, [Optional] JobHandle CEKGKINMKBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C287D0", Offset = "0x2C275D0", VA = "0x182C287D0")]
	[NJLGBKINADM]
	public static JobHandle KONEPKMMJBE<T>(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArrayAsync<Entity> HGFIGDEFGDJ, [Optional] JobHandle CEKGKINMKBC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class IAKCPPELIND
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x25DA910", Offset = "0x25D9710", VA = "0x1825DA910")]
	[NJLGBKINADM]
	public static JobHandle CBJLLKPBMLL<T>(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArray<Entity> HGFIGDEFGDJ, NativeArray<T> HKPHNGEBIED, JobHandle CEKGKINMKBC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class NHODHDKBOFH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2702FC0", Offset = "0x2701DC0", VA = "0x182702FC0")]
	[NJLGBKINADM]
	public static JobHandle ECDBGDNPMAC<T>(this EntityCommandBufferSystem PGKJCMGDHPG, NativeArray<Entity> HGFIGDEFGDJ, T MBDKMNBCLGF, [Optional] JobHandle CEKGKINMKBC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2702EF0", Offset = "0x2701CF0", VA = "0x182702EF0")]
	[NJLGBKINADM]
	public static JobHandle ECDBGDNPMAC<T>(this EntityCommandBufferSystem PGKJCMGDHPG, EntityCommandBuffer AGBBPNDJDFP, NativeArray<Entity> HGFIGDEFGDJ, T MBDKMNBCLGF, [Optional] JobHandle CEKGKINMKBC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class EHJACKEMEMA
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x248D0B0", Offset = "0x248BEB0", VA = "0x18248D0B0")]
	public static NativeList<T> DLNPIKFCELI<T>(NativeList<T> EJLGDPIKFLB, Allocator MAJIAODMLCM) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class DFGAMGGAJPK
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x246FC10", Offset = "0x246EA10", VA = "0x18246FC10")]
	public static NativeArray<T> INHJFNAOGGH<T>(this NativeList<Entity> EJLGDPIKFLB, EntityManager HGAJDDKIMHE, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x246F6D0", Offset = "0x246E4D0", VA = "0x18246F6D0")]
	public static NativeArray<T> INHJFNAOGGH<T>(this NativeArray<Entity> EJLGDPIKFLB, EntityManager HGAJDDKIMHE, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60AFDB0", Offset = "0x60AEBB0", VA = "0x1860AFDB0")]
	public static NativeArray<Entity> OKPDMKMNLBM(this NativeArray<Entity> EJLGDPIKFLB, EntityManager HGAJDDKIMHE, ComponentType EJIDAMOMHCE, Allocator MAJIAODMLCM = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x246FCC0", Offset = "0x246EAC0", VA = "0x18246FCC0")]
	public static NativeArray<T> JHMALEFNFMP<T>(this NativeArray<Entity> EJLGDPIKFLB, EntityManager HGAJDDKIMHE, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CJJAILMDIAC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct BNMMALPKNOG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct MKAMBGLKPNC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public BNMMALPKNOG<TFrom> MBOILCLDJDM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> JJDAIDLKDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct NNIMEGEANGL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct GOEIAEHGNAE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public NNIMEGEANGL<TFrom> MBOILCLDJDM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> JJDAIDLKDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EONACBNBFPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct JLPAFFFLIMJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public EONACBNBFPB<TFrom> MBOILCLDJDM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> JJDAIDLKDKN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class IKINIGMECKD
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class ELCKOPOEIPI
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct DJPEBKPEBAC : BABHHMPOABL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> JHEFJNGDEDG;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60B0020", Offset = "0x60AEE20", VA = "0x1860B0020")]
		[BurstCompatible]
		public Entity DHMFLLFAIHD([In] Entity MBDKMNBCLGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60B0020", Offset = "0x60AEE20", VA = "0x1860B0020", Slot = "4")]
		private Entity DOPLGIDNFMI([In] Entity MBDKMNBCLGF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class PEDMNLDAJJB
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct CBHHKMAKDBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> BAHPJPNGOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> JJDAIDLKDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct GHJDDKBFFNG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> BAHPJPNGOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> JJDAIDLKDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct ABGFJPFKONI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> BAHPJPNGOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> JJDAIDLKDKN;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2194A10", Offset = "0x2193810", VA = "0x182194A10")]
		public NativeListAsync<Entity> MKCCOLMIKDJ<TPredicate>() where TPredicate : struct, NLLMBGNMNFI<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2764510", Offset = "0x2763310", VA = "0x182764510")]
	public static ABGFJPFKONI<T> APLJNPHHLJM<T>(this NativeArrayAsync<Entity> PLACEMENIAP, NativeArrayAsync<T> EJLGDPIKFLB, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct
	{
		return default(ABGFJPFKONI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class EDCOAFIHMIN
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x248A1C0", Offset = "0x2488FC0", VA = "0x18248A1C0")]
	public static NativeListAsync<Entity> JJICGHNCGFD<T, TPredicate>(this NativeArrayAsync<T> EJLGDPIKFLB, NativeArrayAsync<Entity> PLACEMENIAP, Allocator MAJIAODMLCM = Allocator.TempJob) where T : struct where TPredicate : struct, NLLMBGNMNFI<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x248A280", Offset = "0x2489080", VA = "0x18248A280")]
	private static NativeListAsync<Entity> NCGHEPCDBCJ<T, TPredicate>(NativeArrayAsync<T> NGLEHINNECJ, NativeArrayAsync<Entity> PLACEMENIAP, int GENFKPIGLNJ, Allocator MAJIAODMLCM) where T : struct where TPredicate : struct, NLLMBGNMNFI<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class CFIOFDOILBI
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct IBAOMHCIEJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> JJDAIDLKDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct AMGKCEGDBPH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> JJDAIDLKDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct KFDKOAJEPIH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> JJDAIDLKDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct DFCIGPODGKL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator MAJIAODMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> JJDAIDLKDKN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class FHBHPHCLIAP
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class PDPENGNBALH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2764090", Offset = "0x2762E90", VA = "0x182764090")]
	public static NativeList<Entity> KPFENAOJPCN<T>(this NativeArray<Entity> PLACEMENIAP, EntityManager HGAJDDKIMHE, Allocator MAJIAODMLCM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class DOGJKIHELDO
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class OGNIHJCLOEH
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct EOGNGBNJLBD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> IPODKPLEDFE;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
		public EOGNGBNJLBD(NativeArray<TSrc> IPODKPLEDFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public DHNNFKHNMBA<TSrc, TValue> LKFAJLKPKHL<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(DHNNFKHNMBA<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct DHNNFKHNMBA<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> IPODKPLEDFE;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
		public DHNNFKHNMBA(NativeArray<TSrc> IPODKPLEDFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public EMKMOBHCADC<TSrc, TValue, TSelector> DCDGHNIOJEB<TSelector>() where TSelector : struct, BABHHMPOABL<TSrc, TValue>
		{
			return default(EMKMOBHCADC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct EMKMOBHCADC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BABHHMPOABL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> IPODKPLEDFE;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
		public EMKMOBHCADC(NativeArray<TSrc> IPODKPLEDFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x327FF00", Offset = "0x327ED00", VA = "0x18327FF00")]
		public HDLKKKEKPEM<TSrc, TValue, TSelector> CMAIFKIHHHN()
		{
			return default(HDLKKKEKPEM<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct CLOFDOJPHHD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, BABHHMPOABL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> IPODKPLEDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector KMDEKHPMOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int HPLKFBKKIBG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x4AD3B80", Offset = "0x4AD2980", VA = "0x184AD3B80")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int IMILALJBIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9BF550", Offset = "0x9BE350", VA = "0x1809BF550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int PIOKOHDJLOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A110", Offset = "0x1D28F10", VA = "0x181D2A110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3D00", Offset = "0x4AD2B00", VA = "0x184AD3D00")]
		public CLOFDOJPHHD(NativeArray<TSrc> IPODKPLEDFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3CF0", Offset = "0x4AD2AF0", VA = "0x184AD3CF0")]
		public bool IGFODOPPMCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3C10", Offset = "0x4AD2A10", VA = "0x184AD3C10")]
		private TSrc DFPMHFBGDPA(int HBLLIHHIKIO)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct HDLKKKEKPEM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BABHHMPOABL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CLOFDOJPHHD<TSrc, TValue, TSelector> APCJIPBDNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue JDFHGOMEFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int MIMLCMKCBBJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CFGELAIICNI EMDHKHKLIDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x373B9D0", Offset = "0x373A7D0", VA = "0x18373B9D0")]
			get
			{
				return default(CFGELAIICNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue KNHDDGFEBFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, CFGELAIICNI range) GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x373B8F0", Offset = "0x373A6F0", VA = "0x18373B8F0")]
			get
			{
				return default((TValue, CFGELAIICNI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x373BB50", Offset = "0x373A950", VA = "0x18373BB50")]
		public HDLKKKEKPEM(NativeArray<TSrc> IPODKPLEDFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x35E10B0", Offset = "0x35DFEB0", VA = "0x1835E10B0")]
		public HDLKKKEKPEM<TSrc, TValue, TSelector> BCGCEOCJJAB()
		{
			return default(HDLKKKEKPEM<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x373BA10", Offset = "0x373A810", VA = "0x18373BA10")]
		public bool IGFODOPPMCA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x274B1B0", Offset = "0x2749FB0", VA = "0x18274B1B0")]
	public static EOGNGBNJLBD<T> NNPEMEIABOF<T>(this NativeList<T> HFLDOAFOIEF) where T : struct
	{
		return default(EOGNGBNJLBD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
	public static EOGNGBNJLBD<T> NNPEMEIABOF<T>(this NativeArray<T> IPODKPLEDFE) where T : struct
	{
		return default(EOGNGBNJLBD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class HFLNOLNNGII
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct BODFODDCDDL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly IPODKPLEDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int MIMLCMKCBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int ELJIBMLKCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T JDFHGOMEFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T DEMAPJABBIC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CFGELAIICNI EMDHKHKLIDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x399E920", Offset = "0x399D720", VA = "0x18399E920")]
			get
			{
				return default(CFGELAIICNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T KNHDDGFEBFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x32F34E0", Offset = "0x32F22E0", VA = "0x1832F34E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, CFGELAIICNI) GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x46B6560", Offset = "0x46B5360", VA = "0x1846B6560")]
			get
			{
				return default((T, CFGELAIICNI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x46B6A90", Offset = "0x46B5890", VA = "0x1846B6A90")]
		public BODFODDCDDL(NativeArray<T> IPODKPLEDFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x46B6520", Offset = "0x46B5320", VA = "0x1846B6520")]
		public BODFODDCDDL<T> BCGCEOCJJAB()
		{
			return default(BODFODDCDDL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x46B68B0", Offset = "0x46B56B0", VA = "0x1846B68B0")]
		public bool IGFODOPPMCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F03130", Offset = "0x2F01F30", VA = "0x182F03130")]
		public JAMAJNNPEMF<T, TComparer> CBBFBJOJFLL<TComparer>([Optional] TComparer DBPDIPPJODH) where TComparer : struct, IEqualityComparer<T>
		{
			return default(JAMAJNNPEMF<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct JAMAJNNPEMF<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly IPODKPLEDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int MIMLCMKCBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int ELJIBMLKCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T JDFHGOMEFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T DEMAPJABBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer DBPDIPPJODH;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CFGELAIICNI EMDHKHKLIDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x399E920", Offset = "0x399D720", VA = "0x18399E920")]
			get
			{
				return default(CFGELAIICNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T KNHDDGFEBFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x32F34E0", Offset = "0x32F22E0", VA = "0x1832F34E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, CFGELAIICNI range) GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x399E850", Offset = "0x399D650", VA = "0x18399E850")]
			get
			{
				return default((T, CFGELAIICNI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x399EB10", Offset = "0x399D910", VA = "0x18399EB10")]
		public JAMAJNNPEMF(NativeArray<T>.ReadOnly IPODKPLEDFE, TComparer DBPDIPPJODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x399E810", Offset = "0x399D610", VA = "0x18399E810")]
		public JAMAJNNPEMF<T, TComparer> BCGCEOCJJAB()
		{
			return default(JAMAJNNPEMF<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x399E930", Offset = "0x399D730", VA = "0x18399E930")]
		public bool IGFODOPPMCA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x25CC510", Offset = "0x25CB310", VA = "0x1825CC510")]
	public static BODFODDCDDL<T> CMAIFKIHHHN<T>(this NativeArray<T> IPODKPLEDFE) where T : struct
	{
		return default(BODFODDCDDL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface NODGGIDHJID
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class AEJIEFENDOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JBDJAFCFAAO<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GNNFBNFDOAD : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JBDJAFCFAAO<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA302A0", Offset = "0xA2F0A0", VA = "0x180A302A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35EFDA0", Offset = "0x35EEBA0", VA = "0x1835EFDA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public GNNFBNFDOAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x36FDC70", Offset = "0x36FCA70", VA = "0x1836FDC70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x36FDE20", Offset = "0x36FCC20", VA = "0x1836FDE20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> EGHEEJLKBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream KIHJEEILDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream IBKIKJIAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf FPIEAMBDBOG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int PIOKOHDJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x39A3D30", Offset = "0x39A2B30", VA = "0x1839A3D30")]
	private JBDJAFCFAAO(byte[] FHEAENNOLNB, Action<Protobuf> EGHEEJLKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x22F7000", Offset = "0x22F5E00", VA = "0x1822F7000")]
	public static JBDJAFCFAAO<Protobuf> KCGHAKHJLMB<Data>(ReadOnlySpan<byte> MEFCHKNPKLC, ReadOnlySpan<Data> PBMGHICHJGB, Action<Protobuf> EGHEEJLKBGC)
	{
		return default(JBDJAFCFAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x39A3BA0", Offset = "0x39A29A0", VA = "0x1839A3BA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x39A3BE0", Offset = "0x39A29E0", VA = "0x1839A3BE0", Slot = "4")]
	[IteratorStateMachine(typeof(JBDJAFCFAAO<>.GNNFBNFDOAD))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x39A3CD0", Offset = "0x39A2AD0", VA = "0x1839A3CD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NOBOOAFDMMN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] FHEAENNOLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf FPIEAMBDBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream KIHJEEILDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream BHLGGGOOCOO;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B5B0", Offset = "0x3E0A3B0", VA = "0x183E0B5B0")]
	private NOBOOAFDMMN(byte[] FHEAENNOLNB, [In] Protobuf FPIEAMBDBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x230D0E0", Offset = "0x230BEE0", VA = "0x18230D0E0")]
	public static NOBOOAFDMMN<Protobuf> KCGHAKHJLMB<T>(ReadOnlySpan<T> PBMGHICHJGB)
	{
		return default(NOBOOAFDMMN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B450", Offset = "0x3E0A250", VA = "0x183E0B450")]
	public void DKOPMGIPCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B3C0", Offset = "0x3E0A1C0", VA = "0x183E0B3C0")]
	public ByteString DHDGMMHHBCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B480", Offset = "0x3E0A280", VA = "0x183E0B480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DKIFGEDHOCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream KIHJEEILDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream IBKIKJIAPAA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60B0030", Offset = "0x60AEE30", VA = "0x1860B0030", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct KHAGIIHDNJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] FHEAENNOLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream KIHJEEILDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream BHLGGGOOCOO;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60B10A0", Offset = "0x60AFEA0", VA = "0x1860B10A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class NPCCMGABKKP
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void GEOOOMBIKGM<From, To>(From MBOILCLDJDM, To ABBDLLBKBLE, DNIKMALCLMO HKBPEKNGMMF);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class OAJMHJOLPCH<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static GEOOOMBIKGM<From, To> POLPAOIBCDL;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public OAJMHJOLPCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x60B1640", Offset = "0x60B0440", VA = "0x1860B1640")]
	static NPCCMGABKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2719420", Offset = "0x2718220", VA = "0x182719420")]
	public static void DEKBPCGMLFI<T>(GEOOOMBIKGM<T, T> HLLBAPJMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2719BE0", Offset = "0x27189E0", VA = "0x182719BE0")]
	public static void DEKBPCGMLFI<From, To>(GEOOOMBIKGM<From, To> HLLBAPJMAAM, GEOOOMBIKGM<To, From> PPDECFGAKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2718EB0", Offset = "0x2717CB0", VA = "0x182718EB0")]
	public static void DEKBPCGMLFI<From, To>(GEOOOMBIKGM<From, To> POLPAOIBCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x271D550", Offset = "0x271C350", VA = "0x18271D550")]
	public static GEOOOMBIKGM<From, To> GNEGNKOOKMO<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x27229C0", Offset = "0x27217C0", VA = "0x1827229C0")]
	public static void OKDMHGLJLAM<From, To>(From MBOILCLDJDM, To ABBDLLBKBLE, DNIKMALCLMO HKBPEKNGMMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class DNIKMALCLMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> INDFDJPBDDO;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA830", Offset = "0x1CE9630", VA = "0x181CEA830")]
	public DNIKMALCLMO(NativeArray<EntityRemapUtility.EntityRemapInfo> INDFDJPBDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60B0070", Offset = "0x60AEE70", VA = "0x1860B0070")]
	public Entity DJCAGOBFJMG(Entity LGDFGELLOEL)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class LHKNCDEBAEA
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60B14B0", Offset = "0x60B02B0", VA = "0x1860B14B0")]
	public static ulong BGJNDLNDJJJ(Type HJCFEPLFGPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60B1450", Offset = "0x60B0250", VA = "0x1860B1450")]
	public static ulong BGJNDLNDJJJ(string BBLOKOCLJOL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum KICEPKAOLAP
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
public class CFDOIEPEDNO : KCIILHAHFBL
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	public CFDOIEPEDNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class JPEMBLGAPJA
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60B0FD0", Offset = "0x60AFDD0", VA = "0x1860B0FD0")]
	private unsafe static Span<byte> PPAMAJKMKOD(Unity.Entities.Chunk* GHHBKLNJKGA, int NHIEDLDADJG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2608B30", Offset = "0x2607930", VA = "0x182608B30")]
	public unsafe static Span<T> NHAIPFNJPAH<T>(Unity.Entities.Chunk* GHHBKLNJKGA, int NHIEDLDADJG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x25B9300", Offset = "0x25B8100", VA = "0x1825B9300")]
	public static Span<T> NHAIPFNJPAH<T>(this Unity.Entities.Chunk GHHBKLNJKGA, int NHIEDLDADJG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60B0E00", Offset = "0x60AFC00", VA = "0x1860B0E00")]
	public unsafe static Span<Entity> KGOJAPDHIFH(Unity.Entities.Chunk* GHHBKLNJKGA)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60B0E60", Offset = "0x60AFC60", VA = "0x1860B0E60")]
	public unsafe static void LJNFEICKFHE(Unity.Entities.Chunk* GHHBKLNJKGA, int NHIEDLDADJG)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class LBMBDANPICH
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public LBMBDANPICH()
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
