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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84CB390", Offset = "0x84C9D90", VA = "0x1884CB390", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2349C00", Offset = "0x2348600", VA = "0x182349C00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84CC5A0", Offset = "0x84CAFA0", VA = "0x1884CC5A0")]
		private void JKAPILFGJLE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84CC280", Offset = "0x84CAC80", VA = "0x1884CC280")]
		private void BEAEGHPCFKG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84CC980", Offset = "0x84CB380", VA = "0x1884CC980", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84CCA30", Offset = "0x84CB430", VA = "0x1884CCA30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(OOHBKIHOIDE), new string[] { "Photon" })]
public class MDCHKPHDBHN : OOHBKIHOIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class HKADOLLJFBO : FEDJPCMCMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NDGFICGAFID EOOLELFGEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode BBPDHEABJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public PCICNODNJJA HPAHHELMNIM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KGFDMHCLJEN MMPEDFAPIKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84C9550", Offset = "0x84C7F50", VA = "0x1884C9550", Slot = "4")]
			get
			{
				return default(KGFDMHCLJEN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IOMKCHPPNFJ GHKKOHGBCJH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x84C97B0", Offset = "0x84C81B0", VA = "0x1884C97B0", Slot = "5")]
			get
			{
				return default(IOMKCHPPNFJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MMBPHEGCEGO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84C98F0", Offset = "0x84C82F0", VA = "0x1884C98F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool EAPHHFLLFBM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84C8FE0", Offset = "0x84C79E0", VA = "0x1884C8FE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84C91A0", Offset = "0x84C7BA0", VA = "0x1884C91A0", Slot = "8")]
		public object EMLJCHLDAPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84C8CF0", Offset = "0x84C76F0", VA = "0x1884C8CF0", Slot = "9")]
		private (IOMKCHPPNFJ, Dictionary<object, object>) CJFLJODPMGG()
		{
			return default((IOMKCHPPNFJ, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84C9800", Offset = "0x84C8200", VA = "0x1884C9800", Slot = "10")]
		private (GLONLLNEBOJ, IOMKCHPPNFJ) MIMANHJNOCF()
		{
			return default((GLONLLNEBOJ, IOMKCHPPNFJ));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84C9420", Offset = "0x84C7E20", VA = "0x1884C9420", Slot = "11")]
		private MPIEEGKHNJN<(GLONLLNEBOJ, IOMKCHPPNFJ)> HOJPMPJJOCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84C95A0", Offset = "0x84C7FA0", VA = "0x1884C95A0", Slot = "12")]
		private (NHCIMHIBDKO, byte[]) JLMOALHIJMD()
		{
			return default((NHCIMHIBDKO, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84C91F0", Offset = "0x84C7BF0", VA = "0x1884C91F0", Slot = "13")]
		private (CFBDNFNKFAC, byte[]) GEOAJCONONA()
		{
			return default((CFBDNFNKFAC, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43CADD0", Offset = "0x43C97D0", VA = "0x1843CADD0", Slot = "14")]
		public T GEBGILCMHBL<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84C9900", Offset = "0x84C8300", VA = "0x1884C9900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HKADOLLJFBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class PCICNODNJJA : MPIEEGKHNJN<(GLONLLNEBOJ, IOMKCHPPNFJ)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] GKIBIDMDJOE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int NOMMIDHMEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x84CBEC0", Offset = "0x84CA8C0", VA = "0x1884CBEC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (GLONLLNEBOJ view, IOMKCHPPNFJ newOwner) EFLOLIACEGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x84CBE20", Offset = "0x84CA820", VA = "0x1884CBE20", Slot = "4")]
			get
			{
				return default((GLONLLNEBOJ, IOMKCHPPNFJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PCICNODNJJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84CB4A0", Offset = "0x84C9EA0", VA = "0x1884CB4A0", Slot = "4")]
	public bool NGIANNPEOKC(object GPCDCFCPGFK, FEDJPCMCMDH IPJMLGAMPFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MDCHKPHDBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class OKLDEHGKOOI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(ILLBNLMOHMC))]
[RegisterService(typeof(KFLEGKIAMCI), new string[] { "Photon" })]
public class ILLBNLMOHMC : JHNMFGKPECO, IHGALBNHBLD, KFLEGKIAMCI, ELBBPAKODBM, MOJJPNLDPDK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private OGANHOKMKGA KPICELCLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private NFIDLDGKMNC BKHJKPMIHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable FNPCEKCMMCN;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84C9C50", Offset = "0x84C8650", VA = "0x1884C9C50", Slot = "4")]
	public void InitReferences(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84CA230", Offset = "0x84C8C30", VA = "0x1884CA230", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84C9ED0", Offset = "0x84C88D0", VA = "0x1884C9ED0", Slot = "6")]
	public void MMGJGGCFJBG(CFBDNFNKFAC LNBCHJPEENA, ReadOnlySpan<byte> EEMEEFCIEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84CA0A0", Offset = "0x84C8AA0", VA = "0x1884CA0A0", Slot = "10")]
	public void NJNDOIFJODN(CFBDNFNKFAC GKKILJMLOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84C9D40", Offset = "0x84C8740", VA = "0x1884C9D40", Slot = "7")]
	public void KPMNNLPMGFJ(ReadOnlySpan<CFBDNFNKFAC> GPMBNCFHOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84C99F0", Offset = "0x84C83F0", VA = "0x1884C99F0")]
	private Hashtable BHHGNANDOCI(Hashtable LNPPHBDEDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84CA040", Offset = "0x84C8A40", VA = "0x1884CA040")]
	public void MNHMAIGAJPG(object GFNNIJMCMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84CA1C0", Offset = "0x84C8BC0", VA = "0x1884CA1C0", Slot = "8")]
	private void PJJHJIAFIHL(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xFD69A0", Offset = "0xFD53A0", VA = "0x180FD69A0", Slot = "9")]
	private void AHPLLBHAECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84CA370", Offset = "0x84C8D70", VA = "0x1884CA370")]
	public ILLBNLMOHMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::KGICNBGPMIO), new string[] { })]
internal class DMOMIJEEMCC : KJBGABKGHII, global::KGICNBGPMIO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly MEBJEIOEDLD GACDMLEAKAP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override MEBJEIOEDLD[] EIMKDAGHCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84C6D40", Offset = "0x84C5740", VA = "0x1884C6D40")]
	public DMOMIJEEMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AMGDLJJHCCC : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84C6A90", Offset = "0x84C5490", VA = "0x1884C6A90", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type AEOGKDPPBBE, MemberSerialization DCMBCNABAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84C6CA0", Offset = "0x84C56A0", VA = "0x1884C6CA0")]
	public AMGDLJJHCCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JPFJGLNKOHJ
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GGNLGAIEKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GGNLGAIEKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84C8BB0", Offset = "0x84C75B0", VA = "0x1884C8BB0")]
		internal string ACGIGKNFHIE(NDGFICGAFID eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84CB180", Offset = "0x84C9B80", VA = "0x1884CB180")]
	public static string FLKPMDEICCD(this NDGFICGAFID EOOLELFGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84CAF50", Offset = "0x84C9950", VA = "0x1884CAF50")]
	public static KGFDMHCLJEN CLKNLOMDMED(this NDGFICGAFID EOOLELFGEAP)
	{
		return default(KGFDMHCLJEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84CAA00", Offset = "0x84C9400", VA = "0x1884CAA00")]
	public static ViewId AJJPKGPJNOG(this NDGFICGAFID EOOLELFGEAP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84CB2C0", Offset = "0x84C9CC0", VA = "0x1884CB2C0")]
	public static string KFGPOACMEBF(this NDGFICGAFID EOOLELFGEAP, JsonSerializerSettings ILBMMAONKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84CB090", Offset = "0x84C9A90", VA = "0x1884CB090")]
	private static string CPMBDKCJDBD(NDGFICGAFID EOOLELFGEAP, Func<NDGFICGAFID, string> FOAIPBIEILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84CADE0", Offset = "0x84C97E0", VA = "0x1884CADE0")]
	public static string BMNFCBJCLLG(this NDGFICGAFID EOOLELFGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84CAC00", Offset = "0x84C9600", VA = "0x1884CAC00")]
	public static ViewId BHLBJHLLALO(this NDGFICGAFID EOOLELFGEAP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84CB1A0", Offset = "0x84C9BA0", VA = "0x1884CB1A0")]
	public static string IKPKOEDOLFJ(this NDGFICGAFID EOOLELFGEAP, JsonSerializerSettings ILBMMAONKLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ILPGDMNGCBB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class PHJFIOEPJJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string JAHACHJHPNK;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84CA3F0", Offset = "0x84C8DF0", VA = "0x1884CA3F0")]
	public static string PHLIOHNDIDE(KGFDMHCLJEN JBJEMPGNJPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(NIDFFPGDBBC), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class NIDFFPGDBBC : KJBGABKGHII
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly MEBJEIOEDLD BGIJLNBKLJH;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly MEBJEIOEDLD IEKMNDOKIDN;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly MEBJEIOEDLD PJLLGCCOGHA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override MEBJEIOEDLD[] EIMKDAGHCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84CB860", Offset = "0x84CA260", VA = "0x1884CB860", Slot = "9")]
	public override void FNPJNHJCKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84CB6D0", Offset = "0x84CA0D0", VA = "0x1884CB6D0", Slot = "10")]
	public override void FDGDCCMGBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84CB9F0", Offset = "0x84CA3F0", VA = "0x1884CB9F0")]
	private void HAMCNBNCAOL(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84CBA00", Offset = "0x84CA400", VA = "0x1884CBA00")]
	private void JEDBLEBCNOM(NDGFICGAFID EOOLELFGEAP, LFCPHBACBIP KAFJCIDDMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84CBA30", Offset = "0x84CA430", VA = "0x1884CBA30")]
	public void KPKFIGHNOON(NDGFICGAFID EOOLELFGEAP, CMFEIMOOLMG GNLECCHMCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84CB620", Offset = "0x84CA020", VA = "0x1884CB620")]
	private static MEBJEIOEDLD DJJAPPPIPHG(byte LKMAOFPCIGJ)
	{
		return default(MEBJEIOEDLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84CBD30", Offset = "0x84CA730", VA = "0x1884CBD30")]
	public NIDFFPGDBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EJPKLEGCPFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OIMONBODNOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings NOKEONFKADE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84C7140", Offset = "0x84C5B40", VA = "0x1884C7140")]
	public static CJCDFLLANBL FHBAINKMAPA([In] this CJCDFLLANBL KLIFLLIBPKI, NDGFICGAFID EOOLELFGEAP, CMFEIMOOLMG GNLECCHMCFG)
	{
		return default(CJCDFLLANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x84C8680", Offset = "0x84C7080", VA = "0x1884C8680")]
	public static CJCDFLLANBL OMEMHFDMLEA([In] this CJCDFLLANBL KLIFLLIBPKI, NDGFICGAFID EOOLELFGEAP)
	{
		return default(CJCDFLLANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84C6F60", Offset = "0x84C5960", VA = "0x1884C6F60")]
	public static string EOIDMPJOFAH(NDGFICGAFID EOOLELFGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84C8290", Offset = "0x84C6C90", VA = "0x1884C8290")]
	public static string HCFNPKGHAPC(NDGFICGAFID EOOLELFGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84C84F0", Offset = "0x84C6EF0", VA = "0x1884C84F0")]
	public static string JPIHMFDCBOJ(NDGFICGAFID EOOLELFGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84C8200", Offset = "0x84C6C00", VA = "0x1884C8200")]
	[CompilerGenerated]
	internal static bool GOKCFOODFGG([Out] string AEAMJGPOBKI, OIMONBODNOM P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84C6DF0", Offset = "0x84C57F0", VA = "0x1884C6DF0")]
	[CompilerGenerated]
	internal static bool BEEFECIGCKH([Out] string AEAMJGPOBKI, OIMONBODNOM P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
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
