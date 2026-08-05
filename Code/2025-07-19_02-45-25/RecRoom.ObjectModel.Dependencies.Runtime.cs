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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83398E0", Offset = "0x83388E0", VA = "0x1883398E0", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2317030", Offset = "0x2316030", VA = "0x182317030", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x833A310", Offset = "0x8339310", VA = "0x18833A310")]
		private void MNKCLNFPDFM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8339FF0", Offset = "0x8338FF0", VA = "0x188339FF0")]
		private void JFDGNDHPLAM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x833A6F0", Offset = "0x83396F0", VA = "0x18833A6F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x833A7A0", Offset = "0x83397A0", VA = "0x18833A7A0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(KLNNDINKLGO), new string[] { "Photon" })]
public class OKNALLIPDJD : KLNNDINKLGO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class HLCGAIEGLHF : PJEMIAGADJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PMOFBKDCPEL PHDJPEOAFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode IGOMDNPENJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public GDEHBAPCPMH DMIIGCPADAG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HGJJHEKNHLL HHDOJPCILPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8339570", Offset = "0x8338570", VA = "0x188339570", Slot = "4")]
			get
			{
				return default(HGJJHEKNHLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DOHKIBLNJFC BEDFELGNCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8339520", Offset = "0x8338520", VA = "0x188339520", Slot = "5")]
			get
			{
				return default(DOHKIBLNJFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CILHAGGMFND
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8338DE0", Offset = "0x8337DE0", VA = "0x188338DE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool PAMDCONEICJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8338DF0", Offset = "0x8337DF0", VA = "0x188338DF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8338FB0", Offset = "0x8337FB0", VA = "0x188338FB0", Slot = "8")]
		public object FGNMCPKHBLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83390F0", Offset = "0x83380F0", VA = "0x1883390F0", Slot = "9")]
		private (DOHKIBLNJFC, Dictionary<object, object>) HFJCACDLGGC()
		{
			return default((DOHKIBLNJFC, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8339000", Offset = "0x8338000", VA = "0x188339000", Slot = "10")]
		private (AGKIKBEKNMF, DOHKIBLNJFC) FLIPHDMAPOE()
		{
			return default((AGKIKBEKNMF, DOHKIBLNJFC));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83393F0", Offset = "0x83383F0", VA = "0x1883393F0", Slot = "11")]
		private OBBFKFHHJAB<(AGKIKBEKNMF, DOHKIBLNJFC)> LNCDHMPEBEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8338BC0", Offset = "0x8337BC0", VA = "0x188338BC0", Slot = "12")]
		private (HGPLMIJAIIE, byte[]) AFJPDGKEAIL()
		{
			return default((HGPLMIJAIIE, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83395C0", Offset = "0x83385C0", VA = "0x1883395C0", Slot = "13")]
		private (KIHNPHHCPLP, byte[]) PFGBCLPPFHM()
		{
			return default((KIHNPHHCPLP, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43A0AD0", Offset = "0x439FAD0", VA = "0x1843A0AD0", Slot = "14")]
		public T BDGECBGONFO<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83397F0", Offset = "0x83387F0", VA = "0x1883397F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HLCGAIEGLHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class GDEHBAPCPMH : OBBFKFHHJAB<(AGKIKBEKNMF, DOHKIBLNJFC)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] MGIGFLIKPCD;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int BJKDLCPHPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8337FA0", Offset = "0x8336FA0", VA = "0x188337FA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (AGKIKBEKNMF view, DOHKIBLNJFC newOwner) LJHNMNJFPNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8337F00", Offset = "0x8336F00", VA = "0x188337F00", Slot = "4")]
			get
			{
				return default((AGKIKBEKNMF, DOHKIBLNJFC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GDEHBAPCPMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83399F0", Offset = "0x83389F0", VA = "0x1883399F0", Slot = "4")]
	public bool AGIMFBCEFJB(object INCJDDLACNP, PJEMIAGADJB PJGOCFNEGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OKNALLIPDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class OMHJJJKCIJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(CLHLFDADECC))]
[RegisterService(typeof(JNHCHHCBMCK), new string[] { "Photon" })]
public class CLHLFDADECC : PJNGLGAADAH, FAFPDCNJCHG, JNHCHHCBMCK, KELFAPLDHJK, GDOFPGECDFM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private KJGOBLBKEIB IEHKKLCADNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private JIAHAALABFH ACDOKNPGPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable KAEILAKIAKE;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8334DF0", Offset = "0x8333DF0", VA = "0x188334DF0", Slot = "4")]
	public void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8335140", Offset = "0x8334140", VA = "0x188335140", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8334900", Offset = "0x8333900", VA = "0x188334900", Slot = "6")]
	public void AHALJBEAONO(KIHNPHHCPLP DAKIIEIEKNI, ReadOnlySpan<byte> MBAGIDFJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8334AD0", Offset = "0x8333AD0", VA = "0x188334AD0", Slot = "10")]
	public void ECMNGPIDIGM(KIHNPHHCPLP LAJEHHGIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8334C60", Offset = "0x8333C60", VA = "0x188334C60", Slot = "7")]
	public void HCDNIGMNHGL(ReadOnlySpan<KIHNPHHCPLP> BJIFFGJCJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8334EE0", Offset = "0x8333EE0", VA = "0x188334EE0")]
	private Hashtable MAGCPOGKACA(Hashtable GANCNBAHFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8334A70", Offset = "0x8333A70", VA = "0x188334A70")]
	public void BNMKLKKGILL(object NPMBPMNFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8334BF0", Offset = "0x8333BF0", VA = "0x188334BF0", Slot = "8")]
	private void FDOELKOHJIM(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x12C73A0", Offset = "0x12C63A0", VA = "0x1812C73A0", Slot = "9")]
	private void BBFHDNOELJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8335280", Offset = "0x8334280", VA = "0x188335280")]
	public CLHLFDADECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::IDJFFGPAJCG), new string[] { })]
internal class AOLACOOPOFG : FFJCIAOGIBC, global::IDJFFGPAJCG
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly ONIHMLNNEEF EMDOKHPMGEI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override ONIHMLNNEEF[] BDIJGBAKPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83347E0", Offset = "0x83337E0", VA = "0x1883347E0")]
	public AOLACOOPOFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GGHFNCFEADF : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8337FC0", Offset = "0x8336FC0", VA = "0x188337FC0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type BJLNCBFOGNL, MemberSerialization HJNIABOADOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83381D0", Offset = "0x83371D0", VA = "0x1883381D0")]
	public GGHFNCFEADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GGLKCFHNECJ
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PNCCBEAPIPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PNCCBEAPIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8339B80", Offset = "0x8338B80", VA = "0x188339B80")]
		internal string IFPHLELLKEK(PMOFBKDCPEL eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8338630", Offset = "0x8337630", VA = "0x188338630")]
	public static string DPAEIDHBLIB(this PMOFBKDCPEL PHDJPEOAFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83387C0", Offset = "0x83377C0", VA = "0x1883387C0")]
	public static HGJJHEKNHLL MHNKCPFADGJ(this PMOFBKDCPEL PHDJPEOAFMD)
	{
		return default(HGJJHEKNHLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8338220", Offset = "0x8337220", VA = "0x188338220")]
	public static ViewId AFAOFKOOCPD(this PMOFBKDCPEL PHDJPEOAFMD)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8338AF0", Offset = "0x8337AF0", VA = "0x188338AF0")]
	public static string NDFIHNLNFPL(this PMOFBKDCPEL PHDJPEOAFMD, JsonSerializerSettings IABBELGMKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8338540", Offset = "0x8337540", VA = "0x188338540")]
	private static string DEIEEPBIPCP(PMOFBKDCPEL PHDJPEOAFMD, Func<PMOFBKDCPEL, string> DMHPHEGJKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8338650", Offset = "0x8337650", VA = "0x188338650")]
	public static string MGHGOAHPMHI(this PMOFBKDCPEL PHDJPEOAFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8338910", Offset = "0x8337910", VA = "0x188338910")]
	public static ViewId NCNCPCBCABN(this PMOFBKDCPEL PHDJPEOAFMD)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8338420", Offset = "0x8337420", VA = "0x188338420")]
	public static string CCNMDCDAOOK(this PMOFBKDCPEL PHDJPEOAFMD, JsonSerializerSettings IABBELGMKHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DDEKBEOHKNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class CFLOLOEGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string ENEGDEBJLGO;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8335300", Offset = "0x8334300", VA = "0x188335300")]
	public static string PMMCIPONHLL(HGJJHEKNHLL GHGCAGAGHCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(FCDGBGEEKDE), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class FCDGBGEEKDE : FFJCIAOGIBC
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly ONIHMLNNEEF AIFKDHFJPDO;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly ONIHMLNNEEF CGPKHFFHOEM;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly ONIHMLNNEEF IOCEBMHGBJI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override ONIHMLNNEEF[] BDIJGBAKPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8337BD0", Offset = "0x8336BD0", VA = "0x188337BD0", Slot = "9")]
	public override void PNAOLOMOOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8337710", Offset = "0x8336710", VA = "0x188337710", Slot = "10")]
	public override void IGIOGBHBKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8337700", Offset = "0x8336700", VA = "0x188337700")]
	private void GCJBOPECEAF(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8337BA0", Offset = "0x8336BA0", VA = "0x188337BA0")]
	private void PEPLJJIJLGO(PMOFBKDCPEL PHDJPEOAFMD, NDFFKECCNKF MOIMLBHBNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83378A0", Offset = "0x83368A0", VA = "0x1883378A0")]
	public void JICEHJFOCPM(PMOFBKDCPEL PHDJPEOAFMD, FILJPCBJCLJ CDCLEENLNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8337AF0", Offset = "0x8336AF0", VA = "0x188337AF0")]
	private static ONIHMLNNEEF NPDGKHBGAHB(byte KBDMNJDINLK)
	{
		return default(ONIHMLNNEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8337E10", Offset = "0x8336E10", VA = "0x188337E10")]
	public FCDGBGEEKDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EBEKLHBJGED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ODHHLIALELG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings EAPGBMFKMOB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8335910", Offset = "0x8334910", VA = "0x188335910")]
	public static JFIINGNNCOL APJGCPKOJEE([In] this JFIINGNNCOL BHEKJKJMJJC, PMOFBKDCPEL PHDJPEOAFMD, FILJPCBJCLJ CDCLEENLNDP)
	{
		return default(JFIINGNNCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83371C0", Offset = "0x83361C0", VA = "0x1883371C0")]
	public static JFIINGNNCOL ONHJNCOGKPO([In] this JFIINGNNCOL BHEKJKJMJJC, PMOFBKDCPEL PHDJPEOAFMD)
	{
		return default(JFIINGNNCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8336C00", Offset = "0x8335C00", VA = "0x188336C00")]
	public static string FPGGPMLHNAN(PMOFBKDCPEL PHDJPEOAFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8336F60", Offset = "0x8335F60", VA = "0x188336F60")]
	public static string OBKJNNLBFDG(PMOFBKDCPEL PHDJPEOAFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8336A70", Offset = "0x8335A70", VA = "0x188336A70")]
	public static string FJIHLEIMDKP(PMOFBKDCPEL PHDJPEOAFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83369E0", Offset = "0x83359E0", VA = "0x1883369E0")]
	[CompilerGenerated]
	internal static bool CCAAJABJEKD([Out] string BGOCMPMGKKI, ODHHLIALELG P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8336DF0", Offset = "0x8335DF0", VA = "0x188336DF0")]
	[CompilerGenerated]
	internal static bool LMIJBJMCHFN([Out] string BGOCMPMGKKI, ODHHLIALELG P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
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
