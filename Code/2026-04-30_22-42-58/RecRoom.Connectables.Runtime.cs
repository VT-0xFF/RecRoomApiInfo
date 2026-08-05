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
		[Cpp2IlInjected.Address(RVA = "0x96A9710", Offset = "0x96A8B10", VA = "0x1896A9710", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x223B2D0", Offset = "0x223A6D0", VA = "0x18223B2D0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96B5420", Offset = "0x96B4820", VA = "0x1896B5420")]
		private void BAZLOGTATAR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x96B52C0", Offset = "0x96B46C0", VA = "0x1896B52C0")]
		private void BAUEQZZDJPI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96B5580", Offset = "0x96B4980", VA = "0x1896B5580", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96B5890", Offset = "0x96B4C90", VA = "0x1896B5890")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LINMOVFAHAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x96A25C0", Offset = "0x96A19C0", VA = "0x1896A25C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LISTMBYXQLX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x96A2630", Offset = "0x96A1A30", VA = "0x1896A2630")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public VJOIZZFLFVH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x96B3E70", Offset = "0x96B3270", VA = "0x1896B3E70", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x96B3B10", Offset = "0x96B2F10", VA = "0x1896B3B10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x96B3A20", Offset = "0x96B2E20", VA = "0x1896B3A20")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x96B3A40", Offset = "0x96B2E40", VA = "0x1896B3A40")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x96B3F50", Offset = "0x96B3350", VA = "0x1896B3F50", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x96B3A60", Offset = "0x96B2E60", VA = "0x1896B3A60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FDCMNUSABYN> MKQPFAQUTCI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x96B3A60", Offset = "0x96B2E60", VA = "0x1896B3A60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4E30", Offset = "0xCF4230", VA = "0x180CF4E30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C80", Offset = "0xCF4080", VA = "0x180CF4C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool XSGSHESZJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x96AD9A0", Offset = "0x96ACDA0", VA = "0x1896AD9A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x96AB8D0", Offset = "0x96AACD0", VA = "0x1896AB8D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x96A9F20", Offset = "0x96A9320", VA = "0x1896A9F20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x96AC690", Offset = "0x96ABA90", VA = "0x1896AC690", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x96AA060", Offset = "0x96A9460", VA = "0x1896AA060", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x96ABEA0", Offset = "0x96AB2A0", VA = "0x1896ABEA0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x96AE3C0", Offset = "0x96AD7C0", VA = "0x1896AE3C0")]
		public OMConnectableManager(TFZCSWYZDKY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x96AB560", Offset = "0x96AA960", VA = "0x1896AB560", Slot = "12")]
		public void Initialize(GameObject gameObject, JVVGTLYPYDF configData, JQNWKRJJETK sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x96ADD70", Offset = "0x96AD170", VA = "0x1896ADD70", Slot = "26")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x96AB880", Offset = "0x96AAC80", VA = "0x1896AB880", Slot = "22")]
		public bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x96AC2C0", Offset = "0x96AB6C0", VA = "0x1896AC2C0")]
		private void REKRDWJUIEL(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x96ADF40", Offset = "0x96AD340", VA = "0x1896ADF40")]
		private void ZNQTQERCDAR(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x96AB300", Offset = "0x96AA700", VA = "0x1896AB300")]
		private void IYUGFSBUHPV(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x96AA5B0", Offset = "0x96A99B0", VA = "0x1896AA5B0")]
		private void GXYJOEPEVUA(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x96AAF60", Offset = "0x96AA360", VA = "0x1896AAF60", Slot = "14")]
		public void GZVUEGYMGMP(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "15")]
		public void BAEWWTPIDYE(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x96AC090", Offset = "0x96AB490", VA = "0x1896AC090", Slot = "17")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x96ABF50", Offset = "0x96AB350", VA = "0x1896ABF50")]
		public void OJQDSXEAQDZ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96AB270", Offset = "0x96AA670", VA = "0x1896AB270")]
		public void HEHVMXGFEAJ(FDCMNUSABYN a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96AA180", Offset = "0x96A9580", VA = "0x1896AA180", Slot = "18")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96AB7D0", Offset = "0x96AABD0", VA = "0x1896AB7D0")]
		private float JDRTGNASOST(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96AA2E0", Offset = "0x96A96E0", VA = "0x1896AA2E0")]
		public void DSBRXLZNZVL(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x96AA9C0", Offset = "0x96A9DC0", VA = "0x1896AA9C0", Slot = "19")]
		public void GYUSVGQTDMR(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x96A9A20", Offset = "0x96A8E20", VA = "0x1896A9A20", Slot = "16")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "20")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "21")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96AA110", Offset = "0x96A9510", VA = "0x1896AA110", Slot = "23")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x96AC250", Offset = "0x96AB650", VA = "0x1896AC250", Slot = "24")]
		public void PWEZWQWXDQN(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x96AAF40", Offset = "0x96AA340", VA = "0x1896AAF40", Slot = "25")]
		public void GZEGFODBACO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x96AAB30", Offset = "0x96A9F30", VA = "0x1896AAB30")]
		private void GYVDTHLUYVH(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96AC740", Offset = "0x96ABB40", VA = "0x1896AC740")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96A9C30", Offset = "0x96A9030", VA = "0x1896A9C30")]
		private void AVMRQIHKPYW(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96A9FD0", Offset = "0x96A93D0", VA = "0x1896A9FD0")]
		[IteratorStateMachine(typeof(VJOIZZFLFVH))]
		public IEnumerable<FDCMNUSABYN> CHWEROEDEDN(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96ABD60", Offset = "0x96AB160", VA = "0x1896ABD60")]
		internal FDCMNUSABYN NEXEUIUBAIA(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96ADBE0", Offset = "0x96ACFE0", VA = "0x1896ADBE0")]
		internal ObjectLocalId YEGVSRNGPIA(FDCMNUSABYN a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96AD1A0", Offset = "0x96AC5A0", VA = "0x1896AD1A0")]
		private bool TVLTVJGSWVX(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96AB980", Offset = "0x96AAD80", VA = "0x1896AB980")]
		private bool LUIOCENIZFT(XGIWHMXMAZG a, [Out] FDCMNUSABYN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96AB9E0", Offset = "0x96AADE0", VA = "0x1896AB9E0")]
		private FDCMNUSABYN NEXEUIUBAIA(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x96AD010", Offset = "0x96AC410", VA = "0x1896AD010")]
		private FDCMNUSABYN TOBKWPJDCSJ(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x96AC4D0", Offset = "0x96AB8D0", VA = "0x1896AC4D0")]
		private FDCMNUSABYN SOEQBKUCLMW(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96A99E0", Offset = "0x96A8DE0", VA = "0x1896A99E0")]
		private static Guid AIEZLMUBTVB(XGIWHMXMAZG a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x96AD720", Offset = "0x96ACB20", VA = "0x1896AD720")]
		private string VGYCTKPBJXE(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x96ADA50", Offset = "0x96ACE50", VA = "0x1896ADA50")]
		private void YAJAYZVZQJP(FDCMNUSABYN a, FDCMNUSABYN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x96AD810", Offset = "0x96ACC10", VA = "0x1896AD810")]
		private void VKHFVFHVYOL(FDCMNUSABYN a, FDCMNUSABYN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x96AC1F0", Offset = "0x96AB5F0", VA = "0x1896AC1F0")]
		private void PGTPBQEBTYV(FDCMNUSABYN a, FDCMNUSABYN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x96AA420", Offset = "0x96A9820", VA = "0x1896AA420")]
		private void EGGAKIUEUIQ(FDCMNUSABYN a, FDCMNUSABYN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x96AE160", Offset = "0x96AD560", VA = "0x1896AE160")]
		private void ZWBRPSTZJMR(ObjectLocalId a, FDCMNUSABYN b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x96A9CA0", Offset = "0x96A90A0", VA = "0x1896A9CA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x96B40E0", Offset = "0x96B34E0", VA = "0x1896B40E0")]
			internal OMConnectableManager VWBTPSTHWCJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x96B4620", Offset = "0x96B3A20", VA = "0x1896B4620")]
		public static void TNIPUGRPWFD(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x96B45D0", Offset = "0x96B39D0", VA = "0x1896B45D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30", Slot = "38")]
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
			[Cpp2IlInjected.Address(RVA = "0x96AFFD0", Offset = "0x96AF3D0", VA = "0x1896AFFD0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FDCMNUSABYN LPDHWBSBATS
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x96AF480", Offset = "0x96AE880", VA = "0x1896AF480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 TJSAEJFVSHS
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x96AFC60", Offset = "0x96AF060", VA = "0x1896AFC60", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion IYXMSAHRVYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x96AE980", Offset = "0x96ADD80", VA = "0x1896AE980", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JUVNCRVBGYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x96AE9E0", Offset = "0x96ADDE0", VA = "0x1896AE9E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<FDCMNUSABYN> UDLKKLANTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x96AE810", Offset = "0x96ADC10", VA = "0x1896AE810", Slot = "13")]
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
			[Cpp2IlInjected.Address(RVA = "0xD995F0", Offset = "0xD989F0", VA = "0x180D995F0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE8B450", Offset = "0xE8A850", VA = "0x180E8B450", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x96B01E0", Offset = "0x96AF5E0", VA = "0x1896B01E0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x96AFEE0", Offset = "0x96AF2E0", VA = "0x1896AFEE0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x96AFF00", Offset = "0x96AF300", VA = "0x1896AFF00", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x96B0030", Offset = "0x96AF430", VA = "0x1896B0030", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x96B0110", Offset = "0x96AF510", VA = "0x1896B0110", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool NHEZHBFUXHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x96AE930", Offset = "0x96ADD30", VA = "0x1896AE930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler RADTLCPOTOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x96AE7C0", Offset = "0x96ADBC0", VA = "0x1896AE7C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x96AEBC0", Offset = "0x96ADFC0", VA = "0x1896AEBC0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler AQEHXBXGYAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x96AF220", Offset = "0x96AE620", VA = "0x1896AF220", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x96AF540", Offset = "0x96AE940", VA = "0x1896AF540", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler MZNNGPCBUPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x96AEA50", Offset = "0x96ADE50", VA = "0x1896AEA50", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x96AEAA0", Offset = "0x96ADEA0", VA = "0x1896AEAA0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler TZLWXMLKQHM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x96AF630", Offset = "0x96AEA30", VA = "0x1896AF630", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x96AFCC0", Offset = "0x96AF0C0", VA = "0x1896AFCC0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x96AFDE0", Offset = "0x96AF1E0", VA = "0x1896AFDE0")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, CLLWOCGEPVF connectableTool, RXRJFQKKODH[] connectionPoints, XVDZVXXBHNX callbacks, WHFAQEXZBGY connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x96AE430", Offset = "0x96AD830", VA = "0x1896AE430", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "21")]
		public void DDZNCGUGHRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x96AF8C0", Offset = "0x96AECC0", VA = "0x1896AF8C0", Slot = "22")]
		public void QFSFWVDXGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x96AFC10", Offset = "0x96AF010", VA = "0x1896AFC10", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x96AF270", Offset = "0x96AE670", VA = "0x1896AF270", Slot = "25")]
		public void ITBABRLNOZG(int a, FDCMNUSABYN b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x96AEAF0", Offset = "0x96ADEF0", VA = "0x1896AEAF0", Slot = "26")]
		public void GFLAOKEDBFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x96AE4E0", Offset = "0x96AD8E0", VA = "0x1896AE4E0", Slot = "27")]
		public void BHUPFAYRLFA(int a, FDCMNUSABYN b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x96AE460", Offset = "0x96AD860", VA = "0x1896AE460", Slot = "28")]
		public void BGYLPYLJOXO(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x96AEC10", Offset = "0x96AE010", VA = "0x1896AEC10", Slot = "31")]
		public void GXRNACTKRIB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x96AF8E0", Offset = "0x96AECE0", VA = "0x1896AF8E0", Slot = "29")]
		public void QPFQUGDKTDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x96AF6D0", Offset = "0x96AEAD0", VA = "0x1896AF6D0", Slot = "30")]
		public void PRJSGRZFJNO(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x96AF150", Offset = "0x96AE550", VA = "0x1896AF150", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x96AF020", Offset = "0x96AE420", VA = "0x1896AF020", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDD0", Offset = "0xD5B1D0", VA = "0x180D5BDD0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x96AE890", Offset = "0x96ADC90", VA = "0x1896AE890", Slot = "43")]
		public bool CanConnectTo(int slotIndex, FDCMNUSABYN otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "44")]
		public void ParentChanged(int slotIndex, FDCMNUSABYN newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "45")]
		public void ChildAdded(int slotIndex, FDCMNUSABYN newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "46")]
		public void ChildRemoved(int slotIndex, FDCMNUSABYN removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "47")]
		public void ConnectionModified(int slotIndex, FDCMNUSABYN parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x96AFBF0", Offset = "0x96AEFF0", VA = "0x1896AFBF0", Slot = "48")]
		public void RootChanged(FDCMNUSABYN previousRootConnectable, FDCMNUSABYN newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x96AF5E0", Offset = "0x96AE9E0", VA = "0x1896AF5E0", Slot = "23")]
		public void PJFVDPAQZYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x96AE840", Offset = "0x96ADC40", VA = "0x1896AE840", Slot = "24")]
		public void CKEDQPRWOZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x96AF590", Offset = "0x96AE990", VA = "0x1896AF590")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x96B3FE0", Offset = "0x96B33E0", VA = "0x1896B3FE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x96B3F90", Offset = "0x96B3390", VA = "0x1896B3F90", Slot = "5")]
		private void LJERCYKGCZL(GEZRGCKOUXX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF5C5F0", Offset = "0xF5B9F0", VA = "0x180F5C5F0", Slot = "6")]
		private void XGDIBOIJOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool XSGSHESZJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x96B0570", Offset = "0x96AF970", VA = "0x1896B0570", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x96B0360", Offset = "0x96AF760", VA = "0x1896B0360", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x96B0200", Offset = "0x96AF600", VA = "0x1896B0200", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x96B04C0", Offset = "0x96AF8C0", VA = "0x1896B04C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x96B02B0", Offset = "0x96AF6B0", VA = "0x1896B02B0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x96B0410", Offset = "0x96AF810", VA = "0x1896B0410", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "26")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "12")]
		public void Initialize(GameObject gameObject, JVVGTLYPYDF configData, JQNWKRJJETK rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "14")]
		public void GZVUEGYMGMP(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "15")]
		public void BAEWWTPIDYE(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "16")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "17")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "18")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "19")]
		public void GYUSVGQTDMR(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "20")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "21")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "22")]
		public bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "23")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "24")]
		public void PWEZWQWXDQN(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "25")]
		public void GZEGFODBACO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEABB30", Offset = "0xEAAF30", VA = "0x180EABB30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public TRSXFQKGCQI YVBNPRHBULN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x96A0B30", Offset = "0x969FF30", VA = "0x1896A0B30")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x96A0BF0", Offset = "0x969FFF0", VA = "0x1896A0BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x96A1140", Offset = "0x96A0540", VA = "0x1896A1140")]
		public ConnectableLink(FDCMNUSABYN connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x96A10A0", Offset = "0x96A04A0", VA = "0x1896A10A0")]
		public ConnectableLink(FDCMNUSABYN connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x96A11A0", Offset = "0x96A05A0", VA = "0x1896A11A0")]
		public ConnectableLink(FDCMNUSABYN connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x96A0C40", Offset = "0x96A0040", VA = "0x1896A0C40", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x96A0CF0", Offset = "0x96A00F0", VA = "0x1896A0CF0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8FD76C0", Offset = "0x8FD6AC0", VA = "0x188FD76C0", Slot = "4")]
		public void Initialize(Transform transform, TRSXFQKGCQI linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x96A2B60", Offset = "0x96A1F60", VA = "0x1896A2B60", Slot = "5")]
		public TRSXFQKGCQI HRBQBMMOKWK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x96A2AF0", Offset = "0x96A1EF0", VA = "0x1896A2AF0", Slot = "6")]
		public void GZPLLOWLGPO(TRSXFQKGCQI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public HZDYEWMUZJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x96A1440", Offset = "0x96A0840", VA = "0x1896A1440")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x96A5570", Offset = "0x96A4970", VA = "0x1896A5570")]
		public bool VAUNSFJJXIF([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x96A4CA0", Offset = "0x96A40A0", VA = "0x1896A4CA0")]
		private bool OFXZPOHDBQU([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x96A67E0", Offset = "0x96A5BE0", VA = "0x1896A67E0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x96A3ED0", Offset = "0x96A32D0", VA = "0x1896A3ED0", Slot = "5")]
		public void Initialize(WHFAQEXZBGY manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x96A4410", Offset = "0x96A3810", VA = "0x1896A4410", Slot = "17")]
		public void KPLYORJBODW(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x96A4440", Offset = "0x96A3840", VA = "0x1896A4440", Slot = "12")]
		public void MHFFGLLRSLJ(Func<FDCMNUSABYN, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x96A4450", Offset = "0x96A3850", VA = "0x1896A4450")]
		private void MHFFGLLRSLJ(ZFRUMZRKAVG a, Func<FDCMNUSABYN, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x96A4580", Offset = "0x96A3980", VA = "0x1896A4580", Slot = "11")]
		public void MTIOOOBNEUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x96A5260", Offset = "0x96A4660", VA = "0x1896A5260", Slot = "8")]
		public bool OIYPEPDSECA(FDCMNUSABYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x96A45A0", Offset = "0x96A39A0", VA = "0x1896A45A0")]
		private bool NGAJJLKBVDD(FDCMNUSABYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x96A3930", Offset = "0x96A2D30", VA = "0x1896A3930")]
		private static bool BPCZUDNJOGX(FDCMNUSABYN a, ZFRUMZRKAVG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x96A3F80", Offset = "0x96A3380", VA = "0x1896A3F80")]
		private void KCOHINLOYEH(Transform a, ZFRUMZRKAVG b, ZFRUMZRKAVG[] c, FDCMNUSABYN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x96A5860", Offset = "0x96A4C60", VA = "0x1896A5860")]
		private ConnectableLink VNUQLCFJMCG(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x96A5580", Offset = "0x96A4980", VA = "0x1896A5580")]
		private static bool UOIKTFJDGHP(ZFRUMZRKAVG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x96A3BC0", Offset = "0x96A2FC0", VA = "0x1896A3BC0", Slot = "9")]
		public bool DFESIAYKUSE(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x96A3C20", Offset = "0x96A3020", VA = "0x1896A3C20")]
		private bool HMSBIRMRKMF(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x96A6360", Offset = "0x96A5760", VA = "0x1896A6360")]
		private static void ZYWVSHRJEFW(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e, ZFRUMZRKAVG f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x96A5A80", Offset = "0x96A4E80", VA = "0x1896A5A80")]
		private void YAJAYZVZQJP(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x96A5C10", Offset = "0x96A5010", VA = "0x1896A5C10")]
		private void YDNALINJGDD(ZFRUMZRKAVG a, FDCMNUSABYN b, FDCMNUSABYN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x96A5BA0", Offset = "0x96A4FA0", VA = "0x1896A5BA0")]
		private void YDNALINJGDD(FDCMNUSABYN a, FDCMNUSABYN b, FDCMNUSABYN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x96A37C0", Offset = "0x96A2BC0", VA = "0x1896A37C0")]
		private void BAIRYGHPUHM(FDCMNUSABYN a, FDCMNUSABYN b, FDCMNUSABYN c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x96A3830", Offset = "0x96A2C30", VA = "0x1896A3830")]
		private void BAIRYGHPUHM(ZFRUMZRKAVG a, FDCMNUSABYN b, FDCMNUSABYN c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x96A5740", Offset = "0x96A4B40", VA = "0x1896A5740")]
		private void VKHFVFHVYOL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x96A5270", Offset = "0x96A4670", VA = "0x1896A5270")]
		private void PGTPBQEBTYV(URJEDQCFQTZ a, URJEDQCFQTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x96A5410", Offset = "0x96A4810", VA = "0x1896A5410", Slot = "18")]
		public FDCMNUSABYN QYWRKVPDOGQ(FDCMNUSABYN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x96A3430", Offset = "0x96A2830", VA = "0x1896A3430", Slot = "13")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x96A64E0", Offset = "0x96A58E0", VA = "0x1896A64E0", Slot = "14")]
		public List<FDCMNUSABYN> ZZDJDECBJRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x96A59B0", Offset = "0x96A4DB0", VA = "0x1896A59B0")]
		protected URJEDQCFQTZ XRFFELRAYTK(URJEDQCFQTZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x96A4370", Offset = "0x96A3770", VA = "0x1896A4370")]
		protected ZFRUMZRKAVG[] KNOYRVQXPSN(ZFRUMZRKAVG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x96A39E0", Offset = "0x96A2DE0", VA = "0x1896A39E0")]
		protected bool BWCAQAQURTO(FDCMNUSABYN a, [Out] ZFRUMZRKAVG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x96A5C80", Offset = "0x96A5080", VA = "0x1896A5C80", Slot = "15")]
		public bool ZSADQFLWFNO(FDCMNUSABYN a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x96A53D0", Offset = "0x96A47D0", VA = "0x1896A53D0")]
		protected ZFRUMZRKAVG PTENSVNWRLX(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x96A3E70", Offset = "0x96A3270", VA = "0x1896A3E70", Slot = "10")]
		public bool HXODDCMVMPC(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x96A5DB0", Offset = "0x96A51B0", VA = "0x1896A5DB0")]
		private bool ZSZMYDJOYZZ(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x96A3AF0", Offset = "0x96A2EF0", VA = "0x1896A3AF0")]
		private static bool BWEJAVNQGFT(ZFRUMZRKAVG a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x96A5570", Offset = "0x96A4970", VA = "0x1896A5570", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD41880", Offset = "0xD40C80", VA = "0x180D41880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD41540", Offset = "0xD40940", VA = "0x180D41540")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x135AD40", Offset = "0x135A140", VA = "0x18135AD40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x28647D0", Offset = "0x2863BD0", VA = "0x1828647D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool XSGSHESZJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> YMUCOGQZUNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x96A8410", Offset = "0x96A7810", VA = "0x1896A8410", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x96A7CF0", Offset = "0x96A70F0", VA = "0x1896A7CF0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN> HTQBWPGTDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x96A6C90", Offset = "0x96A6090", VA = "0x1896A6C90", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x96A8330", Offset = "0x96A7730", VA = "0x1896A8330", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<FDCMNUSABYN, FDCMNUSABYN, FDCMNUSABYN> QYHXDOBZVBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x96A6F50", Offset = "0x96A6350", VA = "0x1896A6F50", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x96A7E90", Offset = "0x96A7290", VA = "0x1896A7E90", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x96A8650", Offset = "0x96A7A50", VA = "0x1896A8650")]
		public LegacyConnectableManager(TFZCSWYZDKY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x96A7500", Offset = "0x96A6900", VA = "0x1896A7500", Slot = "12")]
		public void Initialize(GameObject gameObject, JVVGTLYPYDF configData, JQNWKRJJETK rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x96A8470", Offset = "0x96A7870", VA = "0x1896A8470", Slot = "26")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x96A8390", Offset = "0x96A7790", VA = "0x1896A8390", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x96A74E0", Offset = "0x96A68E0", VA = "0x1896A74E0", Slot = "14")]
		public void GZVUEGYMGMP(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x96A6C30", Offset = "0x96A6030", VA = "0x1896A6C30", Slot = "15")]
		public void BAEWWTPIDYE(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x96A7AC0", Offset = "0x96A6EC0", VA = "0x1896A7AC0", Slot = "22")]
		public bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x96A8540", Offset = "0x96A7940", VA = "0x1896A8540")]
		internal bool ZSZMYDJOYZZ([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x96A7180", Offset = "0x96A6580", VA = "0x1896A7180")]
		internal bool DWPFQNKAEHP([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x96A7B10", Offset = "0x96A6F10", VA = "0x1896A7B10")]
		internal void KGGYXYMWCMJ(FDCMNUSABYN a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x96A6C30", Offset = "0x96A6030", VA = "0x1896A6C30")]
		internal bool CYCPAGWSEJT(FDCMNUSABYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x96A7D50", Offset = "0x96A7150", VA = "0x1896A7D50")]
		internal bool MPCOKEACXRF(FDCMNUSABYN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x96A6B30", Offset = "0x96A5F30", VA = "0x1896A6B30", Slot = "16")]
		public void ANCPTMZERYX(FDCMNUSABYN a, HashSet<FDCMNUSABYN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x96A7EF0", Offset = "0x96A72F0", VA = "0x1896A7EF0", Slot = "17")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x96A7040", Offset = "0x96A6440", VA = "0x1896A7040", Slot = "18")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x96A72D0", Offset = "0x96A66D0", VA = "0x1896A72D0", Slot = "19")]
		public void GYUSVGQTDMR(FDCMNUSABYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x96A6CF0", Offset = "0x96A60F0", VA = "0x1896A6CF0")]
		public void CSJKLFBIMDW([Optional] PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x96A6FB0", Offset = "0x96A63B0", VA = "0x1896A6FB0", Slot = "23")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x96A8100", Offset = "0x96A7500", VA = "0x1896A8100", Slot = "20")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x96A6990", Offset = "0x96A5D90", VA = "0x1896A6990", Slot = "21")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x96A74A0", Offset = "0x96A68A0", VA = "0x1896A74A0", Slot = "25")]
		public void GZEGFODBACO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x96A8280", Offset = "0x96A7680", VA = "0x1896A8280", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x96B0760", Offset = "0x96AFB60", VA = "0x1896B0760")]
		public QLNPJRUAWUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x96B06A0", Offset = "0x96AFAA0", VA = "0x1896B06A0")]
		public void JZCRFOHBGLO(FDCMNUSABYN a, FDCMNUSABYN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x96B0700", Offset = "0x96AFB00", VA = "0x1896B0700")]
		public void ZZHVQRWBOYC(FDCMNUSABYN a, FDCMNUSABYN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x96B0620", Offset = "0x96AFA20", VA = "0x1896B0620")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public WWOXATHPVZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x96B41F0", Offset = "0x96B35F0", VA = "0x1896B41F0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x96B41E0", Offset = "0x96B35E0", VA = "0x1896B41E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x96B4590", Offset = "0x96B3990", VA = "0x1896B4590")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x96B4520", Offset = "0x96B3920", VA = "0x1896B4520")]
		private void OnMasterClientSwitched(PPTCRKDFMWF newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x96B4420", Offset = "0x96B3820", VA = "0x1896B4420")]
		public void LUJXLZWMVPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x96B4320", Offset = "0x96B3720", VA = "0x1896B4320")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x96B4180", Offset = "0x96B3580", VA = "0x1896B4180")]
			internal LegacyConnectableManager VWBTPSTHWCJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x96A28F0", Offset = "0x96A1CF0", VA = "0x1896A28F0")]
		public static void TNIPUGRPWFD(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x96A2870", Offset = "0x96A1C70", VA = "0x1896A2870")]
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
		[Cpp2IlInjected.Address(RVA = "0x96A9640", Offset = "0x96A8A40", VA = "0x1896A9640")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x96A9120", Offset = "0x96A8520", VA = "0x1896A9120", Slot = "7")]
		public void Initialize(ULIGVRTJBSQ graph, BXTUVAXERBS creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x96A89E0", Offset = "0x96A7DE0", VA = "0x1896A89E0", Slot = "5")]
		public void EMMMPIYMHVT(URJEDQCFQTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x96A9320", Offset = "0x96A8720", VA = "0x1896A9320", Slot = "9")]
		public void LVCTZTHAZWU(URJEDQCFQTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x96A9160", Offset = "0x96A8560", VA = "0x1896A9160", Slot = "8")]
		public void KKDHCXZJRHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x96A8C20", Offset = "0x96A8020", VA = "0x1896A8C20", Slot = "10")]
		public void FKCOXZWOEDB(URJEDQCFQTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x96A9490", Offset = "0x96A8890", VA = "0x1896A9490", Slot = "11")]
		public void WFEGHQXKUTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x96A8F70", Offset = "0x96A8370", VA = "0x1896A8F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x96B30A0", Offset = "0x96B24A0", VA = "0x1896B30A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x96B37B0", Offset = "0x96B2BB0", VA = "0x1896B37B0")]
			public SerializeNodeInSubgraph(ZFRUMZRKAVG currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] XGIWHMXMAZG parentNodeData, [Optional] XGIWHMXMAZG rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x96B2F00", Offset = "0x96B2300", VA = "0x1896B2F00")]
			public XGIWHMXMAZG BGVSXQNQAUM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x96B31C0", Offset = "0x96B25C0", VA = "0x1896B31C0")]
			private XGIWHMXMAZG NTGVPBFMFSI([Out] XGIWHMXMAZG a, [Out] XGIWHMXMAZG b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x96B35B0", Offset = "0x96B29B0", VA = "0x1896B35B0")]
			private XGIWHMXMAZG WIHLQWBSERG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x96B3440", Offset = "0x96B2840", VA = "0x1896B3440")]
			private void UPNVFXQZECG(XGIWHMXMAZG a, XGIWHMXMAZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x96B3280", Offset = "0x96B2680", VA = "0x1896B3280")]
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
			[Cpp2IlInjected.Address(RVA = "0x96B13B0", Offset = "0x96B07B0", VA = "0x1896B13B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool ZMINPHKSNXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x96B1CB0", Offset = "0x96B10B0", VA = "0x1896B1CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x96B0EB0", Offset = "0x96B02B0", VA = "0x1896B0EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x96B1670", Offset = "0x96B0A70", VA = "0x1896B1670")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x96B1CD0", Offset = "0x96B10D0", VA = "0x1896B1CD0")]
		public ConnectableGraphData OZEULYDYBAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x96B0860", Offset = "0x96AFC60", VA = "0x1896B0860")]
		public ConnectableGraphData AFNGFFCIUUI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x96B0B90", Offset = "0x96AFF90", VA = "0x1896B0B90")]
		public void DJCOZTIVBYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x96B1E70", Offset = "0x96B1270", VA = "0x1896B1E70")]
		public void PWEZWQWXDQN(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x96B1E40", Offset = "0x96B1240", VA = "0x1896B1E40")]
		public void OZUSCMYORXR(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x96B2B20", Offset = "0x96B1F20", VA = "0x1896B2B20")]
		private void YHBDOWOWCYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x96B0ED0", Offset = "0x96B02D0", VA = "0x1896B0ED0")]
		private XGIWHMXMAZG EDHKPLSUPGS(ZFRUMZRKAVG a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x96B1420", Offset = "0x96B0820", VA = "0x1896B1420")]
		private static void IAMNCMRQEXS(ZFRUMZRKAVG a, bool b, XGIWHMXMAZG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x96B1190", Offset = "0x96B0590", VA = "0x1896B1190")]
		private void EKALYWUVZRB(ZFRUMZRKAVG a, bool b, XGIWHMXMAZG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x96B1100", Offset = "0x96B0500", VA = "0x1896B1100")]
		private XGIWHMXMAZG EGRLTYYAVOS(ZFRUMZRKAVG a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x96B0C20", Offset = "0x96B0020", VA = "0x1896B0C20")]
		private bool DNMRDQYFBCM(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x96B2080", Offset = "0x96B1480", VA = "0x1896B2080")]
		private bool TVLTVJGSWVX(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x96B1400", Offset = "0x96B0800", VA = "0x1896B1400")]
		private bool HUDXOSWSJOL(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x96B2A10", Offset = "0x96B1E10", VA = "0x1896B2A10")]
		private static bool YHAZTYPQKQC(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x96B16E0", Offset = "0x96B0AE0", VA = "0x1896B16E0")]
		public static bool JFVVBGZHWOW(XGIWHMXMAZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x96B1970", Offset = "0x96B0D70", VA = "0x1896B1970")]
		private FDCMNUSABYN NEXEUIUBAIA(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x96B1F10", Offset = "0x96B1310", VA = "0x1896B1F10")]
		private FDCMNUSABYN SOEQBKUCLMW(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x96B0A00", Offset = "0x96AFE00", VA = "0x1896B0A00")]
		private FDCMNUSABYN BFUDKZWENPD(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x96A99E0", Offset = "0x96A8DE0", VA = "0x1896A99E0")]
		private static Guid AIEZLMUBTVB(XGIWHMXMAZG a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x96B2920", Offset = "0x96B1D20", VA = "0x1896B2920")]
		private string VGYCTKPBJXE(XGIWHMXMAZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x96B2D00", Offset = "0x96B2100", VA = "0x1896B2D00")]
		private bool ZPRGGJKZCNL(ZFRUMZRKAVG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x96B26D0", Offset = "0x96B1AD0", VA = "0x1896B26D0")]
		private static void VFDYXJCLULT(ZFRUMZRKAVG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x96A1220", Offset = "0x96A0620", VA = "0x1896A1220")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink UBRDLXSMLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x96A12C0", Offset = "0x96A06C0", VA = "0x1896A12C0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x96A12F0", Offset = "0x96A06F0", VA = "0x1896A12F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public NIYGFYNSVMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x96A98A0", Offset = "0x96A8CA0", VA = "0x1896A98A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x514A360", Offset = "0x5149760", VA = "0x18514A360", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x96B4790", Offset = "0x96B3B90", VA = "0x1896B4790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ZFRUMZRKAVG SYLHKQLEBTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x96B4C00", Offset = "0x96B4000", VA = "0x1896B4C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public URJEDQCFQTZ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public FDCMNUSABYN RPGPSPXFJNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WSKYCLRQAIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x96B5210", Offset = "0x96B4610", VA = "0x1896B5210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool PBMRHYDWALA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x96B51C0", Offset = "0x96B45C0", VA = "0x1896B51C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected ZFRUMZRKAVG JBSQCTQPIEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x96B51A0", Offset = "0x96B45A0", VA = "0x1896B51A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x96B5220", Offset = "0x96B4620", VA = "0x1896B5220")]
		public ZFRUMZRKAVG(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x96B4CE0", Offset = "0x96B40E0", VA = "0x1896B4CE0")]
		public ZFRUMZRKAVG NKQFAMSGLEZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x96B4910", Offset = "0x96B3D10", VA = "0x1896B4910")]
		public ZFRUMZRKAVG FRNFEAUNBZT(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x96B4F10", Offset = "0x96B4310", VA = "0x1896B4F10")]
		public ZFRUMZRKAVG Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x96B47C0", Offset = "0x96B3BC0", VA = "0x1896B47C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x96B50F0", Offset = "0x96B44F0", VA = "0x1896B50F0")]
		public ZFRUMZRKAVG Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x96B4A90", Offset = "0x96B3E90", VA = "0x1896B4A90")]
		private static void KPLYORJBODW(ZFRUMZRKAVG a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x96B4BF0", Offset = "0x96B3FF0", VA = "0x1896B4BF0", Slot = "9")]
		public void KPLYORJBODW(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x96B4E20", Offset = "0x96B4220", VA = "0x1896B4E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x96A13F0", Offset = "0x96A07F0", VA = "0x1896A13F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x96A13B0", Offset = "0x96A07B0", VA = "0x1896A13B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x96A1360", Offset = "0x96A0760", VA = "0x1896A1360")]
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
			[Cpp2IlInjected.Address(RVA = "0x96A1AA0", Offset = "0x96A0EA0", VA = "0x1896A1AA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x96A1A60", Offset = "0x96A0E60", VA = "0x1896A1A60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView NSLMZWAUMSU
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x96A1690", Offset = "0x96A0A90", VA = "0x1896A1690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> KLJCMQTGKTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x96A18F0", Offset = "0x96A0CF0", VA = "0x1896A18F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x96A19D0", Offset = "0x96A0DD0", VA = "0x1896A19D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<PPTCRKDFMWF> SZGGPUJJABF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x96A2400", Offset = "0x96A1800", VA = "0x1896A2400", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x96A1730", Offset = "0x96A0B30", VA = "0x1896A1730", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x96A1C20", Offset = "0x96A1020", VA = "0x1896A1C20", Slot = "10")]
		public void ORLMZSMEYLO(LegacyConnectableManager a, JQNWKRJJETK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x96A1980", Offset = "0x96A0D80", VA = "0x1896A1980", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x96A1B00", Offset = "0x96A0F00", VA = "0x1896A1B00", Slot = "11")]
		public void OJQDSXEAQDZ(FDCMNUSABYN a, FDCMNUSABYN b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x96A17D0", Offset = "0x96A0BD0", VA = "0x1896A17D0", Slot = "12")]
		public void DSBRXLZNZVL(FDCMNUSABYN a, int b, FDCMNUSABYN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x96A24A0", Offset = "0x96A18A0", VA = "0x1896A24A0", Slot = "13")]
		public void VTDSXCWPILC(ConnectableGraphData a, [Optional] PPTCRKDFMWF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x96A1EE0", Offset = "0x96A12E0", VA = "0x1896A1EE0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(FDCMNUSABYN objectToReparent, int objectToReparentSlotIndex, FDCMNUSABYN newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x96A1CF0", Offset = "0x96A10F0", VA = "0x1896A1CF0")]
		[RPCMethod]
		private void RpcMasterModifyNode(FDCMNUSABYN connectableToModify, FDCMNUSABYN expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x96A22D0", Offset = "0x96A16D0", VA = "0x1896A22D0")]
		[RPCMethod]
		private void RpcReparentNodes(FDCMNUSABYN objectToReparent, int objectToReparentSlotIndex, FDCMNUSABYN newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x96A21E0", Offset = "0x96A15E0", VA = "0x1896A21E0")]
		[RPCMethod]
		private void RpcModifyNode(FDCMNUSABYN connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x96A1CB0", Offset = "0x96A10B0", VA = "0x1896A1CB0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x96A2EF0", Offset = "0x96A22F0", VA = "0x1896A2EF0", Slot = "4")]
		private void UEMRNKSYQPN(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x96A3070", Offset = "0x96A2470", VA = "0x1896A3070", Slot = "5")]
		private void XPQYTHGKYUX(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x96A32D0", Offset = "0x96A26D0", VA = "0x1896A32D0", Slot = "6")]
		private void YWPPBVSXZOU(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x96A2C30", Offset = "0x96A2030", VA = "0x1896A2C30", Slot = "7")]
		private void AQYKBLHDBPG(FDCMNUSABYN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x96A2E80", Offset = "0x96A2280", VA = "0x1896A2E80", Slot = "8")]
		private TRSXFQKGCQI SDEERIDVIHN(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x96A2E20", Offset = "0x96A2220", VA = "0x1896A2E20", Slot = "9")]
		private void FJNALQWWGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xCF4180", Offset = "0xCF3580", VA = "0x180CF4180")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class TNSMOVGWIRA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E140", Offset = "0x3F1D540", VA = "0x183F1E140")]
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
