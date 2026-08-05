using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.CodeGen.Attributes;
using RecRoom.Components;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GMODGGFANJI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly List<(LOBNDPHFMLE nameHash, DPOIMOJBLLE stableTypeHash, Type type)> FLFDIHLIJKD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly List<(LOBNDPHFMLE nameHash, DPOIMOJBLLE stableTypeHash, Type type)> CBILPPIKJFL;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly List<(LOBNDPHFMLE previousNameHash, DPOIMOJBLLE previousStableTypeHash, Type currentTypeName)> CFIGJOMMOMN;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GPGCNAEGLDE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Rigidbody JPHDKFDHOEE;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6650670", Offset = "0x664F870", VA = "0x186650670", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public GPGCNAEGLDE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DEAHBOJIPPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NMLGGFPNFEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public FOILGMPPBAK NPMHEGCJEAG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FOJELFKNGOB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KKCBJIFOAFJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public object IBDDJOKEBPA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6651E80", Offset = "0x6651080", VA = "0x186651E80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KKCBJIFOAFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct GGINJDAENOI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity PPANDIPJOLP;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EFDDNLIAFDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float KGDEANLCBAE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DDKHFNGLFEP<EFDDNLIAFDJ> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ABHDCDIPFBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float3 FGEAPCPJDBP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DIECJIPFDGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JGABCBFOGEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNDBIBLBMII(PABPBCLLOCG JIDECECIIFE, PABPBCLLOCG EBJPGOJMKLG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBGBMBFEMHE();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPCHLFAKBJD();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHFILNFIKBO(bool IHFFPKKEBBB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NKFNMJBKDMB();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAGOALKPFPI();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IHMMJHJKKGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IKJONGBEEDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int KOEDGHJMMIE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x146B210", Offset = "0x146A410", VA = "0x18146B210")]
	public static IKJONGBEEDH OMHOCPNBHHH(int NABCGCEIEGG)
	{
		return default(IKJONGBEEDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum FOILGMPPBAK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum LGJDBCELJGC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OFEJBHGNNGK : GDNHGAGIENF, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PCJNFDJKBDM HICMPCHIMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PCJNFDJKBDM);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IGKIKGDPCOF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public JGABCBFOGEC ALBONKDHIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66511A0", Offset = "0x66503A0", VA = "0x1866511A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public IGKIKGDPCOF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OFPHNBMAMJD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LJLCKDBFJPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3x3 KMHFCIGLKMG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly DDKHFNGLFEP<LJLCKDBFJPB> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EKBECNAGHMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float COIOKMCEEHL;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly DDKHFNGLFEP<EKBECNAGHMK> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[HKHGONOPDJJ]
public struct CIIJPLFLDAC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Entity BLNICJMKCEF;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GJMKIKKIJMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float FKHLIFIDPGJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly DDKHFNGLFEP<GJMKIKKIJMF> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NPAEBGIHHKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 JDBFMFOBMKF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ONEBNOCDFJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Entity MKADPIPCNMO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct GNBCALAPBDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PABPBCLLOCG
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DLBFAOEGKJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3x3 KMHFCIGLKMG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DDKHFNGLFEP<LJLCKDBFJPB> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MILEDLCHDCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity OJEMCPHOKBP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FKLDOFHLELG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FNMJCKGBJKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public FOILGMPPBAK HBBBKGALBBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BBLCLBKLLGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public RigidbodyConstraints LFNBMNEJBMG;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LBLDCBDNKCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float DOLOOPAKJBD;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly DDKHFNGLFEP<LBLDCBDNKCL> NBIAOCJLGIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PJCEALODBDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct IKHBCCAECIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public PABPBCLLOCG EGNKFKHKJED;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly DDKHFNGLFEP<IKHBCCAECIK> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct DFPLJKLDEBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public CollisionDetectionMode LGMAMNAKKDG;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DGAEMMILCEL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public object KLBAKKGODED;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x664CE40", Offset = "0x664C040", VA = "0x18664CE40", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public DGAEMMILCEL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CBEPBEPDPBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HHPNFKONMPB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct FILBBKPDCMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float3 IADJPJPANBP;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct FBDLOELFKPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float NPCGKJPCPGI;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LPCILDABAAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 GJEHAPNKNBM;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[InternalBufferCapacity(8)]
public struct JFFGLDLIPLN : ISystemStateBufferElementData, IBufferElementData, IEquatable<JFFGLDLIPLN>, GBELNJMIIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity PPANDIPJOLP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity EOONBAOMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0")]
	public JFFGLDLIPLN(Entity PPANDIPJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x664D630", Offset = "0x664C830", VA = "0x18664D630", Slot = "4")]
	public bool Equals(JFFGLDLIPLN JMNBIHILIIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static JFFGLDLIPLN OMHOCPNBHHH(Entity BLNICJMKCEF)
	{
		return default(JFFGLDLIPLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct AEJNAFBLHNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ICIFNGLCBLG(1)]
	public Entity BJPEGONLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ICIFNGLCBLG(2)]
	public bool GGCJBJHGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ICIFNGLCBLG(3)]
	public float AFKEGDFEKDD;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[PNBIFHHDBNE(1)]
public struct LGOCNEHIALI : INGMBGOCEKO, IEquatable<LGOCNEHIALI>
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly LGOCNEHIALI MOBOMNFBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[IEIMNMEGNHM(1)]
	public int CJNGPAPKKID;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
	public LGOCNEHIALI(int CJNGPAPKKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6652100", Offset = "0x6651300", VA = "0x186652100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6652070", Offset = "0x6651270", VA = "0x186652070", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2CB0", Offset = "0x3AC1EB0", VA = "0x183AC2CB0", Slot = "6")]
	public bool Equals(LGOCNEHIALI JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x66521A0", Offset = "0x66513A0", VA = "0x1866521A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6652180", Offset = "0x6651380", VA = "0x186652180", Slot = "5")]
	public void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6652170", Offset = "0x6651370", VA = "0x186652170", Slot = "4")]
	public void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct BOHGFEOLDLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ICIFNGLCBLG(1)]
	public float MELLDFCPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly DDKHFNGLFEP<BOHGFEOLDLP> NBIAOCJLGIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal struct OHCKOMILNOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal struct NKBEDDLCDIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Entity BLNICJMKCEF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static NKBEDDLCDIC OMHOCPNBHHH(Entity BLNICJMKCEF)
	{
		return default(NKBEDDLCDIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AFGAEKNHDDJ]
[HHGLODKFBFJ("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct COFCBIMKLHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(1)]
	public AFCPMJNOFLE HCCLEJHCLJP;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Flags]
[KOOAACGNPJE(0, 15943)]
public enum AFCPMJNOFLE
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct HNIEMGKBHMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct AJOFFIINELF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OLOBONAKFAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BLFLALOKPIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct MNBDHEBEKAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LECKLKJMLDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct EJECJLGLNLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IPPPIMBONPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct IJNNNEBCOBK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct LFMDDLCGAGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[IEIMNMEGNHM(1)]
	public OIGCJBPECJE KBIJDJHCEBH;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly DDKHFNGLFEP<LFMDDLCGAGB> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum OIGCJBPECJE : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct MIKHADPILJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ICIFNGLCBLG(1)]
	public float3 PBHILHOLGEM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly DDKHFNGLFEP<MIKHADPILJF> NBIAOCJLGIM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
	public static MIKHADPILJF OMHOCPNBHHH(float3 NABCGCEIEGG)
	{
		return default(MIKHADPILJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[EBGBFBIDBLB]
[NIMLPLFPLGO(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct FPOBAOLIOFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int JMHIFJMLOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ICIFNGLCBLG(2)]
	public bool GLBEFGHMHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ICIFNGLCBLG(3)]
	public bool BKMMOHBPPGI;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly DDKHFNGLFEP<FPOBAOLIOFC> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct LLPDNIBHICC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float IHNHFHPFFNA;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly DDKHFNGLFEP<LLPDNIBHICC> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct FLFCLFLDKKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[ICIFNGLCBLG(1)]
	public SerializableGuid ICCMHBOIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ICIFNGLCBLG(2)]
	public SerializableGuid MKJGAIOAKMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[AFGAEKNHDDJ]
[HHGLODKFBFJ("Container", 0)]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
public struct MHKJKOAIFPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ICIFNGLCBLG(1)]
	[HMFLIOHMGBD(0)]
	public LNFLOBOMJKO DEJDKAPODIK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly DDKHFNGLFEP<MHKJKOAIFPO> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[KOOAACGNPJE(0, 2)]
public enum LNFLOBOMJKO
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal enum OODLGGPDEAM
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class HBDJNAKPMDI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FLJLFHFJEPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct PPBGAJPLLMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ICIFNGLCBLG(1)]
	public bool KCEMMLEMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ICIFNGLCBLG(2)]
	public bool GGCJBJHGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ICIFNGLCBLG(3)]
	public float BLBKLGDEKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ICIFNGLCBLG(4)]
	public float JGECELACBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ICIFNGLCBLG(5)]
	public float CBOHJJDJGAA;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[PNBIFHHDBNE(1)]
