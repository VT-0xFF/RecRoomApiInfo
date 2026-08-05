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
public sealed class NKGEIMCJHAB<TContainer, TField> : FEGEMPJNJOB<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6540", Offset = "0x3DD4F40", VA = "0x183DD6540")]
	public NKGEIMCJHAB(string KJPHMNNIMDP, DAAMMIBDAFG KOIICEKKKHA, FieldInfo ELFBFAKACGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47FD9D0", Offset = "0x47FC3D0", VA = "0x1847FD9D0", Slot = "26")]
	public override bool ENCKAHEIPGI(Entity AINKOAHKAPB, BMMILLGHHLI MMECFHEAHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x47FDB50", Offset = "0x47FC550", VA = "0x1847FDB50", Slot = "32")]
	public override BPKGEBJHOCE OBHKFADKODF(EntityManager LMEMCMADAGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class FBLOJOEBEFP<T> : FEGEMPJNJOB<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6540", Offset = "0x3DD4F40", VA = "0x183DD6540")]
	public FBLOJOEBEFP(string KJPHMNNIMDP, DAAMMIBDAFG KOIICEKKKHA, FieldInfo ELFBFAKACGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6450", Offset = "0x3DD4E50", VA = "0x183DD6450", Slot = "32")]
	public override BPKGEBJHOCE OBHKFADKODF(EntityManager LMEMCMADAGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class FEGEMPJNJOB<T> : IIAFAMCKDIB, KOEALPBAPND<T>, ECOELNHFNHC<Entity, T>, MDJAFNKLIGO<Entity>, DAJNFCEAGJI, IDisposable, BPKGEBJHOCE, DPFNNNOCKEK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool CKGONNEAHEJ(Entity AINKOAHKAPB, [In] T MMECFHEAHOI);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void EPPDEIGMBPF(Entity AINKOAHKAPB, [In] T EAKMFJLHKHA, [In] T MMECFHEAHOI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DAAMMIBDAFG KOIICEKKKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo ELFBFAKACGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int NMEBIIGAMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int IEHCONIHMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int BHEAFIOEIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CKGONNEAHEJ CCJIKCKGKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EPPDEIGMBPF APAFHDCMLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private EPPDEIGMBPF LNOIAKJHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World PKCDFEGEJDG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type EMAFAACIGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDE40", Offset = "0x3DDC840", VA = "0x183DDDE40", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override DAAMMIBDAFG FPHLOHPEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override DPFNNNOCKEK KLENCBKMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo IEJAGNNDJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int LMBMMBFKDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B58E0", Offset = "0x8B42E0", VA = "0x1808B58E0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int JGLCLKBPBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A7290", Offset = "0x8A5C90", VA = "0x1808A7290", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager HAIDOEFFHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4540", Offset = "0x3DE2F40", VA = "0x183DE4540")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6710", Offset = "0x3DE5110", VA = "0x183DE6710")]
	internal FEGEMPJNJOB(string KJPHMNNIMDP, DAAMMIBDAFG KOIICEKKKHA, FieldInfo ELFBFAKACGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE200", Offset = "0x3DDCC00", VA = "0x183DDE200", Slot = "30")]
	public override void AIFHKOLJDOL(EntityManager MAJIKHEKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4560", Offset = "0x3DE2F60", VA = "0x183DE4560")]
	public FEGEMPJNJOB<T> JHLFOMPHHEC(CKGONNEAHEJ CCJIKCKGKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4F30", Offset = "0x3DE3930", VA = "0x183DE4F30")]
	public FEGEMPJNJOB<T> OHNIGNEDFCG(EPPDEIGMBPF APAFHDCMLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4580", Offset = "0x3DE2F80", VA = "0x183DE4580")]
	public FEGEMPJNJOB<T> JNICCFILNNB(EPPDEIGMBPF LNOIAKJHIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4FD0", Offset = "0x3DE39D0", VA = "0x183DE4FD0", Slot = "33")]
	public T PBGHNKGJFJB(Entity AINKOAHKAPB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3DE2C80", Offset = "0x3DE1680", VA = "0x183DE2C80")]
	public bool ENCKAHEIPGI(Entity AINKOAHKAPB, [In] T MMECFHEAHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD790", Offset = "0x3DDC190", VA = "0x183DDD790")]
	public bool AAOCDBLGLJF(Entity AINKOAHKAPB, [In] T MMECFHEAHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEF00", Offset = "0x3DDD900", VA = "0x183DDEF00", Slot = "24")]
	public override bool AOOFMIHDJBB(Entity AINKOAHKAPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5FB0", Offset = "0x3DE49B0", VA = "0x183DE5FB0", Slot = "25")]
	public override void PBGHNKGJFJB(Entity AINKOAHKAPB, FGNBBGCPHEE KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE44A0", Offset = "0x3DE2EA0", VA = "0x183DE44A0", Slot = "26")]
	public override bool ENCKAHEIPGI(Entity AINKOAHKAPB, BMMILLGHHLI MMECFHEAHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4E90", Offset = "0x3DE3890", VA = "0x183DE4E90", Slot = "27")]
	public override void MGNBALLHPAF(IKKFHLHFHID MHEGKEFIIIO, [Optional] object EIGKPCONJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF650", Offset = "0x3DDE050", VA = "0x183DDF650", Slot = "28")]
	public override bool DODCOAEGADP(Entity JPCKHGMDGNF, Entity MILPHOELICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4880", Offset = "0x3DE3280", VA = "0x183DE4880", Slot = "31")]
	public override string MDLPOLGBHOH([In] BMMILLGHHLI MLEKMMNPGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4EC0", Offset = "0x3DE38C0", VA = "0x183DE4EC0")]
	private bool OAGHAJOHACJ(T EAKMFJLHKHA, T MMECFHEAHOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class IIAFAMCKDIB : PHNIBBDBAEI, BPKGEBJHOCE, MDJAFNKLIGO<Entity>, DAJNFCEAGJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type EMAFAACIGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract DAAMMIBDAFG FPHLOHPEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract DPFNNNOCKEK KLENCBKMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BDALMFNNLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D22F0", Offset = "0x9D0CF0", VA = "0x1809D22F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event HKAJOCFFLGL<Entity> FFNBJFJONLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CD50", Offset = "0x6C5B750", VA = "0x186C5CD50", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CE00", Offset = "0x6C5B800", VA = "0x186C5CE00", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool AOOFMIHDJBB(Entity AINKOAHKAPB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void PBGHNKGJFJB(Entity AINKOAHKAPB, FGNBBGCPHEE KLABJGGMBGH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool ENCKAHEIPGI(Entity AINKOAHKAPB, BMMILLGHHLI MMECFHEAHOI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void MGNBALLHPAF(IKKFHLHFHID MHEGKEFIIIO, [Optional] object EIGKPCONJCB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool DODCOAEGADP(Entity JPCKHGMDGNF, Entity MILPHOELICC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void AIFHKOLJDOL(EntityManager MAJIKHEKDED);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E06FC0", Offset = "0x2E059C0", VA = "0x182E06FC0")]
	protected void PKIHLBIMNDM<T>(Entity AINKOAHKAPB, [In] T EAKMFJLHKHA, [In] T MMECFHEAHOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string MDLPOLGBHOH([In] BMMILLGHHLI MLEKMMNPGCD);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract BPKGEBJHOCE OBHKFADKODF(EntityManager LMEMCMADAGH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	protected IIAFAMCKDIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BPKGEBJHOCE : MDJAFNKLIGO<Entity>, DAJNFCEAGJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BPKGEBJHOCE OBHKFADKODF(EntityManager LMEMCMADAGH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KOEALPBAPND<T> : ECOELNHFNHC<Entity, T>, MDJAFNKLIGO<Entity>, DAJNFCEAGJI, IDisposable, BPKGEBJHOCE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface PHNIBBDBAEI : BPKGEBJHOCE, MDJAFNKLIGO<Entity>, DAJNFCEAGJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int BDALMFNNLOF
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
public static class MBIGGEFMOGC
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C1D0", Offset = "0x2E6ABD0", VA = "0x182E6C1D0")]
	public static T OIDAGPMOLPM<T>(this KOEALPBAPND<T> PKFJNPAMFMB, Entity AINKOAHKAPB, [Optional] T MCAGMGIJFIA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C0D0", Offset = "0x2E6AAD0", VA = "0x182E6C0D0")]
	public static T JHMOEGIAFJJ<T>(this MDJAFNKLIGO<Entity> PKFJNPAMFMB, Entity AINKOAHKAPB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C440", Offset = "0x2E6AE40", VA = "0x182E6C440")]
	public static bool OMPLFGPAEBL<T>(this MDJAFNKLIGO<Entity> PKFJNPAMFMB, Entity AINKOAHKAPB, [In] T MMECFHEAHOI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C350", Offset = "0x2E6AD50", VA = "0x182E6C350")]
	public static bool OMPLFGPAEBL<T>(this MDJAFNKLIGO<Entity> PKFJNPAMFMB, Entity AINKOAHKAPB, NativeArray<T> MMECFHEAHOI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void HKAJOCFFLGL<TKey>(TKey GHMNBJIOGAM, [In] BMMILLGHHLI EAKMFJLHKHA, [In] BMMILLGHHLI MMECFHEAHOI);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GKCBNFKIDEH
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9820", Offset = "0x2DA8220", VA = "0x182DA9820")]
	public static void FJEDBGMGJGG<TKey, T>(this HKAJOCFFLGL<TKey> DIBMBMDNNMF, TKey GHMNBJIOGAM, T EAKMFJLHKHA, T MMECFHEAHOI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IKKFHLHFHID
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKCAIBOMCD<TKey, T>(ECOELNHFNHC<TKey, T> PKFJNPAMFMB, [Optional] object EIGKPCONJCB) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DGHAMDDDDAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DPFNNNOCKEK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo AJHEHEFMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int FINIPIMGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int KHAEIGABOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DAJNFCEAGJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type EMAFAACIGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DPFNNNOCKEK KLENCBKMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DAAMMIBDAFG FPHLOHPEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int BDALMFNNLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGNBALLHPAF(IKKFHLHFHID MHEGKEFIIIO, [Optional] object EIGKPCONJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MDJAFNKLIGO<TKey> : DAJNFCEAGJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HKAJOCFFLGL<TKey> FFNBJFJONLG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOOFMIHDJBB(TKey LFOBGDLOPID);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBGHNKGJFJB(TKey LFOBGDLOPID, FGNBBGCPHEE KLABJGGMBGH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ENCKAHEIPGI(TKey LFOBGDLOPID, BMMILLGHHLI MMECFHEAHOI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DODCOAEGADP(TKey JPCKHGMDGNF, TKey MILPHOELICC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string MDLPOLGBHOH([In] BMMILLGHHLI KLABJGGMBGH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface ECOELNHFNHC<TKey, T> : MDJAFNKLIGO<TKey>, DAJNFCEAGJI, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T PBGHNKGJFJB(TKey LFOBGDLOPID);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IEBFJEHJECF
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E05390", Offset = "0x2E03D90", VA = "0x182E05390")]
	public static bool JLNEIPDMCNA<TKey, T>(this MDJAFNKLIGO<TKey> PKFJNPAMFMB, TKey LFOBGDLOPID, [Out] T KLABJGGMBGH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2E05A30", Offset = "0x2E04430", VA = "0x182E05A30")]
	public static T PBGHNKGJFJB<T, TKey>(this MDJAFNKLIGO<TKey> PKFJNPAMFMB, TKey LFOBGDLOPID) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E04B30", Offset = "0x2E03530", VA = "0x182E04B30")]
	public static bool ENCKAHEIPGI<TKey, T>(this MDJAFNKLIGO<TKey> PKFJNPAMFMB, TKey LFOBGDLOPID, T MMECFHEAHOI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E04D90", Offset = "0x2E03790", VA = "0x182E04D90")]
	public static bool ENCKAHEIPGI<TKey, T>(this MDJAFNKLIGO<TKey> PKFJNPAMFMB, TKey LFOBGDLOPID, NativeArray<T> MMECFHEAHOI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface EAAILIELHCH : IEnumerable<BPKGEBJHOCE>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DAAMMIBDAFG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int AKDGDIKBBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int APBECBENDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type DGMGMOBNCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BPKGEBJHOCE[] CGJHCNEMNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NJOLPFGMAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) LOJJEOLKEKL(Entity AINKOAHKAPB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class FEPNBIACBHJ : EAAILIELHCH, IEnumerable<BPKGEBJHOCE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<BPKGEBJHOCE> CMBOAPAKLEN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C760", Offset = "0x6C5B160", VA = "0x186C5C760", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BPKGEBJHOCE BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C7A0", Offset = "0x6C5B1A0", VA = "0x186C5C7A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CD10", Offset = "0x6C5B710", VA = "0x186C5CD10")]
	public FEPNBIACBHJ(IEnumerable<DAAMMIBDAFG> ODOMAJPBDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C800", Offset = "0x6C5B200", VA = "0x186C5C800")]
	private List<BPKGEBJHOCE> DGFCKAPGOPM(IEnumerable<DAAMMIBDAFG> ODOMAJPBDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CC90", Offset = "0x6C5B690", VA = "0x186C5CC90", Slot = "4")]
	public IEnumerator<BPKGEBJHOCE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CC90", Offset = "0x6C5B690", VA = "0x186C5CC90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NOEIJGFIOAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type BGOFNHIPLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string KJPHMNNIMDP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
	public NOEIJGFIOAL(Type BGOFNHIPLDI, string KJPHMNNIMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HIJDJKKNJNE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type BGOFNHIPLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string KJPHMNNIMDP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
	public HIJDJKKNJNE(Type BGOFNHIPLDI, string KJPHMNNIMDP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3F41710", Offset = "0x3F40110", VA = "0x183F41710")]
	public static NOEIJGFIOAL AECPEGEGHIB(HIJDJKKNJNE<T> OLLAHGLHFDA)
	{
		return default(NOEIJGFIOAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GKOGDKLBGMK
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
public class GCJAEBBBAOC
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public GCJAEBBBAOC()
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
