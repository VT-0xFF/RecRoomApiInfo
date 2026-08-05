using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct BLCNPGKNBKK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Hash128 MJGHJAIEBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float4 LGNAGNHNKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA89D50", Offset = "0xA88B50", VA = "0x180A89D50")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DHMDOLOJIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x838BF0", Offset = "0x8379F0", VA = "0x180838BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KEFMNMGDHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x93BE30", Offset = "0x93AC30", VA = "0x18093BE30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public float NKFDDOEOLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB9CFF0", Offset = "0xB9BDF0", VA = "0x180B9CFF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62E6060", Offset = "0x62E4E60", VA = "0x1862E6060")]
	public BLCNPGKNBKK(Color OPEMNAAFCJM, int OABBAKKLDGP, int LMGCLJPIIAF, float PBCEECBIEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x48E8A50", Offset = "0x48E7850", VA = "0x1848E8A50")]
	private static float4 KHKGBHDDOHI(Color OPEMNAAFCJM)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62E5FB0", Offset = "0x62E4DB0", VA = "0x1862E5FB0")]
	private static Hash128 EJOPFOHJAJN(BLCNPGKNBKK PBOPNMPDGAA)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DOFNKLGKCDA : NDLCPFHPLHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly string GBPFFENBHOI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly string OGIDCOHFDJL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly string JDGJOADDICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BLCNPGKNBKK GJCDHDEGAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private JPNLDHBHCMP DMHFIODFBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Hash128 AFJLIIAEBND;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BFEIGLAIJMP CNODGJMMCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBC2900", Offset = "0xBC1700", VA = "0x180BC2900")]
		[CompilerGenerated]
		get
		{
			return default(BFEIGLAIJMP);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBC2AE0", Offset = "0xBC18E0", VA = "0x180BC2AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OGEGAMMIBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBA5410", Offset = "0xBA4210", VA = "0x180BA5410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBA5660", Offset = "0xBA4460", VA = "0x180BA5660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NDNGCBJBMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xBA5630", Offset = "0xBA4430", VA = "0x180BA5630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBA5880", Offset = "0xBA4680", VA = "0x180BA5880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LKBABBDBPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool EHCFBOFMLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xE23400", Offset = "0xE22200", VA = "0x180E23400", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE23430", Offset = "0xE22230", VA = "0x180E23430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PGIEFBHCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBC2900", Offset = "0xBC1700", VA = "0x180BC2900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62EA040", Offset = "0x62E8E40", VA = "0x1862EA040")]
	public DOFNKLGKCDA(BLCNPGKNBKK NEOHGOGPALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62E99F0", Offset = "0x62E87F0", VA = "0x1862E99F0")]
	private bool DELADNEDGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62E9B30", Offset = "0x62E8930", VA = "0x1862E9B30", Slot = "4")]
	public bool IMFFJGIMDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62E9990", Offset = "0x62E8790", VA = "0x1862E9990")]
	private static JPNLDHBHCMP AOOIECJICFE(BLCNPGKNBKK PBOPNMPDGAA)
	{
		return default(JPNLDHBHCMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62E9CD0", Offset = "0x62E8AD0", VA = "0x1862E9CD0", Slot = "5")]
	public bool OAHLJJFNGDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62E9E60", Offset = "0x62E8C60", VA = "0x1862E9E60", Slot = "6")]
	public void OIPPMFBKPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PMADNKLIJMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JPCNIIPEAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGBGHEPHCBF LFDOEOPNCNK(int MNODNKMNJDN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 KCPGDDFACBP(int MNODNKMNJDN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OKJPIDOHDOO BGHMNEIEBLC();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BLCNPGKNBKK ONFLIDOACPH();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EODFBPNMFMP : NDLCPFHPLHL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OKJPIDOHDOO NCDMMOPONFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Transform DGILGMGMOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public List<CLHBEBJLONB> EAFBPJHGBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DOFNKLGKCDA IEHFLGNMIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AAMMBFCCKBI AFHJKFMNDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BFEIGLAIJMP BFPIBDPNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private BFEIGLAIJMP ECJMPJOIPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool IGJBKIBCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private PMADNKLIJMC HNKHKMKHJLB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float HKNGHCNCHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24E8670", Offset = "0x24E7470", VA = "0x1824E8670")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xBEA550", Offset = "0xBE9350", VA = "0x180BEA550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OGEGAMMIBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x96EF10", Offset = "0x96DD10", VA = "0x18096EF10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8950", Offset = "0x1AC7750", VA = "0x181AC8950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NDNGCBJBMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x12C27F0", Offset = "0x12C15F0", VA = "0x1812C27F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BDA760", Offset = "0x3BD9560", VA = "0x183BDA760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EHCFBOFMLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62EA4B0", Offset = "0x62E92B0", VA = "0x1862EA4B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62EA790", Offset = "0x62E9590", VA = "0x1862EA790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool LKBABBDBPON
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62EA4A0", Offset = "0x62E92A0", VA = "0x1862EA4A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62EB840", Offset = "0x62EA640", VA = "0x1862EB840")]
	public EODFBPNMFMP(PMADNKLIJMC PBOPNMPDGAA, bool HLMMGKKOCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62EA4C0", Offset = "0x62E92C0", VA = "0x1862EA4C0")]
	private bool DELADNEDGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62EA7A0", Offset = "0x62E95A0", VA = "0x1862EA7A0", Slot = "4")]
	public bool IMFFJGIMDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62EB430", Offset = "0x62EA230", VA = "0x1862EB430", Slot = "5")]
	public bool OAHLJJFNGDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62EB660", Offset = "0x62EA460", VA = "0x1862EB660", Slot = "6")]
	public void OIPPMFBKPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62EA780", Offset = "0x62E9580", VA = "0x1862EA780", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleRendererFeature]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BBOIAPKJPFP opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static BDLJFIBKGON CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62EE7A0", Offset = "0x62ED5A0", VA = "0x1862EE7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x62EE7E0", Offset = "0x62ED5E0", VA = "0x1862EE7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62EE140", Offset = "0x62ECF40", VA = "0x1862EE140", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62EE110", Offset = "0x62ECF10", VA = "0x1862EE110", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer BMFFGJEAEEP, ref RenderingData EMDEABCMBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62EE5F0", Offset = "0x62ED3F0", VA = "0x1862EE5F0")]
		public void HGLIPLOABJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DCCF50", Offset = "0x1DCBD50", VA = "0x181DCCF50")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KNAJPPEHJLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ulong OCMLMHOKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ulong BFNDOKFMLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class INFBDGCLCFI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct PMPGPLOKCNK : KNAJPPEHJLM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IDisposable DNKBKEJDAPM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ulong OCMLMHOKCIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x989080", Offset = "0x987E80", VA = "0x180989080", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xF315A0", Offset = "0xF303A0", VA = "0x180F315A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ulong BFNDOKFMLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89BCE0", Offset = "0x89AAE0", VA = "0x18089BCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x62EEB60", Offset = "0x62ED960", VA = "0x1862EEB60")]
		internal PMPGPLOKCNK(IDisposable HJNFDEBMDMK, ulong FDEPMLCJGLD, ulong LOBNLGDLKIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62EEAF0", Offset = "0x62ED8F0", VA = "0x1862EEAF0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct ABNAFKHLIII : KNAJPPEHJLM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private RenderTexture PHLOOGOKCHA;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ulong OCMLMHOKCIC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x989080", Offset = "0x987E80", VA = "0x180989080", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xF315A0", Offset = "0xF303A0", VA = "0x180F315A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ulong BFNDOKFMLNF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x89BCE0", Offset = "0x89AAE0", VA = "0x18089BCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x62DD120", Offset = "0x62DBF20", VA = "0x1862DD120")]
		public ABNAFKHLIII(RenderTexture FPPMMLIBFIN, ulong CIDKENFEEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62DD080", Offset = "0x62DBE80", VA = "0x1862DD080", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static ulong MBPJJLGLHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x62EBD30", Offset = "0x62EAB30", VA = "0x1862EBD30")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62EBD70", Offset = "0x62EAB70", VA = "0x1862EBD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static ulong CBLKOPKFLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x62EC320", Offset = "0x62EB120", VA = "0x1862EC320")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62EC360", Offset = "0x62EB160", VA = "0x1862EC360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62EBDB0", Offset = "0x62EABB0", VA = "0x1862EBDB0")]
	public static ComputeBuffer FLOGCKGNDEE(int FNLBOMKPGBB, int ANHJMPIBLMI, ComputeBufferType LKLFHGBOOLP, out KNAJPPEHJLM PDHOEHKDKMC, ComputeBufferMode MCDJPGPBKAG = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62EBF80", Offset = "0x62EAD80", VA = "0x1862EBF80")]
	public static RenderTexture FLOGCKGNDEE(int JGPNGKDAHKB, int OAIIPMIIANM, int CKMKAPIFBLB, RenderTextureFormat DLJPLGLNMPN, out KNAJPPEHJLM PDHOEHKDKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25E81E0", Offset = "0x25E6FE0", VA = "0x1825E81E0")]
	public static NativeArray<T> BNIOPNBBHDH<T>(NativeArray<T> DNKBKEJDAPM, ulong CNKKOGIEKAD, out KNAJPPEHJLM PDHOEHKDKMC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25E9040", Offset = "0x25E7E40", VA = "0x1825E9040")]
	public static NativeArray<T> FLOGCKGNDEE<T>(int CNKKOGIEKAD, Allocator FIPHDKMNFDJ, out KNAJPPEHJLM PDHOEHKDKMC, NativeArrayOptions PJMJNHMCCBP = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	public static NativeArray<T> FLOGCKGNDEE<T>(T[] PKPHLPFOPGM, Allocator FIPHDKMNFDJ, out KNAJPPEHJLM PDHOEHKDKMC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	public static NativeArray<T> FLOGCKGNDEE<T>(NativeArray<T> PKPHLPFOPGM, Allocator FIPHDKMNFDJ, out KNAJPPEHJLM PDHOEHKDKMC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62EC3A0", Offset = "0x62EB1A0", VA = "0x1862EC3A0")]
	public static void MBKJDOLMADL(KNAJPPEHJLM DNKBKEJDAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62EC660", Offset = "0x62EB460", VA = "0x1862EC660")]
	public static uint MGIECCCGKCP(RenderTextureFormat DLJPLGLNMPN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62EC4F0", Offset = "0x62EB2F0", VA = "0x1862EC4F0")]
	public static uint MGIECCCGKCP(GraphicsFormat DLJPLGLNMPN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BLPEDGOEBGJ : OJPIJENINJL<AAMMBFCCKBI, AAMMBFCCKBI>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct LHECJFGJPMM : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		private NativeArray<int> DKOEBDCJCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		private NativeArray<float> JPGJPJAGFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[WriteOnly]
		private NativeArray<float4x4> BEHODELONNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[WriteOnly]
		private NativeArray<float4> EKHFEJIIJMK;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x175C240", Offset = "0x175B040", VA = "0x18175C240")]
		public LHECJFGJPMM(NativeArray<int> BOFAFPNFFDN, NativeArray<float> EHPKOECKPEK, NativeArray<float4x4> JEBPNELFCHB, NativeArray<float4> KNLCHJPAODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x62ED570", Offset = "0x62EC370", VA = "0x1862ED570", Slot = "4")]
		public void Execute(int FHOMILACEHB, TransformAccess NCDMMOPONFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct FIBMCHPOABK : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[ReadOnly]
		private NativeArray<int> DKOEBDCJCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[ReadOnly]
		private NativeArray<float4x4> LFIGGLHOFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[ReadOnly]
		private NativeArray<float4> BPEALAPDNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[WriteOnly]
		private NativeArray<AAMMBFCCKBI> DPFIOINBMKO;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x175C240", Offset = "0x175B040", VA = "0x18175C240")]
		public FIBMCHPOABK(NativeArray<int> BOFAFPNFFDN, NativeArray<float4x4> IDNNEHFBIDB, NativeArray<float4> NLIOIODEGLD, NativeArray<AAMMBFCCKBI> FCAKJLDDKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62EBBE0", Offset = "0x62EA9E0", VA = "0x1862EBBE0", Slot = "4")]
		public void Execute(int FHOMILACEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const byte CGHJGIACLDE = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TransformAccessArray IEEEKFCPCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<float> CICIDOJDOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<float4x4> FDKMMFIJFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeArray<float4> PPDNHFIAAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> KOHELCDAHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<int> JCOJPMNCLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KNAJPPEHJLM PNKCKJHDFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private KNAJPPEHJLM OBONLINIHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KNAJPPEHJLM ABKHLHHMFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KNAJPPEHJLM OEKPJEIEFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private KNAJPPEHJLM LHGGEKCENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform INLBNGBBPHD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62E67F0", Offset = "0x62E55F0", VA = "0x1862E67F0")]
	public BLPEDGOEBGJ(int JBOOBKPCPCD, int CMLFLPAMCON, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62E62F0", Offset = "0x62E50F0", VA = "0x1862E62F0", Slot = "11")]
	protected override void FKCIFKGMNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62E6230", Offset = "0x62E5030", VA = "0x1862E6230")]
	private void FADBPLIHCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x62E66A0", Offset = "0x62E54A0", VA = "0x1862E66A0")]
	public bool PFEIINHDBAN(BFEIGLAIJMP PDHOEHKDKMC, Transform NCDMMOPONFH, float AIACCLLLALE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x62E6500", Offset = "0x62E5300", VA = "0x1862E6500")]
	public void GCEIBMJPLBM(BFEIGLAIJMP PDHOEHKDKMC, float AIACCLLLALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x62E6620", Offset = "0x62E5420", VA = "0x1862E6620")]
	public void LLDEHIMOMCJ(BFEIGLAIJMP PDHOEHKDKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62E65D0", Offset = "0x62E53D0", VA = "0x1862E65D0", Slot = "12")]
	public override void GMKNPONLEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x62E6180", Offset = "0x62E4F80", VA = "0x1862E6180", Slot = "13")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BBOIAPKJPFP : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private BDLJFIBKGON JOBANOODIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private bool HECCKGMOGMB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static bool CCPELBNGCCP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62DDB40", Offset = "0x62DC940", VA = "0x1862DDB40")]
	public BBOIAPKJPFP(BDLJFIBKGON HCPMFFBJECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62DDA20", Offset = "0x62DC820", VA = "0x1862DDA20", Slot = "4")]
	public override void OnCameraSetup(CommandBuffer LHKPOPIFCNM, ref RenderingData EMDEABCMBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62DD6C0", Offset = "0x62DC4C0", VA = "0x1862DD6C0", Slot = "5")]
	public override void Configure(CommandBuffer LHKPOPIFCNM, RenderTextureDescriptor CEABJGDLDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x62DD700", Offset = "0x62DC500", VA = "0x1862DD700", Slot = "8")]
	public override void Execute(ScriptableRenderContext CNBGAPJABKP, ref RenderingData EMDEABCMBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class LIHJFBJCKBP : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BDLJFIBKGON JOBANOODIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool HECCKGMOGMB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x62DDB40", Offset = "0x62DC940", VA = "0x1862DDB40")]
	public LIHJFBJCKBP(BDLJFIBKGON HCPMFFBJECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62DDA20", Offset = "0x62DC820", VA = "0x1862DDA20", Slot = "4")]
	public override void OnCameraSetup(CommandBuffer LHKPOPIFCNM, ref RenderingData EMDEABCMBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62DD6C0", Offset = "0x62DC4C0", VA = "0x1862DD6C0", Slot = "5")]
	public override void Configure(CommandBuffer LHKPOPIFCNM, RenderTextureDescriptor CEABJGDLDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62EDB20", Offset = "0x62EC920", VA = "0x1862EDB20", Slot = "8")]
	public override void Execute(ScriptableRenderContext CNBGAPJABKP, ref RenderingData EMDEABCMBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AFPGODFCHDD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public readonly struct FBHKOFOJLBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly string PPPOJKMOIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly CommandBuffer LHKPOPIFCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly ScriptableRenderContext CNBGAPJABKP;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62EB990", Offset = "0x62EA790", VA = "0x1862EB990")]
		public FBHKOFOJLBC(string NBIGIBEKOEK, ScriptableRenderContext NGNJAMJFKOF, out CommandBuffer MBGIPEEOBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62EB900", Offset = "0x62EA700", VA = "0x1862EB900", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x62DD150", Offset = "0x62DBF50", VA = "0x1862DD150")]
	public static bool CDBAKMEFKEP(RenderingData EMDEABCMBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62DD2E0", Offset = "0x62DC0E0", VA = "0x1862DD2E0")]
	public static void KAAFCAMGJPA(CommandBuffer LHKPOPIFCNM, ScriptableRenderContext CNBGAPJABKP, ShadowDrawingSettings OAHFBIINMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62DD480", Offset = "0x62DC280", VA = "0x1862DD480")]
	public static void KINMHNCFJMC(CommandBuffer LHKPOPIFCNM, ScriptableRenderContext CNBGAPJABKP, RenderingData EMDEABCMBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OOKCAODEMKN : OJPIJENINJL<EJLMIIFPMLK, EJLMIIFPMLK>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x62EEA40", Offset = "0x62ED840", VA = "0x1862EEA40")]
	public OOKCAODEMKN(int JBOOBKPCPCD, int CMLFLPAMCON, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FCJEMKPLNBA : OJPIJENINJL<JPNLDHBHCMP, JPNLDHBHCMP>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62EBA80", Offset = "0x62EA880", VA = "0x1862EBA80")]
	public FCJEMKPLNBA(int JBOOBKPCPCD, int CMLFLPAMCON, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CNNLCCGGHFI : OJPIJENINJL<IFHKHNHNCMN, IFHKHNHNCMN>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62E85F0", Offset = "0x62E73F0", VA = "0x1862E85F0")]
	public CNNLCCGGHFI(int JBOOBKPCPCD, int CMLFLPAMCON, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FHJDHHJEPKG : OJPIJENINJL<EKPMCJMLFIG, LIJELFPHOBC>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62EBB30", Offset = "0x62EA930", VA = "0x1862EBB30")]
	public FHJDHHJEPKG(int JBOOBKPCPCD, int CMLFLPAMCON, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OJPPAKGDPGL : OJPIJENINJL<JIAOCNALJBB, JIAOCNALJBB>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62EE990", Offset = "0x62ED790", VA = "0x1862EE990")]
	public OJPPAKGDPGL(int JBOOBKPCPCD, int CMLFLPAMCON, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IAGFDJMLPAF<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private KNAJPPEHJLM IMNHPHEGGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private KNAJPPEHJLM FKJFOAFOFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ComputeBuffer NFACOKBOMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private RenderTexture GHNBDMCPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private int DJCHKKOKFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int MLIMJLFGPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private string NAPOHJOLLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private string ADBFJEDHEJF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x91A270", Offset = "0x919070", VA = "0x18091A270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int GINCMKIAHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x958760", Offset = "0x957560", VA = "0x180958760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GFECDOIMOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x91A1E0", Offset = "0x918FE0", VA = "0x18091A1E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x365F2F0", Offset = "0x365E0F0", VA = "0x18365F2F0")]
	public IAGFDJMLPAF(string PPPOJKMOIGD, int IIEEKGLMOGE, [Optional] RenderTextureFormat? DLJPLGLNMPN, bool ACJONFKBJJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x365EC60", Offset = "0x365DA60", VA = "0x18365EC60")]
	public void OAHLJJFNGDE(CommandBuffer LHKPOPIFCNM, NativeArray<ValType> FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x365CE10", Offset = "0x365BC10", VA = "0x18365CE10")]
	public void EIONPNLIDGN(CommandBuffer LHKPOPIFCNM, ComputeShader GCFIJOEEPMH, int OBECEKGOIID, int BBCOKGPCCGP = -1, int EGJKFGOHDBP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x365D070", Offset = "0x365BE70", VA = "0x18365D070")]
	public void EIONPNLIDGN(Material DMHFIODFBBK, int BBCOKGPCCGP = -1, int EGJKFGOHDBP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x365E930", Offset = "0x365D730", VA = "0x18365E930")]
	public AsyncGPUReadbackRequest LNPLOIEJGEE(ref NativeArray<ValType> FCAKJLDDKGP)
	{
		return default(AsyncGPUReadbackRequest);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x365E5B0", Offset = "0x365D3B0", VA = "0x18365E5B0")]
	public AsyncGPUReadbackRequest JMAPPJOCDEI(ref NativeArray<ValType> FCAKJLDDKGP, int IMEJPNOGNLF = 0)
	{
		return default(AsyncGPUReadbackRequest);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x365BFF0", Offset = "0x365ADF0", VA = "0x18365BFF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JIAGCCIBFNA
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int PLNCEALNDOA = 4096;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public const int GOMOBHDILJJ = 64;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public const int MMCENIECNKK = 128;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const int AHECBAAHOJA = 192;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public const int HJLGDGNDANN = 32768;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public const int HPEICJGJAPB = 18432;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public const int FMFMEPNHLLB = 131072;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const int EHNOOKOCNAN = 2359296;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int EJCJHJADNKG = 3538944;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const int JLOHJCPEGHP = 4096;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const int GKAMBKMPCMJ = 8;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const int MDDLCHOBIIC = 24;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public const int BOMEDEHELJH = 8;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const int IDINFDGNAMC = 8;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const int BKLCJJOMEKC = 128;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const int JFMLIAJIJIJ = 256;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const int FFBFDLMICIC = 512;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public const int GHONDKLHLOH = 8192;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public const int JFIACDCEEKL = 32;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public const int BIKBJAJGGKB = 65536;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public const int LMMHGFJBFMI = 98304;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public const int PNJEPKKMFGP = 8;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public const int CDFJKNBMFOG = 24;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public const int LMNECAOGAOB = 8192;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public const int HEBMCPJBKCD = 4096;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly int[] JFFALLMHGFB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly uint[] IJMLHHMDJMP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public const int NNOJLGLAEHH = 131072;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public const int PNEEKFOBKFE = 294912;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly string[] KBBFHIDAEHD;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1A62C80", Offset = "0x1A61A80", VA = "0x181A62C80")]
	public static int PGLAGCDFPCC(KANADDAEOJJ HIICPNGGJEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x62EC800", Offset = "0x62EB600", VA = "0x1862EC800")]
	public static int BEEAAKBBGFE(KANADDAEOJJ HIICPNGGJEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x62EC770", Offset = "0x62EB570", VA = "0x1862EC770")]
	public static uint AAJKIOKIHCC(KANADDAEOJJ HIICPNGGJEO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EGBGHEPHCBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIAHFJAFHAI NMCJFPPLLME();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BJHCPPJNGFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Hash128 MJGHJAIEBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int CBIILOCHHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int NAEBGGCKKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NativeArray<float3> GPDHMHFIABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	NativeArray<float3> DACGJJJBIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NativeArray<float4> JOCNMGFMMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	NativeArray<int> DABGHAKJKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	NativeArray<float2> LGACFIJLHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	NativeArray<float4> JFCFBNIHECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	int MAHKEPCDPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int IMMJPCPMPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int NFDEDOGLCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DJNJOGHJPME
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PAMMNIOAPOL();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LIBBFPOEOFC : BJHCPPJNGFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private EGBGHEPHCBF CDDEIOODJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private JIAHFJAFHAI GFNFNFOOGBL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Hash128 MJGHJAIEBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA89D50", Offset = "0xA88B50", VA = "0x180A89D50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA89D40", Offset = "0xA88B40", VA = "0x180A89D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool FJPBKJHDDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9364C0", Offset = "0x9352C0", VA = "0x1809364C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9FECB0", Offset = "0x9FDAB0", VA = "0x1809FECB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CBIILOCHHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x93BE30", Offset = "0x93AC30", VA = "0x18093BE30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x952E20", Offset = "0x951C20", VA = "0x180952E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NAEBGGCKKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x93D1F0", Offset = "0x93BFF0", VA = "0x18093D1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8FE380", Offset = "0x8FD180", VA = "0x1808FE380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int CFBLGNEPLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9D65C0", Offset = "0x9D53C0", VA = "0x1809D65C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9D64C0", Offset = "0x9D52C0", VA = "0x1809D64C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public NativeArray<float3> GPDHMHFIABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62ED810", Offset = "0x62EC610", VA = "0x1862ED810", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NativeArray<float3> DACGJJJBIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62ED8A0", Offset = "0x62EC6A0", VA = "0x1862ED8A0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NativeArray<float4> JOCNMGFMMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62ED990", Offset = "0x62EC790", VA = "0x1862ED990", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NativeArray<int> DABGHAKJKLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62ED8F0", Offset = "0x62EC6F0", VA = "0x1862ED8F0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NativeArray<float2> LGACFIJLHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62ED740", Offset = "0x62EC540", VA = "0x1862ED740", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NativeArray<float4> JFCFBNIHECL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x62ED960", Offset = "0x62EC760", VA = "0x1862ED960", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DJNJOGHJPME
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x91A1F0", Offset = "0x918FF0", VA = "0x18091A1F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x90DA70", Offset = "0x90C870", VA = "0x18090DA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MAHKEPCDPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62ED770", Offset = "0x62EC570", VA = "0x1862ED770", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int IMMJPCPMPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x62ED880", Offset = "0x62EC680", VA = "0x1862ED880", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int NFDEDOGLCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62ED8D0", Offset = "0x62EC6D0", VA = "0x1862ED8D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62EDAD0", Offset = "0x62EC8D0", VA = "0x1862EDAD0")]
	public LIBBFPOEOFC(Hash128 JBJGEACIMDC, EGBGHEPHCBF CDDEIOODJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62ED9C0", Offset = "0x62EC7C0", VA = "0x1862ED9C0", Slot = "16")]
	public void PAMMNIOAPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62ED780", Offset = "0x62EC580", VA = "0x1862ED780", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BFEIGLAIJMP : IEquatable<BFEIGLAIJMP>
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly BFEIGLAIJMP IOPEGLNHBHH;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public readonly int PGIEFBHCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400")]
	public BFEIGLAIJMP(int FHOMILACEHB = -1)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x18F6220", Offset = "0x18F5020", VA = "0x1818F6220")]
	public static bool DDONPFMGGHF(BFEIGLAIJMP MDKJCMEMIDH, BFEIGLAIJMP BGNJLPDNBMK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x18F6230", Offset = "0x18F5030", VA = "0x1818F6230")]
	public static bool HDFILCNJOKD(BFEIGLAIJMP MDKJCMEMIDH, BFEIGLAIJMP BGNJLPDNBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x18F6100", Offset = "0x18F4F00", VA = "0x1818F6100", Slot = "4")]
	public bool Equals(BFEIGLAIJMP FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62E5EE0", Offset = "0x62E4CE0", VA = "0x1862E5EE0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xE3E340", Offset = "0xE3D140", VA = "0x180E3E340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CLHBEBJLONB : NDLCPFHPLHL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool IGJBKIBCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private BJHCPPJNGFI EBGEJKPJDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private List<BFEIGLAIJMP> JNGFFLOIAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<BFEIGLAIJMP> FLNHDJMAAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<BFEIGLAIJMP> OPHHMFFLKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Dictionary<int, uint> CJGNMCJBNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int NCMEACOFHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int LDPHFEEPCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int LMKEFFFLBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int MLHMGPGENDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int LHMFMLNBFCG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int PGIEFBHCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62E6D90", Offset = "0x62E5B90", VA = "0x1862E6D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62E6E30", Offset = "0x62E5C30", VA = "0x1862E6E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OGEGAMMIBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83B610", Offset = "0x83A410", VA = "0x18083B610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8040B0", Offset = "0x802EB0", VA = "0x1808040B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NDNGCBJBMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83B620", Offset = "0x83A420", VA = "0x18083B620")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9E9C70", Offset = "0x9E8A70", VA = "0x1809E9C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LKBABBDBPON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EHCFBOFMLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83B640", Offset = "0x83A440", VA = "0x18083B640", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x11E0140", Offset = "0x11DEF40", VA = "0x1811E0140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public float HKNGHCNCHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD78CB0", Offset = "0xD77AB0", VA = "0x180D78CB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBF4A20", Offset = "0xBF3820", VA = "0x180BF4A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x62E8490", Offset = "0x62E7290", VA = "0x1862E8490")]
	public CLHBEBJLONB(BJHCPPJNGFI GFNFNFOOGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x62E79F0", Offset = "0x62E67F0", VA = "0x1862E79F0")]
	private void OCONELDGOGM(BJHCPPJNGFI GFNFNFOOGBL, int NCMEACOFHGP, int FJEPJEEIAJH, ref int FHOMILACEHB, ref int JPPPJKAIEMD, ref GBNHPCFPIFF FAJCHBCCGOJ, ref float KIMHEDIKOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x62E76C0", Offset = "0x62E64C0", VA = "0x1862E76C0")]
	private void MAAKCOFKBCJ(BJHCPPJNGFI GFNFNFOOGBL, int JILDHAMNNBA, ref int FHOMILACEHB, ref uint3 ODFMDLAFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x62E6A40", Offset = "0x62E5840", VA = "0x1862E6A40")]
	private bool DELADNEDGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x62E6E70", Offset = "0x62E5C70", VA = "0x1862E6E70", Slot = "4")]
	public bool IMFFJGIMDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x62E7970", Offset = "0x62E6770", VA = "0x1862E7970", Slot = "5")]
	public bool OAHLJJFNGDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62E7EB0", Offset = "0x62E6CB0", VA = "0x1862E7EB0", Slot = "6")]
	public void OIPPMFBKPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x62E6D30", Offset = "0x62E5B30", VA = "0x1862E6D30")]
	public void LKPLPMGPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x62E6D30", Offset = "0x62E5B30", VA = "0x1862E6D30", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BDFCJJLFANI
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEHHCBGOMLP(CommandBuffer LHKPOPIFCNM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct EKCEJJNOJBH : BDFCJJLFANI
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public readonly int JMLLMANMBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public readonly RenderTargetIdentifier BGGBOGPFJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2644700", Offset = "0x2643500", VA = "0x182644700")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x62EA480", Offset = "0x62E9280", VA = "0x1862EA480")]
	public EKCEJJNOJBH(int PJCEAFJNLLG, RenderTargetIdentifier FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x62EA430", Offset = "0x62E9230", VA = "0x1862EA430", Slot = "4")]
	public void HEHHCBGOMLP(CommandBuffer LHKPOPIFCNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JILIFEJDDGK : BDFCJJLFANI
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int JMLLMANMBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public readonly Vector4[] MLFIDDECLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x989080", Offset = "0x987E80", VA = "0x180989080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x9460E0", Offset = "0x944EE0", VA = "0x1809460E0")]
	public JILIFEJDDGK(int PJCEAFJNLLG, Vector4[] FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62ED3E0", Offset = "0x62EC1E0", VA = "0x1862ED3E0", Slot = "4")]
	public void HEHHCBGOMLP(CommandBuffer LHKPOPIFCNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct OAFPJLLHLKP : BDFCJJLFANI
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public readonly int JMLLMANMBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public readonly float[] GDCOJOIHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x989080", Offset = "0x987E80", VA = "0x180989080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9460E0", Offset = "0x944EE0", VA = "0x1809460E0")]
	public OAFPJLLHLKP(int PJCEAFJNLLG, float[] FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62EE960", Offset = "0x62ED760", VA = "0x1862EE960", Slot = "4")]
	public void HEHHCBGOMLP(CommandBuffer LHKPOPIFCNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IABCAOKNODJ : BDFCJJLFANI
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public readonly string KGBBPCBIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public readonly bool LELEOIAOIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xD1B050", Offset = "0xD19E50", VA = "0x180D1B050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0xD21EF0", Offset = "0xD20CF0", VA = "0x180D21EF0")]
	public IABCAOKNODJ(string PPPOJKMOIGD, bool HECCKGMOGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x62EBC40", Offset = "0x62EAA40", VA = "0x1862EBC40", Slot = "4")]
	public void HEHHCBGOMLP(CommandBuffer LHKPOPIFCNM)
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x62EDE40", Offset = "0x62ECC40", VA = "0x1862EDE40", Slot = "0")]
		public override bool Equals(object FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x62EE060", Offset = "0x62ECE60", VA = "0x1862EE060", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xD69BC0", Offset = "0xD689C0", VA = "0x180D69BC0")]
		public MClusterData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JPEHINCFNLF
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAMMNIOAPOL(CommandBuffer LHKPOPIFCNM);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAMMNIOAPOL(CommandBuffer LHKPOPIFCNM, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE = -1, int OPNDKPOHAIN = -1, int MOFELFOFKPI = -1, int MEJPCFKLPPE = -1);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIONPNLIDGN(CommandBuffer LHKPOPIFCNM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIONPNLIDGN(CommandBuffer LHKPOPIFCNM, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE = -1);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EIONPNLIDGN(Material NEOHGOGPALD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMKNPONLEEK();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OJPIJENINJL<SrcEntry, DstEntry> : JPEHINCFNLF, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	protected bool[] OGIBKCPHPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	protected KNAJPPEHJLM LPHPEGDIFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	protected KNAJPPEHJLM PBIDGLEIPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected NativeArray<int> LHKPMJNALJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected NativeArray<SrcEntry> HLFLCGLNOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected int HDMEHBOBKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	protected int DOEDEMPKOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	protected IAGFDJMLPAF<int> GKEGBFMKOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected IAGFDJMLPAF<SrcEntry> IMKBANIHMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected IAGFDJMLPAF<DstEntry> IBDOMKNFEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected ComputeShader GBAIICHPDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	protected int IOKGKADFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	protected int PDJIKLKDLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	protected int CJDGPEAJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	protected int GCPJOEJGOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	protected int IFFDOAIAHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	protected int ACEMDOPABEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	protected int JNKBJOILHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	protected int BNHGNGLAEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	protected int MMGEMOIJHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	protected int CGGKGBOCAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected int AABIOCKMHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	protected int JFLNJLEDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected string JFKPHGKOLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	protected float[] OADKMOPKIFF;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int DICHNPPBGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4AF3870", Offset = "0x4AF2670", VA = "0x184AF3870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string CBPBAEIHMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4AF4300", Offset = "0x4AF3100", VA = "0x184AF4300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8FE0", Offset = "0x4AF7DE0", VA = "0x184AF8FE0")]
	public OJPIJENINJL(string PPPOJKMOIGD, int JBOOBKPCPCD, int CMLFLPAMCON, RenderTextureFormat DLJPLGLNMPN, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE = 0, int OPNDKPOHAIN = 0, int MOFELFOFKPI = 0, int MEJPCFKLPPE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4AF3880", Offset = "0x4AF2680", VA = "0x184AF3880")]
	public int DIGENEIDPED()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4AF3D60", Offset = "0x4AF2B60", VA = "0x184AF3D60")]
	protected void EEOBPDCONKI(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2035810", Offset = "0x2034610", VA = "0x182035810")]
	public int FFIKKOBKIJH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5B20", Offset = "0x4AF4920", VA = "0x184AF5B20")]
	public BFEIGLAIJMP IMFFJGIMDFG(ref SrcEntry FAJCHBCCGOJ)
	{
		return default(BFEIGLAIJMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6790", Offset = "0x4AF5590", VA = "0x184AF6790")]
	public bool OAHLJJFNGDE(BFEIGLAIJMP PDHOEHKDKMC, ref SrcEntry FAJCHBCCGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6B40", Offset = "0x4AF5940", VA = "0x184AF6B40")]
	public bool OIPPMFBKPAM(BFEIGLAIJMP PDHOEHKDKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "11")]
	protected virtual void FKCIFKGMNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6B90", Offset = "0x4AF5990", VA = "0x184AF6B90", Slot = "4")]
	public void PAMMNIOAPOL(CommandBuffer LHKPOPIFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4AF7540", Offset = "0x4AF6340", VA = "0x184AF7540", Slot = "5")]
	public void PAMMNIOAPOL(CommandBuffer LHKPOPIFCNM, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE = -1, int OPNDKPOHAIN = -1, int MOFELFOFKPI = -1, int MEJPCFKLPPE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4AF53A0", Offset = "0x4AF41A0", VA = "0x184AF53A0", Slot = "12")]
	public virtual void GMKNPONLEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4AF3F50", Offset = "0x4AF2D50", VA = "0x184AF3F50", Slot = "6")]
	public void EIONPNLIDGN(CommandBuffer LHKPOPIFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4AF3DC0", Offset = "0x4AF2BC0", VA = "0x184AF3DC0", Slot = "7")]
	public void EIONPNLIDGN(CommandBuffer LHKPOPIFCNM, ComputeShader KJLAIGKHGBP, int OKAGBMBHGCE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4AF3F90", Offset = "0x4AF2D90", VA = "0x184AF3F90", Slot = "8")]
	public void EIONPNLIDGN(Material DMHFIODFBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4AF39A0", Offset = "0x4AF27A0", VA = "0x184AF39A0", Slot = "13")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NDLCPFHPLHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool LKBABBDBPON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool EHCFBOFMLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IMFFJGIMDFG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAHLJJFNGDE();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIPPMFBKPAM();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DDPOKHCKFNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly float FNKOEPNOGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Dictionary<Hash128, CLHBEBJLONB> EAGCEJOOGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Dictionary<Hash128, DOFNKLGKCDA> DEPPJDKPABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Queue<NDLCPFHPLHL> EAAHMGNCGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Queue<NDLCPFHPLHL> LBFAIOHNOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Queue<NDLCPFHPLHL> MHEEPECFFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int BBLFGBAEIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int EKLKOEJBOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private float FBGCGLAEKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool CEFAHLNHEEN;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MPIKLPHMEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x958770", Offset = "0x957570", VA = "0x180958770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9588D0", Offset = "0x9576D0", VA = "0x1809588D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FLOJKEEOLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x62E87D0", Offset = "0x62E75D0", VA = "0x1862E87D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string CBPBAEIHMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62E8820", Offset = "0x62E7620", VA = "0x1862E8820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x62E92C0", Offset = "0x62E80C0", VA = "0x1862E92C0")]
	public void MBALOEILPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x62E92D0", Offset = "0x62E80D0", VA = "0x1862E92D0")]
	public void NLAEELKCOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x62E9820", Offset = "0x62E8620", VA = "0x1862E9820")]
	public DDPOKHCKFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x62E91A0", Offset = "0x62E7FA0", VA = "0x1862E91A0")]
	public EODFBPNMFMP MAHHBIDHLIK(PMADNKLIJMC EJBAOAKFGMC, bool HLMMGKKOCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x62E8DA0", Offset = "0x62E7BA0", VA = "0x1862E8DA0")]
	public DOFNKLGKCDA MAHHBIDHLIK(BLCNPGKNBKK DMHFIODFBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x62E8D30", Offset = "0x62E7B30", VA = "0x1862E8D30")]
	public bool IKOLJNFBCJA(Hash128 PJCEAFJNLLG, out CLHBEBJLONB CIHCLCHLEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x62E8EE0", Offset = "0x62E7CE0", VA = "0x1862E8EE0")]
	public CLHBEBJLONB MAHHBIDHLIK(BJHCPPJNGFI GFNFNFOOGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x62E92E0", Offset = "0x62E80E0", VA = "0x1862E92E0")]
	private void OILDOEDBMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x62E8CA0", Offset = "0x62E7AA0", VA = "0x1862E8CA0")]
	private bool HNGOEHPBLHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x62E9300", Offset = "0x62E8100", VA = "0x1862E9300")]
	public void PAMMNIOAPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x62E86A0", Offset = "0x62E74A0", VA = "0x1862E86A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x62E8BF0", Offset = "0x62E79F0", VA = "0x1862E8BF0")]
	public void GMKNPONLEEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BDLJFIBKGON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class NHLEBIOJJHO
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly int DOGNNJFKMCC;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly int BLNNGAGCJAP;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static IAGFDJMLPAF<NBCNECGLBOA> GJDEOAOPKPO;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static IAGFDJMLPAF<uint> OHMIIOAKGHI;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static KNAJPPEHJLM DIKPFOMPAFK;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static ComputeBuffer KDCMHONCGJF;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static List<JPEHINCFNLF> CCKMAGCPBEF;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int KENAFMGNPGC;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static int KEAKPMODOJL;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static int CPGNPHGMGDH;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static int EIKDPDCCAGK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static int[] GEGGLPDPJKE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static Material[] PLFFIAFLOOO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static BDFCJJLFANI[][] BODJEFHANIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Plane[] GOHHDLONJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GJKDPBCAGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int POBAIPNHAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int HAFLDLHOOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int KFOHDEOPPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int BPFFHGMACMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int DNPNBHLMOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int HLEGCMMEFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private int GBDOKPANJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private int GBBILHJADFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int DDDDGPFOEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int NFAJBHEOFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int BOHBPLAKPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int LOBHPPHHKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int GHJFAKKPDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int AGJABFDPKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int MFNHECCGGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int DMGFFKICBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int AOABFAHHECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private float[] JELLPEENEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private DDPOKHCKFNH FNKKOGDLNFH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool OKDOLLENOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x62E4CE0", Offset = "0x62E3AE0", VA = "0x1862E4CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62DE0A0", Offset = "0x62DCEA0", VA = "0x1862DE0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool DIOCDBGGGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x62DDCB0", Offset = "0x62DCAB0", VA = "0x1862DDCB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62DDC50", Offset = "0x62DCA50", VA = "0x1862DDC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData DKPMKJNEILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62DE040", Offset = "0x62DCE40", VA = "0x1862DE040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x62DDD70", Offset = "0x62DCB70", VA = "0x1862DDD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static BLPEDGOEBGJ IPAJPHDGPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x62DDE60", Offset = "0x62DCC60", VA = "0x1862DDE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x62E2900", Offset = "0x62E1700", VA = "0x1862E2900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static OOKCAODEMKN IIGENKOPFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62DF2A0", Offset = "0x62DE0A0", VA = "0x1862DF2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x62E0310", Offset = "0x62DF110", VA = "0x1862E0310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static FCJEMKPLNBA EEPDMIIFGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x62DE910", Offset = "0x62DD710", VA = "0x1862DE910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62E59D0", Offset = "0x62E47D0", VA = "0x1862E59D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static CNNLCCGGHFI HCLMBMEPFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x62DDD10", Offset = "0x62DCB10", VA = "0x1862DDD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x62DE9D0", Offset = "0x62DD7D0", VA = "0x1862DE9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static FHJDHHJEPKG PDONLEABGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x62E4E40", Offset = "0x62E3C40", VA = "0x1862E4E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x62DDBE0", Offset = "0x62DC9E0", VA = "0x1862DDBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static OJPPAKGDPGL DJJIJJLPEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x62E5AD0", Offset = "0x62E48D0", VA = "0x1862E5AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x62E5B30", Offset = "0x62E4930", VA = "0x1862E5B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material MIPOHBMIECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x62DE970", Offset = "0x62DD770", VA = "0x1862DE970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x62E1AD0", Offset = "0x62E08D0", VA = "0x1862E1AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material PCEJLOFOOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x62E5970", Offset = "0x62E4770", VA = "0x1862E5970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x62DDDE0", Offset = "0x62DCBE0", VA = "0x1862DDDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material JBKBLEJHHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x62DF370", Offset = "0x62DE170", VA = "0x1862DF370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x62DF300", Offset = "0x62DE100", VA = "0x1862DF300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material BFKJLKCCFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x62DEA40", Offset = "0x62DD840", VA = "0x1862DEA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x62E3010", Offset = "0x62E1E10", VA = "0x1862E3010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool EKNIPPNANFP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x62DDB80", Offset = "0x62DC980", VA = "0x1862DDB80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x62E1B40", Offset = "0x62E0940", VA = "0x1862E1B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FLOJKEEOLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x62DDFE0", Offset = "0x62DCDE0", VA = "0x1862DDFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string CBPBAEIHMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x62DEAA0", Offset = "0x62DD8A0", VA = "0x1862DEAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x62E5C20", Offset = "0x62E4A20", VA = "0x1862E5C20")]
	internal BDLJFIBKGON([Optional] MClusterData ELCFKIMONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x62E0380", Offset = "0x62DF180", VA = "0x1862E0380")]
	public void HFKECJNCAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x62DF3D0", Offset = "0x62DE1D0", VA = "0x1862DF3D0")]
	public void HBGGDHDFOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x62DDE50", Offset = "0x62DCC50", VA = "0x1862DDE50")]
	public void CPENMIKEIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x62DE100", Offset = "0x62DCF00", VA = "0x1862DE100")]
	public bool EOLMCALNDOM(Hash128 JBJGEACIMDC, out CLHBEBJLONB GFNFNFOOGBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x62E37C0", Offset = "0x62E25C0", VA = "0x1862E37C0")]
	public CLHBEBJLONB MAHHBIDHLIK(BJHCPPJNGFI FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x62E38A0", Offset = "0x62E26A0", VA = "0x1862E38A0")]
	public DOFNKLGKCDA MAHHBIDHLIK(BLCNPGKNBKK DMHFIODFBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x62E35F0", Offset = "0x62E23F0", VA = "0x1862E35F0")]
	public EODFBPNMFMP MAHHBIDHLIK(PMADNKLIJMC EJBAOAKFGMC, bool HLMMGKKOCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x62E5920", Offset = "0x62E4720", VA = "0x1862E5920")]
	public void OIPPMFBKPAM(NDLCPFHPLHL FODHHFDFGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x62E4D40", Offset = "0x62E3B40", VA = "0x1862E4D40")]
	public static void MJABLGCJGNM(KANADDAEOJJ HIICPNGGJEO, BDFCJJLFANI[] FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x62E4EA0", Offset = "0x62E3CA0", VA = "0x1862E4EA0")]
	private void NEGNDJGGEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x62DF480", Offset = "0x62DE280", VA = "0x1862DF480")]
	private static void HFCMAEIOLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x62E3270", Offset = "0x62E2070", VA = "0x1862E3270")]
	public void LLOALJODAJM(CommandBuffer LHKPOPIFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x62E3080", Offset = "0x62E1E80", VA = "0x1862E3080")]
	public void LECKBNHJPCL([Optional] ScriptableRenderContext? CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x62E2590", Offset = "0x62E1390", VA = "0x1862E2590")]
	public void KCKMJMIAFNI(CommandBuffer LHKPOPIFCNM, ShadowSplitData FHGACIKFFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x62E2230", Offset = "0x62E1030", VA = "0x1862E2230")]
	public void KCKMJMIAFNI(CommandBuffer LHKPOPIFCNM, CameraData CIMKHHAKJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x62DE1A0", Offset = "0x62DCFA0", VA = "0x1862DE1A0")]
	public void FAKJDJEFAKP(CommandBuffer LHKPOPIFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x62E5A40", Offset = "0x62E4840", VA = "0x1862E5A40")]
	public void PKLJHJPGIGG(CommandBuffer LHKPOPIFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x62E2970", Offset = "0x62E1770", VA = "0x1862E2970")]
	public void KNHGHLJLLKO(CommandBuffer LHKPOPIFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x62E1BA0", Offset = "0x62E09A0", VA = "0x1862E1BA0")]
	public void JNABKELPPCE(CommandBuffer LHKPOPIFCNM, KANADDAEOJJ GFPMOCBOGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x62E19E0", Offset = "0x62E07E0", VA = "0x1862E19E0")]
	public void HGLIPLOABJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x62E3AB0", Offset = "0x62E28B0", VA = "0x1862E3AB0")]
	public void MBKJDOLMADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x62DDEC0", Offset = "0x62DCCC0", VA = "0x1862DDEC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HFELFGELFEF
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	public static NativeArray<T> ELLLGBJHCKI<T>(T[] PEJGDDHHDBH, Allocator FIPHDKMNFDJ, out KNAJPPEHJLM PDHOEHKDKMC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	public static NativeArray<T> ELLLGBJHCKI<T>(T[] PEJGDDHHDBH, int CNKKOGIEKAD, Allocator FIPHDKMNFDJ, out KNAJPPEHJLM PDHOEHKDKMC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	public static NativeArray<T> ELLLGBJHCKI<T, U>(U[] PEJGDDHHDBH, Allocator FIPHDKMNFDJ, out KNAJPPEHJLM PDHOEHKDKMC) where T : struct where U : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	public static NativeArray<T> ELLLGBJHCKI<T, U>(U[] PEJGDDHHDBH, int CNKKOGIEKAD, Allocator FIPHDKMNFDJ, out KNAJPPEHJLM PDHOEHKDKMC) where T : struct where U : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	public static void APOGFBAMCGJ<T, U>(NativeArray<T> FCAKJLDDKGP, int FHMAJLHBFAD, U[] PEJGDDHHDBH, Allocator FIPHDKMNFDJ) where T : struct where U : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	public static void LOPMEOOAPHL<T>(NativeArray<T> FCAKJLDDKGP, int FHMAJLHBFAD, int CNKKOGIEKAD, byte IEGGAJNPOJC, Allocator FIPHDKMNFDJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9D10", Offset = "0x5AE8B10", VA = "0x185AE9D10")]
	public static int IJEOHFPPNHC(int EFGAFPEAGGO, int EHNNGDLIGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HFELFGELFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct AAMMBFCCKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float4x4 EMNPOIOFFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float4 BAGBGFGMGAP;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static readonly AAMMBFCCKBI AMNHDHLOALE;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly AAMMBFCCKBI IOPEGLNHBHH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x62DC7F0", Offset = "0x62DB5F0", VA = "0x1862DC7F0")]
	private static float4x4 IFCLKHIIGNP(float4x4 NCDMMOPONFH, float3 OLFLAEBOOJB)
	{
		return default(float4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x62DC940", Offset = "0x62DB740", VA = "0x1862DC940")]
	private static float4x4 IFCLKHIIGNP(float4x4 NCDMMOPONFH)
	{
		return default(float4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x62DCE00", Offset = "0x62DBC00", VA = "0x1862DCE00")]
	public AAMMBFCCKBI(Renderer BMFFGJEAEEP, float AIACCLLLALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x62DCCF0", Offset = "0x62DBAF0", VA = "0x1862DCCF0")]
	public AAMMBFCCKBI(TransformAccess FAADGLPPEOK, float AIACCLLLALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x62DCF30", Offset = "0x62DBD30", VA = "0x1862DCF30")]
	public AAMMBFCCKBI(Transform FAADGLPPEOK, float AIACCLLLALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x62DCB00", Offset = "0x62DB900", VA = "0x1862DCB00")]
	public AAMMBFCCKBI(OKJPIDOHDOO FAADGLPPEOK, float AIACCLLLALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x62DD050", Offset = "0x62DBE50", VA = "0x1862DD050")]
	public AAMMBFCCKBI(float4x4 GNBLCKFCLOF, float4 MPJOFDECAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x62DC990", Offset = "0x62DB790", VA = "0x1862DC990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct GBNHPCFPIFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public float4 IHHJAKDKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public float4 AEKDOICBOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public float4 ABAEHHOKHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public float4 MKCLBBNNOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public float4 BALFEDCCBED;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DBCCECBPIIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public float4 IHHJAKDKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public half4 AEKDOICBOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public half4 ABAEHHOKHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public half4 MKCLBBNNOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public half4 BALFEDCCBED;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct LIJELFPHOBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public DBCCECBPIIF BLALLNMHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public DBCCECBPIIF LGNHEPGKODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public DBCCECBPIIF MDKGIMFOIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public DBCCECBPIIF EIJDHLFDIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public DBCCECBPIIF HFJMANDIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public DBCCECBPIIF HEMCJEMOAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public DBCCECBPIIF LCINFHNNBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public DBCCECBPIIF MJKMFKEPHPH;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EKPMCJMLFIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public GBNHPCFPIFF BLALLNMHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public GBNHPCFPIFF LGNHEPGKODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public GBNHPCFPIFF MDKGIMFOIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public GBNHPCFPIFF EIJDHLFDIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public GBNHPCFPIFF HFJMANDIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public GBNHPCFPIFF HEMCJEMOAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public GBNHPCFPIFF LCINFHNNBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public GBNHPCFPIFF MJKMFKEPHPH;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct JPNLDHBHCMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public float4 NJCLJCKFJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public uint OABBAKKLDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public uint LMGCLJPIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float PBCEECBIEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public uint AGGKOEBHNLK;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x62ED410", Offset = "0x62EC210", VA = "0x1862ED410")]
	public JPNLDHBHCMP(Material DMHFIODFBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x62ED540", Offset = "0x62EC340", VA = "0x1862ED540")]
	public JPNLDHBHCMP(BLCNPGKNBKK DMHFIODFBBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NBCNECGLBOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public uint NDLGHIANCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public uint PJBCLLOAIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public uint JPPPJKAIEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public uint AGGKOEBHNLK;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x62EE830", Offset = "0x62ED630", VA = "0x1862EE830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IFHKHNHNCMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public uint FJEPJEEIAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint DBIIPCPDBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint LDPHFEEPCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint AGGKOEBHNLK;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x62EBC80", Offset = "0x62EAA80", VA = "0x1862EBC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EJLMIIFPMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public uint MJEMMMJLIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public uint GJKNNFFBECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public uint FCPGILGPEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public uint LNDMMGCJANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public uint JKDECKJLLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public uint OABDBGGOMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint NPDOLCNFBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint AGGKOEBHNLK;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x62EA090", Offset = "0x62E8E90", VA = "0x1862EA090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JIAOCNALJBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public uint3 KMAKMCFJNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public uint3 HHFHNNNJIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public uint3 DLLDMCGIGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public uint3 GPPIPMFGIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public uint3 MNNIPAGHIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public uint3 IDBAMCNOLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public uint3 CCCCCJBDGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public uint3 CKLBPLIIIAI;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x62ECF70", Offset = "0x62EBD70", VA = "0x1862ECF70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum KANADDAEOJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Shadow
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
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
