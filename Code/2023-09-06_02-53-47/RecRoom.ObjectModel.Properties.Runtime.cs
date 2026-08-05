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
public interface OJKEOMAIHDJ : IEnumerable<EPFAAOCCGEJ>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EPFAAOCCGEJ : ELEHKEJLDOI<Entity>, DPMGHPGKEOP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IKCKKLFHJIF<T> : CGAFBLACJDG<Entity, T>, ELEHKEJLDOI<Entity>, DPMGHPGKEOP, IDisposable, EPFAAOCCGEJ where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface HMKAMBJMBEO : EPFAAOCCGEJ, ELEHKEJLDOI<Entity>, DPMGHPGKEOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int DACJLJGFJGE
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
public static class GKGLGPKGNFF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B40B10", Offset = "0x2B3F110", VA = "0x182B40B10")]
	public static T NHHIBJFEODA<T>(this IKCKKLFHJIF<T> JCPKNOEICEG, Entity MPAGCMNFGMI, [Optional] T INIEFLCMFEE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xF3F060", Offset = "0xF3D660", VA = "0x180F3F060")]
	public static T KMEKHMMFBCC<T>(this ELEHKEJLDOI<Entity> JCPKNOEICEG, Entity MPAGCMNFGMI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B40890", Offset = "0x2B3EE90", VA = "0x182B40890")]
	public static bool ALGMGODHEFB<T>(this ELEHKEJLDOI<Entity> JCPKNOEICEG, Entity MPAGCMNFGMI, in T KIFJIAOCCHE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ELBEJOMIKKE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int FKGHPFPOALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int CEEPGPEEPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type FOFEDJIHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EPFAAOCCGEJ[] GIEKDLKKKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) GDKCFJKPHMK(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMHHHBOFGAN(Entity MPAGCMNFGMI, (uint order, uint change) MPNDOHBKHJO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EKFMAGKKLBM : HMKAMBJMBEO, EPFAAOCCGEJ, ELEHKEJLDOI<Entity>, DPMGHPGKEOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type BJFLOLKBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract ELBEJOMIKKE BPNKBLLBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract GFLOPFFPDHK KEMBFLMAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DACJLJGFJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA39CC0", Offset = "0xA382C0", VA = "0x180A39CC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OOHBGLFCNLM<Entity> NBFJOBLBGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1DE0", Offset = "0x6FF03E0", VA = "0x186FF1DE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1E80", Offset = "0x6FF0480", VA = "0x186FF1E80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool AFPHGIBLJIN(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void MBNHJLNEIKL(Entity MPAGCMNFGMI, CIACNBAJNFM MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool FGMAFKALEHD(Entity MPAGCMNFGMI, NGKHEJGAHGD KIFJIAOCCHE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void IBBEGLBGAJD(KJPEBAGBPMP MIBBABDJMFM, [Optional] object MFPELEJLJLD);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool MOAONFLIEIF(Entity GGCKOLILJHC, Entity POIAHNIMHKJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void GMAKAKECEDK(EntityManager PHHGGAMLDGB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32FF620", Offset = "0x32FDC20", VA = "0x1832FF620")]
	protected void PEACALAFNBP<T>(Entity MPAGCMNFGMI, in T MDNKPPKLBGD, in T KIFJIAOCCHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected EKFMAGKKLBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class FEHHJLHONFC<T> : EKFMAGKKLBM, IKCKKLFHJIF<T>, CGAFBLACJDG<Entity, T>, ELEHKEJLDOI<Entity>, DPMGHPGKEOP, IDisposable, EPFAAOCCGEJ, GFLOPFFPDHK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool PGEBCCBMBAG(Entity MPAGCMNFGMI, in T KIFJIAOCCHE);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void PHFBADAEIIM(Entity MPAGCMNFGMI, in T MDNKPPKLBGD, in T KIFJIAOCCHE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ELBEJOMIKKE OKKDBGDAAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo PIEGKEOCPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int MPGHGDABPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int EBMCNIDEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int OCMPILAHMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PGEBCCBMBAG LKJMFMFNAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private PHFBADAEIIM IMPGOFOAKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PHFBADAEIIM MMPIJCMCJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World DDODGIBMPPP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type BJFLOLKBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49E0830", Offset = "0x49DEE30", VA = "0x1849E0830", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override ELBEJOMIKKE BPNKBLLBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override GFLOPFFPDHK KEMBFLMAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo NPAGPNLNCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int GAINBAOECIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C20", Offset = "0x9A8220", VA = "0x1809A9C20", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int KAMBJHEMDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B35B0", Offset = "0x9B1BB0", VA = "0x1809B35B0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x49DFDC0", Offset = "0x49DE3C0", VA = "0x1849DFDC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49E0EF0", Offset = "0x49DF4F0", VA = "0x1849E0EF0")]
	public FEHHJLHONFC(string ECMAPGHKHFB, ELBEJOMIKKE OKKDBGDAAMO, FieldInfo PIEGKEOCPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49DFD60", Offset = "0x49DE360", VA = "0x1849DFD60", Slot = "28")]
	public override void GMAKAKECEDK(EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B25500", Offset = "0x3B23B00", VA = "0x183B25500")]
	public FEHHJLHONFC<T> DCKGLCGBFOG(PGEBCCBMBAG LKJMFMFNAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B25540", Offset = "0x3B23B40", VA = "0x183B25540")]
	public FEHHJLHONFC<T> OELOPINMHEM(PHFBADAEIIM IMPGOFOAKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B254E0", Offset = "0x3B23AE0", VA = "0x183B254E0")]
	public FEHHJLHONFC<T> BFFPFPOIBPB(PHFBADAEIIM MMPIJCMCJJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x50AAE50", Offset = "0x50A9450", VA = "0x1850AAE50", Slot = "29")]
	public T MBNHJLNEIKL(Entity MPAGCMNFGMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x50A9250", Offset = "0x50A7850", VA = "0x1850A9250")]
	public bool FGMAFKALEHD(Entity MPAGCMNFGMI, in T KIFJIAOCCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49DE860", Offset = "0x49DCE60", VA = "0x1849DE860")]
	public bool EINBPMFCNKO(Entity MPAGCMNFGMI, in T KIFJIAOCCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49DE7B0", Offset = "0x49DCDB0", VA = "0x1849DE7B0", Slot = "22")]
	public override bool AFPHGIBLJIN(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49E0010", Offset = "0x49DE610", VA = "0x1849E0010", Slot = "23")]
	public override void MBNHJLNEIKL(Entity MPAGCMNFGMI, CIACNBAJNFM MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49DE8A0", Offset = "0x49DCEA0", VA = "0x1849DE8A0", Slot = "24")]
	public override bool FGMAFKALEHD(Entity MPAGCMNFGMI, NGKHEJGAHGD KIFJIAOCCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49DFD90", Offset = "0x49DE390", VA = "0x1849DFD90", Slot = "25")]
	public override void IBBEGLBGAJD(KJPEBAGBPMP MIBBABDJMFM, [Optional] object MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49E0470", Offset = "0x49DEA70", VA = "0x1849E0470", Slot = "26")]
	public override bool MOAONFLIEIF(Entity GGCKOLILJHC, Entity POIAHNIMHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x49DE810", Offset = "0x49DCE10", VA = "0x1849DE810")]
	private bool AOBJECGJDBA(ref T MDNKPPKLBGD, ref T KIFJIAOCCHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void OOHBGLFCNLM<TKey>(TKey NKFOPKJGBEM, in NGKHEJGAHGD MDNKPPKLBGD, in NGKHEJGAHGD KIFJIAOCCHE);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NKFFBDPGPKB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20B0850", Offset = "0x20AEE50", VA = "0x1820B0850")]
	public static void JLDGENJLEHM<TKey, T>(this OOHBGLFCNLM<TKey> MOPPIPMIDBH, TKey NKFOPKJGBEM, T MDNKPPKLBGD, T KIFJIAOCCHE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KJPEBAGBPMP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLOJBGGCPJ<TKey, T>(CGAFBLACJDG<TKey, T> JCPKNOEICEG, [Optional] object MFPELEJLJLD) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MBCNLNPLHPE
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GFLOPFFPDHK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo JKIIFAPKABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int ENMONBGIHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int JLLEAFLJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DPMGHPGKEOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type BJFLOLKBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GFLOPFFPDHK KEMBFLMAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ELBEJOMIKKE BPNKBLLBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int DACJLJGFJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IBBEGLBGAJD(KJPEBAGBPMP MIBBABDJMFM, [Optional] object MFPELEJLJLD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ELEHKEJLDOI<TKey> : DPMGHPGKEOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OOHBGLFCNLM<TKey> NBFJOBLBGDE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFPHGIBLJIN(TKey BOMEFJIOGGM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBNHJLNEIKL(TKey BOMEFJIOGGM, CIACNBAJNFM MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FGMAFKALEHD(TKey BOMEFJIOGGM, NGKHEJGAHGD KIFJIAOCCHE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MOAONFLIEIF(TKey GGCKOLILJHC, TKey POIAHNIMHKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface CGAFBLACJDG<TKey, T> : ELEHKEJLDOI<TKey>, DPMGHPGKEOP, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T MBNHJLNEIKL(TKey BOMEFJIOGGM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CAADKHEGPID
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3090110", Offset = "0x308E710", VA = "0x183090110")]
	public static bool BBDOIOJLDPI<TKey, T>(this ELEHKEJLDOI<TKey> JCPKNOEICEG, TKey BOMEFJIOGGM, out T MOLEJFDINLH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3090BC0", Offset = "0x308F1C0", VA = "0x183090BC0")]
	public static T MBNHJLNEIKL<T, TKey>(this ELEHKEJLDOI<TKey> JCPKNOEICEG, TKey BOMEFJIOGGM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x30902B0", Offset = "0x308E8B0", VA = "0x1830902B0")]
	public static bool FGMAFKALEHD<TKey, T>(this ELEHKEJLDOI<TKey> JCPKNOEICEG, TKey BOMEFJIOGGM, T KIFJIAOCCHE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CNGBAJDBKGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type BJDOACDNPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string ECMAPGHKHFB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
	public CNGBAJDBKGM(Type BJDOACDNPGH, string ECMAPGHKHFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GOHNKJBJJHB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type BJDOACDNPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string ECMAPGHKHFB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
	public GOHNKJBJJHB(Type BJDOACDNPGH, string ECMAPGHKHFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x33CA3F0", Offset = "0x33C89F0", VA = "0x1833CA3F0")]
	public static CNGBAJDBKGM JAIGELGEDCG(GOHNKJBJJHB<T> MHJDBAPOFEE)
	{
		return default(CNGBAJDBKGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum NEAJFKGIJJE
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
public class GBEMJDIMABH : OJKEOMAIHDJ, IEnumerable<EPFAAOCCGEJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<EPFAAOCCGEJ> KFCLMJJDOMD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2410", Offset = "0x6FF0A10", VA = "0x186FF2410", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EPFAAOCCGEJ ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2450", Offset = "0x6FF0A50", VA = "0x186FF2450", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2530", Offset = "0x6FF0B30", VA = "0x186FF2530")]
	public GBEMJDIMABH(IEnumerable<ELBEJOMIKKE> KAKOCMILJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1F20", Offset = "0x6FF0520", VA = "0x186FF1F20")]
	private List<EPFAAOCCGEJ> BBKELEPPNPK(IEnumerable<ELBEJOMIKKE> KAKOCMILJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF24B0", Offset = "0x6FF0AB0", VA = "0x186FF24B0", Slot = "4")]
	public IEnumerator<EPFAAOCCGEJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF24B0", Offset = "0x6FF0AB0", VA = "0x186FF24B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JCIBJNJLFPG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JCIBJNJLFPG()
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
