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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x847F000", Offset = "0x847DE00", VA = "0x18847F000", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8484D80", Offset = "0x8483B80", VA = "0x188484D80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NMGBCEEGCOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly OBPMHNNDFCF AMAKFPNFNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte DGPNPBEKOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid DDHBDLPKMNF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x847F880", Offset = "0x847E680", VA = "0x18847F880")]
	public NMGBCEEGCOL(OBPMHNNDFCF AMAKFPNFNCP, byte DGPNPBEKOOD, Guid DDHBDLPKMNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task LABOCDCFPDG(EIPHABKKBFG ENDEOBGIMGA, CancellationToken HIMDFBHMPLL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class EIPHABKKBFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GFFKHEAOFOJ LEMHDBBFMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, CDOFHMONKPD)> JCGPAHMNNAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public AACPGJNOFJH AKPICHBELAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public EJHPEGDEELG EBCBAJELCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ENBAOPBPJOK KAMPMBMALEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<ENBAOPBPJOK> HCOMELABEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<ENBAOPBPJOK> HLOCDBNHPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NPIADBPPJMB GLPMJHDIODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA76750", Offset = "0xA75550", VA = "0x180A76750")]
		[CompilerGenerated]
		get
		{
			return default(NPIADBPPJMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public IMABAOJCLFC DHJLAODJCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CPDFLLLEANH KCBDFJAIIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<NMGBCEEGCOL> DNPOPDNMHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HDFBKAHFHIL PFAMOJLEHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5F330", Offset = "0xA5E130", VA = "0x180A5F330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OLEFGOLBHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA604E0", Offset = "0xA5F2E0", VA = "0x180A604E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x847E300", Offset = "0x847D100", VA = "0x18847E300")]
	public EIPHABKKBFG(AACPGJNOFJH OKIMGMJFNAN, EJHPEGDEELG LGGFANHFKBF, ENBAOPBPJOK CHGCDOEKHMD, IReadOnlyList<ENBAOPBPJOK> IBJBBEKOOAH, IReadOnlyList<ENBAOPBPJOK> JBAHBLPPGCN, NPIADBPPJMB IHECFIMMEOL, bool MMPLDKDOIPC, IMABAOJCLFC JBNEABKLADH, CPDFLLLEANH NOAJNBLGDKM, IEnumerable<NMGBCEEGCOL> KEDPAJJLCAI, HDFBKAHFHIL FECKNFGGFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x847E270", Offset = "0x847D070", VA = "0x18847E270")]
	public void DIGCPDGFBEK(GFFKHEAOFOJ EKJDMBEGLGI, List<(PersistenceView, CDOFHMONKPD)> LPAHBDJPCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x847E290", Offset = "0x847D090", VA = "0x18847E290")]
	public List<(PersistenceView, CDOFHMONKPD)> OIJLMEOGJDD(GFFKHEAOFOJ IGAKMIHOBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AJHDCFJNACE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FAGPKDIFNIN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ABMNIPLGMBM]
public enum GFFKHEAOFOJ
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
public enum BBADNCMFFIL : byte
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
public interface ENBAOPBPJOK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid IPLEJNECALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> IPKIMDBIHAB();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDPFDNHEIDC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEGBBBKJJPH(bool KNGDALLAJJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BCODJCIIJOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NPIADBPPJMB IHECFIMMEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public CDOFHMONKPD FKPLGDJFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool JJBGCIFLIEJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BCHJBLIFBEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> GHDFAEDCNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder MJEJLMFOAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public CIKLCEAGENN MDKOKCBJFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LFCEFJBJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 LNGGMJDJKCI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x847DBF0", Offset = "0x847C9F0", VA = "0x18847DBF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x847DC40", Offset = "0x847CA40", VA = "0x18847DC40")]
	public BCHJBLIFBEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MOCCGPEEMHE
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BDJHLOLGMID
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NIEPLJKFEDH : BDJHLOLGMID
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MOCCGPEEMHE KMNPJKJNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BHGGKAFNGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(BCODJCIIJOF AKMNMHDCHCK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(CDOFHMONKPD FKPLGDJFALO, BCHJBLIFBEP IOMPNBMHBBN, StringBuilder AOHEEJJDIKB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BHJBCIPBNOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MOCCGPEEMHE OILBKCILPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(IMABAOJCLFC JBNEABKLADH, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(IMABAOJCLFC JBNEABKLADH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LHPLEFNICEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool JJBGCIFLIEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MCPMCHCPOAO : NIEPLJKFEDH, BDJHLOLGMID
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(LHPLEFNICEN NOOLHPIENPD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IANCJHJMPDD : NIEPLJKFEDH, BDJHLOLGMID
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(NPIADBPPJMB IHECFIMMEOL, CDOFHMONKPD FKPLGDJFALO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NEAFCOGGKBB : BDJHLOLGMID
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder AOHEEJJDIKB, FAGPKDIFNIN PCHBJGHMGLM, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KGFJDPAACPB
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<JKDIEKHIAPL> JNFHHBGDPHI();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KJPKFLLMAND(object IEOOLFDDEEF, JKDIEKHIAPL IOACPCLMBLG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<LAKKBDHPEHD> CFABMEAGICJ();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, HAHNHFHBMDO
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
		public delegate void EKNDKKJOIBF(Guid DOJOJHFBNFA, Guid FBCKGNBHAFH);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class PPEGDNBPPML
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class BPBNOIDMLMP<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : NIEPLJKFEDH
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
				private HashSet<NIEPLJKFEDH> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<NIEPLJKFEDH> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<NIEPLJKFEDH>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
				[DebuggerHidden]
				public BPBNOIDMLMP(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x480A230", Offset = "0x4809030", VA = "0x18480A230", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6349CB0", Offset = "0x6348AB0", VA = "0x186349CB0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6349C60", Offset = "0x6348A60", VA = "0x186349C60")]
				private void KHMMOEFKMMI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x6349F40", Offset = "0x6348D40", VA = "0x186349F40", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4D24D90", Offset = "0x4D23B90", VA = "0x184D24D90", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4C8E770", Offset = "0x4C8D570", VA = "0x184C8E770", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<NIEPLJKFEDH> JLAHBKEALJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<NIEPLJKFEDH> MGOFFAGCIDL;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x847F960", Offset = "0x847E760", VA = "0x18847F960")]
			public void MKJMPEIBIJK(MOCCGPEEMHE FPDDLMMOPOG, NIEPLJKFEDH MBMLJJAKPDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x847F8E0", Offset = "0x847E6E0", VA = "0x18847F8E0")]
			private static void FFKPBOLEKNK(HashSet<NIEPLJKFEDH> PPBFCAAOABF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x42CD6D0", Offset = "0x42CC4D0", VA = "0x1842CD6D0")]
			public IEnumerable<T> MAGILDINAOL<T>(bool BAJDMGPEFCF) where T : NIEPLJKFEDH
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3938120", Offset = "0x3936F20", VA = "0x183938120")]
			[IteratorStateMachine(typeof(BPBNOIDMLMP<>))]
			private static IEnumerable<T> BAACNKNLCHO<T>(HashSet<NIEPLJKFEDH> PPBFCAAOABF) where T : NIEPLJKFEDH
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public PPEGDNBPPML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class NOMJEAOGPAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public NOMJEAOGPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x847F8C0", Offset = "0x847E6C0", VA = "0x18847F8C0")]
			internal bool AAGBOCHGKNC(CJIDOOCHCLF d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> PEHJFMKFCBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool FCJHKHPBJJC;

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
		private FLFFAJPBAHP<Guid> FKDGNCHNLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<NIEPLJKFEDH> BPCGICCBPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<NEAFCOGGKBB> MDBMCNEEIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PPEGDNBPPML CGOKPKLGIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid AHGOEAEFOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid OINHENBINPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private JDCOMPLHBHF NDEKOGMHCJD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> MCDLOLIKFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x84845E0", Offset = "0x84833E0", VA = "0x1884845E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid ACHEFDKJDFN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x84841A0", Offset = "0x8482FA0", VA = "0x1884841A0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8484730", Offset = "0x8483530", VA = "0x188484730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NEEGIBOAOMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x149E000", Offset = "0x149CE00", VA = "0x18149E000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x149DCC0", Offset = "0x149CAC0", VA = "0x18149DCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MMAMNDAJIPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8484280", Offset = "0x8483080", VA = "0x188484280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool OLBDNLLENJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8480090", Offset = "0x847EE90", VA = "0x188480090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView EOBODPCNOGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA5C310", Offset = "0xA5B110", VA = "0x180A5C310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IAMJIENDFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8484230", Offset = "0x8483030", VA = "0x188484230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool MLKPLBPNNOK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8481040", Offset = "0x847FE40", VA = "0x188481040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EKNDKKJOIBF IFIAICKOMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84840F0", Offset = "0x8482EF0", VA = "0x1884840F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8484680", Offset = "0x8483480", VA = "0x188484680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84801F0", Offset = "0x847EFF0", VA = "0x1884801F0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8481460", Offset = "0x8480260", VA = "0x188481460")]
		private bool KLLBAMLFPIM([Out] Guid FDOGHGPNIMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84825C0", Offset = "0x84813C0", VA = "0x1884825C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8482180", Offset = "0x8480F80", VA = "0x188482180", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x847FAD0", Offset = "0x847E8D0", VA = "0x18847FAD0")]
		private void ABEGMFKJEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84825C0", Offset = "0x84813C0", VA = "0x1884825C0")]
		private void OnMasterClientSwitched(CDKFIILELLC IFADLDJHCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8481D70", Offset = "0x8480B70", VA = "0x188481D70")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8482F60", Offset = "0x8481D60", VA = "0x188482F60")]
		public void PreSerializeAsync(GDLAFIILODC<Task> OODPKPICLBC, StringBuilder AOHEEJJDIKB, FAGPKDIFNIN PCHBJGHMGLM, CancellationToken HIMDFBHMPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8483390", Offset = "0x8482190", VA = "0x188483390")]
		public CDOFHMONKPD Serialize(BCHJBLIFBEP IOMPNBMHBBN, StringBuilder AOHEEJJDIKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8481210", Offset = "0x8480010", VA = "0x188481210")]
		public void InitializeDeserialization(CDOFHMONKPD FKPLGDJFALO, bool HGDEKIGNJEH = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8482A40", Offset = "0x8481840", VA = "0x188482A40")]
		public void PreDeserialize(bool BAJDMGPEFCF, NPIADBPPJMB IHECFIMMEOL, CDOFHMONKPD FKPLGDJFALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84809A0", Offset = "0x847F7A0", VA = "0x1884809A0")]
		public void Deserialize(bool BAJDMGPEFCF, BCODJCIIJOF AKMNMHDCHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84825D0", Offset = "0x84813D0", VA = "0x1884825D0")]
		public void PostDeserialize(bool BAJDMGPEFCF, LHPLEFNICEN NOOLHPIENPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8481570", Offset = "0x8480370", VA = "0x188481570")]
		private void KPFPNACIMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8481F30", Offset = "0x8480D30", VA = "0x188481F30")]
		private CDOFHMONKPD NPODBNEPBJA(CDOFHMONKPD DMHKDHJPMLJ, ChildViewReference CCEEMHPLNFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8481CA0", Offset = "0x8480AA0", VA = "0x188481CA0")]
		public void MarkExcludedFromRoomSave(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8483E20", Offset = "0x8482C20", VA = "0x188483E20")]
		public void UnmarkExcludedFromRoomSave(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8480830", Offset = "0x847F630", VA = "0x188480830", Slot = "14")]
		public void Bake(HLIDELEPHMC IEOOLFDDEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8484000", Offset = "0x8482E00", VA = "0x188484000")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84810B0", Offset = "0x847FEB0", VA = "0x1884810B0")]
		[CompilerGenerated]
		private object FIFOLNLLGFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8481190", Offset = "0x847FF90", VA = "0x188481190")]
		[CompilerGenerated]
		private object HEPPOLGKGLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8481E80", Offset = "0x8480C80", VA = "0x188481E80")]
		[CompilerGenerated]
		private object NENFJIEJLOG()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JKDIEKHIAPL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool JKLIIGEGLAE(EIPHABKKBFG BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NBKLONKPGAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NBKLONKPGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x847F7E0", Offset = "0x847E5E0", VA = "0x18847F7E0")]
		internal Task ABIEAJIONCF(EIPHABKKBFG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GLHEMIOMCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<EIPHABKKBFG> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GLHEMIOMCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x847E440", Offset = "0x847D240", VA = "0x18847E440")]
		internal Task ABIEAJIONCF(EIPHABKKBFG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class APDLLPIJLAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BBADNCMFFIL handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JKDIEKHIAPL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public APDLLPIJLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x847DB40", Offset = "0x847C940", VA = "0x18847DB40")]
		internal object FLFPKIBHDMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<GFFKHEAOFOJ, HashSet<(BBADNCMFFIL, JKLIIGEGLAE, LABOCDCFPDG)>> GGFOEMDAPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid DOAFPDMICDA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x847ED10", Offset = "0x847DB10", VA = "0x18847ED10")]
	public JKDIEKHIAPL(Guid LKHJFPGFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x847E8E0", Offset = "0x847D6E0", VA = "0x18847E8E0")]
	public JKDIEKHIAPL NIGDDFCBFMG(GFFKHEAOFOJ BKPIFOGOPFC, BBADNCMFFIL FPDDLMMOPOG, LABOCDCFPDG IOACPCLMBLG, [Optional] JKLIIGEGLAE PFCMIPDJMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x847EC20", Offset = "0x847DA20", VA = "0x18847EC20")]
	public JKDIEKHIAPL NIGDDFCBFMG(GFFKHEAOFOJ BKPIFOGOPFC, BBADNCMFFIL FPDDLMMOPOG, Action IOACPCLMBLG, [Optional] JKLIIGEGLAE PFCMIPDJMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x847EB30", Offset = "0x847D930", VA = "0x18847EB30")]
	public JKDIEKHIAPL NIGDDFCBFMG(GFFKHEAOFOJ BKPIFOGOPFC, BBADNCMFFIL FPDDLMMOPOG, Action<EIPHABKKBFG> IOACPCLMBLG, [Optional] JKLIIGEGLAE PFCMIPDJMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x847E4F0", Offset = "0x847D2F0", VA = "0x18847E4F0")]
	public Dictionary<BBADNCMFFIL, List<LABOCDCFPDG>> MKAPBFJEIKN(GFFKHEAOFOJ EKJDMBEGLGI, EIPHABKKBFG BOIPFNOKGBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task LAKKBDHPEHD(CancellationToken HIMDFBHMPLL);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class MPJOIKPKHOI : KGFJDPAACPB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GAKAIEMJJEB
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
	private class EBIBOJEKKPN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class CEJMLAMMKMK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object IEOOLFDDEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly JKDIEKHIAPL IOACPCLMBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> MELHBPMBKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool FOABPIBDEDN;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD42A30", Offset = "0xD41830", VA = "0x180D42A30")]
		public CEJMLAMMKMK(object IEOOLFDDEEF, JKDIEKHIAPL IOACPCLMBLG, Action<object> MELHBPMBKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x847DD00", Offset = "0x847CB00", VA = "0x18847DD00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, JKDIEKHIAPL> JMGAOIKDGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<LAKKBDHPEHD> IHDCBNOOLJC;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x847F350", Offset = "0x847E150", VA = "0x18847F350")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void KEKMDAEKNFP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x847F2F0", Offset = "0x847E0F0", VA = "0x18847F2F0", Slot = "4")]
	public IReadOnlyList<JKDIEKHIAPL> JNFHHBGDPHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x847F440", Offset = "0x847E240", VA = "0x18847F440", Slot = "5")]
	public IDisposable KJPKFLLMAND(object IEOOLFDDEEF, JKDIEKHIAPL IOACPCLMBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x847F1D0", Offset = "0x847DFD0", VA = "0x18847F1D0", Slot = "6")]
	public IReadOnlyList<LAKKBDHPEHD> CFABMEAGICJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x847F210", Offset = "0x847E010", VA = "0x18847F210")]
	private void DBFONNNPAEI(object IEOOLFDDEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x847F5C0", Offset = "0x847E3C0", VA = "0x18847F5C0")]
	[ODKIEBDNNBP]
	internal static void NPCLOFDHOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x847F090", Offset = "0x847DE90", VA = "0x18847F090")]
	internal static void ANKJIMJKEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x847F270", Offset = "0x847E070", VA = "0x18847F270")]
	internal void GNENAFMIOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x847F710", Offset = "0x847E510", VA = "0x18847F710")]
	public MPJOIKPKHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class EEKCCMJNLCF
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<GFFKHEAOFOJ> CCELHAIPJIL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<GFFKHEAOFOJ> ABDGGNIGCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x847DFD0", Offset = "0x847CDD0", VA = "0x18847DFD0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KBIBHABDIIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct EBLIKNAHNGG : IAsyncStateMachine
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
		public KBIBHABDIIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x847DD40", Offset = "0x847CB40", VA = "0x18847DD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x847DF70", Offset = "0x847CD70", VA = "0x18847DF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float OAPBKPLLOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float OKEJDEFIBNK;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x847EEC0", Offset = "0x847DCC0", VA = "0x18847EEC0")]
	public KBIBHABDIIC(float OKEJDEFIBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x847EDB0", Offset = "0x847DBB0", VA = "0x18847EDB0")]
	[AsyncStateMachine(typeof(EBLIKNAHNGG))]
	public Task DAKMLGDACNL(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x847EEA0", Offset = "0x847DCA0", VA = "0x18847EEA0")]
	public void PLDNCIPNLFL()
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
