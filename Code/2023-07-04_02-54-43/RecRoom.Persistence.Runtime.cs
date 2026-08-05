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
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MDIGIEGHOPL : JLKFPOJLOAM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(PJLOEOJDLAF CDGJGMOHJAO, NFFPAONFDAO MAEAOOFFCNL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct FLLCNPJDOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public PJLOEOJDLAF CDGJGMOHJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public NFFPAONFDAO MAEAOOFFCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool GBHMIFMNKLB;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KLEMKCCNPOG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> GPDBBDHLDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public OINAJNHIOBP IOFOKLIIKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int PEBMHFLNCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 DKJJPJHLOEL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5970", Offset = "0x6BB3F70", VA = "0x186BB5970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BB59C0", Offset = "0x6BB3FC0", VA = "0x186BB59C0")]
	public KLEMKCCNPOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FMIILHIOPED
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JLKFPOJLOAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FMIILHIOPED OBCBJAIJODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FDAIMIDPMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(FLLCNPJDOPP GEOBPLDCLBH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref NFFPAONFDAO MAEAOOFFCNL, ref KLEMKCCNPOG MKEELMOMMCF, StringBuilder FJLDECOLOJO);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class MBNGFFAJPOB
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class LLMKGOKCMNA<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : JLKFPOJLOAM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				private T <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				private int <>l__initialThreadId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private HashSet<JLKFPOJLOAM> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<JLKFPOJLOAM> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<JLKFPOJLOAM>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private JLKFPOJLOAM <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (T)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x1224AF0", Offset = "0x12230F0", VA = "0x181224AF0")]
				[DebuggerHidden]
				public LLMKGOKCMNA(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x12269B0", Offset = "0x1224FB0", VA = "0x1812269B0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3D3D600", Offset = "0x3D3BC00", VA = "0x183D3D600", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3D3D850", Offset = "0x3D3BE50", VA = "0x183D3D850")]
				private void PIAHDKPIMOH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3D3D9C0", Offset = "0x3D3BFC0", VA = "0x183D3D9C0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x3D3D910", Offset = "0x3D3BF10", VA = "0x183D3D910", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x1224A80", Offset = "0x1223080", VA = "0x181224A80", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<JLKFPOJLOAM> KHAAKKNNICH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<JLKFPOJLOAM> FLGPPODBMGG;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5CA0", Offset = "0x6BB42A0", VA = "0x186BB5CA0")]
			public void EOIKGHKFEAD(FMIILHIOPED KILBEAHOPEK, JLKFPOJLOAM KNODDDDACOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5E00", Offset = "0x6BB4400", VA = "0x186BB5E00")]
			private static void MOGIAACNOLF(ref HashSet<JLKFPOJLOAM> BHEDJJBBEIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2233830", Offset = "0x2231E30", VA = "0x182233830")]
			public IEnumerable<T> JGBNBNGBKEH<T>(bool EAFHDNGHHGG) where T : JLKFPOJLOAM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x151A3D0", Offset = "0x15189D0", VA = "0x18151A3D0")]
			[IteratorStateMachine(typeof(LLMKGOKCMNA<>))]
			private static IEnumerable<T> LDGHFMIOOPP<T>(HashSet<JLKFPOJLOAM> BHEDJJBBEIH) where T : JLKFPOJLOAM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public MBNGFFAJPOB()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct ChildViewReference
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int childId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PersistenceView persistenceView;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate void COHMPDLGMML(Guid NFBABOLBEJD, Guid OHFIMFMHIGG);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NGLGDPFFLCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public KBDALPDHODH serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public NGLGDPFFLCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5E80", Offset = "0x6BB4480", VA = "0x186BB5E80")]
			internal Task EEAODDDNOLP(EBOOJLMPNMJ comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GOKPJPBMCBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KBDALPDHODH serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private NGLGDPFFLCL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerable<Task> <componentTasks>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private ChildViewReference[] <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private ChildViewReference <childView>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private Task <childTask>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public GOKPJPBMCBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6BB49E0", Offset = "0x6BB2FE0", VA = "0x186BB49E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BEHEPJHPKGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public BEHEPJHPKGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4160", Offset = "0x6BB2760", VA = "0x186BB4160")]
			internal bool PMKEEFNBDAN(KCEKBOFJFLL d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> IGACOMMPDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool JJHIODNHPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ChildViewReference[] childViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private int highestChildIdAssigned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		public bool explicitlyBlockPersistence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private CPKHFJLIFDN<Guid> OCAJNGDHOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<JLKFPOJLOAM> FDKCAHBGDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<EBOOJLMPNMJ> PEPOACACOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MBNGFFAJPOB AHJNONGHEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid MBLHIGLOKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid BBABLEFIEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HMOFDMCMMHE IMKPEJKCFPL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> OKKBLHLBNCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6BBB2C0", Offset = "0x6BB98C0", VA = "0x186BBB2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid NEAPDBBCPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6BBAEF0", Offset = "0x6BB94F0", VA = "0x186BBAEF0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6BBB410", Offset = "0x6BB9A10", VA = "0x186BBB410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IIPKIFIMHOP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA75440", Offset = "0xA73A40", VA = "0x180A75440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA75390", Offset = "0xA73990", VA = "0x180A75390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JDFGMGKENAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6BBB010", Offset = "0x6BB9610", VA = "0x186BBB010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool FENPHOLNPNH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6BB7F80", Offset = "0x6BB6580", VA = "0x186BB7F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView CFGCKKGLHGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x91DC10", Offset = "0x91C210", VA = "0x18091DC10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x943F90", Offset = "0x942590", VA = "0x180943F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool NLDKPJOEJKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6BBAFB0", Offset = "0x6BB95B0", VA = "0x186BBAFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool GNINMOGFPBL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6BB7E50", Offset = "0x6BB6450", VA = "0x186BB7E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event COHMPDLGMML BNIIKKAMCLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6BBAE50", Offset = "0x6BB9450", VA = "0x186BBAE50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6BBB370", Offset = "0x6BB9970", VA = "0x186BBB370")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6E20", Offset = "0x6BB5420", VA = "0x186BB6E20", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7CC0", Offset = "0x6BB62C0", VA = "0x186BB7CC0")]
		private bool EEDLAFODOJN(out Guid HBNCBHOPPOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BB75F0", Offset = "0x6BB5BF0", VA = "0x186BB75F0")]
		private bool DEIGLEFOKOK(out Guid HBNCBHOPPOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9570", Offset = "0x6BB7B70", VA = "0x186BB9570")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BB90D0", Offset = "0x6BB76D0", VA = "0x186BB90D0", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8910", Offset = "0x6BB6F10", VA = "0x186BB8910")]
		private void MBMKBMEHPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9570", Offset = "0x6BB7B70", VA = "0x186BB9570")]
		private void OnMasterClientSwitched(DGGGEFEAKFD ALOFLFIJONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8FB0", Offset = "0x6BB75B0", VA = "0x186BB8FB0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9F10", Offset = "0x6BB8510", VA = "0x186BB9F10")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GOKPJPBMCBO))]
		public Task PreSerializeAsync(StringBuilder FJLDECOLOJO, KBDALPDHODH EGNEHPMLPBH, CancellationToken OOAGLCBNIOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA0A0", Offset = "0x6BB86A0", VA = "0x186BBA0A0")]
		public NFFPAONFDAO Serialize(ref KLEMKCCNPOG MKEELMOMMCF, StringBuilder FJLDECOLOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8140", Offset = "0x6BB6740", VA = "0x186BB8140")]
		public void InitializeDeserialization(NFFPAONFDAO MAEAOOFFCNL, bool DGFNFDEKHEN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BB99E0", Offset = "0x6BB7FE0", VA = "0x186BB99E0")]
		public void PreDeserialize(bool EAFHDNGHHGG, PJLOEOJDLAF CDGJGMOHJAO, NFFPAONFDAO MAEAOOFFCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7670", Offset = "0x6BB5C70", VA = "0x186BB7670")]
		public void Deserialize(bool EAFHDNGHHGG, FLLCNPJDOPP GEOBPLDCLBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9580", Offset = "0x6BB7B80", VA = "0x186BB9580")]
		public void PostDeserialize(bool EAFHDNGHHGG, LEJDGPCAPOD MAJOIHDGAKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BB83F0", Offset = "0x6BB69F0", VA = "0x186BB83F0")]
		private void KFKCCMNBPMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6B90", Offset = "0x6BB5190", VA = "0x186BB6B90")]
		private NFFPAONFDAO AHDIGKBFJCH(NFFPAONFDAO FNMDNBKDANA, ChildViewReference AIMPELPKDNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8EE0", Offset = "0x6BB74E0", VA = "0x186BB8EE0")]
		public void MarkExcludedFromRoomSave(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAB70", Offset = "0x6BB9170", VA = "0x186BBAB70")]
		public void UnmarkExcludedFromRoomSave(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAD40", Offset = "0x6BB9340", VA = "0x186BBAD40")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BB74E0", Offset = "0x6BB5AE0", VA = "0x186BB74E0")]
		[CompilerGenerated]
		private object CHPAINIMBBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7570", Offset = "0x6BB5B70", VA = "0x186BB7570")]
		[CompilerGenerated]
		private object CKACGKALINO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7DA0", Offset = "0x6BB63A0", VA = "0x186BB7DA0")]
		[CompilerGenerated]
		private object ENLFFPKACAD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class EPFFDDEKBCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BBBKKMMJPEP FIGOGGGELLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, NFFPAONFDAO)> HBPHOPPFLEE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public LMPJDKBMOBF LNBEEDDLGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public GBCKOOBFABI FPHGHCOGGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BHCGDDFBDAJ FPCCIJNJJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PJLOEOJDLAF FOECGJNBOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A20", Offset = "0x9B0020", VA = "0x1809B1A20")]
		[CompilerGenerated]
		get
		{
			return default(PJLOEOJDLAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public NGDMEJFKJLL PNNJPKNPCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public PPJKDKMANPD PDGFPDKEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GIDMOOPDLFC JFBKNHMHELE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x91DC10", Offset = "0x91C210", VA = "0x18091DC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool ONHDHGENEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA53ED0", Offset = "0xA524D0", VA = "0x180A53ED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4510", Offset = "0x6BB2B10", VA = "0x186BB4510")]
	public EPFFDDEKBCK(LMPJDKBMOBF MIDAGNGFEKI, GBCKOOBFABI EIJDLHHJPLM, BHCGDDFBDAJ BILDEBPIGPF, PJLOEOJDLAF CDGJGMOHJAO, bool AHLLLAKOMDK, NGDMEJFKJLL DNCLKGCICOE, PPJKDKMANPD PEGIFAKLECB, GIDMOOPDLFC NLGBGBOKNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB44F0", Offset = "0x6BB2AF0", VA = "0x186BB44F0")]
	public void IDCCFFCNGJG(BBBKKMMJPEP NCGLBCCHFCC, List<(PersistenceView, NFFPAONFDAO)> FBODAKFKGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4480", Offset = "0x6BB2A80", VA = "0x186BB4480")]
	public List<(PersistenceView, NFFPAONFDAO)> GEFMDKACJAH(BBBKKMMJPEP LBDJOMHJEGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GFLOEMPAIMF
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<BBBKKMMJPEP> AEIBBKNKPBH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<BBBKKMMJPEP> AGKMFKKLBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4690", Offset = "0x6BB2C90", VA = "0x186BB4690")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class PCMAACENNNL : IBCIOGFALAD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum OBMPFFFMJNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Start,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		LoadingScene,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		LoadingSubScenes,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		LoadingPersistence,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		PersistenceLoadComplete
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class OONOJKOCDID : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly object JHAKINLMMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly JAEANCGJHOM LNBMEBPIDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Action<object> PEJINFDFFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool EAOOMFEELLL;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C0D50", Offset = "0x9BF350", VA = "0x1809C0D50")]
		public OONOJKOCDID(object JHAKINLMMJL, JAEANCGJHOM LNBMEBPIDEB, Action<object> PEJINFDFFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5F60", Offset = "0x6BB4560", VA = "0x186BB5F60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly Dictionary<object, JAEANCGJHOM> NCKOIMDKBMF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OIIGIKLMMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HFECFJINPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6020", Offset = "0x6BB4620", VA = "0x186BB6020")]
	[PJEDGFFEDPC(PDIHHCLCNFI.None)]
	private static void ACDBAIMHKIG(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5FC0", Offset = "0x6BB45C0", VA = "0x186BB5FC0", Slot = "4")]
	public IReadOnlyList<JAEANCGJHOM> ABANEILECNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6740", Offset = "0x6BB4D40", VA = "0x186BB6740", Slot = "5")]
	public IDisposable NLIBFENLHKD(object JHAKINLMMJL, JAEANCGJHOM LNBMEBPIDEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6200", Offset = "0x6BB4800", VA = "0x186BB6200")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void EDNNGHLGEAH(JAEANCGJHOM LNBMEBPIDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6520", Offset = "0x6BB4B20", VA = "0x186BB6520")]
	private void GJIDECFGIAH(object JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6110", Offset = "0x6BB4710", VA = "0x186BB6110")]
	[EDLDGBIGMCG(LFDHGOCABCF.Unity_AfterSceneLoad)]
	private static void BJFJBGMMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB63F0", Offset = "0x6BB49F0", VA = "0x186BB63F0")]
	internal static void GEJNBBDCPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6A80", Offset = "0x6BB5080", VA = "0x186BB6A80")]
	internal void PHJHBMJMFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6B10", Offset = "0x6BB5110", VA = "0x186BB6B10")]
	public PCMAACENNNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KOMFNDJENBN
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DJCACPHEKOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KOMFNDJENBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DJCACPHEKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4230", Offset = "0x6BB2830", VA = "0x186BB4230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float EBENBCOFILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly float DCLMCBCNPIL;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5C60", Offset = "0x6BB4260", VA = "0x186BB5C60")]
	public KOMFNDJENBN(float DCLMCBCNPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5B10", Offset = "0x6BB4110", VA = "0x186BB5B10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJCACPHEKOA))]
	public Task ENCDOPIEGHH(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5AF0", Offset = "0x6BB40F0", VA = "0x186BB5AF0")]
	public void BCFKLBADKBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GOIIKNDPALN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	FMIILHIOPED COMLBCHAAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(NGDMEJFKJLL DNCLKGCICOE, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref NGDMEJFKJLL DNCLKGCICOE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[EHFCAELBLDP]
public enum BBBKKMMJPEP
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NOT_STARTED = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	DOWNLOADING_DETAILS = 1,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	DETAILS_DOWNLOADED = 2,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	DOWNLOADING_DATA = 3,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	DATA_DOWNLOADED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	INIT_OBJECTMODEL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	SCENE_LOADED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 7,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	SETUP_ROOM_OBJECTS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	RUN_MIGRATIONS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PRE_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	POST_DESTROY_OLD_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	DESERIALIZE_SETTINGS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	PRE_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	POST_INSTANTIATE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PRE_DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	DESERIALIZE_OBJECTS = 15,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	DESERIALIZE_CONNECTABLES = 16,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	POST_DESERIALIZE_OBJECTS = 17,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DESERIALIZE_OBJECTS_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PRE_COMPLETE = 19,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	COMPLETE = 20
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KOFNMPLHJEJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate Task DLCALGBFBPE(EPFFDDEKBCK GDDHAFPALIL, CancellationToken OOAGLCBNIOG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EBOOJLMPNMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder FJLDECOLOJO, KBDALPDHODH EGNEHPMLPBH, CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JAEANCGJHOM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool NFONIGEIIMB(EPFFDDEKBCK GOMDNNCBLHP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FGKADICMGGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FGKADICMGGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4620", Offset = "0x6BB2C20", VA = "0x186BB4620")]
		internal Task EMKEICDICHC(EPFFDDEKBCK data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GLMMGJEJOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<EPFFDDEKBCK> handler;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GLMMGJEJOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4950", Offset = "0x6BB2F50", VA = "0x186BB4950")]
		internal Task EMKEICDICHC(EPFFDDEKBCK data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KNJHNMJAIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KOFNMPLHJEJ handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public JAEANCGJHOM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KNJHNMJAIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5A40", Offset = "0x6BB4040", VA = "0x186BB5A40")]
		internal object NLPOPEHGEEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<BBBKKMMJPEP, HashSet<(KOFNMPLHJEJ, NFONIGEIIMB, DLCALGBFBPE)>> NABIDGJNBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Guid NAMKFEIKBOG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BB58E0", Offset = "0x6BB3EE0", VA = "0x186BB58E0")]
	public JAEANCGJHOM(Guid ABIEJAANDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BB56A0", Offset = "0x6BB3CA0", VA = "0x186BB56A0")]
	public JAEANCGJHOM IAGEEANGHPC(BBBKKMMJPEP MPHKDHOHMJI, KOFNMPLHJEJ KILBEAHOPEK, DLCALGBFBPE LNBMEBPIDEB, [Optional] NFONIGEIIMB LBJNPLNAPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BB54A0", Offset = "0x6BB3AA0", VA = "0x186BB54A0")]
	public JAEANCGJHOM IAGEEANGHPC(BBBKKMMJPEP MPHKDHOHMJI, KOFNMPLHJEJ KILBEAHOPEK, Action LNBMEBPIDEB, [Optional] NFONIGEIIMB LBJNPLNAPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BB55A0", Offset = "0x6BB3BA0", VA = "0x186BB55A0")]
	public JAEANCGJHOM IAGEEANGHPC(BBBKKMMJPEP MPHKDHOHMJI, KOFNMPLHJEJ KILBEAHOPEK, Action<EPFFDDEKBCK> LNBMEBPIDEB, [Optional] NFONIGEIIMB LBJNPLNAPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5010", Offset = "0x6BB3610", VA = "0x186BB5010")]
	public Dictionary<KOFNMPLHJEJ, List<DLCALGBFBPE>> CHLAIEJFCHI(BBBKKMMJPEP NCGLBCCHFCC, EPFFDDEKBCK GOMDNNCBLHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum ELOHJNEJPLG
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum KBDALPDHODH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LEJDGPCAPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool GBHMIFMNKLB;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OFCPOFGNLJH : JLKFPOJLOAM
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(LEJDGPCAPOD MAJOIHDGAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IBCIOGFALAD
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OIIGIKLMMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HFECFJINPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<JAEANCGJHOM> ABANEILECNF();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NLIBFENLHKD(object JHAKINLMMJL, JAEANCGJHOM LNBMEBPIDEB);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
