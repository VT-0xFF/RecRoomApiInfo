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
		[Cpp2IlInjected.Address(RVA = "0x815F180", Offset = "0x815D980", VA = "0x18815F180", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B170", Offset = "0x1F19970", VA = "0x181F1B170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x816B1A0", Offset = "0x81699A0", VA = "0x18816B1A0")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x816B2F0", Offset = "0x8169AF0", VA = "0x18816B2F0")]
		private void ANXAERWSNVX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x816B440", Offset = "0x8169C40", VA = "0x18816B440", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x816B750", Offset = "0x8169F50", VA = "0x18816B750")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public JTFZROWEFWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8158330", Offset = "0x8156B30", VA = "0x188158330")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public JTASUICGWLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x81580E0", Offset = "0x81568E0", VA = "0x1881580E0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD38BD0", Offset = "0xD373D0", VA = "0x180D38BD0")]
			[DebuggerHidden]
			public YMVSEJNENVY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x816B040", Offset = "0x8169840", VA = "0x18816B040", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x816AC30", Offset = "0x8169430", VA = "0x18816AC30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x816B120", Offset = "0x8169920", VA = "0x18816B120")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x816B140", Offset = "0x8169940", VA = "0x18816B140")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x816B160", Offset = "0x8169960", VA = "0x18816B160", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x816AF90", Offset = "0x8169790", VA = "0x18816AF90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AGFGMJOHUKY> OTXSLESCGEB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x816AF90", Offset = "0x8169790", VA = "0x18816AF90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7D60", Offset = "0xAA6560", VA = "0x180AA7D60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA8660", Offset = "0xAA6E60", VA = "0x180AA8660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RXTESWLWUXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8164010", Offset = "0x8162810", VA = "0x188164010", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8162110", Offset = "0x8160910", VA = "0x188162110", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8165180", Offset = "0x8163980", VA = "0x188165180", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8163A70", Offset = "0x8162270", VA = "0x188163A70", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8163B20", Offset = "0x8162320", VA = "0x188163B20", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8162AF0", Offset = "0x81612F0", VA = "0x188162AF0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8166A40", Offset = "0x8165240", VA = "0x188166A40")]
		public OMConnectableManager(PKSJLYSCDCL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8163120", Offset = "0x8161920", VA = "0x188163120", Slot = "12")]
		public void Initialize(GameObject gameObject, JLSZHGROTDY configData, CPMIWLXZEWF sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8162680", Offset = "0x8160E80", VA = "0x188162680", Slot = "26")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81640C0", Offset = "0x81628C0", VA = "0x1881640C0", Slot = "22")]
		public bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8163700", Offset = "0x8161F00", VA = "0x188163700")]
		private void JZQGHAIUEOM(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8162460", Offset = "0x8160C60", VA = "0x188162460")]
		private void ARASJTUYUGS(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8165C30", Offset = "0x8164430", VA = "0x188165C30")]
		private void TZERQXNCELW(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81662F0", Offset = "0x8164AF0", VA = "0x1881662F0")]
		private void XCLCLNTCNMH(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8163390", Offset = "0x8161B90", VA = "0x188163390", Slot = "14")]
		public void JIBLBJTHOBM(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "15")]
		public void KBLBKORKNFH(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8162300", Offset = "0x8160B00", VA = "0x188162300", Slot = "17")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81621C0", Offset = "0x81609C0", VA = "0x1881621C0")]
		public void AMONYRVAZEQ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8164110", Offset = "0x8162910", VA = "0x188164110")]
		public void NODDEXJOVRG(AGFGMJOHUKY a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8162990", Offset = "0x8161190", VA = "0x188162990", Slot = "18")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8163070", Offset = "0x8161870", VA = "0x188163070")]
		private float FSSDYJKSVZW(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8162850", Offset = "0x8161050", VA = "0x188162850")]
		public void CQFEWFSSHZW(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8163900", Offset = "0x8162100", VA = "0x188163900", Slot = "19")]
		public void KFIJVCZYUIG(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81641A0", Offset = "0x81629A0", VA = "0x1881641A0", Slot = "16")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "20")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "21")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8162F10", Offset = "0x8161710", VA = "0x188162F10", Slot = "23")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8162BA0", Offset = "0x81613A0", VA = "0x188162BA0", Slot = "24")]
		public void CZNOYMWDOIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8165230", Offset = "0x8163A30", VA = "0x188165230", Slot = "25")]
		public void SNNKNRTIIDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8165E90", Offset = "0x8164690", VA = "0x188165E90")]
		private void ULRFXGIBTBQ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8165360", Offset = "0x8163B60", VA = "0x188165360")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8163690", Offset = "0x8161E90", VA = "0x188163690")]
		private void JTPYTEQYDIZ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8164C40", Offset = "0x8163440", VA = "0x188164C40")]
		[IteratorStateMachine(typeof(YMVSEJNENVY))]
		public IEnumerable<AGFGMJOHUKY> QAXRLEFXBIC(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8165050", Offset = "0x8163850", VA = "0x188165050")]
		internal AGFGMJOHUKY RQEVNKDTRKB(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8162C10", Offset = "0x8161410", VA = "0x188162C10")]
		internal ObjectLocalId CZYVMDBYLSN(AGFGMJOHUKY a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81643A0", Offset = "0x8162BA0", VA = "0x1881643A0")]
		private bool NXNBGZIBTDW(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8166290", Offset = "0x8164A90", VA = "0x188166290")]
		private bool WFVTVOPHAFW(PHAWDGNAYSX a, [Out] AGFGMJOHUKY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8164CD0", Offset = "0x81634D0", VA = "0x188164CD0")]
		private AGFGMJOHUKY RQEVNKDTRKB(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8162D90", Offset = "0x8161590", VA = "0x188162D90")]
		private AGFGMJOHUKY DABZXDAFLWK(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8163E50", Offset = "0x8162650", VA = "0x188163E50")]
		private AGFGMJOHUKY MMZOWQRAYGH(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8160BC0", Offset = "0x815F3C0", VA = "0x188160BC0")]
		private static Guid NLYKRGMAUSI(PHAWDGNAYSX a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8162F80", Offset = "0x8161780", VA = "0x188162F80")]
		private string EZXWHAEJDVT(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8164920", Offset = "0x8163120", VA = "0x188164920")]
		private void OLDTADIUDBE(AGFGMJOHUKY a, AGFGMJOHUKY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8164AB0", Offset = "0x81632B0", VA = "0x188164AB0")]
		private void OQAERXPUKUW(AGFGMJOHUKY a, AGFGMJOHUKY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8166890", Offset = "0x8165090", VA = "0x188166890")]
		private void ZTIUUNGKAVW(AGFGMJOHUKY a, AGFGMJOHUKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8166700", Offset = "0x8164F00", VA = "0x188166700")]
		private void YMUEGHRUMBX(AGFGMJOHUKY a, AGFGMJOHUKY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8165250", Offset = "0x8163A50", VA = "0x188165250")]
		private void SSVUARWKQIQ(ObjectLocalId a, AGFGMJOHUKY b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8163BD0", Offset = "0x81623D0", VA = "0x188163BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8168860", Offset = "0x8167060", VA = "0x188168860")]
			internal OMConnectableManager ZHGQFSSNUYI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x815F360", Offset = "0x815DB60", VA = "0x18815F360")]
		public static void RPHUHHYIUOY(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x815F310", Offset = "0x815DB10", VA = "0x18815F310")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0", Slot = "38")]
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
			[Cpp2IlInjected.Address(RVA = "0x8168640", Offset = "0x8166E40", VA = "0x188168640", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AGFGMJOHUKY RZNNQHFQSOL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8167170", Offset = "0x8165970", VA = "0x188167170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 ZFZOKAIJCHL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8167230", Offset = "0x8165A30", VA = "0x188167230", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion AHLHOOUEYZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8167540", Offset = "0x8165D40", VA = "0x188167540", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PADDCFZCDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8167100", Offset = "0x8165900", VA = "0x188167100", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<AGFGMJOHUKY> ZTRBRGCCLLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20", Slot = "13")]
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
			[Cpp2IlInjected.Address(RVA = "0xB6CA30", Offset = "0xB6B230", VA = "0x180B6CA30", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBB7E80", Offset = "0xBB6680", VA = "0x180BB7E80", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8168840", Offset = "0x8167040", VA = "0x188168840", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8168560", Offset = "0x8166D60", VA = "0x188168560", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8168580", Offset = "0x8166D80", VA = "0x188168580", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x81686A0", Offset = "0x8166EA0", VA = "0x1881686A0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8168780", Offset = "0x8166F80", VA = "0x188168780", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool KLYIAAEMXPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8167360", Offset = "0x8165B60", VA = "0x188167360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler RUWDUNTLQJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8166AE0", Offset = "0x81652E0", VA = "0x188166AE0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8168390", Offset = "0x8166B90", VA = "0x188168390", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler XZSCRIQGWKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8167060", Offset = "0x8165860", VA = "0x188167060", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x81670B0", Offset = "0x81658B0", VA = "0x1881670B0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler GSTRYFFESGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8167970", Offset = "0x8166170", VA = "0x188167970", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8166B30", Offset = "0x8165330", VA = "0x188166B30", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler NEXTIRBIVAT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x81674A0", Offset = "0x8165CA0", VA = "0x1881674A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8167400", Offset = "0x8165C00", VA = "0x188167400", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8168460", Offset = "0x8166C60", VA = "0x188168460")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, ONSUYHUWJJA connectableTool, DZUTWPWUIKY[] connectionPoints, HOGONJQLERU callbacks, DFDMTGALMVR connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8166AB0", Offset = "0x81652B0", VA = "0x188166AB0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "21")]
		public void NYFEAWHERWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81682F0", Offset = "0x8166AF0", VA = "0x1881682F0", Slot = "22")]
		public void XKAIPUEKKTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8167920", Offset = "0x8166120", VA = "0x188167920", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8166E50", Offset = "0x8165650", VA = "0x188166E50", Slot = "25")]
		public void HIDEOESYKHZ(int a, AGFGMJOHUKY b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8167290", Offset = "0x8165A90", VA = "0x188167290", Slot = "26")]
		public void NIZZILFPBKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8167BB0", Offset = "0x81663B0", VA = "0x188167BB0", Slot = "27")]
		public void VYANVIOXIGZ(int a, AGFGMJOHUKY b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8168310", Offset = "0x8166B10", VA = "0x188168310", Slot = "28")]
		public void XNCMZXFTGBR(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8167E90", Offset = "0x8166690", VA = "0x188167E90", Slot = "31")]
		public void WFWBKSZWCHC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81675A0", Offset = "0x8165DA0", VA = "0x1881675A0", Slot = "29")]
		public void REUXECYHDWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x81679C0", Offset = "0x81661C0", VA = "0x1881679C0", Slot = "30")]
		public void VJADRVCAYUR(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8166D80", Offset = "0x8165580", VA = "0x188166D80", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8166C50", Offset = "0x8165450", VA = "0x188166C50", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCEED60", Offset = "0xCED560", VA = "0x180CEED60", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8166B80", Offset = "0x8165380", VA = "0x188166B80", Slot = "43")]
		public bool CanConnectTo(int slotIndex, AGFGMJOHUKY otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "44")]
		public void ParentChanged(int slotIndex, AGFGMJOHUKY newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "45")]
		public void ChildAdded(int slotIndex, AGFGMJOHUKY newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "46")]
		public void ChildRemoved(int slotIndex, AGFGMJOHUKY removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "47")]
		public void ConnectionModified(int slotIndex, AGFGMJOHUKY parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81678B0", Offset = "0x81660B0", VA = "0x1881678B0", Slot = "48")]
		public void RootChanged(AGFGMJOHUKY previousRootConnectable, AGFGMJOHUKY newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81682A0", Offset = "0x8166AA0", VA = "0x1881682A0", Slot = "23")]
		public void WQVJYLHFFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81673B0", Offset = "0x8165BB0", VA = "0x1881673B0", Slot = "24")]
		public void NYFZFAYKZCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81678D0", Offset = "0x81660D0", VA = "0x1881678D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x8157D20", Offset = "0x8156520", VA = "0x188157D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8157DB0", Offset = "0x81565B0", VA = "0x188157DB0", Slot = "5")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC990B0", Offset = "0xC978B0", VA = "0x180C990B0", Slot = "6")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RXTESWLWUXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8161FB0", Offset = "0x81607B0", VA = "0x188161FB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8161CF0", Offset = "0x81604F0", VA = "0x188161CF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8162060", Offset = "0x8160860", VA = "0x188162060", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8161E50", Offset = "0x8160650", VA = "0x188161E50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8161F00", Offset = "0x8160700", VA = "0x188161F00", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8161DA0", Offset = "0x81605A0", VA = "0x188161DA0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "26")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "12")]
		public void Initialize(GameObject gameObject, JLSZHGROTDY configData, CPMIWLXZEWF rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "14")]
		public void JIBLBJTHOBM(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "15")]
		public void KBLBKORKNFH(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "16")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "17")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "18")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "19")]
		public void KFIJVCZYUIG(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "20")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "21")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "22")]
		public bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "23")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "24")]
		public void CZNOYMWDOIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "25")]
		public void SNNKNRTIIDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xBE0F00", Offset = "0xBDF700", VA = "0x180BE0F00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JSPDXWAYNZL GWBOXRNZGZA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x81574E0", Offset = "0x8155CE0", VA = "0x1881574E0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x81575A0", Offset = "0x8155DA0", VA = "0x1881575A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8157B80", Offset = "0x8156380", VA = "0x188157B80")]
		public ConnectableLink(AGFGMJOHUKY connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8157A60", Offset = "0x8156260", VA = "0x188157A60")]
		public ConnectableLink(AGFGMJOHUKY connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8157B00", Offset = "0x8156300", VA = "0x188157B00")]
		public ConnectableLink(AGFGMJOHUKY connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81575F0", Offset = "0x8155DF0", VA = "0x1881575F0", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x81576A0", Offset = "0x8155EA0", VA = "0x1881576A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AB37B0", Offset = "0x7AB1FB0", VA = "0x187AB37B0", Slot = "4")]
		public void Initialize(Transform transform, JSPDXWAYNZL linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8158410", Offset = "0x8156C10", VA = "0x188158410", Slot = "5")]
		public JSPDXWAYNZL SZNHCDEPMYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x81583A0", Offset = "0x8156BA0", VA = "0x1881583A0", Slot = "6")]
		public void KJXSTZNPDAT(JSPDXWAYNZL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BEAFSXJMGRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8157350", Offset = "0x8155B50", VA = "0x188157350")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x815AF30", Offset = "0x8159730", VA = "0x18815AF30")]
		public bool KPYZGQUDMCA([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x815A0E0", Offset = "0x81588E0", VA = "0x18815A0E0")]
		private bool GYIUFFVEMUX([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x815C140", Offset = "0x815A940", VA = "0x18815C140")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x815ADA0", Offset = "0x81595A0", VA = "0x18815ADA0", Slot = "5")]
		public void Initialize(DFDMTGALMVR manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x815BC80", Offset = "0x815A480", VA = "0x18815BC80", Slot = "17")]
		public void TYXCJBVUIVX(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8159280", Offset = "0x8157A80", VA = "0x188159280", Slot = "12")]
		public void DGQEUGQAJZW(Func<AGFGMJOHUKY, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8159150", Offset = "0x8157950", VA = "0x188159150")]
		private void DGQEUGQAJZW(AFOUMWXIEFH a, Func<AGFGMJOHUKY, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8159290", Offset = "0x8157A90", VA = "0x188159290", Slot = "11")]
		public void DVGLCITLNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x81594F0", Offset = "0x8157CF0", VA = "0x1881594F0", Slot = "8")]
		public bool EHHPNMJECNX(AGFGMJOHUKY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8159AF0", Offset = "0x81582F0", VA = "0x188159AF0")]
		private bool GRTLJRJACVQ(AGFGMJOHUKY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x815BCB0", Offset = "0x815A4B0", VA = "0x18815BCB0")]
		private static bool VHYFHUNQUKQ(AGFGMJOHUKY a, AFOUMWXIEFH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x815B5C0", Offset = "0x8159DC0", VA = "0x18815B5C0")]
		private void OPAITDZIEXE(Transform a, AFOUMWXIEFH b, AFOUMWXIEFH[] c, AGFGMJOHUKY d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x815A870", Offset = "0x8159070", VA = "0x18815A870")]
		private ConnectableLink HPHYVPUCFCP(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x815BAC0", Offset = "0x815A2C0", VA = "0x18815BAC0")]
		private static bool QNACKPFFEZM(AFOUMWXIEFH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x815AF40", Offset = "0x8159740", VA = "0x18815AF40", Slot = "9")]
		public bool LJDWVVKFVQV(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x815AAF0", Offset = "0x81592F0", VA = "0x18815AAF0")]
		private bool IYFAGFFRESS(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x815A690", Offset = "0x8158E90", VA = "0x18815A690")]
		private static void HAUWLSDPGFT(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e, AFOUMWXIEFH f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x815B4A0", Offset = "0x8159CA0", VA = "0x18815B4A0")]
		private void OLDTADIUDBE(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x815AEC0", Offset = "0x81596C0", VA = "0x18815AEC0")]
		private void KEKXGRMKNKO(AFOUMWXIEFH a, AGFGMJOHUKY b, AGFGMJOHUKY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x815AE50", Offset = "0x8159650", VA = "0x18815AE50")]
		private void KEKXGRMKNKO(AGFGMJOHUKY a, AGFGMJOHUKY b, AGFGMJOHUKY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x815AFA0", Offset = "0x81597A0", VA = "0x18815AFA0")]
		private void MMVOJSGACQD(AGFGMJOHUKY a, AGFGMJOHUKY b, AGFGMJOHUKY c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x815B010", Offset = "0x8159810", VA = "0x18815B010")]
		private void MMVOJSGACQD(AFOUMWXIEFH a, AGFGMJOHUKY b, AGFGMJOHUKY c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x815B9A0", Offset = "0x815A1A0", VA = "0x18815B9A0")]
		private void OQAERXPUKUW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x815BEB0", Offset = "0x815A6B0", VA = "0x18815BEB0")]
		private void ZTIUUNGKAVW(XIZDHCQMOGM a, XIZDHCQMOGM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8158F20", Offset = "0x8157720", VA = "0x188158F20", Slot = "18")]
		public AGFGMJOHUKY BDHLONXIJJT(AGFGMJOHUKY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x815B110", Offset = "0x8159910", VA = "0x18815B110", Slot = "13")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x81592B0", Offset = "0x8157AB0", VA = "0x1881592B0", Slot = "14")]
		public List<AGFGMJOHUKY> EDOEJXVHMSO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8158E50", Offset = "0x8157650", VA = "0x188158E50")]
		protected XIZDHCQMOGM AMVPWCPZIIR(XIZDHCQMOGM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8158DB0", Offset = "0x81575B0", VA = "0x188158DB0")]
		protected AFOUMWXIEFH[] ADPPUTRTPKC(AFOUMWXIEFH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x815BDA0", Offset = "0x815A5A0", VA = "0x18815BDA0")]
		protected bool ZOKYRBOHWXR(AGFGMJOHUKY a, [Out] AFOUMWXIEFH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x815A9C0", Offset = "0x81591C0", VA = "0x18815A9C0", Slot = "15")]
		public bool IWNCOTHZFIP(AGFGMJOHUKY a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x815BD60", Offset = "0x815A560", VA = "0x18815BD60")]
		protected AFOUMWXIEFH YCMRNDQRQCA(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8159500", Offset = "0x8157D00", VA = "0x188159500", Slot = "10")]
		public bool ERFDMNCGRLN(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8159560", Offset = "0x8157D60", VA = "0x188159560")]
		private bool ERMLAQJYEDU(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8159080", Offset = "0x8157880", VA = "0x188159080")]
		private static bool BKJCNVHFMGA(AFOUMWXIEFH a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x815AF30", Offset = "0x8159730", VA = "0x18815AF30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xAEB4A0", Offset = "0xAE9CA0", VA = "0x180AEB4A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAEB0A0", Offset = "0xAE98A0", VA = "0x180AEB0A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x105E1A0", Offset = "0x105C9A0", VA = "0x18105E1A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2532D10", Offset = "0x2531510", VA = "0x182532D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool RXTESWLWUXU
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> DGBDUPFTGNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x815D790", Offset = "0x815BF90", VA = "0x18815D790", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x815C2F0", Offset = "0x815AAF0", VA = "0x18815C2F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY> TXMIKIKBIHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x815DE40", Offset = "0x815C640", VA = "0x18815DE40", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x815D6D0", Offset = "0x815BED0", VA = "0x18815D6D0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<AGFGMJOHUKY, AGFGMJOHUKY, AGFGMJOHUKY> WFFYKDSIWGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x815D730", Offset = "0x815BF30", VA = "0x18815D730", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x815C910", Offset = "0x815B110", VA = "0x18815C910", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x815DF60", Offset = "0x815C760", VA = "0x18815DF60")]
		public LegacyConnectableManager(PKSJLYSCDCL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x815CBC0", Offset = "0x815B3C0", VA = "0x18815CBC0", Slot = "12")]
		public void Initialize(GameObject gameObject, JLSZHGROTDY configData, CPMIWLXZEWF rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x815C560", Offset = "0x815AD60", VA = "0x18815C560", Slot = "26")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x815DEE0", Offset = "0x815C6E0", VA = "0x18815DEE0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x815D180", Offset = "0x815B980", VA = "0x18815D180", Slot = "14")]
		public void JIBLBJTHOBM(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x815D2D0", Offset = "0x815BAD0", VA = "0x18815D2D0", Slot = "15")]
		public void KBLBKORKNFH(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x815DA30", Offset = "0x815C230", VA = "0x18815DA30", Slot = "22")]
		public bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x815CAB0", Offset = "0x815B2B0", VA = "0x18815CAB0")]
		internal bool ERMLAQJYEDU([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x815DCF0", Offset = "0x815C4F0", VA = "0x18815DCF0")]
		internal bool PXMNYNYUMUM([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x815D4F0", Offset = "0x815BCF0", VA = "0x18815D4F0")]
		internal void KYLFACHQSXK(AGFGMJOHUKY a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x815D2D0", Offset = "0x815BAD0", VA = "0x18815D2D0")]
		internal bool ZLIBTEOWURY(AGFGMJOHUKY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x815D1A0", Offset = "0x815B9A0", VA = "0x18815D1A0")]
		internal bool JTWVYECTYKI(AGFGMJOHUKY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x815DA80", Offset = "0x815C280", VA = "0x18815DA80", Slot = "16")]
		public void NUIRABILHOC(AGFGMJOHUKY a, HashSet<AGFGMJOHUKY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x815C350", Offset = "0x815AB50", VA = "0x18815C350", Slot = "17")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x815C7D0", Offset = "0x815AFD0", VA = "0x18815C7D0", Slot = "18")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x815D330", Offset = "0x815BB30", VA = "0x18815D330", Slot = "19")]
		public void KFIJVCZYUIG(AGFGMJOHUKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x815D7F0", Offset = "0x815BFF0", VA = "0x18815D7F0")]
		public void NANISWEBCWD([Optional] RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x815CA20", Offset = "0x815B220", VA = "0x18815CA20", Slot = "23")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x815DB70", Offset = "0x815C370", VA = "0x18815DB70", Slot = "20")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x815C630", Offset = "0x815AE30", VA = "0x18815C630", Slot = "21")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x815DEA0", Offset = "0x815C6A0", VA = "0x18815DEA0", Slot = "25")]
		public void SNNKNRTIIDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x815C970", Offset = "0x815B170", VA = "0x18815C970", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x8168AA0", Offset = "0x81672A0", VA = "0x188168AA0")]
		public RWVYLJXKMPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8168A40", Offset = "0x8167240", VA = "0x188168A40")]
		public void TGYFCWTIYIH(AGFGMJOHUKY a, AGFGMJOHUKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8168960", Offset = "0x8167160", VA = "0x188168960")]
		public void JKJIJWSEHJL(AGFGMJOHUKY a, AGFGMJOHUKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x81689C0", Offset = "0x81671C0", VA = "0x1881689C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public SMESNHOGLUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8168CB0", Offset = "0x81674B0", VA = "0x188168CB0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8168CA0", Offset = "0x81674A0", VA = "0x188168CA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8168F50", Offset = "0x8167750", VA = "0x188168F50")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8168EE0", Offset = "0x81676E0", VA = "0x188168EE0")]
		private void OnMasterClientSwitched(RHIZVYSCBOY newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8168BA0", Offset = "0x81673A0", VA = "0x188168BA0")]
		public void BJKCMEPQKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8168DE0", Offset = "0x81675E0", VA = "0x188168DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8168900", Offset = "0x8167100", VA = "0x188168900")]
			internal LegacyConnectableManager ZHGQFSSNUYI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x816AA40", Offset = "0x8169240", VA = "0x18816AA40")]
		public static void RPHUHHYIUOY(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x816A9C0", Offset = "0x81691C0", VA = "0x18816A9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x815F0B0", Offset = "0x815D8B0", VA = "0x18815F0B0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x815E2F0", Offset = "0x815CAF0", VA = "0x18815E2F0", Slot = "7")]
		public void Initialize(TKMWUFXTASH graph, OQSRVZQXFLR creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x815E330", Offset = "0x815CB30", VA = "0x18815E330", Slot = "5")]
		public void KFTFIUYYTHO(XIZDHCQMOGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x815EE10", Offset = "0x815D610", VA = "0x18815EE10", Slot = "9")]
		public void VZQIGFQCVED(XIZDHCQMOGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x815EC50", Offset = "0x815D450", VA = "0x18815EC50", Slot = "8")]
		public void TEMMRMBKTCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x815E700", Offset = "0x815CF00", VA = "0x18815E700", Slot = "10")]
		public void PXFUCDNJLQA(XIZDHCQMOGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x815E950", Offset = "0x815D150", VA = "0x18815E950", Slot = "11")]
		public void SEAMBBERDTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x815EAA0", Offset = "0x815D2A0", VA = "0x18815EAA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x81692F0", Offset = "0x8167AF0", VA = "0x1881692F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8169830", Offset = "0x8168030", VA = "0x188169830")]
			public SerializeNodeInSubgraph(AFOUMWXIEFH currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] PHAWDGNAYSX parentNodeData, [Optional] PHAWDGNAYSX rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8169150", Offset = "0x8167950", VA = "0x188169150")]
			public PHAWDGNAYSX JVPEYACKYLR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8169570", Offset = "0x8167D70", VA = "0x188169570")]
			private PHAWDGNAYSX VIZNFRPBGJF([Out] PHAWDGNAYSX a, [Out] PHAWDGNAYSX b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8169630", Offset = "0x8167E30", VA = "0x188169630")]
			private PHAWDGNAYSX XSEJWUVXFJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8169400", Offset = "0x8167C00", VA = "0x188169400")]
			private void UDSWBMNZLBN(PHAWDGNAYSX a, PHAWDGNAYSX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8168F90", Offset = "0x8167790", VA = "0x188168F90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8161470", Offset = "0x815FC70", VA = "0x188161470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool EYANGEXKSND
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x81614C0", Offset = "0x815FCC0", VA = "0x1881614C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x81604D0", Offset = "0x815ECD0", VA = "0x1881604D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x81601B0", Offset = "0x815E9B0", VA = "0x1881601B0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8161300", Offset = "0x815FB00", VA = "0x188161300")]
		public ConnectableGraphData PASAQREWFZV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x815F720", Offset = "0x815DF20", VA = "0x18815F720")]
		public ConnectableGraphData CCEHAZYFNAF(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x815F960", Offset = "0x815E160", VA = "0x18815F960")]
		public void EKNAQKCCPGQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x815F8C0", Offset = "0x815E0C0", VA = "0x18815F8C0")]
		public void CZNOYMWDOIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8161C50", Offset = "0x8160450", VA = "0x188161C50")]
		public void ZVIOIXDHNGY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x815FAE0", Offset = "0x815E2E0", VA = "0x18815FAE0")]
		private void FJTTXOWFPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x815FCC0", Offset = "0x815E4C0", VA = "0x18815FCC0")]
		private PHAWDGNAYSX GFZDZZGWUIP(AFOUMWXIEFH a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8160220", Offset = "0x815EA20", VA = "0x188160220")]
		private static void KBRTHJJLTLV(AFOUMWXIEFH a, bool b, PHAWDGNAYSX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x815FDA0", Offset = "0x815E5A0", VA = "0x18815FDA0")]
		private void HXRUMCCFPIA(AFOUMWXIEFH a, bool b, PHAWDGNAYSX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8161270", Offset = "0x815FA70", VA = "0x188161270")]
		private PHAWDGNAYSX OKZEPPVQWYF(AFOUMWXIEFH a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x81619B0", Offset = "0x81601B0", VA = "0x1881619B0")]
		private bool YDPMQDGHASN(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8160C00", Offset = "0x815F400", VA = "0x188160C00")]
		private bool NXNBGZIBTDW(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8161C30", Offset = "0x8160430", VA = "0x188161C30")]
		private bool YHMPZVMCCCK(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x815F610", Offset = "0x815DE10", VA = "0x18815F610")]
		private static bool BAYQTMXJFTR(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8160930", Offset = "0x815F130", VA = "0x188160930")]
		public static bool NGWJXHFMSQP(PHAWDGNAYSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x81614E0", Offset = "0x815FCE0", VA = "0x1881614E0")]
		private AGFGMJOHUKY RQEVNKDTRKB(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x81607B0", Offset = "0x815EFB0", VA = "0x1881607B0")]
		private AGFGMJOHUKY MMZOWQRAYGH(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8161820", Offset = "0x8160020", VA = "0x188161820")]
		private AGFGMJOHUKY XQCOJZLQUWG(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8160BC0", Offset = "0x815F3C0", VA = "0x188160BC0")]
		private static Guid NLYKRGMAUSI(PHAWDGNAYSX a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x815F9F0", Offset = "0x815E1F0", VA = "0x18815F9F0")]
		private string EZXWHAEJDVT(PHAWDGNAYSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x815FFC0", Offset = "0x815E7C0", VA = "0x18815FFC0")]
		private bool IXGEZSJIMXW(AFOUMWXIEFH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x81604F0", Offset = "0x815ECF0", VA = "0x1881604F0")]
		private static void KYKZGORAZVE(AFOUMWXIEFH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x8157BE0", Offset = "0x81563E0", VA = "0x188157BE0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink PGPCQFFQPWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8157C80", Offset = "0x8156480", VA = "0x188157C80")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8157CB0", Offset = "0x81564B0", VA = "0x188157CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public MKCLAVTPTUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x815F4D0", Offset = "0x815DCD0", VA = "0x18815F4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x46C19C0", Offset = "0x46C01C0", VA = "0x1846C19C0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8156AA0", Offset = "0x81552A0", VA = "0x188156AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private AFOUMWXIEFH HJMDDSQJNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x81569C0", Offset = "0x81551C0", VA = "0x1881569C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public XIZDHCQMOGM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public AGFGMJOHUKY HMULSBXUUFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WRRYAERZEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8156C10", Offset = "0x8155410", VA = "0x188156C10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool OXQLXFQTEJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8156820", Offset = "0x8155020", VA = "0x188156820", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected AFOUMWXIEFH OQYAWLRTKSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8157030", Offset = "0x8155830", VA = "0x188157030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x81572B0", Offset = "0x8155AB0", VA = "0x1881572B0")]
		public AFOUMWXIEFH(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8156AD0", Offset = "0x81552D0", VA = "0x188156AD0")]
		public AFOUMWXIEFH JHPMQEXBLAQ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8156C20", Offset = "0x8155420", VA = "0x188156C20")]
		public AFOUMWXIEFH PVNPYSKZNGY(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8156DA0", Offset = "0x81555A0", VA = "0x188156DA0")]
		public AFOUMWXIEFH Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8156870", Offset = "0x8155070", VA = "0x188156870")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8156F80", Offset = "0x8155780", VA = "0x188156F80")]
		public AFOUMWXIEFH Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8157050", Offset = "0x8155850", VA = "0x188157050")]
		private static void TYXCJBVUIVX(AFOUMWXIEFH a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x81571B0", Offset = "0x81559B0", VA = "0x1881571B0", Slot = "9")]
		public void TYXCJBVUIVX(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x81571C0", Offset = "0x81559C0", VA = "0x1881571C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8157E70", Offset = "0x8156670", VA = "0x188157E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8157EC0", Offset = "0x81566C0", VA = "0x188157EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8157F00", Offset = "0x8156700", VA = "0x188157F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8169E60", Offset = "0x8168660", VA = "0x188169E60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8169AF0", Offset = "0x81682F0", VA = "0x188169AF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView MFEJFLHFAPV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8169B30", Offset = "0x8168330", VA = "0x188169B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> VNYLEPNTAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8169D30", Offset = "0x8168530", VA = "0x188169D30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x816A610", Offset = "0x8168E10", VA = "0x18816A610", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<RHIZVYSCBOY> REGNHEHWFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x81698A0", Offset = "0x81680A0", VA = "0x1881698A0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8169DC0", Offset = "0x81685C0", VA = "0x188169DC0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8169A60", Offset = "0x8168260", VA = "0x188169A60", Slot = "10")]
		public void BDNHZJHRRDD(LegacyConnectableManager a, CPMIWLXZEWF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8169CE0", Offset = "0x81684E0", VA = "0x188169CE0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8169940", Offset = "0x8168140", VA = "0x188169940", Slot = "11")]
		public void AMONYRVAZEQ(AGFGMJOHUKY a, AGFGMJOHUKY b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8169BC0", Offset = "0x81683C0", VA = "0x188169BC0", Slot = "12")]
		public void CQFEWFSSHZW(AGFGMJOHUKY a, int b, AGFGMJOHUKY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x816A6A0", Offset = "0x8168EA0", VA = "0x18816A6A0", Slot = "13")]
		public void XIUNGRNCHNT(ConnectableGraphData a, [Optional] RHIZVYSCBOY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x816A0F0", Offset = "0x81688F0", VA = "0x18816A0F0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(AGFGMJOHUKY objectToReparent, int objectToReparentSlotIndex, AGFGMJOHUKY newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8169F00", Offset = "0x8168700", VA = "0x188169F00")]
		[RPCMethod]
		private void RpcMasterModifyNode(AGFGMJOHUKY connectableToModify, AGFGMJOHUKY expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x816A4E0", Offset = "0x8168CE0", VA = "0x18816A4E0")]
		[RPCMethod]
		private void RpcReparentNodes(AGFGMJOHUKY objectToReparent, int objectToReparentSlotIndex, AGFGMJOHUKY newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x816A3F0", Offset = "0x8168BF0", VA = "0x18816A3F0")]
		[RPCMethod]
		private void RpcModifyNode(AGFGMJOHUKY connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8169EC0", Offset = "0x81686C0", VA = "0x188169EC0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8158C30", Offset = "0x8157430", VA = "0x188158C30", Slot = "4")]
		private void YCHHWCBCBJC(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x81589C0", Offset = "0x81571C0", VA = "0x1881589C0", Slot = "5")]
		private void QQOIMHNZIQA(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x81584D0", Offset = "0x8156CD0", VA = "0x1881584D0", Slot = "6")]
		private void DUGPSZDPURX(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8158770", Offset = "0x8156F70", VA = "0x188158770", Slot = "7")]
		private void GYWEAZJLCOX(AGFGMJOHUKY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8158700", Offset = "0x8156F00", VA = "0x188158700", Slot = "8")]
		private JSPDXWAYNZL FXHERPNYYNI(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8158960", Offset = "0x8157160", VA = "0x188158960", Slot = "9")]
		private void HJSXQDGNENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class WUMFLYBVBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCEF0", Offset = "0x3BCB6F0", VA = "0x183BCCEF0")]
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
