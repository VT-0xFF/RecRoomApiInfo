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
		[Cpp2IlInjected.Address(RVA = "0x843DE60", Offset = "0x843CC60", VA = "0x18843DE60", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		private int[] TDVEOKFWPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] TEALLQZTYYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GMAWWHUIGYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset GLVPZBAKXNC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x200DEC0", Offset = "0x200CCC0", VA = "0x18200DEC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84492E0", Offset = "0x84480E0", VA = "0x1884492E0")]
		private void BUNBWTHGJFJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8449190", Offset = "0x8447F90", VA = "0x188449190")]
		private void BUHUZMNIZUA(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8449430", Offset = "0x8448230", VA = "0x188449430", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8449740", Offset = "0x8448540", VA = "0x188449740")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : JBFSYLTXFHA, CZJXGPXNOFX
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class FLDSSOAREAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DHZNTPEYEJU IRPWFCSERHC;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public FLDSSOAREAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x84357A0", Offset = "0x84345A0", VA = "0x1884357A0")]
			internal object NIIQMBZUVWX(DHZNTPEYEJU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class FLIZPUUONLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DHZNTPEYEJU SNVIICURRUK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FLDSSOAREAE CNVJRMTDZSZ;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public FLIZPUUONLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8435810", Offset = "0x8434610", VA = "0x188435810")]
			internal object NIDJOVFXMLO((DHZNTPEYEJU child, DHZNTPEYEJU nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KFCJPJOVPMH : IEnumerable<PVPFAMGHTSL>, IEnumerable, IEnumerator<PVPFAMGHTSL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private PVPFAMGHTSL LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId ZVXAZEZLZCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId CPLVJXJIPJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private MHGARTSMGWH CXZPTOFSIFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray CSINKPMQJWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator NVAWWOTZFNA;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private PVPFAMGHTSL LKAPXOJSXVT
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public KFCJPJOVPMH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8436400", Offset = "0x8435200", VA = "0x188436400", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84360A0", Offset = "0x8434EA0", VA = "0x1884360A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8436080", Offset = "0x8434E80", VA = "0x188436080")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8436060", Offset = "0x8434E60", VA = "0x188436060")]
			private void GWCOUVMHXEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84364E0", Offset = "0x84352E0", VA = "0x1884364E0", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8435FB0", Offset = "0x8434DB0", VA = "0x188435FB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PVPFAMGHTSL> GIRMSEGQTKS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8435FB0", Offset = "0x8434DB0", VA = "0x188435FB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log NNVXYQGITOP;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log QJVVHPJAFRN;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log NUATANIBFYL;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log FRCZXXULODZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private QONONHQRGHQ WJTQZWLMZSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TWQMZHPWAXH RBRESLWJZJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MWHGTXWITII QWIKHPYVULR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JTFADDOJRVU FDATSQVYVNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private KZGIBFRRASS IVDTUMEUCJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JRVNUGMTSYS AKHCSKYOMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly RNLUAAILCMH PQDMHSXVIHK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool VPERIKUXOYP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD1370", Offset = "0xAD0170", VA = "0x180AD1370", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAD1280", Offset = "0xAD0080", VA = "0x180AD1280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NUTHRPUVLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL> MESYNRIQNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8440C20", Offset = "0x843FA20", VA = "0x188440C20", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8440CD0", Offset = "0x843FAD0", VA = "0x188440CD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL> SIOUJZROEIE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x843F3B0", Offset = "0x843E1B0", VA = "0x18843F3B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x84434D0", Offset = "0x84422D0", VA = "0x1884434D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL, PVPFAMGHTSL> OLSCLIEQLQE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x843F620", Offset = "0x843E420", VA = "0x18843F620", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x843F460", Offset = "0x843E260", VA = "0x18843F460", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8443A20", Offset = "0x8442820", VA = "0x188443A20")]
		public OMConnectableManager(TNEKCCANHHI container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8440D80", Offset = "0x843FB80", VA = "0x188440D80", Slot = "12")]
		public void Initialize(GameObject gameObject, AKGDOQXYEOF configData, EADKAXNIXSO sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8443300", Offset = "0x8442100", VA = "0x188443300", Slot = "26")]
		public void VZXWUYBQFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8443580", Offset = "0x8442380", VA = "0x188443580", Slot = "22")]
		public bool YCWOIMOSGUA(DHZNTPEYEJU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8441400", Offset = "0x8440200", VA = "0x188441400")]
		private void NAKHMSYOHLT(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8440910", Offset = "0x843F710", VA = "0x188440910")]
		private void FXTGOHNMAZZ(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84424B0", Offset = "0x84412B0", VA = "0x1884424B0")]
		private void SWZFRQNTFQF(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84418D0", Offset = "0x84406D0", VA = "0x1884418D0")]
		private void PCMNJYLNTGC(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x843F950", Offset = "0x843E750", VA = "0x18843F950", Slot = "14")]
		public void DELFABVRANX(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "15")]
		public void LWTDSZSZCOS(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8441CE0", Offset = "0x8440AE0", VA = "0x188441CE0", Slot = "17")]
		public void PVXSSMKGYFL(PVPFAMGHTSL a, PVPFAMGHTSL b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8441E40", Offset = "0x8440C40", VA = "0x188441E40")]
		public void PVXSSMKGYFL(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8441670", Offset = "0x8440470", VA = "0x188441670")]
		public void NYPZEBEPHSX(PVPFAMGHTSL a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8443710", Offset = "0x8442510", VA = "0x188443710", Slot = "18")]
		public void YDJUSHEKBJV(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x843F570", Offset = "0x843E370", VA = "0x18843F570")]
		private float BMJCZGGLIYJ(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84435D0", Offset = "0x84423D0", VA = "0x1884435D0")]
		public void YDJUSHEKBJV(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8443000", Offset = "0x8441E00", VA = "0x188443000", Slot = "19")]
		public void UHNZWGYUXTN(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x843F1B0", Offset = "0x843DFB0", VA = "0x18843F1B0", Slot = "16")]
		public void AGASFDYRHIN(PVPFAMGHTSL a, HashSet<PVPFAMGHTSL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "20")]
		public ConnectableGraphData ITSKXTXFKMW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "21")]
		public ConnectableGraphData YNGIMKPXXPU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8440FF0", Offset = "0x843FDF0", VA = "0x188440FF0", Slot = "23")]
		public void JUWLLZLPVVF(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8441200", Offset = "0x8440000", VA = "0x188441200", Slot = "24")]
		public void LSQCFAVCRTR(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84408F0", Offset = "0x843F6F0", VA = "0x1884408F0", Slot = "25")]
		public void FXCLDKUORSY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x843FC50", Offset = "0x843EA50", VA = "0x18843FC50")]
		private void DPBXHZTODVJ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8442710", Offset = "0x8441510", VA = "0x188442710")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8441F80", Offset = "0x8440D80", VA = "0x188441F80")]
		private void PXSLKWCZSXO(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8441170", Offset = "0x843FF70", VA = "0x188441170")]
		[IteratorStateMachine(typeof(KFCJPJOVPMH))]
		public IEnumerable<PVPFAMGHTSL> LRTZAULYUOV(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8442380", Offset = "0x8441180", VA = "0x188442380")]
		internal PVPFAMGHTSL QEALKHVYSKS(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84401E0", Offset = "0x843EFE0", VA = "0x1884401E0")]
		internal ObjectLocalId ENFJZLGOBMG(PVPFAMGHTSL a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8440370", Offset = "0x843F170", VA = "0x188440370")]
		private bool EOWLLBPPFSP(DHZNTPEYEJU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x843F510", Offset = "0x843E310", VA = "0x18843F510")]
		private bool BFLBGPRWUFZ(DHZNTPEYEJU a, [Out] PVPFAMGHTSL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8441FF0", Offset = "0x8440DF0", VA = "0x188441FF0")]
		private PVPFAMGHTSL QEALKHVYSKS(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x843F030", Offset = "0x843DE30", VA = "0x18843F030")]
		private PVPFAMGHTSL ACNHISTRPLJ(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8441700", Offset = "0x8440500", VA = "0x188441700")]
		private PVPFAMGHTSL OLOKCKPXZGQ(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8443870", Offset = "0x8442670", VA = "0x188443870")]
		private static Guid YLHZCQHYOOJ(DHZNTPEYEJU a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8440B30", Offset = "0x843F930", VA = "0x188440B30")]
		private string GQETOSPJVJC(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8443170", Offset = "0x8441F70", VA = "0x188443170")]
		private void UKCXBMCPHRB(PVPFAMGHTSL a, PVPFAMGHTSL b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8440050", Offset = "0x843EE50", VA = "0x188440050")]
		private void EJMXXOYBRPH(PVPFAMGHTSL a, PVPFAMGHTSL b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8441610", Offset = "0x8440410", VA = "0x188441610")]
		private void NVMNDNZXMUP(PVPFAMGHTSL a, PVPFAMGHTSL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8441270", Offset = "0x8440070", VA = "0x188441270")]
		private void LTUJOLTMNDI(PVPFAMGHTSL a, PVPFAMGHTSL b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8441060", Offset = "0x843FE60", VA = "0x188441060")]
		private void KIOCROKPHPN(ObjectLocalId a, PVPFAMGHTSL b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x843F6D0", Offset = "0x843E4D0", VA = "0x18843F6D0")]
		private void CUFBZWSEQDK(ObjectLocalId a, PVPFAMGHTSL b, PVPFAMGHTSL c, PVPFAMGHTSL d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ERPPUNDNUCF
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TNEKCCANHHI container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8449090", Offset = "0x8447E90", VA = "0x188449090")]
			internal OMConnectableManager MXIQXMZCEJZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8435630", Offset = "0x8434430", VA = "0x188435630")]
		public static void MYMPJKKOGIL(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84355E0", Offset = "0x84343E0", VA = "0x1884355E0")]
		public static void IDVWKYHBCJS(TNEKCCANHHI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : BGXWGXNKULB, AFDYXFIAEDQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager AFOBJKGTMSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly SSKMPTUMYXX FTQZFUHMUYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly MOWEQOWSZQD FDATSQVYVNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly WCBBWNMHRUH[] XDEORLBWOPB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PVPFAMGHTSL ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8445630", Offset = "0x8444430", VA = "0x188445630", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PVPFAMGHTSL NVIWQPZEQEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8444280", Offset = "0x8443080", VA = "0x188444280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 ECYAPXCEWSC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8444390", Offset = "0x8443190", VA = "0x188444390", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion QMZDPCKUTEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84448C0", Offset = "0x84436C0", VA = "0x1884448C0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool WQZVZJDQSVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8444850", Offset = "0x8443650", VA = "0x188444850", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<PVPFAMGHTSL> AYXSQBEGIZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8445390", Offset = "0x8444190", VA = "0x188445390", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool YKWZMBYLMPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB6CC80", Offset = "0xB6BA80", VA = "0x180B6CC80", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC4E250", Offset = "0xC4D050", VA = "0x180C4E250", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8445830", Offset = "0x8444630", VA = "0x188445830", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8445550", Offset = "0x8444350", VA = "0x188445550", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8445570", Offset = "0x8444370", VA = "0x188445570", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8445690", Offset = "0x8444490", VA = "0x188445690", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8445770", Offset = "0x8444570", VA = "0x188445770", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool LBTYBRJUQCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x84443F0", Offset = "0x84431F0", VA = "0x1884443F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler NKQTDVKDPAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8443AC0", Offset = "0x84428C0", VA = "0x188443AC0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8444940", Offset = "0x8443740", VA = "0x188444940", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler AQMSLPPFFBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8445250", Offset = "0x8444050", VA = "0x188445250", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8444340", Offset = "0x8443140", VA = "0x188444340", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler PNQTPOMNZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8443C80", Offset = "0x8442A80", VA = "0x188443C80", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84452A0", Offset = "0x84440A0", VA = "0x1884452A0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler UGOKHYFMUJC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x84451B0", Offset = "0x8443FB0", VA = "0x1884451B0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8443FE0", Offset = "0x8442DE0", VA = "0x188443FE0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8445450", Offset = "0x8444250", VA = "0x188445450")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, SSKMPTUMYXX connectableTool, WCBBWNMHRUH[] connectionPoints, MOWEQOWSZQD callbacks, JBFSYLTXFHA connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8443A90", Offset = "0x8442890", VA = "0x188443A90", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "21")]
		public void OUSDXNTMYBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8444920", Offset = "0x8443720", VA = "0x188444920", Slot = "22")]
		public void QQOFHYYUHWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8445090", Offset = "0x8443E90", VA = "0x188445090", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8444E80", Offset = "0x8443C80", VA = "0x188444E80", Slot = "25")]
		public void SKVBZZLUTOO(int a, PVPFAMGHTSL b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84450E0", Offset = "0x8443EE0", VA = "0x1884450E0", Slot = "26")]
		public void TMWEVIGUDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8444990", Offset = "0x8443790", VA = "0x188444990", Slot = "27")]
		public void RDJJFFWQVUQ(int a, PVPFAMGHTSL b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8443B10", Offset = "0x8442910", VA = "0x188443B10", Slot = "28")]
		public void CWKOYPHUYZU(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8444440", Offset = "0x8443240", VA = "0x188444440", Slot = "31")]
		public void NXWIHJFGZNV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8443CD0", Offset = "0x8442AD0", VA = "0x188443CD0", Slot = "29")]
		public void FUOERQCMEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8444C70", Offset = "0x8443A70", VA = "0x188444C70", Slot = "30")]
		public void RMORZHFKWHI(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84441B0", Offset = "0x8442FB0", VA = "0x1884441B0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8444080", Offset = "0x8442E80", VA = "0x188444080", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB2EE70", Offset = "0xB2DC70", VA = "0x180B2EE70", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8443B90", Offset = "0x8442990", VA = "0x188443B90", Slot = "43")]
		public bool CanConnectTo(int slotIndex, PVPFAMGHTSL otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "44")]
		public void ParentChanged(int slotIndex, PVPFAMGHTSL newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "45")]
		public void ChildAdded(int slotIndex, PVPFAMGHTSL newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "46")]
		public void ChildRemoved(int slotIndex, PVPFAMGHTSL removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "47")]
		public void ConnectionModified(int slotIndex, PVPFAMGHTSL parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8444E60", Offset = "0x8443C60", VA = "0x188444E60", Slot = "48")]
		public void RootChanged(PVPFAMGHTSL previousRootConnectable, PVPFAMGHTSL newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8445340", Offset = "0x8444140", VA = "0x188445340", Slot = "23")]
		public void XSEEMYTKGWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84452F0", Offset = "0x84440F0", VA = "0x1884452F0", Slot = "24")]
		public void XDGMORWJYEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8443C30", Offset = "0x8442A30", VA = "0x188443C30")]
		private void DWNNYCYSXUN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(ABSPAKGPPHU), new string[] { })]
	public class ZBKZTQDZCOP : ABSPAKGPPHU, KCNRTBNFQOT, XREDDEZXVJN
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IRPKOOLLDLU
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IRPKOOLLDLU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private ZTBNBAQPGMG DRXTGXCTIUV;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object YXVBVPFGQZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8448F90", Offset = "0x8447D90", VA = "0x188448F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8448F40", Offset = "0x8447D40", VA = "0x188448F40", Slot = "5")]
		private void GXDLTINPSCT(ODEDMYTJIPB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xD28E80", Offset = "0xD27C80", VA = "0x180D28E80", Slot = "6")]
		private void WXTEKSAVTDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public ZBKZTQDZCOP()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(JBFSYLTXFHA), new string[] { "Ignore", "Mock" })]
	public class SLTKDRDRMQL : JBFSYLTXFHA, CZJXGPXNOFX
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool VPERIKUXOYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NUTHRPUVLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL> MESYNRIQNKK
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x84480E0", Offset = "0x8446EE0", VA = "0x1884480E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8448190", Offset = "0x8446F90", VA = "0x188448190", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL> SIOUJZROEIE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8447ED0", Offset = "0x8446CD0", VA = "0x188447ED0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8448240", Offset = "0x8447040", VA = "0x188448240", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL, PVPFAMGHTSL> OLSCLIEQLQE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8448030", Offset = "0x8446E30", VA = "0x188448030", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8447F80", Offset = "0x8446D80", VA = "0x188447F80", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "26")]
		public void VZXWUYBQFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "12")]
		public void Initialize(GameObject gameObject, AKGDOQXYEOF configData, EADKAXNIXSO rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "14")]
		public void DELFABVRANX(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "15")]
		public void LWTDSZSZCOS(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "16")]
		public void AGASFDYRHIN(PVPFAMGHTSL a, HashSet<PVPFAMGHTSL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "17")]
		public void PVXSSMKGYFL(PVPFAMGHTSL a, PVPFAMGHTSL b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "18")]
		public void YDJUSHEKBJV(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "19")]
		public void UHNZWGYUXTN(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "20")]
		public ConnectableGraphData ITSKXTXFKMW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "21")]
		public ConnectableGraphData YNGIMKPXXPU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "22")]
		public bool YCWOIMOSGUA(DHZNTPEYEJU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "23")]
		public void JUWLLZLPVVF(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "24")]
		public void LSQCFAVCRTR(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "25")]
		public void FXCLDKUORSY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public SLTKDRDRMQL()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PVPFAMGHTSL : AFDYXFIAEDQ, IEquatable<PVPFAMGHTSL>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface AFDYXFIAEDQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		PVPFAMGHTSL ParentConnectable
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
		bool CanConnectTo(int slotIndex, PVPFAMGHTSL otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, PVPFAMGHTSL newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, PVPFAMGHTSL newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, PVPFAMGHTSL removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, PVPFAMGHTSL parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(PVPFAMGHTSL previousRootConnectable, PVPFAMGHTSL newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JBFSYLTXFHA : CZJXGPXNOFX
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool VPERIKUXOYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool NUTHRPUVLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<PVPFAMGHTSL, PVPFAMGHTSL> MESYNRIQNKK;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<PVPFAMGHTSL, PVPFAMGHTSL> SIOUJZROEIE;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<PVPFAMGHTSL, PVPFAMGHTSL, PVPFAMGHTSL> OLSCLIEQLQE;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, AKGDOQXYEOF configData, EADKAXNIXSO rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DELFABVRANX(PVPFAMGHTSL a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void LWTDSZSZCOS(PVPFAMGHTSL a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void AGASFDYRHIN(PVPFAMGHTSL a, HashSet<PVPFAMGHTSL> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PVXSSMKGYFL(PVPFAMGHTSL a, PVPFAMGHTSL b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void YDJUSHEKBJV(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void UHNZWGYUXTN(PVPFAMGHTSL a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData ITSKXTXFKMW(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData YNGIMKPXXPU(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool YCWOIMOSGUA(DHZNTPEYEJU a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void JUWLLZLPVVF(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void LSQCFAVCRTR(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void FXCLDKUORSY(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface JTFADDOJRVU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PVPFAMGHTSL OLOKCKPXZGQ(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PVPFAMGHTSL ACNHISTRPLJ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool QOTHFKMQNRN(PVPFAMGHTSL a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool MCDRTRDUKJD();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UTZJZPMVPCG(PVPFAMGHTSL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MOWEQOWSZQD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LBTYBRJUQCR(SSKMPTUMYXX a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ULPYNFEQIDW(SSKMPTUMYXX a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string CVHACJHFSRV(SSKMPTUMYXX a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid VPBIXRZIBCG(SSKMPTUMYXX a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int IEMYUWQSKRN(SSKMPTUMYXX a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VMJGXKXLXEO(SSKMPTUMYXX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(PVPFAMGHTSL childConnectable, int childConnectableSlot, PVPFAMGHTSL parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(PVPFAMGHTSL previousRootConnectable, PVPFAMGHTSL newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface SSKMPTUMYXX : PVPFAMGHTSL, AFDYXFIAEDQ, IEquatable<PVPFAMGHTSL>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface BGXWGXNKULB : AFDYXFIAEDQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		PVPFAMGHTSL NVIWQPZEQEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<PVPFAMGHTSL> AYXSQBEGIZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 ECYAPXCEWSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion QMZDPCKUTEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool WQZVZJDQSVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool YKWZMBYLMPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler NKQTDVKDPAI;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler AQMSLPPFFBQ;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler PNQTPOMNZEJ;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler UGOKHYFMUJC;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void OUSDXNTMYBU();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void QQOFHYYUHWL();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void XSEEMYTKGWM();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void XDGMORWJYEX();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void SKVBZZLUTOO(int a, PVPFAMGHTSL b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void TMWEVIGUDBM();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void RDJJFFWQVUQ(int a, PVPFAMGHTSL b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void CWKOYPHUYZU(PVPFAMGHTSL a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void FUOERQCMEDP();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void RMORZHFKWHI(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void NXWIHJFGZNV(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface WCBBWNMHRUH
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 ARWGTCBHEGS
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
	public interface AKGDOQXYEOF
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool UBGMFGEENTF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		TSGDURFHOXU ESNXTXXGAIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, AKGDOQXYEOF
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
		public bool UBGMFGEENTF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xC70C00", Offset = "0xC6FA00", VA = "0x180C70C00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public TSGDURFHOXU ESNXTXXGAIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84349B0", Offset = "0x84337B0", VA = "0x1884349B0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8434A70", Offset = "0x8433870", VA = "0x188434A70")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PVPFAMGHTSL connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x8435050", Offset = "0x8433E50", VA = "0x188435050")]
		public ConnectableLink(PVPFAMGHTSL connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8434FB0", Offset = "0x8433DB0", VA = "0x188434FB0")]
		public ConnectableLink(PVPFAMGHTSL connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8434F20", Offset = "0x8433D20", VA = "0x188434F20")]
		public ConnectableLink(PVPFAMGHTSL connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8434AC0", Offset = "0x84338C0", VA = "0x188434AC0", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8434B70", Offset = "0x8433970", VA = "0x188434B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : QENBQKMCBRI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform SKWHCKDVCZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TSGDURFHOXU PYNOHPDGVDU;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7D615A0", Offset = "0x7D603A0", VA = "0x187D615A0", Slot = "4")]
		public void Initialize(Transform transform, TSGDURFHOXU linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84370C0", Offset = "0x8435EC0", VA = "0x1884370C0", Slot = "5")]
		public TSGDURFHOXU ZEHSNGCLUWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8437050", Offset = "0x8435E50", VA = "0x188437050", Slot = "6")]
		public void LDMCWRKCYOC(TSGDURFHOXU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, XQINYDNRZCG
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class JBJUYEWRLZL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public PVPFAMGHTSL SLARWYCJKCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public PVPFAMGHTSL PDFCVOREJDW;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public JBJUYEWRLZL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8435BE0", Offset = "0x84349E0", VA = "0x188435BE0")]
			internal bool PAIZHIFCQPA(EJIUDDQOFKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly KLGVNHNGDVY OIQGEZFQMYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LBQVHDQUZSR NIIXSLFLLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JXROXNTZCZB VFUMHXQQSZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool QGIOMTTAVJZ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log ZEXUJUSLMGJ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public EJIUDDQOFKB JNMQCQBFHQM
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84389F0", Offset = "0x84377F0", VA = "0x1884389F0")]
		public bool FISCUYBRPLJ([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8438AD0", Offset = "0x84378D0", VA = "0x188438AD0")]
		private bool HIVVDWYGGNA([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x843AE10", Offset = "0x8439C10", VA = "0x18843AE10")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84390F0", Offset = "0x8437EF0", VA = "0x1884390F0", Slot = "5")]
		public void Initialize(JBFSYLTXFHA manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x843A1A0", Offset = "0x8438FA0", VA = "0x18843A1A0", Slot = "17")]
		public void WDURAMQZPUO(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8439420", Offset = "0x8438220", VA = "0x188439420", Slot = "12")]
		public void KHWVUKCFZDD(Func<PVPFAMGHTSL, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x84392F0", Offset = "0x84380F0", VA = "0x1884392F0")]
		private void KHWVUKCFZDD(KLGVNHNGDVY a, Func<PVPFAMGHTSL, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x843A180", Offset = "0x8438F80", VA = "0x18843A180", Slot = "11")]
		public void VNLDREQVFEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8439430", Offset = "0x8438230", VA = "0x188439430", Slot = "8")]
		public bool MOFXZLMYNLM(PVPFAMGHTSL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x843A390", Offset = "0x8439190", VA = "0x18843A390")]
		private bool XNRKLHSWWSL(PVPFAMGHTSL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8439E60", Offset = "0x8438C60", VA = "0x188439E60")]
		private static bool SUOKBMKIKBL(PVPFAMGHTSL a, KLGVNHNGDVY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8439920", Offset = "0x8438720", VA = "0x188439920")]
		private void RHTWVHVUZYF(Transform a, KLGVNHNGDVY b, KLGVNHNGDVY[] c, PVPFAMGHTSL d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84391A0", Offset = "0x8437FA0", VA = "0x1884391A0")]
		private ConnectableLink KBOYNFWRHQE(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x843A1D0", Offset = "0x8438FD0", VA = "0x18843A1D0")]
		private static bool XIZFJNLMFZZ(KLGVNHNGDVY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8439090", Offset = "0x8437E90", VA = "0x188439090", Slot = "9")]
		public bool ILZCKUNEHFU(PVPFAMGHTSL a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8439670", Offset = "0x8438470", VA = "0x188439670")]
		private bool PBRAHSOHEAH(PVPFAMGHTSL a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8438810", Offset = "0x8437610", VA = "0x188438810")]
		private static void ERLPBMJHOWC(PVPFAMGHTSL a, int b, int c, Vector3 d, Quaternion e, KLGVNHNGDVY f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8439F10", Offset = "0x8438D10", VA = "0x188439F10")]
		private void UKCXBMCPHRB(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x843A9F0", Offset = "0x84397F0", VA = "0x18843A9F0")]
		private void XXJRJOGBWBV(KLGVNHNGDVY a, PVPFAMGHTSL b, PVPFAMGHTSL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x843A980", Offset = "0x8439780", VA = "0x18843A980")]
		private void XXJRJOGBWBV(PVPFAMGHTSL a, PVPFAMGHTSL b, PVPFAMGHTSL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8437DF0", Offset = "0x8436BF0", VA = "0x188437DF0")]
		private void CUFBZWSEQDK(PVPFAMGHTSL a, PVPFAMGHTSL b, PVPFAMGHTSL c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8437E60", Offset = "0x8436C60", VA = "0x188437E60")]
		private void CUFBZWSEQDK(KLGVNHNGDVY a, PVPFAMGHTSL b, PVPFAMGHTSL c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x84386F0", Offset = "0x84374F0", VA = "0x1884386F0")]
		private void EJMXXOYBRPH(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8439440", Offset = "0x8438240", VA = "0x188439440")]
		private void NVMNDNZXMUP(EJIUDDQOFKB a, EJIUDDQOFKB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8439D00", Offset = "0x8438B00", VA = "0x188439D00", Slot = "18")]
		public PVPFAMGHTSL RULQUTKNBBY(PVPFAMGHTSL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8437A50", Offset = "0x8436850", VA = "0x188437A50", Slot = "13")]
		public void AGASFDYRHIN(PVPFAMGHTSL a, HashSet<PVPFAMGHTSL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x843AA60", Offset = "0x8439860", VA = "0x18843AA60", Slot = "14")]
		public List<PVPFAMGHTSL> YYNNLGCYDDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8438620", Offset = "0x8437420", VA = "0x188438620")]
		protected EJIUDDQOFKB EICMVQOURPA(EJIUDDQOFKB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x843ACA0", Offset = "0x8439AA0", VA = "0x18843ACA0")]
		protected KLGVNHNGDVY[] ZVMWBDLNJVZ(KLGVNHNGDVY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x843A030", Offset = "0x8438E30", VA = "0x18843A030")]
		protected bool UUXZCUODDDY(PVPFAMGHTSL a, [Out] KLGVNHNGDVY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8437F60", Offset = "0x8436D60", VA = "0x188437F60", Slot = "15")]
		public bool DWJLCQYTSFU(PVPFAMGHTSL a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x843A140", Offset = "0x8438F40", VA = "0x18843A140")]
		protected KLGVNHNGDVY UYYOYDCIMGH(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8439610", Offset = "0x8438410", VA = "0x188439610", Slot = "10")]
		public bool OYTQTICCHIC(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8438090", Offset = "0x8436E90", VA = "0x188438090")]
		private bool EATZMVCSOYZ(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8438A00", Offset = "0x8437800", VA = "0x188438A00")]
		private static bool GOXDQONYLVZ(KLGVNHNGDVY a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x84389F0", Offset = "0x84377F0", VA = "0x1884389F0", Slot = "7")]
		private bool WBPTPPRAUOG([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : JBFSYLTXFHA, CZJXGPXNOFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly TNEKCCANHHI container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly JXROXNTZCZB VFUMHXQQSZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly DHHOZNLXJUU HUFHPCWQRBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly QFRNXWHSHZE ZFAJZDFANQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly XQINYDNRZCG JLRHZTHLZTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal CUTDZRNZHRZ FDATSQVYVNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NUQTHQRTZYQ XFCAIILTWOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal LBQVHDQUZSR DKMUCIENWBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool QGIOMTTAVJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool KUEPSRWPVRW;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MXZCPSHSXVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB14680", Offset = "0xB13480", VA = "0x180B14680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB14170", Offset = "0xB12F70", VA = "0x180B14170")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool VPERIKUXOYP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x10FE9F0", Offset = "0x10FD7F0", VA = "0x1810FE9F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x261CD30", Offset = "0x261BB30", VA = "0x18261CD30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NUTHRPUVLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL> MESYNRIQNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x843B470", Offset = "0x843A270", VA = "0x18843B470", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x843B4D0", Offset = "0x843A2D0", VA = "0x18843B4D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL> SIOUJZROEIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x843B0B0", Offset = "0x8439EB0", VA = "0x18843B0B0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x843C660", Offset = "0x843B460", VA = "0x18843C660", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<PVPFAMGHTSL, PVPFAMGHTSL, PVPFAMGHTSL> OLSCLIEQLQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x843B170", Offset = "0x8439F70", VA = "0x18843B170", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x843B110", Offset = "0x8439F10", VA = "0x18843B110", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x843CC40", Offset = "0x843BA40", VA = "0x18843CC40")]
		public LegacyConnectableManager(TNEKCCANHHI container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x843B6B0", Offset = "0x843A4B0", VA = "0x18843B6B0", Slot = "12")]
		public void Initialize(GameObject gameObject, AKGDOQXYEOF configData, EADKAXNIXSO rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x843C590", Offset = "0x843B390", VA = "0x18843C590", Slot = "26")]
		public void VZXWUYBQFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x843C510", Offset = "0x843B310", VA = "0x18843C510", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x843B1D0", Offset = "0x8439FD0", VA = "0x18843B1D0", Slot = "14")]
		public void DELFABVRANX(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x843C0E0", Offset = "0x843AEE0", VA = "0x18843C0E0", Slot = "15")]
		public void LWTDSZSZCOS(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x843C910", Offset = "0x843B710", VA = "0x18843C910", Slot = "22")]
		public bool YCWOIMOSGUA(DHZNTPEYEJU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x843B320", Offset = "0x843A120", VA = "0x18843B320")]
		internal bool EATZMVCSOYZ([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x843BF90", Offset = "0x843AD90", VA = "0x18843BF90")]
		internal bool LUXDCVIRYYX([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x843BD00", Offset = "0x843AB00", VA = "0x18843BD00")]
		internal void LQWWLHRDQRJ(PVPFAMGHTSL a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x843C0E0", Offset = "0x843AEE0", VA = "0x18843C0E0")]
		internal bool NHKYXUTLRNR(PVPFAMGHTSL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x843B1F0", Offset = "0x8439FF0", VA = "0x18843B1F0")]
		internal bool EAFPUDFZTYN(PVPFAMGHTSL a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x843AFC0", Offset = "0x8439DC0", VA = "0x18843AFC0", Slot = "16")]
		public void AGASFDYRHIN(PVPFAMGHTSL a, HashSet<PVPFAMGHTSL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x843C140", Offset = "0x843AF40", VA = "0x18843C140", Slot = "17")]
		public void PVXSSMKGYFL(PVPFAMGHTSL a, PVPFAMGHTSL b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x843C960", Offset = "0x843B760", VA = "0x18843C960", Slot = "18")]
		public void YDJUSHEKBJV(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x843C350", Offset = "0x843B150", VA = "0x18843C350", Slot = "19")]
		public void UHNZWGYUXTN(PVPFAMGHTSL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x843C6C0", Offset = "0x843B4C0", VA = "0x18843C6C0")]
		public void XHDCQXWVRPI([Optional] VPDKWOIWOKH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x843BC70", Offset = "0x843AA70", VA = "0x18843BC70", Slot = "23")]
		public void JUWLLZLPVVF(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x843B530", Offset = "0x843A330", VA = "0x18843B530", Slot = "20")]
		public ConnectableGraphData ITSKXTXFKMW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x843CAA0", Offset = "0x843B8A0", VA = "0x18843CAA0", Slot = "21")]
		public ConnectableGraphData YNGIMKPXXPU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x843B430", Offset = "0x843A230", VA = "0x18843B430", Slot = "25")]
		public void FXCLDKUORSY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x843BEE0", Offset = "0x843ACE0", VA = "0x18843BEE0", Slot = "24")]
		public void LSQCFAVCRTR(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class JXROXNTZCZB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly OPFQNJIHYGU<PVPFAMGHTSL, PVPFAMGHTSL> MESYNRIQNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly OPFQNJIHYGU<PVPFAMGHTSL, PVPFAMGHTSL> SIOUJZROEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly OPKXKQCFHSD<PVPFAMGHTSL, PVPFAMGHTSL, PVPFAMGHTSL> OLSCLIEQLQE;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8435EB0", Offset = "0x8434CB0", VA = "0x188435EB0")]
		public JXROXNTZCZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8435DF0", Offset = "0x8434BF0", VA = "0x188435DF0")]
		public void JCOJGQFQWJI(PVPFAMGHTSL a, PVPFAMGHTSL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8435E50", Offset = "0x8434C50", VA = "0x188435E50")]
		public void YVNVPYFFSUU(PVPFAMGHTSL a, PVPFAMGHTSL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8435D70", Offset = "0x8434B70", VA = "0x188435D70")]
		public void FDQCJBLZTKA(PVPFAMGHTSL a, PVPFAMGHTSL b, PVPFAMGHTSL c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class DHHOZNLXJUU : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager JTGRNIXZGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NUQTHQRTZYQ XFCAIILTWOW;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public DHHOZNLXJUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8435200", Offset = "0x8434000", VA = "0x188435200")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84351F0", Offset = "0x8433FF0", VA = "0x1884351F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x84353A0", Offset = "0x84341A0", VA = "0x1884353A0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8435330", Offset = "0x8434130", VA = "0x188435330")]
		private void OnMasterClientSwitched(VPDKWOIWOKH newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84354E0", Offset = "0x84342E0", VA = "0x1884354E0")]
		public void XUBSUJUXACQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x84353E0", Offset = "0x84341E0", VA = "0x1884353E0")]
		public void QVCWSCCTBRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class CXYABUHDHTQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public TNEKCCANHHI container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8449130", Offset = "0x8447F30", VA = "0x188449130")]
			internal LegacyConnectableManager MXIQXMZCEJZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x84347C0", Offset = "0x84335C0", VA = "0x1884347C0")]
		public static void MYMPJKKOGIL(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8434740", Offset = "0x8433540", VA = "0x188434740")]
		public static void IDVWKYHBCJS(TNEKCCANHHI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, LBQVHDQUZSR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, TSGDURFHOXU> LOKPZFKZNAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation PKCKDVQTLWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private QENBQKMCBRI TPNHPYBTXIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private XQINYDNRZCG JLRHZTHLZTS;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker BXPSEZCDBQO;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x843DD90", Offset = "0x843CB90", VA = "0x18843DD90")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x843D360", Offset = "0x843C160", VA = "0x18843D360", Slot = "7")]
		public void Initialize(XQINYDNRZCG graph, QENBQKMCBRI creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x843D960", Offset = "0x843C760", VA = "0x18843D960", Slot = "5")]
		public void WBMNQCJGKYL(EJIUDDQOFKB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x843D120", Offset = "0x843BF20", VA = "0x18843D120", Slot = "9")]
		public void IJTBAGBWIEG(EJIUDDQOFKB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x843D3A0", Offset = "0x843C1A0", VA = "0x18843D3A0", Slot = "8")]
		public void JJNWJYUOPMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x843D560", Offset = "0x843C360", VA = "0x18843D560", Slot = "10")]
		public void LLLQDIOGUYN(EJIUDDQOFKB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x843CFD0", Offset = "0x843BDD0", VA = "0x18843CFD0", Slot = "11")]
		public void ETMZJAIUFQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x843D7B0", Offset = "0x843C5B0", VA = "0x18843D7B0")]
		private bool UEQASYTDLGQ(EJIUDDQOFKB a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class QFRNXWHSHZE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly KLGVNHNGDVY currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly DHZNTPEYEJU parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly DHZNTPEYEJU rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool QXQZLJACMZP
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x84488E0", Offset = "0x84476E0", VA = "0x1884488E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8448B90", Offset = "0x8447990", VA = "0x188448B90")]
			public SerializeNodeInSubgraph(KLGVNHNGDVY currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] DHZNTPEYEJU parentNodeData, [Optional] DHZNTPEYEJU rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x84489F0", Offset = "0x84477F0", VA = "0x1884489F0")]
			public DHZNTPEYEJU ZLPVCWRAQLQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x84482F0", Offset = "0x84470F0", VA = "0x1884482F0")]
			private DHZNTPEYEJU GVGFUHTZONI([Out] DHZNTPEYEJU a, [Out] DHZNTPEYEJU b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8448570", Offset = "0x8447370", VA = "0x188448570")]
			private DHZNTPEYEJU QKEIUGUTGXI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8448770", Offset = "0x8447570", VA = "0x188448770")]
			private void SEFVWQTBEIQ(DHZNTPEYEJU a, DHZNTPEYEJU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x84483B0", Offset = "0x84471B0", VA = "0x1884483B0")]
			private void OGOBAEZCRGJ(DHZNTPEYEJU a, DHZNTPEYEJU b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager JTGRNIXZGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private XQINYDNRZCG JLRHZTHLZTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private LBQVHDQUZSR NIIXSLFLLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private NUQTHQRTZYQ XFCAIILTWOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool FFDJDNBYJJC;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool QWRHWISUMBX
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8447710", Offset = "0x8446510", VA = "0x188447710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool MXZCPSHSXVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8445850", Offset = "0x8444650", VA = "0x188445850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8447760", Offset = "0x8446560", VA = "0x188447760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8446CA0", Offset = "0x8445AA0", VA = "0x188446CA0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8446B30", Offset = "0x8445930", VA = "0x188446B30")]
		public ConnectableGraphData ITSKXTXFKMW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8447CC0", Offset = "0x8446AC0", VA = "0x188447CC0")]
		public ConnectableGraphData YNGIMKPXXPU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8446D10", Offset = "0x8445B10", VA = "0x188446D10")]
		public void JUWLLZLPVVF(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8446DA0", Offset = "0x8445BA0", VA = "0x188446DA0")]
		public void LSQCFAVCRTR(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8445CB0", Offset = "0x8444AB0", VA = "0x188445CB0")]
		public void EGGVKXSQXDD(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8447310", Offset = "0x8446110", VA = "0x188447310")]
		private void RXYBSUJVQAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84465C0", Offset = "0x84453C0", VA = "0x1884465C0")]
		private DHZNTPEYEJU FJPKLWQYKNW(KLGVNHNGDVY a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8445A00", Offset = "0x8444800", VA = "0x188445A00")]
		private static void EFTQXERPQBY(KLGVNHNGDVY a, bool b, DHZNTPEYEJU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x84474F0", Offset = "0x84462F0", VA = "0x1884474F0")]
		private void SQJHQVCRNZL(KLGVNHNGDVY a, bool b, DHZNTPEYEJU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8446980", Offset = "0x8445780", VA = "0x188446980")]
		private DHZNTPEYEJU IDKVENGRFVO(KLGVNHNGDVY a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8445CE0", Offset = "0x8444AE0", VA = "0x188445CE0")]
		private bool EMMGTZJBHSG(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8445F60", Offset = "0x8444D60", VA = "0x188445F60")]
		private bool EOWLLBPPFSP(DHZNTPEYEJU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x84472F0", Offset = "0x84460F0", VA = "0x1884472F0")]
		private bool QYMNIIAGJSZ(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8446A10", Offset = "0x8445810", VA = "0x188446A10")]
		private static bool IGXWWBNMQSA(DHZNTPEYEJU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8447A30", Offset = "0x8446830", VA = "0x188447A30")]
		public static bool YCWOIMOSGUA(DHZNTPEYEJU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8446FB0", Offset = "0x8445DB0", VA = "0x188446FB0")]
		private PVPFAMGHTSL QEALKHVYSKS(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8446E40", Offset = "0x8445C40", VA = "0x188446E40")]
		private PVPFAMGHTSL OLOKCKPXZGQ(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8445870", Offset = "0x8444670", VA = "0x188445870")]
		private PVPFAMGHTSL CANMUYXIUBN(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8443870", Offset = "0x8442670", VA = "0x188443870")]
		private static Guid YLHZCQHYOOJ(DHZNTPEYEJU a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8446890", Offset = "0x8445690", VA = "0x188446890")]
		private string GQETOSPJVJC(DHZNTPEYEJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x84466A0", Offset = "0x84454A0", VA = "0x1884466A0")]
		private bool GLOUOGUXBHN(KLGVNHNGDVY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8447780", Offset = "0x8446580", VA = "0x188447780")]
		private static void WTMWILLZJEP(KLGVNHNGDVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public QFRNXWHSHZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PVPFAMGHTSL child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public PVPFAMGHTSL parent;

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
		public ConnectableLink OPWWQTPGZBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x84350B0", Offset = "0x8433EB0", VA = "0x1884350B0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink RVLJPKLGKNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8435150", Offset = "0x8433F50", VA = "0x188435150")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8435180", Offset = "0x8433F80", VA = "0x188435180")]
		public ConnectionOperationData(PVPFAMGHTSL child, PVPFAMGHTSL parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface XQINYDNRZCG
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		EJIUDDQOFKB JNMQCQBFHQM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(JBFSYLTXFHA manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FISCUYBRPLJ([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MOFXZLMYNLM(PVPFAMGHTSL a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ILZCKUNEHFU(PVPFAMGHTSL a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OYTQTICCHIC(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VNLDREQVFEV();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void KHWVUKCFZDD(Func<PVPFAMGHTSL, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AGASFDYRHIN(PVPFAMGHTSL a, HashSet<PVPFAMGHTSL> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<PVPFAMGHTSL> YYNNLGCYDDP();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool DWJLCQYTSFU(PVPFAMGHTSL a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WDURAMQZPUO(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(EJIUDDQOFKB node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface EJIUDDQOFKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		PVPFAMGHTSL XQZPVGLKXAW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		EJIUDDQOFKB VEEIKBNANOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink BVSTKALQUXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool IQICUBOJCLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface TSGDURFHOXU : SXAFQWTIFOS.CDPXIUQTCGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NRKVJJKJWDM(PVPFAMGHTSL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CQWBXYEKMWG(PVPFAMGHTSL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SPKIFMULCLZ(PVPFAMGHTSL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HLVFQGQXVXL(PVPFAMGHTSL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TSGDURFHOXU BFHERDQBZJS(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface QENBQKMCBRI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, TSGDURFHOXU linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TSGDURFHOXU ZEHSNGCLUWM();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LDMCWRKCYOC(TSGDURFHOXU a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface CUTDZRNZHRZ : JTFADDOJRVU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AZUNQSPHFTL();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ELQNWZWIFSU(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface LBQVHDQUZSR
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WBMNQCJGKYL(EJIUDDQOFKB a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(XQINYDNRZCG graph, QENBQKMCBRI linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JJNWJYUOPMU();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IJTBAGBWIEG(EJIUDDQOFKB a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LLLQDIOGUYN(EJIUDDQOFKB a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ETMZJAIUFQV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class KLGVNHNGDVY : EJIUDDQOFKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class YLTHIKBGYII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink DAICZELIXGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public KLGVNHNGDVY RTXKWHBNOHS;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public YLTHIKBGYII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8448E00", Offset = "0x8447C00", VA = "0x188448E00")]
			internal bool QSWOUOYVVTZ(EJIUDDQOFKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink QDMJPLFKOEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<KLGVNHNGDVY> WDBTAENPLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KLGVNHNGDVY FCNZBEZRZPL;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink BVSTKALQUXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4883570", Offset = "0x4882370", VA = "0x184883570", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8436670", Offset = "0x8435470", VA = "0x188436670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private KLGVNHNGDVY YTPNFINVAEY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8436D60", Offset = "0x8435B60", VA = "0x188436D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public EJIUDDQOFKB VEEIKBNANOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public PVPFAMGHTSL XQZPVGLKXAW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool IQICUBOJCLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8436830", Offset = "0x8435630", VA = "0x188436830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool SIJMBTYGEKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x84366A0", Offset = "0x84354A0", VA = "0x1884366A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected KLGVNHNGDVY WYBQGJRULHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x84369C0", Offset = "0x84357C0", VA = "0x1884369C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8436FB0", Offset = "0x8435DB0", VA = "0x188436FB0")]
		public KLGVNHNGDVY(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x84366F0", Offset = "0x84354F0", VA = "0x1884366F0")]
		public KLGVNHNGDVY KLYJQYWESGP(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8436840", Offset = "0x8435640", VA = "0x188436840")]
		public KLGVNHNGDVY MBUQYZVLRVR(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x84369E0", Offset = "0x84357E0", VA = "0x1884369E0")]
		public KLGVNHNGDVY Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8436520", Offset = "0x8435320", VA = "0x188436520")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8436BC0", Offset = "0x84359C0", VA = "0x188436BC0")]
		public KLGVNHNGDVY Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8436E50", Offset = "0x8435C50", VA = "0x188436E50")]
		private static void WDURAMQZPUO(KLGVNHNGDVY a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8436E40", Offset = "0x8435C40", VA = "0x188436E40", Slot = "9")]
		public void WDURAMQZPUO(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8436C70", Offset = "0x8435A70", VA = "0x188436C70")]
		public static KLGVNHNGDVY UYYOYDCIMGH(KLGVNHNGDVY a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface NUQTHQRTZYQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool QWRHWISUMBX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> OUJIQVCSLTX;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<VPDKWOIWOKH> BJBUFDNFZJP;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NRKVJJKJWDM(LegacyConnectableManager a, EADKAXNIXSO b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PVXSSMKGYFL(PVPFAMGHTSL a, PVPFAMGHTSL b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YDJUSHEKBJV(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KRQHSRCLFWO(ConnectableGraphData a, [Optional] VPDKWOIWOKH b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class MDNVSPAABVM
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x843DFF0", Offset = "0x843CDF0", VA = "0x18843DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object PKFRARWZTTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x843E0A0", Offset = "0x843CEA0", VA = "0x18843E0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x843E040", Offset = "0x843CE40", VA = "0x18843E040")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class MHZSGFJSNFD : NUQTHQRTZYQ, IDisposable, PYBXMIOIFQK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager JTGRNIXZGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private EADKAXNIXSO MIRBIJWOPTE;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool QWRHWISUMBX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x843EE10", Offset = "0x843DC10", VA = "0x18843EE10", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x843E130", Offset = "0x843CF30", VA = "0x18843E130", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView LMNXIFDEFQW
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x843E330", Offset = "0x843D130", VA = "0x18843E330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> OUJIQVCSLTX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x843E170", Offset = "0x843CF70", VA = "0x18843E170", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x843E3D0", Offset = "0x843D1D0", VA = "0x18843E3D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<VPDKWOIWOKH> BJBUFDNFZJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x843EF90", Offset = "0x843DD90", VA = "0x18843EF90", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x843E470", Offset = "0x843D270", VA = "0x18843E470", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x843E510", Offset = "0x843D310", VA = "0x18843E510", Slot = "10")]
		public void NRKVJJKJWDM(LegacyConnectableManager a, EADKAXNIXSO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x843E0E0", Offset = "0x843CEE0", VA = "0x18843E0E0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x843E5A0", Offset = "0x843D3A0", VA = "0x18843E5A0", Slot = "11")]
		public void PVXSSMKGYFL(PVPFAMGHTSL a, PVPFAMGHTSL b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x843EE70", Offset = "0x843DC70", VA = "0x18843EE70", Slot = "12")]
		public void YDJUSHEKBJV(PVPFAMGHTSL a, int b, PVPFAMGHTSL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x843E210", Offset = "0x843D010", VA = "0x18843E210", Slot = "13")]
		public void KRQHSRCLFWO(ConnectableGraphData a, [Optional] VPDKWOIWOKH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x843E8F0", Offset = "0x843D6F0", VA = "0x18843E8F0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(PVPFAMGHTSL objectToReparent, int objectToReparentSlotIndex, PVPFAMGHTSL newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x843E700", Offset = "0x843D500", VA = "0x18843E700")]
		[RPCMethod]
		private void RpcMasterModifyNode(PVPFAMGHTSL connectableToModify, PVPFAMGHTSL expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x843ECE0", Offset = "0x843DAE0", VA = "0x18843ECE0")]
		[RPCMethod]
		private void RpcReparentNodes(PVPFAMGHTSL objectToReparent, int objectToReparentSlotIndex, PVPFAMGHTSL newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x843EBF0", Offset = "0x843D9F0", VA = "0x18843EBF0")]
		[RPCMethod]
		private void RpcModifyNode(PVPFAMGHTSL connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x843E6C0", Offset = "0x843D4C0", VA = "0x18843E6C0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public MHZSGFJSNFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, TSGDURFHOXU, SXAFQWTIFOS.CDPXIUQTCGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8437610", Offset = "0x8436410", VA = "0x188437610", Slot = "4")]
		private void PGLGCPPJPTL(PVPFAMGHTSL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x84373B0", Offset = "0x84361B0", VA = "0x1884373B0", Slot = "5")]
		private void EGGZZXIZVTP(PVPFAMGHTSL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8437180", Offset = "0x8435F80", VA = "0x188437180", Slot = "6")]
		private void BXYJLTAXZWC(PVPFAMGHTSL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8437860", Offset = "0x8436660", VA = "0x188437860", Slot = "7")]
		private void YPYHSBFJILM(PVPFAMGHTSL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8437790", Offset = "0x8436590", VA = "0x188437790", Slot = "8")]
		private TSGDURFHOXU RJDBLORTUNX(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8437800", Offset = "0x8436600", VA = "0x188437800", Slot = "9")]
		private void VZPDCNLNAVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class QMQZANRPSKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C0B0", Offset = "0x3A0AEB0", VA = "0x183A0C0B0")]
		public static XWTVGKILBFN<a> CGZRQMXGKWG<a>(this TNEKCCANHHI a)
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
