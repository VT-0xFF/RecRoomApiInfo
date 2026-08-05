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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x61A0940", Offset = "0x619F740", VA = "0x1861A0940")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BLJPPMGBKOF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CLLDGJOLLJE MEBIHPLENKI
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
public interface EHMNKMNLKCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALKFIFEIFBD(Entity JLCPBIBMCCJ, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKPAMIMDGNN(Entity JLCPBIBMCCJ, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NMFGLEGMAEE(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJHFJAIGLGH(Entity JLCPBIBMCCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NHPJAAKFNJL<TComponentData, TValue> : EOGGPBGALFD<TValue>, IDisposable where TComponentData : struct, BLJPPMGBKOF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class IFFDADFKFFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> MOAFNEBEDKD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int EDOFPONLMHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x30A2EB0", Offset = "0x30A1CB0", VA = "0x1830A2EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3876F80", Offset = "0x3875D80", VA = "0x183876F80")]
		public bool JEFFDLFALBC([Out] TValue MAEBFBHFPDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3876ED0", Offset = "0x3875CD0", VA = "0x183876ED0")]
		public void GALNLGNAACN(object BNAJMHPOOCG, TValue MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3876E50", Offset = "0x3875C50", VA = "0x183876E50")]
		public bool FIJOKOAGLFM(object BNAJMHPOOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3877070", Offset = "0x3875E70", VA = "0x183877070")]
		public int JGCKGGOIAIM(object BNAJMHPOOCG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3877150", Offset = "0x3875F50", VA = "0x183877150")]
		public IFFDADFKFFH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<IFFDADFKFFH> LPKPPLPGOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private HNEENCDKOOA<CLLDGJOLLJE, IFFDADFKFFH> IFJONELNKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager MDAGMBDMCCO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2700", Offset = "0x3EB1500", VA = "0x183EB2700")]
	public NHPJAAKFNJL(EntityManager MDAGMBDMCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2150", Offset = "0x3EB0F50", VA = "0x183EB2150", Slot = "4")]
	public void ALKFIFEIFBD(Entity JLCPBIBMCCJ, object BNAJMHPOOCG, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1FB0", Offset = "0x3EB0DB0", VA = "0x183EB1FB0", Slot = "5")]
	public bool AKPAMIMDGNN(Entity JLCPBIBMCCJ, object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB24B0", Offset = "0x3EB12B0", VA = "0x183EB24B0", Slot = "6")]
	public bool JEFFDLFALBC(Entity JLCPBIBMCCJ, [Out] TValue MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2380", Offset = "0x3EB1180", VA = "0x183EB2380", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2670", Offset = "0x3EB1470", VA = "0x183EB2670")]
	private void MAHNDFHCIFB(IFFDADFKFFH BOJBMMNPFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3EB25B0", Offset = "0x3EB13B0", VA = "0x183EB25B0")]
	private bool LMKCNCDEOFE(Entity JLCPBIBMCCJ, [Out] CLLDGJOLLJE PDCBMAPDAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2290", Offset = "0x3EB1090", VA = "0x183EB2290")]
	private void DFOEFIGAIPH(Entity JLCPBIBMCCJ, CLLDGJOLLJE PDCBMAPDAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2490", Offset = "0x3EB1290", VA = "0x183EB2490")]
	private bool GFHEGNFAKKJ(CLLDGJOLLJE PDCBMAPDAEE, [Out] IFFDADFKFFH BOJBMMNPFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3EB23A0", Offset = "0x3EB11A0", VA = "0x183EB23A0")]
	private IFFDADFKFFH ECCANCNFGED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EOGGPBGALFD<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALKFIFEIFBD(Entity JLCPBIBMCCJ, object BNAJMHPOOCG, TValue MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKPAMIMDGNN(Entity JLCPBIBMCCJ, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEFFDLFALBC(Entity JLCPBIBMCCJ, [Out] TValue MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CLLDGJOLLJE : LHOPFFBIOKG, IEquatable<CLLDGJOLLJE>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly CLLDGJOLLJE LCPFPBICDEC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int LNBHMBDGGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int HPLABGPNINE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x22396B0", Offset = "0x22384B0", VA = "0x1822396B0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5534DA0", Offset = "0x5533BA0", VA = "0x185534DA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61A0880", Offset = "0x619F680", VA = "0x1861A0880", Slot = "8")]
	public bool Equals(CLLDGJOLLJE EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61A08D0", Offset = "0x619F6D0", VA = "0x1861A08D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LBKEPKHAHKP<THasTokensTag> : EHMNKMNLKCD, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, CLLDGJOLLJE> KPCJAEKLBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> LPKPPLPGOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private HNEENCDKOOA<CLLDGJOLLJE, HashSet<object>> IFJONELNKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager MDAGMBDMCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem MOMNNDIAGMH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BEFA20", Offset = "0x3BEE820", VA = "0x183BEFA20")]
	public LBKEPKHAHKP(EntityManager MDAGMBDMCCO, EntityCommandBufferSystem MOMNNDIAGMH, IIFCCHIKGII OEGLNKEPACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3BECBD0", Offset = "0x3BEB9D0", VA = "0x183BECBD0", Slot = "4")]
	public bool ALKFIFEIFBD(Entity JLCPBIBMCCJ, object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC8F0", Offset = "0x3BEB6F0", VA = "0x183BEC8F0", Slot = "5")]
	public bool AKPAMIMDGNN(Entity JLCPBIBMCCJ, object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF3C0", Offset = "0x3BEE1C0", VA = "0x183BEF3C0", Slot = "6")]
	public bool NMFGLEGMAEE(Entity JLCPBIBMCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF260", Offset = "0x3BEE060", VA = "0x183BEF260", Slot = "9")]
	public bool NMFGLEGMAEE(CLLDGJOLLJE PDCBMAPDAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BED490", Offset = "0x3BEC290", VA = "0x183BED490", Slot = "7")]
	public bool BJHFJAIGLGH(Entity JLCPBIBMCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE0F0", Offset = "0x3BECEF0", VA = "0x183BEE0F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3BEEE20", Offset = "0x3BEDC20", VA = "0x183BEEE20")]
	private void MAHNDFHCIFB(HashSet<object> BOJBMMNPFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BEECE0", Offset = "0x3BEDAE0", VA = "0x183BEECE0")]
	private bool LMKCNCDEOFE(Entity JLCPBIBMCCJ, [Out] CLLDGJOLLJE PDCBMAPDAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF660", Offset = "0x3BEE460", VA = "0x183BEF660")]
	private bool OMGCBBHKLIA(Entity JLCPBIBMCCJ, [Out] CLLDGJOLLJE PDCBMAPDAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDAD0", Offset = "0x3BEC8D0", VA = "0x183BEDAD0")]
	private void CCJMGJINEMB(Entity JLCPBIBMCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE560", Offset = "0x3BED360", VA = "0x183BEE560")]
	private void KIIKOBIDJAD(Entity JLCPBIBMCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF160", Offset = "0x3BEDF60", VA = "0x183BEF160")]
	private void NFMHIJLCOBA(Entity JLCPBIBMCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDBE0", Offset = "0x3BEC9E0", VA = "0x183BEDBE0")]
	private void DFOEFIGAIPH(Entity JLCPBIBMCCJ, CLLDGJOLLJE PDCBMAPDAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDF90", Offset = "0x3BECD90", VA = "0x183BEDF90")]
	private bool DJOBLDBOEAB(CLLDGJOLLJE PDCBMAPDAEE, [Out] HashSet<object> BOJBMMNPFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE130", Offset = "0x3BECF30", VA = "0x183BEE130")]
	private HashSet<object> ECCANCNFGED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KEAHAPJBIKK
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HNKGNDEHEKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int LBJEFCOBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int DPKFLHPPNCH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EBBAINNAODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x22396B0", Offset = "0x22384B0", VA = "0x1822396B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5534DA0", Offset = "0x5533BA0", VA = "0x185534DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GMKMPIOAACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OJGKBEINDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61A1030", Offset = "0x619FE30", VA = "0x1861A1030")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61A1040", Offset = "0x619FE40", VA = "0x1861A1040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAAB8D0", Offset = "0xAAA6D0", VA = "0x180AAB8D0")]
	private HNKGNDEHEKK(int LBJEFCOBKGF, int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DC92C0", Offset = "0x1DC80C0", VA = "0x181DC92C0")]
	public static HNKGNDEHEKK ONBDOEPDNMN(int LBJEFCOBKGF, int DPKFLHPPNCH)
	{
		return default(HNKGNDEHEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61A1050", Offset = "0x619FE50", VA = "0x1861A1050")]
	public static HNKGNDEHEKK GFANDDHNCPG(int CJNJFDOAKGB, int INMKHBKJJMP)
	{
		return default(HNKGNDEHEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61A1060", Offset = "0x619FE60", VA = "0x1861A1060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BBLIJILEEIB : FGHHEMNGJLM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61A0870", Offset = "0x619F670", VA = "0x1861A0870")]
	public float FJEIFNILKDG([In] float3 MAEBFBHFPDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61A0870", Offset = "0x619F670", VA = "0x1861A0870", Slot = "4")]
	private float PCAJICFAGCK([In] float3 MAEBFBHFPDE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EEBMFAFPICE : FGHHEMNGJLM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x61A0930", Offset = "0x619F730", VA = "0x1861A0930")]
	public float FJEIFNILKDG([In] float3 MAEBFBHFPDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61A0930", Offset = "0x619F730", VA = "0x1861A0930", Slot = "4")]
	private float PCAJICFAGCK([In] float3 MAEBFBHFPDE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PHODCOBJEAJ : FGHHEMNGJLM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1A74A60", Offset = "0x1A73860", VA = "0x181A74A60")]
	public float FJEIFNILKDG([In] float3 MAEBFBHFPDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1A74A60", Offset = "0x1A73860", VA = "0x181A74A60", Slot = "4")]
	private float PCAJICFAGCK([In] float3 MAEBFBHFPDE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NBINPBJJAAB : FGHHEMNGJLM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1395730", Offset = "0x1394530", VA = "0x181395730")]
	public int FJEIFNILKDG([In] int3 MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1395730", Offset = "0x1394530", VA = "0x181395730", Slot = "4")]
	private int LAJPIOFAPJE([In] int3 MAEBFBHFPDE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DENHKKPPBGO : FGHHEMNGJLM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61A0920", Offset = "0x619F720", VA = "0x1861A0920")]
	public int FJEIFNILKDG([In] int3 MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61A0920", Offset = "0x619F720", VA = "0x1861A0920", Slot = "4")]
	private int LAJPIOFAPJE([In] int3 MAEBFBHFPDE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IOHOFLMMDPK : FGHHEMNGJLM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x168CEB0", Offset = "0x168BCB0", VA = "0x18168CEB0")]
	public int FJEIFNILKDG([In] int3 MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x168CEB0", Offset = "0x168BCB0", VA = "0x18168CEB0", Slot = "4")]
	private int LAJPIOFAPJE([In] int3 MAEBFBHFPDE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MGIFMGADOGA : CMGDOCIHCPF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9100", Offset = "0x7C7F00", VA = "0x1807C9100")]
	public MGIFMGADOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class GKGBDFDDHEN : SystemBase, LONGMLBFHLJ
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61A0A10", Offset = "0x619F810", VA = "0x1861A0A10")]
	public ComponentDataFromEntity EOFDIEONDOP(int CEAMMMGHHMC, bool MBMBHJAOAIN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61A09F0", Offset = "0x619F7F0", VA = "0x1861A09F0")]
	public EntityExistenceLookupByEntity EFJKMHHEABL()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61A0AD0", Offset = "0x619F8D0", VA = "0x1861A0AD0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9100", Offset = "0x7C7F00", VA = "0x1807C9100")]
	protected GKGBDFDDHEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class IICDOOAJKIL : GKGBDFDDHEN
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61A10F0", Offset = "0x619FEF0", VA = "0x1861A10F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C9100", Offset = "0x7C7F00", VA = "0x1807C9100")]
	protected IICDOOAJKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OFMLLJODKDP
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class JJONJLJDKFF : EntityCommandBufferSystem, LONGMLBFHLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C9100", Offset = "0x7C7F00", VA = "0x1807C9100")]
	protected JJONJLJDKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FGHHEMNGJLM<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo FJEIFNILKDG([In] TFrom MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CFICPNICHKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBAHKAGEGLG(T MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct NAAKDFDDPKP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	public NativeArray<Entity> ILPEGPIDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ComponentTypes HFFGKBDLNDF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61A1510", Offset = "0x61A0310", VA = "0x1861A1510", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct PPOFNGPCKNI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> ILPEGPIDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61A1790", Offset = "0x61A0590", VA = "0x1861A1790", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct AOMAKBBOMJI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> ILPEGPIDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public ComponentType ONKMEHJKCKF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61A07F0", Offset = "0x619F5F0", VA = "0x1861A07F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct KADBOLHOAAN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<Entity> ILPEGPIDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<T> EEDANCJJEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDCC0", Offset = "0x3AFCAC0", VA = "0x183AFDCC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct AEEFCLLMNOB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<Entity> ILPEGPIDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<T> NPCOHMLDIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct KKIBPCLFAMO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> ILPEGPIDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public T MAEBFBHFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B26200", Offset = "0x3B25000", VA = "0x183B26200", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct DDPGHEEODNL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FGHHEMNGJLM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<TFrom> EJAFDKOJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[WriteOnly]
	public NativeArray<TTo> CNCJDAIPHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TMap CJMBDOEJJJI;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct PGGDNBECJCC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public ComponentDataFromEntity JBCCDOLJIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<Entity> EJAFDKOJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeArray<byte> CNCJDAIPHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int KNIDBBGNBEM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61A1690", Offset = "0x61A0490", VA = "0x1861A1690", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct MBPMMJKJHJD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LBGLGFEBLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<Entity> EJAFDKOJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<T> NFMCAOLFJAB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct CKMEPIINKHO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FGHHEMNGJLM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<TFrom> BACDMDMDKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<TTo> CNCJDAIPHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TMap CJMBDOEJJJI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct PMPEHHPLKCJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HEMANIODFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public NativeArray<Entity> FLMDNPHBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<bool> CHABELMDNDH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct LAGKMHDBGED<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HEMANIODFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> FLMDNPHBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<bool> CHABELMDNDH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9040", Offset = "0x3BE7E40", VA = "0x183BE9040", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct BLEKOOOLNJF<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<T> EJAFDKOJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeList<T> NFMCAOLFJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeParallelHashSet<T> EADPBADKEBI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x47D5C70", Offset = "0x47D4A70", VA = "0x1847D5C70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct BALBMFCHFFE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FGHHEMNGJLM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public NativeArray<TFrom> EJAFDKOJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeList<TFrom> NFMCAOLFJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeParallelHashSet<TTo> EADPBADKEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap CJMBDOEJJJI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct DNEOJIMBDFD<T, TPredicate> : IJob where T : struct where TPredicate : struct, CFICPNICHKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<T> EJAFDKOJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> DKMKHEIFNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeList<Entity> GDOLMJHBCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TPredicate CJMBDOEJJJI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x504C7C0", Offset = "0x504B5C0", VA = "0x18504C7C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct KPBGHOJMGIL<T, TPredicate> : IJob where T : struct where TPredicate : struct, CFICPNICHKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<T> EJAFDKOJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeList<T> NFMCAOLFJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public TPredicate CJMBDOEJJJI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct KOCJEPBGNFH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public ComponentDataFromEntity HEMANIODFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> FLMDNPHBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NativeList<Entity> IGINBBCLMEL;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61A1170", Offset = "0x619FF70", VA = "0x1861A1170", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct NAGLLJDIIBF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public ComponentDataFromEntity HEMANIODFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public NativeArray<Entity> FLMDNPHBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<Entity> IGINBBCLMEL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61A1600", Offset = "0x61A0400", VA = "0x1861A1600", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LAAGOBILKEG
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FFGODDPJJGD
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2732920", Offset = "0x2731720", VA = "0x182732920")]
	public static bool GLCDGCKLNIG<T>(this NativeArray<Entity> FLMDNPHBHLM, EntityManager MDAGMBDMCCO, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GBGJHELMHJB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DFBLIKBANHA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		public DFBLIKBANHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IJIGGCHFACD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		public IJIGGCHFACD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<Func<JobHandle, JobHandle>> OIOKJODNBAC;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61A0960", Offset = "0x619F760", VA = "0x1861A0960")]
	public GBGJHELMHJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OICOGCCMKAL
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IECFPIFHNFC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct JNFDHBEIBHA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct MJJCJNAEAAO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			internal JNFDHBEIBHA<TFrom> FEOGIMKDFKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal NativeArray<TFrom> MCFKOLILEBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct JHHLEBIMLHL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct CHOMNMBMGHA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			internal JHHLEBIMLHL<TFrom> FEOGIMKDFKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal NativeList<TFrom> MCFKOLILEBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct OJLCADNEJCB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct LBCPMCGCOEP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal OJLCADNEJCB<TFrom> FEOGIMKDFKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NativeArrayAsync<TFrom> MCFKOLILEBF;
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct BGOKDBNDAGI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct OEMDKBINLOK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal BGOKDBNDAGI<TFrom> FEOGIMKDFKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeListAsync<TFrom> MCFKOLILEBF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JGLFMJIBBOA
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MAOHMLPKACL
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x280B780", Offset = "0x280A580", VA = "0x18280B780")]
	public static NativeList<T> IGAFPDNCFPL<T>(this NativeList<T> MPBMJBNICDP, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x280B600", Offset = "0x280A400", VA = "0x18280B600")]
	public static NativeList<T> IGAFPDNCFPL<T>(this NativeArray<T> MPBMJBNICDP, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class MFGKNKHCKNO
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HHDBGPOINMN
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2765810", Offset = "0x2764610", VA = "0x182765810")]
	[OFGFBDBMCKH]
	public static JobHandle CCJIJFEJNOC<T>(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArrayAsync<Entity> ILPEGPIDHBI, NativeArrayAsync<T> EEDANCJJEPL, [Optional] JobHandle AEHBGOGHIAO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2765A90", Offset = "0x2764890", VA = "0x182765A90")]
	[OFGFBDBMCKH]
	public static JobHandle CCJIJFEJNOC<T>(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArrayAsync<Entity> ILPEGPIDHBI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2765970", Offset = "0x2764770", VA = "0x182765970")]
	[OFGFBDBMCKH]
	public static JobHandle CCJIJFEJNOC<T>(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArray<Entity> ILPEGPIDHBI, [Optional] JobHandle AEHBGOGHIAO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61A0AE0", Offset = "0x619F8E0", VA = "0x1861A0AE0")]
	[OFGFBDBMCKH]
	public static JobHandle CCJIJFEJNOC(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArray<Entity> ILPEGPIDHBI, ComponentTypes HFFGKBDLNDF, [Optional] JobHandle AEHBGOGHIAO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61A0C50", Offset = "0x619FA50", VA = "0x1861A0C50")]
	[OFGFBDBMCKH]
	public static JobHandle CCJIJFEJNOC(this EntityCommandBufferSystem MOMNNDIAGMH, EntityCommandBuffer PCCICGJEGBH, NativeArray<Entity> ILPEGPIDHBI, ComponentTypes HFFGKBDLNDF, [Optional] JobHandle AEHBGOGHIAO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class EJBONHELNMO
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x25FFCE0", Offset = "0x25FEAE0", VA = "0x1825FFCE0")]
	[OFGFBDBMCKH]
	public static JobHandle DDANBPGEHAA<T>(this EntityCommandBufferSystem MOMNNDIAGMH, EntityCommandBuffer PCCICGJEGBH, EntityQuery GLHAGHMBEIE, T MAEBFBHFPDE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HLCPOALPGLP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61A0DA0", Offset = "0x619FBA0", VA = "0x1861A0DA0")]
	[OFGFBDBMCKH]
	public static JobHandle KBBPFHEHJCO(this EntityCommandBufferSystem MOMNNDIAGMH, NativeList<Entity> ILPEGPIDHBI, [Optional] JobHandle AEHBGOGHIAO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61A0F30", Offset = "0x619FD30", VA = "0x1861A0F30")]
	[OFGFBDBMCKH]
	public static JobHandle KBBPFHEHJCO(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArrayAsync<Entity> ILPEGPIDHBI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NANDGICLDFM
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2863670", Offset = "0x2862470", VA = "0x182863670")]
	public static void KDALBANGDPE<T>(this EntityCommandBufferSystem MOMNNDIAGMH, EntityQuery GLHAGHMBEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x28635B0", Offset = "0x28623B0", VA = "0x1828635B0")]
	[OFGFBDBMCKH]
	public static JobHandle GPFDDLBBJKN<T>(this EntityCommandBufferSystem MOMNNDIAGMH, NativeListAsync<Entity> ILPEGPIDHBI, [Optional] JobHandle AEHBGOGHIAO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2863420", Offset = "0x2862220", VA = "0x182863420")]
	[OFGFBDBMCKH]
	public static JobHandle GPFDDLBBJKN<T>(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArrayAsync<Entity> ILPEGPIDHBI, [Optional] JobHandle AEHBGOGHIAO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PLCLHIDBBME
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x28B1BC0", Offset = "0x28B09C0", VA = "0x1828B1BC0")]
	[OFGFBDBMCKH]
	public static JobHandle NMMJGIAPNNO<T>(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArray<Entity> ILPEGPIDHBI, NativeArray<T> EEDANCJJEPL, JobHandle AEHBGOGHIAO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PBKKKNADOCA
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28AD430", Offset = "0x28AC230", VA = "0x1828AD430")]
	[OFGFBDBMCKH]
	public static JobHandle FJOIPLGIIHI<T>(this EntityCommandBufferSystem MOMNNDIAGMH, NativeArray<Entity> ILPEGPIDHBI, T MAEBFBHFPDE, [Optional] JobHandle AEHBGOGHIAO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x28AD510", Offset = "0x28AC310", VA = "0x1828AD510")]
	[OFGFBDBMCKH]
	public static JobHandle FJOIPLGIIHI<T>(this EntityCommandBufferSystem MOMNNDIAGMH, EntityCommandBuffer PCCICGJEGBH, NativeArray<Entity> ILPEGPIDHBI, T MAEBFBHFPDE, [Optional] JobHandle AEHBGOGHIAO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ICBOMNEHBHH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x277A430", Offset = "0x2779230", VA = "0x18277A430")]
	public static NativeList<T> IGAFPDNCFPL<T>(NativeList<T> MPBMJBNICDP, Allocator ALDDPOOJFGI) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MGPCGOAMCDM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x28118B0", Offset = "0x28106B0", VA = "0x1828118B0")]
	public static NativeArray<T> HBOHACMCLIH<T>(this NativeList<Entity> MPBMJBNICDP, EntityManager MDAGMBDMCCO, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2811530", Offset = "0x2810330", VA = "0x182811530")]
	public static NativeArray<T> HBOHACMCLIH<T>(this NativeArray<Entity> MPBMJBNICDP, EntityManager MDAGMBDMCCO, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61A1330", Offset = "0x61A0130", VA = "0x1861A1330")]
	public static NativeArray<Entity> APHEBBDOBFF(this NativeArray<Entity> MPBMJBNICDP, EntityManager MDAGMBDMCCO, ComponentType ONKMEHJKCKF, Allocator ALDDPOOJFGI = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2811450", Offset = "0x2810250", VA = "0x182811450")]
	public static NativeArray<T> AMCEAGHAEOI<T>(this NativeArray<Entity> MPBMJBNICDP, EntityManager MDAGMBDMCCO, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class IFMOCGFANMP
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct KFMGPMOMKAH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct KBPPNLIOBKM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KFMGPMOMKAH<TFrom> MCFKOLILEBF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<TFrom> EJAFDKOJLNN;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct DGEEHFNHLHL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct CACLLKNJKHP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public DGEEHFNHLHL<TFrom> MCFKOLILEBF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeArrayAsync<TFrom> EJAFDKOJLNN;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct OJGBCHGPCDM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct NHKGCMKPEKP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public OJGBCHGPCDM<TFrom> MCFKOLILEBF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeListAsync<TFrom> EJAFDKOJLNN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KPKJKEMOJHO
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DFOGFFFPAEG
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct JCJNCKKNIMA : FGHHEMNGJLM<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DHAKOAGICKO;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61A1160", Offset = "0x619FF60", VA = "0x1861A1160")]
		[BurstCompatible]
		public Entity FJEIFNILKDG([In] Entity MAEBFBHFPDE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61A1160", Offset = "0x619FF60", VA = "0x1861A1160", Slot = "4")]
		private Entity DAMMKFEEOEO([In] Entity MAEBFBHFPDE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FMLOIBAPKAP
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct HFPGFMDCLIG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<Entity> DKMKHEIFNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<T> EJAFDKOJLNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct KAGODHCJILC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<Entity> DKMKHEIFNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<T> EJAFDKOJLNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct BHJPIFKCJOH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<Entity> DKMKHEIFNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArrayAsync<T> EJAFDKOJLNN;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x229DDF0", Offset = "0x229CBF0", VA = "0x18229DDF0")]
		public NativeListAsync<Entity> CBAHKAGEGLG<TPredicate>() where TPredicate : struct, CFICPNICHKB<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2736150", Offset = "0x2734F50", VA = "0x182736150")]
	public static BHJPIFKCJOH<T> JJONFIHMLJN<T>(this NativeArrayAsync<Entity> FLMDNPHBHLM, NativeArrayAsync<T> MPBMJBNICDP, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct
	{
		return default(BHJPIFKCJOH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CBFHFGLPEKE
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2589B20", Offset = "0x2588920", VA = "0x182589B20")]
	public static NativeListAsync<Entity> EHNILKHNMFG<T, TPredicate>(this NativeArrayAsync<T> MPBMJBNICDP, NativeArrayAsync<Entity> FLMDNPHBHLM, Allocator ALDDPOOJFGI = Allocator.TempJob) where T : struct where TPredicate : struct, CFICPNICHKB<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2589980", Offset = "0x2588780", VA = "0x182589980")]
	private static NativeListAsync<Entity> APFJLBCKCGD<T, TPredicate>(NativeArrayAsync<T> KGKMDOHOICA, NativeArrayAsync<Entity> FLMDNPHBHLM, int AKCMMEDPGHB, Allocator ALDDPOOJFGI) where T : struct where TPredicate : struct, CFICPNICHKB<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OBBOIHKAHKM
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct EGJIIOPFPFK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<T> EJAFDKOJLNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct AHFNBJPBCOO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<T> EJAFDKOJLNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct GCNMMLHDCLD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArrayAsync<T> EJAFDKOJLNN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct INLJDFJGDIP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator ALDDPOOJFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeListAsync<T> EJAFDKOJLNN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class ODKACCPGEIL
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MGHIIAGGMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2810FD0", Offset = "0x280FDD0", VA = "0x182810FD0")]
	public static NativeList<Entity> GHMMGJHEGIH<T>(this NativeArray<Entity> FLMDNPHBHLM, EntityManager MDAGMBDMCCO, Allocator ALDDPOOJFGI = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class BDCHPGFBIBK
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NIHJMDCKACF
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct PGNCLBNNIIO<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> HHAMBPGBENG;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
		public PGNCLBNNIIO(NativeArray<TSrc> HHAMBPGBENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public OIPEIMKLEHC<TSrc, TValue> OGEEDFMKKPO<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(OIPEIMKLEHC<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct OIPEIMKLEHC<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> HHAMBPGBENG;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
		public OIPEIMKLEHC(NativeArray<TSrc> HHAMBPGBENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public FLHBIHICPHL<TSrc, TValue, TSelector> HJAGMAGJAJL<TSelector>() where TSelector : struct, FGHHEMNGJLM<TSrc, TValue>
		{
			return default(FLHBIHICPHL<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public readonly struct FLHBIHICPHL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FGHHEMNGJLM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> HHAMBPGBENG;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
		public FLHBIHICPHL(NativeArray<TSrc> HHAMBPGBENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x361DB80", Offset = "0x361C980", VA = "0x18361DB80")]
		public JIBNIFFCLAI<TSrc, TValue, TSelector> DDBJCMIAPHG()
		{
			return default(JIBNIFFCLAI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MLBPIHHCIIJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FGHHEMNGJLM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> HHAMBPGBENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TSelector DBECBFBNNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int OHINPGIGDNE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3E2E3A0", Offset = "0x3E2D1A0", VA = "0x183E2E3A0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LNBHMBDGGMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA11C10", Offset = "0xA10A10", VA = "0x180A11C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EINKGEEBGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DA0020", Offset = "0x1D9EE20", VA = "0x181DA0020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E520", Offset = "0x3E2D320", VA = "0x183E2E520")]
		public MLBPIHHCIIJ(NativeArray<TSrc> HHAMBPGBENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E510", Offset = "0x3E2D310", VA = "0x183E2E510")]
		public bool PDPJKIMIJLO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E430", Offset = "0x3E2D230", VA = "0x183E2E430")]
		private TSrc LHAHKJCFIHN(int GKGOKFIMAIP)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct JIBNIFFCLAI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FGHHEMNGJLM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private MLBPIHHCIIJ<TSrc, TValue, TSelector> GKFDOPGLMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TValue HCAMJOKNPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int NIAPLMNAGEM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HNKGNDEHEKK KJNJPHGIIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3A6ABA0", Offset = "0x3A699A0", VA = "0x183A6ABA0")]
			get
			{
				return default(HNKGNDEHEKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue OGFLGLMALCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, HNKGNDEHEKK range) OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3A6AAC0", Offset = "0x3A698C0", VA = "0x183A6AAC0")]
			get
			{
				return default((TValue, HNKGNDEHEKK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3A6AD20", Offset = "0x3A69B20", VA = "0x183A6AD20")]
		public JIBNIFFCLAI(NativeArray<TSrc> HHAMBPGBENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3613680", Offset = "0x3612480", VA = "0x183613680")]
		public JIBNIFFCLAI<TSrc, TValue, TSelector> GGNEAJGHJIC()
		{
			return default(JIBNIFFCLAI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3A6ABE0", Offset = "0x3A699E0", VA = "0x183A6ABE0")]
		public bool PDPJKIMIJLO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28685D0", Offset = "0x28673D0", VA = "0x1828685D0")]
	public static PGNCLBNNIIO<T> BMHDCOGPAHH<T>(this NativeList<T> MOAFNEBEDKD) where T : struct
	{
		return default(PGNCLBNNIIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
	public static PGNCLBNNIIO<T> BMHDCOGPAHH<T>(this NativeArray<T> HHAMBPGBENG) where T : struct
	{
		return default(PGNCLBNNIIO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class AGFCIJKJDHE
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DEIONBNDODH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<T>.ReadOnly HHAMBPGBENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int NIAPLMNAGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int BCICOMKFAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T HCAMJOKNPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private T ABBAOAOPHAN;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HNKGNDEHEKK KJNJPHGIIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3B00990", Offset = "0x3AFF790", VA = "0x183B00990")]
			get
			{
				return default(HNKGNDEHEKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T OGFLGLMALCL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x330D750", Offset = "0x330C550", VA = "0x18330D750")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, HNKGNDEHEKK) OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5037A10", Offset = "0x5036810", VA = "0x185037A10")]
			get
			{
				return default((T, HNKGNDEHEKK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5037F80", Offset = "0x5036D80", VA = "0x185037F80")]
		public DEIONBNDODH(NativeArray<T> HHAMBPGBENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5037B90", Offset = "0x5036990", VA = "0x185037B90")]
		public DEIONBNDODH<T> GGNEAJGHJIC()
		{
			return default(DEIONBNDODH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5037DA0", Offset = "0x5036BA0", VA = "0x185037DA0")]
		public bool PDPJKIMIJLO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x22A2D80", Offset = "0x22A1B80", VA = "0x1822A2D80")]
		public KCEJFGPAGOH<T, TComparer> BGKJNKBKPBH<TComparer>([Optional] TComparer KNMBDFHBHCL) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KCEJFGPAGOH<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct KCEJFGPAGOH<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T>.ReadOnly HHAMBPGBENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int NIAPLMNAGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int BCICOMKFAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T HCAMJOKNPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private T ABBAOAOPHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TComparer KNMBDFHBHCL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HNKGNDEHEKK KJNJPHGIIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3B00990", Offset = "0x3AFF790", VA = "0x183B00990")]
			get
			{
				return default(HNKGNDEHEKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T OGFLGLMALCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x330D750", Offset = "0x330C550", VA = "0x18330D750")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B00B80", Offset = "0x3AFF980", VA = "0x183B00B80")]
		public KCEJFGPAGOH(NativeArray<T>.ReadOnly HHAMBPGBENG, TComparer KNMBDFHBHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B009A0", Offset = "0x3AFF7A0", VA = "0x183B009A0")]
		public bool PDPJKIMIJLO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF50C0", Offset = "0x2CF3EC0", VA = "0x182CF50C0")]
	public static DEIONBNDODH<T> DDBJCMIAPHG<T>(this NativeArray<T> HHAMBPGBENG) where T : struct
	{
		return default(DEIONBNDODH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface PNDLGHCGAIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class CAAKODANCGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct HAAMKAGCPPM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class BHAEBBDPGEB : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HAAMKAGCPPM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA86DC0", VA = "0x180A87FC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3686240", Offset = "0x3685040", VA = "0x183686240", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
		[DebuggerHidden]
		public BHAEBBDPGEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x477ADE0", Offset = "0x4779BE0", VA = "0x18477ADE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x477AF90", Offset = "0x4779D90", VA = "0x18477AF90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Action<Protobuf> OEHEGBNAMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MemoryStream KLGEPLBEDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CodedInputStream LNEDPFCGAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Protobuf BNOKDAFJOOH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int EINKGEEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x377A030", Offset = "0x3778E30", VA = "0x18377A030", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x377A070", Offset = "0x3778E70", VA = "0x18377A070", Slot = "4")]
	[IteratorStateMachine(typeof(HAAMKAGCPPM<>.BHAEBBDPGEB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x377A160", Offset = "0x3778F60", VA = "0x18377A160", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PHDHMFMNAEE<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly byte[] LIICAAPCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Protobuf BNOKDAFJOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream KLGEPLBEDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedOutputStream OMDGBHGIDGD;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x40A8E80", Offset = "0x40A7C80", VA = "0x1840A8E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct ILKJCCMGLMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream KLGEPLBEDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedInputStream LNEDPFCGAIG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61A1120", Offset = "0x619FF20", VA = "0x1861A1120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct KOGAHHNICMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly byte[] LIICAAPCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MemoryStream KLGEPLBEDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CodedOutputStream OMDGBHGIDGD;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61A1200", Offset = "0x61A0000", VA = "0x1861A1200", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class BCFMKOOLDEH
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class FFMDLNGDFKO
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
public enum CPCOBJPAGOD
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
internal static class MDEKCPEOGDC
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class HPJJGAKKNAL
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HPJJGAKKNAL()
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
