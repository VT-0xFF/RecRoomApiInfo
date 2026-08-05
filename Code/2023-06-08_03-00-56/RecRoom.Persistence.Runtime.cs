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
public interface MOKMPNBLEGB : IBHGDJOOKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(IGGOJPONDHD CFCJGPIOLLG, PDONGDEAPNB JFPHAJKNJIC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct HAGEDOJDDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public IGGOJPONDHD CFCJGPIOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PDONGDEAPNB JFPHAJKNJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool NEEPJHOBIAD;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IOJGKLPHBED : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> OONPOKJIGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public NNIOLKIOJDO BLPNECDMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int HNPOGIOJMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 OONOMCGBMDN;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B14A60", Offset = "0x6B13860", VA = "0x186B14A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B14AB0", Offset = "0x6B138B0", VA = "0x186B14AB0")]
	public IOJGKLPHBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KOACMDNMBOI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IBHGDJOOKBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KOACMDNMBOI ALDLFMGGPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KPOHNOHMKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(HAGEDOJDDMO PFEKBFOBNKO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref PDONGDEAPNB JFPHAJKNJIC, ref IOJGKLPHBED LJJANIFMOLJ, StringBuilder FGEJGONKKIF);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class MLBCEGKGEBF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class MEJJCDMEJFJ<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : IBHGDJOOKBH
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
				private HashSet<IBHGDJOOKBH> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<IBHGDJOOKBH> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<IBHGDJOOKBH>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private IBHGDJOOKBH <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
				[DebuggerHidden]
				public MEJJCDMEJFJ(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2A2A010", Offset = "0x2A28E10", VA = "0x182A2A010", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3882AF0", Offset = "0x38818F0", VA = "0x183882AF0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3882A30", Offset = "0x3881830", VA = "0x183882A30")]
				private void KJLKGHHLDDO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3882DF0", Offset = "0x3881BF0", VA = "0x183882DF0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x3882D40", Offset = "0x3881B40", VA = "0x183882D40", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2AC0390", Offset = "0x2ABF190", VA = "0x182AC0390", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<IBHGDJOOKBH> OLOEIJDKKGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<IBHGDJOOKBH> CNNEFMJFJKM;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6B15910", Offset = "0x6B14710", VA = "0x186B15910")]
			public void JJHMNAOJCMD(KOACMDNMBOI CGMIFONBBEI, IBHGDJOOKBH IGKGDHEFIFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B15890", Offset = "0x6B14690", VA = "0x186B15890")]
			private static void CPPFEPEBKPA(ref HashSet<IBHGDJOOKBH> IGAKKONPCPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x321F530", Offset = "0x321E330", VA = "0x18321F530")]
			public IEnumerable<T> HCDIPJPDKMJ<T>(bool FNDJEGHHMAP) where T : IBHGDJOOKBH
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x233A7C0", Offset = "0x23395C0", VA = "0x18233A7C0")]
			[IteratorStateMachine(typeof(MEJJCDMEJFJ<>))]
			private static IEnumerable<T> BGEDBOEMMMM<T>(HashSet<IBHGDJOOKBH> IGAKKONPCPC) where T : IBHGDJOOKBH
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public MLBCEGKGEBF()
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
		public delegate void ACLKCGKEBED(Guid IOFFBFHGFOD, Guid ONPNEOGGFGK);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KLDIIOGPAPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public IPPLHIAFKMN serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public KLDIIOGPAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6B157B0", Offset = "0x6B145B0", VA = "0x186B157B0")]
			internal Task PPIHPOCGOKM(LNMFDCMJFEL comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HHFBKJIKELB : IAsyncStateMachine
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
			public IPPLHIAFKMN serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private KLDIIOGPAPC <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public HHFBKJIKELB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6B14420", Offset = "0x6B13220", VA = "0x186B14420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HJCHKMHMCDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public HJCHKMHMCDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6B14A30", Offset = "0x6B13830", VA = "0x186B14A30")]
			internal bool BLMAHCPHBMK(LIIKOGBNFMF d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> KMLBMDICHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool GBIKDHKIACP;

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
		private GICKDGBHLBJ<Guid> NEHBLFKOBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<IBHGDJOOKBH> BGDIFOCHCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<LNMFDCMJFEL> ODPJNGJEECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MLBCEGKGEBF NOLHAKONPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid PHPDEKDJNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid NCNAKIDJDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LHKDGCOKKGC CPFJALOBKJO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> GFDPOFOIOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A540", Offset = "0x6B19340", VA = "0x186B1A540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid JMLLMANMBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A170", Offset = "0x6B18F70", VA = "0x186B1A170")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A690", Offset = "0x6B19490", VA = "0x186B1A690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EEMCGMCBIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xEA1C40", Offset = "0xEA0A40", VA = "0x180EA1C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x11DE290", Offset = "0x11DD090", VA = "0x1811DE290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BBCFMFIKBIN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A290", Offset = "0x6B19090", VA = "0x186B1A290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool OCNFHFABDGB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6B17100", Offset = "0x6B15F00", VA = "0x186B17100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView DKDJBLOFNAC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x922C40", Offset = "0x921A40", VA = "0x180922C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DEOLFOFNOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A230", Offset = "0x6B19030", VA = "0x186B1A230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool HNEIODNCKDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6B16FD0", Offset = "0x6B15DD0", VA = "0x186B16FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ACLKCGKEBED PGMJMBOMKID
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A0D0", Offset = "0x6B18ED0", VA = "0x186B1A0D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A5F0", Offset = "0x6B193F0", VA = "0x186B1A5F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B15F60", Offset = "0x6B14D60", VA = "0x186B15F60", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B16610", Offset = "0x6B15410", VA = "0x186B16610")]
		private bool BAMHDKBFKBM(out Guid OBHOJGNLNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B18790", Offset = "0x6B17590", VA = "0x186B18790")]
		private bool PHIAANCMDAJ(out Guid OBHOJGNLNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B18780", Offset = "0x6B17580", VA = "0x186B18780")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B182E0", Offset = "0x6B170E0", VA = "0x186B182E0", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B17570", Offset = "0x6B16370", VA = "0x186B17570")]
		private void KJMKDDOPLLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B18780", Offset = "0x6B17580", VA = "0x186B18780")]
		private void OnMasterClientSwitched(LHGLKLFIDFM BLBBPGEKKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B181C0", Offset = "0x6B16FC0", VA = "0x186B181C0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B191A0", Offset = "0x6B17FA0", VA = "0x186B191A0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HHFBKJIKELB))]
		public Task PreSerializeAsync(StringBuilder FGEJGONKKIF, IPPLHIAFKMN FFFJLDNLOAN, CancellationToken KIMBGNGMOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B19330", Offset = "0x6B18130", VA = "0x186B19330")]
		public PDONGDEAPNB Serialize(ref IOJGKLPHBED LJJANIFMOLJ, StringBuilder FGEJGONKKIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B172C0", Offset = "0x6B160C0", VA = "0x186B172C0")]
		public void InitializeDeserialization(PDONGDEAPNB JFPHAJKNJIC, bool CDPGLCNDGFM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B18C70", Offset = "0x6B17A70", VA = "0x186B18C70")]
		public void PreDeserialize(bool FNDJEGHHMAP, IGGOJPONDHD CFCJGPIOLLG, PDONGDEAPNB JFPHAJKNJIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B16980", Offset = "0x6B15780", VA = "0x186B16980")]
		public void Deserialize(bool FNDJEGHHMAP, HAGEDOJDDMO PFEKBFOBNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B18810", Offset = "0x6B17610", VA = "0x186B18810")]
		public void PostDeserialize(bool FNDJEGHHMAP, LADEBOAIMJJ GCJJGHCGJPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B17B40", Offset = "0x6B16940", VA = "0x186B17B40")]
		private void MGKDOPHKPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B166F0", Offset = "0x6B154F0", VA = "0x186B166F0")]
		private PDONGDEAPNB BJCMGJFGLEP(PDONGDEAPNB MBBFNNPANGM, ChildViewReference IBGFFODDGJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6B180F0", Offset = "0x6B16EF0", VA = "0x186B180F0")]
		public void MarkExcludedFromRoomSave(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B19E00", Offset = "0x6B18C00", VA = "0x186B19E00")]
		public void UnmarkExcludedFromRoomSave(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B19FC0", Offset = "0x6B18DC0", VA = "0x186B19FC0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B18060", Offset = "0x6B16E60", VA = "0x186B18060")]
		[CompilerGenerated]
		private object MJLKIIABLAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B15E30", Offset = "0x6B14C30", VA = "0x186B15E30")]
		[CompilerGenerated]
		private object AFIDGMAJPEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B15EB0", Offset = "0x6B14CB0", VA = "0x186B15EB0")]
		[CompilerGenerated]
		private object AMBKLMCPCHE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class OKKEILOPOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private DFBGJGLBHBO FDBEJGMADJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, PDONGDEAPNB)> OAKGNALMLLC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public PKPIHKEIHHL BBEOPKLHAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public CFIBOHOJNNP BOBANCHPHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MAMGNGFOFNK ADEIMOGDDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IGGOJPONDHD BJIMBKCHPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x93D1F0", Offset = "0x93BFF0", VA = "0x18093D1F0")]
		[CompilerGenerated]
		get
		{
			return default(IGGOJPONDHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public FOHHNNEFOIN NHHNOGGHHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MCJJGOEJIBB AIEKHBCMKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OMAOIJIBHNJ FDHCAEEGNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EKIDOHCDJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD54BC0", Offset = "0xD539C0", VA = "0x180D54BC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B15D20", Offset = "0x6B14B20", VA = "0x186B15D20")]
	public OKKEILOPOEG(PKPIHKEIHHL OJDPPHDPCII, CFIBOHOJNNP CFNLBNAAJCI, MAMGNGFOFNK OKBOOIPGINA, IGGOJPONDHD CFCJGPIOLLG, bool JKAFACEAECO, FOHHNNEFOIN ODBMILJBDKN, MCJJGOEJIBB EANAFOJCGLK, OMAOIJIBHNJ HOCOIPICBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B15C90", Offset = "0x6B14A90", VA = "0x186B15C90")]
	public void ILCFHNKMKMN(DFBGJGLBHBO JHECHDKAGPH, List<(PersistenceView, PDONGDEAPNB)> JCLAJIFDAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B15CB0", Offset = "0x6B14AB0", VA = "0x186B15CB0")]
	public List<(PersistenceView, PDONGDEAPNB)> LEJFLOADOHN(DFBGJGLBHBO PMPMHMNHAIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BNJECIFLGII
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<DFBGJGLBHBO> BALBIAHOKKO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<DFBGJGLBHBO> MPDANEOLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B134F0", Offset = "0x6B122F0", VA = "0x186B134F0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class IPIHPDFCOPP : GNALIAMEBBF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum FHJPNMPMCJH
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
	private class DCJDEAMPFJI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly object CNBGAPJABKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly FFBOJCOGMOC GLKBAIGAHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Action<object> MFHKPMMIGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool BLMLHEIKNME;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA79760", Offset = "0xA78560", VA = "0x180A79760")]
		public DCJDEAMPFJI(object CNBGAPJABKP, FFBOJCOGMOC GLKBAIGAHCE, Action<object> MFHKPMMIGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B139D0", Offset = "0x6B127D0", VA = "0x186B139D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly Dictionary<object, FFBOJCOGMOC> OMAPMDJDLAE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BEEBPNDDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EENBONGPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B14B90", Offset = "0x6B13990", VA = "0x186B14B90")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.None)]
	private static void BALEBCFJGHH(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B14B30", Offset = "0x6B13930", VA = "0x186B14B30", Slot = "4")]
	public IReadOnlyList<FFBOJCOGMOC> ACIOINIBEEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B15030", Offset = "0x6B13E30", VA = "0x186B15030", Slot = "5")]
	public IDisposable KHGHBIGJDBD(object CNBGAPJABKP, FFBOJCOGMOC GLKBAIGAHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B14C80", Offset = "0x6B13A80", VA = "0x186B14C80")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void BAOEANAOILP(FFBOJCOGMOC GLKBAIGAHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B15370", Offset = "0x6B14170", VA = "0x186B15370")]
	private void MAGBBAHKBJF(object CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B15590", Offset = "0x6B14390", VA = "0x186B15590")]
	[FEBAOGJMMKM(AFFOKNEDPGH.Unity_AfterSceneLoad)]
	private static void NHBFJHPELCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6B14F00", Offset = "0x6B13D00", VA = "0x186B14F00")]
	internal static void GMKNPONLEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B14E70", Offset = "0x6B13C70", VA = "0x186B14E70")]
	internal void GKFBNEHEBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B15680", Offset = "0x6B14480", VA = "0x186B15680")]
	public IPIHPDFCOPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MLHHMJOLKCA
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CCMGJLPAMFP : IAsyncStateMachine
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
		public MLHHMJOLKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CCMGJLPAMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B137B0", Offset = "0x6B125B0", VA = "0x186B137B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float PBAIBFMEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly float JOMNDEOMCBH;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B15BE0", Offset = "0x6B149E0", VA = "0x186B15BE0")]
	public MLHHMJOLKCA(float JOMNDEOMCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B15A90", Offset = "0x6B14890", VA = "0x186B15A90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CCMGJLPAMFP))]
	public Task PDBKPACGOJH(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B15A70", Offset = "0x6B14870", VA = "0x186B15A70")]
	public void HKOMOLJGOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HNDAMPIPBKP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KOACMDNMBOI AFIBNPHCAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(FOHHNNEFOIN ODBMILJBDKN, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref FOHHNNEFOIN ODBMILJBDKN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[OGEPINIJGHJ]
public enum DFBGJGLBHBO
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
public enum CBOJMEGDIMJ : byte
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
public delegate Task CJFJOPJBFGM(OKKEILOPOEG DCPGFNKOIOA, CancellationToken KIMBGNGMOGB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LNMFDCMJFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder FGEJGONKKIF, IPPLHIAFKMN FFFJLDNLOAN, CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FFBOJCOGMOC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool KMOJCICIELD(OKKEILOPOEG FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OBKNFFHECPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OBKNFFHECPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B15C20", Offset = "0x6B14A20", VA = "0x186B15C20")]
		internal Task IMNHOHNPPBF(OKKEILOPOEG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ECAHBCBHFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<OKKEILOPOEG> handler;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ECAHBCBHFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6B13A30", Offset = "0x6B12830", VA = "0x186B13A30")]
		internal Task IMNHOHNPPBF(OKKEILOPOEG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KHPMNBPMEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CBOJMEGDIMJ handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FFBOJCOGMOC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KHPMNBPMEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6B15700", Offset = "0x6B14500", VA = "0x186B15700")]
		internal object PACCLEGBAAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<DFBGJGLBHBO, HashSet<(CBOJMEGDIMJ, KMOJCICIELD, CJFJOPJBFGM)>> DLAFMJAAFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Guid CCILGJENIKP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B14390", Offset = "0x6B13190", VA = "0x186B14390")]
	public FFBOJCOGMOC(Guid JMLEAAPBEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B14150", Offset = "0x6B12F50", VA = "0x186B14150")]
	public FFBOJCOGMOC BLHFPJOEBND(DFBGJGLBHBO OBALAOIHJBE, CBOJMEGDIMJ CGMIFONBBEI, CJFJOPJBFGM GLKBAIGAHCE, [Optional] KMOJCICIELD OHJDEPNNECL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B14050", Offset = "0x6B12E50", VA = "0x186B14050")]
	public FFBOJCOGMOC BLHFPJOEBND(DFBGJGLBHBO OBALAOIHJBE, CBOJMEGDIMJ CGMIFONBBEI, Action GLKBAIGAHCE, [Optional] KMOJCICIELD OHJDEPNNECL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B13F50", Offset = "0x6B12D50", VA = "0x186B13F50")]
	public FFBOJCOGMOC BLHFPJOEBND(DFBGJGLBHBO OBALAOIHJBE, CBOJMEGDIMJ CGMIFONBBEI, Action<OKKEILOPOEG> GLKBAIGAHCE, [Optional] KMOJCICIELD OHJDEPNNECL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B13AC0", Offset = "0x6B128C0", VA = "0x186B13AC0")]
	public Dictionary<CBOJMEGDIMJ, List<CJFJOPJBFGM>> AOJLIDHJIBP(DFBGJGLBHBO JHECHDKAGPH, OKKEILOPOEG FAJCHBCCGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum MKOEPIAGAPI
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum IPPLHIAFKMN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LADEBOAIMJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool NEEPJHOBIAD;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JFJPODNNFBG : IBHGDJOOKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(LADEBOAIMJJ GCJJGHCGJPP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GNALIAMEBBF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BEEBPNDDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EENBONGPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<FFBOJCOGMOC> ACIOINIBEEO();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KHGHBIGJDBD(object CNBGAPJABKP, FFBOJCOGMOC GLKBAIGAHCE);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
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
