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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88C5E20", Offset = "0x88C4820", VA = "0x1888C5E20", Slot = "4")]
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
namespace _AssemblyRegistry.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88CB640", Offset = "0x88CA040", VA = "0x1888CB640", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CGFPIIJECHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly EAFBDFDMHAJ KIHNINAJFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte DGNODDPLLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid GBFHHPHEKAE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88C4E60", Offset = "0x88C3860", VA = "0x1888C4E60")]
	public CGFPIIJECHE(EAFBDFDMHAJ KIHNINAJFFI, byte DGNODDPLLPC, Guid GBFHHPHEKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task JAEDGEODMNM(CMFAJILFAHI ALHCDLPBNNA, CancellationToken AHOMALKMHKK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CMFAJILFAHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IBJAHKDFDAH LNFPNEMNHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, LNEHPBAPDKG)> PABFOCEOICB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public PKCMPJMLDGM NILAGDHEKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public PMHLBPGOPPD HHFNPAPPJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NDIBKEHOAOL JEGFCMGMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<NDIBKEHOAOL> PNOKIAPJAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<NDIBKEHOAOL> PBEAFEBMGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FPGEPAJMDDO NAJDEIPNFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		[CompilerGenerated]
		get
		{
			return default(FPGEPAJMDDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public EHIMHNJBHOL PPEMILFDMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EHFFBGCAIIE AHEEGMIDIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<CGFPIIJECHE> AINBGEICLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DEHOJEDEEJF AELKPAPOBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JDJEPDGEACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x88C4F30", Offset = "0x88C3930", VA = "0x1888C4F30")]
	public CMFAJILFAHI(PKCMPJMLDGM EDBEPKHMJCK, PMHLBPGOPPD JFDMBMLPAKA, NDIBKEHOAOL CFMBMGPBLGP, IReadOnlyList<NDIBKEHOAOL> FOHNPPEOHOM, IReadOnlyList<NDIBKEHOAOL> MIGCGDKCGIK, FPGEPAJMDDO JHLPHOMMEFP, bool KGAHHIIFMEA, EHIMHNJBHOL KALMEDGIGPJ, EHFFBGCAIIE NDJGEMIFCHE, IEnumerable<CGFPIIJECHE> JFBLMHAKDCH, DEHOJEDEEJF IFLNBDOBABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88C4EA0", Offset = "0x88C38A0", VA = "0x1888C4EA0")]
	public void ECLIJIJPBIA(IBJAHKDFDAH FHNBJFFKBEN, List<(PersistenceView, LNEHPBAPDKG)> MHCLJLIBLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88C4EC0", Offset = "0x88C38C0", VA = "0x1888C4EC0")]
	public List<(PersistenceView, LNEHPBAPDKG)> JAGBLFCNFIL(IBJAHKDFDAH DODKBAMAJEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EPNIDEGAFGC
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ALABEABJCDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MEHDELHJEOO]
public enum IBJAHKDFDAH
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
public enum FPKAAOMAOJJ : byte
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
public interface NDIBKEHOAOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid CFMLHNHKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> MFFMHELHHLJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMMOJCEDBAH();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCBIOEKDPJE(bool KLGLBMFPGIH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DBJKMPGIGGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public FPGEPAJMDDO JHLPHOMMEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public LNEHPBAPDKG CKBAKJANFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool KABCBMNPJCD;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IAJJGFEHOPJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> DHFMCPOGFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder EDNHDPIMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public ENONOMOKKCA BMOKNMEPLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int EPJDGGMAPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 FCKFALBAIIP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88C59B0", Offset = "0x88C43B0", VA = "0x1888C59B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88C5A00", Offset = "0x88C4400", VA = "0x1888C5A00")]
	public IAJJGFEHOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PBMOEJBKIKA
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GAEJDNKNCNF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GJIBGMEBIHJ : GAEJDNKNCNF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	PBMOEJBKIKA LDBFMFPJGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PEJPMGAECHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(DBJKMPGIGGB NAAGMNCEAMA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(LNEHPBAPDKG CKBAKJANFMC, IAJJGFEHOPJ MCPEJKLCMHG, StringBuilder FAJNDBEJIBF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HDHBNJPFAHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PBMOEJBKIKA EFMFCJGNLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(EHIMHNJBHOL KALMEDGIGPJ, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(EHIMHNJBHOL KALMEDGIGPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OCFGIMGLIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool KABCBMNPJCD;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AIEDPCOIILC : GJIBGMEBIHJ, GAEJDNKNCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(OCFGIMGLIIP LBMPPDAGIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JIMMEAOBJLF : GJIBGMEBIHJ, GAEJDNKNCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(FPGEPAJMDDO JHLPHOMMEFP, LNEHPBAPDKG CKBAKJANFMC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FNIBBPIOJNG : GAEJDNKNCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder FAJNDBEJIBF, ALABEABJCDD LJLNONPCKJA, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FABKHPHGOJG
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<BGBIJHCFHPL> IPDLMFGLILF();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FDHGDDALIIO(object IJNPIDPIBFP, BGBIJHCFHPL OIAJENBJKKC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<BAHMGECMGEB> ELGLONGEGKG();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, ONOGEDAKJOF
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
		public delegate void OODJFIGKDKO(Guid OLJPBOHCAFE, Guid LJDJKDCIDCJ);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class ENCIIIKCGDH
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class GBPBIGPKCGL<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : GJIBGMEBIHJ
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
				private HashSet<GJIBGMEBIHJ> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<GJIBGMEBIHJ> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<GJIBGMEBIHJ>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
				[DebuggerHidden]
				public GBPBIGPKCGL(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x5065630", Offset = "0x5064030", VA = "0x185065630", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5121EE0", Offset = "0x51208E0", VA = "0x185121EE0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5121E90", Offset = "0x5120890", VA = "0x185121E90")]
				private void LLDKJPCFHKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x5122170", Offset = "0x5120B70", VA = "0x185122170", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x507EB00", Offset = "0x507D500", VA = "0x18507EB00", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x5066830", Offset = "0x5065230", VA = "0x185066830", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<GJIBGMEBIHJ> CNHENBPDFMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<GJIBGMEBIHJ> BHEDJPCMCFC;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88C50F0", Offset = "0x88C3AF0", VA = "0x1888C50F0")]
			public void IAGMDFOKGFG(PBMOEJBKIKA LCEAAKMJPMM, GJIBGMEBIHJ DGNIMLBIIAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x88C5070", Offset = "0x88C3A70", VA = "0x1888C5070")]
			private static void ADJOKFJBGMC(HashSet<GJIBGMEBIHJ> HHHHAPMJLOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x44BEC10", Offset = "0x44BD610", VA = "0x1844BEC10")]
			public IEnumerable<T> GDMLHCPPPLP<T>(bool MMFNNOICEIF) where T : GJIBGMEBIHJ
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3CC0BD0", Offset = "0x3CBF5D0", VA = "0x183CC0BD0")]
			[IteratorStateMachine(typeof(GBPBIGPKCGL<>))]
			private static IEnumerable<T> JDELGHMEOCP<T>(HashSet<GJIBGMEBIHJ> HHHHAPMJLOO) where T : GJIBGMEBIHJ
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public ENCIIIKCGDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class KJFGLBNJNMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public KJFGLBNJNMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x88C5C00", Offset = "0x88C4600", VA = "0x1888C5C00")]
			internal bool PGKNJDAFKGN(MPKFAEGIEKJ d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> PCCHNICGIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool AHDFMOMHLNN;

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
		private IEJEGKIFFLB<Guid> GLLMAMMIKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<GJIBGMEBIHJ> PINGDGEOCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<FNIBBPIOJNG> KPDHLCANFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ENCIIIKCGDH FPCPHLLIBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid OBLLPMEBNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid NLKAMHOAMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private GBIFDHMBLCB NFBGHJAPAOB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> NKIKOAJAOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x88CAEB0", Offset = "0x88C98B0", VA = "0x1888CAEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid BKICOPKGOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x88CAA70", Offset = "0x88C9470", VA = "0x1888CAA70")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x88CB000", Offset = "0x88C9A00", VA = "0x1888CB000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ALJBOGPHPNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x15C7D40", Offset = "0x15C6740", VA = "0x1815C7D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x15C7A00", Offset = "0x15C6400", VA = "0x1815C7A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JNDGLOCDCFF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x88CAB50", Offset = "0x88C9550", VA = "0x1888CAB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool EBMLODODCHD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x88C87A0", Offset = "0x88C71A0", VA = "0x1888C87A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView NMJPCIAEILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KHLKCBAONIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x88CAB00", Offset = "0x88C9500", VA = "0x1888CAB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool FMKCFOMCGCB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88C7E90", Offset = "0x88C6890", VA = "0x1888C7E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OODJFIGKDKO LNCOLBKJAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x88CA9C0", Offset = "0x88C93C0", VA = "0x1888CA9C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x88CAF50", Offset = "0x88C9950", VA = "0x1888CAF50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88C63E0", Offset = "0x88C4DE0", VA = "0x1888C63E0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88C8240", Offset = "0x88C6C40", VA = "0x1888C8240")]
		private bool OKMOOPCFPEF([Out] Guid KKAIMDCIFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88C8790", Offset = "0x88C7190", VA = "0x1888C8790")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88C8350", Offset = "0x88C6D50", VA = "0x1888C8350", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88C8900", Offset = "0x88C7300", VA = "0x1888C8900")]
		private void PHOMCOPIDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88C8790", Offset = "0x88C7190", VA = "0x1888C8790")]
		private void OnMasterClientSwitched(FNAEIBBBBBE BLHNDOLLIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88C8050", Offset = "0x88C6A50", VA = "0x1888C8050")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88C9840", Offset = "0x88C8240", VA = "0x1888C9840")]
		public void PreSerializeAsync(FMJHIDPKFMF<Task> BKGFHPLBDCE, StringBuilder FAJNDBEJIBF, ALABEABJCDD LJLNONPCKJA, CancellationToken AHOMALKMHKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88C9C70", Offset = "0x88C8670", VA = "0x1888C9C70")]
		public LNEHPBAPDKG Serialize(IAJJGFEHOPJ MCPEJKLCMHG, StringBuilder FAJNDBEJIBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88C7BA0", Offset = "0x88C65A0", VA = "0x1888C7BA0")]
		public void InitializeDeserialization(LNEHPBAPDKG CKBAKJANFMC, bool LPNJMDCKNIO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88C9330", Offset = "0x88C7D30", VA = "0x1888C9330")]
		public void PreDeserialize(bool MMFNNOICEIF, FPGEPAJMDDO JHLPHOMMEFP, LNEHPBAPDKG CKBAKJANFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88C6DE0", Offset = "0x88C57E0", VA = "0x1888C6DE0")]
		public void Deserialize(bool MMFNNOICEIF, DBJKMPGIGGB NAAGMNCEAMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88C8EC0", Offset = "0x88C78C0", VA = "0x1888C8EC0")]
		public void PostDeserialize(bool MMFNNOICEIF, OCFGIMGLIIP LBMPPDAGIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88C7470", Offset = "0x88C5E70", VA = "0x1888C7470")]
		private void EDLOBKNEGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x88C6B90", Offset = "0x88C5590", VA = "0x1888C6B90")]
		private LNEHPBAPDKG DPPJKOBCLGI(LNEHPBAPDKG MIPJBFGFKAO, ChildViewReference FPJMMEGHFEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88C7F80", Offset = "0x88C6980", VA = "0x1888C7F80")]
		public void MarkExcludedFromRoomSave(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88CA6F0", Offset = "0x88C90F0", VA = "0x1888CA6F0")]
		public void UnmarkExcludedFromRoomSave(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88C6A20", Offset = "0x88C5420", VA = "0x1888C6A20", Slot = "14")]
		public void Bake(DMCPBIKBILF IJNPIDPIBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88CA8D0", Offset = "0x88C92D0", VA = "0x1888CA8D0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88C8160", Offset = "0x88C6B60", VA = "0x1888C8160")]
		[CompilerGenerated]
		private object NOLDAHOLDPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88C7F00", Offset = "0x88C6900", VA = "0x1888C7F00")]
		[CompilerGenerated]
		private object MJFDIPEMGGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x88C7DE0", Offset = "0x88C67E0", VA = "0x1888C7DE0")]
		[CompilerGenerated]
		private object JEKCLIEHJIP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BGBIJHCFHPL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool HNBMOGFCOJI(CMFAJILFAHI BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BJEDDBGOMEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BJEDDBGOMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88C4D10", Offset = "0x88C3710", VA = "0x1888C4D10")]
		internal Task DAIPPMFEGPL(CMFAJILFAHI data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LDDMGCEIMFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<CMFAJILFAHI> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LDDMGCEIMFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88C5C20", Offset = "0x88C4620", VA = "0x1888C5C20")]
		internal Task DAIPPMFEGPL(CMFAJILFAHI data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CGANPDBIFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FPKAAOMAOJJ handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BGBIJHCFHPL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CGANPDBIFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x88C4DB0", Offset = "0x88C37B0", VA = "0x1888C4DB0")]
		internal object LKDEAGKMGOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<IBJAHKDFDAH, HashSet<(FPKAAOMAOJJ, HNBMOGFCOJI, JAEDGEODMNM)>> NLHMAGAEKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid CINKACLMDJO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x88C4C70", Offset = "0x88C3670", VA = "0x1888C4C70")]
	public BGBIJHCFHPL(Guid LBEIKAOJNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x88C4930", Offset = "0x88C3330", VA = "0x1888C4930")]
	public BGBIJHCFHPL PLAGLNPDDCM(IBJAHKDFDAH BMAJKOLBFDK, FPKAAOMAOJJ LCEAAKMJPMM, JAEDGEODMNM OIAJENBJKKC, [Optional] HNBMOGFCOJI PPPCALHKDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x88C4B80", Offset = "0x88C3580", VA = "0x1888C4B80")]
	public BGBIJHCFHPL PLAGLNPDDCM(IBJAHKDFDAH BMAJKOLBFDK, FPKAAOMAOJJ LCEAAKMJPMM, Action OIAJENBJKKC, [Optional] HNBMOGFCOJI PPPCALHKDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88C4840", Offset = "0x88C3240", VA = "0x1888C4840")]
	public BGBIJHCFHPL PLAGLNPDDCM(IBJAHKDFDAH BMAJKOLBFDK, FPKAAOMAOJJ LCEAAKMJPMM, Action<CMFAJILFAHI> OIAJENBJKKC, [Optional] HNBMOGFCOJI PPPCALHKDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x88C4450", Offset = "0x88C2E50", VA = "0x1888C4450")]
	public Dictionary<FPKAAOMAOJJ, List<JAEDGEODMNM>> AOEOKFFCCOE(IBJAHKDFDAH FHNBJFFKBEN, CMFAJILFAHI BLPDDGCLNPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task BAHMGECMGEB(CancellationToken AHOMALKMHKK);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class HHJGMIPLBLO : FABKHPHGOJG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum EONMNIPEBOJ
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
	private class IOAICGNNMGA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class JBCNFCNPKEI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object IJNPIDPIBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly BGBIJHCFHPL OIAJENBJKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> NFDIKNPHBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool ICPNMNBNLKA;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xE09BE0", Offset = "0xE085E0", VA = "0x180E09BE0")]
		public JBCNFCNPKEI(object IJNPIDPIBFP, BGBIJHCFHPL OIAJENBJKKC, Action<object> NFDIKNPHBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88C5BC0", Offset = "0x88C45C0", VA = "0x1888C5BC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, BGBIJHCFHPL> NPJJNINHCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<BAHMGECMGEB> AAJGKEHDPEJ;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x88C5260", Offset = "0x88C3C60", VA = "0x1888C5260")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void CCKCOACOBKL(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x88C55F0", Offset = "0x88C3FF0", VA = "0x1888C55F0", Slot = "4")]
	public IReadOnlyList<BGBIJHCFHPL> IPDLMFGLILF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x88C5410", Offset = "0x88C3E10", VA = "0x1888C5410", Slot = "5")]
	public IDisposable FDHGDDALIIO(object IJNPIDPIBFP, BGBIJHCFHPL OIAJENBJKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88C53D0", Offset = "0x88C3DD0", VA = "0x1888C53D0", Slot = "6")]
	public IReadOnlyList<BAHMGECMGEB> ELGLONGEGKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x88C5590", Offset = "0x88C3F90", VA = "0x1888C5590")]
	private void GEPGBNBKPIG(object IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x88C5650", Offset = "0x88C4050", VA = "0x1888C5650")]
	[IPFIKIDBFAK]
	internal static void KCCGOIBALIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88C5730", Offset = "0x88C4130", VA = "0x1888C5730")]
	internal static void OLMPCAINCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88C5350", Offset = "0x88C3D50", VA = "0x1888C5350")]
	internal void EFFGFJJMBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x88C58E0", Offset = "0x88C42E0", VA = "0x1888C58E0")]
	public HHJGMIPLBLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class OINANEMHOHE
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<IBJAHKDFDAH> EEGMCFKOEBN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<IBJAHKDFDAH> EGKBEKKIMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x88C5EB0", Offset = "0x88C48B0", VA = "0x1888C5EB0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LNBIFKHOIBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct OOMJFDHNPMO : IAsyncStateMachine
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
		public LNBIFKHOIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x88C6150", Offset = "0x88C4B50", VA = "0x1888C6150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x88C6380", Offset = "0x88C4D80", VA = "0x1888C6380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float KMOIHMOKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float IJEKODGPEII;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88C5DE0", Offset = "0x88C47E0", VA = "0x1888C5DE0")]
	public LNBIFKHOIBN(float IJEKODGPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88C5CD0", Offset = "0x88C46D0", VA = "0x1888C5CD0")]
	[AsyncStateMachine(typeof(OOMJFDHNPMO))]
	public Task EAOCDKMBDJH(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x88C5DC0", Offset = "0x88C47C0", VA = "0x1888C5DC0")]
	public void NPPCJNEPLIK()
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
