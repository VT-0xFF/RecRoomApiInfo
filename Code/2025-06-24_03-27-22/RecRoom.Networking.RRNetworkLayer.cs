using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.ObjectModel;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8BC0", Offset = "0x7EF77C0", VA = "0x187EF8BC0", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_RRNetworkLayer
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

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x220C1E0", Offset = "0x220ADE0", VA = "0x18220C1E0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B2F0", Offset = "0x7F09EF0", VA = "0x187F0B2F0")]
		private void HNLBFOBJPNI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B950", Offset = "0x7F0A550", VA = "0x187F0B950")]
		private void PHGCFAENFGI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BBC0", Offset = "0x7F0A7C0", VA = "0x187F0BBC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BC70", Offset = "0x7F0A870", VA = "0x187F0BC70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGLECOBOLOG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JPIBGNDAFKP KAEEKMHMHPB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JPIBGNDAFKP HFHBCEMOCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F02600", Offset = "0x7F01200", VA = "0x187F02600")]
		get
		{
			return default(JPIBGNDAFKP);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GJADDNEGONL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView EEPDIJAKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JOJHEOLJOJA FENLDNPEEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IJFBFCFKICC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(BONOBHOAEBL PIACJOHGMNL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(EJFPGNMPAFH JGFKHBPEKHF, BONOBHOAEBL PIACJOHGMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface HHAMPAGAEDI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PCIAAHNJNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IJOGPDAMHKO(EJFPGNMPAFH JGFKHBPEKHF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBAGJKMAFHO(EJFPGNMPAFH JGFKHBPEKHF, BONOBHOAEBL PIACJOHGMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface DOHCFFCBBLI : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPGHNAFBFC(GJADDNEGONL ILGJODOAPFO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFGPHHDGACD(GJADDNEGONL ILGJODOAPFO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPAMPFHGGFK(AABOODEENBH.EIMBJENBEDD DCINLPBGPHB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPHBDMOKGOH();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBIOMGIPKNA(object AGFKEDPOHKE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JOJHEOLJOJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NetworkTransform,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	PlayerAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	FullBodyPuppetData,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AvatarSkeletonData,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	ControlDeckData,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	RCCarData,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	GroundVehicleData,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	NetworkEnemyHeadRotationData,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	DesktopScreenSharing,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	RoomieAIAudio,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GameAIAudio,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Invalid
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EJFPGNMPAFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int IBPDAEBHBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint NIEEEGEOENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public double AMIOJIAIOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int JNJNAFNOBGE;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BGBKBJFBNLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<(ViewId, JOJHEOLJOJA), HHAMPAGAEDI> OBIHMJNJCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly List<GJADDNEGONL> NCAMFKAKLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HashSet<(ViewId, JOJHEOLJOJA)> BMDNCEIIIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int EOHNHHBLLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public bool KFEPOMDHEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private AABOODEENBH.EIMBJENBEDD DCINLPBGPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MemoryStream NBKECKPEGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly BONOBHOAEBL EJEGPCMLBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly BONOBHOAEBL NIJHJDPLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private byte[] MHOAKDACPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float LEJICOECEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int LKHGEBPHHFD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB1C0", Offset = "0x7EE9DC0", VA = "0x187EEB1C0")]
	public BGBKBJFBNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9FB0", Offset = "0x7EE8BB0", VA = "0x187EE9FB0")]
	public void CPAMPFHGGFK(AABOODEENBH.EIMBJENBEDD DCINLPBGPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9F50", Offset = "0x7EE8B50", VA = "0x187EE9F50")]
	public void BPHBDMOKGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EEA8C0", Offset = "0x7EE94C0", VA = "0x187EEA8C0")]
	public void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7EEACA0", Offset = "0x7EE98A0", VA = "0x187EEACA0")]
	public bool NKAMMCABBBC(GJADDNEGONL ILGJODOAPFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EEA380", Offset = "0x7EE8F80", VA = "0x187EEA380")]
	public bool HMCNGGMNMHK(GJADDNEGONL ILGJODOAPFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9D30", Offset = "0x7EE8930", VA = "0x187EE9D30")]
	private HHAMPAGAEDI BEPGABNCNBM(ViewId AAHKEEEBFIN, JOJHEOLJOJA HKIGPNGCDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9FA0", Offset = "0x7EE8BA0", VA = "0x187EE9FA0")]
	public void CFLAOEIHPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7EEA4B0", Offset = "0x7EE90B0", VA = "0x187EEA4B0")]
	private void IPAJAGFFPKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9D10", Offset = "0x7EE8910", VA = "0x187EE9D10")]
	private void ADADGILGLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EEA510", Offset = "0x7EE9110", VA = "0x187EEA510")]
	public bool LJHIODBEPBJ(FastBufferWriter JKKEKKKNJIN, int ALFLGPJGDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9FD0", Offset = "0x7EE8BD0", VA = "0x187EE9FD0")]
	public void EBAGJKMAFHO(EJFPGNMPAFH JGFKHBPEKHF, FastBufferReader EENAIFHJAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class HBCEDMDGJJP : HHAMPAGAEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GJADDNEGONL BFHJDAGMGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private uint OLAHEIEMOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int LMBLGFKDCBA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PCIAAHNJNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public HBCEDMDGJJP(GJADDNEGONL BFHJDAGMGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2840", Offset = "0x7EF1440", VA = "0x187EF2840", Slot = "5")]
	public bool IJOGPDAMHKO(EJFPGNMPAFH JGFKHBPEKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2760", Offset = "0x7EF1360", VA = "0x187EF2760", Slot = "6")]
	public void EBAGJKMAFHO(EJFPGNMPAFH JGFKHBPEKHF, BONOBHOAEBL PIACJOHGMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CLPIBPIKPGJ : HHAMPAGAEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private AABOODEENBH.EIMBJENBEDD DCINLPBGPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ViewId AAHKEEEBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int LMBLGFKDCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private uint OLAHEIEMOOP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PCIAAHNJNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1AFE160", Offset = "0x1AFCD60", VA = "0x181AFE160")]
	public CLPIBPIKPGJ(ViewId AAHKEEEBFIN, AABOODEENBH.EIMBJENBEDD DCINLPBGPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB7E0", Offset = "0x7EEA3E0", VA = "0x187EEB7E0", Slot = "5")]
	public bool IJOGPDAMHKO(EJFPGNMPAFH JGFKHBPEKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB600", Offset = "0x7EEA200", VA = "0x187EEB600", Slot = "6")]
	public void EBAGJKMAFHO(EJFPGNMPAFH JGFKHBPEKHF, BONOBHOAEBL PIACJOHGMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NDJPOCFKFJK
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F017C0", Offset = "0x7F003C0", VA = "0x187F017C0")]
	public static void BLPDEIDOFHH(this JADGOGMAGBG FOOEOLNDGBE, BONOBHOAEBL HMCNBCGLIEC, ViewId CBLPKFIJGLH, bool CFIHOMBJCBB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F01EA0", Offset = "0x7F00AA0", VA = "0x187F01EA0")]
	public static void OKMJMJPDIKI(this JADGOGMAGBG FOOEOLNDGBE, BONOBHOAEBL HMCNBCGLIEC, bool CFIHOMBJCBB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F01980", Offset = "0x7F00580", VA = "0x187F01980")]
	public static JADGOGMAGBG EBAGJKMAFHO(BONOBHOAEBL HMCNBCGLIEC, ViewId CBLPKFIJGLH, bool CFIHOMBJCBB = true)
	{
		return default(JADGOGMAGBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F01AF0", Offset = "0x7F006F0", VA = "0x187F01AF0")]
	public static void NJKMGHLCOAG(this JADGOGMAGBG FOOEOLNDGBE, BONOBHOAEBL HMCNBCGLIEC, bool CFIHOMBJCBB = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(DOHCFFCBBLI), new string[] { })]
public class IFLKKDDNJEI : DOHCFFCBBLI, INetworkUpdateSystem, LOEJKIHMCMK, IDOBMNBOACG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly JPIBGNDAFKP EADDOEIBPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BGBKBJFBNLE HPCAEPHENDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private uint EOOPLIEFJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float LAIHCGKIPHG;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7180", Offset = "0x7EF5D80", VA = "0x187EF7180", Slot = "4")]
	public void KHPGHNAFBFC(GJADDNEGONL ILGJODOAPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6D70", Offset = "0x7EF5970", VA = "0x187EF6D70", Slot = "5")]
	public void BFGPHHDGACD(GJADDNEGONL ILGJODOAPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7EF72A0", Offset = "0x7EF5EA0", VA = "0x187EF72A0", Slot = "10")]
	public void NHFNFEMINKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7400", Offset = "0x7EF6000", VA = "0x187EF7400", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage NFHNEPMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7480", Offset = "0x7EF6080", VA = "0x187EF7480")]
	private void PNDEMEGGLJH(uint JMEGGIOOPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6FD0", Offset = "0x7EF5BD0", VA = "0x187EF6FD0", Slot = "6")]
	public void CPAMPFHGGFK(AABOODEENBH.EIMBJENBEDD DCINLPBGPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6F70", Offset = "0x7EF5B70", VA = "0x187EF6F70", Slot = "7")]
	public void BPHBDMOKGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7120", Offset = "0x7EF5D20", VA = "0x187EF7120", Slot = "8")]
	public void HBIOMGIPKNA(object KHKBFEMNDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7EF69F0", Offset = "0x7EF55F0", VA = "0x187EF69F0")]
	private void AKNKJKFMKPD(DCFDGGPHAAA KHKBFEMNDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7000", Offset = "0x7EF5C00", VA = "0x187EF7000", Slot = "11")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7A50", Offset = "0x7EF6650", VA = "0x187EF7A50")]
	public IFLKKDDNJEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GFPNPCLDDME : HHAMPAGAEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private float DOFMLNEADMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int LMBLGFKDCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private uint OLAHEIEMOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly JOJHEOLJOJA MBAAGFKEAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EJFPGNMPAFH OEEGHPGOFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int NPGMBFCNKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte[] DHHCEDKFAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EJFPGNMPAFH JFMJLFBJCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int ALOPNPGLKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private byte[] DLBPHNCFGDH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PCIAAHNJNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7EEF840", Offset = "0x7EEE440", VA = "0x187EEF840", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7EEFA40", Offset = "0x7EEE640", VA = "0x187EEFA40")]
	public GFPNPCLDDME(JOJHEOLJOJA MBAAGFKEAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF6F0", Offset = "0x7EEE2F0", VA = "0x187EEF6F0", Slot = "5")]
	public bool IJOGPDAMHKO(EJFPGNMPAFH JGFKHBPEKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF540", Offset = "0x7EEE140", VA = "0x187EEF540", Slot = "6")]
	public void EBAGJKMAFHO(EJFPGNMPAFH JGFKHBPEKHF, BONOBHOAEBL PIACJOHGMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF730", Offset = "0x7EEE330", VA = "0x187EEF730")]
	internal HBCEDMDGJJP KJDPIAAMNCB(GJADDNEGONL ILGJODOAPFO, BONOBHOAEBL HMCNBCGLIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF870", Offset = "0x7EEE470", VA = "0x187EEF870")]
	private static void PDOHPANBNIB(HBCEDMDGJJP CCGEMHNPMBN, BONOBHOAEBL HMCNBCGLIEC, EJFPGNMPAFH HKCCFCFDNPJ, byte[] DPMBBHPEMOM, int IIDAFMMAPKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(HPMIILIBBKG), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class HPMIILIBBKG : CFLNMGDONAH, LOEJKIHMCMK, IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable OJPJDEIJALE;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable DMCJELLFJMK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly Hashtable CALGAAFMDJJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly MNMNIMLOHNO OCKHMAOJKCB;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly MNMNIMLOHNO OIKLNLDCEHD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly MNMNIMLOHNO DLMIDPKEAHP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly MNMNIMLOHNO ELBKLOOHEDH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly MNMNIMLOHNO FCKGOPLPGKK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int KNCCGEIDHDB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7EF50B0", Offset = "0x7EF3CB0", VA = "0x187EF50B0", Slot = "4")]
	public bool MDFDPGNPEKC(NDDCFJANKJC GALEDNLDGCG, bool OJLJECBIFIL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3150", Offset = "0x7EF1D50", VA = "0x187EF3150", Slot = "5")]
	public int CKIDIFKLCJP(NDDCFJANKJC[] JHOOCHMKOKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5280", Offset = "0x7EF3E80", VA = "0x187EF5280", Slot = "6")]
	public bool PFNMBGEDKMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4F20", Offset = "0x7EF3B20", VA = "0x187EF4F20", Slot = "7")]
	public bool LFFBHNLIBNB(int AAHKEEEBFIN, int NDOFFKPGGGL, bool GNPAFCOHFCF, GameObject AOALCMHDOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3B90", Offset = "0x7EF2790", VA = "0x187EF3B90", Slot = "8")]
	public void EHHLGFJMKNA(int NDOFFKPGGGL, [Optional] int? MAKEDDDKONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4650", Offset = "0x7EF3250", VA = "0x187EF4650", Slot = "9")]
	public bool HKKPNCBFNBH(DCFDGGPHAAA AGFKEDPOHKE, [Out] NDDCFJANKJC PPAMKBDJJMD, bool KICPDGOPEBG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EF47C0", Offset = "0x7EF33C0", VA = "0x187EF47C0", Slot = "10")]
	public bool IBJILNFBCLK(DCFDGGPHAAA AGFKEDPOHKE, [Out] int IEEKKBEHDNA, [Out] NDDCFJANKJC[] JHOOCHMKOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3F80", Offset = "0x7EF2B80", VA = "0x187EF3F80", Slot = "11")]
	public bool HIJDMMILPBM(DCFDGGPHAAA AGFKEDPOHKE, [Out] int NDOFFKPGGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4C20", Offset = "0x7EF3820", VA = "0x187EF4C20", Slot = "12")]
	public void KINPKLDFBLF(DCFDGGPHAAA AGFKEDPOHKE, [Out] int GAHNODEBMNM, [Out] int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3D80", Offset = "0x7EF2980", VA = "0x187EF3D80", Slot = "13")]
	public void EKMDKEBBPDA(int IEEKKBEHDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4E00", Offset = "0x7EF3A00", VA = "0x187EF4E00", Slot = "14")]
	public void LCBDPLHMJEK(int IEEKKBEHDNA, int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4B70", Offset = "0x7EF3770", VA = "0x187EF4B70", Slot = "15")]
	public void KAHBGKEHEOD(int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4AA0", Offset = "0x7EF36A0", VA = "0x187EF4AA0", Slot = "16")]
	public void JEGHPHLDHNG(int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF35F0", Offset = "0x7EF21F0", VA = "0x187EF35F0", Slot = "17")]
	public void DLAHJIMBOJA(int IEEKKBEHDNA, int NDOFFKPGGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3760", Offset = "0x7EF2360", VA = "0x187EF3760")]
	private static void EBJEOMFECJM(NDDCFJANKJC GALEDNLDGCG, Hashtable CGHGFOJCMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7EF40A0", Offset = "0x7EF2CA0", VA = "0x187EF40A0")]
	private static bool HKKPNCBFNBH(Hashtable CGHGFOJCMCG, BJCCECIKIFB OMPONBMFDOL, [Out] NDDCFJANKJC PPAMKBDJJMD, bool KICPDGOPEBG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3510", Offset = "0x7EF2110", VA = "0x187EF3510")]
	private static int CPHINBPPKFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7EF51E0", Offset = "0x7EF3DE0", VA = "0x187EF51E0", Slot = "18")]
	public void NHFNFEMINKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3EE0", Offset = "0x7EF2AE0", VA = "0x187EF3EE0", Slot = "19")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public HPMIILIBBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(PNCOFGLEFNC), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class PNCOFGLEFNC : AHDLBEDIMLO, LOEJKIHMCMK, IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable OGLDMBGJONM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static Hashtable IHKCEOHMPEM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static MNMNIMLOHNO NHFEFBCMBCB;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly MNMNIMLOHNO CCCCNGEAPKB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F02810", Offset = "0x7F01410", VA = "0x187F02810", Slot = "4")]
	public void HOPALJPBDJG(ViewId AAHKEEEBFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F02F50", Offset = "0x7F01B50", VA = "0x187F02F50", Slot = "5")]
	public bool OCDEPDOLPED(DCFDGGPHAAA AGFKEDPOHKE, [Out] ViewId AAHKEEEBFIN, [Out] string NIFKIJKMLPJ, [Out] int IACMPFGGOIA, [Out] object[] HNMKHBLHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F02900", Offset = "0x7F01500", VA = "0x187F02900", Slot = "6")]
	public void KLLOBPNGCLH(ViewId HBPAMLAADAH, string NIFKIJKMLPJ, NHCAOAMKGNN PJDNJJKGMDP, BJCCECIKIFB NEOGODNGJJE, PAENKPGAGKC JNDMJJHAJKH, object[] GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F02770", Offset = "0x7F01370", VA = "0x187F02770", Slot = "8")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F02EB0", Offset = "0x7F01AB0", VA = "0x187F02EB0", Slot = "7")]
	public void NHFNFEMINKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PNCOFGLEFNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ADEIJBJPGKE
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9C30", Offset = "0x7EE8830", VA = "0x187EE9C30")]
	public static BJCCECIKIFB HFLBPPFAMFN(this LDINANBBIGL EOHMOFMBNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE9CC0", Offset = "0x7EE88C0", VA = "0x187EE9CC0")]
	public static LDINANBBIGL JGHEOGHGHCM(this BJCCECIKIFB NEOGODNGJJE)
	{
		return default(LDINANBBIGL);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, BCLMGNMMIPD, LMDGBFCAGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<PCIEBPKKENL> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId OOMPMJLBBOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7F03BA0", Offset = "0x7F027A0", VA = "0x187F03BA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId ICMGGAFJNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7F03BA0", Offset = "0x7F027A0", VA = "0x187F03BA0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView NFBECNGMMAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7F03C20", Offset = "0x7F02820", VA = "0x187F03C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView EEPDIJAKNNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7F03C20", Offset = "0x7F02820", VA = "0x187F03C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BJCCECIKIFB CLCJOGIKGNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7F03D20", Offset = "0x7F02920", VA = "0x187F03D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BJCCECIKIFB IJNCJOKBAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7F04080", Offset = "0x7F02C80", VA = "0x187F04080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KBJEHMKNHLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F03E80", Offset = "0x7F02A80", VA = "0x187F03E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KGKEGEHBJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7F03FF0", Offset = "0x7F02BF0", VA = "0x187F03FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JJIDDPOEHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7F03AD0", Offset = "0x7F026D0", VA = "0x187F03AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ABHGIGJJPDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7F03DB0", Offset = "0x7F029B0", VA = "0x187F03DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PLHJIOBGLJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7F03AD0", Offset = "0x7F026D0", VA = "0x187F03AD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool KPJCJJMKALE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7F03B50", Offset = "0x7F02750", VA = "0x187F03B50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string BBKNACGELMD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7F03C90", Offset = "0x7F02890", VA = "0x187F03C90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool LGMFLLPKACC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7F03A50", Offset = "0x7F02650", VA = "0x187F03A50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<BJCCECIKIFB> PMKNBFBJLOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7F03920", Offset = "0x7F02520", VA = "0x187F03920")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7F04110", Offset = "0x7F02D10", VA = "0x187F04110")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F03880", Offset = "0x7F02480", VA = "0x187F03880")]
		public bool WasSpawnedForPlayer(int PHOAPOAJOAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7253990", Offset = "0x7252590", VA = "0x187253990")]
		private void EFHFGBDNDAM(RRNetworkView NGGJJFKLDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F03460", Offset = "0x7F02060", VA = "0x187F03460", Slot = "9")]
		public void RegisterDestroyHandler(PCIEBPKKENL BGDIJBGKCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F036B0", Offset = "0x7F022B0", VA = "0x187F036B0", Slot = "10")]
		public void UnregisterDestroyHandler(PCIEBPKKENL BGDIJBGKCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F03440", Offset = "0x7F02040", VA = "0x187F03440", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IBILIOFCCPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void MCILHFOLEIB([In] NDDCFJANKJC GALEDNLDGCG, bool JCHFPOEACNP, bool CGHGFOJCMCG, bool NAGNFCNNHLH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void DIHCKNBDFEP(GameObject CJBDGNIBOEE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void DBCBABCAHNG(GameObject CJBDGNIBOEE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void BLFEJHAODEK(RRNetworkView HBPAMLAADAH, string NIFKIJKMLPJ, BJCCECIKIFB LKIPHEHMEBC, NHCAOAMKGNN? MDKAAPLMLKG, bool BIAPBFEPAEG, PAENKPGAGKC DODIPMJHLNC, object[] GALEDNLDGCG, string JNAOBGOMPMD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void KKJGBGJEAPO(RRNetworkView HBPAMLAADAH, string NIFKIJKMLPJ, BJCCECIKIFB LKIPHEHMEBC, NHCAOAMKGNN? MDKAAPLMLKG, bool BIAPBFEPAEG, PAENKPGAGKC DODIPMJHLNC, object[] GALEDNLDGCG, string JNAOBGOMPMD);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void JNNCJGBFKMK(RRNetworkView HBPAMLAADAH, string NIFKIJKMLPJ, object[] HNMKHBLHFDD, string CIOCPKGJBEM);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void HBIKKKMIACJ(RRNetworkView HBPAMLAADAH, BJCCECIKIFB JLGIPHCIBOE);

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CompilerGenerated]
	private static DIHCKNBDFEP KAEBMAMNFHM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event MCILHFOLEIB KAOHHKAPLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7EF61E0", Offset = "0x7EF4DE0", VA = "0x187EF61E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5930", Offset = "0x7EF4530", VA = "0x187EF5930")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event DIHCKNBDFEP DJCCNPOOPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5C00", Offset = "0x7EF4800", VA = "0x187EF5C00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6930", Offset = "0x7EF5530", VA = "0x187EF6930")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event DBCBABCAHNG LJJPDDCJFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7EF67B0", Offset = "0x7EF53B0", VA = "0x187EF67B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6120", Offset = "0x7EF4D20", VA = "0x187EF6120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event DBCBABCAHNG JNDHFBFHANB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF66F0", Offset = "0x7EF52F0", VA = "0x187EF66F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF55E0", Offset = "0x7EF41E0", VA = "0x187EF55E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event BLFEJHAODEK KPNGPFHPCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6360", Offset = "0x7EF4F60", VA = "0x187EF6360")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5F10", Offset = "0x7EF4B10", VA = "0x187EF5F10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event KKJGBGJEAPO LKOMNBCJKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7EF56A0", Offset = "0x7EF42A0", VA = "0x187EF56A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6630", Offset = "0x7EF5230", VA = "0x187EF6630")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event JNNCJGBFKMK GDKHGGBOOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7EF59F0", Offset = "0x7EF45F0", VA = "0x187EF59F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5B40", Offset = "0x7EF4740", VA = "0x187EF5B40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event HBIKKKMIACJ DBHOOFJJIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7EF62A0", Offset = "0x7EF4EA0", VA = "0x187EF62A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6420", Offset = "0x7EF5020", VA = "0x187EF6420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event HBIKKKMIACJ NMLBMOOHGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6870", Offset = "0x7EF5470", VA = "0x187EF6870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6060", Offset = "0x7EF4C60", VA = "0x187EF6060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5E50", Offset = "0x7EF4A50", VA = "0x187EF5E50")]
	public static void FNNBECCNNNE([In] NDDCFJANKJC GALEDNLDGCG, bool JCHFPOEACNP, bool CGHGFOJCMCG, bool NAGNFCNNHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5CC0", Offset = "0x7EF48C0", VA = "0x187EF5CC0")]
	public static void EOACPHONNFG(GameObject CJBDGNIBOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5FD0", Offset = "0x7EF4BD0", VA = "0x187EF5FD0")]
	public static void GLABCKCNAIE(GameObject CJBDGNIBOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5AB0", Offset = "0x7EF46B0", VA = "0x187EF5AB0")]
	public static void EFJPJLHPAHE(GameObject CJBDGNIBOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7EF58A0", Offset = "0x7EF44A0", VA = "0x187EF58A0")]
	public static void BEGDDBCJDGM(GameObject CJBDGNIBOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF64E0", Offset = "0x7EF50E0", VA = "0x187EF64E0")]
	public static void MNHMJPEGAGF(RRNetworkView HBPAMLAADAH, string NIFKIJKMLPJ, BJCCECIKIFB LKIPHEHMEBC, NHCAOAMKGNN? MDKAAPLMLKG, bool BIAPBFEPAEG, PAENKPGAGKC DODIPMJHLNC, object[] GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5760", Offset = "0x7EF4360", VA = "0x187EF5760")]
	public static void BBFNKGNCEFB(RRNetworkView HBPAMLAADAH, string NIFKIJKMLPJ, int HJLLIJDPCPJ, object[] HNMKHBLHFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5D50", Offset = "0x7EF4950", VA = "0x187EF5D50")]
	public static void FLNGKLDGIFD(int AAHKEEEBFIN, int EOHMOFMBNIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NNBLMLIKNGC
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F02480", Offset = "0x7F01080", VA = "0x187F02480")]
	[CanBeNull]
	private static bool LNJKFILKGBM(ViewId ALPNKEJICNA, [Out] RRNetworkView HBPAMLAADAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F023A0", Offset = "0x7F00FA0", VA = "0x187F023A0")]
	[CanBeNull]
	public static Component AFPKFAMDGIA(this ViewId HBPAMLAADAH, Type MCNLEPLIBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C449A0", Offset = "0x3C435A0", VA = "0x183C449A0")]
	[CanBeNull]
	public static T AFPKFAMDGIA<T>(this ViewId HBPAMLAADAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C449A0", Offset = "0x3C435A0", VA = "0x183C449A0")]
	[CanBeNull]
	public static T HEDOIACACGM<T>(this ViewId HBPAMLAADAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C449F0", Offset = "0x3C435F0", VA = "0x183C449F0")]
	public static bool DKHGGPCDLFG<T>(this ViewId HBPAMLAADAH, [Out] T DBJBIPJCIKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F02530", Offset = "0x7F01130", VA = "0x187F02530")]
	[CanBeNull]
	public static RRNetworkView PEKEFDICABH(this ViewId HBPAMLAADAH)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static RRNetworkHandler KLHINJJCPGC;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler LBPNLDGACAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7F04240", Offset = "0x7F02E40", VA = "0x187F04240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F043F0", Offset = "0x7F02FF0", VA = "0x187F043F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F043B0", Offset = "0x7F02FB0", VA = "0x187F043B0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(MAEOOAICBDH), new string[] { "Photon" })]
public sealed class MAEOOAICBDH : KLOBJIBPPJF, LOEJKIHMCMK, IDOBMNBOACG, LAMCDMNANDN, LHJHKELMPGP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PLNMADLBFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PLNMADLBFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F026B0", Offset = "0x7F012B0", VA = "0x187F026B0")]
		internal object MLOJBEAMJJJ((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static JPIBGNDAFKP GCCAAAALJPP;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static JPIBGNDAFKP LPKKOEKDBBP;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, HashSet<int>> GCLCEGBBJPI;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static Dictionary<int, int> BMKIDKHEJFN;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<(GameObject GameObject, int ParentCount)> EBBGIDBONKA;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GameObject> MDEJJDNEMOH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static List<int> MAPGGDPJCHH;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<RRNetworkView> HLNDJMNFDBH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly MNMNIMLOHNO ELBKLOOHEDH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly MNMNIMLOHNO FCKGOPLPGKK;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F00220", Offset = "0x7EFEE20", VA = "0x187F00220", Slot = "8")]
	public void NHFNFEMINKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB630", Offset = "0x7EFA230", VA = "0x187EFB630", Slot = "9")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD2E0", Offset = "0x7EFBEE0", VA = "0x187EFD2E0", Slot = "10")]
	public void InitExternal(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDB00", Offset = "0x7EFC700", VA = "0x187EFDB00", Slot = "11")]
	public void JGDAKBPELOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAE80", Offset = "0x7EF9A80", VA = "0x187EFAE80")]
	private void EEEBPHAEHAH(FPMBFAALCKJ ICMMANEOIJM, FPMBFAALCKJ DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC650", Offset = "0x7EFB250", VA = "0x187EFC650")]
	private void IAHAPKHEJHI(KNPPLJCCOOI NEJICOAALFE, KNPPLJCCOOI EDFPPIJPJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD110", Offset = "0x7EFBD10", VA = "0x187EFD110")]
	public GameObject IOIHBDAPJHM(string LAOCJKNALFF, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, Vector3 LHHOCCKJGIB, ViewId AAHKEEEBFIN, ILDPOIGDHNO GALEDNLDGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF360", Offset = "0x7EFDF60", VA = "0x187EFF360")]
	public GameObject LEFPKAGJOIP(string LAOCJKNALFF, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float LHHOCCKJGIB, object[] GALEDNLDGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F00BE0", Offset = "0x7EFF7E0", VA = "0x187F00BE0")]
	public GameObject PCEJNGANLOH(string LAOCJKNALFF, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, Vector3 LHHOCCKJGIB, ViewId HBPAMLAADAH, ILDPOIGDHNO GALEDNLDGCG, bool NAGNFCNNHLH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F00790", Offset = "0x7EFF390", VA = "0x187F00790")]
	public GameObject OCMDJGMGJDA(NDDCFJANKJC GALEDNLDGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFCA0", Offset = "0x7EFE8A0", VA = "0x187EFFCA0", Slot = "6")]
	public void LKJKMBMIBMP(GameObject CJBDGNIBOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBEF0", Offset = "0x7EFAAF0", VA = "0x187EFBEF0")]
	public void GMPJFFKIFGC(GameObject AOALCMHDOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFCB0", Offset = "0x7EFE8B0", VA = "0x187EFFCB0", Slot = "7")]
	public void LNKBFCMGPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBBD0", Offset = "0x7EFA7D0", VA = "0x187EFBBD0", Slot = "4")]
	public GameObject[] GMPGNCKDCMN(IList<KOKKHDLLJJP> MEDKCOHHKEH, bool OCONIOBOGKN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA7D0", Offset = "0x7EF93D0", VA = "0x187EFA7D0", Slot = "5")]
	public void DAANKKJOKCI(List<GameObject> CELEDNBGMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F00140", Offset = "0x7EFED40", VA = "0x187F00140")]
	public void NFKMDPICKAF(GameObject AOALCMHDOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8E20", Offset = "0x7EF7A20", VA = "0x187EF8E20")]
	private void AKNKJKFMKPD(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCF50", Offset = "0x7EFBB50", VA = "0x187EFCF50")]
	private void IMKHONOPMLD(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEDB0", Offset = "0x7EFD9B0", VA = "0x187EFEDB0")]
	private void KEJMEBDMHJL(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F00900", Offset = "0x7EFF500", VA = "0x187F00900")]
	private void OMGICEOEFOK(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB290", Offset = "0x7EF9E90", VA = "0x187EFB290")]
	private void EPGGCLNNHHC(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC750", Offset = "0x7EFB350", VA = "0x187EFC750")]
	private void IBANDALNBEE(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD4B0", Offset = "0x7EFC0B0", VA = "0x187EFD4B0")]
	private void JDEKEPPAOBO(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB0A0", Offset = "0x7EF9CA0", VA = "0x187EFB0A0")]
	private GameObject EJLAMCFIDGO(string KJKNEFAFPLG, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, Vector3 LHHOCCKJGIB, byte KAEEKMHMHPB = 0, [Optional] object[] PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBF60", Offset = "0x7EFAB60", VA = "0x187EFBF60")]
	private GameObject HOAKANHFLLJ(NDDCFJANKJC GALEDNLDGCG, bool JCHFPOEACNP = false, bool CGHGFOJCMCG = false, bool NAGNFCNNHLH = true, bool DPPDNJIEFBJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFCC0", Offset = "0x7EFE8C0", VA = "0x187EFFCC0")]
	private static GameObject MMMCPMFEOAF(string KJKNEFAFPLG, bool ANIJCDPKHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F00580", Offset = "0x7EFF180", VA = "0x187F00580")]
	private static GameObject NIIKHBFJJME(GameObject DNPJNJCBEBE, NDDCFJANKJC GALEDNLDGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAB90", Offset = "0x7EF9790", VA = "0x187EFAB90")]
	private static void DACDCCAANHA(GameObject CJBDGNIBOEE, RRNetworkView HBPAMLAADAH, [In] NDDCFJANKJC GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF450", Offset = "0x7EFE050", VA = "0x187EFF450")]
	private GameObject[] LEGMOJLABHC(IList<KOKKHDLLJJP> MEDKCOHHKEH, bool OCONIOBOGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF060", Offset = "0x7EFDC60", VA = "0x187EFF060")]
	private GameObject[] KFBJFFNHCPI(NDDCFJANKJC[] JHOOCHMKOKK, int IEEKKBEHDNA, BJCCECIKIFB NEOGODNGJJE, GameObject[] MJKEOEIMCJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCB40", Offset = "0x7EFB740", VA = "0x187EFCB40")]
	private GameObject IEAFJAAGKAE([In] NDDCFJANKJC GALEDNLDGCG, GameObject DNPJNJCBEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7227F20", Offset = "0x7226B20", VA = "0x187227F20")]
	private static bool GAAFKMDEHGO(bool JCHFPOEACNP, bool NAGNFCNNHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EF98E0", Offset = "0x7EF84E0", VA = "0x187EF98E0")]
	private void CGDGECHPPFF(IEnumerable<GameObject> CELEDNBGMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDCD0", Offset = "0x7EFC8D0", VA = "0x187EFDCD0")]
	private void JMADMLMKMIK(GameObject CJBDGNIBOEE, bool DPPDNJIEFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFD40", Offset = "0x7EFE940", VA = "0x187EFFD40")]
	private static void NANDPCGALHE(IEnumerable<GameObject> ABKMBAJJAMC, List<(GameObject GameObject, int ParentCount)> EPOCFMEJAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEBB0", Offset = "0x7EFD7B0", VA = "0x187EFEBB0")]
	private void JMKNOLHOFKD(int NDOFFKPGGGL, int IEEKKBEHDNA, bool DPPDNJIEFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EFED10", Offset = "0x7EFD910", VA = "0x187EFED10")]
	private static int KCPKKGIGDFE(int NDOFFKPGGGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF300", Offset = "0x7EFDF00", VA = "0x187EFF300")]
	private void KGOJHLCKBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F00E70", Offset = "0x7EFFA70", VA = "0x187F00E70")]
	private void PFEHKDDGEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F008A0", Offset = "0x7EFF4A0", VA = "0x187F008A0")]
	private static int OGJFFLIFALJ(int EKIGNNMMAGN, bool NAGNFCNNHLH = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F007C0", Offset = "0x7EFF3C0", VA = "0x187F007C0")]
	private static int[] OEMEDAFDNBN(int EKGMEDBONNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7EFACA0", Offset = "0x7EF98A0", VA = "0x187EFACA0")]
	private static int[] DGPMJJPFKIO(int IJNCJOKBAFO, int EKGMEDBONNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAE40", Offset = "0x7EF9A40", VA = "0x187EFAE40")]
	private void DLMJAAPMNAA(BJCCECIKIFB NJCDGENKHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9110", Offset = "0x7EF7D10", VA = "0x187EF9110")]
	private void APHFLALCHJB(BJCCECIKIFB NEOGODNGJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA500", Offset = "0x7EF9100", VA = "0x187EFA500")]
	private void COFHOPMLILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB990", Offset = "0x7EFA590", VA = "0x187EFB990")]
	private void GCHLAMPGJLE(BJCCECIKIFB NEOGODNGJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7EFADA0", Offset = "0x7EF99A0", VA = "0x187EFADA0")]
	private static void DHNIMPNCCFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAFA0", Offset = "0x7EF9BA0", VA = "0x187EFAFA0")]
	private void EHGKOANIFGK(int[] JBCEMGFOILP, int AJBPDPMCGCL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public MAEOOAICBDH()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(EFFMOCLLOED), new string[] { "Photon" })]
public class EFFMOCLLOED : LOEJKIHMCMK, IDOBMNBOACG, DBMDFMKAJJH
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct HCGGAOFOAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MethodInfo JCABHEKILHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Func<MonoBehaviour, object> GKPONBJDBAD;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
		public HCGGAOFOAGJ(MethodInfo JCABHEKILHK, [Optional] Func<MonoBehaviour, object> GKPONBJDBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x721E2A0", Offset = "0x721CEA0", VA = "0x18721E2A0")]
		public object ONAKPIAMFHC(MonoBehaviour MAOEFKNCJHO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CBJKNKFJMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CBJKNKFJMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7EEB530", Offset = "0x7EEA130", VA = "0x187EEB530")]
		internal HCGGAOFOAGJ DFNJJKHINEI(MethodInfo methodInfo)
		{
			return default(HCGGAOFOAGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x47CEBB0", Offset = "0x47CD7B0", VA = "0x1847CEBB0")]
		internal object DJIFLHMFACI(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ONGGPFIPJPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ONGGPFIPJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x723D550", Offset = "0x723C150", VA = "0x18723D550")]
		internal HCGGAOFOAGJ AECADPMHFOK(MethodInfo methodInfo)
		{
			return default(HCGGAOFOAGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HFJOACJPDFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HFJOACJPDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7EF3000", Offset = "0x7EF1C00", VA = "0x187EF3000")]
		internal bool BFNMGKGODFH(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Stopwatch OLLFMJJCOEE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Dictionary<MethodInfo, ParameterInfo[]> HCBAJEKHLNN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<Type, List<HCGGAOFOAGJ>> DDBCAPOEKIG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EED5C0", Offset = "0x7EEC1C0", VA = "0x187EED5C0", Slot = "4")]
	public void NHFNFEMINKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC4E0", Offset = "0x7EEB0E0", VA = "0x187EEC4E0", Slot = "5")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB920", Offset = "0x7EEA520", VA = "0x187EEB920")]
	private void AKNKJKFMKPD(DCFDGGPHAAA AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EED100", Offset = "0x7EEBD00", VA = "0x187EED100", Slot = "9")]
	public string IMMLGDFBEJH(DCFDGGPHAAA AGFKEDPOHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EED020", Offset = "0x7EEBC20", VA = "0x187EED020", Slot = "8")]
	public void HOPALJPBDJG(ViewId AAHKEEEBFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EEBBD0", Offset = "0x7EEA7D0", VA = "0x187EEBBD0", Slot = "6")]
	public void BCAPMHEILLH(ViewId HBPAMLAADAH, string NIFKIJKMLPJ, BJCCECIKIFB NEOGODNGJJE, PAENKPGAGKC DODIPMJHLNC, params object[] GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC170", Offset = "0x7EEAD70", VA = "0x187EEC170", Slot = "7")]
	public void BCAPMHEILLH(ViewId HBPAMLAADAH, string NIFKIJKMLPJ, NHCAOAMKGNN MDKAAPLMLKG, PAENKPGAGKC DODIPMJHLNC, params object[] GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7EEBCA0", Offset = "0x7EEA8A0", VA = "0x187EEBCA0")]
	private void BCAPMHEILLH(ViewId HBPAMLAADAH, string NIFKIJKMLPJ, NHCAOAMKGNN MDKAAPLMLKG, BJCCECIKIFB NEOGODNGJJE, PAENKPGAGKC DODIPMJHLNC, params object[] GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EED710", Offset = "0x7EEC310", VA = "0x187EED710")]
	private void POCFDJJOILN(ViewId AAHKEEEBFIN, string NIFKIJKMLPJ, BJCCECIKIFB MONEFJFBDPB, int IACMPFGGOIA, object[] HNMKHBLHFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EED130", Offset = "0x7EEBD30", VA = "0x187EED130")]
	private static void KLHLFDCGFGF(HCGGAOFOAGJ JHBFLLOMAIH, MonoBehaviour GLFCEIPONNE, object[] FABPHEFJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC1A0", Offset = "0x7EEADA0", VA = "0x187EEC1A0")]
	private static bool COPPOAKAPDG(ParameterInfo[] MPOOKMKMHLA, Type[] FGDHJHLCFFH, [Out] bool PFPEACLBDLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC630", Offset = "0x7EEB230", VA = "0x187EEC630")]
	private List<HCGGAOFOAGJ> GKKCFCEECCH(MonoBehaviour GLFCEIPONNE, Type MKJJLOMJDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB820", Offset = "0x7EEA420", VA = "0x187EEB820")]
	private static IEnumerable<MethodInfo> AHHJAKOFDCD(Type OPOPAMPKKGD, Type ALMFFKDOLNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC3D0", Offset = "0x7EEAFD0", VA = "0x187EEC3D0")]
	public static ParameterInfo[] DOPDHHNLHMN(MethodInfo ELDGACJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public EFFMOCLLOED()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, MBNIPOOIKJF, DAAGKHHIFFP, NIOAPDEKDJI, PPEMHOCDPPO, GJAPKLOLFLN
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum HPNHKCAFODM
		{
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class MDACHHALLOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public MDACHHALLOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x7F01760", Offset = "0x7F00360", VA = "0x187F01760")]
			internal bool FGEIAEOLONJ(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<int, RRNetworkView> PHOLFBMJMJK;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static MNMNIMLOHNO OKDLBMHBIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private bool GHMEKODFPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal bool EJKBCOIDBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public HPNHKCAFODM hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool GFJABENGHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool IKAJKHHEBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int HNNKNGDPNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool JLALIFHBOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int BCLKALLFPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private BJCCECIKIFB IJNCJOKBAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private BJCCECIKIFB JJEDFAOIFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool? GGGNGFKJOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool IILIJCEGAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal bool NCLKCDGANMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal MonoBehaviour[] FFAFGJHBNCG;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly JPIBGNDAFKP NLIPNMBOKEJ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId ICMGGAFJNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7F09680", Offset = "0x7F08280", VA = "0x187F09680")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId NCGGOGDCEAM
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7F09680", Offset = "0x7F08280", VA = "0x187F09680", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId OOMPMJLBBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7F09680", Offset = "0x7F08280", VA = "0x187F09680")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int ILMPAOCNIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA21F20", Offset = "0xA20B20", VA = "0x180A21F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int JNODPDEOJFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA45B00", Offset = "0xA44700", VA = "0x180A45B00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xE09120", Offset = "0xE07D20", VA = "0x180E09120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ViewId NCNJFDNKKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7F094F0", Offset = "0x7F080F0", VA = "0x187F094F0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GNPAFCOHFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA24660", Offset = "0xA23260", VA = "0x180A24660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool JLPCDGLBJKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7F09500", Offset = "0x7F08100", VA = "0x187F09500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool FGIIDAPABMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xBDFF70", Offset = "0xBDEB70", VA = "0x180BDFF70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xB3BA30", Offset = "0xB3A630", VA = "0x180B3BA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int LEPNLPLDKLB
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8E0", Offset = "0xA6C4E0", VA = "0x180A6D8E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int FEJJCPGLFEB
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7F09490", Offset = "0x7F08090", VA = "0x187F09490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public BJCCECIKIFB ODNPAACGFBB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7F09690", Offset = "0x7F08290", VA = "0x187F09690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public BJCCECIKIFB FEKJEHAPLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7F09460", Offset = "0x7F08060", VA = "0x187F09460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public BJCCECIKIFB CLCJOGIKGNI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7F09460", Offset = "0x7F08060", VA = "0x187F09460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public BJCCECIKIFB OBFGJKGGNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7F09460", Offset = "0x7F08060", VA = "0x187F09460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool GEHNNKJLLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7F095D0", Offset = "0x7F081D0", VA = "0x187F095D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int GJNHFLDCJKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7F094C0", Offset = "0x7F080C0", VA = "0x187F094C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public object[] NDIDGDKFGIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA24890", Offset = "0xA23490", VA = "0x180A24890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool KBJEHMKNHLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7F096C0", Offset = "0x7F082C0", VA = "0x187F096C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EKCKMJMFBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7F09650", Offset = "0x7F08250", VA = "0x187F09650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool KAAEIICEOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xDD35A0", Offset = "0xDD21A0", VA = "0x180DD35A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xF325D0", Offset = "0xF311D0", VA = "0x180F325D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CNLFLMDCNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xC7DE60", Offset = "0xC7CA60", VA = "0x180C7DE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> MNLKBIGKGHF
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7F09300", Offset = "0x7F07F00", VA = "0x187F09300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7F09880", Offset = "0x7F08480", VA = "0x187F09880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<BJCCECIKIFB> EBGDPMLMHNH
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7F05990", Offset = "0x7F04590", VA = "0x187F05990")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7F06300", Offset = "0x7F04F00", VA = "0x187F06300")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<BJCCECIKIFB> PPGCAEAGGAG
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7F05990", Offset = "0x7F04590", VA = "0x187F05990")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7F06300", Offset = "0x7F04F00", VA = "0x187F06300")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> HKFDMHDAEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7F05A40", Offset = "0x7F04640", VA = "0x187F05A40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7F04FD0", Offset = "0x7F03BD0", VA = "0x187F04FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> DKMOJMMMFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7F05A40", Offset = "0x7F04640", VA = "0x187F05A40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7F04FD0", Offset = "0x7F03BD0", VA = "0x187F04FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> LBNLDDDFDID
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7F093B0", Offset = "0x7F07FB0", VA = "0x187F093B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7F09930", Offset = "0x7F08530", VA = "0x187F09930")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action EOOCCLPCNJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7F09250", Offset = "0x7F07E50", VA = "0x187F09250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7F097D0", Offset = "0x7F083D0", VA = "0x187F097D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7F09090", Offset = "0x7F07C90", VA = "0x187F09090")]
		public static bool TryGetNetworkView(int AAHKEEEBFIN, [Out] RRNetworkView HBPAMLAADAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7F051E0", Offset = "0x7F03DE0", VA = "0x187F051E0")]
		public static RRNetworkView Find(int AAHKEEEBFIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7F052E0", Offset = "0x7F03EE0", VA = "0x187F052E0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int GCGNJIOIEMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7F05270", Offset = "0x7F03E70", VA = "0x187F05270")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7F06800", Offset = "0x7F05400", VA = "0x187F06800")]
		public static bool RemoveNetworkView(RRNetworkView HBPAMLAADAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7F065D0", Offset = "0x7F051D0", VA = "0x187F065D0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F05C90", Offset = "0x7F04890", VA = "0x187F05C90")]
		public static void OnPlayerJoinedRoom(BJCCECIKIFB ECKFHGMKBCH, List<int> JBCEMGFOILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F05420", Offset = "0x7F04020", VA = "0x187F05420")]
		public static RRNetworkView Get(Component LBEOEMMCAFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7F05480", Offset = "0x7F04080", VA = "0x187F05480")]
		public static RRNetworkView Get(GameObject KCCEMOHEKBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7F048B0", Offset = "0x7F034B0", VA = "0x187F048B0")]
		private void CLGDOCCMFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7F04DF0", Offset = "0x7F039F0", VA = "0x187F04DF0")]
		public bool CreatedBy(BJCCECIKIFB NEOGODNGJJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7F08EA0", Offset = "0x7F07AA0", VA = "0x187F08EA0")]
		public void TransferOwnership(int HIHJOOBENHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7F08E40", Offset = "0x7F07A40", VA = "0x187F08E40")]
		public void TransferOwnership(BJCCECIKIFB JLGIPHCIBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7F05540", Offset = "0x7F04140", VA = "0x187F05540", Slot = "4")]
		public void Initialize(ViewId GEONONOFJGE, ViewId OODKDJEIEAN, Dictionary<int, object> NJHNNBNFCIE, LDINANBBIGL IJNCJOKBAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7F054E0", Offset = "0x7F040E0", VA = "0x187F054E0")]
		public void Initialize(ViewId GEONONOFJGE, ViewId OODKDJEIEAN, object[] HDNBFLDBGHP, LDINANBBIGL IJNCJOKBAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7F04560", Offset = "0x7F03160", VA = "0x187F04560")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F04990", Offset = "0x7F03590", VA = "0x187F04990")]
		private void CLNNIKEENEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1F08600", Offset = "0x1F07200", VA = "0x181F08600")]
		internal void EBCEBHNAKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7F045C0", Offset = "0x7F031C0", VA = "0x187F045C0", Slot = "6")]
		private void BABBEKDIGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7F04F60", Offset = "0x7F03B60", VA = "0x187F04F60")]
		internal bool EBNDADMMEBI(RRNetworkView HAEBGOJJMHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7F05AF0", Offset = "0x7F046F0", VA = "0x187F05AF0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7F058B0", Offset = "0x7F044B0", VA = "0x187F058B0")]
		internal void KPEOGDDANMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F04430", Offset = "0x7F03030", VA = "0x187F04430")]
		private void ADIEDNDGAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7F05080", Offset = "0x7F03C80", VA = "0x187F05080")]
		internal void FGAHBPNGHGP(BJCCECIKIFB JLGIPHCIBOE, int HIHJOOBENHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7F06760", Offset = "0x7F05360", VA = "0x187F06760")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7F06880", Offset = "0x7F05480", VA = "0x187F06880")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7F044C0", Offset = "0x7F030C0", VA = "0x187F044C0")]
		private void AIOOAMACGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7F04E70", Offset = "0x7F03A70", VA = "0x187F04E70")]
		private void DHFNKBNKDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7F064B0", Offset = "0x7F050B0", VA = "0x187F064B0")]
		public void RPC(string NIFKIJKMLPJ, NHCAOAMKGNN MDKAAPLMLKG, params object[] GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7F06540", Offset = "0x7F05140", VA = "0x187F06540")]
		public void RPC(string NIFKIJKMLPJ, BJCCECIKIFB LKIPHEHMEBC, params object[] GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7F067B0", Offset = "0x7F053B0", VA = "0x187F067B0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7F04680", Offset = "0x7F03280", VA = "0x187F04680", Slot = "8")]
		public void Bake(GJAKMMJKIGI CBLPKFIJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7F04440", Offset = "0x7F03040", VA = "0x187F04440")]
		private static void AHILLGIBMLO(BJCCECIKIFB DMMFONEMJLA, [Out] BJCCECIKIFB JEHLDBHABMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7F05FE0", Offset = "0x7F04BE0", VA = "0x187F05FE0")]
		private static void PBDGKFNHGMO(RRNetworkView NFBECNGMMAD, Delegate JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7F05910", Offset = "0x7F04510", VA = "0x187F05910")]
		private static EEIJICMJMPB LGPHFJLCFFG(RRNetworkView NFBECNGMMAD)
		{
			return default(EEIJICMJMPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7F05140", Offset = "0x7F03D40", VA = "0x187F05140")]
		private static ALHJKKHMHIP FNNJKFOOPCA(RRNetworkView NFBECNGMMAD)
		{
			return default(ALHJKKHMHIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7F046F0", Offset = "0x7F032F0", VA = "0x187F046F0")]
		private static void CFDHPANMOMI(RRNetworkView NFBECNGMMAD, Delegate JHBFLLOMAIH, BJCCECIKIFB MIIGAPBBILG, params object[] GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7F047D0", Offset = "0x7F033D0", VA = "0x187F047D0")]
		private static void CFDHPANMOMI(RRNetworkView NFBECNGMMAD, Delegate JHBFLLOMAIH, NHCAOAMKGNN MIIGAPBBILG, params object[] GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7F056C0", Offset = "0x7F042C0", VA = "0x187F056C0")]
		private static void JDJKMFMMGGF(RRNetworkView NFBECNGMMAD, Delegate JHBFLLOMAIH, NHCAOAMKGNN MIIGAPBBILG, LIGOOAGMMLF PFHGBGEFJKE, params object[] GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7F063B0", Offset = "0x7F04FB0", VA = "0x187F063B0")]
		public void RPCBuffered(string NIFKIJKMLPJ, NHCAOAMKGNN MDKAAPLMLKG, LIGOOAGMMLF DODIPMJHLNC, params object[] GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7F05810", Offset = "0x7F04410", VA = "0x187F05810")]
		private static bool JNNFLMDOAMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7F07130", Offset = "0x7F05D30", VA = "0x187F07130", Slot = "26")]
		public void RpcAll(BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3D495C0", Offset = "0x3D481C0", VA = "0x183D495C0", Slot = "9")]
		public void RpcAll<T1>(BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3D48E40", Offset = "0x3D47A40", VA = "0x183D48E40", Slot = "10")]
		public void RpcAll<T1, T2>(BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B240", Offset = "0x3D49E40", VA = "0x183D4B240", Slot = "27")]
		public void RpcAll<T1, T2, T3>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3D49050", Offset = "0x3D47C50", VA = "0x183D49050", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AC00", Offset = "0x3D49800", VA = "0x183D4AC00", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B740", Offset = "0x3D4A340", VA = "0x183D4B740", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C200", Offset = "0x3D4AE00", VA = "0x183D4C200", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3D50BD0", Offset = "0x3D4F7D0", VA = "0x183D50BD0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BBE0", Offset = "0x3D4A7E0", VA = "0x183D4BBE0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A020", Offset = "0x3D48C20", VA = "0x183D4A020", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3D57800", Offset = "0x3D56400", VA = "0x183D57800", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3D561F0", Offset = "0x3D54DF0", VA = "0x183D561F0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3D55C10", Offset = "0x3D54810", VA = "0x183D55C10", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3D49750", Offset = "0x3D48350", VA = "0x183D49750", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7F072A0", Offset = "0x7F05EA0", VA = "0x187F072A0")]
		public void RpcAll(BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E220", Offset = "0x3D4CE20", VA = "0x183D4E220")]
		public void RpcAll<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3D4EC40", Offset = "0x3D4D840", VA = "0x183D4EC40")]
		public void RpcAll<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A8F0", Offset = "0x3D494F0", VA = "0x183D4A8F0")]
		public void RpcAll<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3D5C980", Offset = "0x3D5B580", VA = "0x183D5C980")]
		public void RpcAll<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3D5BE60", Offset = "0x3D5AA60", VA = "0x183D5BE60")]
		public void RpcAll<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B490", Offset = "0x3D5A090", VA = "0x183D5B490")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A9C0", Offset = "0x3D595C0", VA = "0x183D5A9C0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A1A0", Offset = "0x3D58DA0", VA = "0x183D5A1A0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3D59510", Offset = "0x3D58110", VA = "0x183D59510")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3D58BB0", Offset = "0x3D577B0", VA = "0x183D58BB0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3D57CF0", Offset = "0x3D568F0", VA = "0x183D57CF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3D56D10", Offset = "0x3D55910", VA = "0x183D56D10")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3D54FD0", Offset = "0x3D53BD0", VA = "0x183D54FD0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3D54950", Offset = "0x3D53550", VA = "0x183D54950")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7F06F00", Offset = "0x7F05B00", VA = "0x187F06F00", Slot = "36")]
		public void RpcAll(BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3D60DF0", Offset = "0x3D5F9F0", VA = "0x183D60DF0", Slot = "37")]
		public void RpcAll<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EFE0", Offset = "0x3D5DBE0", VA = "0x183D5EFE0", Slot = "38")]
		public void RpcAll<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3D5D930", Offset = "0x3D5C530", VA = "0x183D5D930", Slot = "39")]
		public void RpcAll<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3D5CC30", Offset = "0x3D5B830", VA = "0x183D5CC30", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3D5C420", Offset = "0x3D5B020", VA = "0x183D5C420", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B7F0", Offset = "0x3D5A3F0", VA = "0x183D5B7F0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D5AD70", Offset = "0x3D59970", VA = "0x183D5AD70", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A5B0", Offset = "0x3D591B0", VA = "0x183D5A5B0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3D59090", Offset = "0x3D57C90", VA = "0x183D59090", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3D58230", Offset = "0x3D56E30", VA = "0x183D58230", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3D572C0", Offset = "0x3D55EC0", VA = "0x183D572C0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3D56760", Offset = "0x3D55360", VA = "0x183D56760", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3D555F0", Offset = "0x3D541F0", VA = "0x183D555F0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3D53C90", Offset = "0x3D52890", VA = "0x183D53C90", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7F06B70", Offset = "0x7F05770", VA = "0x187F06B70", Slot = "51")]
		public void RpcAllViaServer(BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D48B40", Offset = "0x3D47740", VA = "0x183D48B40", Slot = "52")]
		public void RpcAllViaServer<T1>(BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3D40A90", Offset = "0x3D3F690", VA = "0x183D40A90", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3D48210", Offset = "0x3D46E10", VA = "0x183D48210", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3D47C10", Offset = "0x3D46810", VA = "0x183D47C10", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3D479C0", Offset = "0x3D465C0", VA = "0x183D479C0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3D47000", Offset = "0x3D45C00", VA = "0x183D47000", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D467B0", Offset = "0x3D453B0", VA = "0x183D467B0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3D45B40", Offset = "0x3D44740", VA = "0x183D45B40", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3D45440", Offset = "0x3D44040", VA = "0x183D45440", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3D44920", Offset = "0x3D43520", VA = "0x183D44920", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3D438F0", Offset = "0x3D424F0", VA = "0x183D438F0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3D43010", Offset = "0x3D41C10", VA = "0x183D43010", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3D42220", Offset = "0x3D40E20", VA = "0x183D42220", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3D41320", Offset = "0x3D3FF20", VA = "0x183D41320", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7F06CA0", Offset = "0x7F058A0", VA = "0x187F06CA0")]
		public void RpcAllViaServer(BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3D48D40", Offset = "0x3D47940", VA = "0x183D48D40")]
		public void RpcAllViaServer<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3D48880", Offset = "0x3D47480", VA = "0x183D48880")]
		public void RpcAllViaServer<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3D483C0", Offset = "0x3D46FC0", VA = "0x183D483C0")]
		public void RpcAllViaServer<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3D47E10", Offset = "0x3D46A10", VA = "0x183D47E10")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3D47770", Offset = "0x3D46370", VA = "0x183D47770")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3D47290", Offset = "0x3D45E90", VA = "0x183D47290")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3D464D0", Offset = "0x3D450D0", VA = "0x183D464D0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3D45E70", Offset = "0x3D44A70", VA = "0x183D45E70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3D457C0", Offset = "0x3D443C0", VA = "0x183D457C0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3D44CF0", Offset = "0x3D438F0", VA = "0x183D44CF0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3D44130", Offset = "0x3D42D30", VA = "0x183D44130")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D42BA0", Offset = "0x3D417A0", VA = "0x183D42BA0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D426E0", Offset = "0x3D412E0", VA = "0x183D426E0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D40E00", Offset = "0x3D3FA00", VA = "0x183D40E00")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F06DD0", Offset = "0x7F059D0", VA = "0x187F06DD0", Slot = "65")]
		public void RpcAllViaServer(BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D48C40", Offset = "0x3D47840", VA = "0x183D48C40", Slot = "66")]
		public void RpcAllViaServer<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D48720", Offset = "0x3D47320", VA = "0x183D48720", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D48570", Offset = "0x3D47170", VA = "0x183D48570", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D48010", Offset = "0x3D46C10", VA = "0x183D48010", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D47520", Offset = "0x3D46120", VA = "0x183D47520", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D46D70", Offset = "0x3D45970", VA = "0x183D46D70", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D46A90", Offset = "0x3D45690", VA = "0x183D46A90", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D461A0", Offset = "0x3D44DA0", VA = "0x183D461A0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D450C0", Offset = "0x3D43CC0", VA = "0x183D450C0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D44550", Offset = "0x3D43150", VA = "0x183D44550", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D43D10", Offset = "0x3D42910", VA = "0x183D43D10", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D43480", Offset = "0x3D42080", VA = "0x183D43480", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D41D60", Offset = "0x3D40960", VA = "0x183D41D60", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D41840", Offset = "0x3D40440", VA = "0x183D41840", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F08430", Offset = "0x7F07030", VA = "0x187F08430", Slot = "80")]
		public void RpcOthers(BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FE80", Offset = "0x3D8EA80", VA = "0x183D8FE80", Slot = "15")]
		public void RpcOthers<T1>(BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D90730", Offset = "0x3D8F330", VA = "0x183D90730", Slot = "81")]
		public void RpcOthers<T1, T2>(BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FC00", Offset = "0x3D8E800", VA = "0x183D8FC00", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D990A0", Offset = "0x3D97CA0", VA = "0x183D990A0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D91490", Offset = "0x3D90090", VA = "0x183D91490", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D98470", Offset = "0x3D97070", VA = "0x183D98470", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D978D0", Offset = "0x3D964D0", VA = "0x183D978D0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D96F00", Offset = "0x3D95B00", VA = "0x183D96F00", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D967F0", Offset = "0x3D953F0", VA = "0x183D967F0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D95CA0", Offset = "0x3D948A0", VA = "0x183D95CA0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D95080", Offset = "0x3D93C80", VA = "0x183D95080", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D94370", Offset = "0x3D92F70", VA = "0x183D94370", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D93560", Offset = "0x3D92160", VA = "0x183D93560", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D92640", Offset = "0x3D91240", VA = "0x183D92640", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F08580", Offset = "0x7F07180", VA = "0x187F08580")]
		public void RpcOthers(BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D90490", Offset = "0x3D8F090", VA = "0x183D90490")]
		public void RpcOthers<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D902B0", Offset = "0x3D8EEB0", VA = "0x183D902B0")]
		public void RpcOthers<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D9A220", Offset = "0x3D98E20", VA = "0x183D9A220")]
		public void RpcOthers<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FFD0", Offset = "0x3D8EBD0", VA = "0x183D8FFD0")]
		public void RpcOthers<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D90C20", Offset = "0x3D8F820", VA = "0x183D90C20")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D90F60", Offset = "0x3D8FB60", VA = "0x183D90F60")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D97BE0", Offset = "0x3D967E0", VA = "0x183D97BE0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D97260", Offset = "0x3D95E60", VA = "0x183D97260")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D96090", Offset = "0x3D94C90", VA = "0x183D96090")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D958B0", Offset = "0x3D944B0", VA = "0x183D958B0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D94C40", Offset = "0x3D93840", VA = "0x183D94C40")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D93A50", Offset = "0x3D92650", VA = "0x183D93A50")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D92B80", Offset = "0x3D91780", VA = "0x183D92B80")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D92100", Offset = "0x3D90D00", VA = "0x183D92100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F082E0", Offset = "0x7F06EE0", VA = "0x187F082E0", Slot = "93")]
		public void RpcOthers(BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D9AE90", Offset = "0x3D99A90", VA = "0x183D9AE90", Slot = "94")]
		public void RpcOthers<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D9A8F0", Offset = "0x3D994F0", VA = "0x183D9A8F0", Slot = "95")]
		public void RpcOthers<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D9A050", Offset = "0x3D98C50", VA = "0x183D9A050", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D98E80", Offset = "0x3D97A80", VA = "0x183D98E80", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D98730", Offset = "0x3D97330", VA = "0x183D98730", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D981B0", Offset = "0x3D96DB0", VA = "0x183D981B0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D975C0", Offset = "0x3D961C0", VA = "0x183D975C0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D96BA0", Offset = "0x3D957A0", VA = "0x183D96BA0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D96440", Offset = "0x3D95040", VA = "0x183D96440", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D954C0", Offset = "0x3D940C0", VA = "0x183D954C0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D94800", Offset = "0x3D93400", VA = "0x183D94800", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D93EE0", Offset = "0x3D92AE0", VA = "0x183D93EE0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3D93070", Offset = "0x3D91C70", VA = "0x183D93070", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D91BC0", Offset = "0x3D907C0", VA = "0x183D91BC0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F07D50", Offset = "0x7F06950", VA = "0x187F07D50", Slot = "108")]
		public void RpcMaster(BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D74280", Offset = "0x3D72E80", VA = "0x183D74280", Slot = "109")]
		public void RpcMaster<T1>(BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D74610", Offset = "0x3D73210", VA = "0x183D74610", Slot = "17")]
		public void RpcMaster<T1, T2>(BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D73FC0", Offset = "0x3D72BC0", VA = "0x183D73FC0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D73C70", Offset = "0x3D72870", VA = "0x183D73C70", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3D77C90", Offset = "0x3D76890", VA = "0x183D77C90", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A060", Offset = "0x3D78C60", VA = "0x183D7A060", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D82A00", Offset = "0x3D81600", VA = "0x183D82A00", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D81E20", Offset = "0x3D80A20", VA = "0x183D81E20", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D80C70", Offset = "0x3D7F870", VA = "0x183D80C70", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D77460", Offset = "0x3D76060", VA = "0x183D77460", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D76090", Offset = "0x3D74C90", VA = "0x183D76090", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D7D0", Offset = "0x3D7C3D0", VA = "0x183D7D7D0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CBC0", Offset = "0x3D7B7C0", VA = "0x183D7CBC0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D7BF50", Offset = "0x3D7AB50", VA = "0x183D7BF50", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F07EE0", Offset = "0x7F06AE0", VA = "0x187F07EE0")]
		public void RpcMaster(BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D74420", Offset = "0x3D73020", VA = "0x183D74420")]
		public void RpcMaster<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D750B0", Offset = "0x3D73CB0", VA = "0x183D750B0")]
		public void RpcMaster<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D74860", Offset = "0x3D73460", VA = "0x183D74860")]
		public void RpcMaster<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D843D0", Offset = "0x3D82FD0", VA = "0x183D843D0")]
		public void RpcMaster<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D786B0", Offset = "0x3D772B0", VA = "0x183D786B0")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D82DA0", Offset = "0x3D819A0", VA = "0x183D82DA0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D82610", Offset = "0x3D81210", VA = "0x183D82610")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3D81580", Offset = "0x3D80180", VA = "0x183D81580")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3D810D0", Offset = "0x3D7FCD0", VA = "0x183D810D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3D802B0", Offset = "0x3D7EEB0", VA = "0x183D802B0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F370", Offset = "0x3D7DF70", VA = "0x183D7F370")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DD40", Offset = "0x3D7C940", VA = "0x183D7DD40")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C590", Offset = "0x3D7B190", VA = "0x183D7C590")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B230", Offset = "0x3D79E30", VA = "0x183D7B230")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F07B10", Offset = "0x7F06710", VA = "0x187F07B10", Slot = "122")]
		public void RpcMaster(BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D86E10", Offset = "0x3D85A10", VA = "0x183D86E10", Slot = "123")]
		public void RpcMaster<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D85E80", Offset = "0x3D84A80", VA = "0x183D85E80", Slot = "124")]
		public void RpcMaster<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3D84BB0", Offset = "0x3D837B0", VA = "0x183D84BB0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3D846B0", Offset = "0x3D832B0", VA = "0x183D846B0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3D83AD0", Offset = "0x3D826D0", VA = "0x183D83AD0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3D83130", Offset = "0x3D81D30", VA = "0x183D83130", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3D82220", Offset = "0x3D80E20", VA = "0x183D82220", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3D819D0", Offset = "0x3D805D0", VA = "0x183D819D0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3D807C0", Offset = "0x3D7F3C0", VA = "0x183D807C0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F8E0", Offset = "0x3D7E4E0", VA = "0x183D7F8E0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E8E0", Offset = "0x3D7D4E0", VA = "0x183D7E8E0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E310", Offset = "0x3D7CF10", VA = "0x183D7E310", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D1A0", Offset = "0x3D7BDA0", VA = "0x183D7D1A0", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B8C0", Offset = "0x3D7A4C0", VA = "0x183D7B8C0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F07960", Offset = "0x7F06560", VA = "0x187F07960", Slot = "137")]
		public void RpcAuthority(BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3D64200", Offset = "0x3D62E00", VA = "0x183D64200", Slot = "138")]
		public void RpcAuthority<T1>(BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3D653B0", Offset = "0x3D63FB0", VA = "0x183D653B0", Slot = "139")]
		public void RpcAuthority<T1, T2>(BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3D65B60", Offset = "0x3D64760", VA = "0x183D65B60", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3D65080", Offset = "0x3D63C80", VA = "0x183D65080", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3D63E00", Offset = "0x3D62A00", VA = "0x183D63E00", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3D66F60", Offset = "0x3D65B60", VA = "0x183D66F60", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3D66BA0", Offset = "0x3D657A0", VA = "0x183D66BA0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3D72D00", Offset = "0x3D71900", VA = "0x183D72D00", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3D72430", Offset = "0x3D71030", VA = "0x183D72430", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3D70BA0", Offset = "0x3D6F7A0", VA = "0x183D70BA0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3D70670", Offset = "0x3D6F270", VA = "0x183D70670", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3D6BD20", Offset = "0x3D6A920", VA = "0x183D6BD20", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DDF0", Offset = "0x3D6C9F0", VA = "0x183D6DDF0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D160", Offset = "0x3D6BD60", VA = "0x183D6D160", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7F07710", Offset = "0x7F06310", VA = "0x187F07710")]
		public void RpcAuthority(BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3D69E20", Offset = "0x3D68A20", VA = "0x183D69E20")]
		public void RpcAuthority<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3D695C0", Offset = "0x3D681C0", VA = "0x183D695C0")]
		public void RpcAuthority<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3D690D0", Offset = "0x3D67CD0", VA = "0x183D690D0")]
		public void RpcAuthority<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3D68640", Offset = "0x3D67240", VA = "0x183D68640")]
		public void RpcAuthority<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3D67D10", Offset = "0x3D66910", VA = "0x183D67D10")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3D672B0", Offset = "0x3D65EB0", VA = "0x183D672B0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3D667A0", Offset = "0x3D653A0", VA = "0x183D667A0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3D728A0", Offset = "0x3D714A0", VA = "0x183D728A0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3D71AB0", Offset = "0x3D706B0", VA = "0x183D71AB0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3D71590", Offset = "0x3D70190", VA = "0x183D71590")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3D700F0", Offset = "0x3D6ECF0", VA = "0x183D700F0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F590", Offset = "0x3D6E190", VA = "0x183D6F590")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D7B0", Offset = "0x3D6C3B0", VA = "0x183D6D7B0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C420", Offset = "0x3D6B020", VA = "0x183D6C420")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7F074B0", Offset = "0x7F060B0", VA = "0x187F074B0", Slot = "152")]
		public void RpcAuthority(BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A180", Offset = "0x3D68D80", VA = "0x183D6A180", Slot = "153")]
		public void RpcAuthority<T1>(BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3D699D0", Offset = "0x3D685D0", VA = "0x183D699D0", Slot = "154")]
		public void RpcAuthority<T1, T2>(BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3D68C20", Offset = "0x3D67820", VA = "0x183D68C20", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3D68930", Offset = "0x3D67530", VA = "0x183D68930", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3D68060", Offset = "0x3D66C60", VA = "0x183D68060", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3D67660", Offset = "0x3D66260", VA = "0x183D67660", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3D663A0", Offset = "0x3D64FA0", VA = "0x183D663A0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3D73110", Offset = "0x3D71D10", VA = "0x183D73110", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3D71F70", Offset = "0x3D70B70", VA = "0x183D71F70", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3D71070", Offset = "0x3D6FC70", VA = "0x183D71070", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3D6FB70", Offset = "0x3D6E770", VA = "0x183D6FB70", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3D6EFB0", Offset = "0x3D6DBB0", VA = "0x183D6EFB0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E3E0", Offset = "0x3D6CFE0", VA = "0x183D6E3E0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CAC0", Offset = "0x3D6B6C0", VA = "0x183D6CAC0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7F08990", Offset = "0x7F07590", VA = "0x187F08990", Slot = "18")]
		public void RpcPlayer(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9B570", Offset = "0x3D9A170", VA = "0x183D9B570", Slot = "19")]
		public void RpcPlayer<T1>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9BF50", Offset = "0x3D9AB50", VA = "0x183D9BF50", Slot = "20")]
		public void RpcPlayer<T1, T2>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9B970", Offset = "0x3D9A570", VA = "0x183D9B970", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1680", Offset = "0x3DA0280", VA = "0x183DA1680", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2CD0", Offset = "0x3DA18D0", VA = "0x183DA2CD0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2870", Offset = "0x3DA1470", VA = "0x183DA2870", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3DA30B0", Offset = "0x3DA1CB0", VA = "0x183DA30B0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3DA3570", Offset = "0x3DA2170", VA = "0x183DA3570", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3DAA580", Offset = "0x3DA9180", VA = "0x183DAA580", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3DA96F0", Offset = "0x3DA82F0", VA = "0x183DA96F0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJCCECIKIFB NEOGODNGJJE, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1A10", Offset = "0x3DA0610", VA = "0x183DA1A10", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJCCECIKIFB NEOGODNGJJE, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7690", Offset = "0x3DA6290", VA = "0x183DA7690", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BJCCECIKIFB NEOGODNGJJE, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3DA5800", Offset = "0x3DA4400", VA = "0x183DA5800", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BJCCECIKIFB NEOGODNGJJE, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4410", Offset = "0x3DA3010", VA = "0x183DA4410", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BJCCECIKIFB NEOGODNGJJE, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7F08B90", Offset = "0x7F07790", VA = "0x187F08B90")]
		public void RpcPlayer(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3D9B740", Offset = "0x3D9A340", VA = "0x183D9B740")]
		public void RpcPlayer<T1>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FAE0", Offset = "0x3D9E6E0", VA = "0x183D9FAE0")]
		public void RpcPlayer<T1, T2>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE570", Offset = "0x3DAD170", VA = "0x183DAE570")]
		public void RpcPlayer<T1, T2, T3>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3DADA70", Offset = "0x3DAC670", VA = "0x183DADA70")]
		public void RpcPlayer<T1, T2, T3, T4>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3DAD470", Offset = "0x3DAC070", VA = "0x183DAD470")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3DAC330", Offset = "0x3DAAF30", VA = "0x183DAC330")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3DABF10", Offset = "0x3DAAB10", VA = "0x183DABF10")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3DAB2B0", Offset = "0x3DA9EB0", VA = "0x183DAB2B0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3DAA0B0", Offset = "0x3DA8CB0", VA = "0x183DAA0B0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BJCCECIKIFB NEOGODNGJJE, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3DA8C90", Offset = "0x3DA7890", VA = "0x183DA8C90")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJCCECIKIFB NEOGODNGJJE, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3DA8700", Offset = "0x3DA7300", VA = "0x183DA8700")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJCCECIKIFB NEOGODNGJJE, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6AB0", Offset = "0x3DA56B0", VA = "0x183DA6AB0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BJCCECIKIFB NEOGODNGJJE, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6460", Offset = "0x3DA5060", VA = "0x183DA6460")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BJCCECIKIFB NEOGODNGJJE, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4A80", Offset = "0x3DA3680", VA = "0x183DA4A80")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BJCCECIKIFB NEOGODNGJJE, IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7F086D0", Offset = "0x7F072D0", VA = "0x187F086D0", Slot = "176")]
		public void RpcPlayer(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DB20", Offset = "0x3D9C720", VA = "0x183D9DB20", Slot = "177")]
		public void RpcPlayer<T1>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C530", Offset = "0x3D9B130", VA = "0x183D9C530", Slot = "24")]
		public void RpcPlayer<T1, T2>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C1C0", Offset = "0x3D9ADC0", VA = "0x183D9C1C0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2110", Offset = "0x3DA0D10", VA = "0x183DA2110", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3DACE10", Offset = "0x3DABA10", VA = "0x183DACE10", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3DAC6F0", Offset = "0x3DAB2F0", VA = "0x183DAC6F0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3DAB730", Offset = "0x3DAA330", VA = "0x183DAB730", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3DAAE30", Offset = "0x3DA9A30", VA = "0x183DAAE30", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(BJCCECIKIFB NEOGODNGJJE, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3DA9BE0", Offset = "0x3DA87E0", VA = "0x183DA9BE0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BJCCECIKIFB NEOGODNGJJE, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3DA91C0", Offset = "0x3DA7DC0", VA = "0x183DA91C0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJCCECIKIFB NEOGODNGJJE, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7C30", Offset = "0x3DA6830", VA = "0x183DA7C30", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJCCECIKIFB NEOGODNGJJE, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3DA70A0", Offset = "0x3DA5CA0", VA = "0x183DA70A0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BJCCECIKIFB NEOGODNGJJE, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3DA5E10", Offset = "0x3DA4A10", VA = "0x183DA5E10", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BJCCECIKIFB NEOGODNGJJE, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3DA5140", Offset = "0x3DA3D40", VA = "0x183DA5140", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BJCCECIKIFB NEOGODNGJJE, IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7F06990", Offset = "0x7F05590", VA = "0x187F06990", Slot = "189")]
		public void RpcAllBuffered(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3D40850", Offset = "0x3D3F450", VA = "0x183D40850", Slot = "190")]
		public void RpcAllBuffered<T1>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3D402E0", Offset = "0x3D3EEE0", VA = "0x183D402E0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3D3FDA0", Offset = "0x3D3E9A0", VA = "0x183D3FDA0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3FB90", Offset = "0x3D3E790", VA = "0x183D3FB90", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F2D0", Offset = "0x3D3DED0", VA = "0x183D3F2D0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3EDE0", Offset = "0x3D3D9E0", VA = "0x183D3EDE0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E2C0", Offset = "0x3D3CEC0", VA = "0x183D3E2C0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DC90", Offset = "0x3D3C890", VA = "0x183D3DC90", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D280", Offset = "0x3D3BE80", VA = "0x183D3D280", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3D3BFC0", Offset = "0x3D3ABC0", VA = "0x183D3BFC0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LIGOOAGMMLF DODIPMJHLNC, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3D3BB90", Offset = "0x3D3A790", VA = "0x183D3BB90", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LIGOOAGMMLF DODIPMJHLNC, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3D3AEB0", Offset = "0x3D39AB0", VA = "0x183D3AEB0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LIGOOAGMMLF DODIPMJHLNC, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3D39C10", Offset = "0x3D38810", VA = "0x183D39C10", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LIGOOAGMMLF DODIPMJHLNC, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3D38D00", Offset = "0x3D37900", VA = "0x183D38D00", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LIGOOAGMMLF DODIPMJHLNC, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7F06AD0", Offset = "0x7F056D0", VA = "0x187F06AD0")]
		public void RpcAllBuffered(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3D40730", Offset = "0x3D3F330", VA = "0x183D40730")]
		public void RpcAllBuffered<T1>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3D405C0", Offset = "0x3D3F1C0", VA = "0x183D405C0")]
		public void RpcAllBuffered<T1, T2>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3D40120", Offset = "0x3D3ED20", VA = "0x183D40120")]
		public void RpcAllBuffered<T1, T2, T3>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F980", Offset = "0x3D3E580", VA = "0x183D3F980")]
		public void RpcAllBuffered<T1, T2, T3, T4>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F520", Offset = "0x3D3E120", VA = "0x183D3F520")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3D3EB40", Offset = "0x3D3D740", VA = "0x183D3EB40")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E5B0", Offset = "0x3D3D1B0", VA = "0x183D3E5B0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D610", Offset = "0x3D3C210", VA = "0x183D3D610")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CEF0", Offset = "0x3D3BAF0", VA = "0x183D3CEF0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LIGOOAGMMLF DODIPMJHLNC, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C780", Offset = "0x3D3B380", VA = "0x183D3C780")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LIGOOAGMMLF DODIPMJHLNC, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B330", Offset = "0x3D39F30", VA = "0x183D3B330")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LIGOOAGMMLF DODIPMJHLNC, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3D3AA30", Offset = "0x3D39630", VA = "0x183D3AA30")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LIGOOAGMMLF DODIPMJHLNC, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3D39740", Offset = "0x3D38340", VA = "0x183D39740")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LIGOOAGMMLF DODIPMJHLNC, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3D39220", Offset = "0x3D37E20", VA = "0x183D39220")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LIGOOAGMMLF DODIPMJHLNC, IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F06A30", Offset = "0x7F05630", VA = "0x187F06A30", Slot = "204")]
		public void RpcAllBuffered(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3D40970", Offset = "0x3D3F570", VA = "0x183D40970", Slot = "205")]
		public void RpcAllBuffered<T1>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3D40450", Offset = "0x3D3F050", VA = "0x183D40450", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3D3FF60", Offset = "0x3D3EB60", VA = "0x183D3FF60", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F770", Offset = "0x3D3E370", VA = "0x183D3F770", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F080", Offset = "0x3D3DC80", VA = "0x183D3F080", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E8A0", Offset = "0x3D3D4A0", VA = "0x183D3E8A0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DFD0", Offset = "0x3D3CBD0", VA = "0x183D3DFD0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D950", Offset = "0x3D3C550", VA = "0x183D3D950", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CB60", Offset = "0x3D3B760", VA = "0x183D3CB60", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LIGOOAGMMLF DODIPMJHLNC, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C3A0", Offset = "0x3D3AFA0", VA = "0x183D3C3A0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LIGOOAGMMLF DODIPMJHLNC, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B760", Offset = "0x3D3A360", VA = "0x183D3B760", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LIGOOAGMMLF DODIPMJHLNC, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A5B0", Offset = "0x3D391B0", VA = "0x183D3A5B0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LIGOOAGMMLF DODIPMJHLNC, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A0E0", Offset = "0x3D38CE0", VA = "0x183D3A0E0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LIGOOAGMMLF DODIPMJHLNC, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3D387E0", Offset = "0x3D373E0", VA = "0x183D387E0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LIGOOAGMMLF DODIPMJHLNC, IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7F081A0", Offset = "0x7F06DA0", VA = "0x187F081A0", Slot = "219")]
		public void RpcOthersBuffered(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OIGOBEBAAHI JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F8A0", Offset = "0x3D8E4A0", VA = "0x183D8F8A0", Slot = "220")]
		public void RpcOthersBuffered<T1>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.NAOJOJDPDND<T1> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F450", Offset = "0x3D8E050", VA = "0x183D8F450", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.JHHAJCLDMMK<T1, T2> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F290", Offset = "0x3D8DE90", VA = "0x183D8F290", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.POHOLNIGHJP<T1, T2, T3> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3D8ED00", Offset = "0x3D8D900", VA = "0x183D8ED00", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, T4> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3D8E1F0", Offset = "0x3D8CDF0", VA = "0x183D8E1F0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, T5> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3D8DA10", Offset = "0x3D8C610", VA = "0x183D8DA10", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, T6> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3D8D430", Offset = "0x3D8C030", VA = "0x183D8D430", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, T7> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CE00", Offset = "0x3D8BA00", VA = "0x183D8CE00", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, T8> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3D8C060", Offset = "0x3D8AC60", VA = "0x183D8C060", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, T9> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B8F0", Offset = "0x3D8A4F0", VA = "0x183D8B8F0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LIGOOAGMMLF DODIPMJHLNC, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A4A0", Offset = "0x3D890A0", VA = "0x183D8A4A0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LIGOOAGMMLF DODIPMJHLNC, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A020", Offset = "0x3D88C20", VA = "0x183D8A020", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LIGOOAGMMLF DODIPMJHLNC, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D888B0", Offset = "0x3D874B0", VA = "0x183D888B0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LIGOOAGMMLF DODIPMJHLNC, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D87E70", Offset = "0x3D86A70", VA = "0x183D87E70", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LIGOOAGMMLF DODIPMJHLNC, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F08240", Offset = "0x7F06E40", VA = "0x187F08240")]
		public void RpcOthersBuffered(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.NAOJOJDPDND<EEIJICMJMPB> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FAE0", Offset = "0x3D8E6E0", VA = "0x183D8FAE0")]
		public void RpcOthersBuffered<T1>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.JHHAJCLDMMK<T1, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F5C0", Offset = "0x3D8E1C0", VA = "0x183D8F5C0")]
		public void RpcOthersBuffered<T1, T2>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.POHOLNIGHJP<T1, T2, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F0D0", Offset = "0x3D8DCD0", VA = "0x183D8F0D0")]
		public void RpcOthersBuffered<T1, T2, T3>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D8E8E0", Offset = "0x3D8D4E0", VA = "0x183D8E8E0")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D8E690", Offset = "0x3D8D290", VA = "0x183D8E690")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D8DCB0", Offset = "0x3D8C8B0", VA = "0x183D8DCB0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D8D140", Offset = "0x3D8BD40", VA = "0x183D8D140")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CAC0", Offset = "0x3D8B6C0", VA = "0x183D8CAC0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, EEIJICMJMPB> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D8BCD0", Offset = "0x3D8A8D0", VA = "0x183D8BCD0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LIGOOAGMMLF DODIPMJHLNC, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B510", Offset = "0x3D8A110", VA = "0x183D8B510")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LIGOOAGMMLF DODIPMJHLNC, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A8D0", Offset = "0x3D894D0", VA = "0x183D8A8D0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LIGOOAGMMLF DODIPMJHLNC, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D89720", Offset = "0x3D88320", VA = "0x183D89720")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LIGOOAGMMLF DODIPMJHLNC, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D89250", Offset = "0x3D87E50", VA = "0x183D89250")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LIGOOAGMMLF DODIPMJHLNC, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D87950", Offset = "0x3D86550", VA = "0x183D87950")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LIGOOAGMMLF DODIPMJHLNC, IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F08100", Offset = "0x7F06D00", VA = "0x187F08100", Slot = "234")]
		public void RpcOthersBuffered(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.NAOJOJDPDND<ALHJKKHMHIP> JHBFLLOMAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F9C0", Offset = "0x3D8E5C0", VA = "0x183D8F9C0", Slot = "235")]
		public void RpcOthersBuffered<T1>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.JHHAJCLDMMK<T1, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F730", Offset = "0x3D8E330", VA = "0x183D8F730", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.POHOLNIGHJP<T1, T2, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EF10", Offset = "0x3D8DB10", VA = "0x183D8EF10", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.HENHPNJAPCF<T1, T2, T3, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EAF0", Offset = "0x3D8D6F0", VA = "0x183D8EAF0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KOJGPJKJDKN<T1, T2, T3, T4, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D8E440", Offset = "0x3D8D040", VA = "0x183D8E440", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.KKNGHPBFODN<T1, T2, T3, T4, T5, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D8DF50", Offset = "0x3D8CB50", VA = "0x183D8DF50", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.CAKPNGPAGLD<T1, T2, T3, T4, T5, T6, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D8D720", Offset = "0x3D8C320", VA = "0x183D8D720", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.OEDBOHDKONJ<T1, T2, T3, T4, T5, T6, T7, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D8C780", Offset = "0x3D8B380", VA = "0x183D8C780", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LIGOOAGMMLF DODIPMJHLNC, BKJPEGONPKE.PPMONKJBFDH<T1, T2, T3, T4, T5, T6, T7, T8, ALHJKKHMHIP> JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D8C3F0", Offset = "0x3D8AFF0", VA = "0x183D8C3F0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LIGOOAGMMLF DODIPMJHLNC, LJHFJEDEFAF JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B130", Offset = "0x3D89D30", VA = "0x183D8B130", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LIGOOAGMMLF DODIPMJHLNC, NMLHMEMFLDK JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D8AD00", Offset = "0x3D89900", VA = "0x183D8AD00", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LIGOOAGMMLF DODIPMJHLNC, GALBDDFKPJD JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D89BA0", Offset = "0x3D887A0", VA = "0x183D89BA0", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LIGOOAGMMLF DODIPMJHLNC, CIJOALMHAGB JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D88D80", Offset = "0x3D87980", VA = "0x183D88D80", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LIGOOAGMMLF DODIPMJHLNC, JNBPEOOAPOG JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D88390", Offset = "0x3D86F90", VA = "0x183D88390", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LIGOOAGMMLF DODIPMJHLNC, IBPGGDGFFMM JHBFLLOMAIH, T1 POMNCOEIPND, T2 MMJGOENPOIG, T3 IIHEOEJMMOG, T4 IIKJBMGDFOB, T5 NMMKBHBGGEF, T6 MIDJCPCNPCD, T7 OIGGBKFFNIL, T8 EHPIEDOFNBP, T9 KJLPLKNPOPM, T10 FFMPENOCKFK, T11 FNBMDIMNFPD, T12 EJIOEHJEDDB, T13 HMCALMFIJAN, T14 KFIKAGDJPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F04B80", Offset = "0x7F03780", VA = "0x187F04B80", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F04D90", Offset = "0x7F03990", VA = "0x187F04D90", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F5A660", Offset = "0x1F59260", VA = "0x181F5A660")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HFGPMPKNILF
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2F40", Offset = "0x7EF1B40", VA = "0x187EF2F40")]
	private static bool NDFADCGFOGO(ViewId ALPNKEJICNA, [Out] RRNetworkView HBPAMLAADAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0510", Offset = "0x3AAF110", VA = "0x183AB0510")]
	[CanBeNull]
	public static T EBLMOKPFEKB<T>(this ViewId AAHKEEEBFIN)
	{
		return (T)null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class HIGLJJGGMJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public BJCCECIKIFB[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public HIGLJJGGMJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7EF3040", Offset = "0x7EF1C40", VA = "0x187EF3040")]
			internal int CKGCOCJCLOB(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x7EF30C0", Offset = "0x7EF1CC0", VA = "0x187EF30C0")]
			internal void OLCCCGLBJLC(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly JPIBGNDAFKP FAOMHPPHFKM;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static BJCCECIKIFB[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal int BFBPAEKKDPA;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F09B40", Offset = "0x7F08740", VA = "0x187F09B40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A130", Offset = "0x7F08D30", VA = "0x187F0A130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A4E0", Offset = "0x7F090E0", VA = "0x187F0A4E0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A550", Offset = "0x7F09150", VA = "0x187F0A550")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F099E0", Offset = "0x7F085E0", VA = "0x187F099E0")]
		private void GOLAGHDGBFG(BJCCECIKIFB ECKFHGMKBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F099E0", Offset = "0x7F085E0", VA = "0x187F099E0")]
		private void APHFLALCHJB(BJCCECIKIFB PALFCPJOMFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F09F60", Offset = "0x7F08B60", VA = "0x187F09F60")]
		private void GPLDFKCHHDJ(BJCCECIKIFB LKIPHEHMEBC, IDictionary<object, object> GCFDGMCOIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F099F0", Offset = "0x7F085F0", VA = "0x187F099F0")]
		public static void AssignPlayerNumbers(int HMGOJNEDNFJ, int AFGBHPODNID, Func<int, int> MEHBDHDJEEJ, Action<int, int> APHBDLGLCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A5F0", Offset = "0x7F091F0", VA = "0x187F0A5F0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A040", Offset = "0x7F08C40", VA = "0x187F0A040")]
		private void OHKAAJONMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA2E770", Offset = "0xA2D370", VA = "0x180A2E770")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HEMMONNOHGD
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2950", Offset = "0x7EF1550", VA = "0x187EF2950")]
	public static int FNOEABDLFJC(this BJCCECIKIFB NEOGODNGJJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2AF0", Offset = "0x7EF16F0", VA = "0x187EF2AF0")]
	public static void JAGGFHKDGIN(this BJCCECIKIFB NEOGODNGJJE, int IDJIOAKCGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class GGPEMJEENHC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void HJFGDCHPDKP(Hashtable JBCEKMOHDPK);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void FODNADEGHNJ(BJCCECIKIFB NEOGODNGJJE, Hashtable JBCEKMOHDPK);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event HJFGDCHPDKP BONNLAEKALA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7EF25E0", Offset = "0x7EF11E0", VA = "0x187EF25E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7EF23A0", Offset = "0x7EF0FA0", VA = "0x187EF23A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event HJFGDCHPDKP PGEBGKAHFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EF2520", Offset = "0x7EF1120", VA = "0x187EF2520")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7EF26A0", Offset = "0x7EF12A0", VA = "0x187EF26A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event FODNADEGHNJ GGEKOFMBOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7EF2160", Offset = "0x7EF0D60", VA = "0x187EF2160")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EF2220", Offset = "0x7EF0E20", VA = "0x187EF2220")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event FODNADEGHNJ KHOHLNNEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7EF22E0", Offset = "0x7EF0EE0", VA = "0x187EF22E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7EF2460", Offset = "0x7EF1060", VA = "0x187EF2460")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class KKLMFNMPCEG
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int MBCKJBMKGGK;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int ACDPNBDBMDB;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int MMENIJLIFHF;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EF87F0", Offset = "0x7EF73F0", VA = "0x187EF87F0")]
	public static void LIEIKBMNJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8AE0", Offset = "0x7EF76E0", VA = "0x187EF8AE0")]
	public static void OKFKJIJAANF(int[] POAFAAKKFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8840", Offset = "0x7EF7440", VA = "0x187EF8840")]
	public static int OGJFFLIFALJ(int EKIGNNMMAGN, bool NAGNFCNNHLH = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(GGIOADNLMJC), new string[] { })]
public class GGIOADNLMJC : CFLNMGDONAH, LOEJKIHMCMK, IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable OJPJDEIJALE;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable DMCJELLFJMK;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly Hashtable CALGAAFMDJJ;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly MNMNIMLOHNO OCKHMAOJKCB;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly MNMNIMLOHNO OIKLNLDCEHD;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly MNMNIMLOHNO DLMIDPKEAHP;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly MNMNIMLOHNO ELBKLOOHEDH;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly MNMNIMLOHNO FCKGOPLPGKK;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int KNCCGEIDHDB;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1C70", Offset = "0x7EF0870", VA = "0x187EF1C70", Slot = "18")]
	public void NHFNFEMINKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0840", Offset = "0x7EEF440", VA = "0x187EF0840", Slot = "19")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1B40", Offset = "0x7EF0740", VA = "0x187EF1B40", Slot = "4")]
	public bool MDFDPGNPEKC(NDDCFJANKJC GALEDNLDGCG, bool OJLJECBIFIL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7EEFAB0", Offset = "0x7EEE6B0", VA = "0x187EEFAB0", Slot = "5")]
	public int CKIDIFKLCJP(NDDCFJANKJC[] JHOOCHMKOKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1D10", Offset = "0x7EF0910", VA = "0x187EF1D10", Slot = "6")]
	public bool PFNMBGEDKMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7EF19B0", Offset = "0x7EF05B0", VA = "0x187EF19B0", Slot = "7")]
	public bool LFFBHNLIBNB(int AAHKEEEBFIN, int NDOFFKPGGGL, bool GNPAFCOHFCF, GameObject AOALCMHDOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7EF04F0", Offset = "0x7EEF0F0", VA = "0x187EF04F0", Slot = "8")]
	public void EHHLGFJMKNA(int NDOFFKPGGGL, [Optional] int? MAKEDDDKONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0A00", Offset = "0x7EEF600", VA = "0x187EF0A00", Slot = "9")]
	public bool HKKPNCBFNBH(DCFDGGPHAAA AGFKEDPOHKE, [Out] NDDCFJANKJC PPAMKBDJJMD, bool KICPDGOPEBG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1250", Offset = "0x7EEFE50", VA = "0x187EF1250", Slot = "10")]
	public bool IBJILNFBCLK(DCFDGGPHAAA AGFKEDPOHKE, [Out] int IEEKKBEHDNA, [Out] NDDCFJANKJC[] JHOOCHMKOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF08E0", Offset = "0x7EEF4E0", VA = "0x187EF08E0", Slot = "11")]
	public bool HIJDMMILPBM(DCFDGGPHAAA AGFKEDPOHKE, [Out] int NDOFFKPGGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7EF16B0", Offset = "0x7EF02B0", VA = "0x187EF16B0", Slot = "12")]
	public void KINPKLDFBLF(DCFDGGPHAAA AGFKEDPOHKE, [Out] int GAHNODEBMNM, [Out] int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7EF06E0", Offset = "0x7EEF2E0", VA = "0x187EF06E0", Slot = "13")]
	public void EKMDKEBBPDA(int IEEKKBEHDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1890", Offset = "0x7EF0490", VA = "0x187EF1890", Slot = "14")]
	public void LCBDPLHMJEK(int IEEKKBEHDNA, int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1600", Offset = "0x7EF0200", VA = "0x187EF1600", Slot = "15")]
	public void KAHBGKEHEOD(int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1530", Offset = "0x7EF0130", VA = "0x187EF1530", Slot = "16")]
	public void JEGHPHLDHNG(int[] BAMKCCLLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7EEFF50", Offset = "0x7EEEB50", VA = "0x187EEFF50", Slot = "17")]
	public void DLAHJIMBOJA(int IEEKKBEHDNA, int NDOFFKPGGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7EF00C0", Offset = "0x7EEECC0", VA = "0x187EF00C0")]
	private static void EBJEOMFECJM(NDDCFJANKJC GALEDNLDGCG, Hashtable CGHGFOJCMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0B70", Offset = "0x7EEF770", VA = "0x187EF0B70")]
	private static bool HKKPNCBFNBH(Hashtable CGHGFOJCMCG, BJCCECIKIFB OMPONBMFDOL, [Out] NDDCFJANKJC PPAMKBDJJMD, bool KICPDGOPEBG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1DA0", Offset = "0x7EF09A0", VA = "0x187EF1DA0")]
	private static bool PLKBILDKIDC(int NDOFFKPGGGL, NDDCFJANKJC CGHGFOJCMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7EEFE70", Offset = "0x7EEEA70", VA = "0x187EEFE70")]
	private static int CPHINBPPKFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GGIOADNLMJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(KKCACPALKIF), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KKCACPALKIF : AHDLBEDIMLO, LOEJKIHMCMK, IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable OGLDMBGJONM;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static Hashtable IHKCEOHMPEM;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static MNMNIMLOHNO NHFEFBCMBCB;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly MNMNIMLOHNO CCCCNGEAPKB;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7B20", Offset = "0x7EF6720", VA = "0x187EF7B20", Slot = "8")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8260", Offset = "0x7EF6E60", VA = "0x187EF8260", Slot = "7")]
	public void NHFNFEMINKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7BC0", Offset = "0x7EF67C0", VA = "0x187EF7BC0", Slot = "4")]
	public void HOPALJPBDJG(ViewId AAHKEEEBFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8300", Offset = "0x7EF6F00", VA = "0x187EF8300", Slot = "5")]
	public bool OCDEPDOLPED(DCFDGGPHAAA AGFKEDPOHKE, [Out] ViewId AAHKEEEBFIN, [Out] string NIFKIJKMLPJ, [Out] int IACMPFGGOIA, [Out] object[] HNMKHBLHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7CB0", Offset = "0x7EF68B0", VA = "0x187EF7CB0", Slot = "6")]
	public void KLLOBPNGCLH(ViewId HBPAMLAADAH, string NIFKIJKMLPJ, NHCAOAMKGNN PJDNJJKGMDP, BJCCECIKIFB NEOGODNGJJE, PAENKPGAGKC JNDMJJHAJKH, object[] GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public KKCACPALKIF()
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
