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
public abstract class ILFNCEHCKAI : BFBAJINOMHO, DLJCHKGNAAL, HDAIKDCCLDM<Entity>, ODJIKIADPNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public abstract Type HCHJICPCOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract LOKJOECENDK FIFPHADJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract AMJMPAPLJBA KAMCCHIDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GOEHPNFBIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x968FD0", Offset = "0x9683D0", VA = "0x180968FD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FHNLFFDHAIP<Entity> OJKMFFIEPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x61C0CA0", Offset = "0x61C00A0", VA = "0x1861C0CA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61C0D50", Offset = "0x61C0150", VA = "0x1861C0D50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool AJPDEGILBCF(Entity OGLHBJLEIOC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void EBLDKANKNCA(Entity OGLHBJLEIOC, DLDODMECJDD PCGOHCLJAPN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool NINGCLMMDDO(Entity OGLHBJLEIOC, JCBDEGNNEIK JADIFKAAHNO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void HLJKAIDAIBK(OCDIFNJLDKI DNIOAKOIONL, [Optional] object APOKKKDAFKO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool GEAKIBIKCED(Entity NLLKLENOEEI, Entity PPKEPEHJANL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void EOPEJCOCBHD(EntityManager CDKDONGNIMC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x282F9E0", Offset = "0x282EDE0", VA = "0x18282F9E0")]
	protected void OOGOEAKNPFB<T>(Entity OGLHBJLEIOC, [In] T HKDFGKKEJJB, [In] T JADIFKAAHNO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected ILFNCEHCKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public sealed class OLDJDOOGOCO<T> : ILFNCEHCKAI, IDBNPGCEADE<T>, ALOPCJLPHKO<Entity, T>, HDAIKDCCLDM<Entity>, ODJIKIADPNI, IDisposable, DLJCHKGNAAL, AMJMPAPLJBA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate bool MCGBCGJJBEF(Entity OGLHBJLEIOC, [In] T JADIFKAAHNO);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void OBKMHPKEPEB(Entity OGLHBJLEIOC, [In] T HKDFGKKEJJB, [In] T JADIFKAAHNO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LOKJOECENDK KHEIPMEJPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo MIDDJNKEOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int BMMPAHPPMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int PADMGOMCMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int HIAJHKACHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MCGBCGJJBEF JHGGFDNCLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private OBKMHPKEPEB JBAAJOHEKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private OBKMHPKEPEB DCDDPICEDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World JILIFIHPICM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Type HCHJICPCOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x40EF810", Offset = "0x40EEC10", VA = "0x1840EF810", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override LOKJOECENDK FIFPHADJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override AMJMPAPLJBA KAMCCHIDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private FieldInfo LCAHOLFDFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int HHAPDEKLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE00", Offset = "0x7DB200", VA = "0x1807DBE00", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int KDOJKNJJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7CD110", Offset = "0x7CC510", VA = "0x1807CD110", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private EntityManager MELDPEPFNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x40EB980", Offset = "0x40EAD80", VA = "0x1840EB980")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x40F03E0", Offset = "0x40EF7E0", VA = "0x1840F03E0")]
	public OLDJDOOGOCO(string CCNKHEJHFKM, LOKJOECENDK KHEIPMEJPAD, FieldInfo MIDDJNKEOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x40EAEC0", Offset = "0x40EA2C0", VA = "0x1840EAEC0", Slot = "28")]
	public override void EOPEJCOCBHD(EntityManager CDKDONGNIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40E8D00", Offset = "0x40E8100", VA = "0x1840E8D00")]
	public OLDJDOOGOCO<T> AAOLCNAPHHA(MCGBCGJJBEF JHGGFDNCLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x40EB040", Offset = "0x40EA440", VA = "0x1840EB040")]
	public OLDJDOOGOCO<T> FEDINMOBNMA(OBKMHPKEPEB JBAAJOHEKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x40EB9A0", Offset = "0x40EADA0", VA = "0x1840EB9A0")]
	public OLDJDOOGOCO<T> NDOJABOLHPD(OBKMHPKEPEB DCDDPICEDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x40EA3A0", Offset = "0x40E97A0", VA = "0x1840EA3A0", Slot = "29")]
	public T EBLDKANKNCA(Entity OGLHBJLEIOC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40EF020", Offset = "0x40EE420", VA = "0x1840EF020")]
	public bool NINGCLMMDDO(Entity OGLHBJLEIOC, [In] T JADIFKAAHNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x40E9820", Offset = "0x40E8C20", VA = "0x1840E9820")]
	public bool EAGLNJIPACA(Entity OGLHBJLEIOC, [In] T JADIFKAAHNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x40E8FE0", Offset = "0x40E83E0", VA = "0x1840E8FE0", Slot = "22")]
	public override bool AJPDEGILBCF(Entity OGLHBJLEIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x40E9A80", Offset = "0x40E8E80", VA = "0x1840E9A80", Slot = "23")]
	public override void EBLDKANKNCA(Entity OGLHBJLEIOC, DLDODMECJDD PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40ECD20", Offset = "0x40EC120", VA = "0x1840ECD20", Slot = "24")]
	public override bool NINGCLMMDDO(Entity OGLHBJLEIOC, JCBDEGNNEIK JADIFKAAHNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x40EB8F0", Offset = "0x40EACF0", VA = "0x1840EB8F0", Slot = "25")]
	public override void HLJKAIDAIBK(OCDIFNJLDKI DNIOAKOIONL, [Optional] object APOKKKDAFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40EB7F0", Offset = "0x40EABF0", VA = "0x1840EB7F0", Slot = "26")]
	public override bool GEAKIBIKCED(Entity NLLKLENOEEI, Entity PPKEPEHJANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40EB920", Offset = "0x40EAD20", VA = "0x1840EB920")]
	private bool KBPBJKBICML(T HKDFGKKEJJB, T JADIFKAAHNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DLJCHKGNAAL : HDAIKDCCLDM<Entity>, ODJIKIADPNI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IDBNPGCEADE<T> : ALOPCJLPHKO<Entity, T>, HDAIKDCCLDM<Entity>, ODJIKIADPNI, IDisposable, DLJCHKGNAAL where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface BFBAJINOMHO : DLJCHKGNAAL, HDAIKDCCLDM<Entity>, ODJIKIADPNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int GOEHPNFBIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GNJOFIGPLBH
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27F3C10", Offset = "0x27F3010", VA = "0x1827F3C10")]
	public static T MBGKMEDPMGL<T>(this IDBNPGCEADE<T> KENAPEDMLDN, Entity OGLHBJLEIOC, [Optional] T DADBDDPBLHB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x27F3D90", Offset = "0x27F3190", VA = "0x1827F3D90")]
	public static T PLGGDCCMHCN<T>(this HDAIKDCCLDM<Entity> KENAPEDMLDN, Entity OGLHBJLEIOC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x27F3AF0", Offset = "0x27F2EF0", VA = "0x1827F3AF0")]
	public static bool IEOJFHFJBJL<T>(this HDAIKDCCLDM<Entity> KENAPEDMLDN, Entity OGLHBJLEIOC, [In] T JADIFKAAHNO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FHNLFFDHAIP<TKey>(TKey LIKEKIACGIL, [In] JCBDEGNNEIK HKDFGKKEJJB, [In] JCBDEGNNEIK JADIFKAAHNO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BLDHEAFMKJE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x25C2350", Offset = "0x25C1750", VA = "0x1825C2350")]
	public static void CAFHCMPOKLC<TKey, T>(this FHNLFFDHAIP<TKey> PLEAEFJJBBO, TKey LIKEKIACGIL, T HKDFGKKEJJB, T JADIFKAAHNO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OCDIFNJLDKI
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHBCCHFBHAN<TKey, T>(ALOPCJLPHKO<TKey, T> KENAPEDMLDN, [Optional] object APOKKKDAFKO) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CKGHKIPIMPM
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AMJMPAPLJBA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo AIEAPCNNOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int JDFFMJCEGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int JOOOJCLOMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ODJIKIADPNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type HCHJICPCOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AMJMPAPLJBA KAMCCHIDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LOKJOECENDK FIFPHADJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int GOEHPNFBIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HLJKAIDAIBK(OCDIFNJLDKI DNIOAKOIONL, [Optional] object APOKKKDAFKO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HDAIKDCCLDM<TKey> : ODJIKIADPNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FHNLFFDHAIP<TKey> OJKMFFIEPJO;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJPDEGILBCF(TKey NIOPCMHKLMB);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBLDKANKNCA(TKey NIOPCMHKLMB, DLDODMECJDD PCGOHCLJAPN);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NINGCLMMDDO(TKey NIOPCMHKLMB, JCBDEGNNEIK JADIFKAAHNO);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GEAKIBIKCED(TKey NLLKLENOEEI, TKey PPKEPEHJANL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public interface ALOPCJLPHKO<TKey, T> : HDAIKDCCLDM<TKey>, ODJIKIADPNI, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T EBLDKANKNCA(TKey NIOPCMHKLMB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GFFJPGKHHCO
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x27E4DD0", Offset = "0x27E41D0", VA = "0x1827E4DD0")]
	public static bool OPHEKCAINKH<TKey, T>(this HDAIKDCCLDM<TKey> KENAPEDMLDN, TKey NIOPCMHKLMB, [Out] T PCGOHCLJAPN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x27E4030", Offset = "0x27E3430", VA = "0x1827E4030")]
	public static T EBLDKANKNCA<T, TKey>(this HDAIKDCCLDM<TKey> KENAPEDMLDN, TKey NIOPCMHKLMB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x27E4710", Offset = "0x27E3B10", VA = "0x1827E4710")]
	public static bool NINGCLMMDDO<TKey, T>(this HDAIKDCCLDM<TKey> KENAPEDMLDN, TKey NIOPCMHKLMB, T JADIFKAAHNO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface PGONFJDEIMC : IEnumerable<DLJCHKGNAAL>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LOKJOECENDK
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int LKGLILBFMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int MEECKLKEIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type OFFANEKFHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	DLJCHKGNAAL[] AODGCONKJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) FNIBBJMKALI(Entity OGLHBJLEIOC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BLOIIHMALHP(Entity OGLHBJLEIOC, (uint order, uint change) PAKIAOEKDPK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class IBNJDNAPLOA : PGONFJDEIMC, IEnumerable<DLJCHKGNAAL>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<DLJCHKGNAAL> LHFMMMCJCCK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61C0780", Offset = "0x61BFB80", VA = "0x1861C0780", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DLJCHKGNAAL BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61C06A0", Offset = "0x61BFAA0", VA = "0x1861C06A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61C0C60", Offset = "0x61C0060", VA = "0x1861C0C60")]
	public IBNJDNAPLOA(IEnumerable<LOKJOECENDK> MDPFOEPJIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61C07C0", Offset = "0x61BFBC0", VA = "0x1861C07C0")]
	private List<DLJCHKGNAAL> IIFJHODEFNE(IEnumerable<LOKJOECENDK> MDPFOEPJIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61C0700", Offset = "0x61BFB00", VA = "0x1861C0700", Slot = "4")]
	public IEnumerator<DLJCHKGNAAL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61C0700", Offset = "0x61BFB00", VA = "0x1861C0700", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KALDGKCBNIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type JPPCEHAGAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string CCNKHEJHFKM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
	public KALDGKCBNIO(Type JPPCEHAGAGN, string CCNKHEJHFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FPIAKKBMKOD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type JPPCEHAGAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string CCNKHEJHFKM;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
	public FPIAKKBMKOD(Type JPPCEHAGAGN, string CCNKHEJHFKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x37070F0", Offset = "0x37064F0", VA = "0x1837070F0")]
	public static KALDGKCBNIO JNPLDNCEKAI(FPIAKKBMKOD<T> GEGFGGCOHCE)
	{
		return default(KALDGKCBNIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PNBNAMDGGPA
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
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GGOHFKMAPDD
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public GGOHFKMAPDD()
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
