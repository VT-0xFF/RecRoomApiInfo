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
public interface IBMDFMFKCFA : KLCBNDFEBHE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(HBHNCFJCIKF PMBDBGOOBNH, HGNMPOIAAKI EJFGMPEJEDD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct EELJOFEKJPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public HBHNCFJCIKF PMBDBGOOBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public HGNMPOIAAKI EJFGMPEJEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool GLCIMNDNDCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EKIEPCIPJDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> BMEDKJLJAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public KABJJEIAHLA BICFLCMKKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int HDPPEDEKEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 MDCMOFAGKHM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D1F0", Offset = "0x6A8BDF0", VA = "0x186A8D1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D240", Offset = "0x6A8BE40", VA = "0x186A8D240")]
	public EKIEPCIPJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AJNEGGGJOEA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KLCBNDFEBHE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AJNEGGGJOEA LHPIGHEBELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NPLENJCFMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(EELJOFEKJPG MMAODDOOPPG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref HGNMPOIAAKI EJFGMPEJEDD, ref EKIEPCIPJDM LHNAPAPHKDJ, StringBuilder OFLJODODJPE);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class GDMPPOFMBCP
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class CJPMKOJCIOI<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : KLCBNDFEBHE
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
				private HashSet<KLCBNDFEBHE> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<KLCBNDFEBHE> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<KLCBNDFEBHE>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private KLCBNDFEBHE <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x1FC23F0", Offset = "0x1FC0FF0", VA = "0x181FC23F0")]
				[DebuggerHidden]
				public CJPMKOJCIOI(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x29A7EF0", Offset = "0x29A6AF0", VA = "0x1829A7EF0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x29A7B80", Offset = "0x29A6780", VA = "0x1829A7B80", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x29A7AC0", Offset = "0x29A66C0", VA = "0x1829A7AC0")]
				private void EHFOANOMIIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x29A7EB0", Offset = "0x29A6AB0", VA = "0x1829A7EB0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x29A7DD0", Offset = "0x29A69D0", VA = "0x1829A7DD0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x29A7E80", Offset = "0x29A6A80", VA = "0x1829A7E80", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<KLCBNDFEBHE> FOCDKAKJKJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<KLCBNDFEBHE> PHHBEMEAINI;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8D340", Offset = "0x6A8BF40", VA = "0x186A8D340")]
			public void MMNGOAOENLJ(AJNEGGGJOEA KGEBDJDHLNM, KLCBNDFEBHE MBLDJEBKNAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6A8D2C0", Offset = "0x6A8BEC0", VA = "0x186A8D2C0")]
			private static void FDEFANCFLNG(ref HashSet<KLCBNDFEBHE> MJPJIGOGOAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2E5E5B0", Offset = "0x2E5D1B0", VA = "0x182E5E5B0")]
			public IEnumerable<T> FJPDALBPALC<T>(bool FPJMKDBAJEB) where T : KLCBNDFEBHE
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x14590E0", Offset = "0x1457CE0", VA = "0x1814590E0")]
			[IteratorStateMachine(typeof(CJPMKOJCIOI<>))]
			private static IEnumerable<T> INMJCPMEPCH<T>(HashSet<KLCBNDFEBHE> MJPJIGOGOAP) where T : KLCBNDFEBHE
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public GDMPPOFMBCP()
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
		public delegate void KJKNNFDPDCC(Guid CAOBNCDPEFG, Guid HNDAECKIDDB);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EECAAHIGLAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public GEDJHDMKMOJ serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public EECAAHIGLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6A8D110", Offset = "0x6A8BD10", VA = "0x186A8D110")]
			internal Task PGEPOOLGHEI(KENBNKLNLOA comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class CIACFFFIIPE : IAsyncStateMachine
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
			public GEDJHDMKMOJ serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private EECAAHIGLAD <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public CIACFFFIIPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CB00", Offset = "0x6A8B700", VA = "0x186A8CB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HPHKIJJONOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public HPHKIJJONOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6A8DEB0", Offset = "0x6A8CAB0", VA = "0x186A8DEB0")]
			internal bool ELOCPKKHFLH(ILKMODHBMKN d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> DDCJKFCMKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool CBHFNGCKJOF;

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
		private DDNECLEKHMK<Guid> JBJNDBNLABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<KLCBNDFEBHE> GELCOFFIOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<KENBNKLNLOA> LEOAILANGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GDMPPOFMBCP DLEGKFDOHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid GLLAEOGFMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid PJDJODOPHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FMDOKKBAPOM DIHKKLMMDLO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> CFOACJLBAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6A93A60", Offset = "0x6A92660", VA = "0x186A93A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid FKAHMJGAGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6A93690", Offset = "0x6A92290", VA = "0x186A93690")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6A93BB0", Offset = "0x6A927B0", VA = "0x186A93BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EBCAPKKIEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xB5CB10", Offset = "0xB5B710", VA = "0x180B5CB10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD9DF10", Offset = "0xD9CB10", VA = "0x180D9DF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MOIJLFMJIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6A937B0", Offset = "0x6A923B0", VA = "0x186A937B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool KJIAAPKAAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6A91390", Offset = "0x6A8FF90", VA = "0x186A91390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView JLFHCFIMIDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89C6B0", Offset = "0x89B2B0", VA = "0x18089C6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IMBGMGLLJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6A93750", Offset = "0x6A92350", VA = "0x186A93750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool DGAOAFJKIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8FA00", Offset = "0x6A8E600", VA = "0x186A8FA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KJKNNFDPDCC DJKLFAAJJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6A935F0", Offset = "0x6A921F0", VA = "0x186A935F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6A93B10", Offset = "0x6A92710", VA = "0x186A93B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F350", Offset = "0x6A8DF50", VA = "0x186A8F350", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A90720", Offset = "0x6A8F320", VA = "0x186A90720")]
		private bool FOGHBFFPJEB(out Guid OKLJCKBADHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A90D40", Offset = "0x6A8F940", VA = "0x186A90D40")]
		private bool JAJCANCOOHJ(out Guid OKLJCKBADHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A91D20", Offset = "0x6A90920", VA = "0x186A91D20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A91880", Offset = "0x6A90480", VA = "0x186A91880", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A90DC0", Offset = "0x6A8F9C0", VA = "0x186A90DC0")]
		private void JJEBGJKJOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A91D20", Offset = "0x6A90920", VA = "0x186A91D20")]
		private void OnMasterClientSwitched(FDHHGKFBMIM ILJFHAFPNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A91760", Offset = "0x6A90360", VA = "0x186A91760")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A926C0", Offset = "0x6A912C0", VA = "0x186A926C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CIACFFFIIPE))]
		public Task PreSerializeAsync(StringBuilder OFLJODODJPE, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A92850", Offset = "0x6A91450", VA = "0x186A92850")]
		public HGNMPOIAAKI Serialize(ref EKIEPCIPJDM LHNAPAPHKDJ, StringBuilder OFLJODODJPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A90A90", Offset = "0x6A8F690", VA = "0x186A90A90")]
		public void InitializeDeserialization(HGNMPOIAAKI EJFGMPEJEDD, bool INCCKKOINMK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A92190", Offset = "0x6A90D90", VA = "0x186A92190")]
		public void PreDeserialize(bool FPJMKDBAJEB, HBHNCFJCIKF PMBDBGOOBNH, HGNMPOIAAKI EJFGMPEJEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FBB0", Offset = "0x6A8E7B0", VA = "0x186A8FBB0")]
		public void Deserialize(bool FPJMKDBAJEB, EELJOFEKJPG MMAODDOOPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A91D30", Offset = "0x6A90930", VA = "0x186A91D30")]
		public void PostDeserialize(bool FPJMKDBAJEB, CKGIIPHAJBG DIGHFJCKNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A90200", Offset = "0x6A8EE00", VA = "0x186A90200")]
		private void FBODOLHOOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A90800", Offset = "0x6A8F400", VA = "0x186A90800")]
		private HGNMPOIAAKI IPNEBHKNMCP(HGNMPOIAAKI LHCFLIKJJBE, ChildViewReference PIKIEEICNEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6A91690", Offset = "0x6A90290", VA = "0x186A91690")]
		public void MarkExcludedFromRoomSave(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A93320", Offset = "0x6A91F20", VA = "0x186A93320")]
		public void UnmarkExcludedFromRoomSave(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A934E0", Offset = "0x6A920E0", VA = "0x186A934E0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A91600", Offset = "0x6A90200", VA = "0x186A91600")]
		[CompilerGenerated]
		private object MGLCAOCOALD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FB30", Offset = "0x6A8E730", VA = "0x186A8FB30")]
		[CompilerGenerated]
		private object CFHNOKPNHOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A91550", Offset = "0x6A90150", VA = "0x186A91550")]
		[CompilerGenerated]
		private object LFGJPIFDIFD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MOMCOKAPMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FEEJMENJLIJ COOPGACFJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, HGNMPOIAAKI)> NKKMAELDKGN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public IEMLKNOFDEG LJCLBLDIDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public MPOOILGCDLJ FNALKOCFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JGCDJAPPMFN NJJNAFICAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HBHNCFJCIKF MLDCAOMGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x844A80", Offset = "0x843680", VA = "0x180844A80")]
		[CompilerGenerated]
		get
		{
			return default(HBHNCFJCIKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public BNIDNMGAHLD GMFICCODGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CIOHJELGAHC NLHCMKDCGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x843910", Offset = "0x842510", VA = "0x180843910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DBGKDIDMLDF LOODPMKNAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GAPBENDHCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6690", Offset = "0xAA5290", VA = "0x180AA6690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F1D0", Offset = "0x6A8DDD0", VA = "0x186A8F1D0")]
	public MOMCOKAPMLC(IEMLKNOFDEG KBEKHLAONIE, MPOOILGCDLJ BABJGPMDFNF, JGCDJAPPMFN NBMKKHHOMOM, HBHNCFJCIKF PMBDBGOOBNH, bool EENPLMGAOGD, BNIDNMGAHLD CMMCIHFHBLL, CIOHJELGAHC IKHHHDILDNK, DBGKDIDMLDF PNNKKHOAFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F140", Offset = "0x6A8DD40", VA = "0x186A8F140")]
	public void CODLALFEOGO(FEEJMENJLIJ MJLJKGOPJKG, List<(PersistenceView, HGNMPOIAAKI)> LDOJACGGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F160", Offset = "0x6A8DD60", VA = "0x186A8F160")]
	public List<(PersistenceView, HGNMPOIAAKI)> FAPCBMPEKDH(FEEJMENJLIJ PPPALKCBHOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LHCMJJIDKOM
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<FEEJMENJLIJ> NELGBPFIHHO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<FEEJMENJLIJ> OFCEFMKBFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6A8EDF0", Offset = "0x6A8D9F0", VA = "0x186A8EDF0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class KOBMOCONKIC : BBJHDNJAMLE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum EANAEEPNABF
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
	private class KBDKJAEIMNK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly object JFDMKPDIBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly HGGHGJBADJJ NMPOOPDGJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Action<object> NLNAGGIIEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool GHKACLCDPMJ;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xDAB9A0", Offset = "0xDAA5A0", VA = "0x180DAB9A0")]
		public KBDKJAEIMNK(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD, Action<object> NLNAGGIIEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DF70", Offset = "0x6A8CB70", VA = "0x186A8DF70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly Dictionary<object, HGGHGJBADJJ> MJEKDIIJBJM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JBJLFLLGBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HHBHMKLOFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E4A0", Offset = "0x6A8D0A0", VA = "0x186A8E4A0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E220", Offset = "0x6A8CE20", VA = "0x186A8E220", Slot = "4")]
	public IReadOnlyList<HGGHGJBADJJ> EGAFFNAAALH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E590", Offset = "0x6A8D190", VA = "0x186A8E590", Slot = "5")]
	public IDisposable JBKIEOAMFHJ(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EB80", Offset = "0x6A8D780", VA = "0x186A8EB80")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void LIOCDNKPJKP(HGGHGJBADJJ NMPOOPDGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E8D0", Offset = "0x6A8D4D0", VA = "0x186A8E8D0")]
	private void KGJAEDGFGMD(object JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E3B0", Offset = "0x6A8CFB0", VA = "0x186A8E3B0")]
	[GOLHGLLJIPN(OEMLBLOOECK.Unity_AfterSceneLoad)]
	private static void EPPMEGBLMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E280", Offset = "0x6A8CE80", VA = "0x186A8E280")]
	internal static void EKPNKNJDMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EAF0", Offset = "0x6A8D6F0", VA = "0x186A8EAF0")]
	internal void LHBMNBIPFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A8ED70", Offset = "0x6A8D970", VA = "0x186A8ED70")]
	public KOBMOCONKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KBOEHLEJIFO
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AAMIDBEJLPA : IAsyncStateMachine
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
		public KBOEHLEJIFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AAMIDBEJLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C970", Offset = "0x6A8B570", VA = "0x186A8C970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float AHBGEIHFLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly float CNFHBIIKHPL;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E140", Offset = "0x6A8CD40", VA = "0x186A8E140")]
	public KBOEHLEJIFO(float CNFHBIIKHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DFD0", Offset = "0x6A8CBD0", VA = "0x186A8DFD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAMIDBEJLPA))]
	public Task CLBOOCINHEA(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E120", Offset = "0x6A8CD20", VA = "0x186A8E120")]
	public void NHGHFKAFNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FJCPJGMOIHP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AJNEGGGJOEA NBALNFLIJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(BNIDNMGAHLD CMMCIHFHBLL, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref BNIDNMGAHLD CMMCIHFHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CBONMDLGKNK]
public enum FEEJMENJLIJ
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
public enum CCBIIAGKKBF : byte
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
public delegate Task LOHABELNFDM(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KENBNKLNLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder OFLJODODJPE, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HGGHGJBADJJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool DIAGOLELDCI(MOMCOKAPMLC PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NPPIPBIPCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NPPIPBIPCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F2E0", Offset = "0x6A8DEE0", VA = "0x186A8F2E0")]
		internal Task NEGOGFAJGLO(MOMCOKAPMLC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JIOFCNFPLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<MOMCOKAPMLC> handler;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JIOFCNFPLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DEE0", Offset = "0x6A8CAE0", VA = "0x186A8DEE0")]
		internal Task NEGOGFAJGLO(MOMCOKAPMLC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HFJLKOLANPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CCBIIAGKKBF handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HGGHGJBADJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HFJLKOLANPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D4A0", Offset = "0x6A8C0A0", VA = "0x186A8D4A0")]
		internal object MKFJCGFHEGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<FEEJMENJLIJ, HashSet<(CCBIIAGKKBF, DIAGOLELDCI, LOHABELNFDM)>> MKFINEMLCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Guid BKCKIJFPBOM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DE20", Offset = "0x6A8CA20", VA = "0x186A8DE20")]
	public HGGHGJBADJJ(Guid LHPBOIAGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D550", Offset = "0x6A8C150", VA = "0x186A8D550")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, LOHABELNFDM NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D890", Offset = "0x6A8C490", VA = "0x186A8D890")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, Action NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D790", Offset = "0x6A8C390", VA = "0x186A8D790")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, Action<MOMCOKAPMLC> NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D990", Offset = "0x6A8C590", VA = "0x186A8D990")]
	public Dictionary<CCBIIAGKKBF, List<LOHABELNFDM>> EHPBHLHGOMO(FEEJMENJLIJ MJLJKGOPJKG, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum NFBLDIHAPOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum GEDJHDMKMOJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CKGIIPHAJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool GLCIMNDNDCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ANLNHDHAGKI : KLCBNDFEBHE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(CKGIIPHAJBG DIGHFJCKNAB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BBJHDNJAMLE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JBJLFLLGBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HHBHMKLOFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<HGGHGJBADJJ> EGAFFNAAALH();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JBKIEOAMFHJ(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
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
