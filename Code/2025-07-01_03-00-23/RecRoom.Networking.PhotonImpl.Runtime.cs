using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Voice.PUN;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80BCAC0", Offset = "0x80BB0C0", VA = "0x1880BCAC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class CKPNKHDMKDG : FNFHFOLBALO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData FLDOIECLDLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData PHFFJMKMAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte GHAPNAILIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x227E6B0", Offset = "0x227CCB0", VA = "0x18227E6B0", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BPEKBDECLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80AE900", Offset = "0x80ACF00", VA = "0x1880AE900", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object MCBFLDFKJDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80AE940", Offset = "0x80ACF40", VA = "0x1880AE940", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80AE920", Offset = "0x80ACF20", VA = "0x1880AE920", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public CKPNKHDMKDG(EventData FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80AE960", Offset = "0x80ACF60", VA = "0x1880AE960", Slot = "8")]
	public bool OMCPIMBCGII(byte BLIBAMJKLIA, [Out] object KKGBKLFKCPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LKPJCGIJJNB : JBPHOMDJPLN, KEDGPMDLKIM, DCHBINOFFJA, KNPOGEIDBBM, IJDNGFHAHCO, EJGGMPEHJPP, LMOOPOFGDGI, HCMJLICOKOA, AEFDOLMJEPG, NPGCIAMHLCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class IOMOCCCIGPM : ODINAKJMICB
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PHBOOEHNJPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public PHBOOEHNJPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7662650", Offset = "0x7660C50", VA = "0x187662650")]
			internal void KLEKNAMHLED(GNPLFIILCMH rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool GCEDLEMIJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x80B6180", Offset = "0x80B4780", VA = "0x1880B6180", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool OHFOIKIBAIB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x80B6070", Offset = "0x80B4670", VA = "0x1880B6070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public IReadOnlyList<(string code, int ping)> GKMDOLBOJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x80B5E40", Offset = "0x80B4440", VA = "0x1880B5E40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80B5D20", Offset = "0x80B4320", VA = "0x1880B5D20", Slot = "7")]
		public bool DMBDBNGEBEK(Action HGOJOENIEOK, string IFPHDEGLKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IOMOCCCIGPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable AEAPADFDMLI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions OJNHCJLLIEP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions IMJJNMHNNIM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions FCHMEFJKGNJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions MLFABLOOACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EBBJHOMFMHH DFADLNABGKM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] OEGCJIGNKIO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DMJBKCLAMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEEDA80", Offset = "0xEEC080", VA = "0x180EEDA80", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override EBBJHOMFMHH MIOMHIHFGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ENFIEEAABJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80B9090", Offset = "0x80B7690", VA = "0x1880B9090", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EGDAFFCAGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80B9770", Offset = "0x80B7D70", VA = "0x1880B9770", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KNOJHPOMDED AOCMHBHLIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80BAAE0", Offset = "0x80B90E0", VA = "0x1880BAAE0", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NMMDGPOLHAJ LLBBEPMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80BA760", Offset = "0x80B8D60", VA = "0x1880BA760", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool NLGNHAFLMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80B97B0", Offset = "0x80B7DB0", VA = "0x1880B97B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80B8CF0", Offset = "0x80B72F0", VA = "0x1880B8CF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float NHGPGEENMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80B9A20", Offset = "0x80B8020", VA = "0x1880B9A20", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80B9840", Offset = "0x80B7E40", VA = "0x1880B9840", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ODINAKJMICB IAIEHNCGKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IPOEEOLGBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80B9D80", Offset = "0x80B8380", VA = "0x1880B9D80", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80BB6A0", Offset = "0x80B9CA0", VA = "0x1880BB6A0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ANOLHMHILAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80BB380", Offset = "0x80B9980", VA = "0x1880BB380", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HPIFIPBBDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80BA860", Offset = "0x80B8E60", VA = "0x1880BA860", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public object DDHBCMNJGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80B9910", Offset = "0x80B7F10", VA = "0x1880B9910", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NJKAGPPLGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x80B9A60", Offset = "0x80B8060", VA = "0x1880B9A60", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HLEJGGFHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x80BAB60", Offset = "0x80B9160", VA = "0x1880BAB60", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LOFJJMFCJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x80B8C80", Offset = "0x80B7280", VA = "0x1880B8C80", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int HDEKMOFIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80BAB20", Offset = "0x80B9120", VA = "0x1880BAB20", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KNOJHPOMDED BINJEDHCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80BB290", Offset = "0x80B9890", VA = "0x1880BB290", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int DILHBJCAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80B8ED0", Offset = "0x80B74D0", VA = "0x1880B8ED0", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DFNHGFBMNCA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80BADE0", Offset = "0x80B93E0", VA = "0x1880BADE0", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80B94C0", Offset = "0x80B7AC0", VA = "0x1880B94C0", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string ECACLEPEAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80BAF90", Offset = "0x80B9590", VA = "0x1880BAF90", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Func<string, string> HBCEKCNKJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80BB4E0", Offset = "0x80B9AE0", VA = "0x1880BB4E0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DDDIPAHOJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x80B8BA0", Offset = "0x80B71A0", VA = "0x1880B8BA0", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public double EDNAKNOMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80BA2E0", Offset = "0x80B88E0", VA = "0x1880BA2E0", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CKBOIDCLDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80B9D40", Offset = "0x80B8340", VA = "0x1880B9D40", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BFOEENIPBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80B9110", Offset = "0x80B7710", VA = "0x1880B9110", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string HPPDDEICGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80BA2A0", Offset = "0x80B88A0", VA = "0x1880BA2A0", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long KPAANMFHJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80BAF50", Offset = "0x80B9550", VA = "0x1880BAF50", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long GPPLFADADAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x80B8F50", Offset = "0x80B7550", VA = "0x1880B8F50", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HKMFIDMKGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x80BA9B0", Offset = "0x80B8FB0", VA = "0x1880BA9B0", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<KNOJHPOMDED> IMDOMLKACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80B9B60", Offset = "0x80B8160", VA = "0x1880B9B60", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80BAEA0", Offset = "0x80B94A0", VA = "0x1880BAEA0", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<EBBJHOMFMHH, EBBJHOMFMHH> IJNMLNBNMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80BB050", Offset = "0x80B9650", VA = "0x1880BB050", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80B9AB0", Offset = "0x80B80B0", VA = "0x1880B9AB0", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<FNFHFOLBALO> MFOONIBONDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80BB730", Offset = "0x80B9D30", VA = "0x1880BB730", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80BB2D0", Offset = "0x80B98D0", VA = "0x1880BB2D0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80BA8A0", Offset = "0x80B8EA0", VA = "0x1880BA8A0", Slot = "45")]
	public void LCADLGCEDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80B9C10", Offset = "0x80B8210", VA = "0x1880B9C10")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	internal static void GLAOIPJFGAH(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80BBA50", Offset = "0x80BA050", VA = "0x1880BBA50")]
	[UnityEngine.Scripting.Preserve]
	public LKPJCGIJJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80BA1A0", Offset = "0x80B87A0", VA = "0x1880BA1A0")]
	private void IKCGLAHAKME(bool IOLJBNDGNAG, bool JOJOAPOEOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80B8C20", Offset = "0x80B7220", VA = "0x1880B8C20", Slot = "17")]
	public float BAFMMMJMBJJ(bool MIEOHJCOAAH, int JMBJOMJBINP = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80BB7E0", Offset = "0x80B9DE0", VA = "0x1880BB7E0", Slot = "82")]
	[CanBeNull]
	public KNOJHPOMDED PNNMCBEJHIK(int LPDADLLGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80BB1C0", Offset = "0x80B97C0", VA = "0x1880BB1C0", Slot = "84")]
	public KNOJHPOMDED NOHGHGCIFNN(int LPDADLLGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80BA320", Offset = "0x80B8920", VA = "0x1880BA320", Slot = "83")]
	[CanBeNull]
	public KNOJHPOMDED JENFDGKHDBJ(int DKGJDLCFPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80BB490", Offset = "0x80B9A90", VA = "0x1880BB490", Slot = "85")]
	public IReadOnlyList<KNOJHPOMDED> PADCFKADHOA(bool ABPOGIAJPII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80BB440", Offset = "0x80B9A40", VA = "0x1880BB440", Slot = "86")]
	public IReadOnlyList<KNOJHPOMDED> OOHPNCCGIHE(bool ABPOGIAJPII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80B8AF0", Offset = "0x80B70F0", VA = "0x1880B8AF0", Slot = "87")]
	public bool AFPCFFFMDLB(KNOJHPOMDED IIEPGCMOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80BA7B0", Offset = "0x80B8DB0", VA = "0x1880BA7B0")]
	private static short KBAOGODALEO(StreamBuffer ECDEIGOGDFO, object CFOCHKMEDOI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80B9170", Offset = "0x80B7770", VA = "0x1880B9170")]
	private static object DNGGOONCBKA(StreamBuffer AKIPIJPHBEF, short PHABMFMJBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80B9310", Offset = "0x80B7910", VA = "0x1880B9310", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80B8F90", Offset = "0x80B7590", VA = "0x1880B8F90", Slot = "56")]
	public bool CJEBNMGCBCJ(object HMGOEIDKCEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80BAE60", Offset = "0x80B9460", VA = "0x1880BAE60", Slot = "55")]
	public void MPKFLLBBFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80BB540", Offset = "0x80B9B40", VA = "0x1880BB540", Slot = "53")]
	public bool PJHCEGLIFDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80B9D00", Offset = "0x80B8300", VA = "0x1880B9D00", Slot = "18")]
	public bool HAOJBLJEEEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80BAA10", Offset = "0x80B9010", VA = "0x1880BAA10", Slot = "8")]
	public override void LEAKPCFBGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80B99B0", Offset = "0x80B7FB0", VA = "0x1880B99B0", Slot = "20")]
	public void GCGDOKMJAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80B8D40", Offset = "0x80B7340", VA = "0x1880B8D40", Slot = "21")]
	public void BPPHLMNKIBG(List<object> BGGFBGFNIID, int IGHNHCKLCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80BACD0", Offset = "0x80B92D0", VA = "0x1880BACD0", Slot = "22")]
	public void MKLPFCMNKOO(int MEOLDLEBKEJ, object FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80B9E10", Offset = "0x80B8410", VA = "0x1880B9E10", Slot = "23")]
	public void IFBOHDBNLNK(IDictionary<object, object> BKADBAJOKKO, int HKLGEDHKAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80BA3E0", Offset = "0x80B89E0", VA = "0x1880BA3E0", Slot = "70")]
	public bool JFEGKCBMLGB(byte FHBJJABHKPG, object HBPOJHGLIJD, JCLKAOOIHID JCIFHCCPGEJ, GMBKBHGPJMD PFJLCJLCCNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80BABD0", Offset = "0x80B91D0", VA = "0x1880BABD0", Slot = "54")]
	public bool MHMBKEEMFBH(string HDKICABIBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80B95C0", Offset = "0x80B7BC0", VA = "0x1880B95C0", Slot = "35")]
	public void EIKKCOIILLB(string CODLGOOMDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80B90D0", Offset = "0x80B76D0", VA = "0x1880B90D0", Slot = "27")]
	public void DGGPPDAAJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80BAA50", Offset = "0x80B9050", VA = "0x1880BAA50", Slot = "28")]
	public void LGGJGPOGIBH(object ODCICEDDLMB, NativeList<byte> ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80B9890", Offset = "0x80B7E90", VA = "0x1880B9890", Slot = "29")]
	public object FJJOMODMCLM(NativeArray<byte> ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80B8B40", Offset = "0x80B7140", VA = "0x1880B8B40", Slot = "81")]
	public void AGIGLJJJDMJ(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80BB100", Offset = "0x80B9700", VA = "0x1880BB100", Slot = "30")]
	public int NMKNOHKPMGG(FNFHFOLBALO FLDOIECLDLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80BB6F0", Offset = "0x80B9CF0", VA = "0x1880BB6F0", Slot = "95")]
	public int PLDMHDHIBEO()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80A2380", Offset = "0x80A0980", VA = "0x1880A2380", Slot = "11")]
	private void ODGLGEEIJOC(Action KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E30", Offset = "0x80A0430", VA = "0x1880A1E30", Slot = "12")]
	private void MMEMLPCPGFG(Action KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80A1BC0", Offset = "0x80A01C0", VA = "0x1880A1BC0", Slot = "25")]
	private void KJJHDBFHOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80A1860", Offset = "0x809FE60", VA = "0x1880A1860", Slot = "26")]
	private void HJNOCICGMHG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80A1FB0", Offset = "0x80A05B0", VA = "0x1880A1FB0", Slot = "31")]
	private void NBFHGELHJBP(float KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x80A1C30", Offset = "0x80A0230", VA = "0x1880A1C30", Slot = "32")]
	private void LHHJEOHMHKJ(float KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80A1450", Offset = "0x809FA50", VA = "0x1880A1450", Slot = "57")]
	private void EFADJILADDH(Action<bool> KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80A12D0", Offset = "0x809F8D0", VA = "0x1880A12D0", Slot = "58")]
	private void CKMALGFGPEJ(Action<bool> KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80A1420", Offset = "0x809FA20", VA = "0x1880A1420", Slot = "59")]
	private void DLPJFNBFHJB(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80A2420", Offset = "0x80A0A20", VA = "0x1880A2420", Slot = "60")]
	private void OOOOPJAPBLI(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B30", Offset = "0x80A0130", VA = "0x1880A1B30", Slot = "61")]
	private void JGOAPPEOPCP(object DKFMAIJGPFL, bool BNCAKEBPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80A1570", Offset = "0x809FB70", VA = "0x1880A1570", Slot = "62")]
	private IDisposable EODKPLDHJOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80A1850", Offset = "0x809FE50", VA = "0x1880A1850", Slot = "63")]
	private bool HIDBMBHLPEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E00", Offset = "0x80A0400", VA = "0x1880A1E00", Slot = "64")]
	private void MKLDKCEHGGF(StringBuilder ALFEMNGJGJJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80A2520", Offset = "0x80A0B20", VA = "0x1880A2520", Slot = "66")]
	private void PIMCDBGINIC(Action<string, long> KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B90", Offset = "0x80A0190", VA = "0x1880A1B90", Slot = "67")]
	private void JOGMPJNMBLM(Action<string, long> KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x80A1D50", Offset = "0x80A0350", VA = "0x1880A1D50", Slot = "88")]
	private void MHJLNMJAIJJ(Action KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80A1560", Offset = "0x809FB60", VA = "0x1880A1560", Slot = "89")]
	private void EIJOLKDPADF(Action KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80A1A10", Offset = "0x80A0010", VA = "0x1880A1A10", Slot = "90")]
	private void ILOFKMCNNFP()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80BC140", Offset = "0x80BA740", VA = "0x1880BC140", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80BF030", Offset = "0x80BD630", VA = "0x1880BF030", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IAKDPHEHOMK : LIOMIANNNGF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LIOMIANNNGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CHLHACCNABJ POFBMOHCKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string JPADHPDABEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Task AJNIHAJNLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool POBEMBNPMFC(CHLHACCNABJ EDGBFOPGMND);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MPKFLLBBFIB([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CHLHACCNABJ> FIJACKLHECC(CHLHACCNABJ EDGBFOPGMND, object LOLNHDPCOOD, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NFAFJMHIABP([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMCGGCBKCMA(NKDFAILGLGG PNPLCOMBOMN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface MEBJOOPCAHM
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGNEABHFDAM(ushort ILPLHBFCJFF, EPIAAHMBJEE BDBIIGNGJGN, params object[] HAJLJKCFLML);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal enum EPIAAHMBJEE
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Disconnect_AlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Disconnect_AlreadyDisconnected,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DisconnectInternal,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DisconnectInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DisconnectInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DisconnectFromRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DisconnectFromRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DisconnectFromRoomInstance_LeavingAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DisconnectFromRoomInstance_AlreadyLeftRoom,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DisconnectFromRoomInstanceInternal_BeforeLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DisconnectFromRoomInstanceInternal_AfterLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DisconnectFromRoomInstanceInternal_LeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisconnectFromRoomInstanceInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ConnectToRegion,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ConnectToRegion_AddedAuthValues,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ConnectToRegion_ConnectToRegionInternal,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ConnectToRegion_ConnectToRegionInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	ConnectToRegion_EnteredOfflineMode,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ConnectToRegion_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectToRegion_AlreadyConnected,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ConnectToRegion_DisconnectDueToCancellation,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectToRegion_DisconnectDueToError,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ConnectToRegion_Connected,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectWithAppSettings,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ConnectToRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ConnectToRoomInstance_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ConnectToRoomInstance_AlreadyInRoom,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ConnectToRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ConnectToRoomInstanceInternal_Connected
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CHNOGHNCFEH : LIOMIANNNGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PIFKHMANIJI PBENFBAGGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PIFKHMANIJI : IAKDPHEHOMK, LIOMIANNNGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> DDJGMKKKMEA([Optional] TimeSpan? KFIHKLMMNCL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JFLIMACEPOC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool OEHJHLODMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	TimeSpan KCCJDDGOHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan LJEEPIGPFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object CALEGKKGMHC(MAMMBDIALKK LLFPLJBIFFJ);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CMFPAFMDEEI IHFMFKFFGCP(MAMMBDIALKK LLFPLJBIFFJ);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MAMMBDIALKK> ODABPBJDIOJ(CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JFLBIOHMDPC
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LGEBFGGIOJB KAHJFEMLEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string LLDJKIOKFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string FPGHCBOOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> FONOAJMBPEC(string HFJIIENAFFB, string EJJFOKJFHBF, string KPNDAMBENEN);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MPKFLLBBFIB([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal static class JMIECLIAMNM
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FKNCHJIHNDF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Action<string, JLOIIAFGCFD> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public EBBJHOMFMHH networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HCMJLICOKOA networking;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FKNCHJIHNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4C530C0", Offset = "0x4C516C0", VA = "0x184C530C0")]
		internal void GHGAKGPFOBG(OAJNBKMEPPG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4C532C0", Offset = "0x4C518C0", VA = "0x184C532C0")]
		internal void MKCKAPKOPPM(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4C52EA0", Offset = "0x4C514A0", VA = "0x184C52EA0")]
		internal void ACCANBLGNOG(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NOFHDNMJGJH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public HCMJLICOKOA networking;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NOFHDNMJGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x56A3E40", Offset = "0x56A2440", VA = "0x1856A3E40")]
		internal void MMLDEPDHLHL(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x56A3FA0", Offset = "0x56A25A0", VA = "0x1856A3FA0")]
		internal void NKNNAJLEKPD(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x56A3B40", Offset = "0x56A2140", VA = "0x1856A3B40")]
		internal void KABJEJDJMFP(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3BD0", Offset = "0x3BA21D0", VA = "0x183BA3BD0")]
	public static void CDJMKELCCFG<T>(this HCMJLICOKOA ILCCHPCLICG, TaskCompletionSource<T> JGEAKLOFCKJ, [NotNull] EBBJHOMFMHH FLCPGOKHNCJ, JLOIIAFGCFD NCBANOLCNJG, bool LAJGOFGFKDB, Action<string, JLOIIAFGCFD> NDJJBNFFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4330", Offset = "0x3BA2930", VA = "0x183BA4330")]
	public static void NHNPOEINONO<T>(this HCMJLICOKOA ILCCHPCLICG, TaskCompletionSource<T> JGEAKLOFCKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class HDNFKANGGME<TNetworking> : IAKDPHEHOMK, LIOMIANNNGF, IDisposable where TNetworking : class, DCHBINOFFJA, KNPOGEIDBBM
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LHHJMIDIOGM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AsyncTaskMethodBuilder<MAMMBDIALKK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public LHHJMIDIOGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<MAMMBDIALKK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x43008E0", Offset = "0x42FEEE0", VA = "0x1843008E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4300C50", Offset = "0x42FF250", VA = "0x184300C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public MAMMBDIALKK photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LHHJMIDIOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x538BB50", Offset = "0x538A150", VA = "0x18538BB50")]
		[AsyncStateMachine(typeof(HDNFKANGGME<>.LHHJMIDIOGM.<<ConnectToRegionInternal>b__0>d))]
		internal Task<MAMMBDIALKK> KMNHKHCCCKJ(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct COJBHAEEGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<MAMMBDIALKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public MAMMBDIALKK photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LHHJMIDIOGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<MAMMBDIALKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x68825F0", Offset = "0x6880BF0", VA = "0x1868825F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x68831E0", Offset = "0x68817E0", VA = "0x1868831E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct PICHHECAFFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<MAMMBDIALKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MAMMBDIALKK photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x58DD690", Offset = "0x58DBC90", VA = "0x1858DD690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x58DE2A0", Offset = "0x58DC8A0", VA = "0x1858DE2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MHMHHKPGKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x560B610", Offset = "0x5609C10", VA = "0x18560B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x560B860", Offset = "0x5609E60", VA = "0x18560B860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct IDAGOIOMEKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private JLOIIAFGCFD <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4F496F0", Offset = "0x4F47CF0", VA = "0x184F496F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4F49C10", Offset = "0x4F48210", VA = "0x184F49C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EMEAGAJCAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EMEAGAJCAFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x479B0B0", Offset = "0x47996B0", VA = "0x18479B0B0")]
		internal Task<bool> NMPBGCACJAE(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BCILKHIIGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private EMEAGAJCAFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x613E630", Offset = "0x613CC30", VA = "0x18613E630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x613F450", Offset = "0x613DA50", VA = "0x18613F450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BMOIKPNKNDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<OAJNBKMEPPG> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BMOIKPNKNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x62F1C80", Offset = "0x62F0280", VA = "0x1862F1C80")]
		internal void CIDMBDMCOLG(OAJNBKMEPPG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x62F1D40", Offset = "0x62F0340", VA = "0x1862F1D40")]
		internal void GNMCLECCDHI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CBJBEMIBILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private BMOIKPNKNDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<OAJNBKMEPPG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x66BFA70", Offset = "0x66BE070", VA = "0x1866BFA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x66C11C0", Offset = "0x66BF7C0", VA = "0x1866C11C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct ILAFJGPAOAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<CHLHACCNABJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CHLHACCNABJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private JLOIIAFGCFD <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<CHLHACCNABJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4F72780", Offset = "0x4F70D80", VA = "0x184F72780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4F733D0", Offset = "0x4F719D0", VA = "0x184F733D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ELLKAAJENPL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AsyncTaskMethodBuilder<CHLHACCNABJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public ELLKAAJENPL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<CHLHACCNABJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x4300CC0", Offset = "0x42FF2C0", VA = "0x184300CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4301050", Offset = "0x42FF650", VA = "0x184301050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CHLHACCNABJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ELLKAAJENPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x479A240", Offset = "0x4798840", VA = "0x18479A240")]
		[AsyncStateMachine(typeof(HDNFKANGGME<>.ELLKAAJENPL.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<CHLHACCNABJ> ADJGBIAOPMP(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct AELCFMLPEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<CHLHACCNABJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CHLHACCNABJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ELLKAAJENPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<CHLHACCNABJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4E66280", Offset = "0x4E64880", VA = "0x184E66280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4E67020", Offset = "0x4E65620", VA = "0x184E67020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IJHKIHIABGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TaskCompletionSource<JDLMMOCIBOE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IJHKIHIABGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F6AC90", Offset = "0x4F69290", VA = "0x184F6AC90")]
		internal void PFMPBCOMODJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JOJHOBEIGAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<CHLHACCNABJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CHLHACCNABJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IJHKIHIABGC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Action <trySetResAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<MAMMBDIALKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<JDLMMOCIBOE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x51DF240", Offset = "0x51DD840", VA = "0x1851DF240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x51E1590", Offset = "0x51DFB90", VA = "0x1851E1590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct PHNGLHCOJCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Task<MMCIMPFKGEP> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<MMCIMPFKGEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x58DC840", Offset = "0x58DAE40", VA = "0x1858DC840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HJJGPINDDPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4E12870", Offset = "0x4E10E70", VA = "0x184E12870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E12AB0", Offset = "0x4E110B0", VA = "0x184E12AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct HALMLIEAENC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private JLOIIAFGCFD <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4DD44C0", Offset = "0x4DD2AC0", VA = "0x184DD44C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4DD4940", Offset = "0x4DD2F40", VA = "0x184DD4940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct NBNJOOHDFJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x567A470", Offset = "0x5678A70", VA = "0x18567A470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x567AC40", Offset = "0x5679240", VA = "0x18567AC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OLCCBMBLPDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OLCCBMBLPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x57D9AE0", Offset = "0x57D80E0", VA = "0x1857D9AE0")]
		internal Task<MMCIMPFKGEP> BLDCCOFDLIH(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LLGNPJIEFMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private OLCCBMBLPDM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter<MMCIMPFKGEP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x54293D0", Offset = "0x54279D0", VA = "0x1854293D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5429EF0", Offset = "0x54284F0", VA = "0x185429EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CFDMPBNAAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TaskCompletionSource<JDLMMOCIBOE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CFDMPBNAAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6799A40", Offset = "0x6798040", VA = "0x186799A40")]
		internal void PLBKPBOEIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x67999B0", Offset = "0x6797FB0", VA = "0x1867999B0")]
		internal void MDBAGAENDLB(OAJNBKMEPPG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6799770", Offset = "0x6797D70", VA = "0x186799770")]
		internal void AGKGDEMDBHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FHBJGHECCDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public TaskCompletionSource<JDLMMOCIBOE> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CFDMPBNAAAO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FHBJGHECCDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4C0AFA0", Offset = "0x4C095A0", VA = "0x184C0AFA0")]
		internal void ENEEMFBIKKF(OAJNBKMEPPG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4C0B040", Offset = "0x4C09640", VA = "0x184C0B040")]
		internal void IFOFHOHAFEB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct HBJKHAIJCKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder<MMCIMPFKGEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private CFDMPBNAAAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private FHBJGHECCDA <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<JDLMMOCIBOE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4DD68F0", Offset = "0x4DD4EF0", VA = "0x184DD68F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4DD8BB0", Offset = "0x4DD71B0", VA = "0x184DD8BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class JBHKOHBMFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TaskCompletionSource<JDLMMOCIBOE> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JBHKOHBMFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5168EE0", Offset = "0x51674E0", VA = "0x185168EE0")]
		internal string BIIOPOIPBHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5168F50", Offset = "0x5167550", VA = "0x185168F50")]
		internal void LKDABENBILI(JDLMMOCIBOE _1, JDLMMOCIBOE _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JEHEDFGNDOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder<JDLMMOCIBOE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private JBHKOHBMFAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<JDLMMOCIBOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x51926D0", Offset = "0x5190CD0", VA = "0x1851926D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x51933F0", Offset = "0x51919F0", VA = "0x1851933F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FPNPNDAMIBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4C960E0", Offset = "0x4C946E0", VA = "0x184C960E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HAKCHDEALLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4DD4080", Offset = "0x4DD2680", VA = "0x184DD4080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4DD4460", Offset = "0x4DD2A60", VA = "0x184DD4460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct LOOOOKLJBPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public OAJNBKMEPPG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private CKDKPHCBHJD <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5438950", Offset = "0x5436F50", VA = "0x185438950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DODIEGJBKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OAJNBKMEPPG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private HashSet<NKDFAILGLGG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6D38B30", Offset = "0x6D37130", VA = "0x186D38B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D395E0", Offset = "0x6D37BE0", VA = "0x186D395E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct CPJOEBDFNIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private HashSet<MBFBDONFEPL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6888BF0", Offset = "0x68871F0", VA = "0x186888BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x68890E0", Offset = "0x68876E0", VA = "0x1868890E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class BLKALPGEEGO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BLKALPGEEGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		internal string EBHDKONHBFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class EIFOPDMMJDE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AAAKFHPPILG.EHFFPAKOCFF timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EIFOPDMMJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x478C260", Offset = "0x478A860", VA = "0x18478C260")]
		internal void MIENHBHINFH(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x478B830", Offset = "0x4789E30", VA = "0x18478B830")]
		internal AKGMBHPEOCB LLJIAENOMDM(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ILLHAFBBLNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TaskCompletionSource<JDLMMOCIBOE> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ILLHAFBBLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4F76490", Offset = "0x4F74A90", VA = "0x184F76490")]
		internal void APOLNLDIOAE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ECPELKOBOPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private ILLHAFBBLNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JDLMMOCIBOE connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public object appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private TaskAwaiter<JDLMMOCIBOE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x475BA40", Offset = "0x475A040", VA = "0x18475BA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x475CD90", Offset = "0x475B390", VA = "0x18475CD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KFKGPIPNLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KFKGPIPNLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x529B8D0", Offset = "0x5299ED0", VA = "0x18529B8D0")]
		internal object MBHLBEDNKOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DMCDJENJPGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DMCDJENJPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6D22F70", Offset = "0x6D21570", VA = "0x186D22F70")]
		internal object JBHFCDHOGAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CGFHJPJMKCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HDNFKANGGME<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CGFHJPJMKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x679C2C0", Offset = "0x679A8C0", VA = "0x18679C2C0")]
		internal object EPAGIFNOGJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MEBJOOPCAHM PIJKMMPEFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CCBJIBFPIBP FHEGKOHLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected readonly string LHFINBHBHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected readonly JFLIMACEPOC JDNALCJAEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private TaskCompletionSource<MMCIMPFKGEP> CJENPFEGHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected internal readonly TNetworking LHLOMPMFPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private ushort AHCJFCMACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private PEPEGPOLCDE<MAMMBDIALKK> FHOIMICPDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PEPEGPOLCDE<bool> LJLLOAEOOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private PEPEGPOLCDE<CHLHACCNABJ> NKCBEKDBJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private PEPEGPOLCDE<MMCIMPFKGEP> PCGMIJLEEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool CAFIGJBNOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool HDEHEOKDAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HashSet<MBFBDONFEPL> HHFJGMFCLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HashSet<NKDFAILGLGG> GAEJBGNNPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool IPJFEJDAGIO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HPIFIPBBDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4DEB3D0", Offset = "0x4DE99D0", VA = "0x184DEB3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[CanBeNull]
	public CHLHACCNABJ POFBMOHCKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4DEAA80", Offset = "0x4DE9080", VA = "0x184DEAA80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected JDLMMOCIBOE MEFDKDCPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4DEA4F0", Offset = "0x4DE8AF0", VA = "0x184DEA4F0")]
		get
		{
			return default(JDLMMOCIBOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[CanBeNull]
	public string JPADHPDABEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4DECC80", Offset = "0x4DEB280", VA = "0x184DECC80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private TimeSpan KCCJDDGOHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4DEC050", Offset = "0x4DEA650", VA = "0x184DEC050")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private TimeSpan LJEEPIGPFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4DEB1B0", Offset = "0x4DE97B0", VA = "0x184DEB1B0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task AJNIHAJNLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4DEBEB0", Offset = "0x4DEA4B0", VA = "0x184DEBEB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool POBEMBNPMFC(CHLHACCNABJ EDGBFOPGMND);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB6F0", Offset = "0x4DE9CF0", VA = "0x184DEB6F0")]
	private static TimeSpan KOEGJNOHANB(TimeSpan CLIHIFCMKLF, string IEDAJGLJHNI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4DED220", Offset = "0x4DEB820", VA = "0x184DED220")]
	protected HDNFKANGGME(TNetworking ILCCHPCLICG, JFLIMACEPOC GBAAELADHNE, string JKANDKICJMG, CCBJIBFPIBP FHEGKOHLHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4DECF30", Offset = "0x4DEB530", VA = "0x184DECF30")]
	internal HDNFKANGGME(TNetworking ILCCHPCLICG, JFLIMACEPOC GBAAELADHNE, string JKANDKICJMG, CCBJIBFPIBP FHEGKOHLHKP, [Optional] MEBJOOPCAHM PIJKMMPEFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAE00", Offset = "0x4DE9400", VA = "0x184DEAE00")]
	private void JCEPOLDLFPI(bool HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA1C0", Offset = "0x4DE87C0", VA = "0x184DEA1C0")]
	private void CAMCBCCGGNL(JDLMMOCIBOE HBKNLGPKKFM, JDLMMOCIBOE ACBJLKJPPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAB90", Offset = "0x4DE9190", VA = "0x184DEAB90")]
	internal JLOIIAFGCFD ICAOOHCCDID()
	{
		return default(JLOIIAFGCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA2D0", Offset = "0x4DE88D0", VA = "0x184DEA2D0")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.COJBHAEEGMA))]
	private Task<MAMMBDIALKK> CODPJBIJPIJ(JLOIIAFGCFD NCBANOLCNJG, MAMMBDIALKK LLFPLJBIFFJ, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB030", Offset = "0x4DE9630", VA = "0x184DEB030")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.PICHHECAFFK))]
	protected Task<MAMMBDIALKK> JGAJIPOIMIF(JLOIIAFGCFD NCBANOLCNJG, MAMMBDIALKK LLFPLJBIFFJ, CancellationToken CFOIGCAHJAB, CancellationToken CGLPLCAJGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB280", Offset = "0x4DE9880", VA = "0x184DEB280")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.MHMHHKPGKIP))]
	protected Task KIEPJCBAJMA(JLOIIAFGCFD NCBANOLCNJG, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4DEBF40", Offset = "0x4DEA540", VA = "0x184DEBF40", Slot = "7")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.IDAGOIOMEKB))]
	public Task MPKFLLBBFIB([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAEF0", Offset = "0x4DE94F0", VA = "0x184DEAEF0")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.BCILKHIIGFC))]
	private Task JFJNBNPKBGG(JLOIIAFGCFD NCBANOLCNJG, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4DECA80", Offset = "0x4DEB080", VA = "0x184DECA80")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.CBJBEMIBILC))]
	private Task<bool> OPDOHAJDDPG(JLOIIAFGCFD NCBANOLCNJG, CancellationToken DKFMAIJGPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA620", Offset = "0x4DE8C20", VA = "0x184DEA620", Slot = "8")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.ILAFJGPAOAN))]
	public Task<CHLHACCNABJ> FIJACKLHECC(CHLHACCNABJ EDGBFOPGMND, object LOLNHDPCOOD, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB570", Offset = "0x4DE9B70", VA = "0x184DEB570")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.AELCFMLPEEC))]
	private Task<CHLHACCNABJ> KMLFMJIKICN(JLOIIAFGCFD NCBANOLCNJG, CHLHACCNABJ EDGBFOPGMND, object LOLNHDPCOOD, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB940", Offset = "0x4DE9F40", VA = "0x184DEB940")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.JOJHOBEIGAP))]
	private Task<CHLHACCNABJ> LBPBKAMFPNP(JLOIIAFGCFD NCBANOLCNJG, CHLHACCNABJ EDGBFOPGMND, object LOLNHDPCOOD, CancellationToken CFOIGCAHJAB, CancellationToken CGLPLCAJGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAAD0", Offset = "0x4DE90D0", VA = "0x184DEAAD0")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.PHNGLHCOJCB))]
	private void HOAEOJPNHCJ(Task<MMCIMPFKGEP> FNCLMKKJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB440", Offset = "0x4DE9A40", VA = "0x184DEB440")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.HJJGPINDDPC))]
	private Task KMGAEJCDHAA(JLOIIAFGCFD NCBANOLCNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC1C0", Offset = "0x4DEA7C0", VA = "0x184DEC1C0", Slot = "9")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.HALMLIEAENC))]
	public Task NFAFJMHIABP([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4DEBAE0", Offset = "0x4DEA0E0", VA = "0x184DEBAE0")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.NBNJOOHDFJK))]
	private Task LGPFMIMBPBC(JLOIIAFGCFD NCBANOLCNJG, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA070", Offset = "0x4DE8670", VA = "0x184DEA070")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.LLGNPJIEFMM))]
	private Task BJIEEIIHLHC(JLOIIAFGCFD NCBANOLCNJG, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9E00", Offset = "0x4DE8400", VA = "0x184DE9E00")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.HBJKHAIJCKF))]
	private Task<MMCIMPFKGEP> AJNGPLJANKE(JLOIIAFGCFD NCBANOLCNJG, CancellationToken CFOIGCAHJAB, CancellationToken CGLPLCAJGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC430", Offset = "0x4DEAA30", VA = "0x184DEC430")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.JEHEDFGNDOF))]
	private Task<JDLMMOCIBOE> NJFIHLJEKHL(JLOIIAFGCFD NCBANOLCNJG, CancellationToken KMHHNOGHBLL, string CJDOILFHDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4DECBE0", Offset = "0x4DEB1E0", VA = "0x184DECBE0", Slot = "14")]
	protected virtual void PALLLEACICB(JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC120", Offset = "0x4DEA720", VA = "0x184DEC120", Slot = "15")]
	protected virtual void NAFJIGHPOPM(JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4DEABE0", Offset = "0x4DE91E0", VA = "0x184DEABE0")]
	private void IGNEABHFDAM(JLOIIAFGCFD NCBANOLCNJG, EPIAAHMBJEE CJDOILFHDJI, params object[] MMCAOMENGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "16")]
	protected virtual void ODJIICOFIDK(CHLHACCNABJ EFDGJIHHING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4DEB890", Offset = "0x4DE9E90", VA = "0x184DEB890")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.FPNPNDAMIBI))]
	private void LBKGDAMLDEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC9A0", Offset = "0x4DEAFA0", VA = "0x184DEC9A0")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.HAKCHDEALLL))]
	private Task OGONNKBEHCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4DEAD40", Offset = "0x4DE9340", VA = "0x184DEAD40")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.LOOOOKLJBPB))]
	private void JBHFCOLHLNB(OAJNBKMEPPG KLMPGFJOMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4DE9F70", Offset = "0x4DE8570", VA = "0x184DE9F70")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.DODIEGJBKLB))]
	private Task BHAPKBFIFDI(OAJNBKMEPPG KLMPGFJOMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4DEBC30", Offset = "0x4DEA230", VA = "0x184DEBC30")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.CPJOEBDFNIF))]
	private Task MBGKCIMOCOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC5A0", Offset = "0x4DEABA0", VA = "0x184DEC5A0", Slot = "10")]
	public void NMCGGCBKCMA(NKDFAILGLGG PNPLCOMBOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x41C4630", Offset = "0x41C2C30", VA = "0x1841C4630")]
	private TaskCompletionSource<T> OAFBMBMPFMG<T>(JLOIIAFGCFD NCBANOLCNJG, CancellationToken KMHHNOGHBLL, TimeSpan GHMHNEFJOFM, string EEBIBCLKPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x41C4770", Offset = "0x41C2D70", VA = "0x1841C4770")]
	private TaskCompletionSource<T> OAFBMBMPFMG<T>(JLOIIAFGCFD NCBANOLCNJG, CancellationToken KMHHNOGHBLL, TimeSpan GHMHNEFJOFM, AAAKFHPPILG.EHFFPAKOCFF EEBIBCLKPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC2D0", Offset = "0x4DEA8D0", VA = "0x184DEC2D0")]
	[AsyncStateMachine(typeof(HDNFKANGGME<>.ECPELKOBOPD))]
	protected Task NGLDAKDDCCM(JLOIIAFGCFD NCBANOLCNJG, object HMGOEIDKCEG, JDLMMOCIBOE LJDCHLANIOG, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA440", Offset = "0x4DE8A40", VA = "0x184DEA440", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC600", Offset = "0x4DEAC00", VA = "0x184DEC600", Slot = "17")]
	protected virtual void OAFCFLGCIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA2B0", Offset = "0x4DE88B0", VA = "0x184DEA2B0")]
	private static string CLBEBOINJFI(JLOIIAFGCFD NCBANOLCNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	protected void OAAFJAHOMDO(string CJIMOMNMAGD, [Optional] JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA8F0", Offset = "0x4DE8EF0", VA = "0x184DEA8F0")]
	protected void GPFCFOHDADP(string CJIMOMNMAGD, [Optional] JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DEBD20", Offset = "0x4DEA320", VA = "0x184DEBD20")]
	protected void MLBKDBCFNPO(string CJIMOMNMAGD, [Optional] JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4DECCE0", Offset = "0x4DEB2E0", VA = "0x184DECCE0")]
	protected void PHLLJOHELBE(string CJIMOMNMAGD, Exception CGONOPBDIAB, [Optional] JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA5D0", Offset = "0x4DE8BD0", VA = "0x184DEA5D0")]
	public void FCCPKJOBDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4DEA780", Offset = "0x4DE8D80", VA = "0x184DEA780")]
	[CompilerGenerated]
	private void GEMABLDDGOF(EBBJHOMFMHH COCMFLCIFNH, EBBJHOMFMHH LHEIHNIHOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x41C4570", Offset = "0x41C2B70", VA = "0x1841C4570")]
	[CompilerGenerated]
	internal static string CFGOIMIACBO<T>(TimeSpan BDLFAIPEPKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct JLOIIAFGCFD : IEquatable<JLOIIAFGCFD>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public readonly ushort MPIJNFDAJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly string LHFINBHBHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly DCHBINOFFJA ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly Stopwatch LDCPOPGAKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<(TimeSpan, JDLMMOCIBOE, JDLMMOCIBOE)> ILKANOGAGPM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public TimeSpan NFLDJPDIGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x80B6BD0", Offset = "0x80B51D0", VA = "0x1880B6BD0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IReadOnlyList<(TimeSpan time, JDLMMOCIBOE oldState, JDLMMOCIBOE newState)> CNAHFFHJCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x80B6D20", Offset = "0x80B5320", VA = "0x1880B6D20")]
	public JLOIIAFGCFD(ushort ILPLHBFCJFF, string JKANDKICJMG, DCHBINOFFJA ILCCHPCLICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x80B6C10", Offset = "0x80B5210", VA = "0x1880B6C10")]
	private void NFKKGLIDEAG(JDLMMOCIBOE HBKNLGPKKFM, JDLMMOCIBOE ACBJLKJPPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x80B6BA0", Offset = "0x80B51A0", VA = "0x1880B6BA0", Slot = "4")]
	public bool Equals(JLOIIAFGCFD HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x80B6B10", Offset = "0x80B5110", VA = "0x1880B6B10", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x80B6BB0", Offset = "0x80B51B0", VA = "0x1880B6BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x80B6BF0", Offset = "0x80B51F0", VA = "0x1880B6BF0")]
	public static bool JKIBMILPCGE(JLOIIAFGCFD DBDIOGELIIH, JLOIIAFGCFD LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x80B69C0", Offset = "0x80B4FC0", VA = "0x1880B69C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class LFIKFOJIMID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct FANNLJPAFLK<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PEPEGPOLCDE<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public JLOIIAFGCFD doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4BF17F0", Offset = "0x4BEFDF0", VA = "0x184BF17F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1EE0", Offset = "0x4BF04E0", VA = "0x184BF1EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ABKNAFENJHO<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public PEPEGPOLCDE<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public JLOIIAFGCFD doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4E600C0", Offset = "0x4E5E6C0", VA = "0x184E600C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4E60370", Offset = "0x4E5E970", VA = "0x184E60370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct ILHDHLMMMNA<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PEPEGPOLCDE<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4F74F90", Offset = "0x4F73590", VA = "0x184F74F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x478E1B0", Offset = "0x478C7B0", VA = "0x18478E1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0A40", Offset = "0x3BEF040", VA = "0x183BF0A40")]
	[AsyncStateMachine(typeof(FANNLJPAFLK<>))]
	public static Task IJMOHMAAHBK<TArgs>(this PEPEGPOLCDE<TArgs> NLLIMKKHCOB, [Optional] JLOIIAFGCFD FHGAJKMGGGJ) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3BF07E0", Offset = "0x3BEEDE0", VA = "0x183BF07E0")]
	[AsyncStateMachine(typeof(ABKNAFENJHO<>))]
	public static Task IBHLHIFPNFA<TArgs>(this PEPEGPOLCDE<TArgs> NLLIMKKHCOB, TimeSpan JOHFACEAEKE, [Optional] JLOIIAFGCFD FHGAJKMGGGJ) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0570", Offset = "0x3BEEB70", VA = "0x183BF0570")]
	public static (bool, bool) CNPONLINAMM<TArgs>(this PEPEGPOLCDE<TArgs> NLLIMKKHCOB, TArgs OKOGHNMMGGB, [Out] string OPJHGBKNIPA) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0DA0", Offset = "0x3BEF3A0", VA = "0x183BF0DA0")]
	[AsyncStateMachine(typeof(ILHDHLMMMNA<>))]
	public static Task<TArgs> KMFFEKKOLCE<TArgs>(this PEPEGPOLCDE<TArgs> NLLIMKKHCOB, TArgs OKOGHNMMGGB, CancellationToken DJMCDLPPNFL) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class PEPEGPOLCDE<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TArgs> GGIONJBNPMI(CancellationToken DCMIDCBIKJD, CancellationToken LPADHJFIGKJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct NOJAIIKGBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public PEPEGPOLCDE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public JLOIIAFGCFD doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x56A5080", Offset = "0x56A3680", VA = "0x1856A5080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x56A5600", Offset = "0x56A3C00", VA = "0x1856A5600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PFNPIPHCHDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public PEPEGPOLCDE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public JLOIIAFGCFD doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x58B9C70", Offset = "0x58B8270", VA = "0x1858B9C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x58B9F40", Offset = "0x58B8540", VA = "0x1858B9F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BNBGEMALAED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public PEPEGPOLCDE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x62F37D0", Offset = "0x62F1DD0", VA = "0x1862F37D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x62F3FB0", Offset = "0x62F25B0", VA = "0x1862F3FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct INBHKLPMHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public PEPEGPOLCDE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public GGIONJBNPMI taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4F9C9A0", Offset = "0x4F9AFA0", VA = "0x184F9C9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4F9E590", Offset = "0x4F9CB90", VA = "0x184F9E590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct NINOPCCIGHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public PEPEGPOLCDE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5693DC0", Offset = "0x56923C0", VA = "0x185693DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1690", Offset = "0x4D9FC90", VA = "0x184DA1690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool BMIAPMECOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool ANBPDCILIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private CancellationTokenSource MEOLPEGGHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private CancellationTokenSource JKLLDKHKPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly JLOIIAFGCFD NCBANOLCNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly CancellationToken BACOGCKOPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly TArgs OKOGHNMMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private TArgs ADEAGMHJJKM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public TArgs CGHPBCAOGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x58B70C0", Offset = "0x58B56C0", VA = "0x1858B70C0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TArgs EHKNIPKFOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58B8C10", Offset = "0x58B7210", VA = "0x1858B8C10")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CanBeNull]
	public Task<TArgs> OCBLALDFNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x58B9210", Offset = "0x58B7810", VA = "0x1858B9210")]
	public PEPEGPOLCDE(TArgs GGEBFENIKCA, CancellationToken BACOGCKOPIE, JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x58B8110", Offset = "0x58B6710", VA = "0x1858B8110")]
	[AsyncStateMachine(typeof(PEPEGPOLCDE<>.NOJAIIKGBAP))]
	public Task IOLIFNKIGFL(TimeSpan IBGMHJBENBP, JLOIIAFGCFD ELNKNKEJDNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x58B8250", Offset = "0x58B6850", VA = "0x1858B8250")]
	[AsyncStateMachine(typeof(PEPEGPOLCDE<>.PFNPIPHCHDP))]
	public Task JJOIPFIAKDM(JLOIIAFGCFD ELNKNKEJDNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x58B7470", Offset = "0x58B5A70", VA = "0x1858B7470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x58B8F80", Offset = "0x58B7580", VA = "0x1858B8F80")]
	[AsyncStateMachine(typeof(PEPEGPOLCDE<>.BNBGEMALAED))]
	private Task ONBBDOKPEJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x58B7340", Offset = "0x58B5940", VA = "0x1858B7340")]
	[AsyncStateMachine(typeof(PEPEGPOLCDE<>.INBHKLPMHMI))]
	public Task<TArgs> CJGEMGCPDMP(GGIONJBNPMI NDEKEDDIBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x58B8E60", Offset = "0x58B7460", VA = "0x1858B8E60")]
	[AsyncStateMachine(typeof(PEPEGPOLCDE<>.NINOPCCIGHI))]
	private Task<TArgs> NPKHDFIDHOL(Task<TArgs> KGNNEDPIICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x58B7D40", Offset = "0x58B6340", VA = "0x1858B7D40")]
	public bool IADKPCACFOH(TArgs GFECMHPOLAL, [Out] string OPJHGBKNIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x58B8A30", Offset = "0x58B7030", VA = "0x1858B8A30")]
	private bool NEBBGFBLKLH(TArgs GFECMHPOLAL, [Out] string OPJHGBKNIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x58B7950", Offset = "0x58B5F50", VA = "0x1858B7950")]
	public CancellationTokenRegistration? GBIBPAGFJJN(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x58B91F0", Offset = "0x58B77F0", VA = "0x1858B91F0")]
	[CompilerGenerated]
	private void OPGIBNJNCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface CCBJIBFPIBP
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBIADOHIHJC(string JKANDKICJMG, string AEOHFOEEIKE, JLOIIAFGCFD NCBANOLCNJG, [Optional] string COAHNNNBDHI);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGOEAJHJBEB(string JKANDKICJMG, string AEOHFOEEIKE, JLOIIAFGCFD NCBANOLCNJG, [Optional] string COAHNNNBDHI);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFBFKLGHOME(string JKANDKICJMG, string AEOHFOEEIKE, JLOIIAFGCFD NCBANOLCNJG, [Optional] string COAHNNNBDHI);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEBDENOFOHL(string JKANDKICJMG, string AEOHFOEEIKE, JLOIIAFGCFD NCBANOLCNJG, Exception KCNEOPLNBEN, [Optional] string COAHNNNBDHI);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILGHLLJNFIH(string JKANDKICJMG, CKDKPHCBHJD PEJLMELAFGG);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class PPLIICNEGAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct GOGNPANLAPH<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CCBJIBFPIBP analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0E20", Offset = "0x4D9F420", VA = "0x184DA0E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1690", Offset = "0x4D9FC90", VA = "0x184DA1690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct INDNAJNLNHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CCBJIBFPIBP analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x80B5800", Offset = "0x80B3E00", VA = "0x1880B5800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x80B5CC0", Offset = "0x80B42C0", VA = "0x1880B5CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3D08890", Offset = "0x3D06E90", VA = "0x183D08890")]
	[AsyncStateMachine(typeof(GOGNPANLAPH<>))]
	public static Task<T> EPCOMBJJADN<T>(this Task<T> NPLKHMALANM, [CanBeNull] CCBJIBFPIBP FHEGKOHLHKP, string JKANDKICJMG, string AEOHFOEEIKE, JLOIIAFGCFD NCBANOLCNJG, [Optional] string COAHNNNBDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x80BECF0", Offset = "0x80BD2F0", VA = "0x1880BECF0")]
	[AsyncStateMachine(typeof(INDNAJNLNHC))]
	public static Task EPCOMBJJADN(this Task NPLKHMALANM, [CanBeNull] CCBJIBFPIBP FHEGKOHLHKP, string JKANDKICJMG, string AEOHFOEEIKE, JLOIIAFGCFD NCBANOLCNJG, [Optional] string COAHNNNBDHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate Task MBFBDONFEPL();
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate Task NKDFAILGLGG(OAJNBKMEPPG KLMPGFJOMPA);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FCKEPCFOFIN : EBBJHOMFMHH, HCMJLICOKOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class ANNNNICEFJA : CGKEDNMCGFJ, GGMCBKDJEDI, MDOCPICHOBF, KKMEPIFOPNG, PCEOADHBPHD, OGOOJDCDKGN, ANHPMAMOLKA, HCIGHHNENAN, LMKHCLLOEJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly NMMDGPOLHAJ[] HEPHIFGDMFP;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x80ADB50", Offset = "0x80AC150", VA = "0x1880ADB50")]
		public ANNNNICEFJA(IEnumerable<NMMDGPOLHAJ> JGHOCPEBJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x80ACEC0", Offset = "0x80AB4C0", VA = "0x1880ACEC0", Slot = "33")]
		public virtual void OnDisconnected(GBACHNAMKGK DBEFHDJNDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x80ACC10", Offset = "0x80AB210", VA = "0x1880ACC10", Slot = "4")]
		public void OnConnected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x80ACBB0", Offset = "0x80AB1B0", VA = "0x1880ACBB0", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		public void OnRegionListReceived(GNPLFIILCMH MCDKIEGJPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x80ACE20", Offset = "0x80AB420", VA = "0x1880ACE20", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> ACJFHCNBBBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x80ACD80", Offset = "0x80AB380", VA = "0x1880ACD80", Slot = "9")]
		public void OnCustomAuthenticationFailed(string BAJCNCEJNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x80AD7C0", Offset = "0x80ABDC0", VA = "0x1880AD7C0", Slot = "10")]
		public void OnPlayerEnteredRoom(OEFBHGPDFOL PKIBCOHEODF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x80AD9B0", Offset = "0x80ABFB0", VA = "0x1880AD9B0", Slot = "11")]
		public void OnPlayerWillLeaveRoom(OEFBHGPDFOL KCLMDJCLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x80AD860", Offset = "0x80ABE60", VA = "0x1880AD860", Slot = "12")]
		public void OnPlayerLeftRoom(OEFBHGPDFOL KCLMDJCLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x80ADAB0", Offset = "0x80AC0B0", VA = "0x1880ADAB0", Slot = "13")]
		public void OnRoomPropertiesUpdate(Hashtable MLFGAKLFDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x80AD900", Offset = "0x80ABF00", VA = "0x1880AD900", Slot = "14")]
		public void OnPlayerPropertiesUpdate(OEFBHGPDFOL NOFJGJEACCI, Hashtable LDCPJJFBAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x80AD720", Offset = "0x80ABD20", VA = "0x1880AD720", Slot = "15")]
		public void OnMasterClientSwitched(OEFBHGPDFOL BIMDGEMNEOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x80AD540", Offset = "0x80ABB40", VA = "0x1880AD540", Slot = "16")]
		public void OnJoinedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x80AD600", Offset = "0x80ABC00", VA = "0x1880AD600", Slot = "17")]
		public void OnLeftLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x80ADA50", Offset = "0x80AC050", VA = "0x1880ADA50", Slot = "18")]
		public void OnRoomListUpdate(List<PPNBGMMPBKH> BDHBAILNBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x80AD6C0", Offset = "0x80ABCC0", VA = "0x1880AD6C0", Slot = "19")]
		public void OnLobbyStatisticsUpdate(List<GICECNBKMFI> OPNOILKLBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x80AD430", Offset = "0x80ABA30", VA = "0x1880AD430", Slot = "20")]
		public void OnFriendListUpdate(List<LDAMLEFKAMH> OGLAOFGFEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x80ACD20", Offset = "0x80AB320", VA = "0x1880ACD20", Slot = "21")]
		public void OnCreatedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x80ACC70", Offset = "0x80AB270", VA = "0x1880ACC70", Slot = "22")]
		public void OnCreateRoomFailed(short EPCDLKGIILE, string CJIMOMNMAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x80AD5A0", Offset = "0x80ABBA0", VA = "0x1880AD5A0", Slot = "23")]
		public void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x80AD490", Offset = "0x80ABA90", VA = "0x1880AD490", Slot = "24")]
		public void OnJoinRoomFailed(short EPCDLKGIILE, string CJIMOMNMAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "25")]
		public void OnJoinRandomFailed(short EPCDLKGIILE, string CJIMOMNMAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x80AD660", Offset = "0x80ABC60", VA = "0x1880AD660", Slot = "26")]
		public void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "30")]
		public void AILMJPLOHIB(PEDEIDHCFOB FGCEFPKBOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "27")]
		public void NELMGCAFIKF(PhotonView BPNCLMCCNCP, OEFBHGPDFOL FMDCDGBCECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "28")]
		public void LIDEFJOBCKJ(PhotonView BPNCLMCCNCP, OEFBHGPDFOL AEOEEKFENFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "29")]
		public void OnWebRpcResponse(OperationResponse AIOFBMIEPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x80AD360", Offset = "0x80AB960", VA = "0x1880AD360", Slot = "31")]
		public void OnEvent(EventData JEAIDMHHJHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x80AD130", Offset = "0x80AB730", VA = "0x1880AD130", Slot = "32")]
		public void OnEventSend(EventData JEAIDMHHJHH, KPKDPCIEGLJ JCIFHCCPGEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly KMONKHNOLOM PMDOOMLHGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly NMMDGPOLHAJ LOEPJHGCKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly ANNNNICEFJA ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<FCKEPCFOFIN, bool> OBFAKKKOLIJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JDLMMOCIBOE MEFDKDCPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x80AED50", Offset = "0x80AD350", VA = "0x1880AED50", Slot = "4")]
		get
		{
			return default(JDLMMOCIBOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GEAJKOACMNI CEDFJNCLFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB53510", Offset = "0xB51B10", VA = "0x180B53510", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NMMDGPOLHAJ LLBBEPMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HPIFIPBBDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x80AEFD0", Offset = "0x80AD5D0", VA = "0x1880AEFD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool ENFIEEAABJK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x80AEC20", Offset = "0x80AD220", VA = "0x1880AEC20", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool EGDAFFCAGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x80AED70", Offset = "0x80AD370", VA = "0x1880AED70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool JOBJMFOCFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x80AED90", Offset = "0x80AD390", VA = "0x1880AED90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Exception HOHEHHLOIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xB5EA70", Offset = "0xB5D070", VA = "0x180B5EA70", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x80AEFF0", Offset = "0x80AD5F0", VA = "0x1880AEFF0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int GIMPNKBFHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x80AF020", Offset = "0x80AD620", VA = "0x1880AF020", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EDHKGLOLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x80AEB40", Offset = "0x80AD140", VA = "0x1880AEB40", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x80AF0F0", Offset = "0x80AD6F0", VA = "0x1880AF0F0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> DMGJFFIDKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x80AEB70", Offset = "0x80AD170", VA = "0x1880AEB70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x80AF040", Offset = "0x80AD640", VA = "0x1880AF040", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<JDLMMOCIBOE, JDLMMOCIBOE> ONEDGMLCCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x80AEDB0", Offset = "0x80AD3B0", VA = "0x1880AEDB0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x80AEF00", Offset = "0x80AD500", VA = "0x1880AEF00", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x80AF120", Offset = "0x80AD720", VA = "0x1880AF120")]
	public FCKEPCFOFIN(KMONKHNOLOM PMDOOMLHGCL, [Optional] Func<FCKEPCFOFIN, bool> OBFAKKKOLIJ, [Optional] HCMJLICOKOA KJHMCOCIPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x80AEE60", Offset = "0x80AD460", VA = "0x1880AEE60")]
	private void HPEMIJALKNJ(KMONKHNOLOM.ICMIBDLEMCN IHJHDNAKKAN, long KABOPCOFACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x80AEC40", Offset = "0x80AD240", VA = "0x1880AEC40", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x80AEFB0", Offset = "0x80AD5B0", VA = "0x1880AEFB0")]
	private void KEOAONPNFAE(OHNNABKKNNA HBKNLGPKKFM, OHNNABKKNNA ACBJLKJPPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IMIGKMEGIAL : CHNOGHNCFEH, LIOMIANNNGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class OJPHLJHAKMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CHLHACCNABJ targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OJPHLJHAKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x80BCB40", Offset = "0x80BB140", VA = "0x1880BCB40")]
		internal bool LHLBDJNLOBM(IAKDPHEHOMK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class PPBBDIOCIDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PPBBDIOCIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x80BEC90", Offset = "0x80BD290", VA = "0x1880BEC90")]
		internal Task DHKDLNJPJKC(IAKDPHEHOMK c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct KCGJMDCFBKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public IMIGKMEGIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x80B7270", Offset = "0x80B5870", VA = "0x1880B7270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x80B7720", Offset = "0x80B5D20", VA = "0x1880B7720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct HNLJKEJBILP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<CHLHACCNABJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public IMIGKMEGIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CHLHACCNABJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private Task<CHLHACCNABJ> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter<CHLHACCNABJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x80B3930", Offset = "0x80B1F30", VA = "0x1880B3930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x80B4320", Offset = "0x80B2920", VA = "0x1880B4320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MENICJMLACG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MENICJMLACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x80BC5E0", Offset = "0x80BABE0", VA = "0x1880BC5E0")]
		internal Task BJNMJDJKHDD(IAKDPHEHOMK c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct HKNLKKFIEOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public IMIGKMEGIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x80B3420", Offset = "0x80B1A20", VA = "0x1880B3420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x80B38D0", Offset = "0x80B1ED0", VA = "0x1880B38D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct IEBBBBMIACM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder<CHLHACCNABJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public IMIGKMEGIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CHLHACCNABJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<CHLHACCNABJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x80B4390", Offset = "0x80B2990", VA = "0x1880B4390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x80B4690", Offset = "0x80B2C90", VA = "0x1880B4690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct LCNCGODNCGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public IMIGKMEGIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x80B8760", Offset = "0x80B6D60", VA = "0x1880B8760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x80B8A90", Offset = "0x80B7090", VA = "0x1880B8A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct MGCOOAMCIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public IMIGKMEGIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x80BC640", Offset = "0x80BAC40", VA = "0x1880BC640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x80BC970", Offset = "0x80BAF70", VA = "0x1880BC970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly AGCAPFFAIAE PBENFBAGGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly JDMIOLJOGDG DBBNGGCBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly IAKDPHEHOMK[] JJJAIHIGHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly PFFKENHEPMO CKPFFHEHPBI;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public CHLHACCNABJ POFBMOHCKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x80B50A0", Offset = "0x80B36A0", VA = "0x1880B50A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string JPADHPDABEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x80B5530", Offset = "0x80B3B30", VA = "0x1880B5530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private IEnumerable<IAKDPHEHOMK> KNFBPLOOHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x80B5060", Offset = "0x80B3660", VA = "0x1880B5060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private PIFKHMANIJI BELNIFBLBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Task AJNIHAJNLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x80B51E0", Offset = "0x80B37E0", VA = "0x1880B51E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x80B5580", Offset = "0x80B3B80", VA = "0x1880B5580", Slot = "7")]
	public bool POBEMBNPMFC(CHLHACCNABJ EDGBFOPGMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x80B5660", Offset = "0x80B3C60", VA = "0x1880B5660")]
	[UnityEngine.Scripting.Preserve]
	public IMIGKMEGIAL([GGNLMCAPMLP(null)] AGCAPFFAIAE CDADOOIEBLD, [GGNLMCAPMLP(null)] JDMIOLJOGDG HLCJFJEAPCJ, [GGNLMCAPMLP(null)] PFFKENHEPMO LDLNJNHDIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x80B5230", Offset = "0x80B3830", VA = "0x1880B5230", Slot = "8")]
	[AsyncStateMachine(typeof(KCGJMDCFBKG))]
	public Task MPKFLLBBFIB([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x80B4F00", Offset = "0x80B3500", VA = "0x1880B4F00", Slot = "9")]
	[AsyncStateMachine(typeof(HNLJKEJBILP))]
	public Task<CHLHACCNABJ> FIJACKLHECC(CHLHACCNABJ EDGBFOPGMND, object LOLNHDPCOOD, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x80B5320", Offset = "0x80B3920", VA = "0x1880B5320", Slot = "10")]
	[AsyncStateMachine(typeof(HKNLKKFIEOC))]
	public Task NFAFJMHIABP([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x80B4A70", Offset = "0x80B3070", VA = "0x1880B4A70")]
	[AsyncStateMachine(typeof(IEBBBBMIACM))]
	private Task<CHLHACCNABJ> ACAIJHAKHIB(CHLHACCNABJ EDGBFOPGMND, object LOLNHDPCOOD, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x80B4E10", Offset = "0x80B3410", VA = "0x1880B4E10")]
	[AsyncStateMachine(typeof(LCNCGODNCGB))]
	private Task EHLFKLFLILO([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x80B50F0", Offset = "0x80B36F0", VA = "0x1880B50F0")]
	[AsyncStateMachine(typeof(MGCOOAMCIDK))]
	private Task LDNNAGGCDIJ([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x80B4BD0", Offset = "0x80B31D0", VA = "0x1880B4BD0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x80B5410", Offset = "0x80B3A10", VA = "0x1880B5410", Slot = "11")]
	public void NMCGGCBKCMA(NKDFAILGLGG PNPLCOMBOMN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct MMCIMPFKGEP : IEquatable<MMCIMPFKGEP>
{
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public static readonly MMCIMPFKGEP JLODNOEBAIE;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "4")]
	public bool Equals(MMCIMPFKGEP HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x80BC9D0", Offset = "0x80BAFD0", VA = "0x1880BC9D0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PFCLHOGMDMO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x80AE990", Offset = "0x80ACF90", VA = "0x1880AE990")]
	public PFCLHOGMDMO(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x80BCC00", Offset = "0x80BB200", VA = "0x1880BCC00")]
	public PFCLHOGMDMO(string CJIMOMNMAGD, Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KLHNEIFCEJJ : PFCLHOGMDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly string IANKKFHMJAA;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x80B7850", Offset = "0x80B5E50", VA = "0x1880B7850")]
	public KLHNEIFCEJJ(string FHEDIFCELCP, [NotNull] Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GKLHDAMCFHJ : PFCLHOGMDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public readonly CHLHACCNABJ LNCAPGONKKB;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x80AF3D0", Offset = "0x80AD9D0", VA = "0x1880AF3D0")]
	public GKLHDAMCFHJ(CHLHACCNABJ EOEHFJDHHKI, [NotNull] Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class FCPKCDGHFMI : PFCLHOGMDMO
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x80AE990", Offset = "0x80ACF90", VA = "0x1880AE990")]
	public FCPKCDGHFMI(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CKDKPHCBHJD : PFCLHOGMDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public readonly int? GIMPNKBFHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly OAJNBKMEPPG EGIENGGADPH;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x80AE7C0", Offset = "0x80ACDC0", VA = "0x1880AE7C0")]
	public CKDKPHCBHJD(OAJNBKMEPPG KLMPGFJOMPA, Exception OGLKKFPLOGF, int? KMJLNEPDLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x80AE550", Offset = "0x80ACB50", VA = "0x1880AE550")]
	public static CKDKPHCBHJD GNHMHBCIOMO(OAJNBKMEPPG DBEFHDJNDKN, EBBJHOMFMHH FLCPGOKHNCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PIKEFBJPICL : PFCLHOGMDMO
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x80AE990", Offset = "0x80ACF90", VA = "0x1880AE990")]
	public PIKEFBJPICL(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class BNEKLCADDFN : PFCLHOGMDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly short EHCDCKLHAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly string LNMGEJOIIPE;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x80ADF80", Offset = "0x80AC580", VA = "0x1880ADF80")]
	public BNEKLCADDFN(short AMNMJKOJOJL, string JCIFMHHPIPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class ANJAEEKDMLN : PFCLHOGMDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly short EHCDCKLHAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly string LNMGEJOIIPE;

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x80ACAC0", Offset = "0x80AB0C0", VA = "0x1880ACAC0")]
	public ANJAEEKDMLN(short AMNMJKOJOJL, string JCIFMHHPIPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DGOFMLJILOO : PFCLHOGMDMO
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x80AE990", Offset = "0x80ACF90", VA = "0x1880AE990")]
	public DGOFMLJILOO(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class DNKHCEHBNBP : PFCLHOGMDMO
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x80AE9F0", Offset = "0x80ACFF0", VA = "0x1880AE9F0")]
	public DNKHCEHBNBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class AKGMBHPEOCB : CLKDLCNIGIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly Dictionary<string, string> NIHIJMNKNGD;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x80ACA70", Offset = "0x80AB070", VA = "0x1880ACA70")]
	public AKGMBHPEOCB(TimeSpan GHMHNEFJOFM, string CJIMOMNMAGD, Dictionary<string, string> COAHNNNBDHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AGCAPFFAIAE : HDNFKANGGME<KEDGPMDLKIM>, PIFKHMANIJI, IAKDPHEHOMK, LIOMIANNNGF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct LMFAMGEMNOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AGCAPFFAIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x80BBCB0", Offset = "0x80BA2B0", VA = "0x1880BBCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class KFGGCLIACOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AGCAPFFAIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public JLOIIAFGCFD actionContext;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KFGGCLIACOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x80B7780", Offset = "0x80B5D80", VA = "0x1880B7780")]
		internal void EJJPPAHMLED(EHMNEFALKGP<string> timer, LHMKAIAPMBI log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HHAJBKHDIPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AGCAPFFAIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private KFGGCLIACOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private EHMNEFALKGP<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter<MAMMBDIALKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x80AF4F0", Offset = "0x80ADAF0", VA = "0x1880AF4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x80B1600", Offset = "0x80AFC00", VA = "0x1880B1600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private CancellationTokenSource PEKNHMGCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private CancellationTokenSource BPDLJHCNIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private CancellationToken JNOEPNOGMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool IBCEPKEOGBP;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool OIBCNHBBPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xD27EB0", Offset = "0xD264B0", VA = "0x180D27EB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x80AC160", Offset = "0x80AA760", VA = "0x1880AC160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x80AC7C0", Offset = "0x80AADC0", VA = "0x1880AC7C0", Slot = "13")]
	public override bool POBEMBNPMFC(CHLHACCNABJ EDGBFOPGMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x80AC980", Offset = "0x80AAF80", VA = "0x1880AC980")]
	[UnityEngine.Scripting.Preserve]
	public AGCAPFFAIAE([GGNLMCAPMLP(null)] KEDGPMDLKIM ILCCHPCLICG, [GGNLMCAPMLP(null)] JFLIMACEPOC GBAAELADHNE, [GGNLMCAPMLP(null)] CCBJIBFPIBP FHEGKOHLHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x80AC890", Offset = "0x80AAE90", VA = "0x1880AC890")]
	internal AGCAPFFAIAE(KEDGPMDLKIM ILCCHPCLICG, JFLIMACEPOC GBAAELADHNE, CCBJIBFPIBP FHEGKOHLHKP, MEBJOOPCAHM PIJKMMPEFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x80AC540", Offset = "0x80AAB40", VA = "0x1880AC540", Slot = "17")]
	protected override void OAFCFLGCIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x80AC410", Offset = "0x80AAA10", VA = "0x1880AC410")]
	private void HDICGKNCKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x80AC590", Offset = "0x80AAB90", VA = "0x1880AC590", Slot = "16")]
	protected override void ODJIICOFIDK(CHLHACCNABJ EFDGJIHHING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x80AC6F0", Offset = "0x80AACF0", VA = "0x1880AC6F0", Slot = "14")]
	protected override void PALLLEACICB(JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x80AC4C0", Offset = "0x80AAAC0", VA = "0x1880AC4C0", Slot = "15")]
	protected override void NAFJIGHPOPM(JLOIIAFGCFD NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x80AC230", Offset = "0x80AA830", VA = "0x1880AC230")]
	[AsyncStateMachine(typeof(LMFAMGEMNOF))]
	private void AOKPINCHNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x80AC2E0", Offset = "0x80AA8E0", VA = "0x1880AC2E0", Slot = "18")]
	[AsyncStateMachine(typeof(HHAJBKHDIPO))]
	public Task<IReadOnlyDictionary<string, int>> DDJGMKKKMEA([Optional] TimeSpan? KFIHKLMMNCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CHLHACCNABJ : MAMMBDIALKK, IEquatable<CHLHACCNABJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public readonly string DBIMKFFJMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public readonly string? NNADLKPIMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public readonly string? EOGEAPEGOCD;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x80AE360", Offset = "0x80AC960", VA = "0x1880AE360")]
	public CHLHACCNABJ(string LBICGCCAGAF, string NIANBIIPOPE, string PJOJCPAOIPF, string? HGNLGBJBJBK, string KPNDAMBENEN, string HDKICABIBJK, string? HFJIIENAFFB, string? BGHCCCFJODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x80AE300", Offset = "0x80AC900", VA = "0x1880AE300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x80AE140", Offset = "0x80AC740", VA = "0x1880AE140", Slot = "5")]
	public bool Equals(CHLHACCNABJ? HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x80AE070", Offset = "0x80AC670", VA = "0x1880AE070", Slot = "0")]
	public override bool Equals(object? ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x80AE1C0", Offset = "0x80AC7C0", VA = "0x1880AE1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x14214C0", Offset = "0x141FAC0", VA = "0x1814214C0")]
	public static bool JKIBMILPCGE(CHLHACCNABJ? DBDIOGELIIH, CHLHACCNABJ? LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1420DF0", Offset = "0x141F3F0", VA = "0x181420DF0")]
	public static bool FLMCEAOBGCC(CHLHACCNABJ? DBDIOGELIIH, CHLHACCNABJ? LHANOGJMGBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class MAMMBDIALKK : IEquatable<MAMMBDIALKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public readonly string GHAFPCDPJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public readonly string? OOHCNNOEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public readonly string? LJMLDIKBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string? KLONHCKMLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string KECKBPBDGFC;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x80BC490", Offset = "0x80BAA90", VA = "0x1880BC490")]
	public MAMMBDIALKK(string LBICGCCAGAF, string? NIANBIIPOPE, string? PJOJCPAOIPF, string? HGNLGBJBJBK, string KPNDAMBENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x80BC430", Offset = "0x80BAA30", VA = "0x1880BC430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x80BC210", Offset = "0x80BA810", VA = "0x1880BC210", Slot = "4")]
	public bool Equals(MAMMBDIALKK? HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x80BC2A0", Offset = "0x80BA8A0", VA = "0x1880BC2A0", Slot = "0")]
	public override bool Equals(object? ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x80BC340", Offset = "0x80BA940", VA = "0x1880BC340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JDMIOLJOGDG : HDNFKANGGME<JDMIOLJOGDG.KMCHLHJMKMK>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface POBJEJPOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OLCBGBPIAJN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class KMCHLHJMKMK : DCHBINOFFJA, KNPOGEIDBBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private EBBJHOMFMHH DFADLNABGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private bool NJJLLJLCGHF;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private PhotonVoiceNetwork FDBEKIBEJLO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x80B8150", Offset = "0x80B6750", VA = "0x1880B8150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool DMJBKCLAMLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA53E0", Offset = "0xAA39E0", VA = "0x180AA53E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public EBBJHOMFMHH MIOMHIHFGHN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool ENFIEEAABJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x80B7B60", Offset = "0x80B6160", VA = "0x1880B7B60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool EGDAFFCAGKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x80B7BB0", Offset = "0x80B61B0", VA = "0x1880B7BB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool IPOEEOLGBKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x80B7F10", Offset = "0x80B6510", VA = "0x1880B7F10", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool ANOLHMHILAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool HPIFIPBBDGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x80B7FA0", Offset = "0x80B65A0", VA = "0x1880B7FA0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public object DDHBCMNJGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x80B7D10", Offset = "0x80B6310", VA = "0x1880B7D10", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool NLGNHAFLMGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x80B7C00", Offset = "0x80B6200", VA = "0x1880B7C00", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x80B7980", Offset = "0x80B5F80", VA = "0x1880B7980", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EBBJHOMFMHH, EBBJHOMFMHH> IJNMLNBNMLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x80B8480", Offset = "0x80B6A80", VA = "0x1880B8480", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x80B7E60", Offset = "0x80B6460", VA = "0x1880B7E60", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> HHJDOCEDKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "22")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "23")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x80B8040", Offset = "0x80B6640", VA = "0x1880B8040", Slot = "10")]
		public void LCADLGCEDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x80B8630", Offset = "0x80B6C30", VA = "0x1880B8630", Slot = "18")]
		public bool PJHCEGLIFDL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x80B81B0", Offset = "0x80B67B0", VA = "0x1880B81B0", Slot = "19")]
		public bool MHMBKEEMFBH(string HDKICABIBJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x80B8380", Offset = "0x80B6980", VA = "0x1880B8380", Slot = "20")]
		public void MPKFLLBBFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x80B79E0", Offset = "0x80B5FE0", VA = "0x1880B79E0", Slot = "21")]
		public bool CJEBNMGCBCJ(object HMGOEIDKCEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "24")]
		public void IEFHEPKDIDM(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "25")]
		public void HOKENOKGCOI(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "26")]
		public void GKNLPKPFEEP(object DKFMAIJGPFL, bool BNCAKEBPMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x80B7FF0", Offset = "0x80B65F0", VA = "0x1880B7FF0", Slot = "27")]
		public IDisposable KLGOIMBEBIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "28")]
		private bool HIDBMBHLPEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "29")]
		public void DGCIHKAHILO(StringBuilder ALFEMNGJGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x80B8530", Offset = "0x80B6B30", VA = "0x1880B8530", Slot = "30")]
		public bool PJEGPIFHAPO(bool MOCIIBLGHNI, [Out] string NNDNCFBMBFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KMCHLHJMKMK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct IHFHILCCDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public JDMIOLJOGDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AGCAPFFAIAE clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<CHLHACCNABJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x80B4700", Offset = "0x80B2D00", VA = "0x1880B4700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x80B4A10", Offset = "0x80B3010", VA = "0x1880B4A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct APIGKGGIEFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public JDMIOLJOGDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x80ADBB0", Offset = "0x80AC1B0", VA = "0x1880ADBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x80ADF20", Offset = "0x80AC520", VA = "0x1880ADF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly AGCAPFFAIAE CDADOOIEBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly POBJEJPOGJI KFEDCPGGJKO;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x80B65F0", Offset = "0x80B4BF0", VA = "0x1880B65F0", Slot = "13")]
	public override bool POBEMBNPMFC(CHLHACCNABJ EDGBFOPGMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x80B6680", Offset = "0x80B4C80", VA = "0x1880B6680")]
	[RecRoom.NoEngine.Common.Preserve]
	public JDMIOLJOGDG([GGNLMCAPMLP(null)] AGCAPFFAIAE CDADOOIEBLD, [GGNLMCAPMLP(null)] JFLIMACEPOC GBAAELADHNE, [GGNLMCAPMLP(null)] POBJEJPOGJI KFEDCPGGJKO, [GGNLMCAPMLP(null)] CCBJIBFPIBP FHEGKOHLHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x80B6430", Offset = "0x80B4A30", VA = "0x1880B6430")]
	private Task OHGDNAGHBJK(OAJNBKMEPPG KLMPGFJOMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x80B61F0", Offset = "0x80B47F0", VA = "0x1880B61F0")]
	[AsyncStateMachine(typeof(IHFHILCCDMF))]
	public Task AILIIMFIDDJ(AGCAPFFAIAE APCKHIAOFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x80B62E0", Offset = "0x80B48E0", VA = "0x1880B62E0")]
	[CompilerGenerated]
	internal static void BDFFNAPOMNH(EBBJHOMFMHH COCMFLCIFNH, EBBJHOMFMHH LHEIHNIHOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x80B6360", Offset = "0x80B4960", VA = "0x1880B6360")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(APIGKGGIEFB))]
	private Task KDJCPEJEKFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.NoEngine.Common.Preserve]
public class INELBLMCLPI
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public INELBLMCLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.NoEngine.Common.Preserve]
public class KGAMAGMJPFL
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KGAMAGMJPFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class PFFKENHEPMO : IAKDPHEHOMK, LIOMIANNNGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum GCPJFGFJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private NetworkManager IPIKGHELDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private TaskCompletionSource<CHLHACCNABJ> AKEIOPKFPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	protected readonly JFLIMACEPOC KIPDOJCMLDG;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly LHMKAIAPMBI OAAFJAHOMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly HashSet<NKDFAILGLGG> GAEJBGNNPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public GCPJFGFJOCD EHIIGICLCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private CHLHACCNABJ EDGBFOPGMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private RSACryptoServiceProvider LCHKKCHMLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private RSACryptoServiceProvider CDFCFJLDBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private AesCryptoServiceProvider HNHDJNBKKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private byte[] GKPGKOOACOG;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public CHLHACCNABJ POFBMOHCKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string JPADHPDABEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x80BE7F0", Offset = "0x80BCDF0", VA = "0x1880BE7F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Task AJNIHAJNLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x80BE240", Offset = "0x80BC840", VA = "0x1880BE240", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x80BE470", Offset = "0x80BCA70", VA = "0x1880BE470", Slot = "10")]
	public void NMCGGCBKCMA(NKDFAILGLGG PNPLCOMBOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x80BE9A0", Offset = "0x80BCFA0", VA = "0x1880BE9A0", Slot = "6")]
	public bool POBEMBNPMFC(CHLHACCNABJ EDGBFOPGMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x80BEA50", Offset = "0x80BD050", VA = "0x1880BEA50")]
	[RecRoom.NoEngine.Common.Preserve]
	public PFFKENHEPMO([GGNLMCAPMLP(null)] JFLIMACEPOC JMHGLBPAMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x80BCCF0", Offset = "0x80BB2F0", VA = "0x1880BCCF0")]
	private void CGLMMLLGGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x80BD5B0", Offset = "0x80BBBB0", VA = "0x1880BD5B0")]
	private void ELLCKOGNALM(ulong ODCICEDDLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x80BCC70", Offset = "0x80BB270", VA = "0x1880BCC70")]
	private void CGIHJEBJHCN(bool IFOFDAJOJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x80BDFB0", Offset = "0x80BC5B0", VA = "0x1880BDFB0")]
	private void IFBJNMHDOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x80BDA90", Offset = "0x80BC090", VA = "0x1880BDA90")]
	private void GAMCGNGHPAM(ulong ODCICEDDLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x80BE640", Offset = "0x80BCC40", VA = "0x1880BE640")]
	private void ONGDJBMHCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x80BE1D0", Offset = "0x80BC7D0", VA = "0x1880BE1D0")]
	private void JHPHEOHCLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x80BE820", Offset = "0x80BCE20", VA = "0x1880BE820")]
	private void PNADDBKLNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x80BE4D0", Offset = "0x80BCAD0", VA = "0x1880BE4D0")]
	private void NNJEALFBGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x80BE6C0", Offset = "0x80BCCC0", VA = "0x1880BE6C0")]
	private static (IPAddress, ushort) OOIMCONAHIP(string FBNEFGLPGON)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x80BCF50", Offset = "0x80BB550", VA = "0x1880BCF50")]
	private void CPGFCBAJFNF(CHLHACCNABJ GMMHFCCPEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x80BD630", Offset = "0x80BBC30", VA = "0x1880BD630", Slot = "8")]
	public Task<CHLHACCNABJ> FIJACKLHECC(CHLHACCNABJ EDGBFOPGMND, object LOLNHDPCOOD, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x80BE290", Offset = "0x80BC890", VA = "0x1880BE290", Slot = "7")]
	public Task MPKFLLBBFIB([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x80BE380", Offset = "0x80BC980", VA = "0x1880BE380", Slot = "9")]
	public Task NFAFJMHIABP([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x80BD550", Offset = "0x80BBB50", VA = "0x1880BD550", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class EOMBIPAGIOA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x80AEA70", Offset = "0x80AD070", VA = "0x1880AEA70")]
	public EOMBIPAGIOA(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x80AEAD0", Offset = "0x80AD0D0", VA = "0x1880AEAD0")]
	public EOMBIPAGIOA(string CJIMOMNMAGD, Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class AFBLNDINEDO : EOMBIPAGIOA
{
	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x80AC080", Offset = "0x80AA680", VA = "0x1880AC080")]
	public AFBLNDINEDO([NotNull] Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class NBJJBPABEDG : EOMBIPAGIOA
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x80BCA40", Offset = "0x80BB040", VA = "0x1880BCA40")]
	public NBJJBPABEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class PILLLEBMNKN : EOMBIPAGIOA
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x80BEC10", Offset = "0x80BD210", VA = "0x1880BEC10")]
	public PILLLEBMNKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class KCEPPAPJCFO
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static AesCryptoServiceProvider DIPJEJBCFPL;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly string HOKFCIFHOPD;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly string EDCKEPNJLBM;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly string FJAAFNKOGMK;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x80B70D0", Offset = "0x80B56D0", VA = "0x1880B70D0")]
	public static string EHPPIHHMCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x80B6F80", Offset = "0x80B5580", VA = "0x1880B6F80")]
	public static string DFMLEDCPKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x80B6FD0", Offset = "0x80B55D0", VA = "0x1880B6FD0")]
	public static AesCryptoServiceProvider DPHHFALPJDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class HHAKJHCOGDD : JFLBIOHMDPC
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public enum ALFIFALMHHC
	{
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private LGEBFGGIOJB NFHENLANNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NetworkManager IPIKGHELDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	protected readonly JFLIMACEPOC KIPDOJCMLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<bool> MKBNBOPKMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public ALFIFALMHHC EHIIGICLCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private RSACryptoServiceProvider LCHKKCHMLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private RSACryptoServiceProvider CDFCFJLDBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private AesCryptoServiceProvider HNHDJNBKKNH;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LGEBFGGIOJB KAHJFEMLEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string LLDJKIOKFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string FPGHCBOOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x80B2DF0", Offset = "0x80B13F0", VA = "0x1880B2DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x80B3270", Offset = "0x80B1870", VA = "0x1880B3270")]
	[UnityEngine.Scripting.Preserve]
	public HHAKJHCOGDD([GGNLMCAPMLP(null)] JFLIMACEPOC JMHGLBPAMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x80B1B30", Offset = "0x80B0130", VA = "0x1880B1B30")]
	private void CGLMMLLGGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x80B2500", Offset = "0x80B0B00", VA = "0x1880B2500")]
	private void ELLCKOGNALM(ulong ODCICEDDLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x80B1670", Offset = "0x80AFC70", VA = "0x1880B1670")]
	private void BPDNPCNCGOE(ulong ODCICEDDLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x80B2C30", Offset = "0x80B1230", VA = "0x1880B2C30")]
	private void GAMCGNGHPAM(ulong ODCICEDDLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x80B3050", Offset = "0x80B1650", VA = "0x1880B3050")]
	private void ONGDJBMHCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x80B2D80", Offset = "0x80B1380", VA = "0x1880B2D80")]
	private void JHPHEOHCLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x80B2FB0", Offset = "0x80B15B0", VA = "0x1880B2FB0")]
	private void NNJEALFBGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x80B3140", Offset = "0x80B1740", VA = "0x1880B3140")]
	private static (IPAddress, ushort) OOIMCONAHIP(string FBNEFGLPGON)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x80B1D30", Offset = "0x80B0330", VA = "0x1880B1D30")]
	private void CPGFCBAJFNF(string KPNDAMBENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x80B2840", Offset = "0x80B0E40", VA = "0x1880B2840", Slot = "7")]
	public Task<bool> FONOAJMBPEC(string HFJIIENAFFB, string EJJFOKJFHBF, string KPNDAMBENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x80B2F10", Offset = "0x80B1510", VA = "0x1880B2F10", Slot = "8")]
	public Task MPKFLLBBFIB([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
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
