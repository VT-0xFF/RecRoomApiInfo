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
		[Cpp2IlInjected.Address(RVA = "0x98C7310", Offset = "0x98C6310", VA = "0x1898C7310", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		private int[] DFSWPDPJVFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] DFYDMKJHEQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset QBNLPBWZQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset QBIERVDCHEW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2240B50", Offset = "0x223FB50", VA = "0x182240B50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98CF8C0", Offset = "0x98CE8C0", VA = "0x1898CF8C0")]
		private void ROXZSJHBEXH(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98CF770", Offset = "0x98CE770", VA = "0x1898CF770")]
		private void ROSSVCNDVLY(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98CFA10", Offset = "0x98CEA10", VA = "0x1898CFA10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98CFD20", Offset = "0x98CED20", VA = "0x1898CFD20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : VCIUHYJNRJC, KBDWOSKHASX
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class OAMKNSMXCOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LZBUEEHACUI KNOQSEEZBXI;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public OAMKNSMXCOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x98C7630", Offset = "0x98C6630", VA = "0x1898C7630")]
			internal object AUFIZSUMRHX(LZBUEEHACUI a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class OARRKZGULZP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public LZBUEEHACUI JPPXAGJNXQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OAMKNSMXCOG LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public OARRKZGULZP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98C76A0", Offset = "0x98C66A0", VA = "0x1898C76A0")]
			internal object AUACCMAPHWO((LZBUEEHACUI child, LZBUEEHACUI nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XWQAZHEAXWV : IEnumerable<LBBZJIBDMEJ>, IEnumerable, IEnumerator<LBBZJIBDMEJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private LBBZJIBDMEJ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId WHIZQHPFQUQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId IPKCGIKTOTV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private OVUGAPSSNHH BDSZFEHJQWF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray RJHIOZUXAGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator PPQRYGJWASU;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private LBBZJIBDMEJ HUWBUQYIGMP
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public XWQAZHEAXWV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x98CF5A0", Offset = "0x98CE5A0", VA = "0x1898CF5A0", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x98CF240", Offset = "0x98CE240", VA = "0x1898CF240", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x98CF200", Offset = "0x98CE200", VA = "0x1898CF200")]
			private void LZWZIAQZAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x98CF220", Offset = "0x98CE220", VA = "0x1898CF220")]
			private void MACGFHKWJQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x98CF730", Offset = "0x98CE730", VA = "0x1898CF730", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x98CF680", Offset = "0x98CE680", VA = "0x1898CF680", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LBBZJIBDMEJ> TTOLRVBMQUI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x98CF680", Offset = "0x98CE680", VA = "0x1898CF680", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log ELQJJVPWQRD;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log XFEONLEIJNH;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log MBAZSDTLILX;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log CLJYJGRGRYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MULYZFNYGAQ JZUMEEJXBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TIHXEIZQQGP GREKCHRVGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private RZLWEIJUDNQ XDBJDIGDSCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private QCRDCEJGMDC EHXZKUBIMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private RFHGNUFWUDG ATWMHUAUVIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NCTNWCXTGEE ZAQDZFOHHTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly CEUIORQFJYJ WYJOEDKLSWG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ZANTMLNUIXH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCFC310", Offset = "0xCFB310", VA = "0x180CFC310", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCFC300", Offset = "0xCFB300", VA = "0x180CFC300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool YAMYZTVVWMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QAMJPZGYVJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x98CBE60", Offset = "0x98CAE60", VA = "0x1898CBE60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x98CB790", Offset = "0x98CA790", VA = "0x1898CB790", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QWAKMQBZCIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98C9F70", Offset = "0x98C8F70", VA = "0x1898C9F70", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98C8000", Offset = "0x98C7000", VA = "0x1898C8000", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ, LBBZJIBDMEJ> DATVCXBUOEG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x98C9EC0", Offset = "0x98C8EC0", VA = "0x1898C9EC0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x98CB8D0", Offset = "0x98CA8D0", VA = "0x1898CB8D0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x98CC2A0", Offset = "0x98CB2A0", VA = "0x1898CC2A0")]
		public OMConnectableManager(RZEIGZPHMMY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98C9030", Offset = "0x98C8030", VA = "0x1898C9030", Slot = "12")]
		public void Initialize(GameObject gameObject, GGVAUXPRCOX configData, MTIDGMXGFWY sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98C8D50", Offset = "0x98C7D50", VA = "0x1898C8D50", Slot = "26")]
		public void IPPIPTCNVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98C8C90", Offset = "0x98C7C90", VA = "0x1898C8C90", Slot = "22")]
		public bool HTXXUVPLHWK(LZBUEEHACUI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98CA7E0", Offset = "0x98C97E0", VA = "0x1898CA7E0")]
		private void PKKFSTNXPWL(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98C9CA0", Offset = "0x98C8CA0", VA = "0x1898C9CA0")]
		private void NBPFOFIFNYZ(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98CB980", Offset = "0x98CA980", VA = "0x1898CB980")]
		private void XXVKRRNBWAP(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98CA3D0", Offset = "0x98C93D0", VA = "0x1898CA3D0")]
		private void PIRUJVJXIPG(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98CA0D0", Offset = "0x98C90D0", VA = "0x1898CA0D0", Slot = "14")]
		public void OTSRDIPIITJ(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "15")]
		public void FXHLRCDUIQY(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98C9640", Offset = "0x98C8640", VA = "0x1898C9640", Slot = "17")]
		public void KHAIGMRFAHR(LBBZJIBDMEJ a, LBBZJIBDMEJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98C9500", Offset = "0x98C8500", VA = "0x1898C9500")]
		public void KHAIGMRFAHR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98CB840", Offset = "0x98CA840", VA = "0x1898CB840")]
		public void WMPKCEHJDYF(LBBZJIBDMEJ a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98C9AE0", Offset = "0x98C8AE0", VA = "0x1898C9AE0", Slot = "18")]
		public void LPUNEXSLZTX(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98CA020", Offset = "0x98C9020", VA = "0x1898CA020")]
		private float OLPDLNRQCHJ(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98C99A0", Offset = "0x98C89A0", VA = "0x1898C99A0")]
		public void LPUNEXSLZTX(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98C9390", Offset = "0x98C8390", VA = "0x1898C9390", Slot = "19")]
		public void JQKDUSEGDKF(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98CBF30", Offset = "0x98CAF30", VA = "0x1898CBF30", Slot = "16")]
		public void ZQJLUFKDVIX(LBBZJIBDMEJ a, HashSet<LBBZJIBDMEJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "20")]
		public ConnectableGraphData GKRVUXJUBGU(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "21")]
		public ConnectableGraphData LOFXDBZEBPO(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98C8CE0", Offset = "0x98C7CE0", VA = "0x1898C8CE0", Slot = "23")]
		public void IINZHIAYXEJ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98CB5A0", Offset = "0x98CA5A0", VA = "0x1898CB5A0", Slot = "24")]
		public void TNHSEAKFXJL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98CBF10", Offset = "0x98CAF10", VA = "0x1898CBF10", Slot = "25")]
		public void ZHGBUEICMKO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98C80B0", Offset = "0x98C70B0", VA = "0x1898C80B0")]
		private void DNWZNCPQMZX(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98CACB0", Offset = "0x98C9CB0", VA = "0x1898CACB0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98C97A0", Offset = "0x98C87A0", VA = "0x1898C97A0")]
		private void KWNNFUSFJUW(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98CAA50", Offset = "0x98C9A50", VA = "0x1898CAA50")]
		[IteratorStateMachine(typeof(XWQAZHEAXWV))]
		public IEnumerable<LBBZJIBDMEJ> RGWSYAGSHTR(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98C8640", Offset = "0x98C7640", VA = "0x1898C8640")]
		internal LBBZJIBDMEJ GPHTGXKHQAY(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98C8B00", Offset = "0x98C7B00", VA = "0x1898C8B00")]
		internal ObjectLocalId HDNHVKUQZRG(LBBZJIBDMEJ a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98C78F0", Offset = "0x98C68F0", VA = "0x1898C78F0")]
		private bool AEBDZUVVSYJ(LZBUEEHACUI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98CA9F0", Offset = "0x98C99F0", VA = "0x1898CA9F0")]
		private bool QJNMCPUUWUB(LZBUEEHACUI a, [Out] LBBZJIBDMEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98C8770", Offset = "0x98C7770", VA = "0x1898C8770")]
		private LBBZJIBDMEJ GPHTGXKHQAY(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98CB610", Offset = "0x98CA610", VA = "0x1898CB610")]
		private LBBZJIBDMEJ UHLVQTXLHZH(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98CAAE0", Offset = "0x98C9AE0", VA = "0x1898CAAE0")]
		private LBBZJIBDMEJ SJGACMSMPWK(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98BEC50", Offset = "0x98BDC50", VA = "0x1898BEC50")]
		private static Guid QWBLWSRNUQH(LZBUEEHACUI a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98C92A0", Offset = "0x98C82A0", VA = "0x1898C92A0")]
		private string JHPNOAIFXWO(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98C84B0", Offset = "0x98C74B0", VA = "0x1898C84B0")]
		private void GAADCDFSXSZ(LBBZJIBDMEJ a, LBBZJIBDMEJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98C7E70", Offset = "0x98C6E70", VA = "0x1898C7E70")]
		private void AIDGHPHPZLN(LBBZJIBDMEJ a, LBBZJIBDMEJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C40", Offset = "0x98C8C40", VA = "0x1898C9C40")]
		private void MREOVJJMFKZ(LBBZJIBDMEJ a, LBBZJIBDMEJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x98C9810", Offset = "0x98C8810", VA = "0x1898C9810")]
		private void LCFKPUPZGQY(LBBZJIBDMEJ a, LBBZJIBDMEJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98C8F20", Offset = "0x98C7F20", VA = "0x1898C8F20")]
		private void ISEROSKWVCV(ObjectLocalId a, LBBZJIBDMEJ b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98CBBE0", Offset = "0x98CABE0", VA = "0x1898CBBE0")]
		private void YOAODTULFAG(ObjectLocalId a, LBBZJIBDMEJ b, LBBZJIBDMEJ c, LBBZJIBDMEJ d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RNJVMAOMVRF
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class VBNXNXLVIWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public RZEIGZPHMMY container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VBNXNXLVIWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x98CF100", Offset = "0x98CE100", VA = "0x1898CF100")]
			internal OMConnectableManager OQNEWUGVSCB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98CE210", Offset = "0x98CD210", VA = "0x1898CE210")]
		public static void QFBJTNLQHDT(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98CE1C0", Offset = "0x98CD1C0", VA = "0x1898CE1C0")]
		public static void PIDRHJKBNWS(RZEIGZPHMMY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : JYFYHVRRZIR, ODLSFSWDFUA
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager TOIEWAWMTOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BYWOWYCGBMP GJIPZPITYTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly MBGSIUPONDT EHXZKUBIMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly XPDTKUMLEOB[] NRFUVFXMRHT;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LBBZJIBDMEJ ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x98CDEB0", Offset = "0x98CCEB0", VA = "0x1898CDEB0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LBBZJIBDMEJ DQFMBSWSVUE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x98CDA60", Offset = "0x98CCA60", VA = "0x1898CDA60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 KKHCHVAXQMA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x98CD470", Offset = "0x98CC470", VA = "0x1898CD470", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion VDXWWBJUIRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x98CD5B0", Offset = "0x98CC5B0", VA = "0x1898CD5B0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IZQFDFOQGWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x98CD060", Offset = "0x98CC060", VA = "0x1898CD060", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<LBBZJIBDMEJ> YLAGNATNUOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x98CC670", Offset = "0x98CB670", VA = "0x1898CC670", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool XPUXIGYPTKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD9B520", Offset = "0xD9A520", VA = "0x180D9B520", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE7CDA0", Offset = "0xE7BDA0", VA = "0x180E7CDA0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98CE0B0", Offset = "0x98CD0B0", VA = "0x1898CE0B0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x98CDDD0", Offset = "0x98CCDD0", VA = "0x1898CDDD0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x98CDDF0", Offset = "0x98CCDF0", VA = "0x1898CDDF0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x98CDF10", Offset = "0x98CCF10", VA = "0x1898CDF10", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x98CDFF0", Offset = "0x98CCFF0", VA = "0x1898CDFF0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool UVANAIIVOHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x98CC620", Offset = "0x98CB620", VA = "0x1898CC620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler VWBTUXRQONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x98CD2E0", Offset = "0x98CC2E0", VA = "0x1898CD2E0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x98CC6A0", Offset = "0x98CB6A0", VA = "0x1898CC6A0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler XNHSJSYIUTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x98CD660", Offset = "0x98CC660", VA = "0x1898CD660", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x98CDB20", Offset = "0x98CCB20", VA = "0x1898CDB20", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler WKAZZPRBSCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x98CD4D0", Offset = "0x98CC4D0", VA = "0x1898CD4D0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x98CD330", Offset = "0x98CC330", VA = "0x1898CD330", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler NPGEUKBHUJI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x98CD380", Offset = "0x98CC380", VA = "0x1898CD380", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x98CD6B0", Offset = "0x98CC6B0", VA = "0x1898CD6B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x98CDCD0", Offset = "0x98CCCD0", VA = "0x1898CDCD0")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, BYWOWYCGBMP connectableTool, XPDTKUMLEOB[] connectionPoints, MBGSIUPONDT callbacks, VCIUHYJNRJC connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x98CC360", Offset = "0x98CB360", VA = "0x1898CC360", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "21")]
		public void FZXCZHVXASQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x98CD520", Offset = "0x98CC520", VA = "0x1898CD520", Slot = "22")]
		public void QNHRDDCSIVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98CD560", Offset = "0x98CC560", VA = "0x1898CD560", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98CD0D0", Offset = "0x98CC0D0", VA = "0x1898CD0D0", Slot = "25")]
		public void KKBRNWPWOFO(int a, LBBZJIBDMEJ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98CDB70", Offset = "0x98CCB70", VA = "0x1898CDB70", Slot = "26")]
		public void ZESFZFJUXLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98CC6F0", Offset = "0x98CB6F0", VA = "0x1898CC6F0", Slot = "27")]
		public void GJUZVPYQGKC(int a, LBBZJIBDMEJ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98CCBD0", Offset = "0x98CBBD0", VA = "0x1898CCBD0", Slot = "28")]
		public void HQUJUMUTXSU(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98CCC50", Offset = "0x98CBC50", VA = "0x1898CCC50", Slot = "31")]
		public void ICHVXMLVAGJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98CD750", Offset = "0x98CC750", VA = "0x1898CD750", Slot = "29")]
		public void XHKPLOCSZQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98CC430", Offset = "0x98CB430", VA = "0x1898CC430", Slot = "30")]
		public void DHUPYCJDOYU(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x98CCB00", Offset = "0x98CBB00", VA = "0x1898CCB00", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98CC9D0", Offset = "0x98CB9D0", VA = "0x1898CC9D0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD5D000", Offset = "0xD5C000", VA = "0x180D5D000", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98CC390", Offset = "0x98CB390", VA = "0x1898CC390", Slot = "43")]
		public bool CanConnectTo(int slotIndex, LBBZJIBDMEJ otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "44")]
		public void ParentChanged(int slotIndex, LBBZJIBDMEJ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "45")]
		public void ChildAdded(int slotIndex, LBBZJIBDMEJ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "46")]
		public void ChildRemoved(int slotIndex, LBBZJIBDMEJ removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "47")]
		public void ConnectionModified(int slotIndex, LBBZJIBDMEJ parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98CD540", Offset = "0x98CC540", VA = "0x1898CD540", Slot = "48")]
		public void RootChanged(LBBZJIBDMEJ previousRootConnectable, LBBZJIBDMEJ newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x98CD420", Offset = "0x98CC420", VA = "0x1898CD420", Slot = "23")]
		public void LZYWPZKFGNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98CD610", Offset = "0x98CC610", VA = "0x1898CD610", Slot = "24")]
		public void VTGDNYQIVGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98CC310", Offset = "0x98CB310", VA = "0x1898CC310")]
		private void AYXZHJPJFJZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(OGMOZJFOCKE), new string[] { })]
	public class HJHCMWYOKNP : OGMOZJFOCKE, QTEVQCUAZCJ, PLNLFWQKVZL
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private ZKYBUJUWYNS OHYOWYTBMHN;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object NYFUJTZQPQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x98BC830", Offset = "0x98BB830", VA = "0x1898BC830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98BC7E0", Offset = "0x98BB7E0", VA = "0x1898BC7E0", Slot = "5")]
		private void RYSBYWLQLAZ(GLSTNWKFOLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF4E8E0", Offset = "0xF4D8E0", VA = "0x180F4E8E0", Slot = "6")]
		private void KCNBXUAVHWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public HJHCMWYOKNP()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(VCIUHYJNRJC), new string[] { "Ignore", "Mock" })]
	public class JTZYUSIQKNP : VCIUHYJNRJC, KBDWOSKHASX
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ZANTMLNUIXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool YAMYZTVVWMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QAMJPZGYVJK
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x98BF520", Offset = "0x98BE520", VA = "0x1898BF520", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x98BF3C0", Offset = "0x98BE3C0", VA = "0x1898BF3C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QWAKMQBZCIO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x98BF310", Offset = "0x98BE310", VA = "0x1898BF310", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x98BF1B0", Offset = "0x98BE1B0", VA = "0x1898BF1B0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ, LBBZJIBDMEJ> DATVCXBUOEG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x98BF260", Offset = "0x98BE260", VA = "0x1898BF260", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x98BF470", Offset = "0x98BE470", VA = "0x1898BF470", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "26")]
		public void IPPIPTCNVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "12")]
		public void Initialize(GameObject gameObject, GGVAUXPRCOX configData, MTIDGMXGFWY rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "14")]
		public void OTSRDIPIITJ(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "15")]
		public void FXHLRCDUIQY(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "16")]
		public void ZQJLUFKDVIX(LBBZJIBDMEJ a, HashSet<LBBZJIBDMEJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "17")]
		public void KHAIGMRFAHR(LBBZJIBDMEJ a, LBBZJIBDMEJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "18")]
		public void LPUNEXSLZTX(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "19")]
		public void JQKDUSEGDKF(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "20")]
		public ConnectableGraphData GKRVUXJUBGU(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "21")]
		public ConnectableGraphData LOFXDBZEBPO(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "22")]
		public bool HTXXUVPLHWK(LZBUEEHACUI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "23")]
		public void IINZHIAYXEJ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "24")]
		public void TNHSEAKFXJL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "25")]
		public void ZHGBUEICMKO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public JTZYUSIQKNP()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LBBZJIBDMEJ : ODLSFSWDFUA, IEquatable<LBBZJIBDMEJ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ODLSFSWDFUA
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		LBBZJIBDMEJ ParentConnectable
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
		bool CanConnectTo(int slotIndex, LBBZJIBDMEJ otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, LBBZJIBDMEJ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, LBBZJIBDMEJ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, LBBZJIBDMEJ removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, LBBZJIBDMEJ parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(LBBZJIBDMEJ previousRootConnectable, LBBZJIBDMEJ newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VCIUHYJNRJC : KBDWOSKHASX
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool ZANTMLNUIXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool YAMYZTVVWMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QAMJPZGYVJK;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QWAKMQBZCIO;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<LBBZJIBDMEJ, LBBZJIBDMEJ, LBBZJIBDMEJ> DATVCXBUOEG;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, GGVAUXPRCOX configData, MTIDGMXGFWY rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OTSRDIPIITJ(LBBZJIBDMEJ a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void FXHLRCDUIQY(LBBZJIBDMEJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ZQJLUFKDVIX(LBBZJIBDMEJ a, HashSet<LBBZJIBDMEJ> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void KHAIGMRFAHR(LBBZJIBDMEJ a, LBBZJIBDMEJ b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void LPUNEXSLZTX(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void JQKDUSEGDKF(LBBZJIBDMEJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData GKRVUXJUBGU(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData LOFXDBZEBPO(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool HTXXUVPLHWK(LZBUEEHACUI a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void IINZHIAYXEJ(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void TNHSEAKFXJL(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ZHGBUEICMKO(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface QCRDCEJGMDC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LBBZJIBDMEJ SJGACMSMPWK(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LBBZJIBDMEJ UHLVQTXLHZH(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BZAZKNXWJIB(LBBZJIBDMEJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool JOORMJHSRFZ();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EOFUKFPEMFK(LBBZJIBDMEJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MBGSIUPONDT
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UVANAIIVOHZ(BYWOWYCGBMP a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SJPVIQWDWVQ(BYWOWYCGBMP a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string BBSRCOSECNH(BYWOWYCGBMP a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid DEIFBEPQNAI(BYWOWYCGBMP a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int OUZDGQZOYKF(BYWOWYCGBMP a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QWWPVQBBAHS(BYWOWYCGBMP a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(LBBZJIBDMEJ childConnectable, int childConnectableSlot, LBBZJIBDMEJ parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(LBBZJIBDMEJ previousRootConnectable, LBBZJIBDMEJ newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BYWOWYCGBMP : LBBZJIBDMEJ, ODLSFSWDFUA, IEquatable<LBBZJIBDMEJ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JYFYHVRRZIR : ODLSFSWDFUA
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		LBBZJIBDMEJ DQFMBSWSVUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<LBBZJIBDMEJ> YLAGNATNUOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 KKHCHVAXQMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion VDXWWBJUIRT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IZQFDFOQGWX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool XPUXIGYPTKW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler VWBTUXRQONI;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler XNHSJSYIUTS;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler WKAZZPRBSCX;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler NPGEUKBHUJI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void FZXCZHVXASQ();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void QNHRDDCSIVP();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void LZYWPZKFGNU();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void VTGDNYQIVGN();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void KKBRNWPWOFO(int a, LBBZJIBDMEJ b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ZESFZFJUXLO();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void GJUZVPYQGKC(int a, LBBZJIBDMEJ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void HQUJUMUTXSU(LBBZJIBDMEJ a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void XHKPLOCSZQX();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void DHUPYCJDOYU(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void ICHVXMLVAGJ(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface XPDTKUMLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 ZIUICPBPOJG
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
	public interface GGVAUXPRCOX
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool QCAWFUMCDQB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		LVTKHQEBEBW PSHZIFOQFXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, GGVAUXPRCOX
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
		public bool QCAWFUMCDQB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public LVTKHQEBEBW PSHZIFOQFXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x98BAE00", Offset = "0x98B9E00", VA = "0x1898BAE00")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x98BAEC0", Offset = "0x98B9EC0", VA = "0x1898BAEC0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LBBZJIBDMEJ connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x98BB380", Offset = "0x98BA380", VA = "0x1898BB380")]
		public ConnectableLink(LBBZJIBDMEJ connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x98BB470", Offset = "0x98BA470", VA = "0x1898BB470")]
		public ConnectableLink(LBBZJIBDMEJ connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x98BB3E0", Offset = "0x98BA3E0", VA = "0x1898BB3E0")]
		public ConnectableLink(LBBZJIBDMEJ connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x98BAF10", Offset = "0x98B9F10", VA = "0x1898BAF10", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x98BAFC0", Offset = "0x98B9FC0", VA = "0x1898BAFC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : DMPHIIYTJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform HMYJRBLVWEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private LVTKHQEBEBW DJDJZKOUWLS;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x91E4960", Offset = "0x91E3960", VA = "0x1891E4960", Slot = "4")]
		public void Initialize(Transform transform, LVTKHQEBEBW linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x98C04F0", Offset = "0x98BF4F0", VA = "0x1898C04F0", Slot = "5")]
		public LVTKHQEBEBW DIVHCOPFHFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x98C05B0", Offset = "0x98BF5B0", VA = "0x1898C05B0", Slot = "6")]
		public void TLXOHUZIJVW(LVTKHQEBEBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, APFYNIIOTGQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MOFKSSWWWKT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public LBBZJIBDMEJ ZYDKGOORHOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public LBBZJIBDMEJ UKONDQUBCHE;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public MOFKSSWWWKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x98C74A0", Offset = "0x98C64A0", VA = "0x1898C74A0")]
			internal bool LMBXVXQZPSI(LEROMENWBDV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly LJQVVJBFYYY IOTJXPWCMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private WZTOQPXFFYL GZXUCOQVQJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EZVRUSDQNAN ECSGUOTFDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool KWCHRQNURIZ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log YSOTPUCMSQP;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public LEROMENWBDV OTBMMIANHVU
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x98C3760", Offset = "0x98C2760", VA = "0x1898C3760")]
		public bool RVAFUPHKDYV([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x98C1570", Offset = "0x98C0570", VA = "0x1898C1570")]
		private bool FDUQTZMBQMI([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x98C42C0", Offset = "0x98C32C0", VA = "0x1898C42C0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x98C23C0", Offset = "0x98C13C0", VA = "0x1898C23C0", Slot = "5")]
		public void Initialize(VCIUHYJNRJC manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x98C3A70", Offset = "0x98C2A70", VA = "0x1898C3A70", Slot = "17")]
		public void WHJMRMKNWAM(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x98C3A60", Offset = "0x98C2A60", VA = "0x1898C3A60", Slot = "12")]
		public void VNNKCPVQAHJ(Func<LBBZJIBDMEJ, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x98C3930", Offset = "0x98C2930", VA = "0x1898C3930")]
		private void VNNKCPVQAHJ(LJQVVJBFYYY a, Func<LBBZJIBDMEJ, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x98C3670", Offset = "0x98C2670", VA = "0x1898C3670", Slot = "11")]
		public void PXFXRPYUODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x98C3070", Offset = "0x98C2070", VA = "0x1898C3070", Slot = "8")]
		public bool PEATYFUVERK(LBBZJIBDMEJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x98C3080", Offset = "0x98C2080", VA = "0x1898C3080")]
		private bool POMQVZRUZGV(LBBZJIBDMEJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98C1150", Offset = "0x98C0150", VA = "0x1898C1150")]
		private static bool BWYSPITSIMT(LBBZJIBDMEJ a, LJQVVJBFYYY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x98C1B30", Offset = "0x98C0B30", VA = "0x1898C1B30")]
		private void FGNGALJOWXJ(Transform a, LJQVVJBFYYY b, LJQVVJBFYYY[] c, LBBZJIBDMEJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x98C2210", Offset = "0x98C1210", VA = "0x1898C2210")]
		private ConnectableLink HDBTSIANOKG(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98C3770", Offset = "0x98C2770", VA = "0x1898C3770")]
		private static bool VJJKYCFZQSR(LJQVVJBFYYY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x98C12D0", Offset = "0x98C02D0", VA = "0x1898C12D0", Slot = "9")]
		public bool DEZQLDIGDEM(LBBZJIBDMEJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x98C2DC0", Offset = "0x98C1DC0", VA = "0x1898C2DC0")]
		private bool MZQAYHYJUWR(LBBZJIBDMEJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x98C2030", Offset = "0x98C1030", VA = "0x1898C2030")]
		private static void HAOIBCQZPSA(LBBZJIBDMEJ a, int b, int c, Vector3 d, Quaternion e, LJQVVJBFYYY f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x98C1F10", Offset = "0x98C0F10", VA = "0x1898C1F10")]
		private void GAADCDFSXSZ(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x98C13A0", Offset = "0x98C03A0", VA = "0x1898C13A0")]
		private void DTZLLTIMYAZ(LJQVVJBFYYY a, LBBZJIBDMEJ b, LBBZJIBDMEJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x98C1330", Offset = "0x98C0330", VA = "0x1898C1330")]
		private void DTZLLTIMYAZ(LBBZJIBDMEJ a, LBBZJIBDMEJ b, LBBZJIBDMEJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x98C3DE0", Offset = "0x98C2DE0", VA = "0x1898C3DE0")]
		private void YOAODTULFAG(LBBZJIBDMEJ a, LBBZJIBDMEJ b, LBBZJIBDMEJ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x98C3CE0", Offset = "0x98C2CE0", VA = "0x1898C3CE0")]
		private void YOAODTULFAG(LJQVVJBFYYY a, LBBZJIBDMEJ b, LBBZJIBDMEJ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x98C0F00", Offset = "0x98BFF00", VA = "0x1898C0F00")]
		private void AIDGHPHPZLN(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x98C2BF0", Offset = "0x98C1BF0", VA = "0x1898C2BF0")]
		private void MREOVJJMFKZ(LEROMENWBDV a, LEROMENWBDV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x98C1410", Offset = "0x98C0410", VA = "0x1898C1410", Slot = "18")]
		public LBBZJIBDMEJ EVVGACHGWQM(LBBZJIBDMEJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x98C3E50", Offset = "0x98C2E50", VA = "0x1898C3E50", Slot = "13")]
		public void ZQJLUFKDVIX(LBBZJIBDMEJ a, HashSet<LBBZJIBDMEJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x98C3AA0", Offset = "0x98C2AA0", VA = "0x1898C3AA0", Slot = "14")]
		public List<LBBZJIBDMEJ> XNFDWHWFGEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x98C3690", Offset = "0x98C2690", VA = "0x1898C3690")]
		protected LEROMENWBDV RASHZDHWKOM(LEROMENWBDV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x98C24B0", Offset = "0x98C14B0", VA = "0x1898C24B0")]
		protected LJQVVJBFYYY[] JGQCXYTJPSF(LJQVVJBFYYY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x98C2AE0", Offset = "0x98C1AE0", VA = "0x1898C2AE0")]
		protected bool MGGPFLBSQMA(LBBZJIBDMEJ a, [Out] LJQVVJBFYYY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x98C1020", Offset = "0x98C0020", VA = "0x1898C1020", Slot = "15")]
		public bool ANUEIIJJMBK(LBBZJIBDMEJ a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x98C2470", Offset = "0x98C1470", VA = "0x1898C2470")]
		protected LJQVVJBFYYY JGFPFVKDPSJ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x98C2360", Offset = "0x98C1360", VA = "0x1898C2360", Slot = "10")]
		public bool HGIWEPAUYUQ(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x98C2550", Offset = "0x98C1550", VA = "0x1898C2550")]
		private bool JPNAIRFIDHJ(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x98C1200", Offset = "0x98C0200", VA = "0x1898C1200")]
		private static bool CETJWBWYJUJ(LJQVVJBFYYY a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x98C3760", Offset = "0x98C2760", VA = "0x1898C3760", Slot = "7")]
		private bool VVKMVSEFELK([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : VCIUHYJNRJC, KBDWOSKHASX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly RZEIGZPHMMY container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly EZVRUSDQNAN ECSGUOTFDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly LSEYOBMDEVA CTLPOCEVEUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly IKZARDKUCGY EEZYSVUCIXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly APFYNIIOTGQ FJSOJALNPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal KZHYYYRRKQF EHXZKUBIMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal QWARXZNDIEG UOLRISREJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal WZTOQPXFFYL ICMYGSHFESN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool KWCHRQNURIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool NMZIUWCPJGG;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool BLMLXMGLFQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xD42610", Offset = "0xD41610", VA = "0x180D42610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD42120", Offset = "0xD41120", VA = "0x180D42120")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ZANTMLNUIXH
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x132BF40", Offset = "0x132AF40", VA = "0x18132BF40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x285F980", Offset = "0x285E980", VA = "0x18285F980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool YAMYZTVVWMN
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QAMJPZGYVJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x98C5F60", Offset = "0x98C4F60", VA = "0x1898C5F60", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x98C5C50", Offset = "0x98C4C50", VA = "0x1898C5C50", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ> QWAKMQBZCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x98C5790", Offset = "0x98C4790", VA = "0x1898C5790", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x98C4470", Offset = "0x98C3470", VA = "0x1898C4470", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<LBBZJIBDMEJ, LBBZJIBDMEJ, LBBZJIBDMEJ> DATVCXBUOEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x98C5730", Offset = "0x98C4730", VA = "0x1898C5730", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x98C5F00", Offset = "0x98C4F00", VA = "0x1898C5F00", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x98C60F0", Offset = "0x98C50F0", VA = "0x1898C60F0")]
		public LegacyConnectableManager(RZEIGZPHMMY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x98C49B0", Offset = "0x98C39B0", VA = "0x1898C49B0", Slot = "12")]
		public void Initialize(GameObject gameObject, GGVAUXPRCOX configData, MTIDGMXGFWY rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x98C48E0", Offset = "0x98C38E0", VA = "0x1898C48E0", Slot = "26")]
		public void IPPIPTCNVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x98C5BD0", Offset = "0x98C4BD0", VA = "0x1898C5BD0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x98C57F0", Offset = "0x98C47F0", VA = "0x1898C57F0", Slot = "14")]
		public void OTSRDIPIITJ(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x98C4620", Offset = "0x98C3620", VA = "0x1898C4620", Slot = "15")]
		public void FXHLRCDUIQY(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x98C4800", Offset = "0x98C3800", VA = "0x1898C4800", Slot = "22")]
		public bool HTXXUVPLHWK(LZBUEEHACUI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x98C4F70", Offset = "0x98C3F70", VA = "0x1898C4F70")]
		internal bool JPNAIRFIDHJ([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x98C44D0", Offset = "0x98C34D0", VA = "0x1898C44D0")]
		internal bool EGKKGGCEUUV([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x98C5810", Offset = "0x98C4810", VA = "0x1898C5810")]
		internal void QPZZFGQGQGF(LBBZJIBDMEJ a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x98C4620", Offset = "0x98C3620", VA = "0x1898C4620")]
		internal bool QNGUBSRKDIZ(LBBZJIBDMEJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x98C59F0", Offset = "0x98C49F0", VA = "0x1898C59F0")]
		internal bool QZKZMPCDZQH(LBBZJIBDMEJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x98C6000", Offset = "0x98C5000", VA = "0x1898C6000", Slot = "16")]
		public void ZQJLUFKDVIX(LBBZJIBDMEJ a, HashSet<LBBZJIBDMEJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x98C5240", Offset = "0x98C4240", VA = "0x1898C5240", Slot = "17")]
		public void KHAIGMRFAHR(LBBZJIBDMEJ a, LBBZJIBDMEJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x98C55F0", Offset = "0x98C45F0", VA = "0x1898C55F0", Slot = "18")]
		public void LPUNEXSLZTX(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x98C5080", Offset = "0x98C4080", VA = "0x1898C5080", Slot = "19")]
		public void JQKDUSEGDKF(LBBZJIBDMEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x98C5CB0", Offset = "0x98C4CB0", VA = "0x1898C5CB0")]
		public void WOMTSHALDMA([Optional] QCTMRFTYWMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x98C4850", Offset = "0x98C3850", VA = "0x1898C4850", Slot = "23")]
		public void IINZHIAYXEJ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x98C4680", Offset = "0x98C3680", VA = "0x1898C4680", Slot = "20")]
		public ConnectableGraphData GKRVUXJUBGU(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x98C5450", Offset = "0x98C4450", VA = "0x1898C5450", Slot = "21")]
		public ConnectableGraphData LOFXDBZEBPO(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x98C5FC0", Offset = "0x98C4FC0", VA = "0x1898C5FC0", Slot = "25")]
		public void ZHGBUEICMKO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x98C5B20", Offset = "0x98C4B20", VA = "0x1898C5B20", Slot = "24")]
		public void TNHSEAKFXJL(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class EZVRUSDQNAN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly BQLCIBMFVQW<LBBZJIBDMEJ, LBBZJIBDMEJ> QAMJPZGYVJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly BQLCIBMFVQW<LBBZJIBDMEJ, LBBZJIBDMEJ> QWAKMQBZCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly BQQJFIGDFCF<LBBZJIBDMEJ, LBBZJIBDMEJ, LBBZJIBDMEJ> DATVCXBUOEG;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x98BB790", Offset = "0x98BA790", VA = "0x1898BB790")]
		public EZVRUSDQNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x98BB730", Offset = "0x98BA730", VA = "0x1898BB730")]
		public void WEMRFUDQVZW(LBBZJIBDMEJ a, LBBZJIBDMEJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x98BB650", Offset = "0x98BA650", VA = "0x1898BB650")]
		public void NVLDPQNHLSS(LBBZJIBDMEJ a, LBBZJIBDMEJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x98BB6B0", Offset = "0x98BA6B0", VA = "0x1898BB6B0")]
		public void RGWHVZJSGOW(LBBZJIBDMEJ a, LBBZJIBDMEJ b, LBBZJIBDMEJ c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class LSEYOBMDEVA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager RVAMSININVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private QWARXZNDIEG UOLRISREJII;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public LSEYOBMDEVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x98C0110", Offset = "0x98BF110", VA = "0x1898C0110")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x98C0100", Offset = "0x98BF100", VA = "0x1898C0100", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98C03B0", Offset = "0x98BF3B0", VA = "0x1898C03B0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x98C0340", Offset = "0x98BF340", VA = "0x1898C0340")]
		private void OnMasterClientSwitched(QCTMRFTYWMB newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x98C0240", Offset = "0x98BF240", VA = "0x1898C0240")]
		public void KMMJNOXNORM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x98C03F0", Offset = "0x98BF3F0", VA = "0x1898C03F0")]
		public void ZLGRXZVUVKN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class RNVVHKMRZTW
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class VBNXNXLVIWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public RZEIGZPHMMY container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VBNXNXLVIWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x98CF1A0", Offset = "0x98CE1A0", VA = "0x1898CF1A0")]
			internal LegacyConnectableManager OQNEWUGVSCB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x98CE400", Offset = "0x98CD400", VA = "0x1898CE400")]
		public static void QFBJTNLQHDT(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x98CE380", Offset = "0x98CD380", VA = "0x1898CE380")]
		public static void PIDRHJKBNWS(RZEIGZPHMMY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, WZTOQPXFFYL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, LVTKHQEBEBW> KXQJVOTVDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation TFGWCMRMNUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private DMPHIIYTJAM XLXCYWBQZNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private APFYNIIOTGQ FJSOJALNPCO;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker JABBKWMYGCE;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x98C7240", Offset = "0x98C6240", VA = "0x1898C7240")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x98C6A30", Offset = "0x98C5A30", VA = "0x1898C6A30", Slot = "7")]
		public void Initialize(APFYNIIOTGQ graph, DMPHIIYTJAM creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x98C6CC0", Offset = "0x98C5CC0", VA = "0x1898C6CC0", Slot = "5")]
		public void NWEHUHWEISV(LEROMENWBDV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x98C67F0", Offset = "0x98C57F0", VA = "0x1898C67F0", Slot = "9")]
		public void HGHPPEMKZOM(LEROMENWBDV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x98C6480", Offset = "0x98C5480", VA = "0x1898C6480", Slot = "8")]
		public void BTCORUUZQMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x98C6A70", Offset = "0x98C5A70", VA = "0x1898C6A70", Slot = "10")]
		public void KFNJTBNGUGL(LEROMENWBDV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x98C7090", Offset = "0x98C6090", VA = "0x1898C7090", Slot = "11")]
		public void OYHENNDZPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x98C6640", Offset = "0x98C5640", VA = "0x1898C6640")]
		private bool FDQGERTVPSK(LEROMENWBDV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class IKZARDKUCGY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly LJQVVJBFYYY currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly LZBUEEHACUI parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly LZBUEEHACUI rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool MXXJSUROYFR
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x98CE9C0", Offset = "0x98CD9C0", VA = "0x1898CE9C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x98CEE90", Offset = "0x98CDE90", VA = "0x1898CEE90")]
			public SerializeNodeInSubgraph(LJQVVJBFYYY currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] LZBUEEHACUI parentNodeData, [Optional] LZBUEEHACUI rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x98CE5F0", Offset = "0x98CD5F0", VA = "0x1898CE5F0")]
			public LZBUEEHACUI BIDIANLANQI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x98CE900", Offset = "0x98CD900", VA = "0x1898CE900")]
			private LZBUEEHACUI JCZMADJBITC([Out] LZBUEEHACUI a, [Out] LZBUEEHACUI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x98CEC90", Offset = "0x98CDC90", VA = "0x1898CEC90")]
			private LZBUEEHACUI YBQHYZTQHPW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x98CE790", Offset = "0x98CD790", VA = "0x1898CE790")]
			private void HTIFKLDQITM(LZBUEEHACUI a, LZBUEEHACUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x98CEAD0", Offset = "0x98CDAD0", VA = "0x1898CEAD0")]
			private void QYYMFGUCPLB(LZBUEEHACUI a, LZBUEEHACUI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager RVAMSININVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private APFYNIIOTGQ FJSOJALNPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private WZTOQPXFFYL GZXUCOQVQJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private QWARXZNDIEG UOLRISREJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool QZSMNQTWVJM;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool CCVCSHHMDRF
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x98BE1F0", Offset = "0x98BD1F0", VA = "0x1898BE1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool BLMLXMGLFQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x98BD150", Offset = "0x98BC150", VA = "0x1898BD150")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x98BE3E0", Offset = "0x98BD3E0", VA = "0x1898BE3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x98BDE10", Offset = "0x98BCE10", VA = "0x1898BDE10")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x98BD460", Offset = "0x98BC460", VA = "0x1898BD460")]
		public ConnectableGraphData GKRVUXJUBGU(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x98BE240", Offset = "0x98BD240", VA = "0x1898BE240")]
		public ConnectableGraphData LOFXDBZEBPO(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x98BDD80", Offset = "0x98BCD80", VA = "0x1898BDD80")]
		public void IINZHIAYXEJ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x98BEE10", Offset = "0x98BDE10", VA = "0x1898BEE10")]
		public void TNHSEAKFXJL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x98BD430", Offset = "0x98BC430", VA = "0x1898BD430")]
		public void DPBIBTRETXB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x98BD910", Offset = "0x98BC910", VA = "0x1898BD910")]
		private void HDILKFKTTBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x98BEF40", Offset = "0x98BDF40", VA = "0x1898BEF40")]
		private LZBUEEHACUI YGOQRNCGOCG(LJQVVJBFYYY a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x98BE400", Offset = "0x98BD400", VA = "0x1898BE400")]
		private static void MYSBUJLQEBW(LJQVVJBFYYY a, bool b, LZBUEEHACUI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x98BE6B0", Offset = "0x98BD6B0", VA = "0x1898BE6B0")]
		private void NJFPDIZAEBF(LJQVVJBFYYY a, bool b, LZBUEEHACUI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x98BEEB0", Offset = "0x98BDEB0", VA = "0x1898BEEB0")]
		private LZBUEEHACUI TRUMKMXBIIC(LJQVVJBFYYY a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x98BDF70", Offset = "0x98BCF70", VA = "0x1898BDF70")]
		private bool JVYDJOLETPC(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x98BCAC0", Offset = "0x98BBAC0", VA = "0x1898BCAC0")]
		private bool AEBDZUVVSYJ(LZBUEEHACUI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x98BD130", Offset = "0x98BC130", VA = "0x1898BD130")]
		private bool CERZOOXAOCX(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x98BF020", Offset = "0x98BE020", VA = "0x1898BF020")]
		private static bool YTRHQRURRDY(LZBUEEHACUI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x98BDAF0", Offset = "0x98BCAF0", VA = "0x1898BDAF0")]
		public static bool HTXXUVPLHWK(LZBUEEHACUI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x98BD5D0", Offset = "0x98BC5D0", VA = "0x1898BD5D0")]
		private LBBZJIBDMEJ GPHTGXKHQAY(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x98BEC90", Offset = "0x98BDC90", VA = "0x1898BEC90")]
		private LBBZJIBDMEJ SJGACMSMPWK(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x98BEAC0", Offset = "0x98BDAC0", VA = "0x1898BEAC0")]
		private LBBZJIBDMEJ PSLRGFQOGDP(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x98BEC50", Offset = "0x98BDC50", VA = "0x1898BEC50")]
		private static Guid QWBLWSRNUQH(LZBUEEHACUI a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x98BDE80", Offset = "0x98BCE80", VA = "0x1898BDE80")]
		private string JHPNOAIFXWO(LZBUEEHACUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x98BE8D0", Offset = "0x98BD8D0", VA = "0x1898BE8D0")]
		private bool PNWUTXYVCJL(LJQVVJBFYYY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x98BD170", Offset = "0x98BC170", VA = "0x1898BD170")]
		private static void CMJZXANJEPT(LJQVVJBFYYY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public IKZARDKUCGY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public LBBZJIBDMEJ child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public LBBZJIBDMEJ parent;

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
		public ConnectableLink YRJAGRZLSOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x98BB510", Offset = "0x98BA510", VA = "0x1898BB510")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink MDZEOZIAMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x98BB5B0", Offset = "0x98BA5B0", VA = "0x1898BB5B0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x98BB5E0", Offset = "0x98BA5E0", VA = "0x1898BB5E0")]
		public ConnectionOperationData(LBBZJIBDMEJ child, LBBZJIBDMEJ parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface APFYNIIOTGQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		LEROMENWBDV OTBMMIANHVU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(VCIUHYJNRJC manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RVAFUPHKDYV([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PEATYFUVERK(LBBZJIBDMEJ a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DEZQLDIGDEM(LBBZJIBDMEJ a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HGIWEPAUYUQ(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PXFXRPYUODJ();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VNNKCPVQAHJ(Func<LBBZJIBDMEJ, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ZQJLUFKDVIX(LBBZJIBDMEJ a, HashSet<LBBZJIBDMEJ> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<LBBZJIBDMEJ> XNFDWHWFGEH();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ANUEIIJJMBK(LBBZJIBDMEJ a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WHJMRMKNWAM(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(LEROMENWBDV node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface LEROMENWBDV
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		LBBZJIBDMEJ YIEOMYNRXQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		LEROMENWBDV QVPRBHQGWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink JEXOILDKCLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool RDEINAKRALQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface LVTKHQEBEBW : EHYDQQTNUEQ.PZTXZFMPQRQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KWSQHQMQIDG(LBBZJIBDMEJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LIBAXNTBLEI(LBBZJIBDMEJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UAZSFYSGBEZ(LBBZJIBDMEJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ESXNMWMCFKH(LBBZJIBDMEJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LVTKHQEBEBW OZOAAOTFZLM(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface DMPHIIYTJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, LVTKHQEBEBW linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LVTKHQEBEBW DIVHCOPFHFA();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TLXOHUZIJVW(LVTKHQEBEBW a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface KZHYYYRRKQF : QCRDCEJGMDC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DSUSWSECYWT();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KGXJJBFPNSS(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface WZTOQPXFFYL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NWEHUHWEISV(LEROMENWBDV a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(APFYNIIOTGQ graph, DMPHIIYTJAM linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BTCORUUZQMS();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HGHPPEMKZOM(LEROMENWBDV a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KFNJTBNGUGL(LEROMENWBDV a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OYHENNDZPMH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LJQVVJBFYYY : LEROMENWBDV
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class BDVTHNLLPQS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink QVFDXCHLFJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public LJQVVJBFYYY MIXILMKNYUW;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BDVTHNLLPQS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x98BACC0", Offset = "0x98B9CC0", VA = "0x1898BACC0")]
			internal bool HSSNTRJTLVT(LEROMENWBDV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink VUIOERMUYTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<LJQVVJBFYYY> BKYSRCUXUVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private LJQVVJBFYYY DXTWVIEZEAT;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink JEXOILDKCLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x516FA90", Offset = "0x516EA90", VA = "0x18516FA90", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x98BFAA0", Offset = "0x98BEAA0", VA = "0x1898BFAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private LJQVVJBFYYY KPYZQONRQFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x98BF5D0", Offset = "0x98BE5D0", VA = "0x1898BF5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public LEROMENWBDV QVPRBHQGWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public LBBZJIBDMEJ YIEOMYNRXQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool RDEINAKRALQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x98BF820", Offset = "0x98BE820", VA = "0x1898BF820", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool BSJBYBDFSPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x98BFED0", Offset = "0x98BEED0", VA = "0x1898BFED0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected LJQVVJBFYYY DIIJJEHZBXI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x98BF800", Offset = "0x98BE800", VA = "0x1898BF800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x98C0060", Offset = "0x98BF060", VA = "0x1898C0060")]
		public LJQVVJBFYYY(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x98BFF20", Offset = "0x98BEF20", VA = "0x1898BFF20")]
		public LJQVVJBFYYY ZGUAUCXGOAN(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x98BF920", Offset = "0x98BE920", VA = "0x1898BF920")]
		public LJQVVJBFYYY JWOCXHRQHWZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x98BFAD0", Offset = "0x98BEAD0", VA = "0x1898BFAD0")]
		public LJQVVJBFYYY Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x98BF6B0", Offset = "0x98BE6B0", VA = "0x1898BF6B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x98BFCB0", Offset = "0x98BECB0", VA = "0x1898BFCB0")]
		public LJQVVJBFYYY Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x98BFD70", Offset = "0x98BED70", VA = "0x1898BFD70")]
		private static void WHJMRMKNWAM(LJQVVJBFYYY a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x98BFD60", Offset = "0x98BED60", VA = "0x1898BFD60", Slot = "9")]
		public void WHJMRMKNWAM(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x98BF830", Offset = "0x98BE830", VA = "0x1898BF830")]
		public static LJQVVJBFYYY JGFPFVKDPSJ(LJQVVJBFYYY a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface QWARXZNDIEG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool CCVCSHHMDRF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> VRQZAPYFZQT;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<QCTMRFTYWMB> MNPMNJIRUQX;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void KWSQHQMQIDG(LegacyConnectableManager a, MTIDGMXGFWY b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void KHAIGMRFAHR(LBBZJIBDMEJ a, LBBZJIBDMEJ b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void LPUNEXSLZTX(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void JYQPPLLKCTK(ConnectableGraphData a, [Optional] QCTMRFTYWMB b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class OVGKXSKWNUY
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x98CE130", Offset = "0x98CD130", VA = "0x1898CE130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x98CE180", Offset = "0x98CD180", VA = "0x1898CE180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x98CE0D0", Offset = "0x98CD0D0", VA = "0x1898CE0D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class HHWUJNYKPFR : QWARXZNDIEG, IDisposable, RZFGOWBBJPW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager RVAMSININVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private MTIDGMXGFWY VBWCYGAOEOQ;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool CCVCSHHMDRF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x98BBAC0", Offset = "0x98BAAC0", VA = "0x1898BBAC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x98BC700", Offset = "0x98BB700", VA = "0x1898BC700", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView TCOPNGPPKGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x98BC740", Offset = "0x98BB740", VA = "0x1898BC740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> VRQZAPYFZQT
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x98BBA20", Offset = "0x98BAA20", VA = "0x1898BBA20", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x98BB930", Offset = "0x98BA930", VA = "0x1898BB930", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<QCTMRFTYWMB> MNPMNJIRUQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x98BBF10", Offset = "0x98BAF10", VA = "0x1898BBF10", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x98BB890", Offset = "0x98BA890", VA = "0x1898BB890", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x98BBD60", Offset = "0x98BAD60", VA = "0x1898BBD60", Slot = "10")]
		public void KWSQHQMQIDG(LegacyConnectableManager a, MTIDGMXGFWY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x98BB9D0", Offset = "0x98BA9D0", VA = "0x1898BB9D0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x98BBC40", Offset = "0x98BAC40", VA = "0x1898BBC40", Slot = "11")]
		public void KHAIGMRFAHR(LBBZJIBDMEJ a, LBBZJIBDMEJ b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x98BBDF0", Offset = "0x98BADF0", VA = "0x1898BBDF0", Slot = "12")]
		public void LPUNEXSLZTX(LBBZJIBDMEJ a, int b, LBBZJIBDMEJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x98BBB20", Offset = "0x98BAB20", VA = "0x1898BBB20", Slot = "13")]
		public void JYQPPLLKCTK(ConnectableGraphData a, [Optional] QCTMRFTYWMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x98BC1E0", Offset = "0x98BB1E0", VA = "0x1898BC1E0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(LBBZJIBDMEJ objectToReparent, int objectToReparentSlotIndex, LBBZJIBDMEJ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x98BBFF0", Offset = "0x98BAFF0", VA = "0x1898BBFF0")]
		[RPCMethod]
		private void RpcMasterModifyNode(LBBZJIBDMEJ connectableToModify, LBBZJIBDMEJ expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x98BC5D0", Offset = "0x98BB5D0", VA = "0x1898BC5D0")]
		[RPCMethod]
		private void RpcReparentNodes(LBBZJIBDMEJ objectToReparent, int objectToReparentSlotIndex, LBBZJIBDMEJ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x98BC4E0", Offset = "0x98BB4E0", VA = "0x1898BC4E0")]
		[RPCMethod]
		private void RpcModifyNode(LBBZJIBDMEJ connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x98BBFB0", Offset = "0x98BAFB0", VA = "0x1898BBFB0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public HHWUJNYKPFR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, LVTKHQEBEBW, EHYDQQTNUEQ.PZTXZFMPQRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x98C0A80", Offset = "0x98BFA80", VA = "0x1898C0A80", Slot = "4")]
		private void MKYSAVDYYCH(LBBZJIBDMEJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x98C0620", Offset = "0x98BF620", VA = "0x1898C0620", Slot = "5")]
		private void BBYCPZLLSHR(LBBZJIBDMEJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x98C0C70", Offset = "0x98BFC70", VA = "0x1898C0C70", Slot = "6")]
		private void QSODZZTPVEA(LBBZJIBDMEJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x98C0890", Offset = "0x98BF890", VA = "0x1898C0890", Slot = "7")]
		private void BDTXTVGPJTG(LBBZJIBDMEJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x98C0C00", Offset = "0x98BFC00", VA = "0x1898C0C00", Slot = "8")]
		private LVTKHQEBEBW OUNEPDZJHMH(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x98C0EA0", Offset = "0x98BFEA0", VA = "0x1898C0EA0", Slot = "9")]
		private void VAAWSXVMEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class VVUAXYJVZSC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x409B430", Offset = "0x409A430", VA = "0x18409B430")]
		public static HFEFVUXKTHP<a> SXHPRASIZBO<a>(this RZEIGZPHMMY a)
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
