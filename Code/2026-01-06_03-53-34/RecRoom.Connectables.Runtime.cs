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
		[Cpp2IlInjected.Address(RVA = "0x8262D50", Offset = "0x8261750", VA = "0x188262D50", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		private int[] TVXWIVSLKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] TVSPLOYOBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EJWMBZOWMVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset EKBSZGITWGJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F321F0", Offset = "0x1F30BF0", VA = "0x181F321F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x826EDF0", Offset = "0x826D7F0", VA = "0x18826EDF0")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x826EF40", Offset = "0x826D940", VA = "0x18826EF40")]
		private void ANXAERWSNVX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x826F090", Offset = "0x826DA90", VA = "0x18826F090", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x826F3A0", Offset = "0x826DDA0", VA = "0x18826F3A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : DFDMTGALMVR, XVYQGXFPXEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JTFZROWEFWV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public PHAWDGNAYSX JJNTQDSPFPZ;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public JTFZROWEFWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x825C090", Offset = "0x825AA90", VA = "0x18825C090")]
			internal object OPOBDEJHOYE(PHAWDGNAYSX a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JTASUICGWLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public PHAWDGNAYSX KIEUUCFCNXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JTFZROWEFWV MNSDRRJEMWM;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public JTASUICGWLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x825BE50", Offset = "0x825A850", VA = "0x18825BE50")]
			internal object OPTIALDEYJN((PHAWDGNAYSX child, PHAWDGNAYSX nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class YMVSEJNENVY : IEnumerable<AGFGMJOHUKY>, IEnumerable, IEnumerator<AGFGMJOHUKY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private AGFGMJOHUKY YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId UHNCSUBRQEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId WNDMHRJFWDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private ONAYZPPBQDG KPSJBUGFYLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray OKLVQBGRWOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator REMVWNIMTVH;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private AGFGMJOHUKY GHTZOTHSTAG
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public YMVSEJNENVY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x826EC90", Offset = "0x826D690", VA = "0x18826EC90", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x826E880", Offset = "0x826D280", VA = "0x18826E880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x826ED70", Offset = "0x826D770", VA = "0x18826ED70")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x826ED90", Offset = "0x826D790", VA = "0x18826ED90")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x826EDB0", Offset = "0x826D7B0", VA = "0x18826EDB0", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x826EBE0", Offset = "0x826D5E0", VA = "0x18826EBE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AGFGMJOHUKY> OTXSLESCGEB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x826EBE0", Offset = "0x826D5E0", VA = "0x18826EBE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log JZZSLXYUJAK;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log ODKVVXKYNEA;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log MZHKZESWVRO;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log GXECHRBZAWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private SUUZUFWGFQT ZEXJKBWOGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JSMFLIIXBUM YIPPOBOVVZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private JRXTOINJVYB SQQXHHVYGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EPVKSBRSQTH EMVJUYYRCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OZPWKEIEECJ GGCXGEYVOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GOFDNKBTHTZ ZFGQSUOOEYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly YPEVVNJVJUU YDZIBSORXNJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xABECB0", Offset = "0xABD6B0", VA = "0x180ABECB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xABF580", Offset = "0xABDF80", VA = "0x180ABF580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RXTESWLWUXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8267C00", Offset = "0x8266600", VA = "0x188267C00", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8265CD0", Offset = "0x82646D0", VA = "0x188265CD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8268D80", Offset = "0x8267780", VA = "0x188268D80", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8267660", Offset = "0x8266060", VA = "0x188267660", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8267710", Offset = "0x8266110", VA = "0x188267710", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x82666B0", Offset = "0x82650B0", VA = "0x1882666B0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x826A650", Offset = "0x8269050", VA = "0x18826A650")]
		public OMConnectableManager(PKSJLYSCDCL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8266D00", Offset = "0x8265700", VA = "0x188266D00", Slot = "12")]
		public void Initialize(GameObject gameObject, JLSZHGROTDY configData, CPMIWLXZEWF sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8266240", Offset = "0x8264C40", VA = "0x188266240", Slot = "26")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8267CB0", Offset = "0x82666B0", VA = "0x188267CB0", Slot = "22")]
		public bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82672F0", Offset = "0x8265CF0", VA = "0x1882672F0")]
		private void JZQGHAIUEOM(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8266020", Offset = "0x8264A20", VA = "0x188266020")]
		private void ARASJTUYUGS(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8269830", Offset = "0x8268230", VA = "0x188269830")]
		private void TZERQXNCELW(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8269F00", Offset = "0x8268900", VA = "0x188269F00")]
		private void XCLCLNTCNMH(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8266F70", Offset = "0x8265970", VA = "0x188266F70", Slot = "14")]
		public void JIBLBJTHOBM(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "15")]
		public void KBLBKORKNFH(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8265EC0", Offset = "0x82648C0", VA = "0x188265EC0", Slot = "17")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8265D80", Offset = "0x8264780", VA = "0x188265D80")]
		public void AMONYRVAZEQ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8267D00", Offset = "0x8266700", VA = "0x188267D00")]
		public void NODDEXJOVRG(AGFGMJOHUKY a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8266550", Offset = "0x8264F50", VA = "0x188266550", Slot = "18")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8266C50", Offset = "0x8265650", VA = "0x188266C50")]
		private float FSSDYJKSVZW(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8266410", Offset = "0x8264E10", VA = "0x188266410")]
		public void CQFEWFSSHZW(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82674F0", Offset = "0x8265EF0", VA = "0x1882674F0", Slot = "19")]
		public void KFIJVCZYUIG(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8267D90", Offset = "0x8266790", VA = "0x188267D90", Slot = "16")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "20")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "21")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8266AF0", Offset = "0x82654F0", VA = "0x188266AF0", Slot = "23")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8266760", Offset = "0x8265160", VA = "0x188266760", Slot = "24")]
		public void CZNOYMWDOIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8268E30", Offset = "0x8267830", VA = "0x188268E30", Slot = "25")]
		public void SNNKNRTIIDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8269A90", Offset = "0x8268490", VA = "0x188269A90")]
		private void ULRFXGIBTBQ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8268F60", Offset = "0x8267960", VA = "0x188268F60")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8267280", Offset = "0x8265C80", VA = "0x188267280")]
		private void JTPYTEQYDIZ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8268840", Offset = "0x8267240", VA = "0x188268840")]
		[IteratorStateMachine(typeof(YMVSEJNENVY))]
		public IEnumerable<AGFGMJOHUKY> QAXRLEFXBIC(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8268C50", Offset = "0x8267650", VA = "0x188268C50")]
		internal AGFGMJOHUKY RQEVNKDTRKB(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82667D0", Offset = "0x82651D0", VA = "0x1882667D0")]
		internal ObjectLocalId CZYVMDBYLSN(AGFGMJOHUKY a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8267FA0", Offset = "0x82669A0", VA = "0x188267FA0")]
		private bool NXNBGZIBTDW(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8269EA0", Offset = "0x82688A0", VA = "0x188269EA0")]
		private bool WFVTVOPHAFW(PHAWDGNAYSX a, [Out] AGFGMJOHUKY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82688D0", Offset = "0x82672D0", VA = "0x1882688D0")]
		private AGFGMJOHUKY RQEVNKDTRKB(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8266960", Offset = "0x8265360", VA = "0x188266960")]
		private AGFGMJOHUKY DABZXDAFLWK(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8267A40", Offset = "0x8266440", VA = "0x188267A40")]
		private AGFGMJOHUKY MMZOWQRAYGH(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8264790", Offset = "0x8263190", VA = "0x188264790")]
		private static Guid NLYKRGMAUSI(PHAWDGNAYSX a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8266B60", Offset = "0x8265560", VA = "0x188266B60")]
		private string EZXWHAEJDVT(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8268520", Offset = "0x8266F20", VA = "0x188268520")]
		private void OLDTADIUDBE(AGFGMJOHUKY a, AGFGMJOHUKY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82686B0", Offset = "0x82670B0", VA = "0x1882686B0")]
		private void OQAERXPUKUW(AGFGMJOHUKY a, AGFGMJOHUKY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x826A4A0", Offset = "0x8268EA0", VA = "0x18826A4A0")]
		private void ZTIUUNGKAVW(AGFGMJOHUKY a, AGFGMJOHUKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x826A310", Offset = "0x8268D10", VA = "0x18826A310")]
		private void YMUEGHRUMBX(AGFGMJOHUKY a, AGFGMJOHUKY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8268E50", Offset = "0x8267850", VA = "0x188268E50")]
		private void SSVUARWKQIQ(ObjectLocalId a, AGFGMJOHUKY b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82677C0", Offset = "0x82661C0", VA = "0x1882677C0")]
		private void MMVOJSGACQD(ObjectLocalId a, AGFGMJOHUKY b, AGFGMJOHUKY c, AGFGMJOHUKY d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MDYRTJWRTTU
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public PKSJLYSCDCL container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x826C490", Offset = "0x826AE90", VA = "0x18826C490")]
			internal OMConnectableManager ZHGQFSSNUYI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8262F30", Offset = "0x8261930", VA = "0x188262F30")]
		public static void RPHUHHYIUOY(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8262EE0", Offset = "0x82618E0", VA = "0x188262EE0")]
		public static void FILCQLJXIGD(PKSJLYSCDCL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : JJBGXAIEDOU, XPQOESPPVND
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager CSQZJTOYYZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly ONSUYHUWJJA FYCMWEFXIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly HOGONJQLERU EMVJUYYRCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly DZUTWPWUIKY[] UPOMMLEXZGQ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AGFGMJOHUKY ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x826C260", Offset = "0x826AC60", VA = "0x18826C260", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AGFGMJOHUKY RZNNQHFQSOL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x826AD80", Offset = "0x8269780", VA = "0x18826AD80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 ZFZOKAIJCHL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x826AE40", Offset = "0x8269840", VA = "0x18826AE40", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion AHLHOOUEYZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x826B150", Offset = "0x8269B50", VA = "0x18826B150", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PADDCFZCDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x826AD10", Offset = "0x8269710", VA = "0x18826AD10", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<AGFGMJOHUKY> ZTRBRGCCLLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x826A830", Offset = "0x8269230", VA = "0x18826A830", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool HKGZWFVDEHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB83C00", Offset = "0xB82600", VA = "0x180B83C00", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBCEFE0", Offset = "0xBCD9E0", VA = "0x180BCEFE0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x826C470", Offset = "0x826AE70", VA = "0x18826C470", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x826C170", Offset = "0x826AB70", VA = "0x18826C170", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x826C190", Offset = "0x826AB90", VA = "0x18826C190", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x826C2C0", Offset = "0x826ACC0", VA = "0x18826C2C0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x826C3A0", Offset = "0x826ADA0", VA = "0x18826C3A0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool KLYIAAEMXPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x826AF70", Offset = "0x8269970", VA = "0x18826AF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler RUWDUNTLQJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x826A6F0", Offset = "0x82690F0", VA = "0x18826A6F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x826BFA0", Offset = "0x826A9A0", VA = "0x18826BFA0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler XZSCRIQGWKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x826AC70", Offset = "0x8269670", VA = "0x18826AC70", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x826ACC0", Offset = "0x82696C0", VA = "0x18826ACC0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler GSTRYFFESGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x826B580", Offset = "0x8269F80", VA = "0x18826B580", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x826A740", Offset = "0x8269140", VA = "0x18826A740", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler NEXTIRBIVAT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x826B0B0", Offset = "0x8269AB0", VA = "0x18826B0B0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x826B010", Offset = "0x8269A10", VA = "0x18826B010", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x826C070", Offset = "0x826AA70", VA = "0x18826C070")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, ONSUYHUWJJA connectableTool, DZUTWPWUIKY[] connectionPoints, HOGONJQLERU callbacks, DFDMTGALMVR connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x826A6C0", Offset = "0x82690C0", VA = "0x18826A6C0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "21")]
		public void NYFEAWHERWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x826BF00", Offset = "0x826A900", VA = "0x18826BF00", Slot = "22")]
		public void XKAIPUEKKTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x826B530", Offset = "0x8269F30", VA = "0x18826B530", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x826AA60", Offset = "0x8269460", VA = "0x18826AA60", Slot = "25")]
		public void HIDEOESYKHZ(int a, AGFGMJOHUKY b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x826AEA0", Offset = "0x82698A0", VA = "0x18826AEA0", Slot = "26")]
		public void NIZZILFPBKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x826B7C0", Offset = "0x826A1C0", VA = "0x18826B7C0", Slot = "27")]
		public void VYANVIOXIGZ(int a, AGFGMJOHUKY b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x826BF20", Offset = "0x826A920", VA = "0x18826BF20", Slot = "28")]
		public void XNCMZXFTGBR(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x826BAA0", Offset = "0x826A4A0", VA = "0x18826BAA0", Slot = "31")]
		public void WFWBKSZWCHC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x826B1B0", Offset = "0x8269BB0", VA = "0x18826B1B0", Slot = "29")]
		public void REUXECYHDWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x826B5D0", Offset = "0x8269FD0", VA = "0x18826B5D0", Slot = "30")]
		public void VJADRVCAYUR(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x826A990", Offset = "0x8269390", VA = "0x18826A990", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x826A860", Offset = "0x8269260", VA = "0x18826A860", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD061B0", Offset = "0xD04BB0", VA = "0x180D061B0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x826A790", Offset = "0x8269190", VA = "0x18826A790", Slot = "43")]
		public bool CanConnectTo(int slotIndex, AGFGMJOHUKY otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "44")]
		public void ParentChanged(int slotIndex, AGFGMJOHUKY newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "45")]
		public void ChildAdded(int slotIndex, AGFGMJOHUKY newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "46")]
		public void ChildRemoved(int slotIndex, AGFGMJOHUKY removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "47")]
		public void ConnectionModified(int slotIndex, AGFGMJOHUKY parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x826B4C0", Offset = "0x8269EC0", VA = "0x18826B4C0", Slot = "48")]
		public void RootChanged(AGFGMJOHUKY previousRootConnectable, AGFGMJOHUKY newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x826BEB0", Offset = "0x826A8B0", VA = "0x18826BEB0", Slot = "23")]
		public void WQVJYLHFFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x826AFC0", Offset = "0x82699C0", VA = "0x18826AFC0", Slot = "24")]
		public void NYFZFAYKZCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x826B4E0", Offset = "0x8269EE0", VA = "0x18826B4E0")]
		private void SXMINCYINRS(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(GJIWHWLVAXL), new string[] { })]
	public class FIPWCKEWOYG : GJIWHWLVAXL, TTDQLFCDEXA, TFZKCIODVYK
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FVTRMYHTPKV
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FVTRMYHTPKV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private YXSCIWMMLFD FZZXZRNVKWC;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object CTMQASHVLNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x825BA90", Offset = "0x825A490", VA = "0x18825BA90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x825BB20", Offset = "0x825A520", VA = "0x18825BB20", Slot = "5")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCB03D0", Offset = "0xCAEDD0", VA = "0x180CB03D0", Slot = "6")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public FIPWCKEWOYG()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(DFDMTGALMVR), new string[] { "Ignore", "Mock" })]
	public class OIUIQSLFZRK : DFDMTGALMVR, XVYQGXFPXEO
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RXTESWLWUXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8265B70", Offset = "0x8264570", VA = "0x188265B70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x82658B0", Offset = "0x82642B0", VA = "0x1882658B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8265C20", Offset = "0x8264620", VA = "0x188265C20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8265A10", Offset = "0x8264410", VA = "0x188265A10", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8265AC0", Offset = "0x82644C0", VA = "0x188265AC0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8265960", Offset = "0x8264360", VA = "0x188265960", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "26")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "12")]
		public void Initialize(GameObject gameObject, JLSZHGROTDY configData, CPMIWLXZEWF rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "14")]
		public void JIBLBJTHOBM(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "15")]
		public void KBLBKORKNFH(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "16")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "17")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "18")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "19")]
		public void KFIJVCZYUIG(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "20")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "21")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "22")]
		public bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "23")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "24")]
		public void CZNOYMWDOIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "25")]
		public void SNNKNRTIIDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public OIUIQSLFZRK()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AGFGMJOHUKY : XPQOESPPVND, IEquatable<AGFGMJOHUKY>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface XPQOESPPVND
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		AGFGMJOHUKY ParentConnectable
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
		bool CanConnectTo(int slotIndex, AGFGMJOHUKY otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, AGFGMJOHUKY newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, AGFGMJOHUKY newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, AGFGMJOHUKY removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, AGFGMJOHUKY parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(AGFGMJOHUKY previousRootConnectable, AGFGMJOHUKY newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface DFDMTGALMVR : XVYQGXFPXEO
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool RXTESWLWUXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, JLSZHGROTDY configData, CPMIWLXZEWF rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JIBLBJTHOBM(AGFGMJOHUKY a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void KBLBKORKNFH(AGFGMJOHUKY a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void KFIJVCZYUIG(AGFGMJOHUKY a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData PASAQREWFZV(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool NGWJXHFMSQP(PHAWDGNAYSX a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void EKNAQKCCPGQ(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void CZNOYMWDOIO(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void SNNKNRTIIDZ(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface EPVKSBRSQTH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AGFGMJOHUKY MMZOWQRAYGH(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AGFGMJOHUKY DABZXDAFLWK(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JIKBIXLVDUO(AGFGMJOHUKY a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZKWNEVIVAAK();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VITSJIDKWFT(AGFGMJOHUKY a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HOGONJQLERU
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KLYIAAEMXPQ(ONSUYHUWJJA a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CFZDFMFLEOD(ONSUYHUWJJA a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string VGCZBSXXNAC(ONSUYHUWJJA a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid QODJEUFHQPX(ONSUYHUWJJA a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int PLBLSDIBQSG(ONSUYHUWJJA a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZOGVKWVGQTT(ONSUYHUWJJA a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(AGFGMJOHUKY childConnectable, int childConnectableSlot, AGFGMJOHUKY parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(AGFGMJOHUKY previousRootConnectable, AGFGMJOHUKY newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ONSUYHUWJJA : AGFGMJOHUKY, XPQOESPPVND, IEquatable<AGFGMJOHUKY>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JJBGXAIEDOU : XPQOESPPVND
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		AGFGMJOHUKY RZNNQHFQSOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<AGFGMJOHUKY> ZTRBRGCCLLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 ZFZOKAIJCHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion AHLHOOUEYZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool PADDCFZCDHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool HKGZWFVDEHV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler RUWDUNTLQJL;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler XZSCRIQGWKX;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler GSTRYFFESGU;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler NEXTIRBIVAT;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void NYFEAWHERWV();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void XKAIPUEKKTU();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void WQVJYLHFFJB();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void NYFZFAYKZCI();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void HIDEOESYKHZ(int a, AGFGMJOHUKY b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void NIZZILFPBKT();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void VYANVIOXIGZ(int a, AGFGMJOHUKY b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void XNCMZXFTGBR(AGFGMJOHUKY a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void REUXECYHDWC();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void VJADRVCAYUR(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void WFWBKSZWCHC(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface DZUTWPWUIKY
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 IQYAOJZUKIL
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
	public interface JLSZHGROTDY
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool PZZUGRPALPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		JSPDXWAYNZL GWBOXRNZGZA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, JLSZHGROTDY
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
		public bool PZZUGRPALPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JSPDXWAYNZL GWBOXRNZGZA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x825B260", Offset = "0x8259C60", VA = "0x18825B260")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x825B320", Offset = "0x8259D20", VA = "0x18825B320")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AGFGMJOHUKY connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x825B8F0", Offset = "0x825A2F0", VA = "0x18825B8F0")]
		public ConnectableLink(AGFGMJOHUKY connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x825B7D0", Offset = "0x825A1D0", VA = "0x18825B7D0")]
		public ConnectableLink(AGFGMJOHUKY connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x825B870", Offset = "0x825A270", VA = "0x18825B870")]
		public ConnectableLink(AGFGMJOHUKY connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x825B370", Offset = "0x8259D70", VA = "0x18825B370", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x825B420", Offset = "0x8259E20", VA = "0x18825B420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : OQSRVZQXFLR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform UPSIZUKXNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JSPDXWAYNZL HQTLSCJAAHP;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BB73E0", Offset = "0x7BB5DE0", VA = "0x187BB73E0", Slot = "4")]
		public void Initialize(Transform transform, JSPDXWAYNZL linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x825C170", Offset = "0x825AB70", VA = "0x18825C170", Slot = "5")]
		public JSPDXWAYNZL SZNHCDEPMYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x825C100", Offset = "0x825AB00", VA = "0x18825C100", Slot = "6")]
		public void KJXSTZNPDAT(JSPDXWAYNZL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, TKMWUFXTASH
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BEAFSXJMGRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AGFGMJOHUKY SMWRMRHNZTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AGFGMJOHUKY VJPAVQCBNIT;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public BEAFSXJMGRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x825B1A0", Offset = "0x8259BA0", VA = "0x18825B1A0")]
			internal bool AZIIAJAJJWZ(XIZDHCQMOGM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly AFOUMWXIEFH CKWWCEYDHVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private PLFGIJDDTXK AYUIZXVCWNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private RWVYLJXKMPW ZFGRYISJDJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool MMIYSWBUZMY;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log PYUOKBJNUSK;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public XIZDHCQMOGM XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x825EC40", Offset = "0x825D640", VA = "0x18825EC40")]
		public bool KPYZGQUDMCA([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x825DEA0", Offset = "0x825C8A0", VA = "0x18825DEA0")]
		private bool GYIUFFVEMUX([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x825FDE0", Offset = "0x825E7E0", VA = "0x18825FDE0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x825EAB0", Offset = "0x825D4B0", VA = "0x18825EAB0", Slot = "5")]
		public void Initialize(DFDMTGALMVR manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x825F990", Offset = "0x825E390", VA = "0x18825F990", Slot = "17")]
		public void TYXCJBVUIVX(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x825CF10", Offset = "0x825B910", VA = "0x18825CF10", Slot = "12")]
		public void DGQEUGQAJZW(Func<AGFGMJOHUKY, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x825CDE0", Offset = "0x825B7E0", VA = "0x18825CDE0")]
		private void DGQEUGQAJZW(AFOUMWXIEFH a, Func<AGFGMJOHUKY, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x825CF20", Offset = "0x825B920", VA = "0x18825CF20", Slot = "11")]
		public void DVGLCITLNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x825D180", Offset = "0x825BB80", VA = "0x18825D180", Slot = "8")]
		public bool EHHPNMJECNX(AGFGMJOHUKY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x825D790", Offset = "0x825C190", VA = "0x18825D790")]
		private bool GRTLJRJACVQ(AGFGMJOHUKY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x825F9C0", Offset = "0x825E3C0", VA = "0x18825F9C0")]
		private static bool VHYFHUNQUKQ(AGFGMJOHUKY a, AFOUMWXIEFH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x825F2D0", Offset = "0x825DCD0", VA = "0x18825F2D0")]
		private void OPAITDZIEXE(Transform a, AFOUMWXIEFH b, AFOUMWXIEFH[] c, AGFGMJOHUKY d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x825E5E0", Offset = "0x825CFE0", VA = "0x18825E5E0")]
		private ConnectableLink HPHYVPUCFCP(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x825F7D0", Offset = "0x825E1D0", VA = "0x18825F7D0")]
		private static bool QNACKPFFEZM(AFOUMWXIEFH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x825EC50", Offset = "0x825D650", VA = "0x18825EC50", Slot = "9")]
		public bool LJDWVVKFVQV(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x825E860", Offset = "0x825D260", VA = "0x18825E860")]
		private bool IYFAGFFRESS(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x825E460", Offset = "0x825CE60", VA = "0x18825E460")]
		private static void HAUWLSDPGFT(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e, AFOUMWXIEFH f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x825F1B0", Offset = "0x825DBB0", VA = "0x18825F1B0")]
		private void OLDTADIUDBE(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x825EBD0", Offset = "0x825D5D0", VA = "0x18825EBD0")]
		private void KEKXGRMKNKO(AFOUMWXIEFH a, AGFGMJOHUKY b, AGFGMJOHUKY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x825EB60", Offset = "0x825D560", VA = "0x18825EB60")]
		private void KEKXGRMKNKO(AGFGMJOHUKY a, AGFGMJOHUKY b, AGFGMJOHUKY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x825ECB0", Offset = "0x825D6B0", VA = "0x18825ECB0")]
		private void MMVOJSGACQD(AGFGMJOHUKY a, AGFGMJOHUKY b, AGFGMJOHUKY c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x825ED20", Offset = "0x825D720", VA = "0x18825ED20")]
		private void MMVOJSGACQD(AFOUMWXIEFH a, AGFGMJOHUKY b, AGFGMJOHUKY c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x825F6B0", Offset = "0x825E0B0", VA = "0x18825F6B0")]
		private void OQAERXPUKUW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x825FBC0", Offset = "0x825E5C0", VA = "0x18825FBC0")]
		private void ZTIUUNGKAVW(XIZDHCQMOGM a, XIZDHCQMOGM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x825CBB0", Offset = "0x825B5B0", VA = "0x18825CBB0", Slot = "18")]
		public AGFGMJOHUKY BDHLONXIJJT(AGFGMJOHUKY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x825EE20", Offset = "0x825D820", VA = "0x18825EE20", Slot = "13")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x825CF40", Offset = "0x825B940", VA = "0x18825CF40", Slot = "14")]
		public List<AGFGMJOHUKY> EDOEJXVHMSO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x825CAE0", Offset = "0x825B4E0", VA = "0x18825CAE0")]
		protected XIZDHCQMOGM AMVPWCPZIIR(XIZDHCQMOGM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x825CA40", Offset = "0x825B440", VA = "0x18825CA40")]
		protected AFOUMWXIEFH[] ADPPUTRTPKC(AFOUMWXIEFH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x825FAB0", Offset = "0x825E4B0", VA = "0x18825FAB0")]
		protected bool ZOKYRBOHWXR(AGFGMJOHUKY a, [Out] AFOUMWXIEFH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x825E730", Offset = "0x825D130", VA = "0x18825E730", Slot = "15")]
		public bool IWNCOTHZFIP(AGFGMJOHUKY a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x825FA70", Offset = "0x825E470", VA = "0x18825FA70")]
		protected AFOUMWXIEFH YCMRNDQRQCA(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x825D190", Offset = "0x825BB90", VA = "0x18825D190", Slot = "10")]
		public bool ERFDMNCGRLN(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x825D1F0", Offset = "0x825BBF0", VA = "0x18825D1F0")]
		private bool ERMLAQJYEDU(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x825CD10", Offset = "0x825B710", VA = "0x18825CD10")]
		private static bool BKJCNVHFMGA(AFOUMWXIEFH a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x825EC40", Offset = "0x825D640", VA = "0x18825EC40", Slot = "7")]
		private bool TZNXWHLWBTD([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : DFDMTGALMVR, XVYQGXFPXEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly PKSJLYSCDCL container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly RWVYLJXKMPW ZFGRYISJDJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly SMESNHOGLUN DQYEDZQZDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly MZSKVSCEYTZ VXQYGJJATJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly TKMWUFXTASH KAIKPHDIMQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal ZPTCFVNKXMU EMVJUYYRCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal VUUENZGIXJZ KUVVNLSMPEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal PLFGIJDDTXK HSRGERNGMUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool MMIYSWBUZMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool MXUBYZSLMJX;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool EYANGEXKSND
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB02590", Offset = "0xB00F90", VA = "0x180B02590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB02190", Offset = "0xB00B90", VA = "0x180B02190")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x10759B0", Offset = "0x10743B0", VA = "0x1810759B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2545DD0", Offset = "0x25447D0", VA = "0x182545DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool RXTESWLWUXU
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8261440", Offset = "0x825FE40", VA = "0x188261440", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x825FF90", Offset = "0x825E990", VA = "0x18825FF90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8261B10", Offset = "0x8260510", VA = "0x188261B10", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8261380", Offset = "0x825FD80", VA = "0x188261380", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x82613E0", Offset = "0x825FDE0", VA = "0x1882613E0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x82605B0", Offset = "0x825EFB0", VA = "0x1882605B0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8261C30", Offset = "0x8260630", VA = "0x188261C30")]
		public LegacyConnectableManager(PKSJLYSCDCL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8260860", Offset = "0x825F260", VA = "0x188260860", Slot = "12")]
		public void Initialize(GameObject gameObject, JLSZHGROTDY configData, CPMIWLXZEWF rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8260200", Offset = "0x825EC00", VA = "0x188260200", Slot = "26")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8261BB0", Offset = "0x82605B0", VA = "0x188261BB0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8260E20", Offset = "0x825F820", VA = "0x188260E20", Slot = "14")]
		public void JIBLBJTHOBM(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8260F70", Offset = "0x825F970", VA = "0x188260F70", Slot = "15")]
		public void KBLBKORKNFH(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x82616F0", Offset = "0x82600F0", VA = "0x1882616F0", Slot = "22")]
		public bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8260750", Offset = "0x825F150", VA = "0x188260750")]
		internal bool ERMLAQJYEDU([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x82619C0", Offset = "0x82603C0", VA = "0x1882619C0")]
		internal bool PXMNYNYUMUM([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x82611A0", Offset = "0x825FBA0", VA = "0x1882611A0")]
		internal void KYLFACHQSXK(AGFGMJOHUKY a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8260F70", Offset = "0x825F970", VA = "0x188260F70")]
		internal bool ZLIBTEOWURY(AGFGMJOHUKY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8260E40", Offset = "0x825F840", VA = "0x188260E40")]
		internal bool JTWVYECTYKI(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8261740", Offset = "0x8260140", VA = "0x188261740", Slot = "16")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x825FFF0", Offset = "0x825E9F0", VA = "0x18825FFF0", Slot = "17")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8260470", Offset = "0x825EE70", VA = "0x188260470", Slot = "18")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8260FD0", Offset = "0x825F9D0", VA = "0x188260FD0", Slot = "19")]
		public void KFIJVCZYUIG(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x82614A0", Offset = "0x825FEA0", VA = "0x1882614A0")]
		public void NANISWEBCWD([Optional] RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x82606C0", Offset = "0x825F0C0", VA = "0x1882606C0", Slot = "23")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8261840", Offset = "0x8260240", VA = "0x188261840", Slot = "20")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x82602D0", Offset = "0x825ECD0", VA = "0x1882602D0", Slot = "21")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8261B70", Offset = "0x8260570", VA = "0x188261B70", Slot = "25")]
		public void SNNKNRTIIDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8260610", Offset = "0x825F010", VA = "0x188260610", Slot = "24")]
		public void CZNOYMWDOIO(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class RWVYLJXKMPW : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly IYPBXZHMCLT<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly IYPBXZHMCLT<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly IYJVASNOTAK<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x826C6D0", Offset = "0x826B0D0", VA = "0x18826C6D0")]
		public RWVYLJXKMPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x826C670", Offset = "0x826B070", VA = "0x18826C670")]
		public void TGYFCWTIYIH(AGFGMJOHUKY a, AGFGMJOHUKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x826C590", Offset = "0x826AF90", VA = "0x18826C590")]
		public void JKJIJWSEHJL(AGFGMJOHUKY a, AGFGMJOHUKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x826C5F0", Offset = "0x826AFF0", VA = "0x18826C5F0")]
		public void NWUSBRIRGPV(AGFGMJOHUKY a, AGFGMJOHUKY b, AGFGMJOHUKY c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class SMESNHOGLUN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager VTSSGIVZARQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private VUUENZGIXJZ KUVVNLSMPEZ;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SMESNHOGLUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x826C8E0", Offset = "0x826B2E0", VA = "0x18826C8E0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x826C8D0", Offset = "0x826B2D0", VA = "0x18826C8D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x826CB80", Offset = "0x826B580", VA = "0x18826CB80")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x826CB10", Offset = "0x826B510", VA = "0x18826CB10")]
		private void OnMasterClientSwitched(RHIZVYSCBOY newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x826C7D0", Offset = "0x826B1D0", VA = "0x18826C7D0")]
		public void BJKCMEPQKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x826CA10", Offset = "0x826B410", VA = "0x18826CA10")]
		public void MTNSSGDQLSY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class VBDCCYQHWPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PKSJLYSCDCL container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x826C530", Offset = "0x826AF30", VA = "0x18826C530")]
			internal LegacyConnectableManager ZHGQFSSNUYI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x826E680", Offset = "0x826D080", VA = "0x18826E680")]
		public static void RPHUHHYIUOY(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x826E600", Offset = "0x826D000", VA = "0x18826E600")]
		public static void FILCQLJXIGD(PKSJLYSCDCL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, PLFGIJDDTXK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, JSPDXWAYNZL> PJAPIOXUIFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation ANHFJDSJXQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private OQSRVZQXFLR KRNHLNMLHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TKMWUFXTASH KAIKPHDIMQB;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker KZMLOPVRQKX;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8262C80", Offset = "0x8261680", VA = "0x188262C80")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8261FC0", Offset = "0x82609C0", VA = "0x188261FC0", Slot = "7")]
		public void Initialize(TKMWUFXTASH graph, OQSRVZQXFLR creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8262000", Offset = "0x8260A00", VA = "0x188262000", Slot = "5")]
		public void KFTFIUYYTHO(XIZDHCQMOGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8262AB0", Offset = "0x82614B0", VA = "0x188262AB0", Slot = "9")]
		public void VZQIGFQCVED(XIZDHCQMOGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x82628F0", Offset = "0x82612F0", VA = "0x1882628F0", Slot = "8")]
		public void TEMMRMBKTCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x82622A0", Offset = "0x8260CA0", VA = "0x1882622A0", Slot = "10")]
		public void PXFUCDNJLQA(XIZDHCQMOGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x82625F0", Offset = "0x8260FF0", VA = "0x1882625F0", Slot = "11")]
		public void SEAMBBERDTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8262740", Offset = "0x8261140", VA = "0x188262740")]
		private bool SMFNZYLGWRN(XIZDHCQMOGM a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class MZSKVSCEYTZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly AFOUMWXIEFH currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly PHAWDGNAYSX parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly PHAWDGNAYSX rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool SIFLXCDCFEU
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x826CF20", Offset = "0x826B920", VA = "0x18826CF20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x826D470", Offset = "0x826BE70", VA = "0x18826D470")]
			public SerializeNodeInSubgraph(AFOUMWXIEFH currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] PHAWDGNAYSX parentNodeData, [Optional] PHAWDGNAYSX rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x826CD80", Offset = "0x826B780", VA = "0x18826CD80")]
			public PHAWDGNAYSX JVPEYACKYLR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x826D1B0", Offset = "0x826BBB0", VA = "0x18826D1B0")]
			private PHAWDGNAYSX VIZNFRPBGJF([Out] PHAWDGNAYSX a, [Out] PHAWDGNAYSX b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x826D270", Offset = "0x826BC70", VA = "0x18826D270")]
			private PHAWDGNAYSX XSEJWUVXFJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x826D040", Offset = "0x826BA40", VA = "0x18826D040")]
			private void UDSWBMNZLBN(PHAWDGNAYSX a, PHAWDGNAYSX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x826CBC0", Offset = "0x826B5C0", VA = "0x18826CBC0")]
			private void IJMDXIYBHIE(PHAWDGNAYSX a, PHAWDGNAYSX b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager VTSSGIVZARQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TKMWUFXTASH KAIKPHDIMQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private PLFGIJDDTXK AYUIZXVCWNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private VUUENZGIXJZ KUVVNLSMPEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool RXTZBBBRAWX;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool YJXLTSOSYLC
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8265020", Offset = "0x8263A20", VA = "0x188265020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool EYANGEXKSND
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8265070", Offset = "0x8263A70", VA = "0x188265070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8264120", Offset = "0x8262B20", VA = "0x188264120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8263E60", Offset = "0x8262860", VA = "0x188263E60")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8264EB0", Offset = "0x82638B0", VA = "0x188264EB0")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x82632F0", Offset = "0x8261CF0", VA = "0x1882632F0")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8263530", Offset = "0x8261F30", VA = "0x188263530")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8263490", Offset = "0x8261E90", VA = "0x188263490")]
		public void CZNOYMWDOIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8265810", Offset = "0x8264210", VA = "0x188265810")]
		public void ZVIOIXDHNGY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x82636B0", Offset = "0x82620B0", VA = "0x1882636B0")]
		private void FJTTXOWFPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8263890", Offset = "0x8262290", VA = "0x188263890")]
		private PHAWDGNAYSX GFZDZZGWUIP(AFOUMWXIEFH a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8263ED0", Offset = "0x82628D0", VA = "0x188263ED0")]
		private static void KBRTHJJLTLV(AFOUMWXIEFH a, bool b, PHAWDGNAYSX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8263AB0", Offset = "0x82624B0", VA = "0x188263AB0")]
		private void HXRUMCCFPIA(AFOUMWXIEFH a, bool b, PHAWDGNAYSX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8264E20", Offset = "0x8263820", VA = "0x188264E20")]
		private PHAWDGNAYSX OKZEPPVQWYF(AFOUMWXIEFH a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8265560", Offset = "0x8263F60", VA = "0x188265560")]
		private bool YDPMQDGHASN(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x82647D0", Offset = "0x82631D0", VA = "0x1882647D0")]
		private bool NXNBGZIBTDW(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x82657F0", Offset = "0x82641F0", VA = "0x1882657F0")]
		private bool YHMPZVMCCCK(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x82631E0", Offset = "0x8261BE0", VA = "0x1882631E0")]
		private static bool BAYQTMXJFTR(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8264500", Offset = "0x8262F00", VA = "0x188264500")]
		public static bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8265090", Offset = "0x8263A90", VA = "0x188265090")]
		private AGFGMJOHUKY RQEVNKDTRKB(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8264390", Offset = "0x8262D90", VA = "0x188264390")]
		private AGFGMJOHUKY MMZOWQRAYGH(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x82653D0", Offset = "0x8263DD0", VA = "0x1882653D0")]
		private AGFGMJOHUKY XQCOJZLQUWG(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8264790", Offset = "0x8263190", VA = "0x188264790")]
		private static Guid NLYKRGMAUSI(PHAWDGNAYSX a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x82635C0", Offset = "0x8261FC0", VA = "0x1882635C0")]
		private string EZXWHAEJDVT(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8263CD0", Offset = "0x82626D0", VA = "0x188263CD0")]
		private bool IXGEZSJIMXW(AFOUMWXIEFH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8264140", Offset = "0x8262B40", VA = "0x188264140")]
		private static void KYKZGORAZVE(AFOUMWXIEFH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public MZSKVSCEYTZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AGFGMJOHUKY child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AGFGMJOHUKY parent;

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
		public ConnectableLink ZRPMEZWCYGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x825B950", Offset = "0x825A350", VA = "0x18825B950")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink PGPCQFFQPWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x825B9F0", Offset = "0x825A3F0", VA = "0x18825B9F0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x825BA20", Offset = "0x825A420", VA = "0x18825BA20")]
		public ConnectionOperationData(AGFGMJOHUKY child, AGFGMJOHUKY parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface TKMWUFXTASH
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		XIZDHCQMOGM XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(DFDMTGALMVR manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KPYZGQUDMCA([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EHHPNMJECNX(AGFGMJOHUKY a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool LJDWVVKFVQV(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ERFDMNCGRLN(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DVGLCITLNLC();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DGQEUGQAJZW(Func<AGFGMJOHUKY, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<AGFGMJOHUKY> EDOEJXVHMSO();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool IWNCOTHZFIP(AGFGMJOHUKY a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void TYXCJBVUIVX(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(XIZDHCQMOGM node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface XIZDHCQMOGM
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		AGFGMJOHUKY HMULSBXUUFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		XIZDHCQMOGM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink FUDWHFHMKSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool WRRYAERZEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface JSPDXWAYNZL : OVKXEPUBYLJ.XHWNFIAULLX
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BDNHZJHRRDD(AGFGMJOHUKY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OJDFQFKVHZL(AGFGMJOHUKY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CKOHCWJCLTA(AGFGMJOHUKY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CSKDMZSDRGK(AGFGMJOHUKY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		JSPDXWAYNZL JXXCBWAEVKJ(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface OQSRVZQXFLR
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, JSPDXWAYNZL linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JSPDXWAYNZL SZNHCDEPMYH();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KJXSTZNPDAT(JSPDXWAYNZL a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface ZPTCFVNKXMU : EPVKSBRSQTH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WASQJHKCFHE();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RONOAAJHIKP(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface PLFGIJDDTXK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KFTFIUYYTHO(XIZDHCQMOGM a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(TKMWUFXTASH graph, OQSRVZQXFLR linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TEMMRMBKTCN();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VZQIGFQCVED(XIZDHCQMOGM a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PXFUCDNJLQA(XIZDHCQMOGM a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SEAMBBERDTC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class AFOUMWXIEFH : XIZDHCQMOGM
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class MKCLAVTPTUR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink HPBGPGNLJFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AFOUMWXIEFH FFOVFOADVKN;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public MKCLAVTPTUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x82630A0", Offset = "0x8261AA0", VA = "0x1882630A0")]
			internal bool CFWDXPEMXCU(XIZDHCQMOGM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink RMKGBUNSRKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<AFOUMWXIEFH> BZMLJUYVXTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private AFOUMWXIEFH VGSKBZFOGCA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink FUDWHFHMKSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4711E60", Offset = "0x4710860", VA = "0x184711E60", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x825A8F0", Offset = "0x82592F0", VA = "0x18825A8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private AFOUMWXIEFH HJMDDSQJNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x825A810", Offset = "0x8259210", VA = "0x18825A810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public XIZDHCQMOGM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public AGFGMJOHUKY HMULSBXUUFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WRRYAERZEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x825AA60", Offset = "0x8259460", VA = "0x18825AA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool OXQLXFQTEJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x825A670", Offset = "0x8259070", VA = "0x18825A670", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected AFOUMWXIEFH OQYAWLRTKSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x825AE80", Offset = "0x8259880", VA = "0x18825AE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x825B100", Offset = "0x8259B00", VA = "0x18825B100")]
		public AFOUMWXIEFH(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x825A920", Offset = "0x8259320", VA = "0x18825A920")]
		public AFOUMWXIEFH JHPMQEXBLAQ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x825AA70", Offset = "0x8259470", VA = "0x18825AA70")]
		public AFOUMWXIEFH PVNPYSKZNGY(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x825ABF0", Offset = "0x82595F0", VA = "0x18825ABF0")]
		public AFOUMWXIEFH Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x825A6C0", Offset = "0x82590C0", VA = "0x18825A6C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x825ADD0", Offset = "0x82597D0", VA = "0x18825ADD0")]
		public AFOUMWXIEFH Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x825AEA0", Offset = "0x82598A0", VA = "0x18825AEA0")]
		private static void TYXCJBVUIVX(AFOUMWXIEFH a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x825B000", Offset = "0x8259A00", VA = "0x18825B000", Slot = "9")]
		public void TYXCJBVUIVX(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x825B010", Offset = "0x8259A10", VA = "0x18825B010")]
		public static AFOUMWXIEFH YCMRNDQRQCA(AFOUMWXIEFH a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface VUUENZGIXJZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool YJXLTSOSYLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> VNYLEPNTAIQ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<RHIZVYSCBOY> REGNHEHWFKK;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BDNHZJHRRDD(LegacyConnectableManager a, CPMIWLXZEWF b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void XIUNGRNCHNT(ConnectableGraphData a, [Optional] RHIZVYSCBOY b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class GLAQLIDRLPB
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x825BBE0", Offset = "0x825A5E0", VA = "0x18825BBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x825BC30", Offset = "0x825A630", VA = "0x18825BC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x825BC70", Offset = "0x825A670", VA = "0x18825BC70")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class TBOAJQQAZPC : VUUENZGIXJZ, IDisposable, KNRCWYSSSBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager VTSSGIVZARQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CPMIWLXZEWF XRTOUONJFDL;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool YJXLTSOSYLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x826DAA0", Offset = "0x826C4A0", VA = "0x18826DAA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x826D730", Offset = "0x826C130", VA = "0x18826D730", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView MFEJFLHFAPV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x826D770", Offset = "0x826C170", VA = "0x18826D770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> VNYLEPNTAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x826D970", Offset = "0x826C370", VA = "0x18826D970", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x826E250", Offset = "0x826CC50", VA = "0x18826E250", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<RHIZVYSCBOY> REGNHEHWFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x826D4E0", Offset = "0x826BEE0", VA = "0x18826D4E0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x826DA00", Offset = "0x826C400", VA = "0x18826DA00", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x826D6A0", Offset = "0x826C0A0", VA = "0x18826D6A0", Slot = "10")]
		public void BDNHZJHRRDD(LegacyConnectableManager a, CPMIWLXZEWF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x826D920", Offset = "0x826C320", VA = "0x18826D920", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x826D580", Offset = "0x826BF80", VA = "0x18826D580", Slot = "11")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x826D800", Offset = "0x826C200", VA = "0x18826D800", Slot = "12")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x826E2E0", Offset = "0x826CCE0", VA = "0x18826E2E0", Slot = "13")]
		public void XIUNGRNCHNT(ConnectableGraphData a, [Optional] RHIZVYSCBOY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x826DD30", Offset = "0x826C730", VA = "0x18826DD30")]
		[RPCMethod]
		private void RpcMasterReparentNodes(AGFGMJOHUKY objectToReparent, int objectToReparentSlotIndex, AGFGMJOHUKY newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x826DB40", Offset = "0x826C540", VA = "0x18826DB40")]
		[RPCMethod]
		private void RpcMasterModifyNode(AGFGMJOHUKY connectableToModify, AGFGMJOHUKY expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x826E120", Offset = "0x826CB20", VA = "0x18826E120")]
		[RPCMethod]
		private void RpcReparentNodes(AGFGMJOHUKY objectToReparent, int objectToReparentSlotIndex, AGFGMJOHUKY newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x826E030", Offset = "0x826CA30", VA = "0x18826E030")]
		[RPCMethod]
		private void RpcModifyNode(AGFGMJOHUKY connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x826DB00", Offset = "0x826C500", VA = "0x18826DB00")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TBOAJQQAZPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JSPDXWAYNZL, OVKXEPUBYLJ.XHWNFIAULLX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x825C8C0", Offset = "0x825B2C0", VA = "0x18825C8C0", Slot = "4")]
		private void YCHHWCBCBJC(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x825C660", Offset = "0x825B060", VA = "0x18825C660", Slot = "5")]
		private void QQOIMHNZIQA(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x825C240", Offset = "0x825AC40", VA = "0x18825C240", Slot = "6")]
		private void DUGPSZDPURX(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x825C410", Offset = "0x825AE10", VA = "0x18825C410", Slot = "7")]
		private void GYWEAZJLCOX(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x825C3A0", Offset = "0x825ADA0", VA = "0x18825C3A0", Slot = "8")]
		private JSPDXWAYNZL FXHERPNYYNI(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x825C600", Offset = "0x825B000", VA = "0x18825C600", Slot = "9")]
		private void HJSXQDGNENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class WUMFLYBVBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3BE42B0", Offset = "0x3BE2CB0", VA = "0x183BE42B0")]
		public static KWOECSOXYTI<a> QJRTHPRJXZD<a>(this PKSJLYSCDCL a)
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
