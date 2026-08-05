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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x874A600", Offset = "0x8749400", VA = "0x18874A600", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x874FF50", Offset = "0x874ED50", VA = "0x18874FF50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EOFGCLOEFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly GIHLGICFDGM LNOIBELIIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte ADGMECOLKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid LHMBOGGFNPO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8749B60", Offset = "0x8748960", VA = "0x188749B60")]
	public EOFGCLOEFFA(GIHLGICFDGM LNOIBELIIAB, byte ADGMECOLKNH, Guid LHMBOGGFNPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task HHADGHAIIGC(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken BKHGNHANFKK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CHNMCCPJHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NEDOGNOPDGH NEBDMLAJNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, NBHBELOMHAF)> JGMFDDIIMFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public CPKIDEJABEO JMMDCBNKILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public COOMNKKPKFC GAAPILLOKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BCLIAPEMAFA HJEMLCBELKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<BCLIAPEMAFA> MIFBINCPGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<BCLIAPEMAFA> LHEADKNPOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OENCDFMFFLF OKAAFGMMPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		[CompilerGenerated]
		get
		{
			return default(OENCDFMFFLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public GJJFFFDCKLI EHKALJCKOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LFIMFEFFJLO KHLKNFODDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EOFGCLOEFFA> GBGHIJHBBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GMPLNGBLHHL OOPEIEGPEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NJKGIEKGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA98B80", Offset = "0xA97980", VA = "0x180A98B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8749140", Offset = "0x8747F40", VA = "0x188749140")]
	public CHNMCCPJHLL(CPKIDEJABEO ENGKJAJBOCI, COOMNKKPKFC ENMKJMAPPOB, BCLIAPEMAFA MKMGAJBOGBA, IReadOnlyList<BCLIAPEMAFA> NBKCNLFHIHI, IReadOnlyList<BCLIAPEMAFA> MIOIHDOIABC, OENCDFMFFLF MJEPOGFPEAD, bool CGLCMGDALNO, GJJFFFDCKLI OEACCCPPJMI, LFIMFEFFJLO JJDLOODFHIA, IEnumerable<EOFGCLOEFFA> IHEHBFNEGEC, GMPLNGBLHHL MKAGCEFOBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8749120", Offset = "0x8747F20", VA = "0x188749120")]
	public void LJKEKBGCDLC(NEDOGNOPDGH KCMLCIKBODA, List<(PersistenceView, NBHBELOMHAF)> IFJJIKHPOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x87490B0", Offset = "0x8747EB0", VA = "0x1887490B0")]
	public List<(PersistenceView, NBHBELOMHAF)> GBMNMBBBPCL(NEDOGNOPDGH JJODEDLLCFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AFPPAFDLPDP
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GHBEDJAHBFG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MDLMCBIIKPC]
public enum NEDOGNOPDGH
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
public enum NOOHFCFLEMD : byte
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
public interface BCLIAPEMAFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid EJDIBFPKOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> FBLPCMOEKAJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEELLNOEKNF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OIJEGBCJFCH(bool EMGGJEGIEKM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct INLKNBHLIAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OENCDFMFFLF MJEPOGFPEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NBHBELOMHAF MLOICMPKKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool PGHBDKCEKOD;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MENBPLBKBNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> PDDBFGIOJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder LCAAPKFEJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public KMCJALDLNNE JDIIHHBGIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int CEMGNKNNHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 CDGCMDEODOJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x874A920", Offset = "0x8749720", VA = "0x18874A920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x874A970", Offset = "0x8749770", VA = "0x18874A970")]
	public MENBPLBKBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum DNPMMMLILLO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BAOPJCOABPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LKKKIJDIJGP : BAOPJCOABPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DNPMMMLILLO GFKEBEMJHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JEDGICHDAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(INLKNBHLIAN BFCCGHGEPKD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(NBHBELOMHAF MLOICMPKKEC, MENBPLBKBNC NKIDENMICPE, StringBuilder NHLGECKEMIO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PGCCLIJJMAA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DNPMMMLILLO ANJNLAIICFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(GJJFFFDCKLI OEACCCPPJMI, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(GJJFFFDCKLI OEACCCPPJMI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EGJCACEBMBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool PGHBDKCEKOD;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GEBKJIBPONE : LKKKIJDIJGP, BAOPJCOABPP
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(EGJCACEBMBD IDIIIMKBDHN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MGCHCCENIFL : LKKKIJDIJGP, BAOPJCOABPP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(OENCDFMFFLF MJEPOGFPEAD, NBHBELOMHAF MLOICMPKKEC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LJDCJOEBBDP : BAOPJCOABPP
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder NHLGECKEMIO, GHBEDJAHBFG KPMIKLAENNK, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NFGFJOGJHBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<ECPGLILLNAG> CGNLNGMICBD();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HKHMIGLNKKC(object KKBNGKDBMPF, ECPGLILLNAG PMJKNCNKPFJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<AKHHBPOFABD> EFLGONGPJMB();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, DNAFFEFDHCK
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
		public delegate void LIOEJLEENOH(Guid NFPGFFHIDLK, Guid MJLAOPNKMCH);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class NHGIEMFIGPA
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class GHAGOBHJEEL<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : LKKKIJDIJGP
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
				private HashSet<LKKKIJDIJGP> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<LKKKIJDIJGP> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<LKKKIJDIJGP>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
				[DebuggerHidden]
				public GHAGOBHJEEL(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4A44230", Offset = "0x4A43030", VA = "0x184A44230", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4FE52A0", Offset = "0x4FE40A0", VA = "0x184FE52A0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4FE5530", Offset = "0x4FE4330", VA = "0x184FE5530")]
				private void POCLDLCLENG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4FE5580", Offset = "0x4FE4380", VA = "0x184FE5580", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4F75600", Offset = "0x4F74400", VA = "0x184F75600", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4F000C0", Offset = "0x4EFEEC0", VA = "0x184F000C0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<LKKKIJDIJGP> NNJPNMKMCME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<LKKKIJDIJGP> NMABGDNAIND;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x874AB00", Offset = "0x8749900", VA = "0x18874AB00")]
			public void ENCDNJLEOIK(DNPMMMLILLO NPDDPGCPBLA, LKKKIJDIJGP FNBMCGEEOFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x874AC70", Offset = "0x8749A70", VA = "0x18874AC70")]
			private static void LEKDGLMCFGC(HashSet<LKKKIJDIJGP> OKDBCONHNNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x444C7C0", Offset = "0x444B5C0", VA = "0x18444C7C0")]
			public IEnumerable<T> CPANCEEINJD<T>(bool BDBKOLMAHLF) where T : LKKKIJDIJGP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3C27E50", Offset = "0x3C26C50", VA = "0x183C27E50")]
			[IteratorStateMachine(typeof(GHAGOBHJEEL<>))]
			private static IEnumerable<T> MKNGCIPFHEI<T>(HashSet<LKKKIJDIJGP> OKDBCONHNNO) where T : LKKKIJDIJGP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public NHGIEMFIGPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class MGNNFBENMIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public MGNNFBENMIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x874AA30", Offset = "0x8749830", VA = "0x18874AA30")]
			internal bool FAJLBEOLKOH(JHBEHIICCBL d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> EEGKBHMLABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool GGPNPJBIMEN;

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
		private PCPGENHLMHE<Guid> EOMHMPKFBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<LKKKIJDIJGP> BLLNHLNANPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<LJDCJOEBBDP> OJOLLKKLPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private NHGIEMFIGPA OINFCHMMKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid KONMNAGEPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid LJOLPNBFKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private LKAPBLPAEMI FLNKMANOOBG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> BCIAFDFLNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x874F7E0", Offset = "0x874E5E0", VA = "0x18874F7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid FBLHFPABBMB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x874F3B0", Offset = "0x874E1B0", VA = "0x18874F3B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x874F930", Offset = "0x874E730", VA = "0x18874F930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HMFHDOPLEOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1567B50", Offset = "0x1566950", VA = "0x181567B50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1567400", Offset = "0x1566200", VA = "0x181567400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool FNINMDBGCOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x874F490", Offset = "0x874E290", VA = "0x18874F490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool GEOLAPMAEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x874CCD0", Offset = "0x874BAD0", VA = "0x18874CCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView OLMDEAKHBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool FHJJLMAMLNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x874F440", Offset = "0x874E240", VA = "0x18874F440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool MKPMBBACNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x874C050", Offset = "0x874AE50", VA = "0x18874C050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event LIOEJLEENOH GIMGGFOIKLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x874F300", Offset = "0x874E100", VA = "0x18874F300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x874F880", Offset = "0x874E680", VA = "0x18874F880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x874AEA0", Offset = "0x8749CA0", VA = "0x18874AEA0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x874AD90", Offset = "0x8749B90", VA = "0x18874AD90")]
		private bool AAGJNFNOAPI([Out] Guid BGMEHECEGNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x874D260", Offset = "0x874C060", VA = "0x18874D260")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x874CE30", Offset = "0x874BC30", VA = "0x18874CE30", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x874D270", Offset = "0x874C070", VA = "0x18874D270")]
		private void POEHPFMGLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x874D260", Offset = "0x874C060", VA = "0x18874D260")]
		private void OnMasterClientSwitched(AFLCFHLHEHB GLMBLPAKFLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x874CBC0", Offset = "0x874B9C0", VA = "0x18874CBC0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x874E190", Offset = "0x874CF90", VA = "0x18874E190")]
		public void PreSerializeAsync(LIJJHMMHNOE<Task> IDOIFJCJKJG, StringBuilder NHLGECKEMIO, GHBEDJAHBFG KPMIKLAENNK, CancellationToken BKHGNHANFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x874E5D0", Offset = "0x874D3D0", VA = "0x18874E5D0")]
		public NBHBELOMHAF Serialize(MENBPLBKBNC NKIDENMICPE, StringBuilder NHLGECKEMIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x874C7F0", Offset = "0x874B5F0", VA = "0x18874C7F0")]
		public void InitializeDeserialization(NBHBELOMHAF MLOICMPKKEC, bool KNHKPKBDKMC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x874DC80", Offset = "0x874CA80", VA = "0x18874DC80")]
		public void PreDeserialize(bool BDBKOLMAHLF, OENCDFMFFLF MJEPOGFPEAD, NBHBELOMHAF MLOICMPKKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x874B770", Offset = "0x874A570", VA = "0x18874B770")]
		public void Deserialize(bool BDBKOLMAHLF, INLKNBHLIAN BFCCGHGEPKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x874D810", Offset = "0x874C610", VA = "0x18874D810")]
		public void PostDeserialize(bool BDBKOLMAHLF, EGJCACEBMBD IDIIIMKBDHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x874C0C0", Offset = "0x874AEC0", VA = "0x18874C0C0")]
		private void INJAJEGAHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x874BE00", Offset = "0x874AC00", VA = "0x18874BE00")]
		private NBHBELOMHAF EMBBAPHAFBM(NBHBELOMHAF PMGLIBAECGJ, ChildViewReference NKJCHADOMOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x874CB00", Offset = "0x874B900", VA = "0x18874CB00")]
		public void MarkExcludedFromRoomSave(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x874F050", Offset = "0x874DE50", VA = "0x18874F050")]
		public void UnmarkExcludedFromRoomSave(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x874B550", Offset = "0x874A350", VA = "0x18874B550", Slot = "14")]
		public void Bake(LDEHODDHNKL KKBNGKDBMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x874F220", Offset = "0x874E020", VA = "0x18874F220")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x874CA30", Offset = "0x874B830", VA = "0x18874CA30")]
		[CompilerGenerated]
		private object LNLCKGEPHMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x874B4D0", Offset = "0x874A2D0", VA = "0x18874B4D0")]
		[CompilerGenerated]
		private object BINOKEPMIHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x874B6C0", Offset = "0x874A4C0", VA = "0x18874B6C0")]
		[CompilerGenerated]
		private object DEIPBDPKBGJ()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ECPGLILLNAG
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool EMCMCLDLJDN(CHNMCCPJHLL KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NOGGEOPJPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NOGGEOPJPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x874ACF0", Offset = "0x8749AF0", VA = "0x18874ACF0")]
		internal Task AIANJLMDIAN(CHNMCCPJHLL data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MONJLINAJOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<CHNMCCPJHLL> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MONJLINAJOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x874AA50", Offset = "0x8749850", VA = "0x18874AA50")]
		internal Task AIANJLMDIAN(CHNMCCPJHLL data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GFIBAIDGIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NOOHFCFLEMD handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ECPGLILLNAG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GFIBAIDGIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8749CF0", Offset = "0x8748AF0", VA = "0x188749CF0")]
		internal object KOBOKACHOAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<NEDOGNOPDGH, HashSet<(NOOHFCFLEMD, EMCMCLDLJDN, HHADGHAIIGC)>> AHMDHNOLBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid IDMLBGBHNDH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8749AC0", Offset = "0x87488C0", VA = "0x188749AC0")]
	public ECPGLILLNAG(Guid COHLMABABDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x87496A0", Offset = "0x87484A0", VA = "0x1887496A0")]
	public ECPGLILLNAG OMGNCONJMLA(NEDOGNOPDGH HNHLPMGNNFL, NOOHFCFLEMD NPDDPGCPBLA, HHADGHAIIGC PMJKNCNKPFJ, [Optional] EMCMCLDLJDN GFMDIDCJPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x87498E0", Offset = "0x87486E0", VA = "0x1887498E0")]
	public ECPGLILLNAG OMGNCONJMLA(NEDOGNOPDGH HNHLPMGNNFL, NOOHFCFLEMD NPDDPGCPBLA, Action PMJKNCNKPFJ, [Optional] EMCMCLDLJDN GFMDIDCJPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x87499D0", Offset = "0x87487D0", VA = "0x1887499D0")]
	public ECPGLILLNAG OMGNCONJMLA(NEDOGNOPDGH HNHLPMGNNFL, NOOHFCFLEMD NPDDPGCPBLA, Action<CHNMCCPJHLL> PMJKNCNKPFJ, [Optional] EMCMCLDLJDN GFMDIDCJPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x87492C0", Offset = "0x87480C0", VA = "0x1887492C0")]
	public Dictionary<NOOHFCFLEMD, List<HHADGHAIIGC>> KNOMHGDHCPL(NEDOGNOPDGH KCMLCIKBODA, CHNMCCPJHLL KANAIIDGHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task AKHHBPOFABD(CancellationToken BKHGNHANFKK);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class HCBJNGDPBEI : NFGFJOGJHBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum DOAJFLGNGII
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
	private class ALEHHALGAIJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class CNJPPALIKPC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object KKBNGKDBMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly ECPGLILLNAG PMJKNCNKPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> EKPFNGGFEIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool PJLPIIDDCCN;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xDE3F00", Offset = "0xDE2D00", VA = "0x180DE3F00")]
		public CNJPPALIKPC(object KKBNGKDBMPF, ECPGLILLNAG PMJKNCNKPFJ, Action<object> EKPFNGGFEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8749280", Offset = "0x8748080", VA = "0x188749280", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, ECPGLILLNAG> IHLMCLAFHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<AKHHBPOFABD> GKBFDJOICIJ;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x874A2C0", Offset = "0x87490C0", VA = "0x18874A2C0")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void ODAPPKPCBLD(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8749F00", Offset = "0x8748D00", VA = "0x188749F00", Slot = "4")]
	public IReadOnlyList<ECPGLILLNAG> CGNLNGMICBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8749FA0", Offset = "0x8748DA0", VA = "0x188749FA0", Slot = "5")]
	public IDisposable HKHMIGLNKKC(object KKBNGKDBMPF, ECPGLILLNAG PMJKNCNKPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8749F60", Offset = "0x8748D60", VA = "0x188749F60", Slot = "6")]
	public IReadOnlyList<AKHHBPOFABD> EFLGONGPJMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x874A120", Offset = "0x8748F20", VA = "0x18874A120")]
	private void IHABICMKPAI(object KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8749E20", Offset = "0x8748C20", VA = "0x188749E20")]
	[NCBGFGMJMIH]
	internal static void CDANIOHNGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x874A180", Offset = "0x8748F80", VA = "0x18874A180")]
	internal static void KFIKIPOKDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8749DA0", Offset = "0x8748BA0", VA = "0x188749DA0")]
	internal void BNHEMOABJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x874A430", Offset = "0x8749230", VA = "0x18874A430")]
	public HCBJNGDPBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MDICIFEAMKP
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<NEDOGNOPDGH> EFPOHMOIBEN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<NEDOGNOPDGH> PABOEPENAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x874A690", Offset = "0x8749490", VA = "0x18874A690")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FLBILAKLEAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct BFIOONOPDDM : IAsyncStateMachine
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
		public FLBILAKLEAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8748E20", Offset = "0x8747C20", VA = "0x188748E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8749050", Offset = "0x8747E50", VA = "0x188749050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float HGBAPOJENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float OGFINLNPDLN;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8749CB0", Offset = "0x8748AB0", VA = "0x188749CB0")]
	public FLBILAKLEAJ(float OGFINLNPDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8749BA0", Offset = "0x87489A0", VA = "0x188749BA0")]
	[AsyncStateMachine(typeof(BFIOONOPDDM))]
	public Task CDCKGBOLLAD(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8749C90", Offset = "0x8748A90", VA = "0x188749C90")]
	public void KNFHOLHMALL()
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
