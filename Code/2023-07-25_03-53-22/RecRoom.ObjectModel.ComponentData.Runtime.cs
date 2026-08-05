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
public static class CHELKDHEPKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly List<(BIJCDGEHGBM nameHash, LAOLEEKHBHH stableTypeHash, Type type)> PIPIHFOILCG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly List<(BIJCDGEHGBM nameHash, LAOLEEKHBHH stableTypeHash, Type type)> MFILDMLDEDO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly List<(BIJCDGEHGBM previousNameHash, LAOLEEKHBHH previousStableTypeHash, Type currentTypeName)> JHADLKEOIAC;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ONFGFHMICFL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Rigidbody CIEJBNMPJKE;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DC90", Offset = "0x6B0CC90", VA = "0x186B0DC90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public ONFGFHMICFL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HABJAIHKGGF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AFIFHFCGCBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public FLACBGLBMKA ACKBLPKDHMI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MNOCEEEAKLD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IFKBLPFKICB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public object ANOPLGMPPOM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BDD0", Offset = "0x6B0ADD0", VA = "0x186B0BDD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public IFKBLPFKICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct BEIICDEBGOD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity IGJGLIJGINK;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MDPOLJAKODE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LAOKCKEIHIM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly IHABNEGJAPJ<MDPOLJAKODE> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GDBPMKEIFCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float3 KDJJKMHAODG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GNLHMBCJCPE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KEDINEBOMHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHDEJNEOEEL(POLDHLFEBIN GMDACNKJDGE, POLDHLFEBIN NAMHKAOMNNK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELJGHOKOJKB();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMHCFHCLCNP();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADKDLIBNMCE(bool FGLGAHABBBB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DCNNJMCONGG();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOJNAFIKPMO();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CHOGNKENJKB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HDKPCFOHABL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int LJFFGMJKBEO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x16A7940", Offset = "0x16A6940", VA = "0x1816A7940")]
	public static HDKPCFOHABL MGOLCJODLKK(int CKDFGEALFAK)
	{
		return default(HDKPCFOHABL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum FLACBGLBMKA
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum FMOMJHKLCHF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GDJMHNOIEDL : CBGKOLHPOGA, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IEEGMNGDKEC DPGCFNIHEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IEEGMNGDKEC);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FELFKLKEPIL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public KEDINEBOMHC KHEOPIHHDKM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B2C0", Offset = "0x6B0A2C0", VA = "0x186B0B2C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public FELFKLKEPIL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NFDAGKJFHDG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BIFJPEIJAGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3x3 PFLPIMMPEGK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly IHABNEGJAPJ<BIFJPEIJAGF> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NKKCLFAIPDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float MLCINDOKLHO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly IHABNEGJAPJ<NKKCLFAIPDF> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FMEELNNGLGD]
public struct GLCEACAEJDG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Entity NNCCHIHKALO;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OKAFPCPMNEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float FFCIDGEJFPO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly IHABNEGJAPJ<OKAFPCPMNEI> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CACNCMEDIEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 MKCFHCKHINH;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NFBNNGFJMCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Entity EMIPEAKIENF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct ACMIGPLJGAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum POLDHLFEBIN
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
public struct BHCIJIJMMFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3x3 PFLPIMMPEGK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IHABNEGJAPJ<BIFJPEIJAGF> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PJHLMLENFCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity DJAGPEDCGHG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct CACCMOCPCGO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AJAKGOGLGME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public FLACBGLBMKA IGIHKMNBGLB;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CFAHNAHHJBL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public RigidbodyConstraints KNBENOGDALJ;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct PHIPIFLCHHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float OEJMKKOIAEJ;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IHABNEGJAPJ<PHIPIFLCHHL> JCGFDJGGMMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JEBOJGPCAGE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GIFBIJAJAMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public POLDHLFEBIN NMEGDIDDLFL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IHABNEGJAPJ<GIFBIJAJAMM> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct CAMGHABKNFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public CollisionDetectionMode OGCJCPNOCIC;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PIKJOOMBOOK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public object CIPAHNOFBOF;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E040", Offset = "0x6B0D040", VA = "0x186B0E040", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public PIKJOOMBOOK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OLDDBCNIMPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct EEKLJKJNMHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ANGEMACFMPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float3 NIIFGFIFLDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MPJCGJPIMCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float DFGAJEGDAEA;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DAOAJPFCPGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 CCMGHKCLEIF;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[InternalBufferCapacity(8)]
public struct INGOFBMBMKJ : ISystemStateBufferElementData, IBufferElementData, IEquatable<INGOFBMBMKJ>, LBKJFBOMFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity IGJGLIJGINK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity NEEMKBMENHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70")]
	public INGOFBMBMKJ(Entity IGJGLIJGINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BE60", Offset = "0x6B0AE60", VA = "0x186B0BE60", Slot = "4")]
	public bool Equals(INGOFBMBMKJ BKLMLPFOMCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static INGOFBMBMKJ MGOLCJODLKK(Entity NNCCHIHKALO)
	{
		return default(INGOFBMBMKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct KLCMLHJDLPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ANMCIPAPMCD(1)]
	public Entity FBOMMBLFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ANMCIPAPMCD(2)]
	public bool CGACKOONCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ANMCIPAPMCD(3)]
	public float FGLILDFDMEM;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[JEOHGNDCLBJ(1)]
public struct AIMPNEMJPJO : ELNEJMMFHHF, IEquatable<AIMPNEMJPJO>
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly AIMPNEMJPJO JJICOGFFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[CLHNKKOMENE(1)]
	public int IACOMDKJFAL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20")]
	public AIMPNEMJPJO(int IACOMDKJFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B07610", Offset = "0x6B06610", VA = "0x186B07610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B07580", Offset = "0x6B06580", VA = "0x186B07580", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F235E0", Offset = "0x3F225E0", VA = "0x183F235E0", Slot = "6")]
	public bool Equals(AIMPNEMJPJO BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B07690", Offset = "0x6B06690", VA = "0x186B07690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B07560", Offset = "0x6B06560", VA = "0x186B07560", Slot = "5")]
	public void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B07680", Offset = "0x6B06680", VA = "0x186B07680", Slot = "4")]
	public void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct PHMIJGMENMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ANMCIPAPMCD(1)]
	public float CDHAPBHGNKC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly IHABNEGJAPJ<PHMIJGMENMN> JCGFDJGGMMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal struct JKINKMMIHKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal struct GIOLPKLCBPF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Entity NNCCHIHKALO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static GIOLPKLCBPF MGOLCJODLKK(Entity NNCCHIHKALO)
	{
		return default(GIOLPKLCBPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[LPANCLNLNHL]
[IACLKPCAHEF("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct NJIPEPBMELE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(1)]
	public DPJFBCAIHMI BCEPALIFALD;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Flags]
[GOBDJIHHDIN(0, 15943)]
public enum DPJFBCAIHMI
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
public struct IEDBNKCLFIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct IHINJAHNCPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OMCPIEKODEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LOKECOCFNNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JDFIFJAMPIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LHLEPDGIDBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct AJGLKNEGOPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct AENOOPGMBFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct OPMADBJNEHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct KCCFLGGCNPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CLHNKKOMENE(1)]
	public LFGHLCOAGAD ELKCHAMAHHH;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly IHABNEGJAPJ<KCCFLGGCNPD> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum LFGHLCOAGAD : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct DBBOGBIMJNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ANMCIPAPMCD(1)]
	public float3 MAJOLFDNMEO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly IHABNEGJAPJ<DBBOGBIMJNJ> JCGFDJGGMMP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x12EC200", Offset = "0x12EB200", VA = "0x1812EC200")]
	public static DBBOGBIMJNJ MGOLCJODLKK(float3 CKDFGEALFAK)
	{
		return default(DBBOGBIMJNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[PIMLDNKPGPE]
[HPHFBFCABBG(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct LLCCMMPKCBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int NBICOFBGBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ANMCIPAPMCD(2)]
	public bool KOHHFOBFJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ANMCIPAPMCD(3)]
	public bool DMHNFLDFIGD;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly IHABNEGJAPJ<LLCCMMPKCBN> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct OEALHPODBJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float KJPOCAPJMPP;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly IHABNEGJAPJ<OEALHPODBJA> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct IODNKKEODNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[ANMCIPAPMCD(1)]
	public SerializableGuid LILJFFJEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ANMCIPAPMCD(2)]
	public SerializableGuid CIPOMGPCAOA;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[LPANCLNLNHL]
[IACLKPCAHEF("Container", 0)]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
public struct DIKNAIAHGMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(1)]
	public JJJDPOHJEHD IFGELIONDFJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IHABNEGJAPJ<DIKNAIAHGMN> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[GOBDJIHHDIN(0, 2)]
public enum JJJDPOHJEHD
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
internal enum IJJKPELBGLO
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
internal static class OMMADIEJBKN
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct ICAFGFHIMGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct GAAACNAGCNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ANMCIPAPMCD(1)]
	public bool HCEFOMOBPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ANMCIPAPMCD(2)]
	public bool CGACKOONCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ANMCIPAPMCD(3)]
	public float JNFEJCONLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ANMCIPAPMCD(4)]
	public float LMBLJACJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ANMCIPAPMCD(5)]
	public float KHIOAKAGFFK;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[JEOHGNDCLBJ(1)]
