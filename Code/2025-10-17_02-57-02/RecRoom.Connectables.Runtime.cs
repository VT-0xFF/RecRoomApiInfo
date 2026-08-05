using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Creation;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using UJect;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84254F0", Offset = "0x8423AF0", VA = "0x1884254F0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] TPUBNGGXPOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] TPZIKNAUYZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EHSYFWCIGXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset EHNRIPIKXLW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x241FAE0", Offset = "0x241E0E0", VA = "0x18241FAE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8430A10", Offset = "0x842F010", VA = "0x188430A10")]
		private void UAFZRFJIDZJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84308C0", Offset = "0x842EEC0", VA = "0x1884308C0")]
		private void UAASTYPKUOA(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84305B0", Offset = "0x842EBB0", VA = "0x1884305B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8430B60", Offset = "0x842F160", VA = "0x188430B60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : IYUZSJHVLHY, SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class HVBCSQFGBCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public FQFDPGEIZCW DKUNIEECJGM;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HVBCSQFGBCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x841CD30", Offset = "0x841B330", VA = "0x18841CD30")]
			internal object AQSCVFQIJDF(FQFDPGEIZCW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HVGJPWZDKNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FQFDPGEIZCW TZQGCGQKEUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HVBCSQFGBCE GOOXOIYUWOV;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HVGJPWZDKNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x841CDA0", Offset = "0x841B3A0", VA = "0x18841CDA0")]
			internal object AQMVXYWKZRW((FQFDPGEIZCW child, FQFDPGEIZCW nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IOPAYPFPFHR : IEnumerable<ANXSKXJOXKD>, IEnumerable, IEnumerator<ANXSKXJOXKD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private ANXSKXJOXKD MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId TSSXXUXHJDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId SPOXZKQNAPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private SAOUEARSLXZ TIILWNKGDFV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray CBJCACTWYOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator TPQCIIMKDYS;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private ANXSKXJOXKD PIOZHKDZUCV
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public IOPAYPFPFHR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x841D180", Offset = "0x841B780", VA = "0x18841D180", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x841D350", Offset = "0x841B950", VA = "0x18841D350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x841D280", Offset = "0x841B880", VA = "0x18841D280")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x841D260", Offset = "0x841B860", VA = "0x18841D260")]
			private void KOSXCWUKUNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x841D6B0", Offset = "0x841BCB0", VA = "0x18841D6B0", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x841D2A0", Offset = "0x841B8A0", VA = "0x18841D2A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ANXSKXJOXKD> NPKGQJFZEXE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x841D2A0", Offset = "0x841B8A0", VA = "0x18841D2A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log ZYBIMECSFML;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log DIUPKPCBTCD;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log UXPOPFMRRNZ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log DGFDGSJFHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JKRXTVWXZLM TGGQVFOGIYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MMTRKLJTBTD SEZQIJPYBYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private YCOHKLSVTYA KAOJGLZBVJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ORRNDJSZCQS FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private KOGIUQPMNTM LRBRACHFOFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PKCVCCBDLWS AOGCKUOFZYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly EDAGNEPUCRN GNUBXCTIWEI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool SHXMMQDRCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAB3040", Offset = "0xAB1640", VA = "0x180AB3040", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB31B0", Offset = "0xAB17B0", VA = "0x180AB31B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CEEBLTCKQCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD> MMZGUMYNXSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84276A0", Offset = "0x8425CA0", VA = "0x1884276A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8428290", Offset = "0x8426890", VA = "0x188428290", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD> RKYIODIFUXW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8429BC0", Offset = "0x84281C0", VA = "0x188429BC0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8427540", Offset = "0x8425B40", VA = "0x188427540", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD, ANXSKXJOXKD> FOUQOVHKLSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8428500", Offset = "0x8426B00", VA = "0x188428500", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84275F0", Offset = "0x8425BF0", VA = "0x1884275F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x842A420", Offset = "0x8428A20", VA = "0x18842A420")]
		public OMConnectableManager(KUXAUVMITFU container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84279E0", Offset = "0x8425FE0", VA = "0x1884279E0", Slot = "12")]
		public void Initialize(GameObject gameObject, WHHPBCDDRYV configData, MTYZNGYCSFU sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8427810", Offset = "0x8425E10", VA = "0x188427810", Slot = "26")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84277C0", Offset = "0x8425DC0", VA = "0x1884277C0", Slot = "22")]
		public bool HSLBWHYKJCI(FQFDPGEIZCW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8426500", Offset = "0x8424B00", VA = "0x188426500")]
		private void CGCBVYGWTJX(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84260E0", Offset = "0x84246E0", VA = "0x1884260E0")]
		private void CCIRJPZIWHV(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8429F80", Offset = "0x8428580", VA = "0x188429F80")]
		private void ZOTWOEVQUNP(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84297B0", Offset = "0x8427DB0", VA = "0x1884297B0")]
		private void WWYGZDMYJEW(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8427E40", Offset = "0x8426440", VA = "0x188427E40", Slot = "14")]
		public void KQPXXDZDTRT(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "15")]
		public void VJDYMFSHNXM(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8429DB0", Offset = "0x84283B0", VA = "0x188429DB0", Slot = "17")]
		public void YJWIYJPSOFD(ANXSKXJOXKD a, ANXSKXJOXKD b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8429C70", Offset = "0x8428270", VA = "0x188429C70")]
		public void YJWIYJPSOFD(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8426F30", Offset = "0x8425530", VA = "0x188426F30")]
		public void DKTVQURPEHR(ANXSKXJOXKD a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8429380", Offset = "0x8427980", VA = "0x188429380", Slot = "18")]
		public void VYTWLKUAXHB(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84292D0", Offset = "0x84278D0", VA = "0x1884292D0")]
		private float VCRUJPZGVTP(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84294E0", Offset = "0x8427AE0", VA = "0x1884294E0")]
		public void VYTWLKUAXHB(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8428830", Offset = "0x8426E30", VA = "0x188428830", Slot = "19")]
		public void RRNXYEZDZQL(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8426300", Offset = "0x8424900", VA = "0x188426300", Slot = "16")]
		public void CEJVDLBMSGN(ANXSKXJOXKD a, HashSet<ANXSKXJOXKD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "20")]
		public ConnectableGraphData MRTJIVBIYBE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "21")]
		public ConnectableGraphData IKBBBHIUOYW(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8429F10", Offset = "0x8428510", VA = "0x188429F10", Slot = "23")]
		public void YZQIGNOVVQH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8427C50", Offset = "0x8426250", VA = "0x188427C50", Slot = "24")]
		public void JVWAVTBGIDV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8428140", Offset = "0x8426740", VA = "0x188428140", Slot = "25")]
		public void KVIDWKTYOJO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84269A0", Offset = "0x8424FA0", VA = "0x1884269A0")]
		private void DFGCGDYZMRF(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84289A0", Offset = "0x8426FA0", VA = "0x1884289A0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8427750", Offset = "0x8425D50", VA = "0x188427750")]
		private void GQRVDAWNAQM(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8428160", Offset = "0x8426760", VA = "0x188428160")]
		[IteratorStateMachine(typeof(IOPAYPFPFHR))]
		public IEnumerable<ANXSKXJOXKD> KVNAFOAJAJP(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8425FB0", Offset = "0x84245B0", VA = "0x188425FB0")]
		internal ANXSKXJOXKD BYSYSQLXXNY(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8426DA0", Offset = "0x84253A0", VA = "0x188426DA0")]
		internal ObjectLocalId DJKRIPJPWDE(ANXSKXJOXKD a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8426FC0", Offset = "0x84255C0", VA = "0x188426FC0")]
		private bool EWHEWNJQJJB(FQFDPGEIZCW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8428230", Offset = "0x8426830", VA = "0x188428230")]
		private bool MNYZJURYGTV(FQFDPGEIZCW a, [Out] ANXSKXJOXKD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8425C30", Offset = "0x8424230", VA = "0x188425C30")]
		private ANXSKXJOXKD BYSYSQLXXNY(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8427CC0", Offset = "0x84262C0", VA = "0x188427CC0")]
		private ANXSKXJOXKD KBZTQDOQAMD(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8428340", Offset = "0x8426940", VA = "0x188428340")]
		private ANXSKXJOXKD PSRQZQRUIYY(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84281F0", Offset = "0x84267F0", VA = "0x1884281F0")]
		private static Guid MHAGUALYEMF(FQFDPGEIZCW a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x842A1E0", Offset = "0x84287E0", VA = "0x18842A1E0")]
		private string ZPBGMIEGNZK(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8425AA0", Offset = "0x84240A0", VA = "0x188425AA0")]
		private void AIAFSOLVXUT(ANXSKXJOXKD a, ANXSKXJOXKD b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8426810", Offset = "0x8424E10", VA = "0x188426810")]
		private void CTZEYQBBXRL(ANXSKXJOXKD a, ANXSKXJOXKD b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8429270", Offset = "0x8427870", VA = "0x188429270")]
		private void TOFWTKQKMBV(ANXSKXJOXKD a, ANXSKXJOXKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8429620", Offset = "0x8427C20", VA = "0x188429620")]
		private void WFYBDZTFMQS(ANXSKXJOXKD a, ANXSKXJOXKD b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8426700", Offset = "0x8424D00", VA = "0x188426700")]
		private void CKKFJETTDUL(ObjectLocalId a, ANXSKXJOXKD b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84285B0", Offset = "0x8426BB0", VA = "0x1884285B0")]
		private void RFMCFQTXPAU(ObjectLocalId a, ANXSKXJOXKD b, ANXSKXJOXKD c, ANXSKXJOXKD d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RSGHRKEXZVD
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KUXAUVMITFU container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x842FA00", Offset = "0x842E000", VA = "0x18842FA00")]
			internal OMConnectableManager ZRYTXKUNLMH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x842F830", Offset = "0x842DE30", VA = "0x18842F830")]
		public static void XOCVBNBEMBJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x842F7E0", Offset = "0x842DDE0", VA = "0x18842F7E0")]
		public static void OUHJAJHBLYI(KUXAUVMITFU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : CIDCKIWZCOT, UCHAHIAAAQO
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager QKYRSAEFWNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BULVVLMAXPL HDJZVPBLJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly EKEQREWBCIX FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly WOAKKMLCWYD[] TDHXFZFXEDZ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ANXSKXJOXKD ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x842C000", Offset = "0x842A600", VA = "0x18842C000", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ANXSKXJOXKD WVCXKXIOHZE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x842BBF0", Offset = "0x842A1F0", VA = "0x18842BBF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 UOJDGWQRXPE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x842B620", Offset = "0x8429C20", VA = "0x18842B620", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion CDAOPBVIDST
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x842AE20", Offset = "0x8429420", VA = "0x18842AE20", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BSNAMMWPEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x842AF00", Offset = "0x8429500", VA = "0x18842AF00", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<ANXSKXJOXKD> ECTGYSLHESA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x842AE80", Offset = "0x8429480", VA = "0x18842AE80", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool AIJKZNAEOOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xE0B300", Offset = "0xE09900", VA = "0x180E0B300", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xEEF8C0", Offset = "0xEEDEC0", VA = "0x180EEF8C0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x842C200", Offset = "0x842A800", VA = "0x18842C200", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x842BF20", Offset = "0x842A520", VA = "0x18842BF20", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x842BF40", Offset = "0x842A540", VA = "0x18842BF40", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x842C060", Offset = "0x842A660", VA = "0x18842C060", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x842C140", Offset = "0x842A740", VA = "0x18842C140", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool TLRCQRCHQIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x842AF70", Offset = "0x8429570", VA = "0x18842AF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler RHBLSCXBPRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x842AB80", Offset = "0x8429180", VA = "0x18842AB80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x842A510", Offset = "0x8428B10", VA = "0x18842A510", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler WLMMOAUGMYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x842A490", Offset = "0x8428A90", VA = "0x18842A490", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x842A560", Offset = "0x8428B60", VA = "0x18842A560", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler RESQXZKTGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x842B580", Offset = "0x8429B80", VA = "0x18842B580", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x842AEB0", Offset = "0x84294B0", VA = "0x18842AEB0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler HBAEDKFQPSM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x842BCB0", Offset = "0x842A2B0", VA = "0x18842BCB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x842AFC0", Offset = "0x84295C0", VA = "0x18842AFC0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x842BE20", Offset = "0x842A420", VA = "0x18842BE20")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, BULVVLMAXPL connectableTool, WOAKKMLCWYD[] connectionPoints, EKEQREWBCIX callbacks, IYUZSJHVLHY connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x842A4E0", Offset = "0x8428AE0", VA = "0x18842A4E0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "21")]
		public void OMNNZKBVTPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x811BE10", Offset = "0x811A410", VA = "0x18811BE10", Slot = "22")]
		public void NTCXREKZWIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x842B5D0", Offset = "0x8429BD0", VA = "0x18842B5D0", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x842B9E0", Offset = "0x8429FE0", VA = "0x18842B9E0", Slot = "25")]
		public void VXXGEQJVQLA(int a, ANXSKXJOXKD b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x842A5B0", Offset = "0x8428BB0", VA = "0x18842A5B0", Slot = "26")]
		public void CCUDUAYVYFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x842B680", Offset = "0x8429C80", VA = "0x18842B680", Slot = "27")]
		public void TPESLOQTBKM(int a, ANXSKXJOXKD b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x842B960", Offset = "0x8429F60", VA = "0x18842B960", Slot = "28")]
		public void UWNRPTTMCXA(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x842A680", Offset = "0x8428C80", VA = "0x18842A680", Slot = "31")]
		public void CZADWVKHSCX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x842B060", Offset = "0x8429660", VA = "0x18842B060", Slot = "29")]
		public void PRQTWMAEYFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x842B370", Offset = "0x8429970", VA = "0x18842B370", Slot = "30")]
		public void RYCMNVPWEBM(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x842AD50", Offset = "0x8429350", VA = "0x18842AD50", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x842AC20", Offset = "0x8429220", VA = "0x18842AC20", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB6B220", Offset = "0xB69820", VA = "0x180B6B220", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x842AA90", Offset = "0x8429090", VA = "0x18842AA90", Slot = "43")]
		public bool CanConnectTo(int slotIndex, ANXSKXJOXKD otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "44")]
		public void ParentChanged(int slotIndex, ANXSKXJOXKD newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "45")]
		public void ChildAdded(int slotIndex, ANXSKXJOXKD newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "46")]
		public void ChildRemoved(int slotIndex, ANXSKXJOXKD removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "47")]
		public void ConnectionModified(int slotIndex, ANXSKXJOXKD parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x842B560", Offset = "0x8429B60", VA = "0x18842B560", Slot = "48")]
		public void RootChanged(ANXSKXJOXKD previousRootConnectable, ANXSKXJOXKD newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x842ABD0", Offset = "0x84291D0", VA = "0x18842ABD0", Slot = "23")]
		public void FSFOLXLSBTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x842AB30", Offset = "0x8429130", VA = "0x18842AB30", Slot = "24")]
		public void EDRANYUFCPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x842BD50", Offset = "0x842A350", VA = "0x18842BD50")]
		private void XOWSYPBXXOR(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(ZPIAUVNCNBQ), new string[] { })]
	public class ODCZZKPXSQL : ZPIAUVNCNBQ, GIIGMTDPOEP, SWFXCOYYPIH
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class RPGDRVSGBNA
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPGDRVSGBNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private UVGKJNAZQHQ FWGLOYCYIPP;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object JTLROBRFNZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84259A0", Offset = "0x8423FA0", VA = "0x1884259A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8425950", Offset = "0x8423F50", VA = "0x188425950", Slot = "5")]
		private void KPEUJIHXKXR(XRIYJCZWKCD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xFCB320", Offset = "0xFC9920", VA = "0x180FCB320", Slot = "6")]
		private void WCDWJAGTXKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ODCZZKPXSQL()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(IYUZSJHVLHY), new string[] { "Ignore", "Mock" })]
	public class PDOXJXGDDMX : IYUZSJHVLHY, SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool SHXMMQDRCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CEEBLTCKQCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD> MMZGUMYNXSK
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x842C380", Offset = "0x842A980", VA = "0x18842C380", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x842C430", Offset = "0x842AA30", VA = "0x18842C430", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD> RKYIODIFUXW
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x842C590", Offset = "0x842AB90", VA = "0x18842C590", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x842C220", Offset = "0x842A820", VA = "0x18842C220", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD, ANXSKXJOXKD> FOUQOVHKLSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x842C4E0", Offset = "0x842AAE0", VA = "0x18842C4E0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x842C2D0", Offset = "0x842A8D0", VA = "0x18842C2D0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "26")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "12")]
		public void Initialize(GameObject gameObject, WHHPBCDDRYV configData, MTYZNGYCSFU rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "14")]
		public void KQPXXDZDTRT(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "15")]
		public void VJDYMFSHNXM(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "16")]
		public void CEJVDLBMSGN(ANXSKXJOXKD a, HashSet<ANXSKXJOXKD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "17")]
		public void YJWIYJPSOFD(ANXSKXJOXKD a, ANXSKXJOXKD b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "18")]
		public void VYTWLKUAXHB(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "19")]
		public void RRNXYEZDZQL(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "20")]
		public ConnectableGraphData MRTJIVBIYBE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "21")]
		public ConnectableGraphData IKBBBHIUOYW(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "22")]
		public bool HSLBWHYKJCI(FQFDPGEIZCW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "23")]
		public void YZQIGNOVVQH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "24")]
		public void JVWAVTBGIDV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "25")]
		public void KVIDWKTYOJO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PDOXJXGDDMX()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ANXSKXJOXKD : UCHAHIAAAQO, IEquatable<ANXSKXJOXKD>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface UCHAHIAAAQO
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		ANXSKXJOXKD ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Vector3 GetConnectionSlotLocalPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Vector3 GetConnectionSlotPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Color GetConnectionSlotColor(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool CanConnectTo(int slotIndex, ANXSKXJOXKD otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, ANXSKXJOXKD newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, ANXSKXJOXKD newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, ANXSKXJOXKD removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, ANXSKXJOXKD parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(ANXSKXJOXKD previousRootConnectable, ANXSKXJOXKD newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IYUZSJHVLHY : SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool SHXMMQDRCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool CEEBLTCKQCT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<ANXSKXJOXKD, ANXSKXJOXKD> MMZGUMYNXSK;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<ANXSKXJOXKD, ANXSKXJOXKD> RKYIODIFUXW;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<ANXSKXJOXKD, ANXSKXJOXKD, ANXSKXJOXKD> FOUQOVHKLSQ;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, WHHPBCDDRYV configData, MTYZNGYCSFU rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KQPXXDZDTRT(ANXSKXJOXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void VJDYMFSHNXM(ANXSKXJOXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void CEJVDLBMSGN(ANXSKXJOXKD a, HashSet<ANXSKXJOXKD> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void YJWIYJPSOFD(ANXSKXJOXKD a, ANXSKXJOXKD b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void VYTWLKUAXHB(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void RRNXYEZDZQL(ANXSKXJOXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData MRTJIVBIYBE(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData IKBBBHIUOYW(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool HSLBWHYKJCI(FQFDPGEIZCW a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void YZQIGNOVVQH(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void JVWAVTBGIDV(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void KVIDWKTYOJO(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ORRNDJSZCQS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ANXSKXJOXKD PSRQZQRUIYY(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ANXSKXJOXKD KBZTQDOQAMD(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool APORDSGBNGD(ANXSKXJOXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool QLGLWGUNYWB();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FCQSZQOODQC(ANXSKXJOXKD a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface EKEQREWBCIX
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TLRCQRCHQIN(BULVVLMAXPL a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AQWNGFRGBRG(BULVVLMAXPL a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string FQQGDXQMNRB(BULVVLMAXPL a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid XBEGXDJRJZI(BULVVLMAXPL a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int NXXPVGXOYIP(BULVVLMAXPL a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IBEZMBEPSRA(BULVVLMAXPL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(ANXSKXJOXKD childConnectable, int childConnectableSlot, ANXSKXJOXKD parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(ANXSKXJOXKD previousRootConnectable, ANXSKXJOXKD newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BULVVLMAXPL : ANXSKXJOXKD, UCHAHIAAAQO, IEquatable<ANXSKXJOXKD>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface CIDCKIWZCOT : UCHAHIAAAQO
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ANXSKXJOXKD WVCXKXIOHZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<ANXSKXJOXKD> ECTGYSLHESA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 UOJDGWQRXPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion CDAOPBVIDST
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool BSNAMMWPEDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool AIJKZNAEOOY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler RHBLSCXBPRO;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler WLMMOAUGMYG;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler RESQXZKTGKJ;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler HBAEDKFQPSM;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void OMNNZKBVTPU();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void NTCXREKZWIT();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void FSFOLXLSBTO();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void EDRANYUFCPR();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void VXXGEQJVQLA(int a, ANXSKXJOXKD b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void CCUDUAYVYFI();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void TPESLOQTBKM(int a, ANXSKXJOXKD b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void UWNRPTTMCXA(ANXSKXJOXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void PRQTWMAEYFL();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void RYCMNVPWEBM(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void CZADWVKHSCX(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface WOAKKMLCWYD
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 MFJIVFKPZVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface WHHPBCDDRYV
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool VOHKHJZHPSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		GZDQTYVWKZY JMNIRQQHWWF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, WHHPBCDDRYV
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VOHKHJZHPSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public GZDQTYVWKZY JMNIRQQHWWF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x841BC50", Offset = "0x841A250", VA = "0x18841BC50")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x841BD10", Offset = "0x841A310", VA = "0x18841BD10")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ANXSKXJOXKD connectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int slot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int parentSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x841C250", Offset = "0x841A850", VA = "0x18841C250")]
		public ConnectableLink(ANXSKXJOXKD connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x841C2B0", Offset = "0x841A8B0", VA = "0x18841C2B0")]
		public ConnectableLink(ANXSKXJOXKD connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x841C1D0", Offset = "0x841A7D0", VA = "0x18841C1D0")]
		public ConnectableLink(ANXSKXJOXKD connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x841BD60", Offset = "0x841A360", VA = "0x18841BD60", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x841BE10", Offset = "0x841A410", VA = "0x18841BE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : YRWZPEXZHAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform FXOQWRPSRBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private GZDQTYVWKZY QKAPOWUEFLE;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5C40", Offset = "0x7DA4240", VA = "0x187DA5C40", Slot = "4")]
		public void Initialize(Transform transform, GZDQTYVWKZY linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x841E700", Offset = "0x841CD00", VA = "0x18841E700", Slot = "5")]
		public GZDQTYVWKZY SSPFZVMNSQA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x841E7C0", Offset = "0x841CDC0", VA = "0x18841E7C0", Slot = "6")]
		public void UVZPMDQKLRI(GZDQTYVWKZY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, THTPORARMYO
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NQOOHRFIIQZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public ANXSKXJOXKD QJYYSXFTQQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public ANXSKXJOXKD JGDSGSFKSZG;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NQOOHRFIIQZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x84257C0", Offset = "0x8423DC0", VA = "0x1884257C0")]
			internal bool IDXOWXCQPXU(FPKNGWWHESN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly QNWPFZVDILA GOOYRFNSXMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private KQOXGPHVGNH HFQACDMDZIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EQRJJATWTPZ XYCDJVVMZAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool WMEUXPJFUSL;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log QOSAXABVCBT;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public FPKNGWWHESN KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8420180", Offset = "0x841E780", VA = "0x188420180")]
		public bool TESFOKCASOH([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x841FBD0", Offset = "0x841E1D0", VA = "0x18841FBD0")]
		private bool FBIIFFNPNSK([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84224A0", Offset = "0x8420AA0", VA = "0x1884224A0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8420BF0", Offset = "0x841F1F0", VA = "0x188420BF0", Slot = "5")]
		public void Initialize(IYUZSJHVLHY manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8421650", Offset = "0x841FC50", VA = "0x188421650", Slot = "17")]
		public void OYJYBRGKFJM(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8420190", Offset = "0x841E790", VA = "0x188420190", Slot = "12")]
		public void GJGYMXSRXJP(Func<ANXSKXJOXKD, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x84201A0", Offset = "0x841E7A0", VA = "0x1884201A0")]
		private void GJGYMXSRXJP(QNWPFZVDILA a, Func<ANXSKXJOXKD, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8421680", Offset = "0x841FC80", VA = "0x188421680", Slot = "11")]
		public void OZTPJQRUMQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8421E40", Offset = "0x8420440", VA = "0x188421E40", Slot = "8")]
		public bool WOGVJPSKKWK(ANXSKXJOXKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8420310", Offset = "0x841E910", VA = "0x188420310")]
		private bool IGBOTKPBPZJ(ANXSKXJOXKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8421870", Offset = "0x841FE70", VA = "0x188421870")]
		private static bool RPWIWLBKRQJ(ANXSKXJOXKD a, QNWPFZVDILA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8420D70", Offset = "0x841F370", VA = "0x188420D70")]
		private void JLTTACEUFWZ(Transform a, QNWPFZVDILA b, QNWPFZVDILA[] c, ANXSKXJOXKD d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8421150", Offset = "0x841F750", VA = "0x188421150")]
		private ConnectableLink JTAETCLOSWE(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8420900", Offset = "0x841EF00", VA = "0x188420900")]
		private static bool IMZNDFEXMCL(QNWPFZVDILA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x841F230", Offset = "0x841D830", VA = "0x18841F230", Slot = "9")]
		public bool BNKKCHZEQFQ(ANXSKXJOXKD a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x841F920", Offset = "0x841DF20", VA = "0x18841F920")]
		private bool DJHOFMQDKAP(ANXSKXJOXKD a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x841F740", Offset = "0x841DD40", VA = "0x18841F740")]
		private static void DBHBCEIYGSS(ANXSKXJOXKD a, int b, int c, Vector3 d, Quaternion e, QNWPFZVDILA f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x841F110", Offset = "0x841D710", VA = "0x18841F110")]
		private void AIAFSOLVXUT(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8421DD0", Offset = "0x84203D0", VA = "0x188421DD0")]
		private void VZZQYXOAUPZ(QNWPFZVDILA a, ANXSKXJOXKD b, ANXSKXJOXKD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8421D60", Offset = "0x8420360", VA = "0x188421D60")]
		private void VZZQYXOAUPZ(ANXSKXJOXKD a, ANXSKXJOXKD b, ANXSKXJOXKD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8421800", Offset = "0x841FE00", VA = "0x188421800")]
		private void RFMCFQTXPAU(ANXSKXJOXKD a, ANXSKXJOXKD b, ANXSKXJOXKD c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8421700", Offset = "0x841FD00", VA = "0x188421700")]
		private void RFMCFQTXPAU(QNWPFZVDILA a, ANXSKXJOXKD b, ANXSKXJOXKD c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x841F620", Offset = "0x841DC20", VA = "0x18841F620")]
		private void CTZEYQBBXRL(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8421A30", Offset = "0x8420030", VA = "0x188421A30")]
		private void TOFWTKQKMBV(FPKNGWWHESN a, FPKNGWWHESN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8421C00", Offset = "0x8420200", VA = "0x188421C00", Slot = "18")]
		public ANXSKXJOXKD UAJGBMMQAOS(ANXSKXJOXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x841F290", Offset = "0x841D890", VA = "0x18841F290", Slot = "13")]
		public void CEJVDLBMSGN(ANXSKXJOXKD a, HashSet<ANXSKXJOXKD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8421410", Offset = "0x841FA10", VA = "0x188421410", Slot = "14")]
		public List<ANXSKXJOXKD> NUMNHHHZPGZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8420CA0", Offset = "0x841F2A0", VA = "0x188420CA0")]
		protected FPKNGWWHESN JIKVLBBHFMW(FPKNGWWHESN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x84212A0", Offset = "0x841F8A0", VA = "0x1884212A0")]
		protected QNWPFZVDILA[] LQUPSEYKCLB(QNWPFZVDILA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8421920", Offset = "0x841FF20", VA = "0x188421920")]
		protected bool THDNZUTHXTY(ANXSKXJOXKD a, [Out] QNWPFZVDILA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8420AC0", Offset = "0x841F0C0", VA = "0x188420AC0", Slot = "15")]
		public bool ITBZLHWGLMC(ANXSKXJOXKD a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x84202D0", Offset = "0x841E8D0", VA = "0x1884202D0")]
		protected QNWPFZVDILA GTAYRUSLFBN(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84216A0", Offset = "0x841FCA0", VA = "0x1884216A0", Slot = "10")]
		public bool PKKYFVWSMZU(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8421E50", Offset = "0x8420450", VA = "0x188421E50")]
		private bool XRUHIHEAXND(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8421340", Offset = "0x841F940", VA = "0x188421340")]
		private static bool NBTSMVUKLRB(QNWPFZVDILA a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8420180", Offset = "0x841E780", VA = "0x188420180", Slot = "7")]
		private bool FNBVMBWPJHA([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : IYUZSJHVLHY, SPJAMBOPKUB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly KUXAUVMITFU container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly EQRJJATWTPZ XYCDJVVMZAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly EVPFDFGWMAI LGRICOHZUDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly QTTCTOUVABI BIMCGNBMIVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly THTPORARMYO XCAFKBXXMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal XMVEHAEIFKP FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal YSCDIFLZLEA IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal KQOXGPHVGNH BBLNEJBWSOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool WMEUXPJFUSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool QIAEKZYRACA;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool WYXIWUTNPBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAF2330", Offset = "0xAF0930", VA = "0x180AF2330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAF1E30", Offset = "0xAF0430", VA = "0x180AF1E30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool SHXMMQDRCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xB9A670", Offset = "0xB98C70", VA = "0x180B9A670", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xB9A650", Offset = "0xB98C50", VA = "0x180B9A650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CEEBLTCKQCT
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD> MMZGUMYNXSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8422860", Offset = "0x8420E60", VA = "0x188422860", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x84238A0", Offset = "0x8421EA0", VA = "0x1884238A0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD> RKYIODIFUXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8423FD0", Offset = "0x84225D0", VA = "0x188423FD0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x84227A0", Offset = "0x8420DA0", VA = "0x1884227A0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<ANXSKXJOXKD, ANXSKXJOXKD, ANXSKXJOXKD> FOUQOVHKLSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8423AE0", Offset = "0x84220E0", VA = "0x188423AE0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8422800", Offset = "0x8420E00", VA = "0x188422800", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x84242D0", Offset = "0x84228D0", VA = "0x1884242D0")]
		public LegacyConnectableManager(KUXAUVMITFU container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8423050", Offset = "0x8421650", VA = "0x188423050", Slot = "12")]
		public void Initialize(GameObject gameObject, WHHPBCDDRYV configData, MTYZNGYCSFU rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8422F80", Offset = "0x8421580", VA = "0x188422F80", Slot = "26")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8423D00", Offset = "0x8422300", VA = "0x188423D00", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84236C0", Offset = "0x8421CC0", VA = "0x1884236C0", Slot = "14")]
		public void KQPXXDZDTRT(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8422740", Offset = "0x8420D40", VA = "0x188422740", Slot = "15")]
		public void VJDYMFSHNXM(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8422C60", Offset = "0x8421260", VA = "0x188422C60", Slot = "22")]
		public bool HSLBWHYKJCI(FQFDPGEIZCW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8423EC0", Offset = "0x84224C0", VA = "0x188423EC0")]
		internal bool XRUHIHEAXND([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8422B10", Offset = "0x8421110", VA = "0x188422B10")]
		internal bool GUNUCRUKXZZ([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8423900", Offset = "0x8421F00", VA = "0x188423900")]
		internal void PLZEKKMMCZZ(ANXSKXJOXKD a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8422740", Offset = "0x8420D40", VA = "0x188422740")]
		internal bool EMUXIUTJHYL(ANXSKXJOXKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8422CB0", Offset = "0x84212B0", VA = "0x188422CB0")]
		internal bool HZULXWIOIZH(ANXSKXJOXKD a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8422650", Offset = "0x8420C50", VA = "0x188422650", Slot = "16")]
		public void CEJVDLBMSGN(ANXSKXJOXKD a, HashSet<ANXSKXJOXKD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8424030", Offset = "0x8422630", VA = "0x188424030", Slot = "17")]
		public void YJWIYJPSOFD(ANXSKXJOXKD a, ANXSKXJOXKD b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8423D80", Offset = "0x8422380", VA = "0x188423D80", Slot = "18")]
		public void VYTWLKUAXHB(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8423B40", Offset = "0x8422140", VA = "0x188423B40", Slot = "19")]
		public void RRNXYEZDZQL(ANXSKXJOXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x84228C0", Offset = "0x8420EC0", VA = "0x1884228C0")]
		public void GQMGIPHZQBI([Optional] LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8424240", Offset = "0x8422840", VA = "0x188424240", Slot = "23")]
		public void YZQIGNOVVQH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8423720", Offset = "0x8421D20", VA = "0x188423720", Slot = "20")]
		public ConnectableGraphData MRTJIVBIYBE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8422DE0", Offset = "0x84213E0", VA = "0x188422DE0", Slot = "21")]
		public ConnectableGraphData IKBBBHIUOYW(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x84236E0", Offset = "0x8421CE0", VA = "0x1884236E0", Slot = "25")]
		public void KVIDWKTYOJO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8423610", Offset = "0x8421C10", VA = "0x188423610", Slot = "24")]
		public void JVWAVTBGIDV(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class EQRJJATWTPZ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly YPLZGKACCUI<ANXSKXJOXKD, ANXSKXJOXKD> MMZGUMYNXSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly YPLZGKACCUI<ANXSKXJOXKD, ANXSKXJOXKD> RKYIODIFUXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly YPRGDQTZMFR<ANXSKXJOXKD, ANXSKXJOXKD, ANXSKXJOXKD> FOUQOVHKLSQ;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x841C5D0", Offset = "0x841ABD0", VA = "0x18841C5D0")]
		public EQRJJATWTPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x841C510", Offset = "0x841AB10", VA = "0x18841C510")]
		public void OAYRBFMERFU(ANXSKXJOXKD a, ANXSKXJOXKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x841C570", Offset = "0x841AB70", VA = "0x18841C570")]
		public void SNTHHDYZTBO(ANXSKXJOXKD a, ANXSKXJOXKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x841C490", Offset = "0x841AA90", VA = "0x18841C490")]
		public void IZLZMBSLCRO(ANXSKXJOXKD a, ANXSKXJOXKD b, ANXSKXJOXKD c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class EVPFDFGWMAI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager TKPCNEHSYAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YSCDIFLZLEA IXSJEENOFTA;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public EVPFDFGWMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x841C6E0", Offset = "0x841ACE0", VA = "0x18841C6E0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x841C6D0", Offset = "0x841ACD0", VA = "0x18841C6D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x841CA80", Offset = "0x841B080", VA = "0x18841CA80")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x841CA10", Offset = "0x841B010", VA = "0x18841CA10")]
		private void OnMasterClientSwitched(LRIABUPBGVB newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x841C810", Offset = "0x841AE10", VA = "0x18841C810")]
		public void KMGFDPESCQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x841C910", Offset = "0x841AF10", VA = "0x18841C910")]
		public void NNGCOVJIXNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class FCLBZWLAIVQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KUXAUVMITFU container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x842F9A0", Offset = "0x842DFA0", VA = "0x18842F9A0")]
			internal LegacyConnectableManager ZRYTXKUNLMH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x841CB40", Offset = "0x841B140", VA = "0x18841CB40")]
		public static void XOCVBNBEMBJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x841CAC0", Offset = "0x841B0C0", VA = "0x18841CAC0")]
		public static void OUHJAJHBLYI(KUXAUVMITFU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, KQOXGPHVGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, GZDQTYVWKZY> OYGRWUFPXMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation BQMFTUVVVRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private YRWZPEXZHAC BGZVPDNMRPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private THTPORARMYO XCAFKBXXMDG;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker PKKIOAEJRGC;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8425420", Offset = "0x8423A20", VA = "0x188425420")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8424C80", Offset = "0x8423280", VA = "0x188424C80", Slot = "7")]
		public void Initialize(THTPORARMYO graph, YRWZPEXZHAC creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8424660", Offset = "0x8422C60", VA = "0x188424660", Slot = "5")]
		public void CKZWRPJKEQT(FPKNGWWHESN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8424E10", Offset = "0x8423410", VA = "0x188424E10", Slot = "9")]
		public void PWPFAQGBFOG(FPKNGWWHESN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8425050", Offset = "0x8423650", VA = "0x188425050", Slot = "8")]
		public void YCCEHRIPMMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8424A30", Offset = "0x8423030", VA = "0x188424A30", Slot = "10")]
		public void CNGMGKLPZEJ(FPKNGWWHESN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8424CC0", Offset = "0x84232C0", VA = "0x188424CC0", Slot = "11")]
		public void MPETWMRQDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8425210", Offset = "0x8423810", VA = "0x188425210")]
		private bool ZFIYITADFGY(FPKNGWWHESN a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class QTTCTOUVABI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly QNWPFZVDILA currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly FQFDPGEIZCW parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly FQFDPGEIZCW rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool TEDUGQUORWJ
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x8430230", Offset = "0x842E830", VA = "0x188430230")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8430340", Offset = "0x842E940", VA = "0x188430340")]
			public SerializeNodeInSubgraph(QNWPFZVDILA currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] FQFDPGEIZCW parentNodeData, [Optional] FQFDPGEIZCW rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x842FF20", Offset = "0x842E520", VA = "0x18842FF20")]
			public FQFDPGEIZCW KYZOGDONURM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x842FAA0", Offset = "0x842E0A0", VA = "0x18842FAA0")]
			private FQFDPGEIZCW EBUDCFIDYLU([Out] FQFDPGEIZCW a, [Out] FQFDPGEIZCW b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x842FD20", Offset = "0x842E320", VA = "0x18842FD20")]
			private FQFDPGEIZCW IRGVGANBNWG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x84300C0", Offset = "0x842E6C0", VA = "0x1884300C0")]
			private void UTULWFFXDJK(FQFDPGEIZCW a, FQFDPGEIZCW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x842FB60", Offset = "0x842E160", VA = "0x18842FB60")]
			private void FYPAQSMXOQZ(FQFDPGEIZCW a, FQFDPGEIZCW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager TKPCNEHSYAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private THTPORARMYO XCAFKBXXMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private KQOXGPHVGNH HFQACDMDZIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private YSCDIFLZLEA IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool CXJJKSBPZZK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool JWTGFYGYNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x842EC90", Offset = "0x842D290", VA = "0x18842EC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool WYXIWUTNPBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x842F100", Offset = "0x842D700", VA = "0x18842F100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x842DCE0", Offset = "0x842C2E0", VA = "0x18842DCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x842E2C0", Offset = "0x842C8C0", VA = "0x18842E2C0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x842E4B0", Offset = "0x842CAB0", VA = "0x18842E4B0")]
		public ConnectableGraphData MRTJIVBIYBE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x842E120", Offset = "0x842C720", VA = "0x18842E120")]
		public ConnectableGraphData IKBBBHIUOYW(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x842F5F0", Offset = "0x842DBF0", VA = "0x18842F5F0")]
		public void YZQIGNOVVQH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x842E330", Offset = "0x842C930", VA = "0x18842E330")]
		public void JVWAVTBGIDV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x842E620", Offset = "0x842CC20", VA = "0x18842E620")]
		public void NGSBPEIIXJH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x842E930", Offset = "0x842CF30", VA = "0x18842E930")]
		private void PNLKUPFDYAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x842E3D0", Offset = "0x842C9D0", VA = "0x18842E3D0")]
		private FQFDPGEIZCW KPQVMWCVKLC(QNWPFZVDILA a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x842F120", Offset = "0x842D720", VA = "0x18842F120")]
		private static void ULMZORYJBAO(QNWPFZVDILA a, bool b, FQFDPGEIZCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x842F3D0", Offset = "0x842D9D0", VA = "0x18842F3D0")]
		private void YSDSCAWJYCV(QNWPFZVDILA a, bool b, FQFDPGEIZCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x842ECE0", Offset = "0x842D2E0", VA = "0x18842ECE0")]
		private FQFDPGEIZCW RPNSFRHASSA(QNWPFZVDILA a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x842EE80", Offset = "0x842D480", VA = "0x18842EE80")]
		private bool UBSXYDYBCYO(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x842D480", Offset = "0x842BA80", VA = "0x18842D480")]
		private bool EWHEWNJQJJB(FQFDPGEIZCW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x842E650", Offset = "0x842CC50", VA = "0x18842E650")]
		private bool OLJRAPESLHP(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x842ED70", Offset = "0x842D370", VA = "0x18842ED70")]
		private static bool TJGFOIPDJNG(FQFDPGEIZCW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x842DD00", Offset = "0x842C300", VA = "0x18842DD00")]
		public static bool HSLBWHYKJCI(FQFDPGEIZCW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x842D140", Offset = "0x842B740", VA = "0x18842D140")]
		private ANXSKXJOXKD BYSYSQLXXNY(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x842EB10", Offset = "0x842D110", VA = "0x18842EB10")]
		private ANXSKXJOXKD PSRQZQRUIYY(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x842DF90", Offset = "0x842C590", VA = "0x18842DF90")]
		private ANXSKXJOXKD IJDBSPJWRYT(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x84281F0", Offset = "0x84267F0", VA = "0x1884281F0")]
		private static Guid MHAGUALYEMF(FQFDPGEIZCW a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x842F680", Offset = "0x842DC80", VA = "0x18842F680")]
		private string ZPBGMIEGNZK(FQFDPGEIZCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x842DAF0", Offset = "0x842C0F0", VA = "0x18842DAF0")]
		private bool FJMXUKGGETR(QNWPFZVDILA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x842E670", Offset = "0x842CC70", VA = "0x18842E670")]
		private static void PCHZBTLVXMH(QNWPFZVDILA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public QTTCTOUVABI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public ANXSKXJOXKD child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ANXSKXJOXKD parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int childSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int parentSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ConnectableLink LSVWDXUWRGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x841C350", Offset = "0x841A950", VA = "0x18841C350")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink HXAYNPZQOUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x841C3F0", Offset = "0x841A9F0", VA = "0x18841C3F0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x841C420", Offset = "0x841AA20", VA = "0x18841C420")]
		public ConnectionOperationData(ANXSKXJOXKD child, ANXSKXJOXKD parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface THTPORARMYO
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		FPKNGWWHESN KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(IYUZSJHVLHY manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TESFOKCASOH([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WOGVJPSKKWK(ANXSKXJOXKD a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BNKKCHZEQFQ(ANXSKXJOXKD a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PKKYFVWSMZU(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OZTPJQRUMQZ();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GJGYMXSRXJP(Func<ANXSKXJOXKD, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CEJVDLBMSGN(ANXSKXJOXKD a, HashSet<ANXSKXJOXKD> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<ANXSKXJOXKD> NUMNHHHZPGZ();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ITBZLHWGLMC(ANXSKXJOXKD a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OYJYBRGKFJM(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(FPKNGWWHESN node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface FPKNGWWHESN
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ANXSKXJOXKD VZPQNEPRECW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		FPKNGWWHESN VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink BFXWXFCELMU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool RISDIGMIESU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface GZDQTYVWKZY
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FTYJJGFKYMC(ANXSKXJOXKD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KKYGHZTKBGC(ANXSKXJOXKD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BBXRLJOEIAX(ANXSKXJOXKD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TSTQULMAVYJ(ANXSKXJOXKD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GZDQTYVWKZY GHUIZNXTYWE(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface YRWZPEXZHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, GZDQTYVWKZY linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GZDQTYVWKZY SSPFZVMNSQA();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UVZPMDQKLRI(GZDQTYVWKZY a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface XMVEHAEIFKP : ORRNDJSZCQS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WGHZFJGIHDL();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SRVSILRDUKA(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface KQOXGPHVGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CKZWRPJKEQT(FPKNGWWHESN a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(THTPORARMYO graph, YRWZPEXZHAC linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YCCEHRIPMMY();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PWPFAQGBFOG(FPKNGWWHESN a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CNGMGKLPZEJ(FPKNGWWHESN a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MPETWMRQDLP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class QNWPFZVDILA : FPKNGWWHESN
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class MKCFYFMENWI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink NKMJDFKVFWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public QNWPFZVDILA XZENJJHDRVK;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MKCFYFMENWI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8425680", Offset = "0x8423C80", VA = "0x188425680")]
			internal bool FJJSHPBVNPR(FPKNGWWHESN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink MYEGRUIKSEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<QNWPFZVDILA> RMEPSDQKBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private QNWPFZVDILA TGQZIPSPBLT;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink BFXWXFCELMU
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x15D2FE0", Offset = "0x15D15E0", VA = "0x1815D2FE0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x15D2A70", Offset = "0x15D1070", VA = "0x1815D2A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private QNWPFZVDILA SEJYAKTRJIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x842C640", Offset = "0x842AC40", VA = "0x18842C640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FPKNGWWHESN VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ANXSKXJOXKD VZPQNEPRECW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool RISDIGMIESU
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x842C870", Offset = "0x842AE70", VA = "0x18842C870", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool QFRULNVTIWM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x842D030", Offset = "0x842B630", VA = "0x18842D030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected QNWPFZVDILA UPYDKJXZEYI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x842D080", Offset = "0x842B680", VA = "0x18842D080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x842D0A0", Offset = "0x842B6A0", VA = "0x18842D0A0")]
		public QNWPFZVDILA(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x842CC60", Offset = "0x842B260", VA = "0x18842CC60")]
		public QNWPFZVDILA REAOVRDITKT(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x842C970", Offset = "0x842AF70", VA = "0x18842C970")]
		public QNWPFZVDILA MVRWNLAQOTZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x842CDA0", Offset = "0x842B3A0", VA = "0x18842CDA0")]
		public QNWPFZVDILA Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x842C720", Offset = "0x842AD20", VA = "0x18842C720")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x842CF80", Offset = "0x842B580", VA = "0x18842CF80")]
		public QNWPFZVDILA Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x842CAF0", Offset = "0x842B0F0", VA = "0x18842CAF0")]
		private static void OYJYBRGKFJM(QNWPFZVDILA a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x842CC50", Offset = "0x842B250", VA = "0x18842CC50", Slot = "9")]
		public void OYJYBRGKFJM(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x842C880", Offset = "0x842AE80", VA = "0x18842C880")]
		public static QNWPFZVDILA GTAYRUSLFBN(QNWPFZVDILA a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface YSCDIFLZLEA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool JWTGFYGYNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> WBYZSNGDKZX;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<LRIABUPBGVB> AOECWXLSHVX;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FTYJJGFKYMC(LegacyConnectableManager a, MTYZNGYCSFU b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void YJWIYJPSOFD(ANXSKXJOXKD a, ANXSKXJOXKD b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VYTWLKUAXHB(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void VEZRNZIDDUK(ConnectableGraphData a, [Optional] LRIABUPBGVB b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class LLXESPDHKYS
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x841E6B0", Offset = "0x841CCB0", VA = "0x18841E6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x841E620", Offset = "0x841CC20", VA = "0x18841E620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x841E660", Offset = "0x841CC60", VA = "0x18841E660")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class KBYTRUJWCTD : YSCDIFLZLEA, IDisposable, IMZUMQLTLNY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager TKPCNEHSYAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private MTYZNGYCSFU KKTJTIKYZVY;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool JWTGFYGYNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x841D940", Offset = "0x841BF40", VA = "0x18841D940", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x841D860", Offset = "0x841BE60", VA = "0x18841D860", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView UTKAVBFHTRM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x841E580", Offset = "0x841CB80", VA = "0x18841E580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> WBYZSNGDKZX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x841D740", Offset = "0x841BD40", VA = "0x18841D740", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x841E0F0", Offset = "0x841C6F0", VA = "0x18841E0F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<LRIABUPBGVB> AOECWXLSHVX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x841E4E0", Offset = "0x841CAE0", VA = "0x18841E4E0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x841D8A0", Offset = "0x841BEA0", VA = "0x18841D8A0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x841D7D0", Offset = "0x841BDD0", VA = "0x18841D7D0", Slot = "10")]
		public void FTYJJGFKYMC(LegacyConnectableManager a, MTYZNGYCSFU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x841D6F0", Offset = "0x841BCF0", VA = "0x18841D6F0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x841E3C0", Offset = "0x841C9C0", VA = "0x18841E3C0", Slot = "11")]
		public void YJWIYJPSOFD(ANXSKXJOXKD a, ANXSKXJOXKD b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x841E2A0", Offset = "0x841C8A0", VA = "0x18841E2A0", Slot = "12")]
		public void VYTWLKUAXHB(ANXSKXJOXKD a, int b, ANXSKXJOXKD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x841E180", Offset = "0x841C780", VA = "0x18841E180", Slot = "13")]
		public void VEZRNZIDDUK(ConnectableGraphData a, [Optional] LRIABUPBGVB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x841DBD0", Offset = "0x841C1D0", VA = "0x18841DBD0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(ANXSKXJOXKD objectToReparent, int objectToReparentSlotIndex, ANXSKXJOXKD newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x841D9E0", Offset = "0x841BFE0", VA = "0x18841D9E0")]
		[RPCMethod]
		private void RpcMasterModifyNode(ANXSKXJOXKD connectableToModify, ANXSKXJOXKD expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x841DFC0", Offset = "0x841C5C0", VA = "0x18841DFC0")]
		[RPCMethod]
		private void RpcReparentNodes(ANXSKXJOXKD objectToReparent, int objectToReparentSlotIndex, ANXSKXJOXKD newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x841DED0", Offset = "0x841C4D0", VA = "0x18841DED0")]
		[RPCMethod]
		private void RpcModifyNode(ANXSKXJOXKD connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x841D9A0", Offset = "0x841BFA0", VA = "0x18841D9A0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KBYTRUJWCTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, GZDQTYVWKZY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x841EF90", Offset = "0x841D590", VA = "0x18841EF90", Slot = "4")]
		private void ZVQQPAFRKFL(ANXSKXJOXKD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x841E830", Offset = "0x841CE30", VA = "0x18841E830", Slot = "5")]
		private void CEWSXAGOJKB(ANXSKXJOXKD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x841ED60", Offset = "0x841D360", VA = "0x18841ED60", Slot = "6")]
		private void TOYEKNPXEXM(ANXSKXJOXKD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x841EB00", Offset = "0x841D100", VA = "0x18841EB00", Slot = "7")]
		private void HTEWXRPSXIW(ANXSKXJOXKD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x841ECF0", Offset = "0x841D2F0", VA = "0x18841ECF0", Slot = "8")]
		private GZDQTYVWKZY QMEWSHAWMUZ(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x841EAA0", Offset = "0x841D0A0", VA = "0x18841EAA0", Slot = "9")]
		private void DOJQYQZQKOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class YOHLOECIICM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3EE54C0", Offset = "0x3EE3AC0", VA = "0x183EE54C0")]
		public static RLRVBLYLOTN<a> FTQZEKFXGQK<a>(this KUXAUVMITFU a)
		{
			return null;
		}
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
