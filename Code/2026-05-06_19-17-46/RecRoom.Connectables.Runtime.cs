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
		[Cpp2IlInjected.Address(RVA = "0x976EF40", Offset = "0x976D940", VA = "0x18976EF40", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		private int[] YTBMQLWISIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] YTGTNSQGBUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset TSFXVIKPUMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset TSAQYBQSLBM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2234620", Offset = "0x2233020", VA = "0x182234620", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x977AC10", Offset = "0x9779610", VA = "0x18977AC10")]
		private void BAZLOGTATAR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x977AAC0", Offset = "0x97794C0", VA = "0x18977AAC0")]
		private void BAUEQZZDJPI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x977AD60", Offset = "0x9779760", VA = "0x18977AD60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x977B070", Offset = "0x9779A70", VA = "0x18977B070")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : WHFAQEXZBGY, CKGGJPDKIOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class LINMOVFAHAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public XGIWHMXMAZG VNYERIEXAJQ;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LINMOVFAHAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9767C10", Offset = "0x9766610", VA = "0x189767C10")]
			internal object GRXPHOSICVP(XGIWHMXMAZG a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class LISTMBYXQLX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public XGIWHMXMAZG NQGQZNOUDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LINMOVFAHAO IYWFXXOWUJJ;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LISTMBYXQLX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9767C80", Offset = "0x9766680", VA = "0x189767C80")]
			internal object GRSIKHYKTKG((XGIWHMXMAZG child, XGIWHMXMAZG nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class VJOIZZFLFVH : IEnumerable<FDCMNUSABYN>, IEnumerable, IEnumerator<FDCMNUSABYN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private FDCMNUSABYN BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId CQUELWWGPZS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId SUIGYLEEMXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private RKBNVLUDGXD QLDEBRDPIGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray VYOCGJJSSQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator MWWLVOEAKRO;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private FDCMNUSABYN NNOIDXONMVN
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public VJOIZZFLFVH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9779670", Offset = "0x9778070", VA = "0x189779670", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9779310", Offset = "0x9777D10", VA = "0x189779310", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9779220", Offset = "0x9777C20", VA = "0x189779220")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9779240", Offset = "0x9777C40", VA = "0x189779240")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9779750", Offset = "0x9778150", VA = "0x189779750", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9779260", Offset = "0x9777C60", VA = "0x189779260", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FDCMNUSABYN> MKQPFAQUTCI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9779260", Offset = "0x9777C60", VA = "0x189779260", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log DRVMQNGDUQN;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log ZMVUVHAKKUV;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log HRBRCCNSPWN;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log KUNXZYLYGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private EZBXGBRAYMI IRPCRUOCZBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IEJAKBNAYGH ULSOVSMCUER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PVEBGQEABJY KFZOBTWJBTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CXXEOSQREMY YTLVACUUSYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ULOYIOSOHHK QEUUUXQWRQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private WXIZECOMGTO AIDXCYAPGYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly JGQLCFRSMHH HSJFTMYTZCK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E20", Offset = "0xCD5820", VA = "0x180CD6E20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C70", Offset = "0xCD5670", VA = "0x180CD6C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool XSGSHESZJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x97731C0", Offset = "0x9771BC0", VA = "0x1897731C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x97710D0", Offset = "0x976FAD0", VA = "0x1897710D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x976F740", Offset = "0x976E140", VA = "0x18976F740", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9771EA0", Offset = "0x97708A0", VA = "0x189771EA0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x976F880", Offset = "0x976E280", VA = "0x18976F880", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x97716A0", Offset = "0x97700A0", VA = "0x1897716A0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9773C00", Offset = "0x9772600", VA = "0x189773C00")]
		public OMConnectableManager(TFZCSWYZDKY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9770D60", Offset = "0x976F760", VA = "0x189770D60", Slot = "12")]
		public void Initialize(GameObject gameObject, JVVGTLYPYDF configData, JQNWKRJJETK sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9773590", Offset = "0x9771F90", VA = "0x189773590", Slot = "26")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9771080", Offset = "0x976FA80", VA = "0x189771080", Slot = "22")]
		public bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9771AC0", Offset = "0x97704C0", VA = "0x189771AC0")]
		private void REKRDWJUIEL(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9773760", Offset = "0x9772160", VA = "0x189773760")]
		private void ZNQTQERCDAR(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9770B00", Offset = "0x976F500", VA = "0x189770B00")]
		private void IYUGFSBUHPV(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x976FDD0", Offset = "0x976E7D0", VA = "0x18976FDD0")]
		private void GXYJOEPEVUA(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9770770", Offset = "0x976F170", VA = "0x189770770", Slot = "14")]
		public void GZVUEGYMGMP(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "15")]
		public void BAEWWTPIDYE(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9771890", Offset = "0x9770290", VA = "0x189771890", Slot = "17")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9771750", Offset = "0x9770150", VA = "0x189771750")]
		public void OJQDSXEAQDZ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9770A70", Offset = "0x976F470", VA = "0x189770A70")]
		public void HEHVMXGFEAJ(FDCMNUSABYN a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x976F9A0", Offset = "0x976E3A0", VA = "0x18976F9A0", Slot = "18")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9770FD0", Offset = "0x976F9D0", VA = "0x189770FD0")]
		private float JDRTGNASOST(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x976FB00", Offset = "0x976E500", VA = "0x18976FB00")]
		public void DSBRXLZNZVL(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x97701E0", Offset = "0x976EBE0", VA = "0x1897701E0", Slot = "19")]
		public void GYUSVGQTDMR(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x976F250", Offset = "0x976DC50", VA = "0x18976F250", Slot = "16")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "20")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "21")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x976F930", Offset = "0x976E330", VA = "0x18976F930", Slot = "23")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9771A50", Offset = "0x9770450", VA = "0x189771A50", Slot = "24")]
		public void PWEZWQWXDQN(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9770750", Offset = "0x976F150", VA = "0x189770750", Slot = "25")]
		public void GZEGFODBACO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9770350", Offset = "0x976ED50", VA = "0x189770350")]
		private void GYVDTHLUYVH(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9771F50", Offset = "0x9770950", VA = "0x189771F50")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x976F450", Offset = "0x976DE50", VA = "0x18976F450")]
		private void AVMRQIHKPYW(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x976F7F0", Offset = "0x976E1F0", VA = "0x18976F7F0")]
		[IteratorStateMachine(typeof(VJOIZZFLFVH))]
		public IEnumerable<FDCMNUSABYN> CHWEROEDEDN(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9771570", Offset = "0x976FF70", VA = "0x189771570")]
		internal FDCMNUSABYN NEXEUIUBAIA(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9773400", Offset = "0x9771E00", VA = "0x189773400")]
		internal ObjectLocalId YEGVSRNGPIA(FDCMNUSABYN a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97729C0", Offset = "0x97713C0", VA = "0x1897729C0")]
		private bool TVLTVJGSWVX(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9771180", Offset = "0x976FB80", VA = "0x189771180")]
		private bool LUIOCENIZFT(XGIWHMXMAZG a, [Out] FDCMNUSABYN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97711E0", Offset = "0x976FBE0", VA = "0x1897711E0")]
		private FDCMNUSABYN NEXEUIUBAIA(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9772840", Offset = "0x9771240", VA = "0x189772840")]
		private FDCMNUSABYN TOBKWPJDCSJ(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9771CD0", Offset = "0x97706D0", VA = "0x189771CD0")]
		private FDCMNUSABYN SOEQBKUCLMW(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x976F210", Offset = "0x976DC10", VA = "0x18976F210")]
		private static Guid AIEZLMUBTVB(XGIWHMXMAZG a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9772F40", Offset = "0x9771940", VA = "0x189772F40")]
		private string VGYCTKPBJXE(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9773270", Offset = "0x9771C70", VA = "0x189773270")]
		private void YAJAYZVZQJP(FDCMNUSABYN a, FDCMNUSABYN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9773030", Offset = "0x9771A30", VA = "0x189773030")]
		private void VKHFVFHVYOL(FDCMNUSABYN a, FDCMNUSABYN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x97719F0", Offset = "0x97703F0", VA = "0x1897719F0")]
		private void PGTPBQEBTYV(FDCMNUSABYN a, FDCMNUSABYN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x976FC40", Offset = "0x976E640", VA = "0x18976FC40")]
		private void EGGAKIUEUIQ(FDCMNUSABYN a, FDCMNUSABYN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9773980", Offset = "0x9772380", VA = "0x189773980")]
		private void ZWBRPSTZJMR(ObjectLocalId a, FDCMNUSABYN b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x976F4C0", Offset = "0x976DEC0", VA = "0x18976F4C0")]
		private void BAIRYGHPUHM(ObjectLocalId a, FDCMNUSABYN b, FDCMNUSABYN c, FDCMNUSABYN d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class YOUGPGAOOOX
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TFZCSWYZDKY container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x97798E0", Offset = "0x97782E0", VA = "0x1897798E0")]
			internal OMConnectableManager VWBTPSTHWCJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9779E20", Offset = "0x9778820", VA = "0x189779E20")]
		public static void TNIPUGRPWFD(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9779DD0", Offset = "0x97787D0", VA = "0x189779DD0")]
		public static void QGEULEGTWDU(TFZCSWYZDKY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : PJMXSXZJDTD, YKTNJQPEWBK
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager VZHPNFOISSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly CLLWOCGEPVF OROZCCKXOQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly XVDZVXXBHNX YTLVACUUSYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly RXRJFQKKODH[] RRFVIQJUYLH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FDCMNUSABYN ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9775810", Offset = "0x9774210", VA = "0x189775810", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FDCMNUSABYN LPDHWBSBATS
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9774CC0", Offset = "0x97736C0", VA = "0x189774CC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 TJSAEJFVSHS
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x97754A0", Offset = "0x9773EA0", VA = "0x1897754A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion IYXMSAHRVYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x97741C0", Offset = "0x9772BC0", VA = "0x1897741C0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JUVNCRVBGYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9774220", Offset = "0x9772C20", VA = "0x189774220", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<FDCMNUSABYN> UDLKKLANTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9774050", Offset = "0x9772A50", VA = "0x189774050", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool UWKWDYWEDZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD7B880", Offset = "0xD7A280", VA = "0x180D7B880", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE700D0", Offset = "0xE6EAD0", VA = "0x180E700D0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9775A10", Offset = "0x9774410", VA = "0x189775A10", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9775730", Offset = "0x9774130", VA = "0x189775730", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9775750", Offset = "0x9774150", VA = "0x189775750", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9775870", Offset = "0x9774270", VA = "0x189775870", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9775950", Offset = "0x9774350", VA = "0x189775950", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool NHEZHBFUXHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9774170", Offset = "0x9772B70", VA = "0x189774170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler RADTLCPOTOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9774000", Offset = "0x9772A00", VA = "0x189774000", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9774400", Offset = "0x9772E00", VA = "0x189774400", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler AQEHXBXGYAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9774A60", Offset = "0x9773460", VA = "0x189774A60", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9774D80", Offset = "0x9773780", VA = "0x189774D80", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler MZNNGPCBUPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9774290", Offset = "0x9772C90", VA = "0x189774290", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x97742E0", Offset = "0x9772CE0", VA = "0x1897742E0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler TZLWXMLKQHM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9774E70", Offset = "0x9773870", VA = "0x189774E70", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9775500", Offset = "0x9773F00", VA = "0x189775500", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9775630", Offset = "0x9774030", VA = "0x189775630")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, CLLWOCGEPVF connectableTool, RXRJFQKKODH[] connectionPoints, XVDZVXXBHNX callbacks, WHFAQEXZBGY connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9773C70", Offset = "0x9772670", VA = "0x189773C70", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "21")]
		public void DDZNCGUGHRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9775100", Offset = "0x9773B00", VA = "0x189775100", Slot = "22")]
		public void QFSFWVDXGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9775450", Offset = "0x9773E50", VA = "0x189775450", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9774AB0", Offset = "0x97734B0", VA = "0x189774AB0", Slot = "25")]
		public void ITBABRLNOZG(int a, FDCMNUSABYN b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9774330", Offset = "0x9772D30", VA = "0x189774330", Slot = "26")]
		public void GFLAOKEDBFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9773D20", Offset = "0x9772720", VA = "0x189773D20", Slot = "27")]
		public void BHUPFAYRLFA(int a, FDCMNUSABYN b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9773CA0", Offset = "0x97726A0", VA = "0x189773CA0", Slot = "28")]
		public void BGYLPYLJOXO(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9774450", Offset = "0x9772E50", VA = "0x189774450", Slot = "31")]
		public void GXRNACTKRIB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9775120", Offset = "0x9773B20", VA = "0x189775120", Slot = "29")]
		public void QPFQUGDKTDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9774F10", Offset = "0x9773910", VA = "0x189774F10", Slot = "30")]
		public void PRJSGRZFJNO(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9774990", Offset = "0x9773390", VA = "0x189774990", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9774860", Offset = "0x9773260", VA = "0x189774860", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD3DCA0", Offset = "0xD3C6A0", VA = "0x180D3DCA0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x97740D0", Offset = "0x9772AD0", VA = "0x1897740D0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, FDCMNUSABYN otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "44")]
		public void ParentChanged(int slotIndex, FDCMNUSABYN newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "45")]
		public void ChildAdded(int slotIndex, FDCMNUSABYN newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "46")]
		public void ChildRemoved(int slotIndex, FDCMNUSABYN removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "47")]
		public void ConnectionModified(int slotIndex, FDCMNUSABYN parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9775430", Offset = "0x9773E30", VA = "0x189775430", Slot = "48")]
		public void RootChanged(FDCMNUSABYN previousRootConnectable, FDCMNUSABYN newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9774E20", Offset = "0x9773820", VA = "0x189774E20", Slot = "23")]
		public void PJFVDPAQZYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9774080", Offset = "0x9772A80", VA = "0x189774080", Slot = "24")]
		public void CKEDQPRWOZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9774DD0", Offset = "0x97737D0", VA = "0x189774DD0")]
		private void LJEMQKNQWQP(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(VTSCJVWHWHC), new string[] { })]
	public class VQYBHBNYQQB : VTSCJVWHWHC, DYGRHSQNQBH, TQABOQMECSF
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EZWOGTCCREE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public EZWOGTCCREE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private LJOJBYIDAVC XBICCVOMZEX;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object AVWBHNNYUOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x97797E0", Offset = "0x97781E0", VA = "0x1897797E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9779790", Offset = "0x9778190", VA = "0x189779790", Slot = "5")]
		private void LJERCYKGCZL(GEZRGCKOUXX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF45780", Offset = "0xF44180", VA = "0x180F45780", Slot = "6")]
		private void XGDIBOIJOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public VQYBHBNYQQB()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(WHFAQEXZBGY), new string[] { "Ignore", "Mock" })]
	public class QDSQGHTRAIZ : WHFAQEXZBGY, CKGGJPDKIOP
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool XSGSHESZJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9775DA0", Offset = "0x97747A0", VA = "0x189775DA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9775B90", Offset = "0x9774590", VA = "0x189775B90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9775A30", Offset = "0x9774430", VA = "0x189775A30", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9775CF0", Offset = "0x97746F0", VA = "0x189775CF0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9775AE0", Offset = "0x97744E0", VA = "0x189775AE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9775C40", Offset = "0x9774640", VA = "0x189775C40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "26")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "12")]
		public void Initialize(GameObject gameObject, JVVGTLYPYDF configData, JQNWKRJJETK rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "14")]
		public void GZVUEGYMGMP(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "15")]
		public void BAEWWTPIDYE(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "16")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "17")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "18")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "19")]
		public void GYUSVGQTDMR(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "20")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "21")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "22")]
		public bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "23")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "24")]
		public void PWEZWQWXDQN(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "25")]
		public void GZEGFODBACO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public QDSQGHTRAIZ()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FDCMNUSABYN : YKTNJQPEWBK, IEquatable<FDCMNUSABYN>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface YKTNJQPEWBK
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		FDCMNUSABYN ParentConnectable
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
		bool CanConnectTo(int slotIndex, FDCMNUSABYN otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, FDCMNUSABYN newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, FDCMNUSABYN newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, FDCMNUSABYN removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, FDCMNUSABYN parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(FDCMNUSABYN previousRootConnectable, FDCMNUSABYN newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WHFAQEXZBGY : CKGGJPDKIOP
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool XSGSHESZJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, JVVGTLYPYDF configData, JQNWKRJJETK rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void GZVUEGYMGMP(FDCMNUSABYN a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BAEWWTPIDYE(FDCMNUSABYN a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GYUSVGQTDMR(FDCMNUSABYN a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData OZEULYDYBAI(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool JFVVBGZHWOW(XGIWHMXMAZG a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void DJCOZTIVBYZ(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void PWEZWQWXDQN(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void GZEGFODBACO(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface CXXEOSQREMY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FDCMNUSABYN SOEQBKUCLMW(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FDCMNUSABYN TOBKWPJDCSJ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BLWGTOIYUJT(FDCMNUSABYN a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool SMBGJUSGLSX();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HAJMLANOVAQ(FDCMNUSABYN a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface XVDZVXXBHNX
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NHEZHBFUXHF(CLLWOCGEPVF a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YCWUVGBVZUW(CLLWOCGEPVF a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string UJDGITLEHBT(CLLWOCGEPVF a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid XSOKJGHIMRK(CLLWOCGEPVF a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int GRXNXQMJXGR(CLLWOCGEPVF a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EKYAJNIDLCQ(CLLWOCGEPVF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(FDCMNUSABYN childConnectable, int childConnectableSlot, FDCMNUSABYN parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(FDCMNUSABYN previousRootConnectable, FDCMNUSABYN newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface CLLWOCGEPVF : FDCMNUSABYN, YKTNJQPEWBK, IEquatable<FDCMNUSABYN>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface PJMXSXZJDTD : YKTNJQPEWBK
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		FDCMNUSABYN LPDHWBSBATS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<FDCMNUSABYN> UDLKKLANTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 TJSAEJFVSHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion IYXMSAHRVYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool JUVNCRVBGYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool UWKWDYWEDZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler RADTLCPOTOC;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler AQEHXBXGYAI;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler MZNNGPCBUPV;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler TZLWXMLKQHM;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void DDZNCGUGHRO();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void QFSFWVDXGFH();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void PJFVDPAQZYK();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void CKEDQPRWOZT();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ITBABRLNOZG(int a, FDCMNUSABYN b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void GFLAOKEDBFS();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void BHUPFAYRLFA(int a, FDCMNUSABYN b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void BGYLPYLJOXO(FDCMNUSABYN a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void QPFQUGDKTDZ();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void PRJSGRZFJNO(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void GXRNACTKRIB(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface RXRJFQKKODH
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 IHKHPTQRVRC
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
	public interface JVVGTLYPYDF
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool HGSYLAFQWOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		TRSXFQKGCQI YVBNPRHBULN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, JVVGTLYPYDF
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
		public bool HGSYLAFQWOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public TRSXFQKGCQI YVBNPRHBULN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9766070", Offset = "0x9764A70", VA = "0x189766070")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9766130", Offset = "0x9764B30", VA = "0x189766130")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FDCMNUSABYN connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x9766680", Offset = "0x9765080", VA = "0x189766680")]
		public ConnectableLink(FDCMNUSABYN connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x97665E0", Offset = "0x9764FE0", VA = "0x1897665E0")]
		public ConnectableLink(FDCMNUSABYN connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x97666E0", Offset = "0x97650E0", VA = "0x1897666E0")]
		public ConnectableLink(FDCMNUSABYN connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9766180", Offset = "0x9764B80", VA = "0x189766180", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9766230", Offset = "0x9764C30", VA = "0x189766230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : BXTUVAXERBS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform YMEIVUOXKZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TRSXFQKGCQI URHYIQWCMOE;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9090ED0", Offset = "0x908F8D0", VA = "0x189090ED0", Slot = "4")]
		public void Initialize(Transform transform, TRSXFQKGCQI linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x97681A0", Offset = "0x9766BA0", VA = "0x1897681A0", Slot = "5")]
		public TRSXFQKGCQI HRBQBMMOKWK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9768130", Offset = "0x9766B30", VA = "0x189768130", Slot = "6")]
		public void GZPLLOWLGPO(TRSXFQKGCQI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, ULIGVRTJBSQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HZDYEWMUZJZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public FDCMNUSABYN DSBVLANTRDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public FDCMNUSABYN FDXAEHKSCXU;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public HZDYEWMUZJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x97669A0", Offset = "0x97653A0", VA = "0x1897669A0")]
			internal bool TOZAWIRAVDW(URJEDQCFQTZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly ZFRUMZRKAVG VLSSVLCGWQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private KBRRHTRAYOT XDUFURHGPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private QLNPJRUAWUJ JBKGBZJJFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool XXJYXFAALWN;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log UCSGCVEPBFB;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public URJEDQCFQTZ XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x976AC30", Offset = "0x9769630", VA = "0x18976AC30")]
		public bool VAUNSFJJXIF([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x976A2F0", Offset = "0x9768CF0", VA = "0x18976A2F0")]
		private bool OFXZPOHDBQU([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x976BEF0", Offset = "0x976A8F0", VA = "0x18976BEF0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9769640", Offset = "0x9768040", VA = "0x189769640", Slot = "5")]
		public void Initialize(WHFAQEXZBGY manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9769B70", Offset = "0x9768570", VA = "0x189769B70", Slot = "17")]
		public void KPLYORJBODW(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9769BA0", Offset = "0x97685A0", VA = "0x189769BA0", Slot = "12")]
		public void MHFFGLLRSLJ(Func<FDCMNUSABYN, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9769BB0", Offset = "0x97685B0", VA = "0x189769BB0")]
		private void MHFFGLLRSLJ(ZFRUMZRKAVG a, Func<FDCMNUSABYN, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9769CE0", Offset = "0x97686E0", VA = "0x189769CE0", Slot = "11")]
		public void MTIOOOBNEUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x976A8B0", Offset = "0x97692B0", VA = "0x18976A8B0", Slot = "8")]
		public bool OIYPEPDSECA(FDCMNUSABYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9769D00", Offset = "0x9768700", VA = "0x189769D00")]
		private bool NGAJJLKBVDD(FDCMNUSABYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9769040", Offset = "0x9767A40", VA = "0x189769040")]
		private static bool BPCZUDNJOGX(FDCMNUSABYN a, ZFRUMZRKAVG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x97696F0", Offset = "0x97680F0", VA = "0x1897696F0")]
		private void KCOHINLOYEH(Transform a, ZFRUMZRKAVG b, ZFRUMZRKAVG[] c, FDCMNUSABYN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x976AF20", Offset = "0x9769920", VA = "0x18976AF20")]
		private ConnectableLink VNUQLCFJMCG(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x976AC40", Offset = "0x9769640", VA = "0x18976AC40")]
		private static bool UOIKTFJDGHP(ZFRUMZRKAVG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x97692D0", Offset = "0x9767CD0", VA = "0x1897692D0", Slot = "9")]
		public bool DFESIAYKUSE(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9769330", Offset = "0x9767D30", VA = "0x189769330")]
		private bool HMSBIRMRKMF(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x976BA00", Offset = "0x976A400", VA = "0x18976BA00")]
		private static void ZYWVSHRJEFW(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e, ZFRUMZRKAVG f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x976B140", Offset = "0x9769B40", VA = "0x18976B140")]
		private void YAJAYZVZQJP(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x976B2D0", Offset = "0x9769CD0", VA = "0x18976B2D0")]
		private void YDNALINJGDD(ZFRUMZRKAVG a, FDCMNUSABYN b, FDCMNUSABYN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x976B260", Offset = "0x9769C60", VA = "0x18976B260")]
		private void YDNALINJGDD(FDCMNUSABYN a, FDCMNUSABYN b, FDCMNUSABYN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9768ED0", Offset = "0x97678D0", VA = "0x189768ED0")]
		private void BAIRYGHPUHM(FDCMNUSABYN a, FDCMNUSABYN b, FDCMNUSABYN c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9768F40", Offset = "0x9767940", VA = "0x189768F40")]
		private void BAIRYGHPUHM(ZFRUMZRKAVG a, FDCMNUSABYN b, FDCMNUSABYN c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x976AE00", Offset = "0x9769800", VA = "0x18976AE00")]
		private void VKHFVFHVYOL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x976A8C0", Offset = "0x97692C0", VA = "0x18976A8C0")]
		private void PGTPBQEBTYV(URJEDQCFQTZ a, URJEDQCFQTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x976AAD0", Offset = "0x97694D0", VA = "0x18976AAD0", Slot = "18")]
		public FDCMNUSABYN QYWRKVPDOGQ(FDCMNUSABYN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9768B30", Offset = "0x9767530", VA = "0x189768B30", Slot = "13")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x976BBE0", Offset = "0x976A5E0", VA = "0x18976BBE0", Slot = "14")]
		public List<FDCMNUSABYN> ZZDJDECBJRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x976B070", Offset = "0x9769A70", VA = "0x18976B070")]
		protected URJEDQCFQTZ XRFFELRAYTK(URJEDQCFQTZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9769AD0", Offset = "0x97684D0", VA = "0x189769AD0")]
		protected ZFRUMZRKAVG[] KNOYRVQXPSN(ZFRUMZRKAVG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x97690F0", Offset = "0x9767AF0", VA = "0x1897690F0")]
		protected bool BWCAQAQURTO(FDCMNUSABYN a, [Out] ZFRUMZRKAVG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x976B340", Offset = "0x9769D40", VA = "0x18976B340", Slot = "15")]
		public bool ZSADQFLWFNO(FDCMNUSABYN a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x976AA90", Offset = "0x9769490", VA = "0x18976AA90")]
		protected ZFRUMZRKAVG PTENSVNWRLX(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x97695E0", Offset = "0x9767FE0", VA = "0x1897695E0", Slot = "10")]
		public bool HXODDCMVMPC(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x976B470", Offset = "0x9769E70", VA = "0x18976B470")]
		private bool ZSZMYDJOYZZ(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9769200", Offset = "0x9767C00", VA = "0x189769200")]
		private static bool BWEJAVNQGFT(ZFRUMZRKAVG a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x976AC30", Offset = "0x9769630", VA = "0x18976AC30", Slot = "7")]
		private bool TPHFMRALIEI([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : WHFAQEXZBGY, CKGGJPDKIOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly TFZCSWYZDKY container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly QLNPJRUAWUJ JBKGBZJJFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly WWOXATHPVZM VNDGMOOSIIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly QQXJOBTBOPO FKYKSEKOXXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly ULIGVRTJBSQ XINKKBUKNUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal TLAJPTMDOJT YTLVACUUSYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal HTCVNNSCSXQ ZCECRWPMVYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal KBRRHTRAYOT YFTNPDAZXEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool XXJYXFAALWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool AMQEMOAOWAO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ZMINPHKSNXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xD23540", Offset = "0xD21F40", VA = "0x180D23540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD231F0", Offset = "0xD21BF0", VA = "0x180D231F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1347970", Offset = "0x1346370", VA = "0x181347970", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2861690", Offset = "0x2860090", VA = "0x182861690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool XSGSHESZJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x976DAE0", Offset = "0x976C4E0", VA = "0x18976DAE0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x976D3D0", Offset = "0x976BDD0", VA = "0x18976D3D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x976C390", Offset = "0x976AD90", VA = "0x18976C390", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x976DA00", Offset = "0x976C400", VA = "0x18976DA00", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x976C640", Offset = "0x976B040", VA = "0x18976C640", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x976D560", Offset = "0x976BF60", VA = "0x18976D560", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x976DD20", Offset = "0x976C720", VA = "0x18976DD20")]
		public LegacyConnectableManager(TFZCSWYZDKY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x976CBE0", Offset = "0x976B5E0", VA = "0x18976CBE0", Slot = "12")]
		public void Initialize(GameObject gameObject, JVVGTLYPYDF configData, JQNWKRJJETK rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x976DB40", Offset = "0x976C540", VA = "0x18976DB40", Slot = "26")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x976DA60", Offset = "0x976C460", VA = "0x18976DA60", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x976CBC0", Offset = "0x976B5C0", VA = "0x18976CBC0", Slot = "14")]
		public void GZVUEGYMGMP(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x976C330", Offset = "0x976AD30", VA = "0x18976C330", Slot = "15")]
		public void BAEWWTPIDYE(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x976D1A0", Offset = "0x976BBA0", VA = "0x18976D1A0", Slot = "22")]
		public bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x976DC10", Offset = "0x976C610", VA = "0x18976DC10")]
		internal bool ZSZMYDJOYZZ([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x976C870", Offset = "0x976B270", VA = "0x18976C870")]
		internal bool DWPFQNKAEHP([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x976D1F0", Offset = "0x976BBF0", VA = "0x18976D1F0")]
		internal void KGGYXYMWCMJ(FDCMNUSABYN a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x976C330", Offset = "0x976AD30", VA = "0x18976C330")]
		internal bool CYCPAGWSEJT(FDCMNUSABYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x976D430", Offset = "0x976BE30", VA = "0x18976D430")]
		internal bool MPCOKEACXRF(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x976C240", Offset = "0x976AC40", VA = "0x18976C240", Slot = "16")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x976D5C0", Offset = "0x976BFC0", VA = "0x18976D5C0", Slot = "17")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x976C730", Offset = "0x976B130", VA = "0x18976C730", Slot = "18")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x976C9C0", Offset = "0x976B3C0", VA = "0x18976C9C0", Slot = "19")]
		public void GYUSVGQTDMR(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x976C3F0", Offset = "0x976ADF0", VA = "0x18976C3F0")]
		public void CSJKLFBIMDW([Optional] PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x976C6A0", Offset = "0x976B0A0", VA = "0x18976C6A0", Slot = "23")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x976D7D0", Offset = "0x976C1D0", VA = "0x18976D7D0", Slot = "20")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x976C0A0", Offset = "0x976AAA0", VA = "0x18976C0A0", Slot = "21")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x976CB80", Offset = "0x976B580", VA = "0x18976CB80", Slot = "25")]
		public void GZEGFODBACO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x976D950", Offset = "0x976C350", VA = "0x18976D950", Slot = "24")]
		public void PWEZWQWXDQN(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class QLNPJRUAWUJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly PCTEMQPSGQS<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly PCTEMQPSGQS<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly PCYLJXJPQCB<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9775F90", Offset = "0x9774990", VA = "0x189775F90")]
		public QLNPJRUAWUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9775ED0", Offset = "0x97748D0", VA = "0x189775ED0")]
		public void JZCRFOHBGLO(FDCMNUSABYN a, FDCMNUSABYN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9775F30", Offset = "0x9774930", VA = "0x189775F30")]
		public void ZZHVQRWBOYC(FDCMNUSABYN a, FDCMNUSABYN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9775E50", Offset = "0x9774850", VA = "0x189775E50")]
		public void AQOORZOIKRQ(FDCMNUSABYN a, FDCMNUSABYN b, FDCMNUSABYN c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WWOXATHPVZM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager KLZBIVRBXUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private HTCVNNSCSXQ ZCECRWPMVYQ;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public WWOXATHPVZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x97799F0", Offset = "0x97783F0", VA = "0x1897799F0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x97799E0", Offset = "0x97783E0", VA = "0x1897799E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9779D90", Offset = "0x9778790", VA = "0x189779D90")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9779D20", Offset = "0x9778720", VA = "0x189779D20")]
		private void OnMasterClientSwitched(PPTCRKDFMWF newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9779C20", Offset = "0x9778620", VA = "0x189779C20")]
		public void LUJXLZWMVPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9779B20", Offset = "0x9778520", VA = "0x189779B20")]
		public void JWXWIOMEFAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class LRMZITYMXHW
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public TFZCSWYZDKY container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9779980", Offset = "0x9778380", VA = "0x189779980")]
			internal LegacyConnectableManager VWBTPSTHWCJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9767F40", Offset = "0x9766940", VA = "0x189767F40")]
		public static void TNIPUGRPWFD(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9767EC0", Offset = "0x97668C0", VA = "0x189767EC0")]
		public static void QGEULEGTWDU(TFZCSWYZDKY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, KBRRHTRAYOT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, TRSXFQKGCQI> ZPOGBVLPBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation ABIPYLRJMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private BXTUVAXERBS WVNJSILVMVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ULIGVRTJBSQ XINKKBUKNUS;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker MGTKMFJPUQQ;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x976EE70", Offset = "0x976D870", VA = "0x18976EE70")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x976E880", Offset = "0x976D280", VA = "0x18976E880", Slot = "7")]
		public void Initialize(ULIGVRTJBSQ graph, BXTUVAXERBS creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x976E0B0", Offset = "0x976CAB0", VA = "0x18976E0B0", Slot = "5")]
		public void EMMMPIYMHVT(URJEDQCFQTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x976EA80", Offset = "0x976D480", VA = "0x18976EA80", Slot = "9")]
		public void LVCTZTHAZWU(URJEDQCFQTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x976E8C0", Offset = "0x976D2C0", VA = "0x18976E8C0", Slot = "8")]
		public void KKDHCXZJRHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x976E480", Offset = "0x976CE80", VA = "0x18976E480", Slot = "10")]
		public void FKCOXZWOEDB(URJEDQCFQTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x976ECC0", Offset = "0x976D6C0", VA = "0x18976ECC0", Slot = "11")]
		public void WFEGHQXKUTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x976E6D0", Offset = "0x976D0D0", VA = "0x18976E6D0")]
		private bool HSIFPRCAFYW(URJEDQCFQTZ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class QQXJOBTBOPO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly ZFRUMZRKAVG currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly XGIWHMXMAZG parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly XGIWHMXMAZG rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool OODEDYTKARR
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x97788B0", Offset = "0x97772B0", VA = "0x1897788B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9778FB0", Offset = "0x97779B0", VA = "0x189778FB0")]
			public SerializeNodeInSubgraph(ZFRUMZRKAVG currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] XGIWHMXMAZG parentNodeData, [Optional] XGIWHMXMAZG rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9778710", Offset = "0x9777110", VA = "0x189778710")]
			public XGIWHMXMAZG BGVSXQNQAUM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x97789C0", Offset = "0x97773C0", VA = "0x1897789C0")]
			private XGIWHMXMAZG NTGVPBFMFSI([Out] XGIWHMXMAZG a, [Out] XGIWHMXMAZG b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9778DB0", Offset = "0x97777B0", VA = "0x189778DB0")]
			private XGIWHMXMAZG WIHLQWBSERG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9778C40", Offset = "0x9777640", VA = "0x189778C40")]
			private void UPNVFXQZECG(XGIWHMXMAZG a, XGIWHMXMAZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9778A80", Offset = "0x9777480", VA = "0x189778A80")]
			private void PCKRWRYYJSL(XGIWHMXMAZG a, XGIWHMXMAZG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager KLZBIVRBXUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ULIGVRTJBSQ XINKKBUKNUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private KBRRHTRAYOT XDUFURHGPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private HTCVNNSCSXQ ZCECRWPMVYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool SNZOPKAPJPQ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool HRKFJHIJSVB
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9776A80", Offset = "0x9775480", VA = "0x189776A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool ZMINPHKSNXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x97773E0", Offset = "0x9775DE0", VA = "0x1897773E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x97766D0", Offset = "0x97750D0", VA = "0x1897766D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9776DA0", Offset = "0x97757A0", VA = "0x189776DA0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9777400", Offset = "0x9775E00", VA = "0x189777400")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9776090", Offset = "0x9774A90", VA = "0x189776090")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x97763C0", Offset = "0x9774DC0", VA = "0x1897763C0")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x97775A0", Offset = "0x9775FA0", VA = "0x1897775A0")]
		public void PWEZWQWXDQN(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9777570", Offset = "0x9775F70", VA = "0x189777570")]
		public void OZUSCMYORXR(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x97782D0", Offset = "0x9776CD0", VA = "0x1897782D0")]
		private void YHBDOWOWCYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x97766F0", Offset = "0x97750F0", VA = "0x1897766F0")]
		private XGIWHMXMAZG EDHKPLSUPGS(ZFRUMZRKAVG a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9776AF0", Offset = "0x97754F0", VA = "0x189776AF0")]
		private static void IAMNCMRQEXS(ZFRUMZRKAVG a, bool b, XGIWHMXMAZG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9776860", Offset = "0x9775260", VA = "0x189776860")]
		private void EKALYWUVZRB(ZFRUMZRKAVG a, bool b, XGIWHMXMAZG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x97767D0", Offset = "0x97751D0", VA = "0x1897767D0")]
		private XGIWHMXMAZG EGRLTYYAVOS(ZFRUMZRKAVG a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9776450", Offset = "0x9774E50", VA = "0x189776450")]
		private bool DNMRDQYFBCM(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x97777B0", Offset = "0x97761B0", VA = "0x1897777B0")]
		private bool TVLTVJGSWVX(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9776AD0", Offset = "0x97754D0", VA = "0x189776AD0")]
		private bool HUDXOSWSJOL(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x97781B0", Offset = "0x9776BB0", VA = "0x1897781B0")]
		private static bool YHAZTYPQKQC(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9776E10", Offset = "0x9775810", VA = "0x189776E10")]
		public static bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x97770A0", Offset = "0x9775AA0", VA = "0x1897770A0")]
		private FDCMNUSABYN NEXEUIUBAIA(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9777640", Offset = "0x9776040", VA = "0x189777640")]
		private FDCMNUSABYN SOEQBKUCLMW(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9776230", Offset = "0x9774C30", VA = "0x189776230")]
		private FDCMNUSABYN BFUDKZWENPD(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x976F210", Offset = "0x976DC10", VA = "0x18976F210")]
		private static Guid AIEZLMUBTVB(XGIWHMXMAZG a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x97780C0", Offset = "0x9776AC0", VA = "0x1897780C0")]
		private string VGYCTKPBJXE(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x97784B0", Offset = "0x9776EB0", VA = "0x1897784B0")]
		private bool ZPRGGJKZCNL(ZFRUMZRKAVG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9777E10", Offset = "0x9776810", VA = "0x189777E10")]
		private static void VFDYXJCLULT(ZFRUMZRKAVG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public QQXJOBTBOPO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public FDCMNUSABYN child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FDCMNUSABYN parent;

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
		public ConnectableLink GQYJXTZAYVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9766770", Offset = "0x9765170", VA = "0x189766770")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink UBRDLXSMLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9766810", Offset = "0x9765210", VA = "0x189766810")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9766840", Offset = "0x9765240", VA = "0x189766840")]
		public ConnectionOperationData(FDCMNUSABYN child, FDCMNUSABYN parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface ULIGVRTJBSQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		URJEDQCFQTZ XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(WHFAQEXZBGY manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VAUNSFJJXIF([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool OIYPEPDSECA(FDCMNUSABYN a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DFESIAYKUSE(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HXODDCMVMPC(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MTIOOOBNEUH();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MHFFGLLRSLJ(Func<FDCMNUSABYN, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<FDCMNUSABYN> ZZDJDECBJRR();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ZSADQFLWFNO(FDCMNUSABYN a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void KPLYORJBODW(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(URJEDQCFQTZ node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface URJEDQCFQTZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		FDCMNUSABYN RPGPSPXFJNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		URJEDQCFQTZ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink CATTJQRMIIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool WSKYCLRQAIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface TRSXFQKGCQI : OCNJUTZUOUY.IADLUGTXAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ORLMZSMEYLO(FDCMNUSABYN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DNACDUCMHLC(FDCMNUSABYN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MJXUZYFXUOZ(FDCMNUSABYN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TMCUGYEUIHR(FDCMNUSABYN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TRSXFQKGCQI NSCZJZVGTIC(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface BXTUVAXERBS
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, TRSXFQKGCQI linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TRSXFQKGCQI HRBQBMMOKWK();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GZPLLOWLGPO(TRSXFQKGCQI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface TLAJPTMDOJT : CXXEOSQREMY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JNWMMERLOEP();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IQQBBVPVYTU(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface KBRRHTRAYOT
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EMMMPIYMHVT(URJEDQCFQTZ a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(ULIGVRTJBSQ graph, BXTUVAXERBS linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KKDHCXZJRHY();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LVCTZTHAZWU(URJEDQCFQTZ a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FKCOXZWOEDB(URJEDQCFQTZ a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WFEGHQXKUTN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class ZFRUMZRKAVG : URJEDQCFQTZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class NIYGFYNSVMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink EOQUZKJHLPX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public ZFRUMZRKAVG FJTNUHSCIXY;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NIYGFYNSVMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x976F0D0", Offset = "0x976DAD0", VA = "0x18976F0D0")]
			internal bool TBBZLYHVFQF(URJEDQCFQTZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink NTADEFXSPAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<ZFRUMZRKAVG> HHXLXBPRSRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ZFRUMZRKAVG BQJTOXSLIKH;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink CATTJQRMIIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x51CAF60", Offset = "0x51C9960", VA = "0x1851CAF60", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x9779F90", Offset = "0x9778990", VA = "0x189779F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ZFRUMZRKAVG SYLHKQLEBTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x977A400", Offset = "0x9778E00", VA = "0x18977A400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public URJEDQCFQTZ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public FDCMNUSABYN RPGPSPXFJNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WSKYCLRQAIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x977AA10", Offset = "0x9779410", VA = "0x18977AA10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool PBMRHYDWALA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x977A9C0", Offset = "0x97793C0", VA = "0x18977A9C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected ZFRUMZRKAVG JBSQCTQPIEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x977A9A0", Offset = "0x97793A0", VA = "0x18977A9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x977AA20", Offset = "0x9779420", VA = "0x18977AA20")]
		public ZFRUMZRKAVG(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x977A4E0", Offset = "0x9778EE0", VA = "0x18977A4E0")]
		public ZFRUMZRKAVG NKQFAMSGLEZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x977A110", Offset = "0x9778B10", VA = "0x18977A110")]
		public ZFRUMZRKAVG FRNFEAUNBZT(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x977A710", Offset = "0x9779110", VA = "0x18977A710")]
		public ZFRUMZRKAVG Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9779FC0", Offset = "0x97789C0", VA = "0x189779FC0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x977A8F0", Offset = "0x97792F0", VA = "0x18977A8F0")]
		public ZFRUMZRKAVG Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x977A290", Offset = "0x9778C90", VA = "0x18977A290")]
		private static void KPLYORJBODW(ZFRUMZRKAVG a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x977A3F0", Offset = "0x9778DF0", VA = "0x18977A3F0", Slot = "9")]
		public void KPLYORJBODW(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x977A620", Offset = "0x9779020", VA = "0x18977A620")]
		public static ZFRUMZRKAVG PTENSVNWRLX(ZFRUMZRKAVG a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface HTCVNNSCSXQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool HRKFJHIJSVB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> KLJCMQTGKTR;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<PPTCRKDFMWF> SZGGPUJJABF;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ORLMZSMEYLO(LegacyConnectableManager a, JQNWKRJJETK b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void VTDSXCWPILC(ConnectableGraphData a, [Optional] PPTCRKDFMWF b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class DMOSPTFTPUA
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9766950", Offset = "0x9765350", VA = "0x189766950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x9766910", Offset = "0x9765310", VA = "0x189766910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x97668B0", Offset = "0x97652B0", VA = "0x1897668B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class LAKQCRDOBDV : HTCVNNSCSXQ, IDisposable, KLKDAWMSZIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager KLZBIVRBXUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private JQNWKRJJETK QKIHEHIDOLG;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HRKFJHIJSVB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x97670F0", Offset = "0x9765AF0", VA = "0x1897670F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x97670B0", Offset = "0x9765AB0", VA = "0x1897670B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView NSLMZWAUMSU
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9766CC0", Offset = "0x97656C0", VA = "0x189766CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> KLJCMQTGKTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9766F20", Offset = "0x9765920", VA = "0x189766F20", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x9767010", Offset = "0x9765A10", VA = "0x189767010", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<PPTCRKDFMWF> SZGGPUJJABF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9767A50", Offset = "0x9766450", VA = "0x189767A50", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x9766D60", Offset = "0x9765760", VA = "0x189766D60", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9767270", Offset = "0x9765C70", VA = "0x189767270", Slot = "10")]
		public void ORLMZSMEYLO(LegacyConnectableManager a, JQNWKRJJETK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9766FC0", Offset = "0x97659C0", VA = "0x189766FC0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9767150", Offset = "0x9765B50", VA = "0x189767150", Slot = "11")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9766E00", Offset = "0x9765800", VA = "0x189766E00", Slot = "12")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9767AF0", Offset = "0x97664F0", VA = "0x189767AF0", Slot = "13")]
		public void VTDSXCWPILC(ConnectableGraphData a, [Optional] PPTCRKDFMWF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9767530", Offset = "0x9765F30", VA = "0x189767530")]
		[RPCMethod]
		private void RpcMasterReparentNodes(FDCMNUSABYN objectToReparent, int objectToReparentSlotIndex, FDCMNUSABYN newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9767340", Offset = "0x9765D40", VA = "0x189767340")]
		[RPCMethod]
		private void RpcMasterModifyNode(FDCMNUSABYN connectableToModify, FDCMNUSABYN expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9767920", Offset = "0x9766320", VA = "0x189767920")]
		[RPCMethod]
		private void RpcReparentNodes(FDCMNUSABYN objectToReparent, int objectToReparentSlotIndex, FDCMNUSABYN newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9767830", Offset = "0x9766230", VA = "0x189767830")]
		[RPCMethod]
		private void RpcModifyNode(FDCMNUSABYN connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9767300", Offset = "0x9765D00", VA = "0x189767300")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LAKQCRDOBDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, TRSXFQKGCQI, OCNJUTZUOUY.IADLUGTXAFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9768520", Offset = "0x9766F20", VA = "0x189768520", Slot = "4")]
		private void UEMRNKSYQPN(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x97686A0", Offset = "0x97670A0", VA = "0x1897686A0", Slot = "5")]
		private void XPQYTHGKYUX(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9768900", Offset = "0x9767300", VA = "0x189768900", Slot = "6")]
		private void YWPPBVSXZOU(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9768260", Offset = "0x9766C60", VA = "0x189768260", Slot = "7")]
		private void AQYKBLHDBPG(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x97684B0", Offset = "0x9766EB0", VA = "0x1897684B0", Slot = "8")]
		private TRSXFQKGCQI SDEERIDVIHN(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9768450", Offset = "0x9766E50", VA = "0x189768450", Slot = "9")]
		private void FJNALQWWGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class TNSMOVGWIRA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F27A70", Offset = "0x3F26470", VA = "0x183F27A70")]
		public static SPVVFHIMJMN<a> OYBAGBZGPAY<a>(this TFZCSWYZDKY a)
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
