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
		[Cpp2IlInjected.Address(RVA = "0x98AEDB0", Offset = "0x98AD7B0", VA = "0x1898AEDB0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		private int[] QBWAEFIMHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] QCBHBMCJQZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GKXUUHBMTQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset GKSNXAHPKEU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD14330", Offset = "0xD12D30", VA = "0x180D14330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2256010", Offset = "0x2254A10", VA = "0x182256010", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98BA400", Offset = "0x98B8E00", VA = "0x1898BA400")]
		private void QLHWPSDGGQL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98BA2B0", Offset = "0x98B8CB0", VA = "0x1898BA2B0")]
		private void QLCPSLJIXFC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98BA550", Offset = "0x98B8F50", VA = "0x1898BA550", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98BA860", Offset = "0x98B9260", VA = "0x1898BA860")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : NANHKTWOJXE, VGWOSQHBTSN
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ZUTXCLCUZTW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public MERFDKTLKAK XKSOFWUSXCI;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZUTXCLCUZTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x98BA000", Offset = "0x98B8A00", VA = "0x1898BA000")]
			internal object XPSTYEJZSUL(MERFDKTLKAK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class ZUZDZRWSJFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public MERFDKTLKAK HEGSYERNXPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ZUTXCLCUZTW YQELRQOBVLD;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZUZDZRWSJFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98BA070", Offset = "0x98B8A70", VA = "0x1898BA070")]
			internal object XPNNAXQCJJC((MERFDKTLKAK child, MERFDKTLKAK nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NNRMKMQOLGP : IEnumerable<PRMDPODZYPJ>, IEnumerable, IEnumerator<PRMDPODZYPJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private PRMDPODZYPJ AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId YHRESDDJDXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId VDBYQOOWHRD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private HGLSGDPNMGD GIMPBRPWRID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray HOERDVWIYGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator OOALUTIRPVE;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private PRMDPODZYPJ FVEGNIWDSLX
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00")]
			[DebuggerHidden]
			public NNRMKMQOLGP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x98AEFF0", Offset = "0x98AD9F0", VA = "0x1898AEFF0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x98AF0D0", Offset = "0x98ADAD0", VA = "0x1898AF0D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x98AF450", Offset = "0x98ADE50", VA = "0x1898AF450")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x98AF430", Offset = "0x98ADE30", VA = "0x1898AF430")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x98AF470", Offset = "0x98ADE70", VA = "0x1898AF470", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x98AEF40", Offset = "0x98AD940", VA = "0x1898AEF40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PRMDPODZYPJ> EQRWXNHQVMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x98AEF40", Offset = "0x98AD940", VA = "0x1898AEF40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log ICDRDNRCRSL;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log EEJRPMPCKOT;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log HIMLTHEKMIL;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log SPJBHHGSGWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private VISHFKXSWVQ IDTDMKHHIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private VPZOBIBRUKV HPHNRAKIMXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private JBWPPFUIGUI XRNIVCKJVRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private REEZIJGNIDQ UPGGCETSTNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private HELIEAOPKLU XIHIQPGCRYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FPZNZAZPOHQ KNHPSTCCXBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IIPQBMUUUNB MLCEUHKPZQQ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool WJCYHWPRZIP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD14AB0", Offset = "0xD134B0", VA = "0x180D14AB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD142D0", Offset = "0xD12CD0", VA = "0x180D142D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool TNBNJETZKYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x98B0640", Offset = "0x98AF040", VA = "0x1898B0640", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x98B1200", Offset = "0x98AFC00", VA = "0x1898B1200", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98AF9B0", Offset = "0x98AE3B0", VA = "0x1898AF9B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98AF820", Offset = "0x98AE220", VA = "0x1898AF820", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x98B1760", Offset = "0x98B0160", VA = "0x1898B1760", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x98AFF10", Offset = "0x98AE910", VA = "0x1898AFF10", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x98B3FA0", Offset = "0x98B29A0", VA = "0x1898B3FA0")]
		public OMConnectableManager(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98B0320", Offset = "0x98AED20", VA = "0x1898B0320", Slot = "12")]
		public void Initialize(GameObject gameObject, FYZXZUHVIVL configData, MBDTJJXIPKK sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98B2450", Offset = "0x98B0E50", VA = "0x1898B2450", Slot = "26")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98B3720", Offset = "0x98B2120", VA = "0x1898B3720", Slot = "22")]
		public bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98B39E0", Offset = "0x98B23E0", VA = "0x1898B39E0")]
		private void XGKITLXHOUR(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98AF600", Offset = "0x98AE000", VA = "0x1898AF600")]
		private void BJDGRQHROUX(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98B3BF0", Offset = "0x98B25F0", VA = "0x1898B3BF0")]
		private void YOBVMQYYKKR(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98B0D00", Offset = "0x98AF700", VA = "0x1898B0D00")]
		private void LZPIJOOKDKO(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98B2130", Offset = "0x98B0B30", VA = "0x1898B2130", Slot = "14")]
		public void QCIVJGOFOSZ(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "15")]
		public void JLFJVASZUFA(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98B3480", Offset = "0x98B1E80", VA = "0x1898B3480", Slot = "17")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98B35E0", Offset = "0x98B1FE0", VA = "0x1898B35E0")]
		public void UYLXRTJCTGR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98B1170", Offset = "0x98AFB70", VA = "0x1898B1170")]
		public void MBXKBQLQBUH(PRMDPODZYPJ a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98B0880", Offset = "0x98AF280", VA = "0x1898B0880", Slot = "18")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98B0590", Offset = "0x98AEF90", VA = "0x1898B0590")]
		private float JBGXIISQBLL(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98B09E0", Offset = "0x98AF3E0", VA = "0x1898B09E0")]
		public void LCBOFLKLKKD(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98B0B90", Offset = "0x98AF590", VA = "0x1898B0B90", Slot = "19")]
		public void LKGBKCTCCGH(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98B1F20", Offset = "0x98B0920", VA = "0x1898B1F20", Slot = "16")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "20")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "21")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98B0B20", Offset = "0x98AF520", VA = "0x1898B0B20", Slot = "23")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98AF940", Offset = "0x98AE340", VA = "0x1898AF940", Slot = "24")]
		public void EOGDHVZDGCT(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98B2430", Offset = "0x98B0E30", VA = "0x1898B2430", Slot = "25")]
		public void QUTUUOQJBMY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98B2EF0", Offset = "0x98B18F0", VA = "0x1898B2EF0")]
		private void TEBJDGFBFPR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98B2620", Offset = "0x98B1020", VA = "0x1898B2620")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98AF8D0", Offset = "0x98AE2D0", VA = "0x1898AF8D0")]
		private void DGTGTUZGWQY(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98B0290", Offset = "0x98AEC90", VA = "0x1898B0290")]
		[IteratorStateMachine(typeof(NNRMKMQOLGP))]
		public IEnumerable<PRMDPODZYPJ> HVRFFJSJNHL(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98B12B0", Offset = "0x98AFCB0", VA = "0x1898B12B0")]
		internal PRMDPODZYPJ MLIZUSEXGWO(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98B32F0", Offset = "0x98B1CF0", VA = "0x1898B32F0")]
		internal ObjectLocalId UNMVSDJRIPY(PRMDPODZYPJ a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98B19A0", Offset = "0x98B03A0", VA = "0x1898B19A0")]
		private bool PEQGOGWRTLJ(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98AFAA0", Offset = "0x98AE4A0", VA = "0x1898AFAA0")]
		private bool FDAFBPAIZZR(MERFDKTLKAK a, [Out] PRMDPODZYPJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98B13E0", Offset = "0x98AFDE0", VA = "0x1898B13E0")]
		private PRMDPODZYPJ MLIZUSEXGWO(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98B3860", Offset = "0x98B2260", VA = "0x1898B3860")]
		private PRMDPODZYPJ XFWOBSUEUJV(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98B00D0", Offset = "0x98AEAD0", VA = "0x1898B00D0")]
		private PRMDPODZYPJ GFRREJCREGY(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98AFA60", Offset = "0x98AE460", VA = "0x1898AFA60")]
		private static Guid FBNEAAKWYYB(MERFDKTLKAK a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98B3770", Offset = "0x98B2170", VA = "0x1898B3770")]
		private string WRHBIXVFEWQ(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98B06F0", Offset = "0x98AF0F0", VA = "0x1898B06F0")]
		private void KGKIBTFBHIX(PRMDPODZYPJ a, PRMDPODZYPJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98AFB00", Offset = "0x98AE500", VA = "0x1898AFB00")]
		private void FHVLHXFNPTT(PRMDPODZYPJ a, PRMDPODZYPJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98B1110", Offset = "0x98AFB10", VA = "0x1898B1110")]
		private void MBWSAWFKXLR(PRMDPODZYPJ a, PRMDPODZYPJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x98B1810", Offset = "0x98B0210", VA = "0x1898B1810")]
		private void PEPWTGEKQKK(PRMDPODZYPJ a, PRMDPODZYPJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98AFFC0", Offset = "0x98AE9C0", VA = "0x1898AFFC0")]
		private void GESUQTNLFPZ(ObjectLocalId a, PRMDPODZYPJ b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98AFC90", Offset = "0x98AE690", VA = "0x1898AFC90")]
		private void FLXVBBEPVAI(ObjectLocalId a, PRMDPODZYPJ b, PRMDPODZYPJ c, PRMDPODZYPJ d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ISZYMGWZZQR
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JLJLQVTDNTM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KLUMUBWDFVY container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x98A7EB0", Offset = "0x98A68B0", VA = "0x1898A7EB0")]
			internal OMConnectableManager ZJCYWNENSVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98A7CF0", Offset = "0x98A66F0", VA = "0x1898A7CF0")]
		public static void EWAMEUPAFYD(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98A7E60", Offset = "0x98A6860", VA = "0x1898A7E60")]
		public static void UCAQREXWQYA(KLUMUBWDFVY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : WFMOOXADJAH, UIUQZANUYNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager UXUZSRBCRLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly XLRLGIWMKRP MDWNQCQCPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly ZPKMYMCROID UPGGCETSTNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly VZSKLKVDAHJ[] QGEDYWQZTST;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD14330", Offset = "0xD12D30", VA = "0x180D14330", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PRMDPODZYPJ ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x98B5BA0", Offset = "0x98B45A0", VA = "0x1898B5BA0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PRMDPODZYPJ WNUIGSLTVVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x98B5550", Offset = "0x98B3F50", VA = "0x1898B5550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 HQULZJCFLDI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x98B4040", Offset = "0x98B2A40", VA = "0x1898B4040", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion LDYUXZFQLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x98B47C0", Offset = "0x98B31C0", VA = "0x1898B47C0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool YHONTLMRTBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x98B58D0", Offset = "0x98B42D0", VA = "0x1898B58D0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<PRMDPODZYPJ> OGVDPLCZWZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x98B5610", Offset = "0x98B4010", VA = "0x1898B5610", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool DXQRHNXGJHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDAEE30", Offset = "0xDAD830", VA = "0x180DAEE30", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE9FD20", Offset = "0xE9E720", VA = "0x180E9FD20", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98B5DA0", Offset = "0x98B47A0", VA = "0x1898B5DA0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x98B5AC0", Offset = "0x98B44C0", VA = "0x1898B5AC0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x98B5AE0", Offset = "0x98B44E0", VA = "0x1898B5AE0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x98B5C00", Offset = "0x98B4600", VA = "0x1898B5C00", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x98B5CE0", Offset = "0x98B46E0", VA = "0x1898B5CE0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool CYLTCGKDFUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x98B5000", Offset = "0x98B3A00", VA = "0x1898B5000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler NGRHUGNRDIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x98B4770", Offset = "0x98B3170", VA = "0x1898B4770", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x98B5690", Offset = "0x98B4090", VA = "0x1898B5690", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler AYSIQTLKOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x98B5640", Offset = "0x98B4040", VA = "0x1898B5640", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x98B54B0", Offset = "0x98B3EB0", VA = "0x1898B54B0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler OUWMLKJEVVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x98B4450", Offset = "0x98B2E50", VA = "0x1898B4450", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x98B53C0", Offset = "0x98B3DC0", VA = "0x1898B53C0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler RDFZKJIEMYI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x98B5410", Offset = "0x98B3E10", VA = "0x1898B5410", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x98B5050", Offset = "0x98B3A50", VA = "0x1898B5050", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x98B59C0", Offset = "0x98B43C0", VA = "0x1898B59C0")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, XLRLGIWMKRP connectableTool, VZSKLKVDAHJ[] connectionPoints, ZPKMYMCROID callbacks, NANHKTWOJXE connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x98B4010", Offset = "0x98B2A10", VA = "0x1898B4010", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "21")]
		public void YATEBHWKNQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x98B48F0", Offset = "0x98B32F0", VA = "0x1898B48F0", Slot = "22")]
		public void NXAAPQFELCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98B5320", Offset = "0x98B3D20", VA = "0x1898B5320", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98B50F0", Offset = "0x98B3AF0", VA = "0x1898B50F0", Slot = "25")]
		public void RWAGQXFTONY(int a, PRMDPODZYPJ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98B4820", Offset = "0x98B3220", VA = "0x1898B4820", Slot = "26")]
		public void LAEJMKRNPTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98B4D20", Offset = "0x98B3720", VA = "0x1898B4D20", Slot = "27")]
		public void PRJJKIRYPUM(int a, PRMDPODZYPJ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98B44A0", Offset = "0x98B2EA0", VA = "0x1898B44A0", Slot = "28")]
		public void FGFJBUXBGIK(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98B4910", Offset = "0x98B3310", VA = "0x1898B4910", Slot = "31")]
		public void OOLCSEHEGPB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98B40A0", Offset = "0x98B2AA0", VA = "0x1898B40A0", Slot = "29")]
		public void CBTCLGUIEAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98B56E0", Offset = "0x98B40E0", VA = "0x1898B56E0", Slot = "30")]
		public void YLLQKJPPZPA(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x98B46A0", Offset = "0x98B30A0", VA = "0x1898B46A0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98B4570", Offset = "0x98B2F70", VA = "0x1898B4570", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD72070", Offset = "0xD70A70", VA = "0x180D72070", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98B43B0", Offset = "0x98B2DB0", VA = "0x1898B43B0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, PRMDPODZYPJ otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "44")]
		public void ParentChanged(int slotIndex, PRMDPODZYPJ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "45")]
		public void ChildAdded(int slotIndex, PRMDPODZYPJ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "46")]
		public void ChildRemoved(int slotIndex, PRMDPODZYPJ removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "47")]
		public void ConnectionModified(int slotIndex, PRMDPODZYPJ parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98B5300", Offset = "0x98B3D00", VA = "0x1898B5300", Slot = "48")]
		public void RootChanged(PRMDPODZYPJ previousRootConnectable, PRMDPODZYPJ newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x98B5370", Offset = "0x98B3D70", VA = "0x1898B5370", Slot = "23")]
		public void TEOESWTDIWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98B5500", Offset = "0x98B3F00", VA = "0x1898B5500", Slot = "24")]
		public void WMNEXMDXLHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98B4520", Offset = "0x98B2F20", VA = "0x1898B4520")]
		private void FPEEAVMOSUF(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(KXHORJIXWCW), new string[] { })]
	public class OAUGTURJLIL : KXHORJIXWCW, DWYARZFXYRJ, MJCONUSWWSL
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ZBRDALKAYGO
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZBRDALKAYGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private BKJOHHCXOLU MSCWXNUUOPT;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object DJVDQVBYTUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x98AF500", Offset = "0x98ADF00", VA = "0x1898AF500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98AF4B0", Offset = "0x98ADEB0", VA = "0x1898AF4B0", Slot = "5")]
		private void EZUYJSDOFYP(GZOGVDISCYD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF6E1F0", Offset = "0xF6CBF0", VA = "0x180F6E1F0", Slot = "6")]
		private void YIQUJNZVLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public OAUGTURJLIL()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(NANHKTWOJXE), new string[] { "Ignore", "Mock" })]
	public class BUPEGVQLRRB : NANHKTWOJXE, VGWOSQHBTSN
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool WJCYHWPRZIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool TNBNJETZKYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x98A6130", Offset = "0x98A4B30", VA = "0x1898A6130", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x98A61E0", Offset = "0x98A4BE0", VA = "0x1898A61E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x98A5FD0", Offset = "0x98A49D0", VA = "0x1898A5FD0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x98A5F20", Offset = "0x98A4920", VA = "0x1898A5F20", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x98A6290", Offset = "0x98A4C90", VA = "0x1898A6290", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x98A6080", Offset = "0x98A4A80", VA = "0x1898A6080", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "26")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "12")]
		public void Initialize(GameObject gameObject, FYZXZUHVIVL configData, MBDTJJXIPKK rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "14")]
		public void QCIVJGOFOSZ(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "15")]
		public void JLFJVASZUFA(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "16")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "17")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "18")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "19")]
		public void LKGBKCTCCGH(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "20")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "21")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90", Slot = "22")]
		public bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "23")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "24")]
		public void EOGDHVZDGCT(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "25")]
		public void QUTUUOQJBMY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public BUPEGVQLRRB()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PRMDPODZYPJ : UIUQZANUYNI, IEquatable<PRMDPODZYPJ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface UIUQZANUYNI
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		PRMDPODZYPJ ParentConnectable
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
		bool CanConnectTo(int slotIndex, PRMDPODZYPJ otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, PRMDPODZYPJ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, PRMDPODZYPJ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, PRMDPODZYPJ removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, PRMDPODZYPJ parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(PRMDPODZYPJ previousRootConnectable, PRMDPODZYPJ newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NANHKTWOJXE : VGWOSQHBTSN
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool WJCYHWPRZIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool TNBNJETZKYL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, FYZXZUHVIVL configData, MBDTJJXIPKK rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QCIVJGOFOSZ(PRMDPODZYPJ a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void JLFJVASZUFA(PRMDPODZYPJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void LKGBKCTCCGH(PRMDPODZYPJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData VROMMHYETCS(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool VWALBJYTFDS(MERFDKTLKAK a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void LGIEHBRUTYL(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void EOGDHVZDGCT(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void QUTUUOQJBMY(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface REEZIJGNIDQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PRMDPODZYPJ GFRREJCREGY(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PRMDPODZYPJ XFWOBSUEUJV(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZNICMHPHJKP(PRMDPODZYPJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool GHRGVXLWWCV();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WRZVMAITNPY(PRMDPODZYPJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZPKMYMCROID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CYLTCGKDFUN(XLRLGIWMKRP a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HBRZAQTLOMQ(XLRLGIWMKRP a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string IXYNJJGGBAP(XLRLGIWMKRP a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid YWSGJSNUMBY(XLRLGIWMKRP a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int ZRDDIVYJYUT(XLRLGIWMKRP a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OAXIXPHVMYO(XLRLGIWMKRP a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(PRMDPODZYPJ childConnectable, int childConnectableSlot, PRMDPODZYPJ parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(PRMDPODZYPJ previousRootConnectable, PRMDPODZYPJ newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface XLRLGIWMKRP : PRMDPODZYPJ, UIUQZANUYNI, IEquatable<PRMDPODZYPJ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface WFMOOXADJAH : UIUQZANUYNI
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		PRMDPODZYPJ WNUIGSLTVVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<PRMDPODZYPJ> OGVDPLCZWZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 HQULZJCFLDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion LDYUXZFQLAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool YHONTLMRTBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool DXQRHNXGJHW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler NGRHUGNRDIU;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler AYSIQTLKOPE;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler OUWMLKJEVVL;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler RDFZKJIEMYI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YATEBHWKNQO();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void NXAAPQFELCX();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void TEOESWTDIWI();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void WMNEXMDXLHZ();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void RWAGQXFTONY(int a, PRMDPODZYPJ b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void LAEJMKRNPTM();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void PRJJKIRYPUM(int a, PRMDPODZYPJ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void FGFJBUXBGIK(PRMDPODZYPJ a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void CBTCLGUIEAR();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void YLLQKJPPZPA(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void OOLCSEHEGPB(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface VZSKLKVDAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 VFPDNVGISZQ
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
	public interface FYZXZUHVIVL
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool WQAICKDHHOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		MSFLIDTCQZE DNATBRWDQKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, FYZXZUHVIVL
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
		public bool WQAICKDHHOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xEA8300", Offset = "0xEA6D00", VA = "0x180EA8300", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public MSFLIDTCQZE DNATBRWDQKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x98A7270", Offset = "0x98A5C70", VA = "0x1898A7270")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x98A7330", Offset = "0x98A5D30", VA = "0x1898A7330")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PRMDPODZYPJ connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x98A7900", Offset = "0x98A6300", VA = "0x1898A7900")]
		public ConnectableLink(PRMDPODZYPJ connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x98A7860", Offset = "0x98A6260", VA = "0x1898A7860")]
		public ConnectableLink(PRMDPODZYPJ connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x98A77E0", Offset = "0x98A61E0", VA = "0x1898A77E0")]
		public ConnectableLink(PRMDPODZYPJ connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x98A7380", Offset = "0x98A5D80", VA = "0x1898A7380", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x98A7430", Offset = "0x98A5E30", VA = "0x1898A7430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : VMIELKXWDTA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform MOIDUDMLUHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private MSFLIDTCQZE ZMLNBEEEASW;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x91DCC60", Offset = "0x91DB660", VA = "0x1891DCC60", Slot = "4")]
		public void Initialize(Transform transform, MSFLIDTCQZE linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x98A81F0", Offset = "0x98A6BF0", VA = "0x1898A81F0", Slot = "5")]
		public MSFLIDTCQZE GMARJUZRGME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x98A82B0", Offset = "0x98A6CB0", VA = "0x1898A82B0", Slot = "6")]
		public void IIGQBENBMDE(MSFLIDTCQZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, AOVJYPZOHCS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FOYCDAWRFGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public PRMDPODZYPJ TAEUWDVQKXX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public PRMDPODZYPJ AZKWVZLVKTO;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public FOYCDAWRFGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x98A7AA0", Offset = "0x98A64A0", VA = "0x1898A7AA0")]
			internal bool VLDLFGLXJYG(CPBXSJSKLEB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly TRYVDYQYBIG GQLFXHFDAMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private VAEKGHJIDHD IHWSSULLHSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LSNECTQGMUH QAIRITZQFZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool GBWHNGITFDZ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log BALMGYZHMTT;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public CPBXSJSKLEB LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x98A9B00", Offset = "0x98A8500", VA = "0x1898A9B00")]
		public bool HUSHFQALGFN([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x98A8B20", Offset = "0x98A7520", VA = "0x1898A8B20")]
		private bool ABVWBGTTJMK([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x98ABEB0", Offset = "0x98AA8B0", VA = "0x1898ABEB0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x98A9B70", Offset = "0x98A8570", VA = "0x1898A9B70", Slot = "5")]
		public void Initialize(NANHKTWOJXE manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x98A9790", Offset = "0x98A8190", VA = "0x1898A9790", Slot = "17")]
		public void FLXAHZZZSTA(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x98AA5B0", Offset = "0x98A8FB0", VA = "0x1898AA5B0", Slot = "12")]
		public void NNYJMBXIQFH(Func<PRMDPODZYPJ, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x98AA480", Offset = "0x98A8E80", VA = "0x1898AA480")]
		private void NNYJMBXIQFH(TRYVDYQYBIG a, Func<PRMDPODZYPJ, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x98A9AE0", Offset = "0x98A84E0", VA = "0x1898A9AE0", Slot = "11")]
		public void HNRRBFPAQNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x98AB940", Offset = "0x98AA340", VA = "0x1898AB940", Slot = "8")]
		public bool WLVQCTXQGOW(PRMDPODZYPJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x98AAC00", Offset = "0x98A9600", VA = "0x1898AAC00")]
		private bool SBUZXWIWHAX(PRMDPODZYPJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98AB950", Offset = "0x98AA350", VA = "0x1898AB950")]
		private static bool YTAIWTPKMAZ(PRMDPODZYPJ a, TRYVDYQYBIG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x98ABA00", Offset = "0x98AA400", VA = "0x1898ABA00")]
		private void ZERFFIZRRMB(Transform a, TRYVDYQYBIG b, TRYVDYQYBIG[] c, PRMDPODZYPJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x98AB610", Offset = "0x98AA010", VA = "0x1898AB610")]
		private ConnectableLink UHOUSWUAPYQ(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98A9E70", Offset = "0x98A8870", VA = "0x1898A9E70")]
		private static bool KGPUBQJEHIX(TRYVDYQYBIG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x98A9B10", Offset = "0x98A8510", VA = "0x1898A9B10", Slot = "9")]
		public bool IELLZXDPMTI(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x98AA230", Offset = "0x98A8C30", VA = "0x1898AA230")]
		private bool MTJEUQJDCMT(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x98AB7C0", Offset = "0x98AA1C0", VA = "0x1898AB7C0")]
		private static void VEEKPIMOTTA(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e, TRYVDYQYBIG f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x98A9D50", Offset = "0x98A8750", VA = "0x1898A9D50")]
		private void KGKIBTFBHIX(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x98A99A0", Offset = "0x98A83A0", VA = "0x1898A99A0")]
		private void FLXZEDAAQMD(TRYVDYQYBIG a, PRMDPODZYPJ b, PRMDPODZYPJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x98A9930", Offset = "0x98A8330", VA = "0x1898A9930")]
		private void FLXZEDAAQMD(PRMDPODZYPJ a, PRMDPODZYPJ b, PRMDPODZYPJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x98A98C0", Offset = "0x98A82C0", VA = "0x1898A98C0")]
		private void FLXVBBEPVAI(PRMDPODZYPJ a, PRMDPODZYPJ b, PRMDPODZYPJ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x98A97C0", Offset = "0x98A81C0", VA = "0x1898A97C0")]
		private void FLXVBBEPVAI(TRYVDYQYBIG a, PRMDPODZYPJ b, PRMDPODZYPJ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x98A9670", Offset = "0x98A8070", VA = "0x1898A9670")]
		private void FHVLHXFNPTT(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x98AA0D0", Offset = "0x98A8AD0", VA = "0x1898AA0D0")]
		private void MBWSAWFKXLR(CPBXSJSKLEB a, CPBXSJSKLEB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x98AA990", Offset = "0x98A9390", VA = "0x1898AA990", Slot = "18")]
		public PRMDPODZYPJ QKLPGAWJTQO(PRMDPODZYPJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x98AA600", Offset = "0x98A9000", VA = "0x1898AA600", Slot = "13")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x98AB3D0", Offset = "0x98A9DD0", VA = "0x1898AB3D0", Slot = "14")]
		public List<PRMDPODZYPJ> TUUFYVLNNCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x98A9A10", Offset = "0x98A8410", VA = "0x1898A9A10")]
		protected CPBXSJSKLEB GWLJEITQKFE(CPBXSJSKLEB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x98AA030", Offset = "0x98A8A30", VA = "0x1898AA030")]
		protected TRYVDYQYBIG[] KNERUTALYCX(TRYVDYQYBIG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x98AAAF0", Offset = "0x98A94F0", VA = "0x1898AAAF0")]
		protected bool QKOZEWIUHJY(PRMDPODZYPJ a, [Out] TRYVDYQYBIG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x98A9C20", Offset = "0x98A8620", VA = "0x1898A9C20", Slot = "15")]
		public bool KAOLTMOYZAW(PRMDPODZYPJ a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x98AA5C0", Offset = "0x98A8FC0", VA = "0x1898AA5C0")]
		protected TRYVDYQYBIG OALOCSNGWYP(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x98AB760", Offset = "0x98AA160", VA = "0x1898AB760", Slot = "10")]
		public bool URBLWLFLJIG(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x98A90D0", Offset = "0x98A7AD0", VA = "0x1898A90D0")]
		private bool BOWABRLNXVP(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x98AB300", Offset = "0x98A9D00", VA = "0x1898AB300")]
		private static bool SNZBGXRFNNV(TRYVDYQYBIG a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x98A9B00", Offset = "0x98A8500", VA = "0x1898A9B00", Slot = "7")]
		private bool JCWCROVFYHA([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : NANHKTWOJXE, VGWOSQHBTSN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly KLUMUBWDFVY container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly LSNECTQGMUH QAIRITZQFZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly WHPBAUPZHOM VPKOOQZOEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly PIKQXOXROUO QEMDAPBQRLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly AOVJYPZOHCS NROXDSFGWZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal MIFJRJNDEVZ UPGGCETSTNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal MYQOVWZNDGA VJTLLTIAEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal VAEKGHJIDHD WJVSRJWBYBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool GBWHNGITFDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool OQHOPWXSDCY;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GOMXVEFGBFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xD57650", Offset = "0xD56050", VA = "0x180D57650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD57170", Offset = "0xD55B70", VA = "0x180D57170")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool WJCYHWPRZIP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x13676F0", Offset = "0x13660F0", VA = "0x1813676F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x287F300", Offset = "0x287DD00", VA = "0x18287F300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool TNBNJETZKYL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x98ACD50", Offset = "0x98AB750", VA = "0x1898ACD50", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x98AD140", Offset = "0x98ABB40", VA = "0x1898AD140", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x98AC280", Offset = "0x98AAC80", VA = "0x1898AC280", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x98AC170", Offset = "0x98AAB70", VA = "0x1898AC170", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x98AD380", Offset = "0x98ABD80", VA = "0x1898AD380", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x98AC2E0", Offset = "0x98AACE0", VA = "0x1898AC2E0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x98ADCF0", Offset = "0x98AC6F0", VA = "0x1898ADCF0")]
		public LegacyConnectableManager(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x98AC730", Offset = "0x98AB130", VA = "0x1898AC730", Slot = "12")]
		public void Initialize(GameObject gameObject, FYZXZUHVIVL configData, MBDTJJXIPKK rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x98AD670", Offset = "0x98AC070", VA = "0x1898AD670", Slot = "26")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x98AD950", Offset = "0x98AC350", VA = "0x1898AD950", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x98AD4D0", Offset = "0x98ABED0", VA = "0x1898AD4D0", Slot = "14")]
		public void QCIVJGOFOSZ(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x98ACCF0", Offset = "0x98AB6F0", VA = "0x1898ACCF0", Slot = "15")]
		public void JLFJVASZUFA(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x98ADB50", Offset = "0x98AC550", VA = "0x1898ADB50", Slot = "22")]
		public bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x98AC060", Offset = "0x98AAA60", VA = "0x1898AC060")]
		internal bool BOWABRLNXVP([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x98ADBA0", Offset = "0x98AC5A0", VA = "0x1898ADBA0")]
		internal bool XGRFUEWZMRB([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x98AD1A0", Offset = "0x98ABBA0", VA = "0x1898AD1A0")]
		internal void MZRHRAEGKGD(PRMDPODZYPJ a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x98ACCF0", Offset = "0x98AB6F0", VA = "0x1898ACCF0")]
		internal bool UNHSIQAPRWL(PRMDPODZYPJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x98AD4F0", Offset = "0x98ABEF0", VA = "0x1898AD4F0")]
		internal bool QEHJJABPEVD(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x98AD3E0", Offset = "0x98ABDE0", VA = "0x1898AD3E0", Slot = "16")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x98AD740", Offset = "0x98AC140", VA = "0x1898AD740", Slot = "17")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x98ACDB0", Offset = "0x98AB7B0", VA = "0x1898ACDB0", Slot = "18")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x98ACF80", Offset = "0x98AB980", VA = "0x1898ACF80", Slot = "19")]
		public void LKGBKCTCCGH(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x98AC4E0", Offset = "0x98AAEE0", VA = "0x1898AC4E0")]
		public void IKSEBLHXTUK([Optional] JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x98ACEF0", Offset = "0x98AB8F0", VA = "0x1898ACEF0", Slot = "23")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x98AD9D0", Offset = "0x98AC3D0", VA = "0x1898AD9D0", Slot = "20")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x98AC340", Offset = "0x98AAD40", VA = "0x1898AC340", Slot = "21")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x98AD630", Offset = "0x98AC030", VA = "0x1898AD630", Slot = "25")]
		public void QUTUUOQJBMY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x98AC1D0", Offset = "0x98AABD0", VA = "0x1898AC1D0", Slot = "24")]
		public void EOGDHVZDGCT(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class LSNECTQGMUH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly DPMSWLVOVTK<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly DPMSWLVOVTK<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly DPRZTSPMFET<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x98A80F0", Offset = "0x98A6AF0", VA = "0x1898A80F0")]
		public LSNECTQGMUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x98A8030", Offset = "0x98A6A30", VA = "0x1898A8030")]
		public void LIKWRWYWZMC(PRMDPODZYPJ a, PRMDPODZYPJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x98A8090", Offset = "0x98A6A90", VA = "0x1898A8090")]
		public void OFNLGCZDPJS(PRMDPODZYPJ a, PRMDPODZYPJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x98A7FB0", Offset = "0x98A69B0", VA = "0x1898A7FB0")]
		public void EJNWWPGYMCQ(PRMDPODZYPJ a, PRMDPODZYPJ b, PRMDPODZYPJ c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WHPBAUPZHOM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager WOYAAPKNHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private MYQOVWZNDGA VJTLLTIAEEO;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public WHPBAUPZHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x98B9C20", Offset = "0x98B8620", VA = "0x1898B9C20")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x98B9C10", Offset = "0x98B8610", VA = "0x1898B9C10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98B9DC0", Offset = "0x98B87C0", VA = "0x1898B9DC0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x98B9D50", Offset = "0x98B8750", VA = "0x1898B9D50")]
		private void OnMasterClientSwitched(JNIVCIZIPSX newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x98B9F00", Offset = "0x98B8900", VA = "0x1898B9F00")]
		public void ZSPFJTWABNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x98B9E00", Offset = "0x98B8800", VA = "0x1898B9E00")]
		public void WPCVZFBQARZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class ABNYDJYEDKW
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class JLJLQVTDNTM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KLUMUBWDFVY container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x98A7F50", Offset = "0x98A6950", VA = "0x1898A7F50")]
			internal LegacyConnectableManager ZJCYWNENSVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x98A5CB0", Offset = "0x98A46B0", VA = "0x1898A5CB0")]
		public static void EWAMEUPAFYD(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x98A5EA0", Offset = "0x98A48A0", VA = "0x1898A5EA0")]
		public static void UCAQREXWQYA(KLUMUBWDFVY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, VAEKGHJIDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, MSFLIDTCQZE> EIZDSEYPNSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation KNOYQJFKYTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private VMIELKXWDTA HCZWBGQXOIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private AOVJYPZOHCS NROXDSFGWZW;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker CIREMGYDYKC;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x98AECE0", Offset = "0x98AD6E0", VA = "0x1898AECE0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x98AE3F0", Offset = "0x98ACDF0", VA = "0x1898AE3F0", Slot = "7")]
		public void Initialize(AOVJYPZOHCS graph, VMIELKXWDTA creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x98AE8F0", Offset = "0x98AD2F0", VA = "0x1898AE8F0", Slot = "5")]
		public void SYVEGQFGVFZ(CPBXSJSKLEB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x98AE780", Offset = "0x98AD180", VA = "0x1898AE780", Slot = "9")]
		public void PFPONXSHWCG(CPBXSJSKLEB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x98AE230", Offset = "0x98ACC30", VA = "0x1898AE230", Slot = "8")]
		public void EFNEESQGBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x98AE430", Offset = "0x98ACE30", VA = "0x1898AE430", Slot = "10")]
		public void KDWUMUFRBPP(CPBXSJSKLEB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x98AEB30", Offset = "0x98AD530", VA = "0x1898AEB30", Slot = "11")]
		public void VSEVZWOWCSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x98AE080", Offset = "0x98ACA80", VA = "0x1898AE080")]
		private bool DXPRRJBSUZS(CPBXSJSKLEB a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class PIKQXOXROUO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly TRYVDYQYBIG currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly MERFDKTLKAK parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly MERFDKTLKAK rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool UXFTCYAYVZX
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x98B87A0", Offset = "0x98B71A0", VA = "0x1898B87A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x98B8C50", Offset = "0x98B7650", VA = "0x1898B8C50")]
			public SerializeNodeInSubgraph(TRYVDYQYBIG currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] MERFDKTLKAK parentNodeData, [Optional] MERFDKTLKAK rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x98B88B0", Offset = "0x98B72B0", VA = "0x1898B88B0")]
			public MERFDKTLKAK XQIXCNAGDPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x98B8570", Offset = "0x98B6F70", VA = "0x1898B8570")]
			private MERFDKTLKAK FZGIGPIPKIW([Out] MERFDKTLKAK a, [Out] MERFDKTLKAK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x98B8A50", Offset = "0x98B7450", VA = "0x1898B8A50")]
			private MERFDKTLKAK XZZGYBHMWZA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x98B8630", Offset = "0x98B7030", VA = "0x1898B8630")]
			private void HFRLHWBLYNS(MERFDKTLKAK a, MERFDKTLKAK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x98B83B0", Offset = "0x98B6DB0", VA = "0x1898B83B0")]
			private void FNRBHXJGYZL(MERFDKTLKAK a, MERFDKTLKAK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager WOYAAPKNHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private AOVJYPZOHCS NROXDSFGWZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private VAEKGHJIDHD IHWSSULLHSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private MYQOVWZNDGA VJTLLTIAEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool XLPUJFJPZZO;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool ENVICQBEDZP
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x98B6A50", Offset = "0x98B5450", VA = "0x1898B6A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool GOMXVEFGBFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x98B5DC0", Offset = "0x98B47C0", VA = "0x1898B5DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x98B6580", Offset = "0x98B4F80", VA = "0x1898B6580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x98B69C0", Offset = "0x98B53C0", VA = "0x1898B69C0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x98B78F0", Offset = "0x98B62F0", VA = "0x1898B78F0")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x98B6710", Offset = "0x98B5110", VA = "0x1898B6710")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x98B6D50", Offset = "0x98B5750", VA = "0x1898B6D50")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x98B64E0", Offset = "0x98B4EE0", VA = "0x1898B64E0")]
		public void EOGDHVZDGCT(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x98B8310", Offset = "0x98B6D10", VA = "0x1898B8310")]
		public void ZIMDEDCFGNH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x98B5DE0", Offset = "0x98B47E0", VA = "0x1898B5DE0")]
		private void AOOYUUGZSYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x98B6400", Offset = "0x98B4E00", VA = "0x1898B6400")]
		private MERFDKTLKAK EKGGOTWLTWM(TRYVDYQYBIG a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x98B6AA0", Offset = "0x98B54A0", VA = "0x1898B6AA0")]
		private static void KIDAXUHXVNY(TRYVDYQYBIG a, bool b, MERFDKTLKAK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x98B8060", Offset = "0x98B6A60", VA = "0x1898B8060")]
		private void YBWOBCAKICZ(TRYVDYQYBIG a, bool b, MERFDKTLKAK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x98B8280", Offset = "0x98B6C80", VA = "0x1898B8280")]
		private MERFDKTLKAK YGJZTHLNCUQ(TRYVDYQYBIG a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x98B7DE0", Offset = "0x98B67E0", VA = "0x1898B7DE0")]
		private bool XNBCRAALSXU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x98B72A0", Offset = "0x98B5CA0", VA = "0x1898B72A0")]
		private bool PEQGOGWRTLJ(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x98B6A30", Offset = "0x98B5430", VA = "0x1898B6A30")]
		private bool JBTCWNCIGCB(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x98B68B0", Offset = "0x98B52B0", VA = "0x1898B68B0")]
		private static bool IOJZVSJDVQE(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x98B7A60", Offset = "0x98B6460", VA = "0x1898B7A60")]
		public static bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x98B6DE0", Offset = "0x98B57E0", VA = "0x1898B6DE0")]
		private PRMDPODZYPJ MLIZUSEXGWO(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x98B65A0", Offset = "0x98B4FA0", VA = "0x1898B65A0")]
		private PRMDPODZYPJ GFRREJCREGY(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x98B7110", Offset = "0x98B5B10", VA = "0x1898B7110")]
		private PRMDPODZYPJ NXVXICFDFKL(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x98AFA60", Offset = "0x98AE460", VA = "0x1898AFA60")]
		private static Guid FBNEAAKWYYB(MERFDKTLKAK a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x98B7CF0", Offset = "0x98B66F0", VA = "0x1898B7CF0")]
		private string WRHBIXVFEWQ(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x98B5FC0", Offset = "0x98B49C0", VA = "0x1898B5FC0")]
		private bool CPVHDYMWXOT(TRYVDYQYBIG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x98B61B0", Offset = "0x98B4BB0", VA = "0x1898B61B0")]
		private static void EBECMJQEESD(TRYVDYQYBIG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public PIKQXOXROUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PRMDPODZYPJ child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public PRMDPODZYPJ parent;

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
		public ConnectableLink IEARJPCJYIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x98A7960", Offset = "0x98A6360", VA = "0x1898A7960")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink JIRINOPRVMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x98A7A00", Offset = "0x98A6400", VA = "0x1898A7A00")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x98A7A30", Offset = "0x98A6430", VA = "0x1898A7A30")]
		public ConnectionOperationData(PRMDPODZYPJ child, PRMDPODZYPJ parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface AOVJYPZOHCS
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		CPBXSJSKLEB LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(NANHKTWOJXE manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HUSHFQALGFN([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WLVQCTXQGOW(PRMDPODZYPJ a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IELLZXDPMTI(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool URBLWLFLJIG(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HNRRBFPAQNL();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NNYJMBXIQFH(Func<PRMDPODZYPJ, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<PRMDPODZYPJ> TUUFYVLNNCN();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KAOLTMOYZAW(PRMDPODZYPJ a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void FLXAHZZZSTA(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(CPBXSJSKLEB node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface CPBXSJSKLEB
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		PRMDPODZYPJ ZEZFKHXLJLU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CPBXSJSKLEB JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink ZNGWKUTKPVW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool JFFYDATVOWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface MSFLIDTCQZE : MYRIDPBKETA.XOEXMPGHTTG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VQZGAVQPNPU(PRMDPODZYPJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLDHRHTUUBM(PRMDPODZYPJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DIOVSYXJSNJ(PRMDPODZYPJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GQZEQWSYCEB(PRMDPODZYPJ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MSFLIDTCQZE TNEXUDMGJJO(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface VMIELKXWDTA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, MSFLIDTCQZE linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MSFLIDTCQZE GMARJUZRGME();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IIGQBENBMDE(MSFLIDTCQZE a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface MIFJRJNDEVZ : REEZIJGNIDQ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OLQSGKKMDTH();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZRVLUFKLZDW(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface VAEKGHJIDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SYVEGQFGVFZ(CPBXSJSKLEB a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(AOVJYPZOHCS graph, VMIELKXWDTA linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EFNEESQGBJG();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PFPONXSHWCG(CPBXSJSKLEB a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KDWUMUFRBPP(CPBXSJSKLEB a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VSEVZWOWCSB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class TRYVDYQYBIG : CPBXSJSKLEB
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class VEGDJQDXTAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink KLCDJGGURFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public TRYVDYQYBIG KUEPXZWMNIQ;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public VEGDJQDXTAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x98B99F0", Offset = "0x98B83F0", VA = "0x1898B99F0")]
			internal bool AMCWFTESUUP(CPBXSJSKLEB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink LFNGFJZQWOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<TRYVDYQYBIG> JDMGHFSWVRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TRYVDYQYBIG ELFYQUBQONH;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink ZNGWKUTKPVW
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x51C2A80", Offset = "0x51C1480", VA = "0x1851C2A80", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x98B9490", Offset = "0x98B7E90", VA = "0x1898B9490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private TRYVDYQYBIG TSUTPHIUZAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x98B8E10", Offset = "0x98B7810", VA = "0x1898B8E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public CPBXSJSKLEB JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public PRMDPODZYPJ ZEZFKHXLJLU
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool JFFYDATVOWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x98B90D0", Offset = "0x98B7AD0", VA = "0x1898B90D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool HQLTJXLDZPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x98B9060", Offset = "0x98B7A60", VA = "0x1898B9060", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected TRYVDYQYBIG XBKNLMWAWOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x98B90B0", Offset = "0x98B7AB0", VA = "0x1898B90B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x98B9750", Offset = "0x98B8150", VA = "0x1898B9750")]
		public TRYVDYQYBIG(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x98B90E0", Offset = "0x98B7AE0", VA = "0x1898B90E0")]
		public TRYVDYQYBIG JTOEXZFXZXN(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x98B9310", Offset = "0x98B7D10", VA = "0x1898B9310")]
		public TRYVDYQYBIG QCBXIDURAQD(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x98B94C0", Offset = "0x98B7EC0", VA = "0x1898B94C0")]
		public TRYVDYQYBIG Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x98B8CC0", Offset = "0x98B76C0", VA = "0x1898B8CC0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x98B96A0", Offset = "0x98B80A0", VA = "0x1898B96A0")]
		public TRYVDYQYBIG Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x98B8EF0", Offset = "0x98B78F0", VA = "0x1898B8EF0")]
		private static void FLXAHZZZSTA(TRYVDYQYBIG a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x98B9050", Offset = "0x98B7A50", VA = "0x1898B9050", Slot = "9")]
		public void FLXAHZZZSTA(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x98B9220", Offset = "0x98B7C20", VA = "0x1898B9220")]
		public static TRYVDYQYBIG OALOCSNGWYP(TRYVDYQYBIG a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface MYQOVWZNDGA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool ENVICQBEDZP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> TLGJNCBUTJX;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<JNIVCIZIPSX> ABBOYDVOWWF;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VQZGAVQPNPU(LegacyConnectableManager a, MBDTJJXIPKK b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void JJYRCXLGICG(ConnectableGraphData a, [Optional] JNIVCIZIPSX b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class VQQROMWRWXQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x98B9B80", Offset = "0x98B8580", VA = "0x1898B9B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x98B9BD0", Offset = "0x98B85D0", VA = "0x1898B9BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x98B9B30", Offset = "0x98B8530", VA = "0x1898B9B30")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class CNRDUIEZDKN : MYQOVWZNDGA, IDisposable, JNPLRTCKGHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager WOYAAPKNHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private MBDTJJXIPKK CANAESWJSLE;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ENVICQBEDZP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x98A64B0", Offset = "0x98A4EB0", VA = "0x1898A64B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x98A6EC0", Offset = "0x98A58C0", VA = "0x1898A6EC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView NHIHHIWNUKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x98A6F90", Offset = "0x98A5990", VA = "0x1898A6F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> TLGJNCBUTJX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x98A71E0", Offset = "0x98A5BE0", VA = "0x1898A71E0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x98A6F00", Offset = "0x98A5900", VA = "0x1898A6F00", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JNIVCIZIPSX> ABBOYDVOWWF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x98A6E20", Offset = "0x98A5820", VA = "0x1898A6E20", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x98A6D80", Offset = "0x98A5780", VA = "0x1898A6D80", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x98A7150", Offset = "0x98A5B50", VA = "0x1898A7150", Slot = "10")]
		public void VQZGAVQPNPU(LegacyConnectableManager a, MBDTJJXIPKK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x98A6340", Offset = "0x98A4D40", VA = "0x1898A6340", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x98A7030", Offset = "0x98A5A30", VA = "0x1898A7030", Slot = "11")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x98A6510", Offset = "0x98A4F10", VA = "0x1898A6510", Slot = "12")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x98A6390", Offset = "0x98A4D90", VA = "0x1898A6390", Slot = "13")]
		public void JJYRCXLGICG(ConnectableGraphData a, [Optional] JNIVCIZIPSX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x98A6860", Offset = "0x98A5260", VA = "0x1898A6860")]
		[RPCMethod]
		private void RpcMasterReparentNodes(PRMDPODZYPJ objectToReparent, int objectToReparentSlotIndex, PRMDPODZYPJ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x98A6670", Offset = "0x98A5070", VA = "0x1898A6670")]
		[RPCMethod]
		private void RpcMasterModifyNode(PRMDPODZYPJ connectableToModify, PRMDPODZYPJ expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x98A6C50", Offset = "0x98A5650", VA = "0x1898A6C50")]
		[RPCMethod]
		private void RpcReparentNodes(PRMDPODZYPJ objectToReparent, int objectToReparentSlotIndex, PRMDPODZYPJ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x98A6B60", Offset = "0x98A5560", VA = "0x1898A6B60")]
		[RPCMethod]
		private void RpcModifyNode(PRMDPODZYPJ connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x98A6630", Offset = "0x98A5030", VA = "0x1898A6630")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public CNRDUIEZDKN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, MSFLIDTCQZE, MYRIDPBKETA.XOEXMPGHTTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x98A8320", Offset = "0x98A6D20", VA = "0x1898A8320", Slot = "4")]
		private void PCQCNGGRDVD(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x98A87F0", Offset = "0x98A71F0", VA = "0x1898A87F0", Slot = "5")]
		private void WZNAMDWABSV(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x98A8690", Offset = "0x98A7090", VA = "0x1898A8690", Slot = "6")]
		private void VJGXYFCLZAS(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x98A84A0", Offset = "0x98A6EA0", VA = "0x1898A84A0", Slot = "7")]
		private void QEYGBUYACXI(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x98A8AB0", Offset = "0x98A74B0", VA = "0x1898A8AB0", Slot = "8")]
		private MSFLIDTCQZE ZEKUWUEGSUV(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x98A8A50", Offset = "0x98A7450", VA = "0x1898A8A50", Slot = "9")]
		private void YAKNXVKJMXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4B0", Offset = "0xD08EB0", VA = "0x180D0A4B0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class LQMROSSUVRG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C19050", Offset = "0x3C17A50", VA = "0x183C19050")]
		public static FVTTLJABQTZ<a> KHTRPGKLNMK<a>(this KLUMUBWDFVY a)
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
