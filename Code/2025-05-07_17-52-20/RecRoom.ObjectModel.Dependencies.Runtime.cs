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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD5F0", Offset = "0x7DDC5F0", VA = "0x187DDD5F0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B94F80", Offset = "0x7B93F80", VA = "0x187B94F80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DDEA20", Offset = "0x7DDDA20", VA = "0x187DDEA20")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE700", Offset = "0x7DDD700", VA = "0x187DDE700")]
		private void KMFPJCIAGGA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DDEE00", Offset = "0x7DDDE00", VA = "0x187DDEE00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DDEEB0", Offset = "0x7DDDEB0", VA = "0x187DDEEB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(FHPIJCIIFKO), new string[] { "Photon" })]
public class EFICFCKKIPM : FHPIJCIIFKO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class OCDDEBOGMDH : CEADAKHMIIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public EventData NKBJHKLGFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode FOOMEOJAJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public GFPECLGBMNH AHFBFJLAKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public OGHCOBDBBIN PKLEEKLJNAB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PMGMMGGAAPO KFIKOGBAHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7DDDC30", Offset = "0x7DDCC30", VA = "0x187DDDC30", Slot = "4")]
			get
			{
				return default(PMGMMGGAAPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AEMMHEJJEHA FACMAKELJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7DDD700", Offset = "0x7DDC700", VA = "0x187DDD700", Slot = "5")]
			get
			{
				return default(AEMMHEJJEHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JHEKIIEFEMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7DDD720", Offset = "0x7DDC720", VA = "0x187DDD720", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool MBLJOBEFPKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7DDDAC0", Offset = "0x7DDCAC0", VA = "0x187DDDAC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDC50", Offset = "0x7DDCC50", VA = "0x187DDDC50", Slot = "8")]
		private (AEMMHEJJEHA, Dictionary<object, object>) JIBHAOJPCOF()
		{
			return default((AEMMHEJJEHA, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDED0", Offset = "0x7DDCED0", VA = "0x187DDDED0", Slot = "9")]
		private (JOKHKLAANOK, AEMMHEJJEHA) PECMDADJBNP()
		{
			return default((JOKHKLAANOK, AEMMHEJJEHA));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDDB0", Offset = "0x7DDCDB0", VA = "0x187DDDDB0", Slot = "10")]
		private MLEJCHELJGC<(JOKHKLAANOK, AEMMHEJJEHA)> LFEACMHDMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD950", Offset = "0x7DDC950", VA = "0x187DDD950", Slot = "11")]
		private MLEJCHELJGC<PLIPCGIFLFP> FIKMBECIJMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDFA0", Offset = "0x7DDCFA0", VA = "0x187DDDFA0", Slot = "12")]
		private (JJHDADELCNN, byte[]) PONBBBEPJKI()
		{
			return default((JJHDADELCNN, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD730", Offset = "0x7DDC730", VA = "0x187DDD730", Slot = "13")]
		private (NAKHDIPHEPO, byte[]) DHODOMCPELN()
		{
			return default((NAKHDIPHEPO, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDD30", Offset = "0x3EDCD30", VA = "0x183EDDD30", Slot = "14")]
		public T PGKJJBBGDIO<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE1A0", Offset = "0x7DDD1A0", VA = "0x187DDE1A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OCDDEBOGMDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class GFPECLGBMNH : MLEJCHELJGC<(JOKHKLAANOK, AEMMHEJJEHA)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int[] FOOCPKJGLIL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JPLLFCIDPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7DDC780", Offset = "0x7DDB780", VA = "0x187DDC780", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (JOKHKLAANOK view, AEMMHEJJEHA newOwner) OEMFNNCKNFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7DDC6E0", Offset = "0x7DDB6E0", VA = "0x187DDC6E0", Slot = "4")]
			get
			{
				return default((JOKHKLAANOK, AEMMHEJJEHA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GFPECLGBMNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DefaultMember("Item")]
	private class OGHCOBDBBIN : MLEJCHELJGC<PLIPCGIFLFP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public object[] FOOCPKJGLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public BHGMBDOAGID EJFGHOICPEP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int JPLLFCIDPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7DDE360", Offset = "0x7DDD360", VA = "0x187DDE360", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PLIPCGIFLFP OEMFNNCKNFG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7DDE250", Offset = "0x7DDD250", VA = "0x187DDE250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE380", Offset = "0x7DDD380", VA = "0x187DDE380")]
		public OGHCOBDBBIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DefaultMember("Item")]
	private class BHGMBDOAGID : PLIPCGIFLFP, MLEJCHELJGC<ABBHPHKIIPL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JOKHKLAANOK CEDMGFDCANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public object[] DHLGAIMCINE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JOKHKLAANOK DJFLGABMOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0", Slot = "4")]
			get
			{
				return default(JOKHKLAANOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int JPLLFCIDPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7DDA2C0", Offset = "0x7DD92C0", VA = "0x187DDA2C0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ABBHPHKIIPL OEMFNNCKNFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7DDA200", Offset = "0x7DD9200", VA = "0x187DDA200", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BHGMBDOAGID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA2E0", Offset = "0x7DD92E0", VA = "0x187DDA2E0", Slot = "4")]
	public bool HBGMKAEOAKP(object APDBNIMCPID, CEADAKHMIIO DJCKCBEAICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public EFICFCKKIPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class NEAGMAKILNN
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(DCIIAEEBHIA), new string[] { "Photon" })]
[AlsoBindServiceAs(typeof(IKMMOJKDOIA))]
public class IKMMOJKDOIA : PNPJOMLIBJD, EECMODLKMOH, DCIIAEEBHIA, ECADACCIMBA, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[DependsOn]
	private DONCFGGANJP JDPKJPILGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[DependsOn]
	private PLADEJNHEJL IPLPPMJAAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Hashtable FBEFHOGBKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCD90", Offset = "0x7DDBD90", VA = "0x187DDCD90", Slot = "4")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCA70", Offset = "0x7DDBA70", VA = "0x187DDCA70", Slot = "5")]
	public void BAOPLEDIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD0E0", Offset = "0x7DDC0E0", VA = "0x187DDD0E0", Slot = "6")]
	public void OFMEIPHEHKH(NAKHDIPHEPO OEHHKNIGGMI, ReadOnlySpan<byte> DGHLABNPIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCFC0", Offset = "0x7DDBFC0", VA = "0x187DDCFC0", Slot = "11")]
	public void NPLJIMPLMPL(NAKHDIPHEPO IJCHNJDOMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCE30", Offset = "0x7DDBE30", VA = "0x187DDCE30", Slot = "7")]
	public void JBDAPJANMNN(ReadOnlySpan<NAKHDIPHEPO> BABFMBLDKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCB30", Offset = "0x7DDBB30", VA = "0x187DDCB30")]
	private Hashtable DIMHKPHIIIJ(Hashtable PIDJHJKLGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD250", Offset = "0x7DDC250", VA = "0x187DDD250", Slot = "8")]
	public void OnEvent(EventData NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCAC0", Offset = "0x7DDBAC0", VA = "0x187DDCAC0", Slot = "9")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1151D80", Offset = "0x1150D80", VA = "0x181151D80", Slot = "10")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD340", Offset = "0x7DDC340", VA = "0x187DDD340")]
	public IKMMOJKDOIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[RegisterService(typeof(global::HLOFNANLBJP), new string[] { })]
internal class JNMGHMJLPBB : GIFGBLHKBOK, global::HLOFNANLBJP
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly JBBHIJHGEPM PAMLFPGMJBA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	protected override JBBHIJHGEPM[] EBMKHFHPPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD540", Offset = "0x7DDC540", VA = "0x187DDD540")]
	public JNMGHMJLPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GKFGOPLKNHK : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC7A0", Offset = "0x7DDB7A0", VA = "0x187DDC7A0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type MLCOGCMJLBB, MemberSerialization FJABLLNLINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC9B0", Offset = "0x7DDB9B0", VA = "0x187DDC9B0")]
	public GKFGOPLKNHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AEFHHKMNABC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class HAMFNGADLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static string HEMHGIDMDHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JJOMCFDCNGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JJOMCFDCNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD3C0", Offset = "0x7DDC3C0", VA = "0x187DDD3C0")]
		internal string LBECLCGFDCL(EventData eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA1E0", Offset = "0x7DD91E0", VA = "0x187DDA1E0")]
	public static string NGPCLDOEEOD(this EventData NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7DD98A0", Offset = "0x7DD88A0", VA = "0x187DD98A0")]
	public static PMGMMGGAAPO FICALAGANPO(this EventData NKBJHKLGFDP)
	{
		return default(PMGMMGGAAPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9AC0", Offset = "0x7DD8AC0", VA = "0x187DD9AC0")]
	public static string HNFOPDGEGFG(PMGMMGGAAPO OGKCOMEHLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9320", Offset = "0x7DD8320", VA = "0x187DD9320")]
	public static string CLPFOLJMEGI(this EventData NKBJHKLGFDP, JsonSerializerSettings OPLIANKAEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9600", Offset = "0x7DD8600", VA = "0x187DD9600")]
	public static ViewId EDDPEJNHFCJ(this EventData NKBJHKLGFDP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9950", Offset = "0x7DD8950", VA = "0x187DD9950")]
	public static string FMLKFIJNHDC(this EventData NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9440", Offset = "0x7DD8440", VA = "0x187DD9440")]
	public static ViewId DIJDDHMPNPH(this EventData NKBJHKLGFDP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD97D0", Offset = "0x7DD87D0", VA = "0x187DD97D0")]
	public static string EDGOEPMDBKM(this EventData NKBJHKLGFDP, JsonSerializerSettings OPLIANKAEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA0F0", Offset = "0x7DD90F0", VA = "0x187DDA0F0")]
	private static string MHBHJODGEAJ(EventData NKBJHKLGFDP, Func<EventData, string> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(FOPPGCGLICP), new string[] { })]
internal class FOPPGCGLICP : GIFGBLHKBOK, ECADACCIMBA, BGLGDLNFKOF
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly JBBHIJHGEPM EPPEKNOFEFD;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly JBBHIJHGEPM EHAFLPKEMFC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly JBBHIJHGEPM GEFKLDEGOML;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override JBBHIJHGEPM[] EBMKHFHPPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC1D0", Offset = "0x7DDB1D0", VA = "0x187DDC1D0", Slot = "9")]
	public override void JAINDIDLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC4B0", Offset = "0x7DDB4B0", VA = "0x187DDC4B0", Slot = "10")]
	public override void OIABCBMEMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC1C0", Offset = "0x7DDB1C0", VA = "0x187DDC1C0", Slot = "11")]
	private void CJDJGNIFAKM(EventData NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC480", Offset = "0x7DDB480", VA = "0x187DDC480", Slot = "12")]
	private void LEIOBDDNPDJ(EventData NKBJHKLGFDP, LNHCHEGJGAC BPOCFKJCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC480", Offset = "0x7DDB480", VA = "0x187DDC480")]
	private void NEJMJJLHGLJ(EventData NKBJHKLGFDP, LNHCHEGJGAC BPOCFKJCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC260", Offset = "0x7DDB260", VA = "0x187DDC260")]
	public void LAHMHNDHIIJ(EventData NKBJHKLGFDP, DAFDNPPDPPJ KCFPPIHNKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC0F0", Offset = "0x7DDB0F0", VA = "0x187DDC0F0")]
	private static JBBHIJHGEPM CEJKPKBPJMH(EventData NKBJHKLGFDP)
	{
		return default(JBBHIJHGEPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC5F0", Offset = "0x7DDB5F0", VA = "0x187DDC5F0")]
	public FOPPGCGLICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FGHCAFJKDPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct AAKCCANLDBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly JsonSerializerSettings DFEGDODJDPO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAAC0", Offset = "0x7DD9AC0", VA = "0x187DDAAC0")]
	public static HHFCBOBDKHP KOHGHAEDKGD([In] this HHFCBOBDKHP DOHIDBPJPGC, EventData NKBJHKLGFDP, DAFDNPPDPPJ KCFPPIHNKCA)
	{
		return default(HHFCBOBDKHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBBD0", Offset = "0x7DDABD0", VA = "0x187DDBBD0")]
	public static HHFCBOBDKHP PMJGDAOKBEE([In] this HHFCBOBDKHP DOHIDBPJPGC, EventData NKBJHKLGFDP)
	{
		return default(HHFCBOBDKHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA490", Offset = "0x7DD9490", VA = "0x187DDA490")]
	public static string CNLKIBHPMAF(EventData NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA6F0", Offset = "0x7DD96F0", VA = "0x187DDA6F0")]
	public static string HBOJDKLHEDN(EventData NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA940", Offset = "0x7DD9940", VA = "0x187DDA940")]
	public static string HFMGEFIKNCH(EventData NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA660", Offset = "0x7DD9660", VA = "0x187DDA660")]
	[CompilerGenerated]
	internal static bool EPKNNJHOKJO([Out] string OBOOAPELMPF, AAKCCANLDBP P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBA60", Offset = "0x7DDAA60", VA = "0x187DDBA60")]
	[CompilerGenerated]
	internal static bool MACHCKDCODE([Out] string OBOOAPELMPF, AAKCCANLDBP P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPHBBBBMJHN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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
