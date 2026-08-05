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
public sealed class EDMJNHEFLFH<TContainer, TField> : ILNGAGOOPPK<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3742610", Offset = "0x3740E10", VA = "0x183742610")]
	public EDMJNHEFLFH(string GCDLMFGKKMH, JJBHOBIPHNH ECKNMNLLOJH, FieldInfo DBDJILAIPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3742490", Offset = "0x3740C90", VA = "0x183742490", Slot = "25")]
	public override bool KAMKODPJIMO(Entity JIPIEBFBEML, OFJFMHKNJIC MKIPENAKAOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class CJCGKLMPPOG<T> : ILNGAGOOPPK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3742610", Offset = "0x3740E10", VA = "0x183742610")]
	public CJCGKLMPPOG(string GCDLMFGKKMH, JJBHOBIPHNH ECKNMNLLOJH, FieldInfo DBDJILAIPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class ILNGAGOOPPK<T> : CFAGFBNFPCA, BFMCLLPJIOJ<T>, OMOGHJEGGBA<Entity, T>, MAEJGIEPEED<Entity>, GEGNBKMOPOM, IDisposable, FMPDKKGEHKK, GADOHDJLAPN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool HKPCNPHKCOG(Entity JIPIEBFBEML, [In] T MKIPENAKAOC);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void ANCNMHLEOCP(Entity JIPIEBFBEML, [In] T EMHAKLBNJDA, [In] T MKIPENAKAOC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JJBHOBIPHNH ECKNMNLLOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo DBDJILAIPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int COMFAOIGFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int MFLLOPOPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int GGKCGCGFHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HKPCNPHKCOG GIMAHOEJDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private ANCNMHLEOCP GHJEKHBEOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private ANCNMHLEOCP OJHDEMNBOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World NGKMHGNGADJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type LBCGEBEPPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D390", Offset = "0x3D9BB90", VA = "0x183D9D390", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override JJBHOBIPHNH EMMHENJCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override GADOHDJLAPN GIICNBOENBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo LHGAIBBMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int DAOOJFKBIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x860B00", Offset = "0x85F300", VA = "0x180860B00", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int FIFLMOJIDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x852490", Offset = "0x850C90", VA = "0x180852490", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager LPIEJIAIKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D95E30", Offset = "0x3D94630", VA = "0x183D95E30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E2B0", Offset = "0x3D9CAB0", VA = "0x183D9E2B0")]
	internal ILNGAGOOPPK(string GCDLMFGKKMH, JJBHOBIPHNH ECKNMNLLOJH, FieldInfo DBDJILAIPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D962D0", Offset = "0x3D94AD0", VA = "0x183D962D0", Slot = "29")]
	public override void DIHNAABPOCM(EntityManager FHNEBBCLKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D9B9C0", Offset = "0x3D9A1C0", VA = "0x183D9B9C0")]
	public ILNGAGOOPPK<T> MICLABCPLBE(HKPCNPHKCOG GIMAHOEJDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D95370", Offset = "0x3D93B70", VA = "0x183D95370")]
	public ILNGAGOOPPK<T> BHGFAKKBAFB(ANCNMHLEOCP GHJEKHBEOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D9B9E0", Offset = "0x3D9A1E0", VA = "0x183D9B9E0")]
	public ILNGAGOOPPK<T> MICPCBPDNDO(ANCNMHLEOCP OJHDEMNBOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CFE0", Offset = "0x3D9B7E0", VA = "0x183D9CFE0", Slot = "31")]
	public T NBGKOOJKKKA(Entity JIPIEBFBEML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3D978B0", Offset = "0x3D960B0", VA = "0x183D978B0")]
	public bool KAMKODPJIMO(Entity JIPIEBFBEML, [In] T MKIPENAKAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D95390", Offset = "0x3D93B90", VA = "0x183D95390")]
	public bool CLPDEGNDGEA(Entity JIPIEBFBEML, [In] T MKIPENAKAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D96AE0", Offset = "0x3D952E0", VA = "0x183D96AE0", Slot = "23")]
	public override bool HMKIEFDGCCL(Entity JIPIEBFBEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D9BED0", Offset = "0x3D9A6D0", VA = "0x183D9BED0", Slot = "24")]
	public override void NBGKOOJKKKA(Entity JIPIEBFBEML, IBKJLLBNKOA IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D98620", Offset = "0x3D96E20", VA = "0x183D98620", Slot = "25")]
	public override bool KAMKODPJIMO(Entity JIPIEBFBEML, OFJFMHKNJIC MKIPENAKAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D9BA00", Offset = "0x3D9A200", VA = "0x183D9BA00", Slot = "26")]
	public override void MLIKMNFCHGN(PMPFHMCEFIM EJFKBBEMLCC, [Optional] object BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D954F0", Offset = "0x3D93CF0", VA = "0x183D954F0", Slot = "27")]
	public override bool DBMPDAIGBHO(Entity OKKHHHCDIHJ, Entity AMBKIFNGGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D9DA60", Offset = "0x3D9C260", VA = "0x183D9DA60", Slot = "30")]
	public override string NIBJCJPGBCO([In] OFJFMHKNJIC IDIAEDMFJBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D97060", Offset = "0x3D95860", VA = "0x183D97060")]
	private bool IHJMDBLAKJJ(T EMHAKLBNJDA, T MKIPENAKAOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class CFAGFBNFPCA : IPHLGHBEOGO, FMPDKKGEHKK, MAEJGIEPEED<Entity>, GEGNBKMOPOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type LBCGEBEPPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract JJBHOBIPHNH EMMHENJCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract GADOHDJLAPN GIICNBOENBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x844F20", Offset = "0x843720", VA = "0x180844F20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CPOPOGBCKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E10", Offset = "0x8B7610", VA = "0x1808B8E10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KNBPNCBHAAM<Entity> PFNAOHNDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x685D930", Offset = "0x685C130", VA = "0x18685D930", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x685D880", Offset = "0x685C080", VA = "0x18685D880", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool HMKIEFDGCCL(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void NBGKOOJKKKA(Entity JIPIEBFBEML, IBKJLLBNKOA IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool KAMKODPJIMO(Entity JIPIEBFBEML, OFJFMHKNJIC MKIPENAKAOC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void MLIKMNFCHGN(PMPFHMCEFIM EJFKBBEMLCC, [Optional] object BHFMOMNKABO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool DBMPDAIGBHO(Entity OKKHHHCDIHJ, Entity AMBKIFNGGDN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void DIHNAABPOCM(EntityManager FHNEBBCLKID);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28A7C60", Offset = "0x28A6460", VA = "0x1828A7C60")]
	protected void CJICMALOMII<T>(Entity JIPIEBFBEML, [In] T EMHAKLBNJDA, [In] T MKIPENAKAOC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string NIBJCJPGBCO([In] OFJFMHKNJIC IDIAEDMFJBO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected CFAGFBNFPCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FMPDKKGEHKK : MAEJGIEPEED<Entity>, GEGNBKMOPOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFMCLLPJIOJ<T> : OMOGHJEGGBA<Entity, T>, MAEJGIEPEED<Entity>, GEGNBKMOPOM, IDisposable, FMPDKKGEHKK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface IPHLGHBEOGO : FMPDKKGEHKK, MAEJGIEPEED<Entity>, GEGNBKMOPOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int CPOPOGBCKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BENPPNHBBCK
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2834450", Offset = "0x2832C50", VA = "0x182834450")]
	public static T BKDBGJLDJNN<T>(this BFMCLLPJIOJ<T> ABBFPCPEMEH, Entity JIPIEBFBEML, [Optional] T HLCNDDGKJJF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2834890", Offset = "0x2833090", VA = "0x182834890")]
	public static T LOHAKJGKIFE<T>(this MAEJGIEPEED<Entity> ABBFPCPEMEH, Entity JIPIEBFBEML) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28346C0", Offset = "0x2832EC0", VA = "0x1828346C0")]
	public static bool KBAHBKICJCG<T>(this MAEJGIEPEED<Entity> ABBFPCPEMEH, Entity JIPIEBFBEML, [In] T MKIPENAKAOC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2834600", Offset = "0x2832E00", VA = "0x182834600")]
	public static bool KBAHBKICJCG<T>(this MAEJGIEPEED<Entity> ABBFPCPEMEH, Entity JIPIEBFBEML, NativeArray<T> MKIPENAKAOC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void KNBPNCBHAAM<TKey>(TKey GHDJADLHPAA, [In] OFJFMHKNJIC EMHAKLBNJDA, [In] OFJFMHKNJIC MKIPENAKAOC);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HEMJOCPPNGI
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9C10", Offset = "0x2AA8410", VA = "0x182AA9C10")]
	public static void EHHNDHAPNMD<TKey, T>(this KNBPNCBHAAM<TKey> ELLNEPPNPEA, TKey GHDJADLHPAA, T EMHAKLBNJDA, T MKIPENAKAOC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PMPFHMCEFIM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCMDMEDGMOL<TKey, T>(OMOGHJEGGBA<TKey, T> ABBFPCPEMEH, [Optional] object BHFMOMNKABO) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OFFPPMKBGHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GADOHDJLAPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo HHKPNLHNABN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int FHAALGCKALP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int JAFNMFMLFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GEGNBKMOPOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type LBCGEBEPPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GADOHDJLAPN GIICNBOENBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JJBHOBIPHNH EMMHENJCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int CPOPOGBCKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLIKMNFCHGN(PMPFHMCEFIM EJFKBBEMLCC, [Optional] object BHFMOMNKABO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MAEJGIEPEED<TKey> : GEGNBKMOPOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KNBPNCBHAAM<TKey> PFNAOHNDCBN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMKIEFDGCCL(TKey JOEHGGMHBAA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBGKOOJKKKA(TKey JOEHGGMHBAA, IBKJLLBNKOA IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KAMKODPJIMO(TKey JOEHGGMHBAA, OFJFMHKNJIC MKIPENAKAOC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DBMPDAIGBHO(TKey OKKHHHCDIHJ, TKey AMBKIFNGGDN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string NIBJCJPGBCO([In] OFJFMHKNJIC IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface OMOGHJEGGBA<TKey, T> : MAEJGIEPEED<TKey>, GEGNBKMOPOM, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T NBGKOOJKKKA(TKey JOEHGGMHBAA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HCHABMMLJBL
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7DC0", Offset = "0x2AA65C0", VA = "0x182AA7DC0")]
	public static bool GIPAEIFMNNK<TKey, T>(this MAEJGIEPEED<TKey> ABBFPCPEMEH, TKey JOEHGGMHBAA, [Out] T IPHHABIKCHD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8B90", Offset = "0x2AA7390", VA = "0x182AA8B90")]
	public static T NBGKOOJKKKA<T, TKey>(this MAEJGIEPEED<TKey> ABBFPCPEMEH, TKey JOEHGGMHBAA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8330", Offset = "0x2AA6B30", VA = "0x182AA8330")]
	public static bool KAMKODPJIMO<TKey, T>(this MAEJGIEPEED<TKey> ABBFPCPEMEH, TKey JOEHGGMHBAA, T MKIPENAKAOC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2AA80C0", Offset = "0x2AA68C0", VA = "0x182AA80C0")]
	public static bool KAMKODPJIMO<TKey, T>(this MAEJGIEPEED<TKey> ABBFPCPEMEH, TKey JOEHGGMHBAA, NativeArray<T> MKIPENAKAOC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface EIMEPIFECDN : IEnumerable<FMPDKKGEHKK>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JJBHOBIPHNH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int EICABJPMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int NFGLGPGFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type ENNJCJNDHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	FMPDKKGEHKK[] LGLPLPLDILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LGKCCHEEIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) HCJNIMGFCCC(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BEBBLNHCPEP(Entity JIPIEBFBEML, (uint order, uint change) MBDJOBPGDCG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class ENJLCEDKAHM : EIMEPIFECDN, IEnumerable<FMPDKKGEHKK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<FMPDKKGEHKK> DJIOPEBEJAM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x685DF50", Offset = "0x685C750", VA = "0x18685DF50", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FMPDKKGEHKK EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x685D9E0", Offset = "0x685C1E0", VA = "0x18685D9E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x685DF90", Offset = "0x685C790", VA = "0x18685DF90")]
	public ENJLCEDKAHM(IEnumerable<JJBHOBIPHNH> LNDJFMBLLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x685DA40", Offset = "0x685C240", VA = "0x18685DA40")]
	private List<FMPDKKGEHKK> EDAMCDJOOJP(IEnumerable<JJBHOBIPHNH> LNDJFMBLLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x685DED0", Offset = "0x685C6D0", VA = "0x18685DED0", Slot = "4")]
	public IEnumerator<FMPDKKGEHKK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x685DED0", Offset = "0x685C6D0", VA = "0x18685DED0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FPHCOHCKING
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type BGPGCCHNMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string GCDLMFGKKMH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	public FPHCOHCKING(Type BGPGCCHNMBD, string GCDLMFGKKMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct PIJKAEAANBM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type BGPGCCHNMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string GCDLMFGKKMH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	public PIJKAEAANBM(Type BGPGCCHNMBD, string GCDLMFGKKMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x465A040", Offset = "0x4658840", VA = "0x18465A040")]
	public static FPHCOHCKING OOONFFIJKGD(PIJKAEAANBM<T> NCGPGHKFLCK)
	{
		return default(FPHCOHCKING);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HKEMAJPDCDD
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
public class CBIBAIGKJBN
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CBIBAIGKJBN()
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
