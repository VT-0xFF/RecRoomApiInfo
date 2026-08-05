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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x815CD60", Offset = "0x815B560", VA = "0x18815CD60", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21579F0", Offset = "0x21561F0", VA = "0x1821579F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x815D750", Offset = "0x815BF50", VA = "0x18815D750")]
		private void MBKOFANELHN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x815D430", Offset = "0x815BC30", VA = "0x18815D430")]
		private void EDNGKHAEMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x815DB20", Offset = "0x815C320", VA = "0x18815DB20", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x815DBD0", Offset = "0x815C3D0", VA = "0x18815DBD0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(KFPGIMDDCCE), new string[] { "Photon" })]
public class PJFCCLGPDHB : KFPGIMDDCCE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class GEEBGOPLLLO : LHOHOFLFMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public IIBEMPIBOEO NPLHFNMEMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode OICGLDEJEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public JNIPBBOHLME CBMABLKKAPL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PCIFKHJOCMO PBNBGAHIAOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x81584C0", Offset = "0x8156CC0", VA = "0x1881584C0", Slot = "4")]
			get
			{
				return default(PCIFKHJOCMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GBNNBLFIGLH DGFEGJFLMJP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8158D70", Offset = "0x8157570", VA = "0x188158D70", Slot = "5")]
			get
			{
				return default(GBNNBLFIGLH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EPPBJKFNNGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x81584B0", Offset = "0x8156CB0", VA = "0x1881584B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool BJCMHNBDBCL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8158EF0", Offset = "0x81576F0", VA = "0x188158EF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8158800", Offset = "0x8157000", VA = "0x188158800", Slot = "8")]
		public object IJLKEIOJLMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8158510", Offset = "0x8156D10", VA = "0x188158510", Slot = "9")]
		private (GBNNBLFIGLH, Dictionary<object, object>) GHALFIGMLGP()
		{
			return default((GBNNBLFIGLH, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8158C80", Offset = "0x8157480", VA = "0x188158C80", Slot = "10")]
		private (JKKCHPONOAD, GBNNBLFIGLH) MENMLOCKNOB()
		{
			return default((JKKCHPONOAD, GBNNBLFIGLH));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8158DC0", Offset = "0x81575C0", VA = "0x188158DC0", Slot = "11")]
		private AHCMFJODPGC<(JKKCHPONOAD, GBNNBLFIGLH)> NNGALBKAFGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8158A70", Offset = "0x8157270", VA = "0x188158A70", Slot = "12")]
		private (MKLLDEMFALJ, byte[]) JMELFAFHJBC()
		{
			return default((MKLLDEMFALJ, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8158850", Offset = "0x8157050", VA = "0x188158850", Slot = "13")]
		private (MNJLPECGPEL, byte[]) IPDKODPJIEC()
		{
			return default((MNJLPECGPEL, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x414F390", Offset = "0x414DB90", VA = "0x18414F390", Slot = "14")]
		public T LMBCPEKNFIC<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81590B0", Offset = "0x81578B0", VA = "0x1881590B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GEEBGOPLLLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class JNIPBBOHLME : AHCMFJODPGC<(JKKCHPONOAD, GBNNBLFIGLH)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] FIOLEJMGMON;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int FFBDFGAGHML
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x815B850", Offset = "0x815A050", VA = "0x18815B850", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (JKKCHPONOAD view, GBNNBLFIGLH newOwner) NOJAFKJLFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x815B870", Offset = "0x815A070", VA = "0x18815B870", Slot = "4")]
			get
			{
				return default((JKKCHPONOAD, GBNNBLFIGLH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JNIPBBOHLME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x815CFB0", Offset = "0x815B7B0", VA = "0x18815CFB0", Slot = "4")]
	public bool MGMJPBJPHJO(object IMINNNCPCJF, LHOHOFLFMIN ODJFDEMIFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PJFCCLGPDHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class KAKNPMGJMOD
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(LKGNGOAEPLL))]
[RegisterService(typeof(DLBGDMFAPFF), new string[] { "Photon" })]
public class LKGNGOAEPLL : FHLMMIDFMKJ, GOCAAFFABHB, DLBGDMFAPFF, JCLLOKFPFOL, FFGPMFMFIPE
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private DDAIBCKBNKJ DLJGBAKBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private CABKADLKCMC BHPNCPMMJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable JKBGANBHBMG;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x815C5E0", Offset = "0x815ADE0", VA = "0x18815C5E0", Slot = "4")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x815CB50", Offset = "0x815B350", VA = "0x18815CB50", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x815C6D0", Offset = "0x815AED0", VA = "0x18815C6D0", Slot = "6")]
	public void PEHGFJLKEEN(MNJLPECGPEL MNMCNOJCKAF, ReadOnlySpan<byte> OILJBDLKBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x815CA30", Offset = "0x815B230", VA = "0x18815CA30", Slot = "10")]
	public void PNAKILKFIJA(MNJLPECGPEL MFPAJAAINNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x815C8A0", Offset = "0x815B0A0", VA = "0x18815C8A0", Slot = "7")]
	public void PJBDLOOIJIL(ReadOnlySpan<MNJLPECGPEL> IMBBBHENFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x815C380", Offset = "0x815AB80", VA = "0x18815C380")]
	private Hashtable GKFMMGFNAMM(Hashtable PEFMEJODBJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x815C840", Offset = "0x815B040", VA = "0x18815C840")]
	public void PEJPCFBEJFL(object CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x815C310", Offset = "0x815AB10", VA = "0x18815C310", Slot = "8")]
	private void DJHOLMKIEEJ(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11EBD20", Offset = "0x11EA520", VA = "0x1811EBD20", Slot = "9")]
	private void BFECBMINEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x815CC80", Offset = "0x815B480", VA = "0x18815CC80")]
	public LKGNGOAEPLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::KGHOOCONDOI), new string[] { })]
internal class FFKBBGGEFDM : LAHHNADODDJ, global::KGHOOCONDOI
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly BMELPJIFPCL PHEFAJKBLLI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override BMELPJIFPCL[] MLDMCIBIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8158400", Offset = "0x8156C00", VA = "0x188158400")]
	public FFKBBGGEFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KDFIGCKGAHE : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x815C0C0", Offset = "0x815A8C0", VA = "0x18815C0C0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type CEPGAJKBPDM, MemberSerialization ADACOHLIDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x815C2C0", Offset = "0x815AAC0", VA = "0x18815C2C0")]
	public KDFIGCKGAHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HGNDELMFOJG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ODENAOKBKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ODENAOKBKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x815CE70", Offset = "0x815B670", VA = "0x18815CE70")]
		internal string KAMMIPGGLHF(IIBEMPIBOEO eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x815AED0", Offset = "0x81596D0", VA = "0x18815AED0")]
	public static string AILOHNGGJFG(this IIBEMPIBOEO NPLHFNMEMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x815B210", Offset = "0x8159A10", VA = "0x18815B210")]
	public static PCIFKHJOCMO DHBCHLILMPM(this IIBEMPIBOEO NPLHFNMEMBD)
	{
		return default(PCIFKHJOCMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x815B010", Offset = "0x8159810", VA = "0x18815B010")]
	public static ViewId CKHHFJPHCGB(this IIBEMPIBOEO NPLHFNMEMBD)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x815B5B0", Offset = "0x8159DB0", VA = "0x18815B5B0")]
	public static string MDFFHPPHDMH(this IIBEMPIBOEO NPLHFNMEMBD, JsonSerializerSettings CAOIDKPANBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x815B350", Offset = "0x8159B50", VA = "0x18815B350")]
	private static string ICCEEKMAFML(IIBEMPIBOEO NPLHFNMEMBD, Func<IIBEMPIBOEO, string> AMNCPNDDCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x815B440", Offset = "0x8159C40", VA = "0x18815B440")]
	public static string IDIFNMKJIBB(this IIBEMPIBOEO NPLHFNMEMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x815B680", Offset = "0x8159E80", VA = "0x18815B680")]
	public static ViewId NDGJGGDIPHB(this IIBEMPIBOEO NPLHFNMEMBD)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x815AEF0", Offset = "0x81596F0", VA = "0x18815AEF0")]
	public static string BFEKKJPMAMF(this IIBEMPIBOEO NPLHFNMEMBD, JsonSerializerSettings CAOIDKPANBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BLDFADBILBB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class LPODBFALEIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string FAADMHJJKKF;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8157DA0", Offset = "0x81565A0", VA = "0x188157DA0")]
	public static string CHPKNMCCMBK(PCIFKHJOCMO IDIIIALCIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(KAAEOALAPHM), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class KAAEOALAPHM : LAHHNADODDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly BMELPJIFPCL HOLPGGFFJPH;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly BMELPJIFPCL BLJFDALOFNC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly BMELPJIFPCL ONJNFABMPGP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override BMELPJIFPCL[] MLDMCIBIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x815BDC0", Offset = "0x815A5C0", VA = "0x18815BDC0", Slot = "9")]
	public override void PFGBIFMDMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x815BB50", Offset = "0x815A350", VA = "0x18815BB50", Slot = "10")]
	public override void FBMIFNPDOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x815BDB0", Offset = "0x815A5B0", VA = "0x18815BDB0")]
	private void OJAIAJNBBGD(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x815BD80", Offset = "0x815A580", VA = "0x18815BD80")]
	private void GFJMIADNDDL(IIBEMPIBOEO NPLHFNMEMBD, IKNIODLHFBI OLAJFDBFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x815B910", Offset = "0x815A110", VA = "0x18815B910")]
	public void BCFMNFPEHJE(IIBEMPIBOEO NPLHFNMEMBD, GCGEGJLBNPD CODEFCLPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x815BCD0", Offset = "0x815A4D0", VA = "0x18815BCD0")]
	private static BMELPJIFPCL FLMKDAIKBFF(byte EOKPMGGJEMH)
	{
		return default(BMELPJIFPCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x815BFE0", Offset = "0x815A7E0", VA = "0x18815BFE0")]
	public KAAEOALAPHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HGBIJBJJDAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HFCJIEFBLEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings MFMCHHNNCKL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8159310", Offset = "0x8157B10", VA = "0x188159310")]
	public static DCOCDKFIAPG EMIFMIFJOOD([In] this DCOCDKFIAPG GPLJMGHJPHO, IIBEMPIBOEO NPLHFNMEMBD, GCGEGJLBNPD CODEFCLPPBD)
	{
		return default(DCOCDKFIAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x815A360", Offset = "0x8158B60", VA = "0x18815A360")]
	public static DCOCDKFIAPG JJFMCENDNAA([In] this DCOCDKFIAPG GPLJMGHJPHO, IIBEMPIBOEO NPLHFNMEMBD)
	{
		return default(DCOCDKFIAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x815A910", Offset = "0x8159110", VA = "0x18815A910")]
	public static string LOAJONNEFFL(IIBEMPIBOEO NPLHFNMEMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x815A6B0", Offset = "0x8158EB0", VA = "0x18815A6B0")]
	public static string KOAEDIDLHBC(IIBEMPIBOEO NPLHFNMEMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x815AAF0", Offset = "0x81592F0", VA = "0x18815AAF0")]
	public static string MDBNCBCLAHL(IIBEMPIBOEO NPLHFNMEMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x815AC80", Offset = "0x8159480", VA = "0x18815AC80")]
	[CompilerGenerated]
	internal static bool PFCOKEDEDIC([Out] string KJCFPPKBAOB, HFCJIEFBLEJ P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81591A0", Offset = "0x81579A0", VA = "0x1881591A0")]
	[CompilerGenerated]
	internal static bool BCJNHBGPCLB([Out] string KJCFPPKBAOB, HFCJIEFBLEJ P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LBHJJCIMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LBHJJCIMPIK()
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