public struct JONKBLJBIMD : ELNEJMMFHHF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Flags]
	[GOBDJIHHDIN(0, 7)]
	public enum GPFCHGOGPLO
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
	[CLHNKKOMENE(1)]
	public float CKADKONBGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[CLHNKKOMENE(2)]
	public int NPBFLKNBBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[CLHNKKOMENE(3)]
	public GPFCHGOGPLO BCEPALIFALD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AOGPGDLNEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C470", Offset = "0x6B0B470", VA = "0x186B0C470")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C280", Offset = "0x6B0B280", VA = "0x186B0C280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JIDABPDGLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C3F0", Offset = "0x6B0B3F0", VA = "0x186B0C3F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C4F0", Offset = "0x6B0B4F0", VA = "0x186B0C4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HENJCDHKMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C310", Offset = "0x6B0B310", VA = "0x186B0C310")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C2F0", Offset = "0x6B0B2F0", VA = "0x186B0C2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C2A0", Offset = "0x6B0B2A0", VA = "0x186B0C2A0", Slot = "5")]
	public void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C390", Offset = "0x6B0B390", VA = "0x186B0C390", Slot = "4")]
	public void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal struct KNBDJDIEHGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct PDDHAJFDPIC : ISystemStateComponentData, IComponentData, LBKJFBOMFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity PPFEAACADMH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity NEEMKBMENHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct KLEJIOCHKPE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct MLHBFDACEDL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct PIHIGBKEAHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float4x4 AILLLHEHPOK;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly IHABNEGJAPJ<PIHIGBKEAHG> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct HCHDOINLDIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ANMCIPAPMCD(1)]
	public INBBACCKPLH HNPBDIJJBAM;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct KAGIPCJHPEK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Flags]
	[GOBDJIHHDIN(0, 7)]
	public enum OGKPIGAAIFB
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
	[ANMCIPAPMCD(1)]
	public OGKPIGAAIFB BCEPALIFALD;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly IHABNEGJAPJ<KAGIPCJHPEK> JCGFDJGGMMP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KLDDPGCOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C570", Offset = "0x6B0B570", VA = "0x186B0C570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KCNEGGLKPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C5F0", Offset = "0x6B0B5F0", VA = "0x186B0C5F0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct LLICLBDEFCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ANMCIPAPMCD(1)]
	public float CDHAPBHGNKC;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly IHABNEGJAPJ<LLICLBDEFCM> JCGFDJGGMMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct ICMCMEOBOJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct FBOHJNEILAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ANMCIPAPMCD(1)]
	public GDAKNOMINHC OCJOPJBPNNM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct LNFDFPDEELJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct LMHICJPFAEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ANMCIPAPMCD(1)]
	public Entity HECCPMEMKKM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct JELHDLGBKGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[GOBDJIHHDIN(0, 9)]
public enum HCLMPDLDNOB
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
public static class NNJNPJMMHIK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D890", Offset = "0x6B0C890", VA = "0x186B0D890")]
	public static bool LIMBHNLEACJ(this HCLMPDLDNOB MOCKEJPKCNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[GOBDJIHHDIN(-1, 38)]
public enum LAHOJAAPJMH
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
[PIMLDNKPGPE]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[HPHFBFCABBG(15725208981563603541uL, 17017036095303668770uL)]
public struct LLLDKCJELKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ANMCIPAPMCD(1)]
	public ELIGIOKOANN LNODCOPPJNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct NNOILJBDDMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct LGECLKAEOJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[GOBDJIHHDIN(0, 2)]
