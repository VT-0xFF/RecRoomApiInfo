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
public interface FDCACCPPPDK : GKCHCDOHGNO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(DLDBICONFJM LBBOJKMAAGP, EHDNHMEBPAJ FOIHDPEDGJM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct JCFCMKNDBOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public DLDBICONFJM LBBOJKMAAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public EHDNHMEBPAJ FOIHDPEDGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool FDEEOIOECJN;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OOMJECFJHBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> FBKMMCEKPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public POJIKPFFFCH NBHCKFANICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int CJMCKIFKHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 DGKBLFGNIEG;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F6B0", Offset = "0x6C2E6B0", VA = "0x186C2F6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F700", Offset = "0x6C2E700", VA = "0x186C2F700")]
	public OOMJECFJHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JDKMFEMICCP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GKCHCDOHGNO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JDKMFEMICCP BDFAMHLKIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JDDCKDMBCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(JCFCMKNDBOA OPLEOMPOJIP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref EHDNHMEBPAJ FOIHDPEDGJM, ref OOMJECFJHBK NIICCNOEDKK, StringBuilder DKOBFKMEDNL);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class EMOFMGLKBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class GEBJDMNFGKO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : GKCHCDOHGNO
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
				private HashSet<GKCHCDOHGNO> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<GKCHCDOHGNO> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<GKCHCDOHGNO>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private GKCHCDOHGNO <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x185A3D0", Offset = "0x18593D0", VA = "0x18185A3D0")]
				[DebuggerHidden]
				public GEBJDMNFGKO(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1E6EAF0", Offset = "0x1E6DAF0", VA = "0x181E6EAF0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2C880B0", Offset = "0x2C870B0", VA = "0x182C880B0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2C87FF0", Offset = "0x2C86FF0", VA = "0x182C87FF0")]
				private void JIJNIFIPMPN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2C883B0", Offset = "0x2C873B0", VA = "0x182C883B0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2C88300", Offset = "0x2C87300", VA = "0x182C88300", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x1F5DF40", Offset = "0x1F5CF40", VA = "0x181F5DF40", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<GKCHCDOHGNO> NDNCKBEFELB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<GKCHCDOHGNO> IMJNCHHJFKN;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C2E4C0", Offset = "0x6C2D4C0", VA = "0x186C2E4C0")]
			public void DDKIGOHGKNO(JDKMFEMICCP APJHCNCGIGD, GKCHCDOHGNO GHLPIKPFLFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C2E620", Offset = "0x6C2D620", VA = "0x186C2E620")]
			private static void MLAMBONNOCC(ref HashSet<GKCHCDOHGNO> IOBPFBILMIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3323B20", Offset = "0x3322B20", VA = "0x183323B20")]
			public IEnumerable<T> AFPGHJCLIMJ<T>(bool NEMDFCKOCMK) where T : GKCHCDOHGNO
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1E13D60", Offset = "0x1E12D60", VA = "0x181E13D60")]
			[IteratorStateMachine(typeof(GEBJDMNFGKO<>))]
			private static IEnumerable<T> NEGBBHLEPFD<T>(HashSet<GKCHCDOHGNO> IOBPFBILMIA) where T : GKCHCDOHGNO
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public EMOFMGLKBJJ()
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
		public delegate void KJBKFBOBFNF(Guid BELEEMNFHJD, Guid OKGGOPFKIHE);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class AHKLBBGGEON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public FCHEHKECEPG serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public AHKLBBGGEON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6C2DBC0", Offset = "0x6C2CBC0", VA = "0x186C2DBC0")]
			internal Task OIAEBEJLDAN(NBCDHHKBCKK comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AOONDAPJGMJ : IAsyncStateMachine
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
			public FCHEHKECEPG serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private AHKLBBGGEON <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public AOONDAPJGMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C2DE60", Offset = "0x6C2CE60", VA = "0x186C2DE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BFBBNNEOCCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public BFBBNNEOCCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C2E490", Offset = "0x6C2D490", VA = "0x186C2E490")]
			internal bool LKLGGCLBPAM(PGGEMBCGFGE d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> CFNEKCKJJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool HKMLACDKGCD;

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
		private EIGMMGGLINB<Guid> DFCMAOGNGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<GKCHCDOHGNO> KEIAGEOEBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<NBCDHHKBCKK> JNCHOGKBMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EMOFMGLKBJJ OJKNEAMHHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid AJDJNFHHEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid EEEPHNDOACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OEMFJNEEEFM OFKBHFIMFEL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> JHHJHEDMMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6C347F0", Offset = "0x6C337F0", VA = "0x186C347F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid BHGLMOPPBKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6C34420", Offset = "0x6C33420", VA = "0x186C34420")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C34940", Offset = "0x6C33940", VA = "0x186C34940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JFDGHEIMDKL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xADE600", Offset = "0xADD600", VA = "0x180ADE600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xADE020", Offset = "0xADD020", VA = "0x180ADE020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HLDGHPLMHHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C34540", Offset = "0x6C33540", VA = "0x186C34540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool MDNFCODFADP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C30E60", Offset = "0x6C2FE60", VA = "0x186C30E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView MMGNKEIAJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9F7110", Offset = "0x9F6110", VA = "0x1809F7110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HONDNFBJIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6C344E0", Offset = "0x6C334E0", VA = "0x186C344E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool AONNOMKDEHH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C317D0", Offset = "0x6C307D0", VA = "0x186C317D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KJBKFBOBFNF ODFFJJHGNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6C34380", Offset = "0x6C33380", VA = "0x186C34380")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C348A0", Offset = "0x6C338A0", VA = "0x186C348A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C300B0", Offset = "0x6C2F0B0", VA = "0x186C300B0", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C31660", Offset = "0x6C30660", VA = "0x186C31660")]
		private bool KPOFLPAPGOF(out Guid JHLOKBHGAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C31020", Offset = "0x6C30020", VA = "0x186C31020")]
		private bool HMFIHIMKLKD(out Guid JHLOKBHGAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C32AA0", Offset = "0x6C31AA0", VA = "0x186C32AA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C32610", Offset = "0x6C31610", VA = "0x186C32610", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C32040", Offset = "0x6C31040", VA = "0x186C32040")]
		private void OKPICHLLODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C32AA0", Offset = "0x6C31AA0", VA = "0x186C32AA0")]
		private void OnMasterClientSwitched(CMBJDOEGEFJ ECKCAFOFCOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C31F20", Offset = "0x6C30F20", VA = "0x186C31F20")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C33440", Offset = "0x6C32440", VA = "0x186C33440")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AOONDAPJGMJ))]
		public Task PreSerializeAsync(StringBuilder DKOBFKMEDNL, FCHEHKECEPG MHANIEBHIHC, CancellationToken AOAEIGNDKPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C335D0", Offset = "0x6C325D0", VA = "0x186C335D0")]
		public EHDNHMEBPAJ Serialize(ref OOMJECFJHBK NIICCNOEDKK, StringBuilder DKOBFKMEDNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C310A0", Offset = "0x6C300A0", VA = "0x186C310A0")]
		public void InitializeDeserialization(EHDNHMEBPAJ FOIHDPEDGJM, bool HMGHPFGFNDO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C32F10", Offset = "0x6C31F10", VA = "0x186C32F10")]
		public void PreDeserialize(bool NEMDFCKOCMK, DLDBICONFJM LBBOJKMAAGP, EHDNHMEBPAJ FOIHDPEDGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C30760", Offset = "0x6C2F760", VA = "0x186C30760")]
		public void Deserialize(bool NEMDFCKOCMK, JCFCMKNDBOA OPLEOMPOJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C32AB0", Offset = "0x6C31AB0", VA = "0x186C32AB0")]
		public void PostDeserialize(bool NEMDFCKOCMK, IHCOAICHMDG PONPAFPLCHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C31900", Offset = "0x6C30900", VA = "0x186C31900")]
		private void MHEJODKNFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C31350", Offset = "0x6C30350", VA = "0x186C31350")]
		private EHDNHMEBPAJ KAFPBFGPOOH(EHDNHMEBPAJ EBLIKDOHBKL, ChildViewReference CJCAJMJJJKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C31E50", Offset = "0x6C30E50", VA = "0x186C31E50")]
		public void MarkExcludedFromRoomSave(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C340A0", Offset = "0x6C330A0", VA = "0x186C340A0")]
		public void UnmarkExcludedFromRoomSave(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C34270", Offset = "0x6C33270", VA = "0x186C34270")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C31740", Offset = "0x6C30740", VA = "0x186C31740")]
		[CompilerGenerated]
		private object LKCPLJMGBNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C315E0", Offset = "0x6C305E0", VA = "0x186C315E0")]
		[CompilerGenerated]
		private object KGKNKIKJLIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C30DB0", Offset = "0x6C2FDB0", VA = "0x186C30DB0")]
		[CompilerGenerated]
		private object GFPMLIFGFDB()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MLICCGFKPBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FJPEGOCFHLO OMNJMNCBMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, EHDNHMEBPAJ)> FELAMMAOHMJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public HFCNBIIEHLN LNKFLONPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public BHKIGNODGGN BEIGDNLHLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MJDOGGEGMAI MEENIFGILGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DLDBICONFJM BLIMCIDGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB92920", Offset = "0xB91920", VA = "0x180B92920")]
		[CompilerGenerated]
		get
		{
			return default(DLDBICONFJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public HJBOCBIPMIO FHOOJNJGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FAOEADGKIBK CCPAKNMFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LNEEMMLDGFL LEOIDBJDINF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BOOGINFFGFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA85EF0", Offset = "0xA84EF0", VA = "0x180A85EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F510", Offset = "0x6C2E510", VA = "0x186C2F510")]
	public MLICCGFKPBG(HFCNBIIEHLN DJAJOEFBOKM, BHKIGNODGGN LEDHNAJDPBF, MJDOGGEGMAI KAHMFEPAPOB, DLDBICONFJM LBBOJKMAAGP, bool LKMIHMKNNLN, HJBOCBIPMIO EICHFPBIJBD, FAOEADGKIBK KKOHNCFJGIK, LNEEMMLDGFL FNMAGMKKPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F480", Offset = "0x6C2E480", VA = "0x186C2F480")]
	public void BHKJKCJAGGI(FJPEGOCFHLO PJNKCNCDGIL, List<(PersistenceView, EHDNHMEBPAJ)> CIFIMCOBJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F4A0", Offset = "0x6C2E4A0", VA = "0x186C2F4A0")]
	public List<(PersistenceView, EHDNHMEBPAJ)> DKLAPINEAEJ(FJPEGOCFHLO NCFLNFDNKGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GPDFDPCKNCA
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<FJPEGOCFHLO> KFLODEOFBCG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<FJPEGOCFHLO> HGHAOEOAJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E6A0", Offset = "0x6C2D6A0", VA = "0x186C2E6A0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class KGKONCDCDBA : FPKBGJONHAP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum HFGGODEBHIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Start,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		LoadingScene,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		LoadingSubScenes,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		LoadingPersistence,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PersistenceLoadComplete
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class PIMPHAEECID : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly object HBLIBBFCHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly PBCKDOBPMHO KHGAJAOMHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Action<object> JJHAPMOGAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool PPEKOOOIOOG;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA49EB0", Offset = "0xA48EB0", VA = "0x180A49EB0")]
		public PIMPHAEECID(object HBLIBBFCHOD, PBCKDOBPMHO KHGAJAOMHOH, Action<object> JJHAPMOGAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C30050", Offset = "0x6C2F050", VA = "0x186C30050", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly Dictionary<object, PBCKDOBPMHO> OHMOAECFKJA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NEOJPGBHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DLCPBCDFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C2ED90", Offset = "0x6C2DD90", VA = "0x186C2ED90")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EE80", Offset = "0x6C2DE80", VA = "0x186C2EE80", Slot = "4")]
	public IReadOnlyList<PBCKDOBPMHO> GNNLMADKKIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F170", Offset = "0x6C2E170", VA = "0x186C2F170", Slot = "5")]
	public IDisposable OHFNBOPCKNO(object HBLIBBFCHOD, PBCKDOBPMHO KHGAJAOMHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EB10", Offset = "0x6C2DB10", VA = "0x186C2EB10")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CFCDAMCNCDG(PBCKDOBPMHO KHGAJAOMHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EEE0", Offset = "0x6C2DEE0", VA = "0x186C2EEE0")]
	private void IDHPKDHGFOM(object HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F070", Offset = "0x6C2E070", VA = "0x186C2F070")]
	[HNDDGAICDJM(KJNNMKFJALK.Unity_AfterSceneLoad)]
	private static void IOFDPNFHCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EF40", Offset = "0x6C2DF40", VA = "0x186C2EF40")]
	internal static void IFIOIGNKDGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2ED00", Offset = "0x6C2DD00", VA = "0x186C2ED00")]
	internal void EEJJFINKLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F360", Offset = "0x6C2E360", VA = "0x186C2F360")]
	public KGKONCDCDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AGJJBIKALMI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class AOCJJFKNKBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AGJJBIKALMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AOCJJFKNKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DCA0", Offset = "0x6C2CCA0", VA = "0x186C2DCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float HBEKKCKFJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly float MBKGOLMEJEH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DB80", Offset = "0x6C2CB80", VA = "0x186C2DB80")]
	public AGJJBIKALMI(float MBKGOLMEJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DA10", Offset = "0x6C2CA10", VA = "0x186C2DA10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOCJJFKNKBP))]
	public Task IGIOODCEDKI(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DB60", Offset = "0x6C2CB60", VA = "0x186C2DB60")]
	public void OMJIIKCHOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HFGJEOKCNDH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JDKMFEMICCP DAMJEJJCNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(HJBOCBIPMIO EICHFPBIJBD, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref HJBOCBIPMIO EICHFPBIJBD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[JLPIEBHHIJJ]
public enum FJPEGOCFHLO
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	NOT_STARTED = 0,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	DOWNLOADING_DETAILS = 1,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	DETAILS_DOWNLOADED = 2,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	DOWNLOADING_DATA = 3,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	DATA_DOWNLOADED = 4,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	INIT_OBJECTMODEL = 5,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SCENE_LOADED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 7,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	SETUP_ROOM_OBJECTS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RUN_MIGRATIONS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PRE_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	POST_DESTROY_OLD_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	DESERIALIZE_SETTINGS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	PRE_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	POST_INSTANTIATE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	PRE_DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DESERIALIZE_OBJECTS = 15,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	DESERIALIZE_CONNECTABLES = 16,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	POST_DESERIALIZE_OBJECTS = 17,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	DESERIALIZE_OBJECTS_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PRE_COMPLETE = 19,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	COMPLETE = 20
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum EDJKELCENHH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate Task NOKGGCBOAHJ(MLICCGFKPBG JMLOLLOGKEE, CancellationToken AOAEIGNDKPI);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NBCDHHKBCKK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder DKOBFKMEDNL, FCHEHKECEPG MHANIEBHIHC, CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PBCKDOBPMHO
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate bool GJEHFPHFIOL(MLICCGFKPBG HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JNHOLGAKACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JNHOLGAKACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E9F0", Offset = "0x6C2D9F0", VA = "0x186C2E9F0")]
		internal Task CAFCIDIBOAM(MLICCGFKPBG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IIGAMACCGHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action<MLICCGFKPBG> handler;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IIGAMACCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E960", Offset = "0x6C2D960", VA = "0x186C2E960")]
		internal Task CAFCIDIBOAM(MLICCGFKPBG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JPIMKEPKFAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public EDJKELCENHH handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public PBCKDOBPMHO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JPIMKEPKFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EA60", Offset = "0x6C2DA60", VA = "0x186C2EA60")]
		internal object NLJPFNMPNHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<FJPEGOCFHLO, HashSet<(EDJKELCENHH, GJEHFPHFIOL, NOKGGCBOAHJ)>> LAJBKLHFGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Guid BPFIPANPFLD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FFC0", Offset = "0x6C2EFC0", VA = "0x186C2FFC0")]
	public PBCKDOBPMHO(Guid CPANAOFEFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F780", Offset = "0x6C2E780", VA = "0x186C2F780")]
	public PBCKDOBPMHO IJMHBNLOAKB(FJPEGOCFHLO IACEECNBNCE, EDJKELCENHH APJHCNCGIGD, NOKGGCBOAHJ KHGAJAOMHOH, [Optional] GJEHFPHFIOL BEJLCOICJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FAC0", Offset = "0x6C2EAC0", VA = "0x186C2FAC0")]
	public PBCKDOBPMHO IJMHBNLOAKB(FJPEGOCFHLO IACEECNBNCE, EDJKELCENHH APJHCNCGIGD, Action KHGAJAOMHOH, [Optional] GJEHFPHFIOL BEJLCOICJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F9C0", Offset = "0x6C2E9C0", VA = "0x186C2F9C0")]
	public PBCKDOBPMHO IJMHBNLOAKB(FJPEGOCFHLO IACEECNBNCE, EDJKELCENHH APJHCNCGIGD, Action<MLICCGFKPBG> KHGAJAOMHOH, [Optional] GJEHFPHFIOL BEJLCOICJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FBC0", Offset = "0x6C2EBC0", VA = "0x186C2FBC0")]
	public Dictionary<EDJKELCENHH, List<NOKGGCBOAHJ>> OHENIJCGCAK(FJPEGOCFHLO PJNKCNCDGIL, MLICCGFKPBG HCKNMLENIIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum GHGMNDCOENL
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum FCHEHKECEPG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IHCOAICHMDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool FDEEOIOECJN;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GFMADPDKIHM : GKCHCDOHGNO
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(IHCOAICHMDG PONPAFPLCHB);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FPKBGJONHAP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NEOJPGBHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DLCPBCDFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<PBCKDOBPMHO> GNNLMADKKIF();

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OHFNBOPCKNO(object HBLIBBFCHOD, PBCKDOBPMHO KHGAJAOMHOH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
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
