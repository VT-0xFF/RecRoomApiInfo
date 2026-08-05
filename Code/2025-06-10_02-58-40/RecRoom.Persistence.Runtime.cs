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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDFF0", Offset = "0x7FFD1F0", VA = "0x187FFDFF0", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8003510", Offset = "0x8002710", VA = "0x188003510", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KKEGNBCFCEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly JDGCHBGAGIG KBPIMIOBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte GDHKDBJPDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid PLGGGIJOHAJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDD20", Offset = "0x7FFCF20", VA = "0x187FFDD20")]
	public KKEGNBCFCEE(JDGCHBGAGIG KBPIMIOBFPK, byte GDHKDBJPDLG, Guid PLGGGIJOHAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task MNKAFBLBFBC(IMGOPGMMMDH CCEPNMMABPI, CancellationToken FHBCOAHILMJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IMGOPGMMMDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HIBEIMPBEBE KCCCKCFAFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, IHCKNOKFLCP)> PJIJDPEELPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public EAAMLCEDMMD HIGJGAJGGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public EBAEPIOAJNM DBPPOPKFMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OCHIFCLAGPH EOOAPGNIPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<OCHIFCLAGPH> KLNJGFNLBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<OCHIFCLAGPH> LLGDKEIHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MGNNNNPADNA EBEOAEEBKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7E0", Offset = "0xA1E9E0", VA = "0x180A1F7E0")]
		[CompilerGenerated]
		get
		{
			return default(MGNNNNPADNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public OJIMHFCMHLE MGDMAEMMBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KLFAJJACBNI CLGNKFHJONG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<KKEGNBCFCEE> JMOHNABBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BODMDNMFLKL GFHJCJDGJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA00350", Offset = "0x9FF550", VA = "0x180A00350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GOOAIEIMLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD10", Offset = "0xA0EF10", VA = "0x180A0FD10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD6E0", Offset = "0x7FFC8E0", VA = "0x187FFD6E0")]
	public IMGOPGMMMDH(EAAMLCEDMMD PCKDNOKGHKJ, EBAEPIOAJNM JEAFNAEELPJ, OCHIFCLAGPH PIPNJKGBCEF, IReadOnlyList<OCHIFCLAGPH> PPFCCPOLHJF, IReadOnlyList<OCHIFCLAGPH> DLDAEKLIPGG, MGNNNNPADNA ICJKPMCNKAG, bool IJJMNHJPLEM, OJIMHFCMHLE JCFOMPGDMKN, KLFAJJACBNI NDINKJMLNJN, IEnumerable<KKEGNBCFCEE> CGFKAMBJHNE, BODMDNMFLKL DIKCEMHENPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD6C0", Offset = "0x7FFC8C0", VA = "0x187FFD6C0")]
	public void JDACCAPEGKB(HIBEIMPBEBE OFNKJHLMDDE, List<(PersistenceView, IHCKNOKFLCP)> ONJBDCAAEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD650", Offset = "0x7FFC850", VA = "0x187FFD650")]
	public List<(PersistenceView, IHCKNOKFLCP)> IFCKEGHFHFH(HIBEIMPBEBE JAKOLDAOPEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IDBHCDKMGJP
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ALLJAELJMGC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BDBCAOHHABP]
public enum HIBEIMPBEBE
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
public enum KBNOLLLMMGI : byte
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
public interface OCHIFCLAGPH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid GJJACFEFMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> NMKAHLBFJJD();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACKNMJHHMHA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NFOLGBHDKGK(bool ADBJFGLMDDI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HMCGDGIPDCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public MGNNNNPADNA ICJKPMCNKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public IHCKNOKFLCP ABECEAAIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool OFFDPDBNGLH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JECDKMJCGFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> KHLDMDHKJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder LLGFOHBEPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public KAFGIFPICBF OPIIPMIGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int OBKPANBDLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 INOGGBMDCHB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD820", Offset = "0x7FFCA20", VA = "0x187FFD820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD870", Offset = "0x7FFCA70", VA = "0x187FFD870")]
	public JECDKMJCGFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JGLBAKJJAIK
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KBPOFCDPNBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AELELAOEJII : KBPOFCDPNBH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JGLBAKJJAIK MLDBMJLBOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IEIIKMPLPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(HMCGDGIPDCE DMPJOANBNLH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(IHCKNOKFLCP ABECEAAIGGD, JECDKMJCGFK BBLAKKCCBNE, StringBuilder CDAPIGGLCLA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HHEGHGEIMOO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JGLBAKJJAIK GKNGJBFKFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(OJIMHFCMHLE JCFOMPGDMKN, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(OJIMHFCMHLE JCFOMPGDMKN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KOBJFFCEDLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool OFFDPDBNGLH;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FHFNCGDKEOA : AELELAOEJII, KBPOFCDPNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(KOBJFFCEDLD ABEDFFOJAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PHKJJCFDJMM : AELELAOEJII, KBPOFCDPNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(MGNNNNPADNA ICJKPMCNKAG, IHCKNOKFLCP ABECEAAIGGD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PJEEHPDAKGJ : KBPOFCDPNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder CDAPIGGLCLA, ALLJAELJMGC EJIFCBFMJHA, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FAMJNCFEMOB
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<CBFAMDHOPFE> OAOINKDHDDO();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DDIBCCPHDHC(object BKDMJHGCDEA, CBFAMDHOPFE LNODHBGPGBD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<JMFCLCMDBEE> PBHOMBGEGMC();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, FCCLCKGFKHO
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
		public delegate void DPICBAMIFNA(Guid MNIDIBHNEHE, Guid PKDDLDKEDIE);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class JMHMOFENBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class KPNOAOCNECE<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : AELELAOEJII
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
				private HashSet<AELELAOEJII> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<AELELAOEJII> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<AELELAOEJII>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
				[DebuggerHidden]
				public KPNOAOCNECE(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4B379B0", Offset = "0x4B36BB0", VA = "0x184B379B0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x516C2A0", Offset = "0x516B4A0", VA = "0x18516C2A0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x516C250", Offset = "0x516B450", VA = "0x18516C250")]
				private void DOCBGIOIEEK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x516C520", Offset = "0x516B720", VA = "0x18516C520", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4B77370", Offset = "0x4B76570", VA = "0x184B77370", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4B776E0", Offset = "0x4B768E0", VA = "0x184B776E0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<AELELAOEJII> KCOMIONJLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<AELELAOEJII> KBEPIKKMAKO;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7FFD930", Offset = "0x7FFCB30", VA = "0x187FFD930")]
			public void FHEOIINLIGN(JGLBAKJJAIK BIFIIFKONBE, AELELAOEJII ACDFCJHLKJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7FFDAA0", Offset = "0x7FFCCA0", VA = "0x187FFDAA0")]
			private static void MMONBPLGHPE(HashSet<AELELAOEJII> FKMJIBCPIPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x413B430", Offset = "0x413A630", VA = "0x18413B430")]
			public IEnumerable<T> MJJCFDMBDEB<T>(bool LNOBDKEECLM) where T : AELELAOEJII
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x388C9E0", Offset = "0x388BBE0", VA = "0x18388C9E0")]
			[IteratorStateMachine(typeof(KPNOAOCNECE<>))]
			private static IEnumerable<T> BDEGEAEEALA<T>(HashSet<AELELAOEJII> FKMJIBCPIPI) where T : AELELAOEJII
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public JMHMOFENBGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class MNGEIGDOBDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public MNGEIGDOBDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7FFE080", Offset = "0x7FFD280", VA = "0x187FFE080")]
			internal bool HCOLKFOOJIN(OMFKFPADFPH d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> BCIAFBMLEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool OPAMMLPDJDK;

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
		private ICEDNCJNAJM<Guid> HMPGFEGOCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<AELELAOEJII> BLCDBBGFDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<PJEEHPDAKGJ> GJFGGKJFEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private JMHMOFENBGJ BNHGHPNGANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid HNKAHLPOBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid EKLAMABACND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PPOFIDCPAOP KMNKNJGOGDO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> COHFBAMDIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8002D90", Offset = "0x8001F90", VA = "0x188002D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid HHPKMABLCHL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8002950", Offset = "0x8001B50", VA = "0x188002950")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8002EE0", Offset = "0x80020E0", VA = "0x188002EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KKKJFCLMKHP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x139ADE0", Offset = "0x1399FE0", VA = "0x18139ADE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x139AAA0", Offset = "0x1399CA0", VA = "0x18139AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JNOGNBGHEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8002A30", Offset = "0x8001C30", VA = "0x188002A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool GAHOABDLGPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7FFF280", Offset = "0x7FFE480", VA = "0x187FFF280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView JLOOLFKPNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA00BC0", Offset = "0x9FFDC0", VA = "0x180A00BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HFBBLOIMEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x80029E0", Offset = "0x8001BE0", VA = "0x1880029E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool DIPBHGEBJGB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x80000C0", Offset = "0x7FFF2C0", VA = "0x1880000C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DPICBAMIFNA LHHPJLJAKEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x80028A0", Offset = "0x8001AA0", VA = "0x1880028A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8002E30", Offset = "0x8002030", VA = "0x188002E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE2F0", Offset = "0x7FFD4F0", VA = "0x187FFE2F0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8000370", Offset = "0x7FFF570", VA = "0x188000370")]
		private bool MBECKKNDGIC([Out] Guid KACABHAHLOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8000B30", Offset = "0x7FFFD30", VA = "0x188000B30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8000700", Offset = "0x7FFF900", VA = "0x188000700", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FFF3E0", Offset = "0x7FFE5E0", VA = "0x187FFF3E0")]
		private void GKFGJPFMPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8000B30", Offset = "0x7FFFD30", VA = "0x188000B30")]
		private void OnMasterClientSwitched(BNFABCHNBCL NLIBDKKPKLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8000540", Offset = "0x7FFF740", VA = "0x188000540")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8001720", Offset = "0x8000920", VA = "0x188001720")]
		public void PreSerializeAsync(NKNHMBEFOJB<Task> PMJDJAMCDCG, StringBuilder CDAPIGGLCLA, ALLJAELJMGC EJIFCBFMJHA, CancellationToken FHBCOAHILMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8001B60", Offset = "0x8000D60", VA = "0x188001B60")]
		public IHCKNOKFLCP Serialize(JECDKMJCGFK BBLAKKCCBNE, StringBuilder CDAPIGGLCLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8000130", Offset = "0x7FFF330", VA = "0x188000130")]
		public void InitializeDeserialization(IHCKNOKFLCP ABECEAAIGGD, bool KFPGHJBENDJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8001200", Offset = "0x8000400", VA = "0x188001200")]
		public void PreDeserialize(bool LNOBDKEECLM, MGNNNNPADNA ICJKPMCNKAG, IHCKNOKFLCP ABECEAAIGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FFEA90", Offset = "0x7FFDC90", VA = "0x187FFEA90")]
		public void Deserialize(bool LNOBDKEECLM, HMCGDGIPDCE DMPJOANBNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8000D90", Offset = "0x7FFFF90", VA = "0x188000D90")]
		public void PostDeserialize(bool LNOBDKEECLM, KOBJFFCEDLD ABEDFFOJAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7FFF990", Offset = "0x7FFEB90", VA = "0x187FFF990")]
		private void HECOHLCDONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8000B40", Offset = "0x7FFFD40", VA = "0x188000B40")]
		private IHCKNOKFLCP PFHGHJLBICP(IHCKNOKFLCP MGHKLCBCPPP, ChildViewReference JPCNHODHEGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8000480", Offset = "0x7FFF680", VA = "0x188000480")]
		public void MarkExcludedFromRoomSave(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80025F0", Offset = "0x80017F0", VA = "0x1880025F0")]
		public void UnmarkExcludedFromRoomSave(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE920", Offset = "0x7FFDB20", VA = "0x187FFE920", Slot = "14")]
		public void Bake(FDMFIFPHKJP BKDMJHGCDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80027C0", Offset = "0x80019C0", VA = "0x1880027C0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFF130", Offset = "0x7FFE330", VA = "0x187FFF130")]
		[CompilerGenerated]
		private object EAGIJIDDJMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FFF200", Offset = "0x7FFE400", VA = "0x187FFF200")]
		[CompilerGenerated]
		private object FMJBNAKNLIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8000650", Offset = "0x7FFF850", VA = "0x188000650")]
		[CompilerGenerated]
		private object OEKJCMNBOIM()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CBFAMDHOPFE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool PHDPMJLNLEO(IMGOPGMMMDH CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NFLNKKNNPJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NFLNKKNNPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE1A0", Offset = "0x7FFD3A0", VA = "0x187FFE1A0")]
		internal Task NPOGAEBBAHD(IMGOPGMMMDH data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OLEJGIOAIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<IMGOPGMMMDH> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OLEJGIOAIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE240", Offset = "0x7FFD440", VA = "0x187FFE240")]
		internal Task NPOGAEBBAHD(IMGOPGMMMDH data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KICLIMKPADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KBNOLLLMMGI handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CBFAMDHOPFE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KICLIMKPADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDC70", Offset = "0x7FFCE70", VA = "0x187FFDC70")]
		internal object BGADBAODHLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<HIBEIMPBEBE, HashSet<(KBNOLLLMMGI, PHDPMJLNLEO, MNKAFBLBFBC)>> NJENNBOOHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid EIOCHJOFAHF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCB80", Offset = "0x7FFBD80", VA = "0x187FFCB80")]
	public CBFAMDHOPFE(Guid ECNHDFPBHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC940", Offset = "0x7FFBB40", VA = "0x187FFC940")]
	public CBFAMDHOPFE OHDHCEIHGPB(HIBEIMPBEBE DCEGHEFMDKM, KBNOLLLMMGI BIFIIFKONBE, MNKAFBLBFBC LNODHBGPGBD, [Optional] PHDPMJLNLEO GGJHELMAIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC850", Offset = "0x7FFBA50", VA = "0x187FFC850")]
	public CBFAMDHOPFE OHDHCEIHGPB(HIBEIMPBEBE DCEGHEFMDKM, KBNOLLLMMGI BIFIIFKONBE, Action LNODHBGPGBD, [Optional] PHDPMJLNLEO GGJHELMAIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC760", Offset = "0x7FFB960", VA = "0x187FFC760")]
	public CBFAMDHOPFE OHDHCEIHGPB(HIBEIMPBEBE DCEGHEFMDKM, KBNOLLLMMGI BIFIIFKONBE, Action<IMGOPGMMMDH> LNODHBGPGBD, [Optional] PHDPMJLNLEO GGJHELMAIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC380", Offset = "0x7FFB580", VA = "0x187FFC380")]
	public Dictionary<KBNOLLLMMGI, List<MNKAFBLBFBC>> CFELACPHDFH(HIBEIMPBEBE OFNKJHLMDDE, IMGOPGMMMDH CAIGHLKIDBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task JMFCLCMDBEE(CancellationToken FHBCOAHILMJ);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class FILPNNPFMIG : FAMJNCFEMOB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum IHINBNIKCIO
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
	private class JDDLMPLGLJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class EJOHNFFHGCI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object BKDMJHGCDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly CBFAMDHOPFE LNODHBGPGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> DKJMKPPMELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool OLFOBLPNEEI;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC9C830", Offset = "0xC9BA30", VA = "0x180C9C830")]
		public EJOHNFFHGCI(object BKDMJHGCDEA, CBFAMDHOPFE LNODHBGPGBD, Action<object> DKJMKPPMELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCEB0", Offset = "0x7FFC0B0", VA = "0x187FFCEB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, CBFAMDHOPFE> LEJDOBKMDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<JMFCLCMDBEE> DJLAJNJOCAI;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD370", Offset = "0x7FFC570", VA = "0x187FFD370")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void LDPAGBHHOJF(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD470", Offset = "0x7FFC670", VA = "0x187FFD470", Slot = "4")]
	public IReadOnlyList<CBFAMDHOPFE> OAOINKDHDDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCF50", Offset = "0x7FFC150", VA = "0x187FFCF50", Slot = "5")]
	public IDisposable DDIBCCPHDHC(object BKDMJHGCDEA, CBFAMDHOPFE LNODHBGPGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD4D0", Offset = "0x7FFC6D0", VA = "0x187FFD4D0", Slot = "6")]
	public IReadOnlyList<JMFCLCMDBEE> PBHOMBGEGMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCEF0", Offset = "0x7FFC0F0", VA = "0x187FFCEF0")]
	private void AKGOOPLGPMM(object BKDMJHGCDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD0D0", Offset = "0x7FFC2D0", VA = "0x187FFD0D0")]
	[AMFDJJKGJPA]
	internal static void FAMNGHPLDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD1B0", Offset = "0x7FFC3B0", VA = "0x187FFD1B0")]
	internal static void FKEDJLMBNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD2F0", Offset = "0x7FFC4F0", VA = "0x187FFD2F0")]
	internal void GCCMINLHDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD580", Offset = "0x7FFC780", VA = "0x187FFD580")]
	public FILPNNPFMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DDIBODPBLMP
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<HIBEIMPBEBE> LAEHDPLMKOC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<HIBEIMPBEBE> FHGDCNCNLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCC20", Offset = "0x7FFBE20", VA = "0x187FFCC20")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KDLPAPBPGJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct LMIKKIJMALC : IAsyncStateMachine
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
		public KDLPAPBPGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDD60", Offset = "0x7FFCF60", VA = "0x187FFDD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDF90", Offset = "0x7FFD190", VA = "0x187FFDF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float HFEHLKHHDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float DLHBCJLEHNE;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDC30", Offset = "0x7FFCE30", VA = "0x187FFDC30")]
	public KDLPAPBPGJJ(float DLHBCJLEHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDB20", Offset = "0x7FFCD20", VA = "0x187FFDB20")]
	[AsyncStateMachine(typeof(LMIKKIJMALC))]
	public Task AJBEIONPILO(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDC10", Offset = "0x7FFCE10", VA = "0x187FFDC10")]
	public void DNFMCNPCKDE()
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
