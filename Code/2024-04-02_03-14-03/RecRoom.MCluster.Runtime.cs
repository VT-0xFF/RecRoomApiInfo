using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct OCPBKOKDMOP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] FFKKJFEJIIF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] AEOLENCJAMM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] CBPKLGKKBAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD8C510", Offset = "0xD8B110", VA = "0x180D8C510")]
	public static int JGEPOPDKOIB(EPGGOFGEMFJ LCLEPNJJEPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6177C10", Offset = "0x6176810", VA = "0x186177C10")]
	public static int DEPJCAHOFJO(EPGGOFGEMFJ LCLEPNJJEPM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MKMNCHAAEBF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KIINNGNJLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NOJFPHHADLD GHKHCOCJAML(int BFGFFBDCNOA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 JBALEJNDMKH(int BFGFFBDCNOA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CMLIHGNKANO ICCEDJEKAHF();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBKGLJDIFIG CPMDPBCIBHF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HNJDKIJHGAP : GNHBEJAIICI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CMLIHGNKANO NBNNMCCMOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform OIBFJKBCLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<JKBHNNCAJFH> NHKBCHEMNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private ADGGPBNCKOB EFGMHGILIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NJMNBLHOKJP MOIGGBKDOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OHJLADBEACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MKMNCHAAEBF DOAOPMCPCKO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float GDCKMLFKKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x94F520", Offset = "0x94E120", VA = "0x18094F520")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x93D480", Offset = "0x93C080", VA = "0x18093D480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AMJAHPHAMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8729A0", Offset = "0x8715A0", VA = "0x1808729A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x872A60", Offset = "0x871660", VA = "0x180872A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CNIKLFKLIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x107E540", Offset = "0x107D140", VA = "0x18107E540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x107DF90", Offset = "0x107CB90", VA = "0x18107DF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool INFBEJKIOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6174190", Offset = "0x6172D90", VA = "0x186174190", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61741A0", Offset = "0x6172DA0", VA = "0x1861741A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GFDFJMHJGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x124C450", Offset = "0x124B050", VA = "0x18124C450", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61741B0", Offset = "0x6172DB0", VA = "0x1861741B0")]
	public HNJDKIJHGAP(MKMNCHAAEBF KIGGBMJEDEA, bool LAEMKLFPCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6173F70", Offset = "0x6172B70", VA = "0x186173F70")]
	private bool IIECLCNCOBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6173100", Offset = "0x6171D00", VA = "0x186173100", Slot = "4")]
	public bool BGJHDHHBMPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6172F30", Offset = "0x6171B30", VA = "0x186172F30", Slot = "5")]
	public bool BBEBOIIGBMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6173D30", Offset = "0x6172930", VA = "0x186173D30", Slot = "6")]
	public void DMBJGENFJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6173F60", Offset = "0x6172B60", VA = "0x186173F60", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface APPFFJHAGLB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNBBOJOHNLD(CommandBuffer NENBHEDFPEL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HOJGBBAJFJA : APPFFJHAGLB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int BIEADNMOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier LJFMFDGFMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE720", Offset = "0x3BED320", VA = "0x183BEE720")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61742C0", Offset = "0x6172EC0", VA = "0x1861742C0")]
	public HOJGBBAJFJA(int JPCJHDLLDBJ, RenderTargetIdentifier KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6174270", Offset = "0x6172E70", VA = "0x186174270", Slot = "4")]
	public void GNBBOJOHNLD(CommandBuffer NENBHEDFPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct BCNNNLPPLOK : APPFFJHAGLB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int BIEADNMOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] JEAONAJODFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xC4B980", Offset = "0xC4A580", VA = "0x180C4B980")]
	public BCNNNLPPLOK(int JPCJHDLLDBJ, Vector4[] KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61691A0", Offset = "0x6167DA0", VA = "0x1861691A0", Slot = "4")]
	public void GNBBOJOHNLD(CommandBuffer NENBHEDFPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct COFDGFMFBDF : APPFFJHAGLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int BIEADNMOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] CHOFNCNKGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xC4B980", Offset = "0xC4A580", VA = "0x180C4B980")]
	public COFDGFMFBDF(int JPCJHDLLDBJ, float[] KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x616A150", Offset = "0x6168D50", VA = "0x18616A150", Slot = "4")]
	public void GNBBOJOHNLD(CommandBuffer NENBHEDFPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CBFCALJPEOG : APPFFJHAGLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool KKLDKCKGMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x19A34C0", Offset = "0x19A20C0", VA = "0x1819A34C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5770", Offset = "0x3BF4370", VA = "0x183BF5770")]
	public CBFCALJPEOG(string MPGNMPAPHDB, bool OOAKOKIGOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6169CD0", Offset = "0x61688D0", VA = "0x186169CD0", Slot = "4")]
	public void GNBBOJOHNLD(CommandBuffer NENBHEDFPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct IBKGLJDIFIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 PJLNOINEHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 FFHKODBICJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EJHEGNJGLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OIEJECOBLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCF0", Offset = "0x7EE8F0", VA = "0x1807EFCF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OAAPHGDMEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96DE00", Offset = "0x96CA00", VA = "0x18096DE00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6174370", Offset = "0x6172F70", VA = "0x186174370")]
	public IBKGLJDIFIG(Color IFKECNAKMLM, int AKODJGHIOAO, int IJPBBHGPILF, float ICIGBFFKJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1C9AC40", Offset = "0x1C99840", VA = "0x181C9AC40")]
	private static float4 CFIBHINCJJK(Color IFKECNAKMLM)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61742E0", Offset = "0x6172EE0", VA = "0x1861742E0")]
	private static Hash128 IMIPNPLIMAP(IBKGLJDIFIG KIGGBMJEDEA)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ADGGPBNCKOB : GNHBEJAIICI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string AGIADNMPBOJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string IMJFDNGAOOJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string KMAMKAFDDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private IBKGLJDIFIG DIJBKGACNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private BGCIJIDILLL PKJODJFPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 DKEHIHPHMCG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NJMNBLHOKJP JMLFPHNDFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7D8200", Offset = "0x7D6E00", VA = "0x1807D8200")]
		[CompilerGenerated]
		get
		{
			return default(NJMNBLHOKJP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9577C0", Offset = "0x9563C0", VA = "0x1809577C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AMJAHPHAMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5203BE0", Offset = "0x52027E0", VA = "0x185203BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5203BF0", Offset = "0x52027F0", VA = "0x185203BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CNIKLFKLIKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D81D00", Offset = "0x1D80900", VA = "0x181D81D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F1E0", Offset = "0x5F2DDE0", VA = "0x185F2F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GFDFJMHJGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool INFBEJKIOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x52BAE00", Offset = "0x52B9A00", VA = "0x1852BAE00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F3F0", Offset = "0x5F2DFF0", VA = "0x185F2F3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6168D80", Offset = "0x6167980", VA = "0x186168D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6168EC0", Offset = "0x6167AC0", VA = "0x186168EC0")]
	public ADGGPBNCKOB(IBKGLJDIFIG LEENMBMBCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6168C30", Offset = "0x6167830", VA = "0x186168C30")]
	private bool IIECLCNCOBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61689D0", Offset = "0x61675D0", VA = "0x1861689D0", Slot = "4")]
	public bool BGJHDHHBMPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6168D40", Offset = "0x6167940", VA = "0x186168D40")]
	private static BGCIJIDILLL MKEIHCADLNO(IBKGLJDIFIG KIGGBMJEDEA)
	{
		return default(BGCIJIDILLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6168820", Offset = "0x6167420", VA = "0x186168820", Slot = "5")]
	public bool BBEBOIIGBMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6168B20", Offset = "0x6167720", VA = "0x186168B20", Slot = "6")]
	public void DMBJGENFJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6176C40", Offset = "0x6175840", VA = "0x186176C40", Slot = "0")]
		public override bool Equals(object NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6176E40", Offset = "0x6175A40", VA = "0x186176E40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89ACE0", Offset = "0x8998E0", VA = "0x18089ACE0")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private CMKPNANHEKL opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static COKJJCALBLA CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6177510", Offset = "0x6176110", VA = "0x186177510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6177550", Offset = "0x6176150", VA = "0x186177550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6176F20", Offset = "0x6175B20", VA = "0x186176F20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6176EF0", Offset = "0x6175AF0", VA = "0x186176EF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AFGILNBALBJ, RenderingData OBAGCOGAIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6177380", Offset = "0x6175F80", VA = "0x186177380")]
		public void KEBOBFENMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xC4B8D0", Offset = "0xC4A4D0", VA = "0x180C4B8D0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GPFOHKLFMHC<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private BEDEPBNEBAO KOPBCECEJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private BEDEPBNEBAO IGNCPBGPFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer NJKPAGAKFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture JOJGNKEACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int EOHNNAJAOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int KLJALLCNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string LPPFNOCONNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string OCPMBGBBGKB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B80", Offset = "0x7B1780", VA = "0x1807B2B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int HMPFLNGDJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xC685A0", Offset = "0xC671A0", VA = "0x180C685A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GIIGKCCPGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBF0", Offset = "0x7CD7F0", VA = "0x1807CEBF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37B4190", Offset = "0x37B2D90", VA = "0x1837B4190")]
	public GPFOHKLFMHC(string MPGNMPAPHDB, int MHNPFAHMHCP, [Optional] RenderTextureFormat? AHKBHJGDBJA, bool OJMIFKIOJNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37B0680", Offset = "0x37AF280", VA = "0x1837B0680")]
	public void BBEBOIIGBMN(CommandBuffer NENBHEDFPEL, NativeArray<ValType> KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37B14B0", Offset = "0x37B00B0", VA = "0x1837B14B0")]
	public void MOGPKCMDGLN(CommandBuffer NENBHEDFPEL, ComputeShader OBHBIPMMNAD, int KMANCEPFBAH, int NBBACGPICGO = -1, int HNMGEPBEEDH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37B13E0", Offset = "0x37AFFE0", VA = "0x1837B13E0")]
	public void MOGPKCMDGLN(Material PKJODJFPANA, int NBBACGPICGO = -1, int HNMGEPBEEDH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37B1170", Offset = "0x37AFD70", VA = "0x1837B1170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KOFAPDBLBEH
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOGPKCMDGLN(Material LEENMBMBCHM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LGHPBIBJMLD<SrcEntry, DstEntry> : KOFAPDBLBEH, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] MLGLNCAHFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected BEDEPBNEBAO MGKBOILONEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected BEDEPBNEBAO FMKNPHPHMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> OMINOADPMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> AIKPELBOHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int HPFKMDABFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int OHCMMOPAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected GPFOHKLFMHC<int> FEEHCMDJFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected GPFOHKLFMHC<SrcEntry> NJKEPNHCJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected GPFOHKLFMHC<DstEntry> MADALKNCCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader JAGKOGENOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int AKEBABPAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int LOFHKAPMICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int GECHMCAHBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int AHDIFLLNDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int LENNLHKKKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int KLCCMDMHLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int EBDLKIAKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int GKDHJOEFLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int LIPDJPHHBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int NNLOJNEKBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int DFEGKIHDIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int PJPFEKFMBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string CHOPCHJAIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] BAIGPIPGJDD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JGLABEBKLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D7C0", Offset = "0x3C0C3C0", VA = "0x183C0D7C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string MOJHHHHILFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D220", Offset = "0x3C0BE20", VA = "0x183C0D220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3C0DE80", Offset = "0x3C0CA80", VA = "0x183C0DE80")]
	public LGHPBIBJMLD(string MPGNMPAPHDB, int MCOODLBFPFL, int NFJFAMCCMMN, RenderTextureFormat AHKBHJGDBJA, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA = 0, int GAOGILKNPCN = 0, int OFINNCINMBF = 0, int HKDDLLAGLIN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C560", Offset = "0x3C0B160", VA = "0x183C0C560")]
	public int GBIAPBMIAMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D990", Offset = "0x3C0C590", VA = "0x183C0D990")]
	protected void NHMMOAAOOPO(int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C030", Offset = "0x3C0AC30", VA = "0x183C0C030")]
	public NJMNBLHOKJP BGJHDHHBMPP(SrcEntry KOMCCCIEHEA)
	{
		return default(NJMNBLHOKJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B830", Offset = "0x3C0A430", VA = "0x183C0B830")]
	public bool BBEBOIIGBMN(NJMNBLHOKJP FMPJGJEOBDD, SrcEntry KOMCCCIEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C220", Offset = "0x3C0AE20", VA = "0x183C0C220")]
	public bool DMBJGENFJDP(NJMNBLHOKJP FMPJGJEOBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "6")]
	protected virtual void IIEIOCMDGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3C0CF00", Offset = "0x3C0BB00", VA = "0x183C0CF00", Slot = "7")]
	public void JOMFIAPCJDM(CommandBuffer NENBHEDFPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3C0CBF0", Offset = "0x3C0B7F0", VA = "0x183C0CBF0", Slot = "8")]
	public void JOMFIAPCJDM(CommandBuffer NENBHEDFPEL, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA = -1, int GAOGILKNPCN = -1, int OFINNCINMBF = -1, int HKDDLLAGLIN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D820", Offset = "0x3C0C420", VA = "0x183C0D820", Slot = "9")]
	public void MOGPKCMDGLN(CommandBuffer NENBHEDFPEL, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D7D0", Offset = "0x3C0C3D0", VA = "0x183C0D7D0", Slot = "4")]
	public void MOGPKCMDGLN(Material PKJODJFPANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C320", Offset = "0x3C0AF20", VA = "0x183C0C320", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BEDEPBNEBAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong NPBJEHCGDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong HEAOGEFMEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OPNCMJNOKPI
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct LPLLDDGFOLF : BEDEPBNEBAO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable GOOLKBKNFJP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong NPBJEHCGDGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5987580", Offset = "0x5986180", VA = "0x185987580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong HEAOGEFMEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1357DE0", Offset = "0x13569E0", VA = "0x181357DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x45B4510", Offset = "0x45B3110", VA = "0x1845B4510")]
		internal LPLLDDGFOLF(IDisposable NKGOHFHMEOH, ulong CAIPHDONJAH, ulong CMPBLHKKDNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6176BC0", Offset = "0x61757C0", VA = "0x186176BC0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FHNNKFHIGKH : BEDEPBNEBAO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture CBOPAFAOIAL;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong NPBJEHCGDGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5987580", Offset = "0x5986180", VA = "0x185987580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong HEAOGEFMEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1357DE0", Offset = "0x13569E0", VA = "0x181357DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61728C0", Offset = "0x61714C0", VA = "0x1861728C0")]
		public FHNNKFHIGKH(RenderTexture BLAFIMMPJJO, ulong ECNLAPEMDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6172820", Offset = "0x6171420", VA = "0x186172820", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong MNJLBAGOKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61784D0", Offset = "0x61770D0", VA = "0x1861784D0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6178510", Offset = "0x6177110", VA = "0x186178510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong LNFLCGNGFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6178550", Offset = "0x6177150", VA = "0x186178550")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6178590", Offset = "0x6177190", VA = "0x186178590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6178970", Offset = "0x6177570", VA = "0x186178970")]
	public static ComputeBuffer JOBBHNKGDPO(int MAJIECOCCAC, int PBGEBPBPDJM, ComputeBufferType CJEAJMFMNNJ, [Out] BEDEPBNEBAO FMPJGJEOBDD, ComputeBufferMode HJPHBEGAFCD = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61785D0", Offset = "0x61771D0", VA = "0x1861785D0")]
	public static RenderTexture JOBBHNKGDPO(int JMAKFJEBNGB, int JIBGHGEBPGM, int EIGGDODJGMH, RenderTextureFormat AHKBHJGDBJA, [Out] BEDEPBNEBAO FMPJGJEOBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2944280", Offset = "0x2942E80", VA = "0x182944280")]
	public static NativeArray<T> LOBDHMCJGIP<T>(NativeArray<T> GOOLKBKNFJP, ulong GFICJHOBPLH, [Out] BEDEPBNEBAO FMPJGJEOBDD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x29441E0", Offset = "0x2942DE0", VA = "0x1829441E0")]
	public static NativeArray<T> JOBBHNKGDPO<T>(int GFICJHOBPLH, Allocator AIHLFFHGGIO, [Out] BEDEPBNEBAO FMPJGJEOBDD, NativeArrayOptions JAIAHAGCBLM = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6178380", Offset = "0x6176F80", VA = "0x186178380")]
	public static void AIMIAMDLHAG(BEDEPBNEBAO GOOLKBKNFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6178B50", Offset = "0x6177750", VA = "0x186178B50")]
	public static uint PBKFCBMALPD(RenderTextureFormat AHKBHJGDBJA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BPCANFOBLJL : LGHPBIBJMLD<BGDCFLGBIEG, BGDCFLGBIEG>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct AHJENJOMIMP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> IFFCGANFFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> ILFDJNGLJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> DNNBONJFPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> IIOILOAMJCC;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61690C0", Offset = "0x6167CC0", VA = "0x1861690C0")]
		public AHJENJOMIMP(NativeArray<int> GHCNNLJPGPP, NativeArray<float> LGAPEHJEDBE, NativeArray<float4x4> LMBKBFBGBJC, NativeArray<float4> FDIELJEKHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6168F00", Offset = "0x6167B00", VA = "0x186168F00", Slot = "4")]
		public void Execute(int PMIDLPOCCEE, TransformAccess NBNNMCCMOPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct HMKMLJOLEPI : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> IFFCGANFFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> PFNJFNMFPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> DAHGFOKJMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<BGDCFLGBIEG> AEJBCCJAEJB;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x61690C0", Offset = "0x6167CC0", VA = "0x1861690C0")]
		public HMKMLJOLEPI(NativeArray<int> GHCNNLJPGPP, NativeArray<float4x4> JGEINIJDHOC, NativeArray<float4> ANFCOGAONPF, NativeArray<BGDCFLGBIEG> NOMGJFAPODI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6172EC0", Offset = "0x6171AC0", VA = "0x186172EC0", Slot = "4")]
		public void Execute(int PMIDLPOCCEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte HCBCPLIEOML = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray NAGHPIJLCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> FJCBJKMAMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> AGLAKPNJJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> ENHBEBPOGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> MAJNHGEOENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> ONLODOKNJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private BEDEPBNEBAO HJPOJOMGDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private BEDEPBNEBAO HCEEFGOCMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private BEDEPBNEBAO ODBNKOJEEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private BEDEPBNEBAO PJLGDAADKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private BEDEPBNEBAO BCKIOADMFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform LIAHOGBAIJN;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61699F0", Offset = "0x61685F0", VA = "0x1861699F0")]
	public BPCANFOBLJL(int MCOODLBFPFL, int NFJFAMCCMMN, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6169740", Offset = "0x6168340", VA = "0x186169740", Slot = "6")]
	protected override void IIEIOCMDGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6169680", Offset = "0x6168280", VA = "0x186169680")]
	private void HFAFDFCGKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6169520", Offset = "0x6168120", VA = "0x186169520")]
	public bool ECFCACFFOJN(NJMNBLHOKJP FMPJGJEOBDD, Transform NBNNMCCMOPL, float GFEICHJJHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61693A0", Offset = "0x6167FA0", VA = "0x1861693A0")]
	public void BKCJAKCCDHN(NJMNBLHOKJP FMPJGJEOBDD, float GFEICHJJHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6169940", Offset = "0x6168540", VA = "0x186169940")]
	public void OOHKJBDMEON(NJMNBLHOKJP FMPJGJEOBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6169480", Offset = "0x6168080", VA = "0x186169480", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NOJFPHHADLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGMILHEBHMD OJKNFCBJGIJ();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CHOFCONBMDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 PJLNOINEHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int NNHLAMNFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int MFDEBNGOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> KMIPHHDCLED
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> PCKLNGGEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> NANOBJOICHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> CGCCNNELEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> GLMGKOKNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> AMFBGEPKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int KLFCKLHEBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int MPIPPHCLAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int CNLGLOJOLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool BPKBKKAENAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOMFIAPCJDM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JDDINCMDIIF : CHOFCONBMDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NOJFPHHADLD EBLNBAIABEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KGMILHEBHMD PLPNPKIPEIA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 PJLNOINEHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84DD30", Offset = "0x84C930", VA = "0x18084DD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool ACEEKJFCIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E30", Offset = "0x7B8A30", VA = "0x1807B9E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int NNHLAMNFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCF0", Offset = "0x7EE8F0", VA = "0x1807EFCF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7EF920", Offset = "0x7EE520", VA = "0x1807EF920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MFDEBNGOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CC0", Offset = "0x7B58C0", VA = "0x1807B6CC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6570", Offset = "0x7B5170", VA = "0x1807B6570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int KFFIPOGDMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9F4A00", Offset = "0x9F3600", VA = "0x1809F4A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> KMIPHHDCLED
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6174560", Offset = "0x6173160", VA = "0x186174560", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> PCKLNGGEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61745D0", Offset = "0x61731D0", VA = "0x1861745D0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> NANOBJOICHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6174640", Offset = "0x6173240", VA = "0x186174640", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> CGCCNNELEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x61747B0", Offset = "0x61733B0", VA = "0x1861747B0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> GLMGKOKNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6174780", Offset = "0x6173380", VA = "0x186174780", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> AMFBGEPKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61744A0", Offset = "0x61730A0", VA = "0x1861744A0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BPKBKKAENAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x879630", Offset = "0x878230", VA = "0x180879630", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x961730", Offset = "0x960330", VA = "0x180961730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int KLFCKLHEBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6174820", Offset = "0x6173420", VA = "0x186174820", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int MPIPPHCLAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6174620", Offset = "0x6173220", VA = "0x186174620", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int CNLGLOJOLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6174600", Offset = "0x6173200", VA = "0x186174600", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6174830", Offset = "0x6173430", VA = "0x186174830")]
	public JDDINCMDIIF(Hash128 HCLBLKKJPDE, NOJFPHHADLD EBLNBAIABEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6174670", Offset = "0x6173270", VA = "0x186174670", Slot = "16")]
	public void JOMFIAPCJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61744D0", Offset = "0x61730D0", VA = "0x1861744D0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NJMNBLHOKJP : IEquatable<NJMNBLHOKJP>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly NJMNBLHOKJP FAELGIKGNCM;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0")]
	public NJMNBLHOKJP(int PMIDLPOCCEE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61779B0", Offset = "0x61765B0", VA = "0x1861779B0", Slot = "4")]
	public bool Equals(NJMNBLHOKJP NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6177A00", Offset = "0x6176600", VA = "0x186177A00", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6177AD0", Offset = "0x61766D0", VA = "0x186177AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JKBHNNCAJFH : GNHBEJAIICI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool OHJLADBEACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private CHOFCONBMDJ OKHIANEPGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<NJMNBLHOKJP> GHKGIOAAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<NJMNBLHOKJP> ADJMLHBAKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<NJMNBLHOKJP> KBIPEHDMCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> IOOFNKBJOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int NFCHPGGEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int KKHAJNPICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int ALAGHJFCGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int FHDPLPKPNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int OILCGIILCLC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6176400", Offset = "0x6175000", VA = "0x186176400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6175970", Offset = "0x6174570", VA = "0x186175970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AMJAHPHAMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8029C0", Offset = "0x8015C0", VA = "0x1808029C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x869490", Offset = "0x868090", VA = "0x180869490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CNIKLFKLIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA09E00", Offset = "0xA08A00", VA = "0x180A09E00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA09E10", Offset = "0xA08A10", VA = "0x180A09E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool GFDFJMHJGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool INFBEJKIOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x43FC270", Offset = "0x43FAE70", VA = "0x1843FC270", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1783420", Offset = "0x1782020", VA = "0x181783420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float GDCKMLFKKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1B26990", Offset = "0x1B25590", VA = "0x181B26990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1B269A0", Offset = "0x1B255A0", VA = "0x181B269A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x61764B0", Offset = "0x61750B0", VA = "0x1861764B0")]
	public JKBHNNCAJFH(CHOFCONBMDJ PLPNPKIPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6175F20", Offset = "0x6174B20", VA = "0x186175F20")]
	private void KEPOIPPBNIF(CHOFCONBMDJ PLPNPKIPEIA, int NFCHPGGEIFI, int OCNGMJDPBAP, int PMIDLPOCCEE, int BDEIHLHNJJP, LHOBMIPIHNG KOMCCCIEHEA, float OMFLOPHDMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6175C50", Offset = "0x6174850", VA = "0x186175C50")]
	private void IIEIJKHCJME(CHOFCONBMDJ PLPNPKIPEIA, int OJNPIPDGIHB, int PMIDLPOCCEE, uint3 EFIJHDABLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x61759B0", Offset = "0x61745B0", VA = "0x1861759B0")]
	private bool IIECLCNCOBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6174900", Offset = "0x6173500", VA = "0x186174900", Slot = "4")]
	public bool BGJHDHHBMPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6174880", Offset = "0x6173480", VA = "0x186174880", Slot = "5")]
	public bool BBEBOIIGBMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61752A0", Offset = "0x6173EA0", VA = "0x1861752A0", Slot = "6")]
	public void DMBJGENFJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6175910", Offset = "0x6174510", VA = "0x186175910")]
	public void JDDIPONNJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6175910", Offset = "0x6174510", VA = "0x186175910", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GNHBEJAIICI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool GFDFJMHJGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool INFBEJKIOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGJHDHHBMPP();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBEBOIIGBMN();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMBJGENFJDP();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DGFHCOAIEFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float CBODLKJEFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, JKBHNNCAJFH> ELJOFNAKHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, ADGGPBNCKOB> LBIFEFGNOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<GNHBEJAIICI> FMNMMAOBNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<GNHBEJAIICI> BAJOAIPNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<GNHBEJAIICI> DABJMDPBMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int GLOLOFKBKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int BJPEAKNBDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float HOOLEJACLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool OOKFAJANAGI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool IKCPMOAENPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xC6E670", Offset = "0xC6D270", VA = "0x180C6E670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC8BA90", Offset = "0xC8A690", VA = "0x180C8BA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LBPOEJPAPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x61721B0", Offset = "0x6170DB0", VA = "0x1861721B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string MOJHHHHILFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6172200", Offset = "0x6170E00", VA = "0x186172200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6171510", Offset = "0x6170110", VA = "0x186171510")]
	public void CPEBFBMMJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6171630", Offset = "0x6170230", VA = "0x186171630")]
	public void EDJILAKMOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x61725E0", Offset = "0x61711E0", VA = "0x1861725E0")]
	public DGFHCOAIEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6171640", Offset = "0x6170240", VA = "0x186171640")]
	public HNJDKIJHGAP FAEDNEGPAEK(MKMNCHAAEBF MCFGKAKKIKD, bool LAEMKLFPCED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6171A60", Offset = "0x6170660", VA = "0x186171A60")]
	public ADGGPBNCKOB FAEDNEGPAEK(IBKGLJDIFIG PKJODJFPANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6171BC0", Offset = "0x61707C0", VA = "0x186171BC0")]
	public bool GABHHOBABBN(Hash128 JPCJHDLLDBJ, [Out] JKBHNNCAJFH FHFDDHACONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6171770", Offset = "0x6170370", VA = "0x186171770")]
	public JKBHNNCAJFH FAEDNEGPAEK(CHOFCONBMDJ PLPNPKIPEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6171BA0", Offset = "0x61707A0", VA = "0x186171BA0")]
	private void FAKALKIAOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6171480", Offset = "0x6170080", VA = "0x186171480")]
	private bool ANPCAHCFLHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6171CE0", Offset = "0x61708E0", VA = "0x186171CE0")]
	public void JOMFIAPCJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6171520", Offset = "0x6170120", VA = "0x186171520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6171C30", Offset = "0x6170830", VA = "0x186171C30")]
	public void GMACBKOEPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AADPLLEACML : LGHPBIBJMLD<KJEMMGJJLFH, KJEMMGJJLFH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6168770", Offset = "0x6167370", VA = "0x186168770")]
	public AADPLLEACML(int MCOODLBFPFL, int NFJFAMCCMMN, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OCNFOONAGCP : LGHPBIBJMLD<BGCIJIDILLL, BGCIJIDILLL>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6177B60", Offset = "0x6176760", VA = "0x186177B60")]
	public OCNFOONAGCP(int MCOODLBFPFL, int NFJFAMCCMMN, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OINEIFBPBNC : LGHPBIBJMLD<FCJMOOBCPDL, FCJMOOBCPDL>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61782D0", Offset = "0x6176ED0", VA = "0x1861782D0")]
	public OINEIFBPBNC(int MCOODLBFPFL, int NFJFAMCCMMN, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ANLPGJBLCEJ : LGHPBIBJMLD<FAIOJDJHIPM, NLHILLDLBKM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x61690F0", Offset = "0x6167CF0", VA = "0x1861690F0")]
	public ANLPGJBLCEJ(int MCOODLBFPFL, int NFJFAMCCMMN, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GLPJMOGCAHI : LGHPBIBJMLD<MOMBOKCBJNJ, MOMBOKCBJNJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6172E10", Offset = "0x6171A10", VA = "0x186172E10")]
	public GLPJMOGCAHI(int MCOODLBFPFL, int NFJFAMCCMMN, ComputeShader HFBELCOBJPB, int HFKNHNOCPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class CMKPNANHEKL : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private COKJJCALBLA BJNBGFMNJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool OOAKOKIGOGO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool LMHFEHLCPFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6168D10", VA = "0x18616A110")]
	public CMKPNANHEKL(COKJJCALBLA KJOEGPBCMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6169F80", Offset = "0x6168B80", VA = "0x186169F80", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer NENBHEDFPEL, RenderingData OBAGCOGAIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6169D10", Offset = "0x6168910", VA = "0x186169D10", Slot = "6")]
	public override void Configure(CommandBuffer NENBHEDFPEL, RenderTextureDescriptor NFFNHDFJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6169D50", Offset = "0x6168950", VA = "0x186169D50", Slot = "9")]
	public override void Execute(ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class FKNFIGBBCDK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct KLGAJJOOIIG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string MPGNMPAPHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer NENBHEDFPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext LAMCDJBBCDK;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6176AB0", Offset = "0x61756B0", VA = "0x186176AB0")]
		public KLGAJJOOIIG(string BIGNAKEGKAI, ScriptableRenderContext JFPPOIJCDJD, [Out] CommandBuffer ABNOEJAGFKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6176A00", Offset = "0x6175600", VA = "0x186176A00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6172B20", Offset = "0x6171720", VA = "0x186172B20")]
	public static bool LIKKGMFKKOE(RenderingData OBAGCOGAIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6172C70", Offset = "0x6171870", VA = "0x186172C70")]
	public static void LNOOEBCGJOA(CommandBuffer NENBHEDFPEL, ScriptableRenderContext LAMCDJBBCDK, ShadowDrawingSettings AEGDIOCEFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x61728F0", Offset = "0x61714F0", VA = "0x1861728F0")]
	public static void LDLCCPILGLD(CommandBuffer NENBHEDFPEL, ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class COKJJCALBLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class DFJFPFALGOP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int KPFDPOFGGJL;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int JCOHNKLHLNE;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static GPFOHKLFMHC<JKDBMMNDJAP> JPIJDOMGJAG;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static GPFOHKLFMHC<uint> BACEDJCMFFF;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static BEDEPBNEBAO CJBIBJOHCME;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer AGIHANHLPFB;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<KOFAPDBLBEH> HCGBCNEGPEO;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int JKHAEFBPJOG;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int DJJCMAAJCAH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int OHIPPFMOEKJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int PBLEAPKMBAD;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] AJFGBLAPIPK;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] BOEEBLIHGPH;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static APPFFJHAGLB[][] COFGKCDBEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] APLDDMDONOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int IEAPFDANLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int HNFKMCMJCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int AGCGEJOFGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int NDKLGKHMAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int JINHHFLABLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int ENAIHANOJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int DLBFNKCBFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int CFOKNHOBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int KAPFICKGAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int CHMCCPFCJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int HMHBMGLGDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int HHBFMHFIDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int HAMFDNGAPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int LHMLJLKJJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int ODLEKENHMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int IFLJAEBPMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int CMEBFNAAFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int GHIDMOEEKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] CJCNADJOMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private DGFHCOAIEFC MJIDOLMJNEC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool BJMLNHHDAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x616E940", Offset = "0x616D540", VA = "0x18616E940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x616E9F0", Offset = "0x616D5F0", VA = "0x18616E9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool BFHJIJKBNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x616C980", Offset = "0x616B580", VA = "0x18616C980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6170040", Offset = "0x616EC40", VA = "0x186170040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData EIIIJBECKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x616D4C0", Offset = "0x616C0C0", VA = "0x18616D4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6170840", Offset = "0x616F440", VA = "0x186170840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static BPCANFOBLJL MINAMFKBIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x616A780", Offset = "0x6169380", VA = "0x18616A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x616CBD0", Offset = "0x616B7D0", VA = "0x18616CBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static AADPLLEACML GAFFIIBNLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6170F10", Offset = "0x616FB10", VA = "0x186170F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x616C7C0", Offset = "0x616B3C0", VA = "0x18616C7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static OCNFOONAGCP GIMOFMHPJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6170E60", Offset = "0x616FA60", VA = "0x186170E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6171090", Offset = "0x616FC90", VA = "0x186171090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static OINEIFBPBNC PCIDJACKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x61708B0", Offset = "0x616F4B0", VA = "0x1861708B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x616C8B0", Offset = "0x616B4B0", VA = "0x18616C8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static ANLPGJBLCEJ GDAOBIGKCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6170EB0", Offset = "0x616FAB0", VA = "0x186170EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x616CC40", Offset = "0x616B840", VA = "0x18616CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static GLPJMOGCAHI NKGOHNNGDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x616FFE0", Offset = "0x616EBE0", VA = "0x18616FFE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x616C830", Offset = "0x616B430", VA = "0x18616C830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material MNEIIHMKEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x616CCC0", Offset = "0x616B8C0", VA = "0x18616CCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x616D510", Offset = "0x616C110", VA = "0x18616D510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material HLMMIKPHCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x616C250", Offset = "0x616AE50", VA = "0x18616C250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6171000", Offset = "0x616FC00", VA = "0x186171000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material LMHFJKCHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61700A0", Offset = "0x616ECA0", VA = "0x1861700A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x616EAB0", Offset = "0x616D6B0", VA = "0x18616EAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material LHFPCFKFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x616C920", Offset = "0x616B520", VA = "0x18616C920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x61707C0", Offset = "0x616F3C0", VA = "0x1861707C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool EAOEGAALGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x616EA50", Offset = "0x616D650", VA = "0x18616EA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x616E990", Offset = "0x616D590", VA = "0x18616E990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool LBPOEJPAPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x616FF80", Offset = "0x616EB80", VA = "0x18616FF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string MOJHHHHILFD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6170100", Offset = "0x616ED00", VA = "0x186170100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61711A0", Offset = "0x616FDA0", VA = "0x1861711A0")]
	internal COKJJCALBLA([Optional] MClusterData GGGIMECNNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x616D590", Offset = "0x616C190", VA = "0x18616D590")]
	public void HAJAGMDCLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6170F60", Offset = "0x616FB60", VA = "0x186170F60")]
	public void PADPJLGKAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6171080", Offset = "0x616FC80", VA = "0x186171080")]
	public void PGHKNFFBPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x616C9D0", Offset = "0x616B5D0", VA = "0x18616C9D0")]
	public bool DDDCOIHNNIA(Hash128 HCLBLKKJPDE, [Out] JKBHNNCAJFH PLPNPKIPEIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x616CEE0", Offset = "0x616BAE0", VA = "0x18616CEE0")]
	public JKBHNNCAJFH FAEDNEGPAEK(CHOFCONBMDJ KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x616CFA0", Offset = "0x616BBA0", VA = "0x18616CFA0")]
	public ADGGPBNCKOB FAEDNEGPAEK(IBKGLJDIFIG PKJODJFPANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x616CD20", Offset = "0x616B920", VA = "0x18616CD20")]
	public HNJDKIJHGAP FAEDNEGPAEK(MKMNCHAAEBF MCFGKAKKIKD, bool LAEMKLFPCED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x616CA70", Offset = "0x616B670", VA = "0x18616CA70")]
	public void DMBJGENFJDP(GNHBEJAIICI DEABEEHMNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x616F8D0", Offset = "0x616E4D0", VA = "0x18616F8D0")]
	public static void KHFPKOLBKKE(EPGGOFGEMFJ LCLEPNJJEPM, APPFFJHAGLB[] KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x616A9A0", Offset = "0x61695A0", VA = "0x18616A9A0")]
	private void AGGJLKAOOCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x616EC10", Offset = "0x616D810", VA = "0x18616EC10")]
	private static void KFCPEDCBJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x616D1A0", Offset = "0x616BDA0", VA = "0x18616D1A0")]
	public void FMGBFPCBCAJ(CommandBuffer NENBHEDFPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x616A7D0", Offset = "0x61693D0", VA = "0x18616A7D0")]
	public void ACFDBKBHODA([Optional] ScriptableRenderContext? LAMCDJBBCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x616FCA0", Offset = "0x616E8A0", VA = "0x18616FCA0")]
	public void KJHIHAJBJEN(CommandBuffer NENBHEDFPEL, ShadowSplitData NCBHKMNNIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x616F9C0", Offset = "0x616E5C0", VA = "0x18616F9C0")]
	public void KJHIHAJBJEN(CommandBuffer NENBHEDFPEL, CameraData PHJCENNACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6170900", Offset = "0x616F500", VA = "0x186170900")]
	public void NDLBBAMFKBL(CommandBuffer NENBHEDFPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x616C750", Offset = "0x616B350", VA = "0x18616C750")]
	public void BMLOJBLPICE(CommandBuffer NENBHEDFPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x616C2B0", Offset = "0x616AEB0", VA = "0x18616C2B0")]
	public void BLFFIOPOKLC(CommandBuffer NENBHEDFPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x616A180", Offset = "0x6168D80", VA = "0x18616A180")]
	public void AALGLOPEHEB(CommandBuffer NENBHEDFPEL, EPGGOFGEMFJ BJBIDPIJINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x616EB30", Offset = "0x616D730", VA = "0x18616EB30")]
	public void KEBOBFENMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x616B2A0", Offset = "0x6169EA0", VA = "0x18616B2A0")]
	public void AIMIAMDLHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x616CAC0", Offset = "0x616B6C0", VA = "0x18616CAC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LIGLCKDGHEO
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1D6FBF0", Offset = "0x1D6E7F0", VA = "0x181D6FBF0")]
	public static int NMEAEAAIKED(int CFPNJHJGBGM, int GKMICILLDLP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BGDCFLGBIEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 JAKOMCIKBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 EECKFFJALLE;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly BGDCFLGBIEG MKBFCAOKDAE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly BGDCFLGBIEG FAELGIKGNCM;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6169370", Offset = "0x6167F70", VA = "0x186169370")]
	public BGDCFLGBIEG(float4x4 OIGAJNHLODF, float4 CELGBHEDBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6169200", Offset = "0x6167E00", VA = "0x186169200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct LHOBMIPIHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 GMKEEAOHFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 JJMOIFJMOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 IPIBPFLONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 NBDBLMECAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 MLLOBAEHGNE;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LFLINFJDILI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 GMKEEAOHFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 JJMOIFJMOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 IPIBPFLONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 NBDBLMECAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 MLLOBAEHGNE;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NLHILLDLBKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public LFLINFJDILI EBKFMKIDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public LFLINFJDILI DKKCDMAGAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public LFLINFJDILI AHFOICDHMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public LFLINFJDILI JLOAHHEHFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public LFLINFJDILI CEBIKIABELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public LFLINFJDILI ECOJGLACOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public LFLINFJDILI OALOMIJKFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public LFLINFJDILI JIABKLAMFEJ;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct FAIOJDJHIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public LHOBMIPIHNG EBKFMKIDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public LHOBMIPIHNG DKKCDMAGAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public LHOBMIPIHNG AHFOICDHMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public LHOBMIPIHNG JLOAHHEHFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public LHOBMIPIHNG CEBIKIABELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public LHOBMIPIHNG ECOJGLACOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public LHOBMIPIHNG OALOMIJKFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public LHOBMIPIHNG JIABKLAMFEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct BGCIJIDILLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 INEGDGGGMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint AKODJGHIOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint IJPBBHGPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float ICIGBFFKJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint HAJCHNIKNPI;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x61691D0", Offset = "0x6167DD0", VA = "0x1861691D0")]
	public BGCIJIDILLL(IBKGLJDIFIG PKJODJFPANA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JKDBMMNDJAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint CAPKBNNJBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint HMLEEAJOCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint BDEIHLHNJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint HAJCHNIKNPI;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6176620", Offset = "0x6175220", VA = "0x186176620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FCJMOOBCPDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint OCNGMJDPBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint LDHEKKMNMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint KKHAJNPICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint HAJCHNIKNPI;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6172770", Offset = "0x6171370", VA = "0x186172770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KJEMMGJJLFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint HEJODJNNGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint DFIDCOMDBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint NOMANPDKBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint JGLJHMBHCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint EKLFGODCDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint BJMJBNIFDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint IKGBANAFJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint HAJCHNIKNPI;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61766D0", Offset = "0x61752D0", VA = "0x1861766D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MOMBOKCBJNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 IMJOLEDABPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 AOJFAKLFDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 DDBAJBMFEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 FHKAFECHBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 GMGFFGFCCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 JBBPEADMKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 DKBMCLEFLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 OACNMCKFJDF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x61775B0", Offset = "0x61761B0", VA = "0x1861775B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum EPGGOFGEMFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Shadow
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
