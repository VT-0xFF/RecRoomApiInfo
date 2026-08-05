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
public struct EHFIGEGFEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] DKGOBJPNEDN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] KEAPMHBLFLH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] BEKAIBBFFBE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xE29C50", Offset = "0xE28250", VA = "0x180E29C50")]
	public static int EDFIMEIJDON(LELBMHHLIBD ABCPPKFGKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A58660", Offset = "0x6A56C60", VA = "0x186A58660")]
	public static int MIILJCHJBCI(LELBMHHLIBD ABCPPKFGKJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OFCJLJNJKMA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IKIKHGHIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NOOKLLFGOEC IOLKHHHPIKD(int HEPMKAJPNDG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 BDMFLIFKCGI(int HEPMKAJPNDG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ANOGDKLDLNH EEBMMMJDODL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DGLDHLPMLHH EOINAEDJIJF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BIMFFKCCPBN : FJJNIGCHCEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ANOGDKLDLNH AFJHLFMCCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform CCELKHHCKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<IPIHBBBPAIJ> FHMNGKNIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private OEHNGAEBPAC LLBPCKFOMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FDJCIKGMECA CNOAIHPDKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool GCGCAHBHHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OFCJLJNJKMA OKBEEKBOIPD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float ODPNGOLOGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F7680", Offset = "0x8F5C80", VA = "0x1808F7680")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAE9650", Offset = "0xAE7C50", VA = "0x180AE9650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EIHENPAKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3430", Offset = "0x9F1A30", VA = "0x1809F3430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F34E0", Offset = "0x9F1AE0", VA = "0x1809F34E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CMNEKACMHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1263A80", Offset = "0x1262080", VA = "0x181263A80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1263270", Offset = "0x1261870", VA = "0x181263270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KEFAIPMPDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60E3F70", Offset = "0x60E2570", VA = "0x1860E3F70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60E3EF0", Offset = "0x60E24F0", VA = "0x1860E3EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JGGIBHLMALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x140EA50", Offset = "0x140D050", VA = "0x18140EA50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F210", Offset = "0x6A4D810", VA = "0x186A4F210")]
	public BIMFFKCCPBN(OFCJLJNJKMA GBGLBCFHOAO, bool NBAHJJOPPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DFC0", Offset = "0x6A4C5C0", VA = "0x186A4DFC0")]
	private bool EEOLGOJMLLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E5E0", Offset = "0x6A4CBE0", VA = "0x186A4E5E0", Slot = "4")]
	public bool LHEPNGLDBLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E410", Offset = "0x6A4CA10", VA = "0x186A4E410", Slot = "5")]
	public bool JPIODFAGAAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E1E0", Offset = "0x6A4C7E0", VA = "0x186A4E1E0", Slot = "6")]
	public void HHOKGKJNBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DFB0", Offset = "0x6A4C5B0", VA = "0x186A4DFB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CIIECIDLEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLBIOJFAOBG(CommandBuffer MGGOHHEBAAI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PNGDILCLAIJ : CIIECIDLEIM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int LAALHOAJCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier DLKCAPDGDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x42B0820", Offset = "0x42AEE20", VA = "0x1842B0820")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E2D0", Offset = "0x6A5C8D0", VA = "0x186A5E2D0")]
	public PNGDILCLAIJ(int DAIJJLLIENA, RenderTargetIdentifier MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E280", Offset = "0x6A5C880", VA = "0x186A5E280", Slot = "4")]
	public void FLBIOJFAOBG(CommandBuffer MGGOHHEBAAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct AMDEJPCMOHC : CIIECIDLEIM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int LAALHOAJCIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] KCHIDKPAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xDF1F20", Offset = "0xDF0520", VA = "0x180DF1F20")]
	public AMDEJPCMOHC(int DAIJJLLIENA, Vector4[] MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DD30", Offset = "0x6A4C330", VA = "0x186A4DD30", Slot = "4")]
	public void FLBIOJFAOBG(CommandBuffer MGGOHHEBAAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OGBOFOMOKPJ : CIIECIDLEIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int LAALHOAJCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] KOMPPNCDKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xDF1F20", Offset = "0xDF0520", VA = "0x180DF1F20")]
	public OGBOFOMOKPJ(int DAIJJLLIENA, float[] MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DD60", Offset = "0x6A5C360", VA = "0x186A5DD60", Slot = "4")]
	public void FLBIOJFAOBG(CommandBuffer MGGOHHEBAAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JCHKMIJGHOD : CIIECIDLEIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool FKKNICKBACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1C13460", Offset = "0x1C11A60", VA = "0x181C13460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4EA0", Offset = "0x3CB34A0", VA = "0x183CB4EA0")]
	public JCHKMIJGHOD(string GJEDHMJMNJA, bool PCJPKCENFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B8D0", Offset = "0x6A59ED0", VA = "0x186A5B8D0", Slot = "4")]
	public void FLBIOJFAOBG(CommandBuffer MGGOHHEBAAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DGLDHLPMLHH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 KINAJNBDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 JMPDCNENADA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NKHJNMMMCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GHGMCIIAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C50", Offset = "0x8A4250", VA = "0x1808A5C50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CADJKEGGEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F76E0", Offset = "0x8F5CE0", VA = "0x1808F76E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FF80", Offset = "0x6A4E580", VA = "0x186A4FF80")]
	public DGLDHLPMLHH(Color PHHAMGLLFIF, int CAEEPIMAMPB, int ECLABNAHOPL, float FANJHLFJCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9684E0", Offset = "0x966AE0", VA = "0x1809684E0")]
	private static float4 NMCIKNLFIJN(Color PHHAMGLLFIF)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FEF0", Offset = "0x6A4E4F0", VA = "0x186A4FEF0")]
	private static Hash128 CJDOPKGHJDO(DGLDHLPMLHH GBGLBCFHOAO)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OEHNGAEBPAC : FJJNIGCHCEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string FCPDMMCEENE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string KFPNJBKEDAD;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string CDMMDFOCEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private DGLDHLPMLHH ACIAOICAANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private MLMFDLFNEME OLKLLNJBJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 AOGCFKHADBE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FDJCIKGMECA KGJIHBGKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88DFF0", Offset = "0x88C5F0", VA = "0x18088DFF0")]
		[CompilerGenerated]
		get
		{
			return default(FDJCIKGMECA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB03920", Offset = "0xB01F20", VA = "0x180B03920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EIHENPAKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5A526C0", Offset = "0x5A50CC0", VA = "0x185A526C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5A526D0", Offset = "0x5A50CD0", VA = "0x185A526D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CMNEKACMHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A020", Offset = "0x1F68620", VA = "0x181F6A020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69E5370", Offset = "0x69E3970", VA = "0x1869E5370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JGGIBHLMALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KEFAIPMPDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A370", Offset = "0x5B08970", VA = "0x185B0A370", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A5D760", Offset = "0x6A5BD60", VA = "0x186A5D760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A5D4B0", Offset = "0x6A5BAB0", VA = "0x186A5D4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DB60", Offset = "0x6A5C160", VA = "0x186A5DB60")]
	public OEHNGAEBPAC(DGLDHLPMLHH PNFNIMBCPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D540", Offset = "0x6A5BB40", VA = "0x186A5D540")]
	private bool EEOLGOJMLLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D920", Offset = "0x6A5BF20", VA = "0x186A5D920", Slot = "4")]
	public bool LHEPNGLDBLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D500", Offset = "0x6A5BB00", VA = "0x186A5D500")]
	private static MLMFDLFNEME DLGJKMNJJOD(DGLDHLPMLHH GBGLBCFHOAO)
	{
		return default(MLMFDLFNEME);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D770", Offset = "0x6A5BD70", VA = "0x186A5D770", Slot = "5")]
	public bool JPIODFAGAAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D650", Offset = "0x6A5BC50", VA = "0x186A5D650", Slot = "6")]
	public void HHOKGKJNBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C1E0", Offset = "0x6A5A7E0", VA = "0x186A5C1E0", Slot = "0")]
		public override bool Equals(object BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C3E0", Offset = "0x6A5A9E0", VA = "0x186A5C3E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F7720", Offset = "0x8F5D20", VA = "0x1808F7720")]
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
		private OPHJNBMOHIO opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static EAONDHGDGOL CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6A5CAB0", Offset = "0x6A5B0B0", VA = "0x186A5CAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6A5CAF0", Offset = "0x6A5B0F0", VA = "0x186A5CAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C4C0", Offset = "0x6A5AAC0", VA = "0x186A5C4C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C490", Offset = "0x6A5AA90", VA = "0x186A5C490", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PGOGAFFEFPG, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C920", Offset = "0x6A5AF20", VA = "0x186A5C920")]
		public void OKKHCHOKANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xDD2370", Offset = "0xDD0970", VA = "0x180DD2370")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OKMPOJHPPDI<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private AIENKGAGFMF LPAFLDBMLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private AIENKGAGFMF IJBDIKEHIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer HHGCAOHPMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture NMIJAKPOKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int JKPLBOGDCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int DOCGMCGOBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string DBJCBHGIKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string BINAANAPGIE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x874B30", Offset = "0x873130", VA = "0x180874B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BGPMADEMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDF4850", Offset = "0xDF2E50", VA = "0x180DF4850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JAOICNOAOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x884A00", Offset = "0x883000", VA = "0x180884A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46E31A0", Offset = "0x46E17A0", VA = "0x1846E31A0")]
	public OKMPOJHPPDI(string GJEDHMJMNJA, int FLMFNHMBNKN, [Optional] RenderTextureFormat? MLEOMJOOIIP, bool PEHOHKFGKNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46E0E70", Offset = "0x46DF470", VA = "0x1846E0E70")]
	public void JPIODFAGAAF(CommandBuffer MGGOHHEBAAI, NativeArray<ValType> MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x46E2B70", Offset = "0x46E1170", VA = "0x1846E2B70")]
	public void LJACJNPNEDK(CommandBuffer MGGOHHEBAAI, ComputeShader NJAJFOGPCNK, int KGHOACBKPGL, int NMLBKLLBBOE = -1, int EBAPFNAHEPN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x46E2AA0", Offset = "0x46E10A0", VA = "0x1846E2AA0")]
	public void LJACJNPNEDK(Material OLKLLNJBJND, int NMLBKLLBBOE = -1, int EBAPFNAHEPN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x46E0DA0", Offset = "0x46DF3A0", VA = "0x1846E0DA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KNHKODIINNL
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJACJNPNEDK(Material PNFNIMBCPGN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IEJPIAILIJG<SrcEntry, DstEntry> : KNHKODIINNL, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] LADFENHIEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected AIENKGAGFMF OHCDPLOPCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected AIENKGAGFMF JKPODACBBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> BHJCFKOLIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> JCLFECEJGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int IGHPDHNMNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int HNGDCHDBNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected OKMPOJHPPDI<int> CLOBADIJNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected OKMPOJHPPDI<SrcEntry> CFMIPFDLEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected OKMPOJHPPDI<DstEntry> JDHIEBAGKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader OJHODHEGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int MEIIPLHEFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int LEOAAPBAMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int BLCDHONFABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int MNLJGLLJEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int ALGJPBJABAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int DHFKFNIKAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int GICHJLGDIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int NHNELOEOGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int FNDDAGLHBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int HEODJJDDBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int JHBIOKDPPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int JHONBPFAFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string JHJGDNBEMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] OODPEGOLDFJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int LDAFFHKGGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3E5FEB0", Offset = "0x3E5E4B0", VA = "0x183E5FEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string NMEENIHBGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3E60410", Offset = "0x3E5EA10", VA = "0x183E60410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E61D50", Offset = "0x3E60350", VA = "0x183E61D50")]
	public IEJPIAILIJG(string GJEDHMJMNJA, int GEEOEHKGGHC, int CKGKCNOKOJB, RenderTextureFormat MLEOMJOOIIP, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM = 0, int JBOEOCAHPNA = 0, int ALPEDDLPOEO = 0, int JJMJNFAPMME = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FE40", Offset = "0x3E5E440", VA = "0x183E5FE40")]
	public int DDIIKOOGJMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E600E0", Offset = "0x3E5E6E0", VA = "0x183E600E0")]
	protected void GBJHOOBAGFE(int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3E612E0", Offset = "0x3E5F8E0", VA = "0x183E612E0")]
	public FDJCIKGMECA LHEPNGLDBLI(SrcEntry MMDLBEBNCGC)
	{
		return default(FDJCIKGMECA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3E60F30", Offset = "0x3E5F530", VA = "0x183E60F30")]
	public bool JPIODFAGAAF(FDJCIKGMECA FPDGNDMPHII, SrcEntry MMDLBEBNCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E60770", Offset = "0x3E5ED70", VA = "0x183E60770")]
	public bool HHOKGKJNBNI(FDJCIKGMECA FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "6")]
	protected virtual void BGGCNAFMEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3E60ED0", Offset = "0x3E5F4D0", VA = "0x183E60ED0", Slot = "7")]
	public void JABJBLADNFJ(CommandBuffer MGGOHHEBAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3E60B60", Offset = "0x3E5F160", VA = "0x183E60B60", Slot = "8")]
	public void JABJBLADNFJ(CommandBuffer MGGOHHEBAAI, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM = -1, int JBOEOCAHPNA = -1, int ALPEDDLPOEO = -1, int JJMJNFAPMME = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3E61650", Offset = "0x3E5FC50", VA = "0x183E61650", Slot = "9")]
	public void LJACJNPNEDK(CommandBuffer MGGOHHEBAAI, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3E61800", Offset = "0x3E5FE00", VA = "0x183E61800", Slot = "4")]
	public void LJACJNPNEDK(Material OLKLLNJBJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FFD0", Offset = "0x3E5E5D0", VA = "0x183E5FFD0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AIENKGAGFMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong MODHCKBFCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong CHEOJKBPBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CLKBJANKFOM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct KCKIKJOKGHJ : AIENKGAGFMF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable MCJNLHJBMKC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong MODHCKBFCLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6215D00", Offset = "0x6214300", VA = "0x186215D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong CHEOJKBPBBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4D30040", Offset = "0x4D2E640", VA = "0x184D30040")]
		internal KCKIKJOKGHJ(IDisposable PIJAMGCJHJI, ulong BGGHMBDDEAD, ulong NEHBLGFAAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B9E0", Offset = "0x6A59FE0", VA = "0x186A5B9E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JOKEOPJADPO : AIENKGAGFMF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture GKANJIFOEFC;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong MODHCKBFCLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6215D00", Offset = "0x6214300", VA = "0x186215D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong CHEOJKBPBBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B9B0", Offset = "0x6A59FB0", VA = "0x186A5B9B0")]
		public JOKEOPJADPO(RenderTexture CNANONHDMPK, ulong BKFILCBDOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B910", Offset = "0x6A59F10", VA = "0x186A5B910", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong BCJNEHNJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FB20", Offset = "0x6A4E120", VA = "0x186A4FB20")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F890", Offset = "0x6A4DE90", VA = "0x186A4F890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong NJFBAOEPNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FB60", Offset = "0x6A4E160", VA = "0x186A4FB60")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F850", Offset = "0x6A4DE50", VA = "0x186A4F850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F2D0", Offset = "0x6A4D8D0", VA = "0x186A4F2D0")]
	public static ComputeBuffer BBHPEKFPBBP(int BMKFLHFENBJ, int IGACGIBMGCP, ComputeBufferType GOAECDHCJMK, [Out] AIENKGAGFMF FPDGNDMPHII, ComputeBufferMode HIHEPGOGOFO = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F4B0", Offset = "0x6A4DAB0", VA = "0x186A4F4B0")]
	public static RenderTexture BBHPEKFPBBP(int PFOOHGKGLCE, int IBMHEEEDBDM, int FKJAJPCABDK, RenderTextureFormat MLEOMJOOIIP, [Out] AIENKGAGFMF FPDGNDMPHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x29B1580", Offset = "0x29AFB80", VA = "0x1829B1580")]
	public static NativeArray<T> OLMECCBJBEG<T>(NativeArray<T> MCJNLHJBMKC, ulong JOCLJBACIHN, [Out] AIENKGAGFMF FPDGNDMPHII) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x29B14C0", Offset = "0x29AFAC0", VA = "0x1829B14C0")]
	public static NativeArray<T> BBHPEKFPBBP<T>(int JOCLJBACIHN, Allocator KOIILCBLJPK, [Out] AIENKGAGFMF FPDGNDMPHII, NativeArrayOptions EFDCDFNAODA = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F8D0", Offset = "0x6A4DED0", VA = "0x186A4F8D0")]
	public static void IHOPKBJIMEI(AIENKGAGFMF MCJNLHJBMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FA20", Offset = "0x6A4E020", VA = "0x186A4FA20")]
	public static uint JMHJAACPEJE(RenderTextureFormat MLEOMJOOIIP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MDKKPHGBCED : IEJPIAILIJG<BGNBIMEDBNF, BGNBIMEDBNF>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct KDCCGNNGBEJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> EEHCIHGBJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> FCCNFOMJIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> BPPFCDFHADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> MDGDFLKCLEE;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A59590", Offset = "0x6A57B90", VA = "0x186A59590")]
		public KDCCGNNGBEJ(NativeArray<int> JMNJJEPPNOC, NativeArray<float> ANGKOBNBDHP, NativeArray<float4x4> BBMBGBGGCBN, NativeArray<float4> AGMHBKDLHPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BAE0", Offset = "0x6A5A0E0", VA = "0x186A5BAE0", Slot = "4")]
		public void Execute(int PDMMEDBMFPP, TransformAccess AFJHLFMCCIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct GMHALIFLIEJ : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> EEHCIHGBJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> FKFIAFHFHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> IALJIFNOAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<BGNBIMEDBNF> KMAKJGKFKGD;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A59590", Offset = "0x6A57B90", VA = "0x186A59590")]
		public GMHALIFLIEJ(NativeArray<int> JMNJJEPPNOC, NativeArray<float4x4> ICNGOJLFKOE, NativeArray<float4> BBCFGNPAKFH, NativeArray<BGNBIMEDBNF> KEDMKHAFLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A59520", Offset = "0x6A57B20", VA = "0x186A59520", Slot = "4")]
		public void Execute(int PDMMEDBMFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte HJAMMPJAJBL = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray OBONHCBOJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> LADEFGNDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> AGGLPDHLMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> PFFFHMMGMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> BEBOFADPBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> FONIIHHGIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private AIENKGAGFMF GGLLNPPKEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private AIENKGAGFMF CAAAFMAHMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private AIENKGAGFMF KDHGLEINPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private AIENKGAGFMF IBMLJEALLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private AIENKGAGFMF JIJLAKDAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform BLHGHFOKIDG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D1A0", Offset = "0x6A5B7A0", VA = "0x186A5D1A0")]
	public MDKKPHGBCED(int GEEOEHKGGHC, int CKGKCNOKOJB, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CB50", Offset = "0x6A5B150", VA = "0x186A5CB50", Slot = "6")]
	protected override void BGGCNAFMEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D030", Offset = "0x6A5B630", VA = "0x186A5D030")]
	private void HHEBHFAJLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CED0", Offset = "0x6A5B4D0", VA = "0x186A5CED0")]
	public bool GIMCBFFBJKI(FDJCIKGMECA FPDGNDMPHII, Transform AFJHLFMCCIJ, float JEMAMOCDHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CDF0", Offset = "0x6A5B3F0", VA = "0x186A5CDF0")]
	public void FLJOGHMEPBG(FDJCIKGMECA FPDGNDMPHII, float JEMAMOCDHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D0F0", Offset = "0x6A5B6F0", VA = "0x186A5D0F0")]
	public void NDHGOBHGHAP(FDJCIKGMECA FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CD50", Offset = "0x6A5B350", VA = "0x186A5CD50", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NOOKLLFGOEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMKOMDIKKEA OBILMPBHNMC();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DDCHKIJJEBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 KINAJNBDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int ALMEHFENJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> GJMAELHLBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> JCJMLJKLEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> DBHNAIFGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> IKJIMEDIADP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> BDJACNIGAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> ILIFGJOKCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int IIAOHHGKHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int DGKOFBNIJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int HJPKMOHBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool AMBGACJIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JABJBLADNFJ();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LLOEJJBMLCN : DDCHKIJJEBG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NOOKLLFGOEC NKLLDHMOACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private OMKOMDIKKEA CKFPIMAMAKM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 KINAJNBDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD80", Offset = "0x9CE380", VA = "0x1809CFD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool OBGHNKOLBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x868CE0", Offset = "0x8672E0", VA = "0x180868CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int ALMEHFENJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C50", Offset = "0x8A4250", VA = "0x1808A5C50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5800", Offset = "0x8A3E00", VA = "0x1808A5800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86E900", Offset = "0x86CF00", VA = "0x18086E900", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86E8F0", Offset = "0x86CEF0", VA = "0x18086E8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int MHGAEPJHELF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xBA1BE0", Offset = "0xBA01E0", VA = "0x180BA1BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> GJMAELHLBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE90", Offset = "0x6A5A490", VA = "0x186A5BE90", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> JCJMLJKLEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C000", Offset = "0x6A5A600", VA = "0x186A5C000", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> DBHNAIFGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE00", Offset = "0x6A5A400", VA = "0x186A5BE00", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> IKJIMEDIADP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BF90", Offset = "0x6A5A590", VA = "0x186A5BF90", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> BDJACNIGAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C140", Offset = "0x6A5A740", VA = "0x186A5C140", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> ILIFGJOKCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE60", Offset = "0x6A5A460", VA = "0x186A5BE60", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AMBGACJIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C60", Offset = "0x9F5260", VA = "0x1809F6C60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1E7F0", Offset = "0xA1CDF0", VA = "0x180A1E7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int IIAOHHGKHIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE30", Offset = "0x6A5A430", VA = "0x186A5BE30", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DGKOFBNIJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE40", Offset = "0x6A5A440", VA = "0x186A5BE40", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int HJPKMOHBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C170", Offset = "0x6A5A770", VA = "0x186A5C170", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C190", Offset = "0x6A5A790", VA = "0x186A5C190")]
	public LLOEJJBMLCN(Hash128 JEEDPHFPHKM, NOOKLLFGOEC NKLLDHMOACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C030", Offset = "0x6A5A630", VA = "0x186A5C030", Slot = "16")]
	public void JABJBLADNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BF00", Offset = "0x6A5A500", VA = "0x186A5BF00", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FDJCIKGMECA : IEquatable<FDJCIKGMECA>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly FDJCIKGMECA NGHCGFLIPPC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
	public FDJCIKGMECA(int PDMMEDBMFPP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A58F80", Offset = "0x6A57580", VA = "0x186A58F80", Slot = "4")]
	public bool Equals(FDJCIKGMECA BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A58EB0", Offset = "0x6A574B0", VA = "0x186A58EB0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A58FD0", Offset = "0x6A575D0", VA = "0x186A58FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IPIHBBBPAIJ : FJJNIGCHCEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool GCGCAHBHHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private DDCHKIJJEBG BINLFEODBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<FDJCIKGMECA> MOEFIOECCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<FDJCIKGMECA> GPGGIACAKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<FDJCIKGMECA> CGIFHKNLJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> BLKIPCEAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int KJLIFFOOJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int PHNKJDLMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int FCILLBCIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int OCKGMJMLHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int JFBNJMLIFKF;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A59AE0", Offset = "0x6A580E0", VA = "0x186A59AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A59B90", Offset = "0x6A58190", VA = "0x186A59B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EIHENPAKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B83E0", Offset = "0x8B69E0", VA = "0x1808B83E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9E7AA0", Offset = "0x9E60A0", VA = "0x1809E7AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CMNEKACMHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xBD0A60", Offset = "0xBCF060", VA = "0x180BD0A60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xBD0A50", Offset = "0xBCF050", VA = "0x180BD0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool JGGIBHLMALF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KEFAIPMPDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4B32190", Offset = "0x4B30790", VA = "0x184B32190", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x19BD150", Offset = "0x19BB750", VA = "0x1819BD150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float ODPNGOLOGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D80", Offset = "0x8F6380", VA = "0x1808F7D80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D9ABE0", Offset = "0x1D991E0", VA = "0x181D9ABE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B760", Offset = "0x6A59D60", VA = "0x186A5B760")]
	public IPIHBBBPAIJ(DDCHKIJJEBG CKFPIMAMAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B280", Offset = "0x6A59880", VA = "0x186A5B280")]
	private void MHGJBDLACMF(DDCHKIJJEBG CKFPIMAMAKM, int KJLIFFOOJEF, int DCPPFADNGGM, int PDMMEDBMFPP, int OKGPDLCEDDM, HDDOFIFCPMG MMDLBEBNCGC, float JDHNIMIOFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A59BD0", Offset = "0x6A581D0", VA = "0x186A59BD0")]
	private void AMFOKNNBNEA(DDCHKIJJEBG CKFPIMAMAKM, int GNOGOAKMMMB, int PDMMEDBMFPP, uint3 KOJPMOAGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A59F00", Offset = "0x6A58500", VA = "0x186A59F00")]
	private bool EEOLGOJMLLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A890", Offset = "0x6A58E90", VA = "0x186A5A890", Slot = "4")]
	public bool LHEPNGLDBLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A810", Offset = "0x6A58E10", VA = "0x186A5A810", Slot = "5")]
	public bool JPIODFAGAAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A1A0", Offset = "0x6A587A0", VA = "0x186A5A1A0", Slot = "6")]
	public void HHOKGKJNBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A59EA0", Offset = "0x6A584A0", VA = "0x186A59EA0")]
	public void ONFNGNGBAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A59EA0", Offset = "0x6A584A0", VA = "0x186A59EA0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FJJNIGCHCEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JGGIBHLMALF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KEFAIPMPDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHEPNGLDBLI();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JPIODFAGAAF();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHOKGKJNBNI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DLDDDDFPMCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float CGJKHHLBAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, IPIHBBBPAIJ> CFKLJIFIAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, OEHNGAEBPAC> OIDJOHCNADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<FJJNIGCHCEN> HLIDFBFFPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<FJJNIGCHCEN> NFHALDCONNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<FJJNIGCHCEN> NIKDBKPJFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int NEMNKGCCCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int EKAAFNHPHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float BPHAJKOPPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool AGFLDMIFCDP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EEJCNKOMHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDF92D0", Offset = "0xDF78D0", VA = "0x180DF92D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xE00F50", Offset = "0xDFF550", VA = "0x180E00F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GJMODCMJDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A50300", Offset = "0x6A4E900", VA = "0x186A50300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string NMEENIHBGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A50360", Offset = "0x6A4E960", VA = "0x186A50360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A50C00", Offset = "0x6A4F200", VA = "0x186A50C00")]
	public void KGBALPDFPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A50350", Offset = "0x6A4E950", VA = "0x186A50350")]
	public void EKKIFDOOJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A51220", Offset = "0x6A4F820", VA = "0x186A51220")]
	public DLDDDDFPMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A50C80", Offset = "0x6A4F280", VA = "0x186A50C80")]
	public BIMFFKCCPBN NECNOABNHFL(OFCJLJNJKMA ADJKKNJDKEH, bool NBAHJJOPPEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A510A0", Offset = "0x6A4F6A0", VA = "0x186A510A0")]
	public OEHNGAEBPAC NECNOABNHFL(DGLDHLPMLHH OLKLLNJBJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A50C10", Offset = "0x6A4F210", VA = "0x186A50C10")]
	public bool MLBKOEBLDNJ(Hash128 DAIJJLLIENA, [Out] IPIHBBBPAIJ MMIKCLALGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A50DB0", Offset = "0x6A4F3B0", VA = "0x186A50DB0")]
	public IPIHBBBPAIJ NECNOABNHFL(DDCHKIJJEBG CKFPIMAMAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A50710", Offset = "0x6A4ED10", VA = "0x186A50710")]
	private void IOFCMCEKIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A500B0", Offset = "0x6A4E6B0", VA = "0x186A500B0")]
	private bool AEKFELHDIBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A50730", Offset = "0x6A4ED30", VA = "0x186A50730")]
	public void JABJBLADNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A501F0", Offset = "0x6A4E7F0", VA = "0x186A501F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A50140", Offset = "0x6A4E740", VA = "0x186A50140")]
	public void DKCOBMEKFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LLAPPHNEBKC : IEJPIAILIJG<CNAPHHFBLJO, CNAPHHFBLJO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BD50", Offset = "0x6A5A350", VA = "0x186A5BD50")]
	public LLAPPHNEBKC(int GEEOEHKGGHC, int CKGKCNOKOJB, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ELDCFKNAGJN : IEJPIAILIJG<MLMFDLFNEME, MLMFDLFNEME>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A58D50", Offset = "0x6A57350", VA = "0x186A58D50")]
	public ELDCFKNAGJN(int GEEOEHKGGHC, int CKGKCNOKOJB, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FBPHBECKOHE : IEJPIAILIJG<LBMACEHAMEC, LBMACEHAMEC>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A58E00", Offset = "0x6A57400", VA = "0x186A58E00")]
	public FBPHBECKOHE(int GEEOEHKGGHC, int CKGKCNOKOJB, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BDNCCNEEOJD : IEJPIAILIJG<MEOMIFBACMH, IEJGDPNBEGN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DD60", Offset = "0x6A4C360", VA = "0x186A4DD60")]
	public BDNCCNEEOJD(int GEEOEHKGGHC, int CKGKCNOKOJB, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OLCJOIFMAKD : IEJPIAILIJG<GIOKDPFJDCG, GIOKDPFJDCG>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DD90", Offset = "0x6A5C390", VA = "0x186A5DD90")]
	public OLCJOIFMAKD(int GEEOEHKGGHC, int CKGKCNOKOJB, ComputeShader FMAOKAFICIO, int MCMKOPIIFBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class OPHJNBMOHIO : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private EAONDHGDGOL HAPHGJAFDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool PCJPKCENFJC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool OBMALBJDGPG;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E240", Offset = "0x6A5C840", VA = "0x186A5E240")]
	public OPHJNBMOHIO(EAONDHGDGOL GCAFIMFKAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E0B0", Offset = "0x6A5C6B0", VA = "0x186A5E0B0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer MGGOHHEBAAI, RenderingData CNMBPDMPBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DE40", Offset = "0x6A5C440", VA = "0x186A5DE40", Slot = "6")]
	public override void Configure(CommandBuffer MGGOHHEBAAI, RenderTextureDescriptor JPJGEFBBGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DE80", Offset = "0x6A5C480", VA = "0x186A5DE80", Slot = "9")]
	public override void Execute(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class HNANNAECLGO
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct OFMGBNGGELK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string GJEDHMJMNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer MGGOHHEBAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext CAMDIODFJJE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A5DC50", Offset = "0x6A5C250", VA = "0x186A5DC50")]
		public OFMGBNGGELK(string IPOJNKAKJMA, ScriptableRenderContext HPPNJCLBFJJ, [Out] CommandBuffer MPAAMLHNDGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A5DBA0", Offset = "0x6A5C1A0", VA = "0x186A5DBA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A59990", Offset = "0x6A57F90", VA = "0x186A59990")]
	public static bool NMCNHJIPGPM(RenderingData CNMBPDMPBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A597F0", Offset = "0x6A57DF0", VA = "0x186A597F0")]
	public static void GPAECJELLEH(CommandBuffer MGGOHHEBAAI, ScriptableRenderContext CAMDIODFJJE, ShadowDrawingSettings PJGJFAMDILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A595C0", Offset = "0x6A57BC0", VA = "0x186A595C0")]
	public static void GEHAIPNGNBB(CommandBuffer MGGOHHEBAAI, ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EAONDHGDGOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class KCMFBBHDABP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int KKNJGMAJPIN;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int JJOOOMFLBBI;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static OKMPOJHPPDI<FGJMNNGNKMC> LKDIBBPHIEI;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static OKMPOJHPPDI<uint> CCGNAFBDLMO;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static AIENKGAGFMF PFGFHCFOIGK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer NHBCKIGACLN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<KNHKODIINNL> NMEGDIFGABL;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int EKELOOJLIDF;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int DMDHFIJEPIJ;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int LODADAICNAD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int FABPDEMPPMO;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] MAOLCGIIPLB;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] PCFKEINBGCO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static CIIECIDLEIM[][] EJDNODIAFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] KJBEEEBPJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int KOMJEHHOFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int FHHKMBGMHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int HJEFMBKENPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int ICJCPDFJPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int OEKNOCMNIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int LPFBNHOGKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int HACJEELBOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int IPNOEAMHLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int GBEHCKBMPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int EELMCFHECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int PGFEDCLFJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int BCKCCKOMOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int JMOPCEGIPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int IPLBGJONBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int GNGCNPMIFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int GNCGOPJLINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int COFOLAJBBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int MBCMNCCFCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] MJGCFFMPLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private DLDDDDFPMCE HLIPENAKJMH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool DGICDFHJLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A555F0", Offset = "0x6A53BF0", VA = "0x186A555F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6A514D0", Offset = "0x6A4FAD0", VA = "0x186A514D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool KEIKIACAOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A551D0", Offset = "0x6A537D0", VA = "0x186A551D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A52B10", Offset = "0x6A51110", VA = "0x186A52B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData GDPGJFHLHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A55030", Offset = "0x6A53630", VA = "0x186A55030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A55640", Offset = "0x6A53C40", VA = "0x186A55640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static MDKKPHGBCED CNDHGKPBPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A58310", Offset = "0x6A56910", VA = "0x186A58310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A56E70", Offset = "0x6A55470", VA = "0x186A56E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static LLAPPHNEBKC DIDMDONFGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A55540", Offset = "0x6A53B40", VA = "0x186A55540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A53F30", Offset = "0x6A52530", VA = "0x186A53F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static ELDCFKNAGJN CJLEFBIECLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A52790", Offset = "0x6A50D90", VA = "0x186A52790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A51460", Offset = "0x6A4FA60", VA = "0x186A51460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static FBPHBECKOHE NFFAIEEBIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A52B70", Offset = "0x6A51170", VA = "0x186A52B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A55100", Offset = "0x6A53700", VA = "0x186A55100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static BDNCCNEEOJD KMNDHBHPICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A52AB0", Offset = "0x6A510B0", VA = "0x186A52AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A55080", Offset = "0x6A53680", VA = "0x186A55080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static OLCJOIFMAKD JJCBIOIDHCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A52730", Offset = "0x6A50D30", VA = "0x186A52730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A528D0", Offset = "0x6A50ED0", VA = "0x186A528D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material BGGAJPDMGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A52A50", Offset = "0x6A51050", VA = "0x186A52A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A56D10", Offset = "0x6A55310", VA = "0x186A56D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material KOMKFHKKLNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A55590", Offset = "0x6A53B90", VA = "0x186A55590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A53FA0", Offset = "0x6A525A0", VA = "0x186A53FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material INKKFFLINPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A54FD0", Offset = "0x6A535D0", VA = "0x186A54FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6A52BC0", Offset = "0x6A511C0", VA = "0x186A52BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material FAMDAFOLLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6A55170", Offset = "0x6A53770", VA = "0x186A55170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6A56EE0", Offset = "0x6A554E0", VA = "0x186A56EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool LMPKIHMKHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6A51E30", Offset = "0x6A50430", VA = "0x186A51E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A529F0", Offset = "0x6A50FF0", VA = "0x186A529F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GJMODCMJDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A52170", Offset = "0x6A50770", VA = "0x186A52170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string NMEENIHBGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6A53200", Offset = "0x6A51800", VA = "0x186A53200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A58400", Offset = "0x6A56A00", VA = "0x186A58400")]
	internal EAONDHGDGOL([Optional] MClusterData EKNODNDCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A56F60", Offset = "0x6A55560", VA = "0x186A56F60")]
	public void PNLKNBIHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A52950", Offset = "0x6A50F50", VA = "0x186A52950")]
	public void GCNMMAHKBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6A51450", Offset = "0x6A4FA50", VA = "0x186A51450")]
	public void AIAKCABJIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6A513B0", Offset = "0x6A4F9B0", VA = "0x186A513B0")]
	public bool AHKIBEADMBP(Hash128 JEEDPHFPHKM, [Out] IPIHBBBPAIJ CKFPIMAMAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A55720", Offset = "0x6A53D20", VA = "0x186A55720")]
	public IPIHBBBPAIJ NECNOABNHFL(DDCHKIJJEBG MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6A559A0", Offset = "0x6A53FA0", VA = "0x186A559A0")]
	public OEHNGAEBPAC NECNOABNHFL(DGLDHLPMLHH OLKLLNJBJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6A557E0", Offset = "0x6A53DE0", VA = "0x186A557E0")]
	public BIMFFKCCPBN NECNOABNHFL(OFCJLJNJKMA ADJKKNJDKEH, bool NBAHJJOPPEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A538E0", Offset = "0x6A51EE0", VA = "0x186A538E0")]
	public void HHOKGKJNBNI(FJJNIGCHCEN NJJGFJOBMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A527E0", Offset = "0x6A50DE0", VA = "0x186A527E0")]
	public static void FJLIKDCADFB(LELBMHHLIBD ABCPPKFGKJO, CIIECIDLEIM[] MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A51530", Offset = "0x6A4FB30", VA = "0x186A51530")]
	private void DJLKIGMPPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6A56040", Offset = "0x6A54640", VA = "0x186A56040")]
	private static void NKPINMJLBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6A55220", Offset = "0x6A53820", VA = "0x186A55220")]
	public void LCCAHBENIKI(CommandBuffer MGGOHHEBAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A51FA0", Offset = "0x6A505A0", VA = "0x186A51FA0")]
	public void EFEGKMNPCPD([Optional] ScriptableRenderContext? CAMDIODFJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A52F20", Offset = "0x6A51520", VA = "0x186A52F20")]
	public void HBGHHJJAJBG(CommandBuffer MGGOHHEBAAI, ShadowSplitData OOFNCLCAKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A52C40", Offset = "0x6A51240", VA = "0x186A52C40")]
	public void HBGHHJJAJBG(CommandBuffer MGGOHHEBAAI, CameraData BGAACPIEOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A521D0", Offset = "0x6A507D0", VA = "0x186A521D0")]
	public void EJOPBOANDFK(CommandBuffer MGGOHHEBAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A556B0", Offset = "0x6A53CB0", VA = "0x186A556B0")]
	public void MPIMPGPADEB(CommandBuffer MGGOHHEBAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A55BA0", Offset = "0x6A541A0", VA = "0x186A55BA0")]
	public void NEMDBDGGGCK(CommandBuffer MGGOHHEBAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A53930", Offset = "0x6A51F30", VA = "0x186A53930")]
	public void HIHJKIKDLBN(CommandBuffer MGGOHHEBAAI, LELBMHHLIBD LGJDDEBBFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A56D90", Offset = "0x6A55390", VA = "0x186A56D90")]
	public void OKKHCHOKANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A54020", Offset = "0x6A52620", VA = "0x186A54020")]
	public void IHOPKBJIMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A51E90", Offset = "0x6A50490", VA = "0x186A51E90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NMPCGLDDKHI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1F57D80", Offset = "0x1F56380", VA = "0x181F57D80")]
	public static int AMIFHGPGADM(int BILDLIKNGJF, int FINBAJPNMCK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BGNBIMEDBNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 BEEAFJNEFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 LDGLLMCDBBB;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly BGNBIMEDBNF PHCCCGJMKAB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly BGNBIMEDBNF NGHCGFLIPPC;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DF80", Offset = "0x6A4C580", VA = "0x186A4DF80")]
	public BGNBIMEDBNF(float4x4 GLAJPFIKKKH, float4 PLIKJMHIEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DE10", Offset = "0x6A4C410", VA = "0x186A4DE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HDDOFIFCPMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 MCPNOOFMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 MHHLIPGJMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 PDEEPPMIHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 DLBPCLGHNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 MDLBGBMNMCB;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct INAGHFOLPGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 MCPNOOFMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 MHHLIPGJMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 PDEEPPMIHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 DLBPCLGHNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 MDLBGBMNMCB;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct IEJGDPNBEGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public INAGHFOLPGI ONFLBKDAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public INAGHFOLPGI CEBADEAJEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public INAGHFOLPGI GNBHJMLNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public INAGHFOLPGI CEGADKBABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public INAGHFOLPGI KGAMFOGKHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public INAGHFOLPGI GEGENACKABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public INAGHFOLPGI HHPJBPEMGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public INAGHFOLPGI PBHNBFMCPFO;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct MEOMIFBACMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public HDDOFIFCPMG ONFLBKDAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public HDDOFIFCPMG CEBADEAJEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public HDDOFIFCPMG GNBHJMLNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public HDDOFIFCPMG CEGADKBABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public HDDOFIFCPMG KGAMFOGKHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public HDDOFIFCPMG GEGENACKABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public HDDOFIFCPMG HHPJBPEMGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public HDDOFIFCPMG PBHNBFMCPFO;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct MLMFDLFNEME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 ALMIKADFEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint CAEEPIMAMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint ECLABNAHOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float FANJHLFJCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint NKAHKKLLDHB;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D480", Offset = "0x6A5BA80", VA = "0x186A5D480")]
	public MLMFDLFNEME(DGLDHLPMLHH OLKLLNJBJND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FGJMNNGNKMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint FAKBJOJKPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint NPCEGNFKGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint OKGPDLCEDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint NKAHKKLLDHB;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A59060", Offset = "0x6A57660", VA = "0x186A59060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LBMACEHAMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint DCPPFADNGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint GBKPFLIMPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint PHNKJDLMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint NKAHKKLLDHB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BCA0", Offset = "0x6A5A2A0", VA = "0x186A5BCA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CNAPHHFBLJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint IDFKCENAGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint GECENCIEMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint HMAKMINHENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint IALAPICICNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint AIMGNEABIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint KMFCEDPFDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint GJGICLHMAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint NKAHKKLLDHB;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FBA0", Offset = "0x6A4E1A0", VA = "0x186A4FBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GIOKDPFJDCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 KMAOILJBBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 PALNHAJAEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 CBAOODJNCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 LBINFPADELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 FDEIAHOKKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 ACEKNFOIGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 BGGBDGMPIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 LJNNNAAKBPF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6A59110", Offset = "0x6A57710", VA = "0x186A59110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum LELBMHHLIBD
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
