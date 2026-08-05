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
public struct HDIAEBHJOFL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] FJFILOBDLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] BEOJKFPGMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] DCJNDPLLODB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static int IGDGMMLNGJJ(JMNKKLAAOID FBFOMBJELAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6045B70", Offset = "0x6044F70", VA = "0x186045B70")]
	public static int GNIBJBEJLKM(JMNKKLAAOID FBFOMBJELAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BMANIJNLFMB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int FLIBKPINPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GKBCMKFKFFK DIOLDBFMBDN(int NBPAIKKEFCG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 PCGKAGLEPIH(int NBPAIKKEFCG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOMPFHDKEFP PCGBEAPDLLH();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IJLEBOMIJAE IAHDLKDOJCI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CGKHANGIDIM : EKIGBLKEDOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LOMPFHDKEFP FIFLCPFGAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform LIDEAFKMMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<MHPOMHAGFLI> GCLHEODGHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private GAMKHEJPJAF HAEPDOABIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private LFAPALFCFPO BIFKDNBINCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HAPIEPMHBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BMANIJNLFMB DNMPHBMJHCB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float DLPIBICAEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B7AF0", Offset = "0x8B6EF0", VA = "0x1808B7AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF3C50", Offset = "0xAF3050", VA = "0x180AF3C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EMOEEJLOMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81FE30", Offset = "0x81F230", VA = "0x18081FE30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81FE40", Offset = "0x81F240", VA = "0x18081FE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MMJFJABMHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF036A0", Offset = "0xF02AA0", VA = "0x180F036A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xF02D40", Offset = "0xF02140", VA = "0x180F02D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PEEHDGOMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6043A40", Offset = "0x6042E40", VA = "0x186043A40", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60429A0", Offset = "0x6041DA0", VA = "0x1860429A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CDHLJOLJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1185E30", Offset = "0x1185230", VA = "0x181185E30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6043A50", Offset = "0x6042E50", VA = "0x186043A50")]
	public CGKHANGIDIM(BMANIJNLFMB LMAHFGJNONE, bool DDIFMEAOPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60429B0", Offset = "0x6041DB0", VA = "0x1860429B0")]
	private bool DAKIJBJFOPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6042BD0", Offset = "0x6041FD0", VA = "0x186042BD0", Slot = "4")]
	public bool DEAIBIAHPPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60427D0", Offset = "0x6041BD0", VA = "0x1860427D0", Slot = "5")]
	public bool AKOCPLJFKLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6043810", Offset = "0x6042C10", VA = "0x186043810", Slot = "6")]
	public void FKMFNEFKHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6043800", Offset = "0x6042C00", VA = "0x186043800", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OFFJLLKFCLD
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLOPCLIGOAP(CommandBuffer NEJDMALKOPM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FHMPKBPNMEA : OFFJLLKFCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int POIIBGFPHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier CPGNLJMENKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BE55C0", Offset = "0x3BE49C0", VA = "0x183BE55C0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6045150", Offset = "0x6044550", VA = "0x186045150")]
	public FHMPKBPNMEA(int NONJEEALACK, RenderTargetIdentifier GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6045100", Offset = "0x6044500", VA = "0x186045100", Slot = "4")]
	public void HLOPCLIGOAP(CommandBuffer NEJDMALKOPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct OKECBAGOEBB : OFFJLLKFCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int POIIBGFPHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] DGLNAOMOMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xB97A80", Offset = "0xB96E80", VA = "0x180B97A80")]
	public OKECBAGOEBB(int NONJEEALACK, Vector4[] GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x604A9C0", Offset = "0x6049DC0", VA = "0x18604A9C0", Slot = "4")]
	public void HLOPCLIGOAP(CommandBuffer NEJDMALKOPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JCDOCNJOCPB : OFFJLLKFCLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int POIIBGFPHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] IAEIGLENKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xB97A80", Offset = "0xB96E80", VA = "0x180B97A80")]
	public JCDOCNJOCPB(int NONJEEALACK, float[] GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6046430", Offset = "0x6045830", VA = "0x186046430", Slot = "4")]
	public void HLOPCLIGOAP(CommandBuffer NEJDMALKOPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IIHIINPGIJM : OFFJLLKFCLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool BJKMFDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x18A4AE0", Offset = "0x18A3EE0", VA = "0x1818A4AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38D97F0", Offset = "0x38D8BF0", VA = "0x1838D97F0")]
	public IIHIINPGIJM(string ADLKEGECLOG, bool MKECFCAPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6046230", Offset = "0x6045630", VA = "0x186046230", Slot = "4")]
	public void HLOPCLIGOAP(CommandBuffer NEJDMALKOPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct IJLEBOMIJAE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 FCONJDCKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 KFDDPBCMGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DKHHHCOIFII
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DKOOIBBNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF690", Offset = "0x7CEA90", VA = "0x1807CF690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BPBEDNEKOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4970", Offset = "0x7E3D70", VA = "0x1807E4970")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6046300", Offset = "0x6045700", VA = "0x186046300")]
	public IJLEBOMIJAE(Color JKOGDMNIBNM, int BJJHJJMPCIK, int JDDFBAGKFLF, float FMKBMMODDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x55AABD0", Offset = "0x55A9FD0", VA = "0x1855AABD0")]
	private static float4 CFKLEMCCODJ(Color JKOGDMNIBNM)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6046270", Offset = "0x6045670", VA = "0x186046270")]
	private static Hash128 OOKFLABGNFC(IJLEBOMIJAE LMAHFGJNONE)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GAMKHEJPJAF : EKIGBLKEDOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string JJLJFJNNHNB;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string ODHBAOJMFGF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string DEGBJIGMCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private IJLEBOMIJAE JFODJDIOHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private KJNDBMJJPCD DELNJNDMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 EHBBMJDOJIF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LFAPALFCFPO BLHNIMFPOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7B81D0", Offset = "0x7B75D0", VA = "0x1807B81D0")]
		[CompilerGenerated]
		get
		{
			return default(LFAPALFCFPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BCB40", VA = "0x1808BD740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EMOEEJLOMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x513E5B0", Offset = "0x513D9B0", VA = "0x18513E5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x513E5C0", Offset = "0x513D9C0", VA = "0x18513E5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MMJFJABMHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1CB75C0", Offset = "0x1CB69C0", VA = "0x181CB75C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E429A0", Offset = "0x5E41DA0", VA = "0x185E429A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CDHLJOLJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PEEHDGOMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x51E8050", Offset = "0x51E7450", VA = "0x1851E8050", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E42B40", Offset = "0x5E41F40", VA = "0x185E42B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int GOBEDCIKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6045690", Offset = "0x6044A90", VA = "0x186045690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6045810", Offset = "0x6044C10", VA = "0x186045810")]
	public GAMKHEJPJAF(IJLEBOMIJAE NBGGKBNENAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6045320", Offset = "0x6044720", VA = "0x186045320")]
	private bool DAKIJBJFOPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6045430", Offset = "0x6044830", VA = "0x186045430", Slot = "4")]
	public bool DEAIBIAHPPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60456E0", Offset = "0x6044AE0", VA = "0x1860456E0")]
	private static KJNDBMJJPCD KOJLMBOHLKA(IJLEBOMIJAE LMAHFGJNONE)
	{
		return default(KJNDBMJJPCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6045170", Offset = "0x6044570", VA = "0x186045170", Slot = "5")]
	public bool AKOCPLJFKLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6045580", Offset = "0x6044980", VA = "0x186045580", Slot = "6")]
	public void FKMFNEFKHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6046AD0", Offset = "0x6045ED0", VA = "0x186046AD0", Slot = "0")]
		public override bool Equals(object JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6046CD0", Offset = "0x60460D0", VA = "0x186046CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81D4D0", Offset = "0x81C8D0", VA = "0x18081D4D0")]
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
		private FDIIHKOGBLB opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static OOBOGICBFEI CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x60473A0", Offset = "0x60467A0", VA = "0x1860473A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x60473E0", Offset = "0x60467E0", VA = "0x1860473E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6046DB0", Offset = "0x60461B0", VA = "0x186046DB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6046D80", Offset = "0x6046180", VA = "0x186046D80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MADIDHJDPOK, RenderingData IIOFEEBNMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6047210", Offset = "0x6046610", VA = "0x186047210")]
		public void MNFDHCKMKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB81500", Offset = "0xB80900", VA = "0x180B81500")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HEKIPHDCJAN<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private EHNENGDPIKL IIDIHAPPIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private EHNENGDPIKL OJILODAFBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer KKAPEMMPCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture NIEGICJCELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int MPKLBNLIPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int NNIMKCAMLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string AFCPCGOBMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string KGAJONHBBPG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x79A730", Offset = "0x799B30", VA = "0x18079A730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int OJAHFBOAFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xBA1D70", Offset = "0xBA1170", VA = "0x180BA1D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FDBAHGLMENF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBC0", Offset = "0x7ADFC0", VA = "0x1807AEBC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x38180A0", Offset = "0x38174A0", VA = "0x1838180A0")]
	public HEKIPHDCJAN(string ADLKEGECLOG, int DIGEAPKBLME, [Optional] RenderTextureFormat? NBMOIMOKFPB, bool KIJFHNIKCFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3816380", Offset = "0x3815780", VA = "0x183816380")]
	public void AKOCPLJFKLG(CommandBuffer NEJDMALKOPM, NativeArray<ValType> GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3817450", Offset = "0x3816850", VA = "0x183817450")]
	public void MLJCLENBDAL(CommandBuffer NEJDMALKOPM, ComputeShader EONAKIOMCDL, int FGNJDHLJHNC, int DKLACHPENAK = -1, int BFCACNLEOHL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3817BB0", Offset = "0x3816FB0", VA = "0x183817BB0")]
	public void MLJCLENBDAL(Material DELNJNDMHJJ, int DKLACHPENAK = -1, int BFCACNLEOHL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3816B20", Offset = "0x3815F20", VA = "0x183816B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ABPMMOCMPBN
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLJCLENBDAL(Material NBGGKBNENAM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OFPIEHOOPIN<SrcEntry, DstEntry> : ABPMMOCMPBN, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] BPIINBAKBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected EHNENGDPIKL GKJIECIFHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected EHNENGDPIKL IFBCIDMBCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> BKOBFOOBKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> IPOOKJLHPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int JBLCHMINEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int HODCJEGAOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected HEKIPHDCJAN<int> ONBINCHIBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected HEKIPHDCJAN<SrcEntry> HOIFJCAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected HEKIPHDCJAN<DstEntry> GGDGDHEAEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader IIANHCECAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int DNGONPLPFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int HLPLLJJJJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int PPHDKDJHABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int EOCIJDGDHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int OFLNNGKAKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int PALIJJNJBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int HCIELEJPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int KEEFLLOFCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int IHJKLGCDDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int IBBPBIADAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int ENOPGALEPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int EGLCDBHIAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string HGCDDDENDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] NDFNDPBJBOH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PGLEDIIDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3F915E0", Offset = "0x3F909E0", VA = "0x183F915E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string LGOPKIJFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3F93BE0", Offset = "0x3F92FE0", VA = "0x183F93BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F95620", Offset = "0x3F94A20", VA = "0x183F95620")]
	public OFPIEHOOPIN(string ADLKEGECLOG, int DLGMEABDKNF, int PEPLIGCLMFA, RenderTextureFormat NBMOIMOKFPB, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH = 0, int AJFNDFEHKMA = 0, int CKPGONMACGJ = 0, int LPLOKDAACOF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F918F0", Offset = "0x3F90CF0", VA = "0x183F918F0")]
	public int FOHEBHGJILH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F93EB0", Offset = "0x3F932B0", VA = "0x183F93EB0")]
	protected void PFFNEMDGACC(int FGBBDGJMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3F90AD0", Offset = "0x3F8FED0", VA = "0x183F90AD0")]
	public LFAPALFCFPO DEAIBIAHPPK(SrcEntry GMLIPIALCHN)
	{
		return default(LFAPALFCFPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8FE20", Offset = "0x3F8F220", VA = "0x183F8FE20")]
	public bool AKOCPLJFKLG(LFAPALFCFPO AEBAPBHOHLJ, SrcEntry GMLIPIALCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F917F0", Offset = "0x3F90BF0", VA = "0x183F917F0")]
	public bool FKMFNEFKHJM(LFAPALFCFPO AEBAPBHOHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "6")]
	protected virtual void GMHJDAJLMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F91F80", Offset = "0x3F91380", VA = "0x183F91F80", Slot = "7")]
	public void JOONOFHEFDE(CommandBuffer NEJDMALKOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3F925F0", Offset = "0x3F919F0", VA = "0x183F925F0", Slot = "8")]
	public void JOONOFHEFDE(CommandBuffer NEJDMALKOPM, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH = -1, int AJFNDFEHKMA = -1, int CKPGONMACGJ = -1, int LPLOKDAACOF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3F92C10", Offset = "0x3F92010", VA = "0x183F92C10", Slot = "9")]
	public void MLJCLENBDAL(CommandBuffer NEJDMALKOPM, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3F92D80", Offset = "0x3F92180", VA = "0x183F92D80", Slot = "4")]
	public void MLJCLENBDAL(Material DELNJNDMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3F91520", Offset = "0x3F90920", VA = "0x183F91520", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EHNENGDPIKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong FNLJLEPMIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong AADLGCAGCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CFHJOFBHPOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct CFKECKNLDDG : EHNENGDPIKL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable NBFGBIBIJHA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong FNLJLEPMIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5895750", Offset = "0x5894B50", VA = "0x185895750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong AADLGCAGCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1284A60", Offset = "0x1283E60", VA = "0x181284A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6042790", Offset = "0x6041B90", VA = "0x186042790")]
		internal CFKECKNLDDG(IDisposable EBKIDHIDFKN, ulong DLAEAPEAKLK, ulong IHOEJJCMJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6042710", Offset = "0x6041B10", VA = "0x186042710", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct GJHOCGJFPIM : EHNENGDPIKL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture ADPLFLHFILB;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong FNLJLEPMIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5895750", Offset = "0x5894B50", VA = "0x185895750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong AADLGCAGCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1284A60", Offset = "0x1283E60", VA = "0x181284A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6045B40", Offset = "0x6044F40", VA = "0x186045B40")]
		public GJHOCGJFPIM(RenderTexture PGJDHNNPIMB, ulong EPFFJBCDGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6045AA0", Offset = "0x6044EA0", VA = "0x186045AA0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong GKCAMEIMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60426D0", Offset = "0x6041AD0", VA = "0x1860426D0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60423C0", Offset = "0x60417C0", VA = "0x1860423C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong CAJDHMACEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6042400", Offset = "0x6041800", VA = "0x186042400")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6042440", Offset = "0x6041840", VA = "0x186042440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6041E40", Offset = "0x6041240", VA = "0x186041E40")]
	public static ComputeBuffer CNMCABBAMHK(int GNHCGOJHAJG, int ADJBIJPCDKL, ComputeBufferType KHENBEDBKDI, [Out] EHNENGDPIKL AEBAPBHOHLJ, ComputeBufferMode PEOLLHJDPED = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6042020", Offset = "0x6041420", VA = "0x186042020")]
	public static RenderTexture CNMCABBAMHK(int BKCPECMOHLE, int DJKBPBOJAEA, int DALMHOCOHAB, RenderTextureFormat NBMOIMOKFPB, [Out] EHNENGDPIKL AEBAPBHOHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2459AC0", Offset = "0x2458EC0", VA = "0x182459AC0")]
	public static NativeArray<T> OJCGPLGDDII<T>(NativeArray<T> NBFGBIBIJHA, ulong OGHJPGGPGJL, [Out] EHNENGDPIKL AEBAPBHOHLJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2459A20", Offset = "0x2458E20", VA = "0x182459A20")]
	public static NativeArray<T> CNMCABBAMHK<T>(int OGHJPGGPGJL, Allocator FHOLEANHCPH, [Out] EHNENGDPIKL AEBAPBHOHLJ, NativeArrayOptions LOBGHAGLKMO = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6042480", Offset = "0x6041880", VA = "0x186042480")]
	public static void GOHOEIHDKHJ(EHNENGDPIKL NBFGBIBIJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60425D0", Offset = "0x60419D0", VA = "0x1860425D0")]
	public static uint KCLDBIHCMJO(RenderTextureFormat NBMOIMOKFPB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DJAOFDPCNIL : OFPIEHOOPIN<GJFBELECDBB, GJFBELECDBB>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct OFCDHKCJAHJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> MIIPLIHGOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> NLPADFNNKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> JGALLBMAIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> FFCNDHKIFGO;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6044560", Offset = "0x6043960", VA = "0x186044560")]
		public OFCDHKCJAHJ(NativeArray<int> CBOOHGDPIMA, NativeArray<float> AGDIEBGGHJH, NativeArray<float4x4> EIOGMIFOMLG, NativeArray<float4> BMGEGCDECFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x604A800", Offset = "0x6049C00", VA = "0x18604A800", Slot = "4")]
		public void Execute(int FGBBDGJMFEH, TransformAccess FIFLCPFGAIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct EFJDHEPGEPG : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> MIIPLIHGOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> MDAHPHHNLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> LOENKJLEEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<GJFBELECDBB> MLDCFHGAIBN;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6044560", Offset = "0x6043960", VA = "0x186044560")]
		public EFJDHEPGEPG(NativeArray<int> CBOOHGDPIMA, NativeArray<float4x4> ACJGOACJBBE, NativeArray<float4> OHCCKIJEJMG, NativeArray<GJFBELECDBB> GDDIIAFGFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60444F0", Offset = "0x60438F0", VA = "0x1860444F0", Slot = "4")]
		public void Execute(int FGBBDGJMFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte HLEDIIBECNM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray PLNEJLCFMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> HEIDJODNNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> LPKODFGHDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> JMMOGNNMAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> PFIHPPPFGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> CPCLAEKKDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private EHNENGDPIKL CIJBELJIGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EHNENGDPIKL FEEAMCIFMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EHNENGDPIKL ABLGADABALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EHNENGDPIKL IMHPJEGAJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private EHNENGDPIKL HECNJNBJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform APIGJILADJJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6044160", Offset = "0x6043560", VA = "0x186044160")]
	public DJAOFDPCNIL(int DLGMEABDKNF, int PEPLIGCLMFA, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6043D10", Offset = "0x6043110", VA = "0x186043D10", Slot = "6")]
	protected override void GMHJDAJLMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6043F10", Offset = "0x6043310", VA = "0x186043F10")]
	private void HONCMEIOAIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6043B10", Offset = "0x6042F10", VA = "0x186043B10")]
	public bool BDBMELIPAKE(LFAPALFCFPO AEBAPBHOHLJ, Transform FIFLCPFGAIF, float MEKMOKIAHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6043FD0", Offset = "0x60433D0", VA = "0x186043FD0")]
	public void IEONBGAMIIC(LFAPALFCFPO AEBAPBHOHLJ, float MEKMOKIAHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60440B0", Offset = "0x60434B0", VA = "0x1860440B0")]
	public void LKFNLGEPAPJ(LFAPALFCFPO AEBAPBHOHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6043C70", Offset = "0x6043070", VA = "0x186043C70", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GKBCMKFKFFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLIKNHCLNCJ LBKEKNGOEKH();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LOMCLCOFEAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 FCONJDCKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int HCAGCMKLGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int CKAKGLLKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> CNEKGDKGHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> OJGIAAAKMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> MHABLEHPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> BFBEMBBPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> COMJCJGALEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> IPJOIOLGGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int PGOBLOGNPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int DNGPIINCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int KEHFPKPOMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool PMECIDOKMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOONOFHEFDE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LGOJJNNJJKC : LOMCLCOFEAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private GKBCMKFKFFK CBBONACKODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HLIKNHCLNCJ MOKLMJBIJAG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 FCONJDCKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1BC3F10", Offset = "0x1BC3310", VA = "0x181BC3F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool GOPPEBJANCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7940E0", Offset = "0x7934E0", VA = "0x1807940E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HCAGCMKLGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7CF690", Offset = "0x7CEA90", VA = "0x1807CF690", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7CED20", Offset = "0x7CE120", VA = "0x1807CED20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CKAKGLLKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x797290", Offset = "0x796690", VA = "0x180797290", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7979E0", Offset = "0x796DE0", VA = "0x1807979E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int PLIHDJJOCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9683D0", Offset = "0x9677D0", VA = "0x1809683D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> CNEKGDKGHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6046A00", Offset = "0x6045E00", VA = "0x186046A00", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> OJGIAAAKMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6046740", Offset = "0x6045B40", VA = "0x186046740", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> MHABLEHPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x60468C0", Offset = "0x6045CC0", VA = "0x1860468C0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> BFBEMBBPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6046830", Offset = "0x6045C30", VA = "0x186046830", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> COMJCJGALEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6046710", Offset = "0x6045B10", VA = "0x186046710", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> IPJOIOLGGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6046770", Offset = "0x6045B70", VA = "0x186046770", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PMECIDOKMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E49A0", Offset = "0x7E3DA0", VA = "0x1807E49A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E4980", Offset = "0x7E3D80", VA = "0x1807E4980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int PGOBLOGNPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6046A70", Offset = "0x6045E70", VA = "0x186046A70", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DNGPIINCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60466F0", Offset = "0x6045AF0", VA = "0x1860466F0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int KEHFPKPOMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60468A0", Offset = "0x6045CA0", VA = "0x1860468A0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6046A80", Offset = "0x6045E80", VA = "0x186046A80")]
	public LGOJJNNJJKC(Hash128 IJEJDFGCCLC, GKBCMKFKFFK CBBONACKODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x60468F0", Offset = "0x6045CF0", VA = "0x1860468F0", Slot = "16")]
	public void JOONOFHEFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60467A0", Offset = "0x6045BA0", VA = "0x1860467A0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LFAPALFCFPO : IEquatable<LFAPALFCFPO>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly LFAPALFCFPO INDMNNFEIGN;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int GOBEDCIKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600")]
	public LFAPALFCFPO(int FGBBDGJMFEH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6046490", Offset = "0x6045890", VA = "0x186046490", Slot = "4")]
	public bool Equals(LFAPALFCFPO JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60464E0", Offset = "0x60458E0", VA = "0x1860464E0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x60465B0", Offset = "0x60459B0", VA = "0x1860465B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MHPOMHAGFLI : EKIGBLKEDOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool HAPIEPMHBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private LOMCLCOFEAF KDIGGCCDNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<LFAPALFCFPO> OCHDPDCFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<LFAPALFCFPO> JOGPFECKIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<LFAPALFCFPO> AEHJEDOJFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> INFAPFBODEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int GGLNOCBEHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int IDHFPPGCGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int FDKDIHCIEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int LPJCCBGBCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int IJFBCKJJNGN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GOBEDCIKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6048AA0", Offset = "0x6047EA0", VA = "0x186048AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6048B50", Offset = "0x6047F50", VA = "0x186048B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EMOEEJLOMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B90", Offset = "0x7DFF90", VA = "0x1807E0B90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x97ED30", Offset = "0x97E130", VA = "0x18097ED30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MMJFJABMHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x97ED20", Offset = "0x97E120", VA = "0x18097ED20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x97ECA0", Offset = "0x97E0A0", VA = "0x18097ECA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool CDHLJOLJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool PEEHDGOMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x16A2C80", Offset = "0x16A2080", VA = "0x1816A2C80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x16A2C90", Offset = "0x16A2090", VA = "0x1816A2C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float DLPIBICAEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1A06A60", Offset = "0x1A05E60", VA = "0x181A06A60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1A06BB0", Offset = "0x1A05FB0", VA = "0x181A06BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6049070", Offset = "0x6048470", VA = "0x186049070")]
	public MHPOMHAGFLI(LOMCLCOFEAF MOKLMJBIJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6048B90", Offset = "0x6047F90", VA = "0x186048B90")]
	private void PFJBLIEPEBO(LOMCLCOFEAF MOKLMJBIJAG, int GGLNOCBEHJJ, int LJELLNJHGFD, int FGBBDGJMFEH, int DBDBAMCAMEL, PPOHBOFLEAA GMLIPIALCHN, float MFHLCAEIOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6048160", Offset = "0x6047560", VA = "0x186048160")]
	private void EKGEHLEHNFE(LOMCLCOFEAF MOKLMJBIJAG, int AICCKNLDHJI, int FGBBDGJMFEH, uint3 JKIDHPLNNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x60474C0", Offset = "0x60468C0", VA = "0x1860474C0")]
	private bool DAKIJBJFOPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6047760", Offset = "0x6046B60", VA = "0x186047760", Slot = "4")]
	public bool DEAIBIAHPPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6047440", Offset = "0x6046840", VA = "0x186047440", Slot = "5")]
	public bool AKOCPLJFKLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6048430", Offset = "0x6047830", VA = "0x186048430", Slot = "6")]
	public void FKMFNEFKHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6048100", Offset = "0x6047500", VA = "0x186048100")]
	public void KBPOGHLLJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6048100", Offset = "0x6047500", VA = "0x186048100", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EKIGBLKEDOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CDHLJOLJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PEEHDGOMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEAIBIAHPPK();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKOCPLJFKLG();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKMFNEFKHJM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MIEAANPAPNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float IBAFPJJGANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, MHPOMHAGFLI> HNANIPABBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, GAMKHEJPJAF> GMFJGAKGGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<EKIGBLKEDOO> LKOABABDKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<EKIGBLKEDOO> FAAKPOCDLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<EKIGBLKEDOO> MHNEAIFEIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int KIIBNHCKODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int LMGBMHIBBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float EBNDCENMPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool DFAFGIFIABB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FEKFKHNNLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xBA7AF0", Offset = "0xBA6EF0", VA = "0x180BA7AF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xBC3910", Offset = "0xBC2D10", VA = "0x180BC3910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MDBLOIAIIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x60493F0", Offset = "0x60487F0", VA = "0x1860493F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string LGOPKIJFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6049EB0", Offset = "0x60492B0", VA = "0x186049EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6049940", Offset = "0x6048D40", VA = "0x186049940")]
	public void MJKKIPGFICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6049930", Offset = "0x6048D30", VA = "0x186049930")]
	public void LLGCIKAFLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x604A340", Offset = "0x6049740", VA = "0x18604A340")]
	public MIEAANPAPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6049950", Offset = "0x6048D50", VA = "0x186049950")]
	public CGKHANGIDIM OAIKDCNGOPG(BMANIJNLFMB JDMDDMDPEKF, bool DDIFMEAOPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6049A80", Offset = "0x6048E80", VA = "0x186049A80")]
	public GAMKHEJPJAF OAIKDCNGOPG(IJLEBOMIJAE DELNJNDMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x60491E0", Offset = "0x60485E0", VA = "0x1860491E0")]
	public bool AOAOAPLOKHM(Hash128 NONJEEALACK, [Out] MHPOMHAGFLI PNPAJNGHLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6049BC0", Offset = "0x6048FC0", VA = "0x186049BC0")]
	public MHPOMHAGFLI OAIKDCNGOPG(LOMCLCOFEAF MOKLMJBIJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6049440", Offset = "0x6048840", VA = "0x186049440")]
	private void HCDKENCGNIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6049360", Offset = "0x6048760", VA = "0x186049360")]
	private bool FAHJKHFOOCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6049460", Offset = "0x6048860", VA = "0x186049460")]
	public void JOONOFHEFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6049250", Offset = "0x6048650", VA = "0x186049250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x604A250", Offset = "0x6049650", VA = "0x18604A250")]
	public void PHGCODCDGFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FCGHKONOANO : OFPIEHOOPIN<OBDGOOLHACB, OBDGOOLHACB>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6044B60", Offset = "0x6043F60", VA = "0x186044B60")]
	public FCGHKONOANO(int DLGMEABDKNF, int PEPLIGCLMFA, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LFBOOFALBHE : OFPIEHOOPIN<KJNDBMJJPCD, KJNDBMJJPCD>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6046640", Offset = "0x6045A40", VA = "0x186046640")]
	public LFBOOFALBHE(int DLGMEABDKNF, int PEPLIGCLMFA, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FEFGEMAPCNP : OFPIEHOOPIN<GCCAKNAHCGN, GCCAKNAHCGN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6045050", Offset = "0x6044450", VA = "0x186045050")]
	public FEFGEMAPCNP(int DLGMEABDKNF, int PEPLIGCLMFA, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FABJLMFKAHL : OFPIEHOOPIN<NJFINIDGGCI, MIEFENKAIJJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6044AB0", Offset = "0x6043EB0", VA = "0x186044AB0")]
	public FABJLMFKAHL(int DLGMEABDKNF, int PEPLIGCLMFA, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ECILKBBPAFJ : OFPIEHOOPIN<PDMOADDHNFE, PDMOADDHNFE>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6044440", Offset = "0x6043840", VA = "0x186044440")]
	public ECILKBBPAFJ(int DLGMEABDKNF, int PEPLIGCLMFA, ComputeShader GPGHDEAPBGF, int BGDILGJIFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class FDIIHKOGBLB : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private OOBOGICBFEI OMOHAIBIJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool MKECFCAPOLO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool PAFJIIMKIPD;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6045010", Offset = "0x6044410", VA = "0x186045010")]
	public FDIIHKOGBLB(OOBOGICBFEI KJPFPFAHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6044E80", Offset = "0x6044280", VA = "0x186044E80", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer NEJDMALKOPM, RenderingData IIOFEEBNMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6044C10", Offset = "0x6044010", VA = "0x186044C10", Slot = "6")]
	public override void Configure(CommandBuffer NEJDMALKOPM, RenderTextureDescriptor MJCFOIKFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6044C50", Offset = "0x6044050", VA = "0x186044C50", Slot = "9")]
	public override void Execute(ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class EOOEDBELFOG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct BGDJGPAFJFE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string ADLKEGECLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer NEJDMALKOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext AOGDICEMNLI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6041D30", Offset = "0x6041130", VA = "0x186041D30")]
		public BGDJGPAFJFE(string NDCNHEOGFOH, ScriptableRenderContext OPLNJFFOEHO, [Out] CommandBuffer OJLDBOHEAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6041C80", Offset = "0x6041080", VA = "0x186041C80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6044960", Offset = "0x6043D60", VA = "0x186044960")]
	public static bool PNKBFNGDHFP(RenderingData IIOFEEBNMNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x60447C0", Offset = "0x6043BC0", VA = "0x1860447C0")]
	public static void NLCNGLIBHBJ(CommandBuffer NEJDMALKOPM, ScriptableRenderContext AOGDICEMNLI, ShadowDrawingSettings BGCOCPCGACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6044590", Offset = "0x6043990", VA = "0x186044590")]
	public static void LGOCFIKDPAB(CommandBuffer NEJDMALKOPM, ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OOBOGICBFEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class BAHAIOCMOIH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int MCCHOEPHAMF;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int BLEDKOBNJPG;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HEKIPHDCJAN<PFGPJPELELI> CKNLCKJBOLO;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static HEKIPHDCJAN<uint> KLABGEAKNDN;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static EHNENGDPIKL HCLNOLDPCJP;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer PLKNFENPLEF;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<ABPMMOCMPBN> ALPHOMIMPCB;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int LNNFDJGGGPD;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int OCFMDCGKFCB;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int INIEKGHJGIC;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int MABGHMKFIIM;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] OHNPIGAHGOO;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] JEFLMOJONMC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static OFFJLLKFCLD[][] MEODLCMPBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] KDIBKAHPHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int DPDDJKIBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int OJMMLDIEJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int BJOLCAPMIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int CCFDKJAOAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int NJDDGNIGCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int KJELMBMAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int IMJMMMAEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int JKNLMDAOFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int HNHKAGBKOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int PPOMMLLDEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int LPNKOOJMNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int EKNMDHHMOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int HLFJFECGLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int LKGECFABIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int KAJIPGPIACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int BPAFDKHIHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int NNPMNNFEMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int AHMAGFOOJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] NBFCGEIPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private MIEAANPAPNJ FBDPNFLLCCK;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool MFNOCDAKNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x604F6E0", Offset = "0x604EAE0", VA = "0x18604F6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x604AA60", Offset = "0x6049E60", VA = "0x18604AA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool BFMEBMPEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6051920", Offset = "0x6050D20", VA = "0x186051920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x604B230", Offset = "0x604A630", VA = "0x18604B230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData LGDPHHJAFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x604F610", Offset = "0x604EA10", VA = "0x18604F610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x60508C0", Offset = "0x604FCC0", VA = "0x1860508C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static DJAOFDPCNIL IEMOHKGFCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6050600", Offset = "0x604FA00", VA = "0x186050600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x604AAC0", Offset = "0x6049EC0", VA = "0x18604AAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static FCGHKONOANO EINLHCHCHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x604AB30", Offset = "0x6049F30", VA = "0x18604AB30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6050A10", Offset = "0x604FE10", VA = "0x186050A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static LFBOOFALBHE PEKBCFMBECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6050030", Offset = "0x604F430", VA = "0x186050030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x604A9F0", Offset = "0x6049DF0", VA = "0x18604A9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static FEFGEMAPCNP HMJGJOCDJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x604B140", Offset = "0x604A540", VA = "0x18604B140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6050750", Offset = "0x604FB50", VA = "0x186050750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static FABJLMFKAHL EBIFPAANBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x604B420", Offset = "0x604A820", VA = "0x18604B420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6050650", Offset = "0x604FA50", VA = "0x186050650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static ECILKBBPAFJ LJMDBBPFCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x604E9F0", Offset = "0x604DDF0", VA = "0x18604E9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6050840", Offset = "0x604FC40", VA = "0x186050840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material FPPGPNHDMMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6050080", Offset = "0x604F480", VA = "0x186050080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60506D0", Offset = "0x604FAD0", VA = "0x1860506D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material CGOJIKBENLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x604B0E0", Offset = "0x604A4E0", VA = "0x18604B0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60507C0", Offset = "0x604FBC0", VA = "0x1860507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material FKKBEJIDFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x604B540", Offset = "0x604A940", VA = "0x18604B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x604F660", Offset = "0x604EA60", VA = "0x18604F660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material BJIEHLLJPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x604B4E0", Offset = "0x604A8E0", VA = "0x18604B4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60500E0", Offset = "0x604F4E0", VA = "0x1860500E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool GLPGIGCEKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x604D660", Offset = "0x604CA60", VA = "0x18604D660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x604B480", Offset = "0x604A880", VA = "0x18604B480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool MDBLOIAIIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x604D9E0", Offset = "0x604CDE0", VA = "0x18604D9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string LGOPKIJFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6051170", Offset = "0x6050570", VA = "0x186051170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6051A10", Offset = "0x6050E10", VA = "0x186051A10")]
	internal OOBOGICBFEI([Optional] MClusterData BBFGMDJAFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x604C260", Offset = "0x604B660", VA = "0x18604C260")]
	public void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6050A80", Offset = "0x604FE80", VA = "0x186050A80")]
	public void NAFNNJNNGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x604B300", Offset = "0x604A700", VA = "0x18604B300")]
	public void DJCNKFILKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x604B190", Offset = "0x604A590", VA = "0x18604B190")]
	public bool CEPBEPILOLI(Hash128 IJEJDFGCCLC, [Out] MHPOMHAGFLI MOKLMJBIJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6050EB0", Offset = "0x60502B0", VA = "0x186050EB0")]
	public MHPOMHAGFLI OAIKDCNGOPG(LOMCLCOFEAF GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6050F70", Offset = "0x6050370", VA = "0x186050F70")]
	public GAMKHEJPJAF OAIKDCNGOPG(IJLEBOMIJAE DELNJNDMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6050CF0", Offset = "0x60500F0", VA = "0x186050CF0")]
	public CGKHANGIDIM OAIKDCNGOPG(BMANIJNLFMB JDMDDMDPEKF, bool DDIFMEAOPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x604D610", Offset = "0x604CA10", VA = "0x18604D610")]
	public void FKMFNEFKHJM(EKIGBLKEDOO EBLGFJNNLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6051830", Offset = "0x6050C30", VA = "0x186051830")]
	public static void PDBKGHCHAAJ(JMNKKLAAOID FBFOMBJELAK, OFFJLLKFCLD[] GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x604F730", Offset = "0x604EB30", VA = "0x18604F730")]
	private void IPFGHMNFHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x604B5A0", Offset = "0x604A9A0", VA = "0x18604B5A0")]
	private static void FEJMIIHEINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x604D6C0", Offset = "0x604CAC0", VA = "0x18604D6C0")]
	public void GIMIDIDFAPM(CommandBuffer NEJDMALKOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6050B20", Offset = "0x604FF20", VA = "0x186050B20")]
	public void NDMMNFCGHCL([Optional] ScriptableRenderContext? AOGDICEMNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x604EA50", Offset = "0x604DE50", VA = "0x18604EA50")]
	public void HHFOGBKBCCE(CommandBuffer NEJDMALKOPM, ShadowSplitData MHFCJGDLEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x604ED30", Offset = "0x604E130", VA = "0x18604ED30")]
	public void HHFOGBKBCCE(CommandBuffer NEJDMALKOPM, CameraData ACBNJLPCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x604AB80", Offset = "0x6049F80", VA = "0x18604AB80")]
	public void BADKPKBAOCE(CommandBuffer NEJDMALKOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x604B290", Offset = "0x604A690", VA = "0x18604B290")]
	public void DHJIIMKNJDB(CommandBuffer NEJDMALKOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6050160", Offset = "0x604F560", VA = "0x186050160")]
	public void KIGOKHDIBPN(CommandBuffer NEJDMALKOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x604F010", Offset = "0x604E410", VA = "0x18604F010")]
	public void HOLEPPADHED(CommandBuffer NEJDMALKOPM, JMNKKLAAOID AAIHAOGCFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6050930", Offset = "0x604FD30", VA = "0x186050930")]
	public void MNFDHCKMKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x604DA40", Offset = "0x604CE40", VA = "0x18604DA40")]
	public void GOHOEIHDKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x604B310", Offset = "0x604A710", VA = "0x18604B310", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LGIHGEEPMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5490", Offset = "0x1CA4890", VA = "0x181CA5490")]
	public static int GGIDBMEKBGO(int AMJKHBKANHA, int AODJOFINBIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GJFBELECDBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 JFHONIGGHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 MNMBKDHBFIL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly GJFBELECDBB EPJKIOGMFIO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly GJFBELECDBB INDMNNFEIGN;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6045A70", Offset = "0x6044E70", VA = "0x186045A70")]
	public GJFBELECDBB(float4x4 BNDKJOJPCED, float4 HNBAKNKPKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6045900", Offset = "0x6044D00", VA = "0x186045900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct PPOHBOFLEAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 BCGGHPIMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 KELADLMJIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 HCIGGIBPMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 FEAOFOBCCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 JCFPGGLKLAL;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KGCKIPDKDAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 BCGGHPIMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 KELADLMJIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 HCIGGIBPMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 FEAOFOBCCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 JCFPGGLKLAL;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct MIEFENKAIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public KGCKIPDKDAJ JOFGHLOEGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public KGCKIPDKDAJ ENOGNLDDANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public KGCKIPDKDAJ EIBHCMEDNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public KGCKIPDKDAJ EIPHGADNMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public KGCKIPDKDAJ NKPOLOLCCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public KGCKIPDKDAJ ALEELMFHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public KGCKIPDKDAJ BLEMGONHINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public KGCKIPDKDAJ NGMPBGAEACB;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct NJFINIDGGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public PPOHBOFLEAA JOFGHLOEGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public PPOHBOFLEAA ENOGNLDDANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public PPOHBOFLEAA EIBHCMEDNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public PPOHBOFLEAA EIPHGADNMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public PPOHBOFLEAA NKPOLOLCCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public PPOHBOFLEAA ALEELMFHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public PPOHBOFLEAA BLEMGONHINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public PPOHBOFLEAA NGMPBGAEACB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct KJNDBMJJPCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 KDEDJMGHNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint BJJHJJMPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint JDDFBAGKFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float FMKBMMODDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint KCPLFCKJODL;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6046460", Offset = "0x6045860", VA = "0x186046460")]
	public KJNDBMJJPCD(IJLEBOMIJAE DELNJNDMHJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PFGPJPELELI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint LBFGHJCMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint FIIJHNCOGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint DBDBAMCAMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint KCPLFCKJODL;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6052070", Offset = "0x6051470", VA = "0x186052070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GCCAKNAHCGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint LJELLNJHGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint BNNFNOOJDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint IDHFPPGCGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint KCPLFCKJODL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6045850", Offset = "0x6044C50", VA = "0x186045850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct OBDGOOLHACB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint OMKFAPMKJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint CJMMMPHDOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint HHBIJBBOGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint JBOPBNLCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint DOIJNAAMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint BDKEBAKGPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint BENDDMPHHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint KCPLFCKJODL;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x604A4D0", Offset = "0x60498D0", VA = "0x18604A4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct PDMOADDHNFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 MFMGCNLCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 NLKOCKPPNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 KLLDNMFBAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 OMCOKGMDIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 JGEIHKHDHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 CLPNPOPNEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 OLOEAINKLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 DGDCLJNGICI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6051C70", Offset = "0x6051070", VA = "0x186051C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum JMNKKLAAOID
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
