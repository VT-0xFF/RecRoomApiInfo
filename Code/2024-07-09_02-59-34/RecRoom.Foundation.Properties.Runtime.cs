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
public sealed class OHIIIMOEGII<TContainer, TField> : EELDGDBGKMO<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C28760", Offset = "0x3C27360", VA = "0x183C28760")]
	public OHIIIMOEGII(string LONKACOOPGJ, GEDPJLBCGCD DJNHJDCMHHE, FieldInfo EINOOFGHBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4697F00", Offset = "0x4696B00", VA = "0x184697F00", Slot = "25")]
	public override bool IJGOPKKNHAN(Entity AOPPIDPOGKL, ACJOMMOAIML NHPLJONGPGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class FLCBMMMJFDD<T> : EELDGDBGKMO<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C28760", Offset = "0x3C27360", VA = "0x183C28760")]
	public FLCBMMMJFDD(string LONKACOOPGJ, GEDPJLBCGCD DJNHJDCMHHE, FieldInfo EINOOFGHBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class EELDGDBGKMO<T> : CIIICDGMOML, FGOHKKFPMAN<T>, PLEKKPJOJJK<Entity, T>, ILEBMCPHAGK<Entity>, FFJOECNIMAA, IDisposable, GPEOFHLMMPO, BEIFNADNAPP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool KDGCLJIJDBB(Entity AOPPIDPOGKL, [In] T NHPLJONGPGD);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void AFFMADCDMGB(Entity AOPPIDPOGKL, [In] T EDNCIGBPAKF, [In] T NHPLJONGPGD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly GEDPJLBCGCD DJNHJDCMHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo EINOOFGHBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int MEKCIDKBALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int JEHLDDEOFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int INGCLKPLIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KDGCLJIJDBB GFBIPCEKHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private AFFMADCDMGB PDPKIFFBJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private AFFMADCDMGB KFPHADHNGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World PJPKFFPGDHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type DOJGHAOJFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3831560", Offset = "0x3830160", VA = "0x183831560", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override GEDPJLBCGCD KEOLPHPPBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override BEIFNADNAPP DLGDOICDMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo DDLMDLDAJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int DLPNFDFMOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x883F50", Offset = "0x882B50", VA = "0x180883F50", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int AOKJKKOHNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x875460", Offset = "0x874060", VA = "0x180875460", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager PMCJCDLGBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38370F0", Offset = "0x3835CF0", VA = "0x1838370F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3839C90", Offset = "0x3838890", VA = "0x183839C90")]
	internal EELDGDBGKMO(string LONKACOOPGJ, GEDPJLBCGCD DJNHJDCMHHE, FieldInfo EINOOFGHBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3836EB0", Offset = "0x3835AB0", VA = "0x183836EB0", Slot = "29")]
	public override void NJFEGHENHFC(EntityManager LHOMFPBLGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3836A20", Offset = "0x3835620", VA = "0x183836A20")]
	public EELDGDBGKMO<T> JBMLPMDEIHK(KDGCLJIJDBB GFBIPCEKHBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x38303F0", Offset = "0x382EFF0", VA = "0x1838303F0")]
	public EELDGDBGKMO<T> ANCNOBCAKHG(AFFMADCDMGB PDPKIFFBJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3836A40", Offset = "0x3835640", VA = "0x183836A40")]
	public EELDGDBGKMO<T> JNLKPFLGICM(AFFMADCDMGB KFPHADHNGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3837E70", Offset = "0x3836A70", VA = "0x183837E70", Slot = "31")]
	public T OIPGNBHOLEB(Entity AOPPIDPOGKL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3834CB0", Offset = "0x38338B0", VA = "0x183834CB0")]
	public bool IJGOPKKNHAN(Entity AOPPIDPOGKL, [In] T NHPLJONGPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3830410", Offset = "0x382F010", VA = "0x183830410")]
	public bool BAPEGIGOIJJ(Entity AOPPIDPOGKL, [In] T NHPLJONGPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3830510", Offset = "0x382F110", VA = "0x183830510", Slot = "23")]
	public override bool BCICDOOEJDJ(Entity AOPPIDPOGKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3838210", Offset = "0x3836E10", VA = "0x183838210", Slot = "24")]
	public override void OIPGNBHOLEB(Entity AOPPIDPOGKL, IHOAIJPBPNP IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3834C10", Offset = "0x3833810", VA = "0x183834C10", Slot = "25")]
	public override bool IJGOPKKNHAN(Entity AOPPIDPOGKL, ACJOMMOAIML NHPLJONGPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3836A60", Offset = "0x3835660", VA = "0x183836A60", Slot = "26")]
	public override void KBPNCLLPMHJ(EFGIGOBAGDH MEKAEIDGHMF, [Optional] object NGDLPEOFMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3831C90", Offset = "0x3830890", VA = "0x183831C90", Slot = "27")]
	public override bool FEPLHPFJIDG(Entity EGMKHAEDBDP, Entity IOFJKAICIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3838C70", Offset = "0x3837870", VA = "0x183838C70", Slot = "30")]
	public override string ONIFFEIBJJK([In] ACJOMMOAIML HMPGDFBENIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3831010", Offset = "0x382FC10", VA = "0x183831010")]
	private bool BLCHPEHHACB(T EDNCIGBPAKF, T NHPLJONGPGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class CIIICDGMOML : MNOJGLDEBFA, GPEOFHLMMPO, ILEBMCPHAGK<Entity>, FFJOECNIMAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type DOJGHAOJFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract GEDPJLBCGCD KEOLPHPPBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract BEIFNADNAPP DLGDOICDMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ACGOLPEJCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E1990", Offset = "0x8E0590", VA = "0x1808E1990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JAMOPHBIGCA<Entity> NDMMFAFKANC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69D93E0", Offset = "0x69D7FE0", VA = "0x1869D93E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69D9330", Offset = "0x69D7F30", VA = "0x1869D9330", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool BCICDOOEJDJ(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void OIPGNBHOLEB(Entity AOPPIDPOGKL, IHOAIJPBPNP IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool IJGOPKKNHAN(Entity AOPPIDPOGKL, ACJOMMOAIML NHPLJONGPGD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void KBPNCLLPMHJ(EFGIGOBAGDH MEKAEIDGHMF, [Optional] object NGDLPEOFMHL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool FEPLHPFJIDG(Entity EGMKHAEDBDP, Entity IOFJKAICIIH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void NJFEGHENHFC(EntityManager LHOMFPBLGHH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2955E70", Offset = "0x2954A70", VA = "0x182955E70")]
	protected void BOHHBCPFLFC<T>(Entity AOPPIDPOGKL, [In] T EDNCIGBPAKF, [In] T NHPLJONGPGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string ONIFFEIBJJK([In] ACJOMMOAIML HMPGDFBENIJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected CIIICDGMOML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GPEOFHLMMPO : ILEBMCPHAGK<Entity>, FFJOECNIMAA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FGOHKKFPMAN<T> : PLEKKPJOJJK<Entity, T>, ILEBMCPHAGK<Entity>, FFJOECNIMAA, IDisposable, GPEOFHLMMPO where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface MNOJGLDEBFA : GPEOFHLMMPO, ILEBMCPHAGK<Entity>, FFJOECNIMAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int ACGOLPEJCCJ
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
public static class CAKJKLIFKOL
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x294EEC0", Offset = "0x294DAC0", VA = "0x18294EEC0")]
	public static T LGEPNHOLBAK<T>(this FGOHKKFPMAN<T> LPPIGHILDBI, Entity AOPPIDPOGKL, [Optional] T APDNGABBFBA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x294F060", Offset = "0x294DC60", VA = "0x18294F060")]
	public static T MCDECIHBNJE<T>(this ILEBMCPHAGK<Entity> LPPIGHILDBI, Entity AOPPIDPOGKL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x294ED30", Offset = "0x294D930", VA = "0x18294ED30")]
	public static bool FIINAHLFLGM<T>(this ILEBMCPHAGK<Entity> LPPIGHILDBI, Entity AOPPIDPOGKL, [In] T NHPLJONGPGD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x294EC60", Offset = "0x294D860", VA = "0x18294EC60")]
	public static bool FIINAHLFLGM<T>(this ILEBMCPHAGK<Entity> LPPIGHILDBI, Entity AOPPIDPOGKL, NativeArray<T> NHPLJONGPGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void JAMOPHBIGCA<TKey>(TKey APKAFMDACKK, [In] ACJOMMOAIML EDNCIGBPAKF, [In] ACJOMMOAIML NHPLJONGPGD);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NDLAPPLPJOC
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5770", Offset = "0x2CA4370", VA = "0x182CA5770")]
	public static void HEONFGBJNMF<TKey, T>(this JAMOPHBIGCA<TKey> CEELIFFGBFO, TKey APKAFMDACKK, T EDNCIGBPAKF, T NHPLJONGPGD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EFGIGOBAGDH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGBCDJIBEDG<TKey, T>(PLEKKPJOJJK<TKey, T> LPPIGHILDBI, [Optional] object NGDLPEOFMHL) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EBBCGPAJGGN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BEIFNADNAPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo PGLLKOGEPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int IKFOCKOFOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int FODIPBCKAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FFJOECNIMAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type DOJGHAOJFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BEIFNADNAPP DLGDOICDMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GEDPJLBCGCD KEOLPHPPBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int ACGOLPEJCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KBPNCLLPMHJ(EFGIGOBAGDH MEKAEIDGHMF, [Optional] object NGDLPEOFMHL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ILEBMCPHAGK<TKey> : FFJOECNIMAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JAMOPHBIGCA<TKey> NDMMFAFKANC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCICDOOEJDJ(TKey NCMHANGAILD);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIPGNBHOLEB(TKey NCMHANGAILD, IHOAIJPBPNP IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJGOPKKNHAN(TKey NCMHANGAILD, ACJOMMOAIML NHPLJONGPGD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FEPLHPFJIDG(TKey EGMKHAEDBDP, TKey IOFJKAICIIH);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string ONIFFEIBJJK([In] ACJOMMOAIML IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface PLEKKPJOJJK<TKey, T> : ILEBMCPHAGK<TKey>, FFJOECNIMAA, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T OIPGNBHOLEB(TKey NCMHANGAILD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OPCMKOEAFCE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA960", Offset = "0x2CD9560", VA = "0x182CDA960")]
	public static bool LPJAHGPAPEL<TKey, T>(this ILEBMCPHAGK<TKey> LPPIGHILDBI, TKey NCMHANGAILD, [Out] T IIPLJLPCLBC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAEB0", Offset = "0x2CD9AB0", VA = "0x182CDAEB0")]
	public static T OIPGNBHOLEB<T, TKey>(this ILEBMCPHAGK<TKey> LPPIGHILDBI, TKey NCMHANGAILD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA5D0", Offset = "0x2CD91D0", VA = "0x182CDA5D0")]
	public static bool IJGOPKKNHAN<TKey, T>(this ILEBMCPHAGK<TKey> LPPIGHILDBI, TKey NCMHANGAILD, T NHPLJONGPGD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA240", Offset = "0x2CD8E40", VA = "0x182CDA240")]
	public static bool IJGOPKKNHAN<TKey, T>(this ILEBMCPHAGK<TKey> LPPIGHILDBI, TKey NCMHANGAILD, NativeArray<T> NHPLJONGPGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface LPLFNJBCIKD : IEnumerable<GPEOFHLMMPO>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GEDPJLBCGCD
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int GMGAJDDHOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int NLAJKCPCCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type OLGNCKKJPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GPEOFHLMMPO[] DHKCMBPDLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DDFOICBLAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) FDNJONABIDB(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BGMMEEIBICM(Entity AOPPIDPOGKL, (uint order, uint change) FAEMFOKJHDK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class GJDHCAKAAJG : LPLFNJBCIKD, IEnumerable<GPEOFHLMMPO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<GPEOFHLMMPO> EPMGLCMBMDO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69D9490", Offset = "0x69D8090", VA = "0x1869D9490", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GPEOFHLMMPO PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69D99E0", Offset = "0x69D85E0", VA = "0x1869D99E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69D9A40", Offset = "0x69D8640", VA = "0x1869D9A40")]
	public GJDHCAKAAJG(IEnumerable<GEDPJLBCGCD> JFLELEKCKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69D94D0", Offset = "0x69D80D0", VA = "0x1869D94D0")]
	private List<GPEOFHLMMPO> GFPPKCPANDJ(IEnumerable<GEDPJLBCGCD> JFLELEKCKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69D9960", Offset = "0x69D8560", VA = "0x1869D9960", Slot = "4")]
	public IEnumerator<GPEOFHLMMPO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69D9960", Offset = "0x69D8560", VA = "0x1869D9960", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PBLMAPFOOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type HBMOAAOMKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string LONKACOOPGJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	public PBLMAPFOOLN(Type HBMOAAOMKAE, string LONKACOOPGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct AKCMCEICDOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type HBMOAAOMKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string LONKACOOPGJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	public AKCMCEICDOK(Type HBMOAAOMKAE, string LONKACOOPGJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3D33FA0", Offset = "0x3D32BA0", VA = "0x183D33FA0")]
	public static PBLMAPFOOLN DMNLJJFHBFO(AKCMCEICDOK<T> NBGPBPLKMIE)
	{
		return default(PBLMAPFOOLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CJPAFCAHNOP
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
public class KNEBJPIKILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public KNEBJPIKILJ()
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
