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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80F88D0", Offset = "0x80F72D0", VA = "0x1880F88D0", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x80FE960", Offset = "0x80FD360", VA = "0x1880FE960", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KFMMELOCOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly DNIFFLNPKOK KOLHILAFMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte HHCAOFMCNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid FEMLBAPAKMP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80F8890", Offset = "0x80F7290", VA = "0x1880F8890")]
	public KFMMELOCOBN(DNIFFLNPKOK KOLHILAFMEA, byte HHCAOFMCNLG, Guid FEMLBAPAKMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task MPALOKCIKAK(JFCHLDJHBKP MPEOAHOICFG, CancellationToken JKPNCAGHEDI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JFCHLDJHBKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NBLBPMKGJIE EBMKMKFENHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, CEIEJPOFNOJ)> OMKEOCAFHAH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public PFLGPOLCCPC ONDHLOICOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public BBAIIGBMJIM JJCDGBLJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HHAOPNLAPFK KJMGEEFLNND
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<HHAOPNLAPFK> BAMMDIJOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<HHAOPNLAPFK> AEJFMOMEODM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OGEHLNKGNIL EKLEFHOIMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA288C0", Offset = "0xA272C0", VA = "0x180A288C0")]
		[CompilerGenerated]
		get
		{
			return default(OGEHLNKGNIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public BGHEHCDAEKD HALLFPHKOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FKOCDIMDNEB MCKKDELNLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<KFMMELOCOBN> GJAEFNHNPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LANBKINAPGH LMDJHPKBDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BFDDEDJEDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA17C20", Offset = "0xA16620", VA = "0x180A17C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x80F8750", Offset = "0x80F7150", VA = "0x1880F8750")]
	public JFCHLDJHBKP(PFLGPOLCCPC DOMHKNEHBED, BBAIIGBMJIM HGINIPFJDPN, HHAOPNLAPFK HPHKGJBKOGK, IReadOnlyList<HHAOPNLAPFK> FCCOKIGBBEM, IReadOnlyList<HHAOPNLAPFK> JKKLCPNFEHO, OGEHLNKGNIL HBMKKDHLJMD, bool HPDAINBENAE, BGHEHCDAEKD NIAPBNPEIPM, FKOCDIMDNEB OHHJLEDHKKJ, IEnumerable<KFMMELOCOBN> HAENKMJHJBL, LANBKINAPGH FMGBEDEGLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80F8730", Offset = "0x80F7130", VA = "0x1880F8730")]
	public void PKACNIFBMMK(NBLBPMKGJIE CGPMPJFAAHA, List<(PersistenceView, CEIEJPOFNOJ)> FHGEBGHKCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80F86C0", Offset = "0x80F70C0", VA = "0x1880F86C0")]
	public List<(PersistenceView, CEIEJPOFNOJ)> BLFAHGLLJEO(NBLBPMKGJIE PMGGJNOIHIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GCBBLAMCFIM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum LOECPFNBOHH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[OJFLIIHNHDJ]
public enum NBLBPMKGJIE
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
public enum LAILNAMDFHD : byte
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
public interface HHAOPNLAPFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid PJGFMPKJDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> CCAKCDLCGPH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKNJPFOCLIN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGBNOEPLIPG(bool AMNLHOCLHPL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PFIMHECEGJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OGEHLNKGNIL HBMKKDHLJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public CEIEJPOFNOJ IMNAAJEOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool IILCBCCKGAJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OHBJFKNEAGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> JBNEINKJOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder BJNAAIKBJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public AMPPJBENADP IDHHCHDODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JCFHFDAAHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 ADANDOBLDKE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80F9590", Offset = "0x80F7F90", VA = "0x1880F9590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80F95E0", Offset = "0x80F7FE0", VA = "0x1880F95E0")]
	public OHBJFKNEAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PAOBEEJCHJN
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HHCOLPNPOLF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HONGBLOJGPC : HHCOLPNPOLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	PAOBEEJCHJN IGDGDDPGEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GPJJFCINPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(PFIMHECEGJA JKCMFMGPHDC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(CEIEJPOFNOJ IMNAAJEOHCB, OHBJFKNEAGF MPCAEJFHCJD, StringBuilder EDDPFJFOGAA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FOJDFMBBLGG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PAOBEEJCHJN FOCKFPEHNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(BGHEHCDAEKD NIAPBNPEIPM, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(BGHEHCDAEKD NIAPBNPEIPM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HAJOFKJOJDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool IILCBCCKGAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LDJPKCHJKLB : HONGBLOJGPC, HHCOLPNPOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(HAJOFKJOJDC LDHDPDDMICC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GFLAMGNOOON : HONGBLOJGPC, HHCOLPNPOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(OGEHLNKGNIL HBMKKDHLJMD, CEIEJPOFNOJ IMNAAJEOHCB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CMNECGJHIMK : HHCOLPNPOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder EDDPFJFOGAA, LOECPFNBOHH IPMPKPIBGHH, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HEBBNJMIOCB
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<OACHJIOLDGM> LPNPBLMMPDA();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable AEPKLKDILCN(object GJIMIGJJJKI, OACHJIOLDGM NGGCDDHMKBK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<IMPFOMMMKKI> KLOFLNMPEEE();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, ABMABIKDNCI
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
		public delegate void OMLEOEIJICD(Guid IOFMLHNKDMP, Guid GAKFFLLHFCE);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class EOCAAIACCHK
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class NEHKMGLOHEH<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : HONGBLOJGPC
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
				private HashSet<HONGBLOJGPC> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<HONGBLOJGPC> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<HONGBLOJGPC>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
				[DebuggerHidden]
				public NEHKMGLOHEH(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4BCEAF0", Offset = "0x4BCD4F0", VA = "0x184BCEAF0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x54FF4E0", Offset = "0x54FDEE0", VA = "0x1854FF4E0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x54FF490", Offset = "0x54FDE90", VA = "0x1854FF490")]
				private void KIPLFAABBJD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x54FF760", Offset = "0x54FE160", VA = "0x1854FF760", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4BCFC50", Offset = "0x4BCE650", VA = "0x184BCFC50", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x425E460", Offset = "0x425CE60", VA = "0x18425E460", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<HONGBLOJGPC> PJOEOJGNHPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<HONGBLOJGPC> MDCIBBKFOFG;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x80F7B40", Offset = "0x80F6540", VA = "0x1880F7B40")]
			public void LPGGPHKGHFM(PAOBEEJCHJN KCIAHHAHHIL, HONGBLOJGPC MNBNFCMKGJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x80F7AC0", Offset = "0x80F64C0", VA = "0x1880F7AC0")]
			private static void HFGIACKFGJP(HashSet<HONGBLOJGPC> JJJFNOILJGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4185BD0", Offset = "0x41845D0", VA = "0x184185BD0")]
			public IEnumerable<T> CLHLLOKJGIJ<T>(bool AEPNBKALPFN) where T : HONGBLOJGPC
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x399AF20", Offset = "0x3999920", VA = "0x18399AF20")]
			[IteratorStateMachine(typeof(NEHKMGLOHEH<>))]
			private static IEnumerable<T> NAOFODCLFBA<T>(HashSet<HONGBLOJGPC> JJJFNOILJGJ) where T : HONGBLOJGPC
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public EOCAAIACCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FOLIHGOAEPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public FOLIHGOAEPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x80F8410", Offset = "0x80F6E10", VA = "0x1880F8410")]
			internal bool EBICACAEMHN(GNCBODOCEDO d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> EJIJDKHBJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool JMMLOFFLGAO;

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
		private NOHHGHEDDJL<Guid> LKDBNAAEMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<HONGBLOJGPC> ANGPJIBGPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<CMNECGJHIMK> AJBOMJPPNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EOCAAIACCHK BELFOHBFAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid ECMFKGCGPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid OACGIAKPLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MJPGDJKBEEA ANDHMMKNKCO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> DGOIKPCFFKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x80FE1E0", Offset = "0x80FCBE0", VA = "0x1880FE1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid KIJDDDGOGCE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x80FDDA0", Offset = "0x80FC7A0", VA = "0x1880FDDA0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x80FE330", Offset = "0x80FCD30", VA = "0x1880FE330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GOOJFAHHBJF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x13E7390", Offset = "0x13E5D90", VA = "0x1813E7390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x13E7050", Offset = "0x13E5A50", VA = "0x1813E7050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool AIAAJNMHPAA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x80FDE80", Offset = "0x80FC880", VA = "0x1880FDE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool LDCIJDJGNOG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x80FBB80", Offset = "0x80FA580", VA = "0x1880FBB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView KLACKPHNLKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool CDMKILGMCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x80FDE30", Offset = "0x80FC830", VA = "0x1880FDE30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool IPBGJDCPOLF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x80FB650", Offset = "0x80FA050", VA = "0x1880FB650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OMLEOEIJICD GFPFFBMBBMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x80FDCF0", Offset = "0x80FC6F0", VA = "0x1880FDCF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x80FE280", Offset = "0x80FCC80", VA = "0x1880FE280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80F99A0", Offset = "0x80F83A0", VA = "0x1880F99A0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80FAF10", Offset = "0x80F9910", VA = "0x1880FAF10")]
		private bool EOKFNALMIOE([Out] Guid GIKGIFKPMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80FC1E0", Offset = "0x80FABE0", VA = "0x1880FC1E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80FBDB0", Offset = "0x80FA7B0", VA = "0x1880FBDB0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80FB020", Offset = "0x80F9A20", VA = "0x1880FB020")]
		private void FOKFEFIEJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80FC1E0", Offset = "0x80FABE0", VA = "0x1880FC1E0")]
		private void OnMasterClientSwitched(GBDECDHLMJN KPIDJKLDGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80FBA70", Offset = "0x80FA470", VA = "0x1880FBA70")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80FCB80", Offset = "0x80FB580", VA = "0x1880FCB80")]
		public void PreSerializeAsync(BBKFGDIALBG<Task> HDMEIOBGENF, StringBuilder EDDPFJFOGAA, LOECPFNBOHH IPMPKPIBGHH, CancellationToken JKPNCAGHEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80FCFB0", Offset = "0x80FB9B0", VA = "0x1880FCFB0")]
		public CEIEJPOFNOJ Serialize(OHBJFKNEAGF MPCAEJFHCJD, StringBuilder EDDPFJFOGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x80FB6C0", Offset = "0x80FA0C0", VA = "0x1880FB6C0")]
		public void InitializeDeserialization(CEIEJPOFNOJ IMNAAJEOHCB, bool OLIMEFIKCEG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80FC660", Offset = "0x80FB060", VA = "0x1880FC660")]
		public void PreDeserialize(bool AEPNBKALPFN, OGEHLNKGNIL HBMKKDHLJMD, CEIEJPOFNOJ IMNAAJEOHCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80FA870", Offset = "0x80F9270", VA = "0x1880FA870")]
		public void Deserialize(bool AEPNBKALPFN, PFIMHECEGJA JKCMFMGPHDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x80FC1F0", Offset = "0x80FABF0", VA = "0x1880FC1F0")]
		public void PostDeserialize(bool AEPNBKALPFN, HAJOFKJOJDC LDHDPDDMICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x80FA140", Offset = "0x80F8B40", VA = "0x1880FA140")]
		private void DAOPJDJONIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80F9750", Offset = "0x80F8150", VA = "0x1880F9750")]
		private CEIEJPOFNOJ AOKPBOCPOIH(CEIEJPOFNOJ PFNPAJLMCBA, ChildViewReference GBGDJHDAECJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80FB9B0", Offset = "0x80FA3B0", VA = "0x1880FB9B0")]
		public void MarkExcludedFromRoomSave(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80FDA40", Offset = "0x80FC440", VA = "0x1880FDA40")]
		public void UnmarkExcludedFromRoomSave(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80F9FD0", Offset = "0x80F89D0", VA = "0x1880F9FD0", Slot = "14")]
		public void Bake(OKBMAOLKCPM GJIMIGJJJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80FDC10", Offset = "0x80FC610", VA = "0x1880FDC10")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x80FBCE0", Offset = "0x80FA6E0", VA = "0x1880FBCE0")]
		[CompilerGenerated]
		private object OOIKBOKKNMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x80FB5D0", Offset = "0x80F9FD0", VA = "0x1880FB5D0")]
		[CompilerGenerated]
		private object IFFPCLBFPAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x80FB900", Offset = "0x80FA300", VA = "0x1880FB900")]
		[CompilerGenerated]
		private object MHHNIGFKLAK()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OACHJIOLDGM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool HGCHBCIHHCI(JFCHLDJHBKP HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AFDGHHIIHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AFDGHHIIHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80F7890", Offset = "0x80F6290", VA = "0x1880F7890")]
		internal Task EPFHLFOEIMA(JFCHLDJHBKP data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OOGKONOKMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<JFCHLDJHBKP> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OOGKONOKMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80F96A0", Offset = "0x80F80A0", VA = "0x1880F96A0")]
		internal Task EPFHLFOEIMA(JFCHLDJHBKP data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ADFMGBCJCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public LAILNAMDFHD handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OACHJIOLDGM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ADFMGBCJCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80F77E0", Offset = "0x80F61E0", VA = "0x1880F77E0")]
		internal object CDJPMEDMNAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<NBLBPMKGJIE, HashSet<(LAILNAMDFHD, HGCHBCIHHCI, MPALOKCIKAK)>> NHJKBOFAIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid HEFAKHAFLOP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80F9260", Offset = "0x80F7C60", VA = "0x1880F9260")]
	public OACHJIOLDGM(Guid CANDEHHCANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80F9020", Offset = "0x80F7A20", VA = "0x1880F9020")]
	public OACHJIOLDGM PIOINONEIIG(NBLBPMKGJIE ILEBMFHIPAO, LAILNAMDFHD KCIAHHAHHIL, MPALOKCIKAK NGGCDDHMKBK, [Optional] HGCHBCIHHCI ELFLLJBMBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80F8F30", Offset = "0x80F7930", VA = "0x1880F8F30")]
	public OACHJIOLDGM PIOINONEIIG(NBLBPMKGJIE ILEBMFHIPAO, LAILNAMDFHD KCIAHHAHHIL, Action NGGCDDHMKBK, [Optional] HGCHBCIHHCI ELFLLJBMBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80F8E40", Offset = "0x80F7840", VA = "0x1880F8E40")]
	public OACHJIOLDGM PIOINONEIIG(NBLBPMKGJIE ILEBMFHIPAO, LAILNAMDFHD KCIAHHAHHIL, Action<JFCHLDJHBKP> NGGCDDHMKBK, [Optional] HGCHBCIHHCI ELFLLJBMBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80F8A60", Offset = "0x80F7460", VA = "0x1880F8A60")]
	public Dictionary<LAILNAMDFHD, List<MPALOKCIKAK>> OLJIOLHHJKF(NBLBPMKGJIE CGPMPJFAAHA, JFCHLDJHBKP HPGIDELCODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task IMPFOMMMKKI(CancellationToken JKPNCAGHEDI);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class FJMCLLBLOBJ : HEBBNJMIOCB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum AICFLOGEJPM
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
	private class DBPLAHHCNBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class ECBDHJBCFCH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object GJIMIGJJJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly OACHJIOLDGM NGGCDDHMKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> LFCHFKNPPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool CDPHAALIFLC;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCC55F0", Offset = "0xCC3FF0", VA = "0x180CC55F0")]
		public ECBDHJBCFCH(object GJIMIGJJJKI, OACHJIOLDGM NGGCDDHMKBK, Action<object> LFCHFKNPPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x80F7A80", Offset = "0x80F6480", VA = "0x1880F7A80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, OACHJIOLDGM> LEGHCDHDMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<IMPFOMMMKKI> OMDAMGJALPI;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80F8060", Offset = "0x80F6A60", VA = "0x1880F8060")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void FEDJMCICCOK(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x80F8210", Offset = "0x80F6C10", VA = "0x1880F8210", Slot = "4")]
	public IReadOnlyList<OACHJIOLDGM> LPNPBLMMPDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x80F7CB0", Offset = "0x80F66B0", VA = "0x1880F7CB0", Slot = "5")]
	public IDisposable AEPKLKDILCN(object GJIMIGJJJKI, OACHJIOLDGM NGGCDDHMKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80F81D0", Offset = "0x80F6BD0", VA = "0x1880F81D0", Slot = "6")]
	public IReadOnlyList<IMPFOMMMKKI> KLOFLNMPEEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80F8270", Offset = "0x80F6C70", VA = "0x1880F8270")]
	private void OHIFAIHAOIK(object GJIMIGJJJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80F7F80", Offset = "0x80F6980", VA = "0x1880F7F80")]
	[HHPMDADMJLL]
	internal static void EJKOJJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x80F7E30", Offset = "0x80F6830", VA = "0x1880F7E30")]
	internal static void DLJIAJAKIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80F8150", Offset = "0x80F6B50", VA = "0x1880F8150")]
	internal void IKEIHAHCGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80F8340", Offset = "0x80F6D40", VA = "0x1880F8340")]
	public FJMCLLBLOBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class GDMIAOALKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<NBLBPMKGJIE> FLIMFIFCCOP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<NBLBPMKGJIE> JOMDJNACMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x80F8430", Offset = "0x80F6E30", VA = "0x1880F8430")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BKLLEOOLBCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct OGLBPFHBDDL : IAsyncStateMachine
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
		public BKLLEOOLBCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80F9300", Offset = "0x80F7D00", VA = "0x1880F9300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80F9530", Offset = "0x80F7F30", VA = "0x1880F9530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float NGKPGHKEBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float HJACNBHIIML;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x80F7A40", Offset = "0x80F6440", VA = "0x1880F7A40")]
	public BKLLEOOLBCA(float HJACNBHIIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x80F7950", Offset = "0x80F6350", VA = "0x1880F7950")]
	[AsyncStateMachine(typeof(OGLBPFHBDDL))]
	public Task LDIDILKJLAG(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80F7930", Offset = "0x80F6330", VA = "0x1880F7930")]
	public void ALHGHPCNMCL()
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