public struct MGOHIBGGGFF : INGMBGOCEKO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Flags]
	[KOOAACGNPJE(0, 7)]
	public enum IOIJKHBGCDG
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[IEIMNMEGNHM(1)]
	public float MIFDABHFCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[IEIMNMEGNHM(2)]
	public int KGEPCNGNBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[IEIMNMEGNHM(3)]
	public IOIJKHBGCDG HCCLEJHCLJP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EFMENDIJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6652DA0", Offset = "0x6651FA0", VA = "0x186652DA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6652D60", Offset = "0x6651F60", VA = "0x186652D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MKIMGGMOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6652F50", Offset = "0x6652150", VA = "0x186652F50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6652D80", Offset = "0x6651F80", VA = "0x186652D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DOFLJBPHBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6652E80", Offset = "0x6652080", VA = "0x186652E80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6652FD0", Offset = "0x66521D0", VA = "0x186652FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6652F00", Offset = "0x6652100", VA = "0x186652F00", Slot = "5")]
	public void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6652E20", Offset = "0x6652020", VA = "0x186652E20", Slot = "4")]
	public void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal struct DEFMFCBIIBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct HLNFABHIAIF : ISystemStateComponentData, IComponentData, GBELNJMIIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity JLJDDOBIKDP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity EOONBAOMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct OPOLINBDEBP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct MJMFHACLBAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KHKFGBALMEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float4x4 LJFCGJENHAM;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly DDKHFNGLFEP<KHKFGBALMEN> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct PKJNCNHFGJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ICIFNGLCBLG(1)]
	public LNPONMIIMBL DLFDCBCMMIO;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct NEDOPGBAPGB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Flags]
	[KOOAACGNPJE(0, 7)]
	public enum LHCPCKCFDHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ICIFNGLCBLG(1)]
	public LHCPCKCFDHP HCCLEJHCLJP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly DDKHFNGLFEP<NEDOPGBAPGB> NBIAOCJLGIM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OPGMGJICJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x66531C0", Offset = "0x66523C0", VA = "0x1866531C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EDFENIGHLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6653140", Offset = "0x6652340", VA = "0x186653140")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct KKBPIMDFIGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ICIFNGLCBLG(1)]
	public float MELLDFCPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly DDKHFNGLFEP<KKBPIMDFIGE> NBIAOCJLGIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct ENAOFKLNGMF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct PDGDKKKADOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ICIFNGLCBLG(1)]
	public HBANKPKIGIN EMHINNCNJJH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct JFFAJHEDCAD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct GAAIHPAGNAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ICIFNGLCBLG(1)]
	public Entity IEFMFCGPBPC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct NEDOOFANCKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[KOOAACGNPJE(0, 9)]
