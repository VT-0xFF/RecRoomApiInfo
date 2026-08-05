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
public sealed class MLKDDKIGJAK<TContainer, TField> : IPHEKFAFAHM<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x400A7B0", Offset = "0x4009BB0", VA = "0x18400A7B0")]
	public MLKDDKIGJAK(string ADANIHOIEKJ, EDHPIEOENNM IMHKEPBHMIM, FieldInfo FLBKCCGDFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x48415F0", Offset = "0x48409F0", VA = "0x1848415F0", Slot = "26")]
	public override bool JOJCHNFNPDL(Entity GLFIOFJHMHG, PNKJNCEHIKB FFAPBOEDPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4841500", Offset = "0x4840900", VA = "0x184841500", Slot = "32")]
	public override HPAPLFGFAME FNBDODIKBHL(EntityManager BKLNKBBAABF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class BJIIKHENLAO<T> : IPHEKFAFAHM<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x400A7B0", Offset = "0x4009BB0", VA = "0x18400A7B0")]
	public BJIIKHENLAO(string ADANIHOIEKJ, EDHPIEOENNM IMHKEPBHMIM, FieldInfo FLBKCCGDFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x527ACE0", Offset = "0x527A0E0", VA = "0x18527ACE0", Slot = "32")]
	public override HPAPLFGFAME FNBDODIKBHL(EntityManager BKLNKBBAABF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class IPHEKFAFAHM<T> : PPCIBNMKKJN, PJMBKFJKHEG<T>, GHMELDLGACN<Entity, T>, PAFGOGNNLNG<Entity>, OBFHEFPJAGA, IDisposable, HPAPLFGFAME, DNJOFBEFNAN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool LOFGKKOBALO(Entity GLFIOFJHMHG, [In] T FFAPBOEDPIG);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void OMEDGGFGLBG(Entity GLFIOFJHMHG, [In] T HCDCAGFKELC, [In] T FFAPBOEDPIG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly EDHPIEOENNM IMHKEPBHMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo FLBKCCGDFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int BNBPOPFGKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int GMCJIJBLJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int MFKKELONDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LOFGKKOBALO LGJNLEEHEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private OMEDGGFGLBG HDMJLCJFIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private OMEDGGFGLBG EPOHNHJFOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World IIDMDFNKDKL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type MKIIDBFDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4240320", Offset = "0x423F720", VA = "0x184240320", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override EDHPIEOENNM LLPBGDDLFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override DNJOFBEFNAN GDAKIDHBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo BBNCNMAGGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int LDDMJLNPIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8A90", Offset = "0x8C7E90", VA = "0x1808C8A90", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int GPJMIKKELFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1F0", Offset = "0x8B95F0", VA = "0x1808BA1F0", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager KGDEHLJKOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4246BA0", Offset = "0x4245FA0", VA = "0x184246BA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4247E30", Offset = "0x4247230", VA = "0x184247E30")]
	internal IPHEKFAFAHM(string ADANIHOIEKJ, EDHPIEOENNM IMHKEPBHMIM, FieldInfo FLBKCCGDFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4242770", Offset = "0x4241B70", VA = "0x184242770", Slot = "30")]
	public override void JLABJFAHLGH(EntityManager POOMEDKNPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4246BE0", Offset = "0x4245FE0", VA = "0x184246BE0")]
	public IPHEKFAFAHM<T> KIIHFEBOPIM(LOFGKKOBALO LGJNLEEHEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4246BC0", Offset = "0x4245FC0", VA = "0x184246BC0")]
	public IPHEKFAFAHM<T> KIFDJNBOAKP(OMEDGGFGLBG HDMJLCJFIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4246C00", Offset = "0x4246000", VA = "0x184246C00")]
	public IPHEKFAFAHM<T> OOPFIOEJAHC(OMEDGGFGLBG EPOHNHJFOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4241370", Offset = "0x4240770", VA = "0x184241370", Slot = "33")]
	public T JEMJOLBMCNL(Entity GLFIOFJHMHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4243270", Offset = "0x4242670", VA = "0x184243270")]
	public bool JOJCHNFNPDL(Entity GLFIOFJHMHG, [In] T FFAPBOEDPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4240860", Offset = "0x423FC60", VA = "0x184240860")]
	public bool BHBNDJLDLHM(Entity GLFIOFJHMHG, [In] T FFAPBOEDPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4246CD0", Offset = "0x42460D0", VA = "0x184246CD0", Slot = "24")]
	public override bool PJAKFOIGPDG(Entity GLFIOFJHMHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4241590", Offset = "0x4240990", VA = "0x184241590", Slot = "25")]
	public override void JEMJOLBMCNL(Entity GLFIOFJHMHG, ONJJKKKIGOC LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42436C0", Offset = "0x4242AC0", VA = "0x1842436C0", Slot = "26")]
	public override bool JOJCHNFNPDL(Entity GLFIOFJHMHG, PNKJNCEHIKB FFAPBOEDPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4095280", Offset = "0x4094680", VA = "0x184095280", Slot = "27")]
	public override void IDKFFNFJCAM(ABIHPOLLOBL DPCHBCFGEPO, [Optional] object JCPOMHNJOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42408B0", Offset = "0x423FCB0", VA = "0x1842408B0", Slot = "28")]
	public override bool CAOLCICLPPL(Entity EDLJDADHMAM, Entity CAAJFPBAGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4243060", Offset = "0x4242460", VA = "0x184243060", Slot = "31")]
	public override string JLHCGHKALNH([In] PNKJNCEHIKB EMMPLEBMLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4241300", Offset = "0x4240700", VA = "0x184241300")]
	private bool GMGKPAMIGPB(T HCDCAGFKELC, T FFAPBOEDPIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PPCIBNMKKJN : EBOBMGFACGA, HPAPLFGFAME, PAFGOGNNLNG<Entity>, OBFHEFPJAGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type MKIIDBFDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract EDHPIEOENNM LLPBGDDLFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract DNJOFBEFNAN GDAKIDHBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KIKHFCMICOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA8F190", Offset = "0xA8E590", VA = "0x180A8F190", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OPDDPNNHEAM<Entity> BPFGLGMPDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DF9580", Offset = "0x6DF8980", VA = "0x186DF9580", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DF94D0", Offset = "0x6DF88D0", VA = "0x186DF94D0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool PJAKFOIGPDG(Entity GLFIOFJHMHG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void JEMJOLBMCNL(Entity GLFIOFJHMHG, ONJJKKKIGOC LIHHDPOHLDK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool JOJCHNFNPDL(Entity GLFIOFJHMHG, PNKJNCEHIKB FFAPBOEDPIG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void IDKFFNFJCAM(ABIHPOLLOBL DPCHBCFGEPO, [Optional] object JCPOMHNJOIE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool CAOLCICLPPL(Entity EDLJDADHMAM, Entity CAAJFPBAGHE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void JLABJFAHLGH(EntityManager POOMEDKNPIK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x301F360", Offset = "0x301E760", VA = "0x18301F360")]
	protected void EPNPIDMBJMM<T>(Entity GLFIOFJHMHG, [In] T HCDCAGFKELC, [In] T FFAPBOEDPIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string JLHCGHKALNH([In] PNKJNCEHIKB EMMPLEBMLIH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract HPAPLFGFAME FNBDODIKBHL(EntityManager BKLNKBBAABF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected PPCIBNMKKJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HPAPLFGFAME : PAFGOGNNLNG<Entity>, OBFHEFPJAGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPAPLFGFAME FNBDODIKBHL(EntityManager BKLNKBBAABF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PJMBKFJKHEG<T> : GHMELDLGACN<Entity, T>, PAFGOGNNLNG<Entity>, OBFHEFPJAGA, IDisposable, HPAPLFGFAME where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface EBOBMGFACGA : HPAPLFGFAME, PAFGOGNNLNG<Entity>, OBFHEFPJAGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int KIKHFCMICOM
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
public static class HCLPELABLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C4E0", Offset = "0x2E7B8E0", VA = "0x182E7C4E0")]
	public static T LNFGKOIKOPI<T>(this PJMBKFJKHEG<T> NHOIMDHCPOO, Entity GLFIOFJHMHG, [Optional] T JGBDACMOCCC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C430", Offset = "0x2E7B830", VA = "0x182E7C430")]
	public static T GMGOKDOKMEE<T>(this PAFGOGNNLNG<Entity> NHOIMDHCPOO, Entity GLFIOFJHMHG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C790", Offset = "0x2E7BB90", VA = "0x182E7C790")]
	public static bool MICHIDJGAIF<T>(this PAFGOGNNLNG<Entity> NHOIMDHCPOO, Entity GLFIOFJHMHG, [In] T FFAPBOEDPIG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C650", Offset = "0x2E7BA50", VA = "0x182E7C650")]
	public static bool MICHIDJGAIF<T>(this PAFGOGNNLNG<Entity> NHOIMDHCPOO, Entity GLFIOFJHMHG, NativeArray<T> FFAPBOEDPIG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void OPDDPNNHEAM<TKey>(TKey PBAACPJGKNP, [In] PNKJNCEHIKB HCDCAGFKELC, [In] PNKJNCEHIKB FFAPBOEDPIG);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LANMABDBKBD
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AFD0", Offset = "0x2F0A3D0", VA = "0x182F0AFD0")]
	public static void JNFLGGLMFJH<TKey, T>(this OPDDPNNHEAM<TKey> CNAPGMPCKKJ, TKey PBAACPJGKNP, T HCDCAGFKELC, T FFAPBOEDPIG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ABIHPOLLOBL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEOICNHECMJ<TKey, T>(GHMELDLGACN<TKey, T> NHOIMDHCPOO, [Optional] object JCPOMHNJOIE) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KLJOMGJCDNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DNJOFBEFNAN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo DHPIDFKJGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int BLOODECNJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NDEEOPEAONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OBFHEFPJAGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type MKIIDBFDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DNJOFBEFNAN GDAKIDHBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EDHPIEOENNM LLPBGDDLFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int KIKHFCMICOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDKFFNFJCAM(ABIHPOLLOBL DPCHBCFGEPO, [Optional] object JCPOMHNJOIE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PAFGOGNNLNG<TKey> : OBFHEFPJAGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OPDDPNNHEAM<TKey> BPFGLGMPDAM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJAKFOIGPDG(TKey GMJINMLEEAC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEMJOLBMCNL(TKey GMJINMLEEAC, ONJJKKKIGOC LIHHDPOHLDK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JOJCHNFNPDL(TKey GMJINMLEEAC, PNKJNCEHIKB FFAPBOEDPIG);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CAOLCICLPPL(TKey EDLJDADHMAM, TKey CAAJFPBAGHE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string JLHCGHKALNH([In] PNKJNCEHIKB LIHHDPOHLDK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface GHMELDLGACN<TKey, T> : PAFGOGNNLNG<TKey>, OBFHEFPJAGA, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T JEMJOLBMCNL(TKey GMJINMLEEAC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KBGFOEIGGBP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0AA0", Offset = "0x2EEFEA0", VA = "0x182EF0AA0")]
	public static bool CPMADEOKHEK<TKey, T>(this PAFGOGNNLNG<TKey> NHOIMDHCPOO, TKey GMJINMLEEAC, [Out] T LIHHDPOHLDK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0C70", Offset = "0x2EF0070", VA = "0x182EF0C70")]
	public static T JEMJOLBMCNL<T, TKey>(this PAFGOGNNLNG<TKey> NHOIMDHCPOO, TKey GMJINMLEEAC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1760", Offset = "0x2EF0B60", VA = "0x182EF1760")]
	public static bool JOJCHNFNPDL<TKey, T>(this PAFGOGNNLNG<TKey> NHOIMDHCPOO, TKey GMJINMLEEAC, T FFAPBOEDPIG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1890", Offset = "0x2EF0C90", VA = "0x182EF1890")]
	public static bool JOJCHNFNPDL<TKey, T>(this PAFGOGNNLNG<TKey> NHOIMDHCPOO, TKey GMJINMLEEAC, NativeArray<T> FFAPBOEDPIG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface MAHPFBNONDG : IEnumerable<HPAPLFGFAME>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EDHPIEOENNM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int PFFPOGMJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int PGNMJHIMAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type LLJJAHLCALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	HPAPLFGFAME[] OBCCBKPPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NKLIOFAMMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) IMEHAJLKPJL(Entity GLFIOFJHMHG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class FIOCKBNPKJK : MAHPFBNONDG, IEnumerable<HPAPLFGFAME>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<HPAPLFGFAME> GOCFBLFHDKH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF93F0", Offset = "0x6DF87F0", VA = "0x186DF93F0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HPAPLFGFAME CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF9430", Offset = "0x6DF8830", VA = "0x186DF9430", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9490", Offset = "0x6DF8890", VA = "0x186DF9490")]
	public FIOCKBNPKJK(IEnumerable<EDHPIEOENNM> MFPPJHJFPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8EE0", Offset = "0x6DF82E0", VA = "0x186DF8EE0")]
	private List<HPAPLFGFAME> CNNLDDECPGP(IEnumerable<EDHPIEOENNM> MFPPJHJFPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9370", Offset = "0x6DF8770", VA = "0x186DF9370", Slot = "4")]
	public IEnumerator<HPAPLFGFAME> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9370", Offset = "0x6DF8770", VA = "0x186DF9370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OILPIFOFBLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type HBJMFIJBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string ADANIHOIEKJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	public OILPIFOFBLO(Type HBJMFIJBALA, string ADANIHOIEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct POIIJBIAPFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type HBJMFIJBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string ADANIHOIEKJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	public POIIJBIAPFN(Type HBJMFIJBALA, string ADANIHOIEKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4B781C0", Offset = "0x4B775C0", VA = "0x184B781C0")]
	public static OILPIFOFBLO MMDLBPMGOIM(POIIJBIAPFN<T> LLKNDBOAAHA)
	{
		return default(OILPIFOFBLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LMGHJLGDLFE
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
public class EOOKEPBOIFH
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public EOOKEPBOIFH()
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
