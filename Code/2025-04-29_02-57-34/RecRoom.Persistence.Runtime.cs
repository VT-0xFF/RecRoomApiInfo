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
using Photon.Pun;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E5FE40", Offset = "0x7E5F240", VA = "0x187E5FE40", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E65E70", Offset = "0x7E65270", VA = "0x187E65E70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct APCBODKDHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly AEHFCHJCBKK OOHHNOENPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte KHNCICOHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid GOPEMOLHOBL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E5EC60", Offset = "0x7E5E060", VA = "0x187E5EC60")]
	public APCBODKDHBC(AEHFCHJCBKK OOHHNOENPDL, byte KHNCICOHHHJ, Guid GOPEMOLHOBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task LMELJOKCJFH(PMABFBOEKAG KBIBHMCLJNL, CancellationToken JDDHIJBJNHP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class PMABFBOEKAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ACEACLGOILG KHMEGMBEJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, IBDHKNDIHNK)> LNELEEKPJJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public HNAJHGJKLNP JEPMFAPCNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public HABMELLNJLH JOKNLJGHCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KDFBLPMDGJH PHOILICHIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<KDFBLPMDGJH> NKECPKCAGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<KDFBLPMDGJH> MJHIPDLIOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KFOIBDNOLMJ EAIGINOACOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9E8570", Offset = "0x9E7970", VA = "0x1809E8570")]
		[CompilerGenerated]
		get
		{
			return default(KFOIBDNOLMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public MMIOGOBDHFC FHJNHBEDPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KPMJDHJBPEL MEPJGMDKFCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<APCBODKDHBC> JCIFIAJCGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CLFCELJMAMP ABJBKNOAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9CD810", Offset = "0x9CCC10", VA = "0x1809CD810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IMGEBIHMEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9CE3A0", Offset = "0x9CD7A0", VA = "0x1809CE3A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E60AC0", Offset = "0x7E5FEC0", VA = "0x187E60AC0")]
	public PMABFBOEKAG(HNAJHGJKLNP LBIMIKPLDOP, HABMELLNJLH LCHNEIADLCB, KDFBLPMDGJH PPHPDNDPIEF, IReadOnlyList<KDFBLPMDGJH> PJDKPHHKONO, IReadOnlyList<KDFBLPMDGJH> JHOLENFGBLD, KFOIBDNOLMJ HCNMCCFECNA, bool ALJHKDKIJNE, MMIOGOBDHFC NILNGFKCINL, KPMJDHJBPEL PBNEIBAJIIG, IEnumerable<APCBODKDHBC> NLGLIDCMIBD, CLFCELJMAMP MJINDKEPCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E60AA0", Offset = "0x7E5FEA0", VA = "0x187E60AA0")]
	public void OEDFKHMBCFB(ACEACLGOILG KGKADMCNBHD, List<(PersistenceView, IBDHKNDIHNK)> LDAIHJLBDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E60A30", Offset = "0x7E5FE30", VA = "0x187E60A30")]
	public List<(PersistenceView, IBDHKNDIHNK)> JNLIKMCDBPL(ACEACLGOILG BBKAHHJHGHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FOBHJDGLMCB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OGDDCPBMNHF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LFPMNEACGKC]
public enum ACEACLGOILG
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
public enum KFIALIOGHEG : byte
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
public interface KDFBLPMDGJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid GNADLEHNJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> MILIBCHAIGD();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPNCGPBCDME();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PEIIOAPNPOM(bool ONOKIJPLFIH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PAIJLNMPAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public KFOIBDNOLMJ HCNMCCFECNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public IBDHKNDIHNK GEBIOONDCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool DECPFHALLJF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MLEJOHEHBLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> IGDLCDOJIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder GKIPCPOAHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public PNALHNEBOIF CMOGGAHPBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int IEEAGAKEEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 ACMGABNGNFC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5FF70", Offset = "0x7E5F370", VA = "0x187E5FF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E5FFC0", Offset = "0x7E5F3C0", VA = "0x187E5FFC0")]
	public MLEJOHEHBLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GDMPHNLACCA
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DEFOMCHDHCN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KKPGIIMOHFK : DEFOMCHDHCN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GDMPHNLACCA NBNFLGPGMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BOJIBKHPDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(PAIJLNMPAPI NFHAPFFMIEK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(IBDHKNDIHNK GEBIOONDCDF, MLEJOHEHBLD DFMGFJGFHAC, StringBuilder FIADBDOFFPP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BFFIKGCDJNF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GDMPHNLACCA NPCJNMMEPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(MMIOGOBDHFC NILNGFKCINL, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(MMIOGOBDHFC NILNGFKCINL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct APJFFJGBOFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool DECPFHALLJF;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FBFLMAPBDAH : KKPGIIMOHFK, DEFOMCHDHCN
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(APJFFJGBOFK NHHIGHJBJKK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NOFHJGGPBKD : KKPGIIMOHFK, DEFOMCHDHCN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(KFOIBDNOLMJ HCNMCCFECNA, IBDHKNDIHNK GEBIOONDCDF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FAIHFLDGBJA : DEFOMCHDHCN
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder FIADBDOFFPP, OGDDCPBMNHF OBICHNFPNBD, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JCLFAFBONEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<OOEHAOJOEMN> GCFDDMNCOCJ();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OGOHKNJGGBA(object FAJBNOJIOHK, OOEHAOJOEMN CBFIOILKHPI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<BPEMJMDHKBJ> MKIHMLBECDI();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun, ABEGHIDPNFJ
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
		public delegate void FODLNKAMIOF(Guid HCJIBANFHEN, Guid CEEIAKMCHOI);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class DLCLAECGMED
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class DLKKJCJADEG<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : KKPGIIMOHFK
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
				private HashSet<KKPGIIMOHFK> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<KKPGIIMOHFK> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<KKPGIIMOHFK>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
				[DebuggerHidden]
				public DLKKJCJADEG(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x481FFA0", Offset = "0x481F3A0", VA = "0x18481FFA0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x68EDA30", Offset = "0x68ECE30", VA = "0x1868EDA30", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x68ED9E0", Offset = "0x68ECDE0", VA = "0x1868ED9E0")]
				private void BIIMICBPMMK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x68EDCD0", Offset = "0x68ED0D0", VA = "0x1868EDCD0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x48211A0", Offset = "0x48205A0", VA = "0x1848211A0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x47F4C80", Offset = "0x47F4080", VA = "0x1847F4C80", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<KKPGIIMOHFK> HONEBMFAIAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<KKPGIIMOHFK> KDLPFINIAKA;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7E5EDF0", Offset = "0x7E5E1F0", VA = "0x187E5EDF0")]
			public void APGIJPNCEOJ(GDMPHNLACCA CCLCPBPKBKJ, KKPGIIMOHFK NLKPKDAOFMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7E5EF60", Offset = "0x7E5E360", VA = "0x187E5EF60")]
			private static void GDFPDBALHAC(HashSet<KKPGIIMOHFK> ILMOMHGFJFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD4B0", Offset = "0x3DDC8B0", VA = "0x183DDD4B0")]
			public IEnumerable<T> DLAOHPIONIJ<T>(bool LDOEEBNNAPN) where T : KKPGIIMOHFK
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x35DBA20", Offset = "0x35DAE20", VA = "0x1835DBA20")]
			[IteratorStateMachine(typeof(DLKKJCJADEG<>))]
			private static IEnumerable<T> AAOJBLLAOBE<T>(HashSet<KKPGIIMOHFK> ILMOMHGFJFP) where T : KKPGIIMOHFK
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public DLCLAECGMED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class EDJPCJBDKLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EDJPCJBDKLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7E5F280", Offset = "0x7E5E680", VA = "0x187E5F280")]
			internal bool GEPOEPOFDPM(FBBPAFKFKDH d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> KILLCIGFLML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool EEDMALKABKO;

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
		private MOKPFNENEFJ<Guid> JLFCONFKAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<KKPGIIMOHFK> JBCJLFEOBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<FAIHFLDGBJA> LBNNPHFOJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DLCLAECGMED BOCOGPPKJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid BAEHEGGACCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid GBBGGHCMBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MPPAGCOCNOM FCDGBNAKHCJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> GEEKMAFPDAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7E656D0", Offset = "0x7E64AD0", VA = "0x187E656D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid NKGPMMKCOJL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7E65290", Offset = "0x7E64690", VA = "0x187E65290")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7E65820", Offset = "0x7E64C20", VA = "0x187E65820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DGDNJOPGFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD4A620", Offset = "0xD49A20", VA = "0x180D4A620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD4A640", Offset = "0xD49A40", VA = "0x180D4A640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool KDELELLOMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7E65370", Offset = "0x7E64770", VA = "0x187E65370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool ACJGEBJLGGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7E61210", Offset = "0x7E60610", VA = "0x187E61210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView DFOMMEELKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9C9240", Offset = "0x9C8640", VA = "0x1809C9240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool GFMIPJIMGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7E65320", Offset = "0x7E64720", VA = "0x187E65320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool GNOMIGMEBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7E614E0", Offset = "0x7E608E0", VA = "0x187E614E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FODLNKAMIOF FGGLECJKCIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7E651E0", Offset = "0x7E645E0", VA = "0x187E651E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7E65770", Offset = "0x7E64B70", VA = "0x187E65770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E60C00", Offset = "0x7E60000", VA = "0x187E60C00", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E62D40", Offset = "0x7E62140", VA = "0x187E62D40")]
		private bool LAFDCFPHCDF([Out] Guid CCBANMKJOCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E636A0", Offset = "0x7E62AA0", VA = "0x187E636A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E63280", Offset = "0x7E62680", VA = "0x187E63280", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E61D20", Offset = "0x7E61120", VA = "0x187E61D20")]
		private void IACFFBDKHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E636A0", Offset = "0x7E62AA0", VA = "0x187E636A0")]
		private void OnMasterClientSwitched(AFBJPBGMJIG PCGEDHPAHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E62F20", Offset = "0x7E62320", VA = "0x187E62F20")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E64040", Offset = "0x7E63440", VA = "0x187E64040")]
		public void PreSerializeAsync(OAGGALGHDAH<Task> JMMADGCFAHH, StringBuilder FIADBDOFFPP, OGDDCPBMNHF OBICHNFPNBD, CancellationToken JDDHIJBJNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E64480", Offset = "0x7E63880", VA = "0x187E64480")]
		public IBDHKNDIHNK Serialize(MLEJOHEHBLD DFMGFJGFHAC, StringBuilder FIADBDOFFPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E62AF0", Offset = "0x7E61EF0", VA = "0x187E62AF0")]
		public void InitializeDeserialization(IBDHKNDIHNK GEBIOONDCDF, bool OJEIHFDJJNN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E63B20", Offset = "0x7E62F20", VA = "0x187E63B20")]
		public void PreDeserialize(bool LDOEEBNNAPN, KFOIBDNOLMJ HCNMCCFECNA, IBDHKNDIHNK GEBIOONDCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E61550", Offset = "0x7E60950", VA = "0x187E61550")]
		public void Deserialize(bool LDOEEBNNAPN, PAIJLNMPAPI NFHAPFFMIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E636B0", Offset = "0x7E62AB0", VA = "0x187E636B0")]
		public void PostDeserialize(bool LDOEEBNNAPN, APJFFJGBOFK NHHIGHJBJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E622E0", Offset = "0x7E616E0", VA = "0x187E622E0")]
		private void IDMGLDIGIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E63030", Offset = "0x7E62430", VA = "0x187E63030")]
		private IBDHKNDIHNK OOEPJJHBIAJ(IBDHKNDIHNK BBCMFMHAFIM, ChildViewReference EDKEHABGEPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7E62E50", Offset = "0x7E62250", VA = "0x187E62E50")]
		public void MarkExcludedFromRoomSave(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E64F10", Offset = "0x7E64310", VA = "0x187E64F10")]
		public void UnmarkExcludedFromRoomSave(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7E61370", Offset = "0x7E60770", VA = "0x187E61370", Slot = "13")]
		public void Bake(NCJHHPABBJL FAJBNOJIOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7E650F0", Offset = "0x7E644F0", VA = "0x187E650F0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E62A10", Offset = "0x7E61E10", VA = "0x187E62A10")]
		[CompilerGenerated]
		private object IFIJCJFCKCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E61CA0", Offset = "0x7E610A0", VA = "0x187E61CA0")]
		[CompilerGenerated]
		private object FOPDKBIIKGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7E61BF0", Offset = "0x7E60FF0", VA = "0x187E61BF0")]
		[CompilerGenerated]
		private object ENGLIJPFANE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OOEHAOJOEMN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool NHFDFGDFKHM(PMABFBOEKAG AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MKHDPLPDKIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MKHDPLPDKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5FED0", Offset = "0x7E5F2D0", VA = "0x187E5FED0")]
		internal Task JEHIFGAHPHH(PMABFBOEKAG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PDPCKGOECCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<PMABFBOEKAG> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PDPCKGOECCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E60980", Offset = "0x7E5FD80", VA = "0x187E60980")]
		internal Task JEHIFGAHPHH(PMABFBOEKAG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EKPJAOHGKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KFIALIOGHEG handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OOEHAOJOEMN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public EKPJAOHGKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5F2A0", Offset = "0x7E5E6A0", VA = "0x187E5F2A0")]
		internal object CNPPLGPMNFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<ACEACLGOILG, HashSet<(KFIALIOGHEG, NHFDFGDFKHM, LMELJOKCJFH)>> ANEAFNDKFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid KLNADGKLNGK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E608E0", Offset = "0x7E5FCE0", VA = "0x187E608E0")]
	public OOEHAOJOEMN(Guid FODGMGKEIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E602A0", Offset = "0x7E5F6A0", VA = "0x187E602A0")]
	public OOEHAOJOEMN COEOOJPKHJF(ACEACLGOILG GDGACIJCKIL, KFIALIOGHEG CCLCPBPKBKJ, LMELJOKCJFH CBFIOILKHPI, [Optional] NHFDFGDFKHM FDHNGHFOIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E600C0", Offset = "0x7E5F4C0", VA = "0x187E600C0")]
	public OOEHAOJOEMN COEOOJPKHJF(ACEACLGOILG GDGACIJCKIL, KFIALIOGHEG CCLCPBPKBKJ, Action CBFIOILKHPI, [Optional] NHFDFGDFKHM FDHNGHFOIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E601B0", Offset = "0x7E5F5B0", VA = "0x187E601B0")]
	public OOEHAOJOEMN COEOOJPKHJF(ACEACLGOILG GDGACIJCKIL, KFIALIOGHEG CCLCPBPKBKJ, Action<PMABFBOEKAG> CBFIOILKHPI, [Optional] NHFDFGDFKHM FDHNGHFOIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E604F0", Offset = "0x7E5F8F0", VA = "0x187E604F0")]
	public Dictionary<KFIALIOGHEG, List<LMELJOKCJFH>> FAAALGEHADJ(ACEACLGOILG KGKADMCNBHD, PMABFBOEKAG AOFGGGKINCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task BPEMJMDHKBJ(CancellationToken JDDHIJBJNHP);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class ICJBLFBJLAO : JCLFAFBONEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum AHINFPAEAGA
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
	private class FIEKJJECPKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class NFIACMPLEKA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object FAJBNOJIOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly OOEHAOJOEMN CBFIOILKHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> DEEDCNJFFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool FJEDLGBMFFE;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC237D0", Offset = "0xC22BD0", VA = "0x180C237D0")]
		public NFIACMPLEKA(object FAJBNOJIOHK, OOEHAOJOEMN CBFIOILKHPI, Action<object> DEEDCNJFFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7E60080", Offset = "0x7E5F480", VA = "0x187E60080", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, OOEHAOJOEMN> CKDJJJGEKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<BPEMJMDHKBJ> FBFPGAANPPI;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F8A0", Offset = "0x7E5ECA0", VA = "0x187E5F8A0")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	internal static void OFPJHOBLCJH(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F5E0", Offset = "0x7E5E9E0", VA = "0x187E5F5E0", Slot = "4")]
	public IReadOnlyList<OOEHAOJOEMN> GCFDDMNCOCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F9A0", Offset = "0x7E5EDA0", VA = "0x187E5F9A0", Slot = "5")]
	public IDisposable OGOHKNJGGBA(object FAJBNOJIOHK, OOEHAOJOEMN CBFIOILKHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F860", Offset = "0x7E5EC60", VA = "0x187E5F860", Slot = "6")]
	public IReadOnlyList<BPEMJMDHKBJ> MKIHMLBECDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F800", Offset = "0x7E5EC00", VA = "0x187E5F800")]
	private void HKJIJLDCDCB(object FAJBNOJIOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E5FB20", Offset = "0x7E5EF20", VA = "0x187E5FB20")]
	[GEMHNPPGODB]
	internal static void POLKKCDFNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F6C0", Offset = "0x7E5EAC0", VA = "0x187E5F6C0")]
	internal static void HAHHCGEAEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F640", Offset = "0x7E5EA40", VA = "0x187E5F640")]
	internal void GHOFNPKFDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5FC70", Offset = "0x7E5F070", VA = "0x187E5FC70")]
	public ICJBLFBJLAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DOHLFCMJGFF
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<ACEACLGOILG> CIGLGPGOOOC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<ACEACLGOILG> NDHKGCCEODA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7E5EFE0", Offset = "0x7E5E3E0", VA = "0x187E5EFE0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CGIJHFBFBKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HBPOLNMCOCE : IAsyncStateMachine
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
		public CGIJHFBFBKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E5F350", Offset = "0x7E5E750", VA = "0x187E5F350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E5F580", Offset = "0x7E5E980", VA = "0x187E5F580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float LDIGBAENPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float DMAPNJBHBFJ;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E5EDB0", Offset = "0x7E5E1B0", VA = "0x187E5EDB0")]
	public CGIJHFBFBKP(float DMAPNJBHBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E5ECA0", Offset = "0x7E5E0A0", VA = "0x187E5ECA0")]
	[AsyncStateMachine(typeof(HBPOLNMCOCE))]
	public Task GCKJMANDHND(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E5ED90", Offset = "0x7E5E190", VA = "0x187E5ED90")]
	public void ICMDEPLACPK()
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
