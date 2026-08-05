using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x834B440", Offset = "0x8349C40", VA = "0x18834B440", Slot = "4")]
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
namespace _AssemblyRegistry.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8351120", Offset = "0x834F920", VA = "0x188351120", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FLDJPBAHJJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly EGOPMJOJPDK CMDKGDEHAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte CEPGAJKBPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid LOEJBFFHLNB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x834AC60", Offset = "0x8349460", VA = "0x18834AC60")]
	public FLDJPBAHJJH(EGOPMJOJPDK CMDKGDEHAFG, byte CEPGAJKBPDM, Guid LOEJBFFHLNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task NDDLKPKFGHA(HDBLPJBDELH JALDLFHONHH, CancellationToken GMEAHOBHMAD);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class HDBLPJBDELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GCBHLCMINDE CHOKDPOPFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, KCDFJLGNJKD)> HGEIPHJJMMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public APAMIKOGBPP IJFLOGGAFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public NKDJCGCAECB FBCFMGKJDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KKEKPLKDMHL EIJHGBKIIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<KKEKPLKDMHL> HKCBNGBLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<KKEKPLKDMHL> CFOBHHHEAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EIJMMJGEKKD HDEHOGEDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		[CompilerGenerated]
		get
		{
			return default(EIJMMJGEKKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public PCENONMPPIA KFBGBJHPMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LPIFEJNCBGG MBPFFFMKIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<FLDJPBAHJJH> KCHKACOIFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IIIOFLMBLND DAKDONGJKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MOHACJCPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x834B060", Offset = "0x8349860", VA = "0x18834B060")]
	public HDBLPJBDELH(APAMIKOGBPP DHKAOBLPBCI, NKDJCGCAECB BKAEBHHHGHD, KKEKPLKDMHL ODLKEAOAINI, IReadOnlyList<KKEKPLKDMHL> BGBLBNEIBKA, IReadOnlyList<KKEKPLKDMHL> HNOHGBGIEEF, EIJMMJGEKKD EFPILEMLAPL, bool MAEIMFILDED, PCENONMPPIA JPCNIAHCHAA, LPIFEJNCBGG NNOJLKJDGHO, IEnumerable<FLDJPBAHJJH> JDAKJOCCBMJ, IIIOFLMBLND ONFNEGMHBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x834B040", Offset = "0x8349840", VA = "0x18834B040")]
	public void NKBPACPLAGJ(GCBHLCMINDE BGAEFBGMPJH, List<(PersistenceView, KCDFJLGNJKD)> JBLIANBCKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x834AFD0", Offset = "0x83497D0", VA = "0x18834AFD0")]
	public List<(PersistenceView, KCDFJLGNJKD)> JHLEJOIKDKB(GCBHLCMINDE HFGGMCFFMCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DKLOHHBNKIG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KPMJFDCAFMO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[CFGGLIFLDBH]
public enum GCBHLCMINDE
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	NOT_STARTED = 0,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DOWNLOADING_DETAILS = 1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DETAILS_DOWNLOADED = 2,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DOWNLOADING_DATA = 3,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DATA_DOWNLOADED = 4,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	SCENE_LOADED = 5,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	SETUP_ROOM_OBJECTS = 7,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RUN_MIGRATIONS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	PRE_DESTROY_OLD_OBJECTS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	POST_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	DESERIALIZE_SETTINGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PRE_INSTANTIATE_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	POST_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	PRE_DESERIALIZE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DESERIALIZE_CONNECTABLES = 15,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	POST_DESERIALIZE_OBJECTS = 16,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	DESERIALIZE_OBJECTS_COMPLETE = 17,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	PRE_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	COMPLETE = 19
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GCBLKAHKCKN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KKEKPLKDMHL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid LABAJPNFKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> AMMMKDACIJF();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKFNBMFLHAB();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PNDHBNPJGMO(bool GEIDMIOJGBH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PBLELLGFBLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EIJMMJGEKKD EFPILEMLAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public KCDFJLGNJKD KLFCHOKODFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool FIECDJLAEND;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OMLKBKDLMOE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> HLDNJKMJNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder ECOCMLPNFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DKOPFDILECI OBHICHFCOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int OMFFEJEAEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 LKIJLPMPPEN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x834BE70", Offset = "0x834A670", VA = "0x18834BE70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x834BEC0", Offset = "0x834A6C0", VA = "0x18834BEC0")]
	public OMLKBKDLMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BNEOHKBIPGF
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KPICPDCMPDL
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JEOKPFFJCGD : KPICPDCMPDL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BNEOHKBIPGF BFALLGJHEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IBOJONEGFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(PBLELLGFBLP CKMFPBPGIPC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(KCDFJLGNJKD KLFCHOKODFK, OMLKBKDLMOE DKALKIDHLCF, StringBuilder GCBBHNAECKD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MLFHDKFBHIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	BNEOHKBIPGF NGDOHBGJMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(PCENONMPPIA JPCNIAHCHAA, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(PCENONMPPIA JPCNIAHCHAA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ALLOLLCBJKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool FIECDJLAEND;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MLFOLPBFIEG : JEOKPFFJCGD, KPICPDCMPDL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(ALLOLLCBJKI GMDDMEHJEHG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KHPBEGFLHJP : JEOKPFFJCGD, KPICPDCMPDL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(EIJMMJGEKKD EFPILEMLAPL, KCDFJLGNJKD KLFCHOKODFK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GJPFGHHIPCF : KPICPDCMPDL
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder GCBBHNAECKD, KPMJFDCAFMO IENPLAMADNI, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FNBFDEKMNMG
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<AHFDHLNPAAB> JKKOEBNMOPN();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NFCOCCBBNCL(object MJAGIMDGJBK, AHFDHLNPAAB HHPGBAHCBFC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<JEEIKNNKFIG> DLGFIDMJAPI();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, PJJHFEPBJLP
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct ChildViewReference
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int childId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public PersistenceView persistenceView;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void GMDAFNBDEEM(Guid JPAOPFBEKDK, Guid HOIPBCNJCPJ);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class KHHALPPHGNH
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class PFMGEMDMLGB<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : JEOKPFFJCGD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				private T <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				private int <>l__initialThreadId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				private HashSet<JEOKPFFJCGD> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<JEOKPFFJCGD> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<JEOKPFFJCGD>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (T)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
				[DebuggerHidden]
				public PFMGEMDMLGB(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4BA9C00", Offset = "0x4BA8400", VA = "0x184BA9C00", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x58A5F60", Offset = "0x58A4760", VA = "0x1858A5F60", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x58A5F10", Offset = "0x58A4710", VA = "0x1858A5F10")]
				private void EGKKBNFIFOD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x58A6200", Offset = "0x58A4A00", VA = "0x1858A6200", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4BF1F30", Offset = "0x4BF0730", VA = "0x184BF1F30", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4BF22B0", Offset = "0x4BF0AB0", VA = "0x184BF22B0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<JEOKPFFJCGD> EKHOOHFOEFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<JEOKPFFJCGD> CDBOMMKDHLI;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x834B1A0", Offset = "0x83499A0", VA = "0x18834B1A0")]
			public void AAAACGCCEGJ(BNEOHKBIPGF JDGLHNMLCLI, JEOKPFFJCGD LKHCBDOPKEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x834B310", Offset = "0x8349B10", VA = "0x18834B310")]
			private static void CPLBJCOMGFD(HashSet<JEOKPFFJCGD> JOIHPEIKCGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x41501D0", Offset = "0x414E9D0", VA = "0x1841501D0")]
			public IEnumerable<T> MDBOELEOGEC<T>(bool CCBMALPAGCL) where T : JEOKPFFJCGD
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x37FD480", Offset = "0x37FBC80", VA = "0x1837FD480")]
			[IteratorStateMachine(typeof(PFMGEMDMLGB<>))]
			private static IEnumerable<T> ODAHMAJOGBG<T>(HashSet<JEOKPFFJCGD> JOIHPEIKCGH) where T : JEOKPFFJCGD
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public KHHALPPHGNH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class AEMMJPDLIEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public AEMMJPDLIEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x834A020", Offset = "0x8348820", VA = "0x18834A020")]
			internal bool LAMIMADDLLG(CNNJIEIEJOJ d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> PLOGKLHCLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool MKNGOAKCIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private ChildViewReference[] childViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private int highestChildIdAssigned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		public bool explicitlyBlockPersistence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IPMBLMMANMH<Guid> PBKJEIODECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<JEOKPFFJCGD> BAIILLBPLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<GJPFGHHIPCF> LPFGBCNMBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private KHHALPPHGNH HFGGCINEFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid DFLBKBCEKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid FAIBCEFAIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private BFPHHCAGGHH FLHFBOLPAMC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> JIDADLAAKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83509B0", Offset = "0x834F1B0", VA = "0x1883509B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid FIOOAILODJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8350580", Offset = "0x834ED80", VA = "0x188350580")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8350B00", Offset = "0x834F300", VA = "0x188350B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JEKPFIGIEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x13AF740", Offset = "0x13ADF40", VA = "0x1813AF740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x13AF400", Offset = "0x13ADC00", VA = "0x1813AF400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JGMIEAIGIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8350660", Offset = "0x834EE60", VA = "0x188350660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool DEFOECNBKCH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x834D120", Offset = "0x834B920", VA = "0x18834D120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView KHCAHEAGJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HHHDBFKCEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8350610", Offset = "0x834EE10", VA = "0x188350610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool ADHKDEEPHMG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x834D4C0", Offset = "0x834BCC0", VA = "0x18834D4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event GMDAFNBDEEM AENEDFMFGNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x83504D0", Offset = "0x834ECD0", VA = "0x1883504D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8350A50", Offset = "0x834F250", VA = "0x188350A50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x834BF80", Offset = "0x834A780", VA = "0x18834BF80", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x834DD30", Offset = "0x834C530", VA = "0x18834DD30")]
		private bool MMOBDNFDFOL([Out] Guid DFPMDNDBCGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x834E9E0", Offset = "0x834D1E0", VA = "0x18834E9E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x834E5B0", Offset = "0x834CDB0", VA = "0x18834E5B0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x834DE40", Offset = "0x834C640", VA = "0x18834DE40")]
		private void MPHDPECBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x834E9E0", Offset = "0x834D1E0", VA = "0x18834E9E0")]
		private void OnMasterClientSwitched(EIGONBNGIIK OINLJEGCCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x834E4A0", Offset = "0x834CCA0", VA = "0x18834E4A0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x834F370", Offset = "0x834DB70", VA = "0x18834F370")]
		public void PreSerializeAsync(FJODPEEPKJK<Task> EEPLNEMBFJN, StringBuilder GCBBHNAECKD, KPMJFDCAFMO IENPLAMADNI, CancellationToken GMEAHOBHMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x834F7A0", Offset = "0x834DFA0", VA = "0x18834F7A0")]
		public KCDFJLGNJKD Serialize(OMLKBKDLMOE DKALKIDHLCF, StringBuilder GCBBHNAECKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x834D280", Offset = "0x834BA80", VA = "0x18834D280")]
		public void InitializeDeserialization(KCDFJLGNJKD KLFCHOKODFK, bool DLNFOBOIMAL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x834EE60", Offset = "0x834D660", VA = "0x18834EE60")]
		public void PreDeserialize(bool CCBMALPAGCL, EIJMMJGEKKD EFPILEMLAPL, KCDFJLGNJKD KLFCHOKODFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x834C790", Offset = "0x834AF90", VA = "0x18834C790")]
		public void Deserialize(bool CCBMALPAGCL, PBLELLGFBLP CKMFPBPGIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x834E9F0", Offset = "0x834D1F0", VA = "0x18834E9F0")]
		public void PostDeserialize(bool CCBMALPAGCL, ALLOLLCBJKI GMDDMEHJEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x834D530", Offset = "0x834BD30", VA = "0x18834D530")]
		private void LBFPPNCGOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x834CED0", Offset = "0x834B6D0", VA = "0x18834CED0")]
		private KCDFJLGNJKD GCDENAHCCOD(KCDFJLGNJKD DFNFFOAGMAC, ChildViewReference LNFGEICLAJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x834E3E0", Offset = "0x834CBE0", VA = "0x18834E3E0")]
		public void MarkExcludedFromRoomSave(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8350220", Offset = "0x834EA20", VA = "0x188350220")]
		public void UnmarkExcludedFromRoomSave(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x834C5B0", Offset = "0x834ADB0", VA = "0x18834C5B0", Slot = "14")]
		public void Bake(HDJJIILNIDG MJAGIMDGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83503F0", Offset = "0x834EBF0", VA = "0x1883503F0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x834DC60", Offset = "0x834C460", VA = "0x18834DC60")]
		[CompilerGenerated]
		private object LLNBJIEJKAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x834C710", Offset = "0x834AF10", VA = "0x18834C710")]
		[CompilerGenerated]
		private object DLMLHCAANON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x834CE20", Offset = "0x834B620", VA = "0x18834CE20")]
		[CompilerGenerated]
		private object EBEBGFEMCPH()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AHFDHLNPAAB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool HOBFGPNMGAI(HDBLPJBDELH IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FNEMOGPBJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FNEMOGPBJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x834AF30", Offset = "0x8349730", VA = "0x18834AF30")]
		internal Task LPEPEHGALND(HDBLPJBDELH data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LICEMHKPKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<HDBLPJBDELH> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LICEMHKPKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x834B390", Offset = "0x8349B90", VA = "0x18834B390")]
		internal Task LPEPEHGALND(HDBLPJBDELH data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CBMHPGFPLBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GCBLKAHKCKN handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AHFDHLNPAAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CBMHPGFPLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x834A8E0", Offset = "0x83490E0", VA = "0x18834A8E0")]
		internal object GEABFMGEKCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<GCBHLCMINDE, HashSet<(GCBLKAHKCKN, HOBFGPNMGAI, NDDLKPKFGHA)>> GHPNPFONHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid NABEIIJHJMI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x834A840", Offset = "0x8349040", VA = "0x18834A840")]
	public AHFDHLNPAAB(Guid ICKGBHIKCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x834A220", Offset = "0x8348A20", VA = "0x18834A220")]
	public AHFDHLNPAAB CCBMDJKFOEE(GCBHLCMINDE MOEKINEBGPM, GCBLKAHKCKN JDGLHNMLCLI, NDDLKPKFGHA HHPGBAHCBFC, [Optional] HOBFGPNMGAI PJAOPGHOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x834A130", Offset = "0x8348930", VA = "0x18834A130")]
	public AHFDHLNPAAB CCBMDJKFOEE(GCBHLCMINDE MOEKINEBGPM, GCBLKAHKCKN JDGLHNMLCLI, Action HHPGBAHCBFC, [Optional] HOBFGPNMGAI PJAOPGHOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x834A040", Offset = "0x8348840", VA = "0x18834A040")]
	public AHFDHLNPAAB CCBMDJKFOEE(GCBHLCMINDE MOEKINEBGPM, GCBLKAHKCKN JDGLHNMLCLI, Action<HDBLPJBDELH> HHPGBAHCBFC, [Optional] HOBFGPNMGAI PJAOPGHOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x834A460", Offset = "0x8348C60", VA = "0x18834A460")]
	public Dictionary<GCBLKAHKCKN, List<NDDLKPKFGHA>> DBLAJACGLEB(GCBHLCMINDE BGAEFBGMPJH, HDBLPJBDELH IMINNNCPCJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task JEEIKNNKFIG(CancellationToken GMEAHOBHMAD);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class MCGDDIFDEGB : FNBFDEKMNMG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum LNJAGGMLCCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Start,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		LoadingScene,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		LoadingSubScenes,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		LoadingPersistence,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		PersistenceLoadComplete
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class ALEGAJLKDLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class ECPKHFPGNIO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object MJAGIMDGJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly AHFDHLNPAAB HHPGBAHCBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> OFCHIIKMEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool DMJNBPLABAL;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCC0080", Offset = "0xCBE880", VA = "0x180CC0080")]
		public ECPKHFPGNIO(object MJAGIMDGJBK, AHFDHLNPAAB HHPGBAHCBFC, Action<object> OFCHIIKMEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x834A990", Offset = "0x8349190", VA = "0x18834A990", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, AHFDHLNPAAB> KNKAPMOJBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<JEEIKNNKFIG> MJFJIAGCBMG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x834B730", Offset = "0x8349F30", VA = "0x18834B730")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void MNKNDOLBIJB(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x834B6D0", Offset = "0x8349ED0", VA = "0x18834B6D0", Slot = "4")]
	public IReadOnlyList<AHFDHLNPAAB> JKKOEBNMOPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x834B820", Offset = "0x834A020", VA = "0x18834B820", Slot = "5")]
	public IDisposable NFCOCCBBNCL(object MJAGIMDGJBK, AHFDHLNPAAB HHPGBAHCBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x834B5B0", Offset = "0x8349DB0", VA = "0x18834B5B0", Slot = "6")]
	public IReadOnlyList<JEEIKNNKFIG> DLGFIDMJAPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x834B550", Offset = "0x8349D50", VA = "0x18834B550")]
	private void BKACDBOPLBK(object MJAGIMDGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x834B5F0", Offset = "0x8349DF0", VA = "0x18834B5F0")]
	[BDPIALLOKEK]
	internal static void HFKNGLBFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x834B9A0", Offset = "0x834A1A0", VA = "0x18834B9A0")]
	internal static void PBPOAHLKNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x834B4D0", Offset = "0x8349CD0", VA = "0x18834B4D0")]
	internal void AOAALIOHOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x834BB50", Offset = "0x834A350", VA = "0x18834BB50")]
	public MCGDDIFDEGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FCHDOIFJLBE
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<GCBHLCMINDE> BFMJFILONDF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<GCBHLCMINDE> HOGOEEAOCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x834A9D0", Offset = "0x83491D0", VA = "0x18834A9D0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OKNAJCBGHOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct FMHGNGDGLKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public OKNAJCBGHOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x834ACA0", Offset = "0x83494A0", VA = "0x18834ACA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x834AED0", Offset = "0x83496D0", VA = "0x18834AED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float ENNIFLIGLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float IFHICDKEIGN;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x834BE30", Offset = "0x834A630", VA = "0x18834BE30")]
	public OKNAJCBGHOC(float IFHICDKEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x834BD40", Offset = "0x834A540", VA = "0x18834BD40")]
	[AsyncStateMachine(typeof(FMHGNGDGLKM))]
	public Task NHHBMGAJEAG(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x834BD20", Offset = "0x834A520", VA = "0x18834BD20")]
	public void MMBGNLDGDEH()
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
