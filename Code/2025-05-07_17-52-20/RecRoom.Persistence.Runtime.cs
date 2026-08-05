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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE510", Offset = "0x7FCD510", VA = "0x187FCE510", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD4380", Offset = "0x7FD3380", VA = "0x187FD4380", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MCIJFDPPJOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly DIFMPACHIKE GJLLABFIPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte MLCOGCMJLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid LBDJDJIFMMO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE5A0", Offset = "0x7FCD5A0", VA = "0x187FCE5A0")]
	public MCIJFDPPJOL(DIFMPACHIKE GJLLABFIPOE, byte MLCOGCMJLBB, Guid LBDJDJIFMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task JCIEFCALJCE(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JOEFAEBJKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IHHBKLENLMK OFCJMEJECCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, DJNGLNAIHJJ)> DHBFHCCFIHH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public GOMNLGPHFID NNMKPLFMBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public IINCMBDAHBF EMBAJFEEJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IMCNCDOFDAG KIEFPPAJMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<IMCNCDOFDAG> COBKFNDNMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<IMCNCDOFDAG> KPKOICAJDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public APPGMHGFBGI LLDCCJDOCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750")]
		[CompilerGenerated]
		get
		{
			return default(APPGMHGFBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public BPLHNECCAPN FCOHEOALLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HNAGJAILJOF DCPKNPHEEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MCIJFDPPJOL> GDOCHKJJLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public COGPNGPCNGP IBFCKAMNPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BFGJINGIIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9FACA0", Offset = "0x9F9CA0", VA = "0x1809FACA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDAD0", Offset = "0x7FCCAD0", VA = "0x187FCDAD0")]
	public JOEFAEBJKIB(GOMNLGPHFID KNDDJPGLJMO, IINCMBDAHBF CHLJPLPCJPN, IMCNCDOFDAG CKILEEJBEOC, IReadOnlyList<IMCNCDOFDAG> AJDIOHAHEDH, IReadOnlyList<IMCNCDOFDAG> KEKGCMIICPD, APPGMHGFBGI NGAHGPBBOGI, bool MHKMONLJIBA, BPLHNECCAPN MKIDPONBDDE, HNAGJAILJOF OFMJDNINMGK, IEnumerable<MCIJFDPPJOL> NHNPOIIGHMB, COGPNGPCNGP PJAGGMPCPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDA40", Offset = "0x7FCCA40", VA = "0x187FCDA40")]
	public void BFNGCCNANBE(IHHBKLENLMK MBNNBINAODP, List<(PersistenceView, DJNGLNAIHJJ)> NCOPFNGDDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDA60", Offset = "0x7FCCA60", VA = "0x187FCDA60")]
	public List<(PersistenceView, DJNGLNAIHJJ)> OGMCGNGNNGB(IHHBKLENLMK EKHKNJEOKII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KNEDGBILGPM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FHEBLHGADNG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[GENPBBPPBOP]
public enum IHHBKLENLMK
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
public enum LOIOFANBADN : byte
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
public interface IMCNCDOFDAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid KJPMNOCOJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> NFICILNOKIK();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGHCICIJDHI();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHDFCDDMCJA(bool APMFNOCENMP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FOCCKCHHJGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public APPGMHGFBGI NGAHGPBBOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public DJNGLNAIHJJ BJPIFCHFNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool HAGNAKFCLJB;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HDGPNFAELAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> IDGFOLNLIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder MFNAKEDKNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public KDNCIDPCBFM OHBGAHPHOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int PFFDCJEDDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 PAGGBKHOFKM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD580", Offset = "0x7FCC580", VA = "0x187FCD580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD5D0", Offset = "0x7FCC5D0", VA = "0x187FCD5D0")]
	public HDGPNFAELAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MEJEDBJKJED
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KOKBNNBLFKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKODECPEIHC : KOKBNNBLFKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MEJEDBJKJED KBCNEDNDFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IHGIBEILHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(FOCCKCHHJGO KOLGLKDMECH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(DJNGLNAIHJJ BJPIFCHFNAA, HDGPNFAELAI FGPPEIIOCJJ, StringBuilder JCLPBCBNCNH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OOOMLHBIIKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MEJEDBJKJED AKOPHIELMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(BPLHNECCAPN MKIDPONBDDE, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(BPLHNECCAPN MKIDPONBDDE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GHBIKMGLAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool HAGNAKFCLJB;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HLMOLLKKJOM : CKODECPEIHC, KOKBNNBLFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(GHBIKMGLAGL CIEMGHINBIF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HJAJJMDDDDD : CKODECPEIHC, KOKBNNBLFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(APPGMHGFBGI NGAHGPBBOGI, DJNGLNAIHJJ BJPIFCHFNAA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BOFCKLABELI : KOKBNNBLFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder JCLPBCBNCNH, FHEBLHGADNG DMBMNBBDHKN, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JJOKNLDHNDC
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<LFLPPHCMPGO> PECAOOPBNND();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LAJPBEEJBMP(object INLEBAAACKH, LFLPPHCMPGO DLNPOEEPFML);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<JMBLJGACIPD> GEDDDOHFNJJ();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun, MECOHKFOCBB
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
		public delegate void JLDGCDKPJJF(Guid PINMMMMHGNL, Guid FLOGJIKEKID);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class DNDKFNAMBHE
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class DHDCBNLGMCJ<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : CKODECPEIHC
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
				private HashSet<CKODECPEIHC> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<CKODECPEIHC> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<CKODECPEIHC>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
				[DebuggerHidden]
				public DHDCBNLGMCJ(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x48C4F60", Offset = "0x48C3F60", VA = "0x1848C4F60", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6A5D170", Offset = "0x6A5C170", VA = "0x186A5D170", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6A5D120", Offset = "0x6A5C120", VA = "0x186A5D120")]
				private void KILKBHNKCHN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x6A5D410", Offset = "0x6A5C410", VA = "0x186A5D410", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x48C6230", Offset = "0x48C5230", VA = "0x1848C6230", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x48C65B0", Offset = "0x48C55B0", VA = "0x1848C65B0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<CKODECPEIHC> JONFPKGLLGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<CKODECPEIHC> MMGLOMCMPBK;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD360", Offset = "0x7FCC360", VA = "0x187FCD360")]
			public void PCBBFOMKBBD(MEJEDBJKJED ENNNHBGPBFL, CKODECPEIHC CPLGAJFEDNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD2E0", Offset = "0x7FCC2E0", VA = "0x187FCD2E0")]
			private static void LEMCNFLHKNJ(HashSet<CKODECPEIHC> ENJOLJLINPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3F063F0", Offset = "0x3F053F0", VA = "0x183F063F0")]
			public IEnumerable<T> DANODNKHOLD<T>(bool BHMBMJHLKND) where T : CKODECPEIHC
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x368F760", Offset = "0x368E760", VA = "0x18368F760")]
			[IteratorStateMachine(typeof(DHDCBNLGMCJ<>))]
			private static IEnumerable<T> IDNFFJCABMJ<T>(HashSet<CKODECPEIHC> ENJOLJLINPM) where T : CKODECPEIHC
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public DNDKFNAMBHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HNJDKIDOGGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public HNJDKIDOGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD920", Offset = "0x7FCC920", VA = "0x187FCD920")]
			internal bool GMFBAKEEKJF(HONIMMFLLLK d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> LAGLCHLMGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool DPFEKBIHCAH;

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
		private PMOMLNDBBKO<Guid> IEGOFJAOKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<CKODECPEIHC> PMGHLNFGMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<BOFCKLABELI> IIIHEGDFFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DNDKFNAMBHE JCPEJNMKAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid DGEGBJCNLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid KEGOECHDHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PHIGNGELHED GEJDPEDKJAB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> DLGLAFHABBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7FD3BE0", Offset = "0x7FD2BE0", VA = "0x187FD3BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid OJLJBFKDCDP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7FD37A0", Offset = "0x7FD27A0", VA = "0x187FD37A0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7FD3D30", Offset = "0x7FD2D30", VA = "0x187FD3D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IEKIGFPLCKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD6F410", Offset = "0xD6E410", VA = "0x180D6F410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD6F430", Offset = "0xD6E430", VA = "0x180D6F430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HNAOOMJBGMG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FD3880", Offset = "0x7FD2880", VA = "0x187FD3880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool IJMJHBMLDGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7FD13E0", Offset = "0x7FD03E0", VA = "0x187FD13E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView NPNNICNEDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ONJBABHJNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7FD3830", Offset = "0x7FD2830", VA = "0x187FD3830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool AAHBMLACPNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD1540", Offset = "0x7FD0540", VA = "0x187FD1540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JLDGCDKPJJF KFJEFEHELGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7FD36F0", Offset = "0x7FD26F0", VA = "0x187FD36F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7FD3C80", Offset = "0x7FD2C80", VA = "0x187FD3C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF120", Offset = "0x7FCE120", VA = "0x187FCF120", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0960", Offset = "0x7FCF960", VA = "0x187FD0960")]
		private bool HNCODEBLFNP([Out] Guid AMBECFBGDPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1BB0", Offset = "0x7FD0BB0", VA = "0x187FD1BB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1790", Offset = "0x7FD0790", VA = "0x187FD1790", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0DA0", Offset = "0x7FCFDA0", VA = "0x187FD0DA0")]
		private void JMAKCFJIDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1BB0", Offset = "0x7FD0BB0", VA = "0x187FD1BB0")]
		private void OnMasterClientSwitched(NLDJFEFKCOP EKEPPODJHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1680", Offset = "0x7FD0680", VA = "0x187FD1680")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2550", Offset = "0x7FD1550", VA = "0x187FD2550")]
		public void PreSerializeAsync(IEALDBHBOML<Task> CHFOMHMEILP, StringBuilder JCLPBCBNCNH, FHEBLHGADNG DMBMNBBDHKN, CancellationToken CBJPDIFOEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2990", Offset = "0x7FD1990", VA = "0x187FD2990")]
		public DJNGLNAIHJJ Serialize(HDGPNFAELAI FGPPEIIOCJJ, StringBuilder JCLPBCBNCNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0B50", Offset = "0x7FCFB50", VA = "0x187FD0B50")]
		public void InitializeDeserialization(DJNGLNAIHJJ BJPIFCHFNAA, bool OJIMJMJPNHG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2030", Offset = "0x7FD1030", VA = "0x187FD2030")]
		public void PreDeserialize(bool BHMBMJHLKND, APPGMHGFBGI NGAHGPBBOGI, DJNGLNAIHJJ BJPIFCHFNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0210", Offset = "0x7FCF210", VA = "0x187FD0210")]
		public void Deserialize(bool BHMBMJHLKND, FOCCKCHHJGO KOLGLKDMECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1BC0", Offset = "0x7FD0BC0", VA = "0x187FD1BC0")]
		public void PostDeserialize(bool BHMBMJHLKND, GHBIKMGLAGL CIEMGHINBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7FCFAE0", Offset = "0x7FCEAE0", VA = "0x187FCFAE0")]
		private void CMOJJBKJHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF730", Offset = "0x7FCE730", VA = "0x187FCF730")]
		private DJNGLNAIHJJ BBEJMPACAML(DJNGLNAIHJJ GNLFLBGFCHF, ChildViewReference HMCFPGIFOED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FD15B0", Offset = "0x7FD05B0", VA = "0x187FD15B0")]
		public void MarkExcludedFromRoomSave(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3420", Offset = "0x7FD2420", VA = "0x187FD3420")]
		public void UnmarkExcludedFromRoomSave(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF980", Offset = "0x7FCE980", VA = "0x187FCF980", Slot = "13")]
		public void Bake(IDHOFIHAGPL INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3600", Offset = "0x7FD2600", VA = "0x187FD3600")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0A70", Offset = "0x7FCFA70", VA = "0x187FD0A70")]
		[CompilerGenerated]
		private object IDPOIFLLKIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1360", Offset = "0x7FD0360", VA = "0x187FD1360")]
		[CompilerGenerated]
		private object KHFCMDKPKJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD08B0", Offset = "0x7FCF8B0", VA = "0x187FD08B0")]
		[CompilerGenerated]
		private object FGFFLMAKPFA()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LFLPPHCMPGO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool GNLDCGMHOFA(JOEFAEBJKIB APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MJEPCHJIGOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MJEPCHJIGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE880", Offset = "0x7FCD880", VA = "0x187FCE880")]
		internal Task HEDJHNLMJKM(JOEFAEBJKIB data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FJCMKABDINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<JOEFAEBJKIB> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FJCMKABDINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD4D0", Offset = "0x7FCC4D0", VA = "0x187FCD4D0")]
		internal Task HEDJHNLMJKM(JOEFAEBJKIB data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MPHKHKOAINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public LOIOFANBADN handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LFLPPHCMPGO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MPHKHKOAINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE920", Offset = "0x7FCD920", VA = "0x187FCE920")]
		internal object BGKACLFEJHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<IHHBKLENLMK, HashSet<(LOIOFANBADN, GNLDCGMHOFA, JCIEFCALJCE)>> FAIFIHBPNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid LEJGBNADKKP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE470", Offset = "0x7FCD470", VA = "0x187FCE470")]
	public LFLPPHCMPGO(Guid KGIKCAHMNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDC50", Offset = "0x7FCCC50", VA = "0x187FCDC50")]
	public LFLPPHCMPGO HJFIGJGHJBE(IHHBKLENLMK PIEBOPPHAIP, LOIOFANBADN ENNNHBGPBFL, JCIEFCALJCE DLNPOEEPFML, [Optional] GNLDCGMHOFA GLEMIIJEAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDEA0", Offset = "0x7FCCEA0", VA = "0x187FCDEA0")]
	public LFLPPHCMPGO HJFIGJGHJBE(IHHBKLENLMK PIEBOPPHAIP, LOIOFANBADN ENNNHBGPBFL, Action DLNPOEEPFML, [Optional] GNLDCGMHOFA GLEMIIJEAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDF90", Offset = "0x7FCCF90", VA = "0x187FCDF90")]
	public LFLPPHCMPGO HJFIGJGHJBE(IHHBKLENLMK PIEBOPPHAIP, LOIOFANBADN ENNNHBGPBFL, Action<JOEFAEBJKIB> DLNPOEEPFML, [Optional] GNLDCGMHOFA GLEMIIJEAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE080", Offset = "0x7FCD080", VA = "0x187FCE080")]
	public Dictionary<LOIOFANBADN, List<JCIEFCALJCE>> JMFCLBHOGLE(IHHBKLENLMK MBNNBINAODP, JOEFAEBJKIB APDBNIMCPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task JMBLJGACIPD(CancellationToken CBJPDIFOEKF);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class PFFJJDIHMPA : JJOKNLDHNDC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FPAKMCDKPJK
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
	private class PGMCKOFKJNJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class KEAIIPMFFAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object INLEBAAACKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly LFLPPHCMPGO DLNPOEEPFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> CAKOCJPCKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool CIAFEFCBLPC;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC47F60", Offset = "0xC46F60", VA = "0x180C47F60")]
		public KEAIIPMFFAF(object INLEBAAACKH, LFLPPHCMPGO DLNPOEEPFML, Action<object> CAKOCJPCKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDC10", Offset = "0x7FCCC10", VA = "0x187FCDC10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, LFLPPHCMPGO> IKLFPOHBMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<JMBLJGACIPD> MIFHBANPELH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEC90", Offset = "0x7FCDC90", VA = "0x187FCEC90")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEF80", Offset = "0x7FCDF80", VA = "0x187FCEF80", Slot = "4")]
	public IReadOnlyList<LFLPPHCMPGO> PECAOOPBNND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FCED80", Offset = "0x7FCDD80", VA = "0x187FCED80", Slot = "5")]
	public IDisposable LAJPBEEJBMP(object INLEBAAACKH, LFLPPHCMPGO DLNPOEEPFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEC50", Offset = "0x7FCDC50", VA = "0x187FCEC50", Slot = "6")]
	public IReadOnlyList<JMBLJGACIPD> GEDDDOHFNJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEBF0", Offset = "0x7FCDBF0", VA = "0x187FCEBF0")]
	private void EKCHGMGJDAG(object INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEB10", Offset = "0x7FCDB10", VA = "0x187FCEB10")]
	[FHOLJFNIKPC]
	internal static void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE9D0", Offset = "0x7FCD9D0", VA = "0x187FCE9D0")]
	internal static void AOJNBLCPAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEF00", Offset = "0x7FCDF00", VA = "0x187FCEF00")]
	internal void OBDAOKBEIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF050", Offset = "0x7FCE050", VA = "0x187FCF050")]
	public PFFJJDIHMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MFEPONDPJHK
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<IHHBKLENLMK> BDBMCKOLAAF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<IHHBKLENLMK> IBGKANFDPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE5E0", Offset = "0x7FCD5E0", VA = "0x187FCE5E0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AMIGCLEJKKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HHOJIPNIIOF : IAsyncStateMachine
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
		public AMIGCLEJKKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD690", Offset = "0x7FCC690", VA = "0x187FCD690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD8C0", Offset = "0x7FCC8C0", VA = "0x187FCD8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float FCHADMBLPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float LNKDNAHNALP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD2A0", Offset = "0x7FCC2A0", VA = "0x187FCD2A0")]
	public AMIGCLEJKKN(float LNKDNAHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD190", Offset = "0x7FCC190", VA = "0x187FCD190")]
	[AsyncStateMachine(typeof(HHOJIPNIIOF))]
	public Task DAMJMDDKICL(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD280", Offset = "0x7FCC280", VA = "0x187FCD280")]
	public void KGPJOLOPJJK()
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
