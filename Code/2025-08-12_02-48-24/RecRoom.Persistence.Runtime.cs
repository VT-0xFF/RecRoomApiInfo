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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x882C570", Offset = "0x882AB70", VA = "0x18882C570", Slot = "4")]
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
namespace _AssemblyRegistry.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88322C0", Offset = "0x88308C0", VA = "0x1888322C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LPIINEGMECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PAHCIICKGDL KCMCGNJEFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte EHLAHNIAPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid GFKCOHLNPGF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x882C530", Offset = "0x882AB30", VA = "0x18882C530")]
	public LPIINEGMECD(PAHCIICKGDL KCMCGNJEFKH, byte EHLAHNIAPLD, Guid GFKCOHLNPGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task GDEBONPAJHE(IJFCDEBIONC KGIPMLMDBBA, CancellationToken MEKNAIONNND);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IJFCDEBIONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GGJINCEMEKP KCAGLBHBFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, PDJBJEFMPKL)> MBKBJAKAPEK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public NLKJFHIHAMP NIAEHEDJMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public DPBOCMIBIHD EPGALOKLPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NNIEGAIDOCI GPGEPLOPOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<NNIEGAIDOCI> FJDLOKEJMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<NNIEGAIDOCI> BNDMACFBAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JOBIMPNHPOH FHKELFEOELP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		[CompilerGenerated]
		get
		{
			return default(JOBIMPNHPOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public CIMPCCNCPLH ACCHIFFDGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JJAIMOENMBL KHCINFAEELL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LPIINEGMECD> OFCEAELJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IFOLJBABNMM JNLCGKKGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LPLNNECDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA99370", Offset = "0xA97970", VA = "0x180A99370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x882C310", Offset = "0x882A910", VA = "0x18882C310")]
	public IJFCDEBIONC(NLKJFHIHAMP ICCFMKKBMKK, DPBOCMIBIHD ILHBOHCDIPF, NNIEGAIDOCI FMCANCPOPOM, IReadOnlyList<NNIEGAIDOCI> LEGGFDHFMDL, IReadOnlyList<NNIEGAIDOCI> JDDIBICDMEM, JOBIMPNHPOH OIBFPLAJLLP, bool KKNJNCCALKC, CIMPCCNCPLH CPLJEEOPGOB, JJAIMOENMBL BKDKMMJLKLH, IEnumerable<LPIINEGMECD> POLAHONMFCB, IFOLJBABNMM HJOHNPFLOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x882C280", Offset = "0x882A880", VA = "0x18882C280")]
	public void DMDJKAMKNLH(GGJINCEMEKP PNPFAPEBMMF, List<(PersistenceView, PDJBJEFMPKL)> FCIJCONDEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x882C2A0", Offset = "0x882A8A0", VA = "0x18882C2A0")]
	public List<(PersistenceView, PDJBJEFMPKL)> HCNPOJFLGFP(GGJINCEMEKP AHFPMCPMLDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CLIKKLKMJLK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BHJBHGBPBOH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[FMEECDNJMJA]
public enum GGJINCEMEKP
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
public enum JHHOCBAGFAB : byte
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
public interface NNIEGAIDOCI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid MIGCGALIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> KIKGDHFKDDD();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFGDDOHAPMC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHHHOAMMCDJ(bool FBJAAHNLJCG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JKMMBHCCEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public JOBIMPNHPOH OIBFPLAJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public PDJBJEFMPKL JIAPGANKIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool LLDGOCGKEFJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BOPKMPFPFAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> FMCCPLDDAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder KAGGBDPGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NGJONMHKJMO PJOOCJDIFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int NFLMGHHOLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 NCJHNMPEMDM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x882B9C0", Offset = "0x8829FC0", VA = "0x18882B9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x882BA10", Offset = "0x882A010", VA = "0x18882BA10")]
	public BOPKMPFPFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum DCCOIDIJJPO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LMLOJDHBPJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EHMDDBMJNFG : LMLOJDHBPJP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DCCOIDIJJPO HOPMJCPBBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool LOAEELGDMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(JKMMBHCCEJA PLCEAEOGLPK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(PDJBJEFMPKL JIAPGANKIOL, BOPKMPFPFAL IKHBJPKFLMO, StringBuilder JGGFBCFIKDL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MPCHBCCBJGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DCCOIDIJJPO GMMCGJAIMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(CIMPCCNCPLH CPLJEEOPGOB, CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(CIMPCCNCPLH CPLJEEOPGOB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JJPBGCMDOHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool LLDGOCGKEFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GHECHKFINDI : EHMDDBMJNFG, LMLOJDHBPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(JJPBGCMDOHN EIBECKDBECA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AEEMLJEFOOO : EHMDDBMJNFG, LMLOJDHBPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(JOBIMPNHPOH OIBFPLAJLLP, PDJBJEFMPKL JIAPGANKIOL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BEOINFCLPFM : LMLOJDHBPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder JGGFBCFIKDL, BHJBHGBPBOH LMNHPCAEPKM, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KMNENFMKNHB
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<PPBHMNHJALP> AOAGGODAAJE();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LCPIJALOGBP(object HHPFOCCGJIF, PPBHMNHJALP CACEFGPINFP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<FDLCAABNENP> LDANPJJKOBE();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, NFDMFLCLDKG
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
		public delegate void DJBPDPHOJDA(Guid MEDGJIMLPFE, Guid EPCIJDHIIJH);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class APKPFOADNDC
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class OLLODIEEMEI<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : EHMDDBMJNFG
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
				private HashSet<EHMDDBMJNFG> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<EHMDDBMJNFG> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<EHMDDBMJNFG>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
				[DebuggerHidden]
				public OLLODIEEMEI(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4F1F910", Offset = "0x4F1DF10", VA = "0x184F1F910", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5B8A430", Offset = "0x5B88A30", VA = "0x185B8A430", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5B8A6C0", Offset = "0x5B88CC0", VA = "0x185B8A6C0")]
				private void OFOMAIJNFMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x5B8A710", Offset = "0x5B88D10", VA = "0x185B8A710", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4F9D220", Offset = "0x4F9B820", VA = "0x184F9D220", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4F9D5E0", Offset = "0x4F9BBE0", VA = "0x184F9D5E0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<EHMDDBMJNFG> CEODNKLJEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<EHMDDBMJNFG> DMHPFOANKNP;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x882B070", Offset = "0x8829670", VA = "0x18882B070")]
			public void JEMGKMMNNJF(DCCOIDIJJPO NHDKPDDEAKH, EHMDDBMJNFG FCDHDGHCBGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x882B1E0", Offset = "0x88297E0", VA = "0x18882B1E0")]
			private static void NLPJONMOOOK(HashSet<EHMDDBMJNFG> KJALALPGBHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4493890", Offset = "0x4491E90", VA = "0x184493890")]
			public IEnumerable<T> HFJKEOJBLHI<T>(bool PEPMDIHKPNG) where T : EHMDDBMJNFG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3B8AF80", Offset = "0x3B89580", VA = "0x183B8AF80")]
			[IteratorStateMachine(typeof(OLLODIEEMEI<>))]
			private static IEnumerable<T> KIBJINJLABF<T>(HashSet<EHMDDBMJNFG> KJALALPGBHM) where T : EHMDDBMJNFG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public APKPFOADNDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FNGHFHDFAIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public FNGHFHDFAIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x882BE20", Offset = "0x882A420", VA = "0x18882BE20")]
			internal bool IKAFHIDDAIL(GJOHAICKEGA d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> JJAHNMKCBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool EBKDIKALEDF;

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
		private MNDJHGGFBIF<Guid> NLBJIAOFJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<EHMDDBMJNFG> DHPEAEECDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<BEOINFCLPFM> AFANELGICLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private APKPFOADNDC NFHHNADGOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid LHLCNJNLLOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid PECOPGMAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private JHDOLFBOEBO BCAHMMGBHNA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> GLKJKGMAEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8831B20", Offset = "0x8830120", VA = "0x188831B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid AFPIOPNCMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x88316E0", Offset = "0x882FCE0", VA = "0x1888316E0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8831C70", Offset = "0x8830270", VA = "0x188831C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IELOGDLHNJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1572830", Offset = "0x1570E30", VA = "0x181572830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x15724F0", Offset = "0x1570AF0", VA = "0x1815724F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GLEIAFEAONC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x88317C0", Offset = "0x882FDC0", VA = "0x1888317C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool JCMAOAEMPFN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x882E880", Offset = "0x882CE80", VA = "0x18882E880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView AKDEKCGBMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool EHLGLEJEAKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8831770", Offset = "0x882FD70", VA = "0x188831770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool CMNAMOCGNIC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x882ED40", Offset = "0x882D340", VA = "0x18882ED40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DJBPDPHOJDA EOBINPDFCKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8831630", Offset = "0x882FC30", VA = "0x188831630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8831BC0", Offset = "0x88301C0", VA = "0x188831BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x882D5D0", Offset = "0x882BBD0", VA = "0x18882D5D0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x882EC30", Offset = "0x882D230", VA = "0x18882EC30")]
		private bool JAOOLNAEKJE([Out] Guid GFKBKKIBPJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x882FB00", Offset = "0x882E100", VA = "0x18882FB00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x882F6C0", Offset = "0x882DCC0", VA = "0x18882F6C0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x882D010", Offset = "0x882B610", VA = "0x18882D010")]
		private void ANHFOPDMJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x882FB00", Offset = "0x882E100", VA = "0x18882FB00")]
		private void OnMasterClientSwitched(NGPBJJLAELK LIOICDJHFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x882F5B0", Offset = "0x882DBB0", VA = "0x18882F5B0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88304A0", Offset = "0x882EAA0", VA = "0x1888304A0")]
		public void PreSerializeAsync(BIGICIGIIKM<Task> CIMPPALFCEL, StringBuilder JGGFBCFIKDL, BHJBHGBPBOH LMNHPCAEPKM, CancellationToken MEKNAIONNND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88308D0", Offset = "0x882EED0", VA = "0x1888308D0")]
		public PDJBJEFMPKL Serialize(BOPKMPFPFAL IKHBJPKFLMO, StringBuilder JGGFBCFIKDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x882E9E0", Offset = "0x882CFE0", VA = "0x18882E9E0")]
		public void InitializeDeserialization(PDJBJEFMPKL JIAPGANKIOL, bool IPKDBAJNEKH = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x882FF80", Offset = "0x882E580", VA = "0x18882FF80")]
		public void PreDeserialize(bool PEPMDIHKPNG, JOBIMPNHPOH OIBFPLAJLLP, PDJBJEFMPKL JIAPGANKIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x882DD80", Offset = "0x882C380", VA = "0x18882DD80")]
		public void Deserialize(bool PEPMDIHKPNG, JKMMBHCCEJA PLCEAEOGLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x882FB10", Offset = "0x882E110", VA = "0x18882FB10")]
		public void PostDeserialize(bool PEPMDIHKPNG, JJPBGCMDOHN EIBECKDBECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x882EDB0", Offset = "0x882D3B0", VA = "0x18882EDB0")]
		private void MIECNFEBIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x882E630", Offset = "0x882CC30", VA = "0x18882E630")]
		private PDJBJEFMPKL ICDOPFEPOKJ(PDJBJEFMPKL BMBJJONNGOA, ChildViewReference OGHJJFPEOAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x882F4E0", Offset = "0x882DAE0", VA = "0x18882F4E0")]
		public void MarkExcludedFromRoomSave(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8831360", Offset = "0x882F960", VA = "0x188831360")]
		public void UnmarkExcludedFromRoomSave(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x882DC10", Offset = "0x882C210", VA = "0x18882DC10", Slot = "14")]
		public void Bake(BECEKGEMHAB HHPFOCCGJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8831540", Offset = "0x882FB40", VA = "0x188831540")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x882E550", Offset = "0x882CB50", VA = "0x18882E550")]
		[CompilerGenerated]
		private object IBHODIPCFMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x882E420", Offset = "0x882CA20", VA = "0x18882E420")]
		[CompilerGenerated]
		private object ECPKBLKAAGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x882E4A0", Offset = "0x882CAA0", VA = "0x18882E4A0")]
		[CompilerGenerated]
		private object GOLJBNDPDLH()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PPBHMNHJALP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool JIGOLBJCJJL(IJFCDEBIONC DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LHBFFFKIEHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LHBFFFKIEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x882C490", Offset = "0x882AA90", VA = "0x18882C490")]
		internal Task IEIOOOHIFLM(IJFCDEBIONC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GDEKHJOFONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<IJFCDEBIONC> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GDEKHJOFONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x882BF40", Offset = "0x882A540", VA = "0x18882BF40")]
		internal Task IEIOOOHIFLM(IJFCDEBIONC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EJFGBOHLLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public JHHOCBAGFAB handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PPBHMNHJALP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EJFGBOHLLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x882BD70", Offset = "0x882A370", VA = "0x18882BD70")]
		internal object FIGIMCDCPOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<GGJINCEMEKP, HashSet<(JHHOCBAGFAB, JIGOLBJCJJL, GDEBONPAJHE)>> NGGJNCLDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid LFGGKAEBBIJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x882CF70", Offset = "0x882B570", VA = "0x18882CF70")]
	public PPBHMNHJALP(Guid DIHEFGMJPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x882C750", Offset = "0x882AD50", VA = "0x18882C750")]
	public PPBHMNHJALP ICKKPHIGICF(GGJINCEMEKP OPKLKPLNEAJ, JHHOCBAGFAB NHDKPDDEAKH, GDEBONPAJHE CACEFGPINFP, [Optional] JIGOLBJCJJL DNDGOJCNMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x882C9A0", Offset = "0x882AFA0", VA = "0x18882C9A0")]
	public PPBHMNHJALP ICKKPHIGICF(GGJINCEMEKP OPKLKPLNEAJ, JHHOCBAGFAB NHDKPDDEAKH, Action CACEFGPINFP, [Optional] JIGOLBJCJJL DNDGOJCNMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x882CA90", Offset = "0x882B090", VA = "0x18882CA90")]
	public PPBHMNHJALP ICKKPHIGICF(GGJINCEMEKP OPKLKPLNEAJ, JHHOCBAGFAB NHDKPDDEAKH, Action<IJFCDEBIONC> CACEFGPINFP, [Optional] JIGOLBJCJJL DNDGOJCNMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x882CB80", Offset = "0x882B180", VA = "0x18882CB80")]
	public Dictionary<JHHOCBAGFAB, List<GDEBONPAJHE>> IMGGIPDEODK(GGJINCEMEKP PNPFAPEBMMF, IJFCDEBIONC DAJAOHIJHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task FDLCAABNENP(CancellationToken MEKNAIONNND);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class BHIGBFMACIK : KMNENFMKNHB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum MOPPHKKMCFF
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
	private class AAFILJHBLHG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class JBAEMABEOFA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object HHPFOCCGJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly PPBHMNHJALP CACEFGPINFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> MPFGIEJHMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool JBOBNJDEDEL;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xDD53B0", Offset = "0xDD39B0", VA = "0x180DD53B0")]
		public JBAEMABEOFA(object HHPFOCCGJIF, PPBHMNHJALP CACEFGPINFP, Action<object> MPFGIEJHMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x882C450", Offset = "0x882AA50", VA = "0x18882C450", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, PPBHMNHJALP> LGNLGICMBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<FDLCAABNENP> KBJNLIFGOPK;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x882B260", Offset = "0x8829860", VA = "0x18882B260")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void ADENDBKKDEC(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x882B350", Offset = "0x8829950", VA = "0x18882B350", Slot = "4")]
	public IReadOnlyList<PPBHMNHJALP> AOAGGODAAJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x882B660", Offset = "0x8829C60", VA = "0x18882B660", Slot = "5")]
	public IDisposable LCPIJALOGBP(object HHPFOCCGJIF, PPBHMNHJALP CACEFGPINFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x882B7E0", Offset = "0x8829DE0", VA = "0x18882B7E0", Slot = "6")]
	public IReadOnlyList<FDLCAABNENP> LDANPJJKOBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x882B820", Offset = "0x8829E20", VA = "0x18882B820")]
	private void POMKAOEKMKH(object HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x882B3B0", Offset = "0x88299B0", VA = "0x18882B3B0")]
	[KAMEFMADCPE]
	internal static void EDOFINOBNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x882B510", Offset = "0x8829B10", VA = "0x18882B510")]
	internal static void JKHFIKONJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x882B490", Offset = "0x8829A90", VA = "0x18882B490")]
	internal void FLPBAJANNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x882B8F0", Offset = "0x8829EF0", VA = "0x18882B8F0")]
	public BHIGBFMACIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CMAKNCPEJNC
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<GGJINCEMEKP> LLEENHBLDCB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<GGJINCEMEKP> KCDCJIHLMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x882BAD0", Offset = "0x882A0D0", VA = "0x18882BAD0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OGJOKFAEKOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IIBHPPFJLIK : IAsyncStateMachine
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
		public OGJOKFAEKOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x882BFF0", Offset = "0x882A5F0", VA = "0x18882BFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x882C220", Offset = "0x882A820", VA = "0x18882C220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float CGNDGIIBAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float LPLMOMNKLJD;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x882C710", Offset = "0x882AD10", VA = "0x18882C710")]
	public OGJOKFAEKOG(float LPLMOMNKLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x882C600", Offset = "0x882AC00", VA = "0x18882C600")]
	[AsyncStateMachine(typeof(IIBHPPFJLIK))]
	public Task AGBMCHDCLEB(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x882C6F0", Offset = "0x882ACF0", VA = "0x18882C6F0")]
	public void IMGLACMMFNI()
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
