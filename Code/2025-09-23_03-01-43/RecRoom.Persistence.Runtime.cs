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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88CB530", Offset = "0x88C9B30", VA = "0x1888CB530", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D1A90", Offset = "0x88D0090", VA = "0x1888D1A90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AGJBPKIHOCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LENDKCEJOHO CJFLBKGFCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte GPEIAHGICNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid BKJKAJIMPMA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88CA870", Offset = "0x88C8E70", VA = "0x1888CA870")]
	public AGJBPKIHOCO(LENDKCEJOHO CJFLBKGFCDK, byte GPEIAHGICNA, Guid BKJKAJIMPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task GBOAENKKHOB(GNGDPEPAGOH PNGANGECEEL, CancellationToken PJCIHHKJKBP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class GNGDPEPAGOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MKLCKGDOEAC JIDAHCMINBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, ALMOPHBCAAE)> FLDCGAAGNKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public PCHMDNLFCBM PPHEBILLIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public BNKGKIJFGMN EPBIOANEBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ADAEGODKHMB FPGCAGJNIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<ADAEGODKHMB> FBLJAJGHJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<ADAEGODKHMB> DJNDJAFLOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FJLAJMAFHGO NOCGFHIGDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
		[CompilerGenerated]
		get
		{
			return default(FJLAJMAFHGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public NIDHIPJBPAM MIEMEOPFPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GNEPEFPMAAI MJOELPOKKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<AGJBPKIHOCO> IHHDEAOHMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LFJHBIHLDGN LBNJJLOFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GNKAEOJCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA5550", Offset = "0xAA3B50", VA = "0x180AA5550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x88CB0B0", Offset = "0x88C96B0", VA = "0x1888CB0B0")]
	public GNGDPEPAGOH(PCHMDNLFCBM AGDALPKCCLB, BNKGKIJFGMN LFNCCCDMECL, ADAEGODKHMB OFGJPCOFBCI, IReadOnlyList<ADAEGODKHMB> AENLJNKCCDG, IReadOnlyList<ADAEGODKHMB> DKPLKBNOJHC, FJLAJMAFHGO JNDMAOFPIGP, bool AOEJLGJFCHO, NIDHIPJBPAM PGEPJKBFLOM, GNEPEFPMAAI HCNOJONCMKG, IEnumerable<AGJBPKIHOCO> CPHGKMODKHF, LFJHBIHLDGN EJNADJFLFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88CB090", Offset = "0x88C9690", VA = "0x1888CB090")]
	public void CFGMEANEBJO(MKLCKGDOEAC BHKJMKKCCEJ, List<(PersistenceView, ALMOPHBCAAE)> IINBHIJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88CB020", Offset = "0x88C9620", VA = "0x1888CB020")]
	public List<(PersistenceView, ALMOPHBCAAE)> BBJBOIKBILI(MKLCKGDOEAC ADMMJCNFJHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NPHNBEDBCMG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BPEJAHGIOEG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NLOGEJFOJJC]
public enum MKLCKGDOEAC
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
public enum GGOKKFFBJJB : byte
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
public interface ADAEGODKHMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid MOKHOFHMPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> BBEJMLHELLF();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKBNLEHCBDJ();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHPEHCIBNJI(bool BDLPKOKELDO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ELNODDGDKEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public FJLAJMAFHGO JNDMAOFPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public ALMOPHBCAAE CMEDEPJOKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool OMOAADMIDHJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GNCJIPPPOFA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> GGEJAIDLMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder PCCGPNIJDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public PNPFCICGFAP DDJBLPNFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DBNFNELCDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 NAGAIPPCKKF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88CAF10", Offset = "0x88C9510", VA = "0x1888CAF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88CAF60", Offset = "0x88C9560", VA = "0x1888CAF60")]
	public GNCJIPPPOFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CBPIGAMHDFB
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OFHHHPJGODN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JBBBLNBAMKL : OFHHHPJGODN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CBPIGAMHDFB CIDBMGMBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PKKKDCIABNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(ELNODDGDKEB FNLGLNOOIAB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ALMOPHBCAAE CMEDEPJOKEH, GNCJIPPPOFA JMPFAIMKHGA, StringBuilder LGJJGAMKAAC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GNNGHAMAFGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	CBPIGAMHDFB FBLDNMDDOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(NIDHIPJBPAM PGEPJKBFLOM, CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(NIDHIPJBPAM PGEPJKBFLOM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KKGNPABPNMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool OMOAADMIDHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EJNGPAKCLFP : JBBBLNBAMKL, OFHHHPJGODN
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(KKGNPABPNMH MBOOBAHGGAI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GNJHNCIBBFB : JBBBLNBAMKL, OFHHHPJGODN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(FJLAJMAFHGO JNDMAOFPIGP, ALMOPHBCAAE CMEDEPJOKEH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MCNHBFCHOCE : OFHHHPJGODN
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder LGJJGAMKAAC, BPEJAHGIOEG FFONJMBMEJN, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BIDKKAOMJIC
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<OOIGNHBEBHD> HHMMEAEMKIN();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MNODKHODABJ(object JIFPJFGEAIK, OOIGNHBEBHD KMEJDHBNOCM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<HFPLIFGADFO> PBAIGNEKJGO();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, LAHJHLNIINP
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
		public delegate void NJAMFANPFPP(Guid BKNDAOCEAOB, Guid AIFAGGPBFJN);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class PGGBGGGKHEA
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class AENGPHANPMJ<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : JBBBLNBAMKL
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
				private HashSet<JBBBLNBAMKL> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<JBBBLNBAMKL> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<JBBBLNBAMKL>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
				[DebuggerHidden]
				public AENGPHANPMJ(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x462E1E0", Offset = "0x462C7E0", VA = "0x18462E1E0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x540A880", Offset = "0x5408E80", VA = "0x18540A880", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x540A830", Offset = "0x5408E30", VA = "0x18540A830")]
				private void MPMIGDGBFBN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x540AB10", Offset = "0x5409110", VA = "0x18540AB10", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x508C500", Offset = "0x508AB00", VA = "0x18508C500", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x5075420", Offset = "0x5073A20", VA = "0x185075420", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<JBBBLNBAMKL> CLFEOAHPLGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<JBBBLNBAMKL> BPHJIEKLIFK;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88CC6B0", Offset = "0x88CACB0", VA = "0x1888CC6B0")]
			public void NJENLCGEOOK(CBPIGAMHDFB CHMLNGLIGAF, JBBBLNBAMKL GECHDLHIHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x88CC630", Offset = "0x88CAC30", VA = "0x1888CC630")]
			private static void LCKBNNOJKMJ(HashSet<JBBBLNBAMKL> ADHFKKAKOCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x44EF6A0", Offset = "0x44EDCA0", VA = "0x1844EF6A0")]
			public IEnumerable<T> GJDMEHCMMAL<T>(bool NALANKJBCNI) where T : JBBBLNBAMKL
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3D09C60", Offset = "0x3D08260", VA = "0x183D09C60")]
			[IteratorStateMachine(typeof(AENGPHANPMJ<>))]
			private static IEnumerable<T> NJCIGCGDPIH<T>(HashSet<JBBBLNBAMKL> ADHFKKAKOCE) where T : JBBBLNBAMKL
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public PGGBGGGKHEA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class AKNLNKLAAIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public AKNLNKLAAIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x88CA8B0", Offset = "0x88C8EB0", VA = "0x1888CA8B0")]
			internal bool ABKPOKBJLHK(PJABOJPECMA d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> JPPCCAHFHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool BKBLCCJIAIM;

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
		private PMBMFMAHILG<Guid> BAEIBBAOOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<JBBBLNBAMKL> LDLOLPOILBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<MCNHBFCHOCE> HMKIODDJHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PGGBGGGKHEA OHCFAEPDILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid JJDGFADLLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid PEOOELDECMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PBCNGJENIAB GHICPNIECIG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> KAIKIHIDPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x88D1300", Offset = "0x88CF900", VA = "0x1888D1300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid HMNNHOPLICJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x88D0EC0", Offset = "0x88CF4C0", VA = "0x1888D0EC0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x88D1450", Offset = "0x88CFA50", VA = "0x1888D1450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FDEDMNEABEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x15C0AB0", Offset = "0x15BF0B0", VA = "0x1815C0AB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x15C0360", Offset = "0x15BE960", VA = "0x1815C0360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BPFPFLLMDNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x88D0FA0", Offset = "0x88CF5A0", VA = "0x1888D0FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool PINMPBDCKFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x88CD7E0", Offset = "0x88CBDE0", VA = "0x1888CD7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView HELJOLHIBNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IKEPMFPGOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x88D0F50", Offset = "0x88CF550", VA = "0x1888D0F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool JGLHHPMKMCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88CC820", Offset = "0x88CAE20", VA = "0x1888CC820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NJAMFANPFPP AEDOPFJEPNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x88D0E10", Offset = "0x88CF410", VA = "0x1888D0E10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x88D13A0", Offset = "0x88CF9A0", VA = "0x1888D13A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88CC890", Offset = "0x88CAE90", VA = "0x1888CC890", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88CD6D0", Offset = "0x88CBCD0", VA = "0x1888CD6D0")]
		private bool EBCEGEGGJFJ([Out] Guid LKKANMHMENJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88CECB0", Offset = "0x88CD2B0", VA = "0x1888CECB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88CE870", Offset = "0x88CCE70", VA = "0x1888CE870", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88CED40", Offset = "0x88CD340", VA = "0x1888CED40")]
		private void PODIDIMGHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88CECB0", Offset = "0x88CD2B0", VA = "0x1888CECB0")]
		private void OnMasterClientSwitched(MEINMPIOLGA AGIMJJDFEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88CE430", Offset = "0x88CCA30", VA = "0x1888CE430")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88CFC80", Offset = "0x88CE280", VA = "0x1888CFC80")]
		public void PreSerializeAsync(BEHKKOBPFOO<Task> BLACKNGJAMD, StringBuilder LGJJGAMKAAC, BPEJAHGIOEG FFONJMBMEJN, CancellationToken PJCIHHKJKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88D00C0", Offset = "0x88CE6C0", VA = "0x1888D00C0")]
		public ALMOPHBCAAE Serialize(GNCJIPPPOFA JMPFAIMKHGA, StringBuilder LGJJGAMKAAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88CD940", Offset = "0x88CBF40", VA = "0x1888CD940")]
		public void InitializeDeserialization(ALMOPHBCAAE CMEDEPJOKEH, bool LABGOPDNDJE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88CF770", Offset = "0x88CDD70", VA = "0x1888CF770")]
		public void PreDeserialize(bool NALANKJBCNI, FJLAJMAFHGO JNDMAOFPIGP, ALMOPHBCAAE CMEDEPJOKEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88CD040", Offset = "0x88CB640", VA = "0x1888CD040")]
		public void Deserialize(bool NALANKJBCNI, ELNODDGDKEB FNLGLNOOIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88CF300", Offset = "0x88CD900", VA = "0x1888CF300")]
		public void PostDeserialize(bool NALANKJBCNI, KKGNPABPNMH MBOOBAHGGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88CDB80", Offset = "0x88CC180", VA = "0x1888CDB80")]
		private void KPCJMJLOHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x88CE540", Offset = "0x88CCB40", VA = "0x1888CE540")]
		private ALMOPHBCAAE ODOEBJHDAHP(ALMOPHBCAAE KOADGKBIIID, ChildViewReference PEKDBPKONMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88CE360", Offset = "0x88CC960", VA = "0x1888CE360")]
		public void MarkExcludedFromRoomSave(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88D0B40", Offset = "0x88CF140", VA = "0x1888D0B40")]
		public void UnmarkExcludedFromRoomSave(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88CCED0", Offset = "0x88CB4D0", VA = "0x1888CCED0", Slot = "14")]
		public void Bake(AIJJICHNHLM JIFPJFGEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88D0D20", Offset = "0x88CF320", VA = "0x1888D0D20")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88CE790", Offset = "0x88CCD90", VA = "0x1888CE790")]
		[CompilerGenerated]
		private object OLJDIJBDNGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88CECC0", Offset = "0x88CD2C0", VA = "0x1888CECC0")]
		[CompilerGenerated]
		private object PABFHIACDGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x88CE2B0", Offset = "0x88CC8B0", VA = "0x1888CE2B0")]
		[CompilerGenerated]
		private object LMKMNFABDPD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OOIGNHBEBHD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool HAOBHFMFHGM(GNGDPEPAGOH CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CBJNBGACNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CBJNBGACNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88CA8D0", Offset = "0x88C8ED0", VA = "0x1888CA8D0")]
		internal Task CICIGOJJDPM(GNGDPEPAGOH data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LONOJANCBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<GNGDPEPAGOH> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LONOJANCBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88CB480", Offset = "0x88C9A80", VA = "0x1888CB480")]
		internal Task CICIGOJJDPM(GNGDPEPAGOH data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EPFHEAOGIGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GGOKKFFBJJB handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OOIGNHBEBHD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public EPFHEAOGIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x88CAAC0", Offset = "0x88C90C0", VA = "0x1888CAAC0")]
		internal object HPIDLODDFDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<MKLCKGDOEAC, HashSet<(GGOKKFFBJJB, HAOBHFMFHGM, GBOAENKKHOB)>> BIKKJBKFNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid MAECPJAJEND;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x88CC590", Offset = "0x88CAB90", VA = "0x1888CC590")]
	public OOIGNHBEBHD(Guid FPGEEIBILBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x88CC340", Offset = "0x88CA940", VA = "0x1888CC340")]
	public OOIGNHBEBHD NCMIHLHGIEC(MKLCKGDOEAC IOFIFDFNIHJ, GGOKKFFBJJB CHMLNGLIGAF, GBOAENKKHOB KMEJDHBNOCM, [Optional] HAOBHFMFHGM DMMGJCACPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x88CC160", Offset = "0x88CA760", VA = "0x1888CC160")]
	public OOIGNHBEBHD NCMIHLHGIEC(MKLCKGDOEAC IOFIFDFNIHJ, GGOKKFFBJJB CHMLNGLIGAF, Action KMEJDHBNOCM, [Optional] HAOBHFMFHGM DMMGJCACPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88CC250", Offset = "0x88CA850", VA = "0x1888CC250")]
	public OOIGNHBEBHD NCMIHLHGIEC(MKLCKGDOEAC IOFIFDFNIHJ, GGOKKFFBJJB CHMLNGLIGAF, Action<GNGDPEPAGOH> KMEJDHBNOCM, [Optional] HAOBHFMFHGM DMMGJCACPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x88CBD70", Offset = "0x88CA370", VA = "0x1888CBD70")]
	public Dictionary<GGOKKFFBJJB, List<GBOAENKKHOB>> LPLAPJHPJFH(MKLCKGDOEAC BHKJMKKCCEJ, GNGDPEPAGOH CDDIADBJAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task HFPLIFGADFO(CancellationToken PJCIHHKJKBP);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class OMGFMCKFBOK : BIDKKAOMJIC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum KBJKKAMOEJM
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
	private class JOFOAPLJACP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class MCOEAFEGBCL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object JIFPJFGEAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly OOIGNHBEBHD KMEJDHBNOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> OAGAMKJJFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool AHFHMNIBLBI;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xDF7730", Offset = "0xDF5D30", VA = "0x180DF7730")]
		public MCOEAFEGBCL(object JIFPJFGEAIK, OOIGNHBEBHD KMEJDHBNOCM, Action<object> OAGAMKJJFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88CB5C0", Offset = "0x88C9BC0", VA = "0x1888CB5C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, OOIGNHBEBHD> OBDEDLLMJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<HFPLIFGADFO> HLLJPJDGMOG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x88CB750", Offset = "0x88C9D50", VA = "0x1888CB750")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void GOLDGDOKEIF(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x88CB850", Offset = "0x88C9E50", VA = "0x1888CB850", Slot = "4")]
	public IReadOnlyList<OOIGNHBEBHD> HHMMEAEMKIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x88CBA70", Offset = "0x88CA070", VA = "0x1888CBA70", Slot = "5")]
	public IDisposable MNODKHODABJ(object JIFPJFGEAIK, OOIGNHBEBHD KMEJDHBNOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88CBBF0", Offset = "0x88CA1F0", VA = "0x1888CBBF0", Slot = "6")]
	public IReadOnlyList<HFPLIFGADFO> PBAIGNEKJGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x88CB8B0", Offset = "0x88C9EB0", VA = "0x1888CB8B0")]
	private void JPKIMECJKMH(object JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x88CB910", Offset = "0x88C9F10", VA = "0x1888CB910")]
	[DIEFPEDLFME]
	internal static void LLCOMIDCGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88CB600", Offset = "0x88C9C00", VA = "0x1888CB600")]
	internal static void CNCNJGCEOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88CB9F0", Offset = "0x88C9FF0", VA = "0x1888CB9F0")]
	internal void MHLAOMLNCPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x88CBCA0", Offset = "0x88CA2A0", VA = "0x1888CBCA0")]
	public OMGFMCKFBOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class GENHAACHIJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<MKLCKGDOEAC> PBPECFJFIBA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<MKLCKGDOEAC> JELJKCDHDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x88CAC70", Offset = "0x88C9270", VA = "0x1888CAC70")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CGCLHGKDIGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct JOLODILCHAL : IAsyncStateMachine
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
		public CGCLHGKDIGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x88CB1F0", Offset = "0x88C97F0", VA = "0x1888CB1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x88CB420", Offset = "0x88C9A20", VA = "0x1888CB420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float OJDIIHAHHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float MMAOJKACNDA;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88CAA80", Offset = "0x88C9080", VA = "0x1888CAA80")]
	public CGCLHGKDIGO(float MMAOJKACNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88CA990", Offset = "0x88C8F90", VA = "0x1888CA990")]
	[AsyncStateMachine(typeof(JOLODILCHAL))]
	public Task KAIMHJOALKH(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x88CA970", Offset = "0x88C8F70", VA = "0x1888CA970")]
	public void JGIFDBJEMCA()
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
