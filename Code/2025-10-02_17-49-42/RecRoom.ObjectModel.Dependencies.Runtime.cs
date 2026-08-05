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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86C0260", Offset = "0x86BEC60", VA = "0x1886C0260", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2402EF0", Offset = "0x24018F0", VA = "0x182402EF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86C0D50", Offset = "0x86BF750", VA = "0x1886C0D50")]
		private void OFEEGALAMNF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86C0A20", Offset = "0x86BF420", VA = "0x1886C0A20")]
		private void HGLHGGKJMAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86C1130", Offset = "0x86BFB30", VA = "0x1886C1130", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86C11E0", Offset = "0x86BFBE0", VA = "0x1886C11E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(BFLHFHGIDIE), new string[] { "Photon" })]
public class OFDBPGGBHAK : BFLHFHGIDIE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class CFDNJKGEBPK : GKNNEPJOJPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PJCAKALKNLJ PPGGMEFFGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode PEDBJGAHGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public MHJIGONPAGO BDPMJANBJAG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HFHEMOKAFOI EMHLKEMKMPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x86BDBE0", Offset = "0x86BC5E0", VA = "0x1886BDBE0", Slot = "4")]
			get
			{
				return default(HFHEMOKAFOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AFPDBFALGFB HFGLGEFIHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x86BDC30", Offset = "0x86BC630", VA = "0x1886BDC30", Slot = "5")]
			get
			{
				return default(AFPDBFALGFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CPPNOPIMKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x86BD170", Offset = "0x86BBB70", VA = "0x1886BD170", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool NCHMFLKLKDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x86BD3D0", Offset = "0x86BBDD0", VA = "0x1886BD3D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86BD310", Offset = "0x86BBD10", VA = "0x1886BD310", Slot = "9")]
		public bool DEEPOPOLIPJ([Out] AFPDBFALGFB MGCNNJFGDGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86BD120", Offset = "0x86BBB20", VA = "0x1886BD120", Slot = "8")]
		public object AKOLJKPKNKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86BD180", Offset = "0x86BBB80", VA = "0x1886BD180", Slot = "10")]
		private (AFPDBFALGFB, object) CELODEMPIFE()
		{
			return default((AFPDBFALGFB, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86BD590", Offset = "0x86BBF90", VA = "0x1886BD590", Slot = "11")]
		private (ECANCCLIJHJ, AFPDBFALGFB) IDCNCENFHHP()
		{
			return default((ECANCCLIJHJ, AFPDBFALGFB));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86BD890", Offset = "0x86BC290", VA = "0x1886BD890", Slot = "12")]
		private CLBJGHNHEJF<(ECANCCLIJHJ, AFPDBFALGFB)> IFCKHFNCEAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86BD680", Offset = "0x86BC080", VA = "0x1886BD680", Slot = "13")]
		private (LPMIJHKPLOD, byte[]) IDKGGPLMKEJ()
		{
			return default((LPMIJHKPLOD, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86BD9C0", Offset = "0x86BC3C0", VA = "0x1886BD9C0", Slot = "14")]
		private (NDMAOCGGLIO, byte[]) IKOCGIAKGJB()
		{
			return default((NDMAOCGGLIO, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44BCF30", Offset = "0x44BB930", VA = "0x1844BCF30", Slot = "15")]
		public T JDDBDJNKGAN<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86BDC80", Offset = "0x86BC680", VA = "0x1886BDC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CFDNJKGEBPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class MHJIGONPAGO : CLBJGHNHEJF<(ECANCCLIJHJ, AFPDBFALGFB)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] JMPHHICHAIC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int EJCBNJPPPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x86C0410", Offset = "0x86BEE10", VA = "0x1886C0410", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (ECANCCLIJHJ view, AFPDBFALGFB newOwner) PCCJLFHFGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x86C0370", Offset = "0x86BED70", VA = "0x1886C0370", Slot = "4")]
			get
			{
				return default((ECANCCLIJHJ, AFPDBFALGFB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MHJIGONPAGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86C0570", Offset = "0x86BEF70", VA = "0x1886C0570", Slot = "4")]
	public bool AJEKELLDDGL(object BLPDDGCLNPE, GKNNEPJOJPO IEDCIMCKGGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OFDBPGGBHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class GELMJEDBEFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(KDKGFMGECMA))]
[RegisterService(typeof(CGKJIOJBFKF), new string[] { "Photon" })]
public class KDKGFMGECMA : BOHILICPPOJ, NIPGEDOBAJA, CGKJIOJBFKF, PEEGHCFEFBD, EMJENJLEJEA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private FDONBJOCPAM FDFGEPPACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private CODMDJKLCKF NLKBGIDJALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable PIBAONGDHJH;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86BF200", Offset = "0x86BDC00", VA = "0x1886BF200", Slot = "4")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86BF720", Offset = "0x86BE120", VA = "0x1886BF720", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86BF2F0", Offset = "0x86BDCF0", VA = "0x1886BF2F0", Slot = "6")]
	public void LGCHHECHBMH(NDMAOCGGLIO HPFHOBCPNEF, ReadOnlySpan<byte> IHHGLEDNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86BEF50", Offset = "0x86BD950", VA = "0x1886BEF50", Slot = "10")]
	public void GKDIJENIGHJ(NDMAOCGGLIO AKPNOCAICGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86BF070", Offset = "0x86BDA70", VA = "0x1886BF070", Slot = "7")]
	public void HIIPHBHEFIC(ReadOnlySpan<NDMAOCGGLIO> NPBJICOIAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x86BF460", Offset = "0x86BDE60", VA = "0x1886BF460")]
	private Hashtable PCIAEHLHOII(Hashtable LCPJKFCKMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x86BF6C0", Offset = "0x86BE0C0", VA = "0x1886BF6C0")]
	public void PKMPDMLOBCO(object DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86BEEE0", Offset = "0x86BD8E0", VA = "0x1886BEEE0", Slot = "8")]
	private void EBAJCGMAKEG(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1041A60", Offset = "0x1040460", VA = "0x181041A60", Slot = "9")]
	private void DFFGDBKCJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86BF860", Offset = "0x86BE260", VA = "0x1886BF860")]
	public KDKGFMGECMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::JIPFEOPAGLL), new string[] { })]
internal class GALOPGBFDJE : HOOKBBNIKMG, global::JIPFEOPAGLL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly OLFEOKKCIEG HKAIOBBCBGO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override OLFEOKKCIEG[] APNOHBDOKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x86BEE30", Offset = "0x86BD830", VA = "0x1886BEE30")]
	public GALOPGBFDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EJPIMPOMGBB : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x86BE570", Offset = "0x86BCF70", VA = "0x1886BE570", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type DGNODDPLLPC, MemberSerialization JJEPMGCPALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86BE780", Offset = "0x86BD180", VA = "0x1886BE780")]
	public EJPIMPOMGBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LOBBKBNJONE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NPGOBEHLIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NPGOBEHLIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86C0430", Offset = "0x86BEE30", VA = "0x1886C0430")]
		internal string MAIGODHBFLO(PJCAKALKNLJ eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86BF9B0", Offset = "0x86BE3B0", VA = "0x1886BF9B0")]
	public static string DDIACBDPOAO(this PJCAKALKNLJ PPGGMEFFGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x86BF9D0", Offset = "0x86BE3D0", VA = "0x1886BF9D0")]
	public static HFHEMOKAFOI HJJMMBDOHBI(this PJCAKALKNLJ PPGGMEFFGDH)
	{
		return default(HFHEMOKAFOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86BFDD0", Offset = "0x86BE7D0", VA = "0x1886BFDD0")]
	public static ViewId NGHMOJDCFEE(this PJCAKALKNLJ PPGGMEFFGDH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86BF8E0", Offset = "0x86BE2E0", VA = "0x1886BF8E0")]
	public static string CFHCMJDHLPH(this PJCAKALKNLJ PPGGMEFFGDH, JsonSerializerSettings PFBBIKMMODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86BFCE0", Offset = "0x86BE6E0", VA = "0x1886BFCE0")]
	private static string MJMMPAHDMPD(PJCAKALKNLJ PPGGMEFFGDH, Func<PJCAKALKNLJ, string> FCCCPABHDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86BFFD0", Offset = "0x86BE9D0", VA = "0x1886BFFD0")]
	public static string NKJEKEKNBDD(this PJCAKALKNLJ PPGGMEFFGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86BFB10", Offset = "0x86BE510", VA = "0x1886BFB10")]
	public static ViewId IPAAOHJBLEE(this PJCAKALKNLJ PPGGMEFFGDH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86C0140", Offset = "0x86BEB40", VA = "0x1886C0140")]
	public static string OBLIBJNNGGH(this PJCAKALKNLJ PPGGMEFFGDH, JsonSerializerSettings PFBBIKMMODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EOGGMJNHOIL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class CBKNOEJEJDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string BFPLOHOCBOL;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86BE7D0", Offset = "0x86BD1D0", VA = "0x1886BE7D0")]
	public static string MFOGMBJHLAF(HFHEMOKAFOI DMJFIGMGCMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(DBACJPOEPGI), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class DBACJPOEPGI : HOOKBBNIKMG
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly OLFEOKKCIEG IHIDLMDHEGI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly OLFEOKKCIEG MCCOKGCBBCL;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly OLFEOKKCIEG GBGIAGNKBAA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override OLFEOKKCIEG[] APNOHBDOKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86BE240", Offset = "0x86BCC40", VA = "0x1886BE240", Slot = "9")]
	public override void HCIJLAOPINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86BDD70", Offset = "0x86BC770", VA = "0x1886BDD70", Slot = "10")]
	public override void AFEHIMDIEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x86BDF00", Offset = "0x86BC900", VA = "0x1886BDF00")]
	private void ANJOBEEMHPH(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x86BDFC0", Offset = "0x86BC9C0", VA = "0x1886BDFC0")]
	private void COCMBGCHIJD(PJCAKALKNLJ PPGGMEFFGDH, LAAOOMKIIJB IAJLLBCOKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86BDFF0", Offset = "0x86BC9F0", VA = "0x1886BDFF0")]
	public void EGNLNNFKHNJ(PJCAKALKNLJ PPGGMEFFGDH, IFKDCDHMMHL LLPEKLNNPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86BDF10", Offset = "0x86BC910", VA = "0x1886BDF10")]
	private static OLFEOKKCIEG CHLFOMBAEEP(byte DDFEAKLIDDG)
	{
		return default(OLFEOKKCIEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86BE480", Offset = "0x86BCE80", VA = "0x1886BE480")]
	public DBACJPOEPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BKCMMCMMLOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CLCCBIHHHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings OLIJHPEDDKA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x86BB3F0", Offset = "0x86B9DF0", VA = "0x1886BB3F0")]
	public static HFEMCIEBCBE CMBIKKIBJNO([In] this HFEMCIEBCBE BHNDPEOGHGG, PJCAKALKNLJ PPGGMEFFGDH, IFKDCDHMMHL LLPEKLNNPPE)
	{
		return default(HFEMCIEBCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86BC960", Offset = "0x86BB360", VA = "0x1886BC960")]
	public static HFEMCIEBCBE HLPLBHIBPCA([In] this HFEMCIEBCBE BHNDPEOGHGG, PJCAKALKNLJ PPGGMEFFGDH)
	{
		return default(HFEMCIEBCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86BC520", Offset = "0x86BAF20", VA = "0x1886BC520")]
	public static string DAALKMPPPPD(PJCAKALKNLJ PPGGMEFFGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x86BC700", Offset = "0x86BB100", VA = "0x1886BC700")]
	public static string FMLANHMGGNL(PJCAKALKNLJ PPGGMEFFGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x86BCD50", Offset = "0x86BB750", VA = "0x1886BCD50")]
	public static string IKLKOCGPOBB(PJCAKALKNLJ PPGGMEFFGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86BCCC0", Offset = "0x86BB6C0", VA = "0x1886BCCC0")]
	[CompilerGenerated]
	internal static bool IDHINIACDBC([Out] string GGIKEMCHAAA, CLCCBIHHHBI P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x86BB280", Offset = "0x86B9C80", VA = "0x1886BB280")]
	[CompilerGenerated]
	internal static bool AJFNLIICNJI([Out] string GGIKEMCHAAA, CLCCBIHHHBI P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
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