public enum FMAGCHDBGLG
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
[GOBDJIHHDIN(0, 1)]
public enum GDAKNOMINHC
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
internal struct MCMNGKGCLCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HADIIDDGCNH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct FFAIHODBPDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ANMCIPAPMCD(1)]
	public EFOFPEOLGLH PPIJPBOJHCI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static FFAIHODBPDH MGOLCJODLKK(EFOFPEOLGLH CKDFGEALFAK)
	{
		return default(FFAIHODBPDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[IACLKPCAHEF("Container", 0)]
public struct CNAGDAJGBJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(1)]
	public FixedString64Bytes OALFIBFPPAC;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class PAEBMOKKEEK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DD10", Offset = "0x6B0CD10", VA = "0x186B0DD10")]
	public static void DGLJBNFHKAF(this ref CAGKAKBHMGC BCEPALIFALD, DNHKKKPKOHF IJEOPICCBBB, bool LJGOKJPEPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DD60", Offset = "0x6B0CD60", VA = "0x186B0DD60")]
	public static bool OPABGKGLOID(this CAGKAKBHMGC BCEPALIFALD, DNHKKKPKOHF IJEOPICCBBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DD00", Offset = "0x6B0CD00", VA = "0x186B0DD00")]
	public static CAGKAKBHMGC BBNAHDLMHNA(this DNHKKKPKOHF IJEOPICCBBB)
	{
		return default(CAGKAKBHMGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DD40", Offset = "0x6B0CD40", VA = "0x186B0DD40")]
	public static void DGLJBNFHKAF(this ref LBBFKIAKIDM BCEPALIFALD, LBBFKIAKIDM PMEFJLJOGPP, bool LJGOKJPEPHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum DNHKKKPKOHF
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
[GOBDJIHHDIN(0, 16383)]
public enum CAGKAKBHMGC
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
[GOBDJIHHDIN(0, 3)]
public enum LBBFKIAKIDM
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
[PIMLDNKPGPE]
[HPHFBFCABBG(17667479821163689808uL, 11946378475791123970uL)]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
public struct ECJIOHGBEEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JBEKJCAFHOE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[PIMLDNKPGPE]
[HPHFBFCABBG(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
public struct CPNOHKELKAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public HCLMPDLDNOB MOCKEJPKCNM;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[GOBDJIHHDIN(int.MinValue, int.MaxValue)]
public enum PKFAMLPGILK
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
[LPANCLNLNHL]
[IACLKPCAHEF("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct PDOKNFDOIHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ANMCIPAPMCD(1)]
	[OIGFGDIHFEE(0)]
	public bool DDHDBPLDGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(2)]
	public float BCHIFCNECPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(3)]
	public float EICFKDEBBKD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct GEIKDMIELME : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[IACLKPCAHEF("Container", 0)]
public struct OIFPEPFJKIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(1)]
	public float LJJHDOLPJOB;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct GAOLJCEMJHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private NativeList<LMKDLILIDPD> LJPHCDAMGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private NativeList<Entity> EHNJCNEILJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private JobHandle AAPDDMNNEHG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PHDAMLHGKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B5D0", Offset = "0x6B0A5D0", VA = "0x186B0B5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B520", Offset = "0x6B0A520", VA = "0x186B0B520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D651D0", Offset = "0x2D641D0", VA = "0x182D651D0")]
	public GAOLJCEMJHJ(NativeList<LMKDLILIDPD> LJPHCDAMGCJ, NativeList<Entity> EHNJCNEILJH, JobHandle AAPDDMNNEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B640", Offset = "0x6B0A640", VA = "0x186B0B640")]
	public (Entity, NativeSlice<Entity>) PMPPANJODOE(int KJPGMJFNNHE)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B570", Offset = "0x6B0A570", VA = "0x186B0B570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MOJBMMFGFPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public float3 NKMKMKDMOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public quaternion NMKLOHCPMNL;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static readonly IHABNEGJAPJ<MOJBMMFGFPJ> JCGFDJGGMMP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D1B0", Offset = "0x6B0C1B0", VA = "0x186B0D1B0")]
	public float3 JLCNILJMBBB(float3 HNEGIGNBMJE)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class DNFBABHDBHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[PIMLDNKPGPE]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[HPHFBFCABBG(218523523639012570uL, 15191719635551116065uL)]
public struct JLHDPJMFABM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private uint PEBHEOBMAPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct AHELBEDFLDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[IACLKPCAHEF("Light", 0)]
public struct FCAEOKMBKNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[ANMCIPAPMCD(1)]
	[OIGFGDIHFEE(0)]
	public float DICKECOBNAD;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct JNJKFCCHODF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[ANMCIPAPMCD(1)]
	public quaternion IHOLFEDLPLF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static readonly IHABNEGJAPJ<JNJKFCCHODF> JCGFDJGGMMP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
	public static JNJKFCCHODF MGOLCJODLKK(quaternion CKDFGEALFAK)
	{
		return default(JNJKFCCHODF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct FNGNLAOBFHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[ANMCIPAPMCD(1)]
	public Entity FBOMMBLFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ANMCIPAPMCD(2)]
	public bool NPEDOHPDNHM;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JEEKGIOJMIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public FixedString32Bytes OALFIBFPPAC;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[PIMLDNKPGPE]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[HPHFBFCABBG(4470189027631723570uL, 5922380073816386711uL)]
public struct HNKEJLJJMHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[CLHNKKOMENE(1)]
	public CAGKAKBHMGC BCEPALIFALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ANMCIPAPMCD(2)]
	public BFIKHONDEDE OMEOCNINMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(3)]
	public LBBFKIAKIDM CPIFPCMFPLD;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static readonly IHABNEGJAPJ<HNKEJLJJMHA> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct HLJJICOAPLO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Entity NPMKOEDLJJH;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[Flags]
[GOBDJIHHDIN(0, 1)]
public enum GFGONIAKGED
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
public struct MFGKPCMENNA : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[JEOHGNDCLBJ(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[CLHNKKOMENE(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[CLHNKKOMENE(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[CLHNKKOMENE(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[CLHNKKOMENE(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[JEOHGNDCLBJ(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, ELNEJMMFHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[CLHNKKOMENE(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		public static SerializableGuid MGOLCJODLKK(Guid PLBICILNGEB)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EFA0", Offset = "0x6B0DFA0", VA = "0x186B0EFA0", Slot = "4")]
		public bool Equals(SerializableGuid BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EF00", Offset = "0x6B0DF00", VA = "0x186B0EF00", Slot = "5")]
		public int CompareTo(SerializableGuid BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F030", Offset = "0x6B0E030", VA = "0x186B0F030", Slot = "6")]
		public void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EF20", Offset = "0x6B0DF20", VA = "0x186B0EF20", Slot = "7")]
		public void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F120", Offset = "0x6B0E120", VA = "0x186B0F120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct GANDANNAKEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct FGBDBCHHFNM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[GOBDJIHHDIN(0, 4)]
public enum HGKCEEGEIFB
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
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct OGMBFAHBLAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[ANMCIPAPMCD(1)]
	public bool NLBGFALIIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[ANMCIPAPMCD(2)]
	public byte NAFLMGJICJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[ANMCIPAPMCD(3)]
	public short OGGIINLLFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[ANMCIPAPMCD(4)]
	public ushort IIGLJOAPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[ANMCIPAPMCD(5)]
	public int DOMLPCIMFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[ANMCIPAPMCD(6)]
	public uint PMKEGNOBKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[ANMCIPAPMCD(7)]
	public long OKBDLAKJBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[ANMCIPAPMCD(8)]
	public ulong HGFGLPCACIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ANMCIPAPMCD(9)]
	public float ODHLBILLONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ANMCIPAPMCD(10)]
	public double HADIFHCKPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[ANMCIPAPMCD(11)]
	public LEHIJKABEEB MBJPADHKPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[ANMCIPAPMCD(12)]
	public GBKDALJAPOL JAMBDIHGNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[ANMCIPAPMCD(13)]
	public NLFFFJCALND CINCHKFFCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ANMCIPAPMCD(14)]
	public BCNHKBKIEOJ EIBKLCONINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ANMCIPAPMCD(15)]
	public FGKABDLHMLM JCPGKIPGGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ANMCIPAPMCD(16)]
	public HMKFCEJODMI IGHPNJOJCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ANMCIPAPMCD(17)]
	public ADJJPPNMFCA GOCFFFAJIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[ANMCIPAPMCD(18)]
	public CEMFAOCPCDO AAEJHPIAIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ANMCIPAPMCD(20)]
	public Quaternion EJJMPCIBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ANMCIPAPMCD(22)]
	public Vector3 IPKJAEAAFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ANMCIPAPMCD(23)]
	public Vector4 KCAKKOOLIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ANMCIPAPMCD(40)]
	public Entity PKBAIIMCMOD;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public enum LEHIJKABEEB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum GBKDALJAPOL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum NLFFFJCALND : short
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum BCNHKBKIEOJ : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum FGKABDLHMLM
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum HMKFCEJODMI : uint
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum ADJJPPNMFCA : long
{
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum CEMFAOCPCDO : ulong
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
	[LPANCLNLNHL]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[LPANCLNLNHL]
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
public class BFFAGKPONKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public int PDFBAGGMCIA;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public int JICEBGHHFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public GameObject LAPEIFCGFLM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public BFFAGKPONKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class BELFKMGIKEJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct JKBKLGGHCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Vector3 AGOKNMHLHBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public List<SerializableGuid> LEIPKKJDCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class HLPDCOKGKPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public JKBKLGGHCFO JLKBPAIENGJ;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HLPDCOKGKPF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public SerializableGuid JFEIBCKHJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public List<int> MIOBMCNBMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public List<JKBKLGGHCFO> FLAOAHCJFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public List<HLPDCOKGKPF> OONOFCFMNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public GameObject LAPEIFCGFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Light HBKOFDAABEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Collider NLCHDIPHMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public string EAHOBIHOAGO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public BELFKMGIKEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[PIMLDNKPGPE]
[IACLKPCAHEF("Container", 0)]
[HPHFBFCABBG(2613756846563002039uL, 6372660366488563574uL)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct OCFCGHMFPFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(1)]
	public EMKHNIDBEJG FBHALLAMPPP;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[Flags]
[GOBDJIHHDIN(0, 15)]
public enum EMKHNIDBEJG
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
[PIMLDNKPGPE]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[HPHFBFCABBG(9804513251708000208uL, 10903582988135044631uL)]
public struct OMBOMCEPEGL : IComponentData, IEquatable<OMBOMCEPEGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ANMCIPAPMCD(1)]
	public FixedString64Bytes OALFIBFPPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[ANMCIPAPMCD(2)]
	public JJJDPOHJEHD IFGELIONDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[ANMCIPAPMCD(3)]
	public EMKHNIDBEJG FBHALLAMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[ANMCIPAPMCD(4)]
	public FLODMOMFKPJ CFHBLGMAOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	[ANMCIPAPMCD(5)]
	public DPJFBCAIHMI BCEPALIFALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	[ANMCIPAPMCD(6)]
	public float LJJHDOLPJOB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DBB0", Offset = "0x6B0CBB0", VA = "0x186B0DBB0", Slot = "4")]
	public bool Equals(OMBOMCEPEGL BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct IMCOFEBDDKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	[ANMCIPAPMCD(1)]
	public JONKBLJBIMD BPFIFAEKGCN;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct BBMEFLKGJHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	[ANMCIPAPMCD(1)]
	public float3 KOFDECELOKC;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly IHABNEGJAPJ<BBMEFLKGJHL> JCGFDJGGMMP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x12EC200", Offset = "0x12EB200", VA = "0x1812EC200")]
	public static BBMEFLKGJHL MGOLCJODLKK(float3 CKDFGEALFAK)
	{
		return default(BBMEFLKGJHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct LHHEHMHHDHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Entity NPMKOEDLJJH;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[InternalBufferCapacity(8)]
public struct MJFNJHGDFBJ : ISystemStateBufferElementData, IBufferElementData, IEquatable<MJFNJHGDFBJ>, LBKJFBOMFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public Entity IGJGLIJGINK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity NEEMKBMENHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BE60", Offset = "0x6B0AE60", VA = "0x186B0BE60", Slot = "4")]
	public bool Equals(MJFNJHGDFBJ BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal struct MLBPAMJLNHP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public Entity HECCPMEMKKM;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[GOBDJIHHDIN(0, 4)]
public enum INBBACCKPLH
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
[Cpp2IlInjected.Token(Token = "0x2000099")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct NKDCNBGJMFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	[ANMCIPAPMCD(1)]
	public quaternion IHOLFEDLPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	[ANMCIPAPMCD(2)]
	public float3 KOFDECELOKC;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly IHABNEGJAPJ<NKDCNBGJMFJ> JCGFDJGGMMP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x12EBFA0", Offset = "0x12EAFA0", VA = "0x1812EBFA0")]
	public NKDCNBGJMFJ(quaternion IHOLFEDLPLF, float3 KOFDECELOKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B7F0", Offset = "0x6B0A7F0", VA = "0x186B0B7F0")]
	public static RigidTransform MGOLCJODLKK(NKDCNBGJMFJ DNAOCGILBKJ)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B7F0", Offset = "0x6B0A7F0", VA = "0x186B0B7F0")]
	public static NKDCNBGJMFJ MGOLCJODLKK(RigidTransform EAODIPHLAKJ)
	{
		return default(NKDCNBGJMFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class GKOOGPHHKCB
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface LBKJFBOMFGN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity OCCBCCENGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[PIMLDNKPGPE]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[HPHFBFCABBG(9807788745867066359uL, 15168486114979071194uL)]
public struct NLGNGMOEGOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	[ANMCIPAPMCD(1)]
	public CAGKAKBHMGC BCEPALIFALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[ANMCIPAPMCD(2)]
	public BFIKHONDEDE OMEOCNINMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(3)]
	public bool PEFPLIKNHKI;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static readonly IHABNEGJAPJ<NLGNGMOEGOL> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct DNBNHPIAJND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ANMCIPAPMCD(2)]
	public bool KOHHFOBFJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[ANMCIPAPMCD(3)]
	public bool DMHNFLDFIGD;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static readonly IHABNEGJAPJ<DNBNHPIAJND> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[LPANCLNLNHL]
[TypeManager.TypeVersion(2)]
[IACLKPCAHEF("Object", 0)]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct DODEDAPNIOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[ANMCIPAPMCD(2)]
	public BFIKHONDEDE OMEOCNINMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(3)]
	public LBBFKIAKIDM CPIFPCMFPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[CLHNKKOMENE(4)]
	public CAGKAKBHMGC BCEPALIFALD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly IHABNEGJAPJ<DODEDAPNIOE> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct IHDOMNGJLIL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public int OFBBMOFCDFK;
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct LLDHMLONBIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public GCHandle MPHHNEPJLBD;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct IIMDKGFJEGJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private int GPKHJKKNNNC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CCELBNKPBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BE50", Offset = "0x6B0AE50", VA = "0x186B0BE50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BE40", Offset = "0x6B0AE40", VA = "0x186B0BE40")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct BCMJKJJDKNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	[ANMCIPAPMCD(1)]
	public Entity DHCMCCOLMGF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static BCMJKJJDKNL MGOLCJODLKK(Entity NNCCHIHKALO)
	{
		return default(BCMJKJJDKNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[PIMLDNKPGPE]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[HPHFBFCABBG(14327281633525910712uL, 2559857777606771911uL)]
public struct CHMBPPBEBDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	[ANMCIPAPMCD(1)]
	public ELIGIOKOANN LNODCOPPJNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct GHGPHBPFEHB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct AGFIKFGMFLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	[ANMCIPAPMCD(1)]
	public float3 OCFJOANHHLE;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly IHABNEGJAPJ<AGFIKFGMFLF> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[LPANCLNLNHL]
[IACLKPCAHEF("Container", 0)]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
public struct HAINCOFABJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(1)]
	public FLODMOMFKPJ CFHBLGMAOJM;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[GOBDJIHHDIN(0, 1)]
public enum FLODMOMFKPJ
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
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[JEOHGNDCLBJ(1)]
public struct BFIKHONDEDE : ELNEJMMFHHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[CLHNKKOMENE(1)]
	public bool DDHDBPLDGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	[CLHNKKOMENE(2)]
	public float3 IKJEPJBKGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	[CLHNKKOMENE(3)]
	public float3 CPHJHJPJMEG;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static readonly IHABNEGJAPJ<BFIKHONDEDE> JCGFDJGGMMP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B07760", Offset = "0x6B06760", VA = "0x186B07760", Slot = "5")]
	public void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B077D0", Offset = "0x6B067D0", VA = "0x186B077D0", Slot = "4")]
	public void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct DOPMJJNGDNF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	[ANMCIPAPMCD(1)]
	public LAHOJAAPJMH BIBLLCGNKAG;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct LAJLLAGNFEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public int OFBBMOFCDFK;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public interface BDNMGKIBAPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGLFEEPAFKN(bool DLKBCCKGCII);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.TypeVersion(2)]
public struct PJCAKEHMEGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public uint BFCOBBFKEDG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E0B0", Offset = "0x6B0D0B0", VA = "0x186B0E0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct HNLNNPIBJBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal struct AIHBKNLMGJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct BJFFNMODALG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[FMEELNNGLGD]
internal struct OIAKDGFBBHO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public Entity OKAGIIHCOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int CCELBNKPBGB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct PKENLPPHCKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[IACLKPCAHEF("Visual", 0)]
public struct ABGEPJIMAJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	[ANMCIPAPMCD(1)]
	[OIGFGDIHFEE(0)]
	public PKFAMLPGILK IFAEOGGHLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(2)]
	public OLLMGFCLHHL HDEIKJNIFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[ANMCIPAPMCD(3)]
	[OIGFGDIHFEE(0)]
	public float EIDPFALKPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[OIGFGDIHFEE(0)]
	[ANMCIPAPMCD(4)]
	public Vector3 PHDBCFNPFDP;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[LPANCLNLNHL]
[IACLKPCAHEF("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct JPEHOLJLCCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[ANMCIPAPMCD(1)]
	[OIGFGDIHFEE(0)]
	public float KNLCEKNJGOJ;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public static readonly IHABNEGJAPJ<JPEHOLJLCCB> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[JEOHGNDCLBJ(1)]
public struct EFOFPEOLGLH : IComparable<EFOFPEOLGLH>, IEquatable<EFOFPEOLGLH>, ELNEJMMFHHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[CLHNKKOMENE(1)]
	public uint LIJFGPPLGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[CLHNKKOMENE(2)]
	public uint NNNGFFMINGO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint MIHJNFCOENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B0ABF0", Offset = "0x6B09BF0", VA = "0x186B0ABF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B0ACE0", Offset = "0x6B09CE0", VA = "0x186B0ACE0")]
	public EFOFPEOLGLH(int LIJFGPPLGPK, int JHEFMHFGGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B0ACE0", Offset = "0x6B09CE0", VA = "0x186B0ACE0")]
	public EFOFPEOLGLH(uint LIJFGPPLGPK, uint JHEFMHFGGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AB90", Offset = "0x6B09B90", VA = "0x186B0AB90")]
	public EFOFPEOLGLH MLANPCOLPCP(int FCCAKNLHEPE = 1)
	{
		return default(EFOFPEOLGLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A9C0", Offset = "0x6B099C0", VA = "0x186B0A9C0")]
	public EFOFPEOLGLH FHFIHHLFOMG(int FCCAKNLHEPE = 1)
	{
		return default(EFOFPEOLGLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AA70", Offset = "0x6B09A70", VA = "0x186B0AA70")]
	public static EFOFPEOLGLH HABIMGEHAIH(EFOFPEOLGLH EEDCFNGAAFO, EFOFPEOLGLH OFBPOJFNNIJ)
	{
		return default(EFOFPEOLGLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AB60", Offset = "0x6B09B60", VA = "0x186B0AB60")]
	private static uint LJELDBOGDLK(uint LFEMLKHNBHE, uint CNOAFMMFDKH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A870", Offset = "0x6B09870", VA = "0x186B0A870", Slot = "4")]
	public int CompareTo(EFOFPEOLGLH BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A920", Offset = "0x6B09920", VA = "0x186B0A920", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AC00", Offset = "0x6B09C00", VA = "0x186B0AC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A900", Offset = "0x6B09900", VA = "0x186B0A900", Slot = "5")]
	public bool Equals(EFOFPEOLGLH BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AA20", Offset = "0x6B09A20", VA = "0x186B0AA20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AAF0", Offset = "0x6B09AF0", VA = "0x186B0AAF0", Slot = "6")]
	public void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A890", Offset = "0x6B09890", VA = "0x186B0A890", Slot = "7")]
	public void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x107E940", Offset = "0x107D940", VA = "0x18107E940")]
	public static bool LFCPNLBCIDE(EFOFPEOLGLH EEDCFNGAAFO, EFOFPEOLGLH OFBPOJFNNIJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[LPANCLNLNHL]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public ELIGIOKOANN prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class IANHIKNEMKI
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BDA0", Offset = "0x6B0ADA0", VA = "0x186B0BDA0")]
	public static bool LPJFBFEKGCD(this ELIGIOKOANN DPPJBLOOGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BCD0", Offset = "0x6B0ACD0", VA = "0x186B0BCD0")]
	public static string IBJLEOHIGFN(this ELIGIOKOANN DPPJBLOOGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BD50", Offset = "0x6B0AD50", VA = "0x186B0BD50")]
	public static HCLMPDLDNOB JBMFNDPLPDD(this ELIGIOKOANN LNODCOPPJNC)
	{
		return default(HCLMPDLDNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BD70", Offset = "0x6B0AD70", VA = "0x186B0BD70")]
	internal static IJJKPELBGLO JDPNCECPDKM(this HCLMPDLDNOB MOCKEJPKCNM)
	{
		return default(IJJKPELBGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BD80", Offset = "0x6B0AD80", VA = "0x186B0BD80")]
	internal static IJJKPELBGLO JDPNCECPDKM(this ELIGIOKOANN LNODCOPPJNC)
	{
		return default(IJJKPELBGLO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct GPNEICFJCLD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[PIMLDNKPGPE]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[HPHFBFCABBG(9898405628982320166uL, 2023375009558162791uL)]
public struct NDKHBHIJOOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ANMCIPAPMCD(1)]
	public CAGKAKBHMGC BCEPALIFALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	[ANMCIPAPMCD(2)]
	public BFIKHONDEDE OMEOCNINMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	[ANMCIPAPMCD(3)]
	[OIGFGDIHFEE(0)]
	public bool PEFPLIKNHKI;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly IHABNEGJAPJ<NDKHBHIJOOD> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct PENECJOPBGM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public Entity MMBPCKCAKIM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static PENECJOPBGM MGOLCJODLKK(Entity NNCCHIHKALO)
	{
		return default(PENECJOPBGM);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[LPANCLNLNHL]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[CLHNKKOMENE(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct LGDBGIKHENJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public float3 IFOOGKOPKDF;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly IHABNEGJAPJ<LGDBGIKHENJ> JCGFDJGGMMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct JFPACAOHDNP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[LPANCLNLNHL]
[IACLKPCAHEF("Container", 0)]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
public struct HFMHDNFJLIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	[ANMCIPAPMCD(1)]
	[OIGFGDIHFEE(0)]
	public KPHJIOHBDJC HODOGKAIIHL;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly IHABNEGJAPJ<HFMHDNFJLIM> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[GOBDJIHHDIN(0, 127)]
public enum KPHJIOHBDJC
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class KEHBDCFDMPL
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public enum BHBGBFHIPGA
	{
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum IENBMODJDPK
	{
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C720", Offset = "0x6B0B720", VA = "0x186B0C720")]
	public static (BHBGBFHIPGA, IENBMODJDPK) ADPMOEEILIO(this KPHJIOHBDJC KFHMEIJCMFI)
	{
		return default((BHBGBFHIPGA, IENBMODJDPK));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct LMKDLILIDPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public Entity EMIPEAKIENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public int FCCAKNLHEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public int PKGBKHCIKEH;
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
public struct PLLGKCNAGDB : IComponentData, LBKJFBOMFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	[ANMCIPAPMCD(1)]
	public Entity DJAGPEDCGHG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity NEEMKBMENHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70")]
	public PLLGKCNAGDB(Entity DJAGPEDCGHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static PLLGKCNAGDB MGOLCJODLKK(Entity NNCCHIHKALO)
	{
		return default(PLLGKCNAGDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public struct IMKFHFPGJHB : ISystemStateComponentData, IComponentData, LBKJFBOMFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Entity PPFEAACADMH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity NEEMKBMENHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70")]
	public IMKFHFPGJHB(Entity DJAGPEDCGHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static IMKFHFPGJHB MGOLCJODLKK(Entity NNCCHIHKALO)
	{
		return default(IMKFHFPGJHB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct FILFBPKKNBG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[GOBDJIHHDIN(1000, 8000)]
public enum ELIGIOKOANN
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class FAKIHOFDDJC
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct NOKLMJBKPDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[GOBDJIHHDIN(-2, 2)]
public enum OEIGMGMJEIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	MAX = 2
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct GLNOLHMOFEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct HFOCHPCGCEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public uint LBLAIHNBMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public int LJMDBGKMMBL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xB93FA0", Offset = "0xB92FA0", VA = "0x180B93FA0")]
	public HFOCHPCGCEC(uint CPDAGJHNJHG, int JBKIDCJMICJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct PCFFGKDHFJI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[GOBDJIHHDIN(-1, 31)]
public enum OLLMGFCLHHL
{
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct OALHEEDPANC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	[ANMCIPAPMCD(1)]
	public AIMPNEMJPJO LBJAIKEIOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public GCHandle NHLNFFHEKJH;
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct OLKNGPKEADD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public float4x4 APCKKDGJBIG;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly IHABNEGJAPJ<OLKNGPKEADD> JCGFDJGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
public struct MHGFCJHINDP : IComponentData, LBKJFBOMFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[ANMCIPAPMCD(1)]
	public Entity DJAGPEDCGHG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Entity NEEMKBMENHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1131E70", Offset = "0x1130E70", VA = "0x181131E70")]
	public MHGFCJHINDP(Entity DJAGPEDCGHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static MHGFCJHINDP MGOLCJODLKK(Entity NNCCHIHKALO)
	{
		return default(MHGFCJHINDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D1A0", Offset = "0x6B0C1A0", VA = "0x186B0D1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct FFMLPJJFMOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[FMEELNNGLGD]
public struct AGLNKFLPLFN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public Entity DONBOKOKLIL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390")]
	public static AGLNKFLPLFN MGOLCJODLKK(Entity CKDFGEALFAK)
	{
		return default(AGLNKFLPLFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct DKDNGMBJOHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	[ANMCIPAPMCD(1)]
	public GFGONIAKGED POAJMKNGDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[ANMCIPAPMCD(2)]
	public OEIGMGMJEIJ CNNECNKOHFO;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct OGKHGOHFBJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[ANMCIPAPMCD(1)]
	public bool HCEFOMOBPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[ANMCIPAPMCD(2)]
	public bool CGACKOONCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	[ANMCIPAPMCD(3)]
	public float FGLILDFDMEM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public struct OHMCKDLEHKJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct BOIJOELCCCN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct GPHHOHDKMFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[ANMCIPAPMCD(1)]
	public quaternion IHOLFEDLPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[ANMCIPAPMCD(2)]
	public float3 KOFDECELOKC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly IHABNEGJAPJ<GPHHOHDKMFG> JCGFDJGGMMP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x12EBFA0", Offset = "0x12EAFA0", VA = "0x1812EBFA0")]
	public GPHHOHDKMFG(quaternion IHOLFEDLPLF, float3 KOFDECELOKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B7F0", Offset = "0x6B0A7F0", VA = "0x186B0B7F0")]
	public static GPHHOHDKMFG MGOLCJODLKK(RigidTransform EAODIPHLAKJ)
	{
		return default(GPHHOHDKMFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class FGPDIPLAAIG
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[LPANCLNLNHL]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct GPFFKDHIAMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[ANMCIPAPMCD(1)]
	public FMAGCHDBGLG BIBLLCGNKAG;
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : AINCPJMNCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F130", Offset = "0x6B0E130", VA = "0x186B0F130", Slot = "4")]
		public sealed override void KNBCGPCIENC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class ABKCDIHILNG : ContainerPropertyBag<ONFGFHMICFL>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class FGMHAJEJKJI : Property<ONFGFHMICFL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6B0B430", Offset = "0x6B0A430", VA = "0x186B0B430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B3F0", Offset = "0x6B0A3F0", VA = "0x186B0B3F0")]
		public FGMHAJEJKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2781210", Offset = "0x2780210", VA = "0x182781210", Slot = "14")]
		public override Rigidbody GetValue(ref ONFGFHMICFL DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2781230", Offset = "0x2780230", VA = "0x182781230", Slot = "15")]
		public override void SetValue(ref ONFGFHMICFL DBGHBAHCJKO, Rigidbody CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6B06F10", Offset = "0x6B05F10", VA = "0x186B06F10")]
	public ABKCDIHILNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class JBEPHMKBIOM : ContainerPropertyBag<IFKBLPFKICB>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private class NNGLKMAFGFK : Property<IFKBLPFKICB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6B0D860", Offset = "0x6B0C860", VA = "0x186B0D860", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D820", Offset = "0x6B0C820", VA = "0x186B0D820")]
		public NNGLKMAFGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2781210", Offset = "0x2780210", VA = "0x182781210", Slot = "14")]
		public override object GetValue(ref IFKBLPFKICB DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2781230", Offset = "0x2780230", VA = "0x182781230", Slot = "15")]
		public override void SetValue(ref IFKBLPFKICB DBGHBAHCJKO, object CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BE70", Offset = "0x6B0AE70", VA = "0x186B0BE70")]
	public JBEPHMKBIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class KMMJOOBNHFN : ContainerPropertyBag<FELFKLKEPIL>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class JIPEPKKNGCE : Property<FELFKLKEPIL, KEDINEBOMHC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6B0BF80", Offset = "0x6B0AF80", VA = "0x186B0BF80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BF40", Offset = "0x6B0AF40", VA = "0x186B0BF40")]
		public JIPEPKKNGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2781210", Offset = "0x2780210", VA = "0x182781210", Slot = "14")]
		public override KEDINEBOMHC GetValue(ref FELFKLKEPIL DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2781230", Offset = "0x2780230", VA = "0x182781230", Slot = "15")]
		public override void SetValue(ref FELFKLKEPIL DBGHBAHCJKO, KEDINEBOMHC CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CCA0", Offset = "0x6B0BCA0", VA = "0x186B0CCA0")]
	public KMMJOOBNHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class KGNPEOMJMJF : ContainerPropertyBag<PIKJOOMBOOK>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class LFJLPEGONAH : Property<PIKJOOMBOOK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CE40", Offset = "0x6B0BE40", VA = "0x186B0CE40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CE00", Offset = "0x6B0BE00", VA = "0x186B0CE00")]
		public LFJLPEGONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2781210", Offset = "0x2780210", VA = "0x182781210", Slot = "14")]
		public override object GetValue(ref PIKJOOMBOOK DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2781230", Offset = "0x2780230", VA = "0x182781230", Slot = "15")]
		public override void SetValue(ref PIKJOOMBOOK DBGHBAHCJKO, object CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CA40", Offset = "0x6B0BA40", VA = "0x186B0CA40")]
	public KGNPEOMJMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal class JOJEOHGIGNC : ContainerPropertyBag<BFFAGKPONKO>
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private class AHANNFAKKOL : Property<BFFAGKPONKO, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6B07530", Offset = "0x6B06530", VA = "0x186B07530", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6B074F0", Offset = "0x6B064F0", VA = "0x186B074F0")]
		public AHANNFAKKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x44EBCE0", Offset = "0x44EACE0", VA = "0x1844EBCE0", Slot = "14")]
		public override int GetValue(ref BFFAGKPONKO DBGHBAHCJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6B074D0", Offset = "0x6B064D0", VA = "0x186B074D0", Slot = "15")]
		public override void SetValue(ref BFFAGKPONKO DBGHBAHCJKO, int CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class HBJJJACHLAL : Property<BFFAGKPONKO, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6B0B900", Offset = "0x6B0A900", VA = "0x186B0B900", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B8C0", Offset = "0x6B0A8C0", VA = "0x186B0B8C0")]
		public HBJJJACHLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x44EBD70", Offset = "0x44EAD70", VA = "0x1844EBD70", Slot = "14")]
		public override int GetValue(ref BFFAGKPONKO DBGHBAHCJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B8A0", Offset = "0x6B0A8A0", VA = "0x186B0B8A0", Slot = "15")]
		public override void SetValue(ref BFFAGKPONKO DBGHBAHCJKO, int CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class HGHEJNALMGB : Property<BFFAGKPONKO, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6B0BA10", Offset = "0x6B0AA10", VA = "0x186B0BA10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B9D0", Offset = "0x6B0A9D0", VA = "0x186B0B9D0")]
		public HGHEJNALMGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B980", Offset = "0x6B0A980", VA = "0x186B0B980", Slot = "14")]
		public override GameObject GetValue(ref BFFAGKPONKO DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B9A0", Offset = "0x6B0A9A0", VA = "0x186B0B9A0", Slot = "15")]
		public override void SetValue(ref BFFAGKPONKO DBGHBAHCJKO, GameObject CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C0F0", Offset = "0x6B0B0F0", VA = "0x186B0C0F0")]
	public JOJEOHGIGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal class EKMMGCJPDEC : ContainerPropertyBag<BELFKMGIKEJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	private class JNMOOKGMAJA : Property<BELFKMGIKEJ, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6B0C0C0", Offset = "0x6B0B0C0", VA = "0x186B0C0C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C080", Offset = "0x6B0B080", VA = "0x186B0C080")]
		public JNMOOKGMAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C030", Offset = "0x6B0B030", VA = "0x186B0C030", Slot = "14")]
		public override SerializableGuid GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C060", Offset = "0x6B0B060", VA = "0x186B0C060", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, SerializableGuid CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class AAMKMKCDIDI : Property<BELFKMGIKEJ, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6B06EE0", Offset = "0x6B05EE0", VA = "0x186B06EE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6B06EA0", Offset = "0x6B05EA0", VA = "0x186B06EA0")]
		public AAMKMKCDIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6B06E50", Offset = "0x6B05E50", VA = "0x186B06E50", Slot = "14")]
		public override List<int> GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6B06E70", Offset = "0x6B05E70", VA = "0x186B06E70", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, List<int> CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class OEMBHHOGDIK : Property<BELFKMGIKEJ, List<BELFKMGIKEJ.JKBKLGGHCFO>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6B0DA40", Offset = "0x6B0CA40", VA = "0x186B0DA40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DA00", Offset = "0x6B0CA00", VA = "0x186B0DA00")]
		public OEMBHHOGDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D9B0", Offset = "0x6B0C9B0", VA = "0x186B0D9B0", Slot = "14")]
		public override List<BELFKMGIKEJ.JKBKLGGHCFO> GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D9D0", Offset = "0x6B0C9D0", VA = "0x186B0D9D0", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, List<BELFKMGIKEJ.JKBKLGGHCFO> CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class KIOOFNFLEDP : Property<BELFKMGIKEJ, List<BELFKMGIKEJ.HLPDCOKGKPF>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CC70", Offset = "0x6B0BC70", VA = "0x186B0CC70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CC30", Offset = "0x6B0BC30", VA = "0x186B0CC30")]
		public KIOOFNFLEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CBE0", Offset = "0x6B0BBE0", VA = "0x186B0CBE0", Slot = "14")]
		public override List<BELFKMGIKEJ.HLPDCOKGKPF> GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CC00", Offset = "0x6B0BC00", VA = "0x186B0CC00", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, List<BELFKMGIKEJ.HLPDCOKGKPF> CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class FFABKBIIIFG : Property<BELFKMGIKEJ, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6B0B3C0", Offset = "0x6B0A3C0", VA = "0x186B0B3C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B380", Offset = "0x6B0A380", VA = "0x186B0B380")]
		public FFABKBIIIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B330", Offset = "0x6B0A330", VA = "0x186B0B330", Slot = "14")]
		public override GameObject GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B350", Offset = "0x6B0A350", VA = "0x186B0B350", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, GameObject CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class LJDNJLMIKJD : Property<BELFKMGIKEJ, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CFB0", Offset = "0x6B0BFB0", VA = "0x186B0CFB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF70", Offset = "0x6B0BF70", VA = "0x186B0CF70")]
		public LJDNJLMIKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF20", Offset = "0x6B0BF20", VA = "0x186B0CF20", Slot = "14")]
		public override Light GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF40", Offset = "0x6B0BF40", VA = "0x186B0CF40", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, Light CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class HNBAPNNAILN : Property<BELFKMGIKEJ, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6B0BAD0", Offset = "0x6B0AAD0", VA = "0x186B0BAD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BA90", Offset = "0x6B0AA90", VA = "0x186B0BA90")]
		public HNBAPNNAILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BA40", Offset = "0x6B0AA40", VA = "0x186B0BA40", Slot = "14")]
		public override Collider GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BA60", Offset = "0x6B0AA60", VA = "0x186B0BA60", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, Collider CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class FKCABNLNLPO : Property<BELFKMGIKEJ, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6B0B4F0", Offset = "0x6B0A4F0", VA = "0x186B0B4F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B4B0", Offset = "0x6B0A4B0", VA = "0x186B0B4B0")]
		public FKCABNLNLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B460", Offset = "0x6B0A460", VA = "0x186B0B460", Slot = "14")]
		public override string GetValue(ref BELFKMGIKEJ DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B480", Offset = "0x6B0A480", VA = "0x186B0B480", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ DBGHBAHCJKO, string CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AE50", Offset = "0x6B09E50", VA = "0x186B0AE50")]
	public EKMMGCJPDEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class EFEMOLKOGLG : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class EHLBGCLJIMF : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6B0AE20", Offset = "0x6B09E20", VA = "0x186B0AE20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AD30", Offset = "0x6B09D30", VA = "0x186B0AD30")]
		public EHLBGCLJIMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid DBGHBAHCJKO)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x655EAC0", Offset = "0x655DAC0", VA = "0x18655EAC0", Slot = "15")]
		public override void SetValue(ref SerializableGuid DBGHBAHCJKO, Data128 CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A6E0", Offset = "0x6B096E0", VA = "0x186B0A6E0")]
	public EFEMOLKOGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal class AFHGIPABFNF : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class KGIBICKLGBA : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CA10", Offset = "0x6B0BA10", VA = "0x186B0CA10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C920", Offset = "0x6B0B920", VA = "0x186B0C920")]
		public KGIBICKLGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD85C30", Offset = "0xD84C30", VA = "0x180D85C30", Slot = "14")]
		public override int GetValue(ref Data128 DBGHBAHCJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1430", Offset = "0x3FA0430", VA = "0x183FA1430", Slot = "15")]
		public override void SetValue(ref Data128 DBGHBAHCJKO, int CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class CICNEEMBFOI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6B0A310", Offset = "0x6B09310", VA = "0x186B0A310", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A220", Offset = "0x6B09220", VA = "0x186B0A220")]
		public CICNEEMBFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6560E00", Offset = "0x655FE00", VA = "0x186560E00", Slot = "14")]
		public override int GetValue(ref Data128 DBGHBAHCJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x44FDE00", Offset = "0x44FCE00", VA = "0x1844FDE00", Slot = "15")]
		public override void SetValue(ref Data128 DBGHBAHCJKO, int CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class PCLIFGCNKEN : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6B0DE70", Offset = "0x6B0CE70", VA = "0x186B0DE70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DD80", Offset = "0x6B0CD80", VA = "0x186B0DD80")]
		public PCLIFGCNKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x115A440", Offset = "0x1159440", VA = "0x18115A440", Slot = "14")]
		public override int GetValue(ref Data128 DBGHBAHCJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6567A80", Offset = "0x6566A80", VA = "0x186567A80", Slot = "15")]
		public override void SetValue(ref Data128 DBGHBAHCJKO, int CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class PLCBOABACCO : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6B0E230", Offset = "0x6B0D230", VA = "0x186B0E230", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E140", Offset = "0x6B0D140", VA = "0x186B0E140")]
		public PLCBOABACCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6567910", Offset = "0x6566910", VA = "0x186567910", Slot = "14")]
		public override int GetValue(ref Data128 DBGHBAHCJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6567920", Offset = "0x6566920", VA = "0x186567920", Slot = "15")]
		public override void SetValue(ref Data128 DBGHBAHCJKO, int CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6B06FE0", Offset = "0x6B05FE0", VA = "0x186B06FE0")]
	public AFHGIPABFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class BPNNLJMMPHI : ContainerPropertyBag<BELFKMGIKEJ.JKBKLGGHCFO>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class LALMOGIBHML : Property<BELFKMGIKEJ.JKBKLGGHCFO, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CDD0", Offset = "0x6B0BDD0", VA = "0x186B0CDD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CD90", Offset = "0x6B0BD90", VA = "0x186B0CD90")]
		public LALMOGIBHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xF7B270", Offset = "0xF7A270", VA = "0x180F7B270", Slot = "14")]
		public override Vector3 GetValue(ref BELFKMGIKEJ.JKBKLGGHCFO DBGHBAHCJKO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CD70", Offset = "0x6B0BD70", VA = "0x186B0CD70", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ.JKBKLGGHCFO DBGHBAHCJKO, Vector3 CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class KFJMIEDAJJK : Property<BELFKMGIKEJ.JKBKLGGHCFO, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6B0C8F0", Offset = "0x6B0B8F0", VA = "0x186B0C8F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C8B0", Offset = "0x6B0B8B0", VA = "0x186B0C8B0")]
		public KFJMIEDAJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C890", Offset = "0x6B0B890", VA = "0x186B0C890", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref BELFKMGIKEJ.JKBKLGGHCFO DBGHBAHCJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C8A0", Offset = "0x6B0B8A0", VA = "0x186B0C8A0", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ.JKBKLGGHCFO DBGHBAHCJKO, List<SerializableGuid> CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6B07B70", Offset = "0x6B06B70", VA = "0x186B07B70")]
	public BPNNLJMMPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal class CMACHBLAJIF : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class FCALKGLCCMK : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6B0B290", Offset = "0x6B0A290", VA = "0x186B0B290", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B250", Offset = "0x6B0A250", VA = "0x186B0B250")]
		public FCALKGLCCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B230", Offset = "0x6B0A230", VA = "0x186B0B230", Slot = "14")]
		public override float GetValue(ref Vector3 DBGHBAHCJKO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B240", Offset = "0x6B0A240", VA = "0x186B0B240", Slot = "15")]
		public override void SetValue(ref Vector3 DBGHBAHCJKO, float CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class LJFFIEEKLDJ : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6B0D040", Offset = "0x6B0C040", VA = "0x186B0D040", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D000", Offset = "0x6B0C000", VA = "0x186B0D000")]
		public LJFFIEEKLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CFE0", Offset = "0x6B0BFE0", VA = "0x186B0CFE0", Slot = "14")]
		public override float GetValue(ref Vector3 DBGHBAHCJKO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CFF0", Offset = "0x6B0BFF0", VA = "0x186B0CFF0", Slot = "15")]
		public override void SetValue(ref Vector3 DBGHBAHCJKO, float CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class NCEEOFNIFOO : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6B0D4B0", Offset = "0x6B0C4B0", VA = "0x186B0D4B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D470", Offset = "0x6B0C470", VA = "0x186B0D470")]
		public NCEEOFNIFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xDC93B0", Offset = "0xDC83B0", VA = "0x180DC93B0", Slot = "14")]
		public override float GetValue(ref Vector3 DBGHBAHCJKO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D460", Offset = "0x6B0C460", VA = "0x186B0D460", Slot = "15")]
		public override void SetValue(ref Vector3 DBGHBAHCJKO, float CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A340", Offset = "0x6B09340", VA = "0x186B0A340")]
	public CMACHBLAJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class KILABDAHJAD : ContainerPropertyBag<BELFKMGIKEJ.HLPDCOKGKPF>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class OEJMFECEDGN : Property<BELFKMGIKEJ.HLPDCOKGKPF, BELFKMGIKEJ.JKBKLGGHCFO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6B0D980", Offset = "0x6B0C980", VA = "0x186B0D980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D940", Offset = "0x6B0C940", VA = "0x186B0D940")]
		public OEJMFECEDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x655D920", Offset = "0x655C920", VA = "0x18655D920", Slot = "14")]
		public override BELFKMGIKEJ.JKBKLGGHCFO GetValue(ref BELFKMGIKEJ.HLPDCOKGKPF DBGHBAHCJKO)
		{
			return default(BELFKMGIKEJ.JKBKLGGHCFO);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D900", Offset = "0x6B0C900", VA = "0x186B0D900", Slot = "15")]
		public override void SetValue(ref BELFKMGIKEJ.HLPDCOKGKPF DBGHBAHCJKO, BELFKMGIKEJ.JKBKLGGHCFO CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CB10", Offset = "0x6B0BB10", VA = "0x186B0CB10")]
	public KILABDAHJAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class IAEMINOFGML : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class BMDMHCLGLFM : Property<RRObjectPrefabV2Data, ELIGIOKOANN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string CJABCEFOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6B07B40", Offset = "0x6B06B40", VA = "0x186B07B40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool DFLKEFAELDF
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6B07B00", Offset = "0x6B06B00", VA = "0x186B07B00")]
		public BMDMHCLGLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xD85C30", Offset = "0xD84C30", VA = "0x180D85C30", Slot = "14")]
		public override ELIGIOKOANN GetValue(ref RRObjectPrefabV2Data DBGHBAHCJKO)
		{
			return default(ELIGIOKOANN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1430", Offset = "0x3FA0430", VA = "0x183FA1430", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data DBGHBAHCJKO, ELIGIOKOANN CKDFGEALFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BC00", Offset = "0x6B0AC00", VA = "0x186B0BC00")]
	public IAEMINOFGML()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E260", Offset = "0x6B0D260", VA = "0x186B0E260")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000103")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public class AuthoredParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public class AuthoredPreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public class AuthoredChildrenData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public class ParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public class PreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
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
