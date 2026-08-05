using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
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
namespace _LogRegistration.RecRoom_MCluster_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C98040", Offset = "0x7C96640", VA = "0x187C98040", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct JNINPOOMGPL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] OHCHMENFKKH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] PNCNLLOEBPB;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] AAIDKCFEPAC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B780", Offset = "0x1E59D80", VA = "0x181E5B780")]
	public static int NCFENJMBINH(FMLALOECOHN JGGBDGJFMCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C964B0", Offset = "0x7C94AB0", VA = "0x187C964B0")]
	public static int CBFKACDGJEM(FMLALOECOHN JGGBDGJFMCJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BJHBGAPNKPE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KGOFHLOEILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KNHDOEOGJOI EDHIDPPEGOP(int GKGMDAMJCNF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 KLJNHBBKJDH(int GKGMDAMJCNF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CIPJGNAKHIH LAOJGEPMLKG();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BJJJCPEHCID KDFCGDBGIAI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LGJOMFGAFNG : ADCOPGKOHIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CIPJGNAKHIH KOOMPFGMBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform DAPOKCBHMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<DGNHHNGONDN> IBFBAOBNGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MOECHNGGONK BKADFNPFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private ECMJGPEONGP MOGONBCOBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JHMICNKGFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BJHBGAPNKPE DMHBNDHLBAF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float ECCBMHJNPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC073D0", Offset = "0xC059D0", VA = "0x180C073D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC07240", Offset = "0xC05840", VA = "0x180C07240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DBCHBGPDGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC17800", Offset = "0xC15E00", VA = "0x180C17800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCF1F40", Offset = "0xCF0540", VA = "0x180CF1F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PANKKJMNEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD7B0D0", Offset = "0xD796D0", VA = "0x180D7B0D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xD799D0", Offset = "0xD77FD0", VA = "0x180D799D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1E615D0", Offset = "0x1E5FBD0", VA = "0x181E615D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E609C0", Offset = "0x1E5EFC0", VA = "0x181E609C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NKEOBBMJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F4DEF0", Offset = "0x1F4C4F0", VA = "0x181F4DEF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C97EB0", Offset = "0x7C964B0", VA = "0x187C97EB0")]
	public LGJOMFGAFNG(BJHBGAPNKPE LBGDJDBPBBD, bool EPPKCOCHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C96C50", Offset = "0x7C95250", VA = "0x187C96C50")]
	private bool CCECGMBPCHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C97270", Offset = "0x7C95870", VA = "0x187C97270", Slot = "4")]
	public bool IIGLPCDPOEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C970A0", Offset = "0x7C956A0", VA = "0x187C970A0", Slot = "5")]
	public bool IEKHBJGOAKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C96E80", Offset = "0x7C95480", VA = "0x187C96E80", Slot = "6")]
	public void GNAALOCCJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C96E70", Offset = "0x7C95470", VA = "0x187C96E70", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PBBIEIOAEPN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOHAFMDCCAL(CommandBuffer HKEOEPNOEKP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KCOAPELEHEM : PBBIEIOAEPN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier BMGKIAEJELH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x50C5BF0", Offset = "0x50C41F0", VA = "0x1850C5BF0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C96BB0", Offset = "0x7C951B0", VA = "0x187C96BB0")]
	public KCOAPELEHEM(int HJPLNJNIFLL, RenderTargetIdentifier APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C96B60", Offset = "0x7C95160", VA = "0x187C96B60", Slot = "4")]
	public void FOHAFMDCCAL(CommandBuffer HKEOEPNOEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct INGLKAAOIOO : PBBIEIOAEPN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] MDGCFBDFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x16451F0", Offset = "0x16437F0", VA = "0x1816451F0")]
	public INGLKAAOIOO(int HJPLNJNIFLL, Vector4[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C96450", Offset = "0x7C94A50", VA = "0x187C96450", Slot = "4")]
	public void FOHAFMDCCAL(CommandBuffer HKEOEPNOEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PEGFCDHCDBE : PBBIEIOAEPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] CNPGNIIEFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x16451F0", Offset = "0x16437F0", VA = "0x1816451F0")]
	public PEGFCDHCDBE(int HJPLNJNIFLL, float[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A2B0", Offset = "0x7C988B0", VA = "0x187C9A2B0", Slot = "4")]
	public void FOHAFMDCCAL(CommandBuffer HKEOEPNOEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PPIMCPAOBEN : PBBIEIOAEPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool KMGCMFNJFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD2EE80", Offset = "0xD2D480", VA = "0x180D2EE80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x17AD290", Offset = "0x17AB890", VA = "0x1817AD290")]
	public PPIMCPAOBEN(string NFHOBPDKIPM, bool BFEIIPBAHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA17B0", Offset = "0x7C9FDB0", VA = "0x187CA17B0", Slot = "4")]
	public void FOHAFMDCCAL(CommandBuffer HKEOEPNOEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BJJJCPEHCID
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 CBNMGIONGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 PADMDIIJMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int ANPKODPAGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int APHKHGAPDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LHLGNLHGNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF3EEC0", Offset = "0xF3D4C0", VA = "0x180F3EEC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C919E0", Offset = "0x7C8FFE0", VA = "0x187C919E0")]
	public BJJJCPEHCID(Color NGGKCKILBNF, int CHMKOMKIOJM, int IKGHDBJPNHK, float KDDONEOCMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1145D30", Offset = "0x1144330", VA = "0x181145D30")]
	private static float4 ICKHIKNPAEE(Color NGGKCKILBNF)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C91950", Offset = "0x7C8FF50", VA = "0x187C91950")]
	private static Hash128 EJLLPKPJHLH(BJJJCPEHCID LBGDJDBPBBD)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MOECHNGGONK : ADCOPGKOHIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string EDJAHBGEKJN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string IAGJHLMNMHB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string CACOCCFAANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BJJJCPEHCID JCLHDAIAOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private JKFIKAOELPB CANJBFKPEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 BNMHOJLDHCJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ECMJGPEONGP JLIPEHDKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA12060", Offset = "0xA10660", VA = "0x180A12060")]
		[CompilerGenerated]
		get
		{
			return default(ECMJGPEONGP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x131BED0", Offset = "0x131A4D0", VA = "0x18131BED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DBCHBGPDGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1132460", Offset = "0x1130A60", VA = "0x181132460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A67F40", Offset = "0x6A66540", VA = "0x186A67F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PANKKJMNEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x26DE8F0", Offset = "0x26DCEF0", VA = "0x1826DE8F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C00E60", Offset = "0x7BFF460", VA = "0x187C00E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NKEOBBMJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B85640", Offset = "0x6B83C40", VA = "0x186B85640", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C99B30", Offset = "0x7C98130", VA = "0x187C99B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C997E0", Offset = "0x7C97DE0", VA = "0x187C997E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C99C20", Offset = "0x7C98220", VA = "0x187C99C20")]
	public MOECHNGGONK(BJJJCPEHCID PNOMKMDMEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C995E0", Offset = "0x7C97BE0", VA = "0x187C995E0")]
	private bool CCECGMBPCHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C999E0", Offset = "0x7C97FE0", VA = "0x187C999E0", Slot = "4")]
	public bool IIGLPCDPOEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C995A0", Offset = "0x7C97BA0", VA = "0x187C995A0")]
	private static JKFIKAOELPB ADFLGKEIFNM(BJJJCPEHCID LBGDJDBPBBD)
	{
		return default(JKFIKAOELPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C99830", Offset = "0x7C97E30", VA = "0x187C99830", Slot = "5")]
	public bool IEKHBJGOAKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C996E0", Offset = "0x7C97CE0", VA = "0x187C996E0", Slot = "6")]
	public void GNAALOCCJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
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

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C98180", Offset = "0x7C96780", VA = "0x187C98180", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C98380", Offset = "0x7C96980", VA = "0x187C98380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBBABA0", Offset = "0xBB91A0", VA = "0x180BBABA0")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private PBIKBFEIGLM opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static PFGAMGNPFAE CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C98B80", Offset = "0x7C97180", VA = "0x187C98B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7C98BD0", Offset = "0x7C971D0", VA = "0x187C98BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C98640", Offset = "0x7C96C40", VA = "0x187C98640", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C98430", Offset = "0x7C96A30", VA = "0x187C98430", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C98460", Offset = "0x7C96A60", VA = "0x187C98460")]
		public void CHODBLKANMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GMAOMEIHKFB<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private ICAPOKGAKKK ICKOIKPNEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ICAPOKGAKKK PFMEOBBHPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ComputeBuffer GOMFPLNMBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private RenderTexture KGFIDNEJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int IIHEIPADIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int BFKMFDEDOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string ANDOONPALGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private string KFMMCEMFGAH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int FFJMFMINGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD90", Offset = "0xA29390", VA = "0x180A2AD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int PBOBPDOBDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4ACB820", Offset = "0x4AC9E20", VA = "0x184ACB820")]
	public GMAOMEIHKFB(string NFHOBPDKIPM, int JGCOFGKBDCG, [Optional] RenderTextureFormat? CKHLMMECGLE, bool HLNLBOGKLCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4AC9780", Offset = "0x4AC7D80", VA = "0x184AC9780")]
	public void IEKHBJGOAKB(CommandBuffer HKEOEPNOEKP, NativeArray<ValType> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4ACB050", Offset = "0x4AC9650", VA = "0x184ACB050")]
	public void NGJEKGJIPEE(CommandBuffer HKEOEPNOEKP, ComputeShader NHBFJDBEFAO, int NIIPIIDPIDH, int NMAFGGLFKKD = -1, int KKAPANPFMCH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4ACAF80", Offset = "0x4AC9580", VA = "0x184ACAF80")]
	public void NGJEKGJIPEE(Material CANJBFKPEMF, int NMAFGGLFKKD = -1, int KKAPANPFMCH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4AC8C30", Offset = "0x4AC7230", VA = "0x184AC8C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KKPHENGCNFL
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGJEKGJIPEE(Material PNOMKMDMEID);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BAJPOBIKNLG<SrcEntry, DstEntry> : KKPHENGCNFL, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected bool[] KMKNFHFFMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected ICAPOKGAKKK KGOJFMKHGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected ICAPOKGAKKK OJMHJLPNLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<int> MIHOKIJPIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected NativeArray<SrcEntry> BODIOENAIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int EDFNJAIHFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected int PGOKKAJGDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected GMAOMEIHKFB<int> LDAGILMOMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected GMAOMEIHKFB<SrcEntry> ONDENKFEPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected GMAOMEIHKFB<DstEntry> LEBGJCGEGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected ComputeShader DABKGDBJPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int HCHBEKGNOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int JHHKPPJPGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int MDCJBLNDKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int IDAFLABNILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int DFGMHOCJJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int LDFOAFECOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int OKPBAAJPAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int GEGMHMEAEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int PDKNAHMCFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int ILCALBAMPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int ONDOOFNDOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected int JIIBOOMAJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string DOHGOANHJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected float[] FFFIFKAHJDB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6055C00", Offset = "0x6054200", VA = "0x186055C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string DOBBIJAKKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60564C0", Offset = "0x6054AC0", VA = "0x1860564C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60569A0", Offset = "0x6054FA0", VA = "0x1860569A0")]
	public BAJPOBIKNLG(string NFHOBPDKIPM, int OOBLHGFAEBJ, int HDHJPIOPNFE, RenderTextureFormat CKHLMMECGLE, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH = 0, int CBFKOKHEDFI = 0, int BGOHLDFPGEK = 0, int KKGDABFNBAI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6055C60", Offset = "0x6054260", VA = "0x186055C60")]
	public int EICEHJIPKHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6055C10", Offset = "0x6054210", VA = "0x186055C10")]
	protected void EHHJLBIMKKD(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6056300", Offset = "0x6054900", VA = "0x186056300")]
	public ECMJGPEONGP IIGLPCDPOEE(SrcEntry APDBNIMCPID)
	{
		return default(ECMJGPEONGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6056120", Offset = "0x6054720", VA = "0x186056120")]
	public bool IEKHBJGOAKB(ECMJGPEONGP BOJCEMEJOMP, SrcEntry APDBNIMCPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60560A0", Offset = "0x60546A0", VA = "0x1860560A0")]
	public bool GNAALOCCJEL(ECMJGPEONGP BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	protected virtual void HJFKCJCGOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6056040", Offset = "0x6054640", VA = "0x186056040", Slot = "7")]
	public void FIADEAHHAAD(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6055CD0", Offset = "0x60542D0", VA = "0x186055CD0", Slot = "8")]
	public void FIADEAHHAAD(CommandBuffer HKEOEPNOEKP, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH = -1, int CBFKOKHEDFI = -1, int BGOHLDFPGEK = -1, int KKGDABFNBAI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6056790", Offset = "0x6054D90", VA = "0x186056790", Slot = "9")]
	public void NGJEKGJIPEE(CommandBuffer HKEOEPNOEKP, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6056930", Offset = "0x6054F30", VA = "0x186056930", Slot = "4")]
	public void NGJEKGJIPEE(Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6055B00", Offset = "0x6054100", VA = "0x186055B00", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ICAPOKGAKKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong FCBABPNDLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong CPMBHBDPMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CJNGEFCDIMP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct AKMHIJEGLDC : ICAPOKGAKKK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IDisposable LJEENFPIGIA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong FCBABPNDLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x731F620", Offset = "0x731DC20", VA = "0x18731F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong CPMBHBDPMPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C91910", Offset = "0x7C8FF10", VA = "0x187C91910")]
		internal AKMHIJEGLDC(IDisposable POFIHCCNNPF, ulong JFCPMHNEIAC, ulong FKFMCJIIEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7C91890", Offset = "0x7C8FE90", VA = "0x187C91890", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct LOOONOBINFL : ICAPOKGAKKK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private RenderTexture OIKCEKGKOOL;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong FCBABPNDLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x731F620", Offset = "0x731DC20", VA = "0x18731F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong CPMBHBDPMPO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C98010", Offset = "0x7C96610", VA = "0x187C98010")]
		public LOOONOBINFL(RenderTexture BFGBBIJNNHK, ulong PBGOPGJIGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C97F70", Offset = "0x7C96570", VA = "0x187C97F70", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong KMPJHPMPBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C92BB0", Offset = "0x7C911B0", VA = "0x187C92BB0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C92B70", Offset = "0x7C91170", VA = "0x187C92B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong GBPHEJGNBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C92B30", Offset = "0x7C91130", VA = "0x187C92B30")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C92450", Offset = "0x7C90A50", VA = "0x187C92450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C92820", Offset = "0x7C90E20", VA = "0x187C92820")]
	public static ComputeBuffer FLLMCNLHKNL(int JAALIADHHOC, int FCLELIDFMHC, ComputeBufferType MLCOGCMJLBB, [Out] ICAPOKGAKKK BOJCEMEJOMP, ComputeBufferMode MECLDBHCDJI = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C92490", Offset = "0x7C90A90", VA = "0x187C92490")]
	public static RenderTexture FLLMCNLHKNL(int FBOHPNPLBLA, int OEEHMBFMGMF, int PLLHLPGFHPI, RenderTextureFormat CKHLMMECGLE, [Out] ICAPOKGAKKK BOJCEMEJOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3657430", Offset = "0x3655A30", VA = "0x183657430")]
	public static NativeArray<T> LOHIENLBALN<T>(NativeArray<T> LJEENFPIGIA, ulong DDGBDMFPMAI, [Out] ICAPOKGAKKK BOJCEMEJOMP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3657370", Offset = "0x3655970", VA = "0x183657370")]
	public static NativeArray<T> FLLMCNLHKNL<T>(int DDGBDMFPMAI, Allocator NDFENJBGNOB, [Out] ICAPOKGAKKK BOJCEMEJOMP, NativeArrayOptions BFEGEHMOFBB = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C929F0", Offset = "0x7C90FF0", VA = "0x187C929F0")]
	public static void HMHHJKJOIHP(ICAPOKGAKKK LJEENFPIGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C92BF0", Offset = "0x7C911F0", VA = "0x187C92BF0")]
	public static uint PCGHJLFDBIF(RenderTextureFormat CKHLMMECGLE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BJNPEIFHMFL : BAJPOBIKNLG<DAKFDDHIPOB, DAKFDDHIPOB>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct PKMNPJCMCFL : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<int> ABMJALLLICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[ReadOnly]
		private NativeArray<float> IOGCLMMCMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4x4> BPEGFOFEMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[WriteOnly]
		private NativeArray<float4> JHKNMNGCMML;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C95170", Offset = "0x7C93770", VA = "0x187C95170")]
		public PKMNPJCMCFL(NativeArray<int> KOFLOMJIBAI, NativeArray<float> LMBIJCLEJLA, NativeArray<float4x4> LBBIKHHIFIG, NativeArray<float4> BOFBHDIEMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CA15F0", Offset = "0x7C9FBF0", VA = "0x187CA15F0", Slot = "4")]
		public void Execute(int OHHMJGCBCKD, TransformAccess KOOMPFGMBLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[BurstCompile]
	public struct FJIBJKMNJAO : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<int> ABMJALLLICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4x4> BKNDJMPDBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[ReadOnly]
		private NativeArray<float4> CCDBKAKIDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[WriteOnly]
		private NativeArray<DAKFDDHIPOB> CDBFGNKLEFP;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C95170", Offset = "0x7C93770", VA = "0x187C95170")]
		public FJIBJKMNJAO(NativeArray<int> KOFLOMJIBAI, NativeArray<float4x4> MADONELGBIH, NativeArray<float4> HFLJDMEHNBC, NativeArray<DAKFDDHIPOB> ELDDEEODOKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C95100", Offset = "0x7C93700", VA = "0x187C95100", Slot = "4")]
		public void Execute(int OHHMJGCBCKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private const byte GINHBNADACE = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private TransformAccessArray NCBIGMDCCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> NHFNKJACLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4x4> HOGGLBJEAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> KIALNNBNHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> CKMJMKHJCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> OKHHIHBKFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ICAPOKGAKKK HMFGDJJJGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private ICAPOKGAKKK HFEBGHJDEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private ICAPOKGAKKK EGICGMFABPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private ICAPOKGAKKK HMACOEDLHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private ICAPOKGAKKK HJOGMIEJOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private Transform ENAOKGPPFJJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C92170", Offset = "0x7C90770", VA = "0x187C92170")]
	public BJNPEIFHMFL(int OOBLHGFAEBJ, int HDHJPIOPNFE, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C91C90", Offset = "0x7C90290", VA = "0x187C91C90", Slot = "6")]
	protected override void HJFKCJCGOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C920B0", Offset = "0x7C906B0", VA = "0x187C920B0")]
	private void OJEKPKCOHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C91F50", Offset = "0x7C90550", VA = "0x187C91F50")]
	public bool LHFBGCPJGLK(ECMJGPEONGP BOJCEMEJOMP, Transform KOOMPFGMBLG, float FFKAOLHCDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C91BB0", Offset = "0x7C901B0", VA = "0x187C91BB0")]
	public void GGBOEMNIEFF(ECMJGPEONGP BOJCEMEJOMP, float FFKAOLHCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C91EA0", Offset = "0x7C904A0", VA = "0x187C91EA0")]
	public void IGMICFIABOH(ECMJGPEONGP BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C91B10", Offset = "0x7C90110", VA = "0x187C91B10", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KNHDOEOGJOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFNFOCEBPOF MCMIEJOHGAC();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ILDHOPJJLDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 CBNMGIONGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> MJJFMHOFJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> ENMINAOPOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> PEMEIOKOEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> AIFNOFOGIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> JPKMJPHNFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> JPPLGFICOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int GLKEGCPDCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int BNCCMABJCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int KIOEFKKLJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool OCFHLMENICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FIADEAHHAAD();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AFNOGHDFBEH : ILDHOPJJLDN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KNHDOEOGJOI OAFFKBJEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private OFNFOCEBPOF PEPFHNJFNIL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 CBNMGIONGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool NGCMOLJMBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int FLOPHDADGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x13C0D50", Offset = "0x13BF350", VA = "0x1813C0D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> MJJFMHOFJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C91720", Offset = "0x7C8FD20", VA = "0x187C91720", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> ENMINAOPOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C91540", Offset = "0x7C8FB40", VA = "0x187C91540", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> PEMEIOKOEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C91790", Offset = "0x7C8FD90", VA = "0x187C91790", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> AIFNOFOGIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C91570", Offset = "0x7C8FB70", VA = "0x187C91570", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> JPKMJPHNFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C916F0", Offset = "0x7C8FCF0", VA = "0x187C916F0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> JPPLGFICOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C917F0", Offset = "0x7C8FDF0", VA = "0x187C917F0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OCFHLMENICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int GLKEGCPDCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C917E0", Offset = "0x7C8FDE0", VA = "0x187C917E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BNCCMABJCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C917C0", Offset = "0x7C8FDC0", VA = "0x187C917C0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int KIOEFKKLJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C91820", Offset = "0x7C8FE20", VA = "0x187C91820", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C91840", Offset = "0x7C8FE40", VA = "0x187C91840")]
	public AFNOGHDFBEH(Hash128 CNOOJBJPLMK, KNHDOEOGJOI OAFFKBJEEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C915E0", Offset = "0x7C8FBE0", VA = "0x187C915E0", Slot = "16")]
	public void FIADEAHHAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C914B0", Offset = "0x7C8FAB0", VA = "0x187C914B0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ECMJGPEONGP : IEquatable<ECMJGPEONGP>
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly ECMJGPEONGP CABIBLEKJPN;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0")]
	public ECMJGPEONGP(int OHHMJGCBCKD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C94CE0", Offset = "0x7C932E0", VA = "0x187C94CE0", Slot = "4")]
	public bool Equals(ECMJGPEONGP MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C94D30", Offset = "0x7C93330", VA = "0x187C94D30", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C94E00", Offset = "0x7C93400", VA = "0x187C94E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DGNHHNGONDN : ADCOPGKOHIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool JHMICNKGFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private ILDHOPJJLDN DGEJCOALNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<ECMJGPEONGP> IMENBINNIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<ECMJGPEONGP> LHNNNOLNOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private List<ECMJGPEONGP> EPLLGLEDNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Dictionary<int, uint> HJHLMBPPALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int NPGNODKKKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int PCGPKCCHANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int JDCLPFKFBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int NOGGDEMIJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int FFPGICIMBIP;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C94020", Offset = "0x7C92620", VA = "0x187C94020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C94B30", Offset = "0x7C93130", VA = "0x187C94B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DBCHBGPDGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool PANKKJMNEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7F0", Offset = "0xC8DDF0", VA = "0x180C8F7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC8F730", Offset = "0xC8DD30", VA = "0x180C8F730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool NKEOBBMJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2731330", Offset = "0x272F930", VA = "0x182731330", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x26149D0", Offset = "0x2612FD0", VA = "0x1826149D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float ECCBMHJNPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xEC1FF0", Offset = "0xEC05F0", VA = "0x180EC1FF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xEC2000", Offset = "0xEC0600", VA = "0x180EC2000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C94B70", Offset = "0x7C93170", VA = "0x187C94B70")]
	public DGNHHNGONDN(ILDHOPJJLDN PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C93B50", Offset = "0x7C92150", VA = "0x187C93B50")]
	private void GNODOHNKHOB(ILDHOPJJLDN PEPFHNJFNIL, int NPGNODKKKAD, int KJAIKDOLEIC, int OHHMJGCBCKD, int DEHGOLACCLG, AJGNEJGABLI APDBNIMCPID, float GPGPLDEIALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C92F40", Offset = "0x7C91540", VA = "0x187C92F40")]
	private void AANKJJMGBCA(ILDHOPJJLDN PEPFHNJFNIL, int DGBDABFAJCO, int OHHMJGCBCKD, uint3 LLEFPNDFNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C93200", Offset = "0x7C91800", VA = "0x187C93200")]
	private bool CCECGMBPCHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C94150", Offset = "0x7C92750", VA = "0x187C94150", Slot = "4")]
	public bool IIGLPCDPOEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C940D0", Offset = "0x7C926D0", VA = "0x187C940D0", Slot = "5")]
	public bool IEKHBJGOAKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C93500", Offset = "0x7C91B00", VA = "0x187C93500", Slot = "6")]
	public void GNAALOCCJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C934A0", Offset = "0x7C91AA0", VA = "0x187C934A0")]
	public void PBMNHNDBLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C934A0", Offset = "0x7C91AA0", VA = "0x187C934A0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ADCOPGKOHIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool NKEOBBMJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIGLPCDPOEE();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IEKHBJGOAKB();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNAALOCCJEL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HOOPAPBEFIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly float BMLLDLKOKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, DGNHHNGONDN> EGGPIMAONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Dictionary<Hash128, MOECHNGGONK> FNMPPPIICNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<ADCOPGKOHIL> BOGIGIAEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<ADCOPGKOHIL> EIOKHLHMBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Queue<ADCOPGKOHIL> GIGPCJBHHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int ENMOIOHEBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private int FALOJMMOJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float CJBGOMLFMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool JDKAMBIEHIM;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool HFIGNODBLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1680F00", Offset = "0x167F500", VA = "0x181680F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x168CC80", Offset = "0x168B280", VA = "0x18168CC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CBCABKOBHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C961A0", Offset = "0x7C947A0", VA = "0x187C961A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string DOBBIJAKKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C95E00", Offset = "0x7C94400", VA = "0x187C95E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C961F0", Offset = "0x7C947F0", VA = "0x187C961F0")]
	public void OFGJGDCILIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C95DD0", Offset = "0x7C943D0", VA = "0x187C95DD0")]
	public void HMKLLDCFOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C962C0", Offset = "0x7C948C0", VA = "0x187C962C0")]
	public HOOPAPBEFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C955C0", Offset = "0x7C93BC0", VA = "0x187C955C0")]
	public LGJOMFGAFNG AMBIAOGNIIF(BJHBGAPNKPE ELJDCHFNJGK, bool EPPKCOCHJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C95480", Offset = "0x7C93A80", VA = "0x187C95480")]
	public MOECHNGGONK AMBIAOGNIIF(BJJJCPEHCID CANJBFKPEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C958B0", Offset = "0x7C93EB0", VA = "0x187C958B0")]
	public bool FCOMGNIDDIE(Hash128 HJPLNJNIFLL, [Out] DGNHHNGONDN PLPNBELCDBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C951A0", Offset = "0x7C937A0", VA = "0x187C951A0")]
	public DGNHHNGONDN AMBIAOGNIIF(ILDHOPJJLDN PEPFHNJFNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C95DE0", Offset = "0x7C943E0", VA = "0x187C95DE0")]
	private void JKDNJINFDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C96200", Offset = "0x7C94800", VA = "0x187C96200")]
	private bool OPAEGPCPPBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7C95920", Offset = "0x7C93F20", VA = "0x187C95920")]
	public void FIADEAHHAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C957A0", Offset = "0x7C93DA0", VA = "0x187C957A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C956F0", Offset = "0x7C93CF0", VA = "0x187C956F0")]
	public void AOJNBLCPAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ELILNLEMPGI : BAJPOBIKNLG<MJLPDFKAKBF, MJLPDFKAKBF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C94E90", Offset = "0x7C93490", VA = "0x187C94E90")]
	public ELILNLEMPGI(int OOBLHGFAEBJ, int HDHJPIOPNFE, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DDALAEGOHPG : BAJPOBIKNLG<JKFIKAOELPB, JKFIKAOELPB>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C92E90", Offset = "0x7C91490", VA = "0x187C92E90")]
	public DDALAEGOHPG(int OOBLHGFAEBJ, int HDHJPIOPNFE, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MKEHDABKKNJ : BAJPOBIKNLG<OKKENDMKKEA, OKKENDMKKEA>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C994F0", Offset = "0x7C97AF0", VA = "0x187C994F0")]
	public MKEHDABKKNJ(int OOBLHGFAEBJ, int HDHJPIOPNFE, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OPECOMEKBCD : BAJPOBIKNLG<OPMBPNJKHPO, ANPFMNEGHPA>
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C99DC0", Offset = "0x7C983C0", VA = "0x187C99DC0")]
	public OPECOMEKBCD(int OOBLHGFAEBJ, int HDHJPIOPNFE, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NGAEBDDJCNO : BAJPOBIKNLG<PIHNNHOHNCN, PIHNNHOHNCN>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C99C60", Offset = "0x7C98260", VA = "0x187C99C60")]
	public NGAEBDDJCNO(int OOBLHGFAEBJ, int HDHJPIOPNFE, ComputeShader KMPEJCIEICJ, int EHHEPGKEPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class PBIKBFEIGLM : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private PFGAMGNPFAE FELJFFENAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool BFEIIPBAHBE;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static bool DFBDJAPOACI;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A270", Offset = "0x7C98870", VA = "0x187C9A270")]
	public PBIKBFEIGLM(PFGAMGNPFAE HOKIOBICEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A0E0", Offset = "0x7C986E0", VA = "0x187C9A0E0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer HKEOEPNOEKP, RenderingData KEFIEFNNIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C99E70", Offset = "0x7C98470", VA = "0x187C99E70", Slot = "6")]
	public override void Configure(CommandBuffer HKEOEPNOEKP, RenderTextureDescriptor BLBOABPEGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C99EB0", Offset = "0x7C984B0", VA = "0x187C99EB0", Slot = "9")]
	public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class MHAAOFFDGOP
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct EPJLAIIOHIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string NFHOBPDKIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CommandBuffer HKEOEPNOEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly ScriptableRenderContext INLEBAAACKH;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C94FF0", Offset = "0x7C935F0", VA = "0x187C94FF0")]
		public EPJLAIIOHIN(string CILAIABOEGE, ScriptableRenderContext AIPEMICLLLB, [Out] CommandBuffer CGEBPIBHJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C94F40", Offset = "0x7C93540", VA = "0x187C94F40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C98C40", Offset = "0x7C97240", VA = "0x187C98C40")]
	public static bool DMDAHPIHCBO(RenderingData KEFIEFNNIGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C98FF0", Offset = "0x7C975F0", VA = "0x187C98FF0")]
	public static void PMGOEHKFFPJ(CommandBuffer HKEOEPNOEKP, ScriptableRenderContext INLEBAAACKH, ShadowDrawingSettings OHPJOMKGGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C98D90", Offset = "0x7C97390", VA = "0x187C98D90")]
	public static void OANABNHJLDJ(CommandBuffer HKEOEPNOEKP, ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PFGAMGNPFAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class KKJEODLFFGF
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int MKFJEIPMEOA;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly int KGNPGKOBGPH;
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static GMAOMEIHKFB<MBEFPJKMLDE> ACHPFFKJEME;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static GMAOMEIHKFB<uint> NAPKDFAAHGE;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ICAPOKGAKKK CJFLNMOACIK;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static ComputeBuffer MLMIPMJNHDO;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static List<KKPHENGCNFL> HNHHJKPCEEB;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int CIICJFOCJMC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int BILMNJAECGK;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int MBIPJJMHNDG;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int AKCFGMPDPBJ;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int[] HGDEOGJNIBL;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static Material[] FDIIDIACIPM;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static PBBIEIOAEPN[][] DBDLJOPEGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Plane[] EGJDAHJJABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int PIBIEDJBDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int EOCPCINBFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int IEDEFMDBCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int LOKALLMPAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int LOJGCHDIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int OLFOCAFAAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int KIEJCLDNEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int EDCCMPCOLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int ODLFMBFINME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int IGDKCDGHPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int GOCMCMBDBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int GDNEMCLHLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int AKPDMLHOAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int CMCGCAMNAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int LMHPMMDNEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int LBLBPPDCAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int JBNKCGFMGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int EKPEDPHPFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float[] CPLOBLAKLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private HOOPAPBEFIK BKNLCLOHHKL;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool NPPPOBAOHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CBC0", Offset = "0x7C9B1C0", VA = "0x187C9CBC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C610", Offset = "0x7C9AC10", VA = "0x187C9C610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool GPOCLAPJNHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C4E0", Offset = "0x7C9AAE0", VA = "0x187C9C4E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0100", Offset = "0x7C9E700", VA = "0x187CA0100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F9B0", Offset = "0x7C9DFB0", VA = "0x187C9F9B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BA70", Offset = "0x7C9A070", VA = "0x187C9BA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static BJNPEIFHMFL PFPOECJGFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C9FA50", Offset = "0x7C9E050", VA = "0x187C9FA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D850", Offset = "0x7C9BE50", VA = "0x187C9D850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static ELILNLEMPGI PANEAOMJBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F960", Offset = "0x7C9DF60", VA = "0x187C9F960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D970", Offset = "0x7C9BF70", VA = "0x187C9D970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static DDALAEGOHPG MIFPGGLIFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E990", Offset = "0x7C9CF90", VA = "0x187C9E990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C5A0", Offset = "0x7C9ABA0", VA = "0x187C9C5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static MKEHDABKKNJ MEBHCAOCENB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BAE0", Offset = "0x7C9A0E0", VA = "0x187C9BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C9FB00", Offset = "0x7C9E100", VA = "0x187C9FB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static OPECOMEKBCD PPDMIHKHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CA00B0", Offset = "0x7C9E6B0", VA = "0x187CA00B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C470", Offset = "0x7C9AA70", VA = "0x187C9C470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static NGAEBDDJCNO LAKDMFFJPCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D8C0", Offset = "0x7C9BEC0", VA = "0x187C9D8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E9E0", Offset = "0x7C9CFE0", VA = "0x187C9E9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material OMDGNCGHAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C7F0", Offset = "0x7C9ADF0", VA = "0x187C9C7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F8F0", Offset = "0x7C9DEF0", VA = "0x187C9F8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material BDDLGBDCLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C9FA00", Offset = "0x7C9E000", VA = "0x187C9FA00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F1F0", Offset = "0x7C9D7F0", VA = "0x187C9F1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material GNEFHOJNEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BB90", Offset = "0x7C9A190", VA = "0x187C9BB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C530", Offset = "0x7C9AB30", VA = "0x187C9C530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material LILPOPGNJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C9EA50", Offset = "0x7C9D050", VA = "0x187C9EA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C840", Offset = "0x7C9AE40", VA = "0x187C9C840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool JGEMOJCNLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7CA05E0", Offset = "0x7C9EBE0", VA = "0x187CA05E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BB30", Offset = "0x7C9A130", VA = "0x187C9BB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool CBCABKOBHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9FAA0", Offset = "0x7C9E0A0", VA = "0x187C9FAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string DOBBIJAKKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C9EAA0", Offset = "0x7C9D0A0", VA = "0x187C9EAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0F90", Offset = "0x7C9F590", VA = "0x187CA0F90")]
	internal PFGAMGNPFAE([Optional] MClusterData JBLOENGHGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A750", Offset = "0x7C98D50", VA = "0x187C9A750")]
	public void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F150", Offset = "0x7C9D750", VA = "0x187C9F150")]
	public void KMNBBKKBJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D910", Offset = "0x7C9BF10", VA = "0x187C9D910")]
	public void GILIPPKPGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E8F0", Offset = "0x7C9CEF0", VA = "0x187C9E8F0")]
	public bool ICJOPBPKANP(Hash128 CNOOJBJPLMK, [Out] DGNHHNGONDN PEPFHNJFNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A690", Offset = "0x7C98C90", VA = "0x187C9A690")]
	public DGNHHNGONDN AMBIAOGNIIF(ILDHOPJJLDN APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A4A0", Offset = "0x7C98AA0", VA = "0x187C9A4A0")]
	public MOECHNGGONK AMBIAOGNIIF(BJJJCPEHCID CANJBFKPEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A2E0", Offset = "0x7C988E0", VA = "0x187C9A2E0")]
	public LGJOMFGAFNG AMBIAOGNIIF(BJHBGAPNKPE ELJDCHFNJGK, bool EPPKCOCHJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D920", Offset = "0x7C9BF20", VA = "0x187C9D920")]
	public void GNAALOCCJEL(ADCOPGKOHIL OHDGCHLKIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F260", Offset = "0x7C9D860", VA = "0x187C9F260")]
	public static void LDNIIACGPDH(FMLALOECOHN JGGBDGJFMCJ, PBBIEIOAEPN[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0630", Offset = "0x7C9EC30", VA = "0x187CA0630")]
	private void POHKHEEHFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CC10", Offset = "0x7C9B210", VA = "0x187C9CC10")]
	private static void FOLFENJFGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C8B0", Offset = "0x7C9AEB0", VA = "0x187C9C8B0")]
	public void FDPAOGIFJFM(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BBE0", Offset = "0x7C9A1E0", VA = "0x187C9BBE0")]
	public void BLLAHLAFAMD([Optional] ScriptableRenderContext? INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F340", Offset = "0x7C9D940", VA = "0x187C9F340")]
	public void LIEICMLJABB(CommandBuffer HKEOEPNOEKP, ShadowSplitData LPGNBALNAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F610", Offset = "0x7C9DC10", VA = "0x187C9F610")]
	public void LIEICMLJABB(CommandBuffer HKEOEPNOEKP, CameraData FHFBKODOAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FB70", Offset = "0x7C9E170", VA = "0x187C9FB70")]
	public void OGFBPMPJNKD(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C670", Offset = "0x7C9AC70", VA = "0x187C9C670")]
	public void DPFHOFGBDPF(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0160", Offset = "0x7C9E760", VA = "0x187CA0160")]
	public void PIANFKGBDKJ(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BDB0", Offset = "0x7C9A3B0", VA = "0x187C9BDB0")]
	public void CFNPCBKGFHG(CommandBuffer HKEOEPNOEKP, FMLALOECOHN HHMNOKNDOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C390", Offset = "0x7C9A990", VA = "0x187C9C390")]
	public void CHODBLKANMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D9E0", Offset = "0x7C9BFE0", VA = "0x187C9D9E0")]
	public void HMHHJKJOIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C6E0", Offset = "0x7C9ACE0", VA = "0x187C9C6E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BMCIDHAAEAI
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x26CCA20", Offset = "0x26CB020", VA = "0x1826CCA20")]
	public static int GPAPEEHOHJI(int DEBKJNNAPAB, int KMKJHPKIHOH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DAKFDDHIPOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4x4 LFJADKJJHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float4 BPFJBMNEJJK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly DAKFDDHIPOB MCPPCDBNCIC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly DAKFDDHIPOB CABIBLEKJPN;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7C92E60", Offset = "0x7C91460", VA = "0x187C92E60")]
	public DAKFDDHIPOB(float4x4 EDNEHFNBEKB, float4 DICNIEPGKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C92D00", Offset = "0x7C91300", VA = "0x187C92D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct AJGNEJGABLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 EPCLGOKLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 HPAMHMBDLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 OFDPNDMFOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 HFMKPCPKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 CPKLFAAODIJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NBJLLGEGJJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float4 EPCLGOKLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 HPAMHMBDLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 OFDPNDMFOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 HFMKPCPKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public half4 CPKLFAAODIJ;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct ANPFMNEGHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NBJLLGEGJJF HGMEHCAFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NBJLLGEGJJF NJMHIIIKNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NBJLLGEGJJF KMIJGIJJEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NBJLLGEGJJF FIBILCEGONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NBJLLGEGJJF CEINBHFBLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public NBJLLGEGJJF KIJADBELMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public NBJLLGEGJJF LDOIDLMGCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public NBJLLGEGJJF FBDOKFNLGFP;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct OPMBPNJKHPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public AJGNEJGABLI HGMEHCAFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public AJGNEJGABLI NJMHIIIKNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AJGNEJGABLI KMIJGIJJEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public AJGNEJGABLI FIBILCEGONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public AJGNEJGABLI CEINBHFBLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public AJGNEJGABLI KIJADBELMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public AJGNEJGABLI LDOIDLMGCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public AJGNEJGABLI FBDOKFNLGFP;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JKFIKAOELPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float4 BCJBJCJEEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint CHMKOMKIOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public uint IKGHDBJPNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float KDDONEOCMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint NPHLKDHKNPE;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7C96480", Offset = "0x7C94A80", VA = "0x187C96480")]
	public JKFIKAOELPB(BJJJCPEHCID CANJBFKPEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MBEFPJKMLDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint KFKPMMIEBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint HFLJGPFBIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint DEHGOLACCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint NPHLKDHKNPE;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C980D0", Offset = "0x7C966D0", VA = "0x187C980D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct OKKENDMKKEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint KJAIKDOLEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint MALCCEOLKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint PCGPKCCHANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint NPHLKDHKNPE;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7C99D10", Offset = "0x7C98310", VA = "0x187C99D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MJLPDFKAKBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint KMLNOHKPNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint KDKJNIIDEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint JBFEEAPDDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint FLHOPCGIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint KBPAGONOABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint LPODKABIGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint LHFADIKLIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint NPHLKDHKNPE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7C991C0", Offset = "0x7C977C0", VA = "0x187C991C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PIHNNHOHNCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 OGLGEJJHHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 INLAKBDEHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 NBIALLNEFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 HEMKMGCPEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 LIIGBGCHKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 LFCADPMNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 HGHDFFKHHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public uint3 JCDLHMIFOOP;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA11F0", Offset = "0x7C9F7F0", VA = "0x187CA11F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum FMLALOECOHN
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
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
