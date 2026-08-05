using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F557E0", Offset = "0x7F545E0", VA = "0x187F557E0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Type[] bindTypeSet3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE070", Offset = "0x7CCCE70", VA = "0x187CCE070", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F57760", Offset = "0x7F56560", VA = "0x187F57760")]
		private void OCIJCOAIOEO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F57430", Offset = "0x7F56230", VA = "0x187F57430")]
		private void JOJOLCIOGCC(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F57B40", Offset = "0x7F56940", VA = "0x187F57B40", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F57BF0", Offset = "0x7F569F0", VA = "0x187F57BF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(PCMAMBKNBEA), new string[] { "Photon" })]
public class IONNIELPPJE : PCMAMBKNBEA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class KOBPEIPEBHK : GBFCLKEFOGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NEJHGGPCOKC FELHJOMEEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode MHPAMBHJOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public LLEEPCGPNBG GMCIDFAMFEC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EKKDBLOILKP KDNIOMEAELB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F54C40", Offset = "0x7F53A40", VA = "0x187F54C40", Slot = "4")]
			get
			{
				return default(EKKDBLOILKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HMJDCIMFIOA EALAAGBDPPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7F555E0", Offset = "0x7F543E0", VA = "0x187F555E0", Slot = "5")]
			get
			{
				return default(HMJDCIMFIOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool HDMDCHHMGBN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F55360", Offset = "0x7F54160", VA = "0x187F55360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool DBPMIHBNDFF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F550B0", Offset = "0x7F53EB0", VA = "0x187F550B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F55590", Offset = "0x7F54390", VA = "0x187F55590", Slot = "8")]
		public object ONLADDFDIMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F54DC0", Offset = "0x7F53BC0", VA = "0x187F54DC0", Slot = "9")]
		private (HMJDCIMFIOA, Dictionary<object, object>) JEKANLMHIEA()
		{
			return default((HMJDCIMFIOA, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F55270", Offset = "0x7F54070", VA = "0x187F55270", Slot = "10")]
		private (LAFPBLKJNNP, HMJDCIMFIOA) OAJHGEPAIOJ()
		{
			return default((LAFPBLKJNNP, HMJDCIMFIOA));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F54C90", Offset = "0x7F53A90", VA = "0x187F54C90", Slot = "11")]
		private ILMNGEFPMMK<(LAFPBLKJNNP, HMJDCIMFIOA)> HIILFOEPBCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F54A30", Offset = "0x7F53830", VA = "0x187F54A30", Slot = "12")]
		private (MLHKGBLBCLB, byte[]) AGFELJLHOAE()
		{
			return default((MLHKGBLBCLB, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F55370", Offset = "0x7F54170", VA = "0x187F55370", Slot = "13")]
		private (HFKGBNOFMOB, byte[]) OMMDNHDONHO()
		{
			return default((HFKGBNOFMOB, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4072910", Offset = "0x4071710", VA = "0x184072910", Slot = "14")]
		public T DOIHCEMHOKH<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F55630", Offset = "0x7F54430", VA = "0x187F55630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KOBPEIPEBHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class LLEEPCGPNBG : ILMNGEFPMMK<(LAFPBLKJNNP, HMJDCIMFIOA)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] LHMJACPJKPM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int PIMHGEALGDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7F55720", Offset = "0x7F54520", VA = "0x187F55720", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (LAFPBLKJNNP view, HMJDCIMFIOA newOwner) ANMDDLMJFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7F55740", Offset = "0x7F54540", VA = "0x187F55740", Slot = "4")]
			get
			{
				return default((LAFPBLKJNNP, HMJDCIMFIOA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LLEEPCGPNBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F54740", Offset = "0x7F53540", VA = "0x187F54740", Slot = "4")]
	public bool KFANGKAFJMA(object FFEMKICJPKP, GBFCLKEFOGF LANOOKFCHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IONNIELPPJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HKGNMBKLJCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(NFBBIOEIINP))]
[RegisterService(typeof(MHINEIEEMNP), new string[] { "Photon" })]
public class NFBBIOEIINP : GACJOGFPDAE, GNJGKFCJPFE, MHINEIEEMNP, AHDIFPEGPEL, FAGFKOAOOFH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private GADBIHCFMHL NMFFKEACGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private NODDMGJGEIP DMKDGGHGHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable ADPBPEDNFCM;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F55C90", Offset = "0x7F54A90", VA = "0x187F55C90", Slot = "4")]
	public void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F55B80", Offset = "0x7F54980", VA = "0x187F55B80", Slot = "5")]
	public void BFNHDDHMDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F558F0", Offset = "0x7F546F0", VA = "0x187F558F0", Slot = "6")]
	public void AIGMNFJDDJC(HFKGBNOFMOB MAKJJJECHHB, ReadOnlySpan<byte> DKEBGKJJPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F55A60", Offset = "0x7F54860", VA = "0x187F55A60", Slot = "10")]
	public void AKEDEPPGGFE(HFKGBNOFMOB NFKNOBMDJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F55DF0", Offset = "0x7F54BF0", VA = "0x187F55DF0", Slot = "7")]
	public void LGMIIIJHLAM(ReadOnlySpan<HFKGBNOFMOB> LCLAIHPHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F55F80", Offset = "0x7F54D80", VA = "0x187F55F80")]
	private Hashtable MCFGPLGEHKC(Hashtable PFKDOKKJJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F55C30", Offset = "0x7F54A30", VA = "0x187F55C30")]
	public void BKGKIMPMJEA(object KPAGBEKAECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F55D80", Offset = "0x7F54B80", VA = "0x187F55D80", Slot = "8")]
	private void KHEDDOBEPFG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11E2B80", Offset = "0x11E1980", VA = "0x1811E2B80", Slot = "9")]
	private void JLHNKKDCLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F56270", Offset = "0x7F55070", VA = "0x187F56270")]
	public NFBBIOEIINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::EGKJBPOHLIJ), new string[] { })]
internal class KBDHAGBCMFG : BPLCOLJOLMB, global::EGKJBPOHLIJ
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IEBEPMGFCGH PGHEJOMPKCP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override IEBEPMGFCGH[] COBHLCNKKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F54980", Offset = "0x7F53780", VA = "0x187F54980")]
	public KBDHAGBCMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DGLJPEFBKHG : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F525E0", Offset = "0x7F513E0", VA = "0x187F525E0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type AAFMBEEMJAC, MemberSerialization OGHAGAPNAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F527F0", Offset = "0x7F515F0", VA = "0x187F527F0")]
	public DGLJPEFBKHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ALNBGAAEJBP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EIICAJNEBLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EIICAJNEBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F52840", Offset = "0x7F51640", VA = "0x187F52840")]
		internal string EOGBOPENDDP(NEJHGGPCOKC eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F524D0", Offset = "0x7F512D0", VA = "0x187F524D0")]
	public static string MKNDHPGKLDJ(this NEJHGGPCOKC FELHJOMEEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F52380", Offset = "0x7F51180", VA = "0x187F52380")]
	public static EKKDBLOILKP MBAEHNCHIAE(this NEJHGGPCOKC FELHJOMEEAD)
	{
		return default(EKKDBLOILKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F51D60", Offset = "0x7F50B60", VA = "0x187F51D60")]
	public static ViewId IGMLJMLMOLK(this NEJHGGPCOKC FELHJOMEEAD)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F520D0", Offset = "0x7F50ED0", VA = "0x187F520D0")]
	public static string JOFBLFMGGFC(this NEJHGGPCOKC FELHJOMEEAD, JsonSerializerSettings CKBAKJFJHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F524F0", Offset = "0x7F512F0", VA = "0x187F524F0")]
	private static string OJJLIPKLFLE(NEJHGGPCOKC FELHJOMEEAD, Func<NEJHGGPCOKC, string> CFDGGKIIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F51F60", Offset = "0x7F50D60", VA = "0x187F51F60")]
	public static string INCCIGNJDJH(this NEJHGGPCOKC FELHJOMEEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F521A0", Offset = "0x7F50FA0", VA = "0x187F521A0")]
	public static ViewId KDKPEFMOBHF(this NEJHGGPCOKC FELHJOMEEAD)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F51C40", Offset = "0x7F50A40", VA = "0x187F51C40")]
	public static string ENNLICELFPF(this NEJHGGPCOKC FELHJOMEEAD, JsonSerializerSettings CKBAKJFJHKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PPAHGBEGNMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class JCECKKIKNIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string PDAJPLDIMJI;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F56AF0", Offset = "0x7F558F0", VA = "0x187F56AF0")]
	public static string OAKPPHGBHJB(EKKDBLOILKP GDAEOLOIDMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(OFDLABPOANP), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class OFDLABPOANP : BPLCOLJOLMB
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly IEBEPMGFCGH FFOOPEEGOJG;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly IEBEPMGFCGH KJPGGDFCNAG;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IEBEPMGFCGH FDFMFMEOAHK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override IEBEPMGFCGH[] COBHLCNKKFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F562F0", Offset = "0x7F550F0", VA = "0x187F562F0", Slot = "9")]
	public override void BIBFJNBONAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F56490", Offset = "0x7F55290", VA = "0x187F56490", Slot = "10")]
	public override void JFJBEMBOGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F56480", Offset = "0x7F55280", VA = "0x187F56480")]
	private void GPEDIKOMNFE(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F56620", Offset = "0x7F55420", VA = "0x187F56620")]
	private void JNKAMEPNPOA(NEJHGGPCOKC FELHJOMEEAD, EEKDOOHAAOB PCLCKPBICJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F56700", Offset = "0x7F55500", VA = "0x187F56700")]
	public void OOPLOBGODIC(NEJHGGPCOKC FELHJOMEEAD, OJMIHHBLGGJ PGNAJMBPBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F56650", Offset = "0x7F55450", VA = "0x187F56650")]
	private static IEBEPMGFCGH NPKBJNOEIHM(byte OICKECDHHGJ)
	{
		return default(IEBEPMGFCGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F56A00", Offset = "0x7F55800", VA = "0x187F56A00")]
	public OFDLABPOANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HNKHAAIFHBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PLPBMPKIACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings AKJOEDLEHLO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F534B0", Offset = "0x7F522B0", VA = "0x187F534B0")]
	public static KCOMIDCFFCP JGOCGJDEAKH([In] this KCOMIDCFFCP OHHADODJICI, NEJHGGPCOKC FELHJOMEEAD, OJMIHHBLGGJ PGNAJMBPBOM)
	{
		return default(KCOMIDCFFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F52D50", Offset = "0x7F51B50", VA = "0x187F52D50")]
	public static KCOMIDCFFCP EIBFIHBAGLF([In] this KCOMIDCFFCP OHHADODJICI, NEJHGGPCOKC FELHJOMEEAD)
	{
		return default(KCOMIDCFFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F53240", Offset = "0x7F52040", VA = "0x187F53240")]
	public static string HLKAEEOMIKP(NEJHGGPCOKC FELHJOMEEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F52980", Offset = "0x7F51780", VA = "0x187F52980")]
	public static string BAKMENDBPFL(NEJHGGPCOKC FELHJOMEEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F530B0", Offset = "0x7F51EB0", VA = "0x187F530B0")]
	public static string FIFHLJDBMGN(NEJHGGPCOKC FELHJOMEEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F53420", Offset = "0x7F52220", VA = "0x187F53420")]
	[CompilerGenerated]
	internal static bool JGHHPKGDCHG([Out] string BPINCJLADGC, PLPBMPKIACM P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F52BE0", Offset = "0x7F519E0", VA = "0x187F52BE0")]
	[CompilerGenerated]
	internal static bool ECKBKLMHLIE([Out] string BPINCJLADGC, PLPBMPKIACM P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KAMDLADCGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KAMDLADCGCG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
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
