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
public sealed class NNNMGBCNMPI<TContainer, TField> : DLCMGKLPIIF<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3955620", Offset = "0x3954020", VA = "0x183955620")]
	public NNNMGBCNMPI(string HBOONHFLONJ, NDDDMNDCPMH OMFPMCIAPMD, FieldInfo HGNGLPBJEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46CEE30", Offset = "0x46CD830", VA = "0x1846CEE30", Slot = "26")]
	public override bool IDPEEMDPGBG(Entity HLKOPNMJGHO, LNHCPJIMKAE ANAJBMGGMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x46CEA40", Offset = "0x46CD440", VA = "0x1846CEA40", Slot = "32")]
	public override OADCFHDMLKB DNEGMONCCLH(EntityManager DLCMJBOHANK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class EDBPAJJANKO<T> : DLCMGKLPIIF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3955620", Offset = "0x3954020", VA = "0x183955620")]
	public EDBPAJJANKO(string HBOONHFLONJ, NDDDMNDCPMH OMFPMCIAPMD, FieldInfo HGNGLPBJEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3955530", Offset = "0x3953F30", VA = "0x183955530", Slot = "32")]
	public override OADCFHDMLKB DNEGMONCCLH(EntityManager DLCMJBOHANK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class DLCMGKLPIIF<T> : OJILGANHGGJ, GCOOAMPOEII<T>, DLFIHAKFFEP<Entity, T>, EFAPCHNMOJD<Entity>, JAKKDLLLILG, IDisposable, OADCFHDMLKB, JBJCIGIBFNM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool NJKNBPAFPON(Entity HLKOPNMJGHO, [In] T ANAJBMGGMGD);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void GIPGEHHCNKO(Entity HLKOPNMJGHO, [In] T PHFEBPEGINI, [In] T ANAJBMGGMGD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NDDDMNDCPMH OMFPMCIAPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo HGNGLPBJEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int NNGGOAJPOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int ELDAPMPELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int MPLHLKNKHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NJKNBPAFPON DMGGMEJCLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private GIPGEHHCNKO JOAPEDBGIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GIPGEHHCNKO AIHAKBJNFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World HHLCCPFFGLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type HMGDADDECHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5A6BAF0", Offset = "0x5A6A4F0", VA = "0x185A6BAF0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override NDDDMNDCPMH JKMCGDHGDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override JBJCIGIBFNM LHNKGBNJELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo JMFEBKFCABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int FJEMACAKODC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A2530", Offset = "0x8A0F30", VA = "0x1808A2530", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int HBLBAKMEFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x893630", Offset = "0x892030", VA = "0x180893630", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager DPEGDPAJBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5A71F10", Offset = "0x5A70910", VA = "0x185A71F10")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5A74B30", Offset = "0x5A73530", VA = "0x185A74B30")]
	internal DLCMGKLPIIF(string HBOONHFLONJ, NDDDMNDCPMH OMFPMCIAPMD, FieldInfo HGNGLPBJEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5A721D0", Offset = "0x5A70BD0", VA = "0x185A721D0", Slot = "30")]
	public override void PCEEADECCDH(EntityManager PBPLCKDKLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5A6C150", Offset = "0x5A6AB50", VA = "0x185A6C150")]
	public DLCMGKLPIIF<T> IDHKMKLDCGJ(NJKNBPAFPON DMGGMEJCLKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5A70AA0", Offset = "0x5A6F4A0", VA = "0x185A70AA0")]
	public DLCMGKLPIIF<T> IFDPDNKHODB(GIPGEHHCNKO JOAPEDBGIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5A6B020", Offset = "0x5A69A20", VA = "0x185A6B020")]
	public DLCMGKLPIIF<T> GEGHJMLLMHL(GIPGEHHCNKO AIHAKBJNFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5A72D30", Offset = "0x5A71730", VA = "0x185A72D30", Slot = "33")]
	public T PHNOCPFLPNG(Entity HLKOPNMJGHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5A6F1A0", Offset = "0x5A6DBA0", VA = "0x185A6F1A0")]
	public bool IDPEEMDPGBG(Entity HLKOPNMJGHO, [In] T ANAJBMGGMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5A6AF60", Offset = "0x5A69960", VA = "0x185A6AF60")]
	public bool DACINGNFNGE(Entity HLKOPNMJGHO, [In] T ANAJBMGGMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5A70EE0", Offset = "0x5A6F8E0", VA = "0x185A70EE0", Slot = "24")]
	public override bool KAMLGAEHELA(Entity HLKOPNMJGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5A732E0", Offset = "0x5A71CE0", VA = "0x185A732E0", Slot = "25")]
	public override void PHNOCPFLPNG(Entity HLKOPNMJGHO, DIHDMLIICIG CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D0C0", Offset = "0x5A6BAC0", VA = "0x185A6D0C0", Slot = "26")]
	public override bool IDPEEMDPGBG(Entity HLKOPNMJGHO, LNHCPJIMKAE ANAJBMGGMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E5E1D0", Offset = "0x3E5CBD0", VA = "0x183E5E1D0", Slot = "27")]
	public override void GEDPAALKGKL(AHDAJCEDGKM APMFPMABNFA, [Optional] object GJGBLLHIOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5A6B390", Offset = "0x5A69D90", VA = "0x185A6B390", Slot = "28")]
	public override bool HDIAFBEKCKI(Entity FHIOPODCIDM, Entity CDNMICCKGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5A71890", Offset = "0x5A70290", VA = "0x185A71890", Slot = "31")]
	public override string KDHKCEMPOJG([In] LNHCPJIMKAE MNCDIGCMDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5A6AFB0", Offset = "0x5A699B0", VA = "0x185A6AFB0")]
	private bool FNBPDCLIINK(T PHFEBPEGINI, T ANAJBMGGMGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class OJILGANHGGJ : KAODCBMFKJD, OADCFHDMLKB, EFAPCHNMOJD<Entity>, JAKKDLLLILG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type HMGDADDECHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract NDDDMNDCPMH JKMCGDHGDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract JBJCIGIBFNM LHNKGBNJELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DPPCEHEGJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x918C60", VA = "0x18091A260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event HNIKMCABIGO<Entity> ADNFBFKFNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BB41E0", Offset = "0x6BB2BE0", VA = "0x186BB41E0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4130", Offset = "0x6BB2B30", VA = "0x186BB4130", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool KAMLGAEHELA(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void PHNOCPFLPNG(Entity HLKOPNMJGHO, DIHDMLIICIG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool IDPEEMDPGBG(Entity HLKOPNMJGHO, LNHCPJIMKAE ANAJBMGGMGD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void GEDPAALKGKL(AHDAJCEDGKM APMFPMABNFA, [Optional] object GJGBLLHIOAC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool HDIAFBEKCKI(Entity FHIOPODCIDM, Entity CDNMICCKGIM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void PCEEADECCDH(EntityManager PBPLCKDKLPP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E16060", Offset = "0x2E14A60", VA = "0x182E16060")]
	protected void ELCCEKAKAGD<T>(Entity HLKOPNMJGHO, [In] T PHFEBPEGINI, [In] T ANAJBMGGMGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string KDHKCEMPOJG([In] LNHCPJIMKAE MNCDIGCMDFI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract OADCFHDMLKB DNEGMONCCLH(EntityManager DLCMJBOHANK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected OJILGANHGGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OADCFHDMLKB : EFAPCHNMOJD<Entity>, JAKKDLLLILG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OADCFHDMLKB DNEGMONCCLH(EntityManager DLCMJBOHANK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GCOOAMPOEII<T> : DLFIHAKFFEP<Entity, T>, EFAPCHNMOJD<Entity>, JAKKDLLLILG, IDisposable, OADCFHDMLKB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface KAODCBMFKJD : OADCFHDMLKB, EFAPCHNMOJD<Entity>, JAKKDLLLILG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int DPPCEHEGJPO
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
public static class KHILDGJDGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D27140", Offset = "0x2D25B40", VA = "0x182D27140")]
	public static T ONNFIAEIKIP<T>(this GCOOAMPOEII<T> FMKCBFNEFEH, Entity HLKOPNMJGHO, [Optional] T PEMAOEALEHB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D27030", Offset = "0x2D25A30", VA = "0x182D27030")]
	public static T FBCNBGDNDPI<T>(this EFAPCHNMOJD<Entity> FMKCBFNEFEH, Entity HLKOPNMJGHO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D26EA0", Offset = "0x2D258A0", VA = "0x182D26EA0")]
	public static bool DLCIEAOOIGC<T>(this EFAPCHNMOJD<Entity> FMKCBFNEFEH, Entity HLKOPNMJGHO, [In] T ANAJBMGGMGD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D26DE0", Offset = "0x2D257E0", VA = "0x182D26DE0")]
	public static bool DLCIEAOOIGC<T>(this EFAPCHNMOJD<Entity> FMKCBFNEFEH, Entity HLKOPNMJGHO, NativeArray<T> ANAJBMGGMGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void HNIKMCABIGO<TKey>(TKey GIGIFGONEAO, [In] LNHCPJIMKAE PHFEBPEGINI, [In] LNHCPJIMKAE ANAJBMGGMGD);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BPBCADDOBPD
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E010", Offset = "0x2A2CA10", VA = "0x182A2E010")]
	public static void NPIHGHHDKCM<TKey, T>(this HNIKMCABIGO<TKey> ENCDAJFJKND, TKey GIGIFGONEAO, T PHFEBPEGINI, T ANAJBMGGMGD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AHDAJCEDGKM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGHBNAPMOOK<TKey, T>(DLFIHAKFFEP<TKey, T> FMKCBFNEFEH, [Optional] object GJGBLLHIOAC) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BNMLOKMOACM
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JBJCIGIBFNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo NMOFJCDEFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int JGJBOLABHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int GCMPBODBNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JAKKDLLLILG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type HMGDADDECHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JBJCIGIBFNM LHNKGBNJELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NDDDMNDCPMH JKMCGDHGDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int DPPCEHEGJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEDPAALKGKL(AHDAJCEDGKM APMFPMABNFA, [Optional] object GJGBLLHIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EFAPCHNMOJD<TKey> : JAKKDLLLILG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HNIKMCABIGO<TKey> ADNFBFKFNFM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KAMLGAEHELA(TKey JODEIIFHAPK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHNOCPFLPNG(TKey JODEIIFHAPK, DIHDMLIICIG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IDPEEMDPGBG(TKey JODEIIFHAPK, LNHCPJIMKAE ANAJBMGGMGD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HDIAFBEKCKI(TKey FHIOPODCIDM, TKey CDNMICCKGIM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string KDHKCEMPOJG([In] LNHCPJIMKAE CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface DLFIHAKFFEP<TKey, T> : EFAPCHNMOJD<TKey>, JAKKDLLLILG, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T PHNOCPFLPNG(TKey JODEIIFHAPK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CGAKGOCMFLH
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2AB90B0", Offset = "0x2AB7AB0", VA = "0x182AB90B0")]
	public static bool MJGHNDKEOOO<TKey, T>(this EFAPCHNMOJD<TKey> FMKCBFNEFEH, TKey JODEIIFHAPK, [Out] T CLMKDBDPNNH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9620", Offset = "0x2AB8020", VA = "0x182AB9620")]
	public static T PHNOCPFLPNG<T, TKey>(this EFAPCHNMOJD<TKey> FMKCBFNEFEH, TKey JODEIIFHAPK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8AC0", Offset = "0x2AB74C0", VA = "0x182AB8AC0")]
	public static bool IDPEEMDPGBG<TKey, T>(this EFAPCHNMOJD<TKey> FMKCBFNEFEH, TKey JODEIIFHAPK, T ANAJBMGGMGD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8980", Offset = "0x2AB7380", VA = "0x182AB8980")]
	public static bool IDPEEMDPGBG<TKey, T>(this EFAPCHNMOJD<TKey> FMKCBFNEFEH, TKey JODEIIFHAPK, NativeArray<T> ANAJBMGGMGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface FDKIECAIGKL : IEnumerable<OADCFHDMLKB>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NDDDMNDCPMH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int IBCHCJONCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int NAAMMACFPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type KBLKPMDAJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	OADCFHDMLKB[] AOMIJPMLAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GKADGPPKEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) FBMAMADBGGB(Entity HLKOPNMJGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class JGKCKHADICI : FDKIECAIGKL, IEnumerable<OADCFHDMLKB>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<OADCFHDMLKB> BIGJAFGBOML;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3BA0", Offset = "0x6BB25A0", VA = "0x186BB3BA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OADCFHDMLKB MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3B40", Offset = "0x6BB2540", VA = "0x186BB3B40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB40F0", Offset = "0x6BB2AF0", VA = "0x186BB40F0")]
	public JGKCKHADICI(IEnumerable<NDDDMNDCPMH> FHBMCGOJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3C60", Offset = "0x6BB2660", VA = "0x186BB3C60")]
	private List<OADCFHDMLKB> NICICGBKLAB(IEnumerable<NDDDMNDCPMH> FHBMCGOJAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3BE0", Offset = "0x6BB25E0", VA = "0x186BB3BE0", Slot = "4")]
	public IEnumerator<OADCFHDMLKB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3BE0", Offset = "0x6BB25E0", VA = "0x186BB3BE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FCGMIGBJDCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type FDDKAPMPLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string HBOONHFLONJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	public FCGMIGBJDCN(Type FDDKAPMPLDJ, string HBOONHFLONJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct EIHNHHDOPEL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type FDDKAPMPLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string HBOONHFLONJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	public EIHNHHDOPEL(Type FDDKAPMPLDJ, string HBOONHFLONJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3972940", Offset = "0x3971340", VA = "0x183972940")]
	public static FCGMIGBJDCN IBCNELDCGLI(EIHNHHDOPEL<T> BNJJMDJPNPP)
	{
		return default(FCGMIGBJDCN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GDLIMCICJPL
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
public class HFMJLCPPHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public HFMJLCPPHLB()
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
