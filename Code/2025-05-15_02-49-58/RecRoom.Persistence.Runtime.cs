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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE220", Offset = "0x7FBC820", VA = "0x187FBE220", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FC3FF0", Offset = "0x7FC25F0", VA = "0x187FC3FF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FBE2B0", Offset = "0x7FBC8B0", VA = "0x187FBE2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
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
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4CA0", Offset = "0x9F32A0", VA = "0x1809F4CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD800", Offset = "0x7FBBE00", VA = "0x187FBD800")]
	public JOEFAEBJKIB(GOMNLGPHFID KNDDJPGLJMO, IINCMBDAHBF CHLJPLPCJPN, IMCNCDOFDAG CKILEEJBEOC, IReadOnlyList<IMCNCDOFDAG> AJDIOHAHEDH, IReadOnlyList<IMCNCDOFDAG> KEKGCMIICPD, APPGMHGFBGI NGAHGPBBOGI, bool MHKMONLJIBA, BPLHNECCAPN MKIDPONBDDE, HNAGJAILJOF OFMJDNINMGK, IEnumerable<MCIJFDPPJOL> NHNPOIIGHMB, COGPNGPCNGP PJAGGMPCPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD770", Offset = "0x7FBBD70", VA = "0x187FBD770")]
	public void BFNGCCNANBE(IHHBKLENLMK MBNNBINAODP, List<(PersistenceView, DJNGLNAIHJJ)> NCOPFNGDDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD790", Offset = "0x7FBBD90", VA = "0x187FBD790")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FBD2B0", Offset = "0x7FBB8B0", VA = "0x187FBD2B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD300", Offset = "0x7FBB900", VA = "0x187FBD300")]
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
	public class PersistenceView : RRNetworkBehavior, MECOHKFOCBB
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
					[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
				[DebuggerHidden]
				public DHDCBNLGMCJ(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x49F97D0", Offset = "0x49F7DD0", VA = "0x1849F97D0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6A3E260", Offset = "0x6A3C860", VA = "0x186A3E260", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6A3E210", Offset = "0x6A3C810", VA = "0x186A3E210")]
				private void KILKBHNKCHN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x6A3E4F0", Offset = "0x6A3CAF0", VA = "0x186A3E4F0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x49FAA40", Offset = "0x49F9040", VA = "0x1849FAA40", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x49FAD80", Offset = "0x49F9380", VA = "0x1849FAD80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FBD090", Offset = "0x7FBB690", VA = "0x187FBD090")]
			public void PCBBFOMKBBD(MEJEDBJKJED ENNNHBGPBFL, CKODECPEIHC CPLGAJFEDNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7FBD010", Offset = "0x7FBB610", VA = "0x187FBD010")]
			private static void LEMCNFLHKNJ(HashSet<CKODECPEIHC> ENJOLJLINPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3F5B2F0", Offset = "0x3F598F0", VA = "0x183F5B2F0")]
			public IEnumerable<T> DANODNKHOLD<T>(bool BHMBMJHLKND) where T : CKODECPEIHC
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x36AD680", Offset = "0x36ABC80", VA = "0x1836AD680")]
			[IteratorStateMachine(typeof(DHDCBNLGMCJ<>))]
			private static IEnumerable<T> IDNFFJCABMJ<T>(HashSet<CKODECPEIHC> ENJOLJLINPM) where T : CKODECPEIHC
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HNJDKIDOGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7FBD650", Offset = "0x7FBBC50", VA = "0x187FBD650")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FC3880", Offset = "0x7FC1E80", VA = "0x187FC3880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid OJLJBFKDCDP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7FC3450", Offset = "0x7FC1A50", VA = "0x187FC3450")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7FC39D0", Offset = "0x7FC1FD0", VA = "0x187FC39D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IEKIGFPLCKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD81E30", Offset = "0xD80430", VA = "0x180D81E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD81E50", Offset = "0xD80450", VA = "0x180D81E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HNAOOMJBGMG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC3530", Offset = "0x7FC1B30", VA = "0x187FC3530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool IJMJHBMLDGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7FC10D0", Offset = "0x7FBF6D0", VA = "0x187FC10D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView NPNNICNEDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ONJBABHJNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7FC34E0", Offset = "0x7FC1AE0", VA = "0x187FC34E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool AAHBMLACPNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7FC1230", Offset = "0x7FBF830", VA = "0x187FC1230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JLDGCDKPJJF KFJEFEHELGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7FC33A0", Offset = "0x7FC19A0", VA = "0x187FC33A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7FC3920", Offset = "0x7FC1F20", VA = "0x187FC3920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FBEE40", Offset = "0x7FBD440", VA = "0x187FBEE40", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0690", Offset = "0x7FBEC90", VA = "0x187FC0690")]
		private bool HNCODEBLFNP([Out] Guid AMBECFBGDPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FC18A0", Offset = "0x7FBFEA0", VA = "0x187FC18A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1470", Offset = "0x7FBFA70", VA = "0x187FC1470", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0AB0", Offset = "0x7FBF0B0", VA = "0x187FC0AB0")]
		private void JMAKCFJIDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC18A0", Offset = "0x7FBFEA0", VA = "0x187FC18A0")]
		private void OnMasterClientSwitched(AIPAHMNCJKP EKEPPODJHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1360", Offset = "0x7FBF960", VA = "0x187FC1360")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2230", Offset = "0x7FC0830", VA = "0x187FC2230")]
		public void PreSerializeAsync(IEALDBHBOML<Task> CHFOMHMEILP, StringBuilder JCLPBCBNCNH, FHEBLHGADNG DMBMNBBDHKN, CancellationToken CBJPDIFOEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2670", Offset = "0x7FC0C70", VA = "0x187FC2670")]
		public DJNGLNAIHJJ Serialize(HDGPNFAELAI FGPPEIIOCJJ, StringBuilder JCLPBCBNCNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0870", Offset = "0x7FBEE70", VA = "0x187FC0870")]
		public void InitializeDeserialization(DJNGLNAIHJJ BJPIFCHFNAA, bool OJIMJMJPNHG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1D20", Offset = "0x7FC0320", VA = "0x187FC1D20")]
		public void PreDeserialize(bool BHMBMJHLKND, APPGMHGFBGI NGAHGPBBOGI, DJNGLNAIHJJ BJPIFCHFNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FBFF50", Offset = "0x7FBE550", VA = "0x187FBFF50")]
		public void Deserialize(bool BHMBMJHLKND, FOCCKCHHJGO KOLGLKDMECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FC18B0", Offset = "0x7FBFEB0", VA = "0x187FC18B0")]
		public void PostDeserialize(bool BHMBMJHLKND, GHBIKMGLAGL CIEMGHINBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF820", Offset = "0x7FBDE20", VA = "0x187FBF820")]
		private void CMOJJBKJHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF470", Offset = "0x7FBDA70", VA = "0x187FBF470")]
		private DJNGLNAIHJJ BBEJMPACAML(DJNGLNAIHJJ GNLFLBGFCHF, ChildViewReference HMCFPGIFOED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FC12A0", Offset = "0x7FBF8A0", VA = "0x187FC12A0")]
		public void MarkExcludedFromRoomSave(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FC30F0", Offset = "0x7FC16F0", VA = "0x187FC30F0")]
		public void UnmarkExcludedFromRoomSave(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF6C0", Offset = "0x7FBDCC0", VA = "0x187FBF6C0", Slot = "13")]
		public void Bake(IDHOFIHAGPL INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7FC32C0", Offset = "0x7FC18C0", VA = "0x187FC32C0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC07A0", Offset = "0x7FBEDA0", VA = "0x187FC07A0")]
		[CompilerGenerated]
		private object IDPOIFLLKIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1050", Offset = "0x7FBF650", VA = "0x187FC1050")]
		[CompilerGenerated]
		private object KHFCMDKPKJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC05E0", Offset = "0x7FBEBE0", VA = "0x187FC05E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MJEPCHJIGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE580", Offset = "0x7FBCB80", VA = "0x187FBE580")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FJCMKABDINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD200", Offset = "0x7FBB800", VA = "0x187FBD200")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MPHKHKOAINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE620", Offset = "0x7FBCC20", VA = "0x187FBE620")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FBE180", Offset = "0x7FBC780", VA = "0x187FBE180")]
	public LFLPPHCMPGO(Guid KGIKCAHMNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD980", Offset = "0x7FBBF80", VA = "0x187FBD980")]
	public LFLPPHCMPGO HJFIGJGHJBE(IHHBKLENLMK PIEBOPPHAIP, LOIOFANBADN ENNNHBGPBFL, JCIEFCALJCE DLNPOEEPFML, [Optional] GNLDCGMHOFA GLEMIIJEAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FBDBC0", Offset = "0x7FBC1C0", VA = "0x187FBDBC0")]
	public LFLPPHCMPGO HJFIGJGHJBE(IHHBKLENLMK PIEBOPPHAIP, LOIOFANBADN ENNNHBGPBFL, Action DLNPOEEPFML, [Optional] GNLDCGMHOFA GLEMIIJEAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FBDCB0", Offset = "0x7FBC2B0", VA = "0x187FBDCB0")]
	public LFLPPHCMPGO HJFIGJGHJBE(IHHBKLENLMK PIEBOPPHAIP, LOIOFANBADN ENNNHBGPBFL, Action<JOEFAEBJKIB> DLNPOEEPFML, [Optional] GNLDCGMHOFA GLEMIIJEAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FBDDA0", Offset = "0x7FBC3A0", VA = "0x187FBDDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC46E90", Offset = "0xC45490", VA = "0x180C46E90")]
		public KEAIIPMFFAF(object INLEBAAACKH, LFLPPHCMPGO DLNPOEEPFML, Action<object> CAKOCJPCKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD940", Offset = "0x7FBBF40", VA = "0x187FBD940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FBE9A0", Offset = "0x7FBCFA0", VA = "0x187FBE9A0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FBECA0", Offset = "0x7FBD2A0", VA = "0x187FBECA0", Slot = "4")]
	public IReadOnlyList<LFLPPHCMPGO> PECAOOPBNND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FBEAA0", Offset = "0x7FBD0A0", VA = "0x187FBEAA0", Slot = "5")]
	public IDisposable LAJPBEEJBMP(object INLEBAAACKH, LFLPPHCMPGO DLNPOEEPFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FBE960", Offset = "0x7FBCF60", VA = "0x187FBE960", Slot = "6")]
	public IReadOnlyList<JMBLJGACIPD> GEDDDOHFNJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FBE900", Offset = "0x7FBCF00", VA = "0x187FBE900")]
	private void EKCHGMGJDAG(object INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FBE820", Offset = "0x7FBCE20", VA = "0x187FBE820")]
	[FHOLJFNIKPC]
	internal static void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FBE6D0", Offset = "0x7FBCCD0", VA = "0x187FBE6D0")]
	internal static void AOJNBLCPAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FBEC20", Offset = "0x7FBD220", VA = "0x187FBEC20")]
	internal void OBDAOKBEIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FBED70", Offset = "0x7FBD370", VA = "0x187FBED70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FBE2F0", Offset = "0x7FBC8F0", VA = "0x187FBE2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FBD3C0", Offset = "0x7FBB9C0", VA = "0x187FBD3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD5F0", Offset = "0x7FBBBF0", VA = "0x187FBD5F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FBCFD0", Offset = "0x7FBB5D0", VA = "0x187FBCFD0")]
	public AMIGCLEJKKN(float LNKDNAHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCEC0", Offset = "0x7FBB4C0", VA = "0x187FBCEC0")]
	[AsyncStateMachine(typeof(HHOJIPNIIOF))]
	public Task DAMJMDDKICL(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCFB0", Offset = "0x7FBB5B0", VA = "0x187FBCFB0")]
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