public enum FHOKMDLBODC
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FJKJCJLFEAO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x664D640", Offset = "0x664C840", VA = "0x18664D640")]
	public static bool ILBIKAMLKAD(this FHOKMDLBODC DPLLAFOCEAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[KOOAACGNPJE(-1, 38)]
public enum EKGFPCGJLIK
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[EBGBFBIDBLB]
[NIMLPLFPLGO(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct NJKGKIMPNLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ICIFNGLCBLG(1)]
	public IANCKMHPHEB GLKDKMADKLI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HLIALJLAJPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct GNKOBLOMFBP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[KOOAACGNPJE(0, 2)]
public enum IKAFEOPNGGL
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[KOOAACGNPJE(0, 1)]
public enum HBANKPKIGIN
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	MAX = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct PGFOEKEBDCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HEIMCAHLGCI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct GACBCEKGGOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ICIFNGLCBLG(1)]
	public HNPMAFNAGGH AGBECMHFPOA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static GACBCEKGGOB OMHOCPNBHHH(HNPMAFNAGGH NABCGCEIEGG)
	{
		return default(GACBCEKGGOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[HHGLODKFBFJ("Container", 0)]
public struct EMMOOFOOLFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[ICIFNGLCBLG(1)]
	[HMFLIOHMGBD(0)]
	public FixedString64Bytes JPKENOAMLIN;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class MMCAEPEONNK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66530C0", Offset = "0x66522C0", VA = "0x1866530C0")]
	public static void BNDJKAKDCIM(this ref JDFHJEOHFGL HCCLEJHCLJP, IBLIHOJHMNC LPAHHGOEHAO, bool AICOLMFCHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6653110", Offset = "0x6652310", VA = "0x186653110")]
	public static bool DOGJJBLODFI(this JDFHJEOHFGL HCCLEJHCLJP, IBLIHOJHMNC LPAHHGOEHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6653130", Offset = "0x6652330", VA = "0x186653130")]
	public static JDFHJEOHFGL KCEEMNFCBIN(this IBLIHOJHMNC LPAHHGOEHAO)
	{
		return default(JDFHJEOHFGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x66530F0", Offset = "0x66522F0", VA = "0x1866530F0")]
	public static void BNDJKAKDCIM(this ref ACNNOHILHOO HCCLEJHCLJP, ACNNOHILHOO NEPBCPCCOKF, bool AICOLMFCHMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum IBLIHOJHMNC
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Flags]
[KOOAACGNPJE(0, 16383)]
public enum JDFHJEOHFGL
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[Flags]
[KOOAACGNPJE(0, 3)]
public enum ACNNOHILHOO
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	MAX = 3
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[EBGBFBIDBLB]
[NIMLPLFPLGO(17667479821163689808uL, 11946378475791123970uL)]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
public struct NOCIMDECKCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PGGEFBKGHDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[EBGBFBIDBLB]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[NIMLPLFPLGO(1029043735688538310uL, 14256247939851101839uL)]
public struct NEKCKADNKFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public FHOKMDLBODC DPLLAFOCEAG;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KOOAACGNPJE(int.MinValue, int.MaxValue)]
public enum GLADLPGDHJF
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[AFGAEKNHDDJ]
[HHGLODKFBFJ("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct PDLNAIIAPAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ICIFNGLCBLG(1)]
	[HMFLIOHMGBD(0)]
	public bool EECCCGAOPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(2)]
	public float MIGCJHFANIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(3)]
	public float LPHPDIBJEMD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct GKPIGFLADHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[HHGLODKFBFJ("Container", 0)]
public struct BCEMANPLODD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ICIFNGLCBLG(1)]
	[HMFLIOHMGBD(0)]
	public float KFLBBLALBEB;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CGAPDPKGPAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private NativeList<ACLBMNIEIDO> EBANKOKIHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private NativeList<Entity> AGEKKLBLMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private JobHandle FHGDOMMIJLE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BNBLLGADOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x664C790", Offset = "0x664B990", VA = "0x18664C790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x664C800", Offset = "0x664BA00", VA = "0x18664C800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xE6A100", Offset = "0xE69300", VA = "0x180E6A100")]
	public CGAPDPKGPAD(NativeList<ACLBMNIEIDO> EBANKOKIHCJ, NativeList<Entity> AGEKKLBLMAJ, JobHandle FHGDOMMIJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x664C640", Offset = "0x664B840", VA = "0x18664C640")]
	public (Entity, NativeSlice<Entity>) HINFNNLBLFP(int LHPGLCOPMKK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x664C5E0", Offset = "0x664B7E0", VA = "0x18664C5E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GMIHIEHPGOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public float3 BOEKENJNLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public quaternion ELGEECMLAMI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static readonly DDKHFNGLFEP<GMIHIEHPGOF> NBIAOCJLGIM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x664DDD0", Offset = "0x664CFD0", VA = "0x18664DDD0")]
	public float3 FCKLKGOODAI(float3 GKENIDGAHNF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class KJCNOCBPGCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[EBGBFBIDBLB]
[NIMLPLFPLGO(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
public struct KFPEGLMENKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private uint JLNKCNKMLBL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct LCAGEBOGKAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[HHGLODKFBFJ("Light", 0)]
public struct JHGPOFJIAHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(1)]
	public float FJOOHPLDPBF;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct OCJCLNDJHEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[ICIFNGLCBLG(1)]
	public quaternion KGFPECIFPNA;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static readonly DDKHFNGLFEP<OCJCLNDJHEJ> NBIAOCJLGIM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
	public static OCJCLNDJHEJ OMHOCPNBHHH(quaternion NABCGCEIEGG)
	{
		return default(OCJCLNDJHEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct MCJCDKMPGIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[ICIFNGLCBLG(1)]
	public Entity BJPEGONLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ICIFNGLCBLG(2)]
	public bool OBJKGMOLGDD;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct AIOCDBLOONJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public FixedString32Bytes JPKENOAMLIN;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[EBGBFBIDBLB]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[NIMLPLFPLGO(4470189027631723570uL, 5922380073816386711uL)]
public struct DHGBDJJKCDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[IEIMNMEGNHM(1)]
	public JDFHJEOHFGL HCCLEJHCLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ICIFNGLCBLG(2)]
	public KJGKMMIGCMI GHJHJODNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(3)]
	public ACNNOHILHOO DCFPDPANMAN;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static readonly DDKHFNGLFEP<DHGBDJJKCDH> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct OLADFJFFPGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Entity JDKCDALHCCM;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[Flags]
[KOOAACGNPJE(0, 1)]
public enum BOOJLMDIFHN
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	All = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct ONPCICOODNF : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[PNBIFHHDBNE(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[IEIMNMEGNHM(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[IEIMNMEGNHM(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[IEIMNMEGNHM(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[IEIMNMEGNHM(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[PNBIFHHDBNE(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, INGMBGOCEKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[IEIMNMEGNHM(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
		public static SerializableGuid OMHOCPNBHHH(Guid BHKAMCELBPN)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6654830", Offset = "0x6653A30", VA = "0x186654830", Slot = "4")]
		public bool Equals(SerializableGuid JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6654810", Offset = "0x6653A10", VA = "0x186654810", Slot = "5")]
		public int CompareTo(SerializableGuid JMNBIHILIIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x66548C0", Offset = "0x6653AC0", VA = "0x1866548C0", Slot = "6")]
		public void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x66549B0", Offset = "0x6653BB0", VA = "0x1866549B0", Slot = "7")]
		public void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6654A30", Offset = "0x6653C30", VA = "0x186654A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct GIFDDDKMKFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct BABJHBDPCMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[KOOAACGNPJE(0, 4)]
public enum DJLENGEJFOG
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct FCDGKCANOCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[ICIFNGLCBLG(1)]
	public bool LPBCAGKFJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[ICIFNGLCBLG(2)]
	public byte IOCGHNFHIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[ICIFNGLCBLG(3)]
	public short OIOLPIKKKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[ICIFNGLCBLG(4)]
	public ushort KHPNKGCJBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[ICIFNGLCBLG(5)]
	public int BALFFEEBKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[ICIFNGLCBLG(6)]
	public uint KMHCJNHKIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[ICIFNGLCBLG(7)]
	public long MFDCHFLEIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[ICIFNGLCBLG(8)]
	public ulong AGLHANHKMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ICIFNGLCBLG(9)]
	public float LHKGNKGGEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ICIFNGLCBLG(10)]
	public double EDKKHJAFLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[ICIFNGLCBLG(11)]
	public BAAMIKLEFBJ BJNICFKACBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[ICIFNGLCBLG(12)]
	public DPEODDODHBB PFCPNLPBJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[ICIFNGLCBLG(13)]
	public ICDPIBNLCAG PMPGCJFMPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ICIFNGLCBLG(14)]
	public FFADJKNCIDD NCGKGBPBAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ICIFNGLCBLG(15)]
	public FJLHIHHHKNI CCPFDMGKIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ICIFNGLCBLG(16)]
	public GJCOMPDCENE MDADDKFBMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ICIFNGLCBLG(17)]
	public LNDJGOECPIB HBIPJKHHMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[ICIFNGLCBLG(18)]
	public PNJGFPPMKJO LAAJHABPPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ICIFNGLCBLG(20)]
	public Quaternion LFBDOGFPLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ICIFNGLCBLG(22)]
	public Vector3 DEOODKNGEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ICIFNGLCBLG(23)]
	public Vector4 JCMBNJCGEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ICIFNGLCBLG(40)]
	public Entity FFJOKOKABGG;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public enum BAAMIKLEFBJ : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum DPEODDODHBB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum ICDPIBNLCAG : short
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum FFADJKNCIDD : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum FJLHIHHHKNI
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum GJCOMPDCENE : uint
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum LNDJGOECPIB : long
{
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum PNJGFPPMKJO : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[AFGAEKNHDDJ]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[AFGAEKNHDDJ]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class KEPIKEOMDKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public int CCBKAEHNCPH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public int JFCNCGNOKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public GameObject HAAGKPEGEHP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KEPIKEOMDKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class NGLEAFCMFGB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct BPICIBBHDNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Vector3 IPCNILMMDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public List<SerializableGuid> IIAPONHKCEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class ELDLDCMMHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public BPICIBBHDNJ OEILIIMMLGF;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ELDLDCMMHMM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public SerializableGuid NOMFGOLLJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public List<int> PGKNJAEDGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public List<BPICIBBHDNJ> BBNGDKOIGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public List<ELDLDCMMHMM> GOBFFAIOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public GameObject HAAGKPEGEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Light GPOEMHCNKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Collider NAKCMDMIPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public string OFLENMNNADK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public NGLEAFCMFGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[EBGBFBIDBLB]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[NIMLPLFPLGO(2613756846563002039uL, 6372660366488563574uL)]
[HHGLODKFBFJ("Container", 0)]
public struct HBMCJGGAGML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	[ICIFNGLCBLG(1)]
	[HMFLIOHMGBD(0)]
	public LHEPMDBBAHH AIDFHICLHMO;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[Flags]
[KOOAACGNPJE(0, 15)]
public enum LHEPMDBBAHH
{
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[EBGBFBIDBLB]
[NIMLPLFPLGO(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct PCMGFFJLBIH : IComponentData, IEquatable<PCMGFFJLBIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ICIFNGLCBLG(1)]
	public FixedString64Bytes JPKENOAMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[ICIFNGLCBLG(2)]
	public LNFLOBOMJKO DEJDKAPODIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[ICIFNGLCBLG(3)]
	public LHEPMDBBAHH AIDFHICLHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[ICIFNGLCBLG(4)]
	public MDFBMNJHFOE BPMMGIIIJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	[ICIFNGLCBLG(5)]
	public AFCPMJNOFLE HCCLEJHCLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	[ICIFNGLCBLG(6)]
	public float KFLBBLALBEB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6653820", Offset = "0x6652A20", VA = "0x186653820", Slot = "4")]
	public bool Equals(PCMGFFJLBIH JMNBIHILIIC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct KFDHPNCAPNJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct BKCCEEBHOIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	[ICIFNGLCBLG(1)]
	public MGOHIBGGGFF HPANENBGKED;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct AJALCLPOENM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	[ICIFNGLCBLG(1)]
	public float3 DGDMDKFMBBA;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly DDKHFNGLFEP<AJALCLPOENM> NBIAOCJLGIM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
	public static AJALCLPOENM OMHOCPNBHHH(float3 NABCGCEIEGG)
	{
		return default(AJALCLPOENM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct AKFBEAGBHPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Entity JDKCDALHCCM;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[InternalBufferCapacity(8)]
public struct FBIOENFOJHC : ISystemStateBufferElementData, IBufferElementData, IEquatable<FBIOENFOJHC>, GBELNJMIIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public Entity PPANDIPJOLP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity EOONBAOMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x664D630", Offset = "0x664C830", VA = "0x18664D630", Slot = "4")]
	public bool Equals(FBIOENFOJHC JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal struct MGGPMFEKEHP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public Entity IEFMFCGPBPC;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[KOOAACGNPJE(0, 4)]
public enum LNPONMIIMBL
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct CHDOFCKIBBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	[ICIFNGLCBLG(1)]
	public quaternion KGFPECIFPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	[ICIFNGLCBLG(2)]
	public float3 DGDMDKFMBBA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly DDKHFNGLFEP<CHDOFCKIBBD> NBIAOCJLGIM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x15BD770", Offset = "0x15BC970", VA = "0x1815BD770")]
	public CHDOFCKIBBD(quaternion KGFPECIFPNA, float3 DGDMDKFMBBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x664C850", Offset = "0x664BA50", VA = "0x18664C850")]
	public static RigidTransform OMHOCPNBHHH(CHDOFCKIBBD LEHJGJLGJFH)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x664C850", Offset = "0x664BA50", VA = "0x18664C850")]
	public static CHDOFCKIBBD OMHOCPNBHHH(RigidTransform JMLNOEBANEC)
	{
		return default(CHDOFCKIBBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class EBKGJIBEKLK
{
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface GBELNJMIIOO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity LFHLHOCLJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[EBGBFBIDBLB]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[NIMLPLFPLGO(9807788745867066359uL, 15168486114979071194uL)]
public struct NELMEDAHHKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	[ICIFNGLCBLG(1)]
	public JDFHJEOHFGL HCCLEJHCLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[ICIFNGLCBLG(2)]
	public KJGKMMIGCMI GHJHJODNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	[ICIFNGLCBLG(3)]
	[HMFLIOHMGBD(0)]
	public bool DHMNNPNBIKA;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static readonly DDKHFNGLFEP<NELMEDAHHKH> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[AFGAEKNHDDJ]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
public struct BDMAHJJMIAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ICIFNGLCBLG(2)]
	public bool GLBEFGHMHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[ICIFNGLCBLG(3)]
	public bool BKMMOHBPPGI;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static readonly DDKHFNGLFEP<BDMAHJJMIAA> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[HHGLODKFBFJ("Object", 0)]
[TypeManager.TypeVersion(2)]
public struct AOGLDAFPMJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[ICIFNGLCBLG(2)]
	public KJGKMMIGCMI GHJHJODNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(3)]
	public ACNNOHILHOO DCFPDPANMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[IEIMNMEGNHM(4)]
	public JDFHJEOHFGL HCCLEJHCLJP;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly DDKHFNGLFEP<AOGLDAFPMJF> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct BIIDNNEAIEC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public int MIOMNEOFMJG;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct KDPALPIPICP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public GCHandle GHLDLPCMADC;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct JNGGGJCNGDE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private int PLJMHLHCEAO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NNAODBDJDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6651620", Offset = "0x6650820", VA = "0x186651620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6651630", Offset = "0x6650830", VA = "0x186651630")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct FOGHKBPABNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	[ICIFNGLCBLG(1)]
	public Entity CJIKOMJOMEO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static FOGHKBPABNM OMHOCPNBHHH(Entity BLNICJMKCEF)
	{
		return default(FOGHKBPABNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[EBGBFBIDBLB]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[NIMLPLFPLGO(14327281633525910712uL, 2559857777606771911uL)]
public struct FFHIPEJHOGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	[ICIFNGLCBLG(1)]
	public IANCKMHPHEB GLKDKMADKLI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct DHEBLHGLNPM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct EPFNMOOOKJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	[ICIFNGLCBLG(1)]
	public float3 AJGGGKIEIFI;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly DDKHFNGLFEP<EPFNMOOOKJI> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[HHGLODKFBFJ("Container", 0)]
public struct OFGNLEEBOEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(1)]
	public MDFBMNJHFOE BPMMGIIIJBN;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[KOOAACGNPJE(0, 1)]
public enum MDFBMNJHFOE
{
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[PNBIFHHDBNE(1)]
public struct KJGKMMIGCMI : INGMBGOCEKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[IEIMNMEGNHM(1)]
	public bool EECCCGAOPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	[IEIMNMEGNHM(2)]
	public float3 FEDKOCKBBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	[IEIMNMEGNHM(3)]
	public float3 GCCKMBCFHNA;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static readonly DDKHFNGLFEP<KJGKMMIGCMI> NBIAOCJLGIM;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6651D10", Offset = "0x6650F10", VA = "0x186651D10", Slot = "5")]
	public void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6651CC0", Offset = "0x6650EC0", VA = "0x186651CC0", Slot = "4")]
	public void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct FIMBLCDCKDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	[ICIFNGLCBLG(1)]
	public EKGFPCGJLIK NONIDCJCBEN;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct NGMAPOHIHCK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public int MIOMNEOFMJG;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public interface IFMFKMLAHFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMIEGNDCKII(bool MCIMDKDHFFG);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.TypeVersion(2)]
public struct GODAIDEBOAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public uint MLONNHODGPN;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x66505E0", Offset = "0x664F7E0", VA = "0x1866505E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct GDIMPBACNAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal struct DMDGKAEIEFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct PGCMFNNLLKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[HKHGONOPDJJ]
internal struct LPHFGDMHOBO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public Entity DHGONMBIOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int NNAODBDJDNJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct PGBILDHAAAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[HHGLODKFBFJ("Visual", 0)]
public struct NKCHPCLGAKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(1)]
	public GLADLPGDHJF GGJPGIMIKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(2)]
	public ONNAFMGNPOD GMJJKHGKCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(3)]
	public float ICGLNMBGNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(4)]
	public Vector3 NJOJGCPDKKF;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[AFGAEKNHDDJ]
[HHGLODKFBFJ("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct EDICBKLMJAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[HMFLIOHMGBD(0)]
	[ICIFNGLCBLG(1)]
	public float AHPJGLFGGNA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public static readonly DDKHFNGLFEP<EDICBKLMJAO> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[PNBIFHHDBNE(1)]
public struct HNPMAFNAGGH : IComparable<HNPMAFNAGGH>, IEquatable<HNPMAFNAGGH>, INGMBGOCEKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[IEIMNMEGNHM(1)]
	public uint ENEDDMMFIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[IEIMNMEGNHM(2)]
	public uint KIMOEOGHJHG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint BLGGPCBEIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6650ED0", Offset = "0x66500D0", VA = "0x186650ED0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6650FC0", Offset = "0x66501C0", VA = "0x186650FC0")]
	public HNPMAFNAGGH(int ENEDDMMFIEN, int OJGGEIKDFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6650FC0", Offset = "0x66501C0", VA = "0x186650FC0")]
	public HNPMAFNAGGH(uint ENEDDMMFIEN, uint OJGGEIKDFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6650E70", Offset = "0x6650070", VA = "0x186650E70")]
	public HNPMAFNAGGH MGLEGCPKBJM(int MLHOBKJDKGI = 1)
	{
		return default(HNPMAFNAGGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6650CB0", Offset = "0x664FEB0", VA = "0x186650CB0")]
	public HNPMAFNAGGH IKPDGADHOII(int MLHOBKJDKGI = 1)
	{
		return default(HNPMAFNAGGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6650DF0", Offset = "0x664FFF0", VA = "0x186650DF0")]
	public static HNPMAFNAGGH MDHMGLJCNJK(HNPMAFNAGGH NPCLKEGHIKP, HNPMAFNAGGH NCHMBLEIGHE)
	{
		return default(HNPMAFNAGGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6650C80", Offset = "0x664FE80", VA = "0x186650C80")]
	private static uint HGJELCLPNMO(uint GGFLAOCNMAP, uint PIINDHALINJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6650B50", Offset = "0x664FD50", VA = "0x186650B50", Slot = "4")]
	public int CompareTo(HNPMAFNAGGH JMNBIHILIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6650B90", Offset = "0x664FD90", VA = "0x186650B90", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6650EE0", Offset = "0x66500E0", VA = "0x186650EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6650B70", Offset = "0x664FD70", VA = "0x186650B70", Slot = "5")]
	public bool Equals(HNPMAFNAGGH JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6650C30", Offset = "0x664FE30", VA = "0x186650C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6650D10", Offset = "0x664FF10", VA = "0x186650D10", Slot = "6")]
	public void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6650D80", Offset = "0x664FF80", VA = "0x186650D80", Slot = "7")]
	public void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x350C030", Offset = "0x350B230", VA = "0x18350C030")]
	public static bool IJMFMDJGAHN(HNPMAFNAGGH NPCLKEGHIKP, HNPMAFNAGGH NCHMBLEIGHE)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[AFGAEKNHDDJ]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public IANCKMHPHEB prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class GDIKAGBNKBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x664DA60", Offset = "0x664CC60", VA = "0x18664DA60")]
	public static bool OKADFKFICDF(this IANCKMHPHEB FBNKHAJKFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x664D9E0", Offset = "0x664CBE0", VA = "0x18664D9E0")]
	public static string IHNOKGELKOB(this IANCKMHPHEB FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x664D9C0", Offset = "0x664CBC0", VA = "0x18664D9C0")]
	public static FHOKMDLBODC FAFBPKCECOE(this IANCKMHPHEB GLKDKMADKLI)
	{
		return default(FHOKMDLBODC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x664DAB0", Offset = "0x664CCB0", VA = "0x18664DAB0")]
	internal static OODLGGPDEAM PNOEOOMIHPK(this FHOKMDLBODC DPLLAFOCEAG)
	{
		return default(OODLGGPDEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x664DA90", Offset = "0x664CC90", VA = "0x18664DA90")]
	internal static OODLGGPDEAM PNOEOOMIHPK(this IANCKMHPHEB GLKDKMADKLI)
	{
		return default(OODLGGPDEAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class MGGNPGNCGKG
{
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly Dictionary<IANCKMHPHEB, string> OEKCKJLCMHB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6652490", Offset = "0x6651690", VA = "0x186652490")]
	public static string OFMDAMJMEFH(this IANCKMHPHEB FBNKHAJKFLM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct HMEDOPFDBPJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[EBGBFBIDBLB]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[NIMLPLFPLGO(9898405628982320166uL, 2023375009558162791uL)]
public struct NMMEPJKLIPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	[ICIFNGLCBLG(1)]
	public JDFHJEOHFGL HCCLEJHCLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	[ICIFNGLCBLG(2)]
	public KJGKMMIGCMI GHJHJODNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	[ICIFNGLCBLG(3)]
	[HMFLIOHMGBD(0)]
	public bool DHMNNPNBIKA;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly DDKHFNGLFEP<NMMEPJKLIPI> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct HLLLCALHKHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public Entity HBLLKAEGLIB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static HLLLCALHKHI OMHOCPNBHHH(Entity BLNICJMKCEF)
	{
		return default(HLLLCALHKHI);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[AFGAEKNHDDJ]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[IEIMNMEGNHM(1)]
		public uint networkIdBits;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct AFEOBPJCPKK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public struct JNNEGLMKDKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public float3 GDAFEFPAMHC;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public static readonly DDKHFNGLFEP<JNNEGLMKDKE> NBIAOCJLGIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct BMKBJOLLNPN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[HHGLODKFBFJ("Container", 0)]
public struct BHPCOGAHMLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	[ICIFNGLCBLG(1)]
	[HMFLIOHMGBD(0)]
	public BCCEBHKEABG IBNAGLHFLOO;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly DDKHFNGLFEP<BHPCOGAHMLN> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[KOOAACGNPJE(0, 127)]
public enum BCCEBHKEABG
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class HFGNOOAKPNM
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public enum AOMAHHFGBOH
	{
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum FHLPJIDHGFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x66509E0", Offset = "0x664FBE0", VA = "0x1866509E0")]
	public static (AOMAHHFGBOH, FHLPJIDHGFD) PNCGMCLCHCF(this BCCEBHKEABG FNEMOPIFGII)
	{
		return default((AOMAHHFGBOH, FHLPJIDHGFD));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct ACLBMNIEIDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public Entity MKADPIPCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public int MLHOBKJDKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public int AAALINBAMFJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
public struct BGFGOLHGEPN : IComponentData, GBELNJMIIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	[ICIFNGLCBLG(1)]
	public Entity OJEMCPHOKBP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity EOONBAOMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0")]
	public BGFGOLHGEPN(Entity OJEMCPHOKBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static BGFGOLHGEPN OMHOCPNBHHH(Entity BLNICJMKCEF)
	{
		return default(BGFGOLHGEPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public struct LIFFAKCHIOD : ISystemStateComponentData, IComponentData, GBELNJMIIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Entity JLJDDOBIKDP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity EOONBAOMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0")]
	public LIFFAKCHIOD(Entity OJEMCPHOKBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static LIFFAKCHIOD OMHOCPNBHHH(Entity BLNICJMKCEF)
	{
		return default(LIFFAKCHIOD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct KOBDKGMOAOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[KOOAACGNPJE(1000, 8000)]
public enum IANCKMHPHEB
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class BACNFDGFAJD
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct ABHGCOBHKPA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[KOOAACGNPJE(-2, 2)]
public enum GGFNCJIIOKD
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	MAX = 2
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public struct EBMBEMLBOCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public struct DNALICBCDBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public uint BLOBIPGBILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public int IOOBMANECGN;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	public DNALICBCDBG(uint JLHMAFGGGJL, int IJAHMAMKHEH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct IMNLGLPNFGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[KOOAACGNPJE(-1, 31)]
public enum ONNAFMGNPOD
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct IAGNDPCOFDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	[ICIFNGLCBLG(1)]
	public LGOCNEHIALI INCLADNHCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public GCHandle PEJFNLJIKME;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct NMNIMNAKHFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public float4x4 CELAMPCHIFA;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly DDKHFNGLFEP<NMNIMNAKHFI> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
public struct BELHIIPNIDA : IComponentData, GBELNJMIIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[ICIFNGLCBLG(1)]
	public Entity OJEMCPHOKBP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Entity EOONBAOMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0")]
	public BELHIIPNIDA(Entity OJEMCPHOKBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static BELHIIPNIDA OMHOCPNBHHH(Entity BLNICJMKCEF)
	{
		return default(BELHIIPNIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x664C270", Offset = "0x664B470", VA = "0x18664C270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public struct AAEOEFNFMEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[HKHGONOPDJJ]
public struct GOIAGNPNCPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public Entity IBENPLAEBFE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static GOIAGNPNCPL OMHOCPNBHHH(Entity NABCGCEIEGG)
	{
		return default(GOIAGNPNCPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct FICKNDADFIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[ICIFNGLCBLG(1)]
	public BOOJLMDIFHN MLPFMHBIMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[ICIFNGLCBLG(2)]
	public GGFNCJIIOKD LGHEKIBCCKM;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct DOGJPJIDLLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[ICIFNGLCBLG(1)]
	public bool KCEMMLEMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	[ICIFNGLCBLG(2)]
	public bool GGCJBJHGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[ICIFNGLCBLG(3)]
	public float AFKEGDFEKDD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct MINHJFKAHHL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct IBJFPECGAID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct EIMFLLKDNCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[ICIFNGLCBLG(1)]
	public quaternion KGFPECIFPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[ICIFNGLCBLG(2)]
	public float3 DGDMDKFMBBA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly DDKHFNGLFEP<EIMFLLKDNCD> NBIAOCJLGIM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x15BD770", Offset = "0x15BC970", VA = "0x1815BD770")]
	public EIMFLLKDNCD(quaternion KGFPECIFPNA, float3 DGDMDKFMBBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x664C850", Offset = "0x664BA50", VA = "0x18664C850")]
	public static EIMFLLKDNCD OMHOCPNBHHH(RigidTransform JMLNOEBANEC)
	{
		return default(EIMFLLKDNCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class EMPKOEBGJNH
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[AFGAEKNHDDJ]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct CBHCPIODALL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[ICIFNGLCBLG(1)]
	public IKAFEOPNGGL NONIDCJCBEN;
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : MCOMHBDOHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6654A40", Offset = "0x6653C40", VA = "0x186654A40", Slot = "4")]
		public sealed override void DCMFIKPGBKK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class FNOOLDNHLIE : ContainerPropertyBag<GPGCNAEGLDE>
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class EGBBALMKHNJ : Property<GPGCNAEGLDE, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x664D4B0", Offset = "0x664C6B0", VA = "0x18664D4B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x664D470", Offset = "0x664C670", VA = "0x18664D470")]
		public EGBBALMKHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x221C740", Offset = "0x221B940", VA = "0x18221C740", Slot = "14")]
		public override Rigidbody GetValue(ref GPGCNAEGLDE AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x221C760", Offset = "0x221B960", VA = "0x18221C760", Slot = "15")]
		public override void SetValue(ref GPGCNAEGLDE AKLNKNCLGHB, Rigidbody NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x664D800", Offset = "0x664CA00", VA = "0x18664D800")]
	public FNOOLDNHLIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class AAOPLEBAMNK : ContainerPropertyBag<KKCBJIFOAFJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class IOHKAIKLCKP : Property<KKCBJIFOAFJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6651370", Offset = "0x6650570", VA = "0x186651370", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6651330", Offset = "0x6650530", VA = "0x186651330")]
		public IOHKAIKLCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x221C740", Offset = "0x221B940", VA = "0x18221C740", Slot = "14")]
		public override object GetValue(ref KKCBJIFOAFJ AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x221C760", Offset = "0x221B960", VA = "0x18221C760", Slot = "15")]
		public override void SetValue(ref KKCBJIFOAFJ AKLNKNCLGHB, object NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x664BE90", Offset = "0x664B090", VA = "0x18664BE90")]
	public AAOPLEBAMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal class DNIOPOJDDJM : ContainerPropertyBag<IGKIKGDPCOF>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class JPCNKDHFHMA : Property<IGKIKGDPCOF, JGABCBFOGEC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6651BB0", Offset = "0x6650DB0", VA = "0x186651BB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6651B70", Offset = "0x6650D70", VA = "0x186651B70")]
		public JPCNKDHFHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x221C740", Offset = "0x221B940", VA = "0x18221C740", Slot = "14")]
		public override JGABCBFOGEC GetValue(ref IGKIKGDPCOF AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x221C760", Offset = "0x221B960", VA = "0x18221C760", Slot = "15")]
		public override void SetValue(ref IGKIKGDPCOF AKLNKNCLGHB, JGABCBFOGEC NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x664D230", Offset = "0x664C430", VA = "0x18664D230")]
	public DNIOPOJDDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class DNCIGNCIFOA : ContainerPropertyBag<DGAEMMILCEL>
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class JAANGAFFGLD : Property<DGAEMMILCEL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x66514A0", Offset = "0x66506A0", VA = "0x1866514A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6651460", Offset = "0x6650660", VA = "0x186651460")]
		public JAANGAFFGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x221C740", Offset = "0x221B940", VA = "0x18221C740", Slot = "14")]
		public override object GetValue(ref DGAEMMILCEL AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x221C760", Offset = "0x221B960", VA = "0x18221C760", Slot = "15")]
		public override void SetValue(ref DGAEMMILCEL AKLNKNCLGHB, object NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x664D160", Offset = "0x664C360", VA = "0x18664D160")]
	public DNCIGNCIFOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class IAKODPMADFA : ContainerPropertyBag<KEPIKEOMDKC>
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class FJMFLFMNPMG : Property<KEPIKEOMDKC, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x664D6B0", Offset = "0x664C8B0", VA = "0x18664D6B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x664D670", Offset = "0x664C870", VA = "0x18664D670")]
		public FJMFLFMNPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x41BCF20", Offset = "0x41BC120", VA = "0x1841BCF20", Slot = "14")]
		public override int GetValue(ref KEPIKEOMDKC AKLNKNCLGHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x664D650", Offset = "0x664C850", VA = "0x18664D650", Slot = "15")]
		public override void SetValue(ref KEPIKEOMDKC AKLNKNCLGHB, int NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	private class GHAMLFKKGAE : Property<KEPIKEOMDKC, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x664DB20", Offset = "0x664CD20", VA = "0x18664DB20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x664DAE0", Offset = "0x664CCE0", VA = "0x18664DAE0")]
		public GHAMLFKKGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x41BCFB0", Offset = "0x41BC1B0", VA = "0x1841BCFB0", Slot = "14")]
		public override int GetValue(ref KEPIKEOMDKC AKLNKNCLGHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x664DAC0", Offset = "0x664CCC0", VA = "0x18664DAC0", Slot = "15")]
		public override void SetValue(ref KEPIKEOMDKC AKLNKNCLGHB, int NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class JDAKANDMGAM : Property<KEPIKEOMDKC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x66515F0", Offset = "0x66507F0", VA = "0x1866515F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66515B0", Offset = "0x66507B0", VA = "0x1866515B0")]
		public JDAKANDMGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6651560", Offset = "0x6650760", VA = "0x186651560", Slot = "14")]
		public override GameObject GetValue(ref KEPIKEOMDKC AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6651580", Offset = "0x6650780", VA = "0x186651580", Slot = "15")]
		public override void SetValue(ref KEPIKEOMDKC AKLNKNCLGHB, GameObject NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6651010", Offset = "0x6650210", VA = "0x186651010")]
	public IAKODPMADFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class CNJOKLDPBID : ContainerPropertyBag<NGLEAFCMFGB>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class HANAOIJPEFK : Property<NGLEAFCMFGB, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6650770", Offset = "0x664F970", VA = "0x186650770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6650730", Offset = "0x664F930", VA = "0x186650730")]
		public HANAOIJPEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x66506E0", Offset = "0x664F8E0", VA = "0x1866506E0", Slot = "14")]
		public override SerializableGuid GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6650710", Offset = "0x664F910", VA = "0x186650710", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, SerializableGuid NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class HBMALLKMIHD : Property<NGLEAFCMFGB, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6650830", Offset = "0x664FA30", VA = "0x186650830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x66507F0", Offset = "0x664F9F0", VA = "0x1866507F0")]
		public HBMALLKMIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x66507A0", Offset = "0x664F9A0", VA = "0x1866507A0", Slot = "14")]
		public override List<int> GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x66507C0", Offset = "0x664F9C0", VA = "0x1866507C0", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, List<int> NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class IPAJOPILGNJ : Property<NGLEAFCMFGB, List<NGLEAFCMFGB.BPICIBBHDNJ>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6651430", Offset = "0x6650630", VA = "0x186651430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x66513F0", Offset = "0x66505F0", VA = "0x1866513F0")]
		public IPAJOPILGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x66513A0", Offset = "0x66505A0", VA = "0x1866513A0", Slot = "14")]
		public override List<NGLEAFCMFGB.BPICIBBHDNJ> GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x66513C0", Offset = "0x66505C0", VA = "0x1866513C0", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, List<NGLEAFCMFGB.BPICIBBHDNJ> NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class GLFHGJJNIFC : Property<NGLEAFCMFGB, List<NGLEAFCMFGB.ELDLDCMMHMM>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x664DDA0", Offset = "0x664CFA0", VA = "0x18664DDA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x664DD60", Offset = "0x664CF60", VA = "0x18664DD60")]
		public GLFHGJJNIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x664DD10", Offset = "0x664CF10", VA = "0x18664DD10", Slot = "14")]
		public override List<NGLEAFCMFGB.ELDLDCMMHMM> GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x664DD30", Offset = "0x664CF30", VA = "0x18664DD30", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, List<NGLEAFCMFGB.ELDLDCMMHMM> NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class NPMNBJKGJHP : Property<NGLEAFCMFGB, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6653620", Offset = "0x6652820", VA = "0x186653620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x66535E0", Offset = "0x66527E0", VA = "0x1866535E0")]
		public NPMNBJKGJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6653590", Offset = "0x6652790", VA = "0x186653590", Slot = "14")]
		public override GameObject GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x66535B0", Offset = "0x66527B0", VA = "0x1866535B0", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, GameObject NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class LCIFBEGJIEK : Property<NGLEAFCMFGB, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x6651FE0", Offset = "0x66511E0", VA = "0x186651FE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6651FA0", Offset = "0x66511A0", VA = "0x186651FA0")]
		public LCIFBEGJIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6651F50", Offset = "0x6651150", VA = "0x186651F50", Slot = "14")]
		public override Light GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6651F70", Offset = "0x6651170", VA = "0x186651F70", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, Light NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class PDEJJPOENPI : Property<NGLEAFCMFGB, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6653990", Offset = "0x6652B90", VA = "0x186653990", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6653950", Offset = "0x6652B50", VA = "0x186653950")]
		public PDEJJPOENPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6653900", Offset = "0x6652B00", VA = "0x186653900", Slot = "14")]
		public override Collider GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6653920", Offset = "0x6652B20", VA = "0x186653920", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, Collider NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class IILFBEBKPAG : Property<NGLEAFCMFGB, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x66512A0", Offset = "0x66504A0", VA = "0x1866512A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6651260", Offset = "0x6650460", VA = "0x186651260")]
		public IILFBEBKPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6651210", Offset = "0x6650410", VA = "0x186651210", Slot = "14")]
		public override string GetValue(ref NGLEAFCMFGB AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6651230", Offset = "0x6650430", VA = "0x186651230", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB AKLNKNCLGHB, string NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x664CA60", Offset = "0x664BC60", VA = "0x18664CA60")]
	public CNJOKLDPBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal class BJADHNKHBCN : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class PPALLNJMNLH : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6653AB0", Offset = "0x6652CB0", VA = "0x186653AB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x66539C0", Offset = "0x6652BC0", VA = "0x1866539C0")]
		public PPALLNJMNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1A4FDA0", Offset = "0x1A4EFA0", VA = "0x181A4FDA0", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid AKLNKNCLGHB)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x63521A0", Offset = "0x63513A0", VA = "0x1863521A0", Slot = "15")]
		public override void SetValue(ref SerializableGuid AKLNKNCLGHB, Data128 NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x664C2D0", Offset = "0x664B4D0", VA = "0x18664C2D0")]
	public BJADHNKHBCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal class JOPPFPEFPMM : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class MDOHJDCGBLK : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6652460", Offset = "0x6651660", VA = "0x186652460", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6652370", Offset = "0x6651570", VA = "0x186652370")]
		public MDOHJDCGBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140", Slot = "14")]
		public override int GetValue(ref Data128 AKLNKNCLGHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C2ED10", Offset = "0x3C2DF10", VA = "0x183C2ED10", Slot = "15")]
		public override void SetValue(ref Data128 AKLNKNCLGHB, int NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class CCCJEBOAFFE : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x664C5B0", Offset = "0x664B7B0", VA = "0x18664C5B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x664C4C0", Offset = "0x664B6C0", VA = "0x18664C4C0")]
		public CCCJEBOAFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x63544D0", Offset = "0x63536D0", VA = "0x1863544D0", Slot = "14")]
		public override int GetValue(ref Data128 AKLNKNCLGHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x41CF060", Offset = "0x41CE260", VA = "0x1841CF060", Slot = "15")]
		public override void SetValue(ref Data128 AKLNKNCLGHB, int NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class FKAOILODPFN : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x664D7D0", Offset = "0x664C9D0", VA = "0x18664D7D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x664D6E0", Offset = "0x664C8E0", VA = "0x18664D6E0")]
		public FKAOILODPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xC01BF0", Offset = "0xC00DF0", VA = "0x180C01BF0", Slot = "14")]
		public override int GetValue(ref Data128 AKLNKNCLGHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x635AAC0", Offset = "0x6359CC0", VA = "0x18635AAC0", Slot = "15")]
		public override void SetValue(ref Data128 AKLNKNCLGHB, int NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class CKMHBHPKBFC : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x664CA30", Offset = "0x664BC30", VA = "0x18664CA30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x664C940", Offset = "0x664BB40", VA = "0x18664C940")]
		public CKMHBHPKBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x635A950", Offset = "0x6359B50", VA = "0x18635A950", Slot = "14")]
		public override int GetValue(ref Data128 AKLNKNCLGHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x635A960", Offset = "0x6359B60", VA = "0x18635A960", Slot = "15")]
		public override void SetValue(ref Data128 AKLNKNCLGHB, int NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x66516F0", Offset = "0x66508F0", VA = "0x1866516F0")]
	public JOPPFPEFPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal class OLGKJAHMOPB : ContainerPropertyBag<NGLEAFCMFGB.BPICIBBHDNJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class JBMKMGIJEHL : Property<NGLEAFCMFGB.BPICIBBHDNJ, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6651530", Offset = "0x6650730", VA = "0x186651530", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x66514F0", Offset = "0x66506F0", VA = "0x1866514F0")]
		public JBMKMGIJEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x167D5C0", Offset = "0x167C7C0", VA = "0x18167D5C0", Slot = "14")]
		public override Vector3 GetValue(ref NGLEAFCMFGB.BPICIBBHDNJ AKLNKNCLGHB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x66514D0", Offset = "0x66506D0", VA = "0x1866514D0", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB.BPICIBBHDNJ AKLNKNCLGHB, Vector3 NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class GIDGCGCHBBA : Property<NGLEAFCMFGB.BPICIBBHDNJ, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x664DBB0", Offset = "0x664CDB0", VA = "0x18664DBB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x664DB70", Offset = "0x664CD70", VA = "0x18664DB70")]
		public GIDGCGCHBBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x664DB50", Offset = "0x664CD50", VA = "0x18664DB50", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref NGLEAFCMFGB.BPICIBBHDNJ AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x664DB60", Offset = "0x664CD60", VA = "0x18664DB60", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB.BPICIBBHDNJ AKLNKNCLGHB, List<SerializableGuid> NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x66536D0", Offset = "0x66528D0", VA = "0x1866536D0")]
	public OLGKJAHMOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class HCGGBCFMCAN : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class DHOABBCNBCJ : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x664D010", Offset = "0x664C210", VA = "0x18664D010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x664CFD0", Offset = "0x664C1D0", VA = "0x18664CFD0")]
		public DHOABBCNBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x664CFB0", Offset = "0x664C1B0", VA = "0x18664CFB0", Slot = "14")]
		public override float GetValue(ref Vector3 AKLNKNCLGHB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x664CFC0", Offset = "0x664C1C0", VA = "0x18664CFC0", Slot = "15")]
		public override void SetValue(ref Vector3 AKLNKNCLGHB, float NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class PPIDMKBPPLC : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6653B40", Offset = "0x6652D40", VA = "0x186653B40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6653B00", Offset = "0x6652D00", VA = "0x186653B00")]
		public PPIDMKBPPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6653AE0", Offset = "0x6652CE0", VA = "0x186653AE0", Slot = "14")]
		public override float GetValue(ref Vector3 AKLNKNCLGHB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6653AF0", Offset = "0x6652CF0", VA = "0x186653AF0", Slot = "15")]
		public override void SetValue(ref Vector3 AKLNKNCLGHB, float NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class GAMJJEPGBHB : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x664D990", Offset = "0x664CB90", VA = "0x18664D990", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x664D950", Offset = "0x664CB50", VA = "0x18664D950")]
		public GAMJJEPGBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x16FEBC0", Offset = "0x16FDDC0", VA = "0x1816FEBC0", Slot = "14")]
		public override float GetValue(ref Vector3 AKLNKNCLGHB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x664D940", Offset = "0x664CB40", VA = "0x18664D940", Slot = "15")]
		public override void SetValue(ref Vector3 AKLNKNCLGHB, float NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6650860", Offset = "0x664FA60", VA = "0x186650860")]
	public HCGGBCFMCAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class ANJOIKBGALC : ContainerPropertyBag<NGLEAFCMFGB.ELDLDCMMHMM>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class EAHINIAGKKA : Property<NGLEAFCMFGB.ELDLDCMMHMM, NGLEAFCMFGB.BPICIBBHDNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x664D380", Offset = "0x664C580", VA = "0x18664D380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x664D340", Offset = "0x664C540", VA = "0x18664D340")]
		public EAHINIAGKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6351000", Offset = "0x6350200", VA = "0x186351000", Slot = "14")]
		public override NGLEAFCMFGB.BPICIBBHDNJ GetValue(ref NGLEAFCMFGB.ELDLDCMMHMM AKLNKNCLGHB)
		{
			return default(NGLEAFCMFGB.BPICIBBHDNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x664D300", Offset = "0x664C500", VA = "0x18664D300", Slot = "15")]
		public override void SetValue(ref NGLEAFCMFGB.ELDLDCMMHMM AKLNKNCLGHB, NGLEAFCMFGB.BPICIBBHDNJ NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x664C050", Offset = "0x664B250", VA = "0x18664C050")]
	public ANJOIKBGALC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class GKAHJFNNJAG : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class AEKPFJGLMBL : Property<RRObjectPrefabV2Data, IANCKMHPHEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x664BFA0", Offset = "0x664B1A0", VA = "0x18664BFA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x664BF60", Offset = "0x664B160", VA = "0x18664BF60")]
		public AEKPFJGLMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140", Slot = "14")]
		public override IANCKMHPHEB GetValue(ref RRObjectPrefabV2Data AKLNKNCLGHB)
		{
			return default(IANCKMHPHEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3C2ED10", Offset = "0x3C2DF10", VA = "0x183C2ED10", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data AKLNKNCLGHB, IANCKMHPHEB NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x664DC40", Offset = "0x664CE40", VA = "0x18664DC40")]
	public GKAHJFNNJAG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6653B70", Offset = "0x6652D70", VA = "0x186653B70")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class MDBJHPDEIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MDBJHPDEIOP()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public class AuthoredParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public class AuthoredPreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public class AuthoredChildrenData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public class ParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public class PreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public class ChildrenData
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
