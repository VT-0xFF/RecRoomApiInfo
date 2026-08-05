using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public interface GGJBBFGLLDC : IEnumerable<KEJDGFDNFFK>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KEJDGFDNFFK : IEPDOHHLJHK<Entity>, LKKBEGLFKGM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CLMFLEAINNI<T> : FIPEENHHKAO<Entity, T>, IEPDOHHLJHK<Entity>, LKKBEGLFKGM, IDisposable, KEJDGFDNFFK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface APMICJHILNL : KEJDGFDNFFK, IEPDOHHLJHK<Entity>, LKKBEGLFKGM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int HCGDGPKMKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CDLACMCFIEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21BF400", Offset = "0x21BE800", VA = "0x1821BF400")]
	public static T EJIHMNGFFPB<T>(this CLMFLEAINNI<T> LEMJCNJPDLJ, Entity GKMECPLEALF, [Optional] T CHKFHALGEFG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1022370", Offset = "0x1021770", VA = "0x181022370")]
	public static T OIHEHOMKKLI<T>(this IEPDOHHLJHK<Entity> LEMJCNJPDLJ, Entity GKMECPLEALF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21BF620", Offset = "0x21BEA20", VA = "0x1821BF620")]
	public static bool OILNDJNBOIN<T>(this IEPDOHHLJHK<Entity> LEMJCNJPDLJ, Entity GKMECPLEALF, in T PINJDLEFOFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LFHCENHMBCH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int GPPIIHCJKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OEBBNLFJOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type ICNKMGDBELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KEJDGFDNFFK[] AELEPOEPMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) LENCHPICOIF(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMNIIBHEDHA(Entity GKMECPLEALF, (uint order, uint change) LJJHJABONIO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class FEJOICGFFPG : APMICJHILNL, KEJDGFDNFFK, IEPDOHHLJHK<Entity>, LKKBEGLFKGM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type OILIJCDIDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract LFHCENHMBCH GOPBFOMCJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract ENOELDAICIL LMBDELGFHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HCGDGPKMKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA1F6B0", Offset = "0xA1EAB0", VA = "0x180A1F6B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IAFCDGIJOEA<Entity> HLFBHENDGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x722AB90", Offset = "0x7229F90", VA = "0x18722AB90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x722AC30", Offset = "0x722A030", VA = "0x18722AC30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool HFDNCCJGOAI(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void PHGLOPEHIMO(Entity GKMECPLEALF, KKEKCMELKKJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool AFLFAPDAOKF(Entity GKMECPLEALF, CIMGDHMJEHM PINJDLEFOFM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void OMAPCNDDLGL(EJLEFJCKIEJ ACLKHAFOJLC, [Optional] object AKPCLGIGABA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool EMCLIHJFPMF(Entity NBCAFBHOFIE, Entity CIDBOBPIINF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void MHIDNOPDKCM(EntityManager BEBIJONEMLA);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x17ABA80", Offset = "0x17AAE80", VA = "0x1817ABA80")]
	protected void EOEIMPDJOMB<T>(Entity GKMECPLEALF, in T FNIKJMODJCE, in T PINJDLEFOFM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	protected FEJOICGFFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class DFGKOFELELE<T> : FEJOICGFFPG, CLMFLEAINNI<T>, FIPEENHHKAO<Entity, T>, IEPDOHHLJHK<Entity>, LKKBEGLFKGM, IDisposable, KEJDGFDNFFK, ENOELDAICIL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool HNFJHCGIAKN(Entity GKMECPLEALF, in T PINJDLEFOFM);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void HBMHPKFDAAD(Entity GKMECPLEALF, in T FNIKJMODJCE, in T PINJDLEFOFM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LFHCENHMBCH PPBHHNGAHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo OJBBCFPKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int DCJNJIADGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int AEHKIMOEIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int AJCINIIEJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HNFJHCGIAKN MNOJEHHLKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private HBMHPKFDAAD AOLGGILCNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private HBMHPKFDAAD OJEPNBNGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World GLBDCLCAOJH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type OILIJCDIDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2E30DC0", Offset = "0x2E301C0", VA = "0x182E30DC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override LFHCENHMBCH GOPBFOMCJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override ENOELDAICIL LMBDELGFHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo JLJCCJIHANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int JIACLBNACEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1E01180", Offset = "0x1E00580", VA = "0x181E01180", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int NPEKBLOAIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9E6F00", Offset = "0x9E6300", VA = "0x1809E6F00", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2E31060", Offset = "0x2E30460", VA = "0x182E31060")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2E31690", Offset = "0x2E30A90", VA = "0x182E31690")]
	public DFGKOFELELE(string GDKOBCHHFLB, LFHCENHMBCH PPBHHNGAHEA, FieldInfo OJBBCFPKHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2E310E0", Offset = "0x2E304E0", VA = "0x182E310E0", Slot = "28")]
	public override void MHIDNOPDKCM(EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2E30A20", Offset = "0x2E2FE20", VA = "0x182E30A20")]
	public DFGKOFELELE<T> EBJGANKJGFC(HNFJHCGIAKN MNOJEHHLKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2E31110", Offset = "0x2E30510", VA = "0x182E31110")]
	public DFGKOFELELE<T> NJACNANLPFB(HBMHPKFDAAD AOLGGILCNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2E30A00", Offset = "0x2E2FE00", VA = "0x182E30A00")]
	public DFGKOFELELE<T> BLPBEEFDFNN(HBMHPKFDAAD OJEPNBNGMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61BA800", Offset = "0x61B9C00", VA = "0x1861BA800", Slot = "29")]
	public T PHGLOPEHIMO(Entity GKMECPLEALF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2E2FE40", Offset = "0x2E2F240", VA = "0x182E2FE40")]
	public bool AFLFAPDAOKF(Entity GKMECPLEALF, in T PINJDLEFOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2E31160", Offset = "0x2E30560", VA = "0x182E31160")]
	public bool PDDAAAMJIIA(Entity GKMECPLEALF, in T PINJDLEFOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2E31080", Offset = "0x2E30480", VA = "0x182E31080", Slot = "22")]
	public override bool HFDNCCJGOAI(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2E31300", Offset = "0x2E30700", VA = "0x182E31300", Slot = "23")]
	public override void PHGLOPEHIMO(Entity GKMECPLEALF, KKEKCMELKKJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2E2FAD0", Offset = "0x2E2EED0", VA = "0x182E2FAD0", Slot = "24")]
	public override bool AFLFAPDAOKF(Entity GKMECPLEALF, CIMGDHMJEHM PINJDLEFOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2E31130", Offset = "0x2E30530", VA = "0x182E31130", Slot = "25")]
	public override void OMAPCNDDLGL(EJLEFJCKIEJ ACLKHAFOJLC, [Optional] object AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2E30B50", Offset = "0x2E2FF50", VA = "0x182E30B50", Slot = "26")]
	public override bool EMCLIHJFPMF(Entity NBCAFBHOFIE, Entity CIDBOBPIINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2E30A40", Offset = "0x2E2FE40", VA = "0x182E30A40")]
	private bool EKENCFDIDKH(ref T FNIKJMODJCE, ref T PINJDLEFOFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void IAFCDGIJOEA<TKey>(TKey HFAGBIOODHL, in CIMGDHMJEHM FNIKJMODJCE, in CIMGDHMJEHM PINJDLEFOFM);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KBFBMPLFIFM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1D90940", Offset = "0x1D8FD40", VA = "0x181D90940")]
	public static void LABHLMFNFCH<TKey, T>(this IAFCDGIJOEA<TKey> IDKFBDPGAII, TKey HFAGBIOODHL, T FNIKJMODJCE, T PINJDLEFOFM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EJLEFJCKIEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEGICBEPEAB<TKey, T>(FIPEENHHKAO<TKey, T> LEMJCNJPDLJ, [Optional] object AKPCLGIGABA) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HKPLLFOBCKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ENOELDAICIL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo BDHNGDFNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int ENIJHDDIJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MMHHHCFJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LKKBEGLFKGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type OILIJCDIDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	ENOELDAICIL LMBDELGFHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LFHCENHMBCH GOPBFOMCJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int HCGDGPKMKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMAPCNDDLGL(EJLEFJCKIEJ ACLKHAFOJLC, [Optional] object AKPCLGIGABA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IEPDOHHLJHK<TKey> : LKKBEGLFKGM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event IAFCDGIJOEA<TKey> HLFBHENDGNL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFDNCCJGOAI(TKey PMMAAICOJOP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHGLOPEHIMO(TKey PMMAAICOJOP, KKEKCMELKKJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AFLFAPDAOKF(TKey PMMAAICOJOP, CIMGDHMJEHM PINJDLEFOFM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EMCLIHJFPMF(TKey NBCAFBHOFIE, TKey CIDBOBPIINF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface FIPEENHHKAO<TKey, T> : IEPDOHHLJHK<TKey>, LKKBEGLFKGM, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T PHGLOPEHIMO(TKey PMMAAICOJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EHDJMLGCANE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x223D280", Offset = "0x223C680", VA = "0x18223D280")]
	public static bool HBBLEOHJDFE<TKey, T>(this IEPDOHHLJHK<TKey> LEMJCNJPDLJ, TKey PMMAAICOJOP, out T AGLCIEKHLEE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x223D420", Offset = "0x223C820", VA = "0x18223D420")]
	public static T PHGLOPEHIMO<T, TKey>(this IEPDOHHLJHK<TKey> LEMJCNJPDLJ, TKey PMMAAICOJOP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x223C970", Offset = "0x223BD70", VA = "0x18223C970")]
	public static bool AFLFAPDAOKF<TKey, T>(this IEPDOHHLJHK<TKey> LEMJCNJPDLJ, TKey PMMAAICOJOP, T PINJDLEFOFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LOHCJILDMLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type FEPLAPMKDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string GDKOBCHHFLB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
	public LOHCJILDMLL(Type FEPLAPMKDOJ, string GDKOBCHHFLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ENIPADEGOMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type FEPLAPMKDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string GDKOBCHHFLB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
	public ENIPADEGOMD(Type FEPLAPMKDOJ, string GDKOBCHHFLB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x137F920", Offset = "0x137ED20", VA = "0x18137F920")]
	public static LOHCJILDMLL LMCGKCGMNCH(ENIPADEGOMD<T> HAIJKGCOLFL)
	{
		return default(LOHCJILDMLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IKIMHAJFALO
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	External = -6
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class OPKICLGEFDB : GGJBBFGLLDC, IEnumerable<KEJDGFDNFFK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<KEJDGFDNFFK> KEAAHNIFHJP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x722B2A0", Offset = "0x722A6A0", VA = "0x18722B2A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KEJDGFDNFFK ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x722B1C0", Offset = "0x722A5C0", VA = "0x18722B1C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x722B2E0", Offset = "0x722A6E0", VA = "0x18722B2E0")]
	public OPKICLGEFDB(IEnumerable<LFHCENHMBCH> NMNDEJLILOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x722ACD0", Offset = "0x722A0D0", VA = "0x18722ACD0")]
	private List<KEJDGFDNFFK> FCAIDKCEBCP(IEnumerable<LFHCENHMBCH> NMNDEJLILOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x722B220", Offset = "0x722A620", VA = "0x18722B220", Slot = "4")]
	public IEnumerator<KEJDGFDNFFK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x722B220", Offset = "0x722A620", VA = "0x18722B220", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MGDDIBLAEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MGDDIBLAEHJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
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
