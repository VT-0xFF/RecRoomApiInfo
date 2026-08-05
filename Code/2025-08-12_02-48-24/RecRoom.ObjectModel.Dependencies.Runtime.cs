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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8626E90", Offset = "0x8625490", VA = "0x188626E90", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23A8580", Offset = "0x23A6B80", VA = "0x1823A8580", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86294F0", Offset = "0x8627AF0", VA = "0x1886294F0")]
		private void DHALDHDBNEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86298D0", Offset = "0x8627ED0", VA = "0x1886298D0")]
		private void FAEKOOMPDOO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8629C00", Offset = "0x8628200", VA = "0x188629C00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8629CB0", Offset = "0x86282B0", VA = "0x188629CB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(KHKDPIBCEIO), new string[] { "Photon" })]
public class GKCJPFEGAHH : KHKDPIBCEIO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class DDIMJDHNNDA : EAJHCAPHDEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CHPJIJKJKGB KJOIOABMAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode MKCFKNPGJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public BOHAMCODMGM EGNFKOGBKFM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BGMNBFIFPOB MONFNOPPPGA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8624940", Offset = "0x8622F40", VA = "0x188624940", Slot = "4")]
			get
			{
				return default(BGMNBFIFPOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NAPCGDBANAF APDIKMDHFPC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8623FC0", Offset = "0x86225C0", VA = "0x188623FC0", Slot = "5")]
			get
			{
				return default(NAPCGDBANAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AAHCFOKAHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8624540", Offset = "0x8622B40", VA = "0x188624540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool HBAIDMLKEBK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8624780", Offset = "0x8622D80", VA = "0x188624780", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8624140", Offset = "0x8622740", VA = "0x188624140", Slot = "8")]
		public object ECACAOJHGKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86243B0", Offset = "0x86229B0", VA = "0x1886243B0", Slot = "9")]
		private (NAPCGDBANAF, object) IGCJLDKCBDG()
		{
			return default((NAPCGDBANAF, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8624990", Offset = "0x8622F90", VA = "0x188624990", Slot = "10")]
		private (DFCAHNMFPEN, NAPCGDBANAF) OIGBHNDODDD()
		{
			return default((DFCAHNMFPEN, NAPCGDBANAF));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8624010", Offset = "0x8622610", VA = "0x188624010", Slot = "11")]
		private JHHNOACDLEC<(DFCAHNMFPEN, NAPCGDBANAF)> BNJIINACBDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8624190", Offset = "0x8622790", VA = "0x188624190", Slot = "12")]
		private (GNAHHGJHLEP, byte[]) FGMLBIBEEBD()
		{
			return default((GNAHHGJHLEP, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8624550", Offset = "0x8622B50", VA = "0x188624550", Slot = "13")]
		private (EDIKLMECBPD, byte[]) KPJEBHDBBBF()
		{
			return default((EDIKLMECBPD, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x44975C0", Offset = "0x4495BC0", VA = "0x1844975C0", Slot = "14")]
		public T BPHAABJLGCF<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8624A80", Offset = "0x8623080", VA = "0x188624A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public DDIMJDHNNDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class BOHAMCODMGM : JHHNOACDLEC<(DFCAHNMFPEN, NAPCGDBANAF)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] CBHIACGIAAM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LFBOMEJGMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8623FA0", Offset = "0x86225A0", VA = "0x188623FA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (DFCAHNMFPEN view, NAPCGDBANAF newOwner) BNCJGLMKBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8623F00", Offset = "0x8622500", VA = "0x188623F00", Slot = "4")]
			get
			{
				return default((DFCAHNMFPEN, NAPCGDBANAF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BOHAMCODMGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86254F0", Offset = "0x8623AF0", VA = "0x1886254F0", Slot = "4")]
	public bool ABLHAGFIIDN(object DAJAOHIJHHL, EAJHCAPHDEM DDEFJBAICMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GKCJPFEGAHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class NNOLHFICPJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(IKPBNDJHGCP))]
[RegisterService(typeof(JDABOHMACFB), new string[] { "Photon" })]
public class IKPBNDJHGCP : DPFKFJLGBCO, PNLABLKFCDP, JDABOHMACFB, FCOEENGBKBM, CEJIANFMEIL
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private CAMBEBEGFGN AEAKONLNGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private GDMBHKAFGNG BDJMCBNDFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable MKBODFCJGPA;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8626250", Offset = "0x8624850", VA = "0x188626250", Slot = "4")]
	public void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86264D0", Offset = "0x8624AD0", VA = "0x1886264D0", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8625FC0", Offset = "0x86245C0", VA = "0x188625FC0", Slot = "6")]
	public void DLFNHJGPKGD(EDIKLMECBPD HFLDIIIPBCG, ReadOnlySpan<byte> KMJEOGEJMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8626130", Offset = "0x8624730", VA = "0x188626130", Slot = "10")]
	public void GIGICKEEFNG(EDIKLMECBPD GFDECINHCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8626340", Offset = "0x8624940", VA = "0x188626340", Slot = "7")]
	public void NPFHFOCFIDD(ReadOnlySpan<EDIKLMECBPD> JCJKPDOHPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8625D60", Offset = "0x8624360", VA = "0x188625D60")]
	private Hashtable BJPKCGPOGBK(Hashtable BBEHEPMNJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8625C90", Offset = "0x8624290", VA = "0x188625C90")]
	public void ALGHCKOECHC(object KMDFLMLKEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8625CF0", Offset = "0x86242F0", VA = "0x188625CF0", Slot = "8")]
	private void BFPDDFBJGNA(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1004A20", Offset = "0x1003020", VA = "0x181004A20", Slot = "9")]
	private void KMJKAGKKLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8626610", Offset = "0x8624C10", VA = "0x188626610")]
	public IKPBNDJHGCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::BICOEHEEJEN), new string[] { })]
internal class PEOGAINHHIP : KPHPJKEEOIG, global::BICOEHEEJEN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IDGHEFJHGEI OKHELEAHJMF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override IDGHEFJHGEI[] NNKKLHMJDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8628EB0", Offset = "0x86274B0", VA = "0x188628EB0")]
	public PEOGAINHHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PGOOABFGGIJ : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8628F60", Offset = "0x8627560", VA = "0x188628F60", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type EHLAHNIAPLD, MemberSerialization BPNKKNGHKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8629170", Offset = "0x8627770", VA = "0x188629170")]
	public PGOOABFGGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DFCMCALEBJD
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BACOIKDHELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BACOIKDHELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8623DC0", Offset = "0x86223C0", VA = "0x188623DC0")]
		internal string KPDGCOMPOFO(CHPJIJKJKGB eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8625060", Offset = "0x8623660", VA = "0x188625060")]
	public static string GLECBPHBDFL(this CHPJIJKJKGB KJOIOABMAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86253B0", Offset = "0x86239B0", VA = "0x1886253B0")]
	public static BGMNBFIFPOB NPHNNCCKHNJ(this CHPJIJKJKGB KJOIOABMAMH)
	{
		return default(BGMNBFIFPOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8624C90", Offset = "0x8623290", VA = "0x188624C90")]
	public static ViewId AODDCHMFLEF(this CHPJIJKJKGB KJOIOABMAMH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86252E0", Offset = "0x86238E0", VA = "0x1886252E0")]
	public static string MHPENOAEIOJ(this CHPJIJKJKGB KJOIOABMAMH, JsonSerializerSettings LJLPCHJLFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86251F0", Offset = "0x86237F0", VA = "0x1886251F0")]
	private static string MHMIACMDLKM(CHPJIJKJKGB KJOIOABMAMH, Func<CHPJIJKJKGB, string> CBDPHPPPDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8625080", Offset = "0x8623680", VA = "0x188625080")]
	public static string JACGBDMBINI(this CHPJIJKJKGB KJOIOABMAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8624E90", Offset = "0x8623490", VA = "0x188624E90")]
	public static ViewId GJLJACIHPAO(this CHPJIJKJKGB KJOIOABMAMH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8624B70", Offset = "0x8623170", VA = "0x188624B70")]
	public static string AFBNDIEPACJ(this CHPJIJKJKGB KJOIOABMAMH, JsonSerializerSettings LJLPCHJLFHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HCDPLMJMDLC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class MDFLNHMHAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string DGHFBNKMICB;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8625680", Offset = "0x8623C80", VA = "0x188625680")]
	public static string LABAOGDNGJJ(BGMNBFIFPOB GJJLANCEJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(KPDONFDAHLB), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class KPDONFDAHLB : KPHPJKEEOIG
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly IDGHEFJHGEI JMDJFLENGPB;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly IDGHEFJHGEI EBDELPLLLFK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IDGHEFJHGEI EGJEABLBENB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override IDGHEFJHGEI[] NNKKLHMJDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8626860", Offset = "0x8624E60", VA = "0x188626860", Slot = "9")]
	public override void GMBGDNHKJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86266D0", Offset = "0x8624CD0", VA = "0x1886266D0", Slot = "10")]
	public override void ENEOFGGEKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86266C0", Offset = "0x8624CC0", VA = "0x1886266C0")]
	private void BDCIDKKOAEJ(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8626690", Offset = "0x8624C90", VA = "0x188626690")]
	private void AGDAMAOPDMB(CHPJIJKJKGB KJOIOABMAMH, CHACOCKEPKK LMNKFGMNAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x86269F0", Offset = "0x8624FF0", VA = "0x1886269F0")]
	public void JGMOICDJBLG(CHPJIJKJKGB KJOIOABMAMH, MNJIBCLEONI AFBIBIIIMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8626C40", Offset = "0x8625240", VA = "0x188626C40")]
	private static IDGHEFJHGEI NPIGMAPHHIK(byte KBFPIDKMNOD)
	{
		return default(IDGHEFJHGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8626DA0", Offset = "0x86253A0", VA = "0x188626DA0")]
	public KPDONFDAHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OJDMIPJJDBJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KAEPOJDMGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings CBAEEKNFPEG;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8627670", Offset = "0x8625C70", VA = "0x188627670")]
	public static HKGLAFGIPMJ OBEIPAPGIJG([In] this HKGLAFGIPMJ OKPCNKDLIPI, CHPJIJKJKGB KJOIOABMAMH, MNJIBCLEONI AFBIBIIIMFK)
	{
		return default(HKGLAFGIPMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x86270A0", Offset = "0x86256A0", VA = "0x1886270A0")]
	public static HKGLAFGIPMJ LPBINIPDLDA([In] this HKGLAFGIPMJ OKPCNKDLIPI, CHPJIJKJKGB KJOIOABMAMH)
	{
		return default(HKGLAFGIPMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8628AA0", Offset = "0x86270A0", VA = "0x188628AA0")]
	public static string PBHMCKHDFHD(CHPJIJKJKGB KJOIOABMAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8627410", Offset = "0x8625A10", VA = "0x188627410")]
	public static string MPCOMDAGEFG(CHPJIJKJKGB KJOIOABMAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8628910", Offset = "0x8626F10", VA = "0x188628910")]
	public static string OIDDNAIGIKD(CHPJIJKJKGB KJOIOABMAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8627010", Offset = "0x8625610", VA = "0x188627010")]
	[CompilerGenerated]
	internal static bool JLKAFOLNDDA([Out] string CENCPMGPALN, KAEPOJDMGHI P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86287A0", Offset = "0x8626DA0", VA = "0x1886287A0")]
	[CompilerGenerated]
	internal static bool ODDNBNNNGPE([Out] string CENCPMGPALN, KAEPOJDMGHI P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CMLEPANJLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CMLEPANJLDE()
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
